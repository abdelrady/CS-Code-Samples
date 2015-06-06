VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form fCashierManager 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   4080
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9240
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Cashier Manager.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4080
   ScaleWidth      =   9240
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton cmdExit 
      Cancel          =   -1  'True
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   450
      Left            =   5940
      TabIndex        =   9
      Top             =   3285
      Width           =   2985
   End
   Begin VB.TextBox txtConfirm 
      BeginProperty Font 
         Name            =   "Wingdings"
         Size            =   12
         Charset         =   2
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      IMEMode         =   3  'DISABLE
      Left            =   5940
      MaxLength       =   20
      PasswordChar    =   "l"
      TabIndex        =   6
      Top             =   1755
      Width           =   3000
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Left            =   5940
      TabIndex        =   7
      Top             =   2655
      Width           =   1410
   End
   Begin VB.CommandButton cmdNew 
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Left            =   7515
      TabIndex        =   8
      Top             =   2655
      Width           =   1410
   End
   Begin VB.TextBox txtPassword 
      BeginProperty Font 
         Name            =   "Wingdings"
         Size            =   12
         Charset         =   2
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      IMEMode         =   3  'DISABLE
      Left            =   5940
      MaxLength       =   20
      PasswordChar    =   "l"
      TabIndex        =   4
      Top             =   1260
      Width           =   3000
   End
   Begin VB.TextBox txtUsername 
      Height          =   405
      Left            =   5940
      MaxLength       =   20
      TabIndex        =   2
      Top             =   765
      Width           =   3000
   End
   Begin MSComctlLib.ListView lsvCashier 
      Height          =   3405
      Left            =   330
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   330
      Width           =   4025
      _ExtentX        =   7091
      _ExtentY        =   6006
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      Appearance      =   1
      NumItems        =   2
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Username"
         Object.Width           =   3881
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   2
         SubItemIndex    =   1
         Text            =   "Password"
         Object.Width           =   2646
      EndProperty
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   195
      Left            =   8820
      TabIndex        =   11
      Top             =   2295
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   6285
      TabIndex        =   10
      Top             =   330
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "4"
      Height          =   285
      Left            =   4680
      TabIndex        =   5
      Top             =   1800
      Width           =   135
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "3"
      Height          =   285
      Left            =   4695
      TabIndex        =   3
      Top             =   1305
      Width           =   135
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      Height          =   285
      Left            =   4695
      TabIndex        =   1
      Top             =   840
      Width           =   135
   End
End
Attribute VB_Name = "fCashierManager"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdExit_Click()
    Unload Me
    
End Sub

Private Sub cmdNew_Click()
    lsvCashier.ListItems(1).Selected = True
    lsvCashier.SelectedItem.EnsureVisible
    lsvCashier_ItemClick lsvCashier.SelectedItem
    
End Sub

Private Sub cmdSave_Click()
    txtUsername = Trim$(txtUsername)
    txtPassword = Trim$(txtPassword)
    txtConfirm = Trim$(txtConfirm)
    
    On Error Resume Next
    
    If (Len(txtUsername) = 0) Then
        txtUsername.SetFocus
        
    ElseIf (Len(txtPassword) = 0) Then
        txtPassword.SetFocus
        
    ElseIf (Len(txtConfirm) = 0) Then
        txtConfirm.SetFocus
        
    ElseIf (StrComp(txtUsername, "Admin", vbTextCompare) = 0) Then
        MsgBoxEx Me.Name & "0", vbExclamation
        
    ElseIf (StrComp(txtUsername, "Administrator", vbTextCompare) = 0) Then
        MsgBoxEx Me.Name & "0", vbExclamation
        
    ElseIf (Not lsvCashier.FindItem(txtUsername) Is Nothing) Then
        If (StrComp(lsvCashier.SelectedItem.Text, txtUsername.Tag, vbTextCompare) = 0) Then
            '
            ' USERNAME AND/OR PASSWORD HAS BEEN BEEN CHANGED
            '
            Err.Clear
            CON.Execute "UPDATE cashiers SET username='" & txtUsername & "', userpassword='" & txtPassword & "' WHERE userid=" & lsvCashier.SelectedItem.Tag
            
            If (Err.Number = 0) Then
                lsvCashier.SelectedItem.Text = txtUsername
                lsvCashier.SelectedItem.SubItems(1) = String$(Len(txtPassword), "X")
                lsvCashier.SelectedItem.ListSubItems(1).Tag = txtPassword
                
                MsgBoxEx Me.Name & "1", vbInformation
            Else
                MsgBoxEx Me.Name & "2", vbExclamation, Err.Number
            End If
        Else
            MsgBoxEx Me.Name & "3", vbExclamation
        End If
        
    ElseIf (Not StrComp(txtPassword, txtConfirm) = 0) Then
        MsgBoxEx Me.Name & "4", vbExclamation
        txtConfirm.SetFocus
        SendKeys "{HOME}+{END}"
        
    ElseIf (lsvCashier.SelectedItem.Index = 1) Then
        '
        ' ADD NEW CASHIER
        '
        Err.Clear
        CON.Execute "INSERT INTO cashiers (username,userpassword) VALUES ('" & txtUsername & "','" & txtPassword & "')"
        
        If (Err.Number = 0) Then
            lsvCashier.ListItems.Add(, , txtUsername).Selected = True
            
            With lsvCashier.SelectedItem
                .SubItems(1) = String$(Len(txtPassword), "X")
                .ListSubItems(1).Tag = txtPassword
                .EnsureVisible
                
                If (mPublic.OpenRecordset("SELECT userid FROM cashiers WHERE username='" & txtUsername & "'")) Then
                    .Tag = CStr(REC("userid"))
                End If
            End With
            
            MsgBoxEx Me.Name & "5", vbInformation
        Else
            MsgBoxEx Me.Name & "6", vbExclamation, Err.Number
        End If
        
        txtUsername.SetFocus
    Else
        '
        ' ONLY THE PASSWORD HAS BEEN CHANGED
        '
        Err.Clear
        CON.Execute "UPDATE cashiers SET username='" & txtUsername & "', userpassword='" & txtPassword & "' WHERE userid=" & lsvCashier.SelectedItem.Tag
        
        If (Err.Number = 0) Then
            With lsvCashier.SelectedItem
                .Text = txtUsername
                .SubItems(1) = String$(Len(txtPassword), "X")
                .ListSubItems(1).Tag = txtPassword
            End With
            
            MsgBoxEx Me.Name & "7", vbInformation
        Else
            MsgBoxEx Me.Name & "8", vbExclamation, Err.Number
        End If
    End If
    
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    LoadCashiers
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            End If
        End With
    Next
    
End Sub

Private Sub LoadCashiers()
    If (OpenRecordset("SELECT * FROM cashiers ORDER BY username ASC")) Then
        Redraw lsvCashier, False
        
        On Error Resume Next
        
        Dim n As Integer
        
        If (lsvCashier.ListItems.Count > 0) Then
            n = lsvCashier.SelectedItem.Index ' Store selected item's index
        End If
        
        lsvCashier.ListItems.Clear
        lsvCashier.ListItems.Add(, , "NEW CASHIER").ForeColor = vbRed
        
        Dim i As ListItem
        
        While Not REC.EOF
            Set i = lsvCashier.ListItems.Add(, , REC("username"))
                i.SubItems(1) = String$(Len(REC("userpassword")), "X")
                i.ListSubItems(1).Tag = REC("userpassword")
                i.Tag = REC("userid")
                
            REC.MoveNext
        Wend
        
        If (n > 0 And n <= lsvCashier.ListItems.Count) Then
            lsvCashier.ListItems(n).Selected = True ' Restore last selected item
            lsvCashier.SelectedItem.EnsureVisible
            lsvCashier.SetFocus
        End If
        
        Redraw lsvCashier, True
    End If
    
    Exit Sub
Err_Handler:
    CON.RollbackTrans
    MsgBoxEx Me.Name & "9", vbCritical, Err.Number
    
End Sub

Private Sub lsvCashier_ItemClick(ByVal Item As MSComctlLib.ListItem)
    On Error Resume Next
    
    If (Item.Index = 1) Then
        txtUsername = ""
        txtPassword = ""
        txtConfirm = ""
        txtUsername.SetFocus
    Else
        txtUsername.Tag = Item.Text
        txtUsername = Item.Text
        txtPassword = Item.ListSubItems(1).Tag
        txtConfirm = ""
        cmdSave.Enabled = (Not Len(Item.Tag) = 0)
        txtConfirm.SetFocus
    End If
    
End Sub
