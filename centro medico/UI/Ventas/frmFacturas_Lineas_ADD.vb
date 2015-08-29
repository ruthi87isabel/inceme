Public Class frmFacturas_Lineas_ADD


    Public ID_Factura As Long = -1
    Public ID_Factura_Linea As Long = -1
    Public Comision As Double = 0

    Private Expanded As Boolean = False
    Private sizeToExpand As Integer = 240


    Public Factura_Linea As CMDataSet.N_Factura_LineasRow = Nothing

    Private Sub pb_SeleccionarArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SeleccionarArticulo.Click
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Factura_Linea.ID_Articulo = frm.Articulo.ID_Articulo
            Factura_Linea.Codigo = frm.Articulo.Codigo
            CodigoTextBox.Text = frm.Articulo.Codigo
            DescripcionTextBox.Text = frm.Articulo.DescripcionGeneral
            PrecioTextBox.Text = frm.Articulo.PrecioVentaRecomendado
            N_TipoIVAComboBox.SelectedValue = frm.Articulo.ID_TipoIVA
            If Not frm.Articulo.IsImagenNull Then
                Factura_Linea.Imagen = frm.Articulo.Imagen
            End If

        End If
    End Sub

    Private Sub frmFacturas_Lineas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Almacen' table. You can move, or remove it, as needed.
        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
        'TODO: This line of code loads data into the 'CMDataSet.N_TipoIVA' table. You can move, or remove it, as needed.
        Me.N_TipoIVATableAdapter.Fill(Me.CMDataSet.N_TipoIVA)

        If ID_Factura = -1 Then
            MessageBox.Show("Debe especificar una factura")
            Me.Close()
            Return
        End If

        If ID_Factura_Linea <> -1 Then
            Me.N_Factura_LineasTableAdapter.FillBy(Me.CMDataSet.N_Factura_Lineas, ID_Factura, ID_Factura_Linea)
            Factura_Linea = Me.CMDataSet.N_Factura_Lineas(0)

            'Cargar Lotes
            'N_Factura_LotesTableAdapter.Fill(CMDataSet.N_Factura_Lotes, Factura_Linea.ID_FacturaLineas)

            'Cargar documento Origen
            If Not Factura_Linea.IsID_DocOrigenNull Then
                Dim CodigoDocumentoOrigen As String = ""
                Select Case CType(Factura_Linea.ID_TipoDocOrigen, Globales.TipoDocumento)
                    Case Globales.TipoDocumento.Presupuesto
                        ''  Dim adapter As CMDataSetTableAdapters.N_PresupuestosTableAdapter = New CMDataSetTableAdapters.N_PresupuestosTableAdapter()
                        ''   Dim table As CMDataSet.N_PresupuestosDataTable = New CMDataSet.N_PresupuestosDataTable()
                        'adapter.FillBy(table, Factura_Linea.ID_DocOrigen)
                        'If table.Rows.Count > 0 Then
                        '    lbl_Nota.Text = "Nota: Línea validada desde documento " & [Enum].GetName(GetType(Globals.TipoDocumento), Factura_Linea.ID_TipoDocOrigen) & ", Código: " & table(0).Codigo
                        'Else
                        '    MessageBox.Show("El documento que dio origen a esta línea no existe!")
                        'End If
                End Select

            End If
        Else
            'Crearlo Nuevo
            Factura_Linea = N_Factura_LineasBindingSource.AddNew().Row()
            Factura_Linea.ID_Factura = ID_Factura
            'Me.txt_comision.Text = Comision
            N_TipoIVAComboBox.SelectedIndex = 0
            N_AlmacenComboBox.SelectedIndex = 0
            Me.Descuento1TextBox.Text = 0
            Me.Descuento2TextBox.Text = 0
            Me.Descuento3TextBox.Text = 0
            Me.CantidadTextBox.Text = 0
            Me.PrecioTextBox.Text = 0
            Me.IVAIncluidoCheckBox.Checked = False
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If DescripcionTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir alguna descripción")
            DescripcionTextBox.Focus()
            Return
        End If



        Me.Validate()
        Me.N_Factura_LineasBindingSource.EndEdit()
        Me.N_Factura_LineasTableAdapter.Update(Me.CMDataSet.N_Factura_Lineas)

        'Aqui insertar los totales
        Dim tipoIva As CMDataSet.N_TipoIVARow = N_TipoIVAComboBox.SelectedItem.Row

        Dim total As CMDataSet.N_Factura_TotalesRow = CMDataSet.N_Factura_Totales.NewN_Factura_TotalesRow()
        total.DescuentoCantidad = 0
        total.DescuentoPorciento = 0
        total.FinanciacionCantidad = 0
        total.FinanciacionPorciento = 0
        total.ID_Factura = ID_Factura
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

        CMDataSet.N_Factura_Totales.AddN_Factura_TotalesRow(total)

        Dim totalAdapter As New CMDataSetTableAdapters.N_Factura_TotalesTableAdapter()
        Try
            totalAdapter.Update(CMDataSet.N_Factura_Totales)
        Catch ex As Exception
        End Try


        'Salvar los lotes
        'Me.N_Factura_LotesBindingSource.EndEdit()

        'For Each row As DataGridViewRow In N_Factura_LotesDataGridView.Rows
        '    Dim lote As CMDataSet.N_Factura_LotesRow = row.DataBoundItem.Row()
        '    lote.ID_Factura_Linea = Factura_Linea.ID_FacturaLineas
        'Next

        'Me.N_Factura_LotesTableAdapter.Update(Me.CMDataSet.N_Factura_Lotes)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pb_Articulo_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Articulo_Delete.Click
        Factura_Linea.SetID_ArticuloNull()
        CodigoTextBox.Text = ""
    End Sub

    Private Sub CantidadTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PrecioTextBox.KeyUp, Descuento3TextBox.KeyUp, Descuento2TextBox.KeyUp, Descuento1TextBox.KeyUp, CantidadTextBox.KeyUp
        If IsNumeric(sender.text) Then CalculaTotal()
    End Sub

#Region "Private Sub CalculaTotal()"
    Private Sub CalculaTotal()
        Dim precio As Double = 0
        Dim cantidad As Double = 0
        Dim dto1 As Double = 0
        Dim dto2 As Double = 0
        Dim dto3 As Double = 0

        Try
            If IsNumeric(PrecioTextBox.Text) = False Then Exit Sub
            If IsNumeric(CantidadTextBox.Text) = False Then Exit Sub
            If IsNumeric(Descuento1TextBox.Text) = False Then Exit Sub
            If IsNumeric(Descuento2TextBox.Text) = False Then Exit Sub
            If IsNumeric(Descuento3TextBox.Text) = False Then Exit Sub

            precio = Double.Parse(PrecioTextBox.Text)
            cantidad = Double.Parse(CantidadTextBox.Text)
            dto1 = Double.Parse(Descuento1TextBox.Text)
            dto2 = Double.Parse(Descuento2TextBox.Text)
            dto3 = Double.Parse(Descuento3TextBox.Text)

        Catch ex As Exception
            MsgBox(ex.ToString)
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
            btn_Detalles.Image = My.Resources.Resources._24_em_down
        Else
            Me.Height = Me.Height + sizeToExpand
            Expanded = True
            btn_Detalles.Image = My.Resources.Resources._24_em_up
        End If
    End Sub

    Private Sub btn_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imagen.Click
        'Dim frm As frmVisorImagenes = New frmVisorImagenes()
        'If Not Factura_Linea.IsImagenNull Then
        '    frm.Image = Image.FromStream(New System.IO.MemoryStream(Factura_Linea.Imagen))
        'End If
    End Sub


    Private Sub pb_NuevaSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_NuevaSerie.Click
        'Dim nuevo As CMDataSet.N_Factura_LotesRow = Me.N_Factura_LotesBindingSource.AddNew().Row
        'nuevo.ID_Factura_Linea = 0
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
            Factura_Linea.ID_Articulo = articulo.ID_Articulo
            Factura_Linea.Codigo = articulo.Codigo
            CodigoTextBox.Text = articulo.Codigo
            DescripcionTextBox.Text = articulo.DescripcionGeneral
            PrecioTextBox.Text = articulo.PrecioVentaRecomendado
            Me.N_TipoIVAComboBox.SelectedValue = articulo.ID_TipoIVA
            If Not articulo.IsImagenNull Then
                Factura_Linea.Imagen = articulo.Imagen
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