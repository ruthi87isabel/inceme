Public Class frmEntradas_Lineas_ADD

    Public ID_Entrada As Long = -1
    Public ID_Entrada_Linea As Long = -1

    Private Expanded As Boolean = False
    Private sizeToExpand As Integer = 240


    Public Entrada_Linea As CMDataSet.N_Entradas_LineasRow = Nothing

    Private Sub pb_SeleccionarArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SeleccionarArticulo.Click
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Entrada_Linea.ID_Articulo = frm.Articulo.ID_Articulo
            Entrada_Linea.Codigo = frm.Articulo.Codigo
            CodigoTextBox.Text = frm.Articulo.Codigo
            DescripcionTextBox.Text = frm.Articulo.DescripcionGeneral
            PrecioTextBox.Text = frm.Articulo.PrecioCompra
            If Not frm.Articulo.IsImagenNull Then
                Entrada_Linea.Imagen = frm.Articulo.Imagen
            End If

        End If
    End Sub

    Private Sub frmEntradas_Lineas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Almacen' table. You can move, or remove it, as needed.
        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
        'TODO: This line of code loads data into the 'CMDataSet.N_TipoIVA' table. You can move, or remove it, as needed.
        Me.N_TipoIVATableAdapter.Fill(Me.CMDataSet.N_TipoIVA)

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Lectura Then
            Me.btn_Guardar.Enabled = False

        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Modificar Then
            Me.btn_Guardar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Total Then
            Me.btn_Guardar.Enabled = True
        End If

        If ID_Entrada = -1 Then
            MessageBox.Show("Debe especificar un Entrada")
            Me.Close()
            Return
        End If

        If ID_Entrada_Linea <> -1 Then
            Me.N_Entradas_LineasTableAdapter.FillBy(Me.CMDataSet.N_Entradas_Lineas, ID_Entrada, ID_Entrada_Linea)
            Entrada_Linea = Me.CMDataSet.N_Entradas_Lineas(0)

            'Cargar Lotes
            'N_Entradas_LotesTableAdapter.Fill(CMDataSet.N_Entradas_Lotes, Entrada_Linea.ID_EntradaLineas)
        Else
            'Crearlo Nuevo
            Entrada_Linea = N_Entradas_LineasBindingSource.AddNew().Row()
            Entrada_Linea.ID_Entrada = ID_Entrada
            N_TipoIVAComboBox.SelectedIndex = 0
            N_AlmacenComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If DescripcionTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir alguna descripci�n")
            DescripcionTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.N_Entradas_LineasBindingSource.EndEdit()
        Me.N_Entradas_LineasTableAdapter.Update(Me.CMDataSet.N_Entradas_Lineas)

        'Aqui insertar los totales
        Dim tipoIva As CMDataSet.N_TipoIVARow = N_TipoIVAComboBox.SelectedItem.Row

        Dim total As CMDataSet.N_Entradas_TotalesRow = CMDataSet.N_Entradas_Totales.NewN_Entradas_TotalesRow()
        total.DescuentoCantidad = 0
        total.DescuentoPorciento = 0
        total.FinanciacionCantidad = 0
        total.FinanciacionPorciento = 0
        total.ID_Entrada = ID_Entrada
        total.ID_TipoIVA = tipoIva.ID_TipoIVA
        total.ImporteNeto = 0
        total.IVACantidad = 0
        total.IVAPorciento = tipoIva.Valor
        total.PortesCantidad = 0
        total.PortesPorciento = 0
        total.ProntoPagoCantidad = 0
        total.ProntoPagoPorciento = 0
        total.RECantidad = 0
        total.REPorciento = 0
        total.SubTotal = 0

        CMDataSet.N_Entradas_Totales.AddN_Entradas_TotalesRow(total)

        Dim totalAdapter As New CMDataSetTableAdapters.N_Entradas_TotalesTableAdapter()
        Try
            totalAdapter.Update(CMDataSet.N_Entradas_Totales)
        Catch ex As Exception
        End Try

        'Salvar los lotes
        ' Me.N_Entradas_LotesBindingSource.EndEdit()

        'For Each row As DataGridViewRow In N_Entradas_LotesDataGridView.Rows
        '    Dim lote As CMDataSet.N_Entradas_LotesRow = row.DataBoundItem.Row()
        '    lote.ID_Entrada_Linea = Entrada_Linea.ID_EntradaLineas
        'Next

        ' Me.N_Entradas_LotesTableAdapter.Update(Me.CMDataSet.N_Entradas_Lotes)
     
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pb_Articulo_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Articulo_Delete.Click
        Entrada_Linea.SetID_ArticuloNull()
        CodigoTextBox.Text = ""
    End Sub

    Private Sub CantidadTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalTextBox.KeyUp, PrecioTextBox.KeyUp, Descuento3TextBox.KeyUp, Descuento2TextBox.KeyUp, Descuento1TextBox.KeyUp, CantidadTextBox.KeyUp
        CalculaTotal()
    End Sub

#Region "Private Sub CalculaTotal()"
    Private Sub CalculaTotal()
        Dim precio As Double = 0
        Dim cantidad As Double = 0
        Dim dto1 As Double = 0
        Dim dto2 As Double = 0
        Dim dto3 As Double = 0
        Try
            precio = Double.Parse(PrecioTextBox.Text)
            cantidad = Double.Parse(CantidadTextBox.Text)
            dto1 = Double.Parse(Descuento1TextBox.Text)
            dto2 = Double.Parse(Descuento2TextBox.Text)
            dto3 = Double.Parse(Descuento3TextBox.Text)

        Catch ex As Exception

        End Try

        'Dim total = cantidad * precio
        'total = total - (dto1 / 100) * total
        'total = total - (dto2 / 100) * total
        'total = total - (dto3 / 100) * total
        'TotalTextBox.Text = total

        TotalTextBox.Text = precio * cantidad * (1 - dto1 / 100) * (1 - dto2 / 100) * (1 - dto3 / 100)
    End Sub
#End Region

#Region "Private Sub CalculaCantidadDeTotal()"
    Private Sub CalculaCantidadDeTotal()

        Dim total As Double = 0

        Dim precio As Double = 0
        Dim dto1 As Double = 0
        Dim dto2 As Double = 0
        Dim dto3 As Double = 0
        Try
            total = Double.Parse(TotalTextBox.Text)
            precio = Double.Parse(PrecioTextBox.Text)
            dto1 = Double.Parse(Descuento1TextBox.Text)
            dto2 = Double.Parse(Descuento2TextBox.Text)
            dto3 = Double.Parse(Descuento3TextBox.Text)

        Catch ex As Exception
        End Try
        Dim cantidad = total / (precio * (1 - dto1 / 100) * (1 - dto2 / 100) * (1 - dto3 / 100))
        CantidadTextBox.Text = cantidad
    End Sub
#End Region


    Private Sub TotalTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CalculaCantidadDeTotal()
    End Sub

    Private Sub btn_Detalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Detalles.Click
        If Expanded Then
            Me.Height = Me.Height - sizeToExpand
            Expanded = False
            'btn_Detalles.Image = My.Resources.Resources._24_em_down
        Else
            Me.Height = Me.Height + sizeToExpand
            Expanded = True
            'btn_Detalles.Image = My.Resources.Resources._24_em_up
        End If
    End Sub

    Private Sub btn_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imagen.Click
        'Dim frm As frmVisorImagenes = New frmVisorImagenes()
        'If Not Entrada_Linea.IsImagenNull Then
        '    frm.Image = Image.FromStream(New System.IO.MemoryStream(Entrada_Linea.Imagen))
        'End If
    End Sub


    Private Sub pb_NuevaSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim nuevo As CMDataSet.N_Entradas_LotesRow = Me.N_Entradas_LotesBindingSource.AddNew().Row
        'nuevo.ID_Entrada_Linea = 0
        'nuevo.BeginEdit()
    End Sub

    Private Function CargaArticulo() As CMDataSet.N_ArticulosRow
        Dim adapter As CMDataSetTableAdapters.N_ArticulosTableAdapter = New CMDataSetTableAdapters.N_ArticulosTableAdapter()
        Dim table As CMDataSet.N_ArticulosDataTable = New CMDataSet.N_ArticulosDataTable()
        adapter.FillByCodigo(table, CodigoTextBox.Text)
        If table.Rows.Count = 0 Then
            Return Nothing
        Else
            Dim articulo As CMDataSet.N_ArticulosRow = table.Rows(0)
            Entrada_Linea.ID_Articulo = articulo.ID_Articulo
            Entrada_Linea.Codigo = articulo.Codigo
            CodigoTextBox.Text = articulo.Codigo
            DescripcionTextBox.Text = articulo.DescripcionGeneral
            PrecioTextBox.Text = articulo.PrecioCompra
            'If Not articulo.IsImagenNull Then
            '    Entrada_Linea.Imagen = articulo.Imagen
            'End If
            Return articulo
        End If
    End Function

    Private Sub CodigoTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CodigoTextBox.Text <> "" Then
                If CargaArticulo() Is Nothing Then
                    MessageBox.Show("Articulo no encontrado")
                    'CodigoTextBox.Focus()
                End If
                SelectNextControl(sender, True, True, True, True)
                e.SuppressKeyPress = True
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub DescripcionTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DescripcionTextBox.KeyUp, TotalTextBox.KeyDown, PrecioTextBox.KeyDown, N_AlmacenComboBox.KeyDown, Descuento3TextBox.KeyDown, Descuento2TextBox.KeyDown, Descuento1TextBox.KeyDown, CantidadTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub


End Class