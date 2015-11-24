Imports Janus.Windows.GridEX

Public Class frmPlantillaAnalitica

    Private Shadows WithEvents GridEX1 As GridEX

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New form_plantilla__analiticas("Ficha de Forma de Pago-Añadir", Enums.Accion.Insertar)
        frm.ShowDialog()
        'frm.DialogResult.ToString()
        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            content.PLANTILLAANALITICAs.DeleteOnSubmit(content.PLANTILLAANALITICAs.FirstOrDefault(Function(m) m.CODIGO = CType(PLANTILLAANALITICABindingSource.Current, PLANTILLAANALITICA).CODIGO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("La plantilla analítico {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(PLANTILLAANALITICABindingSource.Current, PLANTILLAANALITICA).DESCRIPCION))
        End Try
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Editar()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs)
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    
    Protected Overrides Sub PopulateGrid()

        Me.GridEX1.AllowEdit = InheritableBoolean.False

        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of PLANTILLAANALITICA) = content.PLANTILLAANALITICAs.AsQueryable()

        Dim codInt As Integer = 0

        Integer.TryParse(txtCode.Text, codInt)


        If codInt > 0 Then

            query = query.Where(Function(m) m.CODIGO = codInt)

        End If


        If (Not String.IsNullOrEmpty(txtDescripcion.Text)) Then

            query = query.Where(Function(m) m.DESCRIPCION.Contains(txtDescripcion.Text))

        End If

        PLANTILLAANALITICABindingSource.DataSource = query

        '_GridEx = GridEX1
    End Sub

    Private Sub Editar()

        Dim frm As New form_plantilla__analiticas("Ficha de Forma de Pago-Modificar", Enums.Accion.Modificar, CType(PLANTILLAANALITICABindingSource.Current, PLANTILLAANALITICA).CODIGO)
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
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Modificar Or RoleManager.TipoPermisos.Modificar And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Total Then
            Me.tst_Editar.Enabled = True
            Me.tst_Eliminar.Enabled = True
        Else
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Lectura Or RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Plantillas_para_Analiticas) = RoleManager.TipoPermisos.Ninguno Then
                Me.tst_Editar.Enabled = False
                Me.tst_Eliminar.Enabled = False
            End If
        End If
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "dsPlantillaAnalitica"
        ds.Value = GridEX1.DataSource

        UI.Reportes.ReportesManager.Imprime("PlantillasAnaliticasListado.rdlc", {ds})
    End Sub


    
End Class