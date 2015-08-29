Public Class frmProveedores

    Public ID_Proveedor As Integer
    Public Proveedor As CMDataSet.N_ProveedoresRow

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Private Sub N_ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.N_ProveedoresBindingSource.EndEdit()
        Me.N_ProveedoresTableAdapter.Update(Me.CMDataSet.N_Proveedores)

    End Sub

    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Proveedores' table. You can move, or remove it, as needed.
        Me.N_ProveedoresTableAdapter.Fill(Me.CMDataSet.N_Proveedores)

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
        End If

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmProveedor_Nuevo = New frmProveedor_Nuevo()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Proveedores, "Proveedores", "N", "")


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_ProveedoresTableAdapter.Fill(Me.CMDataSet.N_Proveedores)
        End If
        GC.Collect()
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Dim row As CMDataSet.N_ProveedoresRow = CType(CMDataSet.N_Proveedores(N_ProveedoresDataGridView.SelectedRows(0).Index), CMDataSet.N_ProveedoresRow)

        Dim frm As frmProveedor_Nuevo = New frmProveedor_Nuevo()
        frm.ID_Proveedor = row.ID_Proveedor

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Proveedores, "Proveedores", row.ID_Proveedor.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_ProveedoresTableAdapter.Fill(Me.CMDataSet.N_Proveedores)
        End If
        GC.Collect()
    End Sub

    Private Sub N_ProveedoresDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_ProveedoresDataGridView.SelectionChanged
        tst_Editar.Enabled = N_ProveedoresDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_ProveedoresDataGridView.SelectedRows.Count > 0
    End Sub

    Private Sub N_ProveedoresDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_ProveedoresDataGridView.CellDoubleClick

        If Modo = Globales.ModoParaFormas.Seleccion Then
            Proveedor = CType(CMDataSet.N_Proveedores(N_ProveedoresDataGridView.SelectedRows(0).Index), CMDataSet.N_ProveedoresRow)
            ID_Proveedor = Proveedor.ID_Proveedor
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
        GC.Collect()
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Dim row As CMDataSet.N_ProveedoresRow = CType(CMDataSet.N_Proveedores(N_ProveedoresDataGridView.SelectedRows(0).Index), CMDataSet.N_ProveedoresRow)
        row.Delete()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Proveedores, "Proveedores", "", "")

        N_ProveedoresTableAdapter.Update(CMDataSet.N_Proveedores)
        GC.Collect()
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_PROVEEDORES"
        ds.Value = N_ProveedoresDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("TPVProveedoresListado.rdlc", {ds})
    End Sub
End Class