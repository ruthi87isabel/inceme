Imports System.Transactions
Public Class pacienteFiltro
    Public nombre As String
    Public apellido1 As String
    Public apellido2 As String
End Class

Public Class PacienteManager

    Dim context As New CMLinqDataContext

    Public Function listadoPacientes(ByVal f As pacienteFiltro, ByVal nregistros As Integer?) As List(Of PACIENTE)
        Dim listpac As IQueryable(Of PACIENTE)
        If Not nregistros Is Nothing AndAlso IsNumeric(nregistros) Then
            listpac = context.PACIENTEs.Take(nregistros).Where(Function(o) o.Eliminado = False Or Not o.Eliminado.HasValue)
        Else
            listpac = context.PACIENTEs.Where(Function(o) o.Eliminado = False Or Not o.Eliminado.HasValue)
        End If

        If (Not f.nombre Is Nothing AndAlso f.nombre.Trim.Length > 0) Then
            listpac = filtraNombre(f.nombre, listpac)
        End If

        Return listpac.ToList
    End Function

    Private Function filtraNombre(ByVal nombre As String, ByRef listpac As IQueryable(Of PACIENTE)) As IQueryable(Of PACIENTE)
        listpac = context.PACIENTEs.Where(Function(o) o.NOMBRE.Contains(nombre))
        Return listpac
    End Function

    ''' Utilidad para migrar datos de un paciente a otro
    ''' Script de ejemplo:
    ''' update ANALITICAS set REFPACIENTE=104380 where REFPACIENTE=104422
    ''' update AntecedentesDiagnosticos set CPACIENTE=104380 where CPACIENTE=104422
    ''' update Asociados set IDPacienteOrigen=104380 where IDPacienteOrigen=104422
    ''' update Asociados set IDPacienteBeneficiario=104380 where IDPacienteBeneficiario=104422
    ''' update audiometrias set REFPACIENTE=104380 where refpaciente=104422
    ''' update bonos set cpaciente=104380 where cpaciente=104422
    ''' update comparativas set REFPACIENTE=104380 where refpaciente=104422
    ''' update Comunicaciones set ID_PACIENTEDESTINO=104380 where ID_PacienteDestino=104422
    ''' update d_Odontogramas set IDPaciente=104380 where IDPaciente=104422
    ''' update derivaciones set REFPACIENTE=104380 where refpaciente=104422
    ''' update EntregasCuenta set IDPaciente=104380 where IDPaciente=104422
    ''' update ficheros set REFPACIENTE=104380 where refpaciente=104422
    ''' update HISTORIALES set REFPACIENTE=104380 where refpaciente=104422
    ''' update HISTORIALES_REVISIONES set REFPACIENTE=104380 where refpaciente=104422
    ''' update informacionprimaria set REFPACIENTE=104380 where refpaciente=104422
    ''' update informe_medico set REFPACIENTE=104380 where refpaciente=104422
    ''' update lempresas set REFPACIENTE=104380 where refpaciente=104422
    ''' update lmutuas set REFPACIENTE=104380 where refpaciente=104422
    ''' update N_Factura set ID_Cliente=104380 where ID_Cliente=104422
    ''' update N_Partes_Asistencia set ID_Paciente=104380 where ID_Paciente=104422
    ''' update N_Procesos set ID_Paciente=104380 where ID_Paciente=104422
    ''' update N_ticket set ID_Cliente=104380 where ID_Cliente=104422
    ''' update PagosPaciente set IDPaciente=104380 where IDPaciente=104422
    ''' update RECIBOS set REFPACIENTE=104380 where refpaciente=104422
    ''' update facturas set REFPACIENTE=104380 where refpaciente=104422
    ''' update historiales set REFPACIENTE=104380 where refpaciente=104422
    ''' update imagenes set REFPACIENTE=104380 where refpaciente=104422
    ''' update lineasalarma set REFPACIENTE=104380 where refpaciente=104422
    ''' update PRESUPUESTOS set REFPACIENTE=104380 where refpaciente=104422
    ''' update recetas set REFPACIENTE=104380 where refpaciente=104422
    Shared Function migrarPaciente(ByVal PacienteOrigen As Integer, ByVal PacienteDestino As Integer, ByVal bajaPaciente As Boolean)
        Dim res As Boolean = True
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.MigrarPacientes) <> RoleManager.TipoPermisos.Total Then
            Throw New System.Exception("No dispone de permisos para acceder a este módulo.")
            Return False
        End If
        Try
            Using ts As New TransactionScope
                Dim ctx As New CMLinqDataContext
                Dim log As String = "Registro migración de paciente " & PacienteOrigen & " a " & PacienteDestino & Now.ToString & vbCrLf
                Dim filename As String = Application.StartupPath & "\migracion-" & Now.Ticks.ToString & "-De-" & PacienteOrigen & "-A-" & PacienteDestino & ".txt"


                'Analíticas
                Dim analiticas As IList(Of ANALITICAS) = (From a In ctx.ANALITICAS Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As ANALITICAS In analiticas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'AntecedentesDiagnosticos
                Dim antecedentes As IList(Of AntecedentesDiagnostico) = (From a In ctx.AntecedentesDiagnosticos Where a.CPACIENTE = PacienteOrigen Select a).ToList
                For Each a As AntecedentesDiagnostico In antecedentes
                    a.CPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'Asociados1
                Dim asociados1 As IList(Of Asociado) = (From a In ctx.Asociados Where a.IDPacienteOrigen = PacienteOrigen Select a).ToList
                Dim asoc As Asociado
                For Each a As Asociado In asociados1
                    'al ser una clave formada por dos campos es necesario elimnarla y crearla de nuevo
                    asoc = New Asociado
                    asoc.IDPacienteOrigen = PacienteDestino
                    asoc.IDPacienteBeneficiario = a.IDPacienteBeneficiario
                    asoc.IDParentesco = a.IDParentesco
                    ctx.Asociados.DeleteOnSubmit(a)
                    ctx.Asociados.InsertOnSubmit(asoc)

                    log += vbCrLf & a.ToString & "(cambio pacienteOrigen) de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'Asociados2
                Dim asociados2 As IList(Of Asociado) = (From a In ctx.Asociados Where a.IDPacienteBeneficiario = PacienteOrigen Select a).ToList
                Dim asoc2 As Asociado
                For Each a As Asociado In asociados2
                    'al ser una clave formada por dos campos es necesario elimnarla y crearla de nuevo
                    asoc2 = New Asociado
                    asoc2.IDPacienteOrigen = a.IDPacienteOrigen
                    asoc2.IDPacienteBeneficiario = PacienteDestino
                    asoc2.IDParentesco = a.IDParentesco
                    ctx.Asociados.DeleteOnSubmit(a)
                    ctx.Asociados.InsertOnSubmit(asoc2)
                    log += vbCrLf & a.ToString & "(cambio pacienteBeneficiario) de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'Audiometrias
                Dim audiometrias As IList(Of AUDIOMETRIAS) = (From a In ctx.AUDIOMETRIAS Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As AUDIOMETRIAS In audiometrias
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'Bonos
                Dim bonos As IList(Of Bonos) = (From a In ctx.Bonos Where a.cpaciente = PacienteOrigen Select a).ToList
                For Each a As Bonos In bonos
                    a.cpaciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'comparativas
                Dim comparativas As IList(Of COMPARATIVA) = (From a In ctx.COMPARATIVAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As COMPARATIVA In comparativas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'comunicaciones
                Dim comunicaciones As IList(Of Comunicacion) = (From a In ctx.Comunicacions Where a.ID_PacienteDestino = PacienteOrigen Select a).ToList
                For Each a As Comunicacion In comunicaciones
                    a.ID_PacienteDestino = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'd_Odontogramas
                Dim odontograma As IList(Of d_Odontograma) = (From a In ctx.d_Odontogramas Where a.IDPaciente = PacienteOrigen Select a).ToList
                For Each a As d_Odontograma In odontograma
                    a.IDPaciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'derivaciones
                Dim derivaciones As IList(Of DERIVACIONES) = (From a In ctx.DERIVACIONES Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As DERIVACIONES In derivaciones
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'EntregasCuenta
                Dim EntregasCuenta As IList(Of EntregasCuenta) = (From a In ctx.EntregasCuentas Where a.IDPaciente = PacienteOrigen Select a).ToList
                For Each a As EntregasCuenta In EntregasCuenta
                    a.IDPaciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'ficheros
                Dim ficheros As IList(Of FICHERO) = (From a In ctx.FICHEROs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As FICHERO In ficheros
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'HISTORIALES
                Dim HISTORIALES As IList(Of HISTORIALE) = (From a In ctx.HISTORIALEs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As HISTORIALE In HISTORIALES
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'HISTORIALES_REVISIONES
                Dim HISTORIALES_REVISIONES As IList(Of HISTORIALES_REVISIONES) = (From a In ctx.HISTORIALES_REVISIONES Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As HISTORIALES_REVISIONES In HISTORIALES_REVISIONES
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'informacion primaria
                Dim infoprimaria As IList(Of INFORMACIONPRIMARIA) = (From a In ctx.INFORMACIONPRIMARIAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As INFORMACIONPRIMARIA In infoprimaria
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'informe medico
                Dim informemedico As IList(Of INFORME_MEDICO) = (From a In ctx.INFORME_MEDICOs Where a.RefPaciente = PacienteOrigen Select a).ToList
                For Each a As INFORME_MEDICO In informemedico
                    a.RefPaciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'lempresas
                Dim lempresas As IList(Of LEMPRESA) = (From a In ctx.LEMPRESAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As LEMPRESA In lempresas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next
                'lmutuas
                Dim lmutuas As IList(Of LMUTUA) = (From a In ctx.LMUTUAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As LMUTUA In lmutuas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' n_factura
                Dim nfactura As IList(Of N_Factura) = (From a In ctx.N_Facturas Where a.ID_Cliente = PacienteOrigen Select a).ToList
                For Each a As N_Factura In nfactura
                    a.ID_Cliente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' n_partes
                Dim npartes As IList(Of N_Parte) = (From a In ctx.N_Partes Where a.ID_Paciente = PacienteOrigen Select a).ToList
                For Each a As N_Parte In npartes
                    a.ID_Paciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' n_procesos
                Dim nprocesos As IList(Of N_Proceso) = (From a In ctx.N_Procesos Where a.ID_Paciente = PacienteOrigen Select a).ToList
                For Each a As N_Proceso In nprocesos
                    a.ID_Paciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' n_ticket
                Dim nticket As IList(Of N_Ticket) = (From a In ctx.N_Tickets Where a.ID_Cliente = PacienteOrigen Select a).ToList
                For Each a As N_Ticket In nticket
                    a.ID_Cliente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' pagospaciente
                Dim pagospaciente As IList(Of PagosPaciente) = (From a In ctx.PagosPacientes Where a.IDPaciente = PacienteOrigen Select a).ToList
                For Each a As PagosPaciente In pagospaciente
                    a.IDPaciente = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' recibos
                Dim recibos As IList(Of RECIBO) = (From a In ctx.RECIBOs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As RECIBO In recibos
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' facturas
                Dim facturas As IList(Of FACTURA) = (From a In ctx.FACTURAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As FACTURA In facturas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' imagenes
                Dim imagenes As IList(Of IMAGENES) = (From a In ctx.IMAGENES Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As IMAGENES In imagenes
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' lineasalarma
                Dim lineasalarma As IList(Of LINEASALARMA) = (From a In ctx.LINEASALARMAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As LINEASALARMA In lineasalarma
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' Presupuestos
                Dim presupuestos As IList(Of PRESUPUESTOS) = (From a In ctx.PRESUPUESTOS Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As PRESUPUESTOS In presupuestos
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' Recetas
                Dim recetas As IList(Of RECETA) = (From a In ctx.RECETAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As RECETA In recetas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' Citas
                Dim citas As IList(Of CITA) = (From a In ctx.CITAs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As CITA In citas
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                ' ConceptosFacturables
                Dim conceptosFacturables As IList(Of CONCEPTOSFACTURABLE) = (From a In ctx.CONCEPTOSFACTURABLEs Where a.REFPACIENTE = PacienteOrigen Select a).ToList
                For Each a As CONCEPTOSFACTURABLE In conceptosFacturables
                    a.REFPACIENTE = PacienteDestino
                    log += vbCrLf & a.ToString & "de paciente: " & PacienteOrigen & " a paciente: " & PacienteDestino
                Next

                

                'COMMIT DE LOS CAMBIOS.
                ctx.SubmitChanges()
                Dim sw As New System.IO.StreamWriter(filename)
                sw.WriteLine(log)
                sw.Close()
                ts.Complete()

            End Using

            If bajaPaciente Then
                'Si llega aquí es porque se ha completado la transacción. Ahora vamos a intentar eliminar el paciente en caso que
                'se haya marcado esa opción. Se saca fuera de la transacción porque daba probleamas
                Dim contex As New CMLinqDataContext
                Dim POrigen As PACIENTE = (From x In contex.PACIENTEs Where x.CPACIENTE = PacienteOrigen Select x).SingleOrDefault
                If bajaPaciente = True Then
                    POrigen.Eliminado = bajaPaciente
                End If
                contex.SubmitChanges()
            End If
        Catch ex As TransactionAbortedException
            res = False
            Globales.ErrorMsg(ex, "TransactionAbortedException")
        Catch ex As ApplicationException
            res = False
            Globales.ErrorMsg(ex, "ApplicationException")
        Catch ex As Exception
            res = False
            Globales.ErrorMsg(ex, "Error al migrar los datos del paciente " & PacienteOrigen & " al paciente " & PacienteDestino)

        End Try

        ' si va todo bien devolvemos true, si no hacemos un rollup y devolvemos false.
        Return res

    End Function
End Class

Partial Class PACIENTE

    Public ReadOnly Property DniConLetra() As String
        Get
            Dim dniletra As String = ""
            If Not (Me.DNI Is Nothing AndAlso Me.DNI.Trim.Length = 0) Then
                dniletra = Me.DNI & Globales.GetLetter(Me.DNI)
            Else
                dniletra = Me.DNI
            End If
            Return dniletra
        End Get
       
    End Property

    Public ReadOnly Property TieneDocumentoConsentimiento() As Boolean
        Get
            Dim f As Integer = 0
            f = Me.FICHEROs.Where(Function(o) o.ESCONSENTIMIENTO = True).Count()
            If f > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    'Dim _socioantes As Char
    'Public Property SocioAntes() As Char
    '    Get
    '        Return _socioantes
    '    End Get
    '    Set(value As Char)
    '        _socioantes = value
    '    End Set
    'End Property

    ''' <summary>
    ''' Propiedad virtual de solo lectura que realiza las operaciones para devolver si en el día actual la membresia 
    ''' del socio sigue o no activa
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SocioActivo() As Boolean?
        Get
            Dim hoy As Date = Now
            If Me.SOCIO = "S"c And Not Me.SOCIOVALIDOHASTA Is Nothing Then
                If Now < Me.SOCIOVALIDOHASTA Then
                    Return True
                Else
                    Return False
                End If
            End If
            If Me.BENEFICIARIOCODIGOSOCIO > 0 Then
                Dim cn As New CMLinqDataContext
                Dim pacAsociado As PACIENTE = (From m In cn.PACIENTEs Where m.CPACIENTE = Me.BENEFICIARIOCODIGOSOCIO).SingleOrDefault
                If Not pacAsociado Is Nothing AndAlso Not pacAsociado.SOCIOVALIDOHASTA Is Nothing Then
                    If Now < pacAsociado.SOCIOVALIDOHASTA Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property TieneBonosNoAgotados As Boolean
        Get
            Dim bonos As IEnumerable(Of Bonos)
            bonos = Me.Bonos.Where(Function(b) b.sesionesLibres > 0)
            Return bonos.Count > 0
        End Get
    End Property

    Public ReadOnly Property TotalBonos As Integer
        Get
            Dim f As Integer = 0
            f = Me.Bonos.Where(Function(b) b.numsesiones > 0).Count()
            Return f
        End Get
    End Property

    Public ReadOnly Property SesionesLibres As Integer
        Get
            Dim f As Integer = 0
            Dim bonosList As IEnumerable(Of Bonos)
            bonosList = Me.Bonos.Where(Function(b) b.numsesiones > 0)
            If bonosList.Any() Then
                f = bonosList.Sum(Function(b) b.sesionesLibres)
            End If
            Return f
        End Get
    End Property

    
End Class
