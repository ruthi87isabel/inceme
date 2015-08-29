<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasM
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
        Dim GridEXListado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXListado_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition0.FormatStyle.BackgroundImag" & _
        "e")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasM))
        Dim GridEXListado_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition1.FormatStyle.BackgroundImag" & _
        "e")
        Dim cmbSeries_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridEXListado = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsDuplicarFactura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tbImprimirSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chb_mutuas = New System.Windows.Forms.CheckBox()
        Me.chb_pacientes = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_sincobrar = New System.Windows.Forms.RadioButton()
        Me.rb_cobradas = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_FCOBRO_ff = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_FEMISION_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FCOBRO_fi = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FEMISION_fi = New System.Windows.Forms.DateTimePicker()
        Me.cmbSeries = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListadoPacientesTableAdapter1 = New centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDni = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNumero = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.CtrlConceptoFacturable21 = New centro_medico.ctrlConceptoFacturable2()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEXListado
        '
        Me.GridEXListado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXListado.ColumnAutoResize = True
        Me.GridEXListado.DataSource = Me.FACTURABindingSource
        GridEXListado_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEXListado_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEXListado_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEXListado_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEXListado_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEXListado_DesignTimeLayout_Reference_0, GridEXListado_DesignTimeLayout_Reference_1})
        GridEXListado_DesignTimeLayout.LayoutString = resources.GetString("GridEXListado_DesignTimeLayout.LayoutString")
        Me.GridEXListado.DesignTimeLayout = GridEXListado_DesignTimeLayout
        Me.GridEXListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXListado.GroupByBoxVisible = False
        Me.GridEXListado.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXListado.Location = New System.Drawing.Point(2, 248)
        Me.GridEXListado.Name = "GridEXListado"
        Me.GridEXListado.Size = New System.Drawing.Size(1037, 255)
        Me.GridEXListado.TabIndex = 1
        Me.GridEXListado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXListado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.tsDuplicarFactura, Me.ToolStripSeparator1, Me.tlbImprimir, Me.tbImprimirSeleccionados})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        Me.NewToolStripButton.ToolTipText = "Nueva Factura"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "Modificar"
        Me.tst_Editar.ToolTipText = "Editar Factura"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "Eliminar"
        Me.tst_Eliminar.ToolTipText = "Borrar Factura"
        '
        'tsDuplicarFactura
        '
        Me.tsDuplicarFactura.Enabled = False
        Me.tsDuplicarFactura.Image = Global.centro_medico.My.Resources.Resources._24_tag_manager
        Me.tsDuplicarFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDuplicarFactura.Name = "tsDuplicarFactura"
        Me.tsDuplicarFactura.Size = New System.Drawing.Size(111, 22)
        Me.tsDuplicarFactura.Text = "Duplicar factura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(111, 22)
        Me.tlbImprimir.Text = "Imprimir listado"
        '
        'tbImprimirSeleccionados
        '
        Me.tbImprimirSeleccionados.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tbImprimirSeleccionados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbImprimirSeleccionados.Name = "tbImprimirSeleccionados"
        Me.tbImprimirSeleccionados.Size = New System.Drawing.Size(151, 22)
        Me.tbImprimirSeleccionados.Text = "Imprimir Seleccionados"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1041, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.centro_medico.My.Resources.Resources.handshake
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel1.Text = "Mutuas"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = Global.centro_medico.My.Resources.Resources.pacienteSingular16x16
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel2.Text = "Pacientes"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chb_mutuas)
        Me.GroupBox4.Controls.Add(Me.chb_pacientes)
        Me.GroupBox4.Location = New System.Drawing.Point(210, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 92)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facturado a "
        '
        'chb_mutuas
        '
        Me.chb_mutuas.AutoSize = True
        Me.chb_mutuas.Checked = True
        Me.chb_mutuas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_mutuas.Location = New System.Drawing.Point(9, 51)
        Me.chb_mutuas.Name = "chb_mutuas"
        Me.chb_mutuas.Size = New System.Drawing.Size(61, 17)
        Me.chb_mutuas.TabIndex = 1
        Me.chb_mutuas.Text = "Mutuas"
        Me.chb_mutuas.UseVisualStyleBackColor = True
        '
        'chb_pacientes
        '
        Me.chb_pacientes.AutoSize = True
        Me.chb_pacientes.Checked = True
        Me.chb_pacientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_pacientes.Location = New System.Drawing.Point(10, 28)
        Me.chb_pacientes.Name = "chb_pacientes"
        Me.chb_pacientes.Size = New System.Drawing.Size(73, 17)
        Me.chb_pacientes.TabIndex = 0
        Me.chb_pacientes.Text = "Pacientes"
        Me.chb_pacientes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_sincobrar)
        Me.GroupBox3.Controls.Add(Me.rb_cobradas)
        Me.GroupBox3.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(319, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 92)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        '
        'rb_sincobrar
        '
        Me.rb_sincobrar.AutoSize = True
        Me.rb_sincobrar.Location = New System.Drawing.Point(6, 64)
        Me.rb_sincobrar.Name = "rb_sincobrar"
        Me.rb_sincobrar.Size = New System.Drawing.Size(73, 17)
        Me.rb_sincobrar.TabIndex = 2
        Me.rb_sincobrar.Text = "Sin cobrar"
        Me.rb_sincobrar.UseVisualStyleBackColor = True
        '
        'rb_cobradas
        '
        Me.rb_cobradas.AutoSize = True
        Me.rb_cobradas.Location = New System.Drawing.Point(6, 41)
        Me.rb_cobradas.Name = "rb_cobradas"
        Me.rb_cobradas.Size = New System.Drawing.Size(70, 17)
        Me.rb_cobradas.TabIndex = 1
        Me.rb_cobradas.Text = "Cobradas"
        Me.rb_cobradas.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Checked = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(6, 16)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 0
        Me.rb_todascobrar.TabStop = True
        Me.rb_todascobrar.Text = "Todas"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtp_FCOBRO_ff)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtp_FEMISION_ff)
        Me.GroupBox2.Controls.Add(Me.dtp_FCOBRO_fi)
        Me.GroupBox2.Controls.Add(Me.dtp_FEMISION_fi)
        Me.GroupBox2.Location = New System.Drawing.Point(423, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 91)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'dtp_FCOBRO_ff
        '
        Me.dtp_FCOBRO_ff.Checked = False
        Me.dtp_FCOBRO_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FCOBRO_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FCOBRO_ff.Location = New System.Drawing.Point(227, 56)
        Me.dtp_FCOBRO_ff.Name = "dtp_FCOBRO_ff"
        Me.dtp_FCOBRO_ff.ShowCheckBox = True
        Me.dtp_FCOBRO_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FCOBRO_ff.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Cobro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha Emisión:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'dtp_FEMISION_ff
        '
        Me.dtp_FEMISION_ff.Checked = False
        Me.dtp_FEMISION_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FEMISION_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEMISION_ff.Location = New System.Drawing.Point(227, 27)
        Me.dtp_FEMISION_ff.Name = "dtp_FEMISION_ff"
        Me.dtp_FEMISION_ff.ShowCheckBox = True
        Me.dtp_FEMISION_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FEMISION_ff.TabIndex = 1
        '
        'dtp_FCOBRO_fi
        '
        Me.dtp_FCOBRO_fi.Checked = False
        Me.dtp_FCOBRO_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FCOBRO_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FCOBRO_fi.Location = New System.Drawing.Point(92, 55)
        Me.dtp_FCOBRO_fi.Name = "dtp_FCOBRO_fi"
        Me.dtp_FCOBRO_fi.ShowCheckBox = True
        Me.dtp_FCOBRO_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FCOBRO_fi.TabIndex = 0
        '
        'dtp_FEMISION_fi
        '
        Me.dtp_FEMISION_fi.Checked = False
        Me.dtp_FEMISION_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FEMISION_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEMISION_fi.Location = New System.Drawing.Point(92, 27)
        Me.dtp_FEMISION_fi.Name = "dtp_FEMISION_fi"
        Me.dtp_FEMISION_fi.ShowCheckBox = True
        Me.dtp_FEMISION_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FEMISION_fi.TabIndex = 0
        '
        'cmbSeries
        '
        Me.cmbSeries.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cmbSeries_DesignTimeLayout.LayoutString = resources.GetString("cmbSeries_DesignTimeLayout.LayoutString")
        Me.cmbSeries.DesignTimeLayout = cmbSeries_DesignTimeLayout
        Me.cmbSeries.DropDownDataSource = Me.SERIESBindingSource
        Me.cmbSeries.DropDownValueMember = "CODIGO"
        Me.cmbSeries.HasImage = False
        Me.cmbSeries.Location = New System.Drawing.Point(64, 53)
        Me.cmbSeries.Name = "cmbSeries"
        Me.cmbSeries.SaveSettings = False
        Me.cmbSeries.Size = New System.Drawing.Size(119, 20)
        Me.cmbSeries.TabIndex = 1
        Me.cmbSeries.ValuesDataMember = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Series:"
        '
        'ListadoPacientesTableAdapter1
        '
        Me.ListadoPacientesTableAdapter1.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Número:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.cmbSeries)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 92)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(711, 184)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(67, 38)
        Me.btnFiltrar.TabIndex = 121
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'pnl_Loading
        '
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(357, 346)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(123, 48)
        Me.pnl_Loading.TabIndex = 133
        Me.pnl_Loading.Visible = False
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(59, 18)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Loading.TabIndex = 119
        Me.lbl_Loading.Text = "Filtrando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(13, 8)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 212
        Me.Label10.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "Apellido 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Apellido 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "Nombre:"
        '
        'txtDni
        '
        Me.txtDni.AcceptsReturn = True
        Me.txtDni.Location = New System.Drawing.Point(253, 167)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(142, 20)
        Me.txtDni.TabIndex = 211
        '
        'txtApellido2
        '
        Me.txtApellido2.AcceptsReturn = True
        Me.txtApellido2.Location = New System.Drawing.Point(78, 222)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido2.TabIndex = 207
        '
        'txtApellido1
        '
        Me.txtApellido1.AcceptsReturn = True
        Me.txtApellido1.Location = New System.Drawing.Point(78, 196)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido1.TabIndex = 206
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(78, 170)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(107, 20)
        Me.txtNombre.TabIndex = 205
        '
        'txtNumero
        '
        Me.txtNumero.AcceptsReturn = True
        Me.txtNumero.Location = New System.Drawing.Point(64, 23)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 0
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = False
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(212, 192)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(279, 21)
        Me.CtrlMutua1.TabIndex = 19
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = False
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(196, 219)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(295, 25)
        Me.CtrlEmpresa1.TabIndex = 18
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(8, 119)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(407, 50)
        Me.CtrlPaciente1.TabIndex = 122
        '
        'CtrlConceptoFacturable21
        '
        Me.CtrlConceptoFacturable21.ID_ConceptosFra = Nothing
        Me.CtrlConceptoFacturable21.Location = New System.Drawing.Point(440, 135)
        Me.CtrlConceptoFacturable21.Name = "CtrlConceptoFacturable21"
        Me.CtrlConceptoFacturable21.Size = New System.Drawing.Size(307, 26)
        Me.CtrlConceptoFacturable21.TabIndex = 114
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(437, 167)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(264, 23)
        Me.CtrlFormaPago21.TabIndex = 20
        '
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataSource = GetType(centro_medico.SERIES)
        '
        'FACTURABindingSource
        '
        Me.FACTURABindingSource.DataSource = GetType(centro_medico.FACTURA)
        '
        'frmFacturasM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 526)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CtrlMutua1)
        Me.Controls.Add(Me.CtrlEmpresa1)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.CtrlConceptoFacturable21)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GridEXListado)
        Me.Name = "frmFacturasM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Médicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEXListado As Janus.Windows.GridEX.GridEX
    Friend WithEvents FACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_mutuas As System.Windows.Forms.CheckBox
    Friend WithEvents chb_pacientes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_sincobrar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cobradas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_FCOBRO_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_FEMISION_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FCOBRO_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FEMISION_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlConceptoFacturable21 As centro_medico.ctrlConceptoFacturable2
    Friend WithEvents cmbSeries As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListadoPacientesTableAdapter1 As centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter
    Friend WithEvents txtNumero As ctrlTextboxAvanzado
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents tsDuplicarFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbImprimirSeleccionados As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDni As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtApellido1 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtNombre As centro_medico.ctrlTextboxAvanzado

End Class
