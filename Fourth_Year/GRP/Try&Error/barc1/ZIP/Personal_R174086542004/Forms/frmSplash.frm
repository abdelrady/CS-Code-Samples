VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Begin VB.Form frmSplash 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4305
   ClientLeft      =   3810
   ClientTop       =   3345
   ClientWidth     =   4845
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4305
   ScaleWidth      =   4845
   ShowInTaskbar   =   0   'False
   Begin VB.Frame fraAbout 
      BackColor       =   &H00DFB493&
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   4335
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   4935
      Begin VB.Frame fraDescription 
         BackColor       =   &H00DFB493&
         Height          =   1575
         Left            =   120
         TabIndex        =   4
         Top             =   1560
         Width           =   4575
         Begin VB.Label lblDescription 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BackStyle       =   0  'Transparent
            Caption         =   $"frmSplash.frx":08CA
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00800000&
            Height          =   1215
            Left            =   240
            TabIndex        =   5
            Top             =   240
            Width           =   4095
         End
      End
      Begin LVbuttons.LaVolpeButton cmdDeveloper 
         Height          =   615
         Left            =   1800
         TabIndex        =   3
         Top             =   840
         Width           =   2775
         _ExtentX        =   4895
         _ExtentY        =   1085
         BTYPE           =   7
         TX              =   "Developed By       Mamerto Fabian Jr."
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   2
         BCOL            =   14660755
         FCOL            =   8388608
         FCOLO           =   16711680
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmSplash.frx":0993
         ALIGN           =   1
         IMGLST          =   "(None)"
         IMGICON         =   "(None)"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   2
         SHOWF           =   0   'False
         BSTYLE          =   0
      End
      Begin VB.Label lblThanks 
         BackColor       =   &H00800000&
         BackStyle       =   0  'Transparent
         Caption         =   "Special thanks to: Jeff, TJ, Irvin, Bonbon, Ahbei, Maui, Joy, Cristine, LaVolpe, Hamed"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   495
         Left            =   120
         TabIndex        =   7
         Top             =   3600
         Width           =   4455
      End
      Begin VB.Label lblCopyright 
         BackColor       =   &H00800000&
         BackStyle       =   0  'Transparent
         Caption         =   "Copyright © 2004"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   3240
         Width           =   1815
      End
      Begin VB.Label lblVersion 
         Alignment       =   2  'Center
         BackColor       =   &H00800000&
         BackStyle       =   0  'Transparent
         Caption         =   "Version 1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   255
         Left            =   2520
         TabIndex        =   2
         Top             =   600
         Width           =   1335
      End
      Begin VB.Label lblTitle 
         Alignment       =   2  'Center
         BackColor       =   &H00800000&
         BackStyle       =   0  'Transparent
         Caption         =   "Personal Reloadable Card System"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   615
         Left            =   1680
         TabIndex        =   1
         Top             =   0
         Width           =   3015
      End
      Begin VB.Image imgPReC 
         Appearance      =   0  'Flat
         BorderStyle     =   1  'Fixed Single
         Height          =   1335
         Left            =   120
         Picture         =   "frmSplash.frx":09AF
         Stretch         =   -1  'True
         Top             =   120
         Width           =   1575
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   20
      Left            =   4440
      Top             =   0
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_lngTransparency As Long
Public p_blnSplash As Boolean

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Const SW_SHOWNORMAL = 1

Private Sub Form_Click()
    On Error GoTo hErr
    If Me.p_blnSplash = False Then
        Unload Me
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_Initialize()
    On Error GoTo hErr
    InitControlsXP
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If KeyAscii = 27 And Me.p_blnSplash = False Then
        Unload Me
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_Load()
    On Error GoTo hErr
    Call CenterForm(Me)
    
    If Me.p_blnSplash = True Then
        Set Me.Picture = imgPReC.Picture
        fraAbout.Visible = False
    End If
    
    m_lngTransparency = 0
    Call MakeTransparent(Me.hwnd, 0)
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdDeveloper_Click()
    ShellExecute hwnd, vbNullString, _
       "mailto:junwebhead@hotmail.com", vbNullString, _
       vbNullString, SW_SHOWNORMAL
End Sub

Private Sub fraAbout_Click()
    If Me.p_blnSplash = False Then
        Unload Me
    End If
End Sub

Private Sub fraDescription_DragDrop(Source As Control, X As Single, Y As Single)
    Call fraAbout_Click
End Sub

Private Sub imgPReC_Click()
    Call fraAbout_Click
End Sub

Private Sub lblCopyright_Click()
    Call fraAbout_Click
End Sub

Private Sub lblDescription_Click()
    Call fraAbout_Click
End Sub

Private Sub lblThanks_Click()
    Call fraAbout_Click
End Sub

Private Sub lblTitle_Click()
    Call fraAbout_Click
End Sub

Private Sub lblVersion_Click()
    Call fraAbout_Click
End Sub

Private Sub Timer1_Timer()
    On Error GoTo hErr
    If m_lngTransparency < 255 Then
        m_lngTransparency = m_lngTransparency + 5
        Call MakeTransparent(Me.hwnd, m_lngTransparency)
        
        If m_lngTransparency = 255 Then
            Timer1.Interval = 2500
        End If
    Else
        If Me.p_blnSplash = True Then
            frmLogin.Show
            Unload Me
        Else
            Timer1.Enabled = False
        End If
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub
