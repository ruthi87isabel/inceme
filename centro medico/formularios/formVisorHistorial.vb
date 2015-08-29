Public Class formVisorHistorial
    Public Sub New(ByVal codigoHistorial As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
      
        Me.CtrlVisorHistoria1.CodigoHistorial = codigoHistorial
        Me.CtrlVisorHistoria1.CargarHistorial()

    End Sub

    Private Sub btCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCerrar.Click
        Me.Close()
    End Sub

    Private Sub formVisorHistorial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) = RoleManager.TipoPermisos.Ninguno Then
            MessageBox.Show("Usted no tiene accesso a esta sección")
            Me.Close()
        End If
        Me.btCerrar.Focus()
    End Sub
End Class