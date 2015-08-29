<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartes
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
        Dim gridExPartes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartes))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridEXFieldChooserControl1 = New Janus.Windows.GridEX.GridEXFieldChooserControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_Final = New System.Windows.Forms.CheckBox()
        Me.chk_FechaInicio = New System.Windows.Forms.CheckBox()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.btn_Filtrar = New System.Windows.Forms.Button()
        Me.rb_Altas = New System.Windows.Forms.RadioButton()
        Me.rb_Bajas = New System.Windows.Forms.RadioButton()
        Me.rb_Todos = New System.Windows.Forms.RadioButton()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.N_PartesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.gridExPartes = New Janus.Windows.GridEX.GridEX()
        Me.CM3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_PartesTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.N_PartesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExPartes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(963, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GridEXFieldChooserControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_Filtrar)
        Me.GroupBox1.Controls.Add(Me.rb_Altas)
        Me.GroupBox1.Controls.Add(Me.rb_Bajas)
        Me.GroupBox1.Controls.Add(Me.rb_Todos)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(956, 80)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'GridEXFieldChooserControl1
        '
        Me.GridEXFieldChooserControl1.Location = New System.Drawing.Point(898, 78)
        Me.GridEXFieldChooserControl1.Name = "GridEXFieldChooserControl1"
        Me.GridEXFieldChooserControl1.Size = New System.Drawing.Size(75, 23)
        Me.GridEXFieldChooserControl1.TabIndex = 114
        Me.GridEXFieldChooserControl1.Text = "GridEXFieldChooserControl1"
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
        Me.btn_Filtrar.Location = New System.Drawing.Point(875, 34)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(75, 40)
        Me.btn_Filtrar.TabIndex = 2
        Me.btn_Filtrar.Text = "Filtrar"
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'rb_Altas
        '
        Me.rb_Altas.AutoSize = True
        Me.rb_Altas.Location = New System.Drawing.Point(469, 42)
        Me.rb_Altas.Name = "rb_Altas"
        Me.rb_Altas.Size = New System.Drawing.Size(48, 17)
        Me.rb_Altas.TabIndex = 1
        Me.rb_Altas.Text = "Altas"
        Me.rb_Altas.UseVisualStyleBackColor = True
        '
        'rb_Bajas
        '
        Me.rb_Bajas.AutoSize = True
        Me.rb_Bajas.Location = New System.Drawing.Point(412, 42)
        Me.rb_Bajas.Name = "rb_Bajas"
        Me.rb_Bajas.Size = New System.Drawing.Size(51, 17)
        Me.rb_Bajas.TabIndex = 1
        Me.rb_Bajas.Text = "Bajas"
        Me.rb_Bajas.UseVisualStyleBackColor = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(963, 25)
        Me.ToolStrip1.TabIndex = 16
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
        'N_PartesBindingSource
        '
        Me.N_PartesBindingSource.DataMember = "N_Partes"
        Me.N_PartesBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridExPartes
        '
        Me.gridExPartes.AllowColumnDrag = False
        Me.gridExPartes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridExPartes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridExPartes.DataMember = "N_Partes"
        Me.gridExPartes.DataSource = Me.CM3DataSet
        gridExPartes_DesignTimeLayout.LayoutString = resources.GetString("gridExPartes_DesignTimeLayout.LayoutString")
        Me.gridExPartes.DesignTimeLayout = gridExPartes_DesignTimeLayout
        Me.gridExPartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridExPartes.GroupByBoxVisible = False
        Me.gridExPartes.Hierarchical = True
        Me.gridExPartes.Location = New System.Drawing.Point(5, 113)
        Me.gridExPartes.Name = "gridExPartes"
        Me.gridExPartes.RecordNavigator = True
        Me.gridExPartes.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.gridExPartes.ScrollBarWidth = 17
        Me.gridExPartes.Size = New System.Drawing.Size(946, 535)
        Me.gridExPartes.TabIndex = 20
        '
        'CM3DataSetBindingSource
        '
        Me.CM3DataSetBindingSource.DataSource = Me.CM3DataSet
        Me.CM3DataSetBindingSource.Position = 0
        '
        'N_PartesTableAdapter
        '
        Me.N_PartesTableAdapter.ClearBeforeFill = True
        '
        'frmPartes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 673)
        Me.Controls.Add(Me.gridExPartes)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Name = "frmPartes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Partes Alta/Baja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.N_PartesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExPartes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Final As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FechaInicio As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents rb_Bajas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_PartesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PartesTableAdapter As centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter
    Friend WithEvents rb_Altas As System.Windows.Forms.RadioButton
    Friend WithEvents GridEXFieldChooserControl1 As Janus.Windows.GridEX.GridEXFieldChooserControl
    Friend WithEvents CM3DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gridExPartes As Janus.Windows.GridEX.GridEX
End Class
