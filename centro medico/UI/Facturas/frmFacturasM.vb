Imports centro_medico
Imports System.IO
Imports Janus.Windows
Imports Janus.Windows.GridEX
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes


Public Class frmFacturasM

    Dim ts As New System.Threading.ThreadStart(AddressOf CargarDatos)
    Dim _thread As New System.Threading.Thread(ts)
    Dim _facturas As List(Of FACTURA)

    Dim tsPrint As New System.Threading.ThreadStart(AddressOf CargaDatosImpresion)
    Dim _threadPrint As New System.Threading.Thread(ts)

    Public Context As CMLinqDataContext
    Public IdPacienteToFilter As Nullable(Of Integer) = Nothing
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Factura As FACTURA = Nothing

    Dim listImprimir As New List(Of WRAPPER_FACTURA)

    Private _imprimirSeleccionados As Boolean = False

    Private primeraVezQueCargaElGrid As Boolean = True


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IdPacienteToFilter.HasValue Then
            CtrlPaciente1.ID_PACIENTE = IdPacienteToFilter

        End If
        Me.dtp_FEMISION_fi.Value = DateAdd(DateInterval.Month, -1, Now).Date
        Me.dtp_FEMISION_fi.Checked = True
        Me.dtp_FEMISION_ff.Value = Now
        Me.dtp_FEMISION_ff.Checked = True


        btnFiltrar_Click(Nothing, Nothing)
    End Sub

    Private Sub CargarDatos()
        
        GridEXListado.DataSource = Nothing

        Context = New CMLinqDataContext()
        SERIESBindingSource.DataSource = (From s In Context.SERIES Select s).ToList()

        Dim tmp As IQueryable(Of FACTURA) = (From f In Context.FACTURAs Where f.Eliminado = False Or Not f.Eliminado.HasValue Select f)

        If Not CtrlConceptoFacturable21.ID_ConceptosFra Is Nothing Then
            tmp = (From f In Context.FACTURAs _
                        Join l In Context.LINEASFACTURAs On f.IDFACTURA Equals l.REFFACTURA _
                        Where l.REFCONCEPTO = CtrlConceptoFacturable21.ID_ConceptosFra And f.Eliminado = False _
                        Select f Order By f.FECHA Descending)
        End If

        If IdPacienteToFilter.HasValue Then
            tmp = (From f In tmp Where f.REFPACIENTE = IdPacienteToFilter Select f Order By f.FECHA Descending)
        End If

        If txtNombre.Text <> "" Then
            tmp = tmp.Where(Function(c) c.PACIENTE1.NOMBRE.StartsWith(txtNombre.Text))
        End If

        If txtApellido1.Text <> "" Then
            tmp = (From c In tmp Where c.PACIENTE1.APELLIDO1.StartsWith(txtApellido1.Text) Select c)
        End If
        If txtApellido2.Text <> "" Then
            tmp = (From c In tmp Where c.PACIENTE1.APELLIDO2.StartsWith(txtApellido2.Text) Select c)
        End If
        If txtDni.Text <> "" Then
            tmp = (From c In tmp Where c.PACIENTE1.DNI.StartsWith(txtDni.Text) Select c)
        End If

        _facturas = tmp.ToList()

        

        GridEXListado.BeginInvoke(New BeginInvokeDelegate(AddressOf Filtrar))
    End Sub

    Private Sub Filtrar()
        CtrlPaciente1.Enabled = Not IdPacienteToFilter.HasValue

        If Not IsHandleCreated Then
            Return
        End If

        FACTURABindingSource.DataSource = _facturas
        GridEXListado.DataSource = FACTURABindingSource

        Dim condition As New GridEXFilterCondition()
        condition.LogicalOperator = LogicalOperator.And

        If chb_pacientes.Checked Then
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.Or, _
                               New GridEXFilterCondition(GridEXListado.RootTable.Columns("FACTURAR"), Janus.Windows.GridEX.ConditionOperator.Equal, "P"))
        End If

        If chb_mutuas.Checked Then
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.Or, _
                               New GridEXFilterCondition(GridEXListado.RootTable.Columns("FACTURAR"), Janus.Windows.GridEX.ConditionOperator.Equal, "M"))
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("REFPACIENTE"), Janus.Windows.GridEX.ConditionOperator.Equal, CtrlPaciente1.ID_PACIENTE.Value))
        End If

        If txtNumero.Text <> "" Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("NUMERO"), Janus.Windows.GridEX.ConditionOperator.BeginsWith, txtNumero.Text))
        End If

        If rb_cobradas.Checked Then
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                               New GridEXFilterCondition(GridEXListado.RootTable.Columns("PAGADA"), Janus.Windows.GridEX.ConditionOperator.Equal, "S"))
        End If


        If rb_sincobrar.Checked Then
            condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                               New GridEXFilterCondition(GridEXListado.RootTable.Columns("PAGADA"), Janus.Windows.GridEX.ConditionOperator.Equal, "N"))
        End If

        If dtp_FEMISION_fi.Checked Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("FEMISION"), ConditionOperator.GreaterThanOrEqualTo, New Date(dtp_FEMISION_fi.Value.Year, dtp_FEMISION_fi.Value.Month, dtp_FEMISION_fi.Value.Day, 0, 0, 0)))
        End If

        If dtp_FEMISION_ff.Checked Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("FEMISION"), ConditionOperator.LessThanOrEqualTo, New Date(dtp_FEMISION_ff.Value.Year, dtp_FEMISION_ff.Value.Month, dtp_FEMISION_ff.Value.Day, 23, 59, 59)))
        End If


        If dtp_FCOBRO_fi.Checked Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("FECHACOBRO"), ConditionOperator.GreaterThanOrEqualTo, New Date(dtp_FCOBRO_fi.Value.Year, dtp_FCOBRO_fi.Value.Month, dtp_FCOBRO_fi.Value.Day, 0, 0, 0)))
        End If

        If dtp_FCOBRO_ff.Checked Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("FECHACOBRO"), ConditionOperator.LessThanOrEqualTo, New Date(dtp_FCOBRO_ff.Value.Year, dtp_FCOBRO_ff.Value.Month, dtp_FCOBRO_ff.Value.Day, 23, 59, 59)))
        End If

        If CtrlMutua1.ID_Mutuas.HasValue Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("REFMUTUA"), ConditionOperator.Equal, CtrlMutua1.ID_Mutuas))
        End If

        If CtrlEmpresa1.ID_EMPRESAS.HasValue Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("REFEMPRESA"), ConditionOperator.Equal, CtrlEmpresa1.ID_EMPRESAS))
        End If

        If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
            condition.AddCondition(New GridEXFilterCondition(GridEXListado.RootTable.Columns("REFFORMAPAGO"), ConditionOperator.Equal, CtrlFormaPago21.ID_FORMASPAGO))
        End If

        If Not cmbSeries.CheckedItems Is Nothing Then
            If cmbSeries.CheckedItems.Length > 0 Then
                Dim serieCondition As New GridEXFilterCondition()
                For Each serie As SERIES In cmbSeries.CheckedItems
                    serieCondition.AddCondition(Janus.Windows.GridEX.LogicalOperator.Or, New GridEXFilterCondition(GridEXListado.RootTable.Columns("REFSERIE"), ConditionOperator.BeginsWith, serie.CODIGO))
                Next
                condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, serieCondition)
            End If
        End If

        GridEXListado.RootTable.FilterCondition = Nothing
        GridEXListado.RootTable.FilterCondition = condition
        pnl_Loading.Visible = False
        SetEnabled(True)

        If primeraVezQueCargaElGrid Then
            If GridEXListado.RowCount > 0 Then
                GridEXListado.EnsureVisible(0)
            End If
            primeraVezQueCargaElGrid = False
        End If
    End Sub


    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As New frmFacturasM_ADD()
        frm.Factura = New FACTURA()
        frm.Nuevo = True
        frm.Factura.Eliminado = False
        frm.Factura.IDFACTURA = GetNewFacturaID()

        Dim newContext As New CMLinqDataContext()

        frm.Context = newContext

        If IdPacienteToFilter.HasValue Then
            frm.IDPacienteToFilter = IdPacienteToFilter
            ' frm.CtrlPaciente1.ID_PACIENTE = IDPacienteToFilter
            frm.Factura.REFPACIENTE = IdPacienteToFilter
        End If



        If frm.ShowDialog() = DialogResult.OK Then

            'FACTURABindingSource.EndEdit()            

            newContext.SubmitChanges()
            'Factura = frm.Factura

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Facturas, "FACTURASM", frm.Factura.IDFACTURA, "[" & frm.Factura.NUMERO & "] " & "INSERTADA FACTURA a PACIENTE :" & frm.Factura.PACIENTE)
            CargarDatos()
            Try
                'Dim idFactura As Integer = Factura.IDFACTURA
                'CargarDatos()
                'Dim row As GridEXRow = GridEXListado.GetRows().SingleOrDefault(Function(o) o.DataRow.IDFACTURA = idFactura)
                'If Not row Is Nothing Then
                '    GridEXListado.EnsureVisible(row.RowIndex)
                '    GridEXListado.SelectedItems.Add(row.RowIndex)
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

#Region "Private Function GetNewFacturaID() As Integer"
    Private Function GetNewFacturaID() As Integer
        Dim facturas As List(Of FACTURA) = (From f In Context.FACTURAs Select f).ToList()
        If facturas.Count = 0 Then
            Return 1
        Else
            Return facturas.Max(Function(t) t.IDFACTURA) + 1
        End If
    End Function
#End Region


    Private Sub GridEXListado_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXListado.RowDoubleClick
        tst_Editar_Click(Nothing, Nothing)
    End Sub

    Private Sub GridEXListado_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXListado.SelectionChanged
        tst_Editar.Enabled = GridEXListado.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEXListado.SelectedItems.Count > 0
        tsDuplicarFactura.Enabled = GridEXListado.SelectedItems.Count > 0
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        If GridEXListado.SelectedItems.Count > 0 And GridEXListado.SelectedItems(0).RowType = RowType.Record Then
            Me.Factura = GridEXListado.SelectedItems(0).GetRow().DataRow
            If Modo = Globales.ModoParaFormas.Edicion Then

                Dim context As New CMLinqDataContext()
                Dim fact As FACTURA = (From f As FACTURA In context.FACTURAs Where f.IDFACTURA = Factura.IDFACTURA Select f).SingleOrDefault


                Dim frm As New frmFacturasM_ADD()
                frm.Factura = fact
                frm.Context = context

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Facturas, "FACTURASM", frm.Factura.IDFACTURA, "[" & Factura.NUMERO & "] " & "FACTURA PACIENTE :" & frm.Factura.PACIENTE)
                If frm.ShowDialog() = DialogResult.OK Then
                    context.SubmitChanges()
                    CargarDatos()

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Facturas, "FACTURASM", frm.Factura.IDFACTURA, "[" & Factura.NUMERO & "] " & "FACTURA PACIENTE :" & frm.Factura.PACIENTE)
                Else
                    'FACTURABindingSource.ResetCurrentItem()

                    'Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Factura)
                    'GridEXListado.Refresh()
                    CargarDatos()
                End If
            Else
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        If MessageBox.Show("¿Está seguro que desea eliminar esta factura?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            If GridEXListado.SelectedItems.Count > 0 Then
                Dim factura As FACTURA = GridEXListado.SelectedItems(0).GetRow().DataRow

                If Not factura Is Nothing Then

                    Dim cont As New CMLinqDataContext()
                    Dim fact As FACTURA = (From f In cont.FACTURAs Where f.IDFACTURA = factura.IDFACTURA Select f).SingleOrDefault()
                    'Context.FACTURAs.DeleteOnSubmit(factura)



                    'Buscar pagos

                    Dim entregascuenta As List(Of EntregasCuenta) = (From en In cont.EntregasCuentas _
                                                                    Where en.CodDocumento = fact.IDFACTURA And en.Eliminado = False _
                                                                    Select en).ToList()

                    Dim listacitas As List(Of CITA) = (From c In cont.CITAs Where c.REFFRA = fact.IDFACTURA Select c).ToList
                    Dim txtaviso As String = ""

                    If entregascuenta.Count > 0 Then
                        txtaviso = "La factura contiene pagos y se eliminarán. "
                    End If

                    If Not listacitas Is Nothing AndAlso listacitas.Count > 0 Then
                        txtaviso = txtaviso & "Las citas vinculadas se desviculan. "
                    End If

                    If txtaviso.Length > 0 Then
                        txtaviso = txtaviso & " ¿Desea continuar?"
                    End If

                    Dim resContinuar As MsgBoxResult = MsgBox(txtaviso, MsgBoxStyle.YesNo)
                    If resContinuar = MsgBoxResult.Yes Then
                        'desvincular citas.
                        For Each l As CITA In listacitas
                            l.REFFRA = Nothing
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, _
                                                   RoleManager.Items.Citas, "Desvincular cita ", l.IDCITA, _
                                       "Desvinculada Factura de cita: " & l.FECHA & " Paciente: " & l.PACIENTE & ". Debido a eliminación de la factura " & fact.NUMERO & " FECHA Factura:" & fact.FECHA.Value.ToString())
                        Next
                        'borrar entregas.
                        For Each entrega As EntregasCuenta In entregascuenta
                            entrega.Eliminado = True
                            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, _
                                                  RoleManager.Items.Facturas, "Eliminar pago", entrega.IDEntregaCuenta, _
                                                  "Eliminado pago (" & entrega.Importe.Value.ToString("c2") & " de factura " & fact.NUMERO & " Fecha: " & fact.FECHA & " Paciente:" & _
                                                  fact.PACIENTE & " debido a eliminación de la factura. ")

                        Next

                        'GridEXListado.Delete()
                        'FACTURABindingSource.EndEdit()
                        fact.Eliminado = True
                        cont.SubmitChanges()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Facturas, "FACTURASM", factura.NUMERO, "[" & factura.NUMERO & "] " & "FACTURA PACIENTE :" & factura.PACIENTE)
                        CargarDatos()
                    Else
                        Return
                    End If
                End If
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Esta factura no puede ser eliminada.")
        End Try

    End Sub






    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click

        pnl_Loading.Visible = True
        lbl_Loading.Text = "Procesando..."
        SetEnabled(False)
        _threadPrint = New Threading.Thread(tsPrint)
        _threadPrint.Start()

    End Sub

    Sub CargaDatosImpresion()

        listImprimir.Clear()

        If _imprimirSeleccionados Then
            For Each row As GridEXRow In GridEXListado.GetCheckedRows()
                If row.IsVisible Then
                    Dim factura As FACTURA = row.DataRow
                    listImprimir.Add(New WRAPPER_FACTURA(factura))
                End If
            Next
        Else
            Try

                For Each row As GridEXRow In GridEXListado.GetRows()
                    If row.RowType = RowType.Record Then
                        If row.IsVisible Then
                            Try
                                Dim factura As FACTURA = row.DataRow
                                listImprimir.Add(New WRAPPER_FACTURA(factura))
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                        End If
                    End If
                Next
            Catch ex As Exception

            End Try

        End If




        GridEXListado.BeginInvoke(New BeginInvokeDelegate(AddressOf Imprime))
    End Sub

    Private Sub Imprime()
        'Datasources
        Dim dsFactura As New Microsoft.Reporting.WinForms.ReportDataSource
        dsFactura.Name = "dsFactura"
        dsFactura.Value = listImprimir



        ReportesManager.Imprime("FacturasListado.rdlc", {dsFactura}, Nothing)


        SetEnabled(True)
        pnl_Loading.Visible = False
        lbl_Loading.Text = "Filtrando..."
        _imprimirSeleccionados = False
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        pnl_Loading.Visible = True
        SetEnabled(False)
        _thread = New Threading.Thread(ts)
        _thread.Start()

        'Filtrar()
    End Sub

    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
    End Sub


    Delegate Sub BeginInvokeDelegate()



    Private Sub GridEXListado_LoadingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXListado.LoadingRow

        If e.Row.RowType = RowType.Record Then
            Dim factura As FACTURA = e.Row.DataRow
            If Not factura Is Nothing Then
                If Not factura.REFFORMAPAGO Is Nothing Then
                    Dim formapago As FORMASPAGO = factura.FORMASPAGO
                    e.Row.Cells("FORMASPAGO").Text = formapago.DESCRIPCION
                End If
            End If


        End If

    End Sub

    Private Sub tsDuplicarFactura_Click(sender As System.Object, e As System.EventArgs) Handles tsDuplicarFactura.Click
        Me.Factura = GridEXListado.SelectedItems(0).GetRow().DataRow

        Dim newFactura As New FACTURA()
        newFactura.CP = Factura.CP
        newFactura.Descuento = Factura.Descuento
        newFactura.DIAGNOSTICO = Factura.DIAGNOSTICO
        newFactura.DIRECCION = Factura.DIRECCION
        newFactura.DNI = Factura.DNI
        newFactura.EMPRESA = Factura.EMPRESA
        newFactura.EMPRESA1 = Factura.EMPRESA1
        newFactura.FACCIDENTE = Factura.FACCIDENTE

        newFactura.FACTURAR = Factura.FACTURAR
        newFactura.FALTA = Factura.FALTA
        newFactura.FBAJA = Factura.FBAJA
        newFactura.FECHA = Factura.FECHA
        'newFactura.FECHACOBRO = Factura.FECHACOBRO
        newFactura.FEMISION = Factura.FEMISION
        newFactura.FORMASPAGO = Factura.FORMASPAGO
        newFactura.HISTORIAL = Factura.HISTORIAL


        newFactura.HORA = Factura.HORA
        newFactura.ID_Proceso = Factura.ID_Proceso
        newFactura.IRPF = Factura.IRPF

        For Each linFact As LINEASFACTURA In Factura.LINEASFACTURAs
            Dim newLinF As LINEASFACTURA = New LINEASFACTURA()
            newLinF.CONCEPTO = linFact.CONCEPTO
            newLinF.IMPORTE = linFact.IMPORTE
            newLinF.REFCONCEPTO = linFact.REFCONCEPTO
            newLinF.CANTIDAD = linFact.CANTIDAD
            newLinF.TIPOIVA = linFact.TIPOIVA
            newLinF.ID_Cita = linFact.ID_Cita
            newLinF.Descuento = linFact.Descuento
            newLinF.ImporteOriginal = linFact.ImporteOriginal
            newLinF.RefLineaCita = linFact.RefLineaCita

            newFactura.LINEASFACTURAs.Add(newLinF)
        Next

        newFactura.LOCALIDAD = Factura.LOCALIDAD
        newFactura.MUTUA = Factura.MUTUA

        newFactura.MUTUA = Factura.MUTUA
        newFactura.MUTUA1 = Factura.MUTUA1
        newFactura.NUMERO = Factura.NUMERO
        newFactura.N19 = Factura.N19

        newFactura.PACIENTE = Factura.PACIENTE
        newFactura.PACIENTE1 = Factura.PACIENTE1
        'newFactura.REFPACIENTE = Factura.REFPACIENTE

        'newFactura.PAGADA = Factura.PAGADA

        newFactura.PORCENTAJEIRPF = Factura.PORCENTAJEIRPF

        newFactura.PROVINCIA = Factura.PROVINCIA
        newFactura.RECIBO = Factura.RECIBO
        'newFactura.REFRECIBO = Factura.REFRECIBO
        'newFactura.REFSERIE = Factura.REFSERIE

        newFactura.SERIES = Factura.SERIES
        newFactura.TIPOIVA = Factura.TIPOIVA
        newFactura.TOTAL = Factura.TOTAL

        Dim frm As New frmFacturasM_ADD()
        frm.Factura = newFactura
        'frm.Nuevo = True
        frm.Factura.IDFACTURA = GetNewFacturaID()
        frm.Factura.NUMEROFACTURA = frm.Factura.IDFACTURA
        frm.Context = Context
        frm.Factura.NUMERO = Number(Factura.SERIES)

        If IDPacienteToFilter.HasValue Then
            frm.IDPacienteToFilter = Factura.REFPACIENTE
            ' frm.CtrlPaciente1.ID_PACIENTE = IDPacienteToFilter
            'frm.Factura.REFPACIENTE = Factura.REFPACIENTE
        End If

        'Try
        ' If Not Context.FACTURAs.Contains(frm.Factura) Then
        '' Context.FACTURAs.InsertOnSubmit(frm.Factura)
        'End If
        'Catch ex As Exception

        'End Try

        If frm.ShowDialog() = DialogResult.OK Then

            'FACTURABindingSource.EndEdit()
            If Not Context.FACTURAs.Contains(frm.Factura) Then
                Context.FACTURAs.InsertOnSubmit(frm.Factura)
            End If

            Context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Facturas, "FACTURASM", frm.Factura.IDFACTURA, "[" & Factura.NUMERO & "] " & "FACTURA PACIENTE :" & frm.Factura.PACIENTE)
        End If
        CargarDatos()
    End Sub



#Region "Private Function Number(ByVal acod As String) As String"
    Private Function Number(ByVal serie As SERIES) As String
        If Not serie Is Nothing Then
            'Dim serie As SERIES = (From s In context.SERIES Where s.CODIGO = acod Select s).SingleOrDefault
            Dim generado As Boolean = False
            Dim _result As String

            Do
                _result = serie.CODIGO
                Dim _cant As String = (serie.CONTADOR + 1).ToString()
                'serie.CONTADOR += 1
                'context.SubmitChanges()

                Dim _digits As Integer = _cant.Length
                Dim i As Integer

                For i = 0 To 5 - _digits
                    _result = _result + "0"
                Next
                _result = _result + _cant

                generado = Not ChequeaSiExisteNumero(_result)
                If Not generado Then
                    'Incrementar el numero de la serie
                    serie.CONTADOR += 1
                    'Context.SubmitChanges()
                    'End If
                End If

            Loop Until generado

            Return _result

        End If
        Return ""
    End Function

    Private Function ChequeaSiExisteNumero(ByVal numero As String) As Boolean
        Try
            Dim fac As FACTURA = (From f In Context.FACTURAs _
                                  Where f.NUMERO = numero And f.IDFACTURA <> Factura.IDFACTURA and f.Eliminado = false
                           Select f).SingleOrDefault
            If fac Is Nothing Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function
#End Region

    Private Sub tbImprimirSeleccionados_Click(sender As System.Object, e As System.EventArgs) Handles tbImprimirSeleccionados.Click

        Try
            If GridEXListado.GetCheckedRows().Count = 0 Then
                MessageBox.Show("No hay facturas seleccionadas")
                Return
            End If

            Dim dialog As New PrintDialog()
            'dialog.Document = printDoc

            If dialog.ShowDialog() = DialogResult.OK Then
                For Each row As GridEXRow In GridEXListado.GetCheckedRows()
                    If row.IsVisible Then
                        Dim _factura As FACTURA = row.DataRow
                        Dim reporte = GeneraReporteFactura(_factura)
                        If reporte Is Nothing Then
                            Return
                        End If
                        Dim printer As New GoltraTools.MultipleReportPrinter
                        printer.Impresora = dialog.PrinterSettings
                        printer.Run(reporte)
                    End If
                Next
            End If

            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        

    
        SetEnabled(True)
        pnl_Loading.Visible = False
        lbl_Loading.Text = "Filtrando..."

    End Sub

#Region "Private Function GeneraReporteFactura(ByRef factura As FACTURA) As LocalReport"
    Private Function GeneraReporteFactura(ByRef factura As FACTURA) As LocalReport
        'Datasources

        Dim listImprimir As New List(Of WRAPPER_FACTURA)


        Dim dsFactura As New Microsoft.Reporting.WinForms.ReportDataSource
        dsFactura.Name = "dsFactura"

        listImprimir.Add(New WRAPPER_FACTURA(factura))
        dsFactura.Value = listImprimir


        Dim localReport As New LocalReport()

        'AddHandler localReport.SubreportProcessing, AddressOf DemoSubreportProcessingEventHandler

        If factura.FACTURAR = "M" Then

            localReport.ReportPath = Globales.Reportes("FacturaMutua.rdlc").Fichero
        Else
            localReport.ReportPath = Globales.Reportes("Factura.rdlc").Fichero
        End If

        If Not File.Exists(localReport.ReportPath) Then
            MessageBox.Show("No se encuentra el fichero: " & Path.GetFileName(localReport.ReportPath))
            Return Nothing
        End If

        Dim dsFacturas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsFacturasLineas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsDesglose As New Microsoft.Reporting.WinForms.ReportDataSource

        dsFacturas.Name = "dsFactura"
        dsFacturasLineas.Name = "dsLineas"
        dsPaciente.Name = "dsPacientes"
        dsDesglose.Name = "dsDesglose"

        Dim listFactura As New List(Of WRAPPER_FACTURA)
        listFactura.Add(New WRAPPER_FACTURA(factura))
        Dim listPaciente As New List(Of PACIENTE)
        listPaciente.Add(factura.PACIENTE1)

        dsFacturas.Value = listFactura
        dsFacturasLineas.Value = factura.LINEASFACTURAs
        dsPaciente.Value = listPaciente

        Dim hash As New Hashtable()
        Dim listaDesglosesIva As New List(Of DESGLOSEIVAS)

        For Each linea As LINEASFACTURA In factura.LINEASFACTURAs
            If hash(linea.TIPOIVA) Is Nothing Then
                Dim desglose As New DESGLOSEIVAS()
                desglose.TIPOIVA = linea.TIPOIVA
                desglose.BASE = (linea.IMPORTE) / ((1) + (linea.TIPOIVA / 100))
                desglose.IMPORTE = linea.IMPORTE - desglose.BASE
                hash(linea.TIPOIVA) = desglose
            Else
                Dim desglose As DESGLOSEIVAS = hash(linea.TIPOIVA)
                Dim base As Double = ((linea.IMPORTE) / ((1) + (linea.TIPOIVA / 100)))
                desglose.BASE += base
                desglose.IMPORTE += (linea.IMPORTE - base)
            End If
        Next

        For Each key As Object In hash.Keys
            Dim desglose As DESGLOSEIVAS = hash(key)
            listaDesglosesIva.Add(desglose)
        Next

        dsDesglose.Value = listaDesglosesIva


        'Parametros
        Dim _params_list As List(Of Microsoft.Reporting.WinForms.ReportParameter) = New List(Of ReportParameter)

        Dim _LetraDni As String = Globales.GetLetter(factura.DNI)
        _params_list.Add(New ReportParameter("params_LetraDNI", _LetraDni))

        localReport.DataSources.Add(dsFacturas)
        localReport.DataSources.Add(dsFacturasLineas)
        localReport.DataSources.Add(dsPaciente)
        localReport.DataSources.Add(dsDesglose)
        localReport.DataSources.Add(Globales.DameDatosClinicaReportDatasource())
        localReport.DisplayName = "Factura de paciente " & factura.PACIENTE & " Fecha: " & factura.FECHA.Value.ToShortDateString

        If factura.FACTURAR = "M" Then
            'Agregar la mutua como datasource

            If Not factura.MUTUA1 Is Nothing Then
                Dim dsMutuas As New Microsoft.Reporting.WinForms.ReportDataSource
                dsMutuas.Name = "dsMutuas"

                Dim mutua As MUTUA = (From m In Context.MUTUAs Where m.CMUTUA = CtrlMutua1.ID_Mutuas).SingleOrDefault
                Dim listMutua As New List(Of MUTUA)
                listMutua.Add(factura.MUTUA1)
                dsMutuas.Value = listMutua
                localReport.DataSources.Add(dsMutuas)
            End If
        End If
        Return localReport

    End Function
#End Region

    

   
End Class
