Imports Janus.Windows.GridEX

Public Class frmClinicasExternas

    Private Shadows WithEvents GridEX1 As GridEX


    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New form_clinicas("Ficha de derivaciones-Añadir", Enums.Accion.Insertar)
        frm.ShowDialog()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            content.DERIVACIONES_DESTINOs.DeleteOnSubmit(content.DERIVACIONES_DESTINOs.FirstOrDefault(Function(m) m.CODIGO = CType(DERIVACIONES_DESTINOBindingSource.Current, DERIVACIONES_DESTINO).CODIGO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("La clínica {0} no puede ser eliminada pues se encuentra en uso por la aplicación", CType(DERIVACIONES_DESTINOBindingSource.Current, DERIVACIONES_DESTINO).NOMBRE))
        End Try
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Editar()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Protected Overrides Sub PopulateGrid()
        Me.GridEX1.AllowEdit = InheritableBoolean.False

        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of DERIVACIONES_DESTINO) = content.DERIVACIONES_DESTINOs.AsQueryable()

        Dim codInt As Integer = 0

        Integer.TryParse(txtCode.Text, codInt)


        If codInt > 0 Then

            query = query.Where(Function(m) m.CODIGO = codInt)

        End If


        If (Not String.IsNullOrEmpty(txtCIF.Text)) Then

            query = query.Where(Function(m) m.CIF.Contains(txtCIF.Text))

        End If

        If (Not String.IsNullOrEmpty(txtNombre.Text)) Then

            query = query.Where(Function(m) m.NOMBRE.Contains(txtNombre.Text))

        End If

        If (Not String.IsNullOrEmpty(txtPoblacion.Text)) Then

            query = query.Where(Function(m) m.POBLACION.Contains(txtPoblacion.Text))

        End If

        If (Not String.IsNullOrEmpty(txtProvincia.Text)) Then

            query = query.Where(Function(m) m.PROVINCIA.Contains(txtProvincia.Text))

        End If

        DERIVACIONES_DESTINOBindingSource.DataSource = query
    End Sub

    Private Sub Editar()
        Dim frm As New form_clinicas("Ficha de derivaciones-Modificar", Enums.Accion.Modificar, CType(DERIVACIONES_DESTINOBindingSource.Current, DERIVACIONES_DESTINO).CODIGO)
        frm.ShowDialog()
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