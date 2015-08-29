<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordenar_columnas
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
        Me.panel_rigth = New System.Windows.Forms.Panel
        Me.bt_down = New System.Windows.Forms.Button
        Me.bt_up = New System.Windows.Forms.Button
        Me.panel_left = New System.Windows.Forms.Panel
        Me.lbx_columnas = New System.Windows.Forms.ListBox
        Me.lb_titulo = New System.Windows.Forms.Label
        Me.panel_rigth.SuspendLayout()
        Me.panel_left.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_rigth
        '
        Me.panel_rigth.Controls.Add(Me.bt_down)
        Me.panel_rigth.Controls.Add(Me.bt_up)
        Me.panel_rigth.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_rigth.Location = New System.Drawing.Point(166, 0)
        Me.panel_rigth.Name = "panel_rigth"
        Me.panel_rigth.Size = New System.Drawing.Size(28, 231)
        Me.panel_rigth.TabIndex = 3
        '
        'bt_down
        '
        Me.bt_down.Image = Global.centro_medico.My.Resources.Resources.down
        Me.bt_down.Location = New System.Drawing.Point(5, 53)
        Me.bt_down.Name = "bt_down"
        Me.bt_down.Size = New System.Drawing.Size(23, 27)
        Me.bt_down.TabIndex = 2
        Me.bt_down.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bt_down.UseVisualStyleBackColor = True
        '
        'bt_up
        '
        Me.bt_up.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_up.Location = New System.Drawing.Point(5, 27)
        Me.bt_up.Name = "bt_up"
        Me.bt_up.Size = New System.Drawing.Size(23, 27)
        Me.bt_up.TabIndex = 1
        Me.bt_up.UseVisualStyleBackColor = True
        '
        'panel_left
        '
        Me.panel_left.Controls.Add(Me.lbx_columnas)
        Me.panel_left.Controls.Add(Me.lb_titulo)
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_left.Location = New System.Drawing.Point(0, 0)
        Me.panel_left.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(166, 231)
        Me.panel_left.TabIndex = 4
        '
        'lbx_columnas
        '
        Me.lbx_columnas.FormattingEnabled = True
        Me.lbx_columnas.Items.AddRange(New Object() {"string 1", "string 2", "string 3", "string 4", "string 5", "string 6", "string 7", "string 8", "string 9", "string 10", "string 11", "string 12"})
        Me.lbx_columnas.Location = New System.Drawing.Point(3, 27)
        Me.lbx_columnas.Name = "lbx_columnas"
        Me.lbx_columnas.Size = New System.Drawing.Size(160, 199)
        Me.lbx_columnas.TabIndex = 1
        '
        'lb_titulo
        '
        Me.lb_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_titulo.Location = New System.Drawing.Point(3, 5)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(160, 18)
        Me.lb_titulo.TabIndex = 0
        Me.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ordenar_columnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_rigth)
        Me.Name = "ordenar_columnas"
        Me.Size = New System.Drawing.Size(194, 231)
        Me.panel_rigth.ResumeLayout(False)
        Me.panel_left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_up As System.Windows.Forms.Button
    Friend WithEvents bt_down As System.Windows.Forms.Button
    Friend WithEvents panel_rigth As System.Windows.Forms.Panel
    Friend WithEvents panel_left As System.Windows.Forms.Panel
    Friend WithEvents lbx_columnas As System.Windows.Forms.ListBox
    Friend WithEvents lb_titulo As System.Windows.Forms.Label

End Class
