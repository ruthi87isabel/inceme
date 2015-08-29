Public Class Permisos

    Dim hash As Hashtable = New Hashtable()

    Public ID_Usuario As Integer = -1

    Public Sub New(ByVal ID_Usuario As Integer)
        Me.ID_Usuario = ID_Usuario
        hash = RoleManager.PermisosPorUsuario(ID_Usuario)
    End Sub

    Default Public ReadOnly Property ListaPermisos(ByVal item As RoleManager.Items) As RoleManager.TipoPermisos
        Get
            If Not hash(CType(item, Integer)) Is Nothing Then
                Dim row As CMDataSet.PERMISOSPORUSUARIORow = hash(CType(item, Integer))
                Return [Enum].Parse(GetType(RoleManager.TipoPermisos), row.PERMISO)
            Else
                Return RoleManager.TipoPermisos.Ninguno
            End If
        End Get
    End Property

End Class
