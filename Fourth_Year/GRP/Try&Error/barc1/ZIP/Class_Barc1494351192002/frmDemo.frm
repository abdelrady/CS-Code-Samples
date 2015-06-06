VERSION 5.00
Begin VB.Form frmDemo 
   Caption         =   "Demo"
   ClientHeight    =   6300
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7110
   LinkTopic       =   "Form2"
   ScaleHeight     =   6300
   ScaleWidth      =   7110
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtTest 
      Height          =   285
      Left            =   1440
      TabIndex        =   16
      Top             =   4920
      Width           =   5415
   End
   Begin VB.CommandButton cmdTest 
      Caption         =   "&Test Barcode"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   15
      Top             =   4320
      Width           =   6615
   End
   Begin VB.CommandButton cmdDraw 
      Caption         =   "&Draw"
      Height          =   855
      Left            =   4080
      TabIndex        =   14
      Top             =   3240
      Width           =   1935
   End
   Begin VB.TextBox txtNarrowX 
      Height          =   285
      Left            =   5760
      TabIndex        =   13
      Text            =   "15"
      Top             =   2760
      Width           =   735
   End
   Begin VB.TextBox txtHeight 
      Height          =   285
      Left            =   5760
      TabIndex        =   11
      Text            =   "600"
      Top             =   2280
      Width           =   735
   End
   Begin VB.TextBox txtY 
      Height          =   285
      Left            =   3960
      TabIndex        =   9
      Text            =   "30"
      Top             =   2760
      Width           =   855
   End
   Begin VB.TextBox txtX 
      Height          =   285
      Left            =   3960
      TabIndex        =   7
      Text            =   "30"
      Top             =   2280
      Width           =   855
   End
   Begin VB.CheckBox chkCheckDigit 
      Caption         =   "Check Digit"
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   3240
      Width           =   3375
   End
   Begin VB.CheckBox chkIncludeBox 
      Caption         =   "Include Box"
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   2640
      Value           =   1  'Checked
      Width           =   3255
   End
   Begin VB.TextBox txtBarcode 
      Height          =   285
      Left            =   1080
      TabIndex        =   3
      Text            =   "BARCODE"
      Top             =   2280
      Width           =   2415
   End
   Begin VB.PictureBox picWorkspace 
      BackColor       =   &H00FFFFFF&
      Height          =   1695
      Left            =   240
      ScaleHeight     =   1635
      ScaleWidth      =   6195
      TabIndex        =   0
      Top             =   360
      Width           =   6255
   End
   Begin VB.Label Label7 
      Caption         =   $"frmDemo.frx":0000
      Height          =   855
      Left            =   240
      TabIndex        =   18
      Top             =   5280
      Width           =   6615
   End
   Begin VB.Label Label6 
      Caption         =   "Response:"
      Height          =   255
      Left            =   360
      TabIndex        =   17
      Top             =   4920
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "narrow X:"
      Height          =   375
      Left            =   4920
      TabIndex        =   12
      Top             =   2760
      Width           =   735
   End
   Begin VB.Label Label4 
      Caption         =   "Height:"
      Height          =   255
      Left            =   4920
      TabIndex        =   10
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "Y:"
      Height          =   255
      Left            =   3720
      TabIndex        =   8
      Top             =   2760
      Width           =   375
   End
   Begin VB.Label Label2 
      Caption         =   "X:"
      Height          =   375
      Left            =   3720
      TabIndex        =   6
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label Label1 
      Caption         =   "Barcode:"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label lblHeading 
      Caption         =   "Barcode:"
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   120
      Width           =   1335
   End
End
Attribute VB_Name = "frmDemo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Barcode39 As clsBarCode39

Private Sub cmdDraw_Click()
    
    With Barcode39
        ' Set the position
        .CurrentX = Val(txtX.Text)
        .CurrentY = Val(txtY.Text)
        
        ' Set the narrow X
        .NarrowX = Val(txtNarrowX.Text)
        
        ' Set the height needed
        .BarcodeHeight = Val(txtHeight.Text)
        
        ' Include a box
        .ShowBox = chkIncludeBox.Value
        
        .Barcode = txtBarcode.Text
        If .ErrNumber <> 0 Then
            ' It contain invalid barcode charater
            MsgBox "Error: It contain invalid barcode charater", vbOKOnly + vbCritical, "Error"
            Exit Sub
        End If
        
        ' Add check digit if needed
        If chkCheckDigit.Value = 1 Then
            .Barcode = .Barcode & .FindCheckDigit
        End If
        
        ' Clear the workspace
        picWorkspace.Cls
            
        ' Draw it
        .Draw picWorkspace
        
    End With
End Sub

Private Sub cmdTest_Click()
    ' Set focus so barcode can test on it
    txtTest.SetFocus
End Sub

Private Sub Form_Load()
    Set Barcode39 = New clsBarCode39
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Set Barcode39 = Nothing
End Sub

Private Sub txtTest_KeyPress(KeyAscii As Integer)
    ' If barcode has get the input
    If KeyAscii = vbKeyReturn Then
        MsgBox "Please check the result and tell me. If can, copy the response and tell to me."
    End If
End Sub
