Public Class form_citas_duplicar
    Dim fIdCita As Integer

    Public Min As Date = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0)
    Public Max As Date = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 23, 59, 59)

    Public OriginalCita As CMDataSet.CITASRow
    Private duracion As Integer = 0
    Public IdNuevaCita As Integer

#Region "Sub New(ByVal aId As Integer)"
    Sub New(ByVal aId As Integer)

        InitializeComponent()
        fIdCita = aId
        OriginalCita = Me.CITASTableAdapter.GetCitaById(aId)(0)
        CtrlMedico1.ID_Medico = OriginalCita.REFMEDICO
    End Sub
#End Region

    Private Sub from_citas_duplicar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        

        If CtrlMedico1.ID_Medico.HasValue Then
             Dim _row As CMDataSet.CITASRow = CMDataSet.CITAS.NewCITASRow()
            _row = CITASTableAdapter.GetCitaById(fIdCita)(0)
            tb_horainicio.Text = _row.HORA.ToString
            tb_horafin.Text = _row.HORAFIN.ToString
            duracion = DateDiff(DateInterval.Minute, _row.HORA, _row.HORAFIN)

            dtp_fecha.Text = _row.FECHA.ToString

            CargaCitas(_row.FECHA)
        End If
    End Sub

    Private Function GetLineasCita(ByVal cita As CMDataSet.CITASRow) As String
        Dim lineasTable As New CMDataSet.LineasCitasDataTable()
        LineasCitasTableAdapter.FillByIdCita(lineasTable, cita.IDCITA)

        Dim str As String = "==========================================" & vbCrLf
        For Each linea As CMDataSet.LineasCitasRow In lineasTable
            str = str & " - " & linea.DESCRIPCION & vbCrLf
        Next
        Return str
    End Function

    Private Sub CargaCitas(ByVal fecha As Date)

        Min = New Date(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0)
        Max = New Date(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59)

        Schedule1.Date = Min
        Me.Schedule1.WorkStartTime = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(fecha)
        Me.Schedule1.DayStartHour = centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(fecha).Hours
        Me.Schedule1.WorkEndTime = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(fecha)
        Me.Schedule1.DayEndHour = centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(fecha).Hours + 1

        'Patch: Si la diferencia entre hora de inicio y hora de fin es menor que el intervalo entre citas el programa se cuelga.
        'En caso que eso pueda ocurrir avisamos al usuario y salimos del procedimiento.
        Dim timediff As TimeSpan = Me.Schedule1.WorkEndTime - Me.Schedule1.WorkStartTime
        Dim intervalo As Integer = Globales.Configuracion.dateinterval

        If timediff.TotalMinutes < intervalo Then
            MsgBox("No se puede buscar horas libres en el día seleccionado porque el horario de la clínica es inferior al intervalo definido para las citas", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Select Case intervalo
            Case 1 : Schedule1.Interval = Janus.Windows.Schedule.Interval.OneMinute
            Case 2 : Schedule1.Interval = Janus.Windows.Schedule.Interval.TwoMinutes
            Case 3 : Schedule1.Interval = Janus.Windows.Schedule.Interval.ThreeMinutes
            Case 4 : Schedule1.Interval = Janus.Windows.Schedule.Interval.FourMinutes
            Case 5 : Schedule1.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
            Case 6 : Schedule1.Interval = Janus.Windows.Schedule.Interval.SixMinutes
            Case 7, 8, 9, 10, 11 : Schedule1.Interval = Janus.Windows.Schedule.Interval.TenMinutes
            Case 12, 13, 14 : Schedule1.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
            Case 15, 16, 17, 18 : Schedule1.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
            Case 30 : Schedule1.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
            Case 60 : Schedule1.Interval = Janus.Windows.Schedule.Interval.SixtyMinutes

            Case Else
                If intervalo > 19 And intervalo <= 58 Then Schedule1.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
                If intervalo > 60 Then Schedule1.Interval = Janus.Windows.Schedule.Interval.TwentyMinutes
        End Select


        Me.CITASTableAdapter.FillByIntervaloPorMedico(Me.CMDataSet.CITAS, CtrlMedico1.ID_Medico, Min, Max)
        Dim pacienteTable As New CMDataSet.PACIENTESDataTable()
        Dim pacienteTableAdapter As New CMDataSetTableAdapters.PACIENTESTableAdapter()


        For Each app As Janus.Windows.Schedule.ScheduleAppointment In Schedule1.Appointments

            Dim cita As CMDataSet.CITASRow = app.DataRow.Row

            app.Text = "(" & cita.REFPACIENTE & ") "

            pacienteTableAdapter.FillPacienteById(pacienteTable, cita.REFPACIENTE)
            If pacienteTable.Count > 0 Then
                If Not pacienteTable(0).CODIGOPROPIO Is Nothing Then
                    app.Text = app.Text & "(" & pacienteTable(0).CODIGOPROPIO & ") "
                End If
            End If

            app.Text = app.Text & cita.PACIENTE

            app.Description = GetLineasCita(cita)
        Next

        'Mostrar sugerencias

        Try
            ListBox1.Items.Clear()
            'Dim intervaloCita As TimeSpan = OriginalCita.HORAFIN - OriginalCita.HORA
            Dim intervaloCita As New TimeSpan(0, Globales.Configuracion.citainterval, 0)
            Dim s1 As Date = Schedule1.FindFreeTimeSlot(Schedule1.Date, intervaloCita, True)
            Dim s2 As Date = Schedule1.FindFreeTimeSlot(s1.Add(intervaloCita), intervaloCita, True)

            ListBox1.Items.Add(s1.ToShortTimeString())
            ListBox1.Items.Add(s2.ToShortTimeString())

            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try


    End Sub



    Private Sub Duplicar()
        Try



            Dim _fecha As Date = dtp_fecha.Value.Date
            Dim _row As CMDataSet.CITASRow = CMDataSet.CITAS.NewCITASRow()

            Dim table As CMDataSet.CITASDataTable = CITASTableAdapter.GetCitaById(fIdCita)
            If table.Count = 0 Then
                MessageBox.Show("Cita a duplicar " & fIdCita & " no encontrada")
                Me.Close()
            End If

            Dim _original As CMDataSet.CITASRow = table(0)

            Dim _horainicios As String = tb_horainicio.Text.Trim()
            Dim _horafins As String = tb_horafin.Text.Trim()
            Dim _inicio As Date
            Dim _fin As Date
            Dim _horainicio As Date

            _horainicio = DateAndTime.TimeValue(_horainicios)

            Dim _horafin As Date

            _horafin = DateAndTime.TimeValue(_horafins)
            _fin = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horafin.Hour, _horafin.Minute, 0)
            _inicio = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horainicio.Hour, _horainicio.Minute, 0)


            'Duplicamos la cita
            If Not _original.IsREFPACIENTENull Then
                _row.REFPACIENTE = _original.REFPACIENTE
            End If

            _row.FECHA = _fecha
            _row.FECHACOBRO = _fecha
            _row.HORA = _inicio
            _row.HORAFIN = _fin
            _row.CONFIRMADA = "N"
            If Not _original.IsTOTALNull Then
                _row.TOTAL = _original.TOTAL
            Else
                _row.TOTAL = 0
            End If


            If Not _original.IsNOTASNull Then
                _row.NOTAS = _original.NOTAS
            End If

            If Not _original.IsREFMEDICONull Then
                _row.REFMEDICO = _original.REFMEDICO
            End If

            If Not _original.IsPACIENTENull Then
                _row.PACIENTE = _original.PACIENTE
            End If

            If Not _original.IsIMPORTEDRNull Then
                _row.IMPORTEDR = _original.IMPORTEDR
            Else
                _row.IMPORTEDR = 0
            End If

            If Not _original.IsIMPORTECLNull Then
                _row.IMPORTECL = _original.IMPORTECL
            Else
                _row.IMPORTECL = 0
            End If

            _row.CONTINUA = "N"
            _row.FALTA = "N"

            If Not _row.IsBANCONull Then
                _row.BANCO = _original.BANCO
            End If

            'Pagada no se copia, se pone null
            _row.PAGADA = "N"

            'If Not _original.IsPAGADANull Then
            '    _row.PAGADA = _original.PAGADA
            'Else
            '    _row.PAGADA = "N"
            'End If

            'El recibo no debe duplicarse
            'If Not _original.IsREFRECIBONull Then
            '    _row.REFRECIBO = _original.REFRECIBO
            'End If
            _row.ATENDIDO = "N"


            'La Fra no debe duplicarse tampoco

            If Not _original.IsREFFORMAPAGONull Then
                _row.REFFORMAPAGO = _original.REFFORMAPAGO
            End If

            'La fecha cobro tampoco

            'LA ref procedencia si

            If Not _original.IsREFPROCEDENCIANull Then
                _row.REFPROCEDENCIA = _original.REFPROCEDENCIA
            End If

            If _row.RowState = DataRowState.Detached Then
                CMDataSet.CITAS.AddCITASRow(_row)
            End If

            'If _original.

            _row.Eliminado = False
            Dim n As Integer = Me.CITASTableAdapter.Update(_row)


            'ahora vemos las lineas para copiarlas

            Dim lineasTable As CMDataSet.LineasCitasDataTable = LineasCitasTableAdapter.GetDataByIdCita(_original.IDCITA)

            For Each lineaOriginal As CMDataSet.LineasCitasRow In lineasTable
                Dim lineaNueva As CMDataSet.LineasCitasRow = CMDataSet.LineasCitas.NewLineasCitasRow()
                lineaNueva.Cantidad = lineaOriginal.Cantidad
                lineaNueva.DESCRIPCION = lineaOriginal.DESCRIPCION
                lineaNueva.IdCita = _row.IDCITA
                lineaNueva.ImporteClinica = lineaOriginal.ImporteClinica
                lineaNueva.ImporteDr = lineaOriginal.ImporteDr
                If Not lineaOriginal.IsRefConceptoNull Then
                    lineaNueva.RefConcepto = lineaOriginal.RefConcepto
                End If

                If Not lineaOriginal.IsDuracionNull Then
                    lineaNueva.Duracion = lineaOriginal.Duracion
                End If
                CMDataSet.LineasCitas.AddLineasCitasRow(lineaNueva)
            Next
            LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Citas, "Duplicar Citas", Me.fIdCita.ToString(), _original.PACIENTE)
            IdNuevaCita = _row.IDCITA
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al duplicar cita")
        End Try
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        'comprobamos si son validos los datos
        Dim horaini_jornada As TimeSpan = Globales.Configuracion.DameJornadaLaboralInicio(Me.dtp_fecha.Value)
        Dim horafin_jornada As TimeSpan = Globales.Configuracion.DameJornadaLaboralFinal(Me.dtp_fecha.Value)

        Dim horaini_sele As TimeSpan = New TimeSpan(tb_horainicio.Value.Hour, tb_horainicio.Value.Minute, 0)
        Dim horafin_sele As TimeSpan = New TimeSpan(tb_horafin.Value.Hour, tb_horafin.Value.Minute, 0)
        If Not (horaini_sele >= horaini_jornada And horafin_sele <= horafin_jornada) Then
            MsgBox("La hora de inicio o fin está fuera del horario de la clínica", MsgBoxStyle.Exclamation)
            Return
        End If

        If tb_horafin.Value <= tb_horainicio.Value Then
            MessageBox.Show("Hora final no valida")
            tb_horafin.Focus()
            Return
        End If
        'fin comprobaciones

        Duplicar()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub



    Private Sub tb_horainicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_horainicio.Leave, tb_horainicio.Enter
        'Dim hora As String
        'Dim minutos As String
        'Dim res As Integer
        Dim intervalo As TimeSpan
        Try

            'se comenta la linea siguiente para que la duplicidad de cita también contemple la duración de la cita original.
            'Funciona de la siguiente forma:
            '- una cita que dura 30 min la duplico.
            '- en el form de duplicar poner la hora de inicio y la hora de fin es (horainicio + 30). 
            '- Si modifico la hora de inicio la hora de fin seguirasiendo (horainicio +30).
            '- Si modifico la hora de fin entonces no hacemos nada.
            '- Si vuelvo a modificar la hora de inicio entonces de nuevo (horainicio + 30). 
            ' intervalo = New TimeSpan(0, Globales.Configuracion.citainterval, 0)

            intervalo = New TimeSpan(0, duracion, 0)

            tb_horafin.Text = tb_horainicio.Value.Add(intervalo)

        Catch ex As IndexOutOfRangeException
            MsgBox("Hay algún problema en el formato de la hora de inicio de la cita, reviselo por favor", MsgBoxStyle.Exclamation)
        Catch indexEx As ArgumentOutOfRangeException
            'MsgBox("Ha definido una hora que está fuera de los horarios definidos por la clínica")
        End Try

    End Sub
    Private Sub tb_horainicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horainicio.ValueChanged
        Me.tb_horainicio_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub dtp_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha.ValueChanged
        If Me.IsHandleCreated Then
            CargaCitas(dtp_fecha.Value)
           
        End If
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        tb_horainicio.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub Schedule1_SelectedDaysChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Schedule1.SelectedDaysChanged
        Try
            dtp_fecha.Text = Schedule1.SelectedDays.Start.ToShortDateString
            tb_horainicio.Text = Schedule1.SelectedDays.Start.ToShortTimeString()
        Catch indexEx As ArgumentOutOfRangeException
        End Try
    End Sub

    Private Sub HORALabel_Click(sender As Object, e As EventArgs)

    End Sub

    
End Class