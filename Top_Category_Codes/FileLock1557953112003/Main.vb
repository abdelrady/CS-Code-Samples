Module MainModule
    Private m_SecureList As New ArrayList()

    Const output = "secure.lst"

    Sub Main()
        Console.WriteLine("FileSecure 0.1.1.2, by Guo Xu 2003")

        LoadList()
        ParseCMDs()
    End Sub

    Sub ParseCMDs()
        Console.Write("fs:\\")
        Dim Command As String = Console.ReadLine
        Dim sCommand() As String = Command.Split(" ")

        If Command.Trim.ToLower = "save" Then
            SaveList()
            ParseCMDs()
            Exit Sub
        End If

        If Command.Trim.ToLower = "load" Then
            LoadList()
            ParseCMDs()
            Exit Sub
        End If

        If Command.Trim.ToLower = "exit" Then
            Console.WriteLine("Unsecuring all files. Saving.")
            SaveList()
            End
        End If

        If Command.Trim.ToLower = "list" Then
            Dim i As Integer
            For i = 0 To m_SecureList.Count - 1
                Console.WriteLine(i + 1 & ": " & CType(m_SecureList(i), SecureFile).SetFile)
            Next
        End If

        If sCommand.GetUpperBound(0) = 1 Then
            If sCommand(0).ToLower = "secure" Then
                Add(sCommand(1).ToLower)
            End If
        End If

        If sCommand.GetUpperBound(0) = 1 Then
            If sCommand(0).ToLower = "unsecure" Then
                Try
                    Dim Item As New SecureFile()
                    Dim i As Integer
                    Item.SetFile = sCommand(1).ToLower
                    For i = 0 To m_SecureList.Count - 1
                        If CType(m_SecureList(i), SecureFile).SetFile = Item.SetFile Then
                            CType(m_SecureList(i), SecureFile).Unsecure()
                            m_SecureList.RemoveAt(i)
                        End If
                    Next
                Catch x As Exception
                    Console.WriteLine("Couldn't secure. " & x.Message)
                End Try
            End If
        End If

        ParseCMDs()
    End Sub
    Public Sub Add(ByVal File As String)

        Try
            Dim Item As New SecureFile()
            Item.SetFile = File.ToLower
            If System.IO.File.Exists(Item.SetFile) = False Then
                Console.WriteLine("File couldn't be found.")
                ParseCMDs()
                Exit Sub
            End If
            m_SecureList.Add(Item)
            CType(m_SecureList(m_SecureList.Count - 1), SecureFile).Secure()
        Catch x As Exception
            Console.WriteLine("Couldn't secure. " & x.Message)
        End Try
    End Sub

    Public Sub LoadList()
        Try
            Dim i As Integer
            Dim sreader As System.IO.StreamReader
            sreader = System.IO.File.OpenText(output)

            Dim sSplit() As String
            Dim sData As String = sreader.ReadToEnd
            sreader.Close()
            sSplit = sData.Split(vbCrLf)
            For i = 0 To sSplit.GetUpperBound(0) - 1
                Add(sSplit(i))
            Next
        Catch

        End Try
    End Sub

    Public Sub SaveList()
        Dim i As Integer

        Dim swriter As System.IO.StreamWriter
        swriter = System.IO.File.CreateText(output)

        For i = 0 To m_SecureList.Count - 1
            swriter.WriteLine(CType(m_SecureList(i), SecureFile).SetFile)
        Next

        swriter.Flush()
        swriter.Close()
        Console.WriteLine("Saved to " & output & ".")
    End Sub
End Module
