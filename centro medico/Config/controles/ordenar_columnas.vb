Public Class ordenar_columnas

    Private Sub bt_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_up.Click

        If lbx_columnas.Items.Count > 0 And lbx_columnas.SelectedIndex > -1 Then
            'Se guarda la posicion seleccionada
            Dim _pos_seleccionada As Integer = lbx_columnas.SelectedIndex

            If _pos_seleccionada > 0 Then
                'Se elimina el valor seleccionado de su posicion y se inserta en una posicion menor
                Dim _valor_selecionado As String = lbx_columnas.SelectedItem
                lbx_columnas.Items.RemoveAt(_pos_seleccionada)
                lbx_columnas.Items.Insert(_pos_seleccionada - 1, _valor_selecionado)
                lbx_columnas.SelectedIndex = _pos_seleccionada - 1
            End If

        End If

    End Sub

    Private Sub bt_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_down.Click
        If lbx_columnas.Items.Count > 0 And lbx_columnas.SelectedIndex > -1 Then
            'Se guarda la posicion seleccionada
            Dim _pos_seleccionada As Integer = lbx_columnas.SelectedIndex

            If _pos_seleccionada < lbx_columnas.Items.Count - 1 Then
                'Se elimina el valor seleccionado de su posicion y se inserta en una posicion menor
                Dim _valor_selecionado As String = lbx_columnas.SelectedItem
                lbx_columnas.Items.RemoveAt(_pos_seleccionada)
                lbx_columnas.Items.Insert(_pos_seleccionada + 1, _valor_selecionado)
                lbx_columnas.SelectedIndex = _pos_seleccionada + 1
            End If
        End If
    End Sub

    Public WriteOnly Property AdicionaColumna() As String
        Set(ByVal Value As String)
            If Value <> "" Then
                lbx_columnas.Items.Add(Value)
            End If
        End Set
    End Property

    Public WriteOnly Property Titulo() As String
        Set(ByVal Value As String)
            If Value <> "" Then
                lb_titulo.Text = Value
            End If
        End Set
    End Property

    Public ReadOnly Property NombresColumnas() As ListBox.ObjectCollection
        Get
            Return lbx_columnas.Items
        End Get
    End Property

End Class
