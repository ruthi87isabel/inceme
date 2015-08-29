Public Class form_antecedentes

    Dim fId As Integer
    Dim fMesActual As Boolean
    Dim fCambios As Boolean = False
    Dim fCerrando As Boolean = False

#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()

        'RECETASBindingSource.Filter = "refpaciente =" & fId
    End Sub
#End Region

    Private Sub form_recetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.AntecedentesDiagnosticos' table. You can move, or remove it, as needed.
        Me.AntecedentesDiagnosticosTableAdapter.FillByCPACIENTE(Me.CMDataSet.AntecedentesDiagnosticos, fId)
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        Me.INFORMACIONPRIMARIATableAdapter.FillByPaciente(Me.CMDataSet.INFORMACIONPRIMARIA, fId)
        Me.LINEASALARMATableAdapter.FillByPaciente(Me.CMDataSet.LINEASALARMA, fId)
        Me.ALARMASTableAdapter.FillAlarmaByPaciente(Me.CMDataSet.ALARMAS, fId)

        AplicaPermisos()
        InicializaAlarmas()
        InicializaInformacionPrimaria()
        ActualizarFechaNac()
    End Sub

    Private Sub AplicaPermisos()
        bt_amMasArriba.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        bt_amMenosArriba.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 3)
        bt_amMasAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        bt_amTrianguloAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        bt_amMenosAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 3)
        dtg_amAlarmas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        dtg_amInfoprimaria.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        tb_amDescripcion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        tb_amGrandeabajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        dtg_amAlarmas.EndEdit()
        dtg_amInfoprimaria.EndEdit()
        ALARMASBindingSource.EndEdit()
        ALARMASTableAdapter.Update(CMDataSet.ALARMAS)
        LINEASALARMABindingSource.EndEdit()
        LINEASALARMATableAdapter.Update(CMDataSet.LINEASALARMA)
        INFORMACIONPRIMARIABindingSource.EndEdit()
        INFORMACIONPRIMARIATableAdapter.Update(CMDataSet.INFORMACIONPRIMARIA)
        Me.AntecedentesDiagnosticosBindingSource.EndEdit()
        Me.AntecedentesDiagnosticosTableAdapter.Update(CMDataSet.AntecedentesDiagnosticos)
        fCerrando = True
        Me.Close()
    End Sub


    Private Sub InicializaAlarmas()
        Dim _dataAlarma As DataTable = New DataTable()
        'ALARMASTableAdapter.GetAlarmaByPaciente(fId)
        _dataAlarma.Columns.Add("IDLINEAALARMA")
        _dataAlarma.Columns.Add("Alarma")
        _dataAlarma.Columns.Add("Nivel")
        _dataAlarma.Columns.Add("CALARMA")
        _dataAlarma.Columns.Add("DESCRIPCION")

        Dim _rowsLineaAlarma() As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.Select("REFPACIENTE = " + fId.ToString())

        Dim maxNivelAlarma = 0 'Ninguno

        Dim k As Integer
        For k = 0 To _rowsLineaAlarma.Length - 1
            Dim _row() As Object = New Object(4) {}
            _row(0) = _rowsLineaAlarma(k).Item("IDLINEAALARMA")

            Dim _alarma As CMDataSet.ALARMASDataTable = ALARMASTableAdapter.GetAlarmaById(_rowsLineaAlarma(k).Item("REFALARMA"))

            _row(1) = _alarma.Rows(0).Item("ALARMA").ToString()
            _row(2) = _alarma.Rows(0).Item("NIVEL").ToString()
            Select Case _row(2)
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
            _row(3) = _alarma.Rows(0).Item("CALARMA")
            _row(4) = _alarma.Rows(0).Item("DESCRIPCION").ToString()

            _dataAlarma.Rows.Add(_row)

        Next

        dtg_amAlarmas.DataSource = _dataAlarma
        dtg_amAlarmas.Columns("DESCRIPCION").Visible = False
        dtg_amAlarmas.Columns("IDLINEAALARMA").Visible = False
        dtg_amAlarmas.Columns("CALARMA").Visible = False


        If dtg_amAlarmas.Rows.Count > 0 Then
            tb_amDescripcion.Text = dtg_amAlarmas.Rows.Item(0).Cells("DESCRIPCION").Value.ToString()
        End If
        'Establezco el valor al lblAlarmas del mdiParent

        Select Case maxNivelAlarma
            Case 3  ' Alta
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(255, 69, 0)
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "¡¡ATENCIÓN!!"
            Case 2
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(249, 247, 186)
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "¡PRECAUCIÓN!"
            Case 1
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(255, 174, 0)
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "CUIDADO"
            Case 0
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = System.Drawing.Color.GhostWhite
                Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = ""
        End Select
    End Sub

    Private Sub bt_amMasArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_amMasArriba.Click
        Me.ALARMASTableAdapter.Fill(Me.CMDataSet.ALARMAS)

        Dim _cantidadInicial As Integer = dtg_amAlarmas.Rows.Count

        Dim _name As String = "Listado de Alarmas"
        Dim _listados As form_listados = New form_listados(_name, ALARMASBindingSource, RoleManager.Items.Alarmas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        fCambios = True
        If _listados.Selected <> Nothing Then

            Dim _aId As Integer = Integer.Parse(_listados.Selected)
            Dim _esta As Boolean = False
            Dim i As Integer
            For i = 0 To dtg_amAlarmas.Rows.Count - 1
                If dtg_amAlarmas.Rows(i).Cells("CALARMA").Value = _aId Then
                    _esta = True
                End If
            Next

            If _esta = False Then
                'LINEASALARMATableAdapter.Insert(fId, _listados.Selected, "")
                Dim _newRow As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.NewLINEASALARMARow()
                Dim _rows() As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.Select("", "IDLINEAALARMA ASC")

                Dim _maxBD As Integer = 1
                If LINEASALARMATableAdapter.MaximoId().HasValue = True Then
                    If Integer.TryParse(LINEASALARMATableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If
                End If
                Dim _maxDS As Integer = 1

                If _rows.Length > 0 Then
                    _maxDS = _rows(_rows.Length - 1).IDLINEAALARMA() + 1
                End If

                _newRow.IDLINEAALARMA() = Math.Max(_maxDS, _maxBD)

                _newRow.REFPACIENTE() = fId
                _newRow.REFALARMA() = _aId
                _newRow.DESCRIPCION() = ""
                CMDataSet.LINEASALARMA.AddLINEASALARMARow(_newRow)
                '=====> BORRAR EN LINEASALARMA
                InicializaAlarmas()
            End If
        End If

        If dtg_amAlarmas.Rows.Count > 0 And dtg_amAlarmas.Rows.Count <> _cantidadInicial Then
            dtg_amAlarmas.Rows(dtg_amAlarmas.Rows.Count - 1).Selected = True
        End If


    End Sub

    Private Sub dtg_amAlarmas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_amAlarmas.SelectionChanged
        If dtg_amAlarmas.SelectedRows.Count > 0 Then
            tb_amDescripcion.Text = dtg_amAlarmas.SelectedRows.Item(0).Cells("DESCRIPCION").Value.ToString()
        End If

    End Sub

    Private Sub bt_amMenosArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_amMenosArriba.Click

        If dtg_amAlarmas.SelectedRows.Count > 0 Then

            Dim _index As Integer = dtg_amAlarmas.SelectedRows(0).Index


            Dim _idAlarma As Integer = dtg_amAlarmas.SelectedRows.Item(0).Cells("IDLINEAALARMA").Value
            'LINEASALARMATableAdapter.DeleteLineaAlarmaById(_idAlarma)
            'CMDataSet.LINEASALARMA.RemoveLINEASALARMARow(CMDataSet.LINEASALARMA.FindByIDLINEAALARMA(_idAlarma))
            Dim _row As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.FindByIDLINEAALARMA(_idAlarma)
            _row.Delete()
            fCambios = True

            '=====> ANNADIR EN LINEASALARMA
            InicializaAlarmas()
            If dtg_amAlarmas.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                dtg_amAlarmas.Rows(_index).Selected = True
            End If

        End If

    End Sub


    Private Sub InicializaInformacionPrimaria()

        'Llenando DataGrid de InformacionPrimaria
        Dim _dataInfoPrim As CMDataSet.INFORMACIONPRIMARIADataTable = New CMDataSet.INFORMACIONPRIMARIADataTable()
        'INFORMACIONPRIMARIATableAdapter.GetInfoPrimByPaciente(fId)
        Dim _rowsInfo() As CMDataSet.INFORMACIONPRIMARIARow = CMDataSet.INFORMACIONPRIMARIA.Select("REFPACIENTE =" + fId.ToString())

        Dim i As Integer

        For i = 0 To _rowsInfo.Length - 1

            _dataInfoPrim.ImportRow(_rowsInfo(i))

            Dim _fechaA As DateTime = Nothing
            If _dataInfoPrim.Rows(0)("FECHA").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
                _fechaA = _dataInfoPrim.Rows(0)("FECHA")
                _dataInfoPrim.Rows(0)("FECHA") = _fechaA.ToShortDateString()
            End If

            'If fMesActual = True Then
            '    If _fechaA = Nothing Then
            '        _dataInfoPrim.Rows.RemoveAt(0)
            '    Else
            '        If _fechaA.Month <> DateTime.Now.Month Then
            '            _dataInfoPrim.Rows.RemoveAt(0)
            '        End If
            '    End If

            'End If
        Next

        dtg_amInfoprimaria.DataSource = _dataInfoPrim

        dtg_amInfoprimaria.Columns("ID").Visible = False
        dtg_amInfoprimaria.Columns("TEXTO").Visible = False
        dtg_amInfoprimaria.Columns("REFPACIENTE").Visible = False

        If dtg_amInfoprimaria.Rows.Count > 0 Then
            tb_amGrandeabajo.Text = dtg_amInfoprimaria.Rows.Item(0).Cells("TEXTO").Value.ToString()
        End If


    End Sub

    Private Sub bt_amMasAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_amMasAbajo.Click

        Dim _cantidadInicial As Integer = dtg_amInfoprimaria.Rows.Count

        Dim _infoprimaria As form_pac_infoprimaria = New form_pac_infoprimaria(Enums.Accion.Insertar)

        _infoprimaria.ShowInTaskbar = False
        _infoprimaria.ShowDialog()
        fCambios = True
        If (_infoprimaria.Aceptar() = True) Then
            'INFORMACIONPRIMARIATableAdapter.InsertQuerySinId(_infoprimaria.Fecha(), _infoprimaria.Descripcion(), _infoprimaria.Detalle(), fId)
            Dim _newRow As CMDataSet.INFORMACIONPRIMARIARow = CMDataSet.INFORMACIONPRIMARIA.NewINFORMACIONPRIMARIARow()

            Dim _rows() As CMDataSet.INFORMACIONPRIMARIARow = CMDataSet.INFORMACIONPRIMARIA.Select("", "ID ASC")

            Dim _maxBD As Integer = 1
            If INFORMACIONPRIMARIATableAdapter.MaximoId.HasValue Then
                If Integer.TryParse(INFORMACIONPRIMARIATableAdapter.MaximoId(), _maxBD) Then
                    _maxBD = _maxBD + 1
                End If
            End If

            Dim _maxDS As Integer = 1

            If _rows.Length > 0 Then
                _maxDS = _rows(_rows.Length - 1).ID() + 1
            End If

            _newRow.ID() = Math.Max(_maxDS, _maxBD)
            _newRow.FECHA() = _infoprimaria.Fecha()
            _newRow.DESCRIPCION() = _infoprimaria.Descripcion()
            _newRow.TEXTO() = _infoprimaria.Detalle()
            _newRow.REFPACIENTE() = fId

            CMDataSet.INFORMACIONPRIMARIA.AddINFORMACIONPRIMARIARow(_newRow)

            InicializaInformacionPrimaria()

        End If

        If dtg_amInfoprimaria.Rows.Count > 0 And dtg_amInfoprimaria.Rows.Count <> _cantidadInicial Then
            dtg_amInfoprimaria.Rows(dtg_amInfoprimaria.Rows.Count - 1).Selected = True
        End If

    End Sub

    Private Sub dtg_amInfoprimaria_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_amInfoprimaria.SelectionChanged
        If dtg_amInfoprimaria.SelectedRows.Count > 0 Then
            tb_amGrandeabajo.Text = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("TEXTO").Value.ToString()
        End If
    End Sub

    Private Sub bt_amTrianguloAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_amTrianguloAbajo.Click

        If dtg_amInfoprimaria.SelectedRows.Count > 0 Then
            fCambios = True
            Dim _index As Integer = dtg_amInfoprimaria.SelectedRows(0).Index

            Dim _infoprimaria As form_pac_infoprimaria = New form_pac_infoprimaria(Enums.Accion.Modificar)

            If dtg_amInfoprimaria.SelectedRows.Item(0).Cells("FECHA").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _infoprimaria.Fecha() = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("FECHA").Value
            End If

            If dtg_amInfoprimaria.SelectedRows.Item(0).Cells("DESCRIPCION").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _infoprimaria.Descripcion() = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("DESCRIPCION").Value.ToString()

            End If

            If dtg_amInfoprimaria.SelectedRows.Item(0).Cells("TEXTO").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _infoprimaria.Detalle() = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("TEXTO").Value.ToString()
            End If

            _infoprimaria.ShowInTaskbar = False
            _infoprimaria.ShowDialog()

            If (_infoprimaria.Aceptar() = True) Then
                'INFORMACIONPRIMARIATableAdapter.UpdateQueryById(_infoprimaria.Fecha(), _infoprimaria.Descripcion(), _infoprimaria.Detalle(), dtg_amInfoprimaria.SelectedRows.Item(0).Cells("REFPACIENTE").Value, dtg_amInfoprimaria.SelectedRows.Item(0).Cells("ID").Value)

                Dim _Id As Integer = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("ID").Value
                Dim _updRow As CMDataSet.INFORMACIONPRIMARIARow = CMDataSet.INFORMACIONPRIMARIA.FindByID(_Id)

                _updRow.FECHA() = _infoprimaria.Fecha()
                _updRow.DESCRIPCION() = _infoprimaria.Descripcion()
                _updRow.TEXTO() = _infoprimaria.Detalle()
                _updRow.REFPACIENTE() = fId

                InicializaInformacionPrimaria()

            End If
            dtg_amInfoprimaria.Rows(_index).Selected = True

        End If

    End Sub
    '//YA = DATA SET
    Private Sub bt_amMenosAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_amMenosAbajo.Click
        If dtg_amInfoprimaria.SelectedRows.Count > 0 Then

            Dim _index As Integer = dtg_amInfoprimaria.SelectedRows(0).Index

            Dim _idInfoprim As Integer = dtg_amInfoprimaria.SelectedRows.Item(0).Cells("ID").Value
            'INFORMACIONPRIMARIATableAdapter.DeleteQueryById(_idInfoprim)
            'CMDataSet.INFORMACIONPRIMARIA.RemoveINFORMACIONPRIMARIARow(CMDataSet.INFORMACIONPRIMARIA.FindByID(_idInfoprim))
            Dim _row As CMDataSet.INFORMACIONPRIMARIARow = CMDataSet.INFORMACIONPRIMARIA.FindByID(_idInfoprim)
            _row.Delete()
            fCambios = True
            InicializaInformacionPrimaria()


            If dtg_amInfoprimaria.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                dtg_amInfoprimaria.Rows(_index).Selected = True
            End If
        End If
    End Sub



    Private Sub AddAntecedentesDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddDiagnostico.Click
        Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.fId)
        nuevoDiag.ShowInTaskbar = False
        nuevoDiag.ShowDialog()
        If nuevoDiag.DialogResult = Windows.Forms.DialogResult.OK Then
            fCambios = True
            Dim FILA As CMDataSet.AntecedentesDiagnosticosRow
            FILA = CMDataSet.AntecedentesDiagnosticos.NewAntecedentesDiagnosticosRow
            FILA.CIE10 = nuevoDiag.Cie10
            FILA.DIAGNOSTICO = nuevoDiag.Diagnostico
            FILA.OBSERVACIONES = nuevoDiag.Observaciones
            FILA.CPACIENTE = fId
            FILA.IDDIAGNOSTICO = nuevoDiag.idDiagnostico

            CMDataSet.AntecedentesDiagnosticos.Rows.Add(FILA)
        End If
    End Sub

    Private Sub bt_EditaDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EditaDiagnostico.Click
        If Me.dtg_Diagnosticos.SelectedRows.Count = 0 Then
            Return
        End If


        Dim Cie10 As String
        Dim Observaciones As String
        Dim Diagnostico As String
        Dim idDiagnostico As Integer

        'filaSeleccionada = Me.dtg_Diagnosticos.SelectedRows(0).Cells("IDANTECEDENTEDX").Value
        Cie10 = Me.dtg_Diagnosticos.SelectedRows(0).Cells("CIE10").Value
        Observaciones = Me.dtg_Diagnosticos.SelectedRows(0).Cells("OBSERVACIONES").Value
        Diagnostico = Me.dtg_Diagnosticos.SelectedRows(0).Cells("DIAGNOSTICO").Value
        idDiagnostico = Me.dtg_Diagnosticos.SelectedRows(0).Cells("IDDIAGNOSTICO").Value


        Dim nuevoDiag As New form_Add_AntecedentesDiagnostico(Me.fId, True)
        nuevoDiag.ShowInTaskbar = False
        nuevoDiag.Cie10 = Cie10
        nuevoDiag.Observaciones = Observaciones
        nuevoDiag.Diagnostico = Diagnostico
        nuevoDiag.idDiagnostico = idDiagnostico

        nuevoDiag.ShowDialog()

        If nuevoDiag.DialogResult = Windows.Forms.DialogResult.OK Then
            'Dim FILA As CMDataSet.AntecedentesDiagnosticosRow

            Me.dtg_Diagnosticos.SelectedRows(0).Cells("CIE10").Value = nuevoDiag.Cie10
            Me.dtg_Diagnosticos.SelectedRows(0).Cells("DIAGNOSTICO").Value = nuevoDiag.Diagnostico
            Me.dtg_Diagnosticos.SelectedRows(0).Cells("OBSERVACIONES").Value = nuevoDiag.Observaciones
            Me.dtg_Diagnosticos.SelectedRows(0).Cells("IDDIAGNOSTICO").Value = nuevoDiag.idDiagnostico
        End If
    End Sub

    Private Sub bt_QuitaDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_QuitaDiagnostico.Click
        Dim i As Integer
        Dim res As MsgBoxResult
        If dtg_Diagnosticos.SelectedRows.Count > 0 Then

            res = MsgBox("Se dispone a borrar " & dtg_Diagnosticos.SelectedRows.Count & ", esta acción no podrá deshacerse ¿Desea continuar?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                fCambios = True
                For i = 0 To dtg_Diagnosticos.SelectedRows.Count - 1
                    Me.dtg_Diagnosticos.Rows.Remove(dtg_Diagnosticos.SelectedRows(0))
                Next
            End If
        End If
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

    Private Sub dtg_amInfoprimaria_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_amInfoprimaria.CellMouseDoubleClick
        bt_amTrianguloAbajo_Click(sender, e)
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

    Private Sub form_antecedentes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult
        If fCambios = True And fCerrando = False Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dtg_Diagnosticos_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_Diagnosticos.CellMouseDoubleClick
        bt_EditaDiagnostico_Click(Nothing, Nothing)
    End Sub

    Private Sub bt_alarma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_alarma.Click
        If dtg_amAlarmas.SelectedRows.Count > 0 Then

            Dim _index As Integer = dtg_amAlarmas.SelectedRows(0).Index


            Dim _idAlarma As Integer = dtg_amAlarmas.SelectedRows.Item(0).Cells("IDLINEAALARMA").Value
            Dim _name As String = "Listado de Alarmas"
            Dim _listados As form_listados = New form_listados(_name, ALARMASBindingSource, RoleManager.Items.Alarmas, True)
            _listados.ShowInTaskbar = False
            _listados.ShowDialog()
            fCambios = True
            If _listados.Selected <> Nothing Then

                Dim _aId As Integer = Integer.Parse(_listados.Selected)
                Dim _esta As Boolean = False
                Dim i As Integer
                For i = 0 To dtg_amAlarmas.Rows.Count - 1
                    If dtg_amAlarmas.Rows(i).Cells("CALARMA").Value = _aId Then
                        _esta = True
                    End If
                Next

                If _esta = False Then
                    Dim _row As CMDataSet.LINEASALARMARow = CMDataSet.LINEASALARMA.FindByIDLINEAALARMA(_idAlarma)
                    _row.REFALARMA = _aId
                    fCambios = True

                End If



                InicializaAlarmas()
                If dtg_amAlarmas.Rows.Count > 0 Then
                    If _index <> 0 Then
                        _index = _index - 1
                    End If
                    dtg_amAlarmas.Rows(_index).Selected = True
                End If
            End If
        End If
    End Sub

    Private Sub dtg_amAlarmas_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_amAlarmas.CellMouseDoubleClick
        bt_alarma_Click(sender, e)
    End Sub
End Class