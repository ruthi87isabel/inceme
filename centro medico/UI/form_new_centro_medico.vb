Imports centro_medico.UI.Citas
Imports Importer
Imports System.IO
Imports System.Deployment.Application
Imports centro_medico.UI.Recetas

Imports TestNotifyWindow.NotifyWindow
Imports GoltraTools

Public Class form_new_centro_medico
    Dim fIduser As Integer
    Dim calendar As Boolean = True
    Dim dir As String = ""
    Dim dirFiles As String = ""
    Dim dirRdlc As String = ""
    Dim aviso As TestNotifyWindow.NotifyWindow
    Dim diaNoValido As Boolean = False
    Dim listRecordatorioHoy As List(Of Recordatorio)
    Dim context As New CMLinqDataContext

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.fIduser = 0
    End Sub

    Sub New(ByVal aId As Integer, Optional ByVal noValido As Boolean = False)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.fIduser = aId
        diaNoValido = noValido

    End Sub

    Private Sub form_new_centro_medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.panel_area_foto.Visible = False


        'Verificar si esta en modo demo
        If My.Settings.Demo = True Then
            'Si es asi, mostrar un cartel de advertencia
            MessageBox.Show("Ud se encuentra en modo Demo, por lo que podrá crear sólo 5 pacientes y 5 citas")
        End If

        IniciaUsuario(fIduser)
        CargaListRecod()

        Globales.ChequeaIdentidadTarifas()
        Dim recur As Integer = Globales.VerificaEstadoRecurrencia(2)
        If recur > 0 Then
            MessageBox.Show("Existen " & recur & " citasd bloqueadas por mas de " & 2 & " horas que han sido desbloqueadas")
        End If
    End Sub

    Private Function ConfiguracionBasicaCorrecta() As Boolean

        ChequeaVersionBD()


        Dim mensajeError As String = ""

        If Me.dir Is Nothing Then
            mensajeError = "No se ha definido la ruta para almacenar las imagenes."
        Else
            If dir.Trim.Length < 4 Then
                mensajeError = "No se ha definido la ruta para almacenar las imagenes."
            End If
        End If
        If Me.dirFiles Is Nothing Then
            If mensajeError.Trim.Length > 0 Then mensajeError += vbCrLf
            mensajeError += "No se ha definido la ruta para almacenar los ficheros."
        Else
            If dirFiles.Trim.Length < 4 Then
                mensajeError = "No se ha definido la ruta para almacenar los ficheros."
            End If
        End If
        If Me.dirRdlc Is Nothing Then
            If mensajeError.Trim.Length > 0 Then mensajeError += vbCrLf
            mensajeError += "No se ha definido la ruta para las plantillas de impresión."
        Else
            If Me.dirRdlc.Trim.Length < 4 Then
                If mensajeError.Trim.Length > 0 Then mensajeError += vbCrLf
                mensajeError += "No se ha definido la ruta para las plantillas de impresión."
            End If
        End If

        If mensajeError.Trim.Length > 0 Then
            aviso = New TestNotifyWindow.NotifyWindow

            Me.aviso.WaitOnMouseOver = True
            Me.aviso.SetDimensions(500, 200)
            Me.aviso.BackColor = Color.FromArgb(253, 66, 57)
            'Me.aviso.Top = -500
            Me.aviso.Text = mensajeError
            Me.aviso.Text += vbCrLf & " Vaya al menu Utilidades/Configuración y complete los valores indicados."
            Me.aviso.Title = "Parámetros necesarios para continuar"

            Me.aviso.Notify()
            Return False
        Else
            Return True
        End If
    End Function

    ' ROLES y chequeo de Permisos
    Public Shared IDUser As Integer

#Region "Public Sub IniciaUsuario(ByVal ID_Usuario As Integer)"
    Public Sub IniciaUsuario(ByVal ID_Usuario As Integer)
        'Check la existencia de ciertos permisos
        'se crea con el fin de no tener que modificar mediante script en caso de no existir
        Globales.CheckPermisoBloquearHistorial()
        Globales.CheckPermisoAlmacen()
        Globales.CheckPermisoArticulos()
        Globales.CheckPermisoArticulosAlmacen()
        Globales.CheckPermisoAsistenteFacturacion()
        Globales.CheckPermisoComerciales()
        Globales.CheckPermisoConsolidarStock()
        Globales.CheckPermisoEntradas()
        Globales.CheckPermisoFacturasRecibidas()
        Globales.CheckPermisoFacturasVentas()
        Globales.CheckPermisoPedidosProveedores()
        Globales.CheckPermisoPoblaciones()
        Globales.CheckPermisoTickets()
        Globales.CheckPermisoImporteCitas()
        Globales.CheckPermisoComoConocio()
        Globales.CheckPermisos(80, "Pacientes Débito")
        Globales.CheckPermisos(81, "Tarifas")
        Globales.CheckPermisos(82, "Procesos")
        Globales.CheckPermisos(83, "Auditorias")
        Globales.CheckPermisos(84, "Dental")
        Globales.CheckPermisos(85, "Dental_Presupuestos")
        Globales.CheckPermisos(86, "Comunicaciones")
        Globales.CheckPermisos(87, "IncemeWeb")
        Globales.CheckPermisos(88, "Salas")
        Globales.CheckPermisos(89, "Liquidacion_Medicos")
        Globales.CheckPermisos(90, "Citas_ModificarImporteMedico")
        Globales.CheckPermisos(91, "Horarios")
        Globales.CheckPermisos(92, "Libro_Ingresos_Gastos")
        Globales.CheckPermisos(93, "Galeria_Imagenes")
        Globales.CheckPermisos(RoleManager.Items.Bonos, "Bonos")

        'Fin checkeo existencia permisos.
        IDUser = ID_Usuario
        Globales.Usuario = (From u In Globales.Context.USUARIOs Where u.CODIGO = ID_Usuario Select u).SingleOrDefault

        Globales.Configuracion.LeerConfBD()
        Globales.Configuracion.Crea()
        calendar = Globales.Configuracion.calendar

        'MessageBox.Show(Globales.Configuracion.Email_Address)

        Me.dir = Globales.Configuracion.imagedirectory
        Me.dirFiles = Globales.Configuracion.dirfiles
        Me.dirRdlc = Globales.Configuracion.impresionfilesdirectory

        Globales.Configuracion.Login = Globales.Usuario.USUARIO
        If Not Globales.Usuario.NOMBRECOMPLETO Is Nothing Then
            lb_usuario.Text = Globales.Usuario.NOMBRECOMPLETO
        Else
            lb_usuario.Text = Globales.Usuario.USUARIO
        End If

        'Si el acceso del usuario es fuera de horario se le notifica y se registra en la auditoria. Si es correcto solo se registra
        If (diaNoValido) Then
            MessageBox.Show("Este dia es no laborable para este usuario. Queda registrado su acceso fuera de horario")
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.InicioSistema, "Inicio en el Sistema", "", "Ha accedido al programa en un día no marcado como laborable")
        Else
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.InicioSistema, "Inicio en el Sistema", "", "Inicio de sesión")
        End If

        If Globales.Usuario.ROLESUSUARIOs(0).ROLE.Nombre = "ADMINISTRADOR" Then
            PictureBox1.Image = Global.centro_medico.My.Resources.Resources.PicAdmin1
        ElseIf Globales.Usuario.ROLESUSUARIOs(0).ROLE.Nombre = "MEDICO" Then
            PictureBox1.Image = Global.centro_medico.My.Resources.Resources.PicDoctor
        ElseIf Globales.Usuario.ROLESUSUARIOs(0).ROLE.Nombre = "RECEPCIONISTA" Then
            PictureBox1.Image = Global.centro_medico.My.Resources.Resources.PicReception
        End If


        Try

            'Me.lblRolUsuario.Text = "Rol: " & Globales.Usuario.ROLESUSUARIOs(0).ROLE.Nombre

            Dim index As Integer = My.MySettings.Default.CMConnectionString.IndexOf("Initial Catalog=") + "Initial Catalog=".Length
            Me.lblInfoBD.Text = My.MySettings.Default.CMConnectionString.Substring(index, My.MySettings.Default.CMConnectionString.IndexOf(";", index) - index)

        Catch ex As Exception
        End Try





        'tb_user.Text = Globals.Usuario.USUARIO
        'bt_usersearch.Enabled = True

        'Por cada item desactivar las opciones asociadas

        '************* Menu Clinicas ******************

        'Medicos
        ExplorerBar1.Groups("Group1").Items("Item1").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        Button6.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno) Then Button6.Image = Global.centro_medico.My.Resources.Resources.IconE_Medico
        Button9.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno) Then Button9.Image = Global.centro_medico.My.Resources.Resources.IconE_Medico

        'Mutuas
        ExplorerBar1.Groups("Group1").Items("Item2").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)
        Button10.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno) Then Button10.Image = Global.centro_medico.My.Resources.Resources.IconE_Mutuas

        'Bancos
        ExplorerBar1.Groups("Group1").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Bancos) = RoleManager.TipoPermisos.Ninguno)
        Button11.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Bancos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Bancos) = RoleManager.TipoPermisos.Ninguno) Then Button11.Image = Global.centro_medico.My.Resources.Resources.IconE_Banco

        'Gastos
        ExplorerBar1.Groups("Group1").Items("Item6").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Gastos) = RoleManager.TipoPermisos.Ninguno)
        Button12.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Gastos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Gastos) = RoleManager.TipoPermisos.Ninguno) Then Button12.Image = Global.centro_medico.My.Resources.Resources.IconE_Gastos

        'Liquidacion de Médicos
        ExplorerBar1.Groups("Group1").Items("Item7").Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        ExplorerBar1.Groups("Group1").Items("Item7").Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Gastos) >= RoleManager.TipoPermisos.Modificar)
        Button13.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        Button13.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Gastos) >= RoleManager.TipoPermisos.Modificar)
        If Not (Globales.Usuario.Permisos(RoleManager.Items.Gastos) >= RoleManager.TipoPermisos.Modificar) Then Button13.Image = Global.centro_medico.My.Resources.Resources.IconE_LiquidacionMedicos

        'Dashboard
        Dim DB As Boolean = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_estado) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        ExplorerBar1.Groups("Group1").Items("Item8").Enabled = DB
        Button3.Enabled = DB
        Button14.Enabled = DB
        If Not DB Then Button3.Image = Global.centro_medico.My.Resources.Resources.IconE_DashBoard
        If Not DB Then Button14.Image = Global.centro_medico.My.Resources.Resources.IconE_DashBoard

        'Horarios
        ExplorerBar1.Groups("Group1").Items("Item9").Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Horarios) >= RoleManager.TipoPermisos.Modificar)
        Button15.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Horarios) >= RoleManager.TipoPermisos.Modificar)
        If Not (Globales.Usuario.Permisos(RoleManager.Items.Horarios) >= RoleManager.TipoPermisos.Modificar) Then Button15.Image = Global.centro_medico.My.Resources.Resources.IconE_Horario

        ''************ End Clinicas **************************

        ''************ Begin Pacientes ************************

        'Pacientes
        ExplorerBar1.Groups("Group2").Items("Item10").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        Button5.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        Button1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno) Then Button1.Image = Global.centro_medico.My.Resources.Resources.IconE_Paciente
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno) Then Button5.Image = Global.centro_medico.My.Resources.Resources.IconE_Paciente

        'Empresas
        ExplorerBar1.Groups("Group2").Items("Item11").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)
        Button16.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno) Then Button16.Image = Global.centro_medico.My.Resources.Resources.IconE_Empresa

        'Facturas
        ExplorerBar1.Groups("Group2").Items("Item12").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        ExplorerBar1.Groups("Group2").Items("Item13").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        Button18.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        Button17.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        Button7.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno) Then Button18.Image = Global.centro_medico.My.Resources.Resources.IconE_AsistenteFacturacion
        If (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno) Then Button17.Image = Global.centro_medico.My.Resources.Resources.IconE_Factura
        If (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno) Then Button7.Image = Global.centro_medico.My.Resources.Resources.IconE_Factura

        'Generar Facturas/Recibos Mensuales
        ExplorerBar1.Groups("Group2").Items("Item14").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_Facturas_Recibos_Mensuales) = RoleManager.TipoPermisos.Ninguno)
        Button19.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_Facturas_Recibos_Mensuales) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Generar_Facturas_Recibos_Mensuales) = RoleManager.TipoPermisos.Ninguno) Then Button19.Image = Global.centro_medico.My.Resources.Resources.IconE_GenerarFactura

        'Dental
        ExplorerBar1.Groups("Group2").Items("Item15").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        ExplorerBar1.Groups("Group2").Items("Item15").Visible = Globales.Configuracion.Dental_ModuloActivo
        Button2.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        Button2.Visible = Globales.Configuracion.Dental_ModuloActivo
        If (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno) Then Button2.Image = Global.centro_medico.My.Resources.Resources.IconE_PresupuestosDentales

        'Analiticas
        ExplorerBar1.Groups("Group2").Items("Item16").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Analiticas) = RoleManager.TipoPermisos.Ninguno)
        Button20.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Analiticas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Analiticas) = RoleManager.TipoPermisos.Ninguno) Then Button20.Image = Global.centro_medico.My.Resources.Resources.IconE_Analitica

        'Generar Recibos
        ExplorerBar1.Groups("Group2").Items("Item17").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_Recibos) = RoleManager.TipoPermisos.Ninguno)
        Button21.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_Recibos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Generar_Recibos) = RoleManager.TipoPermisos.Ninguno) Then Button21.Image = Global.centro_medico.My.Resources.Resources.IconE_GenerarRecibo

        'Recibos
        ExplorerBar1.Groups("Group2").Items("Item18").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recibos) = RoleManager.TipoPermisos.Ninguno)
        Button22.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recibos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Recibos) = RoleManager.TipoPermisos.Ninguno) Then Button22.Image = Global.centro_medico.My.Resources.Resources.IconE_Recibos

        ''Imprimir Remesa
        ExplorerBar1.Groups("Group2").Items("Item19").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Imprimir_Remesa) = RoleManager.TipoPermisos.Ninguno)
        Button23.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Imprimir_Remesa) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Imprimir_Remesa) = RoleManager.TipoPermisos.Ninguno) Then Button23.Image = Global.centro_medico.My.Resources.Resources.IconE_ImprimirRemesa

        'Generar Norma 19
        ExplorerBar1.Groups("Group2").Items("Item20").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_norma_19) = RoleManager.TipoPermisos.Ninguno)
        Button24.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Generar_norma_19) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Generar_norma_19) = RoleManager.TipoPermisos.Ninguno) Then Button24.Image = Global.centro_medico.My.Resources.Resources.IconE_GenerarNorma19

        'Citas
        ExplorerBar1.Groups("Group2").Items("Item22").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)
        Button26.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)
        Button4.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno) Then Button26.Image = Global.centro_medico.My.Resources.Resources.IconE_Citas
        If (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno) Then Button4.Image = Global.centro_medico.My.Resources.Resources.IconE_Citas

        'Bajas y Altas
        ExplorerBar1.Groups("Group2").Items("Item23").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas) = RoleManager.TipoPermisos.Ninguno)
        Button27.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas) = RoleManager.TipoPermisos.Ninguno) Then Button27.Image = Global.centro_medico.My.Resources.Resources.IconE_ParteAltas_Bajas

        'Asistencias
        ExplorerBar1.Groups("Group2").Items("Item24").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia) = RoleManager.TipoPermisos.Ninguno)
        Button28.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia) = RoleManager.TipoPermisos.Ninguno) Then Button28.Image = Global.centro_medico.My.Resources.Resources.IconE_ParteAsistencia

        'Pacientes Debito
        ExplorerBar1.Groups("Group2").Items("Item25").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno)
        Button8.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno)
        Button82.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno) Then Button8.Image = Global.centro_medico.My.Resources.Resources.IconE_DebitoPaciente
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno) Then Button82.Image = Global.centro_medico.My.Resources.Resources.IconE_DebitoPaciente

        'Procesos
        ExplorerBar1.Groups("Group2").Items("Item24").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno)
        Button29.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno) Then Button29.Image = Global.centro_medico.My.Resources.Resources.IconE_Procesos

        'Comunicaciones
        ExplorerBar1.Groups("Group2").Items("Item24").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) = RoleManager.TipoPermisos.Ninguno)
        Button30.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) = RoleManager.TipoPermisos.Ninguno) Then Button30.Image = Global.centro_medico.My.Resources.Resources.IconE_Comunicaciones

        ''************ End Pacientes ********************



        ''************ Begin Mantenimiento ********************

        'Alarma
        ExplorerBar1.Groups("Group3").Items("Item1").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Alarmas) = RoleManager.TipoPermisos.Ninguno)
        Button37.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Alarmas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Alarmas) = RoleManager.TipoPermisos.Ninguno) Then Button37.Image = Global.centro_medico.My.Resources.Resources.IconE_Alarma

        'Diagnostico 
        ExplorerBar1.Groups("Group3").Items("Item2").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        Button36.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno) Then Button36.Image = Global.centro_medico.My.Resources.Resources.IconE_Diagnostico

        'Medicamentos 
        ExplorerBar1.Groups("Group3").Items("Item3").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno)
        Button35.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno) Then Button35.Image = Global.centro_medico.My.Resources.Resources.IconE_Medicamentos

        'Indicaciones 
        ExplorerBar1.Groups("Group3").Items("Item4").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Indicaciones) = RoleManager.TipoPermisos.Ninguno)
        Button34.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Indicaciones) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Indicaciones) = RoleManager.TipoPermisos.Ninguno) Then Button34.Image = Global.centro_medico.My.Resources.Resources.IconE_Indicaciones

        'Conceptos Facturables 
        ExplorerBar1.Groups("Group3").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        Button33.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno) Then Button33.Image = Global.centro_medico.My.Resources.Resources.IconE_Conceptos_Facturables

        'Conceptos Facturables 
        ExplorerBar1.Groups("Group3").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        ExplorerBar1.Groups("Group3").Items("Item6").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        Button32.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        Button33.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno) Then Button32.Image = Global.centro_medico.My.Resources.Resources.IconE_Familia
        If (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno) Then Button33.Image = Global.centro_medico.My.Resources.Resources.IconE_Conceptos_Facturables

        'Tarifas
        ExplorerBar1.Groups("Group3").Items("Item7").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tarifas) = RoleManager.TipoPermisos.Ninguno)
        Button31.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tarifas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Tarifas) = RoleManager.TipoPermisos.Ninguno) Then Button31.Image = Global.centro_medico.My.Resources.Resources.IconE_Tarifa

        'Conceptos de Analiticas
        ExplorerBar1.Groups("Group3").Items("Item8").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_de_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        Button38.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_de_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_de_Analiticas) = RoleManager.TipoPermisos.Ninguno) Then Button38.Image = Global.centro_medico.My.Resources.Resources.IconE_Conceptos_Analitica

        'Plantillas para Analiticas
        ExplorerBar1.Groups("Group3").Items("Item9").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        Button46.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno) Then Button46.Image = Global.centro_medico.My.Resources.Resources.IconE_Planillas_Analiticas

        'Modelos Revisiones Comparativas
        ExplorerBar1.Groups("Group3").Items("Item10").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Modelos_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno)
        Button45.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Modelos_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Modelos_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno) Then Button45.Image = Global.centro_medico.My.Resources.Resources.IconE_Reviciones_Comparadas

        'Plantillas de texto
        ExplorerBar1.Groups("Group3").Items("Item11").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_de_texto) = RoleManager.TipoPermisos.Ninguno)
        Button44.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_de_texto) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_de_texto) = RoleManager.TipoPermisos.Ninguno) Then Button44.Image = Global.centro_medico.My.Resources.Resources.IconE_Planillas_Texto

        'Plantilla de Historial
        ExplorerBar1.Groups("Group3").Items("Item12").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantilla_de_Historial) = RoleManager.TipoPermisos.Ninguno)
        Button43.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantilla_de_Historial) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Plantilla_de_Historial) = RoleManager.TipoPermisos.Ninguno) Then Button43.Image = Global.centro_medico.My.Resources.Resources.IconE_Planillas_Historial

        'Poblaciones
        ExplorerBar1.Groups("Group3").Items("Item13").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno)
        Button42.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno) Then Button42.Image = Global.centro_medico.My.Resources.Resources.IconE_Poblacion

        'Paises
        ExplorerBar1.Groups("Group3").Items("Item14").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Paises) = RoleManager.TipoPermisos.Ninguno)
        Button41.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Paises) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Paises) = RoleManager.TipoPermisos.Ninguno) Then Button41.Image = Global.centro_medico.My.Resources.Resources.IconE_Paises

        'ComoConocio
        ExplorerBar1.Groups("Group3").Items("Item15").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)
        Button40.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno) Then Button40.Image = Global.centro_medico.My.Resources.Resources.IconE_Como_nos_Conocio

        'Formas de Pago
        ExplorerBar1.Groups("Group3").Items("Item16").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno)
        Button39.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno) Then Button39.Image = Global.centro_medico.My.Resources.Resources.IconE_Formas_de_pago

        'Clinica externas
        ExplorerBar1.Groups("Group3").Items("Item17").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        Button50.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno) Then Button50.Image = Global.centro_medico.My.Resources.Resources.IconE_Hospitales_Externos

        'Almacen
        ExplorerBar1.Groups("Group3").Items("Item18").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno)
        Button49.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno) Then Button49.Image = Global.centro_medico.My.Resources.Resources.IconE_Almacen

        'Salas
        ExplorerBar1.Groups("Group3").Items("Item19").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Salas) = RoleManager.TipoPermisos.Ninguno)
        Button48.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Salas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Salas) = RoleManager.TipoPermisos.Ninguno) Then Button48.Image = Global.centro_medico.My.Resources.Resources.IconE_Salas

        'Galeria Imagenes
        ExplorerBar1.Groups("Group3").Items("Item20").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Galeria_Imagenes) = RoleManager.TipoPermisos.Ninguno)
        Button47.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Galeria_Imagenes) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Galeria_Imagenes) = RoleManager.TipoPermisos.Ninguno) Then Button47.Image = Global.centro_medico.My.Resources.Resources.IconE_Galeria_de_Imagenes

        ''************ End Mantenimiento ********************

        ''************ Begin Listados ********************

        'Listado de Pacientes
        ExplorerBar1.Groups("Group4").Items("Item1").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Pacientes) = RoleManager.TipoPermisos.Ninguno)
        Button67.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Pacientes) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Pacientes) = RoleManager.TipoPermisos.Ninguno) Then Button67.Image = Global.centro_medico.My.Resources.Resources.IconE_Paciente

        'Listado de Faltas
        ExplorerBar1.Groups("Group4").Items("Item2").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Faltas) = RoleManager.TipoPermisos.Ninguno)
        Button65.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Faltas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Faltas) = RoleManager.TipoPermisos.Ninguno) Then Button65.Image = Global.centro_medico.My.Resources.Resources.IconE_Listado_de_Faltas

        'Partes
        ExplorerBar1.Groups("Group4").Items("Item3").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Ninguno)
        Button64.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Ninguno) Then Button64.Image = Global.centro_medico.My.Resources.Resources.IconE_Partes

        'Recetas
        ExplorerBar1.Groups("Group4").Items("Item4").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recetas) = RoleManager.TipoPermisos.Ninguno)
        Button63.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recetas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Recetas) = RoleManager.TipoPermisos.Ninguno) Then Button63.Image = Global.centro_medico.My.Resources.Resources.IconE_Recetas_y_Tratamientos

        'Listado de Citas
        ExplorerBar1.Groups("Group4").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Citas) = RoleManager.TipoPermisos.Ninguno)
        Button62.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Citas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Citas) = RoleManager.TipoPermisos.Ninguno) Then Button62.Image = Global.centro_medico.My.Resources.Resources.IconE_Listado_de_Citas

        'Ingresos por citas/medicos
        ExplorerBar1.Groups("Group4").Items("Item6").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)
        Button66.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno) Then Button66.Image = Global.centro_medico.My.Resources.Resources.IconE_Ingresos_Citas_Medicos

        'Ingresos por procedencia de cita (no tiene enumerador, usado el mismo que el Ingresos por Citas)
        ExplorerBar1.Groups("Group4").Items("Item7").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)
        Button61.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno) Then Button61.Image = Global.centro_medico.My.Resources.Resources.IconE_Ingresos_Procedencia_Citas

        'Listado de Facturas
        ExplorerBar1.Groups("Group4").Items("Item8").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Facturas) = RoleManager.TipoPermisos.Ninguno)
        Button60.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Facturas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Facturas) = RoleManager.TipoPermisos.Ninguno) Then Button60.Image = Global.centro_medico.My.Resources.Resources.IconE_Listado_de_Facturas

        'Listado de Recibos
        ExplorerBar1.Groups("Group4").Items("Item9").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Recibos) = RoleManager.TipoPermisos.Ninguno)
        Button59.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Recibos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Recibos) = RoleManager.TipoPermisos.Ninguno) Then Button59.Image = Global.centro_medico.My.Resources.Resources.IconE_Listado_de_Recibos

        'Informe de Ingresos y Saldos
        ExplorerBar1.Groups("Group4").Items("Item10").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Informe_de_Ingresos_y_Gastos) = RoleManager.TipoPermisos.Ninguno)
        Button58.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Informe_de_Ingresos_y_Gastos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Informe_de_Ingresos_y_Gastos) = RoleManager.TipoPermisos.Ninguno) Then Button58.Image = Global.centro_medico.My.Resources.Resources.IconE_Informe_de_Ingresos_y_Gastos

        'Diagnosticos Emitidos
        ExplorerBar1.Groups("Group4").Items("Item11").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        Button57.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno) Then Button57.Image = Global.centro_medico.My.Resources.Resources.IconE_Diagnosticos_Emitidos

        'Pacientes por Diagnosticos 
        ExplorerBar1.Groups("Group4").Items("Item12").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        Button56.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno) Then Button56.Image = Global.centro_medico.My.Resources.Resources.IconE_Pacientes_por_Diagnostico

        'Pacientes Derivaciones
        ExplorerBar1.Groups("Group4").Items("Item13").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)
        Button55.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno) Then Button55.Image = Global.centro_medico.My.Resources.Resources.IconE_Derivaciones

        ''************ End Listados ********************

        ''************ Begin TPV ********************

        'Proveedores
        ExplorerBar1.Groups("Group5").Items("Item1").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)
        Button70.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno) Then Button70.Image = Global.centro_medico.My.Resources.Resources.IconE_Proveedores

        'Articulos
        ExplorerBar1.Groups("Group5").Items("Item2").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)
        Button69.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno) Then Button69.Image = Global.centro_medico.My.Resources.Resources.IconE_Articulos

        'Entradas
        ExplorerBar1.Groups("Group5").Items("Item3").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno)
        Button68.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno) Then Button68.Image = Global.centro_medico.My.Resources.Resources.IconE_Entradas

        'Pedidos Proveedores
        ExplorerBar1.Groups("Group5").Items("Item4").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno)
        Button54.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno) Then Button54.Image = Global.centro_medico.My.Resources.Resources.IconE_Pedido_a_Proveedor

        'Facturas Proveedores
        ExplorerBar1.Groups("Group5").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno)
        Button53.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno) Then Button53.Image = Global.centro_medico.My.Resources.Resources.IconE_Facturas_Proveedor

        'Facturas Ventas
        ExplorerBar1.Groups("Group5").Items("Item6").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno)
        Button52.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno) Then Button52.Image = Global.centro_medico.My.Resources.Resources.IconE_Factura

        'Tickets
        ExplorerBar1.Groups("Group5").Items("Item7").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno)
        Button51.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno) Then Button51.Image = Global.centro_medico.My.Resources.Resources.IconE_Listado_de_Tickets

        'Consolidar Stock
        ExplorerBar1.Groups("Group5").Items("Item8").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Consolidar_Stock) = RoleManager.TipoPermisos.Ninguno)
        Button71.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Consolidar_Stock) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Consolidar_Stock) = RoleManager.TipoPermisos.Ninguno) Then Button71.Image = Global.centro_medico.My.Resources.Resources.IconE_Consolidacion_Stock

        ''************ End TPV ********************

        ''************ Begin Ulilidades ********************

        'Usuarios
        ExplorerBar1.Groups("Group6").Items("Item1").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Usuarios) = RoleManager.TipoPermisos.Ninguno)
        Button79.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Usuarios) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Usuarios) = RoleManager.TipoPermisos.Ninguno) Then Button79.Image = Global.centro_medico.My.Resources.Resources.IconE_Usuario

        'Configuracion Roles y permisos
        ExplorerBar1.Groups("Group6").Items("Item3").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Roles_y_permisos) = RoleManager.TipoPermisos.Ninguno)
        Button77.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Roles_y_permisos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Roles_y_permisos) = RoleManager.TipoPermisos.Ninguno) Then Button77.Image = Global.centro_medico.My.Resources.Resources.IconE_Roles_y_Permisos

        'Configuracion Opciones
        ExplorerBar1.Groups("Group6").Items("Item4").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Opciones) = RoleManager.TipoPermisos.Ninguno)
        Button76.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Opciones) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Opciones) = RoleManager.TipoPermisos.Ninguno) Then Button76.Image = Global.centro_medico.My.Resources.Resources.IconE_Opciones

        'Importar Datos
        ExplorerBar1.Groups("Group6").Items("Item7").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Importar_Datos) = RoleManager.TipoPermisos.Ninguno)
        Button73.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Importar_Datos) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Importar_Datos) = RoleManager.TipoPermisos.Ninguno) Then Button73.Image = Global.centro_medico.My.Resources.Resources.IconE_Importar_Datos

        'Integridad
        ExplorerBar1.Groups("Group6").Items("Item5").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        Button75.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno) Then Button75.Image = Global.centro_medico.My.Resources.Resources.IconE_Chequeo_Integridad

        'Totales de Citas
        ExplorerBar1.Groups("Group6").Items("Item6").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        Button74.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno) Then Button74.Image = Global.centro_medico.My.Resources.Resources.IconE_Totales_en_Citas

        'Buscar Actualizaciones
        ExplorerBar1.Groups("Group6").Items("Item8").Enabled = Globales.Usuario.EsAdministrador()
        Button72.Enabled = Globales.Usuario.EsAdministrador()
        If Not Globales.Usuario.EsAdministrador() Then Button72.Image = Global.centro_medico.My.Resources.Resources.IconE_Bascar_Actualizaciones

        'Auditorias
        ExplorerBar1.Groups("Group6").Items("Item9").Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Auditorias) = RoleManager.TipoPermisos.Ninguno)
        Button81.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Auditorias) = RoleManager.TipoPermisos.Ninguno)
        If (Globales.Usuario.Permisos(RoleManager.Items.Auditorias) = RoleManager.TipoPermisos.Ninguno) Then Button81.Image = Global.centro_medico.My.Resources.Resources.IconE_Auditoria

        ''************ End Utilidades ********************

        ''Desarrollo
        'DesarrolloToolStripMenuItem.Visible = Globales.Usuario.EsAdministrador
        ''DesarrolloToolStripMenuItem.Visible = Globals.Usuario.EsAdministrador()

        ''Botones y opciones internas

        ''Me.menu_clinica.Enabled = Not (Globals.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        'Me.PacientesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'tst_NuevoPaciente.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'tst_CodPaciente.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'tst_CodigoPropio.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'ToolStripLabel1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)

        'Me.bt_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'Me.bt_medicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        'Me.bt_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        'Me.bt_citas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)


        Me.ConfiguracionBasicaCorrecta()
        ''Se controla que unos valores de la configuración esten establecidos.
        'If Me.ConfiguracionBasicaCorrecta = False Then
        '    Me.menu_clinica.Enabled = False
        '    Me.PacientesToolStripMenuItem.Enabled = False
        '    Me.MantenimientoToolStripMenuItem.Enabled = False
        '    Me.ListadosToolStripMenuItem.Enabled = False
        '    'Me.bt_addpac.Enabled = False
        '    Me.bt_pacientes.Enabled = False
        '    Me.bt_medicos.Enabled = False
        '    Me.bt_facturas.Enabled = False
        '    Me.bt_citas.Enabled = False
        '    Me.btnDebitoPaciente.Enabled = False
        '    'Me.CtrlPaciente1.Enabled = False
        '    'Me.bt_BuscarCodigoPropio.Enabled = False
        '    'Me.bt_pacearch.Enabled = False
        '    'Me.tb_CodigoPropio.Enabled = False
        '    'Me.tb_pac.Enabled = False
        'End If


        'tstComunicacionesToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) = RoleManager.TipoPermisos.Ninguno)

        Globales.Reportes.Inicia()


    End Sub
#End Region

    Public Sub ChequeaVersionBD()
        '22-01-2016 texto que define la versión mínima de bd para funcionar con la versión de aplicación actual
        Dim minDatabaseVersion As String = "1.0.4.0"

        'Obtiene la version almacenada en la BD y deberia compararse con la version del ensamblado
        Dim strSql As String = "Select Valor from VariablesGlobales WHERE Clave = 'DB_Version'"
        Dim res As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql)

        If Not res Is DBNull.Value Then
            'versión bd actual
            Dim versionActual As Version = New Version(res.ToString())
            'versión aplicación
            Dim versionMin As Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
            'System.Reflection.Assembly.GetExecutingAssembly().GetName().Version'

            lblAppVersion.Text = versionMin.ToString()
            lbl_DbVersionValue.Text = versionActual.ToString()

            'versión mínima necesaria de la bd
            Dim dbrequiredVersion As New Version(minDatabaseVersion)

            If versionActual < dbrequiredVersion Then
                MessageBox.Show("La version actual de la Base de Datos: " & versionActual.ToString() & " difiere de la mínima requerida " & dbrequiredVersion.ToString() & ". Esto podria ocasionar inestabilidad en el sistema. ", "INFORMACIÓN SOBRE BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub SearchText_MouseClick(sender As Object, e As MouseEventArgs) Handles SearchText.MouseClick
        If SearchText.Text = "Buscar Pacientes" Then
            SearchText.Text = ""
            SearchText.ForeColor = Color.Black
            SearchText.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        End If
    End Sub

    Private Sub SearchCPropio_MouseClick(sender As Object, e As MouseEventArgs) Handles SearchCPropio.MouseClick
        If SearchCPropio.Text = "Cod. Propio" Then
            SearchCPropio.Text = ""
            SearchCPropio.ForeColor = Color.Black
            SearchCPropio.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        End If
    End Sub

    Private Sub SearchCPaciente_MouseClick(sender As Object, e As MouseEventArgs) Handles SearchCPaciente.MouseClick
        If SearchCPaciente.Text = "Cod. Paciente" Then
            SearchCPaciente.Text = ""
            SearchCPaciente.ForeColor = Color.Black
            SearchCPaciente.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        End If
    End Sub

    Private Sub SearchText_LostFocus(sender As Object, e As EventArgs) Handles SearchText.LostFocus
        If SearchText.Text = "" Then
            SearchText.Text = "Buscar Pacientes"
            SearchText.ForeColor = Color.DarkGray
            SearchText.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic)
            ExplorerBar1.Focus()
        End If
    End Sub

    Private Sub SearchCPropio_LostFocus(sender As Object, e As EventArgs) Handles SearchCPropio.LostFocus
        If SearchCPropio.Text = "" Then
            SearchCPropio.Text = "Cod. Propio"
            SearchCPropio.ForeColor = Color.DarkGray
            SearchCPropio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic)
            ExplorerBar1.Focus()
        End If
    End Sub

    Private Sub SearchCPaciente_LostFocus(sender As Object, e As EventArgs) Handles SearchCPaciente.LostFocus
        If SearchCPaciente.Text = "" Then
            SearchCPaciente.Text = "Cod. Paciente"
            SearchCPaciente.ForeColor = Color.DarkGray
            SearchCPaciente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic)
            ExplorerBar1.Focus()
        End If
    End Sub

    Private Sub SearchText_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchText.KeyUp, SearchCPaciente.KeyUp, SearchCPropio.KeyUp
        If SearchText.Text = " " And e.KeyData = Keys.Space Then
            SearchText.Text = ""
        End If
        If SearchCPropio.Text = " " And e.KeyData = Keys.Space Then
            SearchCPropio.Text = ""
        End If
        If SearchCPaciente.Text = " " And e.KeyData = Keys.Space Then
            SearchCPaciente.Text = ""
        End If
        If e.KeyData = Keys.Enter Then
            'Buscar paciente por codigo propio
            Try
                BuscaPaciente()
            Catch ex As Exception
            End Try
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            BuscaPaciente()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BuscaPaciente()

        If (Not SearchText.Text = "Buscar Pacientes" And SearchText.Text.Length > 0) Or
            (Not SearchCPropio.Text = "Cod. Propio" And SearchCPropio.Text.Length > 0) Or
            (Not SearchCPaciente.Text = "Cod. Paciente" And SearchCPaciente.Text.Length > 0) Then

            Dim criterio As String = ""
            Dim cpropio As String = ""
            Dim cpaciente As String = ""
            If SearchText.Text <> "Buscar Pacientes" And SearchText.Text.Length > 0 Then criterio = SearchText.Text
            If SearchCPropio.Text <> "Cod. Propio" And SearchCPropio.Text.Length > 0 Then cpropio = SearchCPropio.Text
            If SearchCPaciente.Text <> "Cod. Paciente" And SearchCPaciente.Text.Length > 0 Then cpaciente = SearchCPaciente.Text

            Dim query As String = My.Resources.queryListadoPacientesTop100
            query = query.Insert(query.IndexOf("GROUP"), _
                        " WHERE ('" & cpaciente & "'<> '' AND CONVERT(varchar(10),PACIENTES.CPACIENTE)= '" & cpaciente & "') OR ('" & cpropio & "' <> '' AND PACIENTES.CODIGOPROPIO = '" & cpropio &
                          "') OR ('" & criterio & "' <> '' AND (PACIENTES.DNI='" & criterio & "' OR (PACIENTES.NOMBRE + ' ' + ISNULL(PACIENTES.APELLIDO1, '') + ' ' + ISNULL(PACIENTES.APELLIDO2, '')) LIKE '%" & criterio &
                          "%')) AND (PACIENTES.Eliminado is NULL or PACIENTES.Eliminado = 0)")
            query += " ORDER BY PACIENTES.CPACIENTE DESC "
            Dim dt As DataTable = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, query).Tables(0)
            If dt.Rows.Count() = 1 Then

                Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = dt.Rows(0).Item("CPACIENTE").ToString() And (Not p.Eliminado.HasValue Or p.Eliminado = False) Select p).SingleOrDefault()
                If Not paciente Is Nothing Then
                    Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, paciente.CPACIENTE)
                    _nuevo_paciente.ShowInTaskbar = False
                    _nuevo_paciente.ShowDialog()

                    _nuevo_paciente.Dispose()
                    _nuevo_paciente = Nothing

                    FreeMemory.FlushMemory()
                End If
            ElseIf dt.Rows.Count() > 1 Then
                Dim frm As New frmPacientesListado()
                frm.Buscar = 1
                frm.SQLSentence = query
                frm.Label11.Text = "Días"
                frm.ShowDialog()
            Else
                MessageBox.Show("No se encontraron resultados con el criterio de búsqueda  introducido")
            End If
        End If
    End Sub

    Private Sub MostrarListado(ByVal aName As String, ByVal aBindingSource As BindingSource, ByVal aCurrentList As RoleManager.Items)
        Dim frm As New form_listados(aName, aBindingSource, aCurrentList)
        frm.ShowDialog()
    End Sub

    Private Sub ExplorerBar1_ItemClick(sender As Object, e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles ExplorerBar1.ItemClick

        If ExplorerBar1.Groups("Group1").Items("Item1").Selected Then
            Dim medListado As New frmMedicosListado()
            medListado.ShowDialog()
            FreeMemory.FlushMemory()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item2").Selected Then
            Dim _listados As frmListadoMutua = New frmListadoMutua()
            _listados.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item5").Selected Then
            Dim frm As New frmBancosListado
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item6").Selected Then
            Dim frm As New frmGastosListados()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item7").Selected Then
            Dim frm As New frmLiquidacion_Medicos()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item8").Selected Then
            Dim _dash As Form_DashBoard = New Form_DashBoard()
            _dash.Show()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item9").Selected Then
            Dim frm As New frmHorarios()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group1").Items("Item10").Selected Then
            Button84_Click(Nothing, Nothing)
        End If


        If ExplorerBar1.Groups("Group2").Items("Item10").Selected Then
            Dim frm As New frmPacientesListado()
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
            FreeMemory.FlushMemory()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item11").Selected Then
           ListadoDeEmpresas()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item12").Selected Then
            Dim frm As New frmFacturasM()
            frm.ShowDialog()
            FreeMemory.FlushMemory()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item13").Selected Then
            Dim frm As New frmPartes_AsistenteFacturacion()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item14").Selected Then
            Dim _generar As New form_generar_recfact
            _generar.ShowInTaskbar = False
            _generar.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item15").Selected Then
            Dim frm As New frmDental_ListadoPresupuestos()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item16").Selected Then
            Dim adapter As New CMDataSetTableAdapters.ANALITICASTableAdapter
            adapter.Fill(Me.CMDataSet.ANALITICAS)

            Dim source As New BindingSource
            source.DataSource = CMDataSet
            source.DataMember = "ANALITICAS"

            MostrarListado("Listado de analiticas", source, RoleManager.Items.Analiticas)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item17").Selected Then
            Dim _generar_recibos As form_generar_recibos = New form_generar_recibos(Globales.Configuracion)
            _generar_recibos.ShowInTaskbar = False
            _generar_recibos.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item18").Selected Then
            Me.RECIBOSTableAdapter.Fill(Me.CMDataSet.RECIBOS)
            Dim _name As String = "Listado de Modelos de Recibos"
            MostrarListado(_name, RECIBOSBindingSource, RoleManager.Items.Recibos)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item19").Selected Then
            Dim _remesas As form_remesa_de_recibos = New form_remesa_de_recibos(Globales.Configuracion)
            _remesas.ShowInTaskbar = False
            _remesas.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item20").Selected Then
            Dim frm As New frmNorma19()
            frm.ShowDialog()

            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item21").Selected Then
            Dim _remesas As form_bonos_no_agotados = New form_bonos_no_agotados()
            _remesas.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item22").Selected Then
            Dim frm As New frmCalendarioCitas()
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
            FreeMemory.FlushMemory()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item23").Selected Then
            Dim frm As New frmPartes()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item24").Selected Then
            Dim frm As New frmPartesAsistencia()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item25").Selected Then
            Dim frm As New frmPacienteDebito()
            frm.ShowDialog()
            FreeMemory.FlushMemory()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item26").Selected Then
            Dim frm As New frmProcesos()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item27").Selected Then
            Dim frm As New frmComunicaciones()
            frm.ShowDialog()
        End If

        If ExplorerBar1.Groups("Group3").Items("Item1").Selected Then
            Me.ALARMASTableAdapter.Fill(Me.CMDataSet.ALARMAS)
            Dim _name As String = "Listado de alarmas"
            MostrarListado(_name, ALARMASBindingSource, RoleManager.Items.Alarmas)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item2").Selected Then
            Dim frm As New frmDiagnosticos()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item3").Selected Then
            Dim frm As New frmMedicamentos
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowInTaskbar = False
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item4").Selected Then
            Me.INDICACIONESTableAdapter.Fill(Me.CMDataSet.INDICACIONES)
            Dim _name As String = "Listado de indicaciones"
            MostrarListado(_name, INDICACIONESBindingSource, RoleManager.Items.Indicaciones)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item5").Selected Then
            Dim frm As New frmListadoConceptos()
            frm.tstAnnadirSeleccionados.Visible = False
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item6").Selected Then
            Dim frm As New frmFamiliaSelector()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item7").Selected Then
            Dim frm As New frmTarifas()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item8").Selected Then
            Dim frm As New frmConceptoAnaliticaListado()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item9").Selected Then
            Dim frm As New frmPlantillaAnalitica()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item10").Selected Then
            Dim frm As New frmModelosRevisionesComparativas()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item11").Selected Then
            Dim frm As New frmPlantillasdeTexto()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item12").Selected Then
            Me.PLANTILLA_HISTORIALESTableAdapter.Fill(Me.CMDataSet.PLANTILLA_HISTORIALES)
            Dim _name As String = "Listado de Plantillas de Historial"
            MostrarListado(_name, PLANTILLA_HISTORIALESBindingSource, RoleManager.Items.Plantilla_de_Historial)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item13").Selected Then
            Dim frm As frmPoblaciones = New frmPoblaciones()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item14").Selected Then
            Me.PAISESTableAdapter.Fill(Me.CMDataSet.PAISES)
            Dim _name As String = "Listado de países"
            MostrarListado(_name, PAISESBindingSource, RoleManager.Items.Paises)
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item15").Selected Then
            Dim frm As frmComoConocio = New frmComoConocio()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item16").Selected Then
            Dim frm As New frmFormasDePago()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item17").Selected Then
            Dim frm As New frmClinicasExternas()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item18").Selected Then
            If RoleManager.PermisoPorItem(fIduser, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
                MsgBox("No tiene permisos para acceder a esta parte de la aplicación.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim frm As frmAlmacen = New frmAlmacen()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item19").Selected Then
            Dim frm As New frmSalas
            frm.Show()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item20").Selected Then
            Dim frm As New frm_BancoImag_Galeria()
            frm.ShowDialog()
        End If

        If ExplorerBar1.Groups("Group4").Items("Item1").Selected Then
            Dim frm As New frmPacientesListado()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item2").Selected Then
            Dim _faltas As listado_faltas
            _faltas = New listado_faltas(Globales.Configuracion)
            _faltas.ShowInTaskbar = False
            _faltas.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item3").Selected Then
            Dim _partes As Partes
            _partes = New Partes(Globales.Configuracion)
            _partes.ShowInTaskbar = False
            _partes.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item4").Selected Then
            Dim frm As New frmRecetasListadoFiltrado()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item5").Selected Then
            Dim frm As New frmListadoCitas()
            frm.ShowInTaskbar = False
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item6").Selected Then
            Dim _citas As Citas_Por_Especialista
            _citas = New Citas_Por_Especialista(Globales.Configuracion)
            _citas.ShowInTaskbar = False
            _citas.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item7").Selected Then
            Dim _citas As Citas_Por_Procedencia
            _citas = New Citas_Por_Procedencia(Globales.Configuracion)
            _citas.ShowInTaskbar = False
            _citas.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item8").Selected Then
            Dim frm As New frmFacturasM()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item9").Selected Then
            Dim _recibo As Recibos = New Recibos(Globales.Configuracion)
            _recibo.ShowInTaskbar = False
            _recibo.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item10").Selected Then
            Dim frm As New frmLibroIngresosGastos()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item11").Selected Then
            Dim rdatasource As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasource.Name = "CMDataSet_EstadisticasDiagnosticos"
            rdatasource.Value = Me.EstadisticasDiagnosticosTableAdapter.GetDataTodos
            UI.Reportes.ReportesManager.Imprime("EstadisticasDiagnosticos.rdlc", {rdatasource})
        ElseIf ExplorerBar1.Groups("Group4").Items("Item12").Selected Then
            Dim frm As New frmPacientesPorDiagnosticos
            frm.ShowInTaskbar = False
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item13").Selected Then
            Dim frm As New frmPacientesPorDerivaciones
            frm.ShowInTaskbar = False
            frm.Show()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group4").Items("Item14").Selected Then
            Dim frm As New form_pac_como_nos_conocio
            frm.ShowDialog()
            GC.Collect()
        End If

        If ExplorerBar1.Groups("Group5").Items("Item1").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If
            Dim frm As frmProveedores = New frmProveedores()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item2").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If
            Dim frm As frmArticulos = New frmArticulos()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item3").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If

            Dim frm As frmEntradas = New frmEntradas()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item4").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If
            Dim frm As frmPedidosProveedor = New frmPedidosProveedor()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item5").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If
            Dim frm As frmFacturasRecibidas = New frmFacturasRecibidas()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item6").Selected Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Exit Sub
            End If

            Dim frm As frmFacturasMedicas = New frmFacturasMedicas()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item7").Selected Then
            Dim frm As New frmTPVTicketsListado()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group5").Items("Item8").Selected Then
            Dim frm As frmConsolidacionStock = New frmConsolidacionStock()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        End If

        If ExplorerBar1.Groups("Group6").Items("Item1").Selected Then
            Dim frm As frmUsuarios = New frmUsuarios()
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item2").Selected Then
            Dim frmconfusr As New form_ConfiguracionUsuario
            frmconfusr.ShowDialog()
            frmconfusr.ShowInTaskbar = False
        ElseIf ExplorerBar1.Groups("Group6").Items("Item3").Selected Then
             Dim frm As frmRoles = New frmRoles()
            frm.ShowDialog()
            GC.Collect()
            MessageBox.Show("Los cambios seran aplicados luego de reiniciada la sesión")
        ElseIf ExplorerBar1.Groups("Group6").Items("Item4").Selected Then
            Dim _conf As form_configuracion = New form_configuracion()
            _conf.ShowInTaskbar = False
            _conf.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item5").Selected Then
            Dim frm As New frmChequeoIntegridad()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item6").Selected Then
           Dim frm As New frmChequeoTotalesCitas
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item7").Selected Then
            If MsgBox("La importación de una Base de datos implica la eliminación de los datos actuales en su Base de datos, desea continuar?", MsgBoxStyle.OkCancel, "Importador Datos") = MsgBoxResult.Cancel Then
                Return
            End If

            Dim frm As Importer.FrmConnector = New FrmConnector(Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString)
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item8").Selected Then
            Try
                'MessageBox.Show(Application.StartupPath & "\Updater\UpdaterClient.exe")
                'Dim conStrFile As String = IO.Path.GetTempPath() & "\INCEME.conn"
                'Dim fs As StreamWriter = File.CreateText(conStrFile)
                'fs.Write(My.MySettings.Default.CMConnectionString)
                'fs.Close()
                ''Dim command As String = """" & "ConnString=" & My.MySettings.Default.CMConnectionString & """"
                'MessageBox.Show(command)
                Dim res As MsgBoxResult = MsgBox("Es necesario cerrar inceme para actualizar. Se abrirá una carpeta donde debe ejecutar UPDATERCLIENT.EXE ¿Desea cerrar y continuar con el actualizador?", vbYesNo)
                If res = MsgBoxResult.Yes Then
                    If File.Exists(Application.StartupPath & "\updater\updaterclient.exe") Then
                        Dim path As String
                        path = Application.StartupPath & "\updater"
                        Process.Start("explorer.exe", path)
                        Application.Exit()
                    Else
                        MessageBox.Show("No se encuentra el fichero " & Application.StartupPath & "\updater\UpdaterClient.exe")
                    End If
                End If

            Catch ex As Exception
                Globales.ShowError(ex.Message, ex)
            End Try
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item9").Selected Then
           Dim frm As New frmAuditoria()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group6").Items("Item10").Selected Then
             Dim a As New frmMigrarPacientes
            a.ShowDialog()
       End If

        If ExplorerBar1.Groups("Group7").Items("Item1").Selected Then
            Dim a As New Process
            a.Start("http://www.youtube.com/goltratec")

            GC.Collect()
        End If

        'If ExplorerBar1.Groups("Group9").Items("Item1").Selected Then
        '    Me.DialogResult = Windows.Forms.DialogResult.No
        '    GC.Collect()
        '    Me.Close()
        'ElseIf ExplorerBar1.Groups("Group9").Items("Item2").Selected Then
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        '    Me.Close()
        'End If

    End Sub

    Private Sub ListadoDeEmpresas()
        Dim empresa As New frmEmpresa
        empresa.ShowDialog()
    End Sub

    Private Sub ExplorerBar1_GroupExpanding(sender As Object, e As Janus.Windows.ExplorerBar.GroupCancelEventArgs) Handles ExplorerBar1.GroupExpanding

        If ExplorerBar1.Groups("Group1").Expanded Then ExplorerBar1.Groups("Group1").Expanded = False
        If ExplorerBar1.Groups("Group2").Expanded Then ExplorerBar1.Groups("Group2").Expanded = False
        If ExplorerBar1.Groups("Group3").Expanded Then ExplorerBar1.Groups("Group3").Expanded = False
        If ExplorerBar1.Groups("Group4").Expanded Then ExplorerBar1.Groups("Group4").Expanded = False
        If ExplorerBar1.Groups("Group5").Expanded Then ExplorerBar1.Groups("Group5").Expanded = False
        If ExplorerBar1.Groups("Group6").Expanded Then ExplorerBar1.Groups("Group6").Expanded = False
        If ExplorerBar1.Groups("Group7").Expanded Then ExplorerBar1.Groups("Group7").Expanded = False
        If ExplorerBar1.Groups("Group8").Expanded Then ExplorerBar1.Groups("Group8").Expanded = False
    End Sub

    Private Sub ExplorerBar1_GroupExpanded(sender As Object, e As Janus.Windows.ExplorerBar.GroupEventArgs) Handles ExplorerBar1.GroupExpanded

        UiGroupBox1.Visible = False
        UiGroupBox2.Visible = False
        UiGroupBox3.Visible = False
        UiGroupBox4.Visible = False
        UiGroupBox5.Visible = False
        UiGroupBox6.Visible = False
        UiGroupBox7.Visible = False
        UiGroupBox8.Visible = False

        If ExplorerBar1.Groups("Group1").Expanded Then
            UiGroupBox2.Visible = True
            UiGroupBox2.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group2").Expanded Then
            UiGroupBox3.Visible = True
            UiGroupBox3.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group3").Expanded Then
            UiGroupBox4.Visible = True
            UiGroupBox4.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group4").Expanded Then
            UiGroupBox5.Visible = True
            UiGroupBox5.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group5").Expanded Then
            UiGroupBox6.Visible = True
            UiGroupBox6.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group6").Expanded Then
            UiGroupBox7.Visible = True
            UiGroupBox7.AutoScrollPosition = New Point(0, 0)
        End If

        If ExplorerBar1.Groups("Group7").Expanded Then
            UiGroupBox8.Visible = True
            UiGroupBox8.AutoScrollPosition = New Point(0, 0)
        End If

    End Sub

    Private Sub ExplorerBar1_GroupCollapsing(sender As Object, e As Janus.Windows.ExplorerBar.GroupCancelEventArgs) Handles ExplorerBar1.GroupCollapsing
        Dim a As Integer
        If ExplorerBar1.Groups("Group1").Expanded Then a += 1
        If ExplorerBar1.Groups("Group2").Expanded Then a += 1
        If ExplorerBar1.Groups("Group3").Expanded Then a += 1
        If ExplorerBar1.Groups("Group4").Expanded Then a += 1
        If ExplorerBar1.Groups("Group5").Expanded Then a += 1
        If ExplorerBar1.Groups("Group6").Expanded Then a += 1
        If ExplorerBar1.Groups("Group7").Expanded Then a += 1
        If ExplorerBar1.Groups("Group8").Expanded Then a += 1
        If a = 1 Then
            UiGroupBox1.Visible = True
            UiGroupBox1.Focus()
            UiGroupBox4.AutoScrollPosition = New Point(0, 0)
            UiGroupBox2.Visible = False
            UiGroupBox3.Visible = False
            UiGroupBox4.Visible = False
            UiGroupBox5.Visible = False
            UiGroupBox6.Visible = False
            UiGroupBox7.Visible = False
            UiGroupBox8.Visible = False
        End If
    End Sub

    Private Sub ExplorerBar1_MouseLeave(sender As Object, e As EventArgs) Handles ExplorerBar1.MouseLeave
        If UiGroupBox1.Visible = True Then UiGroupBox1.Focus()
        If UiGroupBox2.Visible = True Then UiGroupBox2.Focus()
        If UiGroupBox3.Visible = True Then UiGroupBox3.Focus()
        If UiGroupBox4.Visible = True Then UiGroupBox4.Focus()
        If UiGroupBox5.Visible = True Then UiGroupBox5.Focus()
        If UiGroupBox6.Visible = True Then UiGroupBox6.Focus()
        If UiGroupBox7.Visible = True Then UiGroupBox7.Focus()
        If UiGroupBox8.Visible = True Then UiGroupBox8.Focus()
    End Sub

    Private Sub ExplorerBar1_MouseHover(sender As Object, e As EventArgs) Handles ExplorerBar1.MouseHover
        ExplorerBar1.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim medListado As New frmMedicosListado()
        medListado.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        Dim _listados As frmListadoMutua = New frmListadoMutua()
        _listados.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Me.PROVEEDORESTableAdapter.Fill(Me.CMDataSet.PROVEEDORES)
        MostrarListado("Listado de proveedores", PROVEEDORESBindingSource, RoleManager.Items.Proveedores)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Dim frm As New frmArticulosListado()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Dim frm As New frmBancosListado
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Dim frm As New frmGastosListados()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Dim frm As New frmLiquidacion_Medicos()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        Dim _dash As Form_DashBoard = New Form_DashBoard()
        _dash.Show()
        GC.Collect()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Dim frm As New frmHorarios()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        ListadoDeEmpresas()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
        Dim frm As New frmFacturasM()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
        Dim frm As New frmPartes_AsistenteFacturacion()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
        Dim _generar As New form_generar_recfact
        _generar.ShowInTaskbar = False
        _generar.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs)
        Dim adapter As New CMDataSetTableAdapters.ANALITICASTableAdapter
        adapter.Fill(Me.CMDataSet.ANALITICAS)

        Dim source As New BindingSource
        source.DataSource = CMDataSet
        source.DataMember = "ANALITICAS"

        MostrarListado("Listado de analiticas", source, RoleManager.Items.Analiticas)
        GC.Collect()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
        Dim _generar_recibos As form_generar_recibos = New form_generar_recibos(Globales.Configuracion)
        _generar_recibos.ShowInTaskbar = False
        _generar_recibos.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs)
        Me.RECIBOSTableAdapter.Fill(Me.CMDataSet.RECIBOS)
        Dim _name As String = "Listado de Modelos de Recibos"
        MostrarListado(_name, RECIBOSBindingSource, RoleManager.Items.Recibos)
        GC.Collect()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
        Dim _remesas As form_remesa_de_recibos = New form_remesa_de_recibos(Globales.Configuracion)
        _remesas.ShowInTaskbar = False
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs)
        Dim frm As New frmNorma19()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs)
        Dim _remesas As form_bonos_no_agotados = New form_bonos_no_agotados()
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs)
        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs)
        Dim frm As New frmPartes()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs)
        Dim frm As New frmPartesAsistencia()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs)
        Dim frm As New frmProcesos()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs)
        Dim frm As New frmComunicaciones()
        frm.ShowDialog()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New frmUsuarios_ADD(True)
        frm.CODIGO = Globales.Usuario.CODIGO
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub lb_usuario_Click(sender As Object, e As EventArgs) Handles lb_usuario.Click
        Dim frm As New frmUsuarios_ADD(True)
        frm.CODIGO = Globales.Usuario.CODIGO
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmPacientesListado()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmDental_ListadoPresupuestos()
        frm.ShowDialog()
    End Sub

    Private Sub UiGroupBox1_Click(sender As Object, e As EventArgs) Handles UiGroupBox1.Click
        UiGroupBox1.Focus()
    End Sub

    Private Sub UiGroupBox2_Click(sender As Object, e As EventArgs) Handles UiGroupBox2.Click
        UiGroupBox2.Focus()
    End Sub

    Private Sub UiGroupBox3_Click(sender As Object, e As EventArgs) Handles UiGroupBox3.Click
        UiGroupBox3.Focus()
    End Sub

    Private Sub UiGroupBox4_Click(sender As Object, e As EventArgs) Handles UiGroupBox4.Click
        UiGroupBox4.Focus()
    End Sub

    Private Sub PictExit1_MouseHover(sender As Object, e As EventArgs) Handles PictExit1.MouseHover
        PictExit1.Visible = False
        PictExit2.Visible = True
    End Sub

    Private Sub PictExit2_MouseLeave(sender As Object, e As EventArgs) Handles PictExit2.MouseLeave
        PictExit2.Visible = False
        PictExit1.Visible = True
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label2.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub PictExit1_Click(sender As Object, e As EventArgs) Handles PictExit1.Click, PictExit2.Click, Label4.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim _dash As Form_DashBoard = New Form_DashBoard()
        _dash.Show()
        GC.Collect()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frmPaciente As New frmPacientesListado
        frmPaciente.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim medListado As New frmMedicosListado()
        medListado.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm As New frmFacturasM()
        frm.ShowDialog()

        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmPacienteDebito()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim medListado As New frmMedicosListado()
        medListado.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim _listados As frmListadoMutua = New frmListadoMutua()
        _listados.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim frm As New frmBancosListado
        frm.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim frm As New frmGastosListados()
        frm.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim frm As New frmLiquidacion_Medicos()
        frm.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim _dash As Form_DashBoard = New Form_DashBoard()
        _dash.Show()
        GC.Collect()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim frm As New frmHorarios()
        frm.ShowDialog()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListadoDeEmpresas()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim frm As New frmFacturasM()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim frm As New frmPartes_AsistenteFacturacion()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim _generar As New form_generar_recfact
        _generar.ShowInTaskbar = False
        _generar.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim adapter As New CMDataSetTableAdapters.ANALITICASTableAdapter
        adapter.Fill(Me.CMDataSet.ANALITICAS)

        Dim source As New BindingSource
        source.DataSource = CMDataSet
        source.DataMember = "ANALITICAS"

        MostrarListado("Listado de analiticas", source, RoleManager.Items.Analiticas)
        GC.Collect()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim _generar_recibos As form_generar_recibos = New form_generar_recibos(Globales.Configuracion)
        _generar_recibos.ShowInTaskbar = False
        _generar_recibos.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.RECIBOSTableAdapter.Fill(Me.CMDataSet.RECIBOS)
        Dim _name As String = "Listado de Modelos de Recibos"
        MostrarListado(_name, RECIBOSBindingSource, RoleManager.Items.Recibos)
        GC.Collect()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim _remesas As form_remesa_de_recibos = New form_remesa_de_recibos(Globales.Configuracion)
        _remesas.ShowInTaskbar = False
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim frm As New frmNorma19()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim _remesas As form_bonos_no_agotados = New form_bonos_no_agotados()
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim frm As New frmPartes()
        frm.ShowDialog()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim frm As New frmPartesAsistencia()
        frm.ShowDialog()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim frm As New frmProcesos()
        frm.ShowDialog()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim frm As New frmComunicaciones()
        frm.ShowDialog()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Me.ALARMASTableAdapter.Fill(Me.CMDataSet.ALARMAS)
        Dim _name As String = "Listado de alarmas"
        MostrarListado(_name, ALARMASBindingSource, RoleManager.Items.Alarmas)
        GC.Collect()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim frm As New frmDiagnosticos()
        frm.ShowDialog()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim frm As New frmMedicamentos
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Me.INDICACIONESTableAdapter.Fill(Me.CMDataSet.INDICACIONES)
        Dim _name As String = "Listado de indicaciones"
        MostrarListado(_name, INDICACIONESBindingSource, RoleManager.Items.Indicaciones)
        GC.Collect()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim frm As New frmListadoConceptos()
        frm.tstAnnadirSeleccionados.Visible = False
        frm.ShowDialog()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim frm As New frmFamiliaSelector()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim frm As New frmTarifas()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim frm As New frmConceptoAnaliticaListado()
        frm.ShowDialog()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim frm As New frmPlantillaAnalitica()
        frm.ShowDialog()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim frm As New frmModelosRevisionesComparativas()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim frm As New frmPlantillasdeTexto()
        frm.ShowDialog()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Me.PLANTILLA_HISTORIALESTableAdapter.Fill(Me.CMDataSet.PLANTILLA_HISTORIALES)
        Dim _name As String = "Listado de Plantillas de Historial"
        MostrarListado(_name, PLANTILLA_HISTORIALESBindingSource, RoleManager.Items.Plantilla_de_Historial)
        GC.Collect()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim frm As frmPoblaciones = New frmPoblaciones()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Me.PAISESTableAdapter.Fill(Me.CMDataSet.PAISES)
        Dim _name As String = "Listado de países"
        MostrarListado(_name, PAISESBindingSource, RoleManager.Items.Paises)
        GC.Collect()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim frm As frmComoConocio = New frmComoConocio()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim frm As New frmFormasDePago()
        frm.ShowDialog()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim frm As New frmClinicasExternas()
        frm.ShowDialog()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If RoleManager.PermisoPorItem(fIduser, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("No tiene permisos para acceder a esta parte de la aplicación.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As frmAlmacen = New frmAlmacen()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim frm As New frmSalas
        frm.Show()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim frm As New frm_BancoImag_Galeria()
        frm.ShowDialog()
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        Dim frm As New frmPacientesListado()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Dim _faltas As listado_faltas
        _faltas = New listado_faltas(Globales.Configuracion)
        _faltas.ShowInTaskbar = False
        _faltas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        Dim _partes As Partes
        _partes = New Partes(Globales.Configuracion)
        _partes.ShowInTaskbar = False
        _partes.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Dim frm As New frmRecetasListadoFiltrado()
        frm.ShowDialog()
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        Dim frm As New frmListadoCitas()
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        Dim _citas As Citas_Por_Especialista
        _citas = New Citas_Por_Especialista(Globales.Configuracion)
        _citas.ShowInTaskbar = False
        _citas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Dim _citas As Citas_Por_Procedencia
        _citas = New Citas_Por_Procedencia(Globales.Configuracion)
        _citas.ShowInTaskbar = False
        _citas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Dim frm As New frmFacturasM()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Dim _recibo As Recibos = New Recibos(Globales.Configuracion)
        _recibo.ShowInTaskbar = False
        _recibo.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim frm As New frmLibroIngresosGastos()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Dim rdatasource As New Microsoft.Reporting.WinForms.ReportDataSource
        rdatasource.Name = "CMDataSet_EstadisticasDiagnosticos"
        rdatasource.Value = Me.EstadisticasDiagnosticosTableAdapter.GetDataTodos
        UI.Reportes.ReportesManager.Imprime("EstadisticasDiagnosticos.rdlc", {rdatasource})
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        Dim frm As New frmPacientesPorDiagnosticos
        frm.ShowInTaskbar = False
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim frm As New frmPacientesPorDerivaciones
        frm.ShowInTaskbar = False
        frm.Show()
        GC.Collect()
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmProveedores = New frmProveedores()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If

        Dim frm As frmEntradas = New frmEntradas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmPedidosProveedor = New frmPedidosProveedor()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmFacturasRecibidas = New frmFacturasRecibidas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If

        Dim frm As frmFacturasMedicas = New frmFacturasMedicas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim frm As New frmTPVTicketsListado()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        Dim frm As frmConsolidacionStock = New frmConsolidacionStock()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        Dim frm As frmUsuarios = New frmUsuarios()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        Dim frmconfusr As New form_ConfiguracionUsuario
        frmconfusr.ShowDialog()
        frmconfusr.ShowInTaskbar = False
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        Dim frm As frmRoles = New frmRoles()
        frm.ShowDialog()
        GC.Collect()
        MessageBox.Show("Los cambios seran aplicados luego de reiniciada la sesión")
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        Dim _conf As form_configuracion = New form_configuracion()
        _conf.ShowInTaskbar = False
        _conf.ShowDialog()
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        Dim frm As New frmChequeoIntegridad()
        frm.ShowDialog()
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        Dim frm As New frmChequeoTotalesCitas
        frm.ShowDialog()
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        If MsgBox("La importación de una Base de datos implica la eliminación de los datos actuales en su Base de datos, desea continuar?", MsgBoxStyle.OkCancel, "Importador Datos") = MsgBoxResult.Cancel Then
            Return
        End If

        Dim frm As Importer.FrmConnector = New FrmConnector(Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString)
        frm.ShowDialog()
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        Try
            'MessageBox.Show(Application.StartupPath & "\Updater\UpdaterClient.exe")
            'Dim conStrFile As String = IO.Path.GetTempPath() & "\INCEME.conn"
            'Dim fs As StreamWriter = File.CreateText(conStrFile)
            'fs.Write(My.MySettings.Default.CMConnectionString)
            'fs.Close()
            ''Dim command As String = """" & "ConnString=" & My.MySettings.Default.CMConnectionString & """"
            'MessageBox.Show(command)
            Dim res As MsgBoxResult = MsgBox("Es necesario cerrar inceme para actualizar. Se abrirá una carpeta donde debe ejecutar UPDATERCLIENT.EXE ¿Desea cerrar y continuar con el actualizador?", vbYesNo)
            If res = MsgBoxResult.Yes Then
                If File.Exists(Application.StartupPath & "\updater\updaterclient.exe") Then
                    Dim path As String
                    path = Application.StartupPath & "\updater"
                    Process.Start("explorer.exe", path)
                    Application.Exit()
                Else
                    MessageBox.Show("No se encuentra el fichero " & Application.StartupPath & "\updater\UpdaterClient.exe")
                End If
            End If

        Catch ex As Exception
            Globales.ShowError(ex.Message, ex)
        End Try
        GC.Collect()
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        Dim frm As New frmAuditoria()
        frm.ShowDialog()
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        Dim a As New frmMigrarPacientes
        a.ShowDialog()
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        Dim a As New Process
        a.Start("http://www.youtube.com/goltratec")

        GC.Collect()
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        Dim frm As New frmPacienteDebito()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        Dim frm As New form_pac_como_nos_conocio
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub CargaListRecod()
        listRecordatorioHoy = (From p In context.Recordatorios _
                            Where p.Fecha = Date.Now And p.Activo And p.IdUsuario = IDUser _
                            Select p Order By p.Hora Descending).ToList()
    End Sub

    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click, NotifyIcon1.MouseDoubleClick
        Dim frmRecord As New Form_Recordatorio

        For Each f As Form In Application.OpenForms
            If f.Name = frmRecord.Name Then
                Return
            End If
        Next
        frmRecord.context = Me.context
        frmRecord.IdUser = IDUser
        frmRecord.ShowDialog()
        CargaListRecod()
        GC.Collect()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim ListRecordatorioHora As List(Of Recordatorio) = listRecordatorioHoy.Where(Function(b) b.Hora.ToString("yyyy-MM-dd HH:mm") = DateTime.Now.ToString("yyyy-MM-dd HH:mm")).ToList()

        If ListRecordatorioHora.Count = 1 Then
            ListRecordatorioHora.Item(0).Activo = False
            context.SubmitChanges()
            CargaListRecod()
            MessageBox.Show(ListRecordatorioHora.Item(0).Anotación, ListRecordatorioHora.Item(0).Hora.ToString("HH:mm") & " - " & ListRecordatorioHora.Item(0).Asunto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ListRecordatorioHora.Count > 1 Then
            Dim mensaje As String = ""
            Dim i As Integer
            For i = 0 To ListRecordatorioHora.Count - 1
                If i = ListRecordatorioHora.Count - 1 Then
                    mensaje += "Notificación" & i + 1 & ": " & ListRecordatorioHora.Item(i).Asunto & vbCrLf & ListRecordatorioHora.Item(i).Anotación & vbCrLf
                Else
                    mensaje += "Notificación" & i + 1 & ": " & ListRecordatorioHora.Item(i).Asunto & vbCrLf & ListRecordatorioHora.Item(i).Anotación & vbCrLf
                    mensaje += "===============================" & vbCrLf & vbCrLf
                End If
                ListRecordatorioHora.Item(i).Activo = False
            Next
            context.SubmitChanges()
            CargaListRecod()
            MessageBox.Show(mensaje, "Notificacion Hora: " & ListRecordatorioHora.Item(0).Hora.ToString("HH:mm"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub form_new_centro_medico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.NotifyIcon1.Visible = False
    End Sub
End Class