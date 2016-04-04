Imports System.Net
Imports System.Net.Mail
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms
Imports System.IO
Imports System.Net.Mime
Imports System.Text.RegularExpressions

Namespace Mail

    Public Class MailSender
        Dim log As New clsLog
        Public Cliente As SmtpClient
        Public Event SendCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs, ByVal info As MessageWrapper)
        Public Event SendProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs, ByVal info As MessageWrapper, ByVal percent As Double)

        Private emailQueue As List(Of MessageWrapper)
        Private currentEmail = 0

        Public Sub New(ByVal host As String, ByVal port As Integer, ByVal user As String, ByVal password As String)

            Cliente = New System.Net.Mail.SmtpClient(host, port)
            Cliente.Credentials = New NetworkCredential(user, password)
        End Sub

        Public Shared Function isEmail(inputEmail As String) As Boolean
            Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
            Dim emailAddressMatch As Match = Regex.Match(inputEmail.Trim(), pattern)
            If emailAddressMatch.Success Then
                Return True
            Else
                Return False
            End If
        End Function


    

        Public Sub SendMailAsync(ByVal message As MailMessage, ByRef UserToken As Object)
            AddHandler Cliente.SendCompleted, AddressOf SendingCompleted
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
            'message.Headers.Add("Disposition-Notification-To", message.From.Address)
            Dim wrapper As New MessageWrapper()
            wrapper.Message = message
            wrapper.UserToken = UserToken
            Try
                Cliente.SendAsync(message, wrapper)
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
                Dim async As New System.ComponentModel.AsyncCompletedEventArgs(ex, False, wrapper)
                RaiseEvent SendCompleted(Me, async, wrapper)
            End Try

        End Sub
        
        Public Sub SendMailAsync(ByVal emailQueue As List(Of MessageWrapper))
            If emailQueue.Count = 0 Then
                MessageBox.Show("Lista de Mensajes Vacia")
                Return
            End If

            Me.emailQueue = emailQueue
            AddHandler Cliente.SendCompleted, AddressOf SendingPartialCompleted

            currentEmail = 0
            Try
                Cliente.SendAsync(emailQueue(currentEmail).Message, emailQueue(currentEmail))

            Catch ex As Exception

                MessageBox.Show("ERROR Enviando correos")
                Try
                    Cliente.SendAsyncCancel()
                Catch ex2 As Exception
                    MsgBox(ex2.ToString)
                End Try

            End Try

        End Sub

        Public Sub SendMailReportAsync(ByVal message As MailMessage, ByVal report As LocalReport, ByRef UserToken As Object)

            Dim att As New Attachment(ExportReport(report))
            message.Attachments.Add(att)

            SendMailAsync(message, UserToken)
        End Sub

#Region "Private Function ExportReport(ByVal report As LocalReport) As String"
        Private Function ExportReport(ByVal report As LocalReport) As String
            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim filenameExtension As String = Nothing


            Dim bytes As Byte() = report.Render("PDF", Nothing, mimeType, encoding, filenameExtension, streamids, warnings)

            Dim filename As String = Path.Combine(Path.GetTempPath(), "report_" & Date.Now.ToString("dd-MM-yyyy__HH-mm") & ".pdf")
            Dim fs As New FileStream(filename, FileMode.Create)
            Try
                fs.Write(bytes, 0, bytes.Length)
            Catch ex As Exception
                MessageBox.Show("Error creado reporte " & filename)
            Finally
                fs.Close()
                'Try
                '    File.Delete(filename)
                'Catch ex As Exception
                'End Try
            End Try

            Return filename
        End Function
#End Region

        Public Sub SendingCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
            If Not e.Cancelled Then
                If e.Error Is Nothing Then
                    'No fue cancelada y no hubo error

                Else
                    'No fue cancelada y SI HUBO ERROR
                    'MessageBox.Show("Error:" & e.Error.Message & e.Error.StackTrace)
                End If
            Else
                'Fue cancelada
            End If
            RaiseEvent SendCompleted(sender, e, e.UserState)
        End Sub

        Public Sub Cancel()
            Cliente.SendAsyncCancel()
        End Sub

        Private Sub SendingPartialCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
            'Cliente.SendAsync(emailQueue(currentEmail), Me)
            log.FileName = Application.StartupPath & "\log.txt"
            log.Log("*** " & Now.ToString & " - enviado email a " & e.UserState.message.To.ToString)

            If Not e.Cancelled Then
                If e.Error Is Nothing Then
                    'No fue cancelada y no hubo error
                    log.Log(vbTab & "no se han detectado errores enviando email ")
                    If currentEmail = emailQueue.Count - 1 Then
                        RaiseEvent SendProgressChanged(sender, e, e.UserState, 1)
                        RaiseEvent SendCompleted(sender, e, e.UserState)
                    Else

                        Dim percent As Double = (currentEmail + 1) / emailQueue.Count
                        RaiseEvent SendProgressChanged(sender, e, e.UserState, percent)
                        currentEmail = currentEmail + 1


                        Cliente.SendAsync(emailQueue(currentEmail).Message, emailQueue(currentEmail))
                    End If

                Else
                    log.Log(vbTab & "error enviado " & e.Error.Message & vbCrLf & e.Error.StackTrace)
                    'No fue cancelada y SI HUBO ERROR
                    'MessageBox.Show("Error:" & e.Error.Message & e.Error.StackTrace)
                End If
            Else
                'Fue cancelada
                log.Log(vbTab & "envio cancelado")
            End If
            log.Log(vbTab & "Fin del envio a " & e.UserState.message.To.ToString)
        End Sub

    End Class

    Public Class MessageWrapper
        Public Message As MailMessage
        Public UserToken As Object
    End Class

End Namespace


