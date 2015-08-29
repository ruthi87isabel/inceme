Public Class frmConceptosFRA


    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Seleccion
    Public ConceptosFRA As CMDataSet.CONCEPTOSFRARow


    Private Sub frmConceptosFRA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CONCEPTOSFRATableAdapter.Fill(Me.CMDataSet.CONCEPTOSFRA)

        'permiso de lectura
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Ninguno Then
            Me.ToolStrip1.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables) = RoleManager.TipoPermisos.Total Then
            Me.ToolStrip1.Enabled = True
            Me.NewToolStripButton.Enabled = True
            Me.tst_Eliminar.Enabled = True
        End If


    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Dim frm As frmAlmacen_ADD = New frmAlmacen_ADD()
        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Me.CONCEPTOSFRATableAdapter.Fill(Me.CMDataSet.CONCEPTOSFRA)
        '    Me.CONCEPTOSFRABindingSource.MoveLast()
        'End If
    End Sub

    Private Sub N_AlmacenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONCEPTOSFRADataGridView.SelectionChanged
        tst_Editar.Enabled = CONCEPTOSFRADataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = CONCEPTOSFRADataGridView.SelectedRows.Count > 0
        If CONCEPTOSFRADataGridView.SelectedRows.Count > 0 Then
            ConceptosFRA = CONCEPTOSFRADataGridView.SelectedRows(0).DataBoundItem.Row
        End If
    End Sub

    Private Sub N_AlmacenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONCEPTOSFRADataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            ConceptosFRA = CONCEPTOSFRADataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        ConceptosFRA = CONCEPTOSFRADataGridView.SelectedRows(0).DataBoundItem.Row
        'Dim frm As frmAlmacen_ADD = New frmAlmacen_ADD()
        'frm.ID_Almacen = Almacen.ID_Almacen
        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Dim pos As Integer = N_AlmacenDataGridView.SelectedRows(0).Index
        '    Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
        '    N_AlmacenDataGridView.Rows(pos).Selected = True
        'End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        ConceptosFRA = CONCEPTOSFRADataGridView.SelectedRows(0).DataBoundItem.Row
        ConceptosFRA.Delete()
        Me.CONCEPTOSFRABindingSource.EndEdit()
        Me.CONCEPTOSFRATableAdapter.Update(Me.CMDataSet.CONCEPTOSFRA)
    End Sub
End Class