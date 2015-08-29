Public Class frmHistorialesDiagnosticosEditar


    Public HistorialDiagnostico As HistorialesDiagnostico

    Sub New(ByRef antecedente As HistorialesDiagnostico)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.HistorialDiagnostico = antecedente
        Me.HistorialesDiagnosticoBindingSource.DataSource = antecedente
        CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS = antecedente.IdDiagnostico
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If (Me.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS Is Nothing) Then
            MessageBox.Show("Debe introducir un diagnóstico", "Diagnóstico")
            Return
        End If


        HistorialDiagnostico.OBSERVACIONES = Globales.TextFromRtf(txtObservaciones.Text)

        Me.HistorialesDiagnosticoBindingSource.EndEdit()

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub CtrlDiagnosticosPrincipal_DIAGNOSTICOSSeleccionado(IdDIAGNOSTICOS As Integer) Handles CtrlDiagnosticosPrincipal.DIAGNOSTICOSSeleccionado
        HistorialDiagnostico.CIE10 = CtrlDiagnosticosPrincipal.Diagnostico.CIE10
        HistorialDiagnostico.IdDiagnostico = IdDIAGNOSTICOS
        HistorialDiagnostico.DIAGNOSTICO = CtrlDiagnosticosPrincipal.Diagnostico.DIAGNOSTICO
    End Sub
End Class