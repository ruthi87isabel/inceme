Public Class WRAPPER_RECETA
    Dim Receta As RECETA
    Dim _usarDatosPrescriptor As Boolean = False

    Public Sub New(receta As RECETA, usarDatosPrescriptor As Boolean)
        Me.Receta = receta
        _usarDatosPrescriptor = usarDatosPrescriptor
    End Sub

    Public ReadOnly Property NOMBRE_MEDICO() As String
        Get
            Return Me.Receta.MEDICO.NOMBRECOMPLETO
        End Get
    End Property

    Public ReadOnly Property TRATAMIENTO() As String
        Get
            Return Me.Receta.TRATAMIENTO
        End Get
    End Property

    Public ReadOnly Property FECHA() As Nullable(Of Date)
        Get
            Return Me.Receta.FECHA
        End Get
    End Property

    Public ReadOnly Property COLEGIADO_MEDICO() As String
        Get
            Return Me.Receta.MEDICO.COLEGIADO
        End Get
    End Property

    Public ReadOnly Property DESCRIPCION() As String
        Get
            Return Me.Receta.DIAGNOSTICO.DIAGNOSTICO
        End Get
    End Property

    Public ReadOnly Property Prescriptor() As String
        Get
            If _usarDatosPrescriptor Then
                Return Me.Receta.Prescriptor
            Else
                Return String.Empty
            End If
        End Get
    End Property

    Public ReadOnly Property Prescripcion() As String
        Get
            Return Me.Receta.Prescripcion
        End Get
    End Property

    Public ReadOnly Property PacienteInfo() As String
        Get
            Return Me.Receta.PacienteInfo
        End Get
    End Property

   

    Public ReadOnly Property DuracionTratamiento() As String
        Get
            Return Me.Receta.DuracionTratamiento
        End Get
    End Property

    Public ReadOnly Property Posologia() As String
        Get
            Return Me.Receta.Posologia
        End Get
    End Property

    Public ReadOnly Property Unidades() As String
        Get
            Return Me.Receta.Unidades
        End Get

    End Property


    Public ReadOnly Property Pauta() As String
        Get
            Return Me.Receta.Pauta
        End Get

    End Property

    Public ReadOnly Property NoOrdenDispensacion() As String
        Get
            Return Me.Receta.NoOrdenDispensacion
        End Get

    End Property

    Public ReadOnly Property FechaPrevistaDispensacion() As Nullable(Of Date)
        Get
            Return Me.Receta.FechaPrevistaDispensacion
        End Get

    End Property

    Public ReadOnly Property InfoAlFarmaceutico() As String
        Get
            Return Me.Receta.InfoAlFarmaceutico
        End Get

    End Property

    Public ReadOnly Property DiagnosticoAlPaciente() As String
        Get
            Return Me.Receta.DiagnosticoAlPaciente
        End Get

    End Property

    Public ReadOnly Property NoEnvases_o_Unidades() As String
        Get
            Return Me.Receta.NoEnvases_o_Unidades
        End Get

    End Property

    Public ReadOnly Property InstruccionesAlPaciente() As String
        Get
            Return Me.Receta.InstruccionesAlPaciente
        End Get
    End Property



    Public ReadOnly Property PACIENTE_NOMBRECOMPLETO() As String
        Get
            Return Me.Receta.PACIENTE.NombreCompleto
        End Get
    End Property


    Public ReadOnly Property DNI As String
        Get
            Return Me.Receta.PACIENTE.DNI
        End Get
    End Property



    Public ReadOnly Property CIE10 As String
        Get
            If Me.Receta.DIAGNOSTICO Is Nothing Then
                Return "---,---"
            Else
                Return Me.Receta.DIAGNOSTICO.CIE10
            End If
        End Get
    End Property


    Public ReadOnly Property Diagnostico As String
        Get
            If Me.Receta.DIAGNOSTICO Is Nothing Then
                Return ""
            Else
                Return Me.Receta.DIAGNOSTICO.DIAGNOSTICO
            End If
        End Get
    End Property

    Public ReadOnly Property CodigoBarra As Byte()
        Get
            Dim rbyte As Byte()
            Try
                If Me.Receta.RecetasXML.Count > 0 Then
                    Dim ms As New System.IO.MemoryStream
                    Dim img As Image = Me.Receta.CodigoBarras
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    rbyte = ms.ToArray
                End If

                Return rbyte
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return Nothing
            End Try
        End Get
    End Property

   


End Class
