Imports centro_medico
Public Class frmPaciente_ReportePersonalizados

    Public idPaciente As Integer = 888
    Dim context As CMLinqDataContext

    Private Sub frmPaciente_ReportePersonalizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatos()
        
    End Sub

    Private Sub CargaDatos()
        Dim idSeccion As Integer = 1
        context = New CMLinqDataContext()

        ReportesPersonalizadoBindingSource.DataSource = (From r In context.ReportesPersonalizados _
                                                         Where r.Seccion = idSeccion _
                                                         Select r)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Dim frm As New frmPacientes_ReportesPersonalizados_ADD()
        'frm.ReportesPersonalizadoBindingSource.DataSource = Me.ReportesPersonalizadoBindingSource.DataSource

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.ReportesPersonalizados, frm.Reporte.FileName, frm.Reporte.IDReporte.ToString(), frm.Reporte.Descripcion)
            CargaDatos()
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        btnDelete.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick

        Dim reporte As ReportesPersonalizado = GridEX1.SelectedItems(0).GetRow().DataRow

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource()
        ds.Name = "centro_medico_PACIENTE" ' reporte.DataSourceName

        Dim context As New CMLinqDataContext()

        Dim lista As List(Of PACIENTE) = (From p In context.PACIENTEs Where p.CPACIENTE = idPaciente).ToList()

        ds.Value = New List(Of WRAPPER_PACIENTE)
        ds.Value.Add(New WRAPPER_PACIENTE(lista(0)))

        Dim path As String
        If IO.File.Exists(Globales.Configuracion.impresionfilesdirectory & "\" & reporte.FileName) Then
            path = Globales.Configuracion.impresionfilesdirectory
        Else
            path = Application.StartupPath & "\rdlc\default"
        End If
        UI.Reportes.ReportesManager.ImprimeDePath(path & "\" & reporte.FileName, "Ficha Paciente", {ds})


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                Dim reporte As ReportesPersonalizado = GridEX1.SelectedItems(0).GetRow().DataRow
                context.ReportesPersonalizados.DeleteOnSubmit(reporte)
                context.SubmitChanges()
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.ReportesPersonalizados, reporte.FileName, reporte.IDReporte.ToString(), reporte.Descripcion)
                CargaDatos()
            End If
        End If

    End Sub

    
End Class
