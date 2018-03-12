
Imports System.IO
Imports System.Configuration

Module Main

    Private UpdaterSelfUpdate As Boolean = False 'Se debe poner en false para poder debuggear, en true, el updaterclient se actualiza el mismo

    Public Sub Main()

        If Not UpdaterSelfUpdate Then
            'No autoactualizarse, se usa en modo desarrollo
            Dim AppPath As String = New DirectoryInfo(Application.StartupPath & "/" & ConfigurationManager.AppSettings("AppPath")).FullName
            Dim frm As frmUpdater = New frmUpdater(AppPath)
            frm.ShowDialog()
        Else
            Dim found As Boolean = False
            For Each param As String In Environment.GetCommandLineArgs()
                If param = "_Replicated" Then
                    Dim AppPath As String = GetAppPath()
                    Dim frm As frmUpdater = New frmUpdater(AppPath)
                    frm.ShowDialog()
                    found = True
                    Return
                End If
            Next
            'Si llega aqui es que no esta "Replicado"
            If Not found Then
                ReplicateUpdater()
            End If
        End If
    End Sub

#Region "Public Sub ReplicateUpdater()"
    Public Sub ReplicateUpdater()
        'Copiarme a mi mismo para una carpeta temporal

        Dim AppPath = New DirectoryInfo(Application.StartupPath & "/" & ConfigurationManager.AppSettings("AppPath")).FullName

        Dim tempDir As String = Path.GetTempPath() & "UpdaterTemp"
        If Not Directory.Exists(tempDir) Then
            Directory.CreateDirectory(tempDir)
        End If

        Dim files As String() = {"ICSharpCode.SharpZipLib.dll", _
                                 "Microsoft.ApplicationBlocks.Data.dll", _
                                 "UpdaterClient.exe", _
                                 "UpdaterClient.xml", _
                                 "UpdaterCommonLibrary.dll", _
                                 "UpdaterCommonLibrary.xml" _
                                }

        For Each file As String In files
            Dim sourceFile As String = AppPath & "\" & file
            Dim targetFile As String = tempDir & "\" & file
            Try
                UpdaterCommonLibrary.Utils.XCopyFile(sourceFile, targetFile)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return
            End Try
        Next

        'Ahora llamar al proceso y cerrar la app
        Dim params As List(Of String) = New List(Of String)
        params.AddRange(Environment.GetCommandLineArgs())
        params.Add("_Replicated")
        params.Add("AppPath=" & """" & AppPath & """")

        Dim paramsString As String = ""
        For Each param As String In params
            If param.Contains("ConnString=") Then
                paramsString = paramsString & " " & """" & param & """"
            Else
                paramsString = paramsString & " " & param
            End If


        Next

        Dim startInfo As ProcessStartInfo = New ProcessStartInfo(tempDir & "\" & "UpdaterClient.exe", paramsString.Trim())
        startInfo.WorkingDirectory = AppPath
        Process.Start(startInfo)
        Return
    End Sub
#End Region

#Region "Private Function GetAppPath() As String"
    Private Function GetAppPath() As String

        For Each param As String In Environment.GetCommandLineArgs()
            If param.Contains("AppPath=") Then
                'MessageBox.Show(param)
                Dim res As String = param.Substring("AppPath=".Length)
                'MessageBox.Show("AppPath resulto:  " & res.Replace("""", ""))
                Return res.Replace("""", "")
            End If
        Next
        Return ""
    End Function
#End Region


End Module
