
Public Class WRAPPER_LineasCita

    Private LineasCita_ As centro_medico.LineasCita

    Private CITA_ As centro_medico.CITA

    Public Sub New(ByVal LineasCita_ As centro_medico.LineasCita, ByVal CITA_ As centro_medico.CITA)
        MyBase.New()
        Me.LineasCita_ = LineasCita_
        Me.CITA_ = CITA_
    End Sub

    Public ReadOnly Property LineasCita_Cantidad() As Double
        Get
            Return Me.LineasCita_.Cantidad
        End Get
    End Property

    Public ReadOnly Property LineasCita_DESCRIPCION() As String
        Get
            Return Me.LineasCita_.DESCRIPCION
        End Get
    End Property

    Public ReadOnly Property LineasCita_DescuentoPercent() As System.Nullable(Of Double)
        Get
            Return Me.LineasCita_.DescuentoPercent
        End Get
    End Property

    Public ReadOnly Property LineasCita_Duracion() As System.Nullable(Of Date)
        Get
            Return Me.LineasCita_.Duracion
        End Get
    End Property

    Public ReadOnly Property LineasCita_IdCita() As Integer
        Get
            Return Me.LineasCita_.IdCita
        End Get
    End Property

    Public ReadOnly Property LineasCita_IdLinea() As Long
        Get
            Return Me.LineasCita_.IdLinea
        End Get
    End Property

    Public ReadOnly Property LineasCita_ImporteClinica() As Double
        Get
            Return Me.LineasCita_.ImporteClinica
        End Get
    End Property

    Public ReadOnly Property LineasCita_ImporteDr() As Double
        Get
            Return Me.LineasCita_.ImporteDr
        End Get
    End Property

    Public ReadOnly Property LineasCita_Liquidada_al_Medico() As System.Nullable(Of Boolean)
        Get
            Return Me.LineasCita_.Liquidada_al_Medico
        End Get
    End Property

    Public ReadOnly Property LineasCita_RefConcepto() As String
        Get
            Return Me.LineasCita_.RefConcepto
        End Get
    End Property

    Public ReadOnly Property LineasCita_RefLineaPresupuestoDental() As System.Nullable(Of Long)
        Get
            Return Me.LineasCita_.RefLineaPresupuestoDental
        End Get
    End Property

    Public ReadOnly Property LineasCita_Total() As System.Nullable(Of Double)
        Get
            Return Me.LineasCita_.Total
        End Get
    End Property

    Public ReadOnly Property LineasCita_CITA() As centro_medico.CITA
        Get
            Return Me.LineasCita_.CITA
        End Get
    End Property

    Public ReadOnly Property CITA_ATENDIDO() As String
        Get
            Return Me.CITA_.ATENDIDO
        End Get
    End Property

    Public ReadOnly Property CITA_BANCO() As String
        Get
            Return Me.CITA_.BANCO
        End Get
    End Property

    Public ReadOnly Property CITA_CONFIRMADA() As String
        Get
            Return Me.CITA_.CONFIRMADA
        End Get
    End Property

    Public ReadOnly Property CITA_CONTINUA() As String
        Get
            Return Me.CITA_.CONTINUA
        End Get
    End Property

    Public ReadOnly Property CITA_Descuento() As System.Nullable(Of Double)
        Get
            Return Me.CITA_.Descuento
        End Get
    End Property

    Public ReadOnly Property CITA_EstadoRecurrencia() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.EstadoRecurrencia
        End Get
    End Property

    Public ReadOnly Property CITA_FALTA() As String
        Get
            Return Me.CITA_.FALTA
        End Get
    End Property

    Public ReadOnly Property CITA_FECHA() As System.Nullable(Of Date)
        Get
            Return Me.CITA_.FECHA
        End Get
    End Property

    Public ReadOnly Property CITA_FECHACOBRO() As System.Nullable(Of Date)
        Get
            Return Me.CITA_.FECHACOBRO
        End Get
    End Property

    Public ReadOnly Property CITA_FechaUltimoEstadoRecurrencia() As System.Nullable(Of Date)
        Get
            Return Me.CITA_.FechaUltimoEstadoRecurrencia
        End Get
    End Property

    Public ReadOnly Property CITA_HORA() As System.Nullable(Of Date)
        Get
            Return Me.CITA_.HORA
        End Get
    End Property

    Public ReadOnly Property CITA_HORAFIN() As System.Nullable(Of Date)
        Get
            Return Me.CITA_.HORAFIN
        End Get
    End Property

    Public ReadOnly Property CITA_ID_Proceso() As System.Nullable(Of Long)
        Get
            Return Me.CITA_.ID_Proceso
        End Get
    End Property

    Public ReadOnly Property CITA_ID_SALA() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.ID_SALA
        End Get
    End Property

    Public ReadOnly Property CITA_IDCITA() As Integer
        Get
            Return Me.CITA_.IDCITA
        End Get
    End Property

    Public ReadOnly Property CITA_IMPORTECL() As System.Nullable(Of Decimal)
        Get
            Return Me.CITA_.IMPORTECL
        End Get
    End Property

    Public ReadOnly Property CITA_IMPORTEDR() As System.Nullable(Of Decimal)
        Get
            Return Me.CITA_.IMPORTEDR
        End Get
    End Property

    Public ReadOnly Property CITA_MEDICO() As centro_medico.MEDICO
        Get
            Return Me.CITA_.MEDICO
        End Get
    End Property

    Public ReadOnly Property CITA_MUTUA() As centro_medico.MUTUA
        Get
            Return Me.CITA_.MUTUA
        End Get
    End Property

    Public ReadOnly Property CITA_NOTAS() As String
        Get
            Return Me.CITA_.NOTAS
        End Get
    End Property

    Public ReadOnly Property CITA_PACIENTE() As String
        Get
            Return Me.CITA_.PACIENTE
        End Get
    End Property

    Public ReadOnly Property CITA_PAGADA() As String
        Get
            Return Me.CITA_.PAGADA
        End Get
    End Property

    Public ReadOnly Property CITA_REFFORMAPAGO() As String
        Get
            Return Me.CITA_.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property CITA_REFFRA() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.REFFRA
        End Get
    End Property

    Public ReadOnly Property CITA_REFMEDICO() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.REFMEDICO
        End Get
    End Property

    Public ReadOnly Property CITA_REFPACIENTE() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.REFPACIENTE
        End Get
    End Property

    Public ReadOnly Property CITA_REFPROCEDENCIA() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.REFPROCEDENCIA
        End Get
    End Property

    Public ReadOnly Property CITA_REFRECIBO() As System.Nullable(Of Integer)
        Get
            Return Me.CITA_.REFRECIBO
        End Get
    End Property

    Public ReadOnly Property CITA_TOTAL() As System.Nullable(Of Decimal)
        Get
            Return Me.CITA_.TOTAL
        End Get
    End Property
End Class