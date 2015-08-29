Public Class form_pac_annadirmutua


    Dim fCodigo As Integer
    Dim fIdMutua As Integer
    Dim fNombre As String
    Dim fPacienteId As Integer
    Dim fcurrentAcc As Integer
    Dim _tipo As String = ""


    Dim fCMDataSet As CMDataSet


    'Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    '    Me.CurrentAccion = aCurrentAccion
    '    Me.Text = aName


    'End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fPacienteId = aPacienteId

        fCMDataSet = aCMDataSet

    End Sub

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aPacienteId As Integer, ByVal aCodigo As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fPacienteId = aPacienteId
        Me.fCodigo = aCodigo

        fCMDataSet = aCMDataSet

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

    Public Property IdMutua() As Integer

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fIdMutua

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Integer)
            fIdMutua = Value
        End Set
    End Property

    Public Property Nombre() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fNombre

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fNombre = Value
        End Set
    End Property

    Public ReadOnly Property Tipo() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return Me._tipo
        End Get

    End Property

    Private Sub MUTUASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MUTUASBindingSource.EndEdit()
        Me.MUTUASTableAdapter.Update(Me.CMDataSet.MUTUAS)

    End Sub


    Public Sub PreCargaMutua(_aId As Integer)
        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)
        Dim _dataMutuas As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_aId)
        fIdMutua = _aId
        fNombre = _dataMutuas.Rows(0).Item("Nombre").ToString()
        tb_AMCompannia.Text = _aId
        tb_AMNombreComp.Text = fNombre
    End Sub

    Private Sub bt_AMBuscarComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AMBuscarComp.Click
        Dim _name As String = "Listado de Mutuas"

        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)

        Dim _listadosMutuas As form_listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True)
        _listadosMutuas.ShowInTaskbar = False
        _listadosMutuas.ShowDialog()
        If _listadosMutuas.Selected <> Nothing Then

            Dim _aId As Integer = Integer.Parse(_listadosMutuas.Selected)
            Dim _dataMutuas As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_aId)

            fIdMutua = _aId
            fNombre = _dataMutuas.Rows(0).Item("Nombre").ToString()
            tb_AMCompannia.Text = _aId
            tb_AMNombreComp.Text = fNombre
        Else
            fIdMutua = -1
            tb_AMCompannia.Text = ""
        End If
    End Sub

    Private Sub bt_AMAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AMAceptar.Click
        If fIdMutua <> -1 Then

            If cb_AMTipo.Text = "Mutua asistencial" Then
                _tipo = "M"
            ElseIf cb_AMTipo.Text = "Compañía de revisión" Then
                _tipo = "C"
            ElseIf cb_AMTipo.Text = "Aseguradora privada" Then
                _tipo = "A"
            End If

            If Me.CurrentAccion = Enums.Accion.Insertar Then
                'LMUTUASTableAdapter.InsertDesdePacientes(fPacienteId, fIdMutua, dtp_AMFechaalta.Value, dtp_AMFechabaja.Value, _tipo, tb_AMNotas.Text)
                '=====> BORRAR EN LMUTUAS
                Dim _newRow As CMDataSet.LMUTUASRow = fCMDataSet.LMUTUAS.NewLMUTUASRow()
                Dim _rows() As CMDataSet.LMUTUASRow = fCMDataSet.LMUTUAS.Select("", "CODIGO ASC")

                Dim _maxBD As Integer = 1
                If LMUTUASTableAdapter.MaximoId.HasValue Then
                    If Integer.TryParse(LMUTUASTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If
                End If

                Dim _maxDS As Integer = 1

                If _rows.Length > 0 Then
                    _maxDS = _rows(_rows.Length - 1).CODIGO() + 1
                End If

                _newRow.CODIGO() = Math.Max(_maxDS, _maxBD)

                _newRow.REFPACIENTE() = fPacienteId
                _newRow.REFMUTUA() = fIdMutua
                _newRow.FECHAALTA() = dtp_AMFechaalta.Value

                If Me.chkFBaja.Checked = True Then
                    _newRow.FECHABAJA() = dtp_AMFechabaja.Value
                End If

                _newRow.TIPO() = _tipo
                _newRow.NOTAS() = tb_AMNotas.Text

                fCMDataSet.LMUTUAS.AddLMUTUASRow(_newRow)

            ElseIf Me.CurrentAccion = Enums.Accion.Modificar Then
                'LMUTUASTableAdapter.UpdateData(fPacienteId, fIdMutua, dtp_AMFechaalta.Value, dtp_AMFechabaja.Value, _tipo, tb_AMNotas.Text, fCodigo)
                '=====> ACTUALIZAR EN LMUTUAS
                Dim _updRow As CMDataSet.LMUTUASRow = fCMDataSet.LMUTUAS.FindByCODIGO(fCodigo)

                _updRow.REFPACIENTE() = fPacienteId
                _updRow.REFMUTUA() = fIdMutua
                _updRow.FECHAALTA() = dtp_AMFechaalta.Value

                If Me.chkFBaja.Checked = False Then
                    _updRow.SetFECHABAJANull()
                Else
                    _updRow.FECHABAJA() = dtp_AMFechabaja.Value
                End If

                _updRow.TIPO() = _tipo
                _updRow.NOTAS() = tb_AMNotas.Text

            End If
        End If
        Close()
    End Sub

    Private Sub form_pac_annadirmutua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.CurrentAccion = Enums.Accion.Insertar Then
            fIdMutua = -1
        Else

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Inicializa()
            End If
        End If
    End Sub

    Private Sub bt_AMCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AMCancelar.Click
        fIdMutua = -1
        Close()
    End Sub

    Private Sub Inicializa()
        Dim _dataLMutua As CMDataSet.LMUTUASDataTable = New CMDataSet.LMUTUASDataTable()
        'LMUTUASTableAdapter.GetDataById(fCodigo)
        _dataLMutua.ImportRow(fCMDataSet.LMUTUAS.FindByCODIGO(fCodigo))
        Dim _dataMutua As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_dataLMutua.Rows(0).Item("REFMUTUA"))

        fIdMutua = _dataMutua.Rows(0).Item("CMUTUA")
        tb_AMCompannia.Text = fIdMutua
        tb_AMCompannia.Enabled = False
        bt_AMBuscarComp.Enabled = False
        tb_AMNombreComp.Text = _dataMutua.Rows(0).Item("Nombre").ToString()

        If _dataLMutua.Rows(0).Item("FECHAALTA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_AMFechaalta.Value = _dataLMutua.Rows(0).Item("FECHAALTA")
        Else
            dtp_AMFechaalta.Value = Date.Now
        End If

        If _dataLMutua.Rows(0).Item("FECHABAJA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_AMFechabaja.Value = _dataLMutua.Rows(0).Item("FECHABAJA")
            dtp_AMFechabaja.Enabled = True
            Me.chkFBaja.Checked = True
        Else
            dtp_AMFechabaja.Enabled = False
            Me.chkFBaja.Checked = False
        End If

        'dtp_AMFechabaja.Value = _dataLMutua.Rows(0).Item("FECHABAJA")
        tb_AMNotas.Text = _dataLMutua.Rows(0).Item("NOTAS").ToString()
        Dim _tipo As String = ""
        If _dataLMutua.Rows(0).Item("Tipo") = "M" Then
            _tipo = "Mutua asistencial"
        ElseIf _dataLMutua.Rows(0).Item("Tipo") = "C" Then
            _tipo = "Compañía de revisión"
        ElseIf _dataLMutua.Rows(0).Item("Tipo") = "A" Then
            _tipo = "Aseguradora privada"
        End If

        cb_AMTipo.Text = _tipo

    End Sub


    Private Sub tb_AMCompannia_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_AMCompannia.Leave
        If tb_AMCompannia.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_AMCompannia.Text)
            Dim data As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_pcodo)
            If data.Rows.Count > 0 Then
                tb_AMNombreComp.Text = data.Rows(0).Item("NOMBRE")
                fIdMutua = _pcodo
            Else
                tb_AMCompannia.Text = ""
                tb_AMCompannia.Focus()
                MessageBox.Show("No existe una mutua con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub chkFBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFBaja.CheckedChanged
        Me.dtp_AMFechabaja.Enabled = chkFBaja.Checked
    End Sub
End Class