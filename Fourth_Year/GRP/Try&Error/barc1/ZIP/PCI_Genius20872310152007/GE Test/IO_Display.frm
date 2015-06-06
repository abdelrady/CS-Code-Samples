VERSION 5.00
Begin VB.Form IO_Display 
   Caption         =   "I/O Test"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6210
   LinkTopic       =   "Form1"
   ScaleHeight     =   6795
   ScaleWidth      =   6210
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text2 
      Height          =   315
      Left            =   1920
      TabIndex        =   61
      Text            =   "0"
      Top             =   2280
      Width           =   1125
   End
   Begin VB.Timer Timer1 
      Interval        =   50
      Left            =   0
      Top             =   0
   End
   Begin VB.TextBox Text4 
      Height          =   315
      Left            =   480
      TabIndex        =   60
      Text            =   "0"
      Top             =   2280
      Width           =   765
   End
   Begin VB.Frame Frame1 
      Caption         =   "GeniusBus Words"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2355
      Left            =   30
      TabIndex        =   25
      Top             =   2640
      Width           =   6135
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   3
         Left            =   5010
         TabIndex        =   43
         Text            =   "00000000"
         Top             =   510
         Width           =   1050
      End
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   2
         Left            =   2010
         TabIndex        =   42
         Top             =   510
         Width           =   1050
      End
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   1
         Left            =   5010
         TabIndex        =   41
         Text            =   "00000000"
         Top             =   210
         Width           =   1050
      End
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   0
         Left            =   2010
         TabIndex        =   40
         Top             =   210
         Width           =   1050
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   12
         Left            =   4410
         TabIndex        =   39
         Text            =   "0"
         Top             =   2010
         Width           =   1650
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   12
         Left            =   1410
         TabIndex        =   38
         Top             =   2010
         Width           =   1650
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   8
         Left            =   4410
         TabIndex        =   37
         Text            =   "0"
         Top             =   1710
         Width           =   1650
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         Height          =   285
         Index           =   8
         Left            =   1410
         TabIndex        =   36
         Top             =   1710
         Width           =   1650
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   6
         Left            =   1410
         TabIndex        =   35
         Top             =   1410
         Width           =   600
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Height          =   285
         Index           =   6
         Left            =   4410
         TabIndex        =   34
         Text            =   "0"
         Top             =   1410
         Width           =   600
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   4
         Left            =   1410
         TabIndex        =   33
         Top             =   1110
         Width           =   600
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Height          =   285
         Index           =   4
         Left            =   4410
         TabIndex        =   32
         Text            =   "0"
         Top             =   1110
         Width           =   600
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   2
         Left            =   1410
         TabIndex        =   31
         Top             =   810
         Width           =   600
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         BackColor       =   &H0000C0C0&
         Height          =   285
         Index           =   2
         Left            =   4410
         TabIndex        =   30
         Text            =   "0"
         Top             =   810
         Width           =   600
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   1
         Left            =   1410
         TabIndex        =   29
         Top             =   510
         Width           =   600
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Height          =   285
         Index           =   1
         Left            =   4410
         TabIndex        =   28
         Text            =   "0"
         Top             =   510
         Width           =   600
      End
      Begin VB.TextBox GBOutput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Height          =   285
         Index           =   0
         Left            =   4410
         TabIndex        =   27
         Text            =   "0"
         Top             =   210
         Width           =   600
      End
      Begin VB.TextBox GBInput 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   0
         Left            =   1410
         TabIndex        =   26
         Top             =   210
         Width           =   600
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W4 (Data2)"
         Height          =   285
         Index           =   11
         Left            =   3060
         TabIndex        =   59
         Top             =   1410
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W3 (Data1)"
         Height          =   285
         Index           =   10
         Left            =   3060
         TabIndex        =   58
         Top             =   1110
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0000C0C0&
         Caption         =   "Output W2"
         Height          =   285
         Index           =   9
         Left            =   3060
         TabIndex        =   57
         Top             =   810
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W4 (Data2)"
         Height          =   285
         Index           =   8
         Left            =   60
         TabIndex        =   56
         Top             =   1410
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W3 (Data1)"
         Height          =   285
         Index           =   7
         Left            =   60
         TabIndex        =   55
         Top             =   1110
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W2"
         Height          =   285
         Index           =   6
         Left            =   60
         TabIndex        =   54
         Top             =   810
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W1 H-Byte"
         Height          =   285
         Index           =   5
         Left            =   3060
         TabIndex        =   53
         Top             =   510
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W1 L-Byte"
         Height          =   285
         Index           =   4
         Left            =   3060
         TabIndex        =   52
         Top             =   210
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W1 H-Byte"
         Height          =   285
         Index           =   3
         Left            =   60
         TabIndex        =   51
         Top             =   510
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W1 L-Byte"
         Height          =   285
         Index           =   2
         Left            =   60
         TabIndex        =   50
         Top             =   210
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W5-6(Real)"
         Height          =   285
         Index           =   12
         Left            =   60
         TabIndex        =   49
         Top             =   1710
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Input W7-8(Real)"
         Height          =   285
         Index           =   13
         Left            =   60
         TabIndex        =   48
         Top             =   2010
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W7-8(Real)"
         Height          =   285
         Index           =   14
         Left            =   3060
         TabIndex        =   47
         Top             =   2010
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Output W5-6(Real)"
         Height          =   285
         Index           =   15
         Left            =   3060
         TabIndex        =   46
         Top             =   1710
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Password"
         Height          =   285
         Index           =   16
         Left            =   2010
         TabIndex        =   45
         Top             =   810
         Width           =   1050
      End
      Begin VB.Label Label1 
         BackColor       =   &H0000C0C0&
         Caption         =   "N/A Reserved"
         Height          =   285
         Index           =   17
         Left            =   5010
         TabIndex        =   44
         Top             =   810
         Width           =   1050
      End
   End
   Begin VB.Frame Frame5 
      Caption         =   "GeniusBus Status Log"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   30
      TabIndex        =   23
      Top             =   5010
      Width           =   5385
      Begin VB.TextBox Text1 
         Height          =   1425
         Left            =   60
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   24
         Top             =   210
         Width           =   5295
      End
   End
   Begin VB.TextBox Text8 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   0
      Left            =   4500
      TabIndex        =   20
      Text            =   "0000000000000000"
      Top             =   2040
      Width           =   1665
   End
   Begin VB.TextBox Text8 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   1
      Left            =   4500
      TabIndex        =   19
      Text            =   "0000000000000000"
      Top             =   2340
      Width           =   1665
   End
   Begin VB.Frame Frame4 
      Caption         =   "GeniusBus Handshaking Bytes"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2025
      Left            =   390
      TabIndex        =   0
      Top             =   0
      Width           =   5415
      Begin VB.TextBox Text7 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Height          =   285
         Index           =   0
         Left            =   870
         TabIndex        =   1
         Top             =   1020
         Width           =   600
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   0
         Left            =   1380
         Shape           =   3  'Circle
         Top             =   240
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "HeartBeat"
         Height          =   195
         Index           =   18
         Left            =   30
         TabIndex        =   18
         Top             =   240
         Width           =   1350
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   1
         Left            =   1380
         Shape           =   3  'Circle
         Top             =   480
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "New Data Ready"
         Height          =   195
         Index           =   19
         Left            =   30
         TabIndex        =   17
         Top             =   480
         Width           =   1350
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   2
         Left            =   1380
         Shape           =   3  'Circle
         Top             =   720
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Data Retrieved"
         Height          =   195
         Index           =   20
         Left            =   30
         TabIndex        =   16
         Top             =   720
         Width           =   1350
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   0
         Left            =   3030
         Shape           =   3  'Circle
         Top             =   240
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "HeartBeat"
         Height          =   195
         Index           =   21
         Left            =   1650
         TabIndex        =   15
         Top             =   240
         Width           =   1350
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   1
         Left            =   3030
         Shape           =   3  'Circle
         Top             =   480
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "New Data Ready"
         Height          =   195
         Index           =   22
         Left            =   1650
         TabIndex        =   14
         Top             =   480
         Width           =   1350
      End
      Begin VB.Shape Shape2 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   2
         Left            =   3030
         Shape           =   3  'Circle
         Top             =   720
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Data Retrieved"
         Height          =   195
         Index           =   23
         Left            =   1650
         TabIndex        =   13
         Top             =   720
         Width           =   1350
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Command"
         Height          =   195
         Index           =   24
         Left            =   30
         TabIndex        =   12
         Top             =   1050
         Width           =   840
      End
      Begin VB.Label Label6 
         BackColor       =   &H00E0E0E0&
         Height          =   435
         Left            =   60
         TabIndex        =   11
         Top             =   1545
         Width           =   3615
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FF80&
         Caption         =   "Description:"
         Height          =   195
         Index           =   25
         Left            =   30
         TabIndex        =   10
         Top             =   1305
         Width           =   840
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   0
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   105
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Overall Fail"
         Height          =   195
         Index           =   26
         Left            =   3750
         TabIndex        =   9
         Top             =   105
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   1
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   345
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Overall Pass"
         Height          =   195
         Index           =   27
         Left            =   3750
         TabIndex        =   8
         Top             =   345
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   2
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   585
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Bypass Warning"
         Height          =   195
         Index           =   28
         Left            =   3750
         TabIndex        =   7
         Top             =   585
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   3
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   825
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Zero Fault"
         Height          =   195
         Index           =   29
         Left            =   3750
         TabIndex        =   6
         Top             =   825
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   4
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   1065
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Window Fault"
         Height          =   195
         Index           =   30
         Left            =   3750
         TabIndex        =   5
         Top             =   1065
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   5
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   1305
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Gain Fault"
         Height          =   195
         Index           =   31
         Left            =   3750
         TabIndex        =   4
         Top             =   1305
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   6
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   1545
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Invalid Command"
         Height          =   195
         Index           =   32
         Left            =   3750
         TabIndex        =   3
         Top             =   1545
         Width           =   1350
      End
      Begin VB.Shape Shape3 
         BackColor       =   &H00000000&
         BackStyle       =   1  'Opaque
         Height          =   195
         Index           =   7
         Left            =   5130
         Shape           =   3  'Circle
         Top             =   1785
         Width           =   195
      End
      Begin VB.Label Label1 
         BackColor       =   &H0000C0C0&
         Caption         =   "N/A (Reserved)"
         Height          =   195
         Index           =   33
         Left            =   3750
         TabIndex        =   2
         Top             =   1785
         Width           =   1350
      End
   End
   Begin VB.Label Label2 
      Caption         =   "Input W1"
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
      Left            =   2160
      TabIndex        =   63
      Top             =   2040
      Width           =   810
   End
   Begin VB.Label lblSBA 
      Caption         =   "SBA - (Remote Node)"
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
      Left            =   0
      TabIndex        =   62
      Top             =   2040
      Width           =   2010
   End
   Begin VB.Label Label1 
      BackColor       =   &H0080FFFF&
      Caption         =   "Binary W4 (Data2)"
      Height          =   195
      Index           =   35
      Left            =   3120
      TabIndex        =   22
      Top             =   2370
      Width           =   1350
   End
   Begin VB.Label Label1 
      BackColor       =   &H0080FFFF&
      Caption         =   "Binary W3 (Data1)"
      Height          =   195
      Index           =   34
      Left            =   3120
      TabIndex        =   21
      Top             =   2100
      Width           =   1350
   End
End
Attribute VB_Name = "IO_Display"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private BoardCount            As Integer
Private LineCount(1)          As Integer
Private bTemp(1)              As Byte
Private cTemp(1)              As Byte
Private dTemp(16)             As Integer
Private eTemp(16)             As Integer
Private fTemp(16)             As Single
Private gTemp(16)             As Single
Private HandShakeByteIN       As String
Private HandShakeByteOUT      As String
Private COMMAND               As String
Private Data_1_IN             As String
Private Data_1_OUT            As String
Private Data_2_OUT            As String
Private Latch                 As Boolean
Private X                     As Integer
Private CurrentSBA            As Integer
Private StatusByte            As String
Private Const T1              As String = "["
Private Const T2              As String = "]"

Private Sub Form_Resize()
    SetWindowPos Me.hwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
End Sub

Private Sub Timer1_Timer()
    UpdateGeniusBus
End Sub
Public Sub UpdateGeniusBus()
    CurrentSBA = Val(Text4.Text)
'This is setup for 16 Bytes In and 16 Bytes Out
    For X = 0 To 1
'Write 2 Bytes to Broadcast Control Output Table
        cTemp(X) = Val(GBOutput(X).Text)
        SetVar MemoryBaseAddress + SRI_BROADCAST_CONTROL_OUTPUT_TABLE_OFFSET + X, cTemp(X), 1
'Read 2 Bytes from SRI Device I/O Table (at Current Node)
        bTemp(X) = GetVar(MemoryBaseAddress + SRI_Device_IO_Table_Offset(CurrentSBA) + X, 1)
        GBInput(X).Text = bTemp(X)
    Next X
    For X = 2 To 6 Step 2
'Write 2 Words (2 Bytes each) to Broadcast Control Output Table
        eTemp(X) = Val(GBOutput(X).Text)
        SetVar MemoryBaseAddress + SRI_BROADCAST_CONTROL_OUTPUT_TABLE_OFFSET + X, eTemp(X), 2
'Read 2 Words (2 Bytes each) from SRI Device I/O Table (at Current Node)
        dTemp(X) = GetVar(MemoryBaseAddress + SRI_Device_IO_Table_Offset(CurrentSBA) + X, 2)
        GBInput(X).Text = dTemp(X)
    Next X
    For X = 8 To 12 Step 4
'Write 2 Singles (4 Bytes each) to Broadcast Control Output Table
        gTemp(X) = CSng(GBOutput(X).Text)
        SetVar MemoryBaseAddress + SRI_BROADCAST_CONTROL_OUTPUT_TABLE_OFFSET + X, gTemp(X), 4
'Read 2 Singles (4 Bytes each) from SRI Device I/O Table (at Current Node)
        fTemp(X) = GetVar(MemoryBaseAddress + SRI_Device_IO_Table_Offset(CurrentSBA) + X, 4)
        GBInput(X).Text = fTemp(X)
    Next X
'Display the integer value of these two bytes
    Text2.Text = GetVar(MemoryBaseAddress + SRI_Device_IO_Table_Offset(CurrentSBA), 2)
    HandShakeByteIN = ByteFormat(DecimalToBinary(GBInput(0).Text))
    COMMAND = GBInput(1).Text
    Data_1_IN = GBInput(4).Text
'Heartbeat
    If Right$(HandShakeByteIN, 1) = "1" Then
        HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 7) & "1"
        Shape1(0).BackColor = &HFF00&
    ElseIf Right$(HandShakeByteIN, 1) = "0" Then
        HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 7) & "0"
        Shape1(0).BackColor = &H0&
    ElseIf Right$(HandShakeByteIN, 1) = vbNullString Then
'ByteFormat(HandShakeByteOUT) = Left$(ByteFormat(HandShakeByteOUT), 7) & "1"
    End If
'New Data IN
    If Mid$(HandShakeByteIN, 7, 1) = "1" Then
        Shape1(1).BackColor = &HFF00&
'Execute selected command sample code
        Select Case COMMAND
        Case "1" 'Text command 1
            Label6.Caption = "This is command 1"
            If Not Latch Then
'Data retrieved OUT
                HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 5) & "1" & Mid$(ByteFormat(HandShakeByteOUT), 7, 1) & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
'DO SOMETHING HERE
'New Data OUT
                HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 6) & "1" & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
                Latch = True
            End If
        Case "2" 'Auto window command - a
            Label6.Caption = "This would be command 2"
            If Not Latch Then
'Data retrieved OUT
                HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 5) & "1" & Mid$(ByteFormat(HandShakeByteOUT), 7, 1) & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
'DO SOMETHING ELSE HERE
'New Data OUT
                HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 6) & "1" & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
                Latch = True
            End If
        Case Else
            Label6.Caption = "Bad GeniusBus Command"
        End Select
    ElseIf Mid$(HandShakeByteIN, 7, 1) = "0" Then
        Latch = False
        HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 5) & "0" & Mid$(ByteFormat(HandShakeByteOUT), 7, 1) & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
        Shape1(1).BackColor = &H0&
    Else
'If Mid$(HandShakeByteIN, 7, 1) = vbNullString Then
'ByteFormat(HandShakeByteOUT) = Left$(ByteFormat(HandShakeByteOUT), 7) & "1"
    End If
'Data Retrieved
    If Mid$(HandShakeByteIN, 6, 1) = "1" Then
        HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 6) & "0" & Mid$(ByteFormat(HandShakeByteOUT), 8, 1)
        Shape1(2).BackColor = &HFF00&
    ElseIf Mid$(HandShakeByteIN, 6, 1) = "0" Then
        Shape1(2).BackColor = &H0&
'HandShakeByteOUT = Left$(ByteFormat(HandShakeByteOUT), 5) & "000"
    ElseIf Mid$(HandShakeByteIN, 6, 1) = vbNullString Then
'ByteFormat(HandShakeByteOUT) = Left$(ByteFormat(HandShakeByteOUT), 7) & "1"
    End If
'Heartbeat Out
    If Right$(HandShakeByteOUT, 1) = "1" Then
        Shape2(0).BackColor = &HFF00&
    ElseIf Right$(HandShakeByteOUT, 1) = "0" Then
        Shape2(0).BackColor = &H0&
    End If
'New Data Ready Out
    If Mid$(HandShakeByteOUT, 7, 1) = "1" Then
        Shape2(1).BackColor = &HFF00&
    ElseIf Mid$(HandShakeByteOUT, 7, 1) = "0" Then
        Shape2(1).BackColor = &H0&
    End If
    If Mid$(HandShakeByteOUT, 6, 1) = "1" Then
        Shape2(2).BackColor = &HFF00&
    ElseIf Mid$(HandShakeByteOUT, 6, 1) = "0" Then
        Shape2(2).BackColor = &H0&
    End If
'Status Byte Out
    If Mid$(StatusByte, 8, 1) = "1" Then
        Shape3(0).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 8, 1) = "0" Then
        Shape3(0).BackColor = &H0&
    End If
    If Mid$(StatusByte, 7, 1) = "1" Then
        Shape3(1).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 7, 1) = "0" Then
        Shape3(1).BackColor = &H0&
    End If
    If Mid$(StatusByte, 6, 1) = "1" Then
        Shape3(2).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 6, 1) = "0" Then
        Shape3(2).BackColor = &H0&
    End If
    If Mid$(StatusByte, 5, 1) = "1" Then
        Shape3(3).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 5, 1) = "0" Then
        Shape3(3).BackColor = &H0&
    End If
    If Mid$(StatusByte, 4, 1) = "1" Then
        Shape3(4).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 4, 1) = "0" Then
        Shape3(4).BackColor = &H0&
    End If
    If Mid$(StatusByte, 3, 1) = "1" Then
        Shape3(5).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 3, 1) = "0" Then
        Shape3(5).BackColor = &H0&
    End If
    If Mid$(StatusByte, 2, 1) = "1" Then
        Shape3(6).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 2, 1) = "0" Then
        Shape3(6).BackColor = &H0&
    End If
    If Mid$(StatusByte, 1, 1) = "1" Then
        Shape3(7).BackColor = &HFF00&
    ElseIf Mid$(StatusByte, 1, 1) = "0" Then
        Shape3(7).BackColor = &H0&
    End If
    Text6(0).Text = HandShakeByteIN
    Text6(1).Text = HandShakeByteOUT
    Text6(2).Text = COMMAND
    Text6(3).Text = StatusByte
    Text8(0).Text = DecimalToBinary(GBOutput(4).Text)
    Text8(1).Text = DecimalToBinary(GBOutput(6).Text)
    GBOutput(0).Text = BinaryToDecimal(HandShakeByteOUT)
    GBOutput(1).Text = BinaryToDecimal(StatusByte)
End Sub
