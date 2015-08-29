Imports Janus.Windows.GridEX

Public Class frmConceptoAnaliticaListado

    Public Shadows WithEvents GridEx1 As GridEX

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New form_concepto_analitica("Ficha de Conceptos Analíticos-Añadir", Enums.Accion.Insertar)
        frm.ShowDialog()
        PopulateGrid()

    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            content.CONCEPTOSANALITICAs.DeleteOnSubmit(content.CONCEPTOSANALITICAs.FirstOrDefault(Function(m) m.CODIGO = CType(CONCEPTOSANALITICABindingSource.Current, CONCEPTOSANALITICA).CODIGO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("El concepto analítico {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(CONCEPTOSANALITICABindingSource.Current, CONCEPTOSANALITICA).CONCEPTO))
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

        Dim frm As New form_concepto_analitica("Ficha de Conceptos Analíticos-Modificar", Enums.Accion.Modificar, CType(CONCEPTOSANALITICABindingSource.Current, CONCEPTOSANALITICA).CODIGO)

        frm.ShowDialog()

        PopulateGrid()


    End Sub

    Protected Overrides Sub PopulateGrid()
        Me.GridEX1.AllowEdit = InheritableBoolean.False

        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of CONCEPTOSANALITICA) = content.CONCEPTOSANALITICAs.AsQueryable()

        Dim codInt As Integer = 0

        Integer.TryParse(txtCodeDesde.Text, codInt)


        If codInt > 0 Then

            query = query.Where(Function(m) m.CODIGO = codInt)

        End If


        If (Not String.IsNullOrEmpty(txtConcepto.Text)) Then

            query = query.Where(Function(m) m.CONCEPTO.Contains(txtConcepto.Text))

        End If


        Dim stockInt As Integer

        Integer.TryParse(txtImporte.Text, stockInt)

        If (stockInt > 0) Then query = query.Where(Function(m) m.IMPORTE <= stockInt)

        CONCEPTOSANALITICABindingSource.DataSource = query

        '_GridEx = GridEX1
        'aplicamos permiso para no visualizar importes
        Me.txtImporte.Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)
        GridEx1.RootTable.Columns("Importe").Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)

    End Sub

    Private Sub btnConfigGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigGrid.Click
        Configure()
    End Sub

    Public Overridable Sub Configure()

        Dim frmConfig As New frmConfiguracionColumnasJanusGridEx()
        frmConfig.Columnas = Me.OriginalColumns
        frmConfig.RootTable = Me.GridEX1.RootTable

        If (frmConfig.ShowDialog() = DialogResult.OK) Then
            Me.GridEX1.RootTable = frmConfig.RootTable
            PopulateGrid()
        End If

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        MyBase.InitializeComponent()

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each cExt As GridEXColumn In GridEX1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next
    End Sub
End Class