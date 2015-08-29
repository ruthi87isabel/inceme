Imports System.Xml.Linq
Imports System.Xml.Linq.XElement


Public Class recetaXML

#Region "Propiedades"
    Public Structure Receta
        Public Numero As String
        Public CVE As String
    End Structure

    Public listaRecetas As New List(Of Receta)

    Private _NombreMedico As String
    Public Property NombreMedico() As String
        Get
            Return _NombreMedico
        End Get
        Set(ByVal value As String)
            _NombreMedico = value
        End Set
    End Property

    Private _NColegiado As String
    Public Property NColegiado() As String
        Get
            Return _NColegiado
        End Get
        Set(ByVal value As String)
            _NColegiado = value
        End Set
    End Property

    Private _Especialidad As String
    Public Property Especialidad() As String
        Get
            Return _Especialidad
        End Get
        Set(ByVal value As String)
            _Especialidad = value
        End Set
    End Property

    Private _NumeroLote As Integer
    Public Property NumeroLote() As Integer
        Get
            Return _NumeroLote
        End Get
        Set(ByVal value As Integer)
            _NumeroLote = value
        End Set
    End Property

    Private _DocumentoIdentificacionTipo As String
    Public Property DocumentoIdentificacionTipo() As String
        Get
            Return _DocumentoIdentificacionTipo
        End Get
        Set(ByVal value As String)
            _DocumentoIdentificacionTipo = value
        End Set
    End Property

    Private _DocumentoIdentificacion As String
    Public Property DocumentoIdentificacion() As String
        Get
            Return _DocumentoIdentificacion
        End Get
        Set(ByVal value As String)
            _DocumentoIdentificacion = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Apellido1 As String
    Public Property Apellido1() As String
        Get
            Return _Apellido1
        End Get
        Set(ByVal value As String)
            _Apellido1 = value
        End Set
    End Property

    Private _Apellido2 As String
    Public Property Apellido2() As String
        Get
            Return _Apellido2
        End Get
        Set(ByVal value As String)
            _Apellido2 = value
        End Set
    End Property

    Private _NumeroColegiado As String
    Public Property NumeroColegiado() As String
        Get
            Return _NumeroColegiado
        End Get
        Set(ByVal value As String)
            _NumeroColegiado = value
        End Set
    End Property

    Private _NombreEspecialidad As String
    Public Property NombreEspecialidad() As String
        Get
            Return _NombreEspecialidad
        End Get
        Set(ByVal value As String)
            _NombreEspecialidad = value
        End Set
    End Property

    Private _IdEspecialidad As String
    Public Property IdEspecialidad() As String
        Get
            Return _IdEspecialidad
        End Get
        Set(ByVal value As String)
            _IdEspecialidad = value
        End Set
    End Property

    Private _DireccionPostal As String
    Public Property DireccionPostal() As String
        Get
            Return _DireccionPostal
        End Get
        Set(ByVal value As String)
            _DireccionPostal = value
        End Set
    End Property

    Private _CodigoPostal As String
    Public Property CodigoPostal() As String
        Get
            Return _CodigoPostal
        End Get
        Set(ByVal value As String)
            _CodigoPostal = value
        End Set
    End Property

    Private _Municipio As String
    Public Property Municipio() As String
        Get
            Return _Municipio
        End Get
        Set(ByVal value As String)
            _Municipio = value
        End Set
    End Property

    Private _Pais As String
    Public Property Pais() As String
        Get
            Return _Pais
        End Get
        Set(ByVal value As String)
            _Pais = value
        End Set
    End Property


    Private _Provincia As String
    Public Property Provincia() As String
        Get
            Return _Provincia
        End Get
        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property

    Private _TipoVia As String
    Public Property TipoVia() As String
        Get
            Return _TipoVia
        End Get
        Set(ByVal value As String)
            _TipoVia = value
        End Set
    End Property

    Private _IdColegio As String
    Public Property IdColegio() As String
        Get
            Return _IdColegio
        End Get
        Set(ByVal value As String)
            _IdColegio = value
        End Set
    End Property

    Private _CentroTrabajo As String
    Public Property CentroTrabajo() As String
        Get
            Return _CentroTrabajo
        End Get
        Set(ByVal value As String)
            _CentroTrabajo = value
        End Set
    End Property

    Private _CIF As String
    Public Property CIF() As String
        Get
            Return _CIF
        End Get
        Set(ByVal value As String)
            _CIF = value
        End Set
    End Property

    Private _EmpleoPrincipal As Boolean
    Public Property EmpleoPrincipal() As Boolean
        Get
            Return _EmpleoPrincipal
        End Get
        Set(ByVal value As Boolean)
            _EmpleoPrincipal = value
        End Set
    End Property

    Private _Sexo As String
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Private _Idioma As Integer
    Public Property Idioma() As Integer
        Get
            Return _Idioma
        End Get
        Set(ByVal value As Integer)
            _Idioma = value
        End Set
    End Property

#End Region

    Public Function recetaDisponible(ByVal codigomedico As Integer, ByVal idreceta As Integer) As Boolean
        Try
            Dim db As New CMLinqDataContext
            Dim receta As RecetasXML
            receta = (From a In db.RecetasXML Select a Where a.idmedico = codigomedico And a.idReceta Is Nothing OrElse a.idReceta.ToString.Trim.Length = 0 Order By a.numero Ascending).First
            If Not receta Is Nothing Then
                receta.idReceta = idreceta

                db.SubmitChanges()
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function recetaDisponible(ByRef rec As centro_medico.RECETA, ByRef cont As CMLinqDataContext, ByVal idmedico As Integer) As Boolean
        Try
            Dim rxml As RecetasXML
            rxml = (From a In cont.RecetasXML Select a Where a.idmedico = idmedico And a.idReceta Is Nothing OrElse a.idReceta.ToString.Trim.Length = 0 Order By a.numero Ascending).FirstOrDefault

            rec.RecetasXML.Add(rxml)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function




    Public Function recetasLibresPorMedico(ByVal codigomedico As Integer) As Integer
        Dim db As New CMLinqDataContext

        Dim numRecetas As Integer = (From n In db.RecetasXML Select n Where n.idmedico = codigomedico And n.idReceta Is Nothing OrElse n.idReceta.ToString.Trim.Length = 0).Count

        Return numRecetas
    End Function

    Public Function leeXML(ByRef path As String, ByRef codigomedico As Integer, ByRef numColegiado As String) As Boolean

        Try
            Dim context As New CMLinqDataContext


            Dim pre As String = "{urn:cgcom.es:vuds.1.0}"
            Dim a As XDocument = XDocument.Load(path)
            Dim obj As IEnumerable(Of XElement) = From it In a.Elements(pre & "ConjuntoRecetas") Select it
            Dim colegiado As IEnumerable(Of XElement) = From col In obj.Elements(pre & "Colegiado") Select col
            Dim especialidad As IEnumerable(Of XElement) = From esp In colegiado.Elements(pre & "Especialidad") Select esp
            Dim direccionOcup As IEnumerable(Of XElement) = From dirOc In colegiado.Elements(pre & "DireccionOcupacion") Select dirOc
            Dim recetas As IEnumerable(Of XElement) = From rec In obj.Elements(pre & "Receta") Select rec

            NumeroLote = obj.Elements(pre & "NumeroLote").Value

            'Hay que comprobar si el lote ya existe
            Dim countLote As Integer = (From l In context.RecetasXML Where l.numeroLote = NumeroLote Select l).Count
            If countLote > 0 Then
                MsgBox("El lote " & NumeroLote & " ya está en la base de datos y no puede volver a importarse", MsgBoxStyle.Exclamation)
                Exit Function
            End If
            'fin comprobación lote

            Idioma = obj.Elements(pre & "Idioma").Value
            NumeroColegiado = colegiado.Elements(pre & "NumeroColegiado").Value

            'compruebo también si el numero de colegiado del médico coincide con el de las recetas
            If NumeroColegiado.Trim <> numColegiado Then
                MsgBox("Está importando recetas que difieren del numero de colegiado del médico seleccionado, " & _
                       "por favor corrija ese dato en la ficha del médico o seleccione el correcto. El n. de colegiado de las recetas xml es " & NumeroColegiado & _
                       " mientras que el definido en la ficha del médico es " & numColegiado & ".", MsgBoxStyle.Exclamation)
                Return False
            End If
            'fin comprobación num colegiado

            DocumentoIdentificacionTipo = colegiado.Elements(pre & "DocumentoIdentificacionTipo").Value
            DocumentoIdentificacion = colegiado.Elements(pre & "DocumentoIdentificacion").Value
            Nombre = colegiado.Elements(pre & "Nombre").Value
            Apellido1 = colegiado.Elements(pre & "Apellido1").Value
            Apellido2 = colegiado.Elements(pre & "Apellido2").Value

            IdColegio = colegiado.Elements(pre & "IdColegio").Value
            CentroTrabajo = colegiado.Elements(pre & "CentroTrabajo").Value
            CIF = colegiado.Elements(pre & "CIF").Value
            EmpleoPrincipal = colegiado.Elements(pre & "EmpleoPrincipal").Value
            Sexo = colegiado.Elements(pre & "Sexo").Value

            NombreEspecialidad = especialidad.Elements(pre & "NombreEspecialidad").Value
            IdEspecialidad = especialidad.Elements(pre & "IdEspecialidad").Value

            CodigoPostal = direccionOcup.Elements(pre & "CodigoPostal").Value
            DireccionPostal = direccionOcup.Elements(pre & "DireccionPostal").Value
            Municipio = direccionOcup.Elements(pre & "Municipio").Value
            Pais = direccionOcup.Elements(pre & "Pais").Value
            Provincia = direccionOcup.Elements(pre & "Provincia").Value
            TipoVia = direccionOcup.Elements(pre & "TipoVia").Value

            For Each r As XElement In recetas
                Dim nreceta As New Receta
                nreceta.Numero = r.Elements(pre & "Numero").Value
                nreceta.CVE = r.Elements(pre & "CVE").Value
                listaRecetas.Add(nreceta)
                'Console.WriteLine(r.Elements(pre & "Numero").Value & vbTab & r.Elements(pre & "CVE").Value)
            Next
            Dim tmpres As Boolean = GuardaEnBd(codigomedico)
            Return tmpres
            'Console.Read()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Se ha producido un error al leer el fichero. Puede que el fichero no sea correcto.")
        End Try

    End Function

    Private Function GuardaEnBd(ByRef codigoMedicoInceme) As Boolean


        'Cuando inserte cada receta comprobar que el numero no existe

        Dim context As New CMLinqDataContext
        Dim rec As RecetasXML



        Try
            For Each r As Receta In listaRecetas
                rec = New RecetasXML
                'id del doctor en inceme
                rec.idmedico = codigoMedicoInceme

                'campos de la receta en xml
                rec.nombre = Nombre
                rec.apellido1 = Apellido1
                rec.apellido2 = Apellido2
                rec.numeroLote = NumeroLote
                rec.idioma = rec.idioma
                rec.documentoIdentificacionTipo = DocumentoIdentificacionTipo
                rec.documentoIdentificacion = DocumentoIdentificacion
                rec.numeroColegiado = NumeroColegiado
                rec.idColegio = IdColegio
                rec.centroTrabajo = CentroTrabajo
                rec.cif = CIF
                rec.empleoPrincipal = EmpleoPrincipal
                rec.sexo = Sexo
                rec.nombreEspecialidad = NombreEspecialidad
                rec.idEspecialidad = IdEspecialidad
                rec.codigoPostal = CodigoPostal
                rec.direccionPostal = DireccionPostal
                rec.municipio = Municipio
                rec.pais = Pais
                rec.provincia = Provincia
                rec.tipoVia = TipoVia
                rec.CVE = r.CVE
                rec.numero = r.Numero
                context.RecetasXML.InsertOnSubmit(rec)
            Next
            context.SubmitChanges()
            MsgBox("Importación realizada correctamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al importar recetas en xml")
            Return False
        End Try

    End Function

    Public Sub DesvinculaReceta(ByVal idreceta As Integer)
        Dim db As New CMLinqDataContext
        Dim receta As RecetasXML
        receta = (From a In db.RecetasXML Select a Where a.idReceta = idreceta).FirstOrDefault
        receta.idReceta = Nothing
        db.SubmitChanges()

    End Sub
End Class

