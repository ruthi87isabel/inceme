Public Class frmAntecedentes_Editar


    Public Antecedente As AntecedentesDiagnostico

    Sub New(ByRef antecedente As AntecedentesDiagnostico)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Antecedente = antecedente
        Me.AntecedentesDiagnosticoBindingSource.DataSource = antecedente
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If (Me.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS Is Nothing) Then
            MessageBox.Show("Debe introducir un diagnóstico", "Diagnóstico")
            Return
        End If

        'Dim d As DIAGNOSTICO = Me.CtrlDiagnosticosPrincipal.Diagnostico
        'If d Is Nothing Then
        '    Return
        'End If
        '    Dim diagnostico As String = ""
        '    If Not d.DIAGNOSTICO Is Nothing Then
        '        diagnostico = d.DIAGNOSTICO
        '    End If
        '    Dim cie10 As String = ""
        '    If Not d.CIE10 Is Nothing Then
        '        cie10 = d.CIE10
        'End If

        'Me.AntecedentesDiagnosticoBindingSource.DataSource = ant
        'Me.AntecedentesDiagnosticoBindingSource.DataSource.CPACIENTE = Me.IDPACIENTE
        'Me.AntecedentesDiagnosticoBindingSource.DataSource.DIAGNOSTICO = diagnostico
        'Me.AntecedentesDiagnosticoBindingSource.DataSource.CIE10 = cie10
        'Me.AntecedentesDiagnosticoBindingSource.DataSource.OBSERVACIONES = Globales.TextFromRtf(txtObservaciones.Text)
        
        Me.AntecedentesDiagnosticoBindingSource.EndEdit()
        Antecedente.OBSERVACIONES = Globales.TextFromRtf(txtObservaciones.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAntecedentes_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CtrlDiagnosticosPrincipal_DIAGNOSTICOSSeleccionado(IdDIAGNOSTICOS As Integer) Handles CtrlDiagnosticosPrincipal.DIAGNOSTICOSSeleccionado
        Antecedente.CIE10 = CtrlDiagnosticosPrincipal.Diagnostico.CIE10
        Antecedente.DIAGNOSTICO = CtrlDiagnosticosPrincipal.Diagnostico.DIAGNOSTICO
    End Sub
End Class