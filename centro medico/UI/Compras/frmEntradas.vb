Public Class frmEntradas

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Entrada As CMDataSet.N_Entradas_ResumenRow


    Private Sub frmEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            TotalDataGridViewTextBoxColumn.HeaderCell.InheritedStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.N_Entradas_ResumenTableAdapter.Fill(Me.CMDataSet.N_Entradas_Resumen)
            CalculaTotal()

            'permisos
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Lectura Then
                Me.tst_Eliminar.Enabled = False
                Me.NewToolStripButton.Enabled = False
            End If
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Modificar Then
                Me.tst_Eliminar.Enabled = True
            End If
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
                Globales.MsgboxErrorPermisoNoAutorizado()
                Me.Close()
            End If
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Total Then
                Me.tst_Eliminar.Enabled = True
                Me.NewToolStripButton.Enabled = True
            End If

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error")
        End Try

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim frm As frmEntradas_ADD = New frmEntradas_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Entradas, "Entradas", "Nuevo", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Entradas_ResumenTableAdapter.Fill(Me.CMDataSet.N_Entradas_Resumen)
            Me.N_Entradas_ResumenBindingSource.MoveLast()
            CalculaTotal()
        End If
    End Sub

    Private Sub N_EntradasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_EntradasDataGridView.SelectionChanged
        tst_Editar.Enabled = N_EntradasDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_EntradasDataGridView.SelectedRows.Count > 0



        If N_EntradasDataGridView.SelectedRows.Count > 0 Then
            Entrada = N_EntradasDataGridView.SelectedRows(0).DataBoundItem.Row

            tst_TotalSeleccionado.Text = "Total seleccionado: " & Entrada.Total
        End If
    End Sub

    Private Sub CalculaTotal()
        tst_Total.Text = "Total: " & CMDataSet.N_Entradas_Resumen.Compute("SUM(Total)", String.Empty)

    End Sub

    Private Sub N_EntradasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_EntradasDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Entrada = N_EntradasDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Entrada = N_EntradasDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmEntradas_ADD = New frmEntradas_ADD()
        frm.ID_Entrada = Entrada.ID_Entrada

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Entradas, "Entradas", frm.ID_Entrada.ToString(), "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_EntradasDataGridView.SelectedRows(0).Index
            Me.N_Entradas_ResumenTableAdapter.Fill(Me.CMDataSet.N_Entradas_Resumen)
            'MuestraTotales()
            N_EntradasDataGridView.Rows(pos).Selected = True
            CalculaTotal()
        End If
    End Sub

    Private Sub N_EntradasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_EntradasDataGridView.CellFormatting

        If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
            If Not e.Value Is DBNull.Value Then
                e.Value = CType(e.Value, Globales.Entradas_Estado)
            End If

        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Entrada = N_EntradasDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As CMDataSetTableAdapters.N_EntradasTableAdapter = New CMDataSetTableAdapters.N_EntradasTableAdapter()
        Dim n As Integer = adapter.DeleteQuery(Entrada.ID_Entrada)
        If n > 0 Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Entradas, "Entradas", Entrada.ID_Entrada.ToString(), "")

            Entrada.Delete()
            Me.N_Entradas_ResumenBindingSource.EndEdit()
            CalculaTotal()
        End If
    End Sub
End Class