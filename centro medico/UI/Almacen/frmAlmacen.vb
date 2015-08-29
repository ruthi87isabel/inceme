Public Class frmAlmacen

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Almacen As CMDataSet.N_AlmacenRow
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)

        'permiso de lectura
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Ninguno Then
            Me.ToolStrip1.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Almacen) = RoleManager.TipoPermisos.Total Then
            Me.ToolStrip1.Enabled = True
            Me.NewToolStripButton.Enabled = True
            Me.tst_Eliminar.Enabled = True
        End If
        'NewToolStripButton.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Almacenes) > 2)
        'tst_Editar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Almacenes) > 2)
        'tst_Eliminar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Almacenes) > 3)

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmAlmacen_ADD = New frmAlmacen_ADD()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Almacen, "Almacen", "Nuevo", "")

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
            Me.N_AlmacenBindingSource.MoveLast()
        End If
    End Sub

    Private Sub N_AlmacenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_AlmacenDataGridView.SelectionChanged
        tst_Editar.Enabled = N_AlmacenDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_AlmacenDataGridView.SelectedRows.Count > 0
        If N_AlmacenDataGridView.SelectedRows.Count > 0 Then
            Almacen = N_AlmacenDataGridView.SelectedRows(0).DataBoundItem.Row
        End If
    End Sub

    Private Sub N_AlmacenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_AlmacenDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Almacen = N_AlmacenDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Almacen = N_AlmacenDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmAlmacen_ADD = New frmAlmacen_ADD()
        frm.ID_Almacen = Almacen.ID_Almacen
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Almacen, "Almacen", Almacen.ID_Almacen.ToString(), "")
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_AlmacenDataGridView.SelectedRows(0).Index
            Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
            N_AlmacenDataGridView.Rows(pos).Selected = True
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Almacen = N_AlmacenDataGridView.SelectedRows(0).DataBoundItem.Row
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Almacen, "Almacen", Almacen.ID_Almacen.ToString(), "")
        Almacen.Delete()
        Me.N_AlmacenBindingSource.EndEdit()
        Me.N_AlmacenTableAdapter.Update(Me.CMDataSet.N_Almacen)
    End Sub
End Class