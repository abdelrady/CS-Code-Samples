VERSION 5.00
Begin VB.Form frmBarcodeTest 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "BarcodeTest"
   ClientHeight    =   3990
   ClientLeft      =   45
   ClientTop       =   360
   ClientWidth     =   6255
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   266
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   417
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtPrintValues 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   120
      TabIndex        =   2
      Text            =   "1234567890"
      Top             =   120
      Width           =   3495
   End
   Begin VB.CommandButton comPrintValues 
      Caption         =   "Print Values"
      Height          =   285
      Left            =   3720
      TabIndex        =   1
      Top             =   120
      Width           =   2415
   End
   Begin VB.PictureBox picBarcode 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   3375
      Left            =   120
      ScaleHeight     =   223
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   399
      TabIndex        =   0
      Top             =   480
      Width           =   6015
   End
End
Attribute VB_Name = "frmBarcodeTest"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'BarcodeTest: A barcode printer. Right now only accepts a subset of
'Code128B (A-Z & 0-9) but can print all that is required by the check character.
'Output is correct using my Argox barcode scanner. Uses the "Start B" set.
'If you want to test it, do a print screen and paste the generated barcode
'into MS Word. Then print using the "High Quality" setting

Option Explicit

'Created to ease data storage
Private Type CodeInfo
    Char As String
    Location As Long
End Type

'Data is stored here
Private auCode() As CodeInfo
Private asBinary() As String

Private Sub codeLoadData()
    'This sub loads Code128 data into memory
    
    Dim sFilePath As String, sFilename As String
    Dim iFN As Integer, lX As Long, lCount As Long
    Dim sData As String, asData() As String, asElement() As String
    
    'Specify the 1st data file (several available chars (I didn't include all chars) and the location of it's binary code)
    sFilePath = App.Path
    If Not Right(sFilePath, 1) = "\" Then sFilePath = sFilePath & "\"
    sFilename = "char.txt"
    
    'Make space for data
    sData = Space$(FileLen(sFilePath & sFilename))
    
    'Open data file, load into memory
    iFN = FreeFile
    Open sFilePath & sFilename For Binary As iFN
    Get iFN, 1, sData
    Close iFN
    
    'Store data it into arrays
    asData = Split(sData, vbCrLf) 'Each line is split
    lCount = UBound(asData)
    ReDim auCode(lCount)
    For lX = 0 To lCount
        asElement = Split(asData(lX), vbTab)
        auCode(lX).Location = CLng(asElement(0))
        auCode(lX).Char = asElement(1)
    Next lX
    
    'Specify the 2nd data file (binary code of all 107 chars in Start A / Start B)
    sFilename = "binary.txt"
    
    'Make space for data
    sData = Space$(FileLen(sFilePath & sFilename))
    
    'Open data file, load into memory
    iFN = FreeFile
    Open sFilePath & sFilename For Binary As iFN
    Get iFN, 1, sData
    Close iFN
    
    'Store data it into arrays
    asData = Split(sData, vbCrLf)
    lCount = UBound(asData)
    ReDim asBinary(lCount)
    For lX = 0 To lCount
        asBinary(lX) = asData(lX)
    Next lX
    
End Sub

Private Function codeCharToBinary(sChar As String) As String
    'Returns the binary code of sChar
    codeCharToBinary = asBinary(codeGetCharID(sChar))
End Function

Private Function codeGetCharID(sChar As String) As Long
    'Returns the location of sChar in asBinary
    Dim lX As Long
    
    'Loop through array to find matching sChar
    For lX = 0 To UBound(auCode, 1)
        If StrComp(auCode(lX).Char, sChar, vbTextCompare) = 0 Then
            'Found. Return the location
            codeGetCharID = auCode(lX).Location
            Exit For
        End If
    Next lX
End Function

Private Function codeCheck(sText As String) As String
    'Returns the binary code of the check char
    'Used to generate the check character. Search google for a better description of the process
    Dim lX As Long, lCodeCheck As Long
    
    'The process here is "(start char value) + Sum(value * weight of all chars)"
    lCodeCheck = 103
    For lX = 1 To Len(sText)
        lCodeCheck = lCodeCheck + lX * codeGetCharID(Mid(sText, lX, 1))
    Next lX
    
    'The total is divided by 103, and the remainder is used as the check char. Or in other words, "Total Mod 103"
    'Get the binary code and return it
    codeCheck = asBinary(lCodeCheck Mod 103)
End Function

Private Sub codePrint(oDevice As Object, sText As String, Optional isPrinter As Boolean = False)
    'Print the whole code
    Const lPosY As Long = 10
    Const lBarDist As Long = 1
    Const lBarWidth As Long = 0
    Const lBarHeight As Long = 50
    Dim lPosX As Long
    Dim lX As Long, lY As Long
    Dim sPrint As String, sCurBinary As String, sCurChar As String
    
    'Clear the picBox. I used "oDevice As Object" because I'm going to add printer
    'support sooner of later (maybe much much later...)
    oDevice.Cls
    
    'The starting "X" position
    lPosX = 10
    
    'Print the starting char first
    codePrintChar oDevice, asBinary(codeGetCharID("<")), lPosX, lPosY, lBarDist, lBarWidth, lBarHeight
    
    'The loop through the whole message and print each one
    For lX = 1 To Len(sText)
        sCurChar = Mid(sText, lX, 1)
        sCurBinary = asBinary(codeGetCharID(sCurChar))
        codePrintChar oDevice, sCurBinary, lPosX, lPosY, lBarDist, lBarWidth, lBarHeight
    Next lX
    
    'Next is the check char
    codePrintChar oDevice, codeCheck(sText), lPosX, lPosY, lBarDist, lBarWidth, lBarHeight
    
    'Finally the stop char
    codePrintChar oDevice, asBinary(codeGetCharID(">")), lPosX, lPosY, lBarDist, lBarWidth, lBarHeight
End Sub

Private Sub codePrintChar(oDevice As Object, sBinary As String, ByRef lPosX As Long, lPosY As Long, lBarDist As Long, lBarWidth As Long, lBarHeight As Long)
    'Prints one individual char barcode. Only accepts binary code
    Dim lY As Long
    
    For lY = 1 To Len(sBinary)
    
        'If the current bit is 1, print a line at the X position
        If StrComp(Mid(sBinary, lY, 1), "1", vbTextCompare) = 0 Then oDevice.Line (lPosX, lPosY)-(lPosX + lBarWidth, lPosY + 50), , BF
        
        'Move X position a certain distance
        lPosX = lPosX + lBarDist + lBarWidth
        
    Next lY
End Sub

Private Sub comPrintValues_Click()
    'Print it
    codePrint picBarcode, txtPrintValues.Text
End Sub

Private Sub Form_Load()
    'Load required Code128 data first
    codeLoadData
End Sub
