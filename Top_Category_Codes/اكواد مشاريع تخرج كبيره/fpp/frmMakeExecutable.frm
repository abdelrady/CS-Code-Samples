VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmMakeExecutable 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Creation of an Executable File"
   ClientHeight    =   1485
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1485
   ScaleWidth      =   6000
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdGetStartFlow 
      Caption         =   "..."
      Height          =   315
      Left            =   5535
      TabIndex        =   4
      Top             =   435
      Width           =   375
   End
   Begin VB.TextBox txtStartUpFlow 
      Height          =   330
      Left            =   75
      TabIndex        =   3
      Top             =   435
      Width           =   5385
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   480
      Top             =   870
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Close"
      Height          =   450
      Left            =   3960
      TabIndex        =   1
      Top             =   930
      Width           =   1005
   End
   Begin VB.CommandButton cmdMake 
      Caption         =   "Create"
      Height          =   450
      Left            =   2820
      TabIndex        =   0
      Top             =   930
      Width           =   1005
   End
   Begin VB.Label lblStartUpFlow 
      AutoSize        =   -1  'True
      Caption         =   "Select Start-up flow:"
      Height          =   195
      Left            =   135
      TabIndex        =   2
      Top             =   105
      Width           =   1425
   End
End
Attribute VB_Name = "frmMakeExecutable"
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


Private Sub cmdGetStartFlow_Click()
On Error GoTo Canceled

    CommonDialog1.InitDir = App.Path ' 1.88

    CommonDialog1.Flags = cdlOFNHideReadOnly
    CommonDialog1.Filter = "Flow Program Projects (*.fpp)|*.fpp|All Files|*.*"
    CommonDialog1.DefaultExt = "fpp"
    CommonDialog1.CancelError = True
    CommonDialog1.ShowOpen

    txtStartUpFlow.Text = CommonDialog1.FileName

    Exit Sub
Canceled:
    Debug.Print "cmdGetStartFlow_Click: " & Err.Description
End Sub

Private Sub Form_Load()
    Me.Icon = frmMain.Icon
End Sub

'1.88
'''Private Sub Form_Activate()
'''   '1.88 Dim i As Integer
'''
'''
'''    ' load all filenames from file list
'''    '  box to combo:
'''
'''    '1.88 cmbStartUpFlow.Clear
'''
'''    ' #020105:
'''    '1.88FileBoxFPP.Path = currentPATH 'd: App.Path
'''    '1.88FileBoxFPP.Refresh
'''
'''    ' no need to continue if it's zero:
'''    '1.88If FileBoxFPP.ListCount <= 0 Then Exit Sub
'''
'''    '1.88For i = 0 To FileBoxFPP.ListCount - 1
'''    '1.88    cmbStartUpFlow.AddItem FileBoxFPP.List(i)
'''    '1.88Next i
'''
'''End Sub



Private Sub cmdMake_Click()
On Error GoTo error_making_exe
    
    Dim sNewFileName As String
    Dim sStartUpFlow As String


    sStartUpFlow = txtStartUpFlow.Text
    
    sStartUpFlow = Trim(sStartUpFlow)

    If sStartUpFlow = "" Then
        MsgBox "Select start-up flow!"
        Exit Sub
    End If
    
    sNewFileName = get_FileName_for_Executable '1.88txtFileName.Text
    
    
    If sNewFileName = "" Then Exit Sub ' canceled
    

    
    ' copy the actual program file into another file:
    ' #020105:
    FileCopy AddSlash(App.Path) & App.EXEName & ".exe", sNewFileName ' 1.88 & ".exe"
    
    ' make an INI file for that file:
    setDefaultINISettings
    setINISetting "SHOULD_ASSOCIATE", "ASSOCIATE_IF_REQUIRED=NO"
    setINISetting "START_UP_FLOW", ExtractFileName(sStartUpFlow)
    
    ' #020105:
    
    ' remove ".exe"
    sNewFileName = Mid(sNewFileName, 1, Len(sNewFileName) - 4)
    
    SaveINISettingsToFile sNewFileName & ".ini"
    
    
    
    Me.Hide
    
    Exit Sub
error_making_exe:
    mBox "Error making executable: " & vbNewLine & _
        Err.Description, Me
End Sub



Private Sub cmdCancel_Click()
    Me.Hide
End Sub

' 1.88
Private Function get_FileName_for_Executable()
On Error GoTo Canceled

    CommonDialog1.InitDir = App.Path ' 1.88
    
    CommonDialog1.FileName = "Program1.exe"

    CommonDialog1.Flags = cdlOFNHideReadOnly + cdlOFNOverwritePrompt
    CommonDialog1.Filter = "Executable Files (*.exe)|*.exe|All Files|*.*"
    CommonDialog1.DefaultExt = "exe"
    CommonDialog1.CancelError = True
    CommonDialog1.ShowSave

    get_FileName_for_Executable = CommonDialog1.FileName
    
    Exit Function
Canceled:
    get_FileName_for_Executable = ""
End Function
