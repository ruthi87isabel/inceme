Partial Public Class USUARIO

    '    Public ID_Usuario As Integer = -1
    '    Public Permisos As Permisos
    '    Public Data As CMDataSet.USUARIOSRow

    '    Public Sub New(ByVal ID_Usuario As Integer)
    '        Me.ID_Usuario = ID_Usuario
    '        'Cargar datos del usuario
    '        Permisos = New Permisos(ID_Usuario)
    '        Dim adapter As CMDataSetTableAdapters.USUARIOSTableAdapter = New CMDataSetTableAdapters.USUARIOSTableAdapter()
    '        Dim _data As CMDataSet.USUARIOSDataTable = adapter.GetUserById(ID_Usuario)
    '        Data = _data.Rows(0)
    '    End Sub

    Private hash As New Hashtable()

    Public ReadOnly Property Permisos(ByVal item As Integer) As Integer
        Get
            If hash.Count = 0 Then
                hash = RoleManager.PermisosPorUsuario(Me.CODIGO)
            End If

            If hash(item) Is Nothing Then
                Return RoleManager.TipoPermisos.Ninguno
            Else
                Dim permiso As ROLESPERMISO = hash(item)

                Return permiso.ID_PERMISO
            End If


        End Get

    End Property

    Public Function EsAdministrador() As Boolean
        'If Me.ADMINISTRADOR.ToUpper() = "S" Then
        '    Return True
        'End If

        For Each r As ROLESUSUARIO In Me.ROLESUSUARIOs
            If r.ID_ROLES = 1 Then
                Return True
            End If
        Next
        Return False

    End Function
End Class
