Imports Microsoft.Reporting.WinForms

Public Class form_pac_historial

    Dim fId As Integer = -1
    Dim fPacienteId As Integer
    Dim fcurrentAcc As Integer
    Dim fDesdePaciente As Boolean

    Dim fMovitoConsulta As String
    Dim fAntecedentes As String
    Dim fHistorial As String
    Dim fExploracion As String
    Dim fPruebasComplementarias As String
    Dim fHipotesisDiagnostica As String
    Dim fTratamiento As String
    Dim fOtrasObservaciones As String
    Dim fNotasFinales As String

    Dim fMedicoId As Integer = -1
    Dim fDiagnosticoId As Integer = -1

    Dim fVengoDeAceptar As Boolean = False

    'Dim CMDataset As CMDataSet



    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId
        Me.fPacienteId = aPacienteId
        'Me.fDesdePaciente = True

        Dim fMedicoId As Integer = -1



        Dim fDiagnosticoId As Integer = -1


        CMDataSet = aCMDataSet


        Dim context As New CMLinqDataContext
        Dim hist As HISTORIALE = (From h In context.HISTORIALEs Where h.CHISTORIAL = aId Select h).SingleOrDefault()
        If Not hist Is Nothing Then
            If hist.ParentHistorial.HasValue Then
                lblTipo.Text = "EPISODIO"
                lblTipo.ForeColor = Color.Red
            Else
                lblTipo.Text = "HISTORIAL"
                lblTipo.ForeColor = Color.Green

            End If

        End If

    End Sub

    Public Property CurrentAccion() As Enums.Accion

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fcurrentAcc

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Enums.Accion)
            fcurrentAcc = Value
        End Set
    End Property

    Public Property MovitoConsulta() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fMovitoConsulta

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fMovitoConsulta = Value
        End Set
    End Property


    Public Property Antecedentes() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fAntecedentes

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fAntecedentes = Value
        End Set
    End Property


    Public Property Historial() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fHistorial

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fHistorial = Value
        End Set
    End Property


    Public Property Exploracion() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fExploracion

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fExploracion = Value
        End Set
    End Property


    Public Property PruebasComplementarias() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fPruebasComplementarias

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fPruebasComplementarias = Value
        End Set
    End Property


    Public Property HipotesisDiagnostica() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fHipotesisDiagnostica

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fHipotesisDiagnostica = Value
        End Set
    End Property


    Public Property oTratamiento() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fTratamiento

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fTratamiento = Value
        End Set
    End Property


    Public Property OtrasObservaciones() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fOtrasObservaciones

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fOtrasObservaciones = Value
        End Set
    End Property


    Public Property NotasFinales() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fNotasFinales

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fNotasFinales = Value
        End Set
    End Property

    Private Sub form_pac_historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.LINEASALARMA' table. You can move, or remove it, as needed.
        '        Me.LINEASALARMATableAdapter.Fill(Me.CMDataSet.LINEASALARMA)




        If Globales.Configuracion.solapashistoriales = True Then
            TabControl1.Visible = True
            pn_FormaTextbox.Visible = False

            tab_Motivo.Text = Globales.Configuracion.histcampo1
            tab_Antecedentes.Text = Globales.Configuracion.histcampo2
            tab_Historial.Text = Globales.Configuracion.histcampo3
            tab_Exploracion.Text = Globales.Configuracion.histcampo4
            tab_PruebasComp.Text = Globales.Configuracion.histcampo5
            tab_HipDiagnostica.Text = Globales.Configuracion.histcampo6
            tab_Tratamiento.Text = Globales.Configuracion.histcampo7
            tab_OtrasObservaciones.Text = Globales.Configuracion.histcampo8
            tab_NotasFinales.Text = Globales.Configuracion.histcampo9

        Else
            TabControl1.Visible = False
            pn_FormaTextbox.Visible = True

            lb_motivoconsultas.Text = Globales.Configuracion.histcampo1
            lb_antecedentes.Text = Globales.Configuracion.histcampo2
            lb_historial.Text = Globales.Configuracion.histcampo3
            lb_exploracion.Text = Globales.Configuracion.histcampo4
            lb_pruebascomplementarias.Text = Globales.Configuracion.histcampo5
            lb_hipotesisdiagnostica.Text = Globales.Configuracion.histcampo6
            lb_tratamiento.Text = Globales.Configuracion.histcampo7
            lb_otrasobservaciones.Text = Globales.Configuracion.histcampo8
            lb_notasfinales.Text = Globales.Configuracion.histcampo9

        End If
        ' Dim a As Object = Globals.Usuario

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
            If Me.tb_Idmedico.Text.Trim.Length > 0 Then
                Me.tb_Nombremedico.Text = GetMedico(tb_Idmedico.Text.Trim)

            End If
        Else
            tb_Paciente.Text = GetPaciente(fPacienteId)

            If Globales.Usuario.REFMEDICO.HasValue Then
                fMedicoId = Globales.Usuario.REFMEDICO
                Me.tb_Idmedico.Text = fMedicoId
                Me.tb_Nombremedico.Text = Me.GetMedico(fMedicoId)
            End If

            Dim _horacorta As String = DateTime.Now.ToShortTimeString()
            tb_Hora.Text = _horacorta
            Me.CMDataSet.HistorialesDiagnosticos.DefaultView.RowFilter = "CHistorial = " & fId
            Me.dtg_Diagnosticos.DataSource = CMDataSet.HistorialesDiagnosticos


        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
            If dtp_Fecha.Value.Date <> Now.Date Then
                Me.bt_HtAceptar.Enabled = False
                Me.bt_HtRecetas.Enabled = False
                'Me.bt_BuscarDiagnosticoPrincipal.Enabled = False
                Me.CtrlDiagnosticos1.Enabled = False
                Me.bt_Buscarmedico.Enabled = False
                Me.bt_HtAplicarplantilla.Enabled = False
            End If
        End If
        Me.CargarHistoriales()
        Me.CargarInformaciónPrimaria()
        Me.CargarAlarmas()
        Me.CargaAntecedentesDiagnosticos()
        Me.CargaRecetas()
        'Me.dgvAntecedentes.DataSource = CMDataset.INFORMACIONPRIMARIA

        Me.edit_Antecedentes.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_Exploracion.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_HipDiagnostica.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_Historial.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_Motivo.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_NotasFinales.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_OtrasObservaciones.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_PruebasComp.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)
        Me.edit_Tratamiento.rtb_texto.SelectionFont = New Font("Microsoft Sans Serif", Globales.Configuracion.TamanoFuente)

    End Sub

    Private Function GetPaciente(ByVal aId As Integer) As String

        'Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)

        Dim _data As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable()
        _data.ImportRow(CMDataSet.PACIENTES.FindByCPACIENTE(aId))
        If _data.Rows.Count > 0 Then
            Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
            Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
            Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
            Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
            Return _paciente
        Else
            Return ""
        End If
    End Function

    Private Function GetMedico(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MEDICOSDataTable = Me.MEDICOSTableAdapter.GetMedicoByID(aId)
        If _data.Rows.Count > 0 Then
            Dim _medname As String = _data.Rows(0).Item("NOMBRE").ToString()
            Dim _medapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
            Dim _medapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
            Dim _med As String = _medapellido1 + " " + _medapellido2 + " , " + _medname

            Return _med
        Else
            Return ""
        End If

    End Function


    Private Sub Inicializa()

        'Dim _data As CMDataSet.HISTORIALESDataTable = Me.HISTORIALESTableAdapter.GetHistorialById(fId)

        Dim _data As CMDataSet.HISTORIALESDataTable = New CMDataSet.HISTORIALESDataTable()
        _data.ImportRow(CMDataSet.HISTORIALES.FindByCHISTORIAL(fId))

        If Globales.Configuracion.solapashistoriales = True Then

            edit_Motivo.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("MOTIVO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_Antecedentes.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("ANTECEDENTES").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_OtrasObservaciones.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("OTROS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_NotasFinales.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("COMENTARIOS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_Tratamiento.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("TRATAMIENTO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_Historial.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("HISTORIAL").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_PruebasComp.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("COMPLEMENTARIAS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_Exploracion.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("EXPLORACION").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            edit_HipDiagnostica.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("JUICIO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            
            'edit_HipDiagnostica.ControlText = _data.Rows(0).Item("JUICIO")

            'edit_HipDiagnostica.rtb_texto.
            'edit_HipDiagnostica.rtb_texto.SelectionStart = 0
            'edit_HipDiagnostica.rtb_texto.SelectionLength = edit_HipDiagnostica.ControlText.Length
            'edit_HipDiagnostica.rtb_texto.ZoomFactor = 2
            'edit_HipDiagnostica.rtb_texto.SelectionFont = New Font(edit_HipDiagnostica.rtb_texto.Font.FontFamily, Globales.Configuracion.TamanoFuente * 2)

        Else
            tb_motivoconsultas.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("MOTIVO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_antecedentes.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("ANTECEDENTES").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_otrasobservaciones.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("OTROS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_notasfinales.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("COMENTARIOS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_tratamiento.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("TRATAMIENTO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_historial.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("HISTORIAL").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_pruebascomplementarias.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("COMPLEMENTARIAS").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_exploracion.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("EXPLORACION").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"
            tb_hipotesisdiagnostica.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & _data.Rows(0).Item("JUICIO").ToString() & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"

        End If

        If Not Integer.TryParse(_data.Rows(0).Item("REFDIAGNOSTICO").ToString(), fDiagnosticoId) Then
            fDiagnosticoId = -1
        End If
        If fDiagnosticoId = -1 Then
            CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
            'tb_DiagnosticoPrincipal.Text = ""
        Else
            Dim _dataDiag As CMDataSet.DIAGNOSTICOSDataTable = Me.DIAGNOSTICOSTableAdapter.GetDiagnosticoById(_data.Rows(0).Item("REFDIAGNOSTICO"))
            CtrlDiagnosticos1.ID_DIAGNOSTICOS = fDiagnosticoId
            If _dataDiag.Rows.Count > 0 Then
                CtrlDiagnosticos1.ID_DIAGNOSTICOS = fDiagnosticoId
                'tb_DiagnosticoPrincipal.Text = _dataDiag.Rows(0).Item("DIAGNOSTICO").ToString()
            End If
            'tb_DiagnosticoPrincipal.Text = _dataDiag.Rows(0).Item("DIAGNOSTICO").ToString()
        End If

        If _data.Rows(0).Item("REFPACIENTE").GetType().ToString <> DBNull.Value.GetType().ToString() Then
            tb_Paciente.Text = GetPaciente(_data.Rows(0).Item("REFPACIENTE"))
        End If

        If _data.Rows(0).Item("REFMEDICO").GetType().ToString <> DBNull.Value.GetType().ToString() Then
            fMedicoId = _data.Rows(0).Item("REFMEDICO")
            tb_Idmedico.Text = _data.Rows(0).Item("REFMEDICO").ToString()
            tb_Nombremedico.Text = GetMedico(_data.Rows(0).Item("REFMEDICO"))
        End If

        If _data.Rows(0).Item("FECHA").GetType().ToString <> DBNull.Value.GetType().ToString() Then
            dtp_Fecha.Value = _data.Rows(0).Item("FECHA")
        Else
            dtp_Fecha.Value = DateTime.Now
        End If

        If _data.Rows(0).Item("FECHA").GetType().ToString <> DBNull.Value.GetType().ToString() Then
            Dim _temp As DateTime = _data.Rows(0).Item("HORA")
            tb_Hora.Text = _temp.ToShortTimeString()
        End If

        'Cargo los diagnosticos asociados ademas del principal
        Me.CMDataSet.HistorialesDiagnosticos.DefaultView.RowFilter = "CHistorial = " & fId
        Me.dtg_Diagnosticos.DataSource = CMDataSet.HistorialesDiagnosticos


        AplicaPermisos()
    End Sub

    Private Sub AplicaPermisos()

        Dim editable As Boolean = Globales.PuedeModificarseHistorial(dtp_Fecha.Value)

        tsbGuardar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        tsbCancelar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_HtAceptar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_HtCancelar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_HtAplicarplantilla.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_HtRecetas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        btAddAntecedentes.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_DelAntecedente.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        'TabControl1.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        'dgvHistoriales.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_AddAlarma.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        bt_DelAlarma.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable

        edit_Motivo.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_Antecedentes.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_Exploracion.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_HipDiagnostica.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_Historial.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_Motivo.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_NotasFinales.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_OtrasObservaciones.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_PruebasComp.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)
        edit_Tratamiento.ReadOnly = Not ((Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable)

        btAddDiagnostico.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        btEditDiagnostico.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        btDelDiagnostico.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        gb_DatosHistorial.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        CtrlDiagnosticos1.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable
        btn_AnnadirAntecentes.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable


        'gb_DatosHistorial.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Pacientes_Historiales_Actuales) > 2) And editable

    End Sub


    Private Sub bt_Buscarmedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Buscarmedico.Click
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, MEDICOSBindingSource, RoleManager.Items.Medicos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If Not _listados.Selected() = "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            fMedicoId = _pcodo
            tb_Idmedico.Text = _pcodo.ToString()
            tb_Nombremedico.Text = GetMedico(_pcodo)
        End If
    End Sub





    Private Sub bt_HtAplicarplantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HtAplicarplantilla.Click
        Me.PLANTILLA_HISTORIALESTableAdapter.Fill(Me.CMDataSet.PLANTILLA_HISTORIALES)
        Dim _name As String = "Listado de Plantillas de Historiales"
        Dim _listados As form_listados = New form_listados(_name, PLANTILLA_HISTORIALESBindingSource, RoleManager.Items.Plantilla_de_Historial, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            '/////////////////////////////////////////
            Dim _pcodo As String = _listados.Selected()
            '-->/////////////////////////////////////////
            Dim _dataPlanHisto As CMDataSet.PLANTILLA_HISTORIALESDataTable = Me.PLANTILLA_HISTORIALESTableAdapter.GetPlantillaById(_pcodo)


            If Globales.Configuracion.solapashistoriales = True Then

                edit_Motivo.ControlText = _dataPlanHisto.Rows(0).Item("MOTIVO").ToString()
                edit_Antecedentes.ControlText = _dataPlanHisto.Rows(0).Item("ANTECEDENTES").ToString()
                edit_OtrasObservaciones.ControlText = _dataPlanHisto.Rows(0).Item("OTROS").ToString()
                edit_NotasFinales.ControlText = _dataPlanHisto.Rows(0).Item("COMENTARIOS").ToString()
                edit_Tratamiento.ControlText = _dataPlanHisto.Rows(0).Item("TRATAMIENTO").ToString()
                edit_Historial.ControlText = _dataPlanHisto.Rows(0).Item("HISTORIAL").ToString()
                edit_PruebasComp.ControlText = _dataPlanHisto.Rows(0).Item("COMPLEMENTARIAS").ToString()
                edit_Exploracion.ControlText = _dataPlanHisto.Rows(0).Item("EXPLORACION").ToString()
                edit_HipDiagnostica.ControlText = _dataPlanHisto.Rows(0).Item("JUICIO").ToString()

            Else
                tb_motivoconsultas.Rtf = _dataPlanHisto.Rows(0).Item("MOTIVO").ToString()
                tb_antecedentes.Rtf = _dataPlanHisto.Rows(0).Item("ANTECEDENTES").ToString()
                tb_otrasobservaciones.Rtf = _dataPlanHisto.Rows(0).Item("OTROS").ToString()
                tb_notasfinales.Rtf = _dataPlanHisto.Rows(0).Item("COMENTARIOS").ToString()
                tb_tratamiento.Rtf = _dataPlanHisto.Rows(0).Item("TRATAMIENTO").ToString()
                tb_historial.Rtf = _dataPlanHisto.Rows(0).Item("HISTORIAL").ToString()
                tb_pruebascomplementarias.Rtf = _dataPlanHisto.Rows(0).Item("COMPLEMENTARIAS").ToString()
                tb_exploracion.Rtf = _dataPlanHisto.Rows(0).Item("EXPLORACION").ToString()
                tb_hipotesisdiagnostica.Rtf = _dataPlanHisto.Rows(0).Item("JUICIO").ToString()
            End If

            'edit_Motivo.ControlText = _dataPlanHisto.Rows(0).Item("MOTIVO").ToString()
            'edit_Antecedentes.ControlText = _dataPlanHisto.Rows(0).Item("ANTECEDENTES").ToString()
            'edit_OtrasObservaciones.ControlText = _dataPlanHisto.Rows(0).Item("OTROS").ToString()
            'edit_NotasFinales.ControlText = _dataPlanHisto.Rows(0).Item("COMENTARIOS").ToString()
            'edit_Tratamiento.ControlText = _dataPlanHisto.Rows(0).Item("TRATAMIENTO")
            'edit_Historial.ControlText = _dataPlanHisto.Rows(0).Item("HISTORIAL").ToString()
            'edit_PruebasComp.ControlText = _dataPlanHisto.Rows(0).Item("COMPLEMENTARIAS").ToString()
            'edit_Exploracion.ControlText = _dataPlanHisto.Rows(0).Item("EXPLORACION")
            'edit_HipDiagnostica.ControlText = _dataPlanHisto.Rows(0).Item("JUICIO").ToString()
        End If
    End Sub

    Private Sub bt_HtMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.MEDICAMENTOSTableAdapter.Fill(Me.CMDataSet.MEDICAMENTOS)
        Dim _name As String = "Listado de Medicamentos"
        Dim _listados As form_listados = New form_listados(_name, MEDICAMENTOSBindingSource, RoleManager.Items.Medicamentos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If Not _listados.Selected() = "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            Dim _dataMed As CMDataSet.MEDICAMENTOSDataTable = Me.MEDICAMENTOSTableAdapter.GetMedicamentoById(_pcodo)
            'edit_Tratamiento.ControlText = edit_Tratamiento.ControlText + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine + _dataMed.Rows(0).Item("DESCRIPCION").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine

            If Globales.Configuracion.solapashistoriales = True Then
                'edit_Tratamiento.ControlText = edit_Tratamiento.ControlText + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine + _dataMed.Rows(0).Item("DESCRIPCION").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine
                Dim _texto As String = Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine + _dataMed.Rows(0).Item("DESCRIPCION").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine

                edit_Tratamiento.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & " " & edit_Tratamiento.ControlText & _texto & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"

                TabControl1.SelectedTab = tab_Tratamiento
            Else
                Dim _texto As String = Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine + _dataMed.Rows(0).Item("DESCRIPCION").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + Microsoft.VisualBasic.ControlChars.NewLine

                tb_tratamiento.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & " " & tb_tratamiento.Rtf & _texto & "\viewkind4\uc1\pard\f0\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & "\par}"

            End If

        End If
    End Sub

    Private Sub bt_HtRecetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HtRecetas.Click
        Dim idRecetaNueva As Integer
        Dim _tratamiento As String
        If Globales.Configuracion.solapashistoriales Then
            _tratamiento = edit_Tratamiento.rtb_texto.Text
        Else
            _tratamiento = tb_tratamiento.Text
        End If

        'Renier, Creare una nueva fecha en que la hora no importe
        Dim now As Date = dtp_Fecha.Value

        If Me.fMedicoId = -1 Then
            Me.RECETASTableAdapter.Insert(now, Me.fPacienteId, "", Nothing, Nothing, Nothing, now)
            'Me.RECETASTableAdapter.Insert(Date.Now, Me.fPacienteId, "", Nothing, Nothing, Nothing, Now)
        Else
            'Me.RECETASTableAdapter.Insert(dtp_Fecha.Value, Me.fPacienteId, "", Me.fMedicoId, Nothing, Nothing, Now)
            Me.RECETASTableAdapter.Insert(now, Me.fPacienteId, "", Me.fMedicoId, Nothing, Nothing, now)

        End If

        idRecetaNueva = Me.RECETASTableAdapter.MaximoId
        Dim _recetas As form_receta_ex = New form_receta_ex("Ficha de Receta - Añadir", Enums.Accion.Modificar, idRecetaNueva, fPacienteId)
        If tb_Idmedico.Text <> "" Then
            _recetas.tb_medico.Text = tb_Idmedico.Text
            _recetas.lb_medico.Text = tb_Nombremedico.Text
            '_recetas.bt_medico.Enabled = False
        End If
        If CtrlDiagnosticos1.ID_DIAGNOSTICOS.HasValue Then
            _recetas.tb_diagnostico.Text = CtrlDiagnosticos1.ID_DIAGNOSTICOS.Value.ToString()
            _recetas.lb_diagnostico.Text = CtrlDiagnosticos1.NombreCompleto
            '_recetas.bt_diagnostico.Enabled = False
        End If

        _recetas.VengoDeHistorialActual = True
        _recetas.ShowInTaskbar = False
        _recetas.ShowDialog()

        If _recetas.tb_diagnostico.Text <> "" Then
            fDiagnosticoId = Integer.Parse(_recetas.tb_diagnostico.Text)
            CtrlDiagnosticos1.ID_DIAGNOSTICOS = fDiagnosticoId
            'tb_DiagnosticoPrincipal.Text = _recetas.lb_diagnostico.Text
        End If

        ' MsgBox(edit_Tratamiento.rtb_texto.Rtf)

        'Se pasa a Tratamiento del historial lo recetado al paciente:
        If _recetas.tb_tratamiento.Text.Trim.Length > 0 Then
            edit_Tratamiento.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\fs" & CInt(Globales.Configuracion.TamanoFuente * 2) & " " & edit_Tratamiento.Text & _recetas.tb_tratamiento.Text & "\viewkind4\uc1\pard\f0\par}"
        End If
        Me.tab_Tratamiento.Focus()
        Me.CargaRecetas()
        '  MsgBox(edit_Tratamiento.rtb_texto.Rtf)
    End Sub

    Private Function Guardar() As Boolean
        fVengoDeAceptar = True
        If fDiagnosticoId.ToString.Trim.Length = 0 Then
            MessageBox.Show("Debe indicar el diagnostico principal. ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If fMedicoId = -1 Then
            MessageBox.Show("El Médico debe ser seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim _rpaciente As Integer = fPacienteId
        Dim _rmedico As Integer = fMedicoId
        Dim _rdiagnostico As Integer = fDiagnosticoId
        Dim _fecha As DateTime = dtp_Fecha.Value
        Dim _ref As DateTime

        If DateTime.TryParse(tb_Hora.Text, _ref) = False Then
            MessageBox.Show("Formato de la Hora Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        Me.Antecedentes_BindingSource1.EndEdit()
        If CMDataSet.AntecedentesDiagnosticos.Count > 0 Then
            For Each an As CMDataSet.AntecedentesDiagnosticosRow In CMDataSet.AntecedentesDiagnosticos
                If an.IsNull("OBSERVACIONES") Then
                    an.OBSERVACIONES = ""
                End If
            Next
        End If
        Me.AntecedentesDiagnosticosTableAdapter.Update(CMDataSet.AntecedentesDiagnosticos)
        Me.INFORMACIONPRIMARIATableAdapter.Update(CMDataSet.INFORMACIONPRIMARIA)
        Me.CMDataSet.INFORMACIONPRIMARIA.AcceptChanges()

        Dim _hora As DateTime = DateTime.Parse(tb_Hora.Text)

        Dim _motivo As String
        Dim _antecedentes As String
        Dim _otros As String
        Dim _comentarios As String
        Dim _tratamiento As String
        Dim _historial As String
        Dim _complementarias As String
        Dim _exploracion As String
        Dim _juicio As String

        If Globales.Configuracion.solapashistoriales = True Then
            _motivo = edit_Motivo.ControlText
            _antecedentes = edit_Antecedentes.ControlText
            _otros = edit_OtrasObservaciones.ControlText
            _comentarios = edit_NotasFinales.ControlText
            _tratamiento = edit_Tratamiento.ControlText
            _historial = edit_Historial.ControlText
            _complementarias = edit_PruebasComp.ControlText
            _exploracion = edit_Exploracion.ControlText
            _juicio = edit_HipDiagnostica.ControlText
        Else
            _motivo = tb_motivoconsultas.Rtf
            _antecedentes = tb_antecedentes.Rtf
            _otros = tb_otrasobservaciones.Rtf
            _comentarios = tb_notasfinales.Rtf
            _tratamiento = tb_tratamiento.Rtf
            _historial = tb_historial.Rtf
            _complementarias = tb_pruebascomplementarias.Rtf
            _exploracion = tb_exploracion.Rtf
            _juicio = tb_hipotesisdiagnostica.Rtf
        End If

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            'HISTORIALESTableAdapter.UpdateValores(_rpaciente, _rmedico, _fecha, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _hora, _rdiagnostico, fId)

            Dim _updRow As CMDataSet.HISTORIALESRow = CMDataSet.HISTORIALES.FindByCHISTORIAL(fId)

            _updRow.REFPACIENTE() = _rpaciente
            _updRow.REFMEDICO() = _rmedico
            _updRow.FECHA() = _fecha
            _updRow.MOTIVO() = _motivo
            _updRow.ANTECEDENTES() = _antecedentes
            _updRow.EXPLORACION() = _exploracion
            _updRow.COMPLEMENTARIAS() = _complementarias
            _updRow.JUICIO() = _juicio
            _updRow.TRATAMIENTO() = _tratamiento
            _updRow.HISTORIAL() = _historial
            _updRow.COMENTARIOS() = _comentarios
            _updRow.OTROS() = _otros
            _updRow.HORA() = _hora
            _updRow.REFDIAGNOSTICO() = _rdiagnostico
            Me.HISTORIALESBindingSource.EndEdit()
            Me.HISTORIALESTableAdapter.Update(CMDataSet.HISTORIALES)

        Else
            'HISTORIALESTableAdapter.InsertValores(_rpaciente, _rmedico, _fecha, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _hora, _rdiagnostico)

            Dim _newRow As CMDataSet.HISTORIALESRow = CMDataSet.HISTORIALES.NewHISTORIALESRow()
            Dim _rows() As CMDataSet.HISTORIALESRow = CMDataSet.HISTORIALES.Select("", "CHISTORIAL ASC")

            Dim _maxBD As Integer = 1
            If HISTORIALESTableAdapter.MaximoId.HasValue Then
                If Integer.TryParse(HISTORIALESTableAdapter.MaximoId(), _maxBD) Then
                    _maxBD = _maxBD + 1
                End If
            End If

            Dim _maxDS As Integer = 1

            If _rows.Length > 0 Then
                _maxDS = _rows(_rows.Length - 1).CHISTORIAL() + 1
            End If

            _newRow.CHISTORIAL() = Math.Max(_maxDS, _maxBD)

            _newRow.REFPACIENTE() = _rpaciente
            _newRow.REFMEDICO() = _rmedico
            _newRow.FECHA() = _fecha
            _newRow.MOTIVO() = _motivo
            _newRow.ANTECEDENTES() = _antecedentes
            _newRow.EXPLORACION() = _exploracion
            _newRow.COMPLEMENTARIAS() = _complementarias
            _newRow.JUICIO() = _juicio
            _newRow.TRATAMIENTO() = _tratamiento
            _newRow.HISTORIAL() = _historial
            _newRow.COMENTARIOS() = _comentarios
            _newRow.OTROS() = _otros
            _newRow.HORA() = _hora
            _newRow.REFDIAGNOSTICO() = _rdiagnostico

            CMDataSet.HISTORIALES.AddHISTORIALESRow(_newRow)
            Me.HISTORIALESBindingSource.EndEdit()
            Me.HISTORIALESTableAdapter.Update(CMDataSet.HISTORIALES)

            'Actualizo los diagnosticos adicionales con el codigo del nuevo historial
            Dim i As Integer
            For i = 0 To CMDataSet.HistorialesDiagnosticos.Rows.Count - 1
                With CMDataSet.HistorialesDiagnosticos.Rows
                    If .Item(i).Item("CHISTORIAL") = -1 Then .Item(i).Item("CHISTORIAL") = _newRow.CHISTORIAL
                End With
            Next
            fId = _newRow.CHISTORIAL
        End If
        'Guardo los diagnosticos adicionales.
        Me.HistorialDiagnosticosBindingSource.EndEdit()
        Me.HistorialesDiagnosticosTableAdapter.Update(CMDataSet.HistorialesDiagnosticos)
        Return True
    End Function

    Private Sub bt_HtAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HtAceptar.Click, tsbGuardar.Click


        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Close()
        End If

    End Sub

    Private Sub bt_HtCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HtCancelar.Click, tsbCancelar.Click
        Close()
    End Sub

    Private Sub bt_HtImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_HtImprimir.Click, tlbImprimir.Click
        If Guardar() Then
            'Dim rptHistorial As New form_mostrar_reporte_historial(Me.fPacienteId, Me.fId, Me.CMDataSet, edit_Antecedentes.rtb_texto.Text.Trim())
            'rptHistorial.ShowDialog()

            'Datasources

            Dim cont As New CMLinqDataContext()

            Dim dsPaciente As New ReportDataSource()
            Dim pac As PACIENTE = (From p In cont.PACIENTEs
                                  Where p.CPACIENTE = fPacienteId
                                  Select p).SingleOrDefault
            Dim paclist As New List(Of PACIENTE)
            paclist.Add(pac)
            dsPaciente.Name = "CMDataSet_PACIENTES"
            dsPaciente.Value = paclist


            Dim dsHistorial As New ReportDataSource()
            Dim historia As HISTORIALE = (From h In cont.HISTORIALEs
                                          Where h.CHISTORIAL = fId
                                          Select h).SingleOrDefault()

            historia.ANTECEDENTES = TextFromRtf(historia.ANTECEDENTES)
            If historia.ANTECEDENTES.Length > 0 Then
                If historia.ANTECEDENTES.Trim().Length > 0 Then
                    historia.ANTECEDENTES = historia.ANTECEDENTES.Trim() + vbCrLf
                End If

            End If

            'Annadir todos los antecedentes
            For Each an As AntecedentesDiagnostico In historia.PACIENTE.AntecedentesDiagnosticos
                historia.ANTECEDENTES += an.DIAGNOSTICO + ". " + an.OBSERVACIONES + vbCrLf
            Next


            historia.COMENTARIOS = TextFromRtf(historia.COMENTARIOS)
            historia.COMPLEMENTARIAS = TextFromRtf(historia.COMPLEMENTARIAS)
            historia.EXPLORACION = TextFromRtf(historia.EXPLORACION)
            historia.HISTORIAL = TextFromRtf(historia.HISTORIAL)
            historia.JUICIO = TextFromRtf(historia.JUICIO)
            historia.MOTIVO = TextFromRtf(historia.MOTIVO)
            historia.TRATAMIENTO = TextFromRtf(historia.TRATAMIENTO)
            historia.OTROS = TextFromRtf(historia.OTROS)


            Dim histList As New List(Of HISTORIALE)
            histList.Add(historia)

            dsHistorial.Name = "CMDataSet_HISTORIALES"
            dsHistorial.Value = histList



            Dim dsLineasDiagnostico As New ReportDataSource()
            dsLineasDiagnostico.Name = "dsLineasDiagnostico"
            dsLineasDiagnostico.Value = historia.HistorialesDiagnosticos.ToList()



            Dim _print As New frmReportViewer_2010()


            _print.ReportViewer1.LocalReport.ReportPath = Globales.Configuracion.impresionfilesdirectory & "\" & Globales.Configuracion.histficheroimpresion

            _print.ReportViewer1.LocalReport.EnableExternalImages = True

            _print.ReportViewer1.LocalReport.DataSources.Add(dsHistorial)

            _print.ReportViewer1.LocalReport.DataSources.Add(dsPaciente)
            _print.ReportViewer1.LocalReport.DataSources.Add(dsLineasDiagnostico)

            Dim rpt_parameters As Microsoft.Reporting.WinForms.ReportParameterInfoCollection = _print.ReportViewer1.LocalReport.GetParameters
            Dim rayParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

            If Not rpt_parameters.Item("param_DNI") Is Nothing Then
                If Not pac.DNI Is Nothing Then
                    rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", pac.DNI.ToString() & Globales.GetLetter(pac.DNI.ToString())))
                Else
                    rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", ""))
                End If
            End If

            If Not rpt_parameters.Item("param_PASAPORTE") Is Nothing Then
                If Not pac.PASAPORTE Is Nothing Then
                    rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", pac.PASAPORTE.ToString()))
                Else
                    rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", ""))
                End If
            End If

            If Not rpt_parameters.Item("param_AntecedentesText") Is Nothing Then
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_AntecedentesText", edit_Antecedentes.rtb_texto.Text.Trim()))
            End If

            If historia.REFMEDICO > 0 Then
                Dim medico As MEDICO = (From p In Globales.Context.MEDICOs
                                       Where p.CMEDICO = historia.REFMEDICO
                                       Select p).SingleOrDefault()

                If Not medico Is Nothing Then
                    If Not medico.FIRMA Is Nothing Then


                        If Not _print.ReportViewer1.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
                            Dim myImage As Byte() = medico.FIRMA.ToArray

                            Dim imgMemoryStream As New IO.MemoryStream(myImage)
                            Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)


                            Dim paramLogo As ReportParameter = New ReportParameter()
                            paramLogo.Name = "FirmaMedicoPath"
                            'paramLogo.Values.Add(@"file:///C:\Users\Mike\AppData\Local\Temp\Logo.png")
                            'Salvar la imagen en una direccion temporal

                            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\temp.jpg"

                            bitmap.Save(filename)


                            paramLogo.Values.Add("file:///" & filename)
                            'Me.ReportViewer.LocalReport.SetParameters(paramLogo)
                            If Not rayParam Is Nothing Then rayParam.Add(paramLogo)
                        End If

                    End If

                    ' wh = New WRAPPER_HISTORIAL(historia)

                    'dsWrapper.Name = "DS_WRAPPERHISTORIAL"
                    'Dim list As New List(Of Object)
                    'list.Add(wh)
                    'dsWrapper.Value = list

                End If
            End If



            _print.ReportViewer1.LocalReport.SetParameters(rayParam)

            _print.ShowDialog()

            cont.Dispose()

        End If
    End Sub

    Private Sub form_pac_historial_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If tsbGuardar.Enabled Then
            If fVengoDeAceptar = False Then
                If MessageBox.Show("Desea cancelar los cambios realizados", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub tb_Idmedico_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Idmedico.Leave
        Dim dtable As CMDataSet.MEDICOSDataTable
        Dim nombremedico As String = ""
        'Try
        If tb_Idmedico.Text.Length > 0 And IsNumeric(tb_Idmedico.Text) Then
            dtable = Me.MEDICOSTableAdapter.GetMedicoByID(CInt(tb_Idmedico.Text.Trim))
            If dtable.Rows.Count > 0 Then
                If Not dtable.Rows(0).Item("NOMBRE").GetType Is GetType(DBNull) Then
                    nombremedico = dtable.Rows(0).Item("NOMBRE")
                End If
                If Not dtable.Rows(0).Item("APELLIDO1").GetType Is GetType(DBNull) Then
                    nombremedico += " " & dtable.Rows(0).Item("APELLIDO1")
                End If
                If Not dtable.Rows(0).Item("APELLIDO2").GetType Is GetType(DBNull) Then
                    nombremedico += " " & dtable.Rows(0).Item("APELLIDO2")
                End If

                Me.tb_Nombremedico.Text = nombremedico.Trim
                fMedicoId = Me.tb_Idmedico.Text
            Else
                MsgBox("El medico seleccionado no es valido", MsgBoxStyle.Exclamation)
                fMedicoId = -1
            End If
        End If
        'Catch ex As Exception
        'End 'Try
    End Sub

    Private Sub CargarInformaciónPrimaria()
        Me.INFORMACIONPRIMARIATableAdapter.FillByPaciente(Me.CMDataSet.INFORMACIONPRIMARIA, Me.fPacienteId)
        Me.dgvAntecedentes.DataSource = Me.CMDataSet.INFORMACIONPRIMARIA

    End Sub
    Private Sub CargarHistoriales()
        Try
            'Me.HISTORIALESTableAdapter.FillByPaciente(Me.CMDataSet.HISTORIALES, Me.fPacienteId)
            'Me.dgvHistoriales.DataSource = CMDataSet.HISTORIALES
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CargarAlarmas()
        '        Me.ALARMASTableAdapter.FillAlarmaByPaciente(Me.CMDataSet.ALARMAS, Me.fPacienteId)
        Me.LINEASALARMATableAdapter.FillByPaciente(Me.CMDataSet.LINEASALARMA, Me.fPacienteId)
        Me.dgvAlarmas.DataSource = CMDataSet.LINEASALARMA
    End Sub
    Private Sub CargaAntecedentesDiagnosticos()
        Dim data As New CMDataSet.AntecedentesDiagnosticosDataTable
        Dim i As Integer = 0
        'If Me.fDesdePaciente Then
        '    Me.AntecedentesDiagnosticoBindingSource1.DataSource = Me.CMDataset.AntecedentesDiagnosticos
        '    Me.dgv_AntecedentesDiagnosticos.DataSource = Me.AntecedentesDiagnosticoBindingSource1
        'Else
        Me.AntecedentesDiagnosticosTableAdapter.FillByCPACIENTE(Me.CMDataSet.AntecedentesDiagnosticos, fPacienteId)
        Me.dgv_AntecedentesDiagnosticos.DataSource = Me.CMDataSet.AntecedentesDiagnosticos
        ' End If
    End Sub
    Private Sub ConsultarHistorial(ByVal CodigoHistorial As Integer)
        Dim frmVisorHistorial As New formVisorHistorial(CodigoHistorial)
        frmVisorHistorial.ShowDialog()
    End Sub
    Private Sub CargaRecetas()
        'Cargaremos las recetas emitidas el mismo dia que la fecha de creación del historial.
        'debemos recordar que si se cambia la fecha del historial, tambien deben cambiar las fechas de las recetas.
        Me.RECETASTableAdapter.FillByPacienteYFecha(CMDataSet.RECETAS, Me.dtp_Fecha.Value.Date, Me.fPacienteId)
        Me.dgv_Recetas.DataSource = Me.CMDataSet.RECETAS

    End Sub

    Private Sub dgvHistoriales_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHistoriales.CellDoubleClick
        ConsultarHistorial(Me.dgvHistoriales.Rows(e.RowIndex).Cells("CHISTORIALDataGridViewTextBoxColumn").Value)
    End Sub

    Private Sub btAddAntecedentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAntecedentes.Click
        Dim frmAddAntecedente As New form_pac_infoprimaria(Enums.Accion.Insertar)
        Dim rowInfoPrimaria As CMDataSet.INFORMACIONPRIMARIARow
        Dim dialogresult As DialogResult

        dialogresult = frmAddAntecedente.ShowDialog
        If dialogresult = Windows.Forms.DialogResult.OK Then
            rowInfoPrimaria = CMDataSet.INFORMACIONPRIMARIA.NewINFORMACIONPRIMARIARow
            With rowInfoPrimaria
                .FECHA = frmAddAntecedente.Fecha.Date
                .DESCRIPCION = frmAddAntecedente.Descripcion
                .REFPACIENTE = Me.fPacienteId
                .TEXTO = frmAddAntecedente.Detalle
                If Me.INFORMACIONPRIMARIATableAdapter.MaximoId.HasValue Then
                    .ID = Me.INFORMACIONPRIMARIATableAdapter.MaximoId.Value + 1
                Else
                    .ID = 1
                End If
            End With
            CMDataSet.INFORMACIONPRIMARIA.Rows.Add(rowInfoPrimaria)
            INFORMACIONPRIMARIATableAdapter.Update(CMDataSet.INFORMACIONPRIMARIA)
        End If
    End Sub

    Private Sub bt_DelAntecedente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_DelAntecedente.Click
        Dim INDICE As Integer = -1
        If Me.dgvAntecedentes.SelectedCells.Count > 0 Then
            INDICE = Me.dgvAntecedentes.SelectedCells(0).RowIndex
            CMDataSet.INFORMACIONPRIMARIA.Rows(INDICE).Delete()
            INFORMACIONPRIMARIATableAdapter.Update(CMDataSet.INFORMACIONPRIMARIA)
        End If
    End Sub


    Private Sub bt_AddAlarma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AddAlarma.Click
        Dim i As Integer = -1
        Dim tbAlarmas As New CMDataSet.ALARMASDataTable
        Me.ALARMASTableAdapter.Fill(CMDataSet.ALARMAS)
        Dim frmAlarmas As New form_listados("Listado de Alarmas", Me.Alarmas_BindingSource, RoleManager.Items.Alarmas, True)
        frmAlarmas.ShowDialog()
        If frmAlarmas.Selected <> "" Then
            'Vuelvo a cargar solo las alarmas del paciente
            Me.CargarAlarmas()

            'Compruebo que la alarma no este ya asignada.
            For i = 0 To Me.dgvAlarmas.Rows.Count - 1
                If Me.dgvAlarmas.Rows(i).Cells("CALARMA").Value = frmAlarmas.Selected Then
                    MsgBox("Ya tiene asignada esa Alarma.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next
            Me.ALARMASTableAdapter.FillAlarmaById(Me.CMDataSet.ALARMAS, frmAlarmas.Selected)
            For i = 0 To CMDataSet.ALARMAS.Rows.Count - 1
                Dim rowLineaAlarma As CMDataSet.LINEASALARMARow
                rowLineaAlarma = CMDataSet.LINEASALARMA.NewLINEASALARMARow

                'asigno los valores
                rowLineaAlarma.REFALARMA = CMDataSet.ALARMAS.Rows(0).Item("CALARMA")
                rowLineaAlarma.REFPACIENTE = Me.fPacienteId
                If Not CMDataSet.ALARMAS.Rows(0).Item("Descripcion").GetType Is GetType(DBNull) Then
                    rowLineaAlarma.DESCRIPCION = CMDataSet.ALARMAS.Rows(0).Item("Descripcion")
                Else
                    rowLineaAlarma.DESCRIPCION = ""
                End If
                'Calculo el id que toca.
                If Not Me.LINEASALARMATableAdapter.MaximoId.Value.GetType Is GetType(DBNull) Then
                    rowLineaAlarma.IDLINEAALARMA = Me.LINEASALARMATableAdapter.MaximoId.Value + 1
                Else
                    rowLineaAlarma.IDLINEAALARMA = 1
                End If
                'añado la linea a la tabla
                Me.CMDataSet.LINEASALARMA.Rows.Add(rowLineaAlarma)
            Next
            Me.LINEASALARMAsBindingSource.CurrencyManager.EndCurrentEdit()
            Me.CMDataSet.LINEASALARMA.AcceptChanges()
            'Tengo qeu guardar en la bd porque si no la consulta de alarmas 
            'por paciente no funciona por tener un inner join
            Me.LINEASALARMATableAdapter.Update(CMDataSet.LINEASALARMA)
            'Me.CargarAlarmas()
        End If

    End Sub
    Private Sub AddHistorialDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddDiagnostico.Click
        Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.fId)
        nuevoDiag.ShowInTaskbar = False
        nuevoDiag.ShowDialog()
        If nuevoDiag.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim FILA As CMDataSet.HistorialesDiagnosticosRow
            FILA = CMDataSet.HistorialesDiagnosticos.NewHistorialesDiagnosticosRow
            FILA.CIE10 = nuevoDiag.Cie10
            FILA.DIAGNOSTICO = nuevoDiag.Diagnostico
            FILA.OBSERVACIONES = nuevoDiag.Observaciones
            FILA.CHistorial = fId
            FILA.IdDiagnostico = nuevoDiag.idDiagnostico

            CMDataSet.HistorialesDiagnosticos.Rows.Add(FILA)
        End If
    End Sub

    Private Sub bt_DelAlarma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_DelAlarma.Click
        Dim index As Integer = -1
        If Me.dgvAlarmas.SelectedCells.Count > 0 Then
            index = Me.dgvAlarmas.SelectedCells(0).RowIndex
            Me.CMDataSet.LINEASALARMA.Rows(index).Delete()
        End If
    End Sub

    Private Sub bt_EditaDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditDiagnostico.Click

        Dim Cie10 As String
        Dim Observaciones As String
        Dim Diagnostico As String
        Dim idDiagnostico As Integer

        'filaSeleccionada = Me.dtg_Diagnosticos.SelectedRows(0).Cells("IDANTECEDENTEDX").Value
        Cie10 = Me.dtg_Diagnosticos.SelectedRows(0).Cells("CIE10DataGridViewTextBoxColumn").Value
        Observaciones = Me.dtg_Diagnosticos.SelectedRows(0).Cells(OBSERVACIONESDataGridViewTextBoxColumn.Name).Value
        Diagnostico = Me.dtg_Diagnosticos.SelectedRows(0).Cells(DIAGNOSTICODataGridViewTextBoxColumn.Name).Value
        idDiagnostico = Me.dtg_Diagnosticos.SelectedRows(0).Cells(IdDiagnosticoDataGridViewTextBoxColumn.Name).Value


        Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.fId, True)
        nuevoDiag.ShowInTaskbar = False
        nuevoDiag.Cie10 = Cie10
        nuevoDiag.Observaciones = Observaciones
        nuevoDiag.Diagnostico = Diagnostico
        nuevoDiag.idDiagnostico = idDiagnostico

        nuevoDiag.ShowDialog()

        If nuevoDiag.DialogResult = Windows.Forms.DialogResult.OK Then
            'Dim FILA As CMDataSet.AntecedentesDiagnosticosRow

            Me.dtg_Diagnosticos.SelectedRows(0).Cells("CIE10DataGridViewTextBoxColumn").Value = nuevoDiag.Cie10
            Me.dtg_Diagnosticos.SelectedRows(0).Cells(OBSERVACIONESDataGridViewTextBoxColumn.Name).Value = nuevoDiag.Diagnostico
            Me.dtg_Diagnosticos.SelectedRows(0).Cells(DIAGNOSTICODataGridViewTextBoxColumn.Name).Value = nuevoDiag.Observaciones
            Me.dtg_Diagnosticos.SelectedRows(0).Cells(IdDiagnosticoDataGridViewTextBoxColumn.Name).Value = nuevoDiag.idDiagnostico

        End If
    End Sub

    Private Sub bt_QuitaDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelDiagnostico.Click
        Dim i As Integer
        Dim res As MsgBoxResult
        If dtg_Diagnosticos.SelectedRows.Count > 0 Then
            res = MsgBox("Se dispone a borrar " & dtg_Diagnosticos.SelectedRows.Count & ", esta acción no podrá deshacerse ¿Desea continuar?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                For i = 0 To dtg_Diagnosticos.SelectedRows.Count - 1
                    Me.dtg_Diagnosticos.Rows.Remove(dtg_Diagnosticos.SelectedRows(0))
                Next
            End If
        End If
    End Sub


    Private Sub dgv_Recetas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Recetas.CellDoubleClick

        If dgv_Recetas.SelectedRows.Count > 0 Then
            Dim receta As CMDataSet.RECETASRow = dgv_Recetas.SelectedRows(0).DataBoundItem.Row
            Dim frm As New form_receta_ex("Editar Receta", Enums.Accion.Modificar, receta.IDRECETA, fPacienteId)
            frm.ShowDialog()
            CargaRecetas()

        End If

    End Sub

    Private Sub btn_AnnadirAntecentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AnnadirAntecentes.Click
        If CtrlDiagnosticos1.ID_DIAGNOSTICOS.HasValue Then
            AnnadirDiagnostico_Antecendentes(CtrlDiagnosticos1.Diagnostico)
        End If
    End Sub

    Private Sub AnnadirDiagnostico_Antecendentes(ByVal diagnosticoRow As DIAGNOSTICO)
        'Si no esta agregado ya, incluir
        Dim diagnostico As String = ""
        If Not diagnosticoRow.DIAGNOSTICO Is Nothing Then
            diagnostico = diagnosticoRow.DIAGNOSTICO
        End If

        Dim observaciones As String = ""
        If Not diagnosticoRow.OBSERVACIONES Is Nothing Then
            observaciones = diagnosticoRow.OBSERVACIONES
        End If
        Dim cie10 As String = ""
        If Not diagnosticoRow.CIE10 Is Nothing Then
            cie10 = diagnosticoRow.CIE10
        End If
        If Not ExisteAntecedentes(diagnosticoRow.IDDIAGNOSTICO) Then
            Dim row As CMDataSet.AntecedentesDiagnosticosRow = _
            CMDataSet.AntecedentesDiagnosticos.NewAntecedentesDiagnosticosRow()
            row.DIAGNOSTICO = diagnostico
            row.CIE10 = cie10
            row.CPACIENTE = fPacienteId
            row.IDDIAGNOSTICO = diagnosticoRow.IDDIAGNOSTICO
            'AddAntecedentesDiagnosticosRow(diagnostico, observaciones, cie10, fPacienteId, diagnosticoRow.IDDIAGNOSTICO)

            CMDataSet.AntecedentesDiagnosticos.AddAntecedentesDiagnosticosRow(row)

            MuestraMensaje("¡Añadido a Antecedentes!", Color.Green)
        Else
            MuestraMensaje("¡Ya existe en Antecedentes!", Color.Red)
        End If
    End Sub

    Private Function ExisteAntecedentes(ByVal idDiagnostico As Integer) As Boolean
        For Each antecente As CMDataSet.AntecedentesDiagnosticosRow In CMDataSet.AntecedentesDiagnosticos

            If antecente.IDDIAGNOSTICO = idDiagnostico Then
                Return True
            End If

        Next
        Return False
    End Function

    Private Sub MuestraMensaje(ByVal text As String, ByVal color As Color)
        lbl_MSG.ForeColor = color
        lbl_MSG.Text = text
        lbl_MSG.Visible = True
        TimerMsg.Start()
    End Sub

    Private Sub CtrlDiagnosticos1_DIAGNOSTICOSSeleccionado(ByVal IdDIAGNOSTICOS As System.Int32) Handles CtrlDiagnosticos1.DIAGNOSTICOSSeleccionado

        fDiagnosticoId = IdDIAGNOSTICOS
        If Globales.Configuracion.solapashistoriales = True Then
            Dim _aux As TabPage = TabControl1.TabPages(Integer.Parse(Globales.Configuracion.campodiagnostico))
            Dim _edit_control As tool_control = _aux.Controls(0)
            _edit_control.ControlText = CtrlDiagnosticos1.NombreCompleto '_dataDiag.Rows(0).Item("DIAGNOSTICO").ToString()
        Else
            pn_FormaTextbox.Controls(2 * Integer.Parse(Globales.Configuracion.campodiagnostico) + 1).Text = CtrlDiagnosticos1.NombreCompleto
        End If
        btn_AnnadirAntecentes.Enabled = True

    End Sub

    Private Sub CtrlDiagnosticos1_DIAGNOSTICOSNoEncontrado() Handles CtrlDiagnosticos1.DIAGNOSTICOSNoEncontrado
        fDiagnosticoId = -1
        btn_AnnadirAntecentes.Enabled = False
    End Sub


    Private Sub CtrlDiagnosticos1_DIAGNOSTICOSEliminada(ByVal IdDIAGNOSTICOS As System.Int32) Handles CtrlDiagnosticos1.DIAGNOSTICOSEliminada
        fDiagnosticoId = -1
        btn_AnnadirAntecentes.Enabled = False
    End Sub

    Private Sub dtg_Diagnosticos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_Diagnosticos.CellClick
        If e.ColumnIndex = ColumnAddAntecente.Index Then
            Dim historialesDiagnostico As CMDataSet.HistorialesDiagnosticosRow = dtg_Diagnosticos.Rows(e.RowIndex).DataBoundItem.Row


            Dim context As New CMLinqDataContext
            Dim diag As DIAGNOSTICO = context.DIAGNOSTICOs.Where(Function(o) o.IDDIAGNOSTICO = historialesDiagnostico.IdDiagnostico).SingleOrDefault()

            If Not diag Is Nothing Then
                AnnadirDiagnostico_Antecendentes(diag)
            End If

            'Dim temp As CMDataSet.DIAGNOSTICOSDataTable = DIAGNOSTICOSTableAdapter.GetDiagnosticoById(historialesDiagnostico.IdDiagnostico)
            'If Not temp Is Nothing And temp.Rows.Count > 0 Then
            '    Dim diagnostico As CMDataSet.DIAGNOSTICOSRow = temp(0)
            '    AnnadirDiagnostico_Antecendentes(diagnostico)
            'End If

        End If
    End Sub

    Private Sub TimerMsg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMsg.Tick
        lbl_MSG.Visible = False
        TimerMsg.Stop()
    End Sub

    Private Sub btnDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDental.Click
        Dim frm As New frmOdontograma()
        frm.PacienteActual = fPacienteId
        frm.Text = "Odontograma de " & tb_Paciente.Text
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Dim richT As New RichTextBox

    Private Function TextFromRtf(p1 As String) As String
        Try
            If p1 Is Nothing Then
                Return Nothing
            End If
            richT.Rtf = p1.Trim()
            Return richT.Text.Trim()
        Catch ex As Exception
            Return p1.Trim()
        End Try

    End Function

End Class