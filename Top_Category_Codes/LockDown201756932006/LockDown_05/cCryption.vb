Imports System.Text
Imports System.Collections.Specialized
Imports System.Security.Cryptography
Public Class cCryption
    Inherits System.Windows.Forms.Form

    Private lbtVector() As Byte = {240, 3, 45, 29, 0, 76, 173, 59}
    Private lscryptoKey As String = "retard"

    Public Function psEncrypt(ByVal sInputVal As String) As String

        Dim loCryptoClass As New TripleDESCryptoServiceProvider
        Dim loCryptoProvider As New MD5CryptoServiceProvider
        Dim lbtBuffer() As Byte

        Try
            lbtBuffer = System.Text.Encoding.ASCII.GetBytes(sInputVal)
            loCryptoClass.Key = loCryptoProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(lscryptoKey))
            loCryptoClass.IV = lbtVector
            sInputVal = Convert.ToBase64String(loCryptoClass.CreateEncryptor().TransformFinalBlock(lbtBuffer, 0, lbtBuffer.Length()))
            psEncrypt = sInputVal
        Catch ex As CryptographicException
            Throw ex
        Catch ex As FormatException
            Throw ex
        Catch ex As Exception
            Throw ex
        Finally
            loCryptoClass.Clear()
            loCryptoProvider.Clear()
            loCryptoClass = Nothing
            loCryptoProvider = Nothing
        End Try
    End Function

    Public Function psDecrypt(ByVal sQueryString As String) As String

        Dim buffer() As Byte
        Dim loCryptoClass As New TripleDESCryptoServiceProvider
        Dim loCryptoProvider As New MD5CryptoServiceProvider

        buffer = Convert.FromBase64String(sQueryString)
        loCryptoClass.Key = loCryptoProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(lscryptoKey))
        loCryptoClass.IV = lbtVector
        Return Encoding.ASCII.GetString(loCryptoClass.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        loCryptoClass.Clear()
        loCryptoProvider.Clear()
        loCryptoClass = Nothing
        loCryptoProvider = Nothing
    End Function
End Class
