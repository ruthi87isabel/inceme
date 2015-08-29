Imports centro_medico.UI.Reportes

Public Class frmFacturas_ADD

    Public ID_Factura As Long = -1
    Public Factura As CMDataSet.N_FacturaRow = Nothing
    Public Cliente As CMDataSet.PACIENTESRow

    Dim totalesAdapter As CMDataSetTableAdapters.N_Factura_TotalesTableAdapter = New CMDataSetTableAdapters.N_Factura_TotalesTableAdapter()
    Dim totalesTable As CMDataSet.N_Factura_TotalesDataTable = New CMDataSet.N_Factura_TotalesDataTable()

    Dim TipoIVAadapter As CMDataSetTableAdapters.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter()
    Dim TipoIVAtable As CMDataSet.N_TipoIVADataTable = New CMDataSet.N_TipoIVADataTable()
    Dim cargada As Boolean = False



    Private SubTotal As Double = 0

    Private Sub frmFacturas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'CMDataSet.N_Factura_Tipos' table. You can move, or remove it, as needed.
        Me.N_Factura_TiposTableAdapter.Fill(Me.CMDataSet.N_Factura_Tipos)

        For Each o As Object In [Enum].GetValues(GetType(Globales.Facturas_Estado))
            cmb_Estado.Items.Add(o)
        Next


        If ID_Factura <> -1 Then
            Me.N_FacturaTableAdapter.FillBy(Me.CMDataSet.N_Factura, ID_Factura)
            Factura = Me.CMDataSet.N_Factura(0)
            CtrlPaciente1.ID_PACIENTE = Factura.ID_Cliente
            dtp_FechaPagado.Value = Factura.FechaPagado
            chk_pagado.Checked = Factura.Pagado
            dtp_FechaPagado.Enabled = Not Factura.Pagado
            chk_pagado.Enabled = Not Factura.Pagado
            If Not Factura.IsID_EstadoNull() Then
                cmb_Estado.SelectedItem = CType(Factura.ID_Estado, Globales.Facturas_Estado)
            End If

            'Cargar lineas
            Me.N_Factura_LineasTableAdapter.Fill(Me.CMDataSet.N_Factura_Lineas, Factura.ID_Factura)

            'rb_Girado.Checked = Not Factura.ReciboPendiente
            'rb_NoTranspasada.Checked = Not Factura.ContabilidadTranspasada
            rb_PorteNoPagado.Checked = Not Factura.PortePagado

            Me.N_Factura_TiposComboBox.Enabled = False

            'Cargar Tab Totales
            CargaTotales()

            'Documentos Relacionados
            Me.CtrlDocProcesados1.id_Doc = ID_Factura
            Me.CtrlDocProcesados1.tipoDoc = Globales.TipoDocumento.Factura
            Me.CtrlDocProcesados1.CargaDocumentosRelacionados()
            cargada = True
        Else
            'Crearlo Nuevo

            Factura = N_FacturaBindingSource.AddNew().Row()
            Me.N_Factura_TiposComboBox.Enabled = True
            If Me.N_Factura_TiposComboBox.SelectedText.Trim.Length > 0 Then
                CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Factura", "Codigo", "000000", "where Id_TipoFactura=" & Me.N_Factura_TiposComboBox.SelectedText)
            Else
                CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Factura", "Codigo", "000000", "where Id_TipoFactura=1")
            End If
            N_Factura_TiposComboBox.SelectedIndex = 0
            Factura.ID_Estado = Globales.Facturas_Estado.Pendiente
            cmb_Estado.SelectedItem = Globales.Facturas_Estado.Pendiente
            Factura.Fecha = Date.Now
            Factura.Total = 0
            txt_Total.Text = 0
            Factura.Pagado = False
            'Factura.FechaPagado = Date.Now
            Factura.PorteDebido = False
            Factura.PortePagado = True
            Factura.PorteTexto = ""
            cargada = True

        End If

        'carga documentos adjuntos
        'Me.DocumentManager1.ConnectionString = My.MySettings.Default.FontanalsBDConnectionString
        'Me.DocumentManager1.IdCategoria = Globals.CategoriaDocumento.FacturasVentas
        'Me.DocumentManager1.QueryExcluyente = "Select idDoc From DocumentosFacturas Where idFacturas=" & Me.Factura.ID_Factura
        'Me.DocumentManager1.UpdateList()


    End Sub

    'Private Sub documentmanager1_FileDeleted(ByVal iddoc As System.Int64) Handles DocumentManager1.FileDeleted
    '    If Not Factura Is Nothing Then
    '        Me.DocumentosFacturasTableAdapter.Delete(iddoc, Factura.ID_Factura)
    '        Me.DocumentManager1.UpdateList()
    '    End If
    'End Sub
    'Private Sub documentmanager1_FileAdded(ByVal iddoc As System.Int64) Handles DocumentManager1.FileAdded
    '    If Not Factura Is Nothing Then
    '        Me.DocumentosFacturasTableAdapter.Insert(iddoc, Factura.ID_Factura)
    '        Me.DocumentManager1.UpdateList()
    '    End If
    'End Sub

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

        'Dim totalesAdapter As CMDataSetTableAdapters.N_Factura_TotalesTableAdapter = New CMDataSetTableAdapters.N_Factura_TotalesTableAdapter()
        'Dim totalesTable As CMDataSet.N_Factura_TotalesDataTable = New CMDataSet.N_Factura_TotalesDataTable()
        totalesAdapter.Fill(totalesTable, ID_Factura)



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

            Dim totalRow As CMDataSet.N_Factura_TotalesRow = row

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
            Dim totalRow As CMDataSet.N_Factura_TotalesRow = row

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

#Region "Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)"
    Private Sub AnnadeTextBoxSimple(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnName As String, ByVal txtBoxReadOnly As Boolean)

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

#Region "Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

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
        Try


            If Not sender Is Nothing Then
                If sender.Text <> "" Then
                    sender.Tag.Item(sender.DataBindings("Text").BindingMemberInfo.BindingField) = sender.Text
                    CalculaTotales()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Datos incorrectos")
            sender.Text = "0"
        End Try

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

        Dim totalRow As CMDataSet.N_Factura_TotalesRow = controlCantidad.Tag

        controlCantidad.Text = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        totalRow.Item(controlCantidad.DataBindings("Text").BindingMemberInfo.BindingField) = controlCantidad.Tag.ImporteNeto * (porciento / 100)
        Me.Validate()
        CalculaTotales()
    End Sub
#End Region

#Region "Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)"
    Private Sub AnnadeTextBoxDobles_ReadOnly(ByRef totalRow As CMDataSet.N_Factura_TotalesRow, ByVal count As Integer, ByRef controlGuia As Control, ByVal columnNamePorciento As String, ByVal columnNameCantidad As String)

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

        't6.Text = 0.ToString("N2")¡
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
            Dim t As CMDataSet.N_Factura_TotalesRow = row
            Me.totalesAdapter.UpdateQuery(t.DescuentoPorciento, t.DescuentoCantidad, t.ProntoPagoPorciento, t.ProntoPagoCantidad, t.PortesPorciento, t.PortesCantidad, t.FinanciacionPorciento, t.FinanciacionCantidad, t.ImporteNeto, t.SubTotal, t.IVAPorciento, t.IVACantidad, t.REPorciento, t.RECantidad, t.ID_Factura, t.ID_TipoIVA)
        Next
    End Sub
#End Region

    Private Function CalculaImporteNeto(ByVal ID_TipoIVA As Integer) As Double
        Return totalesAdapter.ImporteNetoQuery(ID_Factura, ID_TipoIVA)
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
        If Not Me.CtrlPaciente1.ID_PACIENTE.HasValue Then
            MsgBox("Debe indicar un paciente.", MsgBoxStyle.Exclamation)
            CtrlPaciente1.Focus()
            Return False
        End If

        Me.Validate()
        Me.N_FacturaBindingSource.EndEdit()

        If chk_pagado.Checked Then
            Factura.Pagado = True
            Factura.FechaPagado = dtp_FechaPagado.Value
        Else
            Factura.Pagado = False
            Factura.FechaPagado = dtp_FechaPagado.Value
        End If

        Factura.Total = txt_Total.Text
        Factura.ID_Cliente = CtrlPaciente1.ID_PACIENTE
        Try
            Dim n As Integer = Me.N_FacturaTableAdapter.Update(Me.CMDataSet.N_Factura)
        Catch ex As Exception

        End Try

        ID_Factura = Factura.ID_Factura


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

        Dim frm As frmFacturas_Lineas_ADD = New frmFacturas_Lineas_ADD()
        frm.ID_Factura = ID_Factura
        'If Not Me.CtrlAgenteComercial1.AgenteComercial Is Nothing Then
        '    frm.Comision = Me.CtrlAgenteComercial1.AgenteComercial.Comision
        'Else
        'frm.Comision = 0
        'End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Factura_LineasTableAdapter.Fill(Me.CMDataSet.N_Factura_Lineas, Factura.ID_Factura)
            CargaTotales()
        End If

    End Sub
#End Region

#Region "Private Sub N_Factura_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Factura_LineasDataGridView.CellFormatting"
    Private Sub N_Factura_LineasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Factura_LineasDataGridView.CellFormatting
        If (e.ColumnIndex = L.Index) Then
            e.Value = e.RowIndex + 1
        End If

    End Sub
#End Region

#Region "Private Sub N_Factura_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Factura_LineasDataGridView.SelectionChanged"
    Private Sub N_Factura_LineasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Factura_LineasDataGridView.SelectionChanged
        btn_Eliminar.Enabled = N_Factura_LineasDataGridView.SelectedRows.Count > 0
        btn_Editar.Enabled = N_Factura_LineasDataGridView.SelectedRows.Count > 0
    End Sub
#End Region

#Region "Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click"
    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        Dim Factura_Linea As CMDataSet.N_Factura_LineasRow = N_Factura_LineasDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim frm As frmFacturas_Lineas_ADD = New frmFacturas_Lineas_ADD()
        frm.ID_Factura_Linea = Factura_Linea.ID_FacturaLineas
        frm.ID_Factura = Factura_Linea.ID_Factura
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_Factura_LineasDataGridView.SelectedRows(0).Index
            Me.N_Factura_LineasTableAdapter.Fill(Me.CMDataSet.N_Factura_Lineas, Factura.ID_Factura)
            CargaTotales()
            N_Factura_LineasDataGridView.Rows(pos).Selected = True
        End If
    End Sub
#End Region


    Private Sub N_Factura_LineasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Factura_LineasDataGridView.CellDoubleClick
        btn_Editar_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim Factura_Linea As CMDataSet.N_Factura_LineasRow = N_Factura_LineasDataGridView.SelectedRows(0).DataBoundItem.Row
        Factura_Linea.Delete()
        N_Factura_LineasTableAdapter.Update(CMDataSet.N_Factura_Lineas)
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
            Dim totalRow As CMDataSet.N_Factura_TotalesRow = row
            totalRow.IVAPorciento = TipoIVAtable(count).Valor
            totalRow.IVACantidad = totalRow.SubTotal * (TipoIVAtable(count).Valor / 100)
            count = count + 1
        Next
        TipoIVAtable.AcceptChanges()
        pnl_Totales.Refresh()
        CalculaTotales()
    End Sub

    Private Sub btn_ValidarLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ValidarLineas.Click

        'Cargar 


        If Not Me.CtrlPaciente1.ID_PACIENTE.HasValue Then
            MsgBox("Debe Seleccionar un paciente.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not Guardar() Then
            Return
        End If

        Dim frm As frmValidarLineasDocumentos = New frmValidarLineasDocumentos()

        frm.TipoDocDestino = Globales.TipoDocumento.Factura
        frm.ID_DocDestino = Factura.ID_Factura
        frm.CodigoClienteProveedor = Me.CtrlPaciente1.ID_PACIENTE

        frm.ID_Cliente = CtrlPaciente1.ID_PACIENTE

        'frm.DocumentosOrigen.Add(Globals.TipoDocumento.Presupuesto)
        'frm.DocumentosOrigen.Add(Globals.TipoDocumento.Pedido)
        'frm.DocumentosOrigen.Add(Globals.TipoDocumento.Albaran)
        frm.DocumentosOrigen.Add(Globales.TipoDocumento.Ticket)

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'Cargar(lineas)
            Me.N_Factura_LineasTableAdapter.Fill(Me.CMDataSet.N_Factura_Lineas, Factura.ID_Factura)

            'Cargar Tab Totales
            CargaTotales()

        End If
    End Sub

    Private Sub bt_ImprimirFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ImprimirFactura.Click
        If Not Guardar() Then
            Return
        End If



        Dim dtableReportFACTURA As New CMDataSet.REPORT_FACTURADataTable
        Dim dAdapterReportFACTURA As New CMDataSetTableAdapters.REPORT_FACTURATableAdapter
        Dim rdatasource As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim rdatasourceTotales As New Microsoft.Reporting.WinForms.ReportDataSource

        Dim i As Integer

        Dim Descuento As Double = 0
        Dim ProntoPago As Double = 0
        Dim Portes As Double = 0
        Dim Financiacion As Double = 0
        Dim RE As Double = 0
        Dim REPorc As Double = 0
        dAdapterReportFACTURA.FillByIdFactura(dtableReportFACTURA, Me.ID_Factura)
        rdatasource.Name = "CMDataSet_REPORT_FACTURA"
        rdatasource.Value = dtableReportFACTURA

        rdatasourceTotales.Name = "CMDataSet_N_Factura_Totales"
        rdatasourceTotales.Value = totalesTable

        Dim listaparametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("IdFactura", Me.ID_Factura))

        If Not Me.N_FacturaBindingSource.Current("IRPFCantidad").GetType Is GetType(DBNull) Then
            listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Irpf", Me.N_FacturaBindingSource.Current("IRPFCantidad").ToString))
        Else
            listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Irpf", 0))
        End If
        If Not Me.N_FacturaBindingSource.Current("IRPFPorciento").GetType Is GetType(DBNull) Then
            listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("IrpfPorc", Me.N_FacturaBindingSource.Current("IRPFPorciento").ToString))
        Else
            listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("IrpfPorc", 0))
        End If

        listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalPto", Me.txt_Total.Text))

        'If Not rpGenerico.ReportViewer.LocalReport.GetParameters.Item("PasaporteCliente") Is Nothing Then
        Dim pasaporte As String = ""
        If Not CtrlPaciente1.Paciente.PASAPORTE Is Nothing Then
            pasaporte = Me.CtrlPaciente1.Paciente.PASAPORTE
        Else
            pasaporte = ""
        End If
        listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("PasaporteCliente", pasaporte))
        ' End If

        'If Not rpGenerico.ReportViewer.LocalReport.GetParameters.Item("params_LetraDNI") Is Nothing Then
        Dim letra As String = ""
        If Not CtrlPaciente1.Paciente.DNI Is Nothing Then
            letra = Globales.GetLetter(CtrlPaciente1.Paciente.DNI)
        Else
            letra = ""
        End If
        listaparametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("params_LetraDNI", letra))
        ' End If

        UI.Reportes.ReportesManager.Imprime("TPVFacturaVentas.rdlc", {rdatasource, rdatasourceTotales}, listaparametros.ToArray)

    End Sub

    Private Sub tc_Presupuestos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc_Presupuestos.SelectedIndexChanged
        Dim a As Object
        a = sender
        'If a.SelectedTab.TabIndex = 2 Then
        '    Me.grbDocumentos.Refresh()
        '    Me.DocumentManager1.UpdateList()
        'End If
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.btn_Guardar_Click(Nothing, Nothing)
    End Sub


    Private Sub dtp_FechaPagado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaPagado.ValueChanged
        Dim a As Object
        If Me.dtp_FechaPagado.Checked = True Then Me.cmb_Estado.SelectedItem = Globales.Facturas_Estado.Cobrada

    End Sub

    Private Sub CtrlCliente1_ClienteSeleccionado()
        'If Not Me.CtrlCliente1.ID_Cliente Is Nothing Then
        Factura.ID_Cliente = Me.CtrlPaciente1.ID_PACIENTE
        'End If
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        bt_ImprimirFactura_Click(Nothing, Nothing)
    End Sub

    Private Sub N_Factura_TiposComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Factura_TiposComboBox.SelectedIndexChanged
        If cargada = True Then
            If Me.ID_Factura = -1 Then
                CodigoTextBox.Text = Globales.GeneraCodigoAutomatico("N_Factura", "Codigo", "000000", "where Id_TipoFactura=" & Me.N_Factura_TiposComboBox.Text)
            End If
        End If
    End Sub


    Private Sub chk_pagado_Click(sender As Object, e As EventArgs) Handles chk_pagado.Click
        Dim facturaTemp As N_Factura
        Dim context As New CMLinqDataContext

        chk_pagado.Checked = False
        If Not Me.Guardar Then
            Return
        End If

        facturaTemp = (From f In context.N_Facturas Where f.ID_Factura = Me.ID_Factura Select f).Single

        Dim pdm As New PacienteDebitoManager(CtrlPaciente1.Paciente, context, Nothing)

        If pdm.PagarDocumentos({facturaTemp},
                                New frmPagarDocumentos(Me.dtp_FechaPagado.Value),
                                CtrlFormaPago1.ID_FormaPago,
                                Globales.Usuario.CODIGO,
                               context) = Windows.Forms.DialogResult.OK Then
            chk_pagado.Checked = True
            chk_pagado.Enabled = False
            cmb_Estado.SelectedValue = Globales.Facturas_Estado.Cobrada
            dtp_FechaPagado.Value = facturaTemp.FechaPagado
            dtp_FechaPagado.Enabled = False
            CtrlFormaPago1.ID_FormaPago = facturaTemp.ID_FormaPago
        End If

    End Sub

    Private Sub frmFacturas_ADD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ID_Factura <> -1 Then Guardar()
    End Sub
End Class