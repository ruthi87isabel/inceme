Public Class FacturasManager

    
    Public Shared Function ListadoFACTURAsBasico(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of FACTURA)

        Dim FACTURAs As IQueryable(Of FACTURA)

        'Filtro las eliminadas
        FACTURAs = context.FACTURAs.Where(Function(o) o.Eliminado = False Or Not o.Eliminado.HasValue)

        'Incluir or no las con Importe 0
        If Not filtros.IncluirConImporteCero Then
            FACTURAs = FACTURAs.Where(Function(o) o.TOTAL > 0)
        End If

        'Filtrar por doc Pagados, no pagados o todos
        If filtros.StatusPago = StatusPago.Pagado Then
            FACTURAs = FACTURAs.Where(Function(o) o.PAGADA = "S")
        End If

        If filtros.StatusPago = StatusPago.NoPagado Then
            FACTURAs = FACTURAs.Where(Function(o) o.PAGADA = "N")
        End If

        ''Filtro de Hora Inicial Emision
        If filtros.HoraEmisionInicial.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) (o.HORA.Value.Hour * 60 + o.HORA.Value.Minute >= filtros.HoraEmisionInicial.Value.Hour * 60 + filtros.HoraEmisionInicial.Value.Minute))
        End If

        'Filtro de Hora Final Emision
        If filtros.HoraEmisionFinal.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) (o.HORA.Value.Hour * 60 + o.HORA.Value.Minute <= filtros.HoraEmisionFinal.Value.Hour * 60 + filtros.HoraEmisionFinal.Value.Minute))
        End If

        'Filtro de forma de Pago
        If Not filtros.FormaPago Is Nothing Then
            FACTURAs = FACTURAs.Where(Function(o) (o.REFFORMAPAGO = filtros.FormaPago))
        End If

        'Fecha Emision Inicial 
        If filtros.FechaEmisionInicial.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) o.FECHA >= filtros.FechaEmisionInicial)
        End If

        'Fecha Emision Final
        If filtros.FechaEmisionFinal.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) o.FECHA <= filtros.FechaEmisionFinal)
        End If

        'Fecha Pago Inicial 
        If filtros.FechaPagoInicial.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) o.FECHACOBRO >= filtros.FechaPagoInicial)
        End If

        'Fecha Pago Final
        If filtros.FechaPagoFinal.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) o.FECHA <= filtros.FechaPagoFinal)
        End If

        If filtros.CPACIENTE.HasValue Then
            FACTURAs = FACTURAs.Where(Function(o) o.REFPACIENTE = filtros.CPACIENTE)
        End If

        Return FACTURAs.OrderByDescending(Function(o) o.FECHA)

    End Function

    Public Shared Function ListadoFACTURAsDebitoPaciente(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of FACTURA)
        Dim FACTURAs As IQueryable(Of FACTURA) = ListadoFACTURAsBasico(context, filtros)
        FACTURAs = FACTURAs.Where(Function(c) c.REFPACIENTE = filtros.CPACIENTE And (Not c.REFRECIBO.HasValue Or c.REFRECIBO = 0))

        Return FACTURAs
    End Function


    Public Shared Function ListadoFACTURAs(context As CMLinqDataContext, filtros As FiltroListadoFacturas) As IQueryable(Of FACTURA)
        Dim FACTURAs As IQueryable(Of FACTURA) = ListadoFACTURAsBasico(context, filtros)

        If Not String.IsNullOrEmpty(filtros.NOMBREPACIENTE) Then
            FACTURAs = FACTURAs.Where(Function(c) c.PACIENTE1.NOMBRE.StartsWith(filtros.NOMBREPACIENTE))
        End If

        If Not String.IsNullOrEmpty(filtros.APELLIDO1) Then
            FACTURAs = FACTURAs.Where(Function(c) c.PACIENTE1.APELLIDO1.StartsWith(filtros.APELLIDO1))
        End If

        If Not String.IsNullOrEmpty(filtros.APELLIDO2) Then
            FACTURAs = FACTURAs.Where(Function(c) c.PACIENTE1.APELLIDO2.StartsWith(filtros.APELLIDO2))
        End If

        Return FACTURAs
    End Function


    Public Shared Function ListadoFACTURAsParaInformeGastos(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of FACTURA)

        Dim FACTURAs As IQueryable(Of FACTURA) = ListadoFACTURAsBasico(context, filtros)

        'Si tiene recibo la FACTURA no cuenta
        FACTURAs = FACTURAs.Where(Function(o) o.REFRECIBO Is Nothing Or o.REFRECIBO >= 0)

        FACTURAs.Where(Function(o) o.PagadoConCredito = False)

        Return FACTURAs
    End Function

    Public Shared Function ListadoFACTURAsPagadasConCreditoParaInformeGastos(context As CMLinqDataContext, filtros As FiltroGenericoDocumentos) As IQueryable(Of FACTURA)

        Dim FACTURAs As IQueryable(Of FACTURA) = ListadoFACTURAsBasico(context, filtros)
        'Si tiene recibo la FACTURA no cuenta
        FACTURAs = FACTURAs.Where(Function(o) o.REFRECIBO Is Nothing Or o.REFRECIBO >= 0)

        FACTURAs.Where(Function(o) o.PagadoConCredito = True)
        Return FACTURAs
    End Function

    Public Shared Sub ExportarAFacturaE(context As CMLinqDataContext, factura As FACTURA)
        Dim varGlobal As VariablesGlobale

        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "FacturaEFicherosParametrosUrl")
        If varGlobal Is Nothing Or String.IsNullOrEmpty(varGlobal.Valor) Then
            MessageBox.Show(Nothing, "Debe configurar una direccion donde guardar los ficheros de parametros", "Notificacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim path As String = varGlobal.Valor
        Dim FILE_NAME As String = path & "\params.txt"
        If IO.File.Exists(FILE_NAME) = False Then
            IO.File.Create(FILE_NAME).Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
        'Get Parameters here

        objWriter.WriteLine("Fuente: INCEME")
        objWriter.WriteLine("IdFactura: " & factura.IDFACTURA.ToString())

        objWriter.WriteLine("------------------------------------")
        objWriter.WriteLine(" ")
        objWriter.WriteLine("EMISOR")

        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "NombreOrdenante")
        objWriter.WriteLine("Seller: " & varGlobal.Valor)
        objWriter.WriteLine("PersonTypeCode: J")
        objWriter.WriteLine("ResidenceTypeCode: U")
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "CIF")
        objWriter.WriteLine("TaxIdentificationNumber: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "NombreOrdenante")
        objWriter.WriteLine("CorporateName: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "NombreComercial")
        objWriter.WriteLine("TradeName: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Libro")
        objWriter.WriteLine("Book: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "RegistroLocalizacion")
        objWriter.WriteLine("RegisterOfCompaniesLocation: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Hoja")
        objWriter.WriteLine("Sheet: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Folio")
        objWriter.WriteLine("Folio: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Seccion")
        objWriter.WriteLine("Section: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Volumen")
        objWriter.WriteLine("Volume: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Domicilio")
        objWriter.WriteLine("Address: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "CP")
        objWriter.WriteLine("Postcode: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Localidad")
        objWriter.WriteLine("Town: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Provincia")
        objWriter.WriteLine("Province: " & varGlobal.Valor)
        objWriter.WriteLine("CountryCode: ESP")
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Tlfno1")
        objWriter.WriteLine("Telephone: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Web")
        objWriter.WriteLine("WebAddress: " & varGlobal.Valor)
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "Email")
        objWriter.WriteLine("ElectronicMail: " & varGlobal.Valor)

        objWriter.WriteLine("------------------------------------")
        objWriter.WriteLine(" ")
        objWriter.WriteLine("RECEPTOR")

        objWriter.WriteLine("Buyer: " & factura.PACIENTE)
        objWriter.WriteLine("PersonTypeCode: F")
        objWriter.WriteLine("ResidenceTypeCode: U")
        objWriter.WriteLine("ID: " & factura.PACIENTE1.CPACIENTE)
        objWriter.WriteLine("Name: " & factura.PACIENTE1.NOMBRE)
        objWriter.WriteLine("Surname1: " & factura.PACIENTE1.APELLIDO1)
        objWriter.WriteLine("Surname2: " & factura.PACIENTE1.APELLIDO2)
        objWriter.WriteLine("TaxIdentificationNumber: " & factura.DNI)
        objWriter.WriteLine("CorporateName: " & factura.PACIENTE)
        objWriter.WriteLine("Address: " & factura.DIRECCION)
        objWriter.WriteLine("Postcode: " & factura.CP)
        objWriter.WriteLine("Town: " & factura.LOCALIDAD)
        objWriter.WriteLine("Province: " & factura.PROVINCIA)
        objWriter.WriteLine("CountryCode: ESP")
        objWriter.WriteLine("Telephone: " & factura.PACIENTE1.TLFNO)
        objWriter.WriteLine("WebAddress: " & factura.PACIENTE1.WEB)
        objWriter.WriteLine("ElectronicMail: " & factura.PACIENTE1.EMAIL)

        objWriter.WriteLine("------------------------------------")
        objWriter.WriteLine(" ")
        objWriter.WriteLine("FACTURA")

        objWriter.WriteLine("Modality: I")
        objWriter.WriteLine("InvoiceIssuerType: EM")
        objWriter.WriteLine("InvoiceNumber: " & factura.NUMERO.Remove(0, factura.REFSERIE.Length))
        objWriter.WriteLine("InvoiceSeriesCode: " & factura.REFSERIE)
        objWriter.WriteLine("InvoiceDocumentType: FC")
        objWriter.WriteLine("InvoiceClass: OO")
        objWriter.WriteLine("IssueDate: " & factura.FECHA)
        objWriter.WriteLine("InvoiceCurrencyCode: EUR")
        objWriter.WriteLine("LanguageName: es")
        objWriter.WriteLine("TaxTypeCodeOutput: 01")
        objWriter.WriteLine("TaxRateOutput: 0.00")
        objWriter.WriteLine("TaxTypeCodeWithheld: 01")
        Dim total As Decimal = factura.LINEASFACTURAs.Sum(Function(l) l.ImporteOriginal * l.CANTIDAD)
        Dim percent As Decimal = factura.PORCENTAJEIRPF * 100
        Dim ret As Decimal = Math.Round(total * factura.PORCENTAJEIRPF, 2)
        objWriter.WriteLine("TaxRateWithheld: " & percent)
        Dim taxableBase As Decimal = (total * 100) / (100 + factura.TIPOIVA)
        objWriter.WriteLine("TaxableBase: " & taxableBase.ToString())
        Dim totalGrossAmount As Decimal = taxableBase
        objWriter.WriteLine("TotalGrossAmount: " & totalGrossAmount)
        Dim totalGrossAmountBeforeTaxes As Decimal = totalGrossAmount
        objWriter.WriteLine("TotalGrossAmountBeforeTaxes: " & totalGrossAmountBeforeTaxes)
        Dim totalTaxOutputs As Decimal = (factura.TIPOIVA * taxableBase) / 100
        objWriter.WriteLine("TotalTaxOutputs: " & totalTaxOutputs.ToString())
        Dim totalTaxesWithheld As Decimal = ret
        objWriter.WriteLine("TotalTaxesWithheld: " & totalTaxesWithheld.ToString())
        Dim amount = total - ret
        objWriter.WriteLine("InvoiceTotal: " & (totalGrossAmountBeforeTaxes + totalTaxOutputs - totalTaxesWithheld).ToString())
        objWriter.WriteLine("TotalOutstandingAmount: " & Math.Round(amount, 2))
        objWriter.WriteLine("TotalExecutableAmount: " & Math.Round(amount, 2))

        objWriter.WriteLine("------------------------------------")
        objWriter.WriteLine(" ")
        objWriter.WriteLine("LINEAS FACTURA")

        Dim index As Int32 = 1
        For Each lf As LINEASFACTURA In factura.LINEASFACTURAs
            objWriter.WriteLine("Line: " & index.ToString())
            objWriter.WriteLine("ItemDescription: " & lf.CONCEPTO)
            objWriter.WriteLine("Quantity: " & lf.CANTIDAD.ToString())
            objWriter.WriteLine("UnitPriceWithoutTax: " & lf.ImporteOriginal.ToString())
            objWriter.WriteLine("TotalCost: " & (lf.CANTIDAD * lf.ImporteOriginal).ToString())
            objWriter.WriteLine("DiscountAmount: " & lf.Descuento.ToString())
            objWriter.WriteLine("ChargeAmount: " & lf.Descuento.ToString())
            objWriter.WriteLine("GrossAmount: " & (lf.CANTIDAD * lf.ImporteOriginal - lf.Descuento).ToString())
            objWriter.WriteLine("TaxesWithheld.Tax: 0.000000")
            objWriter.WriteLine("TaxesOutputs.Tax: 0.000000")
            index += 1
        Next

        objWriter.Close()


        ' Prepare the process to run
        varGlobal = context.VariablesGlobales.SingleOrDefault(Function(v) v.Clave = "FacturaEEjecutableUrl")
        If varGlobal Is Nothing Or String.IsNullOrEmpty(varGlobal.Valor) Then
            MessageBox.Show(Nothing, "Debe introducir la URL del ejecutable de la aplicacion de FacturaE en las Opciones de Configuracion",
                            "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim start As ProcessStartInfo = New ProcessStartInfo()
        start.Arguments = FILE_NAME
        start.FileName = varGlobal.Valor
        Dim proc = Process.Start(start)
    End Sub


End Class
