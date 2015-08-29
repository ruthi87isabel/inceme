Public Class frmRecibos_Add

    Public ID_Recibo As Integer = -1
    Public Recibo As CMDataSet.RECIBOSRow


    Private Sub frmRecibos_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ID_Recibo <> -1 Then
            Me.RECIBOSTableAdapter.FillByNumero(Me.CMDataSet.RECIBOS, ID_Recibo)
            If Me.CMDataSet.RECIBOS.Count > 0 Then
                Recibo = Me.CMDataSet.RECIBOS(0)
            Else
                MessageBox.Show("Recibo " & ID_Recibo & " no encontrado")
                Me.Close()
            End If
        Else
            Recibo = Me.CMDataSet.RECIBOS.NewRECIBOSRow()
            Recibo.TIPO = "P"
            Me.CMDataSet.RECIBOS.AddRECIBOSRow(Recibo)
        End If



    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged

        If cb_tipo.SelectedItem = "Paciente" Then
            CtrlPaciente1.Visible = True
            Recibo.TIPO = "P"
            'recibo.REFEMPRESA = 
        Else
            Recibo.TIPO = "E"
        End If
        CtrlEmpresa1.Visible = Not CtrlPaciente1.Visible

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.Validate()
        Me.RECIBOSBindingSource.EndEdit()
        Me.RECIBOSTableAdapter.Update(Me.CMDataSet.RECIBOS)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CtrlEmpresa1_EMPRESASeleccionado(ByVal IdEMPRESAS As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlEmpresa1.EMPRESASeleccionado
        Recibo.NOMBRE = CtrlEmpresa1.NombreCompleto
        If Not CtrlEmpresa1.EMPRESA.IsDIRECCIONNull Then
            Recibo.DIRECCION = CtrlEmpresa1.EMPRESA.DIRECCION
        End If
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        If Me.IsHandleCreated Then
            NOMBRETextBox.Text = CtrlPaciente1.NombreCompleto()
            If Not CtrlPaciente1.Paciente.DOMICILIO Is Nothing Then
                Recibo.DIRECCION = CtrlPaciente1.Paciente.DOMICILIO
            End If
            CtrlStatusPaciente1.ID_PACIENTE = IdPaciente
        End If
        
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        CtrlStatusPaciente1.ID_PACIENTE = Nothing
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click

    End Sub
End Class