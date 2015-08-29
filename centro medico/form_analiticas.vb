Imports centro_medico.UI.Reportes

Public Class form_analiticas_ex

    Dim fId As Integer
    Dim fAnaliticaOrdenado As String
    Dim fAnaliticaIntervalo As Boolean
    Dim fAnaliticaRealCount As Integer
    Dim fAnaliticaRowSelected As Integer = 0
    Dim fMesActual As Boolean
    Dim fCambios As Boolean = False
    Dim fCerrando As Boolean = False

#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()
    End Sub
#End Region

    Private Sub form_analiticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.PACIENTES' Puede moverla o quitarla según sea necesario.
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.LINEASANALITICAS' Puede moverla o quitarla según sea necesario.
        'Me.LINEASANALITICASTableAdapter.Fill(Me.CMDataSet.LINEASANALITICAS)
        LINEASANALITICASTableAdapter.FillByPaciente(CMDataSet.LINEASANALITICAS, fId)
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.ANALITICAS' Puede moverla o quitarla según sea necesario.
        Me.ANALITICASTableAdapter.FillByPaciente(Me.CMDataSet.ANALITICAS, fId)

        nv_anAnaliticas.Visible = True

        AplicaPermisos()
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
        ActualizarFechaNac()
    End Sub

    Private Sub AplicaPermisos()
        dtg_anAnaliticas.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
        nv_anAnaliticas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
        BindingNavigatorAddNewItem5.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
        BindingNavigatorDeleteItem5.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 3)
        BindingNavigatorEditAnaliticas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
        dtg_anConceptosanaliticas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
        tb_anNotas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Analiticas) > 2)
    End Sub

    Private Sub InicializaAnaliticas(ByVal aOrdenar As String, ByVal aIntervalo As Boolean)

        Dim _dataAnaliticas As CMDataSet.ANALITICASDataTable = New CMDataSet.ANALITICASDataTable()

        Dim k As Integer

        Dim _expression As String = "REFPACIENTE = " + fId.ToString()
        Dim _sortOrder As String = "NUMERO ASC"

        If aOrdenar = "F" Then
            '_dataAnaliticas = ANALITICASTableAdapter.GetDataByPacienteOrderFecha(fId)
            _expression = "REFPACIENTE = " + fId.ToString()
            _sortOrder = "FECHA ASC"
        ElseIf aOrdenar = "N" Then
            '_dataAnaliticas = ANALITICASTableAdapter.GetDataByPacienteOrderNumero(fId)
            _expression = "REFPACIENTE = " + fId.ToString()
            _sortOrder = "NUMERO ASC"
        ElseIf aOrdenar = "I" Then
            '_dataAnaliticas = ANALITICASTableAdapter.GetDataByPacienteOrderImporte(fId)
            _expression = "REFPACIENTE = " + fId.ToString()
            _sortOrder = "IMPORTE ASC"
        Else
            '_dataAnaliticas = ANALITICASTableAdapter.GetDataByPaciente(fId)
            _expression = "REFPACIENTE = " + fId.ToString()
            _sortOrder = "DESCRIPCION ASC"
        End If

        Dim _rows() As DataRow = CMDataSet.ANALITICAS.Select(_expression, _sortOrder)

        For k = 0 To _rows.Length - 1
            _dataAnaliticas.ImportRow(_rows(k))
        Next


        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Número")
        _source.Columns.Add("Fecha")
        _source.Columns.Add("Descripción")
        _source.Columns.Add("Importe")
        _source.Columns.Add("Notas")
        _source.Columns.Add("Recibida", GetType(Boolean))

        Dim i As Integer
        For i = 0 To _dataAnaliticas.Rows.Count - 1

            Dim _rowAded As Boolean = False

            Dim _row() As Object = New Object(5) {}
            _row(0) = _dataAnaliticas.Rows(i).Item("NUMERO")

            Dim _fecha As DateTime = Nothing
            If _dataAnaliticas.Rows(i).Item("FECHA").GetType().ToString() <> DBNull.Value.ToString() Then
                _fecha = _dataAnaliticas.Rows(i).Item("FECHA")
                _row(1) = _fecha.ToShortDateString()
            End If

            _row(2) = _dataAnaliticas.Rows(i).Item("DESCRIPCION").ToString()
            _row(3) = _dataAnaliticas.Rows(i).Item("IMPORTE")
            _row(4) = _dataAnaliticas.Rows(i).Item("NOTAS").ToString()
            _row(5) = _dataAnaliticas.Rows(i).Item("RECIBIDA")


            If aIntervalo = True Then
                If _fecha <> Nothing Then
                    If _fecha >= dtp_anDesde.Value And _fecha <= dtp_anHasta.Value Then
                        _source.Rows.Add(_row)
                        _rowAded = True
                    End If
                End If

            Else
                _source.Rows.Add(_row)
                _rowAded = True
            End If

            If fMesActual = True Then

                If _fecha = Nothing And _rowAded = True Then
                    _source.Rows.RemoveAt(_source.Rows.Count - 1)
                Else
                    If _fecha.Month <> DateTime.Now.Month And _rowAded = True Then
                        _source.Rows.RemoveAt(_source.Rows.Count - 1)
                    End If
                End If

            End If

        Next

        fAnaliticaRealCount = _source.Rows.Count
        ANALITICASBindingSource.DataSource = _source
        dtg_anAnaliticas.DataSource = ANALITICASBindingSource
        dtg_anAnaliticas.Columns("Importe").Visible = Not (Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) = RoleManager.TipoPermisos.Ninguno)
        nv_anAnaliticas.BindingSource = ANALITICASBindingSource
        fAnaliticaRowSelected = 0

        If _source.Rows.Count > 0 Then
            dtg_anAnaliticas.AllowUserToAddRows = False
            dtg_anAnaliticas.AllowUserToDeleteRows = False
        End If

    End Sub

    Private Sub FillConceptosAnalitica(ByVal aId As Integer)

        Dim _data As CMDataSet.LINEASANALITICASDataTable = New CMDataSet.LINEASANALITICASDataTable()
        '  LINEASANALITICASTableAdapter.GetLineasByAnaliticas(aId)

        Dim k As Integer
        Dim _expression As String = "REFANALITICA = " + aId.ToString()
        Dim _rows() As DataRow = CMDataSet.LINEASANALITICAS.Select(_expression)
        For k = 0 To _rows.Length - 1
            _data.ImportRow(_rows(k))
        Next
        Dim _resf As DataTable = New DataTable()
        _resf.Columns.Add("Concepto")
        _resf.Columns.Add("Precio")
        _resf.Columns.Add("Resultado")
        Dim i As Integer
        For i = 0 To _data.Rows.Count - 1
            Dim _concepto As String = _data.Rows(i).Item("CONCEPTO").ToString()
            Dim _importe As Single = _data.Rows(i).Item("PRECIO")
            Dim _resultado As String = _data.Rows(i).Item("RESULTADO").ToString()
            _resf.Rows.Add(_concepto, _importe, _resultado)

        Next
        dtg_anConceptosanaliticas.DataSource = _resf
        dtg_anConceptosanaliticas.Columns("PRECIO").Visible = False
    End Sub

    Private Sub BindingNavigatorAddNewItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem5.Click
        Dim _cantidadInicial As Integer = dtg_anAnaliticas.Rows.Count

        Dim _add_analitica As form_analiticas = New form_analiticas("Ficha de Analiticas-Añadir", Enums.Accion.Insertar, -1, fId, CMDataSet)
        _add_analitica.ShowInTaskbar = False
        _add_analitica.ShowDialog()
        fCambios = True

        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
        If dtg_anAnaliticas.Rows.Count > 0 And dtg_anAnaliticas.Rows.Count <> _cantidadInicial Then
            fAnaliticaRowSelected = dtg_anAnaliticas.Rows.Count - 1
        End If

        Guardar()
    End Sub

    Private Sub BindingNavigatorDeleteItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem5.Click
        If dtg_anAnaliticas.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_anAnaliticas.SelectedRows(0).Index

            Dim _Cod As Integer = Integer.Parse(dtg_anAnaliticas.SelectedRows(0).Cells("Número").Value.ToString())
            'ANALITICASTableAdapter.DeleteById(_Cod)

            'CMDataSet.ANALITICAS.RemoveANALITICASRow(CMDataSet.ANALITICAS.FindByNUMERO(_Cod))
            Dim _row As CMDataSet.ANALITICASRow = CMDataSet.ANALITICAS.FindByNUMERO(_Cod)
            _row.Delete()

            fAnaliticaRealCount = fAnaliticaRealCount - 1
            fCambios = True

            If dtg_anAnaliticas.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                fAnaliticaRowSelected = _index
            End If
            Guardar()
        End If
    End Sub

    Private Sub BindingNavigatorEditAnaliticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditAnaliticas.Click
        If dtg_anAnaliticas.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_anAnaliticas.SelectedRows(0).Index

            Dim _Cod As Integer = Integer.Parse(dtg_anAnaliticas.SelectedRows(0).Cells("Número").Value.ToString())
            Dim _add_analitica As form_analiticas = New form_analiticas("Ficha de Analiticas-Editar", Enums.Accion.Modificar, _Cod, fId, CMDataSet)
            _add_analitica.ShowInTaskbar = False
            _add_analitica.ShowDialog()
            If dtg_anAnaliticas.Rows.Count > 0 Then
                InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
                Dim _Id As Integer = Integer.Parse(dtg_anAnaliticas.Rows(dtg_anAnaliticas.CurrentRow.Index).Cells("Número").Value.ToString())
                FillConceptosAnalitica(_Id)
                tb_anTotal.Text = dtg_anAnaliticas.Rows(dtg_anAnaliticas.CurrentRow.Index).Cells("Importe").Value.ToString()
                tb_anNotas.Text = dtg_anAnaliticas.Rows(dtg_anAnaliticas.CurrentRow.Index).Cells("Notas").Value.ToString()
            End If

            fAnaliticaRowSelected = _index
            fCambios = True
            Guardar()
        End If
    End Sub

    Private Sub dtg_anAnaliticas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_anAnaliticas.Paint
        If dtg_anAnaliticas.Rows.Count > fAnaliticaRealCount Then
            dtg_anAnaliticas.Rows.RemoveAt(dtg_anAnaliticas.Rows.Count - 1)
        End If

        If dtg_anAnaliticas.Rows.Count > 0 Then
            dtg_anAnaliticas.Rows(fAnaliticaRowSelected).Selected = True
        End If

        BorrarFilasAnaliticas()
        tb_anTotal.Text = ""
        tb_anNotas.Text = ""
        If dtg_anAnaliticas.SelectedRows.Count > 0 Then
            Dim _Id As Integer = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Número").Value
            FillConceptosAnalitica(_Id)
            tb_anTotal.Text = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Importe").Value.ToString()
            tb_anNotas.Text = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Notas").Value.ToString()
        End If
    End Sub

    Private Sub dtg_anAnaliticas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_anAnaliticas.SelectionChanged
        If dtg_anAnaliticas.SelectedRows.Count > 0 And dtg_anAnaliticas.Rows.Count = fAnaliticaRealCount Then
            If dtg_anAnaliticas.SelectedRows.Item(0).Cells("Número").Value.GetType.ToString() <> DBNull.Value.GetType.ToString() Then
                Dim _Id As Integer = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Número").Value
                FillConceptosAnalitica(_Id)
                tb_anTotal.Text = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Importe").Value.ToString()
                tb_anNotas.Text = dtg_anAnaliticas.SelectedRows.Item(0).Cells("Notas").Value.ToString()
            End If
            fAnaliticaRowSelected = dtg_anAnaliticas.SelectedRows(0).Index
        End If
    End Sub

    Private Sub BorrarFilasAnaliticas()
        Dim i As Integer

        For i = 0 To dtg_anConceptosanaliticas.Rows.Count - 1
            dtg_anConceptosanaliticas.Rows.RemoveAt(0)
        Next
    End Sub

    Private Sub rb_anNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_anNumero.CheckedChanged
        fAnaliticaOrdenado = "N"
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
    End Sub

    Private Sub rb_anFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_anFecha.CheckedChanged
        fAnaliticaOrdenado = "F"
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
    End Sub

    Private Sub rb_anDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_anDescripcion.CheckedChanged
        fAnaliticaOrdenado = "D"
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
    End Sub

    Private Sub rb_anImporte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_anImporte.CheckedChanged
        fAnaliticaOrdenado = "I"
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
    End Sub

    Private Sub bt_anFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_anFiltrar.Click
        fAnaliticaIntervalo = True
        InicializaAnaliticas(fAnaliticaOrdenado, fAnaliticaIntervalo)
    End Sub

    Private Sub tlbImprimirAnalitica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimirAnalitica.Click
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim rpt2 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim _data As New CMDataSet.ANALITICASDataTable 'analiticas
        Dim _data2 As New CMDataSet.LINEASANALITICASDataTable 'lineasanaliticas
        Dim codigoAnalitica As Integer
        Dim i As Integer = 0
        'bt_aceptar_Click(Nothing, Nothing)

        '   _analitica = Me.ANALITICASTableAdapter.GetAnaliticaById(Me.fId)
        '   _lineasanalitica = Me.LINEASANALITICASTableAdapter.GetLineasByAnaliticas(Me.fId)
        Me.Guardar()
        codigoAnalitica = Me.dtg_anAnaliticas.SelectedRows(0).Cells("Número").Value
        _data = Me.ANALITICASTableAdapter.GetAnaliticaById(codigoAnalitica)
        _data2 = Me.LINEASANALITICASTableAdapter.GetLineasByAnaliticas(codigoAnalitica)

        rpt.Name = "CMDataSet_ANALITICAS"
        rpt.Value = _data
        rpt2.Name = "CMDataSet_LINEASANALITICAS"
        rpt2.Value = _data2


        ReportesManager.Imprime("AnaliticaPeticion.rdlc", {rpt, rpt2})

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

    Private Sub Guardar()
        Try

        
            dtg_anAnaliticas.EndEdit()
            dtg_anConceptosanaliticas.EndEdit()
            Me.ANALITICASBindingSource.EndEdit()
            Me.ANALITICASTableAdapter.Update(CMDataSet.ANALITICAS)
            Me.LINEASANALITICASBindingSource.EndEdit()
            Me.LINEASANALITICASTableAdapter.Update(CMDataSet.LINEASANALITICAS)
        Catch ex As Exception
            MsgBox("Error al guardar " & ex.Message)
        End Try
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Guardar()
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

    Private Sub form_analiticas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                BindingNavigatorAddNewItem5_Click(sender, e)
            Case Globales.TeclasBasicas.Borrar
                BindingNavigatorDeleteItem5_Click(sender, e)
            Case Globales.TeclasBasicas.Editar
                BindingNavigatorEditAnaliticas_Click(sender, e)
            Case Globales.TeclasBasicas.Filtrar
                Me.bt_anFiltrar_Click(sender, e)
        End Select
    End Sub
    Private Sub dtg_anAnaliticas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_anAnaliticas.CellMouseDoubleClick
        'permiso lectura no deja editar
        If (Globales.Usuario.Permisos(RoleManager.Items.Analiticas) = RoleManager.TipoPermisos.Lectura) Then
            Return
        End If
        BindingNavigatorEditAnaliticas_Click(sender, e)
    End Sub

    Private Sub form_analiticas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult
        If fCambios = True And fCerrando = False Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class