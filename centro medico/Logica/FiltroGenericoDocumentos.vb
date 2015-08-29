Public Class FiltroGenericoDocumentos
    Implements IFiltroGenericoDocumentos


    Private _FechaEmisionInicial As DateTime?
    Private _FechaEmisionFinal As DateTime?
    Private _FechaPagoInicial As DateTime?
    Private _FechaPagoFinal As DateTime?

    Private _HoraEmisionInicial As DateTime?
    Private _HoraEmisionFinal As DateTime?

    Public Property CPACIENTE As Integer?

    Public Property FechaEmisionInicial As DateTime? Implements IFiltroGenericoDocumentos.FechaEmisionInicial
        Get
            Return _FechaEmisionInicial
        End Get
        Set(value As DateTime?)
            _FechaEmisionInicial = FirstDate(value)
        End Set
    End Property

    Public Property FechaEmisionFinal As DateTime? Implements IFiltroGenericoDocumentos.FechaEmisionFinal
        Get
            Return _FechaEmisionFinal
        End Get
        Set(value As DateTime?)
            _FechaEmisionFinal = LastDate(value)
        End Set
    End Property

    Public Property HoraEmisionInicial As DateTime? Implements IFiltroGenericoDocumentos.HoraEmisionInicial
        Get
            Return _HoraEmisionInicial
        End Get
        Set(value As DateTime?)
            _HoraEmisionInicial = FirstTime(value)
        End Set
    End Property


    Public Property HoraEmisionFinal As DateTime? Implements IFiltroGenericoDocumentos.HoraEmisionFinal
        Get
            Return _HoraEmisionFinal
        End Get
        Set(value As DateTime?)
            _HoraEmisionFinal = LastTime(value)
        End Set
    End Property

    Public Property FechaPagoInicial As DateTime? Implements IFiltroGenericoDocumentos.FechaPagoInicial
        Get
            Return _FechaPagoInicial
        End Get
        Set(value As DateTime?)
            _FechaPagoInicial = FirstDate(value)
        End Set
    End Property

    Public Property FechaPagoFinal As DateTime? Implements IFiltroGenericoDocumentos.FechaPagoFinal
        Get
            Return _FechaPagoFinal
        End Get
        Set(value As DateTime?)
            _FechaPagoFinal = LastDate(value)
        End Set
    End Property

    Public Property UsarFechaPagoComoAnd As Boolean = True Implements IFiltroGenericoDocumentos.UsarFechaPagoComoAnd

    Public Property IncluirConImporteCero As Boolean = True Implements IFiltroGenericoDocumentos.IncluirConImporteCero

    Public Property StatusPago As StatusPago = StatusPago.Todos Implements IFiltroGenericoDocumentos.StatusPago

    Public Property FormaPago As String Implements IFiltroGenericoDocumentos.FormaPago


    Public Shared Function FirstDate(value As DateTime?) As DateTime?
        If value Is Nothing Then
            Return Nothing
        End If
        Return IIf(value.HasValue, New Date(value.Value.Year, value.Value.Month, value.Value.Day, 0, 0, 0), Nothing)
    End Function

    Public Shared Function LastDate(value As DateTime?) As DateTime?
        If value Is Nothing Then
            Return Nothing
        End If
        Return IIf(value.HasValue, New Date(value.Value.Year, value.Value.Month, value.Value.Day, 23, 59, 59), Nothing)
    End Function

    Public Shared Function FirstTime(value As DateTime?) As DateTime?
        If value Is Nothing Then
            Return Nothing
        End If
        Return IIf(value.HasValue, New Date(1, 1, 1, value.Value.Hour, value.Value.Minute, 0), Nothing)
    End Function

    Public Shared Function LastTime(value As DateTime?) As DateTime?
        If value Is Nothing Then
            Return Nothing
        End If
        Return IIf(value.HasValue, New Date(1, 1, 1, value.Value.Hour, value.Value.Minute, 59), Nothing)
    End Function

End Class



Public Enum StatusPago
    Pagado = 1
    NoPagado = 2
    Todos = 0
End Enum