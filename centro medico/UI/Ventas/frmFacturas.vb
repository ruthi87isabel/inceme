Imports centro_medico.UI.Reportes

Public Class frmFacturasMedicas


    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Factura As CMDataSet.N_Factura_ResumenRow


    Private Sub frmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If

        Me.tst_Eliminar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura
        Me.NewToolStripButton.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura
        Me.tst_Editar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura

        TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.N_Factura_ResumenTableAdapter.Fill(Me.CMDataSet.N_Factura_Resumen)

        cmb_Estado.Items.Add("Todos")
        For Each o As Object In [Enum].GetValues(GetType(Globales.Facturas_Estado))
            cmb_Estado.Items.Add(o)
        Next
        cmb_Estado.SelectedIndex = 0

        CalculaTotal(String.Empty)

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmFacturas_ADD = New frmFacturas_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Factura_ResumenTableAdapter.Fill(Me.CMDataSet.N_Factura_Resumen)
            Me.N_Factura_ResumenBindingSource.MoveLast()
            CalculaTotal(String.Empty)
        End If
        GC.Collect()
    End Sub

    Private Sub N_Facturas_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Factura_ResumenDataGridView.SelectionChanged
        tst_Editar.Enabled = N_Factura_ResumenDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Enabled = N_Factura_ResumenDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura
        If N_Factura_ResumenDataGridView.SelectedRows.Count > 0 Then
            Factura = N_Factura_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            tst_TotalSeleccionado.Text = "Total seleccionado: " & Factura.Total
        End If
    End Sub

    Private Sub CalculaTotal(ByVal filtro As String)
        If CMDataSet.N_Factura_Resumen.Count > 0 Then
            Dim total As Object = CMDataSet.N_Factura_Resumen.Compute("SUM(Total)", filtro)
            If Not total Is DBNull.Value Then
                tst_Total.Text = "Total: " & CType(total, Double).ToString("C2")
            Else
                tst_Total.Text = "Total: 0.0"
            End If
        Else
            tst_Total.Text = "Total: 0.0"
        End If

    End Sub

    Private Sub N_Factura_ResumenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Factura_ResumenDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Factura = N_Factura_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) > RoleManager.TipoPermisos.Lectura Then
                tst_Editar_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Factura = N_Factura_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmFacturas_ADD = New frmFacturas_ADD()
        frm.ID_Factura = Factura.ID_Factura
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_Factura_ResumenDataGridView.SelectedRows(0).Index
            Me.N_Factura_ResumenTableAdapter.Fill(Me.CMDataSet.N_Factura_Resumen)
            'MuestraTotales()
            N_Factura_ResumenDataGridView.Rows(pos).Selected = True
            CalculaTotal(String.Empty)
        End If
        GC.Collect()
    End Sub

    Private Sub N_Factura_ResumenDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Factura_ResumenDataGridView.CellFormatting

        If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
            If Not e.Value Is DBNull.Value Then
                e.Value = CType(e.Value, Globales.Facturas_Estado)
            End If

        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Factura = N_Factura_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As CMDataSetTableAdapters.N_FacturaTableAdapter = New CMDataSetTableAdapters.N_FacturaTableAdapter()
        Dim n As Integer = adapter.DeleteQuery(Factura.ID_Factura)
        If n > 0 Then
            Factura.Delete()
            Me.N_Factura_ResumenBindingSource.EndEdit()
            CalculaTotal(String.Empty)
        End If
        GC.Collect()
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()
        Dim filtros As New List(Of String)

        If tst_Nombre.Text.Length > 0 Then
            filtros.Add("NombreCompleto like '" & tst_Nombre.Text & "%'")
        End If

        If dtp_FEMISION_fi.Checked Then
            filtros.Add("Fecha >= '" & dtp_FEMISION_fi.Value.ToShortDateString() & "'")
        End If

        If dtp_FEMISION_ff.Checked Then
            Dim ff As New Date(dtp_FEMISION_ff.Value.Year, dtp_FEMISION_ff.Value.Month, dtp_FEMISION_ff.Value.Day, 23, 59, 59)
            filtros.Add("Fecha <= '" & ff & "'")
        End If

        'If cmb_Estado.SelectedIndex > 0 Then
        '    filtros.Add(" Estado like '%" & [Enum].GetName(GetType(Globales.Facturas_Estado), cmb_Estado.SelectedItem) & "%'")
        'End If

        If tst_Numero.Text.Length > 0 Then
            filtros.Add("Codigo like '%" & tst_Numero.Text & "%'")
        End If

        If tst_Referencia.Text.Length > 0 Then
            filtros.Add("Referencia like '%" & tst_Referencia.Text & "%'")
        End If

        If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
            filtros.Add("[Forma de Pago] like '" & CtrlFormaPago21.ID_FORMASPAGO & "-" & CtrlFormaPago21.FORMASPAGO.DESCRIPCION & "%'")
        End If

        If rb_pagadas.Checked Then
            filtros.Add("Pagado=1")
        End If

        If rb_sinpagar.Checked Then
            filtros.Add("Pagado=false")
        End If

        Dim filtro = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CMDataSet.N_Factura_Resumen.DefaultView
            dw.RowFilter = filtro
            dw.RowStateFilter = DataViewRowState.CurrentRows
            N_Factura_ResumenDataGridView.DataSource = dw
            N_Factura_ResumenDataGridView.Update()
            'lb_total.Text = dw.Count
            CalculaTotal(filtro)

        Catch ex As Exception
        End Try

    End Sub
#End Region

#Region "Private Sub CalculaTotales()"
    Private Sub CalculaTotales(ByVal fil As String)
        'Dim total_medicos As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe médico])", fil)
        'Dim total_clinica As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe clínica])", fil)
        'Dim total As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe Total])", fil)

        'If Not total_medicos Is DBNull.Value Then
        '    lb_medico.Text = CType(total_medicos, Double).ToString("C2")
        'Else
        '    lb_medico.Text = "0"
        'End If

        'If Not total_clinica Is DBNull.Value Then
        '    lb_clinica.Text = CType(total_clinica, Double).ToString("C2")
        'Else
        '    lb_clinica.Text = "0"
        'End If

        'If Not total Is DBNull.Value Then
        '    lb_total.Text = CType(total, Double).ToString("C2")
        'Else
        '    lb_total.Text = "0"
        'End If
    End Sub
#End Region



    Private Sub tst_ButtonFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Filtrar()
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource

        ds.Name = "CMDataSet_N_Factura_Resumen"
        ds.Value = N_Factura_ResumenDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("TPVFacturasVentasListado.rdlc", {ds})

    End Sub


End Class