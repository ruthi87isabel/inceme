Partial Public Class Receta

    Public ReadOnly Property CodigoBarras() As Image
        Get

            'Dim db As New CMLinqDataContext
            Dim res As Image
            Dim obj As String
            If (Me.RecetasXML.Count = 1) Then
                obj = Me.RecetasXML(0).CVE

                Dim code As Zen.Barcode.Code128BarcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum

                res = code.Draw(obj.Trim, 70)
            End If
            Return res

        End Get
    End Property
    Public ReadOnly Property TieneFechaDispensacion() As Boolean
        Get
            If Me.FechaPrevistaDispensacion.HasValue Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
End Class
