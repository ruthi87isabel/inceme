Imports System.Linq.Expressions
Imports LinqKit.PredicateBuilder
Public Class Form1
    Dim seleccionandodias As Boolean = False
    Dim diasseleccionados As New List(Of Date)
    Dim context As New CMLinqDataContext

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        context.SubmitChanges()
    End Sub

    Private Sub CtrlHorarios1_DiaSeleccionado(sender As Object, e As Pabo.Calendar.DaySelectedEventArgs) Handles CtrlHorarios1.DiaSeleccionado
        Dim a As Object
        a = e
        For Each d As Date In e.Days
            diasseleccionados.Add(d)
        Next
        If diasseleccionados.Count = 0 Then BindingSource1.DataSource = Nothing
        If Not seleccionandodias And diasseleccionados.Count > 0 Then
            horaOcupadas()
        End If
    End Sub

    Private Sub horaOcupadas()

        Dim query As IQueryable(Of HORARIOS_MEDICOS) = From o In context.HORARIOS_MEDICOS Where o.medico_id = 1 Select o
        'Dim res As List(Of HORARIOS_MEDICOS)
        'Dim a As Expression(Of Func(Of HORARIOS_MEDICOS, Boolean)) = LinqKit.PredicateBuilder.False(Of HORARIOS_MEDICOS)()

        'For Each i As Date In diasseleccionados
        '    a = a.Or(Function(o As HORARIOS_MEDICOS) o.fecha = i)
        '    ' query = query.Union((Function(e) e.fecha. = i)
        'Next
        'res = query.Where(a).ToList
        BindingSource1.DataSource = query
        diasseleccionados.Clear()
    End Sub

    Private Sub CtrlHorarios1_StartMultiSelectionEvent() Handles CtrlHorarios1.StartMultiSelectionEvent
        seleccionandodias = True
    End Sub

    Private Sub CtrlHorarios1_EndMultiSelectionEvent() Handles CtrlHorarios1.EndMultiSelectionEvent
        seleccionandodias = False
    End Sub


    Private Sub GridEX1_ColumnButtonClick(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Dim hora As HORARIOS_MEDICOS = GridEX1.CurrentRow.DataRow
        BindingSource1.Remove(hora)
        BindingSource1.EndEdit()
        context.HORARIOS_MEDICOS.DeleteOnSubmit(hora)
    End Sub
End Class