Public Class WRAPPER_CITA

    Private _cita As centro_medico.CITA
    Private PACIENTE_ As PACIENTE
    Private MEDICO_ As MEDICO
    Private MUTUA_ As MUTUA

    Public Sub New(ByVal _cita As centro_medico.CITA)
        Me._cita = _cita
        Me.PACIENTE_ = _cita.PACIENTE1
        Me.MEDICO_ = _cita.MEDICO
        Me.MUTUA_ = _cita.MUTUA
    End Sub

    Public ReadOnly Property IDCITA() As System.Nullable(Of Int32)
        Get
            Return Me._cita.IDCITA
        End Get
    End Property

    Public ReadOnly Property NUMEROCITA() As System.Nullable(Of Byte)
        Get
            Return Me._cita.NumeroCita
        End Get
    End Property

    Public ReadOnly Property ATENDIDO() As String
        Get
            Return Me._cita.ATENDIDO
        End Get
    End Property

    Public ReadOnly Property BANCO() As String
        Get
            Return Me._cita.BANCO
        End Get
    End Property

    Public ReadOnly Property CONFIRMADA() As String
        Get
            Return Me._cita.CONFIRMADA
        End Get
    End Property

    Public ReadOnly Property CONTINUA() As String
        Get
            Return Me._cita.CONTINUA
        End Get
    End Property

    Public ReadOnly Property d_PresupuestoLineas() As System.Data.Linq.EntitySet(Of centro_medico.d_PresupuestoLinea)
        Get
            Return Me._cita.d_PresupuestoLineas
        End Get
    End Property

    Public ReadOnly Property Descuento() As System.Nullable(Of Double)
        Get
            Return Me._cita.Descuento
        End Get
    End Property

    Public ReadOnly Property EstadoRecurrencia() As System.Nullable(Of Integer)
        Get
            Return Me._cita.EstadoRecurrencia
        End Get
    End Property

    Public ReadOnly Property FALTA() As String
        Get
            Return Me._cita.FALTA
        End Get
    End Property

    Public ReadOnly Property FECHA() As System.Nullable(Of Date)
        Get
            Return Me._cita.FECHA
        End Get
    End Property

    Public ReadOnly Property FechaUltimoEstadoRecurrencia() As System.Nullable(Of Date)
        Get
            Return Me._cita.FechaUltimoEstadoRecurrencia
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO() As centro_medico.FORMASPAGO
        Get
            Return Me._cita.FORMASPAGO
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_CODIGO As String
        Get
            Try
                Return Me._cita.FORMASPAGO.CODIGO
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property FORMASPAGO_DESCRIPCION As String
        Get
            Try
                Return Me._cita.FORMASPAGO.DESCRIPCION
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property HORA() As System.Nullable(Of Date)
        Get
            Return Me._cita.HORA
        End Get
    End Property

    Public ReadOnly Property HORAFIN() As System.Nullable(Of Date)
        Get
            Return Me._cita.HORAFIN
        End Get
    End Property

    Public ReadOnly Property ID_Proceso() As System.Nullable(Of Long)
        Get
            Return Me._cita.ID_Proceso
        End Get
    End Property

    Public ReadOnly Property IMPORTECL() As System.Nullable(Of Decimal)
        Get
            Return Me._cita.IMPORTECL
        End Get
    End Property

    Public ReadOnly Property IMPORTEDR() As System.Nullable(Of Decimal)
        Get
            Return Me._cita.IMPORTEDR
        End Get
    End Property

    Public ReadOnly Property LineasCitas() As System.Data.Linq.EntitySet(Of centro_medico.LineasCita)
        Get
            Return Me._cita.LineasCitas
        End Get
    End Property

    Public ReadOnly Property LINEASFACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.LINEASFACTURA)
        Get
            Return Me._cita.LINEASFACTURAs
        End Get
    End Property

    Public ReadOnly Property MEDICO() As centro_medico.MEDICO
        Get
            Return Me._cita.MEDICO
        End Get
    End Property

    Public ReadOnly Property NOTAS() As String
        Get
            Return Me._cita.NOTAS
        End Get
    End Property

    Public ReadOnly Property PACIENTE() As String
        Get

            If Not PACIENTE1 Is Nothing Then
                If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
                    Return PACIENTE1.NombreCompletoA1A2Nombre()
                Else
                    Return PACIENTE1.NombreCompleto()
                End If
            End If
            
            Return Me._cita.PACIENTE
        End Get
    End Property

    Public ReadOnly Property PACIENTE1() As centro_medico.PACIENTE
        Get
            Return Me._cita.PACIENTE1
        End Get
    End Property



    Public ReadOnly Property PAGADA() As String
        Get
            Return Me._cita.PAGADA
        End Get
    End Property

    Public ReadOnly Property REFFORMAPAGO() As String
        Get
            Return Me._cita.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property REFFRA() As System.Nullable(Of Integer)
        Get
            Return Me._cita.REFFRA
        End Get
    End Property

    Public ReadOnly Property REFMEDICO() As System.Nullable(Of Integer)
        Get
            Return Me._cita.REFMEDICO
        End Get
    End Property

    Public ReadOnly Property REFPACIENTE() As System.Nullable(Of Integer)
        Get
            Return Me._cita.REFPACIENTE
        End Get
    End Property

    Public ReadOnly Property REFRECIBO() As System.Nullable(Of Integer)
        Get
            Return Me._cita.REFRECIBO
        End Get
    End Property

    Public ReadOnly Property REFPROCEDENCIA() As System.Nullable(Of Integer)
        Get
            Return Me._cita.REFPROCEDENCIA
        End Get
    End Property

    Public ReadOnly Property MUTUA() As centro_medico.MUTUA
        Get
            Return Me._cita.MUTUA
        End Get
    End Property

    Public ReadOnly Property FECHACOBRO() As System.Nullable(Of Date)
        Get
            Return Me._cita.FECHACOBRO
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

    Public ReadOnly Property PACIENTE_Asociados() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
        Get
            Return Me.PACIENTE_.Asociados
        End Get
    End Property

    Public ReadOnly Property PACIENTE_Asociados1() As System.Data.Linq.EntitySet(Of centro_medico.Asociado)
        Get
            Return Me.PACIENTE_.Asociados1
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
        Get
            Return Me.PACIENTE_.CITAs
        End Get
    End Property

    Public ReadOnly Property PACIENTE_CODIGOPROPIO() As String
        Get
            Return Me.PACIENTE_.CODIGOPROPIO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_ContactosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.ContactosPaciente)
        Get
            Return Me.PACIENTE_.ContactosPacientes
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_d_Odontogramas() As System.Data.Linq.EntitySet(Of centro_medico.d_Odontograma)
        Get
            Return Me.PACIENTE_.d_Odontogramas
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_EntregasCuentas() As System.Data.Linq.EntitySet(Of centro_medico.EntregasCuenta)
        Get
            Return Me.PACIENTE_.EntregasCuentas
        End Get
    End Property

    Public ReadOnly Property PACIENTE_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
        Get
            Return Me.PACIENTE_.FACTURAs
        End Get
    End Property

    Public ReadOnly Property PACIENTE_EMPRESA() As centro_medico.EMPRESA
        Get
            Return Me.PACIENTE_.EMPRESA
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_FICHEROs() As System.Data.Linq.EntitySet(Of centro_medico.FICHERO)
        Get
            Return Me.PACIENTE_.FICHEROs
        End Get
    End Property

    Public ReadOnly Property PACIENTE_FOTO() As System.Data.Linq.Binary
        Get
            Return Me.PACIENTE_.FOTO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_FOTOGRAFIA() As String
        Get
            Return Me.PACIENTE_.FOTOGRAFIA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_HISTORIALEs() As System.Data.Linq.EntitySet(Of centro_medico.HISTORIALE)
        Get
            Return Me.PACIENTE_.HISTORIALEs
        End Get
    End Property

    Public ReadOnly Property PACIENTE_LEMPRESAs() As System.Data.Linq.EntitySet(Of centro_medico.LEMPRESA)
        Get
            Return Me.PACIENTE_.LEMPRESAs
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_MUTUA() As centro_medico.MUTUA
        Get
            Return Me.PACIENTE_.MUTUA
        End Get
    End Property

    Public ReadOnly Property PACIENTE_N_Tickets() As System.Data.Linq.EntitySet(Of centro_medico.N_Ticket)
        Get
            Return Me.PACIENTE_.N_Tickets
        End Get
    End Property

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

    Public ReadOnly Property PACIENTE_PagosPacientes() As System.Data.Linq.EntitySet(Of centro_medico.PagosPaciente)
        Get
            Return Me.PACIENTE_.PagosPacientes
        End Get
    End Property

    Public ReadOnly Property PACIENTE_PUESTO() As String
        Get
            Return Me.PACIENTE_.PUESTO
        End Get
    End Property

    Public ReadOnly Property PACIENTE_RECIBOs() As System.Data.Linq.EntitySet(Of centro_medico.RECIBO)
        Get
            Return Me.PACIENTE_.RECIBOs
        End Get
    End Property

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



    'MEDICO
    Public ReadOnly Property MEDICO_MOVIL() As String
        Get
            Return Me.MEDICO_.MOVIL
        End Get
    End Property

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

    Public ReadOnly Property MEDICO_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
        Get
            Return Me.MEDICO_.CITAs
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

    Public ReadOnly Property MEDICO_d_Acciones() As System.Data.Linq.EntitySet(Of centro_medico.d_Accione)
        Get
            Return Me.MEDICO_.d_Acciones
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

    Public ReadOnly Property MEDICO_HISTORIALEs() As System.Data.Linq.EntitySet(Of centro_medico.HISTORIALE)
        Get
            Return Me.MEDICO_.HISTORIALEs
        End Get
    End Property

    Public ReadOnly Property MEDICO_LOCALIDAD() As String
        Get
            Return Me.MEDICO_.LOCALIDAD
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

    Public ReadOnly Property MEDICO_NOMBRE() As String
        Get
            Return Me.MEDICO_.NOMBRE
        End Get
    End Property

    'MUTUA
    Public ReadOnly Property MUTUA_CIF() As String
        Get
            Return Me.MUTUA_.CIF
        End Get
    End Property

    Public ReadOnly Property MUTUA_CITAs() As System.Data.Linq.EntitySet(Of centro_medico.CITA)
        Get
            Return Me.MUTUA_.CITAs
        End Get
    End Property

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

    Public ReadOnly Property MUTUA_FACTURAs() As System.Data.Linq.EntitySet(Of centro_medico.FACTURA)
        Get
            Return Me.MUTUA_.FACTURAs
        End Get
    End Property

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
            Return Me.MUTUA_.NOMBRE
        End Get
    End Property

    Public ReadOnly Property MUTUA_NOTAS() As String
        Get
            Return Me.MUTUA_.NOTAS
        End Get
    End Property

    Public ReadOnly Property MUTUA_PACIENTEs() As System.Data.Linq.EntitySet(Of centro_medico.PACIENTE)
        Get
            Return Me.MUTUA_.PACIENTEs
        End Get
    End Property

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

End Class

