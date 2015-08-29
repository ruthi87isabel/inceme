<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulo_Almacen_ADD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim StockMinimoLabel As System.Windows.Forms.Label
        Dim StockMaximoLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tb_Ficha = New System.Windows.Forms.TabPage
        Me.StockMinimoTextBox = New ctrlTextboxAvanzado
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.StockMaximoTextBox = New ctrlTextboxAvanzado
        StockMinimoLabel = New System.Windows.Forms.Label
        StockMaximoLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tb_Ficha.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockMinimoLabel
        '
        StockMinimoLabel.AutoSize = True
        StockMinimoLabel.Location = New System.Drawing.Point(33, 41)
        StockMinimoLabel.Name = "StockMinimoLabel"
        StockMinimoLabel.Size = New System.Drawing.Size(74, 13)
        StockMinimoLabel.TabIndex = 0
        StockMinimoLabel.Text = "Stock Minimo:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tb_Ficha)
        Me.TabControl1.Location = New System.Drawing.Point(2, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(224, 158)
        Me.TabControl1.TabIndex = 0
        '
        'tb_Ficha
        '
        Me.tb_Ficha.Controls.Add(StockMaximoLabel)
        Me.tb_Ficha.Controls.Add(Me.StockMaximoTextBox)
        Me.tb_Ficha.Controls.Add(StockMinimoLabel)
        Me.tb_Ficha.Controls.Add(Me.StockMinimoTextBox)
        Me.tb_Ficha.Location = New System.Drawing.Point(4, 22)
        Me.tb_Ficha.Name = "tb_Ficha"
        Me.tb_Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Ficha.Size = New System.Drawing.Size(216, 132)
        Me.tb_Ficha.TabIndex = 0
        Me.tb_Ficha.Text = "Ficha"
        Me.tb_Ficha.UseVisualStyleBackColor = True
        '
        'StockMinimoTextBox
        '
        Me.StockMinimoTextBox.Location = New System.Drawing.Point(113, 38)
        Me.StockMinimoTextBox.Name = "StockMinimoTextBox"
        Me.StockMinimoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.StockMinimoTextBox.TabIndex = 1
        Me.StockMinimoTextBox.Text = "0"
        Me.StockMinimoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(147, 169)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'StockMaximoLabel
        '
        StockMaximoLabel.AutoSize = True
        StockMaximoLabel.Location = New System.Drawing.Point(33, 67)
        StockMaximoLabel.Name = "StockMaximoLabel"
        StockMaximoLabel.Size = New System.Drawing.Size(77, 13)
        StockMaximoLabel.TabIndex = 2
        StockMaximoLabel.Text = "Stock Maximo:"
        '
        'StockMaximoTextBox
        '
        Me.StockMaximoTextBox.Location = New System.Drawing.Point(113, 64)
        Me.StockMaximoTextBox.Name = "StockMaximoTextBox"
        Me.StockMaximoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.StockMaximoTextBox.TabIndex = 3
        Me.StockMaximoTextBox.Text = "0"
        Me.StockMaximoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmArticulo_Almacen_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 198)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmArticulo_Almacen_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacen"
        Me.TabControl1.ResumeLayout(False)
        Me.tb_Ficha.ResumeLayout(False)
        Me.tb_Ficha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_Ficha As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Public WithEvents StockMinimoTextBox As ctrlTextboxAvanzado
    Public WithEvents StockMaximoTextBox As ctrlTextboxAvanzado
End Class
