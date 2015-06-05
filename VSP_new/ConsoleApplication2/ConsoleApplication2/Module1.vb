'Namespace Hash
'   Module Hash
Module Module1
    Function CreateHash(ByVal strSource As String) As String
        Dim bytHash As Byte()
        Dim uEncode As New Text.UnicodeEncoding()
        'Store the source string in a byte array
        Dim bytSource() As Byte = uEncode.GetBytes(strSource)
        Dim sha1 As New Security.Cryptography.SHA1CryptoServiceProvider()
        'Create the hash
        bytHash = sha1.ComputeHash(bytSource)
        'return as a base64 encoded string
        Return Convert.ToBase64String(bytHash)
    End Function
    'End Module
    ' End Namespace
    Sub Main()
        ' EncryptField("Password", "PasswordHash")
        'Microsoft.CSharp()
        Console.WriteLine(CreateHash("amr_fci"))
    End Sub

End Module
