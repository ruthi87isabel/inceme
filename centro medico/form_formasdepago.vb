Public Class form_formasdepago
    Dim fId As Integer
    Dim fCambios As Boolean = False


#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()
    End Sub
#End Region


    Private Sub form_formasdepago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        AplicaPermisos()
        CargarDatos()
        ActualizarFechaNac()
    End Sub

    Private Sub AplicaPermisos()
        pn_fpCodigo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Formas_de_Pago) > 2)
        tb_fpDescrip.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Formas_de_Pago) > 2)
        Panel1.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Formas_de_Pago) > 2)
    End Sub


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        'If CMDataSet.PACIENTES.Count > 0 Then
        '    Dim paciente As CMDataSet.PACIENTESRow = CMDataSet.PACIENTES(0)
        '    paciente.DC = CtrlCuentaBancaria1.DC
        '    paciente.CUENTA = CtrlCuentaBancaria1.Cuenta
        '    paciente.ENTIDAD = CtrlCuentaBancaria1.Entidad
        '    paciente.OFICINA = CtrlCuentaBancaria1.Oficina

        'End If
        
        PACIENTESBindingSource.EndEdit()
        PACIENTESTableAdapter.Update(CMDataSet.PACIENTES)
        Me.Close()
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Dim res As MsgBoxResult
        If fCambios = True Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub bt_fpBuscarcodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fpBuscarcodigo.Click
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)
        Dim _name As String = "Listado de Formas de Pago"
        Dim _listados As form_listados = New form_listados(_name, FORMASPAGOBindingSource, RoleManager.Items.Formas_de_Pago, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected <> Nothing Then

            tb_fpCodigo.Text = _listados.Selected
            Dim _dataFomapago As CMDataSet.FORMASPAGODataTable = FORMASPAGOTableAdapter.GetFormasPagoById(_listados.Selected)
            tb_fpDescrip.Text = _dataFomapago.Rows(0).Item("DESCRIPCION").ToString()
            CMDataSet.PACIENTES.FindByCPACIENTE(fId).REFFORMAPAGO() = _listados.Selected
            fCambios = True
        End If
    End Sub

    Private Sub bt_fpBuscarbanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fpCuenta.Click
        Me.BANCOSTableAdapter.Fill(Me.CMDataSet.BANCOS)
        Dim _name As String = "Listado de Banco"
        Dim _listados As form_listados = New form_listados(_name, BANCOSBindingSource, RoleManager.Items.Bancos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected <> Nothing Then

            Dim _datos() As String = _listados.Selected.Split("/==>/")
            CtrlCuentaBancaria1.Entidad = _datos(0)
            CtrlCuentaBancaria1.Oficina = _datos(2)
            CMDataSet.PACIENTES.FindByCPACIENTE(fId).ENTIDAD() = _datos(0)
            CMDataSet.PACIENTES.FindByCPACIENTE(fId).OFICINA() = _datos(2)

            Dim _dataBanco As CMDataSet.BANCOSDataTable = BANCOSTableAdapter.GetBancoByKey(_datos(0), _datos(2))
            If _dataBanco.Rows.Count > 0 Then
                tb_fpEntidadbancaria.Text = _dataBanco.Rows(0).Item("NOMBRE").ToString()
            End If
            fCambios = True
        End If
    End Sub

    Private Sub chb_fpPagobanco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_fpPagobanco.CheckedChanged
        If chb_fpPagobanco.Checked = True Then
            CMDataSet.PACIENTES.FindByCPACIENTE(fId).PAGOBANCO() = "S"
        Else
            CMDataSet.PACIENTES.FindByCPACIENTE(fId).PAGOBANCO() = "N"
        End If
        fCambios = True
    End Sub

    'Private Sub tb_fpDc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If tb_fpDc.Text.Length > 0 Then
    '        tb_fpDc.BackColor = Color.Red
    '    Else
    '        tb_fpDc.BackColor = Color.White
    '    End If
    '    CMDataSet.PACIENTES.FindByCPACIENTE(fId).DC() = tb_fpDc.Text
    '    fCambios = True
    'End Sub

    Private Sub CargarDatos()

        Dim _dataDatosPersonales As CMDataSet.PACIENTESDataTable = New CMDataSet.PACIENTESDataTable()
        _dataDatosPersonales.ImportRow(CMDataSet.PACIENTES.FindByCPACIENTE(fId))

        If _dataDatosPersonales.Rows(0).Item("REFFORMAPAGO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            Dim _mId As String = _dataDatosPersonales.Rows(0).Item("REFFORMAPAGO").ToString()
            tb_fpCodigo.Text = _mId
            Dim _dataFomapago As CMDataSet.FORMASPAGODataTable = FORMASPAGOTableAdapter.GetFormasPagoById(_mId)
            tb_fpDescrip.Text = _dataFomapago.Rows(0).Item("DESCRIPCION")
        End If

        If _dataDatosPersonales.Rows(0).Item("PAGOBANCO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            If _dataDatosPersonales.Rows(0).Item("PAGOBANCO").ToString() = "N" Then
                chb_fpPagobanco.Checked = False
            Else
                chb_fpPagobanco.Checked = True
            End If
        End If

        If _dataDatosPersonales.Rows(0).Item("ENTIDAD").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            CtrlCuentaBancaria1.Entidad = _dataDatosPersonales.Rows(0).Item("ENTIDAD").ToString()
        End If

        If _dataDatosPersonales.Rows(0).Item("OFICINA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            CtrlCuentaBancaria1.Oficina = _dataDatosPersonales.Rows(0).Item("OFICINA").ToString()
        End If

        If _dataDatosPersonales.Rows(0).Item("ENTIDAD").GetType().ToString() <> DBNull.Value.GetType().ToString() And _dataDatosPersonales.Rows(0).Item("OFICINA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            Dim _dataBanco As CMDataSet.BANCOSDataTable = BANCOSTableAdapter.GetBancoByKey(_dataDatosPersonales.Rows(0).Item("ENTIDAD").ToString(), _dataDatosPersonales.Rows(0).Item("OFICINA").ToString())
            If _dataBanco.Rows.Count > 0 Then
                tb_fpEntidadbancaria.Text = _dataBanco.Rows(0).Item("NOMBRE").ToString()
            End If
        End If

        If _dataDatosPersonales.Rows(0).Item("DC").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            CtrlCuentaBancaria1.DC = _dataDatosPersonales.Rows(0).Item("DC").ToString()
        End If

        If _dataDatosPersonales.Rows(0).Item("CUENTA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            CtrlCuentaBancaria1.Cuenta = _dataDatosPersonales.Rows(0).Item("CUENTA").ToString()
        End If

        If _dataDatosPersonales.Rows(0).Item("TITULAR").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            tb_fpTitularCuentaORecibo.Text = _dataDatosPersonales.Rows(0).Item("TITULAR").ToString()
        End If


    End Sub

    Private Sub tb_fpDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_fpDescrip.TextChanged
        fCambios = True
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
End Class