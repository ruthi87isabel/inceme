<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCredito
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
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.lblTextoImporteAbonar = New System.Windows.Forms.Label()
        Me.txtMontoAbonar = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(23, 69)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(363, 23)
        Me.CtrlFormaPago21.TabIndex = 15
        '
        'lblTextoImporteAbonar
        '
        Me.lblTextoImporteAbonar.Location = New System.Drawing.Point(21, 24)
        Me.lblTextoImporteAbonar.Name = "lblTextoImporteAbonar"
        Me.lblTextoImporteAbonar.Size = New System.Drawing.Size(61, 20)
        Me.lblTextoImporteAbonar.TabIndex = 0
        Me.lblTextoImporteAbonar.Text = "Importe:"
        Me.lblTextoImporteAbonar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoAbonar
        '
        Me.txtMontoAbonar.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtMontoAbonar.FormatString = "C2"
        Me.txtMontoAbonar.Location = New System.Drawing.Point(88, 21)
        Me.txtMontoAbonar.Name = "txtMontoAbonar"
        Me.txtMontoAbonar.Size = New System.Drawing.Size(74, 20)
        Me.txtMontoAbonar.TabIndex = 0
        Me.txtMontoAbonar.Text = "$0.00"
        Me.txtMontoAbonar.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(285, 21)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_Fecha.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Notas"
        '
        'txtNotas
        '
        Me.txtNotas.AcceptsReturn = True
        Me.txtNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotas.Location = New System.Drawing.Point(20, 129)
        Me.txtNotas.MaxLength = 200
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(368, 129)
        Me.txtNotas.TabIndex = 21
        '
        'ButtonOk
        '
        Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOk.Location = New System.Drawing.Point(313, 274)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 22
        Me.ButtonOk.Text = "Guardar"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha:"
        '
        'frmAgregarCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 309)
        Me.Controls.Add(Me.lblTextoImporteAbonar)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.txtMontoAbonar)
        Me.Controls.Add(Me.dtp_Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAgregarCredito"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Crédito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Public WithEvents lblTextoImporteAbonar As System.Windows.Forms.Label
    Public WithEvents txtMontoAbonar As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtNotas As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
