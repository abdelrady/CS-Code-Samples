VERSION 5.00
Begin VB.Form frmLang 
   Caption         =   "frmLang"
   ClientHeight    =   3345
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5190
   LinkTopic       =   "Form1"
   ScaleHeight     =   3345
   ScaleWidth      =   5190
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstSource 
      Height          =   3180
      ItemData        =   "frmLang.frx":0000
      Left            =   2685
      List            =   "frmLang.frx":002E
      TabIndex        =   1
      Top             =   105
      Width           =   2475
   End
   Begin VB.ListBox lstTranslation 
      Height          =   3180
      ItemData        =   "frmLang.frx":0103
      Left            =   75
      List            =   "frmLang.frx":0131
      TabIndex        =   0
      Top             =   90
      Width           =   2475
   End
End
Attribute VB_Name = "frmLang"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com
' =========================================================
' The language from used to keep
' caption and messages to avoid
' posting them direct inside
' Visual Basic code (to avoid problems
' with VB editor).
' cLang() function uses this form.
' =========================================================

Option Explicit

