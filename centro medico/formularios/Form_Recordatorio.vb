Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports JCS

Public Class Form_Recordatorio
    Public context As New CMLinqDataContext
    Public IdUser As Integer
    Dim IdRecordSelected As Integer
    Dim Accion As String = "Insertar"
    Dim HoraIni As DateTime
    Dim HoraFin As DateTime
    Dim DTReadOnly As DateTime
    Dim DTROnly As Boolean

    'Al cargar la Pagina
    Private Sub Form_Recordatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaHorarioLabXdia(Date.Now)
        ScheduleRecordatorio.Date = FiltroGenericoDocumentos.FirstDate(Date.Now)
        ScheduleRecordatorio.ShowTimeAsClocks = False
        ScheduleRecordatorio.DayStartHour = HoraIni.Hour
        ScheduleRecordatorio.DayEndHour = HoraFin.Hour + 1
        Carga_Recordatorios()
        CargaHoraValida()
    End Sub

    'Al cambiar la fecha del calendario
    Private Sub Calendar2_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar2.SelectionChanged

        Carga_Recordatorios()
        dtp_fecha.Value = ScheduleRecordatorio.Date
        CargaHorarioLabXdia(Calendar2.CurrentDate)
        ScheduleRecordatorio.DayStartHour = HoraIni.Hour
        ScheduleRecordatorio.DayEndHour = HoraFin.Hour + 1
    End Sub

    'Funcion para cargar los datos
    Private Sub Carga_Recordatorios()
        Dim listRecordatorio As List(Of Recordatorio) = (From p In context.Recordatorios.ToList _
                                                        Where p.Fecha = Calendar2.CurrentDate And p.IdUsuario = IdUser _
                                                        Select p Order By p.Hora Descending).ToList()
        BsRecordatorio.DataSource = listRecordatorio
    End Sub

    'Estructura de la informacion a mostrar
    Private Sub ScheduleRecordatorio_AppointmentRead(sender As Object, e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleRecordatorio.AppointmentRead
        Dim Record As Recordatorio = e.Appointment.DataRow
        Dim lista As New List(Of String)

        lista.Add(Record.Hora.ToString("HH:mm") & " - " & Record.Asunto)
        If Record.Anotación.Trim <> "" Then lista.Add("Anotación: " & Record.Anotación)

        e.Appointment.Text = String.Join(vbCrLf, lista.ToArray())
    End Sub

    'Al dar click en un recordatorio o en una fila en blanco
    Private Sub ScheduleRecordatorio_SelectedAppointmentsChanged(sender As Object, e As EventArgs) Handles ScheduleRecordatorio.SelectedAppointmentsChanged, ScheduleRecordatorio.Click
        Dim Record As Recordatorio = Nothing
        If ScheduleRecordatorio.SelectedAppointments.Count > 0 Then
            Record = ScheduleRecordatorio.SelectedAppointments(0).DataRow
        End If
        If Not Record Is Nothing Then
            Accion = "Ver"
            GroupBox1.Text = "Recordatorio [" & Record.IdRecordatorio & "]"
            DTReadOnly = New DateTime(Record.Hora.Year, Record.Hora.Month, Record.Hora.Day, Record.Hora.Hour, Record.Hora.Minute, Record.Hora.Second)
            tsbEliminar.Enabled = True
            tsbModificar.Enabled = True
            dtp_fecha.Value = Record.Fecha
            tb_hora.Value = Record.Hora
            ToggleSwitch1.Checked = Record.Activo
            TbAsunto.Text = Record.Asunto
            TbAnotacion.Text = Record.Anotación
            SetReadOnly(True)
        Else
            ModoInsertar()
            tsbEliminar.Enabled = False
            tsbModificar.Enabled = False
            dtp_fecha.Value = ScheduleRecordatorio.Date
            tb_hora.Value = ScheduleRecordatorio.GetDateTimeAt

        End If
    End Sub

    'Al darle click a Añadir
    Private Sub tsbAñadir_Click(sender As Object, e As EventArgs) Handles tsbAñadir.Click
        ModoInsertar()
        SetEnabled(False)
        GroupBox1.Enabled = True
    End Sub

    'Al darle doble click a un recordatorio
    Private Sub ScheduleRecordatorio_AppointmentDoubleClick(sender As Object, e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleRecordatorio.AppointmentDoubleClick
        tstModificar_Click(Nothing, Nothing)
    End Sub

    'Al darle click a Modificar
    Private Sub tstModificar_Click(sender As Object, e As EventArgs) Handles tsbModificar.Click
        Dim Record As Recordatorio = Nothing
        If ScheduleRecordatorio.SelectedAppointments.Count > 0 Then
            Record = ScheduleRecordatorio.SelectedAppointments(0).DataRow
        End If
        If Not Record Is Nothing Then
            Accion = "Modificar"
            SetEnabled(False)
            GroupBox1.Enabled = True
            GroupBox1.Text = "Editar Recordatorio [" & Record.IdRecordatorio & "]"

            IdRecordSelected = Record.IdRecordatorio
            dtp_fecha.Value = Record.Fecha
            tb_hora.Value = Record.Hora
            ToggleSwitch1.Checked = Record.Activo
            TbAsunto.Text = Record.Asunto
            TbAnotacion.Text = Record.Anotación
            SetReadOnly(False)
        End If
    End Sub

    'Al darle click a Aceptar
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim hora As DateTime = New DateTime(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, tb_hora.Value.Hour, tb_hora.Value.Minute, 0)

        If Not ValidaDatos(hora) Then
            Exit Sub
        End If

        If Accion = "Insertar" Then
            Try
                Dim NewRecord As New Recordatorio With {
                       .IdUsuario = IdUser,
                       .Fecha = dtp_fecha.Value.Date,
                       .Hora = hora,
                       .Activo = ToggleSwitch1.Checked,
                       .Asunto = TbAsunto.Text.Trim,
                       .Anotación = TbAnotacion.Text.Trim
                       }
                context.Recordatorios.InsertOnSubmit(NewRecord)
                context.SubmitChanges()
                RestablecerEstado()
                MessageBox.Show("El recordatorio fue insertado satisfactoriamente.")
            Catch ex As Exception
                MessageBox.Show("No se pudo insertar el recordatorio.")
            End Try
        ElseIf Accion = "Modificar" Then
            Try
                Dim EditRecord As Recordatorio = (From r In context.Recordatorios _
                                                   Where r.IdRecordatorio = IdRecordSelected _
                                                   Select r).SingleOrDefault()
                EditRecord.IdUsuario = IdUser
                EditRecord.Fecha = dtp_fecha.Value.Date
                EditRecord.Hora = hora
                EditRecord.Activo = ToggleSwitch1.Checked
                EditRecord.Asunto = TbAsunto.Text.Trim
                EditRecord.Anotación = TbAnotacion.Text.Trim

                context.SubmitChanges()
                RestablecerEstado()
                MessageBox.Show("El recordatorio fue modificado satisfactoriamente.")
            Catch ex As Exception
                MessageBox.Show("No se pudo modificar el recordatorio.")
            End Try
        End If

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If MessageBox.Show("Esta seguro que desea eliminar este recordatorio?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim Record As Recordatorio = Nothing
                If ScheduleRecordatorio.SelectedAppointments.Count > 0 Then
                    Record = ScheduleRecordatorio.SelectedAppointments(0).DataRow
                    context.Recordatorios.DeleteOnSubmit(Record)
                    context.SubmitChanges()
                    RestablecerEstado()
                    MessageBox.Show("El recordatorio fue eliminado satisfactoriamente.")
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo eliminar el recordatorio.")
            End Try
        End If
    End Sub

    Private Sub RestablecerEstado()
        Accion = "Insertar"
        GroupBox1.Text = "Nuevo Recordatorio"
        ScheduleRecordatorio.Date = dtp_fecha.Value.Date
        Carga_Recordatorios()
        SetEnabled(True)
        tsbEliminar.Enabled = False
        tsbModificar.Enabled = False
        ToggleSwitch1.Checked = True
        TbAsunto.Text = ""
        TbAnotacion.Text = ""
    End Sub

    Private Function ValidaDatos(hora As DateTime) As Boolean
        If TbAnotacion.Text.Trim = "" Then TbAnotacion.Text = ""
        If hora < DateTime.Now Then
            MessageBox.Show("La fecha y hora establecida debe ser mayor a la actual dentro del horario labolar.")
            dtp_fecha.Value = Date.Now
            CargaHoraValida()
            Return False
        End If
        If TbAsunto.Text.Trim = "" Then
            MessageBox.Show("El asunto del recordatorio no puede ser vacio.")
            TbAsunto.Text = ""
            Return False
        End If
        Return True
    End Function

    Private Sub CargaHoraValida()
        If (DateTime.Now >= HoraIni And DateTime.Now < HoraFin) Then
            tb_hora.Value = DateTime.Now.AddMinutes(1)
        ElseIf DateTime.Now < HoraIni Then
            tb_hora.Value = HoraIni
        ElseIf DateTime.Now > HoraFin Then
            tb_hora.Value = HoraIni
            dtp_fecha.Value = Date.Now.AddDays(1)
        End If
    End Sub

    'Al darle click a Cancelar
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CargaHoraValida()
        RestablecerEstado()
    End Sub

    'abilitar o desabilitar  todo el formulario
    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
    End Sub

    Public Sub ModoInsertar()
        Accion = "Insertar"
        GroupBox1.Text = "Nuevo Recordatorio"

        ToggleSwitch1.Checked = True
        TbAsunto.Text = ""
        TbAnotacion.Text = ""
        SetReadOnly(False)
    End Sub

    Public Sub SetReadOnly(value As Boolean)
        ToggleSwitch1.AllowUserChange = Not value
        TbAsunto.ReadOnly = value
        TbAsunto.BackColor = Color.White
        TbAnotacion.ReadOnly = value
        TbAnotacion.BackColor = Color.White
        BtnAceptar.Enabled = Not value
        BtnCancelar.Enabled = Not value
        DTROnly = value
    End Sub

    Private Sub tb_hora_ValueChanged(sender As Object, e As EventArgs) Handles tb_hora.ValueChanged, dtp_fecha.ValueChanged
        If DTROnly Then
            tb_hora.Value = DTReadOnly
            dtp_fecha.Value = DTReadOnly
            Return
        End If
        CargaHorarioLabXdia(dtp_fecha.Value)
        If tb_hora.Value < HoraIni Then tb_hora.Value = HoraIni
        If tb_hora.Value > HoraFin Then tb_hora.Value = HoraFin
    End Sub

    Private Sub CargaHorarioLabXdia(fecha As DateTime)
        HoraIni = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(Globales.Configuracion.DameJornadaLaboralInicio(fecha))
        HoraFin = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(Globales.Configuracion.DameJornadaLaboralFinal(fecha))

    End Sub

    Private Sub Form_Recordatorio_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Close()
        End If
    End Sub
End Class