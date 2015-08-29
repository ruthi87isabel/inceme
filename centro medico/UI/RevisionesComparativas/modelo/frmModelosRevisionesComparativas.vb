Public Class frmModelosRevisionesComparativas

    Public Modelo As CMDataSet.MODELOSCOMPARATIVARow
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion


    Private Sub frmModelosRevisionesComparativas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As New form_modelo_rev_comparativoas("Nuevo modelo", Enums.Accion.Insertar)
        frm.ShowInTaskbar = False
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
    End Sub



    Private Sub MODELOSCOMPARATIVADataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MODELOSCOMPARATIVADataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            tst_Editar_Click(Nothing, Nothing)
        Else
            If MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0 Then
                Modelo = MODELOSCOMPARATIVADataGridView.SelectedRows(0).DataBoundItem.Row
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

    Private Sub MODELOSCOMPARATIVADataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODELOSCOMPARATIVADataGridView.SelectionChanged
        tst_Editar.Enabled = MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0
        tstDuplicarModelo.Enabled = MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0
        If MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0 Then
            Modelo = MODELOSCOMPARATIVADataGridView.SelectedRows(0).DataBoundItem.Row
        End If

    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        If MODELOSCOMPARATIVADataGridView.SelectedRows.Count > 0 Then
            Modelo = MODELOSCOMPARATIVADataGridView.SelectedRows(0).DataBoundItem.Row
            Dim frm As New form_modelo_rev_comparativoas("Nuevo modelo", Enums.Accion.Modificar, Modelo.CODIGO)
            frm.ShowInTaskbar = False
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
        End If
        
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        For Each row As DataGridViewRow In MODELOSCOMPARATIVADataGridView.SelectedRows
            Modelo = row.DataBoundItem.Row
            Try
                'Primero hay que eliminar toda referencia a este Modelo y luego eliminar el modelo
                'Dim LineasAdapter As New CMDataSetTableAdapters.LCOMPARATIVASTableAdapter()
                'Dim n As Integer = LineasAdapter.UpdateREFMODELOCOMPARATIVAaNULL(Modelo.CODIGO)

                Modelo.Delete()
                MODELOSCOMPARATIVABindingSource.EndEdit()
                MODELOSCOMPARATIVATableAdapter.Update(CMDataSet.MODELOSCOMPARATIVA)

            Catch ex As Exception
                MessageBox.Show("Este modelo no puede ser eliminando debido a que esta en uso")
                'MessageBox.Show(ex.Message)
                Return
            End Try
            Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
        Next


    End Sub

    Private Sub tstDuplicarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstDuplicarModelo.Click
        'Primero duplicar el modelo
        Dim modeloNuevo As CMDataSet.MODELOSCOMPARATIVARow = CMDataSet.MODELOSCOMPARATIVA.NewMODELOSCOMPARATIVARow()

        If Not Modelo.MODELO Is Nothing And Not Modelo.CODIGO Is Nothing Then
            modeloNuevo.MODELO = ("Copia de " & Modelo.MODELO).Substring(0, Math.Min(Modelo.MODELO.Length + 9, 120))
            CMDataSet.MODELOSCOMPARATIVA.AddMODELOSCOMPARATIVARow(modeloNuevo)
            Dim succeed As Boolean = False
            While Not succeed
                Try
                    modeloNuevo.CODIGO = Guid.NewGuid().ToString().Substring(0, 12)
                    MODELOSCOMPARATIVABindingSource.EndEdit()
                    MODELOSCOMPARATIVATableAdapter.Update(CMDataSet.MODELOSCOMPARATIVA)
                Catch ex As Exception

                End Try
                succeed = True
            End While

            'Ahora a duplicar los datos
            Dim datosAdapter As New CMDataSetTableAdapters.MODELOSDATOSTableAdapter()
            Dim datosOriginales As New CMDataSet.MODELOSDATOSDataTable()

            datosAdapter.FillByMODELOCOMPARATIVA(datosOriginales, Modelo.CODIGO)
            For Each datoOriginal As CMDataSet.MODELOSDATOSRow In datosOriginales
                Dim nuevoDato As CMDataSet.MODELOSDATOSRow = CMDataSet.MODELOSDATOS.NewMODELOSDATOSRow()
                If Not datoOriginal.NOMBREDATO Is Nothing Then
                    nuevoDato.NOMBREDATO = datoOriginal.NOMBREDATO
                End If

                If Not datoOriginal.TIPODATO Is Nothing Then
                    nuevoDato.TIPODATO = datoOriginal.TIPODATO
                End If

                nuevoDato.REFMODELOCOMPARATIVA = modeloNuevo.CODIGO

                CMDataSet.MODELOSDATOS.AddMODELOSDATOSRow(nuevoDato)
            Next
            datosAdapter.Update(CMDataSet.MODELOSDATOS)
        End If


        If MessageBox.Show("¿desea abrir la nueva plantilla para editarla?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim frm As New form_modelo_rev_comparativoas("Nuevo modelo", Enums.Accion.Modificar, modeloNuevo.CODIGO)
            frm.ShowInTaskbar = False
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)
        End If

        Me.MODELOSCOMPARATIVATableAdapter.Fill(Me.CMDataSet.MODELOSCOMPARATIVA)



    End Sub

    Private Sub tstModelo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tstModelo.KeyUp
        Filtrar()
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()
        Dim filtros As New List(Of String)

        
        If tstModelo.Text.Length > 0 Then
            filtros.Add("MODELO LIKE '" & tstModelo.Text & "%'")
        End If
        
        Dim fil As String = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CMDataSet.MODELOSCOMPARATIVA.DefaultView
            dw.RowFilter = fil
            dw.RowStateFilter = DataViewRowState.CurrentRows
            MODELOSCOMPARATIVADataGridView.DataSource = dw
            MODELOSCOMPARATIVADataGridView.Update()
            
        Catch ex As Exception

        End Try

    End Sub
#End Region

End Class