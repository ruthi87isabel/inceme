
Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms

Public Class MultipleReportPrinter

    Implements IDisposable
    Private _mCurrentPageIndex As Integer
    Private _mStreams As IList(Of Stream)
    Private _localReport As LocalReport

    Public Property Impresora() As PrinterSettings


    'Private Function LoadSalesData() As DataTable
    '    ' Create a new DataSet and read sales data file 
    '    ' data.xml into the first DataTable.
    '    Dim dataSet As New DataSet()
    '    dataSet.ReadXml("..\..\data.xml")
    '    Return dataSet.Tables(0)
    'End Function

#Region "Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream"
    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        _mStreams.Add(stream)
        Return stream
    End Function
#End Region

#Region "Private Sub Export(ByVal report As LocalReport)"
    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport)
        
        Dim deviceInfo As String = "<DeviceInfo>" & _
            "<OutputFormat>EMF</OutputFormat>" & _
            "</DeviceInfo>"
        ' MsgBox(report.GetDefaultPageSettings.PaperSize.Width)
        Dim warnings As Warning() = Nothing
        _mStreams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In _mStreams
            stream.Position = 0
        Next
    End Sub
#End Region

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(_mStreams(_mCurrentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
                                          ev.PageBounds.Width, _
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        _mCurrentPageIndex += 1
        ev.HasMorePages = (_mCurrentPageIndex < _mStreams.Count)
    End Sub

    Private Sub Print()
        If _mStreams Is Nothing OrElse _mStreams.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
        Dim printDoc As New PrintDocument()
        printDoc.DocumentName = _localReport.DisplayName
        printDoc.PrinterSettings = Impresora

        'Dim dialog As New PrintDialog()
        'dialog.Document = printDoc

        'If dialog.ShowDialog() = DialogResult.OK Then

        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            _mCurrentPageIndex = 0
            printDoc.Print()
        End If
        'End If



    End Sub

    ' Create a local report for Report.rdlc, load the data,
    ' export the report to an .emf file, and print it.
    Public Sub Run(report As LocalReport)
        _localReport = report
        'Dim report As New LocalReport()
        'report.ReportPath = "..\..\Report.rdlc"
        'report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))
        Export(report)
        Print()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If _mStreams IsNot Nothing Then
            For Each stream As Stream In _mStreams
                stream.Close()
            Next
            _mStreams = Nothing
        End If
    End Sub

End Class

