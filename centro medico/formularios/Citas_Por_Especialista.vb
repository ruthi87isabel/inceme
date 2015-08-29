Imports centro_medico.UI.Reportes

Public Class Citas_Por_Especialista

    Dim imprimir As Boolean = False
    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub
    Sub New(ByVal lectura As Boolean)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim i As Integer
        'For i = 0 To Me.Controls.Count - 1
        ' Me.Controls(i).Enabled = False
        ' Next
        bt_cerrar.Enabled = True

    End Sub
    Private Sub Citas_Por_Especialista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_fi.Value = New Date(Date.Today.Year, 1, 1)
    End Sub
    Private Function GetMedico(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MEDICOSDataTable = Me.MEDICOSTableAdapter.GetMedicoByID(aId)
        Dim _medname As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _medapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Dim _medapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Dim _med As String = _medapellido1 + " " + _medapellido2 + " , " + _medname

        Return _med

    End Function

    Private Sub bt_medico1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_medico1.Click
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, MEDICOSBindingSource, RoleManager.Items.Medicos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_medico1.Text = _pcodo.ToString()
            lb_medico1.Text = GetMedico(_pcodo)

        End If
    End Sub

    Private Sub bt_medico2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_medico2.Click
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, MEDICOSBindingSource, RoleManager.Items.Medicos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_medico2.Text = _pcodo.ToString()
            lb_medico2.Text = GetMedico(_pcodo)

        End If
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Dim _resc As DataTable = New DataTable()

        _resc.Columns.Add("Código")
        _resc.Columns.Add("Médico")
        _resc.Columns.Add("Importe médico")
        _resc.Columns("Importe médico").DataType = GetType(Double)
        _resc.Columns.Add("Importe clínica")
        _resc.Columns("Importe clínica").DataType = GetType(Double)
        _resc.Columns.Add("Total")
        _resc.Columns("Total").DataType = GetType(Double)


        Dim fit As Date = dtp_fi.Value
        Dim fft As Date = dtp_ff.Value
        Dim fi As Date = New Date(fit.Year, fit.Month, fit.Day, 0, 0, 0)
        Dim ff As Date = New Date(fft.Year, fft.Month, fft.Day, 23, 59, 59)
        Dim idmed1 As Integer
        Dim idmed2 As Integer
        Dim idmed As Integer
        Dim med As String
        Dim imed As Single
        Dim iclinica As Single
        Dim itotal As Single

        Dim imedt As Single
        Dim iclinicat As Single
        Dim itotalt As Single
        Dim _datac As CMDataSet.CITASDataTable

        If tb_medico1.Text <> "" Then
            idmed1 = Integer.Parse(tb_medico1.Text.Trim())
        End If
        If tb_medico2.Text <> "" Then
            idmed2 = Integer.Parse(tb_medico2.Text.Trim())
        End If
        If tb_medico1.Text <> "" Then
            If tb_medico2.Text <> "" Then
                _datac = Me.CITASTableAdapter.GetCitaByEspecialista(fi, ff, idmed1, idmed2)
            Else
                _datac = Me.CITASTableAdapter.GetCitaByEspecialista(fi, ff, idmed1, 100000000)
            End If
        Else
            If tb_medico2.Text <> "" Then
                _datac = Me.CITASTableAdapter.GetCitaByEspecialista(fi, ff, 1, idmed2)
            Else
                _datac = Me.CITASTableAdapter.GetCitaByEspecialista(fi, ff, 1, 100000000)
            End If
        End If
        Dim i As Integer
        For i = 0 To _datac.Rows.Count - 1
            idmed = _datac.Rows(i).Item("REFMEDICO")
            med = GetMedico(idmed)

            If Not _datac(i).IsIMPORTEDRNull Then
                imed = _datac.Rows(i).Item("IMPORTEDR")
            Else
                imed = 0
            End If

            If Not _datac(i).IsIMPORTECLNull Then
                iclinica = _datac.Rows(i).Item("IMPORTECL")
            Else
                iclinica = 0
            End If

            Dim j As Integer
            For j = 0 To _resc.Rows.Count - 1
                If _resc.Rows(j).Item("Código") = idmed Then
                    Dim im As Single = _resc.Rows(j).Item("Importe médico")
                    Dim ic As Single = _resc.Rows(j).Item("Importe clínica")
                    _resc.Rows(j).Delete()
                    imed = imed + im
                    iclinica = iclinica + ic
                End If
            Next
            'Total Parcial de la fila del médico
            itotal = imed + iclinica

            'Totales Globales
            If Not _datac(i).IsIMPORTEDRNull Then
                imedt += _datac.Rows(i).Item("IMPORTEDR")
            End If

            If Not _datac(i).IsIMPORTECLNull Then
                iclinicat += _datac.Rows(i).Item("IMPORTECL")
            End If



            _resc.Rows.Add(idmed, med, imed, iclinica, itotal)
        Next
        'Total
        itotalt += imedt + iclinicat

        dgv_citas.DataSource = _resc
        Me.dgv_citas.Columns("Importe médico").DefaultCellStyle.Format = "C"
        Me.dgv_citas.Columns("Importe clínica").DefaultCellStyle.Format = "C"
        Me.dgv_citas.Columns("Total").DefaultCellStyle.Format = "C"
        lb_medico.Text = String.Format("{0:N}", (imedt)) + " €"
        lb_clinica.Text = String.Format("{0:N}", (iclinicat)) + " €"
        lb_total.Text = String.Format("{0:N}", (itotalt)) + " €"

        If imprimir = True Then
            Dim tipofiltro As String = ""

            Dim parametros(3) As Microsoft.Reporting.WinForms.ReportParameter
            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
            'Preparo el filtro para mostrarlo en el report
            tipofiltro = " Desde: " & Format(Me.dtp_fi.Value.Date, "dd-MM-yyyy") & " a " & Format(Me.dtp_ff.Value.Date, "dd-MM-yyyy")
            tipofiltro += " Codigo Med desde: " & Me.tb_medico1.Text & " " & Me.lb_medico1.Text.Trim & " hasta " & Me.tb_medico2.Text & " " & Me.lb_medico2.Text.Trim

            rpt.Name = "CMDataSet_rpt_CitasMedico"
            rpt.Value = _resc

          
            parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & tipofiltro)
            parametros(1) = New Microsoft.Reporting.WinForms.ReportParameter("ImporteMedico", lb_medico.Text.Trim)
            parametros(2) = New Microsoft.Reporting.WinForms.ReportParameter("ImporteClinica", lb_clinica.Text.Trim)
            parametros(3) = New Microsoft.Reporting.WinForms.ReportParameter("ImporteTotal", lb_total.Text.Trim)

            ReportesManager.Imprime("CitasIngresosPorMedico.rdlc", {rpt}, parametros)

            imprimir = False
        End If
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        'MessageBox.Show("Función no disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        imprimir = True
        Me.bt_filtrar_Click(Nothing, Nothing)
    End Sub

    Private Sub tb_medico1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_medico1.Leave
        If tb_medico1.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_medico1.Text)
            Dim data As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_pcodo)
            If data.Rows.Count > 0 Then
                lb_medico1.Text = GetMedico(_pcodo)
            Else
                tb_medico1.Text = ""
                tb_medico1.Focus()
                MessageBox.Show("No existe un médico con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tb_medico2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_medico2.Leave
        If tb_medico2.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_medico2.Text)
            Dim data As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_pcodo)
            If data.Rows.Count > 0 Then
                lb_medico2.Text = GetMedico(_pcodo)
            Else
                tb_medico2.Text = ""
                tb_medico2.Focus()
                MessageBox.Show("No existe un médico con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class