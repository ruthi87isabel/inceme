<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_hislaboral
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
        Dim lb_hlRegimen As System.Windows.Forms.Label
        Dim lb_hlPuesto As System.Windows.Forms.Label
        Dim lb_hlProfesion As System.Windows.Forms.Label
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.lb_teclas = New System.Windows.Forms.Label
        Me.gb_hlMutAsegComprev = New System.Windows.Forms.GroupBox
        Me.dtg_hlMutuas = New System.Windows.Forms.DataGridView
        Me.bt_hlSelecMutua = New System.Windows.Forms.Button
        Me.bt_hlElimMutua = New System.Windows.Forms.Button
        Me.bt_hlAddMutua = New System.Windows.Forms.Button
        Me.bt_hlEditarMutua = New System.Windows.Forms.Button
        Me.gb_hlEmpresa = New System.Windows.Forms.GroupBox
        Me.dtg_hlLEmpresas = New System.Windows.Forms.DataGridView
        Me.bt_hlSelecEmpresa = New System.Windows.Forms.Button
        Me.bt_hlElimEmpresa = New System.Windows.Forms.Button
        Me.bt_hlAddEmpresa = New System.Windows.Forms.Button
        Me.bt_hlEditarEmpresa = New System.Windows.Forms.Button
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.LEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LEMPRESASTableAdapter
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.cb_hlRegimen = New System.Windows.Forms.ComboBox
        Me.tb_hlPuesto = New ctrlTextboxAvanzado
        Me.tb_hlProfesion = New ctrlTextboxAvanzado
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
        Me.LMUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
        lb_hlRegimen = New System.Windows.Forms.Label
        lb_hlPuesto = New System.Windows.Forms.Label
        lb_hlProfesion = New System.Windows.Forms.Label
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.gb_hlMutAsegComprev.SuspendLayout()
        CType(Me.dtg_hlMutuas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_hlEmpresa.SuspendLayout()
        CType(Me.dtg_hlLEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_hlRegimen
        '
        lb_hlRegimen.AutoSize = True
        lb_hlRegimen.Location = New System.Drawing.Point(538, 72)
        lb_hlRegimen.Name = "lb_hlRegimen"
        lb_hlRegimen.Size = New System.Drawing.Size(49, 13)
        lb_hlRegimen.TabIndex = 34
        lb_hlRegimen.Text = "Régimen"
        lb_hlRegimen.Visible = False
        '
        'lb_hlPuesto
        '
        lb_hlPuesto.AutoSize = True
        lb_hlPuesto.Location = New System.Drawing.Point(263, 72)
        lb_hlPuesto.Name = "lb_hlPuesto"
        lb_hlPuesto.Size = New System.Drawing.Size(40, 13)
        lb_hlPuesto.TabIndex = 32
        lb_hlPuesto.Text = "Puesto"
        lb_hlPuesto.Visible = False
        '
        'lb_hlProfesion
        '
        lb_hlProfesion.AutoSize = True
        lb_hlProfesion.Location = New System.Drawing.Point(31, 72)
        lb_hlProfesion.Name = "lb_hlProfesion"
        lb_hlProfesion.Size = New System.Drawing.Size(51, 13)
        lb_hlProfesion.TabIndex = 30
        lb_hlProfesion.Text = "Profesión"
        lb_hlProfesion.Visible = False
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
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(69, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(35, 506)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(155, 13)
        Me.lb_teclas.TabIndex = 23
        Me.lb_teclas.Text = "Alt+A=Guardar; Alt+C=Cancelar"
        '
        'gb_hlMutAsegComprev
        '
        Me.gb_hlMutAsegComprev.BackColor = System.Drawing.Color.GhostWhite
        Me.gb_hlMutAsegComprev.Controls.Add(Me.dtg_hlMutuas)
        Me.gb_hlMutAsegComprev.Controls.Add(Me.bt_hlSelecMutua)
        Me.gb_hlMutAsegComprev.Controls.Add(Me.bt_hlElimMutua)
        Me.gb_hlMutAsegComprev.Controls.Add(Me.bt_hlAddMutua)
        Me.gb_hlMutAsegComprev.Controls.Add(Me.bt_hlEditarMutua)
        Me.gb_hlMutAsegComprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_hlMutAsegComprev.Location = New System.Drawing.Point(11, 308)
        Me.gb_hlMutAsegComprev.Name = "gb_hlMutAsegComprev"
        Me.gb_hlMutAsegComprev.Size = New System.Drawing.Size(833, 194)
        Me.gb_hlMutAsegComprev.TabIndex = 25
        Me.gb_hlMutAsegComprev.TabStop = False
        Me.gb_hlMutAsegComprev.Text = "Mutuas/Aseguradoras/Compañías de revisión"
        '
        'dtg_hlMutuas
        '
        Me.dtg_hlMutuas.AllowUserToAddRows = False
        Me.dtg_hlMutuas.AllowUserToDeleteRows = False
        Me.dtg_hlMutuas.BackgroundColor = System.Drawing.Color.White
        Me.dtg_hlMutuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_hlMutuas.Location = New System.Drawing.Point(11, 23)
        Me.dtg_hlMutuas.MultiSelect = False
        Me.dtg_hlMutuas.Name = "dtg_hlMutuas"
        Me.dtg_hlMutuas.ReadOnly = True
        Me.dtg_hlMutuas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_hlMutuas.Size = New System.Drawing.Size(764, 159)
        Me.dtg_hlMutuas.TabIndex = 0
        '
        'bt_hlSelecMutua
        '
        Me.bt_hlSelecMutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_hlSelecMutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlSelecMutua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlSelecMutua.Location = New System.Drawing.Point(789, 157)
        Me.bt_hlSelecMutua.Name = "bt_hlSelecMutua"
        Me.bt_hlSelecMutua.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlSelecMutua.TabIndex = 4
        Me.bt_hlSelecMutua.UseVisualStyleBackColor = True
        '
        'bt_hlElimMutua
        '
        Me.bt_hlElimMutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_hlElimMutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlElimMutua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlElimMutua.Location = New System.Drawing.Point(789, 126)
        Me.bt_hlElimMutua.Name = "bt_hlElimMutua"
        Me.bt_hlElimMutua.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlElimMutua.TabIndex = 3
        Me.bt_hlElimMutua.UseVisualStyleBackColor = True
        '
        'bt_hlAddMutua
        '
        Me.bt_hlAddMutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_hlAddMutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlAddMutua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlAddMutua.Location = New System.Drawing.Point(789, 58)
        Me.bt_hlAddMutua.Name = "bt_hlAddMutua"
        Me.bt_hlAddMutua.Size = New System.Drawing.Size(32, 31)
        Me.bt_hlAddMutua.TabIndex = 1
        Me.bt_hlAddMutua.UseVisualStyleBackColor = True
        '
        'bt_hlEditarMutua
        '
        Me.bt_hlEditarMutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_hlEditarMutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlEditarMutua.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlEditarMutua.Location = New System.Drawing.Point(789, 95)
        Me.bt_hlEditarMutua.Name = "bt_hlEditarMutua"
        Me.bt_hlEditarMutua.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlEditarMutua.TabIndex = 2
        Me.bt_hlEditarMutua.UseVisualStyleBackColor = True
        '
        'gb_hlEmpresa
        '
        Me.gb_hlEmpresa.BackColor = System.Drawing.Color.GhostWhite
        Me.gb_hlEmpresa.Controls.Add(Me.dtg_hlLEmpresas)
        Me.gb_hlEmpresa.Controls.Add(Me.bt_hlSelecEmpresa)
        Me.gb_hlEmpresa.Controls.Add(Me.bt_hlElimEmpresa)
        Me.gb_hlEmpresa.Controls.Add(Me.bt_hlAddEmpresa)
        Me.gb_hlEmpresa.Controls.Add(Me.bt_hlEditarEmpresa)
        Me.gb_hlEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_hlEmpresa.Location = New System.Drawing.Point(11, 115)
        Me.gb_hlEmpresa.Name = "gb_hlEmpresa"
        Me.gb_hlEmpresa.Size = New System.Drawing.Size(833, 192)
        Me.gb_hlEmpresa.TabIndex = 24
        Me.gb_hlEmpresa.TabStop = False
        Me.gb_hlEmpresa.Text = "Empresas"
        '
        'dtg_hlLEmpresas
        '
        Me.dtg_hlLEmpresas.AllowUserToAddRows = False
        Me.dtg_hlLEmpresas.AllowUserToDeleteRows = False
        Me.dtg_hlLEmpresas.BackgroundColor = System.Drawing.Color.White
        Me.dtg_hlLEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_hlLEmpresas.Location = New System.Drawing.Point(11, 21)
        Me.dtg_hlLEmpresas.MultiSelect = False
        Me.dtg_hlLEmpresas.Name = "dtg_hlLEmpresas"
        Me.dtg_hlLEmpresas.ReadOnly = True
        Me.dtg_hlLEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_hlLEmpresas.Size = New System.Drawing.Size(765, 151)
        Me.dtg_hlLEmpresas.TabIndex = 1
        '
        'bt_hlSelecEmpresa
        '
        Me.bt_hlSelecEmpresa.BackgroundImage = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_hlSelecEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlSelecEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlSelecEmpresa.Location = New System.Drawing.Point(789, 131)
        Me.bt_hlSelecEmpresa.Name = "bt_hlSelecEmpresa"
        Me.bt_hlSelecEmpresa.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlSelecEmpresa.TabIndex = 0
        Me.bt_hlSelecEmpresa.UseVisualStyleBackColor = True
        '
        'bt_hlElimEmpresa
        '
        Me.bt_hlElimEmpresa.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_hlElimEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlElimEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlElimEmpresa.Location = New System.Drawing.Point(789, 100)
        Me.bt_hlElimEmpresa.Name = "bt_hlElimEmpresa"
        Me.bt_hlElimEmpresa.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlElimEmpresa.TabIndex = 4
        Me.bt_hlElimEmpresa.UseVisualStyleBackColor = True
        '
        'bt_hlAddEmpresa
        '
        Me.bt_hlAddEmpresa.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_hlAddEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlAddEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlAddEmpresa.Location = New System.Drawing.Point(789, 33)
        Me.bt_hlAddEmpresa.Name = "bt_hlAddEmpresa"
        Me.bt_hlAddEmpresa.Size = New System.Drawing.Size(32, 30)
        Me.bt_hlAddEmpresa.TabIndex = 2
        Me.bt_hlAddEmpresa.UseVisualStyleBackColor = True
        '
        'bt_hlEditarEmpresa
        '
        Me.bt_hlEditarEmpresa.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_hlEditarEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_hlEditarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hlEditarEmpresa.Location = New System.Drawing.Point(789, 69)
        Me.bt_hlEditarEmpresa.Name = "bt_hlEditarEmpresa"
        Me.bt_hlEditarEmpresa.Size = New System.Drawing.Size(32, 25)
        Me.bt_hlEditarEmpresa.TabIndex = 3
        Me.bt_hlEditarEmpresa.UseVisualStyleBackColor = True
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'LEMPRESASBindingSource
        '
        Me.LEMPRESASBindingSource.DataMember = "LEMPRESAS"
        Me.LEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'LEMPRESASTableAdapter
        '
        Me.LEMPRESASTableAdapter.ClearBeforeFill = True
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
        'cb_hlRegimen
        '
        Me.cb_hlRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_hlRegimen.FormattingEnabled = True
        Me.cb_hlRegimen.Items.AddRange(New Object() {"General", "Agricultura c/ propia", "Agricultura c/ ajena", "Mar", "Minería carbón"})
        Me.cb_hlRegimen.Location = New System.Drawing.Point(541, 89)
        Me.cb_hlRegimen.Name = "cb_hlRegimen"
        Me.cb_hlRegimen.Size = New System.Drawing.Size(178, 21)
        Me.cb_hlRegimen.TabIndex = 35
        Me.cb_hlRegimen.Visible = False
        '
        'tb_hlPuesto
        '
        Me.tb_hlPuesto.Location = New System.Drawing.Point(266, 90)
        Me.tb_hlPuesto.MaxLength = 30
        Me.tb_hlPuesto.Name = "tb_hlPuesto"
        Me.tb_hlPuesto.Size = New System.Drawing.Size(236, 20)
        Me.tb_hlPuesto.TabIndex = 33
        Me.tb_hlPuesto.Visible = False
        '
        'tb_hlProfesion
        '
        Me.tb_hlProfesion.Location = New System.Drawing.Point(34, 90)
        Me.tb_hlProfesion.MaxLength = 30
        Me.tb_hlProfesion.Name = "tb_hlProfesion"
        Me.tb_hlProfesion.Size = New System.Drawing.Size(193, 20)
        Me.tb_hlProfesion.TabIndex = 31
        Me.tb_hlProfesion.Visible = False
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
        Me.gb_Principales.Location = New System.Drawing.Point(103, 25)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
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
        'LMUTUASBindingSource
        '
        Me.LMUTUASBindingSource.DataMember = "LMUTUAS"
        Me.LMUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASTableAdapter
        '
        Me.LMUTUASTableAdapter.ClearBeforeFill = True
        '
        'form_hislaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 521)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(lb_hlRegimen)
        Me.Controls.Add(Me.cb_hlRegimen)
        Me.Controls.Add(lb_hlPuesto)
        Me.Controls.Add(Me.tb_hlPuesto)
        Me.Controls.Add(lb_hlProfesion)
        Me.Controls.Add(Me.tb_hlProfesion)
        Me.Controls.Add(Me.gb_hlMutAsegComprev)
        Me.Controls.Add(Me.gb_hlEmpresa)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "form_hislaboral"
        Me.ShowInTaskbar = False
        Me.Text = "HISTORIAL LABORAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.gb_hlMutAsegComprev.ResumeLayout(False)
        CType(Me.dtg_hlMutuas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_hlEmpresa.ResumeLayout(False)
        CType(Me.dtg_hlLEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents gb_hlMutAsegComprev As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_hlMutuas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_hlSelecMutua As System.Windows.Forms.Button
    Friend WithEvents bt_hlElimMutua As System.Windows.Forms.Button
    Friend WithEvents bt_hlAddMutua As System.Windows.Forms.Button
    Friend WithEvents bt_hlEditarMutua As System.Windows.Forms.Button
    Friend WithEvents gb_hlEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_hlLEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_hlSelecEmpresa As System.Windows.Forms.Button
    Friend WithEvents bt_hlElimEmpresa As System.Windows.Forms.Button
    Friend WithEvents bt_hlAddEmpresa As System.Windows.Forms.Button
    Friend WithEvents bt_hlEditarEmpresa As System.Windows.Forms.Button
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents LEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LEMPRESASTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents cb_hlRegimen As System.Windows.Forms.ComboBox
    Friend WithEvents tb_hlPuesto As ctrlTextboxAvanzado
    Friend WithEvents tb_hlProfesion As ctrlTextboxAvanzado
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
    Friend WithEvents LMUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
End Class
