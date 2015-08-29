Public Class frmRevComparativa_Nuevo_Seguimiento

    Private Sub frmRevComparativa_Nuevo_Seguimiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim seguimiento As LCOMPARATIVA = LCOMPARATIVABindingSource.DataSource
        If Not seguimiento Is Nothing Then
            If (Now - seguimiento.FECHA.Value).Days >= 1 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
                lblSeguimientoDesactivado.Visible = True
                For Each c As Control In Me.Controls
                    c.Enabled = False
                Next
                lblSeguimientoDesactivado.Enabled = True
            ElseIf (Now - seguimiento.FECHA.Value).Days >= 1 Then
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pacientes_SeguimientoRevision, "Seguimiento de Revisión", seguimiento.ID, "Se ha abierto en modo edición un seguimiento que tiene más de 24h (" & seguimiento.COMPARATIVA.PACIENTE.NombreCompleto & "(" & seguimiento.COMPARATIVA.PACIENTE.CPACIENTE & "). Se ha permitido por la definición del rol del usuario. ")
            End If



        End If

    End Sub

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click

        If CtrlModeloRevision1.CODIGO Is Nothing Then
            MessageBox.Show("Debe seleccionar un modelo")
            CtrlModeloRevision1.Focus()
            Return
        End If

        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe seleccionar un médico para este seguimiento")
            CtrlMedico1.Focus()
            Return
        End If

        If tb_dbsDescripcion.Text = String.Empty Then
            MessageBox.Show("La descripción es obligatoria")
            tb_dbsDescripcion.Focus()
            Return
        End If

        LCOMPARATIVABindingSource.EndEdit()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class