<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlColumnas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbxColumnas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbxColumnas
        '
        Me.lbxColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxColumnas.FormattingEnabled = True
        Me.lbxColumnas.HorizontalScrollbar = True
        Me.lbxColumnas.Location = New System.Drawing.Point(0, 0)
        Me.lbxColumnas.Name = "lbxColumnas"
        Me.lbxColumnas.Size = New System.Drawing.Size(169, 227)
        Me.lbxColumnas.TabIndex = 0
        '
        'ctrlColumnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.lbxColumnas)
        Me.Name = "ctrlColumnas"
        Me.Size = New System.Drawing.Size(169, 227)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxColumnas As System.Windows.Forms.ListBox

End Class
