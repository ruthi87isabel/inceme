Imports Janus.Windows.GridEX

Public Class frmGastosListados

    Private Shadows WithEvents GridEX1 As GridEX

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim _nuevo_gasto As form_gastos = New form_gastos("Gastos", Enums.Accion.Insertar)
        _nuevo_gasto.ShowInTaskbar = False
        _nuevo_gasto.ShowDialog()
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
        Editar()
    End Sub

    Private Sub Editar()
        Dim nuevoGasto As form_gastos = New form_gastos("Gastos", Enums.Accion.Modificar, CType(GASTOBindingSource.Current, GASTO).IDGASTO)
        nuevoGasto.ShowInTaskbar = False
        nuevoGasto.ShowDialog()
        PopulateGrid()
    End Sub

    Private Sub Eliminar()
        Try
            Dim content As New CMLinqDataContext
            content.GASTOs.DeleteOnSubmit(content.GASTOs.FirstOrDefault(Function(g) g.IDGASTO = CType(GASTOBindingSource.Current, GASTO).IDGASTO))
            content.SubmitChanges()
            PopulateGrid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PopulateGrid()


        Me.GridEX1.AllowEdit = InheritableBoolean.False
        
        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of GASTO) = content.GASTOs.AsQueryable

        If (Not String.IsNullOrEmpty(txtConcepto.Text)) Then
            query = query.Where(Function(m) m.CONCEPTO.Contains(txtConcepto.Text))
        End If

        Dim importe As Integer = 0

        If (Not String.IsNullOrEmpty(txtImporte.Text)) Then
            Integer.TryParse(txtImporte.Text, importe)
        End If

        query = query.Where(Function(m) IIf(m.IMPORTE.HasValue, m.IMPORTE.Value >= importe, True))


        If (Not txtFechaHasta.IsNullDate) Then
            query = query.Where(Function(m) m.FECHA <= txtFechaHasta.Value)
        End If

        If (Not txtFechaDesde.IsNullDate) Then
            query = query.Where(Function(m) m.FECHA >= txtFechaDesde.Value)
        End If

        GASTOBindingSource.DataSource = query

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
        Me.txtFechaDesde.Value = New Date(Date.Now.Year, Date.Now.Month, 1, 0, 0, 0, 0)
        Me.txtFechaHasta.Value = New Date(Date.Now.Year, Date.Now.Month, 1, 0, 0, 0, 0).AddMonths(1).AddDays(-1)

    End Sub

    Private Sub frmGastosListados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateGrid()
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_GASTOS"
        ds.Value = GASTOBindingSource.DataSource

        UI.Reportes.ReportesManager.Imprime("GastosListado.rdlc", {ds})

    End Sub
End Class