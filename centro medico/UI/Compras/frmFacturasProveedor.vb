Public Class frmFacturasProveedor

    Public Modo As Globals.ModoParaFormas = Globals.ModoParaFormas.Edicion
    Public FacturaRecibida As CMDataSet.N_FacturasRecibidas_ResumenRow


    Private Sub frmFacturasRecibidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.N_FacturasRecibidas_ResumenTableAdapter.Fill(Me.CMDataSet.N_FacturasRecibidas_Resumen)
        CalculaTotal()

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmFacturasProveedor_ADD = New frmFacturasProveedor_ADD()
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
        If Modo = Globals.ModoParaFormas.Seleccion Then
            FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        FacturaRecibida = N_FacturasRecibidasDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmFacturasProveedor_ADD = New frmFacturasProveedor_ADD()
        frm.ID_FacturaRecibida = FacturaRecibida.ID_FacturaRecibida
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
            FacturaRecibida.Delete()
            Me.N_FacturasRecibidas_ResumenBindingSource.EndEdit()
            CalculaTotal()
        End If
    End Sub
End Class