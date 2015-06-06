VERSION 5.00
Begin VB.Form frmBarCode 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "CueCat BarCode Scanner v1.5"
   ClientHeight    =   5205
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4740
   Icon            =   "frmBarCode.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5205
   ScaleWidth      =   4740
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame frameFormat 
      Caption         =   "Formatting"
      Height          =   1230
      Left            =   45
      TabIndex        =   4
      Top             =   3915
      Width           =   4650
      Begin VB.OptionButton optFormat 
         Caption         =   "This is a best buy receipt"
         Height          =   195
         Index           =   2
         Left            =   180
         TabIndex        =   7
         Top             =   810
         Width           =   2940
      End
      Begin VB.OptionButton optFormat 
         Caption         =   "Do not format at all"
         Height          =   195
         Index           =   1
         Left            =   180
         TabIndex        =   6
         Top             =   540
         Width           =   2940
      End
      Begin VB.OptionButton optFormat 
         Caption         =   "Use automatic formatting (Default)"
         Height          =   195
         Index           =   0
         Left            =   180
         TabIndex        =   5
         Top             =   270
         Value           =   -1  'True
         Width           =   2940
      End
   End
   Begin VB.PictureBox picCueCat 
      AutoSize        =   -1  'True
      Height          =   975
      Left            =   45
      Picture         =   "frmBarCode.frx":030A
      ScaleHeight     =   915
      ScaleWidth      =   900
      TabIndex        =   3
      Top             =   45
      Width           =   960
   End
   Begin VB.Frame frameMain 
      Caption         =   "BarCode Information"
      Height          =   2805
      Left            =   45
      TabIndex        =   2
      Top             =   1080
      Width           =   4650
      Begin VB.Label lblData 
         Caption         =   "0"
         Height          =   1050
         Index           =   3
         Left            =   90
         TabIndex        =   15
         Top             =   1665
         Width           =   4455
      End
      Begin VB.Label lblStatic 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Other Information:"
         Height          =   195
         Index           =   3
         Left            =   90
         TabIndex        =   14
         Top             =   1395
         Width           =   1260
      End
      Begin VB.Label lblStatic 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Barcode # Count:"
         Height          =   195
         Index           =   2
         Left            =   90
         TabIndex        =   13
         Top             =   855
         Width           =   1260
      End
      Begin VB.Label lblData 
         AutoSize        =   -1  'True
         Caption         =   "0"
         Height          =   195
         Index           =   2
         Left            =   1530
         TabIndex        =   12
         Top             =   855
         Width           =   90
      End
      Begin VB.Label lblData 
         AutoSize        =   -1  'True
         Caption         =   "0"
         Height          =   195
         Index           =   1
         Left            =   1530
         TabIndex        =   11
         Top             =   585
         Width           =   90
      End
      Begin VB.Label lblData 
         AutoSize        =   -1  'True
         Caption         =   "0"
         Height          =   195
         Index           =   0
         Left            =   1530
         TabIndex        =   10
         Top             =   315
         Width           =   90
      End
      Begin VB.Label lblStatic 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "UPC BarCode:"
         Height          =   195
         Index           =   1
         Left            =   315
         TabIndex        =   9
         Top             =   585
         Width           =   1035
      End
      Begin VB.Label lblStatic 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "UPC Type:"
         Height          =   195
         Index           =   0
         Left            =   585
         TabIndex        =   8
         Top             =   315
         Width           =   780
      End
   End
   Begin VB.Frame FrameCatData 
      Caption         =   "Enter CueCat Scanner Info Here"
      Height          =   645
      Left            =   1035
      TabIndex        =   1
      Top             =   360
      Width           =   3660
      Begin VB.TextBox txtCode 
         Height          =   285
         Left            =   90
         MultiLine       =   -1  'True
         TabIndex        =   0
         Top             =   225
         Width           =   3435
      End
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Make sure you turn off your CAPS LOCK"
      Height          =   195
      Left            =   1080
      TabIndex        =   16
      Top             =   45
      Width           =   2865
   End
End
Attribute VB_Name = "frmBarCode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim sCueBuffer As String 'CueCat Data to store
Dim sCodeType As String 'I could do this as a numeric value. However, I will do it as a string for easy viewing.

Private Sub chkFormat_Click(Index As Integer)
  txtCode.SetFocus
End Sub

Private Sub Form_Load()
Dim i As Byte
    
    For i = 0 To 3 'Clear all the Data from the Form
      lblData(i).Caption = ""
    Next i
End Sub

Private Sub optFormat_Click(Index As Integer)
txtCode.SetFocus
End Sub

Private Sub txtCode_Change()

Dim nDecimals As Byte
Dim i As Integer

  If InStr(txtCode.Text, vbCrLf) <> 0 Then 'check for <CR>
                       
    For i = 0 To 3 'Clear all the Data from the Form
      lblData(i).Caption = ""
    Next i
                       
    For i = 1 To Len(txtCode.Text) 'Search for the decimals
      If Mid$(txtCode.Text, i, 1) = "." Then nDecimals = nDecimals + 1
      
      If nDecimals = 3 Then '3rd decimal is the start of the data to be decoded.
        sCueBuffer = Mid$(txtCode.Text, i + 1) 'Remove the header prefix (before the 3rd decimal)
        sCueBuffer = Left$(sCueBuffer, Len(sCueBuffer) - 3) 'Remove the trailing decimal and the <CR>
        Exit For 'Exit For/Next Statement
      End If
    
    Next i
    
           
    If InStr(txtCode.Text, ".CNf7.") <> 0 Then 'CODE 128
      sCodeType = "CODE128"
      lblData(0).Caption = "CODE 128"
    ElseIf InStr(txtCode.Text, ".ahb6.") <> 0 Then 'CODE 39
      sCodeType = "CODE39"
      lblData(0).Caption = "CODE 39"
      lblData(3).Caption = "A-Z (uppercase), 0-9, period/decimal, space, $, /, + and %." & vbCrLf & "This version of the source does not implement A-Z or special characters."
    ElseIf InStr(txtCode.Text, ".fHmc.") <> 0 Then 'UPC A (12 Digits)
      sCodeType = "UPCA12"
      lblData(0).Caption = "UPC A (10 + Check Digit)"
      lblData(3).Caption = "UPC A consists of digits 0-9" + vbCrLf + "First Digit: Number System Digit" + vbCrLf + "Next 5 Digits: Manufacturer Code" + vbCrLf + "Next 5 Digits: Product ID" + vbCrLf + "Last Digit: Checksum Digit"
    ElseIf InStr(txtCode.Text, ".cGf2.") <> 0 Then 'UPC 5 Digit Extension (18 Digits)
      sCodeType = "UPC518"
      lblData(0).Caption = "UPC / ISBN +5 Digit Ext. (18 Digits)"
      lblData(3).Caption = "Consists of digits 0-9" + vbCrLf + "Found usually on Books and Magazines" + vbCrLf + "Also includes the ISBN number"
    ElseIf InStr(txtCode.Text, ".cGen.") <> 0 Then 'UPC 5 Digit Extension (13 Digits) minus the 5 digits
      sCodeType = "UPC513"
      lblData(0).Caption = "UPC / ISBN (13 Digits)"
      lblData(3).Caption = "Consists of digits 0-9" + vbCrLf + "Same as the 18 digit version minus the 5 digit extension." + vbCrLf + "For some reason the 13th digit seems to repeat the 12th digit."
    Else 'All other formats that are not implemented or unknown
      sCodeType = "UNKNOWN"
      lblData(0).Caption = "Unknown/Not Implemented"
    End If
    
    txtCode.Text = ""
    
    If optFormat(0).Value = True Then 'Format the Data
      lblData(1).Caption = cc_space(cc_decode(sCueBuffer), sCodeType)
    ElseIf optFormat(1).Value = True Then 'Do not format the Data
      lblData(1).Caption = cc_decode(sCueBuffer)
    ElseIf optFormat(2).Value = True Then 'Best Buy Receipt
      'Check to make sure this is a Best Buy Receipt. Make sure its a Code 128 with 22 numbers.
      If sCodeType = "CODE128" And Len(cc_decode(sCueBuffer)) = 22 Then
        lblData(1).Caption = cc_decode(sCueBuffer)
        lblData(3).Caption = cc_space(cc_decode(sCueBuffer), "BESTBUY")
      Else
        MsgBox "This is not a Best Buy Receipt.", 64
        For i = 0 To 3 'Clear all the Data from the Form
          lblData(i).Caption = ""
        Next i
      End If
    End If
    
    lblData(2).Caption = Len(cc_decode(sCueBuffer)) 'Return the length of the Barcode
  
  End If

End Sub
