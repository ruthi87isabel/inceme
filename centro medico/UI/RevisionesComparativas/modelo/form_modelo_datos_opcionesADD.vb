Public Class form_modelo_datos_opcionesADD


    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        If txtTexto.Text Is Nothing Or txtTexto.Text.Trim() = "" Then
            MessageBox.Show("La descripción no puede ser vacia")
            Return
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtTexto_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTexto.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk_Click(Nothing, Nothing)
        End If
    End Sub
End Class