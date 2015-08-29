Public Class Recibos

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
        '  For i = 0 To Me.Controls.Count - 1
        ' Me.Controls(i).Enabled = False
        'Next
        bt_cerrar.Enabled = True

    End Sub
    Private Sub chb_emision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_emision.CheckedChanged
        If chb_emision.Checked = True Then
            dtp_fi.Enabled = True
            dtp_ff.Enabled = True
        Else
            dtp_fi.Enabled = False
            dtp_ff.Enabled = False
        End If
    End Sub

    Private Sub chb_cobro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_cobro.CheckedChanged
        If chb_cobro.Checked = True Then
            dtp_fci.Enabled = True
            dtp_fcf.Enabled = True
        Else
            dtp_fci.Enabled = False
            dtp_fcf.Enabled = False
        End If
    End Sub

    Private Sub chb_concepto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_concepto.CheckedChanged
        If chb_concepto.Checked = True Then
            tb_concepto.Enabled = True
        Else
            tb_concepto.Enabled = True
            tb_concepto.Clear()
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
    Private Function GetFormaPago(ByVal aId As String) As String

        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(aId)
        Dim _forma As String = _data.Rows(0).Item("DESCRIPCION").ToString()
        Return _forma

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
    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Dim _resc As DataTable = New DataTable()
        Dim tipofiltro As String = ""
       
        _resc.Columns.Add("Número")
        _resc.Columns.Add("Importe")
        _resc.Columns("Importe").DataType = GetType(Double)
        _resc.Columns.Add("Concepto")
        _resc.Columns.Add("Nombre")
        _resc.Columns.Add("F. Cobro")
        _resc.Columns("F. Cobro").DataType = GetType(Date)
        _resc.Columns.Add("F. Emisión")
        _resc.Columns("F. Emisión").DataType = GetType(Date)

        Dim fi As Date
        Dim ff As Date
        If chb_emision.Checked = True Then
            Dim fit As Date = dtp_fi.Value
            Dim fft As Date = dtp_ff.Value
            fi = New Date(fit.Year, fit.Month, fit.Day, 0, 0, 0)
            ff = New Date(fft.Year, fft.Month, fft.Day, 23, 59, 59)
        End If

        Dim fci As Date
        Dim fcf As Date
        If chb_emision.Checked = True Then
            Dim fit As Date = dtp_fi.Value
            Dim fft As Date = dtp_ff.Value
            fci = New Date(fit.Year, fit.Month, fit.Day, 0, 0, 0)
            fcf = New Date(fft.Year, fft.Month, fft.Day, 23, 59, 59)
        End If

        Dim idpac As Integer
        Dim pac As String
        If tb_idpaciente.Text <> "" Then
            idpac = Integer.Parse(tb_idpaciente.Text.Trim())
            pac = GetPaciente(idpac)

        Else
            idpac = 0
            pac = ""

        End If

        Dim idfp As String
        Dim fp As String
        If tb_idforma.Text <> "" Then
            idfp = tb_idforma.Text.Trim()
            fp = GetFormaPago(idfp)

        Else
            idfp = ""
            fp = ""

        End If

        Dim concepto As String = ""
        If chb_concepto.Checked = True Then
            concepto = tb_concepto.Text.Trim()
        End If

        Dim cobrada As Boolean
        If rb_cobrados.Checked = True Then
            cobrada = True
        ElseIf rb_scobrar.Checked = True Then
            cobrada = False
        End If

        Dim importe As Single = 0
        Dim _datac As CMDataSet.RECIBOSDataTable
        If chb_emision.Checked = True And chb_cobro.Checked = True And tb_idpaciente.Text <> "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFormaFemisionCobro(idpac, idfp, fi, ff, fci, fcf)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = True And tb_idpaciente.Text <> "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFemisionCobro(idpac, fi, ff, fci, fcf)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = True And tb_idpaciente.Text = "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFormaFemisionCobro(idfp, fi, ff, fci, fcf)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = True And tb_idpaciente.Text = "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFEmisionCobro(fi, ff, fci, fcf)

        ElseIf chb_emision.Checked = True And chb_cobro.Checked = False And tb_idpaciente.Text <> "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFormaFemision(idpac, idfp, fi, ff)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = False And tb_idpaciente.Text <> "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFemision(idpac, fi, ff)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = False And tb_idpaciente.Text = "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFormaFemision(idfp, fi, ff)
        ElseIf chb_emision.Checked = True And chb_cobro.Checked = False And tb_idpaciente.Text = "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFEmision(fi, ff)

        ElseIf chb_emision.Checked = False And chb_cobro.Checked = True And tb_idpaciente.Text <> "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFormaFCobro(idpac, idfp, fci, fcf)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = True And tb_idpaciente.Text <> "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacFCobro(idpac, fci, fcf)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = True And tb_idpaciente.Text = "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFormaFCobro(idfp, fci, fcf)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = True And tb_idpaciente.Text = "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByFCobro(fci, fcf)

        ElseIf chb_emision.Checked = False And chb_cobro.Checked = False And tb_idpaciente.Text <> "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPacForma(idpac, idfp)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = False And tb_idpaciente.Text <> "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetReciboByPac(idpac)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = False And tb_idpaciente.Text = "" And tb_idforma.Text <> "" Then
            _datac = RECIBOSTableAdapter.GetReciboByForma(idfp)
        ElseIf chb_emision.Checked = False And chb_cobro.Checked = False And tb_idpaciente.Text = "" And tb_idforma.Text = "" Then
            _datac = RECIBOSTableAdapter.GetData()
        End If

        Dim i As Integer
        For i = 0 To _datac.Rows.Count - 1
            Dim numero As Integer = _datac.Rows(i).Item("NUMERO")
            Dim nombre As String = _datac.Rows(i).Item("NOMBRE").ToString()
            Dim pagada As String = _datac.Rows(i).Item("COBRADO").ToString()

            Dim importec As Single = _datac.Rows(i).Item("IMPORTE")
            Dim fEmision As Date
            If _datac.Rows(i).Item("FECHAEMISION").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
                fEmision = _datac.Rows(i).Item("FECHAEMISION")
            Else
                fEmision = Date.Now
            End If

            Dim fCobro As Date
            If _datac.Rows(i).Item("FECHACOBRO").GetType.ToString() <> DBNull.Value.GetType.ToString() Then
                fCobro = _datac.Rows(i).Item("FECHACOBRO")
            Else
                fCobro = Date.Now
            End If
            If rb_cobrados.Checked = True And pagada = "N" Then
                Continue For
            ElseIf rb_scobrar.Checked = True And pagada = "S" Then
                Continue For
            End If
            Dim concept As String = ""
            If Not _datac.Rows(i).Item("CONCEPTO").GetType Is GetType(DBNull) Then
                concept = _datac.Rows(i).Item("CONCEPTO").ToString()
            End If
            If chb_concepto.Checked = True Then
                If concept <> concepto Then
                    Continue For
                End If
            End If
            'Ver como Dayron trata las fechas que no estan por ejemplo para fecha de cobro
            _resc.Rows.Add(numero, importec, concept, nombre, fCobro, fEmision)
            importe = importe + importec
        Next
        dgv_recibos.DataSource = _resc
        dgv_recibos.Columns("Importe").DefaultCellStyle.Format = "C"
        dgv_recibos.Columns("F. Cobro").DefaultCellStyle.Format = "d"
        dgv_recibos.Columns("F. Emisión").DefaultCellStyle.Format = "d"

        lb_importe.Text = String.Format("{0:N}", (importe)) + " €"
        If imprimir = True Then
            tipofiltro = ""
            Dim ii As Integer = 0
            Dim listacampos As String = ""

            Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
            'Preparo el filtro para mostrarlo en el report
            If Me.chb_emision.Checked Then
                tipofiltro += " Fecha Emisión desde: " & Me.dtp_fi.Value.Date & " a " & Me.dtp_ff.Value.Date
            End If
            If Me.chb_cobro.Checked Then
                tipofiltro += " Fecha Cobro desde: " & Me.dtp_fci.Value.Date & " a " & Me.dtp_fcf.Value.Date
            End If

            If Me.rb_todos.Checked Then
                tipofiltro += " Cobrados y Sin Cobrar "
            End If
            If Me.rb_cobrados.Checked Then
                tipofiltro += " Cobrados "
            End If
            If Me.rb_scobrar.Checked Then
                tipofiltro += " Sin Cobrar "
            End If

            If Me.tb_idpaciente.Text.Trim.Length > 0 Then
                tipofiltro += " Paciente: " & Me.lb_paciente.Text.Trim
            End If

            If Me.tb_idforma.Text.Trim.Length > 0 Then
                tipofiltro += " F. Pago: " & Me.lb_forma.Text.Trim
            End If
            If Me.chb_concepto.Checked Then
                tipofiltro += " Concepto: " & Me.tb_concepto.Text
            End If

            rpt.Name = "CMDataSet_rpt_ListadoRecibos"
            rpt.Value = _resc


            parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & tipofiltro)

            UI.Reportes.ReportesManager.Imprime("RecibosListado.rdlc", {rpt}, parametros)
            imprimir = False
        End If
    End Sub

    Private Sub Recibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        imprimir = True
        Me.bt_filtrar_Click(Nothing, Nothing)
    End Sub
End Class