Imports Microsoft.Reporting.WinForms

Public Class form_mostrar_reporte_alarmas


    Sub New(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ALARMASTableAdapter.FillAlarmas(Me.CMDataSet.ALARMAS, aTable, aWhere, aOrder)
        ReportViewer.LocalReport.ReportPath = Globales.Reportes("AlarmasListado.rdlc").Fichero
        ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        ReportViewer.LocalReport.EnableExternalImages = True
        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer.RefreshReport()

      
    End Sub
End Class