Imports System.IO
Imports System.Xml
Imports System.Xml.Linq
Imports System.Globalization

Public Class frmTratamientos
    Public Nuevo As Boolean
    Public currentCODIGO As String
    Public IDFamilia As Integer
    Public catDental As Integer

    Private cbxImagenes(5) As ComboBox
    Private chbImagenes(5) As CheckBox
    Private LoadingImages As Boolean = False
    Private LastInsertedImageID As Integer = 0
    Private IDImageThumb As Integer = 0
    Private cbxOnThumb As ComboBox
    Private ExistingImages As Boolean() = {False, False, False, False, False, False}
    Private charCuadrantes As Char() = {"C", "D", "V", "M", "I", "L"}
    Public EdicionDirecta As Boolean = False

    Public Sub New()
        InitializeComponent()
        cbxImagenes(0) = cbx1
        cbxImagenes(1) = cbx2
        cbxImagenes(2) = cbx3
        cbxImagenes(3) = cbx4
        cbxImagenes(4) = cbx5
        cbxImagenes(5) = cbx6

        chbImagenes(0) = chb1
        chbImagenes(1) = chb2
        chbImagenes(2) = chb3
        chbImagenes(3) = chb4
        chbImagenes(4) = chb5
        chbImagenes(5) = chb6

    End Sub

    Private Function NuevoCodigo() As String
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cod As String = classOdontograma.GetProximoCodigoInCFra()
        If ExisteCodigo(cod) Then
            Dim cod2 As String = (Convert.ToInt32(cod) + 1).ToString()
            Return cod2.Substring(0, Math.Min(10, cod2.Length))
        Else
            Return cod
        End If
    End Function

    'AL CARGAR EL FORMULARIO
    Private Sub frmTratamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGAR LAS IMAGENES
        CargarImagenes(False, 1)
        'CARGAR LAS FAMILIAS
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cFamilias As IEnumerable(Of md_ConceptoFamilia) = classOdontograma.GetFamiliasDental(catDental)
        For Each Operacion As md_ConceptoFamilia In cFamilias
            cbxFamilia.Items.Add(Operacion)
            If IDFamilia = Operacion.IDFamilia Then
                cbxFamilia.SelectedIndex = cbxFamilia.Items.Count - 1
            End If
        Next
        cbxFamilia.DisplayMember = "Descripcion"

        If Nuevo Then
            tbxCodigo.Text = NuevoCodigo()
            cbxFamilia.Enabled = False
        Else
            Text = "Modificando tratamiento"
            CargarControles(classOdontograma.GetCFraByID(currentCODIGO))
        End If
    End Sub
    'MOSTRAR EN LOS CONTROLES LA INFORMACION QUE CONTIENE EL OBJETO
    Private Sub CargarImagenes(Optional ByVal Inserted As Boolean = False, Optional ByVal imgInserted As Integer = 1)
        LoadingImages = True
        Dim LastSoFarID As Integer = LastInsertedImageID
        Dim NewImageIndex As Integer = 0
        'ALMACENAMOS LOS ITEMS SELECIONADOS
        Dim Indexes As Integer() = {0, 0, 0, 0, 0, 0}
        If cbx1.SelectedIndex > 0 Then
            Indexes(0) = TryCast(cbx1.SelectedItem, md_d_Imagen).IDImagen
        End If
        For i As Integer = 1 To 5
            If cbxImagenes(i).SelectedIndex > 0 Then
                Indexes(i) = TryCast(cbx1.Items(cbxImagenes(i).SelectedIndex), md_d_Imagen).IDImagen
            End If
            cbxImagenes(i).Items.Clear()
            cbxImagenes(i).Items.Add("[Ninguna]")
            cbxImagenes(i).SelectedIndex = 0
        Next
        cbx1.Items.Clear()
        cbx1.Items.Add("[Ninguna]")
        cbx1.SelectedIndex = 0
        'CARGAR TODAS LAS IMAGENES, ACTUALIZANDO LA INFORMACION ANTERIOR
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim Imagenes As IEnumerable(Of md_d_Imagen) = classOdontograma.GetImagenes()
        For Each imagen As md_d_Imagen In Imagenes
            If LastInsertedImageID < imagen.IDImagen Then
                LastInsertedImageID = imagen.IDImagen
            End If
            cbx1.Items.Add(imagen)
            If Inserted And (imagen.IDImagen > LastSoFarID) Then
                NewImageIndex = cbx1.Items.Count - 1
            End If
            If imagen.IDImagen = Indexes(0) Then
                cbx1.SelectedIndex = cbx1.Items.Count - 1
            End If
            For i As Integer = 1 To 5
                cbxImagenes(i).Items.Add(imagen.Descripcion)
                If imagen.IDImagen = Indexes(i) Then
                    cbxImagenes(i).SelectedIndex = cbxImagenes(i).Items.Count - 1
                End If
            Next
        Next
        If Inserted And (NewImageIndex > 0) Then
            cbxImagenes(imgInserted - 1).SelectedIndex = NewImageIndex
        End If
        cbx1.DisplayMember = "Descripcion"
        LoadingImages = False
        showthumb(cbxImagenes(imgInserted - 1))
    End Sub
    'MOSTRAR EN LOS CONTROLES LA INFORMACION QUE CONTIENE EL OBJETO
    Private Sub CargarControles(ByVal tratamiento As md_ConceptoFra)
        tbxCodigo.Text = tratamiento.CODIGO
        tbxDescripcion.Text = tratamiento.DESCRIPCION
        tbxImporte.Text = tratamiento.IMPORTE.ToString("0.00##")
        dtpDuracion.Text = Format(tratamiento.Duracion, "HH:mm")
        getXML(tratamiento)
        For i As Integer = 0 To 5
            cbxImagenes(i).SelectedIndex = 0
        Next
        For Each cimg As md_d_ConceptoFra_Imagen In tratamiento.md_d_ConceptoFra_Imagens
            Select Case cimg.Cuadrante
                Case "C"
                    UpdateCbxSelected(cbx1, cimg.IDImagen)
                    chb1.Checked = cimg.Pintar
                    ExistingImages(0) = True
                Case "D"
                    UpdateCbxSelected(cbx2, cimg.IDImagen)
                    chb2.Checked = cimg.Pintar
                    ExistingImages(1) = True
                Case "V"
                    UpdateCbxSelected(cbx3, cimg.IDImagen)
                    chb3.Checked = cimg.Pintar
                    ExistingImages(2) = True
                Case "M"
                    UpdateCbxSelected(cbx4, cimg.IDImagen)
                    chb4.Checked = cimg.Pintar
                    ExistingImages(3) = True
                Case "I"
                    UpdateCbxSelected(cbx5, cimg.IDImagen)
                    chb5.Checked = cimg.Pintar
                    ExistingImages(4) = True
                Case "L"
                    UpdateCbxSelected(cbx6, cimg.IDImagen)
                    chb6.Checked = cimg.Pintar
                    ExistingImages(5) = True
            End Select
        Next
    End Sub
    Private Sub getXML(ByVal tratamiento As md_ConceptoFra)
        If tratamiento.XMLCont Is Nothing Then
            Return
        End If
        Dim doc As XDocument = XDocument.Parse(tratamiento.XMLCont)
        Dim tratNode As XElement = doc.Element("Tratamiento")
        chbMarcar.Checked = tratNode.Attribute("Marcar")
        chBCuadrantes.Checked = tratNode.Attribute("Cuadrantes")
        chbMultiple.Checked = tratNode.Attribute("Multiple")


        If tratNode.Attribute("ImportePorPieza") Is Nothing Then
            'Agregarlo y salvar el Tratamiento
            Dim context As New CMLinqDataContext()
            Dim tratamiento2 As CONCEPTOSFRA = (From t In context.CONCEPTOSFRAs Where t.CODIGO = tratamiento.CODIGO Select t).SingleOrDefault
            'tratamiento.XMLCont = 
            tratNode.Add(New XAttribute("ImportePorPieza", "False"))
            tratamiento2.XMLCont = doc.ToString()
            chkImportePorPiezas.Checked = False
            context.SubmitChanges()
        Else
            chkImportePorPiezas.Checked = tratNode.Attribute("ImportePorPieza")
        End If


        Dim dispNode As XElement = tratNode.Element("Disponibles")
        For Each piece As XElement In dispNode.Elements("Pieza")
            If Convert.ToInt32(piece.Value) > 50 Then
                TryCast(pnlTemporales.Controls(pnlTemporales.Controls.IndexOfKey("chb" + piece.Value)), CheckBox).Checked = True
            Else
                TryCast(pnlDefinitivas.Controls(pnlDefinitivas.Controls.IndexOfKey("chb" + piece.Value)), CheckBox).Checked = True
            End If
        Next
    End Sub
    Private Function setXML() As String
        Dim disponibles As XElement = New XElement("Disponibles")
        For i As Integer = 0 To pnlDefinitivas.Controls.Count - 1
            If (pnlDefinitivas.Controls(i).Name.Substring(0, 3) = "chb") Then
                If (TryCast(pnlDefinitivas.Controls(i), CheckBox).Checked) Then
                    disponibles.Add(New XElement("Pieza", pnlDefinitivas.Controls(i).Tag))
                End If
            End If
        Next
        For i As Integer = 0 To pnlTemporales.Controls.Count - 1
            If (pnlTemporales.Controls(i).Name.Substring(0, 3) = "chb") Then
                If (TryCast(pnlTemporales.Controls(i), CheckBox).Checked) Then
                    disponibles.Add(New XElement("Pieza", pnlTemporales.Controls(i).Tag))
                End If
            End If
        Next

        Dim doc As XDocument = New XDocument(New XElement("Tratamiento", _
                                    New XAttribute("Marcar", chbMarcar.Checked), _
                                    New XAttribute("Cuadrantes", chBCuadrantes.Checked), _
                                    New XAttribute("ImportePorPieza", chkImportePorPiezas.Checked), _
                                    New XAttribute("Multiple", chbMultiple.Checked), disponibles))
        Return doc.ToString()
    End Function
    'ACEPTAR LOS CAMBIOS
    Private Sub SalvarImagenesAsociadas(ByVal CodTrat As String)
        Try
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim imgFra As md_d_ConceptoFra_Imagen
            For i As Integer = 0 To 5
                If ExistingImages(i) = True Then
                    imgFra = classOdontograma.GetSingleImgCFra(CodTrat, charCuadrantes(i))
                    If (cbxImagenes(i).SelectedIndex = 0) OrElse ((i > 0) AndAlso (chBCuadrantes.Checked = False)) Then
                        'ELIMINAR
                        classOdontograma.md_d_ConceptoFra_Imagens.DeleteOnSubmit(imgFra)
                        ExistingImages(i) = False
                    Else
                        'MODIFICAR
                        imgFra.IDImagen = TryCast(cbx1.Items(cbxImagenes(i).SelectedIndex), md_d_Imagen).IDImagen
                        imgFra.Pintar = chbImagenes(i).Checked
                    End If
                ElseIf (cbxImagenes(i).SelectedIndex > 0) AndAlso ((i = 0) OrElse (chBCuadrantes.Checked = True)) Then
                    'INSERTAR
                    imgFra = New md_d_ConceptoFra_Imagen()
                    imgFra.CodigoCfra = CodTrat
                    imgFra.Cuadrante = charCuadrantes(i)
                    imgFra.IDImagen = TryCast(cbx1.Items(cbxImagenes(i).SelectedIndex), md_d_Imagen).IDImagen
                    imgFra.Pintar = chbImagenes(i).Checked
                    classOdontograma.md_d_ConceptoFra_Imagens.InsertOnSubmit(imgFra)
                    ExistingImages(i) = True
                End If
                classOdontograma.SubmitChanges()
            Next
        Catch ex As Exception
            MsgBox("Error al asociar las imágenes al tratamiento: " + ex.ToString())
        End Try
    End Sub
    'MARCAR TODAS LAS PIEZAS
    Private Sub btnMarcarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarTodas.Click
        ChangeChbPiecesStatus(True)
    End Sub
    'DESMARCAR TODAS LAS PIEZAS 
    Private Sub btnDesmarcarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcarTodas.Click
        ChangeChbPiecesStatus(False)
    End Sub
    'CAMBIAR EL ESTADO DE TODAS LAS PIEZAS 
    Private Sub ChangeChbPiecesStatus(ByVal chk As Boolean)
        For i As Integer = 0 To pnlDefinitivas.Controls.Count - 1
            If pnlDefinitivas.Controls(i).Name.Substring(0, 3) = "chb" Then
                TryCast(pnlDefinitivas.Controls(i), CheckBox).Checked = chk
            End If
        Next
        For i As Integer = 0 To pnlTemporales.Controls.Count - 1
            If pnlTemporales.Controls(i).Name.Substring(0, 3) = "chb" Then
                TryCast(pnlTemporales.Controls(i), CheckBox).Checked = chk
            End If
        Next
    End Sub
    'CUANDO CAMBIA EL ESTADO DEL CHECK MARCAR CAMBIAR LO QUE DEPENDE DE EL
    Private Sub chbMarcar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMarcar.CheckedChanged, chbMarcar.EnabledChanged
        chBCuadrantes.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        chbMultiple.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        chkImportePorPiezas.Enabled = chbMarcar.Checked And chbMarcar.Enabled

        pnlDefinitivas.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        pnlTemporales.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        btnMarcarTodas.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        btnDesmarcarTodas.Enabled = chbMarcar.Checked And chbMarcar.Enabled
        If chbMarcar.Checked = False Then
            chBCuadrantes.Checked = False
            chbMultiple.Checked = False
            chkImportePorPiezas.Checked = False
            ChangeChbPiecesStatus(False)
        End If
    End Sub
    'CUANDO CAMBIA EL ESTADO DEL CHECK CUADRANTES CAMBIAR LO QUE DEPENDE DE EL
    Private Sub chBCuadrantes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chBCuadrantes.CheckedChanged
        pnlImgXCuadrantes.Visible = chBCuadrantes.Checked
        If chBCuadrantes.Checked Then
            gbx1.Text = "Imagen asociada a la superficie Cervical"
        Else
            gbx1.Text = "Imagen asociada"
            If Not (cbxOnThumb Is cbx1) Then
                showthumb(cbx1)
            End If
        End If
    End Sub
    Private Sub cbx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx1.SelectedIndexChanged, cbx6.SelectedIndexChanged, cbx5.SelectedIndexChanged, cbx4.SelectedIndexChanged, cbx3.SelectedIndexChanged, cbx2.SelectedIndexChanged
        If Not LoadingImages Then
            showthumb(TryCast(sender, ComboBox))
        End If
    End Sub
    Private Sub showthumb(ByRef cbx As ComboBox)
        cbxOnThumb = cbx
        Dim index As Integer = cbx.SelectedIndex
        If index > 0 Then
            pbxThumb.Image = Image.FromStream(New MemoryStream(TryCast(cbx1.Items(index), md_d_Imagen).Imagen.ToArray()))
            IDImageThumb = TryCast(cbx1.Items(index), md_d_Imagen).IDImagen
        Else
            pbxThumb.Image = Nothing
            IDImageThumb = 0
        End If
    End Sub
    Private Sub UpdateCbxSelected(ByRef cbx As ComboBox, ByVal ID As Integer)
        For i As Integer = 1 To cbx1.Items.Count - 1
            If TryCast(cbx1.Items(i), md_d_Imagen).IDImagen = ID Then
                cbx.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub
    Private Sub btnNueva1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva1.Click, btnNueva6.Click, btnNueva5.Click, btnNueva4.Click, btnNueva3.Click, btnNueva2.Click
        Dim fimagen As New frmImagen()
        If fimagen.ShowDialog(Me) = DialogResult.OK Then
            CargarImagenes(True, Convert.ToInt32(TryCast(sender, Control).Tag))
        End If
    End Sub

    Private Sub pbxThumb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxThumb.Click
        If Not (pbxThumb.Image Is Nothing) Then
            Dim fimagen As New frmImagen()
            fimagen.currentID = IDImageThumb
            If fimagen.ShowDialog(Me) = DialogResult.OK Then
                CargarImagenes(False, Convert.ToInt32(cbxOnThumb.Tag))
            End If
        End If
    End Sub
    Private Sub cbx1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx1.Enter, cbx6.Enter, cbx5.Enter, cbx4.Enter, cbx3.Enter, cbx2.Enter
        showthumb(TryCast(sender, ComboBox))
    End Sub
    Private Sub tbxImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxImporte.KeyPress
        Dim nfi As NumberFormatInfo = NumberFormatInfo.CurrentInfo
        If (Not Char.IsDigit(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            If (e.KeyChar <> nfi.CurrencyDecimalSeparator) Or tbxImporte.Text.Contains(nfi.CurrencyDecimalSeparator) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Function ExisteCodigo(ByVal cod As String) As Boolean
        'Verificar si el codigo existe
        Dim context As New CMLinqDataContext
        Dim concepto As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs _
                                       Where c.CODIGO = tbxCodigo.Text _
                                       Select c).SingleOrDefault()
        Return Not concepto Is Nothing
    End Function

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If (tbxCodigo.Text.Trim = "") Then
            MsgBox("Código no especificado.")
            Exit Sub
        End If
        If (tbxDescripcion.Text.Trim() = "") Then
            MsgBox("Debe especificar la descripción.")
            Exit Sub
        End If
        If (tbxImporte.Text.Trim() = "") Then
            MsgBox("Debe especificar el importe.")
            Exit Sub
        End If

        Dim tratamiento As md_ConceptoFra
        Dim classOdontograma As New ClasesOdontogramaDataContext

        If Nuevo = True Then

           
            If ExisteCodigo(tbxCodigo.Text) Then
                MessageBox.Show("El codigo seleccionado ya existe")
                Return
            End If

            tratamiento = New md_ConceptoFra()
            tratamiento.CODIGO = tbxCodigo.Text
            tratamiento.DESCRIPCION = tbxDescripcion.Text
            tratamiento.IMPORTE = CDbl(tbxImporte.Text)
            tratamiento.Duracion = dtpDuracion.Value
            tratamiento.IDFAMILIA = IDFamilia
            tratamiento.XMLCont = setXML()
            classOdontograma.md_ConceptoFras.InsertOnSubmit(tratamiento)
        Else
            tratamiento = classOdontograma.md_ConceptoFras.Single(Function(f) f.CODIGO = currentCODIGO)
            tratamiento.DESCRIPCION = tbxDescripcion.Text
            tratamiento.IMPORTE = CDbl(tbxImporte.Text)
            tratamiento.Duracion = dtpDuracion.Value
            tratamiento.IDFAMILIA = TryCast(cbxFamilia.SelectedItem, md_ConceptoFamilia).IDFamilia
            tratamiento.XMLCont = setXML()
        End If
        Try
            classOdontograma.SubmitChanges()
            SalvarImagenesAsociadas(tratamiento.CODIGO)

            If Not EdicionDirecta Then

                If (Nuevo = True) Then
                    If Not Owner Is Nothing Then
                        If Owner Is frmOperacion Then
                            TryCast(Owner, frmOperacion).AddItem(tratamiento)
                        End If
                        currentCODIGO = tbxCodigo.Text
                    End If
                Else
                    If IDFamilia = TryCast(cbxFamilia.SelectedItem, md_ConceptoFamilia).IDFamilia Then
                        TryCast(Owner, frmOperacion).UpdateItem(tratamiento)
                    Else
                        TryCast(Owner, frmOperacion).RemoveItem()
                    End If
                End If
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Close()
        Catch ex As Exception
            MsgBox("Error al salvar tratamiento: " + ex.ToString())
        End Try
    End Sub
    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Close()
    End Sub
End Class