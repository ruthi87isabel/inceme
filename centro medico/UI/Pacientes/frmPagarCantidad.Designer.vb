<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarCantidad
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
        Me.lblTextoTotalAPagar = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.txtImporteOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.chkUtilizarCredito = New System.Windows.Forms.CheckBox()
        Me.grpAbonar = New System.Windows.Forms.GroupBox()
        Me.lblTextoImporteAbonar = New System.Windows.Forms.Label()
        Me.txtMontoAbonar = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.grpAbonar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTextoTotalAPagar
        '
        Me.lblTextoTotalAPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTotalAPagar.Location = New System.Drawing.Point(390, 25)
        Me.lblTextoTotalAPagar.Name = "lblTextoTotalAPagar"
        Me.lblTextoTotalAPagar.Size = New System.Drawing.Size(133, 17)
        Me.lblTextoTotalAPagar.TabIndex = 0
        Me.lblTextoTotalAPagar.Text = "Importe TOTAL a Pagar:"
        Me.lblTextoTotalAPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ButtonOk
        '
        Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOk.Location = New System.Drawing.Point(616, 388)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 8
        Me.ButtonOk.Text = "Guardar"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'txtImporteOriginal
        '
        Me.txtImporteOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteOriginal.BackColor = System.Drawing.Color.LightYellow
        Me.txtImporteOriginal.Enabled = False
        Me.txtImporteOriginal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtImporteOriginal.FormatString = "C2"
        Me.txtImporteOriginal.Location = New System.Drawing.Point(529, 22)
        Me.txtImporteOriginal.Name = "txtImporteOriginal"
        Me.txtImporteOriginal.ReadOnly = True
        Me.txtImporteOriginal.Size = New System.Drawing.Size(101, 20)
        Me.txtImporteOriginal.TabIndex = 1
        Me.txtImporteOriginal.Text = "0,00 €"
        Me.txtImporteOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtNotas
        '
        Me.txtNotas.AcceptsReturn = True
        Me.txtNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotas.Location = New System.Drawing.Point(371, 236)
        Me.txtNotas.MaxLength = 200
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(323, 146)
        Me.txtNotas.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Notas"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(529, 193)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_Fecha.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 25)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(347, 386)
        Me.txtDescripcion.TabIndex = 0
        '
        'chkUtilizarCredito
        '
        Me.chkUtilizarCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUtilizarCredito.AutoSize = True
        Me.chkUtilizarCredito.Checked = True
        Me.chkUtilizarCredito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUtilizarCredito.Location = New System.Drawing.Point(371, 117)
        Me.chkUtilizarCredito.Name = "chkUtilizarCredito"
        Me.chkUtilizarCredito.Size = New System.Drawing.Size(152, 17)
        Me.chkUtilizarCredito.TabIndex = 4
        Me.chkUtilizarCredito.Text = "Utilizar credito si es posible"
        Me.chkUtilizarCredito.UseVisualStyleBackColor = True
        Me.chkUtilizarCredito.Visible = False
        '
        'grpAbonar
        '
        Me.grpAbonar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAbonar.Controls.Add(Me.lblTextoImporteAbonar)
        Me.grpAbonar.Controls.Add(Me.txtMontoAbonar)
        Me.grpAbonar.Location = New System.Drawing.Point(371, 132)
        Me.grpAbonar.Name = "grpAbonar"
        Me.grpAbonar.Size = New System.Drawing.Size(323, 48)
        Me.grpAbonar.TabIndex = 5
        Me.grpAbonar.TabStop = False
        '
        'lblTextoImporteAbonar
        '
        Me.lblTextoImporteAbonar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextoImporteAbonar.Location = New System.Drawing.Point(49, 22)
        Me.lblTextoImporteAbonar.Name = "lblTextoImporteAbonar"
        Me.lblTextoImporteAbonar.Size = New System.Drawing.Size(102, 20)
        Me.lblTextoImporteAbonar.TabIndex = 0
        Me.lblTextoImporteAbonar.Text = "Importe abonado:"
        Me.lblTextoImporteAbonar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoAbonar
        '
        Me.txtMontoAbonar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoAbonar.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtMontoAbonar.FormatString = "C2"
        Me.txtMontoAbonar.Location = New System.Drawing.Point(158, 22)
        Me.txtMontoAbonar.Name = "txtMontoAbonar"
        Me.txtMontoAbonar.Size = New System.Drawing.Size(101, 20)
        Me.txtMontoAbonar.TabIndex = 5
        Me.txtMontoAbonar.Text = "0,00 €"
        Me.txtMontoAbonar.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(444, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Crédito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCredito
        '
        Me.txtCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCredito.BackColor = System.Drawing.Color.LightYellow
        Me.txtCredito.Enabled = False
        Me.txtCredito.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCredito.FormatString = "C2"
        Me.txtCredito.Location = New System.Drawing.Point(529, 44)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(101, 20)
        Me.txtCredito.TabIndex = 2
        Me.txtCredito.Text = "0,00 €"
        Me.txtCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(373, 75)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(318, 23)
        Me.CtrlFormaPago21.TabIndex = 3
        '
        'frmPagarCantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 423)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.txtImporteOriginal)
        Me.Controls.Add(Me.grpAbonar)
        Me.Controls.Add(Me.lblTextoTotalAPagar)
        Me.Controls.Add(Me.chkUtilizarCredito)
        Me.Controls.Add(Me.dtp_Fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmPagarCantidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entrega a Cuenta"
        Me.grpAbonar.ResumeLayout(False)
        Me.grpAbonar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Public WithEvents txtImporteOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents lblTextoTotalAPagar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtNotas As ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtDescripcion As centro_medico.ctrlTextboxAvanzado
    Public WithEvents chkUtilizarCredito As System.Windows.Forms.CheckBox
    Public WithEvents grpAbonar As System.Windows.Forms.GroupBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents lblTextoImporteAbonar As System.Windows.Forms.Label
    Public WithEvents txtMontoAbonar As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
End Class
