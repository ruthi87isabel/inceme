Public Class frmConceptoFacturable_ADD

    Public IdPaciente As Integer
    Public ConceptoFacturable As CONCEPTOSFACTURABLE
    Public CurrentAccion As Enums.Accion = Enums.Accion.Ver


    Private Sub frmConceptoFacturable_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONCEPTOSFACTURABLEBindingSource.DataSource = ConceptoFacturable
         If Me.CurrentAccion = Enums.Accion.Modificar Then

            CtrlConceptoFacturable21.ID_ConceptosFra = ConceptoFacturable.REFCONCEPTO
        End If

        If Me.CurrentAccion = Enums.Accion.Ver Then
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
        If Not CtrlConceptoFacturable21.ID_ConceptosFra Is Nothing Then
            If CtrlConceptoFacturable21.ConceptosFra.Duracion.HasValue Then
                txtDuracion.Value = CtrlConceptoFacturable21.ConceptosFra.Duracion
            End If
        End If

    End Sub

    Private Sub CtrlConceptoFacturable21ConceptosSeleccionadoManualmente(idConceptosFra As String) Handles CtrlConceptoFacturable21.ConceptosSeleccionadoManualmente
        txtDescripcion.Text = CtrlConceptoFacturable21.ConceptosFra.DESCRIPCION
        If CtrlConceptoFacturable21.ConceptosFra.Duracion.HasValue Then
            txtDuracion.Value = CtrlConceptoFacturable21.ConceptosFra.Duracion
        End If

    End Sub

    Private Sub BtAceptarClick(sender As Object, e As EventArgs) Handles bt_aceptar.Click

        If String.IsNullOrEmpty(txtDescripcion.Text) Then
            MessageBox.Show("El campo descripción debe tener valor", "Centro Médico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return
        End If

        If CtrlConceptoFacturable21.ID_ConceptosFra Is Nothing Then
            MessageBox.Show("Debe Escoger un Concepto Facturable", "Centro Médico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CtrlConceptoFacturable21.Focus()
            Return
        End If

        'Dim durac As Date = New Date(2000, 1, 1, 0, 0, 0)
        'Try
        '    durac = Date.Parse(txtDuracion.Text)
        'Catch ex As Exception
        'End Try

        ConceptoFacturable.DESCRIPCION = txtDescripcion.Text
        ConceptoFacturable.REFCONCEPTO = CtrlConceptoFacturable21.ID_ConceptosFra
        ConceptoFacturable.IMPORTE = txtImporte.Text
        'ConceptoFacturable.REFPACIENTE = IdPaciente
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    
    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class