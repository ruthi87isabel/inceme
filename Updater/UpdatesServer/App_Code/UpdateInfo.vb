Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Public Class UpdateInfo

    Public PublishedVersion As String 'Version del assembly del ejecutable en el server
    Public UpdateZipURL As String
    Public SizeInBytes As Long
    Public IsUpdateAvailable As Boolean = False
    Public Files As List(Of UpdaterCommonLibrary.FileItem) = New List(Of UpdaterCommonLibrary.FileItem)

    'Public PublishedAppVersion As Version
    'Public PublishedDataBaseVersion As String = ""
    'Public RequiredDatabaseVersion As String

    'Public PublishedDate As DateTime

    'Public RequireDatabaseChanges As Boolean = False
    'Public RequireRestart As Boolean = False

    Public Function UpdateSizeInMegaBytes() As Long
        Return (SizeInBytes / (1024 * 1024)).ToString("N2")
    End Function
End Class