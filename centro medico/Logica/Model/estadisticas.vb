Public Class estadisticas

    ' Numero de Pacientes por día atendidos
    ' Media de Pacientes por médico
    ' Ingresos por médico
    ' 10 Tratamientos más usados
    ' % Formas de pago
    ' Pacientes por paises / provincias
    Public dato As String
    Public valor As Double

    '''<sumary>Devuelve un objeto con dias y pacientes atendidos </sumary>
    Public Shared Function pacientesPorDia(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal context As CMLinqDataContext) As Collection
        Dim citas = (From a In context.CITAs Where a.FECHA >= fechaInicial And a.FECHA <= fechaFinal.AddDays(1) Order By a.FECHA Group By a.FECHA Into Count())
        Dim datos As New Collection

        For Each aa As Object In citas
            Dim dato As New estadisticas
            dato.dato = aa.fecha
            dato.valor = aa.count
            datos.Add(dato)
        Next
    End Function

End Class
