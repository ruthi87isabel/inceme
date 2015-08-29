Public Class form_medicos

    Public MEDICO As CMDataSet.MEDICOSRow = Nothing

    Private Sub form_medicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.MEDICOS' table. You can move, or remove it, as needed.
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
    End Sub

    Private Sub MEDICOSDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MEDICOSDataGridView.CellDoubleClick
        If (MEDICOSDataGridView.SelectedRows.Count > 0) Then
            MEDICO = CType(MEDICOSDataGridView.SelectedRows(0).DataBoundItem.Row, CMDataSet.MEDICOSRow)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub tst_NombreMEDICO_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_NombreMEDICO.KeyUp
        Filtrar("Nombre like '" & tst_NombreMEDICO.Text & "%'")
    End Sub


    Private Sub Filtrar(ByVal filter As String)
        Try

            Dim dw As DataView = Me.CMDataSet.MEDICOS.DefaultView
            dw.RowFilter = filter
            dw.RowStateFilter = DataViewRowState.CurrentRows
            MEDICOSDataGridView.DataSource = dw
            MEDICOSDataGridView.Update()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tst_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Codigo.KeyUp
        If tst_Codigo.Text = "" Then
            Filtrar("CMEDICO >=0")
        Else
            Filtrar("CMEDICO =" & tst_Codigo.Text)
        End If

    End Sub

    Private Sub tst_Apellido1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Apellido1.KeyUp
        Filtrar("APELLIDO1 like '" & tst_Apellido1.Text & "%'")
    End Sub

    Private Sub tst_Apellido2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Apellido2.KeyUp
        Filtrar("APELLIDO2 like '" & tst_Apellido2.Text & "%'")
    End Sub

    Private Sub tst_Especialidad_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tst_Especialidad.KeyUp
        Filtrar("ESPECIALIDAD like '" & tst_Especialidad.Text & "%'")
    End Sub
End Class
