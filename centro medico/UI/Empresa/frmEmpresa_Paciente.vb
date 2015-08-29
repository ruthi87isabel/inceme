Public Class frmEmpresa_Paciente

    Private Sub frmEmpresa_Paciente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_AEAceptar_Click(sender As System.Object, e As System.EventArgs) Handles bt_AEAceptar.Click
        If Not CtrlEmpresa1.ID_EMPRESAS.HasValue Then
            MessageBox.Show("Debe seleccionar una empresa")
            Return
        End If

        Try
            Dim lEmpresa As LEMPRESA = LEMPRESABindingSource.DataSource

            If Not lEmpresa.FECHAALTA.HasValue Then
                lEmpresa.FECHAALTA = Date.Now
            End If
        Catch ex As Exception

        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_AECancelar_Click(sender As System.Object, e As System.EventArgs) Handles bt_AECancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class