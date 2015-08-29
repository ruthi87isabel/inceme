Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Security.Permissions
Imports Microsoft.VisualBasic
<Assembly: SecurityPermissionAttribute(SecurityAction.RequestMinimum, UnmanagedCode:=True), _
 Assembly: PermissionSetAttribute(SecurityAction.RequestMinimum, Name:="FullTrust")> 
Module Module1

    Public Class ImpersonationDemo

        Public Enum LogonType As Integer
            'This logon type is intended for users who will be interactively using the computer, such as a user being logged on
            'by a terminal server, remote shell, or similar process.
            'This logon type has the additional expense of caching logon information for disconnected operations;
            'therefore, it is inappropriate for some client/server applications,
            'such as a mail server.
            LOGON32_LOGON_INTERACTIVE = 2

            'This logon type is intended for high performance servers to authenticate plaintext passwords.
            'The LogonUser function does not cache credentials for this logon type.
            LOGON32_LOGON_NETWORK = 3

            'This logon type is intended for batch servers, where processes may be executing on behalf of a user without
            'their direct intervention. This type is also for higher performance servers that process many plaintext
            'authentication attempts at a time, such as mail or Web servers.
            'The LogonUser function does not cache credentials for this logon type.
            LOGON32_LOGON_BATCH = 4

            'Indicates a service-type logon. The account provided must have the service privilege enabled.
            LOGON32_LOGON_SERVICE = 5

            'This logon type is for GINA DLLs that log on users who will be interactively using the computer.
            'This logon type can generate a unique audit record that shows when the workstation was unlocked.
            LOGON32_LOGON_UNLOCK = 7

            'This logon type preserves the name and password in the authentication package, which allows the server to make
            'connections to other network servers while impersonating the client. A server can accept plaintext credentials
            'from a client, call LogonUser, verify that the user can access the system across the network, and still
            'communicate with other servers.
            'NOTE: Windows NT:  This value is not supported.
            LOGON32_LOGON_NETWORK_CLEARTEXT = 8

            'This logon type allows the caller to clone its current token and specify new credentials for outbound connections.
            'The new logon session has the same local identifier but uses different credentials for other network connections.
            'NOTE: This logon type is supported only by the LOGON32_PROVIDER_WINNT50 logon provider.
            'NOTE: Windows NT:  This value is not supported.
            LOGON32_LOGON_NEW_CREDENTIALS = 9
        End Enum

        Public Enum LogonProvider As Integer
            'Use the standard logon provider for the system.
            'The default security provider is negotiate, unless you pass NULL for the domain name and the user name
            'is not in UPN format. In this case, the default provider is NTLM.
            'NOTE: Windows 2000/NT:   The default security provider is NTLM.
            LOGON32_PROVIDER_DEFAULT = 0
        End Enum


        Public Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As [String], _
            ByVal lpszDomain As [String], ByVal lpszPassword As [String], _
            ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, _
            ByRef phToken As IntPtr) As Boolean

        <DllImport("kernel32.dll")> _
        Public Shared Function FormatMessage(ByVal dwFlags As Integer, ByRef lpSource As IntPtr, _
            ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByRef lpBuffer As [String], _
            ByVal nSize As Integer, ByRef Arguments As IntPtr) As Integer

        End Function

        Public Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Boolean


        Public Declare Auto Function DuplicateToken Lib "advapi32.dll" (ByVal ExistingTokenHandle As IntPtr, _
                ByVal SECURITY_IMPERSONATION_LEVEL As Integer, _
                ByRef DuplicateTokenHandle As IntPtr) As Boolean

        ' Test harness.
        ' If you incorporate this code into a DLL, be sure to demand FullTrust.
        <PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")> _
        Public Overloads Shared Sub Main(ByVal args() As String)

            Dim tokenHandle As New IntPtr(0)
            Dim dupeTokenHandle As New IntPtr(0)
            Try


                Dim userName, domainName As String

                ' Get the user token for the specified user, domain, and password using the 
                ' unmanaged LogonUser method.  
                ' The local machine name can be used for the domain name to impersonate a user on this machine.
                Console.Write("Enter the name of a domain on which to log on: ")
                domainName = Console.ReadLine()

                Console.Write("Enter the login of a user on {0} that you wish to impersonate: ", domainName)
                userName = Console.ReadLine()

                Console.Write("Enter the password for {0}: ", userName)

                Const LOGON32_PROVIDER_DEFAULT As Integer = 0
                'This parameter causes LogonUser to create a primary token.
                Const LOGON32_LOGON_INTERACTIVE As Integer = 2

                tokenHandle = IntPtr.Zero

                ' Call LogonUser to obtain a handle to an access token.
                Dim returnValue As Boolean = LogonUser(userName, domainName, Console.ReadLine(), LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, tokenHandle)

                Console.WriteLine("LogonUser called.")

                If False = returnValue Then
                    Dim ret As Integer = Marshal.GetLastWin32Error()
                    Console.WriteLine("LogonUser failed with error code : {0}", ret)
                    Throw New System.ComponentModel.Win32Exception(ret)

                    Return
                End If

                Dim success As String
                If returnValue Then success = "Yes" Else success = "No"
                Console.WriteLine(("Did LogonUser succeed? " + success))
                Console.WriteLine(("Value of Windows NT token: " + tokenHandle.ToString()))

                ' Check the identity.
                Console.WriteLine(("Before impersonation: " + WindowsIdentity.GetCurrent().Name))

                ' Use the token handle returned by LogonUser.
                Dim newId As New WindowsIdentity(tokenHandle)
                Dim impersonatedUser As WindowsImpersonationContext = newId.Impersonate()

                ' Check the identity.
                Console.WriteLine(("After impersonation: " + WindowsIdentity.GetCurrent().Name))

                ' Stop impersonating the user.
                impersonatedUser.Undo()

                ' Check the identity.
                Console.WriteLine(("After Undo: " + WindowsIdentity.GetCurrent().Name))

                ' Free the tokens.
                If Not System.IntPtr.op_Equality(tokenHandle, IntPtr.Zero) Then
                    CloseHandle(tokenHandle)
                End If

            Catch ex As Exception
                Console.WriteLine(("Exception occurred. " + ex.Message))
            End Try
        End Sub 'Main 
    End Class 'Class1
End Module

