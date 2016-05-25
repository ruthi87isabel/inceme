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

        'If calendar = False Then
        '    menu_calendario.Checked = False
        'End If
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
        'bt_medicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicos) = RoleManager.TipoPermisos.Ninguno)

        ''Mutuas
        'menu_mutuas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)
        'bt_mutuas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Mutuas) = RoleManager.TipoPermisos.Ninguno)

        ''Proveedores
        'menu_proveedores.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)

        ''Articulos
        'menu_artículos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)

        ''Bancos
        'menu_bancos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Bancos) = RoleManager.TipoPermisos.Ninguno)

        ''Gastos
        'menu_gastos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Gastos) = RoleManager.TipoPermisos.Ninguno)

        'Liquidacion de Médicos
        'LiquidacionDeMédicosToolStripMenuItem.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        'LiquidacionDeMédicosToolStripMenuItem.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Gastos) >= RoleManager.TipoPermisos.Modificar)

        ''Horarios
        'HorariosToolStripMenuItem.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Horarios) >= RoleManager.TipoPermisos.Modificar)

        ''************ End Clinicas ********************

        ''************ Begin Pacientes ************************

        ''Pacientes
        'menu_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'bt_pacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes) = RoleManager.TipoPermisos.Ninguno)

        ''Empresas
        'menu_empresas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)
        'bt_empresas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Empresas) = RoleManager.TipoPermisos.Ninguno)

        ''Facturas
        'menu_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)
        'bt_facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Ninguno)

        ''Analiticas
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Analiticas)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_analíticas.Enabled = False
        'End Select

        ''Generar Recibos
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_Recibos)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_generar_recibos.Enabled = False
        'End Select

        ''Recibos
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Recibos)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_recibos.Enabled = False
        'End Select

        ''Imprimir Remesa
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Imprimir_Remesa)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_imprimir_remesas.Enabled = False
        'End Select

        ''Generar Norma 19
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_norma_19)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_generar_norma19.Enabled = False
        'End Select

        ''Citas
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Citas)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        bt_citas.Enabled = False
        '        menu_citas.Enabled = False
        'End Select

        ''Bajas y Altas
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        bt_bajas_altas.Enabled = False
        '        menu_partes_altas_bajas.Enabled = False
        'End Select

        ''Asistencias
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        bt_asistencias.Enabled = False
        '        menu_partes_asistencia.Enabled = False
        'End Select

        ''Generar Facturas/Recibos Mensuales
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Generar_Facturas_Recibos_Mensuales)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        menu_generar_facturas_recibos.Enabled = False
        'End Select

        ''Pacientes Debito
        'Select Case Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Debito)
        '    Case RoleManager.TipoPermisos.Ninguno
        '        btnDebitoPaciente.Enabled = False
        'End Select

        'frmProcesosMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno)

        ''Dashboard
        'menu_DashBoard.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_estado) = RoleManager.TipoPermisos.Ninguno) Or
        '                         Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno) Or
        '                         Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno) Or
        '                         Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno) Or
        '                         Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno) Or
        '                         Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        ''Dental
        'PresupuestosDentalesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        'PresupuestosDentalesToolStripMenuItem.Visible = Globales.Configuracion.Dental_ModuloActivo

        ''************ End Pacientes ********************



        ''************ Begin Mantenimiento ********************

        'menu_alarmas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Alarmas) = RoleManager.TipoPermisos.Ninguno)
        'menu_diagnóstico.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        'menu_medicamentos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno)
        'menu_indicaciones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Indicaciones) = RoleManager.TipoPermisos.Ninguno)

        'menu_conceptos_facturables.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)
        ''ConceptosFacturablesDentalToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        'FamiliasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno)

        'menu_conceptos_analíticas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Conceptos_de_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        'menu_plantillas_analíticas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        'menu_modelo_revisiones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Modelos_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno)
        'menu_plantillas_texto.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantillas_de_texto) = RoleManager.TipoPermisos.Ninguno)
        'menu_plantillas_historial.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Plantilla_de_Historial) = RoleManager.TipoPermisos.Ninguno)
        'menu_paises.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Paises) = RoleManager.TipoPermisos.Ninguno)
        'menu_formas_pago.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno)
        'menu_clínicas_externas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Clinica_externas) = RoleManager.TipoPermisos.Ninguno)
        'Me.ComoNosConocióToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)

        'AlmacenToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno)
        'PoblacionesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno)

        'TarifasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tarifas) = RoleManager.TipoPermisos.Ninguno)

        'SalasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas) = RoleManager.TipoPermisos.Ninguno)

        'GaleriaDeImágenesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Galeria_Imagenes) = RoleManager.TipoPermisos.Ninguno)

        ''************ End Mantenimiento ********************

        ''************ Begin Listados ********************
        'menu_ListadoDePacientes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Pacientes) = RoleManager.TipoPermisos.Ninguno)
        'menu_ListadoDeFaltas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Faltas) = RoleManager.TipoPermisos.Ninguno)
        'menu_Partes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Ninguno)
        'menu_Recetas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Recetas) = RoleManager.TipoPermisos.Ninguno)
        'menu_ListadoDeCitas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Citas) = RoleManager.TipoPermisos.Ninguno)

        ''Ingresos por citas/medicos
        'menu_CitasAgrupadasPorEspecialista.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)

        ''Ingresos por procedencia de cita (no tiene enumerador, usado el mismo que el Ingresos por Citas)
        'menu_CitasAgrupadasPorProcedencia.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Ingresos_por_citas_médicos) = RoleManager.TipoPermisos.Ninguno)

        'menu_ListadoDeFacturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Facturas) = RoleManager.TipoPermisos.Ninguno)
        'menu_ListadoDeRecibos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Listado_de_Recibos) = RoleManager.TipoPermisos.Ninguno)

        ''Informe de Ingresos y Saldos
        'menu_LibroDiario.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Informe_de_Ingresos_y_Gastos) = RoleManager.TipoPermisos.Ninguno)

        'ComoNosConocióToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)
        'ComoNosConocióToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno)

        'PacientesPorDiagnosticosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        'DiagnosticosEmitidosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) = RoleManager.TipoPermisos.Ninguno)
        ''DerivacionesToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)
        ''DerivacionesToolStripMenuItem1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)

        ''EstadisticasToolStripMenuItem.Enabled = ComoNosConocióToolStripMenuItem.Enabled Or PacientesPorDiagnosticosToolStripMenuItem.Enabled


        ''************ End Listados ********************

        'menu_Configuracion.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno)
        'menu_Usuarios.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Usuarios) = RoleManager.TipoPermisos.Ninguno)
        'menu_roles.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Roles_y_permisos) = RoleManager.TipoPermisos.Ninguno)
        'menu_opciones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Configuracion_Opciones) = RoleManager.TipoPermisos.Ninguno)
        'menu_CopiasDeSeguridad.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Copias_de_seguridad) = RoleManager.TipoPermisos.Ninguno)
        'menu_ImportarDatos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Importar_Datos) = RoleManager.TipoPermisos.Ninguno)
        'menu_RenumerarFacturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Renumerar_Facturas) = RoleManager.TipoPermisos.Ninguno)

        ''************ Begin TPV ********************
        'ProveedoresToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno)
        'ArticulosToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno)
        'EntradasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno)
        'PedidosAProveedorToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pedidos_Compras) = RoleManager.TipoPermisos.Ninguno)
        'FacturasProveedorToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Compras) = RoleManager.TipoPermisos.Ninguno)
        'FacturasToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Facturas_Ventas) = RoleManager.TipoPermisos.Ninguno)
        'TicketsToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno)
        'ConsolidacionStockToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Consolidar_Stock) = RoleManager.TipoPermisos.Ninguno)

        ''************ End TPV ********************

        ''************ Begin Utilidades ********************
        'BuscarActualizacionesToolStripMenuItem.Enabled = Globales.Usuario.EsAdministrador() '(Globales.Usuario.ADMINISTRADOR = "S")
        'AuditoriaToolStripMenuItem.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Auditorias) = RoleManager.TipoPermisos.Ninguno)

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

    Private Sub SearchText_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchText.KeyUp
        If SearchText.Text = " " And e.KeyData = Keys.Space Then
            SearchText.Text = ""
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
        If SearchText.Text.Length > 0 Then
            Dim query As String = My.Resources.queryListadoPacientes
            query = query.Insert(query.IndexOf("GROUP"), _
                        " WHERE CONVERT(varchar(10),PACIENTES.CPACIENTE)= '" & SearchText.Text & "' OR PACIENTES.CODIGOPROPIO = '" & SearchText.Text &
                          "' OR PACIENTES.DNI='" & SearchText.Text & "' OR (PACIENTES.NOMBRE + ' ' + ISNULL(PACIENTES.APELLIDO1, '') + ' ' + ISNULL(PACIENTES.APELLIDO2, '')) LIKE '%" & SearchText.Text &
                          "%' AND (PACIENTES.Eliminado is NULL or PACIENTES.Eliminado = 0)")
            query += " ORDER BY PACIENTES.CPACIENTE DESC "
            Dim dt As DataTable = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, query).Tables(0)
            If dt.Rows.Count() = 1 Then
                Dim context As New CMLinqDataContext
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

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        Dim _dash As Form_DashBoard = New Form_DashBoard()
        _dash.Show()
        GC.Collect()
    End Sub

    Private Sub Citas_Click(sender As Object, e As EventArgs) Handles Citas.Click
        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Factura_Click(sender As Object, e As EventArgs) Handles Factura.Click
        Dim frm As New frmFacturasM()
        frm.ShowDialog()

        FreeMemory.FlushMemory()
    End Sub

    Private Sub Medico_Click(sender As Object, e As EventArgs) Handles Medico.Click
        Dim medListado As New frmMedicosListado()
        medListado.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub DebitoPaciente_Click(sender As Object, e As EventArgs) Handles DebitoPaciente.Click
        Dim frm As New frmPacienteDebito()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub Paciente_Click(sender As Object, e As EventArgs) Handles Paciente.Click
        Dim frmPaciente As New frmPacientesListado
        frmPaciente.ShowDialog()
        FreeMemory.FlushMemory()
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
            Dim frm As New frmProcesos()
            frm.ShowDialog()
        ElseIf ExplorerBar1.Groups("Group2").Items("Item26").Selected Then
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
        ElseIf ExplorerBar1.Groups("Group3").Items("Item17").Selected Then
            If RoleManager.PermisoPorItem(fIduser, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
                MsgBox("No tiene permisos para acceder a esta parte de la aplicación.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim frm As frmAlmacen = New frmAlmacen()
            frm.Modo = Globales.ModoParaFormas.Edicion
            frm.ShowDialog()
            GC.Collect()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item17").Selected Then
            Dim frm As New frmSalas
            frm.Show()
        ElseIf ExplorerBar1.Groups("Group3").Items("Item18").Selected Then
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

        If ExplorerBar1.Groups("Group9").Items("Item1").Selected Then
            Me.DialogResult = Windows.Forms.DialogResult.No
            GC.Collect()
            Me.Close()
        ElseIf ExplorerBar1.Groups("Group9").Items("Item2").Selected Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

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
        If ExplorerBar1.Groups("Group9").Expanded Then ExplorerBar1.Groups("Group9").Expanded = False
    End Sub

    Private Sub ExplorerBar1_GroupExpanded(sender As Object, e As Janus.Windows.ExplorerBar.GroupEventArgs) Handles ExplorerBar1.GroupExpanded

        UiGroupBox1.Visible = False
        UiGroupBox2.Visible = False
        UiGroupBox3.Visible = False

        If ExplorerBar1.Groups("Group1").Expanded Then UiGroupBox2.Visible = True
        If ExplorerBar1.Groups("Group2").Expanded Then UiGroupBox3.Visible = True

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
        If ExplorerBar1.Groups("Group9").Expanded Then a += 1
        If a = 1 Then
            UiGroupBox1.Visible = True
            UiGroupBox2.Visible = False
            UiGroupBox3.Visible = False
        End If
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

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        ListadoDeEmpresas()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim frm As New frmFacturasM()
        frm.ShowDialog()
        FreeMemory.FlushMemory()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim frm As New frmPartes_AsistenteFacturacion()
        frm.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim _generar As New form_generar_recfact
        _generar.ShowInTaskbar = False
        _generar.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim adapter As New CMDataSetTableAdapters.ANALITICASTableAdapter
        adapter.Fill(Me.CMDataSet.ANALITICAS)

        Dim source As New BindingSource
        source.DataSource = CMDataSet
        source.DataMember = "ANALITICAS"

        MostrarListado("Listado de analiticas", source, RoleManager.Items.Analiticas)
        GC.Collect()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim _generar_recibos As form_generar_recibos = New form_generar_recibos(Globales.Configuracion)
        _generar_recibos.ShowInTaskbar = False
        _generar_recibos.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Me.RECIBOSTableAdapter.Fill(Me.CMDataSet.RECIBOS)
        Dim _name As String = "Listado de Modelos de Recibos"
        MostrarListado(_name, RECIBOSBindingSource, RoleManager.Items.Recibos)
        GC.Collect()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim _remesas As form_remesa_de_recibos = New form_remesa_de_recibos(Globales.Configuracion)
        _remesas.ShowInTaskbar = False
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Dim frm As New frmNorma19()
        frm.ShowDialog()

        GC.Collect()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Dim _remesas As form_bonos_no_agotados = New form_bonos_no_agotados()
        _remesas.ShowDialog()
        GC.Collect()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Dim frm As New frmCalendarioCitas()
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        FreeMemory.FlushMemory()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Dim frm As New frmPartes()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Dim frm As New frmPartesAsistencia()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Dim frm As New frmProcesos()
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
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

End Class