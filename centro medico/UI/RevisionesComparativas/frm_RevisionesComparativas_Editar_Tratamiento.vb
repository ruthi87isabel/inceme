Public Class frm_RevisionesComparativas_Editar_Tratamiento


    Private Sub frmRevisionesComparativas_ADD_Tratamiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = LCOMPARATIVAS_TRATAMIENTOsBindingSource.DataSource
        If Not tratamiento Is Nothing Then
            If tratamiento.Facturada = True Then
                Label2.Visible = True
                Label2.Text = "Tratamiento Facturado en Cita, edicion desahabilitada"
                'Me.lbl_FacturadoCita.Visible = True
                For Each c As Control In Me.Controls
                    c.Enabled = False
                Next
                btnGuardar.Enabled = True
                Label2.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource.EndEdit()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CtrlConceptoFacturable21_CONCEPTOSFRASeleccionado(IdConceptosFra As System.String) Handles CtrlConceptoFacturable21.CONCEPTOSFRASeleccionado
        'If TratamientoTextBox.Text Is Nothing Or TratamientoTextBox.Text = String.Empty Then
        'Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = LCOMPARATIVAS_TRATAMIENTOsBindingSource.Current
        'tratamiento.Tratamiento = CtrlConceptoFacturable21.ConceptosFra.DESCRIPCION
        'End If
    End Sub

    Private Sub CtrlConceptoFacturable21_ConceptosSeleccionadoManualmente(IdConceptosFra As String) Handles CtrlConceptoFacturable21.ConceptosSeleccionadoManualmente
        Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = LCOMPARATIVAS_TRATAMIENTOsBindingSource.Current
        tratamiento.Tratamiento = CtrlConceptoFacturable21.ConceptosFra.DESCRIPCION
    End Sub
End Class