Imports System.ComponentModel
Imports centro_medico.UI.Reportes

Public Class frmLibroIngresosGastos

    Dim libro As LibroIngresosGastos
    Dim filtros As FiltroLibroIngresosGastos
    Dim _worker As New BackgroundWorker()

    Private Sub frmLibroIngresosGastos_Load(sender As System.Object, exo As System.EventArgs) Handles MyBase.Load
        'Chequear si tiene el permiso de Libros
        dtp_fi.Value = Today
        dtp_ff.Value = Today.AddDays(7)

        If Globales.Configuracion.chkActivar_control_Libro_Ingresos_gastos Then
            If Not (Globales.Usuario.Permisos(RoleManager.Items.LibroIngresosGastos) = RoleManager.TipoPermisos.Total) Then
                lblRestringirSemana.Visible = True
                'grpFecha.Enabled = False
                dtp_fi.MinDate = Today.AddDays(-7)
                dtp_fi.MaxDate = Today

                dtp_ff.MinDate = Today.AddDays(-7)
                dtp_ff.MaxDate = Today

                dtpFechaPagoInicial.MinDate = Today.AddDays(-7)
                dtpFechaPagoInicial.MaxDate = Today

                dtpFechaPagoFinal.MinDate = Today.AddDays(-7)
                dtpFechaPagoFinal.MaxDate = Today
            End If
        End If

        libro = New LibroIngresosGastos()

        _worker.WorkerReportsProgress = True
        _worker.WorkerSupportsCancellation = True

        AddHandler _worker.ProgressChanged, Sub(o, e)
                                                'RaiseEvent UpdateCurrentProgress(e.ProgressPercentage)
                                            End Sub

        AddHandler _worker.DoWork, Sub(o, e)
                                       CargarDatos()
                                   End Sub
        AddHandler _worker.RunWorkerCompleted,
                                   Sub(o, e)
                                       If e.Cancelled = True Then
                                           Return
                                       End If

                                       If e.Error Is Nothing Then
                                           CargarDatosCompletados()
                                       End If

                                   End Sub
    End Sub

    Private Sub BtnFiltrarClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Filtrar()
    End Sub


    Private Sub Filtrar()
        pnl_Loading.Visible = True
        SetEnabled(False)

        'Preparar los filtros basados en lo seleccionado en la UI
        filtros = New FiltroLibroIngresosGastos With
                  {
                      .FechaEmisionInicial = IIf(dtp_fi.Checked, dtp_fi.Value, Nothing),
                      .FechaEmisionFinal = IIf(dtp_ff.Checked, dtp_ff.Value, Nothing),
                      .FechaPagoInicial = IIf(dtpFechaPagoInicial.Checked, dtpFechaPagoInicial.Value, Nothing),
                      .FechaPagoFinal = IIf(dtpFechaPagoFinal.Checked, dtpFechaPagoFinal.Value, Nothing),
                      .UsarFechaPagoComoAnd = False,
                      .HoraEmisionInicial = IIf(dtpHoraInicio.Checked, dtpHoraInicio.Value, Nothing),
                      .HoraEmisionFinal = IIf(dtpHoraFinal.Checked, dtpHoraFinal.Value, Nothing),
                      .FormaPago = IIf(Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing, CtrlFormaPago21.ID_FORMASPAGO, Nothing),
                      .StatusPago = IIf(rb_cobradas.Checked, StatusPago.Pagado, (IIf(rb_sincobrar.Checked, StatusPago.NoPagado, StatusPago.Todos))),
                      .IncluirConImporteCero = chkInclurDocImporte0.Checked,
                      .IncluirCitas = chkCitas.Checked,
                      .IncluirEntregasCuenta = chkEntregasACuenta.Checked,
                      .IncluirFacturas = chkFacturas.Checked,
                      .IncluirGastosVarios = chkGastosVarios.Checked,
                      .IncluirImportesDoctores = chkDoctores.Checked,
                      .IncluirRecibos = chkRecibos.Checked,
                      .IncluirTickets = chkTickets.Checked,
                      .IncluirTPVFacturas = chkTPVFacturas.Checked,
                      .IncluirTPVFacturasProveedores = chkTPVFacturasProveedor.Checked
                  }

        _worker.RunWorkerAsync()  'esto llama a CargaDatos
    End Sub

    
    Private Sub CargarDatos()
        GridEX1.DataSource = Nothing
        libro.Filtrar(filtros)
        'Se filtra pero los datos se muestran en CargarDatosCompletados
    End Sub

    Private Sub CargarDatosCompletados()
        GridEX1.DataSource = libro.Items
        lblCredito.Text = libro.Credito.ToString("C2")
        lblDiferencia.Text = libro.Diferencia.ToString("C2")
        lblGastos.Text = libro.Gastos.ToString("C2")
        lblIngresos.Text = libro.Ingresos.ToString("C2")
        lblPagoCuentaCredito.Text = libro.PagosCuentaConCredito.ToString("C2")
        lblPendiente.Text = libro.Pendiente.ToString("C2")
        pnl_Loading.Visible = False
        SetEnabled(True)
    End Sub


    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
    End Sub





    'Private Sub CargarDatos()

    '    GridEX1.DataSource = Nothing

    '    pendientecobro = 0
    '    ganancia = 0
    '    gasto = 0

    '    monto_entregas = 0
    '    monto_pagos = 0
    '    credito = 0


    '    context = New CMLinqDataContext()


    '    Dim citasdoctoresSinModulo As New List(Of CITA)
    '    Dim citasdoctores As New List(Of Liquidacion_Medico)

    '    Dim citas As New List(Of CITA)
    '    Dim citasPagadasConCredito As New List(Of CITA)

    '    Dim facturas As New List(Of FACTURA)
    '    Dim facturasPagadasConCredito As New List(Of FACTURA)

    '    Dim entregasCuenta As New List(Of EntregasCuenta)




    '    Dim recibos As New List(Of RECIBO)

    '    Dim tickets As New List(Of N_Ticket)
    '    Dim tpvFacturas As New List(Of N_Factura)
    '    Dim gastos As New List(Of GASTO)

    '    lista = New List(Of LIBROINGRESOGASTOS)

    '    'INGRESOS

    '    If chb_citas.Checked Then
    '        citas = CitasManager.ListadoCitasParaInformeGastos(context, filtros).ToList
    '    End If

    '    If chb_facturas.Checked Then
    '        facturas = FacturasManager.ListadoFACTURAsParaInformeGastos(context, filtros).ToList
    '    End If

    '    'If chb_EntregasACuenta.Checked Then
    '    '    entregasCuenta = EntregasCuentaManager.ListadoEntregasCuentaParaInformeGastos(context, filtros).ToList
    '    'End If

    '    ' **** GASTOS ***
    '    If chb_gastos.Checked Then
    '        gastos = (From g In context.GASTOs Where g.FECHA >= filtros.FechaEmisionInicial And g.FECHA < filtros.FechaEmisionFinal And g.IMPORTE > 0).ToList()
    '    End If

    '    If chb_doctores.Checked Or chb_citas.Checked Then

    '        If Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then
    '            citasdoctores = (From o In context.Liquidacion_Medicos Where _
    '                           (o.Fecha >= filtros.FechaEmisionInicial And o.Fecha <= filtros.FechaEmisionFinal) And _
    '                          (o.Importe) > 0).ToList()
    '        Else
    '            citasdoctoresSinModulo = (From o In context.CITAs Where _
    '                                       (o.FECHA >= filtros.FechaEmisionInicial And o.FECHA <= filtros.FechaEmisionFinal) And o.Eliminado = False And _
    '                                      (o.IMPORTEDR + o.IMPORTECL) - o.Descuento > 0).ToList()

    '        End If
    '    End If

    '    If chb_recibos.Checked Then
    '        recibos = (From o In context.RECIBOs Where _
    '                   (o.FECHAEMISION >= filtros.FechaEmisionInicial And o.FECHAEMISION < filtros.FechaEmisionFinal) Or _
    '                    (o.FECHACOBRO >= filtros.FechaEmisionInicial And o.FECHACOBRO <= filtros.FechaEmisionFinal And o.COBRADO = "S")).ToList()

    '        If IsFCobroChecked Then
    '            recibos = (recibos.Where(Function(o) o.FECHACOBRO.Value.ToShortDateString() = filtros.FechaPagoFinal.Value.ToShortDateString)).ToList()
    '        End If
    '    End If



    '    If chk_Tickets.Checked Then
    '        tickets = (From o In context.N_Tickets
    '                  Join lineas As N_Ticket_Linea In context.N_Ticket_Lineas _
    '                  On lineas.ID_Ticket Equals o.ID_Ticket _
    '                  Where o.Fecha >= filtros.FechaEmisionInicial And o.Fecha <= filtros.FechaEmisionFinal And lineas.Validado = False And o.Total > 0 Select o).ToList()
    '        If IsFCobroChecked Then
    '            tickets = (tickets.Where(Function(o) o.FechaPagado.Value.ToShortDateString() = filtros.FechaPagoFinal.Value.ToShortDateString)).ToList()
    '        End If
    '    End If

    '    If chk_TPV_Facturas.Checked Then
    '        tpvFacturas = (From o In context.N_Facturas Where o.Fecha >= filtros.FechaEmisionInicial And o.Fecha <= filtros.FechaEmisionFinal Select o).ToList()
    '        If IsFCobroChecked Then
    '            tpvFacturas = (tpvFacturas.Where(Function(o) o.FechaPagado.ToShortDateString() = filtros.FechaPagoFinal.Value.ToShortDateString)).ToList()
    '        End If
    '    End If

    '    If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
    '        'Filtrar cada lista
    '        gastos = gastos.Where(Function(o) o.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        'citas = citas.Where(Function(o) o.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        citasdoctores = citasdoctores.Where(Function(o) o.ID_FormaPago = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        recibos = recibos.Where(Function(o) o.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        facturas = facturas.Where(Function(o) o.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        tickets = tickets.Where(Function(o) o.ID_FormaPago = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '        tpvFacturas = tpvFacturas.Where(Function(o) o.ID_FormaPago = CtrlFormaPago21.ID_FORMASPAGO).ToList()
    '    End If

    '    If rb_cobradas.Checked = True Then
    '        'gastos_doctores = gastos_doctores.Where(Function(o) o.PAGADA = "N").ToList()
    '        'citasdoctores = citasdoctores.Where(Function(o) o.PAGADA = "S").ToList()
    '        recibos = recibos.Where(Function(o) o.COBRADO = "S").ToList()
    '        facturas = facturas.Where(Function(o) o.PAGADA = "S").ToList()
    '        tickets = tickets.Where(Function(o) o.Pagado = True).ToList()
    '        tpvFacturas = tpvFacturas.Where(Function(o) o.Pagado = True).ToList()
    '    ElseIf rb_sincobrar.Checked = True Then
    '        'citasdoctores = citasdoctores.Where(Function(o) o.PAGADA = "N").ToList()
    '        recibos = recibos.Where(Function(o) o.COBRADO = "N").ToList()
    '        facturas = facturas.Where(Function(o) o.PAGADA = "N").ToList()
    '        tickets = tickets.Where(Function(o) o.Pagado = False).ToList()
    '        tpvFacturas = tpvFacturas.Where(Function(o) o.Pagado = False).ToList()
    '    End If


    '    'recibos
    '    lista.AddRange((From o In recibos _
    '                                 Select New LIBROINGRESOGASTOS With _
    '                                {.FECHA = o.FECHAEMISION, _
    '                                 .FECHACOBRO = o.FECHACOBRO, _
    '                                 .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                                 .CONCEPTO = If(o.PACIENTE Is Nothing, " RECIBO " & o.NUMERO & " PACIENTE NULL!! ", " RECIBO " & o.NUMERO & ", " & o.PACIENTE.NombreCompleto), _
    '                                 .IMPORTE = (o.IMPORTE), _
    '                                  .PagadoConCredito = o.PagadoConCredito,
    '                                 .TIPO = "RECIBO", _
    '                                 .PAGADA = o.COBRADO
    '                                }).ToList())

    '    'Gastos
    '    lista.AddRange((From g In gastos _
    '                        Select New LIBROINGRESOGASTOS With _
    '                               {.FECHA = g.FECHA, _
    '                               .FECHACOBRO = g.FECHA, _
    '                               .FORMAPAGO = If(g.FORMASPAGO Is Nothing, Nothing, g.FORMASPAGO.DESCRIPCION), _
    '                            .CONCEPTO = "GASTO " & g.CONCEPTO, _
    '                               .IMPORTE = (-1 * g.IMPORTE), _
    '                                .TIPO = "GASTO"
    '                               }).ToList())

    '    'Tickets
    '    lista.AddRange((From o In tickets
    '                          Select New LIBROINGRESOGASTOS With _
    '                       {.FECHA = o.Fecha, _
    '                        .FECHACOBRO = o.FechaPagado, _
    '                        .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                        .CONCEPTO = If(o.PACIENTE Is Nothing, "Ticket Nro " & o.ID_Ticket & ": " & " PACIENTE NULL!! ", "Ticket Nro " & o.ID_Ticket & ": " & o.PACIENTE.NombreCompleto), _
    '                        .IMPORTE = o.Total, _
    '                         .PagadoConCredito = o.PagadoConCredito,
    '                        .TIPO = "Ticket", _
    '                        .PAGADA = If(o.Pagado, "S", "N")
    '                       }).ToList())



    '    'TPV Facturas
    '    lista.AddRange((From o In tpvFacturas
    '                         Select New LIBROINGRESOGASTOS With _
    '                      {.FECHA = o.Fecha, _
    '                       .FECHACOBRO = o.FechaPagado, _
    '                       .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                       .CONCEPTO = If(o.PACIENTE Is Nothing, "TPV Factura Nro " & o.ID_Factura & ":" & " PACIENTE NULL!! ", "TPV Factura Nro " & o.ID_Factura & ":" & o.PACIENTE.NombreCompleto), _
    '                       .IMPORTE = o.Total, _
    '                       .TIPO = "Ticket", _
    '                        .PagadoConCredito = o.PagadoConCredito,
    '                       .PAGADA = If(o.Pagado, "S", "N")
    '                      }).ToList())

    '    'Calculos

    '    'gastos
    '    gasto += gastos.Sum(Function(o) o.IMPORTE)

    '    'Doctores

    '    If chb_doctores.Checked Then
    '        'Importes a Doctores
    '        If Globales.Configuracion.ModuloLiquidacionMedicos_Activo Then

    '            lista.AddRange((From o In citasdoctores Where o.Importe > 0 _
    '                                    Select New LIBROINGRESOGASTOS With _
    '                                {.FECHA = o.Fecha, _
    '                                .FECHACOBRO = o.Fecha, _
    '                                .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                                .CONCEPTO = "Liquidación médico " & o.NOMBREMEDICO & "-> " & o.Descripcion, _
    '                                .IMPORTE = -1 * (o.Importe), _
    '                                .TIPO = "MEDICO", _
    '                                .PAGADA = "S"
    '                                }).ToList())

    '            gasto += citasdoctores.Where(Function(k) k.Importe > 0).Sum(Function(o) o.Importe)
    '        Else
    '            lista.AddRange((From o In citasdoctoresSinModulo Where o.IMPORTEDR > 0 _
    '                                   Select New LIBROINGRESOGASTOS With _
    '                               {.FECHA = o.FECHA, _
    '                               .FECHACOBRO = o.FECHACOBRO, _
    '                               .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                               .CONCEPTO = "Pago Cita del " + o.FECHA.ToString() + "  a médico " & o.MEDICO.NOMBRECOMPLETO, _
    '                               .IMPORTE = -1 * (o.IMPORTEDR), _
    '                               .TIPO = "CITA", _
    '                               .PagadoConCredito = o.PagadoConCredito,
    '                               .PAGADA = "S"
    '                               }).ToList())

    '            gasto += citasdoctoresSinModulo.Where(Function(k) k.IMPORTEDR > 0).Sum(Function(o) o.IMPORTEDR)
    '        End If
    '    End If



    '    'de las cita

    '    'citas
    '    lista.AddRange((From o In citas _
    '                                     Select New LIBROINGRESOGASTOS With _
    '                                  {.FECHA = o.FECHA, _
    '                                   .FECHACOBRO = o.FECHACOBRO, _
    '                                   .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                                   .CONCEPTO = " CITA " & Format(o.HORA.Value.Hour, "00") & ":" & Format(o.HORA.Value.Minute, "00") & ", " & o.PACIENTE1.NombreCompleto, _
    '                                   .IMPORTE = o.TOTAL, _
    '                                   .TIPO = "CITA", _
    '                                   .PAGADA = o.PAGADA,
    '                                   .PagadoConCredito = o.PagadoConCredito
    '                                  }).ToList())


    '    ganancia += citas.Where(Function(o) o.PAGADA = "S" And o.PagadoConCredito = False).Sum(Function(k) k.TOTAL)
    '    pendientecobro += citas.Where(Function(o) (o.PAGADA = "N" And o.ATENDIDO = "S")).Sum(Function(k) k.TOTAL)


    '    'Facturas
    '    lista.AddRange((From o In facturas
    '                         Select New LIBROINGRESOGASTOS With _
    '                      {.FECHA = o.FEMISION, _
    '                       .FECHACOBRO = o.FECHACOBRO, _
    '                       .FORMAPAGO = If(o.FORMASPAGO Is Nothing, Nothing, o.FORMASPAGO.DESCRIPCION), _
    '                       .CONCEPTO = If(o.PACIENTE Is Nothing, "Factura Nro " + o.NUMERO + ":" & " PACIENTE NULL!! ", "Factura Nro " + o.NUMERO + ":" & o.PACIENTE), _
    '                       .IMPORTE = o.TOTAL, _
    '                       .TIPO = "Facturas", _
    '                       .PAGADA = o.PAGADA,
    '                       .PagadoConCredito = o.PagadoConCredito
    '                      }).ToList())

    '    'recibos
    '    ganancia += recibos.Where(Function(o) o.COBRADO = "S").Sum(Function(k) k.IMPORTE)
    '    pendientecobro += recibos.Where(Function(o) (o.COBRADO = "N")).Sum(Function(k) k.IMPORTE)

    '    'facturas
    '    ganancia += facturas.Where(Function(o) o.PAGADA = "S" And o.FECHACOBRO >= filtros.FechaEmisionInicial And o.FECHACOBRO <= filtros.FechaEmisionFinal).Sum(Function(k) k.TOTAL)

    '    pendientecobro += facturas.Where(Function(o) (o.PAGADA = "S" And (o.FECHACOBRO < filtros.FechaEmisionInicial Or o.FECHACOBRO > filtros.FechaEmisionFinal))).Sum(Function(k) k.TOTAL)
    '    pendientecobro = pendientecobro + facturas.Where(Function(o) o.PAGADA = "N").Sum(Function(k) k.TOTAL)


    '    'tickets
    '    ganancia += tickets.Where(Function(o) o.Pagado = True).Sum(Function(k) k.Total)
    '    pendientecobro += tickets.Where(Function(o) (o.Pagado = False)).Sum(Function(k) k.Total)

    '    'TPV Facturas
    '    ganancia += tpvFacturas.Where(Function(o) o.Pagado = True).Sum(Function(k) k.Total)
    '    pendientecobro += tpvFacturas.Where(Function(o) (o.Pagado = False)).Sum(Function(k) k.Total)

    '    If chb_EntregasACuenta.Checked Then
    '        _entregas = (From p In context.PagosPacientes Where p.Fecha >= filtros.FechaEmisionInicial And p.Fecha <= filtros.FechaEmisionFinal _
    '                                                 Select New WRAPPER_PagosPaciente(p)).ToList()



    '        Dim pagos As List(Of EntregasCuenta) = (From p In context.EntregasCuentas Where
    '                                                     p.Fecha >= filtros.FechaEmisionInicial And p.Fecha <= filtros.FechaEmisionFinal _
    '                                                     And p.Eliminado = False And p.PagadoConCredito = False _
    '                Select p).ToList()




    '        monto_entregas = _entregas.Sum(Function(e) e.Importe)
    '        monto_pagos = pagos.Sum(Function(e) e.Importe)
    '        credito = monto_entregas - monto_pagos

    '    End If

    '    pacoCuentaCredito = lista.Where(Function(o) o.PagadoConCredito).Sum(Function(o) o.IMPORTE)

    'End Sub



    'Private Sub FiltradoCompletado()
    '    GridEX1.DataSource = lista

    '    lb_Pendiente.Text = pendientecobro.ToString("C2")
    '    lb_gastos.Text = gasto.ToString("C2")
    '    lb_ingresos.Text = ganancia.ToString("C2")
    '    lb_diferencia.Text = (ganancia - gasto).ToString("C2")

    '    lbl_Credito_Value.Text = credito.ToString("C2")
    '    txtPagoCuentaCredito.Text = pacoCuentaCredito.ToString("C2")

    '    pnl_Loading.Visible = False
    '    SetEnabled(True)
    'End Sub

  
    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        If GridEX1.GetRows().Count = 0 Then
            MessageBox.Show("Nada que imprimir, por favor filtre primero")
            Return
        End If

        'Ejecutamos al imprimir

        Dim parametros(5) As Microsoft.Reporting.WinForms.ReportParameter


        'preparo el filtro para mostrarlo.
        Dim filtro As String = " Desde " & Me.dtp_fi.Value.Date.ToString & " a " & Me.dtp_ff.Value.Date.ToString
        If Me.chkCitas.Checked Then filtro += " Citas=S "
        If Me.chkDoctores.Checked Then filtro += " Medicos=S "
        If Me.chkFacturas.Checked Then filtro += " Facturas=S "
        If Me.chkGastosVarios.Checked Then filtro += " Gastos=S "
        If Me.chkRecibos.Checked Then filtro += " Recibos=S "
        If rb_cobradas.Checked Then filtro += " Cobradas=S "
        If Me.rb_sincobrar.Checked Then filtro += " Cobradas=N "
        If Me.rb_todascobrar.Checked Then filtro += " Cobradas y Sin cobrar "

        Dim dsLibro As New Microsoft.Reporting.WinForms.ReportDataSource()
        dsLibro.Name = "dsLibro"
        dsLibro.Value = libro.Items

        Dim dsPagos As New Microsoft.Reporting.WinForms.ReportDataSource()
        dsPagos.Name = "dsPagos"
        dsPagos.Value = libro.EntregasDocumento

        parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & filtro)
        parametros(1) = New Microsoft.Reporting.WinForms.ReportParameter("gastos", libro.Gastos)
        parametros(2) = New Microsoft.Reporting.WinForms.ReportParameter("ingresos", libro.Ingresos)
        parametros(3) = New Microsoft.Reporting.WinForms.ReportParameter("total", libro.Ingresos + libro.Gastos)
        parametros(4) = New Microsoft.Reporting.WinForms.ReportParameter("pendiente", libro.Pendiente)
        parametros(5) = New Microsoft.Reporting.WinForms.ReportParameter("credito", libro.Credito)

        'UI.Reportes.ReportesManager.Imprime("LibroDiario.rdlc", {dsLibro}, parametros)
        UI.Reportes.ReportesManager.Imprime("LibroDiario.rdlc", {dsLibro, dsPagos}, parametros)

    End Sub



    Private Sub BtCerrarClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub dtp_fi_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fi.ValueChanged
        Dim a As Object
        If (sender.checked = False) Then dtpHoraInicio.Checked = sender.checked
        dtpHoraInicio.Enabled = sender.checked
    End Sub


    Private Sub dtp_ff_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ff.ValueChanged
        Dim a As Object
        If sender.checked = False Then dtpHoraFinal.Checked = sender.checked
        dtpHoraFinal.Enabled = sender.checked
    End Sub

    Private Sub rb_sincobrar_CheckedChanged(sender As Object, e As EventArgs) Handles rb_sincobrar.CheckedChanged
        If sender.checked = False Then
            'aaa
        End If
    End Sub
End Class


Partial Public Class PagosPaciente
    Public ReadOnly Property FormaPagoDescripcion() As String
        Get
            If Not Me.FORMASPAGO Is Nothing Then
                Return Me.FORMASPAGO.DESCRIPCION
            Else
                Return String.Empty
            End If
        End Get
    End Property

End Class

