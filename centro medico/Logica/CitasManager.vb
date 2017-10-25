Imports System
Imports System.IO
Imports System.Net

Public Class CitasManager


    Public Shared Function ListadoCitasBasico(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of CITA)

        Dim citas As IQueryable(Of CITA)

        'Filtro las eliminadas
        citas = context.CITAs.Where(Function(o) o.Eliminado = False Or Not o.Eliminado.HasValue)

        'Incluir or no las con Importe 0
        If Not filtros.IncluirConImporteCero Then
            citas = citas.Where(Function(o) o.TOTAL > 0)
        End If

        'Filtrar por doc Pagados, no pagados o todos
        If filtros.StatusPago = StatusPago.Pagado Then
            citas = citas.Where(Function(o) o.PAGADA = "S")
        End If

        If filtros.StatusPago = StatusPago.NoPagado Then
            citas = citas.Where(Function(o) o.PAGADA = "N")
        End If

        ''Filtro de Hora Inicial Emision
        If filtros.HoraEmisionInicial.HasValue Then
            citas = citas.Where(Function(o) (o.HORA.Value.Hour * 60 + o.HORA.Value.Minute >= filtros.HoraEmisionInicial.Value.Hour * 60 + filtros.HoraEmisionInicial.Value.Minute))
        End If

        'Filtro de Hora Final Emision
        If filtros.HoraEmisionFinal.HasValue Then
            citas = citas.Where(Function(o) (o.HORA.Value.Hour * 60 + o.HORA.Value.Minute <= filtros.HoraEmisionFinal.Value.Hour * 60 + filtros.HoraEmisionFinal.Value.Minute))
        End If

        'Filtro de forma de Pago
        If Not filtros.FormaPago Is Nothing Then
            citas = citas.Where(Function(o) (o.REFFORMAPAGO = filtros.FormaPago))
        End If

        'Fecha Emision Inicial 
        If filtros.FechaEmisionInicial.HasValue Then
            citas = citas.Where(Function(o) o.FECHA >= filtros.FechaEmisionInicial)
        End If

        'Fecha Emision Final
        If filtros.FechaEmisionFinal.HasValue Then
            citas = citas.Where(Function(o) o.FECHA <= filtros.FechaEmisionFinal)
        End If

        'Fecha Pago Inicial 
        If filtros.FechaPagoInicial.HasValue Then
            citas = citas.Where(Function(o) o.FECHACOBRO >= filtros.FechaPagoInicial)
        End If

        'Fecha Pago Final
        If filtros.FechaPagoFinal.HasValue Then
            citas = citas.Where(Function(o) o.FECHACOBRO <= filtros.FechaPagoFinal)
        End If

        If filtros.CPACIENTE.HasValue Then
            citas = citas.Where(Function(o) o.REFPACIENTE = filtros.CPACIENTE)
        End If

        Return citas.OrderByDescending(Function(o) o.FECHA)

    End Function

    Public Shared Function ListadoCitasDebitoPaciente(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of CITA)
        Dim citas As IQueryable(Of CITA) = ListadoCitasBasico(context, filtros)
        citas = citas.Where(Function(c) c.REFPACIENTE = filtros.CPACIENTE)
        citas = citas.Where(Function(c) c.ATENDIDO = "S" And c.PAGADA = "N")
        Return citas
    End Function

    'PENDIENTE: Al borrar una cita (marcar como eliminada) desvincular sesión si la tuviera y registrar en auditoria

    Public Shared Function ListadoCitas(context As CMLinqDataContext, filtros As FiltroListadoCitas) As IQueryable(Of CITA)
        Dim citas As IQueryable(Of CITA) = ListadoCitasBasico(context, filtros)

        If Not String.IsNullOrEmpty(filtros.NOMBREPACIENTE) Then
            citas = citas.Where(Function(c) c.PACIENTE1.NOMBRE.StartsWith(filtros.NOMBREPACIENTE))
        End If

        If Not String.IsNullOrEmpty(filtros.APELLIDO1) Then
            citas = citas.Where(Function(c) c.PACIENTE1.APELLIDO1.StartsWith(filtros.APELLIDO1))
        End If

        If Not String.IsNullOrEmpty(filtros.APELLIDO2) Then
            citas = citas.Where(Function(c) c.PACIENTE1.APELLIDO2.StartsWith(filtros.APELLIDO2))
        End If

        Return citas
    End Function


    Public Shared Function ListadoCitasParaInformeGastos(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of CITA)

        Dim citas As IQueryable(Of CITA) = ListadoCitasBasico(context, filtros)

        'Si está pasado a factura, la cita no cuenta
        citas = citas.Where(Function(o) Not o.REFFRA.HasValue Or o.REFFRA = 0)

        citas = citas.Where(Function(o) (((o.ATENDIDO = "S" And o.PAGADA = "N") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.NoPagado)) Or _
                                          ((o.ATENDIDO = "S" And o.PAGADA = "S") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.Pagado)) Or _
                                          ((o.ATENDIDO = "N" And o.PAGADA = "S") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.Pagado))))

        citas = citas.Where(Function(o) o.PagadoConCredito = False)

        Return citas
    End Function


    Public Shared Function ListadoCitasPagadasConCreditoParaInformeGastos(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of CITA)

        Dim citas As IQueryable(Of CITA) = ListadoCitasBasico(context, filtros)

        'Si está pasado a factura, la cita no cuenta
        citas = citas.Where(Function(o) Not o.REFFRA.HasValue Or o.REFFRA = 0)

        citas = citas.Where(Function(o) (((o.ATENDIDO = "S" And o.PAGADA = "N") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.NoPagado)) Or _
                                          ((o.ATENDIDO = "S" And o.PAGADA = "S") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.Pagado)) Or _
                                          ((o.ATENDIDO = "N" And o.PAGADA = "S") And (filtros.StatusPago = StatusPago.Todos Or filtros.StatusPago = StatusPago.Pagado))))

        citas = citas.Where(Function(o) o.PagadoConCredito = True)

        Return citas
    End Function

End Class
Partial Class CITA
    Dim ldcontext As CMLinqDataContext = New CMLinqDataContext

    Public ReadOnly Property DrImporteConDtoSum As Double
        Get
            Dim res As Double = 0
            Dim lineas As List(Of LineasCita) = Me.LineasCitas.ToList
            For Each l As LineasCita In lineas
                If l.Liquidada_al_Medico Is Nothing Then res += l.DrImporteConDto
            Next
            Return res
        End Get
    End Property
    Public Shared Sub DesvincularSesion(ByRef context As CMLinqDataContext, ByVal cita As CITA)
        Dim sesion As Sesiones = (From a As Sesiones In context.Sesiones Where a.refcita = cita.IDCITA Select a).SingleOrDefault

        If Not sesion Is Nothing Then
            context.Sesiones.DeleteOnSubmit(sesion)
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Bonos, "Bonos/Sesiones", sesion.id, "Borrada sesión al eliminar la cita del " & cita.HORA & " del paciente " & cita.PACIENTE)
        End If
    End Sub

    Public ReadOnly Property BONOCITA As String
        Get
            Dim sesion As Sesiones = (From a As Sesiones In ldcontext.Sesiones Where a.refcita = Me.IDCITA Select a).SingleOrDefault
            Return ("Bono " & sesion.Bonos.Notas & " nº " & sesion.refbono).Trim()
        End Get
    End Property

    Public ReadOnly Property DESCRIPCIONPACIENTE As String
        Get
            Return ("[" & Me.REFPACIENTE & "] " & Me.PACIENTE).Trim()
        End Get
    End Property

#Region "funciones para sincronizar las citas con el FTP"

    Public Sub UpdateFileNewPassFtp(idMedico As Integer, NombDoc As String)
        Dim request As FtpWebRequest = FtpWebRequest.Create("ftp://home466817636.1and1-data.host/SincronizacionCitasXMedico/" + Globales.Configuracion.nombrecomercial + "/" + NombDoc)
        request.Credentials = New NetworkCredential("u73075875", "4815Inceme1623$")
        request.Method = WebRequestMethods.Ftp.ListDirectory
        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)

        Dim Lf As Char = Convert.ToChar(CByte(10))
        Dim Cr As Char = Convert.ToChar(CByte(13))
        Dim CrLf As Char() = {Cr, Lf}
        Dim lines() As String = reader.ReadToEnd().Split(CrLf, StringSplitOptions.RemoveEmptyEntries)
        reader.Close()
        response.Close()

        For Each line As String In lines
            Dim fecha As String = line.Remove(line.Length - 5)
            SincronizarMedicoCitas(fecha, idMedico)
        Next

    End Sub

    Public Sub SincronizarMedicoCitas(fecha As String, idmedico As Integer)
        Dim datos As String = ""
        Dim NombDoc As String = ""
        Dim medic As Integer = 0

        Dim seguridad As Seguridad = New Seguridad
        Dim usuario As USUARIO = New USUARIO

        Dim citas As List(Of CITA) = (From c In ldcontext.CITAs Select c _
                        Where c.FECHA = fecha And c.REFMEDICO = idmedico And c.FALTA = "N" _
                        Order By c.HORA Ascending).ToList()

        If citas.Count > 0 Then
            For i As Integer = 0 To citas.Count - 1
                Dim lineas As List(Of LineasCita) = (From l In ldcontext.LineasCitas Select l _
                        Where l.IdCita = citas.Item(i).IDCITA).ToList()

                If medic <> citas.Item(i).REFMEDICO Then
                    medic = citas.Item(i).REFMEDICO
                    NombDoc = citas.Item(i).MEDICO.NOMBRECOMPLETO
                    usuario = (From u In ldcontext.USUARIOs Select u Where u.REFMEDICO = medic).FirstOrDefault

                    datos = "{""Medico_" + medic.ToString + """: { ""IdMedico"": " + medic.ToString + ",""Usuario"": """ + usuario.USUARIO + """, ""Contraseña"": """ +
                        usuario.CONTRASENA + """, ""Nombre"": """ + citas.Item(i).MEDICO.NOMBRECOMPLETO + """}, ""Citas"": ["
                End If

                datos += "{""IdCita"": " + citas.Item(i).IDCITA.ToString + ", ""Fecha"": """ + citas.Item(i).FECHA.ToString + """, ""Hora"": """ + citas.Item(i).HORA.ToString +
                """, ""Nota"": """ + citas.Item(i).NOTAS + """, ""Paciente"": """ + citas.Item(i).PACIENTE1.NombreCompleto + """, ""Anulada"": """ + citas.Item(i).FALTA +
                """, ""Confirmada"": """ + citas.Item(i).CONFIRMADA + """, ""Atendida"", """ + citas.Item(i).ATENDIDO + """, ""Pagada"": """ + citas.Item(i).PAGADA + """"
                If lineas.Count > 0 Then
                    datos += ", ""Lineas"": ["
                    For j As Integer = 0 To lineas.Count - 1
                        datos += "{ ""Idlinea"": " + lineas.Item(j).IdLinea.ToString + ", ""Descripcion"": """ + lineas.Item(j).DESCRIPCION + """, ""Cantidad"": " +
                        lineas.Item(j).Cantidad.ToString + ", ""ImporteClinica"": " + lineas.Item(j).ImporteClinica.ToString + ", ""ImporteDoctor"": " + lineas.Item(j).ImporteDr.ToString + "}"
                        If j <> lineas.Count - 1 Then
                            datos += ","
                        Else
                            datos += "]}"
                        End If
                    Next
                End If
                If i < citas.Count - 1 Then
                    datos += ","
                Else
                    datos += "]}"
                End If
            Next

            If datos <> "" Then
                Dim datosenc As String = seguridad.EncryptData(datos, usuario.CONTRASENA)
                'CreaJson(datosenc, fecha, NombDoc)
                SaveFileFtp(datosenc, fecha, NombDoc)
            End If
        End If
    End Sub

    Public Sub SincronizarMedicoCitasXFecha(fecha As String)
        Dim datos As String = ""
        Dim NombDoc As String = ""
        Dim medic As Integer = 0
        Dim MedIdError As Integer = 0
        Dim seguridad As Seguridad = New Seguridad
        Dim usuario As USUARIO = New USUARIO

        Dim citas As List(Of CITA) = (From c In ldcontext.CITAs Select c _
                        Where c.FECHA = fecha And c.FALTA = "N" _
                        Order By c.REFMEDICO, c.HORA Ascending).ToList()
        If citas.Count > 0 Then

            For i As Integer = 0 To citas.Count - 1
                If MedIdError = citas.Item(i).REFMEDICO Then Continue For
                Dim lineas As List(Of LineasCita) = (From l In ldcontext.LineasCitas Select l _
                        Where l.IdCita = citas.Item(i).IDCITA).ToList()

                If medic <> citas.Item(i).REFMEDICO Then
                    medic = citas.Item(i).REFMEDICO
                    NombDoc = citas.Item(i).MEDICO.NOMBRECOMPLETO
                    usuario = (From u In ldcontext.USUARIOs Select u Where u.REFMEDICO = medic).FirstOrDefault
                    If usuario Is Nothing Then
                        MedIdError = medic
                        Continue For
                    End If
                    datos = "{""Medico_" + medic.ToString + """: { ""IdMedico"": " + medic.ToString + ",""Usuario"": """ + usuario.USUARIO + """, ""Contraseña"": """ +
                        usuario.CONTRASENA + """, ""Nombre"": """ + citas.Item(i).MEDICO.NOMBRECOMPLETO + """}, ""Citas"": ["
                End If
                datos += "{""IdCita"": " + citas.Item(i).IDCITA.ToString + ", ""Fecha"": """ + citas.Item(i).FECHA.ToString + """, ""Hora"": """ + citas.Item(i).HORA.ToString +
                    """, ""Nota"": """ + citas.Item(i).NOTAS + """, ""Paciente"": """ + citas.Item(i).PACIENTE1.NombreCompleto + """, ""Anulada"": """ + citas.Item(i).FALTA +
                    """, ""Confirmada"": """ + citas.Item(i).CONFIRMADA + """, ""Atendida"", """ + citas.Item(i).ATENDIDO + """, ""Pagada"": """ + citas.Item(i).PAGADA + """"
                If lineas.Count > 0 Then
                    datos += ", ""Lineas"": ["
                    For j As Integer = 0 To lineas.Count - 1
                        datos += "{ ""Idlinea"": " + lineas.Item(j).IdLinea.ToString + ", ""Descripcion"": """ + lineas.Item(j).DESCRIPCION + """, ""Cantidad"": " +
                        lineas.Item(j).Cantidad.ToString + ", ""ImporteClinica"": " + lineas.Item(j).ImporteClinica.ToString + ", ""ImporteDoctor"": " + lineas.Item(j).ImporteDr.ToString + "}"
                        If j <> lineas.Count - 1 Then
                            datos += ","
                        Else
                            datos += "]}"
                        End If
                    Next
                End If
                If i < citas.Count - 1 And medic = citas.Item(i + 1).REFMEDICO Then
                    datos += ","
                Else
                    datos += "]}"
                    CreaJson(datos, fecha, NombDoc)
                    Dim datosenc As String = seguridad.EncryptData(datos, usuario.CONTRASENA)
                    CreaJson(datosenc, "encritado", NombDoc)
                    Dim datosdecenc As String = seguridad.DecryptString(datosenc, usuario.CONTRASENA)
                    CreaJson(datosdecenc, "decencritado", NombDoc)
                    datos = ""
                End If
            Next
        End If
    End Sub

    Private Sub CreaJson(datos As String, fecha As String, NombDoc As String)
        Dim Path As String = "c:\SincronizacionCitasXMedico\" + Globales.Configuracion.nombrecomercial + "\" + NombDoc
        Directory.CreateDirectory(Path)
        Dim ruta As String = Path + "\" + fecha + ".json"
        Dim escritor As StreamWriter
        escritor = New StreamWriter(ruta)
        escritor.Write(datos)
        escritor.Flush()
        escritor.Close()
    End Sub



    Private Sub SaveFileFtp(datos As String, fecha As String, NombDoc As String)
        Dim fullpath As String = CreateFolderFtp(NombDoc)
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(fullpath + "/" + fecha + ".json"), FtpWebRequest)
        request.Credentials = New NetworkCredential("u73075875", "4815Inceme1623$")
        request.EnableSsl = True
        request.Method = WebRequestMethods.Ftp.UploadFile


        'Comment next line to activate secure certificate validation
        'https://stackoverflow.com/questions/20510316/ssl-certificate-issue-the-remote-certificate-is-invalid-according-to-the-valid
        'https://stackoverflow.com/questions/19327840/certificate-validation-installation-for-ftps-ssl
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        'Dim file() As Byte = System.IO.File.ReadAllBytes("c:\SincronizacionCitasXMedico\" + Globales.Configuracion.nombrecomercial + "\" + NombDoc + "\" + fecha + ".json")

        Dim encoding As System.Text.ASCIIEncoding = New System.Text.ASCIIEncoding()
        Dim bytes() As Byte = encoding.GetBytes(datos)

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(bytes, 0, bytes.Length)
        strz.Close()
        strz.Dispose()
    End Sub

    Private Function CreateFolderFtp(NombDoc As String) As String
        Dim fullpath As String = "ftp://home466817636.1and1-data.host"
        Dim folderNames(2) As String
        folderNames = New String(2) {"SincronizacionCitasXMedico", Globales.Configuracion.nombrecomercial, NombDoc}

        For Each folderName As String In folderNames
            fullpath += "/" + folderName

            If GetDirectoryExists(fullpath) Then Continue For

            Dim request As FtpWebRequest = FtpWebRequest.Create(fullpath)
            request.Credentials = New NetworkCredential("u73075875", "4815Inceme1623$")
            request.UsePassive = True
            request.UseBinary = True

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            Try
                Using response As FtpWebResponse = request.GetResponse()
                    ' Folder created
                End Using
            Catch ex As WebException
                Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
                ' an error occurred
            End Try
        Next
        Return fullpath
    End Function

    Private Function GetDirectoryExists(directoryName As String) As Boolean
        Dim directoryExists As Boolean
        Dim request As FtpWebRequest = FtpWebRequest.Create(directoryName)
        request.Credentials = New NetworkCredential("u73075875", "4815Inceme1623$")
        request.Method = WebRequestMethods.Ftp.ListDirectory
        Try
            Using response As FtpWebResponse = request.GetResponse()
                directoryExists = True
            End Using
        Catch ex As WebException
            directoryExists = False
            ' an error occurred
        End Try
        Return directoryExists
    End Function

    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

#End Region

End Class

Partial Class LineasCita
    Public ReadOnly Property DtoImporte As Double
        Get
            Dim res As Double = 0
            If Me.DescuentoPercent.HasValue AndAlso Me.DescuentoPercent > 0 Then
                res = (Me.ImporteClinica + Me.ImporteDr) * (Me.DescuentoPercent / 100)
            End If
            Return res
        End Get
    End Property
    Public ReadOnly Property DrImporteConDto As Double
        Get
            Dim res As Double = Me.ImporteDr * Me.Cantidad
            If Me.DescuentoPercent.HasValue AndAlso Me.DescuentoPercent > 0 Then
                res = (Me.ImporteDr - (Me.ImporteDr) * (Me.DescuentoPercent / 100))
            End If
            Return res
        End Get
    End Property


End Class
