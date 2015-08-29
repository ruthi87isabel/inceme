Imports System.Configuration
Imports System.Configuration.Install

Public Class conexion
    Dim bd As String
    Dim server As String
    Dim user As String
    Dim password As String
    Dim cstring As String
    Dim connectionStringName As String = "centro_medico.My.MySettings.CMConnectionString"
    Public Sub New()
        Me.getConnectionString()
    End Sub

    Public Property basededatos As String
        Get
            Return bd
        End Get
        Set(value As String)
            bd = value
        End Set
    End Property
    Public Property servidor As String
        Get
            Return server
        End Get
        Set(value As String)
            server = value
        End Set
    End Property
    Public Property usuario As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property
    Public Property clave As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property


    Public ReadOnly Property connectionString() As String
        Get
            Return cstring
        End Get
        
    End Property



    Public Sub guardar()
        Me.setConnectionString()
    End Sub

    Private Sub getConnectionString()
        Dim a = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim valores() As String
        For Each o As ConnectionStringSettings In a.ConnectionStrings.ConnectionStrings
            If o.Name = connectionStringName Then
                valores = Split(o.ConnectionString, ";")
                For Each v As String In valores
                    If v.Contains("Data Source") Then
                        server = Split(v, "=")(1)
                    End If
                    If v.Contains("Initial Catalog") Then
                        bd = Split(v, "=")(1)
                    End If
                    If v.Contains("User") Then
                        user = Split(v, "=")(1)
                    End If
                    If v.Contains("Password") Then
                        password = Split(v, "=")(1)
                    End If
                Next
            End If

        Next
        'a.Save(ConfigurationSaveMode.Minimal)
    End Sub

    Private Sub setConnectionString()
        'La estructura del connection string es Data Source=xxxx;Initial Catalog=xxxxxxx;User id=sa;Password=xxxxxx
        Dim strCS As String
        Dim errores As String = ""
        If server.Trim.Length = 0 Then
            errores = errores & " servidor "
        End If
        If bd.Trim.Length = 0 Then
            errores = errores & " base de datos "
        End If
        If user.Trim.Length = 0 Then
            errores = errores & " usuario "
        End If
        If password.Trim.Length = 0 Then
            errores = errores & " contraseña "
        End If

        If errores.Trim.Length = 0 Then
            strCS = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3}", server, bd, user, password)
            Dim a = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            For Each o As ConnectionStringSettings In a.ConnectionStrings.ConnectionStrings
                If o.Name = connectionStringName Then
                    o.ConnectionString = strCS
                End If
            Next
            a.save(ConfigurationSaveMode.Minimal)
            cstring = strCS
        Else
            Globales.ErrorMsg(New System.Exception("Errores al setear la conexion"), "Los siguientes datos no están bien configurados (" & errores & ")")
        End If

    End Sub


End Class
