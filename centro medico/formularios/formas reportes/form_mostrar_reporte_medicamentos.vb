Imports Microsoft.Reporting.WinForms

Public Class form_mostrar_reporte_medicamentos

    Sub New(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.MEDICAMENTOSTableAdapter.FillMedicamentos(Me.CMDataSet.MEDICAMENTOS, aTable, aWhere, aOrder)

        Me.ReportViewer.LocalReport.ReportPath = Globales.Reportes("MedicamentosListado.rdlc").Fichero
        ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        ReportViewer.LocalReport.EnableExternalImages = True

        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer.RefreshReport()
    End Sub
End Class