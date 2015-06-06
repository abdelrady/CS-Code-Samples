VERSION 5.00
Begin VB.Form frmBooks 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4785
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   5670
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   319
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   378
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtValue 
      Height          =   285
      Left            =   2880
      TabIndex        =   3
      Top             =   3960
      Width           =   2655
   End
   Begin VB.ComboBox cboFields 
      Height          =   315
      Left            =   120
      TabIndex        =   2
      Text            =   "Select Your Field"
      Top             =   3960
      Width           =   2655
   End
   Begin VB.ListBox lstVariables 
      Height          =   3765
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   5415
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   375
      Left            =   4320
      TabIndex        =   0
      Top             =   4320
      Width           =   1215
   End
End
Attribute VB_Name = "frmBooks"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cboFields_Click()
 If Books.Fields(cboFields.Text) = 0 Then
 txtValue.Text = ""
 Else
 If IsNull(Books.Fields(cboFields.Text)) Then
 txtValue.Text = ""
 Else
 txtValue.Text = Books.Fields(cboFields.Text)
 End If
 End If
End Sub

Private Sub cmdCancel_Click()
Unload Me
End Sub

Private Sub cmdOK_Click()
Me.Hide
frmSignout.ZOrder 0
End Sub

Private Sub Form_Load()
    i = 0
    Set Books = Db.OpenRecordset("Select * From [Books]")
    Do While Not Books.EOF
    'lstBarcodeTitle.AddItem (Books.Fields("Barcode").Value & " - " & Books.Fields("Title").Value)
    Books.MoveNext
    Loop
    Set Books = Db.OpenRecordset(SearchSTR) ' Open Database Table
    '\B/ -- Loads Field Names Into An Array and Combo Box---
    For Each oField In Db.TableDefs("Books").Fields
            cboFields.AddItem oField.Name
            Fields(i) = oField.Name
            i = i + 1
    Next oField
    '/E\ ---------Finish Loading Info about Table--------
    For Counter = 0 To i - 1
    lstVariables.AddItem Fields(Counter) & ": " & Books.Fields(Counter)
    Next Counter
    
End Sub

Private Sub List1_Click()

End Sub

Private Sub txtValue_Change()
Books.Edit
Books.Fields(cboFields.Text) = txtValue.Text
Books.Update
    lstVariables.Clear
    For Counter = 0 To i - 1
    lstVariables.AddItem Fields(Counter) & ": " & Books.Fields(Counter)
    Next Counter
End Sub
