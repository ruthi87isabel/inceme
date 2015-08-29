Imports centro_medico
Imports System.Xml.Linq
Imports System.Linq.Expressions
Imports LinqKit.PredicateBuilder
Imports System.Threading
Imports Janus.Windows.UI.Tab

Public Class frmHorarios

    Public Calendarios As New Dictionary(Of Integer, ctrlHorarios)
    Dim CambiosAAuditar As New List(Of RegistroCambiosAuditoria)
    Dim context As CMLinqDataContext
    Dim diasseleccionados As New List(Of Date)
    Dim hiloCalendarios As Thread


    Private Sub frmHorarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F5 Then
            Me.btConsultarHoras_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmHorarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CargaCalendarios()

    End Sub

    Public Sub CargaCalendarios()

        If Not context Is Nothing Then
            'Salvar lo que deba ser salvado
            tstGuardar_Click(Nothing, Nothing)
        End If
        CambiosAAuditar.Clear()

        tabControl.TabPages.Clear()
        Calendarios.Clear()

        context = New CMLinqDataContext()

        'El calendario global

        Dim tabPageGlobal As New Janus.Windows.UI.Tab.UITabPage("Calendario Global")
        tabPageGlobal.Image = My.Resources.Globe
        Dim ctrlHorarioGlobal As New ctrlHorarios()
        ctrlHorarioGlobal.lblTituloCalendario.Text = "Calendario Global basico"
        'AddHandler ctrlHorarioGlobal.SeleccionarRangoEnTodosLosCalendarios, AddressOf SeleccionarRangoTodosLosCalendarios
        AddHandler ctrlHorarioGlobal.PropagarATodosLosCalendarios, AddressOf PropagarATodosCalendarios
        AddHandler ctrlHorarioGlobal.PropagarTipoFechaATodosLosCalendarios, AddressOf PropagarTipoFechaATodosLosCalendarios
        AddHandler ctrlHorarioGlobal.ClearSeleccionEvent, AddressOf ClearSeleccionEvent
        AddHandler ctrlHorarioGlobal.FechaModificada, AddressOf FechaModificada
        AddHandler ctrlHorarioGlobal.AuditarClonacion, AddressOf AuditarClonacion

        ctrlHorarioGlobal.btnPropagar.Visible = True
        tabPageGlobal.Controls.Add(ctrlHorarioGlobal)
        tabControl.TabPages.Add(tabPageGlobal)
        Calendarios(tabPageGlobal.Index) = ctrlHorarioGlobal

        ctrlHorarioGlobal.Anno = dtpYear.Value.Year
        ctrlHorarioGlobal.TipoCalendario = ctrlHorarios.TipoCalendarioEnum.Calendario_Global



        Dim calendarioGlobal As CALENDARIO_GLOBAL = (From c In context.CALENDARIO_GLOBALs _
                                             Where c.Anno = dtpYear.Value.Year _
                                             Select c).SingleOrDefault()

        If calendarioGlobal Is Nothing Then
            'No tiene para este anno, crearlo
            calendarioGlobal = New CALENDARIO_GLOBAL()
            calendarioGlobal.Anno = dtpYear.Value.Year
            calendarioGlobal.Calendario = New XElement("Calendario")
            context.CALENDARIO_GLOBALs.InsertOnSubmit(calendarioGlobal)
            context.SubmitChanges()
        Else
            ctrlHorarioGlobal.CalendarioXML = calendarioGlobal.Calendario.ToString()
        End If

        ctrlHorarioGlobal.Tag = calendarioGlobal
        ctrlHorarioGlobal.Refresh()



        'Medicos
        For Each medico As MEDICO In context.MEDICOs.Where(CType(Function(m) Not m.Eliminado.HasValue Or m.Eliminado = False, Func(Of MEDICO, Boolean)))

            Dim tabPage As New Janus.Windows.UI.Tab.UITabPage(medico.NOMBRECOMPLETO)
            tabPage.Image = My.Resources.doctors
            Dim ctrlHora As New ctrlHorarios()
            ctrlHora.lblTituloCalendario.Text = medico.NOMBRECOMPLETO + ".  " + medico.ESPECIALIDAD
            ctrlHora.medicoid = medico.CMEDICO

            'AddHandler ctrlHora.SeleccionarRangoEnTodosLosCalendarios, AddressOf SeleccionarRangoTodosLosCalendarios
            AddHandler ctrlHora.PropagarATodosLosCalendarios, AddressOf PropagarATodosCalendarios
            AddHandler ctrlHora.PropagarTipoFechaATodosLosCalendarios, AddressOf PropagarTipoFechaATodosLosCalendarios
            AddHandler ctrlHora.ClearSeleccionEvent, AddressOf ClearSeleccionEvent
            AddHandler ctrlHora.FechaModificada, AddressOf FechaModificada


            tabPage.Controls.Add(ctrlHora)
            tabControl.TabPages.Add(tabPage)
            Calendarios(tabPage.Index) = ctrlHora

            ctrlHora.Anno = dtpYear.Value.Year

            ctrlHora.TipoCalendario = ctrlHorarios.TipoCalendarioEnum.Calendario_Medicos


            Dim calendario As CALENDARIO_MEDICO = (From c In context.CALENDARIO_MEDICOs _
                                                  Where c.ID_MEDICO = medico.CMEDICO And c.Anno = dtpYear.Value.Year _
                                                  Select c).SingleOrDefault()




            If calendario Is Nothing Then
                'No tiene para este medico y anno, crearlo
                calendario = New CALENDARIO_MEDICO()
                calendario.ID_MEDICO = medico.CMEDICO
                calendario.Anno = dtpYear.Value.Year
                calendario.Calendario = New XElement("Calendario")
                context.CALENDARIO_MEDICOs.InsertOnSubmit(calendario)
                context.SubmitChanges()
            Else
                ctrlHora.CalendarioXML = calendario.Calendario.ToString()
            End If
            ctrlHora.Tag = calendario
            ctrlHora.Refresh()
        Next


        'Usuarios()
        For Each user As USUARIO In context.USUARIOs
            If Not user.REFMEDICO.HasValue Then

                Dim tabPage As New Janus.Windows.UI.Tab.UITabPage(user.NOMBRECOMPLETO)
                tabPage.Tag = user
                Dim horario As New ctrlHorarios()
                tabPage.Image = My.Resources.Profile
                horario.lblTituloCalendario.Text = user.NOMBRECOMPLETO + ".  " + user.ROLESUSUARIOs(0).ROLE.Nombre
                horario.TipoCalendario = ctrlHorarios.TipoCalendarioEnum.Calendario_Usuarios

                'AddHandler horario.SeleccionarRangoEnTodosLosCalendarios, AddressOf SeleccionarRangoTodosLosCalendarios
                AddHandler horario.PropagarATodosLosCalendarios, AddressOf PropagarATodosCalendarios

                AddHandler horario.PropagarTipoFechaATodosLosCalendarios, AddressOf PropagarTipoFechaATodosLosCalendarios
                AddHandler horario.ClearSeleccionEvent, AddressOf ClearSeleccionEvent
                AddHandler horario.FechaModificada, AddressOf FechaModificada

                tabPage.Controls.Add(horario)
                tabControl.TabPages.Add(tabPage)
                Calendarios(tabPage.Index) = horario


                horario.Anno = dtpYear.Value.Year


                Dim calendario As CALENDARIO_USUARIO = (From c In context.CALENDARIO_USUARIOs _
                                              Where c.ID_Usuario = user.CODIGO And c.Anno = dtpYear.Value.Year _
                                              Select c).SingleOrDefault()

                If calendario Is Nothing Then
                    'No tiene para este medico y anno, crearlo
                    calendario = New CALENDARIO_USUARIO()
                    calendario.ID_Usuario = user.CODIGO
                    calendario.Anno = dtpYear.Value.Year
                    calendario.Calendario = New XElement("Calendario")
                    context.CALENDARIO_USUARIOs.InsertOnSubmit(calendario)
                    context.SubmitChanges()
                Else
                    horario.CalendarioXML = calendario.Calendario.ToString()
                End If
                horario.Tag = calendario
                horario.Refresh()
            End If
        Next
    End Sub

    Public Sub SeleccionarRangoTodosLosCalendarios(ByVal starDate As Date, ByVal endDate As Date)
        'CtrlHorarios1.SeleccionaRango(starDate, endDate)
        For Each ctrlHora As ctrlHorarios In Calendarios.Values
            ctrlHora.SeleccionaRango(starDate, endDate)
        Next
    End Sub

    Public Sub PropagarATodosCalendarios(ByVal infos() As Pabo.Calendar.DateItem, ByVal index As Integer)
        For Each ctrlHora As ctrlHorarios In Calendarios.Values
            ctrlHora.VaciaCalendario(index)
            ctrlHora.MarcaFechas(infos, index)
        Next
    End Sub

    Public Sub PropagarTipoFechaATodosLosCalendarios(ByVal dates As Pabo.Calendar.SelectedDatesCollection, ByVal tipoFecha As ctrlHorarios.TipoFecha, ByVal index As Integer, ByVal just As String)
        If dates.Count = 0 Then Return

        For Each ctrlHora As ctrlHorarios In Calendarios.Values
            For Each fecha As Date In dates
                ctrlHora.MarcaFecha(fecha, index)
            Next
            ctrlHora.AplicaFormatoSeleccionadas(tipoFecha, just, True)
            'ctrlHora.ClearSelection()
        Next

    End Sub

    Public Sub ClearSeleccionEvent()
        For Each ctrlHora As ctrlHorarios In Calendarios.Values
            ctrlHora.ClearSelection()
        Next

    End Sub

    Private Sub dtpYear_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpYear.ValueChanged

        CargaCalendarios()

    End Sub

    Private Sub tstGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tstGuardar.Click

        'Dim a As ctrlHorarios = tabControl.TabPages(2).Controls(0)
        ' Thread.Sleep(10000)
        'Exit Sub
        'Dim calendarioGlobal As CALENDARIO_GLOBAL = CtrlHorarios1.Tag
        'calendarioGlobal.Calendario = XElement.Parse(CtrlHorarios1.SalvaToXml())

        For Each ctrlHora As ctrlHorarios In Calendarios.Values

            If ctrlHora.Tag.GetType().Equals(GetType(CALENDARIO_GLOBAL)) Then
                Dim calendario As CALENDARIO_GLOBAL = ctrlHora.Tag
                calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
            End If

            If ctrlHora.Tag.GetType().Equals(GetType(CALENDARIO_MEDICO)) Then
                Dim calendario As CALENDARIO_MEDICO = ctrlHora.Tag
                calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
            End If

            If ctrlHora.Tag.GetType().Equals(GetType(CALENDARIO_USUARIO)) Then
                Dim calendario As CALENDARIO_USUARIO = ctrlHora.Tag
                calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
            End If
        Next

        BindingSource1.EndEdit()
        context.SubmitChanges()

        'Auditorias
        For Each item As RegistroCambiosAuditoria In CambiosAAuditar
            Globales.AuditoriaInfo.Registra(item.Accion, item.eLocacion, item.TipoDocumento, item.codigoDocumento, item.DetallesDocumento)
        Next
        CambiosAAuditar.Clear()
    End Sub

    Private Sub VaciarTODOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VaciarTODOToolStripMenuItem.Click
        Dim globalesw As List(Of CALENDARIO_GLOBAL) = (From g In context.CALENDARIO_GLOBALs Select g).ToList()
        Dim medicos As List(Of CALENDARIO_MEDICO) = (From g In context.CALENDARIO_MEDICOs Select g).ToList()
        Dim usuarios As List(Of CALENDARIO_USUARIO) = (From g In context.CALENDARIO_USUARIOs Select g).ToList()

        context.CALENDARIO_GLOBALs.DeleteAllOnSubmit(globalesw)
        context.CALENDARIO_MEDICOs.DeleteAllOnSubmit(medicos)
        context.CALENDARIO_USUARIOs.DeleteAllOnSubmit(usuarios)
        context.SubmitChanges()

        'For Each page As Janus.Windows.UI.Tab.UITabPage In tabControl.TabPages
        '    If page.Index <> 0 Then
        '        tabControl.TabPages.Remove(page)
        '    End If
        'Next
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Horarios, "CALENDARIOS", "TODOS", "VACIAR TODOS LOS CALENDARIOS")
        CargaCalendarios()
    End Sub

    Private Sub DisponibilidadPorFechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisponibilidadPorFechaToolStripMenuItem.Click
        Dim frm As New frmHorario_Disponibilidad
        frm.ShowDialog()

    End Sub

    Public Sub FechaModificada(ByVal fecha As DateTime, ByVal idCalendario As String, ByVal tipoCalendario As ctrlHorarios.TipoCalendarioEnum, ByVal tipoFecha As ctrlHorarios.TipoFecha, ByVal just As String)
        Dim reg As New RegistroCambiosAuditoria
        reg.idDocumento = idCalendario
        reg.Accion = Globales.AuditoriaInfo.Accion.Modificar
        reg.codigoDocumento = idCalendario
        reg.DetallesDocumento = String.Format("Fecha={0} TipoDia={1} Justificacion={2}", fecha.ToString("dd/MM/yyyy"), [Enum].GetName(GetType(ctrlHorarios.TipoFecha), tipoFecha), just)
        'reg.eLocacion = 
        reg.TipoDocumento = [Enum].GetName(GetType(ctrlHorarios.TipoCalendarioEnum), tipoCalendario)
        If Not CambiosAAuditar.Contains(reg) Then
            CambiosAAuditar.Add(reg)
        End If

    End Sub

    Public Sub AuditarClonacion(ByVal msg As String)
        Dim reg As New RegistroCambiosAuditoria
        reg.idDocumento = "A Todos"
        reg.Accion = Globales.AuditoriaInfo.Accion.Modificar
        reg.codigoDocumento = ""
        reg.DetallesDocumento = msg
        reg.eLocacion = RoleManager.Items.Horarios
        reg.TipoDocumento = "CALENDARIO_Global"
        If Not CambiosAAuditar.Contains(reg) Then
            CambiosAAuditar.Add(reg)
        End If

    End Sub

    Private Sub DiasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DiasToolStripMenuItem.Click
        'Reporte Dias Laborables por medico
        Dim frm As New frmHorario_Resumen
        frm.ShowDialog()
    End Sub

    Private Sub horaOcupadas()
        Dim medicoid As Integer = CargaDiasSeleccionados()
        If medicoid > 0 Then
            Dim medico As MEDICO = (From o In context.MEDICOs Where o.CMEDICO = medicoid Select o).SingleOrDefault
            Dim query As IQueryable(Of HORARIOS_MEDICOS) = medico.horasOcupadas(diasseleccionados, context)

            BindingSource1.DataSource = query
            diasseleccionados.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Carga los dias seleccionados en la lista diasseleccionados 
    ''' </summary>
    ''' <returns>medicoid corresponde al id del doctor para el que se han obtenido los días.</returns>
    ''' <remarks>Si medicoid devuelve 0 es porque no hay dias seleccionados.</remarks>
    Private Function CargaDiasSeleccionados() As Integer
        Dim ctrl As ctrlHorarios = Me.tabControl.SelectedTab.Controls(0)
        Dim i As Integer = 0
        For i = 0 To ctrl.Controls.Count - 1
            If TypeOf ctrl.Controls(i) Is Pabo.Calendar.MonthCalendar Then

                Dim cal As Pabo.Calendar.MonthCalendar = ctrl.Controls(i)
                For Each dia As Date In cal.SelectedDates
                    diasseleccionados.Add(dia)
                Next
                Console.WriteLine("calendario")
            End If
        Next

        Return ctrl.medicoid
    End Function

    Private Sub AddHorarios()
        Dim horainitxt As Date
        Dim horafintxt As Date
        Dim msgError As String = ""
        'cargo los días seleccionados en los calendario
        Dim medicoid As Integer = Me.CargaDiasSeleccionados()
        Dim listaConflictos As List(Of HORARIOS_MEDICOS)


        If medicoid > 0 Then
            Dim medico As MEDICO = (From o In context.MEDICOs Where o.CMEDICO = medicoid Select o).SingleOrDefault
            Dim frmIntervalo As New frmIntervaloHoras
            If frmIntervalo.ShowDialog = Windows.Forms.DialogResult.OK Then
                horainitxt = frmIntervalo.horaini
                horafintxt = frmIntervalo.horafin

                For Each d As Date In diasseleccionados
                    Dim hora As New HORARIOS_MEDICOS
                    hora.fecha = d
                    hora.hora_ini = horainitxt
                    hora.hora_fin = horafintxt
                    hora.medico_id = medicoid
                    listaConflictos = medico.CheckConflictosHoras(horainitxt, horafintxt, d, context)

                    If listaConflictos.Count = 0 Then
                        'context.HORARIOS_MEDICOS.InsertOnSubmit(hora)
                        BindingSource1.Add(hora)
                    Else
                        For Each e As HORARIOS_MEDICOS In listaConflictos
                            msgError = msgError & vbCrLf & "Conflicto con el día " & e.fecha.ToShortDateString & " con el intervalo de " & e.hora_ini.ToShortTimeString & " a " & e.hora_fin.ToShortTimeString
                        Next
                        listaConflictos.Clear()
                    End If

                Next
                If msgError.Trim.Length > 0 Then
                    MsgBox("Algunos intervalos no se guardaron porque entran en conflicto con otros ya almacenados: " & msgError, MsgBoxStyle.Exclamation)
                    msgError = ""
                End If

                'disparo el guardar del form
                Me.tstGuardar_Click(Nothing, Nothing)
            End If
            diasseleccionados.Clear()
        End If
    End Sub

    Private Sub bt_addHorario_Click(sender As Object, e As EventArgs) Handles bt_addHorario.Click
        Me.AddHorarios()
    End Sub

    Private Sub btConsultarHoras_Click(sender As Object, e As EventArgs) Handles btConsultarHoras.Click
        Me.horaOcupadas()
    End Sub

    Private Sub GridEX1_ColumnButtonClick(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Dim hora As HORARIOS_MEDICOS = GridEX1.CurrentRow.DataRow
        Dim ob As HORARIOS_MEDICOS = (From a In context.HORARIOS_MEDICOS Where a.id = hora.id Select a).SingleOrDefault
        Dim res As MsgBoxResult = MsgBox("¿Seguro que desea borrar este intervalo?", vbYesNo)
        If res = MsgBoxResult.Yes Then
            BindingSource1.Remove(ob)
            Me.tstGuardar_Click(Nothing, Nothing)
        End If

    End Sub

End Class
