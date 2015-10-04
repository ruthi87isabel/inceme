<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_analiticas_ex
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lb_anHasta As System.Windows.Forms.Label
        Dim lb_anDesde As System.Windows.Forms.Label
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_analiticas_ex))
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lb_teclas = New System.Windows.Forms.Label()
        Me.nv_anAnaliticas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem5 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem5 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorEditAnaliticas = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimirAnalitica = New System.Windows.Forms.ToolStripButton()
        Me.dtg_anAnaliticas = New System.Windows.Forms.DataGridView()
        Me.ANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_anNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_anNotas = New System.Windows.Forms.Label()
        Me.tb_anTotal = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_anTotal = New System.Windows.Forms.Label()
        Me.dtg_anConceptosanaliticas = New System.Windows.Forms.DataGridView()
        Me.gb_anFiltrar = New System.Windows.Forms.GroupBox()
        Me.bt_anFiltrar = New System.Windows.Forms.Button()
        Me.dtp_anHasta = New System.Windows.Forms.DateTimePicker()
        Me.gb_anOrdenarpor = New System.Windows.Forms.GroupBox()
        Me.rb_anImporte = New System.Windows.Forms.RadioButton()
        Me.rb_anDescripcion = New System.Windows.Forms.RadioButton()
        Me.rb_anFecha = New System.Windows.Forms.RadioButton()
        Me.rb_anNumero = New System.Windows.Forms.RadioButton()
        Me.dtp_anDesde = New System.Windows.Forms.DateTimePicker()
        Me.ANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter()
        Me.LINEASANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASANALITICASTableAdapter()
        Me.gb_Principales = New System.Windows.Forms.GroupBox()
        Me.tb_dpEdadhactual = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_Factura = New System.Windows.Forms.Button()
        Me.tb_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_SegundoAp = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_PrimerAp = New centro_medico.ctrlTextboxAvanzado()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.lb_FechaIngreso = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_SegundoAp = New System.Windows.Forms.Label()
        Me.lb_PrimerAp = New System.Windows.Forms.Label()
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        lb_anHasta = New System.Windows.Forms.Label()
        lb_anDesde = New System.Windows.Forms.Label()
        lb_dpEdadhlaboral = New System.Windows.Forms.Label()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.nv_anAnaliticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nv_anAnaliticas.SuspendLayout()
        CType(Me.dtg_anAnaliticas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_anConceptosanaliticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_anFiltrar.SuspendLayout()
        Me.gb_anOrdenarpor.SuspendLayout()
        CType(Me.LINEASANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_anHasta
        '
        lb_anHasta.AutoSize = True
        lb_anHasta.Location = New System.Drawing.Point(246, 22)
        lb_anHasta.Name = "lb_anHasta"
        lb_anHasta.Size = New System.Drawing.Size(35, 13)
        lb_anHasta.TabIndex = 5
        lb_anHasta.Text = "Hasta"
        '
        'lb_anDesde
        '
        lb_anDesde.AutoSize = True
        lb_anDesde.Location = New System.Drawing.Point(144, 22)
        lb_anDesde.Name = "lb_anDesde"
        lb_anDesde.Size = New System.Drawing.Size(38, 13)
        lb_anDesde.TabIndex = 3
        lb_anDesde.Text = "Desde"
        '
        'lb_dpEdadhlaboral
        '
        lb_dpEdadhlaboral.AutoSize = True
        lb_dpEdadhlaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpEdadhlaboral.Location = New System.Drawing.Point(585, 9)
        lb_dpEdadhlaboral.Name = "lb_dpEdadhlaboral"
        lb_dpEdadhlaboral.Size = New System.Drawing.Size(35, 13)
        lb_dpEdadhlaboral.TabIndex = 37
        lb_dpEdadhlaboral.Text = "Edad:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(855, 25)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(35, 523)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(401, 13)
        Me.lb_teclas.TabIndex = 23
        Me.lb_teclas.Text = "Alt A=Añadir; Alt B=Borrar; Alt E=Editar; Alt F=Filtrar; Alt+G=Guardar; Alt+C=Can" & _
    "celar"
        '
        'nv_anAnaliticas
        '
        Me.nv_anAnaliticas.AddNewItem = Me.BindingNavigatorAddNewItem5
        Me.nv_anAnaliticas.AllowItemReorder = True
        Me.nv_anAnaliticas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nv_anAnaliticas.AutoSize = False
        Me.nv_anAnaliticas.CountItem = Me.BindingNavigatorCountItem5
        Me.nv_anAnaliticas.DeleteItem = Me.BindingNavigatorDeleteItem5
        Me.nv_anAnaliticas.Dock = System.Windows.Forms.DockStyle.None
        Me.nv_anAnaliticas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem5, Me.BindingNavigatorMovePreviousItem5, Me.BindingNavigatorSeparator15, Me.BindingNavigatorPositionItem5, Me.BindingNavigatorCountItem5, Me.BindingNavigatorSeparator16, Me.BindingNavigatorMoveNextItem5, Me.BindingNavigatorMoveLastItem5, Me.BindingNavigatorSeparator17, Me.BindingNavigatorEditAnaliticas, Me.BindingNavigatorDeleteItem5, Me.BindingNavigatorAddNewItem5, Me.tlbImprimirAnalitica})
        Me.nv_anAnaliticas.Location = New System.Drawing.Point(8, 472)
        Me.nv_anAnaliticas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem5
        Me.nv_anAnaliticas.MoveLastItem = Me.BindingNavigatorMoveLastItem5
        Me.nv_anAnaliticas.MoveNextItem = Me.BindingNavigatorMoveNextItem5
        Me.nv_anAnaliticas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem5
        Me.nv_anAnaliticas.Name = "nv_anAnaliticas"
        Me.nv_anAnaliticas.PositionItem = Me.BindingNavigatorPositionItem5
        Me.nv_anAnaliticas.Size = New System.Drawing.Size(473, 33)
        Me.nv_anAnaliticas.TabIndex = 24
        Me.nv_anAnaliticas.Text = "BindingNavigator1"
        Me.nv_anAnaliticas.Visible = False
        '
        'BindingNavigatorAddNewItem5
        '
        Me.BindingNavigatorAddNewItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem5.Image = CType(resources.GetObject("BindingNavigatorAddNewItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem5.Name = "BindingNavigatorAddNewItem5"
        Me.BindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem5.Size = New System.Drawing.Size(62, 30)
        Me.BindingNavigatorAddNewItem5.Text = "Añadir"
        '
        'BindingNavigatorCountItem5
        '
        Me.BindingNavigatorCountItem5.Name = "BindingNavigatorCountItem5"
        Me.BindingNavigatorCountItem5.Size = New System.Drawing.Size(35, 30)
        Me.BindingNavigatorCountItem5.Text = "of {0}"
        Me.BindingNavigatorCountItem5.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem5
        '
        Me.BindingNavigatorDeleteItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem5.Image = CType(resources.GetObject("BindingNavigatorDeleteItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem5.Name = "BindingNavigatorDeleteItem5"
        Me.BindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem5.Size = New System.Drawing.Size(59, 30)
        Me.BindingNavigatorDeleteItem5.Text = "Borrar"
        '
        'BindingNavigatorMoveFirstItem5
        '
        Me.BindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem5.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem5.Name = "BindingNavigatorMoveFirstItem5"
        Me.BindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem5.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveFirstItem5.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem5
        '
        Me.BindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem5.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem5.Name = "BindingNavigatorMovePreviousItem5"
        Me.BindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem5.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMovePreviousItem5.Text = "Move previous"
        '
        'BindingNavigatorSeparator15
        '
        Me.BindingNavigatorSeparator15.Name = "BindingNavigatorSeparator15"
        Me.BindingNavigatorSeparator15.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem5
        '
        Me.BindingNavigatorPositionItem5.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem5.AutoSize = False
        Me.BindingNavigatorPositionItem5.Name = "BindingNavigatorPositionItem5"
        Me.BindingNavigatorPositionItem5.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem5.Text = "0"
        Me.BindingNavigatorPositionItem5.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator16
        '
        Me.BindingNavigatorSeparator16.Name = "BindingNavigatorSeparator16"
        Me.BindingNavigatorSeparator16.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem5
        '
        Me.BindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem5.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem5.Name = "BindingNavigatorMoveNextItem5"
        Me.BindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem5.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveNextItem5.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem5
        '
        Me.BindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem5.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem5.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem5.Name = "BindingNavigatorMoveLastItem5"
        Me.BindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem5.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveLastItem5.Text = "Move last"
        '
        'BindingNavigatorSeparator17
        '
        Me.BindingNavigatorSeparator17.Name = "BindingNavigatorSeparator17"
        Me.BindingNavigatorSeparator17.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorEditAnaliticas
        '
        Me.BindingNavigatorEditAnaliticas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorEditAnaliticas.Image = Global.centro_medico.My.Resources.Resources.folderopen
        Me.BindingNavigatorEditAnaliticas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditAnaliticas.Name = "BindingNavigatorEditAnaliticas"
        Me.BindingNavigatorEditAnaliticas.Size = New System.Drawing.Size(57, 30)
        Me.BindingNavigatorEditAnaliticas.Text = "Editar"
        '
        'tlbImprimirAnalitica
        '
        Me.tlbImprimirAnalitica.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlbImprimirAnalitica.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimirAnalitica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimirAnalitica.Name = "tlbImprimirAnalitica"
        Me.tlbImprimirAnalitica.Size = New System.Drawing.Size(73, 30)
        Me.tlbImprimirAnalitica.Text = "Imprimir"
        '
        'dtg_anAnaliticas
        '
        Me.dtg_anAnaliticas.AllowUserToAddRows = False
        Me.dtg_anAnaliticas.AllowUserToDeleteRows = False
        Me.dtg_anAnaliticas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_anAnaliticas.BackgroundColor = System.Drawing.Color.White
        Me.dtg_anAnaliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_anAnaliticas.Location = New System.Drawing.Point(8, 80)
        Me.dtg_anAnaliticas.MultiSelect = False
        Me.dtg_anAnaliticas.Name = "dtg_anAnaliticas"
        Me.dtg_anAnaliticas.ReadOnly = True
        Me.dtg_anAnaliticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_anAnaliticas.Size = New System.Drawing.Size(476, 389)
        Me.dtg_anAnaliticas.TabIndex = 31
        '
        'ANALITICASBindingSource
        '
        Me.ANALITICASBindingSource.DataMember = "ANALITICAS"
        Me.ANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'tb_anNotas
        '
        Me.tb_anNotas.AcceptsReturn = True
        Me.tb_anNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_anNotas.BackColor = System.Drawing.Color.White
        Me.tb_anNotas.Location = New System.Drawing.Point(496, 403)
        Me.tb_anNotas.Multiline = True
        Me.tb_anNotas.Name = "tb_anNotas"
        Me.tb_anNotas.ReadOnly = True
        Me.tb_anNotas.Size = New System.Drawing.Size(351, 93)
        Me.tb_anNotas.TabIndex = 30
        '
        'lb_anNotas
        '
        Me.lb_anNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_anNotas.AutoSize = True
        Me.lb_anNotas.Location = New System.Drawing.Point(496, 386)
        Me.lb_anNotas.Name = "lb_anNotas"
        Me.lb_anNotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_anNotas.TabIndex = 29
        Me.lb_anNotas.Text = "Notas"
        '
        'tb_anTotal
        '
        Me.tb_anTotal.AcceptsReturn = True
        Me.tb_anTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_anTotal.Location = New System.Drawing.Point(699, 377)
        Me.tb_anTotal.Name = "tb_anTotal"
        Me.tb_anTotal.ReadOnly = True
        Me.tb_anTotal.Size = New System.Drawing.Size(148, 20)
        Me.tb_anTotal.TabIndex = 28
        Me.tb_anTotal.Visible = False
        '
        'lb_anTotal
        '
        Me.lb_anTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_anTotal.AutoSize = True
        Me.lb_anTotal.Location = New System.Drawing.Point(653, 379)
        Me.lb_anTotal.Name = "lb_anTotal"
        Me.lb_anTotal.Size = New System.Drawing.Size(31, 13)
        Me.lb_anTotal.TabIndex = 27
        Me.lb_anTotal.Text = "Total"
        Me.lb_anTotal.Visible = False
        '
        'dtg_anConceptosanaliticas
        '
        Me.dtg_anConceptosanaliticas.AllowUserToAddRows = False
        Me.dtg_anConceptosanaliticas.AllowUserToDeleteRows = False
        Me.dtg_anConceptosanaliticas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_anConceptosanaliticas.BackgroundColor = System.Drawing.Color.White
        Me.dtg_anConceptosanaliticas.Location = New System.Drawing.Point(496, 199)
        Me.dtg_anConceptosanaliticas.MultiSelect = False
        Me.dtg_anConceptosanaliticas.Name = "dtg_anConceptosanaliticas"
        Me.dtg_anConceptosanaliticas.ReadOnly = True
        Me.dtg_anConceptosanaliticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_anConceptosanaliticas.Size = New System.Drawing.Size(351, 177)
        Me.dtg_anConceptosanaliticas.TabIndex = 26
        '
        'gb_anFiltrar
        '
        Me.gb_anFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_anFiltrar.Controls.Add(Me.bt_anFiltrar)
        Me.gb_anFiltrar.Controls.Add(lb_anHasta)
        Me.gb_anFiltrar.Controls.Add(Me.dtp_anHasta)
        Me.gb_anFiltrar.Controls.Add(lb_anDesde)
        Me.gb_anFiltrar.Controls.Add(Me.gb_anOrdenarpor)
        Me.gb_anFiltrar.Controls.Add(Me.dtp_anDesde)
        Me.gb_anFiltrar.Location = New System.Drawing.Point(496, 78)
        Me.gb_anFiltrar.Name = "gb_anFiltrar"
        Me.gb_anFiltrar.Size = New System.Drawing.Size(351, 116)
        Me.gb_anFiltrar.TabIndex = 25
        Me.gb_anFiltrar.TabStop = False
        Me.gb_anFiltrar.Text = "Filtrar Analíticas"
        '
        'bt_anFiltrar
        '
        Me.bt_anFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_anFiltrar.ImageIndex = 0
        Me.bt_anFiltrar.Location = New System.Drawing.Point(203, 77)
        Me.bt_anFiltrar.Name = "bt_anFiltrar"
        Me.bt_anFiltrar.Size = New System.Drawing.Size(92, 33)
        Me.bt_anFiltrar.TabIndex = 7
        Me.bt_anFiltrar.Text = "Filtrar"
        Me.bt_anFiltrar.UseVisualStyleBackColor = True
        '
        'dtp_anHasta
        '
        Me.dtp_anHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_anHasta.Location = New System.Drawing.Point(249, 43)
        Me.dtp_anHasta.Name = "dtp_anHasta"
        Me.dtp_anHasta.Size = New System.Drawing.Size(85, 20)
        Me.dtp_anHasta.TabIndex = 6
        '
        'gb_anOrdenarpor
        '
        Me.gb_anOrdenarpor.Controls.Add(Me.rb_anImporte)
        Me.gb_anOrdenarpor.Controls.Add(Me.rb_anDescripcion)
        Me.gb_anOrdenarpor.Controls.Add(Me.rb_anFecha)
        Me.gb_anOrdenarpor.Controls.Add(Me.rb_anNumero)
        Me.gb_anOrdenarpor.Location = New System.Drawing.Point(13, 14)
        Me.gb_anOrdenarpor.Name = "gb_anOrdenarpor"
        Me.gb_anOrdenarpor.Size = New System.Drawing.Size(125, 94)
        Me.gb_anOrdenarpor.TabIndex = 0
        Me.gb_anOrdenarpor.TabStop = False
        Me.gb_anOrdenarpor.Text = "Ordenar por:"
        '
        'rb_anImporte
        '
        Me.rb_anImporte.AutoSize = True
        Me.rb_anImporte.Location = New System.Drawing.Point(21, 71)
        Me.rb_anImporte.Name = "rb_anImporte"
        Me.rb_anImporte.Size = New System.Drawing.Size(60, 17)
        Me.rb_anImporte.TabIndex = 3
        Me.rb_anImporte.TabStop = True
        Me.rb_anImporte.Text = "Importe"
        Me.rb_anImporte.UseVisualStyleBackColor = True
        '
        'rb_anDescripcion
        '
        Me.rb_anDescripcion.AutoSize = True
        Me.rb_anDescripcion.Location = New System.Drawing.Point(21, 54)
        Me.rb_anDescripcion.Name = "rb_anDescripcion"
        Me.rb_anDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.rb_anDescripcion.TabIndex = 2
        Me.rb_anDescripcion.TabStop = True
        Me.rb_anDescripcion.Text = "Descripción"
        Me.rb_anDescripcion.UseVisualStyleBackColor = True
        '
        'rb_anFecha
        '
        Me.rb_anFecha.AutoSize = True
        Me.rb_anFecha.Location = New System.Drawing.Point(21, 36)
        Me.rb_anFecha.Name = "rb_anFecha"
        Me.rb_anFecha.Size = New System.Drawing.Size(55, 17)
        Me.rb_anFecha.TabIndex = 1
        Me.rb_anFecha.TabStop = True
        Me.rb_anFecha.Text = "Fecha"
        Me.rb_anFecha.UseVisualStyleBackColor = True
        '
        'rb_anNumero
        '
        Me.rb_anNumero.AutoSize = True
        Me.rb_anNumero.Location = New System.Drawing.Point(21, 17)
        Me.rb_anNumero.Name = "rb_anNumero"
        Me.rb_anNumero.Size = New System.Drawing.Size(62, 17)
        Me.rb_anNumero.TabIndex = 0
        Me.rb_anNumero.TabStop = True
        Me.rb_anNumero.Text = "Número"
        Me.rb_anNumero.UseVisualStyleBackColor = True
        '
        'dtp_anDesde
        '
        Me.dtp_anDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_anDesde.Location = New System.Drawing.Point(147, 43)
        Me.dtp_anDesde.Name = "dtp_anDesde"
        Me.dtp_anDesde.Size = New System.Drawing.Size(86, 20)
        Me.dtp_anDesde.TabIndex = 4
        '
        'ANALITICASTableAdapter
        '
        Me.ANALITICASTableAdapter.ClearBeforeFill = True
        '
        'LINEASANALITICASBindingSource
        '
        Me.LINEASANALITICASBindingSource.DataMember = "LINEASANALITICAS"
        Me.LINEASANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'LINEASANALITICASTableAdapter
        '
        Me.LINEASANALITICASTableAdapter.ClearBeforeFill = True
        '
        'gb_Principales
        '
        Me.gb_Principales.Controls.Add(Me.tb_dpEdadhactual)
        Me.gb_Principales.Controls.Add(lb_dpEdadhlaboral)
        Me.gb_Principales.Controls.Add(Me.bt_Factura)
        Me.gb_Principales.Controls.Add(Me.tb_Nombre)
        Me.gb_Principales.Controls.Add(Me.tb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.tb_PrimerAp)
        Me.gb_Principales.Controls.Add(Me.dtp_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_Nombre)
        Me.gb_Principales.Controls.Add(Me.lb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.lb_PrimerAp)
        Me.gb_Principales.Location = New System.Drawing.Point(103, 29)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 41
        Me.gb_Principales.TabStop = False
        Me.gb_Principales.Visible = False
        '
        'tb_dpEdadhactual
        '
        Me.tb_dpEdadhactual.AcceptsReturn = True
        Me.tb_dpEdadhactual.Enabled = False
        Me.tb_dpEdadhactual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpEdadhactual.Location = New System.Drawing.Point(588, 22)
        Me.tb_dpEdadhactual.Name = "tb_dpEdadhactual"
        Me.tb_dpEdadhactual.ReadOnly = True
        Me.tb_dpEdadhactual.Size = New System.Drawing.Size(39, 20)
        Me.tb_dpEdadhactual.TabIndex = 36
        '
        'bt_Factura
        '
        Me.bt_Factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.Facturas
        Me.bt_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Factura.Location = New System.Drawing.Point(813, 51)
        Me.bt_Factura.Name = "bt_Factura"
        Me.bt_Factura.Size = New System.Drawing.Size(35, 29)
        Me.bt_Factura.TabIndex = 12
        Me.bt_Factura.UseVisualStyleBackColor = True
        '
        'tb_Nombre
        '
        Me.tb_Nombre.AcceptsReturn = True
        Me.tb_Nombre.BackColor = System.Drawing.SystemColors.Info
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Location = New System.Drawing.Point(319, 23)
        Me.tb_Nombre.MaxLength = 25
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.ReadOnly = True
        Me.tb_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.tb_Nombre.TabIndex = 9
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'tb_SegundoAp
        '
        Me.tb_SegundoAp.AcceptsReturn = True
        Me.tb_SegundoAp.BackColor = System.Drawing.Color.White
        Me.tb_SegundoAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_SegundoAp.Location = New System.Drawing.Point(171, 23)
        Me.tb_SegundoAp.MaxLength = 15
        Me.tb_SegundoAp.Name = "tb_SegundoAp"
        Me.tb_SegundoAp.ReadOnly = True
        Me.tb_SegundoAp.Size = New System.Drawing.Size(144, 20)
        Me.tb_SegundoAp.TabIndex = 8
        '
        'tb_PrimerAp
        '
        Me.tb_PrimerAp.AcceptsReturn = True
        Me.tb_PrimerAp.BackColor = System.Drawing.Color.White
        Me.tb_PrimerAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO1", True))
        Me.tb_PrimerAp.Location = New System.Drawing.Point(46, 23)
        Me.tb_PrimerAp.MaxLength = 15
        Me.tb_PrimerAp.Name = "tb_PrimerAp"
        Me.tb_PrimerAp.ReadOnly = True
        Me.tb_PrimerAp.Size = New System.Drawing.Size(121, 20)
        Me.tb_PrimerAp.TabIndex = 7
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "FECHAALTA", True))
        Me.dtp_FechaIngreso.Enabled = False
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(485, 23)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(94, 20)
        Me.dtp_FechaIngreso.TabIndex = 11
        Me.dtp_FechaIngreso.Value = New Date(2009, 6, 10, 0, 0, 0, 0)
        '
        'lb_FechaIngreso
        '
        Me.lb_FechaIngreso.AutoSize = True
        Me.lb_FechaIngreso.Location = New System.Drawing.Point(483, 9)
        Me.lb_FechaIngreso.Name = "lb_FechaIngreso"
        Me.lb_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lb_FechaIngreso.TabIndex = 4
        Me.lb_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Location = New System.Drawing.Point(318, 9)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lb_Nombre.TabIndex = 3
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_SegundoAp
        '
        Me.lb_SegundoAp.AutoSize = True
        Me.lb_SegundoAp.Location = New System.Drawing.Point(173, 8)
        Me.lb_SegundoAp.Name = "lb_SegundoAp"
        Me.lb_SegundoAp.Size = New System.Drawing.Size(90, 13)
        Me.lb_SegundoAp.TabIndex = 2
        Me.lb_SegundoAp.Text = "Segundo Apellido"
        '
        'lb_PrimerAp
        '
        Me.lb_PrimerAp.AutoSize = True
        Me.lb_PrimerAp.Location = New System.Drawing.Point(47, 8)
        Me.lb_PrimerAp.Name = "lb_PrimerAp"
        Me.lb_PrimerAp.Size = New System.Drawing.Size(76, 13)
        Me.lb_PrimerAp.TabIndex = 1
        Me.lb_PrimerAp.Text = "Primer Apellido"
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'form_analiticas_ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 538)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.dtg_anAnaliticas)
        Me.Controls.Add(Me.tb_anNotas)
        Me.Controls.Add(Me.lb_anNotas)
        Me.Controls.Add(Me.tb_anTotal)
        Me.Controls.Add(Me.lb_anTotal)
        Me.Controls.Add(Me.dtg_anConceptosanaliticas)
        Me.Controls.Add(Me.gb_anFiltrar)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.nv_anAnaliticas)
        Me.KeyPreview = True
        Me.Name = "form_analiticas_ex"
        Me.ShowInTaskbar = False
        Me.Text = "ANALÍTICAS-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.nv_anAnaliticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nv_anAnaliticas.ResumeLayout(False)
        Me.nv_anAnaliticas.PerformLayout()
        CType(Me.dtg_anAnaliticas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_anConceptosanaliticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_anFiltrar.ResumeLayout(False)
        Me.gb_anFiltrar.PerformLayout()
        Me.gb_anOrdenarpor.ResumeLayout(False)
        Me.gb_anOrdenarpor.PerformLayout()
        CType(Me.LINEASANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents nv_anAnaliticas As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditAnaliticas As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimirAnalitica As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtg_anAnaliticas As System.Windows.Forms.DataGridView
    Friend WithEvents tb_anNotas As ctrlTextboxAvanzado
    Friend WithEvents lb_anNotas As System.Windows.Forms.Label
    Friend WithEvents tb_anTotal As ctrlTextboxAvanzado
    Friend WithEvents lb_anTotal As System.Windows.Forms.Label
    Friend WithEvents dtg_anConceptosanaliticas As System.Windows.Forms.DataGridView
    Friend WithEvents gb_anFiltrar As System.Windows.Forms.GroupBox
    Friend WithEvents bt_anFiltrar As System.Windows.Forms.Button
    Friend WithEvents dtp_anHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_anOrdenarpor As System.Windows.Forms.GroupBox
    Friend WithEvents rb_anImporte As System.Windows.Forms.RadioButton
    Friend WithEvents rb_anDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_anFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rb_anNumero As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_anDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter
    Friend WithEvents LINEASANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASANALITICASTableAdapter
    Friend WithEvents gb_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dpEdadhactual As ctrlTextboxAvanzado
    Friend WithEvents bt_Factura As System.Windows.Forms.Button
    Friend WithEvents tb_Nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_SegundoAp As ctrlTextboxAvanzado
    Friend WithEvents tb_PrimerAp As ctrlTextboxAvanzado
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_SegundoAp As System.Windows.Forms.Label
    Friend WithEvents lb_PrimerAp As System.Windows.Forms.Label
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
End Class
