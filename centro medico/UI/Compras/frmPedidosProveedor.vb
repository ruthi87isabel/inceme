Public Class frmPedidosProveedor

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public PedidoProveedor As CMDataSet.N_PedidosProveedor_ResumenRow


    Private Sub frmPedidosProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
            Me.NewToolStripButton.Enabled = True
        End If

        TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.N_PedidosProveedor_ResumenTableAdapter.Fill(Me.CMDataSet.N_PedidosProveedor_Resumen)
        CalculaTotal()

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmPedidosProveedor_ADD = New frmPedidosProveedor_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pedidos_Compras, "Pedidos Proveedor", "Nuevo", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_PedidosProveedor_ResumenTableAdapter.Fill(Me.CMDataSet.N_PedidosProveedor_Resumen)
            Me.N_PedidosProveedor_ResumenBindingSource.MoveLast()
            CalculaTotal()
        End If
    End Sub

    Private Sub N_PedidosProveedorDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_PedidosProveedorDataGridView.SelectionChanged
        tst_Editar.Enabled = N_PedidosProveedorDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_PedidosProveedorDataGridView.SelectedRows.Count > 0
        If N_PedidosProveedorDataGridView.SelectedRows.Count > 0 Then
            PedidoProveedor = N_PedidosProveedorDataGridView.SelectedRows(0).DataBoundItem.Row
            tst_TotalSeleccionado.Text = "Total seleccionado: " & PedidoProveedor.Total
        End If
    End Sub

    Private Sub CalculaTotal()
        tst_Total.Text = "Total: " & CMDataSet.N_PedidosProveedor_Resumen.Compute("SUM(Total)", String.Empty)

    End Sub

    Private Sub N_PedidosProveedorDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_PedidosProveedorDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            PedidoProveedor = N_PedidosProveedorDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        PedidoProveedor = N_PedidosProveedorDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmPedidosProveedor_ADD = New frmPedidosProveedor_ADD()
        frm.ID_PedidoProveedor = PedidoProveedor.ID_PedidoProveedor

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pedidos_Compras, "Pedidos Proveedor", PedidoProveedor.ID_PedidoProveedor.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_PedidosProveedorDataGridView.SelectedRows(0).Index
            Me.N_PedidosProveedor_ResumenTableAdapter.Fill(Me.CMDataSet.N_PedidosProveedor_Resumen)
            'MuestraTotales()
            N_PedidosProveedorDataGridView.Rows(pos).Selected = True
            CalculaTotal()
        End If
    End Sub

    Private Sub N_PedidosProveedorDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_PedidosProveedorDataGridView.CellFormatting

        If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
            If Not e.Value Is DBNull.Value Then
                e.Value = CType(e.Value, Globales.PedidosProveedor_Estado)
            End If

        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        PedidoProveedor = N_PedidosProveedorDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As CMDataSetTableAdapters.N_PedidosProveedorTableAdapter = New CMDataSetTableAdapters.N_PedidosProveedorTableAdapter()
        Dim n As Integer = adapter.DeleteQuery(PedidoProveedor.ID_PedidoProveedor)
        If n > 0 Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pedidos_Compras, "Pedidos Proveedor", PedidoProveedor.ID_PedidoProveedor.ToString(), "")

            PedidoProveedor.Delete()
            Me.N_PedidosProveedor_ResumenBindingSource.EndEdit()
            CalculaTotal()
        End If
    End Sub
End Class