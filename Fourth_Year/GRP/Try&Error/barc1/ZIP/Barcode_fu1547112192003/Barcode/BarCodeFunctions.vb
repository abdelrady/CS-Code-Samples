Option Explicit On 

Imports System.Drawing

'* Module BarCodeFunctions.vb
'* 
'*    Author : Paulo S. Silva Jr.
'*      Date : February 2003
'* Objective : Gather Function to draw Barcodes
'*
'* Methods :
'*
'*   +-------------------+----------------------------------------------------+
'*   | Name              | Description                                        |
'*   +-------------------+----------------------------------------------------+
'*   | EAN2Bin           | Convert an EAN Code on its binary form             |
'*   | PrintEANBarCode   | Print an EAN Barcode on a PictureBox               |
'*   +-------------------+----------------------------------------------------+
'*
'*

Module BarCodeFunctions

    '*
    '* Function  : EAN2Bin
    '*
    '* Objective : Convert an EAN8 or EAN13 in a sequence of 1 and 0 
    '*                  where 1 means a stripe and 0 means a space
    '*
    Private Function EAN2Bin(ByVal strEANCode As String) As String

        Dim K As Integer
        Dim strAux As String
        Dim strExit As String
        Dim strCode As String

        strEANCode = Trim(strEANCode)
        strAux = strEANCode

        '*
        '* Check to see what kind of EAN the code will be
        '*
        If (strAux.Length <> 13) And (strAux.Length <> 8) Then
            '*
            '* If it's not 8 nor 13 "Error: Invalid Function Call"
            '*
            Err.Raise(5, "EAN2Bin", "Invalid EAN Code")
        End If

        '*
        '* Check for numbers only
        '*
        For K = 0 To strEANCode.Length - 1
            Select Case (strAux.Chars(K).ToString)
                Case Is < "0", Is > "9"
                    '*
                    '* Invalid char "Error: Invalid Function Call"
                    '*
                    Err.Raise(5, "EAN2Bin", "Invalid char on EAN Code")
            End Select
        Next

        '*
        '* It's EAN13
        '*
        If (strAux.Length = 13) Then
            '*
            '* The EAN13 is a special code formated as follow
            '*
            '*          CnnnnnnnnnnnK
            '*
            '* Where : C - is not part of the code, but coded in the next 6 digits
            '*         n - THE NUMBER
            '*         K - is a check digit (this function do not calculate this)
            '*
            '* When the first digit of an EAN13 code is 0 (zero) it matches an UPC (12 digits) code

            '*
            '* Skip the first digit of the code
            '*
            strAux = Mid(strAux, 2)

            '*
            '* Select the proper code based on the first digit
            '*
            Select Case CInt(Left(strEANCode, 1))
                Case 0
                    strCode = "000000"
                Case 1
                    strCode = "001011"
                Case 2
                    strCode = "001101"
                Case 3
                    strCode = "001110"
                Case 4
                    strCode = "010011"
                Case 5
                    strCode = "011001"
                Case 6
                    strCode = "011100"
                Case 7
                    strCode = "010101"
                Case 8
                    strCode = "010110"
                Case 9
                    strCode = "011010"
            End Select
        Else
            strCode = "0000"
        End If

        '*
        '* The EAN BarCode starts with a "guardian" 
        '*
        strExit = "000101"

        '*
        '* First half of the code
        '*
        For K = 1 To Len(strAux) \ 2
            Select Case CInt(Mid(strAux, K, 1))
                Case 0
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0001101", "0100111")
                Case 1
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0011001", "0110011")
                Case 2
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0010011", "0011011")
                Case 3
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0111101", "0100001")
                Case 4
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0100011", "0011101")
                Case 5
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0110001", "0111001")
                Case 6
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0101111", "0000101")
                Case 7
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0111011", "0010001")
                Case 8
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0110111", "0001001")
                Case 9
                    strExit &= IIf(Mid(strCode, K, 1) = "0", "0001011", "0010111")
            End Select
        Next K

        '*
        '* Middle "guardian" separator
        '*
        strExit &= "01010"

        '*
        '* Second half of the code
        '*
        For K = Len(strAux) \ 2 + 1 To Len(strAux)
            Select Case CInt(Mid(strAux, K, 1))
                Case 0
                    strExit &= "1110010"
                Case 1
                    strExit &= "1100110"
                Case 2
                    strExit &= "1101100"
                Case 3
                    strExit &= "1000010"
                Case 4
                    strExit &= "1011100"
                Case 5
                    strExit &= "1001110"
                Case 6
                    strExit &= "1010000"
                Case 7
                    strExit &= "1000100"
                Case 8
                    strExit &= "1001000"
                Case 9
                    strExit &= "1110100"
            End Select
        Next K

        '*
        '* The EAN BarCode also finish with a "guardian"
        '*
        strExit &= "101000"

        EAN2Bin = strExit

    End Function

    '* Function : PrintEANBarCode(strEANCode, objPicBox)
    '*
    '*
    Public Sub PrintEANBarCode(ByVal strEANCode As String, _
                                ByVal objPicBox As PictureBox, _
                                Optional ByVal sngX1 As Single = (-1), _
                                Optional ByVal sngY1 As Single = (-1), _
                                Optional ByVal sngX2 As Single = (-1), _
                                Optional ByVal sngY2 As Single = (-1), _
                                Optional ByVal FontForText As Font = Nothing)

        Dim K As Single
        Dim sngPosX As Single
        Dim sngPosY As Single
        Dim sngScaleX As Single
        Dim strEANBin As String
        Dim strFormat As New StringFormat()

        '*
        '* Convert the code on its binary representation
        '*
        strEANBin = EAN2Bin(strEANCode)

        '*
        '* Define the font to be printed
        '*
        If (FontForText Is Nothing) Then
            FontForText = New Font("Courier New", 10)
        End If

        '*
        '* Defines the boundaries to the barcode
        '*
        If sngX1 = (-1) Then sngX1 = 0
        If sngY1 = (-1) Then sngY1 = 0
        If sngX2 = (-1) Then sngX2 = objPicBox.Width
        If sngY2 = (-1) Then sngY2 = objPicBox.Height

        '*
        '* Defines the boundaries of the barcode
        '*
        sngPosX = sngX1
        sngPosY = sngY2 - CSng(1.5 * FontForText.Height)

        '*
        '* Clears the area
        '*
        objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.BackColor), sngX1, sngY1, sngX2 - sngX1, sngY2 - sngY1)

        '*
        '* Calculates the scale
        '*
        sngScaleX = (sngX2 - sngX1) / strEANBin.Length

        '*
        '* Draw the BarCode
        '*
        For K = 1 To Len(strEANBin)
            If Mid(strEANBin, K, 1) = "1" Then
                objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.ForeColor), sngPosX, sngY1, sngScaleX, sngPosY)
            End If
            sngPosX = sngX1 + (K * sngScaleX)
        Next K

        '*
        '* Draw the human-friendly code
        '*
        strFormat.Alignment = StringAlignment.Center
        strFormat.FormatFlags = StringFormatFlags.NoWrap
        objPicBox.CreateGraphics.DrawString(strEANCode, FontForText, New System.Drawing.SolidBrush(objPicBox.ForeColor), CSng((sngX2 - sngX1) / 2), CSng(sngY2 - FontForText.Height), strFormat)

    End Sub

End Module
