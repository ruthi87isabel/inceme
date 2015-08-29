Public Class frmArticulo_Almacen_ADD


    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmArticulo_Almacen_ADD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos_Stock_Almacen) = RoleManager.TipoPermisos.Lectura Then
            Me.btn_Guardar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos_Stock_Almacen) = RoleManager.TipoPermisos.Modificar Then
            Me.btn_Guardar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos_Stock_Almacen) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos_Stock_Almacen) = RoleManager.TipoPermisos.Total Then
            Me.btn_Guardar.Enabled = True
        End If
    End Sub
End Class