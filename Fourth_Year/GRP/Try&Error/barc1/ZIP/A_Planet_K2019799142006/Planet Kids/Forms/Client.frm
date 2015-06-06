VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form fClient 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   5310
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
   Icon            =   "Client.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5310
   ScaleWidth      =   5685
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton cmdClient 
      Cancel          =   -1  'True
      Caption         =   "11"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   510
      Index           =   1
      Left            =   4125
      TabIndex        =   16
      Top             =   4470
      Width           =   1300
   End
   Begin VB.CommandButton cmdClient 
      Caption         =   "10"
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
      Height          =   510
      Index           =   0
      Left            =   2745
      TabIndex        =   15
      Top             =   4470
      Width           =   1300
   End
   Begin MSComCtl2.DTPicker dtpClient 
      Height          =   435
      Left            =   2745
      TabIndex        =   10
      Top             =   2250
      Width           =   2685
      _ExtentX        =   4736
      _ExtentY        =   767
      _Version        =   393216
      CustomFormat    =   "MMMM dd, yyyy"
      Format          =   20643843
      CurrentDate     =   38965
   End
   Begin VB.OptionButton optClient 
      Caption         =   "9"
      Height          =   390
      Index           =   1
      Left            =   4200
      TabIndex        =   8
      Tag             =   "F"
      Top             =   1770
      Width           =   1200
   End
   Begin VB.OptionButton optClient 
      Caption         =   "8"
      Height          =   390
      Index           =   0
      Left            =   2760
      TabIndex        =   7
      Tag             =   "M"
      Top             =   1770
      Value           =   -1  'True
      Width           =   1200
   End
   Begin VB.TextBox txtClient 
      Alignment       =   1  'Right Justify
      Height          =   405
      Index           =   4
      Left            =   2745
      MaxLength       =   50
      TabIndex        =   14
      Top             =   3720
      Width           =   2685
   End
   Begin VB.TextBox txtClient 
      Alignment       =   1  'Right Justify
      Height          =   825
      Index           =   3
      Left            =   1440
      MaxLength       =   50
      TabIndex        =   12
      Top             =   2790
      Width           =   3990
   End
   Begin VB.TextBox txtClient 
      Alignment       =   1  'Right Justify
      Height          =   405
      Index           =   2
      Left            =   1995
      MaxLength       =   25
      TabIndex        =   5
      Top             =   1245
      Width           =   3435
   End
   Begin VB.TextBox txtClient 
      Alignment       =   1  'Right Justify
      Height          =   405
      Index           =   1
      Left            =   1995
      MaxLength       =   25
      TabIndex        =   3
      Top             =   735
      Width           =   3435
   End
   Begin VB.TextBox txtClient 
      Alignment       =   1  'Right Justify
      Height          =   405
      Index           =   0
      Left            =   2745
      MaxLength       =   8
      TabIndex        =   1
      Top             =   240
      Width           =   2685
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
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
      Height          =   240
      Index           =   6
      Left            =   255
      TabIndex        =   13
      Top             =   3795
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
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
      Height          =   240
      Index           =   5
      Left            =   255
      TabIndex        =   11
      Top             =   2865
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   4
      Left            =   255
      TabIndex        =   9
      Top             =   2325
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   3
      Left            =   255
      TabIndex        =   6
      Top             =   1815
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
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
      Height          =   240
      Index           =   2
      Left            =   255
      TabIndex        =   4
      Top             =   1320
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
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
      Height          =   240
      Index           =   1
      Left            =   255
      TabIndex        =   2
      Top             =   825
      Width           =   105
   End
   Begin VB.Label lblClient 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
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
      Height          =   240
      Index           =   0
      Left            =   255
      TabIndex        =   0
      Top             =   300
      Width           =   105
   End
End
Attribute VB_Name = "fClient"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_bEditMode As Boolean
Private m_sRegNumbr As String

Public Property Let EditMode(Value As Boolean)
    m_bEditMode = Value
    
End Property

Public Property Let RegNumber(ByVal Value As String)
    m_sRegNumbr = Value
    
End Property

Private Sub cmdClient_Click(Index As Integer)
    If (Index = 0) Then
        Dim i As Integer
        
        For i = 0 To 2
            If (Len(txtClient(i).Text) = 0) Then ' Find empty textbox
                txtClient(i).SetFocus ' Focus the textbox
                Exit Sub
            End If
        Next
        
        On Error Resume Next
        
        If (m_bEditMode) Then
            Err.Clear
            CON.Execute "UPDATE clients SET firstname='" & txtClient(1) & "', lastname='" & txtClient(2) & "', gender='" & IIf(optClient(0).Value, "M", "F") & "', birthdate=#" & dtpClient.Value & "#, address='" & txtClient(3) & "', guardian='" & txtClient(4) & "' WHERE regnum=" & txtClient(0)
            
            If (Err.Number = 0) Then
                MsgBoxEx Me.Name & "0", vbInformation
            Else
                MsgBoxEx Me.Name & "1", vbExclamation, Err.Number
            End If
        Else
            If (mPublic.IsRegNumberValid(txtClient(0))) Then
                MsgBoxEx Me.Name & "2", vbExclamation
                Exit Sub
            End If
            
            Err.Clear
            CON.Execute "INSERT INTO clients (regnum,firstname,lastname,gender,birthdate,address,guardian) VALUES (" & txtClient(0) & ",'" & txtClient(1) & "','" & txtClient(2) & "','" & IIf(optClient(0).Value, "M", "F") & "',#" & dtpClient.Value & "#,'" & txtClient(3) & "','" & txtClient(4) & "')"
            
            If (Err.Number = 0) Then
                MsgBoxEx Me.Name & "3", vbInformation
            Else
                MsgBoxEx Me.Name & "4", vbExclamation, Err.Number
            End If
            
            With fMain.lsvClients
                .ListItems(.ListItems.Count).Selected = True
            End With
        End If
        
        mPublic.LoadClientsLists fMain.lsvClients
    End If
    
    Unload Me
    
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    
    optClient(0).BackColor = BackColor
    optClient(1).BackColor = BackColor
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is OptionButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            End If
        End With
    Next
    
    If (Not m_bEditMode) Then
        Caption = cINI.Value("FormStrings", Me.Name & "0a")
        
        Dim i As Integer
        For i = 0 To 4
            txtClient(i).Text = ""
        Next
        
        mPublic.AcceptNumbersOnly txtClient(0) ' Registration number
        
        dtpClient.MaxDate = Date$
        dtpClient.Value = Date$
    Else
        Caption = cINI.Value("FormStrings", Me.Name & "0b")
        
        txtClient(0) = m_sRegNumbr
        txtClient(0).Enabled = False
        txtClient(0).BackColor = vbButtonFace
        
        On Error GoTo Err_Handler
        
        If (mPublic.OpenRecordset("SELECT * FROM clients WHERE regnum=" & txtClient(0))) Then
            If (REC.RecordCount > 0) Then
                txtClient(1) = REC("firstname")
                txtClient(2) = REC("lastname")
                
                If (REC("gender") = "M") Then
                    optClient(0).Value = True
                Else
                    optClient(1).Value = True
                End If
                
                dtpClient.Value = CDate(REC("birthdate"))
                txtClient(3) = REC("address")
                txtClient(4) = REC("guardian")
            End If
        Else
            MsgBoxEx Me.Name & "5", vbExclamation
        End If
        
        Exit Sub
Err_Handler:
        MsgBoxEx Me.Name & "6", vbExclamation, Err.Number
    End If
    
End Sub
