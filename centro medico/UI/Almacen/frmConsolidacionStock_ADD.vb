Imports Microsoft.ApplicationBlocks.Data

Public Class frmConsolidacionStock_ADD

    Public ID_Consolidacion As Long = -1
    Public Consolidacion As CMDataSet.N_Articulos_ConsolidacionStockRow

    Private Sub frmConsolidacionStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.N_AlmacenTableAdapter.Fill(Me.CMDataSet.N_Almacen)
        If ID_Consolidacion <> -1 Then
            'Cargar el articulo y sus datos subyacentes
            N_Articulos_ConsolidacionStockTableAdapter.FillByID(CMDataSet.N_Articulos_ConsolidacionStock, ID_Consolidacion)
            Consolidacion = CMDataSet.N_Articulos_ConsolidacionStock(0)

            ConsolidaStock()

        Else
            Consolidacion = N_Articulos_ConsolidacionStockBindingSource.AddNew().Row
            Consolidacion.Fecha = Date.Now
            If N_AlmacenComboBox.Items.Count > 0 Then
                N_AlmacenComboBox.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Me.Validate()
        Me.N_Articulos_ConsolidacionStockBindingSource.EndEdit()
        Me.N_Articulos_ConsolidacionStockTableAdapter.Update(Me.CMDataSet.N_Articulos_ConsolidacionStock)

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Consolidar_Stock, "Consolidacion Stock", Consolidacion.ID_Consolidacion.ToString(), "")

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub UnidadesContadasTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UnidadesContadasTextBox.KeyUp
        CalculaDisponibles()
    End Sub

    Private Sub CalculaDisponibles()
        DisponiblesTextBox.Text = UnidadesContadasTextBox.Text
    End Sub


    Private Sub ConsolidaStock()

        If Not CtrlArticulo1.ID_Articulo.HasValue Then
            MessageBox.Show("Debe seleccionar un artículo")
            Return
        End If

        If N_AlmacenComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un almacén")
            Return
        End If
        StockActualTextBox.Text = Globales.CalculaStock(CtrlArticulo1.ID_Articulo, N_AlmacenComboBox.SelectedValue, FechaDateTimePicker.Value).StockReal
        UnidadesContadasTextBox.Text = StockActualTextBox.Text
        DisponiblesTextBox.Text = UnidadesContadasTextBox.Text
    End Sub


    Private Sub btn_CalcularStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CalcularStock.Click

        ConsolidaStock()

    End Sub

    Private Sub CtrlArticulo1_ID_Selected(ByVal sender As System.Object, ByVal ID As System.Int32) Handles CtrlArticulo1.ID_Selected
        If (CtrlArticulo1.ID_Articulo.HasValue) And N_AlmacenComboBox.SelectedIndex <> -1 Then
            ConsolidaStock()
        End If

    End Sub
End Class