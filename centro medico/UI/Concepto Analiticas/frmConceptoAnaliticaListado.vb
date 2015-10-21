Imports Janus.Windows.GridEX

Public Class frmConceptoAnaliticaListado

    Public Id As Integer = 0
    Public Shadows WithEvents GridEx1 As GridEX
    Dim ts As New Threading.ThreadStart(AddressOf PreparaImpresion)
    Dim threadPrint As New System.Threading.Thread(ts)
    Dim lista As New List(Of WRAPPER_ANALITICA)

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
        If GridEx1.SelectedItems.Count > 0 And Id = 0 Then
            Id = GridEx1.SelectedItems(0).GetRow().DataRow.CODIGO
        End If

    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Editar()
    End Sub

    Private Sub Editar()

        Dim frm As New form_concepto_analitica("Ficha de Conceptos Analíticos-Modificar", Enums.Accion.Modificar, CType(CONCEPTOSANALITICABindingSource.Current, CONCEPTOSANALITICA).CODIGO)
        Id = GridEx1.SelectedItems(0).GetRow().DataRow.CODIGO

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

        Dim i As Integer

        For i = 0 To GridEx1.RowCount - 1
            Dim stilo As New GridEXFormatStyle
            Dim col As String = GridEx1.GetRow(i).DataRow.COLOR
            Dim readcolor As Color = ColorTranslator.FromHtml(col)
            stilo.BackColor = readcolor
            GridEx1.GetRow(i).RowStyle() = stilo

            If GridEx1.GetRow(i).DataRow.CODIGO = Id Then
                GridEx1.MoveTo(i)
            End If
        Next

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

    Private Sub PreparaImpresion()

        lista.Clear()
        Dim contex As New CMLinqDataContext()
        Dim count As Integer = 1
        Try

            For Each row As GridEXRow In GridEX1.GetDataRows
                If row.IsVisible Then
                    Dim cod As Integer = row.DataRow.CODIGO
                    Dim analitica As CONCEPTOSANALITICA = (From p In contex.CONCEPTOSANALITICAs Where p.CODIGO = cod Select p).SingleOrDefault
                    analitica.IMPORTE = row.DataRow.IMPORTE

                    lista.Add(New WRAPPER_ANALITICA(analitica))
                    GridEX1.BeginInvoke(New BeginInvokeDelegate2(AddressOf Progreso), New Object() {"Procesando... " & count & "/" & GridEX1.RowCount})
                    count = count + 1
                End If
            Next
        Catch ex As Exception

        End Try
        GridEX1.BeginInvoke(New BeginInvokeDelegate(AddressOf Imprimir))
    End Sub

    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
        pnl_Loading.Enabled = Not enabled
        lnkCancelar.Enabled = Not enabled
    End Sub

    Delegate Sub BeginInvokeDelegate()
    Delegate Sub BeginInvokeDelegate2(ByVal msg As String)
    Delegate Sub BeginInvokeDelegate3(ByVal enabled As Boolean)

    Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked
        Try
            threadPrint.Abort()
        Catch ex As Exception

        Finally
            GridEX1.BeginInvoke(New BeginInvokeDelegate3(AddressOf SetEnabled), New Object() {True})
            GridEX1.BeginInvoke(New BeginInvokeDelegate(AddressOf GridEX1.Update))
            'SetEnabled(True)
            pnl_Loading.Visible = False
        End Try
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        pnl_Loading.Visible = True
        lbl_Loading.Text = "Procesando..."
        SetEnabled(False)
        threadPrint = New Threading.Thread(ts)
        threadPrint.Start()
    End Sub

    Private Sub Progreso(ByVal msg As String)
        lbl_Loading.Text = msg
    End Sub

    Private Sub Imprimir()

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_CONCEPTOSANALITICA"
        ds.Value = lista

        SetEnabled(True)
        pnl_Loading.Visible = False
        lbl_Loading.Text = "Preparando..."

        UI.Reportes.ReportesManager.Imprime("ConceptosAnaliticasListado.rdlc", {ds})

    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnl_Loading.Visible = True
        lbl_Loading.Text = "Procesando..."
        SetEnabled(False)
        threadPrint = New Threading.Thread(ts)
        threadPrint.Start()
    End Sub

    Private Sub Ordenar(sender As Object, e As EventArgs) Handles GridEx1.SortKeysChanged

        Dim i As Integer
        For i = 0 To GridEx1.RowCount - 1
            Dim stilo As New GridEXFormatStyle
            Dim col As String = GridEx1.GetRow(i).DataRow.COLOR
            Dim readcolor As Color = ColorTranslator.FromHtml(col)
            stilo.BackColor = readcolor
            GridEx1.GetRow(i).RowStyle() = stilo

            If GridEx1.GetRow(i).DataRow.CODIGO = Id Then
                GridEx1.MoveTo(i)
            End If

        Next

    End Sub
End Class