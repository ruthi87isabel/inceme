﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.1434
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.1434.
'
Namespace UpdatesServer
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1434"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Service
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GetServerAppManifestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetUpdateUrlOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.UpdaterClient.My.MySettings.Default.UpdaterClient_UpdatesServer_Service
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event GetServerAppManifestCompleted As GetServerAppManifestCompletedEventHandler
        
        '''<remarks/>
        Public Event GetUpdateUrlCompleted As GetUpdateUrlCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetServerAppManifest", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetServerAppManifest(ByVal AppFolderName As String) As FileItem()
            Dim results() As Object = Me.Invoke("GetServerAppManifest", New Object() {AppFolderName})
            Return CType(results(0),FileItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetServerAppManifestAsync(ByVal AppFolderName As String)
            Me.GetServerAppManifestAsync(AppFolderName, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetServerAppManifestAsync(ByVal AppFolderName As String, ByVal userState As Object)
            If (Me.GetServerAppManifestOperationCompleted Is Nothing) Then
                Me.GetServerAppManifestOperationCompleted = AddressOf Me.OnGetServerAppManifestOperationCompleted
            End If
            Me.InvokeAsync("GetServerAppManifest", New Object() {AppFolderName}, Me.GetServerAppManifestOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetServerAppManifestOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetServerAppManifestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetServerAppManifestCompleted(Me, New GetServerAppManifestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUpdateUrl", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetUpdateUrl(ByVal AppFolderName As String, ByVal remoteFiles() As FileItem) As UpdateInfo
            Dim results() As Object = Me.Invoke("GetUpdateUrl", New Object() {AppFolderName, remoteFiles})
            Return CType(results(0),UpdateInfo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetUpdateUrlAsync(ByVal AppFolderName As String, ByVal remoteFiles() As FileItem)
            Me.GetUpdateUrlAsync(AppFolderName, remoteFiles, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetUpdateUrlAsync(ByVal AppFolderName As String, ByVal remoteFiles() As FileItem, ByVal userState As Object)
            If (Me.GetUpdateUrlOperationCompleted Is Nothing) Then
                Me.GetUpdateUrlOperationCompleted = AddressOf Me.OnGetUpdateUrlOperationCompleted
            End If
            Me.InvokeAsync("GetUpdateUrl", New Object() {AppFolderName, remoteFiles}, Me.GetUpdateUrlOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetUpdateUrlOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetUpdateUrlCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetUpdateUrlCompleted(Me, New GetUpdateUrlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1434"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class FileItem
        
        Private fileNameField As String
        
        Private sizeField As Long
        
        Private mD5Field As String
        
        Private typeField As FileType
        
        '''<comentarios/>
        Public Property FileName() As String
            Get
                Return Me.fileNameField
            End Get
            Set
                Me.fileNameField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property Size() As Long
            Get
                Return Me.sizeField
            End Get
            Set
                Me.sizeField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property MD5() As String
            Get
                Return Me.mD5Field
            End Get
            Set
                Me.mD5Field = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property Type() As FileType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1434"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Public Enum FileType
        
        '''<comentarios/>
        Directory
        
        '''<comentarios/>
        File
    End Enum
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1434"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdateInfo
        
        Private publishedVersionField As String
        
        Private updateZipURLField As String
        
        Private sizeInBytesField As Long
        
        Private isUpdateAvailableField As Boolean
        
        '''<comentarios/>
        Public Property PublishedVersion() As String
            Get
                Return Me.publishedVersionField
            End Get
            Set
                Me.publishedVersionField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property UpdateZipURL() As String
            Get
                Return Me.updateZipURLField
            End Get
            Set
                Me.updateZipURLField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property SizeInBytes() As Long
            Get
                Return Me.sizeInBytesField
            End Get
            Set
                Me.sizeInBytesField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property IsUpdateAvailable() As Boolean
            Get
                Return Me.isUpdateAvailableField
            End Get
            Set
                Me.isUpdateAvailableField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1434")>  _
    Public Delegate Sub GetServerAppManifestCompletedEventHandler(ByVal sender As Object, ByVal e As GetServerAppManifestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1434"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetServerAppManifestCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As FileItem()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),FileItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1434")>  _
    Public Delegate Sub GetUpdateUrlCompletedEventHandler(ByVal sender As Object, ByVal e As GetUpdateUrlCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1434"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetUpdateUrlCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UpdateInfo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UpdateInfo)
            End Get
        End Property
    End Class
End Namespace
