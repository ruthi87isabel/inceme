Imports Microsoft.Reporting.WinForms

Public Class form_mostrar_reporte_empresas

    Sub New(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)

        Me.ReportViewer1.LocalReport.ReportPath = Globales.Reportes("EmpresasListado.rdlc").Fichero
        ReportViewer1.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        ReportViewer1.LocalReport.EnableExternalImages = True

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class