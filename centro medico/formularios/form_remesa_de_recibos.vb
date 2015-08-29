Imports centro_medico.UI.Reportes

Public Class form_remesa_de_recibos
    Dim _source As DataTable
    Dim dView As DataView

    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub form_remesa_de_recibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtp_fechainicial.Value = Now.Date.AddYears(-1)
        InicializaRecibos(False)
    End Sub

    Private Sub InicializaRecibos(ByVal aIntervalo As Boolean)
        Dim _dataRecibos As CMDataSet.RECIBOSDataTable


        If aIntervalo = True Then
            _dataRecibos = RECIBOSTableAdapter.GetReciboByFecha(Me.dtp_fechainicial.Value.Date, Me.dtp_fechafinal.Value.Date.AddDays(1).AddMinutes(-1))
        Else
            _dataRecibos = RECIBOSTableAdapter.GetData
        End If


        dView = _dataRecibos.DefaultView

        If Me.chb_listaremitidos.Checked = True Then
            dView.RowFilter = "EMITIDO = 'S' OR EMITIDO = 'N'"
        Else
            dView.RowFilter = "EMITIDO = 'N'"
        End If

        '_source = New DataTable("Tabla")
        '_source.Columns.Add("Numero")
        '_source.Columns.Add("Nombre")
        '_source.Columns.Add("FechaEmision")
        '_source.Columns.Add("FechaVencimiento")
        '_source.Columns.Add("REFCITA")
        '_source.Columns.Add("REFFACTURA")
        '_source.Columns.Add("DIRECCION")
        '_source.Columns.Add("IMPORTE")
        '_source.Columns.Add("CONCEPTO")
        '_source.Columns.Add("NOTAS")
        '_source.Columns.Add("ENTIDAD")
        '_source.Columns.Add("OFICINA")
        '_source.Columns.Add("DC")
        '_source.Columns.Add("CUENTA")
        '_source.Columns.Add("EMITIDO")


        'Dim i As Integer

        'For i = 0 To _dataRecibos.Rows.Count - 1
        '    Dim _row() As Object = New Object(13) {}
        '    _row(0) = _dataRecibos.Rows(i).Item("NUMERO")
        '    _row(1) = _dataRecibos.Rows(i).Item("NOMBRE").ToString()


        '    Dim _fechaE As DateTime = Nothing
        '    If _dataRecibos.Rows(i).Item("FECHAEMISION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
        '        _fechaE = _dataRecibos.Rows(i).Item("FECHAEMISION")
        '        _row(2) = _fechaE.ToShortDateString()
        '    End If

        '    If _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
        '        Dim _fechaV As DateTime = _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO")
        '        _row(3) = _fechaV.ToShortDateString()
        '    End If


        '    Dim _tempcita As String = _dataRecibos.Rows(i).Item("REFCITA").ToString()
        '    If _tempcita <> "0" Then
        '        _row(4) = _tempcita
        '    Else
        '        _row(4) = ""
        '    End If
        '    Dim _tempfac As String = _dataRecibos.Rows(i).Item("REFFACTURA").ToString()
        '    If _tempfac <> "0" Then
        '        _row(5) = _tempfac
        '    Else
        '        _row(5) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("DIRECCION").GetType Is GetType(DBNull) Then
        '        _row(6) = _dataRecibos.Rows(i).Item("DIRECCION")
        '    Else
        '        _row(6) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("IMPORTE").GetType Is GetType(DBNull) Then
        '        _row(7) = _dataRecibos.Rows(i).Item("IMPORTE")
        '    Else
        '        _row(7) = 0
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("CONCEPTO").GetType Is GetType(DBNull) Then
        '        _row(8) = _dataRecibos.Rows(i).Item("CONCEPTO")
        '    Else
        '        _row(8) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("NOTAS").GetType Is GetType(DBNull) Then
        '        _row(9) = _dataRecibos.Rows(i).Item("NOTAS")
        '    Else
        '        _row(9) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("ENTIDAD").GetType Is GetType(DBNull) Then
        '        _row(10) = _dataRecibos.Rows(i).Item("ENTIDAD")
        '    Else
        '        _row(10) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("OFICINA").GetType Is GetType(DBNull) Then
        '        _row(11) = _dataRecibos.Rows(i).Item("OFICINA")
        '    Else
        '        _row(11) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("DC").GetType Is GetType(DBNull) Then
        '        _row(12) = _dataRecibos.Rows(i).Item("DC")
        '    Else
        '        _row(12) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("CUENTA").GetType Is GetType(DBNull) Then
        '        _row(13) = _dataRecibos.Rows(i).Item("CUENTA")
        '    Else
        '        _row(13) = ""
        '    End If
        '    If Not _dataRecibos.Rows(i).Item("EMITIDO").GetType Is GetType(DBNull) Then
        '        _row(13) = _dataRecibos.Rows(i).Item("EMITIDO")
        '    Else
        '        _row(13) = "N"
        '    End If

        '    If aIntervalo = True Then
        '        If _fechaE <> Nothing Then
        '            If _fechaE >= dtp_fechainicial.Value And _fechaE <= dtp_fechafinal.Value Then
        '                If chb_listaremitidos.Checked = True Then
        '                    _source.Rows.Add(_row)
        '                Else
        '                    Dim _tempemi As String = _dataRecibos.Rows(i).Item("EMITIDO").ToString()
        '                    If _tempemi = "N" Then
        '                        _source.Rows.Add(_row)
        '                    End If

        '                End If
        '            End If
        '        End If

        '    Else
        '        Dim _tempemi As String = _dataRecibos.Rows(i).Item("EMITIDO").ToString()
        '        If _tempemi = "N" Then
        '            _source.Rows.Add(_row)
        '        End If
        '    End If

        'Next


        RECIBOSBindingSource.DataSource = dView
        dtg_recibos.AllowUserToAddRows = False
        dtg_recibos.AllowUserToDeleteRows = False

        Me.tsl_FilasFiltradas.Text = "Mostrando " & dView.Count & " registros."

        'dtg_recibos.DataSource = RECIBOSBindingSource

        'CAMBIO EL HEADERTEXT DE ALGUNAS COLUMNAS 
        'dtg_recibos.Columns("REFCITA").HeaderText = "CITA"
        'dtg_recibos.Columns("REFFACTURA").HeaderText = "FACTURA"
        'dtg_recibos.Columns("FechaEmision").HeaderText = "F.de Emisión"
        'dtg_recibos.Columns("FechaVencimiento").HeaderText = "F.de Vto"


        'OCULTAR COLUMNAS DE LA GRID
        'dtg_recibos.Columns("DIRECCION").Visible = False
        'dtg_recibos.Columns("NOTAS").Visible = False
        'dtg_recibos.Columns("ENTIDAD").Visible = False
        'dtg_recibos.Columns("OFICINA").Visible = False
        'dtg_recibos.Columns("DC").Visible = False
        'dtg_recibos.Columns("CUENTA").Visible = False
        'dtg_recibos.Columns("EMITIDO").Visible = False

        'LOS RECIBOS EMITIDOS SE COLOREAN EN AZUL
        Dim i As Integer = 0
        For i = 0 To dtg_recibos.Rows.Count - 1
            If dtg_recibos.Rows(i).Cells("EMITIDO").Value.ToString = "S" Then
                dtg_recibos.Rows(i).DefaultCellStyle.BackColor = Color.Aqua
            End If
        Next
        dtg_recibos.Sort(Me.FECHAEMISION, System.ComponentModel.ListSortDirection.Ascending)
        dtg_recibos.Refresh()

    End Sub


    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        InicializaRecibos(True)
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        Dim cReciboSeleccionado As Integer = -1
        Dim frmRecibo As form_recibos
        If dtg_recibos.SelectedRows.Count > 0 Then
            cReciboSeleccionado = CInt(dtg_recibos.SelectedRows(0).Cells("NUMERO").Value.ToString)
            frmRecibo = New form_recibos("Recibo", Enums.Accion.Modificar, cReciboSeleccionado)
            frmRecibo.ShowInTaskbar = False
            frmRecibo.ShowDialog()

            'Recargamos la información para mostar los cambios
            Me.InicializaRecibos(True)
            'If dtg_recibos.SelectedRows(0).Cells("REFFACTURA").Value.ToString() = "" Then
            '    Dim _factura As form_factura = New form_factura("Factura - Ver")
            '    _factura.ShowInTaskbar = False
            '    _factura.ShowDialog()
            'Else
            '    Dim _factura As form_factura = New form_factura("Factura - Ver", Enums.Accion.Ver, Integer.Parse(dtg_recibos.SelectedRows(0).Cells("Factura").Value.ToString()))
            '    _factura.ShowInTaskbar = False
            '    _factura.ShowDialog()
            'End If
        End If
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub bt_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_generar.Click
        Dim i As Integer


        Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim dtRecibos As New CMDataSet.RECIBOSDataTable
        Dim res As MsgBoxResult
        Dim filtro As String = ""
        res = MessageBox.Show("¿Desea marcar los recibos seleccionados de la remesa como emitidos?", "Emisión de recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.OK Then

            For i = 0 To dtg_recibos.SelectedRows.Count - 1
                RECIBOSTableAdapter.UpdateEmitido("S", dtg_recibos.SelectedRows(i).Cells("Numero").Value)
                dtg_recibos.SelectedRows(i).DefaultCellStyle.BackColor = Color.Aqua
                If filtro.Trim.Length > 0 Then filtro += " Or "
                filtro += " Numero = " & dtg_recibos.SelectedRows(i).Cells("Numero").Value.ToString
            Next
            If filtro.Trim.Length > 0 Then
                dView.RowFilter = filtro
            End If
            'imprimir
            rpt.Name = "CMDataSet_RECIBOS"
            rpt.Value = dView


            parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("NombreEmisor", Globales.Configuracion.nombrecomercial)


            ReportesManager.Imprime("Recibo.rdlc", {rpt}, parametros)

           
        End If





    End Sub

    Private Sub dtg_recibos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_recibos.CellDoubleClick
        bt_mostrar_Click(Nothing, Nothing)
    End Sub

    Private Sub dtg_recibos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_recibos.SelectionChanged
        Me.tsl_FilasSeleccionadas.Text = Me.dtg_recibos.SelectedRows.Count
    End Sub
End Class