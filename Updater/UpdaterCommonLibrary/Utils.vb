Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Reflection

Public Class Utils


    Public Delegate Sub FileCopyProgressEventHandler(ByVal fileName As String, ByVal progress As Integer)
    Public Event FileProgress As FileCopyProgressEventHandler
    Public Event FileCounting As FileItemSet.FileCountintEventHandler


#Region "Public Shared Function MD5CalcFile(ByVal filepath As String) As String"
    Public Shared Function MD5CalcFile(ByVal filepath As String) As String
        ' open file (as read-only)
        Using reader As New System.IO.FileStream(filepath, IO.FileMode.Open, IO.FileAccess.Read)
            Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                ' hash contents of this stream
                Dim hash() As Byte = md5.ComputeHash(reader)
                ' return formatted hash
                Return ByteArrayToString(hash)
            End Using
            reader.Close()
        End Using
    End Function
#End Region

#Region "Private Shared Function ByteArrayToString(ByVal arrInput() As Byte) As String"

    Private Shared Function ByteArrayToString(ByVal arrInput() As Byte) As String

        Dim sb As New System.Text.StringBuilder(arrInput.Length * 2)

        For i As Integer = 0 To arrInput.Length - 1
            sb.Append(arrInput(i).ToString("X2"))
        Next

        Return sb.ToString().ToLower

    End Function
#End Region

#Region "public Shared Function FormatFileSize(ByVal fileSize As Long) As String"
    Public Shared Function FormatFileSize(ByVal fileSize As Long) As String

        Dim suffixes() As String = {"B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        Dim s As Integer = 0
        Dim _size As Double = fileSize
        While (_size >= 1024)
            s = s + 1
            _size = _size / 1024
        End While
        Return String.Format("{0:N1} {1}", _size, suffixes(s))
    End Function
#End Region

#Region "Public Shared Function FromExecutablePath(ByVal path As String) As Reflection.Assembly"
    Public Shared Function FromExecutablePath(ByVal path As String) As Reflection.Assembly

        If Not IO.File.Exists(path) Then
            Throw New Exception("Fichero no encontrado!! " & path)
        End If

        Dim fileStream As FileStream = New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim rawAssembly(fileStream.Length) As Byte
        fileStream.Read(rawAssembly, 0, fileStream.Length - 1)

        Dim appAssembly As Assembly = Assembly.Load(rawAssembly)
        fileStream.Close()

        Return appAssembly
    End Function
#End Region


    Public Sub CopyFilesAndFolders(ByVal sourceFolder As String, ByVal targetFolder As String)

        Dim fs As FileItemSet = New FileItemSet(sourceFolder)
        RaiseEvent FileProgress("Calculando lista de ficheros...", 0)
        AddHandler fs.FileCounting, New FileItemSet.FileCountintEventHandler(AddressOf FileCount)
        fs.FillNoMD5(sourceFolder)

        Dim i As Long = 0
        Dim progress As Integer = 0
        For Each file As FileItem In fs.Items.Values
            i = i + 1
            progress = (i / fs.Items.Values.Count) * 100
            Dim targetFile As String = targetFolder & "\" & file.FileName
            Try
                XCopyFile(sourceFolder & "\" & file.FileName, targetFile)
                RaiseEvent FileProgress(file.FileName, progress)
            Catch ex As Exception
                RaiseEvent FileProgress("Error copiando " & file.FileName, progress)
                RaiseEvent FileProgress(ex.Message, progress)
            End Try
            
        Next
    End Sub

    Private Sub FileCount(ByVal count As Long)
        RaiseEvent FileCounting(count)
    End Sub

    '#Region "Private Shared Sub FillRecursive(ByVal sourceDirectory As String)"
    '    Private Sub CopyRecursive(ByVal sourceDirectory As String, ByVal targetFolder As String)
    '        If Directory.Exists(sourceDirectory) Then
    '            Dim di As New IO.DirectoryInfo(sourceDirectory)
    '            Dim files As FileInfo() = di.GetFiles()
    '            _TotalFiles = _TotalFiles + files.Length

    '            Dim i As Integer
    '            For i = 0 To files.Length - 1
    '                If (files(i).Attributes And FileAttributes.Hidden) = 0 Then
    '                    _fileCount = _fileCount + 1

    '                    _TotalSize = _TotalSize + files(i).Length
    '                    Dim targetFile As String = targetFolder & "\" & files(i).Name
    '                    XCopyFile(files(i).FullName, targetFile)
    '                    Dim progress As Integer = (_fileCount / _TotalFiles) * 100
    '                    RaiseEvent FileProgress(files(i).Name, progress)
    '                    'fileItem.MD5 = Utils.MD5CalcFile(files(i).FullName)
    '                    'fileItem.Type = fileItem.FileType.File
    '                    'Items.Add(fileItem.FileName, fileItem)
    '                End If
    '            Next

    '            'Obtener los directorios
    '            Dim directories As DirectoryInfo() = di.GetDirectories()

    '            For i = 0 To directories.Length - 1
    '                If (directories(i).Attributes And FileAttributes.Hidden) = 0 Then
    '                    If Not Directory.Exists(targetFolder & "\" & directories(i).Name) Then
    '                        Directory.CreateDirectory(targetFolder & "\" & directories(i).Name)
    '                    End If
    '                    CopyRecursive(directories(i).FullName, targetFolder & "\" & directories(i).Name)
    '                End If
    '            Next
    '        End If

    '    End Sub
    '#End Region

    Public Shared Sub XCopyFile(ByVal sourceFile As String, ByVal targetFile As String)
        Dim targetDir As String = Path.GetDirectoryName(targetFile)
        If Not Directory.Exists(targetDir) Then
            Directory.CreateDirectory(targetDir)
        End If
        Dim fileInfo As FileInfo = New FileInfo(sourceFile)

        If (fileInfo.Attributes And FileAttributes.Directory) <> 0 Then
            'Es un directorio no hacer nada
        Else
            File.Copy(sourceFile, targetFile, True)
        End If
    End Sub

End Class
