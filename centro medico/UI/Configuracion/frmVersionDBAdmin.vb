Public Class frmVersionDBAdmin

    Private Sub VariablesGlobalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariablesGlobalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VariablesGlobalesBindingSource.EndEdit()
        Me.VariablesGlobalesTableAdapter.Update(Me.CM3DataSet.VariablesGlobales)
        Me.Close()

    End Sub

    Private Sub frmVersionDBAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CM3DataSet.VariablesGlobales' table. You can move, or remove it, as needed.
        Me.VariablesGlobalesTableAdapter.FillBy(Me.CM3DataSet.VariablesGlobales, "vBdNecesaria")

    End Sub
End Class