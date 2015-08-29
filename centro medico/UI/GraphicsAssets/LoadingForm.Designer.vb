<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.linkCancel = New System.Windows.Forms.LinkLabel()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Procesando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(5, 12)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(39, 35)
        Me.pb_Loading.TabIndex = 120
        Me.pb_Loading.TabStop = False
        '
        'linkCancel
        '
        Me.linkCancel.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkCancel.AutoSize = True
        Me.linkCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkCancel.LinkColor = System.Drawing.Color.Blue
        Me.linkCancel.Location = New System.Drawing.Point(50, 33)
        Me.linkCancel.Name = "linkCancel"
        Me.linkCancel.Size = New System.Drawing.Size(49, 13)
        Me.linkCancel.TabIndex = 122
        Me.linkCancel.TabStop = True
        Me.linkCancel.Text = "Cancelar"
        Me.linkCancel.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(164, 55)
        Me.Controls.Add(Me.linkCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pb_Loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingForm"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents linkCancel As System.Windows.Forms.LinkLabel
End Class
