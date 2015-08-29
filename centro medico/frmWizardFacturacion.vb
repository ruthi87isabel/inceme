Imports System.Threading.Thread
Public Class frmWizardFacturacionCitas
    Dim hilo As Threading.Thread

    Private Sub frmWizardFacturacionCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.LMUTUAS' table. You can move, or remove it, as needed.
        'Me.LMUTUASTableAdapter.Fill(Me.CMDataSet.LMUTUAS)
        'Me.LineasCitasTableAdapter.Fill(Me.CMDataSet.LineasCitas)
        'Me.FACTURASTableAdapter.Fill(Me.CMDataSet.FACTURAS)
        'Me.LINEASFACTURASTableAdapter.Fill(Me.CMDataSet.LINEASFACTURAS)
        'Me.CITASTableAdapter.Fill(Me.CMDataSet.CITAS)
        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)
        Me.SERIESTableAdapter.Fill(Me.CMDataSet.SERIES)
        CheckForIllegalCrossThreadCalls = False
        'Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        If Me.TabControl1.SelectedIndex = 1 Then
            If Me.rb_Mutuas.Checked = True Then
                If Me.cmbMutuas.SelectedValue Is Nothing Then
                    MsgBox("Debe seleccionar una muta.")
                    Exit Sub
                End If
            End If
        End If
        Me.TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1

    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        If Me.TabControl1.SelectedIndex > 0 Then
            Me.TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
        End If
    End Sub

    Private Sub CrearFactura()

        Dim _Id As Integer
        Dim _Ids As Integer
        Dim _noms As String
        Dim SumImporte As Double = 0
        Dim NomPaciente As String = ""
        Dim NumeroFactura As String = ""
        If FACTURASTableAdapter.GetData().Rows.Count > 0 Then
            If FACTURASTableAdapter.MaximoId.HasValue Then
                Dim _Idt As Integer = FACTURASTableAdapter.MaximoId().Value
                _Id = _Idt + 1
            Else
                _Id = 1
            End If
        Else
            _Id = 1
        End If

        Dim _newRow As CMDataSet.FACTURASRow = CMDataSet.FACTURAS.NewFACTURASRow()
        _newRow.IDFACTURA() = _Id
        _newRow.NUMEROFACTURA() = _Id
        _newRow.REFSERIE() = Me.cb_serie.Text
        _newRow.NUMERO = Number(Me.cb_serie.Text)
        NumeroFactura = _newRow.NUMERO

        If dg_PacientesMutuas.SelectedRows.Count > 0 Then
            _Ids = Integer.Parse(dg_PacientesMutuas.SelectedRows(0).Cells("cpaciente").Value.ToString())
            If rb_pacientes.Checked = True Then

                _newRow.REFPACIENTE() = _Ids
                _newRow.MUTUA() = "0"
            Else
                '  Dim _Ids As Integer = Integer.Parse(dg_PacientesMutuas.SelectedRows(0).Cells("cmutua").Value.ToString())
                _noms = dg_PacientesMutuas.SelectedRows(0).Cells("nombre").Value.ToString()
                _newRow.MUTUA() = _noms
                _newRow.REFPACIENTE() = _Ids
                '_newRow.REFPACIENTE() = ""
            End If
        End If

        _newRow.FECHA() = Now.Date
        _newRow.HORA() = Now
        _newRow.FACCIDENTE() = Now.Date
        _newRow.FBAJA() = Now.Date
        _newRow.FALTA() = Now.Date
        _newRow.FEMISION() = Now.Date

        _newRow.IRPF() = 0

        _newRow.PAGADA() = "N"

        _newRow.RECIBO() = "N"
        'datos del paciente
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).IsDOMICILIONull Then _newRow.DIRECCION() = CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).DOMICILIO
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).IsLOCALIDADNull Then _newRow.LOCALIDAD() = CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).LOCALIDAD
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).IsPROVINCIANull Then _newRow.PROVINCIA() = CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).PROVINCIA
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).APELLIDO1.GetType Is GetType(DBNull) Then
            NomPaciente += " " & CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).APELLIDO1
        End If
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).APELLIDO2.GetType Is GetType(DBNull) Then
            NomPaciente += " " & CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).APELLIDO2
        End If
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).NOMBRE.GetType Is GetType(DBNull) Then
            If NomPaciente.Length > 0 Then
                NomPaciente += ", " & CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).NOMBRE
            Else
                NomPaciente += " " & CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).NOMBRE
            End If
        End If
        _newRow.PACIENTE() = NomPaciente
        _newRow.PORCENTAJEIRPF() = 0
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).IsDNINull Then _newRow.DNI() = CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).DNI
        _newRow.TIPOIVA() = 0
        If Not CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).IsCPNull Then _newRow.CP() = CMDataSet.PACIENTES.FindByCPACIENTE(_Ids).CP
        If Me.rb_Mutuas.Checked = True Then
            _newRow.FACTURAR = "M"
        Else
            _newRow.FACTURAR = "P"
        End If
        If Me.rb_Mutuas.Checked Then
            _newRow.REFMUTUA = Me.cmbMutuas.SelectedValue
            _newRow.MUTUA = Me.cmbMutuas.Text
        End If
        _newRow.EMPRESA = ""
        CMDataSet.FACTURAS.AddFACTURASRow(_newRow)
        FACTURASTableAdapter.Update(CMDataSet.FACTURAS)

        '------------------------------------------------------------
        'Añadimos las lineas a la factura de las citas seleccionadas
        '------------------------------------------------------------

        'verificamos que se haya seleccionado algo de la tabla
        Dim dtgItem As DataGridViewRow
        Dim cont As Boolean = False
        Dim _idcita As Integer
        Dim _citacantidad As Double
        Dim _citapreciouni As Double

        For Each dtgItem In dg_Citas.Rows
            'recorremos la lista de citas seleccionadas
            If (dtgItem.Cells("seleccion").Value = True) Then
                _idcita = dtgItem.Cells("idcita").Value

                'Dim _data As CMDataSet.CITASDataTable
                '_data = Me.CITASTableAdapter.GetCitaById(_idcita)
                '_data.Rows(0).Item("REFFRA") = _Id
                'Me.CITASTableAdapter.Update(CMDataSet.CITAS)

                'cambiamos la vinculación de la cita con la factura nueva
                '--------
                Dim _updRow As CMDataSet.CITASRow = Me.CITASTableAdapter.GetCitaById(_idcita).Rows(0)
                _updRow.REFFRA() = _Id
                SumImporte += _updRow.IMPORTECL + _updRow.IMPORTEDR
                Me.CITASTableAdapter.Update(CMDataSet.CITAS)
                '-----------

                'ahora recorremos las lineas de las cita para sacar el importe y cantidad
                '-----------
                Dim _datalcita As CMDataSet.LineasCitasDataTable = New CMDataSet.LineasCitasDataTable
                Dim _expression As String = "idcita = " & _idcita
                Dim _sortOrder As String = "idcita ASC"
                Dim _rows() As DataRow = CMDataSet.LineasCitas.Select(_expression, _sortOrder)

                Dim k As Integer
                For k = 0 To _rows.Length - 1
                    _datalcita.ImportRow(_rows(k))
                Next

                Dim i As Integer

                Dim _newLfacRowCab As CMDataSet.LINEASFACTURASRow = CMDataSet.LINEASFACTURAS.NewLINEASFACTURASRow
                _newLfacRowCab.CONCEPTO = "** Generado desde la cita del " & CDate(dtgItem.Cells("Fecha").Value).Date.ToShortDateString & " **"
                _newLfacRowCab.IMPORTE = 0
                _newLfacRowCab.CANTIDAD = 0
                _newLfacRowCab.TIPOIVA = 0
                _newLfacRowCab.REFFACTURA = _Id
                CMDataSet.LINEASFACTURAS.AddLINEASFACTURASRow(_newLfacRowCab)
                For i = 0 To _datalcita.Rows.Count - 1
                    _citacantidad = _datalcita.Rows(i).Item("CANTIDAD")
                    _citapreciouni = _datalcita.Rows(i).Item("IMPORTECLINICA") + _datalcita.Rows(i).Item("IMPORTEDR")
                    '-----------
                    'ahora creamos las lineas de las facturas
                    '-----------
                    Dim _newLfacRow As CMDataSet.LINEASFACTURASRow = CMDataSet.LINEASFACTURAS.NewLINEASFACTURASRow

                    _newLfacRow.CONCEPTO = _datalcita.Rows(i).Item("DESCRIPCION").ToString.Trim
                    If _datalcita.Rows(i).Item("REFCONCEPTO").ToString.Trim.Length > 0 Then
                        _newLfacRow.REFCONCEPTO = _datalcita.Rows(i).Item("REFCONCEPTO")
                    Else
                        _newLfacRow.REFCONCEPTO = Nothing
                    End If
                    _newLfacRow.IMPORTE = _citapreciouni
                    _newLfacRow.CANTIDAD = _citacantidad
                    _newLfacRow.TIPOIVA = 0
                    _newLfacRow.REFFACTURA = _Id
                    CMDataSet.LINEASFACTURAS.AddLINEASFACTURASRow(_newLfacRow)
                Next
            End If
        Next
        'Aplico las inserciones realizadas en la tabla Lineas Facturas.
        Me.LINEASFACTURASTableAdapter.Update(CMDataSet.LINEASFACTURAS)
        Me.CMDataSet.LINEASFACTURAS.AcceptChanges()

        'Actualizo el campo total de la factura.
        Dim _updRowFra As CMDataSet.FACTURASRow = CMDataSet.FACTURAS.FindByIDFACTURA(_Id)
        _updRowFra.TOTAL = SumImporte
        FACTURASTableAdapter.Update(CMDataSet.FACTURAS)
        CMDataSet.FACTURAS.AcceptChanges()
        Me.tb_facturagenerada.Text = NumeroFactura
    End Sub
    Private Function Number(ByVal acod As String) As String
        If acod <> "" Then
            Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetSerieByCodigo(acod)
            Dim _cantn As Integer = _data.Rows(0).Item("CONTADOR")
            Dim _cant As String = (_cantn + 1).ToString()
            Me.SERIESTableAdapter.Update(acod, _cantn + 1, acod, _cantn)
            Dim _digits As Integer = _cant.Length
            Dim i As Integer
            Dim _result As String = acod
            For i = 0 To 5 - _digits
                _result = _result + "0"
            Next
            _result = _result + _cant
            Return _result
        End If
        Return ""
    End Function

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting

        If Me.TabControl1.SelectedTab.Name = "tbp_Paso1" Then
            Me.bt_Anterior.Visible = False
            'If (Me.rb_pacientes.Checked = True) Then
            '    FiltrarPacientes()
            'Else
            '    FiltrarMutuas()
            'End If
        Else
            Me.bt_Anterior.Visible = True
        End If
        If Me.TabControl1.SelectedTab.Name = "tbp_Paso2" Then
            'MessageBox.Show("dd")
        End If
        If Me.TabControl1.SelectedTab.Name = "tbp_Paso3" Then
            If dg_PacientesMutuas.SelectedRows.Count = 0 Then
                MessageBox.Show("Debe seleccionar alguna linea para realizar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
                Return
            End If
            LlenarSerie()
            MostrarCitas()
        End If
        If Me.TabControl1.SelectedTab.Name = "tbp_Paso4" Then
            'verificamos que se haya seleccionado algo de la tabla
            Dim dtgItem As DataGridViewRow
            Dim cont As Boolean = False
            For Each dtgItem In dg_Citas.Rows
                If (dtgItem.Cells(0).Value = True) Then
                    cont = True
                End If
            Next
            If cont = False Then
                MessageBox.Show("Debe seleccionar alguna linea para realizar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
                Return
            Else
                CrearFactura()
                'MessageBox.Show("Realizando la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
        'ocultamos/mostramos los botones innecesarios en el paso4
        If Me.TabControl1.SelectedTab.Name = "tbp_Paso4" Then
            Me.bt_Aceptar.Visible = True
            Me.bt_Anterior.Visible = False
            Me.bt_Siguiente.Visible = False
            Me.bt_Cancelar.Visible = False
        End If
    End Sub



    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Name = "tbp_Paso2" Then
            'hemos seleccionado en el paso1..
            ' If (Me.rb_pacientes.Checked = True) Then
            Me.Label3.Visible = True
            Me.Label3.Text = "Cargando información de citas y pacientes, espere por favor. Esto podría tardar unos minutos."
            hilo = New Threading.Thread(AddressOf FiltrarPacientes)
            hilo.Start()
            
            'FiltrarPacientes()
            If Not (Me.rb_pacientes.Checked = True) Then
                Me.lblMutua.Visible = True
                Me.cmbMutuas.Visible = True
            Else
                Me.lblMutua.Visible = False
                Me.cmbMutuas.Visible = False
            End If
            'Else
            'FiltrarMutuas()
            'End If
        End If
    End Sub


    Private Sub bt_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Filtrar.Click
        '   If (Me.rb_pacientes.Checked = True) Then
        Me.Label3.Visible = True
        Me.Label3.Text = "Cargando información de citas y pacientes, espere por favor. Esto podría tardar unos minutos."
        hilo = New Threading.Thread(AddressOf FiltrarPacientes)
        hilo.Start()
        'FiltrarPacientes()
        '  Else
        '   FiltrarMutuas()
        '  End If

    End Sub

    'Private Sub MostrarPacientes()
    '    Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetData

    '    Dim i As Integer
    '    For i = 0 To _data.Rows.Count - 1
    '        Dim _cod As String = _data.Rows(i).Item("NOMBRE").ToString()
    '        'cb_seriepordefecto.Items.Add(_cod)
    '    Next

    '    If _data.Rows.Count > 0 Then
    '        'cb_seriepordefecto.SelectedIndex = 0

    '    End If

    '    dg_PacientesMutuas.DataSource = _data
    '    Dim j As Integer
    '    Dim tit As String
    '    For j = 0 To dg_PacientesMutuas.Columns.Count - 1
    '        tit = dg_PacientesMutuas.Columns(j).Name.ToString()
    '        If tit <> "NOMBRE" And tit <> "APELLIDO1" And tit <> "APELLIDO2" Then
    '            dg_PacientesMutuas.Columns(j).Visible = False
    '        End If
    '    Next
    'End Sub

    Private Sub FiltrarPacientes()
        dg_PacientesMutuas.DataSource = Nothing

        Dim _dataPac As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable
        Dim k As Integer
        Dim _expression As String = ""
        Dim _sortOrder As String = ""
        Dim _sortBy As String = " order by nombre "
        Dim _fecha As DateTime = Nothing

        'desactivo botones para evitar problemas
        Me.bt_Aceptar.Enabled = False
        Me.bt_Anterior.Enabled = False
        Me.bt_Cancelar.Enabled = False
        Me.bt_Filtrar.Enabled = False
        Me.bt_Siguiente.Enabled = False
        Me.dg_Citas.Enabled = False

        

        _expression = ""

        If Me.txtFiltrarPorNombre.Text <> Nothing Then
            _expression = " where nombre like '%" & Me.txtFiltrarPorNombre.Text & "%' " _
            & "OR apellido1 like '%" & Me.txtFiltrarPorNombre.Text & "%' " _
            & "OR apellido2 like '%" & Me.txtFiltrarPorNombre.Text & "%' "
        End If
        Me.PACIENTESTableAdapter.FillPacientes(CMDataSet.PACIENTES, "PACIENTES", _expression, _sortBy)
        'Dim _rows() As DataRow = CMDataSet.PACIENTES

        'For k = 0 To CMDataSet.PACIENTES.Rows.Count - 1
        '    _dataPac.ImportRow(CMDataSet.PACIENTES.Rows(k))
        'Next

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("cpaciente")
        _source.Columns.Add("nombre")
        _source.Columns.Add("apellido1")
        _source.Columns.Add("apellido2")
        _source.Columns.Add("alta")

        Dim i As Integer

        For i = 0 To CMDataSet.PACIENTES.Rows.Count - 1

            Dim _rowAded As Boolean = False
            Dim _row() As Object = New Object(4) {}

            _row(0) = CMDataSet.PACIENTES.Rows(i).Item("CPACIENTE")
            _row(1) = CMDataSet.PACIENTES.Rows(i).Item("NOMBRE")
            _row(2) = CMDataSet.PACIENTES.Rows(i).Item("APELLIDO1")
            _row(3) = CMDataSet.PACIENTES.Rows(i).Item("APELLIDO2")
            ' Me.Label3.Visible = True
            Me.Label3.Text = "Comprando citas de " & _row(2) & ", " & _row(3) & ", " & _row(1)

            If CMDataSet.PACIENTES.Rows(i).Item("FECHAALTA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fecha = CMDataSet.PACIENTES.Rows(i).Item("FECHAALTA")
                _row(4) = _fecha.ToShortDateString()
            End If

            'Compruebo si tiene citas y si las tiene en ese intervalo de tiempo lo añado al datatable.
            Dim tbCitas As CMDataSet.CITASDataTable
            Dim x As Integer = 0


            If Me.rb_Mutuas.Checked = True Then
                tbCitas = Me.CITASTableAdapter.GetDataByIntervalPacConMutua(Me.MonthCalendar1.SelectionStart.Date, Me.MonthCalendar2.SelectionStart.Date, _row(0))
                For x = 0 To tbCitas.Rows.Count - 1
                    _source.Rows.Add(_row)
                    _rowAded = True
                    Exit For
                Next
            Else
                tbCitas = Me.CITASTableAdapter.GetDataByIntervalPacSinMutua(Me.MonthCalendar1.SelectionStart.Date, Me.MonthCalendar2.SelectionStart.Date, _row(0))
                For x = 0 To tbCitas.Rows.Count - 1
                    _source.Rows.Add(_row)
                    _rowAded = True
                    Exit For
                Next
            End If



        Next
        'dg_PacientesMutuas.DataSource = _source
        PACIENTESBindingSource.DataSource = _source
        dg_PacientesMutuas.DataSource = PACIENTESBindingSource.DataSource
        dg_PacientesMutuas.Columns.Item("cpaciente").Visible = False
        Me.Label3.Visible = False

        'activo botones para evitar problemas
        Me.bt_Aceptar.Enabled = True
        Me.bt_Anterior.Enabled = True
        Me.bt_Cancelar.Enabled = true
        Me.bt_Filtrar.Enabled = True
        Me.bt_Siguiente.Enabled = True
        Me.dg_Citas.Enabled = True
        If Not hilo Is Nothing Then hilo = Nothing
    End Sub

    'Private Sub MostrarMutuas()
    '    'Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetData
    '    Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetData

    '    Dim i As Integer
    '    For i = 0 To _data.Rows.Count - 1
    '        Dim _cod As String = _data.Rows(i).Item("NOMBRE").ToString()
    '        'cb_seriepordefecto.Items.Add(_cod)
    '    Next

    '    If _data.Rows.Count > 0 Then
    '        'cb_seriepordefecto.SelectedIndex = 0

    '    End If

    '    dg_PacientesMutuas.DataSource = _data
    '    Dim j As Integer
    '    Dim tit As String
    '    For j = 0 To dg_PacientesMutuas.Columns.Count - 1
    '        tit = dg_PacientesMutuas.Columns(j).Name.ToString()
    '        If tit <> "NOMBRE" And tit <> "CIF" Then
    '            dg_PacientesMutuas.Columns(j).Visible = False
    '        End If
    '    Next
    'End Sub

    Private Sub FiltrarMutuas()
        Dim _dataMutua As CMDataSet.MUTUASDataTable = New CMDataSet.MUTUASDataTable
        Dim k As Integer
        Dim _expression As String = ""
        Dim _sortOrder As String = ""
        Dim _sortBy As String = "nombre ASC"

        dg_PacientesMutuas.DataSource = Nothing

        If Me.txtFiltrarPorNombre.Text <> Nothing Then
            _expression = "nombre like '%" + Me.txtFiltrarPorNombre.Text + "%'"
        End If

        Dim _rows() As DataRow = CMDataSet.MUTUAS.Select(_expression, _sortBy)

        For k = 0 To _rows.Length - 1
            _dataMutua.ImportRow(_rows(k))
        Next

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("cmutua")
        _source.Columns.Add("nombre")
        _source.Columns.Add("cif")


        Dim i As Integer

        For i = 0 To _dataMutua.Rows.Count - 1

            Dim _rowAded As Boolean = False
            Dim _row() As Object = New Object(2) {}

            _row(0) = _dataMutua.Rows(i).Item("CMUTUA")
            _row(1) = _dataMutua.Rows(i).Item("NOMBRE")
            _row(2) = _dataMutua.Rows(i).Item("CIF")


            _source.Rows.Add(_row)
            _rowAded = True


        Next

        'MUTUASBindingSource.DataSource = _source
        '   dg_PacientesMutuas.DataSource = MUTUASBindingSource
        dg_PacientesMutuas.DataSource = _source
        dg_PacientesMutuas.Columns.Item("CMUTUA").Visible = False

    End Sub

    Private Sub LlenarSerie()
        Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetData()
        Dim i As Integer
        cb_serie.Items.Clear()
        For i = 0 To _data.Rows.Count - 1
            Dim _cod As String = _data.Rows(i).Item("CODIGO").ToString()
            cb_serie.Items.Add(_cod)
        Next

        If _data.Rows.Count > 0 Then
            For i = 0 To _data.Rows.Count - 1
                If cb_serie.Items(i) = Globales.Configuracion.serie Then
                    cb_serie.SelectedIndex = i
                End If
            Next
        End If
        ' dtg_series.DataSource = _data
    End Sub

    Private Sub LlenarMutuasPaciente(ByVal IDPAC As Integer)
        Me.LMUTUASTableAdapter.FillByPacienteConNombreMutua(Me.CMDataSet.LMUTUAS, IDPAC)
        'Me.cmbMutuas.Items.Clear()
        Me.cmbMutuas.DataSource = Me.CMDataSet.LMUTUAS
        Me.cmbMutuas.ValueMember = "REFMUTUA"
        Me.cmbMutuas.DisplayMember = "NOMBRE"
    End Sub
    Private Sub MostrarCitas()

        'dg_Citas.DataSource = Nothing
        Dim _dataCita As CMDataSet.CITASDataTable = New CMDataSet.CITASDataTable
        Dim k As Integer
        Dim _expression As String = ""
        Dim _sortOrder As String = ""
        Dim _sortBy As String = "idcita ASC"
        Dim _Id As Integer
        Dim _IdMutua As Integer

        If dg_PacientesMutuas.SelectedRows.Count > 0 Then
            If rb_pacientes.Checked = True Then
                _Id = Integer.Parse(dg_PacientesMutuas.SelectedRows(0).Cells("cpaciente").Value.ToString())
                _expression += "(REFFRA<1 OR REFFRA IS NULL) AND (REFPROCEDENCIA<1 OR REFPROCEDENCIA IS NULL) AND refpaciente = " & _Id
            Else
                _Id = Integer.Parse(dg_PacientesMutuas.SelectedRows(0).Cells("cpaciente").Value.ToString())
                _IdMutua = Integer.Parse(cmbMutuas.SelectedValue)
                _expression += "(REFFRA<1 OR REFFRA IS NULL) AND refpaciente = " & _Id & " AND REFPROCEDENCIA = " & _IdMutua
            End If
        End If

        Dim tbCitas As CMDataSet.CITASDataTable
        tbCitas = Me.CITASTableAdapter.GetCitaByIntervalPac(Me.MonthCalendar1.SelectionStart.Date, Me.MonthCalendar2.SelectionStart.Date.AddMinutes(1439), _Id)
        Dim _rows() As DataRow = tbCitas.Select(_expression, _sortBy)
        For k = 0 To _rows.Length - 1
            _dataCita.ImportRow(_rows(k))
        Next

        Dim chkBox As System.Type = System.Type.GetType("System.Boolean")
        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("seleccion", chkBox)
        _source.Columns.Add("idcita")
        _source.Columns.Add("refpaciente")
        _source.Columns.Add("fecha", System.Type.GetType("System.DateTime"))
        _source.Columns.Add("hora", System.Type.GetType("System.DateTime"))
        _source.Columns.Add("paciente")

        Dim i As Integer
        dg_Citas.DataSource = _source
        'dg_Citas.Columns.Item("FECHA").DefaultCellStyle.Format = "d"
        'dg_Citas.Columns.Item("HORA").DefaultCellStyle.Format = "t"

        For i = 0 To _dataCita.Rows.Count - 1

            Dim _rowAded As Boolean = False
            Dim _row() As Object = New Object(5) {}
            _row(0) = True
            _row(1) = _dataCita.Rows(i).Item("IDCITA")
            _row(2) = _dataCita.Rows(i).Item("REFPACIENTE")
            _row(3) = _dataCita.Rows(i).Item("FECHA")
            _row(4) = _dataCita.Rows(i).Item("HORA")
            _row(5) = _dataCita.Rows(i).Item("PACIENTE")

            _source.Rows.Add(_row)
            _rowAded = True

        Next


        'CITASBindingSource.DataSource = _source
        'dg_Citas.DataSource = CITASBindingSource
        dg_Citas.Columns.Item("REFPACIENTE").Visible = False
        dg_Citas.Columns.Item("IDCITA").Visible = False
    End Sub

    Private Sub rb_Ninguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Ninguno.CheckedChanged
        Dim dtgItem As DataGridViewRow
        For Each dtgItem In dg_Citas.Rows
            If (rb_Todos.Checked = True) Then
                dtgItem.Cells(0).Value = True
            Else
                dtgItem.Cells(0).Value = False
            End If
        Next
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Aceptar.Click
        Me.Close()
    End Sub

    Private Sub dg_PacientesMutuas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg_PacientesMutuas.SelectionChanged
        Dim idpacienteseleccionado As Integer
        If dg_PacientesMutuas.SelectedCells.Count > 0 Then
            idpacienteseleccionado = Me.dg_PacientesMutuas.Rows(Me.dg_PacientesMutuas.SelectedCells(0).RowIndex).Cells("cpaciente").Value
            Me.LlenarMutuasPaciente(idpacienteseleccionado)
        End If
    End Sub
End Class