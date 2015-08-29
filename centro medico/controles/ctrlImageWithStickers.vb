Imports System.Xml.Linq

Public Class ctrlImageWithStickers


    Public Stickers As New List(Of PointingSticker)

    Dim seleccionadoPunto As Boolean = False
    Public Event Sticker_BeforeInsert(ByRef data As LCOMPARATIVAS_TRATAMIENTO, ByRef cancel As Boolean)
    Public Event Sticker_Inserted(ByRef data As LCOMPARATIVAS_TRATAMIENTO)
    Public Event StickerSelected(ByVal sticker As ctrlSticker)
    Public Event StickerDeleted(ByVal sticker As ctrlSticker)

    Public Event StickerDeselected(ByVal sticker As ctrlSticker)
    Public Event StickerUpdated(ByVal sticker As ctrlSticker)

    Public Event ImageChanged(ByVal img() As Byte)

    Public SelectedSticker As ctrlSticker = Nothing


    Dim originalWidth As Integer
    Dim originalHeight As Integer




    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        Me.tsbQuitarImagen.Visible = False
        originalWidth = CtrlMyPanel1.Width
        originalHeight = CtrlMyPanel1.Height
    End Sub

#Region "Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles CtrlMyPanel1.Paint"
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles CtrlMyPanel1.Paint
        'Pintar HotSpots
        For Each sticker As PointingSticker In Stickers
            sticker.Paint(sender, e)
        Next
    End Sub
#End Region


    Private Sub btnAnnadir_Click(sender As System.Object, e As System.EventArgs) Handles tstAnnadir.Click
        lblInfo.Text = "Marque un punto en la imagen. Presione Esc para cancelar"
        CtrlMyPanel1.Cursor = Cursors.Cross
        seleccionadoPunto = True
    End Sub

    Private Sub Panel1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles CtrlMyPanel1.MouseUp
        If seleccionadoPunto Then

            Dim data As New LCOMPARATIVAS_TRATAMIENTO
            Dim cancel As Boolean = False

            RaiseEvent Sticker_BeforeInsert(data, cancel)
            If cancel Then
                seleccionadoPunto = False
                CtrlMyPanel1.Cursor = Cursors.Default
                Return
            Else
                Dim sticker As PointingSticker = AddPointer(e.X, e.Y, data)
                data.Layout = sticker.SaveLayout
                RaiseEvent Sticker_Inserted(data)
            End If

        End If
    End Sub

    Public Function AddPointer(ByRef Data As LCOMPARATIVAS_TRATAMIENTO) As PointingSticker
        Dim sticker As New PointingSticker(CtrlMyPanel1, Pens.Red, Me)

        sticker.Tratamiento = Data
        sticker.Sticker.Title1 = Data.Tratamiento _
                                & vbCrLf & _
                                Data.Valor_Unidad & " " & Data.Unidad _
                                & vbCrLf & _
                                Data.Comentarios

        If Not Data Is Nothing Then
            sticker.Sticker.FechaSeg = "F. Seg: " & Data.LCOMPARATIVA.FECHA.Value.ToShortDateString()
        End If

        Stickers.Add(sticker)

        sticker.LoadLayout(Data.Layout)
        seleccionadoPunto = False
        CtrlMyPanel1.Cursor = Cursors.Default
        'dragControl1.DesignMode(True)
        CtrlMyPanel1.Invalidate()
        lblInfo.Text = ""

        AddHandler sticker.StickerSelected, AddressOf Sticker_Selected
        AddHandler sticker.StickerDeselected, AddressOf Sticker_Deselected
        AddHandler sticker.StickerUpdated, AddressOf Sticker_Updated

        Return sticker
    End Function

    Public Function AddPointer(ByVal x As Integer, ByVal y As Integer, ByRef data As LCOMPARATIVAS_TRATAMIENTO) As PointingSticker
        Dim sticker As New PointingSticker(x, y, CtrlMyPanel1, Pens.Red, Me)

        sticker.Tratamiento = data
        sticker.Sticker.Title1 = data.Tratamiento _
                                & vbCr & _
                                data.Valor_Unidad & " " & data.Unidad _
                                & vbCrLf & vbCrLf & _
                                data.Comentarios

        If Not data Is Nothing Then
            sticker.Sticker.FechaSeg = "F Seg: " & data.LCOMPARATIVA.FECHA.Value.ToShortDateString()
        End If

        Stickers.Add(sticker)

        seleccionadoPunto = False
        CtrlMyPanel1.Cursor = Cursors.Default
        'dragControl1.DesignMode(True)
        CtrlMyPanel1.Invalidate()
        lblInfo.Text = ""

        AddHandler sticker.StickerSelected, AddressOf Sticker_Selected
        AddHandler sticker.StickerDeselected, AddressOf Sticker_Deselected
        AddHandler sticker.StickerUpdated, AddressOf Sticker_Updated

        Return sticker

    End Function

    Public Sub DisplayHint(msg As String)
        lblInfo.Text = msg
    End Sub

    Public Function GetHint() As String
        Return lblInfo.Text
    End Function

    Protected Sub Sticker_Selected(ByVal sticker As ctrlSticker)
        SelectedSticker = sticker
        tstEliminar.Enabled = True
        RaiseEvent StickerSelected(sticker)
    End Sub

    Private Sub Sticker_Deselected(ByVal sticker As ctrlSticker)
        SelectedSticker = Nothing
        RaiseEvent StickerDeselected(sticker)
    End Sub

    Private Sub Sticker_Updated(ByVal sticker As ctrlSticker)
        RaiseEvent StickerUpdated(sticker)
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tstEliminar.Click

        If Not SelectedSticker Is Nothing Then
            Dim color As Color = SelectedSticker.BackColor
            SelectedSticker.BackColor = Drawing.Color.Red
            If MessageBox.Show("¿Desea eliminar el tratamiento seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                SelectedSticker.BackColor = color
                RaiseEvent StickerDeleted(SelectedSticker)
                CtrlMyPanel1.Refresh()
            End If

        End If
    End Sub


    Public Property BackIMAGE As Image
        Get
            Return CtrlMyPanel1.BackgroundImage
        End Get
        Set(value As Image)
            CtrlMyPanel1.BackgroundImage = value
        End Set
    End Property

#Region "Private Sub btnCambiarImagen_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarImagen.Click"
    Private Sub btnCambiarImagen_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarImagen.Click

        Dim frm As New frm_BancoImag_Galeria
        If frm.ShowDialog() = DialogResult.OK Then
            CtrlMyPanel1.BackgroundImage = Image.FromFile(frm.SelectedImagePath)
            Dim ms As New IO.MemoryStream()
            CtrlMyPanel1.BackgroundImage.Save(ms, CtrlMyPanel1.BackgroundImage.RawFormat)
            RaiseEvent ImageChanged(ms.ToArray)
        End If
        'Dim frm As New OpenFileDialog
        'If frm.ShowDialog() Then
        '    Dim stream As IO.FileStream = Nothing
        '    Try
        '        stream = New IO.FileStream(frm.FileName, IO.FileMode.Open, IO.FileAccess.Read)
        '        Dim arr(stream.Length) As Byte
        '        stream.Read(arr, 0, stream.Length)
        '        CtrlMyPanel1.BackgroundImage = Image.FromStream(stream)
        '        RaiseEvent ImageChanged(arr)
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    Finally
        '        If Not stream Is Nothing Then
        '            stream.Close()
        '        End If
        '    End Try
        'End If
    End Sub
#End Region

#Region "Sub Clear()"
    Sub Clear()

        For Each sticker As PointingSticker In Stickers
            sticker.Dispose()
        Next
        tstEliminar.Enabled = False
        SelectedSticker = Nothing
        Stickers.Clear()
        CtrlMyPanel1.Refresh()
    End Sub
#End Region

    Sub ResaltaStickersWithParentID(p1 As Integer)
        For Each s As PointingSticker In Stickers
            If s.Tratamiento.ID_LCOMPARATIVA = p1 Then
                s.Sticker.BackColor = SystemColors.Highlight
                s.HotSpot.Brush = Brushes.Blue
            Else
                s.Sticker.BackColor = System.Drawing.Color.DimGray
                s.HotSpot.Brush = Brushes.Red
            End If
        Next
        Me.CtrlMyPanel1.Refresh()
    End Sub

    Private Sub CtrlMyPanel1_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CtrlMyPanel1.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            CtrlMyPanel1.Cursor = Cursors.Default
            seleccionadoPunto = False
        End If
    End Sub

   

    Private Sub btnAnnadir_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Escape Then
            CtrlMyPanel1.Cursor = Cursors.Default
            seleccionadoPunto = False
            lblInfo.Text = ""
        End If
    End Sub

    Private Sub ctrlImageWithStickers_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        'Recorrer todos los puntos y cambiarlos de posicion




    End Sub

    Private Sub ctrlImageWithStickers_SizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.SizeChanged

        'For Each p As PointingSticker In Stickers

        '    'p.HotSpot.Left = CtrlMyPanel1.BackgroundImage.Width * p.HotSpot.Left / CtrlMyPanel1.Width
        '    'p.HotSpot.Top = CtrlMyPanel1.BackgroundImage.Height * p.HotSpot.Top / CtrlMyPanel1.Height

        '    p.HotSpot.Left = CtrlMyPanel1.Width * p.HotSpot.Left / originalWidth
        '    p.HotSpot.Top = CtrlMyPanel1.Height * p.HotSpot.Top / originalHeight

        '    p.Sticker.Left = CtrlMyPanel1.Width * p.Sticker.Left / originalWidth
        '    p.Sticker.Top = CtrlMyPanel1.Height * p.Sticker.Top / originalHeight


        'Next
        'originalWidth = CtrlMyPanel1.Width
        'originalHeight = CtrlMyPanel1.Height
    End Sub


    Public Function SaveToBitmap() As Bitmap
        Return CtrlMyPanel1.SaveToBitmap()
    End Function
    
    Private Sub tsbQuitarImagen_Click(sender As Object, e As EventArgs) Handles tsbQuitarImagen.Click
        CtrlMyPanel1.BackgroundImage = Nothing
    End Sub
End Class


Public Class PointingSticker

    Public HotSpot As ctrlHotSpot
    Public Sticker As ctrlSticker

    Public Tratamiento As LCOMPARATIVAS_TRATAMIENTO

    Private connector As Connector


    Public Event StickerSelected(ByVal sticker As ctrlSticker)
    Public Event StickerDeselected(ByVal sticker As ctrlSticker)
    Public Event StickerUpdated(ByVal sticker As ctrlSticker)


    Public Pen As Pen

    Public ParentContainer As ctrlImageWithStickers

    Public Sub New(ByVal container As Control, pen As Pen, parentContainer As ctrlImageWithStickers)

        Me.Pen = pen

        HotSpot = New ctrlHotSpot()
        HotSpot.ContainerClass = Me
        HotSpot.Pen = pen

        container.Controls.Add(HotSpot)

        Me.ParentContainer = parentContainer

        Sticker = New ctrlSticker()
       
        Sticker.Pen = pen

        Sticker.ContainerClass = Me
        container.Controls.Add(Sticker)

        connector = New Connector()
        connector.Source = Sticker
        connector.Target = HotSpot
        'connector.Pen = pen

        'Dim r As New Random
        'Dim x As Integer = r.Next(10, container.Width - Sticker.Width - 10)
        'Dim y As Integer = r.Next(10, container.Height - Sticker.Height - 10)

        'Sticker.Location = New Point(x, y)

        AddHandler Sticker.StickerSelected, AddressOf Sticker_Selected
        AddHandler Sticker.StickerDeselected, AddressOf Sticker_Deselected
        AddHandler Sticker.StickerUpdated, AddressOf Sticker_Updated
        AddHandler HotSpot.HotSpot_Updated, AddressOf HotSpot_Updated

    End Sub


    Public Sub New(ByVal pointX As Integer, ByVal pointY As Integer, ByVal container As Control, ByVal pen As Pen, parentContainer As ctrlImageWithStickers)
        Me.New(container, pen, parentContainer)
        HotSpot.Location = New Point(pointX, pointY)

        Dim r As New Random
        Dim x As Integer = r.Next(10, container.Width - Sticker.Width - 10)
        Dim y As Integer = r.Next(10, container.Height - Sticker.Height - 10)

        Sticker.Location = New Point(x, y)
        Sticker.ContainerClass = Me

    End Sub

    Public Sub Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        connector.Paint(sender, e)
    End Sub

    Protected Sub Sticker_Selected(ByVal sticker As ctrlSticker)
        RaiseEvent StickerSelected(sticker)
    End Sub

    Private Sub Sticker_Deselected(ByVal sticker As ctrlSticker)

        RaiseEvent StickerDeselected(sticker)
    End Sub

    Private Sub Sticker_Updated(ByVal sticker As ctrlSticker)
        RaiseEvent StickerUpdated(sticker)
    End Sub

    Public Sub Dispose()
        'Me quito visualmente
        Sticker.Parent.Controls.Remove(HotSpot)
        Sticker.Parent.Controls.Remove(Sticker)

        HotSpot.Dispose()
        Sticker.Dispose()
    End Sub

    Public Sub DisplayHint(msg As String)
        ParentContainer.DisplayHint(msg)
    End Sub

    Public Function SaveLayout() As XElement
        'Retorna las coordenadas y dimensiones de 
        '- Sticker
        '- HotSpot

        'Salvare % en vez de coordenadas
        Dim xml As XElement = <Layout>
                                  <Sticker
                                      x=<%= Sticker.Left %>
                                      y=<%= Sticker.Top %>
                                      width=<%= Sticker.Width %>
                                      height=<%= Sticker.Height %>>
                                  </Sticker>
                                  <HotSpot
                                      x=<%= HotSpot.Left %>
                                      y=<%= HotSpot.Top %>
                                      width=<%= HotSpot.Width %>
                                      height=<%= HotSpot.Height %>>
                                  </HotSpot>
                              </Layout>

        Return xml
    End Function

    Public Sub LoadLayout(ByVal xml As XElement)
        ''Sticker.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom

        Sticker.Location = New Point(xml.<Sticker>.@x, xml.<Sticker>.@y)
        Sticker.Size = New Size(xml.<Sticker>.@width, xml.<Sticker>.@height)
        HotSpot.Location = New Point(xml.<HotSpot>.@x, xml.<HotSpot>.@y)
        HotSpot.Size = New Size(xml.<HotSpot>.@width, xml.<HotSpot>.@height)
        HotSpot.BringToFront()
    End Sub

    Private Sub HotSpot_Updated(ByVal hotSpot As ctrlHotSpot)
        RaiseEvent StickerUpdated(Sticker)
    End Sub

End Class



Public Class Connector

    Public Source As ctrlSticker
    Public Target As ctrlHotSpot
    Public Pen As Pen

    Public Sub New()
        Pen = New Pen(Color.Black, 2.0)
    End Sub

    Public Sub Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawLine(Pen, Source.Vertix, Target.Vertix)
    End Sub
End Class