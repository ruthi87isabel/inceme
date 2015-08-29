Imports centro_medico
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasM_ADD
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
        Dim FEMISIONLabel As System.Windows.Forms.Label
        Dim NUMEROFACTURALabel As System.Windows.Forms.Label
        Dim FALTALabel As System.Windows.Forms.Label
        Dim FBAJALabel As System.Windows.Forms.Label
        Dim HORALabel As System.Windows.Forms.Label
        Dim FACCIDENTELabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim LOCALIDADLabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim TOTALLabel As System.Windows.Forms.Label
        Dim PORCENTAJEIRPFLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim GridEXLineas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasM_ADD))
        Dim GridEXDesglose_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.FACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpDatosPaciente = New System.Windows.Forms.GroupBox()
        Me.lb_dpLetradni = New System.Windows.Forms.Label()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        Me.MaskedEditBox3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDNI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.CtrlDiagnosticos1 = New centro_medico.ctrlDiagnosticos()
        Me.txtNie = New centro_medico.ctrlTextboxAvanzado()
        Me.txtPasaporte = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_localidad = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_provincia = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_direccion = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.dtp_femision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.dtp_falta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fbaja = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fasistencia = New System.Windows.Forms.DateTimePicker()
        Me.chb_recibo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pb_UndoCobrar = New System.Windows.Forms.PictureBox()
        Me.chk_pagada = New System.Windows.Forms.CheckBox()
        Me.combo_FechaEnvio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cb_pagada = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtp_Hora = New System.Windows.Forms.DateTimePicker()
        Me.SERIESComboBox = New System.Windows.Forms.ComboBox()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.tb_nro = New centro_medico.ctrlTextboxAvanzado()
        Me.GridEXLineas = New Janus.Windows.GridEX.GridEX()
        Me.LINEASFACTURAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_ADD = New System.Windows.Forms.Button()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.bt_facturar = New System.Windows.Forms.Button()
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtIRPFImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtImporteLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtIRPFPorciento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.GridEXDesglose = New Janus.Windows.GridEX.GridEX()
        Me.txtTotalIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        Me.btnFacturaE = New System.Windows.Forms.Button()
        FEMISIONLabel = New System.Windows.Forms.Label()
        NUMEROFACTURALabel = New System.Windows.Forms.Label()
        FALTALabel = New System.Windows.Forms.Label()
        FBAJALabel = New System.Windows.Forms.Label()
        HORALabel = New System.Windows.Forms.Label()
        FACCIDENTELabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        LOCALIDADLabel = New System.Windows.Forms.Label()
        PROVINCIALabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        TOTALLabel = New System.Windows.Forms.Label()
        PORCENTAJEIRPFLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosPaciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASFACTURAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXDesglose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FEMISIONLabel
        '
        FEMISIONLabel.AutoSize = True
        FEMISIONLabel.Location = New System.Drawing.Point(424, 18)
        FEMISIONLabel.Name = "FEMISIONLabel"
        FEMISIONLabel.Size = New System.Drawing.Size(94, 13)
        FEMISIONLabel.TabIndex = 81
        FEMISIONLabel.Text = "Fecha de Emision:"
        '
        'NUMEROFACTURALabel
        '
        NUMEROFACTURALabel.AutoSize = True
        NUMEROFACTURALabel.Location = New System.Drawing.Point(21, 20)
        NUMEROFACTURALabel.Name = "NUMEROFACTURALabel"
        NUMEROFACTURALabel.Size = New System.Drawing.Size(63, 13)
        NUMEROFACTURALabel.TabIndex = 79
        NUMEROFACTURALabel.Text = "Nro Factura"
        '
        'FALTALabel
        '
        FALTALabel.AutoSize = True
        FALTALabel.Location = New System.Drawing.Point(700, 59)
        FALTALabel.Name = "FALTALabel"
        FALTALabel.Size = New System.Drawing.Size(37, 13)
        FALTALabel.TabIndex = 32
        FALTALabel.Text = "F.Alta:"
        '
        'FBAJALabel
        '
        FBAJALabel.AutoSize = True
        FBAJALabel.Location = New System.Drawing.Point(566, 59)
        FBAJALabel.Name = "FBAJALabel"
        FBAJALabel.Size = New System.Drawing.Size(40, 13)
        FBAJALabel.TabIndex = 29
        FBAJALabel.Text = "F.Baja:"
        '
        'HORALabel
        '
        HORALabel.AutoSize = True
        HORALabel.Location = New System.Drawing.Point(700, 19)
        HORALabel.Name = "HORALabel"
        HORALabel.Size = New System.Drawing.Size(33, 13)
        HORALabel.TabIndex = 26
        HORALabel.Text = "Hora:"
        '
        'FACCIDENTELabel
        '
        FACCIDENTELabel.AutoSize = True
        FACCIDENTELabel.Location = New System.Drawing.Point(566, 18)
        FACCIDENTELabel.Name = "FACCIDENTELabel"
        FACCIDENTELabel.Size = New System.Drawing.Size(123, 13)
        FACCIDENTELabel.TabIndex = 27
        FACCIDENTELabel.Text = "F. Accidente/Asistencia:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(424, 57)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 89
        Label3.Text = "Cobrada"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(520, 112)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 98
        DNILabel.Text = "DNI:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(10, 85)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 45
        DIRECCIONLabel.Text = "Direccion:"
        '
        'LOCALIDADLabel
        '
        LOCALIDADLabel.AutoSize = True
        LOCALIDADLabel.Location = New System.Drawing.Point(9, 107)
        LOCALIDADLabel.Name = "LOCALIDADLabel"
        LOCALIDADLabel.Size = New System.Drawing.Size(56, 13)
        LOCALIDADLabel.TabIndex = 47
        LOCALIDADLabel.Text = "Localidad:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(223, 106)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 49
        PROVINCIALabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(715, 112)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 90
        CPLabel.Text = "CP:"
        '
        'Label6
        '
        Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(720, 556)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(82, 13)
        Label6.TabIndex = 33
        Label6.Text = "Importe Liquido:"
        '
        'TOTALLabel
        '
        TOTALLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TOTALLabel.AutoSize = True
        TOTALLabel.Location = New System.Drawing.Point(768, 471)
        TOTALLabel.Name = "TOTALLabel"
        TOTALLabel.Size = New System.Drawing.Size(34, 13)
        TOTALLabel.TabIndex = 28
        TOTALLabel.Text = "Total:"
        '
        'PORCENTAJEIRPFLabel
        '
        PORCENTAJEIRPFLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PORCENTAJEIRPFLabel.AutoSize = True
        PORCENTAJEIRPFLabel.Location = New System.Drawing.Point(708, 523)
        PORCENTAJEIRPFLabel.Name = "PORCENTAJEIRPFLabel"
        PORCENTAJEIRPFLabel.Size = New System.Drawing.Size(34, 13)
        PORCENTAJEIRPFLabel.TabIndex = 30
        PORCENTAJEIRPFLabel.Text = "IRPF:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(480, 29)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 13)
        Label4.TabIndex = 49
        Label4.Text = "Diagnóstico:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(10, 138)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 47
        Label5.Text = "Pasaporte:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(249, 138)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 13)
        Label7.TabIndex = 49
        Label7.Text = "NIE:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(808, 20)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(70, 13)
        Label8.TabIndex = 26
        Label8.Text = "Fecha Envio:"
        '
        'Label9
        '
        Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(748, 497)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(54, 13)
        Label9.TabIndex = 28
        Label9.Text = "Total IVA:"
        '
        'FACTURABindingSource
        '
        Me.FACTURABindingSource.DataSource = GetType(centro_medico.FACTURA)
        '
        'grpDatosPaciente
        '
        Me.grpDatosPaciente.Controls.Add(Me.lb_dpLetradni)
        Me.grpDatosPaciente.Controls.Add(Me.CtrlEmpresa1)
        Me.grpDatosPaciente.Controls.Add(Me.MaskedEditBox3)
        Me.grpDatosPaciente.Controls.Add(Me.txtDNI)
        Me.grpDatosPaciente.Controls.Add(Me.CtrlDiagnosticos1)
        Me.grpDatosPaciente.Controls.Add(CPLabel)
        Me.grpDatosPaciente.Controls.Add(DNILabel)
        Me.grpDatosPaciente.Controls.Add(Me.txtNie)
        Me.grpDatosPaciente.Controls.Add(Me.txtPasaporte)
        Me.grpDatosPaciente.Controls.Add(Me.tb_localidad)
        Me.grpDatosPaciente.Controls.Add(Me.tb_provincia)
        Me.grpDatosPaciente.Controls.Add(Me.tb_direccion)
        Me.grpDatosPaciente.Controls.Add(Label4)
        Me.grpDatosPaciente.Controls.Add(Label7)
        Me.grpDatosPaciente.Controls.Add(PROVINCIALabel)
        Me.grpDatosPaciente.Controls.Add(Label5)
        Me.grpDatosPaciente.Controls.Add(LOCALIDADLabel)
        Me.grpDatosPaciente.Controls.Add(DIRECCIONLabel)
        Me.grpDatosPaciente.Controls.Add(Me.CtrlMutua1)
        Me.grpDatosPaciente.Controls.Add(Me.CtrlPaciente1)
        Me.grpDatosPaciente.Location = New System.Drawing.Point(3, 110)
        Me.grpDatosPaciente.Name = "grpDatosPaciente"
        Me.grpDatosPaciente.Size = New System.Drawing.Size(935, 161)
        Me.grpDatosPaciente.TabIndex = 3
        Me.grpDatosPaciente.TabStop = False
        Me.grpDatosPaciente.Text = "Datos paciente"
        '
        'lb_dpLetradni
        '
        Me.lb_dpLetradni.BackColor = System.Drawing.Color.Silver
        Me.lb_dpLetradni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_dpLetradni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dpLetradni.Location = New System.Drawing.Point(664, 109)
        Me.lb_dpLetradni.Name = "lb_dpLetradni"
        Me.lb_dpLetradni.Size = New System.Drawing.Size(22, 20)
        Me.lb_dpLetradni.TabIndex = 102
        Me.lb_dpLetradni.Text = "-"
        Me.lb_dpLetradni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = False
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(497, 50)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(381, 25)
        Me.CtrlEmpresa1.TabIndex = 101
        '
        'MaskedEditBox3
        '
        Me.MaskedEditBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "CP", True))
        Me.MaskedEditBox3.Location = New System.Drawing.Point(745, 108)
        Me.MaskedEditBox3.Mask = "000000"
        Me.MaskedEditBox3.Name = "MaskedEditBox3"
        Me.MaskedEditBox3.Size = New System.Drawing.Size(83, 20)
        Me.MaskedEditBox3.TabIndex = 19
        '
        'txtDNI
        '
        Me.txtDNI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "DNI", True))
        Me.txtDNI.Location = New System.Drawing.Point(552, 108)
        Me.txtDNI.Mask = "000000000"
        Me.txtDNI.MaxLength = 9
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Numeric = True
        Me.txtDNI.Size = New System.Drawing.Size(111, 20)
        Me.txtDNI.TabIndex = 18
        '
        'CtrlDiagnosticos1
        '
        Me.CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticos1.Location = New System.Drawing.Point(552, 23)
        Me.CtrlDiagnosticos1.Name = "CtrlDiagnosticos1"
        Me.CtrlDiagnosticos1.Size = New System.Drawing.Size(327, 25)
        Me.CtrlDiagnosticos1.TabIndex = 15
        '
        'txtNie
        '
        Me.txtNie.AcceptsReturn = True
        Me.txtNie.BackColor = System.Drawing.Color.White
        Me.txtNie.Location = New System.Drawing.Point(283, 135)
        Me.txtNie.MaxLength = 35
        Me.txtNie.Name = "txtNie"
        Me.txtNie.ReadOnly = True
        Me.txtNie.Size = New System.Drawing.Size(150, 20)
        Me.txtNie.TabIndex = 13
        '
        'txtPasaporte
        '
        Me.txtPasaporte.AcceptsReturn = True
        Me.txtPasaporte.BackColor = System.Drawing.Color.White
        Me.txtPasaporte.Location = New System.Drawing.Point(70, 135)
        Me.txtPasaporte.MaxLength = 35
        Me.txtPasaporte.Name = "txtPasaporte"
        Me.txtPasaporte.ReadOnly = True
        Me.txtPasaporte.Size = New System.Drawing.Size(136, 20)
        Me.txtPasaporte.TabIndex = 13
        '
        'tb_localidad
        '
        Me.tb_localidad.AcceptsReturn = True
        Me.tb_localidad.BackColor = System.Drawing.Color.White
        Me.tb_localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "LOCALIDAD", True))
        Me.tb_localidad.Location = New System.Drawing.Point(70, 104)
        Me.tb_localidad.MaxLength = 35
        Me.tb_localidad.Name = "tb_localidad"
        Me.tb_localidad.Size = New System.Drawing.Size(136, 20)
        Me.tb_localidad.TabIndex = 13
        '
        'tb_provincia
        '
        Me.tb_provincia.AcceptsReturn = True
        Me.tb_provincia.BackColor = System.Drawing.Color.White
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(283, 104)
        Me.tb_provincia.MaxLength = 35
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(150, 20)
        Me.tb_provincia.TabIndex = 14
        '
        'tb_direccion
        '
        Me.tb_direccion.AcceptsReturn = True
        Me.tb_direccion.BackColor = System.Drawing.Color.White
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(70, 78)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(363, 20)
        Me.tb_direccion.TabIndex = 12
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = True
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(514, 80)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(339, 21)
        Me.CtrlMutua1.TabIndex = 17
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(22, 21)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(411, 50)
        Me.CtrlPaciente1.TabIndex = 11
        '
        'dtp_femision
        '
        Me.dtp_femision.Checked = False
        Me.dtp_femision.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "FEMISION", True))
        Me.dtp_femision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_femision.Location = New System.Drawing.Point(427, 34)
        Me.dtp_femision.Name = "dtp_femision"
        Me.dtp_femision.Size = New System.Drawing.Size(112, 20)
        Me.dtp_femision.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Tipo de Factura"
        '
        'cb_tipo
        '
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Paciente", "Mutua"})
        Me.cb_tipo.Location = New System.Drawing.Point(262, 36)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cb_tipo.TabIndex = 2
        '
        'dtp_falta
        '
        Me.dtp_falta.Checked = False
        Me.dtp_falta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "FALTA", True))
        Me.dtp_falta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_falta.Location = New System.Drawing.Point(696, 75)
        Me.dtp_falta.Name = "dtp_falta"
        Me.dtp_falta.ShowCheckBox = True
        Me.dtp_falta.Size = New System.Drawing.Size(101, 20)
        Me.dtp_falta.TabIndex = 10
        '
        'dtp_fbaja
        '
        Me.dtp_fbaja.Checked = False
        Me.dtp_fbaja.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "FBAJA", True))
        Me.dtp_fbaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fbaja.Location = New System.Drawing.Point(569, 75)
        Me.dtp_fbaja.Name = "dtp_fbaja"
        Me.dtp_fbaja.ShowCheckBox = True
        Me.dtp_fbaja.Size = New System.Drawing.Size(105, 20)
        Me.dtp_fbaja.TabIndex = 9
        '
        'dtp_fasistencia
        '
        Me.dtp_fasistencia.Checked = False
        Me.dtp_fasistencia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "FACCIDENTE", True))
        Me.dtp_fasistencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fasistencia.Location = New System.Drawing.Point(569, 34)
        Me.dtp_fasistencia.Name = "dtp_fasistencia"
        Me.dtp_fasistencia.ShowCheckBox = True
        Me.dtp_fasistencia.Size = New System.Drawing.Size(105, 20)
        Me.dtp_fasistencia.TabIndex = 4
        '
        'chb_recibo
        '
        Me.chb_recibo.Location = New System.Drawing.Point(295, 77)
        Me.chb_recibo.Name = "chb_recibo"
        Me.chb_recibo.Size = New System.Drawing.Size(97, 19)
        Me.chb_recibo.TabIndex = 7
        Me.chb_recibo.Text = "Generar recibo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_UndoCobrar)
        Me.GroupBox1.Controls.Add(Me.chk_pagada)
        Me.GroupBox1.Controls.Add(Me.combo_FechaEnvio)
        Me.GroupBox1.Controls.Add(Me.cb_pagada)
        Me.GroupBox1.Controls.Add(Me.dtp_Hora)
        Me.GroupBox1.Controls.Add(Me.SERIESComboBox)
        Me.GroupBox1.Controls.Add(Me.CtrlFormaPago21)
        Me.GroupBox1.Controls.Add(FACCIDENTELabel)
        Me.GroupBox1.Controls.Add(Me.chb_recibo)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_fasistencia)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(HORALabel)
        Me.GroupBox1.Controls.Add(FBAJALabel)
        Me.GroupBox1.Controls.Add(Me.dtp_fbaja)
        Me.GroupBox1.Controls.Add(Me.tb_nro)
        Me.GroupBox1.Controls.Add(FALTALabel)
        Me.GroupBox1.Controls.Add(Me.dtp_falta)
        Me.GroupBox1.Controls.Add(Me.cb_tipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(NUMEROFACTURALabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(FEMISIONLabel)
        Me.GroupBox1.Controls.Add(Me.dtp_femision)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos factura"
        '
        'pb_UndoCobrar
        '
        Me.pb_UndoCobrar.Image = Global.centro_medico.My.Resources.Resources.undo_blue
        Me.pb_UndoCobrar.Location = New System.Drawing.Point(535, 77)
        Me.pb_UndoCobrar.Name = "pb_UndoCobrar"
        Me.pb_UndoCobrar.Size = New System.Drawing.Size(16, 16)
        Me.pb_UndoCobrar.TabIndex = 107
        Me.pb_UndoCobrar.TabStop = False
        Me.pb_UndoCobrar.Visible = False
        '
        'chk_pagada
        '
        Me.chk_pagada.AutoSize = True
        Me.chk_pagada.Location = New System.Drawing.Point(408, 79)
        Me.chk_pagada.Name = "chk_pagada"
        Me.chk_pagada.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagada.TabIndex = 106
        Me.chk_pagada.UseVisualStyleBackColor = True
        '
        'combo_FechaEnvio
        '
        Me.combo_FechaEnvio.Checked = False
        Me.combo_FechaEnvio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "FECHAENVIO", True))
        Me.combo_FechaEnvio.IsNullDate = True
        Me.combo_FechaEnvio.Location = New System.Drawing.Point(811, 36)
        Me.combo_FechaEnvio.Name = "combo_FechaEnvio"
        Me.combo_FechaEnvio.Nullable = True
        Me.combo_FechaEnvio.ShowCheckBox = True
        Me.combo_FechaEnvio.Size = New System.Drawing.Size(112, 20)
        Me.combo_FechaEnvio.TabIndex = 105
        '
        'cb_pagada
        '
        Me.cb_pagada.Location = New System.Drawing.Point(427, 75)
        Me.cb_pagada.Name = "cb_pagada"
        Me.cb_pagada.Size = New System.Drawing.Size(105, 20)
        Me.cb_pagada.TabIndex = 104
        Me.cb_pagada.Value = New Date(1, 2, 1, 0, 0, 0, 0)
        '
        'dtp_Hora
        '
        Me.dtp_Hora.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FACTURABindingSource, "HORA", True))
        Me.dtp_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_Hora.Location = New System.Drawing.Point(696, 34)
        Me.dtp_Hora.Name = "dtp_Hora"
        Me.dtp_Hora.ShowUpDown = True
        Me.dtp_Hora.Size = New System.Drawing.Size(89, 20)
        Me.dtp_Hora.TabIndex = 5
        '
        'SERIESComboBox
        '
        Me.SERIESComboBox.DisplayMember = "CODIGO"
        Me.SERIESComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SERIESComboBox.FormattingEnabled = True
        Me.SERIESComboBox.Location = New System.Drawing.Point(142, 36)
        Me.SERIESComboBox.Name = "SERIESComboBox"
        Me.SERIESComboBox.Size = New System.Drawing.Size(102, 21)
        Me.SERIESComboBox.TabIndex = 1
        Me.SERIESComboBox.ValueMember = "CODIGO"
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(21, 73)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(268, 23)
        Me.CtrlFormaPago21.TabIndex = 6
        '
        'tb_nro
        '
        Me.tb_nro.AcceptsReturn = True
        Me.tb_nro.BackColor = System.Drawing.Color.GhostWhite
        Me.tb_nro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACTURABindingSource, "NUMERO", True))
        Me.tb_nro.Location = New System.Drawing.Point(21, 36)
        Me.tb_nro.Name = "tb_nro"
        Me.tb_nro.Size = New System.Drawing.Size(108, 20)
        Me.tb_nro.TabIndex = 0
        '
        'GridEXLineas
        '
        Me.GridEXLineas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXLineas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXLineas.AutoEdit = True
        Me.GridEXLineas.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXLineas.ColumnAutoResize = True
        Me.GridEXLineas.DataSource = Me.LINEASFACTURAsBindingSource
        GridEXLineas_DesignTimeLayout.LayoutString = resources.GetString("GridEXLineas_DesignTimeLayout.LayoutString")
        Me.GridEXLineas.DesignTimeLayout = GridEXLineas_DesignTimeLayout
        Me.GridEXLineas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEXLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXLineas.GroupByBoxVisible = False
        Me.GridEXLineas.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXLineas.Location = New System.Drawing.Point(3, 299)
        Me.GridEXLineas.Name = "GridEXLineas"
        Me.GridEXLineas.Size = New System.Drawing.Size(690, 290)
        Me.GridEXLineas.TabIndex = 20
        Me.GridEXLineas.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXLineas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'LINEASFACTURAsBindingSource
        '
        Me.LINEASFACTURAsBindingSource.DataMember = "LINEASFACTURAs"
        Me.LINEASFACTURAsBindingSource.DataSource = Me.FACTURABindingSource
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackgroundImage = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(25, 277)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(16, 16)
        Me.btn_Eliminar.TabIndex = 38
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD.Location = New System.Drawing.Point(3, 277)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btn_ADD.TabIndex = 36
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(616, 595)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(77, 28)
        Me.bt_imprimir.TabIndex = 39
        Me.bt_imprimir.Text = "&Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(847, 595)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(81, 28)
        Me.bt_cancel.TabIndex = 27
        Me.bt_cancel.Text = "&Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(763, 595)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(82, 28)
        Me.bt_aceptar.TabIndex = 26
        Me.bt_aceptar.Text = "&Guardar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_facturar
        '
        Me.bt_facturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_facturar.Location = New System.Drawing.Point(479, 595)
        Me.bt_facturar.Name = "bt_facturar"
        Me.bt_facturar.Size = New System.Drawing.Size(133, 28)
        Me.bt_facturar.TabIndex = 42
        Me.bt_facturar.Text = "&Facturar Analitica(s)"
        Me.bt_facturar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtTotal.Location = New System.Drawing.Point(808, 468)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(104, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.Text = "$0.00"
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtIRPFImporte
        '
        Me.txtIRPFImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIRPFImporte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtIRPFImporte.Location = New System.Drawing.Point(809, 520)
        Me.txtIRPFImporte.Name = "txtIRPFImporte"
        Me.txtIRPFImporte.Size = New System.Drawing.Size(104, 20)
        Me.txtIRPFImporte.TabIndex = 24
        Me.txtIRPFImporte.Text = "$0.00"
        Me.txtIRPFImporte.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtImporteLiquido
        '
        Me.txtImporteLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteLiquido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteLiquido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtImporteLiquido.Location = New System.Drawing.Point(808, 549)
        Me.txtImporteLiquido.Name = "txtImporteLiquido"
        Me.txtImporteLiquido.Size = New System.Drawing.Size(104, 20)
        Me.txtImporteLiquido.TabIndex = 25
        Me.txtImporteLiquido.Text = "$0.00"
        Me.txtImporteLiquido.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtIRPFPorciento
        '
        Me.txtIRPFPorciento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIRPFPorciento.DecimalDigits = 1
        Me.txtIRPFPorciento.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtIRPFPorciento.Location = New System.Drawing.Point(741, 520)
        Me.txtIRPFPorciento.Name = "txtIRPFPorciento"
        Me.txtIRPFPorciento.Size = New System.Drawing.Size(61, 20)
        Me.txtIRPFPorciento.TabIndex = 23
        Me.txtIRPFPorciento.Text = "0.0 %"
        Me.txtIRPFPorciento.Value = 0.0R
        Me.txtIRPFPorciento.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'GridEXDesglose
        '
        Me.GridEXDesglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDesglose.ColumnAutoResize = True
        GridEXDesglose_DesignTimeLayout.LayoutString = resources.GetString("GridEXDesglose_DesignTimeLayout.LayoutString")
        Me.GridEXDesglose.DesignTimeLayout = GridEXDesglose_DesignTimeLayout
        Me.GridEXDesglose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXDesglose.GroupByBoxVisible = False
        Me.GridEXDesglose.Location = New System.Drawing.Point(699, 299)
        Me.GridEXDesglose.Name = "GridEXDesglose"
        Me.GridEXDesglose.Size = New System.Drawing.Size(229, 155)
        Me.GridEXDesglose.TabIndex = 43
        '
        'txtTotalIVA
        '
        Me.txtTotalIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalIVA.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtTotalIVA.Location = New System.Drawing.Point(808, 494)
        Me.txtTotalIVA.Name = "txtTotalIVA"
        Me.txtTotalIVA.ReadOnly = True
        Me.txtTotalIVA.Size = New System.Drawing.Size(104, 20)
        Me.txtTotalIVA.TabIndex = 22
        Me.txtTotalIVA.Text = "$0.00"
        Me.txtTotalIVA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.FACTURABindingSource, "REFPACIENTE", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(3, 596)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(399, 28)
        Me.CtrlStatusPaciente1.TabIndex = 0
        '
        'btnFacturaE
        '
        Me.btnFacturaE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturaE.Location = New System.Drawing.Point(402, 595)
        Me.btnFacturaE.Name = "btnFacturaE"
        Me.btnFacturaE.Size = New System.Drawing.Size(72, 28)
        Me.btnFacturaE.TabIndex = 44
        Me.btnFacturaE.Text = "FacturaE"
        Me.btnFacturaE.UseVisualStyleBackColor = True
        '
        'frmFacturasM_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 624)
        Me.Controls.Add(Me.btnFacturaE)
        Me.Controls.Add(Me.grpDatosPaciente)
        Me.Controls.Add(Me.GridEXDesglose)
        Me.Controls.Add(Me.txtImporteLiquido)
        Me.Controls.Add(Me.txtIRPFPorciento)
        Me.Controls.Add(Me.txtIRPFImporte)
        Me.Controls.Add(Me.txtTotalIVA)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.bt_facturar)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_ADD)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label9)
        Me.Controls.Add(TOTALLabel)
        Me.Controls.Add(PORCENTAJEIRPFLabel)
        Me.Controls.Add(Me.GridEXLineas)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturasM_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Médica"
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosPaciente.ResumeLayout(False)
        Me.grpDatosPaciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASFACTURAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXDesglose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents grpDatosPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_femision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Public WithEvents dtp_falta As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_nro As ctrlTextboxAvanzado
    Public WithEvents dtp_fbaja As System.Windows.Forms.DateTimePicker
    Public WithEvents dtp_fasistencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_recibo As System.Windows.Forms.CheckBox
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Public WithEvents tb_direccion As ctrlTextboxAvanzado
    Public WithEvents tb_localidad As ctrlTextboxAvanzado
    Public WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents GridEXLineas As Janus.Windows.GridEX.GridEX
    Friend WithEvents FACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERIESComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_facturar As System.Windows.Forms.Button
    Friend WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtIRPFImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtImporteLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtIRPFPorciento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents CtrlDiagnosticos1 As centro_medico.ctrlDiagnosticos
    Friend WithEvents MaskedEditBox3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDNI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtp_Hora As System.Windows.Forms.DateTimePicker
    'Friend WithEvents CtrlEmpresa21 As ctrlEmpresa2
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Friend WithEvents GridEXDesglose As Janus.Windows.GridEX.GridEX
    Friend WithEvents lb_dpLetradni As System.Windows.Forms.Label
    Public WithEvents txtNie As ctrlTextboxAvanzado
    Public WithEvents txtPasaporte As ctrlTextboxAvanzado
    Friend WithEvents cb_pagada As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents combo_FechaEnvio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents LINEASFACTURAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtTotalIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chk_pagada As System.Windows.Forms.CheckBox
    Friend WithEvents pb_UndoCobrar As System.Windows.Forms.PictureBox
    Friend WithEvents btnFacturaE As System.Windows.Forms.Button
End Class
