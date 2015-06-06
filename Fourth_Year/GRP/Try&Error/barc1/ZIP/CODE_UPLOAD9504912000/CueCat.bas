Attribute VB_Name = "CueCat"
Option Explicit
'Special Thanks to Kevin Fowlks

Public Function CueCatDecode(CueStr As String, CueType As Integer) As String
Dim value(3) As String
Dim i As Integer
Dim t As Integer
Dim flip As Boolean
Dim code As String
Dim bcode As String
Dim barvalue As String

'split the cuecat string into subsections
For i = 0 To 3
 value(i) = Split(CueStr, ".")(i)
Next i

'Intialize vars
t = 0
flip = False
barvalue = ""
code = ""
bcode = ""

'decode time
For i = 1 To Len(value(CueType))
 If Not flip Then
  code = Mid(value(CueType), i, 2)
  Select Case code
   Case "C3": bcode = "0"
   Case "CN": bcode = "1"
   Case "Cx": bcode = "2"
   Case "Ch": bcode = "3"
   Case "D3": bcode = "4"
   Case "DN": bcode = "5"
   Case "Dx": bcode = "6"
   Case "Dh": bcode = "7"
   Case "E3": bcode = "8"
   Case "EN": bcode = "9"
   Case "g3": bcode = "X"
  End Select
  flip = True
 Else
  code = Mid(value(CueType), i + 1, 1)
  Select Case code
   Case "n": bcode = "0"
   Case "Z": bcode = "0"
   Case "j": bcode = "1"
   Case "Y": bcode = "1"
   Case "f": bcode = "2"
   Case "X": bcode = "2"
   Case "b": bcode = "3"
   Case "W": bcode = "3"
   Case "D": bcode = "4"
   Case "3": bcode = "4"
   Case "z": bcode = "5"
   Case "2": bcode = "5"
   Case "v": bcode = "6"
   Case "1": bcode = "6"
   Case "r": bcode = "7"
   Case "0": bcode = "7"
   Case "T": bcode = "8"
   Case "7": bcode = "8"
   Case "P": bcode = "9"
   Case "6": bcode = "9"
  End Select
  t = t + 1
  If t = 2 Then
   flip = False
   i = i + 1
   t = 0
  End If
 End If
 barvalue = barvalue & bcode
 code = ""
 bcode = ""
Next i

CueCatDecode = barvalue
End Function

Public Function CheckDigitISBN(barvalue As String) As Integer
Dim first9 As String
Dim i As Integer
Dim sum As Integer
Dim sss As Integer
Dim ss As Integer

first9 = Left(barvalue, 9)
For i = 1 To 9
 sum = 10 - i
 sss = sum * CInt(Mid(first9, i, 1))
 ss = ss + sss
 sum = 11 - (ss Mod 11)
Next i
CheckDigitISBN = sum
End Function

Public Function BarCodeType(barvalue As String) As String

If barvalue = "cGf2" Then
 BarCodeType = "ISBN"
Else
 BarCodeType = "UNKNOWN"
End If
End Function
