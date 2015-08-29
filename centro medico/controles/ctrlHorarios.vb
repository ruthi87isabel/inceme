Public Class ctrlHorarios

    Public Enum TipoFecha
        DiasLaborables = 1
        DiasNoLaborables = 2
        DiasNoLaborables_qNoCuentanVacaciones = 3
        DiasNoLaborables_qSiCuentanVacaciones = 4
        Fiestas = 5
    End Enum

    Public Enum TipoCalendarioEnum
        Calendario_Global
        Calendario_Medicos
        Calendario_Usuarios
    End Enum

    Public DiasNoLaborables As New List(Of Pabo.Calendar.DateItem)
    Public DiasNoLaborables_qNoCuentanVacaciones As New List(Of Pabo.Calendar.DateItem)
    Public DiasNoLaborables_qSiCuentanVacaciones As New List(Of Pabo.Calendar.DateItem)
    Public Fiestas As New List(Of Pabo.Calendar.DateItem)
    Private _medicoid As Integer

    Public Calendarios(11) As Pabo.Calendar.MonthCalendar

    Public Event SeleccionarRangoEnTodosLosCalendarios(ByVal starDate As Date, ByVal endDate As Date)
    Public Event PropagarATodosLosCalendarios(ByVal infos() As Pabo.Calendar.DateItem, ByVal index As Integer)
    Public Event PropagarTipoFechaATodosLosCalendarios(ByVal dates As Pabo.Calendar.SelectedDatesCollection, ByVal tipoFecha As TipoFecha, ByVal index As Integer, ByVal just As String)

    Public Event FechaModificada(ByVal fecha As DateTime, ByVal idCalendario As String, ByVal tipoCalendario As ctrlHorarios.TipoCalendarioEnum, ByVal tipoFecha As ctrlHorarios.TipoFecha, ByVal just As String)
    Public Event AuditarClonacion(ByVal msg As String)

    Public Event StartMultiSelectionEvent(ByRef sender As Object)
    Public Event EndMultiSelectionEvent(ByRef sender As Object)
    Public Event ClearSeleccionEvent()

    Public Event DiaSeleccionado(ByVal sender As System.Object, ByVal e As Pabo.Calendar.DaySelectedEventArgs)

    Public TipoCalendario As TipoCalendarioEnum
    Public Styles_Laborables As New Pabo.Calendar.DateItem
    Public Styles_DiasNoLaborables As New Pabo.Calendar.DateItem
    Public Styles_DiasNoLaborables_qNoCuentanVacaciones As New Pabo.Calendar.DateItem
    Public Styles_DiasNoLaborables_qSiCuentanVacaciones As New Pabo.Calendar.DateItem
    Public Styles_Fiestas As New Pabo.Calendar.DateItem

    Private year As Integer = Date.Now.Year
    Private xmlCalendarios As String

    Private SoloLectura As Boolean = False

    Public Property Anno As Integer
        Get
            Return Me.year
        End Get
        Set(value As Integer)
            Me.year = value
            CargaCalendarios()
        End Set
    End Property

    Public Property CalendarioXML As String
        Get
            Return xmlCalendarios
        End Get
        Set(value As String)
            If Not value Is Nothing Then
                xmlCalendarios = value
                CargaXML()
                'Me.Refresh()
            End If
        End Set
    End Property

    Public Property medicoid As Integer
        Get
            Return _medicoid
        End Get
        Set(value As Integer)
            _medicoid = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Calendarios(0) = MonthCalendar1
        Calendarios(1) = MonthCalendar2
        Calendarios(2) = MonthCalendar3
        Calendarios(3) = MonthCalendar4

        Calendarios(4) = MonthCalendar5
        Calendarios(5) = MonthCalendar6
        Calendarios(6) = MonthCalendar7
        Calendarios(7) = MonthCalendar8

        Calendarios(8) = MonthCalendar9
        Calendarios(9) = MonthCalendar10
        Calendarios(10) = MonthCalendar11
        Calendarios(11) = MonthCalendar12


        Styles_Laborables.BackColor1 = lbl_Laborables.BackColor
        Styles_Laborables.DateColor = lbl_Laborables.ForeColor

        Styles_DiasNoLaborables.BackColor1 = lblNoLaborables.BackColor
        Styles_DiasNoLaborables.DateColor = lblNoLaborables.ForeColor

        Styles_DiasNoLaborables_qNoCuentanVacaciones.BackColor1 = lblDiasNoLaborablesQueNoCuentan.BackColor
        Styles_DiasNoLaborables.DateColor = lblDiasNoLaborablesQueNoCuentan.ForeColor

        Styles_DiasNoLaborables_qSiCuentanVacaciones.BackColor1 = lblDiasNoLaborablesQueSIICuentan.BackColor
        Styles_DiasNoLaborables_qSiCuentanVacaciones.DateColor = lblDiasNoLaborablesQueSIICuentan.ForeColor

        Styles_Fiestas.BackColor1 = lblFiestas.BackColor
        Styles_Fiestas.DateColor = lblFiestas.ForeColor

    End Sub

    Private Sub ctrlHorarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaCalendarios()
    End Sub

    Public Sub CargaCalendarios()
        Dim startYear As Date = New Date(anno, 1, 1)

        Dim i As Integer = 0
        For i = 0 To 11
            Dim fecha As Date = startYear.AddMonths(i)
            Calendarios(i).Dates.Clear()
            Calendarios(i).ActiveMonth.Year = fecha.Year
            Calendarios(i).ActiveMonth.Month = fecha.Month
            Calendarios(i).Tag = _medicoid
        Next
    End Sub

    '    Private Sub MarcaDia(ByVal day As DayOfWeek, ByVal selecc As Boolean)
    '        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
    '            If selecc Then
    '                calen.SelectWeekday(day)
    '            Else
    '                calen.DeselectWeekday(day)
    '                'calen.()
    '                'calen.d
    '            End If
    '        Next
    '    End Sub

    Private Sub btnSelTodosLosFinesSemana_Click(sender As System.Object, e As System.EventArgs) Handles btnSelTodosLosFinesSemana.Click
        RaiseEvent StartMultiSelectionEvent(Me)
        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            calen.SelectWeekday(DayOfWeek.Saturday)
            calen.SelectWeekday(DayOfWeek.Sunday)
        Next
        RaiseEvent EndMultiSelectionEvent(Me)
    End Sub
    
    Private Sub btnSelecTodosSabados_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecTodosSabados.Click
        RaiseEvent StartMultiSelectionEvent(Me)
        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            calen.SelectWeekday(DayOfWeek.Saturday)
        Next
        RaiseEvent EndMultiSelectionEvent(Me)
    End Sub

    Private Sub btnSelecTodosDomingos_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecTodosDomingos.Click
        RaiseEvent StartMultiSelectionEvent(Me)
        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            calen.SelectWeekday(DayOfWeek.Sunday)
        Next
        RaiseEvent EndMultiSelectionEvent(Me)
    End Sub

    Private Sub btnSeleccDesde_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccDesde.Click
        RaiseEvent StartMultiSelectionEvent(Me)
        SeleccionaRango(dtpSelecDesde.Value, dtpSelecHasta.Value)
        RaiseEvent EndMultiSelectionEvent(Me)
    End Sub

    Public Sub SeleccionaRango(ByVal starDate As Date, ByVal endDate As Date)
        If starDate.ToShortDateString() = endDate.ToShortDateString() Then
            Calendarios(starDate.Month - 1).SelectDate(starDate)
            Return
        End If

        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios

            Dim c1 As Date = New Date(calen.ActiveMonth.Year, calen.ActiveMonth.Month, 1)
            Dim c2 As Date = New Date(calen.ActiveMonth.Year, calen.ActiveMonth.Month, Date.DaysInMonth(calen.ActiveMonth.Year, calen.ActiveMonth.Month))




            'Casos fuera, el intervalo starDate - endDate, esta por delante o detras el intervalo c1-c2

            If (c1 < starDate And c2 < starDate) Or _
               (c1 > endDate And c2 > endDate) Then
                'No marcar nada
                Continue For
            End If


            'Caso 6 embedido completo c1-c2 dentro de a-b
            If starDate >= c1 And endDate <= c2 Then
                calen.SelectRange(starDate, endDate)
                Continue For
            End If

            'Caso 1 embebido completo a-b dentro de c1-c2
            If c1 >= starDate And c2 <= endDate Then
                'Se marca todo
                calen.SelectRange(c1, c2)
                Continue For
            End If


            'Casos 2 y 3, solapamiento parcial

            'If (starDate >= fechaInic And starDate <= fechaFin) Or
            '     (endDate <= fechaFin And endDate >= fechaInic) Then
            c1 = New DateTime(Math.Max(starDate.Ticks, c1.Ticks))
            c2 = New DateTime(Math.Min(endDate.Ticks, c2.Ticks))

            calen.SelectRange(c1, c2)
            'End If

        Next
    End Sub

    Private Sub btnSelecDeseleccioanr_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecDeseleccioanr.Click

        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            calen.ClearSelection()
        Next
    End Sub

    '    Private Sub btnSelecRangeEnTodosLosCalendarios_Click(sender As System.Object, e As System.EventArgs)
    '        RaiseEvent SeleccionarRangoEnTodosLosCalendarios(dtpSelecDesde.Value, dtpSelecHasta.Value)
    '    End Sub

    'Private Sub dtpYear_ValueChanged_1(sender As System.Object, e As System.EventArgs)
    '    CargaCalendarios()
    'End Sub

    ''    Private Sub dtpYear_ValueChanged(sender As System.Object, e As System.EventArgs)
    ''        CargaCalendarios()
    ''    End Sub

    'Private Sub chkLunes_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Monday, sender.Checked)
    'End Sub

    'Private Sub chkMartes_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Tuesday, sender.Checked)
    'End Sub

    'Private Sub chkMiercoles_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Wednesday, sender.Checked)
    'End Sub

    'Private Sub chkJueves_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Thursday, sender.Checked)
    'End Sub

    'Private Sub chkViernes_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Friday, sender.Checked)
    'End Sub

    'Private Sub chkSabado_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Saturday, sender.Checked)
    'End Sub

    'Private Sub chkDomingo_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    MarcaDia(DayOfWeek.Sunday, sender.Checked)
    'End Sub

    Public Sub AplicaFormatoSeleccionadas(ByVal tipoFecha As TipoFecha, ByVal justificacion As String, ByVal disparaAuditoria As Boolean)

        Dim formato As Pabo.Calendar.DateItem
        Select Case tipoFecha
            Case tipoFecha.DiasLaborables
                formato = Styles_Laborables
            Case tipoFecha.DiasNoLaborables
                formato = Styles_DiasNoLaborables
            Case tipoFecha.DiasNoLaborables_qNoCuentanVacaciones
                formato = Styles_DiasNoLaborables_qNoCuentanVacaciones
            Case tipoFecha.DiasNoLaborables_qSiCuentanVacaciones
                formato = Styles_DiasNoLaborables_qSiCuentanVacaciones
            Case tipoFecha.Fiestas
                formato = Styles_Fiestas
        End Select



        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            For Each selecDate As Date In calen.SelectedDates
                If calen.GetDateInfo(selecDate).Count > 0 Then
                    calen.RemoveDateInfo(calen.GetDateInfo(selecDate)(0))
                End If
                calen.RemoveDateInfo(selecDate)

                Dim info As New Pabo.Calendar.DateItem()
                info.Date = selecDate
                info.DateColor = formato.DateColor
                info.BackColor1 = formato.BackColor1
                info.BackColor2 = formato.BackColor2
                info.Tag = New DateContainer(tipoFecha, info, Justificacion)
                calen.AddDateInfo(info)

                'Auditar aqui



                If (disparaAuditoria) Then
                    'Auditoria
                    'Dim tipoCalendario As String
                    Dim idCalendario As String = ""
                    'Dim tipoFechaStr As String = [Enum].GetName(GetType(ctrlHorarios.TipoFecha), tipoFecha)
                    If Me.Tag.GetType().Equals(GetType(CALENDARIO_GLOBAL)) Then
                        Dim calendario As CALENDARIO_GLOBAL = Me.Tag
                        'calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
                        'tipoCalendario = "CALENDARIO_GLOBAL"
                        idCalendario = calendario.ID.ToString()
                    End If

                    If Me.Tag.GetType().Equals(GetType(CALENDARIO_MEDICO)) Then
                        Dim calendario As CALENDARIO_MEDICO = Me.Tag
                        'calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
                        'tipoCalendario = "CALENDARIO_GLOBAL"
                        idCalendario = calendario.ID.ToString()
                    End If

                    If Me.Tag.GetType().Equals(GetType(CALENDARIO_USUARIO)) Then
                        Dim calendario As CALENDARIO_USUARIO = Me.Tag
                        'calendario.Calendario = XElement.Parse(ctrlHora.SalvaToXml())
                        ' tipoCalendario = "CALENDARIO_GLOBAL"
                        idCalendario = calendario.ID.ToString()
                    End If
                    RaiseEvent FechaModificada(selecDate, idCalendario, Me.TipoCalendario, tipoFecha, Justificacion)
                End If

            Next
            'calen.ClearSelection()
        Next

        'CuentaFechas()
    End Sub

    Public Sub CuentaFechas()
        DiasNoLaborables.Clear()
        DiasNoLaborables_qNoCuentanVacaciones.Clear()
        DiasNoLaborables_qSiCuentanVacaciones.Clear()
        Fiestas.Clear()

        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            For Each info As Pabo.Calendar.DateItem In calen.Dates

                If Not info.Tag Is Nothing Then
                    Dim container As DateContainer = info.Tag
                    Select Case container.Tipo
                        'Case TipoFecha.DiasLaborables
                        'nodeDiasLaborables += Str()
                        Case TipoFecha.DiasNoLaborables
                            DiasNoLaborables.Add(info)
                        Case TipoFecha.DiasNoLaborables_qNoCuentanVacaciones
                            DiasNoLaborables_qNoCuentanVacaciones.Add(info)
                        Case TipoFecha.DiasNoLaborables_qSiCuentanVacaciones
                            DiasNoLaborables_qSiCuentanVacaciones.Add(info)
                        Case TipoFecha.Fiestas
                            Fiestas.Add(info)
                    End Select
                End If

            Next
        Next

        lblCant1.Text = DiasNoLaborables.Count
        lblCant2.Text = DiasNoLaborables_qNoCuentanVacaciones.Count
        lblCant3.Text = DiasNoLaborables_qSiCuentanVacaciones.Count
        lblCant4.Text = Fiestas.Count

    End Sub

    Public Sub ClearSelection()
        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            calen.ClearSelection()
        Next
        'CuentaFechas()
    End Sub
    
    Private Sub btnAplicarDias_Laborables_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarDias_Laborables.Click
        AplicaFormatoSeleccionadas(TipoFecha.DiasLaborables, "", True)

        ClearSelection()
    End Sub

    Private Sub btnAplicarDiasNoLaborables_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarDiasNoLaborables.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then

            AplicaFormatoSeleccionadas(TipoFecha.DiasNoLaborables, frm.txtMessage.Text, True)
            ClearSelection()
        End If
        
    End Sub

    Private Sub btnAplicarDiasLabNoCuentan_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarDiasLabNoCuentan.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            AplicaFormatoSeleccionadas(TipoFecha.DiasNoLaborables_qNoCuentanVacaciones, frm.txtMessage.Text, True)
            ClearSelection()
        End If

    End Sub

    Private Sub btnAplicarDiasLabSICuentan_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarDiasLabSICuentan.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            AplicaFormatoSeleccionadas(TipoFecha.DiasNoLaborables_qSiCuentanVacaciones, frm.txtMessage.Text, True)
            ClearSelection()
        End If
    End Sub
    
    Private Sub btnAplicFiestas_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicFiestas.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            AplicaFormatoSeleccionadas(TipoFecha.Fiestas, frm.txtMessage.Text, True)
            ClearSelection()
        End If

    End Sub

    Private Sub btnPropagar_Click(sender As System.Object, e As System.EventArgs) Handles btnPropagar.Click

        If MessageBox.Show("Esta acción sobreescribirá los demás calendarios, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim index As Integer = 0

            RaiseEvent AuditarClonacion("Clonacion de Calendario Global Año " & Me.Anno.ToString())

            For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
                RaiseEvent PropagarATodosLosCalendarios(calen.GetDateInfo(), index)
                index += 1
            Next

        End If
        
    End Sub

    Public Sub MarcaFechas(ByVal fechas() As Pabo.Calendar.DateItem, ByVal calIndex As Integer)

        Calendarios(calIndex).AddDateInfo(fechas)
        'For Each item As Pabo.Calendar.DateItem In fechas
        'Calendarios(calIndex).GetDateInfo(item.Date) Is Nothing Then

        'Next
    End Sub

    Public Sub VaciaCalendario(ByVal calIndex As Integer)
        Calendarios(calIndex).Dates.Clear()
    End Sub

    Public Sub MarcaFecha(ByVal fecha As Date, ByVal calIndex As Integer)

        Calendarios(calIndex).SelectDate(fecha)
        'For Each item As Pabo.Calendar.DateItem In fechas
        'Calendarios(calIndex).GetDateInfo(item.Date) Is Nothing Then

        'Next
    End Sub

    Public Function SalvaToXml() As String
        'Retorna el XML de cada cosa
        Dim nodeDiasLaborables As String = ""
        Dim nodeDiasNOLaborables As String = ""
        Dim nodeDiasNoLaborables_qNoCuentanVacaciones As String = ""
        Dim nodeDiasNoLaborables_qSiCuentanVacaciones As String = ""
        Dim nodeFiestas As String = ""



        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            For Each fecha As Pabo.Calendar.DateItem In calen.Dates
                Dim container As DateContainer = fecha.Tag
                Dim just As String = container.Justificacion
                If just Is Nothing Then
                    just = ""
                End If
                Dim str As String = String.Format("<DIA Fecha='{0}' Justificacion='{1}'/>", fecha.Date.ToString("dd/MM/yyyy"), just) & vbCrLf

                Select Case container.Tipo
                    Case TipoFecha.DiasLaborables
                        nodeDiasLaborables += str
                    Case TipoFecha.DiasNoLaborables
                        nodeDiasNOLaborables += str
                    Case TipoFecha.DiasNoLaborables_qNoCuentanVacaciones
                        nodeDiasNoLaborables_qNoCuentanVacaciones += str
                    Case TipoFecha.DiasNoLaborables_qSiCuentanVacaciones
                        nodeDiasNoLaborables_qSiCuentanVacaciones += str
                    Case TipoFecha.Fiestas
                        nodeFiestas += str
                End Select
            Next
        Next

        Dim xml As String = "<Calendario>" _
                            & "<DiasLaborables>" _
                            & nodeDiasLaborables _
                            & "</DiasLaborables>" _
                            & "<DiasNoLaborables>" _
                            & nodeDiasNOLaborables _
                            & "</DiasNoLaborables>" _
                            & "<DiasNoLaborables_qNoCuentanVacaciones>" _
                            & nodeDiasNoLaborables_qNoCuentanVacaciones _
                            & "</DiasNoLaborables_qNoCuentanVacaciones>" _
                            & "<DiasNoLaborables_qSiCuentanVacaciones>" _
                            & nodeDiasNoLaborables_qSiCuentanVacaciones _
                            & "</DiasNoLaborables_qSiCuentanVacaciones>" _
                             & "<Fiestas>" _
                            & nodeFiestas _
                            & "</Fiestas>" _
                            & "</Calendario>"
        Return xml
    End Function

    Private Sub CargaXML()
        If xmlCalendarios Is Nothing Then
            Return
        End If

        'Try
        Dim xml As New System.Xml.XmlDocument()
        xml.LoadXml(xmlCalendarios)
        If (medicoid = 3) Then
            Dim a As Object = ""
        End If
        For Each node As System.Xml.XmlElement In xml.FirstChild.ChildNodes

            Dim tipo As TipoFecha = [Enum].Parse(GetType(TipoFecha), node.Name)
            For Each dias As System.Xml.XmlElement In node.ChildNodes
                Console.Write(dias.Attributes("Fecha").Value & vbCrLf)
                Dim fecha As Date = Date.ParseExact(dias.Attributes("Fecha").Value, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None)
                Dim just As String = dias.Attributes("Justificacion").Value
                SeleccionaRango(fecha, fecha)
                AplicaFormatoSeleccionadas(tipo, just, False)
                ClearSelection()
            Next
        Next

        'Catch ex As Exception

        'End Try
        ClearSelection()

        'CuentaFechas()

    End Sub

    Private Sub btnLaborablesATodos_Click(sender As System.Object, e As System.EventArgs) Handles btnLaborablesATodos.Click
        Dim index As Integer = 0
        For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
            RaiseEvent PropagarTipoFechaATodosLosCalendarios(calen.SelectedDates, TipoFecha.DiasLaborables, index, "")
            index += 1
        Next
        RaiseEvent ClearSeleccionEvent()
    End Sub

    Private Sub btnNOLaborablesATodos_Click(sender As System.Object, e As System.EventArgs) Handles btnNOLaborablesATodos.Click

        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim index As Integer = 0
            For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
                If calen.SelectedDates.Count > 0 Then
                    RaiseEvent PropagarTipoFechaATodosLosCalendarios(calen.SelectedDates, TipoFecha.DiasNoLaborables, index, frm.txtMessage.Text)
                End If

                index += 1
            Next
            RaiseEvent ClearSeleccionEvent()
        End If

       
    End Sub

    Private Sub btnDiasqueNOCuentanATodos_Click(sender As System.Object, e As System.EventArgs) Handles btnDiasqueNOCuentanATodos.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim index As Integer = 0
            For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
                RaiseEvent PropagarTipoFechaATodosLosCalendarios(calen.SelectedDates, TipoFecha.DiasNoLaborables_qNoCuentanVacaciones, index, frm.txtMessage.Text)
                index += 1
            Next
            RaiseEvent ClearSeleccionEvent()
        End If

    End Sub

    Private Sub btnDiasqueSICuentanATodos_Click(sender As System.Object, e As System.EventArgs) Handles btnDiasqueSICuentanATodos.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim index As Integer = 0
            For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
                RaiseEvent PropagarTipoFechaATodosLosCalendarios(calen.SelectedDates, TipoFecha.DiasNoLaborables_qSiCuentanVacaciones, index, frm.txtMessage.Text)
                index += 1
            Next
            RaiseEvent ClearSeleccionEvent()
        End If

    End Sub

    Private Sub btnFiestasATodos_Click(sender As System.Object, e As System.EventArgs) Handles btnFiestasATodos.Click
        Dim frm As New frmHorarios_Justificacion()
        If frm.ShowDialog() = DialogResult.OK Then

            Dim index As Integer = 0
            For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
                RaiseEvent PropagarTipoFechaATodosLosCalendarios(calen.SelectedDates, TipoFecha.Fiestas, index, frm.txtMessage.Text)
                index += 1
            Next
            RaiseEvent ClearSeleccionEvent()
        End If


    End Sub

    Private Sub DiasSeleccionado(sender As System.Object, e As Pabo.Calendar.DaySelectedEventArgs) Handles MonthCalendar9.DaySelected, MonthCalendar8.DaySelected, MonthCalendar7.DaySelected, MonthCalendar6.DaySelected, MonthCalendar5.DaySelected, MonthCalendar4.DaySelected, MonthCalendar3.DaySelected, MonthCalendar2.DaySelected, MonthCalendar12.DaySelected, MonthCalendar11.DaySelected, MonthCalendar10.DaySelected, MonthCalendar1.DaySelected
        'devuelve los días seleccionados.
        'Return e
        ' RaiseEvent StartMultiSelectionEvent(Me)
        RaiseEvent DiaSeleccionado(sender, e)
        '  RaiseEvent EndMultiSelectionEvent(Me)
    End Sub

    Private Sub MonthCalendar1_DayDoubleClick(sender As System.Object, e As Pabo.Calendar.DayClickEventArgs) Handles MonthCalendar9.DayDoubleClick, MonthCalendar8.DayDoubleClick, MonthCalendar7.DayDoubleClick, MonthCalendar6.DayDoubleClick, MonthCalendar5.DayDoubleClick, MonthCalendar4.DayDoubleClick, MonthCalendar3.DayDoubleClick, MonthCalendar2.DayDoubleClick, MonthCalendar12.DayDoubleClick, MonthCalendar11.DayDoubleClick, MonthCalendar10.DayDoubleClick, MonthCalendar1.DayDoubleClick

        Dim calendar As Pabo.Calendar.MonthCalendar = sender

        If calendar.GetDateInfo(e.Date).Count > 0 Then
            Dim container As DateContainer = calendar.GetDateInfo(e.Date)(0).Tag
            If Not container.Justificacion Is Nothing Then
                If container.Justificacion.Trim() <> String.Empty Then
                    Dim frm As New frmHorarios_Justificacion()
                    frm.txtMessage.Text = container.Justificacion
                    frm.txtMessage.ReadOnly = SoloLectura
                    frm.ShowDialog()
                End If

            End If
        End If



    End Sub

    Private Sub MonthCalendar1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MonthCalendar9.KeyDown, MonthCalendar8.KeyDown, MonthCalendar7.KeyDown, MonthCalendar6.KeyDown, MonthCalendar5.KeyDown, MonthCalendar4.KeyDown, MonthCalendar3.KeyDown, MonthCalendar2.KeyDown, MonthCalendar12.KeyDown, MonthCalendar11.KeyDown, MonthCalendar10.KeyDown, MonthCalendar1.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Pabo.Calendar.MonthCalendar.CtrlPressed = True
        End If
    End Sub

    Private Sub MonthCalendar1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MonthCalendar9.KeyUp, MonthCalendar8.KeyUp, MonthCalendar7.KeyUp, MonthCalendar6.KeyUp, MonthCalendar5.KeyUp, MonthCalendar4.KeyUp, MonthCalendar3.KeyUp, MonthCalendar2.KeyUp, MonthCalendar12.KeyUp, MonthCalendar11.KeyUp, MonthCalendar10.KeyUp, MonthCalendar1.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            Pabo.Calendar.MonthCalendar.CtrlPressed = False
        End If
    End Sub
    
    Public Sub ActivarSoloLectura()
        'For Each calen As Pabo.Calendar.MonthCalendar In Calendarios
        '    calen.Enabled = False
        'Next

        Me.SoloLectura = True

        btnAplicarDias_Laborables.Visible = False
        btnAplicarDiasLabNoCuentan.Visible = False
        btnAplicarDiasLabSICuentan.Visible = False
        btnAplicarDiasNoLaborables.Visible = False
        btnAplicFiestas.Visible = False

        btnLaborablesATodos.Visible = False
        btnDiasqueNOCuentanATodos.Visible = False
        btnDiasqueSICuentanATodos.Visible = False
        btnFiestasATodos.Visible = False

        grpSeleccionar.Visible = False
        grpLeyenda.Width = 182


    End Sub
    
End Class

Public Class RegistroCambiosAuditoria
    Public idDocumento As String = ""

    Public Accion As Globales.AuditoriaInfo.Accion = Globales.AuditoriaInfo.Accion.Modificar
    Public eLocacion As RoleManager.Items = RoleManager.Items.Horarios
    Public TipoDocumento As String
    Public codigoDocumento As String
    Public DetallesDocumento As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim reg2 As RegistroCambiosAuditoria = obj
        Return Accion = reg2.Accion And _
               eLocacion = reg2.eLocacion And _
               TipoDocumento = reg2.TipoDocumento And _
               codigoDocumento = reg2.codigoDocumento And _
               DetallesDocumento = reg2.DetallesDocumento And _
               idDocumento = reg2.idDocumento
    End Function
End Class

