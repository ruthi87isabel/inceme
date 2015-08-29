Public Class ctrlAgenteComercial
    Public AgenteComercial As CMDataSet.N_AgentesComercialesRow = Nothing
    Private table As CMDataSet.N_AgentesComercialesDataTable = New CMDataSet.N_AgentesComercialesDataTable()
    Private adapter As CMDataSetTableAdapters.N_AgentesComercialesTableAdapter = New CMDataSetTableAdapters.N_AgentesComercialesTableAdapter()

    Private Sub CargarDatos(ByVal id As Integer)
        Try
            adapter.FillBy(table, id)
            If table.Count > 0 Then
                AgenteComercial = table(0)
                Muestra()
            End If
        Catch ex As Exception
            Globals.ErrorMsg(ex, "Error cargando Agente Comercial")
        End Try
    End Sub

    Private Sub Muestra()
        txt_Text.Text = "(" & AgenteComercial.Codigo & ") - " & AgenteComercial.Nombre
    End Sub

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_AgenteComercial() As Nullable(Of Integer)
        Get
            If AgenteComercial Is Nothing Then
                Return Nothing
            Else
                Return AgenteComercial.ID_AgenteComercial
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarDatos(value)
            End If
        End Set
    End Property

    Private Sub pb_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Seleccionar.Click
        Dim frm As frmAgentesComerciales = New frmAgentesComerciales()
        frm.Modo = Globals.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            'CargarDatos(frm.Agente.ID_AgenteComercial)
            ID_AgenteComercial = AgenteComercial.ID_AgenteComercial
        End If
    End Sub
End Class
