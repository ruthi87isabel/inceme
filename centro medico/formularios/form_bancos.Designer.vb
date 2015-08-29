<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_bancos
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
        Dim LOCALIDADLabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim TLFNO1Label As System.Windows.Forms.Label
        Dim TLFNO2Label As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim ENTIDADLabel As System.Windows.Forms.Label
        Dim OFICINALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim WEBLabel As System.Windows.Forms.Label
        Me.tb_nombre = New ctrlTextboxAvanzado
        Me.BANCOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_direccion = New ctrlTextboxAvanzado
        Me.tb_localidad = New ctrlTextboxAvanzado
        Me.tb_provincia = New ctrlTextboxAvanzado
        Me.tb_cp = New ctrlTextboxAvanzado
        Me.tb_tel1 = New ctrlTextboxAvanzado
        Me.tb_tel2 = New ctrlTextboxAvanzado
        Me.tb_fax = New ctrlTextboxAvanzado
        Me.tb_entidad = New ctrlTextboxAvanzado
        Me.tb_oficina = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.tb_mail = New ctrlTextboxAvanzado
        Me.tb_web = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.BANCOSTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
        NOMBRELabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        LOCALIDADLabel = New System.Windows.Forms.Label
        PROVINCIALabel = New System.Windows.Forms.Label
        CPLabel = New System.Windows.Forms.Label
        TLFNO1Label = New System.Windows.Forms.Label
        TLFNO2Label = New System.Windows.Forms.Label
        FAXLabel = New System.Windows.Forms.Label
        ENTIDADLabel = New System.Windows.Forms.Label
        OFICINALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        EMAILLabel = New System.Windows.Forms.Label
        WEBLabel = New System.Windows.Forms.Label
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(215, 9)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(47, 13)
        NOMBRELabel.TabIndex = 1
        NOMBRELabel.Text = "Nombre:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(12, 60)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 3
        DIRECCIONLabel.Text = "Dirección:"
        '
        'LOCALIDADLabel
        '
        LOCALIDADLabel.AutoSize = True
        LOCALIDADLabel.Location = New System.Drawing.Point(12, 112)
        LOCALIDADLabel.Name = "LOCALIDADLabel"
        LOCALIDADLabel.Size = New System.Drawing.Size(56, 13)
        LOCALIDADLabel.TabIndex = 5
        LOCALIDADLabel.Text = "Localidad:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(221, 112)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 7
        PROVINCIALabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(315, 60)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 9
        CPLabel.Text = "CP:"
        '
        'TLFNO1Label
        '
        TLFNO1Label.AutoSize = True
        TLFNO1Label.Location = New System.Drawing.Point(12, 164)
        TLFNO1Label.Name = "TLFNO1Label"
        TLFNO1Label.Size = New System.Drawing.Size(40, 13)
        TLFNO1Label.TabIndex = 11
        TLFNO1Label.Text = "Tlfno1:"
        '
        'TLFNO2Label
        '
        TLFNO2Label.AutoSize = True
        TLFNO2Label.Location = New System.Drawing.Point(145, 164)
        TLFNO2Label.Name = "TLFNO2Label"
        TLFNO2Label.Size = New System.Drawing.Size(40, 13)
        TLFNO2Label.TabIndex = 13
        TLFNO2Label.Text = "Tlfno2:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(309, 164)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(27, 13)
        FAXLabel.TabIndex = 15
        FAXLabel.Text = "Fax:"
        '
        'ENTIDADLabel
        '
        ENTIDADLabel.AutoSize = True
        ENTIDADLabel.Location = New System.Drawing.Point(12, 9)
        ENTIDADLabel.Name = "ENTIDADLabel"
        ENTIDADLabel.Size = New System.Drawing.Size(46, 13)
        ENTIDADLabel.TabIndex = 17
        ENTIDADLabel.Text = "Entidad:"
        '
        'OFICINALabel
        '
        OFICINALabel.AutoSize = True
        OFICINALabel.Location = New System.Drawing.Point(117, 9)
        OFICINALabel.Name = "OFICINALabel"
        OFICINALabel.Size = New System.Drawing.Size(43, 13)
        OFICINALabel.TabIndex = 19
        OFICINALabel.Text = "Oficina:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(12, 310)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 21
        NOTASLabel.Text = "Notas:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(12, 262)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(38, 13)
        EMAILLabel.TabIndex = 23
        EMAILLabel.Text = "E-mail:"
        '
        'WEBLabel
        '
        WEBLabel.AutoSize = True
        WEBLabel.Location = New System.Drawing.Point(12, 214)
        WEBLabel.Name = "WEBLabel"
        WEBLabel.Size = New System.Drawing.Size(66, 13)
        WEBLabel.TabIndex = 25
        WEBLabel.Text = "Página web:"
        '
        'tb_nombre
        '
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(208, 25)
        Me.tb_nombre.MaxLength = 60
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(184, 20)
        Me.tb_nombre.TabIndex = 2
        '
        'BANCOSBindingSource
        '
        Me.BANCOSBindingSource.DataMember = "BANCOS"
        Me.BANCOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(12, 76)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(269, 20)
        Me.tb_direccion.TabIndex = 3
        '
        'tb_localidad
        '
        Me.tb_localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "LOCALIDAD", True))
        Me.tb_localidad.Location = New System.Drawing.Point(15, 131)
        Me.tb_localidad.MaxLength = 60
        Me.tb_localidad.Name = "tb_localidad"
        Me.tb_localidad.Size = New System.Drawing.Size(190, 20)
        Me.tb_localidad.TabIndex = 5
        '
        'tb_provincia
        '
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(224, 131)
        Me.tb_provincia.MaxLength = 60
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(168, 20)
        Me.tb_provincia.TabIndex = 6
        '
        'tb_cp
        '
        Me.tb_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "CP", True))
        Me.tb_cp.Location = New System.Drawing.Point(301, 76)
        Me.tb_cp.MaxLength = 5
        Me.tb_cp.Name = "tb_cp"
        Me.tb_cp.Size = New System.Drawing.Size(91, 20)
        Me.tb_cp.TabIndex = 4
        '
        'tb_tel1
        '
        Me.tb_tel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "TLFNO1", True))
        Me.tb_tel1.Location = New System.Drawing.Point(15, 180)
        Me.tb_tel1.MaxLength = 12
        Me.tb_tel1.Name = "tb_tel1"
        Me.tb_tel1.Size = New System.Drawing.Size(110, 20)
        Me.tb_tel1.TabIndex = 7
        '
        'tb_tel2
        '
        Me.tb_tel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "TLFNO2", True))
        Me.tb_tel2.Location = New System.Drawing.Point(148, 180)
        Me.tb_tel2.MaxLength = 12
        Me.tb_tel2.Name = "tb_tel2"
        Me.tb_tel2.Size = New System.Drawing.Size(114, 20)
        Me.tb_tel2.TabIndex = 8
        '
        'tb_fax
        '
        Me.tb_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "FAX", True))
        Me.tb_fax.Location = New System.Drawing.Point(281, 180)
        Me.tb_fax.MaxLength = 12
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(111, 20)
        Me.tb_fax.TabIndex = 9
        '
        'tb_entidad
        '
        Me.tb_entidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "ENTIDAD", True))
        Me.tb_entidad.Location = New System.Drawing.Point(12, 25)
        Me.tb_entidad.MaxLength = 4
        Me.tb_entidad.Name = "tb_entidad"
        Me.tb_entidad.Size = New System.Drawing.Size(70, 20)
        Me.tb_entidad.TabIndex = 0
        '
        'tb_oficina
        '
        Me.tb_oficina.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "OFICINA", True))
        Me.tb_oficina.Location = New System.Drawing.Point(108, 25)
        Me.tb_oficina.MaxLength = 4
        Me.tb_oficina.Name = "tb_oficina"
        Me.tb_oficina.Size = New System.Drawing.Size(77, 20)
        Me.tb_oficina.TabIndex = 1
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(12, 326)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(380, 100)
        Me.tb_notas.TabIndex = 12
        '
        'tb_mail
        '
        Me.tb_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "EMAIL", True))
        Me.tb_mail.Location = New System.Drawing.Point(15, 278)
        Me.tb_mail.MaxLength = 100
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(377, 20)
        Me.tb_mail.TabIndex = 11
        '
        'tb_web
        '
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BANCOSBindingSource, "WEB", True))
        Me.tb_web.Location = New System.Drawing.Point(15, 230)
        Me.tb_web.MaxLength = 100
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(377, 20)
        Me.tb_web.TabIndex = 10
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(318, 439)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 14
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(224, 439)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 13
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'BANCOSTableAdapter
        '
        Me.BANCOSTableAdapter.ClearBeforeFill = True
        '
        'form_bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 474)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.tb_nombre)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.tb_direccion)
        Me.Controls.Add(LOCALIDADLabel)
        Me.Controls.Add(Me.tb_localidad)
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
        Me.Controls.Add(ENTIDADLabel)
        Me.Controls.Add(Me.tb_entidad)
        Me.Controls.Add(OFICINALabel)
        Me.Controls.Add(Me.tb_oficina)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.tb_mail)
        Me.Controls.Add(WEBLabel)
        Me.Controls.Add(Me.tb_web)
        Me.Name = "form_bancos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_bancos"
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents BANCOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_localidad As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_cp As ctrlTextboxAvanzado
    Friend WithEvents tb_tel1 As ctrlTextboxAvanzado
    Friend WithEvents tb_tel2 As ctrlTextboxAvanzado
    Friend WithEvents tb_fax As ctrlTextboxAvanzado
    Friend WithEvents tb_entidad As ctrlTextboxAvanzado
    Friend WithEvents tb_oficina As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents tb_mail As ctrlTextboxAvanzado
    Friend WithEvents tb_web As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
