Imports System.Xml
Imports System.IO

Public Class listado_control

    Public currentlistar As Integer
    Public fSeleccion As String
    Public fName As List(Of String) = New List(Of String)
    Public fDBName As List(Of String) = New List(Of String)
    Public fType As List(Of Type) = New List(Of Type)
    Public fIsNumberOnlyDesde As Boolean = False
    Public seleccionando As Boolean = False
    Public IDSELECCIONADO As Object

    Dim fTable As String
    Dim fWhere As String
    Dim fOrder As String

    Public PTable As String
    Public PWhere As String
    Public POrder As String

    Public codpropio As Boolean = False

    Public Configuracion As Configuracion


    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub listado_control_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Aplicar los permisos
        Dim permiso As RoleManager.TipoPermisos = Globales.Usuario.Permisos(CurrentList)

        'Select Case Globals.Usuario.Permisos(CurrentList)
        '    Case RoleManager.TipoPermisos.Lectura
        '        bt_nuevo.Enabled = False
        '        bt_borrar.Enabled = False
        '        bt_modificar.Enabled = False
        '    Case RoleManager.TipoPermisos.Modificar
        '        bt_borrar.Enabled = False
        '    Case RoleManager.TipoPermisos.Ninguno
        '        'Me.Enabled = False
        'End Select

        bt_nuevo.Enabled = permiso > RoleManager.TipoPermisos.Lectura
        bt_borrar.Enabled = permiso > RoleManager.TipoPermisos.Lectura
        bt_modificar.Enabled = permiso > RoleManager.TipoPermisos.Lectura

        bt_refrescar_Click(sender, e)
        MostrarFechas()
        
    End Sub

    Private Sub bt_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevo.Click
        If Me.CurrentList = RoleManager.Items.Medicos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Medicos, "Insertar ", "Nuevo", "En listado control")

            'Dim _nuevo_medico As form_medico = New form_medico("Ficha del Médico-Añadir", Enums.Accion.Insertar)
            '_nuevo_medico.ShowInTaskbar = False
            '_nuevo_medico.ShowDialog()
            'Dim _nuevo_medico As frmMedicos_ADD = New form_medico("Ficha del Médico-Añadir", Enums.Accion.Insertar)
            '_nuevo_medico.ShowInTaskbar = False
            '_nuevo_medico.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Mutuas, "Insertar ", "Nuevo", "En listado control")
            Dim _nueva_mutua As form_mutuas = New form_mutuas("Ficha de Mutua-Añadir", Enums.Accion.Insertar)
            _nueva_mutua.ShowInTaskbar = False
            _nueva_mutua.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Formas_de_Pago, "Insertar ", "Nuevo", "En listado control")
            Dim _nueva_forma_pago As form_formas_pago = New form_formas_pago("Ficha forma de pago-Añadir", Enums.Accion.Insertar)
            _nueva_forma_pago.ShowInTaskbar = False
            _nueva_forma_pago.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Proveedores Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Proveedores, "Insertar ", "Nuevo", "En listado control")
            Dim _nueva_proveedores As form_proveedores = New form_proveedores("Ficha proveedores-Añadir", Enums.Accion.Insertar)
            _nueva_proveedores.ShowInTaskbar = False
            _nueva_proveedores.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Bancos, "Insertar ", "Nuevo", "En listado control")
            Dim _nuevo_banco As form_bancos = New form_bancos("Ficha bancos-Añadir", Enums.Accion.Insertar)
            _nuevo_banco.ShowInTaskbar = False
            _nuevo_banco.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Conceptos_Facturables, "Insertar ", "Nuevo", "En listado control")
            Dim _nuevo_cf As form_conceptos_facturables = New form_conceptos_facturables("Ficha-Añadir", Enums.Accion.Insertar)
            _nuevo_cf.ShowInTaskbar = False
            _nuevo_cf.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Paises Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Paises, "Insertar ", "Nuevo", "En listado control")
            Dim _nuevo_pais As form_paises = New form_paises("País-Añadir", Enums.Accion.Insertar)
            _nuevo_pais.ShowInTaskbar = False
            _nuevo_pais.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Conceptos_de_Analiticas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Conceptos_de_Analiticas, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_concepto As form_concepto_analitica = New form_concepto_analitica("Ficha-Añadir", Enums.Accion.Insertar)
            _nuevo_concepto.ShowInTaskbar = False
            _nuevo_concepto.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Derivaciones, "Insertar ", "Nuevo", "En listado control")

            Dim _nueva_clinica As form_clinicas = New form_clinicas("Ficha-Añadir", Enums.Accion.Insertar)
            _nueva_clinica.ShowInTaskbar = False
            _nueva_clinica.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Articulos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Articulos, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_articulo As form_articulos = New form_articulos("Ficha de artículos-Añadir", Enums.Accion.Insertar)
            _nuevo_articulo.ShowInTaskbar = False
            _nuevo_articulo.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Medicamentos, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_medicamento As form_medicamento = New form_medicamento("Ficha de medicamento-Añadir", Enums.Accion.Insertar)
            _nuevo_medicamento.ShowInTaskbar = False
            _nuevo_medicamento.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantillas_de_texto, "Insertar ", "Nuevo", "En listado control")

            Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Insertar)
            _nueva_plantilla.ShowInTaskbar = False
            _nueva_plantilla.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Diagnosticos, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_diagnostico As form_diagnostico = New form_diagnostico("Ficha de diagnostico-Añadir", Enums.Accion.Insertar)
            _nuevo_diagnostico.ShowInTaskbar = False
            _nuevo_diagnostico.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Gastos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Gastos, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_gasto As form_gastos = New form_gastos("Ficha de gastos-Añadir", Enums.Accion.Insertar)
            _nuevo_gasto.ShowInTaskbar = False
            _nuevo_gasto.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Indicaciones, "Insertar ", "Nuevo", "En listado control")

            Dim _nueva_ind As form_indicaciones = New form_indicaciones("Ficha de indicaciones-Añadir", Enums.Accion.Insertar)
            _nueva_ind.ShowInTaskbar = False
            _nueva_ind.ShowDialog()
            bt_refrescar_Click(sender, e)
        ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Insertar ", "Nuevo", "En listado control")

            Dim _nueva_plantilla As form_plantilla_historial = New form_plantilla_historial("Ficha de indicaciones-Añadir", Enums.Accion.Insertar)
            _nueva_plantilla.ShowInTaskbar = False
            _nueva_plantilla.ShowDialog()
            bt_refrescar_Click(sender, e)
        ElseIf Me.CurrentList = RoleManager.Items.Partes_Asistencia Then
            'Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Partes_Asistencia, "Insertar ", "Nuevo", "En listado control")

            'Dim _nueva_asistencia As form_parte_asistencia = New form_parte_asistencia("Ficha de asistencia-Añadir", Enums.Accion.Insertar)
            '_nueva_asistencia.ShowInTaskbar = False
            '_nueva_asistencia.ShowDialog()
            'bt_refrescar_Click(sender, e)
        ElseIf Me.CurrentList = RoleManager.Items.Partes_Altas_Bajas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Partes_Altas_Bajas, "Insertar ", "Nuevo", "En listado control")

            'Dim _nueva_alta As form_alta_baja_ex = New form_alta_baja_ex("Ficha de alta/baja-Añadir", Enums.Accion.Insertar)
            '_nueva_alta.ShowInTaskbar = False
            '_nueva_alta.ShowDialog()
            'bt_refrescar_Click(sender, e)
        ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Empresas, "Insertar ", "Nuevo", "En listado control")

            Dim _nueva_empresa As form_empresa = New form_empresa("Ficha de empresa-Añadir", Enums.Accion.Insertar)
            _nueva_empresa.ShowInTaskbar = False
            _nueva_empresa.ShowDialog()
            bt_refrescar_Click(sender, e)

            'NUEVO ANNADIDO
        ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then

            'Chequeo del Demo
            If My.Settings.Demo = True Then
                'Contar los pacientes
                If Me.PACIENTESTableAdapter.GetDataBy100Paciente().Count > 4 Then
                    MessageBox.Show("El limite de 5 pacientes ha sido rebasado para este Demo")
                    bt_nuevo.Enabled = False
                    Return
                End If
            End If

            ' Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de pacientes-Añadir", Enums.Accion.Insertar)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de pacientes-Añadir", Enums.Accion.Insertar)
            _nuevo_paciente.ShowInTaskbar = False
            _nuevo_paciente.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Alarmas, "Insertar ", "Nuevo", "En listado control")

            Dim _add_alarma As form_alarmas = New form_alarmas("Ficha de Alarmas-Añadir", Enums.Accion.Insertar)
            _add_alarma.ShowInTaskbar = False
            _add_alarma.ShowDialog()
            bt_refrescar_Click(sender, e)
            '//////////////////////////////////////////////////////////////////////
        ElseIf Me.CurrentList = RoleManager.Items.Facturas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Facturas, "Insertar ", "Nuevo", "En listado control")

            'Dim _add_factura As form_factura = New form_factura("Ficha de Factura-Añadir", Enums.Accion.Insertar)
            '_add_factura.ShowInTaskbar = False
            '_add_factura.ShowDialog()

            Globales.Factura_CreaNueva()

            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Analiticas, "Insertar ", "Nuevo", "En listado control")

            Dim _add_analitica As form_analiticas = New form_analiticas("Ficha de Analiticas-Añadir", Enums.Accion.Insertar)
            _add_analitica.ShowInTaskbar = False
            _add_analitica.ShowDialog()
            bt_refrescar_Click(sender, e)
        ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
            Dim _add_analitica As form_plantilla__analiticas = New form_plantilla__analiticas("Ficha de Plantilla de analiticas-Añadir", Enums.Accion.Insertar)
            _add_analitica.ShowInTaskbar = False
            _add_analitica.ShowDialog()
            bt_refrescar_Click(sender, e)


        ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Modelos_Revisiones_Comparativas, "Insertar ", "Nuevo", "En listado control")

            Dim _nuevo_modelo_revisiones As form_modelo_rev_comparativoas = New form_modelo_rev_comparativoas("Modelo de Revisiones Comparativas", Enums.Accion.Insertar)
            _nuevo_modelo_revisiones.ShowInTaskbar = False
            _nuevo_modelo_revisiones.ShowDialog()
            bt_refrescar_Click(sender, e)

        ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Recibos, "Insertar ", "Nuevo", "En listado control")

            Dim _recibo As form_recibos = New form_recibos("Recibo", Enums.Accion.Insertar)
            _recibo.ShowInTaskbar = False
            _recibo.ShowDialog()
            bt_refrescar_Click(sender, e)

        End If

        bt_ultima_Click(sender, e)

    End Sub

    Private Sub bt_refrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_refrescar.Click

        ClearValues()
        Try
            If Me.CurrentList = RoleManager.Items.Medicos Then
                Me.MEDICOSTableAdapter.Fill(CMDataSet.MEDICOS)
                gv_listado.DataSource = Me.MEDICOSBindingSource
                nav_listado.BindingSource = Me.MEDICOSBindingSource
                LlenarListaCampos("Medicos")

            ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                Me.MUTUASTableAdapter.Fill(CMDataSet.MUTUAS)
                gv_listado.DataSource = Me.MUTUASBindingSource
                nav_listado.BindingSource = Me.MUTUASBindingSource
                Borra()
                LlenarListaCampos("Mutuas")

            ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
                Me.FORMASPAGOTableAdapter.Fill(CMDataSet.FORMASPAGO)
                gv_listado.DataSource = Me.FORMASPAGOBindingSource
                nav_listado.BindingSource = Me.FORMASPAGOBindingSource
                LlenarListaCampos("FormasPago")

            ElseIf Me.CurrentList = RoleManager.Items.Proveedores Then
                Me.PROVEEDORESTableAdapter.Fill(CMDataSet.PROVEEDORES)
                gv_listado.DataSource = Me.PROVEEDORESBindingSource
                nav_listado.BindingSource = Me.PROVEEDORESBindingSource
                Borra()
                LlenarListaCampos("Proveedores")

            ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
                Me.BANCOSTableAdapter.Fill(CMDataSet.BANCOS)
                gv_listado.DataSource = Me.BANCOSBindingSource
                nav_listado.BindingSource = Me.BANCOSBindingSource
                Borra()
                LlenarListaCampos("Bancos")

            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)
                gv_listado.DataSource = Me.CONCEPTOSFRABindingSource
                nav_listado.BindingSource = Me.CONCEPTOSFRABindingSource
                Borra()
                LlenarListaCampos("ConceptosFra")


            ElseIf Me.CurrentList = RoleManager.Items.Paises Then
                Me.PAISESTableAdapter.Fill(CMDataSet.PAISES)
                gv_listado.DataSource = Me.PAISESBindingSource
                nav_listado.BindingSource = Me.PAISESBindingSource
                Borra()
                LlenarListaCampos("Paises")

            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_de_Analiticas Then
                Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)
                gv_listado.DataSource = Me.CONCEPTOSANALITICABindingSource
                nav_listado.BindingSource = Me.CONCEPTOSANALITICABindingSource
                Borra()
                LlenarListaCampos("ConceptosAnalitica")

            ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
                Me.DERIVACIONES_DESTINOSTableAdapter.Fill(CMDataSet.DERIVACIONES_DESTINOS)
                gv_listado.DataSource = Me.DERIVACIONES_DESTINOSBindingSource
                nav_listado.BindingSource = Me.DERIVACIONES_DESTINOSBindingSource
                Borra()
                LlenarListaCampos("Derivaciones_Destinos")

            ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                Me.ALARMASTableAdapter.Fill(CMDataSet.ALARMAS)
                gv_listado.DataSource = Me.ALARMASBindingSource
                nav_listado.BindingSource = Me.ALARMASBindingSource
                Borra()
                LlenarListaCampos("Alarmas")

            ElseIf Me.CurrentList = RoleManager.Items.Articulos Then
                Me.ARTICULOSTableAdapter.Fill(CMDataSet.ARTICULOS)
                gv_listado.DataSource = Me.ARTICULOSBindingSource
                nav_listado.BindingSource = Me.ARTICULOSBindingSource
                Borra()
                LlenarListaCampos("Articulos")

            ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
                Me.MEDICAMENTOSTableAdapter.Fill(CMDataSet.MEDICAMENTOS)
                gv_listado.DataSource = Me.MEDICAMENTOSBindingSource
                nav_listado.BindingSource = Me.MEDICAMENTOSBindingSource
                Borra()
                LlenarListaCampos("Medicamentos")

            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
                Me.PLANTILLASTableAdapter.Fill(CMDataSet.PLANTILLAS)

                gv_listado.DataSource = Me.PLANTILLASBindingSource
                nav_listado.BindingSource = Me.PLANTILLASBindingSource
                Borra()
                LlenarListaCampos("Plantillas")

            ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
                Me.DIAGNOSTICOSTableAdapter.Fill(CMDataSet.DIAGNOSTICOS)
                gv_listado.DataSource = Me.DIAGNOSTICOSBindingSource
                nav_listado.BindingSource = Me.DIAGNOSTICOSBindingSource
                Borra()
                LlenarListaCampos("Diagnosticos")

            ElseIf Me.CurrentList = RoleManager.Items.Gastos Then
                Me.GASTOSTableAdapter.Fill(CMDataSet.GASTOS)
                gv_listado.DataSource = Me.GASTOSBindingSource
                nav_listado.BindingSource = Me.GASTOSBindingSource
                Borra()
                LlenarListaCampos("Gastos")

            ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
                Me.INDICACIONESTableAdapter.Fill(CMDataSet.INDICACIONES)
                gv_listado.DataSource = Me.INDICACIONESBindingSource
                nav_listado.BindingSource = Me.INDICACIONESBindingSource
                Borra()
                LlenarListaCampos("Indicaciones")

            ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
                Me.PLANTILLA_HISTORIALESTableAdapter.Fill(CMDataSet.PLANTILLA_HISTORIALES)
                gv_listado.DataSource = Me.PLANTILLA_HISTORIALESBindingSource
                nav_listado.BindingSource = Me.PLANTILLA_HISTORIALESBindingSource
                Borra()
                LlenarListaCampos("PlantillaHistoriales")

            ElseIf Me.CurrentList = RoleManager.Items.Partes_Asistencia Then
                Me.PARTESTableAdapter.Fill(CMDataSet.PARTES)
                Me.ASISTENCIASTableAdapter.Fill(CMDataSet.ASISTENCIAS)
                Dim _binding As BindingSource = New BindingSource()
                Dim _datap As CMDataSet.PARTESDataTable = PARTESTableAdapter.GetData()
                Dim i As Integer
                Dim Id As Integer
                Dim tipo As String
                For i = 0 To _datap.Rows.Count - 1
                    Id = _datap.Rows(i).Item("IDPARTE")
                    tipo = _datap.Rows(i).Item("TIPO")
                    If tipo = "S" Then
                        _binding.Add(_datap.Rows(i))
                    End If
                Next
                If _binding.Count > 0 Then
                    gv_listado.DataSource = _binding
                    nav_listado.BindingSource = _binding

                    Borra()
                Else
                    gv_listado.Rows.Clear()
                End If
                LlenarListaCampos("Partes")
                fWhere = " Where (TIPO='S')"
            ElseIf Me.CurrentList = RoleManager.Items.Partes_Altas_Bajas Then
                Me.PARTESTableAdapter.Fill(CMDataSet.PARTES)
                Me.ALTASTableAdapter.Fill(CMDataSet.ALTAS)
                Me.BAJASTableAdapter.Fill(CMDataSet.BAJAS)
                Dim _binding As BindingSource = New BindingSource()
                Dim _datap As CMDataSet.PARTESDataTable = PARTESTableAdapter.GetData()
                Dim i As Integer
                Dim Id As Integer
                Dim tipo As String
                For i = 0 To _datap.Rows.Count - 1
                    Id = _datap.Rows(i).Item("IDPARTE")
                    tipo = _datap.Rows(i).Item("TIPO")
                    If tipo <> "S" Then
                        _binding.Add(_datap.Rows(i))
                    End If
                Next

                If _binding.Count > 0 Then
                    gv_listado.DataSource = _binding
                    nav_listado.BindingSource = _binding
                    Borra()
                Else
                    gv_listado.Rows.Clear()
                End If
                LlenarListaCampos("Partes")
                fWhere = " Where (TIPO<>'S')"
            ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                Me.EMPRESASTableAdapter.Fill(CMDataSet.EMPRESAS)
                gv_listado.DataSource = Me.EMPRESASBindingSource
                nav_listado.BindingSource = Me.EMPRESASBindingSource
                Borra()
                LlenarListaCampos("Empresas")

                'NUEVO ANNADIDO
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then
                Me.PACIENTESTableAdapter.FillBy100Paciente(CMDataSet.PACIENTES)
                gv_listado.DataSource = Me.PACIENTESBindingSource
                nav_listado.BindingSource = Me.PACIENTESBindingSource
                Borra()
                LlenarListaCampos("Pacientes")

            ElseIf Me.CurrentList = RoleManager.Items.Facturas Then

                If PTable = "FACTURAS" Then
                    Me.FACTURASTableAdapter.FillFacturas(CMDataSet.FACTURAS, PTable, PWhere, POrder)
                Else
                    Me.FACTURASTableAdapter.Fill(CMDataSet.FACTURAS)
                End If

                gv_listado.DataSource = Me.FACTURASBindingSource
                nav_listado.BindingSource = Me.FACTURASBindingSource
                Borra()
                LlenarListaCampos("Facturas")

            ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
                If Not PTable Is Nothing Then
                    If Me.PTable.Trim.Length > 0 Then Me.ANALITICASTableAdapter.FillAnaliticas(CMDataSet.ANALITICAS, Me.PTable, Me.PWhere, Me.POrder)
                Else
                    Me.ANALITICASTableAdapter.Fill(CMDataSet.ANALITICAS)
                End If

                gv_listado.DataSource = Me.ANALITICASBindingSource
                nav_listado.BindingSource = Me.ANALITICASBindingSource
                Borra()
                LlenarListaCampos("Analiticas")

                

            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
                Me.PLANTILLAANALITICASTableAdapter.Fill(CMDataSet.PLANTILLAANALITICAS)
                gv_listado.DataSource = Me.PLANTILLAANALITICASBindingSource
                nav_listado.BindingSource = Me.PLANTILLAANALITICASBindingSource
                LlenarListaCampos("PlantillaAnaliticas")


            ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
                Me.MODELOSCOMPARATIVATableAdapter.Fill(CMDataSet.MODELOSCOMPARATIVA)
                gv_listado.DataSource = Me.MODELOSCOMPARATIVABindingSource
                nav_listado.BindingSource = Me.MODELOSCOMPARATIVABindingSource
                Borra()
                LlenarListaCampos("ModelosComparativa")

            ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
                Me.RECIBOSTableAdapter.FillRecibosGenerados(CMDataSet.RECIBOS)
                gv_listado.DataSource = Me.RECIBOSBindingSource
                nav_listado.BindingSource = Me.RECIBOSBindingSource
                Borra()
                LlenarListaCampos("Recibos")
            End If



            MostrarColumnas()

            If Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                gv_listado.Columns("IMPORTE").Visible = (Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno)
            End If

            If Me.CurrentList = RoleManager.Items.Analiticas Then
                'si es analitica aplico este permiso
                gv_listado.Columns("IMPORTE").Visible = Not (Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Ninguno)
                gv_listado.Columns("RECIBIDA").Visible = True
                btAnaliticasSinRecibir.Visible = True


            End If

            FillCombobox()
            fTable = QueryTable()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al cargar el listado")
        End Try
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If gv_listado.Rows.Count > 0 Then
            If Me.CurrentList = RoleManager.Items.Medicos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMEDICO").Value
                'Dim _nuevo_medico As form_medico = New form_medico("Ficha del Médico-Editar", Enums.Accion.Modificar, Id)
                '_nuevo_medico.ShowInTaskbar = False
                'Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Medicamentos, "Abrir ", Id.ToString(), "En listado control")

                'If _nuevo_medico.ShowDialog() = DialogResult.OK Then
                bt_refrescar_Click(sender, e)
                'End If
            ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMUTUA").Value
                Dim _nueva_mutua As form_mutuas = New form_mutuas("Ficha de Mutua-Editar", Enums.Accion.Modificar, Id)

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Mutuas, "Abrir ", Id.ToString(), "En listado control")

                _nueva_mutua.ShowInTaskbar = False
                _nueva_mutua.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_forma_pago As form_formas_pago = New form_formas_pago("Ficha forma de pago-Editar", Enums.Accion.Modificar, Id)
                _nueva_forma_pago.ShowInTaskbar = False
                _nueva_forma_pago.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Proveedores Then

                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CPROVEEDOR").Value
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Proveedores, "Abrir ", Id.ToString(), "En listado control")

                Dim _nueva_proveedores As form_proveedores = New form_proveedores("Ficha de proveedor-Editar", Enums.Accion.Modificar, Id)
                _nueva_proveedores.ShowInTaskbar = False
                _nueva_proveedores.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
                Dim entidad As String = gv_listado.SelectedRows.Item(0).Cells("ENTIDAD").Value
                Dim oficina As String = gv_listado.SelectedRows.Item(0).Cells("OFICINA").Value

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Bancos, "Abrir ", entidad & oficina, "En listado control")

                Dim _nuevo_banco As form_bancos = New form_bancos("Ficha de banco-Editar", Enums.Accion.Modificar, entidad, oficina)
                _nuevo_banco.ShowInTaskbar = False
                _nuevo_banco.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Conceptos_Facturables, "Abrir ", Id.ToString(), "En listado control")

                Dim _nueva_cf As form_conceptos_facturables = New form_conceptos_facturables("Ficha -Editar", Enums.Accion.Modificar, Id)
                _nueva_cf.ShowInTaskbar = False
                _nueva_cf.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Paises Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                If Id <> 1 Then
                    Dim _nuevo_pais As form_paises = New form_paises("País-Editar", Enums.Accion.Modificar, Id)

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Paises, "Abrir ", Id.ToString(), "En listado control")

                    _nuevo_pais.ShowInTaskbar = False
                    _nuevo_pais.ShowDialog()
                    bt_refrescar_Click(sender, e)
                Else
                    MessageBox.Show("El país España no puede ser modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_de_Analiticas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nuevo_concepto As form_concepto_analitica = New form_concepto_analitica("Ficha-Editar", Enums.Accion.Modificar, Id)

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Conceptos_de_Analiticas, "Abrir ", Id.ToString(), "En listado control")

                _nuevo_concepto.ShowInTaskbar = False
                _nuevo_concepto.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pacientes_Derivaciones, "Abrir ", Id.ToString(), "En listado control")

                Dim _nueva_clinica As form_clinicas = New form_clinicas("Ficha-Editar", Enums.Accion.Modificar, Id)
                _nueva_clinica.ShowInTaskbar = False
                _nueva_clinica.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CALARMA").Value
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Alarmas, "Abrir ", Id.ToString(), "En listado control")

                Dim _nueva_alarma As form_alarmas = New form_alarmas("Ficha de alarma-Editar", Enums.Accion.Modificar, Id)
                _nueva_alarma.ShowInTaskbar = False
                _nueva_alarma.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Articulos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CARTICULO").Value
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Medicamentos, "Abrir ", Id.ToString(), "En listado control")

                Dim _nuevo_articulo As form_articulos = New form_articulos("Ficha de artículo-Editar", Enums.Accion.Modificar, Id)
                _nuevo_articulo.ShowInTaskbar = False
                _nuevo_articulo.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMEDICAMENTO").Value
                Dim _nuevo_medicamento As form_medicamento = New form_medicamento("Ficha de medicamento-Editar", Enums.Accion.Modificar, Id)
                _nuevo_medicamento.ShowInTaskbar = False
                _nuevo_medicamento.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Modificar, Id)
                _nueva_plantilla.ShowInTaskbar = False
                _nueva_plantilla.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDDIAGNOSTICO").Value
                Dim _nuevo_diagnostico As form_diagnostico = New form_diagnostico("Ficha de diagnostico-Editar", Enums.Accion.Modificar, Id)
                _nuevo_diagnostico.ShowInTaskbar = False
                _nuevo_diagnostico.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Gastos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDGASTO").Value
                Dim _nuevo_gasto As form_gastos = New form_gastos("Ficha de gastos-Editar", Enums.Accion.Modificar, Id)
                _nuevo_gasto.ShowInTaskbar = False
                _nuevo_gasto.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CINDICACIONES").Value
                Dim _nueva_ind As form_indicaciones = New form_indicaciones("Ficha de indicaciones-Editar", Enums.Accion.Modificar, Id)
                _nueva_ind.ShowInTaskbar = False
                _nueva_ind.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nuevo_historial As form_plantilla_historial = New form_plantilla_historial("Ficha de plantilla historial-Editar", Enums.Accion.Modificar, Id)
                _nuevo_historial.ShowInTaskbar = False
                _nuevo_historial.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Partes_Asistencia Then
                'Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDPARTE").Value
                'Dim _nuevo_asistencia As form_parte_asistencia = New form_parte_asistencia("Ficha de asistencia-Editar", Enums.Accion.Modificar, Id)
                '_nuevo_asistencia.ShowInTaskbar = False
                '_nuevo_asistencia.ShowDialog()
                'bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Partes_Altas_Bajas Then
                '    Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDPARTE").Value
                '    Dim _data As CMDataSet.ALTASDataTable = ALTASTableAdapter.GetAltaByParte(Id)
                '    Dim _nuevo_asistencia As form_alta_baja_ex
                '    If _data.Rows.Count > 0 Then
                '        _nuevo_asistencia = New form_alta_baja_ex("Ficha de baja/alta-Editar", Enums.Accion.Modificar, Id, True)
                '    End If
                '    _nuevo_asistencia = New form_alta_baja_ex("Ficha de baja/alta-Editar", Enums.Accion.Modificar, Id)
                '    _nuevo_asistencia.ShowInTaskbar = False
                '    _nuevo_asistencia.ShowDialog()
                '    bt_refrescar_Click(sender, e)
                'ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CEMPRESA").Value
                Dim _nueva_empresa As form_empresa = New form_empresa("Ficha de empresa-Editar", Enums.Accion.Modificar, Id)
                _nueva_empresa.ShowInTaskbar = False
                _nueva_empresa.ShowDialog()
                bt_refrescar_Click(sender, e)

            ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CPACIENTE").Value
                'Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de Paciente-Editar", Enums.Accion.Modificar, Id)
                Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, Id)
                _nuevo_paciente.ShowInTaskbar = False

                If _nuevo_paciente.ShowDialog() <> DialogResult.Cancel Then
                    bt_refrescar_Click(sender, e)
                End If

            ElseIf Me.CurrentList = RoleManager.Items.Facturas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDFACTURA").Value
                Globales.Factura_Modifica_y_Salva(Id)
                'Dim _nueva_factura As form_factura = New form_factura("Ficha de factura-Editar", Enums.Accion.Modificar, Id)
                '_nueva_factura.ShowInTaskbar = False
                'If _nueva_factura.ShowDialog() = DialogResult.OK Then
                bt_refrescar_Click(sender, e)
                'End If

            ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value
                Dim _nueva_analitica As form_analiticas = New form_analiticas("Ficha de analiticas-Editar", Enums.Accion.Modificar, Id)
                _nueva_analitica.ShowInTaskbar = False
                _nueva_analitica.ShowDialog()
                bt_refrescar_Click(sender, e)

            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_analitica As form_plantilla__analiticas = New form_plantilla__analiticas("Ficha de plantillas de analiticas-Editar", Enums.Accion.Modificar, Id)
                _nueva_analitica.ShowInTaskbar = False
                _nueva_analitica.ShowDialog()
                bt_refrescar_Click(sender, e)

            ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value.ToString()
                Dim _nuevo_modelo_revisiones As form_modelo_rev_comparativoas = New form_modelo_rev_comparativoas("Modelo de Revisiones Comparativas", Enums.Accion.Modificar, Id)
                _nuevo_modelo_revisiones.ShowInTaskbar = False
                _nuevo_modelo_revisiones.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value.ToString()
                Dim _recibos As form_recibos = New form_recibos("Recibo", Enums.Accion.Modificar, Id)
                _recibos.ShowInTaskbar = False
                _recibos.ShowDialog()
                bt_refrescar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub bt_borrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_borrar.Click
        If gv_listado.Rows.Count > 0 And gv_listado.SelectedRows.Count > 0 Then
            If MessageBox.Show("Esta seguro que desea borrar los datos de la(las) filas(s) seleccionada(s)  ", "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Me.CurrentList = RoleManager.Items.Medicos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CMEDICO").Value
                        Dim _observo As String
                        Dim _nameo As String
                        Dim _apellido1o As String
                        Dim _apellido2o As String
                        Dim _direcciono As String
                        Dim _telefonoo As String
                        Dim _movilo As String
                        Dim _poblaciono As String
                        Dim _cpo As String
                        Dim _DNIo As String
                        Dim _provinciao As String
                        Dim _colegiadoo As String
                        Dim _especialidado As String
                        Dim _data As CMDataSet.MEDICOSDataTable = Me.MEDICOSTableAdapter.GetMedicoByID(Id)
                        _nameo = _data.Rows(0).Item("NOMBRE").ToString()
                        _apellido1o = _data.Rows(0).Item("APELLIDO1").ToString()
                        _apellido2o = _data.Rows(0).Item("APELLIDO2").ToString()
                        _direcciono = _data.Rows(0).Item("DOMICILIO").ToString()
                        _telefonoo = _data.Rows(0).Item("TLFNO").ToString()
                        _movilo = _data.Rows(0).Item("MOVIL").ToString()
                        _cpo = _data.Rows(0).Item("CP").ToString()
                        _poblaciono = _data.Rows(0).Item("LOCALIDAD").ToString()
                        _DNIo = _data.Rows(0).Item("DNI").ToString()
                        _provinciao = _data.Rows(0).Item("PROVINCIA").ToString()
                        _colegiadoo = _data.Rows(0).Item("COLEGIADO").ToString()
                        _especialidado = _data.Rows(0).Item("ESPECIALIDAD").ToString()
                        _observo = _data.Rows(0).Item("OBSERVACIONES").ToString()

                        Me.MEDICOSTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Medicos, "Eliminar Medicos", Id.ToString(), "En listado control")

                    Next
                    Me.MEDICOSTableAdapter.Fill(CMDataSet.MEDICOS)
                    gv_listado.DataSource = Me.MEDICOSBindingSource
                    nav_listado.BindingSource = Me.MEDICOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CMUTUA").Value
                        Dim _tlfno1o As String
                        Dim _notao As String
                        Dim _nameo As String
                        Dim _tlfno2o As String
                        Dim _faxo As String
                        Dim _mailo As String
                        Dim _direcciono As String
                        Dim _contactoo As String
                        Dim _poblaciono As String
                        Dim _cpo As String
                        Dim _CIFo As String
                        Dim _provinciao As String
                        Dim _webo As String
                        Dim _especialidado As String
                        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(Id)
                        _nameo = _data.Rows(0).Item("NOMBRE").ToString()
                        _direcciono = _data.Rows(0).Item("DIRECCION").ToString()
                        _contactoo = _data.Rows(0).Item("PERSONACON").ToString()
                        _tlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
                        _tlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
                        _mailo = _data.Rows(0).Item("MAIL").ToString()
                        _cpo = _data.Rows(0).Item("CP").ToString()
                        _poblaciono = _data.Rows(0).Item("POBLACION").ToString()
                        _CIFo = _data.Rows(0).Item("CIF").ToString()
                        _provinciao = _data.Rows(0).Item("PROVINCIA").ToString()
                        _webo = _data.Rows(0).Item("WEB").ToString()
                        _especialidado = _data.Rows(0).Item("ESPECIALIDAD").ToString()
                        _notao = _data.Rows(0).Item("NOTAS").ToString()
                        _faxo = _data.Rows(0).Item("FAX").ToString()
                        Me.MUTUASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Mutuas, "Eliminar Mutua", Id.ToString(), "En listado control")

                    Next
                    Me.MUTUASTableAdapter.Fill(CMDataSet.MUTUAS)
                    gv_listado.DataSource = Me.MUTUASBindingSource
                    nav_listado.BindingSource = Me.MUTUASBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _cod As String
                        Dim _descrip As String
                        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(Id)
                        _cod = _data.Rows(0).Item("CODIGO").ToString()
                        _descrip = _data.Rows(0).Item("DESCRIPCION").ToString()
                        Me.FORMASPAGOTableAdapter.DeleteById(_cod)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Formas_de_Pago, "Eliminar Forma de Pago", Id.ToString(), "En listado control")

                    Next
                    Me.FORMASPAGOTableAdapter.Fill(CMDataSet.FORMASPAGO)
                    gv_listado.DataSource = Me.FORMASPAGOBindingSource
                    nav_listado.BindingSource = Me.FORMASPAGOBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Proveedores Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CPROVEEDOR").Value
                        Dim _tlfno1o As String
                        Dim _notao As String
                        Dim _nameo As String
                        Dim _tlfno2o As String
                        Dim _faxo As String
                        Dim _mailo As String
                        Dim _direcciono As String
                        Dim _contactoo As String
                        Dim _poblaciono As String
                        Dim _cpo As String
                        Dim _CIFo As String
                        Dim _provinciao As String
                        Dim _webo As String
                        Dim _data As CMDataSet.PROVEEDORESDataTable = Me.PROVEEDORESTableAdapter.GetProveedorById(Id)
                        _nameo = _data.Rows(0).Item("NOMBRE").ToString()
                        _direcciono = _data.Rows(0).Item("DIRECCION").ToString()
                        _contactoo = _data.Rows(0).Item("PERSONACON").ToString()
                        _tlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
                        _tlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
                        _mailo = _data.Rows(0).Item("MAIL").ToString()
                        _cpo = _data.Rows(0).Item("CP").ToString()
                        _poblaciono = _data.Rows(0).Item("POBLACION").ToString()
                        _CIFo = _data.Rows(0).Item("CIF").ToString()
                        _provinciao = _data.Rows(0).Item("PROVINCIA").ToString()
                        _webo = _data.Rows(0).Item("WEB").ToString()
                        _notao = _data.Rows(0).Item("NOTAS").ToString()
                        _faxo = _data.Rows(0).Item("FAX").ToString()
                        Me.PROVEEDORESTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Proveedores, "Eliminar Proveedores", Id.ToString(), "En listado control")

                    Next
                    Me.PROVEEDORESTableAdapter.Fill(CMDataSet.PROVEEDORES)
                    gv_listado.DataSource = Me.PROVEEDORESBindingSource
                    nav_listado.BindingSource = Me.PROVEEDORESBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim _tlfno1o As String
                        Dim _Id As String
                        Dim _notao As String
                        Dim _nameo As String
                        Dim _tlfno2o As String
                        Dim _faxo As String
                        Dim _mailo As String
                        Dim _direcciono As String
                        Dim _entidado As String = gv_listado.SelectedRows.Item(i).Cells("ENTIDAD").Value
                        Dim _localidado As String
                        Dim _cpo As String
                        Dim _oficinao As String = gv_listado.SelectedRows.Item(i).Cells("OFICINA").Value
                        Dim _provinciao As String
                        Dim _webo As String
                        Dim _data As CMDataSet.BANCOSDataTable = Me.BANCOSTableAdapter.GetBancoByKey(_entidado, _oficinao)
                        _nameo = _data.Rows(0).Item("NOMBRE").ToString()
                        _direcciono = _data.Rows(0).Item("DIRECCION").ToString()
                        _entidado = _data.Rows(0).Item("ENTIDAD").ToString()
                        _tlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
                        _tlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
                        _mailo = _data.Rows(0).Item("EMAIL").ToString()
                        _cpo = _data.Rows(0).Item("CP").ToString()
                        _localidado = _data.Rows(0).Item("LOCALIDAD").ToString()
                        _oficinao = _data.Rows(0).Item("OFICINA").ToString()
                        _provinciao = _data.Rows(0).Item("PROVINCIA").ToString()
                        _webo = _data.Rows(0).Item("WEB").ToString()
                        _notao = _data.Rows(0).Item("NOTAS").ToString()
                        _faxo = _data.Rows(0).Item("FAX").ToString()
                        _Id = _data.Rows(0).Item("ID").ToString()
                        Me.BANCOSTableAdapter.Delete1(_entidado, _oficinao)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Bancos, "Eliminar " & _entidado & _oficinao, _Id.ToString(), "En listado control")

                    Next
                    Me.BANCOSTableAdapter.Fill(CMDataSet.BANCOS)
                    gv_listado.DataSource = Me.BANCOSBindingSource
                    nav_listado.BindingSource = Me.BANCOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _cod As String
                        Dim _descrip As String
                        Dim _importe As String
                        Dim _data As CMDataSet.CONCEPTOSFRADataTable = Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(Id)
                        _cod = _data.Rows(0).Item("CODIGO").ToString()
                        _descrip = _data.Rows(0).Item("DESCRIPCION").ToString()
                        _importe = _data.Rows(0).Item("IMPORTE").ToString()
                        Dim _imp As Single = Single.Parse(_importe)
                        Me.CONCEPTOSFRATableAdapter.DeleteByCodigo(_cod)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Conceptos_Facturables, "Eliminar ", _cod.ToString(), "En listado control")

                    Next
                    Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)
                    gv_listado.DataSource = Me.CONCEPTOSFRABindingSource
                    nav_listado.BindingSource = Me.CONCEPTOSFRABindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Paises Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        If Id <> 1 Then
                            Dim _cod As Integer
                            Dim _nombre As String
                            Dim _notas As String
                            Dim _data As CMDataSet.PAISESDataTable = Me.PAISESTableAdapter.GetPaisById(Id)
                            _cod = _data.Rows(0).Item("CODIGO").ToString()
                            _nombre = _data.Rows(0).Item("NOMBRE").ToString()
                            _notas = _data.Rows(0).Item("NOTAS").ToString()
                            Me.PAISESTableAdapter.DeleteById(_cod)
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Paises, "Eliminar ", _cod.ToString(), "En listado control")

                        End If
                    Next
                    Me.PAISESTableAdapter.Fill(CMDataSet.PAISES)
                    gv_listado.DataSource = Me.PAISESBindingSource
                    nav_listado.BindingSource = Me.PAISESBindingSource

                ElseIf Me.CurrentList = RoleManager.Items.Conceptos_de_Analiticas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _cod As Integer
                        Dim _concepto As String
                        Dim _importe As Single
                        Dim _notas As String
                        Dim _data As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetConceptosAnaliticaById(Id)
                        _cod = _data.Rows(0).Item("CODIGO")
                        _concepto = _data.Rows(0).Item("CONCEPTO").ToString()
                        _importe = _data.Rows(0).Item("IMPORTE")
                        _notas = _data.Rows(0).Item("NOTAS").ToString()
                        Me.CONCEPTOSANALITICATableAdapter.DeleteById(_cod)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Conceptos_de_Analiticas, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)
                    gv_listado.DataSource = Me.CONCEPTOSANALITICABindingSource
                    nav_listado.BindingSource = Me.CONCEPTOSANALITICABindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _tlfno1o As String
                        Dim _descripco As String
                        Dim _tlfno2o As String
                        Dim _faxo As String
                        Dim _mailo As String
                        Dim _direcciono As String
                        Dim _contactoo As String
                        Dim _poblaciono As String
                        Dim _cpo As String
                        Dim _provinciao As String
                        Dim _webo As String
                        Dim _data As CMDataSet.DERIVACIONES_DESTINOSDataTable = Me.DERIVACIONES_DESTINOSTableAdapter.GetClinicaById(Id)
                        _direcciono = _data.Rows(0).Item("DIRECCION").ToString()
                        _contactoo = _data.Rows(0).Item("PERSONACON").ToString()
                        _tlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
                        _tlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
                        _mailo = _data.Rows(0).Item("MAIL").ToString()
                        _cpo = _data.Rows(0).Item("CP").ToString()
                        _poblaciono = _data.Rows(0).Item("POBLACION").ToString()
                        _descripco = _data.Rows(0).Item("DESCRIPCION").ToString()
                        _provinciao = _data.Rows(0).Item("PROVINCIA").ToString()
                        _webo = _data.Rows(0).Item("WEB").ToString()
                        _faxo = _data.Rows(0).Item("FAX").ToString()
                        Me.DERIVACIONES_DESTINOSTableAdapter.Delete1(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Derivaciones, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.DERIVACIONES_DESTINOSTableAdapter.Fill(CMDataSet.DERIVACIONES_DESTINOS)
                    gv_listado.DataSource = Me.DERIVACIONES_DESTINOSBindingSource
                    nav_listado.BindingSource = Me.DERIVACIONES_DESTINOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CALARMA").Value
                        Dim _alarma As String
                        Dim _nivel As String
                        Dim _descripcion As String
                        Dim _data As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(Id)
                        _alarma = _data.Rows(0).Item("ALARMA")
                        _nivel = _data.Rows(0).Item("NIVEL").ToString()
                        _descripcion = _data.Rows(0).Item("DESCRIPCION")

                        Me.ALARMASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Alarmas, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.ALARMASTableAdapter.Fill(CMDataSet.ALARMAS)
                    gv_listado.DataSource = Me.ALARMASBindingSource
                    nav_listado.BindingSource = Me.ALARMASBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Articulos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CARTICULO").Value
                        Me.ARTICULOSTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Articulos, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.ARTICULOSTableAdapter.Fill(CMDataSet.ARTICULOS)
                    gv_listado.DataSource = Me.ARTICULOSBindingSource
                    nav_listado.BindingSource = Me.ARTICULOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CMEDICAMENTO").Value
                        Dim _descripcion
                        Dim _pos As String
                        Dim _cant As String
                        Dim _ind As String
                        Dim _fav As String
                        Dim _data As CMDataSet.MEDICAMENTOSDataTable = Me.MEDICAMENTOSTableAdapter.GetMedicamentoById(Id)
                        _descripcion = _data.Rows(0).Item("DESCRIPCION").ToString()
                        _pos = _data.Rows(0).Item("POSOLOGIA")
                        _cant = _data.Rows(0).Item("CANTIDADES")
                        _ind = _data.Rows(0).Item("INDICACION")
                        _fav = _data.Rows(0).Item("FAVORITOS").ToString()


                        Me.MEDICAMENTOSTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Medicamentos, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.MEDICAMENTOSTableAdapter.Fill(CMDataSet.MEDICAMENTOS)
                    gv_listado.DataSource = Me.MEDICAMENTOSBindingSource
                    nav_listado.BindingSource = Me.MEDICAMENTOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _descripcion As String
                        Dim _seccion As String
                        Dim _text As String
                        Dim _data As CMDataSet.PLANTILLASDataTable = Me.PLANTILLASTableAdapter.GetPlantillaById(Id)
                        _descripcion = _data.Rows(0).Item("DESCRIPCION").ToString()
                        _seccion = _data.Rows(0).Item("SECCION").ToString()
                        _text = _data.Rows(0).Item("TEXTO").ToString()


                        Me.PLANTILLASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Plantillas_de_texto, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.PLANTILLASTableAdapter.Fill(CMDataSet.PLANTILLAS)
                    gv_listado.DataSource = Me.PLANTILLASBindingSource
                    nav_listado.BindingSource = Me.PLANTILLASBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("IDDIAGNOSTICO").Value
                        Dim _diagnostico As String
                        Dim _obs As String
                        Dim _niv As String
                        Dim _sniv As String
                        Dim _fav As String
                        Dim _cie10 As String
                        Dim _data As CMDataSet.DIAGNOSTICOSDataTable = Me.DIAGNOSTICOSTableAdapter.GetDiagnosticoById(Id)
                        _diagnostico = _data.Rows(0).Item("DIAGNOSTICO").ToString()
                        If _data.Rows(0).Item("OBSERVACIONES") Is Nothing Then
                            _obs = _data.Rows(0).Item("OBSERVACIONES")
                        Else : MessageBox.Show("Tipos de datos incompatibles", "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        _niv = _data.Rows(0).Item("NIVEL")
                        _sniv = _data.Rows(0).Item("SUBNIVEL")
                        _fav = _data.Rows(0).Item("FAVORITO").ToString()
                        _cie10 = _data.Rows(0).Item("CIE10").ToString()


                        Me.DIAGNOSTICOSTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Diagnosticos, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.DIAGNOSTICOSTableAdapter.Fill(CMDataSet.DIAGNOSTICOS)
                    gv_listado.DataSource = Me.DIAGNOSTICOSBindingSource
                    nav_listado.BindingSource = Me.DIAGNOSTICOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Gastos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("IDGASTO").Value
                        Dim _concepto As String
                        Dim _fcod As String
                        Dim _importe As Single
                        Dim _fecha As Date
                        Dim _data As CMDataSet.GASTOSDataTable = Me.GASTOSTableAdapter.GetGastoById(Id)
                        _concepto = _data.Rows(0).Item("CONCEPTO").ToString()
                        _fcod = _data.Rows(0).Item("REFFORMAPAGO")
                        _importe = _data.Rows(0).Item("IMPORTE")
                        _fecha = _data.Rows(0).Item("FECHA")

                        Me.GASTOSTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Gastos, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.GASTOSTableAdapter.Fill(CMDataSet.GASTOS)
                    gv_listado.DataSource = Me.GASTOSBindingSource
                    nav_listado.BindingSource = Me.GASTOSBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CINDICACIONES").Value
                        Dim _texto As String
                        Dim _name As String
                        Dim _data As CMDataSet.INDICACIONESDataTable = Me.INDICACIONESTableAdapter.GetIndicacionById(Id)
                        _texto = _data.Rows(0).Item("TEXTO").ToString()
                        _name = _data.Rows(0).Item("NOMBRE")

                        Me.INDICACIONESTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Indicaciones, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.INDICACIONESTableAdapter.Fill(CMDataSet.INDICACIONES)
                    gv_listado.DataSource = Me.INDICACIONESBindingSource
                    nav_listado.BindingSource = Me.INDICACIONESBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _motivo As String
                        Dim _antecedentes As String
                        Dim _exploracion As String
                        Dim _complementarias As String
                        Dim _juicio As String
                        Dim _tratamiento As String
                        Dim _historial As String
                        Dim _comentarios As String
                        Dim _otros As String
                        Dim _descripcion As String
                        Dim _data As CMDataSet.PLANTILLA_HISTORIALESDataTable = Me.PLANTILLA_HISTORIALESTableAdapter.GetPlantillaById(Id)
                        _motivo = _data.Rows(0).Item("MOTIVO").ToString()
                        _antecedentes = _data.Rows(0).Item("ANTECEDENTES").ToString()
                        _exploracion = _data.Rows(0).Item("EXPLORACION").ToString()
                        _complementarias = _data.Rows(0).Item("COMPLEMENTARIAS").ToString()
                        _juicio = _data.Rows(0).Item("JUICIO").ToString()
                        _tratamiento = _data.Rows(0).Item("TRATAMIENTO").ToString()
                        _historial = _data.Rows(0).Item("HISTORIAL").ToString()
                        _comentarios = _data.Rows(0).Item("COMENTARIOS").ToString()
                        _otros = _data.Rows(0).Item("OTROS").ToString()
                        _descripcion = _data.Rows(0).Item("DESCRIPCION").ToString()
                        Me.PLANTILLA_HISTORIALESTableAdapter.Delete(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Plantilla_de_Historial, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.PLANTILLA_HISTORIALESTableAdapter.Fill(CMDataSet.PLANTILLA_HISTORIALES)
                    gv_listado.DataSource = Me.PLANTILLA_HISTORIALESBindingSource
                    nav_listado.BindingSource = Me.PLANTILLA_HISTORIALESBindingSource
                ElseIf Me.CurrentList = RoleManager.Items.Partes_Asistencia Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("IDPARTE").Value
                        Me.PARTESTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Partes, "Eliminar ", Id.ToString(), "En listado control")
                        Me.ASISTENCIASTableAdapter.DeletebyParte(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Partes_Asistencia, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    bt_refrescar_Click(sender, e)
                ElseIf Me.CurrentList = RoleManager.Items.Partes_Altas_Bajas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("IDPARTE").Value
                        Me.PARTESTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Partes_Asistencia, "Eliminar ", Id.ToString(), "En listado control")


                        If Me.ALTASTableAdapter.GetAltaByParte(Id).Rows.Count > 0 Then
                            Me.ALTASTableAdapter.DeleteByParte(Id)
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Partes_Altas_Bajas, "Eliminar parte Alta", Id.ToString(), "En listado control")

                        End If
                        If Me.BAJASTableAdapter.GetBajaByParte(Id).Rows.Count > 0 Then
                            Me.BAJASTableAdapter.DeleteByParte(Id)
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Partes_Altas_Bajas, "Eliminar parte Baja", Id.ToString(), "En listado control")

                        End If

                    Next
                    bt_refrescar_Click(sender, e)
                ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CEMPRESA").Value
                        Me.EMPRESASTableAdapter.DeleteEmpresaById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Empresas, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.EMPRESASTableAdapter.Fill(CMDataSet.EMPRESAS)
                    gv_listado.DataSource = Me.EMPRESASBindingSource
                    nav_listado.BindingSource = Me.EMPRESASBindingSource
                    bt_refrescar_Click(sender, e)
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////
                ElseIf Me.CurrentList = RoleManager.Items.Facturas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("IDFACTURA").Value
                        Me.FACTURASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Facturas, "Eliminar ", Id.ToString(), "En listado control")

                        'actualizo el campo reffra de la tabla citas si tiene alguna relación con la fra borrada.
                        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, "update citas set reffra = 0 where reffra = " & Id)
                    Next
                    Me.FACTURASTableAdapter.Fill(CMDataSet.FACTURAS)
                    gv_listado.DataSource = Me.FACTURASBindingSource
                    nav_listado.BindingSource = Me.FACTURASBindingSource
                    bt_refrescar_Click(sender, e)

                ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("NUMERO").Value
                        Me.ANALITICASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Analiticas, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    bt_refrescar_Click(sender, e)
                ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Dim _descripcion As String
                        Dim _data As CMDataSet.PLANTILLAANALITICASDataTable = Me.PLANTILLAANALITICASTableAdapter.GetPlantillaAnaliticaById(Id)
                        _descripcion = _data.Rows(0).Item("DESCRIPCION").ToString()

                        Me.PLANTILLAANALITICASTableAdapter.DeleteById(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Plantillas_para_Analiticas, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.PLANTILLAANALITICASTableAdapter.Fill(CMDataSet.PLANTILLAANALITICAS)
                    gv_listado.DataSource = Me.PLANTILLAANALITICASBindingSource
                    nav_listado.BindingSource = Me.PLANTILLAANALITICASBindingSource

                ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As Integer = gv_listado.SelectedRows.Item(i).Cells("CPACIENTE").Value
                        'Renier: Solucionar bug, de las alarmas

                        If Globales.PuedeBorrarsePaciente(Id) Then
                            Me.PACIENTESTableAdapter.DeleteById(Id)
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes, "Eliminar Paciente", Id.ToString(), "En Listado Pacientes")
                        Else
                            MessageBox.Show("El paciente " & Id & " no puede eliminarse debido a que tiene historiales abiertos. Solo un Administrador puede efectuar esta operación.")
                        End If
                    Next
                    Me.PACIENTESTableAdapter.Fill(CMDataSet.PACIENTES)
                    gv_listado.DataSource = Me.PACIENTESBindingSource
                    nav_listado.BindingSource = Me.PACIENTESBindingSource
                    bt_refrescar_Click(sender, e)
                    If My.MySettings.Default.Demo Then
                        If CMDataSet.PACIENTES.Count < 5 Then
                            bt_nuevo.Enabled = True
                        End If
                    End If

                ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("CODIGO").Value
                        Try
                            Me.MODELOSCOMPARATIVATableAdapter.DeleteByCodigo(Id)
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Modelos_Revisiones_Comparativas, "Eliminar ", Id.ToString(), "En listado control")
                        Catch ex As Exception
                            MessageBox.Show("El modelo no puede ser borrado mya que esta siendo utilizado")
                        End Try
                        

                    Next
                    Me.MODELOSCOMPARATIVATableAdapter.Fill(CMDataSet.MODELOSCOMPARATIVA)
                    gv_listado.DataSource = Me.MODELOSCOMPARATIVABindingSource
                    nav_listado.BindingSource = Me.MODELOSCOMPARATIVABindingSource
                    bt_refrescar_Click(sender, e)
                ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
                    Dim i As Integer
                    For i = 0 To gv_listado.SelectedRows.Count - 1
                        Dim Id As String = gv_listado.SelectedRows.Item(i).Cells("NUMERO").Value
                        Me.RECIBOSTableAdapter.DeleteByNumero(Id)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Recibos, "Eliminar ", Id.ToString(), "En listado control")

                    Next
                    Me.RECIBOSTableAdapter.Fill(CMDataSet.RECIBOS)
                    gv_listado.DataSource = Me.RECIBOSBindingSource
                    nav_listado.BindingSource = Me.RECIBOSBindingSource
                    bt_refrescar_Click(sender, e)

                End If
            End If
        End If
    End Sub

    Private Sub bt_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ver.Click
        If gv_listado.Rows.Count > 0 Then
            If Me.CurrentList = RoleManager.Items.Medicos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMEDICO").Value
                'Dim _nuevo_medico As form_medico = New form_medico("Ficha del Médico-Ver", Enums.Accion.Ver, Id)
                '_nuevo_medico.ShowInTaskbar = False
                '_nuevo_medico.ShowDialog()
            ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMUTUA").Value
                Dim _nuevo_mutua As form_mutuas = New form_mutuas("Ficha de Mutua-Ver", Enums.Accion.Ver, Id)
                _nuevo_mutua.ShowInTaskbar = False
                _nuevo_mutua.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_forma_pago As form_formas_pago = New form_formas_pago("Ficha forma de pago-Ver", Enums.Accion.Ver, Id)
                _nueva_forma_pago.ShowInTaskbar = False
                _nueva_forma_pago.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Proveedores Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CPROVEEDOR").Value
                Dim _nuevo_proveedor As form_proveedores = New form_proveedores("Ficha de proveedor-Ver", Enums.Accion.Ver, Id)
                _nuevo_proveedor.ShowInTaskbar = False
                _nuevo_proveedor.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
                Dim entidad As String = gv_listado.SelectedRows.Item(0).Cells("ENTIDAD").Value
                Dim oficina As String = gv_listado.SelectedRows.Item(0).Cells("OFICINA").Value
                Dim _nuevo_banco As form_bancos = New form_bancos("Ficha de banco-Ver", Enums.Accion.Ver, entidad, oficina)
                _nuevo_banco.ShowInTaskbar = False
                _nuevo_banco.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_cf As form_conceptos_facturables = New form_conceptos_facturables("Ficha -Ver", Enums.Accion.Ver, Id)
                _nueva_cf.ShowInTaskbar = False
                _nueva_cf.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Paises Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nuevo_pais As form_paises = New form_paises("País-Ver", Enums.Accion.Ver, Id)
                _nuevo_pais.ShowInTaskbar = False
                _nuevo_pais.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_de_Analiticas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nuevo_concepto As form_concepto_analitica = New form_concepto_analitica("Ficha-Ver", Enums.Accion.Ver, Id)
                _nuevo_concepto.ShowInTaskbar = False
                _nuevo_concepto.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_clinica As form_clinicas = New form_clinicas("Ficha-Ver", Enums.Accion.Ver, Id)
                _nueva_clinica.ShowInTaskbar = False
                _nueva_clinica.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CALARMA").Value
                Dim _nueva_alarma As form_alarmas = New form_alarmas("Ficha de alarma-Ver", Enums.Accion.Ver, Id)
                _nueva_alarma.ShowInTaskbar = False
                _nueva_alarma.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Articulos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CARTICULO").Value
                Dim _nuevo_articulo As form_articulos = New form_articulos("Ficha de artículo-Ver", Enums.Accion.Ver, Id)
                _nuevo_articulo.ShowInTaskbar = False
                _nuevo_articulo.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CMEDICAMENTO").Value
                Dim _nuevo_medicamento As form_medicamento = New form_medicamento("Ficha de medicamento-Ver", Enums.Accion.Ver, Id)
                _nuevo_medicamento.ShowInTaskbar = False
                _nuevo_medicamento.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Modificar, Id)
                _nueva_plantilla.ShowInTaskbar = False
                _nueva_plantilla.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDDIAGNOSTICO").Value
                Dim _nuevo_diagnostico As form_diagnostico = New form_diagnostico("Ficha de diagnostico-Ver", Enums.Accion.Ver, Id)
                _nuevo_diagnostico.ShowInTaskbar = False
                _nuevo_diagnostico.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Gastos Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDGASTO").Value
                Dim _nuevo_gasto As form_gastos = New form_gastos("Ficha de gastos-Ver", Enums.Accion.Ver, Id)
                _nuevo_gasto.ShowInTaskbar = False
                _nuevo_gasto.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CINDICACIONES").Value
                Dim _nueva_ind As form_indicaciones = New form_indicaciones("Ficha de indicaciones-Ver", Enums.Accion.Ver, Id)
                _nueva_ind.ShowInTaskbar = False
                _nueva_ind.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nuevo_historial As form_plantilla_historial = New form_plantilla_historial("Ficha de plantilla historial-Ver", Enums.Accion.Ver, Id)
                _nuevo_historial.ShowInTaskbar = False
                _nuevo_historial.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Partes_Asistencia Then
                'Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDPARTE").Value
                'Dim _nuevo_asistencia As form_parte_asistencia = New form_parte_asistencia("Ficha de asistencia-Ver", Enums.Accion.Ver, Id)
                '_nuevo_asistencia.ShowInTaskbar = False
                '_nuevo_asistencia.ShowDialog()
                'bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Partes_Altas_Bajas Then
                '    Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDPARTE").Value
                '    Dim _data As CMDataSet.ALTASDataTable = ALTASTableAdapter.GetAltaByParte(Id)
                '    Dim _nuevo_asistencia As form_alta_baja_ex
                '    If _data.Rows.Count > 0 Then
                '        _nuevo_asistencia = New form_alta_baja_ex("Ficha de baja/alta-Ver", Enums.Accion.Ver, Id, True)
                '    End If
                '    _nuevo_asistencia = New form_alta_baja_ex("Ficha de baja/alta-Ver", Enums.Accion.Ver, Id)
                '    _nuevo_asistencia.ShowInTaskbar = False
                '    _nuevo_asistencia.ShowDialog()
                '    bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("CEMPRESA").Value
                Dim _nueva_empresa As form_empresa = New form_empresa("Ficha de empresa-Ver", Enums.Accion.Ver, Id)
                _nueva_empresa.ShowInTaskbar = False
                _nueva_empresa.ShowDialog()
                bt_refrescar_Click(sender, e)

                '///////////////////////////////////////////////////////////////////////////////////////////////
            ElseIf Me.CurrentList = RoleManager.Items.Facturas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("IDFACTURA").Value
                'Dim _nueva_factura As form_factura = New form_factura("Ficha de factura-Ver", Enums.Accion.Ver, Id)
                '_nueva_factura.ShowInTaskbar = False
                '_nueva_factura.ShowDialog()
                Globales.Factura_Modifica_y_Salva(Id)
                bt_refrescar_Click(sender, e)

            ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
                Dim Id As Integer = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value
                Dim _nueva_analitica As form_analiticas = New form_analiticas("Ficha de analiticas-Ver", Enums.Accion.Ver, Id)
                _nueva_analitica.ShowInTaskbar = False
                _nueva_analitica.ShowDialog()
                bt_refrescar_Click(sender, e)

            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                Dim _nueva_analitica As form_plantilla__analiticas = New form_plantilla__analiticas("Ficha de plantillas de analiticas-Ver", Enums.Accion.Ver, Id)
                _nueva_analitica.ShowInTaskbar = False
                _nueva_analitica.ShowDialog()
                bt_refrescar_Click(sender, e)


            ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value.ToString()
                Dim _nuevo_modelo_revisiones As form_modelo_rev_comparativoas = New form_modelo_rev_comparativoas("Modelo de Revisiones Comparativas", Enums.Accion.Ver, Id)
                _nuevo_modelo_revisiones.ShowInTaskbar = False
                _nuevo_modelo_revisiones.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value.ToString()
                Dim _recibos As form_recibos = New form_recibos("Recibo", Enums.Accion.Ver, Id)
                _recibos.ShowInTaskbar = False
                _recibos.ShowDialog()
                bt_refrescar_Click(sender, e)
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then
                Dim Id As String = gv_listado.SelectedRows.Item(0).Cells("CPACIENTE").Value
                'Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de Paciente-Editar", Enums.Accion.Ver, Id)
                Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Ver, Id)
                _nuevo_paciente.ShowInTaskbar = False
                _nuevo_paciente.ShowDialog()
                bt_refrescar_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.ParentForm.DialogResult = DialogResult.Cancel
        Me.ParentForm.Close()
    End Sub

    Private Sub bt_seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_seleccionar.Click
        If gv_listado.Rows.Count > 0 And gv_listado.SelectedRows.Count > 0 Then
            Dim _Id As Integer
            Dim _sId As String
            If Me.CurrentList = RoleManager.Items.Proveedores Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CPROVEEDOR").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes Then
                If codpropio = True Then
                    _Id = gv_listado.SelectedRows.Item(0).Cells("CODIGOPROPIO").Value
                Else
                    _Id = gv_listado.SelectedRows.Item(0).Cells("CPACIENTE").Value
                End If
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CMUTUA").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CEMPRESA").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Medicos Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CMEDICO").Value
                fSeleccion = _Id.ToString()
                '//////////////////////////////////////////////
            ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CALARMA").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Indicaciones Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CINDICACIONES").Value
                fSeleccion = _Id.ToString()
                '////////////////////////////////////////////
            ElseIf Me.CurrentList = RoleManager.Items.Diagnosticos Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("IDDIAGNOSTICO").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Medicamentos Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("CMEDICAMENTO").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Formas_de_Pago Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                fSeleccion = _sId.ToString()

                'NUEVO ANNADIDO

            ElseIf Me.CurrentList = RoleManager.Items.Alarmas Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CALARMA").Value
                fSeleccion = _sId.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Paises Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                fSeleccion = _sId.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Empresas Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CEMPRESA").Value
                fSeleccion = _sId.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Mutuas Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CMutua").Value
                fSeleccion = _sId.ToString()
                'ESTA ES PARA BANCO Y EN SELECCION VOY A DEVOLVER, COMO TIENE DOS LLAVES PRIMARIAS, 
                'LA PRIMERA /==>/ LA SEGUNDA
            ElseIf Me.CurrentList = RoleManager.Items.Bancos Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("ENTIDAD").Value
                fSeleccion = _sId.ToString() + "/==>/"
                _sId = gv_listado.SelectedRows.Item(0).Cells("OFICINA").Value
                fSeleccion = fSeleccion + _sId.ToString()
                '//////////////////////////////////////////////////////////////
            ElseIf Me.CurrentList = RoleManager.Items.Conceptos_Facturables Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                fSeleccion = _sId.ToString()

            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_para_Analiticas Then
                _sId = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                fSeleccion = _sId.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Analiticas Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Facturas Then
                _Id = gv_listado.SelectedRows.Item(0).Cells("IDFACTURA").Value
                fSeleccion = _Id.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Modelos_Revisiones_Comparativas Then
                fSeleccion = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value.ToString()

            ElseIf Me.CurrentList = RoleManager.Items.Plantilla_de_Historial Then
                fSeleccion = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Recibos Then
                fSeleccion = gv_listado.SelectedRows.Item(0).Cells("NUMERO").Value.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Pacientes_Derivaciones Then
                fSeleccion = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value.ToString()
            ElseIf Me.CurrentList = RoleManager.Items.Plantillas_de_texto Then
                IDSELECCIONADO = gv_listado.SelectedRows.Item(0).Cells("CODIGO").Value
                fSeleccion = gv_listado.SelectedRows.Item(0).Cells(3).Value.ToString()
            End If

            Me.ParentForm.DialogResult = DialogResult.OK
            Me.ParentForm.Close()
        End If

    End Sub

    Private Sub bt_configcolums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_configcolums.Click
        Dim _columns As form_columnas = New form_columnas(Globales.Configuracion)
        _columns.CurrentList = Me.CurrentList
        _columns.ShowInTaskbar = False
        _columns.ShowDialog()
        bt_refrescar_Click(sender, e)
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click, bt_ordenar.Click

        Dim _index As Integer = cb_campos_filtro.SelectedIndex
        If _index <> -1 Then

            If tb_desde.Text <> "" Then
                Dim _table As String = QueryTable()
                Dim _where As String = QueryWhere()
                Dim _order As String = QueryOrder()
                Filtrar(_table, _where, _order)
            Else
                If chb_intervalo.Checked Then
                    Dim _table As String = QueryTable()
                    Dim _where As String = QueryWhere()
                    Dim _order As String = QueryOrder()
                    Filtrar(_table, _where, _order)
                Else
                    MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Else
            MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        Dim _mostrar_reporte As Form = Nothing
        Dim _entrar As Boolean = True
        'Try
        Select Case Me.CurrentList
            Case RoleManager.Items.Alarmas
                _mostrar_reporte = New form_mostrar_reporte_alarmas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Analiticas
                _mostrar_reporte = New form_mostrar_reporte_analiticas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Articulos
                '_mostrar_reporte = New form_mostrar_reporte_articulos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Partes_Asistencia
                '_mostrar_reporte = New form_mostrar_reporte_partes(fTable, fWhere, fOrder)
            Case RoleManager.Items.Bancos
                '_mostrar_reporte = New form_mostrar_reporte_bancos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Partes_Altas_Bajas
                '_mostrar_reporte = New form_mostrar_reporte_partes(fTable, fWhere, fOrder)
            Case RoleManager.Items.Medicos
                '_mostrar_reporte = New form_mostrar_reporte_medicos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Pacientes
                '_mostrar_reporte = New form_mostrar_reporte_pacientes(fTable, fWhere, fOrder)
            Case RoleManager.Items.Mutuas
                '_mostrar_reporte = New form_mostrar_reporte_mutuas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Empresas
                _mostrar_reporte = New form_mostrar_reporte_empresas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Facturas
                '_mostrar_reporte = New form_mostrar_reporte_facturas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Proveedores
                '_mostrar_reporte = New form_mostrar_reporte_proveedores(fTable, fWhere, fOrder)
            Case RoleManager.Items.Gastos
                '_mostrar_reporte = New form_mostrar_reporte_gastos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Recibos
                '_mostrar_reporte = New form_mostrar_reporte_recibos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Diagnosticos
                '_mostrar_reporte = New form_mostrar_reporte_diagnosticos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Medicamentos
                _mostrar_reporte = New form_mostrar_reporte_medicamentos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Indicaciones
                _mostrar_reporte = New form_mostrar_reporte_indicaciones(fTable, fWhere, fOrder)
            Case RoleManager.Items.Conceptos_Facturables
                '_mostrar_reporte = New form_mostrar_reporte_conceptos_facturables(fTable, fWhere, fOrder)
            Case RoleManager.Items.Conceptos_de_Analiticas
                '_mostrar_reporte = New form_mostrar_reporte_conceptos_analiticas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Plantillas_para_Analiticas
                '_mostrar_reporte = New form_mostrar_reporte_planilla_analiticas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                '_mostrar_reporte = New form_mostrar_reporte_modelo_reviciones_comparadas(fTable, fWhere, fOrder)
            Case RoleManager.Items.Plantillas_de_texto
                '_mostrar_reporte = New form_mostrar_reporte_plantillas_texto(fTable, fWhere, fOrder)
            Case RoleManager.Items.Plantilla_de_Historial
                '_mostrar_reporte = New form_mostrar_reporte_plantillas_historial(fTable, fWhere, fOrder)
                Return
            Case RoleManager.Items.Paises
                _mostrar_reporte = New form_mostrar_reporte_paises(fTable, fWhere, fOrder)
            Case RoleManager.Items.Formas_de_Pago
                _mostrar_reporte = New form_mostrar_reporte_forma_pagos(fTable, fWhere, fOrder)
            Case RoleManager.Items.Citas
                _entrar = False
                MessageBox.Show("Función no disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        If _entrar Then
            _mostrar_reporte.ShowDialog()
            _mostrar_reporte.ShowIcon = False
        End If
        'Catch ex As Exception
        'MsgBox("error: " & ex.ToString)
        ' 'End 'Try
    End Sub

    Private Sub bt_filtro_avanzado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtro_avanzado.Click
        Dim _table As String = QueryTable()
        Dim _order As String = QueryOrder()
        Dim filtro As New form_filtro_avanzado(fName, fDBName, fType, _table)
        filtro.ShowInTaskbar = False
        If filtro.ShowDialog() = DialogResult.OK Then
            fWhere = filtro.Where
            Filtrar(_table, fWhere, _order)

        End If
    End Sub

    Private Sub bt_primer_registro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_primer_registro.Click
        Dim i As Integer
        If gv_listado.Rows.Count > 0 Then
            While gv_listado.Rows(0).Cells(i).Visible = False
                i = i + 1
            End While
            gv_listado.CurrentCell = gv_listado.Rows(0).Cells(i)
        End If
    End Sub

    Private Sub bt_ultima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ultima.Click
        Dim i As Integer
        If gv_listado.Rows.Count > 0 Then
            While gv_listado.Rows(0).Cells(i).Visible = False
                i = i + 1
            End While
            gv_listado.CurrentCell = gv_listado.Rows(gv_listado.Rows.Count - 1).Cells(i)
        End If
    End Sub

    Private Sub tb_desde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_desde.TextChanged
        ChequearTextboxSoloNumero(tb_desde)
    End Sub

    Private Sub tb_hasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_hasta.TextChanged
        ChequearTextboxSoloNumero(tb_hasta)
    End Sub

    Private Sub chb_intervalo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_intervalo.CheckedChanged
        If chb_intervalo.Checked Then
            dtp_fecha_min.Enabled = True
            dtp_fecha_max.Enabled = True
            cb_tipo_fecha.Enabled = True
        Else
            dtp_fecha_min.Enabled = False
            dtp_fecha_max.Enabled = False
            cb_tipo_fecha.Enabled = False
        End If
    End Sub

    Private Sub cb_campos_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_campos_filtro.SelectedIndexChanged
        Dim _index As Integer = cb_campos_filtro.SelectedIndex
        If _index <> -1 Then
            Dim _name As String = cb_campos_filtro.Items(_index)

            If fName.Contains(_name) Then
                Dim _pos As Integer = fName.IndexOf(_name)
                If fType.Item(_pos).Name = Type.GetType("System.Int32").Name Then
                    fIsNumberOnlyDesde = True
                Else
                    fIsNumberOnlyDesde = False
                End If
            End If
        End If
    End Sub

    Private Sub gv_listado_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gv_listado.RowHeaderMouseDoubleClick
        If Selection = False Then
            bt_modificar_Click(sender, e)
        Else
            bt_seleccionar_Click(sender, e)
        End If

    End Sub

    Private Sub gv_listado_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gv_listado.CellDoubleClick
        If Selection = False And bt_modificar.Enabled = True Then
            bt_modificar_Click(sender, e)
        Else
            bt_seleccionar_Click(sender, e)
        End If
    End Sub


    Private Sub LlenarListaCampos(ByVal aTable As String)
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        Dim _reader As XmlReader = New XmlTextReader(dir + "\\Config\\componente.xml")

        While _reader.Read = True
            If _reader.Name = "TABLA" Then
                Dim tabla As String = _reader.GetAttribute("Name")
                If aTable = tabla Then
                    Dim _fielNameList As New List(Of String)
                    Dim _campoList As New List(Of String)
                    Dim _tipeList As New List(Of Integer)
                    Dim _posOrdenList As New List(Of Integer)

                    fName.Clear()
                    fDBName.Clear()
                    fType.Clear()

                    While _reader.Read And _reader.Name <> "TABLA"
                        If _reader.Name <> "" Then
                            Dim _fielName As String = _reader.GetAttribute("FieldName")
                            Dim _campo As String = _reader.GetAttribute("Campo")
                            Dim _posOrden As Integer = Integer.Parse(_reader.GetAttribute("PosicionOrden"))
                            Dim _type As Integer = Integer.Parse(_reader.GetAttribute("Tipo"))

                            If _posOrden <> -1 Then
                                If _posOrden <= fName.Count Then
                                    fName.Insert(_posOrden, _campo)
                                    fDBName.Insert(_posOrden, _fielName)
                                    fType.Insert(_posOrden, ColumType(_type))
                                Else
                                    _fielNameList.Add(_fielName)
                                    _campoList.Add(_campo)
                                    _tipeList.Add(_type)
                                    _posOrdenList.Add(_posOrden)
                                End If
                            End If
                        End If
                    End While

                    Dim _fielNameListArray As String() = _fielNameList.ToArray()
                    Dim _campoListArray As String() = _campoList.ToArray()
                    Dim _tipeListArray As Integer() = _tipeList.ToArray()

                    Dim _posOrdenListArray As Integer() = _posOrdenList.ToArray()
                    Dim _temp1 As Integer() = _posOrdenList.ToArray()
                    Dim _temp2 As Integer() = _posOrdenList.ToArray()

                    Array.Sort(_posOrdenListArray, _fielNameListArray)
                    Array.Sort(_temp1, _campoListArray)
                    Array.Sort(_temp2, _tipeListArray)

                    Dim i As Integer
                    For i = 0 To _posOrdenListArray.Length - 1
                        fName.Insert(_posOrdenListArray(i), _campoListArray(i))
                        fDBName.Insert(_posOrdenListArray(i), _fielNameListArray(i))
                        fType.Insert(_posOrdenListArray(i), ColumType(_tipeListArray(i)))
                    Next
                    Return
                End If
            End If
        End While

    End Sub

    Private Sub Borra()
        Dim i As Integer
        For i = 0 To gv_listado.Columns.Count - 1
            gv_listado.Columns(i).Visible = False
        Next
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

    Private Sub MostrarFechas()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Mutuas
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Formas_de_Pago
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Proveedores
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Bancos
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Conceptos_Facturables
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Paises
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Conceptos_de_Analiticas
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Pacientes_Derivaciones
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Alarmas
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Articulos
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Medicamentos
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Plantillas_de_texto
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Diagnosticos
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Gastos
                gb_intervalo_fechas.Visible = True
                FillFechas()

            Case RoleManager.Items.Indicaciones
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Plantilla_de_Historial
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Partes_Asistencia
                gb_intervalo_fechas.Visible = True
                FillFechas()

            Case RoleManager.Items.Partes_Altas_Bajas
                gb_intervalo_fechas.Visible = True
                FillFechas()
            Case RoleManager.Items.Empresas
                gb_intervalo_fechas.Visible = False

            Case RoleManager.Items.Pacientes
                gb_intervalo_fechas.Visible = True
                FillFechas()

            Case RoleManager.Items.Facturas
                gb_intervalo_fechas.Visible = True
                FillFechas()

            Case RoleManager.Items.Analiticas
                gb_intervalo_fechas.Visible = True
                FillFechas()

            Case RoleManager.Items.Plantillas_para_Analiticas
                gb_intervalo_fechas.Visible = False


        End Select
        If cb_tipo_fecha.Items.Count > 0 Then
            cb_tipo_fecha.SelectedIndex = 0
        End If

        'se oculta este panel por que no funcionan bien esos filtros
        gb_intervalo_fechas.Visible = False
    End Sub

    Private Sub BorraConfig(ByVal userlogin As String)
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        Dim _reader As XmlReader = New XmlTextReader(dir + "\\Config\\componente.xml")
        Dim _doc As XmlDocument = New XmlDocument()
        _doc.Load(dir + "\\Config\\configuracion.xml")
        Dim i As Integer
        For i = 1 To _doc.ChildNodes(1).ChildNodes.Count - 1
            Dim node As XmlNode = _doc.ChildNodes(1).ChildNodes(i)
            If node.Name = "USER" Then
                _doc.ChildNodes(1).RemoveChild(node)
            End If
        Next
        _doc.Save(dir + "\\Config\\configuracion.xml")
    End Sub

    Sub FillFechas()
        Dim i As Integer
        cb_tipo_fecha.Items.Clear()
        For i = 0 To fType.Count - 1
            If fType.Item(i).Name = "DateTime" Then
                cb_tipo_fecha.Items.Add(fName.Item(i))
            End If
        Next

    End Sub

    Sub FillCombobox()
        cb_campos_filtro.Items.Clear()
        cb_ordenar.Items.Clear()
        Dim _name As String
        For Each _name In fName
            cb_campos_filtro.Items.Add(_name)
            cb_ordenar.Items.Add(_name)
        Next
        If cb_campos_filtro.Items.Count > 0 Then cb_campos_filtro.SelectedIndex = 0
        If cb_ordenar.Items.Count > 0 Then cb_ordenar.SelectedIndex = 0
    End Sub

    Sub VerificaXML(ByVal aTable As String)
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Header")
        dt.Columns.Add("Pos")
        dt.Columns.Add("Ancho")
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        Dim _reader As XmlReader = New XmlTextReader(dir + "\\Config\\componente.xml")
        While _reader.Read = True
            If _reader.Name = "TABLA" Then
                Dim tabla As String = _reader.GetAttribute("Name")
                If aTable = tabla Then
                    While _reader.Read And _reader.Name <> "TABLA"
                        Dim Visible As String = _reader.GetAttribute("Visible")
                        If Visible = "TRUE" Then
                            Dim columname As String = _reader.GetAttribute("FieldName")
                            Dim pos As Integer = Integer.Parse(_reader.GetAttribute("Posicion"))
                            Dim ancho As Integer = Integer.Parse(_reader.GetAttribute("Ancho"))
                            Dim header As String = _reader.GetAttribute("Campo")
                            dt.Rows.Add(columname, header, pos, ancho)
                        End If
                    End While

                    Dim cant As Integer = 0
                    While cant < dt.Rows.Count
                        Dim i As Integer
                        For i = 0 To dt.Rows.Count - 1
                            If dt.Rows(i).Item("Pos") = cant.ToString() Then
                                Dim columname As String = dt.Rows(i).Item("Nombre")
                                Dim header As String = dt.Rows(i).Item("Header")
                                Dim pos As Integer = Integer.Parse(dt.Rows(i).Item("Pos").ToString())
                                Dim ancho As Integer = Integer.Parse(dt.Rows(i).Item("Ancho").ToString())
                                If gv_listado.Columns.Contains(columname) Then
                                    gv_listado.Columns(columname).HeaderText = header
                                    gv_listado.Columns(columname).DisplayIndex = pos
                                    gv_listado.Columns(columname).Visible = True
                                    gv_listado.Columns(columname).Width = ancho
                                    Continue For
                                Else
                                    gv_listado.Columns.Add(columname, header)
                                    gv_listado.Columns(columname).DisplayIndex = pos
                                    gv_listado.Columns(columname).Visible = True
                                    gv_listado.Columns(columname).Width = ancho

                                End If
                            End If
                        Next
                        cant = cant + 1
                    End While
                    Return
                End If
            End If
        End While
    End Sub

    Sub MostrarColumnas()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos
                Borra()
                VerificaXML("Medicos")

            Case RoleManager.Items.Mutuas
                VerificaXML("Mutuas")

            Case RoleManager.Items.Formas_de_Pago
                VerificaXML("FormasPago")

            Case RoleManager.Items.Proveedores
                VerificaXML("Proveedores")

            Case RoleManager.Items.Bancos
                VerificaXML("Bancos")

            Case RoleManager.Items.Conceptos_Facturables
                VerificaXML("ConceptosFra")

            Case RoleManager.Items.Paises
                VerificaXML("Paises")

            Case RoleManager.Items.Conceptos_de_Analiticas
                VerificaXML("ConceptosAnalitica")

            Case RoleManager.Items.Pacientes_Derivaciones
                VerificaXML("Derivaciones_Destinos")

            Case RoleManager.Items.Alarmas
                VerificaXML("Alarmas")

            Case RoleManager.Items.Articulos
                VerificaXML("Articulos")

            Case RoleManager.Items.Medicamentos
                VerificaXML("Medicamentos")

            Case RoleManager.Items.Plantillas_de_texto
                VerificaXML("Plantillas")

            Case RoleManager.Items.Diagnosticos
                VerificaXML("Diagnosticos")

            Case RoleManager.Items.Gastos
                VerificaXML("Gastos")

            Case RoleManager.Items.Indicaciones
                VerificaXML("Indicaciones")

            Case RoleManager.Items.Plantilla_de_Historial
                VerificaXML("PlantillaHistoriales")

            Case RoleManager.Items.Partes_Asistencia
                VerificaXML("Partes")

            Case RoleManager.Items.Partes_Altas_Bajas
                VerificaXML("Partes")

            Case RoleManager.Items.Empresas
                VerificaXML("Empresas")

            Case RoleManager.Items.Pacientes
                VerificaXML("Pacientes")

            Case RoleManager.Items.Facturas
                VerificaXML("Facturas")

            Case RoleManager.Items.Analiticas
                VerificaXML("Analiticas")

            Case RoleManager.Items.Plantillas_para_Analiticas
                VerificaXML("PlantillaAnaliticas")

                'Case RoleManager.Items.Usuarios
                '    VerificaXML("Usuarios")

            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                VerificaXML("ModelosComparativa")

            Case RoleManager.Items.Recibos
                VerificaXML("Recibos")
        End Select

    End Sub

    Sub ClearValues()
        tb_desde.Text = ""
        tb_hasta.Text = ""
        If chb_intervalo.Checked Then
            chb_intervalo.Checked = False
        End If
        fWhere = ""
        fOrder = ""
    End Sub

    Public Sub Filtrar(ByVal aTable As String, ByVal aWhere As String, ByVal aOrder As String)
        Dim _table As String = aTable
        Dim _where As String = aWhere
        Dim _order As String = aOrder

        If _table <> "" And _table <> Nothing Then

            Select Case Me.CurrentList
                Case RoleManager.Items.Medicos
                    Me.MEDICOSTableAdapter.FillMedicos(CMDataSet.MEDICOS, _table, _where, _order)
                    gv_listado.DataSource = Me.MEDICOSBindingSource
                    nav_listado.BindingSource = Me.MEDICOSBindingSource

                Case RoleManager.Items.Mutuas
                    Me.MUTUASTableAdapter.FillMutuas(CMDataSet.MUTUAS, _table, _where, _order)
                    gv_listado.DataSource = Me.MUTUASBindingSource
                    nav_listado.BindingSource = Me.MUTUASBindingSource
                Case RoleManager.Items.Formas_de_Pago

                Case RoleManager.Items.Proveedores
                    Me.PROVEEDORESTableAdapter.FillProveedores(CMDataSet.PROVEEDORES, _table, _where, _order)
                    gv_listado.DataSource = Me.PROVEEDORESBindingSource
                    nav_listado.BindingSource = Me.PROVEEDORESBindingSource

                Case RoleManager.Items.Bancos
                    Me.BANCOSTableAdapter.FillBancos(CMDataSet.BANCOS, _table, _where, _order)
                    gv_listado.DataSource = Me.BANCOSBindingSource
                    nav_listado.BindingSource = Me.BANCOSBindingSource

                Case RoleManager.Items.Conceptos_Facturables
                    Me.CONCEPTOSFRATableAdapter.FillConceptosFra(CMDataSet.CONCEPTOSFRA, _table, _where, _order)
                    gv_listado.DataSource = Me.CONCEPTOSFRABindingSource
                    nav_listado.BindingSource = Me.CONCEPTOSFRABindingSource

                Case RoleManager.Items.Paises
                    Me.PAISESTableAdapter.FillPaises(CMDataSet.PAISES, _table, _where, _order)
                    gv_listado.DataSource = Me.PAISESBindingSource
                    nav_listado.BindingSource = Me.PAISESBindingSource

                Case RoleManager.Items.Conceptos_de_Analiticas
                    Me.CONCEPTOSANALITICATableAdapter.FillConceptoAnalitica(CMDataSet.CONCEPTOSANALITICA, _table, _where, _order)
                    gv_listado.DataSource = Me.CONCEPTOSANALITICABindingSource
                    nav_listado.BindingSource = Me.CONCEPTOSANALITICABindingSource

                Case RoleManager.Items.Alarmas
                    Me.ALARMASTableAdapter.FillAlarmas(CMDataSet.ALARMAS, _table, _where, _order)
                    gv_listado.DataSource = Me.ALARMASBindingSource
                    nav_listado.BindingSource = Me.ALARMASBindingSource

                Case RoleManager.Items.Articulos
                    Me.ARTICULOSTableAdapter.FillArticulo(CMDataSet.ARTICULOS, _table, _where, _order)
                    gv_listado.DataSource = Me.ARTICULOSBindingSource
                    nav_listado.BindingSource = Me.ARTICULOSBindingSource

                Case RoleManager.Items.Medicamentos
                    Me.MEDICAMENTOSTableAdapter.FillMedicamentos(CMDataSet.MEDICAMENTOS, _table, _where, _order)
                    gv_listado.DataSource = Me.MEDICAMENTOSBindingSource
                    nav_listado.BindingSource = Me.MEDICAMENTOSBindingSource

                Case RoleManager.Items.Diagnosticos
                    Me.DIAGNOSTICOSTableAdapter.FillDiagnosticos(CMDataSet.DIAGNOSTICOS, _table, _where, _order)
                    gv_listado.DataSource = Me.DIAGNOSTICOSBindingSource
                    nav_listado.BindingSource = Me.DIAGNOSTICOSBindingSource

                Case RoleManager.Items.Gastos
                    Me.GASTOSTableAdapter.FillGastos(CMDataSet.GASTOS, _table, _where, _order)
                    gv_listado.DataSource = Me.GASTOSBindingSource
                    nav_listado.BindingSource = Me.GASTOSBindingSource

                Case RoleManager.Items.Empresas
                    Me.EMPRESASTableAdapter.FillEmpresas(CMDataSet.EMPRESAS, _table, _where, _order)
                    gv_listado.DataSource = Me.EMPRESASBindingSource
                    nav_listado.BindingSource = Me.EMPRESASBindingSource

                Case RoleManager.Items.Pacientes
                    Me.PACIENTESTableAdapter.FillPacientes(CMDataSet.PACIENTES, _table, _where, _order)
                    gv_listado.DataSource = Me.PACIENTESBindingSource
                    nav_listado.BindingSource = Me.PACIENTESBindingSource

                Case RoleManager.Items.Facturas
                    Me.FACTURASTableAdapter.FillFacturas(CMDataSet.FACTURAS, _table, _where, _order)
                    gv_listado.DataSource = Me.FACTURASBindingSource
                    nav_listado.BindingSource = Me.FACTURASBindingSource

                Case RoleManager.Items.Analiticas
                    Me.ANALITICASTableAdapter.FillAnaliticas(CMDataSet.ANALITICAS, _table, _where, _order)
                    gv_listado.DataSource = Me.ANALITICASBindingSource
                    nav_listado.BindingSource = Me.ANALITICASBindingSource

                Case RoleManager.Items.Indicaciones
                    Me.INDICACIONESTableAdapter.FillIndicaciones(CMDataSet.INDICACIONES, _table, _where, _order)
                    gv_listado.DataSource = Me.INDICACIONESBindingSource
                    nav_listado.BindingSource = Me.INDICACIONESBindingSource

                Case RoleManager.Items.Pacientes_Derivaciones
                    Me.DERIVACIONES_DESTINOSTableAdapter.FillClinicas(CMDataSet.DERIVACIONES_DESTINOS, _table, _where, _order)
                    gv_listado.DataSource = Me.DERIVACIONES_DESTINOSBindingSource
                    nav_listado.BindingSource = Me.DERIVACIONES_DESTINOSBindingSource

                Case RoleManager.Items.Plantillas_de_texto
                    Me.PLANTILLASTableAdapter.FillPlantillaTextos(CMDataSet.PLANTILLAS, _table, _where, _order)
                    gv_listado.DataSource = Me.PLANTILLASBindingSource
                    nav_listado.BindingSource = Me.PLANTILLASBindingSource

                Case RoleManager.Items.Plantilla_de_Historial
                    Me.PLANTILLA_HISTORIALESTableAdapter.FillPlantillaHistoriales(CMDataSet.PLANTILLA_HISTORIALES, _table, _where, _order)
                    gv_listado.DataSource = Me.PLANTILLA_HISTORIALESBindingSource
                    nav_listado.BindingSource = Me.PLANTILLA_HISTORIALESBindingSource

                Case RoleManager.Items.Partes_Asistencia

                    If _where <> "" Then
                        _where = _where + " AND (TIPO='S')"
                    Else
                        _where = " Where (TIPO='S')"
                    End If
                    PARTESTableAdapter.FillPartes(CMDataSet.PARTES, _table, _where, _order)
                    gv_listado.DataSource = Me.PARTESBindingSource
                    nav_listado.BindingSource = Me.PARTESBindingSource

                Case RoleManager.Items.Partes_Altas_Bajas
                    If _where <> "" Then
                        _where = _where + " AND (TIPO<>'S')"
                    Else
                        _where = " Where (TIPO<>'S')"
                    End If
                    PARTESTableAdapter.FillPartes(CMDataSet.PARTES, _table, _where, _order)
                    gv_listado.DataSource = Me.PARTESBindingSource
                    nav_listado.BindingSource = Me.PARTESBindingSource

                Case RoleManager.Items.Plantillas_para_Analiticas
                    Me.PLANTILLAANALITICASTableAdapter.FillPlantillaAnaliticas(CMDataSet.PLANTILLAANALITICAS, _table, _where, _order)
                    gv_listado.DataSource = Me.PLANTILLASBindingSource
                    nav_listado.BindingSource = Me.PLANTILLASBindingSource
            End Select
            MostrarColumnas()
            fTable = _table
            fWhere = _where
            fOrder = _order
        End If
    End Sub

    Public Property Selection() As Boolean
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return seleccionando
        End Get
        Set(ByVal value As Boolean)
            seleccionando = value
        End Set

    End Property

    Public Property BindingNavigatorSource() As BindingSource
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return nav_listado.BindingSource
        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As BindingSource)
            nav_listado.BindingSource = Value
        End Set
    End Property

    Public Property GridViewSource() As Object
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return gv_listado.DataSource
        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Object)
            gv_listado.DataSource = Value
        End Set
    End Property

    Public ReadOnly Property Selected() As String
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fSeleccion
        End Get

    End Property

    Public Property CurrentList() As RoleManager.Items

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return currentlistar

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As RoleManager.Items)
            currentlistar = Value
        End Set
    End Property

    Private Function QueryWhere() As String

        Dim _where As String = ""
        Dim _index As Integer = cb_campos_filtro.SelectedIndex

        If _index <> -1 Then
            Dim _name As String = cb_campos_filtro.Items(_index)

            If fName.Contains(_name) Then
                Dim _pos As Integer = fName.IndexOf(_name)
                Select Case fType.Item(_pos).Name
                    Case Type.GetType("System.Int32").Name

                        If tb_desde.Text <> "" And tb_desde.Text <> Nothing Then
                            Dim _numero1 As Integer
                            Dim _numero2 As Integer

                            If tb_hasta.Text <> "" And tb_hasta.Text <> Nothing Then
                                If Integer.TryParse(tb_desde.Text.Trim(), _numero1) And Integer.TryParse(tb_hasta.Text.Trim(), _numero2) Then
                                    _where = " Where (" + fDBName.Item(_pos) + " >= " + _numero1.ToString() + " AND " + fDBName.Item(_pos) + " <= " + _numero2.ToString() + ") "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                If Integer.TryParse(tb_desde.Text.Trim(), _numero1) Then
                                    _where = " Where (" + fDBName.Item(_pos) + " >= " + _numero1.ToString() + ") "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        Else
                            If Not chb_intervalo.Checked Then
                                MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    Case Type.GetType("System.String").Name

                        Dim _strCampo1 As String = tb_desde.Text.Trim()
                        Dim _strCampo2 As String = tb_hasta.Text.Trim()

                        If tb_desde.Text <> "" And tb_desde.Text <> Nothing Then

                            If tb_hasta.Text <> "" And tb_hasta.Text <> Nothing Then
                                _where = " Where ((" + fDBName.Item(_pos) + " Between '" + _strCampo1.ToString() + "' And '" + _strCampo2.ToString() + "') Or " + fDBName.Item(_pos) + " Like '" + _strCampo2.ToString() + "%') "
                            Else
                                _where = " Where (" + fDBName.Item(_pos) + " >= '" + _strCampo1.ToString() + "')"
                            End If
                        Else
                            If Not chb_intervalo.Checked Then
                                MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    Case Type.GetType("System.DateTime").Name

                        Dim _date1 As Date
                        Dim _date2 As Date

                        If tb_desde.Text <> "" And tb_desde.Text <> Nothing Then

                            If tb_hasta.Text <> "" And tb_hasta.Text <> Nothing Then

                                If Date.TryParse(tb_desde.Text.Trim(), _date1) And Date.TryParse(tb_hasta.Text.Trim(), _date2) Then
                                    _where = " Where (" & fDBName.Item(_pos) & " >= CAST('" & _date1 & "' AS datetime) And " & fDBName.Item(_pos) & " <=CAST('" & _date2 & "'AS datetime)) "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser fechas válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                If Date.TryParse(tb_desde.Text.Trim(), _date1) Then
                                    _where = " Where (" & fDBName.Item(_pos) & " >= CAST('" & _date1 & "' AS datetime)) "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser fechas válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        Else
                            If Not chb_intervalo.Checked Then
                                MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    Case Type.GetType("System.Decimal").Name

                        If tb_desde.Text <> "" And tb_desde.Text <> Nothing Then
                            Dim _numero1 As Decimal
                            Dim _numero2 As Decimal

                            If tb_hasta.Text <> "" And tb_hasta.Text <> Nothing Then
                                If Decimal.TryParse(tb_desde.Text.Trim(), _numero1) And Decimal.TryParse(tb_hasta.Text.Trim(), _numero2) Then
                                    _where = " Where (" + fDBName.Item(_pos) + " >= " + _numero1.ToString().Replace(",", ".") + " AND " + fDBName.Item(_pos) + " <= " + _numero2.ToString().Replace(",", ".") + ") "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                If Decimal.TryParse(tb_desde.Text.Trim(), _numero1) Then
                                    _where = " Where (" + fDBName.Item(_pos) + " >= " + _numero1.ToString().Replace(",", ".") + ") "
                                Else
                                    MessageBox.Show("Por favor los valores introducidos deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        Else
                            If Not chb_intervalo.Checked Then
                                MessageBox.Show("Por favor introduzca un valor en el campo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                End Select
            End If
        End If
        Dim _fecha As String = QueryWhereFecha()
        If _fecha <> "" Then
            If _where <> "" Then
                _where = _where & " And " & _fecha
            Else
                _where = " Where " & _fecha
            End If
        End If
        Return _where
    End Function

    Private Function QueryWhereFecha() As String
        Dim _where As String = ""
        If chb_intervalo.Checked Then
            Dim _index As Integer = cb_tipo_fecha.SelectedIndex
            If _index <> -1 Then
                Dim _strName As String = cb_tipo_fecha.Items(_index).ToString()
                Dim _pos As Integer = fName.LastIndexOf(_strName)
                If _pos <> -1 Then
                    Dim _campo As String = fDBName.Item(_pos)
                    _where = " (" & _campo & ">= CAST('" & dtp_fecha_min.Value.Date & "'AS datetime) And " & _campo & "<= CAST('" & dtp_fecha_max.Value.Date & "'AS datetime))"
                End If
            End If
        End If

        Return _where
    End Function

    Private Function QueryOrder()
        Dim _order As String = ""
        Dim _index As Integer = cb_ordenar.SelectedIndex

        If _index <> -1 Then
            Dim _name As String = cb_campos_filtro.Items(_index)
            Dim _pos As Integer = fName.IndexOf(_name)
            _order = " Order By " + fDBName.Item(_pos)
        End If
        Return _order
    End Function

    Private Function QueryTable() As String
        Dim _table As String = ""

        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos
                _table = "Medicos"
            Case RoleManager.Items.Mutuas
                _table = "MutuaS"
            Case RoleManager.Items.Formas_de_Pago
                _table = "Formaspago"
            Case RoleManager.Items.Proveedores
                _table = "Proveedores"
            Case RoleManager.Items.Bancos
                _table = "Bancos"
            Case RoleManager.Items.Conceptos_Facturables
                _table = "ConceptosFra"
            Case RoleManager.Items.Paises
                _table = "Paises"
            Case RoleManager.Items.Conceptos_de_Analiticas
                _table = "ConceptosAnalitica"
            Case RoleManager.Items.Pacientes_Derivaciones
                _table = "Derivaciones_Destinos"
            Case RoleManager.Items.Alarmas
                _table = "AlarmaS"
            Case RoleManager.Items.Articulos
                _table = "Articulos"
            Case RoleManager.Items.Medicamentos
                _table = "Medicamentos"
            Case RoleManager.Items.Plantillas_de_texto
                _table = "Plantillas"
            Case RoleManager.Items.Diagnosticos
                _table = "Diagnosticos"
            Case RoleManager.Items.Gastos
                _table = "Gastos"
            Case RoleManager.Items.Indicaciones
                _table = "Indicaciones"
            Case RoleManager.Items.Plantilla_de_Historial
                _table = "PlantillaHistoriales"
            Case RoleManager.Items.Partes_Asistencia
                _table = "Partes"
            Case RoleManager.Items.Partes_Altas_Bajas
                _table = "Partes"
            Case RoleManager.Items.Empresas
                _table = "Empresas"
            Case RoleManager.Items.Pacientes
                _table = "Pacientes"
            Case RoleManager.Items.Facturas
                _table = "Facturas"
            Case RoleManager.Items.Analiticas
                _table = "Analiticas"
            Case RoleManager.Items.Plantillas_para_Analiticas
                _table = "PlantillaAnaliticas"
            Case RoleManager.Items.Recibos
                _table = "Recibos"

        End Select
        Return _table
    End Function

    Private Function ColumType(ByVal aIntType As Integer) As Type
        Dim _str As String = ""
        Dim _int As Integer = 0
        Dim _date As System.DateTime = Date.Now
        Dim _decimal As Decimal = 1.0

        'Dim _result As Type
        Select Case aIntType
            Case 0
                Return _str.GetType()
            Case 1
                Return _int.GetType()
            Case 2
                Return _date.GetType()
            Case 3
                Return _decimal.GetType()
        End Select
        'Return _result
    End Function

    Private Sub gv_listado_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gv_listado.CellFormatting
        Select Case Me.CurrentList
            Case RoleManager.Items.Pacientes
                Dim paciente As CMDataSet.PACIENTESRow = gv_listado.Rows(e.RowIndex).DataBoundItem.Row
                If Not paciente.IsDEFUNCIONNull() Then
                    If paciente.DEFUNCION = "S" Then
                        gv_listado.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                    Else
                        gv_listado.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                    End If
                Else
                    gv_listado.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                End If

                If Not paciente.IsSOCIONull Then
                    If paciente.SOCIO = "S" Then
                        gv_listado.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Purple
                    End If
                End If

                If paciente.BENEFICIARIOCODIGOSOCIO > 0 Then
                    gv_listado.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
                End If


        End Select


    End Sub

    Private Sub AnaliticasSinRecibir_Click(sender As Object, e As EventArgs) Handles btAnaliticasSinRecibir.Click
        Filtrar("Analiticas", " Where Recibida=0 Or Recibida is Null", " Order by Paciente Asc")
    End Sub
End Class
