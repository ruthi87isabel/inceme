Imports System.Xml.Linq
Imports System.IO

Namespace UI.Reportes
    Public Class ReportesManager


        Private ReadOnly _dictionary As New Dictionary(Of String, ReporteInfo)

        Private _doc As XDocument

        Public Sub Inicia()
            Try
                Dim path As String = Application.StartupPath + "/rdlc/lista.xml"
                If Not File.Exists(path) Then
                    MessageBox.Show("No se encuentra " & path & " no se cargaron los reportes, consulte a su administrador")
                    Return
                End If
                If _dictionary.Count > 0 Then _dictionary.Clear()
                _doc = XDocument.Load(path)
                For Each el As XElement In _doc.<lista>.<reporte>
                    _dictionary.Add(el.Attribute("id").Value,
                                New ReporteInfo With {
                                .ID = el.Attribute("id").Value,
                                .Fichero = el.Attribute("fichero").Value,
                                .Info = el.Attribute("info").Value}
                                )
                Next
            Catch ex As Exception
                MessageBox.Show("Error cargando listado de reportes: " + ex.Message)
            End Try
        End Sub

        Default Public ReadOnly Property Item(ByVal index As String) As ReporteInfo
            Get
                If _dictionary.ContainsKey(index) Then
                    Return _dictionary(index)
                Else
                    Return Nothing
                End If
            End Get
            'Set(ByVal Value As ReporteInfo)

            'End Set
        End Property

        Public ReadOnly Property Length() As Long
            Get
                Return _dictionary.Count
            End Get
        End Property


        'Public Function IEnumerable_GetEnumerator() As IEnumerator(Of ReporteInfo) Implements IEnumerable(Of ReporteInfo).GetEnumerator

        'End Function

        Public Function Listado() As List(Of ReporteInfo)
            Return _dictionary.Values.ToList()
        End Function

        Public Shared Sub Imprime(reporteID As String, datasources() As Microsoft.Reporting.WinForms.ReportDataSource, _
                                               Optional parameters() As Microsoft.Reporting.WinForms.ReportParameter = Nothing)

            Dim reporteInfo As ReporteInfo = Globales.Reportes(reporteID)

            If reporteInfo Is Nothing Then
                MessageBox.Show("La definición del reporte " & reporteID & " no está registrada, se abortará la impresión")
                Return
            End If

            Dim path As String = reporteInfo.Fichero

            If Not File.Exists(path) Then
                MessageBox.Show("El fichero " & path & " no existe, abortada la impresión")
                Return
            End If

            ImprimeDePath(path, reporteInfo.Info, datasources, parameters)

        End Sub

        Shared Sub ImprimeDePath(fullPath As String, Titulo As String, datasources As Microsoft.Reporting.WinForms.ReportDataSource(), Optional parameters() As Microsoft.Reporting.WinForms.ReportParameter = Nothing)

            Dim _print As New frmReportViewer

            _print.ReportViewer.LocalReport.ReportPath = fullPath
            _print.Text = Titulo

            _print.ReportViewer.LocalReport.EnableExternalImages = True
            If Not datasources Is Nothing Then
                For Each ds As Microsoft.Reporting.WinForms.ReportDataSource In datasources
                    _print.ReportViewer.LocalReport.DataSources.Add(ds)
                Next
            End If

            _print.ReportViewer.LocalReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())

            If Not parameters Is Nothing Then

                Dim realParamas As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
                Dim rpt_parameters As Microsoft.Reporting.WinForms.ReportParameterInfoCollection = _print.ReportViewer.LocalReport.GetParameters

                For Each param As Microsoft.Reporting.WinForms.ReportParameter In parameters
                    'Verificar si el reporte contiene dicho paramatro
                    If Not rpt_parameters.Item(param.Name) Is Nothing Then
                        realParamas.Add(param)
                    End If
                Next
                _print.ReportViewer.LocalReport.SetParameters(realParamas.ToArray)
            End If

            _print.ShowDialog()
        End Sub

      

    End Class
End Namespace

