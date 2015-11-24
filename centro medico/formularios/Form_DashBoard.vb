Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Threading



Public Class Form_DashBoard

    Dim _source As CMLinqDataContext
    Dim dView1 As DataView
    Dim dView11 As DataView
    Dim dView2 As DataView
    Dim dView21 As DataView
    Dim dView3 As DataView
    Dim dView31 As DataView
    Dim dView4 As DataView
    Dim dView41 As DataView
    Dim dView5 As DataView
    Dim dView51 As DataView
    Dim dView6 As DataView
    Dim dView61 As DataView
    Dim EmptGraf1 As Boolean
    Dim EmptGraf2 As Boolean
    Dim EmptGraf3 As Boolean
    Dim EmptGraf4 As Boolean
    Dim EmptGraf5 As Boolean
    Dim EmptGraf6 As Boolean
    Dim fecha2 As New Date
    Dim fecha6 As New Date
    Dim RowsTotal As Integer = 0
    Dim Estados As Integer = 0


    Private Sub Form_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '***Permisos***
        bImprimir.Enabled = (UiTabPage1.TabVisible Or UiTabPage2.TabVisible Or UiTabPage3.TabVisible Or UiTabPage4.TabVisible Or UiTabPage5.TabVisible Or UiTabPage6.TabVisible)
        UiTabPage1.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_estado) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage2.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage3.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage4.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage5.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage6.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        ClassInicializaDashBoard()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not Me.WindowState = FormWindowState.Minimized Then
            ClassRefresh()
        End If
    End Sub

    '***Refresh***
    Public Sub ClassRefresh()

        '***Citas del día por estado***
        Dim dTable As New CM2DataSet.CitasDiariasDataTable
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable = Me.CitasDiariasTableAdapter1.GetData

        Dim dTable11 As New CM2DataSet.Grafic1DataTable
        dTable11 = Me.Grafic1TableAdapter.GetData()
        Dim est As Integer = dTable11.Rows(0).Item("CONFIRMADA") + dTable11.Rows(0).Item("ATENDIDA") +
                             dTable11.Rows(0).Item("ANULADA") + dTable11.Rows(0).Item("PAGADA")

        If dTable.Count() > 0 And (dTable.Count() <> RowsTotal Or est <> Estados) Then
            Dim paciente As String = ""
            Dim medico As String = ""

            Dim paciente1 As String = ""
            Dim medico1 As String = ""
            Dim espec As String = ""
            Dim conf As String = ""
            Dim atend As String = ""
            Dim anul As String = ""
            Dim pag As String = ""
            Dim hora As String = ""

            If TextBox1.Text.Length > 0 Then paciente = TextBox1.Text
            If TextBox2.Text.Length > 0 Then medico = TextBox2.Text

            For Each row As DataRow In dTable.Rows

                paciente1 = If(Not IsDBNull(row.Item("PACIENTE")), row.Item("PACIENTE"), "")
                medico1 = If(Not IsDBNull(row.Item("MEDICO")), row.Item("MEDICO"), "")
                espec = If(Not IsDBNull(row.Item("ESPECIALIDAD")), row.Item("ESPECIALIDAD"), "")
                conf = If(Not IsDBNull(row.Item("CONFIRMADA")), row.Item("CONFIRMADA"), "")
                atend = If(Not IsDBNull(row.Item("ATENDIDA")), row.Item("ATENDIDA"), "")
                anul = If(Not IsDBNull(row.Item("ANULADA")), row.Item("ANULADA"), "")
                pag = If(Not IsDBNull(row.Item("PAGADA")), row.Item("PAGADA"), "")
                hora = If(Not IsDBNull(row.Item("HORARIO")), row.Item("HORARIO"), "")

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

            Dim total As Integer = dTable11.Rows(0).Item("TOTAL")
            conf = dTable11.Rows(0).Item("CONFIRMADA").ToString
            atend = dTable11.Rows(0).Item("ATENDIDA").ToString
            anul = dTable11.Rows(0).Item("ANULADA").ToString
            pag = dTable11.Rows(0).Item("PAGADA").ToString

            Dim dTableCD As New DataTable
            dTableCD.Columns.Add("Estado", GetType(String))
            dTableCD.Columns.Add("Si", GetType(Integer))
            dTableCD.Columns.Add("No", GetType(Integer))
            dTableCD.Rows.Add("Confirmada", conf, total - conf)
            dTableCD.Rows.Add("Atendida", atend, total - atend)
            dTableCD.Rows.Add("Anulada", anul, total - anul)
            dTableCD.Rows.Add("Pagada", pag, total - pag)

            Chart3.DataSource = dTableCD
            Chart3.DataBind()

            If (conf + atend + anul + pag) > 0 Then
                dView11 = dTable11.DefaultView

                Chart7.DataSource = dTableCD
                Chart7.DataBind()
                Chart7.Titles("Title1").Text = "Analisis Porcentual del Total de Citas (" & total & ")"
                For Each dp As DataPoint In Chart7.Series("Series1").Points
                    Dim temp As String
                    Dim per As Double
                    temp = dp.AxisLabel
                    If dp.YValues(0) <> 0 Then
                        per = (dp.YValues(0) / total) * 100
                        dp.Label = Format(per, "###.##") & "%"
                        If dp.Label.Substring(0, 1) = "," Then dp.Label = "0" & dp.Label
                        dp.LegendText = temp
                    End If
                Next
            Else
                dTable11.Clear()
                dTable11.Rows.Add(total, total, total, total, total)
                dView11 = dTable11.DefaultView

                UiGroupBox8.Visible = False
                UiGroupBox7.Location = New System.Drawing.Point(242, 55)
            End If
        End If
    End Sub

    '***Inicializacion***
    Private Sub ClassInicializaDashBoard()

        Dim fdm As New Date
        fdm = Date.Now
        fdm = fdm.AddDays(-fdm.Day + 1)

        '***Citas del día por estado***
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable1 = Me.CitasDiariasTableAdapter1.GetData()
        DataGridView1.DataSource = dTable1
        dView1 = dTable1.DefaultView

        RowsTotal = dTable1.Count()
        EmptGraf1 = RowsTotal > 0
        If EmptGraf1 Then
            Dim dTable11 As New CM2DataSet.Grafic1DataTable
            dTable11 = Me.Grafic1TableAdapter.GetData()
            Dim total As Integer = dTable11.Rows(0).Item("TOTAL")
            Dim confir As String = dTable11.Rows(0).Item("CONFIRMADA").ToString
            Dim atend As String = dTable11.Rows(0).Item("ATENDIDA").ToString
            Dim anul As String = dTable11.Rows(0).Item("ANULADA").ToString
            Dim paga As String = dTable11.Rows(0).Item("PAGADA").ToString

            Dim dTableCD As New DataTable
            dTableCD.Columns.Add("Estado", GetType(String))
            dTableCD.Columns.Add("Si", GetType(Integer))
            dTableCD.Columns.Add("No", GetType(Integer))
            dTableCD.Rows.Add("Confirmada", confir, total - confir)
            dTableCD.Rows.Add("Atendida", atend, total - atend)
            dTableCD.Rows.Add("Anulada", anul, total - anul)
            dTableCD.Rows.Add("Pagada", paga, total - paga)

            Chart3.DataSource = dTableCD
            Estados = Convert.ToInt16(confir) + Convert.ToInt16(atend) + Convert.ToInt16(anul) + Convert.ToInt16(paga)
            If Estados > 0 Then
                dView11 = dTable11.DefaultView

                Chart7.DataSource = dTableCD
                Chart7.DataBind()
                Chart7.Titles("Title1").Text = "Analisis Porcentual del Total de Citas (" & total & ")"
                For Each dp As DataPoint In Chart7.Series("Series1").Points
                    Dim temp As String
                    Dim per As Double
                    temp = dp.AxisLabel
                    If dp.YValues(0) <> 0 Then
                        per = (dp.YValues(0) / total) * 100
                        dp.Label = Format(per, "###.##") & "%"
                        If dp.Label.Substring(0, 1) = "," Then dp.Label = "0" & dp.Label
                        dp.LegendText = temp
                    End If
                Next
            Else
                dTable11.Clear()
                dTable11.Rows.Add(total, total, total, total, total)
                dView11 = dTable11.DefaultView

                UiGroupBox8.Visible = False
                UiGroupBox7.Location = New System.Drawing.Point(242, 55)
            End If

        Else
            UiGroupBox7.Visible = False
            UiGroupBox8.Visible = False
            Label17.Visible = False
            Label18.Visible = True
        End If


        '***Nuevos Pacientes/Mes***
        DateTimePicker1.MaxDate = Date.Now
        DateTimePicker2.MaxDate = Date.Now
        DateTimePicker1.Value = fdm
        fecha2 = DateTimePicker1.Value

        Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
        dTable2 = Me.PacientesAltaTableAdapter1.GetData(0, "", DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        DataGridView2.DataSource = dTable2
        dView2 = dTable2.DefaultView

        Dim dTable22 As New CM2DataSet.Grafic2DataTable
        Dim dTable21 As New CM2DataSet.Grafic2DataTable
        dTable21 = Me.Grafic2TableAdapter.GetData(1, DateTimePicker2.Value.Year, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)

        For Each row As DataRow In dTable21.Rows
            Dim Color As String = ""
            Dim Meses As String = If(Not IsDBNull(row.Item("Meses")), row.Item("Meses"), "")
            Dim Valor As String = If(Not IsDBNull(row.Item("Valor")), row.Item("Valor"), "")
            Dim fech As DateTime = New DateTime(Meses.Substring(0, 4), Meses.Substring(5, 2), 1)
            If Meses.Substring(5, 2) = "01" Then Color = "#418cf0"
            If Meses.Substring(5, 2) = "02" Then Color = "#fcb441"
            If Meses.Substring(5, 2) = "03" Then Color = "#e0400a"
            If Meses.Substring(5, 2) = "04" Then Color = "#056492"
            If Meses.Substring(5, 2) = "05" Then Color = "#bfbfbf"
            If Meses.Substring(5, 2) = "06" Then Color = "#1a3b69"
            If Meses.Substring(5, 2) = "07" Then Color = "#ffe382"
            If Meses.Substring(5, 2) = "08" Then Color = "#129cdd"
            If Meses.Substring(5, 2) = "09" Then Color = "#ca6b4b"
            If Meses.Substring(5, 2) = "10" Then Color = "#005cdb"
            If Meses.Substring(5, 2) = "11" Then Color = "#f3d288"
            If Meses.Substring(5, 2) = "12" Then Color = "#506381"
            Meses = fech.ToString("MMMM")
            dTable22.Rows.Add(Meses, Valor, Color)
        Next

        EmptGraf2 = dTable22.Count() > 0
        dView21 = dTable22.DefaultView
        If EmptGraf2 Then
            Chart2.DataSource = dTable22
            Chart2.DataBind()

            Dim i As Integer = 0
            For Each dp As DataPoint In Chart2.Series("Series1").Points
                Dim col As String = dTable22.Rows(i).Item("Color").ToString()
                dp.Color = ColorTranslator.FromHtml(col)
                i = i + 1
            Next
            Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & DateTimePicker2.Value.Year & ")"
        Else
            Chart2.Visible = False
            Label19.Visible = True
        End If


        '***Citas atendidas por Médico/Día***
        DateTimePicker3.MaxDate = Date.Now
        DateTimePicker4.MaxDate = Date.Now
        DateTimePicker3.Value = fdm

        Dim dTable3 As New CM2DataSet.MedicoCitasDataTable
        dTable3 = Me.MedicoCitasTableAdapter1.GetData(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
        DataGridView3.DataSource = dTable3
        dView3 = dTable3.DefaultView

        If dTable3.Count() > 0 Then
            Dim DisInf As String = dTable3.Rows(0).Item("FECHA").ToString()
            Dim original As DateTime = New DateTime(DisInf.Substring(6, 4), DisInf.Substring(3, 2), DisInf.Substring(0, 2))
            DateTimePicker4.Value = original

            dTable3 = Me.MedicoCitasTableAdapter1.MediaDesempenno(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
            dView31 = dTable3.DefaultView

            Dim dTable31 As New CM2DataSet.MedicoCitasDataTable
            dTable31 = Me.MedicoCitasTableAdapter1.GetDataBy(DateTimePicker4.Value.Date)
            EmptGraf3 = dTable31.Count() > 0 And dTable3.Count() > 0
            If EmptGraf3 Then
                Chart4.DataSource = dTable31
                Chart8.DataSource = dTable3
                Chart8.DataBind()

                Dim i As Integer = 0
                For Each dp As DataPoint In Chart8.Series("Series1").Points
                    Dim Lbtemp As String = dp.AxisLabel
                    Dim MedDes As String = dTable3.Rows(i).Item("ESPECIALIDAD").ToString()
                    dp.Label = MedDes & " - " & dp.YValues(0)
                    dp.YValues(0) = MedDes
                    dp.LegendText = Lbtemp
                    i = i + 1
                Next

                Chart4.Titles("Title1").Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.ToString("dd / MM / yyyy") & ")"
            Else
                UiGroupBox9.Visible = False
                UiGroupBox10.Visible = False
                Label20.Visible = True
            End If
        End If

        '**Citas por Especialidad/Mes** 
        DateTimePicker5.MaxDate = Date.Now
        DateTimePicker6.MaxDate = Date.Now
        DateTimePicker5.Value = fdm
        Dim firstOfYear As DateTime = New DateTime(DateTimePicker5.Value.Year, 1, 1)

        Dim dTable4 As New CM2DataSet.EspecialidadCitasDataTable
        dTable4 = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
        DataGridView4.DataSource = dTable4
        dView4 = dTable4.DefaultView

        EmptGraf4 = dTable4.Count() > 0
        Dim dTable41 As New CM2DataSet.EspecialidadCitasDataTable
        dTable41 = Me.EspecialidadCitasTableAdapter1.MediaEspecialidad(firstOfYear.Date, DateTimePicker6.Value.Date)
        dView41 = dTable41.DefaultView

        If EmptGraf4 Then
            Chart5.DataSource = dTable4
            Chart9.DataSource = dTable41
            Chart9.DataBind()

            Dim j As Integer = 0
            For Each dp As DataPoint In Chart9.Series("Series1").Points
                Dim Lbtemp1 As String = dp.AxisLabel
                Dim MedEsp As String = dTable41.Rows(j).Item("FECHA").ToString()
                dp.Label = MedEsp & " - " & dp.YValues(0)
                dp.YValues(0) = MedEsp
                dp.LegendText = Lbtemp1
                j = j + 1
            Next

            Chart5.Titles("Title1").Text = "Total de Citas por Especialidad (" & DateTimePicker6.Value.ToString("MMMM yyyy") & ")"
            Chart9.Titles("Title1").Text = "Media Mensual de Citas por Especialidad (" & DateTimePicker6.Value.Year & ")"
        Else
            UiGroupBox11.Visible = False
            UiGroupBox12.Visible = False
            Label21.Visible = True
        End If


        '***Top 10 Tratamientos/Mes***
        DateTimePicker7.MaxDate = Date.Now
        DateTimePicker8.MaxDate = Date.Now
        DateTimePicker7.Value = fdm
        Dim firstOfYear1 As DateTime = New DateTime(DateTimePicker5.Value.Year, 1, 1)

        Dim dTable5 As New CM2DataSet.Top10_TratamientoDataTable
        dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)
        DataGridView5.DataSource = dTable5
        dView5 = dTable5.DefaultView

        Dim view As New DataView(dTable5)
        view.Sort = "CantTratamientos ASC"
        Dim dTable51 As DataTable = view.ToTable()

        EmptGraf5 = dTable5.Count() > 0
        dTable5 = Me.Top10_TratamientoTableAdapter1.MediaTratamiento(firstOfYear1.Date, DateTimePicker8.Value.Date)
        dView51 = dTable5.DefaultView

        If EmptGraf5 Then
            Chart10.ChartAreas("ChartArea1").Position.Height = 93
            Chart6.DataSource = dTable51
            Chart10.DataSource = dTable5
            Chart10.DataBind()

            Dim k As Integer = 0
            For Each dp As DataPoint In Chart10.Series("Series1").Points
                Dim Lbtemp1 As String = dp.AxisLabel
                Dim MedTrat As String = dTable5.Rows(k).Item("FECHA").ToString()
                dp.Label = MedTrat & " - " & dp.YValues(0)
                dp.YValues(0) = MedTrat
                dp.LegendText = Lbtemp1
                k = k + 1
            Next

            Chart6.Titles("Title1").Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.ToString("MMMM yyyy") & ")"
            Label24.Text = "Media Mensual de Citas por Tratamiento (" & DateTimePicker8.Value.Year & ")"
        Else
            UiGroupBox13.Visible = False
            UiGroupBox14.Visible = False
            Label22.Visible = True
        End If


        '***Estadistico Dental***
        DateTimePicker9.MaxDate = Date.Now
        DateTimePicker10.MaxDate = Date.Now
        DateTimePicker9.Value = fdm
        fecha6 = DateTimePicker9.Value

        Dim dTable7 As New CM2DataSet.EstadistDentalDataTable
        Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
        dTable6 = Me.EstadistDentalTableAdapter1.GetData(0, "", DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
        DataGridView6.DataSource = dTable6
        dView6 = dTable6.DefaultView

        dTable6 = Me.EstadistDentalTableAdapter1.GetData(1, DateTimePicker10.Value.Year, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
        dTable7 = Me.EstadistDentalTableAdapter1.GetDataBy(1, DateTimePicker10.Value.Year, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)

        Dim view1 As New DataView(dTable6)
        view1.Sort = "FECHA ASC"
        Dim dTable61 As DataTable = view1.ToTable()

        Dim view2 As New DataView(dTable7)
        view2.Sort = "FECHA ASC"
        Dim dTable71 As DataTable = view2.ToTable()

        dTable6.Clear()
        For Each row As DataRow In dTable61.Rows
            Dim fecha As String = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
            Dim pres As String = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
            Dim acep As String = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
            Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
            fecha = fech.ToString("MMMM")
            dTable6.Rows.Add(fecha, pres, acep)
        Next

        dTable7.Clear()
        For Each row As DataRow In dTable71.Rows
            Dim fecha As String = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
            Dim pres As String = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
            Dim acep As String = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
            Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
            fecha = fech.ToString("MMMM")
            dTable7.Rows.Add(fecha, pres, acep)
        Next

        EmptGraf6 = dTable6.Count() > 0 And dTable7.Count() > 0
        dView61 = dTable6.DefaultView
        If EmptGraf6 Then
            Chart1.DataSource = dTable7
            Chart1.DataBind()
            For Each Serie As System.Windows.Forms.DataVisualization.Charting.Series In Chart1.Series
                For Each dp As DataPoint In Serie.Points
                    dp.Label = dp.YValues(0) & "%"
                Next
            Next
            Chart11.DataSource = dTable6
            Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"
        Else
            Label27.Visible = False
            UiGroupBox15.Visible = False
            UiGroupBox16.Visible = False
            Label23.Visible = True
        End If

    End Sub

    '***Filtrar Panel1***
    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click

        Dim dTable As New CM2DataSet.CitasDiariasDataTable
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable = Me.CitasDiariasTableAdapter1.GetData

        Dim paciente As String = ""
        Dim medico As String = ""

        Dim paciente1 As String = ""
        Dim medico1 As String = ""
        Dim espec As String = ""
        Dim conf As String = ""
        Dim atend As String = ""
        Dim anul As String = ""
        Dim pag As String = ""
        Dim hora As String = ""

        If TextBox1.Text.Length > 0 Then paciente = TextBox1.Text
        If TextBox2.Text.Length > 0 Then medico = TextBox2.Text

        For Each row As DataRow In dTable.Rows

            paciente1 = If(Not IsDBNull(row.Item("PACIENTE")), row.Item("PACIENTE"), "")
            medico1 = If(Not IsDBNull(row.Item("MEDICO")), row.Item("MEDICO"), "")
            espec = If(Not IsDBNull(row.Item("ESPECIALIDAD")), row.Item("ESPECIALIDAD"), "")
            conf = If(Not IsDBNull(row.Item("CONFIRMADA")), row.Item("CONFIRMADA"), "")
            atend = If(Not IsDBNull(row.Item("ATENDIDA")), row.Item("ATENDIDA"), "")
            anul = If(Not IsDBNull(row.Item("ANULADA")), row.Item("ANULADA"), "")
            pag = If(Not IsDBNull(row.Item("PAGADA")), row.Item("PAGADA"), "")
            hora = If(Not IsDBNull(row.Item("HORARIO")), row.Item("HORARIO"), "")

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

    '***Filtrar Panel2***
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mindate1 As New Date
        mindate1 = DateTimePicker1.Value.Date
        Dim num As String = TextBox6.Text
        Dim Anual As Integer = 0
        If num = "" Then num = "1"
        If CheckBox5.Checked Then
            If num.Length < 4 Or Convert.ToInt16(num) < 2005 Or Convert.ToInt16(num) > Date.Now.Year Then
                MsgBox("El año introducido no es válido", vbExclamation)
                TextBox6.Text = Date.Now.Year
            Else
                Anual = 1
                Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
                dTable2 = Me.PacientesAltaTableAdapter1.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                DataGridView2.DataSource = dTable2
                dView2 = dTable2.DefaultView

                Dim dTable22 As New CM2DataSet.Grafic2DataTable
                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)

                For Each row As DataRow In dTable21.Rows
                    Dim Color As String = ""
                    Dim Meses As String = If(Not IsDBNull(row.Item("Meses")), row.Item("Meses"), "")
                    Dim Valor As String = If(Not IsDBNull(row.Item("Valor")), row.Item("Valor"), "")
                    Dim fech As DateTime = New DateTime(Meses.Substring(0, 4), Meses.Substring(5, 2), 1)
                    If Meses.Substring(5, 2) = "01" Then Color = "#418cf0"
                    If Meses.Substring(5, 2) = "02" Then Color = "#fcb441"
                    If Meses.Substring(5, 2) = "03" Then Color = "#e0400a"
                    If Meses.Substring(5, 2) = "04" Then Color = "#056492"
                    If Meses.Substring(5, 2) = "05" Then Color = "#bfbfbf"
                    If Meses.Substring(5, 2) = "06" Then Color = "#1a3b69"
                    If Meses.Substring(5, 2) = "07" Then Color = "#ffe382"
                    If Meses.Substring(5, 2) = "08" Then Color = "#129cdd"
                    If Meses.Substring(5, 2) = "09" Then Color = "#ca6b4b"
                    If Meses.Substring(5, 2) = "10" Then Color = "#005cdb"
                    If Meses.Substring(5, 2) = "11" Then Color = "#f3d288"
                    If Meses.Substring(5, 2) = "12" Then Color = "#506381"
                    Meses = fech.ToString("MMMM")
                    dTable22.Rows.Add(Meses, Valor, Color)
                Next

                EmptGraf2 = dTable22.Count() > 0
                dView21 = dTable22.DefaultView
                If EmptGraf2 Then
                    Chart2.DataSource = dTable22
                    Chart2.DataBind()

                    Dim i As Integer = 0
                    For Each dp As DataPoint In Chart2.Series("Series1").Points
                        Dim col As String = dTable22.Rows(i).Item("Color").ToString()
                        dp.Color = ColorTranslator.FromHtml(col)
                        i = i + 1
                    Next
                    Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & num & ")"
                    If BVerTabla.Visible Then Chart2.Visible = True
                    Label19.Visible = False
                Else
                    Chart2.Visible = False
                    Label19.Text = "El año seleccionado no tiene información disponible"
                    If BVerTabla.Visible Then Label19.Visible = True Else Label19.Visible = False
                End If

            End If

        Else
            If DateTimePicker1.Value > DateTimePicker2.Value Then
                DateTimePicker1.Focus()
                MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
            Else
                If DateTimePicker1.Value.Year < DateTimePicker2.Value.Year Then
                    mindate1 = New DateTime(DateTimePicker2.Value.Year, 1, 1)
                End If
                fecha2 = DateTimePicker1.Value

                Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
                dTable2 = Me.PacientesAltaTableAdapter1.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                DataGridView2.DataSource = dTable2
                dView2 = dTable2.DefaultView

                Dim dTable22 As New CM2DataSet.Grafic2DataTable
                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, mindate1, DateTimePicker2.Value.Date)

                For Each row As DataRow In dTable21.Rows
                    Dim Color As String = ""
                    Dim Meses As String = If(Not IsDBNull(row.Item("Meses")), row.Item("Meses"), "")
                    Dim Valor As String = If(Not IsDBNull(row.Item("Valor")), row.Item("Valor"), "")
                    Dim fech As DateTime = New DateTime(Meses.Substring(0, 4), Meses.Substring(5, 2), 1)
                    If Meses.Substring(5, 2) = "01" Then Color = "#418cf0"
                    If Meses.Substring(5, 2) = "02" Then Color = "#fcb441"
                    If Meses.Substring(5, 2) = "03" Then Color = "#e0400a"
                    If Meses.Substring(5, 2) = "04" Then Color = "#056492"
                    If Meses.Substring(5, 2) = "05" Then Color = "#bfbfbf"
                    If Meses.Substring(5, 2) = "06" Then Color = "#1a3b69"
                    If Meses.Substring(5, 2) = "07" Then Color = "#ffe382"
                    If Meses.Substring(5, 2) = "08" Then Color = "#129cdd"
                    If Meses.Substring(5, 2) = "09" Then Color = "#ca6b4b"
                    If Meses.Substring(5, 2) = "10" Then Color = "#005cdb"
                    If Meses.Substring(5, 2) = "11" Then Color = "#f3d288"
                    If Meses.Substring(5, 2) = "12" Then Color = "#506381"
                    Meses = fech.ToString("MMMM")
                    dTable22.Rows.Add(Meses, Valor, Color)
                Next

                EmptGraf2 = dTable22.Count() > 0
                dView21 = dTable22.DefaultView
                If EmptGraf2 Then
                    Chart2.DataSource = dTable22
                    Chart2.DataBind()

                    Dim i As Integer = 0
                    For Each dp As DataPoint In Chart2.Series("Series1").Points
                        Dim col As String = dTable22.Rows(i).Item("Color").ToString()
                        dp.Color = ColorTranslator.FromHtml(col)
                        i = i + 1
                    Next
                    Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & DateTimePicker2.Value.Year & ")"
                    If BVerTabla.Visible Then Chart2.Visible = True
                    Label19.Visible = False
                Else
                    Chart2.Visible = False
                    Label19.Text = "El rango seleccionado no tiene información disponible"
                    If BVerTabla.Visible Then Label19.Visible = True Else Label19.Visible = False
                End If
                DateTimePicker1.Value = mindate1
            End If

        End If

    End Sub

    '***Filtrar Panel3***
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
                fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                medico1 = If(Not IsDBNull(row.Item("MEDICO")), row.Item("MEDICO"), "")
                espec = If(Not IsDBNull(row.Item("ESPECIALIDAD")), row.Item("ESPECIALIDAD"), "")
                cit = If(Not IsDBNull(row.Item("CantCitas")), row.Item("CantCitas"), "")

                If medico1.ToLower().Contains(medico.ToLower()) Then
                    dTable1.Rows.Add(fecha, medico1, espec, cit)
                End If
            Next

            DataGridView3.DataSource = dTable1
            dView3 = dTable1.DefaultView

            If dTable1.Count() > 0 Then
                Dim DisInf As String = dTable1.Rows(0).Item("FECHA").ToString()
                Dim original As DateTime = New DateTime(DisInf.Substring(6, 4), DisInf.Substring(3, 2), DisInf.Substring(0, 2))
                DateTimePicker4.Value = original

                dTable1 = Me.MedicoCitasTableAdapter1.MediaDesempenno(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
                dView31 = dTable1.DefaultView

                Dim dTable31 As New CM2DataSet.MedicoCitasDataTable
                dTable31 = Me.MedicoCitasTableAdapter1.GetDataBy(DateTimePicker4.Value.Date)
                EmptGraf3 = dTable31.Count() > 0 And dTable1.Count() > 0
                If EmptGraf3 Then
                    Chart4.DataSource = dTable31
                    Chart4.DataBind()
                    Chart8.DataSource = dTable1
                    Chart8.DataBind()

                    Dim i As Integer = 0
                    For Each dp As DataPoint In Chart8.Series("Series1").Points
                        Dim Lbtemp As String = dp.AxisLabel
                        Dim MedDes As String = dTable1.Rows(i).Item("ESPECIALIDAD").ToString()
                        dp.Label = MedDes & " - " & dp.YValues(0)
                        dp.YValues(0) = MedDes
                        dp.LegendText = Lbtemp
                        i = i + 1
                    Next

                    Chart4.Titles("Title1").Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.ToString("dd / MM / yyyy") & ")"
                    Label20.Visible = False
                    If BVerTabla.Visible Then
                        UiGroupBox9.Visible = True
                        UiGroupBox10.Visible = True
                    End If

                Else
                    UiGroupBox9.Visible = False
                    UiGroupBox10.Visible = False
                    If BVerTabla.Visible Then Label20.Visible = True Else Label20.Visible = False
                End If
            End If
        End If
    End Sub

    '***Filtrar Panel4***
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim espec As String = ""
        Dim espec1 As String = ""
        Dim fecha As String = ""
        Dim cit As String = ""
        Dim firstOfMonth As DateTime = New DateTime(DateTimePicker6.Value.Year, DateTimePicker6.Value.Month, 1)

        If DateTimePicker5.Value > DateTimePicker6.Value Then

            DateTimePicker5.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else
            If TextBox4.Text.Length > 0 Then espec = TextBox4.Text

            Dim dTable As New CM2DataSet.EspecialidadCitasDataTable
            Dim dTable1 As New CM2DataSet.EspecialidadCitasDataTable
            dTable = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)

            For Each row As DataRow In dTable.Rows
                fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                espec1 = If(Not IsDBNull(row.Item("ESPECIALIDAD")), row.Item("ESPECIALIDAD"), "")
                cit = If(Not IsDBNull(row.Item("CantCitas")), row.Item("CantCitas"), "")

                If espec1.ToLower().Contains(espec.ToLower()) Then
                    dTable1.Rows.Add(fecha, espec1, cit)
                End If
            Next

            DataGridView4.DataSource = dTable1
            dView4 = dTable1.DefaultView

            dTable = Me.EspecialidadCitasTableAdapter1.GetDataBy(firstOfMonth.Date, DateTimePicker6.Value.Date)
            dTable1 = Me.EspecialidadCitasTableAdapter1.MediaEspecialidad(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
            dView41 = dTable1.DefaultView

            EmptGraf4 = dTable.Count() > 0
            If EmptGraf4 Then
                Chart5.DataSource = dTable
                Chart5.DataBind()
                Chart9.DataSource = dTable1
                Chart9.DataBind()

                Dim j As Integer = 0
                For Each dp As DataPoint In Chart9.Series("Series1").Points
                    Dim Lbtemp1 As String = dp.AxisLabel
                    Dim MedEsp As String = dTable1.Rows(j).Item("FECHA").ToString()
                    dp.Label = MedEsp & " - " & dp.YValues(0)
                    dp.YValues(0) = MedEsp
                    dp.LegendText = Lbtemp1
                    j = j + 1
                Next

                Chart5.Titles("Title1").Text = "Total de Citas por Especialidad (" & DateTimePicker6.Value.ToString("MMMM yyyy") & ")"
                Chart9.Titles("Title1").Text = "Media Mensual de Citas por Especialidad"
                Label21.Visible = False
                If BVerTabla.Visible Then
                    UiGroupBox11.Visible = True
                    UiGroupBox12.Visible = True
                End If

            Else
                UiGroupBox11.Visible = False
                UiGroupBox12.Visible = False
                If BVerTabla.Visible Then Label21.Visible = True Else Label21.Visible = False
            End If
        End If
    End Sub

    '***Filtrar Panel5***
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim trat As String = ""
        Dim trat1 As String = ""
        Dim fecha As String = ""
        Dim cant As String = ""
        Dim firstOfMonth As DateTime = New DateTime(DateTimePicker8.Value.Year, DateTimePicker8.Value.Month, 1)

        If DateTimePicker7.Value > DateTimePicker8.Value Then

            DateTimePicker7.Focus()
            MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
        Else
            If TextBox5.Text.Length > 0 Then trat = TextBox5.Text

            Dim dTable5 As New CM2DataSet.Top10_TratamientoDataTable
            Dim dTable51 As New CM2DataSet.Top10_TratamientoDataTable
            dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)

            For Each row As DataRow In dTable5.Rows
                fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                trat1 = If(Not IsDBNull(row.Item("Tratamiento")), row.Item("Tratamiento"), "")
                cant = If(Not IsDBNull(row.Item("CantTratamientos")), row.Item("CantTratamientos"), "")

                If trat1.ToLower().Contains(trat.ToLower()) Then
                    dTable51.Rows.Add(fecha, trat1, cant)
                End If
            Next

            DataGridView5.DataSource = dTable51
            dView5 = dTable51.DefaultView

            dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(firstOfMonth.Date, DateTimePicker8.Value.Date)
            dTable51 = Me.Top10_TratamientoTableAdapter1.MediaTratamiento(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)
            dView51 = dTable51.DefaultView

            Dim view As New DataView(dTable5)
            view.Sort = "CantTratamientos ASC"
            Dim dTable As DataTable = view.ToTable()

            EmptGraf5 = dTable5.Count() > 0
            If EmptGraf5 Then
                Chart6.DataSource = dTable
                Chart6.DataBind()
                Chart10.DataSource = dTable51
                Chart10.DataBind()

                Dim k As Integer = 0
                For Each dp As DataPoint In Chart10.Series("Series1").Points
                    Dim Lbtemp1 As String = dp.AxisLabel
                    Dim MedTrat As String = dTable51.Rows(k).Item("FECHA").ToString()
                    dp.Label = MedTrat & " - " & dp.YValues(0)
                    dp.YValues(0) = MedTrat
                    dp.LegendText = Lbtemp1
                    k = k + 1
                Next
                Chart6.Titles("Title1").Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.ToString("MMMM yyyy") & ")"
                Label24.Text = "Media Mensual de Citas por Tratamiento"
                Label22.Visible = False
                If BVerTabla.Visible Then
                    UiGroupBox13.Visible = True
                    UiGroupBox14.Visible = True
                    Chart10.Show()
                End If

            Else
                UiGroupBox13.Visible = False
                UiGroupBox14.Visible = False
                If BVerTabla.Visible Then Label22.Visible = True Else Label22.Visible = False
            End If
        End If
    End Sub

    '***Filtrar Panel6***
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim fecha As String
        Dim pres As String
        Dim acep As String
        Dim mindate1 As New Date
        mindate1 = DateTimePicker9.Value.Date
        Dim num As String = TextBox7.Text
        Dim Anual As Integer = 0
        If num = "" Then num = "1"
        If CheckBox6.Checked Then
            If num.Length < 4 Or Convert.ToInt16(num) < 2005 Or Convert.ToInt16(num) > Date.Now.Year Then
                MsgBox("El año introducido no es válido", vbExclamation)
                TextBox7.Text = Date.Now.Year
            Else
                Anual = 1
                Dim dTable7 As New CM2DataSet.EstadistDentalDataTable
                Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
                Dim dTable61 As New CM2DataSet.EstadistDentalDataTable
                dTable7 = Me.EstadistDentalTableAdapter1.GetData(Anual, num, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
                DataGridView6.DataSource = dTable7
                dView6 = dTable7.DefaultView

                dTable61 = Me.EstadistDentalTableAdapter1.GetDataBy(Anual, num, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)

                Dim view As New DataView(dTable7)
                view.Sort = "FECHA ASC"
                Dim dTable As DataTable = view.ToTable()

                Dim view1 As New DataView(dTable61)
                view1.Sort = "FECHA ASC"
                Dim dTable1 As DataTable = view1.ToTable()

                dTable6.Clear()
                For Each row As DataRow In dTable.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable6.Rows.Add(fecha, pres, acep)
                Next

                dTable61.Clear()
                For Each row As DataRow In dTable1.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable61.Rows.Add(fecha, pres, acep)
                Next

                dView61 = dTable6.DefaultView

                EmptGraf6 = dTable6.Count() > 0 And dTable61.Count() > 0
                If EmptGraf6 Then
                    Chart1.DataSource = dTable61
                    Chart1.DataBind()
                    For Each Serie As System.Windows.Forms.DataVisualization.Charting.Series In Chart1.Series
                        For Each dp As DataPoint In Serie.Points
                            dp.Label = dp.YValues(0) & "%"
                        Next
                    Next
                    'Chart1.Series("Series1").Points.Item(2).Color = Color.Red

                    Chart11.DataSource = dTable6
                    Chart11.DataBind()
                    Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & num & ")"
                    Label23.Visible = False
                    If BVerTabla.Visible Then
                        Label27.Visible = True
                        UiGroupBox15.Visible = True
                        UiGroupBox16.Visible = True
                    End If

                Else
                    Label27.Visible = False
                    UiGroupBox15.Visible = False
                    UiGroupBox16.Visible = False
                    Label23.Text = "El año seleccionado no tiene información disponible"
                    If BVerTabla.Visible Then Label23.Visible = True Else Label23.Visible = False
                End If

            End If
        Else
            If DateTimePicker9.Value > DateTimePicker10.Value Then
                DateTimePicker9.Focus()
                MsgBox("El rango de fecha es incorrecto. Rectifíquelo", vbExclamation)
            Else
                If DateTimePicker9.Value.Year < DateTimePicker10.Value.Year Then
                    mindate1 = New DateTime(DateTimePicker10.Value.Year, 1, 1)
                End If
                fecha6 = DateTimePicker9.Value

                Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
                Dim dTable61 As New CM2DataSet.EstadistDentalDataTable
                dTable6 = Me.EstadistDentalTableAdapter1.GetData(Anual, num, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
                DataGridView6.DataSource = dTable6
                dView6 = dTable6.DefaultView

                dTable6 = Me.EstadistDentalTableAdapter1.GetData(Anual, num, mindate1, DateTimePicker10.Value.Date)
                dTable61 = Me.EstadistDentalTableAdapter1.GetDataBy(Anual, num, mindate1, DateTimePicker10.Value.Date)

                Dim view As New DataView(dTable6)
                view.Sort = "FECHA ASC"
                Dim dTable As DataTable = view.ToTable()

                Dim view1 As New DataView(dTable61)
                view1.Sort = "FECHA ASC"
                Dim dTable1 As DataTable = view1.ToTable()

                dTable6.Clear()
                For Each row As DataRow In dTable.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable6.Rows.Add(fecha, pres, acep)
                Next

                dTable61.Clear()
                For Each row As DataRow In dTable1.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable61.Rows.Add(fecha, pres, acep)
                Next

                EmptGraf6 = dTable6.Count() > 0 And dTable61.Count() > 0
                dView61 = dTable6.DefaultView
                If EmptGraf6 Then
                    Chart1.DataSource = dTable61
                    Chart1.DataBind()
                    For Each Serie As System.Windows.Forms.DataVisualization.Charting.Series In Chart1.Series
                        For Each dp As DataPoint In Serie.Points
                            dp.Label = dp.YValues(0) & "%"
                        Next
                    Next
                    'If Chart1.Series("Series1").Points.Count() > 2 Then Chart1.Series("Series1").Points.Item(2).Color = Color.Red

                    Chart11.DataSource = dTable6
                    Chart11.DataBind()
                    Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"
                    Label23.Visible = False
                    If BVerTabla.Visible Then
                        Label27.Visible = True
                        UiGroupBox15.Visible = True
                        UiGroupBox16.Visible = True
                    End If

                Else
                    Label27.Visible = False
                    UiGroupBox15.Visible = False
                    UiGroupBox16.Visible = False
                    Label23.Text = "El rango seleccionado no tiene información disponible"
                    If BVerTabla.Visible Then Label23.Visible = True Else Label23.Visible = False
                End If
                DateTimePicker9.Value = mindate1
            End If
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

            If dView1.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R1_CitasXEstado.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage2.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet1"
            rpt.Value = dView21

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView2

            If dView2.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R2_PacientesAltaXMes.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage3.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet3"
            rpt.Value = dView3

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet31"
            rpt1.Value = dView31

            If dView3.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R3_CitasAtendidasMedicosXDias.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage4.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet3"
            rpt.Value = dView4

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet1"
            rpt1.Value = dView41

            If dView4.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R4_CitasEspecialidadXMes.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage5.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet3"
            rpt.Value = dView5

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet1"
            rpt1.Value = dView51

            If dView5.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R5_Top10TratamientosXMes.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage6.Selected Then

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt.Name = "DataSet1"
            rpt.Value = dView61


            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView6

            If dView6.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R6_EstadiaticaDental.rdlc", {rpt, rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub BVerGrafica_Click(sender As Object, e As EventArgs) Handles BVerGrafica.Click

        ToolTip1.Active = True
        BVerTabla.Visible = True
        BVerGrafica.Visible = False

        '***Planel1***
        If UiTabPage1.TabVisible Then
            If EmptGraf1 Then
                Label18.Visible = False
                Label17.Visible = True
                UiGroupBox7.Visible = True
                If Estados > 0 Then UiGroupBox8.Visible = True
            Else
                UiGroupBox7.Visible = False
                UiGroupBox8.Visible = False
                Label18.Visible = True
                Label17.Visible = False
            End If
            UiGroupBox4.Visible = False
            DataGridView1.Visible = False
        End If

        '***Planel2***
        If UiTabPage2.TabVisible Then
            If EmptGraf2 Then
                Label19.Visible = False
                Chart2.Visible = True
            Else
                Chart2.Visible = False
                Label19.Visible = True
            End If
            If DateTimePicker1.Value.Year < DateTimePicker2.Value.Year Then DateTimePicker1.Value = New DateTime(DateTimePicker2.Value.Year, 1, 1)
            DataGridView2.Visible = False
        End If

        '***Planel3***
        If UiTabPage3.TabVisible Then
            If EmptGraf3 Then
                Label20.Visible = False
                UiGroupBox9.Visible = True
                UiGroupBox10.Visible = True
            Else
                UiGroupBox9.Visible = False
                UiGroupBox10.Visible = False
                Label20.Visible = True
            End If
            DataGridView3.Visible = False
            TextBox3.Enabled = False
        End If

        '***Planel4***
        If UiTabPage4.TabVisible Then
            If EmptGraf4 Then
                Label21.Visible = False
                UiGroupBox11.Visible = True
                UiGroupBox12.Visible = True
            Else
                UiGroupBox11.Visible = False
                UiGroupBox12.Visible = False
                Label21.Visible = True
            End If
            DataGridView4.Visible = False
            TextBox4.Enabled = False
        End If

        '***Planel5***
        If UiTabPage5.TabVisible Then
            If EmptGraf5 Then
                Label22.Visible = False
                UiGroupBox13.Visible = True
                UiGroupBox14.Visible = True
            Else
                UiGroupBox13.Visible = False
                UiGroupBox14.Visible = False
                Label22.Visible = True
            End If
            DataGridView5.Visible = False
            TextBox5.Enabled = False
        End If

        '***Planel6***
        If UiTabPage6.TabVisible Then
            If EmptGraf6 Then
                Label23.Visible = False
                Label27.Visible = True
                UiGroupBox15.Visible = True
                UiGroupBox16.Visible = True
            Else
                Label27.Visible = False
                UiGroupBox15.Visible = False
                UiGroupBox16.Visible = False
                Label23.Visible = True
            End If
            If DateTimePicker9.Value.Year < DateTimePicker10.Value.Year Then DateTimePicker9.Value = New DateTime(DateTimePicker10.Value.Year, 1, 1)
            DataGridView6.Visible = False
        End If
    End Sub

    Private Sub BVerTabla_Click(sender As Object, e As EventArgs) Handles BVerTabla.Click

        ToolTip1.Active = False
        BVerTabla.Visible = False
        BVerGrafica.Visible = True

        '***Planel1***
        If UiTabPage1.TabVisible Then
            UiGroupBox7.Visible = False
            UiGroupBox8.Visible = False
            Label18.Visible = False
            Label17.Visible = False
            UiGroupBox4.Visible = True
            DataGridView1.Visible = True
        End If

        '***Planel2***
        If UiTabPage2.TabVisible Then
            Chart2.Visible = False
            Label19.Visible = False
            DateTimePicker1.Value = fecha2
            DataGridView2.Visible = True
        End If

        '***Planel3***
        If UiTabPage3.TabVisible Then
            UiGroupBox9.Visible = False
            UiGroupBox10.Visible = False
            Label20.Visible = False
            DataGridView3.Visible = True
            TextBox3.Enabled = True
        End If

        '***Planel4***
        If UiTabPage4.TabVisible Then
            UiGroupBox11.Visible = False
            UiGroupBox12.Visible = False
            Label21.Visible = False
            DataGridView4.Visible = True
            TextBox4.Enabled = True
        End If

        '***Planel5***
        If UiTabPage5.TabVisible Then
            UiGroupBox13.Visible = False
            UiGroupBox14.Visible = False
            Label22.Visible = False
            DataGridView5.Visible = True
            TextBox5.Enabled = True
        End If

        '***Planel6***
        If UiTabPage6.TabVisible Then
            UiGroupBox15.Visible = False
            UiGroupBox16.Visible = False
            Label23.Visible = False
            Label27.Visible = False
            DateTimePicker9.Value = fecha6
            DataGridView6.Visible = True
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox7.KeyPress
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
            TextBox6.Text = Date.Now.Year
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        Else
            TextBox6.Enabled = False
            TextBox6.Text = ""
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            TextBox7.Enabled = True
            TextBox7.Text = Date.Now.Year
            DateTimePicker9.Enabled = False
            DateTimePicker10.Enabled = False
        Else
            TextBox7.Enabled = False
            TextBox7.Text = ""
            DateTimePicker9.Enabled = True
            DateTimePicker10.Enabled = True
        End If
    End Sub

End Class