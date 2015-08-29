Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Public Class form_generar_recfact

    Dim ClientesServicios As DataTable
    Dim CodigoFactura As Object  'ultimo codigo de factura usado para la serie seleccionada. LO uso si hay que borrar
    'las facturas generadas, para volver a poner el contador otra vez conforme estaba antes
    Dim ConceptosFacturables As DataTable
    Dim tb_Recibos As New CMDataSet.RECIBOSDataTable
    Dim tb_Fras As New CMDataSet.FACTURASDataTable
    Dim tb_FrasLineas As New CMDataSet.LINEASFACTURASDataTable

    ''' <summary>
    ''' Carga los pacientes que tienen algun Servicio Periodico asignado.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaPacientesConServiciosPeriodicos()
        Dim strSql As String = ""
        Dim Filtro As String = ""
        Dim parametros() As SqlParameter
        Dim cont As Integer = 0

        strSql = "SELECT     RTRIM(PACIENTES.CODIGOPROPIO) AS CodigoPropio, PACIENTES.CPACIENTE, RTRIM(PACIENTES.NOMBRE) as Nombre, RTRIM(PACIENTES.APELLIDO1) as Apellido1, " & _
                     " RTRIM(PACIENTES.APELLIDO2) AS Apellido2, RTRIM(PACIENTES.DOMICILIO) as Domicilio, PACIENTES.LOCALIDAD, " & _
                     "PACIENTES.PROVINCIA AS Provincia, CONCEPTOSFACTURABLES.IMPORTE, PACIENTES.ENTIDAD, PACIENTES.OFICINA, PACIENTES.DC, " & _
                    "PACIENTES.CUENTA, ConceptosFacturables.DESCRIPCION,ConceptosFacturables.REFCONCEPTO, PACIENTES.REFFORMAPAGO,PACIENTES.CP,PACIENTES.DNI,  " & _
                    " PACIENTES.REFEMPRESA, PACIENTES.REFMUTUA " & _
                    "FROM  PACIENTES , CONCEPTOSFACTURABLES where  PACIENTES.CPACIENTE = CONCEPTOSFACTURABLES.REFPACIENTE and PACIENTES.ELIMINADO<>1 "

        'Si esta activado el filtro, preparo la sentencia
        If Me.chk_FiltrarServicios.Checked Then
            strSql += " and ConceptosFacturables.REFCONCEPTO=@RefConcepto "
            ReDim parametros(0)
            parametros(0) = New SqlParameter("@RefConcepto", Me.cmb_ConceptosFacturables.SelectedValue)
        End If

        If Me.chkPagoBanco.Checked Then
            strSql += " and PACIENTES.PAGOBANCO='S' "
        End If


        'Si esta activado el filtro de entidad, preparo la sentencia
        If Me.chkFiltraEntidadBancaria.Checked Then
            If chkDiferente.Checked Then
                strSql += " and PACIENTES.ENTIDAD<>@Entidad "
            Else
                strSql += " and PACIENTES.ENTIDAD=@Entidad "
            End If

            If parametros Is Nothing OrElse parametros.Length = 0 Then
                ReDim parametros(0)
                parametros(0) = New SqlParameter("@Entidad", Me.cmbEntidad.Text)
            Else
                cont = parametros.Length
                ReDim Preserve parametros((cont))
                parametros(cont) = New SqlParameter("@Entidad", Me.cmbEntidad.Text)
            End If

        End If

            If Not ClientesServicios Is Nothing Then ClientesServicios.Clear()
            ClientesServicios = SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, strSql, parametros).Tables(0)
            Me.dgv_pac.DataSource = ClientesServicios
            Me.lb_pac.Text = ClientesServicios.Rows.Count
    End Sub

    ''' <summary>
    ''' Carga las entidades bancarias dadas de alta en la tabla Bancos para
    ''' poder filtrar los clientes por esa entidad a la hora de emitir recibos.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaEntidadesBancarias()
        Dim sqlstr As String = ""
        Dim tb_bancos As DataTable
        Dim i As Integer = 0
        sqlstr = "select distinct entidad from Bancos"
        tb_bancos = SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, sqlstr).Tables(0)
        If cmbEntidad.Items.Count > 0 Then
            cmbEntidad.Items.Clear()
        End If
        For i = 0 To tb_bancos.Rows.Count - 1
            Me.cmbEntidad.Items.Add(tb_bancos.Rows(i).Item(0))
        Next

    End Sub
    ''' <summary>
    ''' Genera El recibo o la factura para cada cliente que tenga un servicio periodico asignado
    ''' </summary>
    ''' <param name="Recibo">Si es true, se generan recibos y si es false se generan facturas</param>
    ''' <remarks></remarks>
    Private Sub GeneraDocumento(ByVal Recibo As Boolean)
        Dim i As Integer = 0
        If Recibo = True Then

            Dim filas As CMDataSet.RECIBOSRow
            If Not Me.tb_Recibos Is Nothing Then tb_Recibos.Clear()
            TabControl1.TabPages.Clear()
            Me.TabControl1.TabPages.Add(Me.tbRecibos)
            For i = 0 To Me.dgv_pac.RowCount - 1
                If dgv_pac.Rows(i).Cells("Seleccionar").Value = True Then
                    filas = tb_Recibos.NewRow
                    filas.COBRADO = "N"
                    filas.CONCEPTO = Me.dgv_pac.Rows(i).Cells("Descripcion").Value
                    If Not Me.dgv_pac.Rows(i).Cells("Cuenta").Value.GetType Is GetType(DBNull) Then
                        filas.CUENTA = Me.dgv_pac.Rows(i).Cells("Cuenta").Value
                    Else
                        filas.CUENTA = ""
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Domicilio").Value.GetType Is GetType(DBNull) Then
                        filas.DIRECCION = Me.dgv_pac.Rows(i).Cells("Domicilio").Value
                    Else
                        filas.DIRECCION = ""
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Localidad").Value.GetType Is GetType(DBNull) Then
                        filas.DIRECCION += vbCrLf & Me.dgv_pac.Rows(i).Cells("Localidad").Value
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Provincia").Value.GetType Is GetType(DBNull) Then
                        filas.DIRECCION += vbCrLf & Me.dgv_pac.Rows(i).Cells("Provincia").Value
                    End If
                    filas.EMITIDO = "N"
                    If Not Me.dgv_pac.Rows(i).Cells("Entidad").Value.GetType Is GetType(DBNull) Then
                        filas.ENTIDAD = Me.dgv_pac.Rows(i).Cells("Entidad").Value
                    Else
                        filas.ENTIDAD = ""
                    End If

                    If Not Me.dgv_pac.Rows(i).Cells("DC").Value.GetType Is GetType(DBNull) Then
                        filas.DC = Me.dgv_pac.Rows(i).Cells("DC").Value
                    Else
                        filas.DC = ""
                    End If

                    filas.FECHAEMISION = Me.dtp_fechaemision.Value.Date
                    If Not Me.dgv_pac.Rows(i).Cells("Importe").Value.GetType Is GetType(DBNull) Then
                        filas.IMPORTE = Me.dgv_pac.Rows(i).Cells("Importe").Value
                    Else
                        filas.IMPORTE = 0
                    End If
                    filas.TIPO = "P"
                    filas.N19 = "N"

                    filas.REFPACIENTE = dgv_pac.Rows(i).Cells("CODIGO").Value

                    If Not Me.dgv_pac.Rows(i).Cells("Apellido1").Value.GetType Is GetType(DBNull) Then
                        filas.NOMBRE = Me.dgv_pac.Rows(i).Cells("Apellido1").Value
                    Else
                        filas.NOMBRE = ""
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Apellido2").Value.GetType Is GetType(DBNull) Then
                        filas.NOMBRE += " " & Me.dgv_pac.Rows(i).Cells("Apellido2").Value
                    
                    End If

                    If Not Me.dgv_pac.Rows(i).Cells("Nombre").Value.GetType Is GetType(DBNull) Then
                        filas.NOMBRE += ", " & Me.dgv_pac.Rows(i).Cells("Nombre").Value
                    End If

                    If Not Me.dgv_pac.Rows(i).Cells("Oficina").Value.GetType Is GetType(DBNull) Then
                        filas.OFICINA = Me.dgv_pac.Rows(i).Cells("Oficina").Value
                    Else
                        filas.OFICINA = ""
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("RefFormaPago").Value.GetType Is GetType(DBNull) Then
                        filas.REFFORMAPAGO = Me.dgv_pac.Rows(i).Cells("RefFormaPago").Value
                    Else
                        filas.IsREFFORMAPAGONull()
                    End If
                    filas.NOTAS = "Generado automaticamente el " & Now.Date & " por " & Globales.Usuario.USUARIO & "."

                    filas.CUENTABANCO = filas.ENTIDAD & filas.OFICINA & filas.DC & filas.CUENTA
                    If Not Me.dgv_pac.Rows(i).Cells("Refempresa").Value.GetType Is GetType(DBNull) Then
                        filas.REFEMPRESA = Me.dgv_pac.Rows(i).Cells("REFEmpresa").Value
                    Else
                        filas.IsREFEMPRESANull()
                    End If

                    'Añado la fila a la tabla
                    tb_Recibos.Rows.Add(filas)

                End If
            Next
            Me.dgvRecibos.DataSource = tb_Recibos
        Else 'si no es recibo será factura
            If Not Me.tb_Fras Is Nothing Then Me.tb_Fras.Clear()
            If Not Me.tb_FrasLineas Is Nothing Then Me.tb_FrasLineas.Clear()
            TabControl1.TabPages.Clear()
            Me.TabControl1.TabPages.Add(Me.tbFacturas)

            Dim filas As CMDataSet.FACTURASRow

            Dim filasfilas As CMDataSet.LINEASFACTURASRow

            Dim cont As Integer = 0
            If cb_serie.SelectedValue = "" Then
                MsgBox("Debe indicar una serie de Facturación", MsgBoxStyle.Exclamation)
                Return
            End If
            CodigoFactura = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select top 1 Contador from Series where Codigo='" & Me.cb_serie.Text & "' order by Contador Desc")

            For i = 0 To Me.dgv_pac.RowCount - 1

                If dgv_pac.Rows(i).Cells("Seleccionar").Value = True Then
                    Dim IDFACTURA As Integer
                    cont += 1
                    'Obtengo el ultimo id de la tabla Facturas
                    If cont = 1 Then IDFACTURA = Globales.ObtenerMaximoValor("FACTURAS", "IDFACTURA")
                    IDFACTURA += 1
                    'Obtengo el ultimo numero para la serie seleccionada
                    Dim Numero As String = ""
                    If Me.cb_serie.Text.Trim.Length > 0 Then
                        Numero = Me.GeneraNumeroFactura(Me.cb_serie.Text)
                    Else
                        MsgBox("Debe seleccionar una serie", MsgBoxStyle.Exclamation)
                        Return
                    End If

                    filas = tb_Fras.NewFACTURASRow
                    If Not dgv_pac.Rows(i).Cells("CP").Value.GetType Is GetType(DBNull) Then
                        filas.CP = dgv_pac.Rows(i).Cells("CP").Value
                    Else
                        filas.CP = ""
                    End If

                    If Not dgv_pac.Rows(i).Cells("Domicilio").Value.GetType Is GetType(DBNull) Then
                        filas.DIRECCION = dgv_pac.Rows(i).Cells("Domicilio").Value
                    Else
                        filas.DIRECCION = ""
                    End If
                    If Not dgv_pac.Rows(i).Cells("DNI").Value.GetType Is GetType(DBNull) Then
                        filas.DNI = dgv_pac.Rows(i).Cells("DNI").Value
                    Else
                        filas.DNI = ""
                    End If
                    filas.FECHA = Me.dtp_fechaemision.Value.Date
                    filas.FEMISION = Me.dtp_fechaemision.Value.Date
                    filas.IDFACTURA = IDFACTURA
                    filas.NUMEROFACTURA = IDFACTURA
                    filas.NUMERO = Numero
                    If Me.tb_IRPF.Text.Trim.Length = 0 Then
                        tb_IRPF.Text = 0
                    End If
                    If Not IsNumeric(Me.tb_IRPF.Text) Then
                        tb_IRPF.Text = 0
                    End If
                    filas.PORCENTAJEIRPF = Me.tb_IRPF.Text.Trim
                    filas.IRPF = dgv_pac.Rows(i).Cells("IMPORTE").Value * (Me.tb_IRPF.Text / 100)
                    If Not dgv_pac.Rows(i).Cells("Localidad").Value.GetType Is GetType(DBNull) Then
                        filas.LOCALIDAD = dgv_pac.Rows(i).Cells("Localidad").Value
                    Else
                        filas.LOCALIDAD = ""
                    End If

                    filas.REFPACIENTE = dgv_pac.Rows(i).Cells("CODIGO").Value
                    If Not Me.dgv_pac.Rows(i).Cells("Apellido1").Value.GetType Is GetType(DBNull) Then
                        filas.PACIENTE = Me.dgv_pac.Rows(i).Cells("Apellido1").Value
                    Else
                        filas.PACIENTE = ""
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Apellido2").Value.GetType Is GetType(DBNull) Then
                        filas.PACIENTE += " " & Me.dgv_pac.Rows(i).Cells("Apellido2").Value
                    End If
                    If Not Me.dgv_pac.Rows(i).Cells("Nombre").Value.GetType Is GetType(DBNull) Then
                        filas.PACIENTE += ", " & Me.dgv_pac.Rows(i).Cells("Nombre").Value
                    End If

                    filas.PAGADA = "N"
                    If Not dgv_pac.Rows(i).Cells("Provincia").Value.GetType Is GetType(DBNull) Then
                        filas.PROVINCIA = dgv_pac.Rows(i).Cells("Provincia").Value
                    Else
                        filas.PROVINCIA = ""
                    End If

                    If chkRecibo.Checked Then
                        filas.RECIBO = "S"
                    Else
                        filas.RECIBO = "N"
                    End If

                    If Not dgv_pac.Rows(i).Cells("REFFORMAPAGO").Value.GetType Is GetType(DBNull) Then
                        filas.REFFORMAPAGO = dgv_pac.Rows(i).Cells("REFFORMAPAGO").Value
                    Else
                        filas.IsREFFORMAPAGONull()
                    End If

                    filas.REFSERIE = Me.cb_serie.SelectedValue

                    If cb_Iva.Text.Trim.Length = 0 Then
                        filas.TIPOIVA = 0
                    Else
                        If IsNumeric(cb_Iva.Text) Then
                            filas.TIPOIVA = cb_Iva.Text
                        Else
                            filas.TIPOIVA = 0
                        End If
                    End If
                    filas.TOTAL = dgv_pac.Rows(i).Cells("IMPORTE").Value - filas.IRPF + (dgv_pac.Rows(i).Cells("IMPORTE").Value * filas.TIPOIVA / 100)
                    filas.MUTUA = ""
                    filas.EMPRESA = ""
                    filas.FACTURAR = "P"

                    'Añado la fila a la tabla Facturas
                    tb_Fras.Rows.Add(filas)

                    filasfilas = tb_FrasLineas.NewLINEASFACTURASRow
                    filasfilas.CANTIDAD = 1
                    If Not dgv_pac.Rows(i).Cells("Descripcion").Value.GetType Is GetType(DBNull) Then
                        filasfilas.CONCEPTO = dgv_pac.Rows(i).Cells("Descripcion").Value
                    Else
                        filasfilas.CONCEPTO = ""
                    End If
                    filasfilas.IMPORTE = dgv_pac.Rows(i).Cells("IMPORTE").Value
                    If Not dgv_pac.Rows(i).Cells("REFCONCEPTO").Value.GetType Is GetType(DBNull) Then
                        filasfilas.REFCONCEPTO = dgv_pac.Rows(i).Cells("REFCONCEPTO").Value
                    Else
                        filasfilas.REFCONCEPTO = ""
                    End If

                    filasfilas.REFFACTURA = IDFACTURA
                    filasfilas.TIPOIVA = filas.TIPOIVA
                    tb_FrasLineas.Rows.Add(filasfilas)

                End If
            Next
            Me.dgv_Fras.DataSource = tb_Fras
        End If
        lb_recibos.Text = Me.dgv_Fras.Rows.Count
        Me.bt_generar.Enabled = False

    End Sub
    ''' <summary>
    ''' Calcula el proximo numero de Factura 
    ''' </summary>
    ''' <param name="acod">Serie para la que debe calcular el Nº</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GeneraNumeroFactura(ByVal acod As String) As String
        If acod <> "" Then
            Dim SeriesTableAdapter As New CMDataSetTableAdapters.SERIESTableAdapter
            Dim _data As CMDataSet.SERIESDataTable = SeriesTableAdapter.GetSerieByCodigo(acod)
            Dim _cantn As Integer = _data.Rows(0).Item("CONTADOR")
            Dim _cant As String = (_cantn + 1).ToString()
            SeriesTableAdapter.Update(acod, _cantn + 1, acod, _cantn)
            Dim _digits As Integer = _cant.Length
            Dim i As Integer
            Dim _result As String = acod
            For i = 0 To 5 - _digits
                _result = _result + "0"
            Next
            _result = _result + _cant
            Return _result
        End If
        Return ""
    End Function

    ''' <summary>
    ''' Carga un lista de conceptos facturables asignados a pacientes mediante un distinct de la tabla ConceptosFacturables
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaListaConceptosFacturables()
        Dim strSql As String = ""
        strSql = "Select distinct RefConcepto,rtrim(Descripcion) as Descripcion from ConceptosFacturables"
        If Not Me.ConceptosFacturables Is Nothing Then Me.ConceptosFacturables.Clear()

        ConceptosFacturables = SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, strSql).Tables(0)
        Me.cmb_ConceptosFacturables.DataSource = ConceptosFacturables
        Me.cmb_ConceptosFacturables.ValueMember = "RefConcepto"
        Me.cmb_ConceptosFacturables.DisplayMember = "Descripcion"
    End Sub


    Private Sub CargaSeries()
        Dim tablaSeries As New CMDataSet.SERIESDataTable
        Dim adapterSerie As New CMDataSetTableAdapters.SERIESTableAdapter
        adapterSerie.Fill(tablaSeries)
        Me.cb_serie.DataSource = tablaSeries
        Me.cb_serie.ValueMember = "CODIGO"
        Me.cb_serie.DisplayMember = "CODIGO"
    End Sub

    Private Sub bt_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Filtrar.Click
        CargaPacientesConServiciosPeriodicos()
    End Sub

    Private Sub form_generar_recfact_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bt_generar.Enabled = False Then
            MsgBox("No puede finalizar sin generar los ficheros. Si no desea continuar con la generación de ficheros, cancelelá antes de salir.", MsgBoxStyle.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub form_generar_recfact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargaListaConceptosFacturables()
        CargaSeries()
        CargaEntidadesBancarias()
        Me.TabControl1.TabPages.Remove(Me.tbRecibos)
        Me.TabControl1.TabPages.Remove(Me.tbFacturas)
    End Sub


    Private Sub bt_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_generar.Click
        Dim recibo As Boolean
        Dim chekeado As Boolean = False
        Dim i As Integer = 0

        If Me.rb_facturas.Checked Then
            recibo = False
            For i = 0 To Me.dgv_pac.Rows.Count - 1
                If Me.dgv_pac.Rows(i).Cells("Seleccionar").Value = True Then
                    chekeado = True
                    Exit For
                End If
            Next
        Else
            recibo = True
            For i = 0 To Me.dgv_pac.Rows.Count - 1
                If Me.dgv_pac.Rows(i).Cells("Seleccionar").Value = True Then
                    chekeado = True
                    Exit For
                End If
            Next
        End If

        If chekeado = True Then Me.GeneraDocumento(recibo) Else MsgBox("Debe seleccionar por lo menos una fila.", MsgBoxStyle.Exclamation)
        If recibo = True Then
            Me.lb_recibos.Text = Me.dgvRecibos.Rows.Count
        Else
            Me.lb_recibos.Text = Me.dgv_Fras.Rows.Count
        End If
    End Sub

    Private Sub bt_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_borrar.Click
        If Not Me.tb_Fras Is Nothing Then Me.tb_Fras.Clear()
        If Not Me.tb_FrasLineas Is Nothing Then Me.tb_FrasLineas.Clear()
        If Not Me.tb_Recibos Is Nothing Then Me.tb_Recibos.Clear()

        'Reseteo el contador de las facturas
        If Not CodigoFactura Is Nothing Then
            If Not CodigoFactura.GetType Is GetType(DBNull) Then
                SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, "Update Series Set Contador = '" & Trim(Me.CodigoFactura) & "' where Codigo = '" & Me.cb_serie.Text & "'")
            End If
        End If

        Me.bt_generar.Enabled = True
    End Sub
    ''' <summary>
    ''' Guarda los documentos Generados.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarCambios()
        Dim adaptRec As New CMDataSetTableAdapters.RECIBOSTableAdapter
        Dim adaptFac As New CMDataSetTableAdapters.FACTURASTableAdapter
        Dim adaptFacLin As New CMDataSetTableAdapters.LINEASFACTURASTableAdapter
        Try
            If Not Me.tb_Fras Is Nothing Then
                If Me.tb_Fras.Rows.Count > 0 Then
                    adaptFac.Update(tb_Fras)
                    If Not Me.tb_FrasLineas Is Nothing Then
                        adaptFacLin.Update(Me.tb_FrasLineas)
                    End If
                    Me.bt_generar.Enabled = True
                End If
            End If
            If Not Me.tb_Recibos Is Nothing Then
                Dim i As Integer = 0
                Dim sqlparam(21) As SqlClient.SqlParameter
                Dim strSql As String = ""
                Dim res As Integer = 0
                If Me.tb_Recibos.Rows.Count > 0 Then
                    Me.bt_generar.Enabled = True
                    strSql = "INSERT RECIBOS (FECHAEMISION,COBRADO,EMITIDO,REFCITA,REFFACTURA,IMPORTE,REFPACIENTE,FECHAVENCIMIENTO,NOMBRE,DIRECCION,NOTAS," & _
                    "CUENTABANCO,ENTIDAD,OFICINA,DC,CUENTA,CONCEPTO,FECHACOBRO,N19,REFFORMAPAGO,TIPO,REFEMPRESA) VALUES (@FECHAEMISION,@COBRADO,@EMITIDO,@REFCITA," & _
                    "@REFFACTURA, @Importe, @REFPACIENTE, @FECHAVENCIMIENTO, @Nombre, @DIRECCION, @NOTAS,@CUENTABANCO,@ENTIDAD,@OFICINA,@DC,@CUENTA,@CONCEPTO," & _
                    "@FECHACOBRO,@N19,@REFFORMAPAGO,@TIPO,@REFEMPRESA)"

                End If
                For i = 0 To Me.tb_Recibos.Rows.Count - 1
                    With tb_Recibos.Rows(i)
                        sqlparam(0) = New SqlParameter("@FECHAEMISION", .Item("FECHAEMISION"))
                        sqlparam(1) = New SqlParameter("@COBRADO", .Item("COBRADO"))
                        sqlparam(2) = New SqlParameter("@EMITIDO", .Item("EMITIDO"))
                        sqlparam(3) = New SqlParameter("@REFCITA", .Item("REFCITA"))
                        sqlparam(4) = New SqlParameter("@REFFACTURA", .Item("REFFACTURA"))
                        sqlparam(5) = New SqlParameter("@IMPORTE", .Item("IMPORTE"))
                        sqlparam(6) = New SqlParameter("@REFPACIENTE", .Item("REFPACIENTE"))
                        sqlparam(7) = New SqlParameter("@FECHAVENCIMIENTO", .Item("FECHAVENCIMIENTO"))
                        sqlparam(8) = New SqlParameter("@NOMBRE", .Item("NOMBRE"))
                        sqlparam(9) = New SqlParameter("@DIRECCION", .Item("DIRECCION"))
                        sqlparam(10) = New SqlParameter("@NOTAS", .Item("NOTAS"))
                        sqlparam(11) = New SqlParameter("@CUENTABANCO", .Item("CUENTABANCO"))
                        sqlparam(12) = New SqlParameter("@ENTIDAD", .Item("ENTIDAD"))
                        sqlparam(13) = New SqlParameter("@OFICINA", .Item("OFICINA"))
                        sqlparam(14) = New SqlParameter("@DC", .Item("DC"))
                        sqlparam(15) = New SqlParameter("@CUENTA", .Item("CUENTA"))
                        sqlparam(16) = New SqlParameter("@CONCEPTO", .Item("CONCEPTO"))
                        sqlparam(17) = New SqlParameter("@FECHACOBRO", .Item("FECHACOBRO"))
                        sqlparam(18) = New SqlParameter("@N19", .Item("N19"))
                        sqlparam(19) = New SqlParameter("@REFFORMAPAGO", .Item("REFFORMAPAGO"))
                        sqlparam(20) = New SqlParameter("@TIPO", .Item("TIPO"))
                        sqlparam(21) = New SqlParameter("@REFEMPRESA", .Item("REFEMPRESA"))
                    End With
                    res = SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlparam)
                    Debug.Print(res)
                Next

                'adaptRec.Update(tb_Recibos)


            End If
        Catch ex As Exception
            Globales.ShowError("Error al guardar los documentos generados.", ex)
        End Try
    End Sub
    Private Sub bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Aceptar.Click
        GuardarCambios()
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub lblSeleccionarTodos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSeleccionarTodos.LinkClicked
        Dim i As Integer = 0
        For i = 0 To Me.dgv_pac.Rows.Count - 1
            dgv_pac.Rows(i).Cells("Seleccionar").Value = True
        Next
    End Sub


    Private Sub lblDesSeleccionarTodos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblDesseleccionarTodos.LinkClicked
        Dim i As Integer = 0
        For i = 0 To Me.dgv_pac.Rows.Count - 1
            dgv_pac.Rows(i).Cells("Seleccionar").Value = False
        Next
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_pac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_pac.Click
        Try
            'If Me.TabControl1.TabPages.Contains(Me.tbFacturas) Then
            '            Dim frmpac As New form_pacientes("FICHA DE PACIENTE", Enums.Accion.Modificar, Me.dgv_pac.Rows(Me.dgv_pac.SelectedCells(0).RowIndex).Cells("CODIGO").Value)
            Dim frmpac As New formPaciente("FICHA DE PACIENTE", Enums.Accion.Modificar, Me.dgv_pac.Rows(Me.dgv_pac.SelectedCells(0).RowIndex).Cells("CODIGO").Value)
            frmpac.ShowDialog()
            'End If
            'If Me.TabControl1.TabPages.Contains(Me.tbRecibos) Then
            'Dim frmpac As New form_pacientes("FICHA DE PACIENTE", Enums.Accion.Modificar, Me.dgvRecibos.SelectedRows(0).Cells("REFPACIENTE").Value)
            'frmpac.ShowDialog()

            'End If
        Catch EX As Exception
            Globales.ShowError("Error al intentar cargar el paciente.", EX)
        End Try
    End Sub

    Private Sub rb_facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_facturas.CheckedChanged
        If rb_facturas.Checked Then
            Me.GroupBox3.Visible = True
        Else
            Me.GroupBox3.Visible = False
        End If

    End Sub
End Class