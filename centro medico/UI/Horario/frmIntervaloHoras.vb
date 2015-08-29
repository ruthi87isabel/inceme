Public Class frmIntervaloHoras
    Public horaini As Date
    Public horafin As Date
 
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
 


        If Not (txtHoraIni.ValidateText Is Nothing And txtHoraFin.ValidateText Is Nothing) Then

            Dim hora As Integer = CInt(Split(txtHoraIni.Text, ":"c)(0))
            Dim minutos As Integer = CInt(Split(txtHoraIni.Text, ":"c)(1))
            horaini = New Date(Now.Year, Now.Month, Now.Day, hora, minutos, 0)

            hora = CInt(Split(txtHoraFin.Text, ":"c)(0))
            minutos = CInt(Split(txtHoraFin.Text, ":"c)(1))
            horafin = New Date(Now.Year, Now.Month, Now.Day, hora, minutos, 0)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else


            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
        Me.Close()

    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class