Imports System.IO
Imports System.Xml

Public Class FileFunctions
    Dim myXwriter As System.Xml.XmlTextWriter

    Sub New()
    End Sub

#Region "Public Function ProcessDir(ByVal strDir As String, ByVal strFileName As String) As Boolean"
    Public Function ProcessDir(ByVal strDir As String, ByVal strFileName As String) As Boolean
        Try
            System.Diagnostics.Debug.WriteLine("Starting: " & Now.ToString)
            myXwriter = New System.Xml.XmlTextWriter(strFileName, Nothing)
            With myXwriter
                .Indentation = 4
                .IndentChar = " "
                .Formatting = .Indentation

                .WriteStartDocument()
                .WriteComment("This a list of directories")
            End With
            myXwriter.WriteRaw(vbCrLf)
            myXwriter.WriteStartElement("Directories")
            'first write out the specified directory

            myXwriter.WriteRaw(vbCrLf)
            myXwriter.WriteStartElement("Directory")
            'if directory exists
            If System.IO.Directory.Exists(strDir) Then
                myXwriter.WriteAttributeString("DirectoryName", strDir)
                myXwriter.WriteRaw(vbCrLf)
                'and write out the files in the specified directory
                GetFiles(strDir)
                myXwriter.WriteEndElement() 'end the root directory

                GetDirectories(strDir)
                'if the root directory does not exist
            Else
                myXwriter.WriteAttributeString("DirectoryName", "Root Directory does note exist")
            End If
            myXwriter.WriteEndDocument() 'end of directries

            Return True
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in ProcessDir: " & ex.Message)
            Return False
        Finally
            myXwriter.Flush()
            myXwriter.Close()
        End Try
    End Function
#End Region

#Region "Sub GetDirectories(ByVal strDir As String)"
    Sub GetDirectories(ByVal strDir As String)
        Try
            ' make a reference to a directory
            Dim di As New IO.DirectoryInfo(strDir)
            '   Dim diar1 As IO.FileInfo() = di.GetFiles()
            di.GetDirectories()
            '  Dim dra As IO.FileInfo
            Dim directory As IO.DirectoryInfo
            'list the names of all files in the specified directory
            'For Each dra In diar1
            '    System.Diagnostics.Debug.WriteLine("File: " & dra.FullName)
            'Next
            myXwriter.WriteRaw(vbCrLf)
            myXwriter.WriteStartElement("Directories")
            'then write out each directory under the specified directory
            For Each directory In di.GetDirectories
                myXwriter.WriteRaw(vbCrLf)
                myXwriter.WriteStartElement("Directory")
                myXwriter.WriteAttributeString("DirectoryName", directory.FullName)
                System.Diagnostics.Debug.WriteLine(directory.FullName)
                GetFiles(directory.FullName)
                myXwriter.WriteEndElement() 'end of directory

                GetDirectories(directory.FullName)

            Next
            myXwriter.WriteEndElement() 'end of directories
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in GetDirectories: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Sub GetFiles(ByVal strDir As String)"
    Sub GetFiles(ByVal strDir As String)
        Try
            ' make a reference to a directory
            Dim di As New IO.DirectoryInfo(strDir)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            di.GetDirectories()
            Dim dra As IO.FileInfo
            Dim directory As IO.DirectoryInfo
            'list the names of all files in the specified directory
            myXwriter.WriteRaw(vbCrLf)
            myXwriter.WriteStartElement("Files")
            For Each dra In diar1
                myXwriter.WriteRaw(vbCrLf)
                myXwriter.WriteStartElement("File")
                myXwriter.WriteAttributeString("FileName", dra.FullName)
                myXwriter.WriteAttributeString("FileSize", dra.Length)
                System.Diagnostics.Debug.WriteLine("--File: " & dra.FullName & " size: " & dra.Length)
                myXwriter.WriteEndElement()
                myXwriter.WriteRaw(vbCrLf)
            Next
            myXwriter.WriteEndElement()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in GetFiles: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Public Function DirectoryExists(ByVal strDirToFind As String, ByVal strXMLFileToSearch As String) As Boolean"
    Public Function DirectoryExists(ByVal strDirToFind As String, ByVal strXMLFileToSearch As String) As Boolean
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            Dim boolDirFound As Boolean = False
            'Create the XML Document
            m_xmld = New XmlDocument
            'Load the Xml file
            m_xmld.Load(strXMLFileToSearch)
            'Get the list of name nodes
            '   m_nodelist = m_xmld.SelectNodes("/Directories/Directory")
            m_nodelist = m_xmld.SelectNodes("//Directory")
            'Loop through the nodes
            For Each m_node In m_nodelist
                'Get the Gender Attribute Value
                If strDirToFind = m_node.Attributes.GetNamedItem("DirectoryName").Value Then
                    boolDirFound = True
                    Exit For
                End If
            Next
            '   System.Diagnostics.Debug.WriteLine("FileFunctions.DirectoryExists: Directory:" & strDirToFind & " File:" & strXMLFileToSearch)
            Return boolDirFound
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in FileFunctions.DirectoryExists: Directory:" & strDirToFind & " File:" & strXMLFileToSearch)
            Return False
        End Try
    End Function
#End Region

#Region "Public Function FileExists(ByVal strFileToFind As String, ByVal strXMLFileToSearch As String) As Boolean"
    Public Function FileExists(ByVal strFileToFind As String, ByVal strXMLFileToSearch As String) As Boolean
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            Dim boolDirFound As Boolean = False
            'Create the XML Document
            m_xmld = New XmlDocument
            'Load the Xml file
            m_xmld.Load(strXMLFileToSearch)
            'Get the list of name nodes
            m_nodelist = m_xmld.SelectNodes("//File")
            'Loop through the nodes
            For Each m_node In m_nodelist
                'Get the Gender Attribute Value
                If strFileToFind = m_node.Attributes.GetNamedItem("FileName").Value Then
                    boolDirFound = True
                    Exit For
                End If
            Next
            '   System.Diagnostics.Debug.WriteLine("FileFunctions.FileExists: Directory:" & strFileToFind & " File:" & strXMLFileToSearch)
            Return boolDirFound
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in FileFunctions.FileExists: Directory:" & strFileToFind & " File:" & strXMLFileToSearch)
            Return False
        End Try
    End Function
#End Region



End Class