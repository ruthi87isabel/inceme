Imports Microsoft.ApplicationBlocks.Data
Public Class frmTarifas

    Public Modo As Globals.ModoParaFormas = Globals.ModoParaFormas.Edicion
    Public Tarifa As CMDataSet.TarifasRow

    Private Sub frmTarifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)

        'permiso de lectura
        If RoleManager.PermisoPorItem(Globals.Usuario.ID_Usuario, RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Lectura Then
            Me.tst_Eliminar.Enabled = False
            Me.NewToolStripButton.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globals.Usuario.ID_Usuario, RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Modificar Then
            Me.tst_Eliminar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globals.Usuario.ID_Usuario, RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Ninguno Then
            Me.ToolStrip1.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globals.Usuario.ID_Usuario, RoleManager.Items.Configuracion) = RoleManager.TipoPermisos.Total Then
            Me.ToolStrip1.Enabled = True
            Me.NewToolStripButton.Enabled = True
            Me.tst_Eliminar.Enabled = True
        End If

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmTarifas_ADD = New frmTarifas_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CMDataSet.Tarifas.Clear()
            Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)
            Me.TarifasBindingSource.MoveLast()
        End If
    End Sub


    Private Sub TarifasDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TarifasDataGridView.CellDoubleClick
        If Modo = Globals.ModoParaFormas.Seleccion Then
            Tarifa = TarifasDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Tarifa = TarifasDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmTarifas_ADD = New frmTarifas_ADD()
        frm.IdTarifa = Tarifa.IdTarifa
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = TarifasDataGridView.SelectedRows(0).Index
            Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)
            TarifasDataGridView.Rows(pos).Selected = True
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        Me.TarifasBindingSource.EndEdit()
        Tarifa = TarifasDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim adapter As New CMDataSetTableAdapters.TarifasTableAdapter()

        Try
            Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
            Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@IdTarifa", SqlDbType.BigInt)
            p1.Value = Tarifa.IdTarifa

            parameters.Add(p1)

            Dim query As String = "DELETE FROM Tarifas WHERE IdTarifa=@IdTarifa"

            Dim res As Object = SqlHelper.ExecuteNonQuery(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())
            Tarifa.Delete()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub TarifasDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarifasDataGridView.SelectionChanged
        tst_Editar.Enabled = TarifasDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = TarifasDataGridView.SelectedRows.Count > 0
        If TarifasDataGridView.SelectedRows.Count > 0 Then
            Tarifa = TarifasDataGridView.SelectedRows(0).DataBoundItem.Row
        End If
    End Sub
End Class