Public Class LibroIngresosGastos

    Public Property Items As List(Of LibroIngresoGastosItem)
    Public Property Filtro As FiltroLibroIngresosGastos
    Dim ImpDlt As Double?

    Public ReadOnly Property Credito As Double
        Get
            Dim pagocuenta = Items.Where(Function(o) o.TIPO = PacienteDebitoManager.TipoDocumento.PagoCuenta).Sum(Function(k) k.IMPORTE)
            Dim pagos = Items.Where(Function(o) o.PAGADA = "S" And o.PagadoConCredito = False And _
                                        o.TIPO <> PacienteDebitoManager.TipoDocumento.PagoCuenta And _
                                        o.TIPO <> Nothing).Sum(Function(k) k.IMPORTE)
            Dim desp = Items.Where(Function(o) o.IMPORTE < 0).Sum(Function(k) k.IMPORTE)
            Dim res = (pagocuenta + (-desp - ImpDlt)) - pagos

            Return res
        End Get
    End Property

    Public ReadOnly Property Diferencia As Double
        Get
            Return Ingresos + Gastos
        End Get
    End Property



    Public ReadOnly Property Gastos As Double
        Get
            Dim _gastos = Items.Where(Function(o) o.TIPO Is Nothing).Sum(Function(o) o.IMPORTE)

            Return _gastos
        End Get
    End Property

    Public ReadOnly Property Ingresos As Double
        Get
            Dim _ingresos = Items.Where(Function(o) o.PAGADA = "S" And o.PagadoConCredito = False And _
                                        o.TIPO <> PacienteDebitoManager.TipoDocumento.PagoCuenta And _
                                        o.TIPO <> Nothing).Sum(Function(k) k.IMPORTE)
            Return _ingresos + Credito
        End Get
    End Property

    Public ReadOnly Property PagosCuentaConCredito As Double
        Get
            Return Items.Where(Function(o) o.PagadoConCredito = True).Sum(Function(k) k.IMPORTE)
        End Get
    End Property

    Public ReadOnly Property Pendiente As Double
        Get

            Return Items.Where(Function(o) o.PAGADA = "N").Sum(Function(k) k.IMPORTE)
        End Get
    End Property

    Public Function Filtrar(filtro As FiltroLibroIngresosGastos) As List(Of LibroIngresoGastosItem)
        Dim context As New CMLinqDataContext

        Dim facturas As IQueryable(Of FACTURA)
        Dim citas As IQueryable(Of CITA)
        Dim tickets As IQueryable(Of N_Ticket)
        Dim facturasTPV As IQueryable(Of N_Factura)
        Dim entregas As IQueryable(Of EntregasCuenta)
        Dim pagos As IQueryable(Of PagosPaciente)
        Dim gastos As IQueryable(Of GASTO)
        Dim comisiones As IQueryable(Of Liquidacion_Medico)

        'Cargar el importe total de las citas despagadas
        Dim EntregaEliminados As IQueryable(Of EntregasCuenta)
        EntregaEliminados = context.EntregasCuentas.Where(Function(o) o.Eliminado = True)

        If (filtro.FechaEmisionInicial.HasValue) Then
            EntregaEliminados = EntregaEliminados.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
        End If

        If (filtro.FechaEmisionFinal.HasValue) Then
            EntregaEliminados = EntregaEliminados.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
        End If

        If (filtro.HoraEmisionInicial.HasValue) Then
            EntregaEliminados = EntregaEliminados.Where(Function(o) o.Fecha >= New Date(filtro.FechaEmisionInicial.Value.Year, filtro.FechaEmisionInicial.Value.Month, _
                                                               filtro.FechaEmisionInicial.Value.Day, filtro.HoraEmisionInicial.Value.Hour, filtro.HoraEmisionInicial.Value.Minute, _
                                                               filtro.HoraEmisionInicial.Value.Second))
        End If

        If (filtro.HoraEmisionFinal.HasValue) Then
            EntregaEliminados = EntregaEliminados.Where(Function(o) o.Fecha <= New Date(filtro.FechaEmisionFinal.Value.Year, filtro.FechaEmisionFinal.Value.Month, _
                                                               filtro.FechaEmisionFinal.Value.Day, filtro.HoraEmisionFinal.Value.Hour, filtro.HoraEmisionFinal.Value.Minute, _
                                                               filtro.HoraEmisionFinal.Value.Second))
        End If

        If (Not filtro.FormaPago Is Nothing) Then
            EntregaEliminados = EntregaEliminados.Where(Function(o) o.IDFormaPago = filtro.FormaPago)
        End If

        ImpDlt = EntregaEliminados.Sum(Function(k) k.Importe)
        ImpDlt = If(ImpDlt Is Nothing, 0, ImpDlt)


        Dim lista As New List(Of LibroIngresoGastosItem)

        If Not filtro.StatusPago = StatusPago.NoPagado Then
            entregas = context.EntregasCuentas.Where(Function(o) o.Eliminado = False)
            Dim tipos As New List(Of Integer)
            If filtro.IncluirTPVFacturas = True Then
                tipos.Add(PacienteDebitoManager.TipoDocumento.N_Facturas)

            End If
            If filtro.IncluirTickets = True Then
                tipos.Add(PacienteDebitoManager.TipoDocumento.N_Tickets)

            End If
            If filtro.IncluirCitas = True Then
                tipos.Add(PacienteDebitoManager.TipoDocumento.Cita)

            End If
            If filtro.IncluirFacturas = True Then
                tipos.Add(PacienteDebitoManager.TipoDocumento.Factura)

            End If

            If tipos.Count > 0 Then
                entregas = entregas.Where(Function(o) tipos.Contains(o.TipoDocumento))
            End If

            If (filtro.FechaEmisionInicial.HasValue) Then
                entregas = entregas.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                entregas = entregas.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If

            'If (filtro.FechaPagoInicial.HasValue) Then

            If (filtro.HoraEmisionInicial.HasValue) Then
                entregas = entregas.Where(Function(o) o.Fecha >= New Date(filtro.FechaEmisionInicial.Value.Year, filtro.FechaEmisionInicial.Value.Month, _
                                                                   filtro.FechaEmisionInicial.Value.Day, filtro.HoraEmisionInicial.Value.Hour, filtro.HoraEmisionInicial.Value.Minute, _
                                                                   filtro.HoraEmisionInicial.Value.Second)
                                                   )
            Else
                ' entregas = entregas.Where(Function(o) o.Fecha >= filtro.FechaPagoInicial)
            End If

            'End If

            'If (filtro.FechaPagoFinal.HasValue) Then

            If (filtro.HoraEmisionFinal.HasValue) Then
                entregas = entregas.Where(Function(o) o.Fecha <= New Date(filtro.FechaEmisionFinal.Value.Year, filtro.FechaEmisionFinal.Value.Month, _
                                                                   filtro.FechaEmisionFinal.Value.Day, filtro.HoraEmisionFinal.Value.Hour, filtro.HoraEmisionFinal.Value.Minute, _
                                                                   filtro.HoraEmisionFinal.Value.Second)
                                                               )
            Else
                '  entregas = entregas.Where(Function(o) o.Fecha <= filtro.FechaPagoFinal)
            End If

            'End If


            If (filtro.IncluirConImporteCero = True) Then
                entregas = entregas.Where(Function(o) o.Importe >= 0)
            Else
                entregas = entregas.Where(Function(O) O.Importe > 0)
            End If

            If (Not filtro.FormaPago Is Nothing) Then
                entregas = entregas.Where(Function(o) o.IDFormaPago = filtro.FormaPago)
            End If

            lista.AddRange((From c In entregas
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.Fecha,
                                .FECHACOBRO = c.Fecha,
                                .FORMAPAGO = c.IDFormaPago,
                                .FORMAPAGOTEXTO = IIf(c.IDFormaPago.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .PagadoConCredito = c.PagadoConCredito,
                                .PAGADA = "S",
                                .TIPO = c.TipoDocumento,
                                .CONCEPTO = c.Descripcion,
                                 .IMPORTE = c.Importe
                           }).ToList())

        End If

        '*** PAGOPACIENTE *** se trata del dinero que los pacientes entregan a modo de crédito
        If (filtro.StatusPago <> StatusPago.NoPagado) Then
            pagos = context.PagosPacientes

            If (filtro.FechaEmisionInicial.HasValue) Then
                pagos = pagos.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                pagos = pagos.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If

            '  If (filtro.FechaPagoInicial.HasValue) Then

            If (filtro.HoraEmisionInicial.HasValue) Then
                pagos = pagos.Where(Function(o) o.Fecha >= New Date(filtro.FechaEmisionInicial.Value.Year, filtro.FechaEmisionInicial.Value.Month, _
                                                                   filtro.FechaEmisionInicial.Value.Day, filtro.HoraEmisionInicial.Value.Hour, filtro.HoraEmisionInicial.Value.Minute, _
                                                                   filtro.HoraEmisionInicial.Value.Second)
                                                   )
            Else
                pagos = pagos.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            'End If

            'If (filtro.FechaPagoFinal.HasValue) Then

            If (filtro.HoraEmisionFinal.HasValue) Then
                pagos = pagos.Where(Function(o) o.Fecha <= New Date(filtro.FechaEmisionFinal.Value.Year, filtro.FechaEmisionFinal.Value.Month, _
                                                                   filtro.FechaEmisionFinal.Value.Day, filtro.HoraEmisionFinal.Value.Hour, filtro.HoraEmisionFinal.Value.Minute, _
                                                                   filtro.HoraEmisionFinal.Value.Second)
                                                               )
            Else
                pagos = pagos.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If

            'End If

            If (Not filtro.FormaPago Is Nothing) Then
                pagos = pagos.Where(Function(o) o.IDFormaPago = filtro.FormaPago)
            End If

            lista.AddRange((From c In pagos
                     Select New LibroIngresoGastosItem With
                            {
                                  .FECHA = c.Fecha,
                                  .FECHACOBRO = c.Fecha,
                                  .FORMAPAGO = c.IDFormaPago,
                                  .FORMAPAGOTEXTO = IIf(c.IDFormaPago.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                  .PagadoConCredito = False,
                                  .TIPO = PacienteDebitoManager.TipoDocumento.PagoCuenta,
                                  .PAGADA = "S",
                                  .CONCEPTO = c.NotasCompletas,
                                  .AUTOMATICO = c.Automatico,
            .IMPORTE = c.Importe
                            }).ToList())
        End If

        'los pagos se gestionan desde débito paciente, por eso el resto de documento solo se cargan si el usuario quiere ver los no pagados o bien todos.
        '**** CITAS ****
        If filtro.IncluirCitas And (Not filtro.StatusPago = StatusPago.Pagado) Then

            citas = context.CITAs.Where(Function(o) o.Eliminado = False And o.PAGADA = "N")

            If (filtro.FechaEmisionInicial.HasValue) Then
                citas = citas.Where(Function(o) o.FECHA >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                citas = citas.Where(Function(o) o.FECHA <= filtro.FechaEmisionFinal)
            End If

            If (filtro.FechaPagoInicial.HasValue) Then
                citas = citas.Where(Function(o) o.FECHACOBRO >= filtro.FechaPagoInicial)
            End If

            If (filtro.FechaPagoFinal.HasValue) Then
                citas = citas.Where(Function(o) o.FECHACOBRO <= filtro.FechaPagoFinal)
            End If

            If (filtro.HoraEmisionInicial.HasValue) Then
                citas = citas.Where(Function(o) o.HORA >= New Date(filtro.FechaEmisionInicial.Value.Year, filtro.FechaEmisionInicial.Value.Month, _
                                                                   filtro.FechaEmisionInicial.Value.Day, filtro.HoraEmisionInicial.Value.Hour, filtro.HoraEmisionInicial.Value.Minute, _
                                                                   filtro.HoraEmisionInicial.Value.Second)
                                                               )
            End If

            If (filtro.HoraEmisionFinal.HasValue) Then
                citas = citas.Where(Function(o) o.HORAFIN <= New Date(filtro.FechaEmisionFinal.Value.Year, filtro.FechaEmisionFinal.Value.Month, _
                                                                   filtro.FechaEmisionFinal.Value.Day, filtro.HoraEmisionFinal.Value.Hour, filtro.HoraEmisionFinal.Value.Minute, _
                                                                   filtro.HoraEmisionFinal.Value.Second)
                                                               )
            End If

            If (filtro.IncluirConImporteCero = True) Then
                citas = citas.Where(Function(o) o.TOTAL >= 0)
            Else
                citas = citas.Where(Function(O) O.TOTAL > 0)
            End If

            If (Not filtro.FormaPago Is Nothing And filtro.StatusPago <> StatusPago.NoPagado) Then
                citas = citas.Where(Function(o) o.REFFORMAPAGO = filtro.FormaPago)
            End If


            lista.AddRange((From c In citas
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.FECHA,
                                .FECHACOBRO = c.FECHACOBRO,
                                .DESCUENTOIMPORTE = c.Descuento,
                                .FORMAPAGO = c.REFFORMAPAGO,
                                .FORMAPAGOTEXTO = IIf(c.REFFORMAPAGO.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .PAGADA = c.PAGADA,
                                .PagadoConCredito = c.PagadoConCredito,
                                .TIPO = c.TipoDocumento,
                                .CONCEPTO = c.DescripcionDocumento,
                                .IMPORTE = c.Importe
                           }).ToList())
        End If



        '*** FACTURAS ****
        If filtro.IncluirFacturas And (Not filtro.StatusPago = StatusPago.Pagado) Then

            facturas = context.FACTURAs.Where(Function(o) o.Eliminado = False And o.PAGADA = "N")

            If (filtro.FechaEmisionInicial.HasValue) Then
                facturas = facturas.Where(Function(o) o.FEMISION >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                facturas = facturas.Where(Function(o) o.FEMISION <= filtro.FechaEmisionFinal)
            End If

            If (filtro.FechaPagoInicial.HasValue) Then
                facturas = facturas.Where(Function(o) o.FECHACOBRO >= filtro.FechaPagoInicial)
            End If

            If (filtro.FechaPagoFinal.HasValue) Then
                facturas = facturas.Where(Function(o) o.FECHACOBRO <= filtro.FechaPagoFinal)
            End If

            If (Not filtro.FormaPago Is Nothing And filtro.StatusPago <> StatusPago.NoPagado) Then
                facturas = facturas.Where(Function(o) o.REFFORMAPAGO = filtro.FormaPago)
            End If


            lista.AddRange((From c In facturas
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.FECHA,
                                .FECHACOBRO = c.FECHACOBRO,
                                .DESCUENTOIMPORTE = c.Descuento,
                                .FORMAPAGO = c.REFFORMAPAGO,
                                .FORMAPAGOTEXTO = IIf(c.REFFORMAPAGO.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .PAGADA = c.PAGADA,
                                .PagadoConCredito = c.PagadoConCredito,
                                .TIPO = c.TipoDocumento,
                                .CONCEPTO = c.DescripcionDocumento,
                                .IMPORTE = c.Importe
                           }).ToList())
        End If


        '*** TICKETS ***
        If filtro.IncluirTickets And (Not filtro.StatusPago = StatusPago.Pagado) Then

            tickets = context.N_Tickets.Where(Function(o) o.Eliminado = False And o.Pagado = False)

            If (filtro.FechaEmisionInicial.HasValue) Then
                tickets = tickets.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                tickets = tickets.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If

            If (filtro.FechaPagoInicial.HasValue) Then
                tickets = tickets.Where(Function(o) o.FechaPagado >= filtro.FechaPagoInicial)
            End If

            If (filtro.FechaPagoFinal.HasValue) Then
                tickets = tickets.Where(Function(o) o.FechaPagado <= filtro.FechaPagoFinal)
            End If

            If (Not filtro.FormaPago Is Nothing And filtro.StatusPago <> StatusPago.NoPagado) Then
                tickets = tickets.Where(Function(o) o.ID_FormaPago = filtro.FormaPago)
            End If



            lista.AddRange((From c In tickets
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.Fecha,
                                .FECHACOBRO = c.FechaPagado,
                                .FORMAPAGO = c.FormaPago,
                                .FORMAPAGOTEXTO = IIf(c.FormaPago.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .PAGADA = IIf(c.Pagado, "S", "N"),
                                .PagadoConCredito = c.PagadoConCredito,
                                .TIPO = c.TipoDocumento,
                                .CONCEPTO = c.DescripcionDocumento,
                                .IMPORTE = c.Importe
                           }).ToList())
        End If
        '*** FACTURAS TPV ****
        If filtro.IncluirTPVFacturas And (Not filtro.StatusPago = StatusPago.Pagado) Then

            facturasTPV = context.N_Facturas.Where(Function(o) o.Pagado = False)

            If (filtro.FechaEmisionInicial.HasValue) Then
                facturasTPV = facturasTPV.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                facturasTPV = facturasTPV.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If

            If (filtro.FechaPagoInicial.HasValue) Then
                facturasTPV = facturasTPV.Where(Function(o) o.FechaPagado >= filtro.FechaPagoInicial)
            End If

            If (filtro.FechaPagoFinal.HasValue) Then
                facturasTPV = facturasTPV.Where(Function(o) o.FechaPagado <= filtro.FechaPagoFinal)
            End If

            If (Not filtro.FormaPago Is Nothing And filtro.StatusPago <> StatusPago.NoPagado) Then
                facturasTPV = facturasTPV.Where(Function(o) o.ID_FormaPago = filtro.FormaPago)
            End If


            lista.AddRange((From c In facturasTPV
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.Fecha,
                                .FECHACOBRO = c.FechaPagado,
                                .FORMAPAGO = c.ID_FormaPago,
                                .FORMAPAGOTEXTO = IIf(c.ID_FormaPago.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .PAGADA = IIf(c.Pagado, "S", "N"),
                                .PagadoConCredito = c.PagadoConCredito,
                                .TIPO = c.TipoDocumento,
                                .CONCEPTO = c.DescripcionDocumento,
                                .IMPORTE = c.Importe
                           }).ToList())
        End If

        '*** GASTOS ****
        If filtro.IncluirGastosVarios Then

            gastos = context.GASTOs

            If (filtro.FechaEmisionInicial.HasValue) Then
                gastos = gastos.Where(Function(o) o.FECHA >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                gastos = gastos.Where(Function(o) o.FECHA <= filtro.FechaEmisionFinal)
            End If


            If (Not filtro.FormaPago Is Nothing) Then
                gastos = gastos.Where(Function(o) o.REFFORMAPAGO = filtro.FormaPago)
            End If

            lista.AddRange((From c In gastos
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.FECHA,
                                .FECHACOBRO = c.FECHA,
                                .FORMAPAGO = c.REFFORMAPAGO,
                                .PagadoConCredito = False,
                                .PAGADA = "S",
                                .FORMAPAGOTEXTO = IIf(c.REFFORMAPAGO.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .CONCEPTO = c.CONCEPTO,
                                .IMPORTE = c.IMPORTE * -1
                           }).ToList())
        End If

        '*** LIQUIDACIONES MÉDICOS ****
        If filtro.IncluirImportesDoctores Then

            comisiones = context.Liquidacion_Medicos

            If (filtro.FechaEmisionInicial.HasValue) Then
                comisiones = comisiones.Where(Function(o) o.Fecha >= filtro.FechaEmisionInicial)
            End If

            If (filtro.FechaEmisionFinal.HasValue) Then
                comisiones = comisiones.Where(Function(o) o.Fecha <= filtro.FechaEmisionFinal)
            End If


            If (Not filtro.FormaPago Is Nothing) Then
                comisiones = comisiones.Where(Function(o) o.ID_FormaPago = filtro.FormaPago)
            End If

            lista.AddRange((From c In comisiones
                    Select New LibroIngresoGastosItem With
                           {
                                .FECHA = c.Fecha,
                                .FECHACOBRO = c.Fecha,
                                .FORMAPAGO = c.ID_FormaPago,
                                .PagadoConCredito = False,
                                .PAGADA = "S",
                                .FORMAPAGOTEXTO = IIf(c.ID_FormaPago.Trim.Length > 0, c.FORMASPAGO.DESCRIPCION, "Ninguna"),
                                .CONCEPTO = c.DescripcionText,
            .IMPORTE = c.Importe * -1
                           }).ToList())
        End If

        Items = lista
        Return lista
    End Function



    Public ReadOnly Property EntregasDocumento As Object
        Get
            Dim _entregas = Items.Where(Function(o) o.TIPO = PacienteDebitoManager.TipoDocumento.PagoCuenta).ToList
            Return _entregas
        End Get
    End Property



End Class
