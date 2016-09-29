Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Recetas
Imports centro_medico.UI.Reportes

Public Class frmHistoriales_Editar
    'Public paciente As PACIENTE
    Public IdPaciente As Integer
    Public PACIENTE_NOMBRECOMPLETO As String
    Public IdHistorial As Integer
    'Public ParentHistorial As Null
    Dim pac As PACIENTE
    Dim context As CMLinqDataContext
    Dim fCambios As Boolean = False
    Dim OnLoad As Boolean = False
    Dim Med As String = ""


    Sub New(IdPaciente As Integer, IDHISTORIAL As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdPaciente = IdPaciente
        Me.IdHistorial = IDHISTORIAL
    End Sub

    Sub New(IdPaciente As Integer, nombre As String, IDHISTORIAL As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdPaciente = IdPaciente
        Me.PACIENTE_NOMBRECOMPLETO = nombre
        Me.IdHistorial = IDHISTORIAL
    End Sub


    Sub New(IdPaciente As Integer, nombre As String, IDHISTORIAL As Integer, modo As Globales.ModoParaFormas)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdPaciente = IdPaciente
        Me.PACIENTE_NOMBRECOMPLETO = nombre
        Me.IdHistorial = IDHISTORIAL
    End Sub

    Private Sub InicializarTextos(hist As HISTORIALE)
        ' HISTORIALEBindingSource.DataSource = hist

        editPruebas.Text = Globales.TextFromRtf(hist.COMPLEMENTARIAS)

        editTratamiento.Text = Globales.TextFromRtf(hist.TRATAMIENTO)

        editHipDiagnostica.Text = Globales.TextFromRtf(hist.JUICIO)

        editExploracion.Text = Globales.TextFromRtf(hist.EXPLORACION)

        editOtrasObservaciones.Text = Globales.TextFromRtf(hist.OTROS)

        editNotasFinales.Text = Globales.TextFromRtf(hist.COMENTARIOS)

        editHistorial.Text = Globales.TextFromRtf(hist.HISTORIAL)

        EditAntecedentes.Text = Globales.TextFromRtf(hist.ANTECEDENTES)

        EditMotivo.Text = Globales.TextFromRtf(hist.MOTIVO)

    End Sub

    Private Sub frmHistoriales_Editar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        OnLoad = True
        Med = CtrlMedicoHistorial.ID_Medico.ToString()
        Filtrar_InformacionPrimaria()
        Cargar_AntecedentesDiagnostico()
        Cargar_LineasAlarmas()
        Cargar_Recetas()
        Cargar_HistorialesDiagnosticos()

        Dim context As New CMLinqDataContext
        Dim hist As HISTORIALE = (From h In context.HISTORIALEs Where h.CHISTORIAL = Me.IdHistorial Select h).SingleOrDefault()
        If Not hist Is Nothing Then
            If hist.ParentHistorial.HasValue Then
                lblTipo.Text = "EPISODIO"
                lblTipo.ForeColor = Color.Red
            Else
                lblTipo.Text = "HISTORIAL"
                lblTipo.ForeColor = Color.Green

            End If
        End If
        InicializarTextos(hist)

        pac = hist.PACIENTE
        tb_Paciente.Text = pac.NombreCompleto


        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Historiales_Actuales) < RoleManager.TipoPermisos.Modificar Then
            SoloLectura()
        End If

        If Not Globales.Usuario.EsAdministrador Then
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
                If MasDeUnDia(hist.FECHA) Then
                    SoloLectura()
                End If
            End If
        End If
        OnLoad = False
    End Sub

    Private Sub SoloLectura()
        Me.bt_HtAceptar.Enabled = False
        Me.tsbGuardar.Enabled = False
        Me.bt_HtRecetas.Enabled = False
        Me.CtrlMedicoHistorial.Enabled = False
        Me.bt_HtAplicarplantilla.Enabled = False
        Me.Add.Visible = False
        Me.borrar.Visible = False
        Me.CtrlDiagnosticosPrincipal.Enabled = False
        Me.btAddDiagnostico.Visible = False
        Me.btEditDiagnostico.Visible = False
        Me.btDelDiagnostico.Visible = False
        Me.InfoPrimariaGridEX.Enabled = False
        Me.GridEXHipoDiag.Enabled = False
        Me.GridEXRecetas.Enabled = False
        btnDental.Enabled = False
        Me.dtp_Fecha.Enabled = False
        Me.dpt_hora.Enabled = False


        EditAntecedentes.ReadOnly = True
        editExploracion.ReadOnly = True
        editHipDiagnostica.ReadOnly = True
        editHistorial.ReadOnly = True
        EditMotivo.ReadOnly = True
        editNotasFinales.ReadOnly = True
        editOtrasObservaciones.ReadOnly = True
        editPruebas.ReadOnly = True
        editTratamiento.ReadOnly = True

        Add.Enabled = False
        borrar.Enabled = False
        btn_AnnadirAntecentes.Enabled = False
        GridEXHipoDiag.Enabled = False

    End Sub

    Private Function MasDeUnDia(fecha As Date)
        Return (Date.Now - fecha).Days > 1
    End Function

    Function Guardar() As Boolean
        HISTORIALEBindingSource.EndEdit()

        'Esto esta asi por problemas del binding

        Dim hist As HISTORIALE = HISTORIALEBindingSource.Current

        hist.FECHA = dtp_Fecha.Value
        hist.HORA = dpt_hora.Value
        hist.COMPLEMENTARIAS = editPruebas.Text
        hist.TRATAMIENTO = editTratamiento.Text
        hist.JUICIO = editHipDiagnostica.Text
        hist.EXPLORACION = editExploracion.Text
        hist.OTROS = editOtrasObservaciones.Text
        hist.COMENTARIOS = editNotasFinales.Text
        hist.HISTORIAL = editHistorial.Text
        hist.ANTECEDENTES = EditAntecedentes.Text
        hist.MOTIVO = EditMotivo.Text
        Return True
    End Function


    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            fCambios = False
            Me.Close()
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles Add.Click
        Dim frm As New frmInfoprimaria(Enums.Accion.Insertar)
        frm.ShowInTaskbar = False
        Dim context As New CMLinqDataContext()
        Dim info As New INFORMACIONPRIMARIA()
        info.REFPACIENTE = IdPaciente
        info.FECHA = Date.Now

        If context.INFORMACIONPRIMARIAs.Count = 0 Then
            info.ID = 0
        Else
            info.ID = context.INFORMACIONPRIMARIAs.Max(Function(o) o.ID) + 1
        End If


        frm.INFORMACIONPRIMARIABindingSource.DataSource = info
        Me.INFORMACIONPRIMARIABindingSource.DataSource = info

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            info.FECHA = frm.dtp_IPFecha.Value
            context.INFORMACIONPRIMARIAs.InsertOnSubmit(info)
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial,Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & IdPaciente.ToString() & " descripción: " & info.DESCRIPCION)
            Filtrar_InformacionPrimaria()
        End If
    End Sub

    Private Sub InfoPrimariaGridEX_DoubleClick(sender As Object, e As EventArgs) Handles InfoPrimariaGridEX.DoubleClick
        If InfoPrimariaGridEX.SelectedItems.Count <= 0 Then
            Return
        End If
        Dim info As INFORMACIONPRIMARIA
        info = InfoPrimariaGridEX.SelectedItems(0).GetRow().DataRow()
        Dim frm As New frmInfoprimaria(Enums.Accion.Modificar)
        frm.ShowInTaskbar = False
        Dim context As New CMLinqDataContext()
        info = (From i In context.INFORMACIONPRIMARIAs Where info.ID = i.ID Select i).First()

        frm.INFORMACIONPRIMARIABindingSource.DataSource = info
        Me.INFORMACIONPRIMARIABindingSource.DataSource = info

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial,Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & IdPaciente.ToString() & " descripción: " & info.DESCRIPCION)
            Filtrar_InformacionPrimaria()
        End If
    End Sub

    Private Sub borrar_Click(sender As System.Object, e As System.EventArgs) Handles borrar.Click
        If InfoPrimariaGridEX.SelectedItems.Count > 0 Then
            Dim info As INFORMACIONPRIMARIA = InfoPrimariaGridEX.SelectedItems(0).GetRow().DataRow()

            If MessageBox.Show("Desea eliminar esta información primaria?" & vbCrLf & info.DESCRIPCION, "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim context As New CMLinqDataContext()
                Dim Inf = (From i In context.INFORMACIONPRIMARIAs Where i.ID = info.ID Select i).First()
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Plantilla_de_Historial, "Historial,Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & IdPaciente.ToString() & " descripción: " & info.DESCRIPCION)
                context.INFORMACIONPRIMARIAs.DeleteOnSubmit(Inf)
                context.SubmitChanges()
                Filtrar_InformacionPrimaria()
            End If
        End If
    End Sub

    Private Sub Filtrar_InformacionPrimaria()
        INFORMACIONPRIMARIABindingSource.DataSource = Nothing
        Dim context As New CMLinqDataContext()
        INFORMACIONPRIMARIABindingSource.DataSource = (From i In context.INFORMACIONPRIMARIAs Where i.REFPACIENTE = IdPaciente).ToList()
        InfoPrimariaGridEX.DataSource = INFORMACIONPRIMARIABindingSource.DataSource
    End Sub

    Private Sub Cargar_AntecedentesDiagnostico()
        Dim context As New CMLinqDataContext()
        Me.AntecedentesDiagnosticoBindingSource.DataSource = (From a In context.AntecedentesDiagnosticos Where a.CPACIENTE = IdPaciente Select a).ToList()
        GridEXDiagnosticoAntecedente.DataSource = Me.AntecedentesDiagnosticoBindingSource

    End Sub

    Function EsElMismoDia(a As Date, b As Date) As Boolean
        Return (a.Date = b.Date)
    End Function

    Private Sub Cargar_Recetas()
        Dim context As New CMLinqDataContext()
        GridEXRecetas.DataSource = Nothing
        RECETABindingSource.DataSource = (From l In context.RECETAs Where (l.REFPACIENTE = IdPaciente And l.FECHA.Value.Date = dtp_Fecha.Value.Date And l.Eliminado = False) Select l).ToList()
        GridEXRecetas.DataSource = RECETABindingSource
    End Sub

    Private Sub Cargar_LineasAlarmas()
        Dim context As New CMLinqDataContext()
        GridEXLineaAlarma.DataSource = Nothing
        LINEASALARMABindingSource.DataSource = (From l In context.LINEASALARMAs Where l.REFPACIENTE = IdPaciente Select l).ToList()
        GridEXLineaAlarma.DataSource = LINEASALARMABindingSource
    End Sub

    Private Sub Cargar_HistorialesDiagnosticos()
        Dim context As New CMLinqDataContext()
        GridEXHipoDiag.DataSource = Nothing
        HistorialesDiagnosticoBindingSource.DataSource = (From l In context.HistorialesDiagnosticos Where l.CHistorial = IdHistorial Select l).ToList()
        GridEXHipoDiag.DataSource = HistorialesDiagnosticoBindingSource
    End Sub

    Private Sub btnDental_Click(sender As System.Object, e As System.EventArgs) Handles btnDental.Click
        Dim frm As New frmOdontograma()
        frm.PacienteActual = IdPaciente
        frm.Text = "Odontograma de " & tb_Paciente.Text
        frm.ShowDialog()
    End Sub

    Private Sub bt_HtRecetas_Click(sender As System.Object, e As System.EventArgs) Handles bt_HtRecetas.Click

        Dim newContext As New CMLinqDataContext()

        Dim _receta As New RECETA()
        _receta.REFPACIENTE = Me.IdPaciente
        _receta.REFMEDICO = CtrlMedicoHistorial.ID_Medico
        _receta.Eliminado = True


        newContext.RECETAs.InsertOnSubmit(_receta)
        newContext.SubmitChanges()

        Dim frm As New frmRecetas_Editar(_receta, newContext)
        frm.ShowInTaskbar = False
        frm.CtrlPacienteReceta.Enabled = False
        frm.DateTimeFecha.Value = Me.dtp_Fecha.Value
        frm.DateTimeHora.Value = Me.dpt_hora.Value

        If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            _receta.Eliminado = False
            newContext.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Recetas, "Receta", _receta.IDRECETA.ToString(), "fecha : " & _receta.FECHA.ToString() & " médico : " & _receta.MEDICO.NOMBRECOMPLETO & " paciente : " & Me.PACIENTE_NOMBRECOMPLETO)
            editTratamiento.Text = editTratamiento.Text + _receta.TRATAMIENTO
            Cargar_Recetas()
        Else
            'ocultar
            _receta.TRATAMIENTO = "RECETA CANCELADA POR EL USUARIO"
            _receta.Eliminado = True
            newContext.SubmitChanges()
        End If

    End Sub

    Private Sub GridEXRecetas_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridEXRecetas.DoubleClick
        If GridEXRecetas.SelectedItems.Count <= 0 Then
            Return
        End If

        Dim _receta As RECETA = GridEXRecetas.SelectedItems(0).GetRow().DataRow()

        Dim context As New CMLinqDataContext()

        _receta = (From r In context.RECETAs Where r.IDRECETA = _receta.IDRECETA Select r).First()

        Dim frm As New frmRecetas_Editar(_receta, context)
       
        frm.ShowInTaskbar = False
        frm.CtrlPacienteReceta.Enabled = False
        frm.DateTimeFecha.Value = Me.dtp_Fecha.Value
        frm.DateTimeHora.Value = Me.dpt_hora.Value

        If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            _receta.TRATAMIENTO = frm.editTratamiento.Text
            _receta.FECHA = frm.DateTimeFecha.Value
            _receta.HORA = frm.DateTimeHora.Value
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Recetas, "Receta", _receta.IDRECETA.ToString(), "fecha : " & _receta.FECHA & " médico : " & _receta.MEDICO.NOMBRECOMPLETO & " paciente : " & _receta.PACIENTE.NombreCompleto)
            context.SubmitChanges()
            Cargar_Recetas()
            Return
        End If

    End Sub


    Private Sub bt_HtAplicarplantilla_Click(sender As System.Object, e As System.EventArgs) Handles bt_HtAplicarplantilla.Click

        Dim _name As String = "Listado de Plantillas de Historiales"
        'Dim _listados As form_listados = New form_listados(_name, PLANTILLA_HISTORIALESBindingSource, RoleManager.Items.Plantilla_de_Historial, True)
        Dim _listados As form_listados = New form_listados(_name, Nothing, RoleManager.Items.Plantilla_de_Historial, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()

        If _listados.Selected() = "" Then
            Return
        End If

        Dim _mensajeResult = MessageBox.Show("Desea sobrescribir los datos de el historial", "Advertencia", MessageBoxButtons.YesNoCancel)
        If _mensajeResult = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Dim idPlantilla As String = _listados.Selected()
        Dim context As New CMLinqDataContext()
        Dim plantilla As PLANTILLA_HISTORIALE = (From p In context.PLANTILLA_HISTORIALEs Where p.CODIGO = idPlantilla Select p).First()

        If _mensajeResult = Windows.Forms.DialogResult.Yes Then
            editPruebas.Text = Globales.TextFromRtf(plantilla.COMPLEMENTARIAS)
            editTratamiento.Text = Globales.TextFromRtf(plantilla.TRATAMIENTO)
            editHipDiagnostica.Text = Globales.TextFromRtf(plantilla.JUICIO)
            editExploracion.Text = Globales.TextFromRtf(plantilla.EXPLORACION)
            EditMotivo.Text = Globales.TextFromRtf(plantilla.MOTIVO)
            EditAntecedentes.Text = Globales.TextFromRtf(plantilla.ANTECEDENTES)
            editHistorial.Text = Globales.TextFromRtf(plantilla.HISTORIAL)
            editNotasFinales.Text = Globales.TextFromRtf(plantilla.COMENTARIOS)
            editOtrasObservaciones.Text = Globales.TextFromRtf(plantilla.OTROS)
            Return
        End If

        editPruebas.Text = editPruebas.Text + " " + Globales.TextFromRtf(plantilla.COMPLEMENTARIAS)
        editTratamiento.Text = editTratamiento.Text + " " + Globales.TextFromRtf(plantilla.TRATAMIENTO)
        editHipDiagnostica.Text = editHipDiagnostica.Text + " " + Globales.TextFromRtf(plantilla.JUICIO)
        editExploracion.Text = editExploracion.Text + " " + Globales.TextFromRtf(plantilla.EXPLORACION)
        EditMotivo.Text = EditMotivo.Text + " " + Globales.TextFromRtf(plantilla.MOTIVO)
        EditAntecedentes.Text = EditAntecedentes.Text + " " + Globales.TextFromRtf(plantilla.ANTECEDENTES)
        editHistorial.Text = editHistorial.Text + " " + Globales.TextFromRtf(plantilla.HISTORIAL)
        editNotasFinales.Text = editNotasFinales.Text + " " + Globales.TextFromRtf(plantilla.COMENTARIOS)
        editOtrasObservaciones.Text = editOtrasObservaciones.Text + " " + Globales.TextFromRtf(plantilla.OTROS)
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tlbImprimir.Click
        'Dim context As New CMLinqDataContext
        'Dim historialesRoot As HISTORIALE = (From h As HISTORIALE In context.HISTORIALEs
        '                                            Where h.CHISTORIAL = IdHistorial Select h).First()

        If Guardar() Then
            Dim historial = HISTORIALEBindingSource.Current
            Imprime(historial)
        End If
        'context.Dispose()
    End Sub

    Private Sub bt_HtImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bt_HtImprimir.Click
        tlbImprimir_Click(Nothing, Nothing)
    End Sub

    Private Sub bt_HtCancelar_Click(sender As System.Object, e As System.EventArgs) Handles bt_HtCancelar.Click
        'Dim res As MsgBoxResult
        'res = MsgBox("Si continua los datos que tenga sin guardar se perderán. ¿Desea continuar?", MsgBoxStyle.YesNo, "Cancelar Edición")
        'If res = MsgBoxResult.Yes Then
        '    Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
        'End If

    End Sub

    Private Sub bt_HtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles bt_HtAceptar.Click
        tsbGuardar_Click(Nothing, Nothing)
    End Sub

    Private Sub btAddDiagnostico_Click(sender As Object, e As EventArgs) Handles btAddDiagnostico.Click
        Dim antecedente As New HistorialesDiagnostico()

        Dim frm As New frmHistorialesDiagnosticosEditar(antecedente)


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim context As New CMLinqDataContext()
            Dim d As DIAGNOSTICO = frm.CtrlDiagnosticosPrincipal.Diagnostico
            If d Is Nothing Then
                Return
            End If
            antecedente.CHistorial = IdHistorial
            Try
                antecedente.IdDiagnostico = frm.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS
                Dim diagnostico As String = ""
                If Not d.DIAGNOSTICO Is Nothing Then
                    diagnostico = d.DIAGNOSTICO
                End If
                Dim cie10 As String = ""
                If Not d.CIE10 Is Nothing Then
                    cie10 = d.CIE10
                End If
                antecedente.DIAGNOSTICO = diagnostico
                antecedente.CIE10 = cie10
                antecedente.OBSERVACIONES = frm.txtObservaciones.Text
                If antecedente.OBSERVACIONES Is Nothing Then
                    antecedente.OBSERVACIONES = ""
                End If
                context.HistorialesDiagnosticos.InsertOnSubmit(antecedente)
                context.SubmitChanges()
                Try
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial diagnosticos", antecedente.IdDiagnostico.ToString(), "diagnóstico : " & antecedente.IdDiagnostico & " " & antecedente.DIAGNOSTICO1.DIAGNOSTICO & " paciente :" & Me.IdPaciente.ToString())
                Catch ex As Exception
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial diagnosticos", antecedente.IdDiagnostico.ToString(), "diagnóstico : " & antecedente.IdDiagnostico & " paciente :" & Me.IdPaciente.ToString())
                End Try
                Cargar_HistorialesDiagnosticos()
            Catch ex As Exception
                MessageBox.Show("no ha podido cargarse el diagnóstico")
            End Try
        End If



        'Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.IdPaciente)
        'nuevoDiag.ShowInTaskbar = False
        'nuevoDiag.ShowDialog()
        'If nuevoDiag.DialogResult = Windows.Forms.DialogResult.OK Then
        '    Dim HistorialDiag As New HistorialesDiagnostico()
        '    HistorialDiag.CHistorial = IdHistorial
        '    HistorialDiag.IdDiagnostico = nuevoDiag.idDiagnostico
        '    HistorialDiag.CIE10 = nuevoDiag.Cie10
        '    HistorialDiag.DIAGNOSTICO = nuevoDiag.Diagnostico
        '    HistorialDiag.OBSERVACIONES = nuevoDiag.Observaciones
        '    context = New CMLinqDataContext()

        '    context.HistorialesDiagnosticos.InsertOnSubmit(HistorialDiag)
        '    context.SubmitChanges()
        '    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Diagnosticos, "Hipótesis Diagnóstica", HistorialDiag.IdLineaDiagnostico.ToString(), "diagnóstico : " & HistorialDiag.IdDiagnostico.ToString() & " historial : " & IdHistorial & " id paciente : " & IdPaciente & " paciente : " & PACIENTE_NOMBRECOMPLETO)
        '    Cargar_HistorialesDiagnosticos()
        ' End If
    End Sub

    Private Sub btEditDiagnostico_Click(sender As Object, e As EventArgs) Handles btEditDiagnostico.Click

        If (GridEXHipoDiag.SelectedItems.Count > 0) Then
            Dim antecedente As HistorialesDiagnostico = GridEXHipoDiag.SelectedItems(0).GetRow.DataRow

            Dim frm As New frmHistorialesDiagnosticosEditar(antecedente)
            'frm.AntecedentesDiagnosticoBindingSource.DataSource = antecedente

            frm.txtObservaciones.Text = antecedente.OBSERVACIONES
            frm.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS = antecedente.IdDiagnostico


            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim context As New CMLinqDataContext()
                Dim d As DIAGNOSTICO = frm.CtrlDiagnosticosPrincipal.Diagnostico
                antecedente = (From a In context.HistorialesDiagnosticos Where a.IdLineaDiagnostico = antecedente.IdLineaDiagnostico Select a).First()
                If d Is Nothing Then
                    Return
                End If
                Try
                    antecedente.IdDiagnostico = frm.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS
                    Dim diagnostico As String = ""
                    If Not d.DIAGNOSTICO Is Nothing Then
                        diagnostico = d.DIAGNOSTICO
                    End If
                    Dim cie10 As String = ""
                    If Not d.CIE10 Is Nothing Then
                        cie10 = d.CIE10
                    End If
                    antecedente.DIAGNOSTICO = diagnostico
                    antecedente.CIE10 = cie10
                    antecedente.OBSERVACIONES = frm.txtObservaciones.Text
                    If antecedente.OBSERVACIONES Is Nothing Then
                        antecedente.OBSERVACIONES = ""
                    End If
                    context.SubmitChanges()
                    Try
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial diagnosticos", antecedente.IdDiagnostico.ToString(), "diagnóstico : " & antecedente.IdDiagnostico & " " & antecedente.DIAGNOSTICO1.DIAGNOSTICO & " paciente :" & Me.IdPaciente.ToString())
                    Catch ex As Exception
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Plantilla_de_Historial, "Historial diagnosticos", antecedente.IdDiagnostico.ToString(), "diagnóstico : " & antecedente.IdDiagnostico & " paciente :" & Me.IdPaciente.ToString())
                    End Try
                    Cargar_HistorialesDiagnosticos()
                Catch ex As Exception
                    MessageBox.Show("no ha podido cargarse el diagnóstico")
                End Try
            End If
        End If

        'If (GridEXHipoDiag.SelectedItems.Count > 0) Then
        '    Dim HistorialDiag As HistorialesDiagnostico = GridEXHipoDiag.SelectedItems(0).GetRow.DataRow

        '    Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.IdPaciente, True)
        '    nuevoDiag.ShowInTaskbar = False
        '    nuevoDiag.Cie10 = HistorialDiag.CIE10
        '    nuevoDiag.Observaciones = HistorialDiag.OBSERVACIONES
        '    nuevoDiag.Diagnostico = HistorialDiag.DIAGNOSTICO
        '    nuevoDiag.idDiagnostico = HistorialDiag.IdDiagnostico

        '    If nuevoDiag.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        HistorialDiag = (From i In context.HistorialesDiagnosticos Where HistorialDiag.IdLineaDiagnostico = i.IdLineaDiagnostico Select i).FirstOrDefault()


        '        HistorialDiag.IdDiagnostico = nuevoDiag.idDiagnostico
        '        HistorialDiag.CIE10 = nuevoDiag.Cie10
        '        HistorialDiag.DIAGNOSTICO = nuevoDiag.Diagnostico
        '        HistorialDiag.OBSERVACIONES = nuevoDiag.Observaciones

        '        ' Dim context As New CMLinqDataContext()
        '        context.SubmitChanges()
        '        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Diagnosticos, "Hipótesis Diagnóstica", HistorialDiag.IdLineaDiagnostico.ToString(), "diagnóstico : " & HistorialDiag.IdDiagnostico.ToString() & " historial : " & IdHistorial & " id paciente : " & IdPaciente & " paciente : " & PACIENTE_NOMBRECOMPLETO)
        '        Cargar_HistorialesDiagnosticos()
        '    End If
        'End If
    End Sub

    Private Sub btDelDiagnostico_Click(sender As Object, e As EventArgs) Handles btDelDiagnostico.Click
        Try
            If (GridEXHipoDiag.SelectedItems.Count > 0) Then
                Dim HistorialDiag As HistorialesDiagnostico = GridEXHipoDiag.SelectedItems(0).GetRow.DataRow

                If MessageBox.Show("Desea eliminar este diagnóstico?" & vbCrLf & HistorialDiag.DIAGNOSTICO, "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim context As New CMLinqDataContext()
                    HistorialDiag = (From i In context.HistorialesDiagnosticos Where HistorialDiag.IdLineaDiagnostico = i.IdLineaDiagnostico Select i).FirstOrDefault()

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Diagnosticos, "Hipótesis Diagnóstica", HistorialDiag.IdLineaDiagnostico.ToString(), "diagnóstico : " & HistorialDiag.IdDiagnostico.ToString() & " historial : " & IdHistorial & " id paciente : " & IdPaciente & " paciente : " & PACIENTE_NOMBRECOMPLETO)
                    context.HistorialesDiagnosticos.DeleteOnSubmit(HistorialDiag)
                    context.SubmitChanges()
                    Cargar_HistorialesDiagnosticos()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridEXHipoDiag_DoubleClick(sender As Object, e As EventArgs) Handles GridEXHipoDiag.DoubleClick
        btEditDiagnostico_Click(Nothing, Nothing)
    End Sub

    Private Sub CtrlDiagnosticosPrincipal_DIAGNOSTICOSEliminada(IdDIAGNOSTICOS As Integer) Handles CtrlDiagnosticosPrincipal.DIAGNOSTICOSEliminada
        btn_AnnadirAntecentes.Enabled = False
    End Sub

    Private Sub CtrlDiagnosticosPrincipal_DIAGNOSTICOSNoEncontrado() Handles CtrlDiagnosticosPrincipal.DIAGNOSTICOSNoEncontrado
        btn_AnnadirAntecentes.Enabled = False
    End Sub

    Private Sub CtrlDiagnosticosPrincipal_DIAGNOSTICOSSeleccionado(IdDIAGNOSTICOS As Integer) Handles CtrlDiagnosticosPrincipal.DIAGNOSTICOSSeleccionado

        'fDiagnosticoId = IdDIAGNOSTICOS
        'If Globales.Configuracion.solapashistoriales = True Then
        '    Dim _aux As TabPage = TabControl1.TabPages(Integer.Parse(Globales.Configuracion.campodiagnostico))
        '    Dim _edit_control As tool_control = _aux.Controls(0)
        '    _edit_control.ControlText = CtrlDiagnosticos1.NombreCompleto '_dataDiag.Rows(0).Item("DIAGNOSTICO").ToString()
        'Else
        '    pn_FormaTextbox.Controls(2 * Integer.Parse(Globales.Configuracion.campodiagnostico) + 1).Text = CtrlDiagnosticos1.NombreCompleto
        'End If
        btn_AnnadirAntecentes.Enabled = True

    End Sub

    Private Sub btn_AnnadirAntecentes_Click(sender As Object, e As EventArgs) Handles btn_AnnadirAntecentes.Click
        If CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS.HasValue Then
            AnnadirDiagnostico_Antecendentes(CtrlDiagnosticosPrincipal.Diagnostico)
        End If
    End Sub

    Private Sub AnnadirDiagnostico_Antecendentes(ByVal diagnosticoRow As DIAGNOSTICO)

        Dim context As New CMLinqDataContext()

        Dim q = (From i In context.AntecedentesDiagnosticos Where (i.IDDIAGNOSTICO = diagnosticoRow.IDDIAGNOSTICO And i.CPACIENTE = Me.IdPaciente)).FirstOrDefault()

        If Not q Is Nothing Then
            MuestraMensaje("¡Ya existe en Antecedentes!", Color.Red)
            Return
        End If

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

        Dim t As New AntecedentesDiagnostico()
        t.CIE10 = cie10
        t.CPACIENTE = Me.IdPaciente
        t.DIAGNOSTICO = diagnostico
        t.IDDIAGNOSTICO = diagnosticoRow.IDDIAGNOSTICO
        t.OBSERVACIONES = observaciones
        context.AntecedentesDiagnosticos.InsertOnSubmit(t)
        context.SubmitChanges()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Diagnosticos, "Antecedentes Diagnósticos", t.IDANTECEDENTEDX, "diagnóstico : " & t.IDDIAGNOSTICO.ToString() & " historial : " & IdHistorial & " id paciente : " & IdPaciente & " paciente : " & PACIENTE_NOMBRECOMPLETO)

        MuestraMensaje("¡Añadido a Antecedentes!", Color.Green)
        'TimerMsg.Start()
        Cargar_AntecedentesDiagnostico()
    End Sub

    Private Sub MuestraMensaje(ByVal text As String, ByVal color As Color)
        lbl_MSG.ForeColor = color
        lbl_MSG.Text = text
        lbl_MSG.Visible = True
        TimerMsg.Start()
    End Sub


    Private Sub GridEXHipoDiag_ColumnButtonClick(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXHipoDiag.ColumnButtonClick
        If e.Column.Key = "ColumnAgregarAntecedentes" Then
            If (GridEXHipoDiag.SelectedItems.Count < 1) Then
                Return
            End If
            Dim ante As HistorialesDiagnostico = GridEXHipoDiag.SelectedItems(0).GetRow.DataRow
            AnnadirDiagnostico_Antecendentes(ante.DIAGNOSTICO1)
        End If
    End Sub

    Private Sub LimpiarRtfs(ByRef historia As HISTORIALE)

        historia.COMENTARIOS = Globales.TextFromRtf(historia.COMENTARIOS)
        historia.COMPLEMENTARIAS = Globales.TextFromRtf(historia.COMPLEMENTARIAS)
        historia.EXPLORACION = Globales.TextFromRtf(historia.EXPLORACION)
        historia.HISTORIAL = Globales.TextFromRtf(historia.HISTORIAL)
        historia.JUICIO = Globales.TextFromRtf(historia.JUICIO)
        historia.MOTIVO = Globales.TextFromRtf(historia.MOTIVO)
        historia.TRATAMIENTO = Globales.TextFromRtf(historia.TRATAMIENTO)
        historia.OTROS = Globales.TextFromRtf(historia.OTROS)
        historia.HipotesisDiagnostica = Globales.TextFromRtf(historia.HipotesisDiagnostica)
        historia.ANTECEDENTES = Globales.TextFromRtf(historia.ANTECEDENTES)
    End Sub

    Private Function Antecedentes() As String
        Dim cadena As String = ""
        Try
            Dim a
            If GridEXDiagnosticoAntecedente.GetRows.Count > 0 Then
                cadena = cadena + vbCrLf
                For Each a In GridEXDiagnosticoAntecedente.GetRows
                    cadena = cadena + a.DataRow.DIAGNOSTICO + vbCrLf
                Next
            End If
        Catch ex As Exception
        End Try
        Return cadena
    End Function

    Private Sub Imprime(historialesRoot As HISTORIALE)
        Try
            'Imprimir todos los historiales

            Dim dsPaciente As New ReportDataSource()
            Dim paclist As New List(Of PACIENTE)

            paclist.Add(pac)
            dsPaciente.Name = "CMDataSet_PACIENTES"
            dsPaciente.Value = paclist


            Dim dsHistorial As New ReportDataSource()

            Dim historiales As New List(Of WRAPPER_HISTORIAL)

            LimpiarRtfs(historialesRoot)

            Dim hist As New WRAPPER_HISTORIAL(historialesRoot)
            hist.HISTORIAL_ANTECEDENTES = hist.HISTORIAL_ANTECEDENTES + Antecedentes()
            historiales.Add(hist)

            dsHistorial.Name = "CMDataSet_HISTORIALES"
            dsHistorial.Value = historiales


            ' Dim rpt_parameters As Microsoft.Reporting.WinForms.ReportParameterInfoCollection = _print.ReportViewer.LocalReport.GetParameters
            Dim rayParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

            'If Not rpt_parameters.Item("param_DNI") Is Nothing Then
            If Not pac.DNI Is Nothing Then
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", pac.DNI.ToString() & Globales.GetLetter(pac.DNI.ToString())))
            Else
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", ""))
            End If
            'End If

            'If Not rpt_parameters.Item("param_PASAPORTE") Is Nothing Then
            If Not pac.PASAPORTE Is Nothing Then
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", pac.PASAPORTE.ToString()))
            Else
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", ""))
            End If
            'End If


            UI.Reportes.ReportesManager.Imprime("HistorialesResumen.rdlc", {dsHistorial, dsPaciente}, rayParam.ToArray)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TimerMsg_Tick(sender As Object, e As EventArgs) Handles TimerMsg.Tick
        lbl_MSG.Visible = False
        TimerMsg.Stop()
    End Sub

    Private Sub frmHistoriales_Editar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        If Not Med = CtrlMedicoHistorial.ID_Medico.ToString() Then
            fCambios = True
            Med = CtrlMedicoHistorial.ID_Medico.ToString()
        End If
        If fCambios = True Then
            res = MsgBox("Hay cambios sin guardar. ¿Desea guardar los cambios?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                'e.Cancel = True
                fCambios = False
                Call tsbGuardar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub EditMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EditMotivo.KeyPress, editHistorial.KeyPress, editExploracion.KeyPress, editPruebas.KeyPress
        fCambios = True
    End Sub

    Private Sub editTratamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles editTratamiento.KeyPress, editHipDiagnostica.KeyPress, editOtrasObservaciones.KeyPress, EditAntecedentes.KeyPress, editNotasFinales.KeyPress
        fCambios = True
    End Sub

    Private Sub dtp_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Fecha.ValueChanged, dpt_hora.ValueChanged
        If Me.Visible Then fCambios = True
    End Sub

    Private Sub GridEXHipoDiag_RowCountChanged(sender As Object, e As EventArgs) Handles GridEXHipoDiag.RowCountChanged, GridEXRecetas.RowCountChanged, InfoPrimariaGridEX.RowCountChanged, GridEXDiagnosticoAntecedente.RowCountChanged, GridEXLineaAlarma.RowCountChanged
        If OnLoad = False Then fCambios = True
    End Sub
End Class


