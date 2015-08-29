Public Class listado_conocio

    Sub New(ByVal aconfig As Configuracion)
        InitializeComponent()
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


    Private Sub listado_conocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.ComoConocio' Puede moverla o quitarla según sea necesario.
        Me.ComoConocioTableAdapter.Fill(Me.CMDataSet.ComoConocio)
        Me.PACIENTESTableAdapter.Fill(CMDataSet.PACIENTES)

    End Sub

    Private Sub GetConocio(ByVal caso As Integer, Optional ByVal Imprimir As Boolean = False)

        Dim _resc As DataTable = New DataTable()
        _resc.Columns.Add("Codigo")
        _resc.Columns.Add("Nombre")
        _resc.Columns.Add("DNI")
        _resc.Columns.Add("Tutor")
        _resc.Columns.Add("conocio")
        _resc.Columns.Add("Fechaalta")

        Dim fecha As Date
        Dim pac As String
        Dim idpac As Integer
        Dim tutor As String
        Dim strFiltro As String = ""        
        Dim _datac As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable
        Dim min As Date = dtp_fi.Value.Date
        Dim max As Date = dtp_ff.Value.Date
        Dim k As Integer
        Dim _expression As String = "conocio <> ' '"
        Dim _sortOrder As String = ""
        Dim _sortBy As String = "nombre ASC"

        If Me.chb_filtrarconocio.Checked = True Then
            _expression = "conocio like '%" + Me.cb_conocio.Text + "%' AND conocio <> ' '"
        End If


        Dim _rows() As DataRow = CMDataSet.PACIENTES.Select(_expression, _sortBy)

        For k = 0 To _rows.Length - 1
            _datac.ImportRow(_rows(k))
        Next

        Dim i As Integer
        For i = 0 To _datac.Rows.Count - 1
            If _datac.Rows(i).Item("FECHAALTA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then                
                fecha = _datac.Rows(i).Item("FECHAALTA")
            End If
            'fecha = _datac.Rows(i).Item("FECHAALTA")
            idpac = _datac.Rows(i).Item("CPACIENTE")
            Dim _datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(idpac)
            Dim _pacientename As String = _datap.Rows(0).Item("NOMBRE").ToString()
            Dim _pacienteapellido1 As String = _datap.Rows(0).Item("APELLIDO1").ToString()
            Dim _pacienteapellido2 As String = _datap.Rows(0).Item("APELLIDO2").ToString()
            pac = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
            tutor = _datap.Rows(0).Item("TUTOR").ToString()
            Dim _conocio As String = _datap.Rows(0).Item("CONOCIO").ToString()
            Dim _dni As String = _datap.Rows(0).Item("DNI").ToString()

            If Me.chb_filtrarfecha.Checked = True Then
                If fecha >= min And fecha <= max Then
                    _resc.Rows.Add(idpac, pac, _dni, tutor, _conocio, fecha.ToShortDateString)
                End If
            Else
                _resc.Rows.Add(idpac, pac, _dni, tutor, _conocio, fecha.ToShortDateString)
            End If



        Next


        'Imprimir
        If Imprimir = True Then

            Dim dsource As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim param(0) As Microsoft.Reporting.WinForms.ReportParameter

            dsource.Name = "CMDataSet_PACIENTES"
            dsource.Value = _resc
            param(0) = New Microsoft.Reporting.WinForms.ReportParameter("FiltroAplicado", strFiltro)

            UI.Reportes.ReportesManager.Imprime("ComoConocioListado.rdlc", {dsource}, param)

            
        End If

    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        GetConocio(0, True)
    End Sub
End Class