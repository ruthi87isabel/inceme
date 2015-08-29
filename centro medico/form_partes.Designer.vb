<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_partes
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
        Dim lb_paHasta As System.Windows.Forms.Label
        Dim lb_paDesde As System.Windows.Forms.Label
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_partes))
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.dtg_paPartes = New System.Windows.Forms.DataGridView
        Me.PARTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_paFiltrar = New System.Windows.Forms.Button
        Me.dtp_paHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_paDesde = New System.Windows.Forms.DateTimePicker
        Me.gb_paOrdenarpor = New System.Windows.Forms.GroupBox
        Me.rb_paTipo = New System.Windows.Forms.RadioButton
        Me.rb_paFecha = New System.Windows.Forms.RadioButton
        Me.nv_paPartes = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditPartes = New System.Windows.Forms.ToolStripButton
        Me.PARTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
        Me.gb_Principales = New System.Windows.Forms.GroupBox
        Me.tb_dpEdadhactual = New ctrlTextboxAvanzado
        Me.bt_Factura = New System.Windows.Forms.Button
        Me.tb_Nombre = New ctrlTextboxAvanzado
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_SegundoAp = New ctrlTextboxAvanzado
        Me.tb_PrimerAp = New ctrlTextboxAvanzado
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.lb_FechaIngreso = New System.Windows.Forms.Label
        Me.lb_Nombre = New System.Windows.Forms.Label
        Me.lb_SegundoAp = New System.Windows.Forms.Label
        Me.lb_PrimerAp = New System.Windows.Forms.Label
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.lb_teclas = New System.Windows.Forms.Label
        lb_paHasta = New System.Windows.Forms.Label
        lb_paDesde = New System.Windows.Forms.Label
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dtg_paPartes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_paOrdenarpor.SuspendLayout()
        CType(Me.nv_paPartes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nv_paPartes.SuspendLayout()
        Me.gb_Principales.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_paHasta
        '
        lb_paHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lb_paHasta.AutoSize = True
        lb_paHasta.Location = New System.Drawing.Point(731, 251)
        lb_paHasta.Name = "lb_paHasta"
        lb_paHasta.Size = New System.Drawing.Size(35, 13)
        lb_paHasta.TabIndex = 27
        lb_paHasta.Text = "Hasta"
        '
        'lb_paDesde
        '
        lb_paDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lb_paDesde.AutoSize = True
        lb_paDesde.Location = New System.Drawing.Point(731, 188)
        lb_paDesde.Name = "lb_paDesde"
        lb_paDesde.Size = New System.Drawing.Size(38, 13)
        lb_paDesde.TabIndex = 25
        lb_paDesde.Text = "Desde"
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
        'dtg_paPartes
        '
        Me.dtg_paPartes.AllowUserToAddRows = False
        Me.dtg_paPartes.AllowUserToDeleteRows = False
        Me.dtg_paPartes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_paPartes.BackgroundColor = System.Drawing.Color.White
        Me.dtg_paPartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_paPartes.Location = New System.Drawing.Point(12, 79)
        Me.dtg_paPartes.MultiSelect = False
        Me.dtg_paPartes.Name = "dtg_paPartes"
        Me.dtg_paPartes.ReadOnly = True
        Me.dtg_paPartes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_paPartes.Size = New System.Drawing.Size(692, 354)
        Me.dtg_paPartes.TabIndex = 30
        '
        'PARTESBindingSource
        '
        Me.PARTESBindingSource.DataMember = "PARTES"
        Me.PARTESBindingSource.DataSource = Me.CMDataSet
        '
        'bt_paFiltrar
        '
        Me.bt_paFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_paFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_paFiltrar.ImageIndex = 0
        Me.bt_paFiltrar.Location = New System.Drawing.Point(734, 330)
        Me.bt_paFiltrar.Name = "bt_paFiltrar"
        Me.bt_paFiltrar.Size = New System.Drawing.Size(104, 31)
        Me.bt_paFiltrar.TabIndex = 29
        Me.bt_paFiltrar.Text = "Filtrar"
        Me.bt_paFiltrar.UseVisualStyleBackColor = True
        '
        'dtp_paHasta
        '
        Me.dtp_paHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_paHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_paHasta.Location = New System.Drawing.Point(734, 267)
        Me.dtp_paHasta.Name = "dtp_paHasta"
        Me.dtp_paHasta.Size = New System.Drawing.Size(85, 20)
        Me.dtp_paHasta.TabIndex = 28
        Me.dtp_paHasta.Value = New Date(2008, 12, 21, 0, 0, 0, 0)
        '
        'dtp_paDesde
        '
        Me.dtp_paDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_paDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_paDesde.Location = New System.Drawing.Point(734, 204)
        Me.dtp_paDesde.Name = "dtp_paDesde"
        Me.dtp_paDesde.Size = New System.Drawing.Size(85, 20)
        Me.dtp_paDesde.TabIndex = 26
        Me.dtp_paDesde.Value = New Date(2008, 12, 21, 0, 0, 0, 0)
        '
        'gb_paOrdenarpor
        '
        Me.gb_paOrdenarpor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_paOrdenarpor.BackColor = System.Drawing.Color.GhostWhite
        Me.gb_paOrdenarpor.Controls.Add(Me.rb_paTipo)
        Me.gb_paOrdenarpor.Controls.Add(Me.rb_paFecha)
        Me.gb_paOrdenarpor.Location = New System.Drawing.Point(720, 51)
        Me.gb_paOrdenarpor.Name = "gb_paOrdenarpor"
        Me.gb_paOrdenarpor.Size = New System.Drawing.Size(133, 111)
        Me.gb_paOrdenarpor.TabIndex = 24
        Me.gb_paOrdenarpor.TabStop = False
        Me.gb_paOrdenarpor.Text = "Ordenar por:"
        '
        'rb_paTipo
        '
        Me.rb_paTipo.AutoSize = True
        Me.rb_paTipo.Location = New System.Drawing.Point(18, 69)
        Me.rb_paTipo.Name = "rb_paTipo"
        Me.rb_paTipo.Size = New System.Drawing.Size(46, 17)
        Me.rb_paTipo.TabIndex = 1
        Me.rb_paTipo.Text = "Tipo"
        Me.rb_paTipo.UseVisualStyleBackColor = True
        '
        'rb_paFecha
        '
        Me.rb_paFecha.AutoSize = True
        Me.rb_paFecha.Location = New System.Drawing.Point(18, 32)
        Me.rb_paFecha.Name = "rb_paFecha"
        Me.rb_paFecha.Size = New System.Drawing.Size(55, 17)
        Me.rb_paFecha.TabIndex = 0
        Me.rb_paFecha.Text = "Fecha"
        Me.rb_paFecha.UseVisualStyleBackColor = True
        '
        'nv_paPartes
        '
        Me.nv_paPartes.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.nv_paPartes.AllowItemReorder = True
        Me.nv_paPartes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nv_paPartes.AutoSize = False
        Me.nv_paPartes.BindingSource = Me.PARTESBindingSource
        Me.nv_paPartes.CountItem = Me.BindingNavigatorCountItem2
        Me.nv_paPartes.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.nv_paPartes.Dock = System.Windows.Forms.DockStyle.None
        Me.nv_paPartes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorEditPartes, Me.BindingNavigatorDeleteItem2, Me.BindingNavigatorAddNewItem2})
        Me.nv_paPartes.Location = New System.Drawing.Point(1, 438)
        Me.nv_paPartes.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.nv_paPartes.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.nv_paPartes.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.nv_paPartes.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.nv_paPartes.Name = "nv_paPartes"
        Me.nv_paPartes.PositionItem = Me.BindingNavigatorPositionItem2
        Me.nv_paPartes.Size = New System.Drawing.Size(703, 39)
        Me.nv_paPartes.TabIndex = 31
        Me.nv_paPartes.Visible = False
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(62, 36)
        Me.BindingNavigatorAddNewItem2.Text = "Añadir"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 36)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(59, 36)
        Me.BindingNavigatorDeleteItem2.Text = "Borrar"
        Me.BindingNavigatorDeleteItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 36)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 36)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 36)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 36)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorEditPartes
        '
        Me.BindingNavigatorEditPartes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorEditPartes.Image = Global.centro_medico.My.Resources.Resources.folderopen
        Me.BindingNavigatorEditPartes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditPartes.Name = "BindingNavigatorEditPartes"
        Me.BindingNavigatorEditPartes.Size = New System.Drawing.Size(57, 36)
        Me.BindingNavigatorEditPartes.Text = "Editar"
        '
        'PARTESTableAdapter
        '
        Me.PARTESTableAdapter.ClearBeforeFill = True
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
        Me.gb_Principales.Location = New System.Drawing.Point(12, 26)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(685, 47)
        Me.gb_Principales.TabIndex = 40
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
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'tb_SegundoAp
        '
        Me.tb_SegundoAp.BackColor = System.Drawing.Color.White
        Me.tb_SegundoAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_SegundoAp.Location = New System.Drawing.Point(143, 22)
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
        Me.tb_PrimerAp.Location = New System.Drawing.Point(6, 23)
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
        Me.lb_SegundoAp.Location = New System.Drawing.Point(145, 7)
        Me.lb_SegundoAp.Name = "lb_SegundoAp"
        Me.lb_SegundoAp.Size = New System.Drawing.Size(90, 13)
        Me.lb_SegundoAp.TabIndex = 2
        Me.lb_SegundoAp.Text = "Segundo Apellido"
        '
        'lb_PrimerAp
        '
        Me.lb_PrimerAp.AutoSize = True
        Me.lb_PrimerAp.Location = New System.Drawing.Point(7, 8)
        Me.lb_PrimerAp.Name = "lb_PrimerAp"
        Me.lb_PrimerAp.Size = New System.Drawing.Size(76, 13)
        Me.lb_PrimerAp.TabIndex = 1
        Me.lb_PrimerAp.Text = "Primer Apellido"
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(24, 481)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(401, 13)
        Me.lb_teclas.TabIndex = 41
        Me.lb_teclas.Text = "Alt A=Añadir; Alt B=Borrar; Alt E=Editar; Alt F=Filtrar; Alt+G=Guardar; Alt+C=Can" & _
            "celar"
        '
        'form_partes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 498)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.dtg_paPartes)
        Me.Controls.Add(Me.bt_paFiltrar)
        Me.Controls.Add(lb_paHasta)
        Me.Controls.Add(Me.dtp_paHasta)
        Me.Controls.Add(lb_paDesde)
        Me.Controls.Add(Me.dtp_paDesde)
        Me.Controls.Add(Me.gb_paOrdenarpor)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.nv_paPartes)
        Me.KeyPreview = True
        Me.Name = "form_partes"
        Me.ShowInTaskbar = False
        Me.Text = "PARTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dtg_paPartes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_paOrdenarpor.ResumeLayout(False)
        Me.gb_paOrdenarpor.PerformLayout()
        CType(Me.nv_paPartes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nv_paPartes.ResumeLayout(False)
        Me.nv_paPartes.PerformLayout()
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
    Friend WithEvents dtg_paPartes As System.Windows.Forms.DataGridView
    Friend WithEvents bt_paFiltrar As System.Windows.Forms.Button
    Friend WithEvents dtp_paHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_paOrdenarpor As System.Windows.Forms.GroupBox
    Friend WithEvents rb_paTipo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paFecha As System.Windows.Forms.RadioButton
    Friend WithEvents nv_paPartes As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditPartes As System.Windows.Forms.ToolStripButton
    Friend WithEvents PARTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARTESTableAdapter As centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
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
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents dtp_paDesde As System.Windows.Forms.DateTimePicker
End Class
