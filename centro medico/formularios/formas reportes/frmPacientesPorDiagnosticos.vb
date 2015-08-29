Imports Microsoft.ApplicationBlocks.Data
Imports centro_medico.UI.Reportes

Public Class frmPacientesPorDiagnosticos

    Private Sub frmPacientesPorDiagnosticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.DIAGNOSTICOS' table. You can move, or remove it, as needed.
        Me.DIAGNOSTICOSTableAdapter.Fill(Me.CMDataSet.DIAGNOSTICOS)

    End Sub
    Private Sub Filtra()

        Dim dtable As New DataTable

        Dim datos As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim fechaini As Date
        Dim fechafin As Date

        If Me.chkFiltroFechas.Checked Then
            fechaini = Me.dtpDesde.Value.Date
            fechafin = Me.dtpHasta.Value.Date.AddDays(1).AddMinutes(-1)
        Else
            fechaini = New Date(1900, 1, 1, 0, 0, 0)
            fechafin = Now
        End If
        If Me.chkFiltroDiagnostico.Checked Then
            'Recorrer todos los diagnosticos
            If lst_Diagnosticos.Items.Count = 0 And Me.cbmDiagnosticos.SelectedIndex > -1 Then
                dtable = Me.RptPacientesPorDiagnosticoTableAdapter.GetDataPacientesPorDiagnostico(Me.cbmDiagnosticos.SelectedValue, fechaini, fechafin)
            Else
                If lst_Diagnosticos.Items.Count > 0 Then
                    For Each item As ListViewItem In lst_Diagnosticos.Items
                        Dim diagnostico As CMDataSet.DIAGNOSTICOSRow = item.Tag
                        'Unir todas las tablasadmin
                        dtable.Merge(Me.RptPacientesPorDiagnosticoTableAdapter.GetDataPacientesPorDiagnostico(diagnostico.IDDIAGNOSTICO, fechaini, fechafin))
                    Next
                End If
            End If
        Else
            dtable = Me.RptPacientesPorDiagnosticoTableAdapter.GetDataByTodosPacientesPorDiagnostico(fechaini, fechafin)
        End If

        If chk_DiagnosticoPorTermino.Checked Then
            If txt_FiltroDiagnostico.Text.Trim().Length > 0 Then

                If dtable.Rows.Count = 0 Then
                    'Solo esta seleccionada la busqueda por termino
                    dtable = RptPacientesPorDiagnosticoTableAdapter.GetDataByTodosPacientesPorDiagnostico(fechafin, fechaini)
                End If
                Dim termino As String = txt_FiltroDiagnostico.Text.Trim().Split(New Char() {" "})(0)
                dtable.DefaultView.RowFilter = " DIAGNOSTICO LIKE '%" & termino & "%'"
                dtable.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
                dtable = dtable.DefaultView.ToTable()
            End If

        End If

        'Ordenar

        If chk_OrdenarDiagnostico.Checked Then
            dtable.DefaultView.Sort = "DIAGNOSTICO ASC"
            dtable.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
            dtable = dtable.DefaultView.ToTable()
        End If



        'If chk_OrdenarFecha.Checked Then
        '    dtable.DefaultView.Sort = "FECHA ASC"
        '    dtable.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        '    dtable = dtable.DefaultView.ToTable()
        'End If


        datos.Name = "CMDataSet_rptPacientesPorDiagnostico"
        datos.Value = dtable

        UI.Reportes.ReportesManager.Imprime("PacientesPorDiagnostico.rdlc", {datos})

    End Sub

    Private Sub btFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFiltrar.Click
        Me.Filtra()
    End Sub

    Private Function Filtrar(ByRef dw As DataView, ByVal filter As String) As Object
        Try
            dw.RowFilter = filter
            dw.RowStateFilter = DataViewRowState.CurrentRows
            Return dw
        Catch ex As Exception
            Dim a As Integer
        End Try
    End Function



    Private Sub pb_AddDiagnostico_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_AddDiagnostico.Click

        If cbmDiagnosticos.SelectedIndex > -1 Then
            Dim row As CMDataSet.DIAGNOSTICOSRow = cbmDiagnosticos.SelectedItem.Row
            Dim item As ListViewItem = New ListViewItem(row.DIAGNOSTICO)
            item.Name = row.DIAGNOSTICO
            item.Tag = row
            If Not lst_Diagnosticos.Items.ContainsKey(item.Name) Then
                lst_Diagnosticos.Items.Add(item)
            End If
        End If
    End Sub

    Private Sub cbmDiagnosticos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmDiagnosticos.SelectedIndexChanged
        pb_AddDiagnostico.Enabled = cbmDiagnosticos.SelectedIndex > -1

    End Sub

    Private Sub lst_Diagnosticos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Diagnosticos.SelectedIndexChanged
        pb_EliminarDiagnostico.Enabled = lst_Diagnosticos.SelectedIndices.Count > 0
    End Sub

    Private Sub chkFiltroDiagnostico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroDiagnostico.CheckedChanged
        groupDiagnosticos.Enabled = chkFiltroDiagnostico.Checked
    End Sub

    Private Sub pb_EliminarDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_EliminarDiagnostico.Click
        lst_Diagnosticos.SelectedItems(0).Remove()
    End Sub
End Class