<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_filtro_avanzado
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
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.panel_filtros = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(189, 322)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 2
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(108, 322)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 1
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'panel_filtros
        '
        Me.panel_filtros.AutoScroll = True
        Me.panel_filtros.Location = New System.Drawing.Point(4, 13)
        Me.panel_filtros.Name = "panel_filtros"
        Me.panel_filtros.Size = New System.Drawing.Size(260, 303)
        Me.panel_filtros.TabIndex = 0
        '
        'form_filtro_avanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 356)
        Me.Controls.Add(Me.panel_filtros)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_filtro_avanzado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro compuesto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents panel_filtros As System.Windows.Forms.Panel
End Class
