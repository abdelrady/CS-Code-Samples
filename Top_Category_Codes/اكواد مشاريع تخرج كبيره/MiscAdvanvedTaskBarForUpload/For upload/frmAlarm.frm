VERSION 5.00
Begin VB.Form frmAlarm 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'None
   ClientHeight    =   2805
   ClientLeft      =   495
   ClientTop       =   495
   ClientWidth     =   3555
   LinkTopic       =   "Form1"
   ScaleHeight     =   2805
   ScaleWidth      =   3555
   ShowInTaskbar   =   0   'False
   Begin VB.Timer timAlarm2 
      Enabled         =   0   'False
      Interval        =   10000
      Left            =   1440
      Top             =   0
   End
   Begin VB.Frame Frame2 
      BorderStyle     =   0  'None
      ClipControls    =   0   'False
      Height          =   2775
      Left            =   0
      TabIndex        =   6
      Top             =   0
      Width           =   1815
      Begin VB.ListBox lstEnum 
         Height          =   255
         Left            =   1560
         TabIndex        =   8
         Top             =   1320
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Timer timAlarm 
         Enabled         =   0   'False
         Interval        =   1000
         Left            =   1440
         Top             =   0
      End
      Begin VB.TextBox txtH 
         Height          =   285
         Left            =   240
         MaxLength       =   2
         TabIndex        =   0
         ToolTipText     =   "Hours"
         Top             =   960
         Width           =   375
      End
      Begin VB.TextBox txtM 
         Height          =   285
         Left            =   720
         MaxLength       =   2
         TabIndex        =   1
         ToolTipText     =   "Minute"
         Top             =   960
         Width           =   375
      End
      Begin VB.TextBox txtS 
         Height          =   285
         Left            =   1200
         MaxLength       =   2
         TabIndex        =   2
         ToolTipText     =   "Second"
         Top             =   960
         Width           =   375
      End
      Begin VB.OptionButton optOff 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Off"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   1440
         Value           =   -1  'True
         Width           =   615
      End
      Begin VB.OptionButton optOn 
         BackColor       =   &H00FFFFFF&
         Caption         =   "On"
         Height          =   255
         Left            =   840
         TabIndex        =   5
         Top             =   1440
         Width           =   615
      End
      Begin VB.TextBox txtDisp 
         Height          =   855
         Left            =   120
         MultiLine       =   -1  'True
         TabIndex        =   3
         Text            =   "frmAlarm.frx":0000
         ToolTipText     =   "Text to Display"
         Top             =   1800
         Width           =   1455
      End
      Begin VB.Image cmdDown 
         Height          =   255
         Left            =   110
         Top             =   295
         Width           =   255
      End
      Begin VB.Image Image1 
         Height          =   3465
         Left            =   0
         Picture         =   "frmAlarm.frx":0010
         Top             =   0
         Width           =   3000
      End
      Begin VB.Label lblTime 
         Height          =   255
         Left            =   600
         TabIndex        =   7
         Top             =   360
         Width           =   975
      End
      Begin VB.Image Image2 
         Height          =   3465
         Left            =   360
         Picture         =   "frmAlarm.frx":9DA6
         Stretch         =   -1  'True
         Top             =   720
         Width           =   3000
      End
   End
End
Attribute VB_Name = "frmAlarm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Mins As Integer
Dim Alarm As Boolean


Private Sub cmdDown_Click()
    Do Until frmAlarm.Top = Screen.Height + (frmAlarm.Height)
        frmAlarm.Top = frmAlarm.Top + 1
        DoEvents
    Loop
End Sub

Private Sub Form_Load()
    optOn.BackColor = RGB(240, 240, 250)
    optOff.BackColor = RGB(240, 240, 250)
    Me.Width = frmMain.Width
    Frame2.Width = Me.Width
    Image1.Width = Me.Width
End Sub

Private Sub optOff_Click()
    timAlarm.Enabled = False
    Alarm = False
End Sub

Private Sub optOn_Click()
    If txtH <> "" And txtM <> "" And txtS <> "" Then
        Alarm = True
        timAlarm.Enabled = True
    Else
        optOff_Click
        optOff = True
        Alarm = False
    End If
End Sub

Private Sub timAlarm_Timer()
    Dim i As Integer
    Dim intMsg As Integer
    If Alarm = True Then
        If Int(Hour(Time$)) >= Int(txtH) Then
                    If Int(Minute(Time$)) >= Int(txtM) Then
                                If Int(Second(Time$)) >= Int(txtS) Then
                                            Beep
                                            Call fEnumWindows(lstEnum)
                                            For i = 0 To lstEnum.ListCount - 1
                                            CloseWindow lstEnum.ItemData(i)
                                            Next i
                                            intMsg = MsgBox(txtDisp.Text & vbLf & "Do you want alarm to be on ?", vbYesNo + vbInformation)
                                            If intMsg = vbYes Then
                                                    Mins = 0
                                                    timAlarm2.Enabled = True
                                                    Alarm = False
                                            Else
                                                    optOff = True
                                                    Alarm = False
                                            End If
                                        End If
                                End If
                            End If
                    End If
            
            
        
    
End Sub

Private Sub timAlarm2_Timer()
    Mins = Mins + 1
    Dim intMsg As Integer
    If Mins = 5 Then
        Beep
        intMsg = MsgBox(txtDisp.Text & vbLf & "Do you want alarm to be on ?", vbYesNo + vbInformation)
        If intMsg = vbYes Then
            Mins = 0
            timAlarm2.Enabled = True
        Else
            optOff = True
        End If
        
    End If
End Sub
