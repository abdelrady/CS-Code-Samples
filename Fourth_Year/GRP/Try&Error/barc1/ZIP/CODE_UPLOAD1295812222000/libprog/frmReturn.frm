VERSION 5.00
Begin VB.Form frmReturn 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   7200
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   9600
   ControlBox      =   0   'False
   LinkTopic       =   "BLAH"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   480
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   640
   StartUpPosition =   1  'CenterOwner
   Begin VB.ListBox lstReturned 
      Height          =   4545
      Left            =   360
      TabIndex        =   8
      Top             =   2160
      Width           =   8895
   End
   Begin VB.Frame famSignOut 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Return"
      Height          =   7095
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   9375
      Begin VB.CommandButton Command1 
         Caption         =   "Main Menu"
         Height          =   255
         Left            =   8280
         TabIndex        =   5
         Top             =   1080
         Width           =   975
      End
      Begin VB.TextBox txtInput 
         Height          =   285
         Left            =   3000
         TabIndex        =   1
         Top             =   1080
         Width           =   5295
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Returned Items"
         Height          =   5055
         Left            =   120
         TabIndex        =   2
         Top             =   1920
         Width           =   9135
      End
      Begin VB.Label Label22 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "Book Barcode To Return:"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   1080
         Width           =   2775
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Book Keeper 101"
         BeginProperty Font 
            Name            =   "Coronet"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   480
         TabIndex        =   4
         Top             =   360
         Width           =   2895
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Beta 1.0"
         Height          =   255
         Left            =   960
         TabIndex        =   3
         Top             =   840
         Width           =   1695
      End
      Begin VB.Image imgLogo 
         Height          =   1635
         Left            =   120
         Picture         =   "frmReturn.frx":0000
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1620
      End
   End
   Begin VB.Label lblRed 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "RED"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   2175
   End
End
Attribute VB_Name = "frmReturn"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub Command1_Click()
Me.Hide
End Sub

Private Sub txtInput_Click()
  If Len(txtInput.Text) > 0 Then
    A = 0
    StrSQL = "SELECT * FROM [Signout]"
    StrSQL = StrSQL & " WHERE [Barcode] LIKE '" & txtInput.Text & "'"
    Set RstQuery = Db.OpenRecordset(StrSQL)
    StrSQL = "SELECT * FROM [Books]"
    StrSQL = StrSQL & " WHERE [Barcode] LIKE '" & txtInput.Text & "'"
    Set Books = Db.OpenRecordset(StrSQL)
    'If Not RstQuery.BOF And RstQuery.EOF Then
    If RstQuery.Fields("Available") = True Then
    Else
    RstQuery.Edit
    RstQuery.Fields("Available") = True
    RstQuery.Update
    If DateDiff("d", Now, RstQuery.Fields("DateDue")) >= 0 Then
    lstReturned.AddItem (RstQuery.Fields("Barcode") & " - " & Books.Fields("Title") & " - " & RstQuery.Fields("DateDue"))
    RstQuery.Delete
    Else
    Beep
    lstReturned.AddItem (RstQuery.Fields("Barcode") & " - " & Books.Fields("Title") & " - " & RstQuery.Fields("DateDue") & " - FINE:" & Format(RstQuery.Fields("FINE"), "Currency"))
    End If
        End If
        'Else
        'End If
    txtInput.Text = ""
    Else
    End If
End Sub

Private Sub txtInput_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Call txtInput_Click
End Sub

