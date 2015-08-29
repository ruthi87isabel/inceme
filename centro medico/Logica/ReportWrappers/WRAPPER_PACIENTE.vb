Public Class WRAPPER_PACIENTE

    Private _PACIENTE As centro_medico.PACIENTE
    Private _IMPORTE As Double = 0

    Public Sub New(ByVal _PACIENTE As centro_medico.PACIENTE)
        Me._PACIENTE = _PACIENTE
    End Sub

    Public ReadOnly Property ACTIVO() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.ACTIVO
        End Get
    End Property

    Public ReadOnly Property APELLIDO1() As String
        Get
            Return Me._PACIENTE.APELLIDO1
        End Get
    End Property

    Public ReadOnly Property APELLIDO2() As String
        Get
            Return Me._PACIENTE.APELLIDO2
        End Get
    End Property

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Me._PACIENTE.NombreCompleto
        End Get
    End Property



    'Public ReadOnly Property Asociados() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
    '    Get
    '        Return Me._PACIENTE.Asociados
    '    End Get
    'End Property

    'Public ReadOnly Property Asociados1() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
    '    Get
    '        Return Me._PACIENTE.Asociados1
    '    End Get
    'End Property

    Public ReadOnly Property BENEFICIARIOCODIGOSOCIO() As Integer
        Get
            Return Me._PACIENTE.BENEFICIARIOCODIGOSOCIO
        End Get
    End Property

    Public ReadOnly Property BENEFICIARIOPARENTESCO() As String
        Get
            Return Me._PACIENTE.BENEFICIARIOPARENTESCO
        End Get
    End Property

    'Public ReadOnly Property CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
    '    Get
    '        Return Me._PACIENTE.CITAs
    '    End Get
    'End Property

    Public ReadOnly Property CODIGOPROPIO() As String
        Get
            Return Me._PACIENTE.CODIGOPROPIO
        End Get
    End Property

    Public ReadOnly Property CONOCIO() As String
        Get
            Return Me._PACIENTE.CONOCIO
        End Get
    End Property

    'Public ReadOnly Property ContactosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.ContactosPaciente)
    '    Get
    '        Return Me._PACIENTE.ContactosPacientes
    '    End Get
    'End Property

    Public ReadOnly Property CP() As String
        Get
            Return Me._PACIENTE.CP
        End Get
    End Property

    Public ReadOnly Property CPACIENTE() As Integer
        Get
            Return Me._PACIENTE.CPACIENTE
        End Get
    End Property

    Public ReadOnly Property CUENTA() As String
        Get
            Return Me._PACIENTE.CUENTA
        End Get
    End Property

    'Public ReadOnly Property d_Odontogramas() As System.Data.Linq.EntitySet(Of centro_medico.d_Odontograma)
    '    Get
    '        Return Me._PACIENTE.d_Odontogramas
    '    End Get
    'End Property

    Public ReadOnly Property DC() As String
        Get
            Return Me._PACIENTE.DC
        End Get
    End Property

    Public ReadOnly Property DEFUNCION() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.DEFUNCION
        End Get
    End Property

    Public ReadOnly Property DNI() As String
        Get
            Return Me._PACIENTE.DNI
        End Get
    End Property

    Public ReadOnly Property DNI_Letra() As String
        Get
            Return Globales.GetLetter(_PACIENTE.DNI)
        End Get
    End Property

    Public ReadOnly Property DOMICILIO() As String
        Get
            Return Me._PACIENTE.DOMICILIO
        End Get
    End Property

    Public ReadOnly Property EMAIL() As String
        Get
            Return Me._PACIENTE.EMAIL
        End Get
    End Property

    'Public ReadOnly Property EMPRESA() As centro_medico.EMPRESA
    '    Get
    '        Return Me._PACIENTE.EMPRESA
    '    End Get
    'End Property

    Public ReadOnly Property ENTIDAD() As String
        Get
            Return Me._PACIENTE.ENTIDAD
        End Get
    End Property

    'Public ReadOnly Property EntregasCuentas() As System.Data.Linq.EntitySet(Of centro_medico.EntregasCuenta)
    '    Get
    '        Return Me._PACIENTE.EntregasCuentas
    '    End Get
    'End Property

    'Public ReadOnly Property FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me._PACIENTE.FACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property FECHAALTA() As System.Nullable(Of Date)
        Get
            Return Me._PACIENTE.FECHAALTA
        End Get
    End Property

    Public ReadOnly Property FECHABAJA() As System.Nullable(Of Date)
        Get
            Return Me._PACIENTE.FECHABAJA
        End Get
    End Property

    Public ReadOnly Property FECHAN() As System.Nullable(Of Date)
        Get
            Return Me._PACIENTE.FECHAN
        End Get
    End Property

    'Public ReadOnly Property FICHEROs() As System.Data.Linq.EntitySet(Of centro_medico.FICHERO)
    '    Get
    '        Return Me._PACIENTE.FICHEROs
    '    End Get
    'End Property

    Public ReadOnly Property FOTO() As Byte()
        Get
            Return Me._PACIENTE.FOTO.ToArray()
        End Get
    End Property

    Public ReadOnly Property FOTOGRAFIA() As String
        Get
            Return Me._PACIENTE.FOTOGRAFIA
        End Get
    End Property

    'Public ReadOnly Property HISTORIALEs() As System.Data.Linq.EntitySet(Of centro_medico.HISTORIALE)
    '    Get
    '        Return Me._PACIENTE.HISTORIALEs
    '    End Get
    'End Property

    'Public ReadOnly Property LEMPRESAs() As System.Data.Linq.EntitySet(Of centro_medico.LEMPRESA)
    '    Get
    '        Return Me._PACIENTE.LEMPRESAs
    '    End Get
    'End Property

    Public ReadOnly Property LOCALIDAD() As String
        Get
            Return Me._PACIENTE.LOCALIDAD
        End Get
    End Property

    Public ReadOnly Property MOVIL() As String
        Get
            Return Me._PACIENTE.MOVIL
        End Get
    End Property

    'Public ReadOnly Property MUTUA() As centro_medico.MUTUA
    '    Get
    '        Return Me._PACIENTE.MUTUA
    '    End Get
    'End Property

    'Public ReadOnly Property N_Tickets() As System.Data.Linq.EntitySet(Of centro_medico.N_Ticket)
    '    Get
    '        Return Me._PACIENTE.N_Tickets
    '    End Get
    'End Property

    Public ReadOnly Property NIE() As String
        Get
            Return Me._PACIENTE.NIE
        End Get
    End Property

    Public ReadOnly Property NOMBRE() As String
        Get
            Return Me._PACIENTE.NOMBRE
        End Get
    End Property

    Public ReadOnly Property NSS() As String
        Get
            Return Me._PACIENTE.NSS
        End Get
    End Property

    Public ReadOnly Property OBSERVACIONES() As String
        Get
            Return Me._PACIENTE.OBSERVACIONES
        End Get
    End Property

    Public ReadOnly Property OFICINA() As String
        Get
            Return Me._PACIENTE.OFICINA
        End Get
    End Property

    Public ReadOnly Property PAGOBANCO() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.PAGOBANCO
        End Get
    End Property

    'Public ReadOnly Property PagosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.PagosPaciente)
    '    Get
    '        Return Me._PACIENTE.PagosPacientes
    '    End Get
    'End Property

    Public ReadOnly Property PASAPORTE() As String
        Get
            Return Me._PACIENTE.PASAPORTE
        End Get
    End Property

    Public ReadOnly Property PROFESION() As String
        Get
            Return Me._PACIENTE.PROFESION
        End Get
    End Property

    Public ReadOnly Property PROVINCIA() As String
        Get
            Return Me._PACIENTE.PROVINCIA
        End Get
    End Property

    Public ReadOnly Property PUESTO() As String
        Get
            Return Me._PACIENTE.PUESTO
        End Get
    End Property

    'Public ReadOnly Property RECIBOs() As System.Data.Linq.EntitySet(Of centro_medico.RECIBO)
    '    Get
    '        Return Me._PACIENTE.RECIBOs
    '    End Get
    'End Property

    Public ReadOnly Property REFEMPRESA() As System.Nullable(Of Integer)
        Get
            Return Me._PACIENTE.REFEMPRESA
        End Get
    End Property

    Public ReadOnly Property REFFORMAPAGO() As String
        Get
            Return Me._PACIENTE.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property REFMUTUA() As System.Nullable(Of Integer)
        Get
            Return Me._PACIENTE.REFMUTUA
        End Get
    End Property

    Public ReadOnly Property REFPAIS() As Integer
        Get
            Return Me._PACIENTE.REFPAIS
        End Get
    End Property

    Public ReadOnly Property REGIMEN() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.REGIMEN
        End Get
    End Property

    Public ReadOnly Property SEXO() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.SEXO
        End Get
    End Property

    Public ReadOnly Property SOCIO() As System.Nullable(Of Char)
        Get
            Return Me._PACIENTE.SOCIO
        End Get
    End Property

    Public ReadOnly Property TARJETASANITARIA() As String
        Get
            Return Me._PACIENTE.TARJETASANITARIA
        End Get
    End Property

    Public ReadOnly Property TITULAR() As String
        Get
            Return Me._PACIENTE.TITULAR
        End Get
    End Property

    Public ReadOnly Property TLFNO() As String
        Get
            Return Me._PACIENTE.TLFNO
        End Get
    End Property

    Public ReadOnly Property TUTOR() As String
        Get
            Return Me._PACIENTE.TUTOR
        End Get
    End Property

    Public ReadOnly Property WEB() As String
        Get
            Return Me._PACIENTE.WEB
        End Get
    End Property


    'Formas de PAgo
    'Public ReadOnly Property FORMASPAGO() As centro_medico.FORMASPAGO
    '    Get
    '        Return Me._PACIENTE.FORMASPAGO
    '    End Get
    'End Property

    Public ReadOnly Property FORMASPAGO_CODIGO As String
        Get
            Try
                Return Me._PACIENTE.FORMASPAGO.CODIGO
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_DESCRIPCION As String
        Get
            Try
                Return Me._PACIENTE.FORMASPAGO.DESCRIPCION
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    'Empresa
    Public ReadOnly Property EMPRESA_ACTIVIDAD() As String
        Get
            Return Me._PACIENTE.EMPRESA.ACTIVIDAD
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CEMPRESA() As Integer
        Get
            Return Me._PACIENTE.EMPRESA.CEMPRESA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CIF() As String
        Get
            Return Me._PACIENTE.EMPRESA.CIF
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CNAE() As String
        Get
            Return Me._PACIENTE.EMPRESA.CNAE
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CP() As String
        Get
            Return Me._PACIENTE.EMPRESA.CP
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CUENTA() As String
        Get
            Return Me._PACIENTE.EMPRESA.CUENTA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_DC() As String
        Get
            Return Me._PACIENTE.EMPRESA.DC
        End Get
    End Property

    Public ReadOnly Property EMPRESA_DIRECCION() As String
        Get
            Return Me._PACIENTE.EMPRESA.DIRECCION
        End Get
    End Property

    Public ReadOnly Property EMPRESA_ENTIDAD() As String
        Get
            Return Me._PACIENTE.EMPRESA.ENTIDAD
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me._PACIENTE.EMPRESA.FACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_FAX() As String
        Get
            Return Me._PACIENTE.EMPRESA.FAX
        End Get
    End Property

    Public ReadOnly Property EMPRESA_FECHA() As System.Nullable(Of Date)
        Get
            Return Me._PACIENTE.EMPRESA.FECHA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_LEMPRESAs() As System.Data.Linq.EntitySet(Of centro_medico.LEMPRESA)
    '    Get
    '        Return Me._PACIENTE.EMPRESA.LEMPRESAs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_MAIL() As String
        Get
            Return Me._PACIENTE.EMPRESA.MAIL
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NOMBRE() As String
        Get
            Return Me._PACIENTE.EMPRESA.NOMBRE
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NOTAS() As String
        Get
            Return Me._PACIENTE.EMPRESA.NOTAS
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NSS() As String
        Get
            Return Me._PACIENTE.EMPRESA.NSS
        End Get
    End Property

    Public ReadOnly Property EMPRESA_OFICINA() As String
        Get
            Return Me._PACIENTE.EMPRESA.OFICINA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_PACIENTEs() As System.Data.Linq.EntitySet(Of centro_medico.PACIENTE)
    '    Get
    '        Return Me._PACIENTE.EMPRESA.PACIENTEs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_PERSONACON() As String
        Get
            Return Me._PACIENTE.EMPRESA.PERSONACON
        End Get
    End Property

    Public ReadOnly Property EMPRESA_POBLACION() As String
        Get
            Return Me._PACIENTE.EMPRESA.POBLACION
        End Get
    End Property

    Public ReadOnly Property EMPRESA_PROVINCIA() As String
        Get
            Return Me._PACIENTE.EMPRESA.PROVINCIA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_RECIBOs() As System.Data.Linq.EntitySet(Of centro_medico.RECIBO)
    '    Get
    '        Return Me._PACIENTE.EMPRESA.RECIBOs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_REFMUTUA() As System.Nullable(Of Integer)
        Get
            Return Me._PACIENTE.EMPRESA.REFMUTUA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TITULAR() As String
        Get
            Return Me._PACIENTE.EMPRESA.TITULAR
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TLFNO1() As String
        Get
            Return Me._PACIENTE.EMPRESA.TLFNO1
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TLFNO2() As String
        Get
            Return Me._PACIENTE.EMPRESA.TLFNO2
        End Get
    End Property

    Public ReadOnly Property EMPRESA_WEB() As String
        Get
            Return Me._PACIENTE.EMPRESA.WEB
        End Get
    End Property


    'MUTUA
    Public ReadOnly Property MUTUA_CIF() As String
        Get
            Return Me._PACIENTE.MUTUA.CIF
        End Get
    End Property

    'Public ReadOnly Property MUTUA_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
    '    Get
    '        Return Me._PACIENTE.MUTUA.CITAs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_CMUTUA() As Integer
        Get
            Return Me._PACIENTE.MUTUA.CMUTUA
        End Get
    End Property

    Public ReadOnly Property MUTUA_CP() As String
        Get
            Return Me._PACIENTE.MUTUA.CP
        End Get
    End Property

    Public ReadOnly Property MUTUA_DIRECCION() As String
        Get
            Return Me._PACIENTE.MUTUA.DIRECCION
        End Get
    End Property

    Public ReadOnly Property MUTUA_ESPECIALIDAD() As String
        Get
            Return Me._PACIENTE.MUTUA.ESPECIALIDAD
        End Get
    End Property

    'Public ReadOnly Property MUTUA_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me._PACIENTE.MUTUA.FACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_FAX() As String
        Get
            Return Me._PACIENTE.MUTUA.FAX
        End Get
    End Property

    Public ReadOnly Property MUTUA_IdTarifa() As System.Nullable(Of Integer)
        Get
            Return Me._PACIENTE.MUTUA.IdTarifa
        End Get
    End Property

    Public ReadOnly Property MUTUA_MAIL() As String
        Get
            Return Me._PACIENTE.MUTUA.MAIL
        End Get
    End Property

    Public ReadOnly Property MUTUA_NOMBRE() As String
        Get
            Return Me._PACIENTE.MUTUA.NOMBRE
        End Get
    End Property

    Public ReadOnly Property MUTUA_NOTAS() As String
        Get
            Return Me._PACIENTE.MUTUA.NOTAS
        End Get
    End Property

    'Public ReadOnly Property MUTUA_PACIENTEs() As System.Data.Linq.EntitySet(Of centro_medico.PACIENTE)
    '    Get
    '        Return Me._PACIENTE.MUTUA.PACIENTEs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_PARTELSR() As String
        Get
            Return Me._PACIENTE.MUTUA.PARTELSR
        End Get
    End Property

    Public ReadOnly Property MUTUA_PARTEMTR() As String
        Get
            Return Me._PACIENTE.MUTUA.PARTEMTR
        End Get
    End Property

    Public ReadOnly Property MUTUA_POBLACION() As String
        Get
            Return Me._PACIENTE.MUTUA.POBLACION
        End Get
    End Property

    Public ReadOnly Property MUTUA_PROVINCIA() As String
        Get
            Return Me._PACIENTE.MUTUA.PROVINCIA
        End Get
    End Property

    Public ReadOnly Property MUTUA_TLFNO1() As String
        Get
            Return Me._PACIENTE.MUTUA.TLFNO1
        End Get
    End Property

    Public ReadOnly Property MUTUA_TLFNO2() As String
        Get
            Return Me._PACIENTE.MUTUA.TLFNO2
        End Get
    End Property

    Public ReadOnly Property MUTUA_WEB() As String
        Get
            Return Me._PACIENTE.MUTUA.WEB
        End Get
    End Property

    Public ReadOnly Property MUTUA_PERSONACON() As String
        Get
            Return Me._PACIENTE.MUTUA.PERSONACON
        End Get
    End Property

    Public Property IMPORTE As Double
        Get
            Return _IMPORTE
        End Get
        Set(ByVal value As Double)
            _IMPORTE = value
        End Set
    End Property

End Class
