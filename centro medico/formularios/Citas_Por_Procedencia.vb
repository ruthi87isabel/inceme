Public Class Citas_Por_Procedencia

    Dim imprimir As Boolean = False

    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal lectura As Boolean)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim i As Integer
        For i = 0 To Me.Controls.Count - 1
            Me.Controls(i).Enabled = False
        Next
        bt_cerrar.Enabled = True

    End Sub
    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub
    Private Function GetMutua(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(aId)
        Dim _mutua As String = _data.Rows(0).Item("NOMBRE").ToString()
        Return _mutua

    End Function
    Private Function GetEmpresa(ByVal aId As Integer) As String

        Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(aId)
        Dim _emp As String = _data.Rows(0).Item("NOMBRE").ToString()
        Return _emp

    End Function

    Private Function GetPacienteNombre(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _Nombre As String = _data.Rows(0).Item("NOMBRE").ToString()
        Return _Nombre

    End Function
    Private Function GetPacienteApellido1(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _apellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Return _apellido1

    End Function
    Private Function GetPacienteApellido2(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _apellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Return _apellido2

    End Function
    Private Sub bt_empresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_empresa.Click
        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)
        Dim _name As String = "Listado de empresas"
        Dim _listados As form_listados = New form_listados(_name, EMPRESASBindingSource, RoleManager.Items.Empresas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_empresa.Text = _pcodo.ToString()
            lb_empresa.Text = GetEmpresa(_pcodo)
        End If
    End Sub
    Private Sub bt_mutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mutua.Click
        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)
        Dim _name As String = "Listado de mutuas"
        Dim _listados As form_listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_mutua.Text = _pcodo.ToString()
            lb_mutua.Text = GetMutua(_pcodo)
        End If
    End Sub
    Private Function GetPacienteRefMutua(ByVal aId As Integer) As Integer

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _mutua As Integer = _data.Rows(0).Item("REFMUTUA").ToString()
        Return _mutua

    End Function
    Private Function GetPacienteRefEmpresa(ByVal aId As Integer) As Integer

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _emp As Integer = _data.Rows(0).Item("REFEMPRESA")
        Return _emp

    End Function

    Private Sub tab_mutua_paciente_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_mutua_paciente.Enter
        bt_empresa.Enabled = False
        bt_mutua.Enabled = True

    End Sub

    Private Sub tab_mutua_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_mutua.Enter
        bt_empresa.Enabled = False
        bt_mutua.Enabled = True

    End Sub

    Private Sub tab_empresa_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_empresa.Enter
        bt_mutua.Enabled = False
        bt_empresa.Enabled = True
    End Sub

    Private Sub tab_empresa_mutua_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_empresa_mutua.Enter
        bt_mutua.Enabled = False
        bt_empresa.Enabled = True
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Dim fInicialt As Date = dtp_fi.Value
        Dim fFinalt As Date = dtp_ff.Value
        Dim fInicial As Date = New Date(fInicialt.Year, fInicialt.Month, fInicialt.Day, 0, 0, 0)
        Dim fFinal As Date = New Date(fFinalt.Year, fFinalt.Month, fFinalt.Day, 23, 59, 59)
        Dim _data As CMDataSet.CITASDataTable = Me.CITASTableAdapter.GetCitaByInterval(fInicial, fFinal)
        Dim i As Integer
        dgv_mutuapac.Rows.Clear()
        dgv_mutuas.Rows.Clear()
        dgv_empresa.Rows.Clear()
        dgv_empresapac.Rows.Clear()
        If tb_mutua.Text = "" Then
            dgv_mutuas.Rows.Add("", "Sin mutua", "")
            dgv_mutuapac.Rows.Add("", "", "", "", "Sin mutua", "")
        Else
            Dim mutuas As ArrayList = New ArrayList()
            Dim cant As ArrayList = New ArrayList()
            Dim mutuasp As ArrayList = New ArrayList()
            Dim cantp As ArrayList = New ArrayList()
            Dim pacientes As ArrayList = New ArrayList()

            For i = 0 To _data.Rows.Count - 1
                cant.Add(0)
                Dim _pcod As Integer = _data.Rows(i).Item("REFPACIENTE")
                Dim _mcod As Integer = GetPacienteRefMutua(_pcod)
                Dim cod As Integer = -1
                If tb_mutua.Text <> "" Then
                    cod = Integer.Parse(tb_mutua.Text.Trim())
                End If
                If mutuas.Contains(_mcod) Then
                    Dim index As Integer = mutuas.IndexOf(_mcod)
                    cant(index) = cant(index) + 1
                ElseIf _mcod = cod Then
                    mutuas.Add(_mcod)
                    cant(mutuas.Count - 1) = 1
                End If
            Next

            For i = 0 To _data.Rows.Count - 1
                cantp.Add(0)
                Dim _pcod As Integer = _data.Rows(i).Item("REFPACIENTE")
                Dim _mcod As Integer = GetPacienteRefMutua(_pcod)
                Dim j As Integer
                Dim cod As Integer = -1
                If tb_mutua.Text <> "" Then
                    cod = Integer.Parse(tb_mutua.Text.Trim())
                End If
                For j = 0 To pacientes.Count - 1

                    If pacientes(j) = _pcod And mutuasp(j) = _mcod And _mcod = cod Then
                        cantp(j) = cantp(j) + 1
                    End If
                Next
                If _mcod = cod Then
                    pacientes.Add(_pcod)
                    mutuasp.Add(_mcod)
                    cantp(pacientes.Count - 1) = 1
                End If
            Next

            For i = 0 To mutuas.Count - 1

                Dim _mutua As String = GetMutua(mutuas(i))
                dgv_mutuas.Rows.Add(mutuas(i), _mutua, cant(i))

            Next
            For i = 0 To pacientes.Count - 1

                Dim _nombre As String = GetPacienteNombre(pacientes(i))
                Dim apellido1 As String = GetPacienteApellido1(pacientes(i))
                Dim apellido2 As String = GetPacienteApellido2(pacientes(i))
                Dim _mutua As String = GetMutua(mutuas(i))
                dgv_mutuapac.Rows.Add(apellido1, apellido2, _nombre, mutuasp(i), _mutua, cantp(i))

            Next

        End If

        If tb_empresa.Text = "" Then
            dgv_empresa.Rows.Add("", "Sin empresa", "")
            dgv_empresapac.Rows.Add("", "", "", "", "Sin empresa", "")
        Else
            Dim empresa As ArrayList = New ArrayList()
            Dim cant As ArrayList = New ArrayList()
            Dim empresap As ArrayList = New ArrayList()
            Dim cantp As ArrayList = New ArrayList()
            Dim pacientes As ArrayList = New ArrayList()
            Dim cod As Integer = -1
            If tb_empresa.Text <> "" Then
                cod = Integer.Parse(tb_empresa.Text.Trim())
            End If
            For i = 0 To _data.Rows.Count - 1
                cant.Add(0)
                Dim _pcod As Integer = _data.Rows(i).Item("REFPACIENTE")
                Dim _mcod As Integer = GetPacienteRefEmpresa(_pcod)
                If empresa.Contains(_mcod) Then
                    Dim index As Integer = empresa.IndexOf(_mcod)
                    cant(index) = cant(index) + 1
                ElseIf _mcod = cod Then
                    empresa.Add(_mcod)
                    cant(empresa.Count - 1) = 1
                End If
            Next

            For i = 0 To _data.Rows.Count - 1
                cantp.Add(0)
                Dim _pcod As Integer = _data.Rows(i).Item("REFPACIENTE")
                Dim _mcod As Integer = GetPacienteRefEmpresa(_pcod)
                Dim j As Integer
                If tb_empresa.Text <> "" Then
                    cod = Integer.Parse(tb_empresa.Text.Trim())
                End If
                For j = 0 To pacientes.Count - 1
                    If pacientes(j) = _pcod And empresap(j) = _mcod And cod = _mcod Then
                        cantp(j) = cantp(j) + 1
                    End If
                Next
                If _mcod = cod Then
                    pacientes.Add(_pcod)
                    empresap.Add(_mcod)
                    cantp(pacientes.Count - 1) = 1
                End If
            Next

            For i = 0 To empresa.Count - 1

                Dim _empresa As String = GetEmpresa(empresa(i))
                dgv_empresa.Rows.Add(empresa(i), _empresa, cant(i))

            Next
            For i = 0 To pacientes.Count - 1

                Dim _nombre As String = GetPacienteNombre(pacientes(i))
                Dim apellido1 As String = GetPacienteApellido1(pacientes(i))
                Dim apellido2 As String = GetPacienteApellido2(pacientes(i))
                Dim _empresa As String = GetEmpresa(empresa(i))
                dgv_empresapac.Rows.Add(apellido1, apellido2, _nombre, empresap(i), _empresa, cantp(i))


            Next
        End If

        If imprimir = True Then


            imprimir = False
        End If
    End Sub

    Private Sub Citas_Por_Procedencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fi.Value = New Date(Date.Today.Year, 1, 1)
    End Sub

    Private Sub tb_mutua_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_mutua.Leave
        If tb_mutua.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_mutua.Text)
            Dim data As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_mutua.Text = GetMutua(_pcodo)
            Else
                tb_mutua.Text = ""
                tb_mutua.Focus()
                MessageBox.Show("No existe una mutua con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tb_empresa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_empresa.Leave
        If tb_empresa.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_empresa.Text)
            Dim data As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_empresa.Text = GetEmpresa(_pcodo)
            Else
                tb_empresa.Text = ""
                tb_empresa.Focus()
                MessageBox.Show("No existe una empresa con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        Me.bt_filtrar_Click(Nothing, Nothing)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class