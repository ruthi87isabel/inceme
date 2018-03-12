Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports UpdaterCommonLibrary

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
     Inherits System.Web.Services.WebService

#Region "Public Function GetServerAppManifest(ByVal AppFolderName As String) As FileItem()"
    <WebMethod()> _
    Public Function GetServerAppManifest(ByVal AppFolderName As String) As FileItem()

        Dim sourceDir = Server.MapPath(Nothing) & "/Updates/" & AppFolderName & "/Release/"
        'Dim outPutFile = Server.MapPath(Nothing) & "/Updates/" & AppFolderName & "/fileManifest.xml"

        Dim fileSet As FileItemSet = New FileItemSet(sourceDir)
        fileSet.Fill(sourceDir)
        'Dim fileFunc As FileFunctions = New FileFunctions()
        'fileFunc.ProcessDir(sourceDir, outPutFile)

        Dim res As FileItem() '= New FileItem()
        ReDim res(fileSet.Items.Values.Count - 1)
        fileSet.Items.Values.CopyTo(res, 0)
        Return res
    End Function
#End Region

    <WebMethod(True)> _
    Public Function GetUpdateUrl(ByVal AppFolderName As String, ByVal remoteFiles() As FileItem) As UpdateInfo ' , ByVal localManifest As FileItem()) As String

        'System.Threading.Thread.Sleep(10000)
        Dim sourceDir = Server.MapPath(Nothing) & "/Updates/" & AppFolderName & "/Release"
        Dim serverSet As FileItemSet = New FileItemSet(sourceDir)
        serverSet.LoadExclusionList(Server.MapPath(Nothing) & "/Updates/" & AppFolderName & "/excludeList.xml")
        serverSet.Fill(sourceDir)

        Dim remoteSet As FileItemSet = New FileItemSet("")

        For Each remoteF As FileItem In remoteFiles
            remoteSet.Items.Add(remoteF.FileName, remoteF)
        Next

        Dim res As FileItemSet = serverSet.DifferenceSet(serverSet, remoteSet)
        res.BaseDirectory = sourceDir

        Dim updateInfo As UpdateInfo = New UpdateInfo

        If res.Items.Count > 0 And res.TotalSize > 0 Then
            'Hay ficheros disponibles
            'Ahora crear un .zip con los ficheros de la diferencia
            'y guardarlos en una carpeta, 

            Dim fileZipFolder As String = Server.MapPath(Nothing) & "/Updates/" & AppFolderName & "/UpdatesZipFolder"
            If Not System.IO.Directory.Exists(fileZipFolder) Then
                System.IO.Directory.CreateDirectory(fileZipFolder)
            End If

            'El nombre del fichero zip debe tener el cuenta el SessionID
            'para que sea unico para cada pedido
            Dim fileZipName As String = AppFolderName & "_" & Guid.NewGuid().ToString() & ".zip"
            'Dim fileZipName As String = AppFolderName & "_" & Me.Session.SessionID & ".zip"
            Dim size = res.CreateZipFile(fileZipFolder & "/" & fileZipName)
            updateInfo.UpdateZipURL = "/Updates/" & AppFolderName & "/UpdatesZipFolder/" & fileZipName
            updateInfo.SizeInBytes = size
            updateInfo.IsUpdateAvailable = True
            updateInfo.PublishedVersion = UpdaterCommonLibrary.Utils.FromExecutablePath(sourceDir & "/" & AppFolderName & ".exe").GetName().Version.ToString

            For Each file As FileItem In res.Items.Values
                updateInfo.Files.Add(file)
            Next
        Else
            updateInfo.UpdateZipURL = "no need"
            updateInfo.SizeInBytes = 0
            updateInfo.IsUpdateAvailable = False

        End If
        Return updateInfo
    End Function


End Class
