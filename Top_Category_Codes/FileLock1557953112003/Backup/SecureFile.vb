Public Class SecureFile
    Private m_FilePath
    Private m_FileStream As System.IO.FileStream

    Public Property SetFile()
        Get
            Return m_FilePath
        End Get
        Set(ByVal Value)
            m_FilePath = Value
        End Set
    End Property
    Public Sub Secure()
        m_FileStream = New System.IO.FileStream(m_FilePath, IO.FileMode.Open)
        Console.WriteLine("Secured " & m_FilePath)
    End Sub

    Public Sub Unsecure()
        Try
            m_FileStream.Close()
        Catch
            'Do nuttin'
            Console.WriteLine("Unabled to unsecure.")
        End Try
        Console.WriteLine("Unsecured " & m_FilePath)
    End Sub
End Class
