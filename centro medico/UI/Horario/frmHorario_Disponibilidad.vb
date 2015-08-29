Imports System.Xml
Imports System.Xml.Linq
Imports centro_medico.UI.Reportes

Public Class frmHorario_Disponibilidad

    Private Sub frmHorario_Disponibilidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDesde.Value = New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0)
        dtpHasta.Value = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)

        CargaDatos()
    End Sub

    Public Sub CargaDatos()
        Dim context As New CMLinqDataContext
        Dim list As New List(Of HorarioEntry)

        If dtpDesde.Value > dtpHasta.Value Then
            MessageBox.Show("Las fecha inicial debe ser menor que la fecha final")
            Return
        End If

        Dim fecha As Date = dtpDesde.Value

        While fecha <= dtpHasta.Value
            For Each med As MEDICO In context.MEDICOs
                Dim calendarioMedico As CALENDARIO_MEDICO = (From c In context.CALENDARIO_MEDICOs _
                                                            Where c.Anno = fecha.Year _
                                                            And c.ID_MEDICO = med.CMEDICO _
                                                            Select c).SingleOrDefault()

                Dim entry As New HorarioEntry()
                entry.Fecha = fecha
                entry.Medico = med.NOMBRECOMPLETO
                entry.Tipo = ctrlHorarios.TipoFecha.DiasLaborables
                entry.Justificacion = ""


                If Not calendarioMedico Is Nothing Then
                    Dim xml As XElement = calendarioMedico.Calendario

                    For Each node As XElement In xml.Nodes
                        Dim tipo As ctrlHorarios.TipoFecha = [Enum].Parse(GetType(ctrlHorarios.TipoFecha), node.Name.ToString())

                        For Each dias As XElement In node.Nodes

                            Dim fech As Date = Date.ParseExact(dias.Attribute("Fecha").Value, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None)
                            If fech.ToShortDateString() = fecha.ToShortDateString() Then
                                Dim just As String = dias.Attribute("Justificacion").Value
                                entry.Justificacion = just
                                entry.Tipo = tipo
                            End If
                        Next
                    Next
                End If
                list.Add(entry)
            Next



            For Each usuario As USUARIO In context.USUARIOs
                If Not usuario.REFMEDICO.HasValue Then

                    Dim calendarioUsuario As CALENDARIO_USUARIO = (From c In context.CALENDARIO_USUARIOs _
                                                                Where c.Anno = fecha.Year _
                                                                And c.ID_Usuario = usuario.CODIGO _
                                                                Select c).SingleOrDefault()

                    Dim entry As New HorarioEntry()
                    entry.Fecha = fecha
                    entry.Usuario = usuario.USUARIO
                    entry.Tipo = ctrlHorarios.TipoFecha.DiasLaborables
                    entry.Justificacion = ""


                    If Not calendarioUsuario Is Nothing Then
                        Dim xml As XElement = calendarioUsuario.Calendario

                        For Each node As XElement In xml.Nodes
                            Dim tipo As ctrlHorarios.TipoFecha = [Enum].Parse(GetType(ctrlHorarios.TipoFecha), node.Name.ToString())

                            For Each dias As XElement In node.Nodes

                                Dim fech As Date = Date.ParseExact(dias.Attribute("Fecha").Value, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None)
                                If fech.ToShortDateString() = fecha.ToShortDateString() Then
                                    Dim just As String = dias.Attribute("Justificacion").Value
                                    entry.Justificacion = just
                                    entry.Tipo = tipo
                                End If
                            Next
                        Next
                    End If
                    list.Add(entry)
                End If

            Next

            fecha = fecha.AddDays(1)
        End While


        

        GridEX1.DataSource = list
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource()
        ds.Name = "dsEntries"
        ds.Value = GridEX1.DataSource
        
        UI.Reportes.ReportesManager.Imprime("MedicosHorariosListado.rdlc", {ds})
    End Sub


    Private Sub btnFiltrar_Click(sender As System.Object, e As System.EventArgs) Handles btnFiltrar.Click
        CargaDatos()
    End Sub
End Class