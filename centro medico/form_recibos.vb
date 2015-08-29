Public Class form_recibos_ex

    Dim fId As Integer

    Dim fRecibosRowSelected As Integer = 0
    Dim fMesActual As Boolean

    Dim fCambios As Boolean = False
    Dim fCerrando As Boolean = False

    Dim fRecibosFiltrado As String
    Dim fRecibosOrdenado As String
    Dim fRecibosIntervalo As Boolean

    Dim fRecibosRealCount As Integer

#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()
    End Sub
#End Region


    Private Sub form_recibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.PACIENTES' Puede moverla o quitarla según sea necesario.
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        Me.RECIBOSTableAdapter.FillByPaciente(CMDataSet.RECIBOS, fId)
        nv_recRecibos.Visible = True
        AplicaPermisos()
        fRecibosFiltrado = "T"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
        rb_recNumero.Checked = True
        rb_recTodas.Checked = True
        ActualizarFechaNac()
    End Sub

    Private Sub AplicaPermisos()
        dtg_recRecibos.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) > 2)
        nv_recRecibos.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) > 3)
        BindingNavigatorAddNewItem8.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) > 2)
        BindingNavigatorDeleteItem8.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) > 3)
        BindingNavigatorEditRecibos.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Recibos) > 2)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.dtg_recRecibos.EndEdit()
        RECIBOSBindingSource.EndEdit()
        RECIBOSTableAdapter.Update(CMDataSet.RECIBOS)
        fCerrando = True
        Me.Close()
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
            fCerrando = True
            Me.Close()
        End If
    End Sub

    Private Sub form_recibos_ex_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult
        If fCambios = True And fCerrando = False Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub form_recibos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                BindingNavigatorAddNewItem8_Click(sender, e)
            Case Globales.TeclasBasicas.Borrar
                BindingNavigatorDeleteItem8_Click(sender, e)
            Case Globales.TeclasBasicas.Editar
                BindingNavigatorEditRecibos_Click(sender, e)
            Case Globales.TeclasBasicas.Filtrar
                Me.bt_recFiltrar_Click(sender, e)
        End Select
    End Sub

    Private Sub ActualizarFechaNac()
        Try
            Dim _fechaNac As Date = CMDataSet.PACIENTES.FindByCPACIENTE(fId).FECHAN
            Dim _anno As Integer = _fechaNac.Year
            If _fechaNac.Month > DateTime.Now.Month Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno - 1).ToString()
            ElseIf _fechaNac.Month < DateTime.Now.Month Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno).ToString()
            ElseIf _fechaNac.Day >= DateTime.Now.Day Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno).ToString()
            Else
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno - 1).ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub InicializaRecibos(ByVal aFiltrar As String, ByVal aOrdenar As String, ByVal aIntervalo As Boolean)
        Dim _dataRecibos As CMDataSet.RECIBOSDataTable = New CMDataSet.RECIBOSDataTable()

        Dim k As Integer

        Dim _expression As String = "REFPACIENTE = " + fId.ToString()
        Dim _sortOrder As String = "NUMERO ASC"

        If aFiltrar = "T" Then
            If aOrdenar = "N" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacienteOrderNumero(fId)
                _expression = "REFPACIENTE = " + fId.ToString()
                _sortOrder = "NUMERO ASC"
            ElseIf aOrdenar = "E" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacienteOrderFechaEmision(fId)
                _expression = "REFPACIENTE = " + fId.ToString()
                _sortOrder = "FECHAEMISION ASC"
            ElseIf aOrdenar = "V" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacienteOrderFechaVencimiento(fId)
                _expression = "REFPACIENTE = " + fId.ToString()
                _sortOrder = "FECHAVENCIMIENTO ASC"
            ElseIf aOrdenar = "I" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacienteOrderImporte(fId)
                _expression = "REFPACIENTE = " + fId.ToString()
                _sortOrder = "IMPORTE ASC"
            Else
                '_dataRecibos = RECIBOSTableAdapter.GetDataBypaciente(fId)
                _expression = "REFPACIENTE = " + fId.ToString()
                _sortOrder = ""
            End If
        ElseIf aFiltrar = "P" Then
            If aOrdenar = "N" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderNumero(fId, "S")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'S'"
                _sortOrder = "NUMERO ASC"
            ElseIf aOrdenar = "E" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderFechaEmision(fId, "S")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'S'"
                _sortOrder = "FECHAEMISION ASC"
            ElseIf aOrdenar = "V" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderFechaVencimiento(fId, "S")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'S'"
                _sortOrder = "FECHAVENCIMIENTO ASC"
            ElseIf aOrdenar = "I" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderImporte(fId, "S")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'S'"
                _sortOrder = "IMPORTE ASC"
            Else
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagado(fId, "S")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'S'"
                _sortOrder = ""
            End If
        Else
            If aOrdenar = "N" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderNumero(fId, "N")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'N'"
                _sortOrder = "NUMERO ASC"
            ElseIf aOrdenar = "E" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderFechaEmision(fId, "N")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'N'"
                _sortOrder = "FECHAEMISION ASC"
            ElseIf aOrdenar = "V" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderFechaVencimiento(fId, "N")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'N'"
                _sortOrder = "FECHAVENCIMIENTO ASC"
            ElseIf aOrdenar = "I" Then
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagadoOrderImporte(fId, "N")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'N'"
                _sortOrder = "IMPORTE ASC"
            Else
                '_dataRecibos = RECIBOSTableAdapter.GetDataByPacPagado(fId, "N")
                _expression = "REFPACIENTE = " + fId.ToString() + "AND COBRADO = 'N'"
                _sortOrder = ""
            End If
        End If


        If aOrdenar = "C" Then
            _sortOrder = "COBRADO ASC"
        End If

        Dim _rows() As DataRow = CMDataSet.RECIBOS.Select(_expression, _sortOrder)

        For k = 0 To _rows.Length - 1
            _dataRecibos.ImportRow(_rows(k))
        Next

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Número")
        _source.Columns.Add("F.Emisión")
        _source.Columns.Add("F.Vencimiento")
        _source.Columns.Add("Importe")
        _source.Columns.Add("Cobrado")
        _source.Columns.Add("F.Cobro")


        Dim i As Integer

        For i = 0 To _dataRecibos.Rows.Count - 1

            If _dataRecibos.Rows(i).Item("TIPO").ToString() <> "G" Then

                Dim _rowAded As Boolean = False

                Dim _row() As Object = New Object(5) {}
                _row(0) = _dataRecibos.Rows(i).Item("NUMERO")
                Dim _fechaE As DateTime = Nothing
                If _dataRecibos.Rows(i).Item("FECHAEMISION").ToString() <> DBNull.Value.ToString Then
                    _fechaE = _dataRecibos.Rows(i).Item("FECHAEMISION")
                    _row(1) = _fechaE.ToShortDateString()
                End If
                Dim _fechaV As DateTime = Nothing
                If _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO").ToString() <> DBNull.Value.ToString Then
                    _fechaV = _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO")
                    _row(2) = _fechaV.ToShortDateString()
                End If
                _row(3) = _dataRecibos.Rows(i).Item("IMPORTE")
                _row(4) = _dataRecibos.Rows(i).Item("COBRADO").ToString()
                If _row(4).ToString() = "S" And _dataRecibos.Rows(i).Item("FECHACOBRO").ToString <> DBNull.Value.ToString Then
                    Dim _fechaC As DateTime = _dataRecibos.Rows(i).Item("FECHACOBRO")
                    _row(5) = _fechaC.ToShortDateString()
                End If

                If aIntervalo = True Then
                    If _fechaE <> Nothing Then
                        If _fechaE >= dtp_recDesde.Value And _fechaE <= dtp_recHasta.Value Then
                            _source.Rows.Add(_row)
                            _rowAded = True
                        End If
                    End If

                Else
                    _source.Rows.Add(_row)
                    _rowAded = True
                End If

                If fMesActual = True Then
                    If _fechaE = Nothing Then
                        _source.Rows.RemoveAt(_source.Rows.Count - 1)
                    Else
                        If _fechaE.Month <> DateTime.Now.Month And _rowAded = True Then
                            _source.Rows.RemoveAt(_source.Rows.Count - 1)
                        End If
                    End If

                End If
            End If

        Next

        fRecibosRealCount = _source.Rows.Count
        RECIBOSBindingSource.DataSource = _source
        dtg_recRecibos.DataSource = RECIBOSBindingSource
        nv_recRecibos.BindingSource = RECIBOSBindingSource

        fRecibosRowSelected = 0

        If _source.Rows.Count > 0 Then
            dtg_recRecibos.AllowUserToAddRows = False
            dtg_recRecibos.AllowUserToDeleteRows = False
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem8.Click
        Dim _cantidadInicial As Integer = dtg_recRecibos.Rows.Count
        Dim _recibo As form_recibos = New form_recibos("Recibo", Enums.Accion.Insertar, -1, fId, CMDataSet)
        fCambios = True
        _recibo.ShowInTaskbar = False
        _recibo.ShowDialog()
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
        If dtg_recRecibos.Rows.Count > 0 And dtg_recRecibos.Rows.Count <> _cantidadInicial Then
            fRecibosRowSelected = dtg_recRecibos.Rows.Count - 1
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem8.Click
        If dtg_recRecibos.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_recRecibos.SelectedRows(0).Index

            Dim _Id As Integer = Integer.Parse(dtg_recRecibos.SelectedRows(0).Cells("Número").Value.ToString())
            'RECIBOSTableAdapter.DeleteByNumero(_Id)
            'CMDataSet.RECIBOS.RemoveRECIBOSRow(CMDataSet.RECIBOS.FindByNUMERO(_Id))
            Dim _row As CMDataSet.RECIBOSRow = CMDataSet.RECIBOS.FindByNUMERO(_Id)
            _row.Delete()
            fCambios = True
            fRecibosRealCount = fRecibosRealCount - 1

            If dtg_recRecibos.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                fRecibosRowSelected = _index
            End If
        End If
    End Sub
    '//YA = DATA SET
    Private Sub BindingNavigatorEditRecibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditRecibos.Click
        If dtg_recRecibos.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_recRecibos.SelectedRows(0).Index

            Dim _aId As Integer = Integer.Parse(dtg_recRecibos.SelectedRows.Item(0).Cells("Número").Value)
            Dim _recibo As form_recibos = New form_recibos("Recibo", Enums.Accion.Modificar, _aId, fId, CMDataSet)
            _recibo.ShowInTaskbar = False
            _recibo.ShowDialog()
            fRecibosFiltrado = "T"
            InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)

            fRecibosRowSelected = _index
            fCambios = True
        End If
    End Sub

    Private Sub rb_recTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recTodas.CheckedChanged
        fRecibosFiltrado = "T"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recPagados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recPagados.CheckedChanged
        fRecibosFiltrado = "P"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recImpagados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recImpagados.CheckedChanged
        fRecibosFiltrado = "I"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recNumero.CheckedChanged
        fRecibosOrdenado = "N"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recFEmision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recFEmision.CheckedChanged
        fRecibosOrdenado = "E"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recFVencimiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recFVencimiento.CheckedChanged
        fRecibosOrdenado = "V"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recImporte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recImporte.CheckedChanged
        fRecibosOrdenado = "I"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub rb_recCobrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recCobrado.CheckedChanged
        fRecibosOrdenado = "C"
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub
    '//YA
    Private Sub dtg_recRecibos_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_recRecibos.Paint
        If dtg_recRecibos.Rows.Count > fRecibosRealCount Then
            dtg_recRecibos.Rows.RemoveAt(dtg_recRecibos.Rows.Count - 1)
        End If
        If dtg_recRecibos.Rows.Count > 0 Then
            dtg_recRecibos.Rows(fRecibosRowSelected).Selected = True
        End If
    End Sub

    'Private Sub dtg_recRecibos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_revComparativas.SelectionChanged, dtg_recRecibos.SelectionChanged
    '    If dtg_recRecibos.SelectedRows.Count > 0 And dtg_recRecibos.Rows.Count = fRecibosRealCount Then
    '        fRecibosRowSelected = dtg_recRecibos.SelectedRows(0).Index
    '    End If
    'End Sub

    Private Sub dtg_recRecibos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_recRecibos.SelectionChanged
        If dtg_recRecibos.SelectedRows.Count > 0 And dtg_recRecibos.Rows.Count = fRecibosRealCount Then
            fRecibosRowSelected = dtg_recRecibos.SelectedRows(0).Index
        End If
    End Sub

    Private Sub bt_recFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_recFiltrar.Click
        fRecibosIntervalo = True
        InicializaRecibos(fRecibosFiltrado, fRecibosOrdenado, fRecibosIntervalo)
    End Sub

    Private Sub dtg_recRecibos_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_recRecibos.CellMouseDoubleClick
        BindingNavigatorEditRecibos_Click(sender, e)
    End Sub
End Class