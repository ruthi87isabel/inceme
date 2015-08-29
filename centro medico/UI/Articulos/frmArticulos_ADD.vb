Public Class frmArticulos_ADD

    Public ID_Articulo As Long = -1
    Public Articulo As CMDataSet.N_ArticulosRow = Nothing

    Private Sub frmArticulos_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Articulos_Almacen_Resumen' table. You can move, or remove it, as needed.
        Me.N_Articulos_Almacen_ResumenTableAdapter.Fill(Me.CMDataSet.N_Articulos_Almacen_Resumen)

        Me.N_FamiliasTableAdapter.Fill(Me.CMDataSet.N_Familias)
        Me.N_TipoIVATableAdapter.Fill(Me.CMDataSet.N_TipoIVA)

        If ID_Articulo <> -1 Then
            Me.N_ArticulosTableAdapter.FillBy(Me.CMDataSet.N_Articulos, ID_Articulo)
            Articulo = Me.CMDataSet.N_Articulos(0)

            If Articulo.IsFavoritoNull Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
            End If

            'Almacenes
            Me.N_Articulos_Almacen_ResumenTableAdapter.FillBy(CMDataSet.N_Articulos_Almacen_Resumen, Articulo.ID_Articulo)

        Else
            'Crearlo Nuevo
            Articulo = N_ArticulosBindingSource.AddNew().Row()
            CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Articulos", "ID_Articulo", "000000")
            Articulo.ID_TipoArticulo = 1
            Articulo.EsEstocable = True
            combo_Familia.SelectedIndex = 0
            Combo_TipoIVA.SelectedIndex = 0
            Articulo.PrecioVentaRecomendado = 0
            Articulo.PrecioCompra = 0
            Articulo.PesoArticulo = 0
            Me.N_Articulos_Almacen_ResumenTableAdapter.Fill(Me.CMDataSet.N_Articulos_Almacen_Resumen)
        End If

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Lectura Then
            Me.btn_Guardar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Modificar Then
            Me.btn_Guardar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Articulos) = RoleManager.TipoPermisos.Total Then
            Me.btn_Guardar.Enabled = True
        End If

    End Sub


    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If CodigoTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir algun código")
            CodigoTextBox.Focus()
            Return
        End If

        Me.Validate()
        If Articulo.PrecioVentaRecomendado = Nothing Then
            Articulo.PrecioVentaRecomendado = 0.0
        End If
        Me.N_ArticulosBindingSource.EndEdit()
        If CheckBox1.Checked Then
            Me.Articulo.Favorito = 1
        Else
            Me.Articulo.SetFavoritoNull()
        End If

        Me.N_ArticulosTableAdapter.Update(Me.CMDataSet.N_Articulos)
        ID_Articulo = Articulo.ID_Articulo

        'Salvar Almacenes
        SalvarAlmacenes()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Articulos, "Articulos", Articulo.ID_Articulo.ToString(), "")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



#Region "Private Sub SalvarAlmacenes()"
    Private Sub SalvarAlmacenes()

        Dim adapter As CMDataSetTableAdapters.N_Articulos_AlmacenTableAdapter = New CMDataSetTableAdapters.N_Articulos_AlmacenTableAdapter()

        For Each gridRow As DataGridViewRow In N_Articulos_Almacen_ResumenDataGridView.Rows
            Dim row As CMDataSet.N_Articulos_Almacen_ResumenRow = gridRow.DataBoundItem.Row

            'Dim n As Integer = adapter.UpdateQuery(Articulo.ID_Articulo, row.ID_Proveedor, row.Precio, row.Descuento1, row.Descuento2, row.Descuento3, row.Resultado, row.Referencia)

            'If n = 0 Then
            'No existe, insertarlo
            adapter.Insert(Articulo.ID_Articulo, row.ID_Almacen, row.StockMinimo, row.StockMaximo)
            'End If
        Next
    End Sub
#End Region

    Private Sub pb_Almacen_Articulo_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Almacen_Articulo_ADD.Click

        Dim frm As frmAlmacen = New frmAlmacen()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("Cierre esta ventana para reflejar el nuevo almacen")
        End If

    End Sub

    Private Sub N_Articulos_Almacen_ResumenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Articulos_Almacen_ResumenDataGridView.CellDoubleClick

        Dim row As CMDataSet.N_Articulos_Almacen_ResumenRow = N_Articulos_Almacen_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim frm As frmArticulo_Almacen_ADD = New frmArticulo_Almacen_ADD()
        frm.StockMinimoTextBox.Text = row.StockMinimo
        frm.StockMaximoTextBox.Text = row.StockMaximo

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            row.StockMinimo = frm.StockMinimoTextBox.Text
            row.StockMaximo = frm.StockMaximoTextBox.Text
        End If
    End Sub
End Class