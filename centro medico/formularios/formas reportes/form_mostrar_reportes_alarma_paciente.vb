Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class form_mostrar_reportes_alarma_paciente


    Sub New(ByVal aIdalarma As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ALARMASTableAdapter.FillAlarmaById(Me.CMDataSet.ALARMAS, aIdalarma)
        'TODO: This line of code loads data into the 'CMDataSet.PACIENTES' table. You can move, or remove it, as needed.
        Me.PACIENTESTableAdapter.FillPacByAlarma(Me.CMDataSet.PACIENTES, aIdalarma)
        Me.ReportViewer1.LocalReport.ReportPath = Globales.Reportes("AlarmasListadoPorPacientes.rdlc").Fichero
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        Me.ReportViewer1.RefreshReport()

        'Dim frmVisor As New frmReportViewer
        'frmVisor.ReportViewer.LocalReport.ReportPath =  Globales.Reportes("AlarmasListadoPorPacientes.rdlc").Fichero
        'frmVisor.ReportViewer.LocalReport.DataSources.Add(dsFactura)
        'frmVisor.ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        'frmVisor.Show()

    End Sub

    Private Sub form_mostrar_reportes_alarma_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class