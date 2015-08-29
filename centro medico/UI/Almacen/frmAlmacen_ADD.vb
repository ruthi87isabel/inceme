Public Class frmAlmacen_ADD


    Public ID_Almacen As Long = -1
    Public Almacen As CMDataSet.N_AlmacenRow = Nothing

    Private Sub frmAlmacen_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.grpDetalles.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Almacen) > 2)
        'Me.btn_Guardar.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Almacen) > 2)
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Lectura Then
            Me.btn_Guardar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Modificar Then
            Me.btn_Guardar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("No tiene permisos para acceder a esta parte de la aplicación", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Total Then
            Me.btn_Guardar.Enabled = True
        End If

        If ID_Almacen <> -1 Then
            Me.N_AlmacenTableAdapter.FillBy(Me.CMDataSet.N_Almacen, ID_Almacen)
            Almacen = Me.CMDataSet.N_Almacen(0)
        Else
            'Crearlo Nuevo
            Almacen = N_AlmacenBindingSource.AddNew().Row()
            CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Almacen", "ID_Almacen", "000000")
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If CodigoTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir algun código")
            CodigoTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.N_AlmacenBindingSource.EndEdit()
        Me.N_AlmacenTableAdapter.Update(Me.CMDataSet.N_Almacen)
        ID_Almacen = Almacen.ID_Almacen

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Almacen, "Almacen", Almacen.ID_Almacen.ToString(), "")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class