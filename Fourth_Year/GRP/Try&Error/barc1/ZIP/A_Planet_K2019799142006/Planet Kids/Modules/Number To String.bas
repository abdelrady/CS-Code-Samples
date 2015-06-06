Attribute VB_Name = "mNumberToString"
Option Explicit

' --------------------------------------------------------------------------------
'   __| | __ _  ___  __ _ _ _ __ _    ___  ___  / _|_____ _  _  _ _ _ _ _ ___  ___
'  / _' |/ _' |/ __\/ _' | '_\  ' |  / __|/ _ \| |_ _   _| \/ \/ /_' | '_\ __\/ __|
' ( (_| | (_| | (__  (_| | |  (_| |  \__ \ (_) |  _| | | \      /(_| | |( (/ )\__ \
'  \__,_|\__,_|\___/\__,_|_| \__,_|  |___/\___/|_|   |_|  \_/\_/\__,_|_| \___/|___/
' --------------------------------------------------------------------------------
' Name:     mNumberToString module
' Author:   Noel A. Dacara (noeldacara@hotmail.com)
' Date:     04 May 2006
'
' You can freely use and distribute this file with or without permission provided
' that credits herein are kept unmodified and having acknowledgements is observed.
'
' Inquiries or comments regarding my works and whatsoever are greatly appreciated.
' --------------------------------------------------------------------------------

Public Function NumberToString(ByVal Number As Currency) As String
    Dim Parsed  As String
    Dim Result  As String
    Dim Temp    As Currency
    
    If (Number > 999999999999999#) Then ' Over 999 Trillion; What the f***!!!
        Result = "Over"
        Number = 999999999999999# ' Maximum value
    End If
    
    If (Number > 999999999999#) Then ' Over 999 Billion; Trillions...
        Parsed = Int(Number)
        Parsed = Left$(Parsed, Len(Parsed) - 12)
        Number = Mid$(Number, Len(Parsed) + 1)
        Result = Result & " " & NumberToString(Parsed) & " Trillion"
    End If
    
    If (Number > 999999999) Then ' Over 999 Million; Billions...
        Parsed = Int(Number)
        Parsed = Left$(Parsed, Len(Parsed) - 9)
        Number = Mid$(Number, Len(Parsed) + 1)
        Result = Result & " " & NumberToString(Parsed) & " Billion"
    End If
    
    If (Number > 999999) Then ' Over 999 Thousand; Millions...
        Parsed = Int(Number)
        Parsed = Left$(Parsed, Len(Parsed) - 6)
        Number = Mid$(Number, Len(Parsed) + 1)
        Result = Result & " " & NumberToString(Parsed) & " Million"
    End If
    
    If (Number > 999) Then ' Over 999; Thousands...
        Parsed = Int(Number)
        Parsed = Left$(Parsed, Len(Parsed) - 3)
        Number = Mid$(Number, Len(Parsed) + 1)
        Result = Result & " " & NumberToString(Parsed) & " Thousand"
    End If
    
    If (Number > 99) Then ' Over 99; Hundreds...
        Parsed = Left$(Number, 1)
        Number = Mid$(Number, Len(Parsed) + 1)
        Result = Result & " " & NumberToString(Parsed) & " Hundred"
    End If
    
    If (Number > 9) Then ' Over 9; Tens...
        Parsed = Left$(Number, 1)
        Parsed = Parsed * 10
        Temp = Int(Number - Parsed)
        
        If (Parsed = 10) Then ' 10 - 19
            Parsed = NumberToWord(Temp + Parsed)
            
            If (Len(Parsed) = 0) Then ' 11 - 19
                Parsed = NumberToWord(Temp) & "teen"
            End If
        Else ' 20 - 99
            Parsed = NumberToWord(Parsed)
            
            If (Temp > 0) Then
                Parsed = Parsed & "-" & NumberToWord(Temp)
            End If
        End If
        
        Temp = Int(Number)
        Result = Result & " " & Parsed
    ElseIf (Number >= 1) Then ' 1 - 9
        Temp = Int(Number)
        Result = Result & " " & NumberToWord(Temp)
    ElseIf (Len(Result) = 0) Then ' 0
        Temp = Int(Number)
        Result = NumberToWord(Temp)
    End If
    
    If (Not Number - Temp = 0) Then ' Has a decimal value?
        Parsed = Int(Number)
        Parsed = Number - Temp
        Parsed = Mid$(Parsed, 3)
        
        If (Len(Parsed) = 1) Then
            Parsed = " And " & (Parsed * 10) & "/100"
        Else
            Parsed = " And " & Int(Parsed) & "/1" & String$(Len(Parsed), "0")
        End If
        
        Result = Result & Parsed
    End If
    
    NumberToString = LTrim$(Result) ' Return result
End Function

Private Function NumberToWord(ByVal Number As Currency) As String
    Select Case Number
        Case 0:     NumberToWord = "Zero"
        Case 1:     NumberToWord = "One"
        Case 2:     NumberToWord = "Two"
        Case 3:     NumberToWord = "Three"
        Case 4:     NumberToWord = "Four"
        Case 5:     NumberToWord = "Five"
        Case 6:     NumberToWord = "Six"
        Case 7:     NumberToWord = "Seven"
        Case 8:     NumberToWord = "Eight"
        Case 9:     NumberToWord = "Nine"
        Case 10:    NumberToWord = "Ten"
        Case 11:    NumberToWord = "Eleven"
        Case 12:    NumberToWord = "Twelve"
        Case 13:    NumberToWord = "Thirteen"
        Case 15:    NumberToWord = "Fifteen"
        Case 18:    NumberToWord = "Eighteen"
        Case 20:    NumberToWord = "Twenty"
        Case 30:    NumberToWord = "Thirty"
        Case 40:    NumberToWord = "Forty"
        Case 50:    NumberToWord = "Fifty"
        Case 60:    NumberToWord = "Sixty"
        Case 70:    NumberToWord = "Seventy"
        Case 80:    NumberToWord = "Eighty"
        Case 90:    NumberToWord = "Ninety"
    End Select
End Function

' Created by Noel A. Dacara | noeldacara@hotmail.com | Davao City, Philippines
