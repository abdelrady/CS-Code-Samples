VERSION 5.00
Begin VB.Form frmAdd 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add to database"
   ClientHeight    =   2460
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4635
   Icon            =   "frmAdd.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2460
   ScaleWidth      =   4635
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdClear 
      Caption         =   "C&lear"
      Height          =   375
      Left            =   3120
      TabIndex        =   6
      Top             =   1800
      Width           =   1095
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   3120
      TabIndex        =   5
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "&Add"
      Height          =   375
      Left            =   3120
      TabIndex        =   4
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton cmdAddMore 
      Caption         =   "Add &More"
      Height          =   375
      Left            =   3120
      TabIndex        =   3
      Top             =   360
      Width           =   1095
   End
   Begin VB.TextBox txtPrice 
      Height          =   285
      Left            =   240
      TabIndex        =   2
      Top             =   1920
      Width           =   2535
   End
   Begin VB.TextBox txtBarcode 
      Height          =   285
      Left            =   240
      TabIndex        =   0
      Top             =   480
      Width           =   2535
   End
   Begin VB.TextBox txtProduct 
      Height          =   285
      Left            =   240
      TabIndex        =   1
      Top             =   1200
      Width           =   2535
   End
   Begin VB.Label lblPrice 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Price"
      Height          =   195
      Left            =   240
      TabIndex        =   9
      Top             =   1680
      Width           =   360
   End
   Begin VB.Label lblBarcode 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Barcode"
      Height          =   195
      Left            =   240
      TabIndex        =   8
      Top             =   240
      Width           =   600
   End
   Begin VB.Label lblProduct 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Product"
      Height          =   195
      Left            =   240
      TabIndex        =   7
      Top             =   960
      Width           =   555
   End
End
Attribute VB_Name = "frmAdd"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim AddMore As Boolean

Private Sub cmdAdd_Click()
    Dim Success As Long
    
    Success = AddNewRecord
    
    If Success = -1 Then
        MsgBox "Record successfully created", vbInformation
        frmMain.OpenDB
    Else
        Exit Sub
    End If
    
    Unload frmAdd
End Sub

Private Sub cmdAddMore_Click()
    Dim Success As Long
    
    AddMore = True
    cmdAddMore.Default = False
    cmdAdd.Default = False
    
    txtBarcode.SetFocus
    
    Success = AddNewRecord
    
    If Success = -1 Then
        MsgBox "Record successfully created", vbInformation
        frmMain.OpenDB
    Else
        Exit Sub
    End If

    txtBarcode.Text = vbNullString
    txtProduct.Text = vbNullString
    txtPrice.Text = vbNullString
End Sub

Private Function AddNewRecord() As Long
    On Error GoTo AddRecordError
    Dim DB As Database
    Dim RS As Recordset
    Dim WS As Workspace
    
    AddNewRecord = -1
    
    If Trim$(txtBarcode.Text) = vbNullString Then Err.Raise 109, , "Please fill in the Barcode field"
    If Trim$(txtProduct.Text) = vbNullString Then Err.Raise 110, , "Please fill in the Product field"
    If Trim$(txtPrice.Text) = vbNullString Then Err.Raise 111, , "Please fill in the Price field"
    
    If Left$(txtBarcode.Text, 1) = "#" Then
        txtBarcode.Text = Right$(txtBarcode.Text, Len(txtBarcode.Text) - 1)
    End If
    
    If IsNumeric(txtPrice.Text) = False Then Err.Raise 112, , "Invalid price"
    If IsNumeric(txtBarcode.Text) = False Then Err.Raise 113, , "Invalid barcode"
    
    Set WS = DBEngine.Workspaces(0)
    Set DB = WS.OpenDatabase(AppPath & "bdb.mdb")
    Set RS = DB.OpenRecordset("Products", dbOpenTable)
    
    RS.AddNew
    
    RS("Barcode") = txtBarcode.Text
    RS("Product") = txtProduct.Text
    RS("Price") = txtPrice.Text
    
    RS.Update
    
    DB.Close
    
    Exit Function
AddRecordError:
AddNewRecord = Err.Number
MsgBox Err.Description, vbExclamation
End Function

Private Sub cmdClear_Click()
    txtBarcode.Text = vbNullString
    txtProduct.Text = vbNullString
    txtPrice.Text = vbNullString
End Sub

Private Sub cmdClose_Click()
    Unload frmAdd
End Sub

Private Sub Form_Load()
    AddMore = False
End Sub

Private Sub txtBarcode_KeyPress(KeyAscii As Integer)
    If KeyAscii = vbKeyReturn Then
        txtProduct.SetFocus
        KeyAscii = 0
    End If
End Sub

Private Sub txtPrice_Change()
    If txtPrice = vbNullString Then Exit Sub
    If AddMore = True Then
        cmdAddMore.Default = True
    Else
        cmdAdd.Default = True
    End If
End Sub

Private Sub txtProduct_KeyPress(KeyAscii As Integer)
    If KeyAscii = vbKeyReturn Then
        txtPrice.SetFocus
        KeyAscii = 0
    End If
End Sub
