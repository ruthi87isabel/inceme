Public Class frm_Mutuas_Lineas_Add

    Private Sub LMUTUASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LMUTUASBindingSource.EndEdit()
        Me.LMUTUASTableAdapter.Update(Me.CMDataSet.LMUTUAS)

    End Sub

    Private Sub frm_Mutuas_Lineas_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.LMUTUAS' table. You can move, or remove it, as needed.
        Me.LMUTUASTableAdapter.Fill(Me.CMDataSet.LMUTUAS)

    End Sub
End Class