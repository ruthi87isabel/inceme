Public Class frmColumna

    Private _columna As Columna
    Public Property Columna() As Columna
        Get
            Return _columna
        End Get
        Set(ByVal value As Columna)
            _columna = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        _columna.Caption = txtNombre.Text
        _columna.Column = txtColumn.Text
        _columna.Row = txtRow.Text
        _columna.ColSpan = txtColumnSpan.Text
        _columna.RowSpan = txtRowSpan.Text

        Me.Close()
    End Sub

    Private Sub frmColumna_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not _columna Is Nothing) Then
            txtNombre.Text = _columna.Caption
            txtColumn.Text = _columna.Column
            txtRow.Text = _columna.Row
            txtColumnSpan.Text = _columna.ColSpan
            txtRowSpan.Text = _columna.RowSpan
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class