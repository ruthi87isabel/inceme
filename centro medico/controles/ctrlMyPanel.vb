Imports System.IO

Public Class ctrlMyPanel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaintBackground(e As System.Windows.Forms.PaintEventArgs)
        'MyBase.OnPaintBackground(e)
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), Me.ClientRectangle)

        If Not Me.BackgroundImage Is Nothing Then
            e.Graphics.DrawImage(Me.BackgroundImage, 10, 10)
        End If
    End Sub

    Public Function SaveToBitmap() As Bitmap
        Dim bitmap As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bitmap, Me.ClientRectangle)
        Return bitmap
    End Function

End Class
