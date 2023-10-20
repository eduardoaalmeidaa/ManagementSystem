#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class FrmLogin
    Public StrConnection = "Data Source=ALMEIDA;Initial Catalog=Fenix;Integrated Security=True"

#Region "Formulario"

#Region "Função"
    Private Sub Login()
        Dim AcessoPermitido As Boolean
        Try
            If TxtUsuario.Text = "" Then
                MsgBox("Digite um nome de usuário", MsgBoxStyle.Critical, "ATENÇÃO!")
                TxtUsuario.Focus()

            ElseIf TxtSenha.Text = "" Then
                MsgBox("Digite uma senha!", MsgBoxStyle.Critical, "ATENÇÃO!")
                TxtSenha.Focus()
            Else
                Try
                    Using cn = New SqlConnection(StrConnection)
                        cn.Open()

                        Using cmd = New SqlCommand("select NomeUsuario, Senha from Usuarios where NomeUsuario = @NomeUsuario AND Senha = @Senha", cn)

                            cmd.Parameters.AddWithValue("@NomeUsuario", TxtUsuario.Text)
                            cmd.Parameters.AddWithValue("@Senha", TxtSenha.Text)

                            Using dr = cmd.ExecuteReader()
                                If dr.HasRows Then
                                    If dr.Read() Then
                                        AcessoPermitido = True
                                    End If
                                End If
                            End Using
                        End Using
                    End Using

                Catch ex As Exception
                    MsgBox("Falha ao conectar!" & vbNewLine & ex.Message, vbCritical)
                End Try

                If AcessoPermitido Then
                    FrmPrincipal.Show()
                    Visible = False
                Else
                    MsgBox("Usuário ou senha inválidos!", vbExclamation, "Sistema")
                    TxtUsuario.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            Login()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Try
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class
