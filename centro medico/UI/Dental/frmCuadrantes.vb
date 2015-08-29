Public Class frmCuadrantes
    Inherits Form
    Private cuadrantes As String() = {"Cervical", "Distal", "Vestibular", "Mesial", "Incisal", "Lingual"}
    Private paneles As Panel() = New Panel(8) {}
    Public pform As frmOdontograma
    Public Pieza As Integer

    Public Sub New()
        InitializeComponent()
        paneles(0) = pnl_C
        paneles(1) = pnl_D
        paneles(2) = pnl_V
        paneles(3) = pnl_M
        paneles(4) = pnl_I
        paneles(5) = pnl_L
        paneles(6) = pnl_D0
        paneles(7) = pnl_V0
        paneles(8) = pnl_M0
    End Sub
    Private Sub pnl_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl_C.Click, pnl_V0.Click, pnl_V.Click, pnl_M0.Click, pnl_M.Click, pnl_L.Click, pnl_I.Click, pnl_D0.Click, pnl_D.Click
        Dim repet As Char() = {"D"c, "V"c, "M"c}
        If TryCast(sender, Panel).BackColor = Color.FromName("White") Then
            TryCast(sender, Panel).BackColor = Color.FromName("DeepSkyBlue")
        Else
            TryCast(sender, Panel).BackColor = Color.FromName("White")
        End If
        If TryCast(sender, Panel).Name.Substring(4, 1).IndexOfAny(repet, 0) >= 0 Then
            If TryCast(sender, Panel).Name.Length = 5 Then
                paneles(Convert.ToInt32(TryCast(sender, Panel).Tag) + 5).BackColor = TryCast(sender, Panel).BackColor
            Else
                paneles(Convert.ToInt32(TryCast(sender, Panel).Tag)).BackColor = TryCast(sender, Panel).BackColor
            End If
        End If
        UpdateTxB()
    End Sub
    Private Sub UpdateTxB()
        TBx_Cuad.Clear()
        pform.cuadrantes = ""
        For i As Integer = 0 To 5
            If paneles(i).BackColor = Color.FromName("DeepSkyBlue") Then
                TBx_Cuad.Text += cuadrantes(i) & "  "
                pform.cuadrantes += cuadrantes(i)(0)
            End If
        Next
    End Sub

    Private Sub frmCuadrantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If (Pieza Mod 10) > 3 Then
        '    cuadrantes(4) = "Oclusal"
        '    label6.Text = "O"
        '    label6.Left = label6.Left - 5
        '    pictureBox2.Visible = False
        '    PictureBox3.Visible = True
        'End If
        'If ((Pieza \ 10) Mod 4) > 1 Then
        '    label2.Text = "M"
        '    label4.Text = "D"
        '    label9.Text = "M"
        '    label8.Text = "D"
        '    paneles(3) = pnl_D
        '    paneles(1) = pnl_M
        '    paneles(8) = pnl_D0
        '    paneles(6) = pnl_M0
        'End If
        If (Pieza Mod 10) > 3 Then
            cuadrantes(4) = "Oclusal"
            label6.Text = "O"
            label6.Left = label6.Left - 5
            pictureBox2.Visible = False
            PictureBox3.Visible = True
        End If
        If ((Pieza \ 10) Mod 4) > 1 Then
            label2.Text = "M"
            label4.Text = "D"
            label9.Text = "M"
            label8.Text = "D"
            paneles(3) = pnl_D
            paneles(1) = pnl_M
            paneles(8) = pnl_D0
            paneles(6) = pnl_M0
            pnl_D.Tag = 3
            pnl_M.Tag = 1
            pnl_D0.Tag = 3
            pnl_M0.Tag = 1
        End If

    End Sub
End Class