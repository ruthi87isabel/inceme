<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNTratamiento
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.lblPieza1 = New System.Windows.Forms.Label
        Me.tbxPieza1 = New ctrlTextboxAvanzado
        Me.cbxTrat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbxDoct = New System.Windows.Forms.ComboBox
        Me.lblPieza2 = New System.Windows.Forms.Label
        Me.tbxPieza2 = New ctrlTextboxAvanzado
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(430, 25)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(69, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'lblPieza1
        '
        Me.lblPieza1.Location = New System.Drawing.Point(13, 134)
        Me.lblPieza1.Name = "lblPieza1"
        Me.lblPieza1.Size = New System.Drawing.Size(101, 12)
        Me.lblPieza1.TabIndex = 48
        Me.lblPieza1.Text = "Pieza inicial"
        Me.lblPieza1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxPieza1
        '
        Me.tbxPieza1.Location = New System.Drawing.Point(120, 130)
        Me.tbxPieza1.Name = "tbxPieza1"
        Me.tbxPieza1.Size = New System.Drawing.Size(52, 20)
        Me.tbxPieza1.TabIndex = 46
        '
        'cbxTrat
        '
        Me.cbxTrat.FormattingEnabled = True
        Me.cbxTrat.Location = New System.Drawing.Point(120, 100)
        Me.cbxTrat.Name = "cbxTrat"
        Me.cbxTrat.Size = New System.Drawing.Size(298, 21)
        Me.cbxTrat.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Tratamiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(120, 70)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(176, 20)
        Me.dtpFecha.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Doctor"
        '
        'cbxDoct
        '
        Me.cbxDoct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDoct.FormattingEnabled = True
        Me.cbxDoct.Location = New System.Drawing.Point(120, 39)
        Me.cbxDoct.Name = "cbxDoct"
        Me.cbxDoct.Size = New System.Drawing.Size(298, 21)
        Me.cbxDoct.TabIndex = 53
        '
        'lblPieza2
        '
        Me.lblPieza2.AutoSize = True
        Me.lblPieza2.Location = New System.Drawing.Point(183, 133)
        Me.lblPieza2.Name = "lblPieza2"
        Me.lblPieza2.Size = New System.Drawing.Size(55, 13)
        Me.lblPieza2.TabIndex = 58
        Me.lblPieza2.Text = "Pieza final"
        '
        'tbxPieza2
        '
        Me.tbxPieza2.Location = New System.Drawing.Point(244, 130)
        Me.tbxPieza2.Name = "tbxPieza2"
        Me.tbxPieza2.Size = New System.Drawing.Size(52, 20)
        Me.tbxPieza2.TabIndex = 57
        '
        'frmNTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 169)
        Me.Controls.Add(Me.lblPieza2)
        Me.Controls.Add(Me.tbxPieza2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxDoct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxTrat)
        Me.Controls.Add(Me.lblPieza1)
        Me.Controls.Add(Me.tbxPieza1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNTratamiento"
        Me.Text = "Nuevo tratamiento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPieza1 As System.Windows.Forms.Label
    Friend WithEvents tbxPieza1 As ctrlTextboxAvanzado
    Friend WithEvents cbxTrat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cbxDoct As System.Windows.Forms.ComboBox
    Friend WithEvents lblPieza2 As System.Windows.Forms.Label
    Friend WithEvents tbxPieza2 As ctrlTextboxAvanzado
End Class
