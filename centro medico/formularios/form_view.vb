Public Class form_view
    Dim direccion As String
    Dim nombre As String

    Sub New(ByVal adir As String, ByVal aname As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        direccion = adir
        nombre = aname
        Me.Text = "Vista Fichero- " + aname
    End Sub
    Private Sub form_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim url As Uri = New Uri(direccion + nombre)
        'Try
        'Impersonar al usuario segun su carpeta compartida
        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                        Globales.Configuracion.CarpetaCompartidaPassword, _
                                                        Globales.Configuracion.CarpetaCompartidaDominio)
        End If

        'Operacion a realizar con las credenciales almacenadas
        'File.Copy(fcompletename, Globals.Configuracion.dirfiles + "\" + _nombre, True)
        WebBrowser1.Url = url

        'Desacher la impersonacion
        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
            End If
        End If

        'Catch ex As Exception
        'WebBrowser1.Stop()
        'End 'Try
    End Sub
End Class