Imports Janus.Windows.GridEX

Public Class frmCita_ImportarLineas

    Public ID_PACIENTE As Integer
    Public ListaTratamientos As New List(Of LCOMPARATIVAS_TRATAMIENTO)
    Public ListaLineasPresupuesto As New List(Of d_PresupuestoLinea)

    Private Sub frmCita_ImportarLineas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TabDental.Visible = Globales.Configuracion.Dental_ModuloActivo
        CargarLineas(ID_PACIENTE)
        Filtrar()
    End Sub
    Private Function filtroPorCitas() As GridEXFilterCondition
        Dim condition1 As New GridEXFilterCondition(GridEXDentales.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").Columns("idCita"), _
                                                    ConditionOperator.IsNull, True)
        Return condition1
    End Function
    Private Sub FiltraPorEstados()
        'If Me.chkConfirmado.Checked Then
        Dim condition1 As New GridEXFilterCondition(GridEXDentales.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").Columns("Confirmado"), _
                                                    ConditionOperator.Equal, Me.chkConfirmado.Checked)
        condition1.AddCondition(LogicalOperator.And, _
                                New GridEXFilterCondition(GridEXDentales.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").Columns("Realizado"), ConditionOperator.Equal, Me.chkRealizado.Checked))
        condition1.AddCondition(LogicalOperator.And, filtroPorCitas)
        Me.GridEXDentales.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").FilterCondition = condition1
        'End If
    End Sub
    Public Sub CargarLineas(ByVal idPaciente As Integer)
        'Cargar lineas de Dental

        'Cargar lineas de Revision Comparativa
        Dim context As New CMLinqDataContext

        Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = idPaciente Select p).SingleOrDefault

        PACIENTEBindingSource.DataSource = paciente

        GridEXRevisiones.ExpandRecords()
        GridEXDentales.ExpandRecords()

        'Dim cantRegulares As Integer = GridEXRevisiones.RecordCount
        'If cantRegulares > 0 Then
        '    TabRevisionesComparativas.Text = "Revisiones comparativas (" & cantRegulares & ")"
        '    'TabDental.seFont.Bold = True
        'End If

        'Dim cantDentales As Integer = GridEXDentales.RecordCount
        'If cantDentales > 0 Then
        '    TabDental.Text = "Presupuestos Dentales (" & cantDentales & ")"
        '    'TabDental.seFont.Bold = True
        'End If


        'El filtrado se hace en el Grid

    End Sub

    Private Sub GridEXDocs_RowCheckStateChanged(sender As System.Object, e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXRevisiones.RowCheckStateChanged
        'Bien si se marco un tratamiento annadirlo al grid2
        'If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
        '    If TypeOf e.Row.DataRow Is LCOMPARATIVAS_TRATAMIENTO Then
        '        MessageBox.Show("yeah")
        '    End If
        'End If
        'ChequeaMarcados()
    End Sub

    Private Sub Filtrar()

        'Dim condition1 As New GridEXFilterCondition(GridEXRevisiones.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").Columns("Confirmado"), _
        '                                            ConditionOperator.Equal, True)
        'Dim condition2 As New GridEXFilterCondition(GridEXRevisiones.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").Columns("IDCITA"), _
        '                                                  ConditionOperator.IsNull, Nothing)
        ''condition1.AddCondition(condition2)

        'Dim condition As New GridEXFilterCondition()
        'condition.LogicalOperator = LogicalOperator.And
        ''condition1.AddCondition(LogicalOperator.And, condition2)

        'condition.AddCondition(LogicalOperator.And, condition1)
        'condition.AddCondition(LogicalOperator.And, condition2)

        ''Dim conditionDental As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").StoredFilters("StoredFilter_Dental").FilterCondition
        ''conditionDental.LogicalOperator = LogicalOperator.And
        ''conditionDental.AddCondition(condicionDental2)

        'GridEXRevisiones.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").FilterParentRows = False
        'GridEXRevisiones.RootTable.ChildTables("d_Odontogramas").ChildTables("d_Presupuestos").ChildTables("d_PresupuestoLineas").FilterCondition = condition

    End Sub


    Public Sub ChequeaMarcados()

        ListaTratamientos.Clear()
        ListaLineasPresupuesto.Clear()

        For Each row As GridEXRow In GridEXRevisiones.GetCheckedRows
            If row.RowType = RowType.Record Then
                If TypeOf row.DataRow Is LCOMPARATIVAS_TRATAMIENTO Then
                    ListaTratamientos.Add(row.DataRow)
                End If


            End If
        Next

        For Each row As GridEXRow In GridEXDentales.GetCheckedRows
            If row.RowType = RowType.Record Then
                If TypeOf row.DataRow Is d_PresupuestoLinea Then
                    ListaLineasPresupuesto.Add(row.DataRow)
                End If
            End If
        Next
    End Sub


    Private Sub btnImportar_Click(sender As System.Object, e As System.EventArgs) Handles btnImportar.Click
        If GridEXRevisiones.GetCheckedRows.Count = 0 And GridEXDentales.GetCheckedRows.Count = 0 Then
            MessageBox.Show("No hay documentos seleccionados")
            Return
        End If

        ChequeaMarcados()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkConfirmado_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmado.CheckedChanged
        Me.FiltraPorEstados()
    End Sub

    Private Sub chkRealizado_CheckedChanged(sender As Object, e As EventArgs) Handles chkRealizado.CheckedChanged
        FiltraPorEstados()
    End Sub
End Class

Public Class ConceptoFacturableHolder
    Public ID_ConceptoFacturable As Nullable(Of Integer)
    Public Descripcion As String
    Public Fecha As Date
    Public Importe As Double
End Class