VERSION 5.00
Begin VB.Form frmDlgWindow 
   Caption         =   "Window Editor"
   ClientHeight    =   5055
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7095
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5055
   ScaleWidth      =   7095
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   465
      Left            =   5835
      TabIndex        =   0
      Top             =   4515
      Width           =   1185
   End
   Begin VB.PictureBox picWin 
      Height          =   3585
      Left            =   60
      ScaleHeight     =   3525
      ScaleWidth      =   4305
      TabIndex        =   19
      Top             =   120
      Width           =   4365
      Begin VB.TextBox objTBOX 
         Height          =   360
         Index           =   0
         Left            =   450
         TabIndex        =   34
         Text            =   "objTBOX"
         Top             =   1290
         Visible         =   0   'False
         Width           =   1305
      End
      Begin VB.PictureBox objPIC 
         AutoRedraw      =   -1  'True
         Height          =   945
         Index           =   0
         Left            =   2580
         ScaleHeight     =   59
         ScaleMode       =   3  'Pixel
         ScaleWidth      =   64
         TabIndex        =   31
         Top             =   240
         Visible         =   0   'False
         Width           =   1020
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   7
         Left            =   1080
         MousePointer    =   9  'Size W E
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   30
         Top             =   2250
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   6
         Left            =   1080
         MousePointer    =   6  'Size NE SW
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   29
         Top             =   2520
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   5
         Left            =   1395
         MousePointer    =   7  'Size N S
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   28
         Top             =   2550
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   4
         Left            =   1740
         MousePointer    =   8  'Size NW SE
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   27
         Top             =   2535
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   3
         Left            =   1740
         MousePointer    =   9  'Size W E
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   26
         Top             =   2265
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   2
         Left            =   1740
         MousePointer    =   6  'Size NE SW
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   25
         Top             =   1980
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   1
         Left            =   1395
         MousePointer    =   7  'Size N S
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   24
         Top             =   1965
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.PictureBox pSel 
         Appearance      =   0  'Flat
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         FillColor       =   &H00FFFFFF&
         ForeColor       =   &H00FFFFFF&
         Height          =   110
         Index           =   0
         Left            =   1080
         MousePointer    =   8  'Size NW SE
         ScaleHeight     =   105
         ScaleWidth      =   105
         TabIndex        =   23
         Top             =   1995
         Visible         =   0   'False
         Width           =   110
      End
      Begin VB.CommandButton objBUTTON 
         Caption         =   "objBUTTON"
         Height          =   480
         Index           =   0
         Left            =   705
         TabIndex        =   21
         Top             =   600
         Visible         =   0   'False
         Width           =   1245
      End
      Begin VB.TextBox objTAREA 
         Height          =   660
         Index           =   0
         Left            =   1950
         MousePointer    =   1  'Arrow
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   20
         Text            =   "frmDlgWindow.frx":0000
         Top             =   1380
         Visible         =   0   'False
         Width           =   1590
      End
   End
   Begin VB.Frame fraEvents 
      Caption         =   " Events "
      Height          =   1575
      Left            =   4560
      TabIndex        =   2
      Top             =   2100
      Width           =   2520
      Begin VB.ComboBox cmbFunction2 
         Height          =   315
         ItemData        =   "frmDlgWindow.frx":000B
         Left            =   1065
         List            =   "frmDlgWindow.frx":0012
         TabIndex        =   7
         Top             =   990
         Width           =   1335
      End
      Begin VB.ComboBox cmbFunction1 
         Height          =   315
         ItemData        =   "frmDlgWindow.frx":001D
         Left            =   1065
         List            =   "frmDlgWindow.frx":0024
         TabIndex        =   6
         Top             =   360
         Width           =   1335
      End
      Begin VB.Label lblFunc2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Right Click:"
         Height          =   195
         Left            =   120
         TabIndex        =   18
         Top             =   1080
         Width           =   810
      End
      Begin VB.Label lblFunc1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Left Click:"
         Height          =   195
         Left            =   120
         TabIndex        =   16
         Top             =   435
         Width           =   705
      End
   End
   Begin VB.Frame fraProperties 
      Caption         =   " Properties "
      Height          =   1890
      Left            =   4545
      TabIndex        =   1
      Top             =   165
      Width           =   2475
      Begin VB.TextBox txtName 
         Height          =   360
         Left            =   945
         TabIndex        =   4
         Top             =   255
         Width           =   1320
      End
      Begin VB.TextBox txtCaption 
         Height          =   360
         Left            =   945
         TabIndex        =   5
         Top             =   690
         Width           =   1320
      End
      Begin VB.Label lblName 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Name: "
         Height          =   195
         Left            =   105
         TabIndex        =   17
         Top             =   345
         Width           =   510
      End
      Begin VB.Label lblText 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Caption: "
         Height          =   195
         Left            =   105
         TabIndex        =   15
         Top             =   795
         Width           =   630
      End
   End
   Begin VB.Frame fraToolBar 
      Height          =   1260
      Left            =   90
      TabIndex        =   3
      Top             =   3750
      Width           =   5580
      Begin VB.CommandButton cmdAdd 
         Caption         =   "Text Box"
         Height          =   450
         Index           =   3
         Left            =   120
         TabIndex        =   8
         Top             =   255
         Width           =   1260
      End
      Begin VB.ComboBox cmbFuncOnResize 
         Height          =   315
         ItemData        =   "frmDlgWindow.frx":002F
         Left            =   1125
         List            =   "frmDlgWindow.frx":0036
         TabIndex        =   13
         Top             =   855
         Width           =   1545
      End
      Begin VB.CommandButton cmdDelete 
         Caption         =   "Delete"
         Height          =   330
         Left            =   4725
         TabIndex        =   12
         Top             =   375
         Width           =   735
      End
      Begin VB.ComboBox cmbFuncOnLoad 
         Height          =   315
         ItemData        =   "frmDlgWindow.frx":0041
         Left            =   3720
         List            =   "frmDlgWindow.frx":0048
         TabIndex        =   14
         Top             =   855
         Width           =   1620
      End
      Begin VB.CommandButton cmdAdd 
         Caption         =   "Picture"
         Height          =   450
         Index           =   2
         Left            =   1447
         TabIndex        =   9
         Top             =   255
         Width           =   1035
      End
      Begin VB.CommandButton cmdJavaTest 
         Caption         =   "Java Test"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   177
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   15
         TabIndex        =   22
         Top             =   -30
         Visible         =   0   'False
         Width           =   1065
      End
      Begin VB.CommandButton cmdAdd 
         Caption         =   "Text Area"
         Height          =   450
         Index           =   1
         Left            =   2549
         TabIndex        =   10
         Top             =   255
         Width           =   1260
      End
      Begin VB.CommandButton cmdAdd 
         Caption         =   "Button"
         Height          =   450
         Index           =   0
         Left            =   3876
         TabIndex        =   11
         Top             =   255
         Width           =   780
      End
      Begin VB.Label lblFuncOnResize 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "On Resize:"
         Height          =   195
         Left            =   150
         TabIndex        =   33
         Top             =   915
         Width           =   780
      End
      Begin VB.Line Line2 
         BorderColor     =   &H80000010&
         X1              =   75
         X2              =   5490
         Y1              =   755
         Y2              =   755
      End
      Begin VB.Line Line1 
         BorderColor     =   &H80000005&
         X1              =   105
         X2              =   5490
         Y1              =   760
         Y2              =   760
      End
      Begin VB.Label lblFuncOnLoad 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "On Load:"
         Height          =   195
         Left            =   2880
         TabIndex        =   32
         Top             =   915
         Width           =   660
      End
   End
End
Attribute VB_Name = "frmDlgWindow"
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

Dim DO_NOT_RESIZE As Boolean

' collection of all GUI objects on form:
Public theGUI As GUI_Collection

' currently selected GUI object:
Public selectedGUI As cGUI_obj

' used for moving controls:
Dim MOUSE_DOWN_X As Single
Dim MOUSE_DOWN_Y As Single
Dim MOUSE_PRESSED As Boolean


' used for moving selectors (to resize):
Dim sel_mDown_X As Single
Dim sel_mDown_Y As Single
Dim sel_mPressed As Boolean

' true when changes are accepted:
Dim ACCEPT_CHANGES As Boolean

'============ resize constrains:
Dim fraProperties_X As Single
Dim fraEvents_X As Single
Dim cmdOK_X As Single
Dim cmdOK_Y As Single
Dim fraToolBar_Y As Single
Dim picWin_W As Single
Dim picWin_H As Single
'==============================

' keep the minimum size of this window:
Dim myMinWidth As Single
Dim myMinHeight As Single



Private Sub Form_Activate()
    frmLists.fillCombo_func cmbFunction1
    frmLists.fillCombo_func cmbFunction2
    frmLists.fillCombo_func cmbFuncOnLoad
    frmLists.fillCombo_func cmbFuncOnResize
End Sub

Private Sub processRecentFunc()
    ' IMPR: (not very important)
    '  on this form only recent for last selected object is added,
    '  since when focus is lost by one of the controls the content
    '  of combo boxes changes.
    
    frmLists.addRecentFunc cmbFunction1.Text
    frmLists.addRecentFunc cmbFunction2.Text
    frmLists.addRecentFunc cmbFuncOnLoad.Text
    frmLists.addRecentFunc cmbFuncOnResize.Text
End Sub




Private Sub cmdAdd_Click(Index As Integer)
    Dim cg As cGUI_obj
    
    ' names are checked (for duplicates) on "OK" click.
    
    Select Case Index
    Case 0
        Set cg = theGUI.Add("Button" & objBUTTON.Count, "BUTTON")
    Case 1
        Set cg = theGUI.Add("TextArea" & objTAREA.Count, "TAREA")
    Case 2
        Set cg = theGUI.Add("Picture" & objPIC.Count, "PIC")
    Case 3
        Set cg = theGUI.Add("TextBox" & objTBOX.Count, "TBOX")
    End Select
    
    Set selectedGUI = cg
    
    showProperties selectedGUI
    setSelector selectedGUI
End Sub

Private Sub cmdJavaTest_Click()
    cmdOK_Click
    frmJavaTest.Show 1, Me
End Sub

Private Sub Form_Load()

    DO_NOT_RESIZE = False

    '============ set resize constrains:
    fraProperties_X = Me.ScaleWidth - fraProperties.Left
    fraEvents_X = Me.ScaleWidth - fraEvents.Left
    cmdOK_X = Me.ScaleWidth - cmdOK.Left
    cmdOK_Y = Me.ScaleHeight - cmdOK.Top
    fraToolBar_Y = Me.ScaleHeight - fraToolBar.Top
    picWin_W = Me.ScaleWidth - picWin.Width
    picWin_H = Me.ScaleHeight - picWin.Height
    '====================================

    ' keep minimum size of the window:
    myMinWidth = Me.Width
    myMinHeight = Me.Height

    ' initialize the collection:
    Set theGUI = New GUI_Collection
    Set theGUI.Parent = Me

    MOUSE_PRESSED = False
    ACCEPT_CHANGES = True
    
    Me.Icon = frmMain.Icon
End Sub

' checks that names are not duplicated.
' when everything OK returns True, otherwise shows
'  an error message and returns False:
Private Function ValidateNames() As Boolean
    Dim iCounter As Integer
    Dim s As String

    Dim cg As cGUI_obj
    Dim cRunner As cGUI_obj
    
    For Each cg In theGUI
        s = cg.sID
        If s <> "<DELETED>" Then   ' ignore deleted controls!
            iCounter = 0
            
            ' count number of components that have this name:
            For Each cRunner In theGUI
                ' compare, ignore case:
                If StrComp(s, cRunner.sID, vbTextCompare) = 0 Then
                    iCounter = iCounter + 1
                End If
            Next cRunner
            
            ' there should be only 1 such name:
            If iCounter > 1 Then
                MsgBox "There are " & iCounter & _
                       " components with name: " & s & vbNewLine & _
                       "All components should have unique names!"
                ValidateNames = False
                Exit Function
            End If
        End If
    Next cg
        
    ' all OK:
    ValidateNames = True
End Function

Private Sub cmdOK_Click()

    If Not ValidateNames() Then Exit Sub
    

    Dim cg As cGUI_obj
    
    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
        .zAction = "WINDOW"

        ' store window size:
        .zParam1 = picWin.Width & "|" & picWin.Height & "|"

        ' store all controls on window:
        .zParam2 = ""
 
        For Each cg In theGUI
            If cg.sID <> "<DELETED>" Then   ' do not store deleted controls!
                .zParam2 = .zParam2 _
                            & cg.sTYPE & "|" _
                            & cg.sID & "|" _
                            & cg.sText & "|" _
                            & cg.X & "|" _
                            & cg.Y & "|" _
                            & cg.w & "|" _
                            & cg.h & "|" _
                            & cg.sFunction1 & "|" _
                            & cg.sFunction2 & "|"
            End If
        Next cg
        
        ' store functions that execute when
        '   window is loaded, and when is resized:
        .zParam3 = cmbFuncOnLoad.Text & "|" & cmbFuncOnResize.Text & "|"
        
        .setCaptionToAction
    End With
    
    Me.Hide
    
    processRecentFunc
    
    bIS_MODIFIED = True
End Sub




''''''''''''   moving buttons:


Private Sub objBUTTON_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_DOWN_X = X
    MOUSE_DOWN_Y = Y
    MOUSE_PRESSED = True
    ' selected:
    Set selectedGUI = theGUI.getObjectFromIndex(Index, "BUTTON")
    'show properties:
    showProperties selectedGUI
    setSelector selectedGUI
End Sub

Private Sub objBUTTON_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If MOUSE_PRESSED Then
        objBUTTON(Index).Move objBUTTON(Index).Left + X - MOUSE_DOWN_X, objBUTTON(Index).Top + Y - MOUSE_DOWN_Y
        setSelectorVisible False
    End If
End Sub

Private Sub objBUTTON_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_PRESSED = False
    setSelector selectedGUI
End Sub





''''''''''' moving TAREAs:


Private Sub objTAREA_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_DOWN_X = X
    MOUSE_DOWN_Y = Y
    MOUSE_PRESSED = True
    ' selected:
    Set selectedGUI = theGUI.getObjectFromIndex(Index, "TAREA")
    'show properties:
    showProperties selectedGUI
    setSelector selectedGUI
End Sub

Private Sub objTAREA_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If MOUSE_PRESSED Then
        objTAREA(Index).Move objTAREA(Index).Left + X - MOUSE_DOWN_X, objTAREA(Index).Top + Y - MOUSE_DOWN_Y
        setSelectorVisible False
    End If
End Sub

Private Sub objTAREA_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_PRESSED = False
    setSelector selectedGUI
End Sub



''''''''''' moving TBOXes:


Private Sub objTBOX_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_DOWN_X = X
    MOUSE_DOWN_Y = Y
    MOUSE_PRESSED = True
    ' selected:
    Set selectedGUI = theGUI.getObjectFromIndex(Index, "TBOX")
    'show properties:
    showProperties selectedGUI
    setSelector selectedGUI
End Sub

Private Sub objTBOX_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If MOUSE_PRESSED Then
        objTBOX(Index).Move objTBOX(Index).Left + X - MOUSE_DOWN_X, objTBOX(Index).Top + Y - MOUSE_DOWN_Y
        setSelectorVisible False
    End If
End Sub

Private Sub objTBOX_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_PRESSED = False
    setSelector selectedGUI
End Sub




''''''''''' moving pics:

Private Sub objPIC_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' picture has PIXEL scale-mode so convert to twips,
    ' since moving can be done only in TWIPS scale mode:
    MOUSE_DOWN_X = X * Screen.TwipsPerPixelX
    MOUSE_DOWN_Y = Y * Screen.TwipsPerPixelY
    MOUSE_PRESSED = True
    ' selected:
    Set selectedGUI = theGUI.getObjectFromIndex(Index, "PIC")
    'show properties:
    showProperties selectedGUI
    setSelector selectedGUI
End Sub

Private Sub objPIC_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' picture has PIXEL scale-mode so convert to twips,
    ' since moving can be done only in TWIPS scale mode:
    X = X * Screen.TwipsPerPixelX
    Y = Y * Screen.TwipsPerPixelY
    If MOUSE_PRESSED Then
        objPIC(Index).Move objPIC(Index).Left + X - MOUSE_DOWN_X, objPIC(Index).Top + Y - MOUSE_DOWN_Y
        setSelectorVisible False
    End If
End Sub

Private Sub objPIC_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    MOUSE_PRESSED = False
    setSelector selectedGUI
End Sub




Private Sub showProperties(objGUI As cGUI_obj)
    If objGUI Is Nothing Then Exit Sub

    ACCEPT_CHANGES = False

    txtName.Text = objGUI.sID
    txtCaption.Text = replaceALL(objGUI.sText, vbNewLine, "\n")
    cmbFunction1.Text = objGUI.sFunction1
    cmbFunction2.Text = objGUI.sFunction2

    ACCEPT_CHANGES = True
End Sub

Private Sub setSelector(objGUI As cGUI_obj)
    If objGUI Is Nothing Then Exit Sub
    
    Dim X As Integer
    Dim Y As Integer
    
    Dim sSIZE As Integer
    
    ' width and height of all selectors
    '   is the same:
    sSIZE = pSel(0).Width
    
    
    
    ' left top:
    X = objGUI.X - sSIZE
    Y = objGUI.Y - sSIZE
    pSel(0).Move X, Y
    
    ' middle top:
    X = objGUI.X + objGUI.w / 2 - sSIZE / 2
    Y = objGUI.Y - sSIZE
    pSel(1).Move X, Y
    
    ' right top:
    X = objGUI.X + objGUI.w
    Y = objGUI.Y - sSIZE
    pSel(2).Move X, Y
    
    ' middle right:
    X = objGUI.X + objGUI.w
    Y = objGUI.Y + objGUI.h / 2 - sSIZE / 2
    pSel(3).Move X, Y
    
    ' right bottom:
    X = objGUI.X + objGUI.w
    Y = objGUI.Y + objGUI.h
    pSel(4).Move X, Y
    
    ' middle bottom:
    X = objGUI.X + objGUI.w / 2 - sSIZE / 2
    Y = objGUI.Y + objGUI.h
    pSel(5).Move X, Y
    
    ' left bottom:
    X = objGUI.X - sSIZE
    Y = objGUI.Y + objGUI.h
    pSel(6).Move X, Y
    
    ' middle left:
    X = objGUI.X - sSIZE
    Y = objGUI.Y + objGUI.h / 2 - sSIZE / 2
    pSel(7).Move X, Y
    
   
   
    ' make sure it's visible and
    '   put it over all other components:
   
    Dim i As Integer
    
    For i = 0 To 7
        pSel(i).ZOrder 0
    Next i
    
    setSelectorVisible True
    
End Sub

Private Sub setSelectorVisible(b As Boolean)
    Dim i As Integer

    For i = 0 To 7
        If pSel(i).Visible <> b Then
            pSel(i).Visible = b
        End If
    Next i
End Sub


Private Sub txtName_Change()
    If selectedGUI Is Nothing Then Exit Sub
    If Not ACCEPT_CHANGES Then Exit Sub
    
    ' names are checked (for duplicates) on "OK" click.
    
    selectedGUI.sID = txtName.Text
End Sub

Private Sub txtCaption_Change()
    If selectedGUI Is Nothing Then Exit Sub
    If Not ACCEPT_CHANGES Then Exit Sub
    
    selectedGUI.sText = replaceALL(txtCaption.Text, "\n", vbNewLine)
End Sub

Private Sub cmbFunction1_Change()
    If selectedGUI Is Nothing Then Exit Sub
    If Not ACCEPT_CHANGES Then Exit Sub

    selectedGUI.sFunction1 = cmbFunction1.Text
End Sub

Private Sub cmbFunction1_Click()
    cmbFunction1_Change
End Sub

Private Sub cmbFunction2_Change()
    If selectedGUI Is Nothing Then Exit Sub
    If Not ACCEPT_CHANGES Then Exit Sub

    selectedGUI.sFunction2 = cmbFunction2.Text
End Sub

Private Sub cmbFunction2_Click()
    cmbFunction2_Change
End Sub

Public Sub setWindowPARAMS(ByVal sSIZE As String, ByVal sWIN_EVENTS As String)
    
    '========== set window size:
    
    ' borders were taken in calculation...
    '  but this caused problems, so removed.
    
    picWin.Width = Val(rcToken(sSIZE, "|")) ' + (picWin.Width - picWin.ScaleWidth)
    picWin.Height = Val(rcToken(sSIZE, "|")) ' + (picWin.Height - picWin.ScaleHeight)
    
    ' allow on resize operations only after height is also set
    DO_NOT_RESIZE = True
    Me.Width = picWin.Width + picWin_W + (Me.Width - Me.ScaleWidth)
    DO_NOT_RESIZE = False
    Me.Height = picWin.Height + picWin_H + (Me.Height - Me.ScaleHeight)
    
    
    '=========== set "ON LOAD" function:
    cmbFuncOnLoad.Text = rcToken(sWIN_EVENTS, "|") ' sONLOAD
    '=========== set "ON RESIZE" function:
    cmbFuncOnResize.Text = rcToken(sWIN_EVENTS, "|")
End Sub

Private Sub Form_Resize()
    
    If DO_NOT_RESIZE Then Exit Sub
    
On Error GoTo err1
    
    ' do only if size is OK:
    If (Me.Width >= myMinWidth) And (Me.Height >= myMinHeight) Then
        '============ re-set resize constrains:
            fraProperties.Left = Me.ScaleWidth - fraProperties_X
            fraEvents.Left = Me.ScaleWidth - fraEvents_X
            cmdOK.Left = Me.ScaleWidth - cmdOK_X
            cmdOK.Top = Me.ScaleHeight - cmdOK_Y
            fraToolBar.Top = Me.ScaleHeight - fraToolBar_Y
            picWin.Width = Me.ScaleWidth - picWin_W
            picWin.Height = Me.ScaleHeight - picWin_H
        '====================================
    Else
        ' check the size (if required make it bigger):
        '   "-30" has no real meaning, but window can
        '   be made smaller for about 2 pixels of minimum
        '   size (that is recorded):
        If Me.Width < (myMinWidth - 30) Then
             Me.Width = myMinWidth
        End If
        If Me.Height < (myMinHeight - 30) Then
            Me.Height = myMinHeight
        End If
    End If
    
Exit Sub
err1:
Debug.Print "Error on resize: " & Err.Description
End Sub




''''' moving selector:

Private Sub pSel_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    sel_mDown_X = X
    sel_mDown_Y = Y
    sel_mPressed = True
End Sub

Private Sub pSel_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   
    If sel_mPressed Then
  
        Dim oldX As Integer
        Dim oldY As Integer
        Dim oldW As Integer
        Dim oldH As Integer
                  
        Dim sSIZE As Integer
        ' width and height of all selectors
        '   is the same:
        sSIZE = pSel(0).Width
       
        oldX = selectedGUI.X
        oldY = selectedGUI.Y
        oldW = selectedGUI.w
        oldH = selectedGUI.h
        
        Select Case Index
         
        Case 0      ' left top
             pSel(Index).Move pSel(Index).Left + X - sel_mDown_X, pSel(Index).Top + Y - sel_mDown_Y
             
             selectedGUI.X = pSel(0).Left + sSIZE
             selectedGUI.Y = pSel(0).Top + sSIZE
             
             selectedGUI.w = (oldX - selectedGUI.X) + oldW
             selectedGUI.h = (oldY - selectedGUI.Y) + oldH
              
        Case 1      ' middle top
             pSel(Index).Top = pSel(Index).Top + Y - sel_mDown_Y
        
             selectedGUI.Y = pSel(1).Top + sSIZE
             
             selectedGUI.h = (oldY - selectedGUI.Y) + oldH
             
        Case 2      ' right top
             pSel(Index).Move pSel(Index).Left + X - sel_mDown_X, pSel(Index).Top + Y - sel_mDown_Y

             selectedGUI.w = pSel(2).Left - oldX
             
             selectedGUI.Y = pSel(2).Top + sSIZE
             
             selectedGUI.h = (oldY - selectedGUI.Y) + oldH
              
        Case 3      ' middle right
            pSel(Index).Left = pSel(Index).Left + X - sel_mDown_X

            selectedGUI.w = pSel(3).Left - oldX
            
        Case 4      ' right bottom
            pSel(Index).Move pSel(Index).Left + X - sel_mDown_X, pSel(Index).Top + Y - sel_mDown_Y

            selectedGUI.w = pSel(4).Left - oldX
            selectedGUI.h = pSel(4).Top - oldY
            
        Case 5      ' middle bottom
            pSel(Index).Top = pSel(Index).Top + Y - sel_mDown_Y

            selectedGUI.h = pSel(5).Top - oldY
            
        Case 6      ' left bottom
            pSel(Index).Move pSel(Index).Left + X - sel_mDown_X, pSel(Index).Top + Y - sel_mDown_Y

            selectedGUI.h = pSel(6).Top - oldY
             
            selectedGUI.X = pSel(6).Left + sSIZE
             
            selectedGUI.w = (oldX - selectedGUI.X) + oldW
              
        Case 7      ' middle left
            pSel(Index).Left = pSel(Index).Left + X - sel_mDown_X

            selectedGUI.X = pSel(7).Left + sSIZE
             
            selectedGUI.w = (oldX - selectedGUI.X) + oldW
             
        End Select
        
        setSelector selectedGUI
        picWin.Refresh
    End If

End Sub

Private Sub pSel_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    sel_mPressed = False
    setSelector selectedGUI
End Sub

Private Sub pSel_Paint(Index As Integer)
    'pSel(Index).Line (10, 10)-(30, 30), , BF
    pSel(Index).Line (0, 0)-(pSel(Index).ScaleWidth - Screen.TwipsPerPixelX, pSel(Index).ScaleHeight - Screen.TwipsPerPixelY), , B
End Sub

Private Sub cmdDelete_Click()
    If selectedGUI Is Nothing Then Exit Sub
    
    ' mark it as deleted (won't be stored):
    selectedGUI.sID = "<DELETED>"
    
    ' hide the object:
    selectedGUI.objGUI.Visible = False
    
    ' hide selector:
    setSelectorVisible False
End Sub
