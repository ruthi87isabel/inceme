Public Class frmPaciente_FormasPago

    Public Paciente As PACIENTE
    Public Context As CMLinqDataContext

    Private Sub frmPaciente_FormasPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Paciente Is Nothing Then
            CtrlFormaPago21.ID_FORMASPAGO = Paciente.REFFORMAPAGO

            CtrlCuentaBancaria1.Cuenta = Paciente.CUENTA
            CtrlCuentaBancaria1.DC = Paciente.DC
            CtrlCuentaBancaria1.Entidad = Paciente.ENTIDAD
            CtrlCuentaBancaria1.Oficina = Paciente.OFICINA

            btIBAN_Click(Nothing, Nothing)
            Dim banco As BANCO = (From b In Context.BANCOs Where
                           b.ENTIDAD = Paciente.ENTIDAD And b.OFICINA = Paciente.OFICINA
                           Select b).SingleOrDefault()

            If Not banco Is Nothing Then
                tb_fpEntidadbancaria.Text = banco.NOMBRE
            End If
        End If

        If Not Paciente.PAGOBANCO Is Nothing Then
            If Paciente.PAGOBANCO = "S" Then
                chkPagoBanco.Checked = True
            Else
                chkPagoBanco.Checked = False
            End If
        Else
            chkPagoBanco.Checked = False
        End If
        
        AplicaPermisos()




    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Paciente.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO
        If chkPagoBanco.Checked Then
            Paciente.PAGOBANCO = "S"
        Else
            Paciente.PAGOBANCO = "N"
        End If

        Me.PACIENTEBindingSource.EndEdit()

        Paciente.CUENTA = CtrlCuentaBancaria1.Cuenta
        Paciente.DC = CtrlCuentaBancaria1.DC
        Paciente.ENTIDAD = CtrlCuentaBancaria1.Entidad
        Paciente.OFICINA = CtrlCuentaBancaria1.Oficina

        Context.SubmitChanges()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AplicaPermisos()
        pnlFormaPago.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Formas_de_Pago) > 2)
       End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bt_fpCuenta_Click(sender As Object, e As EventArgs) Handles bt_fpCuenta.Click
        Dim frm As New frmBancosListado()
        frm.Modo = Globales.ModoParaFormas.Seleccion

        If frm.ShowDialog() = DialogResult.OK Then
            If Not frm.Banco Is Nothing Then
                CtrlCuentaBancaria1.Entidad = frm.Banco.ENTIDAD
                CtrlCuentaBancaria1.Oficina = frm.Banco.OFICINA
                tb_fpEntidadbancaria.Text = frm.Banco.NOMBRE
                CtrlCuentaBancaria1.Calcula()

            End If
            
        End If
    End Sub

    Private Sub btIBAN_Click(sender As Object, e As EventArgs) Handles btIBAN.Click
        Dim A = CtrlCuentaBancaria1.Cuenta
        Me.txtIBAN.Text = GoltraTools.Bancario.DimeIBAN(CtrlCuentaBancaria1.CUENTABANCO & "142800") & CtrlCuentaBancaria1.CUENTABANCO
    End Sub
End Class