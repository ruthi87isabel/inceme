<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlsTest
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
        Me.CtrlRichTextboxAvanzado1 = New centro_medico.ctrlRichTextboxAvanzado()
        Me.SuspendLayout()
        '
        'CtrlRichTextboxAvanzado1
        '
        Me.CtrlRichTextboxAvanzado1.Location = New System.Drawing.Point(12, 25)
        Me.CtrlRichTextboxAvanzado1.Name = "CtrlRichTextboxAvanzado1"
        Me.CtrlRichTextboxAvanzado1.Size = New System.Drawing.Size(487, 234)
        Me.CtrlRichTextboxAvanzado1.TabIndex = 0
        Me.CtrlRichTextboxAvanzado1.Text = ""
        '
        'frmControlsTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 433)
        Me.Controls.Add(Me.CtrlRichTextboxAvanzado1)
        Me.Name = "frmControlsTest"
        Me.Text = "frmControlsTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlRichTextboxAvanzado1 As centro_medico.ctrlRichTextboxAvanzado

End Class
