Public Class frmTarifasConceptos_Add


    Public IdTarifa As Integer = -1
    Public IdConcepto As String = ""
    Public Descripcion As String = ""
    Public Tarifa As CMDataSet.TarifasRow = Nothing
    Private IsNew As Boolean = False

   

    Private Sub frmTarifasConceptos_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TarifasTableAdapter.FillByIdTarifaANDConcepto(Me.CMDataSet.Tarifas, IdTarifa, IdConcepto)
        If Me.CMDataSet.Tarifas.Count > 0 Then
            Tarifa = Me.CMDataSet.Tarifas(0)
        Else
            'Crearlo Nuevo
            IsNew = True
            Tarifa = TarifasBindingSource.AddNew().Row()
            Tarifa.DescripcionTarifa = Descripcion
            Tarifa.IdTarifa = IdTarifa
        End If
    End Sub

    Private Sub ConceptoFacturable_CONCEPTOSFRASeleccionado(ByVal IdConceptosFra As String) Handles ConceptoFacturable.CONCEPTOSFRASeleccionado
        If ImporteTextBox.Text = String.Empty Then
            ImporteTextBox.Text = ConceptoFacturable.ConceptosFra.IMPORTE
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            If Me.ConceptoFacturable.ID_ConceptosFra Is Nothing Then
                MessageBox.Show("Debe seleccionar un concepto facturable ")
                Return
            End If

            Me.Validate()
            Me.TarifasBindingSource.EndEdit()

            'Verificar que no exista ya el concepto
            If TarifasTableAdapter.GetDataByIdTarifaANDConcepto(Tarifa.IdTarifa, Me.ConceptoFacturable.ID_ConceptosFra).Count > 0 Then
                If CMDataSet.HasChanges(DataRowState.Added) Then
                    MessageBox.Show("Este concepto ya está añadido a la tarifa actual")
                    Return
                End If
            End If

            Me.TarifasTableAdapter.Update(Me.CMDataSet.Tarifas)
            IdTarifa = Tarifa.IdTarifa
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ConceptoFacturable_ConceptosFraNoEncontrado() Handles ConceptoFacturable.ConceptosFraNoEncontrado
        ConceptoFacturable.ID_ConceptosFra = Nothing
    End Sub
End Class