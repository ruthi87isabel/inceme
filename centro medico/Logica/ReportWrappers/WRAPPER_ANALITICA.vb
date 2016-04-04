Public Class WRAPPER_ANALITICA

    Private _ANALITICA As centro_medico.CONCEPTOSANALITICA

    Public Sub New(ByVal _ANALITICA As centro_medico.CONCEPTOSANALITICA)
        Me._ANALITICA = _ANALITICA
    End Sub

    Public ReadOnly Property CODIGO() As Integer
        Get
            Return Me._ANALITICA.CODIGO
        End Get
    End Property

    Public ReadOnly Property CONCEPTO() As String
        Get
            Return Me._ANALITICA.CONCEPTO
        End Get
    End Property

    Public ReadOnly Property IMPORTE() As Single

        Get
            Return Me._ANALITICA.IMPORTE
        End Get
    End Property

    Public ReadOnly Property NOTAS() As String
        Get
            Return Me._ANALITICA.NOTAS
        End Get
    End Property

    Public ReadOnly Property COLOR() As String
        Get
            Return Me._ANALITICA.COLOR
        End Get
    End Property

End Class
