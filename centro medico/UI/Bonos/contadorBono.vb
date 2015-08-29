Public Class contadorBono
    Public codigopaciente As Integer
    Public context As CMLinqDataContext
    Public cita As CITA = Nothing
    Public Event asociarCita()

    Public Sub CargaSesionesLibres()
        Dim bono As Bonos = Bonos.bonoUtil(codigopaciente, context)
        If Not bono Is Nothing Then Me.lblContador.Text = "El paciente dispone de sesiones" Else Me.lblContador.Text = "ERROR PAC " & codigopaciente

        Me.Visible = ((Not bono Is Nothing) Or (SesionEnCita()))

        'si la variable cita esta seteada compruebo si esta está vinculada a una sesión del bono.
        SesionEnCita()


    End Sub
    ''' <summary>
    ''' Comprueba si una cita está vinculada a una sesión y devuelve true o false
    ''' </summary>
    ''' <returns>Boolean donde true es que está vinculado a una cita y false que no</returns>
    ''' <remarks></remarks>
    Private Function SesionEnCita() As Boolean
        Dim esta As Boolean = False
        If Not cita Is Nothing Then
            Dim bono As Sesiones = (From a As Sesiones In context.Sesiones Where a.refcita = cita.IDCITA And a.CITA.Eliminado = False Select a Take 1).SingleOrDefault()
            Dim strBono As String = ""
            If Not bono Is Nothing Then
                Me.lblInfo.Visible = True
                Me.lblContador.Visible = False
                If Not bono.Bonos.Notas Is Nothing Then strBono = bono.Bonos.Notas

                Me.lblInfo.Text = "Bono " & bono.Bonos.Notas & " nº " & bono.refbono
                Me.btAsociar.Visible = False
                esta = True
            Else
                Me.btAsociar.Visible = (Not cita Is Nothing)
            End If
        End If
        Return esta
    End Function


    Public Sub NuevaSesion()
        RaiseEvent asociarCita()

        If Not cita Is Nothing Then
            Dim bono As Bonos = Bonos.bonoUtil(codigopaciente, context, True)
            If SesionEnCita() = False AndAlso Not bono Is Nothing Then
                bono.context = context
                bono.AsociaCitaSesion(cita)
                Me.CargaSesionesLibres()
            End If
        End If
    End Sub
    
    Private Sub btAsociar_Click(sender As Object, e As EventArgs) Handles btAsociar.Click
        NuevaSesion()
    End Sub
End Class
