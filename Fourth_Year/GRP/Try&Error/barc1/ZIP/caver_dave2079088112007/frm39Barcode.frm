VERSION 5.00
Begin VB.Form frm39Barcode 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " CREATE A 3 of 9 BARCODE"
   ClientHeight    =   6660
   ClientLeft      =   2865
   ClientTop       =   2670
   ClientWidth     =   11295
   Icon            =   "frm39Barcode.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6660
   ScaleWidth      =   11295
   Begin VB.CommandButton Command5 
      Height          =   615
      Left            =   7920
      Picture         =   "frm39Barcode.frx":0EFA
      Style           =   1  'Graphical
      TabIndex        =   15
      ToolTipText     =   "MINIMISE ME"
      Top             =   5760
      Width           =   615
   End
   Begin VB.CommandButton Command7 
      Height          =   615
      Left            =   9600
      Picture         =   "frm39Barcode.frx":104C
      Style           =   1  'Graphical
      TabIndex        =   14
      ToolTipText     =   "SHOW HELP"
      Top             =   5760
      Width           =   615
   End
   Begin VB.CommandButton Command6 
      Height          =   615
      Left            =   8760
      Picture         =   "frm39Barcode.frx":1D16
      Style           =   1  'Graphical
      TabIndex        =   13
      ToolTipText     =   "SHOW ABOUT AND LINK"
      Top             =   5760
      Width           =   615
   End
   Begin VB.CommandButton Command4 
      Height          =   615
      Left            =   10440
      Picture         =   "frm39Barcode.frx":29E0
      Style           =   1  'Graphical
      TabIndex        =   12
      ToolTipText     =   "EXIT THIS APPLICATION:- BY THE NEAREST DOOR!"
      Top             =   5760
      Width           =   615
   End
   Begin VB.CommandButton Command3 
      Height          =   615
      Left            =   5160
      Picture         =   "frm39Barcode.frx":36AA
      Style           =   1  'Graphical
      TabIndex        =   11
      ToolTipText     =   "CLEAR AND RESET ALL"
      Top             =   5760
      Width           =   615
   End
   Begin VB.CommandButton Command2 
      Height          =   615
      Left            =   4440
      Picture         =   "frm39Barcode.frx":4374
      Style           =   1  'Graphical
      TabIndex        =   10
      ToolTipText     =   "PREVIEW CURRENT BARCODE"
      Top             =   5760
      Width           =   615
   End
   Begin VB.Frame Frame2 
      Caption         =   "Make Barcode"
      Height          =   1095
      Left            =   240
      TabIndex        =   5
      Top             =   4320
      Width           =   10815
      Begin VB.CommandButton Command1 
         Height          =   615
         Left            =   120
         Picture         =   "frm39Barcode.frx":503E
         Style           =   1  'Graphical
         TabIndex        =   7
         ToolTipText     =   "CREATE BARCODE"
         Top             =   270
         Width           =   1095
      End
      Begin VB.TextBox Text1 
         Height          =   285
         Left            =   1335
         TabIndex        =   6
         Top             =   600
         Width           =   6480
      End
      Begin VB.Label Label4 
         Caption         =   "Enter Text For Barcode Here (Max 20 Characters)"
         Height          =   300
         Left            =   1335
         TabIndex        =   9
         Top             =   240
         Width           =   6240
      End
      Begin VB.Label Label1 
         BorderStyle     =   1  'Fixed Single
         Height          =   285
         Left            =   7920
         TabIndex        =   8
         Top             =   600
         Width           =   2655
      End
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   3975
      Left            =   240
      ScaleHeight     =   3915
      ScaleWidth      =   10755
      TabIndex        =   0
      Top             =   240
      Width           =   10815
   End
   Begin VB.Frame Frame1 
      Caption         =   "Picture Properties"
      Height          =   855
      Left            =   240
      TabIndex        =   2
      Top             =   5640
      Width           =   4095
      Begin VB.Label Label2 
         BorderStyle     =   1  'Fixed Single
         Height          =   285
         Left            =   120
         TabIndex        =   4
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label Label3 
         BorderStyle     =   1  'Fixed Single
         Height          =   285
         Left            =   2040
         TabIndex        =   3
         Top             =   360
         Width           =   1815
      End
   End
   Begin VB.Label Node 
      BackColor       =   &H00C00000&
      Caption         =   "Label2"
      Height          =   75
      Index           =   0
      Left            =   75
      TabIndex        =   1
      Top             =   120
      Visible         =   0   'False
      Width           =   75
   End
End
Attribute VB_Name = "frm39Barcode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long

Private Const WM_PAINT = &HF
Private Const WM_PRINT = &H317
Private Const PRF_CLIENT = &H4&    ' Draw the window's client area
Private Const PRF_CHILDREN = &H10& ' Draw all visible child windows
Private Const PRF_OWNED = &H20&    ' Draw all owned windows

Dim i As Integer

Const myerrfilepath = 53
Const errfilepath = 75
'    Const rterror = 68

Private Sub Command1_Click()
Text1.Text = UCase$(Text1) ' convert all entered text to capitals

Picture1.Cls ' clear the box on each click instead of overwriting

Picture1.CurrentX = 567 ' barcode
Picture1.CurrentY = 567 '        position

Picture1.Font = "Free 3 of 9 Extended"
Picture1.FontSize = 45
Picture1.Print Text1.Text ' barcode text

Picture1.CurrentX = 567  ' postion  the    below   barcode
Picture1.CurrentY = 1400 '        of   text     the
Picture1.FontSize = 15
Picture1.FontName = "Courier"
Picture1.FontSize = 15
'Picture1.Print Spc(5); ' add additional spaces if required
Picture1.Print Text1.Text


Text1.Text = ""
Text1.SetFocus
End Sub

Private Sub Command1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command1.MousePointer = 99
Command1.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command2_Click()
'*******************************************************
'*          show the card preview window               *
'*        minimises the main design window             *
'*******************************************************
Dim rv As Long

frmPreview.Show
Me.WindowState = vbMinimized
'* this came straight from ms technet!
frmPreview.Picture1.AutoRedraw = True
rv = SendMessage(Picture1.hwnd, WM_PAINT, frmPreview.Picture1.hDC, 0)
rv = SendMessage(Picture1.hwnd, WM_PRINT, frmPreview.Picture1.hDC, PRF_CHILDREN + PRF_CLIENT + PRF_OWNED)
frmPreview.Picture1.Picture = frmPreview.Picture1.Image
frmPreview.Picture1.AutoRedraw = False
End Sub

Private Sub Command2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command2.MousePointer = 99
Command2.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command3_Click()
Picture1.Width = 10815
Picture1.Height = 3975
 HideNodes
'Label2.Caption = " Width =  " & Picture1.Width
'Label3.Caption = " Height = " & Picture1.Height
Label2.Caption = " Width =  " & Round((Picture1.Width / 567), 2) & " cm"
Label3.Caption = " Height = " & Round((Picture1.Height / 567), 2) & " cm"

Picture1.Cls

End Sub

Private Sub Command3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command3.MousePointer = 99
Command3.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command4_Click()
Unload Me
Unload frmPreview
Unload frmLink
End Sub

Private Sub Command4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command4.MousePointer = 99
Command4.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command5_Click()
Me.WindowState = vbMinimized
End Sub

Private Sub Command5_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command5.MousePointer = 99
Command5.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command6_Click()
frmLink.Show
End Sub

Private Sub Command6_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command6.MousePointer = 99
Command6.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command7_Click()
frm39BarcodeHelp.Show
End Sub

Private Sub Command7_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command7.MousePointer = 99
Command7.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Form_Load()
 If Node.Count = 1 Then
        For i = 1 To 7
            Load Node(i)
        Next
    End If
Label1.Caption = " No of Characters = " & "0"
Text1.MaxLength = 20
'Label2.Caption = " Width =  " & (Picture1.Width / 567) & " cm"
'Label3.Caption = " Height = " & (Picture1.Height / 567) & " cm"
Label2.Caption = " Width =  " & Round((Picture1.Width / 567), 2) & " cm"
Label3.Caption = " Height = " & Round((Picture1.Height / 567), 2) & " cm"

End Sub

Private Sub Text1_Change()
Label1.Caption = " No of Characters = " & Len(Text1.Text) '= UCase$(Text1)
'Text2.Text = UCase(Text1.Text)
End Sub
Private Sub Picture1_DblClick()
 For i = 0 To 7
        Node(i).Visible = False
    Next
End Sub
Private Sub HideNodes()
    For i = 0 To 7
        Node(i).Visible = False
    Next
End Sub
Private Sub SizeObject(NodeIndex As Integer, X As Single, Y As Single)
    On Error Resume Next
    
    With Picture1
        Select Case NodeIndex
            Case 0
                .Width = .Width + (.Left - X)
                .Height = .Height + (.Top - Y)
                .Left = X
                .Top = Y
            Case 1
                .Width = .Width + (.Left - X)
                .Left = X
            Case 2
                .Width = (.Left - X) + .Width
                .Height = Y - .Top
                .Left = X
            Case 3
                .Height = .Height + .Top - Y
                .Top = Y
            Case 4
                .Height = Y - .Top
            Case 5
                .Width = X - .Left
                .Height = .Height + .Top - Y
                .Top = Y
            Case 6
                .Width = X - .Left
            Case 7
                .Width = X - .Left
                .Height = Y - .Top
        End Select
    End With
Label2.Caption = " Width =  " & Round((Picture1.Width / 567), 2) & " cm"
Label3.Caption = " Height = " & Round((Picture1.Height / 567), 2) & " cm"
    'KeyEdit = "Move"
End Sub
Private Sub SetNodes(SelectedControl As Control)
    With SelectedControl
        For i = 0 To 7
            Select Case i
                'Left Top
                Case 0
                    Node(i).Left = .Left - Node(i).Width
                    Node(i).Top = .Top - Node(i).Height
                'Left center
                Case 1
                    Node(i).Left = .Left - Node(i).Width
                    Node(i).Top = .Top + ((.Height - Node(i).Height) / 2)
                'Left bottom
                Case 2
                    Node(i).Left = .Left - Node(i).Width
                    Node(i).Top = .Top + .Height
                'Center Top
                Case 3
                    Node(i).Left = .Left + ((.Width + Node(i).Width) / 2)
                    Node(i).Top = .Top - Node(i).Height
                'Center Bottom
                Case 4
                    Node(i).Left = .Left + ((.Width + Node(i).Width) / 2)
                    Node(i).Top = .Top + .Height
                 'Right Top
                Case 5
                    Node(i).Left = .Left + .Width
                    Node(i).Top = .Top - Node(i).Height
                'Right Center
                Case 6
                    Node(i).Left = .Left + .Width
                    Node(i).Top = .Top + ((.Height - Node(i).Height) / 2)
                'Right Bottom
                Case 7
                    Node(i).Left = .Left + .Width
                    Node(i).Top = .Top + .Height
            End Select
            Node(i).Visible = True
        Next
    End With
End Sub

Private Sub Form_DragDrop(Source As Control, X As Single, Y As Single)
    SetNodes Picture1
End Sub

Private Sub Form_DragOver(Source As Control, X As Single, Y As Single, State As Integer)
    SizeObject Source.Index, X, Y
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    MousePointer = 0
End Sub

Private Sub Picture1_Click()
    If Node.Count = 1 Then
        For i = 1 To 7
            Load Node(i)
        Next
    End If
    SetNodes Picture1
End Sub

Private Sub Picture1_DragDrop(Source As Control, X As Single, Y As Single)
    SetNodes Picture1
End Sub

Private Sub Picture1_DragOver(Source As Control, X As Single, Y As Single, State As Integer)
     'SizeObject Source.Index, X, Y
    With Picture1
        Select Case Source.Index
            Case 0
                .Top = .Top + Y
                .Left = .Left + X
                .Width = .Width - X
                .Height = .Height - Y
            Case 1
                .Left = .Left + X
                .Width = .Width - X
            Case 2
                .Width = .Width - X
                .Height = Y
                .Left = .Left + X
            Case 3
                .Height = .Height - Y
                .Top = .Top + Y
            Case 4
                .Height = Y
            Case 5
                .Width = X
                .Height = .Height - Y
                .Top = .Top + Y
            Case 6
                .Width = X
            Case 7
                .Width = X
                .Height = Y
        End Select
    End With
End Sub

Private Sub Picture1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    MousePointer = 0
End Sub

Private Sub node_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   HideNodes
   Node(Index).Drag
End Sub

Private Sub node_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Select Case Index
        Case 0, 7
            MousePointer = 8
        Case 1, 6
            MousePointer = 9
        Case 2, 5
            MousePointer = 6
        Case 3, 4
            MousePointer = 7
    End Select
End Sub
