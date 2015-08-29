Public Class form_conceptos_facturables
    Dim fcurrentAcc As Integer
    Public fId As String
    Dim clickaccept As Boolean = False
    Dim fcodo As String
    Dim fdescripo As String
    Dim fimporteo As String

    '/////////////////////////////////////////////
    Dim fPacienteId As Integer = 0
    Dim fConFacturableId As Integer = 0
    Dim fDesdePaciente As Boolean = False

    Dim fCMDataSet As CMDataSet
    '-->//////////////////////////////////////////


    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName



    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId



    End Sub

    '/////////////////////////////////////////////////
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String, ByVal aPacienteId As Integer, ByVal aConFacturableId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId

        fDesdePaciente = True

        fPacienteId = aPacienteId
        fConFacturableId = aConFacturableId
        bt_BuscarCodigo.Visible = True


        fCMDataSet = aCMDataSet

    End Sub
    '-->//////////////////////////////////////////////


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

        If fDesdePaciente = True Then
            'Dim _data As CMDataSet.CONCEPTOSFACTURABLESDataTable = Me.CONCEPTOSFACTURABLESTableAdapter.GetConceptosFacturablesById(fConFacturableId)

            Dim _data As CMDataSet.CONCEPTOSFACTURABLESDataTable = New CMDataSet.CONCEPTOSFACTURABLESDataTable()

            _data.ImportRow(fCMDataSet.CONCEPTOSFACTURABLES.FindByID(fConFacturableId))

            fcodo = _data.Rows(0).Item("REFCONCEPTO").ToString()
            fdescripo = _data.Rows(0).Item("DESCRIPCION").ToString()
            fimporteo = _data.Rows(0).Item("IMPORTE").ToString()
        Else
            Dim _data As CMDataSet.CONCEPTOSFRADataTable = Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(fId)
            fcodo = _data.Rows(0).Item("CODIGO").ToString()
            fdescripo = _data.Rows(0).Item("DESCRIPCION").ToString()
            fimporteo = _data.Rows(0).Item("IMPORTE").ToString()
            If Not _data(0).IsDuracionNull Then
                txtDuracion.Text = _data(0).Duracion.ToShortTimeString()
            End If
        End If
        tb_cod.Text = fcodo
        tb_descrip.Text = fdescripo
        tb_importe.Text = String.Format("{0:N}", (fimporteo))

    End Sub
    Private Sub form_conceptos_facturables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
            tb_cod.Enabled = False
            If fDesdePaciente = True Then
                bt_BuscarCodigo.Enabled = False
            End If
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_cod.ReadOnly = True
            tb_descrip.ReadOnly = True
            tb_importe.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
        CtrlFamilia1.Categorias = ctrlFamilia.MostrarCategorias.Regulares
        Try
            Dim context As New CMLinqDataContext()
            Dim concepto As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = fId Select c).SingleOrDefault()
            CtrlFamilia1.ID_CONCEPTOFAMILIA = concepto.IDFAMILIA
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub form_conceptos_facturables_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim durac As Date = New Date(2000, 1, 1, 0, 0, 0)

        Try
            durac = Date.Parse(txtDuracion.Text)
        Catch ex As Exception
        End Try

        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _cod As String = tb_cod.Text.Trim()
            Dim _descrip As String = tb_descrip.Text.Trim()
            Dim _importe As String = tb_importe.Text.Trim()
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If fDesdePaciente = True Then
                        'Me.CONCEPTOSFACTURABLESTableAdapter.UpdateValores(fPacienteId, _cod, _descrip, _importe, fConFacturableId)

                        Dim _updRow As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.FindByID(fConFacturableId)

                        _updRow.REFPACIENTE() = fPacienteId
                        _updRow.REFCONCEPTO() = _cod
                        _updRow.DESCRIPCION() = _descrip
                        _updRow.IMPORTE() = _importe

                    Else
                        Me.CONCEPTOSFRATableAdapter.UpdateValores(_cod, _descrip, _importe, durac, fcodo)
                        Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)

                    End If
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If fDesdePaciente = True Then
                        'Me.CONCEPTOSFACTURABLESTableAdapter.InsertNuevo(fPacienteId, _cod, _descrip, _importe)

                        Dim _newRow As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.NewCONCEPTOSFACTURABLESRow()

                        Dim _rows() As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.Select("", " ASC")

                        Dim _maxBD As Integer = 1
                        If CONCEPTOSFACTURABLESTableAdapter.MaximoId.HasValue Then
                            If Integer.TryParse(CONCEPTOSFACTURABLESTableAdapter.MaximoId(), _maxBD) Then
                                _maxBD = _maxBD + 1
                            End If
                        End If

                        Dim _maxDS As Integer = 1

                        If _rows.Length > 0 Then
                            _maxDS = _rows(_rows.Length - 1).ID() + 1
                        End If

                        _newRow.ID() = Math.Max(_maxDS, _maxBD)

                        _newRow.REFPACIENTE() = fPacienteId
                        _newRow.REFCONCEPTO() = _cod
                        _newRow.DESCRIPCION() = _descrip
                        _newRow.IMPORTE() = _importe

                        fCMDataSet.CONCEPTOSFACTURABLES.AddCONCEPTOSFACTURABLESRow(_newRow)

                    Else
                        Try
                            Me.CONCEPTOSFRATableAdapter.Insert(_cod, _descrip, _importe, durac)
                            Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)

                        Catch ex As Exception

                        End Try
                        
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim durac As Date = New Date(2000, 1, 1, 0, 0, 0)

        Try
            durac = Date.Parse(txtDuracion.Text)
        Catch ex As Exception
        End Try


        Dim _cerrar As Boolean = True
        If CurrentAccion = Enums.Accion.Insertar Then
            If ExisteCodigoFra(tb_cod.Text) = True Then
                MessageBox.Show("El código ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Dim _importe As Double = 0

        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String = tb_cod.Text.Trim()
            Dim _descrip As String = tb_descrip.Text.Trim()
            Double.TryParse(tb_importe.Text, _importe)

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If fDesdePaciente = True Then
                    If _descrip = "" Then
                        MessageBox.Show("El campo descripción debe tener valor", " Centro Médico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        _cerrar = False
                    Else
                        'Me.CONCEPTOSFACTURABLESTableAdapter.UpdateValores(fPacienteId, _cod, _descrip, _importe, fConFacturableId)
                        Dim _updRow As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.FindByID(fConFacturableId)

                        _updRow.REFPACIENTE() = fPacienteId
                        _updRow.REFCONCEPTO() = _cod
                        _updRow.DESCRIPCION() = _descrip
                        _updRow.IMPORTE() = _importe

                    End If
                Else
                    Me.CONCEPTOSFRATableAdapter.UpdateValores(_cod, _descrip, _importe, durac, fcodo)

                    Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)

                End If

            Else
                If fDesdePaciente = True Then
                    If _descrip = "" Then
                        MessageBox.Show("El campo descripción debe tener valor", "Centro Médico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        _cerrar = False
                    Else
                        'Me.CONCEPTOSFACTURABLESTableAdapter.InsertNuevo(fPacienteId, _cod, _descrip, _importe)

                        Dim _newRow As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.NewCONCEPTOSFACTURABLESRow()

                        Dim _rows() As CMDataSet.CONCEPTOSFACTURABLESRow = fCMDataSet.CONCEPTOSFACTURABLES.Select("", "ID ASC")

                        Dim _maxBD As Integer = 1
                        If CONCEPTOSFACTURABLESTableAdapter.MaximoId.HasValue Then
                            If Integer.TryParse(CONCEPTOSFACTURABLESTableAdapter.MaximoId(), _maxBD) Then
                                _maxBD = _maxBD + 1
                            End If
                        End If

                        Dim _maxDS As Integer = 1

                        If _rows.Length > 0 Then
                            _maxDS = _rows(_rows.Length - 1).ID() + 1
                        End If

                        _newRow.ID() = Math.Max(_maxDS, _maxBD)

                        _newRow.REFPACIENTE() = fPacienteId
                        _newRow.REFCONCEPTO() = _cod
                        _newRow.DESCRIPCION() = _descrip
                        _newRow.IMPORTE() = _importe

                        fCMDataSet.CONCEPTOSFACTURABLES.AddCONCEPTOSFACTURABLESRow(_newRow)

                        End If
                Else
                    Try
                        Me.CONCEPTOSFRATableAdapter.Insert(_cod, _descrip, _importe, durac)
                        Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)
                        fId = _cod
                    Catch ex As Exception

                    End Try
                  

                End If
            End If

            If _cerrar = True Then
                clickaccept = True
                Me.Close()
            End If

        End If

        Try
            'If CtrlFamilia1.ID_CONCEPTOFAMILIA.HasValue Then
            Dim context As New CMLinqDataContext()
            Dim concepto As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = fId Select c).SingleOrDefault()
            concepto.IDFAMILIA = CtrlFamilia1.ID_CONCEPTOFAMILIA
            concepto.Duracion = New Date(2000, 1, 1, 0, 0, 0).Add(txtDuracion.Value.TimeOfDay)
            context.SubmitChanges()
            'End If
        Catch ex As Exception

        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub bt_BuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_BuscarCodigo.Click
        Me.CONCEPTOSFRATableAdapter.Fill(CMDataSet.CONCEPTOSFRA)
        Dim _name As String = "Listado de conceptos facturables"

        Dim _listados As form_listados = New form_listados(_name, CONCEPTOSFRABindingSource, RoleManager.Items.Conceptos_Facturables, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()

        If _listados.Selected() <> "" Then
            Dim _Id As String = _listados.Selected()
            Dim _data As CMDataSet.CONCEPTOSFRADataTable = CONCEPTOSFRATableAdapter.GetConceptoFraById(_Id)
            tb_cod.Text = _data.Rows(0).Item("CODIGO")
            tb_descrip.Text = _data.Rows(0).Item("DESCRIPCION")
            tb_importe.Text = _data.Rows(0).Item("IMPORTE")

        End If

    End Sub

    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        'Dim _text As String = aTexbox.Text
        'Dim _number As Single
        'Dim _texto As String = ""
        'Dim modif As Integer = _text.Length
        'Dim cant As Integer = 0
        'If _text <> "" And _text <> Nothing Then
        '    If _text.Length > 0 Then
        '        Dim i As Integer
        '        For i = 0 To _text.Length - 1
        '            If Not Single.TryParse(_text(i), _number) And _text(i) <> "," Then
        '                modif = i
        '                Continue For
        '            Else
        '                If _text(i) = "," And cant = 1 Then
        '                    modif = i
        '                    Continue For
        '                ElseIf _text(i) = "," Then
        '                    cant = 1
        '                End If
        '                _texto = _texto + _text(i)
        '            End If

        '        Next
        '        aTexbox.Text = _texto

        '    End If
        'End If
        'If modif <> _text.Length Then
        '    aTexbox.SelectionStart = modif
        'End If

        Dim cantidad As Double = 0
        If IsNumeric(aTexbox.Text) Then
            cantidad = CDbl(aTexbox.Text)
            aTexbox.Text = Format(cantidad, "##,##0.00")
        End If
    End Sub

    Private Sub tb_importe_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.Leave
        ChequearTextboxSoloNumero(tb_importe)
    End Sub

    Private Function ExisteCodigoFra(ByVal cod As String)
        Dim context As New CMLinqDataContext
        Dim conceptoFra As CONCEPTOSFRA = (From f As CONCEPTOSFRA In context.CONCEPTOSFRAs
                                          Where f.CODIGO = cod
                                          Select f).SingleOrDefault()
        Return Not conceptoFra Is Nothing

    End Function

    Private Function ValidarCodigoConceptoFra() As Boolean
        Dim _data As CMDataSet.CONCEPTOSFRADataTable = CONCEPTOSFRATableAdapter.GetData()
        Dim _result As Boolean = False
        Dim i As Integer
        If _data.Rows.Count > 0 Then
            For i = 0 To _data.Rows.Count - 1
                Dim _id As String = _data.Rows(i).Item("CODIGO").ToString()
                If tb_cod.Text = _id Then
                    Return True
                Else
                    Return False
                End If
            Next
        Else
            Return False
            Exit Function
        End If
        'Return False
    End Function

    Private Sub tb_cod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cod.TextChanged
        If ValidarCodigoConceptoFra() Then
            Dim _data As CMDataSet.CONCEPTOSFRADataTable = CONCEPTOSFRATableAdapter.GetConceptoFraById(tb_cod.Text)
            tb_descrip.Text = _data.Rows(0).Item("DESCRIPCION")
            tb_importe.Text = _data.Rows(0).Item("IMPORTE")
        Else
            tb_descrip.Text = ""
            tb_importe.Text = "0.0"
        End If
    End Sub

   
End Class