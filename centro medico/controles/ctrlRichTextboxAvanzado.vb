Public Class ctrlRichTextboxAvanzado

    Private Sub tstAplicarPlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstAplicarPlantilla.Click
        Dim frm As New frmPlantillasdeTexto()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            Try
                Me.Rtf = frm.Plantilla.TEXTO
            Catch ex As Exception
                Me.Text = frm.Plantilla.TEXTO
            End Try
        End If

    End Sub



    Private Sub ctrlTextboxAvanzado_MultilineChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.MultilineChanged
        If Multiline = False Then
            Me.ContextMenuStrip = Nothing
        Else
            If ContextMenuStrip Is Nothing Then
                Me.ContextMenuStrip = ContextMenuStrip1
            End If
        End If
    End Sub

    Private Sub ctrlTextboxAvanzado_ReadOnlyChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.ReadOnlyChanged
        tstAplicarPlantilla.Enabled = Not Me.ReadOnly
        tstPegar.Enabled = Not Me.ReadOnly
        tstCortar.Enabled = Not Me.ReadOnly

    End Sub


    
    Private Sub tstCopiar_Click(sender As System.Object, e As System.EventArgs) Handles tstCopiar.Click
        'Clipboard.SetText(Me.SelectedText)
        Me.Copy()
    End Sub

    Private Sub tstCortar_Click(sender As System.Object, e As System.EventArgs) Handles tstCortar.Click
        Me.Cut()
        'If Me.SelectedText <> String.Empty Then
        '    Clipboard.SetText(Me.SelectedText)
        '    Me.Text = Me.Text.Remove(Me.Text.IndexOf(Me.SelectedText))
        'End If

    End Sub

    Private Sub tstPegar_Click(sender As System.Object, e As System.EventArgs) Handles tstPegar.Click
        'Me.Text = Me.Text.Insert(Me.Text.Length - 1, Clipboard.GetText())
        Me.Paste()
    End Sub
End Class
