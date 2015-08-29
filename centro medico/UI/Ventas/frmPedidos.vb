Public Class frmPedidos

    Public Modo As Globals.ModoParaFormas = Globals.ModoParaFormas.Edicion
    Public Pedido As CMDataSet.N_Pedidos_ResumenRow


    Private Sub frmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Pedidos' table. You can move, or remove it, as needed.

        TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.N_Pedidos_ResumenTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Resumen)
        CalculaTotal()

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmPedidos_ADD = New frmPedidos_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Pedidos_ResumenTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Resumen)
            Me.N_Pedidos_ResumenBindingSource.MoveLast()
            CalculaTotal()
        End If
    End Sub

    Private Sub N_PedidosDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_PedidosDataGridView.SelectionChanged
        tst_Editar.Enabled = N_PedidosDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_PedidosDataGridView.SelectedRows.Count > 0
        If N_PedidosDataGridView.SelectedRows.Count > 0 Then
            Pedido = N_PedidosDataGridView.SelectedRows(0).DataBoundItem.Row
            tst_TotalSeleccionado.Text = "Total seleccionado: " & Pedido.Total
        End If
    End Sub

    Private Sub CalculaTotal()
        tst_Total.Text = "Total: " & CMDataSet.N_Pedidos_Resumen.Compute("SUM(Total)", String.Empty)

    End Sub

    Private Sub N_PedidosDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_PedidosDataGridView.CellDoubleClick
        If Modo = Globals.ModoParaFormas.Seleccion Then
            Pedido = N_PedidosDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Pedido = N_PedidosDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmPedidos_ADD = New frmPedidos_ADD()
        frm.ID_Pedido = Pedido.ID_Pedido
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_PedidosDataGridView.SelectedRows(0).Index
            Me.N_Pedidos_ResumenTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Resumen)
            'MuestraTotales()
            N_PedidosDataGridView.Rows(pos).Selected = True
            CalculaTotal()
        End If
    End Sub

    Private Sub N_PedidosDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_PedidosDataGridView.CellFormatting

        If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
            If Not e.Value Is DBNull.Value Then
                e.Value = CType(e.Value, Globals.Pedidos_Estado)
            End If

        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Pedido = N_PedidosDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As CMDataSetTableAdapters.N_PedidosTableAdapter = New CMDataSetTableAdapters.N_PedidosTableAdapter()
        Dim n As Integer = adapter.DeleteQuery(Pedido.ID_Pedido)
        If n > 0 Then
            Pedido.Delete()
            Me.N_Pedidos_ResumenBindingSource.EndEdit()
            CalculaTotal()
        End If
    End Sub
End Class
