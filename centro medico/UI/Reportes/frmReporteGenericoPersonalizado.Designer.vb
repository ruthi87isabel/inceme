<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteGenericoPersonalizado
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
        Me.PDPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TopMarginNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.PrintReportButton = New System.Windows.Forms.Button
        Me.RefreshReportButton = New System.Windows.Forms.Button
        Me.PaperComboBox = New System.Windows.Forms.ComboBox
        Me.BottomMarginNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.RightMarginLabel = New System.Windows.Forms.Label
        Me.LeftMarginNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BottomMarginLabel = New System.Windows.Forms.Label
        Me.RightMarginNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LeftMarginLabel = New System.Windows.Forms.Label
        Me.TopMarginLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.TopMarginNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomMarginNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftMarginNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightMarginNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDPrintDocument
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TopMarginNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.PrintReportButton)
        Me.GroupBox1.Controls.Add(Me.RefreshReportButton)
        Me.GroupBox1.Controls.Add(Me.PaperComboBox)
        Me.GroupBox1.Controls.Add(Me.BottomMarginNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RightMarginLabel)
        Me.GroupBox1.Controls.Add(Me.LeftMarginNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.BottomMarginLabel)
        Me.GroupBox1.Controls.Add(Me.RightMarginNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.LeftMarginLabel)
        Me.GroupBox1.Controls.Add(Me.TopMarginLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(767, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 276)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Values"
        '
        'TopMarginNumericUpDown
        '
        Me.TopMarginNumericUpDown.DecimalPlaces = 2
        Me.TopMarginNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.TopMarginNumericUpDown.Location = New System.Drawing.Point(101, 19)
        Me.TopMarginNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.TopMarginNumericUpDown.Name = "TopMarginNumericUpDown"
        Me.TopMarginNumericUpDown.Size = New System.Drawing.Size(81, 20)
        Me.TopMarginNumericUpDown.TabIndex = 2
        Me.TopMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TopMarginNumericUpDown.Value = New Decimal(New Integer() {128, 0, 0, 131072})
        '
        'PrintReportButton
        '
        Me.PrintReportButton.Location = New System.Drawing.Point(66, 218)
        Me.PrintReportButton.Name = "PrintReportButton"
        Me.PrintReportButton.Size = New System.Drawing.Size(116, 46)
        Me.PrintReportButton.TabIndex = 1
        Me.PrintReportButton.Text = "Imprimir"
        Me.PrintReportButton.UseVisualStyleBackColor = True
        '
        'RefreshReportButton
        '
        Me.RefreshReportButton.Location = New System.Drawing.Point(66, 166)
        Me.RefreshReportButton.Name = "RefreshReportButton"
        Me.RefreshReportButton.Size = New System.Drawing.Size(116, 46)
        Me.RefreshReportButton.TabIndex = 1
        Me.RefreshReportButton.Text = "Actualizar Reporte"
        Me.RefreshReportButton.UseVisualStyleBackColor = True
        '
        'PaperComboBox
        '
        Me.PaperComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaperComboBox.FormattingEnabled = True
        Me.PaperComboBox.Items.AddRange(New Object() {"Carta", "Legal", "A4", "8x13", "8x5", "8x8"})
        Me.PaperComboBox.Location = New System.Drawing.Point(102, 123)
        Me.PaperComboBox.Name = "PaperComboBox"
        Me.PaperComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaperComboBox.TabIndex = 4
        '
        'BottomMarginNumericUpDown
        '
        Me.BottomMarginNumericUpDown.DecimalPlaces = 2
        Me.BottomMarginNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.BottomMarginNumericUpDown.Location = New System.Drawing.Point(101, 45)
        Me.BottomMarginNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.BottomMarginNumericUpDown.Name = "BottomMarginNumericUpDown"
        Me.BottomMarginNumericUpDown.Size = New System.Drawing.Size(81, 20)
        Me.BottomMarginNumericUpDown.TabIndex = 2
        Me.BottomMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BottomMarginNumericUpDown.Value = New Decimal(New Integer() {128, 0, 0, 131072})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Papel"
        '
        'RightMarginLabel
        '
        Me.RightMarginLabel.AutoSize = True
        Me.RightMarginLabel.Location = New System.Drawing.Point(10, 99)
        Me.RightMarginLabel.Name = "RightMarginLabel"
        Me.RightMarginLabel.Size = New System.Drawing.Size(86, 13)
        Me.RightMarginLabel.TabIndex = 3
        Me.RightMarginLabel.Text = "Margin Derecho:"
        '
        'LeftMarginNumericUpDown
        '
        Me.LeftMarginNumericUpDown.DecimalPlaces = 2
        Me.LeftMarginNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.LeftMarginNumericUpDown.Location = New System.Drawing.Point(101, 71)
        Me.LeftMarginNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.LeftMarginNumericUpDown.Name = "LeftMarginNumericUpDown"
        Me.LeftMarginNumericUpDown.Size = New System.Drawing.Size(81, 20)
        Me.LeftMarginNumericUpDown.TabIndex = 2
        Me.LeftMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LeftMarginNumericUpDown.Value = New Decimal(New Integer() {128, 0, 0, 131072})
        '
        'BottomMarginLabel
        '
        Me.BottomMarginLabel.AutoSize = True
        Me.BottomMarginLabel.Location = New System.Drawing.Point(16, 47)
        Me.BottomMarginLabel.Name = "BottomMarginLabel"
        Me.BottomMarginLabel.Size = New System.Drawing.Size(81, 13)
        Me.BottomMarginLabel.TabIndex = 3
        Me.BottomMarginLabel.Text = "Margen Inferior:"
        '
        'RightMarginNumericUpDown
        '
        Me.RightMarginNumericUpDown.DecimalPlaces = 2
        Me.RightMarginNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.RightMarginNumericUpDown.Location = New System.Drawing.Point(101, 97)
        Me.RightMarginNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.RightMarginNumericUpDown.Name = "RightMarginNumericUpDown"
        Me.RightMarginNumericUpDown.Size = New System.Drawing.Size(81, 20)
        Me.RightMarginNumericUpDown.TabIndex = 2
        Me.RightMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RightMarginNumericUpDown.Value = New Decimal(New Integer() {128, 0, 0, 131072})
        '
        'LeftMarginLabel
        '
        Me.LeftMarginLabel.AutoSize = True
        Me.LeftMarginLabel.Location = New System.Drawing.Point(8, 73)
        Me.LeftMarginLabel.Name = "LeftMarginLabel"
        Me.LeftMarginLabel.Size = New System.Drawing.Size(92, 13)
        Me.LeftMarginLabel.TabIndex = 3
        Me.LeftMarginLabel.Text = "Margen Izquierdo:"
        '
        'TopMarginLabel
        '
        Me.TopMarginLabel.AutoSize = True
        Me.TopMarginLabel.Location = New System.Drawing.Point(8, 21)
        Me.TopMarginLabel.Name = "TopMarginLabel"
        Me.TopMarginLabel.Size = New System.Drawing.Size(88, 13)
        Me.TopMarginLabel.TabIndex = 3
        Me.TopMarginLabel.Text = "Margen Superior:"
        '
        'frmReporteGenericoPersonalizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReporteGenericoPersonalizado"
        Me.Text = "frmReporteGenericoPersonalizado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TopMarginNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomMarginNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftMarginNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightMarginNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PDPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TopMarginNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents PrintReportButton As System.Windows.Forms.Button
    Friend WithEvents RefreshReportButton As System.Windows.Forms.Button
    Friend WithEvents PaperComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BottomMarginNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RightMarginLabel As System.Windows.Forms.Label
    Friend WithEvents LeftMarginNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BottomMarginLabel As System.Windows.Forms.Label
    Friend WithEvents RightMarginNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeftMarginLabel As System.Windows.Forms.Label
    Friend WithEvents TopMarginLabel As System.Windows.Forms.Label
End Class
