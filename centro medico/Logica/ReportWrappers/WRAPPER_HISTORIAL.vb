Public Class WRAPPER_HISTORIAL

    Private PACIENTE_ As PACIENTE
    Private MEDICO_ As MEDICO

    Private HISTORIAL_ As centro_medico.HISTORIALE

    Public Sub New(ByVal historial As centro_medico.HISTORIALE)
        MyBase.New()
        Me.HISTORIAL_ = historial
        Me.PACIENTE_ = historial.PACIENTE
        MEDICO_ = historial.MEDICO
    End Sub

    Public Property HISTORIAL_ANTECEDENTES() As String
        Get
            Return Me.HISTORIAL_.ANTECEDENTES
        End Get
        Set(value As String)
            Me.HISTORIAL_.ANTECEDENTES = value
        End Set
    End Property

    'Public ReadOnly Property HISTORIAL_ANTECEDENTES() As String
    '    Get
    '        Return Me.HISTORIAL_.ANTECEDENTES
    '    End Get
    'End Property

    Public ReadOnly Property HISTORIAL_CHISTORIAL() As Integer
        Get
            Return Me.HISTORIAL_.CHISTORIAL
        End Get
    End Property

    Public ReadOnly Property HISTORIAL_ParentHistorial() As Nullable(Of Integer)
        Get
            Return Me.HISTORIAL_.ParentHistorial
        End Get
    End Property

    Public ReadOnly Property HISTORIAL_COMENTARIOS() As String
        Get
            Return Me.HISTORIAL_.COMENTARIOS
        End Get
    End Property

    Public ReadOnly Property HISTORIAL_COMPLEMENTARIAS() As String
        Get
            Return Me.HISTORIAL_.COMPLEMENTARIAS
        End Get
       
    End Property

    Public ReadOnly Property HISTORIAL_EXPLORACION() As String
        Get
            Return Me.HISTORIAL_.EXPLORACION
        End Get
       
    End Property

    Public ReadOnly Property HISTORIAL_FECHA() As System.Nullable(Of Date)
        Get
            Return Me.HISTORIAL_.FECHA
        End Get
      
    End Property

    Public ReadOnly Property HISTORIAL_HORA() As System.Nullable(Of Date)
        Get
            Return Me.HISTORIAL_.HORA
        End Get
      
    End Property

    Public ReadOnly Property HISTORIAL_HISTORIAL() As String
        Get
            Return Me.HISTORIAL_.HISTORIAL
        End Get
      
    End Property



    Public ReadOnly Property HISTORIAL_DIAGNOSTICOS() As String
        Get
            Return Globales.TextFromRtf(Me.HISTORIAL_.HipotesisDiagnostica)
        End Get
    End Property

    Public ReadOnly Property HISTORIAL_JUICIO() As String
        Get
            Return Me.HISTORIAL_.JUICIO
        End Get
      
    End Property

    Public ReadOnly Property HISTORIAL_MEDICO() As centro_medico.MEDICO
        Get
            Return Me.HISTORIAL_.MEDICO
        End Get
      
    End Property

    Public ReadOnly Property HISTORIAL_MOTIVO() As String
        Get
            Return Me.HISTORIAL_.MOTIVO
        End Get
       
    End Property

    Public ReadOnly Property HISTORIAL_OTROS() As String
        Get
            Return Me.HISTORIAL_.OTROS
        End Get
        
    End Property

    Public ReadOnly Property HISTORIAL_PACIENTE() As centro_medico.PACIENTE
        Get
            Return Me.HISTORIAL_.PACIENTE
        End Get
       
    End Property

    Public ReadOnly Property HISTORIAL_REFDIAGNOSTICO() As System.Nullable(Of Integer)
        Get
            Return Me.HISTORIAL_.REFDIAGNOSTICO
        End Get
      
    End Property

    Public ReadOnly Property HISTORIAL_REFMEDICO() As Integer
        Get
            Return Me.HISTORIAL_.REFMEDICO
        End Get
     
    End Property

    Public ReadOnly Property HISTORIAL_REFPACIENTE() As Integer
        Get
            Return Me.HISTORIAL_.REFPACIENTE
        End Get
     
    End Property

    Public ReadOnly Property HISTORIAL_TRATAMIENTO() As String
        Get
            Return Me.HISTORIAL_.TRATAMIENTO
        End Get
       
    End Property


    'Medicos
    Public ReadOnly Property MEDICO_APELLIDO1() As String
        Get
            Return Me.MEDICO_.APELLIDO1
        End Get
    End Property

    Public ReadOnly Property MEDICO_APELLIDO2() As String
        Get
            Return Me.MEDICO_.APELLIDO2
        End Get
    End Property

    Public ReadOnly Property MEDICO_CMEDICO() As Integer
        Get
            Return Me.MEDICO_.CMEDICO
        End Get
    End Property

    Public ReadOnly Property MEDICO_COLEGIADO() As String
        Get
            Return Me.MEDICO_.COLEGIADO
        End Get
    End Property

    Public ReadOnly Property MEDICO_CP() As String
        Get
            Return Me.MEDICO_.CP
        End Get
    End Property

    Public ReadOnly Property MEDICO_DNI() As String
        Get
            Return Me.MEDICO_.DNI
        End Get
    End Property

    Public ReadOnly Property MEDICO_DOMICILIO() As String
        Get
            Return Me.MEDICO_.DOMICILIO
        End Get
    End Property

    Public ReadOnly Property MEDICO_ESPECIALIDAD() As String
        Get
            Return Me.MEDICO_.ESPECIALIDAD
        End Get
    End Property

    Public ReadOnly Property MEDICO_LOCALIDAD() As String
        Get
            Return Me.MEDICO_.LOCALIDAD
        End Get
    End Property

    Public ReadOnly Property MEDICO_MOVIL() As String
        Get
            Return Me.MEDICO_.MOVIL
        End Get
    End Property



    Public ReadOnly Property MEDICO_NOMBRE() As String
        Get
            Return Me.MEDICO_.NOMBRE
        End Get
    End Property


    Public ReadOnly Property MEDICO_NOMBRECOMPLETO() As String
        Get
            Return Me.MEDICO_.NOMBRECOMPLETO
        End Get
    End Property

    Public ReadOnly Property MEDICO_OBSERVACIONES() As String
        Get
            Return Me.MEDICO_.OBSERVACIONES
        End Get
    End Property

    Public ReadOnly Property MEDICO_PROVINCIA() As String
        Get
            Return Me.MEDICO_.PROVINCIA
        End Get
    End Property

    Public ReadOnly Property MEDICO_TLFNO() As String
        Get
            Return Me.MEDICO_.TLFNO
        End Get
    End Property

End Class


