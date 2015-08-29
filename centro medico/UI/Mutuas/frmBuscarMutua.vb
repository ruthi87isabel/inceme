Public Class frmBuscarMutua

    Public Event MutuaSeleccionada(ByVal IdMutua As Integer)

    Private Sub tst_Codigo_Leave(sender As System.Object, e As System.EventArgs) Handles tst_Codigo.Leave
        FiltrarMutuas()
    End Sub

    Private Sub tst_NombreMutua_Leave(sender As System.Object, e As System.EventArgs) Handles tst_NombreMutua.Leave
        FiltrarMutuas()
    End Sub

    Private Sub tst_Codigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tst_Codigo.KeyPress
        FiltrarMutuas()
    End Sub

    Private Sub tst_NombreMutua_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tst_NombreMutua.KeyPress
        FiltrarMutuas()
    End Sub

    Private Sub FiltrarMutuas()
        Try

            Dim content As New CMLinqDataContext
            Dim query As IQueryable(Of MUTUA) = content.MUTUAs.AsQueryable()

            If Not String.IsNullOrEmpty(tst_Codigo.Text) Then
                query = query.Where(Function(m) m.CMUTUA = Integer.Parse(tst_Codigo.Text))
            End If

            If Not String.IsNullOrEmpty(tst_NombreMutua.Text) Then
                query = query.Where(Function(m) m.NOMBRE.StartsWith(tst_NombreMutua.Text))
            End If

            MUTUABindingSource.DataSource = query

        Catch ex As Exception

        End Try

    End Sub


    Private Sub frmBuscarMutua_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        FiltrarMutuas()
    End Sub

    Private Sub MUTUADataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MUTUADataGridView.CellDoubleClick
        RaiseEvent MutuaSeleccionada(CType(MUTUABindingSource.Current, MUTUA).CMUTUA)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class