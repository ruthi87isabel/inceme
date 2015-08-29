Imports centro_medico.UI.Reportes

Public Class form_recibos

    Dim fcurrentAcc As Integer
    Dim fId As Integer

    Dim fPacienteId As Integer
    Dim fDesdePaciente As Boolean = False

    Dim frefcita As Integer = Nothing
    Dim freffactura As Integer = Nothing
    Dim fcuentabanco As String = ""


    Dim fCMDataSet As CMDataSet



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

    Private Sub form_recibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtp_fcobro.Enabled = chb_cobrado.Checked

        If fDesdePaciente = True Then

            tb_idpaciente.Text = fPacienteId
            tb_titular.Text = GetPaciente(fPacienteId)
            lb_nombre.Text = tb_titular.Text

            tb_idpaciente.Enabled = False
            tb_titular.Enabled = False
            bt_paciente.Enabled = False
            cb_tipo.Text = "Paciente"
            cb_tipo.Enabled = False
            tb_direccion.Enabled = False
        End If


        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            'tb_concepto.Enabled = False
            CtrlCuentaBancaria1.Enabled = False
            'tb_DC.Enabled = False
            tb_direccion.Enabled = False
            'tb_entidad.Enabled = False
            tb_idforma.Enabled = False
            tb_idpaciente.Enabled = False
            tb_importe.Enabled = False
            tb_notas.Enabled = False
            tb_numero.Enabled = False
            'tb_oficina.Enabled = False
            tb_titular.Enabled = False
            dtp_fcobro.Enabled = False
            dtp_femision.Enabled = False
            dtp_fvencimiento.Enabled = False
            chb_cobrado.Enabled = False
            chb_emitido.Enabled = False
            chb_N19.Enabled = False
            bt_forma.Enabled = False
            bt_paciente.Enabled = False
            cb_tipo.Enabled = False
            bt_aceptar.Hide()
            bt_imprimir.Hide()
            bt_cancel.Text = "Cerrar    "

        End If
        If Me.CurrentAccion = Enums.Accion.Insertar Then

        End If
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


        Dim _paciente As String = ""

        If _data.Rows.Count > 0 Then
            Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
            Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
            Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
            _paciente = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename

            tb_direccion.Text = _data.Rows(0).Item("DOMICILIO").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + _data.Rows(0).Item("CP") + " - " + _data.Rows(0).Item("LOCALIDAD") + " " + _data.Rows(0).Item("PROVINCIA")

        End If

        Return _paciente

    End Function

    Private Function GetEmpresa(ByVal aId As Integer) As String

        Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(aId)
        Dim _emp As String = ""

        If _data.Rows.Count > 0 Then
            _emp = _data.Rows(0).Item("NOMBRE").ToString()
            tb_direccion.Text = _data.Rows(0).Item("DIRECCION").ToString() + Microsoft.VisualBasic.ControlChars.NewLine + _data.Rows(0).Item("CP") + " - " + _data.Rows(0).Item("POBLACION") + " " + _data.Rows(0).Item("PROVINCIA")
        End If

        Return _emp

    End Function

    Private Function GetFormaPago(ByVal aId As String) As String
        Dim _forma As String = ""
        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(aId)

        If _data.Rows.Count > 0 Then
            _forma = _data.Rows(0).Item("DESCRIPCION").ToString()
        End If
        Return _forma

    End Function


    Private Sub Inicializa()
        'Dim _data As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetDataByNumero(fId)

        Dim _data As CMDataSet.RECIBOSDataTable

        If fDesdePaciente Then
            _data = New CMDataSet.RECIBOSDataTable()
            _data.ImportRow(fCMDataSet.RECIBOS.FindByNUMERO(fId))
        Else
            _data = RECIBOSTableAdapter.GetDataByNumero(fId)
        End If


        Dim _fechaemision As DateTime
        If _data.Rows(0).Item("FECHAEMISION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _fechaemision = _data.Rows(0).Item("FECHAEMISION")
        Else
            _fechaemision = Date.Now.Date
        End If


        Dim _cobrado As String = _data.Rows(0).Item("COBRADO").ToString()
        Dim _emitido As String = _data.Rows(0).Item("EMITIDO").ToString()

        Dim _refcita As Integer
        If _data.Rows(0).Item("REFCITA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _refcita = _data.Rows(0).Item("REFCITA")
        Else
            _refcita = Nothing
        End If
        frefcita = _refcita

        Dim _reffactura As Integer
        If _data.Rows(0).Item("REFFACTURA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _reffactura = _data.Rows(0).Item("REFFACTURA")
        Else
            _reffactura = Nothing
        End If
        freffactura = _reffactura

        Dim _importe As Decimal
        If _data.Rows(0).Item("IMPORTE").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _importe = _data.Rows(0).Item("IMPORTE")
        Else
            _importe = Nothing
        End If

        Dim _refpaciente As Integer
        If _data.Rows(0).Item("REFPACIENTE").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _refpaciente = _data.Rows(0).Item("REFPACIENTE")
        Else
            _refpaciente = Nothing
        End If


        Dim _fechavencimiento As DateTime
        If _data.Rows(0).Item("FECHAVENCIMIENTO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _fechavencimiento = _data.Rows(0).Item("FECHAVENCIMIENTO")
        Else
            _fechavencimiento = Date.Now.Date
        End If

        Dim _nombre As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _direccion As String = _data.Rows(0).Item("DIRECCION").ToString()
        Dim _notas As String = _data.Rows(0).Item("NOTAS").ToString()

        Dim _numero As Integer
        If _data.Rows(0).Item("NUMERO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _numero = _data.Rows(0).Item("NUMERO")
        Else
            _numero = Nothing
        End If

        Dim _cuentabanco As String = _data.Rows(0).Item("CUENTABANCO").ToString()
        fcuentabanco = _cuentabanco
        Dim _entidad As String = _data.Rows(0).Item("ENTIDAD").ToString()
        Dim _oficina As String = _data.Rows(0).Item("OFICINA").ToString()
        Dim _dc As String = _data.Rows(0).Item("DC").ToString()
        Dim _cuenta As String = _data.Rows(0).Item("CUENTA").ToString()
        Dim _concepto As String = _data.Rows(0).Item("CONCEPTO").ToString()

        Dim _fechaecobro As DateTime
        If _data.Rows(0).Item("FECHACOBRO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _fechaecobro = _data.Rows(0).Item("FECHACOBRO")
        Else
            _fechaecobro = Date.Now.Date
        End If

        Dim _n19 As String = _data.Rows(0).Item("N19").ToString()

        Dim _refformapago As String
        If _data.Rows(0).Item("REFFORMAPAGO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _refformapago = _data.Rows(0).Item("REFFORMAPAGO").ToString()
        Else
            _refformapago = Nothing
        End If

        Dim _tipo As String = _data.Rows(0).Item("TIPO").ToString()

        Dim _refempresa As Integer
        If _data.Rows(0).Item("REFEMPRESA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            _refempresa = _data.Rows(0).Item("REFEMPRESA")
        Else
            _refempresa = Nothing
        End If


        tb_numero.Text = _numero


        If _tipo = "P" Then
            cb_tipo.Text = "Paciente"
        Else
            cb_tipo.Text = "Empresa"
        End If

        dtp_femision.Value = _fechaemision

        If _cobrado = "S" Then
            chb_cobrado.Checked = True
        Else
            chb_cobrado.Checked = False
        End If

        dtp_fcobro.Enabled = chb_cobrado.Checked


        If _emitido = "S" Then
            chb_emitido.Checked = True
        Else
            chb_emitido.Checked = False
        End If

        If _n19 = "S" Then
            chb_N19.Checked = True
        Else
            chb_N19.Checked = False
        End If

        If _importe <> 0 Then
            tb_importe.Text = String.Format("{0:N}", (_importe))
        End If

        If cb_tipo.Text = "Paciente" Then
            If _refpaciente <> 0 Then
                tb_idpaciente.Text = _refpaciente
                lb_nombre.Text = GetPaciente(_refpaciente)
            End If
            tb_titular.Text = _nombre

        Else
            If _refempresa <> 0 Then
                tb_idpaciente.Text = _refempresa
                lb_nombre.Text = GetEmpresa(_refempresa)
            End If
            tb_titular.Text = _nombre

        End If

        dtp_fvencimiento.Value = _fechavencimiento

        tb_notas.Text = _notas

        CtrlCuentaBancaria1.Entidad = _entidad
        CtrlCuentaBancaria1.Oficina = _oficina
        CtrlCuentaBancaria1.DC = _dc
        CtrlCuentaBancaria1.Cuenta = _cuenta
        tb_concepto.Text = _concepto
        dtp_fcobro.Value = _fechaecobro


        tb_idforma.Text = _refformapago
        If _refformapago <> "" Then
            lb_forma.Text = GetFormaPago(_refformapago)
        End If


    End Sub

    Private Sub bt_forma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_forma.Click
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)
        Dim _name As String = "Listado de formas de pago"
        Dim _listados As form_listados = New form_listados(_name, FORMASPAGOBindingSource, RoleManager.Items.Formas_de_Pago, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As String = _listados.Selected()
            tb_idforma.Text = _pcodo
            lb_forma.Text = GetFormaPago(_pcodo)
        End If
    End Sub

    Private Sub bt_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_paciente.Click
        If cb_tipo.Text = "Paciente" Then
            Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
            Dim _name As String = "Listado de pacientes"
            Dim _listados As form_listados = New form_listados(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes, True)
            _listados.ShowInTaskbar = False
            _listados.ShowDialog()
            If _listados.Selected() <> "" Then
                Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
                tb_idpaciente.Text = _pcodo
                tb_titular.Text = GetPaciente(_pcodo)
                lb_nombre.Text = tb_titular.Text
                CtrlStatusPaciente1.ID_PACIENTE = _pcodo
            End If
        ElseIf cb_tipo.Text = "Empresa" Then
            Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)
            Dim _name As String = "Listado de empresas"
            Dim _listados As form_listados = New form_listados(_name, EMPRESASBindingSource, RoleManager.Items.Empresas, True)
            _listados.ShowInTaskbar = False
            _listados.ShowDialog()
            If _listados.Selected() <> "" Then
                Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
                tb_idpaciente.Text = _pcodo
                tb_titular.Text = GetEmpresa(_pcodo)
                lb_nombre.Text = tb_titular.Text
            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim _fechaemision As DateTime
        If dtp_femision.Enabled = True Then
            _fechaemision = dtp_femision.Value
        Else
            _fechaemision = Nothing
        End If


        Dim _cobrado As String
        If chb_cobrado.Checked = False Then
            _cobrado = "N"
        Else
            _cobrado = "S"
        End If

        Dim _emitido As String
        If chb_emitido.Checked = False Then
            _emitido = "N"
        Else
            _emitido = "S"
        End If

        Dim _importe As Double
        If tb_importe.Text <> "" Then
            _importe = tb_importe.Text
        End If


        Dim _refpaciente As Integer = Nothing
        Dim _refempresa As Integer = Nothing
        Dim _nombre As String
        Dim _tipo As String = cb_tipo.Text

        If cb_tipo.Text = "Paciente" Then
            If tb_idpaciente.Text <> "" Then
                _refpaciente = Integer.Parse(tb_idpaciente.Text)
            End If
            _nombre = tb_titular.Text
            _tipo = "P"
        Else
            If tb_idpaciente.Text <> "" Then
                _refempresa = Integer.Parse(tb_idpaciente.Text)
            End If
            _nombre = tb_titular.Text
            _tipo = "E"
        End If



        Dim _fechavencimiento As DateTime
        If dtp_fvencimiento.Enabled = True Then
            _fechavencimiento = dtp_fvencimiento.Value
        Else
            _fechavencimiento = Nothing
        End If

        Dim _direccion As String = tb_direccion.Text
        Dim _notas As String = tb_notas.Text


        Dim _entidad As String = CtrlCuentaBancaria1.Entidad
        Dim _oficina As String = CtrlCuentaBancaria1.Oficina
        Dim _dc As String = CtrlCuentaBancaria1.DC
        Dim _cuenta As String = CtrlCuentaBancaria1.Cuenta
        Dim _concepto As String = tb_concepto.Text

        Dim _fechaecobro As DateTime
        If dtp_fcobro.Enabled = True Then
            _fechaecobro = dtp_fcobro.Value
        Else
            _fechaecobro = DateTime.Now
        End If

        Dim _n19 As String

        If _chb_N19.Checked = False Then
            _n19 = "N"
        Else
            _n19 = "S"
        End If

        Dim _refformapago As String = tb_idforma.Text

        If Me.CurrentAccion = Enums.Accion.Modificar Then


            If fDesdePaciente Then

                Dim _updRow As CMDataSet.RECIBOSRow = fCMDataSet.RECIBOS.FindByNUMERO(fId)

                _updRow.FECHAEMISION() = _fechaemision
                _updRow.COBRADO() = _cobrado
                _updRow.EMITIDO() = _emitido
                _updRow.REFCITA() = frefcita
                _updRow.REFFACTURA() = freffactura
                _updRow.IMPORTE() = _importe
                _updRow.FECHAVENCIMIENTO() = _fechavencimiento
                _updRow.NOMBRE() = _nombre
                _updRow.DIRECCION() = _direccion
                _updRow.NOTAS() = _notas
                _updRow.CUENTABANCO() = fcuentabanco
                _updRow.ENTIDAD() = _entidad
                _updRow.OFICINA() = _oficina
                _updRow.DC() = _dc
                _updRow.CUENTA() = _cuenta
                _updRow.CONCEPTO() = _concepto
                _updRow.FECHACOBRO() = _fechaecobro
                _updRow.N19() = _n19
                _updRow.TIPO() = _tipo

                If _refformapago <> "" Then
                    _updRow.REFFORMAPAGO() = _refformapago
                End If

                If cb_tipo.Text = "Paciente" Then

                    If _refpaciente <> 0 Then
                        _updRow.REFPACIENTE() = _refpaciente
                    End If
                Else

                    If _refempresa <> 0 Then
                        _updRow.REFEMPRESA() = _refempresa
                    End If
                End If

            Else

                If _refpaciente = 0 And _refempresa = 0 And _refformapago = "" Then
                    RECIBOSTableAdapter.UpdateValoresSinPacEmpYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, fId)
                Else
                    If _refpaciente = 0 And _refempresa = 0 Then
                        RECIBOSTableAdapter.UpdateValoresSinPacienteYEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, fId)
                    Else
                        If cb_tipo.Text = "Paciente" Then
                            If _refpaciente = 0 And _refformapago = "" Then
                                RECIBOSTableAdapter.UpdateValoresSinPacYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, Nothing, fId)
                            ElseIf _refpaciente = 0 Then
                                RECIBOSTableAdapter.UpdateValoresSinPaciente(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, Nothing, fId)
                            ElseIf _refformapago = "" Then
                                RECIBOSTableAdapter.UpdateValoresSinFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _refpaciente, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, Nothing, fId)
                            Else
                                RECIBOSTableAdapter.UpdateValoresSinEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _refpaciente, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, fId)
                            End If
                        Else
                            If _refempresa = 0 And _refformapago = "" Then
                                RECIBOSTableAdapter.UpdateValoresSinEmpresaYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, fId)
                            ElseIf _refempresa = 0 Then
                                RECIBOSTableAdapter.UpdateValoresSinEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, fId)
                            ElseIf _refformapago = "" Then
                                RECIBOSTableAdapter.UpdateValoresSinFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, _refempresa, fId)
                            Else
                                RECIBOSTableAdapter.UpdateValoresSinPaciente(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, _refempresa, fId)
                            End If
                        End If
                    End If

                End If
                Globales.CobroEnCascada(, CInt(Me.tb_numero.Text))
            End If

            Close()
        Else


            If fDesdePaciente Then

                Dim _newRow As CMDataSet.RECIBOSRow = fCMDataSet.RECIBOS.NewRECIBOSRow()

                Dim _rows() As CMDataSet.RECIBOSRow = fCMDataSet.RECIBOS.Select("", "NUMERO ASC")

                Dim _maxBD As Integer = 1
                If RECIBOSTableAdapter.MaximoId.HasValue Then
                    If Integer.TryParse(RECIBOSTableAdapter.MaximoId(), _maxBD) Then
                        _maxBD = _maxBD + 1
                    End If
                End If

                Dim _maxDS As Integer = 1

                If _rows.Length > 0 Then
                    _maxDS = _rows(_rows.Length - 1).NUMERO() + 1
                End If

                _newRow.NUMERO() = Math.Max(_maxDS, _maxBD)

                _newRow.FECHAEMISION() = _fechaemision
                _newRow.COBRADO() = _cobrado
                _newRow.EMITIDO() = _emitido
                _newRow.REFCITA() = frefcita
                _newRow.REFFACTURA() = freffactura
                _newRow.IMPORTE() = _importe
                _newRow.FECHAVENCIMIENTO() = _fechavencimiento
                _newRow.NOMBRE() = _nombre
                _newRow.DIRECCION() = _direccion
                _newRow.NOTAS() = _notas
                _newRow.CUENTABANCO() = fcuentabanco
                _newRow.ENTIDAD() = _entidad
                _newRow.OFICINA() = _oficina
                _newRow.DC() = _dc
                _newRow.CUENTA() = _cuenta
                _newRow.CONCEPTO() = _concepto
                _newRow.FECHACOBRO() = _fechaecobro
                _newRow.N19() = _n19
                _newRow.TIPO() = _tipo

                If _refformapago <> "" Then
                    _newRow.REFFORMAPAGO() = _refformapago
                End If

                If cb_tipo.Text = "Paciente" Then

                    If _refpaciente <> 0 Then
                        _newRow.REFPACIENTE() = _refpaciente
                    End If
                Else

                    If _refempresa <> 0 Then
                        _newRow.REFEMPRESA() = _refempresa
                    End If
                End If

                fCMDataSet.RECIBOS.AddRECIBOSRow(_newRow)

            Else

                If _refpaciente = 0 And _refempresa = 0 And _refformapago = "" Then
                    RECIBOSTableAdapter.InsertSinPacEmpYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo)

                Else
                    If _refpaciente = 0 And _refempresa = 0 Then
                        RECIBOSTableAdapter.InsertSinPacienteYEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo)
                    Else
                        If cb_tipo.Text = "Paciente" Then
                            If _refpaciente = 0 And _refformapago = "" Then
                                RECIBOSTableAdapter.InsertSinPacYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, Nothing)
                            ElseIf _refpaciente = 0 Then
                                RECIBOSTableAdapter.InsertSinPaciente(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, Nothing)
                            ElseIf _refformapago = "" Then
                                RECIBOSTableAdapter.InsertSinFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _refpaciente, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, Nothing)
                            Else
                                RECIBOSTableAdapter.InsertSinEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _refpaciente, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo)
                            End If
                        Else
                            If _refempresa = 0 And _refformapago = "" Then
                                RECIBOSTableAdapter.InsertSinEmpresaYFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo)
                            ElseIf _refempresa = 0 Then
                                RECIBOSTableAdapter.InsertSinEmpresa(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo)
                            ElseIf _refformapago = "" Then
                                RECIBOSTableAdapter.InsertSinFormaPago(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, Nothing, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _tipo, _refempresa)
                            Else
                                RECIBOSTableAdapter.InsertSinPaciente(_fechaemision, _cobrado, _emitido, frefcita, freffactura, _importe, _fechavencimiento, _nombre, _direccion, _notas, fcuentabanco, _entidad, _oficina, _dc, _cuenta, _concepto, _fechaecobro, _n19, _refformapago, _tipo, _refempresa)
                            End If
                        End If
                    End If

                End If
                If tb_numero.Text.Length > 0 Then
                    Globales.CobroEnCascada(, CInt(Me.tb_numero.Text))
                End If

            End If


            Close()
        End If

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Close()
    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged

        tb_idpaciente.Text = ""
        lb_nombre.Text = ""

    End Sub



    Private Sub chb_cobrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_cobrado.CheckedChanged
        dtp_fcobro.Enabled = chb_cobrado.Checked
    End Sub

    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        Dim cant As Integer = 0
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Single.TryParse(_text(i), _number) And _text(i) <> "," Then
                        modif = i
                        Continue For
                    Else
                        If _text(i) = "," And cant = 1 Then
                            modif = i
                            Continue For
                        ElseIf _text(i) = "," Then
                            cant = 1
                        End If
                        _texto = _texto + _text(i)
                    End If

                Next
                aTexbox.Text = _texto

            End If
        End If
        If modif <> _text.Length Then
            aTexbox.SelectionStart = modif
        End If
    End Sub

    Private Sub tb_importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.TextChanged
        ChequearTextboxSoloNumero(tb_importe)
    End Sub

    Private Sub tb_idforma_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idforma.Leave
        If tb_idforma.Text <> "" Then
            Dim _pcodo As String = tb_idforma.Text
            Dim data As CMDataSet.FORMASPAGODataTable = FORMASPAGOTableAdapter.GetFormasPagoById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_forma.Text = GetFormaPago(_pcodo)
            Else
                tb_idforma.Text = ""
                tb_idforma.Focus()
                MessageBox.Show("No existe una forma de pago con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tb_idpaciente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idpaciente.Leave
        If tb_idpaciente.Text <> "" Then
            If cb_tipo.Text = "Paciente" Then
                Dim _pcodo As Integer = Integer.Parse(tb_idpaciente.Text)
                Dim data As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_pcodo)
                If data.Rows.Count > 0 Then
                    lb_nombre.Text = GetPaciente(_pcodo)
                    tb_titular.Text = lb_nombre.Text
                Else
                    tb_idpaciente.Text = ""
                    tb_idpaciente.Focus()
                    MessageBox.Show("No existe un paciente con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf cb_tipo.Text = "Empresa" Then
                Dim _pcodo As Integer = Integer.Parse(tb_idpaciente.Text)
                Dim datac As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaById(_pcodo)
                If datac.Rows.Count > 0 Then
                    lb_nombre.Text = GetEmpresa(_pcodo)
                    tb_titular.Text = lb_nombre.Text
                Else
                    tb_idpaciente.Text = ""
                    tb_idpaciente.Focus()
                    MessageBox.Show("No existe una empresa con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
       
        Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()


        'ANTES DE IMPRIMIR LO OBLIGO A GUARDAR
        Me.bt_aceptar_Click(Nothing, Nothing)
        rpt.Name = "CMDataSet_RECIBOS"
        rpt.Value = Me.RECIBOSTableAdapter.GetDataByNumero(CInt(Me.tb_numero.Text))

        parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("NombreEmisor", Globales.Configuracion.nombrecomercial)

        ReportesManager.Imprime("Recibo.rdlc", {rpt}, parametros)

    End Sub

    
End Class