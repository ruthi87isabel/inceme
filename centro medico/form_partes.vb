Imports Microsoft.ApplicationBlocks.Data.SqlHelper
Public Class form_partes

    Dim fId As Integer
    Dim fCambios As Boolean = False
    Dim fCerrando As Boolean = False

    Dim fMesActual As Boolean

    Dim fParteOrdenado As String
    Dim fParteIntervalo As Boolean = False
    Dim fPartesRowSelected As Integer = 0
    Dim fPartesRealCount As Integer

#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()
    End Sub
#End Region

    Private Sub bt_reFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fParteIntervalo = True
        CargarPartes(fParteOrdenado, fParteIntervalo)
    End Sub


    Private Sub CargarPartes(ByVal aOrdenar As String, ByVal aIntervalo As Boolean)
        Me.PARTESTableAdapter.FillByPaciente(Me.CMDataSet.PARTES, fId.ToString)
        Dim _dataPartes As CMDataSet.PARTESDataTable = New CMDataSet.PARTESDataTable()

        Dim k As Integer

        Dim _expression As String = "REFPACIENTE = " + fId.ToString()
        Dim _sortOrder As String = ""

        If aOrdenar = "F" Then
            _sortOrder = "FECHA ASC"
        Else
            _sortOrder = "TIPO ASC"
        End If

        Dim _rows() As DataRow = CMDataSet.PARTES.Select(_expression, _sortOrder)

        For k = 0 To _rows.Length - 1
            _dataPartes.ImportRow(_rows(k))
        Next

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Id")
        _source.Columns.Add("Fecha")
        _source.Columns.Add("Empresa")
        _source.Columns.Add("Mutua")
        _source.Columns.Add("Tipo")


        Dim i As Integer

        For i = 0 To _dataPartes.Rows.Count - 1

            Dim _rowAded As Boolean = False

            Dim _row() As Object = New Object(4) {}
            _row(0) = _dataPartes.Rows(i).Item("IDPARTE")

            Dim _fecha As DateTime = Nothing
            If _dataPartes.Rows(i).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fecha = _dataPartes.Rows(i).Item("FECHA")
                _row(1) = _fecha.ToShortDateString()
            End If

            _row(2) = _dataPartes.Rows(i).Item("EMPRESA").ToString()
            _row(3) = _dataPartes.Rows(i).Item("MUTUA").ToString()
            _row(4) = _dataPartes.Rows(i).Item("TIPO").ToString()

            If aIntervalo = True Then

                If _fecha <> Nothing Then
                    If _fecha >= dtp_paDesde.Value And _fecha <= dtp_paHasta.Value Then
                        _source.Rows.Add(_row)
                        _rowAded = True
                    End If
                End If

            Else
                _source.Rows.Add(_row)
                _rowAded = True
            End If

            If fMesActual = True Then

                If _fecha = Nothing Then
                    _source.Rows.RemoveAt(_source.Rows.Count - 1)
                Else
                    If _fecha.Month <> DateTime.Now.Month And _rowAded = True Then
                        _source.Rows.RemoveAt(_source.Rows.Count - 1)
                    End If
                End If

            End If

        Next

        fPartesRealCount = _source.Rows.Count
        PARTESBindingSource.DataSource = _source
        dtg_paPartes.DataSource = PARTESBindingSource
        nv_paPartes.BindingSource = PARTESBindingSource

        fPartesRowSelected = 0


        If _source.Rows.Count > 0 Then
            dtg_paPartes.AllowUserToAddRows = False
            dtg_paPartes.AllowUserToDeleteRows = False
            dtg_paPartes.Columns("Id").Visible = False
        End If
    End Sub


    Private Sub form_partes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim now As Date = Date.Now
        dtp_paDesde.Value = Globales.DamePrimeraFecha("FECHA", "PARTES") ' New Date(now.Year, now.Month, now.Day, 0, 0, 0)
        dtp_paHasta.Value = New Date(now.Year, now.Month, now.Day, 23, 59, 59)

        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        Me.PARTESTableAdapter.FillByPaciente(CMDataSet.PARTES, fId)
        nv_paPartes.Visible = True
        AplicaPermisos()
        ActualizarFechaNac()
        CargarPartes(fParteOrdenado, fParteIntervalo)
    End Sub

    Private Sub AplicaPermisos()
        dtg_paPartes.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Partes) > 2)
        BindingNavigatorAddNewItem2.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Partes) > 2)
        BindingNavigatorDeleteItem2.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Partes) > 3)
        BindingNavigatorEditPartes.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Partes) > 2)
        nv_paPartes.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Partes) > 3)
    End Sub


    Private Sub BindingNavigatorAddNewItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem2.Click
        Dim _cantidadInicial As Integer = dtg_paPartes.Rows.Count
        Dim _dataDatosPersonales As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable()
        _dataDatosPersonales.ImportRow(CMDataSet.PACIENTES.FindByCPACIENTE(fId))
        fCambios = True
        Dim _Id As Integer = -1
        If _dataDatosPersonales.Rows(0).Item("REFEMPRESA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _Id = _dataDatosPersonales.Rows(0).Item("REFEMPRESA")
        End If
        Dim _elegir As form_elegir_parte = New form_elegir_parte(fId, _Id, CMDataSet)
        _elegir.ShowInTaskbar = False
        _elegir.ShowDialog()

        'tsbGuardar_Click(sender, e)
        'Me.PARTESTableAdapter.FillByPaciente(CMDataSet.PARTES, fId)

        CargarPartes(fParteOrdenado, fParteIntervalo)
        '   InicializaFacturas(fFacturasFiltrado, fFacturasOrdenado, fFacturasIntervalo)
        If dtg_paPartes.Rows.Count > 0 And dtg_paPartes.Rows.Count <> _cantidadInicial Then
            fPartesRowSelected = dtg_paPartes.Rows.Count - 1
        End If

    End Sub

    Private Sub BindingNavigatorDeleteItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem2.Click
        If dtg_paPartes.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_paPartes.SelectedRows(0).Index
            Dim _Id As Integer = Integer.Parse(dtg_paPartes.SelectedRows(0).Cells("Id").Value.ToString())
            Dim _row As CMDataSet.PARTESRow = CMDataSet.PARTES.FindByIDPARTE(_Id)
            _row.Delete()
            fCambios = True
            fPartesRealCount = fPartesRealCount - 1

            If dtg_paPartes.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                fPartesRowSelected = _index
            End If
        End If
    End Sub

    Private Sub BindingNavigatorEditPartes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditPartes.Click
        'If dtg_paPartes.SelectedRows.Count > 0 Then
        '    Dim _index As Integer = dtg_paPartes.SelectedRows(0).Index
        '    Dim _Id As Integer = Integer.Parse(dtg_paPartes.SelectedRows(0).Cells("Id").Value.ToString())
        '    Dim _dataDatosPersonales As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable()
        '    _dataDatosPersonales.ImportRow(CMDataSet.PACIENTES.FindByCPACIENTE(fId))
        '    fCambios = True
        '    Dim _IdEmpresa As Integer = -1
        '    If _dataDatosPersonales.Rows(0).Item("REFEMPRESA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
        '        _IdEmpresa = _dataDatosPersonales.Rows(0).Item("REFEMPRESA")
        '    End If
        '    If dtg_paPartes.SelectedRows(0).Cells("Tipo").Value.ToString() <> "S" Then
        '        Dim _nueva_alta As form_alta_baja_ex = New form_alta_baja_ex("Ficha de alta/baja-Modificar", Enums.Accion.Modificar, _Id, False, fId, _IdEmpresa, CMDataSet)
        '        _nueva_alta.ShowInTaskbar = False
        '        _nueva_alta.ShowDialog()
        '    Else
        '        Dim _nueva_asistencia As form_parte_asistencia = New form_parte_asistencia("Ficha de asistencia-Modificar", Enums.Accion.Modificar, _Id, fId, _IdEmpresa, CMDataSet)
        '        _nueva_asistencia.ShowInTaskbar = False
        '        _nueva_asistencia.ShowDialog()
        '    End If

        '    Me.PARTESTableAdapter.FillByPaciente(CMDataSet.PARTES, fId)
        '    CargarPartes(fParteOrdenado, fParteIntervalo)
        '    ' InicializaFacturas(fFacturasFiltrado, fFacturasOrdenado, fFacturasIntervalo)
        '    fPartesRowSelected = _index

        'End If
    End Sub

    Private Sub dtg_paPartes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_paPartes.SelectionChanged
        If dtg_paPartes.SelectedRows.Count > 0 And dtg_paPartes.Rows.Count = fPartesRealCount Then
            fPartesRowSelected = dtg_paPartes.SelectedRows(0).Index
        End If
    End Sub

    Private Sub dtg_paPartes_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_paPartes.Paint
        If dtg_paPartes.Rows.Count > fPartesRealCount Then
            dtg_paPartes.Rows.RemoveAt(dtg_paPartes.Rows.Count - 1)
        End If
        If dtg_paPartes.Rows.Count > 0 Then
            dtg_paPartes.Rows(fPartesRowSelected).Selected = True
        End If
    End Sub

    Private Sub bt_paFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_paFiltrar.Click
        fParteIntervalo = True
        CargarPartes(fParteOrdenado, fParteIntervalo)
    End Sub

    Private Sub dtg_paPartes_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_paPartes.CellMouseDoubleClick
        'permiso lectura no deja editar
        If (Globales.Usuario.Permisos(RoleManager.Items.Partes) = RoleManager.TipoPermisos.Lectura) Then
            Return
        End If
        BindingNavigatorEditPartes_Click(sender, e)
    End Sub

    Private Sub rb_paTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_paTipo.CheckedChanged
        fParteOrdenado = "T"
        CargarPartes(fParteOrdenado, fParteIntervalo)
    End Sub

    Private Sub rb_paFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_paFecha.CheckedChanged
        fParteOrdenado = "F"
        CargarPartes(fParteOrdenado, fParteIntervalo)
    End Sub




    Private Sub Guardar()
        dtg_paPartes.EndEdit()
        Me.PARTESBindingSource.EndEdit()
        Me.PARTESTableAdapter.Update(CMDataSet.PARTES)

        'Borrar Bajas que no tienen asociado un Parte ya que no existe integridad referencial.
        Dim strSql As String = "Delete from Bajas Where (REFPARTE NOT IN (SELECT IDPARTE FROM PARTES))"
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, strSql)

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Guardar()
        fCerrando = True
        Me.Close()
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

    Private Sub form_citas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                BindingNavigatorAddNewItem2_Click(sender, e)
            Case Globales.TeclasBasicas.Borrar
                BindingNavigatorDeleteItem2_Click(sender, e)
            Case Globales.TeclasBasicas.Editar
                BindingNavigatorEditPartes_Click(sender, e)
            Case Globales.TeclasBasicas.Filtrar
                Me.bt_paFiltrar_Click(sender, e)
        End Select
    End Sub


    Private Sub form_partes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult
        If fCambios = True And fCerrando = False Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
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

End Class