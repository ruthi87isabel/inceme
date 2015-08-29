<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizardFacturacionCitas
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbp_Paso1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.gb_tipo = New System.Windows.Forms.GroupBox
        Me.rb_Mutuas = New System.Windows.Forms.RadioButton
        Me.rb_pacientes = New System.Windows.Forms.RadioButton
        Me.tbp_Paso2 = New System.Windows.Forms.TabPage
        Me.lblMutua = New System.Windows.Forms.Label
        Me.cmbMutuas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_Filtrar = New System.Windows.Forms.Button
        Me.lblFiltrar = New System.Windows.Forms.Label
        Me.txtFiltrarPorNombre = New ctrlTextboxAvanzado
        Me.dg_PacientesMutuas = New System.Windows.Forms.DataGridView
        Me.tbp_Paso3 = New System.Windows.Forms.TabPage
        Me.grp_SerieFactura = New System.Windows.Forms.GroupBox
        Me.cb_serie = New System.Windows.Forms.ComboBox
        Me.lblCitasFiltradas = New System.Windows.Forms.Label
        Me.gb_seleccion = New System.Windows.Forms.GroupBox
        Me.rb_Ninguno = New System.Windows.Forms.RadioButton
        Me.rb_Todos = New System.Windows.Forms.RadioButton
        Me.dg_Citas = New System.Windows.Forms.DataGridView
        Me.seleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCita = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RefPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tbp_Paso4 = New System.Windows.Forms.TabPage
        Me.tb_facturagenerada = New ctrlTextboxAvanzado
        Me.lb_generada = New System.Windows.Forms.Label
        Me.lb_finalizada = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bt_Siguiente = New System.Windows.Forms.Button
        Me.bt_Anterior = New System.Windows.Forms.Button
        Me.bt_Cancelar = New System.Windows.Forms.Button
        Me.bt_Aceptar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERIESTableAdapter = New centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.LINEASFACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASFACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.LineasCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineasCitasTableAdapter = New centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
        Me.LMUTUASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbp_Paso1.SuspendLayout()
        Me.gb_tipo.SuspendLayout()
        Me.tbp_Paso2.SuspendLayout()
        CType(Me.dg_PacientesMutuas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_Paso3.SuspendLayout()
        Me.grp_SerieFactura.SuspendLayout()
        Me.gb_seleccion.SuspendLayout()
        CType(Me.dg_Citas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_Paso4.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbp_Paso1)
        Me.TabControl1.Controls.Add(Me.tbp_Paso2)
        Me.TabControl1.Controls.Add(Me.tbp_Paso3)
        Me.TabControl1.Controls.Add(Me.tbp_Paso4)
        Me.TabControl1.Location = New System.Drawing.Point(122, -21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 405)
        Me.TabControl1.TabIndex = 0
        '
        'tbp_Paso1
        '
        Me.tbp_Paso1.Controls.Add(Me.Label2)
        Me.tbp_Paso1.Controls.Add(Me.lblHasta)
        Me.tbp_Paso1.Controls.Add(Me.lblDesde)
        Me.tbp_Paso1.Controls.Add(Me.MonthCalendar2)
        Me.tbp_Paso1.Controls.Add(Me.MonthCalendar1)
        Me.tbp_Paso1.Controls.Add(Me.gb_tipo)
        Me.tbp_Paso1.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Paso1.Name = "tbp_Paso1"
        Me.tbp_Paso1.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Paso1.Size = New System.Drawing.Size(435, 379)
        Me.tbp_Paso1.TabIndex = 0
        Me.tbp_Paso1.Text = "TabPage1"
        Me.tbp_Paso1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "INDIQUE TIPO Y FECHA PARA FILTRAR CITAS"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(240, 148)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 4
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(22, 148)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 3
        Me.lblDesde.Text = "Desde"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(243, 170)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(25, 170)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'gb_tipo
        '
        Me.gb_tipo.Controls.Add(Me.rb_Mutuas)
        Me.gb_tipo.Controls.Add(Me.rb_pacientes)
        Me.gb_tipo.Location = New System.Drawing.Point(25, 45)
        Me.gb_tipo.Name = "gb_tipo"
        Me.gb_tipo.Size = New System.Drawing.Size(382, 100)
        Me.gb_tipo.TabIndex = 0
        Me.gb_tipo.TabStop = False
        Me.gb_tipo.Text = "Tipo"
        '
        'rb_Mutuas
        '
        Me.rb_Mutuas.AutoSize = True
        Me.rb_Mutuas.Location = New System.Drawing.Point(19, 51)
        Me.rb_Mutuas.Name = "rb_Mutuas"
        Me.rb_Mutuas.Size = New System.Drawing.Size(60, 17)
        Me.rb_Mutuas.TabIndex = 1
        Me.rb_Mutuas.TabStop = True
        Me.rb_Mutuas.Text = "Mutuas"
        Me.rb_Mutuas.UseVisualStyleBackColor = True
        '
        'rb_pacientes
        '
        Me.rb_pacientes.AutoSize = True
        Me.rb_pacientes.Checked = True
        Me.rb_pacientes.Location = New System.Drawing.Point(19, 19)
        Me.rb_pacientes.Name = "rb_pacientes"
        Me.rb_pacientes.Size = New System.Drawing.Size(72, 17)
        Me.rb_pacientes.TabIndex = 0
        Me.rb_pacientes.TabStop = True
        Me.rb_pacientes.Text = "Pacientes"
        Me.rb_pacientes.UseVisualStyleBackColor = True
        '
        'tbp_Paso2
        '
        Me.tbp_Paso2.Controls.Add(Me.lblMutua)
        Me.tbp_Paso2.Controls.Add(Me.cmbMutuas)
        Me.tbp_Paso2.Controls.Add(Me.Label1)
        Me.tbp_Paso2.Controls.Add(Me.bt_Filtrar)
        Me.tbp_Paso2.Controls.Add(Me.lblFiltrar)
        Me.tbp_Paso2.Controls.Add(Me.txtFiltrarPorNombre)
        Me.tbp_Paso2.Controls.Add(Me.dg_PacientesMutuas)
        Me.tbp_Paso2.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Paso2.Name = "tbp_Paso2"
        Me.tbp_Paso2.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Paso2.Size = New System.Drawing.Size(435, 379)
        Me.tbp_Paso2.TabIndex = 1
        Me.tbp_Paso2.Text = "TabPage2"
        Me.tbp_Paso2.UseVisualStyleBackColor = True
        '
        'lblMutua
        '
        Me.lblMutua.AutoSize = True
        Me.lblMutua.Location = New System.Drawing.Point(2, 60)
        Me.lblMutua.Name = "lblMutua"
        Me.lblMutua.Size = New System.Drawing.Size(40, 13)
        Me.lblMutua.TabIndex = 6
        Me.lblMutua.Text = "Mutua:"
        Me.lblMutua.Visible = False
        '
        'cmbMutuas
        '
        Me.cmbMutuas.FormattingEnabled = True
        Me.cmbMutuas.Location = New System.Drawing.Point(102, 57)
        Me.cmbMutuas.Name = "cmbMutuas"
        Me.cmbMutuas.Size = New System.Drawing.Size(165, 21)
        Me.cmbMutuas.TabIndex = 5
        Me.cmbMutuas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SELECCIONE PACIENTE/MUTUA"
        '
        'bt_Filtrar
        '
        Me.bt_Filtrar.Location = New System.Drawing.Point(352, 32)
        Me.bt_Filtrar.Name = "bt_Filtrar"
        Me.bt_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Filtrar.TabIndex = 3
        Me.bt_Filtrar.Text = "Filtrar"
        Me.bt_Filtrar.UseVisualStyleBackColor = True
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Location = New System.Drawing.Point(2, 37)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(93, 13)
        Me.lblFiltrar.TabIndex = 2
        Me.lblFiltrar.Text = "Filtrar por Nombre:"
        '
        'txtFiltrarPorNombre
        '
        Me.txtFiltrarPorNombre.Location = New System.Drawing.Point(101, 34)
        Me.txtFiltrarPorNombre.Name = "txtFiltrarPorNombre"
        Me.txtFiltrarPorNombre.Size = New System.Drawing.Size(245, 20)
        Me.txtFiltrarPorNombre.TabIndex = 1
        '
        'dg_PacientesMutuas
        '
        Me.dg_PacientesMutuas.AllowUserToAddRows = False
        Me.dg_PacientesMutuas.AllowUserToDeleteRows = False
        Me.dg_PacientesMutuas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_PacientesMutuas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_PacientesMutuas.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.dg_PacientesMutuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_PacientesMutuas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_PacientesMutuas.Location = New System.Drawing.Point(5, 81)
        Me.dg_PacientesMutuas.MultiSelect = False
        Me.dg_PacientesMutuas.Name = "dg_PacientesMutuas"
        Me.dg_PacientesMutuas.ReadOnly = True
        Me.dg_PacientesMutuas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_PacientesMutuas.Size = New System.Drawing.Size(422, 292)
        Me.dg_PacientesMutuas.TabIndex = 0
        '
        'tbp_Paso3
        '
        Me.tbp_Paso3.Controls.Add(Me.grp_SerieFactura)
        Me.tbp_Paso3.Controls.Add(Me.lblCitasFiltradas)
        Me.tbp_Paso3.Controls.Add(Me.gb_seleccion)
        Me.tbp_Paso3.Controls.Add(Me.dg_Citas)
        Me.tbp_Paso3.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Paso3.Name = "tbp_Paso3"
        Me.tbp_Paso3.Size = New System.Drawing.Size(435, 379)
        Me.tbp_Paso3.TabIndex = 2
        Me.tbp_Paso3.Text = "TabPage1"
        Me.tbp_Paso3.UseVisualStyleBackColor = True
        '
        'grp_SerieFactura
        '
        Me.grp_SerieFactura.Controls.Add(Me.cb_serie)
        Me.grp_SerieFactura.Location = New System.Drawing.Point(203, 28)
        Me.grp_SerieFactura.Name = "grp_SerieFactura"
        Me.grp_SerieFactura.Size = New System.Drawing.Size(223, 45)
        Me.grp_SerieFactura.TabIndex = 4
        Me.grp_SerieFactura.TabStop = False
        Me.grp_SerieFactura.Text = "Indique la serie de la Fra a generar"
        '
        'cb_serie
        '
        Me.cb_serie.FormattingEnabled = True
        Me.cb_serie.Location = New System.Drawing.Point(49, 19)
        Me.cb_serie.Name = "cb_serie"
        Me.cb_serie.Size = New System.Drawing.Size(121, 21)
        Me.cb_serie.TabIndex = 0
        '
        'lblCitasFiltradas
        '
        Me.lblCitasFiltradas.AutoSize = True
        Me.lblCitasFiltradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitasFiltradas.Location = New System.Drawing.Point(6, 9)
        Me.lblCitasFiltradas.Name = "lblCitasFiltradas"
        Me.lblCitasFiltradas.Size = New System.Drawing.Size(150, 20)
        Me.lblCitasFiltradas.TabIndex = 3
        Me.lblCitasFiltradas.Text = "CITAS FILTRADAS"
        '
        'gb_seleccion
        '
        Me.gb_seleccion.Controls.Add(Me.rb_Ninguno)
        Me.gb_seleccion.Controls.Add(Me.rb_Todos)
        Me.gb_seleccion.Location = New System.Drawing.Point(6, 28)
        Me.gb_seleccion.Name = "gb_seleccion"
        Me.gb_seleccion.Size = New System.Drawing.Size(191, 46)
        Me.gb_seleccion.TabIndex = 2
        Me.gb_seleccion.TabStop = False
        Me.gb_seleccion.Text = "Seleccionar"
        '
        'rb_Ninguno
        '
        Me.rb_Ninguno.AutoSize = True
        Me.rb_Ninguno.Location = New System.Drawing.Point(99, 19)
        Me.rb_Ninguno.Name = "rb_Ninguno"
        Me.rb_Ninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_Ninguno.TabIndex = 1
        Me.rb_Ninguno.Text = "Ninguno"
        Me.rb_Ninguno.UseVisualStyleBackColor = True
        '
        'rb_Todos
        '
        Me.rb_Todos.AutoSize = True
        Me.rb_Todos.Checked = True
        Me.rb_Todos.Location = New System.Drawing.Point(15, 19)
        Me.rb_Todos.Name = "rb_Todos"
        Me.rb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_Todos.TabIndex = 0
        Me.rb_Todos.TabStop = True
        Me.rb_Todos.Text = "Todos"
        Me.rb_Todos.UseVisualStyleBackColor = True
        '
        'dg_Citas
        '
        Me.dg_Citas.AllowUserToAddRows = False
        Me.dg_Citas.AllowUserToDeleteRows = False
        Me.dg_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Citas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_Citas.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.dg_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Citas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccion, Me.Paciente, Me.Fecha, Me.Hora, Me.IdCita, Me.RefPaciente})
        Me.dg_Citas.Location = New System.Drawing.Point(6, 76)
        Me.dg_Citas.MultiSelect = False
        Me.dg_Citas.Name = "dg_Citas"
        Me.dg_Citas.RowHeadersVisible = False
        Me.dg_Citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Citas.Size = New System.Drawing.Size(422, 289)
        Me.dg_Citas.TabIndex = 1
        '
        'seleccion
        '
        Me.seleccion.DataPropertyName = "seleccion"
        Me.seleccion.FillWeight = 20.0!
        Me.seleccion.HeaderText = "Sel."
        Me.seleccion.Name = "seleccion"
        '
        'Paciente
        '
        Me.Paciente.DataPropertyName = "Paciente"
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "fecha"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fecha.FillWeight = 30.0!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Hora
        '
        Me.Hora.DataPropertyName = "hora"
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Hora.DefaultCellStyle = DataGridViewCellStyle4
        Me.Hora.FillWeight = 30.0!
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'IdCita
        '
        Me.IdCita.DataPropertyName = "IdCita"
        Me.IdCita.HeaderText = "IdCita"
        Me.IdCita.Name = "IdCita"
        Me.IdCita.ReadOnly = True
        Me.IdCita.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdCita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IdCita.Visible = False
        '
        'RefPaciente
        '
        Me.RefPaciente.DataPropertyName = "RefPaciente"
        Me.RefPaciente.HeaderText = "RefPaciente"
        Me.RefPaciente.Name = "RefPaciente"
        Me.RefPaciente.ReadOnly = True
        Me.RefPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RefPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RefPaciente.Visible = False
        '
        'tbp_Paso4
        '
        Me.tbp_Paso4.Controls.Add(Me.tb_facturagenerada)
        Me.tbp_Paso4.Controls.Add(Me.lb_generada)
        Me.tbp_Paso4.Controls.Add(Me.lb_finalizada)
        Me.tbp_Paso4.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Paso4.Name = "tbp_Paso4"
        Me.tbp_Paso4.Size = New System.Drawing.Size(435, 379)
        Me.tbp_Paso4.TabIndex = 3
        Me.tbp_Paso4.Text = "TabPage1"
        Me.tbp_Paso4.UseVisualStyleBackColor = True
        '
        'tb_facturagenerada
        '
        Me.tb_facturagenerada.Location = New System.Drawing.Point(123, 184)
        Me.tb_facturagenerada.Name = "tb_facturagenerada"
        Me.tb_facturagenerada.ReadOnly = True
        Me.tb_facturagenerada.Size = New System.Drawing.Size(179, 20)
        Me.tb_facturagenerada.TabIndex = 6
        '
        'lb_generada
        '
        Me.lb_generada.AutoSize = True
        Me.lb_generada.Location = New System.Drawing.Point(135, 157)
        Me.lb_generada.Name = "lb_generada"
        Me.lb_generada.Size = New System.Drawing.Size(151, 13)
        Me.lb_generada.TabIndex = 5
        Me.lb_generada.Text = "GENERADA LA FACTURA Nº"
        '
        'lb_finalizada
        '
        Me.lb_finalizada.AutoSize = True
        Me.lb_finalizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_finalizada.Location = New System.Drawing.Point(20, 8)
        Me.lb_finalizada.Name = "lb_finalizada"
        Me.lb_finalizada.Size = New System.Drawing.Size(203, 20)
        Me.lb_finalizada.TabIndex = 4
        Me.lb_finalizada.Text = "OPERACIÓN FINALIZADA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.centro_medico.My.Resources.Resources.asistente
        Me.Panel1.Location = New System.Drawing.Point(0, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 450)
        Me.Panel1.TabIndex = 1
        '
        'bt_Siguiente
        '
        Me.bt_Siguiente.Image = Global.centro_medico.My.Resources.Resources._24_arrow_forward
        Me.bt_Siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Siguiente.Location = New System.Drawing.Point(207, 405)
        Me.bt_Siguiente.Name = "bt_Siguiente"
        Me.bt_Siguiente.Size = New System.Drawing.Size(79, 40)
        Me.bt_Siguiente.TabIndex = 2
        Me.bt_Siguiente.Text = "Siguiente"
        Me.bt_Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Siguiente.UseVisualStyleBackColor = True
        '
        'bt_Anterior
        '
        Me.bt_Anterior.Image = Global.centro_medico.My.Resources.Resources._24_arrow_back
        Me.bt_Anterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Anterior.Location = New System.Drawing.Point(128, 405)
        Me.bt_Anterior.Name = "bt_Anterior"
        Me.bt_Anterior.Size = New System.Drawing.Size(75, 40)
        Me.bt_Anterior.TabIndex = 3
        Me.bt_Anterior.Text = "Anterior"
        Me.bt_Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Anterior.UseVisualStyleBackColor = True
        Me.bt_Anterior.Visible = False
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Cancelar.Location = New System.Drawing.Point(474, 405)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(79, 40)
        Me.bt_Cancelar.TabIndex = 4
        Me.bt_Cancelar.Text = "Cancelar"
        Me.bt_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Aceptar
        '
        Me.bt_Aceptar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Aceptar.Location = New System.Drawing.Point(473, 405)
        Me.bt_Aceptar.Name = "bt_Aceptar"
        Me.bt_Aceptar.Size = New System.Drawing.Size(79, 40)
        Me.bt_Aceptar.TabIndex = 5
        Me.bt_Aceptar.Text = "Aceptar"
        Me.bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Aceptar.UseVisualStyleBackColor = True
        Me.bt_Aceptar.Visible = False
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataMember = "SERIES"
        Me.SERIESBindingSource.DataSource = Me.CMDataSet
        '
        'SERIESTableAdapter
        '
        Me.SERIESTableAdapter.ClearBeforeFill = True
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
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'LINEASFACTURASBindingSource
        '
        Me.LINEASFACTURASBindingSource.DataMember = "LINEASFACTURAS"
        Me.LINEASFACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'LINEASFACTURASTableAdapter
        '
        Me.LINEASFACTURASTableAdapter.ClearBeforeFill = True
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
        'LineasCitasBindingSource
        '
        Me.LineasCitasBindingSource.DataMember = "LineasCitas"
        Me.LineasCitasBindingSource.DataSource = Me.CMDataSet
        '
        'LineasCitasTableAdapter
        '
        Me.LineasCitasTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASBindingSource1
        '
        Me.LMUTUASBindingSource1.DataMember = "LMUTUAS"
        Me.LMUTUASBindingSource1.DataSource = Me.CMDataSet
        '
        'LMUTUASTableAdapter
        '
        Me.LMUTUASTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(129, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INFO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'frmWizardFacturacionCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(565, 446)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt_Aceptar)
        Me.Controls.Add(Me.bt_Cancelar)
        Me.Controls.Add(Me.bt_Anterior)
        Me.Controls.Add(Me.bt_Siguiente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmWizardFacturacionCitas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de Facturación de Citas."
        Me.TabControl1.ResumeLayout(False)
        Me.tbp_Paso1.ResumeLayout(False)
        Me.tbp_Paso1.PerformLayout()
        Me.gb_tipo.ResumeLayout(False)
        Me.gb_tipo.PerformLayout()
        Me.tbp_Paso2.ResumeLayout(False)
        Me.tbp_Paso2.PerformLayout()
        CType(Me.dg_PacientesMutuas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_Paso3.ResumeLayout(False)
        Me.tbp_Paso3.PerformLayout()
        Me.grp_SerieFactura.ResumeLayout(False)
        Me.gb_seleccion.ResumeLayout(False)
        Me.gb_seleccion.PerformLayout()
        CType(Me.dg_Citas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_Paso4.ResumeLayout(False)
        Me.tbp_Paso4.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbp_Paso1 As System.Windows.Forms.TabPage
    Friend WithEvents tbp_Paso2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents gb_tipo As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Mutuas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pacientes As System.Windows.Forms.RadioButton
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents bt_Filtrar As System.Windows.Forms.Button
    Friend WithEvents lblFiltrar As System.Windows.Forms.Label
    Friend WithEvents txtFiltrarPorNombre As ctrlTextboxAvanzado
    Friend WithEvents dg_PacientesMutuas As System.Windows.Forms.DataGridView
    Friend WithEvents tbp_Paso3 As System.Windows.Forms.TabPage
    Friend WithEvents dg_Citas As System.Windows.Forms.DataGridView
    Friend WithEvents gb_seleccion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Ninguno As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents lblCitasFiltradas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbp_Paso4 As System.Windows.Forms.TabPage
    Friend WithEvents lb_generada As System.Windows.Forms.Label
    Friend WithEvents lb_finalizada As System.Windows.Forms.Label
    Friend WithEvents tb_facturagenerada As ctrlTextboxAvanzado
    Friend WithEvents grp_SerieFactura As System.Windows.Forms.GroupBox
    Friend WithEvents cb_serie As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERIESTableAdapter As centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents LINEASFACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASFACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents LineasCitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineasCitasTableAdapter As centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
    Friend WithEvents lblMutua As System.Windows.Forms.Label
    Friend WithEvents cmbMutuas As System.Windows.Forms.ComboBox
    Friend WithEvents LMUTUASBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
    Friend WithEvents seleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
