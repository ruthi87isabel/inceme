Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Imaging
Imports Microsoft.VisualBasic.FileIO
Imports System.Math

Public Class Odontograma
    Inherits UserControl
    Private DD As Integer(,) = {{216, 189, 159, 131, 105, 73, 40, 0, 250, 284, 310, 340, 369, 394, 426, 459, 250, 277, 303, 334, 362, 391, 426, 461, 222, 197, 165, 137, 109, 73, 37, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189}, {250, 216, 189, 159, 131, 105, 73, 40, 284, 310, 340, 369, 394, 426, 459, 500, 277, 303, 334, 362, 391, 426, 461, 500, 250, 222, 197, 165, 137, 109, 73, 37}, {151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346}}
    Private DT As Integer(,) = {{210, 183, 153, 122, 89, 252, 286, 312, 341, 373, 252, 279, 305, 338, 373, 216, 191, 159, 122, 86}, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 189, 189, 189, 189, 189, 189, 189, 189, 189, 189}, {244, 210, 183, 154, 122, 286, 312, 342, 373, 406, 279, 305, 336, 373, 408, 244, 216, 191, 158, 122}, {151, 151, 151, 151, 151, 151, 151, 151, 151, 151, 346, 346, 346, 346, 346, 346, 346, 346, 346, 346}}
    Private LinkDent As Integer() = {0, 1, 2, 5, 6, 8, 9, 10, 13, 14, 16, 17, 18, 21, 22, 24, 25, 26, 29, 30}

    Protected lastclickedpiece As Integer
    Protected lasthoverpiece As Integer
    Protected denticiontemporal As Boolean
    Public Sub New()
        InitializeComponent()
        denticiontemporal = False
        lastclickedpiece = 0
        lasthoverpiece = 0
    End Sub
    Public ReadOnly Property ClickedPiece() As Integer
        Get
            Return lastclickedpiece
        End Get
    End Property
    Public ReadOnly Property HOverPiece() As Integer
        Get
            Return lasthoverpiece
        End Get
    End Property
    Public ReadOnly Property PieceImage(ByVal piece As Integer) As Image
        Get
            Dim units As GraphicsUnit = GraphicsUnit.Pixel
            Dim img As System.Drawing.Image

            Dim g As Graphics

            Dim destRect As Rectangle
            Dim posit As Integer
            If piece >= 50 Then
                posit = (((piece - 40) \ 10) - 1) * 5 + (piece Mod 10) - 1
                img = New System.Drawing.Bitmap(DT(2, posit) - DT(0, posit), DT(3, posit) - DT(1, posit))
                destRect = New Rectangle(0, 0, DT(2, posit) - DT(0, posit), DT(3, posit) - DT(1, posit))
                g = Graphics.FromImage(img)
                g.DrawImage(dent_temporal.Image, destRect, DD(0, LinkDent(posit)), DD(1, LinkDent(posit)), DD(2, LinkDent(posit)) - DD(0, LinkDent(posit)), DD(3, LinkDent(posit)) - DD(1, LinkDent(posit)), units)
                g.Dispose()
            Else
                posit = ((piece \ 10) - 1) * 8 + (piece Mod 10) - 1
                img = New System.Drawing.Bitmap(DD(2, posit) - DD(0, posit), DD(3, posit) - DD(1, posit))
                destRect = New Rectangle(0, 0, DD(2, posit) - DD(0, posit), DD(3, posit) - DD(1, posit))
                g = Graphics.FromImage(img)
                g.DrawImage(dent_definitiva.Image, destRect, DD(0, posit), DD(1, posit), DD(2, posit) - DD(0, posit), DD(3, posit) - DD(1, posit), units)
                g.Dispose()
            End If

            Return img
        End Get
    End Property
    Public ReadOnly Property getImage(ByVal temporal As Boolean) As Image
        Get
            Return picture.Image
        End Get
    End Property
    Public Property temporal_dentition() As Boolean
        Get
            Return denticiontemporal
        End Get
        Set(ByVal value As Boolean)
            If denticiontemporal <> value Then
                denticiontemporal = value
                Reset()
            End If
        End Set
    End Property
    Public Sub AddOperation(ByVal pieceNumbers As String, ByVal idimg As Integer, ByVal usingColor As Boolean, ByVal imgColor As Color)
        'POSICION DE LA PIEZA EN EL ARREGLO DE LAS COORDENADAS
        Dim g As Graphics = Graphics.FromImage(picture.Image)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel

        Dim tempImage As Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Inceme\Images\I" + idimg.ToString()) 'Image.FromStream(New MemoryStream(img))
        Dim imageAttributes As ImageAttributes = New ImageAttributes()
        'COLOR MATRIX PARA PINTAR
        If usingColor = True Then
            Dim ptsArray As Single()() = {New Single() {1, 0, 0, 0, 0}, New Single() {0, 1, 0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}}
            Dim clrMatrix As ColorMatrix = New ColorMatrix(ptsArray)
            clrMatrix.Matrix00 = imgColor.R / 255
            clrMatrix.Matrix10 = imgColor.R / 255
            clrMatrix.Matrix20 = imgColor.R / 255
            clrMatrix.Matrix01 = imgColor.G / 255
            clrMatrix.Matrix11 = imgColor.G / 255
            clrMatrix.Matrix21 = imgColor.G / 255
            clrMatrix.Matrix02 = imgColor.B / 255
            clrMatrix.Matrix12 = imgColor.B / 255
            clrMatrix.Matrix22 = imgColor.B / 255

            imageAttributes.SetColorMatrix(clrMatrix, ColorMatrixFlag.Default, ColorAdjustType.Default)
        End If

        'RECTANGULO DONDE DEBEN PEGARSE LAS IMAGENES
        Dim destRect As Rectangle
        
        'SI NO TIENE PIEZA ASOCIADO
        If (pieceNumbers = "") Or (pieceNumbers = Nothing) Then
            If denticiontemporal = True Then
                For i As Integer = 0 To 19
                    destRect = New Rectangle(DT(0, i), DT(1, i), DT(2, i) - DT(0, i), DT(3, i) - DT(1, i))
                    g.DrawImage(tempImage, destRect, DD(0, LinkDent(i)), DD(1, LinkDent(i)), DD(2, LinkDent(i)) - DD(0, LinkDent(i)), DD(3, LinkDent(i)) - DD(1, LinkDent(i)), units, imageAttributes)
                Next
            Else
                destRect = New Rectangle(0, 0, 500, 346)
                g.DrawImage(tempImage, destRect, 0, 0, 500, 346, units, imageAttributes)
            End If
            ' SI ES DENTICION DEFINITIVA
        ElseIf denticiontemporal = False Then
            'CONSTRUIR UN ARREGLO CON LOS RANGOS
            Dim arr_pos1 As Integer
            Dim arr_pos2 As Integer

            Dim piecePosNumber(15, 1) As Integer
            Dim aPos As Integer = 0 'POSICION ACTUAL
            Dim lastIndex As Integer = 0 'ULTIMO INDEX EN LA CADENA
            Dim lastPiece As Integer = 0 'ULTIMA PIEZA CUANDO ES MULTIPLES
            Dim actualPiece As Integer = 0 'PIEZA ACTUAL
            For i As Integer = 0 To pieceNumbers.Length
                If (i = pieceNumbers.Length) OrElse (pieceNumbers(i) = ",") Then
                    actualPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    arr_pos2 = ((actualPiece \ 10) - 1) * 8 + (actualPiece Mod 10) - 1
                    If lastPiece > 0 Then
                        arr_pos1 = ((lastPiece \ 10) - 1) * 8 + (lastPiece Mod 10) - 1
                        If DD(0, arr_pos1) > DD(0, arr_pos2) Then
                            piecePosNumber(aPos, 0) = arr_pos2
                            piecePosNumber(aPos, 1) = arr_pos1
                        Else
                            piecePosNumber(aPos, 0) = arr_pos1
                            piecePosNumber(aPos, 1) = arr_pos2
                        End If
                    Else
                        piecePosNumber(aPos, 0) = arr_pos2
                        piecePosNumber(aPos, 1) = arr_pos2
                    End If
                    aPos = aPos + 1
                    lastPiece = 0
                    lastIndex = i + 1
                ElseIf pieceNumbers(i) = "-" Then
                    lastPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    lastIndex = i + 1
                End If
            Next
            For i As Integer = 0 To aPos - 1
                destRect = New Rectangle(DD(0, piecePosNumber(i, 0)), DD(1, piecePosNumber(i, 0)), DD(2, piecePosNumber(i, 1)) - DD(0, piecePosNumber(i, 0)), DD(3, piecePosNumber(i, 0)) - DD(1, piecePosNumber(i, 0)))
                g.DrawImage(tempImage, destRect, DD(0, piecePosNumber(i, 0)), DD(1, piecePosNumber(i, 0)), DD(2, piecePosNumber(i, 1)) - DD(0, piecePosNumber(i, 0)), DD(3, piecePosNumber(i, 0)) - DD(1, piecePosNumber(i, 0)), units, imageAttributes)
            Next
            'ES DENTICION TEMPORAL
        Else
            'CONSTRUIR UN ARREGLO CON TODAS LAS PIEZAS
            Dim pieceNumber() As Integer = New Integer(19) {}
            Dim aPos As Integer = 0 'POSICION ACTUAL
            Dim lastIndex As Integer = 0 'ULTIMO INDEX EN LA CADENA
            Dim lastPiece As Integer = 0 'ULTIMA PIEZA CUANDO ES MULTIPLES
            Dim actualPiece As Integer = 0 'PIEZA ACTUAL
            For i As Integer = 0 To pieceNumbers.Length
                If (i = pieceNumbers.Length) OrElse (pieceNumbers(i) = ",") Then
                    actualPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    If lastPiece > 0 Then
                        If (actualPiece \ 10) = (lastPiece \ 10) Then
                            'ADICIONAR LAS PIEZAS COMPRENDIDAS
                            For k As Integer = Min(actualPiece, lastPiece) To Max(actualPiece, lastPiece)
                                pieceNumber(aPos) = k
                                aPos = aPos + 1
                            Next
                        Else
                            'ADICIONAR LAS PIEZAS ANTERIORES A LASTPIECE
                            For k As Integer = (lastPiece \ 10) * 10 + 1 To lastPiece
                                pieceNumber(aPos) = k
                                aPos = aPos + 1
                            Next
                            'ADICIONAR LAS PIEZAS ANTERIORES A ACTUALPIECE
                            For k As Integer = (actualPiece \ 10) * 10 + 1 To actualPiece
                                pieceNumber(aPos) = k
                                aPos = aPos + 1
                            Next
                        End If
                    Else
                        pieceNumber(aPos) = actualPiece
                        aPos = aPos + 1
                    End If
                    lastPiece = 0
                    lastIndex = i + 1
                ElseIf pieceNumbers(i) = "-" Then
                    lastPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    lastIndex = i + 1
                End If
            Next


            Dim arr_pos As Integer
            For i As Integer = 0 To aPos - 1
                arr_pos = (((pieceNumber(i) - 40) \ 10) - 1) * 5 + (pieceNumber(i) Mod 10) - 1
                destRect = New Rectangle(DT(0, arr_pos), DT(1, arr_pos), DT(2, arr_pos) - DT(0, arr_pos), DT(3, arr_pos) - DT(1, arr_pos))
                g.DrawImage(tempImage, destRect, DD(0, LinkDent(arr_pos)), DD(1, LinkDent(arr_pos)), DD(2, LinkDent(arr_pos)) - DD(0, LinkDent(arr_pos)), DD(3, LinkDent(arr_pos)) - DD(1, LinkDent(arr_pos)), units, imageAttributes)
            Next
        End If


        g.Dispose()
        picture.Refresh()
        Me.Invalidate()
    End Sub
    Private Function getPieceOn(ByVal X As Integer, ByVal Y As Integer) As Integer
        If denticiontemporal = True Then
            For i As Integer = 0 To 19
                If (X > DT(0, i)) And (Y > DT(1, i)) And (X < DT(2, i)) And (Y < DT(3, i)) Then
                    Return 40 + ((i \ 5) + 1) * 10 + (i Mod 5) + 1
                End If
            Next
            Return 0
        Else
            For i As Integer = 0 To 31
                If (X > DD(0, i)) And (Y > DD(1, i)) And (X < DD(2, i)) And (Y < DD(3, i)) Then
                    Return ((i \ 8) + 1) * 10 + (i Mod 8) + 1
                End If
            Next
            Return 0
        End If
    End Function
    Public Sub Reset()
        Dim g As Graphics = Graphics.FromImage(picture.Image)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel
        Dim tempImage As Image
        If denticiontemporal = True Then
            tempImage = dent_temporal.Image
        Else
            tempImage = dent_definitiva.Image
        End If
        Dim destRect As New Rectangle(0, 0, 500, 346)
        g.DrawImage(tempImage, destRect, 0, 0, 500, 346, units)
        g.Dispose()
        picture.Refresh()
    End Sub
    Private Sub picture_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picture.MouseDown
        lastclickedpiece = getPieceOn(e.X, e.Y)
        MyBase.OnMouseDown(e)
    End Sub
    Private Sub picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture.Click
        MyBase.OnClick(e)
    End Sub
    Private Sub picture_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picture.MouseMove
        lasthoverpiece = getPieceOn(e.X, e.Y)
        MyBase.OnMouseMove(e)
    End Sub
End Class
