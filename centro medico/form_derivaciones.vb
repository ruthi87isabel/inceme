Public Class form_derivaciones_ex

    Dim fId As Integer
    Dim fDerivacionesIntervalo As Boolean
    Dim fDerivacionesRealCount As Integer
    Dim fDerivacionesRowSelected As Integer = 0
    Dim fMesActual As Boolean
    Dim fCambios As Boolean = False


#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()

        'RECETASBindingSource.Filter = "refpaciente =" & fId
    End Sub
#End Region




    Private Sub form_derivaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DERIVACIONESTableAdapter.FillByPaciente(Me.CMDataSet.DERIVACIONES, fId)
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)

        nv_derDerivaciones.Visible = True
        AplicaPermisos()
        InicializaDerivaciones(fDerivacionesIntervalo)
        ActualizarFechaNac()
    End Sub


    Private Sub AplicaPermisos()
        dtg_derDerivaciones.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) > 2)
        nv_derDerivaciones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) > 3)
        BindingNavigatorAddNewItem9.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) > 2)
        BindingNavigatorDeleteItem9.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) > 3)
        BindingNavigatorEditDerivaciones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) > 2)
    End Sub


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.dtg_derDerivaciones.EndEdit()
        DERIVACIONESBindingSource.EndEdit()
        DERIVACIONESTableAdapter.Update(CMDataSet.DERIVACIONES)
        Me.Close()
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Dim res As MsgBoxResult
        If fCambios = True Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                Me.Close()
            End If
            End
        Else
            Me.Close()
        End If
    End Sub

    Private Sub InicializaDerivaciones(ByVal aIntervalo As Boolean)

        Dim _dataDerivaciones As CMDataSet.DERIVACIONESDataTable = New CMDataSet.DERIVACIONESDataTable()
        'DERIVACIONESTableAdapter.GetDataByPaciente(fId)

        Dim _rows() As CMDataSet.DERIVACIONESRow = CMDataSet.DERIVACIONES.Select("REFPACIENTE = " + fId.ToString())

        Dim k As Integer

        For k = 0 To _rows.Length - 1
            _dataDerivaciones.ImportRow(_rows(k))
        Next


        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Código")
        _source.Columns.Add("Fecha")
        _source.Columns.Add("Destino")
        _source.Columns.Add("Motivo")


        Dim i As Integer

        For i = 0 To _dataDerivaciones.Rows.Count - 1

            Dim _rowAded As Boolean = False

            Dim _row() As Object = New Object(3) {}
            _row(0) = _dataDerivaciones.Rows(i).Item("CODIGO")

            Dim _fecha As DateTime = Nothing
            If _dataDerivaciones.Rows(i).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fecha = _dataDerivaciones.Rows(i).Item("FECHA")
                _row(1) = _fecha.ToShortDateString()
            End If

            _row(2) = _dataDerivaciones.Rows(i).Item("DESTINO").ToString()
            _row(3) = _dataDerivaciones.Rows(i).Item("MOTIVO").ToString()

            If aIntervalo = True Then
                If _fecha <> Nothing Then
                    If _fecha >= dtp_derDesde.Value And _fecha <= dtp_derHasta.Value Then
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

        fDerivacionesRealCount = _source.Rows.Count
        DERIVACIONESBindingSource.DataSource = _source
        dtg_derDerivaciones.DataSource = DERIVACIONESBindingSource
        nv_derDerivaciones.BindingSource = DERIVACIONESBindingSource

        fDerivacionesRowSelected = 0

        If _source.Rows.Count > 0 Then
            dtg_derDerivaciones.AllowUserToAddRows = False
            dtg_derDerivaciones.AllowUserToDeleteRows = False
            dtg_derDerivaciones.Columns("Código").Visible = False
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem9.Click
        Dim _cantidadInicial As Integer = dtg_derDerivaciones.Rows.Count
        Dim _derivaciones As form_derivaciones = New form_derivaciones("Derivaciones - Añadir", Enums.Accion.Insertar, -1, fId, CMDataSet)
        fCambios = True
        _derivaciones.ShowInTaskbar = False
        _derivaciones.ShowDialog()
        InicializaDerivaciones(fDerivacionesIntervalo)
        If dtg_derDerivaciones.Rows.Count > 0 And dtg_derDerivaciones.Rows.Count <> _cantidadInicial Then
            fDerivacionesRowSelected = dtg_derDerivaciones.Rows.Count - 1
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem9.Click
        If dtg_derDerivaciones.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_derDerivaciones.SelectedRows(0).Index
            Dim _Cod As String = dtg_derDerivaciones.SelectedRows(0).Cells("Código").Value.ToString()
            Dim _row As CMDataSet.DERIVACIONESRow = CMDataSet.DERIVACIONES.FindByCODIGO(_Cod)
            _row.Delete()
            fCambios = True

            fDerivacionesRealCount = fDerivacionesRealCount - 1

            If dtg_derDerivaciones.Rows.Count > 0 Then
                If _index <> 0 Then
                    _index = _index - 1
                End If
                fDerivacionesRowSelected = _index
            End If

        End If
    End Sub
    '//YA = DATA SET
    Private Sub BindingNavigatorEditDerivaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditDerivaciones.Click
        If dtg_derDerivaciones.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_derDerivaciones.SelectedRows(0).Index
            Dim _Cod As String = dtg_derDerivaciones.SelectedRows(0).Cells("Código").Value.ToString()
            Dim _derivaciones As form_derivaciones = New form_derivaciones("Derivaciones-Editar", Enums.Accion.Modificar, _Cod, fId, CMDataSet)
            fCambios = True
            _derivaciones.ShowInTaskbar = False
            _derivaciones.ShowDialog()
            InicializaDerivaciones(fDerivacionesIntervalo)
            fDerivacionesRowSelected = _index

        End If
    End Sub

    Private Sub bt_derFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_derFiltrar.Click
        fDerivacionesIntervalo = True
        InicializaDerivaciones(fDerivacionesIntervalo)
    End Sub
    '//YA
    Private Sub dtg_derDerivaciones_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtg_derDerivaciones.Paint
        If dtg_derDerivaciones.Rows.Count > fDerivacionesRealCount Then
            dtg_derDerivaciones.Rows.RemoveAt(dtg_derDerivaciones.Rows.Count - 1)
        End If

        If dtg_derDerivaciones.Rows.Count > 0 Then
            dtg_derDerivaciones.Rows(fDerivacionesRowSelected).Selected = True
        End If
    End Sub

    Private Sub dtg_derDerivaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_derDerivaciones.SelectionChanged
        If dtg_derDerivaciones.SelectedRows.Count > 0 And dtg_derDerivaciones.Rows.Count = fDerivacionesRealCount Then
            fDerivacionesRowSelected = dtg_derDerivaciones.SelectedRows(0).Index
        End If

    End Sub

    Private Sub dtg_derDerivaciones_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_derDerivaciones.CellMouseDoubleClick
        'permiso lectura no deja editar
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Derivaciones) = RoleManager.TipoPermisos.Lectura) Then
            Return
        End If
        BindingNavigatorEditDerivaciones_Click(sender, e)
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

    Private Sub form_derivaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                BindingNavigatorAddNewItem9_Click(sender, e)
            Case Globales.TeclasBasicas.Borrar
                BindingNavigatorDeleteItem9_Click(sender, e)
            Case Globales.TeclasBasicas.Editar
                BindingNavigatorEditDerivaciones_Click(sender, e)
            Case Globales.TeclasBasicas.Filtrar
                Me.bt_derFiltrar_Click(sender, e)
        End Select
    End Sub
   
End Class