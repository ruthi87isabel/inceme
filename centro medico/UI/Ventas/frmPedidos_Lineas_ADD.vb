Public Class frmPedidos_Lineas_ADD


    Public ID_Pedido As Long = -1
    Public ID_Pedido_Linea As Long = -1
    Public comision As Double = 0

    Private Expanded As Boolean = False
    Private sizeToExpand As Integer = 240


    Public Pedido_Linea As CMDataSet.N_Pedidos_LineasRow = Nothing

    Private Sub pb_SeleccionarArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SeleccionarArticulo.Click
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globals.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pedido_Linea.ID_Articulo = frm.Articulo.ID_Articulo
            Pedido_Linea.Codigo = frm.Articulo.Codigo
            CodigoTextBox.Text = frm.Articulo.Codigo
            DescripcionTextBox.Text = frm.Articulo.DescripcionGeneral
            PrecioTextBox.Text = frm.Articulo.PrecioCompra
            If Not frm.Articulo.IsImagenNull Then
                Pedido_Linea.Imagen = frm.Articulo.Imagen
            End If

        End If
    End Sub

    Private Sub frmPedidos_Lineas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Almacen' table. You can move, or remove it, as needed.
        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
        'TODO: This line of code loads data into the 'CMDataSet.N_TipoIVA' table. You can move, or remove it, as needed.
        Me.N_TipoIVATableAdapter.Fill(Me.CMDataSet.N_TipoIVA)

        If ID_Pedido = -1 Then
            MessageBox.Show("Debe especificar un pedido")
            Me.Close()
            Return
        End If

        If ID_Pedido_Linea <> -1 Then
            Me.N_Pedidos_LineasTableAdapter.FillBy(Me.CMDataSet.N_Pedidos_Lineas, ID_Pedido, ID_Pedido_Linea)
            Pedido_Linea = Me.CMDataSet.N_Pedidos_Lineas(0)

            'Cargar Lotes
            'N_Pedidos_LotesTableAdapter.Fill(CMDataSet.N_Pedidos_Lotes, Pedido_Linea.ID_PedidoLineas)

            'Cargar documento Origen
            If Not Pedido_Linea.IsID_DocOrigenNull Then
                Dim CodigoDocumentoOrigen As String = ""
                Select Case CType(Pedido_Linea.ID_TipoDocOrigen, Globals.TipoDocumento)
                    Case Globals.TipoDocumento.Presupuesto
                        Dim adapter As CMDataSetTableAdapters.N_PresupuestosTableAdapter = New CMDataSetTableAdapters.N_PresupuestosTableAdapter()
                        Dim table As CMDataSet.N_PresupuestosDataTable = New CMDataSet.N_PresupuestosDataTable()
                        adapter.FillBy(table, Pedido_Linea.ID_DocOrigen)
                        If table.Rows.Count > 0 Then
                            lbl_Nota.Text = "Nota: Línea validada desde documento " & [Enum].GetName(GetType(Globals.TipoDocumento), Pedido_Linea.ID_TipoDocOrigen) & ", Código: " & table(0).Codigo
                        Else
                            MessageBox.Show("El documento que dio origen a esta línea no existe!")
                        End If
                End Select

            End If
        Else
            'Crearlo Nuevo
            Pedido_Linea = N_Pedidos_LineasBindingSource.AddNew().Row()
            Pedido_Linea.ID_Pedido = ID_Pedido
            Me.txt_comision.Text = comision
            N_TipoIVAComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If DescripcionTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir alguna descripción")
            DescripcionTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.N_Pedidos_LineasBindingSource.EndEdit()
        Me.N_Pedidos_LineasTableAdapter.Update(Me.CMDataSet.N_Pedidos_Lineas)

        'Salvar los lotes
        'Me.N_Pedidos_LotesBindingSource.EndEdit()

        'For Each row As DataGridViewRow In N_Pedidos_LotesDataGridView.Rows
        '    Dim lote As CMDataSet.N_Pedidos_LotesRow = row.DataBoundItem.Row()
        '    lote.ID_Pedido_Linea = Pedido_Linea.ID_PedidoLineas
        'Next

        'Me.N_Pedidos_LotesTableAdapter.Update(Me.CMDataSet.N_Pedidos_Lotes)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pb_Articulo_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Articulo_Delete.Click
        Pedido_Linea.SetID_ArticuloNull()
        CodigoTextBox.Text = ""
    End Sub

    Private Sub CantidadTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PrecioTextBox.KeyUp, Descuento3TextBox.KeyUp, Descuento2TextBox.KeyUp, Descuento1TextBox.KeyUp, CantidadTextBox.KeyUp
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


    Private Sub TotalTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalTextBox.KeyUp
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
        'If Not Pedido_Linea.IsImagenNull Then
        '    frm.Image = Image.FromStream(New System.IO.MemoryStream(Pedido_Linea.Imagen))
        'End If
    End Sub


    Private Sub pb_NuevaSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_NuevaSerie.Click
        'Dim nuevo As CMDataSet.N_Pedidos_LotesRow = Me.N_Pedidos_LotesBindingSource.AddNew().Row
        'nuevo.ID_Pedido_Linea = 0
        'nuevo.BeginEdit()
    End Sub

    Private Function CargaArticulo() As CMDataSet.N_ArticulosRow
        Dim adapter As CMDataSetTableAdapters.N_ArticulosTableAdapter = New CMDataSetTableAdapters.N_ArticulosTableAdapter()
        Dim table As CMDataSet.N_ArticulosDataTable = New CMDataSet.N_ArticulosDataTable()
        adapter.FillByCodigo(table, CodigoTextBox.Text)
        If table.Rows.Count = 0 Then
            MessageBox.Show("Articulo no encontrado")
            CodigoTextBox.Focus()
            Return Nothing
        Else
            Dim articulo As CMDataSet.N_ArticulosRow = table.Rows(0)
            Pedido_Linea.ID_Articulo = articulo.ID_Articulo
            Pedido_Linea.Codigo = articulo.Codigo
            CodigoTextBox.Text = articulo.Codigo
            DescripcionTextBox.Text = articulo.DescripcionGeneral
            PrecioTextBox.Text = articulo.PrecioCompra
            If Not articulo.IsImagenNull Then
                Pedido_Linea.Imagen = articulo.Imagen
            End If
            Return articulo
        End If
    End Function

    Private Sub CodigoTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoTextBox.Leave
        'Verificar si existe el articulo
        If CodigoTextBox.Text <> "" Then
            CargaArticulo()
        End If
    End Sub
End Class