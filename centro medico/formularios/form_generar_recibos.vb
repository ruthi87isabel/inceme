Public Class form_generar_recibos


    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub InicializaRecibos(ByVal aIntervalo As Boolean)
        Dim _dataRecibos As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetRecibosSinGenerar()


        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Titular")
        _source.Columns.Add("RefCita")
        _source.Columns.Add("RefFactura")
        _source.Columns.Add("Concepto")
        _source.Columns.Add("Importe")
        _source.Columns.Add("No. Factura")
        _source.Columns.Add("Entidad")
        _source.Columns.Add("Oficina")
        _source.Columns.Add("DC")
        _source.Columns.Add("Cuenta")
        _source.Columns.Add("Numero")



        Dim i As Integer

        For i = 0 To _dataRecibos.Rows.Count - 1
            Dim _row() As Object = New Object(10) {}
            _row(0) = _dataRecibos.Rows(i).Item("NOMBRE")

            Dim _tempcita As String = _dataRecibos.Rows(i).Item("REFCITA").ToString()
            If _tempcita <> "0" Then
                _row(1) = _tempcita
            Else
                _row(1) = ""
            End If
            Dim _tempfac As String = _dataRecibos.Rows(i).Item("REFFACTURA").ToString()
            If _tempfac <> "0" Then
                _row(2) = _tempfac
            Else
                _row(2) = ""
            End If

            If _row(1) <> "" Then
                _row(5) = ""
            ElseIf _row(2) <> "" Then
                Dim _dataFactura As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaById(Integer.Parse(_row(2).ToString()))
                _row(5) = _dataFactura.Rows(0).Item("NUMERO").ToString()
            Else
                _row(3) = ""
                _row(5) = ""
            End If

            _row(3) = _dataRecibos.Rows(i).Item("CONCEPTO").ToString()
            _row(4) = _dataRecibos.Rows(i).Item("IMPORTE").ToString()


            If _dataRecibos.Rows(i).Item("REFPACIENTE").ToString() <> "" Then
                Dim _IdPaciente As Integer = Integer.Parse(_dataRecibos.Rows(i).Item("REFPACIENTE"))
                Dim _dataPaciente As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_IdPaciente)
                _row(6) = _dataPaciente.Rows(0).Item("ENTIDAD").ToString()
                _row(7) = _dataPaciente.Rows(0).Item("OFICINA").ToString()
                _row(8) = _dataPaciente.Rows(0).Item("DC").ToString()
                _row(9) = _dataPaciente.Rows(0).Item("CUENTA").ToString()
            Else
                _row(6) = ""
                _row(7) = ""
                _row(8) = ""
                _row(9) = ""
            End If

            _row(10) = _dataRecibos.Rows(i).Item("NUMERO").ToString()

            Dim _fechaE As DateTime
            If _dataRecibos.Rows(i).Item("FECHAEMISION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fechaE = _dataRecibos.Rows(i).Item("FECHAEMISION")
            Else
                _fechaE = Date.Now.Date
            End If

            Dim _fechaV As DateTime
            If _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fechaV = _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO")
            Else
                _fechaV = Date.Now.Date
            End If

            If aIntervalo = True Then
                If _fechaE >= dtp_fechainicial.Value And _fechaE <= dtp_fechafinal.Value Then
                    _source.Rows.Add(_row)
                End If
            Else
                _source.Rows.Add(_row)
            End If

        Next


        RECIBOSBindingSource.DataSource = _source
        dtg_recibos.AllowUserToAddRows = False
        dtg_recibos.AllowUserToDeleteRows = False
        dtg_recibos.DataSource = RECIBOSBindingSource

        If dtg_recibos.Rows.Count > 0 Then
            dtg_recibos.Columns("RefCita").Visible = False
            dtg_recibos.Columns("RefFactura").Visible = False
            dtg_recibos.Columns("Numero").Visible = False
        Else
            dtg_recibos.DataSource = New DataTable()
        End If


    End Sub



    Private Sub form_generar_recibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InicializaRecibos(False)
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        'If dtg_recibos.SelectedRows.Count > 0 Then
        '    If dtg_recibos.SelectedRows(0).Cells("RefFactura").Value.ToString() <> "" Then

        '        Dim _factura As form_factura = New form_factura("Factura - Ver", Enums.Accion.Ver, Integer.Parse(dtg_recibos.SelectedRows(0).Cells("RefFactura").Value.ToString()))
        '        _factura.ShowInTaskbar = False
        '        _factura.ShowDialog()

        '    ElseIf dtg_recibos.SelectedRows(0).Cells("RefCita").Value.ToString() <> "" Then
        '        Dim _cita As form_citas = New form_citas("Cita - Ver", Enums.Accion.Ver, Integer.Parse(dtg_recibos.SelectedRows(0).Cells("RefCita").Value.ToString()))
        '        _cita.ShowInTaskbar = False
        '        _cita.ShowDialog()
        '    End If
        'End If
    End Sub

    Private Sub bt_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_generar.Click
        Dim i As Integer
        Dim _mensaje As String = "Se han generado correctamente los recibos: " + Microsoft.VisualBasic.ControlChars.NewLine
        For i = 0 To dtg_recibos.SelectedRows.Count - 1
            Dim _numero As Integer = Integer.Parse(dtg_recibos.SelectedRows(i).Cells("Numero").Value.ToString())
            RECIBOSTableAdapter.UpdateTipo("P", _numero)
            RECIBOSTableAdapter.UpdateFechaEmision(DateTime.Now, _numero)
            _mensaje = _mensaje + "No. " + _numero.ToString() + Microsoft.VisualBasic.ControlChars.NewLine
        Next
        MessageBox.Show(_mensaje, "Recibos generados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InicializaRecibos(False)
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        InicializaRecibos(True)
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub
End Class