<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.N_Procesos_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Procesos_ResumenTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_Procesos_ResumenTableAdapter()
        Me.N_Procesos_ResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.columnEstado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_Final = New System.Windows.Forms.CheckBox()
        Me.chk_FechaInicio = New System.Windows.Forms.CheckBox()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.btn_Filtrar = New System.Windows.Forms.Button()
        Me.rb_Finalizados = New System.Windows.Forms.RadioButton()
        Me.rb_Abiertos = New System.Windows.Forms.RadioButton()
        Me.rb_Cerrados = New System.Windows.Forms.RadioButton()
        Me.rb_Todos = New System.Windows.Forms.RadioButton()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Procesos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Procesos_ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Procesos_ResumenBindingSource
        '
        Me.N_Procesos_ResumenBindingSource.DataMember = "N_Procesos_Resumen"
        Me.N_Procesos_ResumenBindingSource.DataSource = Me.CM3DataSet
        '
        'N_Procesos_ResumenTableAdapter
        '
        Me.N_Procesos_ResumenTableAdapter.ClearBeforeFill = True
        '
        'N_Procesos_ResumenDataGridView
        '
        Me.N_Procesos_ResumenDataGridView.AllowUserToAddRows = False
        Me.N_Procesos_ResumenDataGridView.AllowUserToDeleteRows = False
        Me.N_Procesos_ResumenDataGridView.AllowUserToResizeRows = False
        Me.N_Procesos_ResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Procesos_ResumenDataGridView.AutoGenerateColumns = False
        Me.N_Procesos_ResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Procesos_ResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnEstado, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.N_Procesos_ResumenDataGridView.DataSource = Me.N_Procesos_ResumenBindingSource
        Me.N_Procesos_ResumenDataGridView.Location = New System.Drawing.Point(7, 114)
        Me.N_Procesos_ResumenDataGridView.MultiSelect = False
        Me.N_Procesos_ResumenDataGridView.Name = "N_Procesos_ResumenDataGridView"
        Me.N_Procesos_ResumenDataGridView.ReadOnly = True
        Me.N_Procesos_ResumenDataGridView.RowHeadersVisible = False
        Me.N_Procesos_ResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Procesos_ResumenDataGridView.Size = New System.Drawing.Size(932, 536)
        Me.N_Procesos_ResumenDataGridView.TabIndex = 1
        '
        'columnEstado
        '
        Me.columnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.columnEstado.HeaderText = "Estado"
        Me.columnEstado.MinimumWidth = 45
        Me.columnEstado.Name = "columnEstado"
        Me.columnEstado.ReadOnly = True
        Me.columnEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnEstado.Width = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Proceso"
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Paciente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod Paciente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NOMBREPACIENTE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Paciente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaFinal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Final"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 87
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_Empresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_Empresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Empresa"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Mutua"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_Mutua"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MUTUA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Mutua"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_UsuarioCreador"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_UsuarioCreador"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
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
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_Filtrar)
        Me.GroupBox1.Controls.Add(Me.rb_Finalizados)
        Me.GroupBox1.Controls.Add(Me.rb_Abiertos)
        Me.GroupBox1.Controls.Add(Me.rb_Cerrados)
        Me.GroupBox1.Controls.Add(Me.rb_Todos)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 80)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Final)
        Me.GroupBox2.Controls.Add(Me.chk_FechaInicio)
        Me.GroupBox2.Controls.Add(Me.dtp_ff)
        Me.GroupBox2.Controls.Add(Me.dtp_fi)
        Me.GroupBox2.Location = New System.Drawing.Point(567, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 66)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'chk_Final
        '
        Me.chk_Final.AutoSize = True
        Me.chk_Final.Location = New System.Drawing.Point(144, 20)
        Me.chk_Final.Name = "chk_Final"
        Me.chk_Final.Size = New System.Drawing.Size(54, 17)
        Me.chk_Final.TabIndex = 2
        Me.chk_Final.Text = "Hasta"
        Me.chk_Final.UseVisualStyleBackColor = True
        '
        'chk_FechaInicio
        '
        Me.chk_FechaInicio.AutoSize = True
        Me.chk_FechaInicio.Location = New System.Drawing.Point(12, 19)
        Me.chk_FechaInicio.Name = "chk_FechaInicio"
        Me.chk_FechaInicio.Size = New System.Drawing.Size(57, 17)
        Me.chk_FechaInicio.TabIndex = 2
        Me.chk_FechaInicio.Text = "Desde"
        Me.chk_FechaInicio.UseVisualStyleBackColor = True
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(144, 39)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(12, 39)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom_actual
        Me.btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Filtrar.Location = New System.Drawing.Point(850, 34)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(75, 40)
        Me.btn_Filtrar.TabIndex = 2
        Me.btn_Filtrar.Text = "Filtrar"
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'rb_Finalizados
        '
        Me.rb_Finalizados.AutoSize = True
        Me.rb_Finalizados.Location = New System.Drawing.Point(482, 42)
        Me.rb_Finalizados.Name = "rb_Finalizados"
        Me.rb_Finalizados.Size = New System.Drawing.Size(77, 17)
        Me.rb_Finalizados.TabIndex = 1
        Me.rb_Finalizados.Text = "Finalizados"
        Me.rb_Finalizados.UseVisualStyleBackColor = True
        '
        'rb_Abiertos
        '
        Me.rb_Abiertos.AutoSize = True
        Me.rb_Abiertos.Location = New System.Drawing.Point(412, 42)
        Me.rb_Abiertos.Name = "rb_Abiertos"
        Me.rb_Abiertos.Size = New System.Drawing.Size(63, 17)
        Me.rb_Abiertos.TabIndex = 1
        Me.rb_Abiertos.Text = "Abiertos"
        Me.rb_Abiertos.UseVisualStyleBackColor = True
        '
        'rb_Cerrados
        '
        Me.rb_Cerrados.AutoSize = True
        Me.rb_Cerrados.Location = New System.Drawing.Point(482, 19)
        Me.rb_Cerrados.Name = "rb_Cerrados"
        Me.rb_Cerrados.Size = New System.Drawing.Size(67, 17)
        Me.rb_Cerrados.TabIndex = 1
        Me.rb_Cerrados.Text = "Cerrados"
        Me.rb_Cerrados.UseVisualStyleBackColor = True
        '
        'rb_Todos
        '
        Me.rb_Todos.AutoSize = True
        Me.rb_Todos.Checked = True
        Me.rb_Todos.Location = New System.Drawing.Point(412, 19)
        Me.rb_Todos.Name = "rb_Todos"
        Me.rb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_Todos.TabIndex = 1
        Me.rb_Todos.TabStop = True
        Me.rb_Todos.Text = "Todos"
        Me.rb_Todos.UseVisualStyleBackColor = True
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(16, 19)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(370, 53)
        Me.CtrlPaciente1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(944, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(167, 17)
        Me.ToolStripStatusLabel1.Text = "Leyenda estados de proceso:   "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Image = Global.centro_medico.My.Resources.Resources.Procesos_Abierto
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(62, 17)
        Me.ToolStripStatusLabel3.Text = "Abierto"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Image = Global.centro_medico.My.Resources.Resources.Procesos_Cerrado
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel4.Text = "Cerrado"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = Global.centro_medico.My.Resources.Resources.Procesos_Finalizado
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel2.Text = "Finalizado"
        '
        'frmProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 674)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.N_Procesos_ResumenDataGridView)
        Me.KeyPreview = True
        Me.Name = "frmProcesos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesos"
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Procesos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Procesos_ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_Procesos_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Procesos_ResumenTableAdapter As centro_medico.CM3DataSetTableAdapters.N_Procesos_ResumenTableAdapter
    Friend WithEvents N_Procesos_ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents rb_Finalizados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Abiertos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Cerrados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Final As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FechaInicio As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents columnEstado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
