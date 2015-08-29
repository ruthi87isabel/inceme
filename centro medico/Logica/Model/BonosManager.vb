Partial Public Class Bonos
    'Uso estas dos propiedades para filtrar
    Public CodigoPaciente As Integer = -1
    Public CodigoFactura As Integer = -1

    'necesitaremos setear el contexto para operar con la bd.
    Public context As CMLinqDataContext


    Public Function cargaBonos() As IQueryable(Of Bonos)
        If context Is Nothing Then
            Return Nothing
        End If
        Dim bonos As IQueryable(Of Bonos) = (From a In context.Bonos Select a).AsQueryable
        If CodigoPaciente <> -1 Then
            bonos = bonos.Where(Function(b) b.cpaciente = CodigoPaciente)
        End If
        If CodigoFactura <> -1 Then
            bonos = bonos.Where(Function(b) b.idfactura = CodigoFactura)
        End If

        Return bonos
    End Function

    Public ReadOnly Property descripcionConSesionesLibres()
        Get
            Return Me.Notas & " (" & Me.sesionesLibres & " sesión libre)"
        End Get
    End Property

    Public ReadOnly Property sesionesLibres()
        Get
            Dim sesionesusadas As Integer = Me.Sesiones.Count

            Dim _sesioneslibres As Integer = Me.numsesiones - sesionesusadas
            Return _sesioneslibres

        End Get
    End Property

    Public Sub AsociaCitaSesion(ByRef cita As CITA)
        Dim sesion As New Sesiones
        sesion.CITA = cita
        sesion.fecha = cita.FECHA
        sesion.descripcion = "Sesión creada desde la cita del " & cita.FECHA & " para " & cita.PACIENTE
        Me.Sesiones.Add(sesion)
        context.SubmitChanges()
    End Sub


    ''' <summary>
    ''' Función que devuelte el primer bono (según orden cronológico) que no ha agotado las sesiones contratadas.
    ''' </summary>
    ''' <param name="paciente">código del paciente del que se van a consultar los bonos</param>
    ''' <returns>Devuelve un objeto de tipo "Bonos"</returns>
    ''' <remarks></remarks>
    Public Shared Function bonoUtil(ByVal paciente As Integer, ByRef context As CMLinqDataContext, Optional ByRef SeleccionarBono As Boolean = False) As Bonos
        Dim bonos As IEnumerable(Of Bonos) = (From x In context.Bonos Where x.cpaciente = paciente Order By x.fecha Ascending Select x).AsEnumerable
        Dim bono As ICollection(Of Bonos) = New List(Of Bonos)

        For Each b As Bonos In bonos
            If b.sesionesLibres > 0 Then
                bono.Add(b)
                If Not SeleccionarBono Then Exit For
            End If
        Next

        If SeleccionarBono Then
            Dim elegirform As New Elegir_bono(bono)
            Dim idBonoElegido As Integer
            Dim bonoElegido As Bonos

            If elegirform.ShowDialog() = DialogResult.OK Then
                idBonoElegido = elegirform.bonoSeleccionado
                bonoElegido = (From x In context.Bonos Where x.id = idBonoElegido Select x).SingleOrDefault
                Return bonoElegido
            End If
        Else
            If bono.Count > 0 Then Return bono.First Else Return Nothing
        End If


    End Function


End Class
