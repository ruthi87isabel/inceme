<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarAccion
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
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim DescripcionGeneradaLabel As System.Windows.Forms.Label
        Dim IDTratamientoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.DescripcionGeneradaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.D_PresupuestoLineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImporteTextBox = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.TratamientoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.txtDescuento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDescuentoImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTarifa = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        DescripcionGeneradaLabel = New System.Windows.Forms.Label()
        IDTratamientoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.D_PresupuestoLineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(29, 11)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 1
        ImporteLabel.Text = "Importe:"
        '
        'DescripcionGeneradaLabel
        '
        DescripcionGeneradaLabel.AutoSize = True
        DescripcionGeneradaLabel.Location = New System.Drawing.Point(12, 61)
        DescripcionGeneradaLabel.Name = "DescripcionGeneradaLabel"
        DescripcionGeneradaLabel.Size = New System.Drawing.Size(116, 13)
        DescripcionGeneradaLabel.TabIndex = 2
        DescripcionGeneradaLabel.Text = "Descripcion Generada:"
        '
        'IDTratamientoLabel
        '
        IDTratamientoLabel.AutoSize = True
        IDTratamientoLabel.Location = New System.Drawing.Point(12, 9)
        IDTratamientoLabel.Name = "IDTratamientoLabel"
        IDTratamientoLabel.Size = New System.Drawing.Size(66, 13)
        IDTratamientoLabel.TabIndex = 8
        IDTratamientoLabel.Text = "Tratamiento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(29, 55)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 1
        Label1.Text = "Dto %"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(17, 102)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 13)
        Label2.TabIndex = 1
        Label2.Text = " Dto Importe:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(37, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 13)
        Label3.TabIndex = 1
        Label3.Text = "Total:"
        '
        'DescripcionGeneradaTextBox
        '
        Me.DescripcionGeneradaTextBox.AcceptsReturn = True
        Me.DescripcionGeneradaTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionGeneradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.D_PresupuestoLineasBindingSource, "DescripcionGenerada", True))
        Me.DescripcionGeneradaTextBox.Location = New System.Drawing.Point(15, 77)
        Me.DescripcionGeneradaTextBox.MaxLength = 250
        Me.DescripcionGeneradaTextBox.Multiline = True
        Me.DescripcionGeneradaTextBox.Name = "DescripcionGeneradaTextBox"
        Me.DescripcionGeneradaTextBox.Size = New System.Drawing.Size(360, 211)
        Me.DescripcionGeneradaTextBox.TabIndex = 0
        '
        'D_PresupuestoLineasBindingSource
        '
        Me.D_PresupuestoLineasBindingSource.DataSource = GetType(centro_medico.d_PresupuestoLinea)
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.D_PresupuestoLineasBindingSource, "Importe", True))
        Me.ImporteTextBox.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.ImporteTextBox.FormatString = "C2"
        Me.ImporteTextBox.Location = New System.Drawing.Point(14, 29)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ImporteTextBox.TabIndex = 1
        Me.ImporteTextBox.Text = "0,00 €"
        Me.ImporteTextBox.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TratamientoTextBox
        '
        Me.TratamientoTextBox.AcceptsReturn = True
        Me.TratamientoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TratamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.D_PresupuestoLineasBindingSource, "IDTratamiento", True))
        Me.TratamientoTextBox.Location = New System.Drawing.Point(15, 27)
        Me.TratamientoTextBox.Name = "TratamientoTextBox"
        Me.TratamientoTextBox.ReadOnly = True
        Me.TratamientoTextBox.Size = New System.Drawing.Size(457, 20)
        Me.TratamientoTextBox.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(395, 298)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 34)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNota
        '
        Me.lblNota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(12, 315)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(179, 13)
        Me.lblNota.TabIndex = 9
        Me.lblNota.Text = "Nota: Se facturan N piezas x Precio "
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.D_PresupuestoLineasBindingSource, "DescuentoPercent", True))
        Me.txtDescuento.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtDescuento.Location = New System.Drawing.Point(14, 72)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(68, 20)
        Me.txtDescuento.TabIndex = 1
        Me.txtDescuento.Text = "0,00 %"
        Me.txtDescuento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtDescuentoImporte
        '
        Me.txtDescuentoImporte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDescuentoImporte.FormatString = "C2"
        Me.txtDescuentoImporte.Location = New System.Drawing.Point(14, 120)
        Me.txtDescuentoImporte.Name = "txtDescuentoImporte"
        Me.txtDescuentoImporte.Size = New System.Drawing.Size(68, 20)
        Me.txtDescuentoImporte.TabIndex = 1
        Me.txtDescuentoImporte.Text = "0,00 €"
        Me.txtDescuentoImporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(ImporteLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.ImporteTextBox)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.txtDescuentoImporte)
        Me.GroupBox1.Location = New System.Drawing.Point(381, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 222)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtTotal.FormatString = "C2"
        Me.txtTotal.Location = New System.Drawing.Point(17, 176)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(65, 20)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.Text = "0,00 €"
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTarifa
        '
        Me.lblTarifa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTarifa.AutoSize = True
        Me.lblTarifa.ForeColor = System.Drawing.Color.Red
        Me.lblTarifa.Location = New System.Drawing.Point(12, 292)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(252, 13)
        Me.lblTarifa.TabIndex = 9
        Me.lblTarifa.Text = "Nota: Importe tomado de tarifa para este tratamiento"
        Me.lblTarifa.Visible = False
        '
        'frmEditarAccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTarifa)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(IDTratamientoLabel)
        Me.Controls.Add(Me.TratamientoTextBox)
        Me.Controls.Add(DescripcionGeneradaLabel)
        Me.Controls.Add(Me.DescripcionGeneradaTextBox)
        Me.Name = "frmEditarAccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Acción"
        CType(Me.D_PresupuestoLineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents D_PresupuestoLineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents DescripcionGeneradaTextBox As ctrlTextboxAvanzado
    Public WithEvents ImporteTextBox As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents TratamientoTextBox As ctrlTextboxAvanzado
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Public WithEvents txtDescuento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents txtDescuentoImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents lblTarifa As System.Windows.Forms.Label
End Class
