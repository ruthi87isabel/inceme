Public Class frmInformeMedico_ADD
   
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bt_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salvar.Click
        'chequear que todos los valores esten correctos
        If ValidarInforme() Then
            INFORME_MEDICOBindingSource.EndEdit()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub


    Function ValidarInforme() As Boolean
        If descripcionTextBox.Text = String.Empty Then
            MessageBox.Show("Debe introducir algun texto en la descripción")
            descripcionTextBox.Focus()
            Return False
        End If
        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe seleecionar un doctor")
            CtrlMedico1.Focus()
            Return False
        End If
        Return True
    End Function

End Class