Imports System.Windows.Forms

Public Class FrmMDIFenix

#Region "Única Instância"
    Private Shared _Instance As FrmMDIFenix = Nothing
    Private Shared _NovaInstancia As Boolean = False

    Public Property NovaInstancia() As String
        Get
            Return _NovaInstancia
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Shared Function Instance() As FrmMDIFenix
        If _Instance Is Nothing OrElse _Instance.IsDisposed = True Then
            _Instance = New FrmMDIFenix
            _NovaInstancia = True
        Else
            _NovaInstancia = False
        End If
        _Instance.BringToFront()
        Return _Instance
    End Function

#End Region

    Private Sub FrmMDIFenix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FrmLogin.ShowDialog()
    End Sub

    ' Private Sub MnuClientesInclui_Click(sender As Object, e As EventArgs) Handles MnuClientesInclui.Click
    '   Dim myfrmClientes As FrmClientes

    '   myfrmClientes = myfrmClientes.Instance
    '  myfrmClientes.TipoForm = myfrmClientes.enumTipoForm.Inclui
    '  myfrmClientes.MdiParent = Me
    '   myfrmClientes.Show()
    '   End Sub
End Class
