Module Encrypt
    Public con As String
    Public len2 As Integer
    Public position As Integer
    Public len1 As Integer
    Public reply As String
    Public ascode As String
    ''''''''''''''''''''''''''''
    Public finalvalue As String
    Public condition As Integer
    Public finalint As Integer
    Public mainloop1 As Integer
    Public findme3 As String
    Public dec As Integer
    Public findme1 As Integer
    Public decrypt As String
    Public globalfinal As String


    Public Function encryption(ByVal Text As String)
        con = "" 'Final String Obtained after Encryption
        len2 = Text.Length 'TextBox1.Text.Length 'Len = Length of the TextBox
        position = 0
        For len1 = 0 To len2 'Len1 = integer for counting
            If len1 = len2 Then
                Exit For 'Exit Loop
            Else 'Len1 <> len2
                reply = Text.Chars(len1) 'Retrieve the text of character Position of Len1
                ascode = Asc(reply) 'Get the Asc Code of the Character stored in Reply
                ascode = ascode * 20
                ascode = ascode / 2
                ascode = ascode - 100
                If position = 0 Then
                    con = con + CStr(ascode) 'First character for Encryption
                    position = position + 1
                Else
                    con = con + "-" + CStr(ascode) 'Rest of the Character
                End If
            End If
        Next
        globalfinal = con
    End Function
    Public Function decryption(ByVal Text As String)
        finalvalue = ""
        condition = 0
        finalint = 0
        mainloop1 = 0
        findme3 = ""
        For mainloop1 = 1 To Text.Length 'mainloop as integer 
            If mainloop1 = Text.Length Then 'Store the length of Text to be decrypt
                Exit For
            Else
                dec = 0 'Dec = Store Position of "-"
                dec = InStr(mainloop1, Text, "-", CompareMethod.Binary)
                finalint = mainloop1
                'Store mainloop1 in finalint
                'Deduct 1 from finalint to get the original position of finalint
                finalint = finalint - 1
                mainloop1 = dec
                If mainloop1 = 0 Then 'If it is last string
                    For findme1 = finalint To Text.Length
                        If findme1 = Text.Length Then
                            Exit For
                        Else
                            findme3 = findme3 + Text.Chars(findme1)
                        End If
                    Next
                    decrypt = ""
                    findme3 = findme3 + 100
                    findme3 = findme3 * 2
                    findme3 = findme3 / 20
                    decrypt = Chr(findme3)
                    finalvalue = finalvalue + decrypt
                    globalfinal = finalvalue
                    Exit Function
                ElseIf finalint > condition Then
                    dec = dec - 1
                    For findme1 = finalint To dec
                        If findme1 = dec Then
                            Exit For
                        Else
                            findme3 = findme3 + Text.Chars(findme1)
                            'MsgBox(findme3)
                        End If
                    Next
                    findme3 = findme3 + 100
                    findme3 = findme3 * 2
                    findme3 = findme3 / 20
                    decrypt = Chr(findme3)
                    findme3 = ""
                    finalvalue = finalvalue + decrypt
                Else
                    condition = finalint
                    dec = dec - 1
                    For findme1 = 0 To dec
                        If findme1 = dec Then
                            Exit For
                        Else
                            findme3 = findme3 + Text.Chars(findme1)
                        End If
                    Next
                    findme3 = findme3 + 100
                    findme3 = findme3 * 2
                    findme3 = findme3 / 20
                    decrypt = Chr(findme3)
                    findme3 = ""
                    finalvalue = finalvalue + decrypt
                End If
            End If
        Next

    End Function
End Module