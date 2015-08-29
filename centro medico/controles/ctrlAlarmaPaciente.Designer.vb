<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlAlarmaPaciente
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(107, 27)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "¡PRECAUCIÓN!"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctrlAlarmaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblText)
        Me.Name = "ctrlAlarmaPaciente"
        Me.Size = New System.Drawing.Size(107, 27)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label

End Class
