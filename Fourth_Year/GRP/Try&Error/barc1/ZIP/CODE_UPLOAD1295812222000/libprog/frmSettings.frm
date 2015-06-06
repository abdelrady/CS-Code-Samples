VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmSettings 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4230
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   6870
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4230
   ScaleWidth      =   6870
   StartUpPosition =   3  'Windows Default
   Begin VB.Data Periodicals 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "U:\DSD\lib.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   1920
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Periodicals"
      Top             =   3720
      Visible         =   0   'False
      Width           =   1140
   End
   Begin VB.Data dataLibrarySettings 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "U:\DSD\lib.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Library Properties"
      Top             =   4080
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.Data dataItemTypes 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "U:\DSD\lib.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "ItemTypes"
      Top             =   3720
      Visible         =   0   'False
      Width           =   1740
   End
   Begin VB.CommandButton cmdApply 
      Caption         =   "Apply"
      Height          =   375
      Left            =   5520
      TabIndex        =   14
      Top             =   3720
      Width           =   1215
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   4200
      TabIndex        =   13
      Top             =   3720
      Width           =   1215
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   375
      Left            =   2880
      TabIndex        =   12
      Top             =   3720
      Width           =   1215
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   120
      Top             =   3480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      Color           =   16777215
      DialogTitle     =   "Find Database"
      Filter          =   "*.mdb"
      InitDir         =   "app.path"
      Orientation     =   2
   End
   Begin TabDlg.SSTab tabSettings 
      Height          =   3615
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   6855
      _ExtentX        =   12091
      _ExtentY        =   6376
      _Version        =   393216
      Tabs            =   6
      TabHeight       =   520
      BackColor       =   16777215
      TabCaption(0)   =   "Database Properties"
      TabPicture(0)   =   "frmSettings.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label1"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "txtPath"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "Command1"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).ControlCount=   3
      TabCaption(1)   =   "Library Operations"
      TabPicture(1)   =   "frmSettings.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame1"
      Tab(1).Control(1)=   "frmCircDays"
      Tab(1).ControlCount=   2
      TabCaption(2)   =   "Item Type Settings"
      TabPicture(2)   =   "frmSettings.frx":0038
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "DBGrid2"
      Tab(2).ControlCount=   1
      TabCaption(3)   =   "Periodical Settings"
      TabPicture(3)   =   "frmSettings.frx":0054
      Tab(3).ControlEnabled=   0   'False
      Tab(3).Control(0)=   "DBGrid3"
      Tab(3).ControlCount=   1
      TabCaption(4)   =   "Database Tools"
      TabPicture(4)   =   "frmSettings.frx":0070
      Tab(4).ControlEnabled=   0   'False
      Tab(4).ControlCount=   0
      TabCaption(5)   =   "Database Setup"
      TabPicture(5)   =   "frmSettings.frx":008C
      Tab(5).ControlEnabled=   0   'False
      Tab(5).Control(0)=   "Combo1"
      Tab(5).Control(0).Enabled=   0   'False
      Tab(5).ControlCount=   1
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   -74760
         TabIndex        =   19
         Text            =   "Combo1"
         Top             =   720
         Width           =   6255
      End
      Begin MSDBGrid.DBGrid DBGrid3 
         Bindings        =   "frmSettings.frx":00A8
         Height          =   2775
         Left            =   -74880
         OleObjectBlob   =   "frmSettings.frx":00C2
         TabIndex        =   18
         Top             =   720
         Width           =   6495
      End
      Begin MSDBGrid.DBGrid DBGrid2 
         Bindings        =   "frmSettings.frx":0A95
         Height          =   2775
         Left            =   -74880
         OleObjectBlob   =   "frmSettings.frx":0AB1
         TabIndex        =   17
         Top             =   720
         Width           =   6495
      End
      Begin VB.Frame Frame1 
         Caption         =   "Hours"
         Height          =   2655
         Left            =   -73560
         TabIndex        =   15
         Top             =   720
         Width           =   5055
         Begin MSDBGrid.DBGrid DBGrid1 
            Bindings        =   "frmSettings.frx":1484
            Height          =   2295
            Left            =   120
            OleObjectBlob   =   "frmSettings.frx":14A6
            TabIndex        =   16
            Top             =   240
            Width           =   4815
         End
      End
      Begin VB.Frame frmCircDays 
         Caption         =   "Circulation Days"
         Height          =   1935
         Left            =   -74880
         TabIndex        =   4
         Top             =   720
         Width           =   1335
         Begin VB.CheckBox chkSun 
            Caption         =   "Sunday"
            Height          =   195
            Left            =   120
            TabIndex        =   11
            Top             =   1680
            Width           =   1155
         End
         Begin VB.CheckBox chkSat 
            Caption         =   "Saturday"
            Height          =   255
            Left            =   120
            TabIndex        =   10
            Top             =   1440
            Width           =   1155
         End
         Begin VB.CheckBox chkFri 
            Caption         =   "Friday"
            Height          =   255
            Left            =   120
            TabIndex        =   9
            Top             =   1200
            Width           =   1155
         End
         Begin VB.CheckBox chkThurs 
            Caption         =   "Thursday"
            Height          =   255
            Left            =   120
            TabIndex        =   8
            Top             =   960
            Width           =   1155
         End
         Begin VB.CheckBox chkWed 
            Caption         =   "Wednesday"
            Height          =   255
            Left            =   120
            TabIndex        =   7
            Top             =   720
            Width           =   1155
         End
         Begin VB.CheckBox chkTues 
            Caption         =   "Tuesday"
            Height          =   255
            Left            =   120
            TabIndex        =   6
            Top             =   480
            Width           =   1155
         End
         Begin VB.CheckBox chkMon 
            Caption         =   "Monday"
            Height          =   255
            Left            =   120
            TabIndex        =   5
            Top             =   240
            Width           =   1155
         End
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Browse"
         Height          =   255
         Left            =   5760
         TabIndex        =   3
         Top             =   840
         Width           =   735
      End
      Begin VB.TextBox txtPath 
         Height          =   285
         Left            =   1560
         TabIndex        =   2
         Top             =   840
         Width           =   4095
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Database File:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   840
         Width           =   1335
      End
   End
End
Attribute VB_Name = "frmSettings"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim KeySection As String
Dim KeyKey As String
Dim KeyValue As String

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

Private Sub saveini()

Dim lngResult As Long
Dim strFileName
strFileName = App.Path & "\bookkeeper.ini" 'Declare your ini file !
lngResult = WritePrivateProfileString(KeySection, _
KeyKey, KeyValue, strFileName)
If lngResult = 0 Then
'An error has occurred
Call MsgBox("An error has occurred while calling the API function", vbExclamation)
End If

End Sub
' unfortunately you have to include ALL the above on any form
' on which you want to use this, but for my needs this is
' the most simple ini manipulation thing i found :)


Private Sub SSTab1_DblClick()

End Sub

Private Sub cmdApply_Click()
KeySection = "Database Properties"
KeyKey = "Database"
KeyValue = txtPath.Text
saveini
KeySection = "Circulation Properties"
KeyKey = "Mon"
KeyValue = chkMon.Value
saveini
KeyKey = "Tues"
KeyValue = chkTues.Value
saveini
KeyKey = "Wed"
KeyValue = chkWed.Value
saveini
KeyKey = "Thurs"
KeyValue = chkThurs.Value
saveini
KeyKey = "Fri"
KeyValue = chkFri.Value
saveini
KeyKey = "Sat"
KeyValue = chkSat.Value
saveini
KeyKey = "Sun"
KeyValue = chkSun.Value
saveini
End Sub

Private Sub cmdCancel_Click()
Me.Hide
End Sub

Private Sub cmdOK_Click()
KeySection = "Database Properties"
KeyKey = "Database"
KeyValue = txtPath.Text
saveini
KeySection = "Circulation Properties"
KeyKey = "Mon"
KeyValue = chkMon.Value
saveini
KeyKey = "Tues"
KeyValue = chkTues.Value
saveini
KeyKey = "Wed"
KeyValue = chkWed.Value
saveini
KeyKey = "Thurs"
KeyValue = chkThurs.Value
saveini
KeyKey = "Fri"
KeyValue = chkFri.Value
saveini
KeyKey = "Sat"
KeyValue = chkSat.Value
saveini
KeyKey = "Sun"
KeyValue = chkSun.Value
saveini
Me.Hide
End Sub

Private Sub Command1_Click()
CommonDialog1.ShowOpen
txtPath.Text = CommonDialog1.FileName
Data1.DatabaseName = txtPath.Text
End Sub

Private Sub Command3_Click()

End Sub

Private Sub Form_Load()
KeySection = "Database Properties"
KeyKey = "Database"
loadini
txtPath.Text = KeyValue
KeySection = "Circulation Properties"
KeyKey = "Mon"
loadini
chkMon.Value = KeyValue
KeyKey = "Tues"
loadini
chkTues.Value = KeyValue
KeyKey = "Wed"
loadini
chkWed.Value = KeyValue
KeyKey = "Thurs"
loadini
chkThurs.Value = KeyValue
KeyKey = "Fri"
loadini
chkFri.Value = KeyValue
KeyKey = "Sat"
loadini
chkSat.Value = KeyValue
KeyKey = "Sun"
loadini
chkSun.Value = KeyValue
dataItemTypes.DatabaseName = txtPath.Text
dataLibrarySettings.DatabaseName = txtPath.Text
Periodicals.DatabaseName = txtPath.Text
End Sub

Private Sub MSFlexGrid1_Click()

End Sub

Private Sub MSFlexGrid1_DblClick()

End Sub

Private Sub MSFlexGrid1_EnterCell()

End Sub

