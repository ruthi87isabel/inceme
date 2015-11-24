Public Class RoleManager

    Public Enum TipoPermisos
        Ninguno = 1
        Lectura = 2
        Modificar = 3
        Total = 4
    End Enum

    Public Enum Items
        InicioSistema = 0
        Configuracion = 1
        Configuracion_Usuarios = 2
        Configuracion_Roles_y_permisos = 3
        Configuracion_Opciones = 4
        Medicos = 5
        Mutuas = 6
        Proveedores = 7
        'Artículos = 8
        Bancos = 9
        Gastos = 10
        Pacientes = 11
        Pacientes_Datos_Personales = 12
        Pacientes_Antecedentes_Médicos = 13
        Pacientes_Historial_Laboral = 14
        Pacientes_Historiales_Actuales = 15
        Pacientes_Citas = 16
        Pacientes_Partes = 17
        Pacientes_Recetas = 18
        Pacientes_Facturas = 19
        Pacientes_Formas_de_Pago = 20
        Pacientes_Ficheros_y_Multimedia = 21
        Pacientes_Analiticas = 22
        Pacientes_Revisiones_Comparativas = 23
        Pacientes_Servicios_Periodicos = 24
        Pacientes_Recibos = 25
        Pacientes_Derivaciones = 26
        Empresas = 27
        Facturas = 28
        Analiticas = 29
        Generar_Recibos = 30
        Recibos = 31
        Imprimir_Remesa = 32
        Generar_norma_19 = 33
        Citas = 34
        Partes_Altas_Bajas = 35
        Partes_Asistencia = 36
        Generar_Facturas_Recibos_Mensuales = 37
        Alarmas = 38
        Diagnosticos = 39
        Medicamentos = 40
        Indicaciones = 41
        Conceptos_Facturables = 42
        Conceptos_de_Analiticas = 43
        Plantillas_para_Analiticas = 44
        Modelos_Revisiones_Comparativas = 45
        Plantillas_de_texto = 46
        Plantilla_de_Historial = 47
        Paises = 48
        Formas_de_Pago = 49
        Clinica_externas = 50
        Listado_de_Pacientes = 51
        Listado_de_Faltas = 52
        Partes = 53
        Recetas = 54
        Listado_de_Citas = 55
        Ingresos_por_citas_médicos = 56
        Listado_de_Facturas = 57
        Listado_de_Recibos = 58
        Informe_de_Ingresos_y_Gastos = 59
        Copias_de_seguridad = 60
        Importar_Datos = 61
        Renumerar_Facturas = 62
        Bloquear_historial = 63
        Almacen = 65
        Consolidar_Stock = 66
        Comerciales = 67
        Articulos_Stock_Almacen = 68
        Articulos = 69
        Entradas = 70
        Facturas_Compras = 71
        Pedidos_Compras = 72
        Poblaciones = 74
        Facturas_Ventas = 75
        Tickets_Ventas = 76
        Asistente_Facturacion = 77
        ImporteCitas = 78
        ComoConocio = 79
        Pacientes_Debito = 80
        Tarifas = 81
        Procesos = 82
        Auditorias = 83
        Dental = 84
        Dental_Presupuestos = 85
        Comunicaciones = 86
        IncemeWeb = 87
        Salas = 88
        LiquidacionMedico = 89
        Citas_ModificarImporteMedico = 90
        Horarios = 91
        LibroIngresosGastos = 92
        Galeria_Imagenes = 93
        Informes_Medico = 94
        ReportesPersonalizados = 95
        Medicos_Ficheros = 96
        EntregasCuenta = 97
        Pacientes_SeguimientoRevision = 98
        Pacientes_TratamientoSeguimiento = 99
        PagosPaciente = 100
        PagosPaciente_Borrar = 101
        RecetasXml = 102
        Bonos = 103
        MigrarPacientes = 104
        DashB_Cistas_por_estado = 105
        DashB_Relacion_de_Altas = 106
        DashB_Citas_atendidas_por_medicos = 107
        DashB_Citas_por_Especialidad = 108
        DashB_Top_10_Tratamientos = 109
        DashB_Resumen_Dental = 110
    End Enum

#Region "Public Shared Function PermisoPorItem(ByVal ID_Usuario As Integer, ByVal Item As String) As Permisos"
    Public Shared Function PermisoPorItem(ByVal ID_Usuario As Integer, ByVal Item As Items) As TipoPermisos
        'Retorna el nivel de permiso que tiene un usuario para un Item determinado

        Dim adapter As CMDataSetTableAdapters.PERMISOSPORUSUARIOTableAdapter = New CMDataSetTableAdapters.PERMISOSPORUSUARIOTableAdapter()
        Dim table As CMDataSet.PERMISOSPORUSUARIODataTable = New CMDataSet.PERMISOSPORUSUARIODataTable()

        Try

            'Dim usuario As USUARIO
            'usuario.ROLESUSUARIOs.CO()
            
            adapter.Fill(table, ID_Usuario)
            If table.Rows.Count > 0 Then
                'Buscar entre los Permisos
                For Each row As CMDataSet.PERMISOSPORUSUARIORow In table.Rows
                    If row.ID_ROLESITEM = Item Then
                        Return [Enum].Parse(GetType(TipoPermisos), row.PERMISO)
                    End If
                Next
            End If

            'Dim context As New CMLinqDataContext()

            ''Globals.ShowError("Permiso no encontrado", ex)
            ''Si llega aqui no hay ninguna fila asociada al permiso, entonces crearlo

            ''Primero verificar que el item existe
            'Dim itemNuevo As ROLESITEM = (From it In context.ROLESITEMs Where it.ID_ROLESITEM = Item).SingleOrDefault()
            'If itemNuevo Is Nothing Then
            '    itemNuevo = New ROLESITEM()
            '    'Lo inserto
            '    itemNuevo.ID_ROLESITEM = Item
            '    itemNuevo.Nombre = Item.ToString()
            '    context.ROLESITEMs.InsertOnSubmit(itemNuevo)
            '    context.SubmitChanges()

            '    'Ahora para todos los roles insertar el permiso ninguno excepto el adminnistrador

            '    For Each role As ROLE In context.ROLEs
            '        Dim rolePermiso As New ROLESPERMISO()
            '        rolePermiso.ID_ROLES = role.ID_ROLE 'Rol Administradores

            '        If role.ID_ROLE = 1 Then
            '            rolePermiso.ID_PERMISO = 4 'Permiso Total
            '        Else
            '            rolePermiso.ID_PERMISO = 1 ' Ninguno
            '        End If
            '        rolePermiso.ID_ROLESITEM = CType(Item, Integer)
            '        context.ROLESPERMISOs.InsertOnSubmit(rolePermiso)
            '    Next
            '    context.SubmitChanges()
            '    'Retorno el valor de esta misma funcion
            '    Return PermisoPorItem(ID_Usuario, Item)
            'Else
            '    'El roleItem ya existe ya pero no esta asociado el rol de usuario a este rol
            '    Dim usuario As USUARIO = (From u In context.USUARIOs Where u.CODIGO = ID_Usuario).SingleOrDefault()
            '    If Not usuario Is Nothing Then
            '        For Each role As ROLESUSUARIO In usuario.ROLESUSUARIOs
            '            Dim rolePermiso As New ROLESPERMISO()
            '            rolePermiso.ID_ROLES = role.ID_ROLES 'Rol Administradores

            '            If role.ID_ROLES = 1 Then
            '                rolePermiso.ID_PERMISO = 4 'Permiso Total
            '            Else
            '                rolePermiso.ID_PERMISO = 1 ' Ninguno
            '            End If
            '            rolePermiso.ID_ROLESITEM = CType(Item, Integer)
            '            context.ROLESPERMISOs.InsertOnSubmit(rolePermiso)

            '        Next
            '        context.SubmitChanges()
            '    End If

            'End If
            Return TipoPermisos.Ninguno
        Catch ex As Exception
            Globales.ShowError("Error leyendo permisos", ex)
            Return TipoPermisos.Ninguno
        End Try
    End Function
#End Region

#Region "Public Shared Function PermisosPorUsuario(ByVal ID_Usuario As Integer) As Hashtable"
    Public Shared Function PermisosPorUsuario(ByVal ID_Usuario As Integer) As Hashtable
        Dim hash As Hashtable = New Hashtable()

        Dim context As New CMLinqDataContext()

        'Dim permisos As List(Of ROLESPERMISO) = (From per In context.ROLESPERMISOs _
        '                                       Join u In context.ROLESUSUARIOs On u.ID_ROLES Equals per.ID_ROLES _
        '                                       Where u.USUARIO.CODIGO = ID_Usuario _
        '                                       Select per).ToList()

        Dim usuario As USUARIO = (From u In context.USUARIOs Where u.CODIGO = ID_Usuario Select u).SingleOrDefault()
        Dim id_roles As Integer = usuario.ROLESUSUARIOs(0).ID_ROLES

        Dim permisos As List(Of ROLESPERMISO) = (From per In context.ROLESPERMISOs _
                                                   Where per.ID_ROLES = id_roles
                                                   Select per).ToList()

        For Each p As ROLESPERMISO In permisos
            hash.Add(p.ID_ROLESITEM, p)
            If p.ID_ROLESITEM = 92 Then
                Dim a = 2
            End If
        Next

        'Dim adapter As CMDataSetTableAdapters.PERMISOSPORUSUARIOTableAdapter = New CMDataSetTableAdapters.PERMISOSPORUSUARIOTableAdapter()
        'Dim table As CMDataSet.PERMISOSPORUSUARIODataTable = New CMDataSet.PERMISOSPORUSUARIODataTable()

        'Try
        '    adapter.Fill(table, ID_Usuario)
        '    If table.Rows.Count > 0 Then
        '        'Buscar entre los Permisos
        '        For Each row As CMDataSet.PERMISOSPORUSUARIORow In table.Rows
        '            hash.Add(row.ID_ROLESITEM, row)
        '        Next
        '    End If

        '    Return hash
        'Catch ex As Exception
        '    Globals.ShowError("Error leyendo permisos", ex)
        '    Return hash
        'End Try
        Return hash
    End Function
#End Region

End Class
