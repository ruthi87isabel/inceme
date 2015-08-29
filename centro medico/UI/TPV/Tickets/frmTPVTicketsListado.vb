Imports Janus.Windows
Imports Janus.Windows.GridEX
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class frmTPVTicketsListado

    Private Context As CMLinqDataContext
    Dim tickets As List(Of N_Ticket)
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Ticket As N_Ticket


    Private Sub frmTPVTicketsListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_FC_Ini.Value = Date.Now.AddDays(-30)
    End Sub

    Private Sub frmTPVTicketsListado_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        Context = New CMLinqDataContext

        Dim fi As Date = New Date(dt_FC_Ini.Value.Year, dt_FC_Ini.Value.Month, dt_FC_Ini.Value.Day, 0, 0, 0)
        Dim ff As Date = New Date(dt_FC_Fin.Value.Year, dt_FC_Fin.Value.Month, dt_FC_Fin.Value.Day, 23, 59, 59)


        If chkSolo100primeros.Checked Then
            tickets = (From t In Context.N_Tickets _
                      Where t.Fecha >= fi And ff <= ff
                      Select t).Take(100).ToList()
        Else
            tickets = (From t In Context.N_Tickets _
                      Where t.Fecha >= fi And ff <= ff
                      Select t).ToList()
        End If

        tickets = tickets.Where(Function(o) Not o.Eliminado.HasValue OrElse o.Eliminado = False).ToList()

        If rb_Pagados.Checked Then
            tickets = tickets.Where(Function(o) o.Pagado = True).ToList()
        End If

        If rb_Sinpagar.Checked Then
            tickets = tickets.Where(Function(o) o.Pagado = False).ToList()
        End If

        If dt_FP_Ini.Checked Then
            Dim fpi As Date = New Date(dt_FP_Ini.Value.Year, dt_FP_Ini.Value.Month, dt_FP_Ini.Value.Day, 0, 0, 0)
            tickets = tickets.Where(Function(o) o.FechaPagado >= fpi).ToList()
        End If

        If dt_FP_Fin.Checked Then
            Dim fpf As Date = New Date(dt_FP_Fin.Value.Year, dt_FP_Fin.Value.Month, dt_FP_Fin.Value.Day, 23, 59, 59)
            tickets = tickets.Where(Function(o) o.FechaPagado <= fpf).ToList()
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            tickets = tickets.Where(Function(o) o.ID_Cliente = CtrlPaciente1.ID_PACIENTE.Value).ToList()
        End If

        NTicketBindingSource.DataSource = tickets

    End Sub


    Private Sub bt_Filtrar_Click(sender As Object, e As EventArgs) Handles bt_Filtrar.Click
        CargaDatos()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click

        Dim _ticket As New N_Ticket()
        _ticket.Codigo = Globales.GeneraCodigoAutomatico("N_Ticket", "ID_Ticket", "00000")
        _ticket.Fecha = Date.Now

        Dim _context As New CMLinqDataContext
        _context.N_Tickets.InsertOnSubmit(_ticket)
        _context.SubmitChanges()

        Dim frm As New frmTPVTicketsEditar()
        frm.Nuevo = True
        frm.ID_Ticket = _ticket.ID_Ticket

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            frm.Context.SubmitChanges()
            _ticket = frm.Ticket
            If Not _ticket.PACIENTE Is Nothing Then
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Tickets_Ventas, "Ticket", _ticket.ID_Ticket, "[" & _ticket.Codigo & "] " & "Ticket TPV :" & _ticket.PACIENTE.NombreCompleto)
            End If

            CargaDatos()
        End If

    End Sub

    Private Sub tst_Editar_Click(sender As Object, e As EventArgs) Handles tst_Editar.Click
        If GridEXListado.SelectedItems.Count > 0 And GridEXListado.SelectedItems(0).RowType = RowType.Record Then
            If GridEXListado.SelectedItems(0).GetRow().Parent Is Nothing Then
                Me.Ticket = GridEXListado.SelectedItems(0).GetRow().DataRow
                If Modo = Globales.ModoParaFormas.Edicion Then

                    Dim _cont As New CMLinqDataContext()

                    Dim _ticket As N_Ticket = (From f As N_Ticket In _cont.N_Tickets Where f.ID_Ticket = Ticket.ID_Ticket Select f).SingleOrDefault


                    Dim frm As New frmTPVTicketsEditar()
                    'frm.NTicketBindingSource.DataSource = _ticket
                    frm.ID_Ticket = _ticket.ID_Ticket
                    'frm.Context = _cont

                    If Not _ticket.PACIENTE Is Nothing Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Tickets_Ventas, "Ticket", _ticket.ID_Ticket, "[" & _ticket.Codigo & "] " & "Ticket TPV :" & _ticket.PACIENTE.NombreCompleto)
                    End If

                    If frm.ShowDialog() = DialogResult.OK Then
                        frm.Context.SubmitChanges()
                        CargaDatos()

                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Facturas, "Ticket", Ticket.ID_Ticket, "[" & _ticket.Codigo & "] " & "Ticket TPV :" & _ticket.PACIENTE.NombreCompleto)
                    Else
                        'FACTURABindingSource.ResetCurrentItem()

                        'Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Factura)
                        'GridEXListado.Refresh()
                        CargaDatos()
                    End If
                Else
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub tst_Eliminar_Click(sender As Object, e As EventArgs) Handles tst_Eliminar.Click
                ' comprobar si tiene permiso para borrar.

        If MessageBox.Show("¿Está seguro que desea eliminar este ticket?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            If GridEXListado.SelectedItems.Count > 0 Then
                Dim _t As N_Ticket = GridEXListado.SelectedItems(0).GetRow().DataRow

                If Not _t Is Nothing Then

                    Dim cont As New CMLinqDataContext()
                    Dim _ticket As N_Ticket = (From f In cont.N_Tickets Where f.ID_Ticket = _t.ID_Ticket Select f).SingleOrDefault()

                    If _ticket.Pagado Then
                        MsgBox("No puede eliminar un ticket pagado. Debe quitar el pago previamente", MsgBoxStyle.Exclamation)
                        Return
                    End If

                    _ticket.Eliminado = True
                    'cont.N_Tickets.DeleteOnSubmit(_ticket)
                    cont.SubmitChanges()
                    If Not _ticket.PACIENTE Is Nothing Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Tickets_Ventas, "Ticket", _ticket.ID_Ticket, "[" & _ticket.Codigo & "] " & "Ticket TPV :" & _ticket.PACIENTE.NombreCompleto)
                    End If
                    CargaDatos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Este ticket no puede ser eliminado contacte a su administrador")
        End Try

    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource

        ds.Name = "CM2DataSet_ListadoTickets"
        ds.Value = GridEXListado.DataSource

        UI.Reportes.ReportesManager.Imprime("TPVTicketsListado.rdlc", {ds})

    End Sub

    Private Sub GridEXListado_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXListado.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub GridEXListado_SelectionChanged(sender As Object, e As EventArgs) Handles GridEXListado.SelectionChanged
        tst_Editar.Enabled = GridEXListado.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEXListado.SelectedItems.Count > 0
    End Sub

   
End Class

