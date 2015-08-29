Imports System.Text
Imports System.Drawing
Imports System.Security
Imports System.Security.Permissions
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Namespace GoltraTools
#Region "UserCredentialsDialogFlags"
    ''' <summary>
    ''' Specifies special behavior for this function. 
    ''' This value can be a bitwise-OR combination of zero or more of the following values. 
    '''  For more information of these flags see:
    ''' http://msdn.microsoft.com/library/default.asp?url=/library/en-us/secauthn/security/creduipromptforcredentials.asp
    ''' http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnnetsec/html/dpapiusercredentials.asp?frame=true
    ''' </summary>
    <Flags()> _
    Public Enum UserCredentialsDialogFlags
        [Default] = GenericCredentials Or ShowSaveCheckbox Or AlwaysShowUI Or ExpectConfirmation
        None = &H0
        IncorrectPassword = &H1
        DoNotPersist = &H2
        RequestAdministrator = &H4
        ExcludesCertificates = &H8
        RequireCertificate = &H10
        ShowSaveCheckbox = &H40
        AlwaysShowUI = &H80
        RequireSmartCard = &H100
        PasswordOnlyOk = &H200
        ValidateUsername = &H400
        CompleteUserName = &H800
        Persist = &H1000
        ServerCredential = &H4000
        ExpectConfirmation = &H20000
        GenericCredentials = &H40000
        UsernameTargetCredentials = &H80000
        KeepUsername = &H100000
    End Enum
#End Region

#Region "UserCredentialsDialog class"

    ''' <summary>
    ''' Displays a dialog box and promts the user for login credentials.
    ''' </summary>
    <ToolboxItem(True)> _
    <DesignerCategory("Dialogs")> _
    Public Class UserCredentialsDialog
        Inherits CommonDialog
#Region "Fields"

        Private m_user As String
        Private m_password As SecureString
        Private m_domain As String
        Private m_target As String
        Private m_message As String
        Private m_caption As String
        Private m_banner As Image
        Private m_saveChecked As Boolean
        Private m_flags As UserCredentialsDialogFlags

#End Region

#Region "Constructors"

        Public Sub New()
            Me.Reset()
        End Sub

        Public Sub New(ByVal target As String)
            Me.New(target, Nothing, Nothing, Nothing)
        End Sub

        Public Sub New(ByVal target As String, ByVal caption As String)
            Me.New(target, caption, Nothing, Nothing)
        End Sub

        Public Sub New(ByVal target As String, ByVal caption As String, ByVal message As String)
            Me.New(target, caption, message, Nothing)
        End Sub

        Public Sub New(ByVal target As String, ByVal caption As String, ByVal message As String, ByVal banner As Image)
            Me.New()
            Me.Target = target
            Me.Caption = caption
            Me.Message = message
            Me.Banner = banner
        End Sub

#End Region

#Region "Properties"

        Public Property User() As String
            Get
                Return m_user
            End Get
            Set(ByVal value As String)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_USERNAME_LENGTH Then
                        Throw New ArgumentException(String.Format("The user name has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_USERNAME_LENGTH), "User")
                    End If
                End If
                m_user = value
            End Set
        End Property

        Public Property Password() As SecureString
            Get
                Return m_password
            End Get
            Set(ByVal value As SecureString)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_PASSWORD_LENGTH Then
                        Throw New ArgumentException(String.Format("The password has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_PASSWORD_LENGTH), "Password")
                    End If
                End If
                m_password = value
            End Set
        End Property

        Public Property Domain() As String
            Get
                Return m_domain
            End Get
            Set(ByVal value As String)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_DOMAIN_TARGET_LENGTH Then
                        Throw New ArgumentException(String.Format("The domain name has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_DOMAIN_TARGET_LENGTH), "Domain")
                    End If
                End If
                m_domain = value
            End Set
        End Property

        Public Property Target() As String
            Get
                Return m_target
            End Get
            Set(ByVal value As String)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_GENERIC_TARGET_LENGTH Then
                        Throw New ArgumentException(String.Format("The target has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_GENERIC_TARGET_LENGTH), "Target")
                    End If
                End If
                m_target = value
            End Set
        End Property

        Public Property Message() As String
            Get
                Return m_message
            End Get
            Set(ByVal value As String)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_MESSAGE_LENGTH Then
                        Throw New ArgumentException(String.Format("The message has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_MESSAGE_LENGTH), "Message")
                    End If
                End If
                m_message = value
            End Set
        End Property

        Public Property Caption() As String
            Get
                Return m_caption
            End Get
            Set(ByVal value As String)
                If value IsNot Nothing Then
                    If value.Length > Win32Native.CREDUI_MAX_CAPTION_LENGTH Then
                        Throw New ArgumentException(String.Format("The caption has a maximum length of {0} characters.", Win32Native.CREDUI_MAX_CAPTION_LENGTH), "Caption")
                    End If
                End If
                m_caption = value
            End Set
        End Property

        Public Property Banner() As Image
            Get
                Return m_banner
            End Get
            Set(ByVal value As Image)
                If value IsNot Nothing Then
                    If value.Width <> Win32Native.CREDUI_BANNER_WIDTH Then
                        Throw New ArgumentException(String.Format("The banner image width must be {0} pixels.", Win32Native.CREDUI_BANNER_WIDTH), "Banner")
                    End If
                    If value.Height <> Win32Native.CREDUI_BANNER_HEIGHT Then
                        Throw New ArgumentException(String.Format("The banner image height must be {0} pixels.", Win32Native.CREDUI_BANNER_HEIGHT), "Banner")
                    End If
                End If
                m_banner = value
            End Set
        End Property

        Public Property SaveChecked() As Boolean
            Get
                Return m_saveChecked
            End Get
            Set(ByVal value As Boolean)
                m_saveChecked = value
            End Set
        End Property

        Public Property Flags() As UserCredentialsDialogFlags
            Get
                Return m_flags
            End Get
            Set(ByVal value As UserCredentialsDialogFlags)
                m_flags = value
            End Set
        End Property

#End Region

#Region "Public methods"

        Public Sub ConfirmCredentials(ByVal confirm As Boolean)
            Dim ui As New UIPermission(UIPermissionWindow.SafeSubWindows)
            ui.Demand()

            Dim result As Win32Native.CredUIReturnCodes = Win32Native.CredUIConfirmCredentialsW(Me.m_target, confirm)

            If result <> Win32Native.CredUIReturnCodes.NO_ERROR AndAlso result <> Win32Native.CredUIReturnCodes.ERROR_NOT_FOUND AndAlso result <> Win32Native.CredUIReturnCodes.ERROR_INVALID_PARAMETER Then
                Throw New InvalidOperationException(TranslateReturnCode(result))
            End If
        End Sub

        ''' <summary>
        ''' This method is for backward compatibility with APIs that does
        ''' not provide the <see cref="SecureString"/> type.
        ''' </summary>
        ''' <returns></returns>
        Public Function PasswordToString() As String
            Dim ptr As IntPtr = Marshal.SecureStringToGlobalAllocUnicode(Me.m_password)
            Try
                ' Unsecure managed string
                Return Marshal.PtrToStringUni(ptr)
            Finally
                Marshal.ZeroFreeGlobalAllocUnicode(ptr)
            End Try
        End Function

#End Region

#Region "CommonDialog overrides"

        Protected Overrides Function RunDialog(ByVal hwndOwner As IntPtr) As Boolean
            If Environment.OSVersion.Version.Major < 5 Then
                Throw New PlatformNotSupportedException("The Credential Management API requires Windows XP / Windows Server 2003 or later.")
            End If

            Dim credInfo As New Win32Native.CredUIInfo(hwndOwner, Me.m_caption, Me.m_message, Me.m_banner)
            Dim usr As New StringBuilder(Win32Native.CREDUI_MAX_USERNAME_LENGTH)
            Dim pwd As New StringBuilder(Win32Native.CREDUI_MAX_PASSWORD_LENGTH)

            If Not String.IsNullOrEmpty(Me.User) Then
                If Not String.IsNullOrEmpty(Me.Domain) Then
                    usr.Append(Me.Domain & "\")
                End If
                usr.Append(Me.User)
            End If
            If Me.Password IsNot Nothing Then
                pwd.Append(Me.PasswordToString())
            End If

            Try
                Dim result As Win32Native.CredUIReturnCodes = Win32Native.CredUIPromptForCredentials(credInfo, Me.m_target, IntPtr.Zero, 0, usr, Win32Native.CREDUI_MAX_USERNAME_LENGTH, _
                 pwd, Win32Native.CREDUI_MAX_PASSWORD_LENGTH, Me.m_saveChecked, Me.m_flags)
                Select Case result
                    Case Win32Native.CredUIReturnCodes.NO_ERROR
                        LoadUserDomainValues(usr)
                        LoadPasswordValue(pwd)
                        Return True
                    Case Win32Native.CredUIReturnCodes.ERROR_CANCELLED
                        Me.User = Nothing
                        Me.Password = Nothing
                        Return False
                    Case Else
                        Throw New InvalidOperationException(TranslateReturnCode(result))
                End Select
            Finally
                usr.Remove(0, usr.Length)
                pwd.Remove(0, pwd.Length)
                If Me.m_banner IsNot Nothing Then
                    Win32Native.DeleteObject(credInfo.hbmBanner)
                End If
            End Try
        End Function

        ''' <summary>
        ''' Set all properties to it's default values.
        ''' </summary>
        Public Overrides Sub Reset()
            Me.m_target = If(Application.ProductName, AppDomain.CurrentDomain.FriendlyName)
            Me.m_user = Nothing
            Me.m_password = Nothing
            Me.m_domain = Nothing
            Me.m_caption = Nothing
            ' target as caption;
            Me.m_message = Nothing
            Me.m_banner = Nothing
            Me.m_saveChecked = False
            Me.m_flags = UserCredentialsDialogFlags.[Default]
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)

            If Me.m_password IsNot Nothing Then
                Me.m_password.Dispose()
                Me.m_password = Nothing
            End If
        End Sub

#End Region

#Region "Private methods"

        Private Shared Function TranslateReturnCode(ByVal result As Win32Native.CredUIReturnCodes) As String
            Return String.Format("Invalid operation: {0}", result.ToString())
        End Function

        Private Sub LoadPasswordValue(ByVal password As StringBuilder)
            Dim pwd As Char() = New Char(password.Length - 1) {}
            Dim securePassword As New SecureString()
            Try
                password.CopyTo(0, pwd, 0, pwd.Length)
                For Each c As Char In pwd
                    securePassword.AppendChar(c)
                Next
                securePassword.MakeReadOnly()
                Me.Password = securePassword.Copy()
            Finally
                ' discard the char array
                Array.Clear(pwd, 0, pwd.Length)
            End Try
        End Sub

        Private Sub LoadUserDomainValues(ByVal principalName As StringBuilder)
            Dim user As New StringBuilder(Win32Native.CREDUI_MAX_USERNAME_LENGTH)
            Dim domain As New StringBuilder(Win32Native.CREDUI_MAX_DOMAIN_TARGET_LENGTH)
            Dim result As Win32Native.CredUIReturnCodes = Win32Native.CredUIParseUserNameW(principalName.ToString(), user, Win32Native.CREDUI_MAX_USERNAME_LENGTH, domain, Win32Native.CREDUI_MAX_DOMAIN_TARGET_LENGTH)

            If result = Win32Native.CredUIReturnCodes.NO_ERROR Then
                Me.User = user.ToString()
                Me.Domain = domain.ToString()
            Else
                Me.User = principalName.ToString()
                Me.Domain = Environment.MachineName
            End If
        End Sub

#End Region

#Region "Unmanaged code"

        <SuppressUnmanagedCodeSecurity()> _
        Private NotInheritable Class Win32Native
            Friend Const CREDUI_MAX_MESSAGE_LENGTH As Integer = 100
            Friend Const CREDUI_MAX_CAPTION_LENGTH As Integer = 100
            Friend Const CREDUI_MAX_GENERIC_TARGET_LENGTH As Integer = 100
            Friend Const CREDUI_MAX_DOMAIN_TARGET_LENGTH As Integer = 100
            Friend Const CREDUI_MAX_USERNAME_LENGTH As Integer = 100
            Friend Const CREDUI_MAX_PASSWORD_LENGTH As Integer = 100
            Friend Const CREDUI_BANNER_HEIGHT As Integer = 60
            Friend Const CREDUI_BANNER_WIDTH As Integer = 320

            <DllImport("gdi32.dll", EntryPoint:="DeleteObject")> _
            Friend Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
            End Function

            <DllImport("credui.dll", EntryPoint:="CredUIPromptForCredentialsW", SetLastError:=True, CharSet:=CharSet.Unicode)> _
            Friend Shared Function CredUIPromptForCredentials(ByRef creditUR As CredUIInfo, ByVal targetName As String, ByVal reserved1 As IntPtr, ByVal iError As Integer, ByVal userName As StringBuilder, ByVal maxUserName As Integer, _
             ByVal password As StringBuilder, ByVal maxPassword As Integer, ByRef iSave As Boolean, ByVal flags As UserCredentialsDialogFlags) As CredUIReturnCodes
            End Function

            <DllImport("credui.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
            Friend Shared Function CredUIParseUserNameW(ByVal userName As String, ByVal user As StringBuilder, ByVal userMaxChars As Integer, ByVal domain As StringBuilder, ByVal domainMaxChars As Integer) As CredUIReturnCodes
            End Function

            <DllImport("credui.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
            Friend Shared Function CredUIConfirmCredentialsW(ByVal targetName As String, ByVal confirm As Boolean) As CredUIReturnCodes
            End Function

            Friend Enum CredUIReturnCodes
                NO_ERROR = 0
                ERROR_CANCELLED = 1223
                ERROR_NO_SUCH_LOGON_SESSION = 1312
                ERROR_NOT_FOUND = 1168
                ERROR_INVALID_ACCOUNT_NAME = 1315
                ERROR_INSUFFICIENT_BUFFER = 122
                ERROR_INVALID_PARAMETER = 87
                ERROR_INVALID_FLAGS = 1004
            End Enum

            Friend Structure CredUIInfo
                Friend Sub New(ByVal owner As IntPtr, ByVal caption As String, ByVal message As String, ByVal banner As Image)
                    Me.cbSize = Marshal.SizeOf(GetType(CredUIInfo))
                    Me.hwndParent = owner
                    Me.pszCaptionText = caption
                    Me.pszMessageText = message

                    If banner IsNot Nothing Then
                        Me.hbmBanner = New Bitmap(banner, Win32Native.CREDUI_BANNER_WIDTH, Win32Native.CREDUI_BANNER_HEIGHT).GetHbitmap()
                    Else
                        Me.hbmBanner = IntPtr.Zero
                    End If
                End Sub

                Friend cbSize As Integer
                Friend hwndParent As IntPtr
                <MarshalAs(UnmanagedType.LPWStr)> _
                Friend pszMessageText As String
                <MarshalAs(UnmanagedType.LPWStr)> _
                Friend pszCaptionText As String
                Friend hbmBanner As IntPtr
            End Structure
        End Class

#End Region
    End Class
#End Region
End Namespace
