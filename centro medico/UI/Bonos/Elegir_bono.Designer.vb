<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elegir_bono
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Elegir_bono))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tlsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlsCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Notas"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(299, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id"
        '
        'tlsGuardar
        '
        Me.tlsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsGuardar.Image = CType(resources.GetObject("tlsGuardar.Image"), System.Drawing.Image)
        Me.tlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsGuardar.Name = "tlsGuardar"
        Me.tlsGuardar.Size = New System.Drawing.Size(50, 17)
        Me.tlsGuardar.Text = "Guardar"
        Me.tlsGuardar.ToolTipText = "Guardar"
        '
        'tlsCancelar
        '
        Me.tlsCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsCancelar.Image = CType(resources.GetObject("tlsCancelar.Image"), System.Drawing.Image)
        Me.tlsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsCancelar.Name = "tlsCancelar"
        Me.tlsCancelar.Size = New System.Drawing.Size(53, 17)
        Me.tlsCancelar.Text = "Cancelar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsGuardar, Me.tlsCancelar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(323, 20)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Elegir_bono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Elegir_bono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir_bono"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
End Class
