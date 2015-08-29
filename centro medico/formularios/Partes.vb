Public Class Partes

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
        '  For i = 0 To Me.Controls.Count - 1
        ' Me.Controls(i).Enabled = False
        'Next
        bt_cerrar.Enabled = True

    End Sub
    Private Sub chb_altasext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_altasext.CheckedChanged
        If chb_altasext.Checked = True Then
            chb_bajacalta.Checked = True
            chb_bajasalta.Checked = False
            chb_asist.Checked = False
        Else
            chb_bajacalta.Checked = False
            chb_bajasalta.Checked = True
            chb_asist.Checked = True
        End If
    End Sub
    Private Function GetPaciente(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
        Return _paciente

    End Function
    Private Function GetMutua(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(aId)
        Dim _mutua As String = _data.Rows(0).Item("NOMBRE").ToString()
        Return _mutua

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
            lb_paciente.Text = GetPaciente(_pcodo)
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

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        bt_imprimir.Enabled = True
        GetParte()
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub
    Private Sub GetParte(Optional ByVal Imprimir As Boolean = False)
        Dim _resc As DataTable = New DataTable()
        _resc.Columns.Add("Código")
        _resc.Columns.Add("Nro fact")
        _resc.Columns.Add("Cobrado")
        _resc.Columns.Add("Tipo")
        _resc.Columns.Add("F. Asistencia")
        _resc.Columns("F. Asistencia").DataType = GetType(Date)
        _resc.Columns.Add("F. Alta")
        _resc.Columns("F. Alta").DataType = GetType(Date)
        _resc.Columns.Add("F. Baja ")
        _resc.Columns("F. Baja ").DataType = GetType(Date)
        _resc.Columns.Add("Paciente")
        _resc.Columns.Add("Cód Paciente")
        _resc.Columns.Add("Cód Mutua")

        Dim fit As Date = dtp_fi.Value
        Dim fft As Date = dtp_ff.Value
        Dim fi As Date = New Date(fit.Year, fit.Month, fit.Day, 0, 0, 0)
        Dim ff As Date = New Date(fft.Year, fft.Month, fft.Day, 23, 59, 59)
        Dim idpac As Integer
        Dim pac As String
        If tb_idpaciente.Text <> "" Then
            idpac = Integer.Parse(tb_idpaciente.Text.Trim())
            pac = GetPaciente(idpac)

        Else
            idpac = 0
            pac = ""

        End If
        Dim idmutua As Integer
        If tb_mutua.Text <> "" Then
            idmutua = Integer.Parse(tb_mutua.Text.Trim())
        Else
            idmutua = 0
        End If
        Dim fecha As Date
        Dim numerofra As Integer
        Dim tipo As String
        Dim cobrado As String
        If chb_cobrado.Checked = True Then
            cobrado = "S"
        Else
            cobrado = "N"
        End If

        Dim _datac As CMDataSet.PARTESDataTable
        Dim _dataa As CMDataSet.PARTESDataTable
        Dim _datat As CMDataSet.PARTESDataTable
        Dim _c As Boolean = False
        Dim _a As Boolean = False
        Dim _t As Boolean = False

        If tb_idpaciente.Text <> "" And tb_mutua.Text <> "" And chb_bajacalta.Checked = False And chb_bajasalta.Checked = False And chb_asist.Checked = False Then
            _datac = PARTESTableAdapter.GetParteByMutuaPaciente(idmutua, idpac, fi, ff)
            _c = True
        ElseIf tb_idpaciente.Text <> "" And tb_mutua.Text = "" And chb_bajacalta.Checked = False And chb_bajasalta.Checked = False And chb_asist.Checked = False Then
            _datac = PARTESTableAdapter.GetParteByPaciente(idpac, fi, ff)
            _c = True
        ElseIf tb_idpaciente.Text <> "" And tb_mutua.Text = "" And chb_bajacalta.Checked = False And chb_bajasalta.Checked = False And chb_asist.Checked = False Then
            _datac = PARTESTableAdapter.GetParteByMutua(idmutua, fi, ff)
            _c = True
        ElseIf tb_idpaciente.Text <> "" And tb_mutua.Text <> "" Then
            If chb_bajacalta.Checked = True Then
                _a = True
                _dataa = PARTESTableAdapter.GetParteByMutuaPacienteTipo(idmutua, idpac, "A", fi, ff)
            End If
            If chb_bajasalta.Checked = True Then
                _c = True
                _datac = PARTESTableAdapter.GetParteByMutuaPacienteTipo(idmutua, idpac, "B", fi, ff)
            End If
            If chb_asist.Checked = True Then
                _t = True
                _datat = PARTESTableAdapter.GetParteByMutuaPacienteTipo(idmutua, idpac, "S", fi, ff)
            End If
        ElseIf tb_idpaciente.Text = "" And tb_mutua.Text <> "" Then
            If chb_bajacalta.Checked = True Then
                _a = True
                _dataa = PARTESTableAdapter.GetParteByMutuaTipo(idmutua, "A", fi, ff)
            End If
            If chb_bajasalta.Checked = True Then
                _c = True
                _datac = PARTESTableAdapter.GetParteByMutuaTipo(idmutua, "B", fi, ff)
            End If
            If chb_asist.Checked = True Then
                _t = True
                _datat = PARTESTableAdapter.GetParteByMutuaTipo(idmutua, "S", fi, ff)
            End If
        ElseIf tb_idpaciente.Text <> "" And tb_mutua.Text = "" Then
            If chb_bajacalta.Checked = True Then
                _a = True
                _dataa = PARTESTableAdapter.GetParteByPacienteTipo(idpac, "A", fi, ff)
            End If
            If chb_bajasalta.Checked = True Then
                _c = True
                _datac = PARTESTableAdapter.GetParteByPacienteTipo(idpac, "B", fi, ff)
            End If
            If chb_asist.Checked = True Then
                _t = True
                _datat = PARTESTableAdapter.GetParteByPacienteTipo(idpac, "S", fi, ff)
            End If
        ElseIf tb_idpaciente.Text = "" And tb_mutua.Text = "" Then
            If chb_bajacalta.Checked = True Then
                _a = True
                _dataa = PARTESTableAdapter.GetParteByTipo("A", fi, ff)
            End If
            If chb_bajasalta.Checked = True Then
                _c = True
                _datac = PARTESTableAdapter.GetParteByTipo("B", fi, ff)
            End If
            If chb_asist.Checked = True Then
                _t = True
                _datat = PARTESTableAdapter.GetParteByTipo("S", fi, ff)
            End If
        End If
        Dim i As Integer
        Dim id As Integer
        If _c = True Then
            For i = 0 To _datac.Rows.Count - 1
                id = _datac.Rows(i).Item("IDPARTE")
                fecha = _datac.Rows(i).Item("FECHA")
                numerofra = _datac.Rows(i).Item("REFFRA")
                idpac = _datac.Rows(i).Item("REFPACIENTE")
                pac = _datac.Rows(i).Item("PACIENTE")
                idmutua = _datac.Rows(i).Item("REFMUTUA")
                Dim fra As String
                If numerofra = 1 Or numerofra = 0 Then
                    fra = ""
                    cobrado = "N"
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then
                        Continue For
                    ElseIf chb_sinfacturar.Checked = True Then

                    End If
                    If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                    ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                        Continue For
                    ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                        Continue For
                    End If



                Else
                    fra = numerofra.ToString()
                    Dim _data As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaById(fra)
                    cobrado = _data.Rows(0).Item("PAGADA")
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then

                    ElseIf chb_sinfacturar.Checked = True Then
                        Continue For
                    End If

                End If

                If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                    Continue For
                ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                    Continue For
                End If
                tipo = _datac.Rows(i).Item("TIPO")
                If tipo = "A" And chb_altasext.Checked = True Then
                    Dim _dataparte As CMDataSet.ALTASDataTable = ALTASTableAdapter.GetAltaByParte(id)
                    Dim externa As String = _dataparte.Rows(0).Item("CAUSA")
                    If externa <> "Alta externa" Then
                        Continue For
                    End If
                End If
                If tipo = "B" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, DBNull.Value, fecha, pac, idpac, idmutua)
                ElseIf tipo = "A" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, fecha, DBNull.Value, pac, idpac, idmutua)
                Else
                    _resc.Rows.Add(id, fra, cobrado, tipo, fecha, DBNull.Value, DBNull.Value, pac, idpac, idmutua)
                End If
            Next
        End If
        If _a = True Then
            For i = 0 To _dataa.Rows.Count - 1
                id = _dataa.Rows(i).Item("IDPARTE")
                fecha = _dataa.Rows(i).Item("FECHA")
                numerofra = _dataa.Rows(i).Item("REFFRA")
                idpac = _dataa.Rows(i).Item("REFPACIENTE")
                pac = _dataa.Rows(i).Item("PACIENTE")
                idmutua = _dataa.Rows(i).Item("REFMUTUA")
                Dim fra As String
                If numerofra = 1 Or numerofra = 0 Then
                    fra = ""
                    cobrado = "N"
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then
                        Continue For
                    ElseIf chb_sinfacturar.Checked = True Then

                    End If
                    If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                    ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                        Continue For
                    ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                        Continue For
                    End If

                Else
                    fra = numerofra.ToString()
                    Dim _data As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaById(fra)
                    cobrado = _data.Rows(0).Item("PAGADA")
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then

                    ElseIf chb_sinfacturar.Checked = True Then
                        Continue For
                    End If

                End If

                If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                    Continue For
                ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                    Continue For
                End If

                tipo = _dataa.Rows(i).Item("TIPO")
                If tipo = "A" And chb_altasext.Checked = True Then
                    Dim _dataparte As CMDataSet.ALTASDataTable = ALTASTableAdapter.GetAltaByParte(id)
                    Dim externa As String = _dataparte.Rows(0).Item("CAUSA")
                    If externa <> "Alta externa" Then
                        Continue For
                    End If
                End If
                If tipo = "B" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, DBNull.Value, fecha, pac, idpac, idmutua)
                ElseIf tipo = "A" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, fecha, DBNull.Value, pac, idpac, idmutua)
                Else
                    _resc.Rows.Add(id, fra, cobrado, tipo, fecha, DBNull.Value, DBNull.Value, pac, idpac, idmutua)
                End If
            Next
        End If
        If _t = True Then
            For i = 0 To _datat.Rows.Count - 1
                id = _datat.Rows(i).Item("IDPARTE")
                fecha = _datat.Rows(i).Item("FECHA")
                numerofra = _datat.Rows(i).Item("REFFRA")
                idpac = _datat.Rows(i).Item("REFPACIENTE")
                pac = _datat.Rows(i).Item("PACIENTE")
                idmutua = _datat.Rows(i).Item("REFMUTUA")
                Dim fra As String
                If numerofra = 1 Or numerofra = 0 Then
                    fra = ""
                    cobrado = "N"
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then
                        Continue For
                    ElseIf chb_sinfacturar.Checked = True Then

                    End If
                    If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                    ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                        Continue For
                    ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                        Continue For
                    End If
                Else
                    fra = numerofra.ToString()
                    Dim _data As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaById(fra)
                    cobrado = _data.Rows(0).Item("PAGADA")
                    If chb_facturado.Checked = True And chb_sinfacturar.Checked = True Then
                    ElseIf chb_facturado.Checked = True Then

                    ElseIf chb_sinfacturar.Checked = True Then
                        Continue For
                    End If

                End If

                If chb_cobrado.Checked = True And chb_sincobrar.Checked = True Then

                ElseIf chb_cobrado.Checked = True And cobrado = "N" Then
                    Continue For
                ElseIf chb_sincobrar.Checked = True And cobrado = "S" Then
                    Continue For
                End If

                tipo = _datat.Rows(i).Item("TIPO")
                If tipo = "A" And chb_altasext.Checked = True Then
                    Dim _dataparte As CMDataSet.ALTASDataTable = ALTASTableAdapter.GetAltaByParte(id)
                    Dim externa As String = _dataparte.Rows(0).Item("CAUSA")
                    If externa <> "Alta externa" Then
                        Continue For
                    End If
                End If
                If tipo = "B" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, DBNull.Value, fecha, pac, idpac, idmutua)
                ElseIf tipo = "A" Then
                    _resc.Rows.Add(id, fra, cobrado, tipo, DBNull.Value, fecha, DBNull.Value, pac, idpac, idmutua)
                Else
                    _resc.Rows.Add(id, fra, cobrado, tipo, fecha, DBNull.Value, DBNull.Value, pac, idpac, idmutua)
                End If
            Next
        End If

        dgv_partes.DataSource = _resc
        dgv_partes.Columns("Código").Visible = False

        If Imprimir = True Then
            Dim tipofiltro As String = ""

            Dim ii As Integer = 0
            Dim listacampos As String = ""
            'Dim fichero As String = Rutaimpresion & "/ListadoPartes.rdlc"
            Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
            'Preparo el filtro para mostrarlo en el report
            If Me.chb_bajacalta.Checked Then tipofiltro += " Bajas con Alta "
            If Me.chb_bajasalta.Checked Then tipofiltro += " Bajas sin Alta "
            If Me.chb_asist.Checked Then tipofiltro += " Asistencia "
            If Me.chb_facturado.Checked Then tipofiltro += " Facturado "
            If Me.chb_sinfacturar.Checked Then tipofiltro += " Sin Facturar "
            If Me.chb_cobrado.Checked Then tipofiltro += " Cobrado "
            If Me.chb_sincobrar.Checked Then tipofiltro += " Sin cobrar "
            If Me.tb_mutua.Text.Trim.Length > 0 Then tipofiltro += " Mútua = " & Me.lb_mutua.Text.Trim
            If Me.tb_idpaciente.Text.Trim.Length > 0 Then tipofiltro += " Paciente = " & Me.lb_paciente.Text.Trim
            If Me.chb_altasext.Checked Then tipofiltro += " Altas Externas "

            'rpt.Name = "CMDataSet_rpt_ListadoPartes"
            rpt.Name = "CM3DataSet_N_Partes"
            rpt.Value = _resc

            parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & tipofiltro)

            UI.Reportes.ReportesManager.Imprime("PartesBajaAltaListado.rdlc", {rpt}, parametros)

        End If
    End Sub

    Private Sub tb_idpaciente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idpaciente.Leave
        If tb_idpaciente.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_idpaciente.Text)
            Dim data As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_paciente.Text = GetPaciente(_pcodo)
            Else
                tb_idpaciente.Text = ""
                tb_idpaciente.Focus()
                MessageBox.Show("No existe un paciente con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        Me.GetParte(True)
    End Sub

   
End Class