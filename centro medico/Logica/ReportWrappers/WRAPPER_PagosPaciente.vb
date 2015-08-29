Public Class WRAPPER_PagosPaciente
    Private _PagosPaciente As centro_medico.PagosPaciente

    Private _FORMASPAGO As centro_medico.FORMASPAGO

    Public Sub New(ByVal _PagosPaciente As centro_medico.PagosPaciente)
        MyBase.New()
        Me._PagosPaciente = _PagosPaciente
        Me._FORMASPAGO = _PagosPaciente.FORMASPAGO
    End Sub

    Public ReadOnly Property Fecha() As System.Nullable(Of Date)
        Get
            Return Me._PagosPaciente.Fecha
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO() As centro_medico.FORMASPAGO
        Get
            Return Me._PagosPaciente.FORMASPAGO
        End Get
    End Property

    Public ReadOnly Property IDEntrega() As Long
        Get
            Return Me._PagosPaciente.IDEntrega
        End Get
    End Property

    Public ReadOnly Property IDFormaPago() As String
        Get
            Return Me._PagosPaciente.IDFormaPago
        End Get
    End Property

    Public ReadOnly Property IDPaciente() As System.Nullable(Of Integer)
        Get
            Return Me._PagosPaciente.IDPaciente
        End Get
    End Property

    Public ReadOnly Property IDUsuario() As System.Nullable(Of Integer)
        Get
            Return Me._PagosPaciente.IDUsuario
        End Get
    End Property

    Public ReadOnly Property Importe() As System.Nullable(Of Double)
        Get
            Return Me._PagosPaciente.Importe
        End Get
    End Property

    Public ReadOnly Property Notas() As String
        Get
            Return Me._PagosPaciente.Notas
        End Get
    End Property

    Public ReadOnly Property USUARIO() As centro_medico.USUARIO
        Get
            Return Me._PagosPaciente.USUARIO
        End Get
    End Property

    Public ReadOnly Property PACIENTE() As centro_medico.PACIENTE
        Get
            Return Me._PagosPaciente.PACIENTE
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_CODIGO() As String
        Get
            Return Me._FORMASPAGO.CODIGO
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_DESCRIPCION() As String
        Get
            Return Me._FORMASPAGO.DESCRIPCION
        End Get
    End Property

End Class
