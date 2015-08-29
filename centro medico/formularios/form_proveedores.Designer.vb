<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_proveedores
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
        Me.components = New System.ComponentModel.Container
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim TLFNO1Label As System.Windows.Forms.Label
        Dim TLFNO2Label As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim MAILLabel As System.Windows.Forms.Label
        Dim WEBLabel As System.Windows.Forms.Label
        Dim PERSONACONLabel As System.Windows.Forms.Label
        Dim CPROVEEDORLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.lb_datos = New System.Windows.Forms.Label
        Me.tb_nombre = New ctrlTextboxAvanzado
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_direccion = New ctrlTextboxAvanzado
        Me.tb_poblacion = New ctrlTextboxAvanzado
        Me.tb_provincia = New ctrlTextboxAvanzado
        Me.tb_cp = New ctrlTextboxAvanzado
        Me.tb_tel1 = New ctrlTextboxAvanzado
        Me.tb_tel2 = New ctrlTextboxAvanzado
        Me.tb_fax = New ctrlTextboxAvanzado
        Me.tb_mail = New ctrlTextboxAvanzado
        Me.tb_web = New ctrlTextboxAvanzado
        Me.tb_contacto = New ctrlTextboxAvanzado
        Me.tb_cod = New ctrlTextboxAvanzado
        Me.tb_CIF = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.PROVEEDORESTableAdapter = New centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
        NOMBRELabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        POBLACIONLabel = New System.Windows.Forms.Label
        PROVINCIALabel = New System.Windows.Forms.Label
        CPLabel = New System.Windows.Forms.Label
        TLFNO1Label = New System.Windows.Forms.Label
        TLFNO2Label = New System.Windows.Forms.Label
        FAXLabel = New System.Windows.Forms.Label
        MAILLabel = New System.Windows.Forms.Label
        WEBLabel = New System.Windows.Forms.Label
        PERSONACONLabel = New System.Windows.Forms.Label
        CPROVEEDORLabel = New System.Windows.Forms.Label
        CIFLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(161, 28)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(47, 13)
        NOMBRELabel.TabIndex = 31
        NOMBRELabel.Text = "Nombre:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(5, 80)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 33
        DIRECCIONLabel.Text = "Direccion:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(379, 80)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(57, 13)
        POBLACIONLabel.TabIndex = 35
        POBLACIONLabel.Text = "Poblacion:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(2, 134)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 37
        PROVINCIALabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(263, 80)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 39
        CPLabel.Text = "CP:"
        '
        'TLFNO1Label
        '
        TLFNO1Label.AutoSize = True
        TLFNO1Label.Location = New System.Drawing.Point(204, 134)
        TLFNO1Label.Name = "TLFNO1Label"
        TLFNO1Label.Size = New System.Drawing.Size(40, 13)
        TLFNO1Label.TabIndex = 41
        TLFNO1Label.Text = "Tlfno1:"
        '
        'TLFNO2Label
        '
        TLFNO2Label.AutoSize = True
        TLFNO2Label.Location = New System.Drawing.Point(322, 134)
        TLFNO2Label.Name = "TLFNO2Label"
        TLFNO2Label.Size = New System.Drawing.Size(40, 13)
        TLFNO2Label.TabIndex = 43
        TLFNO2Label.Text = "Tlfno2:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(441, 134)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(27, 13)
        FAXLabel.TabIndex = 45
        FAXLabel.Text = "Fax:"
        '
        'MAILLabel
        '
        MAILLabel.AutoSize = True
        MAILLabel.Location = New System.Drawing.Point(263, 184)
        MAILLabel.Name = "MAILLabel"
        MAILLabel.Size = New System.Drawing.Size(29, 13)
        MAILLabel.TabIndex = 47
        MAILLabel.Text = "Mail:"
        '
        'WEBLabel
        '
        WEBLabel.AutoSize = True
        WEBLabel.Location = New System.Drawing.Point(390, 186)
        WEBLabel.Name = "WEBLabel"
        WEBLabel.Size = New System.Drawing.Size(33, 13)
        WEBLabel.TabIndex = 49
        WEBLabel.Text = "Web:"
        '
        'PERSONACONLabel
        '
        PERSONACONLabel.AutoSize = True
        PERSONACONLabel.Location = New System.Drawing.Point(2, 184)
        PERSONACONLabel.Name = "PERSONACONLabel"
        PERSONACONLabel.Size = New System.Drawing.Size(94, 13)
        PERSONACONLabel.TabIndex = 51
        PERSONACONLabel.Text = "Persona contacto:"
        '
        'CPROVEEDORLabel
        '
        CPROVEEDORLabel.AutoSize = True
        CPROVEEDORLabel.Location = New System.Drawing.Point(5, 28)
        CPROVEEDORLabel.Name = "CPROVEEDORLabel"
        CPROVEEDORLabel.Size = New System.Drawing.Size(43, 13)
        CPROVEEDORLabel.TabIndex = 53
        CPROVEEDORLabel.Text = "Codigo:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(457, 28)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(26, 13)
        CIFLabel.TabIndex = 55
        CIFLabel.Text = "CIF:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(2, 245)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 56
        NOTASLabel.Text = "Notas:"
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(5, 4)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(569, 19)
        Me.lb_datos.TabIndex = 30
        Me.lb_datos.Text = "Datos Básicos del proveedor"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_nombre
        '
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(150, 44)
        Me.tb_nombre.MaxLength = 40
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(258, 20)
        Me.tb_nombre.TabIndex = 1
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(5, 96)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(224, 20)
        Me.tb_direccion.TabIndex = 3
        '
        'tb_poblacion
        '
        Me.tb_poblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "POBLACION", True))
        Me.tb_poblacion.Location = New System.Drawing.Point(382, 96)
        Me.tb_poblacion.MaxLength = 20
        Me.tb_poblacion.Name = "tb_poblacion"
        Me.tb_poblacion.Size = New System.Drawing.Size(192, 20)
        Me.tb_poblacion.TabIndex = 5
        '
        'tb_provincia
        '
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(5, 150)
        Me.tb_provincia.MaxLength = 20
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(183, 20)
        Me.tb_provincia.TabIndex = 6
        '
        'tb_cp
        '
        Me.tb_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "CP", True))
        Me.tb_cp.Location = New System.Drawing.Point(257, 96)
        Me.tb_cp.MaxLength = 5
        Me.tb_cp.Name = "tb_cp"
        Me.tb_cp.Size = New System.Drawing.Size(100, 20)
        Me.tb_cp.TabIndex = 4
        '
        'tb_tel1
        '
        Me.tb_tel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "TLFNO1", True))
        Me.tb_tel1.Location = New System.Drawing.Point(207, 150)
        Me.tb_tel1.MaxLength = 10
        Me.tb_tel1.Name = "tb_tel1"
        Me.tb_tel1.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel1.TabIndex = 7
        '
        'tb_tel2
        '
        Me.tb_tel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "TLFNO2", True))
        Me.tb_tel2.Location = New System.Drawing.Point(325, 150)
        Me.tb_tel2.MaxLength = 10
        Me.tb_tel2.Name = "tb_tel2"
        Me.tb_tel2.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel2.TabIndex = 8
        '
        'tb_fax
        '
        Me.tb_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "FAX", True))
        Me.tb_fax.Location = New System.Drawing.Point(439, 150)
        Me.tb_fax.MaxLength = 10
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(135, 20)
        Me.tb_fax.TabIndex = 9
        '
        'tb_mail
        '
        Me.tb_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "MAIL", True))
        Me.tb_mail.Location = New System.Drawing.Point(257, 202)
        Me.tb_mail.MaxLength = 40
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(100, 20)
        Me.tb_mail.TabIndex = 11
        '
        'tb_web
        '
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "WEB", True))
        Me.tb_web.Location = New System.Drawing.Point(382, 202)
        Me.tb_web.MaxLength = 40
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(192, 20)
        Me.tb_web.TabIndex = 12
        '
        'tb_contacto
        '
        Me.tb_contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "PERSONACON", True))
        Me.tb_contacto.Location = New System.Drawing.Point(5, 202)
        Me.tb_contacto.MaxLength = 40
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.Size = New System.Drawing.Size(224, 20)
        Me.tb_contacto.TabIndex = 10
        '
        'tb_cod
        '
        Me.tb_cod.BackColor = System.Drawing.Color.White
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "CPROVEEDOR", True))
        Me.tb_cod.Location = New System.Drawing.Point(5, 44)
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(100, 20)
        Me.tb_cod.TabIndex = 0
        '
        'tb_CIF
        '
        Me.tb_CIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "CIF", True))
        Me.tb_CIF.Location = New System.Drawing.Point(451, 44)
        Me.tb_CIF.MaxLength = 9
        Me.tb_CIF.Name = "tb_CIF"
        Me.tb_CIF.Size = New System.Drawing.Size(123, 20)
        Me.tb_CIF.TabIndex = 2
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(5, 261)
        Me.tb_notas.MaxLength = 150
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(562, 125)
        Me.tb_notas.TabIndex = 13
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(492, 394)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 15
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(398, 394)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 14
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'form_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 428)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.tb_nombre)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.tb_direccion)
        Me.Controls.Add(POBLACIONLabel)
        Me.Controls.Add(Me.tb_poblacion)
        Me.Controls.Add(PROVINCIALabel)
        Me.Controls.Add(Me.tb_provincia)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.tb_cp)
        Me.Controls.Add(TLFNO1Label)
        Me.Controls.Add(Me.tb_tel1)
        Me.Controls.Add(TLFNO2Label)
        Me.Controls.Add(Me.tb_tel2)
        Me.Controls.Add(FAXLabel)
        Me.Controls.Add(Me.tb_fax)
        Me.Controls.Add(MAILLabel)
        Me.Controls.Add(Me.tb_mail)
        Me.Controls.Add(WEBLabel)
        Me.Controls.Add(Me.tb_web)
        Me.Controls.Add(PERSONACONLabel)
        Me.Controls.Add(Me.tb_contacto)
        Me.Controls.Add(CPROVEEDORLabel)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(CIFLabel)
        Me.Controls.Add(Me.tb_CIF)
        Me.Controls.Add(Me.lb_datos)
        Me.Name = "form_proveedores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_proveedores"
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_poblacion As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_cp As ctrlTextboxAvanzado
    Friend WithEvents tb_tel1 As ctrlTextboxAvanzado
    Friend WithEvents tb_tel2 As ctrlTextboxAvanzado
    Friend WithEvents tb_fax As ctrlTextboxAvanzado
    Friend WithEvents tb_mail As ctrlTextboxAvanzado
    Friend WithEvents tb_web As ctrlTextboxAvanzado
    Friend WithEvents tb_contacto As ctrlTextboxAvanzado
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_CIF As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
