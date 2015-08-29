Public Class ctrlBanco

    Public Banco As CMDataSet.BANCOSRow = Nothing

    Private table As CMDataSet.BANCOSDataTable = New CMDataSet.BANCOSDataTable()
    Private adapter As CMDataSetTableAdapters.BANCOSTableAdapter = New CMDataSetTableAdapters.BANCOSTableAdapter()

    Private Sub CargarDatos(ByVal id As Integer)
        Try
            'descomentar cuando haya hecho los cambios en el cmdataset
            'adapter.FillByIdBanco(table, id)
            If table.Count > 0 Then
                Banco = table(0)
                Muestra()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Banco")
        End Try
    End Sub

    Private Sub Muestra()
        'descomentar cuando haya hecho los cambios en el cmdataset
        'txt_Text.Text = "(" & Banco.idBanco & ") - " & Banco.NOMBRE
    End Sub

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Banco() As Nullable(Of Integer)
        Get
            If Banco Is Nothing Then
                Return Nothing
            Else
                'descomentar cuando haya hecho los cambios en el cmdataset
                'Return Banco.IDBanco
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarDatos(value)
            End If
        End Set
    End Property

    Private Sub pb_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Seleccionar.Click
        Dim frm As form_bancos
        adapter.Fill(table)
        frm = New form_bancos("Listado de Bancos", Enums.Accion.Insertar)
        frm.ShowIcon = False
        frm.ShowDialog()

        If frm.ShowDialog() = DialogResult.OK Then
            'descomentar cuando haya hecho los cambios en el cmdataset
            'CargarDatos(frm.Banco.IDBanco)
            'ID_Banco = Banco.IDBanco
        End If
    End Sub

   
End Class
