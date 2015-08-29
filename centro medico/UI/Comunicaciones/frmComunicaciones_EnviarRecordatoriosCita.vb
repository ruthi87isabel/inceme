Imports GoltraTools.Mail
Imports GoltraTools
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frmComunicaciones_EnviarRecordatoriosCita

    Public TipoComunicacion As Globales.ComunicacionTipo = Globales.ComunicacionTipo.EMAIL

    Dim mailer As GoltraTools.Mail.MailSender
    Dim smssender As GoltraTools.SMSSender
    Dim costo As Double = 0
    Dim saldo As Double = 0

    Dim emailQueue As New List(Of MessageWrapper)
    Dim smsQueue As New List(Of System.Net.Mail.MailMessage)

    Public Citas As New List(Of CITA)
    Private CitasOriginales As List(Of CITA)

    Public CitasRecordarEMAIL As Dictionary(Of Integer, CITA) = New Dictionary(Of Integer, CITA)
    Public CitasRecordarSMS As Dictionary(Of Integer, CITA) = New Dictionary(Of Integer, CITA)



    Private Sub dtp_fi_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtp_fi.ValueChanged
        CargaDatos()
    End Sub

    Private Sub dtp_ff_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtp_ff.ValueChanged
        CargaDatos()
    End Sub

    Public Sub CargaDatos()
        If Citas Is Nothing Or Citas.Count = 0 Then
            Dim context As New CMLinqDataContext

            Citas = (From c As CITA In context.CITAs _
                  Where c.FECHA >= dtp_fi.Value And c.FECHA <= dtp_ff.Value And (c.Eliminado = 0 Or Not c.Eliminado.HasValue)
                  Select c).ToList()
            CITABindingSource.DataSource = Citas
        Else
            CITABindingSource.DataSource = Citas.Where(Function(o) o.FECHA >= dtp_fi.Value And o.FECHA <= dtp_ff.Value And (o.Eliminado = 0 Or Not o.Eliminado.HasValue)).ToList()
        End If

        CitasRecordarEMAIL.Clear()
        CitasRecordarSMS.Clear()

        For Each c As CITA In Citas.Where(Function(o) o.FECHA >= dtp_fi.Value And o.FECHA <= dtp_ff.Value).ToList()
            If Not c.PACIENTE1 Is Nothing Then
                If Not c.PACIENTE1.MOVIL Is Nothing Then
                    CitasRecordarSMS.Add(c.IDCITA, c)
                End If

                If Not c.PACIENTE1.EMAIL Is Nothing Then
                    If GoltraTools.Mail.MailSender.isEmail(c.PACIENTE1.EMAIL) Then
                        CitasRecordarEMAIL.Add(c.IDCITA, c)
                    End If
                End If
            End If
        Next


        lblCantEmails.Text = CitasRecordarEMAIL.Count
        lblCantMoviles.Text = CitasRecordarSMS.Count


    End Sub

    Private Sub frmComunicaciones_EnviarRecordatoriosCita_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Citas.Count = 0 Then
            Dim fi As New DateTime(dtp_fi.Value.Year, dtp_fi.Value.Month, dtp_fi.Value.Day, 0, 0, 0)
            Dim ff As New DateTime(dtp_ff.Value.Year, dtp_ff.Value.Month, dtp_ff.Value.Day, 23, 59, 59)
            dtp_fi.Value = fi
            dtp_ff.Value = ff
        End If


        txtAsunto.Text = "RECORDATORIO DE CITA"
        txtMessage.Text = "Le recordamos que tiene un cita el día {CITAFECHA} a las {CITAHORA}"



        comboTipoComunicacion.Items.AddRange([Enum].GetNames(GetType(Globales.ComunicacionTipo)))


        If Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPVerificado>.Value = "false" Then
            MessageBox.Show("La cuenta de correo no ha sido propiamente verificada, es probable que no pueda efectuarse el envio de correos")
        End If

        mailer = New GoltraTools.Mail.MailSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPServer>.Value, _
                                                Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPort>.Value, _
                                                Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUser>.Value, _
                                                Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPassword>.Value)


        mailer.Cliente.EnableSsl = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUseSSL>.Value

        AddHandler mailer.SendCompleted, AddressOf MailSendingCompleted
        AddHandler mailer.SendProgressChanged, AddressOf MailSendingProgressChanged

        If Not Globales.Configuracion.nombrecomercial Is Nothing Then
            If Globales.Configuracion.nombrecomercial.Trim().Length > 0 Then
                txtPieSMS.Text = "Enviado desde " & Globales.Configuracion.nombrecomercial
            Else
                txtPieSMS.Text = "Enviado desde Clinica"
            End If
        Else
            txtPieSMS.Text = "Enviado desde Clinica"
        End If

        comboTipoComunicacion.SelectedItem = TipoComunicacion.ToString()

        smssender = New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
                                         Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
                                         Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value.Replace("+", "").Replace("-", ""))

        AddHandler smssender.DameCreditoAsyncCompleted, AddressOf DameCreditoAsycCompletado
        AddHandler smssender.SendCompleted, AddressOf SmsSendingCompleted
        AddHandler smssender.SendingError, AddressOf SmsSendingError
        AddHandler smssender.SendingProgress, AddressOf SmsSendingProgress

        lblSaldo.Visible = True
        lblSaldo.Text = "(cargando...)"
        smssender.DameCreditoAsync()
        costo = smssender.PresupuestoDe(CitasRecordarSMS.Count)
        lblCosto.Text = costo

    End Sub

#Region "Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click"
    Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click



        If comboTipoComunicacion.SelectedItem = "EMAIL" Then

            If CitasRecordarEMAIL.Count = 0 Then
                MessageBox.Show("No hay destinatarios validos")
                Return
            End If

            Dim tipoEstado As Boolean = comboTipoComunicacion.Enabled
            SetEnabled(False)
            comboTipoComunicacion.Enabled = tipoEstado
            pnl_Loading.Visible = True
            pnl_Loading.Enabled = True
            lbl_Loading.Text = "Enviando..."

            emailQueue.Clear()
            Try

                If Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value = "" Then
                    MessageBox.Show("No hay remitente definido en la configuracion de usuario")
                    Return
                End If

                For Each Cita As CITA In CitasRecordarEMAIL.Values
                    Dim message As New System.Net.Mail.MailMessage()

                    message.From = New System.Net.Mail.MailAddress(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value)


                    Dim paciente As PACIENTE = Cita.PACIENTE1

                    Try
                        message.To.Add(paciente.EMAIL)
                    Catch ex As FormatException
                        MessageBox.Show("El email: " & paciente.EMAIL & " del paciente " & paciente.NombreCompleto & " es incorrecto, se cancelara el envio")
                        lnkCancelar_LinkClicked(Nothing, Nothing)
                        Return
                    End Try
                    message.Subject = Tokenize(txtAsunto.Text, Cita)
                    message.Body = Tokenize(txtMessage.Text, Cita)

                    Dim wrapper As New MessageWrapper()
                    wrapper.Message = message
                    wrapper.UserToken = paciente
                    emailQueue.Add(wrapper)
                Next
            Catch ex As Exception
                MessageBox.Show("Error annadiendo direcciones")
                lnkCancelar_LinkClicked(Nothing, Nothing)
            End Try

            'mailer.SendMailAsync(Message, Message)
            mailer.SendMailAsync(emailQueue)

        Else
            If CitasRecordarSMS.Count = 0 Then
                MessageBox.Show("No hay destinatarios validos")
                Return
            End If

            Dim smsList As New List(Of SMSWrapper)

            'Dim destinatarios As New List(Of String)
            For Each cita As CITA In CitasRecordarSMS.Values
                Dim paciente As PACIENTE = cita.PACIENTE1

                If Not paciente.MOVIL Is Nothing Then
                    Dim sms As New SMSWrapper()
                    sms.Mensaje = Tokenize(txtMessage.Text & vbCrLf & vbCrLf & txtPieSMS.Text, cita)
                    sms.Destino = paciente.MOVIL.Replace("+", "").Replace("-", "")
                    sms.Paciente = paciente
                    smsList.Add(sms)
                End If
            Next



            'smssender = New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
            '                                      Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
            '                                      Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value.Replace("+", "").Replace("-", ""))


            costo = smssender.PresupuestoDe(smsList.Count)
            'saldo = smssender.DameCredito()
            If saldo = -1 Then saldo = 0
            If costo > saldo Then
                MessageBox.Show("CREDITOS INSUFICIENTES." & vbCrLf & "El costo de envio de " & smsList.Count & " mensajes SMS es " & Math.Round(costo, 2) _
                                & " créditos y su balance es de " & Math.Round(saldo, 2) & " créditos." & vbCrLf & vbCrLf & "Necesita al menos " _
                                & Math.Round(costo - saldo, 2) & " créditos adicionales." & vbCrLf & "Contáctenos.")
                saldo = -1
                Return
            End If


            If MessageBox.Show("Se dispone a enviar este sms a " & smsList.Count & " destinatarios. El costo es de " _
                            & Math.Round(costo, 2) & " créditos, su balance actual es de " & Math.Round(saldo, 2) & " créditos. Desea continuar?", _
                            "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Return
            End If



            Dim tipoEstado As Boolean = comboTipoComunicacion.Enabled
            SetEnabled(False)
            comboTipoComunicacion.Enabled = tipoEstado

            pnl_Loading.Visible = True
            pnl_Loading.Enabled = True
            lbl_Loading.Text = "Enviando sms..."
            smssender.Enviar(smsList)

        End If

    End Sub
#End Region


    Private Sub SmsSendingCompleted(sender As Object, e As Net.OpenReadCompletedEventArgs, res As SMSResponse)

        If res.Res_Número > 0 Then
            MessageBox.Show(res.Res_Número & " mensaje(s) enviado(s), saldo restante: " & res.Cred_Número)
            For Each cita As CITA In CitasRecordarSMS.Values
                Dim com As New Comunicacion()
                com.Contenido = txtMessage.Text
                com.eTipo = 2
                com.FechaEnvio = Date.Now
                Dim paciente As PACIENTE = cita.PACIENTE1
                com.ID_PacienteDestino = paciente.CPACIENTE
                com.ID_UsuarioEmisor = Globales.Usuario.CODIGO
                com.NombrePacienteDestino = paciente.NombreCompleto
                com.NombreUsuarioEmisor = Globales.Usuario.USUARIO
                Globales.Context.Comunicacions.InsertOnSubmit(com)

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Comunicaciones, "SMS", "Nuevo", "De: " & com.NombreUsuarioEmisor & " a " & com.NombrePacienteDestino & " Contenido: " & com.Contenido)

            Next
            Globales.Context.SubmitChanges()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else
            If res.Res_Número = -1 Then
                MessageBox.Show("Error de autenticación, revise sus credenciales en la configuracion de usuario.")
            End If

            If res.Res_Número = -2 Then
                MessageBox.Show("Crédito insuficiente. Contacte con nuestras oficinas para su recarga")
            End If

            If res.Res_Número = -3 Then
                MessageBox.Show("Error en los datos de la llamada. ")
            End If
        End If
    End Sub

#Region "Private Sub SmsSendingError(msg As String, e As Exception)"
    Private Sub SmsSendingError(msg As String, e As Exception)
        MessageBox.Show("Error enviando mensaje")
    End Sub
#End Region

    Private Sub SmsSendingProgress(sender As Object, msg As String, percent As Double)
        lbl_Loading.Text = msg
    End Sub


#Region "Private Sub MailSendingCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs, ByVal info As GoltraTools.Mail.MessageWrapper)"

    Private Sub MailSendingCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs, ByVal info As GoltraTools.Mail.MessageWrapper)

        Dim tipoEstado As Boolean = comboTipoComunicacion.Enabled
        SetEnabled(True)
        comboTipoComunicacion.Enabled = tipoEstado

        If e.Error Is Nothing Then

            If e.Cancelled Then
                MessageBox.Show("Envio cancelado por el usuario!")
                Return
            Else
                MessageBox.Show("Envío correcto")

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If


        Else
            MessageBox.Show("Error:" & e.Error.Message)
        End If
    End Sub

#End Region



#Region "Public Sub SetEnabled(ByVal enabled As Boolean)"
    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
        pnl_Loading.Enabled = Not enabled
        lnkCancelar.Enabled = Not enabled
    End Sub
#End Region


    Delegate Sub BeginInvokeDelegate()
    Delegate Sub BeginInvokeDelegate2(ByVal msg As String)
    Delegate Sub BeginInvokeDelegate3(ByVal enabled As Boolean)

    Private Sub Progreso(ByVal msg As String)
        lbl_Loading.Text = msg
    End Sub

#Region "Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked"
    Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            If comboTipoComunicacion.SelectedItem = "EMAIL" Then
                mailer.Cancel()
            Else
                smssender.Cancelar()
            End If

        Catch ex As Exception

        Finally
            Dim tipoEstado As Boolean = comboTipoComunicacion.Enabled
            SetEnabled(True)
            comboTipoComunicacion.Enabled = tipoEstado
            pnl_Loading.Visible = False
        End Try
    End Sub
#End Region

#Region "Private Sub comboTipoComunicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTipoComunicacion.SelectedIndexChanged"
    Private Sub comboTipoComunicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTipoComunicacion.SelectedIndexChanged

        If comboTipoComunicacion.SelectedItem = "EMAIL" Then
            txtDesde.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value
            txtAsunto.Visible = True
            txtMessage.MaxLength = Integer.MaxValue

            txtPieSMS.Visible = False
            lblPieSms.Visible = False
            lblSaldo.Visible = False

        Else
            'SMS

            'Dim tmp As New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
            '                                     Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
            '                                     Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value.Replace("+", "").Replace("-", ""))

            'AddHandler tmp.DameCreditoAsyncCompleted, AddressOf DameCreditoAsycCompletado

            txtDesde.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value
            txtAsunto.Visible = False
            txtPieSMS.Visible = True
            lblPieSms.Visible = True

            txtMessage.MaxLength = 160 - txtPieSMS.Text.Length - 2
            txtMessage.Text = txtMessage.Text.Substring(0, Math.Min(txtMessage.Text.Length, txtMessage.MaxLength))

            lblSaldo.Visible = True
            lblSaldo.Text = "(cargando...)"
            smssender.DameCreditoAsync()
            CuentaCaracteres()
        End If


        lblContador.Text = txtMessage.Text.Length & "/" & txtMessage.MaxLength & " caracteres"
        'lblCantEmails.Text = listDestinos.Items.Count
    End Sub
#End Region

    Private Sub DameCreditoAsycCompletado(saldo As Double)
        Me.saldo = saldo
        lblSaldo.Text = saldo
    End Sub



    Private Sub MailSendingProgressChanged(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs, info As MessageWrapper, percent As Double)

        Try
            lbl_Loading.Text = "Enviado " & (percent * 100).ToString("n2") & "%"
            'Threading.Thread.Sleep(2000)
            ' For Each item As ListViewItem In listDestinos.Items
            Dim com As New Comunicacion()
            com.Contenido = "ASUNTO: " & info.Message.Subject & vbCrLf & info.Message.Body
            com.eTipo = 1
            com.FechaEnvio = Date.Now
            Dim paciente As PACIENTE = info.UserToken
            com.ID_PacienteDestino = paciente.CPACIENTE
            com.ID_UsuarioEmisor = Globales.Usuario.CODIGO
            com.NombrePacienteDestino = paciente.NombreCompleto
            com.NombreUsuarioEmisor = Globales.Usuario.USUARIO
            Globales.Context.Comunicacions.InsertOnSubmit(com)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Comunicaciones, "EMAIL", "Nuevo", "De: " & com.NombreUsuarioEmisor & " a " & com.NombrePacienteDestino & " Contenido: " & com.Contenido)
            'Next
            Globales.Context.SubmitChanges()

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error enviado email a " & info.UserToken.email)
        End Try
    End Sub


    Private Function Tokenize(ByVal message As String, ByVal cita As CITA)

        Dim result As String = message

        If Not cita.PACIENTE1.NOMBRE Is Nothing Then
            result = result.Replace("{NOMBRE}", cita.PACIENTE1.NOMBRE.Substring(0, Math.Min(cita.PACIENTE1.NOMBRE.Length, 15)))
        Else
            result = result.Replace("{NOMBRE}", "")
        End If

        If Not cita.PACIENTE1.APELLIDO1 Is Nothing Then
            result = result.Replace("{APELLIDO1}", cita.PACIENTE1.APELLIDO1.Substring(0, Math.Min(cita.PACIENTE1.APELLIDO1.Length, 15)))
        Else
            result = result.Replace("{APELLIDO1}", "")
        End If

        If Not cita.PACIENTE1.APELLIDO2 Is Nothing Then
            result = result.Replace("{APELLIDO2}", cita.PACIENTE1.APELLIDO2.Substring(0, Math.Min(cita.PACIENTE1.APELLIDO2.Length, 15)))
        Else
            result = result.Replace("{APELLIDO2}", "")
        End If

        If Not cita.PACIENTE1.NombreSMS Is Nothing Then
            result = result.Replace("{NOMBRESMS}", cita.PACIENTE1.NombreSMS.Substring(0, Math.Min(cita.PACIENTE1.NombreSMS.Length, 25)))
        Else
            result = result.Replace("{NOMBRESMS}", "")
        End If

        If cita.FECHA.HasValue Then
            result = result.Replace("{CITAFECHA}", cita.FECHA.Value.ToShortDateString())
        Else
            result = result.Replace("{CITAFECHA}", "")
        End If

        If cita.HORA.HasValue Then
            result = result.Replace("{CITAHORA}", cita.HORA.Value.ToShortTimeString())
        Else
            result = result.Replace("{CITAHORA}", "")
        End If

        If Not cita.MEDICO Is Nothing Then
            result = result.Replace("{MEDICO}", cita.MEDICO.NOMBRECOMPLETO)
        Else
            result = result.Replace("{MEDICO}", "")
        End If

        Return result
    End Function

    Private Sub txtMessage_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyUp
        CuentaCaracteres()
    End Sub

    Private Sub txtMessage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMessage.TextChanged
        CuentaCaracteres()
    End Sub

    Private Sub CuentaCaracteres()

        Dim texto = txtMessage.Text
        texto = texto.Replace("{NOMBRE}", "0123456789012345678901234")
        texto = texto.Replace("{APELLIDO1}", "0123456789012345678901234")
        texto = texto.Replace("{APELLIDO2}", "0123456789012345678901234")

        texto = texto.Replace("{NOMBRESMS}", "012345678901234567890123456789012345")

        lblContador.Text = texto.Length & "/" & txtMessage.MaxLength & " caracteres"

    End Sub

    Private Sub btnPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnPlantilla.Click
        Dim adapter As New CMDataSetTableAdapters.PLANTILLASTableAdapter()
        Dim plantillas As New CMDataSet.PLANTILLASDataTable()

        adapter.Fill(plantillas)
        Dim _name As String = "Listado de plantillas"

        Dim bindingSource As New BindingSource()
        bindingSource.DataSource = plantillas


        Dim _listados As form_listados = New form_listados("Listado de plantillas", bindingSource, RoleManager.Items.Plantillas_de_texto, True)

        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If Not _listados.Selected = "" Then
            Dim id As Integer = Integer.Parse(_listados.Listado_control.IDSELECCIONADO)

            Globales.Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Globales.Context.PLANTILLAs)
            Dim plantilla As PLANTILLA = (From p In Globales.Context.PLANTILLAs
                                         Where p.CODIGO = id
                                         Select p).SingleOrDefault()
            If Not plantilla Is Nothing Then
                Dim rtf As New RichTextBox()
                Try
                    rtf.Rtf = plantilla.TEXTO
                    txtMessage.Text = rtf.Text

                Catch ex As Exception
                    txtMessage.Text = plantilla.TEXTO
                End Try

                CuentaCaracteres()
            End If
        End If
        GC.Collect()
    End Sub
End Class


