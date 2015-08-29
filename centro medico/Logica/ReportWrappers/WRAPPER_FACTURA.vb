Public Class WRAPPER_FACTURA

    Public _FACTURA As centro_medico.FACTURA
    Private MUTUA_ As MUTUA = New MUTUA()
    Public PACIENTE_ As PACIENTE
    Private EMPRESA_ As New EMPRESA()


    Public Sub New(ByVal _FACTURA As centro_medico.FACTURA)
        Me._FACTURA = _FACTURA
        'If _FACTURA Is Nothing Then
        '    Dim a = 2
        'End If
        If Not _FACTURA.MUTUA1 Is Nothing Then
            Me.MUTUA_ = _FACTURA.MUTUA1
        End If
        Me.PACIENTE_ = _FACTURA.PACIENTE1

        If Not _FACTURA.EMPRESA1 Is Nothing Then
            Me.EMPRESA_ = _FACTURA.EMPRESA1
        End If

    End Sub

    Public ReadOnly Property CP() As String
        Get
            Return Me._FACTURA.CP
        End Get
    End Property

    Public ReadOnly Property FECHAENVIO() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FECHAENVIO
        End Get
    End Property

    Public ReadOnly Property Descuento() As System.Nullable(Of Double)
        Get
            Return Me._FACTURA.Descuento
        End Get
    End Property

    Public ReadOnly Property DIAGNOSTICO() As String
        Get
            Return Me._FACTURA.DIAGNOSTICO
        End Get
    End Property

    Public ReadOnly Property DIRECCION() As String
        Get
            Return Me._FACTURA.DIRECCION
        End Get
    End Property

    Public ReadOnly Property DNI() As String
        Get
            If Not _FACTURA.DNI Is Nothing Then
                Return _FACTURA.DNI & Globales.GetLetter(_FACTURA.DNI)
            Else
                Return _FACTURA.DNI
            End If

        End Get
    End Property

    Public ReadOnly Property EMPRESA() As String
        Get
            Return Me._FACTURA.EMPRESA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA1() As centro_medico.EMPRESA
    '    Get
    '        Return Me._FACTURA.EMPRESA1
    '    End Get
    'End Property

    Public ReadOnly Property FACCIDENTE() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FACCIDENTE
        End Get
    End Property

    Public ReadOnly Property FACTURAR() As String
        Get
            Return Me._FACTURA.FACTURAR
        End Get
    End Property

    Public ReadOnly Property FALTA() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FALTA
        End Get
    End Property

    Public ReadOnly Property FBAJA() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FBAJA
        End Get
    End Property

    Public ReadOnly Property FECHA() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FECHA
        End Get
    End Property

    Public ReadOnly Property FECHACOBRO() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FECHACOBRO
        End Get
    End Property

    Public ReadOnly Property FEMISION() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.FEMISION
        End Get
    End Property

    'Public ReadOnly Property FORMASPAGO() As centro_medico.FORMASPAGO
    '    Get
    '        Return Me._FACTURA.FORMASPAGO
    '    End Get
    'End Property

    Public ReadOnly Property FORMASPAGO_DESCRIPCION() As String
        Get
            Return Me._FACTURA.FORMASPAGO.DESCRIPCION
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_CODIGO() As String
        Get
            Return Me._FACTURA.FORMASPAGO.CODIGO
        End Get
    End Property


    Public ReadOnly Property HISTORIAL() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.HISTORIAL
        End Get
    End Property

    Public ReadOnly Property HORA() As System.Nullable(Of Date)
        Get
            Return Me._FACTURA.HORA
        End Get
    End Property

    Public ReadOnly Property ID_Proceso() As System.Nullable(Of Long)
        Get
            Return Me._FACTURA.ID_Proceso
        End Get
    End Property

    Public ReadOnly Property IDFACTURA() As Integer
        Get
            Return Me._FACTURA.IDFACTURA
        End Get
    End Property

    Public ReadOnly Property IRPF() As System.Nullable(Of Decimal)
        Get
            Return Me._FACTURA.IRPF
        End Get
    End Property

    'Public ReadOnly Property LINEASFACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.LINEASFACTURA)
    '    Get
    '        Return Me._FACTURA.LINEASFACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property LOCALIDAD() As String
        Get
            Return Me._FACTURA.LOCALIDAD
        End Get
    End Property

    Public ReadOnly Property MUTUA() As String
        Get
            Return Me._FACTURA.MUTUA
        End Get
    End Property

    'Public ReadOnly Property MUTUA1() As centro_medico.MUTUA
    '    Get
    '        Return Me._FACTURA.MUTUA1
    '    End Get
    'End Property

    Public ReadOnly Property N19() As String
        Get
            Return Me._FACTURA.N19
        End Get
    End Property

    Public ReadOnly Property NUMERO() As String
        Get
            Return Me._FACTURA.NUMERO
        End Get
    End Property

    Public ReadOnly Property NUMEROFACTURA() As Integer
        Get
            Return Me._FACTURA.NUMEROFACTURA
        End Get
    End Property

    Public ReadOnly Property PACIENTE() As String
        Get
            Return Me._FACTURA.PACIENTE
        End Get
    End Property

    'Public ReadOnly Property PACIENTE1() As centro_medico.PACIENTE
    '    Get
    '        Return Me._FACTURA.PACIENTE1
    '    End Get
    'End Property

    Public ReadOnly Property PAGADA() As String
        Get
            Return Me._FACTURA.PAGADA
        End Get
    End Property

    Public ReadOnly Property PORCENTAJEIRPF() As Single
        Get
            Return Me._FACTURA.PORCENTAJEIRPF
        End Get
    End Property

    Public ReadOnly Property PROVINCIA() As String
        Get
            Return Me._FACTURA.PROVINCIA
        End Get
    End Property

    Public ReadOnly Property RECIBO() As String
        Get
            Return Me._FACTURA.RECIBO
        End Get
    End Property

    Public ReadOnly Property REFCITA() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.REFCITA
        End Get
    End Property

    Public ReadOnly Property REFEMPRESA() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.REFEMPRESA
        End Get
    End Property

    Public ReadOnly Property REFFORMAPAGO() As String
        Get
            Return Me._FACTURA.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property REFMUTUA() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.REFMUTUA
        End Get
    End Property

    Public ReadOnly Property REFRECIBO() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.REFRECIBO
        End Get
    End Property

    Public ReadOnly Property REFSERIE() As String
        Get
            Return Me._FACTURA.REFSERIE
        End Get
    End Property

    'Public ReadOnly Property SERIES() As centro_medico.SERIES
    '    Get
    '        Return Me._FACTURA.SERIES
    '    End Get
    'End Property

    Public ReadOnly Property TIPOIVA() As System.Nullable(Of Single)
        Get
            Return Me._FACTURA.TIPOIVA
        End Get
    End Property

    Public ReadOnly Property TOTAL() As System.Nullable(Of Decimal)
        Get
            Return Me._FACTURA.TOTAL
        End Get
    End Property

    Public ReadOnly Property REFPACIENTE() As System.Nullable(Of Integer)
        Get
            Return Me._FACTURA.REFPACIENTE
        End Get
    End Property

    Public ReadOnly Property MUTUA_CIF() As String
        Get
            Return Me.MUTUA_.CIF
        End Get
    End Property

    'Public ReadOnly Property MUTUA_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
    '    Get
    '        Return Me.MUTUA_.CITAs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_CMUTUA() As Integer
        Get
            Return Me.MUTUA_.CMUTUA
        End Get
    End Property

    Public ReadOnly Property MUTUA_CP() As String
        Get
            Return Me.MUTUA_.CP
        End Get
    End Property

    Public ReadOnly Property MUTUA_DIRECCION() As String
        Get
            Return Me.MUTUA_.DIRECCION
        End Get
    End Property

    Public ReadOnly Property MUTUA_ESPECIALIDAD() As String
        Get
            Return Me.MUTUA_.ESPECIALIDAD
        End Get
    End Property

    'Public ReadOnly Property MUTUA_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me.MUTUA_.FACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_FAX() As String
        Get
            Return Me.MUTUA_.FAX
        End Get
    End Property

    Public ReadOnly Property MUTUA_IdTarifa() As System.Nullable(Of Integer)
        Get
            Return Me.MUTUA_.IdTarifa
        End Get
    End Property

    Public ReadOnly Property MUTUA_MAIL() As String
        Get
            Return Me.MUTUA_.MAIL
        End Get
    End Property

    Public ReadOnly Property MUTUA_NOMBRE() As String
        Get
            'If MUTUA Is Nothing Then
            '    Return String.Empty
            'End If
            Return Me.MUTUA_.NOMBRE
        End Get
    End Property

    Public ReadOnly Property MUTUA_NoContrato() As String
        Get
            Return Me.MUTUA_.NoContrato
        End Get
    End Property

    Public ReadOnly Property MUTUA_NOTAS() As String
        Get
            Return Me.MUTUA_.NOTAS
        End Get
    End Property

    'Public ReadOnly Property MUTUA_PACIENTEs() As System.Data.Linq.EntitySet(Of centro_medico.PACIENTE)
    '    Get
    '        Return Me.MUTUA_.PACIENTEs
    '    End Get
    'End Property

    Public ReadOnly Property MUTUA_PARTELSR() As String
        Get
            Return Me.MUTUA_.PARTELSR
        End Get
    End Property

    Public ReadOnly Property MUTUA_PERSONACON() As String
        Get
            Return Me.MUTUA_.PERSONACON
        End Get
    End Property

    Public ReadOnly Property MUTUA_POBLACION() As String
        Get
            Return Me.MUTUA_.POBLACION
        End Get
    End Property

    Public ReadOnly Property MUTUA_PROVINCIA() As String
        Get
            Return Me.MUTUA_.PROVINCIA
        End Get
    End Property

    Public ReadOnly Property MUTUA_TLFNO1() As String
        Get
            Return Me.MUTUA_.TLFNO1
        End Get
    End Property

    Public ReadOnly Property MUTUA_TLFNO2() As String
        Get
            Return Me.MUTUA_.TLFNO2
        End Get
    End Property

    Public ReadOnly Property MUTUA_WEB() As String
        Get
            Return Me.MUTUA_.WEB
        End Get
    End Property

    Public ReadOnly Property MUTUA_PARTEMTR() As String
        Get
            Return Me.MUTUA_.PARTEMTR
        End Get
    End Property


    'PACIENTE ======================================================
    Public ReadOnly Property PACIENTE_ACTIVO() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.ACTIVO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_APELLIDO1() As String
        Get
            Return Me.PACIENTE_.APELLIDO1
        End Get
    End Property

    Public ReadOnly Property PACIENTE_APELLIDO2() As String
        Get
            Return Me.PACIENTE_.APELLIDO2
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_Asociados() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
    '    Get
    '        Return Me.PACIENTE_.Asociados
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_Asociados1() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
    '    Get
    '        Return Me.PACIENTE_.Asociados1
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_BENEFICIARIOCODIGOSOCIO() As Integer
        Get
            Return Me.PACIENTE_.BENEFICIARIOCODIGOSOCIO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_BENEFICIARIOPARENTESCO() As String
        Get
            Return Me.PACIENTE_.BENEFICIARIOPARENTESCO
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
    '    Get
    '        Return Me.PACIENTE_.CITAs
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_CODIGOPROPIO() As String
        Get
            Return Me.PACIENTE_.CODIGOPROPIO
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_ContactosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.ContactosPaciente)
    '    Get
    '        Return Me.PACIENTE_.ContactosPacientes
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_CP() As String
        Get
            Return Me.PACIENTE_.CP
        End Get
    End Property

    Public ReadOnly Property PACIENTE_CPACIENTE() As Integer
        Get
            Return Me.PACIENTE_.CPACIENTE
        End Get
    End Property

    Public ReadOnly Property PACIENTE_CUENTA() As String
        Get
            Return Me.PACIENTE_.CUENTA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_CONOCIO() As String
        Get
            Return Me.PACIENTE_.CONOCIO
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_d_Odontogramas() As System.Data.Linq.EntitySet(Of centro_medico.d_Odontograma)
    '    Get
    '        Return Me.PACIENTE_.d_Odontogramas
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_DC() As String
        Get
            Return Me.PACIENTE_.DC
        End Get
    End Property

    Public ReadOnly Property PACIENTE_DEFUNCION() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.DEFUNCION
        End Get
    End Property

    Public ReadOnly Property PACIENTE_DNI() As String
        Get
            Return Me.PACIENTE_.DNI
        End Get
    End Property

    Public ReadOnly Property PACIENTE_DNI_LETRA() As String
        Get
            If Not Me.PACIENTE_.DNI Is Nothing Then
                Return Globales.GetLetter(PACIENTE_.DNI)
            End If
        End Get
    End Property

    Public ReadOnly Property PACIENTE_DOMICILIO() As String
        Get
            Return Me.PACIENTE_.DOMICILIO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_EMAIL() As String
        Get
            Return Me.PACIENTE_.EMAIL
        End Get
    End Property

    Public ReadOnly Property PACIENTE_ENTIDAD() As String
        Get
            Return Me.PACIENTE_.ENTIDAD
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_EntregasCuentas() As System.Data.Linq.EntitySet(Of centro_medico.EntregasCuenta)
    '    Get
    '        Return Me.PACIENTE_.EntregasCuentas
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me.PACIENTE_.FACTURAs
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_EMPRESA() As centro_medico.EMPRESA
    '    Get
    '        Return Me.PACIENTE_.EMPRESA
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_FECHAALTA() As System.Nullable(Of Date)
        Get
            Return Me.PACIENTE_.FECHAALTA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_FECHABAJA() As System.Nullable(Of Date)
        Get
            Return Me.PACIENTE_.FECHABAJA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_FECHAN() As System.Nullable(Of Date)
        Get
            Return Me.PACIENTE_.FECHAN
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_FICHEROs() As System.Data.Linq.EntitySet(Of centro_medico.FICHERO)
    '    Get
    '        Return Me.PACIENTE_.FICHEROs
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_FOTO() As System.Data.Linq.Binary
    '    Get
    '        Return Me.PACIENTE_.FOTO
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_FOTOGRAFIA() As String
        Get
            Return Me.PACIENTE_.FOTOGRAFIA
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_HISTORIALEs() As System.Data.Linq.EntitySet(Of centro_medico.HISTORIALE)
    '    Get
    '        Return Me.PACIENTE_.HISTORIALEs
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_LEMPRESAs() As System.Data.Linq.EntitySet(Of centro_medico.LEMPRESA)
    '    Get
    '        Return Me.PACIENTE_.LEMPRESAs
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_LOCALIDAD() As String
        Get
            Return Me.PACIENTE_.LOCALIDAD
        End Get
    End Property

    Public ReadOnly Property PACIENTE_MOVIL() As String
        Get
            Return Me.PACIENTE_.MOVIL
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_MUTUA() As centro_medico.MUTUA
    '    Get
    '        Return Me.PACIENTE_.MUTUA
    '    End Get
    'End Property

    'Public ReadOnly Property PACIENTE_N_Tickets() As System.Data.Linq.EntitySet(Of centro_medico.N_Ticket)
    '    Get
    '        Return Me.PACIENTE_.N_Tickets
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_NIE() As String
        Get
            Return Me.PACIENTE_.NIE
        End Get
    End Property

    Public ReadOnly Property PACIENTE_NOMBRE() As String
        Get
            Return Me.PACIENTE_.NOMBRE
        End Get
    End Property

    Public ReadOnly Property PACIENTE_NSS() As String
        Get
            Return Me.PACIENTE_.NSS
        End Get
    End Property

    Public ReadOnly Property PACIENTE_OBSERVACIONES() As String
        Get
            Return Me.PACIENTE_.OBSERVACIONES
        End Get
    End Property

    Public ReadOnly Property PACIENTE_OFICINA() As String
        Get
            Return Me.PACIENTE_.OFICINA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_PAGOBANCO() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.PAGOBANCO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_PASAPORTE() As String
        Get
            Return Me.PACIENTE_.PASAPORTE
        End Get
    End Property

    Public ReadOnly Property PACIENTE_PROFESION() As String
        Get
            Return Me.PACIENTE_.PROFESION
        End Get
    End Property

    Public ReadOnly Property PACIENTE_PROVINCIA() As String
        Get
            Return Me.PACIENTE_.PROVINCIA
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_PagosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.PagosPaciente)
    '    Get
    '        Return Me.PACIENTE_.PagosPacientes
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_PUESTO() As String
        Get
            Return Me.PACIENTE_.PUESTO
        End Get
    End Property

    'Public ReadOnly Property PACIENTE_RECIBOs() As System.Data.Linq.EntitySet(Of centro_medico.RECIBO)
    '    Get
    '        Return Me.PACIENTE_.RECIBOs
    '    End Get
    'End Property

    Public ReadOnly Property PACIENTE_REFEMPRESA() As System.Nullable(Of Integer)
        Get
            Return Me.PACIENTE_.REFEMPRESA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_REFFORMAPAGO() As String
        Get
            Return Me.PACIENTE_.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_REFMUTUA() As System.Nullable(Of Integer)
        Get
            Return Me.PACIENTE_.REFMUTUA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_REFPAIS() As Integer
        Get
            Return Me.PACIENTE_.REFPAIS
        End Get
    End Property

    Public ReadOnly Property PACIENTE_REGIMEN() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.REGIMEN
        End Get
    End Property

    Public ReadOnly Property PACIENTE_SEXO() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.SEXO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_SOCIO() As System.Nullable(Of Char)
        Get
            Return Me.PACIENTE_.SOCIO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_TARJETASANITARIA() As String
        Get
            Return Me.PACIENTE_.TARJETASANITARIA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_TITULAR() As String
        Get
            Return Me.PACIENTE_.TITULAR
        End Get
    End Property

    Public ReadOnly Property PACIENTE_TLFNO() As String
        Get
            Return Me.PACIENTE_.TLFNO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_TUTOR() As String
        Get
            Return Me.PACIENTE_.TUTOR
        End Get
    End Property

    Public ReadOnly Property PACIENTE_WEB() As String
        Get
            Return Me.PACIENTE_.WEB
        End Get
    End Property


    'Empresa
    Public ReadOnly Property EMPRESA_ACTIVIDAD() As String
        Get
            Return Me.EMPRESA_.ACTIVIDAD
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CEMPRESA() As Integer
        Get
            Return Me.EMPRESA_.CEMPRESA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CIF() As String
        Get
            Return Me.EMPRESA_.CIF
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CNAE() As String
        Get
            Return Me.EMPRESA_.CNAE
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CP() As String
        Get
            Return Me.EMPRESA_.CP
        End Get
    End Property

    Public ReadOnly Property EMPRESA_CUENTA() As String
        Get
            Return Me.EMPRESA_.CUENTA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_DC() As String
        Get
            Return Me.EMPRESA_.DC
        End Get
    End Property

    Public ReadOnly Property EMPRESA_DIRECCION() As String
        Get
            Return Me.EMPRESA_.DIRECCION
        End Get
    End Property

    Public ReadOnly Property EMPRESA_ENTIDAD() As String
        Get
            Return Me.EMPRESA_.ENTIDAD
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
    '    Get
    '        Return Me.EMPRESA_.FACTURAs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_FAX() As String
        Get
            Return Me.EMPRESA_.FAX
        End Get
    End Property

    Public ReadOnly Property EMPRESA_FECHA() As System.Nullable(Of Date)
        Get
            Return Me.EMPRESA_.FECHA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_LEMPRESAs() As System.Data.Linq.EntitySet(Of centro_medico.LEMPRESA)
    '    Get
    '        Return Me.EMPRESA_.LEMPRESAs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_MAIL() As String
        Get
            Return Me.EMPRESA_.MAIL
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NOMBRE() As String
        Get
            Return Me.EMPRESA_.NOMBRE
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NOTAS() As String
        Get
            Return Me.EMPRESA_.NOTAS
        End Get
    End Property

    Public ReadOnly Property EMPRESA_NSS() As String
        Get
            Return Me.EMPRESA_.NSS
        End Get
    End Property

    Public ReadOnly Property EMPRESA_OFICINA() As String
        Get
            Return Me.EMPRESA_.OFICINA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_PACIENTEs() As System.Data.Linq.EntitySet(Of centro_medico.PACIENTE)
    '    Get
    '        Return Me.EMPRESA_.PACIENTEs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_PERSONACON() As String
        Get
            Return Me.EMPRESA_.PERSONACON
        End Get
    End Property

    Public ReadOnly Property EMPRESA_POBLACION() As String
        Get
            Return Me.EMPRESA_.POBLACION
        End Get
    End Property

    Public ReadOnly Property EMPRESA_PROVINCIA() As String
        Get
            Return Me.EMPRESA_.PROVINCIA
        End Get
    End Property

    'Public ReadOnly Property EMPRESA_RECIBOs() As System.Data.Linq.EntitySet(Of centro_medico.RECIBO)
    '    Get
    '        Return Me.EMPRESA_.RECIBOs
    '    End Get
    'End Property

    Public ReadOnly Property EMPRESA_REFMUTUA() As System.Nullable(Of Integer)
        Get
            Return Me.EMPRESA_.REFMUTUA
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TLFNO1() As String
        Get
            Return Me.EMPRESA_.TLFNO1
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TLFNO2() As String
        Get
            Return Me.EMPRESA_.TLFNO2
        End Get
    End Property

    Public ReadOnly Property EMPRESA_WEB() As String
        Get
            Return Me.EMPRESA_.WEB
        End Get
    End Property

    Public ReadOnly Property EMPRESA_TITULAR() As String
        Get
            Return Me.EMPRESA_.TITULAR
        End Get
    End Property
End Class