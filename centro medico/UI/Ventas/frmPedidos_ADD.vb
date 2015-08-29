Public Class frmPedidos_ADD


    Public ID_Pedido As Long = -1
    Public Pedido As CMDataSet.N_PedidosRow = Nothing
    Public Cliente As CMDataSet.N_ClientesRow

    Dim totalesAdapter As CMDataSetTableAdapters.N_Pedidos_TotalesTableAdapter = New CMDataSetTableAdapters.N_Pedidos_TotalesTableAdapter()
    Dim totalesTable As CMDataSet.N_Pedidos_TotalesDataTable = New CMDataSet.N_Pedidos_TotalesDataTable()

    Dim TipoIVAadapter As CMDataSetTableAdapters.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter()
    Dim TipoIVAtable As CMDataSet.N_TipoIVADataTable = New CMDataSet.N_TipoIVADataTable()



    Private SubTotal As Double = 0

    Private Sub frmPedidos_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Pedidos_Tipos' table. You can move, or remove it, as needed.
        Me.N_Pedidos_TiposTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Tipos)

        For Each o As Object In [Enum].GetValues(GetType(Globals.Pedidos_Estado))
            cmb_Estado.Items.Add(o)
        Next


        If ID_Pedido <> -1 Then
            Me.N_PedidosTableAdapter.FillBy(Me.CMDataSet.N_Pedidos, ID_Pedido)
            Pedido = Me.CMDataSet.N_Pedidos(0)
            If Not Pedido.IsID_EstadoNull() Then
                cmb_Estado.SelectedItem = CType(Pedido.ID_Estado, Globals.Pedidos_Estado)
            End If

            'Cargar lineas
            Me.N_Pedidos_LineasTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Lineas, Pedido.ID_Pedido)


            rb_PorteNoPagado.Checked = Not Pedido.PortePagado

            'Cargar Tab Totales
            CargaTotales()

            'Documentos Relacionados
            Me.CtrlDocProcesados1.id_Doc = ID_Pedido
            Me.CtrlDocProcesados1.tipoDoc = Globals.TipoDocumento.Pedido
            Me.CtrlDocProcesados1.CargaDocumentosRelacionados()
        Else
            'Crearlo Nuevo
            Pedido = N_PedidosBindingSource.AddNew().Row()
            CodigoTextBox.Text = Globals.GeneraCodigoAutomatico("N_Pedidos", "ID_Pedido", "000000")
            N_Pedidos_TiposComboBox.SelectedIndex = 0
            Pedido.ID_Estado = Globals.Pedidos_Estado.Pendiente
            cmb_Estado.SelectedItem = Globals.Pedidos_Estado.Pendiente
            Pedido.Fecha = Date.Now
            Pedido.Total = 0
            txt_Total.Text = 0
        End If


    End Sub

#Region "Private Sub LimpiaTotales()"
    Private Sub LimpiaTotales()
        pnl_Totales.Controls.Clear()
    End Sub
#End Region

#Region "Private Sub CargaTotales()"
    Private Sub CargaTotales()

        'Limpiar anteriores
        LimpiaTotales()

        'Primero Obtener los IVA
        TipoIVAadapter.Fill(TipoIVAtable)

        'Dim totalesAdapter As CMDataSetTableAdapters.N_Pedidos_TotalesTableAdapter = New CMDataSetTableAdapters.N_Pedidos_TotalesTableAdapter()
        'Dim totalesTable As CMDataSet.N_Pedidos_TotalesDataTable = New CMDataSet.N_Pedidos_TotalesDataTable()
        totalesAdapter.Fill(totalesTable, ID_Pedido)

        If (totalesTable.Rows.Count = 0) Then
            'Si no hay rows crearlos
            For Each row As DataRow In TipoIVAtable.Rows
                Dim IVARow As CMDataSet.N_TipoIVARow = row
                totalesAdapter.Insert(ID_Pedido, IVARow.ID_TipoIVA, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            Next
            totalesAdapter.Fill(totalesTable, ID_Pedido)
        End If


        Dim count As Integer = 0
        For Each row As DataRow In totalesTable.Rows
            Dim totalRow As CMDataSet.N_Pedidos_TotalesRow = row

            'Mostrar los IVA
            Dim t As TextBox = New TextBox()
            t.Text = CType(TipoIVAtable.Rows(count), CMDataSet.N_TipoIVARow).Nombre  'totalRow.ID_TipoIVA.ToString("N2")
            t.ReadOnly = True
            t.TextAlign = HorizontalAlignment.Center
            t.BackColor = System.Drawing.SystemColors.Info
            t.Size = lbl_TipoIVA.Size
            t.Left = lbl_TipoIVA.Left - 3
            t.Top = lbl_TipoIVA.Top + lbl_TipoIVA.Height + 5 + count * (t.Height + 3)

            pnl_Totales.Controls.Add(t)

            'Mostrar Importes Netos

            Dim t2 As TextBox = New TextBox()
            t2.Text = 0.ToString("N2")
            t2.Text = CalculaImporteNeto(totalRow.ID_TipoIVA).ToString("N2")
            totalRow.ImporteNeto = t2.Text
            t2.ReadOnly = True
            t2.TextAlign = HorizontalAlignment.Right
            t2.BackColor = System.Drawing.SystemColors.Info
            t2.Size = lbl_ImporteNeto.Size
            t2.Left = lbl_ImporteNeto.Left - 3
            t2.Top = lbl_ImporteNeto.Top + lbl_ImporteNeto.Height + 5 + count * (t2.Height + 3)
            pnl_Totales.Controls.Add(t2)

            'Mostrar Descuentos

            AnnadeTextBoxDobles(totalRow, count, lbl_Descuento, "DescuentoPorciento", "DescuentoCantidad")
            AnnadeTextBoxDobles(totalRow, count, lbl_ProntoPago, "ProntoPagoPorciento", "ProntoPagoCantidad")
            AnnadeTextBoxDobles(totalRow, count, lbl_Portes, "PortesPorciento", "PortesCantidad")
            AnnadeTextBoxDobles(totalRow, count, lbl_Finaciacion, "FinanciacionPorciento", "FinanciacionCantidad")
            'AnnadeTextBoxDobles(totalRow, count, lbl_IRPF, "IRPFPorciento", "IRPFCantidad")

            AnnadeTextBoxDobles_ReadOnly(totalRow, count, lbl_IVA, "IVAPorciento", "IVACantidad")
            AnnadeTextBoxDobles_ReadOnly(totalRow, count, lbl_RE, "REPorciento", "RECantidad")
            AnnadeTextBoxSimple(totalRow, count, lbl_Suma, "SubTotal", True)

            count = count + 1
        Next
        CalculaTotales()
    End Sub
#End Region

#Region "Private Sub CalculaTotales()"
    Private Sub CalculaTotales()
        Dim total As Double = 0
        SubTotal = 0
        Dim count As Integer = 0
        For Each row As DataRow In totalesTable.Rows
            Dim totalRow As CMDataSet.N_Pedidos_TotalesRow = row

            totalRow.SubTotal = totalRow.ImporteNeto - totalRow.DescuentoCantidad - totalRow.ProntoPagoCantidad + totalRow.PortesCantidad + totalRow.FinanciacionCantidad
            SubTotal = SubTotal + totalRow.SubTotal
            total = total + totalRow.SubTotal + totalRow.IVACantidad + totalRow.RECantidad

            totalRow.IVAPorciento = TipoIVAtable(count).Valor
            totalRow.IVACantidad = totalRow.SubTotal * (TipoIVAtable(count).Valor / 100)

            totalRow.AcceptChanges()
            count = count + 1
        Next

        If IRPFCantidadTextBox.Text = "" Then
            IRPFCantidadTextBox.Text = "0"
        End If
        total = total - IRPFCantidadTextBox.Text
        txt_Total.Text = total.ToString("N2")
        tst_SumaNeta.Text = "Suma Neta: " & SubTotal.ToString("N2")
        tst_TotalNeto.Text = "Total: " & total.ToString("N2")
        Me.Validate()
    End Sub
#End Region

#Region "Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)"
    Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)

        Dim t5 As TextBox = New TextBox()
        't5.Text = 0.ToString("N2")
        t5.TextAlign = HorizontalAlignment.Right
        t5.ReadOnly = txtBoxReadOnly
        If txtBoxReadOnly Then
            t5.BackColor = System.Drawing.SystemColors.Info
        End If

        t5.Height = controlGuia.Height
        t5.Width = controlGuia.Width
        t5.Left = controlGuia.Left - 3
        t5.Top = controlGuia.Top + controlGuia.Height + 5 + count * (t5.Height + 3)

        t5.DataBindings.Add("Text", totalRow, columnName, True, DataSourceUpdateMode.OnValidation, 0)
        pnl_Totales.Controls.Add(t5)
    End Sub
#End Region

#Region "Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

        'Porciento
        Dim t5 As TextBox = New TextBox()
        't5.Text = 0.ToString("N2")
        t5.TextAlign = HorizontalAlignment.Right
        't5.BackColor = System.Drawing.SystemColors.Info
        t5.Height = controlGuia.Height
        t5.Width = controlGuia.Width * (0.3)
        t5.Left = controlGuia.Left - 3
        t5.Top = controlGuia.Top + controlGuia.Height + 5 + count * (t5.Height + 3)

        t5.DataBindings.Add("Text", totalRow, columnNamePorciento)
        pnl_Totales.Controls.Add(t5)

        'Cantidad
        Dim t6 As TextBox = New TextBox()

        't6.Text = 0.ToString("N2")
        t6.TextAlign = HorizontalAlignment.Right
        't6.BackColor = System.Drawing.SystemColors.Info
        t6.Height = controlGuia.Height
        t6.Width = controlGuia.Width * (0.7) - +2
        t6.Left = controlGuia.Left + (controlGuia.Width * (0.3)) + 2
        t6.Top = controlGuia.Top + controlGuia.Height + 5 + count * (t6.Height + 3)
        t6.Tag = totalRow

        AddHandler t6.KeyUp, New KeyEventHandler(AddressOf TotalesKeyUp)

        t5.Tag = t6 'Asociarle al control porciento su control cantidad para despues modificar la cantidad segun el porciento
        AddHandler t5.KeyUp, New KeyEventHandler(AddressOf PorcientosKeyUp)


        t6.DataBindings.Add("Text", totalRow, columnNameCantidad)
        pnl_Totales.Controls.Add(t6)

    End Sub
#End Region

#Region "Private Sub TotalesKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)"
    Private Sub TotalesKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        'Me.Validate()
        sender.Tag.Item(sender.DataBindings("Text").BindingMemberInfo.BindingField) = sender.Text
        CalculaTotales()
    End Sub
#End Region

#Region "Private Sub PorcientosKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)"
    Private Sub PorcientosKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)

        Dim controlCantidad As TextBox = sender.Tag
        'controlCantidad.BackColor = color.Red
        Dim porciento As Double = 0
        Try
            porciento = Double.Parse(sender.Text)
        Catch ex As Exception
        End Try

        Dim totalRow As CMDataSet.N_Pedidos_TotalesRow = controlCantidad.Tag

        controlCantidad.Text = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        totalRow.Item(controlCantidad.DataBindings("Text").BindingMemberInfo.BindingField) = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        Me.Validate()
        CalculaTotales()
    End Sub
#End Region

#Region "Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Pedidos_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

        'Porciento
        Dim t5 As TextBox = New TextBox()
        't5.Text = 0.ToString("N2")
        t5.TextAlign = HorizontalAlignment.Right
        t5.ReadOnly = True
        t5.BackColor = System.Drawing.SystemColors.Info
        t5.Height = controlGuia.Height
        t5.Width = controlGuia.Width * (0.3)
        t5.Left = controlGuia.Left - 3
        t5.Top = controlGuia.Top + controlGuia.Height + 5 + count * (t5.Height + 3)

        t5.DataBindings.Add("Text", totalRow, columnNamePorciento)
        pnl_Totales.Controls.Add(t5)

        'Cantidad
        Dim t6 As TextBox = New TextBox()

        't6.Text = 0.ToString("N2")
        t6.TextAlign = HorizontalAlignment.Right
        t6.BackColor = System.Drawing.SystemColors.Info
        t6.ReadOnly = True
        t6.Height = controlGuia.Height
        t6.Width = controlGuia.Width * (0.7) - +2
        t6.Left = controlGuia.Left + (controlGuia.Width * (0.3)) + 2
        t6.Top = controlGuia.Top + controlGuia.Height + 5 + count * (t6.Height + 3)

        t6.DataBindings.Add("Text", totalRow, columnNameCantidad)
        pnl_Totales.Controls.Add(t6)

    End Sub
#End Region

#Region "Private Sub GuardaTotales()"
    Private Sub GuardaTotales()
        totalesTable.AcceptChanges()
        For Each row As DataRow In totalesTable.Rows
            Dim t As CMDataSet.N_Pedidos_TotalesRow = row
            Me.totalesAdapter.UpdateQuery(t.DescuentoPorciento, t.DescuentoCantidad, t.ProntoPagoPorciento, t.ProntoPagoCantidad, t.PortesPorciento, t.PortesCantidad, t.FinanciacionPorciento, t.FinanciacionCantidad, t.ImporteNeto, t.SubTotal, t.IVAPorciento, t.IVACantidad, t.REPorciento, t.RECantidad, t.ID_Pedido, t.ID_TipoIVA)
        Next
    End Sub
#End Region

    Private Function CalculaImporteNeto(ByVal ID_TipoIVA As Integer) As Double
        Return totalesAdapter.ImporteNeto(ID_Pedido, ID_TipoIVA)
    End Function

#Region "Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click"
    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If Not Guardar() Then
            Return
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region


#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        If CodigoTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir algun código")
            CodigoTextBox.Focus()
            Return False
        End If

        Pedido.Total = txt_Total.Text
        Me.Validate()
        Me.N_PedidosBindingSource.EndEdit()
        Me.N_PedidosTableAdapter.Update(Me.CMDataSet.N_Pedidos)
        ID_Pedido = Pedido.ID_Pedido

        'Guardar Totales
        GuardaTotales()
        Return True
    End Function
#End Region

#Region "Private Sub btn_NuevaLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevaLinea.Click"
    Private Sub btn_NuevaLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevaLinea.Click

        If Not Guardar() Then
            Return
        End If

        Dim frm As frmPedidos_Lineas_ADD = New frmPedidos_Lineas_ADD()
        frm.ID_Pedido = ID_Pedido
        'If Not Me.CtrlAgenteComercial1.AgenteComercial Is Nothing Then
        'frm.comision = Me.CtrlAgenteComercial1.AgenteComercial.Comision
        'Else
        frm.comision = 0
        'End If
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Pedidos_LineasTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Lineas, Pedido.ID_Pedido)
            CargaTotales()
        End If

    End Sub
#End Region

#Region "Private Sub N_Pedidos_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Pedidos_LineasDataGridView.CellFormatting"
    Private Sub N_Pedidos_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Pedidos_LineasDataGridView.CellFormatting
        If (e.ColumnIndex = L.Index) Then
            e.Value = e.RowIndex + 1
        End If

    End Sub
#End Region

#Region "Private Sub N_Pedidos_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Pedidos_LineasDataGridView.SelectionChanged"
    Private Sub N_Pedidos_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Pedidos_LineasDataGridView.SelectionChanged
        btn_Eliminar.Enabled = N_Pedidos_LineasDataGridView.SelectedRows.Count > 0
        btn_Editar.Enabled = N_Pedidos_LineasDataGridView.SelectedRows.Count > 0
    End Sub
#End Region

#Region "Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click"
    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        Dim Pedido_Linea As CMDataSet.N_Pedidos_LineasRow = N_Pedidos_LineasDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim frm As frmPedidos_Lineas_ADD = New frmPedidos_Lineas_ADD()
        frm.ID_Pedido_Linea = Pedido_Linea.ID_PedidoLineas
        frm.ID_Pedido = Pedido_Linea.ID_Pedido
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_Pedidos_LineasDataGridView.SelectedRows(0).Index
            Me.N_Pedidos_LineasTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Lineas, Pedido.ID_Pedido)
            CargaTotales()
            N_Pedidos_LineasDataGridView.Rows(pos).Selected = True
        End If
    End Sub
#End Region


    Private Sub N_Pedidos_LineasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Pedidos_LineasDataGridView.CellDoubleClick
        btn_Editar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim Pedido_Linea As CMDataSet.N_Pedidos_LineasRow = N_Pedidos_LineasDataGridView.SelectedRows(0).DataBoundItem.Row
        Pedido_Linea.Delete()
        N_Pedidos_LineasTableAdapter.Update(CMDataSet.N_Pedidos_Lineas)
        CargaTotales()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiaTotales()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargaTotales()
    End Sub


#Region "Private Sub IRPFPorcientoTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IRPFPorcientoTextBox.KeyUp"
    Private Sub IRPFPorcientoTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IRPFPorcientoTextBox.KeyUp

        Dim porciento As Double = 0
        Try
            porciento = Double.Parse(IRPFPorcientoTextBox.Text)
        Catch ex As Exception
        End Try
        IRPFCantidadTextBox.Text = SubTotal * (porciento / 100)
        CalculaTotales()
    End Sub
#End Region

    Private Sub btn_AplicarIVA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim TipoIVAadapter As CMDataSetTableAdapters.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter()
        Dim TipoIVAtable As CMDataSet.N_TipoIVADataTable = New CMDataSet.N_TipoIVADataTable()
        TipoIVAadapter.Fill(TipoIVAtable)

        Dim count As Integer = 0
        For Each row As DataRow In totalesTable.Rows
            Dim totalRow As CMDataSet.N_Pedidos_TotalesRow = row
            totalRow.IVAPorciento = TipoIVAtable(count).Valor
            totalRow.IVACantidad = totalRow.SubTotal * (TipoIVAtable(count).Valor / 100)
            count = count + 1
        Next
        TipoIVAtable.AcceptChanges()
        pnl_Totales.Refresh()
        CalculaTotales()
    End Sub

    Private Sub btn_ValidarLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarLineas.Click
        'If Me.CtrlCliente1.Cliente Is Nothing Then
        '    MsgBox("Debe Seleccionar un cliente.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        If Not Guardar() Then
            Return
        End If

        'Dim frm As frmValidarLineasDocumentos = New frmValidarLineasDocumentos()

        'frm.TipoDocDestino = Globals.TipoDocumento.Pedido
        'frm.ID_DocDestino = Pedido.ID_Pedido
        'frm.CodigoClienteProveedor = Me.CtrlCliente1.Cliente.Codigo
        'frm.DocumentosOrigen.Add(Globals.TipoDocumento.Presupuesto)

        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        '    'Cargar lineas
        '    Me.N_Pedidos_LineasTableAdapter.Fill(Me.CMDataSet.N_Pedidos_Lineas, Pedido.ID_Pedido)

        '    'Cargar Tab Totales
        '    CargaTotales()

        'End If
    End Sub

    Private Sub bt_ImprimirPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ImprimirPedido.Click
        'Dim rpGenerico As form_ReporteGenerico
        'Dim dtableReportPEDIDO As New CMDataSet.REPORT_PEDIDODataTable
        'Dim dAdapterReportPEDIDO As New CMDataSetTableAdapters.REPORT_PEDIDOTableAdapter
        'Dim parametro(3) As Microsoft.Reporting.WinForms.ReportParameter
        'Dim rdatasource As New Microsoft.Reporting.WinForms.ReportDataSource
        'Dim rdatasourceTotales As New Microsoft.Reporting.WinForms.ReportDataSource

        'Dim i As Integer

        'Dim Descuento As Double = 0
        'Dim ProntoPago As Double = 0
        'Dim Portes As Double = 0
        'Dim Financiacion As Double = 0
        'Dim RE As Double = 0
        'Dim REPorc As Double = 0

        'dAdapterReportPEDIDO.FillByIdPedido(dtableReportPEDIDO, Me.ID_Pedido)
        'rdatasource.Name = "CMDataSet_REPORT_PEDIDO"
        'rdatasource.Value = dtableReportPEDIDO

        'rdatasourceTotales.Name = "CMDataSet_N_Pedidos_Totales"
        'rdatasourceTotales.Value = totalesTable

        'parametro(0) = New Microsoft.Reporting.WinForms.ReportParameter("IdPedido", Me.ID_Pedido)
        'parametro(1) = New Microsoft.Reporting.WinForms.ReportParameter("Irpf", Me.N_PedidosBindingSource.Current("IRPFCantidad").ToString)
        'parametro(2) = New Microsoft.Reporting.WinForms.ReportParameter("IrpfPorc", Me.N_PedidosBindingSource.Current("IRPFPorciento").ToString)
        'parametro(3) = New Microsoft.Reporting.WinForms.ReportParameter("TotalPto", Me.txt_Total.Text)



        'rpGenerico = New form_ReporteGenerico(rdatasource, Application.StartupPath & "\RDLC\Pedido.rdlc", "Pedido")
        'rpGenerico.ReportViewer.LocalReport.DataSources.Add(rdatasourceTotales)
        'rpGenerico.ReportViewer.LocalReport.SetParameters(parametro)

        'rpGenerico.ShowDialog()


    End Sub
End Class