<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_listados
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
        Me.Listado_control = New centro_medico.listado_control
        Me.SuspendLayout()
        '
        'Listado_control
        '
        Me.Listado_control.BindingNavigatorSource = Nothing
        Me.Listado_control.CurrentList = centro_medico.RoleManager.Items.Medicos
        Me.Listado_control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Listado_control.GridViewSource = Nothing
        Me.Listado_control.Location = New System.Drawing.Point(0, 0)
        Me.Listado_control.Name = "Listado_control"
        Me.Listado_control.Size = New System.Drawing.Size(905, 497)
        Me.Listado_control.TabIndex = 0
        '
        'form_listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 497)
        Me.Controls.Add(Me.Listado_control)
        Me.Name = "form_listados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Listado_control As centro_medico.listado_control


End Class
