Public Class frm_BancoImag_NuevaCategoria

    Private Sub frm_BancoImag_NuevaCategoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        RC_Categorias_GaleriaImageneBindingSource.EndEdit()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class