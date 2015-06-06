VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Begin VB.Form frmBarCode
   Caption         =   "BarCode 39 (3 of 9) Generator 1.0"
   ClientHeight    =   2625
   ClientLeft      =   165
   ClientTop       =   240
   ClientWidth     =   9840
   Icon            =   "frmBarCode.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   2625
   ScaleWidth      =   9840
   StartUpPosition =   2 
   Begin MSComDlg.CommonDialog cd1
      Left            =   9360
      Top             =   2160
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.PictureBox Picture1
      Appearance      =   0 
      AutoRedraw      =   -1 
      BackColor       =   &H80000005&
      BorderStyle     =   0 
      ForeColor       =   &H80000008&
      Height          =   1455
      Left            =   120
      ScaleHeight     =   1455
      ScaleWidth      =   9855
      TabIndex        =   2
      Top             =   720
      Width           =   9855
   End
   Begin VB.TextBox Text1
      Alignment       =   2 
      Appearance      =   0 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0  
         Italic          =   0  
         Strikethrough   =   0  
      EndProperty
      Height          =   420
      Left            =   1800
      MaxLength       =   23
      TabIndex        =   0
      Text            =   "T9132146579874654675412"
      Top             =   120
      Width           =   3735
   End
   Begin VB.Label Label4
      AutoSize        =   -1 
      BorderStyle     =   1 
      Caption         =   "About"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0  
         Italic          =   0  
         Strikethrough   =   0  
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   495
      Left            =   8760
      MousePointer    =   10 
      TabIndex        =   5
      Top             =   120
      Width           =   960
   End
   Begin VB.Label Label3
      AutoSize        =   -1 
      Caption         =   "Copyright (C) 2003 Lam Ri Hui"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0  
         Italic          =   0  
         Strikethrough   =   0  
      EndProperty
      Height          =   270
      Left            =   3840
      TabIndex        =   4
      Top             =   2280
      Width           =   2760
   End
   Begin VB.Label Label2
      AutoSize        =   -1 
      BorderStyle     =   1 
      Caption         =   "User Manual"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0  
         Italic          =   0  
         Strikethrough   =   0  
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   495
      Left            =   6720
      MousePointer    =   10 
      TabIndex        =   3
      Top             =   120
      Width           =   1875
   End
   Begin VB.Label Label1
      AutoSize        =   -1 
      Caption         =   "BarCode Text :"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0  
         Italic          =   0  
         Strikethrough   =   0  
      EndProperty
      Height          =   300
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   1560
   End
   Begin VB.Menu mnuMenu
      Caption         =   "Menu"
      Visible         =   0  
      Begin VB.Menu mnuCopy
         Caption         =   "Copy to Clipboard"
      End
      Begin VB.Menu mnuSaveAs
         Caption         =   "Save As"
      End
      Begin VB.Menu mnuPrint
         Caption         =   "Print"
      End
   End
End
Attribute VB_Name = "frmBarCode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()


End Sub
Private Sub Form_Load()

    Call DrawBarcode(Text1, Picture1)

End Sub
Private Sub Label2_Click()

    MsgBox "BarCode 39 (3 of 9) Generator 1.0 by Lam Ri Hui" & vbNewLine & "(lamrihui@yahoo.com)" & vbNewLine & vbNewLine & "User Manual :" & vbNewLine & "1. Type in the barcode number you want to generate." & vbNewLine & "2. Right click the barcode." & vbNewLine & "3. A pop up menu appeared." & vbNewLine & "4. There are 3 options you can select :" & vbNewLine & vbTab & "(a)Copy to clipboard - Copy the barcode to clipboard " & vbNewLine & vbTab & vbTab & vbTab & "  and paste to graphic programs" & vbNewLine & vbTab & vbTab & vbTab & "  such as Adobe Photoshop, Corel" & vbNewLine & vbTab & vbTab & vbTab & "  Draw etc." & vbNewLine & vbTab & "(b)Save As - Save the barcode as a picture file." & vbNewLine & vbTab & "(c)Print - Print the barcode out." & vbNewLine & "5. Select one of the options and you completed a barcode!" & vbNewLine & vbNewLine & "Copyright(C)2003 Lam Ri Hui", , "BarCode 39 (3 of 9) Generator"

End Sub
Private Sub Label4_Click()

    MsgBox "BarCode 39 (3 of 9) Generator 1.0" & vbNewLine & "by Lam Ri Hui" & vbNewLine & vbNewLine & "This code is to generate barcode and save or print it." & vbNewLine & vbNewLine & "Credits :" & vbNewLine & "Someone on PSC had help me a lot but I can't remember his name. Please help me to find the person so that I can credit him properly. Anyway, I thank him a lot." & vbNewLine & vbNewLine & "Copyright (C) 2003 Lam Ri Hui"

End Sub
Private Sub mnuCopy_Click()

    Clipboard.Clear
    Clipboard.SetData Picture1.Image, 2

End Sub
Private Sub mnuPrint_Click()

    frmPrint.Picture1.Picture = Me.Picture1.Image
    frmPrint.PrintForm
    Printer.EndDoc
    Unload frmPrint

End Sub
Private Sub mnuSaveAs_Click()

Dim ObjGifImg As GIF
    cd1.FilterIndex = 1

    On Error GoTo ErrHandler
    cd1.FileName = Picture1.Name
    cd1.CancelError = True
    cd1.Flags = cdlOFNOverwritePrompt + cdlOFNNoReadOnlyReturn
    cd1.Filter = "Bitmaps (*.bmp)|*.bmp"
    cd1.ShowSave
    DoEvents
    Picture1.Picture = Picture1.Image
    Select Case cd1.FilterIndex
        Case 1:
        SavePicture Picture1.Picture, cd1.FileName
    End Select
    Exit Sub
    ErrHandler:
    If Err.Number = 32755 Then
        Exit Sub
    End If

End Sub
Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

    If Button = 2 And Text1 <> "" Then
        PopupMenu mnuMenu
    End If

End Sub
Private Sub Text1_Change()

    Call DrawBarcode(Text1, Picture1)

End Sub
