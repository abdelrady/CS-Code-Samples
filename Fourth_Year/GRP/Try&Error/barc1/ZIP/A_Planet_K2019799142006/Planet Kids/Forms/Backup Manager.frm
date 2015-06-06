VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form fBackupManager 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   4965
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4680
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Backup Manager.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4965
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton cmdBackup 
      Caption         =   "8"
      Default         =   -1  'True
      Height          =   390
      Left            =   285
      TabIndex        =   9
      Top             =   3900
      Width           =   2685
   End
   Begin VB.CommandButton cmdBackupPath 
      Caption         =   "6"
      Height          =   375
      Left            =   1410
      TabIndex        =   8
      Top             =   2445
      Width           =   2625
   End
   Begin VB.CommandButton cmdRestore 
      Caption         =   "7"
      Height          =   390
      Left            =   285
      TabIndex        =   6
      Top             =   3465
      Width           =   2685
   End
   Begin VB.CommandButton cmdClose 
      Cancel          =   -1  'True
      Caption         =   "9"
      Height          =   825
      Left            =   3015
      TabIndex        =   5
      Top             =   3465
      Width           =   1380
   End
   Begin MSComCtl2.DTPicker dtpBackup 
      Height          =   375
      Left            =   1410
      TabIndex        =   4
      Top             =   1830
      Width           =   2625
      _ExtentX        =   4630
      _ExtentY        =   661
      _Version        =   393216
      CustomFormat    =   "MMMM dd, yyyy"
      Format          =   20643843
      CurrentDate     =   38967
   End
   Begin VB.OptionButton optBackup 
      Caption         =   "4"
      Height          =   270
      Index           =   2
      Left            =   570
      TabIndex        =   3
      Top             =   1440
      Width           =   3480
   End
   Begin VB.OptionButton optBackup 
      Caption         =   "3"
      Height          =   270
      Index           =   1
      Left            =   570
      TabIndex        =   2
      Top             =   1035
      Width           =   3480
   End
   Begin VB.OptionButton optBackup 
      Caption         =   "2"
      Height          =   270
      Index           =   0
      Left            =   570
      TabIndex        =   1
      Top             =   660
      Value           =   -1  'True
      Width           =   3480
   End
   Begin VB.Label lblBackup 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "10"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   195
      Index           =   1
      Left            =   2250
      TabIndex        =   10
      Top             =   4530
      Width           =   180
   End
   Begin VB.Label lblPath 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      Height          =   240
      Left            =   840
      TabIndex        =   7
      Top             =   2520
      Width           =   105
   End
   Begin VB.Label lblBackup 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   0
      Left            =   2370
      TabIndex        =   0
      Top             =   210
      Width           =   120
   End
   Begin VB.Shape Shape1 
      Height          =   2865
      Left            =   285
      Shape           =   4  'Rounded Rectangle
      Top             =   330
      Width           =   4110
   End
End
Attribute VB_Name = "fBackupManager"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdBackup_Click()
    On Error GoTo Cancel_Error
    
    With fMain.cdgMain
        .CancelError = True
        .DefaultExt = "mdb"
        .DialogTitle = cINI.Value("FormString", Me.Name & "11")
        .FileName = Format$(Date$, "mmm dd yyyy") & ".mdb"
        .Filter = cINI.Value("FormString", Me.Name & "12")
        .InitDir = cINI.Value("Settings", "Path_Backup", App.Path & "\Backup\")
         
         If (InStr(1, .InitDir, ":") = 0) Then
            .InitDir = App.Path & "\" & .InitDir
         End If
         
         ' Show save file dialog
        .ShowSave
        
        ' Disconnect to database first so that we can backup the file successfully
        mPublic.DatabaseDisconnect
        
        Dim sPath As String
            sPath = cINI.Value("Settings", "Path_Database")
            
            If (InStr(1, sPath, ":") = 0) Then
                sPath = App.Path & "\" & sPath
            End If
            
        ' Simple file copy is enough
        FileCopy sPath, .FileName
        
        cINI.Value("Settings", "Last_BackupDate") = Format$(Date$, "mmm dd yyyy") ' Save backup date
        MsgBoxEx Me.Name & "0", vbInformation
        
        ' Reconnect to database after a successful backup
        If (Not mPublic.DatabaseConnect(True)) Then
            MsgBoxEx Me.Name & "1", vbCritical
            Unload Me
        End If
    End With
    
Cancel_Error:
End Sub

Private Sub cmdBackupPath_Click()
    Dim sPath As String
        sPath = cmdBackupPath.Caption
        
        If (InStr(1, sPath, ":") = 0) Then
            sPath = App.Path & "\" & sPath
        End If
        
        sPath = mBrowseForFolder.BrowseForFolder(Me.Hwnd, "Select Backup Directory:", sPath, True)
        
        If (Len(sPath) > 0) Then
            cmdBackupPath.Caption = Replace$(sPath, App.Path & "\", "", 1, 1, vbTextCompare)
        End If
        
End Sub

Private Sub cmdClose_Click()
    Unload Me
    
End Sub

Private Sub cmdRestore_Click()
    On Error GoTo Err_Handler
    
    Dim iRet As VbMsgBoxResult
        iRet = MsgBoxEx(Me.Name & "2", vbExclamation + vbYesNoCancel + vbDefaultButton2)
        
    If (Not iRet = vbYes) Then
        Exit Sub
    End If
    
    With fMain.cdgMain
        .CancelError = True
        .DefaultExt = "mdb"
        .DialogTitle = cINI.Value("FormStrings", Me.Name & "13")
        .FileName = ""
        .Filter = cINI.Value("FormStrings", Me.Name & "14")
        .InitDir = cINI.Value("Settings", "Path_Backup", App.Path & "\Backup\")
         
         If (InStr(1, .InitDir, ":") = 0) Then
            .InitDir = App.Path & "\" & .InitDir
         End If
         
         ' Show open file dialog
        .ShowOpen
        
        Dim sPath As String
            sPath = cINI.Value("Settings", "Path_Database")
            
        ' Disconnect to current database so that we can use the selected database file
        mPublic.DatabaseDisconnect
        
        On Error Resume Next
        
        Err.Clear
        FileCopy .FileName, sPath ' Overwrite current database with the restored file
        
        If (Not Err.Number = 0) Then
            MsgBoxEx Me.Name & "3", vbExclamation
            mPublic.DatabaseConnect True ' Attempt to reconnect to previous database
            Exit Sub
        End If
        
        ' Connect to selected database
        If (Not mPublic.DatabaseConnect) Then
            If (MsgBoxEx(Me.Name & "4", vbExclamation + vbOKCancel) = vbOK) Then
                
                cINI.Value("Settings", "Path_Database") = sPath
                
                If (Not mPublic.DatabaseConnect) Then
                    MsgBoxEx Me.Name & "5", vbCritical
                    Unload Me
                End If
                
            End If
        Else
            mPublic.LoadSettings
            mPublic.LoadActiveClients fMain.lsvActive
            mPublic.LoadClientsHistory Date$, fMain.lsvHistory
            mPublic.LoadClientsLists fMain.lsvClients
            
            MsgBoxEx Me.Name & "6", vbInformation
        End If
    End With
    
Err_Handler:
End Sub

Private Sub Form_Load()
    Dim i As Integer
        i = cINI.Value("Settings", "Auto_Backup_Mode")
        
    optBackup(i).Value = True ' Select backup schedule setting
    
    If (Not i = 2) Then
        dtpBackup.Value = Date
    Else
        dtpBackup.Value = CDate(cINI.Value("Settings", "Auto_Backup_Date"))
    End If
    
    BackColor = fMain.BackColor
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                .BackColor = BackColor
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is OptionButton) Then
                .BackColor = BackColor
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            End If
        End With
    Next
    
    cmdBackupPath.Caption = cINI.Value("Settings", "Path_Backup")
    
    Dim dLastBackup As String
        dLastBackup = cINI.Value("Settings", "Last_BackupDate")
    
    If (Len(dLastBackup) > 0) Then
        lblBackup(1) = "Database has been backed up since " & dLastBackup
    End If
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Dim i As Integer
    
    For i = 0 To optBackup.UBound
        If (optBackup(i).Value) Then
            cINI.Value("Settings", "Auto_Backup_Mode") = i ' Save settings
            Exit For
        End If
    Next
    
    cINI.Value("Settings", "Auto_Backup_Date") = FormatDateTime$(dtpBackup.Value, vbShortDate)
    
End Sub
