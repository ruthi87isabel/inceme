Imports Microsoft.Reporting.WinForms

Public Class form_mostrar_reporte_bancos

    Sub New(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        BANCOSTableAdapter.FillBancos(Me.CMDataSet.BANCOS, aTable, aWhere, aOrder)
       
        ReportViewer.LocalReport.ReportPath = Globales.Configuracion.impresionfilesdirectory & "/" & Globales.Reportes("Bancos.rdlc").Fichero
        ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        ReportViewer.LocalReport.EnableExternalImages = True

        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer.RefreshReport()
    End Sub
End Class