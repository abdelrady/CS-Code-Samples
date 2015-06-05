VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{EB232C68-A9FC-484A-B9CC-B9F5F12BD9FA}#1.0#0"; "ShapeOCX.ocx"
Begin VB.Form frmMain 
   Caption         =   "Data-Flow Visual Programming Language"
   ClientHeight    =   7005
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   9735
   Icon            =   "frmMain.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   467
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   649
   StartUpPosition =   2  'CenterScreen
   Begin ShapeOCX.GShape shp 
      Height          =   600
      Index           =   0
      Left            =   1320
      TabIndex        =   27
      Top             =   1050
      Visible         =   0   'False
      Width           =   540
      _ExtentX        =   953
      _ExtentY        =   1058
      BGColor         =   16777215
   End
   Begin VB.CheckBox chk_LOAD_GUI 
      Alignment       =   1  'Right Justify
      Caption         =   "Load GUI"
      Height          =   330
      Left            =   8475
      TabIndex        =   23
      Top             =   630
      Value           =   1  'Checked
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   360
      Left            =   5520
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   600
      Visible         =   0   'False
      Width           =   2685
   End
   Begin VB.Frame fraToolBar2 
      Height          =   615
      Left            =   1200
      TabIndex        =   14
      Top             =   -30
      Width           =   2100
      Begin VB.CheckBox chkCONTINUED_CONNECTION 
         Alignment       =   1  'Right Justify
         Height          =   255
         Left            =   120
         TabIndex        =   26
         ToolTipText     =   "Automatic Connect"
         Top             =   240
         Width           =   255
      End
      Begin VB.CommandButton cmdEdit 
         Caption         =   "Edit"
         Height          =   375
         Left            =   1410
         TabIndex        =   17
         Top             =   180
         Width           =   585
      End
      Begin VB.CommandButton cmdConnect 
         Caption         =   "Connect"
         Height          =   375
         Left            =   480
         TabIndex        =   15
         Top             =   180
         Width           =   840
      End
   End
   Begin VB.Timer timerRunner 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   6480
      Top             =   1080
   End
   Begin VB.Frame fraDebug 
      Height          =   630
      Left            =   3360
      TabIndex        =   9
      Top             =   -30
      Width           =   6285
      Begin VB.CheckBox chkPause 
         Alignment       =   1  'Right Justify
         Enabled         =   0   'False
         Height          =   375
         Left            =   1320
         Picture         =   "frmMain.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   25
         ToolTipText     =   "Pause"
         Top             =   165
         Width           =   495
      End
      Begin VB.CommandButton cmdNextStep 
         Enabled         =   0   'False
         Height          =   375
         Left            =   1920
         Picture         =   "frmMain.frx":036F
         Style           =   1  'Graphical
         TabIndex        =   24
         ToolTipText     =   "Step"
         Top             =   165
         Width           =   495
      End
      Begin VB.HScrollBar scroll_ExecutionDelay 
         Height          =   165
         Left            =   2520
         Max             =   2001
         TabIndex        =   22
         TabStop         =   0   'False
         Top             =   360
         Value           =   100
         Width           =   1335
      End
      Begin VB.CommandButton cmdStack 
         Caption         =   "Stack"
         Height          =   375
         Left            =   4530
         MaskColor       =   &H00FFFFFF&
         Style           =   1  'Graphical
         TabIndex        =   19
         TabStop         =   0   'False
         Top             =   165
         UseMaskColor    =   -1  'True
         Width           =   810
      End
      Begin VB.CommandButton cmdVars 
         Caption         =   "Vars"
         Height          =   375
         Left            =   5370
         MaskColor       =   &H00FFFFFF&
         Style           =   1  'Graphical
         TabIndex        =   16
         TabStop         =   0   'False
         Top             =   165
         UseMaskColor    =   -1  'True
         Width           =   810
      End
      Begin VB.CommandButton cmdScreen 
         Height          =   375
         Left            =   3960
         MaskColor       =   &H00FFFFFF&
         Picture         =   "frmMain.frx":03DB
         Style           =   1  'Graphical
         TabIndex        =   12
         TabStop         =   0   'False
         ToolTipText     =   "Screen"
         Top             =   165
         UseMaskColor    =   -1  'True
         Width           =   495
      End
      Begin VB.CommandButton cmdRun 
         Height          =   375
         Left            =   105
         MaskColor       =   &H00FFFFFF&
         Picture         =   "frmMain.frx":08ED
         Style           =   1  'Graphical
         TabIndex        =   11
         TabStop         =   0   'False
         ToolTipText     =   "Run"
         Top             =   165
         Width           =   495
      End
      Begin VB.CommandButton cmdStop 
         Height          =   375
         Left            =   720
         Picture         =   "frmMain.frx":0951
         Style           =   1  'Graphical
         TabIndex        =   10
         TabStop         =   0   'False
         ToolTipText     =   "Stop"
         Top             =   165
         UseMaskColor    =   -1  'True
         Width           =   495
      End
      Begin VB.Label lblDelay 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "delay:100"
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   8.25
            Charset         =   177
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Left            =   2715
         TabIndex        =   18
         Top             =   135
         Width           =   975
      End
   End
   Begin VB.Frame fraToolBar1 
      Height          =   6120
      Left            =   30
      TabIndex        =   2
      Top             =   -30
      Width           =   1095
      Begin VB.CommandButton cmdWindow 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":09AE
         Style           =   1  'Graphical
         TabIndex        =   21
         ToolTipText     =   "Window"
         Top             =   4758
         Width           =   900
      End
      Begin VB.CommandButton cmdFunction 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0A4E
         Style           =   1  'Graphical
         TabIndex        =   20
         ToolTipText     =   "Function"
         Top             =   4104
         Width           =   900
      End
      Begin VB.CommandButton cmdIntersection 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0AF0
         Style           =   1  'Graphical
         TabIndex        =   13
         ToolTipText     =   "Intersection"
         Top             =   3450
         Width           =   900
      End
      Begin VB.CommandButton cmdJunction 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0B61
         Style           =   1  'Graphical
         TabIndex        =   8
         ToolTipText     =   "Conditional Junction"
         Top             =   2796
         Width           =   900
      End
      Begin VB.CommandButton cmdOutput 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0BE3
         Style           =   1  'Graphical
         TabIndex        =   7
         ToolTipText     =   "Output"
         Top             =   2142
         Width           =   900
      End
      Begin VB.CommandButton cmdInput 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0C82
         Style           =   1  'Graphical
         TabIndex        =   6
         ToolTipText     =   "Input"
         Top             =   1488
         Width           =   900
      End
      Begin VB.CommandButton cmdAction 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0D19
         Style           =   1  'Graphical
         TabIndex        =   5
         ToolTipText     =   "Action"
         Top             =   834
         Width           =   900
      End
      Begin VB.CommandButton cmdEnd 
         Height          =   585
         Left            =   105
         Picture         =   "frmMain.frx":0DB8
         Style           =   1  'Graphical
         TabIndex        =   4
         ToolTipText     =   "Stop"
         Top             =   5415
         Width           =   900
      End
      Begin VB.CommandButton cmdStart 
         Height          =   585
         Left            =   105
         MaskColor       =   &H000000FF&
         Picture         =   "frmMain.frx":0E5C
         Style           =   1  'Graphical
         TabIndex        =   3
         ToolTipText     =   "Start"
         Top             =   180
         Width           =   900
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   2160
      Top             =   720
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label lblURL 
      AutoSize        =   -1  'True
      BackColor       =   &H0080FFFF&
      Caption         =   " http://www.emu8086.com/vb/ "
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Left            =   5910
      MouseIcon       =   "frmMain.frx":0F00
      MousePointer    =   99  'Custom
      TabIndex        =   28
      Top             =   600
      Width           =   3360
   End
   Begin VB.Image imgCircle 
      Height          =   480
      Left            =   4005
      Picture         =   "frmMain.frx":1052
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgParall 
      Height          =   480
      Left            =   2493
      Picture         =   "frmMain.frx":11A4
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgOval 
      Height          =   480
      Left            =   1737
      Picture         =   "frmMain.frx":12F6
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgFunc 
      Height          =   480
      Left            =   981
      Picture         =   "frmMain.frx":1448
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgDiamond 
      Height          =   480
      Left            =   225
      Picture         =   "frmMain.frx":159A
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgRect 
      Height          =   480
      Left            =   3249
      Picture         =   "frmMain.frx":16EC
      Top             =   6390
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Shape shp_Selector 
      BorderColor     =   &H00FF0000&
      BorderWidth     =   2
      Height          =   855
      Left            =   4620
      Top             =   1440
      Visible         =   0   'False
      Width           =   1185
   End
   Begin VB.Label lblLineCap 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackColor       =   &H00404040&
      Caption         =   "lblLineCap"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   177
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   240
      Index           =   0
      Left            =   1410
      TabIndex        =   1
      Top             =   3375
      Visible         =   0   'False
      Width           =   1125
   End
   Begin VB.Line arrDown 
      BorderColor     =   &H000000FF&
      BorderWidth     =   2
      Index           =   0
      Visible         =   0   'False
      X1              =   187
      X2              =   211
      Y1              =   287
      Y2              =   275
   End
   Begin VB.Line arrUp 
      BorderColor     =   &H0000FF00&
      BorderWidth     =   2
      Index           =   0
      Visible         =   0   'False
      X1              =   186
      X2              =   212
      Y1              =   265
      Y2              =   272
   End
   Begin VB.Shape aDot 
      BackColor       =   &H00FF00FF&
      BackStyle       =   1  'Opaque
      BorderColor     =   &H0000FF00&
      FillColor       =   &H00FFFF00&
      Height          =   60
      Index           =   0
      Left            =   3345
      Shape           =   3  'Circle
      Top             =   4050
      Visible         =   0   'False
      Width           =   60
   End
   Begin VB.Label lblID 
      Alignment       =   2  'Center
      Caption         =   "id#"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   177
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00808080&
      Height          =   180
      Left            =   1200
      TabIndex        =   0
      Top             =   600
      Width           =   420
   End
   Begin VB.Line ln 
      BorderColor     =   &H00000000&
      BorderWidth     =   2
      Index           =   0
      Visible         =   0   'False
      X1              =   222
      X2              =   344
      Y1              =   76
      Y2              =   217
   End
   Begin VB.Menu mnuFile 
      Caption         =   "File"
      Begin VB.Menu mnuNew 
         Caption         =   "New"
      End
      Begin VB.Menu mnu_DELIMETER_0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuLoad 
         Caption         =   "Load..."
      End
      Begin VB.Menu mnu_DELIMETER_1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExamplesMenu 
         Caption         =   "Examples"
         Begin VB.Menu mnuExample 
            Caption         =   "Factorial Calculation (Recursive)"
            Index           =   0
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Factorial Calculation (Loop)"
            Index           =   1
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Exponent Calculation (Recursive)"
            Index           =   2
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Simple Window and Print"
            Index           =   3
         End
         Begin VB.Menu mnuExample 
            Caption         =   "A basic Image-Map application for the Web"
            Index           =   4
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Window with picture and line drawing"
            Index           =   5
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Hello World"
            Index           =   6
         End
         Begin VB.Menu mnuExample 
            Caption         =   "String Compare"
            Index           =   7
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Conditional Execution"
            Index           =   8
         End
         Begin VB.Menu mnuExample 
            Caption         =   "String Concatenation"
            Index           =   9
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Simple Loop 1"
            Index           =   10
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Simple Loop 2"
            Index           =   11
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Function Call"
            Index           =   12
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Test of Screen Scrolling"
            Index           =   13
         End
         Begin VB.Menu mnuExample 
            Caption         =   "Basic SQL test"
            Index           =   14
            Visible         =   0   'False
         End
      End
      Begin VB.Menu mnu_DELIMETER_6 
         Caption         =   "-"
      End
      Begin VB.Menu mnuMakeExecutable 
         Caption         =   "Make Executable..."
      End
      Begin VB.Menu mnu_DELIMETER_2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSave 
         Caption         =   "Save"
      End
      Begin VB.Menu mnuSaveAs 
         Caption         =   "Save As..."
      End
      Begin VB.Menu mnu_DELIMETER_5 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuChangeShape 
      Caption         =   "Change Shape"
      Begin VB.Menu mnuChangeBackColor 
         Caption         =   "Change Back Color"
      End
      Begin VB.Menu mnuChangeTextColor 
         Caption         =   "Change Text Color"
      End
      Begin VB.Menu mnuChangeBorderColor 
         Caption         =   "Change Border Color"
      End
      Begin VB.Menu mnu_DELIMETER_3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuChangeSize 
         Caption         =   "Change Size"
      End
      Begin VB.Menu mnu_DELIMETER_4 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAddCaptionToLine 
         Caption         =   "Add Caption To Line"
      End
   End
   Begin VB.Menu mnuDelete 
      Caption         =   "Delete"
      Begin VB.Menu mnuDeleteLine 
         Caption         =   "Delete Line"
      End
      Begin VB.Menu mnuDeleteBlock 
         Caption         =   "Delete Block"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Help"
      Begin VB.Menu mnuHelpToStudent 
         Caption         =   "Help Topics"
         Shortcut        =   {F1}
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "frmMain"
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
' =========================================================
'  The main running form.
' =========================================================

Option Explicit

Dim distX As Single
Dim distY As Single

Public WithEvents theBlockCollection As Block_Collection
Attribute theBlockCollection.VB_VarHelpID = -1
Public WithEvents theLineCollection As Line_Collection
Attribute theLineCollection.VB_VarHelpID = -1

' keeps the name of a block, after one of the
'  buttons on the toolbar is clicked:
Dim sTOOLBAR_CLICK As String

' #020105:
Dim bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED As Boolean

Private Sub chk_LOAD_GUI_Click()
    If chk_LOAD_GUI.Value = vbChecked Then
        bGUI = True
    Else
        bGUI = False
    End If
End Sub

Private Sub chkPause_Click()
    If chkPause.Value = vbChecked Then
        timerRunner.Enabled = False
        cmdNextStep.Enabled = True
    Else
        timerRunner.Enabled = True
        cmdNextStep.Enabled = False
    End If
End Sub

Private Sub cmdConnect_Click()
    Dim cl As cLine
    Dim cbk As cBlock
    Dim sAct As String

    If (PREV_SELECTED_SHAPE <> -1) And (SELECTED_SHAPE <> -1) Then
    
        ' #020105:
        ' check if already connected:
        Dim c As cLine
        For Each c In theLineCollection
            If (c.sFrom = shp(PREV_SELECTED_SHAPE).Tag) And (c.sTo = shp(SELECTED_SHAPE).Tag) _
             Or (c.sTo = shp(PREV_SELECTED_SHAPE).Tag) And (c.sFrom = shp(SELECTED_SHAPE).Tag) Then
                If bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED Then
                    mBox cLang("Already connected!")
                End If
                Exit Sub
            End If
        Next c
    
        
        ' connect line:
        Set cl = theLineCollection.AddLine(shp(PREV_SELECTED_SHAPE).Tag, shp(SELECTED_SHAPE).Tag, "")

        ' check if it's an "IF" operation, and thus add any possible
        '     caption:
        Set cbk = theBlockCollection(shp(PREV_SELECTED_SHAPE).Tag)
        sAct = cbk.zAction
        If Mid(sAct, 1, 3) = "IF_" Then     ' any "if" action.
            If has_YES_Connection(cbk) Then
                cl.sCaption = cLang("NO")
            Else
                cl.sCaption = cLang("YES")
            End If
            cl.updateLine   ' to make sure caption is centered correctly.
        End If
        
        bIS_MODIFIED = True
    Else
        mBox "Two objects should be selected!"
    End If
End Sub

' returns TRUE when block has a line that goes from it and has "YES"
'  caption:
Private Function has_YES_Connection(cbk As cBlock) As Boolean
    Dim cl As cLine
    
    For Each cl In theLineCollection
       If cl.sFrom = cbk.theObjectShape.Tag Then
            If UCase(cl.sCaption) = cLang("YES") Then
                has_YES_Connection = True
                Exit Function
            End If
       End If
    Next cl
    
    has_YES_Connection = False
End Function

' allows to edit program's blocks:
Private Sub cmdEdit_Click()
    If SELECTED_SHAPE = -1 Then
        mBox cLang("Block not selected!")
        Exit Sub
    End If

    Dim cb As cBlock
    Set cb = theBlockCollection(shp(SELECTED_SHAPE).Tag)
    
    Select Case cb.zAction
    
    Case "START"
        Load frmDlgGeneral
        frmDlgGeneral.txtLocalVars.Text = cb.zParam1
        frmDlgGeneral.Show 1, Me
        Unload frmDlgGeneral
    
    Case "DEFINITION"   ' also re-defintion.
        Load frmDlgAction
        frmDlgAction.TabStrip1.Tabs("DEFINITION").Selected = True
        frmDlgAction.cboxVarName.Text = cb.zParam1
        frmDlgAction.txtVarValue.Text = cb.zParam2
        frmDlgAction.Show 1, Me
        Unload frmDlgAction
    
    Case "ADD", "MULTIPLY", "SUBTRACT", "DIVIDE"
        Load frmDlgAction
        frmDlgAction.TabStrip1.Tabs("ARITHMETIC").Selected = True
        frmDlgAction.cboxOperand1.Text = cb.zParam1
        frmDlgAction.cboxOperand2.Text = cb.zParam2
        If cb.zAction = "ADD" Then
            frmDlgAction.cboxOperation.ListIndex = 0
        ElseIf cb.zAction = "SUBTRACT" Then
            frmDlgAction.cboxOperation.ListIndex = 1
        ElseIf cb.zAction = "MULTIPLY" Then
            frmDlgAction.cboxOperation.ListIndex = 2
        ElseIf cb.zAction = "DIVIDE" Then
            frmDlgAction.cboxOperation.ListIndex = 3
        End If
        frmDlgAction.cboxResult.Text = cb.zParam3
        frmDlgAction.Show 1, Me
        Unload frmDlgAction
        
        
    Case "JOIN", "COMP"
        Load frmDlgAction
        frmDlgAction.TabStrip1.Tabs("STRINGS").Selected = True
        frmDlgAction.cboxString1.Text = cb.zParam1
        frmDlgAction.cboxString2.Text = cb.zParam2
        If cb.zAction = "JOIN" Then
            frmDlgAction.cboxStringOperation.ListIndex = 0
        ElseIf cb.zAction = "COMP" Then
            frmDlgAction.cboxStringOperation.ListIndex = 1
        End If
        frmDlgAction.cboxStringResult.Text = cb.zParam3
        frmDlgAction.Show 1, Me
        Unload frmDlgAction
        
        
        
    Case "SQL"
        Load frmDlgAction
        frmDlgAction.TabStrip1.Tabs("SQL").Selected = True
        frmDlgAction.cboxDatabase.Text = cb.zParam1
        frmDlgAction.txtSQL.Text = cb.zParam2
        frmDlgAction.Show 1, Me
        Unload frmDlgAction
                
    Case "INPUT"
       Load frmDlgInput
       frmDlgInput.txtText = cb.zParam1
       frmDlgInput.cboxVarName.Text = cb.zParam2
       frmDlgInput.Show 1, Me
       Unload frmDlgInput
        
    Case "OUTPUT"
       Load frmDlgOutput
       frmDlgOutput.txtText = cb.zParam1
       frmDlgOutput.cboxVarName.Text = cb.zParam2
       frmDlgOutput.Show 1, Me
       Unload frmDlgOutput
       
    Case "IF_EQUAL", "IF_LESS", "IF_GREATER", "IF_GREATER_EQUAL", "IF_LESS_EQUAL"
        Load frmDlgIf
        frmDlgIf.cboxOperand1.Text = cb.zParam1
        frmDlgIf.cboxOperand2.Text = cb.zParam2
        If cb.zAction = "IF_EQUAL" Then
             frmDlgIf.cboxOperation.ListIndex = 0
        ElseIf cb.zAction = "IF_LESS" Then
             frmDlgIf.cboxOperation.ListIndex = 1
        ElseIf cb.zAction = "IF_GREATER" Then
             frmDlgIf.cboxOperation.ListIndex = 2
        ElseIf cb.zAction = "IF_GREATER_EQUAL" Then
             frmDlgIf.cboxOperation.ListIndex = 3
        ElseIf cb.zAction = "IF_LESS_EQUAL" Then
             frmDlgIf.cboxOperation.ListIndex = 4
        End If
       frmDlgIf.Show 1, Me
       Unload frmDlgIf
        
    Case "FUNCTION"
        Load frmDlgFunction
        frmDlgFunction.cboxFunctionName.Text = cb.zParam1
        frmDlgFunction.cboxParam1.Text = cb.zParam2
        frmDlgFunction.cboxResult.Text = cb.zParam3
        frmDlgFunction.Show 1, Me
        Unload frmDlgFunction
        
    Case "WINDOW"
        Load frmDlgWindow
        frmDlgWindow.setWindowPARAMS cb.zParam1, cb.zParam3
        setControls frmDlgWindow, cb.zParam2, False
        frmDlgWindow.Show 1, Me
        Unload frmDlgWindow    ' important!!!!!!!!!!
        
    Case "INTERSECTION", "STOP"
        mBox cb.zAction & " can not be edited!"
        
    Case Else
        mBox "Edit not supported yet for function: " & cb.zAction & ". sorry"
    
    End Select
         
    ' update all lines, since the block size could be changed:
    theLineCollection.updateAllLines
         
    ' update the selector:
    setSelector cb
    ' make sure it repaints:
    cb.theObjectShape.RepaintBlock
    
End Sub

Private Sub cmdNextStep_Click()
    chkPause.Value = vbUnchecked
End Sub

Private Sub cmdScreen_Click()
    ' 1.88
    If frmScreen.WindowState = vbMinimized Then
        frmScreen.WindowState = vbNormal
    End If
    frmScreen.Show , Me
End Sub

' 1.88
'''Private Sub cmdScreen_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
'''    ' used instead of Click because Click event reacts on "enter" key
'''    '   (this is good for frmScreen.processKey KeyAscii).
'''    If frmScreen.WindowState = vbMinimized Then
'''        frmScreen.WindowState = vbNormal
'''    End If
'''    frmScreen.Show , Me
'''End Sub

Private Sub cmdStack_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    frmStack.Show , Me
End Sub

Private Sub cmdStop_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' MouseDown is used instead of Click because it's better
    '   when there is always focus on frmScreen (when printing a lot).
    TerminateExecution
End Sub

''''''''''' TOOLBAR ''''''''''''
Private Sub fraToolBar1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' remove selection of any tool when
    '   clicked over the frame:
    sTOOLBAR_CLICK = ""
    Me.MousePointer = vbDefault
End Sub

Private Sub cmdStart_Click()
    If Not bGUI Then Exit Sub

    sTOOLBAR_CLICK = "START"
    
    Me.MouseIcon = imgOval.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdAction_Click()
    If Not bGUI Then Exit Sub
        
    sTOOLBAR_CLICK = "ACTION"
    
    Me.MouseIcon = imgRect.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdInput_Click()
    If Not bGUI Then Exit Sub

    sTOOLBAR_CLICK = "INPUT"
    
    Me.MouseIcon = imgParall.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdOutput_Click()
    If Not bGUI Then Exit Sub

    sTOOLBAR_CLICK = "OUTPUT"
    
    Me.MouseIcon = imgParall.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdJunction_Click()
    If Not bGUI Then Exit Sub

    sTOOLBAR_CLICK = "JUNCTION"
    
    Me.MouseIcon = imgDiamond.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdIntersection_Click()
    If Not bGUI Then Exit Sub
    
    sTOOLBAR_CLICK = "INTERSECTION"
    
    Me.MouseIcon = imgCircle.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdFunction_Click()
    If Not bGUI Then Exit Sub
    
    sTOOLBAR_CLICK = "FUNCTION"
    
    Me.MouseIcon = imgFunc.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdVars_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    frmVars.Show , Me
End Sub

Private Sub cmdWindow_Click()
    If Not bGUI Then Exit Sub
    
    sTOOLBAR_CLICK = "WINDOW"
    
    Me.MouseIcon = imgRect.Picture
    Me.MousePointer = vbCustom
End Sub

Private Sub cmdEnd_Click()
    If Not bGUI Then Exit Sub
    
    sTOOLBAR_CLICK = "END"
    
    Me.MouseIcon = imgOval.Picture
    Me.MousePointer = vbCustom
End Sub
''''''''''' end of TOOLBAR ''''''''''''




Private Sub Form_Load()

    ' #020105:
    bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED = True

' 1.88
''''#020104:
'''    cmdRun.Picture = picRun_internal.Picture
'''    Dim c As Long
'''    c = picRun_internal.Point(12, 2)
'''    If c > 0 Then
'''        cmdRun.MaskColor = c
'''        cmdRun.UseMaskColor = True
'''        ' "stop" uses the same back color as "run":
'''        cmdStop.MaskColor = c
'''        cmdStop.UseMaskColor = True
'''        ' "pause" uses the same back color as "run":
'''        chkPause.MaskColor = c
'''        chkPause.UseMaskColor = True
'''        ' "step" uses the same back color as "run":
'''        cmdNextStep.MaskColor = c
'''        cmdNextStep.UseMaskColor = True
'''    End If
    
' 1.88
' I'm using Transparent GIF files!!!
''''' #020105:
''''    c = pic_menu_back_color.Point(12, 2)
''''    If c > 0 Then
''''        cmdStart.MaskColor = c
''''        cmdStart.UseMaskColor = True
''''
''''        cmdAction.MaskColor = c
''''        cmdAction.UseMaskColor = True
''''
''''        cmdInput.MaskColor = c
''''        cmdInput.UseMaskColor = True
''''
''''        cmdOutput.MaskColor = c
''''        cmdOutput.UseMaskColor = True
''''
''''        cmdJunction.MaskColor = c
''''        cmdJunction.UseMaskColor = True
''''
''''        cmdIntersection.MaskColor = c
''''        cmdIntersection.UseMaskColor = True
''''
''''        cmdFunction.MaskColor = c
''''        cmdFunction.UseMaskColor = True
''''
''''        cmdWindow.MaskColor = c
''''        cmdWindow.UseMaskColor = True
''''
''''        cmdEnd.MaskColor = c
''''        cmdEnd.UseMaskColor = True
''''
''''    End If



    b_frmScreenVisible = False
    b_frm_mBoxVisible = False

    bTERMINATE_ON_CLOSE = False

    MAX_SHAPE = 0
    DRAGGED_SHAPE = -1
    SELECTED_SHAPE = -1
    PREV_SELECTED_SHAPE = -1

    Set theBlockCollection = New Block_Collection
    Set theLineCollection = New Line_Collection
    
    MAX_LINE = 0
    
    bWINDOW_LOADED = False
    bWINDOW_ACTIVATED = False
    bWINDOW_IS_RESIZING = False
    
    bIS_MODIFIED = False
    
    bGUI = True ' by default load GUI.
    
    sTOOLBAR_CLICK = ""
      
End Sub


Private Sub lblURL_Click()
   Call ShellExecute(Me.hwnd, "open", "http://www.emu8086.com/vb/", "", App.Path, SW_SHOWDEFAULT)
End Sub

Private Sub mnuAbout_Click()
    frmAbout.Show vbModal, Me
End Sub

Private Sub mnuChangeBackColor_Click()
    If SELECTED_SHAPE <> -1 Then
        CommonDialog1.ShowColor
        theBlockCollection(shp(SELECTED_SHAPE).Tag).BGColor = CommonDialog1.Color
        shp(SELECTED_SHAPE).RepaintBlock
        bIS_MODIFIED = True
    End If
End Sub

Private Sub mnuChangeBorderColor_Click()
    If SELECTED_SHAPE <> -1 Then
        CommonDialog1.ShowColor
        shp(SELECTED_SHAPE).BorderColor = CommonDialog1.Color
        shp(SELECTED_SHAPE).RepaintBlock
        bIS_MODIFIED = True
    End If
End Sub

Private Sub mnuChangeSize_Click()
    If SELECTED_SHAPE <> -1 Then
        frmSize.Show , Me
    End If
End Sub

Private Sub mnuChangeTextColor_Click()
    If SELECTED_SHAPE <> -1 Then
        CommonDialog1.ShowColor
        theBlockCollection(shp(SELECTED_SHAPE).Tag).TextColor = CommonDialog1.Color
        shp(SELECTED_SHAPE).RepaintBlock
        bIS_MODIFIED = True
    End If
End Sub

Private Sub mnuDeleteBlock_Click()

    theBlockCollection.removeShape SELECTED_SHAPE
    
End Sub

Private Sub mnuDeleteLine_Click()

    theLineCollection.deleteLine SELECTED_SHAPE, PREV_SELECTED_SHAPE
    
End Sub

Private Sub mnuAddCaptionToLine_Click()
    If (PREV_SELECTED_SHAPE <> -1) And (SELECTED_SHAPE <> -1) Then
        Dim s As String
        s = InputBox("Enter the caption")
        theLineCollection.AddCaptionToLine frmMain.shp(PREV_SELECTED_SHAPE).Tag, frmMain.shp(SELECTED_SHAPE).Tag, s
    Else
        mBox "Two objects should be selected!"
    End If
End Sub

Private Sub mnuExample_Click(Index As Integer)
    If Not Check_If_Saved Then Exit Sub
    
    Dim bR As Boolean
    Dim sFileName As String
    
    ' hide selector:
    shp_Selector.Visible = False
    
    Select Case Index
    
    Case 0
        sFileName = "factorial.fpp"
        
    Case 1
        sFileName = "factorial_regular.fpp"
        
    Case 2
        sFileName = "power.fpp"

    Case 3
        sFileName = "b.fpp"

    Case 4
        sFileName = "d.fpp"

    Case 5
        sFileName = "e.fpp"

    Case 6
        sFileName = "test00_hello.fpp"

    Case 7
        sFileName = "test04_comp.fpp"
        
    Case 8
        sFileName = "test05_if.fpp"
        
    Case 9
        sFileName = "test06_concat.fpp"
        
    Case 10
        sFileName = "test07_loop.fpp"
         
    Case 11
        sFileName = "test08_loop.fpp"
        
    Case 12
        sFileName = "test10_call.fpp"
        
    Case 13
        sFileName = "test11_scroll.fpp"
        
    Case 14
        sFileName = "test09_sql.fpp"
        
    End Select
    
    bR = load_FILE(AddSlash(App.Path) & "Examples\" & sFileName)
    
    If Not bR Then
            mBox "Error loading example: " & AddSlash(App.Path) & "Examples\" & sFileName
    End If
    
    ' reset the selection:
    PREV_SELECTED_SHAPE = -1
    SELECTED_SHAPE = -1
End Sub

Private Sub mnuExit_Click()
    Unload Me
End Sub

Private Sub mnuHelpToStudent_Click()
  '  Dim r As Long
    
   ' r = ShellExecute(Me.hwnd, "open", AddSlash(App.Path) & "Help\index.html", "", App.Path, SW_SHOWDEFAULT)
    
      Call ShellExecute(Me.hwnd, "open", "http://www.emu8086.com/fp/Help/index.html", "", App.Path, SW_SHOWDEFAULT)
 
    
  '  If r <= 32 Then
  '      MsgBox "Cannot open help file, make sure program that reads HTML files is installed on your system."
  '  End If
End Sub

Private Sub mnuLoad_Click()

    If Not Check_If_Saved Then Exit Sub
    
   ''''''''''''''''''''''''''''
   

On Error GoTo Canceled

    CommonDialog1.InitDir = App.Path ' 1.88
    
    CommonDialog1.Flags = cdlOFNHideReadOnly
    CommonDialog1.Filter = "Flow Program Projects (*.fpp)|*.fpp|All Files|*.*"
    CommonDialog1.DefaultExt = "fpp"
    CommonDialog1.CancelError = True
    CommonDialog1.ShowOpen

    ' hide selector:
    shp_Selector.Visible = False
    
    load_FILE CommonDialog1.FileName

    ' reset the selection:
    PREV_SELECTED_SHAPE = -1
    SELECTED_SHAPE = -1

Canceled:
    
End Sub

' returns True when load successful, otherwise False:
Public Function load_FILE(sFILE As String) As Boolean

    ' no need to destroy all previous data if file doesn't
    '   even exits:
    If Not FileExists(sFILE) Then
        load_FILE = False
        Exit Function
    End If

    
    currentFileName = ""
    Me.Caption = ""


On Error GoTo error_load

    Dim i As Integer
    
    Dim mFileNum As Integer
    mFileNum = FreeFile
    
    ' unload all previous objects:
    For i = 1 To MAX_SHAPE
        Unload shp(i)
    Next i
    MAX_SHAPE = 0
    For i = theBlockCollection.Count To 1 Step -1
        theBlockCollection.Remove i
    Next i
    For i = 1 To MAX_LINE
        Unload ln(i)
        Unload aDot(i)
        Unload arrUp(i)
        Unload arrDown(i)
        Unload lblLineCap(i)
    Next i
    MAX_LINE = 0
    For i = theLineCollection.Count To 1 Step -1
        theLineCollection.Remove i
    Next i
    
    Open sFILE For Input As mFileNum

    Dim tempS As String
    
    Dim lineCounter As Integer
    Dim shapeCounter As Integer
    
    Line Input #mFileNum, tempS
    shapeCounter = Val(tempS)
    Line Input #mFileNum, tempS
    lineCounter = Val(tempS)
           
    Dim xS As cBlock
    Dim sName As String
           
    For i = 1 To shapeCounter
        Line Input #mFileNum, tempS
        sName = tempS
    
        Line Input #mFileNum, tempS
        Set xS = theBlockCollection.AddShape(Val(tempS), sName, 0, 0)

        Line Input #mFileNum, tempS
        If bGUI Then xS.shapeLeft = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.shapeTop = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.shapeWidth = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.shapeHeight = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.BGColor = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.BorderColor = Val(tempS)
        Line Input #mFileNum, tempS
        If bGUI Then xS.TextColor = Val(tempS)
        Line Input #mFileNum, tempS ' reserved 1
        ' reserved line 1
        Line Input #mFileNum, tempS ' reserved 2
        ' reserved line 2
        Line Input #mFileNum, tempS
        xS.zAction = tempS
        ' new line charectres are replaced by [\n] because of
        '  file format we are using:
        Line Input #mFileNum, tempS
        xS.zParam1 = returnNewLine(tempS)
        Line Input #mFileNum, tempS
        xS.zParam2 = returnNewLine(tempS)
        Line Input #mFileNum, tempS
        xS.zParam3 = returnNewLine(tempS)
        
        If bGUI Then xS.Visible = True
        
        If bGUI Then xS.setCaptionToAction       ' sets the caption from data.
    Next i
    
    ' skip two lines (idefication):
    Line Input #mFileNum, tempS
    Line Input #mFileNum, tempS
        
    Dim sFrom As String
    Dim sTo As String
    Dim psik_index As Integer
    
    Dim xL As cLine
    
    For i = 1 To lineCounter
        Line Input #mFileNum, tempS
        psik_index = InStr(1, tempS, ",")
        sFrom = Mid(tempS, 1, psik_index - 1)
        sTo = Mid(tempS, psik_index + 1)
        Line Input #mFileNum, tempS ' reserved 1
        Line Input #mFileNum, tempS ' get line caption (if any).
        Set xL = theLineCollection.AddLine(sFrom, sTo, tempS)
    Next i
    
    '' no need to update, updated by AddLine():
    theLineCollection.updateAllLines
    
    Close mFileNum
    
    
    currentFileName = sFILE
    Me.Caption = ExtractFileName(currentFileName)
    
    ' #020105:
    currentPATH = ExtractFilePath(currentFileName)
    
    bIS_MODIFIED = False    ' loaded, so no midifications.
    
    load_FILE = True        ' load successful!
    
    Exit Function
error_load:
    mBox "Error loading: " & sFILE & vbNewLine & _
           Err.Description
           
    bIS_MODIFIED = False    ' not loaded ?!, so no midifications.
    
    load_FILE = False       ' load failed!
End Function

Private Function Check_If_Saved() As Boolean
    If bIS_MODIFIED Then
        Dim r As Integer
        
        r = MsgBox("Project " & ExtractFileName(currentFileName) & " isn't saved!" _
           & vbNewLine & _
           vbNewLine & "Save changes?", vbYesNoCancel, "Save changes?")
           
        If r = vbYes Then
            ' by default "Save", if required "Save As..." is done:
            mnuSave_Click
        ElseIf r = vbCancel Then
            Check_If_Saved = False   ' cancel any action.
            Exit Function
        End If
        
        ' in case of "NO" just returns true (like it's saved).
    End If
    
    ' gets here when saved, or save is canceled:
    Check_If_Saved = True
End Function


Private Sub mnuNew_Click()
On Error GoTo err_nc ' 1.88

    If Not Check_If_Saved Then Exit Sub
    
   ''''''''''''''''''''''''''''
   
    load_FILE AddSlash(App.Path) & "NEW_TEMPLATE.fpp"
    currentFileName = ""
    Me.Caption = ""
    
    shp_Selector.Visible = False
   
       
    ' #020105:
    SELECTED_SHAPE = findBlock("START").theObjectShape.Index
    PREV_SELECTED_SHAPE = -1
    
    Exit Sub
err_nc:
    Debug.Print "mnuNew_Click: " & Err.Description
End Sub

Private Sub mnuSave_Click()
    If currentFileName <> "" Then
        SAVE_FILE currentFileName
    Else
        mnuSaveAs_Click     ' do "Save As...".
    End If
End Sub

Private Sub mnuSaveAs_Click()
On Error GoTo Canceled

    CommonDialog1.InitDir = App.Path ' 1.88
    
    CommonDialog1.Flags = cdlOFNHideReadOnly + cdlOFNOverwritePrompt
    CommonDialog1.Filter = "Flow Program Projects (*.fpp)|*.fpp|All Files|*.*"
    CommonDialog1.DefaultExt = "fpp"
    CommonDialog1.CancelError = True
    CommonDialog1.ShowSave

    currentFileName = CommonDialog1.FileName
    Me.Caption = ExtractFileName(currentFileName)
    
    ' #020105:
    currentPATH = ExtractFilePath(currentFileName)
    
    
    SAVE_FILE currentFileName
    
Canceled:

End Sub

Private Sub SAVE_FILE(sFileName As String)
    
    Dim mFileNum As Integer
    mFileNum = FreeFile
    
    Open sFileName For Output As mFileNum
           
    Dim sDl As String
    
    sDl = "       " & vbTab & " <--"
    
    Print #mFileNum, theBlockCollection.Count & sDl & "SHAPES"
    Print #mFileNum, theLineCollection.Count & sDl & "LINES"
    
    Dim xB As cBlock
    
    For Each xB In theBlockCollection
    
        Print #mFileNum, xB.TagID
        Print #mFileNum, xB.Shape & sDl & "TYPE"
        Print #mFileNum, xB.shapeLeft & sDl & "LEFT"
        Print #mFileNum, xB.shapeTop & sDl & "TOP"
        Print #mFileNum, xB.shapeWidth & sDl & "WIDTH"
        Print #mFileNum, xB.shapeHeight & sDl & "HEIGHT"
        Print #mFileNum, xB.BGColor & sDl & "BACKCOLOR"
        Print #mFileNum, xB.BorderColor & sDl & "BORDERCOLOR"
        Print #mFileNum, xB.TextColor & sDl & "BORDERCOLOR"
        Print #mFileNum, "-reserved 1-"   ' reserved!
        Print #mFileNum, "-reserved 2-"   ' reserved!
        Print #mFileNum, xB.zAction
        ' since parameters could be set by a user, it's required to
        '  check if there are new line characters inside, due to file
        '  format:
        Print #mFileNum, removeNewLine(xB.zParam1)
        Print #mFileNum, removeNewLine(xB.zParam2)
        Print #mFileNum, removeNewLine(xB.zParam3)
        
    Next xB
    
    Dim xL As cLine
    
    Print #mFileNum, "  "
    Print #mFileNum, "---- LINES ---- from,to ----"
    
    For Each xL In theLineCollection
        Print #mFileNum, xL.sFrom & "," & xL.sTo
        Print #mFileNum, "reserved 1"   ' reserved 1
        Print #mFileNum, xL.sCaption
    Next xL
    
    Close mFileNum
    
    bIS_MODIFIED = False        ' all saved, so not modified.
    
End Sub

Private Sub shp_DblClick(Index As Integer)
    ' #020105:
    cmdEdit_Click
End Sub

Private Sub shp_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
        DRAGGED_SHAPE = Index
        
        If SELECTED_SHAPE <> Index Then
             PREV_SELECTED_SHAPE = SELECTED_SHAPE
             SELECTED_SHAPE = Index
        End If
        
        distX = X
        distY = Y
        
        lblID.Caption = shp(Index).Tag
        
        ' looks better:
        shp(Index).ZOrder 0
        
        shp_Selector.Visible = False
End Sub

Private Sub shp_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If DRAGGED_SHAPE <> -1 Then
        shp(DRAGGED_SHAPE).Left = shp(DRAGGED_SHAPE).Left + X - distX
        shp(DRAGGED_SHAPE).Top = shp(DRAGGED_SHAPE).Top + Y - distY
        ' theLineCollection.updateAllLines
        theLineCollection.updateConntectedLines (shp(DRAGGED_SHAPE).Tag)
        bIS_MODIFIED = True
        
'' it's no longer required, since we placed an "if" that prevents
''  to prevent flickering (and unnecessary actions) in updateLine(),
''  and it solves problems.
''        ' to prevent undrawn areas when moving over too many
''        '   objects on the form:
''        Me.Refresh

' repaint still not good when there are many blocks...
'      (d4.tzr)
' solved by using updateConntectedLines() instead of updateAllLines().
       
    End If
End Sub

Private Sub shp_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If DRAGGED_SHAPE <> -1 Then setSelector theBlockCollection(shp(DRAGGED_SHAPE).Tag)
    DRAGGED_SHAPE = -1
    
    ' #020105:
    If chkCONTINUED_CONNECTION.Value = vbChecked Then
        bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED = False
        cmdConnect_Click
        bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED = True
    End If
End Sub

Private Sub theBlockCollection_linkError(sERROR As String)
    mBox sERROR
End Sub

Private Sub theLineCollection_linkError(sERROR As String)
    mBox sERROR
End Sub

' the same sub, just public:
Public Sub cmdRun_ClickP()
    cmdRun_MouseDown vbLeftButton, 0, 0, 0
End Sub


Private Sub cmdRun_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' used instead of Click because Click event reacts on "enter" key
    '   (this is good for frmScreen.processKey KeyAscii).

    ''''''''''''''''''''''''''''
    ' save should be done before running,
    '   since information may be lost when
    '   calling functions.
    If Not Check_If_Saved Then Exit Sub
   ''''''''''''''''''''''''''''

    frmScreen.clearScreen
    frmVars.clearVars
    frmStack.clearStack
    
    ' this replaces (simulates the "FUNCTION") - just file isn't loaded:
    
    ' [*] save param of previous function:
    frmStack.PUSH (frmVars.ifVarGetValue("PARAM"))
    
    frmStack.PUSH "PAR-OS" ' parameter(s).
    frmStack.PUSH "RET-OS" ' where to store result in.
    frmStack.PUSH "CS-OS"    ' CS.
    frmStack.PUSH "IP-OS"    ' IP.
    
    ' find block with "START" action,
    '        and start execution from there:
    Set currentRunPointer = findBlock("START")
    setSelector currentRunPointer
    cmdRun.Enabled = False              ' Disable Start button,
    '''cmdStop.SetFocus                    '   until Stop pressed.
    ''' "SetFocus" makes problems when frmMain is not visible.
          
    ' disable all controls that can prevent the right execution:
    enableOtherControls False
    
    ' get the number of seconds elapsed since midnight:
    STARTED_TIME = Timer
    
    StartExecution          ' Start execution.

End Sub

Public Sub StartExecution()
    timerRunner.Enabled = True

    ' in case timerRunner.Interval=0 , then timer doesn't
    ' execute, so we are using an eternal loop (this makes
    ' a turbo speed execution).
    ' Loop doesn't execute when timerRunner.Interval<>0!
    If timerRunner.Interval = 0 Then
        ' when timer gets disabled, loop stops:
        Do While timerRunner.Enabled
            timerRunner_Timer
            ' to prevent hang-ups
            '   (though this slows down the speed a little):
            DoEvents
        Loop
    Else
        ' #020104:
        ' in case not turbo speed, then enable the pause:
        chkPause.Enabled = True
    End If
End Sub


Public Sub TerminateExecution()
    If bGUI Then ' theObjectShape is set only with GUI.
        ' make sure the selected object for editing
        '  will be the same object that is selected
        '   currenlty (where we stoped):
        If Not (currentRunPointer Is Nothing) Then ' jic.
            SELECTED_SHAPE = currentRunPointer.theObjectShape.Index
        End If
        PREV_SELECTED_SHAPE = -1
    End If
    
    Set currentRunPointer = Nothing ' no need to keep it.


    ' in case we're waiting for input, stop it:
    frmScreen.timerInput.Enabled = False

    ' stop the main program timer:
    timerRunner.Enabled = False

    ' enable "Run" button:
    cmdRun.Enabled = True

    ' enalbe all controls again:
    enableOtherControls True


    If bWINDOW_ACTIVATED Then ' bWINDOW_LOADED Then
        ' don't let frmWindow execute UNLOAD()
        '  and start the timer:
        FORCE_CLOSE = True
        If Not bWINDOW_IS_RESIZING Then
            Unload frmWindow
        End If
    End If

    ' in case we are running from prompt:
    If CLOSE_APP_ON_END Then
        ' wait until frmScreen is closed, or
        '  some message is closed:
 ' '   removed because it makes problems -
 ' '   (frmWindow never closes):
 ' '      Do While frmScreen.Visible Or frm_mBox.Visible
 ' '          DoEvents
 ' '      Loop
 ' ' so now it's up to frmScreen and frm_mBox to call Terminate_APPLICATION()
 ' '   when they are closed:
        If (b_frmScreenVisible = False) And (b_frm_mBoxVisible = False) Then
            Terminate_APPLICATION
        Else
            bTERMINATE_ON_CLOSE = True
        End If
    End If


    ' #020104:
    chkPause.Enabled = False
    chkPause.Value = vbUnchecked
    
End Sub

' disable/enable all controls that can prevent the right execution:
Private Sub enableOtherControls(b As Boolean)
    fraToolBar1.Visible = b
    fraToolBar2.Visible = b
    mnuFile.Enabled = b
    mnuChangeShape.Enabled = b
    mnuDelete.Enabled = b
    mnuAddCaptionToLine.Enabled = b
    
    If b = False Then
        ' it's required to disable the executing speed
        '   changer only when it is set to zero:
        If scroll_ExecutionDelay.Value = 0 Then
            scroll_ExecutionDelay.Enabled = False
        Else
            ' do no allow to set executing speed to
            '  zero while running the flow because it is
            '    done by a loop and not the timer delay:
            scroll_ExecutionDelay.Min = 1
        End If
    Else
        scroll_ExecutionDelay.Min = 0 ' allow to set any speed.
        scroll_ExecutionDelay.Enabled = True
    End If
End Sub

Private Sub scroll_ExecutionDelay_Scroll()
    scroll_ExecutionDelay_Change
End Sub

' the speed of execution:
Private Sub scroll_ExecutionDelay_Change()
    timerRunner.Interval = scroll_ExecutionDelay.Value
    
    ' #020104:
    ' the eternal delay?
    If scroll_ExecutionDelay.Value = scroll_ExecutionDelay.Max Then
        lblDelay.Caption = cLang("delay") & ": P"
        timerRunner.Interval = 1
    Else
        lblDelay.Caption = cLang("delay") & ":" & scroll_ExecutionDelay.Value
    End If
End Sub

Private Sub timerRunner_Timer()
    
    'Debug.Print currentRunPointer.zAction
    
    ' catch all errors:
    On Error GoTo err1
    
    ' variants:
    Dim OP1, OP2
    
    ' for string operations:
    Dim s1 As String
    Dim s2 As String
    
    ' if currentRunPointer is not connected, then exit:
    If currentRunPointer Is Nothing Then
        TerminateExecution
        Exit Sub
    End If
    
    ' this is done twice in this sub:
    setSelector currentRunPointer
        
        
        
    ' 1.88
    ' make sure the selected object for editing
    '  will be the same object that is selected
    '   currenlty (where we stoped):
    If bGUI Then
        If Not (currentRunPointer Is Nothing) Then ' jic.
            SELECTED_SHAPE = currentRunPointer.theObjectShape.Index
        End If
        PREV_SELECTED_SHAPE = -1
    End If
        
        
        
    Select Case currentRunPointer.zAction
    
    Case "START"
        ' read parameter(s) from stack:
        If (frmStack.SP + 3) < frmStack.grid.Rows Then
          frmVars.setVar "PARAM", frmStack.grid.TextMatrix(frmStack.SP + 3, 2)
        Else
          mBox "Wrong function call - cannot read parameters from stack."
        End If
        
        ' parameter should be read from stack
        ' before pushing the local variables.
        
        ' push all local variables,
        '   (no need to search, since we keep the list in start block):
        push_LOCAL_vars currentRunPointer.zParam1
        
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
        
        
    Case "INPUT"
        Dim sTemp As String
        If frmScreen.WindowState = vbMinimized Then
            frmScreen.WindowState = vbNormal
        End If
        frmScreen.Show , Me
        ' old version ' sTemp = InputBox(currentRunPointer.zParam1, cLang("input"))
        sTemp = frmScreen.inputLine(currentRunPointer.zParam1)
        ' in case flow is stopped in the middle of input,
        '   currentRunPointer is reset, so we exit to prevent
        '     an error:
        If currentRunPointer Is Nothing Then Exit Sub
        frmVars.setVar currentRunPointer.zParam2, sTemp
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
      
    Case "OUTPUT"
        If frmScreen.WindowState = vbMinimized Then
            frmScreen.WindowState = vbNormal
        End If
        frmScreen.Show , Me
        If currentRunPointer.zParam2 = "" Then
            frmScreen.printLine currentRunPointer.zParam1
        ElseIf currentRunPointer.zParam1 = "" Then
            frmScreen.printLine frmVars.getVar(currentRunPointer.zParam2)
        Else
            frmScreen.printLine currentRunPointer.zParam1 & " " & frmVars.getVar(currentRunPointer.zParam2)
        End If
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).

    Case "DEFINITION"   ' also re-defintion.
        Dim p1 As String
        Dim p2 As String
        p1 = currentRunPointer.zParam1
        p2 = currentRunPointer.zParam2
        ' dots inside "" are ignored (assumed that it is a contant):
        If ((InStr(1, p1, ".") > 0) And (Mid(p1, 1, 1) <> """")) _
            Or ((InStr(1, p2, ".") > 0) And (Mid(p2, 1, 1) <> """")) Then
            If bWINDOW_LOADED Then
                If frmWindow.processObjectDefinition(p1, p2) Then
                    Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
                Else
                    ' in case of any error error is shown by the function.
                    ''Set currentRunPointer = Nothing
                    TerminateExecution  ' stop program!
                End If
            Else
                mBox "This operation requires" & vbNewLine & "window to be loaded!"
                ''Set currentRunPointer = Nothing
                TerminateExecution  ' stop program!
            End If
        Else
            frmVars.setVar p1, frmVars.ifVarGetValue(p2)
            Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
        End If
                
                
    Case "IF_EQUAL"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        If Val(OP1) = Val(OP2) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("YES"))
        Else
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("NO"))
        End If
        
    Case "IF_LESS"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        If Val(OP1) < Val(OP2) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("YES"))
        Else
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("NO"))
        End If
        
    Case "IF_GREATER"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        If Val(OP1) > Val(OP2) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("YES"))
        Else
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("NO"))
        End If
        
    Case "IF_GREATER_EQUAL"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        If Val(OP1) >= Val(OP2) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("YES"))
        Else
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("NO"))
        End If
        
    Case "IF_LESS_EQUAL"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        If Val(OP1) <= Val(OP2) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("YES"))
        Else
            Set currentRunPointer = getNextBlock(currentRunPointer, cLang("NO"))
        End If
        
        
    
    Case "ADD"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        frmVars.setVar currentRunPointer.zParam3, (Val(OP1) + Val(OP2))
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
         
    Case "SUBTRACT"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        frmVars.setVar currentRunPointer.zParam3, (Val(OP1) - Val(OP2))
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
        
    Case "MULTIPLY"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        frmVars.setVar currentRunPointer.zParam3, (Val(OP1) * Val(OP2))
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
                  
    Case "DIVIDE"
        OP1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        OP2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        frmVars.setVar currentRunPointer.zParam3, (Val(OP1) / Val(OP2))
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
                  
                  
                  
    Case "JOIN"
        s1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        s2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        s1 = removeQuotes(s1)  ' quotes around are ignored
        s2 = removeQuotes(s2) '
        frmVars.setVar currentRunPointer.zParam3, (s1 & s2)
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
         
    Case "COMP"
        s1 = frmVars.ifVarGetValue(currentRunPointer.zParam1)
        s2 = frmVars.ifVarGetValue(currentRunPointer.zParam2)
        s1 = removeQuotes(s1)  ' quotes around are ignored
        s2 = removeQuotes(s2) '
        frmVars.setVar currentRunPointer.zParam3, StrComp(s1, s2, vbTextCompare)
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
         
                  
    Case "SQL"
        ' #020105:
        Data1.DatabaseName = currentPATH & currentRunPointer.zParam1
        Data1.Refresh
        dbModule.runSQL currentRunPointer.zParam2
        Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
        
    Case "INTERSECTION"
      Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
    
    Case "FUNCTION"
        Dim sCommand As String
        Dim sParameters As String
        Dim sResultKeeper As String
        sCommand = currentRunPointer.zParam1
        sParameters = currentRunPointer.zParam2
        sResultKeeper = currentRunPointer.zParam3
        If executeInternalFunction(sCommand, sParameters, sResultKeeper) Then
            Set currentRunPointer = getNextBlock(currentRunPointer, "") ' any (should be one).
        Else
            frmStack.PUSH (frmVars.ifVarGetValue("PARAM")) ' [*] save param of previous function.
            ' PUSHING: 1. parameter(s), 2. where to store return, 3. CS, 4. IP
            frmStack.PUSH frmVars.ifVarGetValue(sParameters)   ' parameter(s).
            frmStack.PUSH sResultKeeper ' where to store result in.
            frmStack.PUSH ExtractFileName(currentFileName)  ' CS - return to that program.
            
            ' in case of "STACK OVERFLOW" (PUSH fails)
            '   currentRunPointer is set to nothing, and flow
            '     is terminated, so no need to proceed here:
            If currentRunPointer Is Nothing Then
                Exit Sub
            End If
            
            Dim blockToReturnTo As cBlock
            Set blockToReturnTo = getNextBlock(currentRunPointer, "")  ' any (should be one).
            If Not (blockToReturnTo Is Nothing) Then
                shp_Selector.Visible = False ' hide selector.
                frmStack.PUSH blockToReturnTo.TagID    ' IP - next command to return to (alpha...).
                ' #020105:
                If load_FILE(currentPATH & sCommand & ".fpp") Then   ' load another program (function).
                    Set currentRunPointer = findBlock("START")
                    setSelector currentRunPointer
                Else
                    setSelector currentRunPointer   ' just to show where we stoped.
                    mBox "Cannot load function: " & currentRunPointer.zParam1
                    ''Set currentRunPointer = Nothing ' Stop execution.
                    TerminateExecution  ' stop program!
                End If
            Else
                mBox "Function not connected!"
                ''Set currentRunPointer = Nothing ' Stop execution.
                TerminateExecution  ' stop program!
            End If
        End If
        
    Case "WINDOW"
        ' STOP THE TIMER!!!!!!!!
        '                        - until window is closed.
        '                        - or window calls a function (then closed again).
        timerRunner.Enabled = False
        
        Load frmWindow
        frmWindow.Show , Me
        
    Case "STOP"
        ' pop all local variables,
        '   (need to search, since we keep the list in start block):
        Dim tempB As cBlock
        Set tempB = findBlock("START")
        pop_LOCAL_vars tempB.zParam1

        ' POPING: 1. IP, 2. CS, 3. where to store return, 4. parameter(s) - clear up.
        Dim sStoreResult As String
        Dim sRetCS As String
        Dim sRetIP As String
        sRetIP = frmStack.POP
        sRetCS = frmStack.POP
        sStoreResult = frmStack.POP
        frmStack.POP    ' clear up from parameter(s).
        If sStoreResult <> "" Then
            frmVars.setVar sStoreResult, frmVars.getVar("RETURN") ' function stores return value in "RETURN".
        End If
        If sRetCS = "CS-OS" Then
            TerminateExecution
            '  mBox cLang("Program terminated successfully.") & vbNewLine _
            '      & "Running time: " & (Timer - STARTED_TIME)
            'Debug.Print "Running time: " & (Timer - STARTED_TIME)
        Else
            shp_Selector.Visible = False ' hide selector.
            ' #020105:
            If load_FILE(currentPATH & sRetCS) Then
                ' check that sRetIP really exists (stack may contain wrong data):
                If theBlockCollection.objectNameExists(sRetIP) Then
                    Set currentRunPointer = theBlockCollection(sRetIP)
                Else
                    mBox "Cannot return to calling function" & vbNewLine & _
                          "Stack contains wrong data for return IP: " & sRetIP
                    ''Set currentRunPointer = Nothing ' Stop execution.
                    TerminateExecution  ' stop program!
                End If
            Else
                mBox "Cannot return to calling function" & vbNewLine & _
                      "Stack contains wrong data for return CS: " & sRetCS
                ''Set currentRunPointer = Nothing ' Stop execution.
                TerminateExecution  ' stop program!
            End If

        End If
        frmVars.setVar "PARAM", frmStack.POP ' [*] return value of previous function's param.
       
    Case Else
        mBox "timerRunner_Timer(). UNKNOWN ACTION!: " & currentRunPointer.zAction
        TerminateExecution  ' stop program!
    End Select
    
    ' this is done twice in this sub:
    setSelector currentRunPointer
    
    
    ' #020105:
    If Not (currentRunPointer Is Nothing) Then
        ' #020104:
        ' the eternal delay?
        If scroll_ExecutionDelay.Value = scroll_ExecutionDelay.Max Then
            chkPause.Value = vbChecked
        End If
    End If
    
    '========= error catcher:
    Exit Sub
err1:
    mBox "timerRunner_Timer(). ERROR CATCHED: " & vbNewLine _
               & "Source: " & Err.Source & vbNewLine _
               & "Description: " & Err.Description & vbNewLine _
               & "Error number: " & Err.Number
               
    TerminateExecution  ' stop program!
End Sub

Public Sub setSelector(cb As cBlock)
    If cb Is Nothing Then Exit Sub
    
    If Not bGUI Then Exit Sub
    
  '' optimized for speed:
    
'    shp_Selector.Left = cb.theObjectShape.Left - 2
'    shp_Selector.Top = cb.theObjectShape.Top - 2
'    shp_Selector.Width = cb.theObjectShape.Width + 5
'    shp_Selector.Height = cb.theObjectShape.Height + 5
    
    shp_Selector.Move cb.theObjectShape.Left - 2, _
                      cb.theObjectShape.Top - 2, _
                      cb.theObjectShape.Width + 5, _
                      cb.theObjectShape.Height + 5
    
    If shp_Selector.Visible = False Then
        shp_Selector.Visible = True
    End If
End Sub

' unload and close all forms:
Private Sub Form_Unload(Cancel As Integer)
    If Not Check_If_Saved Then Exit Sub
    
    Terminate_APPLICATION
End Sub


Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim mb As cBlock
    
    Select Case sTOOLBAR_CLICK
        Case "START"
            Set mb = theBlockCollection.AddShape(2, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 70
            mb.shapeHeight = 30
            mb.zAction = "START"
            mb.zParam1 = ""         ' used to store the list of local variables.
            mb.setCaptionToAction
            
            
        Case "ACTION"
            Set mb = theBlockCollection.AddShape(0, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 70
            mb.shapeHeight = 30
            frmDlgAction.Show 1, Me
        
        Case "INPUT"
            ' will be a parallelogram:
            Set mb = theBlockCollection.AddShape(91, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 90
            mb.shapeHeight = 40
            frmDlgInput.Show 1, Me
            
        Case "OUTPUT"
            ' will be a parallelogram:
            Set mb = theBlockCollection.AddShape(91, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 90
            mb.shapeHeight = 40
            frmDlgOutput.Show 1, Me
            
        Case "JUNCTION"
            ' will be a diamond:
            Set mb = theBlockCollection.AddShape(92, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 112
            mb.shapeHeight = 50
            frmDlgIf.Show 1, Me
        
        Case "INTERSECTION"
            ' will be a small circle:
            Set mb = theBlockCollection.AddShape(3, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 10
            mb.shapeHeight = 10
            mb.zAction = "INTERSECTION"
        
        Case "FUNCTION"
            Set mb = theBlockCollection.AddShape(93, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 90
            mb.shapeHeight = 40
            frmDlgFunction.Show 1, Me
            
        Case "WINDOW"
            Set mb = theBlockCollection.AddShape(0, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 90
            mb.shapeHeight = 40
            frmDlgWindow.Show 1, Me
            Unload frmDlgWindow
            
        Case "END"
            Set mb = theBlockCollection.AddShape(2, theBlockCollection.getFreeTagID(), X, Y)
            mb.shapeWidth = 70
            mb.shapeHeight = 30
            mb.zAction = "STOP"
            mb.setCaptionToAction
            
        Case ""
            ' OK, nothing selected, user just clicks over the form.
            Exit Sub
        Case Else
            Debug.Print "ERROR: sTOOLBAR_CLICK = " & sTOOLBAR_CLICK
            Exit Sub
    End Select
    
    sTOOLBAR_CLICK = ""
    Me.MousePointer = vbDefault


    ' in case "OK" is clicked, repaint and set selector;
    '   in case dialog box closed by [x] remove the object:
    If mb.zAction <> "" Then
        mb.theObjectShape.RepaintBlock
        setSelector mb
    Else
        theBlockCollection.removeShape mb.theObjectShape.Index
    End If
    
    
    
    ' #020105:
    If chkCONTINUED_CONNECTION.Value = vbChecked Then
        bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED = False
        cmdConnect_Click
        bSHOW_MESSAGE_WHEN_ALREADY_CONNECTED = True
    End If
End Sub




' pushes list of variables (var names should be separated by ","):
Private Sub push_LOCAL_vars(sVarList As String)
    Dim i As Integer
    Dim s As String
    
    i = 0
    s = getPar(i, sVarList)
    
    Do While s <> ""
        frmStack.PUSH (frmVars.ifVarGetValue(s))
        i = i + 1
        s = getPar(i, sVarList)
    Loop

    'Debug.Print "Local variables pushed: " & sVarList
End Sub

' pops list of variables (var names should be separated by ","):
'  pop should be made the reversed order from push_LOCAL_vars(),
'  so the list is converted to array first:
Private Sub pop_LOCAL_vars(sVarList As String)
    Dim arr() As String
    ' counter is used, since UBound/LBound caused problems:
    Dim iCounter As Integer
    Dim i As Integer
    Dim s As String
    
    ' =========== convert to array:
    i = 0
    s = getPar(i, sVarList)
    
    Do While s <> ""
        ReDim Preserve arr(0 To i)
        arr(i) = s
        i = i + 1
        s = getPar(i, sVarList)
    Loop

    iCounter = i    ' number of variables in the list.

    ' ========= do POP (backwards from PUSH):
    For i = iCounter - 1 To 0 Step -1
        frmVars.setVar arr(i), frmStack.POP
    Next i

    'Debug.Print "Local variables poped: " & sVarList
End Sub


' make frmScreen receive keyboard even if frmMain is active:
Private Sub Form_KeyPress(KeyAscii As Integer)
    frmScreen.processKey KeyAscii
End Sub

Private Sub mnuMakeExecutable_Click()
    frmMakeExecutable.Show 1, Me
End Sub
