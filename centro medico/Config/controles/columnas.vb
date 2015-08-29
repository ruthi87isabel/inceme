Public Class columnas
    Dim binding As BindingSource
    Dim columns As ArrayList

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public ReadOnly Property Columnas() As ArrayList
        Get
            Return columns
        End Get
    End Property
    
    Private Sub columnas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim c As columna_simple = New columna_simple("", True, True)

    Public Event VisibleColumnsChecked As VisibleEventHandler
    Public Event FiltradoColumnsChecked As FilterEventHandler

    Protected Overridable Sub OnVisible(ByVal sender As Object, ByVal e As VisibleEventArgs)
        RaiseEvent VisibleColumnsChecked(sender, e)
    End Sub

    Protected Overridable Sub OnFiltrado(ByVal sender As Object, ByVal e As FilterEventArgs)
        RaiseEvent FiltradoColumnsChecked(sender, e)
    End Sub
    Public Sub Visible_Change(ByVal sender As Object, ByVal e As VisibleEventArgs)
        OnVisible(sender, e)
    End Sub

    Public Sub Filter_Change(ByVal sender As Object, ByVal e As FilterEventArgs)
        OnFiltrado(sender, e)
    End Sub
End Class
