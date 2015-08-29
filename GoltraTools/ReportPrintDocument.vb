
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports System.Collections.Generic
Imports System.Collections.Specialized

Namespace PrintReport
    ''' <summary>
    ''' The ReportPrintDocument will print all of the pages of a ServerReport or LocalReport.
    ''' The pages are rendered when the print document is constructed.  Once constructed,
    ''' call Print() on this class to begin printing.
    ''' </summary>
    Public Class ReportPrintDocument
        Inherits PrintDocument
        Private m_pageSettings As PageSettings
        Private m_currentPage As Integer
        Public m_pages As New List(Of Stream)()

        Public Sub New(ByVal serverReport As ServerReport)
            Me.New(DirectCast(serverReport, Report))
            RenderAllServerReportPages(serverReport)
        End Sub

        Public Sub New(ByVal localReport As LocalReport)
            Me.New(DirectCast(localReport, Report))
            RenderAllLocalReportPages(localReport)
        End Sub

        Private Sub New(ByVal report As Report)
            Try
                ' Set the page settings to the default defined in the report
                Dim reportPageSettings As ReportPageSettings = report.GetDefaultPageSettings()

                ' The page settings object will use the default printer unless
                ' PageSettings.PrinterSettings is changed.  This assumes there
                ' is a default printer.
                m_pageSettings = New PageSettings()
                m_pageSettings.PaperSize = reportPageSettings.PaperSize
                m_pageSettings.Margins = reportPageSettings.Margins
            Catch ex As exception
                msgbox(ex.toString())
            End Try
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)

            If disposing Then
                For Each s As Stream In m_pages
                    s.Dispose()
                Next

                m_pages.Clear()
            End If
        End Sub

        Protected Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
            MyBase.OnBeginPrint(e)

            m_currentPage = 0
        End Sub

        Protected Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
            MyBase.OnPrintPage(e)

            Dim pageToPrint As Stream = m_pages(m_currentPage)
            pageToPrint.Position = 0

            ' Load each page into a Metafile to draw it.
            Using pageMetaFile As New Metafile(pageToPrint)
                Dim adjustedRect As New Rectangle(e.PageBounds.Left - CInt(Math.Truncate(e.PageSettings.HardMarginX)), e.PageBounds.Top - CInt(Math.Truncate(e.PageSettings.HardMarginY)), e.PageBounds.Width, e.PageBounds.Height)

                ' Draw a white background for the report
                e.Graphics.FillRectangle(Brushes.White, adjustedRect)

                ' Draw the report content
                e.Graphics.DrawImage(pageMetaFile, adjustedRect)

                ' Prepare for next page.  Make sure we haven't hit the end.
                m_currentPage += 1
                e.HasMorePages = m_currentPage < m_pages.Count
            End Using
        End Sub

        Protected Overrides Sub OnQueryPageSettings(ByVal e As QueryPageSettingsEventArgs)
            e.PageSettings = DirectCast(m_pageSettings.Clone(), PageSettings)
        End Sub

        Private Sub RenderAllServerReportPages(ByVal serverReport As ServerReport)
            Dim deviceInfo As String = CreateEMFDeviceInfo()

            ' Generating Image renderer pages one at a time can be expensive.  In order
            ' to generate page 2, the server would need to recalculate page 1 and throw it
            ' away.  Using PersistStreams causes the server to generate all the pages in
            ' the background but return as soon as page 1 is complete.
            Dim firstPageParameters As New NameValueCollection()
            firstPageParameters.Add("rs:PersistStreams", "True")

            ' GetNextStream returns the next page in the sequence from the background process
            ' started by PersistStreams.
            Dim nonFirstPageParameters As New NameValueCollection()
            nonFirstPageParameters.Add("rs:GetNextStream", "True")

            Dim mimeType As String = Nothing
            Dim fileExtension As String = Nothing
            Dim pageStream As Stream = serverReport.Render("IMAGE", deviceInfo, firstPageParameters, mimeType, fileExtension)

            ' The server returns an empty stream when moving beyond the last page.
            While pageStream.Length > 0
                m_pages.Add(pageStream)

                pageStream = serverReport.Render("IMAGE", deviceInfo, nonFirstPageParameters, mimeType, fileExtension)
            End While
        End Sub

        Private Sub RenderAllLocalReportPages(ByVal localReport As LocalReport)
            Dim deviceInfo As String = CreateEMFDeviceInfo()

            Dim warnings As Warning() = Nothing
            localReport.Render("IMAGE", deviceInfo, AddressOf LocalReportCreateStreamCallback, warnings)
        End Sub

        Private Function LocalReportCreateStreamCallback(ByVal name As String, ByVal extension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
            Dim stream As New MemoryStream()
            m_pages.Add(stream)

            Return stream
        End Function

        Private Function CreateEMFDeviceInfo() As String
            Dim paperSize As PaperSize = m_pageSettings.PaperSize
            Dim margins As Margins = m_pageSettings.Margins

            ' The device info string defines the page range to print as well as the size of the page.
            ' A start and end page of 0 means generate all pages.
            Return String.Format(CultureInfo.InvariantCulture, "<DeviceInfo><OutputFormat>emf</OutputFormat><StartPage>0</StartPage><EndPage>0</EndPage><MarginTop>{0}</MarginTop><MarginLeft>{1}</MarginLeft><MarginRight>{2}</MarginRight><MarginBottom>{3}</MarginBottom><PageHeight>{4}</PageHeight><PageWidth>{5}</PageWidth></DeviceInfo>", ToInches(margins.Top), ToInches(margins.Left), ToInches(margins.Right), ToInches(margins.Bottom), _
             ToInches(paperSize.Height), ToInches(paperSize.Width))
        End Function

        Private Shared Function ToInches(ByVal hundrethsOfInch As Integer) As String
            Dim inches As Double = hundrethsOfInch / 100.0
            Return inches.ToString(CultureInfo.InvariantCulture) & "in"
        End Function
    End Class
End Namespace
