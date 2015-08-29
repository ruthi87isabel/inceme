<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas_Por_Procedencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas_Por_Procedencia))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_empresa = New System.Windows.Forms.Button
        Me.tb_empresa = New ctrlTextboxAvanzado
        Me.bt_mutua = New System.Windows.Forms.Button
        Me.tb_mutua = New ctrlTextboxAvanzado
        Me.lb_empresa = New System.Windows.Forms.Label
        Me.lb_mutua = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_mutua = New System.Windows.Forms.TabPage
        Me.dgv_mutuas = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mutua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Visitas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tab_mutua_paciente = New System.Windows.Forms.TabPage
        Me.dgv_mutuapac = New System.Windows.Forms.DataGridView
        Me.Apellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tab_empresa = New System.Windows.Forms.TabPage
        Me.dgv_empresa = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tab_empresa_mutua = New System.Windows.Forms.TabPage
        Me.dgv_empresapac = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.tab_mutua.SuspendLayout()
        CType(Me.dgv_mutuas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mutua_paciente.SuspendLayout()
        CType(Me.dgv_mutuapac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_empresa.SuspendLayout()
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_empresa_mutua.SuspendLayout()
        CType(Me.dgv_empresapac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(147, 25)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(15, 25)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(15, 435)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 32)
        Me.bt_imprimir.TabIndex = 12
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(586, 90)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(93, 23)
        Me.bt_filtrar.TabIndex = 9
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'bt_empresa
        '
        Me.bt_empresa.BackgroundImage = CType(resources.GetObject("bt_empresa.BackgroundImage"), System.Drawing.Image)
        Me.bt_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_empresa.Enabled = False
        Me.bt_empresa.Location = New System.Drawing.Point(354, 63)
        Me.bt_empresa.Name = "bt_empresa"
        Me.bt_empresa.Size = New System.Drawing.Size(31, 23)
        Me.bt_empresa.TabIndex = 6
        Me.bt_empresa.UseVisualStyleBackColor = True
        '
        'tb_empresa
        '
        Me.tb_empresa.BackColor = System.Drawing.Color.White
        Me.tb_empresa.Enabled = False
        Me.tb_empresa.Location = New System.Drawing.Point(275, 63)
        Me.tb_empresa.Name = "tb_empresa"
        Me.tb_empresa.Size = New System.Drawing.Size(82, 20)
        Me.tb_empresa.TabIndex = 5
        '
        'bt_mutua
        '
        Me.bt_mutua.BackgroundImage = CType(resources.GetObject("bt_mutua.BackgroundImage"), System.Drawing.Image)
        Me.bt_mutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_mutua.Location = New System.Drawing.Point(354, 22)
        Me.bt_mutua.Name = "bt_mutua"
        Me.bt_mutua.Size = New System.Drawing.Size(31, 23)
        Me.bt_mutua.TabIndex = 4
        Me.bt_mutua.UseVisualStyleBackColor = True
        '
        'tb_mutua
        '
        Me.tb_mutua.BackColor = System.Drawing.Color.White
        Me.tb_mutua.Enabled = False
        Me.tb_mutua.Location = New System.Drawing.Point(275, 24)
        Me.tb_mutua.Name = "tb_mutua"
        Me.tb_mutua.Size = New System.Drawing.Size(82, 20)
        Me.tb_mutua.TabIndex = 3
        '
        'lb_empresa
        '
        Me.lb_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_empresa.Enabled = False
        Me.lb_empresa.Location = New System.Drawing.Point(390, 67)
        Me.lb_empresa.Name = "lb_empresa"
        Me.lb_empresa.Size = New System.Drawing.Size(289, 20)
        Me.lb_empresa.TabIndex = 8
        '
        'lb_mutua
        '
        Me.lb_mutua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_mutua.Enabled = False
        Me.lb_mutua.Location = New System.Drawing.Point(390, 23)
        Me.lb_mutua.Name = "lb_mutua"
        Me.lb_mutua.Size = New System.Drawing.Size(289, 20)
        Me.lb_mutua.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Mutua"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Empresa"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_mutua)
        Me.TabControl1.Controls.Add(Me.tab_mutua_paciente)
        Me.TabControl1.Controls.Add(Me.tab_empresa)
        Me.TabControl1.Controls.Add(Me.tab_empresa_mutua)
        Me.TabControl1.Location = New System.Drawing.Point(15, 123)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(663, 297)
        Me.TabControl1.TabIndex = 10
        '
        'tab_mutua
        '
        Me.tab_mutua.Controls.Add(Me.dgv_mutuas)
        Me.tab_mutua.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua.Name = "tab_mutua"
        Me.tab_mutua.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mutua.Size = New System.Drawing.Size(655, 271)
        Me.tab_mutua.TabIndex = 0
        Me.tab_mutua.Text = "Agrupadas por mutua"
        Me.tab_mutua.UseVisualStyleBackColor = True
        '
        'dgv_mutuas
        '
        Me.dgv_mutuas.AllowUserToAddRows = False
        Me.dgv_mutuas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_mutuas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_mutuas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_mutuas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_mutuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mutuas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Mutua, Me.Visitas})
        Me.dgv_mutuas.Location = New System.Drawing.Point(4, 3)
        Me.dgv_mutuas.MultiSelect = False
        Me.dgv_mutuas.Name = "dgv_mutuas"
        Me.dgv_mutuas.RowHeadersVisible = False
        Me.dgv_mutuas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mutuas.Size = New System.Drawing.Size(653, 262)
        Me.dgv_mutuas.TabIndex = 11
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cód. Mutua"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 87
        '
        'Mutua
        '
        Me.Mutua.HeaderText = "Mutua"
        Me.Mutua.Name = "Mutua"
        Me.Mutua.Width = 62
        '
        'Visitas
        '
        Me.Visitas.HeaderText = "Visitas"
        Me.Visitas.Name = "Visitas"
        Me.Visitas.Width = 62
        '
        'tab_mutua_paciente
        '
        Me.tab_mutua_paciente.Controls.Add(Me.dgv_mutuapac)
        Me.tab_mutua_paciente.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_paciente.Name = "tab_mutua_paciente"
        Me.tab_mutua_paciente.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mutua_paciente.Size = New System.Drawing.Size(655, 271)
        Me.tab_mutua_paciente.TabIndex = 1
        Me.tab_mutua_paciente.Text = "Agrupadas por paciente/mutua"
        Me.tab_mutua_paciente.UseVisualStyleBackColor = True
        '
        'dgv_mutuapac
        '
        Me.dgv_mutuapac.AllowUserToAddRows = False
        Me.dgv_mutuapac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_mutuapac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_mutuapac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_mutuapac.BackgroundColor = System.Drawing.Color.White
        Me.dgv_mutuapac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mutuapac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido1, Me.Apellido2, Me.Nombre, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgv_mutuapac.Location = New System.Drawing.Point(5, 4)
        Me.dgv_mutuapac.MultiSelect = False
        Me.dgv_mutuapac.Name = "dgv_mutuapac"
        Me.dgv_mutuapac.RowHeadersVisible = False
        Me.dgv_mutuapac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mutuapac.Size = New System.Drawing.Size(653, 262)
        Me.dgv_mutuapac.TabIndex = 51
        '
        'Apellido1
        '
        Me.Apellido1.HeaderText = "1er Apellido"
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.Width = 87
        '
        'Apellido2
        '
        Me.Apellido2.HeaderText = "2do Apellido"
        Me.Apellido2.Name = "Apellido2"
        Me.Apellido2.Width = 90
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 69
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cód. Mutua"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 87
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mutua"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 62
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Visitas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 62
        '
        'tab_empresa
        '
        Me.tab_empresa.Controls.Add(Me.dgv_empresa)
        Me.tab_empresa.Location = New System.Drawing.Point(4, 22)
        Me.tab_empresa.Name = "tab_empresa"
        Me.tab_empresa.Size = New System.Drawing.Size(655, 271)
        Me.tab_empresa.TabIndex = 2
        Me.tab_empresa.Text = "Agrupadas por empresa"
        Me.tab_empresa.UseVisualStyleBackColor = True
        '
        'dgv_empresa
        '
        Me.dgv_empresa.AllowUserToAddRows = False
        Me.dgv_empresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_empresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_empresa.BackgroundColor = System.Drawing.Color.White
        Me.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Empresa, Me.DataGridViewTextBoxColumn6})
        Me.dgv_empresa.Location = New System.Drawing.Point(5, 4)
        Me.dgv_empresa.MultiSelect = False
        Me.dgv_empresa.Name = "dgv_empresa"
        Me.dgv_empresa.RowHeadersVisible = False
        Me.dgv_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empresa.Size = New System.Drawing.Size(653, 262)
        Me.dgv_empresa.TabIndex = 51
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cód. Empresa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 98
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Width = 73
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Visitas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 62
        '
        'tab_empresa_mutua
        '
        Me.tab_empresa_mutua.Controls.Add(Me.dgv_empresapac)
        Me.tab_empresa_mutua.Location = New System.Drawing.Point(4, 22)
        Me.tab_empresa_mutua.Name = "tab_empresa_mutua"
        Me.tab_empresa_mutua.Size = New System.Drawing.Size(655, 271)
        Me.tab_empresa_mutua.TabIndex = 3
        Me.tab_empresa_mutua.Text = "Agrupadas por paciente/empresa"
        Me.tab_empresa_mutua.UseVisualStyleBackColor = True
        '
        'dgv_empresapac
        '
        Me.dgv_empresapac.AllowUserToAddRows = False
        Me.dgv_empresapac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_empresapac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_empresapac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_empresapac.BackgroundColor = System.Drawing.Color.White
        Me.dgv_empresapac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empresapac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Nombre_Empresa, Me.DataGridViewTextBoxColumn11})
        Me.dgv_empresapac.Location = New System.Drawing.Point(5, 4)
        Me.dgv_empresapac.MultiSelect = False
        Me.dgv_empresapac.Name = "dgv_empresapac"
        Me.dgv_empresapac.RowHeadersVisible = False
        Me.dgv_empresapac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empresapac.Size = New System.Drawing.Size(653, 262)
        Me.dgv_empresapac.TabIndex = 52
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "1er Apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 87
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "2do Apellido"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 69
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cód Empresa"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 95
        '
        'Nombre_Empresa
        '
        Me.Nombre_Empresa.HeaderText = "Empresa"
        Me.Nombre_Empresa.Name = "Nombre_Empresa"
        Me.Nombre_Empresa.Width = 73
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Visitas"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 62
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(603, 439)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 13
        Me.bt_cerrar.Text = "     Cerrar"
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'Citas_Por_Procedencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(683, 471)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_empresa)
        Me.Controls.Add(Me.lb_mutua)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.bt_empresa)
        Me.Controls.Add(Me.tb_empresa)
        Me.Controls.Add(Me.bt_mutua)
        Me.Controls.Add(Me.tb_mutua)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.dtp_fi)
        Me.Name = "Citas_Por_Procedencia"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de citas agrupadas por procedencia"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_mutua.ResumeLayout(False)
        CType(Me.dgv_mutuas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mutua_paciente.ResumeLayout(False)
        CType(Me.dgv_mutuapac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_empresa.ResumeLayout(False)
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_empresa_mutua.ResumeLayout(False)
        CType(Me.dgv_empresapac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents bt_empresa As System.Windows.Forms.Button
    Friend WithEvents tb_empresa As ctrlTextboxAvanzado
    Friend WithEvents bt_mutua As System.Windows.Forms.Button
    Friend WithEvents tb_mutua As ctrlTextboxAvanzado
    Friend WithEvents lb_empresa As System.Windows.Forms.Label
    Friend WithEvents lb_mutua As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_mutua As System.Windows.Forms.TabPage
    Friend WithEvents tab_mutua_paciente As System.Windows.Forms.TabPage
    Friend WithEvents tab_empresa As System.Windows.Forms.TabPage
    Friend WithEvents tab_empresa_mutua As System.Windows.Forms.TabPage
    Friend WithEvents dgv_mutuas As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mutua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Visitas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_mutuapac As System.Windows.Forms.DataGridView
    Friend WithEvents Apellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_empresa As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_empresapac As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
End Class
