VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form fCardManager 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   5205
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5685
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Card Manager.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5205
   ScaleWidth      =   5685
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton cmdDel 
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   4605
      TabIndex        =   4
      Top             =   3855
      Width           =   735
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "1"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   3810
      TabIndex        =   3
      Top             =   3855
      Width           =   735
   End
   Begin VB.TextBox txtCard 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   330
      MaxLength       =   15
      TabIndex        =   0
      Top             =   3855
      Width           =   3420
   End
   Begin MSComctlLib.ListView lsvCards 
      Height          =   3405
      Left            =   330
      TabIndex        =   1
      Top             =   330
      Width           =   5025
      _ExtentX        =   8864
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
         Text            =   "Card Number"
         Object.Width           =   4762
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Status"
         Object.Width           =   3528
      EndProperty
   End
   Begin VB.CommandButton cmdExit 
      Cancel          =   -1  'True
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   465
      Left            =   330
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   4395
      Width           =   5025
   End
End
Attribute VB_Name = "fCardManager"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAdd_Click()
    On Error Resume Next
    
    txtCard = Trim$(txtCard)
    
    If (Len(txtCard) > 0) Then
        If (Not lsvCards.FindItem(txtCard) Is Nothing) Then
            MsgBoxEx Me.Name & "0"
            txtCard.Text = ""
            txtCard.SetFocus
            Exit Sub
        End If
        
        Dim Item As ListItem
        Set Item = lsvCards.ListItems.Add(, , txtCard)
            Item.SubItems(1) = "OK"
            Item.Selected = True
            Item.EnsureVisible
            
            txtCard.Text = ""
            txtCard.SetFocus
    Else
        txtCard.SetFocus
    End If
    
End Sub

Private Sub cmdDel_Click()
    If (lsvCards.SelectedItem Is Nothing) Then
        Exit Sub
    End If
    
    lsvCards.SelectedItem.EnsureVisible
    
    Dim iRet As VbMsgBoxResult
    
    If (StrComp(lsvCards.SelectedItem.SubItems(1), "OK", vbTextCompare) = 0) Then
        iRet = MsgBoxEx(Me.Name & "1", vbInformation + vbYesNo)
    Else
        iRet = vbYes
    End If
    
    If (iRet = vbYes) Then
        Dim i As Integer
            i = lsvCards.SelectedItem.Index
            
            If (i > 1) Then
                lsvCards.ListItems(i - 1).Selected = True
                lsvCards.SelectedItem.EnsureVisible
            End If
            
        lsvCards.ListItems.Remove i
        lsvCards.SetFocus
    End If
    
End Sub

Private Sub cmdExit_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    LoadSaveCards ' Load card number lists
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
            End If
        End With
    Next
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    LoadSaveCards True
    
End Sub

Private Sub LoadSaveCards(Optional Save As Boolean)
    If (Save) Then
        On Error GoTo Err_Handler
        
        CON.BeginTrans
        CON.Execute "DELETE FROM cardnums" ' Remove all existing cards first
        
        Dim n As Integer
        Dim m As Integer
            m = lsvCards.ListItems.Count
            
        For n = 1 To m
            CON.Execute "INSERT INTO cardnums (cardnum,lostdamaged) VALUES ('" & lsvCards.ListItems(n).Text & "'," & (Not lsvCards.ListItems(n).SubItems(1) = "OK") & ")"
        Next
        
        CON.CommitTrans
        Exit Sub
    End If
    
    If (OpenRecordset("SELECT * FROM cardnums ORDER BY cardnum ASC")) Then
        On Error Resume Next
        
        Redraw lsvCards, False
        
        Dim Item As ListItem
        
        While Not REC.EOF
            Set Item = lsvCards.ListItems.Add(, , REC("cardnum"))
                If (REC("lostdamaged") = False) Then
                    Item.SubItems(1) = "OK"
                    Item.ListSubItems(1).ForeColor = vbBlue
                Else
                    Item.SubItems(1) = "Lost/Damaged"
                    Item.ListSubItems(1).ForeColor = vbRed
                End If
                
            REC.MoveNext
        Wend
        
        Redraw lsvCards, True
    End If
    
    Exit Sub
Err_Handler:
    CON.RollbackTrans
    MsgBoxEx Me.Name & "2", vbCritical, Err.Number
    
End Sub
