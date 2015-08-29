Public Class frmComoConocio

    '  Public Poblacion As CMDataSet.N_PoblacionesFULLRow
    Public ComoConocio As CMDataSet.ComoConocioRow
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Seleccion

    Private Sub frmComoconocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ComoConocio) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
            Me.NewToolStripButton.Enabled = True
        End If
        'TODO: This line of code loads data into the 'CMDataSet.N_PoblacionesFULL' table. You can move, or remove it, as needed.
        'Me.N_PoblacionesFULLTableAdapter.Connection.ConnectionString = My.Settings.FontanalsBDConnectionString
        '   Me.N_PoblacionesFULLTableAdapter.Fill(Me.CMDataSet.N_PoblacionesFULL)
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.ComoConocio' Puede moverla o quitarla según sea necesario.
        Me.ComoConocioTableAdapter.Fill(Me.CMDataSet.ComoConocio)
        NewToolStripButton.Visible = (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) > 2)
        tst_Editar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) > 2)
        tst_Eliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.ComoConocio) > 3)

    End Sub


    Private Sub N_PoblacionesFULLDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_comoconocio.SelectionChanged
        tst_Editar.Enabled = dtg_comoconocio.SelectedRows.Count > 0
        tst_Eliminar.Enabled = dtg_comoconocio.SelectedRows.Count > 0
    End Sub

    Private Sub ComoconocioDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_comoconocio.CellDoubleClick, dtg_comoconocio.CellContentDoubleClick

        'ComoConocio = CMDataSet.N_PoblacionesFULL.FindByID_Poblacion(dtg_comoconocio.SelectedRows(0).DataBoundItem.Row.ID_Poblacion)
        ComoConocio = CMDataSet.ComoConocio.FindByIDConocio(dtg_comoconocio.SelectedRows(0).DataBoundItem.Row.IDConocio)
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmComoConocio_ADD = New frmComoConocio_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Me.N_PoblacionesFULLTableAdapter.Fill(Me.CMDataSet.N_PoblacionesFULL)
            Me.ComoConocioTableAdapter.Fill(Me.CMDataSet.ComoConocio)
            'Dim pos As Integer = Me.N_PoblacionesFULLBindingSource.Find("Nombre", frm.Poblacion.Nombre)
            Dim pos As Integer = Me.ComoConocioBindingSource.Find("Descripcion", frm.ComoConocio.Descripcion)
            'Me.N_PoblacionesFULLBindingSource.Position = pos
            Me.ComoConocioBindingSource.Position = pos
        End If

    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        ComoConocio = CMDataSet.ComoConocio.FindByIDConocio(dtg_comoconocio.SelectedRows(0).DataBoundItem.Row.IDConocio)
        Dim frm As frmComoConocio_ADD = New frmComoConocio_ADD()
        frm.IDConocio = ComoConocio.IDConocio
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'ComoConocio.IDConocio = frm.ComoConocio.IDConocio
            ComoConocio.Descripcion = frm.ComoConocio.Descripcion
        End If
        Me.ValidateChildren()
    End Sub


    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        'If Me.dtg_comoconocio.SelectedRows.Count > 0 Then
        '    Poblacion = CMDataSet.N_PoblacionesFULL.FindByID_Poblacion(dtg_comoconocio.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value)

        'Dim adapter2 As CMDataSetTableAdapters.N_PoblacionesTableAdapter = New CMDataSetTableAdapters.N_PoblacionesTableAdapter()
        'Dim n2 As Integer = adapter2.DeleteQuery() DeleteQuery(Poblacion.ID_Poblacion)
        '    If n > 0 Then
        '        Poblacion.Delete()
        '    End If
        'End If

        If Me.dtg_comoconocio.SelectedRows.Count > 0 Then
            ComoConocio = CMDataSet.ComoConocio.FindByIDConocio(dtg_comoconocio.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value)
            Dim adapter As CMDataSetTableAdapters.ComoConocioTableAdapter = New CMDataSetTableAdapters.ComoConocioTableAdapter
            Dim n As Integer = adapter.DeleteQuery(ComoConocio.IDConocio)
            If n > 0 Then
                ComoConocio.Delete()
            End If
        End If
    End Sub

    Private Sub tst_Descripcion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Descripcion.KeyUp
        Filtrar("Descripcion like '%" & tst_Descripcion.Text & "%'")
    End Sub



    Private Sub Filtrar(ByVal filter As String)
        Try
            'Dim dw As DataView = Me.CMDataSet.N_PoblacionesFULL.DefaultView
            Dim dw As DataView = Me.CMDataSet.ComoConocio.DefaultView
            dw.RowFilter = filter
            dw.RowStateFilter = DataViewRowState.CurrentRows
            dtg_comoconocio.DataSource = dw
            dtg_comoconocio.Update()
        Catch ex As Exception

        End Try

    End Sub


End Class