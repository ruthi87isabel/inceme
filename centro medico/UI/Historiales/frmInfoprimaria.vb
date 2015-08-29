Public Class frmInfoprimaria

    'Dim fFecha As DateTime
    'Dim fDescripcion As String
    'Dim fDetalle As String
    'Dim fAceptar As Boolean
    Dim fCurrentAccion As Enums.Accion


    Sub New(ByVal aCurrentAccion As Enums.Accion)

        InitializeComponent()
        fCurrentAccion = aCurrentAccion
    End Sub

    
    Private Sub bt_IPAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_IPAceptar.Click
        If tb_IPDescrip.Text() = Nothing Then
            MessageBox.Show("Tiene que poner un descripción")
            tb_IPDescrip.Focus()
            Return
        End If
        'fFecha = dtp_IPFecha.Value()
        'fDescripcion =
        'fDetalle = tb_IPDetalle.Text()
        'fAceptar = True
        INFORMACIONPRIMARIABindingSource.EndEdit()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_IPCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_IPCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub form_pac_infoprimaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If fCurrentAccion <> Enums.Accion.Insertar Then
        '    dtp_IPFecha.Value = fFecha
        '    tb_IPDescrip.Text = fDescripcion
        '    tb_IPDetalle.Text = fDetalle
        'End If

    End Sub
End Class