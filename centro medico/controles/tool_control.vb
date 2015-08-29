
Imports System.IO
Public Class tool_control
    Dim familyfont As FontFamily = FontFamily.GenericSansSerif
    Dim fontsize As Single = Globales.Configuracion.TamanoFuente
    Private Sub ts_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_open.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim _doc As String = OpenFileDialog1.FileName
            Dim _Sr As StreamReader = New StreamReader(_doc)
            Dim _texto As String = _Sr.ReadToEnd()
            rtb_texto.Text = _texto.Trim()
        End If
    End Sub


    Public Property [ReadOnly]
        Get
            Return rtb_texto.ReadOnly
        End Get
        Set(value)
            rtb_texto.ReadOnly = value
            ts_open.Enabled = Not value
            ts_cut.Enabled = Not value
            ts_paste.Enabled = Not value
            ts_bold.Enabled = Not value
            ts_italic.Enabled = Not value
            ts_bold.Enabled = Not value

            ts_font.Enabled = Not value
            ts_underline.Enabled = Not value
            ts_left.Enabled = Not value
            ts_center.Enabled = Not value
            ts_rigth.Enabled = Not value

        End Set
    End Property


    Private Sub ts_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_save.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtb_texto.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ts_cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_cut.Click
        rtb_texto.Cut()
    End Sub

    Private Sub ts_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_copy.Click
        rtb_texto.Copy()
    End Sub

    Private Sub ts_paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_paste.Click
        rtb_texto.Paste()
    End Sub

    Private Sub ts_font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_font.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtb_texto.SelectionFont = FontDialog1.Font()
            fontsize = FontDialog1.Font.Size
            familyfont = FontDialog1.Font.FontFamily
        End If
    End Sub

    Private Sub ts_left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_left.Click
        rtb_texto.SelectionAlignment = HorizontalAlignment.Left
        ts_center.Checked = False
        ts_rigth.Checked = False
        ts_left.Checked = True
    End Sub

    Private Sub ts_center_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_center.Click
        rtb_texto.SelectionAlignment = HorizontalAlignment.Center
        ts_center.Checked = True
        ts_rigth.Checked = False
        ts_left.Checked = False
    End Sub

    Private Sub ts_rigth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_rigth.Click
        rtb_texto.SelectionAlignment = HorizontalAlignment.Right
        ts_center.Checked = False
        ts_rigth.Checked = True
        ts_left.Checked = False
    End Sub

    Private Sub ts_bold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_bold.Click
        If ts_bold.Checked = True Then
            If ts_underline.Checked = True Then
                If ts_italic.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Italic)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline)
                End If
            ElseIf ts_italic.Checked = True Then
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Regular)
            End If
            ts_bold.Checked = False
        Else
            If ts_underline.Checked = True Then
                If ts_italic.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Italic Or FontStyle.Bold)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Bold)
                End If
            ElseIf ts_italic.Checked = True Then

                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold Or FontStyle.Italic)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold)

            End If
            ts_bold.Checked = True
        End If
        rtb_texto.Update()
    End Sub

    Private Sub ts_italic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_italic.Click
        If ts_italic.Checked = True Then
            If ts_underline.Checked = True Then
                If ts_bold.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Bold)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline)
                End If
            ElseIf ts_bold.Checked = True Then
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Regular)
            End If
            ts_italic.Checked = False
        Else
            If ts_underline.Checked = True Then
                If ts_bold.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Italic Or FontStyle.Bold)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Italic)
                End If
            ElseIf ts_bold.Checked = True Then
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Bold)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic)

            End If
            ts_italic.Checked = True
        End If
    End Sub

    Private Sub ts_underline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_underline.Click
        If ts_underline.Checked = True Then
            If ts_bold.Checked = True Then
                If ts_italic.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold Or FontStyle.Italic)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold)
                End If
            ElseIf ts_italic.Checked = True Then
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Regular)
            End If
            ts_underline.Checked = False
        Else
            If ts_bold.Checked = True Then
                If ts_italic.Checked = True Then
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Italic Or FontStyle.Bold)
                Else
                    rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Bold)
                End If
            ElseIf ts_italic.Checked = True Then
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Underline)
            Else
                rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline)
            End If
            ts_underline.Checked = True
        End If
    End Sub

    Private Sub rtb_texto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ts_underline.Checked = True And ts_italic.Checked = True And ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic)
        ElseIf ts_bold.Checked = True And ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold Or FontStyle.Underline)
        ElseIf ts_italic.Checked = True And ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Bold)
        ElseIf ts_italic.Checked = True And ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Underline)
        ElseIf ts_italic.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic)
        ElseIf ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline)
        ElseIf ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold)
        Else
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Regular)
        End If
    End Sub

    Private Sub rtb_texto_FontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ts_underline.Checked = True And ts_italic.Checked = True And ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic)
        ElseIf ts_bold.Checked = True And ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold Or FontStyle.Underline)
        ElseIf ts_italic.Checked = True And ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Bold)
        ElseIf ts_italic.Checked = True And ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic Or FontStyle.Underline)
        ElseIf ts_italic.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Italic)
        ElseIf ts_underline.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Underline)
        ElseIf ts_bold.Checked = True Then
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Bold)
        Else
            rtb_texto.SelectionFont = New Font(familyfont, fontsize, FontStyle.Regular)
        End If
    End Sub

    Public Property ControlText() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return rtb_texto.Rtf
        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            Try
                rtb_texto.Rtf = Value
            Catch ex As Exception
                'Esto es por los textos que no son validos RTF
                rtb_texto.Text = Value
            End Try

        End Set
    End Property


    Private Sub tool_control_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        familyfont = FontFamily.GenericSansSerif
        'fontsize = 12
    End Sub
End Class
