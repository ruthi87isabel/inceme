<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_citas
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
        Dim FECHALabel As System.Windows.Forms.Label
        Dim HORALabel As System.Windows.Forms.Label
        Dim IMPORTEDRLabel As System.Windows.Forms.Label
        Dim IMPORTECLLabel As System.Windows.Forms.Label
        Dim REFFORMAPAGOLabel As System.Windows.Forms.Label
        Dim HORAFINLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim CONFIRMADALabel As System.Windows.Forms.Label
        Dim ATENDIDOLabel As System.Windows.Forms.Label
        Dim FALTALabel As System.Windows.Forms.Label
        Dim PAGADALabel As System.Windows.Forms.Label
        Dim REFRECIBOLabel As System.Windows.Forms.Label
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_citas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column19.ButtonImage")
        Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Dim GridEX1_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column4.ButtonImage")
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.dtp_fechacobro = New System.Windows.Forms.DateTimePicker()
        Me.chb_confirmada = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pb_UndoCobrar = New System.Windows.Forms.PictureBox()
        Me.chb_pagada = New System.Windows.Forms.CheckBox()
        Me.chb_falta = New System.Windows.Forms.CheckBox()
        Me.chb_atendido = New System.Windows.Forms.CheckBox()
        Me.grpImporte = New System.Windows.Forms.GroupBox()
        Me.pnl_Facturar = New System.Windows.Forms.Panel()
        Me.bt_factura = New System.Windows.Forms.Button()
        Me.btn_DesasociarFactura = New System.Windows.Forms.Button()
        Me.txtDescuentoTotal = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_ftexto = New System.Windows.Forms.Label()
        Me.lb_factura = New System.Windows.Forms.Label()
        Me.pb_facturas = New System.Windows.Forms.PictureBox()
        Me.txtDuracion = New System.Windows.Forms.Label()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.pb_citas = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_forma = New System.Windows.Forms.Label()
        Me.lb_recibo = New System.Windows.Forms.Label()
        Me.bt_forma = New System.Windows.Forms.Button()
        Me.chb_recibo = New System.Windows.Forms.CheckBox()
        Me.tb_clinica = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dr = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_idforma = New centro_medico.ctrlTextboxAvanzado()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bntAsistenteFacturacion = New System.Windows.Forms.Button()
        Me.grpFechaHora = New System.Windows.Forms.GroupBox()
        Me.lblHorarioEspecial = New System.Windows.Forms.Label()
        Me.tb_horafin = New System.Windows.Forms.DateTimePicker()
        Me.tb_horainicio = New System.Windows.Forms.DateTimePicker()
        Me.lb_aviso = New System.Windows.Forms.Label()
        Me.chb_aseguradora = New System.Windows.Forms.CheckBox()
        Me.cb_aseguradora = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bt_AddHistoria = New System.Windows.Forms.Button()
        Me.bt_ActualizaNumeracion = New System.Windows.Forms.Button()
        Me.bt_actualiza_cbMutuas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gb_citaMultiple = New System.Windows.Forms.GroupBox()
        Me.tb_horafincm = New System.Windows.Forms.DateTimePicker()
        Me.tb_horainiciocm = New System.Windows.Forms.DateTimePicker()
        Me.chb_sab = New System.Windows.Forms.CheckBox()
        Me.chb_vie = New System.Windows.Forms.CheckBox()
        Me.chb_mier = New System.Windows.Forms.CheckBox()
        Me.chb_mar = New System.Windows.Forms.CheckBox()
        Me.chb_dom = New System.Windows.Forms.CheckBox()
        Me.chb_jue = New System.Windows.Forms.CheckBox()
        Me.chb_lun = New System.Windows.Forms.CheckBox()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechacm = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBcitas = New System.Windows.Forms.ComboBox()
        Me.grp_SalaDisponible = New System.Windows.Forms.GroupBox()
        Me.lnkSugerirHorario = New System.Windows.Forms.LinkLabel()
        Me.lblDispo = New System.Windows.Forms.Label()
        Me.CtrlSalasvb1 = New centro_medico.ctrlSalasvb()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnDental = New System.Windows.Forms.Button()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.cb_citaMultiple = New System.Windows.Forms.CheckBox()
        Me.lblEdicionDesactivada = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsdb_imprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_imprimircita = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_imprimirjustificante = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsVerPacienteSeleccionado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsd_ventas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HacerTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsb_DebitoPaciente = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstrip_Info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dg_LineasCitas = New System.Windows.Forms.DataGridView()
        Me.LineasCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_AddLinea = New System.Windows.Forms.Button()
        Me.bt_DelLinea = New System.Windows.Forms.Button()
        Me.btn_HistorialProcesos = New System.Windows.Forms.Button()
        Me.group_Proceso = New System.Windows.Forms.GroupBox()
        Me.btnVerProceso = New System.Windows.Forms.Button()
        Me.lblCitaProcesoInfo = New System.Windows.Forms.Label()
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter()
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter()
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter()
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.LINEASFACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter()
        Me.LINEASFACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter()
        Me.LineasCitasTableAdapter = New centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter()
        Me.ConceptosFacturablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.HISTORIALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAddLineasGenericas = New System.Windows.Forms.Button()
        Me.lblCitaEliminada = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContadorBono1 = New centro_medico.contadorBono()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        Me.tb_notas = New centro_medico.ctrlTextboxAvanzado()
        Me.colIdCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBuscar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colRefConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporteClinica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporteDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDtoImp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FECHALabel = New System.Windows.Forms.Label()
        HORALabel = New System.Windows.Forms.Label()
        IMPORTEDRLabel = New System.Windows.Forms.Label()
        IMPORTECLLabel = New System.Windows.Forms.Label()
        REFFORMAPAGOLabel = New System.Windows.Forms.Label()
        HORAFINLabel = New System.Windows.Forms.Label()
        NOTASLabel = New System.Windows.Forms.Label()
        CONFIRMADALabel = New System.Windows.Forms.Label()
        ATENDIDOLabel = New System.Windows.Forms.Label()
        FALTALabel = New System.Windows.Forms.Label()
        PAGADALabel = New System.Windows.Forms.Label()
        REFRECIBOLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImporte.SuspendLayout()
        Me.pnl_Facturar.SuspendLayout()
        CType(Me.pb_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_citas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFechaHora.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gb_citaMultiple.SuspendLayout()
        Me.grp_SalaDisponible.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dg_LineasCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Proceso.SuspendLayout()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConceptosFacturablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(6, 52)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 35
        FECHALabel.Text = "Fecha:"
        '
        'HORALabel
        '
        HORALabel.AutoSize = True
        HORALabel.Location = New System.Drawing.Point(101, 53)
        HORALabel.Name = "HORALabel"
        HORALabel.Size = New System.Drawing.Size(61, 13)
        HORALabel.TabIndex = 37
        HORALabel.Text = "Hora Inicio:"
        AddHandler HORALabel.Click, AddressOf Me.HORALabel_Click
        '
        'IMPORTEDRLabel
        '
        IMPORTEDRLabel.AutoSize = True
        IMPORTEDRLabel.Location = New System.Drawing.Point(63, 16)
        IMPORTEDRLabel.Name = "IMPORTEDRLabel"
        IMPORTEDRLabel.Size = New System.Drawing.Size(42, 13)
        IMPORTEDRLabel.TabIndex = 45
        IMPORTEDRLabel.Text = "Doctor:"
        '
        'IMPORTECLLabel
        '
        IMPORTECLLabel.AutoSize = True
        IMPORTECLLabel.Location = New System.Drawing.Point(6, 18)
        IMPORTECLLabel.Name = "IMPORTECLLabel"
        IMPORTECLLabel.Size = New System.Drawing.Size(41, 13)
        IMPORTECLLabel.TabIndex = 47
        IMPORTECLLabel.Text = "Clinica:"
        '
        'REFFORMAPAGOLabel
        '
        REFFORMAPAGOLabel.AutoSize = True
        REFFORMAPAGOLabel.Location = New System.Drawing.Point(309, 16)
        REFFORMAPAGOLabel.Name = "REFFORMAPAGOLabel"
        REFFORMAPAGOLabel.Size = New System.Drawing.Size(66, 13)
        REFFORMAPAGOLabel.TabIndex = 63
        REFFORMAPAGOLabel.Text = "Forma pago:"
        '
        'HORAFINLabel
        '
        HORAFINLabel.AutoSize = True
        HORAFINLabel.Location = New System.Drawing.Point(179, 53)
        HORAFINLabel.Name = "HORAFINLabel"
        HORAFINLabel.Size = New System.Drawing.Size(47, 13)
        HORAFINLabel.TabIndex = 65
        HORAFINLabel.Text = "Hora fin:"
        '
        'NOTASLabel
        '
        NOTASLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(224, 527)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(15, 65)
        NOTASLabel.TabIndex = 70
        NOTASLabel.Text = "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s"
        '
        'CONFIRMADALabel
        '
        CONFIRMADALabel.AutoSize = True
        CONFIRMADALabel.Location = New System.Drawing.Point(5, 47)
        CONFIRMADALabel.Name = "CONFIRMADALabel"
        CONFIRMADALabel.Size = New System.Drawing.Size(63, 13)
        CONFIRMADALabel.TabIndex = 71
        CONFIRMADALabel.Text = "Confirmada:"
        '
        'ATENDIDOLabel
        '
        ATENDIDOLabel.AutoSize = True
        ATENDIDOLabel.Location = New System.Drawing.Point(16, 70)
        ATENDIDOLabel.Name = "ATENDIDOLabel"
        ATENDIDOLabel.Size = New System.Drawing.Size(52, 13)
        ATENDIDOLabel.TabIndex = 73
        ATENDIDOLabel.Text = "Atendida:"
        '
        'FALTALabel
        '
        FALTALabel.AutoSize = True
        FALTALabel.Location = New System.Drawing.Point(33, 94)
        FALTALabel.Name = "FALTALabel"
        FALTALabel.Size = New System.Drawing.Size(33, 13)
        FALTALabel.TabIndex = 73
        FALTALabel.Text = "Falta:"
        AddHandler FALTALabel.Click, AddressOf Me.FALTALabel_Click
        '
        'PAGADALabel
        '
        PAGADALabel.AutoSize = True
        PAGADALabel.Location = New System.Drawing.Point(7, 118)
        PAGADALabel.Name = "PAGADALabel"
        PAGADALabel.Size = New System.Drawing.Size(50, 13)
        PAGADALabel.TabIndex = 74
        PAGADALabel.Text = "Cobrada:"
        AddHandler PAGADALabel.Click, AddressOf Me.PAGADALabel_Click
        '
        'REFRECIBOLabel
        '
        REFRECIBOLabel.AutoSize = True
        REFRECIBOLabel.Location = New System.Drawing.Point(34, 62)
        REFRECIBOLabel.Name = "REFRECIBOLabel"
        REFRECIBOLabel.Size = New System.Drawing.Size(44, 13)
        REFRECIBOLabel.TabIndex = 64
        REFRECIBOLabel.Text = "Recibo:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(134, 120)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(29, 13)
        Label3.TabIndex = 5
        Label3.Text = "Sab:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(69, 120)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(25, 13)
        Label4.TabIndex = 4
        Label4.Text = "Vie:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(134, 101)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(30, 13)
        Label5.TabIndex = 2
        Label5.Text = "Mier:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(69, 101)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(28, 13)
        Label1.TabIndex = 1
        Label1.Text = "Mar:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(8, 136)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(32, 13)
        Label2.TabIndex = 6
        Label2.Text = "Dom:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 120)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(27, 13)
        Label6.TabIndex = 3
        Label6.Text = "Jue:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(12, 101)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(28, 13)
        Label9.TabIndex = 0
        Label9.Text = "Lun:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(124, 15)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(65, 13)
        Label10.TabIndex = 68
        Label10.Text = "Fecha Final:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(12, 16)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(70, 13)
        Label11.TabIndex = 35
        Label11.Text = "Fecha Inicial:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(12, 58)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(61, 13)
        Label12.TabIndex = 37
        Label12.Text = "Hora Inicio:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(124, 58)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(47, 13)
        Label13.TabIndex = 65
        Label13.Text = "Hora fin:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(122, 16)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(27, 13)
        Label7.TabIndex = 91
        Label7.Text = "Dto:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(9, 68)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(85, 20)
        Me.dtp_fecha.TabIndex = 36
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
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtp_fechacobro
        '
        Me.dtp_fechacobro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "FECHACOBRO", True))
        Me.dtp_fechacobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechacobro.Location = New System.Drawing.Point(6, 19)
        Me.dtp_fechacobro.Name = "dtp_fechacobro"
        Me.dtp_fechacobro.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fechacobro.TabIndex = 2
        '
        'chb_confirmada
        '
        Me.chb_confirmada.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "CONFIRMADA", True))
        Me.chb_confirmada.Location = New System.Drawing.Point(70, 42)
        Me.chb_confirmada.Name = "chb_confirmada"
        Me.chb_confirmada.Size = New System.Drawing.Size(24, 24)
        Me.chb_confirmada.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_UndoCobrar)
        Me.GroupBox1.Controls.Add(PAGADALabel)
        Me.GroupBox1.Controls.Add(Me.chb_pagada)
        Me.GroupBox1.Controls.Add(FALTALabel)
        Me.GroupBox1.Controls.Add(Me.chb_falta)
        Me.GroupBox1.Controls.Add(ATENDIDOLabel)
        Me.GroupBox1.Controls.Add(Me.chb_atendido)
        Me.GroupBox1.Controls.Add(CONFIRMADALabel)
        Me.GroupBox1.Controls.Add(Me.chb_confirmada)
        Me.GroupBox1.Controls.Add(Me.dtp_fechacobro)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 154)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'pb_UndoCobrar
        '
        Me.pb_UndoCobrar.Image = CType(resources.GetObject("pb_UndoCobrar.Image"), System.Drawing.Image)
        Me.pb_UndoCobrar.Location = New System.Drawing.Point(78, 116)
        Me.pb_UndoCobrar.Name = "pb_UndoCobrar"
        Me.pb_UndoCobrar.Size = New System.Drawing.Size(16, 16)
        Me.pb_UndoCobrar.TabIndex = 75
        Me.pb_UndoCobrar.TabStop = False
        Me.pb_UndoCobrar.Visible = False
        '
        'chb_pagada
        '
        Me.chb_pagada.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "PAGADA", True))
        Me.chb_pagada.Location = New System.Drawing.Point(64, 113)
        Me.chb_pagada.Name = "chb_pagada"
        Me.chb_pagada.Size = New System.Drawing.Size(16, 24)
        Me.chb_pagada.TabIndex = 1
        '
        'chb_falta
        '
        Me.chb_falta.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "FALTA", True))
        Me.chb_falta.Location = New System.Drawing.Point(70, 89)
        Me.chb_falta.Name = "chb_falta"
        Me.chb_falta.Size = New System.Drawing.Size(18, 24)
        Me.chb_falta.TabIndex = 0
        '
        'chb_atendido
        '
        Me.chb_atendido.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "ATENDIDO", True))
        Me.chb_atendido.Location = New System.Drawing.Point(70, 65)
        Me.chb_atendido.Name = "chb_atendido"
        Me.chb_atendido.Size = New System.Drawing.Size(24, 24)
        Me.chb_atendido.TabIndex = 1
        '
        'grpImporte
        '
        Me.grpImporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImporte.Controls.Add(Me.pnl_Facturar)
        Me.grpImporte.Controls.Add(Label7)
        Me.grpImporte.Controls.Add(Me.txtDescuentoTotal)
        Me.grpImporte.Controls.Add(Me.lb_ftexto)
        Me.grpImporte.Controls.Add(Me.lb_factura)
        Me.grpImporte.Controls.Add(Me.pb_facturas)
        Me.grpImporte.Controls.Add(Me.txtDuracion)
        Me.grpImporte.Controls.Add(Me.lb_total)
        Me.grpImporte.Controls.Add(Me.pb_citas)
        Me.grpImporte.Controls.Add(Me.Label14)
        Me.grpImporte.Controls.Add(Me.Label8)
        Me.grpImporte.Controls.Add(Me.lb_forma)
        Me.grpImporte.Controls.Add(Me.lb_recibo)
        Me.grpImporte.Controls.Add(Me.bt_forma)
        Me.grpImporte.Controls.Add(REFRECIBOLabel)
        Me.grpImporte.Controls.Add(Me.chb_recibo)
        Me.grpImporte.Controls.Add(IMPORTECLLabel)
        Me.grpImporte.Controls.Add(Me.tb_clinica)
        Me.grpImporte.Controls.Add(IMPORTEDRLabel)
        Me.grpImporte.Controls.Add(Me.tb_dr)
        Me.grpImporte.Controls.Add(REFFORMAPAGOLabel)
        Me.grpImporte.Controls.Add(Me.tb_idforma)
        Me.grpImporte.Location = New System.Drawing.Point(351, 245)
        Me.grpImporte.Name = "grpImporte"
        Me.grpImporte.Size = New System.Drawing.Size(448, 154)
        Me.grpImporte.TabIndex = 74
        Me.grpImporte.TabStop = False
        Me.grpImporte.Text = "Importe"
        '
        'pnl_Facturar
        '
        Me.pnl_Facturar.Controls.Add(Me.bt_factura)
        Me.pnl_Facturar.Controls.Add(Me.btn_DesasociarFactura)
        Me.pnl_Facturar.Location = New System.Drawing.Point(140, 107)
        Me.pnl_Facturar.Name = "pnl_Facturar"
        Me.pnl_Facturar.Size = New System.Drawing.Size(308, 42)
        Me.pnl_Facturar.TabIndex = 101
        '
        'bt_factura
        '
        Me.bt_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_factura.Image = CType(resources.GetObject("bt_factura.Image"), System.Drawing.Image)
        Me.bt_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_factura.Location = New System.Drawing.Point(3, 1)
        Me.bt_factura.Name = "bt_factura"
        Me.bt_factura.Size = New System.Drawing.Size(98, 38)
        Me.bt_factura.TabIndex = 9
        Me.bt_factura.Text = "Emitir Factura"
        Me.bt_factura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bt_factura, "Emitir Factura")
        Me.bt_factura.UseVisualStyleBackColor = True
        '
        'btn_DesasociarFactura
        '
        Me.btn_DesasociarFactura.Image = CType(resources.GetObject("btn_DesasociarFactura.Image"), System.Drawing.Image)
        Me.btn_DesasociarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_DesasociarFactura.Location = New System.Drawing.Point(101, 1)
        Me.btn_DesasociarFactura.Name = "btn_DesasociarFactura"
        Me.btn_DesasociarFactura.Size = New System.Drawing.Size(134, 38)
        Me.btn_DesasociarFactura.TabIndex = 8
        Me.btn_DesasociarFactura.Text = "Desvincular Factura"
        Me.btn_DesasociarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DesasociarFactura.UseVisualStyleBackColor = True
        Me.btn_DesasociarFactura.Visible = False
        '
        'txtDescuentoTotal
        '
        Me.txtDescuentoTotal.AcceptsReturn = True
        Me.txtDescuentoTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "Descuento", True))
        Me.txtDescuentoTotal.Location = New System.Drawing.Point(122, 34)
        Me.txtDescuentoTotal.Name = "txtDescuentoTotal"
        Me.txtDescuentoTotal.ReadOnly = True
        Me.txtDescuentoTotal.Size = New System.Drawing.Size(50, 20)
        Me.txtDescuentoTotal.TabIndex = 90
        Me.txtDescuentoTotal.Text = "0,00"
        '
        'lb_ftexto
        '
        Me.lb_ftexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_ftexto.Location = New System.Drawing.Point(131, 77)
        Me.lb_ftexto.Name = "lb_ftexto"
        Me.lb_ftexto.Size = New System.Drawing.Size(93, 20)
        Me.lb_ftexto.TabIndex = 7
        Me.lb_ftexto.Visible = False
        '
        'lb_factura
        '
        Me.lb_factura.AutoSize = True
        Me.lb_factura.Location = New System.Drawing.Point(128, 59)
        Me.lb_factura.Name = "lb_factura"
        Me.lb_factura.Size = New System.Drawing.Size(43, 13)
        Me.lb_factura.TabIndex = 88
        Me.lb_factura.Text = "Factura"
        Me.lb_factura.Visible = False
        '
        'pb_facturas
        '
        Me.pb_facturas.Image = CType(resources.GetObject("pb_facturas.Image"), System.Drawing.Image)
        Me.pb_facturas.Location = New System.Drawing.Point(343, 79)
        Me.pb_facturas.Name = "pb_facturas"
        Me.pb_facturas.Size = New System.Drawing.Size(25, 23)
        Me.pb_facturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_facturas.TabIndex = 86
        Me.pb_facturas.TabStop = False
        Me.pb_facturas.Visible = False
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDuracion.Location = New System.Drawing.Point(255, 33)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(47, 20)
        Me.txtDuracion.TabIndex = 2
        Me.txtDuracion.Text = "00,00"
        Me.txtDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_total
        '
        Me.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_total.Location = New System.Drawing.Point(178, 34)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(76, 20)
        Me.lb_total.TabIndex = 2
        Me.lb_total.Text = "0,00"
        Me.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pb_citas
        '
        Me.pb_citas.Image = CType(resources.GetObject("pb_citas.Image"), System.Drawing.Image)
        Me.pb_citas.Location = New System.Drawing.Point(312, 79)
        Me.pb_citas.Name = "pb_citas"
        Me.pb_citas.Size = New System.Drawing.Size(25, 23)
        Me.pb_citas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_citas.TabIndex = 85
        Me.pb_citas.TabStop = False
        Me.pb_citas.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Duración"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Total"
        '
        'lb_forma
        '
        Me.lb_forma.AutoSize = True
        Me.lb_forma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_forma.Location = New System.Drawing.Point(312, 57)
        Me.lb_forma.Name = "lb_forma"
        Me.lb_forma.Size = New System.Drawing.Size(117, 15)
        Me.lb_forma.TabIndex = 5
        Me.lb_forma.Text = "                                    "
        '
        'lb_recibo
        '
        Me.lb_recibo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_recibo.Location = New System.Drawing.Point(6, 78)
        Me.lb_recibo.Name = "lb_recibo"
        Me.lb_recibo.Size = New System.Drawing.Size(111, 20)
        Me.lb_recibo.TabIndex = 6
        '
        'bt_forma
        '
        Me.bt_forma.BackgroundImage = CType(resources.GetObject("bt_forma.BackgroundImage"), System.Drawing.Image)
        Me.bt_forma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_forma.Location = New System.Drawing.Point(388, 31)
        Me.bt_forma.Name = "bt_forma"
        Me.bt_forma.Size = New System.Drawing.Size(36, 23)
        Me.bt_forma.TabIndex = 4
        Me.bt_forma.UseVisualStyleBackColor = True
        '
        'chb_recibo
        '
        Me.chb_recibo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "REFRECIBO", True))
        Me.chb_recibo.Location = New System.Drawing.Point(9, 57)
        Me.chb_recibo.Name = "chb_recibo"
        Me.chb_recibo.Size = New System.Drawing.Size(25, 24)
        Me.chb_recibo.TabIndex = 65
        '
        'tb_clinica
        '
        Me.tb_clinica.AcceptsReturn = True
        Me.tb_clinica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "IMPORTECL", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.tb_clinica.Location = New System.Drawing.Point(6, 34)
        Me.tb_clinica.Name = "tb_clinica"
        Me.tb_clinica.ReadOnly = True
        Me.tb_clinica.Size = New System.Drawing.Size(53, 20)
        Me.tb_clinica.TabIndex = 0
        Me.tb_clinica.Text = "0,00"
        '
        'tb_dr
        '
        Me.tb_dr.AcceptsReturn = True
        Me.tb_dr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "IMPORTEDR", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.tb_dr.Location = New System.Drawing.Point(63, 34)
        Me.tb_dr.Name = "tb_dr"
        Me.tb_dr.ReadOnly = True
        Me.tb_dr.Size = New System.Drawing.Size(55, 20)
        Me.tb_dr.TabIndex = 1
        Me.tb_dr.Text = "0,00"
        '
        'tb_idforma
        '
        Me.tb_idforma.AcceptsReturn = True
        Me.tb_idforma.BackColor = System.Drawing.Color.White
        Me.tb_idforma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "REFFORMAPAGO", True))
        Me.tb_idforma.Location = New System.Drawing.Point(312, 34)
        Me.tb_idforma.Name = "tb_idforma"
        Me.tb_idforma.Size = New System.Drawing.Size(75, 20)
        Me.tb_idforma.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'bntAsistenteFacturacion
        '
        Me.bntAsistenteFacturacion.AutoSize = True
        Me.bntAsistenteFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bntAsistenteFacturacion.Image = CType(resources.GetObject("bntAsistenteFacturacion.Image"), System.Drawing.Image)
        Me.bntAsistenteFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntAsistenteFacturacion.Location = New System.Drawing.Point(353, 352)
        Me.bntAsistenteFacturacion.Name = "bntAsistenteFacturacion"
        Me.bntAsistenteFacturacion.Size = New System.Drawing.Size(133, 38)
        Me.bntAsistenteFacturacion.TabIndex = 101
        Me.bntAsistenteFacturacion.Text = "Asist. Facturación"
        Me.bntAsistenteFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntAsistenteFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntAsistenteFacturacion.UseVisualStyleBackColor = True
        '
        'grpFechaHora
        '
        Me.grpFechaHora.Controls.Add(Me.lblHorarioEspecial)
        Me.grpFechaHora.Controls.Add(Me.tb_horafin)
        Me.grpFechaHora.Controls.Add(Me.tb_horainicio)
        Me.grpFechaHora.Controls.Add(Me.lb_aviso)
        Me.grpFechaHora.Controls.Add(FECHALabel)
        Me.grpFechaHora.Controls.Add(Me.dtp_fecha)
        Me.grpFechaHora.Controls.Add(HORALabel)
        Me.grpFechaHora.Controls.Add(HORAFINLabel)
        Me.grpFechaHora.Location = New System.Drawing.Point(15, 102)
        Me.grpFechaHora.Name = "grpFechaHora"
        Me.grpFechaHora.Size = New System.Drawing.Size(249, 96)
        Me.grpFechaHora.TabIndex = 75
        Me.grpFechaHora.TabStop = False
        Me.grpFechaHora.Text = "Fecha"
        '
        'lblHorarioEspecial
        '
        Me.lblHorarioEspecial.AutoSize = True
        Me.lblHorarioEspecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarioEspecial.ForeColor = System.Drawing.Color.Green
        Me.lblHorarioEspecial.Location = New System.Drawing.Point(10, 13)
        Me.lblHorarioEspecial.Name = "lblHorarioEspecial"
        Me.lblHorarioEspecial.Size = New System.Drawing.Size(84, 13)
        Me.lblHorarioEspecial.TabIndex = 71
        Me.lblHorarioEspecial.Text = "Horario ESpecial"
        Me.lblHorarioEspecial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHorarioEspecial.Visible = False
        '
        'tb_horafin
        '
        Me.tb_horafin.CustomFormat = "HH:mm"
        Me.tb_horafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horafin.Location = New System.Drawing.Point(182, 68)
        Me.tb_horafin.Name = "tb_horafin"
        Me.tb_horafin.ShowUpDown = True
        Me.tb_horafin.Size = New System.Drawing.Size(58, 20)
        Me.tb_horafin.TabIndex = 70
        '
        'tb_horainicio
        '
        Me.tb_horainicio.CustomFormat = "HH:mm"
        Me.tb_horainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horainicio.Location = New System.Drawing.Point(104, 68)
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
        'chb_aseguradora
        '
        Me.chb_aseguradora.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CITASBindingSource, "REFPROCEDENCIA", True))
        Me.chb_aseguradora.Enabled = False
        Me.chb_aseguradora.Location = New System.Drawing.Point(394, 118)
        Me.chb_aseguradora.Name = "chb_aseguradora"
        Me.chb_aseguradora.Size = New System.Drawing.Size(177, 24)
        Me.chb_aseguradora.TabIndex = 78
        Me.chb_aseguradora.Text = "Cita de mutua\aseguradora:"
        '
        'cb_aseguradora
        '
        Me.cb_aseguradora.DisplayMember = "NOMBRE"
        Me.cb_aseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_aseguradora.Enabled = False
        Me.cb_aseguradora.FormattingEnabled = True
        Me.cb_aseguradora.Location = New System.Drawing.Point(394, 144)
        Me.cb_aseguradora.Name = "cb_aseguradora"
        Me.cb_aseguradora.Size = New System.Drawing.Size(220, 21)
        Me.cb_aseguradora.TabIndex = 0
        Me.cb_aseguradora.ValueMember = "REFMUTUA"
        '
        'bt_AddHistoria
        '
        Me.bt_AddHistoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_AddHistoria.FlatAppearance.BorderSize = 0
        Me.bt_AddHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_AddHistoria.Image = CType(resources.GetObject("bt_AddHistoria.Image"), System.Drawing.Image)
        Me.bt_AddHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AddHistoria.Location = New System.Drawing.Point(5, 562)
        Me.bt_AddHistoria.Name = "bt_AddHistoria"
        Me.bt_AddHistoria.Size = New System.Drawing.Size(108, 32)
        Me.bt_AddHistoria.TabIndex = 92
        Me.bt_AddHistoria.Text = "Añadir Historia"
        Me.bt_AddHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bt_AddHistoria, "Añadir a la Historia")
        Me.bt_AddHistoria.UseVisualStyleBackColor = True
        '
        'bt_ActualizaNumeracion
        '
        Me.bt_ActualizaNumeracion.Image = CType(resources.GetObject("bt_ActualizaNumeracion.Image"), System.Drawing.Image)
        Me.bt_ActualizaNumeracion.Location = New System.Drawing.Point(713, 23)
        Me.bt_ActualizaNumeracion.Name = "bt_ActualizaNumeracion"
        Me.bt_ActualizaNumeracion.Size = New System.Drawing.Size(23, 22)
        Me.bt_ActualizaNumeracion.TabIndex = 102
        Me.ToolTip1.SetToolTip(Me.bt_ActualizaNumeracion, "Chequear numeración")
        Me.bt_ActualizaNumeracion.UseVisualStyleBackColor = True
        '
        'bt_actualiza_cbMutuas
        '
        Me.bt_actualiza_cbMutuas.Image = CType(resources.GetObject("bt_actualiza_cbMutuas.Image"), System.Drawing.Image)
        Me.bt_actualiza_cbMutuas.Location = New System.Drawing.Point(620, 144)
        Me.bt_actualiza_cbMutuas.Name = "bt_actualiza_cbMutuas"
        Me.bt_actualiza_cbMutuas.Size = New System.Drawing.Size(23, 22)
        Me.bt_actualiza_cbMutuas.TabIndex = 87
        Me.bt_actualiza_cbMutuas.UseVisualStyleBackColor = True
        Me.bt_actualiza_cbMutuas.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.gb_citaMultiple)
        Me.Panel1.Controls.Add(Me.bt_ActualizaNumeracion)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.CBcitas)
        Me.Panel1.Controls.Add(Me.grp_SalaDisponible)
        Me.Panel1.Controls.Add(Me.CtrlSalasvb1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.btnDental)
        Me.Panel1.Controls.Add(Me.CtrlMedico1)
        Me.Panel1.Controls.Add(Me.cb_citaMultiple)
        Me.Panel1.Controls.Add(Me.bt_actualiza_cbMutuas)
        Me.Panel1.Controls.Add(Me.cb_aseguradora)
        Me.Panel1.Controls.Add(Me.chb_aseguradora)
        Me.Panel1.Controls.Add(Me.grpFechaHora)
        Me.Panel1.Location = New System.Drawing.Point(5, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 211)
        Me.Panel1.TabIndex = 91
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
        Me.gb_citaMultiple.Location = New System.Drawing.Point(751, 6)
        Me.gb_citaMultiple.Name = "gb_citaMultiple"
        Me.gb_citaMultiple.Size = New System.Drawing.Size(244, 168)
        Me.gb_citaMultiple.TabIndex = 92
        Me.gb_citaMultiple.TabStop = False
        Me.gb_citaMultiple.Text = "Fecha cita múltiple"
        Me.gb_citaMultiple.Visible = False
        '
        'tb_horafincm
        '
        Me.tb_horafincm.CustomFormat = "HH:mm"
        Me.tb_horafincm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horafincm.Location = New System.Drawing.Point(127, 75)
        Me.tb_horafincm.Name = "tb_horafincm"
        Me.tb_horafincm.ShowUpDown = True
        Me.tb_horafincm.Size = New System.Drawing.Size(58, 20)
        Me.tb_horafincm.TabIndex = 72
        '
        'tb_horainiciocm
        '
        Me.tb_horainiciocm.CustomFormat = "HH:mm"
        Me.tb_horainiciocm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horainiciocm.Location = New System.Drawing.Point(17, 75)
        Me.tb_horainiciocm.Name = "tb_horainiciocm"
        Me.tb_horainiciocm.ShowUpDown = True
        Me.tb_horainiciocm.Size = New System.Drawing.Size(58, 20)
        Me.tb_horainiciocm.TabIndex = 71
        '
        'chb_sab
        '
        Me.chb_sab.Location = New System.Drawing.Point(170, 115)
        Me.chb_sab.Name = "chb_sab"
        Me.chb_sab.Size = New System.Drawing.Size(18, 24)
        Me.chb_sab.TabIndex = 9
        '
        'chb_vie
        '
        Me.chb_vie.Location = New System.Drawing.Point(103, 115)
        Me.chb_vie.Name = "chb_vie"
        Me.chb_vie.Size = New System.Drawing.Size(24, 24)
        Me.chb_vie.TabIndex = 8
        '
        'chb_mier
        '
        Me.chb_mier.Location = New System.Drawing.Point(170, 96)
        Me.chb_mier.Name = "chb_mier"
        Me.chb_mier.Size = New System.Drawing.Size(24, 24)
        Me.chb_mier.TabIndex = 6
        '
        'chb_mar
        '
        Me.chb_mar.Location = New System.Drawing.Point(103, 96)
        Me.chb_mar.Name = "chb_mar"
        Me.chb_mar.Size = New System.Drawing.Size(25, 24)
        Me.chb_mar.TabIndex = 5
        '
        'chb_dom
        '
        Me.chb_dom.Location = New System.Drawing.Point(46, 136)
        Me.chb_dom.Name = "chb_dom"
        Me.chb_dom.Size = New System.Drawing.Size(18, 15)
        Me.chb_dom.TabIndex = 10
        '
        'chb_jue
        '
        Me.chb_jue.Location = New System.Drawing.Point(46, 115)
        Me.chb_jue.Name = "chb_jue"
        Me.chb_jue.Size = New System.Drawing.Size(24, 20)
        Me.chb_jue.TabIndex = 7
        '
        'chb_lun
        '
        Me.chb_lun.Location = New System.Drawing.Point(46, 96)
        Me.chb_lun.Name = "chb_lun"
        Me.chb_lun.Size = New System.Drawing.Size(24, 24)
        Me.chb_lun.TabIndex = 4
        '
        'dtp_final
        '
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(127, 32)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.Size = New System.Drawing.Size(104, 20)
        Me.dtp_final.TabIndex = 1
        '
        'dtp_fechacm
        '
        Me.dtp_fechacm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechacm.Location = New System.Drawing.Point(9, 33)
        Me.dtp_fechacm.Name = "dtp_fechacm"
        Me.dtp_fechacm.Size = New System.Drawing.Size(104, 20)
        Me.dtp_fechacm.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(586, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Tipo de Cita"
        '
        'CBcitas
        '
        Me.CBcitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcitas.FormattingEnabled = True
        Me.CBcitas.Items.AddRange(New Object() {"1ra Cita", "2da Cita", "3ra Cita", "Cita Sucesiva"})
        Me.CBcitas.Location = New System.Drawing.Point(586, 23)
        Me.CBcitas.Name = "CBcitas"
        Me.CBcitas.Size = New System.Drawing.Size(121, 21)
        Me.CBcitas.TabIndex = 0
        '
        'grp_SalaDisponible
        '
        Me.grp_SalaDisponible.Controls.Add(Me.lnkSugerirHorario)
        Me.grp_SalaDisponible.Controls.Add(Me.lblDispo)
        Me.grp_SalaDisponible.Location = New System.Drawing.Point(724, 71)
        Me.grp_SalaDisponible.Name = "grp_SalaDisponible"
        Me.grp_SalaDisponible.Size = New System.Drawing.Size(191, 68)
        Me.grp_SalaDisponible.TabIndex = 99
        Me.grp_SalaDisponible.TabStop = False
        Me.grp_SalaDisponible.Visible = False
        '
        'lnkSugerirHorario
        '
        Me.lnkSugerirHorario.AutoSize = True
        Me.lnkSugerirHorario.Location = New System.Drawing.Point(6, 44)
        Me.lnkSugerirHorario.Name = "lnkSugerirHorario"
        Me.lnkSugerirHorario.Size = New System.Drawing.Size(75, 13)
        Me.lnkSugerirHorario.TabIndex = 1
        Me.lnkSugerirHorario.TabStop = True
        Me.lnkSugerirHorario.Text = "Sugerir horario"
        '
        'lblDispo
        '
        Me.lblDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispo.ForeColor = System.Drawing.Color.Red
        Me.lblDispo.Location = New System.Drawing.Point(6, 13)
        Me.lblDispo.Name = "lblDispo"
        Me.lblDispo.Size = New System.Drawing.Size(183, 31)
        Me.lblDispo.TabIndex = 0
        Me.lblDispo.Text = "Sala No disponible en este horario"
        '
        'CtrlSalasvb1
        '
        Me.CtrlSalasvb1.ID_SALA = Nothing
        Me.CtrlSalasvb1.Location = New System.Drawing.Point(436, 77)
        Me.CtrlSalasvb1.Name = "CtrlSalasvb1"
        Me.CtrlSalasvb1.Size = New System.Drawing.Size(285, 26)
        Me.CtrlSalasvb1.TabIndex = 98
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(433, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Sala / Consulta"
        '
        'btnDental
        '
        Me.btnDental.Image = CType(resources.GetObject("btnDental.Image"), System.Drawing.Image)
        Me.btnDental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDental.Location = New System.Drawing.Point(499, 22)
        Me.btnDental.Name = "btnDental"
        Me.btnDental.Size = New System.Drawing.Size(63, 24)
        Me.btnDental.TabIndex = 96
        Me.btnDental.Text = "Dental"
        Me.btnDental.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDental.UseVisualStyleBackColor = True
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.CITASBindingSource, "REFMEDICO", True))
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(17, 56)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(403, 42)
        Me.CtrlMedico1.TabIndex = 95
        '
        'cb_citaMultiple
        '
        Me.cb_citaMultiple.AutoSize = True
        Me.cb_citaMultiple.Location = New System.Drawing.Point(286, 139)
        Me.cb_citaMultiple.Name = "cb_citaMultiple"
        Me.cb_citaMultiple.Size = New System.Drawing.Size(83, 17)
        Me.cb_citaMultiple.TabIndex = 93
        Me.cb_citaMultiple.Text = "Cita Múltiple"
        Me.cb_citaMultiple.UseVisualStyleBackColor = True
        '
        'lblEdicionDesactivada
        '
        Me.lblEdicionDesactivada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEdicionDesactivada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionDesactivada.ForeColor = System.Drawing.Color.Red
        Me.lblEdicionDesactivada.Location = New System.Drawing.Point(573, 35)
        Me.lblEdicionDesactivada.Name = "lblEdicionDesactivada"
        Me.lblEdicionDesactivada.Size = New System.Drawing.Size(423, 53)
        Me.lblEdicionDesactivada.TabIndex = 2
        Me.lblEdicionDesactivada.Text = "Cita bloqueada excepto para facturación."
        Me.lblEdicionDesactivada.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1, Me.tsdb_imprimir, Me.ToolStripSeparator3, Me.tlsVerPacienteSeleccionado, Me.ToolStripSeparator1, Me.tsd_ventas, Me.ToolStripSeparator2, Me.tsb_DebitoPaciente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 93
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel1.Text = "&Guardar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "&Cancelar"
        '
        'tsdb_imprimir
        '
        Me.tsdb_imprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_imprimircita, Me.tsm_imprimirjustificante})
        Me.tsdb_imprimir.Image = CType(resources.GetObject("tsdb_imprimir.Image"), System.Drawing.Image)
        Me.tsdb_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdb_imprimir.Name = "tsdb_imprimir"
        Me.tsdb_imprimir.Size = New System.Drawing.Size(89, 22)
        Me.tsdb_imprimir.Text = "Impresión"
        '
        'tsm_imprimircita
        '
        Me.tsm_imprimircita.Name = "tsm_imprimircita"
        Me.tsm_imprimircita.Size = New System.Drawing.Size(182, 22)
        Me.tsm_imprimircita.Text = "Imprimir Cita"
        '
        'tsm_imprimirjustificante
        '
        Me.tsm_imprimirjustificante.Name = "tsm_imprimirjustificante"
        Me.tsm_imprimirjustificante.Size = New System.Drawing.Size(182, 22)
        Me.tsm_imprimirjustificante.Text = "Imprimir Justificante"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlsVerPacienteSeleccionado
        '
        Me.tlsVerPacienteSeleccionado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsVerPacienteSeleccionado.Image = CType(resources.GetObject("tlsVerPacienteSeleccionado.Image"), System.Drawing.Image)
        Me.tlsVerPacienteSeleccionado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsVerPacienteSeleccionado.Name = "tlsVerPacienteSeleccionado"
        Me.tlsVerPacienteSeleccionado.Size = New System.Drawing.Size(106, 22)
        Me.tlsVerPacienteSeleccionado.Text = "Ficha del Paciente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsd_ventas
        '
        Me.tsd_ventas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsd_ventas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HacerTicketToolStripMenuItem, Me.ListadoDeTicketsToolStripMenuItem})
        Me.tsd_ventas.Image = CType(resources.GetObject("tsd_ventas.Image"), System.Drawing.Image)
        Me.tsd_ventas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsd_ventas.Name = "tsd_ventas"
        Me.tsd_ventas.Size = New System.Drawing.Size(55, 22)
        Me.tsd_ventas.Text = "Ventas"
        '
        'HacerTicketToolStripMenuItem
        '
        Me.HacerTicketToolStripMenuItem.Enabled = False
        Me.HacerTicketToolStripMenuItem.Name = "HacerTicketToolStripMenuItem"
        Me.HacerTicketToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.HacerTicketToolStripMenuItem.Text = "Hacer Ticket"
        '
        'ListadoDeTicketsToolStripMenuItem
        '
        Me.ListadoDeTicketsToolStripMenuItem.Name = "ListadoDeTicketsToolStripMenuItem"
        Me.ListadoDeTicketsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ListadoDeTicketsToolStripMenuItem.Text = "Listado de Tickets"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsb_DebitoPaciente
        '
        Me.tsb_DebitoPaciente.Enabled = False
        Me.tsb_DebitoPaciente.Image = CType(resources.GetObject("tsb_DebitoPaciente.Image"), System.Drawing.Image)
        Me.tsb_DebitoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DebitoPaciente.Name = "tsb_DebitoPaciente"
        Me.tsb_DebitoPaciente.Size = New System.Drawing.Size(110, 22)
        Me.tsb_DebitoPaciente.Text = "Débito Paciente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.tstrip_Info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 94
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
        'dg_LineasCitas
        '
        Me.dg_LineasCitas.AllowUserToAddRows = False
        Me.dg_LineasCitas.AllowUserToDeleteRows = False
        Me.dg_LineasCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_LineasCitas.AutoGenerateColumns = False
        Me.dg_LineasCitas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_LineasCitas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_LineasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_LineasCitas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdCita, Me.colBuscar, Me.colRefConcepto, Me.colDescripcion, Me.colCantidad, Me.colImporteClinica, Me.colImporteDoctor, Me.DescuentoPercent, Me.Total, Me.Duracion, Me.ColumnDtoImp})
        Me.dg_LineasCitas.DataSource = Me.LineasCitasBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_LineasCitas.DefaultCellStyle = DataGridViewCellStyle8
        Me.dg_LineasCitas.GridColor = System.Drawing.Color.DimGray
        Me.dg_LineasCitas.Location = New System.Drawing.Point(231, 403)
        Me.dg_LineasCitas.Name = "dg_LineasCitas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_LineasCitas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dg_LineasCitas.RowHeadersVisible = False
        Me.dg_LineasCitas.Size = New System.Drawing.Size(685, 107)
        Me.dg_LineasCitas.TabIndex = 95
        '
        'LineasCitasBindingSource
        '
        Me.LineasCitasBindingSource.DataMember = "LineasCitas"
        Me.LineasCitasBindingSource.DataSource = Me.CMDataSet
        '
        'bt_AddLinea
        '
        Me.bt_AddLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AddLinea.Image = CType(resources.GetObject("bt_AddLinea.Image"), System.Drawing.Image)
        Me.bt_AddLinea.Location = New System.Drawing.Point(922, 375)
        Me.bt_AddLinea.Name = "bt_AddLinea"
        Me.bt_AddLinea.Size = New System.Drawing.Size(34, 32)
        Me.bt_AddLinea.TabIndex = 96
        Me.bt_AddLinea.UseVisualStyleBackColor = True
        '
        'bt_DelLinea
        '
        Me.bt_DelLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_DelLinea.Image = CType(resources.GetObject("bt_DelLinea.Image"), System.Drawing.Image)
        Me.bt_DelLinea.Location = New System.Drawing.Point(922, 411)
        Me.bt_DelLinea.Name = "bt_DelLinea"
        Me.bt_DelLinea.Size = New System.Drawing.Size(34, 31)
        Me.bt_DelLinea.TabIndex = 97
        Me.bt_DelLinea.UseVisualStyleBackColor = True
        '
        'btn_HistorialProcesos
        '
        Me.btn_HistorialProcesos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_HistorialProcesos.Image = CType(resources.GetObject("btn_HistorialProcesos.Image"), System.Drawing.Image)
        Me.btn_HistorialProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistorialProcesos.Location = New System.Drawing.Point(6, 69)
        Me.btn_HistorialProcesos.Name = "btn_HistorialProcesos"
        Me.btn_HistorialProcesos.Size = New System.Drawing.Size(90, 43)
        Me.btn_HistorialProcesos.TabIndex = 98
        Me.btn_HistorialProcesos.Text = "Historial de Procesos"
        Me.btn_HistorialProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HistorialProcesos.UseVisualStyleBackColor = True
        '
        'group_Proceso
        '
        Me.group_Proceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_Proceso.Controls.Add(Me.btnVerProceso)
        Me.group_Proceso.Controls.Add(Me.lblCitaProcesoInfo)
        Me.group_Proceso.Controls.Add(Me.btn_HistorialProcesos)
        Me.group_Proceso.Location = New System.Drawing.Point(805, 245)
        Me.group_Proceso.Name = "group_Proceso"
        Me.group_Proceso.Size = New System.Drawing.Size(195, 123)
        Me.group_Proceso.TabIndex = 99
        Me.group_Proceso.TabStop = False
        Me.group_Proceso.Text = "Procesos"
        '
        'btnVerProceso
        '
        Me.btnVerProceso.Enabled = False
        Me.btnVerProceso.Image = CType(resources.GetObject("btnVerProceso.Image"), System.Drawing.Image)
        Me.btnVerProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerProceso.Location = New System.Drawing.Point(105, 69)
        Me.btnVerProceso.Name = "btnVerProceso"
        Me.btnVerProceso.Size = New System.Drawing.Size(84, 44)
        Me.btnVerProceso.TabIndex = 100
        Me.btnVerProceso.Text = "Ver Proceso"
        Me.btnVerProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerProceso.UseVisualStyleBackColor = True
        '
        'lblCitaProcesoInfo
        '
        Me.lblCitaProcesoInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitaProcesoInfo.Location = New System.Drawing.Point(35, 22)
        Me.lblCitaProcesoInfo.Name = "lblCitaProcesoInfo"
        Me.lblCitaProcesoInfo.Size = New System.Drawing.Size(155, 40)
        Me.lblCitaProcesoInfo.TabIndex = 99
        Me.lblCitaProcesoInfo.Text = "Esta cita no se encuentra vinculada a ningun proceso"
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASBindingSource
        '
        Me.LMUTUASBindingSource.DataMember = "LMUTUAS"
        Me.LMUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASTableAdapter
        '
        Me.LMUTUASTableAdapter.ClearBeforeFill = True
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
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
        'LINEASFACTURASTableAdapter
        '
        Me.LINEASFACTURASTableAdapter.ClearBeforeFill = True
        '
        'LINEASFACTURASBindingSource
        '
        Me.LINEASFACTURASBindingSource.DataMember = "LINEASFACTURAS"
        Me.LINEASFACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'LineasCitasTableAdapter
        '
        Me.LineasCitasTableAdapter.ClearBeforeFill = True
        '
        'ConceptosFacturablesBindingSource
        '
        Me.ConceptosFacturablesBindingSource.DataMember = "CONCEPTOSFRA"
        Me.ConceptosFacturablesBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFRATableAdapter
        '
        Me.CONCEPTOSFRATableAdapter.ClearBeforeFill = True
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
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re una columna aquí para reagrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEX1.DataSource = Me.HISTORIALEBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1, GridEX1_DesignTimeLayout_Reference_2})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GridLines = Janus.Windows.GridEX.GridLines.RowOutline
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(5, 254)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEX1.Size = New System.Drawing.Size(213, 302)
        Me.GridEX1.TabIndex = 222
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'HISTORIALEBindingSource
        '
        Me.HISTORIALEBindingSource.DataSource = GetType(centro_medico.HISTORIALE)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 223
        Me.Label16.Text = "HISTORIALES"
        '
        'btnAddLineasGenericas
        '
        Me.btnAddLineasGenericas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLineasGenericas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddLineasGenericas.Image = CType(resources.GetObject("btnAddLineasGenericas.Image"), System.Drawing.Image)
        Me.btnAddLineasGenericas.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAddLineasGenericas.Location = New System.Drawing.Point(922, 448)
        Me.btnAddLineasGenericas.Name = "btnAddLineasGenericas"
        Me.btnAddLineasGenericas.Size = New System.Drawing.Size(34, 31)
        Me.btnAddLineasGenericas.TabIndex = 96
        Me.btnAddLineasGenericas.UseVisualStyleBackColor = True
        '
        'lblCitaEliminada
        '
        Me.lblCitaEliminada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCitaEliminada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitaEliminada.ForeColor = System.Drawing.Color.Red
        Me.lblCitaEliminada.Location = New System.Drawing.Point(574, 65)
        Me.lblCitaEliminada.Name = "lblCitaEliminada"
        Me.lblCitaEliminada.Size = New System.Drawing.Size(411, 38)
        Me.lblCitaEliminada.TabIndex = 224
        Me.lblCitaEliminada.Text = "CITA ELIMINADA, EDICION DESACTIVADA"
        Me.lblCitaEliminada.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ContadorBono1
        '
        Me.ContadorBono1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContadorBono1.BackColor = System.Drawing.Color.Gainsboro
        Me.ContadorBono1.Location = New System.Drawing.Point(757, 516)
        Me.ContadorBono1.Name = "ContadorBono1"
        Me.ContadorBono1.Size = New System.Drawing.Size(247, 78)
        Me.ContadorBono1.TabIndex = 100
        Me.ContadorBono1.Visible = False
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.CITASBindingSource, "REFPACIENTE", True))
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(23, 31)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(476, 52)
        Me.CtrlPaciente1.TabIndex = 94
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.CITASBindingSource, "REFPACIENTE", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(612, 0)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(393, 28)
        Me.CtrlStatusPaciente1.TabIndex = 100
        '
        'tb_notas
        '
        Me.tb_notas.AcceptsReturn = True
        Me.tb_notas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_notas.BackColor = System.Drawing.Color.LemonChiffon
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CITASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(239, 516)
        Me.tb_notas.MaxLength = 2147483647
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_notas.Size = New System.Drawing.Size(512, 76)
        Me.tb_notas.TabIndex = 1
        '
        'colIdCita
        '
        Me.colIdCita.DataPropertyName = "IdCita"
        Me.colIdCita.HeaderText = "IdCita"
        Me.colIdCita.Name = "colIdCita"
        Me.colIdCita.Visible = False
        '
        'colBuscar
        '
        Me.colBuscar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colBuscar.HeaderText = "..."
        Me.colBuscar.Image = CType(resources.GetObject("colBuscar.Image"), System.Drawing.Image)
        Me.colBuscar.Name = "colBuscar"
        Me.colBuscar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBuscar.Width = 22
        '
        'colRefConcepto
        '
        Me.colRefConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colRefConcepto.DataPropertyName = "RefConcepto"
        Me.colRefConcepto.HeaderText = "Cod"
        Me.colRefConcepto.MinimumWidth = 61
        Me.colRefConcepto.Name = "colRefConcepto"
        Me.colRefConcepto.Width = 61
        '
        'colDescripcion
        '
        Me.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcion.DataPropertyName = "DESCRIPCION"
        Me.colDescripcion.HeaderText = "DESCRIPCION"
        Me.colDescripcion.Name = "colDescripcion"
        '
        'colCantidad
        '
        Me.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colCantidad.DataPropertyName = "Cantidad"
        Me.colCantidad.HeaderText = "Uds"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Width = 51
        '
        'colImporteClinica
        '
        Me.colImporteClinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colImporteClinica.DataPropertyName = "ImporteClinica"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colImporteClinica.DefaultCellStyle = DataGridViewCellStyle2
        Me.colImporteClinica.HeaderText = "Clínica"
        Me.colImporteClinica.Name = "colImporteClinica"
        Me.colImporteClinica.Width = 65
        '
        'colImporteDoctor
        '
        Me.colImporteDoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colImporteDoctor.DataPropertyName = "ImporteDr"
        DataGridViewCellStyle3.Format = "C2"
        Me.colImporteDoctor.DefaultCellStyle = DataGridViewCellStyle3
        Me.colImporteDoctor.HeaderText = "Doctor"
        Me.colImporteDoctor.Name = "colImporteDoctor"
        Me.colImporteDoctor.Width = 64
        '
        'DescuentoPercent
        '
        Me.DescuentoPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DescuentoPercent.DataPropertyName = "DescuentoPercent"
        DataGridViewCellStyle4.Format = "N2"
        Me.DescuentoPercent.DefaultCellStyle = DataGridViewCellStyle4
        Me.DescuentoPercent.HeaderText = "Dto %"
        Me.DescuentoPercent.Name = "DescuentoPercent"
        Me.DescuentoPercent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DescuentoPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DescuentoPercent.Width = 41
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle5.Format = "C2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 70
        '
        'Duracion
        '
        Me.Duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Duracion.DataPropertyName = "Duracion"
        DataGridViewCellStyle6.Format = "HH:mm"
        DataGridViewCellStyle6.NullValue = "00:00"
        Me.Duracion.DefaultCellStyle = DataGridViewCellStyle6
        Me.Duracion.HeaderText = "Duración"
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Width = 75
        '
        'ColumnDtoImp
        '
        Me.ColumnDtoImp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle7.Format = "C2"
        Me.ColumnDtoImp.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColumnDtoImp.HeaderText = "Dto Imp"
        Me.ColumnDtoImp.Name = "ColumnDtoImp"
        Me.ColumnDtoImp.Width = 69
        '
        'form_citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1008, 621)
        Me.Controls.Add(Me.ContadorBono1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.bntAsistenteFacturacion)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(Me.bt_DelLinea)
        Me.Controls.Add(Me.btnAddLineasGenericas)
        Me.Controls.Add(Me.bt_AddLinea)
        Me.Controls.Add(Me.dg_LineasCitas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_AddHistoria)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpImporte)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.group_Proceso)
        Me.Controls.Add(Me.lblEdicionDesactivada)
        Me.Controls.Add(Me.lblCitaEliminada)
        Me.Name = "form_citas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_citas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImporte.ResumeLayout(False)
        Me.grpImporte.PerformLayout()
        Me.pnl_Facturar.ResumeLayout(False)
        CType(Me.pb_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_citas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFechaHora.ResumeLayout(False)
        Me.grpFechaHora.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_citaMultiple.ResumeLayout(False)
        Me.gb_citaMultiple.PerformLayout()
        Me.grp_SalaDisponible.ResumeLayout(False)
        Me.grp_SalaDisponible.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dg_LineasCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Proceso.ResumeLayout(False)
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConceptosFacturablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_dr As ctrlTextboxAvanzado
    Friend WithEvents tb_clinica As ctrlTextboxAvanzado
    Friend WithEvents tb_idforma As ctrlTextboxAvanzado
    Friend WithEvents dtp_fechacobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents chb_confirmada As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_pagada As System.Windows.Forms.CheckBox
    Friend WithEvents chb_falta As System.Windows.Forms.CheckBox
    Friend WithEvents chb_atendido As System.Windows.Forms.CheckBox
    Friend WithEvents grpImporte As System.Windows.Forms.GroupBox
    Friend WithEvents grpFechaHora As System.Windows.Forms.GroupBox
    Friend WithEvents chb_recibo As System.Windows.Forms.CheckBox
    Friend WithEvents bt_forma As System.Windows.Forms.Button
    Friend WithEvents bt_factura As System.Windows.Forms.Button
    Friend WithEvents lb_forma As System.Windows.Forms.Label
    Friend WithEvents lb_recibo As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_aseguradora As System.Windows.Forms.ComboBox
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lb_ftexto As System.Windows.Forms.Label
    Friend WithEvents lb_factura As System.Windows.Forms.Label
    Friend WithEvents pb_citas As System.Windows.Forms.PictureBox
    Friend WithEvents pb_facturas As System.Windows.Forms.PictureBox
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents LINEASFACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter
    Friend WithEvents LINEASFACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents bt_actualiza_cbMutuas As System.Windows.Forms.Button
    Friend WithEvents lb_aviso As System.Windows.Forms.Label
    Friend WithEvents tb_horainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_AddHistoria As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstrip_Info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dg_LineasCitas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_AddLinea As System.Windows.Forms.Button
    Friend WithEvents bt_DelLinea As System.Windows.Forms.Button
    Friend WithEvents LineasCitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineasCitasTableAdapter As centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
    Friend WithEvents ConceptosFacturablesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
    Friend WithEvents cb_citaMultiple As System.Windows.Forms.CheckBox
    Friend WithEvents gb_citaMultiple As System.Windows.Forms.GroupBox
    Friend WithEvents chb_sab As System.Windows.Forms.CheckBox
    Friend WithEvents chb_vie As System.Windows.Forms.CheckBox
    Friend WithEvents chb_mier As System.Windows.Forms.CheckBox
    Friend WithEvents chb_mar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_dom As System.Windows.Forms.CheckBox
    Friend WithEvents chb_jue As System.Windows.Forms.CheckBox
    Friend WithEvents chb_lun As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechacm As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horafincm As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horainiciocm As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_DebitoPaciente As System.Windows.Forms.ToolStripButton
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents btn_DesasociarFactura As System.Windows.Forms.Button
    Friend WithEvents btn_HistorialProcesos As System.Windows.Forms.Button
    Friend WithEvents group_Proceso As System.Windows.Forms.GroupBox
    Friend WithEvents lblCitaProcesoInfo As System.Windows.Forms.Label
    Friend WithEvents btnVerProceso As System.Windows.Forms.Button
    Public WithEvents chb_aseguradora As System.Windows.Forms.CheckBox
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents txtDuracion As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnDental As System.Windows.Forms.Button
    Friend WithEvents txtDescuentoTotal As ctrlTextboxAvanzado
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CtrlSalasvb1 As centro_medico.ctrlSalasvb
    Friend WithEvents grp_SalaDisponible As System.Windows.Forms.GroupBox
    Friend WithEvents lnkSugerirHorario As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDispo As System.Windows.Forms.Label
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents bntAsistenteFacturacion As System.Windows.Forms.Button
    Friend WithEvents pnl_Facturar As System.Windows.Forms.Panel
    Friend WithEvents lblEdicionDesactivada As System.Windows.Forms.Label
    Friend WithEvents pb_UndoCobrar As System.Windows.Forms.PictureBox
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents HISTORIALEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAddLineasGenericas As System.Windows.Forms.Button
    Friend WithEvents lblCitaEliminada As System.Windows.Forms.Label
    Friend WithEvents tlsVerPacienteSeleccionado As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblHorarioEspecial As System.Windows.Forms.Label
    Friend WithEvents tsdb_imprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsm_imprimircita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_imprimirjustificante As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsd_ventas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents HacerTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeTicketsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContadorBono1 As centro_medico.contadorBono
    Friend WithEvents CBcitas As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bt_ActualizaNumeracion As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents colIdCita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBuscar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colRefConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporteClinica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporteDoctor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDtoImp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
