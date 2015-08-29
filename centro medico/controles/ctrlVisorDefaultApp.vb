Imports System.IO
Public Class ctrlVisorDefaultApp
    Public Sub abreAplicacion(ByVal path As String)
        If File.Exists(path) Then System.Diagnostics.Process.Start(path) Else MsgBox("No hay fichero para mostrar", MsgBoxStyle.Exclamation)
    End Sub


End Class
