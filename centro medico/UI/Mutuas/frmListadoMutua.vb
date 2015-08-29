Imports Janus.Windows.GridEX

Public Class frmListadoMutua

    Dim modo As Globales.ModoParaFormas
    Public IDMUTUASELECCIONADA As Nullable(Of Integer) = Nothing

    Public Paciente As PACIENTE

    Dim context As CMLinqDataContext

    Private Shadows WithEvents GridEX1 As GridEX

    Sub New(modo As Globales.ModoParaFormas)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.modo = modo
    End Sub


    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Me.modo = Globales.ModoParaFormas.Seleccion Then
            If GridEX1.SelectedItems.Count < 1 Then
                Return
            End If
            IDMUTUASELECCIONADA = GridEX1.SelectedItems(0).GetRow.DataRow.CMUTUA
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Return
        End If
        Editar()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Dim _nueva_mutua As form_mutuas = New form_mutuas("Ficha de Mutua-Añadir", Enums.Accion.Insertar)
        _nueva_mutua.ShowInTaskbar = False
        _nueva_mutua.ShowDialog()

        'If Paciente.HasValue Then
        '    If MessageBox.Show("Desea annadir esta mutua)
        '    End If

        PopulateGrid()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            If MessageBox.Show("Desea eliminar esta mutua?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'Dim content As New CMLinqDataContext
                Dim mutua As MUTUA = MUTUABindingSource.Current
                mutua.Eliminado = True

                'content.MUTUAs.DeleteOnSubmit(content.MUTUAs.FirstOrDefault(Function(m) m.CMUTUA = CType(MUTUABindingSource.Current, MUTUA).CMUTUA))
                context.SubmitChanges()
                PopulateGrid()
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("La mutua {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(MUTUABindingSource.Current, MEDICO).NOMBRE))
        End Try
    End Sub

    Private Sub Editar()
        Dim _nueva_mutua As form_mutuas = New form_mutuas("Ficha de Mutua-Añadir", Enums.Accion.Modificar, CType(MUTUABindingSource.Current, MUTUA).CMUTUA)
        _nueva_mutua.ShowInTaskbar = False
        _nueva_mutua.ShowDialog()
        PopulateGrid()
    End Sub

    Protected Overrides Sub PopulateGrid()

        Me.GridEX1.AllowEdit = InheritableBoolean.False

        Me.context = New CMLinqDataContext


        Dim query As IQueryable(Of MUTUA) = context.MUTUAs.Where(Function(m) Not m.Eliminado.HasValue OrElse m.Eliminado = False).AsQueryable()

        If Not Paciente Is Nothing Then
            Dim lmutuas As List(Of Integer?) = (From l In context.LMUTUAs Where l.REFPACIENTE = Paciente.CPACIENTE Select l.REFMUTUA).ToList()
            query = query.Where(Function(m) lmutuas.Contains(m.CMUTUA))
            Me.Text = "Mutuas de " & Paciente.NombreCompleto
        End If

        'If mutuaDesde.Id > 0 And mutuaHasta.Id > 0 Then
        '    query = query.Where(Function(m) m.CMUTUA >= mutuaDesde.Id And m.CMUTUA <= mutuaHasta.Id)
        'End If
        If CtrlMutuaDesde.ID_MUTUA > 0 And CtrlMutuaMejoradoHasta.ID_MUTUA > 0 Then
            query = query.Where(Function(m) m.CMUTUA >= CtrlMutuaDesde.ID_MUTUA And m.CMUTUA <= CtrlMutuaMejoradoHasta.ID_MUTUA)
        End If

        If (Not String.IsNullOrEmpty(txtNombre.Text)) Then
            query = query.Where(Function(m) m.NOMBRE.Contains(txtNombre.Text))
        End If

        If (Not String.IsNullOrEmpty(txtEspecialidad.Text)) Then
            query = query.Where(Function(m) m.ESPECIALIDAD.Contains(txtEspecialidad.Text))
        End If

        If (Not String.IsNullOrEmpty(txtTelefono.Text)) Then
            query = query.Where(Function(m) m.TLFNO1.Contains(txtTelefono.Text))
        End If

        MUTUABindingSource.DataSource = query
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
        modo = Globales.ModoParaFormas.Edicion
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tlbImprimir.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_MUTUAS"
        ds.Value = MUTUABindingSource.DataSource

        UI.Reportes.ReportesManager.Imprime("MutuasListado.rdlc", {ds})

    End Sub

End Class