Imports LinqKit.PredicateBuilder
Imports System.Linq.Expressions

Partial Class MEDICO
    Public Function importarRecetas(ByVal path As String)
        Dim receta As New recetaXML
        Dim res As Boolean = receta.leeXML(path, Me.CMEDICO, Me.COLEGIADO)

        If res = False Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.RecetasXml, "Recetas XML", "", "Se ha intentado importar un fichero de recetas xml sin existo")
        Else
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.RecetasXml, "Recetas XML", "", "Se ha importado el lote de recetas xml " & receta.NumeroLote & "  con existo")
        End If
        Return res
    End Function

    Public Function horasOcupadas(ByRef diasSeleccionados As List(Of Date), ByRef context As CMLinqDataContext) As IQueryable(Of HORARIOS_MEDICOS)

        Dim query As IQueryable(Of HORARIOS_MEDICOS) = From o In context.HORARIOS_MEDICOS Where o.medico_id = CMEDICO Select o

        Dim a As Expression(Of Func(Of HORARIOS_MEDICOS, Boolean)) = LinqKit.PredicateBuilder.False(Of HORARIOS_MEDICOS)()

        For Each i As Date In diasSeleccionados
            a = a.Or(Function(o As HORARIOS_MEDICOS) o.fecha = i)
        Next
        query = query.Where(a)

        Return query
    End Function
    ''' <summary>
    ''' Devuelve las horas que entran en conflicto con las que se desean guarar
    ''' </summary>
    ''' <param name="horaini">Hora inicio que se desea guardar</param>
    ''' <param name="horafin">Hora fin que se desea guardar</param>
    ''' <param name="dia">Dia en a la que se aplican hora inicio y hora fin</param>
    ''' <param name="context">Context de acceso a la bd.</param>
    ''' <returns>Lista del objeto HORARIOS_MEDICOS que entran en conflicto con lo que se desea guardar</returns>
    ''' <remarks></remarks>
    Public Function CheckConflictosHoras(ByRef horaini As Date, ByRef horafin As Date, ByVal dia As Date, ByRef context As CMLinqDataContext) As List(Of HORARIOS_MEDICOS)
        Dim horaIniCheckear As New Date(dia.Year, dia.Month, dia.Day, horaini.Hour, horaini.Minute, 0)
        Dim horaFinCheckear As New Date(dia.Year, dia.Month, dia.Day, horafin.Hour, horafin.Minute, 0)
        Dim intervalos As List(Of HORARIOS_MEDICOS)

        intervalos = (From o In context.HORARIOS_MEDICOS Where o.medico_id = Me.CMEDICO And o.fecha = dia _
                     And ((horaIniCheckear >= o.hora_ini And horaIniCheckear <= o.hora_fin) Or _
                    (horaFinCheckear >= o.hora_ini And horaFinCheckear <= o.hora_fin))).ToList

        Return (intervalos)
    End Function



End Class
