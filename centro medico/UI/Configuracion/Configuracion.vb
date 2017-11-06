Imports System.Xml.Linq
Imports Microsoft.ApplicationBlocks.Data


Public Class Configuracion

    Public Login As String
    Public Medaprox As String
    Public Mutuaaprox As String
    Public Formaaprox As String
    Public Proveedoraprox As String
    Public Bancoaprox As String
    Public Conceptoaprox As String
    Public Paisesaprox As String
    Public Conceptanalaprox As String
    Public Derivacionesaprox As String
    Public Alarmaaprox As String
    Public Articuloaprox As String
    Public Medicamentoaprox As String
    Public platillatextoaprox As String
    Public diagnosticoaprox As String
    Public Gastosaprox As String
    Public indicacionesaprox As String
    Public historialaprox As String
    Public asistaprox As String
    Public bajaaprox As String
    Public empaprox As String
    Public pacaprox As String
    Public facturasaprox As String
    Public analaprox As String
    Public plantillaanalaprox As String
    Public usuarioaprox As String
    Public revaprox As String
    Public recibosaprox As String
    Public serie As String
    Public IRPF As Single
    Public impresora As String
    Public impresionfilesdirectory As String
    
    Public dateinterval As Integer
    Public citainterval As Integer
    Public ivaIncluido As Integer
    'Public jornadalaboralfin As String

    Private _jornadalaboralini As TimeSpan
    Private _jornadalaboralfin As TimeSpan

    'Configuracion a nivel de Usuario
    Public citastyle As String
    Public citanote As Boolean
    Public citapac As Boolean
    Public citaCodPropioPac As Boolean
    Public citamed As Boolean
    Public citaesp As Boolean
    Public TamanoFuente As Integer
    Public EnfocarCodigoPropioPaciente As Boolean
    Public CalendarioMostrarListaMedicosPorDefecto As Boolean = False
    'Public ReporteFacturaMultiple As String = "2010_FacturaMultiple.rdlc"


    Function DameJornadaLaboralInicio(ByVal fecha As Date) As TimeSpan
        If JornadaLaboral.<Global>.@Activa = "True" Then
            Return _jornadalaboralini
        Else
            'Busco el dia correspodiente
            Dim dia As Integer = fecha.DayOfWeek
            Return TimeSpan.Parse(JornadaLaboral.<Dias>.<Dia>(dia).@Inicio)
        End If
    End Function

    Function DameJornadaLaboralFinal(ByVal fecha As Date) As TimeSpan
        If JornadaLaboral.<Global>.@Activa = "True" Then
            Return _jornadalaboralfin
        Else
            Dim dia As Integer = fecha.DayOfWeek
            Return TimeSpan.Parse(JornadaLaboral.<Dias>.<Dia>(dia).@Final)
        End If

    End Function


    Sub CambiaJornadaLaboralInicio(ByVal fecha As Date)
        If JornadaLaboral.<Global>.@Activa = "True" Then
            _jornadalaboralini = fecha.TimeOfDay
        End If
    End Sub

    Sub CambiaJornadaLaboralFinal(ByVal fecha As Date)
        If JornadaLaboral.<Global>.@Activa = "True" Then
            _jornadalaboralfin = fecha.TimeOfDay
        End If

    End Sub




    Public ReadOnly Property EmailAddress() As String
        Get
            Return Globales.Usuario.CONFIGURACIONXML.<Comunicacion>.<Email>.Value
        End Get
        'Set(ByVal value)

        'End Set
    End Property



    Public calendar As Boolean
    Public imagefile As String
    Public imagedirectory As String
    Public remoto As Boolean
    Public ip As String
    Public puerto As Integer
    Public dirfiles As String
    Public solapasvisibles As String
    Public solapasinicial As String
    Public filtrar As Boolean
    Public tipofiltrado As String
    Public solapashistoriales As Boolean
    Public histcampo1 As String
    Public histcampo2 As String
    Public histcampo3 As String
    Public histcampo4 As String
    Public histcampo5 As String
    Public histcampo6 As String
    Public histcampo7 As String
    Public histcampo8 As String
    Public histcampo9 As String
    Public campodiagnostico As String


    Public nombrecomercial As String
    Public denominacion As String
    Public domicilio As String
    Public localidad As String
    Public provincia As String
    Public CP As String
    Public Tlfno1 As String
    Public Email As String
    Public CIF As String
    Public Tlfno2 As String
    Public fax As String
    Public web As String
    Public libro As String
    Public regmercantil As String
    Public hoja As String
    Public folio As String
    Public seccion As String
    Public volumen As String
    Public urlParamFiles As String
    Public urlFacturaEexe As String
    Public ficheroDB As String
    Public ficheroimage As String
    Public comppac As String
    Public compmed As String
    Public compmut As String
    Public compemp As String
    Public compalarmas As String
    Public compdiagnostico As String
    Public compfact As String
    Public compart As String
    Public compmedicamento As String
    Public compproveedor As String
    Public companal As String
    Public comprec As String
    Public nombreord As String
    Public CIFord As String
    Public sufijoord As String
    Public entidadord As String
    Public DCord As String
    Public oficinaord As String
    Public cuentaord As String
    Public nombrepres As String
    Public CIFpres As String
    Public sufijopres As String
    Public entidadpres As String
    Public oficinapres As String

    Public Cita_AutoRefreshInterval As Long = 60000
    Public Cita_UsarSalas As Boolean = False

    Public Cita_IncluirPrecioDelMedicoEnLasLineas As Boolean = True
    'Public Citas_Medico_OcultarColumna As Boolean = False
    Public Cita_Medico_PorcientoGlobal As Double = 0


    Public logotipo As String
    Public carpetacompartidaficheros As String


    Public AutoSugerirHoraCita As Boolean = True

    Public SincCalendCitaFtp As Boolean = True
    Public IdentificadorClinica As String = ""

    Public Calendario_SiUsuarioMedicoMostrarSoloSusCitas As Boolean = False


    Public UsarCuentaDominioParaCarpetaCompartida As Boolean = False
    Public CarpetaCompartidaUsuario As String = String.Empty
    Public CarpetaCompartidaPassword As String = String.Empty
    Public CarpetaCompartidaDominio As String = String.Empty


    'Citas
    

    Public UserImpersonation As System.Security.Principal.WindowsImpersonationContext = Nothing


    Public UsarPacienteDebitoAlPagar As Boolean = True
    Public FiltroEspecial_Cumplennos As Boolean = True
    Public Dental_ModuloActivo As Boolean = True

    Public ModuloLiquidacionMedicos_Activo As Boolean

    Public chkActivar_control_Libro_Ingresos_gastos As Boolean = False

    'Public Fecha As Date = Date.Now.DayOfWeek.

    Public JornadaLaboral As Xml.Linq.XElement = <JornadaLaboral>
                                                     <Global Activa="True" Inicio="8:00" Final="17:00"/>
                                                     <Dias>
                                                         <Dia Nombre="Domingo" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Lunes" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Martes" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Miércoles" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Jueves" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Viernes" Inicio="8:00" Final="17:00"/>
                                                         <Dia Nombre="Sabado" Inicio="8:00" Final="17:00"/>
                                                     </Dias>
                                                 </JornadaLaboral>

    



    Public Enum CalendarioTipoFiltroEnum
        NoFiltrar = 1
        FiltrarMisCitas = 2
        FiltrarPrimerFacultativo = 3
    End Enum

    Public CalendarioTipoFiltro As Integer = CalendarioTipoFiltroEnum.NoFiltrar



#Region "Private Function LeeConfiguracionDesdeBd(ByVal Clave As String, Optional ByVal Valor As String = "", Optional ByVal Leer As Boolean = True)"



    ''' <summary>
    ''' Funcion que lee o escribe los valores de configuración en la bd y que comprueba 
    ''' si la clave existe. En caso de no exitir la crea en la tabla Variables Globales.
    ''' Se crea esta función para sustituir la forma de Cargar la configuración que debe ser
    ''' global para toda la aplicación.
    ''' </summary>
    ''' <param name="Clave">Nombre que se le da a la clave.</param>
    ''' <param name="Valor">Valor de la clave. Si no lo pasamos sera una cadena vacia</param>
    ''' <param name="Leer">Por defecto es true, lo que implica que lo que queremos es que la 
    ''' funcion nos devuelva el valor de la clave. En caso contrario escribira el valor sobre la clave definida. 
    ''' Si la clave no existe la crea.</param>
    ''' <returns>Devuelve el valor de la clave definida si hemos puesto el valor leer a true</returns>
    ''' <remarks></remarks>
    Private Function LeeConfiguracionDesdeBd(ByVal Clave As String, Optional ByVal Valor As String = "", Optional ByVal Leer As Boolean = True)
        Dim parametros As New List(Of SqlClient.SqlParameter)
        Dim claves As Integer = 0 'variable donde almacenamos los resultados devueltos al comprobar si existe alguna clave con el nombre proporcionado
        Dim valorClave As String = ""

        'comprobamos si existe la clave.
        parametros.Add(New SqlClient.SqlParameter("@Clave", Clave))
        claves = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select count(clave) from VariablesGlobales Where Clave=@Clave", parametros.ToArray)
        parametros.Clear()

        If claves = 0 Then
            'si la clave no existe la creamos.
            parametros.Add(New SqlClient.SqlParameter("@Clave", Clave))
            SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, "Insert into VariablesGlobales (Clave,Valor) values (@Clave,'')", parametros.ToArray)
            parametros.Clear()
        End If
        If Leer = True Then
            parametros.Add(New SqlClient.SqlParameter("@Clave", Clave))
            valorClave = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select Valor from VariablesGlobales Where Clave=@Clave", parametros.ToArray)
            parametros.Clear()
        Else
            If Not Valor Is Nothing Then
                If Valor.Trim.Length > 0 Then
                    parametros.Add(New SqlClient.SqlParameter("@Clave", Clave))
                    parametros.Add(New SqlClient.SqlParameter("@Valor", Valor))
                    SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, "Update VariablesGlobales Set Valor = @Valor Where Clave = @Clave", parametros.ToArray)
                    'Else
                    '    MsgBox("No ha definido un valor correcto para " & Clave & ". No se actualizará este parametro de configuración.", MsgBoxStyle.Exclamation)
                End If
            End If


        End If
        Return valorClave
    End Function

#End Region

#Region "Private Function LeeConfiguracionDesdeXML(ByVal Seccion As String, ByVal Clave As String, Optional ByVal Valor As String = "", Optional ByVal Leer As Boolean = True)"
    Private Function LeeConfiguracionDesdeXML(ByVal Seccion As String, ByVal Clave As String, Optional ByVal Valor As String = "", Optional ByVal Leer As Boolean = True)
        Dim dir As String = Application.StartupPath()
        Dim rxml As New AMS.Profile.Xml(dir + "\\Config\\configuracion.xml")
        Dim resultado As String = ""
        If Leer = True Then
            If rxml.HasEntry(Seccion, Clave) Then
                resultado = rxml.GetValue(Seccion, Clave)
            Else
                'Si el dato al que intento acceder no exite, lo creo y le devuelvo.
                rxml.SetValue(Seccion, Clave, Valor)
                resultado = rxml.GetValue(Seccion, Clave)
            End If
        Else
            rxml.SetValue(Seccion, Clave, Valor)

        End If
        Return resultado
    End Function
#End Region

#Region "Public Sub LeerConfBD()"
    Public Sub LeerConfBD()

        Dim t As String = Me.LeeConfiguracionDesdeBd("AutoSugerirHoraCita").ToString()
        If t = "" Then
            Me.AutoSugerirHoraCita = True
        Else
            Me.AutoSugerirHoraCita = False
        End If

        Dim s As String = Me.LeeConfiguracionDesdeBd("SincCalendCitaFtp").ToString()
        If s = "" Or s = "True" Then
            Me.SincCalendCitaFtp = True
        Else
            Me.SincCalendCitaFtp = False
        End If

        Me.IdentificadorClinica = Me.LeeConfiguracionDesdeBd("IdentificadorClinica").ToString()

        serie = Me.LeeConfiguracionDesdeBd("SerieDefecto")
        If Me.LeeConfiguracionDesdeBd("IRPFDefecto").ToString.Trim.Length = 0 Then
            IRPF = 0
        Else
            IRPF = Me.LeeConfiguracionDesdeBd("IRPFDefecto")
        End If
        impresionfilesdirectory = Me.LeeConfiguracionDesdeBd("DirectorioPlantillasImpresion")
        If Me.LeeConfiguracionDesdeBd("IntervaloCita").ToString.Trim.Length = 0 Then
            dateinterval = 10
        Else
            dateinterval = Me.LeeConfiguracionDesdeBd("IntervaloCita")
        End If
        If Me.LeeConfiguracionDesdeBd("DuracionCita").ToString.Trim.Length = 0 Then
            citainterval = 10
        Else
            citainterval = Me.LeeConfiguracionDesdeBd("DuracionCita")
        End If
        If Me.LeeConfiguracionDesdeBd("InicioJornada").ToString.Trim.Length = 0 Then
            _jornadalaboralini = New TimeSpan(8, 0, 0)
        Else
            Dim hora As Long = Me.LeeConfiguracionDesdeBd("InicioJornada")
            If hora < 24 Then
                _jornadalaboralini = New TimeSpan(hora, 0, 0)
            Else
                _jornadalaboralini = New TimeSpan(hora)
            End If
        End If

        If Me.LeeConfiguracionDesdeBd("FinJornada").ToString.Trim.Length = 0 Then
            _jornadalaboralfin = New TimeSpan(19, 0, 0)
        Else

            Dim hora As Long = Me.LeeConfiguracionDesdeBd("FinJornada")
            If hora < 24 Then
                _jornadalaboralfin = New TimeSpan(hora, 0, 0)
            Else
                _jornadalaboralfin = New TimeSpan(hora)
            End If
        End If


        imagedirectory = Me.LeeConfiguracionDesdeBd("CarpetaImagenes")
        If Me.LeeConfiguracionDesdeBd("FiltrarPaciente").ToString.Trim.Length = 0 Then
            filtrar = True
        Else
            If Me.LeeConfiguracionDesdeBd("FiltrarPaciente") = "S" Then filtrar = True Else filtrar = False
        End If
        If Me.LeeConfiguracionDesdeBd("HistorialSolapas").ToString.Trim.Length = 0 Then
            solapashistoriales = True
        Else
            If Me.LeeConfiguracionDesdeBd("HistorialSolapas") = "S" Then solapashistoriales = True Else solapashistoriales = False

        End If

        dirfiles = Me.LeeConfiguracionDesdeBd("RutaFicheros")
        tipofiltrado = Me.LeeConfiguracionDesdeBd("FiltrarPacientesDesde")
        solapasinicial = Me.LeeConfiguracionDesdeBd("SolapaPacientes")
        solapasvisibles = Me.LeeConfiguracionDesdeBd("SolapasVisibles")
        If Me.LeeConfiguracionDesdeBd("Campo1").ToString.Trim.Length = 0 Then
            histcampo1 = "Motivo de Consulta"
        Else
            histcampo1 = Me.LeeConfiguracionDesdeBd("Campo1")
        End If
        If Me.LeeConfiguracionDesdeBd("Campo2").ToString.Trim.Length = 0 Then
            histcampo2 = "Antecedentes"
        Else
            histcampo2 = Me.LeeConfiguracionDesdeBd("Campo2")
        End If
        If Me.LeeConfiguracionDesdeBd("Campo3").ToString.Trim.Length = 0 Then
            histcampo3 = "Historial"
        Else
            histcampo3 = Me.LeeConfiguracionDesdeBd("Campo3")
        End If
        If Me.LeeConfiguracionDesdeBd("Campo4").ToString.Trim.Length = 0 Then
            histcampo4 = "Exploración"
        Else
            histcampo4 = Me.LeeConfiguracionDesdeBd("Campo4")
        End If

        If Me.LeeConfiguracionDesdeBd("Campo5").ToString.Trim.Length = 0 Then
            histcampo5 = "Pruebas complementarias"
        Else
            histcampo5 = Me.LeeConfiguracionDesdeBd("Campo5")
        End If
        If Me.LeeConfiguracionDesdeBd("Campo6").ToString.Trim.Length = 0 Then
            histcampo6 = "Hipótesis diagnóstica"
        Else
            histcampo6 = Me.LeeConfiguracionDesdeBd("Campo6")
        End If

        If Me.LeeConfiguracionDesdeBd("Campo7").ToString.Trim.Length = 0 Then
            histcampo7 = "Tratamiento"
        Else
            histcampo7 = Me.LeeConfiguracionDesdeBd("Campo7")
        End If
        If Me.LeeConfiguracionDesdeBd("Campo8").ToString.Trim.Length = 0 Then
            histcampo8 = "Otras observaciones"
        Else
            histcampo8 = Me.LeeConfiguracionDesdeBd("Campo8")
        End If

        If Me.LeeConfiguracionDesdeBd("Campo9").ToString.Trim.Length = 0 Then
            histcampo9 = "Notas finales"
        Else
            histcampo9 = Me.LeeConfiguracionDesdeBd("Campo9")
        End If
        If Me.LeeConfiguracionDesdeBd("Diagnostico").ToString.Trim.Length = 0 Then
            campodiagnostico = 6
        Else
            campodiagnostico = Me.LeeConfiguracionDesdeBd("Diagnostico")
        End If

        nombrecomercial = Me.LeeConfiguracionDesdeBd("NombreComercial")
        denominacion = Me.LeeConfiguracionDesdeBd("Denominacion")
        CP = Me.LeeConfiguracionDesdeBd("CP")
        provincia = Me.LeeConfiguracionDesdeBd("Provincia")
        localidad = Me.LeeConfiguracionDesdeBd("Localidad")
        Tlfno1 = Me.LeeConfiguracionDesdeBd("Tlfno1")
        Tlfno2 = Me.LeeConfiguracionDesdeBd("Tlfno2")
        fax = Me.LeeConfiguracionDesdeBd("Fax")
        CIF = Me.LeeConfiguracionDesdeBd("CIF")
        Email = Me.LeeConfiguracionDesdeBd("Email")
        web = Me.LeeConfiguracionDesdeBd("Web")
        libro = Me.LeeConfiguracionDesdeBd("Libro")
        regmercantil = Me.LeeConfiguracionDesdeBd("RegistroLocalizacion")
        hoja = Me.LeeConfiguracionDesdeBd("Hoja")
        folio = Me.LeeConfiguracionDesdeBd("Folio")
        seccion = Me.LeeConfiguracionDesdeBd("Seccion")
        volumen = Me.LeeConfiguracionDesdeBd("Volumen")
        urlParamFiles = Me.LeeConfiguracionDesdeBd("FacturaEFicherosParametrosUrl")
        urlFacturaEexe = Me.LeeConfiguracionDesdeBd("FacturaEEjecutableUrl")
        domicilio = Me.LeeConfiguracionDesdeBd("Domicilio")
        comppac = Me.LeeConfiguracionDesdeBd("Pacientes")
        compmed = Me.LeeConfiguracionDesdeBd("Medicos")
        compmut = Me.LeeConfiguracionDesdeBd("Mutuas")
        compemp = Me.LeeConfiguracionDesdeBd("Empresas")
        compalarmas = Me.LeeConfiguracionDesdeBd("Alarmas")
        compdiagnostico = Me.LeeConfiguracionDesdeBd("Diagnosticos")
        compfact = Me.LeeConfiguracionDesdeBd("Facturas")
        compart = Me.LeeConfiguracionDesdeBd("Articulos")
        compmedicamento = Me.LeeConfiguracionDesdeBd("Medicamentos")
        compproveedor = Me.LeeConfiguracionDesdeBd("Proveedores")
        companal = Me.LeeConfiguracionDesdeBd("Analiticas")
        comprec = Me.LeeConfiguracionDesdeBd("Recibos")
        nombreord = Me.LeeConfiguracionDesdeBd("NombreOrdenante")
        CIFord = Me.LeeConfiguracionDesdeBd("NifOrdenante")
        sufijoord = Me.LeeConfiguracionDesdeBd("SufijoOrdenante")
        DCord = Me.LeeConfiguracionDesdeBd("DC")
        entidadord = Me.LeeConfiguracionDesdeBd("EntidadOrdenante")
        oficinaord = Me.LeeConfiguracionDesdeBd("OficinaOrdenante")
        cuentaord = Me.LeeConfiguracionDesdeBd("CuentaOrdenante")
        nombrepres = Me.LeeConfiguracionDesdeBd("NombrePresentador")
        CIFpres = Me.LeeConfiguracionDesdeBd("CIFPresentador")
        oficinapres = Me.LeeConfiguracionDesdeBd("OficinaPresentador")
        entidadpres = Me.LeeConfiguracionDesdeBd("EntidadPresentador")
        sufijopres = Me.LeeConfiguracionDesdeBd("SufijoPresentador")
        'If Me.LeeConfiguracionDesdeBd("FRFHistorial").ToString.Trim.Length = 0 Then
        '    histficheroimpresion = "Historial.rdlc"
        'Else
        '    histficheroimpresion = Me.LeeConfiguracionDesdeBd("FRFHistorial")
        'End If


        logotipo = Me.LeeConfiguracionDesdeBd("Logotipo")
        Medaprox = Me.LeeConfiguracionDesdeBd("MedicosAproximada")
        Bancoaprox = Me.LeeConfiguracionDesdeBd("BancosAproximada")
        empaprox = Me.LeeConfiguracionDesdeBd("EmpresasAproximada")
        Gastosaprox = Me.LeeConfiguracionDesdeBd("GastosAproximada")
        diagnosticoaprox = Me.LeeConfiguracionDesdeBd("DiagnosticosAproximada")
        Formaaprox = Me.LeeConfiguracionDesdeBd("FormasPagoAproximada")
        facturasaprox = Me.LeeConfiguracionDesdeBd("FacturasAproximada")
        pacaprox = Me.LeeConfiguracionDesdeBd("PacientesAproximada")
        analaprox = Me.LeeConfiguracionDesdeBd("AnaliticasProximada")
        Proveedoraprox = Me.LeeConfiguracionDesdeBd("Proveedoraproximada")
        Conceptoaprox = Me.LeeConfiguracionDesdeBd("ConceptosFraAproximada")
        Paisesaprox = Me.LeeConfiguracionDesdeBd("PaisesAproximada")
        Conceptanalaprox = Me.LeeConfiguracionDesdeBd("ConceptosAnaliticasAproximada")
        Derivacionesaprox = Me.LeeConfiguracionDesdeBd("DerivacionesAproximada")
        Alarmaaprox = Me.LeeConfiguracionDesdeBd("AlarmasAproximada")
        Articuloaprox = Me.LeeConfiguracionDesdeBd("ArticulosAproximada")
        Medicamentoaprox = Me.LeeConfiguracionDesdeBd("MedicamentosAproximada")
        platillatextoaprox = Me.LeeConfiguracionDesdeBd("PlantillaTextoAproximada")
        indicacionesaprox = Me.LeeConfiguracionDesdeBd("IndicacionesAproximada")
        historialaprox = Me.LeeConfiguracionDesdeBd("HistorialAproximada")
        asistaprox = Me.LeeConfiguracionDesdeBd("AsistenciaAproximada")
        bajaaprox = Me.LeeConfiguracionDesdeBd("BajaAproximada")
        plantillaanalaprox = Me.LeeConfiguracionDesdeBd("PlantillaAnaliticasAproximada")
        usuarioaprox = Me.LeeConfiguracionDesdeBd("UsuariosAproximada")
        revaprox = Me.LeeConfiguracionDesdeBd("RevisionesAproximada")
        recibosaprox = Me.LeeConfiguracionDesdeBd("RecibosAproximada")

        If Me.LeeConfiguracionDesdeBd("IvaIncluido").ToString.Trim.Length > 0 Then
            ivaIncluido = Me.LeeConfiguracionDesdeBd("IvaIncluido")
        Else
            ivaIncluido = 0
        End If

        If Me.LeeConfiguracionDesdeBd("Cita_AutoRefreshInterval") = "" Then
            Cita_AutoRefreshInterval = 60000
        Else
            Cita_AutoRefreshInterval = Long.Parse(Me.LeeConfiguracionDesdeBd("Cita_AutoRefreshInterval").ToString())
        End If

        If Me.LeeConfiguracionDesdeBd("Cita_UsarSalas") = "" Then
            Cita_UsarSalas = False
        Else
            Cita_UsarSalas = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Cita_UsarSalas").ToString())
        End If

        If Me.LeeConfiguracionDesdeBd("Cita_IncluirPrecioDelMedicoEnLasLineas") = "" Then
            Cita_IncluirPrecioDelMedicoEnLasLineas = True
        Else
            Cita_IncluirPrecioDelMedicoEnLasLineas = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Cita_IncluirPrecioDelMedicoEnLasLineas").ToString())
        End If

        'If Me.LeeConfiguracionDesdeBd("Citas_Medico_OcultarColumna") = "" Then
        '    Citas_Medico_OcultarColumna = False
        'Else
        '    Citas_Medico_OcultarColumna = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Citas_Medico_OcultarColumna").ToString())
        'End If

        If Me.LeeConfiguracionDesdeBd("Cita_Medico_PorcientoGlobal") = "" Then
            Cita_Medico_PorcientoGlobal = 0
        Else
            Cita_Medico_PorcientoGlobal = Double.Parse(Me.LeeConfiguracionDesdeBd("Cita_Medico_PorcientoGlobal").ToString())
        End If

        If Me.LeeConfiguracionDesdeBd("Calendario_SiUsuarioMedicoMostrarSoloSusCitas") = "" Then
            Calendario_SiUsuarioMedicoMostrarSoloSusCitas = False
        Else
            Calendario_SiUsuarioMedicoMostrarSoloSusCitas = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Calendario_SiUsuarioMedicoMostrarSoloSusCitas"))
        End If

        If Me.LeeConfiguracionDesdeBd("UsarCuentaDominioParaCarpetaCompartida") = "" Then
            UsarCuentaDominioParaCarpetaCompartida = False
        Else
            UsarCuentaDominioParaCarpetaCompartida = Boolean.Parse(Me.LeeConfiguracionDesdeBd("UsarCuentaDominioParaCarpetaCompartida"))
        End If

        Globales.Configuracion.CarpetaCompartidaUsuario = Me.LeeConfiguracionDesdeBd("CarpetaCompartidaUsuario")
        Globales.Configuracion.CarpetaCompartidaPassword = Me.LeeConfiguracionDesdeBd("CarpetaCompartidaPassword")
        Globales.Configuracion.CarpetaCompartidaDominio = Me.LeeConfiguracionDesdeBd("CarpetaCompartidaDominio")



        'If Me.LeeConfiguracionDesdeBd("Dental_Presupuesto_TenerEnCuentaCantidadPiezas") = "" Then
        '    Dental_Presupuesto_TenerEnCuentaCantidadPiezas = False
        'Else
        '    Globales.Configuracion.Dental_Presupuesto_TenerEnCuentaCantidadPiezas = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Dental_Presupuesto_TenerEnCuentaCantidadPiezas"))
        'End If



        If Me.LeeConfiguracionDesdeBd("UsarPacienteDebitoAlPagar") = "" Then
            UsarPacienteDebitoAlPagar = True 'Boolean.Parse(Me.LeeConfiguracionDesdeBd("UsarPacienteDebitoAlPagar"))
        Else
            UsarPacienteDebitoAlPagar = True 'Boolean.Parse(Me.LeeConfiguracionDesdeBd("UsarPacienteDebitoAlPagar"))
        End If


        If Me.LeeConfiguracionDesdeBd("FiltroEspecial_Cumplennos") = "" Then
            FiltroEspecial_Cumplennos = True
        Else
            FiltroEspecial_Cumplennos = Boolean.Parse(Me.LeeConfiguracionDesdeBd("FiltroEspecial_Cumplennos"))
        End If

        If Me.LeeConfiguracionDesdeBd("Dental_ModuloActivo") = "" Then
            Dental_ModuloActivo = True
        Else
            Dental_ModuloActivo = Boolean.Parse(Me.LeeConfiguracionDesdeBd("Dental_ModuloActivo"))
        End If


        If Me.LeeConfiguracionDesdeBd("ModuloLiquidacionMedicos_Activo") = "" Then
            ModuloLiquidacionMedicos_Activo = True
        Else
            ModuloLiquidacionMedicos_Activo = Boolean.Parse(Me.LeeConfiguracionDesdeBd("ModuloLiquidacionMedicos_Activo"))
        End If

        'ReporteFacturaMultiple = Me.LeeConfiguracionDesdeBd("Reporte_Factura_Multiple")
        'If ReporteFacturaMultiple = String.Empty Then
        '    ReporteFacturaMultiple = "2010_FacturaMultiple.rdlc"
        'End If

        If Me.LeeConfiguracionDesdeBd("chkActivar_control_Libro_Ingresos_gastos") = "" Then
            chkActivar_control_Libro_Ingresos_gastos = False
        Else
            chkActivar_control_Libro_Ingresos_gastos = Boolean.Parse(Me.LeeConfiguracionDesdeBd("chkActivar_control_Libro_Ingresos_gastos"))
        End If

        If Me.LeeConfiguracionDesdeBd("JornadaLaboral") <> "" Then
            JornadaLaboral = Xml.Linq.XElement.Parse(Me.LeeConfiguracionDesdeBd("JornadaLaboral"))
        End If




    End Sub

#End Region

#Region "Public Sub GuardarConfBD()"
    Public Sub GuardarConfBd()

        LeeConfiguracionDesdeBd("AutoSugerirHoraCita", AutoSugerirHoraCita, False)
        LeeConfiguracionDesdeBd("SincCalendCitaFtp", SincCalendCitaFtp, False)
        LeeConfiguracionDesdeBd("IdentificadorClinica", IdentificadorClinica, False)


        LeeConfiguracionDesdeBd("SerieDefecto", serie, False)
        LeeConfiguracionDesdeBd("IRPFDefecto", IRPF.ToString, False)
        LeeConfiguracionDesdeBd("DirectorioPlantillasImpresion", impresionfilesdirectory, False)
        LeeConfiguracionDesdeBd("IntervaloCita", dateinterval.ToString, False)
        LeeConfiguracionDesdeBd("DuracionCita", citainterval.ToString, False)
        LeeConfiguracionDesdeBd("InicioJornada", _jornadalaboralini.Ticks, False)
        LeeConfiguracionDesdeBd("FinJornada", _jornadalaboralfin.Ticks, False)
        'LeeConfiguracionDesdeBd("TipoVistaCita", citastyle.ToString, False)
        'If citapac = True Then LeeConfiguracionDesdeBd("MostrarPacienteCitas", "S", False) Else LeeConfiguracionDesdeBd("MostrarPacienteCitas", "N", False)
        'If citamed = True Then LeeConfiguracionDesdeBd("MostrarMedicoCitas", "S", False) Else LeeConfiguracionDesdeBd("MostrarMedicoCitas", "N", False)
        'If citanote = True Then LeeConfiguracionDesdeBd("MostrarNotasCitas", "S", False) Else LeeConfiguracionDesdeBd("MostrarNotasCitas", "N", False)
        'If citaesp = True Then LeeConfiguracionDesdeBd("MostrarEspecialidadCitas", "S", False) Else LeeConfiguracionDesdeBd("MostrarEspecialidadCitas", "N", False)
        LeeConfiguracionDesdeBd("CarpetaImagenes", imagedirectory.ToString, False)
        If filtrar = True Then LeeConfiguracionDesdeBd("FiltrarPaciente", "S", False) Else LeeConfiguracionDesdeBd("FiltrarPaciente", "N", False)
        If solapashistoriales = True Then LeeConfiguracionDesdeBd("HistorialSolapas", "S", False) Else LeeConfiguracionDesdeBd("HistorialSolapas", "N", False)
        LeeConfiguracionDesdeBd("RutaFicheros", dirfiles.ToString, False)
        LeeConfiguracionDesdeBd("FiltrarPacientesDesde", tipofiltrado.ToString, False)
        LeeConfiguracionDesdeBd("SolapaPacientes", solapasinicial.ToString, False)
        LeeConfiguracionDesdeBd("SolapasVisibles", solapasvisibles.ToString, False)
        LeeConfiguracionDesdeBd("Campo1", histcampo1, False)
        LeeConfiguracionDesdeBd("Campo2", histcampo2, False)
        LeeConfiguracionDesdeBd("Campo3", histcampo3, False)
        LeeConfiguracionDesdeBd("Campo4", histcampo4, False)
        LeeConfiguracionDesdeBd("Campo5", histcampo5, False)
        LeeConfiguracionDesdeBd("Campo6", histcampo6, False)
        LeeConfiguracionDesdeBd("Campo7", histcampo7, False)
        LeeConfiguracionDesdeBd("Campo8", histcampo8, False)
        LeeConfiguracionDesdeBd("Campo9", histcampo9, False)
        LeeConfiguracionDesdeBd("Diagnostico", campodiagnostico, False)
        LeeConfiguracionDesdeBd("NombreComercial", nombrecomercial, False)
        LeeConfiguracionDesdeBd("Denominacion", denominacion, False)
        LeeConfiguracionDesdeBd("CP", CP, False)
        LeeConfiguracionDesdeBd("Provincia", provincia, False)
        LeeConfiguracionDesdeBd("Localidad", localidad, False)
        LeeConfiguracionDesdeBd("Tlfno1", Tlfno1, False)
        LeeConfiguracionDesdeBd("Tlfno2", Tlfno2, False)
        LeeConfiguracionDesdeBd("Fax", fax, False)
        LeeConfiguracionDesdeBd("CIF", CIF, False)
        LeeConfiguracionDesdeBd("Email", Email, False)
        LeeConfiguracionDesdeBd("Web", web, False)
        LeeConfiguracionDesdeBd("Libro", libro, False)
        LeeConfiguracionDesdeBd("RegistroLocalizacion", regmercantil, False)
        LeeConfiguracionDesdeBd("Hoja", hoja, False)
        LeeConfiguracionDesdeBd("Folio", folio, False)
        LeeConfiguracionDesdeBd("Seccion", seccion, False)
        LeeConfiguracionDesdeBd("Volumen", volumen, False)
        LeeConfiguracionDesdeBd("FacturaEFicherosParametrosUrl", urlParamFiles, False)
        LeeConfiguracionDesdeBd("FacturaEEjecutableUrl", urlFacturaEexe, False)
        LeeConfiguracionDesdeBd("Domicilio", domicilio, False)
        LeeConfiguracionDesdeBd("Pacientes", comppac, False)
        LeeConfiguracionDesdeBd("Medicos", compmed, False)
        LeeConfiguracionDesdeBd("Mutuas", compmut, False)
        LeeConfiguracionDesdeBd("Empresas", compemp, False)
        LeeConfiguracionDesdeBd("Alarmas", compalarmas, False)
        LeeConfiguracionDesdeBd("Diagnosticos", compdiagnostico, False)
        LeeConfiguracionDesdeBd("Facturas", compfact, False)
        LeeConfiguracionDesdeBd("Articulos", compart, False)
        LeeConfiguracionDesdeBd("Medicamentos", compmedicamento, False)
        LeeConfiguracionDesdeBd("Proveedores", compproveedor, False)
        LeeConfiguracionDesdeBd("Analiticas", companal, False)
        LeeConfiguracionDesdeBd("Recibos", comprec, False)
        LeeConfiguracionDesdeBd("NombreOrdenante", nombreord, False)
        LeeConfiguracionDesdeBd("NifOrdenante", CIFord, False)
        LeeConfiguracionDesdeBd("SufijoOrdenante", sufijoord, False)
        LeeConfiguracionDesdeBd("DC", DCord, False)
        LeeConfiguracionDesdeBd("EntidadOrdenante", entidadord, False)
        LeeConfiguracionDesdeBd("OficinaOrdenante", oficinaord, False)
        LeeConfiguracionDesdeBd("CuentaOrdenante", cuentaord, False)
        LeeConfiguracionDesdeBd("NombrePresentador", nombrepres, False)
        LeeConfiguracionDesdeBd("CIFPresentador", CIFpres, False)
        LeeConfiguracionDesdeBd("OficinaPresentador", oficinapres, False)
        LeeConfiguracionDesdeBd("EntidadPresentador", entidadpres, False)
        LeeConfiguracionDesdeBd("SufijoPresentador", sufijopres, False)
        'LeeConfiguracionDesdeBd("FRFHistorial", histficheroimpresion, False)
        
        LeeConfiguracionDesdeBd("Logotipo", logotipo, False)
        LeeConfiguracionDesdeBd("MedicosAproximada", Medaprox, False)
        LeeConfiguracionDesdeBd("BancosAproximada", Bancoaprox, False)
        LeeConfiguracionDesdeBd("EmpresasAproximada", empaprox, False)
        LeeConfiguracionDesdeBd("GastosAproximada", Gastosaprox, False)
        LeeConfiguracionDesdeBd("DiagnosticosAproximada", diagnosticoaprox, False)
        LeeConfiguracionDesdeBd("FormasPagoAproximada", Formaaprox, False)
        LeeConfiguracionDesdeBd("FacturasAproximada", facturasaprox, False)
        LeeConfiguracionDesdeBd("PacientesAproximada", pacaprox, False)
        LeeConfiguracionDesdeBd("AnaliticasProximada", analaprox, False)
        LeeConfiguracionDesdeBd("Proveedoraproximada", Proveedoraprox, False)
        LeeConfiguracionDesdeBd("ConceptosFraAproximada", Conceptoaprox, False)
        LeeConfiguracionDesdeBd("PaisesAproximada", Paisesaprox, False)
        LeeConfiguracionDesdeBd("ConceptosAnaliticasAproximada", Conceptanalaprox, False)
        LeeConfiguracionDesdeBd("DerivacionesAproximada", Derivacionesaprox, False)
        LeeConfiguracionDesdeBd("AlarmasAproximada", Alarmaaprox, False)
        LeeConfiguracionDesdeBd("ArticulosAproximada", Articuloaprox, False)
        LeeConfiguracionDesdeBd("MedicamentosAproximada", Medicamentoaprox, False)
        LeeConfiguracionDesdeBd("PlantillaTextoAproximada", platillatextoaprox, False)
        LeeConfiguracionDesdeBd("IndicacionesAproximada", indicacionesaprox, False)
        LeeConfiguracionDesdeBd("HistorialAproximada", historialaprox, False)
        LeeConfiguracionDesdeBd("AsistenciaAproximada", asistaprox, False)
        LeeConfiguracionDesdeBd("BajaAproximada", bajaaprox, True)
        LeeConfiguracionDesdeBd("PlantillaAnaliticasAproximada", plantillaanalaprox, False)
        LeeConfiguracionDesdeBd("UsuariosAproximada", usuarioaprox, False)
        LeeConfiguracionDesdeBd("RevisionesAproximada", revaprox, False)
        LeeConfiguracionDesdeBd("RecibosAproximada", recibosaprox, False)
        LeeConfiguracionDesdeBd("IvaIncluido", ivaIncluido, False)

        LeeConfiguracionDesdeBd("Cita_AutoRefreshInterval", Cita_AutoRefreshInterval, False)
        LeeConfiguracionDesdeBd("Cita_UsarSalas", Cita_UsarSalas, False)
        LeeConfiguracionDesdeBd("Cita_IncluirPrecioDelMedicoEnLasLineas", Cita_IncluirPrecioDelMedicoEnLasLineas, False)
        'LeeConfiguracionDesdeBd("Citas_Medico_OcultarColumna", Citas_Medico_OcultarColumna, False)
        LeeConfiguracionDesdeBd("Cita_Medico_PorcientoGlobal", Cita_Medico_PorcientoGlobal, False)
        LeeConfiguracionDesdeBd("Calendario_SiUsuarioMedicoMostrarSoloSusCitas", Calendario_SiUsuarioMedicoMostrarSoloSusCitas, False)

        LeeConfiguracionDesdeBd("UsarCuentaDominioParaCarpetaCompartida", UsarCuentaDominioParaCarpetaCompartida, False)

        LeeConfiguracionDesdeBd("CarpetaCompartidaUsuario", CarpetaCompartidaUsuario, False)
        LeeConfiguracionDesdeBd("CarpetaCompartidaPassword", CarpetaCompartidaPassword, False)
        LeeConfiguracionDesdeBd("CarpetaCompartidaDominio", CarpetaCompartidaDominio, False)
        
       
        LeeConfiguracionDesdeBd("UsarPacienteDebitoAlPagar", UsarPacienteDebitoAlPagar, False)

        LeeConfiguracionDesdeBd("FiltroEspecial_Cumplennos", FiltroEspecial_Cumplennos, False)
        LeeConfiguracionDesdeBd("Dental_ModuloActivo", Dental_ModuloActivo, False)

        LeeConfiguracionDesdeBd("ModuloLiquidacionMedicos_Activo", ModuloLiquidacionMedicos_Activo, False)

        'LeeConfiguracionDesdeBd("Reporte_Factura_Multiple", ReporteFacturaMultiple, False)

        LeeConfiguracionDesdeBd("chkActivar_control_Libro_Ingresos_gastos", chkActivar_control_Libro_Ingresos_gastos, False)

        LeeConfiguracionDesdeBd("JornadaLaboral", JornadaLaboral.ToString(), False)

        'LeeConfiguracionDesdeBd("Dental_Presupuesto_TenerEnCuentaCantidadPiezas", Dental_Presupuesto_TenerEnCuentaCantidadPiezas, False)

       
    End Sub
#End Region

#Region "Public Sub Crea()"
    Public Sub Crea()

        'Aqui debo leerla del usuario

        If Globales.Usuario.CONFIGURACIONXML Is Nothing Then
            Dim valor As String = ""
            citastyle = Me.LeeConfiguracionDesdeXML("CITAS", "VISTA", "Grafica")

            valor = Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARPACIENTE", "S")
            If valor = "S" Then
                citapac = True
            Else
                citapac = False
            End If

            valor = Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARMEDICO", "S")
            If valor = "S" Then
                citamed = True
            Else
                citamed = False
            End If

            valor = Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARNOTAS", "S")
            If valor = "S" Then
                citanote = True
            Else
                citanote = False
            End If

            valor = Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARESPECIALIDAD", "S")
            If valor = "S" Then
                citaesp = True
            Else
                citaesp = False
            End If

            valor = Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARCODIGOPROPIO", "S")
            If valor = "S" Then
                Me.citaCodPropioPac = True
            Else
                Me.citaCodPropioPac = False
            End If

            valor = Me.LeeConfiguracionDesdeXML("EDICION", "TAMANOFUENTE", "9")
            TamanoFuente = valor

            EnfocarCodigoPropioPaciente = Me.LeeConfiguracionDesdeXML("PACIENTE", "EnfocarCodigoPropioPaciente", True)

            CalendarioMostrarListaMedicosPorDefecto = Me.LeeConfiguracionDesdeXML("CITAS", "Calendario_MostrarListaMedicosPorDefecto", False)
            CalendarioTipoFiltro = Me.LeeConfiguracionDesdeXML("CITAS", "Calendario_TipoFiltro", "1")


            Dim configXml As XElement = _
        <configuracion>
            <Comunicacion>
                <Email>
                    <Address></Address>
                    <SMTPServer>server</SMTPServer>
                    <SMTPPort>25</SMTPPort>
                    <SMTPUser>user</SMTPUser>
                    <SMTPPassword>pass</SMTPPassword>
                    <SMTPUseSSL>true</SMTPUseSSL>
                    <SMTPVerificado>false</SMTPVerificado>
                </Email>
                <SMS>
                    <Server></Server>
                    <Usuario></Usuario>
                    <Password></Password>
                    <Remitente></Remitente>
                    <SMSVerificado>false</SMSVerificado>
                </SMS>
            </Comunicacion>
            <Citas>
                <CitaStyle><%= citastyle %></CitaStyle>

                <Calendario_TipoFiltro><%= CalendarioTipoFiltro %></Calendario_TipoFiltro>

                <CitaVisualNombrePaciente><%= citapac %></CitaVisualNombrePaciente>
                <CitaVisualMedico><%= citamed %></CitaVisualMedico>
                <CitaVisualNotas><%= citanote %></CitaVisualNotas>
                <CitaVisualEspecialidad><%= citaesp %></CitaVisualEspecialidad>
                <Calendario_MostrarListaMedicosPorDefecto><%= CalendarioMostrarListaMedicosPorDefecto %></Calendario_MostrarListaMedicosPorDefecto>
                <CitaCodPropioPac><%= citaCodPropioPac %></CitaCodPropioPac>
                <CitaFormatoNombre>1</CitaFormatoNombre>

            </Citas>
            <Historiales>
                <TamanoFuente><%= TamanoFuente %></TamanoFuente>
            </Historiales>
            <Medico>
                <SiUsuarioMedicoUsarPorDefecto>false</SiUsuarioMedicoUsarPorDefecto>
            </Medico>
        </configuracion>

            'Dim context As New CMLinqDataContext()

            Globales.Usuario.CONFIGURACIONXML = configXml
            Globales.Context.SubmitChanges()
        Else

            'Leer los valores del xml
            citastyle = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaStyle>.Value
            CalendarioTipoFiltro = Globales.Usuario.CONFIGURACIONXML.<Citas>.<Calendario_TipoFiltro>.Value
            citapac = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaVisualNombrePaciente>.Value
            citamed = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaVisualMedico>.Value
            citanote = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaVisualNotas>.Value
            citaesp = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaVisualEspecialidad>.Value
            CalendarioMostrarListaMedicosPorDefecto = Globales.Usuario.CONFIGURACIONXML.<Citas>.<Calendario_MostrarListaMedicosPorDefecto>.Value
            citaCodPropioPac = Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaCodPropioPac>.Value
            TamanoFuente = Globales.Usuario.CONFIGURACIONXML.<Historiales>.<TamanoFuente>.Value

            If Globales.Usuario.CONFIGURACIONXML.<Medico>.<SiUsuarioMedicoUsarPorDefecto>.Value Is Nothing Then
                Globales.Usuario.CONFIGURACIONXML.Add(<Medico><SiUsuarioMedicoUsarPorDefecto>False</SiUsuarioMedicoUsarPorDefecto></Medico>)
                Globales.Context.SubmitChanges()
            End If

            If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value Is Nothing Then
                Globales.Usuario.CONFIGURACIONXML.Add(<Citas><CitaFormatoNombre>1</CitaFormatoNombre></Citas>)
                Globales.Context.SubmitChanges()
            End If




        End If


    End Sub
#End Region

#Region "Public Sub Save(ByVal alogin As String)"
    Public Sub Save(ByVal alogin As String)
        Dim log As String = ""
        Try

            Me.LeeConfiguracionDesdeXML("PACIENTE", "EnfocarCodigoPropioPaciente", EnfocarCodigoPropioPaciente, False)


            Me.LeeConfiguracionDesdeXML("CITAS", "VISTA", citastyle, False)

            If citapac = True Then
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARPACIENTE", "S", False)
            Else
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARPACIENTE", "N", False)
            End If


            If citamed = True Then
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARMEDICO", "S", False)
            Else
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARMEDICO", "N", False)
            End If


            If citanote = True Then
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARNOTAS", "S", False)
            Else
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARNOTAS", "N", False)
            End If

            If citaesp = True Then
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARESPECIALIDAD", "S", False)
            Else
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARESPECIALIDAD", "N", False)
            End If

            If Me.citaCodPropioPac = True Then
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARCODIGOPROPIO", "S", False)
            Else
                Me.LeeConfiguracionDesdeXML("CITAS", "MOSTRARCODIGOPROPIO", "N", False)
            End If

            Me.LeeConfiguracionDesdeXML("EDICION", "TAMANOFUENTE", TamanoFuente, False)

            Me.LeeConfiguracionDesdeXML("CITAS", "Calendario_MostrarListaMedicosPorDefecto", CalendarioMostrarListaMedicosPorDefecto, False)

            Me.LeeConfiguracionDesdeXML("CITAS", "Calendario_TipoFiltro", CalendarioTipoFiltro.ToString(), False)

            'Cita_Medico_PorcientoGlobal


        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & "Error al guardar la configuración" & vbCrLf & log)
        End Try
    End Sub

#End Region

#Region "Public Function EsValidaConfiguracionFacturas_Recibos() as Boolean"
    Public Function EsValidaConfiguracionFacturas_Recibos() As Boolean
        'Ordenante
        If nombreord.Length > 40 Then
            MessageBox.Show("Longitud del nombre del ordenante excede los 40 caracteres")
            Return False
        End If
        If CIFord.Length > 9 Then
            MessageBox.Show("Longitud del CIF del Ordenante excede los 9 caracteres")
            Return False
        End If

        If sufijoord.Length > 3 Then
            MessageBox.Show("Longitud del sufijo del Ordenante excede los 3 caracteres")
            Return False
        Else
            If sufijoord.Trim() = "" Then
                MessageBox.Show("El sufijo del Ordenante ha de ser distinto de todo espacios")
                Return False
            End If
        End If

        If entidadord.Length > 4 Then
            MessageBox.Show("Longitud de la entidad del Ordenante excede los 4 caracteres")
            Return False
        End If

        If oficinaord.Length > 4 Then
            MessageBox.Show("Longitud de la oficina del Ordenante excede los 4 caracteres")
            Return False
        End If

        If DCord.Length > 2 Then
            MessageBox.Show("Longitud del DC del Ordenante excede los 2 caracteres")
            Return False
        End If

        If cuentaord.Length > 10 Then
            MessageBox.Show("Longitud de la cuenta del Ordenante excede los 10 caracteres")
            Return False
        End If

        'Presentador
        If nombrepres.Length > 40 Then
            MessageBox.Show("Longitud del nombre del Presentador excede los 40 caracteres")
            Return False
        End If

        If entidadpres.Length > 4 Then
            MessageBox.Show("Longitud de la entidad del Presentador excede los 4 caracteres")
            Return False
        End If

        If sufijopres.Length > 3 Then
            MessageBox.Show("Longitud del sufijo del Presentador excede los 3 caracteres")
            Return False
        Else
            If sufijopres.Trim() = "" Then
                MessageBox.Show("El sufijo del Presentador ha de ser distinto de todo espacios")
                Return False
            End If
        End If

        If CIFpres.Length > 9 Then
            MessageBox.Show("Longitud del CIF del Presentador excede los 9 caracteres")
            Return False
        End If

        If oficinapres.Length > 4 Then
            MessageBox.Show("Longitud de la oficina del Presentador excede los 4 caracteres")
            Return False
        End If
        Return True
    End Function
#End Region


End Class

