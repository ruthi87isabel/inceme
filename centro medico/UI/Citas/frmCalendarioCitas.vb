Imports Janus.Windows.Schedule
Imports Janus.Windows.GridEX
Imports System.Drawing.Printing
Imports centro_medico.UI.Reportes

Namespace UI.Citas

    Public Class frmCalendarioCitas

        Public IdPaciente As Integer = -1

        Private MedicosOwners() As ScheduleAppointmentOwner
        Private SalasOwners() As ScheduleAppointmentOwner

        Private currentNotas As List(Of NOTA)

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            If Not Globales.Configuracion.Cita_UsarSalas Then
                PanelNotas.Top = GridEXMutuas.Bottom + 5
                PanelNotas.Height = PanelNotas.Height + (GridEXSalas.Height + 5)
                PanelNotas.Left = GridEXMedicos.Left
                PanelNotas.Anchor = AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            End If
        End Sub

        Public Enum EstadoCalendario
            Idle
            Annadiendo
            Editando
            Borrando
            Duplicando
            Ver
            Imprimiendo
        End Enum

        Public Estado As EstadoCalendario = EstadoCalendario.Idle

        Private userSelected As Boolean = False

        Dim context As New CMLinqDataContext()

        Private Sub frmCalendarioCitas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
            FreeMemory.FlushMemory()
        End Sub


        Private Sub frmCalendarioCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ApplyFormatConditions()
            CargarMutuas()
            CargarMedicosOwners()
            CargarSalasOwners()



            'ScheduleCitas.MultiOwner = Globales.Configuracion.Calendario_MostrarListaMedicosPorDefecto
            rbPorMedicos.Checked = Globales.Configuracion.CalendarioMostrarListaMedicosPorDefecto
            ScheduleCitas.Date = FiltroGenericoDocumentos.FirstDate(Date.Now)

            ScheduleCitas.ShowTimeAsClocks = False

            'Permisos de acceso
            Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas)
            tstEliminar.Visible = apermiso > RoleManager.TipoPermisos.Modificar
            tstNuevaCitas.Visible = apermiso > RoleManager.TipoPermisos.Lectura
            tstModificar.Visible = apermiso > RoleManager.TipoPermisos.Lectura
            tstDuplicarCita.Visible = apermiso > RoleManager.TipoPermisos.Lectura

            mi_cambiar.Enabled = apermiso > RoleManager.TipoPermisos.Lectura
            ModificarCitaToolStripMenuItem.Enabled = apermiso > RoleManager.TipoPermisos.Lectura
            BorrarCitaToolStripMenuItem.Enabled = apermiso > RoleManager.TipoPermisos.Modificar
            DuplicarCitaToolStripMenuItem.Enabled = apermiso > RoleManager.TipoPermisos.Modificar



            Dim intervalo As Integer = Globales.Configuracion.dateinterval
            Select Case intervalo
                Case 1 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.OneMinute
                Case 2 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.TwoMinutes
                Case 3 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.ThreeMinutes
                Case 4 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.FourMinutes
                Case 5 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
                Case 6 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.SixMinutes
                Case 7, 8, 9, 10, 11 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.TenMinutes
                Case 12, 13, 14 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
                Case 15, 16, 17, 18 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
                Case 30 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
                Case 60 : ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.SixtyMinutes
                Case Else
                    If intervalo > 19 And intervalo <= 58 Then ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
                    If intervalo > 60 Then ScheduleCitas.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
            End Select
            Me.ScheduleCitas.WorkStartTime = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(Date.Now)
            Me.ScheduleCitas.DayStartHour = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(Date.Now).Hours
            Me.ScheduleCitas.WorkEndTime = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(Date.Now)
            Me.ScheduleCitas.DayEndHour = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(Date.Now).Hours + 1

            ''Salas
            'ScheduleSalas.Interval = ScheduleCitas.Interval
            'Me.ScheduleSalas.WorkStartTime = New TimeSpan(0, centro_medico.Globales.Configuracion.JornadaLaboralInicio, 0, 0)
            'Me.ScheduleSalas.DayStartHour = centro_medico.Globales.Configuracion.JornadaLaboralInicio
            'Me.ScheduleSalas.WorkEndTime = New TimeSpan(0, centro_medico.Globales.Configuracion.JornadaLaboralFinal, 0, 0)
            'Me.ScheduleSalas.DayEndHour = centro_medico.Globales.Configuracion.JornadaLaboralFinal

            If Globales.Configuracion.Cita_AutoRefreshInterval = 0 Then
                TimerCitas.Enabled = False
            Else
                TimerCitas.Enabled = True
                TimerCitas.Interval = Globales.Configuracion.Cita_AutoRefreshInterval
            End If



            If Globales.Configuracion.citastyle = "Clasica" Then
                TabControl1.SelectedIndex = 1
            End If

            'Visibilidad de columnas en el Grid
            GridEX1.RootTable.Columns("CODIGOPROPIO").Visible = Globales.Configuracion.citaCodPropioPac
            GridEX1.RootTable.Columns("PACIENTE").Visible = Globales.Configuracion.citapac
            GridEX1.RootTable.Columns("MEDICONOMBRECOMPLETO").Visible = Globales.Configuracion.citamed
            GridEX1.RootTable.Columns("MEDICO.ESPECIALIDAD").Visible = Globales.Configuracion.citaesp

            If Not Globales.Configuracion.citanote Then
                GridEX1.RootTable.ChildTables.RemoveAt(0)
            End If

            'GridEX1.RootTable.ChildTables(0).Columns ("CODIGOPROPIO").Visible = Globals.Configuracion.citaCodPropioPac
            If IdPaciente <> -1 Then
                PanelIntervalo.Visible = True
                Panel1.Visible = False
                TabControl1.SelectedIndex = 1


                'Determinar fecha maxima y minima de las citas del paciente en cuestion
                'Dim context As New CMLinqDataContext()
                Dim citas As List(Of CITA) = (From c In context.CITAs Select c _
                        Where c.REFPACIENTE = IdPaciente And c.Eliminado = False _
                        Order By c.FECHA Descending).ToList()
                If citas.Count > 0 Then
                    dtpFechaInicio.Value = citas(citas.Count - 1).FECHA
                    dtpFechaFinal.Value = Date.Now
                    'LoadCitas()
                End If
            End If

            'Visibilidad de las Salas
            rbPorSala.Visible = Globales.Configuracion.Cita_UsarSalas
            GridEXSalas.Visible = Globales.Configuracion.Cita_UsarSalas
            'If Not GridEXSalas.Visible Then
            '    PanelNotas.Top = GridEXMutuas.Bottom + 5
            '    PanelNotas.Height = PanelNotas.Height + (GridEXSalas.Height + 5)
            '    PanelNotas.Left = GridEXMedicos.Left
            '    PanelNotas.Anchor = AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            'End If
            'pnl_Notastoolbar.Left = GridEXMedicos.Left




            tstSala.Visible = Globales.Configuracion.Cita_UsarSalas
            GridEX1.RootTable.Columns("SALA.Nombre").Visible = Globales.Configuracion.Cita_UsarSalas
            GC.Collect()
            'ToogleGrid(GridEXMedicos, True)
        End Sub

#Region "Private Sub ApplyFormatConditions"

        Private Sub ApplyFormatConditions()

            'Las categorias serian Regular y Mutua

            Dim field As ScheduleField = Me.ScheduleCitas.Fields("REFPROCEDENCIA")
            Dim categoryFormatStyle As ScheduleFormatStyle = New ScheduleFormatStyle()
            'categoryFormatStyle.BackColor = Color.FromArgb(246, 236, 214)
            'categoryFormatStyle.ForeColor = Color.FromArgb(217, 175, 70)

            Dim condition As ScheduleFormatCondition = New ScheduleFormatCondition(field, Janus.Windows.Schedule.ConditionOperator.GreaterThan, 0)
            condition.ImageIndex1 = 0

            condition.FormatStyle = categoryFormatStyle
            Me.ScheduleCitas.FormatConditions.Add(condition)


            'Formatear citas en Schedule
            Dim sfc As ScheduleFormatCondition
            sfc = New ScheduleFormatCondition(ScheduleCitas.Fields("CONFIRMADA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S")
            sfc.FormatStyle.BackColor = Color.Silver
            ScheduleCitas.FormatConditions.Add(sfc)

            Dim sfc2 As ScheduleFormatCondition
            sfc2 = New ScheduleFormatCondition(ScheduleCitas.Fields("ATENDIDO"), Janus.Windows.Schedule.ConditionOperator.Equal, "S")
            sfc2.FormatStyle.BackColor = Color.FromArgb(70, 200, 200)
            ScheduleCitas.FormatConditions.Add(sfc2)

            Dim sfc3 As ScheduleFormatCondition
            sfc3 = New ScheduleFormatCondition(ScheduleCitas.Fields("FALTA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S")
            sfc3.FormatStyle.BackColor = Color.FromArgb(220, 120, 100)
            ScheduleCitas.FormatConditions.Add(sfc3)

            Dim sfc4 As ScheduleFormatCondition
            sfc4 = New ScheduleFormatCondition(ScheduleCitas.Fields("PAGADA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S")
            sfc4.FormatStyle.BackColor = Color.FromArgb(120, 240, 120)
            ScheduleCitas.FormatConditions.Add(sfc4)

            Dim sfc6 As ScheduleFormatCondition
            Dim ccondition As New ScheduleFilterCondition

            ccondition.AddCondition(New ScheduleFilterCondition(ScheduleCitas.Fields("PAGADA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S"))
            ccondition.AddCondition(New ScheduleFilterCondition(ScheduleCitas.Fields("FALTA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S"))
            sfc6 = New ScheduleFormatCondition(ScheduleCitas.Fields("FALTA"), Janus.Windows.Schedule.ConditionOperator.Equal, "S")
            sfc6.FilterCondition = ccondition
            sfc6.FormatStyle.ForeColor = Color.Red
            ScheduleCitas.FormatConditions.Add(sfc6)

            If Globales.Configuracion.Cita_UsarSalas Then
                Dim sfc5 As ScheduleFormatCondition
                sfc5 = New ScheduleFormatCondition(ScheduleCitas.Fields("ID_SALA"), Janus.Windows.Schedule.ConditionOperator.NotIsNull, Nothing)
                sfc5.ImageIndex2 = 1
                ScheduleCitas.FormatConditions.Add(sfc5)
            End If


            'Formatear citas en Grid
            Dim fc As GridEXFormatCondition
            fc = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("CONFIRMADA"), _
                Janus.Windows.GridEX.ConditionOperator.Equal, "S")

            fc.FormatStyle.BackColor = Color.Silver
            GridEX1.RootTable.FormatConditions.Add(fc)

            Dim fc2 As GridEXFormatCondition
            fc2 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("ATENDIDO"), _
                Janus.Windows.GridEX.ConditionOperator.Equal, "S")
            fc2.FormatStyle.BackColor = Color.FromArgb(70, 200, 200)
            GridEX1.RootTable.FormatConditions.Add(fc2)

            Dim fc3 As GridEXFormatCondition
            fc3 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("FALTA"), _
                Janus.Windows.GridEX.ConditionOperator.Equal, "S")
            fc3.FormatStyle.BackColor = Color.FromArgb(220, 120, 100)
            GridEX1.RootTable.FormatConditions.Add(fc3)

            Dim fc4 As GridEXFormatCondition
            fc4 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("PAGADA"), _
                Janus.Windows.GridEX.ConditionOperator.Equal, "S")
            fc4.FormatStyle.BackColor = Color.FromArgb(120, 240, 120)
            GridEX1.RootTable.FormatConditions.Add(fc4)

        End Sub

#End Region



        '#Region "Private Sub Toogled( ByVal selected As Boolean)"
        '        Private Sub ToogleGrid(ByRef Grid As GridEX, ByVal selected As Boolean)
        '            If selected Then
        '                Grid.CheckAllRecords()
        '            Else
        '                Grid.UnCheckAllRecords()
        '            End If

        '        End Sub
        '#End Region

#Region "Private Sub MUTUASDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MUTUASDataGridView.CellMouseClick"
        Private Sub MUTUASDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
            Filtrar()
        End Sub
#End Region


#Region "Citas"



#Region "Private Sub LoadCitas(ByVal startDate As Date, ByVal endDate As Date)"
        Private Sub LoadCitas()

            Dim startDate As Date = FiltroGenericoDocumentos.FirstDate(ScheduleCitas.DateRange.Start)
            Dim endDate As Date = FiltroGenericoDocumentos.LastDate(ScheduleCitas.DateRange.End)

            context = New CMLinqDataContext()

            Dim citas As New List(Of CITA)

            If IdPaciente = -1 Then
                citas = (From c In context.CITAs Select c _
                    Where c.FECHA >= startDate And c.FECHA <= endDate And c.Eliminado = False Order By c.FECHA Ascending).ToList()
            Else
                citas = (From c In context.CITAs Select c _
                    Where c.FECHA >= dtpFechaInicio.Value And c.FECHA <= dtpFechaFinal.Value And c.Eliminado = False _
                          And c.REFPACIENTE = IdPaciente _
                    Order By c.FECHA Descending).ToList()
            End If


            Me.CITABindingSource.DataSource = citas

            Filtrar()

            MuestraNota()
        End Sub
#End Region


#Region "Private Sub ScheduleCitas_AppointmentRead(ByVal sender As System.Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleCitas.AppointmentRead"
        Private Sub ScheduleCitas_AppointmentRead(ByVal sender As System.Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleCitas.AppointmentRead
            Dim cita As CITA = e.Appointment.DataRow
            Try

                Dim lista As New List(Of String)


                'Hay que componer lo que se muestra en la cita basado en la configuracion
                Dim nota As String = ""

                'Mostrar paciente
                If Globales.Configuracion.citapac = True Then
                    nota += "[" & cita.PACIENTE1.CPACIENTE & "] "

                    If Globales.Configuracion.citaCodPropioPac Then
                        nota += "(C.Propio: " & cita.PACIENTE1.CODIGOPROPIO & ") "
                    End If

                    If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
                        nota += cita.PACIENTE1.NombreCompletoA1A2Nombre()
                    Else
                        nota += cita.PACIENTE1.NombreCompleto()
                    End If

                    lista.Add(nota)
                    'nota += vbCrLf
                End If

                If Globales.Configuracion.citamed = True Then
                    'nota += " Médico: " & cita.MEDICO.NOMBRE + " " + cita.MEDICO.APELLIDO1 + " " + cita.MEDICO.APELLIDO2
                    lista.Add(" Médico: " & cita.MEDICO.NOMBRE + " " + cita.MEDICO.APELLIDO1 + " " + cita.MEDICO.APELLIDO2)

                End If

                If Globales.Configuracion.citaesp = True And Not cita.MEDICO.ESPECIALIDAD Is Nothing Then
                    If cita.MEDICO.ESPECIALIDAD.Trim() <> "" Then
                        'nota += " Especialidad: " & cita.MEDICO.ESPECIALIDAD
                        lista.Add(" Especialidad: " & cita.MEDICO.ESPECIALIDAD)

                    End If
                End If
                'lista.Add(vbCrLf)
                nota += vbCrLf

                If Globales.Configuracion.citanote = True Then
                    'nota = nota & "==========================================="
                    lista.Add("===========================================")

                    For Each linea As LineasCita In cita.LineasCitas
                        'e.Appointment.Description += ("  - " & linea.DESCRIPCION & vbCrLf)
                        e.Appointment.Description += ("  - " & linea.DESCRIPCION & vbCrLf)

                    Next
                End If

                If Globales.Configuracion.Cita_UsarSalas Then
                    If Not cita.ID_SALA Is Nothing Then
                        'nota = nota & vbCrLf & "SALA: " & cita.SALA.Nombre
                        lista.Add("SALA: " & cita.SALA.Nombre)

                    End If
                End If


                e.Appointment.Text = String.Join(vbCrLf, lista.ToArray())

                'Globals.ColoreaCitas(cita.CONFIRMADA, cita.ATENDIDO, cita.FALTA, cita.PAGADA, e.Appointment.FormatStyle.BackColor, e.Appointment.FormatStyle.ForeColor)
                'e.Handled = False
            Catch ex As Exception
            End Try
        End Sub
#End Region

#End Region

#Region "Private Sub CargarSalasOwners()"
        Private Sub CargarSalasOwners()

            Dim salas As List(Of SALA) = (From s In context.SALAs Select s).ToList()
            SALABindingSource.DataSource = salas
            SalasOwners = (From s In salas Select New ScheduleAppointmentOwner(s.ID_SALA, s.Nombre)).ToArray()

            'ScheduleSalas.MultiOwner = True ' Globales.Configuracion.Calendario_MostrarListaMedicosPorDefecto
            'ScheduleSalas.Date = Date.Now

            'ScheduleSalas.ShowTimeAsClocks = False
            'ScheduleSalas.Owners.Clear()

            'ScheduleSalas.Owners.AddRange(SalasOwners)       
            'Me.ScheduleSalas.DayColumns = salas.Count


        End Sub
#End Region
#Region "Medicos"




#Region "Private Sub CargarMedicosOwners()"
        Private Sub CargarMedicosOwners()
            ScheduleCitas.Owners.Clear()

            If Globales.Usuario.REFMEDICO.HasValue And Globales.Configuracion.Calendario_SiUsuarioMedicoMostrarSoloSusCitas = True Then
                'El usuario es medico asi que se deben mostrar solo sus citas
                GridEXMedicos.DataSource = (From m In context.MEDICOs _
                    Where m.CMEDICO = centro_medico.Globales.Usuario.REFMEDICO And (Not m.Eliminado.HasValue Or m.Eliminado = False) _
                    Select New With {.CMEDICO = m.CMEDICO, .text = m.NOMBRECOMPLETO}).ToArray()
            Else
                GridEXMedicos.DataSource = (From m In context.MEDICOs Where Not m.Eliminado.HasValue Or m.Eliminado = False _
                    Select New With {.CMEDICO = m.CMEDICO, .text = m.NOMBRECOMPLETO}).ToArray()
            End If


            If Globales.Usuario.REFMEDICO.HasValue And Globales.Configuracion.Calendario_SiUsuarioMedicoMostrarSoloSusCitas = True Then
                'El usuario es medico asi que se deben mostrar solo sus citas
                MedicosOwners = (From m In context.MEDICOs Where (Not m.Eliminado.HasValue Or m.Eliminado = False) And m.CMEDICO = centro_medico.Globales.Usuario.REFMEDICO Select New ScheduleAppointmentOwner(m.CMEDICO, FormateaNombre(m))).ToArray()
            Else
                MedicosOwners = (From m In context.MEDICOs Where (Not m.Eliminado.HasValue Or m.Eliminado = False) Select New ScheduleAppointmentOwner(m.CMEDICO, FormateaNombre(m))).ToArray()
            End If

            ColoreaMedicos()


            'GridEXMedicos.DataSource = medicos
            'ScheduleCitas.Owners.AddRange(MedicosOwners)
            'Me.ScheduleCitas.DayColumns = MedicosOwners.Count        
        End Sub
#End Region

        Private Sub ColoreaMedicos()

            For Each row As GridEXRow In GridEXMedicos.GetRows()
                Dim idMedico As Integer = row.DataRow.CMEDICO
                Dim dia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(idMedico, Calendar2.CurrentDate)
                Dim medico As MEDICO = (From a In context.MEDICOs Where a.CMEDICO = idMedico Select a).SingleOrDefault
                Dim fechas As New List(Of Date)
                Dim horarioespecial As Boolean = False
                fechas.Add(Calendar2.CurrentDate)
                If medico.horasOcupadas(fechas, context).ToList.Count > 0 Then
                    horarioespecial = True
                End If
                row.BeginEdit()
                If horarioespecial = True Then
                    row.Cells(4).Value = 1
                Else
                    row.Cells(4).Value = 0
                End If

                If dia = ctrlHorarios.TipoFecha.DiasLaborables Then
                    row.Cells("columnStatus").Value = 1
                    row.Cells("Text").ToolTipText = "Disponible"
                Else

                    row.Cells("columnStatus").Value = 2
                    row.Cells(0).ToolTipText = "No disponible en la fecha seleccionada " & Calendar2.CurrentDate.ToShortDateString()
                    row.Cells(1).ToolTipText = "No disponible en la fecha seleccionada " & Calendar2.CurrentDate.ToShortDateString()
                    row.Cells(2).ToolTipText = "No disponible en la fecha seleccionada " & Calendar2.CurrentDate.ToShortDateString()
                End If
                row.EndEdit()
                'Dim dias As List(Of Date) = GetDiasNoLaborables(idMedico)

                'row.BeginEdit()
                'If dias.Count = 0 Then
                '    row.Cells("columnStatus").Value = 1
                'End If

                'If dias.Count = 1 And (Calendar2.SelectionRange.End - Calendar2.SelectionRange.Start).Days = 1 Then
                '    row.Cells("columnStatus").Value = 2
                '    row.Cells("Text").ToolTipText = "No disponible en esta fecha"
                'End If
                'If dias.Count > 1 And (Calendar2.SelectionRange.End - Calendar2.SelectionRange.Start).Days > 1 Then
                '    row.Cells("columnStatus").Value = 3
                '    row.Cells("Text").ToolTipText = GetOcupadoString(GetDiasNoLaborables(idMedico))
                'End If

                'row.EndEdit()

            Next
            

            'GridEXMedicos.Refresh()
        End Sub

        Function GetDiasNoLaborables(ByVal idMedico As Integer) As List(Of Date)
            Dim ini As Date = Calendar2.SelectionRange.Start
            Dim fin As Date = Calendar2.SelectionRange.End
            Dim dia As ctrlHorarios.TipoFecha = ctrlHorarios.TipoFecha.DiasLaborables

            Dim diasNoLaborables As New List(Of Date)

            While ini.ToShortDateString <> fin.ToShortDateString
                dia = CalendarioManager.DameTipoDiaDe(idMedico, ini)
                If dia <> ctrlHorarios.TipoFecha.DiasLaborables Then
                    diasNoLaborables.Add(ini)
                End If
                ini = ini.AddDays(1)
            End While

            Return diasNoLaborables

        End Function

        'Private Function GetOcupadoString(ByVal lista As List(Of Date)) As String
        '    Dim str As String = "Dias no laborables"
        '    For Each d As Date In lista
        '        str = str & ", " & d.ToShortDateString()
        '    Next
        '    Return str
        'End Function




#Region "Private Sub CargarMutuas()"
        Private Sub CargarMutuas()
            Dim mutuas = (From m In context.MUTUAs Select m)
            MUTUABindingSource.DataSource = mutuas
        End Sub
#End Region

        Public Sub Filtrar()
            FiltrarSchedule()
            FiltrarGrid()
        End Sub

#Region "Private Sub FiltrarGrid()"

        Private Sub FiltrarGrid()
            Dim condition As New GridEXFilterCondition()

            Dim medicoCondition As New GridEXFilterCondition()
            For Each row As Janus.Windows.GridEX.GridEXRow In GridEXMedicos.GetCheckedRows()
                Dim m = row.DataRow
                medicoCondition.AddCondition(Janus.Windows.GridEX.LogicalOperator.Or, _
                                             New GridEXFilterCondition(GridEX1.RootTable.Columns("REFMEDICO"), Janus.Windows.GridEX.ConditionOperator.Equal, m.CMEDICO))

            Next
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, medicoCondition)


            If rb_atendidos.Checked Then

                condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                                       New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), Janus.Windows.GridEX.ConditionOperator.Equal, "S"))
            End If

            If rb_pendientes.Checked Then
                condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                                       New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), Janus.Windows.GridEX.ConditionOperator.Equal, "N"))
            End If

            Dim mutuaCondition As New GridEXFilterCondition()

            For Each row As Janus.Windows.GridEX.GridEXRow In GridEXMutuas.GetCheckedRows()
                Dim mutua As MUTUA = row.DataRow
                mutuaCondition.AddCondition(Janus.Windows.GridEX.LogicalOperator.Or, _
                                            New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), Janus.Windows.GridEX.ConditionOperator.Equal, mutua.CMUTUA))

            Next
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, mutuaCondition)

            'Salas
            Dim salaConditions As New GridEXFilterCondition()
            For Each row As Janus.Windows.GridEX.GridEXRow In GridEXSalas.GetCheckedRows()
                Dim sala As SALA = row.DataRow
                salaConditions.AddCondition(Janus.Windows.Schedule.LogicalOperator.Or, _
                                            New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_SALA"), Janus.Windows.GridEX.ConditionOperator.Equal, sala.ID_SALA))
            Next
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, salaConditions)

            If rbPorSala.Checked Then
                condition.AddCondition(Janus.Windows.Schedule.LogicalOperator.And, _
                                       New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_SALA"), Janus.Windows.GridEX.ConditionOperator.NotIsNull, Nothing))

            End If

            If Not GridEX1.RootTable Is Nothing Then
                GridEX1.RootTable.FilterCondition = Nothing
                GridEX1.RootTable.FilterCondition = condition
                'GridEX1.RootTable.ApplyFilter(condition)
            End If


        End Sub
#End Region

#Region "Private Sub FiltrarSchedule()"

        Private Sub FiltrarSchedule()
            Dim condition As New ScheduleFilterCondition()
            Dim conditionSalas As New ScheduleFilterCondition()


            Dim medicosCondition As New ScheduleFilterCondition()
            For Each row As Janus.Windows.GridEX.GridEXRow In GridEXMedicos.GetRows()
                Dim m = row.DataRow
                Try

                    MedicosOwners(row.RowIndex).Visible = (row.IsChecked)
                    If row.IsChecked Then
                        medicosCondition.AddCondition(Janus.Windows.Schedule.LogicalOperator.Or, _
                                                      New ScheduleFilterCondition(ScheduleCitas.Fields("REFMEDICO"), Janus.Windows.GridEX.ConditionOperator.Equal, m.CMEDICO))

                    End If

                Catch ex As Exception
                End Try
            Next
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, medicosCondition)



            If rb_atendidos.Checked Then
                condition.AddCondition(Janus.Windows.Schedule.LogicalOperator.And, _
                                       New ScheduleFilterCondition(ScheduleCitas.Fields("ATENDIDO"), Janus.Windows.GridEX.ConditionOperator.Equal, "S"))
            End If



            If rb_pendientes.Checked Then
                condition.AddCondition(Janus.Windows.Schedule.LogicalOperator.And, _
                                       New ScheduleFilterCondition(ScheduleCitas.Fields("ATENDIDO"), Janus.Windows.GridEX.ConditionOperator.Equal, "N"))
            End If


            If GridEXMutuas.GetCheckedRows().Count > 0 Then
                Dim mutuaCondition As New ScheduleFilterCondition()
                For Each row As Janus.Windows.GridEX.GridEXRow In GridEXMutuas.GetCheckedRows()
                    Dim mutua As MUTUA = row.DataRow
                    mutuaCondition.AddCondition(Janus.Windows.Schedule.LogicalOperator.Or, _
                                                New ScheduleFilterCondition(ScheduleCitas.Fields("REFPROCEDENCIA"), Janus.Windows.GridEX.ConditionOperator.Equal, mutua.CMUTUA))
                Next
                condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, mutuaCondition)
            End If


            If GridEXSalas.GetCheckedRows().Count > 0 Then
                Dim salaConditions As New ScheduleFilterCondition()
                For Each row As Janus.Windows.GridEX.GridEXRow In GridEXSalas.GetCheckedRows()
                    Dim sala As SALA = row.DataRow
                    salaConditions.AddCondition(Janus.Windows.Schedule.LogicalOperator.Or, _
                                                New ScheduleFilterCondition(ScheduleCitas.Fields("ID_SALA"), Janus.Windows.GridEX.ConditionOperator.Equal, sala.ID_SALA))
                Next
                condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, salaConditions)

            End If


            'Sala
            If rbPorSala.Checked Then
                condition.AddCondition(Janus.Windows.Schedule.LogicalOperator.And, _
                                       New ScheduleFilterCondition(ScheduleCitas.Fields("ID_SALA"), Janus.Windows.GridEX.ConditionOperator.NotIsNull, Nothing))

            End If


            ScheduleCitas.FilterCondition = Nothing
            ScheduleCitas.FilterCondition = condition
            GC.Collect()
        End Sub
#End Region





#Region "Private Function FormateaNombre(ByVal medico As MEDICO) As String"
        Private Function FormateaNombre(ByVal medico As MEDICO) As String
            Dim nombres As New List(Of String)

            If Not medico Is Nothing Then
                If Not medico.APELLIDO1 Is Nothing Then
                    If medico.APELLIDO1.Trim().Length > 0 Then nombres.Add(medico.APELLIDO1)
                End If
                If Not medico.APELLIDO2 Is Nothing Then
                    If medico.APELLIDO2.Trim().Length > 0 Then nombres.Add(medico.APELLIDO2)
                End If

                If Not medico.NOMBRE Is Nothing Then
                    If medico.NOMBRE.Trim().Length > 0 Then nombres.Add(medico.NOMBRE)
                End If
                Return String.Join(", ", nombres.ToArray())
            End If
            Return "Sin nombre"
        End Function
#End Region

        '#Region "Public Sub BuscaNuevoOwner(ByVal ownerindex As Integer)"
        '    Public Sub BuscaNuevoOwner(ByVal ownerindex As Integer)
        '        For Each row As DataGridViewRow In MEDICOSDataGridView.Rows
        '            If row.Index <> ownerindex Then
        '                'Asignarle el owner a otro medico visible
        '                If ScheduleCitas.Owners(row.Index).Visible = True Then
        '                    ScheduleCitas.CurrentOwner = ScheduleCitas.Owners(row.Index)
        '                    ScheduleCitas.Owners(ownerindex).Visible = False
        '                    Return
        '                End If
        '            End If
        '        Next
        '        'Si llega aqui es que todos los owners estaban ocultos excepto el current owner so
        '        Dim t As ScheduleAppointmentOwner = ScheduleCitas.CurrentOwner

        '        'ScheduleCitas.MultiOwner = False
        '        'ScheduleCitas.CurrentOwner = Nothing

        '        't.Visible = False
        '        chkMostrarCitasPerDoctor.Checked = False
        '        MEDICOSDataGridView.Rows(ownerindex).Cells(columChkMedico.Index).Value = True

        '        'ScheduleCitas.MultiOwner = True
        '        'chb_filtrar.Checked = False
        '    End Sub
        '#End Region

#End Region

#Region "Filtros Pacientes"
        Private Sub rb_atendidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_atendidos.CheckedChanged
            Filtrar()
        End Sub

        Private Sub rb_pendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pendientes.CheckedChanged
            Filtrar()
        End Sub

        Private Sub rb_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged
            Filtrar()
        End Sub
#End Region

#Region "Private Sub ScheduleCitas_SelectedAppointmentsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleCitas.SelectedAppointmentsChanged"
        Private Sub ScheduleCitas_SelectedAppointmentsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleCitas.SelectedAppointmentsChanged
            tstEliminar.Enabled = ScheduleCitas.SelectedAppointments.Count > 0
            tstModificar.Enabled = ScheduleCitas.SelectedAppointments.Count > 0
            tstVer.Enabled = ScheduleCitas.SelectedAppointments.Count > 0
            tstDuplicarCita.Enabled = ScheduleCitas.SelectedAppointments.Count > 0
            'tstDuplicarCita.Enabled = ScheduleCitas.SelectedAppointments.Count > 0
            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                tstEliminar.Enabled = (cita.PAGADA = "N") Or Globales.Usuario.EsAdministrador
            End If

        End Sub
#End Region

#Region "Private Sub ScheduleCitas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScheduleCitas.MouseDown"
        Private Sub ScheduleCitas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScheduleCitas.MouseDown

            Dim hit As HitTest = ScheduleCitas.HitTest(e.X, e.Y)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then
                If (hit = HitTest.Appointment) Then
                    Dim appointment As ScheduleAppointment = ScheduleCitas.GetAppointmentAt(e.X, e.Y)
                    appointment.Selected = True
                    ScheduleCitas.ContextMenuStrip = menu_citas
                    ReflejaEstadoCitaEnContextMenu(appointment.DataRow)
                Else
                    ScheduleCitas.ContextMenuStrip = Nothing
                End If
            End If

            If hit = HitTest.Schedule Then
                userSelected = True
            End If
        End Sub
#End Region


        'Private Sub ScheduleSalas_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        '    Dim hit As HitTest = ScheduleSalas.HitTest(e.X, e.Y)
        '    If (e.Button = Windows.Forms.MouseButtons.Right) Then
        '        If (hit = HitTest.Appointment) Then
        '            Dim appointment As ScheduleAppointment = ScheduleSalas.GetAppointmentAt(e.X, e.Y)
        '            appointment.Selected = True
        '            ScheduleSalas.ContextMenuStrip = menu_citas
        '            ReflejaEstadoCitaEnContextMenu(appointment.DataRow)
        '        Else
        '            ScheduleSalas.ContextMenuStrip = Nothing
        '        End If
        '    End If

        '    If hit = HitTest.Schedule Then
        '        userSelected = True
        '    End If
        'End Sub



        Private Function GetHoraInicio() As Date

            Return ScheduleCitas.SelectedDays.Start
        End Function



        Private Function BuscaCapacidadParaCita(p1 As Date, timeSpan As TimeSpan, p3 As Boolean, scheduleAppointmentOwner As ScheduleAppointmentOwner) As Date

            Dim fecha As Date = ScheduleCitas.FindFreeTimeSlot(p1, New TimeSpan(0, Globales.Configuracion.citainterval, 0), p3, scheduleAppointmentOwner)

            'If Not scheduleAppointmentOwner Is Nothing Then
            '    Dim medico As MEDICO = scheduleAppointmentOwner.Tag
            '    If CalendarioManager.DameTipoDiaDe(medico.CMEDICO, Now) <> ctrlHorarios.TipoFecha.DiasLaborables Then
            '    End If
            'End If


            Return fecha

            ' DameHoraNuevaCita(dgv_medicos.SelectedRows(0).Cells("Id").Value)
        End Function


#Region "Botones de la Barra superior"

        Private Sub tstNuevaCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevaCitas.Click





            Me.Estado = EstadoCalendario.Annadiendo

            Dim horaini As DateTime
            Dim horafin As DateTime
            'Verificar el Demo
            If My.Settings.Demo = True Then
                If ScheduleCitas.Appointments.Count > 5 Then
                    MessageBox.Show("Usted ha excedido el número de citas para este Demo")
                    tstNuevaCitas.Enabled = False
                    Return
                End If
            End If



            Dim _nueva_cita As form_citas = New form_citas("Ficha de citas-Añadir", Enums.Accion.Insertar, Calendar2.CurrentDate, Nothing)

            'Owner por Salas
            If rbPorSala.Checked Then
                If Not ScheduleCitas.CurrentOwner Is Nothing Then
                    _nueva_cita.CtrlSalasvb1.ID_SALA = ScheduleCitas.CurrentOwner.Value
                End If
            End If

            If rbPorMedicos.Checked Then
                If Not ScheduleCitas.CurrentOwner Is Nothing Then
                    _nueva_cita.CtrlMedico1.ID_Medico = ScheduleCitas.CurrentOwner.Value

                End If
            End If



            If IdPaciente <> -1 Then
                _nueva_cita.CtrlPaciente1.ID_PACIENTE = IdPaciente
                _nueva_cita.CtrlPaciente1.Enabled = False
            End If

            _nueva_cita.ShowInTaskbar = False
            _nueva_cita.CtrlMedico1.Enabled = False

            If GridEXMedicos.GetCheckedRows().Count = 1 Then
                _nueva_cita.CtrlMedico1.ID_Medico = GridEXMedicos.GetCheckedRows(0).DataRow.CMEDICO
            Else
                '_nueva_cita.CtrlMedico1.ID_Medico = MEDICOSDataGridView.Rows(0).Cells("CMEDICO").Value
            End If





            If userSelected Then
                '_nueva_cita.dtp_fecha.Value = ScheduleCitas.SelectedDays.Start
                'horaini = ScheduleCitas.SelectedDays.Start
                _nueva_cita.dtp_fecha.Value = GetHoraInicio()
                horaini = GetHoraInicio()

                horafin = horaini.AddMinutes(Globales.Configuracion.citainterval)

            Else
                _nueva_cita.dtp_fecha.Value = New Date(Calendar2.CurrentDate.Year, Calendar2.CurrentDate.Month, Calendar2.CurrentDate.Day, Date.Now.Hour, Date.Now.Minute, 0)
                'horaini = ScheduleCitas.FindFreeTimeSlot(_nueva_cita.dtp_fecha.Value, _
                '                                         New TimeSpan(0, Globales.Configuracion.citainterval, 0), _
                '                                         False, _
                '                                         ScheduleCitas.CurrentOwner) ' DameHoraNuevaCita(dgv_medicos.SelectedRows(0).Cells("Id").Value)

                horaini = BuscaCapacidadParaCita(_nueva_cita.dtp_fecha.Value, _
                                                 New TimeSpan(0, Globales.Configuracion.citainterval, 0), _
                                                 False, _
                                                 ScheduleCitas.CurrentOwner) ' DameHoraNuevaCita(dgv_medicos.SelectedRows(0).Cells("Id").Value)

                horafin = horaini.AddMinutes(Globales.Configuracion.citainterval)
            End If

            _nueva_cita.tb_horainicio.Value = horaini
            _nueva_cita.tb_horafin.Value = horafin
            _nueva_cita.dtp_fechacobro.Value = _nueva_cita.dtp_fecha.Value
            _nueva_cita.DesdeCalendario = True

         
            If Not _nueva_cita.CtrlMedico1.ID_Medico.HasValue Then
                'No hay medico seleccionado, ni como usuario, ni como owner, ni marcado, ni el usuario es medico
                'Seleccionar el primero de la lista
                If Not MedicosOwners Is Nothing Then
                    If MedicosOwners.Count > 0 Then
                        _nueva_cita.CtrlMedico1.ID_Medico = MedicosOwners(0).Value
                    End If
                End If
            End If

            If _nueva_cita.CtrlMedico1.ID_Medico.HasValue Then
                Dim idMedico As Integer = _nueva_cita.CtrlMedico1.ID_Medico
                Dim tipodia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(idMedico, _nueva_cita.dtp_fecha.Value)
                If tipodia <> ctrlHorarios.TipoFecha.DiasLaborables Then

                    If MessageBox.Show("La fecha/hora seleccionada es no laborable para este médico. ¿Desea crear la cita de todas formas?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                        Return
                    End If
                End If
            End If

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Citas, "Citas", "Nuevo", "")

            _nueva_cita.ShowDialog()
            'CargarSalasOwners()
            'CargarMedicosOwners()
            LoadCitas()

            'rbTodas.Checked = True


            Estado = EstadoCalendario.Idle
            GC.Collect()
        End Sub


        'Public Function EsFechaLaborableParaMedico(ByVal fecha As Date, ByVal idMedico As Integer)
        '    Dim tipodia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(idMedico, fecha)
        '    If tipodia <> ctrlHorarios.TipoFecha.DiasLaborables Then
        '        return false
        '    End If
        '    return true
        'End Function



        Private Sub tstModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstModificar.Click

            Me.Estado = EstadoCalendario.Editando

            Dim cita As CITA = GetCurrentCita()

            If Not cita Is Nothing Then
                If Not Globales.VerificaSiCitaEstaEnUsoYSePuedeProceder(cita.IDCITA) Then Return

                Dim _nueva_cita As form_citas = New form_citas("Ficha de citas-Editar", Enums.Accion.Modificar, cita.IDCITA)
                _nueva_cita.ShowInTaskbar = False



                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Citas, "Citas", cita.IDCITA.ToString(), cita.PACIENTE)

                _nueva_cita.ShowDialog()

                Globales.CambiaEstadoRecurrencia(cita.IDCITA, Globales.EstadoRecurrencia.Libre)

                LoadCitas()
                If Not _nueva_cita.IsDisposed Then _nueva_cita.Dispose()
            End If
            Me.Estado = EstadoCalendario.Idle
            GC.Collect()
        End Sub

        Private Sub CITASDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
            tstModificar_Click(Nothing, Nothing)
        End Sub

        Private Sub ScheduleCitas_AppointmentDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleCitas.AppointmentDoubleClick
            tstModificar_Click(Nothing, Nothing)
        End Sub

        Private Sub ScheduleSalas_AppointmentDoubleClick(sender As System.Object, e As Janus.Windows.Schedule.AppointmentEventArgs)
            tstModificar_Click(Nothing, Nothing)
        End Sub


#Region "Private Sub tstVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstVer.Click"
        Private Sub tstVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstVer.Click

            Me.Estado = EstadoCalendario.Ver

            Dim cita As CITA = GetCurrentCita()

            If Not cita Is Nothing Then
                Dim _nueva_cita As form_citas = New form_citas("Ficha de citas-Ver", Enums.Accion.Ver, cita.IDCITA)
                _nueva_cita.ShowInTaskbar = False
                _nueva_cita.ShowDialog()

                LoadCitas()
            End If

            Me.Estado = EstadoCalendario.Idle
        End Sub
#End Region

#Region "Private Sub tstEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstEliminar.Click"
        Private Sub tstEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstEliminar.Click

            Me.Estado = EstadoCalendario.Borrando

            Dim cita As CITA = GetCurrentCita()

            Globales.EliminarCitaCorrectamente(cita, False)

            LoadCitas()
            Me.Estado = EstadoCalendario.Idle
            GC.Collect()
        End Sub
#End Region

#Region "Private Sub tstDuplicarCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstDuplicarCita.Click"

        Private Sub tstDuplicarCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstDuplicarCita.Click



            Me.Estado = EstadoCalendario.Duplicando

            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then


                If cita.REFMEDICO.HasValue Then
                    Dim tipodia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(cita.REFMEDICO, cita.FECHA)
                    If tipodia <> ctrlHorarios.TipoFecha.DiasLaborables Then
                        If MessageBox.Show("La fecha/hora seleccionada es no laborable para este médico. ¿Desea duplicar la cita de todas formas?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                            Return
                        End If

                    End If
                End If

                Dim nuevaCitaForm As form_citas_duplicar
                nuevaCitaForm = New form_citas_duplicar(cita.IDCITA)
                nuevaCitaForm.ShowInTaskbar = False
                If nuevaCitaForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Citas, "Duplicar Citas", cita.IDCITA.ToString(), cita.PACIENTE)

                    Dim context2 As New CMLinqDataContext()

                    Dim citaDuplicada As CITA = (From c In context2.CITAs
                                        Where c.IDCITA = nuevaCitaForm.IdNuevaCita
                                        Select c).SingleOrDefault()
                    If Not citaDuplicada Is Nothing Then
                        citaDuplicada.TipoCita = 0
                        context2.SubmitChanges()
                        Dim frmcita As New form_citas("Editar Cita Duplicada", Enums.Accion.Modificar, nuevaCitaForm.IdNuevaCita)
                        frmcita.ShowDialog()
                    End If
                End If
                LoadCitas()
            End If

            Estado = EstadoCalendario.Idle
            GC.Collect()
        End Sub

#End Region

#Region "Private Sub bt_imprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstImprimir.Click"
        Private Sub bt_imprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstImprimir.Click

            Me.Estado = EstadoCalendario.Imprimiendo

            Dim tipofiltro As String = ""
           

            Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource()
            If TabControl1.SelectedTab.Equals(TabListado) = True Then
                'Preparo el filtro para mostrarlo en el report
                tipofiltro += "Fecha desde: " & Me.Calendar2.DatesRange.Start & " hasta " & Me.Calendar2.DatesRange.End
                ds.Name = "centro_medico_CITA"

                Dim lista As List(Of WRAPPER_CITA) = (From row In GridEX1.GetDataRows Where row.IsVisible Select c = row.DataRow Select New WRAPPER_CITA(DirectCast(c, CITA))).ToList()

                ds.Value = lista

                Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
                parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & tipofiltro)
              
                UI.Reportes.ReportesManager.Imprime("CitasListado.rdlc", {ds}, parametros)

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir, RoleManager.Items.Citas, "Imprimir Calendario Citas", "FechaIncial:" & Calendar2.DatesRange.Start.ToShortDateString() & " - " & Calendar2.DatesRange.End.ToShortDateString(), "")
            Else
                Dim frm As New PrintDialog()
                frm.UseEXDialog = True
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then


                    Me.SchedulePrintDocument1.PrinterSettings = frm.PrinterSettings()
                    Me.SchedulePrintDocument1.Print()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir, RoleManager.Items.Citas, "Imprimir Calendario Citas", "FechaIncial:" & Calendar2.DatesRange.Start.ToShortDateString() & " - " & Calendar2.DatesRange.End.ToShortDateString(), "")

                End If

            End If

            Me.Estado = EstadoCalendario.Idle
            GC.Collect()
        End Sub
#End Region


        'Sub SetPrintParameters()
        '    'Set the parameters we need to be able to print
        '    Dim objPrinterSettings As New Printing.PageSettings
        '    PDPrintDocument.PrinterSettings.PrinterName = objPrinterSettings.PrinterSettings.PrinterName

        '    Dim objPaperKind As System.Drawing.Printing.PaperKind
        '    Select Case nPaperType
        '        Case ReportEditor.PAPER_TYPE._Letter
        '            objPaperKind = PaperKind.Letter
        '        Case ReportEditor.PAPER_TYPE._Legal
        '            objPaperKind = PaperKind.Legal
        '        Case ReportEditor.PAPER_TYPE._A4
        '            objPaperKind = PaperKind.A4
        '        Case ReportEditor.PAPER_TYPE._8X13
        '            objPaperKind = PaperKind.Folio
        '        Case Else
        '            'If the paper is custom then we have
        '            'to set it this way
        '            Dim objPaperSize As New System.Drawing.Printing.PaperSize
        '            objPaperSize.Height = (nPageHeight / 2.54) * 100
        '            objPaperSize.Width = (nPageWidth / 2.54) * 100
        '            objPaperSize.PaperName = "Custom"
        '            PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize
        '    End Select

        '    'With this 4 lines i solved the problem that when you print on different papers
        '    'always when you check the paper type in the print job you see the default paper
        '    For Each objPaperSize1 As PaperSize In PDPrintDocument.PrinterSettings.PaperSizes
        '        If objPaperSize1.Kind = objPaperKind Then
        '            PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize1
        '        End If
        '    Next

        '    'you will see this in the queue for the printer
        '    PDPrintDocument.DocumentName = My.Application.Info.ProductName & " - Countries list"
        'End Sub


#Region "Private Function GetCurrentCita() As CITA"
        Private Function GetCurrentCita() As CITA
            Dim idcita As Integer = -1
            Dim cita As CITA = Nothing

            If TabControl1.SelectedTab.Equals(tabCalendario) Then
                If ScheduleCitas.SelectedAppointments.Count > 0 Then
                    cita = ScheduleCitas.SelectedAppointments(0).DataRow
                End If
            End If
            If TabControl1.SelectedTab.Equals(TabListado) Then
                If GridEX1.SelectedItems.Count > 0 Then
                    If GridEX1.SelectedItems(0).GetRow().Parent Is Nothing Then
                        cita = GridEX1.SelectedItems(0).GetRow().DataRow
                    Else
                        cita = GridEX1.SelectedItems(0).GetRow().Parent.DataRow
                    End If

                End If
            End If

            'If TabControl1.SelectedTab.Equals(tabSalas) Then
            '    If ScheduleSalas.SelectedAppointments.Count > 0 Then
            '        cita = ScheduleSalas.SelectedAppointments(0).DataRow
            '    End If
            'End If

            Return cita
        End Function
#End Region

#End Region

#Region "Menu contextual Citas"

        Private Sub ModificarCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCitaToolStripMenuItem.Click
            tstModificar_Click(Nothing, Nothing)
        End Sub

        Private Sub VerCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerCitaToolStripMenuItem.Click
            tstVer_Click(Nothing, Nothing)
        End Sub

        Private Sub BorrarCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCitaToolStripMenuItem.Click
            tstEliminar_Click(Nothing, Nothing)
        End Sub

        Private Sub DuplicarCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicarCitaToolStripMenuItem.Click
            tstDuplicarCita_Click(Nothing, Nothing)
        End Sub

#Region "Private Sub ReflejaEstadoCitaEnContextMenu(ByVal cita As CITA)"
        Private Sub ReflejaEstadoCitaEnContextMenu(ByVal cita As CITA)
            If Not cita Is Nothing Then
                mi_atendida.Checked = (cita.ATENDIDO = "S")
                mi_confirmada.Checked = (cita.CONFIRMADA = "S")
                mi_cobrada.Checked = (cita.PAGADA = "S")

                mi_atendida.Enabled = (cita.PAGADA = "N")
                mi_confirmada.Enabled = (cita.PAGADA = "N")
                mi_cobrada.Enabled = (cita.PAGADA = "N")
                mi_cambiar.Enabled = (cita.PAGADA = "N")
                mi_falta.Checked = (cita.FALTA = "S")

                If cita.PAGADA = "S" Then
                    'mi_atendida.Enabled = False
                    'mi_confirmada.Enabled = False
                    'mi_falta.Enabled = False
                    'ModificarCitaToolStripMenuItem.Enabled = False
                    BorrarCitaToolStripMenuItem.Enabled = (cita.PAGADA = "N") Or Globales.Usuario.EsAdministrador
                    tstEliminar.Enabled = (cita.PAGADA = "N") Or Globales.Usuario.EsAdministrador
                End If

            End If
        End Sub
#End Region


        Private Sub mi_confirmada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_confirmada.Click
            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                If mi_confirmada.Checked Then
                    cita.CONFIRMADA = "S"
                Else
                    cita.CONFIRMADA = "N"
                End If

                context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
                LoadCitas()
            End If
        End Sub

        Private Sub mi_atendida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_atendida.Click

            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                If mi_atendida.Checked Then
                    cita.ATENDIDO = "S"
                Else
                    cita.ATENDIDO = "N"
                End If

                context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
                LoadCitas()
            End If
        End Sub

        Private Sub mi_falta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_falta.Click
            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                If mi_falta.Checked Then
                    cita.FALTA = "S"
                Else
                    cita.FALTA = "N"
                End If

                context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
                LoadCitas()
            End If
        End Sub

        Private Sub mi_cobrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_cobrada.Click
            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                If Not cita.TOTAL.HasValue Then
                    cita.TOTAL = cita.IMPORTECL + cita.IMPORTEDR - cita.Descuento
                End If

                If cita.TOTAL = 0 Then
                    cita.PAGADA = "S"
                    context.SubmitChanges()
                    Return
                End If
                Dim frm As New frmPacienteDebito()
                frm.CtrlPaciente1.ID_PACIENTE = cita.REFPACIENTE
                frm.PagarDirecto = True
                frm.IdsCitasPreseleccionadas.Add(cita.IDCITA)
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    mi_cobrada.Enabled = False
                End If

                LoadCitas()
            End If
        End Sub

        '#Region "Private Sub CITASDataGridView_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CITASDataGridView.MouseDown"
        '        Private Sub CITASDataGridView_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '            If e.Button = Windows.Forms.MouseButtons.Right Then
        '                'CITASDataGridView.Rows(CITASDataGridView.HitTest(e.X, e.Y).RowIndex).Selected = True
        '            End If
        '        End Sub
        '#End Region

#End Region


        Private Sub TimerCitas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCitas.Tick
            If Estado = EstadoCalendario.Idle Then
                ToolStrip1.Enabled = False
                menu_citas.Enabled = False
                'pbLoading.Visible = True
                'Me.ScheduleCitas.Enabled = False
                LoadCitas()
                ToolStrip1.Enabled = True
                menu_citas.Enabled = True
                Console.WriteLine(Now.ToString & " REFRES")
                'Me.ScheduleCitas.Enabled = True
                'pbLoading.Visible = False
            End If
        End Sub

        Private Sub frmCalendarioCitas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            TimerCitas.Stop()

        End Sub


        Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
            tstModificar.Enabled = GridEX1.SelectedItems.Count > 0
            tstEliminar.Enabled = GridEX1.SelectedItems.Count > 0
            tstDuplicarCita.Enabled = GridEX1.SelectedItems.Count > 0
            tstVer.Enabled = GridEX1.SelectedItems.Count > 0
        End Sub

        Private Sub GridEX1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridEX1.MouseDoubleClick
            If GridEX1.HitTest(e.X, e.Y) = GridArea.Cell Then
                tstModificar_Click(Nothing, Nothing)
            End If
        End Sub

        'Private Sub GridEX1_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.LoadingRow
        '    If e.Row.RowType = RowType.Record Then
        '        'You can get the values directly from the GridEXRow object
        '        If e.Row.Parent Is Nothing Then
        '            Dim nombremedico As String = e.Row.Cells("MEDICO.NOMBRE").Value & " " & e.Row.Cells("MEDICO.APELLIDO1").Value & " " & e.Row.Cells("MEDICO.APELLIDO2").Value
        '            e.Row.Cells("MEDICONOMBRECOMPLETO").Value = nombremedico.Trim()
        '            Try
        '                Dim paciente As PACIENTE = e.Row.DataRow.PACIENTE1
        '                Dim nombrepaciente As String = ""
        '                If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
        '                    nombrepaciente = paciente.NombreCompletoA1A2Nombre()
        '                Else
        '                    nombrepaciente = paciente.NombreCompleto()
        '                End If
        '                e.Row.Cells("PACIENTE").Text = nombrepaciente
        '            Catch ex As Exception

        '            End Try

        '        End If

        '    End If
        'End Sub

        Private Sub GridEXMedicos_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXMedicos.RowCheckStateChanged
            'Try
            '    MedicosOwners(e.Row.RowIndex).Visible = (e.CheckState = RowCheckState.Checked)
            'Catch ex As Exception

            'End Try
           
            Filtrar()
        End Sub

        Private Sub GridEXMutuas_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXMutuas.RowCheckStateChanged
            Filtrar()
        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            'If TabControl1.SelectedIndex = 2 Then
            '    Calendar2.Schedule = ScheduleSalas
            'Else
            '    Calendar2.Schedule = ScheduleCitas
            'End If
            ScheduleCitas.SelectedAppointments.Clear()
            GridEX1.SelectedItems.Clear()

        End Sub

        Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.ValueChanged
            If Me.IsHandleCreated Then
                LoadCitas()
                ScheduleCitas.Date = dtpFechaInicio.Value
            End If

        End Sub

        Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFinal.ValueChanged
            If Me.IsHandleCreated Then
                LoadCitas()
            End If

        End Sub



#Region "Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged"
        Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged

            If Me.IsHandleCreated Then
                Me.ScheduleCitas.WorkStartTime = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(Calendar2.SelectionRange.Start)
                Me.ScheduleCitas.WorkEndTime = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(Calendar2.SelectionRange.Start)

                Me.ScheduleCitas.DayStartHour = 0
                Me.ScheduleCitas.DayEndHour = 24

                Me.ScheduleCitas.DayStartHour = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(Calendar2.SelectionRange.Start).Hours
                Me.ScheduleCitas.DayEndHour = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(Calendar2.SelectionRange.Start).Hours + 1


                'Me.ScheduleCitas.EnsureVisible(Me.ScheduleCitas.WorkStartTime)
                LoadCitas()
                ColoreaMedicos()

            End If
           

            'Me.ScheduleCitas.Invalidate()
            'Me.ScheduleCitas.Refresh()
            'Me.ScheduleCitas.Update()
        End Sub
#End Region


        Private Sub ScheduleCitas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScheduleCitas.MouseDoubleClick
            Dim hit As HitTest = ScheduleCitas.HitTest(e.X, e.Y)
            If (hit = HitTest.Schedule) Then
                tstNuevaCitas_Click(Nothing, Nothing)
            End If
        End Sub


        'Private Sub ScheduleSalas_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        '    Dim hit As HitTest = ScheduleSalas.HitTest(e.X, e.Y)
        '    If (hit = HitTest.Schedule) Then
        '        tstNuevaCitas_Click(Nothing, Nothing)
        '    End If
        'End Sub



        Private Sub rbTodas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTodas.CheckedChanged
            If rbTodas.Checked Then
                ScheduleCitas.Owners.Clear()
                ScheduleCitas.MultiOwner = False
                Filtrar()
            End If

        End Sub


        Private Sub rbPorSala_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPorSala.CheckedChanged
            If rbPorSala.Checked Then
                'Cambiar el owner del Schedule
                ScheduleCitas.Owners.Clear()
                ScheduleCitas.Owners.AddRange(SalasOwners)
                ScheduleCitas.MultiOwner = True
                ScheduleCitas.OwnerMember = "ID_SALA"
                'Me.ScheduleCitas.DayColumns = SalasOwners.Count
                Filtrar()
            End If

        End Sub


        Private Sub rbPorMedicos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPorMedicos.CheckedChanged
            If rbPorMedicos.Checked Then
                'If Not ScheduleCitas.MultiOwner Then
                '    ScheduleCitas.CurrentOwner = Nothing
                'End If
                ScheduleCitas.Owners.Clear()
                ScheduleCitas.Owners.AddRange(MedicosOwners)
                ScheduleCitas.MultiOwner = True
                ScheduleCitas.OwnerMember = "REFMEDICO"
                'Me.ScheduleCitas.DayColumns = MedicosOwners.Count
                GridEXMedicos.CheckAllRecords()
                Filtrar()
            Else
                ''GridEXMedicos.UnCheckAllRecords()

            End If

        End Sub

        Private Sub GridEXSalas_RowCheckStateChanged(sender As System.Object, e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXSalas.RowCheckStateChanged
            Filtrar()
        End Sub


        'Private Sub GridEXMedicos_RowCheckStateChanging(sender As System.Object, e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs) Handles GridEXMedicos.RowCheckStateChanging
        '    If GridEXMedicos.GetCheckedRows().Count = 1 And e.CheckState = RowCheckState.Unchecked Then
        '        e.Cancel = True
        '    End If
        'End Sub


        Private Sub pb_NuevaNota_Click(sender As System.Object, e As System.EventArgs) Handles btnNota_Agregar.Click
            Try
                Dim nota As New NOTA
                nota.ID_Usuario = Globales.Usuario.CODIGO
                nota.Fecha = Date.Now

                Dim frm As New frmNotas_ADD()
                frm.NOMBRECOMPLETOTextBox.Text = Globales.Usuario.NOMBRECOMPLETO
                frm.NOTABindingSource.DataSource = nota

                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    context.NOTAs.InsertOnSubmit(nota)
                    context.SubmitChanges()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Citas, "NOTAS CITA", "", nota.Fecha.Value.ToString() & " - " _
                                                                                                                                       & nota.USUARIO.NOMBRECOMPLETO & vbCrLf & nota.NOTA)
                    MuestraNota()
                End If
            Catch ex As Exception

            End Try

        End Sub


        Dim notasContext As CMLinqDataContext

        Private Sub pbNotas_Delete_Click(sender As System.Object, e As System.EventArgs) Handles btnNota_Delete.Click
            Try
                If GridEXNotas.GetCheckedRows().Count = 0 Then
                    MessageBox.Show("No hay notas seleccionadas")
                    Return
                End If

                If MessageBox.Show("¿Desea eliminar esta(s) nota(s)?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    For Each row As GridEXRow In GridEXNotas.GetCheckedRows
                        Dim n As NOTA = row.DataRow
                        notasContext.NOTAs.DeleteOnSubmit(n)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Citas, "NOTAS CITA", "", n.Fecha.Value.ToString() & " - " _
                                                                                                                                         & n.USUARIO.NOMBRECOMPLETO & vbCrLf & n.NOTA)

                    Next
                    notasContext.SubmitChanges()

                    MuestraNota()
                End If
            Catch ex As Exception

            End Try


        End Sub

        Private Sub MuestraNota()
            currentNotas = Nothing
            GridEXNotas.DataSource = Nothing

            notasContext = New CMLinqDataContext()
            currentNotas = (From n As NOTA In notasContext.NOTAs
                Order By n.Fecha Descending
                Select n).ToList()

            NOTABindingSource.DataSource = currentNotas
            GridEXNotas.DataSource = NOTABindingSource
        End Sub


        Private Sub btnNota_Editar_Click(sender As System.Object, e As System.EventArgs) Handles btnNota_Editar.Click
            Try

                If Not GridEXNotas.GetRow() Is Nothing Then
                    Dim nota As NOTA = GridEXNotas.GetRow().DataRow
                    'nota.ID_Usuario = Globales.Usuario.CODIGO
                    'nota.Fecha = Date.Now


                    Dim frm As New frmNotas_ADD()
                    frm.NOMBRECOMPLETOTextBox.Text = nota.USUARIO.NOMBRECOMPLETO
                    frm.NOTABindingSource.DataSource = nota

                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        notasContext.SubmitChanges()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Citas, _
                                                        "NOTAS CITA", nota.ID_NOTA.ToString(), nota.Fecha.Value.ToString() & " - " _
                                                                                               & nota.USUARIO.NOMBRECOMPLETO & vbCrLf & nota.NOTA)
                        MuestraNota()
                    End If
                End If

            Catch ex As Exception

            End Try
        End Sub

        Private Sub GridEXNotas_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXNotas.RowDoubleClick
            If btnNota_Editar.Visible Then
                btnNota_Editar_Click(Nothing, Nothing)
            End If
        End Sub

      
        Private Sub tstImprimirJustificante_Click(sender As Object, e As EventArgs) Handles tstImprimirJustificante.Click
            Dim cita As CITA = GetCurrentCita()
            If Not cita Is Nothing Then
                Globales.ImprimeJustificante(cita)
            End If
            GC.Collect()
        End Sub

        Private Sub MuestraHorarioDialog()

            Dim mensaje As String = ""
            Dim id As Integer = Me.GridEXMedicos.CurrentRow.DataRow.cmedico
            Dim medico As MEDICO = (From o In context.MEDICOs Where o.CMEDICO = id Select o).SingleOrDefault
            Dim fechaselec As List(Of Date) = Calendar2.SelectedDates.ToList
            Dim horas As List(Of HORARIOS_MEDICOS) = medico.horasOcupadas(fechaselec, context).ToList

            For Each ho As HORARIOS_MEDICOS In horas
                mensaje = mensaje & "El horario de " & medico.NOMBRECOMPLETO & " el día " & ho.fecha & " es de " & ho.hora_ini.ToShortTimeString & " a " & ho.hora_fin.ToShortTimeString & ". " & vbCrLf
            Next

            If mensaje.Trim.Length > 0 Then
                Dim aviso As TestNotifyWindow.NotifyWindow = New TestNotifyWindow.NotifyWindow

                aviso.WaitOnMouseOver = True
                aviso.SetDimensions(500, 200)
                'aviso.BackColor = Color.FromArgb(253, 66, 57)
                'Me.aviso.Top = -500
                aviso.Text = mensaje

                aviso.Title = "Horario."
                aviso.Notify()
            End If




        End Sub

        Private Sub GridEXMedicos_DoubleClick(sender As Object, e As EventArgs) Handles GridEXMedicos.DoubleClick
            MuestraHorarioDialog()
        End Sub
    End Class

End Namespace