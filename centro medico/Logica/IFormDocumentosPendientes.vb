Public Interface IFormDocumentosPendientes

    Property DocumentosPendientes As ICollection(Of IDocumentoPagable)

    Property IdFormaPagoPreseleccionada As String

    Property IdFormaPagoSeleccionada As String

    ReadOnly Property UsarCredito As Boolean

    Property Credito As Double

    Property Importe As Double

    Function Muestra(credito As Double) As DialogResult

    ReadOnly Property FechaPago As Date

End Interface
