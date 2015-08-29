Imports System.Math

Public Class frmHistorialPieza

    Public Pieza As Integer
    Public Odontograma As Integer
    Public oForm As frmOdontograma
    Private Sub frmHistorialPieza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarHistorial()
    End Sub
    Private Sub MostrarHistorial()
        Dim imgIdx As Integer
        lvw.SmallImageList = oForm.imgList
        pbx.Image = oForm.Odontograma1.PieceImage(Pieza)
        lblPieza.Text = "Pieza: " + Pieza.ToString()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim acciones As IEnumerable(Of md_d_Accion) = classOdontograma.GetAccionesByOdontograma(Odontograma)

        For Each accion As md_d_Accion In acciones
            If PiezaContenidaEn(Pieza, accion.PiezasInvolucradas) Then
                InsertInLVw(frmOdontograma.imgIndex.Realizado, accion.IDGabinete = -1, accion.FechaEjecucion, accion.md_ConceptoFra.DESCRIPCION, accion.Cuadrantes)
            End If
        Next

        Dim lineas As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineasPendientes(Odontograma)
        For Each pendiente As md_d_PresupuestoLinea In lineas
            If PiezaContenidaEn(Pieza, pendiente.PiezasInvolucradas) Then
                imgIdx = frmOdontograma.imgIndex.Confirmado
                If pendiente.Urgencia Then
                    imgIdx = frmOdontograma.imgIndex.ConfirmadoUrgente
                End If
                InsertInLVw(imgIdx, False, pendiente.FechaConfirmado, pendiente.md_ConceptoFra.DESCRIPCION, pendiente.Cuadrantes)
            End If
        Next

        lineas = classOdontograma.GetLineasSinConfirmar(Odontograma)
        For Each linea As md_d_PresupuestoLinea In lineas
            If PiezaContenidaEn(Pieza, linea.PiezasInvolucradas) Then
                imgIdx = frmOdontograma.imgIndex.LineaPresupuesto
                If linea.Urgencia Then
                    imgIdx = frmOdontograma.imgIndex.LineaPresupuestoUrgente
                End If
                InsertInLVw(imgIdx, False, linea.md_d_Presupuesto.FechaConcepcion, linea.md_ConceptoFra.DESCRIPCION, linea.Cuadrantes)
            End If
        Next
    End Sub
    Private Function PiezaContenidaEn(ByVal pieza As Integer, ByVal pieceNumbers As String) As Boolean
        Dim Found As Boolean = False

        If (pieceNumbers = "") Or (pieceNumbers = Nothing) Then
            Return False
        Else
            Dim lastIndex As Integer = 0 'ULTIMO INDEX EN LA CADENA
            Dim lastPiece As Integer = 0 'ULTIMA PIEZA CUANDO ES MULTIPLES
            Dim actualPiece As Integer = 0 'PIEZA ACTUAL

            For i As Integer = 0 To pieceNumbers.Length
                If (i = pieceNumbers.Length) OrElse (pieceNumbers(i) = ",") Then
                    actualPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    If lastPiece > 0 Then
                        If (actualPiece \ 10) = (lastPiece \ 10) Then
                            If (pieza >= Min(actualPiece, lastPiece)) And (pieza <= Max(actualPiece, lastPiece)) Then
                                Found = True
                                Exit For
                            End If
                        Else
                            If ((pieza >= ((lastPiece \ 10) * 10 + 1)) And (pieza <= lastPiece)) Or ((pieza >= ((actualPiece \ 10) * 10 + 1)) And (pieza <= actualPiece)) Then
                                Found = True
                                Exit For
                            End If
                        End If
                    Else
                        If pieza = actualPiece Then
                            Found = True
                            Exit For
                        End If
                    End If
                    lastPiece = 0
                    lastIndex = i + 1
                ElseIf pieceNumbers(i) = "-" Then
                    lastPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    lastIndex = i + 1
                End If
            Next
        End If
        Return Found
    End Function
    Private Sub InsertInLVw(ByVal imgidx As Integer, ByVal PV As Boolean, ByVal fecha As Date, ByVal tratamiento As String, ByVal cuadrantes As String)
        Dim LI As ListViewItem
        If PV = True Then
            LI = lvw.Items.Add("Primera visita")
        Else
            LI = lvw.Items.Add(Format(fecha, "dd/MM/yyyy"))
        End If
        LI.SubItems.Add(tratamiento)
        LI.SubItems.Add(cuadrantes)
        LI.ImageIndex = imgidx
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class