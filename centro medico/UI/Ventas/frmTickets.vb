Imports centro_medico.UI.Reportes

Public Class frmTickets
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Ticket As CM2DataSet.ListadoTicketsRow

    Private Sub frmTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If

        Me.tst_Eliminar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura
        Me.NewToolStripButton.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura
        Me.tst_Editar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura

        'TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.ListadoTicketsTableAdapter.Fill(Me.CM2DataSet.ListadoTickets)
        CalculaTotal(String.Empty)

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmTicket = New frmTicket()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.ListadoTicketsTableAdapter.Fill(Me.CM2DataSet.ListadoTickets)
            Me.ListadoTicketsBindingSource.MoveLast()
            CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub N_Tickets_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoTicketsDataGridView.SelectionChanged
        tst_Editar.Enabled = ListadoTicketsDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Enabled = ListadoTicketsDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura
        If ListadoTicketsDataGridView.SelectedRows.Count > 0 Then
            Ticket = ListadoTicketsDataGridView.SelectedRows(0).DataBoundItem.Row
            tst_TotalSeleccionado.Text = "Total seleccionado: " & Ticket.Total.ToString("C2")
        End If
    End Sub

    Private Sub CalculaTotal(ByVal filtro As String)
        If CM2DataSet.ListadoTickets.Count > 0 Then
            Dim total As Object = CM2DataSet.ListadoTickets.Compute("SUM(Total)", filtro)
            If Not total Is DBNull.Value Then
                tst_Total.Text = " Total: " & CType(total, Double).ToString("C2")
            End If
        Else
            tst_Total.Text = " Total: 0"
        End If

    End Sub


    Private Sub ListadoTicketsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoTicketsDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Ticket = ListadoTicketsDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) > RoleManager.TipoPermisos.Lectura Then
                tst_Editar_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Ticket = ListadoTicketsDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmTicket = New frmTicket()
        frm.ID_Ticket = Ticket.ID_Ticket
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = ListadoTicketsDataGridView.SelectedRows(0).Index
            Me.ListadoTicketsTableAdapter.Fill(Me.CM2DataSet.ListadoTickets)
            'MuestraTotales()
            ListadoTicketsDataGridView.Rows(pos).Selected = True
            CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub ListadoTicketsDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles ListadoTicketsDataGridView.CellFormatting



        If ListadoTicketsDataGridView.Rows(e.RowIndex).Cells(PagadoColumn.Index).Value = True Then
            ListadoTicketsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkGreen
            'Color.FromArgb(120, 240, 120)
        Else
            ListadoTicketsDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            ListadoTicketsDataGridView.Rows(e.RowIndex).Cells(ColumnFechaPagado.Index).Value = ""
        End If
        'If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
        '    If Not e.Value Is DBNull.Value Then
        '        e.Value = CType(e.Value, Globals.Tickets_Estado)
        '    End If

        'End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If ListadoTicketsDataGridView.SelectedRows.Count > 0 Then
            Ticket = ListadoTicketsDataGridView.SelectedRows(0).DataBoundItem.Row
            Dim adapter As CMDataSetTableAdapters.N_TicketTableAdapter = New CMDataSetTableAdapters.N_TicketTableAdapter()
            Dim n As Integer = adapter.DeleteQuery(Ticket.ID_Ticket)
            If n > 0 Then
                Ticket.Delete()
                Me.ListadoTicketsBindingSource.EndEdit()
                CalculaTotal(String.Empty)
            End If
        End If
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()
        Dim filtros As New List(Of String)

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            filtros.Add("ID_Cliente=" & CtrlPaciente1.ID_PACIENTE.Value & "")
        End If

        If chk_FechaCreacion.Checked Then
            Dim fechaIni As Date = New Date(dt_FC_Ini.Value.Year, dt_FC_Ini.Value.Month, dt_FC_Ini.Value.Day, 0, 0, 0)
            Dim fechaFin As Date = New Date(dt_FC_Fin.Value.Year, dt_FC_Fin.Value.Month, dt_FC_Fin.Value.Day, 23, 59, 59)

            filtros.Add("Fecha >= '" & fechaIni.ToShortDateString() & "' AND Fecha <='" & fechaFin.ToString() & "'")
        End If

        If chk_FechaPagado.Checked Then
            Dim fechaIni As Date = New Date(dt_FP_Ini.Value.Year, dt_FP_Ini.Value.Month, dt_FP_Ini.Value.Day, 0, 0, 0)
            Dim fechaFin As Date = New Date(dt_FP_Fin.Value.Year, dt_FP_Fin.Value.Month, dt_FP_Fin.Value.Day, 23, 59, 59)
            filtros.Add("FechaPagado >= '" & fechaIni.ToShortDateString() & "' AND FechaPagado <='" & fechaFin.ToString() & "'")
        End If

        If rb_Pagados.Checked Then
            filtros.Add("Pagado = 1")
        End If

        If rb_Sinpagar.Checked Then
            filtros.Add("Pagado = 0")
        End If

        Dim filtro = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CM2DataSet.ListadoTickets.DefaultView
            dw.RowFilter = filtro
            dw.RowStateFilter = DataViewRowState.CurrentRows
            ListadoTicketsDataGridView.DataSource = dw
            ListadoTicketsDataGridView.Update()
            'lb_total.Text = dw.Count
            CalculaTotal(filtro)

        Catch ex As Exception
        End Try
        Me.Refresh()
    End Sub
#End Region

#Region "Private Sub CalculaTotales()"
    Private Sub CalculaTotales(ByVal fil As String)
        'Dim total_medicos As Object = CM2DataSet.ListadoTickets.Compute("Sum([Importe médico])", fil)
        'Dim total_clinica As Object = CM2DataSet.ListadoTickets.Compute("Sum([Importe clínica])", fil)
        'Dim total As Object = CM2DataSet.ListadoTickets.Compute("Sum([Importe Total])", fil)

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


    'Private Sub tst_Nombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Nombre.KeyUp
    '    Filtrar()
    'End Sub

    'Private Sub CtrlFormaPago21_FORMASPAGOeleccionado(ByVal IdFORMASPAGO As System.String, ByVal IsReturnPressed As System.Boolean) Handles CtrlFormaPago21.FORMASPAGOeleccionado
    '    Filtrar()
    'End Sub

    'Private Sub CtrlFormaPago21_FORMASPAGOEliminado(ByVal IdFORMASPAGOAnterior As System.String) Handles CtrlFormaPago21.FORMASPAGOEliminado
    '    CtrlFormaPago21.ID_FORMASPAGO = String.Empty
    '    Filtrar()
    'End Sub

    'Private Sub CtrlFormaPago21_FORMASPAGONoEncontrado() Handles CtrlFormaPago21.FORMASPAGONoEncontrado
    '    Filtrar()
    'End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource

        ds.Name = "CM2DataSet_ListadoTickets"
        ds.Value = ListadoTicketsDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("TPVTicketsListado.rdlc", {ds})

    End Sub

    Private Sub ListadoTicketsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoTicketsDataGridView.CellContentClick

    End Sub

    Private Sub bt_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Filtrar.Click
        Filtrar()
    End Sub


    Private Sub chk_FechaCreacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FechaCreacion.CheckedChanged
        grp_FechaCreacion.Enabled = chk_FechaCreacion.Checked
    End Sub

    Private Sub chk_FechaPagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FechaPagado.CheckedChanged
        grp_FechaPagado.Enabled = chk_FechaPagado.Checked
    End Sub
End Class