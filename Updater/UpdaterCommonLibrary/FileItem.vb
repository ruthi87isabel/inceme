Imports Microsoft.VisualBasic

Public Class FileItem

    Public Enum FileType
        Directory
        File
    End Enum

    Public FileName As String 'Debera contener Path relativo
    Public Size As Long
    Public MD5 As String
    Public Type As FileType

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Return Me.MD5.Equals(obj.MD5)
    End Function

End Class
