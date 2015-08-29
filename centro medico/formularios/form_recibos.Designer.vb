<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_recibos
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
        Dim FECHAEMISIONLabel As System.Windows.Forms.Label
        Dim COBRADOLabel As System.Windows.Forms.Label
        Dim EMITIDOLabel As System.Windows.Forms.Label
        Dim IMPORTELabel As System.Windows.Forms.Label
        Dim FECHAVENCIMIENTOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim NUMEROLabel As System.Windows.Forms.Label
        Dim CUENTALabel As System.Windows.Forms.Label
        Dim CONCEPTOLabel As System.Windows.Forms.Label
        Dim N19Label As System.Windows.Forms.Label
        Dim TIPOLabel As System.Windows.Forms.Label
        Dim REFFORMAPAGOLabel As System.Windows.Forms.Label
        Dim PACIENTELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_recibos))
        Me.dtp_femision = New System.Windows.Forms.DateTimePicker
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.chb_cobrado = New System.Windows.Forms.CheckBox
        Me.chb_emitido = New System.Windows.Forms.CheckBox
        Me.tb_importe = New ctrlTextboxAvanzado
        Me.dtp_fvencimiento = New System.Windows.Forms.DateTimePicker
        Me.tb_titular = New ctrlTextboxAvanzado
        Me.tb_direccion = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.tb_numero = New ctrlTextboxAvanzado
        Me.tb_concepto = New ctrlTextboxAvanzado
        Me.dtp_fcobro = New System.Windows.Forms.DateTimePicker
        Me.chb_N19 = New System.Windows.Forms.CheckBox
        Me.cb_tipo = New System.Windows.Forms.ComboBox
        Me.lb_forma = New System.Windows.Forms.Label
        Me.bt_forma = New System.Windows.Forms.Button
        Me.tb_idforma = New ctrlTextboxAvanzado
        Me.bt_paciente = New System.Windows.Forms.Button
        Me.tb_idpaciente = New ctrlTextboxAvanzado
        Me.lb_nombre = New System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente
        Me.CtrlCuentaBancaria1 = New centro_medico.ctrlCuentaBancaria
        FECHAEMISIONLabel = New System.Windows.Forms.Label
        COBRADOLabel = New System.Windows.Forms.Label
        EMITIDOLabel = New System.Windows.Forms.Label
        IMPORTELabel = New System.Windows.Forms.Label
        FECHAVENCIMIENTOLabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        NUMEROLabel = New System.Windows.Forms.Label
        CUENTALabel = New System.Windows.Forms.Label
        CONCEPTOLabel = New System.Windows.Forms.Label
        N19Label = New System.Windows.Forms.Label
        TIPOLabel = New System.Windows.Forms.Label
        REFFORMAPAGOLabel = New System.Windows.Forms.Label
        PACIENTELabel = New System.Windows.Forms.Label
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHAEMISIONLabel
        '
        FECHAEMISIONLabel.AutoSize = True
        FECHAEMISIONLabel.Location = New System.Drawing.Point(147, 15)
        FECHAEMISIONLabel.Name = "FECHAEMISIONLabel"
        FECHAEMISIONLabel.Size = New System.Drawing.Size(94, 13)
        FECHAEMISIONLabel.TabIndex = 1
        FECHAEMISIONLabel.Text = "Fecha de Emisión:"
        '
        'COBRADOLabel
        '
        COBRADOLabel.AutoSize = True
        COBRADOLabel.Location = New System.Drawing.Point(147, 57)
        COBRADOLabel.Name = "COBRADOLabel"
        COBRADOLabel.Size = New System.Drawing.Size(50, 13)
        COBRADOLabel.TabIndex = 3
        COBRADOLabel.Text = "Cobrado:"
        '
        'EMITIDOLabel
        '
        EMITIDOLabel.AutoSize = True
        EMITIDOLabel.Location = New System.Drawing.Point(451, 13)
        EMITIDOLabel.Name = "EMITIDOLabel"
        EMITIDOLabel.Size = New System.Drawing.Size(44, 13)
        EMITIDOLabel.TabIndex = 3
        EMITIDOLabel.Text = "Emitido:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(12, 62)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 11
        IMPORTELabel.Text = "Importe:"
        '
        'FECHAVENCIMIENTOLabel
        '
        FECHAVENCIMIENTOLabel.AutoSize = True
        FECHAVENCIMIENTOLabel.Location = New System.Drawing.Point(276, 15)
        FECHAVENCIMIENTOLabel.Name = "FECHAVENCIMIENTOLabel"
        FECHAVENCIMIENTOLabel.Size = New System.Drawing.Size(116, 13)
        FECHAVENCIMIENTOLabel.TabIndex = 15
        FECHAVENCIMIENTOLabel.Text = "Fecha de Vencimiento:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(7, 138)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(93, 13)
        NOMBRELabel.TabIndex = 17
        NOMBRELabel.Text = "Titular del Recibo:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(9, 177)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 19
        DIRECCIONLabel.Text = "Dirección:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(7, 364)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 21
        NOTASLabel.Text = "Notas:"
        '
        'NUMEROLabel
        '
        NUMEROLabel.AutoSize = True
        NUMEROLabel.Location = New System.Drawing.Point(12, 15)
        NUMEROLabel.Name = "NUMEROLabel"
        NUMEROLabel.Size = New System.Drawing.Size(47, 13)
        NUMEROLabel.TabIndex = 23
        NUMEROLabel.Text = "Número:"
        '
        'CUENTALabel
        '
        CUENTALabel.AutoSize = True
        CUENTALabel.Location = New System.Drawing.Point(7, 342)
        CUENTALabel.Name = "CUENTALabel"
        CUENTALabel.Size = New System.Drawing.Size(89, 13)
        CUENTALabel.TabIndex = 33
        CUENTALabel.Text = "Cuenta Bancaria:"
        '
        'CONCEPTOLabel
        '
        CONCEPTOLabel.AutoSize = True
        CONCEPTOLabel.Location = New System.Drawing.Point(7, 280)
        CONCEPTOLabel.Name = "CONCEPTOLabel"
        CONCEPTOLabel.Size = New System.Drawing.Size(56, 13)
        CONCEPTOLabel.TabIndex = 35
        CONCEPTOLabel.Text = "Concepto:"
        '
        'N19Label
        '
        N19Label.AutoSize = True
        N19Label.Location = New System.Drawing.Point(415, 36)
        N19Label.Name = "N19Label"
        N19Label.Size = New System.Drawing.Size(80, 13)
        N19Label.TabIndex = 5
        N19Label.Text = "Generado N19:"
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.Location = New System.Drawing.Point(12, 98)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(68, 13)
        TIPOLabel.TabIndex = 43
        TIPOLabel.Text = "Recibo para:"
        '
        'REFFORMAPAGOLabel
        '
        REFFORMAPAGOLabel.AutoSize = True
        REFFORMAPAGOLabel.Location = New System.Drawing.Point(273, 56)
        REFFORMAPAGOLabel.Name = "REFFORMAPAGOLabel"
        REFFORMAPAGOLabel.Size = New System.Drawing.Size(66, 13)
        REFFORMAPAGOLabel.TabIndex = 80
        REFFORMAPAGOLabel.Text = "Forma pago:"
        '
        'PACIENTELabel
        '
        PACIENTELabel.AutoSize = True
        PACIENTELabel.Location = New System.Drawing.Point(148, 98)
        PACIENTELabel.Name = "PACIENTELabel"
        PACIENTELabel.Size = New System.Drawing.Size(42, 13)
        PACIENTELabel.TabIndex = 88
        PACIENTELabel.Text = "Cliente:"
        '
        'dtp_femision
        '
        Me.dtp_femision.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_femision.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHAEMISION", True))
        Me.dtp_femision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_femision.Location = New System.Drawing.Point(150, 31)
        Me.dtp_femision.Name = "dtp_femision"
        Me.dtp_femision.Size = New System.Drawing.Size(113, 20)
        Me.dtp_femision.TabIndex = 1
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chb_cobrado
        '
        Me.chb_cobrado.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RECIBOSBindingSource, "COBRADO", True))
        Me.chb_cobrado.Location = New System.Drawing.Point(216, 51)
        Me.chb_cobrado.Name = "chb_cobrado"
        Me.chb_cobrado.Size = New System.Drawing.Size(47, 24)
        Me.chb_cobrado.TabIndex = 4
        '
        'chb_emitido
        '
        Me.chb_emitido.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RECIBOSBindingSource, "EMITIDO", True))
        Me.chb_emitido.Location = New System.Drawing.Point(512, 10)
        Me.chb_emitido.Name = "chb_emitido"
        Me.chb_emitido.Size = New System.Drawing.Size(30, 24)
        Me.chb_emitido.TabIndex = 4
        '
        'tb_importe
        '
        Me.tb_importe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "IMPORTE", True))
        Me.tb_importe.Location = New System.Drawing.Point(12, 78)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(112, 20)
        Me.tb_importe.TabIndex = 7
        '
        'dtp_fvencimiento
        '
        Me.dtp_fvencimiento.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fvencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHAVENCIMIENTO", True))
        Me.dtp_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fvencimiento.Location = New System.Drawing.Point(279, 31)
        Me.dtp_fvencimiento.Name = "dtp_fvencimiento"
        Me.dtp_fvencimiento.Size = New System.Drawing.Size(105, 20)
        Me.dtp_fvencimiento.TabIndex = 2
        '
        'tb_titular
        '
        Me.tb_titular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NOMBRE", True))
        Me.tb_titular.Location = New System.Drawing.Point(10, 154)
        Me.tb_titular.Name = "tb_titular"
        Me.tb_titular.Size = New System.Drawing.Size(374, 20)
        Me.tb_titular.TabIndex = 16
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(10, 193)
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(532, 84)
        Me.tb_direccion.TabIndex = 17
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(10, 380)
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(532, 205)
        Me.tb_notas.TabIndex = 23
        '
        'tb_numero
        '
        Me.tb_numero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NUMERO", True))
        Me.tb_numero.Location = New System.Drawing.Point(12, 31)
        Me.tb_numero.Name = "tb_numero"
        Me.tb_numero.ReadOnly = True
        Me.tb_numero.Size = New System.Drawing.Size(112, 20)
        Me.tb_numero.TabIndex = 0
        '
        'tb_concepto
        '
        Me.tb_concepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "CONCEPTO", True))
        Me.tb_concepto.Location = New System.Drawing.Point(10, 296)
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(532, 20)
        Me.tb_concepto.TabIndex = 18
        '
        'dtp_fcobro
        '
        Me.dtp_fcobro.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fcobro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHACOBRO", True))
        Me.dtp_fcobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fcobro.Location = New System.Drawing.Point(150, 77)
        Me.dtp_fcobro.Name = "dtp_fcobro"
        Me.dtp_fcobro.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fcobro.TabIndex = 8
        '
        'chb_N19
        '
        Me.chb_N19.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RECIBOSBindingSource, "N19", True))
        Me.chb_N19.Location = New System.Drawing.Point(512, 31)
        Me.chb_N19.Name = "chb_N19"
        Me.chb_N19.Size = New System.Drawing.Size(30, 24)
        Me.chb_N19.TabIndex = 6
        '
        'cb_tipo
        '
        Me.cb_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "TIPO", True))
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Paciente", "Empresa"})
        Me.cb_tipo.Location = New System.Drawing.Point(10, 114)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(114, 21)
        Me.cb_tipo.TabIndex = 12
        Me.cb_tipo.Text = "Paciente"
        '
        'lb_forma
        '
        Me.lb_forma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_forma.Location = New System.Drawing.Point(390, 77)
        Me.lb_forma.Name = "lb_forma"
        Me.lb_forma.Size = New System.Drawing.Size(152, 20)
        Me.lb_forma.TabIndex = 11
        '
        'bt_forma
        '
        Me.bt_forma.BackgroundImage = CType(resources.GetObject("bt_forma.BackgroundImage"), System.Drawing.Image)
        Me.bt_forma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_forma.Location = New System.Drawing.Point(348, 75)
        Me.bt_forma.Name = "bt_forma"
        Me.bt_forma.Size = New System.Drawing.Size(36, 23)
        Me.bt_forma.TabIndex = 10
        Me.bt_forma.UseVisualStyleBackColor = True
        '
        'tb_idforma
        '
        Me.tb_idforma.BackColor = System.Drawing.Color.White
        Me.tb_idforma.Location = New System.Drawing.Point(276, 77)
        Me.tb_idforma.Name = "tb_idforma"
        Me.tb_idforma.Size = New System.Drawing.Size(75, 20)
        Me.tb_idforma.TabIndex = 9
        '
        'bt_paciente
        '
        Me.bt_paciente.BackgroundImage = CType(resources.GetObject("bt_paciente.BackgroundImage"), System.Drawing.Image)
        Me.bt_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_paciente.Location = New System.Drawing.Point(230, 112)
        Me.bt_paciente.Name = "bt_paciente"
        Me.bt_paciente.Size = New System.Drawing.Size(33, 23)
        Me.bt_paciente.TabIndex = 14
        Me.bt_paciente.UseVisualStyleBackColor = True
        '
        'tb_idpaciente
        '
        Me.tb_idpaciente.BackColor = System.Drawing.Color.White
        Me.tb_idpaciente.Location = New System.Drawing.Point(150, 114)
        Me.tb_idpaciente.Name = "tb_idpaciente"
        Me.tb_idpaciente.Size = New System.Drawing.Size(87, 20)
        Me.tb_idpaciente.TabIndex = 13
        '
        'lb_nombre
        '
        Me.lb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_nombre.Location = New System.Drawing.Point(276, 112)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(266, 20)
        Me.lb_nombre.TabIndex = 15
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(467, 603)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 26
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(385, 603)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 25
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(304, 603)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 24
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.RECIBOSBindingSource, "REFPACIENTE", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(10, 603)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlStatusPaciente1.TabIndex = 89
        '
        'CtrlCuentaBancaria1
        '
        Me.CtrlCuentaBancaria1.Cuenta = "0000000000"
        Me.CtrlCuentaBancaria1.CUENTABANCO = "000000000000000000"
        Me.CtrlCuentaBancaria1.DC = ""
        Me.CtrlCuentaBancaria1.Entidad = "0000"
        Me.CtrlCuentaBancaria1.Location = New System.Drawing.Point(102, 321)
        Me.CtrlCuentaBancaria1.Name = "CtrlCuentaBancaria1"
        Me.CtrlCuentaBancaria1.Oficina = "0000"
        Me.CtrlCuentaBancaria1.Size = New System.Drawing.Size(231, 39)
        Me.CtrlCuentaBancaria1.TabIndex = 90
        '
        'form_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 634)
        Me.Controls.Add(Me.CtrlCuentaBancaria1)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(PACIENTELabel)
        Me.Controls.Add(Me.lb_nombre)
        Me.Controls.Add(Me.bt_paciente)
        Me.Controls.Add(Me.tb_idpaciente)
        Me.Controls.Add(Me.lb_forma)
        Me.Controls.Add(Me.bt_forma)
        Me.Controls.Add(REFFORMAPAGOLabel)
        Me.Controls.Add(Me.tb_idforma)
        Me.Controls.Add(FECHAEMISIONLabel)
        Me.Controls.Add(Me.dtp_femision)
        Me.Controls.Add(COBRADOLabel)
        Me.Controls.Add(Me.chb_cobrado)
        Me.Controls.Add(EMITIDOLabel)
        Me.Controls.Add(Me.chb_emitido)
        Me.Controls.Add(IMPORTELabel)
        Me.Controls.Add(Me.tb_importe)
        Me.Controls.Add(FECHAVENCIMIENTOLabel)
        Me.Controls.Add(Me.dtp_fvencimiento)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.tb_titular)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.tb_direccion)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(NUMEROLabel)
        Me.Controls.Add(Me.tb_numero)
        Me.Controls.Add(CUENTALabel)
        Me.Controls.Add(CONCEPTOLabel)
        Me.Controls.Add(Me.tb_concepto)
        Me.Controls.Add(Me.dtp_fcobro)
        Me.Controls.Add(N19Label)
        Me.Controls.Add(Me.chb_N19)
        Me.Controls.Add(TIPOLabel)
        Me.Controls.Add(Me.cb_tipo)
        Me.Name = "form_recibos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_recibos"
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents dtp_femision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_cobrado As System.Windows.Forms.CheckBox
    Friend WithEvents chb_emitido As System.Windows.Forms.CheckBox
    Friend WithEvents tb_importe As ctrlTextboxAvanzado
    Friend WithEvents dtp_fvencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_titular As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents tb_numero As ctrlTextboxAvanzado
    Friend WithEvents tb_concepto As ctrlTextboxAvanzado
    Friend WithEvents dtp_fcobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_N19 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lb_forma As System.Windows.Forms.Label
    Friend WithEvents bt_forma As System.Windows.Forms.Button
    Friend WithEvents tb_idforma As ctrlTextboxAvanzado
    Friend WithEvents bt_paciente As System.Windows.Forms.Button
    Friend WithEvents tb_idpaciente As ctrlTextboxAvanzado
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents CtrlCuentaBancaria1 As centro_medico.ctrlCuentaBancaria
End Class
