Public Class ctrlCuentaBancaria

    Public Event CuentaCorrecta(ByVal entidad As String, ByVal oficina As String, ByVal cuenta As String, ByVal dc As String)
    Public Event CuentaIncorrecta(ByVal message As String)


#Region "Public Sub Chequea()"
    Public Sub Chequea()
        Try
            If txtEntidad.Text = "0000" Then
                Incorrecto("Entidad no puede ser 0000")
                Return
            End If
            If txtOficina.Text = "0000" Then
                Incorrecto("Oficina no puede ser 0000")
                Return
            End If

            If txtCuenta.Text = "0000000000" Then
                Incorrecto("Cuenta no puede ser 0000")
                Return
            End If
            If txtDC.Text = GoltraTools.DocumentoN19.CalculaDC(txtEntidad.Text, txtOficina.Text, txtCuenta.Text) Then
                Correcto()
            Else
                Incorrecto("DC incorrecto")
            End If

        Catch ex As Exception
            Incorrecto(ex.Message)
        End Try
    End Sub
#End Region

#Region "Public Sub Calcula()"
    Public Sub Calcula()
        Try
            If txtEntidad.Text = "0000" Then
                Incorrecto("Entidad no puede ser 0000")
                Return
            End If
            If txtOficina.Text = "0000" Then
                Incorrecto("Oficina no puede ser 0000")
                Return
            End If

            If txtCuenta.Text = "0000000000" Then
                Incorrecto("Cuenta no puede ser 0000")
                Return
            End If
            txtDC.Text = GoltraTools.DocumentoN19.CalculaDC(txtEntidad.Text, txtOficina.Text, txtCuenta.Text)

            Correcto()
        Catch ex As Exception
            Incorrecto(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub txtCuenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chequea()
    End Sub

    Private Sub Incorrecto(ByVal msg As String)
        txtDC.BackColor = Color.Red
        pb_Cheq.Image = My.Resources._24_message_warn
        ToolTipImg.SetToolTip(pb_Cheq, msg)
        RaiseEvent CuentaIncorrecta(msg)
    End Sub

    Private Sub Correcto()
        pb_Cheq.Image = My.Resources._24_em_check
        txtDC.BackColor = Color.FromArgb(255, 255, 192)
        ToolTipImg.SetToolTip(pb_Cheq, "Datos Correcto")
        RaiseEvent CuentaCorrecta(txtEntidad.Text, txtOficina.Text, txtCuenta.Text, txtDC.Text)
    End Sub

    'Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOficina.KeyPress, txtEntidad.KeyPress, txtCuenta.KeyPress
    '    'If Char.IsDigit(e.KeyChar) Then
    '    Chequea()
    '    ' End If
    'End Sub

#Region "Public Property Entidad() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property Entidad() As String
        Get
            Return txtEntidad.Text
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                txtEntidad.Text = value
                Chequea()
            End If
        End Set
    End Property
#End Region

#Region "Public Property Oficina() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property Oficina() As String
        Get
            Return txtOficina.Text
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                txtOficina.Text = value
                Chequea()
            End If
        End Set
    End Property
#End Region

#Region "Public Property Oficina() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property Cuenta() As String
        Get
            Return txtCuenta.Text
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                txtCuenta.Text = value
                Chequea()
            End If
        End Set
    End Property
#End Region

#Region "Public Property DC() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property DC() As String
        Get
            Return txtDC.Text
        End Get
        Set(ByVal value As String)
            txtDC.Text = value
            Chequea()
        End Set
    End Property
#End Region

#Region "Public Property CUENTABANCO() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property CUENTABANCO() As String
        Get
            Return txtEntidad.Text & txtOficina.Text & txtDC.Text & txtCuenta.Text
        End Get
        Set(ByVal value As String)
            Try
                txtEntidad.Text = value.Substring(0, 4)
                txtOficina.Text = value.Substring(4, 4)
                txtDC.Text = value.Substring(8, 2)
                txtCuenta.Text = value.Substring(10, 10)
                Chequea()
            Catch ex As Exception
                Incorrecto(ex.Message)
            End Try
        End Set
    End Property
#End Region

    Private Sub txtEntidad_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOficina.KeyUp, txtEntidad.KeyUp, txtCuenta.KeyUp
        Calcula()
    End Sub
End Class
