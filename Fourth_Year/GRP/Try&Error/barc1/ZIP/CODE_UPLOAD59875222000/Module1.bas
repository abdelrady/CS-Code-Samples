Attribute VB_Name = "Module1"
Private I As Integer
Private F As Integer
Private DataToPrint As String
Private DataToEncode As String
Private OnlyCorrectData As String
Private Printable_string As String
Private Encoding As String
Private weightedTotal As Long
Private WeightValue As Integer
Private CurrentValue As Long
Private CheckDigitValue As Integer
Private Factor As Integer
Private CheckDigit As Integer
Private CurrentEncoding As String
Private NewLine As String
Private msg As String
Private CurrentChar As String
Private C128_StartA As String
Private C128_StartB As String
Private C128_StartC As String
Private C128_Stop As String
Private C128Start As String
Private C128_CheckDigit As String
Private StartCode As String
Private StopCode As String
Private Fnc1 As String
Private LeadingDigit As String
Private EAN2AddOn As String
Private EAN5AddOn As String
Private EANAddOnToPrint As String

Public Function Code128a(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' The purpose of this code is to print the Code 128 barcode from character set A
' Use the characters from set B to print characters not on the keyboard
' The scanner will scan characters from set A
'
' You MUST use the fully functional Code 128 Version 2.0 or above
' font for this code to create and print a proper barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
C128_StartA = Chr(203)
C128_StartB = Chr(204)
C128_StartC = Chr(205)
C128_Stop = Chr(206)

'Here we select character set A
C128Start = C128_StartA

'<<<< Calculate Modulo 103 Check Digit >>>>
'Set WeightedTotal to the value of the start character
weightedTotal = (Asc(C128Start) - 100)
For I = 1 To Len(DataToEncode)
    'Get the ASCII value of each character
    CurrentChar = (Asc(Mid(DataToEncode, I, 1)))
    'Get the Code 128 value of CurrentChar according to chart
    If CurrentChar < 135 Then CurrentValue = CurrentChar - 32
    If CurrentChar > 134 Then CurrentValue = CurrentChar - 100
    'multiply by the weighting character
    CurrentValue = CurrentValue * I
    'add the values together
    weightedTotal = weightedTotal + CurrentValue
Next I
'divide the WeightedTotal by 103 and get the remainder, this is the CheckDigitValue
CheckDigitValue = (weightedTotal Mod 103)
'Now that we have the CheckDigitValue, find the corresponding ASCII character from the table
If CheckDigitValue < 95 And CheckDigitValue > 0 Then C128_CheckDigit = CheckDigitValue + 32
If CheckDigitValue > 94 Then C128_CheckDigit = CheckDigitValue + 100
If CheckDigitValue = 0 Then C128_CheckDigit = 159
C128_CheckDigit = Chr(C128_CheckDigit)

'Check for spaces or "00" and print ASCII 159 instead
'place changes in DataToPrint
For I = 1 To Len(DataToEncode)
    CurrentChar = Mid(DataToEncode, I, 1)
    If CurrentChar = " " Then CurrentChar = Chr(159)
    DataToPrint = DataToPrint & CurrentChar
Next I

'Get PrintableString
Printable_string = C128Start & DataToPrint & C128_CheckDigit & C128_Stop & " "

'Return the PrintableString
Code128a = Printable_string

End Function

Public Function Code128b(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the Code 128 barcode from character set B
'
' You MUST use the fully functional Code 128 Version 2.0 or above
' font for this code to create and print a proper barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
C128_StartA = Chr(203)
C128_StartB = Chr(204)
C128_StartC = Chr(205)
C128_Stop = Chr(206)

'Here we select character set A or B but not C
C128Start = C128_StartB

'<<<< Calculate Modulo 103 Check Digit >>>>
'Set WeightedTotal to the value of the start character
weightedTotal = (Asc(C128Start) - 100)
For I = 1 To Len(DataToEncode)
    'Get the ASCII value of each character
    CurrentChar = (Asc(Mid(DataToEncode, I, 1)))
    'Get the Code 128 value of CurrentChar according to chart
    If CurrentChar < 135 Then CurrentValue = CurrentChar - 32
    If CurrentChar > 134 Then CurrentValue = CurrentChar - 100
    'multiply by the weighting character
    CurrentValue = CurrentValue * I
    'add the values together
    weightedTotal = weightedTotal + CurrentValue
Next I
'divide the WeightedTotal by 103 and get the remainder, this is the CheckDigitValue
CheckDigitValue = (weightedTotal Mod 103)
'Now that we have the CheckDigitValue, find the corresponding ASCII character from the table
If CheckDigitValue < 95 And CheckDigitValue > 0 Then C128_CheckDigit = CheckDigitValue + 32
If CheckDigitValue > 94 Then C128_CheckDigit = CheckDigitValue + 100
If CheckDigitValue = 0 Then C128_CheckDigit = 159
C128_CheckDigit = Chr(C128_CheckDigit)

'Check for spaces or "00" and print ASCII 159 instead
'place changes in DataToPrint
For I = 1 To Len(DataToEncode)
    CurrentChar = Mid(DataToEncode, I, 1)
    If CurrentChar = " " Then CurrentChar = Chr(159)
    DataToPrint = DataToPrint & CurrentChar
Next I

'Get Printable String
Printable_string = C128Start & DataToPrint & C128_CheckDigit & C128_Stop & " "

'Return the PrintableString
Code128b = Printable_string
End Function

Public Function Code11(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the Code 11 barcode
' Enter all the numbers without dashes

DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))

' Check to make sure data is numeric or a dash and remove all others.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "-" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

'<<<< Calculate Check Digit >>>>
Factor = 1
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'Set the "-" character to the value of 10
    If CurrentChar = "-" Then CurrentChar = "10"
    'multiply by the weighting character and add together
    weightedTotal = weightedTotal + (CurrentChar * Factor)
    'change factor for next calculation
    Factor = Factor + 1
Next I
'Find the Modulo 11 check digit
CheckDigit = (weightedTotal Mod 11)

'Get Printable String
Printable_string = "(" & DataToEncode & CheckDigit & ")" & " "

'Return the PrintableString
Code11 = Printable_string

End Function


Public Function Code128c(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the Code 128 barcode from character set C
'
' You MUST use the fully functional Code 128 Version 2.0 or above
' font for this code to create and print a proper barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

'Check for an even number of digits, add 0 if not even
If (Len(DataToEncode) Mod 2) = 1 Then DataToEncode = "0" & DataToEncode

'Assign start & stop codes
StartCode = Chr(205)
StopCode = Chr(206)

'<<<< Calculate Modulo 103 Check Digit and generate DataToPrint >>>>
'Set WeightedTotal to the Code 128 value of the start character
weightedTotal = 105
WeightValue = 1
For I = 1 To Len(DataToEncode) Step 2
    'Get the value of each number pair
    CurrentValue = Mid(DataToEncode, I, 2)
    'get the DataToPrint
    If CurrentValue < 95 And CurrentValue > 0 Then DataToPrint = DataToPrint & Chr(CurrentValue + 32)
    If CurrentValue > 94 Then DataToPrint = DataToPrint & Chr(CurrentValue + 100)
    If CurrentValue = 0 Then DataToPrint = DataToPrint & Chr(159)
    'multiply by the weighting character
    CurrentValue = CurrentValue * WeightValue
    'add the values together to get the weighted total
    weightedTotal = weightedTotal + CurrentValue
    WeightValue = WeightValue + 1
Next I
'divide the WeightedTotal by 103 and get the remainder, this is the CheckDigitValue
CheckDigitValue = (weightedTotal Mod 103)

'Now that we have the CheckDigitValue, find the corresponding ASCII character from the table
If CheckDigitValue < 95 And CheckDigitValue > 0 Then C128_CheckDigit = CheckDigitValue + 32
If CheckDigitValue > 94 Then C128_CheckDigit = CheckDigitValue + 100
If CheckDigitValue = 0 Then C128_CheckDigit = 159
C128_CheckDigit = Chr(C128_CheckDigit)
'
'Get Printable String
Printable_string = StartCode & DataToPrint & C128_CheckDigit & StopCode & " "

'Return PrintableString
Code128c = Printable_string

End Function

Public Function Code39(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the CODE 39 barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
'Check for spaces in code
For I = 1 To Len(DataToEncode)
    'Get each character one at a time
    CurrentChar = (Mid(DataToEncode, I, 1))
    'To print the barcode symbol representing a space you will
    'to type or print "=" (the equal character) instead of a space character.
    If CurrentChar = " " Then CurrentChar = "="
    DataToPrint = DataToPrint & CurrentChar
Next I

'Get Printable String
Printable_string = "!" & DataToPrint & "!" & " "

'Return PrintableString
Code39 = Printable_string

End Function

Public Function Code39Mod43(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' The purpose of this code is to print the CODE 39 barcode
' You MUST install the AdvC39C font for this application to print
'
' Get data from user, this is the DataToEncode
DataToEncode = RTrim(DataToEncode)
DataToEncode = UCase(DataToEncode)
DataToPrint = ""
OnlyCorrectData = ""
'only pass correct data
For I = 1 To Len(DataToEncode)
    'Get each character one at a time
    CurrentChar = (Asc(Mid(DataToEncode, I, 1)))
    'Get the value of CurrentChar according to MOD43
    '0-9
    If CurrentChar < 58 And CurrentChar > 47 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    'A-Z
    If CurrentChar < 91 And CurrentChar > 64 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    'Space
    If CurrentChar = 32 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '-
    If CurrentChar = 45 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '.
    If CurrentChar = 46 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '$
    If CurrentChar = 36 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '/
    If CurrentChar = 47 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '+
    If CurrentChar = 43 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    '%
    If CurrentChar = 37 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

weightedTotal = 0
For I = 1 To Len(DataToEncode)
    'Get each character one at a time
    CurrentChar = (Asc(Mid(DataToEncode, I, 1)))
    'Get the value of CurrentChar according to MOD43
    '0-9
    If CurrentChar < 58 And CurrentChar > 47 Then CurrentValue = CurrentChar - 48
    'A-Z
    If CurrentChar < 91 And CurrentChar > 64 Then CurrentValue = CurrentChar - 55
    'Space
    If CurrentChar = 32 Then CurrentValue = 38
    '-
    If CurrentChar = 45 Then CurrentValue = 36
    '.
    If CurrentChar = 46 Then CurrentValue = 37
    '$
    If CurrentChar = 36 Then CurrentValue = 39
    '/
    If CurrentChar = 47 Then CurrentValue = 40
    '+
    If CurrentChar = 43 Then CurrentValue = 41
    '%
    If CurrentChar = 37 Then CurrentValue = 42
    'To print the barcode symbol representing a space you will
    'to type or print "=" (the equal character) instead of a space character.
    If CurrentChar = 32 Then CurrentChar = 61
    'gather data to print
    DataToPrint = DataToPrint & Chr(CurrentChar)
    'add the values together
    weightedTotal = weightedTotal + CurrentValue
Next I
'divide the WeightedTotal by 43 and get the remainder, this is the CheckDigit
CheckDigitValue = (weightedTotal Mod 43)
    'Assign values to characters
    '0-9
    If CheckDigitValue < 10 Then CheckDigit = CheckDigitValue + 48
    'A-Z
    If CheckDigitValue < 36 And CheckDigitValue > 9 Then CheckDigit = CheckDigitValue + 55
    'Space
    If CheckDigitValue = 38 Then CheckDigit = 61
    '-
    If CheckDigitValue = 36 Then CheckDigit = 45
    '.
    If CheckDigitValue = 37 Then CheckDigit = 46
    '$
    If CheckDigitValue = 39 Then CheckDigit = 36
    '/
    If CheckDigitValue = 40 Then CheckDigit = 47
    '+
    If CheckDigitValue = 41 Then CheckDigit = 43
    '%
    If CheckDigitValue = 42 Then CheckDigit = 37

'Get Printable String
Printable_string = "!" & DataToPrint & Chr(CheckDigit) & "!" & " "

'Return PrintableString
Code39Mod43 = Printable_string

End Function

Public Function RM4SCC(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' The purpose of this code is to print the CODE 39 barcode
' You MUST install the AdvRM font for this application to print
'
' Get data from user, this is the DataToEncode
DataToEncode = RTrim(LTrim(DataToEncode))
DataToEncode = UCase(DataToEncode)
'only pass correct data
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Get each character one at a time
    CurrentChar = (Asc(Mid(DataToEncode, I, 1)))
    'Get the value of CurrentChar according to MOD43
    '0-9
    If CurrentChar < 58 And CurrentChar > 47 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    'A-Z
    If CurrentChar < 91 And CurrentChar > 64 Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData
DataToPrint = DataToEncode

Dim r As Integer
Dim c As Integer
Dim Rtotal As Long
Dim Ctotal As Long
Rtotal = 0
Ctotal = 0
weightedTotal = 0
For I = 1 To Len(DataToEncode)
    'Get each character one at a time
    CurrentChar = Mid(DataToEncode, I, 1)
    'Get the values of CurrentChar
    Select Case CurrentChar
    Case "0"
        r = 1
        c = 1
    Case "1"
        r = 1
        c = 2
    Case "2"
        r = 1
        c = 3
    Case "3"
        r = 1
        c = 4
    Case "4"
        r = 1
        c = 5
    Case "5"
        r = 1
        c = 0
    Case "6"
        r = 2
        c = 1
    Case "7"
        r = 2
        c = 2
    Case "8"
        r = 2
        c = 3
    Case "9"
        r = 2
        c = 4
    Case "A"
        r = 2
        c = 5
    Case "B"
        r = 2
        c = 0
    Case "C"
        r = 3
        c = 1
    Case "D"
        r = 3
        c = 2
    Case "E"
        r = 3
        c = 3
    Case "F"
        r = 3
        c = 4
    Case "G"
        r = 3
        c = 5
    Case "H"
        r = 3
        c = 0
    Case "I"
        r = 4
        c = 1
    Case "J"
        r = 4
        c = 2
    Case "K"
        r = 4
        c = 3
    Case "L"
        r = 4
        c = 4
    Case "M"
        r = 4
        c = 5
    Case "N"
        r = 4
        c = 0
    Case "O"
        r = 5
        c = 1
    Case "P"
        r = 5
        c = 2
    Case "Q"
        r = 5
        c = 3
    Case "R"
        r = 5
        c = 4
    Case "S"
        r = 5
        c = 5
    Case "T"
        r = 5
        c = 0
    Case "U"
        r = 0
        c = 1
    Case "V"
        r = 0
        c = 2
    Case "W"
        r = 0
        c = 3
    Case "X"
        r = 0
        c = 4
    Case "Y"
        r = 0
        c = 5
    Case "Z"
        r = 0
        c = 0
        
    End Select
    'add the values together
    Rtotal = Rtotal + r
    Ctotal = Ctotal + c
Next I

'divide the Totals by 6 and get the remainder, this is a reference
'to the Check Digit.
'set check digit to CurrentChar (a string)
    Rtotal = (Rtotal Mod 6)
    Ctotal = (Ctotal Mod 6)
Select Case Rtotal
    Case 1
        Select Case Ctotal
            Case 1
                CurrentChar = "0"
            Case 2
                CurrentChar = "1"
            Case 3
                CurrentChar = "2"
            Case 4
                CurrentChar = "3"
            Case 5
                CurrentChar = "4"
            Case 0
                CurrentChar = "5"
        End Select
    Case 2
        Select Case Ctotal
            Case 1
                CurrentChar = "6"
            Case 2
                CurrentChar = "7"
            Case 3
                CurrentChar = "8"
            Case 4
                CurrentChar = "9"
            Case 5
                CurrentChar = "A"
            Case 0
                CurrentChar = "B"
        End Select
    Case 3
        Select Case Ctotal
            Case 1
                CurrentChar = "C"
            Case 2
                CurrentChar = "D"
            Case 3
                CurrentChar = "E"
            Case 4
                CurrentChar = "F"
            Case 5
                CurrentChar = "G"
            Case 0
                CurrentChar = "H"
        End Select
    Case 4
        Select Case Ctotal
            Case 1
                CurrentChar = "I"
            Case 2
                CurrentChar = "J"
            Case 3
                CurrentChar = "K"
            Case 4
                CurrentChar = "L"
            Case 5
                CurrentChar = "M"
            Case 0
                CurrentChar = "N"
        End Select
    Case 5
        Select Case Ctotal
            Case 1
                CurrentChar = "O"
            Case 2
                CurrentChar = "P"
            Case 3
                CurrentChar = "Q"
            Case 4
                CurrentChar = "R"
            Case 5
                CurrentChar = "S"
            Case 0
                CurrentChar = "T"
        End Select
    Case 0
        Select Case Ctotal
            Case 1
                CurrentChar = "U"
            Case 2
                CurrentChar = "V"
            Case 3
                CurrentChar = "W"
            Case 4
                CurrentChar = "X"
            Case 5
                CurrentChar = "Y"
            Case 0
                CurrentChar = "Z"
        End Select
End Select

'Get Printable String
Printable_string = "(" & DataToPrint & CurrentChar & ")" & " "

'Return PrintableString
RM4SCC = Printable_string

End Function
Public Function EAN13(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the EAN-13 barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))

' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
'DataToEncode = OnlyCorrectData
''
'Remove check digits if they added one
If Len(OnlyCorrectData) = "13" Then OnlyCorrectData = Mid(OnlyCorrectData, 1, 12)
If Len(OnlyCorrectData) = "15" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 12) & Mid(OnlyCorrectData, 14, 2))
If Len(OnlyCorrectData) = "18" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 12) & Mid(OnlyCorrectData, 14, 5))
'End sub if incorrect number

Dim EAN2AddOn As String
Dim EAN5AddOn As String
Dim EANAddOnToPrint As String
EAN2AddOn = ""
EAN5AddOn = ""
EANAddOnToPrint = ""
If Len(OnlyCorrectData) = 17 Then EAN5AddOn = Mid(OnlyCorrectData, 13, 5)
If Len(OnlyCorrectData) = 14 Then EAN2AddOn = Mid(OnlyCorrectData, 13, 2)
'split 12 digit number from add-on
DataToEncode = Mid(OnlyCorrectData, 1, 12)
''
'<<<< Calculate Check Digit >>>>
Factor = 3
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'multiply by the weighting factor which is 3,1,3,1...
    'and add the sum together
    weightedTotal = weightedTotal + CurrentChar * Factor
    'change factor for next calculation
    Factor = 4 - Factor
Next I
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If
'Now we must encode the leading digit into the left half of the EAN-13 symbol
'by using variable parity between character sets A and B
LeadingDigit = Mid(DataToEncode, 1, 1)
Select Case LeadingDigit
    Case 0
        Encoding = "AAAAAACCCCCC"
    Case 1
        Encoding = "AABABBCCCCCC"
    Case 2
        Encoding = "AABBABCCCCCC"
    Case 3
        Encoding = "AABBBACCCCCC"
    Case 4
        Encoding = "ABAABBCCCCCC"
    Case 5
        Encoding = "ABBAABCCCCCC"
    Case 6
        Encoding = "ABBBAACCCCCC"
    Case 7
        Encoding = "ABABABCCCCCC"
    Case 8
        Encoding = "ABABBACCCCCC"
    Case 9
        Encoding = "ABBABACCCCCC"
End Select
'add the check digit to the end of the barcode & remove the leading digit
DataToEncode = Mid(DataToEncode, 2, 11) & CheckDigit
'Now that we have the total number including the check digit, determine character to print
'for proper barcoding:
For I = 1 To Len(DataToEncode)
    'Get the ASCII value of each number excluding the first number because
    'it is encoded with variable parity
    CurrentChar = Asc(Mid(DataToEncode, I, 1))
    CurrentEncoding = Mid(Encoding, I, 1)
    'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
    Select Case CurrentEncoding
      Case "A"
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case "B"
        DataToPrint = DataToPrint & Chr(CurrentChar + 17)
      Case "C"
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
    End Select
    'add in the 1st character along with guard patterns
    Select Case I
      Case 1
        'For the LeadingDigit print the human readable character,
        'the normal guard pattern and then the rest of the barcode
        If LeadingDigit > 4 Then DataToPrint = Chr(Asc(LeadingDigit) + 64) & "(" & DataToPrint
        If LeadingDigit < 5 Then DataToPrint = Chr(Asc(LeadingDigit) + 37) & "(" & DataToPrint
      Case 6
        'Print the center guard pattern after the 6th character
        DataToPrint = DataToPrint & "*"
      Case 12
        'For the last character (12) print the the normal guard pattern
        'after the barcode
         DataToPrint = DataToPrint & "("
    End Select
Next I

'Process 5 digit add on if it exists
If Len(EAN5AddOn) = 5 Then
    EANAddOnToPrint = ""
    'Get check digit for add on
    Factor = 3
    weightedTotal = "0"
    For I = Len(EAN5AddOn) To 1 Step -1
        'Get the value of each number starting at the end
        CurrentChar = Mid(EAN5AddOn, I, 1)
        'multiply by the weighting factor which is 3,9,3,9.
        'and add the sum together
        If Factor = "3" Then weightedTotal = weightedTotal + CurrentChar * 3
        If Factor = "1" Then weightedTotal = weightedTotal + CurrentChar * 9
        'change factor for next calculation
        Factor = 4 - Factor
    Next I
    'Find the CheckDigit by extracting the right-most number from weightedTotal
    CheckDigit = Right$(weightedTotal, 1)
    'Now we must encode the add-on CheckDigit into the number sets
    'by using variable parity between character sets A and B
    Select Case CheckDigit
        Case 0
            Encoding = "BBAAA"
        Case 1
            Encoding = "BABAA"
        Case 2
            Encoding = "BAABA"
        Case 3
            Encoding = "BAAAB"
        Case 4
            Encoding = "ABBAA"
        Case 5
            Encoding = "AABBA"
        Case 6
            Encoding = "AAABB"
        Case 7
            Encoding = "ABABA"
        Case 8
            Encoding = "ABAAB"
        Case 9
            Encoding = "AABAB"
    End Select
    
    'Now that we have the total number including the check digit, determine character to print
    'for proper barcoding:
    For I = 1 To Len(EAN5AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN5AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
          'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 3
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 4
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 5
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
    
    
End If

'Process 2 digit add on if it exists
If Len(EAN2AddOn) = 2 Then
    EANAddOnToPrint = ""
    'Get encoding for add on
    For I = 0 To 99 Step 4
        If EAN2AddOn = I Then Encoding = "AA"
        If EAN2AddOn = I + 1 Then Encoding = "AB"
        If EAN2AddOn = I + 2 Then Encoding = "BA"
        If EAN2AddOn = I + 3 Then Encoding = "BB"
    Next I
    'Now that we have the total number including the encoding
    'determine what to print
    For I = 1 To Len(EAN2AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN2AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
          'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
End If

'Get Printable String
Printable_string = DataToPrint & EANAddOnToPrint & " "

'Return PrintableString
EAN13 = Printable_string

End Function

Public Function EAN8(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the EAN-8 barcode
' Enter all the numbers without dashes
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData
If Len(DataToEncode) <> "7" Then
    MsgBox "Cannot process; you MUST enter a 7 digit NUMBER for this type of barcode. Do not use any spaces or dashes."
    Exit Function
End If

'<<<< Calculate Check Digit >>>>
Factor = 3
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'multiply by the weighting factor which is 3,1,3,1...
    'and add the sum together
    weightedTotal = weightedTotal + CurrentChar * Factor
    'change factor for next calculation
    Factor = 4 - Factor
Next I
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If
DataToEncode = DataToEncode & CheckDigit
'Now that have the total number including the check digit, determine character to print
'for proper barcoding
For I = 1 To Len(DataToEncode)
    'Get the ASCII value of each number
    CurrentChar = Asc(Mid(DataToEncode, I, 1))
    CurrentEncoding = Mid(Encoding, I, 1)
    'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
    'Print different barcodes according to the location of the CurrentChar
    Select Case I
      Case 1
        'For the first character print the normal guard pattern
        'and then the barcode without the human readable character
        DataToPrint = "(" & Chr(CurrentChar)
      Case 2
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 3
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 4
        'Print the center guard pattern after the 6th character
        DataToPrint = DataToPrint & Chr(CurrentChar) & "*"
      Case 5
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 6
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 7
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 8
        'Print the check digit as 8th character + normal guard pattern
        DataToPrint = DataToPrint & Chr(CurrentChar + 27) & "("
    End Select
Next I

'Get Printable String
Printable_string = DataToPrint & " "

'Display PrintableString in textbox
EAN8 = Printable_string

End Function


Public Function Interleaved2of5(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData
'Check for an even number of digits, add 0 if not even
If (Len(DataToEncode) Mod 2) = 1 Then DataToEncode = "0" & DataToEncode

'Assign start and stop codes
StartCode = Chr(40)
StopCode = Chr(41)

For I = 1 To Len(DataToEncode) Step 2
    'Get the value of each number pair
    CurrentChar = (Mid(DataToEncode, I, 2))
    'Get the ASCII value of CurrentChar according to chart by adding 130 to value
    DataToPrint = DataToPrint & Chr(CurrentChar + 130)
    
Next I

'Get Printable String
Printable_string = StartCode + DataToPrint + StopCode & " "

'Return PrintableString
Interleaved2of5 = Printable_string

End Function

Public Function Interleaved2of5Mod10(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' The purpose of this code is to print the Interleaved 2 of 5 barcode
' With a MOD 10 check digit. This is now required by the US Post Office for
' printing barcodes on US MAIL for their "Special Services". Use the AdvI25p
' font when printing barcodes for US MAIL.
'
' Get data from user, this is the DataToEncode
DataToEncode = RTrim(LTrim(DataToEncode))
DataToPrint = ""

' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

'<<<< Calculate Check Digit >>>>
Factor = 3
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'multiply by the weighting factor which is 3,1,3,1...
    'and add the sum together
    weightedTotal = weightedTotal + CurrentChar * Factor
    'change factor for next calculation
    Factor = 4 - Factor
Next I
'Find the CheckDigit by finding the smallest number that = a multiple of 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If
'Add check digit to number to DataToEncode
DataToEncode = DataToEncode & CheckDigit

'Check for an even number of digits, add 0 if not even
If (Len(DataToEncode) Mod 2) = 1 Then DataToEncode = "0" & DataToEncode

For I = 1 To Len(DataToEncode) Step 2
    'Get the value of each number pair
    CurrentChar = (Mid(DataToEncode, I, 2))
    'Get the ASCII value of CurrentChar according to chart by adding 130 to value
    DataToPrint = DataToPrint & Chr(CurrentChar + 130)
Next I

'Get PrintableString
Printable_string = Chr(40) & DataToPrint & Chr(41) & " "

'Return PrintableString
Interleaved2of5Mod10 = Printable_string

End Function



Public Function MSI(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

'<<<< Calculate Check Digit >>>>
Dim OddNumbers As String
Dim EvenNumberSum As Integer
Dim OddProductSum As Integer
weightedTotal = "0"
For I = 1 To Len(DataToEncode) Step 1
    'Get the value of each EVEN number, 1st number is even & add them together
    If (I Mod 2) = "1" Then EvenNumberSum = EvenNumberSum + Mid(DataToEncode, I, 1)
    'Get the value of each ODD number, 2nd nuymber is odd & gether them
    If (I Mod 2) = "0" Then OddNumbers = OddNumbers & Mid(DataToEncode, I, 1)
Next I
'Multiply odd number gethered by 2
OddNumbers = OddNumbers * 2
'Add the digits of the product together
OddProductSum = "0"
For I = 1 To Len(OddNumbers)
    OddProductSum = OddProductSum + Mid(OddNumbers, I, 1)
Next I
weightedTotal = OddProductSum + EvenNumberSum
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If

'Get Printable String
DataToPrint = DataToEncode
Printable_string = "(" & DataToPrint & CheckDigit & ")" & " "

'Return PrintableString
MSI = Printable_string

End Function

Public Function Postnet(DataToEncode As String) As String
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' The purpose of this code is to calculate the POSTNET barcode
' Enter all the numbers without dashes
' You MUST install the AdvPOSTNET font for this application to print
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToEncode = OnlyCorrectData

'<<<< Calculate Check Digit >>>>
weightedTotal = "0"
For I = 1 To Len(DataToEncode)
    'Get the value of each number
    CurrentChar = Mid(DataToEncode, I, 1)
    'add the values together
    weightedTotal = weightedTotal + CurrentChar
Next I
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If

'Get Printable String
DataToPrint = DataToEncode
Printable_string = "(" & DataToPrint & CheckDigit & ")" & " "

'Return PrintableString
Postnet = Printable_string

End Function

Public Function UCC128(DataToEncode As String) As String
'
' This code is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
' The purpose for this code is to generate a check digit and print a barcode
' according to the UCC-128 EAN-128, SSCC-18 and SCC-14 standards.
'
' UCC/EAN-128 calls for the FNC1 character to be entered, since this cannot
' be printed from the keyboard you must enter FA for the FNC1 code.
' The first FNC1 code is included automatically but you may need to enter this FA
' code if you need to enter another FNC1 code in the middle of the number.
' If you do this MAKE SURE that EVEN numbers are between "FA"; this code performs
' no checking for this!!
'
' Here is an example:  1234FA567800
'
' You MUST use the fully functional Code 128 Version 2.0 or above
' font for this code to create and print a proper barcode
'
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric or "FA" and remove all others.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode) Step 2
    'Add all numbers and "FA" to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 2)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 2)
    If Mid(DataToEncode, I, 2) = "FA" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 2)
Next I
DataToEncode = OnlyCorrectData
'Assign start, stop and FNC1 codes
StartCode = Chr(205)
StopCode = Chr(206)
Fnc1 = Chr(202)
' CurrentValue
'<<<< Calculate Modulo 103 Check Digit and generate DataToPrint >>>>
'Set WeightedTotal to the Code 128 value of the start character + Fnc1
weightedTotal = 105 + 102
WeightValue = 2
For I = 1 To Len(DataToEncode) Step 2
    'Get the value of each number pair
    CurrentChar = Mid(DataToEncode, I, 2)
    'get the DataToPrint
    If CurrentChar <> "FA" Then
        'set the Integer CurrentValue to the number of String CurrentChar
        CurrentValue = CInt(CurrentChar)
        If CurrentValue < 95 And CurrentValue > 0 Then DataToPrint = DataToPrint & Chr(CurrentValue + 32)
        If CurrentValue > 94 Then DataToPrint = DataToPrint & Chr(CurrentValue + 100)
        If CurrentValue = 0 Then DataToPrint = DataToPrint & Chr(159)
    Else:
        If CurrentChar = "FA" Then DataToPrint = DataToPrint & Chr(202)
    End If
    'multiply by the weighting character
    If CurrentChar <> "FA" Then CurrentValue = CurrentValue * WeightValue
    If CurrentChar = "FA" Then CurrentValue = 102 * WeightValue
    'add the values together to get the weighted total
    weightedTotal = weightedTotal + CurrentValue
    WeightValue = WeightValue + 1
Next I
'divide the WeightedTotal by 103 and get the remainder, this is the CheckDigitValue
CheckDigitValue = (weightedTotal Mod 103)
'Now that we have the CheckDigitValue, find the corresponding ASCII character from the table
If CheckDigitValue < 95 And CheckDigitValue > 0 Then C128_CheckDigit = CheckDigitValue + 32
If CheckDigitValue > 94 Then C128_CheckDigit = CheckDigitValue + 100
If CheckDigitValue = 0 Then C128_CheckDigit = 159
C128_CheckDigit = Chr(C128_CheckDigit)
'
'Get Printable String
Printable_string = StartCode & Fnc1 & DataToPrint & C128_CheckDigit & StopCode & " "

'Return PrintableString
UCC128 = Printable_string

End Function

Public Function UPCa(DataToEncode As String) As String
'
' Copyright © AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' You may use our source code in your applications only if you are using barcode fonts created by AdvanceMeants, Inc.
' and you do not remove the copyright notices in the source code.
'
' The purpose of this code is to calculate the UPC-A barcode
' Enter all the numbers without dashes
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
'Remove check digits if they added one
If Len(OnlyCorrectData) = "12" Then OnlyCorrectData = Mid(OnlyCorrectData, 1, 11)
If Len(OnlyCorrectData) = "14" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 11) & Mid(OnlyCorrectData, 13, 2))
If Len(OnlyCorrectData) = "17" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 11) & Mid(OnlyCorrectData, 13, 5))
EAN2AddOn = ""
EAN5AddOn = ""
EANAddOnToPrint = ""
If Len(OnlyCorrectData) = 16 Then EAN5AddOn = Mid(OnlyCorrectData, 12, 5)
If Len(OnlyCorrectData) = 13 Then EAN2AddOn = Mid(OnlyCorrectData, 12, 2)
'split 12 digit number from add-on
DataToEncode = Mid(OnlyCorrectData, 1, 11)

'<<<< Calculate Check Digit >>>>
Factor = 3
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'multiply by the weighting factor which is 3,1,3,1...
    'and add the sum together
    weightedTotal = weightedTotal + CurrentChar * Factor
    'change factor for next calculation
    Factor = 4 - Factor
Next I
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If

DataToEncode = DataToEncode & CheckDigit
'Now that have the total number including the check digit, determine character to print
'for proper barcoding
For I = 1 To Len(DataToEncode)
    'Get the ASCII value of each number
    CurrentChar = Asc(Mid(DataToEncode, I, 1))
    'Print different barcodes according to the location of the CurrentChar
    Select Case I
      Case 1
        'For the first character print the human readable character, the normal
        'guard pattern and then the barcode without the human readable character
        If Chr(CurrentChar) > 4 Then DataToPrint = Chr(CurrentChar + 64) & "(" & Chr(CurrentChar + 49)
        If Chr(CurrentChar) < 5 Then DataToPrint = Chr(CurrentChar + 37) & "(" & Chr(CurrentChar + 49)
      Case 2
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 3
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 4
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 5
        DataToPrint = DataToPrint & Chr(CurrentChar)
      Case 6
        'Print the center guard pattern after the 6th character
        DataToPrint = DataToPrint & Chr(CurrentChar) & "*"
      Case 7
        'Add 27 to the ASII value of characters 6-12 to print from character set+ C
        'this is required when printing to the right of the center guard pattern
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 8
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 9
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 10
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 11
        DataToPrint = DataToPrint & Chr(CurrentChar + 27)
      Case 12
        'For the last character print the barcode without the human readable character,
        'the normal guard pattern and then the human readable character.
        If Chr(CurrentChar) > 4 Then DataToPrint = DataToPrint & Chr(CurrentChar + 59) & "(" & Chr(CurrentChar + 64)
        If Chr(CurrentChar) < 5 Then DataToPrint = DataToPrint & Chr(CurrentChar + 59) & "(" & Chr(CurrentChar + 37)
    End Select
Next I

'Process 5 digit add on if it exists
If Len(EAN5AddOn) = 5 Then
    EANAddOnToPrint = ""
    'Get check digit for add on
    Factor = 3
    weightedTotal = "0"
    For I = Len(EAN5AddOn) To 1 Step -1
        'Get the value of each number starting at the end
        CurrentChar = Mid(EAN5AddOn, I, 1)
        'multiply by the weighting factor which is 3,9,3,9.
        'and add the sum together
        If Factor = "3" Then weightedTotal = weightedTotal + CurrentChar * 3
        If Factor = "1" Then weightedTotal = weightedTotal + CurrentChar * 9
        'change factor for next calculation
        Factor = 4 - Factor
    Next I
    'Find the CheckDigit by extracting the right-most number from weightedTotal
    CheckDigit = Right$(weightedTotal, 1)
    'Now we must encode the add-on CheckDigit into the number sets
    'by using variable parity between character sets A and B
    Select Case CheckDigit
        Case 0
            Encoding = "BBAAA"
        Case 1
            Encoding = "BABAA"
        Case 2
            Encoding = "BAABA"
        Case 3
            Encoding = "BAAAB"
        Case 4
            Encoding = "ABBAA"
        Case 5
            Encoding = "AABBA"
        Case 6
            Encoding = "AAABB"
        Case 7
            Encoding = "ABABA"
        Case 8
            Encoding = "ABAAB"
        Case 9
            Encoding = "AABAB"
    End Select
    
    'Now that we have the total number including the check digit, determine character to print
    'for proper barcoding:
    For I = 1 To Len(EAN5AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN5AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            'EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
            EANAddOnToPrint = Chr(43) & EANAddOnToPrint & Chr(33)
            'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 3
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 4
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 5
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
    
    
End If

'Process 2 digit add on if it exists
If Len(EAN2AddOn) = 2 Then
    EANAddOnToPrint = ""
    'Get encoding for add on
    For I = 0 To 99 Step 4
        If EAN2AddOn = I Then Encoding = "AA"
        If EAN2AddOn = I + 1 Then Encoding = "AB"
        If EAN2AddOn = I + 2 Then Encoding = "BA"
        If EAN2AddOn = I + 3 Then Encoding = "BB"
    Next I
    'Now that we have the total number including the encoding
    'determine what to print
    For I = 1 To Len(EAN2AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN2AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            'EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
            EANAddOnToPrint = Chr(43) & EANAddOnToPrint & Chr(33)
            'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
End If

'Get Printable String
Printable_string = DataToPrint & EANAddOnToPrint & " "

'Return PrintableString
UPCa = Printable_string
End Function

Public Function Codabar(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com
'
' The purpose of this code is to print the Codabar barcode
DataToPrint = ""
DataToEncode = RTrim(LTrim(DataToEncode))

' Check to make sure data is numeric, $, +, -, /, or :, and remove all others.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "$" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "+" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "-" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "/" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = "." Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
    If Mid(DataToEncode, I, 1) = ":" Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
DataToPrint = OnlyCorrectData

'Get Printable String
Printable_string = "A" & DataToPrint & "B" & " "

'Return PrintableString
Codabar = Printable_string

End Function

Public Function UPCe(DataToEncode As String) As String
'
' This module is Copyright, AdvanceMeants, Inc. 2000.  All rights reserved.
' For more info visit http://www.BizFonts.com or http://www.AdvanceMeants.com
'
' The purpose of this code is to print the UPC-E barcode
' from a UPC-A barcode that can be compressed.
'
' Get data from user, this is the DataToEncode
DataToEncode = RTrim(LTrim(DataToEncode))
DataToPrint = ""
' Check to make sure data is numeric and remove dashes, etc.
OnlyCorrectData = ""
For I = 1 To Len(DataToEncode)
    'Add all numbers to OnlyCorrectData string
    If IsNumeric(Mid(DataToEncode, I, 1)) Then OnlyCorrectData = OnlyCorrectData & Mid(DataToEncode, I, 1)
Next I
'Remove check digits if they added one
If Len(OnlyCorrectData) = "12" Then OnlyCorrectData = Mid(OnlyCorrectData, 1, 11)
If Len(OnlyCorrectData) = "14" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 11) & Mid(OnlyCorrectData, 13, 2))
If Len(OnlyCorrectData) = "17" Then OnlyCorrectData = (Mid(OnlyCorrectData, 1, 11) & Mid(OnlyCorrectData, 13, 5))
EAN2AddOn = ""
EAN5AddOn = ""
EANAddOnToPrint = ""
If Len(OnlyCorrectData) = 16 Then EAN5AddOn = Mid(OnlyCorrectData, 12, 5)
If Len(OnlyCorrectData) = 13 Then EAN2AddOn = Mid(OnlyCorrectData, 12, 2)
'split 12 digit number from add-on
DataToEncode = Mid(OnlyCorrectData, 1, 11)

'<<<< Calculate Check Digit >>>>
Factor = 3
weightedTotal = "0"
For I = Len(DataToEncode) To 1 Step -1
    'Get the value of each number starting at the end
    CurrentChar = Mid(DataToEncode, I, 1)
    'multiply by the weighting factor which is 3,1,3,1...
    'and add the sum together
    weightedTotal = weightedTotal + CurrentChar * Factor
    'change factor for next calculation
    Factor = 4 - Factor
Next I
'Find the CheckDigit by finding the number + weightedTotal that = a multiple of 10
'divide by 10, get the remainder and subtract from 10
I = (weightedTotal Mod 10)
If I <> 0 Then
    CheckDigit = (10 - I)
Else
    CheckDigit = 0
End If

DataToEncode = DataToEncode & CheckDigit
'Compress UPC-A to UPC-E if possible
Dim D1 As String
Dim D2 As String
Dim D3 As String
Dim D4 As String
Dim D5 As String
Dim D6 As String
Dim D7 As String
Dim D8 As String
Dim D9 As String
Dim D10 As String
Dim D11 As String
Dim D12 As String
D1 = Mid(DataToEncode, 1, 1)
D2 = Mid(DataToEncode, 2, 1)
D3 = Mid(DataToEncode, 3, 1)
D4 = Mid(DataToEncode, 4, 1)
D5 = Mid(DataToEncode, 5, 1)
D6 = Mid(DataToEncode, 6, 1)
D7 = Mid(DataToEncode, 7, 1)
D8 = Mid(DataToEncode, 8, 1)
D9 = Mid(DataToEncode, 9, 1)
D10 = Mid(DataToEncode, 10, 1)
D11 = Mid(DataToEncode, 11, 1)
D12 = Mid(DataToEncode, 12, 1)
'Condition A
If (D11 = "5" Or D11 = "6" Or D11 = "7" Or D11 = "8" Or D11 = 9) And D6 <> "0" And (D7 = "0" And D8 = "0" And D9 = "0" And D10 = "0") Then
    DataToEncode = D2 & D3 & D4 & D5 & D6 & D11
End If
'Condition B
If (D6 = "0" And D7 = "0" And D8 = "0" And D9 = "0" And D10 = "0") And D5 <> "0" Then
    DataToEncode = D2 & D3 & D4 & D5 & D11 & "4"
End If
'Condition C
If (D5 = "0" And D6 = "0" And D7 = "0" And D8 = "0") And (D4 = "1" Or D4 = "2" Or D4 = "0") Then
    DataToEncode = D2 & D3 & D9 & D10 & D11 & D4
End If
'Condition D
If (D5 = "0" And D6 = "0" And D7 = "0" And D8 = "0" And D9 = "0") And (D4 = "3" Or D4 = "4" Or D4 = "5" Or D4 = "6" Or D4 = "7" Or D4 = "8" Or D4 = "9") Then
    DataToEncode = D2 & D3 & D4 & D10 & D11 & "3"
End If
'
'Run UPC-E compression only if DataToEncode = 6
If Len(DataToEncode) = 6 Then
    'Now we must encode the check character into the symbol
    'by using variable parity between character sets A and B
    Select Case D12
        Case 0
            Encoding = "BBBAAA"
        Case 1
            Encoding = "BBABAA"
        Case 2
            Encoding = "BBAABA"
        Case 3
            Encoding = "BBAAAB"
        Case 4
            Encoding = "BABBAA"
        Case 5
            Encoding = "BAABBA"
        Case 6
            Encoding = "BAAABB"
        Case 7
            Encoding = "BABABA"
        Case 8
            Encoding = "BABAAB"
        Case 9
            Encoding = "BAABAB"
    End Select
    For I = 1 To Len(DataToEncode)
        'Get the ASCII value of each number
        CurrentChar = Asc(Mid(DataToEncode, I, 1))
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            DataToPrint = DataToPrint & Chr(CurrentChar)
          Case "B"
            DataToPrint = DataToPrint & Chr(CurrentChar + 17)
        End Select
        'add in the 1st character along with guard patterns
        Select Case I
          Case 1
            'For the LeadingDigit print the human readable character,
            'the normal guard pattern and then the rest of the barcode
            DataToPrint = Chr(85) & "(" & DataToPrint
          Case 6
            'Print the SPECIAL guard pattern and check character
            If CInt(D12) > 4 Then DataToPrint = DataToPrint & ")" & Chr(Asc(D12) + 64)
            If CInt(D12) < 5 Then DataToPrint = DataToPrint & ")" & Chr(Asc(D12) + 37)
    
        End Select
    Next I
End If

'determine character to print
'for proper upc-a barcoding
If Len(DataToEncode) <> 6 Then
    For I = 1 To Len(DataToEncode)
        'Get the ASCII value of each number
        CurrentChar = Asc(Mid(DataToEncode, I, 1))
        'Print different barcodes according to the location of the CurrentChar
        Select Case I
          Case 1
            'For the first character print the human readable character, the normal
            'guard pattern and then the barcode without the human readable character
            If Chr(CurrentChar) > 4 Then DataToPrint = Chr(CurrentChar + 64) & "(" & Chr(CurrentChar + 49)
            If Chr(CurrentChar) < 5 Then DataToPrint = Chr(CurrentChar + 37) & "(" & Chr(CurrentChar + 49)
          Case 2
            DataToPrint = DataToPrint & Chr(CurrentChar)
          Case 3
            DataToPrint = DataToPrint & Chr(CurrentChar)
          Case 4
            DataToPrint = DataToPrint & Chr(CurrentChar)
          Case 5
            DataToPrint = DataToPrint & Chr(CurrentChar)
          Case 6
            'Print the center guard pattern after the 6th character
            DataToPrint = DataToPrint & Chr(CurrentChar) & "*"
          Case 7
            'Add 27 to the ASII value of characters 6-12 to print from character set+ C
            'this is required when printing to the right of the center guard pattern
            DataToPrint = DataToPrint & Chr(CurrentChar + 27)
          Case 8
            DataToPrint = DataToPrint & Chr(CurrentChar + 27)
          Case 9
            DataToPrint = DataToPrint & Chr(CurrentChar + 27)
          Case 10
            DataToPrint = DataToPrint & Chr(CurrentChar + 27)
          Case 11
            DataToPrint = DataToPrint & Chr(CurrentChar + 27)
          Case 12
            'For the last character print the barcode without the human readable character,
            'the normal guard pattern and then the human readable character.
            If Chr(CurrentChar) > 4 Then DataToPrint = DataToPrint & Chr(CurrentChar + 59) & "(" & Chr(CurrentChar + 64)
            If Chr(CurrentChar) < 5 Then DataToPrint = DataToPrint & Chr(CurrentChar + 59) & "(" & Chr(CurrentChar + 37)
        End Select
    Next I
End If

'Process 5 digit add on if it exists
If Len(EAN5AddOn) = 5 Then
    EANAddOnToPrint = ""
    'Get check digit for add on
    Factor = 3
    weightedTotal = "0"
    For I = Len(EAN5AddOn) To 1 Step -1
        'Get the value of each number starting at the end
        CurrentChar = Mid(EAN5AddOn, I, 1)
        'multiply by the weighting factor which is 3,9,3,9.
        'and add the sum together
        If Factor = "3" Then weightedTotal = weightedTotal + CurrentChar * 3
        If Factor = "1" Then weightedTotal = weightedTotal + CurrentChar * 9
        'change factor for next calculation
        Factor = 4 - Factor
    Next I
    'Find the CheckDigit by extracting the right-most number from weightedTotal
    CheckDigit = Right$(weightedTotal, 1)
    'Now we must encode the add-on CheckDigit into the number sets
    'by using variable parity between character sets A and B
    Select Case CheckDigit
        Case 0
            Encoding = "BBAAA"
        Case 1
            Encoding = "BABAA"
        Case 2
            Encoding = "BAABA"
        Case 3
            Encoding = "BAAAB"
        Case 4
            Encoding = "ABBAA"
        Case 5
            Encoding = "AABBA"
        Case 6
            Encoding = "AAABB"
        Case 7
            Encoding = "ABABA"
        Case 8
            Encoding = "ABAAB"
        Case 9
            Encoding = "AABAB"
    End Select
    
    'Now that we have the total number including the check digit, determine character to print
    'for proper barcoding:
    For I = 1 To Len(EAN5AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN5AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            'EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
            EANAddOnToPrint = Chr(43) & EANAddOnToPrint & Chr(33)
            'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 3
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 4
            EANAddOnToPrint = EANAddOnToPrint & Chr(33)
          Case 5
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
End If

'Process 2 digit add on if it exists
If Len(EAN2AddOn) = 2 Then
    EANAddOnToPrint = ""
    'Get encoding for add on
    For I = 0 To 99 Step 4
        If EAN2AddOn = I Then Encoding = "AA"
        If EAN2AddOn = I + 1 Then Encoding = "AB"
        If EAN2AddOn = I + 2 Then Encoding = "BA"
        If EAN2AddOn = I + 3 Then Encoding = "BB"
    Next I
    'Now that we have the total number including the encoding
    'determine what to print
    For I = 1 To Len(EAN2AddOn)
        'Get the value of each number
        'it is encoded with variable parity
        CurrentChar = Mid(EAN2AddOn, I, 1)
        CurrentEncoding = Mid(Encoding, I, 1)
        'Print different barcodes according to the location of the CurrentChar and CurrentEncoding
        Select Case CurrentEncoding
          Case "A"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(34)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(35)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(36)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(37)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(38)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(44)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(46)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(47)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(58)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(59)
          Case "B"
            If CurrentChar = "0" Then EANAddOnToPrint = EANAddOnToPrint & Chr(122)
            If CurrentChar = "1" Then EANAddOnToPrint = EANAddOnToPrint & Chr(61)
            If CurrentChar = "2" Then EANAddOnToPrint = EANAddOnToPrint & Chr(63)
            If CurrentChar = "3" Then EANAddOnToPrint = EANAddOnToPrint & Chr(64)
            If CurrentChar = "4" Then EANAddOnToPrint = EANAddOnToPrint & Chr(91)
            If CurrentChar = "5" Then EANAddOnToPrint = EANAddOnToPrint & Chr(92)
            If CurrentChar = "6" Then EANAddOnToPrint = EANAddOnToPrint & Chr(93)
            If CurrentChar = "7" Then EANAddOnToPrint = EANAddOnToPrint & Chr(95)
            If CurrentChar = "8" Then EANAddOnToPrint = EANAddOnToPrint & Chr(123)
            If CurrentChar = "9" Then EANAddOnToPrint = EANAddOnToPrint & Chr(125)
        End Select
        'add in the space & add-on guard pattern
        Select Case I
          Case 1
            'EANAddOnToPrint = Chr(32) & Chr(43) & EANAddOnToPrint & Chr(33)
            EANAddOnToPrint = Chr(43) & EANAddOnToPrint & Chr(33)
            'Now print add-on delineators between each add-on character
          Case 2
            EANAddOnToPrint = EANAddOnToPrint
        End Select
    Next I
End If

'Get Printable String
Printable_string = DataToPrint & EANAddOnToPrint & " "

'Return PrintableString
UPCe = Printable_string

End Function
