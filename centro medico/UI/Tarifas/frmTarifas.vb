Imports Microsoft.ApplicationBlocks.Data
Public Class frmTarifas

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Tarifa As CMDataSet.TarifasRow

    Private Sub frmTarifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)

        'TarifasBindingSource.DataSource = From t In Globales.Context.Tarifas Select t Distinct

        
            'permiso de lectura

        Me.tst_Eliminar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tarifas) > RoleManager.TipoPermisos.Lectura
        Me.NewToolStripButton.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tarifas) > RoleManager.TipoPermisos.Lectura
        Me.tst_Editar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tarifas) > RoleManager.TipoPermisos.Lectura

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmTarifas_ADD = New frmTarifas_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CMDataSet.Tarifas.Clear()
            Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)
            Me.TarifasBindingSource.MoveLast()
        End If
    End Sub


    
    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        If (GridEX1.SelectedItems.Count > 0) Then
            Tarifa = GridEX1.SelectedItems(0).GetRow().DataRow.Row
            Dim frm As frmTarifas_ADD = New frmTarifas_ADD()
            frm.IdTarifa = Tarifa.IdTarifa
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim pos As Integer = GridEX1.SelectedItems(0).GetRow().RowIndex
                Me.TarifasTableAdapter.FillByDistinct(Me.CMDataSet.Tarifas)
                GridEX1.EnsureVisible(pos)
            End If
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        If (GridEX1.SelectedItems.Count > 0) Then
            Me.TarifasBindingSource.EndEdit()
            Tarifa = GridEX1.SelectedItems(0).GetRow().DataRow.Row
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

        End If


    End Sub


    Private Sub frmTarifas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                NewToolStripButton_Click(Nothing, Nothing)
            Case Globales.TeclasBasicas.Editar
                tst_Editar_Click(Nothing, Nothing)
            Case Globales.TeclasBasicas.Borrar
                tst_Eliminar_Click(Nothing, Nothing)
        End Select

    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Tarifa = GridEX1.SelectedItems(0).GetRow().DataRow.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If tst_Editar.Enabled Then
                tst_Editar_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = GridEX1.SelectedItems.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tarifas) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Enabled = GridEX1.SelectedItems.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Tarifas) > RoleManager.TipoPermisos.Lectura
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                Tarifa = GridEX1.SelectedItems(0).GetRow().DataRow.Row
            End If
        End If
    End Sub
End Class