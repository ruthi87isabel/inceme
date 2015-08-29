<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVisorHistorial
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
        Me.CtrlVisorHistoria1 = New centro_medico.ctrlVisorHistoria
        Me.btCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CtrlVisorHistoria1
        '
        Me.CtrlVisorHistoria1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlVisorHistoria1.BackColor = System.Drawing.Color.LemonChiffon
        Me.CtrlVisorHistoria1.Location = New System.Drawing.Point(3, 4)
        Me.CtrlVisorHistoria1.Name = "CtrlVisorHistoria1"
        Me.CtrlVisorHistoria1.Size = New System.Drawing.Size(479, 533)
        Me.CtrlVisorHistoria1.TabIndex = 0
        '
        'btCerrar
        '
        Me.btCerrar.Location = New System.Drawing.Point(399, 535)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btCerrar.TabIndex = 1
        Me.btCerrar.Text = "Cerrar"
        Me.btCerrar.UseVisualStyleBackColor = True
        '
        'formVisorHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(486, 561)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.CtrlVisorHistoria1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formVisorHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor Historial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlVisorHistoria1 As centro_medico.ctrlVisorHistoria
    Friend WithEvents btCerrar As System.Windows.Forms.Button
End Class
