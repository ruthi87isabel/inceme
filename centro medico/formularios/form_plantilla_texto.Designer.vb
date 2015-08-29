<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_plantilla_texto
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
        Me.components = New System.ComponentModel.Container()
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim SECCIONLabel As System.Windows.Forms.Label
        Dim TEXTOLabel As System.Windows.Forms.Label
        Me.tb_descripc = New centro_medico.ctrlTextboxAvanzado()
        Me.PLANTILLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.cb_seccion = New System.Windows.Forms.ComboBox()
        Me.bt_open = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.PLANTILLASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_text = New System.Windows.Forms.TextBox()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        SECCIONLabel = New System.Windows.Forms.Label()
        TEXTOLabel = New System.Windows.Forms.Label()
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(2, 45)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 1
        DESCRIPCIONLabel.Text = "Descripción:"
        '
        'SECCIONLabel
        '
        SECCIONLabel.AutoSize = True
        SECCIONLabel.Location = New System.Drawing.Point(19, 15)
        SECCIONLabel.Name = "SECCIONLabel"
        SECCIONLabel.Size = New System.Drawing.Size(49, 13)
        SECCIONLabel.TabIndex = 3
        SECCIONLabel.Text = "Sección:"
        '
        'TEXTOLabel
        '
        TEXTOLabel.AutoSize = True
        TEXTOLabel.Location = New System.Drawing.Point(12, 83)
        TEXTOLabel.Name = "TEXTOLabel"
        TEXTOLabel.Size = New System.Drawing.Size(37, 13)
        TEXTOLabel.TabIndex = 5
        TEXTOLabel.Text = "Texto:"
        '
        'tb_descripc
        '
        Me.tb_descripc.AcceptsReturn = True
        Me.tb_descripc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_descripc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLASBindingSource, "DESCRIPCION", True))
        Me.tb_descripc.Location = New System.Drawing.Point(74, 42)
        Me.tb_descripc.MaxLength = 90
        Me.tb_descripc.Multiline = True
        Me.tb_descripc.Name = "tb_descripc"
        Me.tb_descripc.Size = New System.Drawing.Size(525, 20)
        Me.tb_descripc.TabIndex = 1
        '
        'PLANTILLASBindingSource
        '
        Me.PLANTILLASBindingSource.DataMember = "PLANTILLAS"
        Me.PLANTILLASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_seccion
        '
        Me.cb_seccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLASBindingSource, "SECCION", True))
        Me.cb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_seccion.FormattingEnabled = True
        Me.cb_seccion.Items.AddRange(New Object() {"General", "Historial-Motivo de consulta", "Historial-Antecedentes", "Historial-Historial", "Historial-Exploración", "Historial-Pruebas complementarias", "Historial-Juicio clínico", "Historial-Tratamiento", "Historial-Observaciones", "Recetas", "EMAIL", "SMS"})
        Me.cb_seccion.Location = New System.Drawing.Point(74, 12)
        Me.cb_seccion.Name = "cb_seccion"
        Me.cb_seccion.Size = New System.Drawing.Size(221, 21)
        Me.cb_seccion.TabIndex = 0
        '
        'bt_open
        '
        Me.bt_open.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_open.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_open.Location = New System.Drawing.Point(215, 420)
        Me.bt_open.Name = "bt_open"
        Me.bt_open.Size = New System.Drawing.Size(30, 23)
        Me.bt_open.TabIndex = 3
        Me.bt_open.UseVisualStyleBackColor = True
        Me.bt_open.Visible = False
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(332, 417)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(251, 417)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'PLANTILLASTableAdapter
        '
        Me.PLANTILLASTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(413, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 346)
        Me.GroupBox1.TabIndex = 227
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leyenda"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(13, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 48)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nota: En el caso de los EMAIL, las etiquetas pueden usarse también en el Asunto"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(3, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "{APELLIDO2} : Apellido 2  (15)"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(2, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "{APELLIDO1} : Apellido 1  (15)"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 49)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "{NOMBRESMS} : Nombre completo en formato ""Ramón G. H"" para reducir consumo caract" & _
    "eres (Max 25)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(13, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "{NOMBRE} : Nombre  (15)"
        '
        'tb_text
        '
        Me.tb_text.AcceptsReturn = True
        Me.tb_text.Location = New System.Drawing.Point(12, 99)
        Me.tb_text.Multiline = True
        Me.tb_text.Name = "tb_text"
        Me.tb_text.Size = New System.Drawing.Size(392, 308)
        Me.tb_text.TabIndex = 2
        '
        'form_plantilla_texto
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(642, 457)
        Me.Controls.Add(Me.tb_text)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_open)
        Me.Controls.Add(TEXTOLabel)
        Me.Controls.Add(SECCIONLabel)
        Me.Controls.Add(Me.cb_seccion)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descripc)
        Me.Name = "form_plantilla_texto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plantillas de Texto"
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PLANTILLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter
    Friend WithEvents tb_descripc As ctrlTextboxAvanzado
    Friend WithEvents cb_seccion As System.Windows.Forms.ComboBox
    Friend WithEvents bt_open As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_text As System.Windows.Forms.TextBox
End Class
