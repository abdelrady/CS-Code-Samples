VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.2#0"; "COMCTL32.OCX"
Begin VB.Form frmPreview 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Print Preview"
   ClientHeight    =   4035
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   4740
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4035
   ScaleWidth      =   4740
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin ComctlLib.TabStrip tabPreview 
      Height          =   315
      Left            =   180
      TabIndex        =   11
      Top             =   3600
      Width           =   4275
      _ExtentX        =   7541
      _ExtentY        =   556
      Style           =   1
      _Version        =   327682
      BeginProperty Tabs {0713E432-850A-101B-AFC0-4210102A8DA7} 
         NumTabs         =   1
         BeginProperty Tab1 {0713F341-850A-101B-AFC0-4210102A8DA7} 
            Caption         =   "Page 1"
            Key             =   ""
            Object.Tag             =   ""
            Object.ToolTipText     =   ""
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
   Begin VB.PictureBox picToolbar 
      Appearance      =   0  'Flat
      ForeColor       =   &H80000008&
      Height          =   495
      Left            =   0
      ScaleHeight     =   465
      ScaleWidth      =   4605
      TabIndex        =   5
      Top             =   0
      Width           =   4635
      Begin VB.CommandButton btnPreview 
         Appearance      =   0  'Flat
         Caption         =   "Zoom Out"
         Height          =   315
         Index           =   2
         Left            =   1680
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   60
         Width           =   975
      End
      Begin VB.CommandButton btnPreview 
         Appearance      =   0  'Flat
         Caption         =   "Zoom In"
         Height          =   315
         Index           =   1
         Left            =   960
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   60
         Width           =   735
      End
      Begin VB.CommandButton btnPreview 
         Appearance      =   0  'Flat
         Caption         =   "Print"
         Height          =   315
         Index           =   0
         Left            =   180
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   60
         Width           =   795
      End
      Begin VB.ComboBox cboPercent 
         Height          =   315
         Left            =   2640
         Style           =   2  'Dropdown List
         TabIndex        =   7
         Top             =   60
         Width           =   855
      End
      Begin VB.CommandButton cmdClose 
         Caption         =   "Close"
         Height          =   315
         Left            =   3720
         TabIndex        =   6
         Top             =   60
         Width           =   855
      End
   End
   Begin VB.PictureBox picParent 
      Height          =   2835
      Left            =   120
      ScaleHeight     =   2775
      ScaleWidth      =   4035
      TabIndex        =   0
      Top             =   600
      Width           =   4095
      Begin VB.PictureBox imgCorner 
         BorderStyle     =   0  'None
         ClipControls    =   0   'False
         Height          =   240
         Left            =   3360
         ScaleHeight     =   240
         ScaleWidth      =   240
         TabIndex        =   4
         Top             =   2340
         Visible         =   0   'False
         Width           =   240
      End
      Begin VB.HScrollBar hscPreview 
         Height          =   195
         LargeChange     =   2000
         Left            =   300
         SmallChange     =   500
         TabIndex        =   2
         Top             =   2280
         Width           =   2895
      End
      Begin VB.VScrollBar vscPreview 
         Height          =   2475
         LargeChange     =   2000
         Left            =   3720
         SmallChange     =   500
         TabIndex        =   3
         Top             =   120
         Width           =   195
      End
      Begin VB.PictureBox picPreview 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   2055
         Index           =   0
         Left            =   60
         ScaleHeight     =   2055
         ScaleWidth      =   3075
         TabIndex        =   1
         Top             =   0
         Visible         =   0   'False
         Width           =   3075
      End
      Begin VB.Image picChild 
         Height          =   1875
         Left            =   720
         Stretch         =   -1  'True
         Top             =   360
         Width           =   2655
      End
   End
End
Attribute VB_Name = "frmPreview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Const lBorder = 100
Private ScalePercent As Integer
Private bLoad As Boolean

Public Sub AddPage(PageNumber As Integer)

    If PageNumber > 1 Then
        Load picPreview(PageNumber - 1)
        Set picPreview(PageNumber - 1) = Nothing
        tabPreview.Tabs.Add PageNumber, , "Page " & PageNumber
    End If
    
End Sub

Private Sub FillCboPercent()

    Dim iCount As Integer
    Dim strSearch As String
    
    With cboPercent
        For iCount = 200 To 30 Step -10
            .AddItem CStr(iCount) & "%"
        Next
        strSearch = "100%"
        .ListIndex = SendMessage(.hWnd, CB_FINDSTRING, -1, ByVal strSearch)
    End With
    
End Sub

Public Sub PictureShow()
    
    Screen.MousePointer = vbHourglass
    With picChild
        .Height = (ScalePercent / 100) * picPreview(0).Height
        .Width = (ScalePercent / 100) * picPreview(0).Width
        ResizeScrollBars
    End With
    Screen.MousePointer = vbDefault

End Sub

Private Sub PreviewPrint()

    Dim iCount, iPicCount As Integer
    
    On Error GoTo ErrHandle
    
'Setup the picture boxes for printing
    For iCount = 0 To picPreview.Count - 1
        picPreview(iCount).Picture = picPreview(iCount).Image
    Next
                
    If Printer.Copies > 0 Then
        For iCount = 1 To Printer.Copies
            Printer.Print
            For iPicCount = 0 To picPreview.Count - 1
                Printer.PaintPicture picPreview(iPicCount).Picture, 0, 0
                If iPicCount < picPreview.Count - 1 Then _
                    Printer.NewPage
            Next
            Printer.EndDoc
        Next
    End If
    
    Exit Sub
    
ErrHandle:
    Select Case Err.Number
        Case 482    'Printer error
            MsgBox "Make sure that you have a printer installed.  If a " & _
                "printer is installed, go into your printer properties " & _
                "look under the Setup tab, and make sure the ICM checkbox " & _
                "is checked and try printing again.", , "Printer Error"
            Exit Sub
        Case 32755  'Cancel was pressed
            Exit Sub
        Case Else
            MsgBox Err.Number & " " & Err.Description, , "Preview - Printing"
            Resume Next
    End Select
    
End Sub

Private Sub PreviewZoomIn()
    
    With cboPercent
        If .ListIndex - 1 >= 0 Then
            ScalePercent = ScalePercent + 10
            .ListIndex = .ListIndex - 1
        End If
    End With
    
    Exit Sub
    
ErrHandle:
    Select Case Err.Number
        Case Else
            MsgBox Err.Number & " " & Err.Description, , "Preview - Printing"
            Resume Next
    End Select

End Sub

Private Sub PreviewZoomOut()

    With cboPercent
        If .ListIndex + 1 < .ListCount Then
            ScalePercent = ScalePercent - 10
            .ListIndex = .ListIndex + 1
        End If
    End With
    
    Exit Sub
    
ErrHandle:
    Select Case Err.Number
        Case Else
            MsgBox Err.Number & " " & Err.Description, , "Preview - Printing"
            Resume Next
    End Select

End Sub

Private Sub ResizeScrollBars()

' Check if scrollbars need to be added
    With vscPreview
'Determine if the Vertical scrollbar needs to be displayed
        If picChild.Height > picParent.Height Then
            .Visible = True
            .Max = picChild.Height - picParent.ScaleHeight
            .Min = 0
            .LargeChange = picChild.Height - picParent.Height
            imgCorner.Visible = True
        Else
            .Visible = False
            imgCorner.Visible = False
        End If
    End With
    
    With hscPreview
'Determine if the Horizontal scrollbar needs to be displayed
        If picChild.Width > picParent.Width Then
            .Visible = True
            .Max = picChild.Width - picParent.ScaleWidth
            .Min = 0
            .LargeChange = picChild.Width - picParent.ScaleWidth
            imgCorner.Visible = True
        Else
            .Visible = False
            imgCorner.Visible = False
        End If
    End With

End Sub

Public Sub SizePreview(lWidth As Long, lHeight As Long)

    Dim iCount As Integer
    
    For iCount = 0 To picPreview.Count - 1
        With picPreview(iCount)
            .Left = 0
            .Top = 0
            .Width = lWidth
            .Height = lHeight
        End With
    Next
    picChild.Move 0, 0, lWidth, lHeight
    
End Sub

Private Sub btnPreview_Click(Index As Integer)

    Select Case Index
        Case 0  'Print
            PreviewPrint
            Unload Me
        Case 1  'Zoom In
            PreviewZoomIn
        Case 2  'Zoom Out
            PreviewZoomOut
    End Select
    
End Sub

Private Sub cboPercent_Change()

    If bLoad = False Then
        With cboPercent
            ScalePercent = CInt(Left(.List(.ListIndex), Len(.List(.ListIndex)) - 1))
        End With
        PictureShow
    End If
    
End Sub

Private Sub cboPercent_Click()

    If bLoad = False Then
        With cboPercent
            ScalePercent = CInt(Left(.List(.ListIndex), Len(.List(.ListIndex)) - 1))
        End With
        PictureShow
    End If

End Sub

Private Sub cmdClose_Click()

    Unload Me
    
End Sub

Private Sub Form_Activate()
    
'Display the first page
    With picPreview(0)
        .Picture = .Image
        picChild.Move 0, 0, .Width, .Height
        picChild.Picture = .Picture
        PictureShow
    End With
    
End Sub

Private Sub Form_Load()

    bLoad = True
    FillCboPercent
    ScalePercent = 100
    WindowState = vbMaximized
    bLoad = False
    
End Sub

Private Sub Form_Resize()

    On Error Resume Next
    
    If WindowState = vbMinimized Then Exit Sub
    
    picToolbar.Move 0, 0, Width
    With tabPreview
        .Move lBorder, ScaleHeight - .Height - lBorder, ScaleWidth - (2 * lBorder)
        picParent.Move lBorder, lBorder + picToolbar.Height, ScaleWidth - (2 * lBorder), ScaleHeight - .Height - picToolbar.Height - (2 * lBorder)
    End With
    
End Sub

Private Sub hscPreview_Change()
    picChild.Left = (-hscPreview.Value)
End Sub

Private Sub hscPreview_Scroll()
    picChild.Left = (-hscPreview.Value)
End Sub

Private Sub picParent_Resize()
    
    Dim iCount As Integer
    
    With picParent
'Set up the Vertical Scroll Bar
        vscPreview.Move .ScaleLeft + .ScaleWidth - vscPreview.Width, .ScaleTop, vscPreview.Width, .ScaleHeight - hscPreview.Height

'Set up the Horizontal Scroll Bar
        hscPreview.Move 0, .ScaleHeight - hscPreview.Height, .ScaleWidth - vscPreview.Width

        imgCorner.Move vscPreview.Left, hscPreview.Top
    End With
    ResizeScrollBars
    
End Sub

Private Sub tabPreview_Click()

'Display the selected page
    With picPreview(tabPreview.SelectedItem.Index - 1)
        .Picture = .Image
        picChild.Picture = .Picture
        PictureShow
    End With

End Sub

Private Sub vscPreview_Change()
    picChild.Top = (-vscPreview.Value)
End Sub

Private Sub vscPreview_Scroll()
    picChild.Top = (-vscPreview.Value)
End Sub
