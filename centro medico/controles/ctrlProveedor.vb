Public Class ctrlProveedor

    Public Proveedor As N_Proveedor = Nothing
    Public Context As New CMLinqDataContext


    Public Event ProveedorSeleccionado(ByVal Id As Integer, ByVal oldProvider As Nullable(Of Integer))
    Public Event ProveedorEliminado(ByVal IdAnterior As Nullable(Of Integer))
    Public Event ProveedorNoEncontrado()
  
    Private Sub CargarDatos(ByVal id As Integer)


        Try
            Proveedor = (From p In Context.N_Proveedors _
                        Where p.ID_Proveedor = id _
                        Select p).SingleOrDefault()


            If Not Proveedor Is Nothing Then
                Muestra()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Proveedor")
        End Try
    End Sub

    Private Sub Muestra()
        txt_Codigo.Text = Proveedor.Codigo
        txt_Nombre.Text = Proveedor.NombreFiscal
    End Sub

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Proveedor() As Nullable(Of Integer)
        Get
            If Proveedor Is Nothing Then
                Return Nothing
            Else
                Return Proveedor.ID_Proveedor
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarDatos(value)
            End If
        End Set
    End Property

    Private Sub pb_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As frmProveedores = New frmProveedores()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarDatos(frm.Proveedor.ID_Proveedor)
            ID_Proveedor = Proveedor.ID_Proveedor
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim oldProveedor As Nullable(Of Integer) = Me.ID_Proveedor
                Dim id As Integer = Integer.Parse(txt_Codigo.Text)
                CargarDatos(id)
                If Not Me.Proveedor Is Nothing Then
                    If oldProveedor = Proveedor.ID_Proveedor Then
                        oldProveedor = Nothing
                    End If
                    RaiseEvent ProveedorSeleccionado(id, oldProveedor)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            Dim oldProveedor As Nullable(Of Integer) = Me.ID_Proveedor
            Dim cProveedor As Integer = Integer.Parse(txt_Codigo.Text)
            CargarDatos(cProveedor)
            If Not Me.Proveedor Is Nothing Then
                If oldProveedor = Proveedor.ID_Proveedor Then
                    oldProveedor = Nothing
                End If
                RaiseEvent ProveedorSeleccionado(cProveedor, oldProveedor)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim oldProveedor As Nullable(Of Integer) = Nothing
        If Me.ID_Proveedor.HasValue Then
            oldProveedor = Me.ID_Proveedor
        End If

        Me.ID_Proveedor = Nothing
        Me.Proveedor = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione Proveedor"

        RaiseEvent ProveedorEliminado(oldProveedor)

    End Sub


End Class
