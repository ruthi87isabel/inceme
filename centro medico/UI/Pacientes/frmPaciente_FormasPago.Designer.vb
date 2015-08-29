<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente_FormasPago
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlFormaPago = New System.Windows.Forms.Panel()
        Me.btIBAN = New System.Windows.Forms.Button()
        Me.txtIBAN = New System.Windows.Forms.TextBox()
        Me.chkPagoBanco = New Janus.Windows.EditControls.UICheckBox()
        Me.CtrlCuentaBancaria1 = New centro_medico.ctrlCuentaBancaria()
        Me.tb_fpEntidadbancaria = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_fpEntidadbancaria = New System.Windows.Forms.Label()
        Me.tb_fpTitularCuentaORecibo = New centro_medico.ctrlTextboxAvanzado()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_fpTitularCuentaORecibo = New System.Windows.Forms.Label()
        Me.bt_fpCuenta = New System.Windows.Forms.Button()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblIBAN = New System.Windows.Forms.Label()
        Me.pnlFormaPago.SuspendLayout()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFormaPago
        '
        Me.pnlFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormaPago.Controls.Add(Me.lblIBAN)
        Me.pnlFormaPago.Controls.Add(Me.btIBAN)
        Me.pnlFormaPago.Controls.Add(Me.txtIBAN)
        Me.pnlFormaPago.Controls.Add(Me.chkPagoBanco)
        Me.pnlFormaPago.Controls.Add(Me.CtrlCuentaBancaria1)
        Me.pnlFormaPago.Controls.Add(Me.tb_fpEntidadbancaria)
        Me.pnlFormaPago.Controls.Add(Me.lb_fpEntidadbancaria)
        Me.pnlFormaPago.Controls.Add(Me.tb_fpTitularCuentaORecibo)
        Me.pnlFormaPago.Controls.Add(Me.lb_fpTitularCuentaORecibo)
        Me.pnlFormaPago.Controls.Add(Me.bt_fpCuenta)
        Me.pnlFormaPago.Location = New System.Drawing.Point(12, 68)
        Me.pnlFormaPago.Name = "pnlFormaPago"
        Me.pnlFormaPago.Size = New System.Drawing.Size(697, 118)
        Me.pnlFormaPago.TabIndex = 1
        '
        'btIBAN
        '
        Me.btIBAN.Location = New System.Drawing.Point(339, 46)
        Me.btIBAN.Name = "btIBAN"
        Me.btIBAN.Size = New System.Drawing.Size(23, 23)
        Me.btIBAN.TabIndex = 14
        Me.btIBAN.UseVisualStyleBackColor = True
        '
        'txtIBAN
        '
        Me.txtIBAN.Location = New System.Drawing.Point(134, 50)
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.Size = New System.Drawing.Size(201, 20)
        Me.txtIBAN.TabIndex = 13
        '
        'chkPagoBanco
        '
        Me.chkPagoBanco.CheckedValue = "S"
        Me.chkPagoBanco.Location = New System.Drawing.Point(15, 25)
        Me.chkPagoBanco.Name = "chkPagoBanco"
        Me.chkPagoBanco.Size = New System.Drawing.Size(104, 23)
        Me.chkPagoBanco.TabIndex = 0
        Me.chkPagoBanco.Text = "Pago Banco"
        Me.chkPagoBanco.UncheckedValue = "N"
        '
        'CtrlCuentaBancaria1
        '
        Me.CtrlCuentaBancaria1.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.CtrlCuentaBancaria1.Cuenta = "0000000000"
        Me.CtrlCuentaBancaria1.CUENTABANCO = "000000000000000000"
        Me.CtrlCuentaBancaria1.DC = ""
        Me.CtrlCuentaBancaria1.Entidad = "0000"
        Me.CtrlCuentaBancaria1.Location = New System.Drawing.Point(134, 13)
        Me.CtrlCuentaBancaria1.Name = "CtrlCuentaBancaria1"
        Me.CtrlCuentaBancaria1.Oficina = "0000"
        Me.CtrlCuentaBancaria1.Size = New System.Drawing.Size(241, 39)
        Me.CtrlCuentaBancaria1.TabIndex = 1
        '
        'tb_fpEntidadbancaria
        '
        Me.tb_fpEntidadbancaria.AcceptsReturn = True
        Me.tb_fpEntidadbancaria.BackColor = System.Drawing.Color.White
        Me.tb_fpEntidadbancaria.Location = New System.Drawing.Point(381, 90)
        Me.tb_fpEntidadbancaria.MaxLength = 10
        Me.tb_fpEntidadbancaria.Name = "tb_fpEntidadbancaria"
        Me.tb_fpEntidadbancaria.ReadOnly = True
        Me.tb_fpEntidadbancaria.Size = New System.Drawing.Size(285, 20)
        Me.tb_fpEntidadbancaria.TabIndex = 4
        '
        'lb_fpEntidadbancaria
        '
        Me.lb_fpEntidadbancaria.AutoSize = True
        Me.lb_fpEntidadbancaria.Location = New System.Drawing.Point(378, 74)
        Me.lb_fpEntidadbancaria.Name = "lb_fpEntidadbancaria"
        Me.lb_fpEntidadbancaria.Size = New System.Drawing.Size(88, 13)
        Me.lb_fpEntidadbancaria.TabIndex = 12
        Me.lb_fpEntidadbancaria.Text = "Entidad Bancaria"
        '
        'tb_fpTitularCuentaORecibo
        '
        Me.tb_fpTitularCuentaORecibo.AcceptsReturn = True
        Me.tb_fpTitularCuentaORecibo.BackColor = System.Drawing.Color.White
        Me.tb_fpTitularCuentaORecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "TITULAR", True))
        Me.tb_fpTitularCuentaORecibo.Location = New System.Drawing.Point(15, 90)
        Me.tb_fpTitularCuentaORecibo.MaxLength = 90
        Me.tb_fpTitularCuentaORecibo.Name = "tb_fpTitularCuentaORecibo"
        Me.tb_fpTitularCuentaORecibo.Size = New System.Drawing.Size(344, 20)
        Me.tb_fpTitularCuentaORecibo.TabIndex = 3
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'lb_fpTitularCuentaORecibo
        '
        Me.lb_fpTitularCuentaORecibo.AutoSize = True
        Me.lb_fpTitularCuentaORecibo.Location = New System.Drawing.Point(12, 74)
        Me.lb_fpTitularCuentaORecibo.Name = "lb_fpTitularCuentaORecibo"
        Me.lb_fpTitularCuentaORecibo.Size = New System.Drawing.Size(195, 13)
        Me.lb_fpTitularCuentaORecibo.TabIndex = 10
        Me.lb_fpTitularCuentaORecibo.Text = "Titular de la cuenta / titular para recibos"
        '
        'bt_fpCuenta
        '
        Me.bt_fpCuenta.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_fpCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_fpCuenta.Location = New System.Drawing.Point(381, 25)
        Me.bt_fpCuenta.Name = "bt_fpCuenta"
        Me.bt_fpCuenta.Size = New System.Drawing.Size(29, 23)
        Me.bt_fpCuenta.TabIndex = 2
        Me.bt_fpCuenta.UseVisualStyleBackColor = True
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.DataBindings.Add(New System.Windows.Forms.Binding("ID_FORMASPAGO", Me.PACIENTEBindingSource, "REFFORMAPAGO", True))
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(12, 33)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(408, 23)
        Me.CtrlFormaPago21.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(721, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'lblIBAN
        '
        Me.lblIBAN.AutoSize = True
        Me.lblIBAN.Location = New System.Drawing.Point(59, 51)
        Me.lblIBAN.Name = "lblIBAN"
        Me.lblIBAN.Size = New System.Drawing.Size(32, 13)
        Me.lblIBAN.TabIndex = 3
        Me.lblIBAN.Text = "IBAN"
        '
        'frmPaciente_FormasPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 195)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.pnlFormaPago)
        Me.Name = "frmPaciente_FormasPago"
        Me.ShowInTaskbar = False
        Me.Text = "Forma de Pago"
        Me.pnlFormaPago.ResumeLayout(False)
        Me.pnlFormaPago.PerformLayout()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlFormaPago As System.Windows.Forms.Panel
    Friend WithEvents CtrlCuentaBancaria1 As centro_medico.ctrlCuentaBancaria
    Friend WithEvents tb_fpEntidadbancaria As ctrlTextboxAvanzado
    Friend WithEvents lb_fpEntidadbancaria As System.Windows.Forms.Label
    Friend WithEvents tb_fpTitularCuentaORecibo As ctrlTextboxAvanzado
    Friend WithEvents lb_fpTitularCuentaORecibo As System.Windows.Forms.Label
    Friend WithEvents bt_fpCuenta As System.Windows.Forms.Button
    Friend WithEvents chkPagoBanco As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Public WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btIBAN As System.Windows.Forms.Button
    Friend WithEvents txtIBAN As System.Windows.Forms.TextBox
    Friend WithEvents lblIBAN As System.Windows.Forms.Label
End Class
