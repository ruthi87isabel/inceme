Imports System.IO
Imports Microsoft.ApplicationBlocks.Data
Imports System.Linq
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes
Imports System.ComponentModel

Public Class form_citas
    Dim cambioCT As Integer
    Dim citas As Nullable(Of Integer)
    Dim cit As CITA
    Dim context As New CMLinqDataContext()
    Dim cargando As Boolean
    Dim fcurrentAcc As Integer
    Public fIdCITA As Integer
    Dim fIdfactura As Nullable(Of Integer) = Nothing
    Dim fnotaso As String
    Dim fidpaco As Integer
    Dim fpacienteo As String
    Dim fidmedicoo As Integer
    Dim fidformao As String
    Dim faseguradorao As Integer
    Dim freciboo As Nullable(Of Integer) = Nothing
    Dim fconfirmadao As String
    Dim fatendidao As String
    Dim ffaltao As String
    Dim fpagadao As String
    Dim ffechao As Date
    Dim ffechacobroo As Date
    Dim fhorainicioo As Date
    Dim fhorafino As Date
    Dim fimporteclinicao As Double
    Dim fimportedro As Double
    Dim clickaccept As Boolean = False
    Dim cambios As Boolean = False
    '
    Dim fduracion As Integer = 10
    '/////////////////////////////////////
    Dim fPacienteId As Integer
    Dim fDesdePaciente As Boolean = False

    Dim fCMDataSet As CMDataSet
    '-->/////////////////////////////////////

    Dim recalcularConceptos As Boolean = False

    Public DesdeCalendario As Boolean = False

    Public IdProceso As Nullable(Of Long) = Nothing
    Public DesdeFormProceso As Boolean = False

    Public MutuaPreseleccionada As CMDataSet.MUTUASRow = Nothing

    Private duracionCalculada As Boolean = False

    Public ID_Sala As Nullable(Of Integer) = Nothing
    Dim horas As IList(Of HORARIOS_MEDICOS)

    Dim CitasModificadas As List(Of CitaKey)
    Dim Sincfecha As Date
    Dim Sincmedico As Integer
    Dim CheckMutua As Boolean = Globales.Configuracion.VincularCitaMutua


    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal afecha As Date, ID_SalaP As Nullable(Of Integer))

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.ffechao = afecha
        If CurrentAccion = Enums.Accion.Insertar Then
            If Globales.Usuario.REFMEDICO.HasValue Then
                Me.CtrlMedico1.ID_Medico = Globales.Usuario.REFMEDICO
                'Me.lb_medico.Text = Me.GetMedico(tb_idmedico.Text)
            End If
        End If

        cambios = False
        Me.ID_Sala = ID_SalaP

    End Sub

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fIdCITA = aId
        cambios = False

    End Sub

    '/////////////////////////////////////
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)
        'aqui
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fIdCITA = aId
        Me.fPacienteId = aPacienteId
        Me.fDesdePaciente = True
        If CurrentAccion = Enums.Accion.Insertar Then
            ffechao = DateTime.Now
            If Globales.Usuario.REFMEDICO.HasValue Then
                Me.CtrlMedico1.ID_Medico = Globales.Usuario.REFMEDICO
                'Me.lb_medico.Text = Me.GetMedico(tb_idmedico.Text)
            End If
        Else
            cb_citaMultiple.Visible = False
        End If

        fCMDataSet = aCMDataSet
        cambios = False

    End Sub
    '-->/////////////////////////////////////

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
    Private Sub cargaLineasEnCMDATASET(ByVal idCita As Integer)
        Dim i As Integer = 0
        Dim oRow As DataRow
        CMDataSet.LineasCitas.Clear()
        For Each oRow In fCMDataSet.LineasCitas.Select("idCita=" & idCita)
            Me.CMDataSet.LineasCitas.ImportRow(oRow)
        Next
    End Sub

    Private Sub Inicializa()



        Dim _data As CMDataSet.CITASDataTable
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            Me.cb_citaMultiple.Visible = True
        Else
            Me.cb_citaMultiple.Visible = False
        End If


        _data = Me.CITASTableAdapter.GetCitaById(fIdCITA)


        If _data.Count > 0 Then
            'Verificar el Proceso de la cita
            'Dim myCita As CMDataSet.CITASRow '= Me.CITASTableAdapter.FillByIDCITA
            If Not _data(0).IsID_ProcesoNull() Then
                lblCitaProcesoInfo.Text = "Esta cita esta vinculada a un proceso"
                IdProceso = _data(0).ID_Proceso
            Else
                lblCitaProcesoInfo.Text = "Esta cita no esta vinculada a ningun proceso"
                IdProceso = Nothing
            End If
        End If


        btnVerProceso.Enabled = IdProceso.HasValue
        btnVerProceso.Visible = Not DesdeFormProceso
        btn_HistorialProcesos.Visible = Not DesdeFormProceso


        Me.LineasCitasTableAdapter.FillByIdCita(CMDataSet.LineasCitas, fIdCITA)
        'End If



        fnotaso = _data.Rows(0).Item("NOTAS").ToString()

        If _data.Rows(0).Item("REFPACIENTE").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            fidpaco = _data.Rows(0).Item("REFPACIENTE").ToString()
            'LLenaCombo(fidpaco)
            CtrlPaciente1.ID_PACIENTE = fidpaco

        Else
            fidpaco = Nothing
        End If

        fpacienteo = _data.Rows(0).Item("PACIENTE").ToString()

        If _data.Rows(0).Item("REFMEDICO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            fidmedicoo = _data.Rows(0).Item("REFMEDICO").ToString()
            HacerTicketToolStripMenuItem.Enabled = True
            tsb_DebitoPaciente.Enabled = True

        Else
            fidmedicoo = Nothing
        End If

        fidformao = _data.Rows(0).Item("REFFORMAPAGO").ToString()

        If _data.Rows(0).Item("REFPROCEDENCIA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            faseguradorao = _data.Rows(0).Item("REFPROCEDENCIA")
            cb_aseguradora.SelectedIndex = BuscaMutua(faseguradorao)
        Else
            faseguradorao = -1
        End If

        'fIdfactura = _data.Rows(0).Item("REFFRA")
        If Not _data.Rows(0).Item("REFFRA").GetType Is GetType(DBNull) Then
            fIdfactura = _data.Rows(0).Item("REFFRA")
            btn_DesasociarFactura.Visible = True
            'bntAsistenteFacturacion.Enabled = False
            bntAsistenteFacturacion.Text = "Cita ya facturada"
            chb_pagada.Enabled = False
        End If


        If Not _data(0).IsREFRECIBONull Then
            freciboo = _data(0).REFRECIBO
            chb_recibo.Checked = True
        Else
            chb_recibo.Checked = False
            freciboo = Nothing
        End If



        fconfirmadao = _data.Rows(0).Item("CONFIRMADA").ToString()
        fatendidao = _data.Rows(0).Item("ATENDIDO").ToString()
        ffaltao = _data.Rows(0).Item("FALTA").ToString()
        fpagadao = _data.Rows(0).Item("PAGADA").ToString()


        '////////////////////////////////////////////
        If _data.Rows(0).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            ffechao = _data.Rows(0).Item("FECHA").ToString()
        Else
            ffechao = DateTime.Now
        End If

        If _data.Rows(0).Item("FECHACOBRO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            ffechacobroo = _data.Rows(0).Item("FECHACOBRO").ToString()
        Else
            ffechacobroo = DateTime.Now
        End If

        If _data.Rows(0).Item("HORA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            fhorainicioo = _data.Rows(0).Item("HORA")
        Else
            fhorainicioo = DateTime.Now
        End If

        If _data.Rows(0).Item("HORAFIN").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            fhorafino = _data.Rows(0).Item("HORAFIN")
        Else
            fhorafino = DateTime.Now
        End If

        If CheckMutua And (faseguradorao > -1 Or cb_aseguradora.Items.Count > 0) Then
            chb_aseguradora.Checked = True
        Else
            chb_aseguradora.Checked = False
        End If

        '-->////////////////////////////////////////////


        fimporteclinicao = _data.Rows(0).Item("IMPORTECL")
        fimportedro = _data.Rows(0).Item("IMPORTEDR")

        Sincmedico = fidmedicoo
        'tb_paciente.Text = fpacienteo
        CtrlMedico1.ID_Medico = fidmedicoo
        'lb_medico.Text = GetMedico(fidmedicoo)
        'lb_especialidad.Text = GetEspecialidad(fidmedicoo)

        Sincfecha = ffechao

        tb_notas.Text = fnotaso
        dtp_fecha.Value = ffechao
        If fidformao <> "" Then
            tb_idforma.Text = fidformao
            lb_forma.Text = GetFormaPago(fidformao)
        End If
        tb_clinica.Text = String.Format("{0:C2}", (fimporteclinicao))
        tb_dr.Text = String.Format("{0:C2}", (fimportedro))
        lb_total.Text = String.Format("{0:C2}", (fimporteclinicao + fimportedro))
        If fconfirmadao = "S" Then
            chb_confirmada.Checked = True
        End If
        If ffaltao = "S" Then
            chb_falta.Checked = True
        End If
        If fatendidao = "S" Then
            chb_atendido.Checked = True
        End If
        If fpagadao = "S" Then
            chb_pagada.Checked = True
        End If

        dtp_fechacobro.Value = ffechacobroo
        dtp_fecha.Value = ffechao
        Dim hora_inicio As String
        Dim hora_fin As String
        If fhorainicioo.Minute >= 10 Then
            hora_inicio = fhorainicioo.Hour.ToString() + ":" + fhorainicioo.Minute.ToString()
        Else
            hora_inicio = fhorainicioo.Hour.ToString() + ":0" + fhorainicioo.Minute.ToString()
        End If
        If fhorafino.Minute >= 10 Then
            hora_fin = fhorafino.Hour.ToString() + ":" + fhorafino.Minute.ToString()
        Else
            hora_fin = fhorafino.Hour.ToString() + ":0" + fhorafino.Minute.ToString()
        End If
        tb_horainicio.Text = hora_inicio
        tb_horafin.Text = hora_fin

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            Dim _datac As CMDataSet.CITASDataTable

            'If fDesdePaciente Then
            '    _datac = New CMDataSet.CITASDataTable()
            '    Dim _rows() As CMDataSet.CITASRow = fCMDataSet.CITAS.Select("REFPACIENTE =" + fidpaco.ToString())
            '    Dim j As Integer

            '    For j = 0 To _rows.Length - 1
            '        _datac.ImportRow(_rows(j))
            '    Next

            'Else
            _datac = Me.CITASTableAdapter.GetDataByPaciente(fidpaco)
            'End If

            Dim _dataf As CMDataSet.FACTURASDataTable

            _dataf = Me.FACTURASTableAdapter.GetFacturaByPaciente(fidpaco)


            Dim _pagada As String
            Dim i As Integer
            Dim cont As Integer = 0
            Dim contf As Integer = 0
            For i = 0 To _datac.Rows.Count - 1
                _pagada = _datac.Rows(i).Item("PAGADA").ToString()
                If _pagada = "N" Then
                    cont = cont + 1
                End If
            Next
            For i = 0 To _dataf.Rows.Count - 1
                _pagada = _dataf.Rows(i).Item("PAGADA").ToString()
                If _pagada = "N" Then
                    contf = contf + 1
                End If
            Next

            Dim dir As String = Application.StartupPath()
            Dim di As DirectoryInfo = Directory.GetParent(dir)
            Dim dip As DirectoryInfo = di.Parent
            Dim direccion As String = dip.FullName
            If cont > 0 Then
                pb_citas.Visible = True
                'pb_citas.Image = Image.FromFile(direccion + "/Resources/Citas.ico")
                ToolTip1.SetToolTip(pb_citas, "Citas pendientes por pagar del paciente: " + cont.ToString())
            End If
            If contf > 0 Then
                pb_facturas.Visible = True
                'pb_facturas.Image = Image.FromFile(direccion + "/Resources/Facturas.ico")
                ToolTip1.SetToolTip(pb_facturas, "Facturas pendientes por pagar del paciente: " + contf.ToString())
            End If

            'btnAddLineasPresupuestoDental.Visible = Globales.Configuracion.Dental_ModuloActivo
        End If

        If CurrentAccion = Enums.Accion.Modificar Or CurrentAccion = Enums.Accion.Ver Then
            CtrlPaciente1.Enabled = False
        End If


        'If CurrentAccion = Enums.Accion.Modificar Then
        Me.CMDataSet.LineasCitas.Columns("idCita").DefaultValue = fIdCITA
        For Each row As DataGridViewRow In dg_LineasCitas.Rows
            If Not row.DataBoundItem Is Nothing Then
                Dim lineaCita As CMDataSet.LineasCitasRow = row.DataBoundItem.Row
                If lineaCita.IsDescuentoPercentNull() Then
                    lineaCita.DescuentoPercent = 0
                End If
                CalculaFila(row, colCantidad.Index)
            End If
        Next
        ' End If


        CalculaTotalesCita()
        CargaHistorias()
        checkFactura()
        'fIdfactura = _data.Rows(0).Item("REFFRA")
        'If Not _data.Rows(0).Item("REFFRA").GetType Is GetType(DBNull) Then

        '    MessageBox.Show("Esta cita tiene asociada una factura, se abrira en modo solo lectura")
        '    For Each c As Control In Me.Controls
        '        c.Enabled = False
        '    Next

        '    ToolStrip1.Enabled = True

        'End If

        ' Dim context As New CMLinqDataContext
        Dim cita As CITA = (From c In context.CITAs
                           Where c.IDCITA = fIdCITA
                           Select c).SingleOrDefault
        cit = cita
        If cita.ID_SALA.HasValue Then
            CtrlSalasvb1.ID_SALA = cita.ID_SALA

        End If

        If fIdfactura.HasValue Then
            bntAsistenteFacturacion.Text = "Ver factura"
            chb_pagada.Enabled = False
            bt_factura.Enabled = False
        End If

        If CurrentAccion = Enums.Accion.Modificar Or CurrentAccion = Enums.Accion.Ver Then
            CargaBDCitas()
        End If

        pnl_Facturar.Visible = Globales.Usuario.EsAdministrador Or _
            RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas) > RoleManager.TipoPermisos.Modificar

        tsm_imprimirjustificante.Visible = Globales.Usuario.EsAdministrador Or _
            RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas) > RoleManager.TipoPermisos.Modificar


        pb_UndoCobrar.Visible = Globales.Usuario.EsAdministrador Or _
            RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas) > RoleManager.TipoPermisos.Modificar


        bt_factura.Visible = pnl_Facturar.Visible
        If cita.PAGADA = "S" Then
            DesactivaTodo()

            If cita.PagadoConCredito Then
                Me.lb_forma.Text = "CREDITO"
            End If

        End If
        If cita.Eliminado Then
            lblCitaEliminada.Visible = True
            DesactivaTodo()
        End If

        ' Me.ContadorBono1.Visible = False
        Me.ContadorBono1.cita = cita
        Me.ContadorBono1.context = context
        Me.cargaSesionesPaciente()


    End Sub

    Private Function BuscaMutua(ByVal idMutua As Integer)
        Dim i As Integer = 0
        For i = 0 To cb_aseguradora.Items.Count - 1
            ' Dim mutua As CMDataSet.MUTUASRow = cb_aseguradora.Items(i)
            If cb_aseguradora.Items(i).CMUTUA = idMutua Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub CargaHistorias()
        Try
            If Me.CtrlPaciente1.ID_PACIENTE.HasValue Then
                Dim context As New CMLinqDataContext()
                Dim idpaciente As Integer = CtrlPaciente1.ID_PACIENTE
                GridEX1.DataSource = Nothing
                HISTORIALEBindingSource.DataSource = Nothing
                Me.HISTORIALEBindingSource.DataSource = From h As HISTORIALE In context.HISTORIALEs Where h.REFPACIENTE = idpaciente And h.Eliminado = False Select h
                GridEX1.DataSource = HISTORIALEBindingSource.DataSource
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CargaFormadePagoPredeterminada(ByVal idPaciente As Integer)
        Dim fpago As Object = Nothing
        If Me.tb_idforma.Text.Trim.Length = 0 Then
            fpago = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select REFFORMAPAGO from PACIENTES WHERE CPACIENTE = " & idPaciente)
            If Not fpago Is Nothing AndAlso Not fpago.GetType Is GetType(DBNull) Then
                Me.tb_idforma.Text = fpago
                Me.tb_idforma_Leave(Nothing, Nothing)
            End If
        End If
    End Sub
    Private Sub CompruebaUltimaHoraDia()
        Dim dtable As CMDataSet.CITASDataTable
        Dim UltimaHora As DateTime
        dtable = Me.CITASTableAdapter.GetCitaByInterval(New Date(ffechao.Date.Year, ffechao.Month, ffechao.Day, 0, 0, 0), New Date(ffechao.Date.Year, ffechao.Month, ffechao.Day, 23, 59, 0))
        If dtable.Rows.Count > 0 Then
            UltimaHora = dtable.Select("", "horafin desc")(0).Item("horafin")
            Me.tb_horainicio.Text = CStr(Format(UltimaHora.Hour, "00") & ":" & Format(UltimaHora.Minute, "00"))

        Else

            Me.tb_horainicio.Text = Format(Globales.Configuracion.DameJornadaLaboralInicio(ffechao), "00") & ":00"
        End If
        'Establezco la hora de final
        Me.tb_horafin.Text = CDate(Me.tb_horainicio.Text).AddMinutes(Globales.Configuracion.citainterval)
    End Sub
    Private Sub CITASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CITASBindingSource.EndEdit()
        Me.CITASTableAdapter.Update(Me.CMDataSet.CITAS)
    End Sub
    Private Function ObtieneConceptoFacturable(ByVal idConcepto As String) As CMDataSet.CONCEPTOSFRARow
        Dim concepto As CMDataSet.CONCEPTOSFRARow
        If Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(idConcepto).Rows.Count > 0 Then
            concepto = Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(idConcepto).Rows(0)
        Else
            Return Nothing
            Exit Function
        End If
        If Not concepto Is Nothing Then
            Return concepto
        Else
            Return Nothing
        End If
    End Function


    Public Sub CargaPaciente(ByVal idPaciente As Integer, ByVal aCurrentAccion As Enums.Accion)
        fPacienteId = idPaciente
        fDesdePaciente = True
        Me.CurrentAccion = aCurrentAccion

        form_citas_Load(Nothing, Nothing)
        LLenaCombo(idPaciente)

    End Sub

    Private Sub form_citas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FreeMemory.FlushMemory()
        'GC.Collect()
    End Sub

    Private Sub form_citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargando = True
        '/////////////////////////////////////
        If fDesdePaciente = True Then

            CtrlPaciente1.ID_PACIENTE = fPacienteId

            CtrlPaciente1.Enabled = False


            HacerTicketToolStripMenuItem.Enabled = True
            tsb_DebitoPaciente.Enabled = True
        End If
        '-->/////////////////////////////////////
        'btnAddLineasPresupuestoDental.Visible = Globales.Configuracion.Dental_ModuloActivo

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
            '///////////////////////////////////////////////////////////////


            'End If


            CtrlMedico1.Enabled = True
            'Me.tb_idmedico.ReadOnly = False



            '/////////////////////////////////////////////////////////////////////
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            CtrlPaciente1.Enabled = False
            'tb_idpaciente.ReadOnly = True
            'tb_paciente.ReadOnly = True
            'tb_idmedico.ReadOnly = True
            CtrlMedico1.Enabled = False

            tb_idforma.ReadOnly = True
            tb_notas.ReadOnly = True
            dtp_fecha.Enabled = False
            'bt_medico.Enabled = False
            'bt_paciente.Enabled = False
            bt_factura.Enabled = False
            'Me.bt_AsignarFra.Enabled = False
            bt_forma.Enabled = False
            cb_aseguradora.Enabled = False
            tb_clinica.ReadOnly = True
            tb_dr.ReadOnly = True
            chb_confirmada.Enabled = False
            chb_falta.Enabled = False
            chb_atendido.Enabled = False
            chb_pagada.Enabled = False
            chb_aseguradora.Enabled = False
            dtp_fechacobro.Enabled = True
            dtp_fecha.Enabled = False
            tb_horainicio.Enabled = False
            tb_horafin.Enabled = False
            Me.ToolStripButton1.Enabled = False

        End If
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            'CompruebaUltimaHoraDia()
            If tb_horafin.Text = "" Then
                dtp_fecha.Value = ffechao
                'Dim fecha As Date = dtp_fecha.Value
                'Dim hora_inicio As String = fecha.Hour.ToString() + ":" + fecha.Minute.ToString()
                'If fecha.Minute < 10 Then
                '    hora_inicio = fecha.Hour.ToString() + ":0" + (fecha.Minute).ToString()

                'End If

                'Dim hora_fin As String
                'If fecha.Minute + fduracion < 60 Then
                '    hora_fin = fecha.Hour.ToString() + ":" + (fecha.Minute + fduracion).ToString()
                'ElseIf fecha.Minute + fduracion >= 70 Then
                '    hora_fin = (fecha.Hour + (fduracion \ 60)).ToString() + ":" + (fecha.Minute + (fduracion Mod 60)).ToString()
                'Else
                '    hora_fin = (fecha.Hour + 1).ToString() + ":" + "0" + (fecha.Minute + (fduracion Mod 60)).ToString().Substring((fecha.Minute).ToString().Length - 1)
                'End If
                'tb_horafin.Text = hora_fin

            End If

            If Not DesdeCalendario Then
                tb_horainicio.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day).Add(Globales.Configuracion.DameJornadaLaboralInicio(Date.Now))
                tb_horafin.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day).Add(Globales.Configuracion.DameJornadaLaboralInicio(Date.Now)).AddMinutes(15)
            End If

            'Me.tb_idmedico.ReadOnly = False
            CtrlMedico1.Enabled = True
            'Queda pendiente cargar medico como usuario inscrito

            If Not MutuaPreseleccionada Is Nothing Then
                cb_aseguradora.SelectedItem = MutuaPreseleccionada
            End If


            If Not IdProceso.HasValue Then
            Else
                lblCitaProcesoInfo.Text = "Esta cita esta vinculada a un proceso"
                btnVerProceso.Enabled = True

                btnVerProceso.Visible = Not DesdeFormProceso
                btn_HistorialProcesos.Visible = Not DesdeFormProceso
            End If

            chb_pagada.Enabled = False
        End If


        'Aplico permisos referentes a poder ver o no los importes de cobra la clinica y el doctor que atiende la cita.
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Ninguno Then
            Me.grpImporte.Visible = False
            Me.colImporteClinica.Visible = False
            Me.colImporteDoctor.Visible = False
            Me.dg_LineasCitas.Columns("Total").Visible = False

            dg_LineasCitas.Columns("colImporteClinica").Visible = False
            dg_LineasCitas.Columns("colImporteDoctor").Visible = False
            dg_LineasCitas.Columns("DescuentoPercent").Visible = False
            dg_LineasCitas.Columns("ColumnDtoImp").Visible = False
            dg_LineasCitas.Columns("Total").Visible = False

        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Asistente_Facturacion) = RoleManager.TipoPermisos.Ninguno Then
            'Me.bntAsistenteFacturacion.Visible = False
            ' Me.bt_factura.Visible = False
        End If


        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Lectura Then
            Me.grpImporte.Visible = True
            Me.grpImporte.Enabled = False
            Me.colImporteClinica.Visible = True
            Me.colImporteClinica.ReadOnly = True
            Me.colImporteDoctor.Visible = True
            Me.colImporteDoctor.ReadOnly = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Modificar Or _
        RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Total Then
            Me.grpImporte.Visible = True
            Me.grpImporte.Enabled = True
            Me.colImporteClinica.Visible = True
            Me.colImporteClinica.ReadOnly = False
            Me.colImporteDoctor.Visible = True
            Me.colImporteDoctor.ReadOnly = False
        End If

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno Then
            Me.tsb_DebitoPaciente.Visible = False
        End If

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Me.HacerTicketToolStripMenuItem.Visible = False
        End If

        cargando = False
        Me.CtrlPaciente1.Focus()

        Me.cambios = False
        Me.group_Proceso.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.GroupBox1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.grpFechaHora.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.grpImporte.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.ToolStrip1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.CtrlPaciente1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.CtrlMedico1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.dg_LineasCitas.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.Panel1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.bt_actualiza_cbMutuas.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        Me.bt_AddHistoria.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        bt_AddLinea.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        bt_DelLinea.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        GridEX1.Enabled = Globales.Usuario.Permisos(RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura

        CtrlSalasvb1.Visible = Globales.Configuracion.Cita_UsarSalas
        Label15.Visible = Globales.Configuracion.Cita_UsarSalas

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Dim context As New CMLinqDataContext()
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = fIdCITA Select c).SingleOrDefault()

            If Not cita Is Nothing Then
                chb_pagada.Enabled = Not (cita.PAGADA = "S")
            End If
        End If


        If chb_pagada.Checked Or fIdfactura.HasValue Then
            'Esta pagada solo los admins pueden modificarla
            If Not Globales.Usuario.EsAdministrador Then
                'MessageBox.Show("Edición desactivada excepto para el administrador")
                'lblEdicionDesactivada.Visible = True
                'lblEdicionDesactivada.BringToFront()
                'DesactivaTodo()
                'lblEdicionDesactivada.Enabled = True

                If fIdfactura.HasValue Then
                    'bntAsistenteFacturacion.Enabled = False
                Else
                    grpImporte.Enabled = True
                    bntAsistenteFacturacion.Enabled = True
                End If
            Else
                lblEdicionDesactivada.Visible = True
                Dim texto As String = ""
                If (fIdfactura.HasValue) Then
                    texto = "Los cambios efectuados no afectarán a Facturas vinculadas"
                End If
                If (chb_pagada.Checked) Then
                    If texto.Trim.Length > 0 Then texto += vbCrLf
                    texto += "Esta cita ha sido pagada y por lo tanto no se puede editar, consulte a su administrador"
                End If
                lblEdicionDesactivada.BringToFront()

            End If
        End If

        If fIdfactura.HasValue Then
            bntAsistenteFacturacion.Text = "Ver factura"
            bntAsistenteFacturacion.Enabled = True
            chb_pagada.Enabled = False
            bt_factura.Enabled = False
        End If

        'colImporteDoctor.Visible = colImporteDoctor.Visible And Not Globales.Configuracion.Citas_Medico_OcultarColumna

        If Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas Then

            'dg_LineasCitas.Columns(colImporteDoctor.Index).DefaultCellStyle.BackColor = Color.LightGray
        End If

        dg_LineasCitas.Columns(colImporteDoctor.Index).ReadOnly = Not (Globales.Usuario.Permisos(RoleManager.Items.Citas_ModificarImporteMedico) > RoleManager.TipoPermisos.Lectura)
        ChequeaFechaDiaDisponible()

    End Sub

    Private Sub DesactivaTodo()
        For Each c As Control In Me.Controls
            c.Enabled = False
            For Each c2 As Control In c.Controls
                c2.Enabled = False
                For Each c3 As Control In c2.Controls
                    c3.Enabled = False
                Next
            Next
        Next
        Me.ToolStripLabel1.Enabled = False
        Me.dg_LineasCitas.ReadOnly = True
        Me.pb_UndoCobrar.Enabled = True
        Me.pnl_Facturar.Enabled = True
        Me.bt_factura.Enabled = True
        Me.btn_DesasociarFactura.Enabled = True
        Me.ToolStripLabel1.Enabled = True 'boton guardar
        Me.bt_AddLinea.Visible = False
        Me.bt_DelLinea.Visible = False
        Me.btnAddLineasGenericas.Visible = False
        Me.colBuscar.Visible = False



    End Sub

    Private Function GetMutua(ByVal aId As Integer) As String
        If aId <> 0 Then
            Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(aId)

            Dim _mutua As String = _data.Rows(0).Item("NOMBRE").ToString()
            Return _mutua
        End If
        Return ""
    End Function

    Private Function GetEmpresa(ByVal aId As Integer) As String
        If aId <> 0 Then
            Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(aId)

            Dim _emp As String = _data.Rows(0).Item("NOMBRE").ToString()
            Return _emp
        End If
        Return ""
    End Function
    Private Sub checkFactura()
        Dim _dataf As CMDataSet.FACTURASDataTable


        'If fDesdePaciente Then
        '    _dataf = New CMDataSet.FACTURASDataTable()
        '    Dim _rows() As CMDataSet.FACTURASRow = fCMDataSet.FACTURAS.Select("IDFACTURA =" & fIdfactura)
        '    If _rows.Length > 0 Then
        '        _dataf.ImportRow(_rows(0))
        '    End If
        'Else
        If fIdfactura.HasValue Then
            _dataf = FACTURASTableAdapter.GetFacturaById(fIdfactura)
            If _dataf.Rows.Count > 0 Then
                'bt_factura.Visible = False
                btn_DesasociarFactura.Visible = True
                pnl_Facturar.Visible = True
                'bt_modificar.Visible = True
                lb_factura.Visible = True
                lb_ftexto.Visible = True
                fIdfactura = _dataf.Rows(0).Item("IDFACTURA")
                If Not _dataf(0).IsNUMERONull Then
                    lb_ftexto.Text = _dataf.Rows(0).Item("NUMERO")
                Else
                    lb_ftexto.Text = String.Empty
                End If

            End If
        End If
    End Sub
    Private Sub Cancelar()
        clickaccept = True
        If Me.CurrentAccion = Enums.Accion.Insertar And fIdfactura.HasValue Then

            'FACTURASTableAdapter.DeleteById(fIdfactura.Value)

        End If
        Me.Close()
    End Sub

    Private Function GetPaciente(Optional ByVal aId As Integer = -1, Optional ByVal codprop As String = "") As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        If aId = -1 And codprop.Trim.Length = 0 Then
            MsgBox("debe indicar un codigo de paciente", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        If codprop.Trim.Length > 0 Then
            _data = Me.PACIENTESTableAdapter.GetDataByCodProp(codprop)
        Else
            _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        End If
        '    End If

        If _data.Rows.Count > 0 Then
            Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
            Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
            Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
            Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename

            If Not _data.Rows(0).Item("CPACIENTE").GetType Is GetType(DBNull) Then
                Me.CtrlPaciente1.ID_PACIENTE = _data.Rows(0).Item("CPACIENTE")
                aId = Me.CtrlPaciente1.ID_PACIENTE
            End If

            CompruebaDeudas(aId)
            Me.CargaHistorias()
            Return _paciente
        Else
            If cargando = False Then
                CtrlPaciente1.ID_PACIENTE = Nothing
                CtrlPaciente1.Focus()
                MessageBox.Show("No existe un paciente con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        'Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
        'Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        'Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        'Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename

        'CompruebaDeudas(aId)
        'Me.CargaHistorias()
        'Return _paciente
        HacerTicketToolStripMenuItem.Enabled = True
        tsb_DebitoPaciente.Enabled = True

    End Function
    Private Function GetPacienteDNI(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _DNI As String = _data.Rows(0).Item("DNI").ToString()
        Return _DNI

    End Function
    Private Function GetPacienteCP(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _CP As String = _data.Rows(0).Item("CP").ToString()
        Return _CP

    End Function
    Private Function GetPacienteRefMutua(ByVal aId As Integer) As Integer

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _mutua As Integer
        If _data.Rows(0).Item("REFMUTUA").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
            _mutua = _data.Rows(0).Item("REFMUTUA").ToString()
        End If
        Return _mutua

    End Function
    Private Function GetPacienteRefEmpresa(ByVal aId As Integer) As Integer

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _emp As Integer
        If _data.Rows(0).Item("REFEMPRESA").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
            _emp = _data.Rows(0).Item("REFEMPRESA")
        End If
        Return _emp

    End Function
    Private Function GetPacienteLocalidad(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _loc As String = _data.Rows(0).Item("LOCALIDAD").ToString()
        Return _loc

    End Function
    Private Function GetPacienteProvincia(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _prov As String = _data.Rows(0).Item("PROVINCIA").ToString()
        Return _prov

    End Function
    Private Function GetPacienteDireccion(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.PACIENTESDataTable()
        '    _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        'Else
        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        'End If

        Dim _dir As String = _data.Rows(0).Item("DOMICILIO").ToString()
        Return _dir

    End Function


    Private Function GetEspecialidad(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MEDICOSDataTable = Me.MEDICOSTableAdapter.GetMedicoByID(aId)
        Dim _medespecialidad As String = ""
        If _data.Rows.Count > 0 Then
            _medespecialidad = _data.Rows(0).Item("ESPECIALIDAD").ToString()
        End If

        Return _medespecialidad

    End Function
    Private Function GetFormaPago(ByVal aId As String) As String

        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(aId)
        Dim _forma As String = ""
        If _data.Rows.Count > 0 Then
            _forma = _data.Rows(0).Item("DESCRIPCION").ToString()
        End If

        Return _forma

    End Function

    Private Sub bt_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _name As String = "Listado de pacientes"
        Dim _listados As form_listados = New form_listados(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes, True)
        _listados.ShowInTaskbar = False
        'busca por codpropio o cod del programa
        '_listados.Listado_control.codpropio = cb_codpropio.Checked
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            'MessageBox.Show(_listados.Selected())
            CtrlPaciente1.ID_PACIENTE = _pcodo.ToString()
            Me.CargaFormadePagoPredeterminada(_pcodo)
            GetPaciente(_pcodo)
            HacerTicketToolStripMenuItem.Enabled = True
            tsb_DebitoPaciente.Enabled = True
            LLenaCombo(_pcodo)
            fPacienteId = _pcodo
        End If
    End Sub
    Private Sub CompruebaDeudas(ByVal CodigoPaciente As Integer)
        Dim _pcodo As Integer = CodigoPaciente
        Dim _data As CMDataSet.CITASDataTable = Me.CITASTableAdapter.GetDataByPaciente(_pcodo)
        Dim _dataf As CMDataSet.FACTURASDataTable = Me.FACTURASTableAdapter.GetFacturaByPaciente(_pcodo)
        Dim _pagada As String
        Dim i As Integer
        Dim cont As Integer = 0
        Dim contf As Integer = 0
        For i = 0 To _data.Rows.Count - 1
            _pagada = _data.Rows(i).Item("PAGADA").ToString()
            If _pagada = "N" Then
                cont = cont + 1
            End If
        Next
        For i = 0 To _dataf.Rows.Count - 1
            _pagada = _dataf.Rows(i).Item("PAGADA").ToString()
            If _pagada = "N" Then
                contf = contf + 1
            End If
        Next
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        If cont > 0 Then
            pb_citas.Image = My.Resources.Citas
            ToolTip1.SetToolTip(pb_citas, "Citas pendientes por pagar del paciente: " + cont.ToString())
        Else
            pb_citas.Image = Nothing
        End If
        If contf > 0 Then
            pb_facturas.Image = My.Resources.Facturas
            ToolTip1.SetToolTip(pb_facturas, "Facturas pendientes por pagar del paciente: " + contf.ToString())
        Else
            pb_facturas.Image = Nothing
        End If

    End Sub

    'Private Sub bt_medico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
    '    Dim _name As String = "Listado de medicos"
    '    Dim _listados As form_listados = New form_listados(_name, MEDICOSBindingSource, RoleManager.Items.Medicos, True)
    '    _listados.ShowInTaskbar = False
    '    _listados.ShowDialog()
    '    If _listados.Selected() <> "" Then
    '        Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
    '        tb_idmedico.Text = _pcodo.ToString()
    '        lb_medico.Text = GetMedico(_pcodo)
    '        lb_especialidad.Text = GetEspecialidad(_pcodo)
    '    End If
    'End Sub

    Private Sub bt_forma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_forma.Click
        'Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)
        Dim _name As String = "Listado de formas de pago"
        Dim fpago As New frmFormasDePago
        'Dim _listados As form_listados = New form_listados(_name, FORMASPAGOBindingSource, RoleManager.Items.Formas_de_Pago, True)

        fpago.ShowInTaskbar = False
        fpago.Modo = Globales.ModoParaFormas.Seleccion
        fpago.ShowDialog()

        If Not fpago.FormaPago Is Nothing Then
            Dim _pcodo As String = fpago.FormaPago.CODIGO
            tb_idforma.Text = _pcodo
            lb_forma.Text = fpago.FormaPago.DESCRIPCION
        End If
    End Sub


    Private Function Guardar() As Boolean

        CITASBindingSource.EndEdit()
        dg_LineasCitas.EndEdit()
        CalculaTotalesCita()

        Dim idCitaTrasInsertar As Integer

        If Not ValidaSalvado() Then
            Return False
        End If

        Dim total As Double = 0
        Try
            total = Double.Parse(lb_total.Text, System.Globalization.NumberStyles.Currency)
        Catch ex As Exception

        End Try

        If CBcitas.SelectedItem = "Cita Sucesiva" Then citas = Nothing
        If CBcitas.SelectedItem = "3ra Cita" Then citas = 3
        If CBcitas.SelectedItem = "2da Cita" Then citas = 2
        If CBcitas.SelectedItem = "1ra Cita" Then citas = 1

        If citas <> cambioCT And Me.CurrentAccion = Enums.Accion.Modificar Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Cambio_de_tipo_de_Cita, RoleManager.Items.Citas, "Citas", fIdCITA.ToString(), CtrlPaciente1.NombreCompleto)
        End If

        If citas <> cambioCT And Me.CurrentAccion = Enums.Accion.Insertar Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Cambio_de_tipo_de_Cita, RoleManager.Items.Citas, "Citas", fIdCITA.ToString(), CtrlPaciente1.NombreCompleto)
        End If

        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _notas As String = tb_notas.Text.Trim()
            Dim _idpac As Integer
            Dim _idmedico As Integer


            If Not IdProceso.HasValue Then
                'Verificacion del Proceso
                Dim procesos As CM3DataSet.N_Procesos_ResumenDataTable = ProcesosDePaciente(CtrlPaciente1.ID_PACIENTE.Value)
                If procesos.Count > 0 Then
                    If MessageBox.Show("Este paciente tiene proceso(s) abierto(s). ¿Desea vincular esta cita a algun proceso?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        btn_HistorialProcesos_Click(Nothing, Nothing)
                    Else
                        IdProceso = Nothing
                    End If
                End If
            End If

            _idpac = CtrlPaciente1.ID_PACIENTE

            Dim _paciente As String = CtrlPaciente1.NombreCompleto
            If CtrlMedico1.ID_Medico.HasValue Then
                _idmedico = CtrlMedico1.ID_Medico
            Else
                MessageBox.Show("Debe entrar un medico válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Dim tipodia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(CtrlMedico1.ID_Medico, dtp_fecha.Value)
            Dim fueraHorario As Boolean = False
            If tipodia <> ctrlHorarios.TipoFecha.DiasLaborables Then
                'If Globales.Usuario.EsAdministrador And Globales.Usuario.REFMEDICO = CtrlMedico1.ID_Medico Then
                'Else

                If MessageBox.Show("La fecha/hora seleccionada es no laborable para este médico. ¿Desea crear la cita de todas formas?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    'Return True
                    fueraHorario = True
                Else
                    Return False
                End If

                'End If
            End If

            'If tipodia = ctrlHorarios.TipoFecha.Fiestas Then
            '    MessageBox.Show("La fecha seleccionada es no laborable para este médico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return False
            'End If

            Dim _idforma As String
            If tb_idforma.Text.Trim() <> "" Then
                _idforma = tb_idforma.Text.Trim()
            Else
                _idforma = Nothing
            End If
            Dim _confirmada As String
            Dim _atendida As String
            Dim _falta As String
            Dim _pagada As String
            If chb_confirmada.Checked Then
                _confirmada = "S"
            Else : _confirmada = "N"
            End If
            If chb_pagada.Checked Then
                _pagada = "S"
            Else : _pagada = "N"
            End If
            If chb_falta.Checked Then
                _falta = "S"
            Else : _falta = "N"
            End If
            If chb_atendido.Checked Then
                _atendida = "S"
            Else : _atendida = "N"
            End If
            Dim _fecha As Date = dtp_fecha.Value.Date
            Dim _fechacobro As Date = dtp_fechacobro.Value.Date
            Dim _horainicios As String = tb_horainicio.Text.Trim()
            Dim _horafins As String = tb_horafin.Text.Trim()
            Dim _inicio As Date
            Dim _fin As Date
            Try
                Dim _horainicio As Date = DateAndTime.TimeValue(_horainicios)
                _inicio = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horainicio.Hour, _horainicio.Minute, 0)
            Catch ex As Exception
                MessageBox.Show("La hora inicial está en un formato incorrecto. Debe tener el formato hh:mm", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End Try

            Try
                Dim _horafin As Date = DateAndTime.TimeValue(_horafins)
                _fin = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horafin.Hour, _horafin.Minute, 0)
            Catch ex As Exception
                MessageBox.Show("La hora final está en un formato incorrecto. Debe tener el formato hh:mm", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End Try
            Dim _importeclinica As Double = Double.Parse(tb_clinica.Text.Trim(), Globalization.NumberStyles.Currency)
            Dim _importedr As Double = Double.Parse(tb_dr.Text.Trim(), Globalization.NumberStyles.Currency)

            Dim _idmutua As Nullable(Of Integer) = Nothing
            If chb_aseguradora.Checked = True Then
                If cb_aseguradora.SelectedIndex > -1 Then
                    _idmutua = cb_aseguradora.SelectedItem.CMUTUA
                End If
            End If



            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If freciboo.HasValue Then
                    Dim _dataRecibo As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetDataByNumero(freciboo)
                    If chb_recibo.Checked Then

                        Dim _refformapago As String = tb_idforma.Text
                        Dim _dataCita As CMDataSet.CITASDataTable = CITASTableAdapter.GetData()
                        Dim _refCita As Integer = Integer.Parse(_dataCita.Rows(_dataCita.Rows.Count - 1).Item("IDCITA").ToString())
                        Dim _dataPaciente As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_idpac)
                        Dim _direccion As String = _dataPaciente.Rows(0).Item("DOMICILIO").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + _dataPaciente.Rows(0).Item("CP").ToString() + " - " + _dataPaciente.Rows(0).Item("LOCALIDAD").ToString() + " (" + _dataPaciente.Rows(0).Item("PROVINCIA").ToString() + ")"
                        Dim _entidad As String = _dataPaciente.Rows(0).Item("ENTIDAD").ToString()
                        Dim _oficina As String = _dataPaciente.Rows(0).Item("OFICINA").ToString()
                        Dim _dc As String = _dataPaciente.Rows(0).Item("DC").ToString()
                        Dim _cuenta As String = _dataPaciente.Rows(0).Item("CUENTA").ToString()

                        If _refformapago <> "" Then
                            RECIBOSTableAdapter.UpdateValoresSinEmpresa(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToString("dd/mm/yyyy"), Nothing, "N", _refformapago, "G", freciboo)
                        Else
                            RECIBOSTableAdapter.UpdateValoresSinEmpresaYFormaPago(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToString("dd/mm/yyyy"), Nothing, "N", "G", freciboo)
                        End If

                    ElseIf _dataRecibo.Rows(0).Item("TIPO").ToString() = "G" Then
                        RECIBOSTableAdapter.DeleteByNumero(freciboo)
                        freciboo = Nothing
                    Else
                        freciboo = Nothing
                    End If
                Else

                    If chb_recibo.Checked Then
                        Dim _refformapago As String = tb_idforma.Text
                        Dim _refCita As Integer = fIdCITA
                        Dim _dataPaciente As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_idpac)
                        Dim _direccion As String = _dataPaciente.Rows(0).Item("DOMICILIO").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + _dataPaciente.Rows(0).Item("CP").ToString() + " - " + _dataPaciente.Rows(0).Item("LOCALIDAD").ToString() + " (" + _dataPaciente.Rows(0).Item("PROVINCIA").ToString() + ")"
                        Dim _entidad As String = _dataPaciente.Rows(0).Item("ENTIDAD").ToString()
                        Dim _oficina As String = _dataPaciente.Rows(0).Item("OFICINA").ToString()
                        Dim _dc As String = _dataPaciente.Rows(0).Item("DC").ToString()
                        Dim _cuenta As String = _dataPaciente.Rows(0).Item("CUENTA").ToString()

                        If _refformapago <> "" Then
                            RECIBOSTableAdapter.InsertSinEmpresa(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToShortDateString(), Nothing, "N", _refformapago, "G")
                        Else
                            RECIBOSTableAdapter.InsertSinEmpresaYFormaPago(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToShortDateString(), Nothing, "N", "G")
                        End If

                        Dim _dataRecibo As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetData()
                        freciboo = Integer.Parse(_dataRecibo.Rows(_dataRecibo.Rows.Count - 1).Item("NUMERO").ToString())

                    End If
                End If

                'Me.CITASBindingSource.EndEdit()
                Dim descuento As Double = 0
                Try
                    descuento = Double.Parse(txtDescuentoTotal.Text, System.Globalization.NumberStyles.Currency)
                Catch ex As Exception

                End Try


                Dim n As Integer = Me.CITASTableAdapter.Update1(_idpac, _fecha, _inicio, _confirmada, _notas, _idmedico, _paciente, _importedr, _importeclinica, "N", _falta, "", _pagada, freciboo, _atendida, fIdfactura, _idforma, _fin, _fechacobro, _idmutua, IdProceso, Nothing, Nothing, descuento, CtrlSalasvb1.ID_SALA, total, citas, fIdCITA)

                'este update es solo para el descuento,  ineficiente pero el VS2010 no me deja modificar el dataset
                'Try
                '    Dim context As New CMLinqDataContext()
                '    Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = fId Select c).SingleOrDefault()
                '    cita.Descuento = Double.Parse(txtDescuentoTotal.Text, System.Globalization.NumberStyles.Currency)
                '    context.SubmitChanges()
                'Catch ex As Exception

                'End Try



                If fIdfactura.HasValue Then
                    FACTURASTableAdapter.UpdateRefCita(fIdCITA, fIdfactura)
                End If

                '** GUARDO LAS LINEAS DE LAS CITAS CUANDO LA CITA NO ES ABIERTA DESDE EL FORM DE PACIENTES ***
                'al no provenir desde el paciente actualizo directamente el cmdataset
                Me.LineasCitasBindingSource.CurrencyManager.EndCurrentEdit()
                Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
                Me.CMDataSet.LineasCitas.AcceptChanges()

            Else

                'ponemos las citas multiples
                If cb_citaMultiple.Checked = True Then
                    CitaMultiple()

                    'Me.Historiales_BindingSource1.CurrencyManager.EndCurrentEdit()
                    'Me.HISTORIALESTableAdapter.Update(Me.CMDataSet.HISTORIALES)
                    'Me.CMDataSet.HISTORIALES.AcceptChanges()

                    'Globals.CobroEnCascada(, , , Me.fId)

                    clickaccept = True
                    Me.Close()
                    Return False
                End If


                If chb_recibo.Checked Then
                    Dim _refformapago As String = tb_idforma.Text
                    Dim _dataCita As CMDataSet.CITASDataTable = CITASTableAdapter.GetData()
                    Dim _refCita As Integer = Integer.Parse(_dataCita.Rows(_dataCita.Rows.Count - 1).Item("IDCITA").ToString())
                    Dim _dataPaciente As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_idpac)
                    Dim _direccion As String = _dataPaciente.Rows(0).Item("DOMICILIO").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + _dataPaciente.Rows(0).Item("CP").ToString() + " - " + _dataPaciente.Rows(0).Item("LOCALIDAD").ToString() + " (" + _dataPaciente.Rows(0).Item("PROVINCIA").ToString() + ")"
                    Dim _entidad As String = _dataPaciente.Rows(0).Item("ENTIDAD").ToString()
                    Dim _oficina As String = _dataPaciente.Rows(0).Item("OFICINA").ToString()
                    Dim _dc As String = _dataPaciente.Rows(0).Item("DC").ToString()
                    Dim _cuenta As String = _dataPaciente.Rows(0).Item("CUENTA").ToString()

                    If _refformapago <> "" Then
                        RECIBOSTableAdapter.InsertSinEmpresa(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToShortDateString(), Nothing, "N", _refformapago, "G")
                    Else
                        RECIBOSTableAdapter.InsertSinEmpresaYFormaPago(Nothing, "N", "N", _refCita, Nothing, (_importedr + _importeclinica), _idpac, Nothing, _paciente, _direccion, "", "", _entidad, _oficina, _dc, _cuenta, "Cobro de Cita Fecha " + _fecha.ToShortDateString(), Nothing, "N", "G")
                    End If

                    Dim _dataRecibo As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetData()
                    freciboo = Integer.Parse(_dataRecibo.Rows(_dataRecibo.Rows.Count - 1).Item("NUMERO").ToString())

                End If
                Me.CITASBindingSource.EndEdit()
                Me.CITASTableAdapter.Insert(_idpac, _fecha, _inicio, _confirmada, _notas, _idmedico, _paciente, _importedr, _importeclinica, "N", _falta, "", _pagada, freciboo, _atendida, fIdfactura, _idforma, _fin, _fechacobro, _idmutua, IdProceso, Nothing, Nothing, txtDescuentoTotal.Text, CtrlSalasvb1.ID_SALA, total, 0, False, citas)

                idCitaTrasInsertar = CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA")

                If Me.CurrentAccion = Enums.Accion.Insertar Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Citas, "Citas", idCitaTrasInsertar.ToString(), CtrlPaciente1.NombreCompleto)
                End If

                '** GUARDO LAS LINEAS DE LAS CITAS CUANDO LA CITA NO ES ABIERTA DESDE EL FORM DE PACIENTES ***
                'actualizo el id de las lineas citas con el nuevo id de la cita
                Dim i As Integer = 0
                For i = 0 To Me.CMDataSet.LineasCitas.Rows.Count - 1
                    Me.CMDataSet.LineasCitas.Rows(i).Item("IdCita") = idCitaTrasInsertar
                Next
                Me.LineasCitasBindingSource.CurrencyManager.EndCurrentEdit()
                Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
                Me.CMDataSet.LineasCitas.AcceptChanges()




                If fIdfactura.HasValue Then
                    FACTURASTableAdapter.UpdateRefCita(CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA"), fIdfactura)
                End If
            End If

            'Me.Historiales_BindingSource1.CurrencyManager.EndCurrentEdit()
            'Me.HISTORIALESTableAdapter.Update(Me.CMDataSet.HISTORIALES)
            'Me.CMDataSet.HISTORIALES.AcceptChanges()

            If fIdCITA <> 0 Then
                Globales.CobroEnCascada(, , , Me.fIdCITA)
            End If


            clickaccept = True

            'Dim _Mydata As CMDataSet.CITASDataTable
            '_Mydata = Me.CITASTableAdapter.GetCitaById(fId)
            'If _Mydata.Count > 0 Then
            '    _Mydata(0).ID_Proceso = idProceso
            '    _Mydata.AcceptChanges()
            'CITASBindingSource.EndEdit()
            'Dim p As Integer = CITASTableAdapter.Update(CMDataSet.CITAS)
            'End If


            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Citas, "Citas", fIdCITA.ToString(), CtrlPaciente1.NombreCompleto)
            End If


            'Salvar las lineas de presupuestos dentales y la Sala
            Try

                'Dim context As New CMLinqDataContext()
                Dim idCita As Integer = fIdCITA
                If idCita = 0 Then
                    idCita = idCitaTrasInsertar
                End If

                Dim cita As CITA = (From c In context.CITAs
                                   Where c.IDCITA = idCita
                                   Select c).SingleOrDefault()

                If Not cita Is Nothing Then
                    cita.ID_SALA = CtrlSalasvb1.ID_SALA
                    cita.TOTAL = total
                    If fueraHorario Then
                        cita.TipoCita = 2
                    Else
                        cita.TipoCita = 0
                    End If

                    context.SubmitChanges()

                    'Me.ContadorBono1.Visible = False
                    Me.ContadorBono1.cita = cita
                    'Me.ContadorBono1.context = context
                    Me.cargaSesionesPaciente()


                End If


                For Each lineacita As CMDataSet.LineasCitasRow In CMDataSet.LineasCitas
                    If Not lineacita.IsRefLineaPresupuestoDentalNull Then
                        'Actualizar el presupuesto correspondiente                     
                        Dim lineaPresupuesto As d_PresupuestoLinea = (From l In context.d_PresupuestoLineas Where l.IDPresupuestoLinea = lineacita.RefLineaPresupuestoDental Select l).SingleOrDefault()
                        If Not lineaPresupuesto Is Nothing Then
                            If fIdCITA = 0 Then
                                lineaPresupuesto.IDCITA = idCitaTrasInsertar
                            Else
                                lineaPresupuesto.IDCITA = fIdCITA
                            End If
                        End If
                    End If

                    'Lineas de Tratamiento
                    If Not lineacita.IsRefLineaTratamientoNull Then
                        Dim lineaTratamiento As LCOMPARATIVAS_TRATAMIENTO = (From lin In context.LCOMPARATIVAS_TRATAMIENTOs Where lin.ID = lineacita.RefLineaTratamiento Select lin).SingleOrDefault
                        If Not lineaTratamiento Is Nothing Then
                            If fIdCITA = 0 Then
                                lineaTratamiento.ID_Cita = idCitaTrasInsertar
                                lineaTratamiento.ID_LineaCita = lineacita.IdCita
                            Else
                                lineaTratamiento.ID_Cita = fIdCITA
                                lineaTratamiento.ID_LineaCita = lineacita.IdCita
                            End If
                            lineaTratamiento.Facturada = True
                        End If

                    End If
                Next
                If idCitaTrasInsertar <> 0 Then fIdCITA = idCitaTrasInsertar
                context.SubmitChanges()

            Catch ex As Exception
            End Try

            CitasModificadas = New List(Of CitaKey)

            If (Sincfecha <> _fecha Or Sincmedico <> _idmedico) And Not CurrentAccion = Enums.Accion.Insertar Then
                AddCitasModificadas(Sincfecha, Sincmedico)
            End If

            AddCitasModificadas(_fecha, _idmedico)
            If CitasModificadas.Count > 0 Then
                If Not BackgroundWorker1.IsBusy Then
                    BackgroundWorker1.RunWorkerAsync()
                End If
            End If
        End If
        'Como es posible qeu se llame al guardar y no se cierre, lo que hacemos es qeu si se ha producido un insertar modificamos el currentaction de insertar a modificar
        If CurrentAccion = Enums.Accion.Insertar Then
            Me.CurrentAccion = Enums.Accion.Modificar
        End If

        Return True
        'Me.Close()
    End Function

    Private Sub AddCitasModificadas(_fecha As Date, _idmedico As Integer)

        If _fecha > Date.Now.AddDays(-7) Then
            Dim USUARIO As USUARIO = (From u In context.USUARIOs Select u Where u.REFMEDICO = _idmedico).FirstOrDefault
            If Not USUARIO Is Nothing And Globales.Configuracion.SincCalendCitaFtp Then
                Dim newcita As New CitaKey(_fecha.ToString("yyyy-MM-dd"), _idmedico)
                CitasModificadas.Add(newcita)
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Cita As New CITA
        For Each ModCitas As CitaKey In CitasModificadas
            Cita.SincronizarMedicoCitas(ModCitas.CitaFecha, ModCitas.CitaMedico)
        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Function Is_CitaDay(ByVal aday As Date) As Boolean
        Dim day As Integer = DateAndTime.Weekday(aday, FirstDayOfWeek.Sunday)
        If day = 1 And chb_dom.Checked = True Then
            Return True
        ElseIf day = 2 And chb_lun.Checked = True Then
            Return True
        ElseIf day = 3 And chb_mar.Checked = True Then
            Return True
        ElseIf day = 4 And chb_mier.Checked = True Then
            Return True
        ElseIf day = 5 And chb_jue.Checked = True Then
            Return True
        ElseIf day = 6 And chb_vie.Checked = True Then
            Return True
        ElseIf day = 7 And chb_sab.Checked = True Then
            Return True
        Else : Return False
        End If
    End Function

    Private Sub CitaMultiple()

        Dim total As Double = 0
        Try
            total = Double.Parse(lb_total.Text, System.Globalization.NumberStyles.Currency)
        Catch ex As Exception

        End Try

        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _notas As String = tb_notas.Text.Trim()
            Dim _idpac As Integer
            If CtrlPaciente1.ID_PACIENTE.HasValue Then
                _idpac = CtrlPaciente1.ID_PACIENTE.Value
            Else
                MessageBox.Show("Debe entrar un paciente válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim _paciente As String = CtrlPaciente1.NombreCompleto.Trim()
            Dim _idmedico As Integer
            If CtrlMedico1.ID_Medico.HasValue Then
                _idmedico = CtrlMedico1.ID_Medico
            Else
                MessageBox.Show("Debe entrar un medico válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim _idforma As String
            If tb_idforma.Text.Trim() <> "" Then
                _idforma = tb_idforma.Text.Trim()
            Else
                _idforma = Nothing
            End If
            Dim _fecha As Date = dtp_fechacm.Value.Date
            Dim _fechafinal As Date = dtp_final.Value.Date
            Dim _horainicios As String = tb_horainiciocm.Text.Trim()
            Dim _horafins As String = tb_horafincm.Text.Trim()
            Dim _inicio As Date
            Dim _fin As Date
            Dim _horainicio As Date

            _horainicio = DateAndTime.TimeValue(_horainicios)
            _inicio = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horainicio.Hour, _horainicio.Minute, 0)

            Dim _horafin As Date

            _horafin = DateAndTime.TimeValue(_horafins)
            _fin = New Date(_fechafinal.Year, _fechafinal.Month, _fechafinal.Day, _horafin.Hour, _horafin.Minute, 0)

            Dim _importeclinica As Double
            Dim _importedr As Double
            If tb_clinica.Text <> "" Then
                _importeclinica = Double.Parse(tb_clinica.Text.Trim(), Globalization.NumberStyles.Currency)
            End If
            If tb_dr.Text <> "" Then
                _importedr = Double.Parse(tb_dr.Text.Trim(), Globalization.NumberStyles.Currency)
            End If
            Dim _idmutua As Nullable(Of Integer) = Nothing
            If chb_aseguradora.Checked = True Then
                If cb_aseguradora.SelectedIndex > -1 Then
                    _idmutua = cb_aseguradora.SelectedItem.Row.CMUTUA
                Else
                    MessageBox.Show("Debe entrar una mutua válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If

            Dim primera As Boolean = True
            While _fecha <= _fechafinal
                If Is_CitaDay(_fecha) Then
                    _inicio = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horainicio.Hour, _horainicio.Minute, 0)
                    _fin = New Date(_fecha.Year, _fecha.Month, _fecha.Day, _horafin.Hour, _horafin.Minute, 0)
                    If fIdfactura.HasValue Then
                        Me.CITASTableAdapter.Insert(_idpac, _fecha, _inicio, "N", _notas, _idmedico, _paciente, _importedr, _importeclinica, "N", "N", "", "N", Nothing, "N", fIdfactura, _idforma, _fin, _fechafinal, _idmutua, IdProceso, Nothing, Nothing, txtDescuentoTotal.Text, CtrlSalasvb1.ID_SALA, total, 0, False, citas)
                        FACTURASTableAdapter.UpdateRefCita(CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA"), fIdfactura)
                    Else
                        Me.CITASTableAdapter.Insert(_idpac, _fecha, _inicio, "N", _notas, _idmedico, _paciente, _importedr, _importeclinica, "N", "N", "", "N", Nothing, "N", Nothing, _idforma, _fin, _fechafinal, _idmutua, IdProceso, Nothing, Nothing, txtDescuentoTotal.Text, CtrlSalasvb1.ID_SALA, total, 0, False, citas)
                    End If

                    'INICIO - tras insertar relleno todos los datos
                    Dim idCitaTrasInsertar As Integer
                    If primera = True Then
                        idCitaTrasInsertar = CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA")
                        Dim i As Integer = 0
                        For i = 0 To Me.CMDataSet.LineasCitas.Rows.Count - 1
                            Me.CMDataSet.LineasCitas.Rows(i).Item("IdCita") = idCitaTrasInsertar
                        Next
                        primera = False
                    Else
                        Dim idCitaTrasInsertarNueva As Integer
                        idCitaTrasInsertarNueva = CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA")

                        Dim j As Integer = 0
                        Dim cont As Integer = LineasCitasTableAdapter.GetDataByIdCita(idCitaTrasInsertar).Rows.Count
                        For j = 0 To cont - 1
                            Dim rowTemp As CMDataSet.LineasCitasRow
                            Dim row As CMDataSet.LineasCitasRow
                            row = Me.CMDataSet.LineasCitas.NewLineasCitasRow
                            'sacamos la informacion de cada linea de la cita a copiar
                            rowTemp = LineasCitasTableAdapter.GetDataByIdCita(idCitaTrasInsertar).Rows(j)

                            row.Cantidad = rowTemp.Item("CANTIDAD")
                            row.ImporteClinica = rowTemp.Item("IMPORTECLINICA")
                            row.ImporteDr = rowTemp.Item("IMPORTEDR")
                            row.Total = rowTemp.Item("Total")
                            row.DESCRIPCION = rowTemp.Item("DESCRIPCION")
                            row.IdCita = idCitaTrasInsertarNueva
                            row.RefConcepto = rowTemp.Item("RefConcepto")
                            'row.RefConcepto = LineasCitasTableAdapter.GetData().Rows(LineasCitasTableAdapter.GetData().Rows.Count - 1).Item("RefConcepto")
                            CMDataSet.LineasCitas.Rows.Add(row)
                        Next

                    End If

                    Me.LineasCitasBindingSource.CurrencyManager.EndCurrentEdit()
                    Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
                    Me.CMDataSet.LineasCitas.AcceptChanges()
                    '-----

                    'fin insercion nueva linea
                    If fIdfactura.HasValue Then
                        FACTURASTableAdapter.UpdateRefCita(CITASTableAdapter.GetData().Rows(CITASTableAdapter.GetData().Rows.Count - 1).Item("IDCITA"), fIdfactura)
                    End If
                    'FIN - tras insertar relleno todos los datos



                End If
                _fecha = DateAndTime.DateAdd(DateInterval.Day, 1, _fecha)
            End While

            Me.LineasCitasBindingSource.CurrencyManager.EndCurrentEdit()
            Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
            Me.CMDataSet.LineasCitas.AcceptChanges()

            clickaccept = True
        End If
    End Sub



    Public Sub LLenaCombo(ByVal idPaciente As Integer)
        'cb_aseguradora.DataSource = MUTUASTableAdapter.GetDataByMutuasAsignadasAPaciente(idPaciente)
        '''TODO: AAAAAA
        Dim context As New CMLinqDataContext
        Dim pac As PACIENTE = context.PACIENTEs.Single(Function(o) o.CPACIENTE = idPaciente)
        Dim mutuasLista As New List(Of MUTUA)
        For Each m As LMUTUA In pac.LMUTUAs
            mutuasLista.Add(m.MUTUA)
        Next
        cb_aseguradora.DataSource = mutuasLista
        If Not MutuaPreseleccionada Is Nothing Then
            cb_aseguradora.SelectedIndex = BuscaMutua(MutuaPreseleccionada.CMUTUA)
        End If
        If CheckMutua And (faseguradorao > -1 Or cb_aseguradora.Items.Count > 0) Then
            chb_aseguradora.Checked = True
        Else
            chb_aseguradora.Checked = False
        End If


    End Sub





    Private Sub bt_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_factura.Click

        If CurrentAccion = Enums.Accion.Insertar Then
            MessageBox.Show("Debe guardar primero la cita")
            Return
        End If

        If Not chb_confirmada.Checked Or Not chb_atendido.Checked Then
            MessageBox.Show("La cita debe estar confirmada y atendida para ser facturada")
            Return
        End If

        If Guardar2() Then
            If dg_LineasCitas.Rows.Count = 0 Then
                MessageBox.Show("No hay lineas que facturar")
                Return
            End If



            Dim frm As New frmPartes_AsistenteFacturacion()
            frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
            frm.IdCitaPreseleccionada = fIdCITA
            frm.chkMostrarCero.Checked = True

            If chb_aseguradora.Checked Then
                frm.rbCitasMutuas.Checked = True
            Else
                frm.rbCitas_Paciente.Checked = True
            End If
            frm.GeneraFacturaDirecto = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frm.CitasFacturadas.Keys.Contains(fIdCITA) Then
                    'Ya fue facturada
                    'bntAsistenteFacturacion.Enabled = False
                    bntAsistenteFacturacion.Text = "Ver factura"
                    'Me.lb_factura.Visible = True
                    'Me.lb_ftexto.Visible = True
                    'Me.lb_ftexto.Text = frm.CitasFacturadas.Keys.Contains(fac
                    pb_facturas.Visible = True
                    bt_factura.Visible = False

                End If
                Inicializa()
            End If

            CtrlStatusPaciente1.CargaDatos()




        End If



    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Id As Integer = fIdfactura

        Dim pac As Integer = Nothing

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            pac = CtrlPaciente1.ID_PACIENTE
        End If

        'Dim _nueva_factura As form_factura

        'If fDesdePaciente Then
        '    _nueva_factura = New form_factura("Ficha de factura-Editar", Enums.Accion.Modificar, Id, pac, fCMDataSet)

        'Else
        '    _nueva_factura = New form_factura("Ficha de factura-Editar", Enums.Accion.Modificar, Id)

        'End If
        '_nueva_factura.ShowInTaskbar = False
        '_nueva_factura.ShowDialog()

        Dim factura As FACTURA = Globales.Factura_Modifica_y_Salva(fIdfactura)

        If CurrentAccion = Enums.Accion.Insertar Or CurrentAccion = Enums.Accion.Modificar Then

            Me.chb_pagada.Checked = (factura.PAGADA = "S")
            If Not factura.FECHACOBRO Is Nothing Then
                Me.dtp_fechacobro.Value = factura.FECHACOBRO
            End If

        End If
    End Sub

    'Private Sub tb_clinica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_clinica.TextChanged
    '    'ChequearTextboxSoloNumero(tb_clinica)
    'End Sub

    'Private Sub tb_dr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_dr.TextChanged
    '    'ChequearTextboxSoloNumero(tb_dr)
    'End Sub

    Private Sub tb_idpaciente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cargando = False Then
            If CtrlPaciente1.ID_PACIENTE.HasValue Then
                Dim _pcodo As Integer = CtrlPaciente1.ID_PACIENTE
                Dim _data As CMDataSet.PACIENTESDataTable

                _data = PACIENTESTableAdapter.GetPacienteById(_pcodo)

                If _data.Rows.Count > 0 Then
                    GetPaciente(_pcodo)
                    Me.CargaHistorias()
                Else
                    CtrlPaciente1.ID_PACIENTE = ""
                    CtrlPaciente1.Focus()
                    MessageBox.Show("No existe un paciente con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Private Sub tb_idforma_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idforma.Leave
        If tb_idforma.Text <> "" Then
            Dim _pcodo As String = tb_idforma.Text
            Dim data As CMDataSet.FORMASPAGODataTable = FORMASPAGOTableAdapter.GetFormasPagoById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_forma.Text = GetFormaPago(_pcodo)
            Else
                tb_idforma.Text = ""
                tb_idforma.Focus()
                MessageBox.Show("No existe una forma de pago con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tb_horainicio_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If tb_horainicio.Text.Trim.Length <> 5 Then
        '    Me.lb_aviso.Visible = True
        '    Me.lb_aviso.Text = "El formato de la hora debe ser hh:mm"
        '    Return
        'Else
        '    Me.lb_aviso.Visible = False
        '    Me.lb_aviso.Text = ""
        'End If

    End Sub

    Private Sub tb_horainicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_horainicio.Leave, tb_horainicio.Enter
        ' Dim hora As String
        'Dim minutos As String
        'Dim res As Integer
        Dim intervalo As Integer = 0
        Try
            intervalo = Globales.Configuracion.citainterval
            tb_horafin.Text = tb_horainicio.Value.AddMinutes(intervalo)
            'Me.HoraNoLaboral()
        Catch ex As IndexOutOfRangeException
            MsgBox("Hay algún problema en el formato de la hora de inicio de la cita, reviselo por favor", MsgBoxStyle.Exclamation)
        End Try
        ChequeaSala()
    End Sub


    Private Sub tb_horainiciocm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_horainicio.Leave, tb_horainicio.Enter, tb_horainiciocm.Leave, tb_horainiciocm.Enter
        'Dim hora As String
        'Dim minutos As String
        'Dim res As Integer
        Dim intervalo As Integer = 0
        Try
            intervalo = Globales.Configuracion.citainterval
            tb_horafincm.Text = tb_horainiciocm.Value.AddMinutes(intervalo)
            'Me.HoraNoLaboral()
        Catch ex As IndexOutOfRangeException
            MsgBox("Hay algún problema en el formato de la hora de inicio de la cita, reviselo por favor", MsgBoxStyle.Exclamation)
        End Try
        ChequeaSala()
    End Sub

    Private Sub AbrirPaciente()

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            Return
        End If

        'Intentar localizar al usuario
        Dim codigoPaciente As Integer = -1
        Try
            codigoPaciente = CtrlPaciente1.ID_PACIENTE.Value
        Catch ex As Exception
            MessageBox.Show("Introduzca un código válido!")
            CtrlPaciente1.Focus()
            Return
        End Try

        Me.PACIENTESTableAdapter.FillPacienteById(CMDataSet.PACIENTES, codigoPaciente)
        If CMDataSet.PACIENTES.Count = 0 Then
            MessageBox.Show("Paciente no existe!")
            CtrlPaciente1.Focus()
            Return
        End If

        'Si llega aqui el paciente existe
        Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, codigoPaciente)
        _nuevo_paciente.ShowInTaskbar = False
        _nuevo_paciente.ShowDialog()
    End Sub
    Private Sub ImprimirCita()

        Dim param(3) As Microsoft.Reporting.WinForms.ReportParameter

        'Establezco los parametros que contienen la información a mostrar en la ficha de cita.
        param(0) = (New Microsoft.Reporting.WinForms.ReportParameter("DiaCita", Me.dtp_fecha.Text))
        param(1) = (New Microsoft.Reporting.WinForms.ReportParameter("HoraCita", Me.tb_horainicio.Text))
        param(2) = (New Microsoft.Reporting.WinForms.ReportParameter("NomDoctor", CtrlMedico1.Medico.NOMBRECOMPLETO))
        param(3) = (New Microsoft.Reporting.WinForms.ReportParameter("NomPaciente", CtrlPaciente1.NombreCompleto))

        UI.Reportes.ReportesManager.Imprime("CitaJustificante.rdlc", Nothing, param)

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir, RoleManager.Items.Citas, "Imprimir Cita", Me.fIdCITA.ToString(), CtrlPaciente1.NombreCompleto)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_actualiza_cbMutuas.Click
        Me.LLenaCombo(fPacienteId)
    End Sub

    Private Sub bt_AbrirPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.AbrirPaciente()
    End Sub

    Private Sub pb_facturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pb_facturas.DoubleClick
        Dim frm As New frmFacturasM()
        frm.IdPacienteToFilter = CtrlPaciente1.ID_PACIENTE
        frm.ShowDialog()
        'Dim frmFacPtes As New listado_facturas(Me.CtrlPaciente1.ID_PACIENTE, "N")
        'frmFacPtes.StartPosition = FormStartPosition.CenterScreen
        'frmFacPtes.ShowDialog()
    End Sub

    Private Sub pb_citas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pb_citas.DoubleClick
        'Dim frmCitasPtes As New Citas(Me.CtrlPaciente1.ID_PACIENTE, "N")
        'frmCitasPtes.StartPosition = FormStartPosition.CenterScreen
        'frmCitasPtes.ShowDialog()
        Dim listadoCitas As New frmListadoCitas()
        listadoCitas.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
        listadoCitas.CtrlPaciente1.Enabled = True
        listadoCitas.ShowDialog()

    End Sub

    Private Sub PAGADALabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lb_ftexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_ftexto.Click

    End Sub

    Private Sub lb_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_factura.Click

    End Sub


    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Dim o As HISTORIALE
        o = Me.GridEX1.CurrentRow.DataRow
        'Dim frmVisor As New formVisorHistorial(o.CHISTORIAL)
        Dim frmvisor As New frmHistoriales
        frmvisor.IdPaciente = o.REFPACIENTE
        frmvisor.StartPosition = FormStartPosition.CenterScreen
        frmvisor.ShowInTaskbar = False

        frmvisor.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'DataGridView1_CellDoubleClick(Nothing, e)
    End Sub


    Private Sub AsignarFacturaExistente()

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar una paciente ")
            Return
        End If

        Dim frmlistado As New form_listados("Lista de Facturas", Me.FACTURASBindingSource, RoleManager.Items.Facturas, True, "FACTURAS", " WHERE REFPACIENTE=" & CtrlPaciente1.ID_PACIENTE.Value, " ORDER BY FECHA ASC")
        frmlistado.ShowDialog()
        If Not frmlistado.Selected Is Nothing Then
            fIdfactura = frmlistado.Selected

            Me.FACTURASTableAdapter.FillFacturaById(CMDataSet.FACTURAS, fIdfactura)
            If CMDataSet.FACTURAS.Rows.Count > 0 Then
                Me.lb_ftexto.Text = CMDataSet.FACTURAS.Rows(0).Item("NUMERO")
                Me.lb_factura.Visible = True
                Me.lb_ftexto.Visible = True
                'Me.bt_modificar.Visible = True
            End If


            If MessageBox.Show("¿Desea asignarle los conceptos facturables de la cita a la factura seleccionada?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim cont As Integer = 0
                For cont = 0 To dg_LineasCitas.Rows.Count - 1

                    ''If cont = 0 Then
                    ''    LINEASFACTURASTableAdapter.Insert("*** Cita ***", 0, fIdfactura, Nothing, 0.0F, 0)
                    ''End If

                    'Dim Descripcion As String = ""
                    'Dim Importe As Double = 0
                    'Dim RefConcepto As String = ""
                    'Dim Cantidad As Double = 0
                    'If Not Me.dg_LineasCitas.Rows(cont).Cells("colDescripcion").Value.GetType Is GetType(DBNull) Then
                    '    Descripcion = dtp_fecha.Value.ToShortDateString() & " - " & Me.dg_LineasCitas.Rows(cont).Cells("colDescripcion").Value
                    'End If
                    'If Not Me.dg_LineasCitas.Rows(cont).Cells("colRefConcepto").Value.GetType Is GetType(DBNull) Then
                    '    If Me.dg_LineasCitas.Rows(cont).Cells("colRefConcepto").Value.ToString.Trim.Length = 0 Then
                    '        RefConcepto = Nothing
                    '    Else
                    '        RefConcepto = Me.dg_LineasCitas.Rows(cont).Cells("colRefConcepto").Value
                    '    End If

                    'Else
                    '    If RefConcepto.Trim.Length = 0 Then RefConcepto = Nothing
                    'End If
                    'Importe = Me.dg_LineasCitas.Rows(cont).Cells("colImporteClinica").Value + Me.dg_LineasCitas.Rows(cont).Cells("colImporteDoctor").Value
                    'Cantidad = Me.dg_LineasCitas.Rows(cont).Cells("colCantidad").Value
                    'LINEASFACTURASTableAdapter.Insert(Descripcion _
                    '        , Importe, fIdfactura, RefConcepto, _
                    '        Cantidad, 0, fIdCITA, , Nothing)

                    ''Cargo la factura para que el usuario se obligue a salvar

                    'Globales.Factura_Modifica_y_Salva(fIdfactura)
                    ''Dim _nueva_factura As form_factura = New form_factura("Ficha de factura-Editar", Enums.Accion.Modificar, fIdfactura, CtrlPaciente1.ID_PACIENTE.Value, fCMDataSet)
                    ''_nueva_factura.ShowInTaskbar = False
                    ''_nueva_factura.ShowDialog()

                Next

                'RecalculaTotalesFactura(fIdfactura)
                btn_DesasociarFactura.Visible = True
            End If

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AsignarFacturaExistente()
    End Sub

    Private Sub bt_AddHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AddHistoria.Click
        'If Not CtrlMedico1.ID_Medico.HasValue Then
        '    MessageBox.Show("Debe seleccionar un médico antes")
        '    Return
        'End If
        If CtrlPaciente1.ID_PACIENTE.HasValue Then

            Dim frm As New frmHistoriales()
            frm.IdPaciente = CtrlPaciente1.ID_PACIENTE
            frm.ShowDialog()
            CargaHistorias()
            'CtrlPaciente1_PacienteSeleccionado(CtrlPaciente1.ID_PACIENTE, False)

            'Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, Me.CtrlPaciente1.ID_PACIENTE)
            'Me.MEDICOSTableAdapter.FillMedicoByID(Me.CMDataSet.MEDICOS, CtrlMedico1.ID_Medico)
            'Dim frmHistoria As New form_pac_historial("Historial", Enums.Accion.Insertar, -1, CInt(Me.CtrlPaciente1.ID_PACIENTE), CMDataSet)
            'frmHistoria.ShowDialog()
            'If frmHistoria.DialogResult = Windows.Forms.DialogResult.OK Then
            '    '    Me.CargaHistorias()
            'End If
        End If
    End Sub

    Private Sub tb_horainicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horainicio.ValueChanged
        Me.tb_horainicio_TextChanged(Nothing, Nothing)

    End Sub

    Private Sub HORALabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chb_falta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_falta.CheckedChanged

    End Sub

    Private Sub FALTALabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Cancelar()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ImprimirCita()
    End Sub
    Private Sub addLineaTicket()
        Dim row As CMDataSet.LineasCitasRow
        'If Me.fDesdePaciente Then
        '    row = Me.fCMDataSet.LineasCitas.NewLineasCitasRow
        'Else
        row = Me.CMDataSet.LineasCitas.NewLineasCitasRow
        'End If

        Dim idCita As Integer = -1


        If Me.CurrentAccion = Enums.Accion.Modificar Then
            idCita = Me.fIdCITA
            'si es una nueva cita en el evento de aceptar actualizo todas las lineas el idcita.
        End If

        'valores por defecto
        row.Cantidad = 1
        row.ImporteClinica = 0
        row.ImporteDr = 0
        row.DESCRIPCION = ""
        row.IdCita = idCita
        row.RefConcepto = ""
        row.Duracion = New Date(2000, 1, 1, 0, 0, 0)
        row.Total = 0

        'If Me.fDesdePaciente Then
        '    fCMDataSet.LineasCitas.Rows.Add(row)
        'Else
        CMDataSet.LineasCitas.Rows.Add(row)
        'End If


        'Gana el foco el campo Articulo de la ultima fila que es la que acabo de añadir.
        If Me.dg_LineasCitas.Rows.Count > 0 Then
            Me.dg_LineasCitas.ClearSelection()
            Me.dg_LineasCitas.MultiSelect = False
            Me.dg_LineasCitas.Focus()
            Dim rowGrid As DataGridViewRow = dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.GetLastRow(DataGridViewElementStates.Displayed))

            'Dim cellDuracion As New DataGridViewTextBoxCell()
            'cellDuracion.Value = Date.Now()
            'rowGrid.Cells("Duracion").Value = Date.Now()

            Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells("ColRefConcepto").Selected = True
            Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells(ColumnDtoImp.Index).Value = 0
            Me.dg_LineasCitas.MultiSelect = True
        End If
        cambios = True
        'CMDataSet.LineasCitas.AcceptChanges()
        ' Me.dg_LineasCitas.Refresh()

    End Sub
    Private Sub EliminarFila(ByRef indicefila As Integer)
        Dim res As MsgBoxResult
        res = MsgBox("Esta acción no podrá deshacerse. ¿Seguro que desea continuar?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.No Then Exit Sub
        Try
            Dim lineaCita As CMDataSet.LineasCitasRow = Me.dg_LineasCitas.Rows(indicefila).DataBoundItem.Row
            EliminaPresupuestoDental(lineaCita)
            EliminaTratamiento(lineaCita)
            Me.dg_LineasCitas.Rows.RemoveAt(indicefila)
            'Me.dg_LineasCitas_CellEndEdit(Nothing, Nothing)
            dg_LineasCitas.EndEdit()
            Me.LineasCitasBindingSource.EndEdit()
            Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
            CalculaTotalesCita()
            cambios = True
        Catch ex As Exception

        End Try



    End Sub

    Private Sub EliminaPresupuestoDental(ByVal lineaCita As CMDataSet.LineasCitasRow)
        If Not lineaCita.IsRefLineaPresupuestoDentalNull Then
            Try
                Dim context As New CMLinqDataContext()
                Dim lineaP As d_PresupuestoLinea = (From l In context.d_PresupuestoLineas Where l.IDPresupuestoLinea = lineaCita.RefLineaPresupuestoDental Select l).SingleOrDefault()
                lineaP.IDCITA = Nothing
                context.SubmitChanges()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub EliminaTratamiento(ByVal lineaCita As CMDataSet.LineasCitasRow)
        If Not lineaCita.IsRefLineaTratamientoNull Then
            Try
                Dim context As New CMLinqDataContext()
                Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = (From l In context.LCOMPARATIVAS_TRATAMIENTOs
                                                               Where l.ID = lineaCita.RefLineaTratamiento
                                                               Select l).SingleOrDefault()
                If Not tratamiento Is Nothing Then
                    tratamiento.ID_Cita = Nothing
                    tratamiento.ID_LineaCita = Nothing
                    tratamiento.Facturada = False
                End If
                context.SubmitChanges()
            Catch ex As Exception
            End Try
        End If
    End Sub
    'Private Sub CalculaDuracion()
    '    Dim totalDuracion As New DateTime(2000, 1, 1, 0, 0, 0)
    '    Dim i As Integer = 0
    '    For i = 0 To dg_LineasCitas.Rows.Count - 1
    '        Dim linea As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(i).DataBoundItem.Row
    '        If Not linea.IsDuracionNull Then
    '            totalDuracion = totalDuracion.Add(linea.Duracion.TimeOfDay)
    '        End If
    '    Next

    '    If Not duracionCalculada Then
    '        txtDuracion.Text = totalDuracion.ToString("HH:mm")
    '        duracionCalculada = True
    '        If Not totalDuracion.TimeOfDay = TimeSpan.Zero Then
    '            tb_horafin.Value = tb_horainicio.Value.Add(totalDuracion.TimeOfDay)
    '        End If
    '    End If
    'End Sub

    Private Sub CalculaTotalesCita()
        dg_LineasCitas.EndEdit()

        Dim sumClinica As Double = 0
        Dim sumDr As Double = 0
        Dim total As Double = 0
        Dim totalDuracion As New TimeSpan(0, 0, 0)

        Dim dto As Double = 0
        Dim i = 0
        For i = 0 To dg_LineasCitas.Rows.Count - 1
            Dim linea As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(i).DataBoundItem.Row

            If linea.IsTotalNull() Then
                linea.Total = 0
            End If
            sumClinica += linea.ImporteClinica * linea.Cantidad
            sumDr += linea.ImporteDr * linea.Cantidad
            total += linea.Total

            dto += dg_LineasCitas.Rows(i).Cells(ColumnDtoImp.Index).Value
            If Not linea.IsDuracionNull Then
                totalDuracion = totalDuracion.Add(linea.Duracion.TimeOfDay)
            End If
        Next


        If Not duracionCalculada Then
            txtDuracion.Text = totalDuracion.Hours & ":" & totalDuracion.Minutes
            duracionCalculada = True
            If Not totalDuracion = TimeSpan.Zero Then
                tb_horafin.Value = tb_horainicio.Value.Add(totalDuracion)
            End If
        End If

        Me.tb_clinica.Text = sumClinica.ToString("C2")
        Me.tb_dr.Text = sumDr.ToString("C2")
        Me.lb_total.Text = total.ToString("C2")
        Me.txtDescuentoTotal.Text = dto.ToString("C2")

        'MessageBox.Show(sumClinica)

    End Sub





#Region "Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String,Byval descripcion as String, ByVal importeDefecto As Double) As Double"
    Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String, ByVal descripcion As String, ByVal importeDefecto As Double) As Double


        If dg_LineasCitas.Rows.Count = 1 And recalcularConceptos = False And cb_aseguradora.SelectedIndex > -1 And CtrlPaciente1.ID_PACIENTE.HasValue And chb_aseguradora.Checked Then
            If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                Dim res As DialogResult = MessageBox.Show("Desea recalcular los importes con la tarifa de la mutua seleccionada, si procede?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.Yes Then
                    recalcularConceptos = True
                Else
                    recalcularConceptos = False
                End If
            Else
                'Se recalcula obligatoriamente sin preguntar
                recalcularConceptos = True
            End If
        End If

        'Pasos
        'Obtener la tarifa de la mutua seleccionada si hay una seleccionada

        Dim importe As Double = importeDefecto

        'Verificar si hay una mutua seleccionada

        If chb_aseguradora.Checked Then
            If cb_aseguradora.SelectedIndex > -1 Then
                Dim mutua As MUTUA = cb_aseguradora.SelectedItem

                Dim tarifaAdapter As New CMDataSetTableAdapters.TarifasTableAdapter()
                Dim tarifaTable As New CMDataSet.TarifasDataTable()

                'Si tiene tarifa
                If mutua.IdTarifa.HasValue Then
                    'Cargarla
                    tarifaAdapter.FillBy(tarifaTable, mutua.IdTarifa)
                    If (tarifaTable.Count > 0) Then
                        For Each tarifa As CMDataSet.TarifasRow In tarifaTable.Rows
                            'If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto And recalcularConceptos Then
                            If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto Then
                                Return tarifa.Importe
                            End If
                        Next
                    End If
                End If
            End If
        End If
        Return importe
    End Function
#End Region

    Private Sub RestauraValoresConceptos()

        For Each row As DataGridViewRow In dg_LineasCitas.Rows
            'row.Cells("colImporteClinica").Value = ObtieneConceptoFacturable(row.Cells("colRefConcepto").Value).IMPORTE.ToString("C2")
            row.Cells("colImporteClinica").Value = ObtieneConceptoFacturable(row.Cells("colRefConcepto").Value).IMPORTE.ToString()
        Next

    End Sub

    Private Sub CalculaFila(ByRef gridRow As DataGridViewRow, ByVal columnIndex As Integer)

        'Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas = True
        'Globales.Configuracion.ModuloLiquidacionMedicos_Activo = True


        If Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then
            If Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas Then
                'ImporteIncluido
                CalculaFilaImporteMedicoIncluido(gridRow, columnIndex)
            Else
                CalculaFilaSinImporteMedicoInclido(gridRow, columnIndex)
            End If
        Else
            CalculaFilaSinImporteMedicoInclido(gridRow, columnIndex)
        End If
    End Sub

#Region "Private Sub CalculaFilaSinImporteMedicoInclido(ByRef gridRow As DataGridViewRow, ByVal columnIndex As Integer)"
    Private Sub CalculaFilaSinImporteMedicoInclido(ByRef gridRow As DataGridViewRow, ByVal columnIndex As Integer)
        Try
            Dim lineaCita As CMDataSet.LineasCitasRow = gridRow.DataBoundItem.Row
            Dim comisionDoctor As Double = DameComisionMedico(lineaCita.RefConcepto)

            If Not lineaCita.IsDescuentoPercentNull() And columnIndex <> ColumnDtoImp.Index Then
                gridRow.Cells(ColumnDtoImp.Index).Value = (lineaCita.DescuentoPercent / 100) * (lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr))
            End If


            If lineaCita.Cantidad = 0 Then
                lineaCita.Cantidad = 1
            End If

            Dim totalLinea As Double = 0

            'columna codigo
            If columnIndex = 1 Then
                Dim filaconcepto As CMDataSet.CONCEPTOSFRARow
                'If gridRow.Cells(columnIndex).Value.ToString.Trim.Length > 0 Then
                If Not lineaCita.IsRefConceptoNull() Then
                    filaconcepto = Me.ObtieneConceptoFacturable(lineaCita.RefConcepto)
                    If Not filaconcepto Is Nothing Then
                        AnnadeLinea(gridRow, filaconcepto.CODIGO)
                    End If
                End If
                LineasCitasBindingSource.EndEdit()
            End If

            'column Cantidad unidades
            If columnIndex = colCantidad.Index Then
                'totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                'lineaCita.Total = totalLinea - gridRow.Cells(ColumnDtoImp.Index).Value
                'gridRow.Cells(dg_LineasCitas.Columns("Total").Index).Value = totalLinea - gridRow.Cells(ColumnDtoImp.Index).Value
            End If

            'columna Importe Clinica
            If columnIndex = colImporteClinica.Index Then
                Dim neto As Double = lineaCita.ImporteClinica * lineaCita.Cantidad

                If comisionDoctor > 0 Then
                    lineaCita.ImporteDr = comisionDoctor * neto
                End If
            End If

            'columna Importe Doctor
            If columnIndex = colImporteDoctor.Index Then

            End If

            'columna % Dto
            If columnIndex = DescuentoPercent.Index Then

                If gridRow.Cells(DescuentoPercent.Index).Value >= 0 Then
                    Dim percent As Double = gridRow.Cells(DescuentoPercent.Index).Value
                    totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                    gridRow.Cells(ColumnDtoImp.Index).Value = (percent / 100) * totalLinea
                    'lineaCita.Total = totalLinea
                Else
                    MessageBox.Show("Valor del Dto % incorrecto, corríjalo por favor")
                    gridRow.Cells(DescuentoPercent.Index).Value = 0
                End If
            End If

            'columna Dto Importe
            If columnIndex = ColumnDtoImp.Index Then

                If gridRow.Cells(ColumnDtoImp.Index).Value >= 0 Then
                    Dim amount As Double = gridRow.Cells(ColumnDtoImp.Index).Value
                    totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                    If totalLinea > 0 Then
                        gridRow.Cells(DescuentoPercent.Index).Value = (amount / totalLinea) * 100
                    End If
                Else
                    MessageBox.Show("Valor del Dto Importe incorrecto, corríjalo por favor")
                    gridRow.Cells(ColumnDtoImp.Index).Value = 0
                End If
            End If

            'columna Duracion
            If columnIndex = Duracion.Index Then
                duracionCalculada = False
            End If

            'column Total
            If columnIndex = Total.Index Then
                If Not lineaCita.IsTotalNull() Then
                    If lineaCita.Total > 0 Then
                        Dim dtoImporte As Double = gridRow.Cells(ColumnDtoImp.Index).Value

                        Dim neto As Double = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr) - dtoImporte
                        Dim dtoInicial As Double = (gridRow.Cells(DescuentoPercent.Index).Value / 100 * neto)

                        If comisionDoctor = 0 Then
                            'Hay que recalcular proporcionalmente
                            'Calculando pro, total anterior / total actual
                            Dim coef As Double = (neto) / lineaCita.Total
                            If coef = 0 Then coef = 1

                            lineaCita.ImporteClinica = 1 / coef * lineaCita.ImporteClinica
                            lineaCita.ImporteDr = 1 / coef * lineaCita.ImporteDr
                        Else
                            lineaCita.ImporteDr = comisionDoctor * (lineaCita.Total - dtoImporte)
                            lineaCita.ImporteClinica = lineaCita.Total - dtoImporte - lineaCita.ImporteDr
                        End If
                        gridRow.Cells(ColumnDtoImp.Index).Value = (gridRow.Cells(DescuentoPercent.Index).Value / 100 * lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr))
                        dg_LineasCitas.EndEdit()
                        LineasCitasBindingSource.EndEdit()
                        CalculaTotalesCita()
                        Return
                    End If
                End If
            End If


            lineaCita.Total = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr) - gridRow.Cells(ColumnDtoImp.Index).Value

            dg_LineasCitas.EndEdit()
            LineasCitasBindingSource.EndEdit()
            CalculaTotalesCita()
        Catch ex As Exception
            MessageBox.Show("Datos Incorrectos, corríjalos por favor")
        End Try

    End Sub
#End Region


    Private Sub CalculaFilaImporteMedicoIncluido(ByRef gridRow As DataGridViewRow, ByVal columnIndex As Integer)
        Try
            Dim lineaCita As CMDataSet.LineasCitasRow = gridRow.DataBoundItem.Row
            Dim comisionDoctor As Double = 0
            If Not lineaCita.IsRefConceptoNull Then
                comisionDoctor = DameComisionMedico(lineaCita.RefConcepto)
            Else
                comisionDoctor = DameComisionMedico("")
            End If
            If Not lineaCita.IsDescuentoPercentNull() And columnIndex <> ColumnDtoImp.Index Then
                gridRow.Cells(ColumnDtoImp.Index).Value = (lineaCita.DescuentoPercent / 100) * (lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr))
            End If


            If lineaCita.Cantidad = 0 Then
                lineaCita.Cantidad = 1
            End If

            Dim totalLinea As Double = 0

            'columna codigo
            If columnIndex = 1 Then
                Dim filaconcepto As CMDataSet.CONCEPTOSFRARow
                'If gridRow.Cells(columnIndex).Value.ToString.Trim.Length > 0 Then
                If Not lineaCita.IsRefConceptoNull() Then
                    filaconcepto = Me.ObtieneConceptoFacturable(lineaCita.RefConcepto)
                    If Not filaconcepto Is Nothing Then
                        AnnadeLinea(gridRow, filaconcepto.CODIGO)
                    End If
                End If
                LineasCitasBindingSource.EndEdit()
            End If

            'column Cantidad unidades
            If columnIndex = colCantidad.Index Then
                'totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                'lineaCita.Total = totalLinea - gridRow.Cells(ColumnDtoImp.Index).Value
                'gridRow.Cells(dg_LineasCitas.Columns("Total").Index).Value = totalLinea - gridRow.Cells(ColumnDtoImp.Index).Value
            End If

            'columna Importe Clinica
            If columnIndex = colImporteClinica.Index Then
                Dim neto As Double = lineaCita.ImporteClinica * lineaCita.Cantidad
                lineaCita.Total = lineaCita.ImporteClinica * lineaCita.Cantidad

                If comisionDoctor > 0 Then
                    lineaCita.ImporteDr = comisionDoctor * neto
                    lineaCita.ImporteClinica = neto - lineaCita.ImporteDr
                    Dim percent As Double = gridRow.Cells(DescuentoPercent.Index).Value
                    totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                    gridRow.Cells(ColumnDtoImp.Index).Value = (percent / 100) * totalLinea
                End If

            End If

            'columna Importe Doctor
            If columnIndex = colImporteDoctor.Index Then
                'gridRow.Cells(ColumnDtoImp.Index).Value = (lineaCita.DescuentoPercent / 100) * (lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr))
                'totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                lineaCita.ImporteClinica = lineaCita.Total + gridRow.Cells(ColumnDtoImp.Index).Value - (lineaCita.ImporteDr * lineaCita.Cantidad)
                Return
            End If

            'columna % Dto
            If columnIndex = DescuentoPercent.Index Then

                If gridRow.Cells(DescuentoPercent.Index).Value >= 0 Then
                    Dim percent As Double = gridRow.Cells(DescuentoPercent.Index).Value
                    totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                    gridRow.Cells(ColumnDtoImp.Index).Value = (percent / 100) * totalLinea
                    'lineaCita.Total = totalLinea
                Else
                    MessageBox.Show("Valor del Dto % incorrecto, corríjalo por favor")
                    gridRow.Cells(DescuentoPercent.Index).Value = 0
                End If
            End If

            'columna Dto Importe
            If columnIndex = ColumnDtoImp.Index Then

                If gridRow.Cells(ColumnDtoImp.Index).Value >= 0 Then
                    Dim amount As Double = gridRow.Cells(ColumnDtoImp.Index).Value
                    totalLinea = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                    If totalLinea > 0 Then
                        gridRow.Cells(DescuentoPercent.Index).Value = (amount / totalLinea) * 100
                    End If
                Else
                    MessageBox.Show("Valor del Dto Importe incorrecto, corríjalo por favor")
                    gridRow.Cells(ColumnDtoImp.Index).Value = 0
                End If
            End If

            'columna Duracion
            If columnIndex = Duracion.Index Then
                duracionCalculada = False
            End If

            'column Total
            If columnIndex = Total.Index Then
                If Not lineaCita.IsTotalNull() Then
                    If lineaCita.Total > 0 Then

                        Dim dtoImporte As Double = (lineaCita.DescuentoPercent / 100) * lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                        Dim neto As Double = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr) - dtoImporte


                        If neto = 0 Then neto = 1
                        Dim coef As Double = lineaCita.Total / neto


                        If dtoImporte <> 0 Then
                            dtoImporte = coef * dtoImporte
                        End If
                        gridRow.Cells(ColumnDtoImp.Index).Value = dtoImporte

                        'If dtoImporte > 0 Then
                        '    'Calcular el nuevo porciento
                        '    Dim total As Double = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr)
                        '    If total <> 0 Then
                        '        'gridRow.Cells(DescuentoPercent.Index).Value = ceof * (dtoImporte / total) * 100
                        '    End If
                        'End If

                        If comisionDoctor > 0 Then
                            'Calcular su parte basado en el porciento de comision sobre el Total-DtoImpo
                            lineaCita.ImporteDr = comisionDoctor * (lineaCita.Total + dtoImporte)
                            lineaCita.ImporteClinica = (lineaCita.Total + dtoImporte) - lineaCita.ImporteDr
                        Else
                            lineaCita.ImporteDr = coef * lineaCita.ImporteDr
                            'lineaCita.ImporteClinica = 1 / coef * lineaCita.ImporteClinica
                            lineaCita.ImporteClinica = (lineaCita.Total + dtoImporte) - lineaCita.ImporteDr
                        End If

                        'dg_LineasCitas.EndEdit()
                        'LineasCitasBindingSource.EndEdit()
                        'CalculaTotalesCita()
                        'Return
                    End If
                End If
            End If


            lineaCita.Total = lineaCita.Cantidad * (lineaCita.ImporteClinica + lineaCita.ImporteDr) - gridRow.Cells(ColumnDtoImp.Index).Value

            dg_LineasCitas.EndEdit()
            LineasCitasBindingSource.EndEdit()
            CalculaTotalesCita()
        Catch ex As Exception
            MessageBox.Show("Datos Incorrectos, corríjalos por favor")
        End Try

    End Sub

    Private Sub dg_LineasCitas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellEndEdit
        CalculaFila(dg_LineasCitas.Rows(e.RowIndex), e.ColumnIndex)
        CalculaTotalesCita()
    End Sub


    Private Function DameComisionMedico(ByVal refConcepto As String)
        Dim spare As Boolean = False
        Return CtrlMedico1.Medico.PorcientoCitaReal(refConcepto, spare)
    End Function

    Private Sub AjustaImportes(ByRef gridRow As DataGridViewRow)

        'If Not CtrlMedico1.ID_Medico.HasValue Then
        'Restaurar el valor original del conceptop y hacer 0 el del doctor para el recalculo

        Dim oldImporteMedico As Double = gridRow.Cells(colImporteDoctor.Index).Value

        Dim row2 As CMDataSet.LineasCitasRow = gridRow.DataBoundItem.Row
        If Not row2.IsRefConceptoNull Then
            If row2.RefConcepto <> "" Then
                Dim concepto As CMDataSet.CONCEPTOSFRARow = ObtieneConceptoFacturable(row2.RefConcepto)
                If Not concepto Is Nothing Then
                    gridRow.Cells(colImporteClinica.Index).Value = concepto.IMPORTE
                    gridRow.Cells(colImporteDoctor.Index).Value = 0
                    Dim linea As CMDataSet.LineasCitasRow = gridRow.DataBoundItem.Row
                    linea.ImporteClinica = concepto.IMPORTE
                    linea.ImporteDr = 0
                End If
            End If

        End If
        ' End If



        Dim netoLinea As Double = gridRow.Cells(colCantidad.Index).Value * _
                      gridRow.Cells(colImporteClinica.Index).Value


        Dim huboCambiosEnComisionesLinea As Boolean = False
        gridRow.Cells(colImporteDoctor.Index).ToolTipText = "Deducido el " & (CalculaImporteMedico(gridRow, huboCambiosEnComisionesLinea) * 100) & "%"
        Dim importeMedico As Double = CalculaImporteMedico(gridRow, huboCambiosEnComisionesLinea) * netoLinea

        gridRow.Cells(colImporteDoctor.Index).Value = importeMedico


        If oldImporteMedico <> importeMedico And importeMedico > 0 Then
            HuboCambiosEnComisiones = True
        End If

        Try
            If huboCambiosEnComisionesLinea Then
                'gridRow.Cells(colImporteDoctor.Index).Style.ForeColor = Color.Red


            Else
                'gridRow.Cells(colImporteDoctor.Index).Style.ForeColor = Color.Black
            End If

        Catch ex As Exception

        End Try

        Dim row As CMDataSet.LineasCitasRow = gridRow.DataBoundItem.Row
        row.ImporteDr = importeMedico

        If Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then
            If Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas Then
                row.ImporteClinica = netoLinea - importeMedico
            End If
        End If

    End Sub

    Private Sub dg_LineasCitas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellClick
        If e.ColumnIndex = colBuscar.Index Then 'significa que han pulsado en la columna tipo imagen que usamos para busqueda de articulos
            If e.RowIndex <> -1 Then
                Dim frm As New frmListadoConceptos()
                'frm.tabDental.TabVisible = False
                frm.Modo = Globales.ModoParaFormas.Seleccion
                If frm.ShowDialog() = DialogResult.OK Then

                    If frm.ConceptosSeleccionados.Count = 0 Then
                        AnnadeLinea(dg_LineasCitas.Rows(e.RowIndex), frm.ConceptoFra.CODIGO)
                    Else
                        AnnadeMultiplesLineas(dg_LineasCitas.Rows(e.RowIndex), frm.ConceptosSeleccionados)
                    End If

                    CalculaTotalesCita()
                    dg_LineasCitas.EndEdit()
                    LineasCitasBindingSource.EndEdit()
                    dg_LineasCitas.Update()
                End If
            End If

        End If

    End Sub

#Region "Private Sub AnnadeLinea(ByRef row As DataGridViewRow, ByVal codigoConcepto As String)"
    Private Sub AnnadeLinea(ByRef row As DataGridViewRow, ByVal codigoConcepto As String)
        Dim concepto As CMDataSet.CONCEPTOSFRARow
        concepto = Me.ObtieneConceptoFacturable(codigoConcepto)

        Dim fila As CMDataSet.LineasCitasRow = row.DataBoundItem.Row
        fila.RefConcepto = concepto.CODIGO
        fila.DESCRIPCION = concepto.DESCRIPCION
        fila.Cantidad = 1
        fila.ImporteClinica = ObtenImporteConceptoSegunTarifa(concepto.CODIGO, concepto.DESCRIPCION, concepto.IMPORTE)


        'dg_LineasCitas.Rows(row.Index).Cells("colRefConcepto").Value = concepto.CODIGO
        'dg_LineasCitas.Rows(row.Index).Cells("colDescripcion").Value = concepto.DESCRIPCION
        'dg_LineasCitas.Rows(row.Index).Cells("colImporteClinica").Value = ObtenImporteConceptoSegunTarifa(concepto.CODIGO, concepto.DESCRIPCION, concepto.IMPORTE)

        'El importe del medico se deduce del todal basado en el % sin afectar el total, re
        'If CtrlMedico1.ID_Medico.HasValue Then
        AjustaImportes(dg_LineasCitas.Rows(row.Index))
        'End If
        If Not concepto.IsDuracionNull Then
            dg_LineasCitas.Rows(row.Index).Cells("Duracion").Value = concepto.Duracion
        Else
            dg_LineasCitas.Rows(row.Index).Cells("Duracion").Value = New Date(2000, 1, 1, 0, 0, 0)
        End If
        If chb_aseguradora.Checked Then
            ChequeaTarifaDeLinea(dg_LineasCitas.Rows(row.Index))
        End If

        fila.Total = fila.Cantidad * (fila.ImporteClinica + fila.ImporteDr)

        duracionCalculada = False
        CalculaTotalesCita()
    End Sub
#End Region

    Private Sub AnnadeMultiplesLineas(ByRef startingRow As DataGridViewRow, ByRef conceptos As List(Of CONCEPTOSFRA))

        Dim newRow As DataGridViewRow = startingRow
        For i As Integer = 0 To conceptos.Count - 1

            Dim filaConcepto As CONCEPTOSFRA = conceptos(i)

            newRow.Cells("colRefConcepto").Value = filaConcepto.CODIGO
            newRow.Cells("colDescripcion").Value = filaConcepto.DESCRIPCION
            newRow.Cells("colImporteClinica").Value = ObtenImporteConceptoSegunTarifa(filaConcepto.CODIGO, filaConcepto.DESCRIPCION, filaConcepto.IMPORTE)

            AjustaImportes(newRow)

            If filaConcepto.Duracion.HasValue Then
                newRow.Cells("Duracion").Value = filaConcepto.Duracion
            Else
                newRow.Cells("Duracion").Value = New Date(2000, 1, 1, 0, 0, 0)
            End If

            If i < conceptos.Count - 1 Then
                Dim row As CMDataSet.LineasCitasRow
                row = Me.CMDataSet.LineasCitas.NewLineasCitasRow
                Dim idCita As Integer = -1
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    idCita = Me.fIdCITA
                End If

                'valores por defecto
                row.Cantidad = 1
                row.ImporteClinica = 0
                row.ImporteDr = 0
                row.DESCRIPCION = ""
                row.IdCita = idCita
                row.RefConcepto = ""
                row.Duracion = New Date(2000, 1, 1, 0, 0, 0)
                CMDataSet.LineasCitas.Rows.Add(row)
                newRow = dg_LineasCitas.Rows(dg_LineasCitas.Rows.Count - 1)
            End If
        Next
        duracionCalculada = False
    End Sub

    Private Sub dg_LineasCitas_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellValidated
        'CalculaTotalesCita()
    End Sub

    'Private Sub dg_LineasCitas_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellMouseLeave
    '    If e.ColumnIndex = DescuentoPercent.Index Then
    '        Dim row As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(e.RowIndex).DataBoundItem.Row

    '        If dg_LineasCitas.Rows(e.RowIndex).Cells(DescuentoPercent.Index).Value > 0 Then
    '            Dim percent As Double = dg_LineasCitas.Rows(e.RowIndex).Cells(DescuentoPercent.Index).Value
    '            Dim totalLinea As Double = row.Cantidad * (row.ImporteClinica + row.ImporteDr)
    '            dg_LineasCitas.Rows(e.RowIndex).Cells(ColumnDtoImp.Index).Value = (percent / 100) * totalLinea
    '        End If
    '    End If
    '    If e.ColumnIndex = ColumnDtoImp.Index Then
    '        Dim row As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(e.RowIndex).DataBoundItem.Row

    '        If dg_LineasCitas.Rows(e.RowIndex).Cells(ColumnDtoImp.Index).Value > 0 Then
    '            Dim amount As Double = dg_LineasCitas.Rows(e.RowIndex).Cells(ColumnDtoImp.Index).Value
    '            Dim totalLinea As Double = row.Cantidad * (row.ImporteClinica + row.ImporteDr)
    '            If totalLinea > 0 Then
    '                dg_LineasCitas.Rows(e.RowIndex).Cells(DescuentoPercent.Index).Value = (amount / totalLinea) * 100
    '            End If
    '        End If
    '    End If
    '    CalculaTotalesCita()
    'End Sub

    Private Sub bt_AddLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AddLinea.Click
        Me.addLineaTicket()
    End Sub

    Private Sub bt_DelLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_DelLinea.Click
        If dg_LineasCitas.SelectedCells.Count > 0 Then
            Me.EliminarFila(dg_LineasCitas.SelectedCells(0).RowIndex)
        End If
    End Sub

    Private Sub cb_citaMultiple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_citaMultiple.CheckedChanged
        gb_citaMultiple.Visible = cb_citaMultiple.Checked
        grpFechaHora.Visible = Not cb_citaMultiple.Checked

        If cb_citaMultiple.Checked Then
            tb_horainiciocm.Value = tb_horainicio.Value
            tb_horafincm.Value = tb_horafin.Value
        Else
            tb_horainicio.Value = tb_horainiciocm.Value
            tb_horafin.Value = tb_horafincm.Value
        End If
    End Sub

    Private Sub tb_horainiciocm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horainiciocm.ValueChanged
        Me.tb_horainiciocm_TextChanged(Nothing, Nothing)
    End Sub


    Private Sub hacerVenta()

        Dim idPaciente As Integer
        Try
            idPaciente = CtrlPaciente1.ID_PACIENTE.Value
        Catch ex As Exception
            MessageBox.Show("Codigo de Paciente incorrecto...")
            Return
        End Try

        If CurrentAccion = Enums.Accion.Insertar Then
            MessageBox.Show("Debe salvar la cita antes de efectuar esta operacion")
            Return
        End If

        'Dim frm As New frmTPVTicketsEditar

        ''Dim frm As New frmTicket()
        ''frm.NuevoTicket()
        'frm.Nuevo = True
        'frm.CtrlPaciente1.ID_PACIENTE = idPaciente
        'frm.ShowDialog()


        Dim _ticket As New N_Ticket()
        _ticket.Codigo = Globales.GeneraCodigoAutomatico("N_Ticket", "ID_Ticket", "00000")
        _ticket.Fecha = Date.Now
        _ticket.ID_Cliente = Me.CtrlPaciente1.ID_PACIENTE

        Dim _context As New CMLinqDataContext
        _context.N_Tickets.InsertOnSubmit(_ticket)
        _context.SubmitChanges()

        Dim frm As New frmTPVTicketsEditar()
        frm.Nuevo = True
        frm.ID_Ticket = _ticket.ID_Ticket


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            frm.Context.SubmitChanges()
            _ticket = frm.Ticket
            If Not _ticket.PACIENTE Is Nothing Then
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Tickets_Ventas, "Ticket", _ticket.ID_Ticket, "[" & _ticket.Codigo & "] " & "Ticket TPV :" & _ticket.PACIENTE.NombreCompleto)
            End If
        End If



        'Ahora tengo que verificar si al crear el ticket, y casualmente le dio al form_Debito y pago la Cita actual

        Dim cita As CMDataSet.CITASRow = CITASTableAdapter.GetCitaById(fIdCITA)(0)
        If cita.PAGADA = "S" Then
            'Actualizar la forma de pago
            'Ponerla como pagada
            chb_pagada.Checked = True
            Try
                'If Not IsDBNull(cita.REFFORMAPAGO) Then
                tb_idforma.Text = cita.REFFORMAPAGO
                lb_forma.Text = GetFormaPago(cita.REFFORMAPAGO)
                'End If
            Catch ex As System.Data.StrongTypingException
                'usamos esta excepción para controlar cuando una cita está pagada pero no han asignado forma de pago
                'se intenta hacer con isDbNull pero por algún motivo no funciona de manera que capturamos la exceción que dispara
            End Try

        End If

    End Sub


    Private Sub tsb_DebitoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DebitoPaciente.Click
        If CurrentAccion = Enums.Accion.Insertar Then
            MessageBox.Show("Debe guardar primero la cita")
            Return
        End If
        'test
        If Not chb_atendido.Checked Then
            MessageBox.Show("Debe marcar como Atendida esta cita primero")
            chb_pagada.Checked = False
            Return
        End If
        Dim idPaciente As Integer
        If Guardar2() Then

            Try
                idPaciente = CtrlPaciente1.ID_PACIENTE.Value
            Catch ex As Exception
                MessageBox.Show("Codigo de Paciente incorrecto...")
                Return
            End Try
        Else
            Return
        End If

        'If CurrentAccion = Enums.Accion.Insertar Then
        '    MessageBox.Show("Debe salvar la cita antes de efectuar esta operacion")
        '    Return
        'End If


        Dim frm As New frmPacienteDebito
        frm.CtrlPaciente1.ID_PACIENTE = idPaciente
        frm.IdsCitasPreseleccionadas.Add(fIdCITA)

        'frm.dtp_Inicio.Checked = True
        'frm.dtp_Inicio.Value = dtp_fecha.Value

        If tb_idforma.Text <> String.Empty Then
            Dim context As New CMLinqDataContext
            frm.FormaPagoPreseleccionada = (From c In context.FORMASPAGOs Where c.CODIGO = tb_idforma.Text Select c).SingleOrDefault
        End If

        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Citas
        frm.ShowDialog()

        'If Not frm.FormaPagoSeleccionadaAlPagar Is Nothing Then

        'End If

        If frm.CitasPagadas.Count > 0 Then
            If frm.CitasPagadas.Count > 0 Then
                If Not frm.FormaPagoSeleccionadaAlPagar Is Nothing Then
                    tb_idforma.Text = frm.FormaPagoSeleccionadaAlPagar.CODIGO
                    lb_forma.Text = frm.FormaPagoSeleccionadaAlPagar.DESCRIPCION
                End If
            End If
        End If

    End Sub

    Private Function ConsultarUsuarioParaImporteMutuas() As Boolean
        'Comprobar si los conceptos facturables existentes estan asociadas a la tarifa de la mutua para preguntar si quiere hacer el proceso
        Dim mutua As MUTUA = cb_aseguradora.SelectedItem

        Dim tarifaAdapter As New CMDataSetTableAdapters.TarifasTableAdapter()
        Dim tarifaTable As New CMDataSet.TarifasDataTable()

        'Si tiene tarifa
        If mutua.IdTarifa.HasValue Then
            'Cargarla
            tarifaAdapter.FillBy(tarifaTable, mutua.IdTarifa)

            If (tarifaTable.Count > 0) Then
                For Each tarifa As CMDataSet.TarifasRow In tarifaTable.Rows
                    'If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto And recalcularConceptos Then

                    For Each row As DataGridViewRow In dg_LineasCitas.Rows
                        If row.Cells("colRefConcepto").Value = tarifa.IdConceptoFra Then
                            Return True
                        End If
                    Next
                Next
            End If
        End If

        Return False
    End Function

    Private Sub cb_aseguradora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_aseguradora.SelectedIndexChanged

        If cargando Then
            Return
        End If

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            Return
        End If

        If Me.IsHandleCreated Then
            If cb_aseguradora.SelectedIndex > -1 Then

                If chb_aseguradora.Checked Then
                    If dg_LineasCitas.Rows.Count > 0 Then
                        If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then

                            Dim res As DialogResult = Windows.Forms.DialogResult.No

                            If ConsultarUsuarioParaImporteMutuas() Then
                                res = MessageBox.Show("Desea recalcular los importes con la tarifa de la mutua seleccionada si procede?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                            End If

                            If res = Windows.Forms.DialogResult.Yes Then
                                recalcularConceptos = True
                                ChequeaTarifasEnLineasCita()
                            Else
                                recalcularConceptos = False

                                'Si la mutua seleccionada no tiene tarifa reasignar los precios originales

                                RestauraValoresConceptos()
                            End If
                        Else
                            'Se recalcula obligatoriamente sin preguntar
                            Dim mutua As MUTUA = cb_aseguradora.SelectedItem

                            If mutua.IdTarifa.HasValue Then
                                ChequeaTarifasEnLineasCita()
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ChequeaTarifasEnLineasCita()
        For Each row As DataGridViewRow In dg_LineasCitas.Rows
            ChequeaTarifaDeLinea(row)
        Next
        CalculaTotalesCita()
    End Sub

    Private Sub ChequeaTarifaDeLinea(ByRef row As DataGridViewRow)
        row.Cells("colImporteClinica").Value = ObtenImporteConceptoSegunTarifa(row.Cells("colRefConcepto").Value, row.Cells("colDescripcion").Value, row.Cells("colImporteClinica").Value)
    End Sub


    Private Sub chb_aseguradora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_aseguradora.CheckedChanged

        cb_aseguradora.Enabled = chb_aseguradora.Checked And cb_aseguradora.Items.Count > 0

        If cargando Then
            Return
        End If

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            Return
        End If

        If cb_aseguradora.Items.Count = 0 Then
            If chb_aseguradora.Checked Then
                MessageBox.Show("No hay mutuas asignadas a este paciente")
            End If

            Return
        End If

        recalcularConceptos = True

        If chb_aseguradora.Checked Then

            If dg_LineasCitas.Rows.Count > 0 Then
                If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                    Dim res As DialogResult = Windows.Forms.DialogResult.Yes

                    If ConsultarUsuarioParaImporteMutuas() Then
                        res = MessageBox.Show("Desea recalcular los importes con la tarifa de la mutua seleccionada si procede?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    End If

                    If res = Windows.Forms.DialogResult.Yes Then
                        recalcularConceptos = True
                        ChequeaTarifasEnLineasCita()
                    Else
                        recalcularConceptos = False
                    End If
                Else
                    'Se recalcula obligatoriamente
                    ChequeaTarifasEnLineasCita()
                End If

            End If
        Else
            If dg_LineasCitas.Rows.Count > 0 And cb_aseguradora.Items.Count > 0 Then
                cb_aseguradora.Enabled = True
                'Significa que habia antes una mutua aplicada y se le ha eliminado
                'se deben restaurar los valores originales
                'Si el usuario puede ver los importes se le preguntara antes de efectuar esta operacion
                If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                    Dim res As DialogResult = MessageBox.Show("Desea restaurar los importes de los conceptos a sus valores originales?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If res = Windows.Forms.DialogResult.Yes Then
                        recalcularConceptos = False
                        RestauraValoresConceptos()
                    Else
                        recalcularConceptos = False
                    End If
                Else
                    'Si no tiene permiso de ver importes, se recalcula obligatoriamente
                    RestauraValoresConceptos()
                End If
            End If
        End If
        CalculaTotalesCita()
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        CtrlStatusPaciente1.ID_PACIENTE = IdPaciente
        CargaHistorias()
        LLenaCombo(IdPaciente)
        Me.CargaFormadePagoPredeterminada(IdPaciente)
        tsb_DebitoPaciente.Enabled = True
        chb_aseguradora.Enabled = True
        If cb_aseguradora.SelectedIndex > -1 And CheckMutua Then chb_aseguradora.Checked = True

        If cb_aseguradora.SelectedIndex > -1 And chb_aseguradora.Checked = True Then
            recalcularConceptos = True
        End If

        Me.cargaSesionesPaciente()
        CargaBDCitas()
    End Sub

    Private Function ProcesosDePaciente(ByVal idPaciente) As CM3DataSet.N_Procesos_ResumenDataTable
        Dim adapter As New CM3DataSetTableAdapters.N_Procesos_ResumenTableAdapter()
        Dim table As New CM3DataSet.N_Procesos_ResumenDataTable()
        adapter.FillByPaciente(table, idPaciente)
        Return table
    End Function

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        tsb_DebitoPaciente.Enabled = False
        chb_aseguradora.Enabled = False
        chb_aseguradora.Checked = False

        CtrlStatusPaciente1.ID_PACIENTE = Nothing
        ContadorBono1.Visible = False
        'group_Proceso.Visible = False
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        chb_aseguradora.Enabled = False
        chb_aseguradora.Checked = False

        tsb_DebitoPaciente.Enabled = False
        cb_aseguradora.Enabled = False
        cb_aseguradora.Items.Remove(cb_aseguradora.Items)

        'LLenaCombo(-1)
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
        ContadorBono1.Visible = False
    End Sub

    Private Sub form_citas_sub_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        'Guardar()
    End Sub

    Private Sub btn_DesasociarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DesasociarFactura.Click
        If MessageBox.Show("Esta seguro que desea desasociar la factura, se perdera toda relacion con la cita", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim tempidfactura As Integer = fIdfactura
            Dim temptxtfactura As String = lb_ftexto.Text
            If tempidfactura > 0 And Len(temptxtfactura) > 0 Then


                DesvincultaFactura(fIdCITA)
                fIdfactura = Nothing
                lb_ftexto.Text = String.Empty
                Guardar()
                btn_DesasociarFactura.Visible = False
                bt_factura.Visible = True
                bt_factura.Enabled = True
                bntAsistenteFacturacion.Visible = True
                bntAsistenteFacturacion.Text = "Asist. Facturación"

                'Registro la desvinculación entre la cita y la fra
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Citas, _
                                            "Citas", fIdCITA, "Cita del paciente " & CtrlPaciente1.NombreCompleto & " del día " & dtp_fecha.Value & ". Desvincular Fra " & temptxtfactura & "(" & tempidfactura & ") de la cita.")
            Else
                MsgBox("No parece que esta cita esté asociada a ninguna factura")
            End If
        End If
        'fIdfactura = Nothing
        'lb_ftexto.Text = String.Empty
        'btn_DesasociarFactura.Visible = False
        'bt_factura.Visible = True
    End Sub

    Private Sub DesvincultaFactura(ByVal idcita As Integer)
        Try
            Dim lfacturas As List(Of LINEASFACTURA) = (From ln In context.LINEASFACTURAs Where ln.ID_Cita = fIdCITA Select ln).ToList

            Dim l As LINEASFACTURA
            For Each l In lfacturas
                l.ID_Cita = Nothing
                l.RefLineaCita = Nothing
            Next
            context.SubmitChanges()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al intentar eliminar la asociación entre la cita y la factura " & ex.Message)
        End Try

    End Sub

    Private Sub btn_HistorialProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HistorialProcesos.Click

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            Return
        End If
        Dim frm As New frmProcesos_Seleccionar()
        If IdProceso.HasValue Then
            frm.IDProcesoPreseleccionado = IdProceso.Value
        End If

        frm.ID_Paciente = CtrlPaciente1.ID_PACIENTE.Value
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not frm.SelectedProceso() Is Nothing Then
                IdProceso = frm.SelectedProceso().ID_Proceso
                lblCitaProcesoInfo.Text = "Cita vinculada a un proceso. Debe Guardar para hacer permanente este cambio"
            Else
                'Desmarco todo, significa eliminar cita de proceso
                IdProceso = Nothing
            End If
        End If
        btnVerProceso.Enabled = IdProceso.HasValue
    End Sub


    Private Sub btnVerProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProceso.Click
        Dim frm As New frmProcesos_ADD()
        frm.ID_Proceso = IdProceso
        frm.ShowDialog()
    End Sub



    Private Sub btnAddLineasPresupuestoDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            Return
        End If
        Dim frm As New frmDental_ListadoPresupuestos()
        frm.CtrlPaciente1.ID_PACIENTE = Me.CtrlPaciente1.ID_PACIENTE
        frm.CtrlPaciente1.Enabled = False


        frm.rbCitasAsociados.Enabled = False
        frm.rbCitasNoAsociados.Enabled = False
        frm.rbCitasTodos.Enabled = False
        frm.rbCitasNoAsociados.Checked = True
        frm.btnSeleccionarLineas.Visible = True
        frm.chkConfirmados.Checked = True
        frm.chkConfirmados.Enabled = False
        frm.chkRealizados.Enabled = False

        frm.Text = "Presupuestos de " & CtrlPaciente1.NombreCompleto
        frm.lblMsg.Visible = True
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each linea As d_PresupuestoLinea In frm.SelectedLineas
                addLineaDental(linea)
                'linea.IDCITA = fId
                'context.d_PresupuestoLineas.Attach(linea)
            Next
        End If

    End Sub

    Private Sub btnAddLineasGenericas_Click(sender As System.Object, e As System.EventArgs) Handles btnAddLineasGenericas.Click
        If CurrentAccion = Enums.Accion.Insertar Then
            If MessageBox.Show("Debe guardar la cita antes de importar lineas." & vbCrLf & "¿Desea guardar y continuar la importación?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Not Guardar() Then Return
            Else
                Return
            End If
        End If
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            Dim frm As New frmCita_ImportarLineas()
            frm.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                For Each tratamiento As LCOMPARATIVAS_TRATAMIENTO In frm.ListaTratamientos
                    addLineaTratamientos(tratamiento)
                Next
                For Each lineaPresupuesto As d_PresupuestoLinea In frm.ListaLineasPresupuesto
                    addLineaDental(lineaPresupuesto)
                Next
                Guardar2()
            End If
        End If
    End Sub


    Public Sub addLineaDental(ByVal lineapresupuesto As d_PresupuestoLinea)

        Dim row As CMDataSet.LineasCitasRow
        'If Me.fDesdePaciente Then
        '    row = Me.fCMDataSet.LineasCitas.NewLineasCitasRow
        'Else
        row = Me.CMDataSet.LineasCitas.NewLineasCitasRow
        'End If

        Dim idCita As Integer = -1


        If Me.CurrentAccion = Enums.Accion.Modificar Then
            idCita = Me.fIdCITA
            'si es una nueva cita en el evento de aceptar actualizo todas las lineas el idcita.
        End If

        'valores por defecto
        row.Cantidad = 1

        If lineapresupuesto.DescuentoPercent.HasValue Then
            row.DescuentoPercent = lineapresupuesto.descuentoPorcentaje
        Else
            row.DescuentoPercent = 0
        End If

        row.ImporteClinica = lineapresupuesto.Importe + lineapresupuesto.DescuentoPercent
        row.Total = lineapresupuesto.Importe

        'If lineapresupuesto.DescuentoPercent > 0 Then
        '    row.ImporteClinica = lineapresupuesto.Importe + lineapresupuesto.DescuentoPercent
        '    row.DescuentoPercent = (lineapresupuesto.DescuentoPercent / row.ImporteClinica) * 100
        'Else
        '    row.ImporteClinica = lineapresupuesto.Importe
        '    row.Total = lineapresupuesto.Importe
        'End If

        '9row.DescuentoPercent = 0
        row.ImporteDr = 0
        row.DESCRIPCION = lineapresupuesto.DescripcionGenerada
        row.IdCita = idCita
        row.RefConcepto = lineapresupuesto.IDTratamiento
        row.RefLineaPresupuestoDental = lineapresupuesto.IDPresupuestoLinea ' lo marco para ponerle el id luego lineapresupuesto.IDPresupuestoLinea

        row.Duracion = New Date(2000, 1, 1, 0, 0, 0)
        'If Me.fDesdePaciente Then
        '    fCMDataSet.LineasCitas.Rows.Add(row)
        'Else
        CMDataSet.LineasCitas.Rows.Add(row)
        'End If


        'Gana el foco el campo Articulo de la ultima fila que es la que acabo de añadir.
        If Me.dg_LineasCitas.Rows.Count > 0 Then
            Me.dg_LineasCitas.ClearSelection()
            Me.dg_LineasCitas.MultiSelect = False
            Me.dg_LineasCitas.Focus()
            Dim rowGrid As DataGridViewRow = dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.GetLastRow(DataGridViewElementStates.Displayed))

            'Dim cellDuracion As New DataGridViewTextBoxCell()
            'cellDuracion.Value = Date.Now()
            'rowGrid.Cells("Duracion").Value = Date.Now()

            Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells("ColRefConcepto").Selected = True
            'Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells(ColumnDtoImp.Index).Value = lineapresupuesto.DescuentoPercent
            Me.dg_LineasCitas.MultiSelect = True
            CalculaFila(rowGrid, colImporteClinica.Index)
            dg_LineasCitas.EndEdit()
            LineasCitasBindingSource.EndEdit()
            dg_LineasCitas.Refresh()

        End If
        cambios = True
        'RecalculaImporteMedico()

        CalculaTotalesCita()

    End Sub

    Public Sub addLineaTratamientos(ByVal tratamiemto As LCOMPARATIVAS_TRATAMIENTO)

        Dim row As CMDataSet.LineasCitasRow
        row = Me.CMDataSet.LineasCitas.NewLineasCitasRow
        Dim idCita As Integer = -1


        If Me.CurrentAccion = Enums.Accion.Modificar Then
            idCita = Me.fIdCITA
            'si es una nueva cita en el evento de aceptar actualizo todas las lineas el idcita.
        End If

        'valores por defecto
        row.Cantidad = 1
        row.ImporteClinica = 0

        Dim context As New CMLinqDataContext()

        If Not tratamiemto.REFCONCEPTOFRA Is Nothing Then
            Dim concepto As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = tratamiemto.REFCONCEPTOFRA Select c).SingleOrDefault()
            If Not concepto Is Nothing Then
                concepto.IMPORTE = concepto.IMPORTE
            End If
        End If

        row.ImporteDr = 0
        row.DESCRIPCION = tratamiemto.Tratamiento
        row.IdCita = idCita
        row.RefConcepto = tratamiemto.REFCONCEPTOFRA
        row.RefLineaTratamiento = tratamiemto.ID ' lo marco para ponerle el id luego lineapresupuesto.IDPresupuestoLinea
        'row.Duracion = New Date(2000, 1, 1, 0, 0, 0)        
        CMDataSet.LineasCitas.Rows.Add(row)

        'Gana el foco el campo Articulo de la ultima fila que es la que acabo de añadir.
        If Me.dg_LineasCitas.Rows.Count > 0 Then
            Me.dg_LineasCitas.ClearSelection()
            Me.dg_LineasCitas.MultiSelect = False
            Me.dg_LineasCitas.Focus()
            Dim rowGrid As DataGridViewRow = dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.GetLastRow(DataGridViewElementStates.Displayed))

            'Dim cellDuracion As New DataGridViewTextBoxCell()
            'cellDuracion.Value = Date.Now()
            'rowGrid.Cells("Duracion").Value = Date.Now()

            Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells("ColRefConcepto").Selected = True
            'Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells(ColumnDtoImp.Index).Value = lineapresupuesto.DescuentoPercent
            Me.dg_LineasCitas.MultiSelect = True
        End If
        cambios = True
        RecalculaImporteMedico()
        CalculaTotalesCita()
    End Sub


    Private Sub dg_LineasCitas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg_LineasCitas.MouseLeave
        'CalculaTotalesCita()
    End Sub

    Private Sub btnDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDental.Click
        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente primero")
            Return
        End If

        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe seleccionar un médico")
            Return
        End If

        Dim frm As New frmOdontograma()
        frm.PacienteActual = CtrlPaciente1.ID_PACIENTE.Value
        frm.MedicoPreseleccionado = CtrlMedico1.ID_Medico
        frm.ShowDialog()
        'Inicializa()
    End Sub

    Private Sub pb_facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_facturas.Click

    End Sub

    Private Sub CtrlSalasvb1_SalaSeleccionada(IdSala As System.Int32) Handles CtrlSalasvb1.SalaSeleccionada
        ChequeaSala()
    End Sub

    Private Sub ChequeaSala()
        'grp_SalaDisponible.Visible = True
        Try
            If Me.CurrentAccion = Enums.Accion.Insertar Then
                If CtrlSalasvb1.ID_SALA.HasValue Then
                    grp_SalaDisponible.Visible = Not Globales.EstaDisponibleSala(CtrlSalasvb1.ID_SALA, dtp_fecha.Value, tb_horainicio.Value, tb_horafin.Value)
                End If
            Else
                If CtrlSalasvb1.ID_SALA.HasValue Then
                    grp_SalaDisponible.Visible = Not Globales.EstaDisponibleSala(CtrlSalasvb1.ID_SALA, dtp_fecha.Value, tb_horainicio.Value, tb_horafin.Value, Me.fIdCITA)
                End If
            End If
            'Console.WriteLine("checkea sala")
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error en form_citas.ChequeaSala()")
        End Try
    End Sub

    Private Sub CtrlSalasvb1_SalaEliminada(idSala As System.Int32) Handles CtrlSalasvb1.SalaEliminada
        grp_SalaDisponible.Visible = False
    End Sub

    Private Sub dtp_fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtp_fecha.ValueChanged
        ChequeaSala()
        ChequeaFechaDiaDisponible()

    End Sub
    Private Sub HorarioMedico(ByVal medicoid As Integer)
        Dim context As New CMLinqDataContext
        Dim dias As New List(Of Date)
        dias.Add(dtp_fecha.Value)
        Dim medico As MEDICO = (From o In context.MEDICOs Where o.CMEDICO = medicoid Select o).SingleOrDefault
        Dim mensaje As String = ""
        horas = medico.horasOcupadas(dias, context).ToList

        If (horas.Count > 0) Then
            For Each h As HORARIOS_MEDICOS In horas
                mensaje = mensaje & "Horario de: " & h.hora_ini.ToShortTimeString & " a " & h.hora_fin.ToShortTimeString & vbCrLf
            Next
            lblHorarioEspecial.Text = mensaje
            lblHorarioEspecial.Visible = True

            'Mostrará un mensaje si el horario definido esta fuera del horario laboral del profesional.
            HoraNoLaboral()
        Else
            lblHorarioEspecial.Visible = False
        End If


    End Sub
    Private Sub HoraNoLaboral()
        Dim eslaboral As Boolean = True
        'copmrobar si la hora inicio y fin estan dentro del intervalo de horario laboral del profesional.
        Try
            If (horas.Count > 0) Then
                'si hay varios intervalos de horas y uno de ellos es se cumple usamos la variable checksalir
                ' para no comprobar más ya que si comprobamos con otro intervalo
                'va a dar como resultado que la hora no es laborable.
                Dim checksalir As Boolean = False
                For Each h As HORARIOS_MEDICOS In horas
                    Dim hini As New DateTime(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, tb_horainicio.Value.Hour, tb_horainicio.Value.Minute, 0)
                    Dim hfin As New DateTime(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, tb_horafin.Value.Hour, tb_horafin.Value.Minute, 0)

                    If hini >= h.hora_ini And hini <= h.hora_fin And hfin >= h.hora_ini And hfin <= h.hora_fin Then
                        checksalir = True
                        eslaboral = True
                    Else
                        'si no se cumple entonces es una hora no laboral
                        eslaboral = False
                    End If
                    If checksalir = True Then Exit For
                Next
                If Not eslaboral Then
                    MsgBox("El horario definido no es laborable para este profesional  y  este día. Esto solo es un aviso, puede continuar con la cita si lo desea.", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch nullex As NullReferenceException
            'llegará aqui si horas es null
        End Try
    End Sub
    Private Sub ChequeaFechaDiaDisponible()
        If CtrlMedico1.ID_Medico.HasValue Then
            'Antes de comprobar los días que no trabaja, chequeo si tiene horario especial en el día seleccionado en la cita.
            Me.HorarioMedico(CtrlMedico1.ID_Medico)

            Dim dia As ctrlHorarios.TipoFecha = CalendarioManager.DameTipoDiaDe(CtrlMedico1.ID_Medico, dtp_fecha.Value)
            If dia <> ctrlHorarios.TipoFecha.DiasLaborables Then
                grpFechaHora.Text = "Fecha no laborable para este doctor"
                grpFechaHora.ForeColor = Color.Red
            Else
                grpFechaHora.Text = "Fecha"
                grpFechaHora.ForeColor = SystemColors.ControlText
            End If
        Else
            grpFechaHora.Text = "Fecha"
            grpFechaHora.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub lnkSugerirHorario_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSugerirHorario.LinkClicked
        Dim duration As TimeSpan = tb_horafin.Value - tb_horainicio.Value
        If (Not CtrlSalasvb1.ID_SALA Is Nothing) Then
            dtp_fecha.Value = FindFreeSlot(tb_horainicio.Value, duration, CtrlSalasvb1.ID_SALA)
            tb_horainicio.Value = dtp_fecha.Value
            tb_horafin.Value = dtp_fecha.Value.Add(duration)
        End If
        ''Dim horario As Date = Globales.HorarioDisponible(CtrlSalasvb1.ID_SALA, dtp_fecha.Value, tb_horainicio.Value, tb_horafin.Value)
        ''If Not horario = Nothing Then
        ''    MessageBox.Show("Horario disponible es : " & horario.ToShortTimeString())
        ''End If

        ''Dim startDate As Date = dtp_fecha.Value
        ''Dim startDate As Date = dtp_fecha.Value


        'Dim frm As New frmSalas
        ''frm.WindowState = FormWindowState.Minimized
        'frm.FechaSugerida = dtp_fecha.Value

        'frm.dt_Duracion.Value = dtp_fecha.Value.Add(tb_horafin.Value - tb_horainicio.Value)
        'frm.ID_SALA = CtrlSalasvb1.ID_SALA

        'frm.Modo = Globales.ModoParaFormas.Seleccion
        'frm.UiTab1.SelectedIndex = 1
        'frm.AutoSugerir = True
        ''frm.SugerirCita()
        'AddHandler frm.HoraSugerida, AddressOf HoraSugerida
        'frm.Show()
        ''If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        ''    dtp_fecha.Value = frm.Cita.FECHA
        ''    tb_horainicio.Value = frm.Cita.FECHA
        ''    tb_horafin.Value = frm.Cita.FECHA.Value.Add(frm.dt_Duracion.Value.TimeOfDay)
        ''End If

    End Sub

    Private Function FindFreeSlot(ByVal fechaStart As Date, ByVal duration As TimeSpan, ByVal idSala As Integer)

        Dim fechaEnd As Date = fechaStart.Add(duration)

        Dim context As New CMLinqDataContext()
        Dim cita As List(Of CITA) = (From c In context.CITAs _
                                    Where c.HORA >= fechaStart And c.HORAFIN <= fechaEnd And c.Eliminado = False _
                                    And c.ID_SALA = idSala
                                    Select c).ToList()
        If cita.Count = 0 Then
            Return fechaStart
        Else
            If fechaEnd.Add(duration).TimeOfDay > centro_medico.Globales.Configuracion.DameJornadaLaboralFinal(fechaEnd) Then
                Dim tmp As Date = fechaEnd.AddDays(1)
                Dim newDate As Date = New Date(tmp.Year, tmp.Month, tmp.Day).Add(centro_medico.Globales.Configuracion.DameJornadaLaboralInicio(tmp))
                Return FindFreeSlot(newDate, duration, idSala)
            Else
                Return FindFreeSlot(fechaEnd, duration, idSala)
            End If
        End If
    End Function

    Private Sub HoraSugerida(ByVal fecha As Date)
        dtp_fecha.Value = fecha
        tb_horainicio.Value = fecha
        'tb_horafin.Value = fecha.Add(dtp_Duracion.Value.TimeOfDay)

    End Sub

    Private Function ValidaSalvado() As Boolean
        Dim hIni As New Date(Me.dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day _
                             , tb_horainicio.Value.Hour, tb_horainicio.Value.Minute, tb_horainicio.Value.Second)

        Dim hFin As New Date(Me.dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day _
                            , tb_horafin.Value.Hour, tb_horafin.Value.Minute, tb_horafin.Value.Second)

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe entrar un paciente válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CtrlPaciente1.Focus()
            Return False
        End If

        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe entrar un medico válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CtrlMedico1.Focus()
            Return False
        End If

        If hFin <= hIni Then
            MessageBox.Show("Hora Final no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_horafin.Focus()
            Return False
        End If

        If hIni.TimeOfDay < Globales.Configuracion.DameJornadaLaboralInicio(hIni) Or hFin.TimeOfDay > Globales.Configuracion.DameJornadaLaboralFinal(hFin) Then
            MessageBox.Show("Hora Inicial no válida. La jornada laboral configurada es de " + Globales.Configuracion.DameJornadaLaboralInicio(hIni).ToString + " a " + Globales.Configuracion.DameJornadaLaboralFinal(hIni).ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_horainicio.Focus()
            Return False
        End If

        If hFin.TimeOfDay >= Globales.Configuracion.DameJornadaLaboralFinal(hFin) Then
            MessageBox.Show("Hora Final no válida. La jornada laboral configurada es de " + Globales.Configuracion.DameJornadaLaboralInicio(hIni).ToString() & " a " & Globales.Configuracion.DameJornadaLaboralFinal(hIni).ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_horainicio.Focus()
            Return False
        End If








        'Verificar si la sala no esta ocupada
        If grp_SalaDisponible.Visible Then
            If MessageBox.Show("No esta disponible esta Sala/Consulta en este horario. Debe cambiar la hora de la cita ") Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Function Guardar2() As Boolean
        '** GUARDO LAS LINEAS DE LAS CITAS CUANDO LA CITA NO ES ABIERTA DESDE EL FORM DE PACIENTES ***
        'actualizo el id de las lineas citas con el nuevo id de la cita
        CITASBindingSource.EndEdit()
        LineasCitasBindingSource.EndEdit()

        If Not ValidaSalvado() Then
            Return False
        End If



        Dim total As Double = 0
        Dim descuento As Double = 0
        Dim _importeclinica As Double = 0
        Dim _importedr As Double = 0
        Try
            _importeclinica = Double.Parse(tb_clinica.Text.Trim(), Globalization.NumberStyles.Currency)
            _importedr = Double.Parse(tb_dr.Text.Trim(), Globalization.NumberStyles.Currency)
            total = Double.Parse(lb_total.Text, System.Globalization.NumberStyles.Currency)
            descuento = Double.Parse(txtDescuentoTotal.Text, System.Globalization.NumberStyles.Currency)
        Catch ex As Exception

        End Try


        Dim i As Integer = 0
        For i = 0 To Me.CMDataSet.LineasCitas.Rows.Count - 1
            Me.CMDataSet.LineasCitas.Rows(i).Item("IdCita") = fIdCITA
        Next
        Me.LineasCitasBindingSource.CurrencyManager.EndCurrentEdit()
        Me.LineasCitasTableAdapter.Update(CMDataSet.LineasCitas)
        Me.CMDataSet.LineasCitas.AcceptChanges()



        Try
            'Dim context As New CMLinqDataContext()

            Dim idCita As Integer = fIdCITA
            If idCita = 0 Then
                idCita = fIdCITA
            End If

            Dim cita As CITA = (From c In context.CITAs
                               Where c.IDCITA = idCita
                               Select c).SingleOrDefault()

            cita.ATENDIDO = "S"
            cita.IMPORTECL = _importeclinica
            cita.IMPORTEDR = _importedr
            cita.Descuento = descuento
            cita.TOTAL = total


            If Not cita Is Nothing Then
                cita.ID_SALA = CtrlSalasvb1.ID_SALA

                context.SubmitChanges()

                ' Me.ContadorBono1.Visible = False
                Me.ContadorBono1.cita = cita
                ' Me.ContadorBono1.context = context
                Me.cargaSesionesPaciente()

            End If


            For Each lineacita As CMDataSet.LineasCitasRow In CMDataSet.LineasCitas
                If Not lineacita.IsRefLineaPresupuestoDentalNull Then
                    'Actualizar el presupuesto correspondiente                     
                    Dim lineaPresupuesto As d_PresupuestoLinea = (From l In context.d_PresupuestoLineas Where l.IDPresupuestoLinea = lineacita.RefLineaPresupuestoDental Select l).SingleOrDefault()
                    If Not lineaPresupuesto Is Nothing Then
                        If fIdCITA = 0 Then
                            lineaPresupuesto.IDCITA = fIdCITA
                        Else
                            lineaPresupuesto.IDCITA = fIdCITA
                        End If
                    End If
                End If
                If Not lineacita.IsRefLineaTratamientoNull Then
                    Dim lineaTratamiento As LCOMPARATIVAS_TRATAMIENTO = (From lin In context.LCOMPARATIVAS_TRATAMIENTOs Where lin.ID = lineacita.RefLineaTratamiento Select lin).SingleOrDefault
                    If Not lineaTratamiento Is Nothing Then
                        If fIdCITA = 0 Then
                            lineaTratamiento.ID_Cita = fIdCITA
                            lineaTratamiento.ID_LineaCita = lineacita.IdCita
                        Else
                            lineaTratamiento.ID_Cita = fIdCITA
                            lineaTratamiento.ID_LineaCita = lineacita.IdCita
                        End If
                        lineaTratamiento.Facturada = True
                    End If

                End If
            Next
            context.SubmitChanges()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub cargaSesionesPaciente()
        If ContadorBono1.context Is Nothing Then ContadorBono1.context = context
        If Not ContadorBono1.context Is Nothing Then
            Me.ContadorBono1.codigopaciente = Me.CtrlPaciente1.ID_PACIENTE
            Me.ContadorBono1.CargaSesionesLibres()
        End If
    End Sub
    Private Sub chb_pagada_Click(sender As System.Object, e As System.EventArgs) Handles chb_pagada.Click

        'Validaciones
        If Not chb_atendido.Checked Then
            MessageBox.Show("Debe marcar como Atendida esta cita primero")
            chb_pagada.Checked = False
            Return
        End If

        If Not Guardar2() Then
            Return
        End If

        chb_pagada.Checked = False

        Dim contextPago As New CMLinqDataContext
        Dim cita = (From c In contextPago.CITAs Where c.IDCITA = fIdCITA Select c).SingleOrDefault

        If Not cita Is Nothing Then
            Dim pdm As New PacienteDebitoManager(CtrlPaciente1.Paciente, contextPago, Nothing)

            If pdm.PagarDocumentos({cita},
                                    New frmPagarDocumentos(Me.dtp_fechacobro.Value),
                                    tb_idforma.Text,
                                    Globales.Usuario.CODIGO,
                                   contextPago) = Windows.Forms.DialogResult.OK Then

                chb_pagada.Checked = True
                chb_pagada.Enabled = False
                dtp_fechacobro.Value = cita.FECHACOBRO
                tb_idforma.Text = cita.REFFORMAPAGO
            End If

        End If

    End Sub

    Private Sub dg_LineasCitas_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dg_LineasCitas.DataError
        If e.ColumnIndex = dg_LineasCitas.Columns("Duracion").Index Then
            e.ThrowException = False
            e.Cancel = True
        End If
    End Sub


    Private Sub CtrlStatusPaciente1_CitaPagada(ByVal idCita As Integer) Handles CtrlStatusPaciente1.CitaPagada
        If idCita = fIdCITA Then
            chb_pagada.Checked = True
            chb_pagada.Enabled = Not chb_pagada.Checked
            'bntAsistenteFacturacion.Enabled = False
        End If
    End Sub

    Private Function ChequeaSiCitaEstaPagada(ByVal idCita As Integer)
        Dim context As New CMLinqDataContext
        Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = idCita Select c).SingleOrDefault()
        If cita Is Nothing Then
            Return False
        End If
        Return cita.PAGADA = "S"
    End Function

    Private Sub bntAsistenteFacturacion_Click(sender As System.Object, e As System.EventArgs) Handles bntAsistenteFacturacion.Click

        If CurrentAccion = Enums.Accion.Insertar Then
            MessageBox.Show("Debe guardar primero la cita")
            Return
        End If

        If Not chb_confirmada.Checked Or Not chb_atendido.Checked Then
            MessageBox.Show("La cita debe estar confirmada y atendida para ser facturada")
            Return
        End If

        If fIdfactura.HasValue Then
            'Mostrar la Factura
            Dim context As New CMLinqDataContext()
            Dim factura As FACTURA = (From f As FACTURA In context.FACTURAs Where f.IDFACTURA = fIdfactura Select f).SingleOrDefault()
            Dim frm As New frmFacturasM_ADD()
            frm.FacturadaGeneradaDesdeCita = True
            frm.Factura = factura
            frm.Context = context
            If frm.ShowDialog() = DialogResult.OK Then
                context.SubmitChanges()
            End If
            If frm.Factura.PAGADA = "S" Then
                chb_pagada.Checked = True
            End If
        Else
            If Guardar2() Then
                Dim frm As New frmPartes_AsistenteFacturacion()
                frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
                frm.IdCitaPreseleccionada = fIdCITA
                frm.chkMostrarCero.Checked = True

                If chb_aseguradora.Checked Then
                    frm.rbCitasMutuas.Checked = True
                Else
                    frm.rbCitas_Paciente.Checked = True
                End If
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If frm.CitasFacturadas.Keys.Contains(fIdCITA) Then
                        'Ya fue facturada
                        'bntAsistenteFacturacion.Enabled = False
                        bntAsistenteFacturacion.Text = "Ver factura"

                        pb_facturas.Visible = True
                    End If
                End If
                Inicializa()
            End If
        End If
        CtrlStatusPaciente1.CargaDatos()

    End Sub

    Private Sub CtrlStatusPaciente1_FacturaPagada(id As System.Int32) Handles CtrlStatusPaciente1.FacturaPagada
        If id = fIdfactura Then
            chb_pagada.Checked = True

        End If
    End Sub


    Private HuboCambiosDeDoctor As Boolean = False
    Private HuboCambiosEnComisiones As Boolean = False



    Private Sub CtrlMedico1_MEDICOSeleccionado(IdMedico As System.Int32, ByVal oldMedico As Nullable(Of Integer), IsReturnPressed As System.Boolean) Handles CtrlMedico1.MEDICOSeleccionado
        If oldMedico.HasValue Then
            HuboCambiosDeDoctor = True
        Else
            HuboCambiosDeDoctor = False
        End If
        RecalculaImporteMedico()
        'End If
        ChequeaFechaDiaDisponible()
        CargaBDCitas()
    End Sub

    Private Sub CtrlMedico1_MedicoNoEncontrado() Handles CtrlMedico1.MedicoNoEncontrado
        RecalculaImporteMedico()
        ChequeaFechaDiaDisponible()
    End Sub

    Private Sub CtrlMedico1_MEDICOEliminado(IdMedicoAnterior As System.Int32) Handles CtrlMedico1.MEDICOEliminado
        RecalculaImporteMedico()
        ChequeaFechaDiaDisponible()
    End Sub

    Private Sub RecalculaImporteMedico()
        'If Globales.Configuracion.Cita_IncluirPrecioDelMedicoEnLasLineas Then
        'El importe del medico se deduce del todal basado en el % sin afectar el total, re
        'If CtrlMedico1.ID_Medico.HasValue Then
        HuboCambiosEnComisiones = False
        For Each row As DataGridViewRow In dg_LineasCitas.Rows
            AjustaImportes(row)
        Next
        If HuboCambiosDeDoctor And HuboCambiosEnComisiones Then
            MessageBox.Show("Nota: Se cambiaron algunas comisiones")
            'HuboCambiosDeDoctor = False
            HuboCambiosEnComisiones = False
        End If

        CalculaTotalesCita()
    End Sub


    Function CalculaImporteMedico(ByRef row As DataGridViewRow, ByRef huboCambiosEnComisiones As Boolean) As Double

        If Not Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then
            Return 0
        End If

        If Not CtrlMedico1.ID_Medico.HasValue Then
            'Aun si no hay medico seleccionado si existe un valor global se usara
            If Globales.Configuracion.Cita_Medico_PorcientoGlobal > 0 Then
                Return Globales.Configuracion.Cita_Medico_PorcientoGlobal
            End If
            Return 0
        End If



        If Not row.DataBoundItem Is Nothing Then
            Dim lineaCita As CMDataSet.LineasCitasRow = row.DataBoundItem.Row
            If Not lineaCita.IsRefConceptoNull Then
                If lineaCita.RefConcepto <> "" Then
                    Return CtrlMedico1.Medico.PorcientoCitaReal(lineaCita.RefConcepto, huboCambiosEnComisiones)
                Else
                    Return CtrlMedico1.Medico.PorcientoCitaReal(Nothing, huboCambiosEnComisiones)
                End If
            End If
        End If
        Return 0
    End Function


    Private Sub pb_UndoCobrar_Click(sender As System.Object, e As System.EventArgs) Handles pb_UndoCobrar.Click
        If Globales.Usuario.EsAdministrador Then
            If Me.chb_pagada.Checked AndAlso MessageBox.Show("Como Administrador puede marcar como no pagada esta cita, pero esto puede traer consecuencias en los pagos/entregas efectuados: Desea continuar?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                chb_pagada.Checked = False
                chb_pagada.Enabled = True

                If Guardar2() Then
                    Dim context As New CMLinqDataContext
                    Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = fIdCITA Select c).Single
                    If Not cita Is Nothing Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Citas, "Descobrar Cita", fIdCITA, String.Format("Descobrada cita {0}-{1}-{2} importe {3}", cita.IDCITA, cita.FECHA, cita.PACIENTE, cita.TOTAL))
                    End If
                    cita.MarcarDespagado()
                    context.Dispose()
                    Me.Guardar()
                End If

            End If
        ElseIf Me.chb_pagada.Checked Then
            MsgBox("Debe ser del grupo de administradores para poder ""despagar"" una cita", MsgBoxStyle.Information)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Citas, "Descobrar Cita", fIdCITA, _
                                            String.Format("El usuario {0} que no es administrador ha intentado descobrar la cita del -{1}-{2}", _
                                                          Globales.Usuario.NOMBRECOMPLETO, Me.dtp_fecha.Value.ToShortDateString, Me.tb_horainicio.Value.ToShortTimeString))

        End If
    End Sub

    Private Sub Imprimir_JustificanteAsistencia()
        Try


            Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
            ds.Name = "dsCita"

            If Not Guardar() Then
                Return
            End If

            Dim context As New CMLinqDataContext()
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = fIdCITA Select c).SingleOrDefault()
            If cita Is Nothing Then
                Return
            End If

            Dim wrapper As WRAPPER_CITA = New WRAPPER_CITA(cita)
            Dim list As New List(Of WRAPPER_CITA)
            list.Add(wrapper)

            ds.Value = list

            UI.Reportes.ReportesManager.Imprime("CitaJustificanteAsistencia.rdlc", {ds})

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir, RoleManager.Items.Citas, "Imprimir Cita", Me.fIdCITA.ToString(), CtrlPaciente1.NombreCompleto)

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error")
        End Try

    End Sub

    Private Sub listadoTickets()
        Dim frm As New frmTPVTicketsListado
        frm.ShowDialog()
    End Sub



    Private Sub tstImprimirCita_Click(sender As System.Object, e As System.EventArgs)
        ImprimirCita()
    End Sub



    Private Sub tlsVerPacienteSeleccionado_Click(sender As Object, e As EventArgs) Handles tlsVerPacienteSeleccionado.Click
        Me.CtrlPaciente1.abrirFicha()
    End Sub

    Private Sub tsm_imprimircita_Click(sender As Object, e As EventArgs) Handles tsm_imprimircita.Click
        ImprimirCita()
    End Sub

    Private Sub tsm_imprimirjustificante_Click(sender As Object, e As EventArgs) Handles tsm_imprimirjustificante.Click
        Imprimir_JustificanteAsistencia()
    End Sub

    Private Sub HacerTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HacerTicketToolStripMenuItem.Click
        Me.hacerVenta()
    End Sub

    Private Sub ListadoDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTicketsToolStripMenuItem.Click
        listadoTickets()
    End Sub


    Private Sub tb_horafin_Enter(sender As Object, e As EventArgs) Handles tb_horafin.ValueChanged
        Me.HoraNoLaboral()
    End Sub


    Private Sub ContadorBono1_asociarCita() Handles ContadorBono1.asociarCita
        If Guardar() Then
            '  Me.DialogResult = Windows.Forms.DialogResult.OK
            '  Me.Close()
        End If
    End Sub

    Private Sub bt_ActualizaNumeracion_Click(sender As Object, e As EventArgs) Handles bt_ActualizaNumeracion.Click
        CargaBDCitas()
    End Sub

    Private Sub CargaBDCitas()

        Dim dt As DataTable
        If CtrlPaciente1.ID_PACIENTE.HasValue And CtrlMedico1.txt_Especialidad.Text <> "" Then

            If CurrentAccion = Enums.Accion.Insertar Then

                Dim query As String = "SELECT IDCITA,NumeroCita FROM citas c INNER JOIN dbo.MEDICOS m ON c.REFMEDICO = m.CMEDICO WHERE REFPACIENTE='" & CtrlPaciente1.ID_PACIENTE &
                                "' AND ESPECIALIDAD='" & CtrlMedico1.txt_Especialidad.Text & "'AND FALTA='N' AND c.Eliminado=0"
                dt = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, query).Tables(0)

                If dt.Rows.Count() = 0 Then
                    CBcitas.SelectedItem = "1ra Cita"
                    citas = 1
                Else
                    citas = If(((dt.Rows(dt.Rows.Count() - 1).Item("NumeroCita")).ToString() <> ""), Convert.ToInt32(dt.Rows(dt.Rows.Count() - 1).Item("NumeroCita")), -1)

                    If citas = -1 Or citas = 0 Then citas = dt.Rows.Count()

                    If citas > 2 Then
                        CBcitas.SelectedItem = "Cita Sucesiva"
                    ElseIf citas = 2 Then
                        CBcitas.SelectedItem = "3ra Cita"
                    ElseIf citas = 1 Then
                        CBcitas.SelectedItem = "2da Cita"
                    End If
                    citas = citas + 1
                End If
            End If
            If CurrentAccion = Enums.Accion.Modificar Or CurrentAccion = Enums.Accion.Ver Then

                Dim query As String = "SELECT IDCITA,NumeroCita FROM citas c INNER JOIN dbo.MEDICOS m ON c.REFMEDICO = m.CMEDICO WHERE REFPACIENTE='" & CtrlPaciente1.ID_PACIENTE &
                                "' AND ESPECIALIDAD='" & CtrlMedico1.txt_Especialidad.Text & "'AND FALTA='N' AND c.Eliminado=0 AND IDCITA <= " & cit.IDCITA
                dt = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, query).Tables(0)

                If (Not cit.NumeroCita Is Nothing) Then
                    citas = cit.NumeroCita
                Else
                    citas = -1
                End If

                If citas = -1 Or citas = 0 Then citas = dt.Rows.Count()

                If citas > 3 Then
                    CBcitas.SelectedItem = "Cita Sucesiva"
                    citas = 4
                ElseIf citas = 3 Then
                    CBcitas.SelectedItem = "3ra Cita"
                ElseIf citas = 2 Then
                    CBcitas.SelectedItem = "2da Cita"
                ElseIf citas = 1 Then
                    CBcitas.SelectedItem = "1ra Cita"
                End If
            End If
            cambioCT = citas
        End If
    End Sub

End Class

Partial Public Class MEDICO

    Public Function PorcientoCitaReal(ByVal codigoConcepto As String, ByRef HuboCambiosEnComisiones As Boolean) As Double
        Try
            If codigoConcepto <> "" Then
                Dim context As New CMLinqDataContext()

                Dim medico_fra As MEDICOS_CONCEPTOFRA = (From cm As MEDICOS_CONCEPTOFRA In context.MEDICOS_CONCEPTOFRAs _
                                                        Where cm.CODIGO = codigoConcepto And cm.CMEDICO = Me.CMEDICO
                                                        Select cm).SingleOrDefault()

                If Not medico_fra Is Nothing Then
                    If medico_fra.ImportePorciento > 0 Then
                        HuboCambiosEnComisiones = True
                        Return medico_fra.ImportePorciento
                    End If
                End If
            End If


            'Si tiene valor el concepto prevalece
            'Sino el valor a nivel de medico
            'Sino el Global
            'Sino 0         


            'Revisar valor a nivel de medico
            If Me.PorcientoCita.HasValue Then
                If Me.PorcientoCita.Value > 0 Then
                    Return PorcientoCita
                End If
            End If

            'Si llega aqui el valor es el global o 0
            If Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then
                If Globales.Configuracion.Cita_Medico_PorcientoGlobal > 0 Then
                    Return Globales.Configuracion.Cita_Medico_PorcientoGlobal
                End If
            Else
                Return 0
            End If

            Return 0

            'Select Case Globales.Usuario.CONFIGURACIONXML.<Medico>.<TipoPorcientoUsar>.Value
            '    Case "1"  'Global
            '        Return Globales.Configuracion.Cita_Medico_PorcientoGlobal
            '    Case "2" ' 
            '        Return PorcientoCita

            '    Case "3"
            '        For Each c As MEDICOS_CONCEPTOFRA In Me.MEDICOS_CONCEPTOFRAs
            '            If c.CODIGO = codigoConcepto Then
            '                Return c.ImportePorciento
            '            End If
            '        Next

            'End Select
        Catch ex As Exception

        End Try

        Return 0
    End Function

End Class