Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmSelecionaUsuario
    Dim conexao As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")
#Region "Formulario"

#Region "Única Instância"
    Private Shared _Instance As FrmSelecionaUsuario = Nothing
    Private Shared _NovaInstancia As Boolean = False

    Public Property NovaInstancia() As String
        Get
            Return _NovaInstancia
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Shared Function Instance() As FrmSelecionaUsuario
        If _Instance Is Nothing OrElse _Instance.IsDisposed = True Then
            _Instance = New FrmSelecionaUsuario
            _NovaInstancia = True
        Else
            _NovaInstancia = False
        End If
        _Instance.BringToFront()
        Return _Instance
    End Function
#End Region

#Region "Função"
    Sub ExecuteQuery(ByVal query As String)
        Try
            Dim cmd As New SqlCommand(query, conexao)

            conexao.Open()
            cmd.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ConfiguraLista()
        Try
            DgUsuario.Columns("UsuarioID").Visible = False
            DgUsuario.Columns("NomeUsuario").DisplayIndex = 1
            DgUsuario.Columns("Senha").DisplayIndex = 2
            DgUsuario.Columns("DataCadastro").DisplayIndex = 3
            DgUsuario.Columns("Email").DisplayIndex = 4

            DgUsuario.Columns("NomeUsuario").HeaderText = "Usuário"
            DgUsuario.Columns("Senha").HeaderText = "Senha"
            DgUsuario.Columns("DataCadastro").HeaderText = "Cadastro"
            DgUsuario.Columns("Email").HeaderText = "Email"

            DgUsuario.Columns("NomeUsuario").Width = 150
            DgUsuario.Columns("Senha").Width = 100
            DgUsuario.Columns("DataCadastro").Width = 100
            DgUsuario.Columns("Email").Width = 220

            DgUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64)
            DgUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AtualizaLista()
        Try
            Dim cmd As New SqlCommand("SELECT * FROM Usuarios", conexao)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            DgUsuario.DataSource = dt
            ConfiguraLista()
            BtnIncluir.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub IncluiUsuario()
        Try
            If TxtUsuario.Text = "" Then
                MessageBox.Show("Digite um Usuário!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtUsuario.Focus()
                Exit Sub
            ElseIf TxtSenha.Text = "" Then
                MessageBox.Show("Digite uma Senha!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtSenha.Focus()
                Exit Sub
            ElseIf TxtEmail.Text = "" And CmbEmail.Text <> "" Then
                MessageBox.Show("Digite seu Email!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtEmail.Focus()
                Exit Sub
            ElseIf TxtEmail.Text <> "" And CmbEmail.Text = "" Then
                MessageBox.Show("Selecione um domínio para o Email!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                CmbEmail.Focus()
                Exit Sub
            Else
                Dim dominio As String = TxtEmail.Text.Trim & CmbEmail.Text.Trim
                Dim connStr As String = "Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True"

                Using connection As New SqlConnection(connStr)
                    Using cmd As New SqlCommand("InserirUsuario", connection) 'CONSUMO DE PROCEDURE
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@Senha", TxtSenha.Text.Trim)

                        Dim dataTexto As String = DtData.Text
                        Dim dataFormatada As String
                        If DateTime.TryParse(dataTexto, Nothing) Then
                            dataFormatada = DateTime.Parse(dataTexto).ToString("yyyy-MM-dd")
                        Else
                            MessageBox.Show("A data não está em um formato válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        cmd.Parameters.AddWithValue("@DataCadastro", dataFormatada)
                        cmd.Parameters.AddWithValue("@NomeUsuario", TxtUsuario.Text.Trim)
                        cmd.Parameters.AddWithValue("@Email", dominio)

                        connection.Open()
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Cadastro realizado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AtualizaLista()
                        Limpar()
                        TxtUsuario.Focus()
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AlteraUsuario()
        Try
            If String.IsNullOrEmpty(TxtID.Text) Then
                MessageBox.Show("Selecione um registro para alterar!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtID.Focus()
                Exit Sub
            ElseIf TxtUsuario.Text = DgUsuario.CurrentRow.Cells(3).Value.ToString() Then
                MessageBox.Show("Digite um usuário diferente!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtUsuario.Focus()
                Exit Sub
            ElseIf TxtEmail.Text = "" And CmbEmail.Text <> "" Then
                MessageBox.Show("Digite seu Email!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtEmail.Focus()
                Exit Sub
            ElseIf TxtEmail.Text <> "" And CmbEmail.Text = "" Then
                MessageBox.Show("Selecione um domínio para o Email!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                CmbEmail.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TxtSenha.Text) Then
                MessageBox.Show("Digite uma nova senha!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtSenha.Focus()
                Exit Sub
            ElseIf TxtEmail.Text <> DgUsuario.CurrentRow.Cells(4).Value Then
                If MsgBox("Alterar dominio?", MsgBoxStyle.YesNo, "INCLUSÃO DE PEDIDO") = MsgBoxResult.Yes Then
                    Dim dominio As String = TxtEmail.Text.Trim() & CmbEmail.Text.Trim()

                    Using connection As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")
                        connection.Open()

                        Using command As New SqlCommand("AlterarUsuario", connection) 'CONSUMO DE PROCEDURE
                            command.CommandType = CommandType.StoredProcedure

                            command.Parameters.AddWithValue("@UsuarioID", TxtID.Text.Trim())
                            command.Parameters.AddWithValue("@Senha", TxtSenha.Text.Trim())
                            command.Parameters.AddWithValue("@NomeUsuario", TxtUsuario.Text.Trim())
                            command.Parameters.AddWithValue("@Email", dominio)

                            command.ExecuteNonQuery()

                            MessageBox.Show("Registro alterado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            AtualizaLista()
                            Limpar()
                            TxtUsuario.Focus()
                        End Using
                    End Using
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub DeletaUsuario()
        Try
            If DgUsuario.SelectedRows.Count > 0 Then
                Dim usuarioID As Integer = Convert.ToInt32(DgUsuario.SelectedRows(0).Cells("UsuarioID").Value)
                Dim nomeUsuario As String = DgUsuario.SelectedRows(0).Cells("NomeUsuario").Value.ToString()

                If MsgBox("Deseja realmente deletar o Usuário: " & nomeUsuario & " ?", MsgBoxStyle.YesNo, "EXCLUSÃO") = MsgBoxResult.Yes Then
                    Using connection As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")
                        connection.Open()

                        Using command As New SqlCommand("DeletarUsuario", connection) 'CONSUMO DE PROCEDURE
                            command.CommandType = CommandType.StoredProcedure
                            command.Parameters.AddWithValue("@UsuarioID", usuarioID)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Usuário deletado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AtualizaLista()
                    Limpar()
                    TxtUsuario.Focus()
                Else
                    Return
                End If
            Else
                MessageBox.Show("Selecione um Usuário na lista para excluir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Limpar()
        Try
            TxtUsuario.Text = ""
            TxtSenha.Text = ""
            TxtEmail.Text = ""
            CmbEmail.ResetText()
            BtnIncluir.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub FrmSelecionaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AtualizaLista()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmSelecionaUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            ElseIf e.KeyCode = Keys.Delete Then
                BtnDeletar.PerformClick()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtEmail_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        Try
            If e.KeyChar = "@" Then
                MessageBox.Show("Selecione um Dominio!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                CmbEmail.Focus()
                e.Handled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgUsuario.CellClick
        Try
            TxtID.Text = DgUsuario.CurrentRow.Cells(0).Value
            TxtUsuario.Text = DgUsuario.CurrentRow.Cells(3).Value

            'PEGAR CAMPO EMAIL SEM ESTAR CONCATENADO COM O DOMINIO
            Dim domainEmail As String = DgUsuario.CurrentRow.Cells(4).Value.ToString()
            If domainEmail.Contains("@") Then
                Dim email() As String = domainEmail.Split("@")
                If email.Length > 0 Then
                    TxtEmail.Text = email(0)
                End If
            Else
                TxtEmail.Text = domainEmail
            End If

            TxtSenha.Text = DgUsuario.CurrentRow.Cells(1).Value
            DgUsuario.Text = DgUsuario.CurrentRow.Cells(2).Value
            BtnIncluir.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        Try
            AtualizaLista()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnIncluir_Click_1(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Try
            IncluiUsuario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Try
            AlteraUsuario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        Try
            DeletaUsuario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try
            Limpar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Try
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class
