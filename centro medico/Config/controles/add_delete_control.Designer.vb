<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_delete_control
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
        Dim lb_add_control As System.Windows.Forms.ListBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.panel1 = New System.Windows.Forms.Panel
        Me.bt_delete = New System.Windows.Forms.Button
        Me.bt_add = New System.Windows.Forms.Button
        lb_add_control = New System.Windows.Forms.ListBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_add_control
        '
        lb_add_control.Enabled = False
        lb_add_control.FormattingEnabled = True
        lb_add_control.Location = New System.Drawing.Point(229, 3)
        lb_add_control.Name = "lb_add_control"
        lb_add_control.ScrollAlwaysVisible = True
        lb_add_control.Size = New System.Drawing.Size(196, 225)
        lb_add_control.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(223, 234)
        Me.DataGridView1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.Controls.Add(lb_add_control)
        Me.panel1.Controls.Add(Me.DataGridView1)
        Me.panel1.Controls.Add(Me.bt_delete)
        Me.panel1.Controls.Add(Me.bt_add)
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 266)
        Me.panel1.TabIndex = 1
        '
        'bt_delete
        '
        Me.bt_delete.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_delete.Location = New System.Drawing.Point(188, 240)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(35, 23)
        Me.bt_delete.TabIndex = 3
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_add.Location = New System.Drawing.Point(147, 240)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(35, 23)
        Me.bt_add.TabIndex = 2
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'add_delete_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel1)
        Me.Name = "add_delete_control"
        Me.Size = New System.Drawing.Size(430, 272)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents bt_delete As System.Windows.Forms.Button

End Class
