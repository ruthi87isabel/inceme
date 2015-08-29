Public Class frmProcesos_Seleccionar

    Private _id_paciente As Nullable(Of Integer) = Nothing

    Public IDProcesoPreseleccionado As Long = -1

    '<System.ComponentModel.Browsable(True)> _
    Public Property ID_Paciente() As Nullable(Of Integer)
        Get
            Return _id_paciente
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _id_paciente = value
            CargaProcesos()
        End Set
    End Property


    Private Sub ctrlProcesosActivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        CargaProcesos()

    End Sub

    Private Sub CargaProcesos()
        If _id_paciente.HasValue Then
            N_Procesos_ResumenTableAdapter.FillByPaciente(CM3DataSet.N_Procesos_Resumen, _id_paciente)
            For Each row As DataGridViewRow In N_Procesos_ResumenDataGridView.Rows
                Dim proceso As CM3DataSet.N_Procesos_ResumenRow = row.DataBoundItem.Row

                row.Cells(columnEstado.Index).Value = Globales.Proceso_DameIconoEstado(proceso)

                'If Not proceso.IsFechaFinalNull Then
                '    If proceso.Finalizado Then
                '        'Finalizado
                '        row.Cells(columnEstado.Index).Value = Global.centro_medico.My.Resources.Resources._24_em_check
                '    Else
                '        'Cerrado
                '        row.Cells(columnEstado.Index).Value = Global.centro_medico.My.Resources.Resources._24_control_stop
                '    End If
                'Else
                '    'Abierto
                '    row.Cells(columnEstado.Index).Value = Global.centro_medico.My.Resources.Resources._24_arrow_forward
                'End If
                If proceso.ID_Proceso = IDProcesoPreseleccionado Then
                    row.Cells(ChkCol.Index).Value += True
                    row.Selected = True
                End If
            Next
        Else
            CM3DataSet.N_Procesos_Resumen.Clear()
        End If

    End Sub


    Public Function SelectedProceso() As CM3DataSet.N_Procesos_ResumenRow
        If N_Procesos_ResumenDataGridView.SelectedRows.Count > 0 Then
            If N_Procesos_ResumenDataGridView.SelectedRows(0).Cells(ChkCol.Index).Value = True Then
                Dim proceso As CM3DataSet.N_Procesos_ResumenRow = N_Procesos_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
                Return proceso
            End If
        End If
        Return Nothing
    End Function


    Private Sub bt_Partes_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Partes_Edit.Click
        Dim frm As New frmProcesos()
        frm.ShowDialog()
        CargaProcesos()
    End Sub



    Private Sub CheckAll(ByVal value As Boolean)
        For Each row As DataGridViewRow In N_Procesos_ResumenDataGridView.Rows
            row.Cells(ChkCol.Index).Value = value
        Next
    End Sub


    Private Sub N_Procesos_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Procesos_ResumenDataGridView.SelectionChanged
        btn_Aceptar.Enabled = N_Procesos_ResumenDataGridView.SelectedRows.Count > 0
    End Sub

    Private Sub N_Procesos_ResumenDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Procesos_ResumenDataGridView.CellContentDoubleClick
        If N_Procesos_ResumenDataGridView.SelectedRows.Count > 0 Then
            btn_Aceptar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub N_Procesos_ResumenDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Procesos_ResumenDataGridView.CellClick
        'If e.ColumnIndex = ChkCol.Index Then
        CheckAll(False)
        N_Procesos_ResumenDataGridView.Rows(e.RowIndex).Cells(ChkCol.Index).Value = True
        'End If
    End Sub
End Class