Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml
Imports ICSharpCode.SharpZipLib.Zip
Imports System.Windows.Forms


<Serializable()> _
Public Class FileItemSet
    Public BaseDirectory As String
    Public Items As Dictionary(Of String, FileItem) = New Dictionary(Of String, FileItem)
    Public ExclusionList As Dictionary(Of String, FileItem) = New Dictionary(Of String, FileItem)
    Public TotalSize As Long = 0

    Public Delegate Sub FileCountintEventHandler(ByVal counter As Long)
    Public Event FileCounting As FileCountintEventHandler

#Region "Public Sub New(ByVal baseDirectory As String)"
    Public Sub New(ByVal baseDirectory As String)
        'If Not Directory.Exists(baseDirectory) Then
        '    Throw New Exception("No existe el directorio base " & baseDirectory)
        'End If
        Me.BaseDirectory = baseDirectory
    End Sub
#End Region

#Region "Public Sub Fill(ByVal sourceDirectory As String)"
    Public Sub Fill(ByVal sourceDirectory As String)
        TotalSize = 0
        FillRecursive(sourceDirectory)
    End Sub
#End Region

#Region "Public Function DifferenceSet(ByRef A As FileItemSet, ByRef B As FileItemSet) As FileItemSet"
    Public Function DifferenceSet(ByRef A As FileItemSet, ByRef B As FileItemSet) As FileItemSet
        'Retorna A - B
        'Los elementos que estan en A y no estan en B, basados en los fileName y los MD5 
        Dim res As FileItemSet = New FileItemSet("")
        For Each fileName As String In A.Items.Keys
            If Not B.Items.ContainsKey(fileName) Then
                'Si no contiene el fichero annadirlo a la diferencia
                res.Items.Add(fileName, A.Items(fileName))
                res.TotalSize = res.TotalSize + A.Items(fileName).Size
            Else
                'Si ya lo contiene verificar si son iguales
                If A.Items(fileName).MD5 <> B.Items(fileName).MD5 Then
                    'Son distintos, annadirlo a la diferencia
                    res.Items.Add(fileName, A.Items(fileName))
                    res.TotalSize = res.TotalSize + A.Items(fileName).Size
                End If
            End If
        Next

        Return res
    End Function
#End Region

#Region "Public Sub LoadExclusionList(ByVal xmlPath As String)"
    Public Sub LoadExclusionList(ByVal xmlPath As String)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(xmlPath)
        For Each fileNode As XmlNode In doc("excludeList").ChildNodes
            If fileNode.Name = "file" Then
                Dim item As FileItem = New FileItem()
                item.FileName = fileNode.InnerText
                ExclusionList.Add(item.FileName, item)
            End If

        Next
    End Sub
#End Region

#Region "Private Sub FillRecursive(ByVal sourceDirectory As String)"
    Private Sub FillRecursive(ByVal sourceDirectory As String)
        If Directory.Exists(sourceDirectory) Then
            Dim di As New IO.DirectoryInfo(sourceDirectory)
            Dim files As FileInfo() = di.GetFiles()

            Dim i As Integer
            For i = 0 To files.Length - 1
                If (files(i).Attributes And FileAttributes.Hidden) = 0 Then
                    Dim fileItem As FileItem = New FileItem()

                    'Al nombre del fichero se le quita el BaseDirectory
                    'si se guardan todos los ficheros relativos
                    fileItem.FileName = files(i).FullName.Substring(BaseDirectory.Length + 1)
                    fileItem.Size = files(i).Length
                    TotalSize = TotalSize + fileItem.Size
                    fileItem.MD5 = Utils.MD5CalcFile(files(i).FullName)
                    fileItem.Type = fileItem.FileType.File
                    If Not ExclusionList.ContainsKey(fileItem.FileName) Then
                        'Annadirlo si no esta en la lista de exclusion
                        Items.Add(fileItem.FileName, fileItem)
                    Else
                        'MessageBox.Show("Excluido:" & fileItem.FileName)
                    End If

                End If
            Next

            'Obtener los directorios
            Dim directories As DirectoryInfo() = di.GetDirectories()


            For i = 0 To directories.Length - 1
                If (directories(i).Attributes And FileAttributes.Hidden) = 0 Then

                    'Al nombre del fichero se le quita el BaseDirectory
                    'si se guardan todos los ficheros relativos
                    Dim dirItem As FileItem = New FileItem()
                    dirItem.FileName = directories(i).FullName.Substring(BaseDirectory.Length + 1)
                    dirItem.Size = 0 'directories(i).Length
                    dirItem.MD5 = dirItem.FileName  ' Utils.MD5CalcFile(directories(j).FullName)
                    dirItem.Type = FileItem.FileType.Directory
                    If Not ExclusionList.ContainsKey(dirItem.FileName) Then
                        'Si el folder no esta en la lista de exclusion agregarlo y navegarlo
                        Items.Add(dirItem.FileName, dirItem)
                        FillRecursive(directories(i).FullName)
                    Else
                        'MessageBox.Show("Excluido:" & dirItem.FileName)
                    End If

                End If
            Next
        End If

    End Sub
#End Region

#Region "Public Sub CreateZipFile(ByVal fileName As String)"
    Public Function CreateZipFile(ByVal fileName As String) As Long


        Dim z As ZipFile = ZipFile.Create(fileName)
        z.BeginUpdate()
        z.NameTransform = New ZipNameTransform(BaseDirectory)

        For Each file As FileItem In Items.Values
            If file.Type = FileItem.FileType.File Then
                z.Add(BaseDirectory & "/" & file.FileName)
            Else
                z.AddDirectory(BaseDirectory & "/" & file.FileName)
            End If

        Next
        z.CommitUpdate()
        z.Close()
        Dim fi As FileInfo = New FileInfo(fileName)
        Return fi.Length
    End Function

#End Region

#Region "Public Function ToArray() As UpdaterCommonLibrary.FileItem()"
    Public Function ToArray() As UpdaterCommonLibrary.FileItem()
        Dim res As FileItem()
        ReDim res(Me.Items.Values.Count - 1)
        Me.Items.Values.CopyTo(res, 0)
        Return res
    End Function
#End Region

#Region "Public Sub FillNoMD5(ByVal sourceDirectory As String)"
    Public Sub FillNoMD5(ByVal sourceDirectory As String)
        TotalSize = 0
        FillRecursiveNoMd5(sourceDirectory)
    End Sub
#End Region

#Region "Private Sub FillRecursiveNoMd5(ByVal sourceDirectory As String)"
    Private Sub FillRecursiveNoMd5(ByVal sourceDirectory As String)
        If Directory.Exists(sourceDirectory) Then
            Dim di As New IO.DirectoryInfo(sourceDirectory)
            Dim files As FileInfo() = di.GetFiles()

            Dim i As Integer
            For i = 0 To files.Length - 1
                If (files(i).Attributes And FileAttributes.Hidden) = 0 Then
                    Dim fileItem As FileItem = New FileItem()

                    'Al nombre del fichero se le quita el BaseDirectory
                    'si se guardan todos los ficheros relativos
                    fileItem.FileName = files(i).FullName.Substring(BaseDirectory.Length)
                    fileItem.Size = files(i).Length
                    TotalSize = TotalSize + fileItem.Size
                    'fileItem.MD5 = Utils.MD5CalcFile(files(i).FullName)
                    fileItem.Type = fileItem.FileType.File
                    'If Not ExclusionList.ContainsKey(fileItem.FileName) Then
                    '    'Annadirlo si no esta en la lista de exclusion
                    Items.Add(fileItem.FileName, fileItem)
                    'End If

                End If
            Next

            RaiseEvent FileCounting(Me.Items.Count)

            'Obtener los directorios
            Dim directories As DirectoryInfo() = di.GetDirectories()


            For i = 0 To directories.Length - 1
                If (directories(i).Attributes And FileAttributes.Hidden) = 0 Then

                    'Al nombre del fichero se le quita el BaseDirectory
                    'si se guardan todos los ficheros relativos
                    Dim dirItem As FileItem = New FileItem()
                    dirItem.FileName = directories(i).FullName.Substring(BaseDirectory.Length)
                    dirItem.Size = 0 'directories(i).Length
                    'dirItem.MD5 = dirItem.FileName  ' Utils.MD5CalcFile(directories(j).FullName)
                    dirItem.Type = FileItem.FileType.Directory
                    'If Not ExclusionList.ContainsKey(dirItem.FileName) Then
                    'Si el folder no esta en la lista de exclusion agregarlo y navegarlo
                    Items.Add(dirItem.FileName, dirItem)
                    FillRecursiveNoMd5(directories(i).FullName)
                    'End If

                End If
            Next
        End If

    End Sub
#End Region

End Class
