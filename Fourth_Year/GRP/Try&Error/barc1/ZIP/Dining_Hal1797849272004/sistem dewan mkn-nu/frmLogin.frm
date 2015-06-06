VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmLogin 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Login :: Sekuriti"
   ClientHeight    =   1305
   ClientLeft      =   2835
   ClientTop       =   3480
   ClientWidth     =   4350
   Icon            =   "frmLogin.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   771.037
   ScaleMode       =   0  'User
   ScaleWidth      =   4084.414
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin LVbuttons.LaVolpeButton cmdCancel 
      Height          =   420
      Left            =   2760
      TabIndex        =   5
      Top             =   840
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   741
      BTYPE           =   3
      TX              =   "&Cancel"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   1
      BCOL            =   12632256
      FCOL            =   0
      FCOLO           =   0
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmLogin.frx":0E42
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   -1  'True
      BSTYLE          =   0
   End
   Begin VB.TextBox txtUserName 
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   345
      Left            =   2160
      TabIndex        =   1
      Top             =   30
      Width           =   2085
   End
   Begin VB.TextBox txtPassword 
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   339
      IMEMode         =   3  'DISABLE
      Left            =   2160
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   420
      Width           =   2085
   End
   Begin MSAdodcLib.Adodc adoStaff 
      Height          =   375
      Left            =   2640
      Top             =   975
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * FROM user"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin LVbuttons.LaVolpeButton cmdOK 
      Height          =   420
      Left            =   960
      TabIndex        =   4
      Top             =   840
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   741
      BTYPE           =   3
      TX              =   "&Login"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   1
      BCOL            =   12632256
      FCOL            =   0
      FCOLO           =   0
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmLogin.frx":0E5E
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   -1  'True
      BSTYLE          =   0
   End
   Begin VB.Image Image1 
      Height          =   840
      Left            =   0
      Picture         =   "frmLogin.frx":0E7A
      Stretch         =   -1  'True
      Top             =   120
      Width           =   825
   End
   Begin VB.Label lblLabels 
      BackStyle       =   0  'Transparent
      Caption         =   "&Login ID"
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
      Index           =   0
      Left            =   960
      TabIndex        =   0
      Top             =   120
      Width           =   1080
   End
   Begin VB.Label lblLabels 
      BackStyle       =   0  'Transparent
      Caption         =   "&Password"
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
      Index           =   1
      Left            =   960
      TabIndex        =   2
      Top             =   495
      Width           =   1080
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public LoginSucceeded As Boolean
Public logOk As Integer
Public passOk As Integer


Private Sub cmdCancel_Click()
    Dim ans As String
    LoginSucceeded = False
    ans = MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Quit?")
    If ans = vbYes Then
        End
    Else
        txtUserName.SetFocus
        Exit Sub
    End If
End Sub

Private Sub cmdOK_Click()
    If txtUserName.Text = "" Or txtPassword.Text = "" Then
       MsgBox "Please specify your password!", vbOKOnly + vbExclamation, "Security"
       txtUserName.SetFocus
       Exit Sub
    End If
    
    logOk = 0
    passOk = 0
    
    adoStaff.Refresh
    adoStaff.Recordset.MoveFirst
    While Not adoStaff.Recordset.EOF
        If LCase(adoStaff.Recordset.Fields("userLogin").Value) = txtUserName.Text Then
            logOk = 1 'rite log id
            curLogin = adoStaff.Recordset.Fields("userLogin").Value
            If adoStaff.Recordset.Fields("userPass").Value = LCase(txtPassword.Text) Then
                passOk = 1
                curLevel = adoStaff.Recordset.Fields("userLevel").Value
                GoTo nomb
            Else
                passOk = 0
                GoTo nomb
            End If
        Else
            adoStaff.Recordset.MoveNext
        End If
    Wend
    
    
nomb:
          If logOk = 0 Then
            MsgBox "Your login id is invalid!", vbOKOnly, "Security"
            txtUserName.SetFocus
            'Exit Sub
            SendKeys "{Home}+{End}"
          End If
          
          If passOk = 0 And logOk = 1 Then
            MsgBox "Your password is invalid!", vbOKOnly, "Security"
            txtPassword.SetFocus
            'Exit Sub
            SendKeys "{Home}+{End}"
          End If
          
         
          If logOk = 1 And passOk = 1 Then
             LoginSucceeded = True
             Me.Hide
             If LoginSucceeded = True Then
                Load frmStudnt
                frmStudnt.Show
             End If
             Exit Sub
          End If
End Sub
Private Sub Form_Unload(Cancel As Integer)
    Dim ans As String
    LoginSucceeded = False
    ans = MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Quit?")
    If ans = vbYes Then
        End
    Else
        Cancel = 1
    End If
End Sub

Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        cmdOK_Click
    End If
End Sub

Private Sub txtUserName_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        txtPassword.SetFocus
    End If
End Sub
