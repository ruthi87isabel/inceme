Imports centro_medico.UI.Citas
Imports Importer
Imports System.IO
Imports System.Deployment.Application
Imports centro_medico.UI.Recetas

Imports TestNotifyWindow.NotifyWindow
Imports GoltraTools

Public Class form_centro_medico
    Dim fIduser As Integer
    Dim calendar As Boolean = True
    Dim dir As String = ""
    Dim dirFiles As String = ""
    Dim dirRdlc As String = ""
    Dim aviso As TestNotifyWindow.NotifyWindow
    Dim diaNoValido As Boolean = False

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

    Private Sub bt_pacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_pacientes.Click
        menu_pacientes_Click(Nothing, Nothing)
    End Sub

    Private Sub bt_medicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_medicos.Click

        Dim medListado As New frmMedicosListado()
        medListado.ShowDialog()
        FreeMemory.FlushMemory()

    End Sub

    Private Sub form_centro_medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.panel_area_foto.Visible = False


        'Verificar si esta en modo demo
        If My.Settings.Demo = True Then
            'Si es asi, mostrar un cartel de advertencia
            MessageBox.Show("Ud se encuentra en modo Demo, por lo que podrá crear sólo 5 pacientes y 5 citas")
        End If

        IniciaUsuario(fIduser)

        If calendar = False Then
            menu_calendario.Checked = False
        End If
        'CtrlPaciente1.Focus()

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



        Globales.Configuracion.login = Globales.Usuario.USUARIO
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

        Try

            Me.lblRolUsuario.Text = "Rol: " & Globales.Usuario.ROLESUSUARIOs(0).ROLE.Nombre

            Dim index As Integer = My.MySettings.Default.CMConnectionString.IndexOf("Initial Catalog=") + "Initial Catalog=".Length
            Me.lblInfoBD.Text = My.MySettings.Default.CMConnectionString.Substring(index, My.MySettings.Default.CMConnectionString.IndexOf(";", index) - index)

        Catch ex As Exception
        End Try





        'tb_user.Text = Globals.Usuario.USUARIO
        'bt_usersearch.Enabled = True

        'Por cada item desactivar las opciones asociadas

        '************* Menu Clinicas ******************

        'Medicos
        menu_médicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        bt_medicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)

        'Mutuas
        menu_mutuas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)
        bt_mutuas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)

        'Proveedores
        menu_proveedores.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)

        'Articulos
        menu_artículos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)

        'Bancos
        menu_bancos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Bancos) = RoleManager.TipoPermisos.Ninguno)

        'Gastos
        menu_gastos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Gastos) = RoleManager.TipoPermisos.Ninguno)

        'Liquidacion de Médicos
        LiquidacionDeMédicosToolStripMenuItem.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        LiquidacionDeMédicosToolStripMenuItem.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Gastos) >= RoleManager.TipoPermisos.Modificar)

        'Horarios
        HorariosToolStripMenuItem.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Horarios) >= RoleManager.TipoPermisos.Modificar)

        '************ End Clinicas ********************

        '************ Begin Pacientes ************************

        'Pacientes
        menu_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        bt_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)

        'Empresas
        menu_empresas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)
        bt_empresas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)

        'Facturas
        menu_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        bt_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)

        'Analiticas
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Analiticas)
            Case RoleManager.TipoPermisos.Ninguno
                menu_analíticas.Enabled = False
        End Select

        'Generar Recibos
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_Recibos)
            Case RoleManager.TipoPermisos.Ninguno
                menu_generar_recibos.Enabled = False
        End Select

        'Recibos
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Recibos)
            Case RoleManager.TipoPermisos.Ninguno
                menu_recibos.Enabled = False
        End Select

        'Imprimir Remesa
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Imprimir_Remesa)
            Case RoleManager.TipoPermisos.Ninguno
                menu_imprimir_remesas.Enabled = False
        End Select

        'Generar Norma 19
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_norma_19)
            Case RoleManager.TipoPermisos.Ninguno
                menu_generar_norma19.Enabled = False
        End Select

        'Citas
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Citas)
            Case RoleManager.TipoPermisos.Ninguno
                bt_citas.Enabled = False
                menu_citas.Enabled = False
        End Select

        'Bajas y Altas
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas)
            Case RoleManager.TipoPermisos.Ninguno
                bt_bajas_altas.Enabled = False
                menu_partes_altas_bajas.Enabled = False
        End Select

        'Asistencias
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia)
            Case RoleManager.TipoPermisos.Ninguno
                bt_asistencias.Enabled = False
                menu_partes_asistencia.Enabled = False
        End Select

        'Generar Facturas/Recibos Mensuales
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_Facturas_Recibos_Mensuales)
            Case RoleManager.TipoPermisos.Ninguno
                menu_generar_facturas_recibos.Enabled = False
        End Select

        'Pacientes Debito
        Select Case Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito)
            Case RoleManager.TipoPermisos.Ninguno
                btnDebitoPaciente.Enabled = False
        End Select

        frmProcesosMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno)

        'Dashboard
        menu_DashBoard.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Cistas_por_estado) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno) Or
                                 Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        'Dental
        PresupuestosDentalesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        PresupuestosDentalesToolStripMenuItem.Visible = Globales.Configuracion.Dental_ModuloActivo

        '************ End Pacientes ********************



        '************ Begin Mantenimiento ********************

        menu_alarmas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Alarmas) = RoleManager.TipoPermisos.Ninguno)
        menu_diagnóstico.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        menu_medicamentos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno)
        menu_indicaciones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Indicaciones) = RoleManager.TipoPermisos.Ninguno)

        menu_conceptos_facturables.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        'ConceptosFacturablesDentalToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        FamiliasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)

        menu_conceptos_analíticas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_de_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        menu_plantillas_analíticas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        menu_modelo_revisiones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Modelos_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno)
        menu_plantillas_texto.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_de_texto) = RoleManager.TipoPermisos.Ninguno)
        menu_plantillas_historial.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantilla_de_Historial) = RoleManager.TipoPermisos.Ninguno)
        menu_paises.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Paises) = RoleManager.TipoPermisos.Ninguno)
        menu_formas_pago.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno)
        menu_clínicas_externas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        Me.ComoNosConocióToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)

        AlmacenToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno)
        PoblacionesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno)

        TarifasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tarifas) = RoleManager.TipoPermisos.Ninguno)

        SalasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)

        GaleriaDeImágenesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Galeria_Imagenes) = RoleManager.TipoPermisos.Ninguno)

        '************ End Mantenimiento ********************

        '************ Begin Listados ********************
        menu_ListadoDePacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Pacientes) = RoleManager.TipoPermisos.Ninguno)
        menu_ListadoDeFaltas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Faltas) = RoleManager.TipoPermisos.Ninguno)
        menu_Partes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Ninguno)
        menu_Recetas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recetas) = RoleManager.TipoPermisos.Ninguno)
        menu_ListadoDeCitas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Citas) = RoleManager.TipoPermisos.Ninguno)

        'Ingresos por citas/medicos
        menu_CitasAgrupadasPorEspecialista.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)

        'Ingresos por procedencia de cita (no tiene enumerador, usado el mismo que el Ingresos por Citas)
        menu_CitasAgrupadasPorProcedencia.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)

        menu_ListadoDeFacturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Facturas) = RoleManager.TipoPermisos.Ninguno)
        menu_ListadoDeRecibos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Recibos) = RoleManager.TipoPermisos.Ninguno)

        'Informe de Ingresos y Saldos
        menu_LibroDiario.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Informe_de_Ingresos_y_Gastos) = RoleManager.TipoPermisos.Ninguno)

        ComoNosConocióToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)
        ComoNosConocióToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)

        PacientesPorDiagnosticosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        DiagnosticosEmitidosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        'DerivacionesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)
        'DerivacionesToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)

        'EstadisticasToolStripMenuItem.Enabled = ComoNosConocióToolStripMenuItem.Enabled Or PacientesPorDiagnosticosToolStripMenuItem.Enabled


        '************ End Listados ********************

        menu_Configuracion.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        menu_Usuarios.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Usuarios) = RoleManager.TipoPermisos.Ninguno)
        menu_roles.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Roles_y_permisos) = RoleManager.TipoPermisos.Ninguno)
        menu_opciones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Opciones) = RoleManager.TipoPermisos.Ninguno)
        menu_CopiasDeSeguridad.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Copias_de_seguridad) = RoleManager.TipoPermisos.Ninguno)
        menu_ImportarDatos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Importar_Datos) = RoleManager.TipoPermisos.Ninguno)
        menu_RenumerarFacturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Renumerar_Facturas) = RoleManager.TipoPermisos.Ninguno)

        '************ Begin TPV ********************
        ProveedoresToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)
        ArticulosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)
        EntradasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno)
        PedidosAProveedorToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno)
        FacturasProveedorToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno)
        FacturasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno)
        TicketsToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno)
        ConsolidacionStockToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Consolidar_Stock) = RoleManager.TipoPermisos.Ninguno)

        '************ End TPV ********************

        '************ Begin Utilidades ********************
        BuscarActualizacionesToolStripMenuItem.Enabled = Globales.Usuario.EsAdministrador() '(Globales.Usuario.ADMINISTRADOR = "S")
        AuditoriaToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Auditorias) = RoleManager.TipoPermisos.Ninguno)

        '************ End Utilidades ********************

        'Desarrollo
        DesarrolloToolStripMenuItem.Visible = Globales.Usuario.EsAdministrador
        'DesarrolloToolStripMenuItem.Visible = Globals.Usuario.EsAdministrador()

        'Botones y opciones internas

        'Me.menu_clinica.Enabled = Not (Globals.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        Me.PacientesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        tst_NuevoPaciente.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        tst_CodPaciente.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        tst_CodigoPropio.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        ToolStripLabel1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)

        Me.bt_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        Me.bt_medicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)
        Me.bt_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        Me.bt_citas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)



        'Se controla que unos valores de la configuración esten establecidos.
        If Me.ConfiguracionBasicaCorrecta = False Then
            Me.menu_clinica.Enabled = False
            Me.PacientesToolStripMenuItem.Enabled = False
            Me.MantenimientoToolStripMenuItem.Enabled = False
            Me.ListadosToolStripMenuItem.Enabled = False
            'Me.bt_addpac.Enabled = False
            Me.bt_pacientes.Enabled = False
            Me.bt_medicos.Enabled = False
            Me.bt_facturas.Enabled = False
            Me.bt_citas.Enabled = False
            Me.btnDebitoPaciente.Enabled = False
            'Me.CtrlPaciente1.Enabled = False
            'Me.bt_BuscarCodigoPropio.Enabled = False
            'Me.bt_pacearch.Enabled = False
            'Me.tb_CodigoPropio.Enabled = False
            'Me.tb_pac.Enabled = False
        End If


        tstComunicacionesToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) = RoleManager.TipoPermisos.Ninguno)

        Globales.Reportes.Inicia()


    End Sub
#End Region



    Private Sub bt_citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_citas.Click

        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub


    Private Sub menu_cambiar_imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_cambiar_imagen.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            'Try
            '    pb_imagen.Image = Image.FromFile(OpenFileDialog1.FileName)
            '    pb_imagen.Show()
            'Catch ex As Exception
            '    MessageBox.Show("La dirección de la imagen es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
            GC.Collect()
        End If
    End Sub

    Private Sub menu_SinImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_SinImagen.Click
        'pb_imagen.Hide()

    End Sub

    Private Sub menu_calendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_calendario.Click
        If (menu_calendario.Checked = True) Then
            menu_calendario.Checked = False
            'cal_fecha.Hide()
            'pb_imagen.Location = New Point(0, 33)
            'pb_imagen.Width += 178
        Else
            menu_calendario.Checked = True
            'cal_fecha.Show()
            'pb_imagen.Location = New Point(178, 33)
            'pb_imagen.Width -= 178

        End If
    End Sub

    Private Sub bt_mutuas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mutuas.Click
        Dim _listados As frmListadoMutua = New frmListadoMutua()
        _listados.ShowDialog()
    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Salir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub menu_médicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_médicos.Click
        bt_medicos_Click(sender, e)
    End Sub

    Private Sub menu_mutuas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_mutuas.Click
        bt_mutuas_Click(sender, e)
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub menu_formas_pago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_formas_pago.Click
        Dim frm As New frmFormasDePago()
        frm.ShowDialog()
    End Sub

    Private Sub menu_proveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_proveedores.Click
        Me.PROVEEDORESTableAdapter.Fill(Me.CMDataSet.PROVEEDORES)
        MostrarListado("Listado de proveedores", PROVEEDORESBindingSource, RoleManager.Items.Proveedores)
    End Sub

    Private Sub menu_bancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bancos.Click
        Dim frm As New frmBancosListado
        frm.ShowDialog()
    End Sub

    Private Sub menu_conceptos_facturables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_conceptos_facturables.Click
        Dim frm As New frmListadoConceptos()
        'frm.tabDental.TabVisible = False
        frm.tstAnnadirSeleccionados.Visible = False
        'frm.tstAnnadirSeleccionados2.Visible = False
        frm.ShowDialog()
    End Sub

    Private Sub menu_paises_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_paises.Click
        Me.PAISESTableAdapter.Fill(Me.CMDataSet.PAISES)
        Dim _name As String = "Listado de países"
        MostrarListado(_name, PAISESBindingSource, RoleManager.Items.Paises)
        'Dim frm As frmPoblaciones = New frmPoblaciones()
        'frm.Modo = Globals.ModoParaFormas.Edicion
        'frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_conceptos_analíticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_conceptos_analíticas.Click
        Dim frm As New frmConceptoAnaliticaListado()
        frm.ShowDialog()
    End Sub

    Private Sub menu_clínicas_externas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_clínicas_externas.Click
        Dim frm As New frmClinicasExternas()
        frm.ShowDialog()
    End Sub

    Private Sub menu_alarmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_alarmas.Click
        Me.ALARMASTableAdapter.Fill(Me.CMDataSet.ALARMAS)
        Dim _name As String = "Listado de alarmas"
        MostrarListado(_name, ALARMASBindingSource, RoleManager.Items.Alarmas)
        GC.Collect()
    End Sub

    Private Sub menu_artículos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_artículos.Click
        Dim frm As New frmArticulosListado()
        frm.ShowDialog()
    End Sub

    Private Sub menu_medicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_medicamentos.Click
        'Me.MEDICAMENTOSTableAdapter.Fill(Me.CMDataSet.MEDICAMENTOS)
        'Dim _name As String = "Listado de medicamentos"
        'MostrarListado(_name, MEDICAMENTOSBindingSource, RoleManager.Items.Medicamentos)
        'GC.Collect()
        Dim frm As New frmMedicamentos
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub menu_plantillas_texto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_plantillas_texto.Click
        Dim frm As New frmPlantillasdeTexto()
        frm.ShowDialog()

        'Me.PLANTILLASTableAdapter.Fill(Me.CMDataSet.PLANTILLAS)
        'Dim _name As String = "Listado de plantillas"
        'MostrarListado(_name, PLANTILLASBindingSource, RoleManager.Items.Plantillas_de_texto)
        'GC.Collect()
    End Sub

    Private Sub menu_diagnóstico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_diagnóstico.Click
        Dim frm As New frmDiagnosticos()
        frm.ShowDialog()
    End Sub

    Private Sub menu_gastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_gastos.Click
        Dim frm As New frmGastosListados()
        frm.ShowDialog()
    End Sub

    Private Sub menu_indicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_indicaciones.Click
        Me.INDICACIONESTableAdapter.Fill(Me.CMDataSet.INDICACIONES)
        Dim _name As String = "Listado de indicaciones"

        MostrarListado(_name, INDICACIONESBindingSource, RoleManager.Items.Indicaciones)
        GC.Collect()
    End Sub

    Private Sub menu_plantillas_historial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_plantillas_historial.Click
        Me.PLANTILLA_HISTORIALESTableAdapter.Fill(Me.CMDataSet.PLANTILLA_HISTORIALES)
        Dim _name As String = "Listado de Plantillas de Historial"
        MostrarListado(_name, PLANTILLA_HISTORIALESBindingSource, RoleManager.Items.Plantilla_de_Historial)
        GC.Collect()
    End Sub


    'Private Sub bt_asistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asistencias.Click
    '    Me.PARTESTableAdapter.Fill(Me.CMDataSet.PARTES)
    '    Dim _name As String = "Listado de partes"
    '    Dim _binding As BindingSource = New BindingSource()
    '    Dim _datap As CMDataSet.PARTESDataTable = PARTESTableAdapter.GetData()
    '    Dim i As Integer
    '    Dim Id As Integer
    '    For i = 0 To _datap.Rows.Count - 1
    '        Id = _datap.Rows(i).Item("IDPARTE")
    '        Dim _data As CMDataSet.ASISTENCIASDataTable = ASISTENCIASTableAdapter.GetAsistenciaByParte(Id)
    '        If _data.Rows.Count > 0 Then
    '            _binding.Add(_datap.Rows(i))
    '        End If
    '    Next
    '    MostrarListado(_name, _binding, RoleManager.Items.Partes_Asistencia)
    '    GC.Collect()
    'End Sub

    'Private Sub bt_bajas_altas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_bajas_altas.Click
    '    Me.PARTESTableAdapter.Fill(Me.CMDataSet.PARTES)
    '    Dim _name As String = "Listado de partes"
    '    Dim _binding As BindingSource = New BindingSource()
    '    Dim _datap As CMDataSet.PARTESDataTable = PARTESTableAdapter.GetData()
    '    Dim i As Integer
    '    Dim Id As Integer
    '    Dim tipo As String
    '    For i = 0 To _datap.Rows.Count - 1
    '        Id = _datap.Rows(i).Item("IDPARTE")
    '        'Dim _data As CMDataSet.ASISTENCIASDataTable = ASISTENCIASTableAdapter.GetAsistenciaByParte(Id)
    '        tipo = _datap.Rows(i).Item("TIPO")
    '        If tipo = "B" Then
    '            _binding.Add(_datap.Rows(i))
    '        End If
    '    Next
    '    MostrarListado(_name, _binding, RoleManager.Items.Partes_Altas_Bajas)
    '    GC.Collect()
    'End Sub

    Private Sub menu_partes_altas_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_partes_altas_bajas.Click
        'bt_bajas_altas_Click(sender, e)
        Dim frm As New frmPartes()
        frm.ShowDialog()
    End Sub

    Private Sub menu_partes_asistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_partes_asistencia.Click
        'bt_asistencias_Click(sender, e)
        Dim frm As New frmPartesAsistencia()
        frm.ShowDialog()
    End Sub

    Private Sub menu_pacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_pacientes.Click
        'Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
        'Dim _name As String = "Listado de Pacientes"

        'MostrarListado(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes)
        Dim frm As New frmPacientesListado()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub DashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menu_DashBoard.Click
        Dim _dash As Form_DashBoard = New Form_DashBoard()
        _dash.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub BonosNoAgotadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonosNoAgotadosToolStripMenuItem.Click
        Dim _remesas As form_bonos_no_agotados = New form_bonos_no_agotados()
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_citas.Click
        bt_citas_Click(sender, e)
    End Sub

    Private Sub menu_Recetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Recetas.Click
        'Dim _recetas As listado_recetas

        '_recetas = New listado_recetas(Globales.Configuracion)

        '_recetas.ShowInTaskbar = False
        '_recetas.ShowDialog()
        'GC.Collect()
        Dim frm As New frmRecetasListadoFiltrado()
        frm.ShowDialog()

    End Sub

    Private Sub menu_ListadoDeFaltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ListadoDeFaltas.Click
        Dim _faltas As listado_faltas

        _faltas = New listado_faltas(Globales.Configuracion)

        _faltas.ShowInTaskbar = False
        _faltas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub ListadoDeEmpresas()
        Dim empresa As New frmEmpresa
        empresa.ShowDialog()
    End Sub

    Private Sub bt_empresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_empresas.Click
        ListadoDeEmpresas()
    End Sub

    Private Sub menu_empresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_empresas.Click
        ListadoDeEmpresas()
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub bt_facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_facturas.Click
        'Me.FACTURASTableAdapter.Fill(Me.CMDataSet.FACTURAS)
        'MostrarListado("Listado de facturas", FACTURASBindingSource, RoleManager.Items.Facturas)
        Dim frm As New frmFacturasM()
        frm.ShowDialog()

        FreeMemory.FlushMemory()
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////

    Private Sub menu_analíticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_analíticas.Click


        Dim adapter As New CMDataSetTableAdapters.ANALITICASTableAdapter
        adapter.Fill(Me.CMDataSet.ANALITICAS)

        Dim source As New BindingSource
        source.DataSource = CMDataSet
        source.DataMember = "ANALITICAS"

        MostrarListado("Listado de analiticas", source, RoleManager.Items.Analiticas)
        GC.Collect()
    End Sub

    Private Sub menu_plantillas_analíticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_plantillas_analíticas.Click
        'Me.PLANTILLAANALITICASTableAdapter.Fill(Me.CMDataSet.PLANTILLAANALITICAS)
        'Dim _name As String = "Listado de plantillas para analiticas"

        'MostrarListado(_name, PLANTILLAANALITICASBindingSource, RoleManager.Items.Plantillas_para_Analiticas)
        'GC.Collect()
        Dim frm As New frmPlantillaAnalitica()
        frm.ShowDialog()
    End Sub

    Private Sub menu_CitasAgrupadasPorProcedencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CitasAgrupadasPorProcedencia.Click
        Dim _citas As Citas_Por_Procedencia

        _citas = New Citas_Por_Procedencia(Globales.Configuracion)

        _citas.ShowInTaskbar = False
        _citas.ShowDialog()
        GC.Collect()

    End Sub

    Private Sub menu_generar_recibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_generar_recibos.Click
        Dim _generar_recibos As form_generar_recibos = New form_generar_recibos(Globales.Configuracion)
        _generar_recibos.ShowInTaskbar = False
        _generar_recibos.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_recibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_recibos.Click
        Me.RECIBOSTableAdapter.Fill(Me.CMDataSet.RECIBOS)
        Dim _name As String = "Listado de Modelos de Recibos"
        MostrarListado(_name, RECIBOSBindingSource, RoleManager.Items.Recibos)
        GC.Collect()
    End Sub

    Private Sub menu_imprimir_remesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_imprimir_remesas.Click
        Dim _remesas As form_remesa_de_recibos = New form_remesa_de_recibos(Globales.Configuracion)
        _remesas.ShowInTaskbar = False
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_generar_norma19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_generar_norma19.Click
        'Dim _n19 As form_generar_n19 = New form_generar_n19(Globals.Configuracion)
        '_n19.ShowInTaskbar = False
        '_n19.ShowDialog()
        Dim frm As New frmNorma19()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub menu_generar_facturas_recibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_generar_facturas_recibos.Click
        Dim _generar As New form_generar_recfact
        _generar.ShowInTaskbar = False
        _generar.ShowDialog()
        GC.Collect()

        'MessageBox.Show("Esta opción no se encuentra disponible en la presente versión del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub menu_ListadoDePacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ListadoDePacientes.Click
        'Dim _pac As listado_pacientes
        '_pac = New listado_pacientes(Globals.Configuracion)
        '_pac.ShowInTaskbar = False
        '_pac.ShowDialog()

        Dim frm As New frmPacientesListado()
        frm.ShowDialog()
        'Dim frm As New frm_ListadoFiltradoPacientes()
        'frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_Partes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Partes.Click
        Dim _partes As Partes

        _partes = New Partes(Globales.Configuracion)

        _partes.ShowInTaskbar = False
        _partes.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_ListadoDeCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ListadoDeCitas.Click
        'Dim _citas As Citas

        '_citas = New Citas(Globals.Configuracion)

        '_citas.ShowInTaskbar = False
        '_citas.ShowDialog()
        'Try
        Dim frm As New frmListadoCitas()
        frm.ShowInTaskbar = False
        frm.ShowDialog()
        'Catch ex As Exception
        ' End Try

        GC.Collect()

    End Sub

    Private Sub menu_CitasAgrupadasPorEspecialista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CitasAgrupadasPorEspecialista.Click
        Dim _citas As Citas_Por_Especialista

        _citas = New Citas_Por_Especialista(Globales.Configuracion)

        _citas.ShowInTaskbar = False
        _citas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_ListadoDeFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ListadoDeFacturas.Click
        'Dim _factura As listado_facturas
        '_factura = New listado_facturas(Globales.Configuracion)
        '_factura.ShowInTaskbar = False
        '_factura.ShowDialog()
        Dim frm As New frmFacturasM()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub menu_ListadoDeRecibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ListadoDeRecibos.Click
        Dim _recibo As Recibos = New Recibos(Globales.Configuracion)
        _recibo.ShowInTaskbar = False
        _recibo.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub menu_LibroDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_LibroDiario.Click
        'Dim _libro As form_libro
        '_libro = New form_libro(Globales.Configuracion)

        '_libro.ShowInTaskbar = False
        ''_libro.ShowDialog()
        '_libro.Show()
        Dim frm As New frmLibroIngresosGastos()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub menu_CopiasDeSeguridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CopiasDeSeguridad.Click
        MessageBox.Show("Esta opción no se encuentra disponible en la presente versión del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub menu_RenumerarFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_RenumerarFacturas.Click
        Dim _renum As form_renumerar = New form_renumerar(Globales.Configuracion)
        _renum.ShowInTaskbar = False
        _renum.ShowDialog()
    End Sub

    Private Sub menu_ManualDeInstrucciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ManualDeInstrucciones.Click
        'MessageBox.Show("Esta opción no se encuentra disponible en la presente versión del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim a As New Process
        a.Start("http://www.youtube.com/goltratec")

        GC.Collect()
    End Sub

    Private Sub menu_ArgosGalaica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ArgosGalaica.Click
        MessageBox.Show("Esta opción no se encuentra disponible en la presente versión del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub menu_modelo_revisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_modelo_revisiones.Click
        'Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
        'Dim _name As String = "Listado de Modelos de Revisiones Comparativas"
        'MostrarListado(_name, MODELOSCOMPARATIVABindingSource, RoleManager.Items.Modelos_Revisiones_Comparativas)
        Dim frm As New frmModelosRevisionesComparativas()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    'Private Sub bt_pacearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If tb_pac.Text.Trim() = "" Then
    '        Return
    '    End If

    '    'Intentar localizar al usuario
    '    Dim codigoPaciente As Integer = -1
    '    Try
    '        codigoPaciente = Integer.Parse(tb_pac.Text)
    '    Catch ex As Exception
    '        MessageBox.Show("Introduzca un código válido!")
    '        tb_pac.Focus()
    '        Return
    '    End Try

    '    Me.PACIENTESTableAdapter.FillPacienteById(CMDataSet.PACIENTES, codigoPaciente)
    '    If CMDataSet.PACIENTES.Count = 0 Then
    '        MessageBox.Show("Paciente no existe!")
    '        tb_pac.Focus()
    '        Return
    '    End If

    '    'Si llega aqui el paciente existe
    '    'Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de Paciente-Editar", Enums.Accion.Modificar, codigoPaciente)
    '    Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, codigoPaciente)
    '    _nuevo_paciente.ShowInTaskbar = False
    '    _nuevo_paciente.ShowDialog()

    'End Sub
    Private Sub AbrirPaciente(ByVal CPaciente As Integer)
        '        Dim _paciente As New form_pacientes("Ficha de Paciente", Enums.Accion.Modificar, CPaciente)
        Dim _paciente As New formPaciente("Ficha de Paciente", Enums.Accion.Modificar, CPaciente)
        _paciente.ShowInTaskbar = False
        _paciente.ShowDialog()
        'Me.PACIENTESTableAdapter.FillPacienteById(CMDataSet.PACIENTES, CPaciente)
        GC.Collect()
    End Sub
    Private Sub bt_addpac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_NuevoPaciente.Click
        '        Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de Paciente-Editar", Enums.Accion.Insertar)
        Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Insertar)
        _nuevo_paciente.ShowInTaskbar = False
        _nuevo_paciente.ShowDialog()
        'Me.PACIENTESTableAdapter.Fill(CMDataSet.PACIENTES)
        FreeMemory.FlushMemory()
    End Sub

    'Private Sub bt_usersearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _name As String = "Usuarios"
    '    Dim _listados As form_listados = New form_listados(_name, USUARIOSBindingSource, RoleManager.Items.Configuracion_Usuarios, True, "", "", "")
    '    _listados.ShowInTaskbar = False
    '    _listados.ShowDialog()
    '    If _listados.Selected() <> "" Then
    '        Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
    '        fIduser = _pcodo
    '        If fIduser = 0 Then
    '            Globales.Configuracion.LeerConfBD()
    '            calendar = Globales.Configuracion.calendar
    '            dir = Globales.Configuracion.imagefile
    '        Else
    '            Dim data As CMDataSet.USUARIOSDataTable = USUARIOSTableAdapter.GetUserById(fIduser)
    '            Dim login As String = data.Rows(0).Item("Usuario")
    '            Globales.Configuracion.LeerConfBD()
    '            calendar = Globales.Configuracion.calendar
    '            dir = Globales.Configuracion.imagefile
    '        End If
    '    End If
    '    GC.Collect()
    'End Sub

    Private Sub form_centro_medico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'form.Close()
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



    Private Sub MostrarListado2(ByVal aName As String, ByVal aBindingSource As BindingSource, ByVal aCurrentList As RoleManager.Items)
        Dim _listados As form_listados = New form_listados(aName, aBindingSource, aCurrentList, False, "PLANTILLAS", "WHERE SECCION<>''", "ORDER BY DESCRIPCION ASC")

        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub MostrarListado(ByVal aName As String, ByVal aBindingSource As BindingSource, ByVal aCurrentList As RoleManager.Items)
        Dim frm As New form_listados(aName, aBindingSource, aCurrentList)
        frm.ShowDialog()
    End Sub

    Private Sub ImportarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ImportarDatos.Click
        If MsgBox("La importación de una Base de datos implica la eliminación de los datos actuales en su Base de datos, desea continuar?", MsgBoxStyle.OkCancel, "Importador Datos") = MsgBoxResult.Cancel Then
            Return
        End If

        Dim frm As Importer.FrmConnector = New FrmConnector(Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString)
        frm.ShowDialog()
    End Sub



    'Private Sub tb_pac_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        bt_pacearch_Click(Nothing, Nothing)
    '    End If
    'End Sub


    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_opciones.Click
        Dim _conf As form_configuracion = New form_configuracion()
        _conf.ShowInTaskbar = False
        _conf.ShowDialog()
        PresupuestosDentalesToolStripMenuItem.Visible = Globales.Configuracion.Dental_ModuloActivo
        LiquidacionDeMédicosToolStripMenuItem.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Usuarios.Click
        Dim frm As frmUsuarios = New frmUsuarios()
        frm.ShowDialog()
        GC.Collect()
    End Sub


    Private Sub SalirDeINCEMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDeINCEMEToolStripMenuItem.Click
        bt_salir_Click(sender, e)
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        'DialogResult = No que indica no cerrar al Main 
        Me.DialogResult = Windows.Forms.DialogResult.No
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub RolesYPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_roles.Click
        Dim frm As frmRoles = New frmRoles()
        frm.ShowDialog()
        GC.Collect()
        MessageBox.Show("Los cambios seran aplicados luego de reiniciada la sesión")
    End Sub

    Private Sub bt_CerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_CerrarSession.Click
        CerrarSesiónToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        'Llamo al actualizador y le paso el connstring para los updates
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

    Private Sub DiagnosticosEmitidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosticosEmitidosToolStripMenuItem.Click
        Dim rdatasource As New Microsoft.Reporting.WinForms.ReportDataSource

        rdatasource.Name = "CMDataSet_EstadisticasDiagnosticos"
        rdatasource.Value = Me.EstadisticasDiagnosticosTableAdapter.GetDataTodos
        UI.Reportes.ReportesManager.Imprime("EstadisticasDiagnosticos.rdlc", {rdatasource})
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As frmBancos = New frmBancos()
        'frm.Modo = Globals.ModoParaFormas.Edicion
        'frm.ShowDialog()
    End Sub

    Private Sub PoblacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoblacionesToolStripMenuItem.Click
        Dim frm As frmPoblaciones = New frmPoblaciones()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()

    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenToolStripMenuItem.Click
        If RoleManager.PermisoPorItem(fIduser, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("No tiene permisos para acceder a esta parte de la aplicación.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As frmAlmacen = New frmAlmacen()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    'Private Sub tb_CodigoPropio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Me.CargarPorCodigoPropio(Me.tb_CodigoPropio.Text.Trim)
    '    End If
    'End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub bt_BuscarCodigoPropio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.CargarPorCodigoPropio(Me.tb_CodigoPropio.Text.Trim)
    'End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmProveedores = New frmProveedores()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub


    Private Sub EntradasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If

        Dim frm As frmEntradas = New frmEntradas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PedidosAProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosAProveedorToolStripMenuItem.Click
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmPedidosProveedor = New frmPedidosProveedor()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub ConsolidacionStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidacionStockToolStripMenuItem.Click
        Dim frm As frmConsolidacionStock = New frmConsolidacionStock()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()

    End Sub

    Private Sub FacturasProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasProveedorToolStripMenuItem.Click
        'permisos

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If
        Dim frm As frmFacturasRecibidas = New frmFacturasRecibidas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click


        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Exit Sub
        End If

        Dim frm As frmFacturasMedicas = New frmFacturasMedicas()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub ConfiguraciónDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeUsuarioToolStripMenuItem.Click
        Dim frmconfusr As New form_ConfiguracionUsuario
        frmconfusr.ShowDialog()
        frmconfusr.ShowInTaskbar = False
    End Sub


    Private Sub TicketsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketsToolStripMenuItem.Click
        'Dim frmTicket As New frmTicket
        'frmTicket.ShowDialog()
        Dim frm As New frmTPVTicketsListado()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub MostrarFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarFacturasToolStripMenuItem.Click
        bt_facturas_Click(sender, e)
    End Sub

    Private Sub AsistenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsistenteToolStripMenuItem.Click
        'Dim frmWizard As New frmWizardFacturacionCitas
        'frmWizard.ShowDialog()
        Dim frm As New frmPartes_AsistenteFacturacion()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub ComoNosConocióToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComoNosConocióToolStripMenuItem.Click
        Dim frm As frmComoConocio = New frmComoConocio()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
        GC.Collect()
    End Sub


    Private Sub ComoNosConocióToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComoNosConocióToolStripMenuItem1.Click
        Dim _frm As listado_conocio
        _frm = New listado_conocio(Globales.Configuracion)
        _frm.ShowInTaskbar = False
        _frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PacientesPorDiagnosticosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesPorDiagnosticosToolStripMenuItem.Click
        Dim frm As New frmPacientesPorDiagnosticos
        frm.ShowInTaskbar = False
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub RecetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim IDpaciente As Integer
        'IDpaciente = 5
        'Dim ce As form_recetas = New form_recetas(IDpaciente)
        'ce.ShowDialog()
        'GC.Collect()
        Dim IDpaciente As Integer
        IDpaciente = 5
        Dim ce As New frmRecetas(IDpaciente)
        ce.CtrlPacienteReceta.Enabled = False
        ce.ShowDialog()
        GC.Collect()
    End Sub

    'Private Sub CitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim IDpaciente As Integer
    '    IDpaciente = 5
    '    Dim ce As form_citas_ex = New form_citas_ex(IDpaciente)
    '    ce.ShowDialog()
    '    GC.Collect()
    'End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim IDpaciente As Integer
        'IDpaciente = 5
        'Dim ce As form_datospersonales = New form_datospersonales(IDpaciente)
        'ce.ShowDialog()
    End Sub

    Private Sub PartesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IDpaciente As Integer
        IDpaciente = 5
        Dim ce As form_partes = New form_partes(IDpaciente)
        ce.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub DerivacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IDpaciente As Integer
        IDpaciente = 5
        Dim ce As form_derivaciones_ex = New form_derivaciones_ex(IDpaciente)
        ce.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub FormasDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IDpaciente As Integer
        IDpaciente = 5
        Dim ce As form_formasdepago = New form_formasdepago(IDpaciente)
        ce.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub RecibosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IDpaciente As Integer
        IDpaciente = 5
        Dim ce As form_recibos_ex = New form_recibos_ex(IDpaciente)
        ce.ShowDialog()
        GC.Collect()
    End Sub


    Private Sub DerivacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DerivacionesToolStripMenuItem1.Click
        Dim frm As New frmPacientesPorDerivaciones
        frm.ShowInTaskbar = False
        frm.Show()
        GC.Collect()
    End Sub

    Private Sub btnDebitoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebitoPaciente.Click

        Dim frm As New frmPacienteDebito()
        frm.ShowDialog()
        FreeMemory.FlushMemory()

        'Dim frm As New form_pacientes
        'frm.Text = "SELECCIONE PACIENTE"
        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    MessageBox.Show(frm.Paciente.NOMBRE)
        'End If

    End Sub

    Private Sub TarifasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarifasToolStripMenuItem.Click
        Dim frm As New frmTarifas()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    'Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As Boolean)
    '    btnVerPaciente.Enabled = True
    '    If IsReturnPressed Then
    '        btnVerPaciente_Click(Nothing, Nothing)
    '    End If
    'End Sub

    'Private Sub CtrlPaciente1_PacienteNoEncontrado()
    '    btnVerPaciente.Enabled = False
    'End Sub

    'Private Sub btnVerPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, CtrlPaciente1.ID_PACIENTE)
    '    _nuevo_paciente.ShowInTaskbar = False
    '    _nuevo_paciente.ShowDialog()
    '    GC.Collect()
    'End Sub

    Private Sub tst_CodigoPropio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_CodigoPropio.KeyUp
        If e.KeyData = Keys.Enter Then
            'Buscar paciente por codigo propio
            Try
                If tst_CodigoPropio.Text.Length > 0 Then

                    Dim context As New CMLinqDataContext
                    Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CODIGOPROPIO = tst_CodigoPropio.Text And (Not p.Eliminado.HasValue Or p.Eliminado = False) Select p).SingleOrDefault()
                    If Not paciente Is Nothing Then
                        Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, paciente.CPACIENTE)
                        _nuevo_paciente.ShowInTaskbar = False
                        _nuevo_paciente.ShowDialog()
                        GC.Collect()
                    End If
                End If

            Catch ex As Exception
            End Try
            e.Handled = True
        End If

    End Sub


    Private Sub tst_CodPaciente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_CodPaciente.KeyUp

        If e.KeyData = Keys.Enter Then
            'Buscar paciente por codigo propio
            Try
                If tst_CodPaciente.Text.Length > 0 Then

                    Dim context As New CMLinqDataContext
                    Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = tst_CodPaciente.Text And (Not p.Eliminado.HasValue Or p.Eliminado = False) Select p).SingleOrDefault()
                    If Not paciente Is Nothing Then
                        Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, paciente.CPACIENTE)
                        _nuevo_paciente.ShowInTaskbar = False
                        _nuevo_paciente.ShowDialog()

                        _nuevo_paciente.Dispose()
                        _nuevo_paciente = Nothing

                        FreeMemory.FlushMemory()
                    End If

                End If

            Catch ex As Exception
                Globales.ErrorMsg(ex, "")
            End Try
            e.Handled = True
        End If

    End Sub



    Private Sub FrmCitaADDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmCita_Add()
        ''frm.IDCITA = 2898
        'frm.ShowDialog()
        'GC.Collect()
    End Sub

    Private Sub frmProcesosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmProcesos()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub FrmPartesAltayBajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPartes()
        frm.ShowDialog()
    End Sub

    Private Sub FrmPartesAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPartesAsistencia()
        frm.ShowDialog()

    End Sub


    Public Sub ChequeaVersionBD()

        ''Verificar que exista la clave vBdNecesaria en la BD, sino crearla
        'Dim sqlInsert As String = "IF NOT EXISTS (SELECT Valor FROM VariablesGlobales WHERE Clave = 'vBdNecesaria')  INSERT INTO VariablesGlobales(Clave, Valor) VALUES ('vBdNecesaria', '0.0.0.0')"
        'Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, sqlInsert)


        'Obtiene la version almacenada en la BD y deberia compararse con la version del ensamblado
        Dim strSql As String = "Select Valor from VariablesGlobales WHERE Clave = 'DB_Version'"
        Dim res As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql)

        'Dim strSql2 As String = "Select Valor from VariablesGlobales WHERE Clave = 'vBdNecesaria'"
        'Dim res2 As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql2)

        If Not res Is DBNull.Value Then
            Dim versionActual As Version = New Version(res.ToString())
            Dim versionMin As Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
            'System.Reflection.Assembly.GetExecutingAssembly().GetName().Version'

            lblAppVersion.Text = versionMin.ToString()
            lbl_DbVersionValue.Text = versionActual.ToString()


            Dim dbrequiredVersion As New Version("1.0.3.7")

            If versionActual < dbrequiredVersion Then
                MessageBox.Show("La version actual de la Base de Datos: " & versionActual.ToString() & " difiere de la mínima requerida " & dbrequiredVersion.ToString() & ". Esto podria ocasionar inestabilidad en el sistema. ", "INFORMACIÓN SOBRE BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub


    Private Sub btn_VerificarDBVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_VerificarDBVersion.Click
        ChequeaVersionBD()

    End Sub

    Private Sub VersionMinBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmVersionDBAdmin()
        frm.ShowDialog()
    End Sub

    Private Sub frmProcesosMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmProcesos()
        frm.ShowDialog()

    End Sub

    Private Sub frmProcesosMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmProcesosMenuItem.Click
        Dim frm As New frmProcesos()
        frm.ShowDialog()
    End Sub


    Private Sub FrmCalendarioCitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Me.CITASTableAdapter.FillCitaByInterval(Me.CMDataSet.CITAS, _min_date, _max_date)
        'Dim _listados As form_listado_citas = New form_listado_citas("Listado de Citas", RoleManager.Items.Citas, Globales.Usuario.Permisos(RoleManager.Items.Citas))
        '_listados.ShowInTaskbar = False
        '_listados.Show()

        'Dim frm As New frmCalendarioCitas()
        'frm.ShowDialog()
    End Sub

    Private Sub FrmAuditoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmAuditoria()
        frm.ShowDialog()
    End Sub

    Private Sub AuditoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditoriaToolStripMenuItem.Click
        Dim frm As New frmAuditoria()
        frm.ShowDialog()
    End Sub

    Private Sub FrmPacientesMainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPacienteMain()
        frm.IdPaciente = 101505
        frm.Show()
    End Sub

    Private Sub NuevoFrmPacienteDebitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPacienteDebito()
        frm.ShowDialog()
    End Sub

    Private Sub FrmFicherosAdjuntosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmFicherosAdjuntos()
        frm.ShowDialog()
    End Sub


    Private Sub FrmFacturaMedicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmFacturasMedicas_ADD()
        'frm.Show()
    End Sub

    Private Sub PresupuestosDentalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestosDentalesToolStripMenuItem.Click
        Dim frm As New frmDental_ListadoPresupuestos()
        frm.ShowDialog()

    End Sub

    Private Sub FrmListadoConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmListadoConceptos()
        frm.ShowDialog()
    End Sub


    Private Sub FrmTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmControlsTest()
        'Dim frm As New frmPlantillasdeTexto()
        'frm.Modo = Globales.ModoParaFormas.Seleccion
        frm.ShowDialog()
    End Sub

    Private Sub ListadoPacienteConPaginadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPacientesListado()
        frm.ShowDialog()
    End Sub

    Private Sub ComunicacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmComunicaciones()
        frm.ShowDialog()
    End Sub

    Private Sub tstComunicacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstComunicacionesToolStripMenuItem1.Click
        Dim frm As New frmComunicaciones()
        frm.ShowDialog()
    End Sub

    Private Sub FrmTemplatesToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmTemplates()
        frm.ShowDialog()
    End Sub


    Private Sub FrmSalasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmSalas
        frm.Show()
    End Sub

    Private Sub SalasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalasToolStripMenuItem.Click
        Dim frm As New frmSalas
        frm.Show()
    End Sub

    Private Sub ConceptosFacturablesDentalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmListadoConceptos()
        'frm.tabOtros.TabVisible = False
        frm.ShowDialog()

    End Sub

    Private Sub tstJustificantePagoCita_Click(sender As System.Object, e As System.EventArgs)

        Dim idCita As Integer = 1390

        Dim cita As CITA = (From c In Globales.Context.CITAs Where c.IDCITA = idCita Select c).SingleOrDefault()
        If Not cita Is Nothing Then
            Globales.ImprimeJustificante(cita)
        End If


    End Sub


    Private Sub tstLiquidacionMedicos_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmLiquidacion_Medicos()
        frm.ShowDialog()
    End Sub

    Private Sub LiquidacionDeMédicosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LiquidacionDeMédicosToolStripMenuItem.Click
        Dim frm As New frmLiquidacion_Medicos()
        frm.ShowDialog()
    End Sub

    Private Sub FamiliasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FamiliasToolStripMenuItem.Click
        Dim frm As New frmFamiliaSelector()
        frm.Modo = Globales.ModoParaFormas.Edicion
        frm.ShowDialog()
    End Sub

    Private Sub tstDevHorarios_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmHorarios()
        frm.ShowDialog()
    End Sub



    Private Sub HorariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HorariosToolStripMenuItem.Click
        Dim frm As New frmHorarios()
        frm.ShowDialog()
    End Sub

    Private Sub EfectuarChequeoIntegridadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EfectuarChequeoIntegridadToolStripMenuItem.Click
        'El chequeo de integridad debe hacerse OnDemand

        Dim frm As New frmChequeoIntegridad()
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        'Dim frm As New frm_RevisionComparativa_Editar()
        'frm.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frm_BancoImag_Galeria()
        frm.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New form_modelos_datos("", Enums.Accion.Insertar, 1)
        'frm.Tipo = frmRevisionComparativa_EditarResultados.TipoDato.OpcionesMultiples
        frm.ShowDialog()
    End Sub

    Private Sub FrmRevisionComparativaEditarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmRevisiones()
        frm.ID_Paciente = 12896
        frm.ShowDialog()
    End Sub

    Private Sub GaleriaDeImágenesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GaleriaDeImágenesToolStripMenuItem.Click
        Dim frm As New frm_BancoImag_Galeria()
        frm.ShowDialog()
    End Sub

    Private Sub FrmCitaImportarConceptosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmCita_ImportarLineas()
        frm.ID_PACIENTE = 12896
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("Seleccionados " & frm.ListaTratamientos.Count & " tratamientos")
        End If

    End Sub



    Private Sub FrmPacienteEditarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim frm As New frmAntecedentes(12896)
        frm.ShowDialog()


    End Sub

    Private Sub TPVFrmTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmTPVTicketsListado
        frm.ShowDialog()

    End Sub

    Private Sub EvaluarExpresionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmRC_Expresiones()
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(sender As Object, e As KeyEventArgs)
        MessageBox.Show("aqui")
    End Sub

    Private Sub EfectuarChequeoTotalesDeCitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectuarChequeoTotalesDeCitasToolStripMenuItem.Click
        Dim frm As New frmChequeoTotalesCitas
        frm.ShowDialog()
    End Sub

    Private Sub FrmRecetasListadoFiltradoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmRecetasListadoFiltrado
        frm.ShowDialog()

    End Sub

    Private Sub CrearDatosPruebaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim context As New CMLinqDataContext


        Dim paciente As New PACIENTE
        paciente.CPACIENTE = 1
        paciente.NOMBRE = "Manolo"
        paciente.APELLIDO1 = "Mesa"
        paciente.Eliminado = False

        paciente.WEB = String.Empty
        paciente.EMAIL = String.Empty
        paciente.CODIGOPROPIO = String.Empty
        paciente.BENEFICIARIOCODIGOSOCIO = 0
        paciente.BENEFICIARIOPARENTESCO = String.Empty
        paciente.REFPAIS = 1

        context.PACIENTEs.InsertOnSubmit(paciente)

        Dim medico As New MEDICO
        medico.NOMBRE = "Doctor"
        medico.APELLIDO1 = "House"
        medico.Eliminado = False

        context.MEDICOs.InsertOnSubmit(medico)

        context.SubmitChanges()


        Dim cita As New CITA()
        cita.REFMEDICO = medico.CMEDICO
        cita.REFPACIENTE = paciente.CPACIENTE
        cita.FECHA = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 9, 0, 0)
        cita.HORA = cita.FECHA
        cita.HORAFIN = cita.HORA.Value.AddMinutes(30)
        cita.PACIENTE = paciente.NombreCompleto
        cita.Eliminado = False
        cita.IMPORTECL = 100
        cita.IMPORTEDR = 0
        cita.TOTAL = 100

        Dim lineaCita As New LineasCita() With
                {
                    .Cantidad = 1,
                    .DESCRIPCION = "Revision de Piojos",
                    .DescuentoPercent = 0,
                    .ImporteClinica = 100,
                    .ImporteDr = 0,
                    .Liquidada_al_Medico = False,
                    .Total = 100
                }

        cita.LineasCitas.Add(lineaCita)

        context.CITAs.InsertOnSubmit(cita)
        context.SubmitChanges()
    End Sub

    Private Sub ListadoPacientes2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmPacientesListado2
        frm.ShowDialog()
    End Sub

    Private Sub HorasMedicosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New Form1
        frm.ShowDialog()
    End Sub




    Private Sub tst_PefilUsuario_Click(sender As Object, e As EventArgs) Handles tst_PefilUsuario.Click
        Dim frm As New frmUsuarios_ADD(True)
        frm.CODIGO = Globales.Usuario.CODIGO
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub tsmMigrarPaciente_Click(sender As Object, e As EventArgs) Handles tsmMigrarPaciente.Click
        Dim a As New frmMigrarPacientes
        a.ShowDialog()
    End Sub

    Private Sub PacientepordiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientepordiaToolStripMenuItem.Click
        'Dim con As New CMLinqDataContext
        'estadisticas.pacientesPorDia(New Date(2014, 1, 1), New Date(2015, 1, 31), con)
        'Dim a As New test
        'a.ShowDialog()
    End Sub

   
End Class
