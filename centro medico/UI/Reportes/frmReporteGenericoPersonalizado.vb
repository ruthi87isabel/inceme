Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms
Imports System.Collections.ObjectModel

Public Class frmReporteGenericoPersonalizado

    Dim ReportContent As ReportViewer


    Public ReportParameters As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
    Public ReportNamePath As String = Nothing
    Public DataSource As New Microsoft.Reporting.WinForms.ReportDataSource
    Public PaperType As ReportEditor.PAPER_TYPE = ReportEditor.PAPER_TYPE._Letter

    'Dim ReportViewer As New Microsoft.Reporting.WinForms.ReportViewer


    Private nPageWidth As Single = 21.59
    Private nPageHeight As Single = 27.94
    Private m_streams As IList(Of Stream)
    Private m_currentPageIndex As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PaperComboBox.SelectedIndex = GetSelectedIndex()
        ShowReport()
    End Sub

    Private Function GetSelectedIndex() As Integer
        Select Case Me.PaperType
            Case ReportEditor.PAPER_TYPE._Letter
                Return 0
            Case ReportEditor.PAPER_TYPE._Legal
                Return 1
            Case ReportEditor.PAPER_TYPE._A4
                Return 2
            Case ReportEditor.PAPER_TYPE._8X13
                Return 3
            Case ReportEditor.PAPER_TYPE._8X5
                Return 4
            Case ReportEditor.PAPER_TYPE._8X8
                Return 5
        End Select
    End Function




    Sub ShowReport()
        'Show the report
        Application.DoEvents()
        If Not ReportContent Is Nothing Then
            Me.Controls.Remove(ReportContent)
            ReportContent.Dispose()
        End If

        Dim ReportViewer As New Microsoft.Reporting.WinForms.ReportViewer


        ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportViewer.Location = New System.Drawing.Point(12, 12)
        ReportViewer.Size = New System.Drawing.Size(Me.Size.Width - 281, Me.Size.Height - 58)
        ReportViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportViewer.Name = "ReportContent"
        ReportViewer.TabIndex = 16

        ReportContent = ReportViewer
        Me.Controls.Add(ReportViewer)

        'Edit the report using the report editor class
        'The report editor class works with a string
        'so we have to convert the report that is stored as stream to string
        'I made the function ResStreamToString(strNameOfTheResource) to do it
        'this function returns a string with the xml code of the report
        'and we send that string to the reporteditorclass

        'Dim objReportEditor As New ReportEditor(ResStreamToString(ReportNamePath))

        Dim objReportEditor As New ReportEditor(ReportToString(ReportNamePath))

        With objReportEditor
            'Change the paper
            .SetPaper(PaperType)
            'set the margins
            .SetTopMargin(Me.TopMarginNumericUpDown.Value)
            .SetBottomMargin(Me.BottomMarginNumericUpDown.Value)
            .SetRightMargin(Me.RightMarginNumericUpDown.Value)
            .SetLeftMargin(Me.LeftMarginNumericUpDown.Value)
            'keep the pagewith and pageheight in centimeters to be able to print later
            'if you are going to print with the reportviewer bprint button then you dont need this
            nPageWidth = .PageWidthCM
            nPageHeight = .PageHeightCM
        End With

        'Load the report definition in the reportviewer
        'We have to convert the xml code back to stream to be loaded into the reportviewer
        'i made another little function StringToStream(strReportXML)
        'this function converts a string into a stream
        'so we can load the report definition

        'Dim fs As FileStream(

        Dim temp_report As String = IO.Path.GetTempFileName()

        objReportEditor.XMLReport.Save(temp_report)
        Dim fs As New FileStream(temp_report, FileMode.Open)
        ReportContent.LocalReport.LoadReportDefinition(fs)

        fs.Close()
        ReportContent.LocalReport.EnableExternalImages = True

        'DataSource
        'Probably you know what this is
        'loading the data for the report

        'Dim objTableAdapter As New dataDataSetTableAdapters.countriesTableAdapter
        'objDataSource.Name = "dataDataSet_countries"
        'objDataSource.Value = objTableAdapter.GetData
        ReportContent.LocalReport.DataSources.Add(DataSource)
        ReportContent.LocalReport.SetParameters(ReportParameters)


        ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Application.DoEvents()
        ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ReportContent.Visible = True
    End Sub


    Private Function ReportToString(ByVal reportPath As String)
        Dim tr As StreamReader
        Dim str As String
        Try
            tr = New StreamReader(reportPath)
            str = tr.ReadToEnd()

        Catch ex As Exception
            MessageBox.Show("Error leyendo reporte ")
            Return Nothing
        Finally
            If Not tr Is Nothing Then
                tr.Close()
            End If
        End Try
        Return str
    End Function


    Private Sub RefreshReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshReportButton.Click
        Select Case Me.PaperComboBox.SelectedIndex
            Case 0
                PaperType = ReportEditor.PAPER_TYPE._Letter
            Case 1
                PaperType = ReportEditor.PAPER_TYPE._Legal
            Case 2
                PaperType = ReportEditor.PAPER_TYPE._A4
            Case 3
                PaperType = ReportEditor.PAPER_TYPE._8X13
            Case 4
                PaperType = ReportEditor.PAPER_TYPE._8X5
            Case 5
                PaperType = ReportEditor.PAPER_TYPE._8X8
        End Select
        ShowReport()
    End Sub

    Private Sub PrintReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportButton.Click
        print()
    End Sub


    Sub print()
        SetPrintParameters()
        If Not PDPrintDocument.PrinterSettings.IsValid Then
            MsgBox("Can't find printer")
            Return
        End If
        Export()
        PDPrintDocument.Print()
        RemoveStreams()
    End Sub
    '
    Sub SetPrintParameters()
        'Set the parameters we need to be able to print
        Dim objPrinterSettings As New Printing.PageSettings
        PDPrintDocument.PrinterSettings.PrinterName = objPrinterSettings.PrinterSettings.PrinterName

        Dim objPaperKind As System.Drawing.Printing.PaperKind
        Select Case PaperType
            Case ReportEditor.PAPER_TYPE._Letter
                objPaperKind = PaperKind.Letter
            Case ReportEditor.PAPER_TYPE._Legal
                objPaperKind = PaperKind.Legal
            Case ReportEditor.PAPER_TYPE._A4
                objPaperKind = PaperKind.A4
            Case ReportEditor.PAPER_TYPE._8X13
                objPaperKind = PaperKind.Folio
            Case Else
                'If the paper is custom then we have
                'to set it this way
                Dim objPaperSize As New System.Drawing.Printing.PaperSize
                objPaperSize.Height = (nPageHeight / 2.54) * 100
                objPaperSize.Width = (nPageWidth / 2.54) * 100
                objPaperSize.PaperName = "Custom"
                PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize
        End Select

        'With this 4 lines i solved the problem that when you print on different papers
        'always when you check the paper type in the print job you see the default paper
        For Each objPaperSize1 As PaperSize In PDPrintDocument.PrinterSettings.PaperSizes
            If objPaperSize1.Kind = objPaperKind Then
                PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize1
            End If
        Next

        'you will see this in the queue for the printer
        PDPrintDocument.DocumentName = My.Application.Info.ProductName
    End Sub


    'This function exports the report to EMF, create the streams and create files with
    'every page of the report
    'you need the Replace(",", ".") only if the decimal symbol is , for example.. in Venezuela.. my country ;)
    Public Sub Export()
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>" & Str(nPageWidth).Trim & "cm</PageWidth>" + _
          "  <PageHeight>" & Str(nPageHeight).Trim & "cm</PageHeight>" + _
          "  <MarginTop>" & Me.TopMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginTop>" + _
          "  <MarginLeft>" & Me.LeftMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginLeft>" + _
          "  <MarginRight>" & Me.RightMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginRight>" + _
          "  <MarginBottom>" & Me.BottomMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginBottom>" + _
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        ReportContent.LocalReport.Render("Image", deviceInfo, _
              AddressOf CreateStream, warnings)
        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Function CreateStream(ByVal name As String, _
    ByVal fileNameExtension As String, _
    ByVal encoding As Encoding, ByVal mimeType As String, _
    ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New FileStream(My.Application.Info.DirectoryPath & "\" & name + "." _
         + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function
    Public Sub RemoveStreams()
        'LIMPIAR EL ARRAY DE STREAMS
        If Not (m_streams Is Nothing) Then
            Dim stream As Stream
            For Each stream In m_streams
                stream.Close()
                stream = Nothing
            Next
            'm_streams = Nothing
        End If
        m_currentPageIndex = 0
        'BORRAR ARCHIVOS TEMPORALES
        Dim files As ReadOnlyCollection(Of String)
        Dim fileExists As Boolean
        files = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath, FileIO.SearchOption.SearchTopLevelOnly, "*.emf")
        For Each file As String In files
            fileExists = My.Computer.FileSystem.FileExists(file)
            If fileExists Then
                System.IO.File.Delete(file)
            End If
        Next
    End Sub


    Private Sub PDPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDPrintDocument.PrintPage
        Try
            Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
            e.Graphics.DrawImage(pageImage, e.PageBounds)
            m_currentPageIndex += 1
            e.HasMorePages = (m_currentPageIndex < m_streams.Count)
        Catch ex As Exception
            MsgBox(m_currentPageIndex & " - PDPrintDocument_PrintPage -" & ex.Message)
        End Try

    End Sub
End Class

#Region "Public Class ReportEditor"
Public Class ReportEditor
    Private intPageWidth As Single
    Private intPageHeight As Single
    Private intTopMargin As Single
    Private intBottomMargin As Single
    Private intLeftMargin As Single
    Private intRightMargin As Single

    Private lPageFooter As Boolean = True

    Public XMLReport As New Xml.XmlDocument()
    Dim ns As New Xml.XmlNamespaceManager(XMLReport.NameTable)
    Dim strRoot As String = "//ns:Report"
    Dim strReportTag As String = "<Report xmlns=""http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition"" xmlns:rd=""http://schemas.microsoft.com/SQLServer/reporting/reportdesigner"">"


    Public Enum PAPER_TYPE
        _Letter
        _Legal
        _A4
        _8X13
        _8X5
        _8X8
    End Enum

    Public Sub SetPaper(ByVal tipo As PAPER_TYPE)
        Select Case tipo
            Case PAPER_TYPE._Letter
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(27.94)
            Case PAPER_TYPE._A4
                Me.SetPageWidth(21)
                Me.SetPageHeight(29.7)
            Case PAPER_TYPE._8X5
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(13.97)
            Case PAPER_TYPE._8X8
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(20.96)
            Case PAPER_TYPE._Legal
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(35.56)
            Case PAPER_TYPE._8X13
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(33.02)
        End Select
    End Sub
    Sub New(ByVal strRDLCReport As String)
        XMLReport.LoadXml(strRDLCReport)

        ns.AddNamespace("ns", _
        "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")
        ns.AddNamespace("rd", _
        "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner")

        intPageWidth = InchCmToSingle(GetInnerText(strRoot, "ns:PageWidth"))
        intPageHeight = InchCmToSingle(GetInnerText(strRoot, "ns:PageHeight"))
        intTopMargin = InchCmToSingle(GetInnerText(strRoot, "ns:TopMargin"))
        intBottomMargin = InchCmToSingle(GetInnerText(strRoot, "ns:BottomMargin"))
        intLeftMargin = InchCmToSingle(GetInnerText(strRoot, "ns:LeftMargin"))
        intRightMargin = InchCmToSingle(GetInnerText(strRoot, "ns:RightMargin"))
    End Sub

    Sub New()

    End Sub

    ReadOnly Property PageWidthCM() As Single
        Get
            Return intPageWidth
        End Get
    End Property
    ReadOnly Property PageHeightCM() As Single
        Get
            Return intPageHeight
        End Get
    End Property

    ReadOnly Property PageWidthInch() As Single
        Get
            Return intPageWidth / 2.54
        End Get
    End Property
    ReadOnly Property PageHeightInch() As Single
        Get
            Return intPageHeight / 2.54
        End Get
    End Property

    Public Sub SetPageWidth(ByVal value As Single)
        SetInnerText(strRoot, "ns:PageWidth", toCm(value))
        intPageWidth = InchCmToSingle(GetInnerText(strRoot, "ns:PageWidth"))
    End Sub
    ReadOnly Property PageWidth() As String
        Get
            Return toCm(intPageWidth)
        End Get
    End Property

    Public Sub SetPageHeight(ByVal value As Single)
        SetInnerText(strRoot, "ns:PageHeight", toCm(value))
        intPageHeight = InchCmToSingle(GetInnerText(strRoot, "ns:PageHeight"))
    End Sub
    ReadOnly Property PageHeight() As String
        Get
            Return toCm(intPageHeight)
        End Get
    End Property

    Public Sub SetTopMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:TopMargin", toCm(value))
        intTopMargin = InchCmToSingle(GetInnerText(strRoot, "ns:TopMargin"))
    End Sub
    ReadOnly Property TopMargin() As String
        Get
            Return toCm(intTopMargin)
        End Get
    End Property

    Public Sub SetBottomMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:BottomMargin", toCm(value))
        intBottomMargin = InchCmToSingle(GetInnerText(strRoot, "ns:BottomMargin"))
    End Sub
    ReadOnly Property BottomMargin() As String
        Get
            Return toCm(intBottomMargin)
        End Get
    End Property

    Public Sub SetLeftMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:LeftMargin", toCm(value))
        intLeftMargin = InchCmToSingle(GetInnerText(strRoot, "ns:LeftMargin"))
    End Sub
    ReadOnly Property LeftMargin() As String
        Get
            Return toCm(intLeftMargin)
        End Get
    End Property

    Public Sub SetRightMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:RightMargin", toCm(value))
        intRightMargin = InchCmToSingle(GetInnerText(strRoot, "ns:RightMargin"))
    End Sub
    ReadOnly Property RightMargin() As String
        Get
            Return toCm(intRightMargin)
        End Get
    End Property
#Region "Converters"
    Private Function toCm(ByVal intValue As Single) As String
        Return Format(intValue, "#.##").Replace(",", ".") & "cm"
    End Function

    Private Function InchCmToSingle(ByVal strValue As String) As Single
        Try
            If strValue.ToUpper.IndexOf("CM") > -1 Then
                Return Val(strValue.ToUpper.Replace("CM", ""))
            End If
            If strValue.ToUpper.IndexOf("IN") > -1 Then
                Return Val(strValue.ToUpper.Replace("IN", "")) * 2.54
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
#Region "XML"
    'get an application setting by key value
    Private Function GetInnerText(ByVal section As String, ByVal key As String, Optional ByVal defaultvalue As String = "") As String
        Dim Node As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode( _
                                   section & "/" & key, ns)
        'return the value or nothing if it doesn't exist
        If Not Node Is Nothing Then
            Return Node.InnerText
        Else
            Return defaultvalue
        End If
    End Function

    Private Sub SetInnerText(ByVal section As String, ByVal key As String, ByVal value As String)
        'get the value
        Dim Node As Xml.XmlElement = XMLReport.DocumentElement.SelectSingleNode( _
                                           section & "/" & _
                                          key, ns)
        If Not Node Is Nothing Then
            'key found, set the value
            Node.InnerXml = value
        Else
            'key not found, create it
            Node = XMLReport.CreateElement(key, "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")

            'Node = xd.CreateElement(key)
            Node.InnerXml = value


            'look for the appsettings node
            Dim Root As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode(section, ns)

            'add the new child node (this key)
            If Not Root Is Nothing Then
                Root.AppendChild(Node)
            End If
        End If
    End Sub

    'delete an application setting, takes a key and a value
    Private Sub DeleteInnerText(ByVal section As String, ByVal key As String)

        'get the value
        Dim Node As Xml.XmlElement = CType(XMLReport.DocumentElement.SelectSingleNode( _
                                            section & "/" & _
                                           key, ns), Xml.XmlElement)
        If Not Node Is Nothing Then
            'key found, delete the value
            'look for the appsettings node
            Dim Root As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode(section, ns)
            If Not Root Is Nothing Then
                Root.RemoveChild(Node)
            End If
        Else
            'key not found, ignore            
        End If
    End Sub

#End Region

End Class
#End Region