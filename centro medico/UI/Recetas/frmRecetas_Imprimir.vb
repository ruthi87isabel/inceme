Public Class frmRecetas_Imprimir

    Private paciente As PACIENTE

    Sub New(paciente As PACIENTE)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.paciente = paciente
    End Sub

    Private Sub frmRecetas_Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cont As Integer = 5
        If paciente.DNI Is Nothing Then
            Me.UiCheckBoxDNI.Checked = False
            Me.UiCheckBoxDNI.Enabled = False
            cont = cont - 1
        End If
        If paciente.PASAPORTE Is Nothing Then
            Me.UiCheckBoxPasaporte.Checked = False
            Me.UiCheckBoxPasaporte.Enabled = False
            cont = cont - 1
        End If
        If paciente.REFMUTUA Is Nothing Then
            Me.UiCheckBoxMutua.Checked = False
            Me.UiCheckBoxMutua.Enabled = False
            cont = cont - 1
        End If
        If paciente.REFEMPRESA Is Nothing Then
            Me.UiCheckBoxEmpresa.Checked = False
            Me.UiCheckBoxEmpresa.Enabled = False
            cont = cont - 1
        End If
        If paciente.NIE Is Nothing Then
            Me.UiCheckBoxNIE.Checked = False
            Me.UiCheckBoxNIE.Enabled = False
            cont = cont - 1
        End If
        If cont = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        End If
    End Sub

    Private Sub bt_HtImprimir_Click(sender As Object, e As EventArgs) Handles bt_HtImprimir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_HtCancelar_Click(sender As Object, e As EventArgs) Handles bt_HtCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class