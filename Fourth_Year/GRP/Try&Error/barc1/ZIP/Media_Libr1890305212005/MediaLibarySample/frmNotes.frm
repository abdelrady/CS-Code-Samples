VERSION 5.00
Begin VB.Form frmNotes 
   Caption         =   "Media Sample Notes"
   ClientHeight    =   7635
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9735
   LinkTopic       =   "Form1"
   ScaleHeight     =   7635
   ScaleWidth      =   9735
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   8040
      TabIndex        =   1
      Top             =   7200
      Width           =   1215
   End
   Begin VB.TextBox txtNotes 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   6855
      Left            =   240
      MultiLine       =   -1  'True
      TabIndex        =   0
      Text            =   "frmNotes.frx":0000
      Top             =   120
      Width           =   9015
   End
   Begin VB.Label Label1 
      Caption         =   "Use scroll up and down and page up and down keys."
      Height          =   375
      Left            =   2280
      TabIndex        =   2
      Top             =   7200
      Width           =   4455
   End
End
Attribute VB_Name = "frmNotes"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------
' Module    : frmNotes
' DateTime  : 14/05/2005 09:26
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
Option Explicit

'---------------------------------------------------------------------------------------
' Procedure : cmdClose_Click
' DateTime  : 14/05/2005 09:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdClose_Click()
    Unload Me
End Sub

'---------------------------------------------------------------------------------------
' Procedure : Form_Load
' DateTime  : 14/05/2005 09:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub Form_Load()
 Dim iNotesChan As Integer
 Dim sNotes As String
 Dim sNoteLine As String
 
   On Error GoTo Form_Load_Error

    sNotes = ""
    iNotesChan = FreeFile()
    
    Open App.Path & "/" & "readme.txt" For Input As #iNotesChan
    While Not EOF(iNotesChan)
        Line Input #iNotesChan, sNoteLine
        sNotes = sNotes & sNoteLine & vbCrLf
    Wend
    Close #12
    txtNotes.Text = sNotes

   On Error GoTo 0
   Exit Sub

Form_Load_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure Form_Load of Form frmNotes"
    
End Sub

'#eof
