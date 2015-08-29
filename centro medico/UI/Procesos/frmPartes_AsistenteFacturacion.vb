Imports Janus.Windows.GridEX
Imports System.Data.Linq

Public Class frmPartes_AsistenteFacturacion

    Public ID_Proceso As Integer = -1

    ' Public LineasCitaAFacturar As New List(Of LineasCita)

    Public Empresa As EMPRESA = Nothing

    Private Context As CMLinqDataContext

    Public CitasFacturadas As New Dictionary(Of Integer, Integer)


    Public IdCitaPreseleccionada As Nullable(Of Integer) = Nothing
    Public GeneraFacturaDirecto As Boolean = False

    Private Sub frmPartes_AsistenteFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_ff.Value = Date.Now
        dtp_fi.Value = dtp_ff.Value.AddMonths(-1)
        CargaDatos()
    End Sub

    Function CargaDatos()

        LINEASFACTURABindingSource.Clear()
        GridEX1.DataSource = Nothing
        'GridLineas.DataSource = Nothing

        Context = New CMLinqDataContext

      
        If CtrlPaciente1.ID_PACIENTE.HasValue Then

            Dim citas As List(Of CITA)

            If IdCitaPreseleccionada.HasValue Then
                citas = (From c In Context.CITAs _
                                Where c.ATENDIDO = "S" _
                                And Not c.REFFRA.HasValue _
                                And c.REFPACIENTE = CtrlPaciente1.ID_PACIENTE _
                                And c.IDCITA = IdCitaPreseleccionada _
                                And c.Eliminado = False
                                Select c).ToList()
            Else
                citas = (From c In Context.CITAs _
                                Where c.ATENDIDO = "S" _
                                And Not c.REFFRA.HasValue _
                                And c.REFPACIENTE = CtrlPaciente1.ID_PACIENTE _
                                And c.Eliminado = False
                                Select c).ToList()
            End If

            CITABindingSource.DataSource = citas
            CtrlMutuaPorPaciente1.IDPACIENTE = CtrlPaciente1.ID_PACIENTE
            If IdCitaPreseleccionada.HasValue Then
                If Not citas Is Nothing AndAlso citas.Count = 1 AndAlso Not citas(0).MUTUA Is Nothing Then _
                    CtrlMutuaPorPaciente1.ID_Mutuas = citas(0).REFPROCEDENCIA
            End If

            GridEX1.DataSource = CITABindingSource

            Filtrar()
            'For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetRows()
            '    If row.RowType = RowType.Record Then
            '        If row.Parent Is Nothing Then
            '            Dim cita As CITA = row.DataRow
            '            Dim formato As New Janus.Windows.GridEX.GridEXFormatStyle()
            '            Globales.ColoreaCitas(cita.CONFIRMADA, cita.ATENDIDO, cita.FALTA, cita.PAGADA, formato.BackColor, formato.ForeColor)
            '            row.RowStyle = formato
            '        End If
            '    End If
            'Next


            If IdCitaPreseleccionada.HasValue Then
                GridEX1.ExpandRecords()
                lnkTodas_LinkClicked(Nothing, Nothing)

                If GeneraFacturaDirecto Then
                    btn_GenerarNuevaFactura_Click(Nothing, Nothing)
                End If
            End If
        End If

       
    End Function

  

    Private Function Compara(ByVal lineaCita As LineasCita, ByVal row As DataGridViewRow)
        Try
            Return row.Cells("ColumnIDLINEACITA").Value = lineaCita.IdLinea

        Catch ex As Exception
            Return False
        End Try

    End Function


    Private Sub BuscaYDesmarca(ByVal row As DataGridViewRow)
        For Each parent As Janus.Windows.GridEX.GridEXRow In GridEX1.GetRows()
            For Each child As Janus.Windows.GridEX.GridEXRow In parent.GetChildRows()
                Dim lineaCita As LineasCita = child.DataRow.Row
                If Compara(lineaCita, row) Then
                    child.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked
                    parent.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked
                End If
            Next
        Next
    End Sub




    Private Sub btn_GenerarNuevaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GenerarNuevaFactura.Click
       
        Try
            GenerarNuevaFactura()


        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al generar Factura")
        End Try
    End Sub

    Private Sub btn_Asignar_a_Factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar_a_Factura.Click
        Try
            AsignarFactura()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al asignar Factura")
        End Try
    End Sub


    Private Sub GenerarNuevaFactura()
        If GridLineas.Rows.Count = 0 Then
            MessageBox.Show("No hay lineas que facturar")
            Return
        End If


        Dim frm As New frmFacturasM_ADD()
        frm.Factura = New FACTURA()
        frm.Nuevo = True
        frm.Factura.IDFACTURA = Globales.ObtenerMaximoValor("FACTURAS", "IDFACTURA") + 1

        'Hay que incrementar el contador de la serie
        'Globales.IncrementaSerie(frm.Factura.se)

        Dim context As New CMLinqDataContext()
        frm.Context = context


        Dim factura As FACTURA = frm.Factura


        factura.MUTUA = ""


        If rbCitasMutuas.Checked Then
            If CtrlMutuaPorPaciente1.ID_Mutuas.HasValue Then
                factura.REFMUTUA = CtrlMutuaPorPaciente1.ID_Mutuas
                If Not CtrlMutuaPorPaciente1.Mutuas.NOMBRE Is Nothing Then
                    factura.MUTUA = CtrlMutuaPorPaciente1.Mutuas.NOMBRE
                End If
            End If
            factura.FACTURAR = "M"
        Else
            factura.FACTURAR = "P"
            factura.REFMUTUA = Nothing
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            factura.REFPACIENTE = CtrlPaciente1.ID_PACIENTE
            factura.PACIENTE = CtrlPaciente1.NombreCompleto
            If Not CtrlPaciente1.Paciente.REFFORMAPAGO Is Nothing Then
                factura.REFFORMAPAGO = CtrlPaciente1.Paciente.REFFORMAPAGO
            End If
        End If


        factura.FECHA = Date.Now
        factura.HORA = Date.Now
        factura.FEMISION = Date.Now


        If ID_Proceso <> -1 Then
            factura.ID_Proceso = ID_Proceso
        End If

        Dim total As Double = 0
        For Each row As DataGridViewRow In GridLineas.Rows

            Dim selectedLinea As LINEASFACTURA = row.DataBoundItem
            Dim lineaFactura As New LINEASFACTURA
            lineaFactura.CANTIDAD = selectedLinea.CANTIDAD
            lineaFactura.CONCEPTO = selectedLinea.CONCEPTO
            lineaFactura.Descuento = selectedLinea.Descuento
            lineaFactura.ID_Cita = selectedLinea.ID_Cita
            lineaFactura.IMPORTE = selectedLinea.IMPORTE
            lineaFactura.ImporteOriginal = selectedLinea.ImporteOriginal
            lineaFactura.REFCONCEPTO = selectedLinea.REFCONCEPTO

            lineaFactura.RefLineaCita = selectedLinea.RefLineaCita
            lineaFactura.TIPOIVA = selectedLinea.TIPOIVA

            lineaFactura.REFFACTURA = factura.IDFACTURA
            'lineaFactura.TIPOIVA = 0
            ' total = total + lineaFactura.IMPORTE
            'lineaFactura.CONCEPTO = lineaFactura.CONCEPTO.Substring(0, Math.Min(lineaFactura.CONCEPTO.Length, 90))
            factura.LINEASFACTURAs.Add(lineaFactura)
        Next

        factura.TOTAL = total 'Hay que calcularlo
        factura.NUMEROFACTURA = factura.IDFACTURA
        factura.PAGADA = "N"


        If IdCitaPreseleccionada.HasValue Then

            Dim cita As CITA = (From c As CITA In context.CITAs Where c.IDCITA = IdCitaPreseleccionada Select c).SingleOrDefault
            If Not cita Is Nothing Then
                If cita.PAGADA = "S" Then
                    factura.PAGADA = "S"
                    factura.FECHACOBRO = Date.Now
                End If
            End If

        End If


        factura.RECIBO = ""
        factura.PORCENTAJEIRPF = 0
        If Not Empresa Is Nothing Then
            factura.REFEMPRESA = Empresa.CEMPRESA
            factura.EMPRESA = Empresa.NOMBRE
        Else
            factura.EMPRESA = ""
            If CtrlPaciente1.Paciente.REFEMPRESA.HasValue Then
                factura.REFEMPRESA = CtrlPaciente1.Paciente.REFEMPRESA
                factura.EMPRESA = CtrlPaciente1.Paciente.NOMBRE
            End If
        End If


        factura.IRPF = 0


        'Datos del paciente

        If Not CtrlPaciente1.Paciente.DNI Is Nothing Then
            factura.DNI = CtrlPaciente1.Paciente.DNI
        End If

        If Not CtrlPaciente1.Paciente.DOMICILIO Is Nothing Then
            factura.DIRECCION = CtrlPaciente1.Paciente.DOMICILIO
        End If

        If Not CtrlPaciente1.Paciente.LOCALIDAD Is Nothing Then
            factura.LOCALIDAD = CtrlPaciente1.Paciente.LOCALIDAD
        End If

        If Not CtrlPaciente1.Paciente.PROVINCIA Is Nothing Then
            factura.PROVINCIA = CtrlPaciente1.Paciente.PROVINCIA
        End If

        If Not CtrlPaciente1.Paciente.CP Is Nothing Then
            factura.CP = CtrlPaciente1.Paciente.CP
        End If


        'Dim context As New CMLinqDataContext()
        'context.FACTURAs.InsertOnSubmit(factura)

        'Desactivar el ctrlStatusPaciente pues podria ocasionar errores de concurrencia
        frm.CtrlStatusPaciente1.Visible = False
        'frm.Nuevo = True
        frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
        frm.cb_pagada.Checked = True
        frm.CargaDatosPaciente()
        frm.FacturadaGeneradaDesdeCita = True

        If frm.ShowDialog() = DialogResult.OK Then

            If Not frm.Context.FACTURAs.Contains(frm.Factura) Then
                frm.Context.FACTURAs.InsertOnSubmit(frm.Factura)
            End If

            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Facturas, "FACTURASM", frm.Factura.IDFACTURA, "[" & factura.NUMERO & "] " & "FACTURA PACIENTE :" & frm.Factura.PACIENTE)


            CambiarCitaAFacturada(frm.Factura.IDFACTURA)
            'Poner la referencia de las lineas de Cita a lineas de Factura

            If GeneraFacturaDirecto Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

            If Not IdCitaPreseleccionada.HasValue Then CargaDatos()
        Else
            If GeneraFacturaDirecto Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        End If
    End Sub

    Private Sub AsignarFactura()
        'Aqui debo escoger una factura para asignarle estas lineas
        If GridLineas.Rows.Count = 0 Then
            MessageBox.Show("No hay lineas que facturar")
            Return
        End If

        Dim frmListado As New frmFacturasM()
        frmListado.IDPacienteToFilter = CtrlPaciente1.ID_PACIENTE
        frmListado.Modo = Globales.ModoParaFormas.Seleccion
        If frmListado.ShowDialog() = DialogResult.OK Then
            For Each row As DataGridViewRow In GridLineas.Rows

                Dim selectedLinea As LINEASFACTURA = row.DataBoundItem
                Dim lineaFactura As New LINEASFACTURA
                lineaFactura.CANTIDAD = selectedLinea.CANTIDAD
                lineaFactura.CONCEPTO = selectedLinea.CONCEPTO
                lineaFactura.Descuento = selectedLinea.Descuento
                lineaFactura.ID_Cita = selectedLinea.ID_Cita
                lineaFactura.IMPORTE = selectedLinea.IMPORTE
                lineaFactura.ImporteOriginal = selectedLinea.ImporteOriginal
                lineaFactura.REFCONCEPTO = selectedLinea.REFCONCEPTO

                lineaFactura.RefLineaCita = selectedLinea.RefLineaCita
                lineaFactura.TIPOIVA = selectedLinea.TIPOIVA

                lineaFactura.REFFACTURA = frmListado.Factura.IDFACTURA

                'linea.CONCEPTO = linea.CONCEPTO.Substring(0, Math.Min(linea.CONCEPTO.Length, 90))
                frmListado.Factura.LINEASFACTURAs.Add(lineaFactura)
            Next

            Dim frmFactura As New frmFacturasM_ADD()
            frmFactura.Factura = frmListado.Factura
            frmFactura.Context = frmListado.Context
            'Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir,
            '                                RoleManager.Items.Facturas, "FACTURASM", frmFactura.Factura.IDFACTURA, "[" & frmFactura.Factura.NUMERO & "] " & "FACTURA PACIENTE :" & frmFactura.Factura.PACIENTE)

            If frmFactura.ShowDialog() = DialogResult.OK Then
                frmFactura.Context.SubmitChanges()
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Facturas, "FACTURASM", frmFactura.Factura.IDFACTURA, "[" & frmFactura.Factura.NUMERO & "] " & "FACTURA PACIENTE :" & frmFactura.Factura.PACIENTE)
                CambiarCitaAFacturada(frmListado.Factura.IDFACTURA)
                CargaDatos()
            End If
        End If
    End Sub

    



    Private Sub ts_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub rbCitas_Paciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCitas_Paciente.CheckedChanged

        If rbCitas_Paciente.Checked Then
            CtrlMutuaPorPaciente1.ID_Mutuas = Nothing
            CtrlMutuaPorPaciente1.Enabled = False
            lbl_SeleccioneMutua.Visible = False
        Else
            CtrlMutuaPorPaciente1.Enabled = True
            CtrlMutuaPorPaciente1.IDPACIENTE = CtrlPaciente1.ID_PACIENTE
        End If



        Filtrar()
        LINEASFACTURABindingSource.Clear()
        GridEX1.UnCheckAllRecords()

    End Sub

#Region "Public Sub Filtrar()"
    Public Sub Filtrar()

        'Return


        lbl_SeleccioneMutua.Visible = Not CtrlMutuaPorPaciente1.ID_Mutuas.HasValue And Not rbCitas_Paciente.Checked

        Dim condition As New GridEXFilterCondition()

        Dim conditionLineas As New GridEXFilterCondition()

        'Dim filtros As New List(Of String)

        If Not Me.IsHandleCreated Then
            Return
        End If

        If chkMostrarCero.Checked Then
            condition.AddCondition(GridEX1.RootTable.StoredFilters("StoredFilterIncluirCero").FilterCondition.Clone())
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("TOTAL"), ConditionOperator.GreaterThan, 0))
        Else
            condition.AddCondition(GridEX1.RootTable.StoredFilters("StoredFilterSinIncluirCero").FilterCondition.Clone())
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("TOTAL"), ConditionOperator.GreaterThanOrEqualTo, 0))
        End If

        If ID_Proceso <> -1 Then
            'filtros.Add(" ID_Proceso=" & ID_Proceso)
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))
        End If

        'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            'filtros.Add(" REFPACIENTE=" & CtrlPaciente1.ID_PACIENTE.Value)
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPACIENTE"), ConditionOperator.Equal, CtrlPaciente1.ID_PACIENTE))
        Else
            'filtros.Add(" REFPACIENTE IS NULL")
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPACIENTE"), ConditionOperator.IsNull, Nothing))
        End If

        If rbCitas_Paciente.Checked Then
            '    filtros.Add(" REFPROCEDENCIA IS NULL OR REFPROCEDENCIA = 0")
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.IsNull Or ConditionOperator.Equal, 0))

        Else
            If CtrlMutuaPorPaciente1.ID_Mutuas.HasValue Then
                'filtros.Add(" REFPROCEDENCIA=" & CtrlMutuaPorPaciente1.ID_Mutuas.Value)
                condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.Equal, CtrlMutuaPorPaciente1.ID_Mutuas.Value))
            Else
                '        filtros.Add(" REFPROCEDENCIA=-1")
                'Esta condicion es para que NO devuelva nada si no hay Mutua Seleccionada
                condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.Equal, -100))
            End If
        End If

        If chk_FechaInicio.Checked Then
            '    filtros.Add("([FECHA] > '" & dtp_fi.Value.ToShortDateString() & "')")
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHA"), ConditionOperator.GreaterThanOrEqualTo, dtp_fi.Value.ToShortDateString()))
        End If

        If chk_Final.Checked Then
            'filtros.Add("([FECHA] < '" & dtp_ff.Value.ToShortDateString() & "')")
            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHA"), ConditionOperator.LessThanOrEqualTo, dtp_ff.Value.ToShortDateString()))
        End If

        'Dim filtro As String = String.Join(" AND ", filtros.ToArray())

        'conditionLineas.AddCondition(LogicalOperator.Or, New GridEXFilterCondition(GridEX1.RootTable.ChildTables("LineasCitas").Columns("FACTURADA"), ConditionOperator.Equal, 0))
        'condition.AddCondition(LogicalOperator.Or, New GridEXFilterCondition(GridEX1.RootTable.ChildTables("LineasCitas").Columns("FACTURADA"), ConditionOperator.Equal, "0").)
        'Dim linea As New LineasCita()

        Try
            'Me.filtro = filter

            'Create the condition

            'Dim condition As New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHA"), ConditionOperator.GreaterThanOrEqualTo, dtp_fi.Value.ToShortDateString())
            GridEX1.RootTable.FilterCondition = condition
            'GridEX1.RootTable.ChildTables("LineasCitas").FilterCondition = conditionLineas


            'Dim dw As DataView = Me.CMDataSet.CITAS.DefaultView
            'dw.RowFilter = filtro
            'dw.RowStateFilter = DataViewRowState.CurrentRows
            ''6GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
            'GridEX1.DataSource = dw
            'GridEX1.Update()

        Catch ex As Exception
            Dim m As String = ex.Message
        End Try

    End Sub
#End Region


    Private Sub chk_FechaInicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FechaInicio.CheckedChanged
        dtp_fi.Enabled = chk_FechaInicio.Checked
        Filtrar()
    End Sub

    Private Sub chk_Final_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Final.CheckedChanged
        dtp_ff.Enabled = chk_Final.Checked
        Filtrar()
    End Sub

    Private Sub dtp_fi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fi.ValueChanged
        Filtrar()
    End Sub

    Private Sub dtp_ff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ff.ValueChanged
        Filtrar()
    End Sub


#Region "Private Sub btn_FacturaSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FacturaSimple.Click"
    Private Sub btn_FacturaSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FacturaSimple.Click

        For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetCheckedRows()
            If row.Parent Is Nothing Then
                'Es la cita,
                Dim cita As CMDataSet.CITASRow = row.DataRow.Row
                For Each childRow As Janus.Windows.GridEX.GridEXRow In row.GetChildRows()
                    If row.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
                        Dim lineaCita As CMDataSet.LineasCitasRow = childRow.DataRow.Row

                    End If
                Next
            End If
        Next

    End Sub
#End Region

    Private Function ExisteLineaCita(ByVal lineaCita As LineasCita)
        For Each row As DataGridViewRow In GridLineas.Rows
            If Not row.DataBoundItem Is Nothing Then
                Dim lineaFactura As LINEASFACTURA = row.DataBoundItem
                If Compara(lineaCita, row) Then Return True
            End If
        Next
        Return False
    End Function

    Private Sub btn_EliminarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarTodas.Click
        LINEASFACTURABindingSource.Clear()

    End Sub

    Private Sub lnkTodas_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTodas.LinkClicked

        GridEX1.CheckAllRecords()
        For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetRows()
            ChequeaRow(row, Janus.Windows.GridEX.RowCheckState.Checked)
        Next

    End Sub

    Private Sub lnkNinguna_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNinguna.LinkClicked
        GridEX1.UnCheckAllRecords()
        For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetRows()
            ChequeaRow(row, Janus.Windows.GridEX.RowCheckState.Unchecked)
        Next
    End Sub


    Private Sub ListadoCitasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        btn_FacturaSimple_Click(Nothing, Nothing)
    End Sub

    Private Sub GridEX1_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEX1.RowCheckStateChanged
        If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
            'If Not e.Row Is Nothing Then
            '    ChequeaRow(e.Row, e.CheckState)
            'End If
            If e.CheckState = RowCheckState.Checked Then
                lnkTodas_LinkClicked(Nothing, Nothing)
            Else
                lnkNinguna_LinkClicked(Nothing, Nothing)
            End If

        Else
            If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.RowChange Then
                ChequeaRow(e.Row, e.CheckState)
            End If
        End If

    End Sub

    Private Sub ChequeaRow(ByVal row As Janus.Windows.GridEX.GridEXRow, ByVal checked As Janus.Windows.GridEX.RowCheckState)
        'row.CheckState = checked
        If row.Table.Key = "LineasCitas" Then
            Dim cita As CITA = row.Parent.DataRow
            Dim linea As LineasCita = row.DataRow
            If checked = Janus.Windows.GridEX.RowCheckState.Checked Then
                If Not CitasFacturadas.ContainsKey(cita.IDCITA) Then
                    CitasFacturadas.Add(cita.IDCITA, cita.IDCITA)
                End If
                AnnadirLineaCita(cita, linea)
            Else
                If CitasFacturadas.ContainsKey(cita.IDCITA) Then
                    CitasFacturadas.Remove(cita.IDCITA)
                End If

                EliminaLineaFactura(linea)
            End If
        End If

        For Each child As Janus.Windows.GridEX.GridEXRow In row.GetChildRows()
            ChequeaRow(child, checked)
        Next
    End Sub


    Private Sub AnnadirLineaCita(ByVal cita As CITA, ByVal lineaCita As LineasCita)
        If Not ExisteLineaCita(lineaCita) Then

            Dim lineaFactura As New LINEASFACTURA()
            lineaFactura.CANTIDAD = lineaCita.Cantidad
            If Not lineaCita.RefConcepto Is Nothing Then
                lineaFactura.REFCONCEPTO = lineaCita.RefConcepto
            Else
                lineaFactura.REFCONCEPTO = Nothing
            End If
            lineaFactura.CONCEPTO = cita.FECHA.Value.ToShortDateString() & " - " & lineaCita.DESCRIPCION
            lineaFactura.CANTIDAD = lineaCita.Cantidad

            lineaFactura.ImporteOriginal = (lineaCita.ImporteClinica + lineaCita.ImporteDr) * lineaCita.Cantidad
            lineaFactura.IMPORTE = lineaFactura.ImporteOriginal - lineaCita.DescuentoPercent / 100 * lineaFactura.ImporteOriginal
            lineaFactura.ID_Cita = lineaCita.IdCita
            lineaFactura.RefLineaCita = lineaCita.IdLinea

            If Not lineaCita.DescuentoPercent Is Nothing Then
                lineaFactura.Descuento = lineaCita.DescuentoPercent / 100 * lineaFactura.ImporteOriginal
            Else
                lineaFactura.Descuento = 0
            End If

            'If lineaCita.CITA.PAGADA = "S" Then
            '    lineaFactura.CONCEPTO = "Importe liquidado en la cita del " & lineaCita.CITA.FECHA.Value.ToShortDateString() & " a las " & lineaCita.CITA.HORA.Value.ToShortTimeString() & "." & lineaCita.DESCRIPCION
            '    'lineaFactura.IMPORTE = 0
            '    'lineaFactura.ImporteOriginal = 0

            'End If

            Dim pos As Integer = LINEASFACTURABindingSource.Add(lineaFactura)

            Dim row As DataGridViewRow = GridLineas.Rows(pos)
            row.Cells("ColumnIDLINEACITA").Value = lineaCita.IdLinea

            'lineaCita.LINEASFACTURA = lineaFactura
           
        End If
    End Sub

    Private Sub EliminaLineaFactura(ByVal lineaCita As LineasCita)
        Dim rowToDelete As DataGridViewRow = Nothing
        For Each row As DataGridViewRow In GridLineas.Rows
            Dim lineaFactura As LINEASFACTURA = row.DataBoundItem
            If Compara(lineaCita, row) Then
                GridLineas.Rows.Remove(row)
            End If

        Next


        'Dim row As GridEXRow = GridEXLineasFactura.GetRow()
    End Sub

    Private Sub CambiarCitaAFacturada(ByVal idFactura)
        For Each IdCita As Integer In CitasFacturadas.Keys
            Dim cita As CITA = (From c In Context.CITAs Where c.IDCITA = IdCita Select c).SingleOrDefault
            If Not cita Is Nothing Then
                cita.REFFRA = idFactura
                Context.SubmitChanges()
                If Not CitasFacturadas.Keys.Contains(cita.IDCITA) Then
                    CitasFacturadas.Add(cita.IDCITA, cita.IDCITA)
                End If
            End If
        Next
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CtrlMutuaPorPaciente1.IDPACIENTE = Nothing
        Filtrar()
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        Filtrar()
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionadoByBrowser(IdPaciente As Integer) Handles CtrlPaciente1.PacienteSeleccionadoByBrowser
        CargaDatos()
    End Sub
  
    'Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
    '    CargaPaciente()
    'End Sub

    Private Sub CtrlPaciente1_PacienteFichaAbierta(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteFichaAbierta
        CargaDatos()
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionadoDeNuevo(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteSeleccionadoDeNuevo
        CargaDatos()
    End Sub


    Private Sub CtrlMutuaPorPaciente1_MutuasSeleccionado_1(ByVal IdMutuas As System.Int32) Handles CtrlMutuaPorPaciente1.MutuasSeleccionado
        Filtrar()
    End Sub


    Private Sub chkMostrarCero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarCero.CheckedChanged
        Filtrar()
    End Sub


    Private Sub frmPartes_AsistenteFacturacion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If IdCitaPreseleccionada.HasValue Then
            GridEX1.ExpandRecords()
            lnkTodas_LinkClicked(Nothing, Nothing)
        End If
    End Sub

    
End Class