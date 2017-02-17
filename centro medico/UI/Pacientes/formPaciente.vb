Imports System
Imports centro_medico.UI.Citas
Imports centro_medico.UI.Reportes

Public Class formPaciente
    Dim fId As Integer
    Dim fcurrentAcc As Integer
    Dim fCambios As Boolean = False
    Dim fCerrando As Boolean = False
    'Dim frmCitas As form_citas_ex
    Dim frmCitas As frmCalendarioCitas
    'Dim frmDatosPersonales As form_datospersonales
    Dim frmPacienteEditar As frmPaciente_Editar
    Dim frmHistorialLaboral As form_hislaboral
    Dim frmFacturas As frmFacturasM
    Dim frmFormasPago As frmPaciente_FormasPago
    Dim frmFicherosMulti As form_ficherosmult
    Dim frmServiciosPeriodicos As frmConceptoFacturableListado
    Dim frmrecibos As form_recibos_ex
    Dim frmPartes As form_partes
    Dim frmAntecedentes As form_antecedentes
    Dim frmHistorialClinico As frmHistoriales
    'Dim frmHistorialClinico As form_hisactuales


    Dim frmDerivaciones As form_derivaciones_ex
    Dim frmRecetas As frmRecetas
    Dim frmAnaliticas As form_analiticas_ex
    'Dim frmRevComparativa As form_revisiones_ex
    Dim frmRevComparativa As frmRevisiones
    Dim frmInfMedico As frmInformeMedico
    Dim fdataPaciente As CMDataSet.PACIENTESDataTable

#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
    End Sub
#End Region


#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)"
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

        InitializeComponent()
        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId

    End Sub
#End Region

    Public Property CurrentAccion() As Enums.Accion
        Get
            Return fcurrentAcc
        End Get
        Set(ByVal Value As Enums.Accion)
            fcurrentAcc = Value
        End Set
    End Property

    Private Sub formPaciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        For Each a As Form In Me.MdiChildren
            a.Dispose()
        Next
        FreeMemory.FlushMemory()
    End Sub

    Private Sub formPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.LINEASALARMA' Puede moverla o quitarla según sea necesario.
        Me.LINEASALARMATableAdapter.FillByPaciente(Me.CMDataSet.LINEASALARMA, fId)
        Me.ALARMASTableAdapter.FillAlarmaByPaciente(Me.CMDataSet.ALARMAS, fId)
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)

        AplicaPermisos()

        

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            fdataPaciente = New CMDataSet.PACIENTESDataTable()
            fdataPaciente.ImportRow(CMDataSet.PACIENTES.FindByCPACIENTE(fId))
            'If fId <> 0 Then
            '    '  Inicializa()
            'End If



        ElseIf Me.CurrentAccion = Enums.Accion.Ver Then
            'If fId <> 0 Then
            '    '  Inicializa()
            'End If

        ElseIf Me.CurrentAccion = Enums.Accion.Insertar Then

            Dim _newRow As CMDataSet.PACIENTESRow = CMDataSet.PACIENTES.NewPACIENTESRow()
            Dim _rows() As CMDataSet.PACIENTESRow = CMDataSet.PACIENTES.Select("", "CPACIENTE ASC")

            Dim _maxBD As Integer = 1
            If PACIENTESTableAdapter.MaximoId.HasValue Then
                If Integer.TryParse(PACIENTESTableAdapter.MaximoId(), _maxBD) Then
                    _maxBD = _maxBD + 1
                End If
            End If

            Dim _maxDS As Integer = 1

            If _rows.Length > 0 Then
                _maxDS = _rows(_rows.Length - 1).CPACIENTE() + 1
            End If

            _newRow.CPACIENTE() = Math.Max(_maxDS, _maxBD)

            _newRow.REFPAIS() = 1
            _newRow.Eliminado = False

            'inicializamos del valor de la fecha de ingreso.
            _newRow.FECHAALTA = Now.Date

            CMDataSet.PACIENTES.AddPACIENTESRow(_newRow)
            fId = CMDataSet.PACIENTES.Rows(CMDataSet.PACIENTES.Rows.Count - 1).Item("CPACIENTE")

            'Inicializar todos los formularios, esto evita las preguntas de IsNull
            frmFormasPago = New frmPaciente_FormasPago()
            frmFormasPago.MdiParent = Me


            _newRow.CODIGOPROPIO = ""
            'frmDatosPersonales = New form_datospersonales(fId, Me, Enums.Accion.Ver)
            'frmDatosPersonales.MdiParent = Me

            frmHistorialLaboral = New form_hislaboral(fId)
            frmHistorialLaboral.MdiParent = Me



            'inserto ya los datos del nuevo paciente para evitar posibles problemas de concurrencia con otros usuarios de la red
            'y abrimos el form de datos personales para rellenar los datos básicos.
            Me.PACIENTESTableAdapter.Update(CMDataSet.PACIENTES)

            If bt_DatosPersonales.Enabled Then
                Me.bt_DatosPersonales_Click(Nothing, Nothing)
            End If

            'tb_Codigo.Text = fId
            'cb_dpSexo.Items.Add("Hombre")
            'cb_dpSexo.Items.Add("Mujer")

            'cb_dpSexo.SelectedIndex = 0
            'chb_dpActivo.Checked = True

        End If


        'Inicializar todos los formularios, esto evita las preguntas de IsNull
        frmFormasPago = New frmPaciente_FormasPago()
        frmFormasPago.MdiParent = Me

        'frmDatosPersonales = New form_datospersonales(fId, Me, Enums.Accion.Ver)
        'frmDatosPersonales.MdiParent = Me

        frmHistorialLaboral = New form_hislaboral(fId)
        frmHistorialLaboral.MdiParent = Me

        frmPacienteEditar = New frmPaciente_Editar(fId)
        frmPacienteEditar.MdiParent = Me


        ActualizarFechaNac()
        CargarAlarmas()

        'Muestro el menu definido en la configuración
        If Globales.Configuracion.solapasvisibles = "Administrativos" Then
            Me.NavigationBar1.SelectedItem = Me.nbp_DatosAdministrativos
        Else
            Me.NavigationBar1.SelectedItem = Me.nbp_DatosMedicos
        End If


        'Carga el formulario que se haya indicado en la configuración.
        If Not CurrentAccion = Enums.Accion.Insertar Then
            If Globales.Configuracion.solapasinicial = "Antecedentes" Then
                Me.bt_Antecedentes_Click(Nothing, Nothing)
            Else
                If Me.bt_DatosPersonales.Enabled Then
                    Me.bt_DatosPersonales_Click(Nothing, Nothing)
                End If

            End If
        End If

        
        lblConsentimiento.Visible = Not CompruebaConsentimiento(fId)


        AddHandler frmPacienteEditar.FormClosed, AddressOf frmPacienteEditarClosed

    End Sub

    Public Function CompruebaConsentimiento(ByVal fid As Integer) As Boolean
        Dim context As New CMLinqDataContext
        Dim pacienteTmp As PACIENTE
        pacienteTmp = (From a In context.PACIENTEs Where a.CPACIENTE = fid Select a).SingleOrDefault
        If pacienteTmp.TieneDocumentoConsentimiento Then
            Return True
        End If
        Return False
    End Function

    Private Sub frmPacienteEditarClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ActualizarFechaNac()
        If Not frmPacienteEditar.IsDisposed Then
            frmPacienteEditar.Dispose()
        End If
        FreeMemory.FlushMemory()
    End Sub

#Region "Private Sub AplicaPermisos()"
    Private Sub AplicaPermisos()
        'Por cada item desactivar las opciones asociadas

        bt_DatosPersonales.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) = RoleManager.TipoPermisos.Ninguno)
        'bt_HistorialLaboral.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) = RoleManager.TipoPermisos.Ninguno)
        bt_Citas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Citas) = RoleManager.TipoPermisos.Ninguno)
        bt_Facturas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Facturas) = RoleManager.TipoPermisos.Ninguno)
        bt_FormaPago.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Formas_de_Pago) = RoleManager.TipoPermisos.Ninguno)
        bt_FicherosMultimedia.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) = RoleManager.TipoPermisos.Ninguno)
        bt_ServiciosPeriodicos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) = RoleManager.TipoPermisos.Ninguno)
        bt_Recibos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) = RoleManager.TipoPermisos.Ninguno)
        bt_PartesBajaAlta.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Altas_Bajas) = RoleManager.TipoPermisos.Ninguno)
        btn_PartesAsistencia.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Partes_Asistencia) = RoleManager.TipoPermisos.Ninguno)

        bt_Antecedentes.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) = RoleManager.TipoPermisos.Ninguno)
        bt_HistorialClinico.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) = RoleManager.TipoPermisos.Ninguno)
        bt_Derivaciones.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Ninguno)

        bt_Recetas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recetas) = RoleManager.TipoPermisos.Ninguno)
        bt_Analiticas.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) = RoleManager.TipoPermisos.Ninguno)
        bt_RevComparativa.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) = RoleManager.TipoPermisos.Ninguno)
        btnReportesPersonalizados.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) = RoleManager.TipoPermisos.Ninguno)
        btProcesos.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Procesos) = RoleManager.TipoPermisos.Ninguno)
    End Sub
#End Region


    Private Sub tb_CodigoPropio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_CodigoPropio.TextChanged
        fCambios = True
    End Sub

    Private Sub bt_Citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Citas.Click
        'If (frmPacienteEditar.Visible = True) Then
        '    MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las citas. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
        '    Return
        'End If
        If frmCitas Is Nothing OrElse frmCitas.Visible = False Then
            frmCitas = New frmCalendarioCitas()
            frmCitas.IdPaciente = fId
            frmCitas.WindowState = FormWindowState.Maximized
            frmCitas.MdiParent = Me
            frmCitas.Show()
        End If
        frmCitas.Focus()
    End Sub

    Private Sub bt_DatosPersonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_DatosPersonales.Click

        'If (frmHistorialLaboral.Visible = True) Then
        '    MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las Formas de Pago. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
        '    Return
        'End If

        'If (frmFormasPago.Visible = True) Then
        '    MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las Formas de Pago. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
        '    Return
        'End If

        'If frmDatosPersonales.Visible = False Or frmDatosPersonales.IsDisposed Then
        '    frmDatosPersonales = New form_datospersonales(fId, Me, Enums.Accion.Ver)
        '    frmDatosPersonales.MdiParent = Me
        '    frmDatosPersonales.Show()
        'End If

        'frmDatosPersonales.Focus()


        If (frmFormasPago.Visible = True) Then
            MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las Formas de Pago. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
            Return
        End If

            'creo el formulario
        'Dim context As New CMLinqDataContext()
            Dim idPaciente As Integer = Me.fId
        If frmPacienteEditar Is Nothing OrElse frmPacienteEditar.Visible = False Then

            frmPacienteEditar = New frmPaciente_Editar(idPaciente)
            frmPacienteEditar.WindowState = FormWindowState.Maximized
            frmPacienteEditar.MdiParent = Me
            frmPacienteEditar.Show()
            
            Return
        End If
        frmPacienteEditar.TabControl1.SelectedTab = frmPacienteEditar.TabPageDetalles
        frmPacienteEditar.Focus()
    End Sub

    Private Sub SalvarDatosPaciente()

    End Sub

    Private Sub bt_HistorialLaboral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (frmFormasPago.Visible = True) Then
            MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las Formas de Pago. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
            Return
        End If

        Dim context As New CMLinqDataContext()
        Dim idPaciente As Integer = Me.fId
        If frmPacienteEditar Is Nothing OrElse frmPacienteEditar.Visible = False Then

            'Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = idPaciente Select p).First()
            frmPacienteEditar = New frmPaciente_Editar(idPaciente)
            frmPacienteEditar.WindowState = FormWindowState.Maximized
            frmPacienteEditar.MdiParent = Me
            frmPacienteEditar.TabControl1.SelectedTab = frmPacienteEditar.HClinico
            frmPacienteEditar.Show()

            Return
        End If
        'Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = idPaciente Select p).First()
        'frmPacienteEditar = New frmPaciente_Editar(idPaciente)
        'frmPacienteEditar.WindowState = FormWindowState.Maximized
        ''frmPacienteEditar.MdiParent = Me
        'frmPacienteEditar.PACIENTESBindingSource.DataSource = pac
        'frmPacienteEditar.TabControl1.SelectedTab = frmPacienteEditar.HClinico
        ''frmPacienteEditar.Show()
        'If (frmPacienteEditar.ShowDialog() = Windows.Forms.DialogResult.OK) Then
        '    pac.FECHAN = frmPacienteEditar.dtp_dpFeNac.Value
        '    If frmPacienteEditar.dtp_dpFechaAlta.Checked Then
        '        pac.FECHAALTA = frmPacienteEditar.dtp_dpFechaAlta.Value
        '    End If
        '    If frmPacienteEditar.dtp_dpFechabaja.Checked Then
        '        pac.FECHABAJA = frmPacienteEditar.dtp_dpFechabaja.Value
        '    End If
        '    If frmPacienteEditar.cb_dpSexo.SelectedItem = "Mujer" Then
        '        pac.SEXO = "M"
        '    Else
        '        pac.SEXO = "H"
        '    End If

        '    pac.REFEMPRESA = frmPacienteEditar.IDEMPRESA
        '    pac.REFMUTUA = frmPacienteEditar.IDMUTUA
        '    pac.CONOCIO = frmPacienteEditar.cb_comoconocio.SelectedItem
        '    context.SubmitChanges()
        '    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes, "nuevo paciente", pac.CPACIENTE.ToString(), "nombre : " & pac.NombreCompleto)
        '    Return
        'End If
        frmPacienteEditar.TabControl1.SelectedTab = frmPacienteEditar.HClinico
        frmPacienteEditar.Focus()
    End Sub

    Private Sub bt_Facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Facturas.Click
        If frmFacturas Is Nothing OrElse frmFacturas.Visible = False Then
            frmFacturas = New frmFacturasM()
            frmFacturas.IDPacienteToFilter = fId
            frmFacturas.MdiParent = Me
            frmFacturas.Show()
        End If
        frmFacturas.Focus()
    End Sub

    Private Sub bt_FormaPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FormaPago.Click

        If Not frmPacienteEditar Is Nothing Then
            If frmPacienteEditar.Visible = True Then
                MsgBox("Por tratar ciertos datos en común, no se permite tener abierto los datos basicos del paciente y las Formas de Pago. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
                Return
            End If
        End If

        If frmFormasPago.Visible = False Or frmFormasPago.IsDisposed Then
            'frmFormasPago = New form_formasdepago(fId)
            frmFormasPago = New frmPaciente_FormasPago()

            Dim context As New CMLinqDataContext
            Dim paciente As PACIENTE = (From p In context.PACIENTEs
                                       Where p.CPACIENTE = fId
                                       Select p).SingleOrDefault()

            frmFormasPago.Paciente = paciente
            frmFormasPago.Context = context
            frmFormasPago.PACIENTEBindingSource.DataSource = paciente
            frmFormasPago.MdiParent = Me
            frmFormasPago.Show()
            
        End If

        frmFormasPago.Focus()
    End Sub

    Private Sub bt_FicherosMultimedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FicherosMultimedia.Click

        Dim frm As New frmFicherosAdjuntos()
        frm.IDPaciente = fId
        frm.MdiParent = Me
        frm.Show()
        'If frmFicherosMulti Is Nothing OrElse frmFicherosMulti.Visible = False Then
        '    frmFicherosMulti = New form_ficherosmult(fId)
        '    frmFicherosMulti.MdiParent = Me
        '    Try
        '        frmFicherosMulti.Show()
        '    Catch ex As Exception
        '    End Try
        'End If
        'frmFicherosMulti.Focus()
    End Sub

    Private Sub bt_ServiciosPeriodicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ServiciosPeriodicos.Click
        If frmServiciosPeriodicos Is Nothing OrElse frmServiciosPeriodicos.Visible = False Then
            frmServiciosPeriodicos = New frmConceptoFacturableListado()
            frmServiciosPeriodicos.IdPaciente = fId
            frmServiciosPeriodicos.MdiParent = Me
            frmServiciosPeriodicos.Show()
        End If
        frmServiciosPeriodicos.Focus()
    End Sub

    Private Sub bt_Recibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Recibos.Click
        If frmrecibos Is Nothing OrElse frmrecibos.Visible = False Then
            frmrecibos = New form_recibos_ex(fId)
            frmrecibos.MdiParent = Me
            frmrecibos.Show()
        End If
        frmrecibos.Focus()
    End Sub



    Private Sub bt_Antecedentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Antecedentes.Click
        If frmAntecedentes Is Nothing OrElse frmAntecedentes.Visible = False Then
            If frmHistorialClinico Is Nothing OrElse frmHistorialClinico.Visible = False Then
                frmAntecedentes = New form_antecedentes(fId)
                frmAntecedentes.MdiParent = Me
                frmAntecedentes.Show()
            Else
                MsgBox("Por tratar ciertos datos en común, no se permite tener abierto la ventana de Antecedentes del paciente y otros formularios la lista de historias clinicas. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        '    Me.ActivateMdiChild(frmAntecedentes)
        frmAntecedentes.Focus()

    End Sub

    Private Sub bt_HistorialClinico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HistorialClinico.Click
        'If frmHistorialClinico Is Nothing OrElse frmHistorialClinico.Visible = False Then
        '    If (frmAntecedentes Is Nothing OrElse frmAntecedentes.Visible = False) And (frmRecetas Is Nothing OrElse frmRecetas.Visible = False) Then
        '        frmHistorialClinico = New form_hisactuales(fId)
        '        frmHistorialClinico.MdiParent = Me
        '        frmHistorialClinico.Show()
        '    Else
        '        MsgBox("Por tratar ciertos datos en común, no se permite tener abierto la lista de historiales clinico del paciente y otros formularios como Recetas o Antecedentes. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If
        'End If
        'frmHistorialClinico.Focus()

        If frmHistorialClinico Is Nothing OrElse frmHistorialClinico.Visible = False Then
            If (frmAntecedentes Is Nothing OrElse frmAntecedentes.Visible = False) And (frmRecetas Is Nothing OrElse frmRecetas.Visible = False) Then
                frmHistorialClinico = New frmHistoriales()
                frmHistorialClinico.WindowState = FormWindowState.Maximized

                frmHistorialClinico.IdPaciente = fId
                frmHistorialClinico.MdiParent = Me
                frmHistorialClinico.Show()
            Else
                MsgBox("Por tratar ciertos datos en común, no se permite tener abierto la lista de historiales clinico del paciente y otros formularios como Recetas o Antecedentes. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        frmHistorialClinico.Focus()
    End Sub

    Private Sub bt_Derivaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Derivaciones.Click
        If frmDerivaciones Is Nothing OrElse frmDerivaciones.Visible = False Then
            frmDerivaciones = New form_derivaciones_ex(fId)
            frmDerivaciones.MdiParent = Me
            frmDerivaciones.WindowState = FormWindowState.Maximized
            frmDerivaciones.Show()
        End If
        frmDerivaciones.Focus()
    End Sub

    Private Sub bt_Recetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Recetas.Click
        If frmRecetas Is Nothing OrElse frmRecetas.Visible = False Then
            If frmHistorialClinico Is Nothing OrElse frmHistorialClinico.Visible = False Then
                frmRecetas = New frmRecetas(fId)
                frmRecetas.MdiParent = Me
                'frmRecetas.WindowState = FormWindowState.Maximized
                frmRecetas.CtrlPacienteReceta.Enabled = False
                frmRecetas.Show()
            Else
                MsgBox("Por tratar ciertos datos en común, no se permite tener abierto la lista de recetas del paciente y otros formularios como la lista de historias clínicas. Cierre una de esas ventanas para abrir la otra.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        frmRecetas.Focus()
    End Sub

    Private Sub bt_Analiticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Analiticas.Click
        If frmAnaliticas Is Nothing OrElse frmAnaliticas.Visible = False Then
            frmAnaliticas = New form_analiticas_ex(fId)
            frmAnaliticas.MdiParent = Me
            frmAnaliticas.Show()
        End If
        frmAnaliticas.Focus()
    End Sub

    Private Sub bt_RevComparativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_RevComparativa.Click

        If frmRevComparativa Is Nothing OrElse frmRevComparativa.Visible = False Then
            frmRevComparativa = New frmRevisiones()
            frmRevComparativa.ID_Paciente = fId
            frmRevComparativa.MdiParent = Me
            frmRevComparativa.Show()
        End If
        'frmRevComparativa.Focus()
        'If frmRevComparativa Is Nothing OrElse frmRevComparativa.Visible = False Then
        '    frmRevComparativa = New form_revisiones_ex(fId)
        '    frmRevComparativa.MdiParent = Me
        '    frmRevComparativa.Show()
        'End If
        'frmRevComparativa.Focus()
    End Sub


    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click

        Dim context As New CMLinqDataContext()
        Dim lista As List(Of PACIENTE) = (From p In context.PACIENTEs Where p.CPACIENTE = fId).ToList()

        Dim rep As New Microsoft.Reporting.WinForms.ReportDataSource
        rep.Name = "centro_medico_PACIENTE"
        rep.Value = New List(Of WRAPPER_PACIENTE)
        rep.Value.Add(New WRAPPER_PACIENTE(lista(0)))

        ReportesManager.Imprime("Paciente.rdlc", {rep})

    End Sub

    Private Sub ActualizarFechaNac()
        Try

            Dim context As New CMLinqDataContext
            Dim pac As PACIENTE = context.PACIENTEs.SingleOrDefault(Function(o) o.CPACIENTE = fId)
            tb_Edad.Text = pac.Edad

            'Dim _fechaNac As Date = CMDataSet.PACIENTES.FindByCPACIENTE(fId).FECHAN
            'Dim _anno As Integer = _fechaNac.Year
            'If _fechaNac.Month > DateTime.Now.Month Then
            '    tb_Edad.Text = (DateTime.Now.Year - _anno - 1).ToString()
            'ElseIf _fechaNac.Month < DateTime.Now.Month Then
            '    tb_Edad.Text = (DateTime.Now.Year - _anno).ToString()
            'ElseIf _fechaNac.Day >= DateTime.Now.Day Then
            '    tb_Edad.Text = (DateTime.Now.Year - _anno).ToString()
            'Else
            '    tb_Edad.Text = (DateTime.Now.Year - _anno - 1).ToString()
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Dim res As MsgBoxResult
        If fCambios = True Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                fCerrando = True
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub form_pacientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Globales.FormPacienteKeys.Antecendentes
                Me.bt_Antecedentes_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.DatosPersonales
                Me.bt_DatosPersonales_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.ServiciosPeriodicos
                Me.bt_ServiciosPeriodicos_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.HistorialClinico
                Me.bt_HistorialClinico_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.Cita
                Me.bt_Cita_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.Derivacione
                Me.bt_Derivaciones_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.Recetas
                Me.bt_Recetas_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.Factura
                Me.bt_Factura_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.Analiticas
                Me.bt_Analiticas_Click(Nothing, Nothing)
            Case Globales.FormPacienteKeys.RevComparativa
                Me.bt_RevComparativa_Click(Nothing, Nothing)

        End Select

    End Sub
    Private Sub CargarAlarmas()
        Dim _rowsLineaAlarma() As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.Select("REFPACIENTE = " + fId.ToString())
        Dim maxNivelAlarma = 0 'Ninguno
        Dim k As Integer
        For k = 0 To _rowsLineaAlarma.Length - 1
            Dim _alarma As CMDataSet.ALARMASDataTable = ALARMASTableAdapter.GetAlarmaById(_rowsLineaAlarma(k).Item("REFALARMA"))
            Select Case _alarma.Rows(0).Item("NIVEL").ToString()
                Case "A"
                    maxNivelAlarma = 3
                Case "M"
                    If maxNivelAlarma <> 3 Then
                        maxNivelAlarma = 2
                    End If
                Case "B"
                    If maxNivelAlarma <> 2 And maxNivelAlarma <> 3 Then
                        maxNivelAlarma = 1
                    End If

            End Select
        Next

        Select Case maxNivelAlarma
            Case 3  ' Alta
                Me.lblAlarmas.BackColor = Color.FromArgb(255, 69, 0)
                Me.lblAlarmas.Text = "¡¡ATENCIÓN!!"
            Case 2
                Me.lblAlarmas.BackColor = Color.FromArgb(249, 247, 186)
                Me.lblAlarmas.Text = "¡PRECAUCIÓN!"
            Case 1
                Me.lblAlarmas.BackColor = Color.FromArgb(255, 174, 0)
                Me.lblAlarmas.Text = "CUIDADO"
            Case 0
                Me.lblAlarmas.BackColor = System.Drawing.Color.Transparent
                Me.lblAlarmas.Text = ""
        End Select
    End Sub

    Private Sub bt_Cita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cita.Click
        If frmCitas Is Nothing OrElse frmCitas.Visible = False Then
            frmCitas = New frmCalendarioCitas()
            frmCitas.IdPaciente = fId
            frmCitas.WindowState = FormWindowState.Maximized
            frmCitas.MdiParent = Me
            frmCitas.Show()
        End If
        frmCitas.Focus()
        'frmCitas.rb_ciImpagadas.Checked = True

    End Sub

    Private Sub bt_Factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Factura.Click
        If frmFacturas Is Nothing OrElse frmFacturas.Visible = False Then
            frmFacturas = New frmFacturasM()
            frmFacturas.IDPacienteToFilter = fId
            frmFacturas.MdiParent = Me
            frmFacturas.Show()
        End If
        frmFacturas.Focus()
        'frmFacturas.rb_faImpagadas.Checked = True

    End Sub



    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        'PACIENTESBindingSource.EndEdit()
        'PACIENTESTableAdapter.Update(CMDataSet.PACIENTES)
        'fCerrando = True
        'Me.Close()
    End Sub


    Private Sub formPaciente_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs Where p.CPACIENTE = fId Select p).SingleOrDefault
        'If Not paciente Is Nothing Then
        '    If paciente.NOMBRE Is Nothing Then
        '        MessageBox.Show("El paciente no puede tener nombre vacio")
        '        e.Cancel = True
        '        Return
        '    End If
        'End If

        Dim res As MsgBoxResult
        'If Not Me.frmAnaliticas Is Nothing Then frmAnaliticas.Close()
        'If Not Me.frmDatosPersonales Is Nothing Then frmDatosPersonales.Close()
        'If fCambios = True And fCerrando = False Then
        '    res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
        '    If res = MsgBoxResult.No Then
        '        e.Cancel = True
        '    End If

        'End If

        'Revisar cada una de las ventanas MDI, y si hay alguna abierta (Visible and not Disposed)

        Dim hayVentanasAbiertas As Boolean = False
        For Each childForm As Form In Me.MdiChildren
            If childForm.Visible And Not childForm.IsDisposed Then
                hayVentanasAbiertas = True
            End If
        Next
        If hayVentanasAbiertas Then
            res = MsgBox("Hay ventanas abiertas que pueden tener datos sin guardar. Le recomendamos que cierre una a una guardando los cambios realizados, si no podría perder información. ¿Desea continuar cerrando?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tb_Apellido1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Apellido1.TextChanged
        fCambios = True
    End Sub

    Private Sub tb_Apellido2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Apellido2.TextChanged
        fCambios = True
    End Sub

    Private Sub tb_Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Nombre.TextChanged
        fCambios = True
    End Sub

    Private Sub bt_Partes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_PartesBajaAlta.Click

        'Falta ponerle los permismos

        Dim frm As New frmPartes()
        frm.MdiParent = Me
        frm.CtrlPaciente1.ID_PACIENTE = fId
        frm.CtrlPaciente1.Enabled = False
        frm.Filtrar()
        frm.Show()
        'If frmPartes Is Nothing OrElse frmPartes.Visible = False Then
        '    frmPartes = New form_partes(fId)
        '    frmPartes.MdiParent = Me
        '    frmPartes.Show()
        'End If
        'frmPartes.Focus()
    End Sub

    Private Sub btn_PartesAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PartesAsistencia.Click
        Dim frm As New frmPartesAsistencia()
        frm.MdiParent = Me
        frm.CtrlPaciente1.ID_PACIENTE = fId
        frm.CtrlPaciente1.Enabled = False
        frm.Filtrar()
        frm.Show()
    End Sub

    Private Sub btnReportesPersonalizados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportesPersonalizados.Click
        Dim frm As New frmPaciente_ReportePersonalizados()
        frm.MdiParent = Me
        frm.idPaciente = fId
        frm.Show()
    End Sub


    Private Sub btnComunicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComunicaciones.Click
        Dim frm As New frmComunicaciones()
        frm.IDPACIENTE = fId
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub bt_informesMedicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_informesMedicos.Click
        
        If frmInfMedico Is Nothing OrElse frmInfMedico.Visible = False Then
            frmInfMedico = New frmInformeMedico(fId)
            frmInfMedico.WindowState = FormWindowState.Maximized
            frmInfMedico.IDPACIENTE = fId
            frmInfMedico.MdiParent = Me
            frmInfMedico.Show()
        End If
        frmInfMedico.Focus()
    End Sub

    Private Sub buttonProcesos_Click(sender As Object, e As EventArgs) Handles btProcesos.Click
        Dim frm As New frmProcesos
        frm.CtrlPaciente1.ID_PACIENTE = fId
        frm.CtrlPaciente1.Enabled = False
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btBonos_Click(sender As Object, e As EventArgs) Handles btBonos.Click

        Dim context As New CMLinqDataContext
        Dim paciente As PACIENTE = (From a As PACIENTE In context.PACIENTEs Where a.CPACIENTE = fId Select a).SingleOrDefault()

        If Not paciente Is Nothing Then
            Dim bonos As New Bonos_form(context, paciente, True)


            bonos.MdiParent = Me
            bonos.Show()
        End If
    End Sub
End Class