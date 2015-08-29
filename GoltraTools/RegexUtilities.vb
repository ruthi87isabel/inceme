Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class RegexUtilities
    Shared _invalid As Boolean = False

    Public Shared Function IsValidEmail(strIn As String) As Boolean
        _invalid = False
        If String.IsNullOrEmpty(strIn) Then Return False

        ' Use IdnMapping class to convert Unicode domain names. 
        Try
            strIn = Regex.Replace(strIn, "(@)(.+)$", AddressOf DomainMapper, RegexOptions.None)
        Catch e As Exception
            Return False
        End Try

        If _invalid Then Return False

        ' Return true if strIn is in valid e-mail format. 
        Try
            Return Regex.IsMatch(strIn, "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", RegexOptions.IgnoreCase)
        Catch e As Exception
            Return False
        End Try
    End Function

    Shared Function DomainMapper(match As Match) As String
        ' IdnMapping class with default property values. 
        Dim idn As New IdnMapping()

        Dim domainName As String = match.Groups(2).Value
        Try
            domainName = idn.GetAscii(domainName)
        Catch e As ArgumentException
            _invalid = True
        End Try
        Return match.Groups(1).Value + domainName
    End Function

    Public Shared Function CheckPhoneNumber(ByVal strPhoneNumber As String) As Boolean

        If strPhoneNumber Is Nothing Then
            Return False
        End If
        Return strPhoneNumber.Trim().Length > 5

        'Const matchPhoneNumberPattern As String = "^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"
        'If strPhoneNumber IsNot Nothing Then
        '    Return Regex.IsMatch(strPhoneNumber, matchPhoneNumberPattern)
        'Else
        '    Return False
        'End If
    End Function
End Class
