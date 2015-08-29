Imports Janus.Windows.GridEX

Public Class Columna
    Implements IGridTipoOrden

    Private _key As String
    Public Property Key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            _key = value
        End Set
    End Property

    Private _caption As String
    Public Property Caption() As String
        Get
            Return _caption
        End Get
        Set(ByVal value As String)
            _caption = value
        End Set
    End Property

    Private _row As Integer
    Public Property Row() As Integer
        Get
            Return _row
        End Get
        Set(ByVal value As Integer)
            _row = value
        End Set
    End Property

    Private _col As Integer
    Public Property Column() As Integer
        Get
            Return _col
        End Get
        Set(ByVal value As Integer)
            _col = value
        End Set
    End Property

    Private _rowSpan As Integer
    Public Property RowSpan() As Integer
        Get
            Return _rowSpan
        End Get
        Set(ByVal value As Integer)
            _rowSpan = value
        End Set
    End Property

    Private _colSpan As Integer
    Public Property ColSpan() As Integer
        Get
            Return _colSpan
        End Get
        Set(ByVal value As Integer)
            _colSpan = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1},{2})", IIf(String.IsNullOrEmpty(Caption), Key, Caption), Row, Column)
    End Function

End Class
