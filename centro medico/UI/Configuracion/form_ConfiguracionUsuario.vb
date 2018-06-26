Imports System.Xml
Imports System.Xml.Linq
Imports GoltraTools

Public Class form_ConfiguracionUsuario
    Dim cambios As Boolean = False

    Private Sub Cargar()

        If Globales.Configuracion.citastyle = "Grafica" Then
            rb_vistagrafica.Checked = True
            Me.rb_vistaclasica.Checked = False
        Else
            rb_vistagrafica.Checked = False
            Me.rb_vistaclasica.Checked = True
        End If
        chb_datosCitaVisualNombrePaciente.Checked = Globales.Configuracion.citapac
        chb_datosCitaVisualMedico.Checked = Globales.Configuracion.citamed
        chb_datosCitaVisualNotas.Checked = Globales.Configuracion.citanote
        chb_datosCitaVisualEspecialidad.Checked = Globales.Configuracion.citaesp
        Me.chb_CodigoPropioPaciente.Checked = Globales.Configuracion.citaCodPropioPac
        Me.nudTamanoTexto.Value = CInt(Globales.Configuracion.TamanoFuente)
        rb_Pacientes_CodigoPropio.Checked = Globales.Configuracion.EnfocarCodigoPropioPaciente
        rb_Paciente_CodPaciente.Checked = Not rb_Pacientes_CodigoPropio.Checked
        chkMostrarListaMedicos.Checked = Globales.Configuracion.CalendarioMostrarListaMedicosPorDefecto

        Select Case Globales.Configuracion.CalendarioTipoFiltro
            Case Configuracion.CalendarioTipoFiltroEnum.NoFiltrar
                chbNoFiltrar.Checked = True

            Case Configuracion.CalendarioTipoFiltroEnum.FiltrarMisCitas
                chb_FiltrarMisCitas.Checked = True

            Case Configuracion.CalendarioTipoFiltroEnum.FiltrarPrimerFacultativo
                chbFiltrarElPrimerFacultativo.Checked = True

        End Select


        'Cargar del xml de configuracion a nivel de usuario

        If Not Globales.Usuario.CONFIGURACIONXML Is Nothing Then
            txtEmail.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value
            txtSMTP_Server.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPServer>.Value
            txtSMTP_Port.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPort>.Value

            txtSMTP_User.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUser>.Value
            txtSMTP_Password.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPassword>.Value
            txtSMS_Server.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Server>.Value
            chk_EMAIL_SSL.Checked = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUseSSL>.Value
            lblEmailVerificado.Text = IIf(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPVerificado>.Value = "true", "Verificado", "No verificado")
            lblEmailVerificado.ForeColor = IIf(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPVerificado>.Value = "true", Color.Green, Color.Red)

            txtSMS_user.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value
            txtSMS_Password.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value
            txtSMS_Remitente.Text = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value
            lblSMSVerificado.Text = IIf(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<SMSVerificado>.Value = "true", "Verificado", "No verificado")
            lblSMSVerificado.ForeColor = IIf(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<SMSVerificado>.Value = "true", Color.Green, Color.Red)

            If Globales.Usuario.CONFIGURACIONXML.<Medico>.<SiUsuarioMedicoUsarPorDefecto>.Value Is Nothing Then
                Globales.Usuario.CONFIGURACIONXML.<Medico>.<SiUsuarioMedicoUsarPorDefecto>.Value = False
            End If
            chkSiUsuarioMedicoUsarPorDefecto.Checked = Globales.Usuario.CONFIGURACIONXML.<Medico>.<SiUsuarioMedicoUsarPorDefecto>.Value
            rbAp1Ap1No.Checked = (Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1")
            rbNomApe1Ape2.Checked = (Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "2")

            NumMedicos.Value = Globales.Configuracion.NumeroColumnaMedico
            NumMedicos.Maximum = (From m In Globales.Context.MEDICOs Where (Not m.Eliminado.HasValue Or m.Eliminado = False)).ToList().Count()

        End If

    End Sub

    Private Sub guardar()
        If rb_vistagrafica.Checked = True Then
            Globales.Configuracion.citastyle = "Grafica"
        Else
            Globales.Configuracion.citastyle = "Clasica"
        End If
        Globales.Configuracion.citapac = chb_datosCitaVisualNombrePaciente.Checked
        Globales.Configuracion.citamed = chb_datosCitaVisualMedico.Checked
        Globales.Configuracion.citanote = chb_datosCitaVisualNotas.Checked
        Globales.Configuracion.citaesp = chb_datosCitaVisualEspecialidad.Checked
        Globales.Configuracion.citaCodPropioPac = Me.chb_CodigoPropioPaciente.Checked
        Globales.Configuracion.TamanoFuente = CInt(Me.nudTamanoTexto.Value)
        Globales.Configuracion.NumeroColumnaMedico = Integer.Parse(NumMedicos.Value.ToString())

        Globales.Configuracion.CalendarioMostrarListaMedicosPorDefecto = chkMostrarListaMedicos.Checked

        Globales.Configuracion.EnfocarCodigoPropioPaciente = rb_Pacientes_CodigoPropio.Checked


        'Filtros
        If chbNoFiltrar.Checked Then
            Globales.Configuracion.CalendarioTipoFiltro = 1
        End If

        If chb_FiltrarMisCitas.Checked Then
            Globales.Configuracion.CalendarioTipoFiltro = 2
        End If

        If chbFiltrarElPrimerFacultativo.Checked Then
            Globales.Configuracion.CalendarioTipoFiltro = 3
        End If


        'Guardarlo todo en la configuracion de usuario
        Dim configXml As XElement = _
         <configuracion>
             <Comunicacion>
                 <Email>
                     <Address><%= txtEmail.Text %></Address>
                     <SMTPServer><%= txtSMTP_Server.Text %></SMTPServer>
                     <SMTPPort><%= txtSMTP_Port.Text %></SMTPPort>
                     <SMTPUser><%= txtSMTP_User.Text %></SMTPUser>
                     <SMTPPassword><%= txtSMTP_Password.Text %></SMTPPassword>
                     <SMTPUseSSL><%= chk_EMAIL_SSL.Checked %></SMTPUseSSL>
                     <SMTPVerificado><%= IIf(lblEmailVerificado.Text = "Verificado" Or ForzarV.Checked, True, False) %></SMTPVerificado>
                 </Email>
                 <SMS>
                     <Server><%= txtSMS_Server.Text %></Server>
                     <Usuario><%= txtSMS_user.Text %></Usuario>
                     <Password><%= txtSMS_Password.Text %></Password>
                     <Remitente><%= txtSMS_Remitente.Text %></Remitente>
                     <SMSVerificado><%= IIf(lblSMSVerificado.Text = "Verificado", True, False) %></SMSVerificado>
                 </SMS>
             </Comunicacion>
             <Citas>
                 <CitaStyle><%= IIf(rb_vistagrafica.Checked, "Grafica", "Clasica") %></CitaStyle>

                 <Calendario_TipoFiltro><%= Globales.Configuracion.CalendarioTipoFiltro %></Calendario_TipoFiltro>

                 <CitaVisualNombrePaciente><%= chb_datosCitaVisualNombrePaciente.Checked %></CitaVisualNombrePaciente>
                 <CitaVisualMedico><%= chb_datosCitaVisualMedico.Checked %></CitaVisualMedico>
                 <CitaVisualNotas><%= chb_datosCitaVisualNotas.Checked %></CitaVisualNotas>
                 <CitaVisualEspecialidad><%= chb_datosCitaVisualEspecialidad.Checked %></CitaVisualEspecialidad>

                 <Calendario_MostrarListaMedicosPorDefecto><%= chkMostrarListaMedicos.Checked %></Calendario_MostrarListaMedicosPorDefecto>
                 <CitaCodPropioPac><%= chb_CodigoPropioPaciente.Checked %></CitaCodPropioPac>
                 <CitaFormatoNombre><%= IIf(rbAp1Ap1No.Checked, "1", "2") %></CitaFormatoNombre>
             </Citas>
             <Historiales>
                 <TamanoFuente><%= CInt(Me.nudTamanoTexto.Value) %></TamanoFuente>
             </Historiales>
             <Medico>
                 <SiUsuarioMedicoUsarPorDefecto><%= chkSiUsuarioMedicoUsarPorDefecto.Checked %></SiUsuarioMedicoUsarPorDefecto>
             </Medico>
         </configuracion>

        'Dim context As New CMLinqDataContext()

        Globales.Usuario.CONFIGURACIONXML = configXml
        Globales.Context.SubmitChanges()
        Globales.Configuracion.GuardarConfBd()
        Globales.Configuracion.Save(Globales.Configuracion.login)
    End Sub


    Private Sub form_ConfiguracionUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar()
        cambios = False
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.guardar()
        Me.Close()
    End Sub

    Private Sub rb_vistagrafica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vistagrafica.CheckedChanged, chb_datosCitaVisualEspecialidad.CheckedChanged, chb_datosCitaVisualMedico.CheckedChanged, chb_datosCitaVisualNombrePaciente.CheckedChanged, chb_datosCitaVisualNotas.CheckedChanged, rb_vistaclasica.CheckedChanged, chkMostrarListaMedicos.CheckedChanged
        cambios = True
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Dim dialogres As DialogResult
        If cambios = True Then
            dialogres = MsgBox("Hay datos sin guardar, si continua los perderá. ¿Desea continuar y perder estos cambios?", MsgBoxStyle.YesNo)
            If dialogres = Windows.Forms.DialogResult.Yes Then Me.Close()
        Else
            Me.Close()
        End If

    End Sub

    Dim codigo As String = ""
    Dim codigoSMS As String = ""
    Private Sub btnComprobarEMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobarEMAIL.Click

        Me.guardar()

        Dim m As New GoltraTools.Mail.MailSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPServer>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPort>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUser>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPPassword>.Value)

        AddHandler m.SendCompleted, AddressOf MailSendingCompleted

        m.Cliente.EnableSsl = Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<SMTPUseSSL>.Value

        Dim message As New System.Net.Mail.MailMessage()
        message.From = New System.Net.Mail.MailAddress(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value)
        message.To.Add(New System.Net.Mail.MailAddress(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.<Address>.Value))
        message.Subject = "Mensaje de comprobación de su correo electronico"


        codigo = Guid.NewGuid().ToString()
        message.Body = "Mensaje de comprobación de su correo electronico. " & vbCr & vbCrLf & _
                        "Su codigo de verificacion es:" & codigo

        btnComprobarEMAIL.Enabled = False
        btnComprobarEMAIL.Text = "Enviando"

        m.SendMailAsync(message, Nothing)

    End Sub

    Private Sub MailSendingCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs, ByVal info As GoltraTools.Mail.MessageWrapper)

        btnComprobarEMAIL.Enabled = True
        btnComprobarEMAIL.Text = "Comprobar"

        If e.Error Is Nothing Then
            MessageBox.Show("El Mensaje ha sido enviado, compruebe su bandeja de entrada")
            Dim response As String = InputBox("Entre el codigo de verificacion enviado a su correo:", "Confirmación")
            If response.Trim() = codigo Then
                MessageBox.Show("Coincide, correo verificado")
                lblEmailVerificado.Text = "Verificado"
                lblEmailVerificado.ForeColor = Color.Green
            Else
                MessageBox.Show("No coincide, intentelo de nuevo")
                lblEmailVerificado.Text = "No verificado"
                lblEmailVerificado.ForeColor = Color.Red
            End If
        Else
            MessageBox.Show("Error:" & e.Error.Message)
            MessageBox.Show("No coincide, intentelo de nuevo")
            lblEmailVerificado.Text = "No verificado"
            lblEmailVerificado.ForeColor = Color.Red
        End If
    End Sub


    Private Sub btnCheckSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckSMS.Click

        guardar()

        Dim destinations As New List(Of String)
        destinations.Add(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value)

        Dim smssender As New GoltraTools.SMSSender(Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Usuario>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Password>.Value, _
                                                 Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<SMS>.<Remitente>.Value)

        Dim saldo As Double = smssender.DameCredito()
        If saldo = -1 Then
            MessageBox.Show("Ha ocurrido un error comprobando su saldo chequee sus datos")
            Return
        Else
            If saldo = 0 Then
                MessageBox.Show("Crédito insuficiente. Contacte con nuestras oficinas para su recarga")
            Else
                MessageBox.Show("Su saldo es: " & saldo)
            End If


        End If

    End Sub
End Class