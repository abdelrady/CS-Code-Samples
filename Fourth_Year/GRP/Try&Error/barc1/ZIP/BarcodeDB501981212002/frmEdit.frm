VERSION 5.00
Begin VB.Form frmEdit 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Edit"
   ClientHeight    =   2460
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4635
   Icon            =   "frmEdit.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2460
   ScaleWidth      =   4635
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtProduct 
      Height          =   285
      Left            =   240
      TabIndex        =   1
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtBarcode 
      Height          =   285
      Left            =   240
      TabIndex        =   0
      Top             =   480
      Width           =   2535
   End
   Begin VB.TextBox txtPrice 
      Height          =   285
      Left            =   240
      TabIndex        =   2
      Top             =   1920
      Width           =   2535
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Height          =   375
      Left            =   3120
      TabIndex        =   3
      Top             =   360
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   3120
      TabIndex        =   4
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancelAll 
      Caption         =   "Cancel &All"
      Height          =   375
      Left            =   3120
      TabIndex        =   5
      Top             =   1320
      Width           =   1095
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "C&lear"
      Height          =   375
      Left            =   3120
      TabIndex        =   6
      Top             =   1800
      Width           =   1095
   End
   Begin VB.Label lblProduct 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Product"
      Height          =   195
      Left            =   240
      TabIndex        =   9
      Top             =   960
      Width           =   555
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
   Begin VB.Label lblPrice 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Price"
      Height          =   195
      Left            =   240
      TabIndex        =   7
      Top             =   1680
      Width           =   360
   End
End
Attribute VB_Name = "frmEdit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim CurrentIndex As Long
Dim lstIndex As Long
Public StopEdit As Boolean

Private Sub cmdCancel_Click()
    Unload frmEdit
End Sub

Private Sub cmdCancelAll_Click()
    StopEdit = True
    Unload frmEdit
End Sub

Private Sub cmdClear_Click()
    txtBarcode.Text = vbNullString
    txtProduct.Text = vbNullString
    txtPrice.Text = vbNullString
End Sub

Sub StartEdit(hIndex As Long, ListIndex As Long)
    Dim DB As Database
    Dim RS As Recordset
    Dim WS As Workspace

    Set WS = DBEngine.Workspaces(0)
    Set DB = WS.OpenDatabase(App.Path & "\bdb.mdb")
    Set RS = DB.OpenRecordset("Products", dbOpenTable)
    
    StopEdit = False
    
    RS.Move hIndex
    
    txtBarcode.Text = RS("Barcode")
    txtProduct.Text = RS("Product")
    txtPrice.Text = RS("Price")
    
    CurrentIndex = hIndex
    lstIndex = ListIndex
    
    RS.Close
    
    cmdOK.Default = False
End Sub

Private Sub cmdOK_Click()
    On Error GoTo EditError
    Dim DB As Database
    Dim RS As Recordset
    Dim WS As Workspace

    If Trim$(txtBarcode.Text) = vbNullString Then Err.Raise 109, , "Please fill in the Barcode field"
    If Trim$(txtProduct.Text) = vbNullString Then Err.Raise 110, , "Please fill in the Product field"
    If Trim$(txtPrice.Text) = vbNullString Then Err.Raise 111, , "Please fill in the Price field"
    
    If Left$(txtBarcode.Text, 1) = "#" Then
        txtBarcode.Text = Right$(txtBarcode.Text, Len(txtBarcode.Text) - 1)
    End If
    
    If IsNumeric(txtPrice.Text) = False Then Err.Raise 112, , "Invalid price"
    If IsNumeric(txtBarcode.Text) = False Then Err.Raise 113, , "Invalid barcode"

    Set WS = DBEngine.Workspaces(0)
    Set DB = WS.OpenDatabase(App.Path & "\bdb.mdb")
    Set RS = DB.OpenRecordset("Products", dbOpenTable)
    
    RS.Move CurrentIndex
    RS.Edit
    
    RS("Barcode") = txtBarcode.Text
    RS("Product") = txtProduct.Text
    RS("Price") = txtPrice.Text
    
    RS.Update
    
    With frmMain.lstDB
    .ListItems(lstIndex).Text = RS("Barcode")
    .ListItems(lstIndex).ListSubItems(1).Text = RS("Product")
    .ListItems(lstIndex).ListSubItems(2).Text = Format(RS("Price"), "$#,##0.00")
    .ListItems(lstIndex).ListSubItems(3).Text = Format(RS("Price"), "00000000000000000000000000.00")
    .ListItems(lstIndex).ListSubItems(4).Text = Format(RS("Barcode"), "000000000000000000000000000")
    End With
    
    RS.Close
    
    MsgBox "Record successfully changed", vbInformation
    
    Unload frmEdit
    Exit Sub
    
EditError:
MsgBox Err.Description, vbExclamation
End Sub

Private Sub txtBarcode_GotFocus()
    txtBarcode.SelStart = 0
    txtBarcode.SelLength = Len(txtBarcode)
End Sub

Private Sub txtBarcode_KeyDown(KeyCode As Integer, Shift As Integer)
    If KeyCode = vbKeyReturn Then
        txtProduct.SetFocus
    End If
End Sub

Private Sub txtPrice_Change()
    cmdOK.Default = True
End Sub

Private Sub txtPrice_GotFocus()
    txtPrice.SelStart = 0
    txtPrice.SelLength = Len(txtPrice.Text)
End Sub

Private Sub txtProduct_GotFocus()
    txtProduct.SelStart = 0
    txtProduct.SelLength = Len(txtProduct.Text)
End Sub

Private Sub txtProduct_KeyDown(KeyCode As Integer, Shift As Integer)
    If KeyCode = vbKeyReturn Then
        txtPrice.SetFocus
    End If
End Sub
