Imports System
Public Class frmAgregarCredito

    Public Property MontoAbonado As Double
        Get
            Return txtMontoAbonar.Value
        End Get
        Set(value As Double)
            txtMontoAbonar.Value = value
        End Set
    End Property


    Private Sub frmAgregarCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        If CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
            MessageBox.Show("Debe seleccionar una forma de pago")
            CtrlFormaPago21.Focus()
            Return
        End If

        If MontoAbonado < 0 Then
            MessageBox.Show("El importe debe ser mayor que cero")
            txtMontoAbonar.Focus()
            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class