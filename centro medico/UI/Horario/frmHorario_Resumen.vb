Imports System.Xml
Imports System.Xml.Linq
Imports centro_medico.UI.Reportes

Public Class frmHorario_Resumen

    Private Sub frmHorario_Resumen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaDatos()
    End Sub

    Public Sub CargaDatos()
        'Hacerlo a lo crudo
        Dim context As New CMLinqDataContext
        Dim list As New List(Of HorarioEntry)
        Dim calendario As CALENDARIO_MEDICO = (From c In context.CALENDARIO_MEDICOs Where c.ID_MEDICO = CtrlMedico1.ID_Medico _
                                              And c.Anno = dtpYear.Value.Year _
                                              Select c).SingleOrDefault()
        If Not calendario Is Nothing Then
            Dim xml As XElement = calendario.Calendario

            For Each node As XElement In xml.Nodes
                Dim tipo As ctrlHorarios.TipoFecha = [Enum].Parse(GetType(ctrlHorarios.TipoFecha), node.Name.ToString())

                If tipo <> ctrlHorarios.TipoFecha.DiasLaborables Then
                    For Each dias As XElement In node.Nodes

                        Dim fecha As Date = Date.ParseExact(dias.Attribute("Fecha").Value, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None)
                        Dim just As String = dias.Attribute("Justificacion").Value
                        Dim entry As New HorarioEntry()
                        entry.Fecha = fecha
                        entry.Justificacion = just
                        entry.Medico = CtrlMedico1.Medico.NOMBRECOMPLETO
                        entry.Tipo = tipo
                        list.Add(entry)
                    Next
                End If
            Next
            GridEX1.DataSource = list
        End If

    End Sub

    Private Sub CtrlMedico1_MEDICOSeleccionado(IdMedico As System.Int32, oldMedico As System.Nullable(Of Integer), IsReturnPressed As System.Boolean) Handles CtrlMedico1.MEDICOSeleccionado
        CargaDatos()
    End Sub

    Private Sub dtpYear_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpYear.ValueChanged
        CargaDatos()
    End Sub

    
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
     
        Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource()
        dsMedico.Name = "dsMedico"
        dsMedico.Value = New List(Of MEDICO)
        dsMedico.Value.Add(CtrlMedico1.Medico)

        Dim dsEntries As New Microsoft.Reporting.WinForms.ReportDataSource()
        dsEntries.Name = "dsEntries"
        dsEntries.Value = GridEX1.DataSource

        UI.Reportes.ReportesManager.Imprime("MedicosHorariosListado.rdlc", {dsMedico, dsEntries})

    End Sub

End Class