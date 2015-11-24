Public Class form_analiticas
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim fIdpac As Integer
    Dim ffacturas As Integer
    Dim fimporte As Single
    Dim fimporteo As Single
    Dim fpac As String
    Dim festado As String
    Dim ffecha As Date
    Dim fnotas As String
    Dim fdescripcion As String
    Dim clickaccept As Boolean = False

    '////////
    Dim fPacienteId As Integer
    Dim fDesdePaciente As Boolean = False

    Dim fCMDataSet As CMDataSet
    '-->////

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

    '/////////////////////////////////////////////////////
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId
        Me.fPacienteId = aPacienteId
        Me.fDesdePaciente = True

        fCMDataSet = aCMDataSet

    End Sub
    '-->/////////////////////////////////////////////////

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

    Private Sub ANALITICASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ANALITICASBindingSource.EndEdit()
        Me.ANALITICASTableAdapter.Update(Me.CMDataSet.ANALITICAS)

    End Sub

    Private Sub Borra()
        Dim i As Integer
        For i = 0 To dgv_disponibles.Columns.Count - 1
            dgv_disponibles.Columns(i).Visible = False
        Next
    End Sub

    Private Sub Agregar(ByVal aRefanalitica As Integer)
        Dim i As Integer
        For i = 0 To dgv_realizar.Rows.Count - 1
            'If dgv_realizar.Rows(i).Cells("Id").Value = -1 Then
            Dim refconcepto As Integer = dgv_realizar.Rows(i).Cells("RefConcepto").Value
            Dim concepto As String = dgv_realizar.Rows(i).Cells("Concepto").Value
            Dim realizado As String = dgv_realizar.Rows(i).Cells("Realizado").Value
            Dim precio As Single = dgv_realizar.Rows(i).Cells("Precio").Value
            Dim _data As CMDataSet.LINEASANALITICASDataTable
            '= LINEASANALITICASTableAdapter.GetLineasByAnaliticas(aRefanalitica)

            If fDesdePaciente Then
                _data = New CMDataSet.LINEASANALITICASDataTable()

                Dim k As Integer
                Dim _expression As String = "REFANALITICA = " + aRefanalitica.ToString()
                Dim _rows() As DataRow = fCMDataSet.LINEASANALITICAS.Select(_expression)
                For k = 0 To _rows.Length - 1
                    _data.ImportRow(_rows(k))
                Next

            Else
                _data = LINEASANALITICASTableAdapter.GetLineasByAnaliticas(aRefanalitica)
            End If

            Dim j As Integer
            Dim insertado As Boolean = False
            Dim id As Integer
            For j = 0 To _data.Rows.Count - 1
                Dim concept As Integer = _data.Rows(j).Item("REFCONCEPTO")

                If refconcepto = concept Then
                    insertado = True
                    id = _data.Rows(j).Item("ID")

                    If fDesdePaciente Then
                        Dim _updRow As CMDataSet.LINEASANALITICASRow = fCMDataSet.LINEASANALITICAS.FindByID(id)
                        _updRow.REFANALITICA() = aRefanalitica
                        _updRow.REFCONCEPTO() = refconcepto
                        _updRow.CONCEPTO() = concepto
                        _updRow.PRECIO() = precio
                        _updRow.RESULTADO() = realizado

                    Else
                        LINEASANALITICASTableAdapter.UpdateById(aRefanalitica, refconcepto, concepto, precio, realizado, id)
                    End If

                End If
            Next
            If insertado = False Then

                If fDesdePaciente Then
                    Dim _newRow As CMDataSet.LINEASANALITICASRow = fCMDataSet.LINEASANALITICAS.NewLINEASANALITICASRow()

                    Dim _rows() As CMDataSet.LINEASANALITICASRow = fCMDataSet.LINEASANALITICAS.Select("", "ID ASC")

                    Dim _maxBD As Integer = 1

                    If Integer.TryParse(LINEASANALITICASTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If


                    Dim _maxDS As Integer = 1

                    If _rows.Length > 0 Then
                        _maxDS = _rows(_rows.Length - 1).ID() + 1
                    End If

                    _newRow.ID() = Math.Max(_maxDS, _maxBD)

                    _newRow.REFANALITICA() = aRefanalitica
                    _newRow.REFCONCEPTO() = refconcepto
                    _newRow.CONCEPTO() = concepto
                    _newRow.PRECIO() = precio
                    _newRow.RESULTADO() = realizado

                    fCMDataSet.LINEASANALITICAS.AddLINEASANALITICASRow(_newRow)

                Else
                    LINEASANALITICASTableAdapter.Insert(aRefanalitica, refconcepto, concepto, precio, realizado)

                End If


            End If

            'End If
        Next

        For i = 0 To dgv_disponibles.Rows.Count - 1
            If dgv_disponibles.Rows(i).Cells("Id").Value <> -1 Then

                Dim _row As CMDataSet.LINEASANALITICASRow = fCMDataSet.LINEASANALITICAS.FindByID(dgv_disponibles.Rows(i).Cells("Id").Value)
                _row.Delete()

            End If
        Next
    End Sub

    Private Sub Inicializa()
        Dim _data As CMDataSet.ANALITICASDataTable

        If fDesdePaciente Then
            _data = New CMDataSet.ANALITICASDataTable()
            _data.ImportRow(fCMDataSet.ANALITICAS.FindByNUMERO(fId))
        Else
            _data = Me.ANALITICASTableAdapter.GetAnaliticaById(fId)
        End If

        If _data.Rows(0).Item("REFPACIENTE").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
            fIdpac = Integer.Parse(_data.Rows(0).Item("REFPACIENTE"))
            fpac = GetPaciente(fIdpac)
            tb_idpaciente.Text = fIdpac.ToString()
            tb_paciente.Text = fpac
        End If
        If _data.Rows(0).Item("IMPORTE").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
            fimporte = Single.Parse(_data.Rows(0).Item("IMPORTE"))
            tb_total.Text = String.Format("{0:N}", (fimporte))
            fimporteo = fimporte
        End If
        fdescripcion = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_descripcion.Text = fdescripcion
        If _data.Rows(0).Item("REFFRA").GetType.ToString() <> DBNull.Value.GetType.ToString() Then


            ffacturas = _data.Rows(0).Item("REFFRA")
            If ffacturas <> 0 Then
                tb_factura.Text = FACTURASTableAdapter.GetFacturaById(ffacturas).Rows(0).Item("NUMERO")
            End If
        End If
        fnotas = _data.Rows(0).Item("NOTAS").ToString()
        tb_notas.Text = fnotas
        ffecha = _data.Rows(0).Item("FECHA")
        dtp_femision.Value = ffecha
        festado = _data.Rows(0).Item("ESTADO").ToString()
        If festado = "S" Then
            chb_estado.Checked = True
        Else
            chb_estado.Checked = False
        End If

        ckRecibida.Checked = If(Not IsDBNull(_data.Rows(0).Item("RECIBIDA")), _data.Rows(0).Item("RECIBIDA"), False)

        Dim _dataf As CMDataSet.LINEASANALITICASDataTable

        If fDesdePaciente Then

            _dataf = New CMDataSet.LINEASANALITICASDataTable()

            Dim k As Integer
            Dim _expression As String = "REFANALITICA = " + fId.ToString()
            Dim _rows() As DataRow = fCMDataSet.LINEASANALITICAS.Select(_expression)
            For k = 0 To _rows.Length - 1
                _dataf.ImportRow(_rows(k))
            Next
        Else
            _dataf = Me.LINEASANALITICASTableAdapter.GetLineasByAnaliticas(fId)

        End If

        Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
        dgv_disponibles.Columns.Add("Concepto", "Concepto")
        dgv_disponibles.Columns.Add("Precio", "Precio")
        dgv_disponibles.Columns("Precio").Visible = False
        dgv_disponibles.Columns.Add("Codigo", "Codigo")
        dgv_disponibles.Columns.Add("Id", "Id")
        dgv_realizar.Columns.Add("Concepto", "Concepto")
        dgv_realizar.Columns.Add("Precio", "Precio")
        dgv_realizar.Columns("Precio").Visible = False
        dgv_realizar.Columns.Add("Realizado", "Realizado")
        dgv_realizar.Columns.Add("RefConcepto", "RefConcepto")
        dgv_realizar.Columns.Add("Id", "Id")
        dgv_disponibles.Rows.Clear()
        dgv_realizar.Rows.Clear()

        Dim id As Integer
        Dim idc As Integer
        Dim idconcepto As Integer
        Dim concepto As String
        Dim conceptoc As String
        Dim precio As Single
        Dim precioc As Single
        Dim resultado As String
        Dim col As String
        Dim i As Integer
        Dim j As Integer

        For j = 0 To _datac.Rows.Count - 1
            idc = _datac.Rows(j).Item("CODIGO")
            conceptoc = _datac.Rows(j).Item("CONCEPTO")
            precioc = _datac.Rows(j).Item("IMPORTE")
            col = _datac.Rows(j).Item("COLOR")
            Dim readcolor As Color = ColorTranslator.FromHtml(col)
            Dim cojido As Boolean = False
            For i = 0 To _dataf.Rows.Count - 1

                idconcepto = _dataf.Rows(i).Item("REFCONCEPTO")
                If idconcepto = idc Then
                    cojido = True
                    id = _dataf.Rows(i).Item("ID")
                    concepto = _dataf.Rows(i).Item("CONCEPTO")
                    precio = _dataf.Rows(i).Item("PRECIO")
                    If _dataf.Rows(i).Item("RESULTADO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                        resultado = _dataf.Rows(i).Item("RESULTADO")
                    End If

                    Dim newrow As New DataGridViewRow
                    newrow.CreateCells(dgv_realizar)
                    newrow.SetValues(concepto, precio, resultado, idconcepto, id)
                    newrow.DefaultCellStyle.BackColor = readcolor
                    dgv_realizar.Rows.Add(newrow)
                End If

            Next
            If cojido = False Then

                Dim newrow As New DataGridViewRow
                newrow.CreateCells(dgv_disponibles)
                newrow.SetValues(conceptoc, precioc, idc, -1)
                newrow.DefaultCellStyle.BackColor = readcolor
                dgv_disponibles.Rows.Add(newrow)
            End If

        Next

        dgv_realizar.Columns("Id").Visible = False
        dgv_realizar.Columns("RefConcepto").Visible = False
        dgv_disponibles.Columns("Codigo").Visible = False
        dgv_disponibles.Columns("Id").Visible = False


    End Sub
    Private Sub filtra(Optional ByVal filtro As String = "")
        Dim _dataf As CMDataSet.LINEASANALITICASDataTable
        Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
        Dim dview As DataView

        If fDesdePaciente Then

            _dataf = New CMDataSet.LINEASANALITICASDataTable()

            Dim k As Integer
            Dim _expression As String = "REFANALITICA = " + fId.ToString()
            Dim _rows() As DataRow = fCMDataSet.LINEASANALITICAS.Select(_expression)
            For k = 0 To _rows.Length - 1
                _dataf.ImportRow(_rows(k))
            Next
        Else
            _dataf = Me.LINEASANALITICASTableAdapter.GetLineasByAnaliticas(fId)

        End If
        dview = _datac.DefaultView
        dview.RowFilter = "Concepto like '" & filtro & "%'"

        dgv_disponibles.Rows.Clear()

        Dim idc As Integer
        Dim conceptoc As String
        Dim precioc As Single
        Dim i As Integer
        Dim j As Integer

        For j = 0 To dview.Count - 1
            idc = dview(j).Item("CODIGO")
            conceptoc = dview(j).Item("CONCEPTO")
            precioc = dview(j).Item("IMPORTE")
            Dim cojido As Boolean = False

            For i = 0 To Me.dgv_realizar.Rows.Count - 1
                If dgv_realizar.Rows(i).Cells.Item("Concepto").Value = conceptoc.Trim Then
                    cojido = True
                End If
            Next
            If cojido = False Then
                dgv_disponibles.Rows.Add(conceptoc, precioc, idc, -1)
            End If
        Next

        dgv_disponibles.Columns("Codigo").Visible = False
        dgv_disponibles.Columns("Id").Visible = False
    End Sub
    Private Sub GetConceptos()

        If Me.CurrentAccion = Enums.Accion.Insertar Then

            Me.dgv_disponibles.Rows.Clear()

            dgv_disponibles.Columns.Add("Concepto", "Concepto")
            dgv_disponibles.Columns.Add("Precio", "Precio")
            dgv_disponibles.Columns("Precio").Visible = False
            dgv_disponibles.Columns.Add("Codigo", "Codigo")
            dgv_disponibles.Columns.Add("Id", "Id")
            Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)
            Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
            Dim idc As Integer
            Dim conceptoc As String
            Dim precioc As Single
            Dim j As Integer
            Dim dview As DataView
            dview = _datac.DefaultView

            For j = 0 To _datac.Rows.Count - 1
                idc = dview.Table.Rows(j).Item("CODIGO")
                conceptoc = dview.Table.Rows(j).Item("CONCEPTO")
                precioc = dview.Table.Rows(j).Item("IMPORTE")
                dgv_disponibles.Rows.Add(conceptoc, precioc, idc, -1)
            Next

            dgv_disponibles.Columns("Codigo").Visible = False
            dgv_disponibles.Columns("Id").Visible = False
            dgv_realizar.Columns.Add("Concepto", "Concepto")
            dgv_realizar.Columns.Add("Precio", "Precio")
            dgv_realizar.Columns("Precio").Visible = False
            dgv_realizar.Columns.Add("Realizado", "Realizado")
            dgv_realizar.Columns.Add("RefConcepto", "RefConcepto")
            dgv_realizar.Columns.Add("Id", "Id")
            dgv_realizar.Columns("RefConcepto").Visible = False
            dgv_realizar.Columns("Id").Visible = False

            Dim p As Integer

            For p = 0 To _datac.Rows.Count - 1
                Dim col As String = _datac.Rows(p).Item("COLOR")
                Dim readcolor As Color = ColorTranslator.FromHtml(col)
                dgv_disponibles.Rows(p).DefaultCellStyle.BackColor = readcolor
            Next

        End If
    End Sub

    Private Sub form_analiticas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim res As DialogResult = DialogResult
        If res = Windows.Forms.DialogResult.Cancel Then
            Dim res2 As MsgBoxResult = MsgBox("Si continua y no ha guardado los cambios, los perderá.  ¿Seguro que desea continuar?", MsgBoxStyle.YesNo)
            If res2 = MsgBoxResult.No Then e.Cancel = True
        End If

    End Sub

    

    Private Sub form_analiticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '/////////////////////////////////////
        If fDesdePaciente = True Then

            tb_idpaciente.Text = fPacienteId
            tb_paciente.Text = GetPaciente(fPacienteId)


            tb_idpaciente.Enabled = False
            tb_paciente.Enabled = False
            bt_paciente.Enabled = False


        End If
        '-->/////////////////////////////////////
        If Me.CurrentAccion = Enums.Accion.Modificar Then

            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            Dim i As Integer
            For i = 0 To Me.Controls.Count - 1
                Me.Controls(i).Enabled = False
            Next

            bt_aceptar.Hide()
            bt_cancel.Enabled = True
            bt_imprimir.Enabled = True
            bt_cancel.Text = "Cerrar"

        End If
        GetConceptos()
        dgv_disponibles.Columns("Concepto").SortMode() = DataGridViewColumnSortMode.Automatic
        dgv_realizar.Columns(0).SortMode() = DataGridViewColumnSortMode.Automatic

    End Sub

    Private Function GetPaciente(ByVal aId As Integer) As String

        'Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)

        Dim _data As CMDataSet.PACIENTESDataTable

        If fDesdePaciente Then
            _data = New CMDataSet.PACIENTESDataTable()
            _data.ImportRow(fCMDataSet.PACIENTES.FindByCPACIENTE(aId))
        Else
            _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        End If

        Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
        Return _paciente

    End Function

    Private Sub bt_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_paciente.Click
        Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
        Dim _name As String = "Listado de pacientes"
        Dim _listados As form_listados = New form_listados(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_idpaciente.Text = _pcodo.ToString()
            tb_paciente.Text = GetPaciente(_pcodo)
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_izq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_izq.Click
        Dim i As Integer
        For i = 0 To dgv_disponibles.SelectedRows.Count - 1
            Dim concepto As String
            Dim Col As System.Drawing.Color
            Dim importe As Single
            Dim id As Integer
            Col = dgv_disponibles.SelectedRows(i).DefaultCellStyle.BackColor
            concepto = dgv_disponibles.SelectedRows(i).Cells("Concepto").Value
            importe = dgv_disponibles.SelectedRows(i).Cells("Precio").Value
            id = dgv_disponibles.SelectedRows(i).Cells("Codigo").Value

            Dim newrow As New DataGridViewRow
            newrow.CreateCells(dgv_realizar)
            newrow.SetValues(concepto, importe, "", id, -1)
            newrow.DefaultCellStyle.BackColor = Col
            dgv_realizar.Rows.Add(newrow)

            dgv_disponibles.Rows.RemoveAt(dgv_disponibles.SelectedRows(i).Index())
            fimporte = fimporte + importe
            tb_total.Text = fimporte.ToString()

        Next
        dgv_realizar.CurrentCell = dgv_realizar.Rows(dgv_realizar.Rows.Count - 1).Cells(0)
    End Sub

    Private Sub bt_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_der.Click
        Dim i As Integer
        For i = 0 To dgv_realizar.SelectedRows.Count - 1
            Dim concepto As String
            Dim Col As System.Drawing.Color
            Dim importe As Single
            Dim id As Integer
            Dim ida As Integer
            Col = dgv_realizar.SelectedRows(i).DefaultCellStyle.BackColor
            concepto = dgv_realizar.SelectedRows(i).Cells("Concepto").Value
            importe = dgv_realizar.SelectedRows(i).Cells("Precio").Value
            id = dgv_realizar.SelectedRows(i).Cells("RefConcepto").Value
            ida = dgv_realizar.SelectedRows(i).Cells("Id").Value

            Dim newrow As New DataGridViewRow
            newrow.CreateCells(dgv_disponibles)
            newrow.SetValues(concepto, importe, id, ida)
            newrow.DefaultCellStyle.BackColor = Col
            dgv_disponibles.Rows.Add(newrow)

            dgv_realizar.Rows.RemoveAt(dgv_realizar.SelectedRows(i).Index())
            fimporte = fimporte - importe
            tb_total.Text = fimporte.ToString()

        Next
        dgv_disponibles.CurrentCell = dgv_disponibles.Rows(dgv_disponibles.Rows.Count - 1).Cells(0)
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim _Idpac As Integer
        If tb_idpaciente.Text <> "" Then
            _Idpac = Integer.Parse(tb_idpaciente.Text.Trim())
        Else : _Idpac = 0
        End If
        Dim _pac As String = tb_paciente.Text
        Dim _estado As String
        If chb_estado.Checked = True Then
            _estado = "S"
        Else
            _estado = "N"
        End If
        Dim _recibida As Boolean
        _recibida = ckRecibida.Checked



        Dim _fecha As Date = dtp_femision.Value
        Dim _notas As String = tb_notas.Text
        Dim _descripcion As String = tb_descripcion.Text
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            If _Idpac <> 0 Then

                If fDesdePaciente Then
                    Dim _updRow As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.FindByNUMERO(fId)

                    _updRow.DESCRIPCION() = _descripcion
                    _updRow.IMPORTE() = fimporte
                    _updRow.REFPACIENTE() = _Idpac
                    _updRow.PACIENTE() = _pac
                    _updRow.ESTADO() = _estado
                    _updRow.FECHA() = _fecha
                    _updRow.NOTAS() = _notas
                    _updRow.REFFRA() = ffacturas
                    _updRow.RECIBIDA() = _recibida


                Else
                    ANALITICASTableAdapter.UpdateValores(_descripcion, fimporte, _Idpac, _pac, _estado, _fecha, _notas, ffacturas, _recibida, fId)
                End If

            Else

                If fDesdePaciente Then
                    Dim _updRow As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.FindByNUMERO(fId)

                    _updRow.DESCRIPCION() = _descripcion
                    _updRow.IMPORTE() = fimporte
                    _updRow.ESTADO() = _estado
                    _updRow.FECHA() = _fecha
                    _updRow.NOTAS() = _notas
                    _updRow.REFFRA() = ffacturas
                    _updRow.RECIBIDA() = _recibida

                Else
                    ANALITICASTableAdapter.UpdateSinPac(_descripcion, fimporte, _estado, _fecha, _notas, ffacturas, _recibida, fId)
                End If

            End If
            Agregar(fId)

        ElseIf Me.CurrentAccion = Enums.Accion.Insertar Then
            If _Idpac <> 0 Then

                If fDesdePaciente Then
                    Dim _newRow As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.NewANALITICASRow()

                    Dim _rows() As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.Select("", "NUMERO ASC")

                    Dim _maxBD As Integer = 1

                    If Integer.TryParse(ANALITICASTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If


                    Dim _maxDS As Integer = 1

                    If _rows.Length > 0 Then
                        _maxDS = _rows(_rows.Length - 1).NUMERO() + 1
                    End If

                    ' Dim ultimoId As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "SELECT ident_current('Analiticas')")


                    _newRow.NUMERO() = _maxBD 'Math.Max(_maxDS, _maxBD)

                    _newRow.DESCRIPCION() = _descripcion
                    _newRow.IMPORTE() = fimporte
                    _newRow.REFPACIENTE() = _Idpac
                    _newRow.PACIENTE() = _pac
                    _newRow.ESTADO() = _estado
                    _newRow.FECHA() = _fecha
                    _newRow.NOTAS() = _notas
                    _newRow.REFFRA() = ffacturas
                    _newRow.RECIBIDA() = _recibida

                    fCMDataSet.ANALITICAS.AddANALITICASRow(_newRow)
                Else
                    ANALITICASTableAdapter.Insert(_descripcion, fimporte, _Idpac, _pac, _estado, _fecha, _notas, ffacturas, Nothing, _recibida)
                End If

            Else

                If fDesdePaciente Then
                    Dim _newRow As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.NewANALITICASRow()

                    Dim _rows() As CMDataSet.ANALITICASRow = fCMDataSet.ANALITICAS.Select("", "NUMERO ASC")

                    Dim _maxBD As Integer = 1

                    If Integer.TryParse(ANALITICASTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If


                    Dim _maxDS As Integer = 1

                    If _rows.Length > 0 Then
                        _maxDS = _rows(_rows.Length - 1).NUMERO() + 1
                    End If

                    _newRow.NUMERO() = _maxBD 'Math.Max(_maxDS, _maxBD)

                    _newRow.DESCRIPCION() = _descripcion
                    _newRow.IMPORTE() = fimporte
                    _newRow.ESTADO() = _estado
                    _newRow.FECHA() = _fecha
                    _newRow.NOTAS() = _notas
                    _newRow.REFFRA() = ffacturas
                    _newRow.RECIBIDA() = _recibida

                    fCMDataSet.ANALITICAS.AddANALITICASRow(_newRow)
                Else
                    ANALITICASTableAdapter.InsertSinPac(_descripcion, fimporte, _estado, _fecha, _notas, ffacturas)
                End If

            End If

            Dim _anal As Integer

            If fDesdePaciente Then
                _anal = fCMDataSet.ANALITICAS.Rows(fCMDataSet.ANALITICAS.Rows.Count - 1).Item("NUMERO")
            Else
                ANALITICASTableAdapter.Fill(CMDataSet.ANALITICAS)
                _anal = ANALITICASTableAdapter.GetData().Rows(ANALITICASTableAdapter.GetData().Rows.Count - 1).Item("NUMERO")
            End If

            Agregar(_anal)
        End If
        Globales.CobroEnCascada(, , fId)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_copiar.Click
        Me.PLANTILLAANALITICASTableAdapter.Fill(Me.CMDataSet.PLANTILLAANALITICAS)
        Dim _name As String = "Listado de plantillas de analiticas"
        Dim _listados As form_listados = New form_listados(_name, PLANTILLAANALITICASBindingSource, RoleManager.Items.Plantillas_para_Analiticas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            dgv_disponibles.Columns.Clear()
            dgv_realizar.Columns.Clear()

            Dim _pcodo As String = _listados.Selected()
            Dim DPLANTANA As CMDataSet.PLANTILLAANALITICASDataTable = Me.PLANTILLAANALITICASTableAdapter.GetDataPlantillaAnaliticas("PLANTILLAANALITICAS", "WHERE CODIGO='" & _pcodo & "'", "")
            If DPLANTANA.Rows.Count > 0 Then
                If Not DPLANTANA.Rows(0).Item("Descripcion").GetType Is GetType(DBNull) Then
                    Me.tb_descripcion.Text = DPLANTANA.Rows(0).Item("Descripcion").trim
                End If
            End If
            Dim _dataf As CMDataSet.LPLANTILLAANALITICASDataTable = Me.LPLANTILLAANALITICASTableAdapter.GetLPlantillaByPlantilla(_pcodo)
            Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
            dgv_disponibles.Columns.Add("Concepto", "Concepto")
            dgv_disponibles.Columns.Add("Precio", "Precio")

            dgv_disponibles.Columns.Add("Codigo", "Codigo")
            dgv_disponibles.Columns.Add("Id", "Id")
            dgv_realizar.Columns.Add("Concepto", "Concepto")
            dgv_realizar.Columns.Add("Precio", "Precio")

            dgv_realizar.Columns.Add("Realizado", "Realizado")
            dgv_realizar.Columns.Add("RefConcepto", "RefConcepto")

            dgv_realizar.Columns.Add("Id", "Id")

            dgv_disponibles.Rows.Clear()
            dgv_realizar.Rows.Clear()


            Dim idc As Integer
            Dim idconcepto As Integer
            Dim concepto As String
            Dim conceptoc As String
            Dim precio As Single
            Dim precioc As Single
            Dim i As Integer
            Dim j As Integer
            fimporte = 0
            For j = 0 To _datac.Rows.Count - 1
                idc = _datac.Rows(j).Item("CODIGO")
                conceptoc = _datac.Rows(j).Item("CONCEPTO")
                precioc = _datac.Rows(j).Item("IMPORTE")
                Dim cojido As Boolean = False
                For i = 0 To _dataf.Rows.Count - 1

                    idconcepto = Integer.Parse(_dataf.Rows(i).Item("REFCONCEPTO"))
                    If idconcepto = idc Then
                        cojido = True
                        concepto = CONCEPTOSANALITICATableAdapter.GetConceptosAnaliticaById(idconcepto).Rows(0).Item("CONCEPTO")
                        precio = _dataf.Rows(i).Item("PRECIO")
                        dgv_realizar.Rows.Add(concepto, precio, "", idconcepto, -1)
                        fimporte = fimporte + precio
                        tb_total.Text = fimporte
                    End If

                Next
                If cojido = False Then
                    dgv_disponibles.Rows.Add(conceptoc, precioc, idc, -1)
                End If

            Next

            dgv_realizar.Columns("Id").Visible = False
            dgv_realizar.Columns("RefConcepto").Visible = False
            dgv_realizar.Columns("Precio").Visible = False

            dgv_disponibles.Columns("Precio").Visible = False
            dgv_disponibles.Columns("Codigo").Visible = False
            dgv_disponibles.Columns("Id").Visible = False
        End If


    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click

        'Dim rpt2 As New Microsoft.Reporting.WinForms.ReportDataSource
        'Dim _analitica As New CMDataSet.ANALITICASDataTable
        'Dim _lineasanalitica As New CMDataSet.LINEASANALITICASDataTable

        'bt_aceptar_Click(Nothing, Nothing)

        ''   _analitica = Me.ANALITICASTableAdapter.GetAnaliticaById(Me.fId)
        ''   _lineasanalitica = Me.LINEASANALITICASTableAdapter.GetLineasByAnaliticas(Me.fId)

        'rpt.Name = "CMDataSet_ANALITICAS"
        'rpt.Value = Me.ANALITICASBindingSource
        'rpt2.Name = "CMDataSet_LINEASANALITICAS"
        'rpt2.Value = Me.LINEASANALITICASBindingSource

        'Dim _print As New form_ReporteGenerico(rpt, fichero, "Analítica")
        '_print.ReportViewer.LocalReport.DataSources.Add(rpt2)

        '_print.ShowInTaskbar = False
        '_print.ReportViewer.RefreshReport()
        '_print.ShowDialog()
    End Sub

    Private Sub dgv_realizar_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_realizar.CellDoubleClick
        If dgv_realizar.SelectedRows.Count > 0 Then
            Dim _result As New form_analresult()
            _result.ShowInTaskbar = False
            _result._result = dgv_realizar.SelectedRows(0).Cells("Realizado").Value
            If _result.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgv_realizar.SelectedRows(0).Cells("Realizado").Value = _result._result
            End If
        End If
    End Sub

    Private Sub dgv_disponibles_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_disponibles.CellDoubleClick
        bt_izq_Click(sender, e)
    End Sub

    Private Sub tb_idpaciente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idpaciente.Leave
        If tb_idpaciente.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_idpaciente.Text)
            Dim data As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_pcodo)
            If data.Rows.Count > 0 Then
                tb_paciente.Text = GetPaciente(_pcodo)
            Else
                tb_idpaciente.Text = ""
                tb_idpaciente.Focus()
                MessageBox.Show("No existe un paciente con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub tb_buscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyUp
        filtra(Me.tb_buscar.Text.Trim)
    End Sub


End Class