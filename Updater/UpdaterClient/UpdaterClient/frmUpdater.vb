Imports System.Net
Imports UpdaterCommonLibrary
Imports System.IO
Imports System.Configuration
Imports ICSharpCode.SharpZipLib.Zip
Imports System.Reflection
Imports System.Threading

Public Class frmUpdater

    Enum UpdateTypeEnum
        Internet
        Local
    End Enum

    Enum UpdateMode
        Silent
        Verbose
    End Enum

    Dim UpdatesServer As UpdatesServer.Service
    Dim localFileSet As FileItem

    Private Delegate Sub SetProgresbarDelegate(ByVal value As Integer)
    Private Delegate Sub ChangeTextValueDelegate(ByRef control As Control, ByVal text As String)

    Dim AppName As String
    Dim AppPath As String
    Dim AppScriptsFolder As String
    Dim UpdateType As UpdateTypeEnum = UpdateTypeEnum.Local
    Dim InternetUpdateServer As String
    Dim LocalUpdateFolder As String
    Dim localZipPath As String

    Dim TemporaryLocalFolder As String
    Dim TempUnpackFolder As String

    Dim _oWebClient As WebClient = New System.Net.WebClient()
    Dim userState As Object

    Dim thread As Thread
    Dim LocalAppVersion As Version

    Dim utils As UpdaterCommonLibrary.Utils

    Public Sub New(ByVal AppPath As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.AppPath = AppPath
        If AppPath.EndsWith("\") Then
            Me.AppPath = AppPath.Remove(AppPath.Length - 1, 1)
        End If
        'MessageBox.Show("AppPath=" & AppPath)
    End Sub

   
    Private Sub frmUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        Me.Text = "Actualizador '" & AppName & "'"
    End Sub

#Region "Public Sub StartUpdate()"
    Public Sub StartUpdate()
        pBar.Value = 0
        btn_Buscar.Enabled = False
        btn_Configurar.Enabled = False

        utils = New UpdaterCommonLibrary.Utils()
        AddHandler utils.FileCounting, New UpdaterCommonLibrary.FileItemSet.FileCountintEventHandler(AddressOf FileCounting)
        AddHandler utils.FileProgress, New Utils.FileCopyProgressEventHandler(AddressOf fileCopyProgress)

        thread = New Thread(AddressOf UpdateApp)
        thread.Start()
    End Sub
#End Region

#Region "Private Sub LoadConfig()"
    Private Sub LoadConfig()
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(AppPath & "\UpdaterClient.exe")
        AppName = config.AppSettings.Settings("AppName").Value
        AppScriptsFolder = config.AppSettings.Settings("AppScriptsFolder").Value
        UpdateType = [Enum].Parse(GetType(UpdateTypeEnum), config.AppSettings.Settings("UpdateType").Value)
        InternetUpdateServer = config.AppSettings.Settings("InternetUpdateServer").Value
        LocalUpdateFolder = config.AppSettings.Settings("LocalUpdateFolder").Value
        If LocalUpdateFolder.EndsWith("\") Then
            LocalUpdateFolder = LocalUpdateFolder.Remove(LocalUpdateFolder.Length - 1, 1)
        End If
    End Sub
#End Region

#Region "private Sub UpdateApp()"
    Private Sub UpdateApp()
        'Inicializar valores
        LoadConfig()
        If UpdateType = UpdateTypeEnum.Local Then
            Try
                If Not Directory.Exists(LocalUpdateFolder) Then
                    MessageBox.Show("La carpeta de actualizacion es incorrecta.")
                    btn_Cancelar_Click(Nothing, Nothing)
                    Return
                End If
            Catch ex As Exception
                'MessageBox.Show("La carpeta de actualizacion es incorrecta.")
                'btn_Cancelar_Click(Nothing, Nothing)
            End Try
        End If

        TemporaryLocalFolder = Path.GetTempPath() & "\" & AppName
        If Not Directory.Exists(TemporaryLocalFolder) Then
            Directory.CreateDirectory(TemporaryLocalFolder)
        End If
        TempUnpackFolder = TemporaryLocalFolder & "/Unpacked"
        LocalAppVersion = UpdaterCommonLibrary.Utils.FromExecutablePath(AppPath & "/" & AppName & ".exe").GetName().Version

        'Llenar la lista local

        Dim localSet As UpdaterCommonLibrary.FileItemSet = New UpdaterCommonLibrary.FileItemSet(AppPath)
        localSet.LoadExclusionList(AppPath & "\excludeList.xml")
        localSet.Fill(AppPath)


        'MessageBox.Show("btn_Buscar, Apppath=" & AppPath)

        Select Case UpdateType
            Case UpdateTypeEnum.Internet
                UpdateViaInternet(localSet)

            Case UpdateTypeEnum.Local
                UpdateLocal(localSet)
        End Select

    End Sub
#End Region

#Region "Private Sub UpdateLocal(ByRef localSet As FileItemSet)"
    Private Sub UpdateLocal(ByRef localSet As FileItemSet)


        'Ahora leer los files de la carpeta de actualizacion

        ShowLog("Buscando actualizaciones...")
        ShowLog("Carpeta: " & LocalUpdateFolder)
        ShowLog("Comprobando validez...")
        If Not Directory.Exists(LocalUpdateFolder) Then
            ShowLog("Error Carpeta " & LocalUpdateFolder & " no existe")
            btn_Cancelar_Click(Nothing, Nothing)
            Return
        End If

        If Not File.Exists(LocalUpdateFolder & "\" & AppName & ".exe") Then
            ShowLog("Error! carpeta origen de actualizaciones no valida.")
            btn_Cancelar_Click(Nothing, Nothing)
            Return
        End If

        Dim updateSet As FileItemSet = New FileItemSet(LocalUpdateFolder)
        updateSet.LoadExclusionList(LocalUpdateFolder & "\excludeList.xml")
        updateSet.Fill(LocalUpdateFolder)

        Dim diff As FileItemSet = localSet.DifferenceSet(updateSet, localSet)

        ShowLog("Total ficheros a actualizar: " & diff.Items.Values.Count)

        If diff.Items.Values.Count = 0 Then
            ShowLog("No es necesario actualizarse")
            btn_Cancelar_Click(Nothing, Nothing)
            Return
        Else
            If MessageBox.Show("Total ficheros a actualizar: " & diff.Items.Values.Count & " (" & FormatFileSize(diff.TotalSize) & ")", "Actualizacion disponible!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'Seguir
            Else
                ShowLog("Cancelado por el usuario")
                btn_Cancelar_Click(Nothing, Nothing)
                Return
            End If
        End If

        If CloseAppProcess() Then
            Dim count As Integer = 0
            For Each file As FileItem In diff.Items.Values
                Dim sourceFile As String = LocalUpdateFolder & "\" & file.FileName
                Dim targetFile As String = AppPath & "\" & file.FileName
                ShowLog(file.FileName)
                Try
                    UpdaterCommonLibrary.Utils.XCopyFile(sourceFile, targetFile)
                    System.Threading.Thread.Sleep(100)
                Catch ex As Exception
                    ShowLog("Error: " & ex.Message)
                End Try

                Dim val As Integer = CType(Math.Round(count / diff.Items.Values.Count * 100), Integer)
                pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {val})
                'pBar.Value = Math.Round(count / diff.Items.Values.Count) * 100
                count = count + 1
            Next
            VerifyDBScripts(AppPath)
            ShowLog("Completado con exito!")
            pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {100})
            ShowLog("Copia completada.")
            ShowLog("Actualizacion completada con exito.")
            btn_Cancelar_Click(Nothing, Nothing)
            RestartApp()
        End If
    End Sub
#End Region

#Region "Private Sub UpdateViaInternet(ByRef localSet As FileItemSet)"
    Private Sub UpdateViaInternet(ByRef localSet As FileItemSet)
        Dim localItems As FileItem() = localSet.ToArray()

        Dim webServiceItems As UpdaterClient.UpdatesServer.FileItem()
        ReDim webServiceItems(localItems.Length - 1)

        Dim i As Integer = 0
        For i = 0 To localItems.Length - 1
            webServiceItems(i) = New UpdaterClient.UpdatesServer.FileItem()
            webServiceItems(i).FileName = localItems(i).FileName
            webServiceItems(i).MD5 = localItems(i).MD5
            webServiceItems(i).Size = localItems(i).Size
            webServiceItems(i).Type = localItems(i).Type
        Next

        UpdatesServer = New UpdatesServer.Service()
        UpdatesServer.Url = InternetUpdateServer & "Updates.asmx"
        AddHandler UpdatesServer.GetUpdateUrlCompleted, New UpdatesServer.GetUpdateUrlCompletedEventHandler(AddressOf GetUpdateUrlCompleted)
        ShowLog("Buscando actualizaciones...")
        ShowLog("Origen: " & UpdatesServer.Url)
        pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {10})
        UpdatesServer.GetUpdateUrlAsync("INCEME", webServiceItems, userState)
    End Sub
#End Region

#Region "Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click"
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        rt_Log.Clear()
        btn_Buscar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Cancelar.Text = "Cancelar"
        StartUpdate()
    End Sub
#End Region

#Region "Private Sub SetProgressBar(ByVal value As Integer)"
    Private Sub SetProgressBar(ByVal value As Integer)
        pBar.Value = value
    End Sub
#End Region

#Region "Private Sub GetUpdateUrlCompleted(ByVal sender As Object, ByVal e As UpdatesServer.GetUpdateUrlCompletedEventArgs)"
    Private Sub GetUpdateUrlCompleted(ByVal sender As Object, ByVal e As UpdatesServer.GetUpdateUrlCompletedEventArgs)
        If e.Cancelled Then
            ShowLog("Cancelado por el usuario")
            Return
        End If
        If Not e.Error Is Nothing Then
            ShowLog("Error encontrado:" & vbCrLf & e.Error.Message)
            btn_Cancelar_Click(Nothing, Nothing)
            Return
        End If
        If e.Result.IsUpdateAvailable Then
            ShowLog("Actualizacion disponible (" & FormatFileSize(e.Result.SizeInBytes) & ")")
            Dim frmNueva As frmNuevaVersionDisponible = New frmNuevaVersionDisponible()
            frmNueva.Info = e.Result
            frmNueva.CurrentVersion = LocalAppVersion
            If frmNueva.ShowDialog() = Windows.Forms.DialogResult.OK Then
                DownloadUpdate(e.Result)
            Else
                ShowLog("Cancelado por el usuario")
                Return
            End If
        Else
            ShowLog("No hay actualizaciones disponibles en este momento")
            btn_Cancelar_Click(Nothing, Nothing)
        End If
        pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {100})
    End Sub
#End Region

#Region "Private Sub DownloadUpdate(ByVal updateInfo As UpdatesServer.UpdateInfo)"
    Private Sub DownloadUpdate(ByVal updateInfo As UpdatesServer.UpdateInfo)
        _oWebClient = New WebClient()
        AddHandler _oWebClient.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf DownloadUpdateFileProgressHandler)
        AddHandler _oWebClient.DownloadFileCompleted, New System.ComponentModel.AsyncCompletedEventHandler(AddressOf DownloadUpdateFileCompletedHandler)

        Dim uri As New Uri(InternetUpdateServer & updateInfo.UpdateZipURL)
        localZipPath = TemporaryLocalFolder & "/" & System.IO.Path.GetFileName(updateInfo.UpdateZipURL)
        'If Not Directory.Exists(IO.Path.GetDirectoryName(localDestination)) Then
        '    Directory.CreateDirectory(Path.GetDirectoryName(localDestination))
        'End If
        ShowLog("Descargando " & uri.ToString())
        _oWebClient.DownloadFileAsync(uri, localZipPath)

    End Sub
#End Region

#Region "Private Sub DownloadUpdateFileProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)"
    Private Sub DownloadUpdateFileProgressHandler(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {e.ProgressPercentage})
        lbl_Msg.BeginInvoke(New ChangeTextValueDelegate(AddressOf ChangeTextValue), New Object() {lbl_Msg, "Descargando " & FormatedProgress(e.BytesReceived, e.TotalBytesToReceive)})
        'ShowLog("Descargando " & FormatedProgress(e.BytesReceived, e.TotalBytesToReceive))
    End Sub
#End Region

#Region "Private Sub DownloadUpdateFileCompletedHandler(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)"
    Private Sub DownloadUpdateFileCompletedHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        If Not e.Error Is Nothing Then
            ShowLog("ERROR: " & e.Error.Message)
            If Not e.Error.InnerException Is Nothing Then
                ShowLog("ERROR: " & e.Error.InnerException.Message)

            End If
            ShowLog(e.Error.StackTrace)
            btn_Cancelar_Click(Nothing, Nothing)
            Return
        End If

        If e.Cancelled Then
            ShowLog("El usuario ha cancelado")
            'btn_Cancelar_Click(Nothing, Nothing)
            Return
        End If

        ShowLog("Descarga finalizada")
        ShowLog("Extrayendo actualizacion...")
        UnpackZipFile(localZipPath)

        ShowLog("Copiando archivos...")

        If CloseAppProcess() Then
            MoveFiles(TempUnpackFolder, AppPath)
            VerifyDBScripts(AppPath)
            ShowLog("Completado con exito!")
            RestartApp()
        End If
    End Sub
#End Region

#Region "Private Sub ShowLog(ByVal msg As String)"
    Private Sub ShowLog(ByVal msg As String)
        lbl_Msg.BeginInvoke(New ChangeTextValueDelegate(AddressOf ChangeTextValue), New Object() {lbl_Msg, msg})
        rt_Log.BeginInvoke(New ChangeTextValueDelegate(AddressOf AppendTextValue), New Object() {rt_Log, msg & vbCrLf})
        'rt_Log.AppendText(msg & vbCrLf)
    End Sub
#End Region

    Private Sub ChangeTextValue(ByRef control As Control, ByVal text As String)
        control.Text = text
    End Sub

    Private Sub AppendTextValue(ByRef control As Control, ByVal text As String)
        control.Text = control.Text + text
    End Sub

#Region "Private Function FormatFileSize(ByVal fileSize As Long) As String"
    Private Function FormatFileSize(ByVal fileSize As Long) As String

        Dim suffixes() As String = {"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        Dim s As Integer = 0
        Dim _size As Double = fileSize
        While (_size >= 1024)
            s = s + 1
            _size = _size / 1024
        End While
        Return String.Format("{0:N1} {1}", _size, suffixes(s))
    End Function
#End Region

#Region "Public Function FormatedProgress(ByVal BytesReceived As Long, ByVal TotalBytesToReceive As Long) As String"
    Public Function FormatedProgress(ByVal BytesReceived As Long, ByVal TotalBytesToReceive As Long) As String
        Return "(" & FormatFileSize(BytesReceived) & " / " & FormatFileSize(TotalBytesToReceive) & " )"
    End Function
#End Region

#Region "Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click"
    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click

        Try

            If btn_Buscar.Enabled = True Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {0})
                btn_Buscar.Enabled = True
                btn_Configurar.Enabled = True
                btn_Cancelar.Text = "Cerrar"

                Select Case UpdateType
                    Case UpdateTypeEnum.Internet
                        UpdatesServer.CancelAsync(userState)
                        If Not _oWebClient Is Nothing Then
                            If _oWebClient.IsBusy Then
                                _oWebClient.CancelAsync()
                            End If
                        End If
                    Case UpdateTypeEnum.Local
                        Try
                            thread.Abort()
                        Catch ex As Exception

                        End Try
                End Select
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Private Sub UnpackZipFile(ByVal zipfilePath As String)"
    Private Sub UnpackZipFile(ByVal zipfilePath As String)
        Dim fast As FastZip = New FastZip()
        fast.CreateEmptyDirectories = True

        If Not Directory.Exists(TempUnpackFolder) Then
            Directory.CreateDirectory(TempUnpackFolder)
        End If
        fast.ExtractZip(zipfilePath, TempUnpackFolder, Nothing)
    End Sub

#End Region

#Region "Private Sub MoveFiles(ByVal sSourcePath As String,  ByVal sDestinationPath As String)"
    Private Sub MoveFiles(ByVal sSourcePath As String, _
                          ByVal sDestinationPath As String)

        If sSourcePath.EndsWith("\") Then
            sSourcePath = sSourcePath.Remove(sSourcePath.Length - 1, 1)
        End If

        If sDestinationPath.EndsWith("\") Then
            sDestinationPath = sDestinationPath.Remove(sDestinationPath.Length - 1, 1)
        End If

        utils.CopyFilesAndFolders(sSourcePath, sDestinationPath)

        System.Windows.Forms.Application.DoEvents()
        ShowLog("Eliminando temporales")
        RemoveDir(TemporaryLocalFolder)
    End Sub
#End Region

    Public Sub fileCopyProgress(ByVal fileName As String, ByVal v As Integer)
        ShowLog(fileName)
        pBar.BeginInvoke(New SetProgresbarDelegate(AddressOf SetProgressBar), New Object() {v})
    End Sub

    Public Sub FileCounting(ByVal count As Long)
        ShowLog("Encontrados " & count)
        'lbl_Msg.Text = 
    End Sub

#Region "Private Sub RemoveDir(ByVal sSourcePath As String)"
    Private Sub RemoveDir(ByVal sSourcePath As String)

        If sSourcePath.EndsWith("\") Then
            sSourcePath = sSourcePath.Remove(sSourcePath.Length - 1, 1)
        End If

        Directory.Delete(sSourcePath, True)

    End Sub
#End Region

#Region "Private Sub VerifyDBScripts(ByVal updatesFolder As String)"
    Private Sub VerifyDBScripts(ByVal updatesFolder As String)
        'Dim localScripts() As String = Directory.GetFiles(AppPath, "*.sql")
        'Dim newScripts() As String = Directory.GetFiles(AppPath, "*.sql")

        If Not Directory.Exists(updatesFolder & "\" & AppScriptsFolder) Then
            'No se requieren cambios en la DB
            Return
        End If

        If Not Directory.Exists(AppPath & "\" & AppScriptsFolder) Then
            Directory.CreateDirectory(AppPath & "\" & AppScriptsFolder)
            Return
        End If

        Dim localScriptSet As UpdaterCommonLibrary.FileItemSet = New UpdaterCommonLibrary.FileItemSet(AppPath & "\" & AppScriptsFolder)
        localScriptSet.Fill(AppPath & "\" & AppScriptsFolder)

        'Dim updatedScriptSet As UpdaterCommonLibrary.FileItemSet = New UpdaterCommonLibrary.FileItemSet(updatesFolder & "\" & AppScriptsFolder)
        'updatedScriptSet.Fill(updatesFolder & "\" & AppScriptsFolder)

        'Dim diffScripts As UpdaterCommonLibrary.FileItemSet = localScriptSet.DifferenceSet(updatedScriptSet, localScriptSet)

        If localScriptSet.Items.Count > 0 Then
            Dim frm As frmDatabaseUpdater = New frmDatabaseUpdater(AppName)
            frm.Scripts = localScriptSet
            frm.ShowDialog()
        End If
    End Sub
#End Region

    Private Function CloseAppProcess() As Boolean
        'Reiniciar la applicacion 
        Try
            Dim updateRes As DialogResult = MessageBox.Show("La aplicación " & AppName & " deberá reiniciarse para aplicar los cambios," & vbCrLf & "  todos los cambios no almacenados se perderán, Guarde su trabajo y presione OK para reiniciar la aplicación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If updateRes = Windows.Forms.DialogResult.OK Then
                'Eliminar todos los procesos de al AppName
                Dim processes As Process() = Process.GetProcessesByName(AppName)
                For Each proc As Process In processes
                    proc.Kill()
                Next
                Return True
            End If
        Catch ex As Exception
            ShowLog(ex.Message)
            Return False
        End Try
        Return False
    End Function

    Private Sub RestartApp()
        'Reiniciar la app
        Process.Start(AppPath & "\" & AppName & ".exe")
        Application.Exit()
    End Sub

#Region "Private Function GetDiffScript(ByVal scriptOldPath As String, ByVal scriptNewPath As String) As String"
    Private Function GetDiffScript(ByVal scriptOldPath As String, ByVal scriptNewPath As String) As String
        'Esta funcion lee el scritp viejo y lo elimina del nuevo retornando el script diferencia
        Try
            Dim oldStream As StreamReader = File.OpenText(scriptOldPath)
            Dim oldStr As String = oldStream.ReadToEnd()
            oldStream.Close()

            Dim newStream As StreamReader = File.OpenText(scriptNewPath)
            Dim newStr As String = newStream.ReadToEnd()
            newStream.Close()
            Return newStr.Substring(oldStr.Length)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ShowLog(ex.Message)
        End Try
    End Function
#End Region

#Region "Private Sub btn_Configurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Configurar.Click"
    Private Sub btn_Configurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Configurar.Click
        Dim frm As frmUpdaterConfig = New frmUpdaterConfig(AppPath)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Recargar la configuracion

        End If
    End Sub
#End Region

End Class
