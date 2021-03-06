Imports System.IO
Imports System.Globalization

Public Class DocumentoN19

    Public CabeceraPresentador As CabeceraPresentador = New CabeceraPresentador()
    Public CabeceraOrdenante As CabeceraOrdenante = New CabeceraOrdenante()
    Public RegistrosIndividuales As New List(Of IndividualObligatorio)()
    Public TotalOrdenante As Total_Ordenante = New Total_Ordenante()
    Public Total_General As Total_General = New Total_General()
    Public Opcionales As New List(Of Opcional)()

    ' Gets a NumberFormatInfo associated with the en-US culture.

    Friend Shared Function parseaCadena(ByVal cadenas As String) As String
        Dim res As String
        res = cadenas.ToUpper
        res = res.Replace("´"c, " "c)
        res = res.Replace("'"c, " "c)
        res = res.Replace("Á"c, "A"c)
        res = res.Replace("É"c, "E"c)
        res = res.Replace("Í"c, "I"c)
        res = res.Replace("Ó"c, "O"c)
        res = res.Replace("Ú"c, "U"c)
        res = res.Replace("Ä"c, "A"c)
        res = res.Replace("Ë"c, "E"c)
        res = res.Replace("Ï"c, "I"c)
        res = res.Replace("Ö"c, "O"c)
        res = res.Replace("Ü"c, "U"c)
        res = res.Replace("Ñ"c, "N"c)
        res = res.Replace("/"c, "-"c)
        res = res.Replace("\"c, "-"c)
        res = res.Replace("_"c, "-"c)
        res = res.Replace(","c, " "c)
        Return res
    End Function
    Friend Shared Function FormateaDecimal(ByVal val As Double) As String
        Dim nfi As NumberFormatInfo = New CultureInfo("es-es", False).NumberFormat
        nfi.NumberDecimalSeparator = " "
        nfi.NumberGroupSeparator = ""
        Return val.ToString("N2", nfi).Replace(" ", "")
    End Function

#Region "Public Shared Function CalculaDC(ByVal entidad As String, ByVal oficina As String, ByVal numcuenta As String) As String"
    ''' <summary>
    ''' Calcula el numero de control DC, basado en entidad(4), oficina(4), y numcuenta (10)
    ''' </summary>
    ''' <param name="entidad">4 chars</param>
    ''' <param name="oficina">4 chars</param>
    ''' <param name="numcuenta">10 chars</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CalculaDC(ByVal entidad As String, ByVal oficina As String, ByVal numcuenta As String) As String
        If entidad.Length > 4 Then
            Throw New Exception("Entidad excede los 4 caracteres")
        End If
        If oficina.Length > 4 Then
            Throw New Exception("Oficina excede los 4 caracteres")
        End If

        If numcuenta.Length > 10 Then
            Throw New Exception("No. Cuenta excede los 10 caracteres")
        End If

        Try
            'Validacion de numeros
            Dim n As Int64 = Int64.Parse(entidad)
            n = Int64.Parse(oficina)
            n = Int64.Parse(numcuenta)
        Catch ex As Exception
            Throw New Exception("Error en los datos, entidad, oficina y numcuenta debe ser solo numericos")
        End Try

        'Ahora procedemos a calcular los digitos de control DC
        'La primera cifra del banco se multiplica por 4.
        'La segunda cifra del banco se multiplica por 8.
        'La tercera cifra del banco se multiplica por 5.
        'La cuarta cifra del banco se multiplica por 10.

        'La primera cifra de la entidad se multiplica por 9.
        'La segunda cifra de la entidad se multiplica por 7.
        'La tercera cifra de la entidad se multiplica por 3.
        'La cuarta cifra de la entidad se multiplica por 6.

        'Se suman todos los resultados obtenidos.
        'Se divide entre 11 y nos quedamos con el resto de la divisi�n.
        'A 11 le quitamos el resto anterior, y ese el el primer d�gito de control, con la salvedad de que si nos da 10, el d�gito es 1

        'Para obtener el segundo d�gito de control:
        'La primera cifra de la cuenta se multiplica por 1
        'La primera cifra de la cuenta se multiplica por 2
        'La primera cifra de la cuenta se multiplica por 4
        'La primera cifra de la cuenta se multiplica por 8
        'La primera cifra de la cuenta se multiplica por 5
        'La primera cifra de la cuenta se multiplica por 10
        'La primera cifra de la cuenta se multiplica por 9
        'La primera cifra de la cuenta se multiplica por 7
        'La primera cifra de la cuenta se multiplica por 3
        'La primera cifra de la cuenta se multiplica por 6
        'Se suman todos los resultados obtenidos.
        'Se divide entre 11 y nos quedamos con el resto de la divisi�n.
        'A 11 le quitamos el resto anterior, y ese el el segundo d�gito de control, con la salvedad de que si nos da 10, el d�gito es 1

        Dim o1 As Integer = Integer.Parse(entidad(0)) * 4
        Dim o2 As Integer = Integer.Parse(entidad(1)) * 8
        Dim o3 As Integer = Integer.Parse(entidad(2)) * 5
        Dim o4 As Integer = Integer.Parse(entidad(3)) * 10

        Dim e1 As Integer = Integer.Parse(oficina(0)) * 9
        Dim e2 As Integer = Integer.Parse(oficina(1)) * 7
        Dim e3 As Integer = Integer.Parse(oficina(2)) * 3
        Dim e4 As Integer = Integer.Parse(oficina(3)) * 6

        Dim suma1 As Integer = o1 + o2 + o3 + o4 + e1 + e2 + e3 + e4
        Dim resto1 As Integer = suma1 Mod 11

        Dim d1 As Integer = 11 - resto1

        If d1 = 10 Then
            d1 = 1
        ElseIf d1 = 11 Then
            d1 = 0
        End If

        Dim c1 As Integer = Integer.Parse(numcuenta(0)) * 1
        Dim c2 As Integer = Integer.Parse(numcuenta(1)) * 2
        Dim c3 As Integer = Integer.Parse(numcuenta(2)) * 4
        Dim c4 As Integer = Integer.Parse(numcuenta(3)) * 8
        Dim c5 As Integer = Integer.Parse(numcuenta(4)) * 5
        Dim c6 As Integer = Integer.Parse(numcuenta(5)) * 10
        Dim c7 As Integer = Integer.Parse(numcuenta(6)) * 9
        Dim c8 As Integer = Integer.Parse(numcuenta(7)) * 7
        Dim c9 As Integer = Integer.Parse(numcuenta(8)) * 3
        Dim c10 As Integer = Integer.Parse(numcuenta(9)) * 6

        Dim suma2 As Integer = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10
        Dim resto2 As Integer = suma2 Mod 11
        Dim d2 As Integer = 11 - resto2

        If d2 = 10 Then
            d2 = 1
        ElseIf d2 = 11 Then
            d2 = 0
        End If


        Return d1.ToString() & d2.ToString()

    End Function
#End Region

    Public Shared Function VerificaCuenta(ByVal cuenta As String) As Boolean
        Try
            If cuenta.Length <> 10 Then
                Return False
            End If
            Dim numero As Long = Long.Parse(cuenta)
            Return True
            'Dim dcCuenta As String = cuenta.Substring(8, 2)
            'Dim dc As String = CalculaDC(cuenta.Substring(0, 4), cuenta.Substring(4, 4), cuenta.Substring(10, 10))
            'Return (dcCuenta = cuenta)
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Overrides Function ToString() As String
        Dim s As String = CabeceraPresentador.ToString() & vbCrLf & CabeceraOrdenante.ToString() & vbCrLf
        Dim i As Integer = 0
        For i = 0 To RegistrosIndividuales.Count - 1
            s = s & RegistrosIndividuales(i).ToString & vbCrLf
            's = s & Opcionales(i).ToString & vbCrLf
        Next
        'For Each individual As IndividualObligatorio In RegistrosIndividuales
        '    s = s & individual.ToString() & vbCrLf
        'Next

        'For Each opcional As Opcional In Opcionales
        '    s = s & opcional.ToString() & vbCrLf
        'Next

        If Not TotalOrdenante Is Nothing Then
            s = s & TotalOrdenante.ToString() & vbCrLf
        End If

        s = s & Total_General.ToString() & vbCrLf
        Return s
    End Function

    Public Sub GeneraFichero(ByVal filename As String)


        Dim _fs As FileStream = File.Create(filename)
        Dim _sw As StreamWriter = New StreamWriter(_fs)
        _sw.Write(Me.ToString())
        _sw.Flush()
        _sw.Close()
        _fs.Close()
    End Sub
End Class

#Region "Public Class CabeceraPresentador"
Public Class CabeceraPresentador

#Region "Zona A"
    Dim A1 As String = "51"
    Dim A2 As String = "80"
    Public ReadOnly Property A()
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"
    
    Private _B1_NIF As String = "000000000"
    Private _B1_Sufijo As String = "000"

    ''' <summary>
    ''' Código de presentador, NIF, ajustado a la derecha
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los 9 caracteres")
            End If
            _B1_NIF = value
        End Set
    End Property

    ''' <summary>
    ''' Sufijo
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los 3")
            End If
            _B1_Sufijo = value
        End Set
    End Property

    
    Private _B2 As String = "ddMMyy"
    ''' <summary>
    ''' Fecha confeccion soporte
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B2() As String
        Get
            Return _B2
        End Get
        Set(ByVal value As String)
            _B2 = value
        End Set
    End Property


    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public B3 As String = "".PadLeft(6, " ")

    Public ReadOnly Property B() As String
        Get
            Return (_B1_NIF & _B1_Sufijo).PadLeft(12, "0") & B2 & B3
        End Get
    End Property


#End Region

#Region "Zona C"
    Private _C As String = "".PadLeft(40, " ")

    ''' <summary>
    ''' Nombre del cliente presentador
    ''' </summary>
    ''' <remarks></remarks>
    Public Property C() As String
        Get
            Return _C
        End Get
        Set(ByVal value As String)
            If value.Length > 40 Then
                Throw New Exception("Longitud de nombre excede los " & 40)
            End If
            _C = value.PadRight(40, " ")
        End Set
    End Property
#End Region

#Region "Zona D"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public D As String = "".PadLeft(20, " ")

#End Region

#Region "Zona E"
    Private _E1 As String = "0000"
    'Seccion E
    ''' <summary>
    ''' Entidad receptora
    ''' </summary>
    ''' <remarks></remarks>
    Public Property E1() As String
        Get
            Return _E1
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de E1 excede los " & 4)
            End If
            _E1 = value.PadLeft(4, "0")
        End Set
    End Property

    Private _E2 As String = "0000"

    'Seccion E2
    ''' <summary>
    ''' Oficina
    ''' </summary>
    ''' <remarks></remarks>
    Public Property E2() As String
        Get
            Return _E2
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de E1 excede los " & 4)
            End If
            _E2 = value.PadLeft(4, "0")
        End Set
    End Property


    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public E3 As String = "".PadLeft(12, " ")


    Public ReadOnly Property E()
        Get
            Return E1 & E2 & E3
        End Get
    End Property


#End Region

#Region "Zona F"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F As String = "".PadLeft(40, " ")
#End Region

#Region "Zona G"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public G As String = "".PadLeft(14, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F & G
    End Function


End Class
#End Region

#Region "Public Class CabeceraOrdenante"
Public Class CabeceraOrdenante

#Region "Zona A"
    Dim A1 As String = "53"
    Dim A2 As String = "80"

    Public ReadOnly Property A() As String
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"
    ''' <summary>
    ''' NIF, ajustado a la derecha
    ''' </summary>
    ''' <remarks></remarks>
    Private _B1_NIF As String = "000000000"

    ''' <summary>
    ''' Sufijo
    ''' </summary>
    ''' <remarks></remarks>
    Private _B1_Sufijo As String = "000"

    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los " & 9)
            End If
            _B1_NIF = value
        End Set
    End Property

    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los " & 3)
            End If
            _B1_Sufijo = value
        End Set
    End Property

    Public ReadOnly Property B() As String
        Get
            Return (_B1_NIF & _B1_Sufijo).PadLeft(12, "0") & B2 & B3
        End Get
    End Property


    ''' <summary>
    ''' Fecha de confección del fichero. En formato DDMMAA
    ''' </summary>
    ''' <remarks></remarks>
    Public B2 As String = "ddMMyy"

    ''' <summary>
    ''' Fecha de cargo. Fecha a partir de la cual la Entidad 
    ''' domiciliataria debe efectuar los adeudos en las cuentas de sus clientes. En formato DDMMAA. 
    ''' </summary>
    ''' <remarks></remarks>
    Public B3 As String = "ddMMyy"

#End Region

#Region "Zona C"
    Private _C As String = "".PadLeft(40, " ")

    ''' <summary>
    ''' Nombre del cliente ordenante
    ''' </summary>
    ''' <remarks></remarks>
    Public Property C() As String
        Get
            Return _C
        End Get
        Set(ByVal value As String)
            If value.Length > 40 Then
                Throw New Exception("Longitud de nombre excede los " & 40)
            End If
            _C = value.PadRight(40, " ")
        End Set
    End Property
#End Region

#Region "Zona D"

    Private _D1 As String = "0000"
    Private _D2 As String = "0000"
    Private _D3 As String = "00"
    Private _D4 As String = "0000000000"


    ''' <summary>
    ''' Entidad, 4 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D1() As String
        Get
            Return _D1
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de excede los " & 4)
            End If
            _D1 = value.PadRight(4, "0")
        End Set
    End Property

    ''' <summary>
    ''' Oficina, 4 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D2() As String
        Get
            Return _D2
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de excede los " & 4)
            End If
            _D2 = value.PadRight(4, "0")
        End Set
    End Property

    ''' <summary>
    ''' DC, 2 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D3() As String
        Get
            Return _D3
        End Get
        Set(ByVal value As String)
            If value.Length > 2 Then
                Throw New Exception("Longitud de excede los " & 2)
            End If
            _D3 = value.PadRight(2, "0")
        End Set
    End Property

    ''' <summary>
    ''' Numero de cuenta, 10 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D4() As String
        Get
            Return _D4
        End Get
        Set(ByVal value As String)
            If value.Length > 10 Then
                Throw New Exception("Longitud de excede los " & 10)
            End If
            _D4 = value.PadRight(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' C C C de Abono, deben estar correctamente asignados D1, D2, D3, D4
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property D() As String
        Get
            Return D1 & D2 & D3 & D4
        End Get
    End Property

#End Region

#Region "Zona E"
    Private _E1 As String = "".PadLeft(8, " ")
    Private _E2 As String = "00"
    Private _E3 As String = "".PadLeft(10, " ")

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E1() As String
        Get
            Return _E1
        End Get
        Set(ByVal value As String)
            _E1 = value.PadLeft(8, " ")
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento de realización de adeudo, "01", si corresponde al "Primero". "02", si corresponde al "Segundo". 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E2() As String
        Get
            Return _E2
        End Get
        Set(ByVal value As String)
            If value <> "01" And value <> "02" Then Throw New Exception("Valores correctos son 01, y 02")
            _E2 = value
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E3() As String
        Get
            Return _E3
        End Get
        Set(ByVal value As String)
            _E3 = value
        End Set
    End Property

    ''' <summary>
    ''' Zona E, requiere los campos E1, E2, E3
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property E() As String
        Get
            Return E1 & E2 & E3
        End Get
    End Property

#End Region

#Region "Zona F"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F As String = "".PadLeft(40, " ")
#End Region

#Region "Zona G"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public G As String = "".PadLeft(14, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F & G
    End Function

End Class
#End Region

#Region "Public Class IndividualObligatorio"
Public Class IndividualObligatorio

#Region "Zona A"

    Dim A1 As String = "56"
    Dim A2 As String = "80"

    Public ReadOnly Property A() As String
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"

    Private _B1_NIF As String = "000000000"
    Private _B1_Sufijo As String = "000"

    ''' <summary>
    ''' NIF, ajustado a la derecha, Código del cliente ordenante. El mismo que figura en este 
    ''' campo en el Registro "Cabecera de ordenante".
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los 9")
            End If
            _B1_NIF = value
        End Set
    End Property

    ''' <summary>
    ''' Sufijo, mismo de la cabecera del ordenante
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los 3")
            End If

            If value.Trim() = "" Then
                Throw New Exception("Ha  de ser distinto de todo espacios!!")
            End If
            _B1_Sufijo = value
        End Set
    End Property


    Private _B2 As String = "".PadLeft(12, " ")

    ''' <summary>
    ''' Código de referencia. Según se indica en el apartado 
    ''' "REQUISITOS PREVIOS". Ha  de ser distinto de todo espacios y de todo cero
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B2() As String
        Get
            Return _B2
        End Get
        Set(ByVal value As String)
            _B2 = value.PadRight(12, " ")
        End Set
    End Property



    Public ReadOnly Property B()
        Get
            Return (B1_NIF & B1_Sufijo).PadLeft(12, "0") & B2
        End Get
    End Property

#End Region

#Region "Zona C"
    Private _C As String = "".PadLeft(40, " ")


    ''' <summary>
    ''' Nombre o razón social del titular de la domiciliación. Distinto de  
    '''  espacios. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property C() As String
        Get
            Return _C
        End Get
        Set(ByVal value As String)
            'parseo el value para que no contenga caracteres indebidos.
            value = DocumentoN19.parseaCadena(value)

            If value.Length > 40 Then
                value = value.Substring(0, 40)
                'Throw New Exception("Longitud de nombre excede los 40")
            End If
            If value.Trim() = "" Then
                Throw New Exception("Distinto de  todo espacios!!")
            End If
            _C = value.PadRight(40, " ")
        End Set
    End Property
#End Region

#Region "Zona D"

    Private _D1 As String = "0000"
    Private _D2 As String = "0000"
    Private _D3 As String = "**"
    Private _D4 As String = "0000000000"


    ''' <summary>
    ''' Entidad, 4 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D1() As String
        Get
            Return _D1
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de excede los " & 4)
            End If
            _D1 = value.PadRight(4, "0")
        End Set
    End Property

    ''' <summary>
    ''' Oficina, 4 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D2() As String
        Get
            Return _D2
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New Exception("Longitud de excede los " & 4)
            End If
            _D2 = value.PadRight(4, "0")
        End Set
    End Property

    ''' <summary>
    ''' DC, 2 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D3() As String
        Get
            Return _D3
        End Get
        Set(ByVal value As String)
            If value.Length > 2 Then
                Throw New Exception("Longitud de excede los " & 2)
            End If
            _D3 = value.PadRight(2, "0")
        End Set
    End Property

    ''' <summary>
    ''' Numero de cuenta, 10 digitos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D4() As String
        Get
            Return _D4
        End Get
        Set(ByVal value As String)
            If value.Length > 10 Then
                Throw New Exception("Longitud de excede los " & 10)
            End If
            If value.Replace("0", " ").Trim() = "" Then
                Throw New Exception("El numero de cuenta de adeudo no puede ser todo ceros ")
            End If

            _D4 = value.PadRight(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' C C C de Adeudo, deben estar correctamente asignados D1, D2, D3, D4
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property D() As String
        Get
            Return D1 & D2 & D3 & D4
        End Get
    End Property

#End Region

#Region "Zona E"
    Private _E As String = "".PadLeft(10, " ")

    ''' <summary>
    ''' Importe de la domiciliación, con dos posiciones decimales para 
    ''' céntimos. Ha de ser distinto de ceros.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E() As String
        Get
            Return _E
        End Get
        Set(ByVal value As String)
            Dim v As Double = Double.Parse(value)
            _E = DocumentoN19.FormateaDecimal(v).PadLeft(10, "0")
        End Set
    End Property

#End Region

#Region "Zona F"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F As String = "".PadLeft(16, " ")
#End Region

#Region "Zona G"

    Private _G As String = "".PadLeft(40, " ")

    ''' <summary>
    ''' Primer campo de concepto. Podrá ir a espacios. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property G() As String
        Get
            Return _G
        End Get
        Set(ByVal value As String)
            If value.Length > 40 Then
                value = value.Substring(0, 40)
            End If
            _G = value.PadRight(40, " ")
        End Set
    End Property

#End Region

#Region "Zona H"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public H As String = "".PadLeft(8, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F & G & H
    End Function
End Class
#End Region

#Region "Public Class Opcional"
Public Class Opcional
#Region "Zona A"
    Private A1 As String = "56"
    Private A2 As String = "86"

    Public ReadOnly Property A()
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"

    Private _B1_NIF As String = "000000000"
    Private _B1_Sufijo As String = "000"

    ''' <summary>
    ''' Código del cliente ordenante. El mismo que figura en este 
    ''' campo en el registro "Cabecera de ordenante". 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los " & 9)
            End If
            _B1_NIF = value
        End Set
    End Property

    ''' <summary>
    ''' Mismo sufijo del cliente ordenante
     ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los " & 3)
            End If
            _B1_Sufijo = value
        End Set
    End Property

    Private _B2 As String = "".PadLeft(12, " ")

    ''' <summary>
    ''' Código de referencia. El mismo que figura en el registro 
    ''' "Individual obligatorio" correspondiente. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B2() As String
        Get
            Return _B2
        End Get
        Set(ByVal value As String)
            _B2 = value.PadLeft(12, " ")
        End Set
    End Property

    Public ReadOnly Property B() As String
        Get
            Return (_B1_NIF & _B1_Sufijo).PadLeft(12, "0") & B2
        End Get
    End Property


#End Region

#Region "Zona C"
    Private _C As String = "".PadLeft(40, " ")

    ''' <summary>
    ''' Nombre del titular de la cuenta domiciliataria. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property C() As String
        Get
            Return _C
        End Get
        Set(ByVal value As String)
            If value.Length > 40 Then
                value = value.Substring(0, 40)
                ' Throw New Exception("Longitud de nombre excede los " & 40)
            End If
            If value.Trim() = "" Then
                Throw New Exception("Distinto de  todo espacios!!")
            End If
            _C = value.PadRight(40, " ")
        End Set
    End Property
#End Region

#Region "Zona D"
    Private _D As String = "".PadLeft(40, " ")

    ''' <summary>
    ''' Domicilio del Titular de la cuenta. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D() As String
        Get
            Return _D
        End Get
        Set(ByVal value As String)
            If value.Length > 40 Then
                value = value.Substring(0, 40)
            End If
            _D = value.PadRight(40, " ")
        End Set
    End Property
#End Region

#Region "Zona E"
    Private _E1 As String = "".PadLeft(35, " ")
    Private _E2 As String = "".PadLeft(5, " ")

    ''' <summary>
    ''' Plaza del domicilio del titular de la cuenta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E1() As String
        Get
            Return _E1
        End Get
        Set(ByVal value As String)
            If value.Length > 35 Then
                value = value.Substring(0, 35)
            End If
            _E1 = value.PadRight(35, " ")
        End Set
    End Property

    ''' <summary>
    ''' Código postal de este domicilio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E2() As String
        Get
            Return _E2
        End Get
        Set(ByVal value As String)
            _E2 = value.PadRight(5, " ")
        End Set
    End Property

    Public ReadOnly Property E() As String
        Get
            Return E1 & E2
        End Get
    End Property

#End Region

#Region "Zona F"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F As String = "".PadLeft(14, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F
    End Function

End Class
#End Region

#Region "Public Class Total Ordenante"
Public Class Total_Ordenante

#Region "Zona A"
    Private A1 As String = "58"
    Private A2 As String = "80"

    Public ReadOnly Property A()
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"

    Private _B1_NIF As String = "000000000"
    Private _B1_Sufijo As String = "000"

    ''' <summary>
    ''' Código del cliente ordenante. El mismo que figura en este 
    ''' campo en el registro "Cabecera de ordenante". 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los " & 9)
            End If
            _B1_NIF = value
        End Set
    End Property

    ''' <summary>
    ''' Código de referencia. El mismo que figura en el registro 
    ''' "Individual obligatorio" correspondiente. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los " & 3)
            End If
            _B1_Sufijo = value
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public B2 As String = "".PadLeft(12, " ")


    Public ReadOnly Property B() As String
        Get
            Return (_B1_NIF & _B1_Sufijo).PadLeft(12, "0") & B2
        End Get
    End Property


#End Region

#Region "Zona C"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public C As String = "".PadLeft(40, " ")
#End Region

#Region "Zona D"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public D As String = "".PadLeft(20, " ")
#End Region

#Region "Zona E"
    Private _E1 As String = "".PadLeft(10, " ")
    Private _E2 As String = "".PadLeft(6, " ")

    ''' <summary>
    ''' Suma de importes del ordenante
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E1() As String
        Get
            Return _E1
        End Get
        Set(ByVal value As String)
            Dim v As Double = Double.Parse(value)
            _E1 = DocumentoN19.FormateaDecimal(v).PadLeft(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E2() As String
        Get
            Return _E2
        End Get
        Set(ByVal value As String)
            _E2 = value.PadRight(6, " ")
        End Set
    End Property

    Public ReadOnly Property E() As String
        Get
            Return E1 & E2
        End Get
    End Property

#End Region

#Region "Zona F"
    Private _F1 As String = "".PadLeft(10, "0")
    Private _F2 As String = "".PadLeft(10, "0")

    ''' <summary>
    ''' Número de domiciliaciones del ordenante.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property F1() As String
        Get
            Return _F1
        End Get
        Set(ByVal value As String)
            _F1 = value.PadLeft(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' Número total de registros del ordenante, incluyendo el de 
    ''' Cabecera y total ordenante. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property F2() As String
        Get
            Return _F2
        End Get
        Set(ByVal value As String)
            _F2 = value.PadLeft(10, "0")
        End Set
    End Property



    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F3 As String = "".PadLeft(20, " ")

    Public ReadOnly Property F() As String
        Get
            Return F1 & F2 & F3
        End Get
    End Property

#End Region

#Region "Zona G"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public G As String = "".PadLeft(18, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F & G
    End Function

End Class
#End Region

#Region "Public Class Total General"
Public Class Total_General

#Region "Zona A"
    Private A1 As String = "59"
    Private A2 As String = "80"

    Public ReadOnly Property A()
        Get
            Return A1 & A2
        End Get
    End Property
#End Region

#Region "Zona B"

    Private _B1_NIF As String = "000000000"
    Private _B1_Sufijo As String = "000"

    ''' <summary>
    ''' Código de presentador. El mismo que figura en este campo 
    ''' en el registro "Cabecera de presentador".
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_NIF() As String
        Get
            Return _B1_NIF
        End Get
        Set(ByVal value As String)
            If value.Length > 9 Then
                Throw New Exception("Longitud de NIF excede los " & 9)
            End If
            _B1_NIF = value
        End Set
    End Property

    ''' <summary>
    ''' Sufijo el mismo del registro "Cabecera de Presentador"
    ''' </summary>
    ''' <remarks></remarks>
    Public Property B1_Sufijo() As String
        Get
            Return _B1_Sufijo
        End Get
        Set(ByVal value As String)
            If value.Length > 3 Then
                Throw New Exception("Longitud del sufijo excede los " & 3)
            End If
            _B1_Sufijo = value
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public B2 As String = "".PadLeft(12, " ")


    Public ReadOnly Property B() As String
        Get
            Return (_B1_NIF & _B1_Sufijo).PadLeft(12, "0") & B2
        End Get
    End Property


#End Region

#Region "Zona C"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public C As String = "".PadLeft(40, " ")
#End Region

#Region "Zona D"

    Private _D1 As String = "".PadLeft(4, " ")
    Private _D2 As String = "".PadLeft(16, " ")

    ''' <summary>
    ''' Número de ordenantes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D1() As String
        Get
            Return _D1
        End Get
        Set(ByVal value As String)
            _D1 = value.PadLeft(4, "0")
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D2() As String
        Get
            Return _D2
        End Get
        Set(ByVal value As String)
            _D1 = value.PadLeft(16, " ")
        End Set
    End Property

    Public ReadOnly Property D() As String
        Get
            Return D1 & D2
        End Get
    End Property


#End Region

#Region "Zona E"
    Private _E1 As String = "".PadLeft(10, " ")
    Private _E2 As String = "".PadLeft(6, " ")

    ''' <summary>
    ''' Total Importes. Suma de los importes de los registros de 
    ''' "Código de registro 56" y "Código de dato 80", del fichero.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E1() As String
        Get
            Return _E1
        End Get
        Set(ByVal value As String)
            Dim v As Double = Double.Parse(value)
            _E1 = DocumentoN19.FormateaDecimal(v).PadLeft(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property E2() As String
        Get
            Return _E2
        End Get
        Set(ByVal value As String)
            _E2 = value.PadRight(6, " ")
        End Set
    End Property

    Public ReadOnly Property E() As String
        Get
            Return E1 & E2
        End Get
    End Property

#End Region

#Region "Zona F"
    Private _F1 As String = "".PadLeft(10, " ")
    Private _F2 As String = "".PadLeft(10, " ")

    ''' <summary>
    '''Número total de registros de tipo individual obligatorio.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property F1() As String
        Get
            Return _F1
        End Get
        Set(ByVal value As String)
            _F1 = value.PadLeft(10, "0")
        End Set
    End Property

    ''' <summary>
    ''' Número de registros que contiene el fichero, incluidos los 
    ''' de cabecera, el de total ordenante y el propio de total general. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property F2() As String
        Get
            Return _F2
        End Get
        Set(ByVal value As String)
            _F2 = value.PadLeft(10, "0")
        End Set
    End Property



    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public F3 As String = "".PadLeft(20, " ")

    Public ReadOnly Property F() As String
        Get
            Return F1 & F2 & F3
        End Get
    End Property

#End Region

#Region "Zona G"
    ''' <summary>
    ''' Libre
    ''' </summary>
    ''' <remarks></remarks>
    Public G As String = "".PadLeft(18, " ")
#End Region

    Public Overrides Function ToString() As String
        Return A & B & C & D & E & F & G
    End Function

End Class
#End Region
