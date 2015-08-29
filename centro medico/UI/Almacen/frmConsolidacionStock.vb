Public Class frmConsolidacionStock


    Public ConsolidacionStock As CMDataSet.N_Articulos_Consolidacion_ResumenRow

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Private Sub frmConsolidacionStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.N_Articulos_Consolidacion_ResumenTableAdapter.Fill(Me.CMDataSet.N_Articulos_Consolidacion_Resumen)

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
            Me.NewToolStripButton.Enabled = True
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Chequear condiciones para nuevo ConsolidacionStock

        Dim frm As frmConsolidacionStock_ADD = New frmConsolidacionStock_ADD()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Consolidar_Stock, "Consolidacion Stock", "NUEVO", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Articulos_Consolidacion_ResumenTableAdapter.Fill(Me.CMDataSet.N_Articulos_Consolidacion_Resumen)
            'Ubicarlo en el ultimo insertado, no se si funcionara cuando hayan filtros
            'Me.N_Articulos_Consolidacion_ResumenBindingSource.Current = Me.CMDataSet.N_Articulos_Consolidacion_Resumen.FindByID_ConsolidacionStock(frm.ConsolidacionStockCreado.ID_ConsolidacionStock)
            Me.N_Articulos_Consolidacion_ResumenBindingSource.MoveLast()

        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        Dim ConsolidacionStock As CMDataSet.N_Articulos_Consolidacion_ResumenRow = N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmConsolidacionStock_ADD = New frmConsolidacionStock_ADD()
        frm.ID_Consolidacion = ConsolidacionStock.ID_Consolidacion

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Consolidar_Stock, "Consolidacion Stock", ConsolidacionStock.ID_Consolidacion.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = Me.N_Articulos_Consolidacion_ResumenBindingSource.Position
            Me.N_Articulos_Consolidacion_ResumenTableAdapter.Fill(Me.CMDataSet.N_Articulos_Consolidacion_Resumen)
            Me.N_Articulos_Consolidacion_ResumenBindingSource.Position = pos
        End If
    End Sub

    Private Sub N_ConsolidacionStockDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Articulos_Consolidacion_ResumenDataGridView.SelectionChanged
        tst_Editar.Enabled = N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows.Count > 0
    End Sub


    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Dim ConsolidacionStock As CMDataSet.N_Articulos_Consolidacion_ResumenRow = N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Consolidar_Stock, "Consolidacion Stock", ConsolidacionStock.ID_Consolidacion.ToString(), "")

        Dim adapter As CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter = New CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter()
        adapter.DeleteQuery(ConsolidacionStock.ID_Consolidacion)
        ConsolidacionStock.Delete()
    End Sub

    Private Sub N_ConsolidacionStockDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Articulos_Consolidacion_ResumenDataGridView.CellDoubleClick
        If N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows.Count = 0 Then Return

        If Modo = Globales.ModoParaFormas.Seleccion Then
            ConsolidacionStock = N_Articulos_Consolidacion_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If Modo = Globales.ModoParaFormas.Edicion Then
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub
End Class