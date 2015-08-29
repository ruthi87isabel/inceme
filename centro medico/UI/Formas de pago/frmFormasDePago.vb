Imports Janus.Windows.GridEX

Public Class frmFormasDePago

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public FormaPago As FORMASPAGO = Nothing

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New form_formas_pago("Ficha de Forma de Pago-Añadir", Enums.Accion.Insertar)
        frm.ShowDialog()
        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            content.FORMASPAGOs.DeleteOnSubmit(content.FORMASPAGOs.FirstOrDefault(Function(m) m.CODIGO = CType(FORMASPAGOBindingSource.Current, FORMASPAGO).CODIGO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("El concepto analítico {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(FORMASPAGOBindingSource.Current, FORMASPAGO).DESCRIPCION))
        End Try
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            Editar()
        Else
            If GridEX1.SelectedItems.Count > 0 Then
                FormaPago = GridEX1.SelectedItems(0).GetRow().DataRow
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
            
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Protected Overrides Sub PopulateGrid()
        Me.GridEX1.AllowEdit = InheritableBoolean.False
        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of FORMASPAGO) = content.FORMASPAGOs.AsQueryable()

        Dim codInt As Integer = 0

        Integer.TryParse(txtCodigo.Text, codInt)


        If codInt > 0 Then

            query = query.Where(Function(m) m.CODIGO = codInt)

        End If


        If (Not String.IsNullOrEmpty(txt_Descipcion.Text)) Then

            query = query.Where(Function(m) m.DESCRIPCION.Contains(txt_Descipcion.Text))

        End If

        FORMASPAGOBindingSource.DataSource = query

        '_GridEx = GridEX1
    End Sub

    Private Sub Editar()

        Dim frm As New form_formas_pago("Ficha de Forma de Pago-Modificar", Enums.Accion.Modificar, CType(FORMASPAGOBindingSource.Current, FORMASPAGO).CODIGO)
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