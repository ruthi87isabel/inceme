Imports centro_medico.ClasesOdontogramaDataContext
Imports System.IO
Imports System.Data.Linq

Public Class frmOperaciones

    Public catDental As Integer
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Familia As md_ConceptoFamilia

    Private Sub frmOperaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cFamilias As IEnumerable(Of md_ConceptoFamilia) = classOdontograma.GetFamiliasDental(catDental)
        For Each Operacion As md_ConceptoFamilia In cFamilias
            AddItem(Operacion)
        Next
        If LVw_Oper.Items.Count > 0 Then
            LVw_Oper.Items(0).Selected = True
        End If
    End Sub
    Public Sub AddItem(ByVal operacion As md_ConceptoFamilia)
        LVw_Oper.Items.Add(operacion.Descripcion, 0)
        LVw_Oper.Items(LVw_Oper.Items.Count - 1).Tag = operacion
    End Sub
    Public Sub UpdateItem(ByVal operacion As md_ConceptoFamilia)
        LVw_Oper.SelectedItems(0).Text = operacion.Descripcion
    End Sub
    Private Sub LVw_Oper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Oper.SelectedIndexChanged
        tsbModificar.Enabled = LVw_Oper.SelectedItems.Count > 0
        tsbEliminar.Enabled = LVw_Oper.SelectedItems.Count > 0
    End Sub
    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Dim foperacion As New frmOperacion()
        foperacion.catDental = catDental
        foperacion.Nuevo = True
        foperacion.ShowDialog(Me)
    End Sub
    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        MostrarSeleccionado()
    End Sub
    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        EliminarSeleccionado()
    End Sub
    Private Sub MostrarSeleccionado()
        Dim foperacion As New frmOperacion()
        foperacion.catDental = catDental
        foperacion.Nuevo = False
        foperacion.currentID = TryCast(LVw_Oper.SelectedItems(0).Tag, md_ConceptoFamilia).IDFamilia
        foperacion.ShowDialog(Me)
    End Sub
    Private Sub EliminarSeleccionado()
        If MsgBox("Al eliminar la operación seleccionada, se eliminarán los tratamientos asociados, y con estos todas las acciones donde fueron aplicados. ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de borrado") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim familia As md_ConceptoFamilia = classOdontograma.md_ConceptoFamilias.Single(Function(f) f.IDFamilia = TryCast(LVw_Oper.SelectedItems(0).Tag, md_ConceptoFamilia).IDFamilia)
            Dim tratamientos As IEnumerable(Of md_ConceptoFra) = classOdontograma.GetCFraByFamilia(familia.IDFamilia)
            classOdontograma.md_ConceptoFamilias.DeleteOnSubmit(familia)
            'HAY QUE BORRARLOS MANUALMENTE PORQUE NO ESTAN RELACIONADOS
            classOdontograma.md_ConceptoFras.DeleteAllOnSubmit(tratamientos)
            classOdontograma.SubmitChanges()
            LVw_Oper.SelectedItems(0).Remove()
        End If
    End Sub
    Private Sub LVw_Oper_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Oper.DoubleClick
        If LVw_Oper.SelectedItems.Count > 0 Then
            If Modo = Globales.ModoParaFormas.Seleccion Then
                Dim classOdontograma As New ClasesOdontogramaDataContext
                Familia = classOdontograma.md_ConceptoFamilias.Single(Function(f) f.IDFamilia = TryCast(LVw_Oper.SelectedItems(0).Tag, md_ConceptoFamilia).IDFamilia)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MostrarSeleccionado()
            End If
        End If
    End Sub
    Private Sub LVw_Oper_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LVw_Oper.KeyDown
        If LVw_Oper.SelectedItems.Count > 0 Then
            If e.KeyCode = Keys.Delete Then
                EliminarSeleccionado()
            ElseIf e.KeyCode = Keys.F2 Then
                MostrarSeleccionado()
            End If
        End If
    End Sub
End Class