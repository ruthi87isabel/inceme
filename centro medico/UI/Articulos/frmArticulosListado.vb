Imports Janus.Windows.GridEX

Public Class frmArticulosListado

    Private Sub txtMayorQue_Enter(sender As System.Object, e As System.EventArgs) Handles txtMayorQue.Enter, txtMenorQue.Enter
        txtMayorQue.Enabled = txtMayorQue.Focused
        txtMenorQue.Enabled = Not txtMayorQue.Enabled
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New form_articulos("Ficha de Artículos-Añadir", Enums.Accion.Insertar)
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            content.ARTICULOs.DeleteOnSubmit(content.ARTICULOs.FirstOrDefault(Function(m) m.CARTICULO = CType(ARTICULOBindingSource.Current, ARTICULO).CARTICULO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("El artículo {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(ARTICULOBindingSource.Current, ARTICULO).DESCRIPCION))
        End Try
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Editar()
    End Sub


    Private Sub Editar()
        Dim frm As New form_articulos("Ficha de Artículos-Editar", Enums.Accion.Modificar, CType(ARTICULOBindingSource.Current, ARTICULO).CARTICULO)
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Protected Overrides Sub PopulateGrid()

        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of ARTICULO) = content.ARTICULOs.AsQueryable()

        Dim codInt As Integer = 0
        Integer.TryParse(txtCodigo.Text, codInt)

        If codInt > 0 Then
            query = query.Where(Function(m) m.CARTICULO = codInt)
        End If

        If (Not String.IsNullOrEmpty(txtDescripcion.Text)) Then
            query = query.Where(Function(m) m.DESCRIPCION.Contains(txtDescripcion.Text))
        End If

        Dim stockInt As Integer

        If (txtMayorQue.Enabled) Then
            Integer.TryParse(txtMayorQue.Text, stockInt)
            query = query.Where(Function(m) m.STOCK.Value <= stockInt)
        Else
            Integer.TryParse(txtMenorQue.Text, stockInt)
            query = query.Where(Function(m) m.STOCK >= stockInt)
        End If

        ARTICULOBindingSource.DataSource = query
    End Sub

    Private Sub btnConfigGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigGrid.Click
        Configure()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each cExt As GridEXColumn In GridEX1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next


    End Sub
End Class