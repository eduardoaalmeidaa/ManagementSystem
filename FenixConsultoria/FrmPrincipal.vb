Public Class FrmPrincipal
#Region "Formulario"

#Region "Única Instância"
    Private Shared _Instance As FrmPrincipal = Nothing
    Private Shared _NovaInstancia As Boolean = False

    Public Property NovaInstancia() As String
        Get
            Return _NovaInstancia
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Shared Function Instance() As FrmPrincipal
        If _Instance Is Nothing OrElse _Instance.IsDisposed = True Then
            _Instance = New FrmPrincipal
            _NovaInstancia = True
        Else
            _NovaInstancia = False
        End If
        _Instance.BringToFront()
        Return _Instance
    End Function
#End Region

    Private Sub MnuClientes_Click(sender As Object, e As EventArgs) Handles MnuClientes.Click
        Dim myfrmSelecionaUsuario As FrmSelecionaUsuario
        Try
            myfrmSelecionaUsuario = FrmSelecionaUsuario.Instance
            myfrmSelecionaUsuario.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MnuPedidos_Click(sender As Object, e As EventArgs) Handles MnuPedidos.Click
        Dim myfrmSelecionaProdutos As FrmSelecionaProdutos
        Try
            myfrmSelecionaProdutos = FrmSelecionaProdutos.Instance
            myfrmSelecionaProdutos.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class