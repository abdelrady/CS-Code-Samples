VERSION 5.00
Begin VB.Form frmLogin 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   1755
   ClientLeft      =   2805
   ClientTop       =   3165
   ClientWidth     =   4410
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1036.912
   ScaleMode       =   0  'User
   ScaleWidth      =   4140.751
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox chkGuest 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Guest"
      Height          =   255
      Left            =   2040
      TabIndex        =   6
      Top             =   960
      Width           =   2295
   End
   Begin VB.TextBox txtUserName 
      Height          =   345
      Left            =   2010
      TabIndex        =   1
      Top             =   135
      Width           =   2325
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   390
      Left            =   1200
      TabIndex        =   4
      Top             =   1320
      Width           =   1140
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   390
      Left            =   2820
      TabIndex        =   5
      Top             =   1320
      Width           =   1140
   End
   Begin VB.TextBox txtPassword 
      Height          =   345
      IMEMode         =   3  'DISABLE
      Left            =   2010
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   525
      Width           =   2325
   End
   Begin VB.Label lblLabels 
      BackStyle       =   0  'Transparent
      Caption         =   "&User Name:"
      Height          =   270
      Index           =   0
      Left            =   825
      TabIndex        =   0
      Top             =   150
      Width           =   1080
   End
   Begin VB.Label lblLabels 
      BackStyle       =   0  'Transparent
      Caption         =   "&Password:"
      Height          =   270
      Index           =   1
      Left            =   825
      TabIndex        =   2
      Top             =   540
      Width           =   1080
   End
   Begin VB.Image imgLogo 
      Height          =   1710
      Left            =   0
      Picture         =   "frmLogin.frx":0000
      Top             =   0
      Width           =   1710
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'\B/ ---------------- Declare Variables ------------------
Option Explicit
Public LoginSucceeded As Boolean
Dim KeySection As String
Dim KeyKey As String
Dim KeyValue As String
Dim rs As Recordset
Dim password As String
Dim type_format As String
Dim RstQuery As Recordset
Dim StrSQL As String
'/E\ ----------------- Finish Declare ---------------------

'\B/ ---------------Code To Use INI Files -----------------
Private Sub loadini()
Dim lngResult As Long
Dim strFileName
Dim strResult As String * 50
strFileName = App.Path & "\bookkeeper.ini" 'Declare your ini file !
lngResult = GetPrivateProfileString(KeySection, _
KeyKey, strFileName, strResult, Len(strResult), _
strFileName)
If lngResult = 0 Then
'An error has occurred
Call MsgBox("An error has occurred while calling the API function", vbExclamation)
Else
KeyValue = Trim(strResult)
End If
End Sub
'/E\ ----------- Finish Code To Use INI Files -------------

'\B/ ---------- Commands For The Cancel Button ------------
Private Sub cmdCancel_Click()
    'set the global var to false
    'to denote a failed login
    LoginSucceeded = False
    Me.Hide
    frmSplash.Show
End Sub
'/E\ ----------Finish Commands For Cancel Button ------------

'\B/ -------------Code To Look Up The Password-------------
Private Sub cmdOK_Click()
    StrSQL = "SELECT * FROM [Users]"
    StrSQL = StrSQL & " WHERE [UserName] LIKE '" & txtUserName.Text & "'"
    Set RstQuery = Db.OpenRecordset(StrSQL)
    If Not (RstQuery.BOF And RstQuery.EOF) Then
    RstQuery.MoveFirst
    password = RstQuery.Fields("Password").Value
    'check for correct password
    If txtPassword = password Then
        'place code to here to pass the
        'success to the calling sub
        'setting a global var is the easiest
        LoginSucceeded = True
        Me.Hide
        frmMain.Show 'Show The Main Menu
        
    Else
        MsgBox "Invalid Password, try again!", , "Login"
        txtPassword.SetFocus
        SendKeys "{Home}+{End}"
    End If
    Else
        MsgBox "Please Enter A User Name", , "Login"
    End If
End Sub
'/E\ -----------Finish Code To Look Up Password ----------

'\B/ -The Commands That Are Executed on the Forms Loading -
Private Sub Form_Load()
KeySection = "Database Properties"
KeyKey = "Database"
loadini
dbName = KeyValue
    Set Db = Nothing
    Set rs = Nothing
    type_format = ""
    Set Db = OpenDatabase(dbName, False, False, type_format)
    Set rs = Db.OpenRecordset("Users")
    rs.MoveFirst
End Sub
'/E\ ---------------- Finish Load Commands ---------------
