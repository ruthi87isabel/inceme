Imports System.Net
Imports System.IO
Imports System.Globalization

Public Class SMSSender


    Public MaxDestinationsPerSending = 2
    Public PricePerSMS As Double = 1

    'Private uri As Uri = New System.Uri("http://localhost")
    Private uri As Uri = New System.Uri("http://api.mensatek.com/v4/enviar.php")

    Private correoMensatek As String
    Private password As String

    Dim client As WebClient = New WebClient()
    Public Event SendCompleted(ByVal sender As Object, e As System.Net.OpenReadCompletedEventArgs, ByVal info As SMSResponse)
    Public Event SendingProgress(ByVal sender As Object, msg As String, percent As Double)
    Public Event SendingError(ByVal msg As String, e As Exception)
    Public Event SendingCancelled()


    Public Event DameCreditoAsyncCompleted(ByVal saldo As Double)


    Private Destinations As New List(Of SMSWrapper)
    Private current As Integer = 0




#Region "Public Sub New(ByVal correoMensatek As String, ByVal passwd As String, ByVal remitente As String, _"
    Public Sub New(ByVal correoMensatek As String, ByVal passwd As String, ByVal remitente As String)

        Me.correoMensatek = correoMensatek
        Me.password = passwd

        ' No es necesario pero conviene siempre hacer creer que eres Internet explorer 
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
        ' Ahora se añaden los parámetros de la petición
        client.QueryString.Add("Correo", correoMensatek)
        client.QueryString.Add("Passwd", passwd)
        client.QueryString.Add("Remitente", remitente)

        client.QueryString.Add("Destinatarios", "")
        'Destinations = destinatarios

        client.QueryString.Add("Mensaje", "")

        client.QueryString.Add("Flash", "0")
        client.QueryString.Add("Report", "0")
        client.QueryString.Add("Descuento", "0")
        '// Añadir todos los parámetros que se necesiten en la petición
        '//.........  Todos los parámetros necesarios de la API HTTP facilitada en PDF 
        '// con client.QueryString.Add("....", "...."); 

        AddHandler client.OpenReadCompleted, New OpenReadCompletedEventHandler(AddressOf openReadComplete)
    End Sub
#End Region


    Public Sub Enviar(ByVal smsList As List(Of SMSWrapper))
        Destinations = smsList
        current = 0
        Try
           
            'client.
            client.QueryString("Mensaje") = System.Web.HttpUtility.UrlEncode(Destinations(current).Mensaje)
            client.QueryString("Destinatarios") = Destinations(current).Destino
            client.OpenReadAsync(uri)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("ERROR:" & ex.Message)
        End Try

    End Sub

    Public Sub Cancelar()
        client.CancelAsync()
    End Sub


    Private Sub openReadComplete(sender As Object, e As System.Net.OpenReadCompletedEventArgs)

        'Threading.Thread.Sleep(500)

        If e.Cancelled Then
            RaiseEvent SendingCancelled()
            Return
        End If

        If e.Error Is Nothing Then
            Dim Data As Stream = e.Result
            Dim reader As StreamReader = New StreamReader(Data)
            Dim s As String = reader.ReadToEnd()
            Data.Close()
            reader.Close()

            Dim res As SMSResponse = ParseaResponse(s)

            If res.Res_Número > 0 Then
                If current = Destinations.Count - 1 Then
                    RaiseEvent SendingProgress(Me, "Enviado 100%", 1)
                    res.Res_Número = Destinations.Count
                    RaiseEvent SendCompleted(sender, e, res)
                Else

                    'Evento de progreso
                    Dim percent As Double = (current + 1) / Destinations.Count

                    RaiseEvent SendingProgress(Me, "Enviado " & Math.Round(percent * 100, 2) & "%", percent)

                    'Proseguir con la cola de envio
                    current += 1
                    Try

                        'client.
                        client.QueryString("Destinatarios") = Destinations(current).Destino
                        client.QueryString("Mensaje") = System.Web.HttpUtility.UrlEncode(Destinations(current).Mensaje)
                        client.OpenReadAsync(uri)

                    Catch ex As Exception
                        System.Windows.Forms.MessageBox.Show("ERROR:" & ex.Message)
                    End Try

                End If
            Else

                If res.Res_Número = -1 Then
                    RaiseEvent SendingError("Error de autenticación, revise sus credenciales en la configuracion de usuario.", e.Error)
                End If

                If res.Res_Número = -2 Then
                    RaiseEvent SendingError("Crédito insuficiente. Contacte con nuestras oficinas para su recarga", e.Error)
                End If
                If res.Res_Número = -3 Then
                    RaiseEvent SendingError("Error en los datos de la llamada. ", e.Error)
                End If
                RaiseEvent SendingError("ERROR", e.Error)
            End If
        Else
            RaiseEvent SendingError("ERROR", e.Error)
        End If
    End Sub



    Private Function ParseaResponse(ByVal response As String) As SMSResponse
        Dim res As New SMSResponse()
        Try
            Dim cads() As String = response.Split(vbCr)

            res.Res_Número = Integer.Parse(cads(0).Split(":")(1))
            res.Msgid_identificador = Integer.Parse(cads(1).Split(":")(1))

            Dim culture As CultureInfo = New CultureInfo("es-ES")
            res.Cred_Número = Double.Parse(cads(2).Split(":")(1), culture.NumberFormat)
        Catch ex As Exception
            'Por defecto
            res.Res_Número = Destinations.Count
            res.Cred_Número = DameCredito()
        End Try
        
        Return res
    End Function

    Public Function DameCredito() As Double
        Try
            Dim baseurl As String = "http://api.mensatek.com/v4/creditos.php?Correo=" & Me.correoMensatek & "&Passwd=" & password
            Dim Data As Stream = client.OpenRead(baseurl)
            Dim reader As StreamReader = New StreamReader(Data)
            Dim s As String = reader.ReadToEnd()
            Data.Close()
            reader.Close()

            Dim culture As CultureInfo = New CultureInfo("es-ES")
            Return Double.Parse(s.Split(":")(1), culture.NumberFormat)

        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Sub DameCreditoAsync()
        Try
            Dim clientCredito As New WebClient
            Dim uriCred As New Uri("http://api.mensatek.com/v4/creditos.php?Correo=" & Me.correoMensatek & "&Passwd=" & password)
            AddHandler clientCredito.OpenReadCompleted, AddressOf subDameCreditoAsyncCompleted
            clientCredito.OpenReadAsync(uriCred)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub subDameCreditoAsyncCompleted(sender As Object, e As OpenReadCompletedEventArgs)
        If e.Error Is Nothing Then

            Try
                Dim Data As Stream = e.Result
                Dim reader As StreamReader = New StreamReader(Data)
                Dim s As String = reader.ReadToEnd()
                Data.Close()
                reader.Close()

                Dim culture As CultureInfo = New CultureInfo("es-ES")
                RaiseEvent DameCreditoAsyncCompleted(Double.Parse(s.Split(":")(1), culture.NumberFormat))
            Catch ex As Exception
                RaiseEvent DameCreditoAsyncCompleted(-1)
            End Try
            
        End If
    End Sub


    Public Function PresupuestoDe(cantMensajes As Integer) As Double
        Return cantMensajes * PricePerSMS
    End Function


   

End Class

Public Class SMSResponse
    Public Res_Número As Integer
    Public Msgid_identificador As Integer
    Public Cred_Número As Double

End Class

Public Class SMSWrapper
    Public Destino As String
    Public Mensaje As String
    Public Paciente As Object
End Class
