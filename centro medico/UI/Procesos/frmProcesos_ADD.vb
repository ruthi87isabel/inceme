Public Class frmProcesos_ADD

    Public ID_Proceso As Integer = -1
    Public Proceso As CM3DataSet.N_ProcesosRow

    Dim partesAdapter As New CM3DataSetTableAdapters.N_PartesTableAdapter()


    Private Sub frmProcesos_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CM3DataSet.N_Partes' table. You can move, or remove it, as needed.
        Me.N_PartesTableAdapter.Fill(Me.CM3DataSet.N_Partes)

        If ID_Proceso <> -1 Then
            N_ProcesosTableAdapter.FillBy(Me.CM3DataSet.N_Procesos, ID_Proceso)
            Proceso = Me.CM3DataSet.N_Procesos(0)

            CargaPartes()
            Me.CITASTableAdapter.FillByProceso(Me.CMDataSet.CITAS, ID_Proceso)
            Me.FACTURASTableAdapter.FillByProceso(Me.CMDataSet.FACTURAS, ID_Proceso)
        Else
            'Nuevo
            Proceso = N_ProcesosBindingSource.AddNew().Row()
            Proceso.FechaInicio = Date.Now
            Proceso.Finalizado = False

        End If
    End Sub

#Region "Private Sub CargaPartes()"
    Private Sub CargaPartes()
        N_PartesPorProcesoTableAdapter.Fill(Me.CM3DataSet.N_PartesPorProceso, ID_Proceso)

        For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetRows()
            If row.RowType = Janus.Windows.GridEX.RowType.Record Then
                Dim parte As CM3DataSet.N_PartesPorProcesoRow = row.DataRow.Row

                If parte.Tipo = Globales.Partes_Tipos.Baja Then
                    row.Cells("Tipo").Text = "BAJA"

                    'Averiguar si es por recaida
                    Dim table As New CM3DataSet.N_PartesDataTable()
                    partesAdapter.FillBy(table, parte.ID)
                    If table.Count > 0 Then
                        If Not table(0).IsRecaidaNull() Then
                            If table(0).Recaida = True Then
                                'Es de baja y con ID_ParteOrigen, entonces es una recaida
                                row.Cells("columnParteRecaida").Image = My.Resources.Recaida

                            End If
                        End If
                    End If
                    ''Averiguar si tiene hijos
                End If

                If parte.Tipo = Globales.Partes_Tipos.Asistencia Then
                    row.Cells("Tipo").Text = "ASISTENCIA"
                End If



            End If
        Next
    End Sub
#End Region


    Private Sub ts_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_Guardar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        Try
            If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
                MessageBox.Show("Debe seleccionar un paciente!")
                CtrlPaciente1.Focus()
                Return False
            End If

            If FechaFinalDateTimePicker.Checked = False Then
                Proceso.SetFechaFinalNull()
            End If



            Me.Validate()
            Me.N_ProcesosBindingSource.EndEdit()
            Me.N_ProcesosTableAdapter.Update(Me.CM3DataSet.N_Procesos)
            ID_Proceso = Proceso.ID_Proceso
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function
#End Region

#Region "Private Sub btn_Cita_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cita_ADD.Click"
    Private Sub btn_Cita_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cita_ADD.Click

        If Guardar() Then
            'If MUTUASComboBox.SelectedIndex = -1 Then
            '    MessageBox.Show("Debe seleccionar una mutua")
            '    Return
            'End If

            Dim frm As New form_citas("Nueva Cita", Enums.Accion.Insertar, Date.Now, Nothing)
            frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
            frm.IdProceso = ID_Proceso
            frm.DesdeFormProceso = True

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.chb_aseguradora.Checked = True
                frm.MutuaPreseleccionada = MUTUASComboBox.SelectedItem.Row
                frm.LLenaCombo(CtrlPaciente1.ID_PACIENTE)
            End If



            frm.ShowDialog()

            Dim citaTable As CMDataSet.CITASDataTable = CITASTableAdapter.GetCitaById(frm.fIdCITA)
            If citaTable.Count > 0 Then
                Dim cita As CMDataSet.CITASRow = citaTable(0)
                cita.ID_Proceso = ID_Proceso
                If MUTUASComboBox.SelectedIndex <> -1 Then
                    cita.REFPROCEDENCIA = MUTUASComboBox.SelectedItem.Row.CMUTUA
                End If
                Dim n As Integer = CITASTableAdapter.Update(cita)
            End If


            Me.CITASTableAdapter.FillByProceso(Me.CMDataSet.CITAS, ID_Proceso)
        End If
    End Sub
#End Region

#Region "Private Sub bt_Partes_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Partes_Add.Click"
    Private Sub bt_Partes_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Partes_Add.Click

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            Return
        End If

        If EMPRESASComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una empresa")
            Return
        End If

        If Guardar() Then
            Dim frm As New frmPartes_ADD()
            frm.ID_Paciente = CtrlPaciente1.ID_PACIENTE
            frm.ID_Empresa = EMPRESASComboBox.SelectedValue
            frm.ID_Proceso = ID_Proceso

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.Mutua = MUTUASComboBox.SelectedItem.Row
            End If

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CargaPartes()
            End If

        End If
    End Sub
#End Region

    Private Sub bt_Partes_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Partes_Edit.Click
        Dim parte As CM3DataSet.N_PartesPorProcesoRow = GridEX1.SelectedItems(0).GetRow.DataRow.Row
        If parte.Tipo = Globales.Partes_Tipos.Alta Or parte.Tipo = Globales.Partes_Tipos.Baja Then
            Dim frm As New frmPartes_ADD()
            frm.ID_Proceso = ID_Proceso
            frm.ID_Parte = parte.ID

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.Mutua = MUTUASComboBox.SelectedItem.Row
            End If

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CargaPartes()
            End If
        Else
            Dim frm As New frmPartesAsistencia_ADD()
            frm.ID_Proceso = ID_Proceso
            frm.ID_Parte = parte.ID

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.Mutua = MUTUASComboBox.SelectedItem.Row
            End If
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CargaPartes()
            End If
        End If
    End Sub

    Private Sub bt_Partes_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Partes_Delete.Click
        'Borrar el parte seleccionado
        If MessageBox.Show("¿Esta seguro que desea eliminar este parte y sus datos relacionados?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim parte As CM3DataSet.N_PartesPorProcesoRow = GridEX1.SelectedItems(0).GetRow.DataRow.Row

            If parte.Tipo < 3 Then
                'Alta
                Dim adapter As New CM3DataSetTableAdapters.N_PartesTableAdapter()
                adapter.DeleteQuery(parte.ID)
            Else
                Dim adapter As New CM3DataSetTableAdapters.N_Partes_AsistenciaTableAdapter()
                adapter.DeleteQuery(parte.ID)
            End If
            CargaPartes()
        End If

    End Sub

    Private Sub N_PartesPorProcesoDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If GridEX1.SelectedItems.Count Then
            bt_Partes_Edit_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_Asistente_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asistente_Facturacion.Click
        If Guardar() Then
            Dim frm As New frmPartes_AsistenteFacturacion()
            frm.ID_Proceso = ID_Proceso
            frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
            frm.CtrlPaciente1.Enabled = False
            If EMPRESASComboBox.SelectedIndex <> -1 Then
                Dim empresaVieja As CMDataSet.EMPRESASRow = EMPRESASComboBox.SelectedItem.Row
                Dim context As New CMLinqDataContext()
                Dim empresa As EMPRESA = (From k In context.EMPRESAs Where k.CEMPRESA = empresaVieja.CEMPRESA Select k).SingleOrDefault
                frm.Empresa = empresa
            End If

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.CtrlMutuaPorPaciente1.ID_Mutuas = MUTUASComboBox.SelectedItem.Row.CMutua
            End If

            frm.ShowDialog()
            Me.FACTURASTableAdapter.FillByProceso(Me.CMDataSet.FACTURAS, ID_Proceso)
            Me.CITASTableAdapter.FillByProceso(Me.CMDataSet.CITAS, ID_Proceso)
        End If
    End Sub



    Private Sub btn_Cita_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cita_Edit.Click

        If Guardar() Then
            Dim cita As CMDataSet.CITASRow = CITASDataGridView.SelectedRows(0).DataBoundItem.Row
            Dim frm As New form_citas("Editar Cita", Enums.Accion.Modificar, cita.IDCITA)
            frm.DesdeFormProceso = True
            frm.ShowDialog()
            Me.CITASTableAdapter.FillByProceso(Me.CMDataSet.CITAS, ID_Proceso)
        End If
    End Sub

    Private Sub btn_Cita_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cita_Eliminar.Click
        Dim cita As CMDataSet.CITASRow = CITASDataGridView.SelectedRows(0).DataBoundItem.Row
        CITASTableAdapter.DeleteCitaById(cita.IDCITA)
        cita.Delete()
        Me.CITASTableAdapter.FillByProceso(Me.CMDataSet.CITAS, ID_Proceso)
    End Sub

    Private Sub btn_Facturas_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Facturas_Add.Click
        btn_Asistente_Facturacion_Click(Nothing, Nothing)
    End Sub


    Private Sub btn_Factura_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Factura_Edit.Click
        Dim factura As CMDataSet.FACTURASRow = FACTURASDataGridView.SelectedRows(0).DataBoundItem.Row
        'Dim frm As New form_factura("Editar Factura", Enums.Accion.Modificar, factura.IDFACTURA)
        'frm.ShowDialog()
        Globales.Factura_Modifica_y_Salva(factura.IDFACTURA)

        Me.FACTURASTableAdapter.FillByProceso(Me.CMDataSet.FACTURAS, ID_Proceso)

    End Sub

    Private Sub btn_Factura_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Factura_Del.Click
        Dim factura As CMDataSet.FACTURASRow = FACTURASDataGridView.SelectedRows(0).DataBoundItem.Row
        FACTURASTableAdapter.DeleteById(factura.IDFACTURA)
        factura.Delete()
        Me.FACTURASTableAdapter.FillByProceso(Me.CMDataSet.FACTURAS, ID_Proceso)
    End Sub

    Private Sub CITASDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CITASDataGridView.SelectionChanged
        btn_Cita_Edit.Enabled = CITASDataGridView.SelectedRows.Count > 0
        btn_Cita_Eliminar.Enabled = CITASDataGridView.SelectedRows.Count > 0

    End Sub

    Private Sub FACTURASDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FACTURASDataGridView.SelectionChanged
        btn_Factura_Edit.Enabled = FACTURASDataGridView.SelectedRows.Count > 0
        btn_Factura_Del.Enabled = FACTURASDataGridView.SelectedRows.Count > 0

    End Sub

    Private Sub CITASDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CITASDataGridView.CellDoubleClick
        If CITASDataGridView.SelectedRows.Count > 0 Then
            btn_Cita_Edit_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FACTURASDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FACTURASDataGridView.CellDoubleClick
        If FACTURASDataGridView.SelectedRows.Count > 0 Then
            btn_Factura_Edit_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        CtrlFicherosAdjuntos1.IDPACIENTE = CtrlPaciente1.ID_PACIENTE
        EMPRESASTableAdapter.FillByPaciente(CMDataSet.EMPRESAS, IdPaciente)
        MUTUASTableAdapter.FillByMutuasAsignadasAPaciente(CMDataSet.MUTUAS, IdPaciente)
        'CtrlMutua1.IDPACIENTE = IdPaciente
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CtrlFicherosAdjuntos1.IDPACIENTE = Nothing
        CMDataSet.EMPRESAS.Clear()
        CMDataSet.MUTUAS.Clear()
        'CtrlMutua1.IDPACIENTE = Nothing
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        CtrlFicherosAdjuntos1.IDPACIENTE = Nothing
        CMDataSet.EMPRESAS.Clear()
        CMDataSet.MUTUAS.Clear()
        'CtrlMutua1.IDPACIENTE = Nothing
    End Sub

    Private Sub CITASDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles CITASDataGridView.CellFormatting
        If e.ColumnIndex = 1 Then
            Dim cita As CMDataSet.CITASRow = CITASDataGridView.Rows(e.RowIndex).DataBoundItem.Row

            Globales.ColoreaCitas(cita.CONFIRMADA, cita.ATENDIDO, cita.FALTA, cita.PAGADA, CITASDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor, CITASDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor)

            If Not cita.IsREFFRANull Then
                CITASDataGridView.Rows(e.RowIndex).Cells(columnCitaFacturada.Index).Value = My.Resources.Facturas
            End If
        End If

    End Sub

    Private Sub btn_ParteAsistencia_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ParteAsistencia_ADD.Click

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            Return
        End If

        If EMPRESASComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una empresa")
            Return
        End If

        If Guardar() Then
            Dim frm As New frmPartesAsistencia_ADD()
            frm.ID_Paciente = CtrlPaciente1.ID_PACIENTE
            frm.ID_Empresa = EMPRESASComboBox.SelectedValue
            frm.ID_Proceso = ID_Proceso

            If MUTUASComboBox.SelectedIndex <> -1 Then
                frm.Mutua = MUTUASComboBox.SelectedItem.Row
            End If

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CargaPartes()
            End If

        End If
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click

        If Guardar() Then

            Dim rdatasourceProcesos As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourceProcesos.Name = "CM3DataSet_N_Procesos"
            rdatasourceProcesos.Value = CM3DataSet.N_Procesos

            Dim rdatasourcePartes As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourcePartes.Name = "CM3DataSet_N_PartesPorProceso"
            rdatasourcePartes.Value = CM3DataSet.N_PartesPorProceso

            Dim rdatasourceCitas As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourceCitas.Name = "CMDataSet_CITAS"
            rdatasourceCitas.Value = CMDataSet.CITAS

            Dim rdatasourceFacturas As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourceFacturas.Name = "CMDataSet_FACTURAS"
            rdatasourceFacturas.Value = CMDataSet.FACTURAS


            'Parametros

            Dim parameters As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("param_NombrePaciente", CtrlPaciente1.NombreCompleto)
            Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("param_CodigoPaciente", CtrlPaciente1.ID_PACIENTE.Value.ToString())

            Dim mutua As String = ""
            If MUTUASComboBox.SelectedIndex <> -1 Then
                mutua = MUTUASComboBox.SelectedItem.Row.Nombre.ToString()
            End If
            Dim empresa As String = ""
            If EMPRESASComboBox.SelectedIndex <> -1 Then
                empresa = EMPRESASComboBox.SelectedItem.Row.Nombre.ToString()
            End If
            Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("param_NombreMutua", mutua)
            Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("param_NombreEmpresa", empresa)

            parameters.Add(p1)
            parameters.Add(p2)
            parameters.Add(p3)
            parameters.Add(p4)


            UI.Reportes.ReportesManager.Imprime("Proceso.rdlc", {rdatasourceProcesos, rdatasourcePartes, rdatasourceCitas, rdatasourceFacturas}, parameters.ToArray)


            
        End If

    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            bt_Partes_Edit_Click(Nothing, Nothing)
        End If
    End Sub

  

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        bt_Partes_Edit.Enabled = GridEX1.SelectedItems.Count > 0
        bt_Partes_Delete.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            Dim parte As CM3DataSet.N_PartesPorProcesoRow = e.Row.DataRow.Row
            If parte.Tipo = 2 Then
                e.Row.Cells("Tipo").Text = "ALTA"
            End If



            'If parte.Tipo = Globals.Partes_Tipos.Baja Then
            '    row.Cells("Tipo").Text = "BAJA"

            '    'Averiguar si es por recaida
            '    Dim table As New CM3DataSet.N_PartesDataTable()
            '    partesAdapter.FillBy(table, parte.ID)
            '    If table.Count > 0 Then
            '        If Not table(0).IsRecaidaNull() Then
            '            If table(0).Recaida = True Then
            '                'Es de baja y con ID_ParteOrigen, entonces es una recaida
            '                row.Cells("columnParteRecaida").Image = My.Resources.Recaida

            '            End If
            '        End If
            '    End If
            '    ''Averiguar si tiene hijos
            '    For Each child As Janus.Windows.GridEX.GridEXRow In row.GetChildRows()
            '        If child.RowType = Janus.Windows.GridEX.RowType.Record Then
            '            child.Cells(2).Text = "ALTA"
            '        End If
            '    Next
            'End If

            'If parte.Tipo = Globals.Partes_Tipos.Asistencia Then
            '    row.Cells("Tipo").Text = "ASISTENCIA"
            'End If

        End If
    End Sub
End Class