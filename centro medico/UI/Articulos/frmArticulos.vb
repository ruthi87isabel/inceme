Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmArticulos

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Articulo As CMDataSet.N_ArticulosResumenRow


    Private Sub frmArticulosResumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargaArticulos()

        'NewToolStripButton.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Articulos) > 2)
        'tst_Editar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Articulos) > 2)
        'tst_Eliminar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Articulos) > 3)
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
        End If


    End Sub

    Private Sub CargaArticulos()
        Me.CMDataSet.N_ArticulosResumen.Clear()
        'Me.CMDataSet.N_ArticulosResumen.Columns.Clear()
        Me.N_ArticulosResumenTableAdapter.Fill(Me.CMDataSet.N_ArticulosResumen)


        If Not Me.CMDataSet.N_ArticulosResumen.Columns.Contains("StockReal") Then
            Me.CMDataSet.N_ArticulosResumen.Columns.Add("StockReal")
        End If

        If Not Me.CMDataSet.N_ArticulosResumen.Columns.Contains("StockPrevisto") Then
            Me.CMDataSet.N_ArticulosResumen.Columns.Add("StockPrevisto")
        End If

        For Each row As DataGridViewRow In N_ArticulosResumenDataGridView.Rows
            Dim arti As CMDataSet.N_ArticulosResumenRow = row.DataBoundItem.Row
            Dim stock As StockArticulo = Globales.CalculaStockTodosAlmacenes(arti.ID_Articulo, Date.Now)
            row.Cells("StockReal").Value = stock.StockReal
            row.Cells("StockPrevisto").Value = stock.StockPrevisto

            If Not arti.IsFavoritoNull Then
                row.Cells("Favorito").Value = My.Resources.Button_Favorite_icon
            Else
                row.Cells("Favorito").Value = New Bitmap(16, 16)
            End If
        Next
        FiltrarGrid()
    End Sub


    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmArticulos_ADD = New frmArticulos_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Articulos, "Articulos", "NUEVO", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CargaArticulos()
            Me.N_ArticulosResumenBindingSource.MoveLast()
        End If
    End Sub

    Private Sub N_ArticulosResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_ArticulosResumenDataGridView.SelectionChanged
        tst_Editar.Enabled = N_ArticulosResumenDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_ArticulosResumenDataGridView.SelectedRows.Count > 0
        'tstMarcarComoFavorito.Enabled = N_ArticulosResumenDataGridView.SelectedRows.Count > 0
        If N_ArticulosResumenDataGridView.SelectedRows.Count > 0 Then
            Articulo = N_ArticulosResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        End If
    End Sub


    Private Sub N_ArticulosResumenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_ArticulosResumenDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Articulo = N_ArticulosResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Articulo = N_ArticulosResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmArticulos_ADD = New frmArticulos_ADD()
        frm.ID_Articulo = Articulo.ID_Articulo

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Articulos, "Articulos", Articulo.ID_Articulo.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_ArticulosResumenDataGridView.SelectedRows(0).Index
            CargaArticulos()
            N_ArticulosResumenDataGridView.Rows(pos).Selected = True
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Articulo = N_ArticulosResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        If N_ArticulosResumenTableAdapter.DeleteQuery(Articulo.ID_Articulo) > 0 Then

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Articulos, "Articulos", Articulo.ID_Articulo.ToString(), "")

            Articulo.Delete()
            Me.N_ArticulosResumenBindingSource.EndEdit()
        End If
    End Sub

    Private Sub tstMarcarComoFavorito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Articulo = N_ArticulosResumenDataGridView.SelectedRows(0).DataBoundItem.Row

        ToggleFavorito(Articulo.ID_Articulo)

        Dim pos As Integer = N_ArticulosResumenDataGridView.SelectedRows(0).Index
        CargaArticulos()
        N_ArticulosResumenDataGridView.Rows(pos).Selected = True

    End Sub

    Private Sub ToggleFavorito(ByVal idArticulo As Long)

        Dim context As New CMLinqDataContext()
        Dim arti As N_Articulo = (From a In context.N_Articulos Where a.ID_Articulo = idArticulo Select a).Single()

        If arti.Favorito Is Nothing Then
            arti.Favorito = 1
        Else
            arti.Favorito = Nothing
        End If

        context.SubmitChanges()

    End Sub

    'Private Sub N_ArticulosResumenDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_ArticulosResumenDataGridView.CellFormatting
    '    If e.ColumnIndex = Favorito.Index Then
    '        Dim arti As CMDataSet.N_ArticulosResumenRow = N_ArticulosResumenDataGridView.Rows(e.RowIndex).DataBoundItem.Row
    '        If Not arti.IsFavoritoNull Then
    '            N_ArticulosResumenDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = My.Resources.Button_Favorite_icon
    '        Else
    '            N_ArticulosResumenDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = New Bitmap(16, 16)
    '        End If
    '    End If
    'End Sub

#Region "Private Sub FiltrarGrid()"

    Private Sub FiltrarGrid()
        Dim condition As New GridEXFilterCondition()

        condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                           New GridEXFilterCondition(GridEX1.RootTable.Columns("Favorito"), Janus.Windows.GridEX.ConditionOperator.NotIsNull, Nothing))

        GridEX1.RootTable.FilterCondition = Nothing
        GridEX1.RootTable.FilterCondition = condition
        'GridEX1.RootTable.ApplyFilter(condition)

    End Sub
#End Region


    Private Sub N_ArticulosResumenDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_ArticulosResumenDataGridView.CellClick
        If e.ColumnIndex = Favorito.Index Then
            Dim arti As CMDataSet.N_ArticulosResumenRow = N_ArticulosResumenDataGridView.Rows(e.RowIndex).DataBoundItem.Row
            ToggleFavorito(arti.ID_Articulo)
            Dim pos As Integer = N_ArticulosResumenDataGridView.SelectedRows(0).Index
            CargaArticulos()
            N_ArticulosResumenDataGridView.Rows(pos).Selected = True
        End If
    End Sub

    Private Sub N_ArticulosResumenDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles N_ArticulosResumenDataGridView.DataError
        e.Cancel = True
    End Sub

  
    Private Sub tstImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tstImprimir.Click

        'Datasources
        Dim dsFactura As New Microsoft.Reporting.WinForms.ReportDataSource
        dsFactura.Name = "dsArticulos"
        dsFactura.Value = N_ArticulosResumenDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("TPVArticulosListado.rdlc", {dsFactura})

    End Sub
End Class