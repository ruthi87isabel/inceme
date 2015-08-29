Imports Microsoft.ApplicationBlocks.Data
Imports centro_medico.UI.Reportes

Public Class frmPacientesPorDerivaciones
    Private Sub frmPacientesPorDervaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.DERIVACIONES_DESTINOS' Puede moverla o quitarla según sea necesario.
        Me.DERIVACIONES_DESTINOSTableAdapter.Fill(Me.CMDataSet.DERIVACIONES_DESTINOS)
        Me.DERIVACIONESTableAdapter.Fill(Me.CMDataSet.DERIVACIONES)
    End Sub

    Private Sub Filtra()
        Dim dtable As DataTable
        Dim datos As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim fechaini As Date
        Dim fechafin As Date

        If Me.chkFiltroFechas.Checked Then
            fechaini = Me.dtpDesde.Value.Date
            fechafin = Me.dtpHasta.Value.Date.AddDays(1).AddMinutes(-1)
        Else
            fechaini = CDate("01/01/1900")
            fechafin = Now
        End If
        If Me.chkFiltroDiagnostico.Checked Then
            dtable = Me.RptPacientesPorDerivacionTableAdapter.GetDataPacientesPorDerivacion(fechaini, fechafin, Me.cbmDerivaciones.SelectedValue)
        Else
            dtable = Me.RptPacientesPorDerivacionTableAdapter.GetDataByTodosPacintesPorDerivacion(fechaini, fechafin)
        End If

        If chk_OrdenarDiagnostico.Checked Then
            dtable.DefaultView.Sort = "DESTINO ASC"
            dtable.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
            dtable = dtable.DefaultView.ToTable()
        End If

        If chk_OrdenarFecha.Checked Then
            If rb_FechaAsc.Checked Then
                dtable.DefaultView.Sort = "FECHA ASC"
            Else
                dtable.DefaultView.Sort = "FECHA DESC"
            End If

            dtable.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
            dtable = dtable.DefaultView.ToTable()
        End If

        datos.Name = "CMDataSet_rptPacientesPorDerivacion"
        datos.Value = dtable

        UI.Reportes.ReportesManager.Imprime("PacientesPorDerivaciones.rdlc", {datos})

       
    End Sub

    Private Sub btFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFiltrar.Click
        Me.Filtra()
    End Sub


End Class