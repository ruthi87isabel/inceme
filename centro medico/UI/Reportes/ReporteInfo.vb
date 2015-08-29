Namespace UI.Reportes
    Public Class ReporteInfo
        Public Property ID As String
        Public Property Info As String

        Private _fichero As String
        Public Property Fichero As String
            Get
                Dim path As String = Globales.Configuracion.impresionfilesdirectory & "\" & _fichero
                Dim defaultPath As String = Application.StartupPath & "\rdlc\default\" & _fichero
                If System.IO.File.Exists(path) Then
                    EsPersonalizado = path <> defaultPath
                    Return path
                Else
                    Return defaultPath
                    EsPersonalizado = False
                End If
            End Get
            Set(value As String)
                _fichero = value
            End Set
        End Property
        Public Property Verificado As Boolean = False
        Public Property EsPersonalizado As Boolean = False
    End Class
End Namespace