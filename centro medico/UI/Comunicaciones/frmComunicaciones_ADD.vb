Imports GoltraTools.Mail
Imports GoltraTools

Public Class frmComunicaciones_ADD
    Public TipoComunicacion As Globales.ComunicacionTipo = Globales.ComunicacionTipo.EMAIL

    Dim mailer As GoltraTools.Mail.MailSender
    Dim smssender As GoltraTools.SMSSender
    Dim costo As Double = 0
    Dim saldo As Double = 0

    ''' <summary>
    ''' Es para uso de la ficha paciente, cuando los mensajes son para un usuario unico y fijo
    ''' </summary>
    ''' <remarks></remarks>
    Public UsarDestinatarioUnico As Boolean = False

    Public Destinatarios As New List(Of PACIENTE)


    Dim emailQueue As New List(Of MessageWrapper)
    Dim smsQueue As New List(Of System.Net.Mail.MailMessage)



#Region "Private Sub frmComunicaciones_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load"
    Private Sub frmComunicaciones_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboTipoComunicacion.Items.AddRange([Enum].GetNames(GetType(Globales.ComunicacionTipo)))


        If Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPVerificado>.Value = "false" Then
            MessageBox.Show("La cuenta de correo de sistema no ha sido propiamente verificada, no podrá efectuarse el envio de correos")
            Me.Close()
        End If

        If UsarDestinatarioUnico Then
            If Destinatarios.Count = 0 Then
                MessageBox.Show("No ha especificado el destinatario unico")
                Me.Close()
            End If

            If Destinatarios(0).EMAIL Is Nothing Then
                MessageBox.Show("El email destinatario no existe")
                Me.Close()
            End If

            Dim emailValido As Boolean = GoltraTools.RegexUtilities.IsValidEmail(Destinatarios(0).EMAIL)
            If Not emailValido Then
                MessageBox.Show(String.Format("El email destinatario '{0}' no es válido", Destinatarios(0).EMAIL))
            End If

            Dim mobileValido As Boolean = False
            If Destinatarios(0).MOVIL Is Nothing Then
                MessageBox.Show("El móvil está vacio, no podrá enviar sms")
                mobileValido = False
            Else
                mobileValido = GoltraTools.RegexUtilities.CheckPhoneNumber(Destinatarios(0).MOVIL)
                If Not mobileValido Then
                    MessageBox.Show(String.Format("El número de móvil '{0}' no es válido , no podrá enviar sms", Destinatarios(0).MOVIL))
                End If
            End If
            If Not emailValido And Not mobileValido Then
                MessageBox.Show(String.Format("El destinatario {0} no tiene ni email ni móvil válidos, se abortará la operación", Destinatarios(0).NombreCompleto))
                Me.Close()
            End If

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
    End Sub


#End Region


    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click

        If listDestinos.Items.Count = 0 Then
            MessageBox.Show("No hay destinatarios")
            Return
        End If

        If comboTipoComunicacion.SelectedItem = "EMAIL" Then
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

                For Each item As ListViewItem In listDestinos.Items
                    Dim message As New System.Net.Mail.MailMessage()

                    message.From = New System.Net.Mail.MailAddress(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value)


                    Dim paciente As PACIENTE = item.Tag

                    Try
                        message.To.Add(paciente.EMAIL)
                    Catch ex As FormatException
                        MessageBox.Show("El email: " & paciente.EMAIL & " del paciente " & paciente.NombreCompleto & " es incorrecto, se cancelara el envio")
                        lnkCancelar_LinkClicked(Nothing, Nothing)
                        Return
                    End Try
                    message.Subject = Tokenize(txtAsunto.Text, paciente)
                    message.Body = Tokenize(txtMessage.Text, paciente)

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

            Dim smsList As New List(Of SMSWrapper)

            'Dim destinatarios As New List(Of String)
            For Each item As ListViewItem In listDestinos.Items
                Dim paciente As PACIENTE = item.Tag

                If Not paciente.MOVIL Is Nothing Then
                    Dim sms As New SMSWrapper()
                    sms.Mensaje = Tokenize(txtMessage.Text & vbCrLf & vbCrLf & txtPieSMS.Text, paciente)
                    sms.Destino = paciente.MOVIL.Replace("+", "").Replace("-", "")
                    sms.Paciente = paciente
                    smsList.Add(sms)
                End If
            Next



            smssender = New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
                                                  Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
                                                  Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value.Replace("+", "").Replace("-", ""))


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

            AddHandler smssender.SendCompleted, AddressOf SmsSendingCompleted
            AddHandler smssender.SendingError, AddressOf SmsSendingError
            AddHandler smssender.SendingProgress, AddressOf SmsSendingProgress

            Dim tipoEstado As Boolean = comboTipoComunicacion.Enabled
            SetEnabled(False)
            comboTipoComunicacion.Enabled = tipoEstado

            pnl_Loading.Visible = True
            pnl_Loading.Enabled = True
            lbl_Loading.Text = "Enviando sms..."
            smssender.Enviar(smsList)

        End If

    End Sub


    Private Sub SmsSendingCompleted(sender As Object, e As Net.OpenReadCompletedEventArgs, res As SMSResponse)

        If res.Res_Número > 0 Then
            MessageBox.Show(res.Res_Número & " mensaje(s) enviado(s), saldo restante: " & res.Cred_Número)
            For Each item As ListViewItem In listDestinos.Items
                Dim com As New Comunicacion()
                com.Contenido = txtMessage.Text
                com.eTipo = 2
                com.FechaEnvio = Date.Now
                Dim paciente As PACIENTE = item.Tag
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

#Region "Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click"
    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        For Each item As ListViewItem In listDestinos.SelectedItems
            Destinatarios.Remove(item.Tag)
        Next
        comboTipoComunicacion_SelectedIndexChanged(Nothing, Nothing)
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
    Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked
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

#Region "Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click"
    Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click
        Dim context As New CMLinqDataContext
        'Dim frm As form_pacientes = New form_pacientes()
        Dim frm As New frmPacientesListado()
        frm.Modo = Globales.ModoParaFormas.Seleccion

        If frm.ShowDialog() = DialogResult.OK Then

            If comboTipoComunicacion.SelectedItem = "EMAIL" Then

                If String.IsNullOrEmpty(frm.Paciente.EMAIL) Then
                    MessageBox.Show("No tiene EMAIL")
                    Return
                End If

                Dim paciente As PACIENTE = (From p In context.PACIENTEs _
                                           Where p.CPACIENTE = frm.Paciente.CPACIENTE).SingleOrDefault()
                'item.Text = paciente.NombreCompleto & " <" & paciente.EMAIL & ">"
                'item.Tag = paciente

                If Not Destinatarios.Contains(paciente) Then
                    Destinatarios.Add(paciente)
                End If

                'If Not listDestinos.Items.Contains(item) Then
                '    listDestinos.Items.Add(item)
                'End If
            Else
                If frm.Paciente.MOVIL Is Nothing Then
                    MessageBox.Show("No tiene MOVIL")
                    Return
                End If

                If frm.Paciente.MOVIL.Trim().Length = 0 Then
                    MessageBox.Show("No tiene Movil")
                    Return
                End If


                Dim paciente As PACIENTE = (From p In context.PACIENTEs _
                                           Where p.CPACIENTE = frm.Paciente.CPACIENTE).SingleOrDefault()

                If Not Destinatarios.Contains(paciente) Then
                    Destinatarios.Add(paciente)
                End If

            End If
        End If
        comboTipoComunicacion_SelectedIndexChanged(Nothing, Nothing)
    End Sub
#End Region

#Region "Private Sub comboTipoComunicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTipoComunicacion.SelectedIndexChanged"
    Private Sub comboTipoComunicacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTipoComunicacion.SelectedIndexChanged
        listDestinos.Items.Clear()

        If comboTipoComunicacion.SelectedItem = "EMAIL" Then
            txtDesde.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value
            txtAsunto.Visible = True
            txtMessage.MaxLength = Integer.MaxValue

            txtPieSMS.Visible = False
            lblPieSms.Visible = False
            lblSaldo.Visible = False

            For Each p As PACIENTE In Destinatarios
                Dim item As New ListViewItem()
                If Not p.EMAIL Is Nothing Then
                    If p.EMAIL.Trim.Length > 0 Then
                        item.Text = p.NombreCompleto & " <" & p.EMAIL & ">"
                        item.Tag = p
                        listDestinos.Items.Add(item)
                    End If
                End If

            Next

        Else
            'SMS

            Dim tmp As New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value.Replace("+", "").Replace("-", ""))

            AddHandler tmp.DameCreditoAsyncCompleted, AddressOf DameCreditoAsycCompletado

            txtDesde.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value
            txtAsunto.Visible = False
            txtPieSMS.Visible = True
            lblPieSms.Visible = True

            txtMessage.MaxLength = 160 - txtPieSMS.Text.Length - 2
            txtMessage.Text = txtMessage.Text.Substring(0, Math.Min(txtMessage.Text.Length, txtMessage.MaxLength))

            For Each p As PACIENTE In Destinatarios
                Dim item As New ListViewItem()
                If Not p.MOVIL Is Nothing Then
                    If p.MOVIL.Trim.Length > 0 Then
                        item.Text = p.NombreCompleto & " <" & p.MOVIL & ">"
                        item.Tag = p
                        listDestinos.Items.Add(item)
                    End If
                End If
            Next
            lblSaldo.Visible = True
            lblSaldo.Text = "Saldo: (cargando...)"
            tmp.DameCreditoAsync()
            CuentaCaracteres()
        End If


        lblContador.Text = txtMessage.Text.Length & "/" & txtMessage.MaxLength & " caracteres"
        lblDestinatariosTotal.Text = listDestinos.Items.Count
    End Sub
#End Region

    Private Sub DameCreditoAsycCompletado(saldo As Double)
        Me.saldo = saldo
        lblSaldo.Text = "Saldo: " & saldo
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

        End Try
    End Sub


    Private Function Tokenize(ByVal message As String, ByVal paciente As PACIENTE)

        Dim result As String = message

        If Not paciente.NOMBRE Is Nothing Then
            result = result.Replace("{NOMBRE}", paciente.NOMBRE.Substring(0, Math.Min(paciente.NOMBRE.Length, 15)))
        Else
            result = result.Replace("{NOMBRE}", "")
        End If

        If Not paciente.APELLIDO1 Is Nothing Then
            result = result.Replace("{APELLIDO1}", paciente.APELLIDO1.Substring(0, Math.Min(paciente.APELLIDO1.Length, 15)))
        Else
            result = result.Replace("{APELLIDO1}", "")
        End If

        If Not paciente.APELLIDO2 Is Nothing Then
            result = result.Replace("{APELLIDO2}", paciente.APELLIDO2.Substring(0, Math.Min(paciente.APELLIDO2.Length, 15)))
        Else
            result = result.Replace("{APELLIDO2}", "")
        End If

        If Not paciente.NombreSMS Is Nothing Then
            result = result.Replace("{NOMBRESMS}", paciente.NombreSMS.Substring(0, Math.Min(paciente.NombreSMS.Length, 25)))
        Else
            result = result.Replace("{NOMBRESMS}", "")
        End If

        Return result
    End Function

#Region " Private Sub btnPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnPlantilla.Click"
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
#End Region



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

End Class


Partial Public Class PACIENTE
    Public ReadOnly Property NombreCompleto() As String
        Get
            If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
                Return NombreCompletoA1A2Nombre()
            Else
                Return (Me.NOMBRE & " " & Me.APELLIDO1 & " " & Me.APELLIDO2).Trim()
            End If
        End Get
    End Property

    Public Function NombreSMS() As String

        Dim str As String = ("" + Me.NOMBRE).Trim()

        If Not Me.APELLIDO1 Is Nothing Then
            If Me.APELLIDO1.Length > 0 Then
                str = str + " " + Me.APELLIDO1.Substring(0, 1) + "."
            End If
        End If

        If Not Me.APELLIDO2 Is Nothing Then
            If Me.APELLIDO2.Length > 0 Then
                str = str + " " + Me.APELLIDO2.Substring(0, 1) + "."
            End If
        End If

        Return str
    End Function

    Public Function NombreCompletoA1A2Nombre() As String
        Return (Me.APELLIDO1 & " " & Me.APELLIDO2 & " " & Me.NOMBRE).Trim()
    End Function

    Public ReadOnly Property Edad() As Integer
        Get
            Dim today As Date = DateTime.Today
            Dim age As Integer = 0
            If FECHAN.HasValue Then
                age = today.Year - FECHAN.Value.Year
                If FECHAN.Value > today.AddYears(-age) Then
                    age = age - 1
                End If
            End If

            Return age
        End Get
    End Property
End Class