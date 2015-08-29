Public Class frmPoblaciones

    Public Poblacion As CMDataSet.N_PoblacionesFULLRow
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Seleccion

    Private Sub frmPoblaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Poblaciones) = RoleManager.TipoPermisos.Total Then
            Me.tst_Eliminar.Enabled = True
            Me.NewToolStripButton.Enabled = True
        End If
        'TODO: This line of code loads data into the 'CMDataSet.N_PoblacionesFULL' table. You can move, or remove it, as needed.
        'Me.N_PoblacionesFULLTableAdapter.Connection.ConnectionString = My.Settings.FontanalsBDConnectionString
        Me.N_PoblacionesFULLTableAdapter.Fill(Me.CMDataSet.N_PoblacionesFULL)

        NewToolStripButton.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)
        tst_Editar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)
        tst_Eliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 3)

    End Sub


    Private Sub N_PoblacionesFULLDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_PoblacionesFULLDataGridView.SelectionChanged
        tst_Editar.Enabled = N_PoblacionesFULLDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_PoblacionesFULLDataGridView.SelectedRows.Count > 0
    End Sub

    Private Sub N_PoblacionesFULLDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_PoblacionesFULLDataGridView.CellDoubleClick

        Poblacion = CMDataSet.N_PoblacionesFULL.FindByID_Poblacion(N_PoblacionesFULLDataGridView.SelectedRows(0).DataBoundItem.Row.ID_Poblacion)
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmPoblaciones_ADD = New frmPoblaciones_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_PoblacionesFULLTableAdapter.Fill(Me.CMDataSet.N_PoblacionesFULL)
            Dim pos As Integer = Me.N_PoblacionesFULLBindingSource.Find("Nombre", frm.Poblacion.Nombre)
            Me.N_PoblacionesFULLBindingSource.Position = pos
        End If

    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Poblacion = CMDataSet.N_PoblacionesFULL.FindByID_Poblacion(N_PoblacionesFULLDataGridView.SelectedRows(0).DataBoundItem.Row.ID_Poblacion)

        Dim frm As frmPoblaciones_ADD = New frmPoblaciones_ADD()
        frm.ID_Poblacion = Poblacion.ID_Poblacion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Poblacion.Nombre = frm.Poblacion.Nombre
            Poblacion.ID_Provincia = frm.Poblacion.ID_Provincia
            Poblacion.Provincia = frm.N_ProvinciasComboBox.SelectedItem.Row.Nombre
        End If
        Me.ValidateChildren()
    End Sub


    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If Me.N_PoblacionesFULLDataGridView.SelectedRows.Count > 0 Then
            Poblacion = CMDataSet.N_PoblacionesFULL.FindByID_Poblacion(N_PoblacionesFULLDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value)

            Dim adapter As CMDataSetTableAdapters.N_PoblacionesTableAdapter = New CMDataSetTableAdapters.N_PoblacionesTableAdapter()
            Dim n As Integer = adapter.DeleteQuery(Poblacion.ID_Poblacion)
            If n > 0 Then
                Poblacion.Delete()
            End If
        End If
    End Sub

    Private Sub tst_Nombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Nombre.KeyUp
        Filtrar("Nombre like '" & tst_Nombre.Text & "%' and Provincia like '" & tst_Provincia.Text & "%'")
    End Sub

    Private Sub tst_Provincia_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Provincia.KeyUp
        Filtrar("Nombre like '" & tst_Nombre.Text & "%' and Provincia like '" & tst_Provincia.Text & "%'")
    End Sub

    Private Sub Filtrar(ByVal filter As String)
        Try
            Dim dw As DataView = Me.CMDataSet.N_PoblacionesFULL.DefaultView
            dw.RowFilter = filter
            dw.RowStateFilter = DataViewRowState.CurrentRows
            N_PoblacionesFULLDataGridView.DataSource = dw
            N_PoblacionesFULLDataGridView.Update()
        Catch ex As Exception

        End Try

    End Sub


End Class