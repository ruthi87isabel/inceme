<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Add_AntecedentesDiagnostico
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
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.txtDiagnostico = New centro_medico.ctrlTextboxAvanzado()
        Me.lbDiagnostico = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCIE10 = New centro_medico.ctrlTextboxAvanzado()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DiagnosticosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DiagnosticosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip2.TabIndex = 19
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
        'txtDiagnostico
        '
        Me.txtDiagnostico.AcceptsReturn = True
        Me.txtDiagnostico.Location = New System.Drawing.Point(103, 42)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.ReadOnly = True
        Me.txtDiagnostico.Size = New System.Drawing.Size(249, 20)
        Me.txtDiagnostico.TabIndex = 20
        '
        'lbDiagnostico
        '
        Me.lbDiagnostico.AutoSize = True
        Me.lbDiagnostico.Location = New System.Drawing.Point(19, 45)
        Me.lbDiagnostico.Name = "lbDiagnostico"
        Me.lbDiagnostico.Size = New System.Drawing.Size(63, 13)
        Me.lbDiagnostico.TabIndex = 21
        Me.lbDiagnostico.Text = "Diagnostico"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(19, 78)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 23
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.Location = New System.Drawing.Point(103, 75)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(413, 86)
        Me.txtObservaciones.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CIE10"
        '
        'txtCIE10
        '
        Me.txtCIE10.AcceptsReturn = True
        Me.txtCIE10.Location = New System.Drawing.Point(429, 42)
        Me.txtCIE10.Name = "txtCIE10"
        Me.txtCIE10.ReadOnly = True
        Me.txtCIE10.Size = New System.Drawing.Size(87, 20)
        Me.txtCIE10.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 174)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(535, 22)
        Me.StatusStrip1.TabIndex = 26
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Alt + G -> Guardar"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(109, 17)
        Me.ToolStripStatusLabel2.Text = "Alt + C -> Cancelar"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.Button1.Location = New System.Drawing.Point(354, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DiagnosticosBindingSource1
        '
        Me.DiagnosticosBindingSource1.DataMember = "DIAGNOSTICOS"
        Me.DiagnosticosBindingSource1.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'form_Add_AntecedentesDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 196)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCIE10)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lbDiagnostico)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.ToolStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "form_Add_AntecedentesDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añade diagnóstico a Antecedentes Médicos"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DiagnosticosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDiagnostico As ctrlTextboxAvanzado
    Friend WithEvents lbDiagnostico As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCIE10 As ctrlTextboxAvanzado
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DiagnosticosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
End Class
