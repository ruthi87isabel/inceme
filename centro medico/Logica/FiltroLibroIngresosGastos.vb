Public Class FiltroLibroIngresosGastos
    Inherits FiltroGenericoDocumentos


    Public Property IncluirFacturas As Boolean = False
    Public Property IncluirTPVFacturas As Boolean = False
    Public Property IncluirRecibos As Boolean = False
    Public Property IncluirCitas As Boolean = False
    Public Property IncluirTickets As Boolean = False
    Public Property IncluirEntregasCuenta As Boolean = False
    Public Property IncluirGastosVarios As Boolean = False
    Public Property IncluirImportesDoctores As Boolean = False
    Public Property IncluirTPVFacturasProveedores As Boolean = False

End Class
