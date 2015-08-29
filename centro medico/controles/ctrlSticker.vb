Public Class ctrlSticker


    Public ContainerClass As PointingSticker

    Public Event StickerSelected(ByVal sticker As ctrlSticker)
    Public Event StickerDeselected(ByVal sticker As ctrlSticker)
    Public Event StickerUpdated(ByVal sticker As ctrlSticker)

    Public Pen As Pen

    Public FechaSeg As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)

        DraggableExtensionModule.ControlExtension.Draggable(Me, True)


    End Sub


    Private Sub ctrlSticker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public ReadOnly Property Vertix As Point
        Get
            Return New Point(Me.Left + Me.Width / 2, Me.Top + Me.Height / 2)
        End Get
    End Property


    Public Property Title1 As String
        Get
            Return lblTitle1.Text
        End Get
        Set(value As String)
            lblTitle1.Text = value
        End Set
    End Property

    'Public Property FechaSeg As String
    '    Get
    '    End Get
    '    Set(value As String)
    '    End Set
    'End Property






    


   
    Private Sub ctrlSticker_Enter(sender As System.Object, e As System.EventArgs) Handles MyBase.Enter
        'Me.BackColor = SystemColors.Highlight
        RaiseEvent StickerSelected(Me)
    End Sub

    Private Sub ctrlSticker_Leave(sender As System.Object, e As System.EventArgs) Handles MyBase.Leave
        'Me.BackColor = System.Drawing.Color.DimGray
        'RaiseEvent StickerDeselected(Me)
    End Sub

   
    Dim _resizing As Boolean = False
    
    Private Sub Button1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        _resizing = True
    End Sub


    Private Sub Button1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        _resizing = False
        RaiseEvent StickerUpdated(Me)
    End Sub


    Private Sub Button1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If (_resizing) Then
            Me.Size = New Size(Me.Width + e.X,
                               Me.Height + e.Y)

            Dim invalidateRec As New Rectangle

            invalidateRec.X = Math.Min(ContainerClass.Sticker.Left,
                                       ContainerClass.HotSpot.Left)

            invalidateRec.Y = Math.Min(ContainerClass.Sticker.Top, ContainerClass.HotSpot.Top)

            invalidateRec.Width = Math.Max(ContainerClass.Sticker.Left + ContainerClass.Sticker.Width,
                                           ContainerClass.HotSpot.Left + ContainerClass.HotSpot.Width)

            invalidateRec.Height = Math.Max(ContainerClass.Sticker.Top + ContainerClass.Sticker.Height,
                                            ContainerClass.HotSpot.Top + ContainerClass.HotSpot.Height)



            Parent.Invalidate(invalidateRec)
            'Parent.Invalidate()
        End If

    End Sub

    Private Sub ctrlSticker_LocationChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.LocationChanged
        RaiseEvent StickerUpdated(Me)
    End Sub

    Dim oldMsg As String = ""
    Private Sub ctrlSticker_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter
        oldMsg = ContainerClass.ParentContainer.GetHint()
        ContainerClass.ParentContainer.DisplayHint("Arrastre para recolocarlo")
    End Sub

    Private Sub ctrlSticker_MouseLeave(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseLeave
        ContainerClass.ParentContainer.DisplayHint(oldMsg)
    End Sub


    Dim currentHeight As Integer = 60

    Private Sub pbExpand_Click(sender As System.Object, e As System.EventArgs) Handles pbExpand.Click
        If Me.Height = 36 Then
            Me.Height = currentHeight
        Else
            currentHeight = Me.Height
            Me.Height = 36
        End If
    End Sub

    Private Sub ctrlSticker_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawString(Me.FechaSeg, Me.Font, Brushes.White, 0, 0)
        'e.Graphics.DrawEllipse(Pens.Red, 0, 0, 10, 10)
    End Sub
End Class
