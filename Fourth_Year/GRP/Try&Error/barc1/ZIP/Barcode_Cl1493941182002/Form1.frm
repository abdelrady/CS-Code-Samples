VERSION 5.00
Begin VB.Form frmMain 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Barcode Generator"
   ClientHeight    =   2700
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8025
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2700
   ScaleWidth      =   8025
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picBarcode 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      FillStyle       =   0  'Solid
      FontTransparent =   0   'False
      Height          =   975
      Left            =   120
      ScaleHeight     =   975
      ScaleWidth      =   7695
      TabIndex        =   2
      Top             =   120
      Width           =   7695
   End
   Begin VB.TextBox txtTextline 
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   1320
      Width           =   7695
   End
   Begin VB.CommandButton cmdCopy 
      Caption         =   "&Copy To Clipboard"
      Height          =   495
      Left            =   2700
      TabIndex        =   0
      Top             =   2160
      Width           =   2535
   End
   Begin VB.Label lblCaption 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "Enter text to convert to Code 39 Barcode"
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   1800
      Width           =   7695
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' Barcode Clipboard
' Copyright © 2002, Otto Schellin, ElectraWare
'
' This utility application will copy a standard Code 39 barcode to a Windows OS
' clipboard for use in other applications that support cut-and-paste.

' Revision History
' 03/27/2002 - Version 0.1.0 (Beta) -  Project Inception and initial design. OLS
' 03/28/2002 - Version 0.1.1 (Beta) -  Altered barcode line spacing for better
'                                      reading reliability.
Option Explicit

Dim l1Space As Long
Dim l2Space As Long
Dim lInterChar As Long
Dim l1Line As Long
Dim l2Line As Long
Dim lHeight As Long
Dim lXLoc1 As Long
Dim lXLoc2 As Long
Dim lYStart As Long
Dim Code(32 To 90) As String
Dim lXStart As Long

Private Sub PrintString(sData As String)
   ' Prints a text string to barcode on picBarcode picturebox
   Dim sChar As String
   Dim sText As String
   Dim lLen As Long
   Dim l As Long
   
   sText = txtTextline.Text
   lLen = Len(sText)
   
   ' Print barcode if string has text
   If lLen > 0 Then
      
      ' Print leading asterisk as required by Code 39 barcode specs
      Call DispCode("*")
      
      ' Iterate through string and display each character in barcode
      For l = 1 To lLen
         sChar = Mid$(sText, l, 1)
         Call DispCode(sChar)
      Next
      
      ' Print trailing asterisk as required by Code 39 barcode specs
      Call DispCode("*")
   End If
   
   ' Move barcode picturebox to proper location on form
   picBarcode.Width = lXLoc1 + 400
   picBarcode.Height = lYStart + lHeight + 100
End Sub

Private Sub cmdCopy_Click()
   ' Copy barcode picturebox to system clipboard
   
   ' Clear any data currently in the clipboard
   Clipboard.Clear
   
   ' Copy the picturebox image to the clipboard
   Clipboard.SetData picBarcode.Image
   
   ' Provide feedback to user that barcode has been copied
   Beep
End Sub

Private Sub Form_Activate()
   ' Set focus on data input textbox
   txtTextline.SetFocus
End Sub

Private Sub Form_Load()
   l1Space = 38         ' Barcode single-width space
   l2Space = 65         ' Barcode double-width space
   l1Line = 14          ' Barcode single-width line
   l2Line = 42          ' Barcode double-width line
   lInterChar = 30      ' Inter-character space width
   
   lHeight = 400        ' Barcode Height in twips.
   lXStart = 100        ' Horizontal Form starting location in twips.
   lYStart = 0          ' Vertical Form starting location in twips.
   lXLoc1 = lXStart     ' Start right of form's left edge

   Call SetupCodes      ' Load character codes
End Sub

Private Sub ClearForm()
   ' Clear the barcode picturebox
   picBarcode.Cls
   lXLoc1 = lXStart
End Sub

Private Sub DL(LineWidth As Integer)
   ' Draw Line procedure. LineWidth = 1 or 2 for single or double-width lines
   Dim lLen As Long
   
   If LineWidth = 1 Then
      lLen = l1Line
   Else
      lLen = l2Line
   End If
   
   ' Move to next printing location
   lXLoc2 = lXLoc1 + lLen
   
   ' Print the line in the picturebox
   picBarcode.Line (lXLoc1, lYStart)-(lXLoc2, lYStart + lHeight), vbBlack, BF
   
   lXLoc1 = lXLoc2
End Sub

Private Sub SP(SpaceWidth As Integer)
   ' Create a space on the picturebox.
   ' SpaceWidth = 1 or 2 for single or double-width spaces.
   Dim lLen As Long
   
   If SpaceWidth = 1 Then
      lLen = l1Space
   Else
      lLen = l2Space
   End If
   
   lXLoc1 = lXLoc1 + lLen
End Sub

Private Sub DispCode(sChar As String)
   ' Display a character in barcode
   
   Dim iVal As Integer
   Dim sFormat As String
   Dim i As Integer
   Dim sVal As String
   
   ' Make sure that it's a printable character.
   iVal = Asc(sChar)
   If iVal >= LBound(Code) And iVal <= UBound(Code) Then
   
      ' Get the barcode format for character
      sFormat = Code(iVal)
      
      ' See if sFormat is Blank
      If StrComp(sFormat, vbNullString) <> 0 Then
         ' Iterate through each code in the format
         For i = 1 To Len(sFormat)
            sVal = Mid$(sFormat, i, 1)
            If i Mod 2 = 0 Then        'Even characters are spaces
               Call SP(CInt(sVal))
            Else                       'Odd characters are lines
               Call DL(CInt(sVal))
            End If
         Next
         
         ' Put space between characters
         Call NewChar
      End If
   End If
End Sub

Private Sub NewChar()
   ' Place space between characters
   lXLoc1 = lXLoc1 + lInterChar
End Sub

Private Sub SetupCodes()
   ' Barcode formats for each printable character. 1 means single width line
   ' or space, 2 means double-width line or space.
   
   Code(32) = "122111211"
   Code(36) = "121212111"
   Code(37) = "111212121"
   Code(42) = "121121211"
   Code(43) = "121112121"
   Code(45) = "121111212"
   Code(46) = "221111211"
   Code(47) = "121211121"
   Code(48) = "111221211"
   Code(49) = "211211112"
   Code(50) = "112211112"
   Code(51) = "212211111"
   Code(52) = "111221112"
   Code(53) = "211221111"
   Code(54) = "112221111"
   Code(55) = "111211212"
   Code(56) = "211211211"
   Code(57) = "112211211"
   Code(65) = "211112112"
   Code(66) = "112112112"
   Code(67) = "212112111"
   Code(68) = "111122112"
   Code(69) = "211122111"
   Code(70) = "112122111"
   Code(71) = "111112212"
   Code(72) = "211112211"
   Code(73) = "112112211"
   Code(74) = "111122211"
   Code(75) = "211111122"
   Code(76) = "112111122"
   Code(77) = "212111121"
   Code(78) = "111121122"
   Code(79) = "211121121"
   Code(80) = "112121121"
   Code(81) = "111111222"
   Code(82) = "211111221"
   Code(83) = "112111221"
   Code(84) = "111121221"
   Code(85) = "221111112"
   Code(86) = "122111112"
   Code(87) = "222111111"
   Code(88) = "121121112"
   Code(89) = "221121111"
   Code(90) = "122121111"
End Sub

Private Sub txtTextline_Change()
   ' Update picturebox display when textbox changes
   Call ClearForm
   Call PrintString(txtTextline.Text)
End Sub

Private Sub txtTextline_KeyPress(KeyAscii As Integer)
   ' Convert character to Upper Case
   KeyAscii = Asc(UCase(Chr$(KeyAscii)))
   
   ' Allow for backspace for corrections.
   ' Copy barcode to clipboard if user presses return key.
   If KeyAscii < LBound(Code) Or KeyAscii > UBound(Code) Then
      If KeyAscii <> vbKeyBack Then
         If KeyAscii = vbKeyReturn Then
            cmdCopy.Value = True
         End If
         KeyAscii = 0
      End If
   End If
End Sub
