Partial Public Class d_PresupuestoLinea
    Public ReadOnly Property descuentoPorcentaje()
        Get
            Dim res As Double = 0
            If Me.DescuentoPercent.HasValue And Me.DescuentoPercent.HasValue > 0 Then
                res = (100 * Me.DescuentoPercent) / CDbl(Me.Importe + Me.DescuentoPercent)
            End If
            Return res

        End Get
    End Property

End Class
