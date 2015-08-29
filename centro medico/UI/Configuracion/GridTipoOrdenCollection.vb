Imports System.Linq

Public Class GridTipoOrdenCollection
    Inherits List(Of IGridTipoOrden)

    Public ReadOnly Property MaxRow() As Integer
        Get
            If Count = 0 Then Return 0

            Dim max As Integer = 0

            For index As Integer = 0 To Me.Count - 1
                If (TypeOf (Me(index)) Is Agrupador) Then
                    If (max < CType(Me(index), Agrupador).Filas) Then max = CType(Me(index), Agrupador).Filas
                End If
            Next

            Return max
        End Get
    End Property

    Public Function ExisteColumna(ByVal key As String)
        For index As Integer = 0 To Me.Count - 1
            If (TypeOf (Me(index)) Is Agrupador) Then
                If (CType(Me(index), Agrupador).Columnas.Any(Function(col) col.Key = key)) Then Return True
            Else
                If (CType(Me(index), Columna).Key = key) Then Return True
            End If
        Next

        Return False
    End Function

    Public Sub EliminaColumna(ByVal key As String)
        Dim columnIndex As Integer = -1
        For i As Integer = 0 To Me.Count - 1
            If (TypeOf (Me(i)) Is Agrupador) Then
                'Agrupador
                Dim _agrupador As Agrupador = CType(Me(i), Agrupador)

                If (_agrupador.Columnas.Any(Function(col) col.Key = key)) Then
                    For j As Integer = 0 To _agrupador.Columnas.Count - 1
                        If (_agrupador.Columnas(j).Key = key) Then
                            columnIndex = j
                            Exit For
                        End If
                    Next

                    If (columnIndex > -1) Then
                        _agrupador.Columnas.RemoveAt(columnIndex)
                        Exit For
                    End If
                End If
            Else
                'Columna
                If (CType(Me(i), Columna).Key = key) Then
                    RemoveAt(i)
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Function ExisteColumnSet(ByVal index As Integer)
        For i As Integer = 0 To Me.Count - 1
            If (TypeOf (Me(i)) Is Agrupador) Then
                If ((CType(Me(i), Agrupador).Index = index)) Then Return True
            End If
        Next

        Return False
    End Function

    Public Sub AgregaColumnaAgrupador(ByVal col As Columna, ByVal index As Integer)
        For i As Integer = 0 To Me.Count - 1
            If (TypeOf (Me(i)) Is Agrupador) Then
                If (CType(Me(i), Agrupador).Index = index) Then CType(Me(i), Agrupador).Columnas.Add(col)
            End If
        Next
    End Sub

    Public Function ContieneAgrupadores() As Boolean
        For i As Integer = 0 To Me.Count - 1
            If (TypeOf (Me(i)) Is Agrupador) Then Return True
        Next

        Return False
    End Function

    Sub MoveColumnSet(index As Integer, position As Integer)

        Dim indexInCollection As Integer = -1

        For i As Integer = 0 To Me.Count - 1
            If TypeOf (Me(i)) Is Agrupador Then
                If CType(Me(i), Agrupador).Index = index Then
                    indexInCollection = i
                    Exit For
                End If
            End If
        Next

        Try
            If (indexInCollection = -1) Then Exit Sub

            Dim tmpAgrupador As Agrupador = Me(indexInCollection)
            RemoveAt(indexInCollection)
            Me.Insert(indexInCollection + position, tmpAgrupador)

        Catch ex As Exception
        End Try


    End Sub

    Sub MoveColumn(key As String, position As Integer)

        If Me.Count > 0 Then
            If TypeOf (Me(0)) Is Agrupador Then Exit Sub
        End If

        Dim indexInCollection As Integer = -1

        For i As Integer = 0 To Me.Count - 1
            If TypeOf (Me(i)) Is Columna Then
                If CType(Me(i), Columna).Key = key Then
                    indexInCollection = i
                    Exit For
                End If
            End If
        Next

        Try
            If (indexInCollection = -1) Then Exit Sub

            Dim tmpColumna As Columna = Me(indexInCollection)
            RemoveAt(indexInCollection)
            Me.Insert(indexInCollection + position, tmpColumna)

        Catch ex As Exception
        End Try

    End Sub

End Class