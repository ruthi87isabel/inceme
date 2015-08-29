Public Class frmCita_Add

    Public CITA As CMDataSet.CITASRow
    Public IDCITA As Integer = -1

    Private recalcularConceptos As Boolean = False
    Private CONCEPTOSFRATableAdapter As New CMDataSetTableAdapters.CONCEPTOSFRATableAdapter()



    Private Sub frmCita_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.CONCEPTOSFACTURABLES' table. You can move, or remove it, as needed.
        Me.CONCEPTOSFACTURABLESTableAdapter.Fill(Me.CMDataSet.CONCEPTOSFACTURABLES)
      
        If IDCITA <> -1 Then
            CargaCita()
        Else
            NuevaCita()
        End If
    End Sub

#Region "NuevaCita()"
    Private Sub NuevaCita()
        'Nueva Cita
        CITA = CITASBindingSource.AddNew().Row()

        CITA.CONFIRMADA = "N"
        CITA.CONTINUA = "N"
        CITA.FALTA = "N"
        CITA.PAGADA = "N"
        CITA.ATENDIDO = "N"
        CITA.IMPORTEDR = 0
        CITA.IMPORTECL = 0

        tb_horafin.Value = tb_horainicio.Value.AddMinutes(Globals.Configuracion.citainterval)
        tb_horafincm.Value = tb_horainiciocm.Value.AddMinutes(Globals.Configuracion.citainterval)

        CMDataSet.CITAS.AddCITASRow(CITA)
    End Sub
#End Region

#Region "Private Sub CargaCita()"
    Private Sub CargaCita()
        'Editar Cita
        Me.CITASTableAdapter.FillByIDCITA(CMDataSet.CITAS, IDCITA)
        If CMDataSet.CITAS.Count = 0 Then
            MessageBox.Show("Cita no encontrada")
            Me.Close()
        End If
        CITA = CMDataSet.CITAS(0)

        CtrlPaciente1.ID_PACIENTE = CITA.REFPACIENTE
        CtrlPaciente1.Enabled = False

        dtp_fecha.Value = CITA.FECHA

        CITA.IMPORTEDR = Double.Parse(tb_dr.Text, Globalization.NumberStyles.Currency)
        CITA.IMPORTECL = Double.Parse(tb_clinica.Text, Globalization.NumberStyles.Currency)

        Me.LineasCitasTableAdapter.FillByIdCita(Me.CMDataSet.LineasCitas, IDCITA)
    End Sub
#End Region

#Region "Eventos CtrlPaciente "
    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        Me.MUTUASTableAdapter.FillByMutuasAsignadasAPaciente(Me.CMDataSet.MUTUAS, IdPaciente)
        chb_aseguradora.Checked = Me.CMDataSet.MUTUAS.Count > 0
        chb_aseguradora.Enabled = Me.CMDataSet.MUTUAS.Count > 0

        CtrlStatusPaciente1.ID_PACIENTE = IdPaciente
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        Me.CMDataSet.MUTUAS.Clear()
        chb_aseguradora.Checked = False
        chb_aseguradora.Enabled = False
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        Me.CMDataSet.MUTUAS.Clear()
        chb_aseguradora.Checked = False
        chb_aseguradora.Enabled = False
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub CtrlPaciente1_PacienteFichaAbierta(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteFichaAbierta
        'Aqui deberia actualizar las mutuas y revisar si cambiaron otros datos que afecten la cita
    End Sub
#End Region

#Region "Guardar()"

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function Guardar() As Boolean
        'Validaciones
        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe entrar un paciente válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CtrlPaciente1.Focus()
            Return False
        End If

        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe entrar un medico válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CtrlMedico1.Focus()
            Return False
        End If

        If tb_horafin.Value <= tb_horainicio.Value Then
            MessageBox.Show("Hora Final no válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tb_horafin.Focus()
            Return False
        End If

        CITASBindingSource.EndEdit()

        'Mutuas
        If chb_aseguradora.Checked Then
            If cb_aseguradora.SelectedIndex <> -1 Then
                CITA.REFPROCEDENCIA = cb_aseguradora.SelectedItem.Row.CMUTUA
            Else
                CITA.SetREFPROCEDENCIANull()
            End If
        Else
            CITA.SetREFPROCEDENCIANull()
        End If

        'Datos

        If Not cb_citaMultiple.Checked Then
            CITA.FECHA = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, 0, 0, 0)
            CITA.HORA = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, tb_horainicio.Value.Hour, tb_horainicio.Value.Minute, 0)
            CITA.HORAFIN = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, tb_horafin.Value.Hour, tb_horafin.Value.Minute, 0)
            CITA.PACIENTE = CtrlPaciente1.NombreCompleto
            CITA.IMPORTEDR = Double.Parse(tb_dr.Text, Globalization.NumberStyles.Currency)
            CITA.IMPORTECL = Double.Parse(tb_clinica.Text, Globalization.NumberStyles.Currency)
        End If

        Dim n As Integer = CITASTableAdapter.Update(CMDataSet.CITAS)

        Return True
    End Function
#End Region

    Private Sub tb_horainicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horainicio.ValueChanged
        'Cita simple
        tb_horafin.Value = tb_horainicio.Value.AddMinutes(Globals.Configuracion.citainterval)
    End Sub

    Private Sub tb_horainiciocm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horainiciocm.ValueChanged
        'Cita Multiple
        tb_horafincm.Value = tb_horainiciocm.Value.AddMinutes(Globals.Configuracion.citainterval)
    End Sub

    Private Sub PAGADAUICheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAGADAUICheckBox.CheckedChanged
        dtp_fechacobro.Enabled = PAGADAUICheckBox.Checked
    End Sub

    Private Sub chb_aseguradora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_aseguradora.CheckedChanged
        cb_aseguradora.Enabled = chb_aseguradora.Checked
    End Sub

    Private Sub cb_citaMultiple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_citaMultiple.CheckedChanged
        GroupBoxFechaSimple.Visible = Not cb_citaMultiple.Checked
        gb_citaMultiple.Visible = cb_citaMultiple.Checked
    End Sub


#Region "Private Sub bt_AddLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AddLinea.Click"

    Private Sub bt_AddLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AddLinea.Click

        'Primero guardar la cita para tener a mano el idCita
        'If Not Guardar() Then
        '    Return
        'End If

        Dim row As CMDataSet.LineasCitasRow = CMDataSet.LineasCitas.NewLineasCitasRow()
        row.IdCita = CITA.IDCITA
        row.Cantidad = 1
        row.ImporteClinica = 0
        row.ImporteDr = 0
        row.DESCRIPCION = ""

        'Gana el foco el campo Articulo de la ultima fila que es la que acabo de añadir.
        If Me.dg_LineasCitas.Rows.Count > 0 Then
            'Me.dg_LineasCitas.ClearSelection()
            'Me.dg_LineasCitas.MultiSelect = False
            'Me.dg_LineasCitas.Focus()
            Me.dg_LineasCitas.Rows.GetLastRow(DataGridViewElementStates.Displayed)
            Me.dg_LineasCitas.Rows(Me.dg_LineasCitas.Rows.Count - 1).Cells("ColRefConcepto").Selected = True
            'Me.dg_LineasCitas.MultiSelect = True
        End If
        'cambios = True

        CMDataSet.LineasCitas.AddLineasCitasRow(row)
    End Sub
#End Region


    Private Sub dg_LineasCitas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellClick
        If e.ColumnIndex = colBuscar.Index Then 'significa que han pulsado en la columna tipo imagen que usamos para busqueda de articulos

            Dim actomedico As New form_listados("Listado de actos médicos", Me.CONCEPTOSFACTURABLESBindingSource, RoleManager.Items.Conceptos_Facturables, True)

            Dim idactomedico As String
            Dim filaConcepto As CMDataSet.CONCEPTOSFRARow

            actomedico.ShowInTaskbar = False
            actomedico.ShowDialog()
            If Not actomedico.Selected Is Nothing Then
                If actomedico.Selected.Trim.Length > 0 Then
                    idactomedico = actomedico.Selected
                    filaConcepto = Me.ObtieneConceptoFacturable(idactomedico)
                    Dim lineacita As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(e.RowIndex).DataBoundItem.Row
                    lineacita.RefConcepto = filaConcepto.CODIGO
                    lineacita.DESCRIPCION = filaConcepto.DESCRIPCION
                    lineacita.ImporteClinica = filaConcepto.IMPORTE
                    'dg_LineasCitas.Rows(e.RowIndex).Cells("colRefConcepto").Value = filaConcepto.CODIGO
                    'dg_LineasCitas.Rows(e.RowIndex).Cells("colDescripcion").Value = filaConcepto.DESCRIPCION
                    'dg_LineasCitas.Rows(e.RowIndex).Cells("colImporteClinica").Value = ObtenImporteConceptoSegunTarifa(filaConcepto.CODIGO, filaConcepto.DESCRIPCION, filaConcepto.IMPORTE)
                    CalculaTotalesCita()
                End If
            End If

        End If
    End Sub

#Region "Private Function ObtieneConceptoFacturable(ByVal idConcepto As String) As CMDataSet.CONCEPTOSFRARow"
    Private Function ObtieneConceptoFacturable(ByVal idConcepto As String) As CMDataSet.CONCEPTOSFRARow

        Dim conceptoTable As CMDataSet.CONCEPTOSFRADataTable = Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(idConcepto)
        If conceptoTable.Count > 0 Then
            Return conceptoTable(0)
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String,Byval descripcion as String, ByVal importeDefecto As Double) As Double"
    Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String, ByVal descripcion As String, ByVal importeDefecto As Double) As Double


        If dg_LineasCitas.Rows.Count = 1 And recalcularConceptos = False And cb_aseguradora.SelectedIndex > -1 And CtrlPaciente1.ID_PACIENTE.HasValue And chb_aseguradora.Checked Then
            If Globals.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                Dim res As DialogResult = MessageBox.Show("Desea recalcular los importes con la tarifa de la mutua seleccionada, si procede?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.Yes Then
                    recalcularConceptos = True
                Else
                    recalcularConceptos = False
                End If
            Else
                'Se recalcula obligatoriamente sin preguntar
                recalcularConceptos = True
            End If
        End If


        'Pasos
        'Obtener la tarifa de la mutua seleccionada si hay una seleccionada

        Dim importe As Double = importeDefecto

        'Verificar si hay una mutua seleccionada

        If chb_aseguradora.Checked Then
            If cb_aseguradora.SelectedIndex > -1 Then
                Dim mutua As CMDataSet.MUTUASRow = cb_aseguradora.SelectedItem.Row

                Dim tarifaAdapter As New CMDataSetTableAdapters.TarifasTableAdapter()
                Dim tarifaTable As New CMDataSet.TarifasDataTable()

                'Si tiene tarifa
                If Not mutua.IsIdTarifaNull() Then
                    'Cargarla
                    tarifaAdapter.FillBy(tarifaTable, mutua.IdTarifa)
                    If (tarifaTable.Count > 0) Then
                        For Each tarifa As CMDataSet.TarifasRow In tarifaTable.Rows
                            If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto And recalcularConceptos Then
                                Return tarifa.Importe
                            End If
                        Next
                    End If
                End If
            End If
        End If
        Return importe
    End Function
#End Region

    Private Sub CalculaTotalesCita()
        Dim i As Integer = 0
        Dim totalmedico As Double = 0
        Dim totalclinica As Double = 0
        Dim total As Double = 0
        dg_LineasCitas.EndEdit()

        For i = 0 To dg_LineasCitas.Rows.Count - 1
            Dim linea As CMDataSet.LineasCitasRow = dg_LineasCitas.Rows(i).DataBoundItem.Row
            totalmedico += linea.Cantidad * linea.ImporteDr
            totalclinica += linea.Cantidad * linea.ImporteClinica
        Next

        total = totalmedico + totalclinica
        Me.tb_clinica.Text = totalclinica.ToString("C2")
        Me.tb_dr.Text = totalmedico.ToString("C2")
        Me.lb_total.Text = total.ToString("C2")
    End Sub


    Private Sub RestauraValoresConceptos()

        For Each row As DataGridViewRow In dg_LineasCitas.Rows
            row.Cells("colImporteClinica").Value = ObtieneConceptoFacturable(row.Cells("colRefConcepto").Value).IMPORTE.ToString("C2")
        Next

    End Sub


    Private Sub dg_LineasCitas_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_LineasCitas.CellLeave
        CalculaTotalesCita()
    End Sub
End Class