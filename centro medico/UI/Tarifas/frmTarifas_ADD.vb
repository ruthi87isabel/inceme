
Imports Microsoft.ApplicationBlocks.Data

Public Class frmTarifas_ADD

    Public IdTarifa As Integer = -1
    Public Tarifa As CMDataSet.TarifasRow = Nothing

    'Private adapter As CMDataSetTableAdapters.TarifasTableAdapter

    Private Sub frmTarifas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IdTarifa <> -1 Then
            Me.TarifasTableAdapter.FillBy(Me.CMDataSet.Tarifas, IdTarifa)
            Tarifa = Me.CMDataSet.Tarifas(0)
            Me.TarifasResumenTableAdapter.FillBy(Me.CMDataSet.TarifasResumen, IdTarifa)
        Else
            'Crearlo Nuevo
            Tarifa = TarifasBindingSource.AddNew().Row()
            Tarifa.DescripcionTarifa = "Sin descripcion"
            IdTarifaTextBox.Text = Globales.GeneraCodigoAutomatico("Tarifas", "IdTarifa", "0")
            Tarifa.IdTarifa = Integer.Parse(IdTarifaTextBox.Text)
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Tarifa.DescripcionTarifa = 

        Try
            If TarifasResumenDataGridView.Rows.Count = 0 Then
                MessageBox.Show("Debe escoger agregar al menos un concepto facturable")
                Return
            End If

            Me.Validate()
            Me.TarifasBindingSource.EndEdit()

            Me.TarifasTableAdapter.UpdateDescripcionTodasTarifas(DescripcionTarifaTextBox.Text, Tarifa.IdTarifa)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub btnAddConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddConcepto.Click
        Dim frm As New frmTarifasConceptos_Add()
        frm.IdTarifa = Tarifa.IdTarifa
        frm.Descripcion = DescripcionTarifaTextBox.Text
        frm.ShowDialog()
        Me.TarifasResumenTableAdapter.FillBy(Me.CMDataSet.TarifasResumen, Tarifa.IdTarifa)

    End Sub

    Private Sub TarifasResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarifasResumenDataGridView.SelectionChanged
        btnDelConcepto.Enabled = TarifasResumenDataGridView.SelectedRows.Count > 0
        btnEdit.Enabled = TarifasResumenDataGridView.SelectedRows.Count > 0
    End Sub

    Private Sub btnDelConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelConcepto.Click


        Dim t As CMDataSet.TarifasResumenRow = TarifasResumenDataGridView.SelectedRows(0).DataBoundItem.Row

        Dim adapter As New CMDataSetTableAdapters.TarifasTableAdapter()

        Try
            Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
            Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@IdTarifa", SqlDbType.BigInt)
            p1.Value = t.IdTarifa

            Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@IdConceptoFra", SqlDbType.VarChar)
            p2.Value = t.IdConceptoFra

            parameters.Add(p1)
            parameters.Add(p2)


            Dim query As String = "DELETE FROM Tarifas WHERE IdTarifa=@IdTarifa AND IdConceptoFra=@IdConceptoFra"

            Dim res As Object = SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())
            t.Delete()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TarifasResumenDataGridView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TarifasResumenDataGridView.MouseDoubleClick
        If (TarifasResumenDataGridView.SelectedRows.Count > 0) Then
            Dim t As CMDataSet.TarifasResumenRow = TarifasResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            Dim frm As New frmTarifasConceptos_Add()
            frm.IdTarifa = t.IdTarifa
            frm.IdConcepto = t.IdConceptoFra
            frm.Descripcion = DescripcionTarifaTextBox.Text
            frm.ShowDialog()
            Me.TarifasResumenTableAdapter.FillBy(Me.CMDataSet.TarifasResumen, Tarifa.IdTarifa)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        TarifasResumenDataGridView_MouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub frmTarifas_ADD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                btnAddConcepto_Click(Nothing, Nothing)
            Case Globales.TeclasBasicas.Editar
                TarifasResumenDataGridView_MouseDoubleClick(Nothing, Nothing)
            Case Globales.TeclasBasicas.Borrar
                btnDelConcepto_Click(Nothing, Nothing)
        End Select
    End Sub
End Class