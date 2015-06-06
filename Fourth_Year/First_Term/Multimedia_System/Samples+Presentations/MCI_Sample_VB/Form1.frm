VERSION 5.00
Begin VB.Form FForm1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5790
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   5790
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdStop 
      Caption         =   "Command2"
      Height          =   495
      Left            =   2760
      TabIndex        =   1
      Top             =   360
      Width           =   2055
   End
   Begin VB.CommandButton cmdPlay 
      Caption         =   "Command1"
      Height          =   615
      Left            =   600
      TabIndex        =   0
      Top             =   360
      Width           =   1455
   End
End
Attribute VB_Name = "FForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' This code is licensed according to the terms and conditions listed here.

' Declarations and such needed for the example:
' (Copy them to the (declarations) section of a module.)
Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal _
    lpszCommand As String, ByVal lpszReturnString As String, ByVal cchReturnLength _
    As Long, ByVal hwndCallback As Long) As Long
Private Declare Function mciGetErrorString Lib "winmm.dll" Alias "mciGetErrorStringA" (ByVal _
    fdwError As Long, ByVal lpszErrorText As String, ByVal cchErrorText As Long) As Long

' Use the MCI to play or stop playback of a MIDI file.  The file C:\Music\canyon.mid
' is opened when the form opens.  The Play and Stop buttons behave as you'd expect.  The
' only potential surprise is that the current position is not reset when playback stops; it
' behaves just as pausing playback would.  The file closes when the form unloads.

' If anything goes wrong in the example, display a message box with
' the MCI error message text.

Private Sub Form_Load()
    ' Open the file "C:\Music\canyon.mid" for later use in the example.
    ' Give it an alias of "canyon" so we don't need to refer to the filename again.
    Dim errcode As Long  ' MCI error code
    
    errcode = mciSendString("open onestop.mid alias canyon", "", 0, 0)
    If errcode <> 0 Then DisplayError errcode
End Sub

Private Sub cmdPlay_Click()
    ' Begin playback of the MIDI file when this button is pressed.
    Dim errcode As Long  ' MCI error code
    
    errcode = mciSendString("play canyon", "", 0, 0)
    If errcode <> 0 Then DisplayError errcode
End Sub

Private Sub cmdStop_Click()
    ' Stop playback of the MIDI file when this button is pressed.
    ' The position within the file does not move back to the beginning.
    Dim errcode As Long  ' MCI error code
    
    errcode = mciSendString("stop canyon", "", 0, 0)
    If errcode <> 0 Then DisplayError errcode
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' Close the MIDI file when the form unloads.  This is important, because the
    ' MIDI driver can only work with one file at a time.  There's no need to check
    ' for an error here, since we're just closing the file.
    Dim errcode As Long  ' MCI error code
    
    errcode = mciSendString("close canyon", "", 0, 0)
End Sub

Private Sub DisplayError(ByVal errcode As Long)
    ' This subroutine displays a dialog box with the text of the MCI error.  There's
    ' no reason to use the MessageBox API function; VB's MsgBox function will suffice.
    Dim errstr As String  ' MCI error message text
    Dim retval As Long    ' return value
    
    ' Get a string explaining the MCI error.
    errstr = Space(128)
    retval = mciGetErrorString(errcode, errstr, Len(errstr))
    ' Remove the terminating null and empty space at the end.
    errstr = Left(errstr, InStr(errstr, vbNullChar) - 1)
    
    ' Display a simple error message box.
    retval = MsgBox(errstr, vbOKOnly Or vbCritical)
End Sub

