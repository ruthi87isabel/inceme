<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Splach
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
        Me.pb_imagen = New System.Windows.Forms.PictureBox
        CType(Me.pb_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_imagen
        '
        Me.pb_imagen.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.pb_imagen.Image = Global.centro_medico.My.Resources.Resources.davinci1
        Me.pb_imagen.Location = New System.Drawing.Point(0, 0)
        Me.pb_imagen.Name = "pb_imagen"
        Me.pb_imagen.Size = New System.Drawing.Size(342, 292)
        Me.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_imagen.TabIndex = 2
        Me.pb_imagen.TabStop = False
        '
        'form_Splach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 292)
        Me.Controls.Add(Me.pb_imagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Splach"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_Splach"
        CType(Me.pb_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_imagen As System.Windows.Forms.PictureBox
End Class
