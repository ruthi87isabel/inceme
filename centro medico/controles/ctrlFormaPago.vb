Public Class ctrlFormaPago

    Public FormaPago As CMDataSet.FORMASPAGORow = Nothing

    Private table As CMDataSet.FORMASPAGODataTable = New CMDataSet.FORMASPAGODataTable()
    Private adapter As CMDataSetTableAdapters.FORMASPAGOTableAdapter = New CMDataSetTableAdapters.FORMASPAGOTableAdapter()

    Private Sub CargarDatos(ByVal id As String)
        Try
            table = adapter.GetFormasPagoById(id)
            If table.Count > 0 Then
                FormaPago = table(0)
                Muestra()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Forma Pago")
        End Try
    End Sub

    Private Sub Muestra()
        txt_Text.Text = "(" & FormaPago.Codigo & ") - " & FormaPago.Descripcion
    End Sub

    '<System.ComponentModel.Browsable(True)> _
    Public Property ID_FormaPago() As String
        Get
            If FormaPago Is Nothing Then
                Return Nothing
            Else
                Return FormaPago.CODIGO
            End If
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                If value.Length > 0 Then
                    CargarDatos(value)
                End If
            End If
        End Set
    End Property

    Private Sub pb_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Seleccionar.Click
        Dim frm As form_listados
        adapter.Fill(table)
        frm = New form_listados("Listado Formas de Pago", Me.FormasPagoBindingSource, RoleManager.Items.Formas_de_Pago, True)
        frm.ShowInTaskbar = False
        'frm.ShowDialog()
        If frm.ShowDialog() = DialogResult.OK Then
            CargarDatos(frm.Selected)
            ID_FormaPago = FormaPago.CODIGO
        End If
    End Sub

End Class
