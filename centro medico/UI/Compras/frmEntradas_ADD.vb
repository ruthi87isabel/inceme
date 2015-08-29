Public Class frmEntradas_ADD

    '- Descuento: se calcula el porcentaje especificado en base al importe neto y se reta a este
    'EJemplo: Importe neto 100    Descuento 10% con lo que el total es 90
    '- Pronto Pago: Idem que descuento, solo que es unconcepto usado para saber que el descuento se realiza por haber pagado en un corto plazo de tiempo.
    '- Portes: En este caso se trata de un incremento y se calcula de la misma forma que los anteriores.
    '- Financiacion: Idem que portes pero es unconcepto separado para saber que el incremento sobre el importe neto es debido a unos gastos de financiación del total.
    '- Iva: Se trata de unincremento del porcentaje especificado sobre el importe neto - dto-prontopago + portes +financiacion. Esto es unimpuesto qeu se aplica en españa y segun el tipo de articulo se aplica un iva u otro
    '- RE: Se trata de un incremento que ciertos clientes tendran por unas cuestiones fiscales. Como en todo lo anterior, el incremento se calcula en base al importe neto - dto-prontopago + portes +financiacion. Este solo se aplica si esta definido en la ficha del cliente.
    '- IRPF: Es un porcentaje que hay qeu descontar. como en lo anterior en base al importe neto - dto-prontopago + portes +financiacion.

    'Te pongo un ejemplo con cifras:
    'Importe neto = 100€
    'Descuento =10% (-10€)
    'ProntoPago =7% (-7€)
    'Portes=3 % (+3€)
    'Financiacion = 1 % (+1€)
    'Tas aplicar lo anterior al impote neto nos queda untotal de 87€, sobre este total aplicamos lo referente a impuestos que te detallo a continuacion.
    'Iva = 16% (+13,92€)
    'RE = 4% (+3,48€)
    'IRPF = 15% (-13,05€)
    'Con lo que al final tenemos un Total Entradaado de 91,35 €


    Public ID_Entrada As Long = -1
    Public Entrada As CMDataSet.N_EntradasRow = Nothing
    'Public Cliente As CMDataSet.N_ClientesRow

    Dim totalesAdapter As CMDataSetTableAdapters.N_Entradas_TotalesTableAdapter = New CMDataSetTableAdapters.N_Entradas_TotalesTableAdapter()
    Dim totalesTable As CMDataSet.N_Entradas_TotalesDataTable = New CMDataSet.N_Entradas_TotalesDataTable()

    Dim TipoIVAadapter As CMDataSetTableAdapters.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter()
    Dim TipoIVAtable As CMDataSet.N_TipoIVADataTable = New CMDataSet.N_TipoIVADataTable()



    Private SubTotal As Double = 0

    Private Sub frmEntradas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_Entradas_Lineas' table. You can move, or remove it, as needed.

        Me.N_Entradas_TiposTableAdapter.Fill(Me.CMDataSet.N_Entradas_Tipos)
        'Estados

        For Each o As Object In [Enum].GetValues(GetType(Globales.Entradas_Estado))
            cmb_Estado.Items.Add(o)
        Next

        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Lectura Then
            Me.btn_Guardar.Enabled = False
            Me.btn_Editar.Enabled = False
            Me.btn_Eliminar.Enabled = False
            Me.btn_ValidarLineas.Enabled = False
            Me.btn_NuevaLinea.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Modificar Then
            Me.btn_Guardar.Enabled = True
            Me.btn_Editar.Enabled = True
            Me.btn_Eliminar.Enabled = False
            Me.btn_ValidarLineas.Enabled = True
            Me.btn_NuevaLinea.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Entradas) = RoleManager.TipoPermisos.Total Then
            Me.btn_Guardar.Enabled = True
            Me.btn_Editar.Enabled = True
            Me.btn_Eliminar.Enabled = True
            Me.btn_ValidarLineas.Enabled = True
            Me.btn_NuevaLinea.Enabled = True
        End If

        If ID_Entrada <> -1 Then
            Me.N_EntradasTableAdapter.FillBy(Me.CMDataSet.N_Entradas, ID_Entrada)
            Entrada = Me.CMDataSet.N_Entradas(0)
            If Not Entrada.IsID_EstadoNull() Then
                cmb_Estado.SelectedItem = CType(Entrada.ID_Estado, Globales.Entradas_Estado)
            End If

            'Cargar lineas
            Me.N_Entradas_LineasTableAdapter.Fill(Me.CMDataSet.N_Entradas_Lineas, Entrada.ID_Entrada)

            'Cargar Tab Totales
            CargaTotales()

            'Documentos Relacionados
            Me.CtrlDocProcesados1.id_Doc = ID_Entrada
            Me.CtrlDocProcesados1.tipoDoc = Globales.TipoDocumento.Entrada
            Me.CtrlDocProcesados1.CargaDocumentosRelacionados()
        Else
            'Crearlo Nuevo
            Entrada = N_EntradasBindingSource.AddNew().Row()
            CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Entradas", "ID_Entrada", "000000")
            N_Entradas_TiposComboBox.SelectedIndex = 0
            Entrada.ID_Estado = Globales.Entradas_Estado.Pendiente
            cmb_Estado.SelectedItem = Globales.Entradas_Estado.Pendiente
            Entrada.Fecha = Date.Now
            Entrada.Total = 0
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

        'Dim totalesAdapter As CMDataSetTableAdapters.N_Entrada_TotalesTableAdapter = New CMDataSetTableAdapters.N_Entrada_TotalesTableAdapter()
        'Dim totalesTable As CMDataSet.N_Entrada_TotalesDataTable = New CMDataSet.N_Entrada_TotalesDataTable()
        totalesAdapter.Fill(totalesTable, ID_Entrada)



        'If (totalesTable.Rows.Count = 0) Then
        '    'Si no hay rows crearlos
        '    For Each row As DataRow In TipoIVAtable.Rows
        '        Dim IVARow As CMDataSet.N_TipoIVARow = row
        '        totalesAdapter.Insert(ID_Factura, IVARow.ID_TipoIVA, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        '    Next
        '    totalesAdapter.Fill(totalesTable, ID_Factura)
        'End If


        Dim count As Integer = 0
        For Each row As DataRow In totalesTable.Select(Nothing, "IVAPorciento DESC")

            Dim totalRow As CMDataSet.N_Entradas_TotalesRow = row

            'Mostrar los IVA
            Dim t As TextBox = New TextBox()
            t.Text = TipoIVAtable.FindByID_TipoIVA(totalRow.ID_TipoIVA).Nombre  'totalRow.ID_TipoIVA.ToString("N2")
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
            Dim totalRow As CMDataSet.N_Entradas_TotalesRow = row

            totalRow.SubTotal = totalRow.ImporteNeto - totalRow.DescuentoCantidad - totalRow.ProntoPagoCantidad + totalRow.PortesCantidad + totalRow.FinanciacionCantidad
            SubTotal = SubTotal + totalRow.SubTotal

            totalRow.IVAPorciento = TipoIVAtable.FindByID_TipoIVA(totalRow.ID_TipoIVA).Valor
            totalRow.IVACantidad = totalRow.SubTotal * (TipoIVAtable.FindByID_TipoIVA(totalRow.ID_TipoIVA).Valor / 100)

            total = total + totalRow.SubTotal + totalRow.IVACantidad + totalRow.RECantidad
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

#Region "Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)"
    Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)

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

#Region "Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

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

        Dim totalRow As CMDataSet.N_Entradas_TotalesRow = controlCantidad.Tag

        controlCantidad.Text = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        totalRow.Item(controlCantidad.DataBindings("Text").BindingMemberInfo.BindingField) = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        Me.Validate()
        CalculaTotales()
    End Sub
#End Region

#Region "Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Entradas_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

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
            Dim t As CMDataSet.N_Entradas_TotalesRow = row
            Me.totalesAdapter.UpdateQuery(t.DescuentoPorciento, t.DescuentoCantidad, t.ProntoPagoPorciento, t.ProntoPagoCantidad, t.PortesPorciento, t.PortesCantidad, t.FinanciacionPorciento, t.FinanciacionCantidad, t.ImporteNeto, t.SubTotal, t.IVAPorciento, t.IVACantidad, t.REPorciento, t.RECantidad, t.ID_Entrada, t.ID_TipoIVA)
        Next
    End Sub
#End Region

    Private Function CalculaImporteNeto(ByVal ID_TipoIVA As Integer) As Double
        Return totalesAdapter.ImporteNetoQuery(ID_Entrada, ID_TipoIVA)
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
        If Me.CtrlProveedor1.Proveedor Is Nothing Then
            MsgBox("Debe indicar un proveedor.", MsgBoxStyle.Exclamation)
            Exit Function
        End If
        If txt_Total.Text <> String.Empty Then
            Entrada.Total = txt_Total.Text
        End If

        Me.Validate()
        Me.N_EntradasBindingSource.EndEdit()
        Me.N_EntradasTableAdapter.Update(Me.CMDataSet.N_Entradas)
        ID_Entrada = Entrada.ID_Entrada

        'Guardar Totales
        GuardaTotales()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Entradas, "Entradas", Entrada.ID_Entrada.ToString(), "")

        Return True
    End Function
#End Region

#Region "Private Sub btn_NuevaLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevaLinea.Click"
    Private Sub btn_NuevaLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevaLinea.Click

        If Not Guardar() Then
            Return
        End If

        Dim frm As frmEntradas_Lineas_ADD = New frmEntradas_Lineas_ADD()
        frm.ID_Entrada = ID_Entrada
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Entradas_LineasTableAdapter.Fill(Me.CMDataSet.N_Entradas_Lineas, Entrada.ID_Entrada)
            CargaTotales()
        End If

    End Sub
#End Region

#Region "Private Sub N_Entradas_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Entradas_LineasDataGridView.CellFormatting"
    Private Sub N_Entradas_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Entradas_LineasDataGridView.CellFormatting
        If (e.ColumnIndex = L.Index) Then
            e.Value = e.RowIndex + 1
        End If

    End Sub
#End Region

#Region "Private Sub N_Entradas_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Entradas_LineasDataGridView.SelectionChanged"
    Private Sub N_Entradas_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Entradas_LineasDataGridView.SelectionChanged
        btn_Eliminar.Enabled = N_Entradas_LineasDataGridView.SelectedRows.Count > 0
        btn_Editar.Enabled = N_Entradas_LineasDataGridView.SelectedRows.Count > 0
    End Sub
#End Region

#Region "Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click"
    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        Dim Entrada_Linea As CMDataSet.N_Entradas_LineasRow = N_Entradas_LineasDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim frm As frmEntradas_Lineas_ADD = New frmEntradas_Lineas_ADD()
        frm.ID_Entrada_Linea = Entrada_Linea.ID_EntradaLineas
        frm.ID_Entrada = Entrada_Linea.ID_Entrada
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_Entradas_LineasDataGridView.SelectedRows(0).Index
            Me.N_Entradas_LineasTableAdapter.Fill(Me.CMDataSet.N_Entradas_Lineas, Entrada.ID_Entrada)
            CargaTotales()
            N_Entradas_LineasDataGridView.Rows(pos).Selected = True
        End If
    End Sub
#End Region


    Private Sub N_Entradas_LineasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Entradas_LineasDataGridView.CellDoubleClick
        btn_Editar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim Entrada_Linea As CMDataSet.N_Entradas_LineasRow = N_Entradas_LineasDataGridView.SelectedRows(0).DataBoundItem.Row
        Entrada_Linea.Delete()
        N_Entradas_LineasTableAdapter.Update(CMDataSet.N_Entradas_Lineas)
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
            Dim totalRow As CMDataSet.N_Entradas_TotalesRow = row
            totalRow.IVAPorciento = TipoIVAtable(count).Valor
            totalRow.IVACantidad = totalRow.SubTotal * (TipoIVAtable(count).Valor / 100)
            count = count + 1
        Next
        TipoIVAtable.AcceptChanges()
        pnl_Totales.Refresh()
        CalculaTotales()
    End Sub

    Private Sub btn_ValidarLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarLineas.Click
        If Not Guardar() Then
            Return
        End If

        Dim frm As frmValidarLineasDocumentos = New frmValidarLineasDocumentos()

        frm.TipoDocDestino = Globales.TipoDocumento.Entrada
        frm.ID_DocDestino = Entrada.ID_Entrada
        frm.CodigoClienteProveedor = Me.CtrlProveedor1.Proveedor.Codigo
        frm.DocumentosOrigen.Add(Globales.TipoDocumento.PedidoProveedor)

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'Cargar lineas
            Me.N_Entradas_LineasTableAdapter.Fill(Me.CMDataSet.N_Entradas_Lineas, Entrada.ID_Entrada)

            'Cargar Tab Totales
            CargaTotales()

        End If
    End Sub
End Class