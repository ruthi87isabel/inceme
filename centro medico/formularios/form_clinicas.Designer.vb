<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_clinicas
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim TLFNO1Label As System.Windows.Forms.Label
        Dim TLFNO2Label As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim MAILLabel As System.Windows.Forms.Label
        Dim WEBLabel As System.Windows.Forms.Label
        Dim PERSONACONLabel As System.Windows.Forms.Label
        Me.tb_codigo = New ctrlTextboxAvanzado
        Me.CLINICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_descrip = New ctrlTextboxAvanzado
        Me.tb_direccion = New ctrlTextboxAvanzado
        Me.tb_cp = New ctrlTextboxAvanzado
        Me.tb_poblacion = New ctrlTextboxAvanzado
        Me.tb_provincia = New ctrlTextboxAvanzado
        Me.tb_tel1 = New ctrlTextboxAvanzado
        Me.tb_tel2 = New ctrlTextboxAvanzado
        Me.tb_fax = New ctrlTextboxAvanzado
        Me.tb_mail = New ctrlTextboxAvanzado
        Me.tb_web = New ctrlTextboxAvanzado
        Me.tb_contacto = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.CLINICASTableAdapter = New centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
        Me.DERIVACIONES_DESTINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DERIVACIONES_DESTINOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
        CODIGOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        CPLabel = New System.Windows.Forms.Label
        POBLACIONLabel = New System.Windows.Forms.Label
        PROVINCIALabel = New System.Windows.Forms.Label
        TLFNO1Label = New System.Windows.Forms.Label
        TLFNO2Label = New System.Windows.Forms.Label
        FAXLabel = New System.Windows.Forms.Label
        MAILLabel = New System.Windows.Forms.Label
        WEBLabel = New System.Windows.Forms.Label
        PERSONACONLabel = New System.Windows.Forms.Label
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(8, 13)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "Codigo:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(146, 13)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(8, 61)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 5
        DIRECCIONLabel.Text = "Direccion:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(8, 111)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 7
        CPLabel.Text = "CP:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(110, 111)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(57, 13)
        POBLACIONLabel.TabIndex = 9
        POBLACIONLabel.Text = "Poblacion:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(274, 111)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 11
        PROVINCIALabel.Text = "Provincia:"
        '
        'TLFNO1Label
        '
        TLFNO1Label.AutoSize = True
        TLFNO1Label.Location = New System.Drawing.Point(9, 160)
        TLFNO1Label.Name = "TLFNO1Label"
        TLFNO1Label.Size = New System.Drawing.Size(40, 13)
        TLFNO1Label.TabIndex = 13
        TLFNO1Label.Text = "Tlfno1:"
        '
        'TLFNO2Label
        '
        TLFNO2Label.AutoSize = True
        TLFNO2Label.Location = New System.Drawing.Point(130, 160)
        TLFNO2Label.Name = "TLFNO2Label"
        TLFNO2Label.Size = New System.Drawing.Size(40, 13)
        TLFNO2Label.TabIndex = 15
        TLFNO2Label.Text = "Tlfno2:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(254, 160)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(27, 13)
        FAXLabel.TabIndex = 17
        FAXLabel.Text = "Fax:"
        '
        'MAILLabel
        '
        MAILLabel.AutoSize = True
        MAILLabel.Location = New System.Drawing.Point(9, 208)
        MAILLabel.Name = "MAILLabel"
        MAILLabel.Size = New System.Drawing.Size(37, 13)
        MAILLabel.TabIndex = 19
        MAILLabel.Text = "e-mail:"
        '
        'WEBLabel
        '
        WEBLabel.AutoSize = True
        WEBLabel.Location = New System.Drawing.Point(9, 260)
        WEBLabel.Name = "WEBLabel"
        WEBLabel.Size = New System.Drawing.Size(69, 13)
        WEBLabel.TabIndex = 21
        WEBLabel.Text = "Pagina Web:"
        '
        'PERSONACONLabel
        '
        PERSONACONLabel.AutoSize = True
        PERSONACONLabel.Location = New System.Drawing.Point(181, 208)
        PERSONACONLabel.Name = "PERSONACONLabel"
        PERSONACONLabel.Size = New System.Drawing.Size(94, 13)
        PERSONACONLabel.TabIndex = 23
        PERSONACONLabel.Text = "Persona contacto:"
        '
        'tb_codigo
        '
        Me.tb_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "CODIGO", True))
        Me.tb_codigo.Location = New System.Drawing.Point(11, 29)
        Me.tb_codigo.MaxLength = 12
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(100, 20)
        Me.tb_codigo.TabIndex = 0
        '
        'CLINICASBindingSource
        '
        Me.CLINICASBindingSource.DataMember = "CLINICAS"
        Me.CLINICASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descrip
        '
        Me.tb_descrip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "DESCRIPCION", True))
        Me.tb_descrip.Location = New System.Drawing.Point(149, 29)
        Me.tb_descrip.MaxLength = 120
        Me.tb_descrip.Name = "tb_descrip"
        Me.tb_descrip.Size = New System.Drawing.Size(241, 20)
        Me.tb_descrip.TabIndex = 1
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(11, 77)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(379, 20)
        Me.tb_direccion.TabIndex = 2
        '
        'tb_cp
        '
        Me.tb_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "CP", True))
        Me.tb_cp.Location = New System.Drawing.Point(11, 127)
        Me.tb_cp.MaxLength = 5
        Me.tb_cp.Name = "tb_cp"
        Me.tb_cp.Size = New System.Drawing.Size(85, 20)
        Me.tb_cp.TabIndex = 3
        '
        'tb_poblacion
        '
        Me.tb_poblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "POBLACION", True))
        Me.tb_poblacion.Location = New System.Drawing.Point(113, 127)
        Me.tb_poblacion.MaxLength = 20
        Me.tb_poblacion.Name = "tb_poblacion"
        Me.tb_poblacion.Size = New System.Drawing.Size(137, 20)
        Me.tb_poblacion.TabIndex = 4
        '
        'tb_provincia
        '
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(267, 127)
        Me.tb_provincia.MaxLength = 20
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(123, 20)
        Me.tb_provincia.TabIndex = 5
        '
        'tb_tel1
        '
        Me.tb_tel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "TLFNO1", True))
        Me.tb_tel1.Location = New System.Drawing.Point(12, 176)
        Me.tb_tel1.MaxLength = 10
        Me.tb_tel1.Name = "tb_tel1"
        Me.tb_tel1.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel1.TabIndex = 6
        '
        'tb_tel2
        '
        Me.tb_tel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "TLFNO2", True))
        Me.tb_tel2.Location = New System.Drawing.Point(133, 176)
        Me.tb_tel2.MaxLength = 10
        Me.tb_tel2.Name = "tb_tel2"
        Me.tb_tel2.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel2.TabIndex = 7
        '
        'tb_fax
        '
        Me.tb_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "FAX", True))
        Me.tb_fax.Location = New System.Drawing.Point(257, 176)
        Me.tb_fax.MaxLength = 10
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(100, 20)
        Me.tb_fax.TabIndex = 8
        '
        'tb_mail
        '
        Me.tb_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "MAIL", True))
        Me.tb_mail.Location = New System.Drawing.Point(11, 224)
        Me.tb_mail.MaxLength = 40
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(154, 20)
        Me.tb_mail.TabIndex = 9
        '
        'tb_web
        '
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "WEB", True))
        Me.tb_web.Location = New System.Drawing.Point(12, 276)
        Me.tb_web.MaxLength = 40
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(378, 20)
        Me.tb_web.TabIndex = 11
        '
        'tb_contacto
        '
        Me.tb_contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLINICASBindingSource, "PERSONACON", True))
        Me.tb_contacto.Location = New System.Drawing.Point(184, 224)
        Me.tb_contacto.MaxLength = 40
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.Size = New System.Drawing.Size(206, 20)
        Me.tb_contacto.TabIndex = 10
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(315, 321)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 13
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(233, 321)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CLINICASTableAdapter
        '
        Me.CLINICASTableAdapter.ClearBeforeFill = True
        '
        'DERIVACIONES_DESTINOSBindingSource
        '
        Me.DERIVACIONES_DESTINOSBindingSource.DataMember = "DERIVACIONES_DESTINOS"
        Me.DERIVACIONES_DESTINOSBindingSource.DataSource = Me.CMDataSet
        '
        'DERIVACIONES_DESTINOSTableAdapter
        '
        Me.DERIVACIONES_DESTINOSTableAdapter.ClearBeforeFill = True
        '
        'form_clinicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 356)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descrip)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.tb_direccion)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.tb_cp)
        Me.Controls.Add(POBLACIONLabel)
        Me.Controls.Add(Me.tb_poblacion)
        Me.Controls.Add(PROVINCIALabel)
        Me.Controls.Add(Me.tb_provincia)
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
        Me.Name = "form_clinicas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_clinicas"
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CLINICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLINICASTableAdapter As centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents tb_descrip As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_cp As ctrlTextboxAvanzado
    Friend WithEvents tb_poblacion As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_tel1 As ctrlTextboxAvanzado
    Friend WithEvents tb_tel2 As ctrlTextboxAvanzado
    Friend WithEvents tb_fax As ctrlTextboxAvanzado
    Friend WithEvents tb_mail As ctrlTextboxAvanzado
    Friend WithEvents tb_web As ctrlTextboxAvanzado
    Friend WithEvents tb_contacto As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents DERIVACIONES_DESTINOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONES_DESTINOSTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
End Class
