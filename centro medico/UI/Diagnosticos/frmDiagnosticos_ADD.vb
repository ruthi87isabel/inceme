Public Class frmDiagnosticos_ADD

    Public Diagnostico As DIAGNOSTICO


    Private Sub bt_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles bt_aceptar.Click
        Me.Validate()
        Me.DIAGNOSTICOBindingSource.EndEdit()

        If (FAVORITOCheckBox.Checked) Then
            Diagnostico.FAVORITO = "S"
        Else : Diagnostico.FAVORITO = "N"
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub frmDiagnosticos_ADD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (Diagnostico.FAVORITO = "S") Then
            FAVORITOCheckBox.Checked = True
        Else : FAVORITOCheckBox.Checked = False
        End If
    End Sub

    Private Sub bt_cancel_Click(sender As System.Object, e As System.EventArgs) Handles bt_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class