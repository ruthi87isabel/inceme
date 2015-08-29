Public Class frmDescuento

    Private Sub rbCantidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCantidad.CheckedChanged
        txtPorciento.Enabled = rbPercentual.Checked
        txtCantidad.Enabled = Not rbPercentual.Checked
        Calcula()
    End Sub

    Private Sub rbPercentual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPercentual.CheckedChanged
        txtPorciento.Enabled = rbPercentual.Checked
        txtCantidad.Enabled = Not rbPercentual.Checked
        Calcula()
    End Sub

    Private Sub Calcula()

        If rbPercentual.Checked Then
            txtCantidad.Value = txtImporteOriginal.Value * (txtPorciento.Value)
        Else
            If txtImporteOriginal.Value > 0 Then
                txtPorciento.Value = (txtCantidad.Value / txtImporteOriginal.Value)
            Else
                txtPorciento.Value = 0
            End If

        End If

        txtResultante.Value = txtImporteOriginal.Value - txtCantidad.Value
    End Sub

    Private Sub txtPorciento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Calcula()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calcula()
    End Sub

    Private Sub txtPorciento_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorciento.KeyUp, txtCantidad.KeyUp
        Calcula()
    End Sub

    Private Sub txtPorciento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorciento.TextChanged, txtCantidad.TextChanged
        Calcula()
    End Sub
End Class