Public Class frmHorarios_Justificacion

    Public HorarioDesde As Nullable(Of Date) = Nothing
    Public HorarioHasta As Nullable(Of Date) = Nothing


    Private Sub frmHorarios_Justificacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not HorarioDesde.HasValue Then
            'HorarioDesde = New Globales.Configuracion.JornadaLaboralInicio
            'HorarioHasta = Globales.Configuracion.JornadaLaboralInicio

        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class