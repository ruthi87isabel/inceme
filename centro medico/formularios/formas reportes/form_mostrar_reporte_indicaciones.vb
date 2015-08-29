Imports Microsoft.Reporting.WinForms

Public Class form_mostrar_reporte_indicaciones

    Sub New(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.INDICACIONESTableAdapter.FillIndicaciones(Me.CMDataSet.INDICACIONES, aTable, aWhere, aOrder)
        Me.ReportViewer.LocalReport.ReportPath = Globales.Reportes("IndicacionesListado.rdlc").Fichero
        Me.ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        Me.ReportViewer.LocalReport.EnableExternalImages = True

        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer.RefreshReport()
    End Sub
End Class