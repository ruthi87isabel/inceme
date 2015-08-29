<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_derivaciones_ex
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
        Me.components = New System.ComponentModel.Container
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_derivaciones_ex))
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.dtg_derDerivaciones = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lb_hasta = New System.Windows.Forms.Label
        Me.lb_desde = New System.Windows.Forms.Label
        Me.bt_derFiltrar = New System.Windows.Forms.Button
        Me.dtp_derHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_derDesde = New System.Windows.Forms.DateTimePicker
        Me.nv_derDerivaciones = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem9 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator27 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem9 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator28 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem9 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator29 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditDerivaciones = New System.Windows.Forms.ToolStripButton
        Me.gb_Principales = New System.Windows.Forms.GroupBox
        Me.tb_dpEdadhactual = New ctrlTextboxAvanzado
        Me.bt_Factura = New System.Windows.Forms.Button
        Me.tb_Nombre = New ctrlTextboxAvanzado
        Me.tb_SegundoAp = New ctrlTextboxAvanzado
        Me.tb_PrimerAp = New ctrlTextboxAvanzado
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.lb_FechaIngreso = New System.Windows.Forms.Label
        Me.lb_Nombre = New System.Windows.Forms.Label
        Me.lb_SegundoAp = New System.Windows.Forms.Label
        Me.lb_PrimerAp = New System.Windows.Forms.Label
        Me.lb_teclas = New System.Windows.Forms.Label
        Me.DERIVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DERIVACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_derDerivaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nv_derDerivaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nv_derDerivaciones.SuspendLayout()
        Me.gb_Principales.SuspendLayout()
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'dtg_derDerivaciones
        '
        Me.dtg_derDerivaciones.AllowUserToAddRows = False
        Me.dtg_derDerivaciones.AllowUserToDeleteRows = False
        Me.dtg_derDerivaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_derDerivaciones.BackgroundColor = System.Drawing.Color.White
        Me.dtg_derDerivaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_derDerivaciones.Location = New System.Drawing.Point(7, 150)
        Me.dtg_derDerivaciones.MultiSelect = False
        Me.dtg_derDerivaciones.Name = "dtg_derDerivaciones"
        Me.dtg_derDerivaciones.ReadOnly = True
        Me.dtg_derDerivaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_derDerivaciones.Size = New System.Drawing.Size(836, 250)
        Me.dtg_derDerivaciones.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.lb_hasta)
        Me.GroupBox1.Controls.Add(Me.lb_desde)
        Me.GroupBox1.Controls.Add(Me.bt_derFiltrar)
        Me.GroupBox1.Controls.Add(Me.dtp_derHasta)
        Me.GroupBox1.Controls.Add(Me.dtp_derDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 64)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'lb_hasta
        '
        Me.lb_hasta.AutoSize = True
        Me.lb_hasta.Location = New System.Drawing.Point(177, 15)
        Me.lb_hasta.Name = "lb_hasta"
        Me.lb_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lb_hasta.TabIndex = 4
        Me.lb_hasta.Text = "Hasta"
        '
        'lb_desde
        '
        Me.lb_desde.AutoSize = True
        Me.lb_desde.Location = New System.Drawing.Point(17, 15)
        Me.lb_desde.Name = "lb_desde"
        Me.lb_desde.Size = New System.Drawing.Size(38, 13)
        Me.lb_desde.TabIndex = 3
        Me.lb_desde.Text = "Desde"
        '
        'bt_derFiltrar
        '
        Me.bt_derFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_derFiltrar.ImageIndex = 0
        Me.bt_derFiltrar.Location = New System.Drawing.Point(345, 22)
        Me.bt_derFiltrar.Name = "bt_derFiltrar"
        Me.bt_derFiltrar.Size = New System.Drawing.Size(108, 31)
        Me.bt_derFiltrar.TabIndex = 2
        Me.bt_derFiltrar.Text = "Filtrar"
        Me.bt_derFiltrar.UseVisualStyleBackColor = True
        '
        'dtp_derHasta
        '
        Me.dtp_derHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_derHasta.Location = New System.Drawing.Point(178, 34)
        Me.dtp_derHasta.Name = "dtp_derHasta"
        Me.dtp_derHasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_derHasta.TabIndex = 1
        '
        'dtp_derDesde
        '
        Me.dtp_derDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_derDesde.Location = New System.Drawing.Point(20, 34)
        Me.dtp_derDesde.Name = "dtp_derDesde"
        Me.dtp_derDesde.Size = New System.Drawing.Size(97, 20)
        Me.dtp_derDesde.TabIndex = 0
        '
        'nv_derDerivaciones
        '
        Me.nv_derDerivaciones.AddNewItem = Me.BindingNavigatorAddNewItem9
        Me.nv_derDerivaciones.AllowItemReorder = True
        Me.nv_derDerivaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nv_derDerivaciones.AutoSize = False
        Me.nv_derDerivaciones.CountItem = Me.BindingNavigatorCountItem9
        Me.nv_derDerivaciones.DeleteItem = Me.BindingNavigatorDeleteItem9
        Me.nv_derDerivaciones.Dock = System.Windows.Forms.DockStyle.None
        Me.nv_derDerivaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem9, Me.BindingNavigatorMovePreviousItem9, Me.BindingNavigatorSeparator27, Me.BindingNavigatorPositionItem9, Me.BindingNavigatorCountItem9, Me.BindingNavigatorSeparator28, Me.BindingNavigatorMoveNextItem9, Me.BindingNavigatorMoveLastItem9, Me.BindingNavigatorSeparator29, Me.BindingNavigatorEditDerivaciones, Me.BindingNavigatorDeleteItem9, Me.BindingNavigatorAddNewItem9})
        Me.nv_derDerivaciones.Location = New System.Drawing.Point(7, 403)
        Me.nv_derDerivaciones.MoveFirstItem = Me.BindingNavigatorMoveFirstItem9
        Me.nv_derDerivaciones.MoveLastItem = Me.BindingNavigatorMoveLastItem9
        Me.nv_derDerivaciones.MoveNextItem = Me.BindingNavigatorMoveNextItem9
        Me.nv_derDerivaciones.MovePreviousItem = Me.BindingNavigatorMovePreviousItem9
        Me.nv_derDerivaciones.Name = "nv_derDerivaciones"
        Me.nv_derDerivaciones.PositionItem = Me.BindingNavigatorPositionItem9
        Me.nv_derDerivaciones.Size = New System.Drawing.Size(836, 33)
        Me.nv_derDerivaciones.TabIndex = 32
        Me.nv_derDerivaciones.Text = "BindingNavigator1"
        Me.nv_derDerivaciones.Visible = False
        '
        'BindingNavigatorAddNewItem9
        '
        Me.BindingNavigatorAddNewItem9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem9.Image = CType(resources.GetObject("BindingNavigatorAddNewItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem9.Name = "BindingNavigatorAddNewItem9"
        Me.BindingNavigatorAddNewItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem9.Size = New System.Drawing.Size(62, 30)
        Me.BindingNavigatorAddNewItem9.Text = "Añadir"
        '
        'BindingNavigatorCountItem9
        '
        Me.BindingNavigatorCountItem9.Name = "BindingNavigatorCountItem9"
        Me.BindingNavigatorCountItem9.Size = New System.Drawing.Size(35, 30)
        Me.BindingNavigatorCountItem9.Text = "of {0}"
        Me.BindingNavigatorCountItem9.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem9
        '
        Me.BindingNavigatorDeleteItem9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem9.Image = CType(resources.GetObject("BindingNavigatorDeleteItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem9.Name = "BindingNavigatorDeleteItem9"
        Me.BindingNavigatorDeleteItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem9.Size = New System.Drawing.Size(59, 30)
        Me.BindingNavigatorDeleteItem9.Text = "Borrar"
        '
        'BindingNavigatorMoveFirstItem9
        '
        Me.BindingNavigatorMoveFirstItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem9.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem9.Name = "BindingNavigatorMoveFirstItem9"
        Me.BindingNavigatorMoveFirstItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem9.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveFirstItem9.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem9
        '
        Me.BindingNavigatorMovePreviousItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem9.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem9.Name = "BindingNavigatorMovePreviousItem9"
        Me.BindingNavigatorMovePreviousItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem9.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMovePreviousItem9.Text = "Move previous"
        '
        'BindingNavigatorSeparator27
        '
        Me.BindingNavigatorSeparator27.Name = "BindingNavigatorSeparator27"
        Me.BindingNavigatorSeparator27.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem9
        '
        Me.BindingNavigatorPositionItem9.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem9.AutoSize = False
        Me.BindingNavigatorPositionItem9.Name = "BindingNavigatorPositionItem9"
        Me.BindingNavigatorPositionItem9.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem9.Text = "0"
        Me.BindingNavigatorPositionItem9.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator28
        '
        Me.BindingNavigatorSeparator28.Name = "BindingNavigatorSeparator28"
        Me.BindingNavigatorSeparator28.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem9
        '
        Me.BindingNavigatorMoveNextItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem9.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem9.Name = "BindingNavigatorMoveNextItem9"
        Me.BindingNavigatorMoveNextItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem9.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveNextItem9.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem9
        '
        Me.BindingNavigatorMoveLastItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem9.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem9.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem9.Name = "BindingNavigatorMoveLastItem9"
        Me.BindingNavigatorMoveLastItem9.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem9.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveLastItem9.Text = "Move last"
        '
        'BindingNavigatorSeparator29
        '
        Me.BindingNavigatorSeparator29.Name = "BindingNavigatorSeparator29"
        Me.BindingNavigatorSeparator29.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorEditDerivaciones
        '
        Me.BindingNavigatorEditDerivaciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorEditDerivaciones.Image = Global.centro_medico.My.Resources.Resources.folderopen
        Me.BindingNavigatorEditDerivaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditDerivaciones.Name = "BindingNavigatorEditDerivaciones"
        Me.BindingNavigatorEditDerivaciones.Size = New System.Drawing.Size(57, 30)
        Me.BindingNavigatorEditDerivaciones.Text = "Editar"
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
        Me.gb_Principales.Location = New System.Drawing.Point(100, 28)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 41
        Me.gb_Principales.TabStop = False
        Me.gb_Principales.Visible = False
        '
        'tb_dpEdadhactual
        '
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
        Me.tb_Nombre.BackColor = System.Drawing.SystemColors.Info
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Location = New System.Drawing.Point(319, 23)
        Me.tb_Nombre.MaxLength = 25
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.ReadOnly = True
        Me.tb_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.tb_Nombre.TabIndex = 9
        '
        'tb_SegundoAp
        '
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
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(54, 440)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(401, 13)
        Me.lb_teclas.TabIndex = 42
        Me.lb_teclas.Text = "Alt A=Añadir; Alt B=Borrar; Alt E=Editar; Alt F=Filtrar; Alt+G=Guardar; Alt+C=Can" & _
            "celar"
        '
        'DERIVACIONESBindingSource
        '
        Me.DERIVACIONESBindingSource.DataMember = "DERIVACIONES"
        Me.DERIVACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'DERIVACIONESTableAdapter
        '
        Me.DERIVACIONESTableAdapter.ClearBeforeFill = True
        '
        'form_derivaciones_ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 457)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.dtg_derDerivaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.nv_derDerivaciones)
        Me.KeyPreview = True
        Me.Name = "form_derivaciones_ex"
        Me.ShowInTaskbar = False
        Me.Text = "DERIVACIONES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_derDerivaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nv_derDerivaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nv_derDerivaciones.ResumeLayout(False)
        Me.nv_derDerivaciones.PerformLayout()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents dtg_derDerivaciones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_hasta As System.Windows.Forms.Label
    Friend WithEvents lb_desde As System.Windows.Forms.Label
    Friend WithEvents bt_derFiltrar As System.Windows.Forms.Button
    Friend WithEvents dtp_derHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_derDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents nv_derDerivaciones As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem9 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator29 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditDerivaciones As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents DERIVACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
End Class
