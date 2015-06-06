Attribute VB_Name = "modAlgorithm"
'------------------------------------------------------------
' Alex Skinner (deligon@yahoo.com)
'
' Deligon Technologies, Inc. www.deligon.com / www.reapers.org
' CueCat BarCode Decoder Version 1.5
' This version of the source allows decoding of up to 24 Digit Barcodes
' Text and Special characters will be implemented in versions to come.
'
' All information may not be accurate.  The "X" and "-" may not work
' on all barcodes.  I took this information from Microsoft and Some
' Radio Shack products. (Code 39)
'
' This program is for use with the cuecat.  Get it for free at any
' Radio Shack or go to getcat.com or digitalconvergence.com.
'
' Source was put together quickly and may not be 100% efficient or clean.
'------------------------------------------------------------
Global sCueBuffer
Global sCueType


Function cc_decode(sCueCode As String)
    
    sCueCatCode = sCueCode
  Do
    
    nSpace = nSpace + 1
    
    Select Case nSpace
    
    Case 1, 4, 7, 10, 13, 16, 19, 22
      
      sCue = Mid$(sCueCatCode, 1, 2)
      
      If sCue = "C3" Then sBarNum = "0"
      If sCue = "CN" Then sBarNum = "1"
      If sCue = "Cx" Then sBarNum = "2"
      If sCue = "Ch" Then sBarNum = "3"
      If sCue = "D3" Then sBarNum = "4"
      If sCue = "DN" Then sBarNum = "5"
      If sCue = "Dx" Then sBarNum = "6"
      If sCue = "Dh" Then sBarNum = "7"
      If sCue = "E3" Then sBarNum = "8"
      If sCue = "EN" Then sBarNum = "9"
      
      'Special Codes 'Alphanumeric barcodes only.
      If sCue = "g3" Then sBarNum = "X"
      If sCue = "BN" Then sBarNum = "-"

      
      cc_decode = cc_decode & sBarNum
      sCueCatCode = Right$(sCueCatCode, Len(sCueCatCode) - 2)

    Case 2, 5, 8, 11, 14, 17, 20, 23

      sCue = Mid$(sCueCatCode, 1, 1)
      
      If sCue = "n" Then sBarNum = "0"
      If sCue = "j" Then sBarNum = "1"
      If sCue = "f" Then sBarNum = "2"
      If sCue = "b" Then sBarNum = "3"
      If sCue = "D" Then sBarNum = "4"
      If sCue = "z" Then sBarNum = "5"
      If sCue = "v" Then sBarNum = "6"
      If sCue = "r" Then sBarNum = "7"
      If sCue = "T" Then sBarNum = "8"
      If sCue = "P" Then sBarNum = "9"
      
      'Special Codes
      If sCue = "U" Then sBarNum = "-"
      
      cc_decode = cc_decode & sBarNum
      sCueCatCode = Right$(sCueCatCode, Len(sCueCatCode) - 1)
    
    Case 3, 6, 9, 12, 15, 18, 21, 24

      sCue = Mid$(sCueCatCode, 1, 1)
      
      If sCue = "Z" Then sBarNum = "0"
      If sCue = "Y" Then sBarNum = "1"
      If sCue = "X" Then sBarNum = "2"
      If sCue = "W" Then sBarNum = "3"
      If sCue = "3" Then sBarNum = "4"
      If sCue = "2" Then sBarNum = "5"
      If sCue = "1" Then sBarNum = "6"
      If sCue = "0" Then sBarNum = "7"
      If sCue = "7" Then sBarNum = "8"
      If sCue = "6" Then sBarNum = "9"
      
      'Special Codes
      If sCue = "U" Then sBarNum = "-"
      
      cc_decode = cc_decode & sBarNum
      sCueCatCode = Right$(sCueCatCode, Len(sCueCatCode) - 1)
    Case Else
      sCueCatCode = ""
    End Select

  Loop Until sCueCatCode = ""
  
End Function

Function cc_space(sCueString As String, sCodeType As String)
  nBarCount = Len(sCueString)
  
  Select Case sCodeType
    
    Case "UPCA12"
      cc_space = Mid$(sCueString, 1, 1) & " " & Mid$(sCueString, 2, 5) & " " & Mid$(sCueString, 7, 5) & " " & Mid$(sCueString, 12, 1)
    Case "UPC518"
      cc_space = Mid$(sCueString, 1, 1) & " " & Mid$(sCueString, 2, 6) & " " & Mid$(sCueString, 8, 6) & " [" & Mid$(sCueString, 14, 5) & "]"
    Case "UPC513"
      cc_space = Mid$(sCueString, 1, 1) & " " & Mid$(sCueString, 2, 6) & " " & Mid$(sCueString, 8, 6)
    Case "CODE39"
      cc_space = sCueString
    Case "CODE128"
      cc_space = sCueString
      frmBarCode.lblData(3).Caption = "Only the numerical portion of CODE 128 can be deciphered at the moment."
    Case "BESTBUY"
      
      sSale = Left$(sCueString, 2) 'Determine if this is a SALE or a RETURN
      If sSale = "01" Then sSaleCode = "This is a SALE [01]"
      If sSale = "02" Then sSaleCode = "This is a RETURN [02]"

      sReceiptCode = Mid$(sCueString, 3, 4) & " " & Mid$(sCueString, 7, 3) & " " & Mid$(sCueString, 10, 4)
      sDate = Format$(Mid$(sCueString, 14, 8), "##/##/####")
      cc_space = sSaleCode & vbCrLf & "Receipt ID: " & sReceiptCode & vbCrLf & "Date: " & sDate & vbCrLf & "Trailing Code: " & Mid$(sCueString, 22, 1)
  
    Case Else
      cc_space = sCueString & " [ UNKNOWN ]"
  End Select
  
End Function
