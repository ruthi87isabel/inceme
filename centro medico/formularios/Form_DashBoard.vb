Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form_DashBoard

    Dim _source As CMLinqDataContext
    Dim dView1 As DataView
    Dim dView11 As DataView
    Dim dView2 As DataView
    Dim dView21 As DataView
    Dim dView3 As DataView
    Dim dView4 As DataView
    Dim dView5 As DataView
    Dim dView6 As DataView
    Dim dView61 As DataView


    Private Sub Form_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '***Permisos***
        bImprimir.Enabled = (UiTabPage1.TabVisible Or UiTabPage2.TabVisible Or UiTabPage3.TabVisible Or UiTabPage4.TabVisible Or UiTabPage5.TabVisible Or UiTabPage6.TabVisible)
        UiTabPage1.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Cistas_por_estado) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage2.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage3.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage4.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage5.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage6.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        ClassInizializaDashBoard()

    End Sub

    Private Sub ClassInizializaDashBoard()

        GroupBox1.Visible = False
        TextBox6.Enabled = False


        Dim rtn As New Date
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 1)

        '***Citas del día por estado***
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable1 = Me.CitasDiariasTableAdapter1.GetData
        DataGridView1.DataSource = dTable1
        dView1 = dTable1.DefaultView

        Dim dTable11 As New CM2DataSet.Grafic1DataTable
        dTable11 = Me.Grafic1TableAdapter.GetData()
        dView11 = dTable11.DefaultView
        Chart3.DataSource = dTable11
        Chart3.ChartAreas(0).AxisX.LineWidth = 0
        Chart3.ChartAreas(0).AxisY.LineWidth = 0

        Dim row1 As DataRow = dTable11.Rows(0)
        Dim confir As String = row1.Item("CONFIRMADA").ToString
        Dim atend As String = row1.Item("ATENDIDO").ToString
        Dim anul As String = row1.Item("ANULADA").ToString
        Dim paga As String = row1.Item("PAGADA").ToString
        Chart7.Series.Clear()
        Chart7.Series.Add("Serie1")
        Chart7.Series("Serie1").ChartType = SeriesChartType.Pie
        Chart7.Series("Serie1").Points.AddXY("CONFIRMADA", confir)
        Chart7.Series("Serie1").Points.AddXY("ATENDIDO", atend)
        Chart7.Series("Serie1").Points.AddXY("ANULADA", anul)
        Chart7.Series("Serie1").Points.AddXY("PAGADA", paga)
        Chart7.Series("Serie1").IsValueShownAsLabel = False
        'Chart7.Series("Serie1")("PieLabelStyle") = "Disabled"
        For Each dp As DataPoint In Chart7.Series("Serie1").Points
            dp.IsValueShownAsLabel = True
            If dp.YValues(0) = 0 Then
                dp.IsValueShownAsLabel = False
            End If
        Next


            '***Nuevos Pacientes/Mes***
            DateTimePicker1.Value = rtn
            DateTimePicker1.MaxDate = Date.Now
            DateTimePicker2.MaxDate = Date.Now

            Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
            dTable2 = Me.PacientesAltaTableAdapter1.GetData(0, "", DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            DataGridView2.DataSource = dTable2
            dView2 = dTable2.DefaultView

            Dim dTable21 As New CM2DataSet.Grafic2DataTable
            dTable21 = Me.Grafic2TableAdapter.GetData(1, DateTimePicker2.Value.Year, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            dView21 = dTable21.DefaultView
            Chart2.DataSource = dTable21
            Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & DateTimePicker2.Value.Year & ")"

            '***Citas atendidas por Médico/Día***
            DateTimePicker3.Value = rtn
            DateTimePicker3.MaxDate = Date.Now
            DateTimePicker4.MaxDate = Date.Now

            Dim dTable3 As New CM2DataSet.MedicoCitasDataTable
            dTable3 = Me.MedicoCitasTableAdapter1.GetData(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
            DataGridView3.DataSource = dTable3
            dView3 = dTable3.DefaultView

            Dim dTable31 As New CM2DataSet.Grafic3DataTable
            dTable31 = Me.Grafic3TableAdapter1.GetData(DateTimePicker4.Value.Date)
            Chart4.DataSource = dTable31
            Chart4.Titles.Item(0).Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.Date & ")"

            '**Citas por Especialidad/Mes***
            DateTimePicker5.Value = rtn
            DateTimePicker5.MaxDate = Date.Now
            DateTimePicker6.MaxDate = Date.Now

            Dim dTable4 As New CM2DataSet.EspecialidadCitasDataTable
            dTable4 = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
            DataGridView4.DataSource = dTable4
            dView4 = dTable4.DefaultView

            Dim dTable41 As New CM2DataSet.EspecialidadCitasDataTable
            dTable41 = Me.EspecialidadCitasTableAdapter1.GetDataBy(DateTimePicker6.Value.Date)
            Chart5.DataSource = dTable41
        Chart5.Titles.Item(0).Text = "Citas Mensuales por Especialidad (" & DateTimePicker6.Value.Date.Month & " / " & DateTimePicker6.Value.Date.Year & ")"

            '***Top 10 Tratamientos/Mes***
            DateTimePicker7.Value = rtn
            DateTimePicker7.MaxDate = Date.Now
            DateTimePicker8.MaxDate = Date.Now

            Dim dTable5 As New CM2DataSet.Top10_TratamientoDataTable
            dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)
            DataGridView5.DataSource = dTable5
            dView5 = dTable5.DefaultView

            Dim dTable51 As New CM2DataSet.Top10_TratamientoDataTable
            dTable51 = Me.Top10_TratamientoTableAdapter1.GetDataBy(DateTimePicker8.Value.Date)
            Chart6.DataSource = dTable51
        Chart6.Titles.Item(0).Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.Date.Month.ToString & " / " & DateTimePicker8.Value.Date.Year & ")"

            '***Estadistico Dental***
            DateTimePicker9.Value = rtn
            DateTimePicker9.MaxDate = Date.Now
            DateTimePicker10.MaxDate = Date.Now

            Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
            dTable6 = Me.EstadistDentalTableAdapter1.GetData(DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
            DataGridView6.DataSource = dTable6
            dView6 = dTable6.DefaultView

            Dim dTable61 As New CM2DataSet.EstadistDentalDataTable
            dTable61 = Me.EstadistDentalTableAdapter1.GetDataBy(DateTimePicker10.Value.Date)
            dView61 = dTable61.DefaultView
            Chart1.DataSource = dView61
            Chart1.Titles.Item(0).Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"

    End Sub

    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click

        Dim dTable As New CM2DataSet.CitasDiariasDataTable
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable = Me.CitasDiariasTableAdapter1.GetData

        Dim paciente As String = ""
        Dim medico As String = ""
        Dim paciente1 As String = ""
        Dim medico1 As String = ""
        Dim conf As String = ""
        Dim atend As String = ""
        Dim anul As String = ""
        Dim pag As String = ""

        Dim hora As String = ""
        Dim citas As String = ""
        Dim espec As String = ""

        If TextBox1.Text.Length > 0 Then paciente = TextBox1.Text
        If TextBox2.Text.Length > 0 Then medico = TextBox2.Text

        For Each row As DataRow In dTable.Rows
            paciente1 = row.Item("PACIENTE")
            medico1 = row.Item("MEDICO")
            espec = row.Item("ESPECIALIDAD")
            conf = row.Item("CONFIRMADA")
            atend = row.Item("ATENDIDO")
            anul = row.Item("ANULADA")
            pag = row.Item("PAGADA")
            hora = row.Item("HORARIO")



            If paciente1.ToLower().Contains(paciente.ToLower()) And
               medico1.ToLower().Contains(medico.ToLower()) And
               ((CheckBox1.Checked = True And conf = "Si") Or (CheckBox1.Checked = False)) And
               ((CheckBox2.Checked = True And atend = "Si") Or (CheckBox2.Checked = False)) And
               ((CheckBox3.Checked = True And anul = "Si") Or (CheckBox3.Checked = False)) And
               ((CheckBox4.Checked = True And pag = "Si") Or (CheckBox4.Checked = False)) Then
                dTable1.Rows.Add(hora, paciente1, medico1, espec, conf, atend, anul, pag)
            End If

        Next
        DataGridView1.DataSource = dTable1
        dView1 = dTable1.DefaultView

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mindate1 As New Date
        mindate1 = DateTimePicker1.Value.Date
        Dim num As String = TextBox6.Text
        Dim Anual As Integer = 0
        If num = "" Then
            num = "1"
        End If
        If CheckBox5.Checked Then
            If num.Length < 4 Or Convert.ToInt16(num) < 2005 Or Convert.ToInt16(num) > Date.Now.Year Then
                MsgBox("El año introducido no es válido", vbExclamation)
            Else
                Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
                dTable2 = Me.PacientesAltaTableAdapter1.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                DataGridView2.DataSource = dTable2
                dView2 = dTable2.DefaultView

                Anual = 1
                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                dView21 = dTable21.DefaultView
                Chart2.DataSource = dTable21
                Chart2.DataBind()
                Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & num & ")"
            End If
        Else
            If DateTimePicker1.Value > DateTimePicker2.Value Then
                DateTimePicker1.Focus()
                MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
            Else
                If DateTimePicker1.Value.Year < DateTimePicker2.Value.Year Then
                    mindate1 = New DateTime(DateTimePicker2.Value.Year, 1, 1)
                End If

                Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
                dTable2 = Me.PacientesAltaTableAdapter1.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                DataGridView2.DataSource = dTable2
                dView2 = dTable2.DefaultView

                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, mindate1, DateTimePicker2.Value.Date)
                dView21 = dTable21.DefaultView
                Chart2.DataSource = dTable21
                Chart2.DataBind()
                Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & DateTimePicker2.Value.Year & ")"

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim medico As String = ""
        Dim medico1 As String = ""
        Dim fecha As String = ""
        Dim cit As String = ""
        Dim espec As String = ""

        If DateTimePicker3.Value > DateTimePicker4.Value Then

            DateTimePicker3.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else

            If TextBox3.Text.Length > 0 Then medico = TextBox3.Text

            Dim dTable As New CM2DataSet.MedicoCitasDataTable
            Dim dTable1 As New CM2DataSet.MedicoCitasDataTable
            dTable = Me.MedicoCitasTableAdapter1.GetData(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)

            For Each row As DataRow In dTable.Rows
                fecha = row.Item("FECHA")
                medico1 = row.Item("MEDICO")
                espec = row.Item("ESPECIALIDAD")
                cit = row.Item("CantCitas")

                If medico1.ToLower().Contains(medico.ToLower()) Then
                    dTable1.Rows.Add(fecha, medico1, espec, cit)
                End If
            Next

            DataGridView3.DataSource = dTable1
            dView3 = dTable1.DefaultView

            Dim dTable31 As New CM2DataSet.Grafic3DataTable
            dTable31 = Me.Grafic3TableAdapter1.GetData(DateTimePicker4.Value.Date)
            Chart4.DataSource = dTable31
            Chart4.DataBind()
            Chart4.Titles.Item(0).Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.Date & ")"

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim espec As String = ""
        Dim espec1 As String = ""
        Dim fecha As String = ""
        Dim cit As String = ""

        If DateTimePicker5.Value > DateTimePicker6.Value Then

            DateTimePicker5.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else

            If TextBox4.Text.Length > 0 Then espec = TextBox4.Text

            Dim dTable As New CM2DataSet.EspecialidadCitasDataTable
            Dim dTable1 As New CM2DataSet.EspecialidadCitasDataTable
            dTable = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)

            For Each row As DataRow In dTable.Rows
                fecha = row.Item("FECHA")
                espec1 = row.Item("ESPECIALIDAD")
                cit = row.Item("CantCitas")

                If espec1.ToLower().Contains(espec.ToLower()) Then
                    dTable1.Rows.Add(fecha, espec1, cit)
                End If
            Next

            DataGridView4.DataSource = dTable1
            dView4 = dTable1.DefaultView

            Dim dTable41 As New CM2DataSet.EspecialidadCitasDataTable
            dTable41 = Me.EspecialidadCitasTableAdapter1.GetDataBy(DateTimePicker6.Value.Date)
            Chart5.DataSource = dTable41
            Chart5.DataBind()
            Chart5.Titles.Item(0).Text = "Citas Mensuales por Especialidad (" & DateTimePicker6.Value.Date.Month.ToString & " / " & DateTimePicker6.Value.Date.Year & ")"

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim trat As String = ""
        Dim trat1 As String = ""
        Dim fecha As String = ""
        Dim cant As String = ""

        If DateTimePicker7.Value > DateTimePicker8.Value Then

            DateTimePicker7.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else

            If TextBox5.Text.Length > 0 Then trat = TextBox5.Text

            Dim dTable As New CM2DataSet.Top10_TratamientoDataTable
            Dim dTable1 As New CM2DataSet.Top10_TratamientoDataTable
            dTable = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)

            For Each row As DataRow In dTable.Rows
                fecha = row.Item("FECHA")
                trat1 = row.Item("Tratamiento")
                cant = row.Item("CantTratamientos")

                If trat1.ToLower().Contains(trat.ToLower()) Then
                    dTable1.Rows.Add(fecha, trat1, cant)
                End If
            Next

            DataGridView5.DataSource = dTable1
            dView5 = dTable1.DefaultView

            Dim dTable51 As New CM2DataSet.Top10_TratamientoDataTable
            dTable51 = Me.Top10_TratamientoTableAdapter1.GetDataBy(DateTimePicker8.Value.Date)
            Chart6.DataSource = dTable51
            Chart6.DataBind()
            Chart6.Titles.Item(0).Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.Date.Month.ToString & " / " & DateTimePicker8.Value.Date.Year & ")"

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button5.Click

        If DateTimePicker9.Value > DateTimePicker10.Value Then

            DateTimePicker9.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else

            Dim dTable As New CM2DataSet.EstadistDentalDataTable
            dTable = Me.EstadistDentalTableAdapter1.GetData(DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
            DataGridView6.DataSource = dTable
            dView6 = dTable.DefaultView

            Dim dTable61 As New CM2DataSet.EstadistDentalDataTable
            dTable61 = Me.EstadistDentalTableAdapter1.GetDataBy(DateTimePicker10.Value.Date)
            dView61 = dTable61.DefaultView
            Chart1.DataSource = dTable61
            Chart1.DataBind()
            Chart1.Titles.Item(0).Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"


        End If
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        If UiTabPage1.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet1"
            rpt.Value = dView11

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView1

            UI.Reportes.ReportesManager.Imprime("R1_CitasXEstado.rdlc", {rpt, rpt1})

        End If

        If UiTabPage2.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet1"
            rpt.Value = dView21

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView2

            UI.Reportes.ReportesManager.Imprime("R2_PacientesAltaXMes.rdlc", {rpt, rpt1})

        End If

        If UiTabPage3.Selected Then

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView3

            UI.Reportes.ReportesManager.Imprime("R3_CitasAtendidasMedicosXDias.rdlc", {rpt1})

        End If

        If UiTabPage4.Selected Then

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView4

            UI.Reportes.ReportesManager.Imprime("R4_CitasEspecialidadXMes.rdlc", {rpt1})

        End If

        If UiTabPage5.Selected Then

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView5

            UI.Reportes.ReportesManager.Imprime("R5_Top10TratamientosXMes.rdlc", {rpt1})

        End If

        If UiTabPage6.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet1"
            rpt.Value = dView61


            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView6

            UI.Reportes.ReportesManager.Imprime("R6_EstadiaticaDental.rdlc", {rpt, rpt1})

        End If

    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        DataGridView1.Visible = False
        Chart3.Visible = True
        Button7.Visible = True
        Button6.Visible = False
        GroupBox1.Visible = False


        DataGridView2.Visible = False
        Chart2.Visible = True
        Label17.Visible = True


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        DataGridView1.Visible = True
        Chart3.Visible = False
        Button7.Visible = False
        Button6.Visible = True
        GroupBox1.Visible = True


        DataGridView2.Visible = True
        Chart2.Visible = False
        Label17.Visible = False

    End Sub

    Private Sub TextBox6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            TextBox6.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        Else
            TextBox6.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
    End Sub
End Class