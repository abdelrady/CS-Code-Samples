VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.Form frmMain 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Barcode Reader by Andrew Ford"
   ClientHeight    =   4110
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11415
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4110
   ScaleWidth      =   11415
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraFrames 
      Caption         =   "Barcode Reader Options"
      Height          =   3855
      Index           =   2
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   5535
      Begin MSCommLib.MSComm ComPort 
         Left            =   4920
         Top             =   120
         _ExtentX        =   1005
         _ExtentY        =   1005
         _Version        =   393216
         DTREnable       =   -1  'True
      End
      Begin VB.OptionButton optComPort 
         Caption         =   "COM4"
         Height          =   255
         Index           =   3
         Left            =   480
         TabIndex        =   14
         Top             =   1320
         Width           =   1335
      End
      Begin VB.OptionButton optComPort 
         Caption         =   "COM3"
         Height          =   255
         Index           =   2
         Left            =   480
         TabIndex        =   13
         Top             =   1080
         Width           =   1335
      End
      Begin VB.OptionButton optComPort 
         Caption         =   "COM2"
         Height          =   255
         Index           =   1
         Left            =   480
         TabIndex        =   12
         Top             =   840
         Width           =   1335
      End
      Begin VB.OptionButton optComPort 
         Caption         =   "COM1"
         Height          =   255
         Index           =   0
         Left            =   480
         TabIndex        =   11
         Top             =   600
         Value           =   -1  'True
         Width           =   1335
      End
      Begin VB.CommandButton cmdDisconnect 
         Caption         =   "Disconnect"
         Enabled         =   0   'False
         Height          =   375
         Left            =   2280
         TabIndex        =   9
         Top             =   1080
         Width           =   3015
      End
      Begin VB.CommandButton cmdConnect 
         Caption         =   "Connect To Selected COM Port"
         Height          =   375
         Left            =   2280
         TabIndex        =   8
         Top             =   600
         Width           =   3015
      End
      Begin VB.CheckBox chkWedge 
         Caption         =   "Enable Wedge Emulation"
         Height          =   255
         Left            =   480
         TabIndex        =   7
         Top             =   1920
         Width           =   2535
      End
      Begin VB.CommandButton cmdExit 
         Caption         =   "Exit"
         Height          =   375
         Left            =   240
         TabIndex        =   6
         Top             =   2880
         Width           =   5055
      End
      Begin VB.CommandButton cmdClear 
         Caption         =   "Clear All Current Barcodes"
         Height          =   375
         Left            =   240
         TabIndex        =   5
         Top             =   2400
         Width           =   5055
      End
      Begin VB.Label lblStatus 
         Alignment       =   2  'Center
         Caption         =   "Idle"
         Height          =   255
         Left            =   105
         TabIndex        =   10
         Top             =   3360
         Width           =   5295
      End
   End
   Begin VB.Frame frmFrames 
      Caption         =   "Previous Barcodes"
      Height          =   2415
      Left            =   5760
      TabIndex        =   2
      Top             =   1560
      Width           =   5535
      Begin VB.ListBox lstBarcodes 
         Height          =   1815
         Left            =   240
         TabIndex        =   3
         Top             =   360
         Width           =   5055
      End
   End
   Begin VB.Frame fraFrames 
      Caption         =   "Last Barcode Scanned"
      Height          =   1335
      Index           =   1
      Left            =   5760
      TabIndex        =   0
      Top             =   120
      Width           =   5535
      Begin VB.TextBox txtBarcode 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   240
         Locked          =   -1  'True
         TabIndex        =   1
         Top             =   525
         Width           =   5055
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'*******************************************************************************
' FORM:         frmMain
' FILENAME:     frmMain.frm
' AUTHOR:       Andrew Ford
' CREATED:      15-Jun-2003
'
'   Serial Barcode Reader by Andrew Ford
'
'       Project based on code from:
'       http://www.zygo.btinternet.co.uk/vbdemo.zip
'       Website @
'       http://www.zygo.btinternet.co.uk/wa3400.html
'
'*******************************************************************************

'Force declaration of variables
Option Explicit

'Form level declarations
Dim sBarcodeTemp As String  'Holds the barcode characters that has been scanned
Dim sInTemp As String       'Holds each character that is passed to the com port

Private Sub cmdClear_Click()

    'Clear listbox and textbox
    lstBarcodes.Clear
    txtBarcode.Text = ""
    
End Sub

Private Sub cmdConnect_Click()

    'Find and Connect to the selected serial port
    Dim i As Integer
    For i = 1 To 4
        If optComPort(i - 1).Value = True Then
            ComPort.CommPort = i
            Exit For 'Skip the rest
        End If
    Next
    
    If ComPort.PortOpen = True Then ComPort.PortOpen = False  'Close port if open
    ComPort.PortOpen = True  'Open com port
    
    'Set status
    lblStatus = "Connected..."
    
    'Setup dis/connect buttons
    cmdConnect.Enabled = False
    cmdDisconnect.Enabled = True
    
End Sub

Private Sub cmdDisconnect_Click()

    'Disconnect from serial port
    If ComPort.PortOpen = True Then ComPort.PortOpen = False
    
    'Set status
    lblStatus = "Disconected..."
    
    'Setup dis/connect buttons
    cmdDisconnect.Enabled = False
    cmdConnect.Enabled = True
    
End Sub

Private Sub cmdExit_Click()

    'Disconnect from serial port
    If ComPort.PortOpen = True Then ComPort.PortOpen = False
    
    'End program
    Unload Me
    End

End Sub

Private Sub ComPort_OnComm()

    'If we have recieved data though the com port, continue
    If ComPort.CommEvent <> comEvReceive Then Exit Sub
     
    'Get the input character
    sInTemp = ComPort.Input

    'Add the input charater to the barcode buffer
    sBarcodeTemp = sBarcodeTemp & sInTemp

    'If finished reading the barcode
    If Right$(sBarcodeTemp, 2) = vbNewLine Then
    
        'Wedge emulation with carrage return
        If chkWedge Then SendKeys sBarcodeTemp
        
        'Strip the barcode of the carrage return
        sBarcodeTemp = Left$(sBarcodeTemp, Len(sBarcodeTemp) - 2)
        
        'Wedge emulation without carrage return
        'If chkWedge Then SendKeys sBarcodeTemp
        
        'Add barcode to the text box
        txtBarcode = sBarcodeTemp

        'Add to the top of the list box
        lstBarcodes.AddItem sBarcodeTemp, 0
        
        'Clear barcode temp
        sBarcodeTemp = ""
        
        'Set status
        lblStatus = "Barcode Scanned"

    End If
       
End Sub

Private Sub Form_Load()

    'Loop counter
    Dim iComPort As Integer 'Holds current port number

    'Error handle for com port errors
    On Error GoTo CommErrorHandle
    
    'Try to connect to each serial port
    For iComPort = 1 To 4
        ComPort.CommPort = iComPort 'Set the current port number
        If ComPort.PortOpen = True Then ComPort.PortOpen = False 'Close it if its open
        ComPort.PortOpen = True  'Try to open it
        ComPort.PortOpen = False 'Close It
    Next
    
    'Configure ComPort Control For Single Character Input
    ComPort.InputLen = 1    '1 Character For Input
    ComPort.RThreshold = 1  '1 Character Before OnComm Event Is Triggered
    
    'Skip error handle
    Exit Sub
    
CommErrorHandle:

    '68   = Device Unavaliable
    '8002 = Invalid Port Number
    '8012 = Device Not Open
    If Err = 68 Or Err = 8002 Or Err = 8012 Then
        'Device unavaliable, disable comm port option
        optComPort(iComPort - 1).Enabled = False
    End If
    
    'Continue from error point
    Resume Next
    
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)

    'Disconnect com port on exit
    If ComPort.PortOpen = True Then ComPort.PortOpen = False

End Sub
