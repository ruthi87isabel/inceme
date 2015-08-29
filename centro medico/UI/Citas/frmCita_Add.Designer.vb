<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCita_Add
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim HORALabel As System.Windows.Forms.Label
        Dim HORAFINLabel As System.Windows.Forms.Label
        Dim REFRECIBOLabel As System.Windows.Forms.Label
        Dim IMPORTECLLabel As System.Windows.Forms.Label
        Dim IMPORTEDRLabel As System.Windows.Forms.Label
        Dim CONFIRMADALabel1 As System.Windows.Forms.Label
        Dim ATENDIDOLabel1 As System.Windows.Forms.Label
        Dim FALTALabel1 As System.Windows.Forms.Label
        Dim PAGADALabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCita_Add))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsb_HacerVenta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsb_DebitoPaciente = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CtrlMedico1 = New centro_medico.ctrlMedico
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente
        Me.cb_citaMultiple = New System.Windows.Forms.CheckBox
        Me.gb_citaMultiple = New System.Windows.Forms.GroupBox
        Me.tb_horafincm = New System.Windows.Forms.DateTimePicker
        Me.tb_horainiciocm = New System.Windows.Forms.DateTimePicker
        Me.chb_sab = New System.Windows.Forms.CheckBox
        Me.chb_vie = New System.Windows.Forms.CheckBox
        Me.chb_mier = New System.Windows.Forms.CheckBox
        Me.chb_mar = New System.Windows.Forms.CheckBox
        Me.chb_dom = New System.Windows.Forms.CheckBox
        Me.chb_jue = New System.Windows.Forms.CheckBox
        Me.chb_lun = New System.Windows.Forms.CheckBox
        Me.dtp_final = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechacm = New System.Windows.Forms.DateTimePicker
        Me.cb_aseguradora = New System.Windows.Forms.ComboBox
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chb_aseguradora = New System.Windows.Forms.CheckBox
        Me.GroupBoxFechaSimple = New System.Windows.Forms.GroupBox
        Me.tb_horafin = New System.Windows.Forms.DateTimePicker
        Me.tb_horainicio = New System.Windows.Forms.DateTimePicker
        Me.lb_aviso = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.tb_notas = New System.Windows.Forms.TextBox
        Me.bt_DelLinea = New System.Windows.Forms.Button
        Me.bt_AddLinea = New System.Windows.Forms.Button
        Me.dg_LineasCitas = New System.Windows.Forms.DataGridView
        Me.RefConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBuscar = New System.Windows.Forms.DataGridViewImageColumn
        Me.IdLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteClinicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineasCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstrip_Info = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PAGADAUICheckBox = New Janus.Windows.EditControls.UICheckBox
        Me.FALTAUICheckBox = New Janus.Windows.EditControls.UICheckBox
        Me.ATENDIDOUICheckBox = New Janus.Windows.EditControls.UICheckBox
        Me.CONFIRMADAUICheckBox = New Janus.Windows.EditControls.UICheckBox
        Me.dtp_fechacobro = New System.Windows.Forms.DateTimePicker
        Me.bt_AddHistoria = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.grpImporte = New System.Windows.Forms.GroupBox
        Me.bt_modificar = New Janus.Windows.EditControls.UIButton
        Me.bt_AsignarFra = New Janus.Windows.EditControls.UIButton
        Me.bt_factura = New Janus.Windows.EditControls.UIButton
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2
        Me.lb_ftexto = New System.Windows.Forms.Label
        Me.lb_factura = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lb_recibo = New System.Windows.Forms.Label
        Me.chb_recibo = New System.Windows.Forms.CheckBox
        Me.tb_clinica = New System.Windows.Forms.TextBox
        Me.tb_dr = New System.Windows.Forms.TextBox
        Me.LineasCitasTableAdapter = New centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
        Me.group_Proceso = New System.Windows.Forms.GroupBox
        Me.btnVerProceso = New System.Windows.Forms.Button
        Me.lblCitaProcesoInfo = New System.Windows.Forms.Label
        Me.btn_HistorialProcesos = New System.Windows.Forms.Button
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.CONCEPTOSFACTURABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFACTURABLESTableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        HORALabel = New System.Windows.Forms.Label
        HORAFINLabel = New System.Windows.Forms.Label
        REFRECIBOLabel = New System.Windows.Forms.Label
        IMPORTECLLabel = New System.Windows.Forms.Label
        IMPORTEDRLabel = New System.Windows.Forms.Label
        CONFIRMADALabel1 = New System.Windows.Forms.Label
        ATENDIDOLabel1 = New System.Windows.Forms.Label
        FALTALabel1 = New System.Windows.Forms.Label
        PAGADALabel1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_citaMultiple.SuspendLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFechaSimple.SuspendLayout()
        CType(Me.dg_LineasCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImporte.SuspendLayout()
        Me.group_Proceso.SuspendLayout()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(134, 127)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(29, 13)
        Label3.TabIndex = 5
        Label3.Text = "Sab:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(69, 127)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(25, 13)
        Label4.TabIndex = 4
        Label4.Text = "Vie:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(134, 108)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(30, 13)
        Label5.TabIndex = 2
        Label5.Text = "Mier:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(69, 108)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(28, 13)
        Label1.TabIndex = 1
        Label1.Text = "Mar:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(8, 143)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(32, 13)
        Label2.TabIndex = 6
        Label2.Text = "Dom:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 127)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(27, 13)
        Label6.TabIndex = 3
        Label6.Text = "Jue:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(12, 108)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(28, 13)
        Label9.TabIndex = 0
        Label9.Text = "Lun:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(124, 22)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(65, 13)
        Label10.TabIndex = 68
        Label10.Text = "Fecha Final:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(12, 23)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(70, 13)
        Label11.TabIndex = 35
        Label11.Text = "Fecha Inicial:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(12, 65)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(61, 13)
        Label12.TabIndex = 37
        Label12.Text = "Hora Inicio:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(124, 65)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(47, 13)
        Label13.TabIndex = 65
        Label13.Text = "Hora fin:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(6, 16)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 35
        FECHALabel.Text = "Fecha:"
        '
        'HORALabel
        '
        HORALabel.AutoSize = True
        HORALabel.Location = New System.Drawing.Point(101, 17)
        HORALabel.Name = "HORALabel"
        HORALabel.Size = New System.Drawing.Size(61, 13)
        HORALabel.TabIndex = 37
        HORALabel.Text = "Hora Inicio:"
        '
        'HORAFINLabel
        '
        HORAFINLabel.AutoSize = True
        HORAFINLabel.Location = New System.Drawing.Point(179, 17)
        HORAFINLabel.Name = "HORAFINLabel"
        HORAFINLabel.Size = New System.Drawing.Size(47, 13)
        HORAFINLabel.TabIndex = 65
        HORAFINLabel.Text = "Hora fin:"
        '
        'REFRECIBOLabel
        '
        REFRECIBOLabel.AutoSize = True
        REFRECIBOLabel.Location = New System.Drawing.Point(335, 92)
        REFRECIBOLabel.Name = "REFRECIBOLabel"
        REFRECIBOLabel.Size = New System.Drawing.Size(44, 13)
        REFRECIBOLabel.TabIndex = 64
        REFRECIBOLabel.Text = "Recibo:"
        '
        'IMPORTECLLabel
        '
        IMPORTECLLabel.AutoSize = True
        IMPORTECLLabel.Location = New System.Drawing.Point(13, 30)
        IMPORTECLLabel.Name = "IMPORTECLLabel"
        IMPORTECLLabel.Size = New System.Drawing.Size(41, 13)
        IMPORTECLLabel.TabIndex = 47
        IMPORTECLLabel.Text = "Clinica:"
        '
        'IMPORTEDRLabel
        '
        IMPORTEDRLabel.AutoSize = True
        IMPORTEDRLabel.Location = New System.Drawing.Point(89, 28)
        IMPORTEDRLabel.Name = "IMPORTEDRLabel"
        IMPORTEDRLabel.Size = New System.Drawing.Size(42, 13)
        IMPORTEDRLabel.TabIndex = 45
        IMPORTEDRLabel.Text = "Doctor:"
        '
        'CONFIRMADALabel1
        '
        CONFIRMADALabel1.AutoSize = True
        CONFIRMADALabel1.Location = New System.Drawing.Point(21, 29)
        CONFIRMADALabel1.Name = "CONFIRMADALabel1"
        CONFIRMADALabel1.Size = New System.Drawing.Size(63, 13)
        CONFIRMADALabel1.TabIndex = 2
        CONFIRMADALabel1.Text = "Confirmada:"
        '
        'ATENDIDOLabel1
        '
        ATENDIDOLabel1.AutoSize = True
        ATENDIDOLabel1.Location = New System.Drawing.Point(32, 51)
        ATENDIDOLabel1.Name = "ATENDIDOLabel1"
        ATENDIDOLabel1.Size = New System.Drawing.Size(52, 13)
        ATENDIDOLabel1.TabIndex = 3
        ATENDIDOLabel1.Text = "Atendida:"
        '
        'FALTALabel1
        '
        FALTALabel1.AutoSize = True
        FALTALabel1.Location = New System.Drawing.Point(51, 73)
        FALTALabel1.Name = "FALTALabel1"
        FALTALabel1.Size = New System.Drawing.Size(33, 13)
        FALTALabel1.TabIndex = 5
        FALTALabel1.Text = "Falta:"
        '
        'PAGADALabel1
        '
        PAGADALabel1.AutoSize = True
        PAGADALabel1.Location = New System.Drawing.Point(34, 95)
        PAGADALabel1.Name = "PAGADALabel1"
        PAGADALabel1.Size = New System.Drawing.Size(50, 13)
        PAGADALabel1.TabIndex = 7
        PAGADALabel1.Text = "Cobrada:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.tsb_HacerVenta, Me.ToolStripSeparator2, Me.tsb_DebitoPaciente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 94
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.ToolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel1.Text = "&Guardar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "&Cancelar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton2.Text = "&Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsb_HacerVenta
        '
        Me.tsb_HacerVenta.Enabled = False
        Me.tsb_HacerVenta.Image = Global.centro_medico.My.Resources.Resources.Dollar_Sign
        Me.tsb_HacerVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_HacerVenta.Name = "tsb_HacerVenta"
        Me.tsb_HacerVenta.Size = New System.Drawing.Size(90, 22)
        Me.tsb_HacerVenta.Text = "Hacer venta"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsb_DebitoPaciente
        '
        Me.tsb_DebitoPaciente.Enabled = False
        Me.tsb_DebitoPaciente.Image = Global.centro_medico.My.Resources.Resources.PacienteDebito
        Me.tsb_DebitoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DebitoPaciente.Name = "tsb_DebitoPaciente"
        Me.tsb_DebitoPaciente.Size = New System.Drawing.Size(110, 22)
        Me.tsb_DebitoPaciente.Text = "Débito Paciente"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CtrlMedico1)
        Me.Panel1.Controls.Add(Me.CtrlPaciente1)
        Me.Panel1.Controls.Add(Me.cb_citaMultiple)
        Me.Panel1.Controls.Add(Me.gb_citaMultiple)
        Me.Panel1.Controls.Add(Me.cb_aseguradora)
        Me.Panel1.Controls.Add(Me.chb_aseguradora)
        Me.Panel1.Controls.Add(Me.GroupBoxFechaSimple)
        Me.Panel1.Location = New System.Drawing.Point(4, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 186)
        Me.Panel1.TabIndex = 95
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.CITASBindingSource, "REFMEDICO", True))
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(64, 51)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(458, 42)
        Me.CtrlMedico1.TabIndex = 95
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.CITASBindingSource, "REFPACIENTE", True))
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(15, 3)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(507, 52)
        Me.CtrlPaciente1.TabIndex = 94
        '
        'cb_citaMultiple
        '
        Me.cb_citaMultiple.AutoSize = True
        Me.cb_citaMultiple.Location = New System.Drawing.Point(602, 23)
        Me.cb_citaMultiple.Name = "cb_citaMultiple"
        Me.cb_citaMultiple.Size = New System.Drawing.Size(83, 17)
        Me.cb_citaMultiple.TabIndex = 93
        Me.cb_citaMultiple.Text = "Cita Múltiple"
        Me.cb_citaMultiple.UseVisualStyleBackColor = True
        '
        'gb_citaMultiple
        '
        Me.gb_citaMultiple.Controls.Add(Me.tb_horafincm)
        Me.gb_citaMultiple.Controls.Add(Me.tb_horainiciocm)
        Me.gb_citaMultiple.Controls.Add(Label3)
        Me.gb_citaMultiple.Controls.Add(Me.chb_sab)
        Me.gb_citaMultiple.Controls.Add(Label4)
        Me.gb_citaMultiple.Controls.Add(Me.chb_vie)
        Me.gb_citaMultiple.Controls.Add(Label5)
        Me.gb_citaMultiple.Controls.Add(Me.chb_mier)
        Me.gb_citaMultiple.Controls.Add(Label1)
        Me.gb_citaMultiple.Controls.Add(Me.chb_mar)
        Me.gb_citaMultiple.Controls.Add(Label2)
        Me.gb_citaMultiple.Controls.Add(Me.chb_dom)
        Me.gb_citaMultiple.Controls.Add(Label6)
        Me.gb_citaMultiple.Controls.Add(Me.chb_jue)
        Me.gb_citaMultiple.Controls.Add(Label9)
        Me.gb_citaMultiple.Controls.Add(Me.chb_lun)
        Me.gb_citaMultiple.Controls.Add(Label10)
        Me.gb_citaMultiple.Controls.Add(Me.dtp_final)
        Me.gb_citaMultiple.Controls.Add(Label11)
        Me.gb_citaMultiple.Controls.Add(Me.dtp_fechacm)
        Me.gb_citaMultiple.Controls.Add(Label12)
        Me.gb_citaMultiple.Controls.Add(Label13)
        Me.gb_citaMultiple.Location = New System.Drawing.Point(691, 5)
        Me.gb_citaMultiple.Name = "gb_citaMultiple"
        Me.gb_citaMultiple.Size = New System.Drawing.Size(244, 176)
        Me.gb_citaMultiple.TabIndex = 92
        Me.gb_citaMultiple.TabStop = False
        Me.gb_citaMultiple.Text = "Cita múltiple"
        Me.gb_citaMultiple.Visible = False
        '
        'tb_horafincm
        '
        Me.tb_horafincm.CustomFormat = "HH:mm"
        Me.tb_horafincm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horafincm.Location = New System.Drawing.Point(127, 82)
        Me.tb_horafincm.Name = "tb_horafincm"
        Me.tb_horafincm.ShowUpDown = True
        Me.tb_horafincm.Size = New System.Drawing.Size(58, 20)
        Me.tb_horafincm.TabIndex = 72
        '
        'tb_horainiciocm
        '
        Me.tb_horainiciocm.CustomFormat = "HH:mm"
        Me.tb_horainiciocm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horainiciocm.Location = New System.Drawing.Point(17, 82)
        Me.tb_horainiciocm.Name = "tb_horainiciocm"
        Me.tb_horainiciocm.ShowUpDown = True
        Me.tb_horainiciocm.Size = New System.Drawing.Size(58, 20)
        Me.tb_horainiciocm.TabIndex = 71
        '
        'chb_sab
        '
        Me.chb_sab.Location = New System.Drawing.Point(170, 122)
        Me.chb_sab.Name = "chb_sab"
        Me.chb_sab.Size = New System.Drawing.Size(18, 24)
        Me.chb_sab.TabIndex = 9
        '
        'chb_vie
        '
        Me.chb_vie.Location = New System.Drawing.Point(103, 122)
        Me.chb_vie.Name = "chb_vie"
        Me.chb_vie.Size = New System.Drawing.Size(24, 24)
        Me.chb_vie.TabIndex = 8
        '
        'chb_mier
        '
        Me.chb_mier.Location = New System.Drawing.Point(170, 103)
        Me.chb_mier.Name = "chb_mier"
        Me.chb_mier.Size = New System.Drawing.Size(24, 24)
        Me.chb_mier.TabIndex = 6
        '
        'chb_mar
        '
        Me.chb_mar.Location = New System.Drawing.Point(103, 103)
        Me.chb_mar.Name = "chb_mar"
        Me.chb_mar.Size = New System.Drawing.Size(25, 24)
        Me.chb_mar.TabIndex = 5
        '
        'chb_dom
        '
        Me.chb_dom.Location = New System.Drawing.Point(46, 143)
        Me.chb_dom.Name = "chb_dom"
        Me.chb_dom.Size = New System.Drawing.Size(18, 15)
        Me.chb_dom.TabIndex = 10
        '
        'chb_jue
        '
        Me.chb_jue.Location = New System.Drawing.Point(46, 122)
        Me.chb_jue.Name = "chb_jue"
        Me.chb_jue.Size = New System.Drawing.Size(24, 20)
        Me.chb_jue.TabIndex = 7
        '
        'chb_lun
        '
        Me.chb_lun.Location = New System.Drawing.Point(46, 103)
        Me.chb_lun.Name = "chb_lun"
        Me.chb_lun.Size = New System.Drawing.Size(24, 24)
        Me.chb_lun.TabIndex = 4
        '
        'dtp_final
        '
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(127, 39)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.Size = New System.Drawing.Size(104, 20)
        Me.dtp_final.TabIndex = 1
        '
        'dtp_fechacm
        '
        Me.dtp_fechacm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechacm.Location = New System.Drawing.Point(9, 40)
        Me.dtp_fechacm.Name = "dtp_fechacm"
        Me.dtp_fechacm.Size = New System.Drawing.Size(104, 20)
        Me.dtp_fechacm.TabIndex = 0
        '
        'cb_aseguradora
        '
        Me.cb_aseguradora.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CITASBindingSource, "REFPROCEDENCIA", True))
        Me.cb_aseguradora.DataSource = Me.MUTUASBindingSource
        Me.cb_aseguradora.DisplayMember = "NOMBRE"
        Me.cb_aseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_aseguradora.Enabled = False
        Me.cb_aseguradora.FormattingEnabled = True
        Me.cb_aseguradora.Location = New System.Drawing.Point(394, 141)
        Me.cb_aseguradora.Name = "cb_aseguradora"
        Me.cb_aseguradora.Size = New System.Drawing.Size(220, 21)
        Me.cb_aseguradora.TabIndex = 0
        Me.cb_aseguradora.ValueMember = "CMUTUA"
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'chb_aseguradora
        '
        Me.chb_aseguradora.Enabled = False
        Me.chb_aseguradora.Location = New System.Drawing.Point(394, 115)
        Me.chb_aseguradora.Name = "chb_aseguradora"
        Me.chb_aseguradora.Size = New System.Drawing.Size(177, 24)
        Me.chb_aseguradora.TabIndex = 78
        Me.chb_aseguradora.Text = "Cita de muta\aseguradora:"
        '
        'GroupBoxFechaSimple
        '
        Me.GroupBoxFechaSimple.Controls.Add(Me.tb_horafin)
        Me.GroupBoxFechaSimple.Controls.Add(Me.tb_horainicio)
        Me.GroupBoxFechaSimple.Controls.Add(Me.lb_aviso)
        Me.GroupBoxFechaSimple.Controls.Add(FECHALabel)
        Me.GroupBoxFechaSimple.Controls.Add(Me.dtp_fecha)
        Me.GroupBoxFechaSimple.Controls.Add(HORALabel)
        Me.GroupBoxFechaSimple.Controls.Add(HORAFINLabel)
        Me.GroupBoxFechaSimple.Location = New System.Drawing.Point(15, 106)
        Me.GroupBoxFechaSimple.Name = "GroupBoxFechaSimple"
        Me.GroupBoxFechaSimple.Size = New System.Drawing.Size(249, 70)
        Me.GroupBoxFechaSimple.TabIndex = 75
        Me.GroupBoxFechaSimple.TabStop = False
        Me.GroupBoxFechaSimple.Text = "Fecha"
        '
        'tb_horafin
        '
        Me.tb_horafin.CustomFormat = "HH:mm"
        Me.tb_horafin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "HORAFIN", True))
        Me.tb_horafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horafin.Location = New System.Drawing.Point(182, 32)
        Me.tb_horafin.Name = "tb_horafin"
        Me.tb_horafin.ShowUpDown = True
        Me.tb_horafin.Size = New System.Drawing.Size(58, 20)
        Me.tb_horafin.TabIndex = 70
        '
        'tb_horainicio
        '
        Me.tb_horainicio.CustomFormat = "HH:mm"
        Me.tb_horainicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "HORA", True))
        Me.tb_horainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horainicio.Location = New System.Drawing.Point(104, 32)
        Me.tb_horainicio.Name = "tb_horainicio"
        Me.tb_horainicio.ShowUpDown = True
        Me.tb_horainicio.Size = New System.Drawing.Size(58, 20)
        Me.tb_horainicio.TabIndex = 69
        '
        'lb_aviso
        '
        Me.lb_aviso.AutoSize = True
        Me.lb_aviso.ForeColor = System.Drawing.Color.Red
        Me.lb_aviso.Location = New System.Drawing.Point(10, 91)
        Me.lb_aviso.Name = "lb_aviso"
        Me.lb_aviso.Size = New System.Drawing.Size(10, 13)
        Me.lb_aviso.TabIndex = 68
        Me.lb_aviso.Text = "."
        Me.lb_aviso.Visible = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(9, 32)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(85, 20)
        Me.dtp_fecha.TabIndex = 36
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'tb_notas
        '
        Me.tb_notas.AcceptsReturn = True
        Me.tb_notas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_notas.BackColor = System.Drawing.Color.LemonChiffon
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(185, 574)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_notas.Size = New System.Drawing.Size(526, 63)
        Me.tb_notas.TabIndex = 98
        '
        'bt_DelLinea
        '
        Me.bt_DelLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_DelLinea.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_DelLinea.Location = New System.Drawing.Point(680, 415)
        Me.bt_DelLinea.Name = "bt_DelLinea"
        Me.bt_DelLinea.Size = New System.Drawing.Size(31, 31)
        Me.bt_DelLinea.TabIndex = 106
        Me.bt_DelLinea.UseVisualStyleBackColor = True
        '
        'bt_AddLinea
        '
        Me.bt_AddLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AddLinea.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.bt_AddLinea.Location = New System.Drawing.Point(680, 377)
        Me.bt_AddLinea.Name = "bt_AddLinea"
        Me.bt_AddLinea.Size = New System.Drawing.Size(31, 32)
        Me.bt_AddLinea.TabIndex = 105
        Me.bt_AddLinea.UseVisualStyleBackColor = True
        '
        'dg_LineasCitas
        '
        Me.dg_LineasCitas.AllowUserToAddRows = False
        Me.dg_LineasCitas.AllowUserToDeleteRows = False
        Me.dg_LineasCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_LineasCitas.AutoGenerateColumns = False
        Me.dg_LineasCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_LineasCitas.BackgroundColor = System.Drawing.Color.White
        Me.dg_LineasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_LineasCitas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefConceptoDataGridViewTextBoxColumn, Me.colBuscar, Me.IdLineaDataGridViewTextBoxColumn, Me.IdCitaDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.ImporteClinicaDataGridViewTextBoxColumn, Me.ImporteDrDataGridViewTextBoxColumn})
        Me.dg_LineasCitas.DataSource = Me.LineasCitasBindingSource
        Me.dg_LineasCitas.GridColor = System.Drawing.Color.DimGray
        Me.dg_LineasCitas.Location = New System.Drawing.Point(184, 377)
        Me.dg_LineasCitas.MultiSelect = False
        Me.dg_LineasCitas.Name = "dg_LineasCitas"
        Me.dg_LineasCitas.RowHeadersVisible = False
        Me.dg_LineasCitas.Size = New System.Drawing.Size(491, 191)
        Me.dg_LineasCitas.TabIndex = 104
        '
        'RefConceptoDataGridViewTextBoxColumn
        '
        Me.RefConceptoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.RefConceptoDataGridViewTextBoxColumn.DataPropertyName = "RefConcepto"
        Me.RefConceptoDataGridViewTextBoxColumn.HeaderText = "Cod"
        Me.RefConceptoDataGridViewTextBoxColumn.Name = "RefConceptoDataGridViewTextBoxColumn"
        Me.RefConceptoDataGridViewTextBoxColumn.Width = 51
        '
        'colBuscar
        '
        Me.colBuscar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colBuscar.HeaderText = "..."
        Me.colBuscar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.colBuscar.MinimumWidth = 25
        Me.colBuscar.Name = "colBuscar"
        Me.colBuscar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBuscar.Width = 25
        '
        'IdLineaDataGridViewTextBoxColumn
        '
        Me.IdLineaDataGridViewTextBoxColumn.DataPropertyName = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.HeaderText = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.Name = "IdLineaDataGridViewTextBoxColumn"
        Me.IdLineaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLineaDataGridViewTextBoxColumn.Visible = False
        '
        'IdCitaDataGridViewTextBoxColumn
        '
        Me.IdCitaDataGridViewTextBoxColumn.DataPropertyName = "IdCita"
        Me.IdCitaDataGridViewTextBoxColumn.HeaderText = "IdCita"
        Me.IdCitaDataGridViewTextBoxColumn.Name = "IdCitaDataGridViewTextBoxColumn"
        Me.IdCitaDataGridViewTextBoxColumn.Visible = False
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 74
        '
        'ImporteClinicaDataGridViewTextBoxColumn
        '
        Me.ImporteClinicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ImporteClinicaDataGridViewTextBoxColumn.DataPropertyName = "ImporteClinica"
        DataGridViewCellStyle1.Format = "C2"
        Me.ImporteClinicaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteClinicaDataGridViewTextBoxColumn.HeaderText = "Importe CL"
        Me.ImporteClinicaDataGridViewTextBoxColumn.Name = "ImporteClinicaDataGridViewTextBoxColumn"
        Me.ImporteClinicaDataGridViewTextBoxColumn.Width = 83
        '
        'ImporteDrDataGridViewTextBoxColumn
        '
        Me.ImporteDrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ImporteDrDataGridViewTextBoxColumn.DataPropertyName = "ImporteDr"
        DataGridViewCellStyle2.Format = "C2"
        Me.ImporteDrDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDrDataGridViewTextBoxColumn.HeaderText = "Importe Dr"
        Me.ImporteDrDataGridViewTextBoxColumn.Name = "ImporteDrDataGridViewTextBoxColumn"
        Me.ImporteDrDataGridViewTextBoxColumn.Width = 81
        '
        'LineasCitasBindingSource
        '
        Me.LineasCitasBindingSource.DataMember = "LineasCitas"
        Me.LineasCitasBindingSource.DataSource = Me.CMDataSet
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.tstrip_Info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 650)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(967, 22)
        Me.StatusStrip1.TabIndex = 103
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripStatusLabel1.Text = "Alt+G -> Guardar"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel2.Text = "Alt+C -> Cancelar"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel3.Text = "Alt+I -> Imprimir"
        '
        'tstrip_Info
        '
        Me.tstrip_Info.Name = "tstrip_Info"
        Me.tstrip_Info.Size = New System.Drawing.Size(13, 17)
        Me.tstrip_Info.Text = ".."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PAGADAUICheckBox)
        Me.GroupBox1.Controls.Add(Me.FALTAUICheckBox)
        Me.GroupBox1.Controls.Add(Me.ATENDIDOUICheckBox)
        Me.GroupBox1.Controls.Add(Me.CONFIRMADAUICheckBox)
        Me.GroupBox1.Controls.Add(Me.dtp_fechacobro)
        Me.GroupBox1.Controls.Add(PAGADALabel1)
        Me.GroupBox1.Controls.Add(FALTALabel1)
        Me.GroupBox1.Controls.Add(ATENDIDOLabel1)
        Me.GroupBox1.Controls.Add(CONFIRMADALabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(185, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 147)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'PAGADAUICheckBox
        '
        Me.PAGADAUICheckBox.CheckedValue = "S"
        Me.PAGADAUICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CITASBindingSource, "PAGADA", True))
        Me.PAGADAUICheckBox.IndeterminatedValue = ""
        Me.PAGADAUICheckBox.Location = New System.Drawing.Point(87, 92)
        Me.PAGADAUICheckBox.Name = "PAGADAUICheckBox"
        Me.PAGADAUICheckBox.Size = New System.Drawing.Size(18, 23)
        Me.PAGADAUICheckBox.TabIndex = 8
        Me.PAGADAUICheckBox.UncheckedValue = "N"
        '
        'FALTAUICheckBox
        '
        Me.FALTAUICheckBox.CheckedValue = "S"
        Me.FALTAUICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CITASBindingSource, "FALTA", True))
        Me.FALTAUICheckBox.IndeterminatedValue = ""
        Me.FALTAUICheckBox.Location = New System.Drawing.Point(87, 69)
        Me.FALTAUICheckBox.Name = "FALTAUICheckBox"
        Me.FALTAUICheckBox.Size = New System.Drawing.Size(18, 23)
        Me.FALTAUICheckBox.TabIndex = 6
        Me.FALTAUICheckBox.UncheckedValue = "N"
        '
        'ATENDIDOUICheckBox
        '
        Me.ATENDIDOUICheckBox.CheckedValue = "S"
        Me.ATENDIDOUICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CITASBindingSource, "ATENDIDO", True))
        Me.ATENDIDOUICheckBox.IndeterminatedValue = ""
        Me.ATENDIDOUICheckBox.Location = New System.Drawing.Point(87, 46)
        Me.ATENDIDOUICheckBox.Name = "ATENDIDOUICheckBox"
        Me.ATENDIDOUICheckBox.Size = New System.Drawing.Size(18, 23)
        Me.ATENDIDOUICheckBox.TabIndex = 4
        Me.ATENDIDOUICheckBox.UncheckedValue = "N"
        '
        'CONFIRMADAUICheckBox
        '
        Me.CONFIRMADAUICheckBox.CheckedValue = "S"
        Me.CONFIRMADAUICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CITASBindingSource, "CONFIRMADA", True))
        Me.CONFIRMADAUICheckBox.IndeterminatedValue = ""
        Me.CONFIRMADAUICheckBox.Location = New System.Drawing.Point(87, 23)
        Me.CONFIRMADAUICheckBox.Name = "CONFIRMADAUICheckBox"
        Me.CONFIRMADAUICheckBox.Size = New System.Drawing.Size(18, 23)
        Me.CONFIRMADAUICheckBox.TabIndex = 3
        Me.CONFIRMADAUICheckBox.UncheckedValue = "N"
        '
        'dtp_fechacobro
        '
        Me.dtp_fechacobro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "FECHACOBRO", True))
        Me.dtp_fechacobro.Enabled = False
        Me.dtp_fechacobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechacobro.Location = New System.Drawing.Point(24, 121)
        Me.dtp_fechacobro.Name = "dtp_fechacobro"
        Me.dtp_fechacobro.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fechacobro.TabIndex = 9
        '
        'bt_AddHistoria
        '
        Me.bt_AddHistoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_AddHistoria.FlatAppearance.BorderSize = 0
        Me.bt_AddHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_AddHistoria.Image = Global.centro_medico.My.Resources.Resources._24_book_blue_add
        Me.bt_AddHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AddHistoria.Location = New System.Drawing.Point(7, 613)
        Me.bt_AddHistoria.Name = "bt_AddHistoria"
        Me.bt_AddHistoria.Size = New System.Drawing.Size(108, 32)
        Me.bt_AddHistoria.TabIndex = 102
        Me.bt_AddHistoria.Text = "Añadir Historia"
        Me.bt_AddHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AddHistoria.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(7, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(168, 393)
        Me.DataGridView1.TabIndex = 101
        '
        'grpImporte
        '
        Me.grpImporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImporte.Controls.Add(Me.bt_modificar)
        Me.grpImporte.Controls.Add(Me.bt_AsignarFra)
        Me.grpImporte.Controls.Add(Me.bt_factura)
        Me.grpImporte.Controls.Add(Me.CtrlFormaPago21)
        Me.grpImporte.Controls.Add(Me.lb_ftexto)
        Me.grpImporte.Controls.Add(Me.lb_factura)
        Me.grpImporte.Controls.Add(Me.lb_total)
        Me.grpImporte.Controls.Add(Me.Label8)
        Me.grpImporte.Controls.Add(Me.lb_recibo)
        Me.grpImporte.Controls.Add(REFRECIBOLabel)
        Me.grpImporte.Controls.Add(Me.chb_recibo)
        Me.grpImporte.Controls.Add(IMPORTECLLabel)
        Me.grpImporte.Controls.Add(Me.tb_clinica)
        Me.grpImporte.Controls.Add(IMPORTEDRLabel)
        Me.grpImporte.Controls.Add(Me.tb_dr)
        Me.grpImporte.Location = New System.Drawing.Point(318, 218)
        Me.grpImporte.Name = "grpImporte"
        Me.grpImporte.Size = New System.Drawing.Size(643, 147)
        Me.grpImporte.TabIndex = 100
        Me.grpImporte.TabStop = False
        Me.grpImporte.Text = "Importe"
        '
        'bt_modificar
        '
        Me.bt_modificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.bt_modificar.Location = New System.Drawing.Point(207, 87)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(30, 23)
        Me.bt_modificar.TabIndex = 108
        Me.bt_modificar.ToolTipText = "Asignar Factura"
        '
        'bt_AsignarFra
        '
        Me.bt_AsignarFra.Image = Global.centro_medico.My.Resources.Resources.Facturas
        Me.bt_AsignarFra.Location = New System.Drawing.Point(237, 87)
        Me.bt_AsignarFra.Name = "bt_AsignarFra"
        Me.bt_AsignarFra.Size = New System.Drawing.Size(30, 23)
        Me.bt_AsignarFra.TabIndex = 108
        Me.bt_AsignarFra.ToolTipText = "Asignar Factura"
        '
        'bt_factura
        '
        Me.bt_factura.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.bt_factura.Location = New System.Drawing.Point(178, 87)
        Me.bt_factura.Name = "bt_factura"
        Me.bt_factura.Size = New System.Drawing.Size(30, 23)
        Me.bt_factura.TabIndex = 108
        Me.bt_factura.ToolTipText = "Emitir Factura"
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.DataBindings.Add(New System.Windows.Forms.Binding("ID_FORMASPAGO", Me.CITASBindingSource, "REFFORMAPAGO", True))
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(289, 43)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(312, 23)
        Me.CtrlFormaPago21.TabIndex = 107
        '
        'lb_ftexto
        '
        Me.lb_ftexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_ftexto.Location = New System.Drawing.Point(64, 89)
        Me.lb_ftexto.Name = "lb_ftexto"
        Me.lb_ftexto.Size = New System.Drawing.Size(111, 20)
        Me.lb_ftexto.TabIndex = 7
        '
        'lb_factura
        '
        Me.lb_factura.AutoSize = True
        Me.lb_factura.Location = New System.Drawing.Point(14, 92)
        Me.lb_factura.Name = "lb_factura"
        Me.lb_factura.Size = New System.Drawing.Size(46, 13)
        Me.lb_factura.TabIndex = 88
        Me.lb_factura.Text = "Factura:"
        '
        'lb_total
        '
        Me.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_total.Location = New System.Drawing.Point(176, 46)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(69, 20)
        Me.lb_total.TabIndex = 2
        Me.lb_total.Text = "0,00"
        Me.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Total"
        '
        'lb_recibo
        '
        Me.lb_recibo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_recibo.Location = New System.Drawing.Point(385, 89)
        Me.lb_recibo.Name = "lb_recibo"
        Me.lb_recibo.Size = New System.Drawing.Size(111, 20)
        Me.lb_recibo.TabIndex = 6
        '
        'chb_recibo
        '
        Me.chb_recibo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "REFRECIBO", True))
        Me.chb_recibo.Location = New System.Drawing.Point(317, 88)
        Me.chb_recibo.Name = "chb_recibo"
        Me.chb_recibo.Size = New System.Drawing.Size(19, 24)
        Me.chb_recibo.TabIndex = 65
        '
        'tb_clinica
        '
        Me.tb_clinica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "IMPORTECL", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.tb_clinica.Location = New System.Drawing.Point(13, 46)
        Me.tb_clinica.Name = "tb_clinica"
        Me.tb_clinica.ReadOnly = True
        Me.tb_clinica.Size = New System.Drawing.Size(65, 20)
        Me.tb_clinica.TabIndex = 0
        Me.tb_clinica.Text = "0,00"
        '
        'tb_dr
        '
        Me.tb_dr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "IMPORTEDR", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.tb_dr.Location = New System.Drawing.Point(89, 46)
        Me.tb_dr.Name = "tb_dr"
        Me.tb_dr.ReadOnly = True
        Me.tb_dr.Size = New System.Drawing.Size(75, 20)
        Me.tb_dr.TabIndex = 1
        Me.tb_dr.Text = "0,00"
        '
        'LineasCitasTableAdapter
        '
        Me.LineasCitasTableAdapter.ClearBeforeFill = True
        '
        'group_Proceso
        '
        Me.group_Proceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_Proceso.Controls.Add(Me.btnVerProceso)
        Me.group_Proceso.Controls.Add(Me.lblCitaProcesoInfo)
        Me.group_Proceso.Controls.Add(Me.btn_HistorialProcesos)
        Me.group_Proceso.Location = New System.Drawing.Point(752, 371)
        Me.group_Proceso.Name = "group_Proceso"
        Me.group_Proceso.Size = New System.Drawing.Size(200, 123)
        Me.group_Proceso.TabIndex = 108
        Me.group_Proceso.TabStop = False
        Me.group_Proceso.Text = "Proceso"
        '
        'btnVerProceso
        '
        Me.btnVerProceso.Enabled = False
        Me.btnVerProceso.Image = Global.centro_medico.My.Resources.Resources._24_image_open
        Me.btnVerProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerProceso.Location = New System.Drawing.Point(109, 70)
        Me.btnVerProceso.Name = "btnVerProceso"
        Me.btnVerProceso.Size = New System.Drawing.Size(85, 44)
        Me.btnVerProceso.TabIndex = 100
        Me.btnVerProceso.Text = "Ver Proceso"
        Me.btnVerProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerProceso.UseVisualStyleBackColor = True
        '
        'lblCitaProcesoInfo
        '
        Me.lblCitaProcesoInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitaProcesoInfo.Location = New System.Drawing.Point(15, 20)
        Me.lblCitaProcesoInfo.Name = "lblCitaProcesoInfo"
        Me.lblCitaProcesoInfo.Size = New System.Drawing.Size(171, 40)
        Me.lblCitaProcesoInfo.TabIndex = 99
        Me.lblCitaProcesoInfo.Text = "Esta cita no se encuentra vinculada a ningun proceso"
        '
        'btn_HistorialProcesos
        '
        Me.btn_HistorialProcesos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_HistorialProcesos.Image = Global.centro_medico.My.Resources.Resources._24_imageset
        Me.btn_HistorialProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistorialProcesos.Location = New System.Drawing.Point(11, 70)
        Me.btn_HistorialProcesos.Name = "btn_HistorialProcesos"
        Me.btn_HistorialProcesos.Size = New System.Drawing.Size(92, 43)
        Me.btn_HistorialProcesos.TabIndex = 98
        Me.btn_HistorialProcesos.Text = "Historial de Procesos"
        Me.btn_HistorialProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HistorialProcesos.UseVisualStyleBackColor = True
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(713, 0)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 27)
        Me.CtrlStatusPaciente1.TabIndex = 107
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFACTURABLESBindingSource
        '
        Me.CONCEPTOSFACTURABLESBindingSource.DataMember = "CONCEPTOSFACTURABLES"
        Me.CONCEPTOSFACTURABLESBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFACTURABLESTableAdapter
        '
        Me.CONCEPTOSFACTURABLESTableAdapter.ClearBeforeFill = True
        '
        'frmCita_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 672)
        Me.Controls.Add(Me.group_Proceso)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(Me.bt_DelLinea)
        Me.Controls.Add(Me.bt_AddLinea)
        Me.Controls.Add(Me.dg_LineasCitas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_AddHistoria)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpImporte)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCita_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir/Modificar Cita"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_citaMultiple.ResumeLayout(False)
        Me.gb_citaMultiple.PerformLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFechaSimple.ResumeLayout(False)
        Me.GroupBoxFechaSimple.PerformLayout()
        CType(Me.dg_LineasCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImporte.ResumeLayout(False)
        Me.grpImporte.PerformLayout()
        Me.group_Proceso.ResumeLayout(False)
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_HacerVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_DebitoPaciente As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents cb_citaMultiple As System.Windows.Forms.CheckBox
    Friend WithEvents gb_citaMultiple As System.Windows.Forms.GroupBox
    Friend WithEvents tb_horafincm As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horainiciocm As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_sab As System.Windows.Forms.CheckBox
    Friend WithEvents chb_vie As System.Windows.Forms.CheckBox
    Friend WithEvents chb_mier As System.Windows.Forms.CheckBox
    Friend WithEvents chb_mar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_dom As System.Windows.Forms.CheckBox
    Friend WithEvents chb_jue As System.Windows.Forms.CheckBox
    Friend WithEvents chb_lun As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechacm As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_aseguradora As System.Windows.Forms.ComboBox
    Friend WithEvents chb_aseguradora As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxFechaSimple As System.Windows.Forms.GroupBox
    Friend WithEvents tb_horafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_aviso As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents tb_notas As System.Windows.Forms.TextBox
    Friend WithEvents bt_DelLinea As System.Windows.Forms.Button
    Friend WithEvents bt_AddLinea As System.Windows.Forms.Button
    Friend WithEvents dg_LineasCitas As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstrip_Info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_AddHistoria As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpImporte As System.Windows.Forms.GroupBox
    Friend WithEvents lb_ftexto As System.Windows.Forms.Label
    Friend WithEvents lb_factura As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lb_recibo As System.Windows.Forms.Label
    Friend WithEvents chb_recibo As System.Windows.Forms.CheckBox
    Friend WithEvents tb_clinica As System.Windows.Forms.TextBox
    Friend WithEvents tb_dr As System.Windows.Forms.TextBox
    Friend WithEvents LineasCitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineasCitasTableAdapter As centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents group_Proceso As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerProceso As System.Windows.Forms.Button
    Friend WithEvents lblCitaProcesoInfo As System.Windows.Forms.Label
    Friend WithEvents btn_HistorialProcesos As System.Windows.Forms.Button
    Friend WithEvents PAGADAUICheckBox As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents FALTAUICheckBox As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ATENDIDOUICheckBox As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CONFIRMADAUICheckBox As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents dtp_fechacobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents RefConceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBuscar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents IdLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteClinicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_AsignarFra As Janus.Windows.EditControls.UIButton
    Friend WithEvents bt_factura As Janus.Windows.EditControls.UIButton
    Friend WithEvents bt_modificar As Janus.Windows.EditControls.UIButton
    Friend WithEvents CONCEPTOSFACTURABLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESTableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
End Class
