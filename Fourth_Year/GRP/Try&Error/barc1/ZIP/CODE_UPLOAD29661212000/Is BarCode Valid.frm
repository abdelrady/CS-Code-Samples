VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Is Valid BarCode?"
   ClientHeight    =   2505
   ClientLeft      =   4200
   ClientTop       =   2460
   ClientWidth     =   5175
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   ScaleHeight     =   2505
   ScaleWidth      =   5175
   Begin VB.OptionButton Option2 
      Caption         =   "Right Check Digit"
      Height          =   255
      Left            =   2670
      TabIndex        =   7
      Top             =   570
      Width           =   1605
   End
   Begin VB.OptionButton Option1 
      Caption         =   "Left Check Digit"
      Height          =   255
      Left            =   1020
      TabIndex        =   6
      Top             =   570
      Width           =   1485
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Quit"
      Height          =   405
      Left            =   2760
      TabIndex        =   4
      Top             =   1290
      Width           =   1365
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Validate"
      Height          =   405
      Left            =   1140
      TabIndex        =   3
      Top             =   1290
      Width           =   1365
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   2100
      MaxLength       =   13
      TabIndex        =   0
      Top             =   180
      Width           =   2625
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   345
      Left            =   1140
      TabIndex        =   5
      Top             =   870
      Width           =   2985
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Note:  READ THE ATTACHED README TEXT FILE."
      Height          =   195
      Left            =   690
      TabIndex        =   2
      Top             =   1950
      Width           =   3840
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Enter 13-digit barcode:"
      Height          =   195
      Left            =   390
      TabIndex        =   1
      Top             =   210
      Width           =   1605
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'
' linda.69@mailcity.com
' not to be used illegally.
' author expresses no liabilities whatsoever.
' code is for educational purposes only.
'
' with  4  808680  200903     (808 = FOOD)
' enter as 8086802009034 / left checkdigit
'
' with  978971  863630  5     (978 = BOOK)
' enter as is 9789718636305 / right checkdigit
'
' i did not include the meaning of the first 3 digits,
' coz it is not the same in each country...
'
' please read the readme text.

Option Explicit

Function IsBARCODEValid(ByVal BARCODE As String) As Boolean
Dim OddSum, EvenSum, TotalSum As Integer
Dim ctr As Integer
    
  OddSum = 0
  
  'get OddSum = (1)+(3)+(5)+ ... + (11)
  For ctr = 1 To 11 Step 2
    OddSum = OddSum + Val(Mid(BARCODE, ctr, 1))
  Next

  EvenSum = 0
  
  'get EvenSum = (2)+(4)+(6)+ ... + (12)
  For ctr = 2 To 12 Step 2
    EvenSum = EvenSum + Val(Mid(BARCODE, ctr, 1))
  Next

  'where is the check digit?
  If Option2.Value Then
    EvenSum = EvenSum * 3
  Else
    OddSum = OddSum * 3
  End If
  
  TotalSum = EvenSum + OddSum
  
  TotalSum = TotalSum Mod 10
  
  'Check if =0 then checkdigit = 0
  'else checkdigit = 10-totalsum
  If TotalSum = 0 Then
    IsBARCODEValid = _
      Val(Mid(BARCODE, 13, 1)) = 0
  Else
    IsBARCODEValid = _
      Val(Mid(BARCODE, 13, 1)) = (10 - TotalSum)
  End If
End Function

Private Sub Command1_Click()
On Error Resume Next
Dim BARCODE As String

  Label3.Caption = ""
  
  If Len(Text1.Text) <> 13 Then Exit Sub
    
  BARCODE = Text1.Text
  
  If IsBARCODEValid(BARCODE) Then
    Label3.Caption = "VALID"
  Else
    Label3.Caption = "INVALID"
  End If
End Sub

Private Sub Command2_Click()
  Unload Me
End Sub

Private Sub Form_Load()
  Option2.Value = True
End Sub

