Public Class listado_faltas

    Dim context As New CMLinqDataContext()
    Dim min As Date
    Dim max As Date
    Dim filtro As String




    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal lectura As Boolean)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim i As Integer
        For i = 0 To Me.Controls.Count - 1
            Me.Controls(i).Enabled = False
        Next
        bt_cerrar.Enabled = True

    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    'Private Function GetPaciente(ByVal aId As Integer) As String

    '    Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
    '    Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
    '    Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
    '    Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
    '    Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
    '    Return _paciente

    'End Function
    'Private Sub bt_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
    '    Dim _name As String = "Listado de pacientes"
    '    Dim _listados As form_listados = New form_listados(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes, True)
    '    _listados.ShowInTaskbar = False
    '    _listados.ShowDialog()
    '    If _listados.Selected <> "" Then
    '        CtrlPaciente1.ID_PACIENTE = Integer.Parse(_listados.Selected())
    '    End If
    'End Sub


    Private Sub listado_faltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bt_filtrar_Click(Nothing, Nothing)

        'Dim citas = (From c In context.CITAs Where c.FALTA = "S" Order By c.FECHA _
        '            Select New With {c.IDCITA, c.FECHA, c.HORA, c.REFPACIENTE, c.PACIENTE, c.PACIENTE1.TUTOR, c.PACIENTE1.TLFNO, c.NOTAS})


        ''min = (From d In citas

        'dgv_faltas.DataSource = citas

            'Me.CITASTableAdapter.Fill(CMDataSet.CITAS)
            'GetFalta(1)
            'If dgv_faltas.Rows.Count() > 0 Then
            '    bt_imprimir.Enabled = True
        'End If

        dgv_faltas.AutoGenerateColumns = False
    End Sub
    'Private Sub GetFalta(ByVal caso As Integer, Optional ByVal Imprimir As Boolean = False)

    '    Dim _resc As DataTable = New DataTable()
    '    _resc.Columns.Add("Fecha")
    '    _resc.Columns.Add("Hora")
    '    _resc.Columns.Add("Codigo")
    '    _resc.Columns.Add("Paciente")
    '    _resc.Columns.Add("Tutor")
    '    _resc.Columns.Add("Tlfno")
    '    _resc.Columns.Add("Notas")

    '    Dim fecha As Date
    '    Dim pac As String
    '    Dim idpac As Integer
    '    Dim hora As Date
    '    Dim tutor As String
    '    Dim tlfno As String
    '    Dim notas As String
    '    Dim strFiltro As String = ""
    '    Dim _datac As CMDataSet.CITASDataTable
    '    Dim min As Date = dtp_fi.Value.Date
    '    Dim max As Date = dtp_ff.Value.Date
    '    If caso = 0 Then

    '        If CtrlPaciente1.ID_PACIENTE.HasValue Then
    '            Dim paciente As Integer = CtrlPaciente1.ID_PACIENTE
    '            _datac = Me.CITASTableAdapter.GetCitaFaltaByFechaPac(min, max, paciente, "S")
    '            strFiltro = "F. inicial: " & min.Date & ", F. final: " & max.Date & ", Paciente: " & CtrlPaciente1.NombreCompleto
    '        End If
    '    ElseIf caso = 1 Then
    '        _datac = Me.CITASTableAdapter.GetCitaFaltaByFecha(min, max, "S")
    '        strFiltro = "F. inicial: " & min.Date & ", F. final: " & max.Date
    '    End If

    '    Dim i As Integer
    '    For i = 0 To _datac.Rows.Count - 1
    '        fecha = _datac.Rows(i).Item("FECHA")
    '        hora = _datac.Rows(i).Item("HORA")
    '        idpac = _datac.Rows(i).Item("REFPACIENTE")
    '        notas = _datac.Rows(i).Item("NOTAS")

    '        Dim _datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(idpac)
    '        If _datap.Count > 0 Then
    '            Dim _pacientename As String = _datap.Rows(0).Item("NOMBRE").ToString()
    '            Dim _pacienteapellido1 As String = _datap.Rows(0).Item("APELLIDO1").ToString()
    '            Dim _pacienteapellido2 As String = _datap.Rows(0).Item("APELLIDO2").ToString()
    '            pac = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
    '            tutor = _datap.Rows(0).Item("TUTOR").ToString()
    '            tlfno = _datap.Rows(0).Item("TLFNO").ToString()

    '            'Dim hora_inicio As String
    '            'If hora.Minute >= 10 Then
    '            '    hora_inicio = hora.Hour.ToString() + ":" + hora.Minute.ToString()
    '            'Else : hora_inicio = hora.Hour.ToString() + ":0" + hora.Minute.ToString()
    '            'End If
    '            'Dim fecha_tabla = fecha.Year.ToString() + "/" + fecha.Month.ToString() + "/" + fecha.Day.ToString()
    '            _resc.Rows.Add(fecha.ToShortDateString, hora.ToShortTimeString, idpac, pac, tutor, tlfno, notas)
    '        End If
    '    Next
    '    dgv_faltas.DataSource = _resc
    '    'Imprimir
    '    If Imprimir = True Then
    '        Dim rep As form_ReporteGenerico
    '        Dim dsource As New Microsoft.Reporting.WinForms.ReportDataSource
    '        Dim param(0) As Microsoft.Reporting.WinForms.ReportParameter

    '        dsource.Name = "CMDataSet_CITAS"
    '        dsource.Value = _resc
    '        param(0) = New Microsoft.Reporting.WinForms.ReportParameter("FiltroAplicado", strFiltro)

    '        rep = New form_ReporteGenerico(dsource, Globals.Configuracion.impresionfilesdirectory & "\listadoFaltas.rdlc", "Informe de Faltas.")
    '        rep.ReportViewer.LocalReport.SetParameters(param)
    '        rep.ShowInTaskbar = False
    '        rep.WindowState = FormWindowState.Maximized
    '        rep.ShowDialog()
    '    End If

    'End Sub
    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Dim citas


        If CtrlPaciente1.ID_PACIENTE.HasValue = True Then
            citas = (From c In context.CITAs Where c.FALTA = "S" And c.REFPACIENTE = CtrlPaciente1.ID_PACIENTE And _
                    c.FECHA >= dtp_fi.Value And c.FECHA <= dtp_ff.Value And c.Eliminado = False Order By c.FECHA Descending _
                    Select New With {c.IDCITA, c.FECHA, c.HORA, c.REFPACIENTE, c.PACIENTE, c.PACIENTE1.TUTOR, c.PACIENTE1.TLFNO, c.NOTAS}).ToList()
        Else
            citas = (From c In context.CITAs Where c.FALTA = "S" And _
                    c.FECHA >= dtp_fi.Value And c.FECHA <= dtp_ff.Value And c.Eliminado = False Order By c.FECHA Descending _
                    Select New With {c.IDCITA, c.FECHA, c.HORA, c.REFPACIENTE, c.PACIENTE, c.PACIENTE1.TUTOR, c.PACIENTE1.TLFNO, c.NOTAS}).ToList()
        End If

        If citas.Count > 0 Then
            max = citas(0).FECHA
            min = citas(citas.Count - 1).FECHA
        End If

        'max = citas(0).FECHA

        dgv_faltas.DataSource = citas
        bt_imprimir.Enabled = True

    End Sub

    Public Function FiltraParaImprimir() As Object

        Dim res
        If CtrlPaciente1.ID_PACIENTE.HasValue = True Then
            res = (From c In context.CITAs Where c.FALTA = "S" And c.REFPACIENTE = CtrlPaciente1.ID_PACIENTE And _
                    c.FECHA >= dtp_fi.Value And c.FECHA <= dtp_ff.Value And c.Eliminado = False Order By c.FECHA Descending _
                    Select New WRAPPER_CITA(c)).ToList()
            'Select New With {c.IDCITA, c.FECHA, c.HORA, c.REFPACIENTE, c.PACIENTE, c.PACIENTE1.TUTOR, c.PACIENTE1.TLFNO, c.NOTAS}).ToList()
        Else
            res = (From c In context.CITAs Where c.FALTA = "S" And _
                    c.FECHA >= dtp_fi.Value And c.FECHA <= dtp_ff.Value And c.Eliminado = False Order By c.FECHA Descending _
                     Select New WRAPPER_CITA(c)).ToList()
            'Select New With {c.IDCITA, c.FECHA, c.HORA, c.REFPACIENTE, c.PACIENTE, c.PACIENTE1.TUTOR, c.PACIENTE1.TLFNO, c.NOTAS}).ToList()

        End If

        'If citas.Count > 0 Then
        '    max = citas(0).FECHA
        '    min = citas(citas.Count - 1).FECHA
        'End If

        'max = citas(0).FECHA
        'dgv_faltas.DataSource = citas
        bt_imprimir.Enabled = True
        Return res
    End Function




    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        bt_filtrar_Click(Nothing, Nothing)

        'Dim min As Date = Date.Now  '= CType(dgv_faltas.DataSource, IQueryable)
        'Dim max As Date = Date.Now  '(From c In CType(dgv_faltas.DataSource, IQueryable(Of CITA)) Select c.FECHA).Max()

        Dim paciente As String = ""
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            paciente = CtrlPaciente1.NombreCompleto
        End If

        Dim strFiltro As String = "F. inicial: " & min.Date & ", F. final: " & max.Date & ", Paciente: " & paciente

        Dim dsource As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim param(0) As Microsoft.Reporting.WinForms.ReportParameter

        dsource.Name = "CMDataSet_CITAS"
        dsource.Value = FiltraParaImprimir() 'dgv_faltas.DataSource




        param(0) = New Microsoft.Reporting.WinForms.ReportParameter("FiltroAplicado", strFiltro)

        UI.Reportes.ReportesManager.Imprime("FaltasListado.rdlc", {dsource}, param)

    End Sub
End Class