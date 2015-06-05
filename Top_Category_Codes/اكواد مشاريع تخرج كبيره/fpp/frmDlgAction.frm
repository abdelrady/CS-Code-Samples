VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmDlgAction 
   Caption         =   "Action"
   ClientHeight    =   2925
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5385
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2925
   ScaleWidth      =   5385
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   465
      Left            =   4335
      TabIndex        =   0
      Top             =   2415
      Width           =   915
   End
   Begin VB.Frame frame 
      Height          =   1890
      Index           =   1
      Left            =   90
      TabIndex        =   15
      Top             =   420
      Width           =   5160
      Begin VB.TextBox txtVarValue 
         Height          =   330
         Left            =   1380
         TabIndex        =   12
         Top             =   1080
         Width           =   3555
      End
      Begin VB.ComboBox cboxVarName 
         Height          =   315
         ItemData        =   "frmDlgAction.frx":0000
         Left            =   1380
         List            =   "frmDlgAction.frx":0002
         TabIndex        =   11
         Top             =   435
         Width           =   3555
      End
      Begin VB.Label lblDefValue 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Value:"
         Height          =   195
         Left            =   195
         TabIndex        =   17
         Top             =   1148
         Width           =   450
      End
      Begin VB.Label lblDefVarName 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Variable name:"
         Height          =   195
         Left            =   150
         TabIndex        =   16
         Top             =   495
         Width           =   1050
      End
   End
   Begin VB.Frame frame 
      Height          =   1890
      Index           =   4
      Left            =   90
      TabIndex        =   23
      Top             =   420
      Visible         =   0   'False
      Width           =   5160
      Begin VB.TextBox txtSQL 
         Height          =   1140
         Left            =   90
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   14
         Text            =   "frmDlgAction.frx":0004
         Top             =   600
         Width           =   4980
      End
      Begin VB.ComboBox cboxDatabase 
         Height          =   315
         ItemData        =   "frmDlgAction.frx":0012
         Left            =   2595
         List            =   "frmDlgAction.frx":0019
         TabIndex        =   13
         Top             =   180
         Width           =   2385
      End
      Begin VB.Label lblDBname 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "data base:"
         Height          =   195
         Left            =   1740
         TabIndex        =   25
         Top             =   240
         Width           =   750
      End
      Begin VB.Label lblSQL 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "SQL code:"
         Height          =   195
         Left            =   165
         TabIndex        =   24
         Top             =   360
         Width           =   780
      End
   End
   Begin VB.Frame frame 
      Height          =   1890
      Index           =   3
      Left            =   90
      TabIndex        =   2
      Top             =   420
      Visible         =   0   'False
      Width           =   5160
      Begin VB.ComboBox cboxStringOperation 
         BeginProperty Font 
            Name            =   "Fixedsys"
            Size            =   9.75
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         ItemData        =   "frmDlgAction.frx":002B
         Left            =   2040
         List            =   "frmDlgAction.frx":0035
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   465
         Width           =   1005
      End
      Begin VB.ComboBox cboxString2 
         Height          =   315
         Left            =   3165
         TabIndex        =   5
         Top             =   465
         Width           =   1720
      End
      Begin VB.ComboBox cboxString1 
         Height          =   315
         Left            =   90
         TabIndex        =   3
         Top             =   465
         Width           =   1720
      End
      Begin VB.ComboBox cboxStringResult 
         Height          =   315
         ItemData        =   "frmDlgAction.frx":0042
         Left            =   1395
         List            =   "frmDlgAction.frx":0044
         TabIndex        =   6
         Top             =   1365
         Width           =   2535
      End
      Begin VB.Label lblString1 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "String 1"
         Height          =   195
         Left            =   705
         TabIndex        =   29
         Top             =   195
         Width           =   540
      End
      Begin VB.Label lblString2 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "String 2"
         Height          =   195
         Left            =   3750
         TabIndex        =   28
         Top             =   210
         Width           =   540
      End
      Begin VB.Label lblStringOperation 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "operation"
         Height          =   195
         Left            =   2160
         TabIndex        =   27
         Top             =   210
         Width           =   660
      End
      Begin VB.Label lblStringResult 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Store result in:"
         Height          =   195
         Left            =   1890
         TabIndex        =   26
         Top             =   1065
         Width           =   1020
      End
   End
   Begin VB.Frame frame 
      Height          =   1890
      Index           =   2
      Left            =   90
      TabIndex        =   18
      Top             =   420
      Visible         =   0   'False
      Width           =   5160
      Begin VB.ComboBox cboxResult 
         Height          =   315
         ItemData        =   "frmDlgAction.frx":0046
         Left            =   1395
         List            =   "frmDlgAction.frx":0048
         TabIndex        =   10
         Top             =   1365
         Width           =   2130
      End
      Begin VB.ComboBox cboxOperand1 
         Height          =   315
         Left            =   90
         TabIndex        =   7
         Top             =   465
         Width           =   1920
      End
      Begin VB.ComboBox cboxOperand2 
         Height          =   315
         Left            =   3075
         TabIndex        =   9
         Top             =   465
         Width           =   1920
      End
      Begin VB.ComboBox cboxOperation 
         BeginProperty Font 
            Name            =   "Fixedsys"
            Size            =   9.75
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         ItemData        =   "frmDlgAction.frx":004A
         Left            =   2040
         List            =   "frmDlgAction.frx":005A
         Style           =   2  'Dropdown List
         TabIndex        =   8
         Top             =   465
         Width           =   1005
      End
      Begin VB.Label lblMathResult 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Store result in:"
         Height          =   195
         Left            =   1890
         TabIndex        =   22
         Top             =   1065
         Width           =   1020
      End
      Begin VB.Label lblMathOperation 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "operation"
         Height          =   195
         Left            =   2160
         TabIndex        =   21
         Top             =   210
         Width           =   660
      End
      Begin VB.Label lblMathOp2 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Operand 2"
         Height          =   195
         Left            =   3615
         TabIndex        =   20
         Top             =   210
         Width           =   750
      End
      Begin VB.Label lblMathOp1 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Operand 1"
         Height          =   195
         Left            =   600
         TabIndex        =   19
         Top             =   195
         Width           =   750
      End
   End
   Begin MSComctlLib.TabStrip TabStrip1 
      Height          =   2325
      Left            =   30
      TabIndex        =   1
      Top             =   60
      Width           =   5295
      _ExtentX        =   9340
      _ExtentY        =   4101
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   4
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Definition"
            Key             =   "DEFINITION"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab2 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Arithmetic Operation"
            Key             =   "ARITHMETIC"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab3 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "String Operations"
            Key             =   "STRINGS"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab4 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "SQL operation"
            Key             =   "SQL"
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmDlgAction"
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
' Dialog to set Action
' =========================================================

Option Explicit

Dim currentlySelected As Integer

'============ resize constrains:
Dim rc_TabStrip1_width As Single
Dim rc_TabStrip1_height As Single

Dim rc_cmdOK_left As Single
Dim rc_cmdOK_top As Single

Dim rc_frame_width As Single
Dim rc_frame_height As Single


Private Sub Form_Activate()
    frmLists.fillCombo_var_val cboxVarName

    frmLists.fillCombo_var_val cboxOperand1
    frmLists.fillCombo_var_val cboxOperand2
    frmLists.fillCombo_var_val cboxResult
    
    frmLists.fillCombo_var_val cboxString1
    frmLists.fillCombo_var_val cboxString2
    frmLists.fillCombo_var_val cboxStringResult
End Sub

Private Sub processRecentVarNames()
    frmLists.addRecentVarVal cboxVarName.Text

    frmLists.addRecentVarVal cboxOperand1.Text
    frmLists.addRecentVarVal cboxOperand2.Text
    frmLists.addRecentVarVal cboxResult.Text

    frmLists.addRecentVarVal cboxString1.Text
    frmLists.addRecentVarVal cboxString2.Text
    frmLists.addRecentVarVal cboxStringResult.Text
End Sub

Private Sub cmdOK_Click()

    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
    
        If TabStrip1.SelectedItem.Key = "DEFINITION" Then
            .zAction = "DEFINITION"
            .zParam1 = cboxVarName.Text
            .zParam2 = txtVarValue.Text
            
        ElseIf TabStrip1.SelectedItem.Key = "ARITHMETIC" Then
            If cboxOperation.Text = "+" Then  ' ADD
                .zAction = "ADD"
            ElseIf cboxOperation.Text = "-" Then  ' SUBTRACT
                .zAction = "SUBTRACT"
            ElseIf cboxOperation.Text = "*" Then  ' MULTIPLY
                .zAction = "MULTIPLY"
            ElseIf cboxOperation.Text = "/" Then  ' DIVIDE
                .zAction = "DIVIDE"
            End If
            .zParam1 = cboxOperand1.Text
            .zParam2 = cboxOperand2.Text
            .zParam3 = cboxResult.Text
            
            
        ElseIf TabStrip1.SelectedItem.Key = "STRINGS" Then
            If cboxStringOperation.Text = "&" Then  ' Join Strings.
                .zAction = "JOIN"
            ElseIf cboxStringOperation.Text = "COMP" Then  ' Compare Strings.
                .zAction = "COMP"
            End If
            .zParam1 = cboxString1.Text
            .zParam2 = cboxString2.Text
            .zParam3 = cboxStringResult.Text


        ElseIf TabStrip1.SelectedItem.Key = "SQL" Then
            .zAction = "SQL"
            .zParam1 = cboxDatabase.Text
            .zParam2 = txtSQL.Text
            
        End If
        
        .setCaptionToAction
    End With
    
    Me.Hide
    
    processRecentVarNames
    
    bIS_MODIFIED = True
End Sub

Private Sub Form_Load()
    currentlySelected = 1   ' selected tab.
    
    cboxOperation.ListIndex = 0
    cboxStringOperation.ListIndex = 0
    
    Me.Icon = frmMain.Icon
    
    '============ set resize constrains:
    rc_TabStrip1_width = Me.ScaleWidth - TabStrip1.Width
    rc_TabStrip1_height = Me.ScaleHeight - TabStrip1.Height
    
    rc_cmdOK_left = Me.ScaleWidth - cmdOK.Left
    rc_cmdOK_top = Me.ScaleHeight - cmdOK.Top
    
    ' all frames have the same width/height
    rc_frame_width = Me.ScaleWidth - frame(1).Width
    rc_frame_height = Me.ScaleHeight - frame(1).Height
End Sub

Private Sub Form_Resize()
    On Error GoTo err1
    
    Dim i As Integer
    
    '============ re-set resize constrains:
    TabStrip1.Width = Me.ScaleWidth - rc_TabStrip1_width
    TabStrip1.Height = Me.ScaleHeight - rc_TabStrip1_height
    
    cmdOK.Left = Me.ScaleWidth - rc_cmdOK_left
    cmdOK.Top = Me.ScaleHeight - rc_cmdOK_top
    
    For i = frame.LBound To frame.UBound
        frame(i).Width = Me.ScaleWidth - rc_frame_width
        frame(i).Height = Me.ScaleHeight - rc_frame_height
    Next i
    
    ' //// other controls are calculated relative to frames:
    
    ' ////////// data base tab:
    ' the same space from left & right:
    txtSQL.Width = frame(4).Width - txtSQL.Left * 2
    txtSQL.Height = frame(4).Height - txtSQL.Top - 60
    'lblDBname.Left = frame(4).Width - lblDBname.Width - 90
    cboxDatabase.Width = frame(4).Width - cboxDatabase.Left - 90
    
    ' ////////  definition tab:
    'lblDefVarName.Left =  - lblDefVarName.Width - 90
    cboxVarName.Width = frame(1).Width - cboxVarName.Left - 90
    ' the same as upper objects:
    'lblDefValue.Left = lblDefVarName.Left
    txtVarValue.Width = frame(1).Width - cboxVarName.Left - 90
    
    
    
    ' //////// math tab:
    ' what's left divide by 2:
    cboxOperand1.Width = (frame(2).Width - cboxOperation.Width - cboxOperand1.Left - 90 * 3) / 2
    cboxOperand2.Width = cboxOperand1.Width
    cboxOperation.Left = cboxOperand1.Left + cboxOperand1.Width + 90
    cboxOperand2.Left = cboxOperation.Left + cboxOperation.Width + 90
    cboxResult.Width = frame(2).Width / 2
    ' center it:
    cboxResult.Left = frame(2).Width / 2 - cboxResult.Width / 2
    ' labels (just center them above the controls):
    lblMathOp1.Left = cboxOperand1.Left + cboxOperand1.Width / 2 - lblMathOp1.Width / 2
    lblMathOp2.Left = cboxOperand2.Left + cboxOperand2.Width / 2 - lblMathOp2.Width / 2
    lblMathOperation.Left = cboxOperation.Left + cboxOperation.Width / 2 - lblMathOperation.Width / 2
    lblMathResult.Left = cboxResult.Left + cboxResult.Width / 2 - lblMathResult.Width / 2
    
    
    ' //////// strings tab:
    ' the same as math tab:
    cboxString1.Width = cboxOperand1.Width
    cboxString2.Width = cboxOperand2.Width
    cboxStringOperation.Left = cboxOperation.Left
    cboxString2.Left = cboxOperand2.Left
    cboxStringResult.Width = cboxResult.Width
    cboxStringResult.Left = cboxResult.Left
    lblString1.Left = lblMathOp1.Left
    lblString2.Left = lblMathOp2.Left
    lblStringOperation.Left = lblMathOperation.Left
    lblStringResult.Left = lblMathResult.Left
    
    
    Exit Sub
err1:
    Debug.Print "Error on frmDlgAction_Resize() ->" & Err.Description
End Sub

Private Sub TabStrip1_Click()
       
   If TabStrip1.SelectedItem.Index > 0 Then
       frame(currentlySelected).Visible = False
       currentlySelected = TabStrip1.SelectedItem.Index
       frame(currentlySelected).Visible = True
   End If
    
End Sub
