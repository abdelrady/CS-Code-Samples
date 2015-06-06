VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "IP-Barcode:"
   ClientHeight    =   2100
   ClientLeft      =   7170
   ClientTop       =   3570
   ClientWidth     =   4440
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2100
   ScaleWidth      =   4440
   Begin VB.CommandButton Command5 
      Caption         =   "Help"
      Height          =   375
      Left            =   60
      TabIndex        =   12
      Top             =   1650
      Width           =   4305
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Exit"
      Height          =   375
      Left            =   3300
      TabIndex        =   8
      Top             =   1260
      Width           =   1065
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Clear"
      Height          =   375
      Left            =   2220
      TabIndex        =   7
      Top             =   1260
      Width           =   1065
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Copy"
      Height          =   375
      Left            =   1140
      TabIndex        =   6
      Top             =   1260
      Width           =   1065
   End
   Begin VB.Frame Frame1 
      Caption         =   "IP-Barcode:"
      Height          =   1155
      Left            =   60
      TabIndex        =   9
      Top             =   30
      Width           =   4275
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   1980
         MaxLength       =   3
         TabIndex        =   1
         Text            =   "0"
         Top             =   300
         Width           =   465
      End
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   2490
         MaxLength       =   3
         TabIndex        =   2
         Text            =   "0"
         Top             =   300
         Width           =   465
      End
      Begin VB.TextBox Text3 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   3000
         MaxLength       =   3
         TabIndex        =   3
         Text            =   "0"
         Top             =   300
         Width           =   465
      End
      Begin VB.TextBox Text4 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   3510
         MaxLength       =   3
         TabIndex        =   4
         Text            =   "0"
         Top             =   300
         Width           =   465
      End
      Begin VB.TextBox Text5 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   1980
         TabIndex        =   5
         Text            =   "0"
         Top             =   690
         Width           =   1995
      End
      Begin VB.Label Label2 
         Caption         =   "IP Barcode Number:"
         Height          =   195
         Left            =   300
         TabIndex        =   11
         Top             =   690
         Width           =   1635
      End
      Begin VB.Label Label1 
         Caption         =   "IP Address Number:"
         Height          =   195
         Left            =   300
         TabIndex        =   10
         Top             =   330
         Width           =   1635
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Calculate"
      Height          =   375
      Left            =   60
      TabIndex        =   0
      Top             =   1260
      Width           =   1065
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
On Error Resume Next
Dim a, b, c, d, value
a = Val(Text1.Text) * 16777216
b = Val(Text2.Text) * 65536
c = Val(Text3.Text) * 256
d = Val(Text4.Text) * 1
value = Val(a) + Val(b) + Val(c) + Val(d)
Text5.Text = value
End Sub

Private Sub Command2_Click()
On Error Resume Next
Clipboard.SetText Text5.Text
End Sub

Private Sub Command3_Click()
On Error Resume Next
Text1.Text = "0"
Text2.Text = "0"
Text3.Text = "0"
Text4.Text = "0"
Text5.Text = "0"
End Sub

Private Sub Command4_Click()
On Error Resume Next
Unload Me
End
End Sub

Private Sub Command5_Click()
Load Form2
Form2.Show vbModal
End Sub
