Public Class frmLineaAlarma_Editar

    Public IDPACIENTE As Integer

    Sub New(IDPACIENTE As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IDPACIENTE = IDPACIENTE
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If CtrlAlarma1.ID_ALARMA Is Nothing Then
            MessageBox.Show("Debe seleccionar una alarma", "Alarma")
            Return
        End If
        Dim t As Integer = 5
        Me.LINEAALARMABindingSource.DataSource.REFPACIENTE = Me.IDPACIENTE
        Me.LINEAALARMABindingSource.DataSource.DESCRIPCION = Me.EditDescripcionAlarma.Text
        Me.LINEAALARMABindingSource.EndEdit()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

End Class