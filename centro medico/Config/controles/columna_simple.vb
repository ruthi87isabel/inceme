Public Class columna_simple

    Dim name As String
    Dim visible As Boolean
    Dim filtrar As Boolean
    Public Event VisibleChecked As VisibleEventHandler
    Public Event FiltradoChecked As FilterEventHandler
    Sub New(ByVal aname As String, ByVal avisible As Boolean, ByVal afiltrar As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lb_texto.Text = aname
        chb_visible.Checked = avisible
        chb_filtro.Checked = afiltrar
        name = aname
        visible = avisible
        filtrar = afiltrar
    End Sub
    Public Property Visibilidad() As Boolean
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return visible
        End Get
        Set(ByVal value As Boolean)
            visible = value
        End Set

    End Property

    Public Property Filtrado() As Boolean
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return filtrar
        End Get
        Set(ByVal value As Boolean)
            filtrar = value
        End Set

    End Property
    Public Property Nombre() As String
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set

    End Property

    Public Overridable Sub OnVisible(ByVal e As VisibleEventArgs)
        RaiseEvent VisibleChecked(Me, e)
    End Sub

    Protected Overridable Sub OnFiltrado(ByVal e As FilterEventArgs)
        RaiseEvent FiltradoChecked(Me, e)
    End Sub

    Private Sub chb_visible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_visible.CheckedChanged
        If chb_visible.Checked = True Then
            Me.Visibilidad = True
            Dim vis As New VisibleEventArgs(Me.Nombre, True)
            OnVisible(vis)
        Else
            Me.Visibilidad = False
            Dim vis As New VisibleEventArgs(Me.Nombre, False)
            OnVisible(vis)
        End If
    End Sub

    Private Sub chb_filtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_filtro.CheckedChanged
        If chb_filtro.Checked = True Then
            Me.Filtrado = True
            Dim filt As New FilterEventArgs(Me.Nombre, True)
            OnFiltrado(filt)
        Else
            Me.Filtrado = False
            Dim filt As New FilterEventArgs(Me.Nombre, False)
            OnFiltrado(filt)
        End If
    End Sub
End Class
Public Delegate Sub VisibleEventHandler(ByVal sender As Object, ByVal e As VisibleEventArgs)
Public Delegate Sub FilterEventHandler(ByVal sender As Object, ByVal e As FilterEventArgs)

Public Class VisibleEventArgs
    Inherits EventArgs
    Private namec As String
    Private visiblec As Boolean

    Public Sub New(ByVal aname As String, ByVal avisible As Boolean)
        namec = aname
        visiblec = avisible
    End Sub
    Public Property Name() As String
        Get
            Return namec
        End Get
        Set(ByVal Value As String)
            namec = Value
        End Set
    End Property

    Public Property Visible() As Boolean
        Get
            Return visiblec
        End Get
        Set(ByVal Value As Boolean)
            visiblec = Value
        End Set
    End Property
End Class

Public Class FilterEventArgs
    Inherits EventArgs
    Private namec As String
    Private filterc As Boolean

    Public Sub New(ByVal aname As String, ByVal afilter As Boolean)
        namec = aname
        filterc = afilter
    End Sub
    Public Property Name() As String
        Get
            Return namec
        End Get
        Set(ByVal Value As String)
            namec = Value
        End Set
    End Property

    Public Property Filtrado() As Boolean
        Get
            Return filterc
        End Get
        Set(ByVal Value As Boolean)
            filterc = Value
        End Set
    End Property
End Class