Imports System.Security.Cryptography

Public Class Seguridad
    Public Function EncryptData(Message As String, key As String) As String

        Dim Results() As Byte
        Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
        Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim TDESKey() As Byte = HashProvider.ComputeHash(UTF8.GetBytes(key))
        Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        TDESAlgorithm.Key = TDESKey
        TDESAlgorithm.Mode = CipherMode.ECB
        TDESAlgorithm.Padding = PaddingMode.PKCS7
        Dim DataToEncrypt() As Byte = UTF8.GetBytes(Message)
        Try
            Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
            Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
        Finally
            TDESAlgorithm.Clear()
            HashProvider.Clear()
        End Try
        Return Convert.ToBase64String(Results)

    End Function

    Public Function DecryptString(Message As String, key As String) As String

        Dim Results() As Byte
        Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
        Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim TDESKey() As Byte = HashProvider.ComputeHash(UTF8.GetBytes(key))
        Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        TDESAlgorithm.Key = TDESKey
        TDESAlgorithm.Mode = CipherMode.ECB
        TDESAlgorithm.Padding = PaddingMode.PKCS7
        Dim DataToDecrypt() As Byte = Convert.FromBase64String(Message)
        Try
            Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
            Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
        Finally
            TDESAlgorithm.Clear()
            HashProvider.Clear()
        End Try
        Return UTF8.GetString(Results)
    End Function
End Class
