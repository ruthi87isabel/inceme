Imports System.IO

Partial Public Class ClasesOdontogramaDataContext
    'CONVERTIR UNA IMAGEN EN BYTES PARA ALMACENARLA
    Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function
    'REDIMENSIONAR LAS IMAGENES CARGADAS PARA ADAPTARLAS AL PICTUREBOX
    Public Shared Sub resizePictureBox(ByVal pbx As PictureBox, ByVal maxSize As Integer)
        If (pbx.Image.Width > maxSize) Or (pbx.Image.Height > maxSize) Then
            If pbx.Image.Width > pbx.Image.Height Then
                pbx.Width = maxSize
                pbx.Height = pbx.Image.Height * maxSize / pbx.Image.Width
            Else
                pbx.Height = maxSize
                pbx.Width = pbx.Image.Width * maxSize / pbx.Image.Height
            End If
        Else
            pbx.Width = pbx.Image.Width
            pbx.Height = pbx.Image.Height
        End If
    End Sub
    'OBTENER LAS FAMILIAS SEGUN LA CATEGORIA QUE DEFINE LAS FAMILIAS DENTALES 
    Public Function GetListadoMedicos() As IEnumerable(Of md_MEDICO)
        Return From m In Me.md_MEDICOs Order By m.NOMBRE, m.APELLIDO1, m.APELLIDO2 Select m
    End Function
    'OBTENER LAS FAMILIAS SEGUN LA CATEGORIA QUE DEFINE LAS FAMILIAS DENTALES 
    Public Function GetFamiliasDental(ByVal Categoria As Integer) As IEnumerable(Of md_ConceptoFamilia)
        Return From f In Me.md_ConceptoFamilias Where f.Categoria = Categoria Order By f.Descripcion Select f
    End Function
    'OBTENER EL PROXIMO CODIGO A UTILIZAR EN UNA NUEVA OPERACION
    Public Function GetProximoIDInCFamilia() As Integer
        Dim cfamilia As md_ConceptoFamilia = (From f In Me.md_ConceptoFamilias Order By f.IDFamilia Descending Select f).First()
        If cfamilia Is Nothing Then
            Return 1
        Else
            Return cfamilia.IDFamilia + 1
        End If
    End Function
    'OBTENER LA FAMILIAS SEGUN ID
    Public Function GetFamiliaByID(ByVal ID As Integer) As md_ConceptoFamilia
        Return Me.md_ConceptoFamilias.Single(Function(f) f.IDFamilia = ID)
    End Function
    'OBTENER LOS CONCEPTOS FACTURABLES SEGUN FAMILIA
    Public Function GetCFraByFamilia(ByVal IDFamilia As Integer) As IEnumerable(Of md_ConceptoFra)
        Return From f In Me.md_ConceptoFras Where f.IDFAMILIA = IDFamilia Order By f.DESCRIPCION Select f
    End Function
    'OBTENER TODOS LOS CONCEPTOS FACTURABLES ASOCIADOS A OPERACIONES DENTALES
    Public Function GetAllCFra(ByVal Categoria As Integer) As IEnumerable(Of md_ConceptoFra)
        Return From f In Me.md_ConceptoFras Where f.md_ConceptoFamilia.Categoria = Categoria Order By f.DESCRIPCION Select f
    End Function
    'OBTENER EL PROXIMO CODIGO A UTILIZAR EN UN NUEVO CONCEPTO FACTURABLE
    Public Function GetProximoCodigoInCFra() As String
        Dim cfra As md_ConceptoFra = (From f In Me.md_ConceptoFras Order By f.CODIGO.Length Descending, f.CODIGO Descending Select f).First()
        If cfra Is Nothing Then
            Return "1"
        Else
            Dim cod As String = (Convert.ToInt32(cfra.CODIGO) + 1).ToString()
            Return cod.Substring(0, Math.Min(10, cod.Length))
        End If
    End Function
    'OBTENER CONCEPTO FACTURABLE SEGUN CODIGO
    Public Function GetCFraByID(ByVal Codigo As String) As md_ConceptoFra
        Return Me.md_ConceptoFras.Single(Function(f) f.CODIGO = Codigo)
    End Function
    'OBTENER IMAGEN_CONCEPTOFACTURABLE SEGUN IMAGEN, CONCEPTO 
    Public Function GetSingleImgCFra(ByVal Codigo As String, ByVal Cuadrante As Char) As md_d_ConceptoFra_Imagen
        Try
            Return Me.md_d_ConceptoFra_Imagens.Single(Function(i) (i.CodigoCfra = Codigo And i.Cuadrante = Cuadrante))
        Catch
            Return Nothing
        End Try
    End Function
    'OBTENER LOS COLORES QUE SE UTILIZARAN PARA PINTAR EL ODONTOGRAMA
    Public Function GetColores() As md_d_Color
        If md_d_Colors.Count = 0 Then
            Dim colores As New md_d_Color
            colores.clRealizado = Color.Blue.ToArgb()
            colores.clPendiente = Color.Green.ToArgb()
            colores.clPrimeravista = Color.Gray.ToArgb()
            colores.clPresupuesto = Color.Orange.ToArgb()
            colores.clUrgente = Color.Red.ToArgb()
            md_d_Colors.InsertOnSubmit(colores)
            SubmitChanges()
            Return colores
        Else
            Return (From c In md_d_Colors Select c).First()
        End If
    End Function
    'OBTENER TODAS LAS IMAGENES
    Public Function GetImagenes() As IEnumerable(Of md_d_Imagen)
        Return From i In Me.md_d_Imagens Order By i.Descripcion Select i
    End Function
    'OBTENER UNA IMAGEN SEGUN ID
    Public Function GetImagenByID(ByVal ID As Integer) As md_d_Imagen
        Return Me.md_d_Imagens.Single(Function(i) i.IDImagen = ID)
    End Function
    'OBTENER LOS ODONTOGRAMAS ASOCIADOS A UN PACIENTE
    Public Function GetOdontogramasByPaciente(ByVal Paciente As Integer) As IEnumerable(Of md_d_Odontograma)
        Dim Odontogramas As IEnumerable(Of md_d_Odontograma) = From o In Me.md_d_Odontogramas Where o.IDPaciente = Paciente Order By o.TipoDenticion Ascending Select o
        If Odontogramas.Count = 0 Then
            Dim odont As md_d_Odontograma() = {New md_d_Odontograma(), New md_d_Odontograma()}
            odont(0).IDPaciente = Paciente
            odont(0).Fecha = Date.Today
            odont(0).TipoDenticion = 0

            odont(1).IDPaciente = Paciente
            odont(1).Fecha = Date.Today
            odont(1).TipoDenticion = 1

            md_d_Odontogramas.InsertAllOnSubmit(odont)
            SubmitChanges()
            Odontogramas = From o In Me.md_d_Odontogramas Where o.IDPaciente = Paciente Order By o.TipoDenticion Ascending Select o
        End If
        Return Odontogramas
    End Function
    'OBTENER LAS ACCIONES ASOCIADAS A UN ODONTOGRAMA
    Public Function GetAccionesByOdontograma(ByVal Odontograma As Integer) As IEnumerable(Of md_d_Accion)
        Return From a In Me.md_d_Accions Where a.IDOdontograma = Odontograma Order By a.IDGabinete, a.FechaEjecucion Ascending Select a
    End Function
    'OBTENER TODAS LAS ACCIONES ASOCIADAS A UN ODONTOGRAMA SIN IMPORTAR LA DENTICION
    Public Function GetAllAccionesByOdontograma(ByVal Odontograma1 As Integer, ByVal Odontograma2 As Integer) As IEnumerable(Of md_d_Accion)
        Return From a In Me.md_d_Accions Where a.IDOdontograma = Odontograma1 Or a.IDOdontograma = Odontograma2 Order By a.IDGabinete, a.FechaEjecucion Ascending Select a
    End Function
    'OBTENER LOS PRESUPUESTOS ASOCIADOS A UN ODONTOGRAMA
    Public Function GetPresupuestosByOdontograma(ByVal Odontograma As Integer) As IEnumerable(Of md_d_Presupuesto)
        Return From p In Me.md_d_Presupuestos Where p.IDOdontograma = Odontograma Order By p.IDPresupuesto Ascending Select p
    End Function
    'OBTENER TODOS LOS PRESUPUESTOS SIN IMPORTAR LA DENTICION
    Public Function GetAllPresupuestos(ByVal Odontograma1 As Integer, ByVal Odontograma2 As Integer) As IEnumerable(Of md_d_Presupuesto)
        Return From p In Me.md_d_Presupuestos Where p.IDOdontograma = Odontograma1 Or p.IDOdontograma = Odontograma2 Order By p.IDPresupuesto Ascending Select p
    End Function
    'OBTENER LAS LINEAS DE PRESUPUESTOS ASOCIADAS A UN PRESUPUESTO
    Public Function GetLineasByPresupuesto(ByVal Presupuesto As Integer) As IEnumerable(Of md_d_PresupuestoLinea)
        Return From p In Me.md_d_PresupuestoLineas Where p.IDPresupuesto = Presupuesto Order By p.IDPresupuestoLinea Ascending Select p
    End Function
    'OBTENER LAS LINEAS DE PRESUPUESTOS QUE ESTAN CONFIRMADAS PERO NO REALIZADAS ASOCIADOS A UN ODONTOGRAMA
    Public Function GetLineasPendientes(ByVal Odontograma As Integer) As IEnumerable(Of md_d_PresupuestoLinea)
        Return From p In Me.md_d_PresupuestoLineas Join r In Me.md_d_Presupuestos On p.IDPresupuesto Equals r.IDPresupuesto Where r.IDOdontograma = Odontograma And p.Confirmado = True And p.Realizado = False Order By p.FechaConfirmado, p.IDPresupuestoLinea Select p
    End Function
    'OBTENER TODAS LAS LINEAS DE PRESUPUESTOS PENDIENTES SIN IMPORTAR LA DENTICION
    Public Function GetAllLineasPendientes(ByVal Odontograma1 As Integer, ByVal Odontograma2 As Integer) As IEnumerable(Of md_d_PresupuestoLinea)
        Return From p In Me.md_d_PresupuestoLineas Join r In Me.md_d_Presupuestos On p.IDPresupuesto Equals r.IDPresupuesto Where r.IDOdontograma = Odontograma1 Or r.IDOdontograma = Odontograma2 And p.Confirmado = True And p.Realizado = False Order By p.FechaConfirmado, p.IDPresupuestoLinea Select p
    End Function
    'OBTENER LAS LINEAS DE PRESUPUESTOS QUE AUN NO HAN SIDO CONFIRMADAS
    Public Function GetLineasSinConfirmar(ByVal Odontograma As Integer) As IEnumerable(Of md_d_PresupuestoLinea)
        Return From p In Me.md_d_PresupuestoLineas Join r In Me.md_d_Presupuestos On p.IDPresupuesto Equals r.IDPresupuesto Where r.IDOdontograma = Odontograma And p.Confirmado = False And p.Realizado = False Order By p.FechaConfirmado, p.IDPresupuestoLinea Select p
    End Function
    'OBTENER ACCION SEGUN ID
    Public Function GetAccionByID(ByVal ID As Integer) As md_d_Accion
        Return Me.md_d_Accions.Single(Function(a) a.IDAccion = ID)
    End Function
    'OBTENER PRESUPUESTO SEGUN ID
    Public Function GetPresupuestoByID(ByVal ID As Integer) As md_d_Presupuesto
        Return Me.md_d_Presupuestos.Single(Function(p) p.IDPresupuesto = ID)
    End Function
    'OBTENER LINEA DE PRESUPUESTO SEGUN ID
    Public Function GetLineaPresupuestoByID(ByVal ID As Integer) As md_d_PresupuestoLinea
        Return Me.md_d_PresupuestoLineas.Single(Function(p) p.IDPresupuestoLinea = ID)
    End Function
    'OBTENER EL TIPO DE DENTICION DE UNA LINEA DE PRESUPUESTO SEGUN ID
    Public Function GetTipoDenticioLineaPresupuestoByID(ByVal ID As Integer) As Integer?
        Return (From p In Me.md_d_PresupuestoLineas Where p.IDPresupuestoLinea = ID Select p.TipoDenticion).FirstOrDefault()
    End Function
    'OBTENER LINEAS DE PRESUPUESTO SEGUN ID DE UNA DE LAS LINEAS
    Public Function GetLineaPresupuestoByIDLinea(ByVal ID As Integer) As IEnumerable(Of md_d_PresupuestoLinea)
        Dim IdPres As Integer = (From p In Me.md_d_PresupuestoLineas Where p.IDPresupuestoLinea = ID Select p.IDPresupuesto).FirstOrDefault()
        Return GetLineasByPresupuesto(IdPres)
    End Function
End Class
