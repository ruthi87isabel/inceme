Public Class ctrlHotSpot


    Public ContainerClass As PointingSticker
    Public Title As String
    Public Brush As SolidBrush
    Public Pen As Pen = Pens.Red

    Public Event HotSpot_Updated(ByVal hotSpot As ctrlHotSpot)



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Brush = New SolidBrush(Pen.Color)

    End Sub

  
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        'e.Graphics.DrawEllipse(Pens.Red, 0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.FillEllipse(Brush, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Public ReadOnly Property Vertix As Point
        Get
            Return New Point(Me.Left + Me.Width / 2, Me.Top + Me.Height / 2)
        End Get
    End Property

    Private Sub ctrlHotSpot_LocationChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.LocationChanged
        RaiseEvent HotSpot_Updated(Me)
    End Sub

   
    Private Sub ctrlHotSpot_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter
        ContainerClass.ParentContainer.DisplayHint("Arrastre el punto para recolocarlo")
    End Sub

    Private Sub ctrlHotSpot_MouseLeave(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseLeave
        ContainerClass.ParentContainer.DisplayHint("")
    End Sub
End Class
