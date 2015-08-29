Imports centro_medico
Imports System.Xml.Linq
Public Class CalendarioManager

#Region "Public Shared Function DameTipoDiaDe(ByVal idMedico As Integer, ByVal fecha As Date) As ctrlHorarios.TipoFecha"
    Public Shared Function DameTipoDiaDe(ByVal idMedico As Integer, ByVal fecha As Date) As ctrlHorarios.TipoFecha
        'Primero buscar en el calendario del medico
        Dim context As New CMLinqDataContext()

        Dim tipo As Nullable(Of ctrlHorarios.TipoFecha) = Nothing

        Dim calendario As CALENDARIO_MEDICO = (From c In context.CALENDARIO_MEDICOs _
                                               Where c.ID_MEDICO = idMedico _
                                               And c.Anno = fecha.Year _
                                               Select c).SingleOrDefault()
        If Not calendario Is Nothing Then
            tipo = BuscaFechaTipo(fecha, calendario.Calendario)
        End If

        If Not tipo.HasValue Then
            'O no habia calendario medico, o bien no se encontro esa fecha
            'Buscar en los globales
            Dim calendarioGlobal As CALENDARIO_GLOBAL = (From cg In context.CALENDARIO_GLOBALs _
                                                         Where cg.Anno = fecha.Year _
                                                         Select cg).SingleOrDefault()
            If Not calendarioGlobal Is Nothing Then
                tipo = BuscaFechaTipo(fecha, calendarioGlobal.Calendario)
            End If
        End If

        If tipo.HasValue Then
            Return tipo.Value
        End If

        Return ctrlHorarios.TipoFecha.DiasLaborables
    End Function

    Public Shared Function DameTipoDiaDeUsuario(ByVal idUsuario As Integer, ByVal fecha As Date) As ctrlHorarios.TipoFecha
        'Primero buscar en el calendario del medico
        Dim context As New CMLinqDataContext()

        Dim tipo As Nullable(Of ctrlHorarios.TipoFecha) = Nothing

        Dim calendario As CALENDARIO_USUARIO = (From c In context.CALENDARIO_USUARIOs _
                                               Where c.ID_Usuario = idUsuario _
                                               And c.Anno = fecha.Year _
                                               Select c).SingleOrDefault()
        If Not calendario Is Nothing Then
            tipo = BuscaFechaTipo(fecha, calendario.Calendario)
        End If

        If Not tipo.HasValue Then
            'O no habia calendario medico, o bien no se encontro esa fecha
            'Buscar en los globales
            Dim calendarioGlobal As CALENDARIO_GLOBAL = (From cg In context.CALENDARIO_GLOBALs _
                                                         Where cg.Anno = fecha.Year _
                                                         Select cg).SingleOrDefault()
            If Not calendarioGlobal Is Nothing Then
                tipo = BuscaFechaTipo(fecha, calendarioGlobal.Calendario)
            End If
        End If

        If tipo.HasValue Then
            Return tipo.Value
        End If

        Return ctrlHorarios.TipoFecha.DiasLaborables
    End Function


    Private Shared Function BuscaFechaTipo(ByVal fecha As Date, ByRef xml As XElement) As Nullable(Of ctrlHorarios.TipoFecha)
        For Each node As XElement In xml.Nodes
            Dim tipo As ctrlHorarios.TipoFecha = [Enum].Parse(GetType(ctrlHorarios.TipoFecha), node.Name.ToString())
            For Each day As XElement In node.Nodes
                Dim f As Date = Date.ParseExact(day.Attribute("Fecha").Value, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None)
                If f.ToString("dd/MM/yyyy") = fecha.ToString("dd/MM/yyyy") Then
                    Return tipo
                End If
            Next
        Next
        Return Nothing
    End Function
#End Region

    
End Class
