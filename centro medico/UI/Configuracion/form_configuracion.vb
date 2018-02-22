Imports System.IO
Imports System.ComponentModel
Imports centro_medico.UI.Reportes
Imports Janus.Windows.GridEX

Public Class form_configuracion

    Dim Identificador As String = ""

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub LlenaSerie()
        Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetData()
        Dim i As Integer
        For i = 0 To _data.Rows.Count - 1
            Dim _cod As String = _data(i).CODIGO
            cb_seriepordefecto.Items.Add(_cod)
        Next

        If _data.Rows.Count > 0 Then
            cb_seriepordefecto.SelectedItem = Globales.Configuracion.serie

        End If

        dtg_series.DataSource = _data
        For Each row As DataGridViewRow In dtg_series.Rows
            If row.DataBoundItem.Row.CODIGO = Globales.Configuracion.serie Then
                row.Selected = True
            End If
        Next

    End Sub

    Private Sub LlenaCampoDiagnostico(ByVal aIndex As Integer)
        cb_diagnosticocopiacampo.Items.Clear()

        cb_diagnosticocopiacampo.Items.Add(tb_histCampo1.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo2.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo3.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo4.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo5.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo6.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo7.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo8.Text)
        cb_diagnosticocopiacampo.Items.Add(tb_histCampo9.Text)

        cb_diagnosticocopiacampo.SelectedIndex = aIndex


    End Sub

    Private Sub form_configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Inicializa()
        LlenaCampoDiagnostico(Integer.Parse(Globales.Configuracion.campodiagnostico))

        ofd_ficherogdb.InitialDirectory = Globales.Configuracion.impresionfilesdirectory
        ofd_CarpetaReportes.InitialDirectory = Globales.Configuracion.impresionfilesdirectory

        Identificador = TbIdClinica.Text
    End Sub

    Private Sub bt_annadirseries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_annadirseries.Click
        Dim _series As form_serie = New form_serie("Serie - Añadir", Enums.Accion.Insertar, -1)
        _series.ShowInTaskbar = False
        _series.ShowDialog()
        LlenaSerie()
    End Sub

    Private Sub bt_editarseries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_editarseries.Click
        If dtg_series.SelectedRows.Count > 0 Then
            Dim _Id As String = dtg_series.SelectedRows(0).Cells("CODIGO").Value.ToString()
            Dim _series As form_serie = New form_serie("Serie - Modificar", Enums.Accion.Modificar, _Id)
            _series.ShowInTaskbar = False
            _series.ShowDialog()
            LlenaSerie()
        End If
    End Sub

    Private Sub bt_eliminarseries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarseries.Click
        If dtg_series.SelectedRows.Count > 0 Then
            Dim _Id As String = dtg_series.SelectedRows(0).Cells("CODIGO").Value.ToString()
            Dim _Contador As Integer = dtg_series.SelectedRows(0).Cells("CONTADOR").Value
            SERIESTableAdapter.Delete(_Id, _Contador)
            LlenaSerie()
        End If
    End Sub

    Private Sub Inicializa()

        ReporteInfoBindingSource.DataSource = Globales.Reportes.Listado()
        tb_carpetaimpresion.Text = Globales.Configuracion.impresionfilesdirectory

        VerificaReportes()

        tb_nombrecomercial.Text = Globales.Configuracion.nombrecomercial
        tb_denominacionsocial.Text = Globales.Configuracion.denominacion
        tb_domicilio.Text = Globales.Configuracion.domicilio
        tb_localidad.Text = Globales.Configuracion.localidad
        tb_cp.Text = Globales.Configuracion.CP
        tb_provincia.Text = Globales.Configuracion.provincia
        tb_tlfno.Text = Globales.Configuracion.Tlfno1
        tb_tlfno2.Text = Globales.Configuracion.Tlfno2
        tb_fax.Text = Globales.Configuracion.fax
        tb_cifnif.Text = Globales.Configuracion.CIF
        tb_email.Text = Globales.Configuracion.Email
        tb_paginaweb.Text = Globales.Configuracion.web
        tb_libro.Text = Globales.Configuracion.libro
        tb_regmercantil.Text = Globales.Configuracion.regmercantil
        tb_hoja.Text = Globales.Configuracion.hoja
        tb_folio.Text = Globales.Configuracion.folio
        tb_seccion.Text = Globales.Configuracion.seccion
        tb_volume.Text = Globales.Configuracion.volumen
        tb_urlParamFiles.Text = Globales.Configuracion.urlParamFiles
        tb_urlFacturaEexe.Text = Globales.Configuracion.urlFacturaEexe

        cb_impresoras.Text = Globales.Configuracion.impresora
      
        'rb_local.Checked = Not Globals.Configuracion.remoto
        'rb_remoto.Checked = Globals.Configuracion.remoto


        'tb_alladoremoto.Text = Globals.Configuracion.ip
        'nud_terminal.Value = Globals.Configuracion.puerto

        tb_carpetacompartidaimagenes.Text = Globales.Configuracion.imagedirectory
        'tb_histFicheroImpresion.Text = Globales.Configuracion.histficheroimpresion

        chb_histMostraFormaSolap.Checked = Globales.Configuracion.solapashistoriales

        tb_histCampo1.Text = Globales.Configuracion.histcampo1
        tb_histCampo2.Text = Globales.Configuracion.histcampo2
        tb_histCampo3.Text = Globales.Configuracion.histcampo3
        tb_histCampo4.Text = Globales.Configuracion.histcampo4
        tb_histCampo5.Text = Globales.Configuracion.histcampo5
        tb_histCampo6.Text = Globales.Configuracion.histcampo6
        tb_histCampo7.Text = Globales.Configuracion.histcampo7
        tb_histCampo8.Text = Globales.Configuracion.histcampo8
        tb_histCampo9.Text = Globales.Configuracion.histcampo9

        tb_nombreordenante.Text = Globales.Configuracion.nombreord
        tb_nifcifordenante.Text = Globales.Configuracion.CIFord
        tb_sufijoordenante.Text = Globales.Configuracion.sufijoord

        CtrlCuentaBancariaOrdenante.Entidad = Globales.Configuracion.entidadord
        CtrlCuentaBancariaOrdenante.Oficina = Globales.Configuracion.oficinaord
        CtrlCuentaBancariaOrdenante.DC = Globales.Configuracion.DCord
        CtrlCuentaBancariaOrdenante.Cuenta = Globales.Configuracion.cuentaord

        tb_nombrepresentador.Text = Globales.Configuracion.nombrepres
        tb_sufijopresentador.Text = Globales.Configuracion.sufijopres
        tb_nifcifpresentador.Text = Globales.Configuracion.CIFpres
        tb_entidadpresentador.Text = Globales.Configuracion.entidadpres
        tb_oficinapresentador.Text = Globales.Configuracion.oficinapres

        nud_porcentajeirpf.Value = Globales.Configuracion.IRPF
        cb_seriepordefecto.Text = Globales.Configuracion.serie

        'If Globals.Configuracion.citastyle = "Grafica" Then
        '    rb_vistagrafica.Checked = True
        'Else
        '    rb_vistagrafica.Checked = False
        'End If

        nud_intervalo.Value = Globales.Configuracion.dateinterval
        nud_duracion.Value = Globales.Configuracion.citainterval

        tb_jornadalaboralinicio.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(Globales.Configuracion.DameJornadaLaboralInicio(Date.Now))
        tb_jornadalaboralfin.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(Globales.Configuracion.DameJornadaLaboralFinal(Date.Now))

        'chb_datosCitaVisualNombrePaciente.Checked = Globals.Configuracion.citapac
        'chb_datosCitaVisualMedico.Checked = Globals.Configuracion.citamed
        'chb_datosCitaVisualNotas.Checked = Globals.Configuracion.citanote
        'chb_datosCitaVisualEspecialidad.Checked = Globals.Configuracion.citaesp

       
        'tb_imagenfondo.Text = Globals.Configuracion.imagefile
        tb_carpetacompartidaficheros.Text = Globales.Configuracion.dirfiles

        chb_mostrarcalendariopantallaprinciapal.Checked = Globales.Configuracion.calendar

        If Globales.Configuracion.solapasinicial = "Antecedentes" Then
            rb_solpInicialPacAntecPerson.Checked = True
        Else
            rb_solpInicialPacDatosPerson.Checked = True
        End If

        If Globales.Configuracion.solapasvisibles = "Todas" Then
            rb_solpVisPacTodas.Checked = True
        ElseIf Globales.Configuracion.solapasvisibles = "Administrativos" Then
            rb_solpVisPacDatosAdministrativos.Checked = True
        Else
            rb_solpVisPacDatosClinicos.Checked = True
        End If

        chb_filtrarautomsolap.Checked = Globales.Configuracion.filtrar
        rb_filtrarAutomSolapTodos.Enabled = chb_filtrarautomsolap.Checked
        rb_filtrarAutomSolapMesActual.Enabled = chb_filtrarautomsolap.Checked


        If Globales.Configuracion.tipofiltrado = "Todos" Then
            rb_filtrarAutomSolapTodos.Checked = True
        Else
            rb_filtrarAutomSolapMesActual.Checked = True
        End If

        If Globales.Configuracion.logotipo <> "" Then
            Try
                Dim _imagen As Bitmap = Bitmap.FromFile(Globales.Configuracion.logotipo)
                pb_logotipo.BackgroundImage = _imagen
                pb_logotipo.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
                MessageBox.Show("Error cargando logotipo " & Globales.Configuracion.logotipo & ex.Message)
            End Try
        End If

        If Globales.Configuracion.ivaIncluido = 0 Then
            chkIvaIncluido.Checked = False
        Else
            chkIvaIncluido.Checked = True
        End If

        chk_AutoSugerirHoraCita.Checked = Globales.Configuracion.AutoSugerirHoraCita

        ChkCincronCalendario.Checked = Globales.Configuracion.SincCalendCitaFtp
        TbIdClinica.Enabled = ChkCincronCalendario.Checked
        LbIdClinica.Enabled = ChkCincronCalendario.Checked
        TbIdClinica.Text = Globales.Configuracion.IdentificadorClinica

        ChkVincularCitaMutua.Checked = Globales.Configuracion.VincularCitaMutua

        LlenaSerie()

        Cita_AutoRefreshInterval.Minimum = 0
        Cita_AutoRefreshInterval.Value = Globales.Configuracion.Cita_AutoRefreshInterval / 60000
        Cita_AutoRefreshInterval.Maximum = 60


        chkSiUsuarioMedicoMostrar.Checked = Globales.Configuracion.Calendario_SiUsuarioMedicoMostrarSoloSusCitas
        chkUsarCuentaDominioParaCarpetaCompartida.Checked = Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida
        'chkOcultarColumnaImporte.Checked = Globales.Configuracion.Citas_Medico_OcultarColumna

        txtUser.Text = Globales.Configuracion.CarpetaCompartidaUsuario
        txtPassword.Text = Globales.Configuracion.CarpetaCompartidaPassword
        txtDominio.Text = Globales.Configuracion.CarpetaCompartidaDominio

        'chkDental_Presupuestos_TenerEnCuentaCantPiezas.Checked = Globales.Configuracion.Dental_Presupuesto_TenerEnCuentaCantidadPiezas
        chkSalas.Checked = Globales.Configuracion.Cita_UsarSalas

        chkCitas_IncluirImporteDelDoctorEnPrecioDeLaLinea.Checked = Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas
        txtMedico_PorcientoGlobal.Value = Globales.Configuracion.Cita_Medico_PorcientoGlobal


        chkUsarPacienteDebitoPagar.Checked = Globales.Configuracion.UsarPacienteDebitoAlPagar

        chkFiltroCumpleannos.Checked = Globales.Configuracion.FiltroEspecial_Cumplennos
        chkDental_Activar.Checked = Globales.Configuracion.Dental_ModuloActivo

        chk_ModuloLiquidacionMedicos_Activo.Checked = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        'txt_Reporte_Factura_Multiple.Text = Globales.Configuracion.ReporteFacturaMultiple

        chkActivar_control_Libro_Ingresos_gastos.Checked = Globales.Configuracion.chkActivar_control_Libro_Ingresos_gastos

        ProcesaJornadaLaboral()

    End Sub

    Public Sub ProcesaJornadaLaboral()
        chkJornadaGlobal.Checked = Boolean.Parse(Globales.Configuracion.JornadaLaboral.<Global>.@Activa)

        ParseaDia(0, dtpDomingoIni, dtpDomingoFin)
        ParseaDia(1, dtpLunesIni, dtpLunesFin)
        ParseaDia(2, dtpMartesIni, dtpMartesFin)
        ParseaDia(3, dtpMiercolesIni, dtpMiercolesFin)
        ParseaDia(4, dtpJuevesIni, dtpJuevesFin)
        ParseaDia(5, dtpViernesIni, dtpViernesFin)
        ParseaDia(6, dtpSabadoIni, dtpSabadoFin)

        'Dim xml As Xml.Linq.XDocument = 
    End Sub

    Private Sub ParseaDia(ByVal dayIndex As Integer, ByRef dtpIni As DateTimePicker, ByRef dtpFin As DateTimePicker)
        Dim span As TimeSpan = TimeSpan.Parse(Globales.Configuracion.JornadaLaboral.<Dias>.<Dia>(dayIndex).@Inicio)
        dtpIni.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(span)

        span = TimeSpan.Parse(Globales.Configuracion.JornadaLaboral.<Dias>.<Dia>(dayIndex).@Final)
        dtpFin.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0).Add(span)
    End Sub


    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Globales.Configuracion.nombrecomercial = tb_nombrecomercial.Text
        Globales.Configuracion.denominacion = tb_denominacionsocial.Text
        Globales.Configuracion.domicilio = tb_domicilio.Text
        Globales.Configuracion.localidad = tb_localidad.Text
        Globales.Configuracion.CP = tb_cp.Text
        Globales.Configuracion.provincia = tb_provincia.Text
        Globales.Configuracion.Tlfno1 = tb_tlfno.Text
        Globales.Configuracion.Tlfno2 = tb_tlfno2.Text
        Globales.Configuracion.fax = tb_fax.Text
        Globales.Configuracion.CIF = tb_cifnif.Text
        Globales.Configuracion.Email = tb_email.Text
        Globales.Configuracion.web = tb_paginaweb.Text
        Globales.Configuracion.libro = tb_libro.Text
        Globales.Configuracion.regmercantil = tb_regmercantil.Text
        Globales.Configuracion.hoja = tb_hoja.Text
        Globales.Configuracion.folio = tb_folio.Text
        Globales.Configuracion.seccion = tb_seccion.Text
        Globales.Configuracion.volumen = tb_volume.Text
        Globales.Configuracion.urlParamFiles = tb_urlParamFiles.Text
        Globales.Configuracion.urlFacturaEexe = tb_urlFacturaEexe.Text
        Globales.Configuracion.impresionfilesdirectory = tb_carpetaimpresion.Text
        Globales.Configuracion.impresora = cb_impresoras.Text

        'Globals.Configuracion.remoto = rb_remoto.Checked


        'Globals.Configuracion.ip = tb_alladoremoto.Text
        'Globals.Configuracion.puerto = nud_terminal.Value

        Globales.Configuracion.imagedirectory = tb_carpetacompartidaimagenes.Text
        'Globales.Configuracion.histficheroimpresion = tb_histFicheroImpresion.Text

        Globales.Configuracion.solapashistoriales = chb_histMostraFormaSolap.Checked

        Globales.Configuracion.histcampo1 = tb_histCampo1.Text
        Globales.Configuracion.histcampo2 = tb_histCampo2.Text
        Globales.Configuracion.histcampo3 = tb_histCampo3.Text
        Globales.Configuracion.histcampo4 = tb_histCampo4.Text
        Globales.Configuracion.histcampo5 = tb_histCampo5.Text
        Globales.Configuracion.histcampo6 = tb_histCampo6.Text
        Globales.Configuracion.histcampo7 = tb_histCampo7.Text
        Globales.Configuracion.histcampo8 = tb_histCampo8.Text
        Globales.Configuracion.histcampo9 = tb_histCampo9.Text

        Globales.Configuracion.campodiagnostico = cb_diagnosticocopiacampo.SelectedIndex

        Globales.Configuracion.nombreord = tb_nombreordenante.Text
        Globales.Configuracion.CIFord = tb_nifcifordenante.Text
        Globales.Configuracion.sufijoord = tb_sufijoordenante.Text
        Globales.Configuracion.entidadord = CtrlCuentaBancariaOrdenante.Entidad
        Globales.Configuracion.oficinaord = CtrlCuentaBancariaOrdenante.Oficina
        Globales.Configuracion.DCord = CtrlCuentaBancariaOrdenante.DC
        Globales.Configuracion.cuentaord = CtrlCuentaBancariaOrdenante.Cuenta

        Globales.Configuracion.nombrepres = tb_nombrepresentador.Text
        Globales.Configuracion.sufijopres = tb_sufijopresentador.Text
        Globales.Configuracion.CIFpres = tb_nifcifpresentador.Text
        Globales.Configuracion.entidadpres = tb_entidadpresentador.Text
        Globales.Configuracion.oficinapres = tb_oficinapresentador.Text

        Globales.Configuracion.IRPF = nud_porcentajeirpf.Value
        Globales.Configuracion.serie = cb_seriepordefecto.SelectedItem

 
        Globales.Configuracion.dateinterval = nud_intervalo.Value
        Globales.Configuracion.citainterval = nud_duracion.Value

        Globales.Configuracion.CambiaJornadaLaboralInicio(tb_jornadalaboralinicio.Value)
        Globales.Configuracion.CambiaJornadaLaboralFinal(tb_jornadalaboralfin.Value)

        
        'Globals.Configuracion.imagefile = tb_imagenfondo.Text
        Globales.Configuracion.dirfiles = tb_carpetacompartidaficheros.Text

        Globales.Configuracion.calendar = chb_mostrarcalendariopantallaprinciapal.Checked

        Globales.Configuracion.AutoSugerirHoraCita = chk_AutoSugerirHoraCita.Checked

        Globales.Configuracion.VincularCitaMutua = ChkVincularCitaMutua.Checked

        Globales.Configuracion.SincCalendCitaFtp = ChkCincronCalendario.Checked
        If ChkCincronCalendario.Checked Then
            If TbIdClinica.Text = "" Then
                TbIdClinica.Focus()
                MessageBox.Show("Debe especificar un identificador de Clínica")
                Return
            ElseIf Identificador <> TbIdClinica.Text And ComprobarIdClinica(TbIdClinica.Text) Then
                TbIdClinica.Focus()
                MessageBox.Show("El identificador de Clínica especificado ya existe")
                Return
            Else
                Globales.Configuracion.IdentificadorClinica = TbIdClinica.Text
            End If
        Else
            Globales.Configuracion.IdentificadorClinica = TbIdClinica.Text
        End If

        If rb_solpInicialPacAntecPerson.Checked = True Then
            Globales.Configuracion.solapasinicial = "Antecedentes"
        Else
            Globales.Configuracion.solapasinicial = "Datos Personales"
        End If

        If rb_solpVisPacTodas.Checked = True Then
            Globales.Configuracion.solapasvisibles = "Todas"
        ElseIf rb_solpVisPacDatosAdministrativos.Checked = True Then
            Globales.Configuracion.solapasvisibles = "Administrativos"
        Else
            Globales.Configuracion.solapasvisibles = "Clinicos"
        End If

        Globales.Configuracion.filtrar = chb_filtrarautomsolap.Checked

        If rb_filtrarAutomSolapTodos.Checked = True Then
            Globales.Configuracion.tipofiltrado = "Todos"
        Else
            Globales.Configuracion.tipofiltrado = "Mes Actual"
        End If
        If chkIvaIncluido.Checked = False Then
            Globales.Configuracion.ivaIncluido = 0
        Else
            Globales.Configuracion.ivaIncluido = 1
        End If

        If Not Globales.Configuracion.EsValidaConfiguracionFacturas_Recibos() Then
            TabControl1.SelectedTab = tab_recibosYfacturas
            Return
        End If

        Globales.Configuracion.Cita_AutoRefreshInterval = Cita_AutoRefreshInterval.Value * 60000
        Globales.Configuracion.Cita_UsarSalas = chkSalas.Checked
        Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas = chkCitas_IncluirImporteDelDoctorEnPrecioDeLaLinea.Checked
        'Globales.Configuracion.Citas_Medico_OcultarColumna = chkOcultarColumnaImporte.Checked
        Globales.Configuracion.Cita_Medico_PorcientoGlobal = txtMedico_PorcientoGlobal.Value


        Globales.Configuracion.Calendario_SiUsuarioMedicoMostrarSoloSusCitas = chkSiUsuarioMedicoMostrar.Checked

        Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida = chkUsarCuentaDominioParaCarpetaCompartida.Checked

        Globales.Configuracion.CarpetaCompartidaUsuario = txtUser.Text
        Globales.Configuracion.CarpetaCompartidaPassword = txtPassword.Text
        Globales.Configuracion.CarpetaCompartidaDominio = txtDominio.Text

        Globales.Configuracion.UsarPacienteDebitoAlPagar = chkUsarPacienteDebitoPagar.Checked

        Globales.Configuracion.FiltroEspecial_Cumplennos = chkFiltroCumpleannos.Checked
        Globales.Configuracion.Dental_ModuloActivo = chkDental_Activar.Checked
        Globales.Configuracion.ModuloLiquidacionMedicos_Activo = chk_ModuloLiquidacionMedicos_Activo.Checked


        Globales.Configuracion.chkActivar_control_Libro_Ingresos_gastos = chkActivar_control_Libro_Ingresos_gastos.Checked


        Globales.Configuracion.JornadaLaboral = <JornadaLaboral>
                                                    <Global Activa=<%= chkJornadaGlobal.Checked.ToString %> Inicio=<%= tb_jornadalaboralinicio.Value.ToString("HH:mm") %> Final=<%= tb_jornadalaboralfin.Value.ToString("HH:mm") %>/>
                                                    <Dias>
                                                        <Dia Nombre="Domingo" Inicio=<%= dtpDomingoIni.Value.ToString("HH:mm") %> Final=<%= dtpDomingoFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Lunes" Inicio=<%= dtpLunesIni.Value.ToString("HH:mm") %> Final=<%= dtpLunesFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Martes" Inicio=<%= dtpMartesIni.Value.ToString("HH:mm") %> Final=<%= dtpMartesFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Miércoles" Inicio=<%= dtpMiercolesIni.Value.ToString("HH:mm") %> Final=<%= dtpMiercolesFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Jueves" Inicio=<%= dtpJuevesIni.Value.ToString("HH:mm") %> Final=<%= dtpJuevesFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Viernes" Inicio=<%= dtpViernesIni.Value.ToString("HH:mm") %> Final=<%= dtpViernesFin.Value.ToString("HH:mm") %>/>
                                                        <Dia Nombre="Sabado" Inicio=<%= dtpSabadoIni.Value.ToString("HH:mm") %> Final=<%= dtpSabadoFin.Value.ToString("HH:mm") %>/>
                                                    </Dias>
                                                </JornadaLaboral>


        Globales.Configuracion.GuardarConfBd()
        Globales.Configuracion.Save(Globales.Configuracion.Login)

        Close()
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Integer.TryParse(_text(i), _number) Then
                        modif = i
                        Continue For
                    Else
                        _texto = _texto + _text(i)
                    End If

                Next
                aTexbox.Text = _texto

            End If
        End If
        If modif <> _text.Length Then
            aTexbox.SelectionStart = modif
        End If
    End Sub


    Private Sub chb_filtrarautomsolap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_filtrarautomsolap.CheckedChanged
        rb_filtrarAutomSolapTodos.Enabled = chb_filtrarautomsolap.Checked
        rb_filtrarAutomSolapMesActual.Enabled = chb_filtrarautomsolap.Checked

    End Sub


    Private Sub tb_histCampo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo1.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 0 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo2.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 1 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo3.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 2 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo4.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 3 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo5.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 4 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo6.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 5 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo7.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 6 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo8.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 7 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub tb_histCampo9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_histCampo9.TextChanged
        LlenaCampoDiagnostico(Globales.Configuracion.campodiagnostico)
        If Globales.Configuracion.campodiagnostico = 8 Then
            cb_diagnosticocopiacampo.Text = ""
        End If
    End Sub

    Private Sub cb_diagnosticocopiacampo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_diagnosticocopiacampo.SelectedIndexChanged
        Globales.Configuracion.campodiagnostico = cb_diagnosticocopiacampo.SelectedIndex
    End Sub

    Private Sub bt_buscarcarpetaimpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscarcarpetaimpresion.Click
        fbd_buscarcarpetaimpresion.SelectedPath = tb_carpetaimpresion.Text
        If fbd_buscarcarpetaimpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tb_carpetaimpresion.Text = fbd_buscarcarpetaimpresion.SelectedPath
            VerificaReportes()
        End If
    End Sub

    Private Sub bt_buscarcarpetacompartidaimagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscarcarpetacompartidaimagenes.Click
        If fbd_carpetacompartidaimagenes.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tb_carpetacompartidaimagenes.Text = fbd_carpetacompartidaimagenes.SelectedPath
        End If
    End Sub

    Private Sub bt_cargarLogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cargarLogotipo.Click
        If ofd_imagenfondo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Globales.Configuracion.logotipo = ofd_imagenfondo.FileName

            Dim _imagen As Bitmap = Bitmap.FromFile(Globales.Configuracion.logotipo)
            pb_logotipo.BackgroundImage = _imagen
            pb_logotipo.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub bt_buscarimagenfondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ofd_imagenfondo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim _indice As Integer = ofd_imagenfondo.FileName.LastIndexOf("\")
            'Dim _name As String = ofd_imagenfondo.FileName.Substring(_indice + 1)
            ''tb_imagenfondo.Text = _name
        End If
    End Sub

    Private Sub bt_buscarcarpetacompartidaficheros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscarcarpetacompartidaficheros.Click
        If fbd_carpetacompartidaficheros.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tb_carpetacompartidaficheros.Text = fbd_carpetacompartidaficheros.SelectedPath
        End If
    End Sub

    Private Sub bt_eliminarLogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarLogotipo.Click
        Globales.Configuracion.logotipo = ""
        pb_logotipo.BackgroundImage = Nothing
    End Sub

 Private Sub chkUsarCuentaDominioParaCarpetaCompartida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUsarCuentaDominioParaCarpetaCompartida.CheckedChanged
        groupCuentaAccesoCarpeta.Enabled = chkUsarCuentaDominioParaCarpetaCompartida.Checked
    End Sub

    Private Sub btnVerificarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarCuenta.Click
        Dim copier As New GoltraTools.FileCopier()
        If copier.VerificarCuenta(tb_carpetacompartidaficheros.Text, txtUser.Text, txtPassword.Text, txtDominio.Text) Then
            MessageBox.Show("Credenciales verificadas correctamente")
        Else
            MessageBox.Show("ERROR accediendo a la carpeta compartida, verifque las credenciales!")
        End If
    End Sub
    
    Private Sub chk_ModuloLiquidacionMedicos_Activo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_ModuloLiquidacionMedicos_Activo.CheckedChanged

        chkCitas_IncluirImporteDelDoctorEnPrecioDeLaLinea.Enabled = chk_ModuloLiquidacionMedicos_Activo.Checked
        chkOcultarColumnaImporte.Enabled = chk_ModuloLiquidacionMedicos_Activo.Checked
        txtMedico_PorcientoGlobal.Enabled = chk_ModuloLiquidacionMedicos_Activo.Checked
    End Sub

    Private Sub chkJornadaGlobal_CheckedChanged(sender As Object, e As EventArgs) Handles chkJornadaGlobal.CheckedChanged
        grpJornadaPersonalizada.Enabled = Not chkJornadaGlobal.Checked
        tb_jornadalaboralinicio.Enabled = chkJornadaGlobal.Checked
        tb_jornadalaboralfin.Enabled = chkJornadaGlobal.Checked
    End Sub
    
    Private Sub btn_Historial_Resume_FicheroImpresion_Click(sender As System.Object, e As System.EventArgs) Handles btn_Historial_Resume_FicheroImpresion.Click
        SeleccionaFichero(txtHistorialesResumenFichero)
    End Sub

    Private Sub SeleccionaFichero(textBoxDestino As TextBox)
        ofd_ficherogdb.InitialDirectory = tb_carpetaimpresion.Text
        If ofd_ficherogdb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            textBoxDestino.Text = Path.GetFileName(ofd_ficherogdb.FileName)
        End If
    End Sub

    
    Private Sub lnkVerificarReportes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkVerificarReportes.LinkClicked
        VerificaReportes()
    End Sub


    Private _workerVerificaReportes As BackgroundWorker
    Private Sub VerificaReportes()
        Globales.Configuracion.impresionfilesdirectory = tb_carpetaimpresion.Text
        _workerVerificaReportes = New BackgroundWorker() With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}

        AddHandler _workerVerificaReportes.ProgressChanged, Sub(e, p)
                                                                Me.BeginInvoke(Sub()
                                                                                   Try
                                                                                       Dim rep As GridEXRow = p.UserState
                                                                                       lnkVerificarReportes.Text = "Verificando " & rep.DataRow.Fichero
                                                                                       GridEXReportes.Refresh()
                                                                                       GridEXReportes.EnsureVisible(rep.Position)
                                                                                   Catch ex As Exception

                                                                                   End Try

                                                                               End Sub)
                                                            End Sub



        AddHandler _workerVerificaReportes.DoWork, Sub()
                                                       Dim counter = 0
                                                       Dim cant = GridEXReportes.RowCount

                                                       Try
                                                           For Each repRow As GridEXRow In GridEXReportes.GetRows()
                                                               Dim rep As ReporteInfo = repRow.DataRow


                                                               If File.Exists(rep.Fichero) Then
                                                                   repRow.Cells(1).ToolTipText = String.Empty
                                                                   rep.Verificado = True
                                                               Else
                                                                   repRow.Cells(1).ToolTipText = "No existe el fichero"
                                                                   rep.Verificado = False
                                                               End If

                                                               counter = counter + 1
                                                               _workerVerificaReportes.ReportProgress((counter / cant) * 100, repRow)

                                                           Next
                                                       Catch ex As Exception

                                                           If TypeOf (ex) Is IOException Then
                                                               Me.BeginInvoke(Sub()
                                                                                  MessageBox.Show("Error:" & ex.Message)
                                                                              End Sub)
                                                               'lnkVerificarReportes.Text = "Verificar"
                                                               'lnkVerificarReportes.Enabled = True
                                                           End If

                                                       End Try
                                                   End Sub

        AddHandler _workerVerificaReportes.RunWorkerCompleted, Sub(e, p)
                                                                   Me.BeginInvoke(Sub()
                                                                                      lnkVerificarReportes.Text = "Verificar"
                                                                                      lnkVerificarReportes.Enabled = True

                                                                                      Dim errores As Integer = Globales.Reportes.Listado().Where(Function(o) o.Verificado = False).Count
                                                                                      lblReportesErrores.Text = "Errores: " & errores
                                                                                      If errores = 0 Then
                                                                                          lblReportesErrores.ForeColor = Color.Green
                                                                                      Else
                                                                                          lblReportesErrores.ForeColor = Color.Red
                                                                                      End If
                                                                                      'ReporteInfoBindingSource.EndEdit()
                                                                                      'GridEXReportes.Refresh()
                                                                                  End Sub)
                                                               End Sub

        lnkVerificarReportes.Enabled = False
        _workerVerificaReportes.RunWorkerAsync()

    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            tb_urlParamFiles.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        OpenFileDialog1.InitialDirectory = Environment.CurrentDirectory
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            tb_urlFacturaEexe.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ChkCincronCalendario_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCincronCalendario.CheckedChanged
        TbIdClinica.Enabled = ChkCincronCalendario.Checked
        LbIdClinica.Enabled = ChkCincronCalendario.Checked
    End Sub

    Private Function ComprobarIdClinica(idClin As String) As Boolean
        Dim Path As String = "ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" + idClin
        Dim Ftp As FtpManager = New FtpManager
        Return Ftp.GetDirectoryExists(Path)
    End Function

    Private Sub TbIdClinica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdClinica.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class