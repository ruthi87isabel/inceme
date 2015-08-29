Public Class LibroIngresosGastosManager


    ' ''' <summary>
    ' ''' Retorna las entradas del Libro de Ingresos de Gastos que cumple con los filtros informados
    ' ''' </summary>
    ' ''' <param name="filtro"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function ObtenLibroIngresosGastos(filtro As IFiltroGenericoDocumentos) As ILibroIngresosGastos

    '    Dim libro As New LibroIngresosGastos()

    '    Return libro
    'End Function


    'Public Function ObtenLibroIngresosGastos(gastosRepositorios As ICollection(Of IGastoRepository), _
    '                                         ingresosRepositorios As ICollection(Of IIngresosRepository), _
    '                                         filtros As FiltroGenericoDocumentos _
    '                                         ) As ICollection(Of ILibroItem)
    '    Return gastosRepositorios.
    'End Function



    'Public Function CalculaBalance(fechaIni As Date, fechaFin As Date, ingresos As ICollection(Of IIngreso), gastos As ICollection(Of IGasto)) As Balance

    '    Return New Balance With
    '                             {.EntregasCuenta = 20.0,
    '                              .IngresosPorPago = 10.0,
    '                              .PagoDesdeCredito = 30.0,
    '                              .Gastos = 15.0,
    '                              .TotalIngresos = 30
    '                             }

    '    Return New Balance With
    '                              {.EntregasCuenta = 20.0,
    '                               .IngresosPorPago = 10.0,
    '                               .PagoDesdeCredito = 30.0,
    '                               .Gastos = 15.0,
    '                               .TotalIngresos = 30
    '                              }
    'End Function

End Class

