Public Class WRAPPER_InformeMedico

    Private informe As INFORME_MEDICO
    Private _domicilio, _dni As String

    Sub New(informe As INFORME_MEDICO)
        Me.informe = informe
    End Sub

    Sub New(informe As INFORME_MEDICO, domicilio As String, dni As String)
        Me.informe = informe
        _domicilio = domicilio
        _dni = dni
    End Sub

    Public ReadOnly Property NOMBRE_MEDICO() As String
        Get
            Return informe.MEDICO.NOMBRECOMPLETO
        End Get
    End Property

    Public ReadOnly Property DOMICILIO_MEDICO() As String
        Get
            'Return informe.MEDICO.DOMICILIO
            Return _domicilio
        End Get
    End Property

    Public ReadOnly Property CODIGO_MEDICO() As String
        Get
            Return informe.MEDICO.CMEDICO.ToString()
        End Get
    End Property

    Public ReadOnly Property ESPECIALIDAD_MEDICO() As String
        Get
            Return informe.MEDICO.ESPECIALIDAD
        End Get
    End Property


    Public ReadOnly Property FECHA() As Date
        Get
            Return informe.Fecha
        End Get
    End Property

    Public ReadOnly Property DESCRIPCION() As String
        Get
            Return informe.Descripcion
        End Get
    End Property

    Public ReadOnly Property PACIENTE_NOMBRE() As String
        Get
            Return informe.PACIENTE.NombreCompleto
        End Get
    End Property

    Public ReadOnly Property PACIENTE_DNI() As String
        Get
            'Return informe.PACIENTE.DNI
            Return _dni
        End Get
    End Property
End Class

