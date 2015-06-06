VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.MDIForm MainMDi 
   BackColor       =   &H8000000C&
   Caption         =   "MDIForm1"
   ClientHeight    =   8805
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10005
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picMain 
      Align           =   3  'Align Left
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000004&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   8805
      Left            =   0
      ScaleHeight     =   8805
      ScaleWidth      =   4560
      TabIndex        =   0
      Top             =   0
      Width           =   4560
      Begin MSComctlLib.ProgressBar PBar 
         Height          =   135
         Left            =   0
         TabIndex        =   7
         Top             =   360
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   238
         _Version        =   393216
         Appearance      =   0
         Scrolling       =   1
      End
      Begin VB.ComboBox cboDisplayType 
         Height          =   315
         ItemData        =   "MainMDI.frx":0000
         Left            =   0
         List            =   "MainMDI.frx":000A
         Style           =   2  'Dropdown List
         TabIndex        =   5
         Top             =   0
         Width           =   4095
      End
      Begin VB.PictureBox picSplitter 
         BackColor       =   &H00808080&
         BorderStyle     =   0  'None
         FillColor       =   &H00808080&
         Height          =   4650
         Left            =   4275
         ScaleHeight     =   2024.809
         ScaleMode       =   0  'User
         ScaleWidth      =   780
         TabIndex        =   2
         Top             =   30
         Visible         =   0   'False
         Width           =   72
      End
      Begin VB.PictureBox picInsert 
         AutoRedraw      =   -1  'True
         AutoSize        =   -1  'True
         Height          =   525
         Left            =   -690
         ScaleHeight     =   465
         ScaleWidth      =   525
         TabIndex        =   3
         Top             =   5250
         Width           =   585
      End
      Begin VB.CommandButton cmdMove 
         BackColor       =   &H00FFFFC0&
         Caption         =   "<<<"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   3570
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   7710
         Width           =   525
      End
      Begin VB.ComboBox cbostate 
         Height          =   315
         ItemData        =   "MainMDI.frx":002F
         Left            =   1080
         List            =   "MainMDI.frx":0066
         Sorted          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   6
         Top             =   8280
         Visible         =   0   'False
         Width           =   2655
      End
      Begin MSComctlLib.TreeView trview 
         Height          =   9270
         Left            =   0
         TabIndex        =   4
         Top             =   480
         Width           =   4065
         _ExtentX        =   7170
         _ExtentY        =   16351
         _Version        =   393217
         HideSelection   =   0   'False
         LabelEdit       =   1
         Sorted          =   -1  'True
         Style           =   7
         Appearance      =   1
      End
      Begin VB.Image imgSplitter 
         Height          =   4695
         Left            =   4410
         MousePointer    =   9  'Size W E
         Top             =   45
         Width           =   75
      End
   End
End
Attribute VB_Name = "MainMDi"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const sglSplitLimit = 500
Public TEMPCONN                 As String

Dim mbMoving                    As Boolean

Private Sub cboDisplayType_Click()
    Call FloodTreeView(cboDisplayType.ListIndex)
End Sub

Private Sub MDIForm_Load()
Dim MyState     As Long
Dim TempSTR     As String

On Error GoTo ErrTrap

TEMPCONN = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\DB\Contact Manager.mdb;Jet OLEDB:Database Password=;Admin"

MyState = Val(GetSetting(App.Title, "Settings", "State"))
If MyState = vbNormal Then
    Me.Left = GetSetting(App.Title, "Settings", "MainLeft", 100)
    Me.Top = GetSetting(App.Title, "Settings", "MainTop", 100)
    Me.Width = GetSetting(App.Title, "Settings", "MainWidth", 9615)
    Me.Height = GetSetting(App.Title, "Settings", "MainHeight", 6315)
Else
    Me.WindowState = MyState
End If

trview.Left = picMain.Left + 30
trview.Height = picMain.Height - trview.Top - 400
trview.Width = picMain.Width - trview.Left - 120


trview.Nodes.Clear
trview.Nodes.add , , "AP", "Support Application"
trview.Nodes.add "AP", tvwChild, "AP\IMPORT EXCEL", "IMPORT EXCEL DATA"
trview.Nodes.add "AP", tvwChild, "AP\ACCESS DATABASE VIEWER", "ACCESS DATABASE VIEWER"
trview.Nodes.add "AP", tvwChild, "AP\CONTACTS VIEWER", "CONTACTS VIEWER"
trview.Nodes.add , , "CM", "Contact Manager"
trview.Nodes.add "CM", tvwChild, "CM\ALPHABETICAL", "Cat: Alphabetical Order"
trview.Nodes.add "CM", tvwChild, "CM\STATE", "Cat: By State"
trview.Nodes("AP").Expanded = True
trview.Nodes("CM").Expanded = True
Exit Sub
ErrTrap:
MsgBox Err.Description, vbCritical, "Error - " & Err.Number
Unload Me
End Sub

Private Sub FloodTreeView(Category As Integer)
Dim TempData        As String
Dim TempData2       As String
Dim count           As Long
Dim MyADO           As ADODB.Recordset

Set MyADO = New Recordset
MyADO.Open "SELECT * FROM CONTACT", TEMPCONN, adOpenStatic, adLockOptimistic, adCmdText

Select Case Category
Case 0 ' by state
    trview.Nodes.Remove "CM\STATE"
    trview.Nodes.add "CM", tvwChild, "CM\STATE", "CATEGORY: By State"
    For i = 0 To cbostate.ListCount - 1
        trview.Nodes.add "CM\STATE", tvwChild, "CM\STATE\" & cbostate.List(i), cbostate.List(i)
    Next
    
    trview.Nodes.add "CM\STATE", tvwChild, "CM\STATE\UNCLASIFIED", "**UNCLASIFIED"
    MyADO.MoveFirst: count = 0
    Do While Not MyADO.EOF
        TempData = UCase(MyADO.Fields("State"))
        If TempData = "PENANG" Then
            TempData = "PULAU PINANG"
            MyADO.Fields("State").Value = "PULAU PINANG"
            MyADO.Update
        End If
        If CheckNodes("CM\STATE\" & TempData) <> "" Then
            trview.Nodes.add "CM\STATE\" & TempData, tvwChild, "CM\STATE\" & TempData & "\" & MyADO.Fields("Record ID"), MyADO.Fields("Contact Person") & " "
        Else
            trview.Nodes.add "CM\STATE\UNCLASIFIED", tvwChild, "CM\STATE\UNCLASIFIED" & "\" & MyADO.Fields("Record ID"), MyADO.Fields("Contact Person") & " "
        End If
        MyADO.MoveNext
        count = count + 1
        PBar = (count / MyADO.RecordCount) * 100
    Loop
Case 1
    trview.Nodes.Remove "CM\ALPHABETICAL"
    trview.Nodes.add "CM", tvwChild, "CM\ALPHABETICAL", "CATEGORY: Alphabetical Order"
    TempData = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Do While TempData <> ""
        TempData2 = Left(TempData, 1)
        TempData = Right(TempData, Len(TempData) - 1)
        trview.Nodes.add "CM\ALPHABETICAL", tvwChild, "CM\ALPHABETICAL\" & TempData2, TempData2
    Loop
    trview.Nodes.add "CM\ALPHABETICAL", tvwChild, "CM\ALPHABETICAL\UNCLASIFIED", "**UNCLASIFIED"
    MyADO.MoveFirst: count = 0
    Do While Not MyADO.EOF
        TempData = MyADO.Fields("Contact Person") & " "
        TempData2 = UCase(Left(TempData, 1))
        If CheckNodes("CM\ALPHABETICAL\" & TempData2) <> "" Then
            trview.Nodes.add "CM\ALPHABETICAL\" & TempData2, tvwChild, "CM\ALPHABETICAL\" & TempData2 & "\" & MyADO.Fields("Record ID"), TempData & " "
        Else
            trview.Nodes.add "CM\ALPHABETICAL\UNCLASIFIED", tvwChild, "CM\STATE\UNCLASIFIED" & "\" & MyADO.Fields("Record ID"), TempData & " "
        End If
        MyADO.MoveNext
        count = count + 1
        PBar = (count / MyADO.RecordCount) * 100
    Loop
End Select
MyADO.Close
Set MyADO = Nothing

End Sub

Private Function CheckNodes(NodeKey As String)
On Error GoTo ExitFunction
CheckNodes = ""

CheckNodes = trview.Nodes(NodeKey).Key

Exit Function
ExitFunction:
End Function

Private Sub MDIForm_Unload(Cancel As Integer)
If Me.WindowState <> vbMinimized Then
    SaveSetting App.Title, "Settings", "MainLeft", Me.Left
    SaveSetting App.Title, "Settings", "MainTop", Me.Top
    SaveSetting App.Title, "Settings", "MainWidth", Me.Width
    SaveSetting App.Title, "Settings", "MainHeight", Me.Height
    SaveSetting App.Title, "Settings", "State", Me.WindowState
End If
End Sub

Private Sub MDIForm_Resize()
Dim MyPicMain   As Single

If EffectOn = True Then Exit Sub
If Me.WindowState = 1 Then Exit Sub
    picSplitter.Height = picMain.Height
    picSplitter.Top = 0
    imgSplitter.Top = 0
    imgSplitter.Height = picMain.Height
    picMain.Width = 3960
    If MyPicMain = 0 Then
        SizeControls imgSplitter.Left
    Else
        SizeControls MyPicMain
    End If
    cmdMove.Height = 300
    cmdMove.Top = picMain.Height - cmdMove.Height - 30: cmdMove.ZOrder 0
    imgSplitter.Left = picMain.Width - imgSplitter.Width
    trview.Height = picMain.Height - trview.Top - 400
End Sub

Private Sub cmdMove_Click()
Dim blnStatus   As Boolean

    cmdMove.Tag = "Process"
    If cmdMove.Caption = "<<<" Then
        Do While picMain.Width > 160 + cmdMove.Width
            picMain.Width = picMain.Width - 50
            DoEvents
        Loop
        picMain.Width = 160 + cmdMove.Width
        displayPicmain False
        cmdMove.Caption = ">>>"
    Else
        Do While picMain.Width < 4310
            picMain.Width = picMain.Width + 50
            DoEvents
        Loop
        picMain.Width = 4310
        SizeControls 4310
        cmdMove.Caption = "<<<"
        displayPicmain True
    End If
    cmdMove.Tag = ""
    cmdMove.Left = picMain.Width - cmdMove.Width - 50
End Sub

Private Sub displayPicmain(blnStatus As Boolean)
    trview.Visible = blnStatus
    PBar.Visible = blnStatus
    cboDisplayType.Visible = blnStatus
End Sub

Private Sub imgSplitter_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    Dim sglPos As Single
    
    picSplitter.ZOrder 0
    If mbMoving Then
        sglPos = x + imgSplitter.Left
        If sglPos < sglSplitLimit Then
            picSplitter.Left = sglSplitLimit
        ElseIf sglPos > Me.Width - sglSplitLimit Then
            picSplitter.Left = Me.Width - sglSplitLimit
        Else
            picSplitter.Left = sglPos
        End If
    End If

End Sub

Private Sub imgSplitter_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    With imgSplitter
        picSplitter.Move .Left, .Top, .Width \ 2, .Height - 20
    End With
    picSplitter.Visible = True
    mbMoving = True
End Sub

Private Sub imgSplitter_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
    SizeControls picSplitter.Left
    picSplitter.Visible = False
    mbMoving = False
End Sub

Sub SizeControls(x As Single)

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<set the width
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    If x < 3000 Then x = 3000
    If x > (Me.Width - 1500) Then x = Me.Width - 1500
    picMain.Width = x
    imgSplitter.Left = picMain.Width - imgSplitter.Width
    imgSplitter.Top = 0
    imgSplitter.Height = picMain.Height
    trview.Width = picMain.Width - trview.Left - 120
    PBar.Width = picMain.Width - PBar.Left - 120
    cboDisplayType.Width = picMain.Width - cboDisplayType.Left - 120
    cmdMove.ZOrder 0
    cmdMove.Left = picMain.Width - cmdMove.Width - 50
Exit Sub
WriteMyError:
    Screen.MousePointer = vbNormal
End Sub

Private Sub trview_DblClick()
Dim TempData        As String
Dim i               As Long

On Error GoTo 0
Screen.MousePointer = vbHourglass

TempData = trview.SelectedItem.Key

Select Case TempData
Case "AP\IMPORT EXCEL"
    Load Excel
    Excel.ZOrder 0
Case "AP\ACCESS DATABASE VIEWER"
    Load RDBMS
    RDBMS.ZOrder 0
Case "AP\CONTACTS VIEWER"
    Load Form1
    Form1.ZOrder 0
Case Else
    i = HowMany(TempData, "*")
    If i > 0 Then
        i = i - 1
        TempData = Right(TempData, Len(TempData) - i)
        If Len(TempData) > 0 Then
            Load Form1
            Form1.ZOrder 0
            Call Form1.FloodWithData(TempData, trview.SelectedItem.Key)
        End If
    End If
End Select
Screen.MousePointer = vbNormal
End Sub
