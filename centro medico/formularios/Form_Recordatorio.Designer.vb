<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Recordatorio
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
        Dim LbFecha As System.Windows.Forms.Label
        Dim LbHora As System.Windows.Forms.Label
        Dim LbTexto As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ScheduleRecordatorio_DesignTimeLayout As Janus.Windows.Schedule.ScheduleLayout = New Janus.Windows.Schedule.ScheduleLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Recordatorio))
        Me.BsRecordatorio = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleRecordatorio = New Janus.Windows.Schedule.Schedule()
        Me.Calendar2 = New Janus.Windows.Schedule.Calendar()
        Me.tb_hora = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToggleSwitch1 = New JCS.ToggleSwitch()
        Me.TbAsunto = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TbAnotacion = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbAñadir = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        LbFecha = New System.Windows.Forms.Label()
        LbHora = New System.Windows.Forms.Label()
        LbTexto = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BsRecordatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleRecordatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calendar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbFecha
        '
        LbFecha.AutoSize = True
        LbFecha.Location = New System.Drawing.Point(8, 25)
        LbFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LbFecha.Name = "LbFecha"
        LbFecha.Size = New System.Drawing.Size(51, 17)
        LbFecha.TabIndex = 71
        LbFecha.Text = "Fecha:"
        '
        'LbHora
        '
        LbHora.AutoSize = True
        LbHora.Location = New System.Drawing.Point(137, 26)
        LbHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LbHora.Name = "LbHora"
        LbHora.Size = New System.Drawing.Size(43, 17)
        LbHora.TabIndex = 73
        LbHora.Text = "Hora:"
        '
        'LbTexto
        '
        LbTexto.AutoSize = True
        LbTexto.Location = New System.Drawing.Point(8, 123)
        LbTexto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LbTexto.Name = "LbTexto"
        LbTexto.Size = New System.Drawing.Size(75, 17)
        LbTexto.TabIndex = 76
        LbTexto.Text = "Anotación:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 73)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 17)
        Label1.TabIndex = 100
        Label1.Text = "Asunto:"
        '
        'ScheduleRecordatorio
        '
        Me.ScheduleRecordatorio.AddNewMode = Janus.Windows.Schedule.AddNewMode.Manual
        Me.ScheduleRecordatorio.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.None
        Me.ScheduleRecordatorio.AllowDayResize = False
        Me.ScheduleRecordatorio.AllowDelete = False
        Me.ScheduleRecordatorio.AllowEdit = False
        Me.ScheduleRecordatorio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScheduleRecordatorio.DataSource = Me.BsRecordatorio
        Me.ScheduleRecordatorio.Date = New Date(2017, 3, 14, 0, 0, 0, 0)
        Me.ScheduleRecordatorio.DayColumns = 5
        Me.ScheduleRecordatorio.DayEndHour = 17
        Me.ScheduleRecordatorio.DayNavigationButtons = True
        Me.ScheduleRecordatorio.DayStartHour = 8
        ScheduleRecordatorio_DesignTimeLayout.DataSource = Me.BsRecordatorio
        ScheduleRecordatorio_DesignTimeLayout.LayoutString = resources.GetString("ScheduleRecordatorio_DesignTimeLayout.LayoutString")
        Me.ScheduleRecordatorio.DesignTimeLayout = ScheduleRecordatorio_DesignTimeLayout
        Me.ScheduleRecordatorio.FirstDayOfWeek = Janus.Windows.Schedule.ScheduleDayOfWeek.Monday
        Me.ScheduleRecordatorio.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
        Me.ScheduleRecordatorio.Location = New System.Drawing.Point(13, 31)
        Me.ScheduleRecordatorio.Margin = New System.Windows.Forms.Padding(4)
        Me.ScheduleRecordatorio.Name = "ScheduleRecordatorio"
        Me.ScheduleRecordatorio.OwnerDrawnArea = Janus.Windows.Schedule.OwnerDrawnArea.Appointments
        Me.ScheduleRecordatorio.ShowAllDayArea = False
        Me.ScheduleRecordatorio.ShowMinutesInTimeNavigator = True
        Me.ScheduleRecordatorio.ShowTimeHintOnAppointments = Janus.Windows.Schedule.TimeHintOnAppointments.Never
        Me.ScheduleRecordatorio.Size = New System.Drawing.Size(730, 615)
        Me.ScheduleRecordatorio.StartTimeMember = "HORA"
        Me.ScheduleRecordatorio.TabIndex = 3
        Me.ScheduleRecordatorio.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours
        Me.ScheduleRecordatorio.TimeNavigatorFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ScheduleRecordatorio.TimeNavigatorFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ScheduleRecordatorio.VisualStyle = Janus.Windows.Schedule.VisualStyle.VS2010
        Me.ScheduleRecordatorio.VisualStyleAreas.AllDayAreaStyle = Janus.Windows.Schedule.VisualStyle.Office2003
        Me.ScheduleRecordatorio.WorkStartTime = System.TimeSpan.Parse("07:00:00")
        '
        'Calendar2
        '
        Me.Calendar2.AllowDrop = True
        Me.Calendar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendar2.FirstMonth = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.Calendar2.Location = New System.Drawing.Point(796, 36)
        Me.Calendar2.Margin = New System.Windows.Forms.Padding(4)
        Me.Calendar2.Name = "Calendar2"
        Me.Calendar2.Schedule = Me.ScheduleRecordatorio
        Me.Calendar2.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule
        Me.Calendar2.Size = New System.Drawing.Size(184, 168)
        Me.Calendar2.TabIndex = 18
        '
        'tb_hora
        '
        Me.tb_hora.CustomFormat = "HH:mm"
        Me.tb_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_hora.Location = New System.Drawing.Point(140, 46)
        Me.tb_hora.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_hora.Name = "tb_hora"
        Me.tb_hora.ShowUpDown = True
        Me.tb_hora.Size = New System.Drawing.Size(76, 22)
        Me.tb_hora.TabIndex = 74
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(11, 46)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(112, 22)
        Me.dtp_fecha.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ToggleSwitch1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TbAsunto)
        Me.GroupBox1.Controls.Add(Me.BtnAceptar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(LbTexto)
        Me.GroupBox1.Controls.Add(Me.TbAnotacion)
        Me.GroupBox1.Controls.Add(Me.tb_hora)
        Me.GroupBox1.Controls.Add(LbHora)
        Me.GroupBox1.Controls.Add(LbFecha)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(751, 212)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(313, 427)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Recordatorio"
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Checked = True
        Me.ToggleSwitch1.Location = New System.Drawing.Point(235, 46)
        Me.ToggleSwitch1.Margin = New System.Windows.Forms.Padding(4)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.OffFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSwitch1.OnFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSwitch1.Size = New System.Drawing.Size(67, 23)
        Me.ToggleSwitch1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy
        Me.ToggleSwitch1.TabIndex = 101
        '
        'TbAsunto
        '
        Me.TbAsunto.Location = New System.Drawing.Point(11, 94)
        Me.TbAsunto.Name = "TbAsunto"
        Me.TbAsunto.Size = New System.Drawing.Size(291, 22)
        Me.TbAsunto.TabIndex = 99
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.centro_medico.My.Resources.Resources.Checked
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(14, 392)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 30)
        Me.BtnAceptar.TabIndex = 98
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.centro_medico.My.Resources.Resources.new_delete
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(197, 392)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 97
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TbAnotacion
        '
        Me.TbAnotacion.Location = New System.Drawing.Point(10, 144)
        Me.TbAnotacion.Multiline = True
        Me.TbAnotacion.Name = "TbAnotacion"
        Me.TbAnotacion.Size = New System.Drawing.Size(292, 241)
        Me.TbAnotacion.TabIndex = 75
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAñadir, Me.tsbModificar, Me.tsbEliminar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(261, 27)
        Me.ToolStrip2.TabIndex = 100
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbAñadir
        '
        Me.tsbAñadir.Image = Global.centro_medico.My.Resources.Resources.new_add
        Me.tsbAñadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAñadir.Name = "tsbAñadir"
        Me.tsbAñadir.Size = New System.Drawing.Size(73, 24)
        Me.tsbAñadir.Text = "Añadir"
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(93, 24)
        Me.tsbModificar.Text = "Modificar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.centro_medico.My.Resources.Resources.new_delete
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(83, 24)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'Form_Recordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1076, 659)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Calendar2)
        Me.Controls.Add(Me.ScheduleRecordatorio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Recordatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recordatorio"
        CType(Me.BsRecordatorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleRecordatorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calendar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScheduleRecordatorio As Janus.Windows.Schedule.Schedule
    Friend WithEvents Calendar2 As Janus.Windows.Schedule.Calendar
    Friend WithEvents tb_hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TbAnotacion As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TbAsunto As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAñadir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents ToggleSwitch1 As JCS.ToggleSwitch
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BsRecordatorio As System.Windows.Forms.BindingSource
End Class
