Public Class frmTemplates_ADD

    Private Sub bt_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles bt_aceptar.Click
        Dim p As PLANTILLA = PLANTILLABindingSource.DataSource
        p.SECCION = cb_seccion.SelectedItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmTemplates_ADD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim p As PLANTILLA = PLANTILLABindingSource.DataSource
        If Not p.SECCION Is Nothing Then
            cb_seccion.SelectedItem = p.SECCION
        End If
    End Sub
End Class