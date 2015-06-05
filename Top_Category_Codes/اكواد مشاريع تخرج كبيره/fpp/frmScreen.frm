VERSION 5.00
Begin VB.Form frmScreen 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00000000&
   Caption         =   "Screen"
   ClientHeight    =   3195
   ClientLeft      =   5700
   ClientTop       =   585
   ClientWidth     =   4680
   BeginProperty Font 
      Name            =   "Fixedsys"
      Size            =   9.75
      Charset         =   204
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00FFFFFF&
   LinkTopic       =   "Form1"
   ScaleHeight     =   213
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   312
   Begin VB.Timer timerInput 
      Enabled         =   0   'False
      Interval        =   220
      Left            =   270
      Top             =   1380
   End
   Begin VB.Menu mnuPopup 
      Caption         =   "mnuPopup"
      Visible         =   0   'False
      Begin VB.Menu mnuClearScreen 
         Caption         =   "Clear Screen"
      End
   End
End
Attribute VB_Name = "frmScreen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/




' info@emu8086.com
' =========================================================
' Our virtual screen
' =========================================================

Option Explicit

' ==== variables for receiving the input string:
' starting position (CurrentX/Y before input):
Dim nX As Single
Dim nY As Single
' the message that appears before input:
Dim sMessage As String
' the input string (user input):
Dim sInputBuffer As String
' a blinker (changes from " " to "_" all the time):
Dim sBlinker As String
' already printed on screen (both mesage and input), used
'  to remove it from screen on update:
Dim lastPrintedInp As String


' ++++++++++ vertual screen (to allow scrolling):
' maximum 37 lines:
Dim vScreen(0 To 36) As String
' current line (where next printing will be done):
Dim curLine As Integer

Private Sub Form_Activate()
    b_frmScreenVisible = True
End Sub

Private Sub Form_Load()
    Me.Icon = frmMain.Icon
    clearScreen
End Sub


' prints out a message, and waits for user to enter a string,
' returns the entered string.
' does not return (eternal loop) until enter is pressed!
Public Function inputLine(message As String) As String
    
    ' scroll if required before any printing:
    doScrollUp_if_Required
    
    ' keep starting position:
    nX = Me.CurrentX
    nY = Me.CurrentY
           
    sMessage = message
           
    sInputBuffer = ""
    sBlinker = "_"
    lastPrintedInp = ""
    
    timerInput.Enabled = True
     
    ' run until ENTER is pressed (end of input):
    Do While timerInput.Enabled
        DoEvents
    Loop
            
    ' print out everything again, to make sure the blinker
    '    won't stay on the screen:
    sBlinker = ""
    printOut
    
    ' store last printed data in virtual screen:
    vScreen(curLine) = lastPrintedInp
    ' go next line:
    curLine = curLine + 1
        
    inputLine = sInputBuffer
End Function

Public Sub processKey(KeyAscii As Integer)
    Form_KeyPress KeyAscii
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    'Debug.Print KeyAscii
    
    If KeyAscii = vbKeyReturn Then     ' enter pressed?
        timerInput.Enabled = False  ' make return from inputLine().
    ElseIf KeyAscii = vbKeyBack Then   ' backspace pressed?
        ' removing the last char:
        Dim l As Long
        l = Len(sInputBuffer)
        If l > 0 Then   ' is there something to remove?
            sInputBuffer = Mid(sInputBuffer, 1, l - 1)
        End If
    Else ' adding to buffer:
        If timerInput.Enabled Then  ' waiting for input?
            sInputBuffer = sInputBuffer & Chr(KeyAscii)
        End If
    End If
    
    If timerInput.Enabled Then  ' waiting for input?
        ' print the message again from the same point
        '   with what we already have in a buffer:
        printOut
    End If
End Sub

' timer, used to make a blinker:
Private Sub timerInput_Timer()
    ' print the message again from the same point
    '   with what we already have in a buffer:
    printOut
    
    ' make a blink effect:
    If sBlinker = "_" Then
        sBlinker = " "
    Else
        sBlinker = "_"
    End If
End Sub

' prints the message again from the same point
'   with what we already have in a buffer:
Private Sub printOut()
    Dim s As String
    Dim tOrigForeColor As Long  ' temporary var to store original color.
    
    ' delete old message by writing over it
    '   with back color:
    tOrigForeColor = Me.ForeColor   ' store original fore color.
    Me.ForeColor = Me.BackColor
    Me.CurrentX = nX
    Me.CurrentY = nY
    Me.Print lastPrintedInp         ' clear from previous message.
    
    ' print new message:
    Me.ForeColor = tOrigForeColor
    s = sMessage & " >" & sInputBuffer & sBlinker
    Me.CurrentX = nX
    Me.CurrentY = nY
    Me.Print s
    
    ' store for removing it on update (when
    '    something added to buffer):
    lastPrintedInp = s
End Sub

Public Sub clearScreen()
    Me.Cls
    
    Dim i As Integer
    
    ' clear vertual screen:
    For i = 0 To UBound(vScreen)
        vScreen(i) = ""
    Next i
    
    ' set current line to most upper line:
    curLine = 0
End Sub

Private Sub doScrollUp_if_Required()

    If Not ((curLine > UBound(vScreen)) Or (Me.CurrentY + Me.TextHeight("A") > Me.ScaleHeight)) Then
        Exit Sub ' scroll not required.
    End If

    Dim i As Integer
        
    ' move everything up (removing the first line):
    For i = 0 To UBound(vScreen) - 1
        vScreen(i) = vScreen(i + 1)
    Next i
    
    ' clear last line:
    i = UBound(vScreen)
    vScreen(i) = ""
    
    ' clear actual screen:
    Me.Cls
    
    ' get to previous line (if there is one):
    If curLine > 0 Then
        curLine = curLine - 1
    Else    ' just in case (to prevent any possible errors):
        curLine = 0
    End If
    
    ' print out the vertual screen,
    '    currentX/Y will be set on the last line:
    For i = 0 To curLine - 1
        Me.Print vScreen(i)
    Next i
    
End Sub

' prints a message on the screen,
' cares about scrolling:
Public Sub printLine(s As String, Optional b_NOT_TerminateWithNewLine As Boolean)
   
    doScrollUp_if_Required  ' scroll if required.
    
    ' keep printed on vertual screen also,
    '   previous printing may not be terminated by "\n",
    '   so concat:
    vScreen(curLine) = vScreen(curLine) & s
    
    If b_NOT_TerminateWithNewLine Then
        Me.Print s; ' doesn't go to the next line.
    Else
        Me.Print s
        curLine = curLine + 1
    End If

End Sub


Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    
 b_frmScreenVisible = False

 If UnloadMode = vbFormControlMenu Then ' user closes frmScreen.
 
    If CLOSE_APP_ON_END Then
        If Not bWINDOW_LOADED Then
            ' if running from prompt and user closes this
            '   window, and frmWindow isn't visible, then
            '   exit from application:
            Terminate_APPLICATION
        End If
    Else
    
        If bTERMINATE_ON_CLOSE And (b_frm_mBoxVisible = False) Then
             Terminate_APPLICATION
        Else
            ' hide instead of close (to avoid losing data):
            Cancel = 1
            Me.Hide
        End If

    End If
    
 End If
 
End Sub



Private Sub mnuClearScreen_Click()
    clearScreen
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = vbRightButton Then
        PopupMenu mnuPopup
    End If
End Sub
