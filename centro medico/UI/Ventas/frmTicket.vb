Imports centro_medico.UI.Reportes

Public Class frmTicket

    Public ID_Ticket As Integer = -1
    Public Ticket As CMDataSet.N_TicketRow
    Public IDCITA As Integer = -1

#Region "Variables globales"
    Dim rayIvas As Double(,)
    Dim Cambios As Boolean = False

#End Region

    Public Sub NuevoTicket()
        Dim cambios As Boolean = False

        Ticket = Me.N_TicketBindingSource.AddNew().Row()

        Ticket.Fecha = Date.Now
        Ticket.Total = 0
        Ticket.Pagado = False
        Ticket.PortePagado = False
        Ticket.FechaPagado = Date.Now
        Ticket.ID_TipoTicket = 1
        Ticket.Codigo = Globales.GeneraCodigoAutomatico("N_Ticket", "ID_Ticket", "00000")

        'Me.CMDataSet.N_Ticket.AddN_TicketRow(Ticket)

        'ID_TicketTextBox.Text = Ticket.ID_Ticket
        'ID_Ticket = Me.N_TicketTableAdapter.MaxId

    End Sub

#Region "Funciones y procedimientos"


    Public Sub SeleccionaPaciente(ByVal idPaciente As Integer)
        CtrlPaciente1.ID_PACIENTE = idPaciente
    End Sub



    Private Function HayCambios() As Boolean
        Return Cambios
    End Function
    Private Sub Guardar()

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            CtrlPaciente1.Focus()
            Return
        End If

        'Me.Validate()

        'Guardo cabecera ticket

        Me.N_TicketBindingSource.EndEdit()
        Me.N_TicketTableAdapter.Update(Me.CMDataSet.N_Ticket)
        Me.ID_Ticket = Ticket.ID_Ticket

        'Guardo lineas ticket
        Me.N_Ticket_TotalesBindingSource.EndEdit()
        Me.N_Ticket_LineasTableAdapter.Update(Me.CMDataSet.N_Ticket_Lineas)
        Cambios = False

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CargarTicket(ByVal idTicket As Integer)
        Try
            Dim res As MsgBoxResult
            If HayCambios() = True Then
                res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
                If res = MsgBoxResult.No Then Exit Sub
            End If

            Me.N_TicketTableAdapter.Fill(Me.CMDataSet.N_Ticket, idTicket)
            If Me.CMDataSet.N_Ticket.Count > 0 Then
                Ticket = Me.CMDataSet.N_Ticket(0)
            Else
                MessageBox.Show("Ticket no encontrado")
                Me.Close()
            End If

            If CMDataSet.N_Ticket.Rows.Count > 0 And Not CMDataSet.N_Ticket.Rows(0).IsNull("ID_Cliente") Then
                Me.CtrlPaciente1.ID_PACIENTE = CMDataSet.N_Ticket.Rows(0).Item("ID_Cliente")
            Else
                Return
            End If

            Me.N_Ticket_LineasTableAdapter.Fill(Me.CMDataSet.N_Ticket_Lineas, idTicket)

            Me.CMDataSet.N_Ticket_Lineas.ID_TicketColumn.DefaultValue = Me.ID_TicketTextBox.Text

            'si esta pagado, el datapicker de fecha pagado debe estar enable = true
            If Me.PagadoCheckBox.Checked = True Then Me.FechaPagadoDateTimePicker.Enabled = True

            'Cargo los documentos a los que este ticket puede haber sido procesado
            If IsNumeric(Me.ID_TicketTextBox.Text) Then
                Me.CtrlDocProcesados1.TreeView1.Nodes.Clear()
                Me.CtrlDocProcesados1.id_Doc = Me.ID_TicketTextBox.Text
                Me.CtrlDocProcesados1.tipoDoc = Globales.TipoDocumento.Ticket
                Me.CtrlDocProcesados1.CargaDocumentosRelacionados()
            End If
            Me.N_Ticket_LineasDataGridView_CellValidated(Nothing, Nothing)
            Cambios = False
            grpTodo.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cargaFormaPago()
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)
    End Sub

    Private Sub addLineaTicket()
        Dim row As CMDataSet.N_Ticket_LineasRow
        row = Me.CMDataSet.N_Ticket_Lineas.NewN_Ticket_LineasRow

        'valores por defecto
        row.Cantidad = 1
        row.Codigo = ""
        row.Costo = 0
        row.Descripcion = ""
        row.Descuento1 = 0
        row.Descuento2 = 0
        row.Descuento3 = 0
        row.ID_Ticket = Me.Ticket.ID_Ticket
        row.Validado = False
        If Globales.Configuracion.ivaIncluido = 0 Then
            row.IVAIncluido = False
        Else
            row.IVAIncluido = True
        End If

        CMDataSet.N_Ticket_Lineas.Rows.Add(row)

        'Gana el foco el campo Articulo de la ultima fila que es la que acabo de añadir.
        If Me.N_Ticket_LineasDataGridView.Rows.Count > 0 Then
            Me.N_Ticket_LineasDataGridView.ClearSelection()
            Me.N_Ticket_LineasDataGridView.MultiSelect = False
            Me.N_Ticket_LineasDataGridView.Focus()
            Me.N_Ticket_LineasDataGridView.Rows.GetLastRow(DataGridViewElementStates.Displayed)
            Me.N_Ticket_LineasDataGridView.Rows(Me.N_Ticket_LineasDataGridView.Rows.Count - 1).Cells("ColCodigo").Selected = True
            Me.N_Ticket_LineasDataGridView.MultiSelect = True
        End If
        Cambios = True
        N_Ticket_LineasDataGridView.Update()
    End Sub

    Private Sub CargaIva()
        Dim x As Integer = 0
        Dim z As Integer = 0
        ReDim rayIvas(1, 0)
        Me.N_TipoIVATableAdapter.Fill(Me.CMDataSet.N_TipoIVA)
        For x = 0 To Me.CMDataSet.N_TipoIVA.Rows.Count - 1
            If x = 0 Then
                rayIvas(0, x) = CMDataSet.N_TipoIVA.Rows(x).Item("Valor")
            Else
                z = UBound(rayIvas, 2) + 1
                If UBound(rayIvas, 2) > -1 Then ReDim Preserve rayIvas(1, z)
                rayIvas(0, z) = CMDataSet.N_TipoIVA.Rows(x).Item("Valor")
            End If
        Next
    End Sub
    Private Sub CargaArticulo(ByRef indiceFila As Integer)
        With N_Ticket_LineasDataGridView
            'Obtener info sobre el codigo del articulo indicado en el campo codigo y establecer el campo IdArticulo
            Dim Articulo As CMDataSet.N_ArticulosRow
            If Not Me.N_Ticket_LineasDataGridView.Rows(indiceFila).Cells("ColCodigo").Value Is Nothing Then
                Me.N_ArticulosTableAdapter.FillByCodigo(Me.CMDataSet.N_Articulos, Me.N_Ticket_LineasDataGridView.Rows(indiceFila).Cells("ColCodigo").Value)
            Else
                Exit Sub
            End If
            If Me.CMDataSet.N_Articulos.Rows.Count > 0 Then
                Articulo = CMDataSet.N_Articulos.Rows(0)
                'Compruebo si ese articulo se puede usar.
                If Articulo.IsNoPermitirUtilzarArticuloNull = False Then
                    If Articulo.NoPermitirUtilzarArticulo = True Then
                        MsgBox("Este artículo esta deshabilitado para su uso.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
                .Rows(indiceFila).Cells("ColIdArticulo").Value = Articulo.ID_Articulo
                If Articulo.IsDescripcionGeneralNull = False Then
                    .Rows(indiceFila).Cells("ColDescripcion").Value = Articulo.DescripcionGeneral
                End If
                If Articulo.IsID_TipoIVANull = False Then
                    .Rows(indiceFila).Cells("ColTipoIva").Value = Articulo.ID_TipoIVA
                End If
                If Not Articulo.PrecioVentaRecomendado.GetType Is GetType(DBNull) Then
                    .Rows(indiceFila).Cells("ColPrecio").Value = Articulo.PrecioVentaRecomendado
                End If

                If Articulo.IsMensajeEmergenteNull = False Then
                    If Articulo.MensajeEmergente.Trim.Length > 0 Then
                        MsgBox(Articulo.MensajeEmergente, MsgBoxStyle.Information, "Mensaje del artículo")
                    End If
                End If

                'asigno el primer valor del almacen
                If Articulo.EsEstocable = True Then
                    If Me.CMDataSet.N_Almacen.Rows.Count > 0 Then
                        .Rows(indiceFila).Cells("ColIdAlmacen").Value = Me.CMDataSet.N_Almacen.Rows(0).Item("Id_Almacen")
                    End If
                End If

            End If
        End With

        Cambios = True
    End Sub
    Private Sub EliminarFila(ByRef indicefila As Integer)
        Dim res As MsgBoxResult
        res = MsgBox("Esta acción no podrá deshacerse. ¿Seguro que desea continuar?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.No Then Exit Sub
        Me.N_Ticket_LineasDataGridView.Rows.RemoveAt(indicefila)
        Me.N_Ticket_LineasDataGridView_CellValidated(Nothing, Nothing)
        Cambios = True
    End Sub
    Private Sub ElminarTicket()
        Dim res As MsgBoxResult
        res = MsgBox("Se dispone a eliminar un ticket. Esta acció no podrá deshacerse ¿Desea continuar borrando el ticket?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.No Then Exit Sub
        Me.N_TicketBindingSource.RemoveCurrent()
        CMDataSet.N_Ticket_Lineas.Clear()
        Me.Guardar()
        grpTodo.Enabled = False
    End Sub
    Private Sub Imprimir()


        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim param(12) As Microsoft.Reporting.WinForms.ReportParameter
        If CMDataSet.N_Ticket_Lineas.Rows.Count > 0 Then
            'asigno valor a los parametros
            param(0) = New Microsoft.Reporting.WinForms.ReportParameter("NombreCompletoCliente", Me.CtrlPaciente1.NombreCompleto)
            param(1) = New Microsoft.Reporting.WinForms.ReportParameter("ResumenIva", Me.txtInfoIva.Text.Trim)
            param(2) = New Microsoft.Reporting.WinForms.ReportParameter("NombreEmpresa", Globales.Configuracion.nombrecomercial)
            param(3) = New Microsoft.Reporting.WinForms.ReportParameter("DireccionEmpresa", Globales.Configuracion.domicilio)
            param(4) = New Microsoft.Reporting.WinForms.ReportParameter("PoblacionEmpresa", Globales.Configuracion.localidad)
            param(5) = New Microsoft.Reporting.WinForms.ReportParameter("CodigoPostalEmpresa", Globales.Configuracion.CP)
            param(6) = New Microsoft.Reporting.WinForms.ReportParameter("ProvinciaEmpresa", Globales.Configuracion.provincia)
            param(7) = New Microsoft.Reporting.WinForms.ReportParameter("CifEmpresa", Globales.Configuracion.CIF)
            param(8) = New Microsoft.Reporting.WinForms.ReportParameter("TelefonoEmpresa", Globales.Configuracion.Tlfno1)
            param(9) = New Microsoft.Reporting.WinForms.ReportParameter("EmailEmpresa", Globales.Configuracion.Email)
            param(10) = New Microsoft.Reporting.WinForms.ReportParameter("WebEmpresa", Globales.Configuracion.web)
            param(11) = New Microsoft.Reporting.WinForms.ReportParameter("NTicket", Me.ID_TicketTextBox.Text)
            param(12) = New Microsoft.Reporting.WinForms.ReportParameter("TotalTicket", Me.TotalTextBox.Text)

            ds.Name = "CMDataSet_N_Ticket_Lineas"
            ds.Value = CMDataSet.N_Ticket_Lineas

            UI.Reportes.ReportesManager.Imprime("TPVTicket.rdlc", {ds}, param)

        End If
    End Sub
    Private Sub Cargaalmacenes()
        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
    End Sub
#End Region

#Region "Eventos"


    Private Sub frmTicket_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        If HayCambios() = True Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmTicket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'EVENTOS DISPARADOS POR LAS TECLAS F
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Lectura Then
            Select Case e.KeyCode
                Case Keys.F4
                    Me.Imprimir()
            End Select
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Modificar Then
            Select Case e.KeyCode
                Case Keys.F4
                    Me.Imprimir()
                Case Keys.F5
                    Me.addLineaTicket()
                Case Keys.F6
                    Me.btEliminar_Click(Nothing, Nothing)
            End Select
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Total Then
            Select Case e.KeyCode
                Case Keys.F1
                    Me.NuevoTicket()
                Case Keys.F2
                    Me.Guardar()
                Case Keys.F3
                    Me.ElminarTicket()
                Case Keys.F4
                    Me.Imprimir()
                Case Keys.F5
                    Me.addLineaTicket()
                Case Keys.F6
                    Me.btEliminar_Click(Nothing, Nothing)
            End Select
        End If


    End Sub


    Private Sub frmTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargaalmacenes()
        Me.CargaIva()
        cargaFormaPago()
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Lectura Then
            Me.tlsbNuevo.Enabled = False
            Me.tsbGuardar.Enabled = False
            Me.tsbCancelar.Enabled = False
            Me.btAddLinea.Enabled = False
            Me.btEliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Modificar Then
            Me.tlsbNuevo.Enabled = False
            Me.tsbGuardar.Enabled = False
            Me.tsbCancelar.Enabled = True
            Me.btAddLinea.Enabled = True
            Me.btEliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Total Then
            Me.tlsbNuevo.Enabled = True
            Me.tsbGuardar.Enabled = True
            Me.tsbCancelar.Enabled = True
            Me.btAddLinea.Enabled = True
            Me.btEliminar.Enabled = True
        End If

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno Then
            Me.tsb_DebitoPaciente.Visible = False
        End If

        If ID_Ticket <> -1 Then
            CargarTicket(ID_Ticket)
        Else
            NuevoTicket()
        End If

        If IDCITA <> -1 Then
            ImportarLineasDeCita(IDCITA)
        End If

    End Sub

    Private Sub ImportarLineasDeCita(ByVal IDCITA As Integer)

        'Dim adapter As New CMDataSetTableAdapters.LineasCitasTableAdapter()
        'adapter.FillByIdCita(CMDataSet.LineasCitas, IDCITA)

        'For Each lineaCita As CMDataSet.LineasCitasRow In CMDataSet.LineasCitas
        '    Dim lineaTicket As CMDataSet.N_Ticket_LineasRow = CMDataSet.N_Ticket_Lineas.NewRow()
        '    'Aqui hay que annadir las lineas
        'Next
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub ReferenciaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenciaTextBox.TextChanged
        Cambios = True
    End Sub

    Private Sub FechaPagadoDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaPagadoDateTimePicker.ValueChanged
        Cambios = True
    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaDateTimePicker.ValueChanged
        Cambios = True
    End Sub
    Private Sub tlsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbNuevo.Click
        Me.NuevoTicket()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.Guardar()

    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.ElminarTicket()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CargarTicket(Integer.Parse(ID_TicketTextBox.Text))
    End Sub

    Private Sub btAddLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddLinea.Click

        Me.N_TicketBindingSource.EndEdit()
        Me.N_TicketTableAdapter.Update(Me.CMDataSet.N_Ticket)
        Me.ID_Ticket = Ticket.ID_Ticket

        Me.addLineaTicket()
    End Sub

    Private Sub N_Ticket_LineasDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Ticket_LineasDataGridView.CellEndEdit
        'If VengoDeGuardar = False Then
        If e.ColumnIndex = 1 Then
            Me.CargaArticulo(e.RowIndex)
        End If
        Cambios = True
        'End If
    End Sub


    Private Sub N_Ticket_LineasDataGridView_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Ticket_LineasDataGridView.CellValidated
        'Calcular total de la linea
        Dim TotalLinea As Double = 0
        Dim cantidad As Double = 0
        Dim Precio As Double = 0
        Dim Descuento1 As Double = 0
        Dim Descuento2 As Double = 0
        Dim Descuento3 As Double = 0
        Dim ImporteDescuentos As Double = 0
        Dim i As Integer = 0
        Dim ivaIncluido As Boolean = True
        Dim iva As Integer = 0
        Dim x As Integer = 0
        Dim z As Integer = 0



        With N_Ticket_LineasDataGridView
            If Not e Is Nothing Then
                cantidad = .Rows(e.RowIndex).Cells("ColCantidad").Value
                If Not .Rows(e.RowIndex).Cells("ColPrecio").Value.GetType Is GetType(DBNull) Then
                    Precio = .Rows(e.RowIndex).Cells("ColPrecio").Value
                Else
                    Precio = 0
                End If
                If Not .Rows(e.RowIndex).Cells("ColDescuento1").Value.GetType Is GetType(DBNull) Then
                    Descuento1 = .Rows(e.RowIndex).Cells("ColDescuento1").Value
                Else
                    Descuento1 = 0
                End If
                If Not .Rows(e.RowIndex).Cells("ColDescuento2").Value.GetType Is GetType(DBNull) Then
                    Descuento2 = .Rows(e.RowIndex).Cells("ColDescuento2").Value
                Else
                    Descuento2 = 0
                End If
                If Not .Rows(e.RowIndex).Cells("ColDescuento3").Value.GetType Is GetType(DBNull) Then
                    Descuento3 = .Rows(e.RowIndex).Cells("ColDescuento3").Value
                Else
                    Descuento3 = 0
                End If

                ImporteDescuentos = (cantidad * Precio) * (Descuento1 / 100)
                ImporteDescuentos += (cantidad * Precio) * (Descuento2 / 100)
                ImporteDescuentos += (cantidad * Precio) * (Descuento3 / 100)

                TotalLinea = (cantidad * Precio) - ImporteDescuentos

                .Rows(e.RowIndex).Cells("colTotal").Value = TotalLinea
            End If
            'Calcular total del ticket
            TotalLinea = 0
            ImporteDescuentos = 0
            Descuento1 = 0
            Descuento2 = 0
            Descuento3 = 0
            Precio = 0
            cantidad = 0
            'reseteo los valores del iva
            For x = 0 To UBound(rayIvas, 2)
                rayIvas(1, x) = 0
            Next
            x = 0
            'fin reseteo
            '            Me.ColIvaIncluido.Visible = True
            For i = 0 To .Rows.Count - 1
                If Not .Rows(i).Cells("ColIvaIncluido").Value.GetType Is GetType(DBNull) Then
                    ivaIncluido = .Rows(i).Cells("colIvaIncluido").Value
                Else
                    ivaIncluido = False
                End If
                If Not .Rows(i).Cells("ColTipoIva").Value.GetType Is GetType(DBNull) Then
                    iva = .Rows(i).Cells("ColTipoIva").FormattedValue
                Else
                    iva = 0
                End If
                If Not .Rows(i).Cells("ColPrecio").Value.GetType Is GetType(DBNull) Then
                    Precio = .Rows(i).Cells("ColPrecio").Value
                Else
                    Precio = 0
                End If
                If Not .Rows(i).Cells("ColCantidad").Value.GetType Is GetType(DBNull) Then
                    cantidad = .Rows(i).Cells("ColCantidad").Value
                Else
                    cantidad = 0
                End If
                If Not .Rows(i).Cells("ColDescuento1").Value.GetType Is GetType(DBNull) Then
                    Descuento1 = .Rows(i).Cells("ColDescuento1").Value
                Else
                    Descuento1 = 0
                End If
                If Not .Rows(i).Cells("ColDescuento2").Value.GetType Is GetType(DBNull) Then
                    Descuento2 = .Rows(i).Cells("ColDescuento2").Value
                Else
                    Descuento2 = 0
                End If
                If Not .Rows(i).Cells("ColDescuento3").Value.GetType Is GetType(DBNull) Then
                    Descuento3 = .Rows(i).Cells("ColDescuento3").Value
                Else
                    Descuento3 = 0
                End If

                If ivaIncluido = True Then
                    TotalLinea += cantidad * Precio
                Else
                    TotalLinea += (cantidad * Precio) + (cantidad * Precio * iva / 100)
                    For x = 0 To UBound(rayIvas, 2)
                        If rayIvas(0, x) = iva Then
                            rayIvas(1, x) += (cantidad * Precio * iva / 100)
                        End If
                    Next

                End If
                'Calculamos el importe de los descuentos
                ImporteDescuentos += (cantidad * Precio) * (Descuento1 / 100)
                ImporteDescuentos += (cantidad * Precio) * (Descuento2 / 100)
                ImporteDescuentos += (cantidad * Precio) * (Descuento3 / 100)
            Next
            Me.TotalTextBox.Text = String.Format("{0:C}", TotalLinea - ImporteDescuentos)
            x = 0
            'Cuadro resumen de iva
            Me.txtInfoIva.Text = ""
            For x = 0 To UBound(rayIvas, 2)
                Me.txtInfoIva.Text += "- " & rayIvas(0, x) & "% " & String.Format("{0:C}", rayIvas(1, x)) & vbCrLf
            Next
        End With

    End Sub


    Private Sub CtrlCliente1_ClienteSeleccionado()
        'Me.ID_ClienteTextBox.Text = CtrlCliente1.ID_Cliente.Value

        Cambios = True
    End Sub



    Private Sub PagadoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagadoCheckBox.CheckedChanged
        If PagadoCheckBox.Checked = True Then
            Me.FechaPagadoDateTimePicker.Enabled = True
        Else
            Me.FechaPagadoDateTimePicker.Enabled = False
        End If
        Cambios = True

    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim filaseleccionada As Integer = -1

        If Me.N_Ticket_LineasDataGridView.SelectedCells.Count > 0 Then
            filaseleccionada = Me.N_Ticket_LineasDataGridView.SelectedCells(0).RowIndex
            Me.EliminarFila(filaseleccionada)
        End If
    End Sub

    Private Sub ID_FormaPagoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_FormaPagoComboBox.SelectedIndexChanged
        Cambios = True
    End Sub
#End Region

    Private Sub N_Ticket_LineasDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles N_Ticket_LineasDataGridView.DataError
        Dim a As Object
    End Sub


    Private Sub N_Ticket_LineasDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Ticket_LineasDataGridView.CellClick
        If e.ColumnIndex = 2 Then 'significa que han pulsado en la columna tipo imagen que usamos para busqueda de articulos
            Dim articulo As New frmArticulos
            articulo.Modo = Globales.ModoParaFormas.Seleccion
            articulo.ShowInTaskbar = False
            articulo.ShowDialog()
            If articulo.DialogResult = Windows.Forms.DialogResult.OK Then
                If Not articulo.Articulo Is Nothing Then
                    Me.N_Ticket_LineasDataGridView.Rows(e.RowIndex).Cells("ColCodigo").Value = articulo.Articulo.Codigo
                    Me.CargaArticulo(e.RowIndex)
                    Me.Validate()
                End If
            End If
        End If

    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        btn_EmitirCita.Enabled = True
        tsb_DebitoPaciente.Enabled = True
        CtrlStatusPaciente1.ID_PACIENTE = IdPaciente
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        btn_EmitirCita.Enabled = False
        tsb_DebitoPaciente.Enabled = False
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub btn_EmitirCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EmitirCita.Click
        Dim frm As New form_citas("Nueva Cita", Enums.Accion.Insertar, DateTime.Now, Nothing)
        frm.CargaPaciente(CtrlPaciente1.ID_PACIENTE, Enums.Accion.Insertar)

        frm.ShowDialog()

    End Sub

    Private Sub tsb_DebitoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DebitoPaciente.Click

        'Salvar para prevenir errores de concurrencia
        Me.Guardar()

        Dim frm As New frmPacienteDebito
        frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
        'frm.dtp_Inicio.Value = FechaDateTimePicker.Value
        'frm.dtp_Inicio.Checked = True

        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Tickets
        frm.ShowDialog()

        Me.CargarTicket(ID_Ticket)

        For Each ticket As N_Ticket In frm.TicketsPagados
            If ticket.ID_Ticket = Integer.Parse(ID_TicketTextBox.Text) Then
                'Actualizar la forma de pago
                'Ponerla como pagada
                ID_FormaPagoComboBox.SelectedValue = ticket.ID_FormaPago
                PagadoCheckBox.Checked = True
            End If
        Next




    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub
End Class