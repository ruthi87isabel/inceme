Public Class RC_ParcialHeader
    Public Property Paciente_Nombre As String
    Public Property Paciente_Apellido1 As String
    Public Property Paciente_Apellido2 As String
    Public Property Paciente_Sexo As String
    Public Property Paciente_FechaNacimiento As Date

    Public Property RevisionCodigo As String
    Public Property RevisionModelo As String
    Public Property Revision_FechaInicio As Date
    Public Property Revision_Descripcion As String

End Class


Public Class RC_Seguimiento
    Public Property Fecha As String
    Public Property Medico_NombreCompleto As String
    Public Property Descripcion_SEGUIMIENTO As String
    Public Property NotaSeguimiento As String

    Public Property NOMBREDATO As String
    Public Property TIPODATO As String
    Public Property OcultarImpresionCliente As Boolean
    Public Property OcultarEnReporte As Boolean

    Private _valor As Object

    Public Property VALOR As Object
        Get
            If Not _valor Is Nothing Then
                If TypeOf (_valor) Is System.Single Or TypeOf (_valor) Is System.Double Or TypeOf (_valor) Is System.Decimal Then
                    Return Double.Parse(_valor.ToString()).ToString("N3")
                End If
            End If
            Return _valor
        End Get
        Set(value As Object)
            _valor = value
        End Set
    End Property

    Public Property DiffAnterior As String
        
End Class