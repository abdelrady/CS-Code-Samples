VERSION 5.00
Begin VB.Form frmRegister 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Register"
   ClientHeight    =   2370
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   4770
   Icon            =   "frmRegister.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2370
   ScaleWidth      =   4770
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtKey 
      Height          =   1095
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   1
      Top             =   1080
      Width           =   2775
   End
   Begin VB.TextBox txtName 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   2775
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3360
      TabIndex        =   3
      Top             =   960
      Width           =   1215
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3360
      TabIndex        =   2
      Top             =   360
      Width           =   1215
   End
   Begin VB.Label lblKey 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Enter registration key"
      Height          =   195
      Left            =   120
      TabIndex        =   5
      Top             =   840
      Width           =   1485
   End
   Begin VB.Label lblName 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Enter registration name"
      Height          =   195
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1620
   End
End
Attribute VB_Name = "frmRegister"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Unload frmRegister
End Sub

Private Sub cmdOK_Click()
    Dim uName As String
    Dim GeneratedKey As String
    
    uName = Trim$(txtName.Text)
    
    If Len(uName) < 4 Then
        MsgBox "At least 4 charcters required in the name field.", vbExclamation
        Exit Sub
    End If
    
    If Len(uName) > 25 Then
        MsgBox "Too many characters in the name field. There must be no more than 25 characters.", vbExclamation
        Exit Sub
    End If
    
    GeneratedKey = GenRegKey(txtName.Text)
    
    'Checks to see if the registration information is valid.
    'If -10 is returned that is an error code so we don't want it being
    'registered if -10 is returned and the user put -10 in the key field.
    If txtKey.Text = GeneratedKey And GeneratedKey <> "-10" Then
        'Save username and key to the registry. TO be even safer we could
        'use simple encryption to encrypt the key so that no one using
        'the computer could discover it. I didn't think about that until now
        'but it should be simple to do.
        SaveSetting AppName, "Options", "Reg Name", txtName.Text
        SaveSetting AppName, "Options", "Reg Key", txtKey.Text
        MsgBox "Registration key accepted. Thank you for registering", vbInformation
        Unload frmRegister
    Else
        MsgBox "Registration key incorrect", vbExclamation
    End If
End Sub
