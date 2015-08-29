Imports Janus.Windows.GridEX

Public Class frmPlantillasdeTexto

    Private Shadows WithEvents GridEX1 As GridEX


    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Plantilla As PLANTILLA

    Public Sub New(Modo As Globales.ModoParaFormas)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Modo = Modo
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Insertar)
        _nueva_plantilla.ShowDialog()
        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            If GridEX1.SelectedItems.Count < 1 Then
                Return
            End If
            Dim content As New CMLinqDataContext
            'Dim _plantilla As PLANTILLA = content.PLANTILLAs.FirstOrDefault(Function(m) m.CODIGO = CType(PLANTILLABindingSource.Current, PLANTILLAANALITICA).CODIGO)
            Dim _plantilla As PLANTILLA = GridEX1.SelectedItems(0).GetRow.DataRow
            _plantilla = content.PLANTILLAs.FirstOrDefault(Function(m) m.CODIGO = _plantilla.CODIGO)
            content.PLANTILLAs.DeleteOnSubmit(_plantilla)
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("La plantilla de texto {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(PLANTILLABindingSource.Current, PLANTILLAANALITICA).DESCRIPCION))
        End Try
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            Editar()
        Else
            Dim item As Object = e.Row.DataRow
            Plantilla = item
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub



    Protected Overrides Sub PopulateGrid()
        Me.GridEX1.AllowEdit = InheritableBoolean.False
        GridEX1.DataSource = Nothing

        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of PLANTILLA) = content.PLANTILLAs.AsQueryable()

        Dim codInt As Integer = 0

        Integer.TryParse(txtCode.Text, codInt)

        If codInt > 0 Then
            query = query.Where(Function(m) m.CODIGO = codInt)
        End If

        If (Not String.IsNullOrEmpty(txtDescripcion.Text)) Then
            query = query.Where(Function(m) m.DESCRIPCION.Contains(txtDescripcion.Text))
        End If

        PLANTILLABindingSource.DataSource = query
        GridEX1.DataSource = PLANTILLABindingSource
        '_GridEx = GridEX1
    End Sub

    Private Sub Editar()
        If GridEX1.SelectedItems.Count < 1 Then
            Return
        End If
        'Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Modificar, CType(PLANTILLABindingSource.Current, PLANTILLA).CODIGO)
        Dim _nueva_plantilla As form_plantilla_texto = New form_plantilla_texto("Plantilla de texto", Enums.Accion.Modificar, CType(PLANTILLABindingSource.Current, PLANTILLA).CODIGO)
        _nueva_plantilla.ShowDialog()
        PopulateGrid()
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

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_PLANTILLAS"
        ds.Value = GridEX1.DataSource

        UI.Reportes.ReportesManager.Imprime("PlantillaTextosListado.rdlc", {ds})
    End Sub
End Class