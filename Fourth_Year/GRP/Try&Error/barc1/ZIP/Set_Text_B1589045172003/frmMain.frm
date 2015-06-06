VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "RTF TextBackColor Demo"
   ClientHeight    =   2655
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5415
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2655
   ScaleWidth      =   5415
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame fraTextBackColor 
      Caption         =   "Text Back Color"
      Height          =   735
      Left            =   120
      TabIndex        =   8
      Top             =   960
      Width           =   5175
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "Red"
         Height          =   345
         Index           =   0
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "Green"
         Height          =   345
         Index           =   1
         Left            =   960
         TabIndex        =   13
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "Blue"
         Height          =   345
         Index           =   2
         Left            =   1800
         TabIndex        =   12
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "Black"
         Height          =   345
         Index           =   3
         Left            =   2640
         TabIndex        =   11
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "White"
         Height          =   345
         Index           =   4
         Left            =   3480
         TabIndex        =   10
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextBackColor 
         Caption         =   "Cyan"
         Height          =   345
         Index           =   5
         Left            =   4320
         TabIndex        =   9
         Top             =   240
         Width           =   735
      End
   End
   Begin VB.Frame fraTextColor 
      Caption         =   "Text Color"
      Height          =   735
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   5175
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "Cyan"
         Height          =   345
         Index           =   5
         Left            =   4320
         TabIndex        =   7
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "White"
         Height          =   345
         Index           =   4
         Left            =   3480
         TabIndex        =   6
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "Black"
         Height          =   345
         Index           =   3
         Left            =   2640
         TabIndex        =   5
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "Blue"
         Height          =   345
         Index           =   2
         Left            =   1800
         TabIndex        =   4
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "Green"
         Height          =   345
         Index           =   1
         Left            =   960
         TabIndex        =   3
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdTextColor 
         Caption         =   "Red"
         Height          =   345
         Index           =   0
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   735
      End
   End
   Begin RichTextLib.RichTextBox rtfMain 
      Height          =   735
      Left            =   120
      TabIndex        =   0
      Top             =   1800
      Width           =   5175
      _ExtentX        =   9128
      _ExtentY        =   1296
      _Version        =   393217
      TextRTF         =   $"frmMain.frx":0000
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'A BIG thanks to vbAccelerator and their RichEdit control available at:
'  http://www.vbaccelerator.com/codelib/richedit/richedit.htm

Option Explicit

Const LF_FACESIZE = 32
Const CFM_BACKCOLOR = &H4000000

Const WM_USER = &H400
Const EM_SETCHARFORMAT = (WM_USER + 68)

Private Type CHARFORMAT2
    cbSize As Integer '2
    wPad1 As Integer  '4
    dwMask As Long    '8
    dwEffects As Long '12
    yHeight As Long   '16
    yOffset As Long   '20
    crTextColor As Long '24
    bCharSet As Byte    '25
    bPitchAndFamily As Byte '26
    szFaceName(0 To LF_FACESIZE - 1) As Byte ' 58
    wPad2 As Integer ' 60
    
    ' Additional stuff supported by RICHEDIT20
    wWeight As Integer            ' /* Font weight (LOGFONT value)      */
    sSpacing As Integer           ' /* Amount to space between letters  */
    crBackColor As Long        ' /* Background color                 */
    lLCID As Long               ' /* Locale ID                        */
    dwReserved As Long         ' /* Reserved. Must be 0              */
    sStyle As Integer            ' /* Style handle                     */
    wKerning As Integer            ' /* Twip size above which to kern char pair*/
    bUnderlineType As Byte     ' /* Underline type                   */
    bAnimation As Byte         ' /* Animated text like marching ants */
    bRevAuthor As Byte         ' /* Revision author index            */
    bReserved1 As Byte
End Type

'Const SCF_DEFAULT = &H0&
Const SCF_SELECTION As Long = &H1&
Const SCF_WORD As Long = &H2&
Const SCF_ALL As Long = &H4&
'Const SCF_USEUIRULES = &H8&

Public Enum ERECSetFormatRange
   ercSetFormatAll = SCF_ALL
   ercSetFormatSelection = SCF_SELECTION
   ercSetFormatWord = SCF_WORD Or SCF_SELECTION
End Enum

Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long

Private Sub cmdTextBackColor_Click(Index As Integer)
    Select Case Index
        Case 0: Call SetTextBackColor(RGB(255, 0, 0))
        Case 1: Call SetTextBackColor(RGB(0, 255, 0))
        Case 2: Call SetTextBackColor(RGB(0, 0, 255))
        Case 3: Call SetTextBackColor(RGB(0, 0, 0))
        Case 4: Call SetTextBackColor(RGB(255, 255, 255))
        Case 5: Call SetTextBackColor(RGB(0, 255, 255))
    End Select
End Sub

Private Sub cmdTextColor_Click(Index As Integer)
    Select Case Index
        Case 0: rtfMain.SelColor = RGB(255, 0, 0)
        Case 1: rtfMain.SelColor = RGB(0, 255, 0)
        Case 2: rtfMain.SelColor = RGB(0, 0, 255)
        Case 3: rtfMain.SelColor = RGB(0, 0, 0)
        Case 4: rtfMain.SelColor = RGB(255, 255, 255)
        Case 5: rtfMain.SelColor = RGB(0, 255, 255)
    End Select
End Sub

Private Sub SetTextBackColor(ByVal lColor As Long)
    Dim tCF2 As CHARFORMAT2
    tCF2.dwMask = CFM_BACKCOLOR
    tCF2.crBackColor = lColor
    tCF2.cbSize = Len(tCF2)
    Call SendMessage(rtfMain.hwnd, EM_SETCHARFORMAT, ercSetFormatSelection, tCF2)
End Sub
