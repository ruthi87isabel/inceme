Public Class form_listados


    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub New(ByVal aName As String, ByVal aSource As BindingSource, ByVal aCurrentList As RoleManager.Items)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Listado_control.gv_listado.DataSource = aSource
        Listado_control.nav_listado.BindingSource = aSource
        Listado_control.CurrentList = aCurrentList
        Me.WindowState = FormWindowState.Maximized
        Me.Text = aName
        Listado_control.Configuracion = Globales.Configuracion

    End Sub
    Sub New(ByVal aName As String, ByVal aSource As BindingSource, ByVal aCurrentList As RoleManager.Items, ByVal aSeleccion As Boolean, Optional ByVal table As String = "", Optional ByVal where As String = "", Optional ByVal sort As String = "")

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Listado_control.gv_listado.DataSource = aSource
        Listado_control.nav_listado.BindingSource = aSource
        Listado_control.CurrentList = aCurrentList
        Listado_control.Configuracion = Globales.Configuracion
        Listado_control.PTable = table
        Listado_control.PWhere = where
        Listado_control.POrder = sort

        If aSeleccion = True Then
            'Listado_control.bt_seleccionar.Show()
            Listado_control.Selection = True
        End If
        Me.Text = aName

        Me.WindowState = FormWindowState.Maximized
    End Sub
   

    Public ReadOnly Property Selected() As String
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return Listado_control.Selected
        End Get

    End Property
  

End Class
