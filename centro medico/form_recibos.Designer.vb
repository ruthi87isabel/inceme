<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_recibos_ex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_recibos_ex))
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.lb_teclas = New System.Windows.Forms.Label
        Me.dtg_recRecibos = New System.Windows.Forms.DataGridView
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gb_recFiltrar = New System.Windows.Forms.GroupBox
        Me.bt_recFiltrar = New System.Windows.Forms.Button
        Me.dtp_recHasta = New System.Windows.Forms.DateTimePicker
        Me.lb_recHasta = New System.Windows.Forms.Label
        Me.dtp_recDesde = New System.Windows.Forms.DateTimePicker
        Me.lb_recDesde = New System.Windows.Forms.Label
        Me.gb_recOrdenarpor = New System.Windows.Forms.GroupBox
        Me.rb_recImporte = New System.Windows.Forms.RadioButton
        Me.rb_recFVencimiento = New System.Windows.Forms.RadioButton
        Me.rb_recCobrado = New System.Windows.Forms.RadioButton
        Me.rb_recFEmision = New System.Windows.Forms.RadioButton
        Me.rb_recNumero = New System.Windows.Forms.RadioButton
        Me.gb_recEstado = New System.Windows.Forms.GroupBox
        Me.rb_recImpagados = New System.Windows.Forms.RadioButton
        Me.rb_recPagados = New System.Windows.Forms.RadioButton
        Me.rb_recTodas = New System.Windows.Forms.RadioButton
        Me.nv_recRecibos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem8 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator24 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem8 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator25 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem8 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator26 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditRecibos = New System.Windows.Forms.ToolStripButton
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
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
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dtg_recRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_recFiltrar.SuspendLayout()
        Me.gb_recOrdenarpor.SuspendLayout()
        Me.gb_recEstado.SuspendLayout()
        CType(Me.nv_recRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nv_recRecibos.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
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
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(35, 477)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(401, 13)
        Me.lb_teclas.TabIndex = 23
        Me.lb_teclas.Text = "Alt A=Añadir; Alt B=Borrar; Alt E=Editar; Alt F=Filtrar; Alt+G=Guardar; Alt+C=Can" & _
            "celar"
        '
        'dtg_recRecibos
        '
        Me.dtg_recRecibos.AllowUserToAddRows = False
        Me.dtg_recRecibos.AllowUserToDeleteRows = False
        Me.dtg_recRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_recRecibos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_recRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_recRecibos.Location = New System.Drawing.Point(2, 81)
        Me.dtg_recRecibos.MultiSelect = False
        Me.dtg_recRecibos.Name = "dtg_recRecibos"
        Me.dtg_recRecibos.ReadOnly = True
        Me.dtg_recRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_recRecibos.Size = New System.Drawing.Size(580, 353)
        Me.dtg_recRecibos.TabIndex = 24
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'gb_recFiltrar
        '
        Me.gb_recFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_recFiltrar.Controls.Add(Me.bt_recFiltrar)
        Me.gb_recFiltrar.Controls.Add(Me.dtp_recHasta)
        Me.gb_recFiltrar.Controls.Add(Me.lb_recHasta)
        Me.gb_recFiltrar.Controls.Add(Me.dtp_recDesde)
        Me.gb_recFiltrar.Controls.Add(Me.lb_recDesde)
        Me.gb_recFiltrar.Controls.Add(Me.gb_recOrdenarpor)
        Me.gb_recFiltrar.Controls.Add(Me.gb_recEstado)
        Me.gb_recFiltrar.Location = New System.Drawing.Point(595, 78)
        Me.gb_recFiltrar.Name = "gb_recFiltrar"
        Me.gb_recFiltrar.Size = New System.Drawing.Size(257, 243)
        Me.gb_recFiltrar.TabIndex = 25
        Me.gb_recFiltrar.TabStop = False
        Me.gb_recFiltrar.Text = "Filtrar Recibos"
        '
        'bt_recFiltrar
        '
        Me.bt_recFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_recFiltrar.ImageIndex = 0
        Me.bt_recFiltrar.Location = New System.Drawing.Point(145, 181)
        Me.bt_recFiltrar.Name = "bt_recFiltrar"
        Me.bt_recFiltrar.Size = New System.Drawing.Size(94, 33)
        Me.bt_recFiltrar.TabIndex = 6
        Me.bt_recFiltrar.Text = "Filtrar"
        Me.bt_recFiltrar.UseVisualStyleBackColor = True
        '
        'dtp_recHasta
        '
        Me.dtp_recHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_recHasta.Location = New System.Drawing.Point(136, 127)
        Me.dtp_recHasta.Name = "dtp_recHasta"
        Me.dtp_recHasta.Size = New System.Drawing.Size(103, 20)
        Me.dtp_recHasta.TabIndex = 5
        '
        'lb_recHasta
        '
        Me.lb_recHasta.AutoSize = True
        Me.lb_recHasta.Location = New System.Drawing.Point(133, 109)
        Me.lb_recHasta.Name = "lb_recHasta"
        Me.lb_recHasta.Size = New System.Drawing.Size(35, 13)
        Me.lb_recHasta.TabIndex = 4
        Me.lb_recHasta.Text = "Hasta"
        '
        'dtp_recDesde
        '
        Me.dtp_recDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_recDesde.Location = New System.Drawing.Point(136, 63)
        Me.dtp_recDesde.Name = "dtp_recDesde"
        Me.dtp_recDesde.Size = New System.Drawing.Size(103, 20)
        Me.dtp_recDesde.TabIndex = 3
        '
        'lb_recDesde
        '
        Me.lb_recDesde.AutoSize = True
        Me.lb_recDesde.Location = New System.Drawing.Point(133, 45)
        Me.lb_recDesde.Name = "lb_recDesde"
        Me.lb_recDesde.Size = New System.Drawing.Size(38, 13)
        Me.lb_recDesde.TabIndex = 2
        Me.lb_recDesde.Text = "Desde"
        '
        'gb_recOrdenarpor
        '
        Me.gb_recOrdenarpor.Controls.Add(Me.rb_recImporte)
        Me.gb_recOrdenarpor.Controls.Add(Me.rb_recFVencimiento)
        Me.gb_recOrdenarpor.Controls.Add(Me.rb_recCobrado)
        Me.gb_recOrdenarpor.Controls.Add(Me.rb_recFEmision)
        Me.gb_recOrdenarpor.Controls.Add(Me.rb_recNumero)
        Me.gb_recOrdenarpor.Location = New System.Drawing.Point(18, 109)
        Me.gb_recOrdenarpor.Name = "gb_recOrdenarpor"
        Me.gb_recOrdenarpor.Size = New System.Drawing.Size(108, 105)
        Me.gb_recOrdenarpor.TabIndex = 1
        Me.gb_recOrdenarpor.TabStop = False
        Me.gb_recOrdenarpor.Text = "Ordenar por:"
        '
        'rb_recImporte
        '
        Me.rb_recImporte.AutoSize = True
        Me.rb_recImporte.Location = New System.Drawing.Point(7, 64)
        Me.rb_recImporte.Name = "rb_recImporte"
        Me.rb_recImporte.Size = New System.Drawing.Size(60, 17)
        Me.rb_recImporte.TabIndex = 4
        Me.rb_recImporte.Text = "Importe"
        Me.rb_recImporte.UseVisualStyleBackColor = True
        '
        'rb_recFVencimiento
        '
        Me.rb_recFVencimiento.AutoSize = True
        Me.rb_recFVencimiento.Location = New System.Drawing.Point(7, 49)
        Me.rb_recFVencimiento.Name = "rb_recFVencimiento"
        Me.rb_recFVencimiento.Size = New System.Drawing.Size(95, 17)
        Me.rb_recFVencimiento.TabIndex = 3
        Me.rb_recFVencimiento.Text = "F. Vencimiento"
        Me.rb_recFVencimiento.UseVisualStyleBackColor = True
        '
        'rb_recCobrado
        '
        Me.rb_recCobrado.AutoSize = True
        Me.rb_recCobrado.Location = New System.Drawing.Point(7, 79)
        Me.rb_recCobrado.Name = "rb_recCobrado"
        Me.rb_recCobrado.Size = New System.Drawing.Size(65, 17)
        Me.rb_recCobrado.TabIndex = 5
        Me.rb_recCobrado.Text = "Cobrado"
        Me.rb_recCobrado.UseVisualStyleBackColor = True
        '
        'rb_recFEmision
        '
        Me.rb_recFEmision.AutoSize = True
        Me.rb_recFEmision.Location = New System.Drawing.Point(7, 34)
        Me.rb_recFEmision.Name = "rb_recFEmision"
        Me.rb_recFEmision.Size = New System.Drawing.Size(73, 17)
        Me.rb_recFEmision.TabIndex = 2
        Me.rb_recFEmision.Text = "F. Emisión"
        Me.rb_recFEmision.UseVisualStyleBackColor = True
        '
        'rb_recNumero
        '
        Me.rb_recNumero.AutoSize = True
        Me.rb_recNumero.Location = New System.Drawing.Point(7, 19)
        Me.rb_recNumero.Name = "rb_recNumero"
        Me.rb_recNumero.Size = New System.Drawing.Size(62, 17)
        Me.rb_recNumero.TabIndex = 1
        Me.rb_recNumero.Text = "Número"
        Me.rb_recNumero.UseVisualStyleBackColor = True
        '
        'gb_recEstado
        '
        Me.gb_recEstado.Controls.Add(Me.rb_recImpagados)
        Me.gb_recEstado.Controls.Add(Me.rb_recPagados)
        Me.gb_recEstado.Controls.Add(Me.rb_recTodas)
        Me.gb_recEstado.Location = New System.Drawing.Point(18, 26)
        Me.gb_recEstado.Name = "gb_recEstado"
        Me.gb_recEstado.Size = New System.Drawing.Size(108, 77)
        Me.gb_recEstado.TabIndex = 0
        Me.gb_recEstado.TabStop = False
        Me.gb_recEstado.Text = "Estado:"
        '
        'rb_recImpagados
        '
        Me.rb_recImpagados.AutoSize = True
        Me.rb_recImpagados.Location = New System.Drawing.Point(6, 54)
        Me.rb_recImpagados.Name = "rb_recImpagados"
        Me.rb_recImpagados.Size = New System.Drawing.Size(77, 17)
        Me.rb_recImpagados.TabIndex = 2
        Me.rb_recImpagados.Text = "Impagados"
        Me.rb_recImpagados.UseVisualStyleBackColor = True
        '
        'rb_recPagados
        '
        Me.rb_recPagados.AutoSize = True
        Me.rb_recPagados.Location = New System.Drawing.Point(6, 37)
        Me.rb_recPagados.Name = "rb_recPagados"
        Me.rb_recPagados.Size = New System.Drawing.Size(67, 17)
        Me.rb_recPagados.TabIndex = 1
        Me.rb_recPagados.Text = "Pagados"
        Me.rb_recPagados.UseVisualStyleBackColor = True
        '
        'rb_recTodas
        '
        Me.rb_recTodas.AutoSize = True
        Me.rb_recTodas.Location = New System.Drawing.Point(6, 19)
        Me.rb_recTodas.Name = "rb_recTodas"
        Me.rb_recTodas.Size = New System.Drawing.Size(55, 17)
        Me.rb_recTodas.TabIndex = 0
        Me.rb_recTodas.Text = "Todas"
        Me.rb_recTodas.UseVisualStyleBackColor = True
        '
        'nv_recRecibos
        '
        Me.nv_recRecibos.AddNewItem = Me.BindingNavigatorAddNewItem8
        Me.nv_recRecibos.AllowItemReorder = True
        Me.nv_recRecibos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nv_recRecibos.AutoSize = False
        Me.nv_recRecibos.CountItem = Me.BindingNavigatorCountItem8
        Me.nv_recRecibos.DeleteItem = Me.BindingNavigatorDeleteItem8
        Me.nv_recRecibos.Dock = System.Windows.Forms.DockStyle.None
        Me.nv_recRecibos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem8, Me.BindingNavigatorMovePreviousItem8, Me.BindingNavigatorSeparator24, Me.BindingNavigatorPositionItem8, Me.BindingNavigatorCountItem8, Me.BindingNavigatorSeparator25, Me.BindingNavigatorMoveNextItem8, Me.BindingNavigatorMoveLastItem8, Me.BindingNavigatorSeparator26, Me.BindingNavigatorEditRecibos, Me.BindingNavigatorDeleteItem8, Me.BindingNavigatorAddNewItem8})
        Me.nv_recRecibos.Location = New System.Drawing.Point(2, 439)
        Me.nv_recRecibos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem8
        Me.nv_recRecibos.MoveLastItem = Me.BindingNavigatorMoveLastItem8
        Me.nv_recRecibos.MoveNextItem = Me.BindingNavigatorMoveNextItem8
        Me.nv_recRecibos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem8
        Me.nv_recRecibos.Name = "nv_recRecibos"
        Me.nv_recRecibos.PositionItem = Me.BindingNavigatorPositionItem8
        Me.nv_recRecibos.Size = New System.Drawing.Size(583, 38)
        Me.nv_recRecibos.TabIndex = 26
        Me.nv_recRecibos.Text = "BindingNavigator2"
        Me.nv_recRecibos.Visible = False
        '
        'BindingNavigatorAddNewItem8
        '
        Me.BindingNavigatorAddNewItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem8.Image = CType(resources.GetObject("BindingNavigatorAddNewItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem8.Name = "BindingNavigatorAddNewItem8"
        Me.BindingNavigatorAddNewItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem8.Size = New System.Drawing.Size(62, 35)
        Me.BindingNavigatorAddNewItem8.Text = "Añadir"
        '
        'BindingNavigatorCountItem8
        '
        Me.BindingNavigatorCountItem8.Name = "BindingNavigatorCountItem8"
        Me.BindingNavigatorCountItem8.Size = New System.Drawing.Size(35, 35)
        Me.BindingNavigatorCountItem8.Text = "of {0}"
        Me.BindingNavigatorCountItem8.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem8
        '
        Me.BindingNavigatorDeleteItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem8.Image = CType(resources.GetObject("BindingNavigatorDeleteItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem8.Name = "BindingNavigatorDeleteItem8"
        Me.BindingNavigatorDeleteItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem8.Size = New System.Drawing.Size(59, 35)
        Me.BindingNavigatorDeleteItem8.Text = "Borrar"
        '
        'BindingNavigatorMoveFirstItem8
        '
        Me.BindingNavigatorMoveFirstItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem8.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem8.Name = "BindingNavigatorMoveFirstItem8"
        Me.BindingNavigatorMoveFirstItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem8.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveFirstItem8.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem8
        '
        Me.BindingNavigatorMovePreviousItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem8.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem8.Name = "BindingNavigatorMovePreviousItem8"
        Me.BindingNavigatorMovePreviousItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem8.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMovePreviousItem8.Text = "Move previous"
        '
        'BindingNavigatorSeparator24
        '
        Me.BindingNavigatorSeparator24.Name = "BindingNavigatorSeparator24"
        Me.BindingNavigatorSeparator24.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem8
        '
        Me.BindingNavigatorPositionItem8.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem8.AutoSize = False
        Me.BindingNavigatorPositionItem8.Name = "BindingNavigatorPositionItem8"
        Me.BindingNavigatorPositionItem8.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem8.Text = "0"
        Me.BindingNavigatorPositionItem8.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator25
        '
        Me.BindingNavigatorSeparator25.Name = "BindingNavigatorSeparator25"
        Me.BindingNavigatorSeparator25.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem8
        '
        Me.BindingNavigatorMoveNextItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem8.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem8.Name = "BindingNavigatorMoveNextItem8"
        Me.BindingNavigatorMoveNextItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem8.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveNextItem8.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem8
        '
        Me.BindingNavigatorMoveLastItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem8.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem8.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem8.Name = "BindingNavigatorMoveLastItem8"
        Me.BindingNavigatorMoveLastItem8.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem8.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveLastItem8.Text = "Move last"
        '
        'BindingNavigatorSeparator26
        '
        Me.BindingNavigatorSeparator26.Name = "BindingNavigatorSeparator26"
        Me.BindingNavigatorSeparator26.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorEditRecibos
        '
        Me.BindingNavigatorEditRecibos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorEditRecibos.Image = Global.centro_medico.My.Resources.Resources.folderopen
        Me.BindingNavigatorEditRecibos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditRecibos.Name = "BindingNavigatorEditRecibos"
        Me.BindingNavigatorEditRecibos.Size = New System.Drawing.Size(57, 35)
        Me.BindingNavigatorEditRecibos.Text = "Editar"
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
        Me.gb_Principales.Location = New System.Drawing.Point(103, 27)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 42
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
        'form_recibos_ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 492)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.dtg_recRecibos)
        Me.Controls.Add(Me.gb_recFiltrar)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.nv_recRecibos)
        Me.KeyPreview = True
        Me.Name = "form_recibos_ex"
        Me.ShowInTaskbar = False
        Me.Text = "RECIBOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dtg_recRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_recFiltrar.ResumeLayout(False)
        Me.gb_recFiltrar.PerformLayout()
        Me.gb_recOrdenarpor.ResumeLayout(False)
        Me.gb_recOrdenarpor.PerformLayout()
        Me.gb_recEstado.ResumeLayout(False)
        Me.gb_recEstado.PerformLayout()
        CType(Me.nv_recRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nv_recRecibos.ResumeLayout(False)
        Me.nv_recRecibos.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents dtg_recRecibos As System.Windows.Forms.DataGridView
    Friend WithEvents gb_recFiltrar As System.Windows.Forms.GroupBox
    Friend WithEvents bt_recFiltrar As System.Windows.Forms.Button
    Friend WithEvents dtp_recHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_recHasta As System.Windows.Forms.Label
    Friend WithEvents dtp_recDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_recDesde As System.Windows.Forms.Label
    Friend WithEvents gb_recOrdenarpor As System.Windows.Forms.GroupBox
    Friend WithEvents rb_recImporte As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recFVencimiento As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recCobrado As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recFEmision As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recNumero As System.Windows.Forms.RadioButton
    Friend WithEvents gb_recEstado As System.Windows.Forms.GroupBox
    Friend WithEvents rb_recImpagados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recPagados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recTodas As System.Windows.Forms.RadioButton
    Friend WithEvents nv_recRecibos As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem8 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditRecibos As System.Windows.Forms.ToolStripButton
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
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
End Class
