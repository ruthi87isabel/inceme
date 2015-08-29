Public Class form_hislaboral
    Dim fId As Integer
    Dim fIdEmpresa As Integer = -1
    Dim fIdMutua As Integer = -1
    Dim fELoading As Boolean = True
    Dim fMLoading As Boolean = True
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


    Private Sub form_histlaboral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.LMUTUAS' Puede moverla o quitarla según sea necesario.
        Me.LMUTUASTableAdapter.Fill(Me.CMDataSet.LMUTUAS)
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)
        Me.LEMPRESASTableAdapter.Fill(Me.CMDataSet.LEMPRESAS)
        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)

        AplicaPermisos()
        ActualizarFechaNac()

        InicializaEmpresas()
        InicializaMutuas()
    End Sub

    Private Sub AplicaPermisos()
        tb_hlProfesion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        tb_hlPuesto.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        cb_hlRegimen.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        gb_hlEmpresa.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        gb_hlMutAsegComprev.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlAddEmpresa.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlEditarEmpresa.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlElimEmpresa.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 3)
        bt_hlSelecEmpresa.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlAddMutua.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlEditarMutua.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        bt_hlElimMutua.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 3)
        bt_hlSelecMutua.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)

        If Globales.Usuario.Permisos(RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then

        End If


    End Sub



    Private Sub InicializaEmpresas()

        '  PACIENTESTableAdapter.Update(CMDataSet.PACIENTES)

        'Me.LEMPRESASTableAdapter.FillByPaciente(CMDataSet.LEMPRESAS, fId)

        Dim _dataLEmpresa As CMDataSet.LEMPRESASDataTable = New CMDataSet.LEMPRESASDataTable()
        'LEMPRESASTableAdapter.GetDataByPaciente(fId)
        Me.LEMPRESASTableAdapter.FillByPaciente(CMDataSet.LEMPRESAS, fId)



        Dim _source As DataTable = New DataTable()
        _source.Columns.Add("Codigo")
        _source.Columns.Add("IdEmpresa")
        _source.Columns.Add("Empresa")
        _source.Columns.Add("F. Alta")
        _source.Columns.Add("F. Baja")
        _source.Columns.Add("Puesto")

        Dim _rowsLEmpresa() As CMDataSet.LEMPRESASRow = CMDataSet.LEMPRESAS.Select("REFPACIENTE = " + fId.ToString())

        Dim k As Integer

        For k = 0 To _rowsLEmpresa.Length - 1
            _dataLEmpresa.ImportRow(_rowsLEmpresa(k))

            Dim _rowSource() As Object = New Object(5) {}
            _rowSource(0) = _dataLEmpresa.Rows(k).Item("CODIGO")
            _rowSource(1) = _dataLEmpresa.Rows(k).Item("REFEMPRESA")
            _rowSource(3) = _dataLEmpresa.Rows(k).Item("FECHAALTA")
            _rowSource(4) = _dataLEmpresa.Rows(k).Item("FECHABAJA")
            _rowSource(5) = _dataLEmpresa.Rows(k).Item("PUESTOTRABAJO")

            _rowSource(2) = EMPRESASTableAdapter.GetEmpresaById(_rowSource(1)).Rows(0).Item("NOMBRE")

            _source.Rows.Add(_rowSource)

        Next

        If _source.Rows.Count > 0 Then

            dtg_hlLEmpresas.DataSource = _source

            Dim i As Integer


            Dim paciente As CMDataSet.PACIENTESRow = PACIENTESTableAdapter.GetPacienteById(fId)(0)


            For i = 0 To dtg_hlLEmpresas.Rows.Count - 1
                'vinculado a otros form - vicente
                'If fIdEmpresa = dtg_hlLEmpresas.Rows(i).Cells("IdEmpresa").Value Then
                '    If tb_dpEmpresaactual.Text <> "" Then
                '        Dim _font As Font = New Font("Arial", 8, FontStyle.Bold)
                '        dtg_hlLEmpresas.Rows(i).DefaultCellStyle.Font = _font
                '    End If
                'End If

                Dim _fechaA As DateTime = Nothing
                If dtg_hlLEmpresas.Rows(i).Cells("F. Alta").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                    _fechaA = dtg_hlLEmpresas.Rows(i).Cells("F. Alta").Value
                    dtg_hlLEmpresas.Rows(i).Cells("F. Alta").Value = _fechaA.ToShortDateString()
                End If

                If dtg_hlLEmpresas.Rows(i).Cells("F. Baja").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                    Dim _fechaB As DateTime = dtg_hlLEmpresas.Rows(i).Cells("F. Baja").Value
                    dtg_hlLEmpresas.Rows(i).Cells("F. Baja").Value = _fechaB.ToShortDateString()

                End If


                If fMesActual = True Then
                    If _fechaA = Nothing Then
                        dtg_hlLEmpresas.Rows.RemoveAt(i)
                    Else
                        If _fechaA.Month <> DateTime.Now.Month Then
                            dtg_hlLEmpresas.Rows.RemoveAt(i)
                        End If
                    End If

                End If

                If Not paciente.IsREFEMPRESANull Then
                    If paciente.REFEMPRESA = dtg_hlLEmpresas.Rows(i).Cells(1).Value Then
                        dtg_hlLEmpresas.Rows(i).DefaultCellStyle.Font = New Font(dtg_hlLEmpresas.Font, FontStyle.Bold)
                    End If
                End If

            Next

            dtg_hlLEmpresas.Columns("Codigo").Visible = False
            dtg_hlLEmpresas.Columns("IdEmpresa").Visible = False

        Else
            dtg_hlLEmpresas.DataSource = New DataTable()
        End If

    End Sub

    Private Sub bt_hlAddEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlAddEmpresa.Click
        Dim _cantidadInicial As Integer = dtg_hlLEmpresas.Rows.Count

        Dim context As New CMLinqDataContext()

        Dim linea As New LEMPRESA()
        linea.REFPACIENTE = fId
        linea.PUESTOTRABAJO = ""
        Dim frm As New frmEmpresa_Paciente()
        frm.LEMPRESABindingSource.DataSource = linea
        If frm.ShowDialog() = DialogResult.OK Then

            If Not Globales.Empresa_Existe(linea.REFEMPRESA, fId) Then
                context.LEMPRESAs.InsertOnSubmit(linea)
            Else
                MessageBox.Show("La empresa seleccionada ya existe")
                Return
            End If

            If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim _aId As Integer = linea.REFEMPRESA
                Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = fId Select p).SingleOrDefault()
                If Not paciente Is Nothing Then
                    paciente.REFEMPRESA = linea.REFEMPRESA
                    fIdEmpresa = linea.REFEMPRESA
                End If
            End If
            context.SubmitChanges()
            fCambios = True
            GuardarSinSalir()
            InicializaEmpresas()
        End If
        


        'Dim _annadirEmpresa As form_pac_annadirempresa = New form_pac_annadirempresa("Ficha empresa - Añadir", Enums.Accion.Insertar, fId, CMDataSet)
        '_annadirEmpresa.ShowInTaskbar = False
        '_annadirEmpresa.ShowDialog()


        'fCambios = True
        'If _annadirEmpresa.IdEmpresa() <> -1 Then

        '    If Not Globales.Empresa_Existe(_annadirEmpresa.IdEmpresa(), fId) Then

        '        If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

        '            Dim _aId As Integer = _annadirEmpresa.IdEmpresa()
        '            fIdEmpresa = _aId

        '            CMDataSet.PACIENTES(0).REFEMPRESA = _aId
        '            PACIENTESTableAdapter.UpdateEmpresa(_aId, fId)

        '        End If
        '        GuardarSinSalir()
        '        InicializaEmpresas()
        '    Else
        '        MessageBox.Show("La empresa seleccionada ya existe.")
        '    End If
        'End If

        If dtg_hlLEmpresas.Rows.Count > 0 And dtg_hlLEmpresas.Rows.Count <> _cantidadInicial Then
            dtg_hlLEmpresas.Rows(dtg_hlLEmpresas.Rows.Count - 1).Selected = True
        End If

    End Sub

    Private Sub bt_hlEditarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlEditarEmpresa.Click

        If dtg_hlLEmpresas.SelectedRows.Count > 0 Then
            Try

            
            fCambios = True
            Dim _index As Integer = dtg_hlLEmpresas.SelectedRows(0).Index

            Dim context As New CMLinqDataContext()
                Dim codigo As Integer = Integer.Parse(dtg_hlLEmpresas.SelectedRows.Item(0).Cells("Codigo").Value.ToString())

                Dim lEmpresa As LEMPRESA = (From c In context.LEMPRESAs _
                                            Where c.CODIGO = codigo And c.REFPACIENTE = fId
                                            Select c).SingleOrDefault()

            If Not lEmpresa Is Nothing Then
                Dim frm As New frmEmpresa_Paciente()
                frm.LEMPRESABindingSource.DataSource = lEmpresa
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    context.SubmitChanges()
                    InicializaEmpresas()
                    dtg_hlLEmpresas.Rows(_index).Selected = True
                End If
            End If


            'Dim _annadirEmpresa As form_pac_annadirempresa = New form_pac_annadirempresa("Ficha empresa - Editar", Enums.Accion.Modificar, fId, dtg_hlLEmpresas.SelectedRows.Item(0).Cells("Codigo").Value, CMDataSet)
            '_annadirEmpresa.ShowInTaskbar = False
            '_annadirEmpresa.ShowDialog()

            'InicializaEmpresas()
                'dtg_hlLEmpresas.Rows(_index).Selected = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bt_hlElimEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlElimEmpresa.Click
        If dtg_hlLEmpresas.SelectedRows.Count > 0 Then
            fCambios = True
            Dim _index As Integer = dtg_hlLEmpresas.SelectedRows(0).Index

            Dim _aId As Integer = dtg_hlLEmpresas.SelectedRows.Item(0).Cells("Codigo").Value
            Dim _eId As Integer = dtg_hlLEmpresas.SelectedRows.Item(0).Cells("IdEmpresa").Value


            If _eId = fIdEmpresa Then
                fIdEmpresa = -1
                'vinculado a otros form - vicente
                'tb_dpEmpresaactual.Text = ""

                CMDataSet.PACIENTES.FindByCPACIENTE(fId).REFEMPRESA() = Nothing
                MessageBox.Show("Debe establecer una empresa. Sino este valor quedará en blanco ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'LEMPRESASTableAdapter.DeleteById(_aId)
            'CMDataSet.LEMPRESAS.RemoveLEMPRESASRow(CMDataSet.LEMPRESAS.FindByCODIGO(_aId))
            Dim _row As CMDataSet.LEMPRESASRow = CMDataSet.LEMPRESAS.FindByCODIGO(_aId)
            _row.Delete()
            GuardarSinSalir()

            InicializaEmpresas()

            If dtg_hlLEmpresas.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                dtg_hlLEmpresas.Rows(_index).Selected = True
            End If

        End If
    End Sub

    Private Sub bt_hlSelecEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlSelecEmpresa.Click
        If dtg_hlLEmpresas.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_hlLEmpresas.SelectedRows(0).Index
            If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                Dim _aId As Integer = dtg_hlLEmpresas.SelectedRows.Item(0).Cells("IdEmpresa").Value
                fIdEmpresa = _aId
                Me.CMDataSet.PACIENTES(0).REFEMPRESA = _aId
                PACIENTESTableAdapter.UpdateEmpresa(_aId, fId)

                'vinculado a otros form - vicente
                'tb_dpEmpresaactual.Text = dtg_hlLEmpresas.SelectedRows.Item(0).Cells("Empresa").Value
                InicializaEmpresas()
            End If
            dtg_hlLEmpresas.Rows(_index).Selected = True
        End If
    End Sub


    Private Sub InicializaMutuas()

        'PACIENTESTableAdapter.Update(CMDataSet.PACIENTES)
        'On Error Resume Next

        Dim _dataLMutua As CMDataSet.LMUTUASDataTable = New CMDataSet.LMUTUASDataTable()
        'LMUTUASTableAdapter.GetDataByPaciente(fId)


        Dim _source As DataTable = New DataTable()
        _source.Columns.Add("Codigo")
        _source.Columns.Add("IdMutua")
        _source.Columns.Add("Tipo")
        _source.Columns.Add("Mutua")
        _source.Columns.Add("F. Alta")
        _source.Columns.Add("F. Baja")

        Dim _rowsLMutua() As CMDataSet.LMUTUASRow = CMDataSet.LMUTUAS.Select("REFPACIENTE = " + fId.ToString())

        Dim k As Integer


        For k = 0 To _rowsLMutua.Length - 1
            _dataLMutua.ImportRow(_rowsLMutua(k))

            Dim _rowSource() As Object = New Object(5) {}

            _rowSource(0) = _dataLMutua.Rows(k).Item("CODIGO")
            _rowSource(1) = _dataLMutua.Rows(k).Item("REFMUTUA")
            _rowSource(2) = _dataLMutua.Rows(k).Item("TIPO").ToString()

            If _rowSource(2) = "M" Then
                _rowSource(2) = "Mutua asistencial"
            ElseIf _rowSource(2) = "C" Then
                _rowSource(2) = "Compañía de revisión"
            ElseIf _rowSource(2) = "A" Then
                _rowSource(2) = "Aseguradora privada"
            End If

            _rowSource(4) = _dataLMutua.Rows(k).Item("FECHAALTA")
            _rowSource(5) = _dataLMutua.Rows(k).Item("FECHABAJA")

            If _rowSource(1) > 0 Then
                _rowSource(3) = MUTUASTableAdapter.GetMutuaById(_rowSource(1)).Rows(0).Item("NOMBRE").ToString()
            End If

            _source.Rows.Add(_rowSource)

        Next

        If _source.Rows.Count > 0 Then
            dtg_hlMutuas.DataSource = _source
            Dim i As Integer


            Dim paciente As CMDataSet.PACIENTESRow = PACIENTESTableAdapter.GetPacienteById(fId)(0)

            For i = 0 To dtg_hlMutuas.Rows.Count - 1

                'vinculado a otros form - vicente
                'If fIdMutua = dtg_hlMutuas.Rows(i).Cells("IdMutua").Value Then
                '    If tb_dpMutuaactual.Text <> "" Then
                '        Dim _font As Font = New Font("Arial", 8, FontStyle.Bold)
                '        dtg_hlMutuas.Rows(i).DefaultCellStyle.Font = _font
                '    End If
                'End If

                Dim _fechaA As DateTime = Nothing
                If dtg_hlMutuas.Rows(i).Cells("F. Alta").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                    _fechaA = dtg_hlMutuas.Rows(i).Cells("F. Alta").Value
                    dtg_hlMutuas.Rows(i).Cells("F. Alta").Value = _fechaA.ToShortDateString()

                End If

                If dtg_hlMutuas.Rows(i).Cells("F. Baja").Value.GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                    Dim _fechaB As DateTime = dtg_hlMutuas.Rows(i).Cells("F. Baja").Value
                    dtg_hlMutuas.Rows(i).Cells("F. Baja").Value = _fechaB.ToShortDateString()

                End If


                If fMesActual = True Then
                    If _fechaA = Nothing Then
                        dtg_hlMutuas.Rows.RemoveAt(i)
                    Else
                        If _fechaA.Month <> DateTime.Now.Month Then
                            dtg_hlMutuas.Rows.RemoveAt(i)
                        End If
                    End If

                End If

                If Not paciente.IsREFMUTUANull Then
                    If paciente.REFMUTUA = dtg_hlMutuas.Rows(i).Cells(1).Value Then
                        dtg_hlMutuas.Rows(i).DefaultCellStyle.Font = New Font(dtg_hlMutuas.Font, FontStyle.Bold)
                    End If
                End If

            Next

            dtg_hlMutuas.Columns("Codigo").Visible = False
            dtg_hlMutuas.Columns("IdMutua").Visible = False
        Else
            dtg_hlMutuas.DataSource = New DataTable()
        End If

        'Err.Clear()
    End Sub

    Private Sub bt_hlAddMutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlAddMutua.Click

        Dim _cantidadInicial As Integer = dtg_hlMutuas.Rows.Count
        fCambios = True
        Dim _annadirMutua As form_pac_annadirmutua = New form_pac_annadirmutua("Ficha mutua - Añadir", Enums.Accion.Insertar, fId, CMDataSet)
        _annadirMutua.ShowInTaskbar = False
        _annadirMutua.ShowDialog()
        If _annadirMutua.IdMutua() <> -1 Then

            'Chequear si existe la  mutua
            If Not Globales.Mutua_Existe(_annadirMutua.IdMutua, fId) Then

                If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Dim _aId As Integer = _annadirMutua.IdMutua()

                    fIdMutua = _aId

                    Me.CMDataSet.PACIENTES(0).REFMUTUA = _aId

                    PACIENTESTableAdapter.UpdateMutua(_aId, fId)

                    'vinculado a otros form - vicente
                    'tb_dpMutuaactual.Text = _annadirMutua.Nombre()
                End If
                GuardarSinSalir()
                InicializaMutuas()


                If dtg_hlMutuas.Rows.Count > 0 And dtg_hlMutuas.Rows.Count <> _cantidadInicial Then
                    dtg_hlMutuas.Rows(dtg_hlMutuas.Rows.Count - 1).Selected = True
                End If
            Else
                MessageBox.Show("La mutua seleccionada ya existe")
            End If
        End If
    End Sub

    Private Sub bt_hlEditarMutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlEditarMutua.Click
        If dtg_hlMutuas.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_hlMutuas.SelectedRows(0).Index
            Dim _annadirMutua As form_pac_annadirmutua = New form_pac_annadirmutua("Ficha mutua - Editar", Enums.Accion.Modificar, fId, dtg_hlMutuas.SelectedRows.Item(0).Cells("Codigo").Value, CMDataSet)
            _annadirMutua.ShowInTaskbar = False
            _annadirMutua.ShowDialog()
            fCambios = True

            InicializaMutuas()

            dtg_hlMutuas.Rows(_index).Selected = True

        End If
    End Sub

    Private Sub bt_hlElimMutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlElimMutua.Click
        If dtg_hlMutuas.SelectedRows.Count > 0 Then

            Dim _index As Integer = dtg_hlMutuas.SelectedRows(0).Index

            Dim _aId As Integer = dtg_hlMutuas.SelectedRows.Item(0).Cells("Codigo").Value
            Dim _mId As Integer = dtg_hlMutuas.SelectedRows.Item(0).Cells("IdMutua").Value

            fCambios = True
            If _mId = fIdMutua Then
                fIdMutua = -1
                'vinculado a otros form - vicente
                'tb_dpMutuaactual.Text = ""

                CMDataSet.PACIENTES.FindByCPACIENTE(fId).REFMUTUA() = Nothing
                MessageBox.Show("Debe establecer una mutua. Sino este valor quedara en blanco ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'LMUTUASTableAdapter.DeleteByCodigo(_aId)
            'CMDataSet.LMUTUAS.RemoveLMUTUASRow(CMDataSet.LMUTUAS.FindByCODIGO(_aId))
            Dim _row As CMDataSet.LMUTUASRow = CMDataSet.LMUTUAS.FindByCODIGO(_aId)
            _row.Delete()
            GuardarSinSalir()
            InicializaMutuas()


            If dtg_hlMutuas.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                dtg_hlMutuas.Rows(_index).Selected = True
            End If

        End If
    End Sub

    Private Sub bt_hlSelecMutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hlSelecMutua.Click
        If dtg_hlMutuas.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_hlMutuas.SelectedRows(0).Index

            If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim _aId As Integer = dtg_hlMutuas.SelectedRows.Item(0).Cells("IdMutua").Value
                fIdMutua = _aId

                CMDataSet.PACIENTES.FindByCPACIENTE(fId).REFMUTUA() = _aId
                PACIENTESTableAdapter.UpdateMutua(_aId, fId)

                'vinculado a otros form - vicente
                'tb_dpMutuaactual.Text = dtg_hlMutuas.SelectedRows.Item(0).Cells("Mutua").Value
                InicializaMutuas()
            End If
            dtg_hlMutuas.Rows(_index).Selected = True

        End If
    End Sub

    Private Sub dtg_hlLEmpresas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_hlLEmpresas.Paint
        If fELoading = True Then
            InicializaEmpresas()
            fELoading = False
        End If

    End Sub

    Private Sub dtg_hlMutuas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_hlMutuas.Paint

        If fMLoading = True Then
            InicializaMutuas()
            fMLoading = False
        End If
    End Sub

    Private Sub dtg_hlLEmpresas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_hlLEmpresas.CellMouseDoubleClick
        bt_hlEditarEmpresa_Click(sender, e)
    End Sub


    Private Sub dtg_hlMutuas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_hlMutuas.CellMouseDoubleClick
        'permiso lectura no deja editar
        bt_hlEditarMutua_Click(sender, e)
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

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        GuardarSinSalir()
        fCerrando = True
        Me.Close()
    End Sub

    Private Sub GuardarSinSalir()
        dtg_hlLEmpresas.EndEdit()
        EMPRESASBindingSource.EndEdit()
        EMPRESASTableAdapter.Update(CMDataSet.EMPRESAS)
        LEMPRESASBindingSource.EndEdit()
        LEMPRESASTableAdapter.Update(CMDataSet.LEMPRESAS)
        dtg_hlMutuas.EndEdit()
        MUTUASBindingSource.EndEdit()
        MUTUASTableAdapter.Update(CMDataSet.MUTUAS)
        LMUTUASBindingSource.EndEdit()
        LMUTUASTableAdapter.Update(CMDataSet.LMUTUAS)
    End Sub

    Private Sub form_hislaboral_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult
        If fCambios = True And fCerrando = False Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub


End Class