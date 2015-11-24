Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Web

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
    Dim EmptGraf1 As Boolean
    Dim EmptGraf2 As Boolean
    Dim EmptGraf3 As Boolean
    Dim EmptGraf4 As Boolean
    Dim EmptGraf5 As Boolean
    Dim EmptGraf6 As Boolean
    Dim fecha2 As New Date
    Dim fecha4 As New Date
    Dim fecha5 As New Date
    Dim fecha6 As New Date



    Private Sub Form_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '***Permisos***
        bImprimir.Enabled = (UiTabPage1.TabVisible Or UiTabPage2.TabVisible Or UiTabPage3.TabVisible Or UiTabPage4.TabVisible Or UiTabPage5.TabVisible Or UiTabPage6.TabVisible)
        UiTabPage1.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_estado) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage2.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Relacion_de_Altas) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage3.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_atendidas_por_medicos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage4.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Citas_por_Especialidad) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage5.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Top_10_Tratamientos) = RoleManager.TipoPermisos.Ninguno)
        UiTabPage6.TabVisible = Not (Globales.Usuario.Permisos(RoleManager.Items.DashB_Resumen_Dental) = RoleManager.TipoPermisos.Ninguno)

        ClassInizializaDashBoard()

    End Sub

    Private Sub ClassInizializaDashBoard()

        Dim fdm As New Date
        fdm = Date.Now
        fdm = fdm.AddDays(-fdm.Day + 1)

        '***Citas del día por estado***
        Dim dTable1 As New CM2DataSet.CitasDiariasDataTable
        dTable1 = Me.CitasDiariasTableAdapter1.GetData()
        DataGridView1.DataSource = dTable1
        dView1 = dTable1.DefaultView

        Dim dTable11 As New CM2DataSet.Grafic1DataTable
        dTable11 = Me.Grafic1TableAdapter.GetData()
        Dim total As Integer = dTable11.Rows(0).Item("TOTAL")
        EmptGraf1 = dTable11.Rows(0).Item("CONFIRMADA") + dTable11.Rows(0).Item("ATENDIDA") + dTable11.Rows(0).Item("ANULADA") + dTable11.Rows(0).Item("PAGADA") > 0
        dView11 = dTable11.DefaultView
        If EmptGraf1 Then
            Chart3.DataSource = dTable11

            Dim row1 As DataRow = dTable11.Rows(0)
            Dim confir As String = row1.Item("CONFIRMADA").ToString
            Dim atend As String = row1.Item("ATENDIDA").ToString
            Dim anul As String = row1.Item("ANULADA").ToString
            Dim paga As String = row1.Item("PAGADA").ToString
            Chart7.Series.Clear()
            Chart7.Series.Add("Serie1")
            Chart7.Series("Serie1").ChartType = SeriesChartType.Pie
            Chart7.Series("Serie1").Points.AddXY("Confirmada", confir)
            Chart7.Series("Serie1").Points.AddXY("Atendida", atend)
            Chart7.Series("Serie1").Points.AddXY("Anulada", anul)
            Chart7.Series("Serie1").Points.AddXY("Pagada", paga)
            Chart7.Series("Serie1").IsValueShownAsLabel = False
            Chart7.Series("Serie1").CustomProperties = "PieDrawingStyle=SoftEdge, PieLabelStyle=Outside"
            Chart7.Series("Serie1").Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
            Chart7.Titles("Title1").Text = "Analisis Porcentual del Total de Citas (" & total & ")"
            Chart7.Titles("Title1").Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
            Chart7.ChartAreas("ChartArea1").Position.Height = 95.0!
            Chart7.ChartAreas("ChartArea1").Position.Width = 95.0!
            Chart7.ChartAreas("ChartArea1").Position.X = 10.0!
            Chart7.ChartAreas("ChartArea1").Position.Y = 2.0!
            Chart7.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
            Chart7.ChartAreas("ChartArea1").Area3DStyle.Inclination = 40
            Chart7.Legends("Legend1").BackColor = System.Drawing.Color.Transparent
            Chart7.Legends("Legend1").BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
            Chart7.Legends("Legend1").Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
            Chart7.Legends("Legend1").IsTextAutoFit = False
            Chart7.Legends("Legend1").LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
            Chart7.Legends("Legend1").Name = "Legend1"
            Chart7.Legends("Legend1").Position.Auto = False
            Chart7.Legends("Legend1").Position.Height = 6.0!
            Chart7.Legends("Legend1").Position.Width = 99.0!
            Chart7.Legends("Legend1").Position.Y = 94.0!
            For Each dp As DataPoint In Chart7.Series("Serie1").Points
                Dim temp As String
                Dim per As Double
                temp = dp.AxisLabel
                dp.IsValueShownAsLabel = True
                If dp.YValues(0) = 0 Then
                    dp.IsValueShownAsLabel = False
                End If
                If dp.YValues(0) <> 0 Then
                    per = (dp.YValues(0) / total) * 100
                    dp.Label = Format(per, "###.###") & "%"
                    If dp.Label.Substring(0, 1) = "," Then dp.Label = "0" & dp.Label
                    dp.LegendText = temp
                End If
            Next
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

        Dim dTable21 As New CM2DataSet.Grafic2DataTable
        dTable21 = Me.Grafic2TableAdapter.GetData(1, DateTimePicker2.Value.Year, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        EmptGraf2 = dTable21.Rows(0).Item("Enero") + dTable21.Rows(0).Item("Febrero") + dTable21.Rows(0).Item("Marzo") + dTable21.Rows(0).Item("Abril") +
                    dTable21.Rows(0).Item("Mayo") + dTable21.Rows(0).Item("Junio") + dTable21.Rows(0).Item("Julio") + dTable21.Rows(0).Item("Agosto") +
                    dTable21.Rows(0).Item("Septiembre") + dTable21.Rows(0).Item("Octubre") + dTable21.Rows(0).Item("Noviembre") + dTable21.Rows(0).Item("Diciembre") > 0
        dView21 = dTable21.DefaultView
        If EmptGraf2 Then
            Chart2.DataSource = dTable21
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

        If dTable3.Count() > 0 Then 'CheckBox6.Checked And
            Dim DisInf As String = dTable3.Rows(0).Item("FECHA").ToString()
            Dim original As DateTime = New DateTime(DisInf.Substring(6, 4), DisInf.Substring(3, 2), DisInf.Substring(0, 2))
            DateTimePicker4.Value = original
        End If

        Dim dTable31 As New CM2DataSet.MedicoCitasDataTable
        dTable31 = Me.MedicoCitasTableAdapter1.GetDataBy(DateTimePicker4.Value.Date)
        EmptGraf3 = dTable31.Count() > 0
        If EmptGraf3 Then
            Chart4.DataSource = dTable31
            Chart8.DataSource = dTable31
            Label24.Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.ToString("dd / MM / yyyy") & ")"
        Else
            Label24.Visible = False
            UiGroupBox9.Visible = False
            UiGroupBox10.Visible = False
            Label20.Visible = True
        End If


        '**Citas por Especialidad/Mes**
        DateTimePicker5.MaxDate = Date.Now
        DateTimePicker6.MaxDate = Date.Now
        DateTimePicker5.Value = fdm
        fecha4 = DateTimePicker5.Value

        Dim dTable4 As New CM2DataSet.EspecialidadCitasDataTable
        dTable4 = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
        DataGridView4.DataSource = dTable4
        dView4 = dTable4.DefaultView

        EmptGraf4 = dTable4.Count() > 0
        If EmptGraf4 Then
            Chart5.DataSource = dTable4
            Chart9.DataSource = dTable4
            Label25.Text = "Citas Mensuales por Especialidad (" & DateTimePicker6.Value.ToString("MMMM yyyy") & ")"
        Else
            Label25.Visible = False
            UiGroupBox11.Visible = False
            UiGroupBox12.Visible = False
            Label21.Visible = True
        End If


        '***Top 10 Tratamientos/Mes***
        DateTimePicker7.MaxDate = Date.Now
        DateTimePicker8.MaxDate = Date.Now
        DateTimePicker7.Value = fdm
        fecha5 = DateTimePicker7.Value

        Dim dTable5 As New CM2DataSet.Top10_TratamientoDataTable
        dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)
        DataGridView5.DataSource = dTable5
        dView5 = dTable5.DefaultView

        Dim view As New DataView(dTable5)
        view.Sort = "CantTratamientos ASC"
        Dim dTable51 As DataTable = view.ToTable()

        EmptGraf5 = dTable5.Count() > 0
        If EmptGraf5 Then
            Chart6.DataSource = dTable51
            Chart10.DataSource = dTable5
            Label26.Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.ToString("MMMM yyyy") & ")"
        Else
            Label26.Visible = False
            UiGroupBox13.Visible = False
            UiGroupBox14.Visible = False
            Label22.Visible = True
        End If

        '***Estadistico Dental***
        DateTimePicker9.MaxDate = Date.Now
        DateTimePicker10.MaxDate = Date.Now
        DateTimePicker9.Value = fdm
        fecha6 = DateTimePicker9.Value

        Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
        dTable6 = Me.EstadistDentalTableAdapter1.GetData(0, "", DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
        DataGridView6.DataSource = dTable6
        dView6 = dTable6.DefaultView

        dTable6 = Me.EstadistDentalTableAdapter1.GetData(1, DateTimePicker10.Value.Year, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)

        Dim view1 As New DataView(dTable6)
        view1.Sort = "FECHA ASC"
        Dim dTable61 As DataTable = view1.ToTable()

        dTable6.Clear()
        For Each row As DataRow In dTable61.Rows
            Dim fecha As String = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
            Dim pres As String = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
            Dim acep As String = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
            Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
            fecha = fech.ToString("MMMM")
            dTable6.Rows.Add(fecha, pres, acep)
        Next

        EmptGraf6 = dTable6.Count() > 0
        dView61 = dTable6.DefaultView
        If EmptGraf6 Then
            Chart1.DataSource = dTable6
            Chart11.DataSource = dTable6
            Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"
        Else
            Label27.Visible = False
            UiGroupBox15.Visible = False
            UiGroupBox16.Visible = False
            Label23.Visible = True
        End If

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
                TextBox6.Text = Date.Now.Year
            Else
                Anual = 1
                Dim dTable2 As New CM2DataSet.PacientesAltaDataTable
                dTable2 = Me.PacientesAltaTableAdapter1.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                DataGridView2.DataSource = dTable2
                dView2 = dTable2.DefaultView

                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                EmptGraf2 = dTable21.Rows(0).Item("Enero") + dTable21.Rows(0).Item("Febrero") + dTable21.Rows(0).Item("Marzo") + dTable21.Rows(0).Item("Abril") +
                            dTable21.Rows(0).Item("Mayo") + dTable21.Rows(0).Item("Junio") + dTable21.Rows(0).Item("Julio") + dTable21.Rows(0).Item("Agosto") +
                            dTable21.Rows(0).Item("Septiembre") + dTable21.Rows(0).Item("Octubre") + dTable21.Rows(0).Item("Noviembre") + dTable21.Rows(0).Item("Diciembre") > 0
                dView21 = dTable21.DefaultView
                If EmptGraf2 Then
                    Chart2.DataSource = dTable21
                    Chart2.DataBind()
                    Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & num & ")"
                    If BVerTabla.Visible Then Chart2.Visible = True
                    Label19.Visible = False
                Else
                    Chart2.Visible = False
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

                Dim dTable21 As New CM2DataSet.Grafic2DataTable
                dTable21 = Me.Grafic2TableAdapter.GetData(Anual, num, mindate1, DateTimePicker2.Value.Date)
                EmptGraf2 = dTable21.Rows(0).Item("Enero") + dTable21.Rows(0).Item("Febrero") + dTable21.Rows(0).Item("Marzo") + dTable21.Rows(0).Item("Abril") +
                            dTable21.Rows(0).Item("Mayo") + dTable21.Rows(0).Item("Junio") + dTable21.Rows(0).Item("Julio") + dTable21.Rows(0).Item("Agosto") +
                            dTable21.Rows(0).Item("Septiembre") + dTable21.Rows(0).Item("Octubre") + dTable21.Rows(0).Item("Noviembre") + dTable21.Rows(0).Item("Diciembre") > 0
                dView21 = dTable21.DefaultView
                If EmptGraf2 Then
                    Chart2.DataSource = dTable21
                    Chart2.DataBind()
                    Chart2.Titles.Item(0).Text = "Comportamiento Anual de Nuevas Altas por Meses (" & DateTimePicker2.Value.Year & ")"
                    If BVerTabla.Visible Then
                        Chart2.Visible = True
                        DateTimePicker1.Value = mindate1
                    End If

                    Label19.Visible = False
                Else
                    Chart2.Visible = False
                    If BVerTabla.Visible Then Label19.Visible = True Else Label19.Visible = False
                End If

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

            If dTable1.Count() > 0 Then 'CheckBox6.Checked And
                Dim DisInf As String = dTable1.Rows(0).Item("FECHA").ToString()
                Dim original As DateTime = New DateTime(DisInf.Substring(6, 4), DisInf.Substring(3, 2), DisInf.Substring(0, 2))
                DateTimePicker4.Value = original
            End If

            Dim dTable31 As New CM2DataSet.MedicoCitasDataTable
            dTable31 = Me.MedicoCitasTableAdapter1.GetDataBy(DateTimePicker4.Value.Date)
            EmptGraf3 = dTable31.Count() > 0
            If EmptGraf3 Then
                Chart4.DataSource = dTable31
                Chart4.DataBind()
                Chart8.DataSource = dTable31
                Chart8.DataBind()
                Label24.Text = "Citas Diarias Atendidas por Médicos (" & DateTimePicker4.Value.ToString("dd / MM / yyyy") & ")"
                Label20.Visible = False
                If BVerTabla.Visible Then
                    Label24.Visible = True
                    UiGroupBox9.Visible = True
                    UiGroupBox10.Visible = True
                End If

            Else
                Label24.Visible = False
                UiGroupBox9.Visible = False
                UiGroupBox10.Visible = False
                If BVerTabla.Visible Then Label20.Visible = True Else Label20.Visible = False
            End If

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
            fecha4 = DateTimePicker5.Value
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

            If dTable1.Count() > 0 And Not ((DateTimePicker5.Value.Month = DateTimePicker6.Value.Month) And (DateTimePicker5.Value.Year = DateTimePicker6.Value.Year)) Then 'CheckBox7.Checked And
                Dim DisInf As String = dTable1.Rows(0).Item("FECHA").ToString()
                Dim firstOfMonth As DateTime = New DateTime(DisInf.Substring(0, 4), DisInf.Substring(5, 2), 1)
                Dim lastOfMonth As DateTime = firstOfMonth.Date.AddDays(-(firstOfMonth.Day - 1)).AddMonths(1).AddDays(-1)
                If DateTimePicker6.Value.Month = firstOfMonth.Month Then
                    DateTimePicker5.Value = firstOfMonth
                Else
                    DateTimePicker5.Value = firstOfMonth
                    DateTimePicker6.Value = lastOfMonth
                End If
            End If

            Dim dTable41 As New CM2DataSet.EspecialidadCitasDataTable
            dTable41 = Me.EspecialidadCitasTableAdapter1.GetData(DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
            EmptGraf4 = dTable41.Count() > 0
            If EmptGraf4 Then
                Chart5.DataSource = dTable41
                Chart5.DataBind()
                Chart9.DataSource = dTable41
                Chart9.DataBind()
                Label25.Text = "Citas Mensuales por Especialidad (" & DateTimePicker6.Value.ToString("MMMMM yyyy") & ")"
                Label21.Visible = False
                If BVerTabla.Visible Then
                    Label25.Visible = True
                    UiGroupBox11.Visible = True
                    UiGroupBox12.Visible = True
                Else
                    DateTimePicker5.Value = fecha4
                End If

            Else
                Label25.Visible = False
                UiGroupBox11.Visible = False
                UiGroupBox12.Visible = False
                If BVerTabla.Visible Then Label21.Visible = True Else Label21.Visible = False
            End If

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
            fecha5 = DateTimePicker7.Value
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

            If dTable51.Count() > 0 And Not ((DateTimePicker7.Value.Month = DateTimePicker8.Value.Month) And (DateTimePicker7.Value.Year = DateTimePicker8.Value.Year)) Then 'CheckBox8.Checked And
                Dim DisInf As String = dTable51.Rows(0).Item("FECHA").ToString()
                Dim firstOfMonth As DateTime = New DateTime(DisInf.Substring(0, 4), DisInf.Substring(5, 2), 1)
                Dim lastOfMonth As DateTime = firstOfMonth.Date.AddDays(-(firstOfMonth.Day - 1)).AddMonths(1).AddDays(-1)
                If DateTimePicker8.Value.Month = firstOfMonth.Month Then
                    DateTimePicker7.Value = firstOfMonth
                Else
                    DateTimePicker7.Value = firstOfMonth
                    DateTimePicker8.Value = lastOfMonth
                End If
            End If

            dTable5 = Me.Top10_TratamientoTableAdapter1.GetData(DateTimePicker7.Value.Date, DateTimePicker8.Value.Date)

            Dim view As New DataView(dTable5)
            view.Sort = "CantTratamientos ASC"
            Dim dTable As DataTable = view.ToTable()

            EmptGraf5 = dTable5.Count() > 0
            If EmptGraf5 Then
                Chart6.DataSource = dTable
                Chart6.DataBind()
                Chart10.DataSource = dTable5
                Chart10.DataBind()
                Label26.Text = "Top 10 Tratamientos Mensuales (" & DateTimePicker8.Value.ToString("MMMM yyyy") & ")"
                Label22.Visible = False
                If BVerTabla.Visible Then
                    Label26.Visible = True
                    UiGroupBox13.Visible = True
                    UiGroupBox14.Visible = True
                Else
                    DateTimePicker7.Value = fecha5
                End If

            Else
                Label26.Visible = False
                UiGroupBox13.Visible = False
                UiGroupBox14.Visible = False
                If BVerTabla.Visible Then Label22.Visible = True Else Label22.Visible = False
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim fecha As String
        Dim pres As String
        Dim acep As String
        Dim mindate1 As New Date
        mindate1 = DateTimePicker9.Value.Date
        Dim num As String = TextBox7.Text
        Dim Anual As Integer = 0
        If num = "" Then
            num = "1"
        End If
        If CheckBox6.Checked Then
            If num.Length < 4 Or Convert.ToInt16(num) < 2005 Or Convert.ToInt16(num) > Date.Now.Year Then
                MsgBox("El año introducido no es válido", vbExclamation)
                TextBox7.Text = Date.Now.Year
            Else
                Anual = 1
                Dim dTable61 As New CM2DataSet.EstadistDentalDataTable
                Dim dTable6 As New CM2DataSet.EstadistDentalDataTable
                dTable6 = Me.EstadistDentalTableAdapter1.GetData(Anual, num, DateTimePicker9.Value.Date, DateTimePicker10.Value.Date)
                DataGridView6.DataSource = dTable6
                dView6 = dTable6.DefaultView

                Dim view As New DataView(dTable6)
                view.Sort = "FECHA ASC"
                Dim dTable As DataTable = view.ToTable()

                For Each row As DataRow In dTable.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable61.Rows.Add(fecha, pres, acep)
                Next

                dView61 = dTable61.DefaultView

                EmptGraf6 = dTable61.Count() > 0
                If EmptGraf6 Then
                    Chart1.DataSource = dTable61
                    Chart1.DataBind()
                    Chart11.DataSource = dTable61
                    Chart11.DataBind()
                    Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & num & ")"
                    Label23.Visible = False
                    If BVerTabla.Visible Then
                        Label26.Visible = True
                        UiGroupBox15.Visible = True
                        UiGroupBox16.Visible = True
                    End If

                Else
                    Label27.Visible = False
                    UiGroupBox15.Visible = False
                    UiGroupBox16.Visible = False
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

                Dim view As New DataView(dTable6)
                view.Sort = "FECHA ASC"
                Dim dTable As DataTable = view.ToTable()

                For Each row As DataRow In dTable.Rows
                    fecha = If(Not IsDBNull(row.Item("FECHA")), row.Item("FECHA"), "")
                    pres = If(Not IsDBNull(row.Item("Presupuestado")), row.Item("Presupuestado"), "")
                    acep = If(Not IsDBNull(row.Item("Aceptado")), row.Item("Aceptado"), "")
                    Dim fech As DateTime = New DateTime(fecha.Substring(0, 4), fecha.Substring(5, 2), 1)
                    fecha = fech.ToString("MMMM")
                    dTable61.Rows.Add(fecha, pres, acep)
                Next

                EmptGraf6 = dTable61.Count() > 0
                dView61 = dTable61.DefaultView
                If EmptGraf6 Then
                    Chart1.DataSource = dTable61
                    Chart1.DataBind()
                    Chart11.DataSource = dTable61
                    Chart11.DataBind()
                    Label27.Text = "Tratamientos Presupuestados Frente a los Aceptados (" & DateTimePicker10.Value.Year & ")"
                    Label23.Visible = False
                    If BVerTabla.Visible Then
                        Label26.Visible = True
                        UiGroupBox15.Visible = True
                        UiGroupBox16.Visible = True
                        DateTimePicker9.Value = mindate1
                    End If

                Else
                    Label27.Visible = False
                    UiGroupBox15.Visible = False
                    UiGroupBox16.Visible = False
                    If BVerTabla.Visible Then Label23.Visible = True Else Label23.Visible = False
                End If

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

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView3

            If dView3.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R3_CitasAtendidasMedicosXDias.rdlc", {rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage4.Selected Then

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView4

            If dView4.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R4_CitasEspecialidadXMes.rdlc", {rpt1})
            Else
                MsgBox("No hay información disponible para imprimir", vbExclamation)
            End If

        End If

        If UiTabPage5.Selected Then

            Dim rpt1 As New Microsoft.Reporting.WinForms.ReportDataSource
            rpt1.Name = "DataSet3"
            rpt1.Value = dView5

            If dView5.Count() > 0 Then
                UI.Reportes.ReportesManager.Imprime("R5_Top10TratamientosXMes.rdlc", {rpt1})
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
                UiGroupBox8.Visible = True
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
                Label24.Visible = True
                UiGroupBox9.Visible = True
                UiGroupBox10.Visible = True
            Else
                Label24.Visible = False
                UiGroupBox9.Visible = False
                UiGroupBox10.Visible = False
                Label20.Visible = True
            End If
            DataGridView3.Visible = False
            TextBox3.Enabled = False
            'CheckBox6.Visible = True
        End If

        '***Planel4***
        If UiTabPage4.TabVisible Then
            If EmptGraf4 Then
                Label21.Visible = False
                Label25.Visible = True
                UiGroupBox11.Visible = True
                UiGroupBox12.Visible = True
            Else
                Label25.Visible = False
                UiGroupBox11.Visible = False
                UiGroupBox12.Visible = False
                Label21.Visible = True
            End If
            If Not (DateTimePicker5.Value.Month = DateTimePicker6.Value.Month And DateTimePicker5.Value.Year = DateTimePicker6.Value.Year) Then
                DateTimePicker5.Value = New DateTime(DateTimePicker6.Value.Year, DateTimePicker6.Value.Month, 1)
            End If
            DataGridView4.Visible = False
            TextBox4.Enabled = False
            'CheckBox7.Visible = True
        End If

        '***Planel5***
        If UiTabPage5.TabVisible Then
            If EmptGraf5 Then
                Label22.Visible = False
                Label26.Visible = True
                UiGroupBox13.Visible = True
                UiGroupBox14.Visible = True
            Else
                Label26.Visible = False
                UiGroupBox13.Visible = False
                UiGroupBox14.Visible = False
                Label22.Visible = True
            End If
            If Not (DateTimePicker7.Value.Month = DateTimePicker8.Value.Month And DateTimePicker7.Value.Year = DateTimePicker8.Value.Year) Then
                DateTimePicker7.Value = New DateTime(DateTimePicker8.Value.Year, DateTimePicker8.Value.Month, 1)
            End If
            DataGridView5.Visible = False
            TextBox5.Enabled = False
            'CheckBox8.Visible = True
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
            'CheckBox6.Visible = False
            Label24.Visible = False
            DataGridView3.Visible = True
            TextBox3.Enabled = True
        End If

        '***Planel4***
        If UiTabPage4.TabVisible Then
            UiGroupBox11.Visible = False
            UiGroupBox12.Visible = False
            Label21.Visible = False
            Label25.Visible = False
            DateTimePicker5.Value = fecha4
            'CheckBox7.Visible = False
            DataGridView4.Visible = True
            TextBox4.Enabled = True
        End If

        '***Planel5***
        If UiTabPage5.TabVisible Then
            UiGroupBox13.Visible = False
            UiGroupBox14.Visible = False
            Label22.Visible = False
            Label26.Visible = False
            DateTimePicker7.Value = fecha5
            'CheckBox8.Visible = False
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