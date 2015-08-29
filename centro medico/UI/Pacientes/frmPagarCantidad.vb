Imports centro_medico

Public Class frmPagarCantidad


    Public Paciente As PACIENTE

    Public FormaPagoPreseleccionada As FORMASPAGO = Nothing
        
    Public Property Credito() As Double
        Get
            Return txtCredito.Value
        End Get
        Set(value As Double)
            txtCredito.Value = value
        End Set
    End Property

    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click

        If CtrlFormaPago21.ID_FORMASPAGO Is Nothing And Not chkUtilizarCredito.Checked Then
            MessageBox.Show("Debe seleccionar una forma de pago")
            CtrlFormaPago21.Focus()
            Return
        End If

        Try
            Dim total As Double = txtImporteOriginal.Value
            Dim monto As Double = txtMontoAbonar.Value

            'If (monto + Credito) < total Then
            '    MessageBox.Show("El importe abonado más el crédito no cubre los documentos seleccionados")
            '    Return
            'End If

            'If monto > total Then
            '    MessageBox.Show("El importe no puede ser mayor que el Total")
            '    Return
            'End If

            'If monto <= 0 Then
            '    MessageBox.Show("El importe debe ser mayor que 0")
            '    Return
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmPagarCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim context As New CMLinqDataContext()
        Dim fpago As List(Of FORMASPAGO) = (From f In context.FORMASPAGOs Order By f.DESCRIPCION Ascending Select f).ToList()
        If fpago.Count = 0 Then
            MessageBox.Show("Debe tener definida al menos una forma de pago antes de usar esta funcion")
            Me.Close()
        End If

        If Not FormaPagoPreseleccionada Is Nothing Then
            CtrlFormaPago21.ID_FORMASPAGO = FormaPagoPreseleccionada.CODIGO
        Else
            If Not Paciente Is Nothing Then
                If Not Paciente.FORMASPAGO Is Nothing Then
                    CtrlFormaPago21.ID_FORMASPAGO = Paciente.REFFORMAPAGO
                End If
            End If
        End If

    End Sub

    Private Sub txtMontoAbonar_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNotas.KeyUp, txtMontoAbonar.KeyUp, dtp_Fecha.KeyUp, txtDescripcion.KeyUp
        If e.KeyData = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub chkUtilizarCredito_CheckedChanged(sender As Object, e As EventArgs) Handles chkUtilizarCredito.CheckedChanged
        grpAbonar.Enabled = Not chkUtilizarCredito.Checked
    End Sub

    
    
End Class