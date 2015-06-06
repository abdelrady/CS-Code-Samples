VERSION 5.00
Begin VB.Form fPlayAvi 
   Caption         =   "PlayAVI"
   ClientHeight    =   3255
   ClientLeft      =   2160
   ClientTop       =   2745
   ClientWidth     =   2820
   LinkTopic       =   "Form1"
   ScaleHeight     =   3255
   ScaleWidth      =   2820
   Begin VB.CommandButton Command1 
      Caption         =   "CreateMCIWND"
      Height          =   510
      Left            =   495
      TabIndex        =   0
      Top             =   2385
      Width           =   1815
   End
End
Attribute VB_Name = "fPlayAvi"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'******************************************************
'PLAYAVI PROJECT
'by Ray Mercer <raymer@macnica.co.jp>
'7/23/98
'playavi.frm
'playavi.vbp
'mciWnd.bas
'SIMPLE DEMO OF USING Win32 MCIWnd directly functions from VB
'Copyright 1998, Ray Mercer, All Rights Reserved
'*******************************************************
Option Explicit

Dim hMCIWnd As Long
Private Sub Command1_Click()
    Dim flags As Long
    
    If hMCIWnd <> 0 Then 'destroy old instances before recreating
        Call MCIWndCleanup
    End If
    
    'create a Win32 MCIWND class
    Call MCIWndRegisterClass
    'flags = WS_CHILD Or WS_VISIBLE Or WS_BORDER Or MCIWNDF_SHOWALL Or MCIWNDF_NOOPEN Or MCIWNDF_NOMENU Or MCIWNDF_NOTIFYALL
    flags = WS_CHILD Or WS_VISIBLE Or WS_BORDER Or MCIWNDF_SHOWALL Or MCIWNDF_NOTIFYALL
    'create a new window based on this class
    hMCIWnd = CreateWindowExAsString(0&, "MCIWndClass", "TEST", flags, _
                            10&, 10&, 0&, 0&, _
                            Me.hwnd, _
                            0&, _
                            App.hInstance, _
                            App.Path & "\macnica.avi")
    'not necessary but could load a different AVI here
    'Call SendMessageAsString(hMCIWnd, MCIWNDM_OPEN, flags, App.Path & "\macnica.avi")
    Call SendMessageAsString(hMCIWnd, MCIWNDM_SENDSTRING, 0&, "play repeat")
End Sub

Private Sub MCIWndCleanup()
    'destroy old instances and zero hWnd
    If hMCIWnd <> 0 Then
        Call DestroyWindow(hMCIWnd)
        hMCIWnd = 0&
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Call MCIWndCleanup
End Sub
