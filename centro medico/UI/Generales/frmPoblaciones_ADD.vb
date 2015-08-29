Public Class frmPoblaciones_ADD

    Public Poblacion As CMDataSet.N_PoblacionesRow
    Public ID_Poblacion As Integer = -1

    Private Sub frmPoblaciones_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TabControl1.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)
        Me.btn_Guardar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Paises) > 2)

        Me.N_ProvinciasTableAdapter.Fill(Me.CMDataSet.N_Provincias)

        If ID_Poblacion <> -1 Then
            Me.N_PoblacionesTableAdapter.FillBy(Me.CMDataSet.N_Poblaciones, ID_Poblacion)
            Poblacion = Me.CMDataSet.N_Poblaciones(0)
        Else
            Poblacion = N_PoblacionesBindingSource.AddNew().Row()
            Poblacion.ID_Poblacion = Globales.ObtenerMaximoValor("N_Poblaciones", "ID_Poblacion") + 1
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If NombreTextBox.Text = "" Then
            MessageBox.Show("Necesita especificar un nombre")
            NombreTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.N_PoblacionesBindingSource.EndEdit()
        Me.N_PoblacionesTableAdapter.Update(Me.CMDataSet.N_Poblaciones)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class