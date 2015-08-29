
Public Interface IGastoRepository
    Function GetDocumentos(Filtros As FiltroGenericoDocumentos) As ICollection(Of ILibroItem)
End Interface
