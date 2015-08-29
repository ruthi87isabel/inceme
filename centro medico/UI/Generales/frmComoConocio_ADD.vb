Public Class frmComoConocio_ADD

    'Public Poblacion As CMDataSet.N_PoblacionesRow
    'Public ID_Poblacion As Integer = -1
    Public ComoConocio As CMDataSet.ComoConocioRow
    Public IDConocio As Integer = -1

    Private Sub frmComoConocio_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TabControl1.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)
        Me.btn_Guardar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)

        'Me.ComoConocioTableAdapter.Fill(Me.CMDataSet.ComoConocio)

        If IDConocio <> -1 Then
            Me.ComoConocioTableAdapter.FillBy(Me.CMDataSet.ComoConocio, IDConocio)
            ComoConocio = Me.CMDataSet.ComoConocio(0)
        Else
            ComoConocio = ComoConocioBindingSource.AddNew().Row()
            ComoConocio.IDConocio = Globales.ObtenerMaximoValor("ComoConocio", "IDConocio") + 1
        End If


    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If DescripcionTextBox.Text = "" Then
            MessageBox.Show("Necesita especificar un nombre")
            DescripcionTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.ComoConocioBindingSource.EndEdit()
        Me.ComoConocioTableAdapter.Update(Me.CMDataSet.ComoConocio)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class