VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "DB&FCIS"
   ClientHeight    =   4380
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   8205
   ForeColor       =   &H0000FF00&
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "DB INSERT"
   MaxButton       =   0   'False
   ScaleHeight     =   4380
   ScaleWidth      =   8205
   StartUpPosition =   2  'CenterScreen
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton Command11 
      Caption         =   "Count Of Rec."
      Height          =   375
      Left            =   6480
      TabIndex        =   33
      Top             =   3360
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CheckBox Check1 
      Caption         =   "&Clear After ADD"
      Height          =   375
      Left            =   360
      TabIndex        =   32
      Top             =   2400
      Width           =   1575
   End
   Begin VB.CommandButton Command9 
      Caption         =   "&Delete"
      Height          =   300
      Left            =   6720
      TabIndex        =   31
      Top             =   3000
      Width           =   855
   End
   Begin VB.CommandButton Command10 
      Caption         =   "&Search"
      Height          =   300
      Left            =   5640
      TabIndex        =   30
      Top             =   3000
      Width           =   855
   End
   Begin VB.TextBox Text12 
      Height          =   495
      Left            =   5280
      TabIndex        =   29
      Top             =   3600
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox Text11 
      Height          =   495
      Left            =   360
      TabIndex        =   28
      Top             =   3720
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton Command8 
      Caption         =   ">>"
      Height          =   495
      Left            =   4320
      TabIndex        =   27
      Top             =   3600
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton Command7 
      Caption         =   "<<"
      Height          =   495
      Left            =   2520
      TabIndex        =   26
      Top             =   3600
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton Command5 
      Caption         =   "<"
      Height          =   495
      Left            =   3120
      TabIndex        =   25
      Top             =   3600
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox Text6 
      DataField       =   "TYPE_NAME"
      DataSource      =   "Ado_KEY_TYPES"
      Height          =   495
      Left            =   5880
      TabIndex        =   24
      Text            =   "Text6"
      Top             =   2760
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   ">"
      Height          =   495
      Left            =   3720
      TabIndex        =   23
      Top             =   3600
      Visible         =   0   'False
      Width           =   495
   End
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   375
      Left            =   2160
      Top             =   1800
      Visible         =   0   'False
      Width           =   2655
      _ExtentX        =   4683
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
      Connect         =   $"Form1.frx":5E8A
      OLEDBString     =   $"Form1.frx":5F22
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.TextBox Text10 
      Height          =   495
      Left            =   120
      TabIndex        =   20
      Text            =   "-1"
      Top             =   3240
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox Text9 
      Height          =   495
      Left            =   5760
      TabIndex        =   19
      Text            =   "-1"
      Top             =   3360
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "&View Records"
      Height          =   300
      Left            =   2040
      TabIndex        =   17
      Top             =   3000
      Width           =   1215
   End
   Begin VB.TextBox Text8 
      Height          =   295
      Left            =   2880
      MultiLine       =   -1  'True
      TabIndex        =   5
      Top             =   1440
      Width           =   3555
   End
   Begin VB.CommandButton Command4 
      Caption         =   "&Clear"
      Height          =   300
      Left            =   960
      TabIndex        =   9
      Top             =   3000
      Width           =   855
   End
   Begin VB.TextBox Text7 
      DataField       =   "FULL_NAME"
      DataSource      =   "Ado_REG_ORG"
      Height          =   495
      Left            =   0
      TabIndex        =   16
      Text            =   "Text7"
      Top             =   3240
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Cancel          =   -1  'True
      Caption         =   "E&XIT"
      Height          =   300
      Left            =   3480
      TabIndex        =   10
      Top             =   3000
      Width           =   615
   End
   Begin MSAdodcLib.Adodc Ado_KEY_TYPES 
      Height          =   330
      Left            =   120
      Top             =   3720
      Visible         =   0   'False
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   582
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
      Connect         =   $"Form1.frx":5FBA
      OLEDBString     =   $"Form1.frx":6052
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from KEY_TYPES"
      Caption         =   "Adodc3"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSAdodcLib.Adodc Ado_REG_ORG 
      Height          =   375
      Left            =   5160
      Top             =   3720
      Visible         =   0   'False
      Width           =   1935
      _ExtentX        =   3413
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
      Connect         =   $"Form1.frx":60EA
      OLEDBString     =   $"Form1.frx":6182
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from REG_ORG"
      Caption         =   "Adodc2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.ComboBox cmb_KEY_TYPES 
      Height          =   315
      ItemData        =   "Form1.frx":621A
      Left            =   2040
      List            =   "Form1.frx":621C
      Style           =   2  'Dropdown List
      TabIndex        =   6
      Top             =   2400
      Width           =   2175
   End
   Begin VB.ComboBox cmb_REG_ORG 
      Height          =   315
      ItemData        =   "Form1.frx":621E
      Left            =   4920
      List            =   "Form1.frx":6220
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   2400
      Width           =   2175
   End
   Begin VB.TextBox Text5 
      Height          =   295
      Left            =   120
      TabIndex        =   4
      Top             =   1440
      Width           =   2475
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&ADD To DB"
      Height          =   300
      Left            =   4320
      TabIndex        =   8
      Top             =   3000
      Width           =   1095
   End
   Begin VB.TextBox Text4 
      Height          =   295
      Left            =   7560
      TabIndex        =   3
      Top             =   1440
      Width           =   495
   End
   Begin VB.TextBox Text3 
      Height          =   295
      Left            =   6720
      TabIndex        =   2
      Top             =   1440
      Width           =   495
   End
   Begin VB.TextBox Text2 
      Height          =   295
      Left            =   4200
      MultiLine       =   -1  'True
      TabIndex        =   1
      Top             =   480
      Width           =   3840
   End
   Begin VB.TextBox Text1 
      DataSource      =   "Adodc1"
      Height          =   295
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   0
      Top             =   480
      Width           =   3675
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   495
      Left            =   1800
      Top             =   3600
      Visible         =   0   'False
      Width           =   3495
      _ExtentX        =   6165
      _ExtentY        =   873
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
      Connect         =   $"Form1.frx":6222
      OLEDBString     =   $"Form1.frx":62BA
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from REG_KEYS"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label Label8 
      Caption         =   "Reg_Hive"
      Height          =   495
      Left            =   5640
      TabIndex        =   22
      Top             =   2160
      Width           =   735
   End
   Begin VB.Label Label7 
      Caption         =   "Key_Type"
      Height          =   495
      Left            =   2640
      TabIndex        =   21
      Top             =   2160
      Width           =   735
   End
   Begin VB.Label Label6 
      Caption         =   "Notes:"
      Height          =   255
      Left            =   4680
      TabIndex        =   18
      Top             =   1200
      Width           =   495
   End
   Begin VB.Label Label5 
      Caption         =   "Tip Key:"
      Height          =   255
      Left            =   720
      TabIndex        =   15
      Top             =   1200
      Width           =   615
   End
   Begin VB.Label Label4 
      Caption         =   "OFF:"
      Height          =   255
      Left            =   7560
      TabIndex        =   14
      Top             =   1200
      Width           =   495
   End
   Begin VB.Label Label3 
      Caption         =   "ON:"
      Height          =   255
      Left            =   6720
      TabIndex        =   13
      Top             =   1200
      Width           =   495
   End
   Begin VB.Label Label2 
      Caption         =   "Tip Key Path:"
      Height          =   495
      Left            =   5760
      TabIndex        =   12
      Top             =   240
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Tip Name:"
      Height          =   495
      Left            =   840
      TabIndex        =   11
      Top             =   240
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim num As Integer, asd As Integer
Function test_Find() As Integer
Adodc2.RecordSource = "select Tip_KEY,KEY_PATH From REG_KEYS Where TIP_KEY = '" + Text5.Text + "' And KEY_PATH='" + Text2.Text + "'"
'Key_Path = '" + Text2.Text + "' And
Set Text11.DataSource = Adodc2
Set Text12.DataSource = Adodc2
Text11.DataField = "tip_key"
Text12.DataField = "Key_path"
Dim k As Integer
k = Adodc2.Recordset.RecordCount
'MsgBox k
If k > 0 Then
test_Find = 1
Else
test_Find = 0
End If
End Function

Private Sub cmb_KEY_TYPES_Click()
If Command6.Caption = "&Hide Records" Then
Text9.Text = cmb_KEY_TYPES.ListIndex
End If
End Sub

Private Sub Command1_Click()
'Adodc1.Recordset.AddNew Array("TIP_DESC", "KEY_PATH", "TIP_KEY", "ON_VAL", "OFF_VAL", "TYPE_ID", "ORG_ID") _array(Text1.Text,Text2.Text,Text5.Text,Val(Text3.Text),Val(Text4.Text),cmb_KEY_TYPES.ListIndex,cmb_REG_ORG.ListIndex )
If (cmb_REG_ORG.ListIndex < 0 Or cmb_KEY_TYPES.ListIndex < 0) Then
MsgBox "YOU Must Choose From HEKY Types & Key Types", vbCritical + vbOKOnly
Exit Sub
End If
If asd = 0 Then
Adodc1.Recordset.Open
asd = 1
End If
Dim j As Integer
j = test_Find()
If j = 1 Then
MsgBox "Record Exactly Found In DB", vbCritical + vbOKOnly
'Command4.Value = True
Exit Sub
End If

Adodc1.Recordset.AddNew
Adodc1.Recordset.Fields("TIP_DESC").Value = Text1.Text
Adodc1.Recordset.Fields("KEY_PATH").Value = Text2.Text
Adodc1.Recordset.Fields("TIP_KEY").Value = Text5.Text
Adodc1.Recordset.Fields("ON_VAL").Value = Text3.Text
Adodc1.Recordset.Fields("OFF_VAL").Value = Text4.Text
Adodc1.Recordset.Fields("TYPE_ID").Value = cmb_KEY_TYPES.ListIndex
Adodc1.Recordset.Fields("ORG_ID").Value = cmb_REG_ORG.ListIndex
Adodc1.Recordset.Fields("Notes").Value = Text8.Text
'Adodc1.Recordset.Update
MsgBox "RECORD ADDED", vbInformation + vbOKOnly
If Check1.Value = True Then
Command4.Value = True
End If

End Sub

Private Sub Command10_Click()
If Command6.Caption = "&View Records" Then Command6.Value = True
Dim BookMark1 As Variant
    'Mark your place in case no match is found
BookMark1 = Adodc1.Recordset.Bookmark
    'Move to top of table to start search
'Adodc1.Recordset.MoveFirst
    Adodc1.Recordset.Find "TIP_KEY = '" + InputBox("Enter Key To Search For:") + "'", 0, adSearchForward
    If Adodc1.Recordset.EOF = True Then
      Adodc1.Recordset.Bookmark = BookMark1
    End If
End Sub

Private Sub Command11_Click()
If Command6.Caption = "&View Records" Then Command6.Value = True
Dim BookMark1 As Variant
    'Mark your place in case no match is found
BookMark1 = Adodc1.Recordset.Bookmark
    Adodc1.Recordset.Find "On_Val = 99 ", 1, adSearchForward
    If Adodc1.Recordset.EOF = True Then
      Adodc1.Recordset.Bookmark = BookMark1
  End If
' MsgBox Adodc1.Recordset.RecordCount

End Sub

Private Sub Command2_Click()
If Not Adodc1.Recordset.EOF Then
Adodc1.Recordset.MoveNext
Else
Adodc1.Recordset.MoveLast
End If
cmb_KEY_TYPES.ListIndex = Val(Text9.Text)
cmb_REG_ORG.ListIndex = Val(Text10.Text)
'Adodc2.Recordset.Requery
End Sub

Private Sub Command3_Click()
Dim i As Integer
i = MsgBox("SURE. U Want To Exit.", vbQuestion + vbYesNo)
If i = vbYes Then
'Ado_REG_ORG.Recordset.Close
'Ado_KEY_TYPES.Recordset.Close
'Adodc1.Recordset.Close
End
Else
Exit Sub
End If
End Sub
Private Sub Command4_Click()
Text1.Text = "": Text2.Text = "": Text3.Text = "": Text4.Text = "": Text5.Text = "": Text8.Text = ""
cmb_REG_ORG.ListIndex = -1
cmb_KEY_TYPES.ListIndex = -1
Text1.SetFocus
End Sub

Private Sub Command5_Click()
If Not Adodc1.Recordset.BOF Then
Adodc1.Recordset.MovePrevious
Else
Adodc1.Recordset.MoveFirst
End If
cmb_KEY_TYPES.ListIndex = Val(Text9.Text)
cmb_REG_ORG.ListIndex = Val(Text10.Text)
End Sub

Private Sub Command6_Click()

If Command6.Caption = "&View Records" Then
'Command1.Enabled = False
Command4.Enabled = False
Command2.Visible = True
Command5.Visible = True
Command7.Visible = True
Command8.Visible = True
If asd = 0 Then
Adodc1.Recordset.Open
asd = 1
End If
Set Text1.DataSource = Adodc1
Set Text2.DataSource = Adodc1
Set Text3.DataSource = Adodc1
Set Text4.DataSource = Adodc1
Set Text5.DataSource = Adodc1
Set Text9.DataSource = Adodc1
Set Text10.DataSource = Adodc1
Set Text8.DataSource = Adodc1
Text1.DataField = "tip_desc"
Text2.DataField = "Key_path"
Text5.DataField = "Tip_KEY"
Text3.DataField = "ON_VAL"
Text4.DataField = "OFF_VAL"
Text9.DataField = "Type_ID"
Text10.DataField = "ORG_ID"
Text8.DataField = "Notes"
Command6.Caption = "&Hide Records"
cmb_KEY_TYPES.ListIndex = Val(Text9.Text)
cmb_REG_ORG.ListIndex = Val(Text10.Text)
Else
'If Command6.Caption = "" Then
asd = 0
Command1.Enabled = True
Command4.Enabled = True
Command2.Visible = False
Command5.Visible = False
Command7.Visible = False
Command8.Visible = False

Set Text1.DataSource = Nothing
Set Text2.DataSource = Nothing
Set Text3.DataSource = Nothing
Set Text4.DataSource = Nothing
Set Text5.DataSource = Nothing
Set Text9.DataSource = Nothing
Set Text10.DataSource = Nothing
Set Text8.DataSource = Nothing
Text1.DataField = ""
Text2.DataField = ""
Text5.DataField = ""
Text3.DataField = ""
Text4.DataField = ""
Text9.DataField = ""
Text10.DataField = ""
Text8.DataField = ""
Adodc1.Recordset.Close
cmb_KEY_TYPES.ListIndex = -1
cmb_REG_ORG.ListIndex = -1
Command6.Caption = "&View Records"
Command4.Value = True
End If
End Sub

Private Sub Command7_Click()
Adodc1.Recordset.MoveFirst
cmb_KEY_TYPES.ListIndex = Val(Text9.Text)
cmb_REG_ORG.ListIndex = Val(Text10.Text)
End Sub

Private Sub Command8_Click()
Adodc1.Recordset.MoveLast
cmb_KEY_TYPES.ListIndex = Val(Text9.Text)
cmb_REG_ORG.ListIndex = Val(Text10.Text)
End Sub

Private Sub Command9_Click()
If Command6.Caption = "&View Records" Then
MsgBox "No Record To Delete.Click View Records First.", vbCritical + vbOKOnly, "Error"
Exit Sub
End If
'ActiveControl.Caption = "asd"
'Clipboard.GetText
Dim i As Integer
i = MsgBox("Sure Delete.", vbInformation + vbYesNo, "Confirmation")
If i = vbYes Then
Adodc1.Recordset.Delete adAffectCurrent
Adodc1.Recordset.MoveNext
If Adodc1.Recordset.EOF Then
Adodc1.Recordset.MovePrevious
End If
End If
End Sub

Private Sub Form_Load()
num = -1
asd = 1
'Text1.Text = "": Text2.Text = "": Text3.Text = "": Text4.Text = ""
Me.Show
Do Until Ado_REG_ORG.Recordset.EOF
cmb_REG_ORG.AddItem Text7.Text
Ado_REG_ORG.Recordset.MoveNext
Loop

Do Until Ado_KEY_TYPES.Recordset.EOF
cmb_KEY_TYPES.AddItem Text6.Text
Ado_KEY_TYPES.Recordset.MoveNext
Loop
End Sub

