Public Class frmUsuarios

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RolesUsuarios_ResumenTableAdapter.Fill(CMDataSet.RolesUsuarios_Resumen)

    End Sub

    Private Sub RolesUsuarios_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolesUsuarios_ResumenDataGridView.SelectionChanged
        tst_Editar.Enabled = RolesUsuarios_ResumenDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = RolesUsuarios_ResumenDataGridView.SelectedRows.Count > 0
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmUsuarios_ADD = New frmUsuarios_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Configuracion_Usuarios, "Usuarios", "Nuevo", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RolesUsuarios_ResumenTableAdapter.Fill(CMDataSet.RolesUsuarios_Resumen)
            RolesUsuarios_ResumenBindingSource.MoveLast()
        End If
    End Sub


    Private Sub RolesUsuarios_ResumenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RolesUsuarios_ResumenDataGridView.CellDoubleClick
        'Editar al usuario

        Dim codigo As Integer = RolesUsuarios_ResumenDataGridView.SelectedRows(0).Cells(0).Value

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Configuracion_Usuarios, "Usuarios", codigo.ToString(), "")

        Dim frm As frmUsuarios_ADD = New frmUsuarios_ADD()
        frm.CODIGO = codigo
        Dim index As Integer = RolesUsuarios_ResumenDataGridView.SelectedRows(0).Index

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RolesUsuarios_ResumenTableAdapter.Fill(CMDataSet.RolesUsuarios_Resumen)
            RolesUsuarios_ResumenDataGridView.Rows(index).Selected = True
        End If

    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        RolesUsuarios_ResumenDataGridView_CellDoubleClick(Nothing, Nothing)

    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click



        Dim codigo As Integer = RolesUsuarios_ResumenDataGridView.SelectedRows(0).Cells(0).Value

        Try
            Dim context As New CMLinqDataContext
            Dim calendarios As List(Of CALENDARIO_USUARIO) = (From c In context.CALENDARIO_USUARIOs Where c.ID_Usuario = codigo
                                                             Select c).ToList()

            context.CALENDARIO_USUARIOs.DeleteAllOnSubmit(calendarios)
            context.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message & vbCrLf & ex.StackTrace)
            Return
        End Try
        

        Dim adapter As CMDataSetTableAdapters.USUARIOSTableAdapter = New CMDataSetTableAdapters.USUARIOSTableAdapter()

        Dim n As Integer = adapter.DeleteById(codigo)
        If n > 0 Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Configuracion_Usuarios, "Usuarios", codigo.ToString(), "")

            RolesUsuarios_ResumenBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "dsUsuario"
        ds.Value = RolesUsuarios_ResumenDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("UsuariosListado.rdlc", {ds})

    End Sub
End Class