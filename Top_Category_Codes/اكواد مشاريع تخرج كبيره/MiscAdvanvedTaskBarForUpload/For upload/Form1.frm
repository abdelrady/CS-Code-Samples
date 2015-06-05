VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{48E59290-9880-11CF-9754-00AA00C00908}#1.0#0"; "MSINET.OCX"
Begin VB.Form frmMain 
   AutoRedraw      =   -1  'True
   BorderStyle     =   0  'None
   ClientHeight    =   15300
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   3510
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   15300
   ScaleWidth      =   3510
   ShowInTaskbar   =   0   'False
   Begin VB.PictureBox picMain 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      Height          =   15420
      Left            =   0
      Picture         =   "Form1.frx":1DBA
      ScaleHeight     =   15360
      ScaleWidth      =   3000
      TabIndex        =   1
      Top             =   0
      Width           =   3060
      Begin VB.PictureBox picContain 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFC0C0&
         BorderStyle     =   0  'None
         FillColor       =   &H00FF8080&
         Height          =   530
         Left            =   0
         MouseIcon       =   "Form1.frx":183A3
         MousePointer    =   99  'Custom
         Picture         =   "Form1.frx":184F5
         ScaleHeight     =   525
         ScaleWidth      =   375
         TabIndex        =   4
         Top             =   0
         Width           =   375
         Begin VB.PictureBox picShortcut 
            AutoRedraw      =   -1  'True
            AutoSize        =   -1  'True
            BackColor       =   &H00FFC0C0&
            BorderStyle     =   0  'None
            Height          =   475
            Index           =   0
            Left            =   -480
            ScaleHeight     =   32
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   32
            TabIndex        =   5
            Top             =   0
            Width           =   475
         End
      End
      Begin VB.PictureBox Picture1 
         Height          =   495
         Left            =   2520
         ScaleHeight     =   435
         ScaleWidth      =   435
         TabIndex        =   3
         Top             =   0
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Line lnSecond 
         BorderColor     =   &H00E0E0E0&
         X1              =   240
         X2              =   0
         Y1              =   240
         Y2              =   0
      End
      Begin VB.Image cmdAlarm 
         Height          =   1005
         Left            =   1920
         Picture         =   "Form1.frx":1AD97
         Stretch         =   -1  'True
         Top             =   15960
         Width           =   1035
      End
      Begin VB.Line lnMinute 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   2
         X1              =   0
         X2              =   360
         Y1              =   360
         Y2              =   120
      End
      Begin VB.Line lnHour 
         BorderColor     =   &H00E0E0E0&
         BorderWidth     =   3
         X1              =   0
         X2              =   360
         Y1              =   120
         Y2              =   240
      End
      Begin VB.Image imgPic 
         Height          =   375
         Left            =   0
         ToolTipText     =   "Click to see full screen"
         Top             =   0
         Width           =   435
      End
      Begin VB.Image cmdNext 
         Height          =   285
         Left            =   0
         Picture         =   "Form1.frx":1B679
         Stretch         =   -1  'True
         Top             =   0
         Width           =   285
      End
      Begin VB.Image cmdPer 
         Height          =   330
         Left            =   0
         Picture         =   "Form1.frx":1BD82
         Stretch         =   -1  'True
         Top             =   0
         Width           =   285
      End
      Begin VB.Image imgWall 
         Height          =   315
         Left            =   0
         Picture         =   "Form1.frx":1C433
         Stretch         =   -1  'True
         Top             =   0
         Width           =   405
      End
      Begin VB.Image cmdPlay 
         Height          =   285
         Left            =   0
         Picture         =   "Form1.frx":1CD91
         Stretch         =   -1  'True
         Top             =   0
         Width           =   315
      End
      Begin VB.Image cmdBrowse 
         Height          =   420
         Left            =   0
         Picture         =   "Form1.frx":1DABE
         Stretch         =   -1  'True
         Top             =   0
         Width           =   420
      End
   End
   Begin VB.PictureBox add1600 
      AutoSize        =   -1  'True
      Height          =   600
      Left            =   0
      OLEDropMode     =   1  'Manual
      Picture         =   "Form1.frx":1F0A3
      ScaleHeight     =   540
      ScaleWidth      =   2715
      TabIndex        =   14
      Top             =   0
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.PictureBox add1280 
      AutoSize        =   -1  'True
      Height          =   660
      Left            =   0
      Picture         =   "Form1.frx":1F4C1
      ScaleHeight     =   600
      ScaleWidth      =   2460
      TabIndex        =   13
      Top             =   0
      Visible         =   0   'False
      Width           =   2520
   End
   Begin VB.PictureBox add1152 
      AutoSize        =   -1  'True
      Height          =   615
      Left            =   0
      Picture         =   "Form1.frx":1F8E9
      ScaleHeight     =   555
      ScaleWidth      =   2055
      TabIndex        =   12
      Top             =   0
      Visible         =   0   'False
      Width           =   2115
   End
   Begin VB.PictureBox add1024 
      AutoSize        =   -1  'True
      Height          =   660
      Left            =   0
      Picture         =   "Form1.frx":1FCB9
      ScaleHeight     =   600
      ScaleWidth      =   1740
      TabIndex        =   11
      Top             =   0
      Visible         =   0   'False
      Width           =   1800
   End
   Begin VB.PictureBox add800 
      AutoSize        =   -1  'True
      Height          =   630
      Left            =   0
      Picture         =   "Form1.frx":20073
      ScaleHeight     =   570
      ScaleWidth      =   1350
      TabIndex        =   10
      Top             =   0
      Visible         =   0   'False
      Width           =   1410
   End
   Begin InetCtlsObjects.Inet Inet1 
      Left            =   2520
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
   End
   Begin VB.Timer timDel 
      Enabled         =   0   'False
      Interval        =   20
      Left            =   2640
      Top             =   0
   End
   Begin VB.Timer timHand 
      Interval        =   500
      Left            =   2640
      Top             =   0
   End
   Begin VB.Timer timCur 
      Interval        =   1
      Left            =   2640
      Top             =   0
   End
   Begin VB.Timer timHiding 
      Enabled         =   0   'False
      Interval        =   500
      Left            =   2640
      Top             =   0
   End
   Begin VB.FileListBox File1 
      Height          =   480
      Left            =   2520
      TabIndex        =   0
      Top             =   0
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Timer timPlay 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   2640
      Top             =   0
   End
   Begin VB.Timer timConnected 
      Interval        =   1
      Left            =   2640
      Top             =   0
   End
   Begin MSComDlg.CommonDialog cdl 
      Left            =   2520
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.PictureBox pic1280 
      AutoSize        =   -1  'True
      Height          =   15420
      Left            =   0
      Picture         =   "Form1.frx":203F7
      ScaleHeight     =   15360
      ScaleWidth      =   3000
      TabIndex        =   2
      Top             =   0
      Visible         =   0   'False
      Width           =   3060
   End
   Begin VB.PictureBox pic800 
      AutoSize        =   -1  'True
      Height          =   9060
      Left            =   0
      Picture         =   "Form1.frx":369E0
      ScaleHeight     =   9000
      ScaleWidth      =   1755
      TabIndex        =   6
      Top             =   0
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.PictureBox pic1024 
      AutoSize        =   -1  'True
      Height          =   11580
      Left            =   0
      Picture         =   "Form1.frx":423D1
      ScaleHeight     =   11520
      ScaleWidth      =   2250
      TabIndex        =   7
      Top             =   0
      Visible         =   0   'False
      Width           =   2310
   End
   Begin VB.PictureBox pic1152 
      AutoSize        =   -1  'True
      Height          =   13020
      Left            =   0
      Picture         =   "Form1.frx":52229
      ScaleHeight     =   12960
      ScaleWidth      =   2535
      TabIndex        =   8
      Top             =   0
      Visible         =   0   'False
      Width           =   2595
   End
   Begin VB.PictureBox pic1600 
      AutoSize        =   -1  'True
      Height          =   18060
      Left            =   0
      Picture         =   "Form1.frx":6567B
      ScaleHeight     =   18000
      ScaleWidth      =   3510
      TabIndex        =   9
      Top             =   0
      Visible         =   0   'False
      Width           =   3570
   End
   Begin VB.Line Line2 
      BorderColor     =   &H00FFFFFF&
      Index           =   0
      X1              =   2040
      X2              =   120
      Y1              =   5800
      Y2              =   5800
   End
   Begin VB.Line Line3 
      BorderColor     =   &H00808080&
      Index           =   0
      X1              =   2040
      X2              =   120
      Y1              =   5760
      Y2              =   5760
   End
   Begin VB.Line Line2 
      BorderColor     =   &H00FFFFFF&
      Index           =   1
      X1              =   2040
      X2              =   120
      Y1              =   5000
      Y2              =   5000
   End
   Begin VB.Line Line3 
      BorderColor     =   &H00808080&
      Index           =   1
      X1              =   2040
      X2              =   120
      Y1              =   5040
      Y2              =   5040
   End
   Begin VB.Menu mnuShort 
      Caption         =   "Shortcut"
      Visible         =   0   'False
      Begin VB.Menu mnuNew 
         Caption         =   "Add new shortcut"
      End
      Begin VB.Menu mnuDel 
         Caption         =   "Delete shortcut"
      End
   End
   Begin VB.Menu mnuMain 
      Caption         =   "Main"
      Visible         =   0   'False
      Begin VB.Menu mnuHide 
         Caption         =   "Auto hide"
      End
      Begin VB.Menu mnuDash1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "About"
      End
      Begin VB.Menu mnuDash2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Index As Integer, picI As Integer, SecondAngle As Integer, LastSecond As Integer, LastMinute As Integer, LastHour As Integer, BrWidth As Integer, BrHeight As Integer
Dim MinuteAngle As Integer, HourAngle As Integer, counter As Integer, ProperHour As Integer, Going As Integer
Dim Changed As Boolean, Saved As Boolean, blHide As Boolean, Visi As Boolean, Hide2 As Boolean, IsPlaying As Boolean, Hiding As Boolean
Dim lngLeftWall As Long, lngTopWall As Long, lngLeftPlay As Long, lngTopPlay As Long, lngLeftBrowse As Long, lngTopBrowse As Long
Dim lngLeftAlarm As Long, lngTopAlarm As Long, lngLeftNext As Long, lngTopNext As Long, lngLeftPer As Long, lngTopPer As Long

Private Sub cmdAlarm_Click()
    frmAlarm.Width = Me.Width
    'frmAlarm.Height = Screen.Height
    frmAlarm.Left = Screen.Width - Me.Width
    frmAlarm.Top = Screen.Height + frmAlarm.Height
    frmAlarm.Show , Me
    Do Until frmAlarm.Top = Screen.Height - (frmAlarm.Height) '+ cmdAlarm.Height)
        frmAlarm.Top = frmAlarm.Top - 1
        DoEvents
    Loop
End Sub

Private Sub cmdAlarm_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdAlarm.Left = cmdAlarm.Left + 50
    cmdAlarm.Top = cmdAlarm.Top + 50
End Sub

Private Sub cmdAlarm_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdAlarm.Left = lngLeftAlarm
    cmdAlarm.Top = lngTopAlarm
End Sub

Private Sub cmdBrowse_Click()
    On Error Resume Next
    Dim strFile As String
    Dim i As Integer
    cdl.Filter = "All Picture Formats (*.jpg , *.bmp , *.gif)|*.jpg;*.bmp;*.gif|"
    cdl.DialogTitle = "Select a picture"
    cdl.ShowOpen
    strFile = cdl.FileName
    imgPic.Picture = LoadPicture(strFile)
    File1.Path = Replace(cdl.FileName, cdl.FileTitle, "")
    If imgPic.Width > BrWidth Then
        imgPic.Stretch = True
        imgPic.Width = BrWidth
    End If
    If imgPic.Height > BrHeight Then
        imgPic.Stretch = True
        imgPic.Height = BrHeight
    End If
    If imgPic.Width > BrWidth And imgPic.Height > BrHeight Then
        imgPic.Stretch = True
        imgPic.Width = BrWidth
        imgPic.Height = BrHeight
    End If
    
    
    For i = 0 To File1.ListCount
            If cdl.FileTitle = File1.List(i) Then
                File1.ListIndex = i
                Exit For
            End If
        Next i
End Sub


Private Sub cmdBrowse_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdBrowse.Left = cmdBrowse.Left + 50
    cmdBrowse.Top = cmdBrowse.Top + 50
End Sub


Private Sub cmdBrowse_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdBrowse.Left = lngLeftBrowse
    cmdBrowse.Top = lngTopBrowse
End Sub


Private Sub cmdnext_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    On Error Resume Next
    Dim i As Integer
    Going = Going + 1
    'MsgBox picShortcut.Count
    cmdNext.Left = cmdNext.Left + 50
    cmdNext.Top = cmdNext.Top + 50
    For i = 1 To Index
        picShortcut(i).Left = picShortcut(i).Left - picShortcut(0).Height
    Next
End Sub

Private Sub cmdNext_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdNext.Left = lngLeftNext
    cmdNext.Top = lngTopNext
End Sub


Private Sub cmdPer_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    On Error Resume Next
    Dim i As Integer
    'MsgBox picShortcut.Count
    cmdPer.Left = cmdPer.Left + 50
    cmdPer.Top = cmdPer.Top + 50
    
    If Going > 0 Then
        Going = Going - 1
        For i = 1 To Index
            picShortcut(i).Left = picShortcut(i).Left + picShortcut(0).Height
        Next
    End If
   ' MsgBox Going
    
End Sub

Private Sub cmdPer_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdPer.Left = lngLeftPer
    cmdPer.Top = lngTopPer
End Sub


Private Sub cmdPlay_Click()
    IsPlaying = Not IsPlaying
    timPlay.Enabled = True
End Sub

Private Sub cmdPlay_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdPlay.Left = cmdPlay.Left + 50
    cmdPlay.Top = cmdPlay.Top + 50
End Sub


Private Sub cmdPlay_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    cmdPlay.Left = lngLeftPlay
    cmdPlay.Top = lngTopPlay
End Sub

Private Sub Form_Load()
        On Error Resume Next
        Dim Dev As DEVMODE
        Dim Res As Integer
        

        EnumDisplaySettings 0, ENUM_CURRENT_SETTINGS, Dev
        Res = Dev.dmPelsWidth
        
        
        DOMainSettings
         DOHands Res, True
     
End Sub

Private Sub imgPic_Click()
    frmPicture.imgPic.Picture = imgPic.Picture
    frmPicture.imgPic.Left = ((Screen.Width - frmPicture.imgPic.Width) / 2)
    frmPicture.imgPic.Top = ((Screen.Height - frmPicture.imgPic.Height) / 2)
    frmPicture.Show vbModal, Me
End Sub

Private Sub imgWall_Click()
    On Error Resume Next
    Dim Wall As Long
    Dim Path As String
   If imgPic.Picture <> 0 Then
        SavePicture imgPic.Picture, App.Path & "\Advanced Taskbar.bmp"
        Path = App.Path & "\Advanced Taskbar.bmp"
        Wall = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0&, ByVal Path, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
    End If
    If Wall = 0 Then MsgBox "Not changed!"
End Sub

Private Sub imgWall_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    imgWall.Left = imgWall.Left + 50
    imgWall.Top = imgWall.Top + 50
End Sub


Private Sub imgWall_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    imgWall.Left = lngLeftWall
    imgWall.Top = lngTopWall
End Sub

Private Sub mnuAbout_Click()
    On Error Resume Next
    DoEvents
    frmAbout.Show vbModal, Me
End Sub

Private Sub mnuDel_Click()
   ' On Error GoTo MsG
   timDel.Enabled = True
    
    Exit Sub
MSG:
    
End Sub

Private Sub mnuExit_Click()
    End
End Sub

Private Sub mnuHide_Click()
    mnuHide.Checked = Not mnuHide.Checked
    blHide = mnuHide.Checked
    SaveSetting App.Title, "MainSetting", "Main Popupmenu", blHide
    
End Sub

Private Sub mnuNew_Click()
   On Error Resume Next
    Dim Icon As Long
    Dim File As String
    With cdl
        .DialogTitle = "Select a file"
        .Filter = "Executable Files (*.exe)|*.exe|)"
        .ShowOpen
        Icon = ExtractIcon(Me.hWnd, .FileName, 0)
        File = .FileName
    End With
    If File <> "" Then Index = Index + 1
    'index = 1
    Load picShortcut(Index)

    picShortcut(Index).Left = picShortcut(Index).Width * Index + (picShortcut(0).Left) + (1 * 50) - 50
    'MsgBox picShortcut(index).Width
    picShortcut(Index).Visible = True
    DrawIcon picShortcut(Index).hDC, 0, 0, Icon
    picShortcut(Index).ToolTipText = cdl.FileTitle
    SaveSetting App.Title, "SaveShortCuts", "IconBrowsing" & Index, File
    SaveSetting App.Title, "SaveShortCuts", "IconToolTipText" & Index, cdl.FileTitle
    SaveSetting App.Title, "SaveShortCuts", "IconCount", Index
End Sub

Private Sub picContain_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = vbRightButton Then
        mnuDel.Visible = False
        PopupMenu mnuShort
    End If
End Sub

Private Sub picMain_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = vbRightButton Then
        Me.PopupMenu mnuMain
    End If
End Sub

Private Sub picShortcut_Click(Index As Integer)
    On Error GoTo MSG
    Dim strFile As String
    strFile = GetSetting(App.Title, "SaveShortCuts", "IconBrowsing" & Index)
    Shell strFile, vbNormalFocus
    Exit Sub
MSG:
    MsgBox Err.Description
End Sub

Private Sub picShortcut_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = vbRightButton Then
        mnuDel.Visible = True
        PopupMenu mnuShort
        picI = Index
    End If
End Sub

Private Sub timConnected_Timer()
    Dim strInfo As String
    If IsConnected = True Then
        strInfo = Inet1.OpenURL("http://molisoftprograms.tripod.com/updates/av1.html")
        'MsgBox strInfo
        If InStr(strInfo, "www.") > 0 And InStr(strInfo, "UPDATE IT IN GEOCITIES") > 0 Then
            MsgBox "New updates are ready to download!"
            Shell "Explorer http://www.geocities.com/m_alian14"
        ElseIf InStr(strInfo, ".com") > 0 And InStr(strInfo, "UPDATE IT IN TRIPOD") > 0 Then
            MsgBox "New updates are ready to download!"
            Shell "Explorer http://m_alian.tripod.com"
        End If
        timConnected.Enabled = False
    End If
End Sub

Private Sub timCur_Timer()
    Dim Point As POINTAPI
    Dim Setting As Integer
    Dim Dev As DEVMODE
    
    EnumDisplaySettings 0, ENUM_CURRENT_SETTINGS, Dev
    
    Setting = Dev.dmPelsWidth
    GetCursorPos Point
    
    If blHide = True Then
        If Point.X >= (Setting - 3) Then
            If Hiding = False Then
                Do Until Me.Left = (Dev.dmPelsWidth * 15) - Me.Width
                    Hide2 = False
                    Me.Left = Me.Left - 1
                    frmAlarm.Left = frmAlarm.Left - 1
                    DoEvents
                Loop
                Hide2 = False
            End If
        ElseIf Point.X <= ((Dev.dmPelsWidth) - Me.Width / 15) Then
            timHiding.Enabled = True
            Hide2 = True
        End If
    End If
    
End Sub

Private Sub timDel_Timer()
    On Error GoTo iIndex
    Dim i As Integer
    Dim File2 As String
    Dim Title2 As String
    Dim iiIndex As Integer
    Unload picShortcut(picI)
    
    For i = picI + 1 To Index
        File2 = GetSetting(App.Title, "SaveShortCuts", "IconBrowsing" & i)
        SaveSetting App.Title, "SaveShortCuts", "IconBrowsing" & i - 1, File2
        Title2 = GetSetting(App.Title, "SaveShortCuts", "IconToolTipText" & i)
        SaveSetting App.Title, "SaveShortCuts", "IconToolTipText" & i - 1, Title2
    Next i
    Index = Index - 1
    iiIndex = Index + 1
    SaveSetting App.Title, "SaveShortCuts", "IconCount", Index
    For i = picI + 1 To iiIndex
        picShortcut(i).Left = picShortcut(i).Left - picShortcut(0).Height
    Next
    timDel.Enabled = False
    Exit Sub
iIndex:
     iiIndex = iiIndex + 1
End Sub

Private Sub timHand_Timer()
    DoEvents
    Dim Dev As DEVMODE
    Dim Res As Integer
    EnumDisplaySettings 0, ENUM_CURRENT_SETTINGS, Dev
    Res = Dev.dmPelsWidth
    frmAlarm.lblTime.Caption = Time$
    DOHands Res, False
    
    'Resizing for changing the reselousoin
     If Dev.dmPelsHeight <> Resol.intHeight And Dev.dmPelsWidth <> Resol.intWidth Then
        Resol.intHeight = Dev.dmPelsHeight
        Resol.intWidth = Dev.dmPelsWidth
        If Dev.dmPelsWidth = 1280 Then picMain.Picture = pic1280.Picture
        If Dev.dmPelsWidth = 1024 Then picMain.Picture = pic1024.Picture
        If Dev.dmPelsWidth = 800 Then picMain.Picture = pic800.Picture
        If Dev.dmPelsWidth = 1600 Then picMain.Picture = pic1600.Picture
        DOMainSettings
        DOHands Res, True
    End If
    
End Sub

Private Sub timHiding_Timer()
    Dim Dev As DEVMODE
    
    EnumDisplaySettings 0, ENUM_CURRENT_SETTINGS, Dev
    timHiding.Enabled = False
    
    If Hide2 = True Then
           Hiding = True
            Do Until Me.Left = (Dev.dmPelsWidth * 15) - 50
                Me.Left = Me.Left + 1
                frmAlarm.Left = frmAlarm.Left + 1
                DoEvents
            Loop
             
    End If
    Hiding = False
End Sub

Private Sub timPlay_Timer()
    On Error GoTo MSG
    If imgPic.Picture <> 0 Then
        If IsPlaying Then
            cmdPlay.ToolTipText = "Pause Show Slide"
            File1.ListIndex = File1.ListIndex + 1
            imgPic.Stretch = True
            imgPic.Picture = LoadPicture(File1.FileName)
        ElseIf IsPlaying = False Then
            cmdPlay.ToolTipText = "Play Show Slide"
            timPlay.Enabled = False
        End If
    End If
    Exit Sub
MSG:
    timPlay.Enabled = False
    IsPlaying = False
    
End Sub


Private Sub DOMainSettings()
    On Error Resume Next
    Dim i As Integer
    Dim File As String
    Dim Icon As Long
    Dim Title As String
    Dim Dev As DEVMODE
    Dim PicRGN As Long
    Dim IShort As Integer
    
    EnumDisplaySettings 0, ENUM_CURRENT_SETTINGS, Dev
    
    Going = 0
    App.TaskVisible = False
    Index = GetSetting(App.Title, "SaveShortCuts", "IconCount")
    cmdPlay.ToolTipText = "Play Show Slide"
    
    
    
    Resol.intHeight = Dev.dmPelsHeight
    Resol.intWidth = Dev.dmPelsWidth
    DoEvents
     
    File1.Pattern = ("*.bmp;*.jpg;*.gif")
    
    'Load seting
    blHide = GetSetting(App.Title, "MainSetting", "Main Popupmenu")
    mnuHide.Checked = blHide
    
    'Load icons
    For i = 1 To Index
        File = GetSetting(App.Title, "SaveShortCuts", "IconBrowsing" & i)
        Title = GetSetting(App.Title, "SaveShortCuts", "IconToolTipText" & i)
        Icon = ExtractIcon(Me.hWnd, File, 0)
        DoEvents
        Load picShortcut(i)
        DrawIcon picShortcut(i).hDC, 0, 0, Icon
        picShortcut(i).Left = picShortcut(0).Width * i + (picShortcut(0).Left) + (i * 50) - 50
        picShortcut(i).ToolTipText = Title
        picShortcut(i).Visible = True
        
'        You can let it be for no background for the icons......
        'picShortcut(i).ScaleMode = vbPixels
'        picShortcut(i).AutoRedraw = True
        'picShortcut(i).AutoSize = True
'
        'PicRGN = MakeRegion(picShortcut(i))
'        SetWindowRgn picShortcut(i).hWnd, PicRGN, True
    Next i
    
    
    If Dev.dmPelsWidth = 1280 Then
        picMain.Picture = pic1280.Picture
        picContain.Picture = add1280.Picture
        imgPic.Move 360, 4200, 2235, 2055
        cmdBrowse.Move 360, 6720, 540, 540
        cmdPlay.Move 1080, 6720, 480, 525
        imgWall.Move 1800, 6720, 525, 585
        cmdPer.Move 0, 7500, 375, 405
        picContain.Move 420, 7500, 2175, 475
        cmdNext.Move 2550, 7500, 375, 375
        cmdAlarm.Move 1800, 13680, 795, 810
        
    ElseIf Dev.dmPelsWidth = 800 Then
        picMain.Picture = pic800.Picture
        picContain.Picture = add800.Picture
        imgPic.Move 240, 2520, 1275, 1095
        cmdBrowse.Move 120, 3840, 420, 420
        cmdPlay.Move 600, 3840, 435, 405
        imgWall.Move 1080, 3840, 405, 435
        cmdPer.Move 0, 4400, 255, 285
        picContain.Move 225, 4290, 1215, 475
        cmdNext.Move 1440, 4400, 275, 275
        cmdAlarm.Move 960, 7920, 555, 570
        
    ElseIf Dev.dmPelsWidth = 1024 Then
        picMain.Picture = pic1024.Picture
        picContain.Picture = add1024.Picture
        imgPic.Move 240, 3120, 1755, 1575
        cmdBrowse.Move 150, 4920, 540, 540
        cmdPlay.Move 750, 4920, 555, 645
        imgWall.Move 1400, 4920, 525, 555
        cmdPer.Move 0, 5730, 325, 325
        picContain.Move 285, 5640, 1695, 475
        cmdNext.Move 1920, 5730, 350, 350
        cmdAlarm.Move 1200, 10200, 675, 690
        
    ElseIf Dev.dmPelsWidth = 1152 Then
        picMain.Picture = pic1152.Picture
        picContain.Picture = add1152.Picture
        imgPic.Move 240, 3600, 1995, 1695
        cmdBrowse.Move 200, 5600, 540, 540
        cmdPlay.Move 880, 5570, 555, 645
        imgWall.Move 1600, 5600, 525, 555
        cmdPer.Move 0, 6300, 405, 450
        picContain.Move 350, 6240, 1815, 475
        cmdNext.Move 2160, 6300, 405, 405
        cmdAlarm.Move 1320, 11400, 795, 810
        
    ElseIf Dev.dmPelsWidth = 1600 Then
        picMain.Picture = pic1600.Picture
        picContain.Picture = add1600.Picture
        imgPic.Move 360, 4920, 2715, 2415
        cmdBrowse.Move 240, 7920, 780, 780
        cmdPlay.Move 1200, 7920, 675, 765
        imgWall.Move 2160, 7800, 645, 795
        cmdPer.Move -75, 9000, 525, 570
        picContain.Move 375, 9000, 2535, 475
        cmdNext.Move 3000, 9000, 525, 525
        cmdAlarm.Move 1920, 15960, 1035, 1005
        
    End If
    
    BrWidth = imgPic.Width
    BrHeight = imgPic.Height
    lngLeftWall = imgWall.Left
    lngTopWall = imgWall.Top
    lngLeftPlay = cmdPlay.Left
    lngTopPlay = cmdPlay.Top
    lngLeftBrowse = cmdBrowse.Left
    lngTopBrowse = cmdBrowse.Top
    lngLeftAlarm = cmdAlarm.Left
    lngTopAlarm = cmdAlarm.Top
    lngLeftNext = cmdNext.Left
    lngTopNext = cmdNext.Top
    lngLeftPer = cmdPer.Left
    lngTopPer = cmdPer.Top
    
    Me.Width = picMain.Width
    Me.Height = picMain.Height
    Me.Left = (Dev.dmPelsWidth * 15) - Me.Width
    Me.Top = 0
End Sub

Sub DOHands(Resoul As Integer, DoChange As Boolean)
    Dim intX As Integer
    Dim intY As Integer
    Dim SSec As Integer
    Dim SMin As Integer
    Dim SHour As Integer
    
    If Resoul = 1600 Then
        intX = 800
        intY = 900
       SSec = 1200
        SMin = 1000
        SHour = 650
    ElseIf Resoul = 1280 Then
        intX = 532.8
        intY = 630
        SSec = 1000
        SMin = 900
        SHour = 600
     ElseIf Resoul = 1024 Then
        intX = 157.78
        intY = 232.5
       SSec = 750
        SMin = 600
        SHour = 400
    ElseIf Resoul = 1152 Then
        intX = 300
        intY = 380
       SSec = 800
        SMin = 700
        SHour = 450
    ElseIf Resoul = 800 Then
        intX = -90
        intY = -27
       SSec = 600
        SMin = 475
        SHour = 300
    End If
    
    If (Second(Time) <> LastSecond) Or DoChange = True Then

        SecondAngle = (Second(Time) * 6) - 90
        lnSecond.X1 = Centre - (Cos(SecondAngle * 3.14 / 180) * 1) + intX
        lnSecond.Y1 = Centre - (Sin(SecondAngle * 3.14 / 180) * 1) + intY
        lnSecond.X2 = Centre + (Cos(SecondAngle * 3.14 / 180) * SSec) + intX
        lnSecond.Y2 = Centre + (Sin(SecondAngle * 3.14 / 180) * SSec) + intY
        LastSecond = Second(Time)
        'change minute hand
        If LastMinute <> Minute(Time) Or DoChange = True Then
            MinuteAngle = (Minute(Time) * 6) - 90
            lnMinute.X1 = Centre - (Cos(MinuteAngle * 3.14 / 180) * 50) + intX
            lnMinute.Y1 = Centre - (Sin(MinuteAngle * 3.14 / 180) * 50) + intY
            lnMinute.X2 = Centre + (Cos(MinuteAngle * 3.14 / 180) * SMin) + intX
            lnMinute.Y2 = Centre + (Sin(MinuteAngle * 3.14 / 180) * SMin) + intY
            LastMinute = Minute(Time)
    
            'change hour
            If Hour(Time) > 12 Then
                ProperHour = Hour(Time) - 12
            Else
                ProperHour = Hour(Time)
            End If
            HourAngle = ((ProperHour * 30) - 90) + (Minute(Time) / 2)
            lnHour.X1 = Centre - (Cos(HourAngle * 3.14 / 180) * 50) + intX
            lnHour.Y1 = Centre - (Sin(HourAngle * 3.14 / 180) * 50) + intY
            lnHour.X2 = Centre + (Cos(HourAngle * 3.14 / 180) * SHour) + intX
            lnHour.Y2 = Centre + (Sin(HourAngle * 3.14 / 180) * SHour) + intY
            LastHour = Hour(Time)
    
        End If
    End If

End Sub
