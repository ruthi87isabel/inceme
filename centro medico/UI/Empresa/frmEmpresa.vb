Imports Janus.Windows.GridEX

Public Class frmEmpresa

    Public Shadows WithEvents GridEX1 As GridEX
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Empresa As EMPRESA
    Dim context As CMLinqDataContext


    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            Editar()
        Else
            If Not EMPRESABindingSource.Current Is Nothing Then
                Empresa = EMPRESABindingSource.Current
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Overloads Sub PopulateGrid()
        context = New CMLinqDataContext()
        Try

            Dim query As IQueryable(Of EMPRESA) = context.EMPRESAs.Where(Function(k) k.Eliminado.HasValue And k.Eliminado = False).AsQueryable()

            If Not String.IsNullOrEmpty(txtCodigoDesde.Text) And Not String.IsNullOrEmpty(txtCodigoHasta.Text) Then
                query = query.Where(Function(e) e.CEMPRESA >= Integer.Parse(txtCodigoDesde.Text) And e.CEMPRESA <= Integer.Parse(txtCodigoHasta.Text))
            End If

            If (Not String.IsNullOrEmpty(txtNombre.Text)) Then
                query = query.Where(Function(m) m.NOMBRE.Contains(txtNombre.Text))
            End If

            EMPRESABindingSource.DataSource = query

        Catch ex As Exception

        End Try

        '_GridEx = GridEX1
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim _nueva_empresa As form_empresa = New form_empresa("Ficha de empresa-Añadir", Enums.Accion.Insertar)
        _nueva_empresa.ShowInTaskbar = False
        _nueva_empresa.ShowDialog()
        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar esta empresa?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim empresa As EMPRESA = EMPRESABindingSource.Current
            empresa.Eliminado = True
            context.SubmitChanges()
            PopulateGrid()
        End If

    End Sub

    Private Sub Editar()
        Dim _nueva_empresa As form_empresa = New form_empresa("Ficha de empresa-Añadir", Enums.Accion.Modificar, CType(EMPRESABindingSource.Current, EMPRESA).CEMPRESA)
        _nueva_empresa.ShowInTaskbar = False
        _nueva_empresa.ShowDialog()
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

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

  
    Private Sub frmEmpresa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PopulateGrid()
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click

    End Sub
End Class