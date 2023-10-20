#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class FrmSelecionaProdutos
    Dim conexao As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")

#Region "Formulario"

#Region "Única Instância"
    Private Shared _Instance As FrmSelecionaProdutos = Nothing
    Private Shared _NovaInstancia As Boolean = False

    Public Property NovaInstancia() As String
        Get
            Return _NovaInstancia
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Shared Function Instance() As FrmSelecionaProdutos
        If _Instance Is Nothing OrElse _Instance.IsDisposed = True Then
            _Instance = New FrmSelecionaProdutos
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
            DgProduto.Columns("ProdutoID").Visible = False
            DgProduto.Columns("Produto").DisplayIndex = 1
            DgProduto.Columns("Preco").DisplayIndex = 2
            DgProduto.Columns("Observacao").DisplayIndex = 3
            DgProduto.Columns("DataCadastro").DisplayIndex = 4

            DgProduto.Columns("Produto").HeaderText = "Produto"
            DgProduto.Columns("Preco").HeaderText = "Preço"
            DgProduto.Columns("Observacao").HeaderText = "Observação"
            DgProduto.Columns("DataCadastro").HeaderText = "Data Cadastro"

            DgProduto.Columns("Produto").Width = 80
            DgProduto.Columns("Preco").Width = 50
            DgProduto.Columns("Observacao").Width = 200
            DgProduto.Columns("DataCadastro").Width = 80

            DgProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64)
            DgProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AtualizaLista()
        Try
            Dim cmd As New SqlCommand("SELECT * FROM Produtos", conexao)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            DgProduto.DataSource = dt
            ConfiguraLista()
            BtnIncluir.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub IncluiProduto()
        Try
            If TxtProduto.Text = "" Then
                MessageBox.Show("Digite o nome do Produto!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtProduto.Focus()
                Exit Sub
            ElseIf TxtPreco.Text = "" Then
                MessageBox.Show("Digite o Preço!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtPreco.Focus()
                Exit Sub
            Else
                Dim connStr As String = "Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True"

                Using connection As New SqlConnection(connStr)
                    Using cmd As New SqlCommand("InserirProduto", connection) 'CONSUMO DE PROCEDURE
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@Produto", TxtProduto.Text.Trim)

                        Dim dataTexto As String = DtData.Text
                        Dim dataFormatada As String
                        If DateTime.TryParse(dataTexto, Nothing) Then
                            dataFormatada = DateTime.Parse(dataTexto).ToString("yyyy-MM-dd")
                        Else
                            MessageBox.Show("A data não está em um formato válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        cmd.Parameters.AddWithValue("@DataCadastro", dataFormatada)
                        cmd.Parameters.AddWithValue("@Preco", TxtPreco.Text.Trim)
                        cmd.Parameters.AddWithValue("@Observacao", TxtObservacao.Text.Trim)

                        connection.Open()
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Cadastro realizado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AtualizaLista()
                        Limpar()
                        TxtProduto.Focus()
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AlteraProduto()
        Try
            If String.IsNullOrEmpty(TxtID.Text) Then
                MessageBox.Show("Selecione um registro para alterar!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtID.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TxtPreco.Text) Then
                MessageBox.Show("Digite um Preço para alterar!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TxtPreco.Focus()
                Exit Sub
            Else
                Using connection As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")
                    connection.Open()

                    Using command As New SqlCommand("AlterarProduto", connection) 'CONSUMO DE PROCEDURE
                        command.CommandType = CommandType.StoredProcedure

                        command.Parameters.AddWithValue("@ProdutoID", TxtID.Text.Trim())
                        command.Parameters.AddWithValue("@Produto", TxtProduto.Text.Trim())
                        command.Parameters.AddWithValue("@Observacao", TxtObservacao.Text.Trim())
                        command.Parameters.AddWithValue("@Preco", TxtPreco.Text.Trim())

                        command.ExecuteNonQuery()

                        MessageBox.Show("Registro alterado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AtualizaLista()
                        Limpar()
                        TxtProduto.Focus()
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub DeletaProduto()
        Try
            If DgProduto.SelectedRows.Count > 0 Then
                Dim produtoID As Integer = Convert.ToInt32(DgProduto.SelectedRows(0).Cells("ProdutoID").Value)
                Dim nomeProduto As String = DgProduto.SelectedRows(0).Cells("Produto").Value.ToString()

                If MsgBox("Deseja realmente deletar o Produto: " & nomeProduto & " ?", MsgBoxStyle.YesNo, "EXCLUSÃO") = MsgBoxResult.Yes Then
                    Using connection As New SqlConnection("Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True")
                        connection.Open()

                        Using command As New SqlCommand("DeletarProduto", connection) 'CONSUMO DE PROCEDURE
                            command.CommandType = CommandType.StoredProcedure
                            command.Parameters.AddWithValue("@ProdutoID", produtoID)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Produto deletado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AtualizaLista()
                    Limpar()
                    TxtProduto.Focus()
                Else
                    Return
                End If
            Else
                MessageBox.Show("Selecione um Produto na lista para excluir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Limpar()
        Try
            TxtProduto.Text = ""
            TxtPreco.Text = ""
            TxtObservacao.Text = ""
            BtnIncluir.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub FrmSelecionaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AtualizaLista()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmSelecionaProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub TxtPreco_TextChanged(sender As Object, e As EventArgs) Handles TxtPreco.TextChanged
        Try
            'FORMATA CAMPO PRECO PARA RECEBER FORMATO 'R$'
            Dim valorDigitado As String = TxtPreco.Text.Replace("R$", "").Trim()

            If IsNumeric(valorDigitado) Then
                Dim valorFormatado As String = String.Format("R$ {0:F2}", CDbl(valorDigitado))
                TxtPreco.Text = valorFormatado
            Else
                TxtPreco.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProduto.CellClick
        Try
            TxtID.Text = DgProduto.CurrentRow.Cells(0).Value
            TxtProduto.Text = DgProduto.CurrentRow.Cells(1).Value
            TxtPreco.Text = DgProduto.CurrentRow.Cells(3).Value
            DgProduto.Text = DgProduto.CurrentRow.Cells(4).Value
            TxtObservacao.Text = DgProduto.CurrentRow.Cells(2).Value
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

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Try
            IncluiProduto()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Try
            AlteraProduto()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        Try
            DeletaProduto()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try
            Limpar()
            TxtProduto.Focus()

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