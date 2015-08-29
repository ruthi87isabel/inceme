Imports Janus.Windows.Schedule
Imports Janus.Windows.GridEX

Public Class frmSalas

    Public Context As New CMLinqDataContext
    Public Sala As SALA
    Public Modo As Globales.ModoParaFormas

    Public Appointment As ScheduleAppointment
    Public Cita As CITA
    Public FechaSugerida As Date = Date.Now
    Public ID_SALA As Integer

    'Public Duracion As TimeSpan


    Public Event HoraSugerida(ByVal fechainicio)

    Public AutoSugerir As Boolean = False

    Private Sub frmSalas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaSalas()
        Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas)
        tst_Eliminar.Visible = apermiso > RoleManager.TipoPermisos.Modificar
        tstNuevo.Visible = apermiso > RoleManager.TipoPermisos.Lectura
        tst_Editar.Visible = apermiso > RoleManager.TipoPermisos.Lectura

    End Sub

    Private Sub CargaSalas()
        SALABindingSource.DataSource = (From s In Context.SALAs
                                      Order By s.Nombre
                                      Select s).ToList()
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Try
            Dim sala As New SALA()

            Dim frm As New frmSalas_ADD
            frm.SALABindingSource.DataSource = sala
            If frm.ShowDialog() Then
                If Not Context.SALAs.Contains(sala) Then
                    Context.SALAs.InsertOnSubmit(sala)
                End If
                Context.SubmitChanges()
                SALABindingSource.Add(sala)
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Salas, "SALA", sala.ID_SALA, "SALA: " & sala.Nombre)
            Else
                SALABindingSource.ResetCurrentItem()
            End If
        Catch ex As Exception
            GridEXListado.Refresh()
        End Try
    End Sub


    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Try
            Dim frm As New frmSalas_ADD
            frm.SALABindingSource.DataSource = SALABindingSource.Current
            If frm.ShowDialog() Then
                Context.SubmitChanges()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXListado.RowDoubleClick

        If Modo = Globales.ModoParaFormas.Edicion Then
            Try
                tst_Editar_Click(Nothing, Nothing)
            Catch ex As Exception

            End Try
        Else
            If GridEXListado.SelectedItems.Count > 0 Then
                Try
                    Sala = GridEXListado.SelectedItems(0).GetRow().DataRow
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    GridEXListado.Refresh()
                End Try
            End If
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXListado.SelectionChanged
        tst_Editar.Enabled = GridEXListado.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEXListado.SelectedItems.Count > 0
        If Not GridEXListado.CurrentRow Is Nothing Then
            If GridEXListado.CurrentRow.RowType = RowType.Record Then
                If Not GridEXListado.CurrentRow.DataRow Is Nothing Then
                    Sala = GridEXListado.CurrentRow.DataRow
                End If
            End If
        End If
    End Sub


    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click

        If MessageBox.Show("¿Está seguro que desea eliminar esta sala?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try

                SALABindingSource.EndEdit()
                If GridEXListado.SelectedItems.Count > 0 Then
                    Dim sala As SALA = GridEXListado.SelectedItems(0).GetRow().DataRow

                    Dim context As New CMLinqDataContext
                    Dim salaBorrar As SALA = (From s In context.SALAs
                                             Where s.ID_SALA = sala.ID_SALA
                                             Select s).SingleOrDefault()


                    context.SALAs.DeleteOnSubmit(salaBorrar)
                    context.SubmitChanges()
                    GridEXListado.Delete()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Salas, "SALAS", sala.ID_SALA, "Sala:" & sala.Descripcion)
                End If
            Catch ex As Exception
            End Try
        End If

        'If Not SALABindingSource.Current Is Nothing Then
        '    Try
        '        SaveToolStripButton_Click(Nothing, Nothing)

        '        If Not Sala Is Nothing Then
        '            Dim con As New CMLinqDataContext()
        '            Dim idSala As Integer = Sala.ID_SALA
        '            Dim sal As SALA = (From s In con.SALAs
        '                              Where s.ID_SALA = idSala
        '                              Select s).SingleOrDefault()

        '            If Not sal Is Nothing Then
        '                con.SALAs.DeleteOnSubmit(sal)
        '                con.SubmitChanges()
        '                SALABindingSource.RemoveCurrent()
        '            End If
        '        End If


        '    Catch ex As Exception
        '        MessageBox.Show("Error:" & ex.Message)
        '    End Try

        '    'If MessageBox.Show("¿Está seguro que desea eliminar esta factura?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    '    Try
        '    '        If GridEXListado.SelectedItems.Count > 0 Then
        '    '            Dim factura As FACTURA = GridEXListado.SelectedItems(0).GetRow().DataRow
        '    '            Context.FACTURAs.DeleteOnSubmit(factura)
        '    '            GridEXListado.Delete()
        '    '            FACTURABindingSource.EndEdit()
        '    '            Context.SubmitChanges()
        '    '            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Facturas, "FACTURASM", factura.IDFACTURA, "FACTURA PACIENTE :" & factura.PACIENTE)
        '    '        End If
        '    '    Catch ex As Exception
        '    '    End Try
        '    'End If
        'End If

    End Sub


    '    Private Sub UiTabPage2_Click(sender As System.Object, e As System.EventArgs)

    '    End Sub

    '    Private Sub UiTab1_TabIndexChanged(sender As System.Object, e As System.EventArgs) Handles UiTab1.TabIndexChanged

    '    End Sub
    '    'Private Sub UiTab1_ChangingSelectedTab(sender As System.Object, e As Janus.Windows.UI.Tab.TabCancelEventArgs) Handles UiTab1.ChangingSelectedTab

    '    '    If e.Page.Index = 1 Then
    '    '        If SALABindingSource.Count = 0 Then
    '    '            MessageBox.Show("Debe crear alguna sala primero")
    '    '            e.Cancel = True
    '    '            Return
    '    '        End If
    '    '    End If


    '    'End Sub
    '    Private Sub UiTab1_SelectedTabChanged(sender As System.Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles UiTab1.SelectedTabChanged
    '        If UiTab1.SelectedIndex = 1 Then
    '            CargaSalas()
    '            SugerirCita()
    '        End If
    '    End Sub

    '    Private Sub CargaSalas()

    '        SALABindingSource.DataSource = (From s In Context.SALAs
    '                                      Order By s.Nombre
    '                                      Select s).ToList()


    '        Dim intervalo As Integer = Globales.Configuracion.citainterval
    '        Select Case intervalo
    '            Case 1 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.OneMinute
    '            Case 2 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.TwoMinutes
    '            Case 3 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.ThreeMinutes
    '            Case 4 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.FourMinutes
    '            Case 5 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
    '            Case 6 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.SixMinutes
    '            Case 7, 8, 9, 10, 11 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.TenMinutes
    '            Case 12, 13, 14 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
    '            Case 15, 16, 17, 18 : ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
    '            Case Else
    '                If intervalo > 19 And intervalo <= 58 Then ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
    '                If intervalo > 58 Then ScheduleSalas.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
    '        End Select
    '        Me.ScheduleSalas.WorkStartTime = New TimeSpan(0, centro_medico.Globales.Configuracion.JornadaLaboralInicio, 0, 0)
    '        Me.ScheduleSalas.DayStartHour = centro_medico.Globales.Configuracion.JornadaLaboralInicio
    '        Me.ScheduleSalas.WorkEndTime = New TimeSpan(0, centro_medico.Globales.Configuracion.JornadaLaboralFinal, 0, 0)
    '        Me.ScheduleSalas.DayEndHour = centro_medico.Globales.Configuracion.JornadaLaboralFinal


    '        ScheduleSalas.MultiOwner = True ' Globales.Configuracion.Calendario_MostrarListaMedicosPorDefecto
    '        ScheduleSalas.Date = Date.Now

    '        ScheduleSalas.ShowTimeAsClocks = False
    '        ScheduleSalas.Owners.Clear()
    '        Dim salas = (From s In Context.SALAs Select New ScheduleAppointmentOwner(s.ID_SALA, s.Nombre)).ToArray()
    '        'GridEXSalas.DataSource = salas

    '        ScheduleSalas.Owners.AddRange(salas)
    '        Me.ScheduleSalas.DayColumns = salas.Length

    '        Dim startDate As Date = ScheduleSalas.DateRange.Start
    '        Dim endDate As Date = ScheduleSalas.DateRange.End

    '        Context = New CMLinqDataContext()

    '        Dim citas As New List(Of CITA)


    '        citas = (From c In Context.CITAs Select c _
    '                Where c.FECHA >= startDate And c.FECHA <= endDate Order By c.FECHA Ascending).ToList()

    '        CITABindingSource.DataSource = citas

    '        dt_Duracion.Value = New Date(2000, 1, 1, 0, 0, 0).AddMinutes(Globales.Configuracion.citainterval)

    '        If salas.Length = 0 Then
    '            TabDisponibilidad.Enabled = False
    '            TabDisponibilidad.TabVisible = False
    '        End If


    '    End Sub


    '#Region "Private Sub ScheduleCitas_AppointmentRead(ByVal sender As System.Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleSalas.AppointmentRead"
    '    Private Sub ScheduleCitas_AppointmentRead(ByVal sender As System.Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs)
    '        Dim cita As CITA = e.Appointment.DataRow
    '        Try

    '            'Hay que componer lo que se muestra en la cita basado en la configuracion
    '            Dim nota As String = ""

    '            'Mostrar paciente
    '            If Globales.Configuracion.citapac = True Then
    '                nota += "[" & cita.PACIENTE1.CPACIENTE & "] "

    '                If Globales.Configuracion.citaCodPropioPac Then
    '                    nota += "(C.Propio: " & cita.PACIENTE1.CODIGOPROPIO & ") "
    '                End If

    '                If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
    '                    nota += cita.PACIENTE1.NombreCompletoA1A2Nombre()
    '                Else
    '                    nota += cita.PACIENTE1.NombreCompleto()
    '                End If

    '                nota += vbCrLf
    '            End If

    '            If Globales.Configuracion.citamed = True Then
    '                nota += " Médico: " & cita.MEDICO.NOMBRE + " " + cita.MEDICO.APELLIDO1 + " " + cita.MEDICO.APELLIDO2
    '            End If

    '            If Globales.Configuracion.citaesp = True And Not cita.MEDICO.ESPECIALIDAD Is Nothing Then
    '                If cita.MEDICO.ESPECIALIDAD.Trim() <> "" Then
    '                    nota += " Especialidad: " & cita.MEDICO.ESPECIALIDAD
    '                End If
    '            End If

    '            nota += vbCrLf

    '            If Globales.Configuracion.citanote = True Then
    '                nota = nota & "==========================================="
    '                For Each linea As LineasCita In cita.LineasCitas
    '                    e.Appointment.Description += ("  - " & linea.DESCRIPCION & vbCrLf)
    '                Next
    '            End If

    '            If Not cita.ID_SALA Is Nothing Then
    '                nota = nota & vbCrLf & "SALA: " & cita.SALA.Nombre
    '            End If

    '            e.Appointment.Text = nota

    '            'Globals.ColoreaCitas(cita.CONFIRMADA, cita.ATENDIDO, cita.FALTA, cita.PAGADA, e.Appointment.FormatStyle.BackColor, e.Appointment.FormatStyle.ForeColor)
    '            'e.Handled = False
    '        Catch ex As Exception
    '        End Try
    '    End Sub
    '#End Region


    '    Private Sub btnSugerir_Click(sender As System.Object, e As System.EventArgs)
    '        SugerirCita()
    '    End Sub


    '    Private Function DameFechaInicial() As Date
    '        Dim fecha As Date = FechaSugerida


    '        Return fecha
    '    End Function

    'Public Sub SugerirCita()
    '    Dim startDate As Date = DameFechaInicial() ' ScheduleSalas.SelectedDays.Start


    '    If CITABindingSource.Contains(Cita) Then
    '        startDate = Cita.HORAFIN
    '        CITABindingSource.Remove(Cita)
    '    Else
    '    End If

    '    Cita = New CITA()
    '    Dim paciente As New PACIENTE
    '    paciente.NOMBRE = "RESERVADA"
    '    Cita.PACIENTE1 = paciente
    '    Cita.FECHA = ScheduleSalas.FindFreeTimeSlot(startDate, dt_Duracion.Value.TimeOfDay, True, New ScheduleAppointmentOwner(ID_SALA, "SUGERIR"))
    '    Cita.HORA = Cita.FECHA
    '    Cita.HORAFIN = Cita.FECHA.Value.Add(dt_Duracion.Value.TimeOfDay)

    '    If Not cb_Salas.SelectedItem Is Nothing Then
    '        Dim sala As SALA = cb_Salas.SelectedItem
    '        Cita.ID_SALA = sala.ID_SALA
    '    End If


    '    CITABindingSource.Add(Cita)

    '    btnAceptoSugerencia.Visible = True
    '    ScheduleSalas.Update()

    '    RaiseEvent HoraSugerida(Cita.FECHA)
    '    'Context.SubmitChanges()

    'End Sub

    'Private Sub ScheduleSalas_AppointmentAdded(sender As System.Object, e As Janus.Windows.Schedule.AppointmentEventArgs)
    '    e.Appointment.FormatStyle.BackColor = Color.Orange
    '    e.Appointment.Text = e.Appointment.StartTime.ToString("(HH:mm)") & " - " & e.Appointment.EndTime.ToString("(HH:mm)") & "  SUGERENCIA"
    '    e.Appointment.Description = ""
    '    e.Appointment.Selected = True
    '    ScheduleSalas.EnsureVisible(e.Appointment)
    '    ScheduleSalas.Update()
    'End Sub

    'Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs)
    '    If CITABindingSource.Contains(Cita) Then
    '        CITABindingSource.Remove(Cita)
    '        ScheduleSalas.Date = FechaSugerida
    '    End If
    '    btnAceptoSugerencia.Visible = False
    'End Sub

    'Private Sub btnAceptoSugerencia_Click(sender As System.Object, e As System.EventArgs)
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub

    'Private Sub Calendar2_SelectionChanged(sender As System.Object, e As System.EventArgs)

    'End Sub


    'Private Sub frmSalas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
    '    If AutoSugerir Then
    '        CargaSalas()
    '        SugerirCita()
    '    End If

    'End Sub
End Class