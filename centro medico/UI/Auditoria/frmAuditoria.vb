Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmAuditoria



    Private Sub frmAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fechaini As New Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0)
        Dim fechafin As Date = fechaini.AddHours(23).AddMinutes(59)
        dtpDesde.Value = fechaini
        dtpHasta.Value = fechafin
        'Filtros
        'Dim locaciones = From l In RoleManager.Items Select l

        For Each value As RoleManager.Items In [Enum].GetValues(GetType(RoleManager.Items))
            GridEX1.RootTable.Columns("eLocacion").ValueList.Add(value, value.ToString())
        Next
        GridEX1.RootTable.Columns("eLocacion").ValueList.Sort()

        For Each value As Globales.AuditoriaInfo.Accion In [Enum].GetValues(GetType(Globales.AuditoriaInfo.Accion))
            GridEX1.RootTable.Columns("eAccion").ValueList.Add(value, value.ToString())
        Next


    End Sub

    Private Sub CargarAuditorias()
        Dim context As New CMLinqDataContext()

        If dtpDesde.Checked Then
            If dtpHasta.Checked Then
                GridEX1.DataSource = (From a In context.Auditorias _
                                      Where a.FechaHora >= dtpDesde.Value And a.FechaHora <= dtpHasta.Value _
                                      Order By a.FechaHora Descending Select a).ToList()
            Else
                GridEX1.DataSource = (From a In context.Auditorias _
                                      Where a.FechaHora >= dtpDesde.Value
                                      Order By a.FechaHora Descending Select a).ToList()
            End If
        Else
            If dtpHasta.Checked Then
                GridEX1.DataSource = (From a In context.Auditorias _
                                      Where a.FechaHora <= dtpHasta.Value _
                                      Order By a.FechaHora Descending Select a).ToList()
            End If
        End If
        Filtrar()
    End Sub

    Private Sub tstFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarAuditorias()
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()
        'If Not Me.IsHandleCreated Then
        '    Return
        'End If

        'Dim condition As New GridEXFilterCondition()

        ''Dim filtros As New List(Of String)

        'If Not Me.IsHandleCreated Then
        '    Return
        'End If

        'If dtpDesde.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FechaHora"), ConditionOperator.GreaterThanOrEqualTo, New Date(dtpDesde.Value.Year, dtpDesde.Value.Month, dtpDesde.Value.Day, 0, 0, 0).ToShortDateString()))
        'End If

        'If dtpHasta.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FechaHora"), ConditionOperator.LessThanOrEqualTo, New Date(dtpHasta.Value.Year, dtpHasta.Value.Month, dtpHasta.Value.Day, 23, 59, 59).ToShortDateString()))
        'End If

        'If Not chb_importe.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("Importe"), ConditionOperator.GreaterThan, 0))
        'Else
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("Importe"), ConditionOperator.GreaterThanOrEqualTo, 0))
        'End If

        ''If ID_Proceso <> -1 Then
        ''    'filtros.Add(" ID_Proceso=" & ID_Proceso)
        ''    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))
        ''End If

        ''condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))

        'If CtrlPaciente1.ID_PACIENTE.HasValue Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPACIENTE"), ConditionOperator.Equal, CtrlPaciente1.ID_PACIENTE))
        'End If


        'If CtrlMutua1.ID_Mutuas.HasValue Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.Equal, CtrlMutua1.ID_Mutuas.Value))
        'End If

        'If CtrlMedico1.ID_Medico.HasValue Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFMEDICO"), ConditionOperator.Equal, CtrlMedico1.ID_Medico.Value))
        'End If

        'If rb_cobradas.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "S"))
        'End If

        'If rb_sincobrar.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "N"))
        '    condition.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "N"))
        'End If


        'If rb_atendidas.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), ConditionOperator.Equal, "S"))
        'End If

        'If rb_noatendidas.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), ConditionOperator.Equal, "N"))
        'End If

        ''Facturacion

        'If rb_Facturadas.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.GreaterThan, 0))
        'End If

        'If rb_NoFacturadas.Checked Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.IsNull, Nothing))
        '    condition.AddCondition(LogicalOperator.Or, New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.Equal, 0))
        'End If




        'If Not CtrlConceptoFacturable1.ID_ConceptosFra Is Nothing Then
        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("RefConcepto"), ConditionOperator.Equal, CtrlConceptoFacturable1.ID_ConceptosFra))
        'End If

        'If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
        '    condition.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFORMAPAGO"), ConditionOperator.Equal, CtrlFormaPago21.ID_FORMASPAGO))
        'End If



        'Try
        '    GridEX1.RootTable.FilterCondition = condition
        '    'GridEX1.Update()

        'Catch ex As Exception
        '    Dim m As String = ex.Message
        'End Try
        'GridEX1.FilterRow.

    End Sub
#End Region

    Private Sub tstImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstImprimir.Click

        Dim list As New List(Of Object)

        For Each row As GridEXRow In GridEX1.GetRows()
            If row.IsVisible And row.RowType = RowType.Record Then
                Dim audit As Auditoria = row.DataRow

                Dim obj = New With {.CodigoDocumento = audit.CodigoDocumento, _
                                   .DetallesDocumento = audit.DetallesDocumento, _
                                   .eAccion = [Enum].Parse(GetType(Globales.AuditoriaInfo.Accion), audit.eAccion.ToString()), _
                                   .eLocacion = [Enum].Parse(GetType(RoleManager.Items), audit.eLocacion.ToString()), _
                                   .FechaHora = audit.FechaHora, _
                                   .idLog = audit.idLog, _
                                   .idUsuario = audit.idUsuario, _
                                   .loginUsuario = audit.loginUsuario,
                                   .NombreUsuario = audit.NombreUsuario, _
                                   .TipoDocumento = audit.TipoDocumento}
                list.Add(obj)
            End If
        Next

        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
        rpt.Name = "centro_medico_Auditoria"
        rpt.Value = list

        UI.Reportes.ReportesManager.Imprime("AuditoriasListado.rdlc", {rpt})

    End Sub

    Private Sub tstVaciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MessageBox.Show("¿Desea vaciar el registro?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, " DELETE FROM Auditoria", Nothing)

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Auditorias, "VACIAR REGISTRO!!", "Registros Auditorias", "")
            tstFiltrar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged
        CargarAuditorias()
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        CargarAuditorias()
    End Sub

    Private Sub dtpDesde_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpDesde.MouseUp
        CargarAuditorias()
    End Sub

    Private Sub dtpHasta_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpHasta.MouseUp
        CargarAuditorias()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        CargarAuditorias()
    End Sub

    Dim ts As System.Threading.ThreadStart
    Dim thread As System.Threading.Thread
    Dim filetoExport As String
    Private Sub tstExportar_Click(sender As System.Object, e As System.EventArgs) Handles tstExportar.Click

        Dim frm As New SaveFileDialog()
        frm.Filter = "*.xls|*.xls"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            filetoExport = frm.FileName
            SetEnabled(False)
            lnkCancelar.Enabled = True
            pnl_Loading.Enabled = True
            ts = New System.Threading.ThreadStart(AddressOf ExportToExcel)
            thread = New System.Threading.Thread(ts)
            thread.Start()

            'Dim  writer  as New System.IO.BinaryWriter(
            'g.Export(
        End If
    End Sub

    Private Sub ExportToExcel()
        Dim g As New Janus.Windows.GridEX.Export.GridEXExporter()
        'GridEX1.RootTable.ex()
        g.GridEX = GridEX1
        g.ExportMode = ExportMode.AllRows

        Try
            Dim stream As New System.IO.FileStream(filetoExport, IO.FileMode.Create, IO.FileAccess.ReadWrite)
            g.Export(stream)
            stream.Close()
            SetEnabled(True)

        Catch ex As Exception
            If TypeOf (ex) Is System.Threading.ThreadAbortException Then
                MessageBox.Show("Cancelado por el usuario")
            Else
                MessageBox.Show("Error exportando:" & ex.Message)
            End If

        Finally
            SetEnabled(True)
        End Try

    End Sub


    Delegate Sub MyDelegateEnabled(ByRef myControl As Control, ByVal enabled As Boolean)
    Delegate Sub MyDelegateVisible(ByRef myControl As Control, ByVal visible As Boolean)


#Region "Public Sub SetEnabled(ByVal enabled As Boolean)"
    Public Sub SetEnabled(ByVal enabled As Boolean)
        Try
            'pnl_Loading.Visible = Not enabled
            Dim myArray(1) As Object

            myArray(1) = enabled

            Dim myArray2(1) As Object
            myArray2(0) = pnl_Loading
            myArray2(1) = Not enabled

            pnl_Loading.BeginInvoke(New MyDelegateVisible(AddressOf SetVisibleInvoked), myArray2)



            For Each control As Control In Me.Controls
                myArray(0) = control
                control.BeginInvoke(New MyDelegateEnabled(AddressOf SetEnabledInvoked), myArray)
                'control.Enabled = enabled
            Next

            myArray(0) = pnl_Loading
            pnl_Loading.BeginInvoke(New MyDelegateEnabled(AddressOf SetEnabledInvoked), myArray)


            myArray(0) = lnkCancelar
            lnkCancelar.BeginInvoke(New MyDelegateEnabled(AddressOf SetEnabledInvoked), myArray)
            'pnl_Loading.Enabled = Not enabled
            'lnkCancelar.Enabled = Not enabled
        Catch ex As Exception
        End Try
    End Sub
#End Region


    Private Sub SetEnabledInvoked(ByRef control As Control, ByVal enabled As Boolean)
        control.Enabled = enabled
    End Sub

    Private Sub SetVisibleInvoked(ByRef control As Control, ByVal visible As Boolean)
        control.Visible = visible
    End Sub





#Region "Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked"
    Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked
        Try
            thread.Abort()
            SetEnabled(True)
        Catch ex As Exception
            SetEnabled(True)
        Finally
        End Try
    End Sub
#End Region

    Private Sub VaciarIntervaloSeleccionadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VaciarIntervaloSeleccionadoToolStripMenuItem.Click
        If MessageBox.Show("¿Desea vaciar los registros mostrados?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("¿Esta Ud seguro? Esta acción no se podra deshacer", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                For Each row As GridEXRow In GridEX1.GetRows()
                    Dim auditoria As Auditoria = row.DataRow
                    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, " DELETE FROM Auditoria WHERE idLog=" & auditoria.idLog, Nothing)
                Next
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Auditorias, "VACIAR REGISTRO!!", "Registros Auditorias", "")
                tstFiltrar_Click(Nothing, Nothing)

            End If
        End If


    End Sub

    Private Sub VaciarloTodoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VaciarloTodoToolStripMenuItem.Click
        If MessageBox.Show("¿Desea vaciar el registro?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("¿Esta Ud seguro? Esta acción no se podra deshacer", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, " DELETE FROM Auditoria", Nothing)
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Auditorias, "VACIAR REGISTRO!!", "Registros Auditorias", "")
                tstFiltrar_Click(Nothing, Nothing)
            End If

        End If
    End Sub
End Class