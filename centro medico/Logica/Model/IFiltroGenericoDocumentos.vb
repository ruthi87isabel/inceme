Public Interface IFiltroGenericoDocumentos

    Property FechaEmisionInicial As DateTime?
    Property FechaEmisionFinal As DateTime?
    Property HoraEmisionInicial As DateTime?
    Property HoraEmisionFinal As DateTime?
    Property FechaPagoInicial As DateTime?
    Property FechaPagoFinal As DateTime?
    Property UsarFechaPagoComoAnd As Boolean
    Property IncluirConImporteCero As Boolean
    Property StatusPago As StatusPago
    Property FormaPago As String

End Interface
