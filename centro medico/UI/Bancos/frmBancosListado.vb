Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmBancosListado

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Private Shadows WithEvents GridEX1 As GridEX
    Public Banco As BANCO
    Dim context As CMLinqDataContext

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        'Dim _nuevo_banco As form_bancos = New form_bancos("Ficha bancos-Añadir", Enums.Accion.Insertar)
        '_nuevo_banco.ShowInTaskbar = False
        '_nuevo_banco.ShowDialog()
        Dim _banco As New BANCO

        Dim frm As New frmBancosEditar()
        frm.BANCOSBindingSource.DataSource = _banco
        If frm.ShowDialog() = DialogResult.OK Then
            context.BANCOs.InsertOnSubmit(_banco)
            context.SubmitChanges()
        End If

        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Eliminar()
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            Editar()
        Else
            If Not GridEX1.CurrentRow Is Nothing Then
                Banco = GridEX1.CurrentRow.DataRow
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Editar()
        'Dim _nuevo_banco As form_bancos = New form_bancos("Ficha bancos-Añadir", Enums.Accion.Modificar, CType(BANCOBindingSource.Current, BANCO).ENTIDAD, CType(BANCOBindingSource.Current, BANCO).OFICINA)
        '_nuevo_banco.ShowInTaskbar = False
        '_nuevo_banco.ShowDialog()
        Dim frm As New frmBancosEditar()
        frm.BANCOSBindingSource.DataSource = GridEX1.CurrentRow.DataRow
        frm.ShowDialog()
        context.SubmitChanges()

        PopulateGrid()
    End Sub

    Private Sub Eliminar()
        Try
            Dim content As New CMLinqDataContext
            Dim _banco As BANCO = GridEX1.CurrentRow.DataRow
            Dim ban As BANCO = (From c In content.BANCOs Where c.IdBanco = _banco.IdBanco Select c).SingleOrDefault()
            If Not ban Is Nothing Then
                content.BANCOs.DeleteOnSubmit(ban)
                content.SubmitChanges()
                PopulateGrid()
            End If

        Catch ex As Exception
            MessageBox.Show("No pudo eliminarse el banco")
        End Try

    End Sub

    Protected Overrides Sub PopulateGrid()
        Me.GridEX1.AllowEdit = InheritableBoolean.False
        context = New CMLinqDataContext

        Dim query As IQueryable(Of BANCO) = context.BANCOs.AsQueryable

        If (Not String.IsNullOrEmpty(txtNombre.Text)) Then
            query = query.Where(Function(m) m.NOMBRE.Contains(txtNombre.Text))
        End If

        If (Not String.IsNullOrEmpty(txtEntidad.Text)) Then
            query = query.Where(Function(m) m.ENTIDAD.Contains(txtEntidad.Text))
        End If

        If (Not String.IsNullOrEmpty(txtOficina.Text)) Then
            query = query.Where(Function(m) m.OFICINA.Contains(txtOficina.Text))
        End If

        If (Not String.IsNullOrEmpty(txtLocalidad.Text)) Then
            query = query.Where(Function(m) m.LOCALIDAD.Contains(txtLocalidad.Text))
        End If

        If (Not String.IsNullOrEmpty(txtProvincia.Text)) Then
            query = query.Where(Function(m) m.PROVINCIA.Contains(txtProvincia.Text))
        End If

        BANCOBindingSource.DataSource = query

        '_GridEx = GridEX1
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

    Private Sub tlbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_BANCOS"
        ds.Value = BANCOBindingSource.DataSource

        UI.Reportes.ReportesManager.Imprime("BancosListado.rdlc", {ds})


    End Sub
End Class