Public Class ctrlSalasvb

    Public Sala As SALA
    Public Context As New CMLinqDataContext


    Public Event SalaSeleccionada(ByVal IdSala As Integer)
    Public Event SalaEliminada(ByVal idSala As Integer)
    Public Event PacienteNoEncontrado()

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_SALA() As Nullable(Of Integer)
        Get
            If Sala Is Nothing Then
                Return Nothing
            Else
                Return Sala.ID_SALA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarSala(value)
            End If
        End Set
    End Property

    Private Sub ctrlSalasvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarSala(value As Integer?)

        If value.HasValue Then
            Sala = (From s In Context.SALAs Where s.ID_SALA = value Select s).SingleOrDefault()
            If Not Sala Is Nothing Then
                txt_Codigo.Text = Sala.ID_SALA
                txt_Nombre.Text = Sala.Nombre
            Else
                txt_Codigo.Text = String.Empty
                txt_Nombre.Text = "No seleccionado"
            End If
        Else
            txt_Codigo.Text = String.Empty
            txt_Nombre.Text = "No seleccionado"
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As New frmSalas
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog = DialogResult.OK Then
            Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Context.SALAs)
            CargarSala(frm.Sala.ID_SALA)
            RaiseEvent SalaSeleccionada(frm.Sala.ID_SALA)
        End If
        GC.Collect()
        If Not frm.IsDisposed Then frm.Dispose()
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Dim codigo As Nullable(Of Integer) = Nothing
        Try
            codigo = Integer.Parse(txt_Codigo.Text)
        Catch ex As Exception
        End Try
        CargarSala(codigo)
        If ID_SALA.HasValue Then
            RaiseEvent SalaSeleccionada(ID_SALA)
        End If
    End Sub

    Private Sub btn_Deseleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Deseleccionar.Click
        Dim oldId As Nullable(Of Integer) = Nothing
        If Not Sala Is Nothing Then
            oldId = Sala.ID_SALA
            RaiseEvent SalaEliminada(oldId)
        End If
        Sala = Nothing
        CargarSala(Nothing)


    End Sub
End Class
