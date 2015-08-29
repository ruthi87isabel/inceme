Public Class ctrlTarifa
    Public Tarifas As CMDataSet.TarifasRow = Nothing
    Private table As CMDataSet.TarifasDataTable = New CMDataSet.TarifasDataTable()
    Private adapter As CMDataSetTableAdapters.TarifasTableAdapter = New CMDataSetTableAdapters.TarifasTableAdapter()

    Public Event TarifasSeleccionado(ByVal IdTarifas As Integer)
    Public Event TarifasNoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione Tarifa"
        If Not Tarifas Is Nothing Then

            nombre = Tarifas.DescripcionTarifa

        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarTarifas(ByVal id As Integer)"
    Private Sub CargarTarifas(ByVal id As Integer)
        Try
            table = adapter.GetDataBy(id)
            If table.Count > 0 Then
                Tarifas = table(0)
                Muestra()
                RaiseEvent TarifasSeleccionado(id)
            Else
                txt_Nombre.Text = "Tarifa no encontrado..."
                'txt_Especialidad.Text = ""
                RaiseEvent TarifasNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Tarifas")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()
        Dim fullName As String = "Nombre es nulo!!"
        fullName = Tarifas.DescripcionTarifa.Trim()
        txt_Codigo.Text = Tarifas.IdTarifa
        txt_Nombre.Text = fullName
        'txt_Especialidad.Text = Tarifas.Importe.ToString("C2")
    End Sub
#End Region

#Region "Public Property ID_Tarifas() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property ID_Tarifas() As Nullable(Of Integer)
        Get
            If Tarifas Is Nothing Then
                Return Nothing
            Else
                Return Tarifas.IdTarifa
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarTarifas(value)
            End If
        End Set
    End Property
#End Region

    Private Sub pb_SeleccionarTarifas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As frmTarifas = New frmTarifas()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarTarifas(frm.Tarifa.IdTarifa)
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            Try
                CargarTarifas(Integer.Parse(txt_Codigo.Text))
                e.Handled = True
            Catch ex As Exception
                CargarTarifas(-1)
            End Try
        End If
    End Sub


    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            CargarTarifas(Integer.Parse(txt_Codigo.Text))
        Catch ex As Exception
            CargarTarifas(-1)
        End Try
    End Sub

    Private Sub ctrlTarifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Codigo.Focus()
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click
        ID_Tarifas = Nothing
        Tarifas = Nothing
        txt_Codigo.Text = String.Empty
        txt_Nombre.Text = String.Empty
        'txt_Especialidad.Text = ""
    End Sub
End Class