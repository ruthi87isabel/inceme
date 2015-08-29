Public Class frmTarifasConceptos_Add


    Public IdTarifa As Integer = -1
    Public IdConcepto As String = ""
    Public Descripcion As String = ""
    Public Tarifa As CMDataSet.TarifasRow = Nothing

   

    Private Sub frmTarifasConceptos_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TarifasTableAdapter.FillByIdTarifaANDConcepto(Me.CMDataSet.Tarifas, IdTarifa, IdConcepto)
        If Me.CMDataSet.Tarifas.Count > 0 Then
            Tarifa = Me.CMDataSet.Tarifas(0)
        Else
            'Crearlo Nuevo
            Tarifa = TarifasBindingSource.AddNew().Row()
            Tarifa.DescripcionTarifa = Descripcion
            Tarifa.IdTarifa = IdTarifa
        End If
    End Sub

    Private Sub ConceptoFacturable_CONCEPTOSFRASeleccionado(ByVal IdConceptosFra As System.Int32) Handles ConceptoFacturable.CONCEPTOSFRASeleccionado
        ImporteTextBox.Text = ConceptoFacturable.ConceptosFra.IMPORTE
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.Validate()
        Me.TarifasBindingSource.EndEdit()
        Me.TarifasTableAdapter.Update(Me.CMDataSet.Tarifas)
        IdTarifa = Tarifa.IdTarifa
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class