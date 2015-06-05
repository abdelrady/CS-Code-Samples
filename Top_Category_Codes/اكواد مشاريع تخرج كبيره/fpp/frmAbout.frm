VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About MyApp"
   ClientHeight    =   4995
   ClientLeft      =   2340
   ClientTop       =   1935
   ClientWidth     =   6345
   ClipControls    =   0   'False
   LinkTopic       =   "Form2"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3447.637
   ScaleMode       =   0  'User
   ScaleWidth      =   5958.282
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame Frame1 
      Height          =   1110
      Left            =   135
      TabIndex        =   14
      Top             =   2055
      Width           =   4620
      Begin VB.CommandButton cmdRegister 
         Caption         =   "Register"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   3435
         TabIndex        =   17
         Top             =   150
         Visible         =   0   'False
         Width           =   1125
      End
      Begin VB.Label lblRegisteredTo 
         AutoSize        =   -1  'True
         Caption         =   "This product is registered to:"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   150
         TabIndex        =   16
         Top             =   195
         Visible         =   0   'False
         Width           =   2475
      End
      Begin VB.Label lblUserName 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "FREEWARE"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   270
         Left            =   1545
         TabIndex        =   15
         Top             =   480
         Width           =   1500
      End
   End
   Begin VB.TextBox txtDisclaimer 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000012&
      Height          =   915
      Left            =   3345
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   13
      TabStop         =   0   'False
      Text            =   "frmAbout.frx":0000
      Top             =   3270
      Width           =   2850
   End
   Begin VB.CommandButton cmdCheckForUpdate 
      Caption         =   "Check for an update!"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   600
      Left            =   510
      TabIndex        =   10
      Top             =   3420
      Width           =   2190
   End
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   345
      Left            =   5040
      TabIndex        =   9
      Top             =   2310
      Width           =   1260
   End
   Begin VB.PictureBox picIcon 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      ClipControls    =   0   'False
      ForeColor       =   &H80000008&
      Height          =   480
      Left            =   240
      Picture         =   "frmAbout.frx":0163
      ScaleHeight     =   337.12
      ScaleMode       =   0  'User
      ScaleWidth      =   337.12
      TabIndex        =   0
      Top             =   240
      Width           =   480
   End
   Begin VB.CommandButton cmdSysInfo 
      Caption         =   "System Info..."
      Height          =   345
      Left            =   5040
      TabIndex        =   1
      Top             =   2760
      Width           =   1245
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      Caption         =   "Portions Copyright 1998-2002 Yuri Margolin.  All rights reserved."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   75
      TabIndex        =   12
      Top             =   4695
      Width           =   6180
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "e-mail:"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   75
      TabIndex        =   11
      Top             =   1590
      Width           =   690
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Caption         =   "Copyright 2002 Alexander Popov Emulation Soft.   All rights reserved."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Left            =   75
      TabIndex        =   8
      Top             =   4350
      Width           =   6195
   End
   Begin VB.Label lblEmail 
      AutoSize        =   -1  'True
      BackColor       =   &H0080FFFF&
      Caption         =   " info@emu8086.com "
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   12
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   240
      Left            =   1395
      MouseIcon       =   "frmAbout.frx":046D
      MousePointer    =   99  'Custom
      TabIndex        =   7
      Top             =   1620
      Width           =   2430
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "homepage:"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   75
      TabIndex        =   6
      Top             =   1200
      Width           =   1095
   End
   Begin VB.Label lblURL 
      AutoSize        =   -1  'True
      BackColor       =   &H0080FFFF&
      Caption         =   " http://www.emu8086.com/vb/ "
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   12
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   240
      Left            =   1395
      MouseIcon       =   "frmAbout.frx":05BF
      MousePointer    =   99  'Custom
      TabIndex        =   5
      Top             =   1215
      Width           =   3780
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderStyle     =   6  'Inside Solid
      Index           =   1
      X1              =   70.429
      X2              =   5817.425
      Y1              =   1376.984
      Y2              =   1376.984
   End
   Begin VB.Label lblDescription 
      AutoSize        =   -1  'True
      Caption         =   "Data-Flow Visual Programming Language"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   1500
      TabIndex        =   2
      Top             =   885
      Width           =   4065
   End
   Begin VB.Label lblTitle 
      AutoSize        =   -1  'True
      Caption         =   "Application Title"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   1050
      TabIndex        =   3
      Top             =   240
      Width           =   1515
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00FFFFFF&
      BorderWidth     =   2
      Index           =   0
      X1              =   56.343
      X2              =   5803.339
      Y1              =   1387.337
      Y2              =   1387.337
   End
   Begin VB.Label lblVersion 
      AutoSize        =   -1  'True
      Caption         =   "version"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1095
      TabIndex        =   4
      Top             =   585
      Width           =   705
   End
End
Attribute VB_Name = "frmAbout"
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

Option Explicit

' Reg Key Security Options...
Const READ_CONTROL = &H20000
Const KEY_QUERY_VALUE = &H1
Const KEY_SET_VALUE = &H2
Const KEY_CREATE_SUB_KEY = &H4
Const KEY_ENUMERATE_SUB_KEYS = &H8
Const KEY_NOTIFY = &H10
Const KEY_CREATE_LINK = &H20
Const KEY_ALL_ACCESS = KEY_QUERY_VALUE + KEY_SET_VALUE + _
                       KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + _
                       KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL
                     
' Reg Key ROOT Types...
Const HKEY_LOCAL_MACHINE = &H80000002
Const ERROR_SUCCESS = 0
Const REG_SZ = 1                         ' Unicode nul terminated string
Const REG_DWORD = 4                      ' 32-bit number

Const gREGKEYSYSINFOLOC = "SOFTWARE\Microsoft\Shared Tools Location"
Const gREGVALSYSINFOLOC = "MSINFO"
Const gREGKEYSYSINFO = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
Const gREGVALSYSINFO = "PATH"

Private Declare Function RegOpenKeyEx Lib "advapi32" Alias "RegOpenKeyExA" (ByVal hKey As Long, ByVal lpSubKey As String, ByVal ulOptions As Long, ByVal samDesired As Long, ByRef phkResult As Long) As Long
Private Declare Function RegQueryValueEx Lib "advapi32" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, ByRef lpType As Long, ByVal lpData As String, ByRef lpcbData As Long) As Long
Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Long) As Long


Private Sub cmdCheckForUpdate_Click()
   Call ShellExecute(Me.hwnd, "open", "http://www.emu8086.com/vb/", "", App.Path, SW_SHOWDEFAULT)
End Sub

'Private Sub cmdRegister_Click()
'    frmRegister.Show vbModal, Me
'End Sub

Private Sub cmdSysInfo_Click()
  Call StartSysInfo
End Sub

Private Sub cmdOK_Click()

  Me.Hide
    
' 1.19 called from frmEmulation also...
' so only hide!
' frmMain.SetFocus

End Sub

'Public Sub show_Registered_To()
'    If bREGISTERED Then
'        cmdRegister.Visible = False
'        lblUserName.Caption = sUSER_NAME
'    End If
'End Sub



Private Sub Form_Load()
    Me.Caption = "About " & App.Title
    lblVersion.Caption = "version " & App.Major & "." & App.Minor & App.Revision '& sBETA_STRING
    lblTitle.Caption = App.Title
    
    Me.Icon = frmMain.Icon 'yur
    
    'show_Registered_To
End Sub

Public Sub StartSysInfo()
    On Error GoTo SysInfoErr
  
    Dim rc As Long
    Dim SysInfoPath As String
    
    ' Try To Get System Info Program Path\Name From Registry...
    If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFO, gREGVALSYSINFO, SysInfoPath) Then
    ' Try To Get System Info Program Path Only From Registry...
    ElseIf GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFOLOC, gREGVALSYSINFOLOC, SysInfoPath) Then
        ' Validate Existance Of Known 32 Bit File Version
        If (Dir(SysInfoPath & "\MSINFO32.EXE") <> "") Then
            SysInfoPath = SysInfoPath & "\MSINFO32.EXE"
            
        ' Error - File Can Not Be Found...
        Else
            GoTo SysInfoErr
        End If
    ' Error - Registry Entry Can Not Be Found...
    Else
        GoTo SysInfoErr
    End If
    
    Call Shell(SysInfoPath, vbNormalFocus)
    
    Exit Sub
SysInfoErr:
    MsgBox "System Information Is Unavailable At This Time", vbOKOnly
End Sub

Public Function GetKeyValue(KeyRoot As Long, KeyName As String, SubKeyRef As String, ByRef KeyVal As String) As Boolean
    Dim i As Long                                           ' Loop Counter
    Dim rc As Long                                          ' Return Code
    Dim hKey As Long                                        ' Handle To An Open Registry Key
    Dim hDepth As Long                                      '
    Dim KeyValType As Long                                  ' Data Type Of A Registry Key
    Dim tmpVal As String                                    ' Tempory Storage For A Registry Key Value
    Dim KeyValSize As Long                                  ' Size Of Registry Key Variable
    '------------------------------------------------------------
    ' Open RegKey Under KeyRoot {HKEY_LOCAL_MACHINE...}
    '------------------------------------------------------------
    rc = RegOpenKeyEx(KeyRoot, KeyName, 0, KEY_ALL_ACCESS, hKey) ' Open Registry Key
    
    If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError          ' Handle Error...
    
    tmpVal = String$(1024, 0)                             ' Allocate Variable Space
    KeyValSize = 1024                                       ' Mark Variable Size
    
    '------------------------------------------------------------
    ' Retrieve Registry Key Value...
    '------------------------------------------------------------
    rc = RegQueryValueEx(hKey, SubKeyRef, 0, _
                         KeyValType, tmpVal, KeyValSize)    ' Get/Create Key Value
                        
    If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError          ' Handle Errors
    
    If (Asc(Mid(tmpVal, KeyValSize, 1)) = 0) Then           ' Win95 Adds Null Terminated String...
        tmpVal = Left(tmpVal, KeyValSize - 1)               ' Null Found, Extract From String
    Else                                                    ' WinNT Does NOT Null Terminate String...
        tmpVal = Left(tmpVal, KeyValSize)                   ' Null Not Found, Extract String Only
    End If
    '------------------------------------------------------------
    ' Determine Key Value Type For Conversion...
    '------------------------------------------------------------
    Select Case KeyValType                                  ' Search Data Types...
    Case REG_SZ                                             ' String Registry Key Data Type
        KeyVal = tmpVal                                     ' Copy String Value
    Case REG_DWORD                                          ' Double Word Registry Key Data Type
        For i = Len(tmpVal) To 1 Step -1                    ' Convert Each Bit
            KeyVal = KeyVal + Hex(Asc(Mid(tmpVal, i, 1)))   ' Build Value Char. By Char.
        Next
        KeyVal = Format$("&h" + KeyVal)                     ' Convert Double Word To String
    End Select
    
    GetKeyValue = True                                      ' Return Success
    rc = RegCloseKey(hKey)                                  ' Close Registry Key
    Exit Function                                           ' Exit
    
GetKeyError:      ' Cleanup After An Error Has Occured...
    KeyVal = ""                                             ' Set Return Val To Empty String
    GetKeyValue = False                                     ' Return Failure
    rc = RegCloseKey(hKey)                                  ' Close Registry Key
End Function


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If lblURL.FontUnderline Then lblURL.FontUnderline = False
    If lblEmail.FontUnderline Then lblEmail.FontUnderline = False
End Sub

Private Sub lblEmail_Click()
   Call ShellExecute(Me.hwnd, "open", "mailto:info@emu8086.com", "", App.Path, SW_SHOWDEFAULT)

End Sub

Private Sub lblEmail_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Not lblEmail.FontUnderline Then lblEmail.FontUnderline = True
End Sub

Private Sub lblURL_Click()
   Call ShellExecute(Me.hwnd, "open", "http://www.emu8086.com/vb/", "", App.Path, SW_SHOWDEFAULT)

End Sub

Private Sub lblURL_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Not lblURL.FontUnderline Then lblURL.FontUnderline = True
End Sub


Private Sub Form_Activate()
    ' 1.23#252
    ' in case font is not as original, make sure
    ' the size of the labels will become regular
    ' before user moves mouse over:
    
    lblURL.FontUnderline = True
    lblEmail.FontUnderline = True
    
    lblURL.FontUnderline = False
    lblEmail.FontUnderline = False
End Sub
