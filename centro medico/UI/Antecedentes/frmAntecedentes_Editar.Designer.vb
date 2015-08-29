<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAntecedentes_Editar
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
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlDiagnosticosPrincipal = New centro_medico.ctrlDiagnosticos()
        Me.txtObservaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCie10 = New System.Windows.Forms.TextBox()
        Me.AntecedentesDiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2.SuspendLayout()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 107)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 32
        Me.lblObservaciones.Text = "Observaciones"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(626, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "&Cancelar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 236
        Me.Label2.Text = "Diagnóstico"
        '
        'CtrlDiagnosticosPrincipal
        '
        Me.CtrlDiagnosticosPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticosPrincipal.Location = New System.Drawing.Point(81, 30)
        Me.CtrlDiagnosticosPrincipal.Name = "CtrlDiagnosticosPrincipal"
        Me.CtrlDiagnosticosPrincipal.Size = New System.Drawing.Size(533, 25)
        Me.CtrlDiagnosticosPrincipal.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AntecedentesDiagnosticoBindingSource, "OBSERVACIONES", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 123)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(602, 94)
        Me.txtObservaciones.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "CIE10"
        '
        'txtCie10
        '
        Me.txtCie10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AntecedentesDiagnosticoBindingSource, "CIE10", True))
        Me.txtCie10.Location = New System.Drawing.Point(81, 67)
        Me.txtCie10.Name = "txtCie10"
        Me.txtCie10.ReadOnly = True
        Me.txtCie10.Size = New System.Drawing.Size(100, 20)
        Me.txtCie10.TabIndex = 238
        '
        'AntecedentesDiagnosticoBindingSource
        '
        Me.AntecedentesDiagnosticoBindingSource.DataSource = GetType(centro_medico.AntecedentesDiagnostico)
        '
        'frmAntecedentes_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 229)
        Me.Controls.Add(Me.txtCie10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CtrlDiagnosticosPrincipal)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "frmAntecedentes_Editar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedente"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CtrlDiagnosticosPrincipal As centro_medico.ctrlDiagnosticos
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCie10 As System.Windows.Forms.TextBox
    Friend WithEvents AntecedentesDiagnosticoBindingSource As System.Windows.Forms.BindingSource
End Class
