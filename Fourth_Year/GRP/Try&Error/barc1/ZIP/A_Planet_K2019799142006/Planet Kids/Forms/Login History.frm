VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form fLoginHistory 
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
   Icon            =   "Login History.frx":0000
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
   Begin MSComCtl2.DTPicker dtpLogin 
      Height          =   390
      Left            =   3135
      TabIndex        =   2
      Top             =   3855
      Width           =   2220
      _ExtentX        =   3916
      _ExtentY        =   688
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      CustomFormat    =   "MMMM dd, yyyy"
      Format          =   20643843
      CurrentDate     =   38968
   End
   Begin VB.CommandButton cmdRefresh 
      Caption         =   "1"
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
      Left            =   330
      TabIndex        =   1
      Top             =   3855
      Width           =   2700
   End
   Begin MSComctlLib.ListView lsvLogin 
      Height          =   3405
      Left            =   330
      TabIndex        =   0
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
      NumItems        =   3
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Username"
         Object.Width           =   3704
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   2
         SubItemIndex    =   1
         Text            =   "Login"
         Object.Width           =   2293
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   2
         SubItemIndex    =   2
         Text            =   "Logout"
         Object.Width           =   2293
      EndProperty
   End
   Begin VB.CommandButton cmdExit 
      Cancel          =   -1  'True
      Caption         =   "2"
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
      Height          =   465
      Left            =   330
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   4395
      Width           =   5025
   End
End
Attribute VB_Name = "fLoginHistory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdExit_Click()
    Unload Me
    
End Sub

Private Sub cmdRefresh_Click()
    On Error GoTo Err_Handler
    
    If (mPublic.OpenRecordset("SELECT * FROM loginhistory WHERE logindate=#" & dtpLogin.Value & "# AND logouttime<>NULL ORDER BY logintime DESC")) Then
        Redraw lsvLogin, False
        
        Dim RC As Recordset
        Set RC = REC.Clone
        
        Dim n As Integer
        
        If (lsvLogin.ListItems.Count > 0) Then
            n = lsvLogin.SelectedItem.Index
        End If
        
        lsvLogin.ListItems.Clear
        
        Dim Item As ListItem
        
        While Not RC.EOF
            Set Item = lsvLogin.ListItems.Add(, , "")
                
                If (RC("userid") = 0) Then
                    Item.Text = "Administrator"
                    Item.ForeColor = vbBlue
                Else
                    Item.Text = mPublic.FromUserIDToName(RC("userid"))
                End If
                
                Item.SubItems(1) = Format$(RC("logintime"), "HH:MM AM/PM")
                Item.SubItems(2) = Format$(RC("logouttime"), "HH:MM AM/PM")
                
                RC.MoveNext
        Wend
            
            RC.Close
        Set RC = Nothing
        
        If (n > 0 And n <= lsvLogin.ListItems.Count) Then
            lsvLogin.ListItems(n).Selected = True ' Restore last selected item
            lsvLogin.SelectedItem.EnsureVisible
        End If
        
        Redraw lsvLogin, True
    End If
    
Err_Handler:
End Sub

Private Sub dtpLogin_Change()
    cmdRefresh_Click
    
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    dtpLogin.MaxDate = Date
    dtpLogin.Value = Date
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
            End If
        End With
    Next
    
    cmdRefresh_Click
    
End Sub
