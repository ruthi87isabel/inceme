Public Class form_pac_annadirempresa


    Dim fCodigo As Integer
    Dim fIdEmpresa As Integer
    Dim fNombre As String
    Dim fPacienteId As Integer
    Dim fcurrentAcc As Integer


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

    Public Property IdEmpresa() As Integer

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fIdEmpresa

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Integer)
            fIdEmpresa = Value
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

    Public ReadOnly Property PuestoTrabajo() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return Me.txtPuesto.Text.Trim

        End Get
        
    End Property


    Private Sub bt_AEListarempresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AEListarempresas.Click
        Dim _name As String = "Listado de Empresas"

        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)

        Dim _listadosEmpresas As form_listados = New form_listados(_name, EMPRESASBindingSource, RoleManager.Items.Empresas, True)
        _listadosEmpresas.ShowInTaskbar = False
        _listadosEmpresas.ShowDialog()
        If _listadosEmpresas.Selected <> Nothing Then

            Dim _aId As Integer = Integer.Parse(_listadosEmpresas.Selected)
            Dim _dataEmpresas As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaById(_aId)
            fIdEmpresa = _aId
            fNombre = _dataEmpresas.Rows(0).Item("Nombre")
            tb_AEEmpresa.Text = _aId
            tb_AENombre.Text = fNombre
        Else
            fIdEmpresa = -1
            tb_AEEmpresa.Text = ""
        End If
    End Sub

    Private Sub form_pac_annadirempresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.CurrentAccion = Enums.Accion.Insertar Then
            fIdEmpresa = -1
        Else

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Inicializa()
            End If
        End If

    End Sub

    Private Sub bt_AEAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AEAceptar.Click
        If fIdEmpresa <> -1 Then
            If Me.CurrentAccion = Enums.Accion.Insertar Then
                'LEMPRESASTableAdapter.Insert(fIdEmpresa, fPacienteId, dtp_AEFechaalta.Value, dtp_AEFechabaja.Value, tb_AENotas.Text)

                Dim _newRow As CMDataSet.LEMPRESASRow = fCMDataSet.LEMPRESAS.NewLEMPRESASRow()
                Dim _rows() As CMDataSet.LEMPRESASRow = fCMDataSet.LEMPRESAS.Select("", "CODIGO ASC")

                Dim _maxBD As Integer = 1
                If LEMPRESASTableAdapter.MaximoId.HasValue Then
                    If Integer.TryParse(LEMPRESASTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If
                End If

                Dim _maxDS As Integer = 1

                If _rows.Length > 0 Then
                    _maxDS = _rows(_rows.Length - 1).CODIGO() + 1
                End If

                _newRow.CODIGO() = Math.Max(_maxDS, _maxBD)


                _newRow.REFPACIENTE() = fPacienteId
                _newRow.REFEMPRESA() = fIdEmpresa
                _newRow.FECHAALTA() = dtp_AEFechaalta.Value
                _newRow.FECHABAJA() = dtp_AEFechabaja.Value
                _newRow.NOTAS() = tb_AENotas.Text
                _newRow.PUESTOTRABAJO = Me.txtPuesto.Text.Trim

                fCMDataSet.LEMPRESAS.AddLEMPRESASRow(_newRow)

            ElseIf Me.CurrentAccion = Enums.Accion.Modificar Then
                'LEMPRESASTableAdapter.UpdateData(fIdEmpresa, fPacienteId, dtp_AEFechaalta.Value, dtp_AEFechabaja.Value, tb_AENotas.Text, fCodigo)
                Dim _updRow As CMDataSet.LEMPRESASRow = fCMDataSet.LEMPRESAS.FindByCODIGO(fCodigo)

                _updRow.REFPACIENTE() = fPacienteId
                _updRow.REFEMPRESA() = fIdEmpresa
                _updRow.FECHAALTA() = dtp_AEFechaalta.Value
                _updRow.FECHABAJA() = dtp_AEFechabaja.Value
                _updRow.NOTAS() = tb_AENotas.Text
                _updRow.PUESTOTRABAJO = Me.txtPuesto.Text.Trim

            End If

            End If
        Close()
    End Sub

    Private Sub bt_AECancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AECancelar.Click
        fIdEmpresa = -1
        Close()
    End Sub

    Private Sub Inicializa()
        Dim _dataLEmpresa As CMDataSet.LEMPRESASDataTable = New CMDataSet.LEMPRESASDataTable()
        'LEMPRESASTableAdapter.GetDataById(fCodigo)
        _dataLEmpresa.ImportRow(fCMDataSet.LEMPRESAS.FindByCODIGO(fCodigo))
        Dim _dataEmpresa As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaById(_dataLEmpresa.Rows(0).Item("REFEMPRESA"))

        fIdEmpresa = _dataEmpresa.Rows(0).Item("CEMPRESA")
        tb_AEEmpresa.Text = fIdEmpresa
        tb_AEEmpresa.Enabled = False
        bt_AEListarempresas.Enabled = False
        tb_AENombre.Text = _dataEmpresa.Rows(0).Item("Nombre").ToString()
        Me.txtPuesto.Text = _dataLEmpresa.Rows(0).Item("PUESTOTRABAJO").ToString

        If _dataLEmpresa.Rows(0).Item("FECHAALTA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_AEFechaalta.Value = _dataLEmpresa.Rows(0).Item("FECHAALTA")
        Else
            dtp_AEFechaalta.Value = Date.Now
        End If

        If _dataLEmpresa.Rows(0).Item("FECHABAJA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_AEFechabaja.Value = _dataLEmpresa.Rows(0).Item("FECHABAJA")
        Else
            dtp_AEFechabaja.Value = Date.Now
        End If



        'dtp_AEFechaalta.Value = _dataLEmpresa.Rows(0).Item("FECHAALTA")
        'dtp_AEFechabaja.Value = _dataLEmpresa.Rows(0).Item("FECHABAJA")
        tb_AENotas.Text = _dataLEmpresa.Rows(0).Item("NOTAS").ToString()

    End Sub

    Private Sub tb_AEEmpresa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_AEEmpresa.Leave
        If tb_AEEmpresa.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_AEEmpresa.Text)
            Dim data As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaById(_pcodo)
            If data.Rows.Count > 0 Then
                fIdEmpresa = _pcodo
                tb_AENombre.Text = data.Rows(0).Item("NOMBRE")
            Else
                tb_AEEmpresa.Text = ""
                tb_AEEmpresa.Focus()
                MessageBox.Show("No existe una empresa con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class