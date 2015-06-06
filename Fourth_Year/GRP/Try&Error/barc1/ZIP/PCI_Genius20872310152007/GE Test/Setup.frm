VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Setup 
   Caption         =   "Setup PCGEN Card"
   ClientHeight    =   2655
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   3405
   LinkTopic       =   "Form1"
   ScaleHeight     =   2655
   ScaleWidth      =   3405
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox lblDevice 
      Alignment       =   2  'Center
      Height          =   345
      Left            =   510
      TabIndex        =   12
      Text            =   "--Device--"
      Top             =   30
      Width           =   2175
   End
   Begin VB.Frame Frame2 
      Caption         =   "Outputs Control"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   90
      TabIndex        =   9
      Top             =   1110
      Width           =   1635
      Begin VB.OptionButton Opt_OC_Enabled 
         Caption         =   "Enabled"
         Height          =   285
         Left            =   90
         TabIndex        =   11
         Top             =   270
         Width           =   1200
      End
      Begin VB.OptionButton Opt_OC_Disabled 
         Caption         =   "Disabled"
         Height          =   285
         Left            =   90
         TabIndex        =   10
         Top             =   600
         Value           =   -1  'True
         Width           =   1200
      End
   End
   Begin VB.CommandButton Setup_OK 
      Caption         =   "OK"
      Height          =   465
      Left            =   1200
      TabIndex        =   8
      Top             =   2130
      Width           =   975
   End
   Begin VB.Frame Frame1 
      Caption         =   "Baud Rate"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1635
      Left            =   1770
      TabIndex        =   3
      Top             =   450
      Width           =   1515
      Begin VB.OptionButton Opt_153p6STD 
         Caption         =   "153.6k STD"
         Height          =   285
         Left            =   150
         TabIndex        =   7
         Top             =   270
         Value           =   -1  'True
         Width           =   1200
      End
      Begin VB.OptionButton Opt_153p6EXT 
         Caption         =   "153.6k EXT"
         Height          =   285
         Left            =   150
         TabIndex        =   6
         Top             =   600
         Width           =   1200
      End
      Begin VB.OptionButton Opt_76p8 
         Caption         =   "76.8k"
         Height          =   285
         Left            =   150
         TabIndex        =   5
         Top             =   930
         Width           =   1200
      End
      Begin VB.OptionButton Opt_38p4 
         Caption         =   "38.4k"
         Height          =   285
         Left            =   150
         TabIndex        =   4
         Top             =   1260
         Width           =   1200
      End
   End
   Begin MSComCtl2.UpDown NumSBA_UpDown 
      Height          =   405
      Left            =   1080
      TabIndex        =   0
      Top             =   510
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   714
      _Version        =   393216
      Enabled         =   -1  'True
   End
   Begin VB.TextBox NumSBA 
      Height          =   435
      Left            =   510
      TabIndex        =   1
      Text            =   "0"
      Top             =   480
      Width           =   855
   End
   Begin VB.Label lblSBA 
      Caption         =   "SBA"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   60
      TabIndex        =   2
      Top             =   570
      Width           =   450
   End
End
Attribute VB_Name = "Setup"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    If GENI_LocateCard(0) = GENI_NoError Then
        lblDevice.Text = cGEGENIUS
    Else
        frmMain.Show
        Unload Me
    End If
'If we get here, Card exists - Load Offset Constants to an array for easier use
    SRI_Device_Config_Offset(0) = SRI_SBA00_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(1) = SRI_SBA01_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(2) = SRI_SBA02_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(3) = SRI_SBA03_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(4) = SRI_SBA04_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(5) = SRI_SBA05_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(6) = SRI_SBA06_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(7) = SRI_SBA07_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(8) = SRI_SBA08_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(9) = SRI_SBA09_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(10) = SRI_SBA10_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(11) = SRI_SBA11_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(12) = SRI_SBA12_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(13) = SRI_SBA13_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(14) = SRI_SBA14_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(15) = SRI_SBA15_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(16) = SRI_SBA16_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(17) = SRI_SBA17_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(18) = SRI_SBA18_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(19) = SRI_SBA19_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(20) = SRI_SBA20_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(21) = SRI_SBA21_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(22) = SRI_SBA22_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(23) = SRI_SBA23_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(24) = SRI_SBA24_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(25) = SRI_SBA25_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(26) = SRI_SBA26_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(27) = SRI_SBA27_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(28) = SRI_SBA28_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(29) = SRI_SBA29_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(30) = SRI_SBA30_DEVICE_CONFIG_OFFSET
    SRI_Device_Config_Offset(31) = SRI_SBA31_DEVICE_CONFIG_OFFSET
    SRI_Device_IO_Table_Offset(0) = SRI_SBA00_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(1) = SRI_SBA01_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(2) = SRI_SBA02_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(3) = SRI_SBA03_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(4) = SRI_SBA04_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(5) = SRI_SBA05_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(6) = SRI_SBA06_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(7) = SRI_SBA07_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(8) = SRI_SBA08_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(9) = SRI_SBA09_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(10) = SRI_SBA10_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(11) = SRI_SBA11_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(12) = SRI_SBA12_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(13) = SRI_SBA13_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(14) = SRI_SBA14_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(15) = SRI_SBA15_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(16) = SRI_SBA16_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(17) = SRI_SBA17_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(18) = SRI_SBA18_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(19) = SRI_SBA19_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(20) = SRI_SBA20_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(21) = SRI_SBA21_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(22) = SRI_SBA22_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(23) = SRI_SBA23_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(24) = SRI_SBA24_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(25) = SRI_SBA25_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(26) = SRI_SBA26_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(27) = SRI_SBA27_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(28) = SRI_SBA28_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(29) = SRI_SBA29_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(30) = SRI_SBA30_DEVICE_IO_TABLE_OFFSET
    SRI_Device_IO_Table_Offset(31) = SRI_SBA31_DEVICE_IO_TABLE_OFFSET
End Sub
Private Sub NumSBA_UpDown_Change()
    If Val(NumSBA.Text) < 0 Then
        NumSBA.Text = 0
    ElseIf Val(NumSBA.Text) > 31 Then
        NumSBA.Text = 31
    End If
End Sub
Private Sub NumSBA_UpDown_DownClick()
    If Val(NumSBA.Text) > 0 Then
        NumSBA.Text = Val(NumSBA.Text) - 1
    End If
End Sub
Private Sub NumSBA_UpDown_UpClick()
    If Val(NumSBA.Text) < 31 Then
        NumSBA.Text = Val(NumSBA.Text) + 1
    End If
End Sub
Private Sub Opt_153p6EXT_Click()
    With Opt_153p6EXT
        .Value = Not .Value
        Opt_153p6STD.Value = Not .Value
        Opt_38p4.Value = Not .Value
        Opt_76p8.Value = Not .Value
    End With 'Opt_153p6EXT
End Sub
Private Sub Opt_153p6STD_Click()
    With Opt_153p6STD
        .Value = Not .Value
        Opt_153p6EXT.Value = Not .Value
        Opt_38p4.Value = Not .Value
        Opt_76p8.Value = Not .Value
    End With 'Opt_153p6STD
End Sub
Private Sub Opt_38p4_Click()
    With Opt_38p4
        .Value = Not .Value
        Opt_153p6STD.Value = Not .Value
        Opt_153p6EXT.Value = Not .Value
        Opt_76p8.Value = Not .Value
    End With 'Opt_38p4
End Sub
Private Sub Opt_76p8_Click()
    With Opt_76p8
        .Value = Not .Value
        Opt_38p4.Value = Not .Value
        Opt_153p6STD.Value = Not .Value
        Opt_153p6EXT.Value = Not .Value
    End With 'Opt_76p8
End Sub
Private Sub Opt_OC_Disabled_Click()
    Opt_OC_Disabled.Value = Not Opt_OC_Disabled.Value
    Opt_OC_Enabled.Value = Not Opt_OC_Disabled.Value
End Sub
Private Sub Opt_OC_Enabled_Click()
    Opt_OC_Enabled.Value = Not Opt_OC_Enabled.Value
    Opt_OC_Disabled.Value = Not Opt_OC_Enabled.Value
End Sub
Private Sub Setup_OK_Click()
    If Opt_OC_Enabled.Value Then
        Outputs = OutputsEnabled
    ElseIf Opt_OC_Disabled.Value Then
        Outputs = Outputsdisabled
    End If
    If Opt_153p6STD.Value Then
        BaudRate = baud_153p6kstd
    ElseIf Opt_153p6EXT.Value Then
        BaudRate = Baud_153p6kEXT
    ElseIf Opt_76p8.Value Then
        BaudRate = Baud_76p8k
    ElseIf Opt_38p4.Value Then
        BaudRate = Baud_38p4k
    End If
    Node = Val(NumSBA.Text)
    CardSetup Outputs, BaudRate, Node
    frmMain.Show
    Unload Me
End Sub
