<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class columna_simple
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lb_texto = New System.Windows.Forms.Label
        Me.chb_filtro = New System.Windows.Forms.CheckBox
        Me.chb_visible = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'lb_texto
        '
        Me.lb_texto.AutoSize = True
        Me.lb_texto.Location = New System.Drawing.Point(9, 7)
        Me.lb_texto.Name = "lb_texto"
        Me.lb_texto.Size = New System.Drawing.Size(39, 13)
        Me.lb_texto.TabIndex = 1
        Me.lb_texto.Text = "Label2"
        '
        'chb_filtro
        '
        Me.chb_filtro.AutoSize = True
        Me.chb_filtro.Location = New System.Drawing.Point(204, 8)
        Me.chb_filtro.Name = "chb_filtro"
        Me.chb_filtro.Size = New System.Drawing.Size(94, 17)
        Me.chb_filtro.TabIndex = 3
        Me.chb_filtro.Text = "Orden/Filtrado"
        Me.chb_filtro.UseVisualStyleBackColor = True
        '
        'chb_visible
        '
        Me.chb_visible.AutoSize = True
        Me.chb_visible.Location = New System.Drawing.Point(142, 7)
        Me.chb_visible.Name = "chb_visible"
        Me.chb_visible.Size = New System.Drawing.Size(56, 17)
        Me.chb_visible.TabIndex = 2
        Me.chb_visible.Text = "Visible"
        Me.chb_visible.UseVisualStyleBackColor = True
        '
        'columna_simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.chb_visible)
        Me.Controls.Add(Me.chb_filtro)
        Me.Controls.Add(Me.lb_texto)
        Me.Controls.Add(Me.Label1)
        Me.name = "columna_simple"
        Me.Size = New System.Drawing.Size(300, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_texto As System.Windows.Forms.Label
    Friend WithEvents chb_filtro As System.Windows.Forms.CheckBox
    Friend WithEvents chb_visible As System.Windows.Forms.CheckBox

End Class
