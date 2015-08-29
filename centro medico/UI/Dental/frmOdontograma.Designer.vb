<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOdontograma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOdontograma))
        Dim Grid3_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmNTratamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmAPendiente = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmARealizado = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmVerCita = New System.Windows.Forms.ToolStripMenuItem()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CBx_Doct = New System.Windows.Forms.ComboBox()
        Me.oMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mitHistorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitFicherosAsociados = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvw1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pbx_urg1 = New System.Windows.Forms.PictureBox()
        Me.chbUrgente2 = New System.Windows.Forms.CheckBox()
        Me.lvw2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TsPresupuestos = New System.Windows.Forms.ToolStrip()
        Me.btnPNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnPMPendiente = New System.Windows.Forms.ToolStripButton()
        Me.btnPMRealizado = New System.Windows.Forms.ToolStripButton()
        Me.btnPEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnPReporte = New System.Windows.Forms.ToolStripButton()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tvwPresupuestos = New System.Windows.Forms.TreeView()
        Me.pMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mitNuevoPres = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitMoverTodoPendiente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitMoverTodoRealizado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEliminarPres = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mitVerReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.chbUrgente3 = New System.Windows.Forms.CheckBox()
        Me.pbx_urg2 = New System.Windows.Forms.PictureBox()
        Me.lvw4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgListtbC = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnDefinitiva = New System.Windows.Forms.RadioButton()
        Me.rbnTemporal = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.chbHabilitar = New System.Windows.Forms.CheckBox()
        Me.TsMenu = New System.Windows.Forms.ToolStrip()
        Me.tstOperaciones = New System.Windows.Forms.ToolStripButton()
        Me.tstColores = New System.Windows.Forms.ToolStripButton()
        Me.tstReportes = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tstRptOdontograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstRptPresupuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslCasosUrgentes = New System.Windows.Forms.ToolStripLabel()
        Me.lblTratInfo = New System.Windows.Forms.Label()
        Me.chbVerPendientes = New System.Windows.Forms.CheckBox()
        Me.chbVerPresupuesto = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPieza = New System.Windows.Forms.Label()
        Me.tbcTrat = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LVw_TTrat = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LVw_Oper = New System.Windows.Forms.ListView()
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.LVw_Trat = New System.Windows.Forms.ListView()
        Me.columnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTratamiento = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbxFamilia = New System.Windows.Forms.PictureBox()
        Me.tbc = New Janus.Windows.UI.Tab.UITab()
        Me.Odontograma1 = New Odontograma()
        Me.Odontograma2 = New Odontograma()
        Me.Odontograma3 = New Odontograma()
        Me.Grid3 = New Janus.Windows.GridEX.GridEX()
        Me.OdontTratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OdontTrat = New centro_medico.OdontTrat()
        Me.Odontograma4 = New Odontograma()
        Me.LineasPresupuestoTableAdapter = New centro_medico.OdontTratTableAdapters.LineasPresupuestoTableAdapter()
        Me.CtrlAlarmaPaciente1 = New centro_medico.ctrlAlarmaPaciente()
        Me.tbpRealizado = New Janus.Windows.UI.Tab.UITabPage()
        Me.tbpPendiente = New Janus.Windows.UI.Tab.UITabPage()
        Me.tbpPresupuestos = New Janus.Windows.UI.Tab.UITabPage()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.tbpPrimeraVisita = New Janus.Windows.UI.Tab.UITabPage()
        Me.tbxTrat = New centro_medico.ctrlTextboxAvanzado()
        Me.rtb3 = New centro_medico.ctrlRichTextboxAvanzado()
        Me.rtb2 = New centro_medico.ctrlRichTextboxAvanzado()
        Me.rtb1 = New centro_medico.ctrlRichTextboxAvanzado()
        Me.rtb4 = New centro_medico.ctrlRichTextboxAvanzado()
        Me.cMenu.SuspendLayout()
        Me.oMenu.SuspendLayout()
        CType(Me.pbx_urg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsPresupuestos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pMenu.SuspendLayout()
        CType(Me.pbx_urg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TsMenu.SuspendLayout()
        Me.tbcTrat.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbxFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdontTratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdontTrat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpRealizado.SuspendLayout()
        Me.tbpPendiente.SuspendLayout()
        Me.tbpPresupuestos.SuspendLayout()
        Me.tbpPrimeraVisita.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.White
        Me.imgList.Images.SetKeyName(0, "folder.bmp")
        Me.imgList.Images.SetKeyName(1, "file.bmp")
        Me.imgList.Images.SetKeyName(2, "presupuesto.ico")
        Me.imgList.Images.SetKeyName(3, "diente.ico")
        Me.imgList.Images.SetKeyName(4, "urgente.ico")
        Me.imgList.Images.SetKeyName(5, "confirmado.ico")
        Me.imgList.Images.SetKeyName(6, "confirmado_urgente.ico")
        Me.imgList.Images.SetKeyName(7, "realizado.ico")
        '
        'cMenu
        '
        Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmNTratamiento, Me.cmEliminar, Me.cmAPendiente, Me.cmARealizado, Me.cmVerCita})
        Me.cMenu.Name = "cMenu"
        Me.cMenu.Size = New System.Drawing.Size(297, 114)
        '
        'cmNTratamiento
        '
        Me.cmNTratamiento.Image = CType(resources.GetObject("cmNTratamiento.Image"), System.Drawing.Image)
        Me.cmNTratamiento.Name = "cmNTratamiento"
        Me.cmNTratamiento.Size = New System.Drawing.Size(296, 22)
        Me.cmNTratamiento.Text = "&Nuevo tratamiento"
        '
        'cmEliminar
        '
        Me.cmEliminar.Image = CType(resources.GetObject("cmEliminar.Image"), System.Drawing.Image)
        Me.cmEliminar.Name = "cmEliminar"
        Me.cmEliminar.Size = New System.Drawing.Size(296, 22)
        Me.cmEliminar.Text = "&Eliminar"
        '
        'cmAPendiente
        '
        Me.cmAPendiente.Image = CType(resources.GetObject("cmAPendiente.Image"), System.Drawing.Image)
        Me.cmAPendiente.Name = "cmAPendiente"
        Me.cmAPendiente.Size = New System.Drawing.Size(296, 22)
        Me.cmAPendiente.Text = "Mover a trabajos &pendientes (confirmado)"
        '
        'cmARealizado
        '
        Me.cmARealizado.Image = CType(resources.GetObject("cmARealizado.Image"), System.Drawing.Image)
        Me.cmARealizado.Name = "cmARealizado"
        Me.cmARealizado.Size = New System.Drawing.Size(296, 22)
        Me.cmARealizado.Text = "Mover a &Realizado"
        '
        'cmVerCita
        '
        Me.cmVerCita.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmVerCita.Image = Global.centro_medico.My.Resources.Resources.Citas
        Me.cmVerCita.Name = "cmVerCita"
        Me.cmVerCita.Size = New System.Drawing.Size(296, 22)
        Me.cmVerCita.Text = "Ver cita"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(518, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Doctor"
        '
        'CBx_Doct
        '
        Me.CBx_Doct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBx_Doct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBx_Doct.FormattingEnabled = True
        Me.CBx_Doct.Location = New System.Drawing.Point(563, 30)
        Me.CBx_Doct.Name = "CBx_Doct"
        Me.CBx_Doct.Size = New System.Drawing.Size(230, 21)
        Me.CBx_Doct.TabIndex = 6
        '
        'oMenu
        '
        Me.oMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitHistorial, Me.mitFicherosAsociados, Me.ToolStripMenuItem2})
        Me.oMenu.Name = "oMenu"
        Me.oMenu.Size = New System.Drawing.Size(264, 70)
        '
        'mitHistorial
        '
        Me.mitHistorial.Image = CType(resources.GetObject("mitHistorial.Image"), System.Drawing.Image)
        Me.mitHistorial.Name = "mitHistorial"
        Me.mitHistorial.Size = New System.Drawing.Size(263, 22)
        Me.mitHistorial.Text = "&Historial de la pieza"
        '
        'mitFicherosAsociados
        '
        Me.mitFicherosAsociados.Image = CType(resources.GetObject("mitFicherosAsociados.Image"), System.Drawing.Image)
        Me.mitFicherosAsociados.Name = "mitFicherosAsociados"
        Me.mitFicherosAsociados.Size = New System.Drawing.Size(263, 22)
        Me.mitFicherosAsociados.Text = "Ficheros asociados"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(263, 22)
        Me.ToolStripMenuItem2.Text = "Ficheros asociados al Odontograma"
        '
        'lvw1
        '
        Me.lvw1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5})
        Me.lvw1.ContextMenuStrip = Me.cMenu
        Me.lvw1.FullRowSelect = True
        Me.lvw1.HideSelection = False
        Me.lvw1.Location = New System.Drawing.Point(3, 353)
        Me.lvw1.Name = "lvw1"
        Me.lvw1.Size = New System.Drawing.Size(500, 293)
        Me.lvw1.SmallImageList = Me.imgList
        Me.lvw1.TabIndex = 13
        Me.lvw1.Tag = "1"
        Me.lvw1.UseCompatibleStateImageBehavior = False
        Me.lvw1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Fecha"
        Me.columnHeader1.Width = 90
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Tratamiento"
        Me.columnHeader2.Width = 175
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Pieza"
        Me.columnHeader3.Width = 72
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Cuadrantes"
        Me.columnHeader4.Width = 69
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Doctor"
        Me.columnHeader5.Width = 65
        '
        'pbx_urg1
        '
        Me.pbx_urg1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_urg1.InitialImage = Nothing
        Me.pbx_urg1.Location = New System.Drawing.Point(423, 632)
        Me.pbx_urg1.Name = "pbx_urg1"
        Me.pbx_urg1.Size = New System.Drawing.Size(12, 12)
        Me.pbx_urg1.TabIndex = 66
        Me.pbx_urg1.TabStop = False
        '
        'chbUrgente2
        '
        Me.chbUrgente2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbUrgente2.AutoSize = True
        Me.chbUrgente2.BackColor = System.Drawing.Color.Transparent
        Me.chbUrgente2.Location = New System.Drawing.Point(440, 630)
        Me.chbUrgente2.Name = "chbUrgente2"
        Me.chbUrgente2.Size = New System.Drawing.Size(64, 17)
        Me.chbUrgente2.TabIndex = 22
        Me.chbUrgente2.Text = "Urgente"
        Me.chbUrgente2.UseVisualStyleBackColor = False
        '
        'lvw2
        '
        Me.lvw2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvw2.ContextMenuStrip = Me.cMenu
        Me.lvw2.FullRowSelect = True
        Me.lvw2.HideSelection = False
        Me.lvw2.Location = New System.Drawing.Point(3, 353)
        Me.lvw2.Name = "lvw2"
        Me.lvw2.Size = New System.Drawing.Size(500, 276)
        Me.lvw2.SmallImageList = Me.imgList
        Me.lvw2.TabIndex = 18
        Me.lvw2.Tag = "2"
        Me.lvw2.UseCompatibleStateImageBehavior = False
        Me.lvw2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Fecha"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tratamiento"
        Me.ColumnHeader8.Width = 243
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Pieza"
        Me.ColumnHeader9.Width = 72
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Cuadrantes"
        Me.ColumnHeader10.Width = 69
        '
        'TsPresupuestos
        '
        Me.TsPresupuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TsPresupuestos.AutoSize = False
        Me.TsPresupuestos.Dock = System.Windows.Forms.DockStyle.None
        Me.TsPresupuestos.GripMargin = New System.Windows.Forms.Padding(0)
        Me.TsPresupuestos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsPresupuestos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPNuevo, Me.btnPMPendiente, Me.btnPMRealizado, Me.btnPEliminar, Me.ToolStripButton5, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1, Me.btnPReporte})
        Me.TsPresupuestos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.TsPresupuestos.Location = New System.Drawing.Point(3, 627)
        Me.TsPresupuestos.Name = "TsPresupuestos"
        Me.TsPresupuestos.Padding = New System.Windows.Forms.Padding(0)
        Me.TsPresupuestos.Size = New System.Drawing.Size(116, 20)
        Me.TsPresupuestos.TabIndex = 73
        Me.TsPresupuestos.Visible = False
        '
        'btnPNuevo
        '
        Me.btnPNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPNuevo.Image = CType(resources.GetObject("btnPNuevo.Image"), System.Drawing.Image)
        Me.btnPNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPNuevo.Name = "btnPNuevo"
        Me.btnPNuevo.Size = New System.Drawing.Size(23, 20)
        Me.btnPNuevo.ToolTipText = "Nuevo Presupuesto"
        '
        'btnPMPendiente
        '
        Me.btnPMPendiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPMPendiente.Enabled = False
        Me.btnPMPendiente.Image = CType(resources.GetObject("btnPMPendiente.Image"), System.Drawing.Image)
        Me.btnPMPendiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPMPendiente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPMPendiente.Name = "btnPMPendiente"
        Me.btnPMPendiente.Size = New System.Drawing.Size(23, 20)
        Me.btnPMPendiente.ToolTipText = "Mover todas las líneas a Pendiente"
        '
        'btnPMRealizado
        '
        Me.btnPMRealizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPMRealizado.Enabled = False
        Me.btnPMRealizado.Image = CType(resources.GetObject("btnPMRealizado.Image"), System.Drawing.Image)
        Me.btnPMRealizado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPMRealizado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPMRealizado.Name = "btnPMRealizado"
        Me.btnPMRealizado.Size = New System.Drawing.Size(23, 20)
        Me.btnPMRealizado.ToolTipText = "Mover todas las líneas a Realizado"
        '
        'btnPEliminar
        '
        Me.btnPEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPEliminar.Enabled = False
        Me.btnPEliminar.Image = CType(resources.GetObject("btnPEliminar.Image"), System.Drawing.Image)
        Me.btnPEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPEliminar.Name = "btnPEliminar"
        Me.btnPEliminar.Size = New System.Drawing.Size(23, 20)
        Me.btnPEliminar.ToolTipText = "Eliminar Presupuesto"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Enabled = False
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton5.ToolTipText = "Ver Reporte"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Enabled = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton4.ToolTipText = "Eliminar Presupuesto"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton3.ToolTipText = "Mover todas las líneas a Realizado"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton2.ToolTipText = "Mover todas las líneas a Pendiente"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton1.ToolTipText = "Nuevo Presupuesto"
        '
        'btnPReporte
        '
        Me.btnPReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPReporte.Enabled = False
        Me.btnPReporte.Image = CType(resources.GetObject("btnPReporte.Image"), System.Drawing.Image)
        Me.btnPReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPReporte.Name = "btnPReporte"
        Me.btnPReporte.Size = New System.Drawing.Size(23, 20)
        Me.btnPReporte.ToolTipText = "Ver Reporte"
        '
        'lblImporte
        '
        Me.lblImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.Location = New System.Drawing.Point(126, 630)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(82, 13)
        Me.lblImporte.TabIndex = 66
        Me.lblImporte.Text = "Importe total:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(4, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(103, 19)
        Me.Panel1.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Presupuestos"
        '
        'tvwPresupuestos
        '
        Me.tvwPresupuestos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvwPresupuestos.ContextMenuStrip = Me.pMenu
        Me.tvwPresupuestos.HideSelection = False
        Me.tvwPresupuestos.ImageIndex = 2
        Me.tvwPresupuestos.ImageList = Me.imgList
        Me.tvwPresupuestos.Indent = 19
        Me.tvwPresupuestos.Location = New System.Drawing.Point(4, 372)
        Me.tvwPresupuestos.Name = "tvwPresupuestos"
        Me.tvwPresupuestos.SelectedImageIndex = 2
        Me.tvwPresupuestos.ShowPlusMinus = False
        Me.tvwPresupuestos.ShowRootLines = False
        Me.tvwPresupuestos.Size = New System.Drawing.Size(102, 253)
        Me.tvwPresupuestos.TabIndex = 22
        '
        'pMenu
        '
        Me.pMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitNuevoPres, Me.mitMoverTodoPendiente, Me.mitMoverTodoRealizado, Me.mitEliminarPres, Me.ToolStripMenuItem1, Me.mitVerReporte})
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(227, 120)
        '
        'mitNuevoPres
        '
        Me.mitNuevoPres.Image = CType(resources.GetObject("mitNuevoPres.Image"), System.Drawing.Image)
        Me.mitNuevoPres.Name = "mitNuevoPres"
        Me.mitNuevoPres.Size = New System.Drawing.Size(226, 22)
        Me.mitNuevoPres.Text = "&Nuevo presupuesto"
        '
        'mitMoverTodoPendiente
        '
        Me.mitMoverTodoPendiente.Image = CType(resources.GetObject("mitMoverTodoPendiente.Image"), System.Drawing.Image)
        Me.mitMoverTodoPendiente.Name = "mitMoverTodoPendiente"
        Me.mitMoverTodoPendiente.Size = New System.Drawing.Size(226, 22)
        Me.mitMoverTodoPendiente.Text = "Mover a &Trabajos pendientes"
        '
        'mitMoverTodoRealizado
        '
        Me.mitMoverTodoRealizado.Image = CType(resources.GetObject("mitMoverTodoRealizado.Image"), System.Drawing.Image)
        Me.mitMoverTodoRealizado.Name = "mitMoverTodoRealizado"
        Me.mitMoverTodoRealizado.Size = New System.Drawing.Size(226, 22)
        Me.mitMoverTodoRealizado.Text = "Mover a &Relizado"
        '
        'mitEliminarPres
        '
        Me.mitEliminarPres.Image = CType(resources.GetObject("mitEliminarPres.Image"), System.Drawing.Image)
        Me.mitEliminarPres.Name = "mitEliminarPres"
        Me.mitEliminarPres.Size = New System.Drawing.Size(226, 22)
        Me.mitEliminarPres.Text = "&Eliminar presupuesto"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(223, 6)
        '
        'mitVerReporte
        '
        Me.mitVerReporte.Image = CType(resources.GetObject("mitVerReporte.Image"), System.Drawing.Image)
        Me.mitVerReporte.Name = "mitVerReporte"
        Me.mitVerReporte.Size = New System.Drawing.Size(226, 22)
        Me.mitVerReporte.Text = "&Ver reporte"
        '
        'chbUrgente3
        '
        Me.chbUrgente3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbUrgente3.AutoSize = True
        Me.chbUrgente3.Location = New System.Drawing.Point(440, 630)
        Me.chbUrgente3.Name = "chbUrgente3"
        Me.chbUrgente3.Size = New System.Drawing.Size(64, 17)
        Me.chbUrgente3.TabIndex = 21
        Me.chbUrgente3.Text = "Urgente"
        Me.chbUrgente3.UseVisualStyleBackColor = True
        '
        'pbx_urg2
        '
        Me.pbx_urg2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_urg2.InitialImage = Nothing
        Me.pbx_urg2.Location = New System.Drawing.Point(423, 632)
        Me.pbx_urg2.Name = "pbx_urg2"
        Me.pbx_urg2.Size = New System.Drawing.Size(12, 12)
        Me.pbx_urg2.TabIndex = 65
        Me.pbx_urg2.TabStop = False
        '
        'lvw4
        '
        Me.lvw4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22})
        Me.lvw4.ContextMenuStrip = Me.cMenu
        Me.lvw4.FullRowSelect = True
        Me.lvw4.HideSelection = False
        Me.lvw4.Location = New System.Drawing.Point(3, 353)
        Me.lvw4.Name = "lvw4"
        Me.lvw4.Size = New System.Drawing.Size(499, 293)
        Me.lvw4.SmallImageList = Me.imgList
        Me.lvw4.TabIndex = 18
        Me.lvw4.TabStop = False
        Me.lvw4.Tag = "4"
        Me.lvw4.UseCompatibleStateImageBehavior = False
        Me.lvw4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Fecha"
        Me.ColumnHeader18.Width = 90
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Tratamiento"
        Me.ColumnHeader19.Width = 175
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Pieza"
        Me.ColumnHeader20.Width = 72
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Cuadrantes"
        Me.ColumnHeader21.Width = 69
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Doctor"
        Me.ColumnHeader22.Width = 66
        '
        'imgListtbC
        '
        Me.imgListtbC.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgListtbC.ImageSize = New System.Drawing.Size(12, 12)
        Me.imgListtbC.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbnDefinitiva)
        Me.GroupBox1.Controls.Add(Me.rbnTemporal)
        Me.GroupBox1.Location = New System.Drawing.Point(526, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 43)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Tipo de dentición "
        '
        'rbnDefinitiva
        '
        Me.rbnDefinitiva.AutoSize = True
        Me.rbnDefinitiva.Checked = True
        Me.rbnDefinitiva.Location = New System.Drawing.Point(16, 19)
        Me.rbnDefinitiva.Name = "rbnDefinitiva"
        Me.rbnDefinitiva.Size = New System.Drawing.Size(69, 17)
        Me.rbnDefinitiva.TabIndex = 1
        Me.rbnDefinitiva.TabStop = True
        Me.rbnDefinitiva.Text = "Definitiva"
        Me.rbnDefinitiva.UseVisualStyleBackColor = True
        '
        'rbnTemporal
        '
        Me.rbnTemporal.AutoSize = True
        Me.rbnTemporal.Location = New System.Drawing.Point(108, 19)
        Me.rbnTemporal.Name = "rbnTemporal"
        Me.rbnTemporal.Size = New System.Drawing.Size(69, 17)
        Me.rbnTemporal.TabIndex = 0
        Me.rbnTemporal.Text = "Temporal"
        Me.rbnTemporal.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(564, 54)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(152, 20)
        Me.dtpFecha.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Fecha"
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(523, 573)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(162, 18)
        Me.lblInfo.TabIndex = 48
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbHabilitar
        '
        Me.chbHabilitar.AutoSize = True
        Me.chbHabilitar.BackColor = System.Drawing.Color.Transparent
        Me.chbHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbHabilitar.Location = New System.Drawing.Point(262, 6)
        Me.chbHabilitar.Name = "chbHabilitar"
        Me.chbHabilitar.Size = New System.Drawing.Size(12, 11)
        Me.chbHabilitar.TabIndex = 49
        Me.chbHabilitar.UseVisualStyleBackColor = True
        '
        'TsMenu
        '
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstOperaciones, Me.tstColores, Me.tstReportes, Me.ToolStripSeparator1, Me.tslCasosUrgentes})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Size = New System.Drawing.Size(814, 25)
        Me.TsMenu.TabIndex = 50
        Me.TsMenu.Text = "ToolStrip1"
        '
        'tstOperaciones
        '
        Me.tstOperaciones.Image = Global.centro_medico.My.Resources.Resources._24_columns
        Me.tstOperaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstOperaciones.Name = "tstOperaciones"
        Me.tstOperaciones.Size = New System.Drawing.Size(93, 22)
        Me.tstOperaciones.Text = "Operaciones"
        '
        'tstColores
        '
        Me.tstColores.Image = CType(resources.GetObject("tstColores.Image"), System.Drawing.Image)
        Me.tstColores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstColores.Name = "tstColores"
        Me.tstColores.Size = New System.Drawing.Size(67, 22)
        Me.tstColores.Text = "Colores"
        '
        'tstReportes
        '
        Me.tstReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstRptOdontograma, Me.tstRptPresupuesto})
        Me.tstReportes.Image = CType(resources.GetObject("tstReportes.Image"), System.Drawing.Image)
        Me.tstReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstReportes.Name = "tstReportes"
        Me.tstReportes.Size = New System.Drawing.Size(82, 22)
        Me.tstReportes.Text = "Reportes"
        Me.tstReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tstRptOdontograma
        '
        Me.tstRptOdontograma.Name = "tstRptOdontograma"
        Me.tstRptOdontograma.Size = New System.Drawing.Size(211, 22)
        Me.tstRptOdontograma.Text = "Odontograma actual"
        '
        'tstRptPresupuesto
        '
        Me.tstRptPresupuesto.Name = "tstRptPresupuesto"
        Me.tstRptPresupuesto.Size = New System.Drawing.Size(211, 22)
        Me.tstRptPresupuesto.Text = "Presupuesto seleccionado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslCasosUrgentes
        '
        Me.tslCasosUrgentes.Name = "tslCasosUrgentes"
        Me.tslCasosUrgentes.Size = New System.Drawing.Size(325, 22)
        Me.tslCasosUrgentes.Text = "      Habilitar inserciones en el odontograma (casos urgentes)"
        '
        'lblTratInfo
        '
        Me.lblTratInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTratInfo.BackColor = System.Drawing.SystemColors.Window
        Me.lblTratInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTratInfo.Location = New System.Drawing.Point(523, 540)
        Me.lblTratInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTratInfo.Name = "lblTratInfo"
        Me.lblTratInfo.Size = New System.Drawing.Size(280, 30)
        Me.lblTratInfo.TabIndex = 51
        '
        'chbVerPendientes
        '
        Me.chbVerPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbVerPendientes.AutoSize = True
        Me.chbVerPendientes.Location = New System.Drawing.Point(521, 678)
        Me.chbVerPendientes.Name = "chbVerPendientes"
        Me.chbVerPendientes.Size = New System.Drawing.Size(127, 17)
        Me.chbVerPendientes.TabIndex = 59
        Me.chbVerPendientes.Text = "Ver trabajo pendiente"
        Me.chbVerPendientes.UseVisualStyleBackColor = True
        '
        'chbVerPresupuesto
        '
        Me.chbVerPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbVerPresupuesto.AutoSize = True
        Me.chbVerPresupuesto.Location = New System.Drawing.Point(648, 678)
        Me.chbVerPresupuesto.Name = "chbVerPresupuesto"
        Me.chbVerPresupuesto.Size = New System.Drawing.Size(165, 17)
        Me.chbVerPresupuesto.TabIndex = 60
        Me.chbVerPresupuesto.Text = "Ver presupuesto sin confirmar"
        Me.chbVerPresupuesto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(524, 591)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 14)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Observaciones del tratamiento seleccionado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPieza
        '
        Me.lblPieza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPieza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPieza.ForeColor = System.Drawing.Color.Black
        Me.lblPieza.Location = New System.Drawing.Point(699, 573)
        Me.lblPieza.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPieza.Name = "lblPieza"
        Me.lblPieza.Size = New System.Drawing.Size(101, 18)
        Me.lblPieza.TabIndex = 62
        Me.lblPieza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbcTrat
        '
        Me.tbcTrat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcTrat.Controls.Add(Me.TabPage1)
        Me.tbcTrat.Controls.Add(Me.TabPage2)
        Me.tbcTrat.Location = New System.Drawing.Point(516, 131)
        Me.tbcTrat.Name = "tbcTrat"
        Me.tbcTrat.SelectedIndex = 0
        Me.tbcTrat.Size = New System.Drawing.Size(295, 406)
        Me.tbcTrat.TabIndex = 63
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbxTrat)
        Me.TabPage1.Controls.Add(Me.LVw_TTrat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(287, 380)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Todos los tratamientos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LVw_TTrat
        '
        Me.LVw_TTrat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVw_TTrat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12})
        Me.LVw_TTrat.FullRowSelect = True
        Me.LVw_TTrat.HideSelection = False
        Me.LVw_TTrat.Location = New System.Drawing.Point(3, 33)
        Me.LVw_TTrat.MultiSelect = False
        Me.LVw_TTrat.Name = "LVw_TTrat"
        Me.LVw_TTrat.Size = New System.Drawing.Size(280, 341)
        Me.LVw_TTrat.SmallImageList = Me.imgList
        Me.LVw_TTrat.TabIndex = 18
        Me.LVw_TTrat.UseCompatibleStateImageBehavior = False
        Me.LVw_TTrat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Tratamientos"
        Me.ColumnHeader12.Width = 250
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LVw_Oper)
        Me.TabPage2.Controls.Add(Me.lblOperacion)
        Me.TabPage2.Controls.Add(Me.LVw_Trat)
        Me.TabPage2.Controls.Add(Me.lblTratamiento)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(287, 380)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Por operaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LVw_Oper
        '
        Me.LVw_Oper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVw_Oper.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader6})
        Me.LVw_Oper.FullRowSelect = True
        Me.LVw_Oper.HideSelection = False
        Me.LVw_Oper.Location = New System.Drawing.Point(4, 18)
        Me.LVw_Oper.MultiSelect = False
        Me.LVw_Oper.Name = "LVw_Oper"
        Me.LVw_Oper.Size = New System.Drawing.Size(280, 100)
        Me.LVw_Oper.SmallImageList = Me.imgList
        Me.LVw_Oper.TabIndex = 14
        Me.LVw_Oper.UseCompatibleStateImageBehavior = False
        Me.LVw_Oper.View = System.Windows.Forms.View.Details
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "Operaciones"
        Me.columnHeader6.Width = 250
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(5, 2)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(130, 13)
        Me.lblOperacion.TabIndex = 16
        Me.lblOperacion.Text = "Seleccione operación"
        '
        'LVw_Trat
        '
        Me.LVw_Trat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVw_Trat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader11})
        Me.LVw_Trat.FullRowSelect = True
        Me.LVw_Trat.HideSelection = False
        Me.LVw_Trat.Location = New System.Drawing.Point(4, 137)
        Me.LVw_Trat.MultiSelect = False
        Me.LVw_Trat.Name = "LVw_Trat"
        Me.LVw_Trat.Size = New System.Drawing.Size(280, 106)
        Me.LVw_Trat.SmallImageList = Me.imgList
        Me.LVw_Trat.TabIndex = 15
        Me.LVw_Trat.UseCompatibleStateImageBehavior = False
        Me.LVw_Trat.View = System.Windows.Forms.View.Details
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Tratamientos"
        Me.columnHeader11.Width = 250
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamiento.Location = New System.Drawing.Point(5, 121)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(137, 13)
        Me.lblTratamiento.TabIndex = 17
        Me.lblTratamiento.Text = "Seleccione tratamiento"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(814, 22)
        Me.StatusStrip1.TabIndex = 64
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel1.Text = "Odontograma: Alt+O   "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(148, 17)
        Me.ToolStripStatusLabel2.Text = "Trabajo pendiente: Alt+T   "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(117, 17)
        Me.ToolStripStatusLabel3.Text = "Presupuesto: Alt+P   "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(123, 17)
        Me.ToolStripStatusLabel4.Text = "Primera visita: Alt+V   "
        '
        'pbxFamilia
        '
        Me.pbxFamilia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxFamilia.Location = New System.Drawing.Point(725, 79)
        Me.pbxFamilia.Name = "pbxFamilia"
        Me.pbxFamilia.Size = New System.Drawing.Size(50, 50)
        Me.pbxFamilia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFamilia.TabIndex = 52
        Me.pbxFamilia.TabStop = False
        '
        'tbc
        '
        Me.tbc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbc.ImageList = Me.imgListtbC
        Me.tbc.ImageSize = New System.Drawing.Size(12, 12)
        Me.tbc.Location = New System.Drawing.Point(2, 30)
        Me.tbc.Name = "tbc"
        Me.tbc.Size = New System.Drawing.Size(510, 674)
        Me.tbc.TabIndex = 65
        Me.tbc.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tbpRealizado, Me.tbpPendiente, Me.tbpPresupuestos, Me.tbpPrimeraVisita})
        '
        'Odontograma1
        '
        Me.Odontograma1.BackColor = System.Drawing.SystemColors.Window
        Me.Odontograma1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Odontograma1.ContextMenuStrip = Me.oMenu
        Me.Odontograma1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Odontograma1.Location = New System.Drawing.Point(3, 4)
        Me.Odontograma1.Margin = New System.Windows.Forms.Padding(0)
        Me.Odontograma1.Name = "Odontograma1"
        Me.Odontograma1.Size = New System.Drawing.Size(500, 346)
        Me.Odontograma1.TabIndex = 12
        Me.Odontograma1.Tag = "1"
        Me.Odontograma1.temporal_dentition = False
        '
        'Odontograma2
        '
        Me.Odontograma2.BackColor = System.Drawing.SystemColors.Window
        Me.Odontograma2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Odontograma2.ContextMenuStrip = Me.oMenu
        Me.Odontograma2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Odontograma2.Location = New System.Drawing.Point(3, 4)
        Me.Odontograma2.Margin = New System.Windows.Forms.Padding(0)
        Me.Odontograma2.Name = "Odontograma2"
        Me.Odontograma2.Size = New System.Drawing.Size(500, 346)
        Me.Odontograma2.TabIndex = 17
        Me.Odontograma2.Tag = "2"
        Me.Odontograma2.temporal_dentition = False
        '
        'Odontograma3
        '
        Me.Odontograma3.BackColor = System.Drawing.SystemColors.Window
        Me.Odontograma3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Odontograma3.ContextMenuStrip = Me.oMenu
        Me.Odontograma3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Odontograma3.Location = New System.Drawing.Point(3, 4)
        Me.Odontograma3.Margin = New System.Windows.Forms.Padding(0)
        Me.Odontograma3.Name = "Odontograma3"
        Me.Odontograma3.Size = New System.Drawing.Size(500, 346)
        Me.Odontograma3.TabIndex = 17
        Me.Odontograma3.Tag = "3"
        Me.Odontograma3.temporal_dentition = False
        '
        'Grid3
        '
        Me.Grid3.AllowColumnDrag = False
        Me.Grid3.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid3.AutomaticSort = False
        Me.Grid3.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.Grid3.ColumnAutoResize = True
        Me.Grid3.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.Grid3.ContextMenuStrip = Me.cMenu
        Me.Grid3.DataMember = "LineasPresupuesto"
        Me.Grid3.DataSource = Me.OdontTratBindingSource
        Grid3_DesignTimeLayout.LayoutString = resources.GetString("Grid3_DesignTimeLayout.LayoutString")
        Me.Grid3.DesignTimeLayout = Grid3_DesignTimeLayout
        Me.Grid3.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.Grid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grid3.GridLines = Janus.Windows.GridEX.GridLines.None
        Me.Grid3.GroupByBoxVisible = False
        Me.Grid3.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.Grid3.ImageList = Me.imgList
        Me.Grid3.Location = New System.Drawing.Point(110, 384)
        Me.Grid3.Name = "Grid3"
        Me.Grid3.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable
        Me.Grid3.Size = New System.Drawing.Size(393, 241)
        Me.Grid3.TabIndex = 130
        '
        'OdontTratBindingSource
        '
        Me.OdontTratBindingSource.DataSource = Me.OdontTrat
        Me.OdontTratBindingSource.Position = 0
        '
        'OdontTrat
        '
        Me.OdontTrat.DataSetName = "OdontTrat"
        Me.OdontTrat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Odontograma4
        '
        Me.Odontograma4.BackColor = System.Drawing.SystemColors.Window
        Me.Odontograma4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Odontograma4.ContextMenuStrip = Me.oMenu
        Me.Odontograma4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Odontograma4.Location = New System.Drawing.Point(3, 4)
        Me.Odontograma4.Margin = New System.Windows.Forms.Padding(0)
        Me.Odontograma4.Name = "Odontograma4"
        Me.Odontograma4.Size = New System.Drawing.Size(500, 346)
        Me.Odontograma4.TabIndex = 17
        Me.Odontograma4.Tag = "4"
        Me.Odontograma4.temporal_dentition = False
        '
        'LineasPresupuestoTableAdapter
        '
        Me.LineasPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'CtrlAlarmaPaciente1
        '
        Me.CtrlAlarmaPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlAlarmaPaciente1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlAlarmaPaciente1.ID_Paciente = Nothing
        Me.CtrlAlarmaPaciente1.Location = New System.Drawing.Point(598, 0)
        Me.CtrlAlarmaPaciente1.Name = "CtrlAlarmaPaciente1"
        Me.CtrlAlarmaPaciente1.Size = New System.Drawing.Size(216, 25)
        Me.CtrlAlarmaPaciente1.TabIndex = 66
        '
        'tbpRealizado
        '
        Me.tbpRealizado.Controls.Add(Me.lvw1)
        Me.tbpRealizado.Controls.Add(Me.Odontograma1)
        Me.tbpRealizado.ImageIndex = 0
        Me.tbpRealizado.Location = New System.Drawing.Point(1, 21)
        Me.tbpRealizado.Name = "tbpRealizado"
        Me.tbpRealizado.Size = New System.Drawing.Size(506, 650)
        Me.tbpRealizado.TabStop = True
        Me.tbpRealizado.Text = "Odontograma"
        '
        'tbpPendiente
        '
        Me.tbpPendiente.Controls.Add(Me.pbx_urg1)
        Me.tbpPendiente.Controls.Add(Me.Odontograma2)
        Me.tbpPendiente.Controls.Add(Me.chbUrgente2)
        Me.tbpPendiente.Controls.Add(Me.lvw2)
        Me.tbpPendiente.ImageIndex = 1
        Me.tbpPendiente.Location = New System.Drawing.Point(1, 21)
        Me.tbpPendiente.Name = "tbpPendiente"
        Me.tbpPendiente.Size = New System.Drawing.Size(506, 650)
        Me.tbpPendiente.TabStop = True
        Me.tbpPendiente.Text = "Trabajo pendiente"
        '
        'tbpPresupuestos
        '
        Me.tbpPresupuestos.Controls.Add(Me.CtrlMutua1)
        Me.tbpPresupuestos.Controls.Add(Me.TsPresupuestos)
        Me.tbpPresupuestos.Controls.Add(Me.Odontograma3)
        Me.tbpPresupuestos.Controls.Add(Me.lblImporte)
        Me.tbpPresupuestos.Controls.Add(Me.Grid3)
        Me.tbpPresupuestos.Controls.Add(Me.Panel1)
        Me.tbpPresupuestos.Controls.Add(Me.pbx_urg2)
        Me.tbpPresupuestos.Controls.Add(Me.tvwPresupuestos)
        Me.tbpPresupuestos.Controls.Add(Me.chbUrgente3)
        Me.tbpPresupuestos.ImageIndex = 2
        Me.tbpPresupuestos.Location = New System.Drawing.Point(1, 21)
        Me.tbpPresupuestos.Name = "tbpPresupuestos"
        Me.tbpPresupuestos.Size = New System.Drawing.Size(506, 650)
        Me.tbpPresupuestos.TabStop = True
        Me.tbpPresupuestos.Text = "Presupuestos"
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = False
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(128, 357)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(373, 21)
        Me.CtrlMutua1.TabIndex = 131
        '
        'tbpPrimeraVisita
        '
        Me.tbpPrimeraVisita.Controls.Add(Me.lvw4)
        Me.tbpPrimeraVisita.Controls.Add(Me.Odontograma4)
        Me.tbpPrimeraVisita.ImageIndex = 3
        Me.tbpPrimeraVisita.Location = New System.Drawing.Point(1, 21)
        Me.tbpPrimeraVisita.Name = "tbpPrimeraVisita"
        Me.tbpPrimeraVisita.Size = New System.Drawing.Size(506, 650)
        Me.tbpPrimeraVisita.TabStop = True
        Me.tbpPrimeraVisita.Text = "Primera visita"
        '
        'tbxTrat
        '
        Me.tbxTrat.AcceptsReturn = True
        Me.tbxTrat.Location = New System.Drawing.Point(3, 7)
        Me.tbxTrat.Name = "tbxTrat"
        Me.tbxTrat.Size = New System.Drawing.Size(279, 20)
        Me.tbxTrat.TabIndex = 19
        '
        'rtb3
        '
        Me.rtb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb3.Enabled = False
        Me.rtb3.Location = New System.Drawing.Point(523, 608)
        Me.rtb3.MaxLength = 250
        Me.rtb3.Name = "rtb3"
        Me.rtb3.Size = New System.Drawing.Size(280, 63)
        Me.rtb3.TabIndex = 58
        Me.rtb3.Text = ""
        Me.rtb3.Visible = False
        '
        'rtb2
        '
        Me.rtb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb2.Enabled = False
        Me.rtb2.Location = New System.Drawing.Point(523, 608)
        Me.rtb2.MaxLength = 250
        Me.rtb2.Name = "rtb2"
        Me.rtb2.Size = New System.Drawing.Size(280, 63)
        Me.rtb2.TabIndex = 57
        Me.rtb2.Text = ""
        Me.rtb2.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb1.Enabled = False
        Me.rtb1.Location = New System.Drawing.Point(523, 608)
        Me.rtb1.MaxLength = 250
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(280, 63)
        Me.rtb1.TabIndex = 56
        Me.rtb1.Text = ""
        '
        'rtb4
        '
        Me.rtb4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb4.Enabled = False
        Me.rtb4.Location = New System.Drawing.Point(523, 608)
        Me.rtb4.MaxLength = 250
        Me.rtb4.Name = "rtb4"
        Me.rtb4.Size = New System.Drawing.Size(280, 63)
        Me.rtb4.TabIndex = 55
        Me.rtb4.Text = ""
        Me.rtb4.Visible = False
        '
        'frmOdontograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 729)
        Me.Controls.Add(Me.CtrlAlarmaPaciente1)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.chbHabilitar)
        Me.Controls.Add(Me.TsMenu)
        Me.Controls.Add(Me.tbcTrat)
        Me.Controls.Add(Me.lblPieza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chbVerPresupuesto)
        Me.Controls.Add(Me.chbVerPendientes)
        Me.Controls.Add(Me.rtb3)
        Me.Controls.Add(Me.rtb2)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.rtb4)
        Me.Controls.Add(Me.lblTratInfo)
        Me.Controls.Add(Me.pbxFamilia)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.CBx_Doct)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmOdontograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Odontograma"
        Me.cMenu.ResumeLayout(False)
        Me.oMenu.ResumeLayout(False)
        CType(Me.pbx_urg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsPresupuestos.ResumeLayout(False)
        Me.TsPresupuestos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pMenu.ResumeLayout(False)
        CType(Me.pbx_urg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.tbcTrat.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pbxFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdontTratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdontTrat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpRealizado.ResumeLayout(False)
        Me.tbpPendiente.ResumeLayout(False)
        Me.tbpPendiente.PerformLayout()
        Me.tbpPresupuestos.ResumeLayout(False)
        Me.tbpPresupuestos.PerformLayout()
        Me.tbpPrimeraVisita.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents CBx_Doct As System.Windows.Forms.ComboBox
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents cMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmEliminar As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lvw1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Odontograma1 As Odontograma
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnDefinitiva As System.Windows.Forms.RadioButton
    Friend WithEvents rbnTemporal As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chbUrgente2 As System.Windows.Forms.CheckBox
    Private WithEvents lvw2 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Odontograma2 As Odontograma
    Friend WithEvents chbUrgente3 As System.Windows.Forms.CheckBox
    Friend WithEvents Odontograma3 As Odontograma
    Private WithEvents lvw4 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Odontograma4 As Odontograma
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents cmAPendiente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmARealizado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chbHabilitar As System.Windows.Forms.CheckBox
    Friend WithEvents TsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tstOperaciones As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstColores As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTratInfo As System.Windows.Forms.Label
    Friend WithEvents pbxFamilia As System.Windows.Forms.PictureBox
    Friend WithEvents rtb4 As ctrlRichTextBoxAvanzado
    Friend WithEvents rtb1 As ctrlRichTextBoxAvanzado
    Friend WithEvents rtb2 As ctrlRichTextBoxAvanzado
    Friend WithEvents rtb3 As ctrlRichTextBoxAvanzado
    Friend WithEvents chbVerPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents chbVerPresupuesto As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imgListtbC As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents oMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mitHistorial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPieza As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tvwPresupuestos As System.Windows.Forms.TreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mitNuevoPres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitEliminarPres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbx_urg2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_urg1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents mitMoverTodoPendiente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitMoverTodoRealizado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbcTrat As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents LVw_Oper As System.Windows.Forms.ListView
    Private WithEvents columnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblOperacion As System.Windows.Forms.Label
    Private WithEvents LVw_Trat As System.Windows.Forms.ListView
    Private WithEvents columnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTratamiento As System.Windows.Forms.Label
    Friend WithEvents tbxTrat As ctrlTextboxAvanzado
    Private WithEvents LVw_TTrat As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmNTratamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstReportes As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tstRptOdontograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mitVerReporte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mitFicherosAsociados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslCasosUrgentes As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstRptPresupuesto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsPresupuestos As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPMPendiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPMRealizado As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmVerCita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbc As Janus.Windows.UI.Tab.UITab
    Friend WithEvents tbpRealizado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tbpPendiente As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tbpPresupuestos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tbpPrimeraVisita As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Grid3 As Janus.Windows.GridEX.GridEX
    Friend WithEvents LineasPresupuestoTableAdapter As centro_medico.OdontTratTableAdapters.LineasPresupuestoTableAdapter
    Friend WithEvents OdontTratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OdontTrat As centro_medico.OdontTrat
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents CtrlAlarmaPaciente1 As centro_medico.ctrlAlarmaPaciente

End Class
