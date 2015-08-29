Public Class frmAgrupador

    Private _agrupador As Agrupador
    Public Property Agrupador() As Agrupador
        Get
            Return _agrupador
        End Get
        Set(ByVal value As Agrupador)
            _agrupador = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        _agrupador = New Agrupador()
        _agrupador.Nombre = txtNombre.Text
        _agrupador.NoColumnas = txtColumn.Text
        _agrupador.Filas = txtRow.Text

        Me.Close()
    End Sub

    Private Sub frmAgrupador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not _agrupador Is Nothing Then
            txtNombre.Text = _agrupador.Nombre
            txtColumn.Text = _agrupador.NoColumnas
            txtRow.Text = _agrupador.Filas
        End If

    End Sub

End Class