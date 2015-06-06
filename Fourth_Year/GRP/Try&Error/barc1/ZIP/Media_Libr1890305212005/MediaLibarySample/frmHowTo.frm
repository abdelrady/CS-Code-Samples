VERSION 5.00
Begin VB.Form frmHowTo 
   Caption         =   "Media Sample How-To"
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
      Text            =   "frmHowTo.frx":0000
      Top             =   120
      Width           =   9015
   End
   Begin VB.Label Label1 
      Caption         =   "Use scroll up and down and page up and down keys."
      Height          =   375
      Left            =   2520
      TabIndex        =   2
      Top             =   7200
      Width           =   3855
   End
End
Attribute VB_Name = "frmHowTo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------
' Module    : frmHowTo
' DateTime  : 14/05/2005 09:26
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

' ----------------------------------------
'   How-To
' ----------------------------------------
'
' Using Media Libray in Memory Mode Only:
'
' Make sure you are in memory mode, that's the book with the hand icon, not the book with the disc icon.
' (top left corner of main screen)
'
'    Select 'Main' from the menu bar, and then click on 'Load Library'
' wait for the status line at the bottom to finishing loading the library and
' ends with Loaded (n) Records : date time.
'
' Now click on button [ Show All Media ].
'
' wait for the status line at the bottom to finishing loading the view and
' ends with Loaded (n) Records : date time.
'
' now click on any item in the listview and it will automatically appear with all the details
' in the main form.
'
' To make changes to the details, you need to click the [ Edit Media ] button.
' Make changes to the details, but don't change the barcode).
' When all changes entered, click the [ Update Media ] button.
' Now to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the store and re-loads them into the main form.
'
' Note : buttons are enabled and disabled where appropriate.  This is a beta test version,
'        to demonstrate the use of the BSTN class.  Sometimes the buttons may not be as
'        expected, but clicking [ Search Media ] button usually gets the buttons you need
'        enabled or try going to the 'Show All' screen and clicking on an item line.
'
' To add new media details, you need to click the [ Edit Media ] button.
' Make changes to the details, enter a new barcode that does not exist in the library already.
' When all changes entered, click the [ Add Media ] button.
' Now to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the memory store and re-loads them into the main form.
'
' To delete media details, you need to click the [ Delete Media ] button.
' Once the barcode and the details, are deleted,
' to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the store and will not re-load them into the main form as they don't exist, so
' the previous information will stay in the details, until you load another media item.
'
'
' Using Media Libray in Disk Mode Only:
' -------------------------------------
'
' Make sure you are in memory mode, that's the book with the hand icon, not the book with the disc icon.
' (top left corner of main screen)
'
'    Click on 'Use Disk Media'
'
' The book with the hand icon (top left corner of main screen), will change to the book with the disc.
'
' Now all the operations work directly on the disk file.
'
' Now click on button [ Show All Media ].
'
' wait for the status line at the bottom to finishing loading the view and
' ends with Loaded (n) Records : date time.
'
' now click on any item in the listview and it will automatically appear with all the details
' in the main form.
'
' To make changes to the details, you need to click the [ Edit Media ] button.
' Make changes to the details, but don't change the barcode).
' When all changes entered, click the [ Update Media ] button.
' Now to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the disk store and re-loads them into the main form.
'
' Note : buttons are enabled and disabled where appropriate.  This is a beta test version,
'        to demonstrate the use of the BSTN class.  Sometimes the buttons may not be as
'        expected, but clicking [ Search Media ] button usually gets the buttons you need
'        enabled or try going to the 'Show All' screen and clicking on an item line.
'
' To add new media details, you need to click the [ Edit Media ] button.
' Make changes to the details, enter a new barcode that does not exist in the library already.
' When all changes entered, click the [ Add Media ] button.
' Now to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the disk store and re-loads them into the main form.
'
' To delete media details, you need to click the [ Delete Media ] button.
' Once the barcode and the details, are deleted,
' to prove the changes are entered click the [ Search Media ] button.  This re-scans
' the details in the store and will not re-load them into the main form as they don't exist, so
' the previous information will stay in the details, until you load another media item.
'
''  Select 'Main' from the menu bar, and then click on 'Load Library'
' wait for the status line at the bottom to finishing loading the library and
' ends with Loaded (n) Records : date time.
'
'
' IMPORTANT the download includes a <ready-made> disk media file!
'           this is how to make one yourself once
'          you have trashed/amended the pre-made version
'
' Make sure you are in memory mode, that's the book with the hand, not the book with the disc.
' and the button's caption near the [ Close ] button says [ Use Disk Media ].
'
' Select 'Main' from the menu bar, and then click on 'Build Disk File From Library (memory) '
'
'    Click on 'Use Disk Media'   - you're now using the new disk file you just built from the
'     original .dat library.
'
' IMPORTANT POINT:  If you decide to switch from Disk mode back to Memory mode, the Load Library operation,
' is called automatically. This is because part of the memory store is used as a disk store cache,
' so the memory operations would be in a confused state otherwise.
'
' Have Fun!!!
'
Option Explicit

'---------------------------------------------------------------------------------------
' Procedure : cmdClose_Click
' DateTime  : 14/05/2005 09:26
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdClose_Click()
    Unload Me
End Sub

'---------------------------------------------------------------------------------------
' Procedure : Form_Load
' DateTime  : 14/05/2005 09:26
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
    
    Open App.Path & "/" & "how-to.txt" For Input As #iNotesChan
    While Not EOF(iNotesChan)
        Line Input #iNotesChan, sNoteLine
        sNotes = sNotes & sNoteLine & vbCrLf
    Wend
    Close #12
    txtNotes.Text = sNotes

   On Error GoTo 0
   Exit Sub

Form_Load_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure Form_Load of Form frmHowTo"
    
End Sub

'#eof
