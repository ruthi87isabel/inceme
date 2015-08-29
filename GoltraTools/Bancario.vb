Public Class Bancario
    Public Shared Function DimeIBAN(ByVal NumeroCuenta As String) As String

        Dim ParteCuenta As String
        Dim ProximosNumeros As Integer
        'Limpio el numero de cuenta primero
        NumeroCuenta = NumeroCuenta.Replace("-", "")
        NumeroCuenta = NumeroCuenta.Replace(" ", "")
        NumeroCuenta = NumeroCuenta.Replace(".", "")
        NumeroCuenta = NumeroCuenta.Replace("/", "")

        
        'Módulo de los primeros 9 digitos
        ParteCuenta = String.Format("{0:00}", CInt(NumeroCuenta.Substring(0, 9)) Mod 97)

        ' Cogemos otro grupo de digitos de la cuenta
        NumeroCuenta = NumeroCuenta.Substring(9, NumeroCuenta.Length - 9)

        ' Recorremos la cuenta hasta el final
        While NumeroCuenta <> ""

            If CInt(ParteCuenta) < 10 Then

                ProximosNumeros = 8
            Else

                ProximosNumeros = 7
            End If

            If NumeroCuenta.Length < ProximosNumeros Then

                ParteCuenta = ParteCuenta & NumeroCuenta
                NumeroCuenta = ""

            Else

                ParteCuenta = ParteCuenta & NumeroCuenta.Substring(0, ProximosNumeros)

                NumeroCuenta = NumeroCuenta.Substring(ProximosNumeros, NumeroCuenta.Length - ProximosNumeros)

            End If

            ParteCuenta = String.Format("{0:00}", ParteCuenta Mod 97)

        End While

        Return "ES" & String.Format("{0:00}", 98 - ParteCuenta)

    End Function
End Class
