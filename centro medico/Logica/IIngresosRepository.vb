
Public Interface IIngresosRepository
    Function GetDocumentos(Filtros As FiltroGenericoDocumentos) As ICollection(Of ILibroItem)
End Interface
