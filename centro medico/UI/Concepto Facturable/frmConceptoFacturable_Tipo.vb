Public Class frmConceptoFacturable_Tipo

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class