Public Interface IDocumentoPagable

    ReadOnly Property IDDocumento As String
    ReadOnly Property IDPaciente As Integer
    ReadOnly Property TipoDocumento As PacienteDebitoManager.TipoDocumento
    ReadOnly Property Importe As Double

    ReadOnly Property DescripcionDocumento As String

    ReadOnly Property IDFormaPago As String

    Property PagadoConCredito As Boolean

    Function Pagado() As Boolean
    Sub MarcarPagado(fecha As Date, Optional idFormaPago As String = "")
    Sub MarcarDespagado()

End Interface