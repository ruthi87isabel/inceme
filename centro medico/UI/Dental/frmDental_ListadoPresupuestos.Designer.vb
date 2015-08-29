<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDental_ListadoPresupuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDental_ListadoPresupuestos))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column13.ButtonImage")
        Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.FormatConditions.Condition0.FormatS" & _
        "tyle.BackgroundImage")
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.DPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpFiltroAsociado = New System.Windows.Forms.GroupBox()
        Me.rbCitasNoAsociados = New System.Windows.Forms.RadioButton()
        Me.rbCitasAsociados = New System.Windows.Forms.RadioButton()
        Me.rbCitasTodos = New System.Windows.Forms.RadioButton()
        Me.btnSeleccionarLineas = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRealizados = New System.Windows.Forms.CheckBox()
        Me.chkConfirmados = New System.Windows.Forms.CheckBox()
        Me.chkMostrarLineasImporte0 = New System.Windows.Forms.CheckBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.txtApellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroAsociado.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(957, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = CType(resources.GetObject("tst_Editar.Image"), System.Drawing.Image)
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = CType(resources.GetObject("tst_Eliminar.Image"), System.Drawing.Image)
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
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.DPresupuestoBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(0, 149)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEX1.Size = New System.Drawing.Size(957, 273)
        Me.GridEX1.TabIndex = 131
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'DPresupuestoBindingSource
        '
        Me.DPresupuestoBindingSource.DataSource = GetType(centro_medico.d_Presupuesto)
        '
        'grpFiltroAsociado
        '
        Me.grpFiltroAsociado.Controls.Add(Me.rbCitasNoAsociados)
        Me.grpFiltroAsociado.Controls.Add(Me.rbCitasAsociados)
        Me.grpFiltroAsociado.Controls.Add(Me.rbCitasTodos)
        Me.grpFiltroAsociado.Location = New System.Drawing.Point(558, 11)
        Me.grpFiltroAsociado.Name = "grpFiltroAsociado"
        Me.grpFiltroAsociado.Size = New System.Drawing.Size(121, 70)
        Me.grpFiltroAsociado.TabIndex = 132
        Me.grpFiltroAsociado.TabStop = False
        '
        'rbCitasNoAsociados
        '
        Me.rbCitasNoAsociados.AutoSize = True
        Me.rbCitasNoAsociados.Location = New System.Drawing.Point(10, 45)
        Me.rbCitasNoAsociados.Name = "rbCitasNoAsociados"
        Me.rbCitasNoAsociados.Size = New System.Drawing.Size(90, 17)
        Me.rbCitasNoAsociados.TabIndex = 0
        Me.rbCitasNoAsociados.Text = "No asociados"
        Me.rbCitasNoAsociados.UseVisualStyleBackColor = True
        '
        'rbCitasAsociados
        '
        Me.rbCitasAsociados.AutoSize = True
        Me.rbCitasAsociados.Location = New System.Drawing.Point(10, 28)
        Me.rbCitasAsociados.Name = "rbCitasAsociados"
        Me.rbCitasAsociados.Size = New System.Drawing.Size(104, 17)
        Me.rbCitasAsociados.TabIndex = 0
        Me.rbCitasAsociados.Text = "Asociados a Cita"
        Me.rbCitasAsociados.UseVisualStyleBackColor = True
        '
        'rbCitasTodos
        '
        Me.rbCitasTodos.AutoSize = True
        Me.rbCitasTodos.Checked = True
        Me.rbCitasTodos.Location = New System.Drawing.Point(11, 10)
        Me.rbCitasTodos.Name = "rbCitasTodos"
        Me.rbCitasTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbCitasTodos.TabIndex = 0
        Me.rbCitasTodos.TabStop = True
        Me.rbCitasTodos.Text = "Todos"
        Me.rbCitasTodos.UseVisualStyleBackColor = True
        '
        'btnSeleccionarLineas
        '
        Me.btnSeleccionarLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarLineas.Location = New System.Drawing.Point(827, 94)
        Me.btnSeleccionarLineas.Name = "btnSeleccionarLineas"
        Me.btnSeleccionarLineas.Size = New System.Drawing.Size(118, 49)
        Me.btnSeleccionarLineas.TabIndex = 134
        Me.btnSeleccionarLineas.Text = "Asociar lineas seleccionadas a cita"
        Me.btnSeleccionarLineas.UseVisualStyleBackColor = True
        Me.btnSeleccionarLineas.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 135
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel3.Text = "Presupuestos:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(136, 17)
        Me.ToolStripStatusLabel1.Text = "Parcialmente aceptados "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(127, 17)
        Me.ToolStripStatusLabel2.Text = "Totalmente Aceptados"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatusLabel4.Text = "Nada Aceptado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRealizados)
        Me.GroupBox1.Controls.Add(Me.chkConfirmados)
        Me.GroupBox1.Location = New System.Drawing.Point(685, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 70)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        '
        'chkRealizados
        '
        Me.chkRealizados.AutoSize = True
        Me.chkRealizados.Location = New System.Drawing.Point(15, 42)
        Me.chkRealizados.Name = "chkRealizados"
        Me.chkRealizados.Size = New System.Drawing.Size(78, 17)
        Me.chkRealizados.TabIndex = 1
        Me.chkRealizados.Text = "Realizados"
        Me.chkRealizados.UseVisualStyleBackColor = True
        '
        'chkConfirmados
        '
        Me.chkConfirmados.AutoSize = True
        Me.chkConfirmados.Location = New System.Drawing.Point(15, 19)
        Me.chkConfirmados.Name = "chkConfirmados"
        Me.chkConfirmados.Size = New System.Drawing.Size(84, 17)
        Me.chkConfirmados.TabIndex = 0
        Me.chkConfirmados.Text = "Confirmados"
        Me.chkConfirmados.UseVisualStyleBackColor = True
        '
        'chkMostrarLineasImporte0
        '
        Me.chkMostrarLineasImporte0.AutoSize = True
        Me.chkMostrarLineasImporte0.Checked = True
        Me.chkMostrarLineasImporte0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarLineasImporte0.Location = New System.Drawing.Point(558, 87)
        Me.chkMostrarLineasImporte0.Name = "chkMostrarLineasImporte0"
        Me.chkMostrarLineasImporte0.Size = New System.Drawing.Size(159, 17)
        Me.chkMostrarLineasImporte0.TabIndex = 136
        Me.chkMostrarLineasImporte0.Text = "Mostrar lineas con Importe 0"
        Me.chkMostrarLineasImporte0.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(559, 425)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(344, 31)
        Me.lblMsg.TabIndex = 137
        Me.lblMsg.Text = "Nota: Solo se mostrarán los presupuestos del paciente con lineas confirmadas que " & _
    "aún no han sido asignadas a cita"
        Me.lblMsg.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpHasta)
        Me.GroupBox2.Controls.Add(Me.dtpDesde)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 70)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Checked = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(53, 41)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.ShowCheckBox = True
        Me.dtpHasta.Size = New System.Drawing.Size(101, 20)
        Me.dtpHasta.TabIndex = 0
        '
        'dtpDesde
        '
        Me.dtpDesde.Checked = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(53, 16)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.ShowCheckBox = True
        Me.dtpDesde.Size = New System.Drawing.Size(101, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Apellidos"
        '
        'grpFiltros
        '
        Me.grpFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltros.Controls.Add(Me.CtrlPaciente1)
        Me.grpFiltros.Controls.Add(Me.Label4)
        Me.grpFiltros.Controls.Add(Me.grpFiltroAsociado)
        Me.grpFiltros.Controls.Add(Me.Label3)
        Me.grpFiltros.Controls.Add(Me.GroupBox1)
        Me.grpFiltros.Controls.Add(Me.txtApellido2)
        Me.grpFiltros.Controls.Add(Me.GroupBox2)
        Me.grpFiltros.Controls.Add(Me.txtApellido1)
        Me.grpFiltros.Controls.Add(Me.chkMostrarLineasImporte0)
        Me.grpFiltros.Controls.Add(Me.txtNombre)
        Me.grpFiltros.Location = New System.Drawing.Point(0, 28)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(821, 115)
        Me.grpFiltros.TabIndex = 140
        Me.grpFiltros.TabStop = False
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(12, 19)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(341, 50)
        Me.CtrlPaciente1.TabIndex = 133
        '
        'txtApellido2
        '
        Me.txtApellido2.AcceptsReturn = True
        Me.txtApellido2.Location = New System.Drawing.Point(340, 87)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(95, 20)
        Me.txtApellido2.TabIndex = 138
        '
        'txtApellido1
        '
        Me.txtApellido1.AcceptsReturn = True
        Me.txtApellido1.Location = New System.Drawing.Point(239, 87)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(95, 20)
        Me.txtApellido1.TabIndex = 138
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(67, 87)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(95, 20)
        Me.txtNombre.TabIndex = 138
        '
        'lblLoading
        '
        Me.lblLoading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoading.Location = New System.Drawing.Point(381, 219)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(193, 73)
        Me.lblLoading.TabIndex = 0
        Me.lblLoading.Text = "Cargando Odontograma, por favor espere..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoading.Visible = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(828, 39)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(117, 49)
        Me.btn_filtrar.TabIndex = 2
        Me.btn_filtrar.Text = "FILTRAR"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'frmDental_ListadoPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 456)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.grpFiltros)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSeleccionarLineas)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmDental_ListadoPresupuestos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuestos Dentales por Pacientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroAsociado.ResumeLayout(False)
        Me.grpFiltroAsociado.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltroAsociado As System.Windows.Forms.GroupBox
    Friend WithEvents rbCitasAsociados As System.Windows.Forms.RadioButton
    Friend WithEvents rbCitasTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCitasNoAsociados As System.Windows.Forms.RadioButton
    Public WithEvents btnSeleccionarLineas As System.Windows.Forms.Button
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents DPresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents chkRealizados As System.Windows.Forms.CheckBox
    Public WithEvents chkConfirmados As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarLineasImporte0 As System.Windows.Forms.CheckBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As ctrlTextboxAvanzado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As ctrlTextboxAvanzado
    Public WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
End Class
