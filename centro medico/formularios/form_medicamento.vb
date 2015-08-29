Imports Microsoft.ApplicationBlocks.Data

Public Class form_medicamento
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fposologiao As String
    Dim fcantidado As String
    Dim fdescripciono As String
    Dim ffavoritoo As String
    Dim findicaciono As String


    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId


    End Sub
    Public Property CurrentAccion() As Enums.Accion

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fcurrentAcc

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Enums.Accion)
            fcurrentAcc = Value
        End Set
    End Property

    Private Sub Inicializa()
        cb_indicaciones.Items.Clear()
        Dim _data As CMDataSet.MEDICAMENTOSDataTable = Me.MEDICAMENTOSTableAdapter.GetMedicamentoById(fId)
        fposologiao = _data.Rows(0).Item("POSOLOGIA").ToString()
        fcantidado = _data.Rows(0).Item("CANTIDADES").ToString()
        ffavoritoo = _data.Rows(0).Item("FAVORITOS").ToString()
        findicaciono = _data.Rows(0).Item("INDICACION").ToString()
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_cod.Text = fId.ToString()
        tb_posologia.Text = fposologiao
        tb_cantidades.Text = fcantidado
        cb_indicaciones.Text = findicaciono
        tb_descripc.Text = fdescripciono.ToString()
        If ffavoritoo = "N" Then
            chb_fav.Checked = False
        Else
            chb_fav.Checked = True
        End If

        Dim _dataa As CMDataSet.LINEASALARMAMDataTable = Me.LINEASALARMAMTableAdapter.GetAlarmaByMedicamento(fId)
        Dim _datai As CMDataSet.LINEASINDICACIONESDataTable = Me.LINEASINDICACIONESTableAdapter.GetIndicacionByMedicamento(fId)
        Dim i As Integer
        Dim id As Integer

        For i = 0 To _dataa.Rows.Count - 1
            id = _dataa.Rows(i).Item("REFALARMA")
            Dim _dataalarm As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(id)
            If _dataalarm.Rows.Count > 0 Then
                Dim alarma As String = _dataalarm.Rows(0).Item("ALARMA").ToString()
                Dim niv As String = _dataalarm.Rows(0).Item("NIVEL").ToString()
                Dim desc As String = _dataalarm.Rows(0).Item("DESCRIPCION").ToString()
                Dim nivel As String
                If niv = "B" Then
                    nivel = "Baja"
                ElseIf niv = "M" Then
                    nivel = "Media"
                Else : nivel = "Alta"
                End If
                Dim cod As Integer = _dataalarm.Rows(0).Item("CALARMA")
                dgv_alarmas.Rows.Add(alarma, nivel, cod, desc)
            End If

        Next
        For i = 0 To _datai.Rows.Count - 1
            id = _datai.Rows(i).Item("REFINDICACION")
            Dim _dataind As CMDataSet.INDICACIONESDataTable = Me.INDICACIONESTableAdapter.GetIndicacionById(id)
            If _dataind.Rows.Count > 0 Then
                Dim cod As Integer = _dataind.Rows(0).Item("CINDICACIONES")
                Dim nombre As String = _dataind.Rows(0).Item("NOMBRE").ToString()
                Dim text As String = _dataind.Rows(0).Item("TEXTO").ToString()
                dgv_indicaciones.Rows.Add(cod, nombre, text)
                cb_indicaciones.Items.Add(nombre)
            End If

        Next
    End Sub
    Private Sub MEDICAMENTOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MEDICAMENTOSBindingSource.EndEdit()
        Me.MEDICAMENTOSTableAdapter.Update(Me.CMDataSet.MEDICAMENTOS)

    End Sub

    Private Sub form_medicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv_alarmas.Columns.Add("Alarma", "Alarma")
        dgv_alarmas.Columns.Add("N", "N")
        dgv_alarmas.Columns.Add("Codigo", "Codigo")
        dgv_alarmas.Columns.Add("Descripcion", "Descripcion")
        dgv_indicaciones.Columns.Add("Cod", "Cod")
        dgv_indicaciones.Columns.Add("Indicaciones", "Indicaciones")
        dgv_indicaciones.Columns.Add("Texto", "Texto")
        dgv_indicaciones.Columns("Texto").Visible = False
        dgv_alarmas.Columns("Codigo").Visible = False
        dgv_alarmas.Columns("Descripcion").Visible = False
        dgv_alarmas.Rows.Clear()
        dgv_indicaciones.Rows.Clear()

        If Me.CurrentAccion = Enums.Accion.Insertar Then
            tb_cod.Text = GeneraNuevoCodigo()
        End If

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_cod.ReadOnly = True
            tb_descripc.ReadOnly = True
            tb_posologia.ReadOnly = True
            tb_cantidades.ReadOnly = True
            cb_indicaciones.Enabled = False
            chb_fav.Enabled = False

            bt_aceptar.Hide()
            bt_agregar.Enabled = False
            bt_quitar.Enabled = False
            bt_add.Enabled = False
            bt_delete.Enabled = False
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_medicamento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String
            If tb_cod.Text <> "" Then
                _cod = tb_cod.Text.Trim()
            End If
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _fav As String
            Dim _posologia As String = tb_posologia.Text.Trim()
            Dim _cantidad As String = tb_cantidades.Text.Trim()
            Dim _indicacion As String = cb_indicaciones.Text.Trim()
            If (chb_fav.Checked) Then
                _fav = "S"
            Else : _fav = "N"
            End If
            If _cod.ToString() <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.MEDICAMENTOSTableAdapter.UpdateValores(_cod, _descripcion, _posologia, _cantidad, _indicacion, _fav, fId)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Medicamentos, "Medicamento", _cod.ToString.Trim, "Se ha modificado un medicamento")
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.MEDICAMENTOSTableAdapter.Insert(_cod, _descripcion, _posologia, _cantidad, _indicacion, _fav)
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Medicamentos, "Medicamento", _cod.ToString.Trim, "Se ha insertado un nuevo medicamento")
                    End If
                End If
                Me.MEDICAMENTOSTableAdapter.Fill(CMDataSet.MEDICAMENTOS)
                Agregar()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String
            If tb_cod.Text <> "" Then
                _cod = tb_cod.Text.Trim()
            End If
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _fav As String
            Dim _posologia As String = tb_posologia.Text.Trim()
            Dim _cantidad As String = tb_cantidades.Text.Trim()
            Dim _indicacion As String = cb_indicaciones.Text.Trim()
            If (chb_fav.Checked) Then
                _fav = "S"
            Else : _fav = "N"
            End If
            If _cod.ToString() <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    Me.MEDICAMENTOSTableAdapter.UpdateValores(_cod, _descripcion, _posologia, _cantidad, _indicacion, _fav, fId)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Medicamentos, "Medicamento", _cod.ToString.Trim, "Se ha modificado un medicamento")
                Else
                    Me.MEDICAMENTOSTableAdapter.Insert(_cod, _descripcion, _posologia, _cantidad, _indicacion, _fav)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Medicamentos, "Medicamento", _cod.ToString.Trim, "Se ha insertado un nuevo medicamento")
                End If
                Me.MEDICAMENTOSTableAdapter.Fill(CMDataSet.MEDICAMENTOS)
                clickaccept = True
                Agregar()
                Me.Close()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#Region "Private Function MaximoCodigoNumerico() As Integer"
    Private Function MaximoCodigoNumerico() As Integer
        Dim query As String = "SELECT  MAX(CAST(CMEDICAMENTO AS Int)) AS Expr1 FROM MEDICAMENTOS WHERE  (IsNumeric(CMEDICAMENTO) = 1)"
        Dim res As Object = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, query)
        If res Is DBNull.Value Then
            Return 0
        Else
            Return res
        End If
    End Function
#End Region


    Private Function ExisteCodigoMedicamento(ByVal codigo As String)
        Dim query As String = "SELECT CMEDICAMENTO FROM MEDICAMENTOS WHERE (CMEDICAMENTO = @CMEDICAMENTO)"
        Dim param As New SqlClient.SqlParameter("@CMEDICAMENTO", SqlDbType.NVarChar)
        param.Value = codigo
        Dim res As Object = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, query, New SqlClient.SqlParameter() {param})
        If res Is DBNull.Value Or res Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GeneraNuevoCodigo() As String
        'Primero ver si es posible generar el codigo con numeros
        Dim codigo As String
        Dim n As Integer = MaximoCodigoNumerico()
        If n < 99999 Then
            codigo = (n + 1).ToString()
        Else
            'Este caso es para cuando hay un 99999 ya en la BD
            'generaremos codigos con A

            For Each letter As Char In New Char() {"A", "B", "C", "D", "F"}
                Dim i As Integer = 0
                Do
                    codigo = letter & ("0000".Substring(0, "0000".Length - i.ToString().Length)) & i.ToString()
                    i = i + 1
                Loop Until Not ExisteCodigoMedicamento(codigo)
                Return codigo
            Next

        End If
        Return codigo
    End Function

    Private Sub Agregar()
        LINEASALARMAMTableAdapter.DeleteByMed(fId)
        LINEASINDICACIONESTableAdapter.DeleteByMed(fId)
        Dim i As Integer
        For i = 0 To dgv_indicaciones.Rows.Count - 1
            Dim cod As Integer = dgv_indicaciones.Rows(i).Cells("Cod").Value
            Dim text As String = dgv_indicaciones.Rows(i).Cells("Texto").Value
            LINEASINDICACIONESTableAdapter.Insert(fId, cod, text)

        Next
        For i = 0 To dgv_alarmas.Rows.Count - 1
            Dim cod As Integer = dgv_alarmas.Rows(i).Cells("Codigo").Value
            Dim text As String = dgv_alarmas.Rows(i).Cells("Descripcion").Value
            LINEASALARMAMTableAdapter.Insert(fId, cod, text)

        Next

    End Sub
    Private Sub bt_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_quitar.Click
        Dim i As Integer
        For i = 0 To dgv_alarmas.SelectedRows.Count - 1
            dgv_alarmas.Rows.RemoveAt(dgv_alarmas.SelectedRows(i).Index())
        Next
    End Sub

    Private Sub bt_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_delete.Click
        Dim i As Integer
        For i = 0 To dgv_indicaciones.SelectedRows.Count - 1
            If cb_indicaciones.Items.Contains(dgv_indicaciones.SelectedRows(i).Cells("Indicaciones").Value) Then
                cb_indicaciones.Items.Remove(dgv_indicaciones.SelectedRows(i).Cells("Indicaciones").Value)
            End If
            dgv_indicaciones.Rows.RemoveAt(dgv_indicaciones.SelectedRows(i).Index())

        Next
    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click


        Me.ALARMASTableAdapter.Fill(Me.CMDataSet.ALARMAS)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, ALARMASBindingSource, RoleManager.Items.Alarmas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            Dim niv As String = GetNivel(_pcodo)
            Dim alarma As String = GetAlarma(_pcodo)
            Dim descripcion As String = GetDescripcion(_pcodo)
            dgv_alarmas.Rows.Add(alarma, niv, _pcodo, descripcion)
        End If

    End Sub
    Private Function GetNivel(ByVal acod As Integer) As String
        Dim nivel As String = ""
        Dim _dataalarm As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(acod)
        If _dataalarm.Rows.Count > 0 Then
            Dim niv As String = _dataalarm.Rows(0).Item("NIVEL").ToString()
            If niv = "B" Then
                nivel = "Baja"
            ElseIf niv = "M" Then
                nivel = "Media"
            Else : nivel = "Alta"
            End If
        End If
        Return nivel
    End Function
    Private Function GetAlarma(ByVal acod As Integer) As String
        Dim alarma As String = ""
        Dim _dataalarm As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(acod)
        If _dataalarm.Rows.Count > 0 Then
            alarma = _dataalarm.Rows(0).Item("ALARMA").ToString()

        End If
        Return alarma
    End Function
    Private Function GetTexto(ByVal acod As Integer) As String
        Dim texto As String = ""
        Dim _dataind As CMDataSet.INDICACIONESDataTable = Me.INDICACIONESTableAdapter.GetIndicacionById(acod)
        If _dataind.Rows.Count > 0 Then
            texto = _dataind.Rows(0).Item("TEXTO").ToString()

        End If
        Return texto
    End Function
    Private Function GetNombre(ByVal acod As Integer) As String
        Dim nombre As String = ""
        Dim _dataind As CMDataSet.INDICACIONESDataTable = Me.INDICACIONESTableAdapter.GetIndicacionById(acod)
        If _dataind.Rows.Count > 0 Then
            nombre = _dataind.Rows(0).Item("NOMBRE").ToString()

        End If
        Return nombre
    End Function
    Private Function GetDescripcion(ByVal acod As Integer) As String
        Dim desc As String = ""
        Dim _dataalarm As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(acod)
        If _dataalarm.Rows.Count > 0 Then
            desc = _dataalarm.Rows(0).Item("DESCRIPCION").ToString()
        End If
        Return desc
    End Function
    'Falta poner a funcionar estos metodos y hacer 


    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click


        Me.INDICACIONESTableAdapter.Fill(Me.CMDataSet.INDICACIONES)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, INDICACIONESBindingSource, RoleManager.Items.Indicaciones, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            Dim nombre As String = GetNombre(_pcodo)
            Dim texto As String = GetTexto(_pcodo)
            dgv_indicaciones.Rows.Add(_pcodo, nombre, texto)
            cb_indicaciones.Items.Add(nombre)
        End If
    End Sub

    Private Sub dgv_indicaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_indicaciones.SelectionChanged
        If dgv_indicaciones.Rows.Count() > 0 And dgv_indicaciones.SelectedRows.Count > 0 Then
            tb_indicaciones.Text = dgv_indicaciones.SelectedRows(0).Cells("Texto").Value.ToString()
        End If
    End Sub

    Private Sub dgv_alarmas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_alarmas.SelectionChanged
        If dgv_alarmas.Rows.Count() > 0 And dgv_alarmas.SelectedRows.Count > 0 Then
            tb_alarmas.Text = dgv_alarmas.SelectedRows(0).Cells("Descripcion").Value.ToString()
        End If
    End Sub

    Private Sub lblFichaTecnica_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblFichaTecnica.LinkClicked
        Dim tabla As DataTable = Globales.ObtenerMedicamentos(Me.tb_descripc.Text.Trim)
        If Not tabla Is Nothing Then
            Me.DataGridView1.DataSource = tabla
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim a As Object
        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
            Dim iniciar As New ProcessStartInfo(Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            Process.Start(iniciar)
        End If
        a = e
    End Sub
End Class