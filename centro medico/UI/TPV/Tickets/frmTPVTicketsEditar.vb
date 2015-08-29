Imports centro_medico.UI.Reportes

Public Class frmTPVTicketsEditar

    Public Context As CMLinqDataContext
    Public Nuevo As Boolean = False
    Public ID_Ticket As Integer
    Public Ticket As N_Ticket
    Public deCita As Boolean = False

    Private Sub frmTPVTicketsEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargaDatos()
        CalculaTotal()

        Me.tsb_DebitoPaciente.Visible = Not deCita
        Me.CtrlDocProcesados1.TreeView1.Nodes.Clear()
        Me.CtrlDocProcesados1.id_Doc = Ticket.ID_Ticket
        Me.CtrlDocProcesados1.tipoDoc = Globales.TipoDocumento.Ticket
        Me.CtrlDocProcesados1.CargaDocumentosRelacionados()

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Lectura Then
            'Me.tlsbNuevo.Enabled = False
            Me.tsbGuardar.Enabled = False
            'Me.tsbCancelar.Enabled = False
            Me.btAddLinea.Enabled = False
            Me.btEliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Modificar Then
            'Me.tlsbNuevo.Enabled = False
            Me.tsbGuardar.Enabled = False
            'Me.tsbCancelar.Enabled = True
            Me.btAddLinea.Enabled = True
            Me.btEliminar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Total Then
            'Me.tlsbNuevo.Enabled = True
            Me.tsbGuardar.Enabled = True
            'Me.tsbCancelar.Enabled = True
            Me.btAddLinea.Enabled = True
            Me.btEliminar.Enabled = True
        End If

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Debito) = RoleManager.TipoPermisos.Ninguno Then
            Me.tsb_DebitoPaciente.Visible = False
        End If
        'If IDCITA <> -1 Then
        '    ImportarLineasDeCita(IDCITA)
        'End If

    End Sub

    Private Sub CargaDatos()

        GridEXListado.DataSource = Nothing
        Context = New CMLinqDataContext()
        Ticket = (From t In Context.N_Tickets Where t.ID_Ticket = ID_Ticket Select t).SingleOrDefault()


        ID_FormaPagoComboBox.DataSource = Context.FORMASPAGOs


        'NTipoIVABindingSource.DataSource = Context.N_TipoIVAs
        'GridEXListado.DropDowns(0).DataSource = NTipoIVABindingSource.DataSource


        If Nuevo Then
            If Not Context.N_Tickets.Contains(Ticket) Then
                Context.N_Tickets.InsertOnSubmit(Ticket)
                'Context.SubmitChanges()
            End If
        End If


        NTicketBindingSource.DataSource = Ticket
        GridEXListado.DataSource = NTicketLineasBindingSource

        If Not Ticket.ID_FormaPago Is Nothing Then
            ID_FormaPagoComboBox.SelectedValue = Ticket.ID_FormaPago
        End If

        If Ticket.ID_Cliente.HasValue Then
            CtrlPaciente1.ID_PACIENTE = Ticket.ID_Cliente
        End If

        'si esta pagado, el datapicker de fecha pagado debe estar enable = true
        
        chk_pagado.Checked = Ticket.Pagado
        chk_pagado.Enabled = Not Ticket.Pagado
        FechaPagadoDateTimePicker.Enabled = Not Ticket.Pagado

        'Cargo los documentos a los que este ticket puede haber sido procesado


    End Sub

    'Private Sub ImportarLineasDeCita(ByVal IDCITA As Integer)

    '    'Dim adapter As New CMDataSetTableAdapters.LineasCitasTableAdapter()
    '    'adapter.FillByIdCita(CMDataSet.LineasCitas, IDCITA)

    '    'For Each lineaCita As CMDataSet.LineasCitasRow In CMDataSet.LineasCitas
    '    '    Dim lineaTicket As CMDataSet.N_Ticket_LineasRow = CMDataSet.N_Ticket_Lineas.NewRow()
    '    '    'Aqui hay que annadir las lineas
    '    'Next
    'End Sub



    Private Function Guardar() As Boolean
        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Se requiere un paciente")
            CtrlPaciente1.Focus()
            Return False
        End If

        Me.NTicketBindingSource.EndEdit()
        Me.NTicketLineasBindingSource.EndEdit()



        Dim ticket As N_Ticket = NTicketBindingSource.DataSource
        ticket.ID_Cliente = CtrlPaciente1.ID_PACIENTE
        ticket.ID_FormaPago = ID_FormaPagoComboBox.SelectedValue
        If chk_pagado.Checked = False Then
            ticket.FechaPagado = Nothing
        End If
        ticket.NombrePaciente = ticket.PACIENTE.NombreCompleto
        If Not ticket.ID_FormaPago Is Nothing Then
            If Not (ticket.FORMASPAGO Is Nothing) Then ticket.FormaPago = ticket.FORMASPAGO.DESCRIPCION
        Else
            ticket.FormaPago = String.Empty
        End If

        Return True

    End Function

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If


    End Sub

    Private Sub btAddLinea_Click(sender As Object, e As EventArgs) Handles btAddLinea.Click
        Dim ticket As N_Ticket = NTicketBindingSource.DataSource
        Dim linea As New N_Ticket_Linea()

        linea.Cantidad = 1
        linea.Codigo = String.Empty
        linea.Precio = 0
        linea.Costo = 0
        linea.Descripcion = ""
        linea.Descuento1 = 0
        linea.Descuento2 = 0
        linea.Descuento3 = 0
        linea.ID_Ticket = ticket.ID_Ticket
        linea.Validado = False
        linea.IVAPorciento = 0
        linea.IVAImporte = 0
        If Globales.Configuracion.ivaIncluido = 0 Then
            linea.IVAIncluido = False
        Else
            linea.IVAIncluido = True
        End If

        Dim pos As Integer = NTicketLineasBindingSource.Add(linea)
        NTicketLineasBindingSource.MoveLast()
        'GridEXListado.EnsureVisible(pos)

    End Sub


    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If Not GridEXListado.CurrentRow Is Nothing Then
            Try
                If Nuevo Then
                    GridEXListado.Delete()
                    CalculaTotal()
                    Return
                End If


                Try
                    Context.N_Ticket_Lineas.DeleteOnSubmit(GridEXListado.CurrentRow.DataRow)
                    Context.SubmitChanges()
                    CargaDatos()
                Catch ex As Exception
                    Dim a = 2
                    GridEXListado.Delete()
                End Try


                CalculaTotal()
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CalculaTotal()
        NTicketLineasBindingSource.EndEdit()
        GridEXListado.UpdateData()
        GridEXListado.Refresh()
        Ticket.Total = Ticket.N_Ticket_Lineas.Sum(Function(o) o.Total)
        txtIvaDesglosado.Value = Ticket.N_Ticket_Lineas.Sum(Function(o) o.IVAImporte)
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(IdPaciente As Integer, IsReturnPressed As Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        CtrlStatusPaciente1.ID_PACIENTE = IdPaciente

    End Sub




    Private Sub GridEXListado_ColumnButtonClick(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXListado.ColumnButtonClick
        If e.Column.Index = GridEXListado.RootTable.Columns("Codigo").Index Then
            Dim frm As New frmArticulos()
            frm.Modo = Globales.ModoParaFormas.Seleccion
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frm.Articulo.IsNoPermitirUtilzarArticuloNull = False Then
                    If frm.Articulo.NoPermitirUtilzarArticulo = True Then
                        MsgBox("Este artículo esta deshabilitado para su uso.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
                AddLinea(frm.Articulo.Codigo)

            End If
        End If
    End Sub

#Region "Private Sub AddLinea(ByVal codigoArticulo As String)"
    Private Sub AddLinea(ByVal codigoArticulo As String)

        Dim articulo As N_Articulo = (From a In Context.N_Articulos _
                                      Where a.Codigo = codigoArticulo).SingleOrDefault()
        Dim linea As N_Ticket_Linea = GridEXListado.CurrentRow.DataRow
        If Not articulo Is Nothing Then
            If Not GridEXListado.CurrentRow Is Nothing Then

                If articulo.NoPermitirUtilzarArticulo.HasValue Then
                    If articulo.NoPermitirUtilzarArticulo = True Then
                        MsgBox("Este artículo esta deshabilitado para su uso.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If

                linea.ID_Articulo = articulo.ID_Articulo
                linea.Descripcion = articulo.DescripcionGeneral
                linea.Codigo = codigoArticulo
                If Not articulo.N_TipoIVA Is Nothing Then
                    linea.IVAPorciento = articulo.N_TipoIVA.Valor
                Else
                    linea.IVAPorciento = 0
                    linea.IVAImporte = 0
                End If

                linea.Precio = articulo.PrecioVentaRecomendado
                linea.Costo = articulo.PrecioCompra

                If Not articulo.MensajeEmergente Is Nothing Then
                    If articulo.MensajeEmergente.Trim.Length > 0 Then
                        MsgBox(articulo.MensajeEmergente, MsgBoxStyle.Information, "Mensaje del artículo")
                    End If
                End If

                'asigno el primer valor del almacen
                If articulo.EsEstocable = True Then
                    Dim almacen As N_Almacen = Context.N_Almacens.FirstOrDefault()
                    If Not almacen Is Nothing Then
                        linea.ID_Almacen = almacen.ID_Almacen
                    End If
                End If
            End If
        Else
            'Borrar el código de la linea
            GridEXListado.CurrentRow.Cells(GridEXListado.RootTable.Columns("Codigo").Index).Value = Nothing
        End If
        CalculaLinea(linea)
    End Sub
#End Region

    Private Sub GridEXListado_CellEdited(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXListado.CellEdited
        If Not e.Column Is Nothing Then
            If e.Column.Index = GridEXListado.RootTable.Columns("Codigo").Index Then
                AddLinea(GridEXListado.CurrentRow.Cells(e.Column.Index).Value)
            End If

            NTicketLineasBindingSource.EndEdit()
            GridEXListado.UpdateData()

            Dim linea As N_Ticket_Linea = GridEXListado.CurrentRow.DataRow
            CalculaLinea(linea)
        End If


    End Sub

    Private Function CalculaLinea(ByRef linea As N_Ticket_Linea)
        'Inicializaciones para prevenir errores
        If Not linea.Cantidad.HasValue Then linea.Cantidad = 1
        If Not linea.Precio.HasValue Then linea.Precio = 0
        If Not linea.Descuento1.HasValue Then linea.Descuento1 = 0
        If Not linea.Descuento2.HasValue Then linea.Descuento2 = 0
        If Not linea.Descuento3.HasValue Then linea.Descuento3 = 0

        Dim total As Double = 0

        If linea.IVAIncluido = True Then
            total += linea.Cantidad * linea.Precio
            linea.IVAImporte = (linea.Cantidad * linea.Precio * linea.IVAPorciento / 100)
        Else
            linea.IVAImporte = (linea.Cantidad * linea.Precio * linea.IVAPorciento / 100)
            total += (linea.Cantidad * linea.Precio) + linea.IVAImporte
        End If


        total -= total * linea.Descuento1 / 100
        total -= total * linea.Descuento2 / 100
        total -= total * linea.Descuento3 / 100

        linea.Total = total
        CalculaTotal()
    End Function

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        If Guardar() Then

            Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim param(12) As Microsoft.Reporting.WinForms.ReportParameter

            param(0) = New Microsoft.Reporting.WinForms.ReportParameter("NombreCompletoCliente", Me.CtrlPaciente1.NombreCompleto)
            param(1) = New Microsoft.Reporting.WinForms.ReportParameter("ResumenIva", Me.txtIvaDesglosado.Value.ToString())
            param(2) = New Microsoft.Reporting.WinForms.ReportParameter("NombreEmpresa", Globales.Configuracion.nombrecomercial)
            param(3) = New Microsoft.Reporting.WinForms.ReportParameter("DireccionEmpresa", Globales.Configuracion.domicilio)
            param(4) = New Microsoft.Reporting.WinForms.ReportParameter("PoblacionEmpresa", Globales.Configuracion.localidad)
            param(5) = New Microsoft.Reporting.WinForms.ReportParameter("CodigoPostalEmpresa", Globales.Configuracion.CP)
            param(6) = New Microsoft.Reporting.WinForms.ReportParameter("ProvinciaEmpresa", Globales.Configuracion.provincia)
            param(7) = New Microsoft.Reporting.WinForms.ReportParameter("CifEmpresa", Globales.Configuracion.CIF)
            param(8) = New Microsoft.Reporting.WinForms.ReportParameter("TelefonoEmpresa", Globales.Configuracion.Tlfno1)
            param(9) = New Microsoft.Reporting.WinForms.ReportParameter("EmailEmpresa", Globales.Configuracion.Email)
            param(10) = New Microsoft.Reporting.WinForms.ReportParameter("WebEmpresa", Globales.Configuracion.web)
            param(11) = New Microsoft.Reporting.WinForms.ReportParameter("NTicket", Me.Ticket.ID_Ticket)
            param(12) = New Microsoft.Reporting.WinForms.ReportParameter("TotalTicket", Me.Ticket.Total)

            ds.Name = "CMDataSet_N_Ticket_Lineas"
            ds.Value = Ticket.N_Ticket_Lineas

            UI.Reportes.ReportesManager.Imprime("TPVTicket.rdlc", {ds}, param)
            
        End If


    End Sub

    Private Sub frmTicket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'EVENTOS DISPARADOS POR LAS TECLAS F
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Lectura Then
            Select Case e.KeyCode
                Case Keys.F4
                    Me.tlbImprimir_Click(Nothing, Nothing)
            End Select
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tickets_Ventas) = RoleManager.TipoPermisos.Modificar Then
            Select Case e.KeyCode
                Case Keys.F4
                    Me.tlbImprimir_Click(Nothing, Nothing)
                Case Keys.F5
                    Me.btAddLinea_Click(Nothing, Nothing)
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
                Case Keys.F2
                    Me.Guardar()
                Case Keys.F4
                    Me.tlbImprimir_Click(Nothing, Nothing)
                Case Keys.F5
                    Me.btAddLinea_Click(Nothing, Nothing)
                Case Keys.F6
                    Me.btEliminar_Click(Nothing, Nothing)
            End Select
        End If


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


        For Each ticket As N_Ticket In frm.TicketsPagados
            If ticket.ID_Ticket = ticket.ID_Ticket Then
                'Actualizar la forma de pago
                'Ponerla como pagada
                ID_FormaPagoComboBox.SelectedValue = ticket.ID_FormaPago
                FechaPagadoDateTimePicker.Checked = True
            End If
        Next
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub chk_pagado_Click(sender As Object, e As EventArgs) Handles chk_pagado.Click


        If Not Guardar() Then
            Return
        End If
        chk_pagado.Checked = False
        Dim pdm As New PacienteDebitoManager(CtrlPaciente1.Paciente, Context, Nothing)

        If pdm.PagarDocumentos({Ticket},
                                New frmPagarDocumentos(Me.FechaPagadoDateTimePicker.Value),
                                ID_FormaPagoComboBox.SelectedValue,
                                Globales.Usuario.CODIGO,
                               Context) = Windows.Forms.DialogResult.OK Then
            chk_pagado.Checked = True
            chk_pagado.Enabled = False
            FechaPagadoDateTimePicker.Enabled = False
            FechaPagadoDateTimePicker.Value = Ticket.FechaPagado
            ID_FormaPagoComboBox.SelectedValue = Ticket.ID_FormaPago
        End If
    End Sub

    
    Private Sub pb_UndoCobrar_Click(sender As Object, e As EventArgs) Handles pb_UndoCobrar.Click
        If Globales.Usuario.EsAdministrador Then
            If Me.chk_pagado.Checked AndAlso MessageBox.Show("Como Administrador puede marcar como no pagada este ticket, pero esto puede traer consecuencias en los pagos/entregas efectuados: Desea continuar?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                chk_pagado.Checked = False
                Ticket.Pagado = False
                chk_pagado.Enabled = True

                If Guardar() Then
                    Dim context As New CMLinqDataContext
                    Dim ticket As N_Ticket = (From c In context.N_Tickets Where c.ID_Ticket = ID_Ticket Select c).Single
                    If Not ticket Is Nothing Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Tickets_Ventas, "Descobrar Ticket", ID_Ticket, String.Format("Descobrado  ticket {0}-{1}-{2} importe {3}", ticket.ID_Ticket, ticket.Fecha, ticket.PACIENTE, ticket.Total))
                    End If
                    ticket.MarcarDespagado()
                    context.Dispose()
                    Me.Guardar()
                End If

            End If
        End If
    End Sub
End Class