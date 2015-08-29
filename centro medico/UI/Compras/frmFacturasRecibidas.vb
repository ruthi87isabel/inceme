Public Class frmFacturasRecibidas

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public FacturaRecibida As CMDataSet.N_FacturasRecibidas_ResumenRow


    Private Sub frmFacturasRecibidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
            Me.NewToolStripButton.Enabled = True
        End If

        TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.N_FacturasRecibidas_ResumenTableAdapter.Fill(Me.CMDataSet.N_FacturasRecibidas_Resumen)
        CalculaTotal()

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmFacturasRecibidas_ADD = New frmFacturasRecibidas_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Facturas_Compras, "Facturas Compras", "Nueva", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_FacturasRecibidas_ResumenTableAdapter.Fill(Me.CMDataSet.N_FacturasRecibidas_Resumen)
            Me.N_FacturasRecibidas_ResumenBindingSource.MoveLast()
            CalculaTotal()
        End If
    End Sub

    Private Sub N_FacturasRecibidasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_FacturasRecibidasDataGridView.SelectionChanged
        tst_Editar.Enabled = N_FacturasRecibidasDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_FacturasRecibidasDataGridView.SelectedRows.Count > 0
        If N_FacturasRecibidasDataGridView.SelectedRows.Count > 0 Then
            FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row
            tst_TotalSeleccionado.Text = "Total seleccionado: " & FacturaRecibida.Total
        End If
    End Sub

    Private Sub CalculaTotal()
        tst_Total.Text = "Total: " & CMDataSet.N_FacturasRecibidas_Resumen.Compute("SUM(Total)", String.Empty)

    End Sub

    Private Sub N_FacturasRecibidasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_FacturasRecibidasDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmFacturasRecibidas_ADD = New frmFacturasRecibidas_ADD()
        frm.ID_FacturaRecibida = FacturaRecibida.ID_FacturaRecibida

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Facturas_Compras, "Facturas Compras", FacturaRecibida.ID_FacturaRecibida.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_FacturasRecibidasDataGridView.SelectedRows(0).Index
            Me.N_FacturasRecibidas_ResumenTableAdapter.Fill(Me.CMDataSet.N_FacturasRecibidas_Resumen)
            'MuestraTotales()
            N_FacturasRecibidasDataGridView.Rows(pos).Selected = True
            CalculaTotal()
        End If
    End Sub


    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As CMDataSetTableAdapters.N_FacturasRecibidasTableAdapter = New CMDataSetTableAdapters.N_FacturasRecibidasTableAdapter()
        Dim n As Integer = adapter.DeleteQuery(FacturaRecibida.ID_FacturaRecibida)
        If n > 0 Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Facturas_Compras, "Facturas Compras", FacturaRecibida.ID_FacturaRecibida.ToString(), "")

            FacturaRecibida.Delete()
            Me.N_FacturasRecibidas_ResumenBindingSource.EndEdit()
            CalculaTotal()
        End If
    End Sub
End Class