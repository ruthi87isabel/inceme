<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_citas_duplicar
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
        Me.components = New System.ComponentModel.Container()
        Dim FECHALabel As System.Windows.Forms.Label
        Dim HORALabel As System.Windows.Forms.Label
        Dim HORAFINLabel As System.Windows.Forms.Label
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Calendar1 = New Janus.Windows.Schedule.Calendar()
        Me.Schedule1 = New Janus.Windows.Schedule.Schedule()
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tb_horafin = New System.Windows.Forms.DateTimePicker()
        Me.tb_horainicio = New System.Windows.Forms.DateTimePicker()
        Me.lb_aviso = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.LineasCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter()
        Me.LineasCitasTableAdapter = New centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        FECHALabel = New System.Windows.Forms.Label()
        HORALabel = New System.Windows.Forms.Label()
        HORAFINLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(5, 12)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 35
        FECHALabel.Text = "Fecha:"
        '
        'HORALabel
        '
        HORALabel.AutoSize = True
        HORALabel.Location = New System.Drawing.Point(96, 13)
        HORALabel.Name = "HORALabel"
        HORALabel.Size = New System.Drawing.Size(61, 13)
        HORALabel.TabIndex = 37
        HORALabel.Text = "Hora Inicio:"
        AddHandler HORALabel.Click, AddressOf Me.HORALabel_Click
        '
        'HORAFINLabel
        '
        HORAFINLabel.AutoSize = True
        HORAFINLabel.Location = New System.Drawing.Point(161, 13)
        HORAFINLabel.Name = "HORAFINLabel"
        HORAFINLabel.Size = New System.Drawing.Size(47, 13)
        HORAFINLabel.TabIndex = 65
        HORAFINLabel.Text = "Hora fin:"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(701, 311)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 36
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Calendar1)
        Me.GroupBox3.Controls.Add(Me.tb_horafin)
        Me.GroupBox3.Controls.Add(Me.tb_horainicio)
        Me.GroupBox3.Controls.Add(Me.lb_aviso)
        Me.GroupBox3.Controls.Add(FECHALabel)
        Me.GroupBox3.Controls.Add(Me.dtp_fecha)
        Me.GroupBox3.Controls.Add(HORALabel)
        Me.GroupBox3.Controls.Add(HORAFINLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(249, 186)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'Calendar1
        '
        Me.Calendar1.Location = New System.Drawing.Point(6, 47)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Schedule = Me.Schedule1
        Me.Calendar1.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule
        Me.Calendar1.Size = New System.Drawing.Size(148, 136)
        Me.Calendar1.TabIndex = 74
        '
        'Schedule1
        '
        Me.Schedule1.AddNewMode = Janus.Windows.Schedule.AddNewMode.Manual
        Me.Schedule1.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.None
        Me.Schedule1.AllowDayResize = False
        Me.Schedule1.AllowDelete = False
        Me.Schedule1.AllowEdit = False
        Me.Schedule1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Schedule1.DataSource = Me.CITASBindingSource
        Me.Schedule1.Date = New Date(2014, 3, 3, 0, 0, 0, 0)
        Me.Schedule1.DayColumns = 5
        Me.Schedule1.DescriptionMember = "PACIENTE"
        Me.Schedule1.EndTimeMember = "HORAFIN"
        Me.Schedule1.FirstDayOfWeek = Janus.Windows.Schedule.ScheduleDayOfWeek.Monday
        Me.Schedule1.FirstVisibleTime = System.TimeSpan.Parse("00:00:00")
        Me.Schedule1.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
        Me.Schedule1.Location = New System.Drawing.Point(12, 68)
        Me.Schedule1.Name = "Schedule1"
        Me.Schedule1.ShowAllDayArea = False
        Me.Schedule1.ShowMinutesInTimeNavigator = True
        Me.Schedule1.Size = New System.Drawing.Size(521, 580)
        Me.Schedule1.StartTimeMember = "HORA"
        Me.Schedule1.TabIndex = 77
        Me.Schedule1.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours
        Me.Schedule1.VisualStyle = Janus.Windows.Schedule.VisualStyle.VS2005
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_horafin
        '
        Me.tb_horafin.CustomFormat = "HH:mm"
        Me.tb_horafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horafin.Location = New System.Drawing.Point(164, 28)
        Me.tb_horafin.Name = "tb_horafin"
        Me.tb_horafin.ShowUpDown = True
        Me.tb_horafin.Size = New System.Drawing.Size(58, 20)
        Me.tb_horafin.TabIndex = 70
        '
        'tb_horainicio
        '
        Me.tb_horainicio.CustomFormat = "HH:mm"
        Me.tb_horainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_horainicio.Location = New System.Drawing.Point(99, 28)
        Me.tb_horainicio.Name = "tb_horainicio"
        Me.tb_horainicio.ShowUpDown = True
        Me.tb_horainicio.Size = New System.Drawing.Size(59, 20)
        Me.tb_horainicio.TabIndex = 69
        '
        'lb_aviso
        '
        Me.lb_aviso.AutoSize = True
        Me.lb_aviso.ForeColor = System.Drawing.Color.Red
        Me.lb_aviso.Location = New System.Drawing.Point(10, 91)
        Me.lb_aviso.Name = "lb_aviso"
        Me.lb_aviso.Size = New System.Drawing.Size(10, 13)
        Me.lb_aviso.TabIndex = 68
        Me.lb_aviso.Text = "."
        Me.lb_aviso.Visible = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CITASBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(8, 28)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(85, 20)
        Me.dtp_fecha.TabIndex = 36
        '
        'LineasCitasBindingSource
        '
        Me.LineasCitasBindingSource.DataMember = "LineasCitas"
        Me.LineasCitasBindingSource.DataSource = Me.CMDataSet
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'LineasCitasTableAdapter
        '
        Me.LineasCitasTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(568, 410)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 238)
        Me.ListBox1.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(560, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Sugerencias de horas libres"
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.Enabled = False
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(12, 20)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(521, 42)
        Me.CtrlMedico1.TabIndex = 79
        '
        'form_citas_duplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.Schedule1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Name = "form_citas_duplicar"
        Me.Text = "Duplicar Cita"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents LineasCitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineasCitasTableAdapter As centro_medico.CMDataSetTableAdapters.LineasCitasTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_horafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_horainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_aviso As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Schedule1 As Janus.Windows.Schedule.Schedule
    Public WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Calendar1 As Janus.Windows.Schedule.Calendar
End Class
