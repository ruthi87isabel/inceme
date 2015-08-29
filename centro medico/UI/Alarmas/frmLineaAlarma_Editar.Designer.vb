<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineaAlarma_Editar
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
        Me.components = New System.ComponentModel.Container()
        Me.EditDescripcionAlarma = New centro_medico.ctrlTextboxAvanzado()
        Me.LINEAALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlAlarma1 = New centro_medico.ctrlAlarma()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.LINEAALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditDescripcionAlarma
        '
        Me.EditDescripcionAlarma.AcceptsReturn = True
        Me.EditDescripcionAlarma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditDescripcionAlarma.BackColor = System.Drawing.SystemColors.Window
        Me.EditDescripcionAlarma.Location = New System.Drawing.Point(12, 53)
        Me.EditDescripcionAlarma.Multiline = True
        Me.EditDescripcionAlarma.Name = "EditDescripcionAlarma"
        Me.EditDescripcionAlarma.Size = New System.Drawing.Size(375, 190)
        Me.EditDescripcionAlarma.TabIndex = 55
        '
        'LINEAALARMABindingSource
        '
        Me.LINEAALARMABindingSource.DataSource = GetType(centro_medico.LINEASALARMA)
        '
        'CtrlAlarma1
        '
        Me.CtrlAlarma1.DataBindings.Add(New System.Windows.Forms.Binding("ID_ALARMA", Me.LINEAALARMABindingSource, "REFALARMA", True))
        Me.CtrlAlarma1.ID_ALARMA = Nothing
        Me.CtrlAlarma1.Location = New System.Drawing.Point(54, 26)
        Me.CtrlAlarma1.Name = "CtrlAlarma1"
        Me.CtrlAlarma1.Size = New System.Drawing.Size(333, 21)
        Me.CtrlAlarma1.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Alarma"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(399, 25)
        Me.ToolStrip2.TabIndex = 58
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'frmLineaAlarma_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 255)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CtrlAlarma1)
        Me.Controls.Add(Me.EditDescripcionAlarma)
        Me.Name = "frmLineaAlarma_Editar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarma"
        CType(Me.LINEAALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditDescripcionAlarma As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents CtrlAlarma1 As centro_medico.ctrlAlarma
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents LINEAALARMABindingSource As System.Windows.Forms.BindingSource
End Class
