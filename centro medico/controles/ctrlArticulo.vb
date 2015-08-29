Public Class ctrlArticulo
    Public Articulo As CMDataSet.N_ArticulosRow = Nothing

    Private table As CMDataSet.N_ArticulosDataTable = New CMDataSet.N_ArticulosDataTable()
    Private adapter As CMDataSetTableAdapters.N_ArticulosTableAdapter = New CMDataSetTableAdapters.N_ArticulosTableAdapter()

    Public Delegate Sub ID_SelectedEventHandler(ByVal sender As Object, ByVal ID As Integer)

    Public Event ID_Selected As ID_SelectedEventHandler


    Private Sub CargarDatos(ByVal id As Integer)
        Try
            adapter.FillBy(table, id)
            If table.Count > 0 Then
                Articulo = table(0)
                Muestra()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Articulo")
        End Try
    End Sub

    Private Sub Muestra()
        txt_Text.Text = "(" & Articulo.Codigo & ") - " & Articulo.DescripcionGeneral
    End Sub

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Articulo() As Nullable(Of Integer)
        Get
            If Articulo Is Nothing Then
                Return Nothing
            Else
                Return Articulo.ID_Articulo
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarDatos(value)
            End If
        End Set
    End Property

    Private Sub pb_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Seleccionar.Click
        Dim frm As frmArticulos = New frmArticulos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarDatos(frm.Articulo.ID_Articulo)
            ID_Articulo = Articulo.ID_Articulo
            RaiseEvent ID_Selected(Me, ID_Articulo)
        End If
    End Sub


End Class
