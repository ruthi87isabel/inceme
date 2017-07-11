Namespace UI.Citas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCalendarioCitas
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
            Dim ScheduleCitas_DesignTimeLayout As Janus.Windows.Schedule.ScheduleLayout = New Janus.Windows.Schedule.ScheduleLayout()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendarioCitas))
            Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition2.FormatStyle.BackgroundImag" & _
            "e")
            Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition3.FormatStyle.BackgroundImag" & _
            "e")
            Dim GridEX1_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition4.FormatStyle.BackgroundImag" & _
            "e")
            Dim GridEXMedicos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Dim GridEXMutuas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Dim GridEXSalas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Dim GridEXNotas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tabCalendario = New System.Windows.Forms.TabPage()
            Me.ScheduleCitas = New Janus.Windows.Schedule.Schedule()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.TabListado = New System.Windows.Forms.TabPage()
            Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
            Me.rbPorSala = New System.Windows.Forms.RadioButton()
            Me.rbPorMedicos = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.Calendar2 = New Janus.Windows.Schedule.Calendar()
            Me.gb_pacientes = New System.Windows.Forms.GroupBox()
            Me.rb_pendientes = New System.Windows.Forms.RadioButton()
            Me.rb_atendidos = New System.Windows.Forms.RadioButton()
            Me.rb_todos = New System.Windows.Forms.RadioButton()
            Me.menu_citas = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ModificarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.BorrarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DuplicarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mi_cambiar = New System.Windows.Forms.ToolStripMenuItem()
            Me.mi_atendida = New System.Windows.Forms.ToolStripMenuItem()
            Me.mi_confirmada = New System.Windows.Forms.ToolStripMenuItem()
            Me.mi_falta = New System.Windows.Forms.ToolStripMenuItem()
            Me.mi_cobrada = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tstNuevaCitas = New System.Windows.Forms.ToolStripButton()
            Me.tstModificar = New System.Windows.Forms.ToolStripButton()
            Me.tstEliminar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.tstDuplicarCita = New System.Windows.Forms.ToolStripButton()
            Me.tstVer = New System.Windows.Forms.ToolStripButton()
            Me.tstImprimir = New System.Windows.Forms.ToolStripButton()
            Me.tstImprimirDetallado = New System.Windows.Forms.ToolStripButton()
            Me.tstImprimirJustificante = New System.Windows.Forms.ToolStripButton()
            Me.tlbPrev = New System.Windows.Forms.ToolBarButton()
            Me.tlbNext = New System.Windows.Forms.ToolBarButton()
            Me.tlbSep1 = New System.Windows.Forms.ToolBarButton()
            Me.tlbNew = New System.Windows.Forms.ToolBarButton()
            Me.tlbSave = New System.Windows.Forms.ToolBarButton()
            Me.tlbDelete = New System.Windows.Forms.ToolBarButton()
            Me.tlbSep2 = New System.Windows.Forms.ToolBarButton()
            Me.tlbDay = New System.Windows.Forms.ToolBarButton()
            Me.tlbWorkWeek = New System.Windows.Forms.ToolBarButton()
            Me.tlbWeek = New System.Windows.Forms.ToolBarButton()
            Me.tlbMonth = New System.Windows.Forms.ToolBarButton()
            Me.tlbSep3 = New System.Windows.Forms.ToolBarButton()
            Me.tlnPrintPreview = New System.Windows.Forms.ToolBarButton()
            Me.tlnPrint = New System.Windows.Forms.ToolBarButton()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.tlsAtendida = New System.Windows.Forms.ToolStripStatusLabel()
            Me.tlsConfirmada = New System.Windows.Forms.ToolStripStatusLabel()
            Me.tlsFalta = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.tlsPagadaFalta = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.tstSala = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.SchedulePrintDocument1 = New Janus.Windows.Schedule.SchedulePrintDocument()
            Me.TimerCitas = New System.Windows.Forms.Timer(Me.components)
            Me.GridEXMedicos = New Janus.Windows.GridEX.GridEX()
            Me.GridEXMutuas = New Janus.Windows.GridEX.GridEX()
            Me.MUTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.PanelIntervalo = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
            Me.GridEXExporter1 = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
            Me.GridEXSalas = New Janus.Windows.GridEX.GridEX()
            Me.SALABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GridEXNotas = New Janus.Windows.GridEX.GridEX()
            Me.NOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.btnNota_Agregar = New System.Windows.Forms.Button()
            Me.PanelNotas = New System.Windows.Forms.Panel()
            Me.btnNota_Delete = New System.Windows.Forms.Button()
            Me.btnNota_Editar = New System.Windows.Forms.Button()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.CBcitas = New System.Windows.Forms.ComboBox()
            Me.ListadoCitaDetalladoTableAdapter1 = New centro_medico.CM2DataSetTableAdapters.ListadoCitaDetalladoTableAdapter()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pbLoading = New System.Windows.Forms.PictureBox()
            Me.Rango = New System.Windows.Forms.Button()
            CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.tabCalendario.SuspendLayout()
            CType(Me.ScheduleCitas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabListado.SuspendLayout()
            CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Calendar2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gb_pacientes.SuspendLayout()
            Me.menu_citas.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.StatusStrip1.SuspendLayout()
            CType(Me.GridEXMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridEXMutuas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.PanelIntervalo.SuspendLayout()
            CType(Me.GridEXSalas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.GridEXNotas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelNotas.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CITABindingSource
            '
            Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.tabCalendario)
            Me.TabControl1.Controls.Add(Me.TabListado)
            Me.TabControl1.Location = New System.Drawing.Point(7, 28)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(703, 628)
            Me.TabControl1.TabIndex = 5
            '
            'tabCalendario
            '
            Me.tabCalendario.AutoScroll = True
            Me.tabCalendario.Controls.Add(Me.ScheduleCitas)
            Me.tabCalendario.Location = New System.Drawing.Point(4, 22)
            Me.tabCalendario.Name = "tabCalendario"
            Me.tabCalendario.Padding = New System.Windows.Forms.Padding(3)
            Me.tabCalendario.Size = New System.Drawing.Size(695, 602)
            Me.tabCalendario.TabIndex = 0
            Me.tabCalendario.Text = "Planning Visual"
            Me.tabCalendario.UseVisualStyleBackColor = True
            '
            'ScheduleCitas
            '
            Me.ScheduleCitas.AddNewMode = Janus.Windows.Schedule.AddNewMode.Manual
            Me.ScheduleCitas.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.None
            Me.ScheduleCitas.AllowDayResize = False
            Me.ScheduleCitas.AllowDelete = False
            Me.ScheduleCitas.AllowEdit = False
            Me.ScheduleCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ScheduleCitas.DataSource = Me.CITABindingSource
            Me.ScheduleCitas.Date = New Date(2010, 4, 19, 0, 0, 0, 0)
            Me.ScheduleCitas.DayColumns = 5
            Me.ScheduleCitas.DayEndHour = 17
            Me.ScheduleCitas.DayNavigationButtons = True
            Me.ScheduleCitas.DayStartHour = 8
            ScheduleCitas_DesignTimeLayout.DataSource = Me.CITABindingSource
            ScheduleCitas_DesignTimeLayout.LayoutString = resources.GetString("ScheduleCitas_DesignTimeLayout.LayoutString")
            Me.ScheduleCitas.DesignTimeLayout = ScheduleCitas_DesignTimeLayout
            Me.ScheduleCitas.EndTimeMember = "HORAFIN"
            Me.ScheduleCitas.FirstDayOfWeek = Janus.Windows.Schedule.ScheduleDayOfWeek.Monday
            Me.ScheduleCitas.ImageList = Me.ImageList1
            Me.ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
            Me.ScheduleCitas.Location = New System.Drawing.Point(8, 9)
            Me.ScheduleCitas.Name = "ScheduleCitas"
            Me.ScheduleCitas.OwnerDrawnArea = Janus.Windows.Schedule.OwnerDrawnArea.Appointments
            Me.ScheduleCitas.OwnerMember = "REFMEDICO"
            Me.ScheduleCitas.ShowAllDayArea = False
            Me.ScheduleCitas.ShowMinutesInTimeNavigator = True
            Me.ScheduleCitas.Size = New System.Drawing.Size(681, 587)
            Me.ScheduleCitas.StartTimeMember = "HORA"
            Me.ScheduleCitas.TabIndex = 2
            Me.ScheduleCitas.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours
            Me.ScheduleCitas.TimeNavigatorFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ScheduleCitas.TimeNavigatorFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(223, Byte), Integer))
            Me.ScheduleCitas.VisualStyle = Janus.Windows.Schedule.VisualStyle.VS2010
            Me.ScheduleCitas.VisualStyleAreas.AllDayAreaStyle = Janus.Windows.Schedule.VisualStyle.Office2003
            Me.ScheduleCitas.WorkStartTime = System.TimeSpan.Parse("07:00:00")
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "handshake.png")
            Me.ImageList1.Images.SetKeyName(1, "24-image.png")
            Me.ImageList1.Images.SetKeyName(2, "exclamation-octagon-fram-icon.png")
            Me.ImageList1.Images.SetKeyName(3, "1.png")
            Me.ImageList1.Images.SetKeyName(4, "2.png")
            Me.ImageList1.Images.SetKeyName(5, "3.png")
            '
            'TabListado
            '
            Me.TabListado.Controls.Add(Me.GridEX1)
            Me.TabListado.Location = New System.Drawing.Point(4, 22)
            Me.TabListado.Name = "TabListado"
            Me.TabListado.Padding = New System.Windows.Forms.Padding(3)
            Me.TabListado.Size = New System.Drawing.Size(695, 602)
            Me.TabListado.TabIndex = 1
            Me.TabListado.Text = "Listado"
            Me.TabListado.UseVisualStyleBackColor = True
            '
            'GridEX1
            '
            Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridEX1.ColumnAutoResize = True
            Me.GridEX1.DataSource = Me.CITABindingSource
            GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
            GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
            GridEX1_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"), Object)
            GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1, GridEX1_DesignTimeLayout_Reference_2})
            GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
            Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
            Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.GridEX1.GroupByBoxVisible = False
            Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
            Me.GridEX1.Hierarchical = True
            Me.GridEX1.Location = New System.Drawing.Point(6, 3)
            Me.GridEX1.Name = "GridEX1"
            Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
            Me.GridEX1.Size = New System.Drawing.Size(683, 593)
            Me.GridEX1.TabIndex = 130
            Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
            Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
            '
            'rbPorSala
            '
            Me.rbPorSala.AutoSize = True
            Me.rbPorSala.Location = New System.Drawing.Point(206, 16)
            Me.rbPorSala.Name = "rbPorSala"
            Me.rbPorSala.Size = New System.Drawing.Size(65, 17)
            Me.rbPorSala.TabIndex = 21
            Me.rbPorSala.Text = "Por Sala"
            Me.rbPorSala.UseVisualStyleBackColor = True
            '
            'rbPorMedicos
            '
            Me.rbPorMedicos.AutoSize = True
            Me.rbPorMedicos.Location = New System.Drawing.Point(122, 16)
            Me.rbPorMedicos.Name = "rbPorMedicos"
            Me.rbPorMedicos.Size = New System.Drawing.Size(79, 17)
            Me.rbPorMedicos.TabIndex = 21
            Me.rbPorMedicos.Text = "Por Médico"
            Me.rbPorMedicos.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Checked = True
            Me.rbTodas.Location = New System.Drawing.Point(59, 16)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(55, 17)
            Me.rbTodas.TabIndex = 21
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'Calendar2
            '
            Me.Calendar2.AllowDrop = True
            Me.Calendar2.FirstMonth = New Date(2010, 4, 1, 0, 0, 0, 0)
            Me.Calendar2.Location = New System.Drawing.Point(5, 6)
            Me.Calendar2.Name = "Calendar2"
            Me.Calendar2.Schedule = Me.ScheduleCitas
            Me.Calendar2.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule
            Me.Calendar2.Size = New System.Drawing.Size(148, 136)
            Me.Calendar2.TabIndex = 17
            '
            'gb_pacientes
            '
            Me.gb_pacientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gb_pacientes.Controls.Add(Me.rb_pendientes)
            Me.gb_pacientes.Controls.Add(Me.rb_atendidos)
            Me.gb_pacientes.Controls.Add(Me.rb_todos)
            Me.gb_pacientes.Location = New System.Drawing.Point(718, 49)
            Me.gb_pacientes.Name = "gb_pacientes"
            Me.gb_pacientes.Size = New System.Drawing.Size(285, 39)
            Me.gb_pacientes.TabIndex = 14
            Me.gb_pacientes.TabStop = False
            Me.gb_pacientes.Text = "Mostrar pacientes"
            '
            'rb_pendientes
            '
            Me.rb_pendientes.AutoSize = True
            Me.rb_pendientes.Location = New System.Drawing.Point(202, 16)
            Me.rb_pendientes.Name = "rb_pendientes"
            Me.rb_pendientes.Size = New System.Drawing.Size(78, 17)
            Me.rb_pendientes.TabIndex = 2
            Me.rb_pendientes.Text = "Pendientes"
            Me.rb_pendientes.UseVisualStyleBackColor = True
            '
            'rb_atendidos
            '
            Me.rb_atendidos.AutoSize = True
            Me.rb_atendidos.Location = New System.Drawing.Point(122, 16)
            Me.rb_atendidos.Name = "rb_atendidos"
            Me.rb_atendidos.Size = New System.Drawing.Size(72, 17)
            Me.rb_atendidos.TabIndex = 1
            Me.rb_atendidos.Text = "Atendidos"
            Me.rb_atendidos.UseVisualStyleBackColor = True
            '
            'rb_todos
            '
            Me.rb_todos.AutoSize = True
            Me.rb_todos.Checked = True
            Me.rb_todos.Location = New System.Drawing.Point(59, 16)
            Me.rb_todos.Name = "rb_todos"
            Me.rb_todos.Size = New System.Drawing.Size(55, 17)
            Me.rb_todos.TabIndex = 0
            Me.rb_todos.TabStop = True
            Me.rb_todos.Text = "Todos"
            Me.rb_todos.UseVisualStyleBackColor = True
            '
            'menu_citas
            '
            Me.menu_citas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerCitaToolStripMenuItem, Me.ModificarCitaToolStripMenuItem, Me.BorrarCitaToolStripMenuItem, Me.DuplicarCitaToolStripMenuItem, Me.ToolStripSeparator2, Me.mi_cambiar})
            Me.menu_citas.Name = "ContextMenuStrip1"
            Me.menu_citas.Size = New System.Drawing.Size(158, 120)
            '
            'VerCitaToolStripMenuItem
            '
            Me.VerCitaToolStripMenuItem.Image = Global.centro_medico.My.Resources.Resources._24_zoom
            Me.VerCitaToolStripMenuItem.Name = "VerCitaToolStripMenuItem"
            Me.VerCitaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
            Me.VerCitaToolStripMenuItem.Text = "Ver Cita"
            '
            'ModificarCitaToolStripMenuItem
            '
            Me.ModificarCitaToolStripMenuItem.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
            Me.ModificarCitaToolStripMenuItem.Name = "ModificarCitaToolStripMenuItem"
            Me.ModificarCitaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
            Me.ModificarCitaToolStripMenuItem.Text = "Modificar Cita"
            '
            'BorrarCitaToolStripMenuItem
            '
            Me.BorrarCitaToolStripMenuItem.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
            Me.BorrarCitaToolStripMenuItem.Name = "BorrarCitaToolStripMenuItem"
            Me.BorrarCitaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
            Me.BorrarCitaToolStripMenuItem.Text = "Borrar Cita"
            '
            'DuplicarCitaToolStripMenuItem
            '
            Me.DuplicarCitaToolStripMenuItem.Image = Global.centro_medico.My.Resources.Resources._24_imageset
            Me.DuplicarCitaToolStripMenuItem.Name = "DuplicarCitaToolStripMenuItem"
            Me.DuplicarCitaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
            Me.DuplicarCitaToolStripMenuItem.Text = "Duplicar Cita"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(154, 6)
            '
            'mi_cambiar
            '
            Me.mi_cambiar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_atendida, Me.mi_confirmada, Me.mi_falta, Me.mi_cobrada})
            Me.mi_cambiar.Name = "mi_cambiar"
            Me.mi_cambiar.RightToLeftAutoMirrorImage = True
            Me.mi_cambiar.Size = New System.Drawing.Size(157, 22)
            Me.mi_cambiar.Text = "Cambiar estado"
            '
            'mi_atendida
            '
            Me.mi_atendida.CheckOnClick = True
            Me.mi_atendida.Name = "mi_atendida"
            Me.mi_atendida.Size = New System.Drawing.Size(137, 22)
            Me.mi_atendida.Text = "Atendida"
            '
            'mi_confirmada
            '
            Me.mi_confirmada.CheckOnClick = True
            Me.mi_confirmada.Name = "mi_confirmada"
            Me.mi_confirmada.Size = New System.Drawing.Size(137, 22)
            Me.mi_confirmada.Text = "Confirmada"
            '
            'mi_falta
            '
            Me.mi_falta.CheckOnClick = True
            Me.mi_falta.Name = "mi_falta"
            Me.mi_falta.Size = New System.Drawing.Size(137, 22)
            Me.mi_falta.Text = "Falta"
            '
            'mi_cobrada
            '
            Me.mi_cobrada.CheckOnClick = True
            Me.mi_cobrada.Name = "mi_cobrada"
            Me.mi_cobrada.Size = New System.Drawing.Size(137, 22)
            Me.mi_cobrada.Text = "Cobrada"
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevaCitas, Me.tstModificar, Me.tstEliminar, Me.ToolStripSeparator1, Me.tstDuplicarCita, Me.tstVer, Me.tstImprimir, Me.tstImprimirDetallado, Me.tstImprimirJustificante})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(691, 25)
            Me.ToolStrip1.TabIndex = 6
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'tstNuevaCitas
            '
            Me.tstNuevaCitas.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
            Me.tstNuevaCitas.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstNuevaCitas.Name = "tstNuevaCitas"
            Me.tstNuevaCitas.Size = New System.Drawing.Size(85, 22)
            Me.tstNuevaCitas.Text = "&Nueva Cita"
            '
            'tstModificar
            '
            Me.tstModificar.Enabled = False
            Me.tstModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
            Me.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstModificar.Name = "tstModificar"
            Me.tstModificar.Size = New System.Drawing.Size(102, 22)
            Me.tstModificar.Text = "&Modificar Cita"
            '
            'tstEliminar
            '
            Me.tstEliminar.Enabled = False
            Me.tstEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
            Me.tstEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstEliminar.Name = "tstEliminar"
            Me.tstEliminar.Size = New System.Drawing.Size(70, 22)
            Me.tstEliminar.Text = "&Eliminar"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'tstDuplicarCita
            '
            Me.tstDuplicarCita.Enabled = False
            Me.tstDuplicarCita.Image = Global.centro_medico.My.Resources.Resources._24_imageset
            Me.tstDuplicarCita.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstDuplicarCita.Name = "tstDuplicarCita"
            Me.tstDuplicarCita.Size = New System.Drawing.Size(95, 22)
            Me.tstDuplicarCita.Text = "&Duplicar Cita"
            '
            'tstVer
            '
            Me.tstVer.Enabled = False
            Me.tstVer.Image = Global.centro_medico.My.Resources.Resources._24_zoom
            Me.tstVer.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstVer.Name = "tstVer"
            Me.tstVer.Size = New System.Drawing.Size(44, 22)
            Me.tstVer.Text = "&Ver"
            '
            'tstImprimir
            '
            Me.tstImprimir.Image = Global.centro_medico.My.Resources.Resources.Print
            Me.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstImprimir.Name = "tstImprimir"
            Me.tstImprimir.Size = New System.Drawing.Size(73, 22)
            Me.tstImprimir.Text = "&Imprimir"
            '
            'tstImprimirDetallado
            '
            Me.tstImprimirDetallado.Image = Global.centro_medico.My.Resources.Resources.Print
            Me.tstImprimirDetallado.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstImprimirDetallado.Name = "tstImprimirDetallado"
            Me.tstImprimirDetallado.Size = New System.Drawing.Size(126, 22)
            Me.tstImprimirDetallado.Text = "&Imprimir Detallado"
            '
            'tstImprimirJustificante
            '
            Me.tstImprimirJustificante.Image = Global.centro_medico.My.Resources.Resources.Print
            Me.tstImprimirJustificante.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tstImprimirJustificante.Name = "tstImprimirJustificante"
            Me.tstImprimirJustificante.Size = New System.Drawing.Size(78, 22)
            Me.tstImprimirJustificante.Text = "&Impr. Just"
            '
            'tlbPrev
            '
            Me.tlbPrev.ImageIndex = 0
            Me.tlbPrev.Name = "tlbPrev"
            Me.tlbPrev.ToolTipText = "Previous Date"
            '
            'tlbNext
            '
            Me.tlbNext.ImageIndex = 1
            Me.tlbNext.Name = "tlbNext"
            Me.tlbNext.ToolTipText = "Next Date"
            '
            'tlbSep1
            '
            Me.tlbSep1.Name = "tlbSep1"
            Me.tlbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            '
            'tlbNew
            '
            Me.tlbNew.ImageIndex = 2
            Me.tlbNew.Name = "tlbNew"
            Me.tlbNew.Text = "New Appointment"
            '
            'tlbSave
            '
            Me.tlbSave.ImageIndex = 4
            Me.tlbSave.Name = "tlbSave"
            Me.tlbSave.Text = "Save"
            Me.tlbSave.ToolTipText = "Save"
            '
            'tlbDelete
            '
            Me.tlbDelete.Enabled = False
            Me.tlbDelete.ImageIndex = 3
            Me.tlbDelete.Name = "tlbDelete"
            '
            'tlbSep2
            '
            Me.tlbSep2.Name = "tlbSep2"
            Me.tlbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            '
            'tlbDay
            '
            Me.tlbDay.ImageIndex = 5
            Me.tlbDay.Name = "tlbDay"
            Me.tlbDay.Pushed = True
            Me.tlbDay.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tlbDay.Text = "Day"
            Me.tlbDay.ToolTipText = "Day"
            '
            'tlbWorkWeek
            '
            Me.tlbWorkWeek.ImageIndex = 6
            Me.tlbWorkWeek.Name = "tlbWorkWeek"
            Me.tlbWorkWeek.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tlbWorkWeek.Text = "Work Week"
            Me.tlbWorkWeek.ToolTipText = "Work Week"
            '
            'tlbWeek
            '
            Me.tlbWeek.ImageIndex = 7
            Me.tlbWeek.Name = "tlbWeek"
            Me.tlbWeek.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tlbWeek.Text = "Week"
            Me.tlbWeek.ToolTipText = "Week"
            '
            'tlbMonth
            '
            Me.tlbMonth.ImageIndex = 8
            Me.tlbMonth.Name = "tlbMonth"
            Me.tlbMonth.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tlbMonth.Text = "Month"
            Me.tlbMonth.ToolTipText = "Month"
            '
            'tlbSep3
            '
            Me.tlbSep3.Name = "tlbSep3"
            Me.tlbSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            '
            'tlnPrintPreview
            '
            Me.tlnPrintPreview.ImageIndex = 9
            Me.tlnPrintPreview.Name = "tlnPrintPreview"
            Me.tlnPrintPreview.ToolTipText = "Print Preview"
            '
            'tlnPrint
            '
            Me.tlnPrint.ImageIndex = 10
            Me.tlnPrint.Name = "tlnPrint"
            Me.tlnPrint.ToolTipText = "Print"
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 7.5!)
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsAtendida, Me.tlsConfirmada, Me.tlsFalta, Me.ToolStripStatusLabel6, Me.tlsPagadaFalta, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel10, Me.tstSala, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(1008, 25)
            Me.StatusStrip1.TabIndex = 13
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'tlsAtendida
            '
            Me.tlsAtendida.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.tlsAtendida.Name = "tlsAtendida"
            Me.tlsAtendida.Size = New System.Drawing.Size(45, 20)
            Me.tlsAtendida.Text = "Atendida"
            '
            'tlsConfirmada
            '
            Me.tlsConfirmada.BackColor = System.Drawing.Color.Silver
            Me.tlsConfirmada.Name = "tlsConfirmada"
            Me.tlsConfirmada.Size = New System.Drawing.Size(57, 20)
            Me.tlsConfirmada.Text = "Confirmada"
            '
            'tlsFalta
            '
            Me.tlsFalta.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(100, Byte), Integer))
            Me.tlsFalta.Name = "tlsFalta"
            Me.tlsFalta.Size = New System.Drawing.Size(67, 20)
            Me.tlsFalta.Text = "Anulada/Falta"
            '
            'ToolStripStatusLabel6
            '
            Me.ToolStripStatusLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
            Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(44, 20)
            Me.ToolStripStatusLabel6.Text = "Cobrada"
            '
            'tlsPagadaFalta
            '
            Me.tlsPagadaFalta.BackColor = System.Drawing.Color.LightGreen
            Me.tlsPagadaFalta.ForeColor = System.Drawing.Color.Red
            Me.tlsPagadaFalta.Name = "tlsPagadaFalta"
            Me.tlsPagadaFalta.Size = New System.Drawing.Size(63, 20)
            Me.tlsPagadaFalta.Text = "Pagada-Falta"
            '
            'ToolStripStatusLabel9
            '
            Me.ToolStripStatusLabel9.AutoSize = False
            Me.ToolStripStatusLabel9.BackColor = System.Drawing.Color.White
            Me.ToolStripStatusLabel9.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.ToolStripStatusLabel9.Image = Global.centro_medico.My.Resources.Resources.handshake
            Me.ToolStripStatusLabel9.Margin = New System.Windows.Forms.Padding(2, 3, 1, 2)
            Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
            Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(58, 20)
            Me.ToolStripStatusLabel9.Text = "Mutua"
            '
            'ToolStripStatusLabel10
            '
            Me.ToolStripStatusLabel10.AutoSize = False
            Me.ToolStripStatusLabel10.BackColor = System.Drawing.Color.White
            Me.ToolStripStatusLabel10.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.ToolStripStatusLabel10.Image = Global.centro_medico.My.Resources.Resources.exclamation_octagon_fram_icon
            Me.ToolStripStatusLabel10.Margin = New System.Windows.Forms.Padding(1, 3, 2, 2)
            Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
            Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(110, 20)
            Me.ToolStripStatusLabel10.Text = "Fuera de horario"
            '
            'tstSala
            '
            Me.tstSala.BackColor = System.Drawing.Color.White
            Me.tstSala.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.tstSala.ForeColor = System.Drawing.Color.Black
            Me.tstSala.Image = Global.centro_medico.My.Resources.Resources._24_image
            Me.tstSala.Margin = New System.Windows.Forms.Padding(2, 3, 2, 2)
            Me.tstSala.Name = "tstSala"
            Me.tstSala.Size = New System.Drawing.Size(58, 20)
            Me.tstSala.Text = "En Sala"
            Me.tstSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ToolStripStatusLabel1
            '
            Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
            Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(102, 20)
            Me.ToolStripStatusLabel1.Text = "Alt+N -> Nueva Cita"
            '
            'ToolStripStatusLabel2
            '
            Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
            Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 20)
            Me.ToolStripStatusLabel2.Text = "Alt+p-> Nueva Cita Multp"
            Me.ToolStripStatusLabel2.Visible = False
            '
            'ToolStripStatusLabel3
            '
            Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
            Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(87, 20)
            Me.ToolStripStatusLabel3.Text = "Alt+M-> Modificar"
            '
            'ToolStripStatusLabel4
            '
            Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
            Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(73, 20)
            Me.ToolStripStatusLabel4.Text = "Alt+B-> Borrar"
            '
            'ToolStripStatusLabel5
            '
            Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
            Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(80, 20)
            Me.ToolStripStatusLabel5.Text = "Alt+I-> Imprimir"
            '
            'ToolStripStatusLabel7
            '
            Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
            Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(59, 20)
            Me.ToolStripStatusLabel7.Text = "Alt+V-> Ver"
            '
            'ToolStripStatusLabel8
            '
            Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
            Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(78, 20)
            Me.ToolStripStatusLabel8.Text = "Alt+F4-> Cerrar"
            '
            'SchedulePrintDocument1
            '
            Me.SchedulePrintDocument1.DocumentName = "Listado Gráfico"
            Me.SchedulePrintDocument1.FooterRight = "23/06/2009"
            Me.SchedulePrintDocument1.LayoutPages = Janus.Windows.Schedule.LayoutPages.TwoPages
            Me.SchedulePrintDocument1.Schedule = Me.ScheduleCitas
            Me.SchedulePrintDocument1.ShowDateHeader = False
            '
            'TimerCitas
            '
            Me.TimerCitas.Interval = 10000
            '
            'GridEXMedicos
            '
            Me.GridEXMedicos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridEXMedicos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridEXMedicos.ColumnAutoResize = True
            GridEXMedicos_DesignTimeLayout.LayoutString = resources.GetString("GridEXMedicos_DesignTimeLayout.LayoutString")
            Me.GridEXMedicos.DesignTimeLayout = GridEXMedicos_DesignTimeLayout
            Me.GridEXMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.GridEXMedicos.GroupByBoxVisible = False
            Me.GridEXMedicos.Location = New System.Drawing.Point(716, 232)
            Me.GridEXMedicos.Name = "GridEXMedicos"
            Me.GridEXMedicos.Size = New System.Drawing.Size(284, 148)
            Me.GridEXMedicos.TabIndex = 21
            '
            'GridEXMutuas
            '
            Me.GridEXMutuas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridEXMutuas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridEXMutuas.ColumnAutoResize = True
            Me.GridEXMutuas.DataSource = Me.MUTUABindingSource
            GridEXMutuas_DesignTimeLayout.LayoutString = resources.GetString("GridEXMutuas_DesignTimeLayout.LayoutString")
            Me.GridEXMutuas.DesignTimeLayout = GridEXMutuas_DesignTimeLayout
            Me.GridEXMutuas.GroupByBoxVisible = False
            Me.GridEXMutuas.Location = New System.Drawing.Point(717, 385)
            Me.GridEXMutuas.Name = "GridEXMutuas"
            Me.GridEXMutuas.Size = New System.Drawing.Size(283, 104)
            Me.GridEXMutuas.TabIndex = 21
            '
            'MUTUABindingSource
            '
            Me.MUTUABindingSource.DataSource = GetType(centro_medico.MUTUA)
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.Controls.Add(Me.Calendar2)
            Me.Panel1.Location = New System.Drawing.Point(713, 86)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(171, 146)
            Me.Panel1.TabIndex = 22
            '
            'PanelIntervalo
            '
            Me.PanelIntervalo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PanelIntervalo.Controls.Add(Me.Label2)
            Me.PanelIntervalo.Controls.Add(Me.Label1)
            Me.PanelIntervalo.Controls.Add(Me.dtpFechaFinal)
            Me.PanelIntervalo.Controls.Add(Me.dtpFechaInicio)
            Me.PanelIntervalo.Location = New System.Drawing.Point(720, 100)
            Me.PanelIntervalo.Name = "PanelIntervalo"
            Me.PanelIntervalo.Size = New System.Drawing.Size(153, 61)
            Me.PanelIntervalo.TabIndex = 23
            Me.PanelIntervalo.Visible = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Hasta:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(0, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(41, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Desde:"
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaFinal.Location = New System.Drawing.Point(47, 29)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(95, 20)
            Me.dtpFechaFinal.TabIndex = 0
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaInicio.Location = New System.Drawing.Point(47, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(95, 20)
            Me.dtpFechaInicio.TabIndex = 0
            '
            'GridEXSalas
            '
            Me.GridEXSalas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridEXSalas.AutoEdit = True
            Me.GridEXSalas.ColumnAutoResize = True
            Me.GridEXSalas.DataSource = Me.SALABindingSource
            GridEXSalas_DesignTimeLayout.LayoutString = resources.GetString("GridEXSalas_DesignTimeLayout.LayoutString")
            Me.GridEXSalas.DesignTimeLayout = GridEXSalas_DesignTimeLayout
            Me.GridEXSalas.GroupByBoxVisible = False
            Me.GridEXSalas.Location = New System.Drawing.Point(717, 494)
            Me.GridEXSalas.Name = "GridEXSalas"
            Me.GridEXSalas.Size = New System.Drawing.Size(283, 77)
            Me.GridEXSalas.TabIndex = 24
            '
            'SALABindingSource
            '
            Me.SALABindingSource.DataSource = GetType(centro_medico.SALA)
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.rbPorMedicos)
            Me.GroupBox1.Controls.Add(Me.rbPorSala)
            Me.GroupBox1.Controls.Add(Me.rbTodas)
            Me.GroupBox1.Location = New System.Drawing.Point(718, 10)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(285, 39)
            Me.GroupBox1.TabIndex = 25
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Filtrar citas"
            '
            'GridEXNotas
            '
            Me.GridEXNotas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridEXNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridEXNotas.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
            Me.GridEXNotas.ColumnAutoResize = True
            Me.GridEXNotas.DataSource = Me.NOTABindingSource
            GridEXNotas_DesignTimeLayout.LayoutString = resources.GetString("GridEXNotas_DesignTimeLayout.LayoutString")
            Me.GridEXNotas.DesignTimeLayout = GridEXNotas_DesignTimeLayout
            Me.GridEXNotas.GroupByBoxVisible = False
            Me.GridEXNotas.Location = New System.Drawing.Point(3, 18)
            Me.GridEXNotas.Name = "GridEXNotas"
            Me.GridEXNotas.Size = New System.Drawing.Size(279, 58)
            Me.GridEXNotas.TabIndex = 26
            '
            'NOTABindingSource
            '
            Me.NOTABindingSource.DataSource = GetType(centro_medico.NOTA)
            '
            'btnNota_Agregar
            '
            Me.btnNota_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNota_Agregar.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
            Me.btnNota_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnNota_Agregar.FlatAppearance.BorderSize = 0
            Me.btnNota_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNota_Agregar.Location = New System.Drawing.Point(227, 1)
            Me.btnNota_Agregar.Margin = New System.Windows.Forms.Padding(0)
            Me.btnNota_Agregar.Name = "btnNota_Agregar"
            Me.btnNota_Agregar.Size = New System.Drawing.Size(14, 16)
            Me.btnNota_Agregar.TabIndex = 27
            Me.btnNota_Agregar.UseVisualStyleBackColor = True
            '
            'PanelNotas
            '
            Me.PanelNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PanelNotas.Controls.Add(Me.GridEXNotas)
            Me.PanelNotas.Controls.Add(Me.btnNota_Delete)
            Me.PanelNotas.Controls.Add(Me.btnNota_Editar)
            Me.PanelNotas.Controls.Add(Me.btnNota_Agregar)
            Me.PanelNotas.Location = New System.Drawing.Point(714, 576)
            Me.PanelNotas.Name = "PanelNotas"
            Me.PanelNotas.Size = New System.Drawing.Size(286, 76)
            Me.PanelNotas.TabIndex = 3
            '
            'btnNota_Delete
            '
            Me.btnNota_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNota_Delete.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
            Me.btnNota_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnNota_Delete.FlatAppearance.BorderSize = 0
            Me.btnNota_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNota_Delete.Location = New System.Drawing.Point(268, 1)
            Me.btnNota_Delete.Margin = New System.Windows.Forms.Padding(0)
            Me.btnNota_Delete.Name = "btnNota_Delete"
            Me.btnNota_Delete.Size = New System.Drawing.Size(14, 16)
            Me.btnNota_Delete.TabIndex = 27
            Me.btnNota_Delete.UseVisualStyleBackColor = True
            '
            'btnNota_Editar
            '
            Me.btnNota_Editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNota_Editar.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_tag_pencil
            Me.btnNota_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnNota_Editar.FlatAppearance.BorderSize = 0
            Me.btnNota_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNota_Editar.Location = New System.Drawing.Point(248, 1)
            Me.btnNota_Editar.Margin = New System.Windows.Forms.Padding(0)
            Me.btnNota_Editar.Name = "btnNota_Editar"
            Me.btnNota_Editar.Size = New System.Drawing.Size(14, 16)
            Me.btnNota_Editar.TabIndex = 27
            Me.btnNota_Editar.UseVisualStyleBackColor = True
            '
            'Label17
            '
            Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(728, 165)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(64, 13)
            Me.Label17.TabIndex = 216
            Me.Label17.Text = "Tipo de Cita"
            Me.Label17.Visible = False
            '
            'CBcitas
            '
            Me.CBcitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CBcitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CBcitas.FormattingEnabled = True
            Me.CBcitas.Items.AddRange(New Object() {"", "1ra Cita", "2da Cita", "3ra Cita"})
            Me.CBcitas.Location = New System.Drawing.Point(728, 182)
            Me.CBcitas.Name = "CBcitas"
            Me.CBcitas.Size = New System.Drawing.Size(121, 21)
            Me.CBcitas.TabIndex = 215
            Me.CBcitas.Visible = False
            '
            'ListadoCitaDetalladoTableAdapter1
            '
            Me.ListadoCitaDetalladoTableAdapter1.ClearBeforeFill = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.pbLoading)
            Me.GroupBox2.Controls.Add(Me.Rango)
            Me.GroupBox2.Location = New System.Drawing.Point(890, 87)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(113, 141)
            Me.GroupBox2.TabIndex = 219
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Rango fecha"
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker2.Location = New System.Drawing.Point(6, 78)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(101, 20)
            Me.DateTimePicker2.TabIndex = 219
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker1.Location = New System.Drawing.Point(6, 38)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
            Me.DateTimePicker1.TabIndex = 221
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 64)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(38, 13)
            Me.Label4.TabIndex = 224
            Me.Label4.Text = "Hasta:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 24)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(41, 13)
            Me.Label3.TabIndex = 223
            Me.Label3.Text = "Desde:"
            '
            'pbLoading
            '
            Me.pbLoading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
            Me.pbLoading.Location = New System.Drawing.Point(6, 102)
            Me.pbLoading.Name = "pbLoading"
            Me.pbLoading.Size = New System.Drawing.Size(37, 37)
            Me.pbLoading.TabIndex = 220
            Me.pbLoading.TabStop = False
            Me.pbLoading.Visible = False
            '
            'Rango
            '
            Me.Rango.Location = New System.Drawing.Point(57, 112)
            Me.Rango.Name = "Rango"
            Me.Rango.Size = New System.Drawing.Size(50, 23)
            Me.Rango.TabIndex = 222
            Me.Rango.Text = "Rango"
            Me.Rango.UseVisualStyleBackColor = True
            '
            'frmCalendarioCitas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1008, 684)
            Me.Controls.Add(Me.gb_pacientes)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.CBcitas)
            Me.Controls.Add(Me.PanelNotas)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GridEXSalas)
            Me.Controls.Add(Me.PanelIntervalo)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GridEXMedicos)
            Me.Controls.Add(Me.GridEXMutuas)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.TabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmCalendarioCitas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Calendario de Citas"
            CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.tabCalendario.ResumeLayout(False)
            CType(Me.ScheduleCitas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabListado.ResumeLayout(False)
            CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Calendar2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gb_pacientes.ResumeLayout(False)
            Me.gb_pacientes.PerformLayout()
            Me.menu_citas.ResumeLayout(False)
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            CType(Me.GridEXMedicos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridEXMutuas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.PanelIntervalo.ResumeLayout(False)
            Me.PanelIntervalo.PerformLayout()
            CType(Me.GridEXSalas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.GridEXNotas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelNotas.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tabCalendario As System.Windows.Forms.TabPage
        Friend WithEvents ScheduleCitas As Janus.Windows.Schedule.Schedule
        Friend WithEvents TabListado As System.Windows.Forms.TabPage
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents tstNuevaCitas As System.Windows.Forms.ToolStripButton
        Friend WithEvents tstModificar As System.Windows.Forms.ToolStripButton
        Friend WithEvents tstEliminar As System.Windows.Forms.ToolStripButton
        Friend WithEvents tstImprimir As System.Windows.Forms.ToolStripButton
        Friend WithEvents tlbPrev As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbNext As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbSep1 As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbNew As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbSave As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbDelete As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbSep2 As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbDay As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbWorkWeek As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbWeek As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbMonth As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlbSep3 As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlnPrintPreview As System.Windows.Forms.ToolBarButton
        Friend WithEvents tlnPrint As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents gb_pacientes As System.Windows.Forms.GroupBox
        Friend WithEvents rb_pendientes As System.Windows.Forms.RadioButton
        Friend WithEvents rb_atendidos As System.Windows.Forms.RadioButton
        Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
        Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
        Friend WithEvents tlsAtendida As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents tlsConfirmada As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents tlsFalta As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents tstVer As System.Windows.Forms.ToolStripButton
        Friend WithEvents menu_citas As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ModificarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents BorrarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DuplicarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mi_cambiar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mi_atendida As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mi_confirmada As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mi_falta As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mi_cobrada As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Calendar2 As Janus.Windows.Schedule.Calendar
        Friend WithEvents tstDuplicarCita As System.Windows.Forms.ToolStripButton
        Friend WithEvents SchedulePrintDocument1 As Janus.Windows.Schedule.SchedulePrintDocument
        Friend WithEvents TimerCitas As System.Windows.Forms.Timer
        Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
        Friend WithEvents GridEXMedicos As Janus.Windows.GridEX.GridEX
        Friend WithEvents GridEXMutuas As Janus.Windows.GridEX.GridEX
        Friend WithEvents MUTUABindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Public WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents PanelIntervalo As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents GridEXExporter1 As Janus.Windows.GridEX.Export.GridEXExporter
        Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents tstSala As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents GridEXSalas As Janus.Windows.GridEX.GridEX
        Friend WithEvents SALABindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents rbPorSala As System.Windows.Forms.RadioButton
        Friend WithEvents rbPorMedicos As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents GridEXNotas As Janus.Windows.GridEX.GridEX
        Friend WithEvents NOTABindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents btnNota_Agregar As System.Windows.Forms.Button
        Friend WithEvents PanelNotas As System.Windows.Forms.Panel
        Friend WithEvents btnNota_Delete As System.Windows.Forms.Button
        Friend WithEvents btnNota_Editar As System.Windows.Forms.Button
        Friend WithEvents tstImprimirJustificante As System.Windows.Forms.ToolStripButton
        Friend WithEvents tlsPagadaFalta As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents CBcitas As System.Windows.Forms.ComboBox
        Friend WithEvents tstImprimirDetallado As System.Windows.Forms.ToolStripButton
        Friend WithEvents ListadoCitaDetalladoTableAdapter1 As centro_medico.CM2DataSetTableAdapters.ListadoCitaDetalladoTableAdapter
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
        Friend WithEvents Rango As System.Windows.Forms.Button
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace