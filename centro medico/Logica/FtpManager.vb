Imports System
Imports System.IO
Imports System.Net
Imports GoltraTools.clsLog
Imports GoltraTools

Public Class FtpManager

    Dim log As New clsLog
    Dim User As String = "u73075875"
    Dim Password As String = "4815Inceme1623$"

    'Actualiza el codigo de cifrado de las citas del medico cuando cambia de contraseña
    Public Sub UpdateFileNewPassFtp(idMedico As Integer, usuario As String)
        usuario = usuario.Replace(" ", "_")
        Dim cita As New CITA
        Dim Path As String = "ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" + Globales.Configuracion.IdentificadorClinica + "/" + usuario
        If Not GetDirectoryExists(Path) Then Return

        Dim lines() As String = GetFileList(Path)
        If Not lines Is Nothing Then
            For Each line As String In lines
                Dim fecha As String = line.Remove(line.Length - 4)
                cita.SincronizarMedicoCitas(fecha, idMedico)
            Next
        End If
    End Sub

    'Elimina las citas anteriores a una semana
    Public Function DeleteOldFileFtp(usuario As String) As Boolean
        usuario = usuario.Replace(" ", "_")
        Dim Path As String = "ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" + Globales.Configuracion.IdentificadorClinica + "/" + usuario

        Try
            Dim lines() As String = GetFileList(Path)
            If Not lines Is Nothing Then
                For Each line As String In lines
                    Dim fecha As String = line.Remove(line.Length - 4)
                    If fecha < Date.Now.AddDays(-7) Then
                        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(Path + "/" + fecha + ".txt"), FtpWebRequest)
                        request.Credentials = New NetworkCredential(User, Password)
                        request.Method = WebRequestMethods.Ftp.DeleteFile
                        Dim response As FtpWebResponse = request.GetResponse
                        response.Close()
                    End If
                Next
            End If
            log.Log("Eliminar las citas anteriores a una semana para el doctor " & usuario)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    'Elimina el fichero que tiene una sola cita y esta es eliminada
    Public Function DeleteFileFtp(usuario As String, fecha As String) As Boolean
        usuario = usuario.Replace(" ", "_")
        Dim Path As String = "ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" + Globales.Configuracion.IdentificadorClinica + "/" + usuario
        If Not GetDirectoryExists(Path) Then Return False

        Try
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(Path + "/" + fecha + ".txt"), FtpWebRequest)
            request.Credentials = New NetworkCredential(User, Password)
            request.Method = WebRequestMethods.Ftp.DeleteFile
            Dim response As FtpWebResponse = request.GetResponse
            response.Close()
            log.Log("Eliminar fichero del día " & fecha & " para el doctor " & usuario & " por falta de contenido")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    'Sube el fichero de citas txt al medico que corresponda en el FTP
    Public Sub SaveFileFtp(datos As String, fecha As String, usuario As String)

        log.FileName = Application.StartupPath & "\Log_SincronizacionCitasXMedico.txt"
        log.Log("*** " & Now.ToString & " - Subir citas del día " & fecha & " para el doctor " & usuario)

        usuario = usuario.Replace(" ", "_")

        Dim fullpath As String = ""
        If Not GetDirectoryExists("ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" & Globales.Configuracion.IdentificadorClinica & "/" & usuario) Then
            fullpath = CreateFolderFtp(usuario)
        Else
            fullpath = "ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" & Globales.Configuracion.IdentificadorClinica & "/" & usuario
        End If

        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(fullpath + "/" + fecha + ".txt"), FtpWebRequest)
        request.Credentials = New NetworkCredential(User, Password)
        request.EnableSsl = True
        request.Method = WebRequestMethods.Ftp.UploadFile

        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        'Dim file() As Byte = System.IO.File.ReadAllBytes("c:\SincronizacionCitasXMedico\" + Globales.Configuracion.IdentificadorClinica + "\" + usuario + "\" + fecha + ".txt")

        Dim encoding As System.Text.ASCIIEncoding = New System.Text.ASCIIEncoding()
        Dim bytes() As Byte = encoding.GetBytes(datos)
        log.Log(vbTab & "Cargar datos a subir al ftp")

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(bytes, 0, bytes.Length)
        strz.Close()
        strz.Dispose()
        log.Log("*** Datos subidos al ftp correctamente")
    End Sub

    'Crea la escructura de directorios donde se guardan las citas
    Private Function CreateFolderFtp(usuario As String) As String
        usuario = usuario.Replace(" ", "_")
        Dim fullpath As String = "ftp://home466817636.1and1-data.host"
        Dim folderNames(2) As String
        folderNames = New String(2) {"SincronizacionCitasXMedico", Globales.Configuracion.IdentificadorClinica, usuario}

        For Each folderName As String In folderNames
            fullpath += "/" + folderName

            If GetDirectoryExists(fullpath) Then Continue For

            Dim request As FtpWebRequest = FtpWebRequest.Create(fullpath)
            request.Credentials = New NetworkCredential(User, Password)
            request.UsePassive = True
            request.UseBinary = True

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            Try
                Using response As FtpWebResponse = request.GetResponse()
                End Using
            Catch ex As WebException
                Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            End Try
        Next

        log.Log(vbTab & "Crear estructura de directorio: " & fullpath)

        Return fullpath
    End Function

    'Verifica la existencia del directorio
    Public Function GetDirectoryExists(directoryName As String) As Boolean
        Dim directoryExists As Boolean
        Dim request As FtpWebRequest = FtpWebRequest.Create(directoryName)
        request.Credentials = New NetworkCredential(User, Password)
        request.Method = WebRequestMethods.Ftp.ListDirectory
        Try
            Using response As FtpWebResponse = request.GetResponse()
                directoryExists = True
            End Using
        Catch ex As WebException
            directoryExists = False
        End Try

        log.Log(vbTab & "Existencia del directorio: " & directoryName & " = " & directoryExists.ToString)
        Return directoryExists
    End Function

    'Obtiene una lista de citas para un medico determinado
    Public Function GetFileList(Path As String) As String()
        'If Not GetDirectoryExists(Path) Then Return Nothing

        Dim request As FtpWebRequest = FtpWebRequest.Create(Path)
        request.Credentials = New NetworkCredential(User, Password)
        request.Method = WebRequestMethods.Ftp.ListDirectory
        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)

        Dim Lf As Char = Convert.ToChar(CByte(10))
        Dim Cr As Char = Convert.ToChar(CByte(13))
        Dim CrLf As Char() = {Cr, Lf}
        Dim lines() As String = reader.ReadToEnd().Split(CrLf, StringSplitOptions.RemoveEmptyEntries)
        reader.Close()
        response.Close()
        Return lines
    End Function

    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

End Class
