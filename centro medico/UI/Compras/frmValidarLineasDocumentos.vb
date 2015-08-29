Public Class frmValidarLineasDocumentos

    Public DocumentosOrigen As List(Of Globales.TipoDocumento) = New List(Of Globales.TipoDocumento)

    Public TipoDocDestino As Globales.TipoDocumento = Globales.TipoDocumento.Presupuesto
    Public ID_DocDestino As Long = -1
    Public CodigoClienteProveedor As String = ""
    Public ID_Cliente As Nullable(Of Integer)

    Private Sub frmValidarLineasDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.N_PedidosProveedor' table. You can move, or remove it, as needed.
        Me.N_PedidosProveedorTableAdapter.Fill(Me.CMDataSet.N_PedidosProveedor)


        If ID_Cliente.HasValue Then
            Me.N_TicketTableAdapter.FillByCliente(Me.CMDataSet.N_Ticket, ID_Cliente)
        End If

        'Llenar los tipos de Documento excepto el DocumentoDestino

        Select Case TipoDocDestino
            Case Globales.TipoDocumento.Albaran
                cmb_TipoDocumento.Items.AddRange(New Object() {Globales.TipoDocumento.Presupuesto, Globales.TipoDocumento.Pedido, Globales.TipoDocumento.ParteTrabajo})
            Case Globales.TipoDocumento.Pedido
                cmb_TipoDocumento.Items.AddRange(New Object() {Globales.TipoDocumento.Presupuesto})
            Case Globales.TipoDocumento.Factura
                cmb_TipoDocumento.Items.AddRange(New Object() {Globales.TipoDocumento.Ticket})
            Case Globales.TipoDocumento.Entrada
                cmb_TipoDocumento.Items.AddRange(New Object() {Globales.TipoDocumento.PedidoProveedor})
            Case Globales.TipoDocumento.Devolucion
                cmb_TipoDocumento.Items.AddRange(New Object() {Globales.TipoDocumento.Entrada, Globales.TipoDocumento.FacturaProveedor})
            Case Globales.TipoDocumento.FacturaProveedor
                cmb_TipoDocumento.Items.AddRange(New Object() { _
                    Globales.TipoDocumento.Entrada, _
                    Globales.TipoDocumento.PedidoProveedor}) ', _
                'Globals.TipoDocumento.Devolucion})
        End Select

        cmb_TipoDocumento.SelectedIndex = 0
    End Sub

#Region "Private Sub cmb_TipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDocumento.SelectedIndexChanged"
    Private Sub cmb_TipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDocumento.SelectedIndexChanged
        cmb_Documentos.DataSource = Nothing
        cmb_Documentos.Items.Clear()
        Select Case cmb_TipoDocumento.SelectedItem
            'Case Globals.TipoDocumento.Presupuesto
            '    Dim adapter As CMDataSetTableAdapters.N_Presupuestos_ResumenTableAdapter = New CMDataSetTableAdapters.N_Presupuestos_ResumenTableAdapter()
            '    Dim table As CMDataSet.N_Presupuestos_ResumenDataTable = New CMDataSet.N_Presupuestos_ResumenDataTable()
            '    adapter.FillBy(table)
            '    Dim dview As DataView = table.DefaultView
            '    dview.RowFilter = "Cliente = '" & CodigoClienteProveedor & "'"
            '    cmb_Documentos.DataSource = dview
            '    cmb_Documentos.DisplayMember = "Codigo"
            '    cmb_Documentos.ValueMember = "ID_Presupuesto"

            'Case Globals.TipoDocumento.Albaran
            '    Dim adapter As CMDataSetTableAdapters.N_Albaranes_ResumenTableAdapter = New CMDataSetTableAdapters.N_Albaranes_ResumenTableAdapter()
            '    Dim table As CMDataSet.N_Albaranes_ResumenDataTable = New CMDataSet.N_Albaranes_ResumenDataTable()
            '    adapter.FillBy(table)
            '    Dim dview As DataView = table.DefaultView
            '    dview.RowFilter = "Cliente = '" & CodigoClienteProveedor & "'"
            '    cmb_Documentos.DataSource = dview
            '    cmb_Documentos.DisplayMember = "Codigo"
            '    cmb_Documentos.ValueMember = "ID_Albaran"

            'Case Globals.TipoDocumento.ParteTrabajo
            '    Dim adapter As CMDataSetTableAdapters.N_PartesResumenTableAdapter = New CMDataSetTableAdapters.N_PartesResumenTableAdapter()
            '    Dim table As CMDataSet.N_PartesResumenDataTable = New CMDataSet.N_PartesResumenDataTable()
            '    adapter.Fill(table)
            '    Dim dview As DataView = table.DefaultView
            '    dview.RowFilter = "idCliente = '" & CodigoClienteProveedor & "'"
            '    cmb_Documentos.DataSource = dview
            '    cmb_Documentos.DisplayMember = "idParte"
            '    cmb_Documentos.ValueMember = "idParte"

            'Case Globals.TipoDocumento.Pedido
            '    Dim adapter As CMDataSetTableAdapters.N_Pedidos_ResumenTableAdapter = New CMDataSetTableAdapters.N_Pedidos_ResumenTableAdapter()
            '    Dim table As CMDataSet.N_Pedidos_ResumenDataTable = New CMDataSet.N_Pedidos_ResumenDataTable()
            '    adapter.FillBy(table)
            '    Dim dview As DataView = table.DefaultView
            '    dview.RowFilter = "Cliente = '" & CodigoClienteProveedor & "'"
            '    cmb_Documentos.DataSource = dview
            '    cmb_Documentos.DisplayMember = "Codigo"
            '    cmb_Documentos.ValueMember = "ID_Pedido"

            Case Globales.TipoDocumento.PedidoProveedor
                Dim adapter As CMDataSetTableAdapters.N_PedidosProveedor_ResumenTableAdapter = New CMDataSetTableAdapters.N_PedidosProveedor_ResumenTableAdapter()
                Dim table As CMDataSet.N_PedidosProveedor_ResumenDataTable = New CMDataSet.N_PedidosProveedor_ResumenDataTable()
                adapter.Fill(table)
                'Dim dview As DataView = table.DefaultView
                'dview.RowFilter = "CodigoProveedor = '" & CodigoClienteProveedor & "'"
                cmb_Documentos.DataSource = table
                cmb_Documentos.DisplayMember = "Codigo"
                cmb_Documentos.ValueMember = "ID_PedidoProveedor"
                cmb_Documentos.Update()

            Case Globales.TipoDocumento.Entrada
                Dim adapter As CMDataSetTableAdapters.N_Entradas_ResumenTableAdapter = New CMDataSetTableAdapters.N_Entradas_ResumenTableAdapter
                Dim table As CMDataSet.N_Entradas_ResumenDataTable = New CMDataSet.N_Entradas_ResumenDataTable()
                adapter.Fill(table)
                Dim dview As DataView = table.DefaultView

                dview.RowFilter = "Proveedor = '" & CodigoClienteProveedor & "'"
                cmb_Documentos.DataSource = dview
                cmb_Documentos.DisplayMember = "Codigo"
                cmb_Documentos.ValueMember = "ID_Entrada"

            Case Globales.TipoDocumento.Ticket
                Dim adapter As CMDataSetTableAdapters.N_TicketTableAdapter = New CMDataSetTableAdapters.N_TicketTableAdapter
                Dim table As CMDataSet.N_TicketDataTable = New CMDataSet.N_TicketDataTable
                adapter.FillTodosTickets(table)
                Dim dview As DataView = table.DefaultView
                dview.RowFilter = " Id_Cliente= '" & CodigoClienteProveedor & "'"
                cmb_Documentos.DataSource = dview
                cmb_Documentos.DisplayMember = "Codigo"
                cmb_Documentos.ValueMember = "ID_Ticket"
        End Select
    End Sub
#End Region

#Region "Private Sub cmb_Documentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Documentos.SelectedIndexChanged"
    Private Sub cmb_Documentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Documentos.SelectedIndexChanged
        If cmb_Documentos.SelectedIndex <> -1 Then

            Select Case cmb_TipoDocumento.SelectedItem
                'Case Globals.TipoDocumento.Presupuesto
                '    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Presupuesto
                '    N_Presupuestos_LineasTableAdapter.FillByNoValidado(CMDataSet.N_Presupuestos_Lineas, ID_Doc)
                '    LineasDataGridView.DataSource = CMDataSet.N_Presupuestos_Lineas
                '    Me.MuestraTab(1)

                'Case Globals.TipoDocumento.Albaran
                '    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Albaran
                '    ' Dim adapter As CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter = New CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter()
                '    Me.N_Albaranes_LineasTableAdapter.FillByNoValidado(CMDataSet.N_Albaranes_Lineas, ID_Doc)
                '    LineasDataGridView.DataSource = Me.N_Albaranes_LineasBindingSource
                '    Me.MuestraTab(1)

                'Case Globals.TipoDocumento.ParteTrabajo
                '    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.idParte
                '    ' Dim adapter As CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter = New CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter()
                '    Me.N_PartesTableAdapter.FillByValidado(CMDataSet.N_Partes, False, ID_Doc)
                '    LineasDataGridView2.DataSource = Me.N_PartesBindingSource
                '    Me.MuestraTab(2)

                'Case Globals.TipoDocumento.Pedido
                '    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Pedido
                '    'Dim adapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                '    Me.N_Pedidos_LineasTableAdapter.FillByNoValidado(CMDataSet.N_Pedidos_Lineas, ID_Doc)
                '    LineasDataGridView.DataSource = Me.N_Pedidos_LineasBindingSource
                '    Me.MuestraTab(1)

                Case Globales.TipoDocumento.PedidoProveedor
                    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_PedidoProveedor
                    'Dim adapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                    Me.N_PedidosProveedor_LineasTableAdapter.FillByNoValidado(CMDataSet.N_PedidosProveedor_Lineas, ID_Doc)
                    LineasDataGridView.DataSource = Me.N_PedidosProveedor_LineasBindingSource
                    Me.MuestraTab(1)

                Case Globales.TipoDocumento.Entrada
                    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Entrada
                    'Dim adapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                    Me.N_Entradas_LineasTableAdapter.FillByNoValidado(CMDataSet.N_Entradas_Lineas, ID_Doc)
                    LineasDataGridView.DataSource = Me.N_Entradas_LineasBindingSource
                    Me.MuestraTab(1)

                Case Globales.TipoDocumento.Ticket
                    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Ticket
                    'Dim adapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                    Me.N_Ticket_LineasTableAdapter.FillByNoValidados(CMDataSet.N_Ticket_Lineas, ID_Doc)
                    LineasDataGridView.DataSource = Me.N_Ticket_lineasBindingSource
                    Me.MuestraTab(1)
                    'Case Globals.TipoDocumento.Devolucion
                    '    Dim ID_Doc As Integer = cmb_Documentos.SelectedItem.Row.ID_Devolucion
                    '    'Dim adapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                    '    Me.N_Devoluciones_LineasTableAdapter.FillByNoValidado(CMDataSet.N_Devoluciones_Lineas, ID_Doc)
                    '    LineasDataGridView.DataSource = Me.N_Devoluciones_LineasBindingSource
                    '    Me.MuestraTab(1)
            End Select
        Else
            If Not cmb_TipoDocumento.SelectedItem = Globales.TipoDocumento.ParteTrabajo Then
                LineasDataGridView.DataSource = Nothing
                LineasDataGridView.Rows.Clear()
                Me.MuestraTab(1)
            Else
                'LineasDataGridView2.DataSource = Nothing
                'LineasDataGridView2.Rows.Clear()
                'Me.MuestraTab(2)
            End If
        End If
    End Sub
#End Region

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click


        If cmb_Documentos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un documento")
            Return
        End If

        Dim ID_DocOrigen As Integer = cmb_Documentos.SelectedValue
        Dim Rows As DataGridViewRowCollection

        If cmb_TipoDocumento.SelectedItem = Globales.TipoDocumento.ParteTrabajo Then
            'rows = LineasDataGridView2.Rows
        Else
            rows = LineasDataGridView.Rows
        End If

        For Each row As DataGridViewRow In rows

            If row.DataBoundItem.Row.Validado = True Then

                Dim ID_Articulo As Nullable(Of Long) = Nothing
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsID_ArticuloNull Then
                        ID_Articulo = row.DataBoundItem.Row.ID_Articulo
                    End If
                End If

                Dim Codigo As String = ""
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsCodigoNull Then
                        Codigo = row.DataBoundItem.Row.Codigo
                    End If
                End If

                Dim imagen() As Byte ' = [Array].CreateInstance(GetType(Byte), 0)
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsImagenNull Then
                        imagen = row.DataBoundItem.Row.Imagen
                    End If
                End If

                Dim observaciones As String = ""
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsObservacionesNull Then
                        observaciones = row.DataBoundItem.Row.Observaciones
                    End If
                End If

                Dim descripcion As String = ""
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsDescripcionNull Then
                        descripcion = row.DataBoundItem.Row.Descripcion
                    End If
                Else
                    descripcion = row.DataBoundItem.Row.detalles
                End If

                Dim ID_Almacen As Nullable(Of Integer) = Nothing
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If Not row.DataBoundItem.Row.IsID_AlmacenNull Then
                        ID_Almacen = row.DataBoundItem.Row.ID_Almacen
                    End If
                End If

                Dim IvaIncluido As Boolean
                Dim Comision As Double
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    If row.DataBoundItem.row.IVAIncluido.GetType Is GetType(DBNull) Then
                        IvaIncluido = False
                    End If

                    '    If Not row.DataBoundItem.Row.IsComisionNull Then
                    '        Comision = 0
                    '    End If
                    'Else
                    '    IvaIncluido = False
                    '    Comision = 0
                End If

                Dim Precio As Double = 0
                Dim Descuento1 As Double = 0
                Dim Descuento2 As Double = 0
                Dim Descuento3 As Double
                Dim Total As Double = 0
                Dim idTipoIva As Integer
                Dim Costo As Double = 0
                Dim Cantidad As Double = 0
                Dim HoraIni As DateTime = Now
                Dim horafin As DateTime = Now
                If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.ParteTrabajo Then
                    Precio = row.DataBoundItem.Row.Precio
                    Descuento1 = row.DataBoundItem.Row.Descuento1
                    Descuento2 = row.DataBoundItem.Row.Descuento2
                    Descuento3 = row.DataBoundItem.Row.Descuento3
                    Total = row.DataBoundItem.Row.Total
                    idTipoIva = row.DataBoundItem.Row.ID_TipoIVA
                    If cmb_TipoDocumento.SelectedItem <> Globales.TipoDocumento.Ticket Then _
                        Costo = row.DataBoundItem.Row.Costo
                    Cantidad = row.DataBoundItem.Row.Cantidad
                Else
                    Precio = 0
                    Descuento1 = 0
                    Descuento2 = 0
                    Descuento3 = 0
                    HoraIni = row.DataBoundItem.row.horaIni
                    horafin = row.DataBoundItem.Row.horaFin
                    Total = DateDiff(DateInterval.Second, HoraIni, horafin) / 3600
                    idTipoIva = 1 'Globals.Config.IvaPorDefecto
                    Costo = 0
                    Cantidad = Total
                End If
                'End If
                Dim TipoDocSeleccionado As Globales.TipoDocumento
                TipoDocSeleccionado = CType(Me.cmb_TipoDocumento.SelectedItem, Globales.TipoDocumento)
                'Insertar la linea segun el tipo de documento
                Select Case TipoDocDestino

                    'Case Globals.TipoDocumento.Presupuesto, un presupuesto no valida lineas de nadie

                    'Case Globals.TipoDocumento.Albaran
                    '    Dim lineaAlbaranAdapter As CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter = New CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter()
                    '    lineaAlbaranAdapter.Insert(ID_DocDestino, _
                    '                                Codigo, _
                    '                                ID_Articulo, _
                    '                                descripcion, _
                    '                                Precio, _
                    '                                Descuento1, _
                    '                                Descuento2, _
                    '                                Descuento3, _
                    '                                Total, _
                    '                                idTipoIva, _
                    '                                IvaIncluido, _
                    '                                Costo, _
                    '                                imagen, _
                    '                                observaciones, _
                    '                                ID_Almacen, _
                    '                                0, _
                    '                                Comision, _
                    '                                ID_DocOrigen, _
                    '                                CType(TipoDocSeleccionado, Integer), 0, _
                    '                                Cantidad)

                    'Case Globals.TipoDocumento.Pedido
                    '    Dim lineaPedidoAdapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter()
                    '    lineaPedidoAdapter.Insert(ID_DocDestino, _
                    '                                Codigo, _
                    '                                ID_Articulo, _
                    '                                descripcion, _
                    '                                Cantidad, _
                    '                                Precio, _
                    '                                Descuento1, _
                    '                                Descuento2, _
                    '                            Descuento3, _
                    '                                Total, _
                    '                               idTipoIva, _
                    '                                IvaIncluido, _
                    '                                observaciones, _
                    '                                ID_Almacen, _
                    '                                0, _
                    '                                0, _
                    '                                ID_DocOrigen, _
                    '                                CInt(TipoDocSeleccionado), imagen, Costo, Comision)


                    'Case Globals.TipoDocumento.Factura

                    '    Dim lineaFacturaAdapter As CMDataSetTableAdapters.N_Facturas_LineasTableAdapter = New CMDataSetTableAdapters.N_Facturas_LineasTableAdapter()
                    '    lineaFacturaAdapter.Insert(ID_DocDestino, _
                    '        Codigo, _
                    '        ID_Articulo, _
                    '        descripcion, _
                    '        Precio, _
                    '        Descuento1, _
                    '        Descuento2, _
                    '        Descuento3, _
                    '        Total, _
                    '        idTipoIva, _
                    '        IvaIncluido, _
                    '        0, _
                    '        imagen, _
                    '        observaciones, _
                    '        ID_Almacen, _
                    '        0, _
                    '        Comision, _
                    '        ID_DocOrigen, _
                    '        CType(TipoDocSeleccionado, Integer), _
                    '        CType(Cantidad, Long))

                    Case Globales.TipoDocumento.Entrada

                        Dim lineaEntradaAdapter As CMDataSetTableAdapters.N_Entradas_LineasTableAdapter = New CMDataSetTableAdapters.N_Entradas_LineasTableAdapter()
                        lineaEntradaAdapter.Insert(ID_DocDestino, _
                            Codigo, _
                            ID_Articulo, _
                            descripcion, _
                            Cantidad, _
                            Precio, _
                            Descuento1, _
                            Descuento2, _
                            Descuento3, _
                            Total, _
                            idTipoIva, _
                            IvaIncluido, _
                            0, _
                            imagen, _
                            observaciones, _
                            ID_Almacen, _
                            0, _
                            ID_DocOrigen, _
                            Globales.TipoDocumento.Entrada)

                        'CType(TipoDocSeleccionado, Integer))

                        'Case Globals.TipoDocumento.Devolucion

                        '    Dim lineaDevolucionAdapter As CMDataSetTableAdapters.N_Devoluciones_LineasTableAdapter = New CMDataSetTableAdapters.N_Devoluciones_LineasTableAdapter()
                        '    lineaDevolucionAdapter.Insert(Codigo, _
                        '        0, descripcion, _
                        '       Descuento1, _
                        '        Descuento2, _
                        '        Descuento3, _
                        '        ID_Articulo, _
                        '        ID_DocDestino, _
                        '       idTipoIva, _
                        '        IvaIncluido, _
                        '       imagen, _
                        '        observaciones, _
                        '         Precio, _
                        '        Total, _
                        '    ID_Almacen, 0, Cantidad, _
                        '    CType(TipoDocSeleccionado, Integer), _
                        '    ID_DocOrigen)


                    Case Globales.TipoDocumento.FacturaProveedor

                        Dim lineaFacturaProveedorAdapter As CMDataSetTableAdapters.N_FacturasRecibidas_LineasTableAdapter = New CMDataSetTableAdapters.N_FacturasRecibidas_LineasTableAdapter()
                        lineaFacturaProveedorAdapter.Insert(Cantidad, _
                            Codigo, _
                            0, _
                            descripcion, _
                            Descuento1, _
                            Descuento2, _
                            Descuento3, _
                            ID_Articulo, ID_DocDestino, _
                            idTipoIva, _
                            IvaIncluido, _
                            imagen, _
                            observaciones, _
                            Precio, _
                            Total, _
                            ID_Almacen, _
                            0, _
                            ID_DocOrigen, _
                            CType(TipoDocSeleccionado, Integer))
                    Case Globales.TipoDocumento.Factura

                        Dim lineaFacturaAdapter As CMDataSetTableAdapters.N_Factura_LineasTableAdapter = New CMDataSetTableAdapters.N_Factura_LineasTableAdapter()
                        lineaFacturaAdapter.Insert(Me.ID_DocDestino, _
                            Codigo, _
                            ID_Articulo, _
                            descripcion, _
                            Cantidad, _
                            Precio, _
                            Descuento1, _
                            Descuento2, _
                            Descuento3, _
                            Total, _
                            idTipoIva, _
                            IvaIncluido, _
                            Costo, _
                            imagen, _
                            observaciones, _
                            ID_Almacen, _
                            1, _
                            ID_DocOrigen, _
                            CInt(TipoDocSeleccionado))
                End Select
            End If
        Next

        'Marcarlo como Validado

        If cmb_Documentos.SelectedIndex <> -1 Then
            Select Case cmb_TipoDocumento.SelectedItem
                'Case Globals.TipoDocumento.Presupuesto
                '    Me.N_Presupuestos_LineasBindingSource.EndEdit()
                '    Me.N_Presupuestos_LineasTableAdapter.Update(CMDataSet.N_Presupuestos_Lineas)
                'Case Globals.TipoDocumento.Albaran
                '    Me.N_Albaranes_LineasBindingSource.EndEdit()
                '    Me.N_Albaranes_LineasTableAdapter.Update(CMDataSet.N_Albaranes_Lineas)
                'Case Globals.TipoDocumento.ParteTrabajo
                '    Me.N_PartesBindingSource.EndEdit()
                '    Me.N_PartesTableAdapter.Update(CMDataSet.N_Partes)
                'Case Globals.TipoDocumento.Pedido
                '    Me.N_Pedidos_LineasBindingSource.EndEdit()
                '    Me.N_Pedidos_LineasTableAdapter.Update(CMDataSet.N_Pedidos_Lineas)
                Case Globales.TipoDocumento.PedidoProveedor
                    Me.N_PedidosProveedor_LineasBindingSource.EndEdit()
                    Me.N_PedidosProveedor_LineasTableAdapter.Update(CMDataSet.N_PedidosProveedor_Lineas)
                Case Globales.TipoDocumento.Entrada
                    Me.N_Entradas_LineasBindingSource.EndEdit()
                    Me.N_Entradas_LineasTableAdapter.Update(CMDataSet.N_Entradas_Lineas)
                Case Globales.TipoDocumento.Ticket
                    Me.N_Ticket_lineasBindingSource.EndEdit()
                    Me.N_Ticket_LineasTableAdapter.Update(CMDataSet.N_Ticket_Lineas)
                    'Case Globals.TipoDocumento.Devolucion
                    '    Me.N_Devoluciones_LineasBindingSource.EndEdit()
                    '    Me.N_Devoluciones_LineasTableAdapter.Update(CMDataSet.N_Devoluciones_Lineas)
            End Select
        End If


        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' Se muestra uno u otro tab dependiendo del indice pasado.
    ''' </summary>
    ''' <param name="index">Valor 1 muestra el tab1 (para documentos que no sean partes de trabajo), 
    ''' Valor 2 muestra el tab2 (partes de trabajo)</param>
    ''' <remarks></remarks>
    Private Sub MuestraTab(ByVal index As Integer)
        If index = 1 Then
            Me.TabControl1.SelectedTab = Me.tb_Lineas
            'If Not Me.TabControl1.TabPages.Contains(Me.TabPage1) Then
            '    Me.TabControl1.TabPages.Add(TabPage1)
            'End If
            'If Me.TabControl1.TabPages.Contains(Me.TabPage2) Then
            '    Me.TabControl1.TabPages.Remove(Me.TabPage2)
            'End If
        Else
            'Me.TabControl1.SelectedTab = Me.TabPage2
            'If Not Me.TabControl1.TabPages.Contains(Me.TabPage2) Then
            '    Me.TabControl1.TabPages.Add(TabPage2)
            'End If
            'If Me.TabControl1.TabPages.Contains(Me.TabPage1) Then
            '    Me.TabControl1.TabPages.Remove(Me.TabPage1)
            'End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_MarcarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MarcarTodos.Click
        For Each row As DataGridViewRow In LineasDataGridView.Rows
            Try
                row.DataBoundItem.Row.Validado = True
            Catch ex As Exception

            End Try
        Next

    End Sub


    Private Sub btn_Desmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Desmarcar.Click
        For Each row As DataGridViewRow In LineasDataGridView.Rows
            row.DataBoundItem.Row.Validado = False
        Next
    End Sub
End Class