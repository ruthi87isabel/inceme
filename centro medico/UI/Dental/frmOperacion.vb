Imports centro_medico.ClasesOdontogramaDataContext
Imports System.IO
Imports System.Data.Linq

Public Class frmOperacion
    Public Nuevo As Boolean
    Public currentID As Integer
    Public catDental As Integer
    Private ImageChanged As Boolean = False

    Private Sub frmOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim classOdontograma As New ClasesOdontogramaDataContext
        If Nuevo Then
            tbxID.Text = classOdontograma.GetProximoIDInCFamilia()
        Else
            Text = "Modificando operación"
            CargarControles(classOdontograma.md_ConceptoFamilias.Single(Function(f) f.IDFamilia = currentID))
            CargarTratamientos()
        End If
    End Sub
    'MOSTRAR EN LOS CONTROLES LA INFORMACION QUE CONTIENE EL OBJETO
    Private Sub CargarControles(ByVal familia As md_ConceptoFamilia)
        tbxID.Text = familia.IDFamilia.ToString()
        tbxDescripcion.Text = familia.Descripcion
        chbNatural.Checked = familia.Natural
        If familia.IconoName = Nothing Then
            pbxIcono.Image = Nothing
        Else
            pbxIcono.Image = Image.FromStream(New MemoryStream(familia.IconoName.ToArray()))
            resizePicture()
        End If
    End Sub
    'REDIMENSIONAR LAS IMAGENES CARGADAS PARA ADAPTARLAS AL PICTUREBOX
    Private Sub resizePicture()
        resizePictureBox(pbxIcono, 60)
    End Sub
    'BUSCAR LA IMAGEN A INSERTAR
    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        dlgOpen.Filter = "Ficheros de imagen (*.gif;*.jpg;*.jpeg*.bmp;*.wmf;*.png;*.ico)|*.gif;*.jpg;*.jpeg*.bmp;*.wmf;*.png;*.ico"
        dlgOpen.Title = "Seleccionado imagen"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            pbxIcono.Image = Image.FromFile(dlgOpen.FileName)
            resizePicture()
            ImageChanged = True
        End If
    End Sub
    'LIMPIAR LA IMAGEN SI HAY ALGO
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        pbxIcono.Image = Nothing
        ImageChanged = True
    End Sub
    'PERMITIR SOLAMENTE LA ENTRADA DE CARACTERES EN EL CAMPO ID
    Private Sub tbxID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxID.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Function Salvar() As Boolean
        If tbxID.Text.Trim = "" Then
            MsgBox("Debe especificar el valor del ID.")
            tbxID.Focus()
            Return False
        End If
        If tbxDescripcion.Text.Trim() = "" Then
            MsgBox("Debe especificar la descripción de la operación.")
            tbxDescripcion.Focus()
            Return False
        End If
        Dim familia As md_ConceptoFamilia
        Dim classOdontograma As New ClasesOdontogramaDataContext

        If Nuevo = True Then
            familia = New md_ConceptoFamilia()
            familia.IDFamilia = Convert.ToInt32(tbxID.Text)
            familia.Descripcion = tbxDescripcion.Text
            familia.Natural = chbNatural.Checked
            familia.Categoria = catDental
            If ImageChanged = True Then
                If pbxIcono.Image Is Nothing Then
                    familia.IconoName = Nothing
                Else
                    familia.IconoName = Image2Bytes(pbxIcono.Image)
                End If
            End If
            classOdontograma.md_ConceptoFamilias.InsertOnSubmit(familia)
        Else
            familia = classOdontograma.md_ConceptoFamilias.Single(Function(f) f.IDFamilia = currentID)
            familia.Descripcion = tbxDescripcion.Text
            familia.Natural = chbNatural.Checked
            If ImageChanged = True Then
                If pbxIcono.Image Is Nothing Then
                    familia.IconoName = Nothing
                Else
                    familia.IconoName = Image2Bytes(pbxIcono.Image)
                End If
            End If
        End If

        Try
            classOdontograma.SubmitChanges()
            If Nuevo = True Then
                TryCast(Owner, frmOperaciones).AddItem(familia)
            Else
                TryCast(Owner, frmOperaciones).UpdateItem(familia)
            End If
            Return True
        Catch ex As Exception
            MsgBox("Error al salvar operación: " + ex.ToString())
            Return False
        End Try
    End Function
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If Salvar() = True Then
            Close()
        End If
    End Sub
    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Close()
    End Sub
    Private Sub CargarTratamientos()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cFra As IEnumerable(Of md_ConceptoFra) = classOdontograma.GetCFraByFamilia(currentID)
        For Each tratamiento As md_ConceptoFra In cFra
            AddItem(tratamiento)
        Next
        If LVw_Trat.Items.Count > 0 Then
            LVw_Trat.Items(0).Selected = True
        End If
    End Sub
    Public Sub AddItem(ByVal tratamiento As md_ConceptoFra)
        Dim LI As ListViewItem = LVw_Trat.Items.Add(tratamiento.DESCRIPCION, 0)
        LI.SubItems.Add(tratamiento.IMPORTE.ToString("0.00##"))
        LI.SubItems.Add(Format(tratamiento.Duracion, "HH:mm"))
        LI.Tag = tratamiento
    End Sub
    Public Sub UpdateItem(ByVal tratamiento As md_ConceptoFra)
        LVw_Trat.SelectedItems(0).Text = tratamiento.DESCRIPCION
        LVw_Trat.SelectedItems(0).SubItems(1).Text = tratamiento.IMPORTE.ToString("0.00##")
        LVw_Trat.SelectedItems(0).SubItems(2).Text = Format(tratamiento.Duracion, "HH:mm")
    End Sub
    Public Sub RemoveItem()
        LVw_Trat.SelectedItems(0).Remove()
    End Sub
    Private Sub LVw_Trat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Trat.SelectedIndexChanged
        btnModificar.Enabled = LVw_Trat.SelectedItems.Count > 0
        btnEliminar.Enabled = LVw_Trat.SelectedItems.Count > 0
    End Sub
    Private Sub MostrarSeleccionado()
        Dim ftratamiento As New frmTratamientos()
        ftratamiento.Nuevo = False
        ftratamiento.catDental = catDental
        ftratamiento.IDFamilia = Convert.ToInt32(tbxID.Text)
        ftratamiento.currentCODIGO = TryCast(LVw_Trat.SelectedItems(0).Tag, md_ConceptoFra).CODIGO
        ftratamiento.ShowDialog(Me)
    End Sub
    Private Sub EliminarSeleccionado()
        If MsgBox("Al eliminar el tratamiento se eliminarán las acciones donde dicho tratamiento fue aplicado. ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de borrado") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim tratamiento As md_ConceptoFra = classOdontograma.md_ConceptoFras.Single(Function(f) f.CODIGO = TryCast(LVw_Trat.SelectedItems(0).Tag, md_ConceptoFra).CODIGO)
            classOdontograma.md_ConceptoFras.DeleteOnSubmit(tratamiento)
            Try
                classOdontograma.SubmitChanges()
                LVw_Trat.SelectedItems(0).Remove()
            Catch ex As Exception
                MessageBox.Show("El tratamiento no pudo ser eliminado, pues es utilizado en el Odontrograma/Presupuestos de uno o varios pacientes")
            End Try
            
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If Nuevo Then
            If Salvar() = True Then
                Nuevo = False
            Else
                Exit Sub
            End If
        End If
        Dim ftratamiento As New frmTratamientos()
        ftratamiento.catDental = catDental
        ftratamiento.Nuevo = True
        ftratamiento.IDFamilia = Convert.ToInt32(tbxID.Text)
        ftratamiento.ShowDialog(Me)
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        MostrarSeleccionado()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        EliminarSeleccionado()
    End Sub
    Private Sub LVw_Trat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LVw_Trat.KeyDown
        If LVw_Trat.SelectedItems.Count > 0 Then
            If e.KeyCode = Keys.Delete Then
                EliminarSeleccionado()
            ElseIf e.KeyCode = Keys.F2 Then
                MostrarSeleccionado()
            End If
        End If
    End Sub
    Private Sub LVw_Trat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Trat.DoubleClick
        If LVw_Trat.SelectedItems.Count > 0 Then
            MostrarSeleccionado()
        End If
    End Sub
End Class