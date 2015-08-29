<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlHorarios
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpSeleccionar = New System.Windows.Forms.GroupBox()
        Me.dtpSelecHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelecDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnSeleccDesde = New System.Windows.Forms.Button()
        Me.btnSelecTodosDomingos = New System.Windows.Forms.Button()
        Me.btnSelecTodosSabados = New System.Windows.Forms.Button()
        Me.btnSelecDeseleccioanr = New System.Windows.Forms.Button()
        Me.btnSelTodosLosFinesSemana = New System.Windows.Forms.Button()
        Me.grpLeyenda = New System.Windows.Forms.GroupBox()
        Me.btnFiestasATodos = New System.Windows.Forms.Button()
        Me.btnDiasqueSICuentanATodos = New System.Windows.Forms.Button()
        Me.btnDiasqueNOCuentanATodos = New System.Windows.Forms.Button()
        Me.btnNOLaborablesATodos = New System.Windows.Forms.Button()
        Me.btnLaborablesATodos = New System.Windows.Forms.Button()
        Me.btnPropagar = New System.Windows.Forms.Button()
        Me.btnAplicFiestas = New System.Windows.Forms.Button()
        Me.btnAplicarDiasLabSICuentan = New System.Windows.Forms.Button()
        Me.btnAplicarDiasLabNoCuentan = New System.Windows.Forms.Button()
        Me.btnAplicarDias_Laborables = New System.Windows.Forms.Button()
        Me.btnAplicarDiasNoLaborables = New System.Windows.Forms.Button()
        Me.lblDiasNoLaborablesQueSIICuentan = New System.Windows.Forms.Label()
        Me.lblDiasNoLaborablesQueNoCuentan = New System.Windows.Forms.Label()
        Me.lblFiestas = New System.Windows.Forms.Label()
        Me.lbl_Laborables = New System.Windows.Forms.Label()
        Me.lblNoLaborables = New System.Windows.Forms.Label()
        Me.lblTituloCalendario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCant1 = New System.Windows.Forms.Label()
        Me.lblCant2 = New System.Windows.Forms.Label()
        Me.lblCant3 = New System.Windows.Forms.Label()
        Me.lblCant4 = New System.Windows.Forms.Label()
        Me.MonthCalendar9 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar10 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar11 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar12 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar5 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar6 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar7 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar8 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar4 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar3 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar2 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar1 = New Pabo.Calendar.MonthCalendar()
        Me.grpSeleccionar.SuspendLayout()
        Me.grpLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSeleccionar
        '
        Me.grpSeleccionar.Controls.Add(Me.dtpSelecHasta)
        Me.grpSeleccionar.Controls.Add(Me.dtpSelecDesde)
        Me.grpSeleccionar.Controls.Add(Me.btnSeleccDesde)
        Me.grpSeleccionar.Controls.Add(Me.btnSelecTodosDomingos)
        Me.grpSeleccionar.Controls.Add(Me.btnSelecTodosSabados)
        Me.grpSeleccionar.Controls.Add(Me.btnSelecDeseleccioanr)
        Me.grpSeleccionar.Controls.Add(Me.btnSelTodosLosFinesSemana)
        Me.grpSeleccionar.Location = New System.Drawing.Point(686, 279)
        Me.grpSeleccionar.Name = "grpSeleccionar"
        Me.grpSeleccionar.Size = New System.Drawing.Size(317, 204)
        Me.grpSeleccionar.TabIndex = 34
        Me.grpSeleccionar.TabStop = False
        Me.grpSeleccionar.Text = "Seleccion rapida"
        '
        'dtpSelecHasta
        '
        Me.dtpSelecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSelecHasta.Location = New System.Drawing.Point(148, 163)
        Me.dtpSelecHasta.Name = "dtpSelecHasta"
        Me.dtpSelecHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtpSelecHasta.TabIndex = 2
        '
        'dtpSelecDesde
        '
        Me.dtpSelecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSelecDesde.Location = New System.Drawing.Point(148, 137)
        Me.dtpSelecDesde.Name = "dtpSelecDesde"
        Me.dtpSelecDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtpSelecDesde.TabIndex = 2
        '
        'btnSeleccDesde
        '
        Me.btnSeleccDesde.Location = New System.Drawing.Point(53, 147)
        Me.btnSeleccDesde.Name = "btnSeleccDesde"
        Me.btnSeleccDesde.Size = New System.Drawing.Size(80, 23)
        Me.btnSeleccDesde.TabIndex = 1
        Me.btnSeleccDesde.Text = "Desde:"
        Me.btnSeleccDesde.UseVisualStyleBackColor = True
        '
        'btnSelecTodosDomingos
        '
        Me.btnSelecTodosDomingos.Location = New System.Drawing.Point(19, 87)
        Me.btnSelecTodosDomingos.Name = "btnSelecTodosDomingos"
        Me.btnSelecTodosDomingos.Size = New System.Drawing.Size(170, 23)
        Me.btnSelecTodosDomingos.TabIndex = 1
        Me.btnSelecTodosDomingos.Text = "Todos los domingos"
        Me.btnSelecTodosDomingos.UseVisualStyleBackColor = True
        '
        'btnSelecTodosSabados
        '
        Me.btnSelecTodosSabados.Location = New System.Drawing.Point(19, 58)
        Me.btnSelecTodosSabados.Name = "btnSelecTodosSabados"
        Me.btnSelecTodosSabados.Size = New System.Drawing.Size(170, 23)
        Me.btnSelecTodosSabados.TabIndex = 1
        Me.btnSelecTodosSabados.Text = "Todos los sábados"
        Me.btnSelecTodosSabados.UseVisualStyleBackColor = True
        '
        'btnSelecDeseleccioanr
        '
        Me.btnSelecDeseleccioanr.Location = New System.Drawing.Point(211, 29)
        Me.btnSelecDeseleccioanr.Name = "btnSelecDeseleccioanr"
        Me.btnSelecDeseleccioanr.Size = New System.Drawing.Size(86, 80)
        Me.btnSelecDeseleccioanr.TabIndex = 1
        Me.btnSelecDeseleccioanr.Text = "Deseleccionar Todo"
        Me.btnSelecDeseleccioanr.UseVisualStyleBackColor = True
        '
        'btnSelTodosLosFinesSemana
        '
        Me.btnSelTodosLosFinesSemana.Location = New System.Drawing.Point(19, 29)
        Me.btnSelTodosLosFinesSemana.Name = "btnSelTodosLosFinesSemana"
        Me.btnSelTodosLosFinesSemana.Size = New System.Drawing.Size(170, 23)
        Me.btnSelTodosLosFinesSemana.TabIndex = 1
        Me.btnSelTodosLosFinesSemana.Text = "Todos los fines de semana"
        Me.btnSelTodosLosFinesSemana.UseVisualStyleBackColor = True
        '
        'grpLeyenda
        '
        Me.grpLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLeyenda.Controls.Add(Me.btnFiestasATodos)
        Me.grpLeyenda.Controls.Add(Me.btnDiasqueSICuentanATodos)
        Me.grpLeyenda.Controls.Add(Me.btnDiasqueNOCuentanATodos)
        Me.grpLeyenda.Controls.Add(Me.btnNOLaborablesATodos)
        Me.grpLeyenda.Controls.Add(Me.btnLaborablesATodos)
        Me.grpLeyenda.Controls.Add(Me.btnPropagar)
        Me.grpLeyenda.Controls.Add(Me.btnAplicFiestas)
        Me.grpLeyenda.Controls.Add(Me.btnAplicarDiasLabSICuentan)
        Me.grpLeyenda.Controls.Add(Me.btnAplicarDiasLabNoCuentan)
        Me.grpLeyenda.Controls.Add(Me.btnAplicarDias_Laborables)
        Me.grpLeyenda.Controls.Add(Me.btnAplicarDiasNoLaborables)
        Me.grpLeyenda.Controls.Add(Me.lblDiasNoLaborablesQueSIICuentan)
        Me.grpLeyenda.Controls.Add(Me.lblDiasNoLaborablesQueNoCuentan)
        Me.grpLeyenda.Controls.Add(Me.lblFiestas)
        Me.grpLeyenda.Controls.Add(Me.lbl_Laborables)
        Me.grpLeyenda.Controls.Add(Me.lblNoLaborables)
        Me.grpLeyenda.Location = New System.Drawing.Point(685, 38)
        Me.grpLeyenda.Name = "grpLeyenda"
        Me.grpLeyenda.Size = New System.Drawing.Size(318, 235)
        Me.grpLeyenda.TabIndex = 33
        Me.grpLeyenda.TabStop = False
        Me.grpLeyenda.Text = "Leyenda"
        '
        'btnFiestasATodos
        '
        Me.btnFiestasATodos.Location = New System.Drawing.Point(261, 155)
        Me.btnFiestasATodos.Name = "btnFiestasATodos"
        Me.btnFiestasATodos.Size = New System.Drawing.Size(51, 35)
        Me.btnFiestasATodos.TabIndex = 2
        Me.btnFiestasATodos.Text = "A Todos"
        Me.btnFiestasATodos.UseVisualStyleBackColor = True
        '
        'btnDiasqueSICuentanATodos
        '
        Me.btnDiasqueSICuentanATodos.Location = New System.Drawing.Point(261, 122)
        Me.btnDiasqueSICuentanATodos.Name = "btnDiasqueSICuentanATodos"
        Me.btnDiasqueSICuentanATodos.Size = New System.Drawing.Size(51, 35)
        Me.btnDiasqueSICuentanATodos.TabIndex = 2
        Me.btnDiasqueSICuentanATodos.Text = "A Todos"
        Me.btnDiasqueSICuentanATodos.UseVisualStyleBackColor = True
        '
        'btnDiasqueNOCuentanATodos
        '
        Me.btnDiasqueNOCuentanATodos.Location = New System.Drawing.Point(261, 88)
        Me.btnDiasqueNOCuentanATodos.Name = "btnDiasqueNOCuentanATodos"
        Me.btnDiasqueNOCuentanATodos.Size = New System.Drawing.Size(51, 35)
        Me.btnDiasqueNOCuentanATodos.TabIndex = 2
        Me.btnDiasqueNOCuentanATodos.Text = "A Todos"
        Me.btnDiasqueNOCuentanATodos.UseVisualStyleBackColor = True
        '
        'btnNOLaborablesATodos
        '
        Me.btnNOLaborablesATodos.Location = New System.Drawing.Point(261, 52)
        Me.btnNOLaborablesATodos.Name = "btnNOLaborablesATodos"
        Me.btnNOLaborablesATodos.Size = New System.Drawing.Size(51, 35)
        Me.btnNOLaborablesATodos.TabIndex = 2
        Me.btnNOLaborablesATodos.Text = "A Todos"
        Me.btnNOLaborablesATodos.UseVisualStyleBackColor = True
        '
        'btnLaborablesATodos
        '
        Me.btnLaborablesATodos.Location = New System.Drawing.Point(261, 18)
        Me.btnLaborablesATodos.Name = "btnLaborablesATodos"
        Me.btnLaborablesATodos.Size = New System.Drawing.Size(51, 35)
        Me.btnLaborablesATodos.TabIndex = 2
        Me.btnLaborablesATodos.Text = "A Todos"
        Me.btnLaborablesATodos.UseVisualStyleBackColor = True
        '
        'btnPropagar
        '
        Me.btnPropagar.Location = New System.Drawing.Point(64, 201)
        Me.btnPropagar.Name = "btnPropagar"
        Me.btnPropagar.Size = New System.Drawing.Size(181, 26)
        Me.btnPropagar.TabIndex = 1
        Me.btnPropagar.Text = "Clonar calendario actual a todos"
        Me.btnPropagar.UseVisualStyleBackColor = True
        Me.btnPropagar.Visible = False
        '
        'btnAplicFiestas
        '
        Me.btnAplicFiestas.Location = New System.Drawing.Point(176, 156)
        Me.btnAplicFiestas.Name = "btnAplicFiestas"
        Me.btnAplicFiestas.Size = New System.Drawing.Size(84, 34)
        Me.btnAplicFiestas.TabIndex = 1
        Me.btnAplicFiestas.Text = "Aplicar a Selecc."
        Me.btnAplicFiestas.UseVisualStyleBackColor = True
        '
        'btnAplicarDiasLabSICuentan
        '
        Me.btnAplicarDiasLabSICuentan.Location = New System.Drawing.Point(176, 122)
        Me.btnAplicarDiasLabSICuentan.Name = "btnAplicarDiasLabSICuentan"
        Me.btnAplicarDiasLabSICuentan.Size = New System.Drawing.Size(84, 34)
        Me.btnAplicarDiasLabSICuentan.TabIndex = 1
        Me.btnAplicarDiasLabSICuentan.Text = "Aplicar a Selecc."
        Me.btnAplicarDiasLabSICuentan.UseVisualStyleBackColor = True
        '
        'btnAplicarDiasLabNoCuentan
        '
        Me.btnAplicarDiasLabNoCuentan.Location = New System.Drawing.Point(176, 88)
        Me.btnAplicarDiasLabNoCuentan.Name = "btnAplicarDiasLabNoCuentan"
        Me.btnAplicarDiasLabNoCuentan.Size = New System.Drawing.Size(84, 34)
        Me.btnAplicarDiasLabNoCuentan.TabIndex = 1
        Me.btnAplicarDiasLabNoCuentan.Text = "Aplicar a Selecc."
        Me.btnAplicarDiasLabNoCuentan.UseVisualStyleBackColor = True
        '
        'btnAplicarDias_Laborables
        '
        Me.btnAplicarDias_Laborables.Location = New System.Drawing.Point(176, 18)
        Me.btnAplicarDias_Laborables.Name = "btnAplicarDias_Laborables"
        Me.btnAplicarDias_Laborables.Size = New System.Drawing.Size(84, 35)
        Me.btnAplicarDias_Laborables.TabIndex = 1
        Me.btnAplicarDias_Laborables.Text = "Aplicar a Selecc."
        Me.btnAplicarDias_Laborables.UseVisualStyleBackColor = True
        '
        'btnAplicarDiasNoLaborables
        '
        Me.btnAplicarDiasNoLaborables.Location = New System.Drawing.Point(176, 53)
        Me.btnAplicarDiasNoLaborables.Name = "btnAplicarDiasNoLaborables"
        Me.btnAplicarDiasNoLaborables.Size = New System.Drawing.Size(84, 34)
        Me.btnAplicarDiasNoLaborables.TabIndex = 1
        Me.btnAplicarDiasNoLaborables.Text = "Aplicar a Selecc."
        Me.btnAplicarDiasNoLaborables.UseVisualStyleBackColor = True
        '
        'lblDiasNoLaborablesQueSIICuentan
        '
        Me.lblDiasNoLaborablesQueSIICuentan.BackColor = System.Drawing.Color.Red
        Me.lblDiasNoLaborablesQueSIICuentan.ForeColor = System.Drawing.Color.White
        Me.lblDiasNoLaborablesQueSIICuentan.Location = New System.Drawing.Point(11, 122)
        Me.lblDiasNoLaborablesQueSIICuentan.Name = "lblDiasNoLaborablesQueSIICuentan"
        Me.lblDiasNoLaborablesQueSIICuentan.Size = New System.Drawing.Size(160, 34)
        Me.lblDiasNoLaborablesQueSIICuentan.TabIndex = 0
        Me.lblDiasNoLaborablesQueSIICuentan.Text = "Días no laborables generales que cuentan en vacaciones"
        Me.lblDiasNoLaborablesQueSIICuentan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiasNoLaborablesQueNoCuentan
        '
        Me.lblDiasNoLaborablesQueNoCuentan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiasNoLaborablesQueNoCuentan.ForeColor = System.Drawing.Color.White
        Me.lblDiasNoLaborablesQueNoCuentan.Location = New System.Drawing.Point(11, 87)
        Me.lblDiasNoLaborablesQueNoCuentan.Name = "lblDiasNoLaborablesQueNoCuentan"
        Me.lblDiasNoLaborablesQueNoCuentan.Size = New System.Drawing.Size(160, 34)
        Me.lblDiasNoLaborablesQueNoCuentan.TabIndex = 0
        Me.lblDiasNoLaborablesQueNoCuentan.Text = "Días no laborables generales que no cuentan en vacaciones"
        Me.lblDiasNoLaborablesQueNoCuentan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFiestas
        '
        Me.lblFiestas.BackColor = System.Drawing.Color.Navy
        Me.lblFiestas.ForeColor = System.Drawing.Color.White
        Me.lblFiestas.Location = New System.Drawing.Point(11, 157)
        Me.lblFiestas.Name = "lblFiestas"
        Me.lblFiestas.Size = New System.Drawing.Size(160, 34)
        Me.lblFiestas.TabIndex = 0
        Me.lblFiestas.Text = "Fiestas"
        Me.lblFiestas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Laborables
        '
        Me.lbl_Laborables.BackColor = System.Drawing.Color.White
        Me.lbl_Laborables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Laborables.ForeColor = System.Drawing.Color.Black
        Me.lbl_Laborables.Location = New System.Drawing.Point(11, 19)
        Me.lbl_Laborables.Name = "lbl_Laborables"
        Me.lbl_Laborables.Size = New System.Drawing.Size(160, 34)
        Me.lbl_Laborables.TabIndex = 0
        Me.lbl_Laborables.Text = "Laborables"
        Me.lbl_Laborables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoLaborables
        '
        Me.lblNoLaborables.BackColor = System.Drawing.Color.Green
        Me.lblNoLaborables.ForeColor = System.Drawing.Color.White
        Me.lblNoLaborables.Location = New System.Drawing.Point(11, 54)
        Me.lblNoLaborables.Name = "lblNoLaborables"
        Me.lblNoLaborables.Size = New System.Drawing.Size(160, 34)
        Me.lblNoLaborables.TabIndex = 0
        Me.lblNoLaborables.Text = "No Laborables"
        Me.lblNoLaborables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTituloCalendario
        '
        Me.lblTituloCalendario.AutoSize = True
        Me.lblTituloCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCalendario.Location = New System.Drawing.Point(3, 13)
        Me.lblTituloCalendario.Name = "lblTituloCalendario"
        Me.lblTituloCalendario.Size = New System.Drawing.Size(134, 16)
        Me.lblTituloCalendario.TabIndex = 35
        Me.lblTituloCalendario.Text = "Calendario Global"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cantidades:"
        Me.Label1.Visible = False
        '
        'lblCant1
        '
        Me.lblCant1.BackColor = System.Drawing.Color.Green
        Me.lblCant1.ForeColor = System.Drawing.Color.White
        Me.lblCant1.Location = New System.Drawing.Point(519, 495)
        Me.lblCant1.Name = "lblCant1"
        Me.lblCant1.Size = New System.Drawing.Size(36, 18)
        Me.lblCant1.TabIndex = 37
        Me.lblCant1.Text = "0"
        Me.lblCant1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCant1.Visible = False
        '
        'lblCant2
        '
        Me.lblCant2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCant2.ForeColor = System.Drawing.Color.White
        Me.lblCant2.Location = New System.Drawing.Point(560, 495)
        Me.lblCant2.Name = "lblCant2"
        Me.lblCant2.Size = New System.Drawing.Size(36, 18)
        Me.lblCant2.TabIndex = 38
        Me.lblCant2.Text = "0"
        Me.lblCant2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCant2.Visible = False
        '
        'lblCant3
        '
        Me.lblCant3.BackColor = System.Drawing.Color.Red
        Me.lblCant3.ForeColor = System.Drawing.Color.White
        Me.lblCant3.Location = New System.Drawing.Point(601, 495)
        Me.lblCant3.Name = "lblCant3"
        Me.lblCant3.Size = New System.Drawing.Size(36, 18)
        Me.lblCant3.TabIndex = 39
        Me.lblCant3.Text = "0"
        Me.lblCant3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCant3.Visible = False
        '
        'lblCant4
        '
        Me.lblCant4.BackColor = System.Drawing.Color.Navy
        Me.lblCant4.ForeColor = System.Drawing.Color.White
        Me.lblCant4.Location = New System.Drawing.Point(642, 495)
        Me.lblCant4.Name = "lblCant4"
        Me.lblCant4.Size = New System.Drawing.Size(36, 18)
        Me.lblCant4.TabIndex = 40
        Me.lblCant4.Text = "0"
        Me.lblCant4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCant4.Visible = False
        '
        'MonthCalendar9
        '
        Me.MonthCalendar9.ActiveMonth.Month = 1
        Me.MonthCalendar9.ActiveMonth.Year = 2012
        Me.MonthCalendar9.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar9.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar9.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar9.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar9.Header.MonthSelectors = False
        Me.MonthCalendar9.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar9.ImageList = Nothing
        Me.MonthCalendar9.Location = New System.Drawing.Point(6, 335)
        Me.MonthCalendar9.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar9.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar9.Month.BackgroundImage = Nothing
        Me.MonthCalendar9.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar9.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar9.Name = "MonthCalendar9"
        Me.MonthCalendar9.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar9.SelectTrailingDates = False
        Me.MonthCalendar9.ShowFocus = False
        Me.MonthCalendar9.ShowFooter = False
        Me.MonthCalendar9.ShowTrailingDates = False
        Me.MonthCalendar9.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar9.TabIndex = 29
        Me.MonthCalendar9.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar9.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar10
        '
        Me.MonthCalendar10.ActiveMonth.Month = 1
        Me.MonthCalendar10.ActiveMonth.Year = 2012
        Me.MonthCalendar10.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar10.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar10.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar10.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar10.Header.MonthSelectors = False
        Me.MonthCalendar10.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar10.ImageList = Nothing
        Me.MonthCalendar10.Location = New System.Drawing.Point(174, 335)
        Me.MonthCalendar10.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar10.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar10.Month.BackgroundImage = Nothing
        Me.MonthCalendar10.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar10.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar10.Name = "MonthCalendar10"
        Me.MonthCalendar10.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar10.SelectTrailingDates = False
        Me.MonthCalendar10.ShowFocus = False
        Me.MonthCalendar10.ShowFooter = False
        Me.MonthCalendar10.ShowTrailingDates = False
        Me.MonthCalendar10.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar10.TabIndex = 28
        Me.MonthCalendar10.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar10.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar11
        '
        Me.MonthCalendar11.ActiveMonth.Month = 1
        Me.MonthCalendar11.ActiveMonth.Year = 2012
        Me.MonthCalendar11.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar11.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar11.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar11.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar11.Header.MonthSelectors = False
        Me.MonthCalendar11.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar11.ImageList = Nothing
        Me.MonthCalendar11.Location = New System.Drawing.Point(342, 335)
        Me.MonthCalendar11.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar11.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar11.Month.BackgroundImage = Nothing
        Me.MonthCalendar11.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar11.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar11.Name = "MonthCalendar11"
        Me.MonthCalendar11.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar11.SelectTrailingDates = False
        Me.MonthCalendar11.ShowFocus = False
        Me.MonthCalendar11.ShowFooter = False
        Me.MonthCalendar11.ShowTrailingDates = False
        Me.MonthCalendar11.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar11.TabIndex = 27
        Me.MonthCalendar11.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar11.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar12
        '
        Me.MonthCalendar12.ActiveMonth.Month = 1
        Me.MonthCalendar12.ActiveMonth.Year = 2012
        Me.MonthCalendar12.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar12.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar12.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar12.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar12.Header.MonthSelectors = False
        Me.MonthCalendar12.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar12.ImageList = Nothing
        Me.MonthCalendar12.Location = New System.Drawing.Point(510, 335)
        Me.MonthCalendar12.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar12.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar12.Month.BackgroundImage = Nothing
        Me.MonthCalendar12.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar12.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar12.Name = "MonthCalendar12"
        Me.MonthCalendar12.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar12.SelectTrailingDates = False
        Me.MonthCalendar12.ShowFocus = False
        Me.MonthCalendar12.ShowFooter = False
        Me.MonthCalendar12.ShowTrailingDates = False
        Me.MonthCalendar12.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar12.TabIndex = 26
        Me.MonthCalendar12.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar12.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar5
        '
        Me.MonthCalendar5.ActiveMonth.Month = 1
        Me.MonthCalendar5.ActiveMonth.Year = 2012
        Me.MonthCalendar5.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar5.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar5.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar5.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar5.Header.MonthSelectors = False
        Me.MonthCalendar5.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar5.ImageList = Nothing
        Me.MonthCalendar5.Location = New System.Drawing.Point(6, 187)
        Me.MonthCalendar5.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar5.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar5.Month.BackgroundImage = Nothing
        Me.MonthCalendar5.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar5.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar5.Name = "MonthCalendar5"
        Me.MonthCalendar5.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar5.SelectTrailingDates = False
        Me.MonthCalendar5.ShowFocus = False
        Me.MonthCalendar5.ShowFooter = False
        Me.MonthCalendar5.ShowTrailingDates = False
        Me.MonthCalendar5.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar5.TabIndex = 25
        Me.MonthCalendar5.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar5.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar6
        '
        Me.MonthCalendar6.ActiveMonth.Month = 1
        Me.MonthCalendar6.ActiveMonth.Year = 2012
        Me.MonthCalendar6.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar6.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar6.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar6.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar6.Header.MonthSelectors = False
        Me.MonthCalendar6.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar6.ImageList = Nothing
        Me.MonthCalendar6.Location = New System.Drawing.Point(174, 187)
        Me.MonthCalendar6.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar6.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar6.Month.BackgroundImage = Nothing
        Me.MonthCalendar6.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar6.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar6.Name = "MonthCalendar6"
        Me.MonthCalendar6.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar6.SelectTrailingDates = False
        Me.MonthCalendar6.ShowFocus = False
        Me.MonthCalendar6.ShowFooter = False
        Me.MonthCalendar6.ShowTrailingDates = False
        Me.MonthCalendar6.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar6.TabIndex = 24
        Me.MonthCalendar6.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar6.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar7
        '
        Me.MonthCalendar7.ActiveMonth.Month = 1
        Me.MonthCalendar7.ActiveMonth.Year = 2012
        Me.MonthCalendar7.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar7.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar7.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar7.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar7.Header.MonthSelectors = False
        Me.MonthCalendar7.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar7.ImageList = Nothing
        Me.MonthCalendar7.Location = New System.Drawing.Point(342, 187)
        Me.MonthCalendar7.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar7.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar7.Month.BackgroundImage = Nothing
        Me.MonthCalendar7.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar7.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar7.Name = "MonthCalendar7"
        Me.MonthCalendar7.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar7.SelectTrailingDates = False
        Me.MonthCalendar7.ShowFocus = False
        Me.MonthCalendar7.ShowFooter = False
        Me.MonthCalendar7.ShowTrailingDates = False
        Me.MonthCalendar7.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar7.TabIndex = 23
        Me.MonthCalendar7.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar7.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar8
        '
        Me.MonthCalendar8.ActiveMonth.Month = 1
        Me.MonthCalendar8.ActiveMonth.Year = 2012
        Me.MonthCalendar8.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar8.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar8.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar8.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar8.Header.MonthSelectors = False
        Me.MonthCalendar8.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar8.ImageList = Nothing
        Me.MonthCalendar8.Location = New System.Drawing.Point(510, 187)
        Me.MonthCalendar8.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar8.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar8.Month.BackgroundImage = Nothing
        Me.MonthCalendar8.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar8.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar8.Name = "MonthCalendar8"
        Me.MonthCalendar8.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar8.SelectTrailingDates = False
        Me.MonthCalendar8.ShowFocus = False
        Me.MonthCalendar8.ShowFooter = False
        Me.MonthCalendar8.ShowTrailingDates = False
        Me.MonthCalendar8.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar8.TabIndex = 22
        Me.MonthCalendar8.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar8.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar4
        '
        Me.MonthCalendar4.ActiveMonth.Month = 1
        Me.MonthCalendar4.ActiveMonth.Year = 2012
        Me.MonthCalendar4.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar4.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar4.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar4.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar4.Header.MonthSelectors = False
        Me.MonthCalendar4.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar4.ImageList = Nothing
        Me.MonthCalendar4.Location = New System.Drawing.Point(510, 39)
        Me.MonthCalendar4.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar4.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar4.Month.BackgroundImage = Nothing
        Me.MonthCalendar4.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar4.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar4.Name = "MonthCalendar4"
        Me.MonthCalendar4.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar4.SelectTrailingDates = False
        Me.MonthCalendar4.ShowFocus = False
        Me.MonthCalendar4.ShowFooter = False
        Me.MonthCalendar4.ShowTrailingDates = False
        Me.MonthCalendar4.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar4.TabIndex = 21
        Me.MonthCalendar4.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar4.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.ActiveMonth.Month = 1
        Me.MonthCalendar3.ActiveMonth.Year = 2012
        Me.MonthCalendar3.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar3.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar3.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Header.MonthSelectors = False
        Me.MonthCalendar3.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar3.ImageList = Nothing
        Me.MonthCalendar3.Location = New System.Drawing.Point(342, 39)
        Me.MonthCalendar3.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar3.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar3.Month.BackgroundImage = Nothing
        Me.MonthCalendar3.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar3.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar3.SelectTrailingDates = False
        Me.MonthCalendar3.ShowFocus = False
        Me.MonthCalendar3.ShowFooter = False
        Me.MonthCalendar3.ShowTrailingDates = False
        Me.MonthCalendar3.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar3.TabIndex = 20
        Me.MonthCalendar3.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar3.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.ActiveMonth.Month = 2
        Me.MonthCalendar2.ActiveMonth.Year = 2012
        Me.MonthCalendar2.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar2.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar2.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar2.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar2.Header.MonthSelectors = False
        Me.MonthCalendar2.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.ImageList = Nothing
        Me.MonthCalendar2.Location = New System.Drawing.Point(174, 39)
        Me.MonthCalendar2.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar2.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar2.Month.BackgroundImage = Nothing
        Me.MonthCalendar2.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar2.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar2.SelectTrailingDates = False
        Me.MonthCalendar2.ShowFocus = False
        Me.MonthCalendar2.ShowFooter = False
        Me.MonthCalendar2.ShowTrailingDates = False
        Me.MonthCalendar2.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar2.TabIndex = 19
        Me.MonthCalendar2.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar2.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.ActiveMonth.Month = 1
        Me.MonthCalendar1.ActiveMonth.Year = 2012
        Me.MonthCalendar1.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MonthCalendar1.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar1.Header.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar1.Header.MonthSelectors = False
        Me.MonthCalendar1.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar1.ImageList = Nothing
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 39)
        Me.MonthCalendar1.MaxDate = New Date(2022, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar1.MinDate = New Date(2002, 2, 2, 16, 28, 43, 363)
        Me.MonthCalendar1.Month.BackgroundImage = Nothing
        Me.MonthCalendar1.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar1.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended
        Me.MonthCalendar1.SelectTrailingDates = False
        Me.MonthCalendar1.ShowFocus = False
        Me.MonthCalendar1.ShowFooter = False
        Me.MonthCalendar1.ShowTrailingDates = False
        Me.MonthCalendar1.Size = New System.Drawing.Size(168, 148)
        Me.MonthCalendar1.TabIndex = 18
        Me.MonthCalendar1.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MonthCalendar1.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'ctrlHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblCant4)
        Me.Controls.Add(Me.lblCant3)
        Me.Controls.Add(Me.lblCant2)
        Me.Controls.Add(Me.lblCant1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTituloCalendario)
        Me.Controls.Add(Me.grpSeleccionar)
        Me.Controls.Add(Me.grpLeyenda)
        Me.Controls.Add(Me.MonthCalendar9)
        Me.Controls.Add(Me.MonthCalendar10)
        Me.Controls.Add(Me.MonthCalendar11)
        Me.Controls.Add(Me.MonthCalendar12)
        Me.Controls.Add(Me.MonthCalendar5)
        Me.Controls.Add(Me.MonthCalendar6)
        Me.Controls.Add(Me.MonthCalendar7)
        Me.Controls.Add(Me.MonthCalendar8)
        Me.Controls.Add(Me.MonthCalendar4)
        Me.Controls.Add(Me.MonthCalendar3)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "ctrlHorarios"
        Me.Size = New System.Drawing.Size(1014, 529)
        Me.grpSeleccionar.ResumeLayout(False)
        Me.grpLeyenda.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSeleccionar As System.Windows.Forms.GroupBox
    Friend WithEvents dtpSelecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSelecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSeleccDesde As System.Windows.Forms.Button
    Friend WithEvents btnSelecTodosDomingos As System.Windows.Forms.Button
    Friend WithEvents btnSelecTodosSabados As System.Windows.Forms.Button
    Friend WithEvents btnSelTodosLosFinesSemana As System.Windows.Forms.Button
    Friend WithEvents grpLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents btnAplicFiestas As System.Windows.Forms.Button
    Friend WithEvents btnAplicarDiasLabSICuentan As System.Windows.Forms.Button
    Friend WithEvents btnAplicarDiasLabNoCuentan As System.Windows.Forms.Button
    Friend WithEvents btnAplicarDias_Laborables As System.Windows.Forms.Button
    Friend WithEvents btnAplicarDiasNoLaborables As System.Windows.Forms.Button
    Friend WithEvents lblDiasNoLaborablesQueSIICuentan As System.Windows.Forms.Label
    Friend WithEvents lblDiasNoLaborablesQueNoCuentan As System.Windows.Forms.Label
    Friend WithEvents lblFiestas As System.Windows.Forms.Label
    Friend WithEvents lbl_Laborables As System.Windows.Forms.Label
    Friend WithEvents lblNoLaborables As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar9 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar10 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar11 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar12 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar5 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar6 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar7 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar8 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar4 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar3 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar2 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar1 As Pabo.Calendar.MonthCalendar
    Friend WithEvents btnSelecDeseleccioanr As System.Windows.Forms.Button
    Public WithEvents lblTituloCalendario As System.Windows.Forms.Label
    Public WithEvents btnPropagar As System.Windows.Forms.Button
    Friend WithEvents btnFiestasATodos As System.Windows.Forms.Button
    Friend WithEvents btnDiasqueSICuentanATodos As System.Windows.Forms.Button
    Friend WithEvents btnDiasqueNOCuentanATodos As System.Windows.Forms.Button
    Friend WithEvents btnNOLaborablesATodos As System.Windows.Forms.Button
    Friend WithEvents btnLaborablesATodos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCant1 As System.Windows.Forms.Label
    Friend WithEvents lblCant2 As System.Windows.Forms.Label
    Friend WithEvents lblCant3 As System.Windows.Forms.Label
    Friend WithEvents lblCant4 As System.Windows.Forms.Label

End Class
