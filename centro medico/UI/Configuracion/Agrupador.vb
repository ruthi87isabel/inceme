Public Class Agrupador
    Implements IGridTipoOrden

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _noColumnas As String
    Public Property NoColumnas() As String
        Get
            Return _noColumnas
        End Get
        Set(ByVal value As String)
            _noColumnas = value
        End Set
    End Property

    Private _noFilas As String
    Public Property Filas() As String
        Get
            Return _noFilas
        End Get
        Set(ByVal value As String)
            _noFilas = value
        End Set
    End Property

    Private _anchoColumnas As List(Of Integer)
    Public Property AnchoColumnas() As List(Of Integer)
        Get
            Return _anchoColumnas
        End Get
        Set(ByVal value As List(Of Integer))
            _anchoColumnas = value
        End Set
    End Property

    Private _columnas As List(Of Columna)
    Public Property Columnas() As List(Of Columna)
        Get
            Return _columnas
        End Get
        Set(ByVal value As List(Of Columna))
            _columnas = value
        End Set
    End Property

    Private _index As Integer
    Public Property Index() As Integer
        Get
            Return _index
        End Get
        Set(ByVal value As Integer)
            _index = value
        End Set
    End Property


    Public Sub New()
        Columnas = New List(Of Columna)
        AnchoColumnas = New List(Of Integer)
    End Sub
End Class

