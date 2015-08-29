Imports System.Text
Imports System.Windows.Forms
Imports System.Security
Imports System.Security.Principal
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Security.Permissions


Public Class FileCopier

    Public Delegate Sub FileCopyProgressEventHandler(ByVal fileName As String, ByVal progress As Integer)
    Public Event FileProgress As FileCopyProgressEventHandler
    'Public Event FileCounting As FileItemSet.FileCountintEventHandler
    'public Event ErrorOcurred as 

    Public Delegate Sub ErrorCopiandoDelegate(ByVal msg As String, ByVal ex As Exception)
    Public Delegate Sub CopiaTerminadaDelegate()
    Public Delegate Sub CredencialesCambiadasDelegate(ByVal newUser As String, ByVal newPassword As SecureString, ByVal newDomain As String)

    Public Event CredencialesCambiadas As CredencialesCambiadasDelegate
    Public Event CopiaTerminada As CopiaTerminadaDelegate
    Public Event ErrorCopiando As ErrorCopiandoDelegate

    Const ERROR_LOGON_FAILURE = 1326

    Shared tokenHandle As New IntPtr(0)
    Shared dupeTokenHandle As New IntPtr(0)





#Region "Public Sub CopiarFicheroConCredenciales(ByVal sourceFile As String, ByVal destPath As String, ByVal user As String, ByVal password As String, ByVal domain As String)"
    Public Sub CopiarFicheroConCredenciales(ByVal sourceFile As String, ByVal destPath As String, ByVal user As String, ByVal password As String, ByVal domain As String)

        If Not File.Exists(sourceFile) Then
            RaiseEvent ErrorCopiando("El fichero " & sourceFile & " no existe!", New FileNotFoundException())
            Return
        End If

        'Este metodo primero intentara copiar el fichero con las credenciales que se ejecuta el sistema'

        Try
            'Copiar fichero
            XCopyFile(sourceFile, destPath)

            ' si llega aqui es que se pudo copiar con las credenciales por defecto
            RaiseEvent CopiaTerminada()
            Return 'salir
        Catch ex As Exception
        End Try

        'Si llega aqui es que no se pudo copiar con la cuenta por defecto (u otro error), intentaremos 
        'usando las credenciales de los parametros

        Dim dialog As New GoltraTools.UserCredentialsDialog(destPath, "Conectar", "Introduza credenciales válidas")
        dialog.User = user
        dialog.Password = ToSecure(password)
        dialog.Domain = domain


        Dim returnValue As Boolean = False
        Do
            Try
                'Primero tratar de autenticar usando las credenciales aportadas
                tokenHandle = IntPtr.Zero
                returnValue = ImpersonationDemo.LogonUser(dialog.User, domain, dialog.PasswordToString(), 9, 0, tokenHandle)

                If returnValue = False Then
                    Dim ret As Integer = Marshal.GetLastWin32Error()
                    If ret = ERROR_LOGON_FAILURE Then
                        'Las credenciales de usuario no sirvieron, solicitar nuevas

                        If dialog.ShowDialog() = DialogResult.Cancel Then
                            'Si cancela salir
                            Return
                        End If
                    Else
                        Throw New System.ComponentModel.Win32Exception(ret)
                    End If
                End If

            Catch ex As Exception
                RaiseEvent ErrorCopiando("Error autenticando " & user, ex)
                Return
            End Try
        Loop Until returnValue = True

        'Verificar si hubo algun cambio en las credenciales y si es asi invocar el evento de cambio de credenciales
        If dialog.User <> user Or Not dialog.PasswordToString.Equals(password) Or dialog.Domain <> domain Then
            RaiseEvent CredencialesCambiadas(dialog.User, dialog.Password, dialog.Domain)
        End If

        'El usuario esta autenticado

        Try
            ' Use the token handle returned by LogonUser.
            Dim newId As New WindowsIdentity(tokenHandle)

            'Impersonar
            Dim impersonatedUser As WindowsImpersonationContext = newId.Impersonate()

            'Copiar fichero
            XCopyFile(sourceFile, destPath)

            ' Stop impersonating the user.
            impersonatedUser.Undo()

        Catch ex As Exception
            RaiseEvent ErrorCopiando("Error copiando " & sourceFile & " para " & destPath, ex)
            Return
        Finally
            ' Free the tokens.
            If Not System.IntPtr.op_Equality(tokenHandle, IntPtr.Zero) Then
                ImpersonationDemo.CloseHandle(tokenHandle)
            End If
        End Try
        RaiseEvent CopiaTerminada()
    End Sub
#End Region

#Region "Public Function VerificarCuenta(ByVal destPath As String, ByVal user As String, ByVal password As String, ByVal domain As String)"
    ''' <summary>
    ''' Verifica si unas credenciales tienen permiso de escritura en una carpeta especifica
    ''' </summary>
    ''' <param name="destPath"></param>
    ''' <param name="user"></param>
    ''' <param name="password"></param>
    ''' <param name="domain"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarCuenta(ByVal destPath As String, ByVal user As String, ByVal password As String, ByVal domain As String)
        tokenHandle = IntPtr.Zero
        Dim context = Nothing
        Try
            'If My.Computer.FileSystem.DirectoryExists(destPath) Then
            '    'la carpeta es local
            '    Dim context = FileCopier.Impersonate(user, password, domain)
            '    Dim fs As FileStream = File.Create(destPath & "\text.txt")
            '    fs.Close()
            '    File.Delete(destPath & "\text.txt")
            '    UndoImpersonate(context)
            'Else

            context = FileCopier.Impersonate(user, password, domain)
            If Not context Is Nothing Then
                Dim fs As FileStream = File.Create(destPath & "\text.txt")
                fs.Close()
                File.Delete(destPath & "\text.txt")
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            If Not context Is Nothing Then
                UndoImpersonate(context)
            End If

        End Try
        Return True
    End Function
#End Region

#Region "Public Shared Function Impersonate(ByVal user As String, ByVal password As String, ByVal dominio As String) As WindowsImpersonationContext"
    <PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")> _
    Public Shared Function Impersonate(ByVal user As String, ByVal password As String, ByVal dominio As String) As WindowsImpersonationContext

        Dim impersonatedUser As WindowsImpersonationContext
        Try

            tokenHandle = IntPtr.Zero
            Dim returnValue As Boolean
            If dominio.ToUpper() = My.Computer.Name Then
                'Autenticar local

                returnValue = ImpersonationDemo.LogonUser(user, dominio, password, _
                                                          ImpersonationDemo.LogonType.LOGON32_LOGON_INTERACTIVE, _
                                                          0, _
                                                          tokenHandle)
            Else
                'Autenticar por la red
                returnValue = ImpersonationDemo.LogonUser(user, dominio, password, 9, 0, tokenHandle)

            End If

             If returnValue = False Then
                MessageBox.Show("Error autenticando usuario '" & user & "' en dominio '" & dominio & "'. Contacte al administrador")
                Return Nothing
            End If
            ' Use the token handle returned by LogonUser.
            Dim newId As New WindowsIdentity(tokenHandle)

            'Impersonar
            impersonatedUser = newId.Impersonate()


        Catch ex As Exception
            MessageBox.Show("Error autenticando " & user)
            Return Nothing
        End Try

        Return impersonatedUser
    End Function
#End Region

#Region "Public Shared Function UndoImpersonate(ByVal context As WindowsImpersonationContext)"
    Public Shared Function UndoImpersonate(ByVal context As WindowsImpersonationContext)
        ' Stop impersonating the user.
        context.Undo()
        If Not System.IntPtr.op_Equality(tokenHandle, IntPtr.Zero) Then
            ImpersonationDemo.CloseHandle(tokenHandle)
        End If
        Return True
    End Function
#End Region


    Public Delegate Sub CopyingFileResultDelegate(ByVal res As DialogResult)

    ''' <summary>
    ''' Este metodo copia un fichero desde un origen hasta un destino utilizando distintas credenciales.
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="target"></param>
    ''' <remarks></remarks>
    Public Sub CopiarFicheroAsincrono(ByRef source As Origen, ByRef target As Destination, ByRef copyResult As CopyingFileResultDelegate, ByVal override As Boolean)
        Dim frm As New frmDualCopyProgress(source, target, override)

        copyResult(frm.ShowDialog())

    End Sub


#Region "Public Shared Function ToSecure(ByVal current As String) As SecureString"
    Public Shared Function ToSecure(ByVal current As String) As SecureString
        Dim secure As New SecureString()
        For Each c As Char In current.ToCharArray()
            secure.AppendChar(c)
        Next
        Return secure
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

#Region "Private Shared Sub XCopyFile(ByVal sourceFile As String, ByVal targetPath As String)"
    Private Shared Sub XCopyFile(ByVal sourceFile As String, ByVal targetPath As String)

        Dim targetFile As String = Path.GetFileName(sourceFile)
        Dim fileInfo As FileInfo = New FileInfo(sourceFile)
        File.Copy(sourceFile, targetPath & "\" & targetFile, True)

    End Sub
#End Region


#Region "Mapear torres"
    Public Declare Function WNetAddConnection2 Lib "mpr.dll" Alias "WNetAddConnection2A" _
(ByRef lpNetResource As NETRESOURCE, ByVal lpPassword As String, _
ByVal lpUserName As String, ByVal dwFlags As Integer) As Integer

    Public Declare Function WNetCancelConnection2 Lib "mpr" Alias "WNetCancelConnection2A" _
  (ByVal lpName As String, ByVal dwFlags As Integer, ByVal fForce As Integer) As Integer

    <StructLayout(LayoutKind.Sequential)> _
Public Structure NETRESOURCE
        Public dwScope As Integer
        Public dwType As Integer
        Public dwDisplayType As Integer
        Public dwUsage As Integer
        Public lpLocalName As String
        Public lpRemoteName As String
        Public lpComment As String
        Public lpProvider As String
    End Structure

    Public Const ForceDisconnect As Integer = 1
    Public Const RESOURCETYPE_DISK As Long = &H1

    Public Const ERROR_INVALID_PASSWORD = 86

    Public Shared Function MapDrive(ByVal DriveLetter As String, ByVal UNCPath As String, ByVal user As String, ByVal password As String, ByVal dominio As String) As Boolean

        Dim nr As NETRESOURCE
        Dim strUsername As String
        Dim strPassword As String

        nr = New NETRESOURCE
        nr.lpRemoteName = UNCPath
        nr.lpLocalName = DriveLetter & ":"
        strUsername = user
        strPassword = password
        nr.dwType = RESOURCETYPE_DISK

        Dim result As Integer
        result = WNetAddConnection2(nr, strPassword, strUsername, 0)

        If result = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function UnMapDrive(ByVal DriveLetter As String) As Boolean
        Dim rc As Integer
        rc = WNetCancelConnection2(DriveLetter & ":", 0, ForceDisconnect)

        If rc = 0 Then
            Return True
        Else
            Return False
        End If

    End Function


#Region "Public Shared Function GetAvailableDriveLetters() As List(Of String)"
    ''' <summary>
    ''' method to retrieve all available drive letters
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetAvailableDriveLetters() As List(Of String)
        Dim letters As New List(Of String)()

        'first let's get all avilable drive letters
        For i As Integer = Convert.ToInt16("a"c) To Convert.ToInt16("z"c) - 1
            letters.Add(New String(New Char() {CChar(ChrW(i))}))
        Next


        'now loop through each and remove it's drive letter from our list
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            letters.Remove(drive.Name.Substring(0, 1).ToLower())
        Next

        'return the letters left
        Return letters
    End Function
#End Region

#End Region




End Class



Public Class Origen
    Public FileName As String
    Public Username As String
    Public Password As String
    Public Domain As String
    Public UseCredentials As Boolean = False
End Class

Public Class Destination
    Public FileName As String
    Public Username As String
    Public Password As String
    Public Domain As String
    Public UseCredentials As Boolean = False
End Class

Public Class CopyMonitor

    Public Delegate Sub ProgressChangedDelegate(ByVal percent As Double)
    Public Delegate Sub ErrorDelegate(ByVal msg As String, ByVal ex As Exception)
    Public Delegate Sub CopyCompletedDelegate()

    Public Event ProgressChanged As ProgressChangedDelegate
    Public Event ErrorOcurred As ErrorDelegate
    Public Event CopyCompleted As CopyCompletedDelegate

End Class