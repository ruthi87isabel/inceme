Imports centro_medico.UI.Reportes

Public Class frmListadoEntregas

    Public IdPaciente As Integer = 1
    Dim context As CMLinqDataContext

    Private Sub frmListadoEntregas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        context = New CMLinqDataContext()
        PagosPacienteBindingSource.DataSource = (From p In context.PagosPacientes Where p.IDPaciente = IdPaciente Select p).ToList()
    End Sub

    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick

        Dim pago As PagosPaciente = GridEX1.SelectedItems(0).GetRow().DataRow

        Dim rptDS_PagosPacientes As New Microsoft.Reporting.WinForms.ReportDataSource()
        rptDS_PagosPacientes.Name = "centro_medico_PagosPaciente"

        Dim pagos As New List(Of WRAPPER_PagosPaciente)
        pagos.Add(New WRAPPER_PagosPaciente(pago))
        rptDS_PagosPacientes.Value = pagos


        Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = IdPaciente Select p).SingleOrDefault()


        Dim parametros(3) As Microsoft.Reporting.WinForms.ReportParameter
        parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("paramNombreClinica", Globales.Configuracion.nombrecomercial)
        parametros(1) = New Microsoft.Reporting.WinForms.ReportParameter("paramDireccionClinica", Globales.Configuracion.domicilio & ", " & Globales.Configuracion.localidad)
        parametros(2) = New Microsoft.Reporting.WinForms.ReportParameter("paramTelefonoClinica", Globales.Configuracion.Tlfno1 & ", Email:" & Globales.Configuracion.Email)
        parametros(3) = New Microsoft.Reporting.WinForms.ReportParameter("paramNomPaciente", _
                                                                         paciente.NOMBRE & " " & paciente.APELLIDO1 & " " & paciente.APELLIDO2)


        UI.Reportes.ReportesManager.Imprime("EntregaJustificante.rdlc", {rptDS_PagosPacientes}, parametros)



    End Sub
End Class