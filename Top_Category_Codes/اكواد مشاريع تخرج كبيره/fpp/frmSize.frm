VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmSize 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Size"
   ClientHeight    =   975
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   1815
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   975
   ScaleWidth      =   1815
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin MSComCtl2.UpDown UpDownWidth 
      Height          =   315
      Left            =   1530
      TabIndex        =   4
      Top             =   135
      Width           =   240
      _ExtentX        =   423
      _ExtentY        =   556
      _Version        =   393216
      Value           =   1
      BuddyControl    =   "txtWidth"
      BuddyDispid     =   196610
      OrigLeft        =   915
      OrigTop         =   255
      OrigRight       =   1155
      OrigBottom      =   510
      Increment       =   10
      Max             =   1000
      Min             =   1
      SyncBuddy       =   -1  'True
      BuddyProperty   =   65547
      Enabled         =   -1  'True
   End
   Begin VB.TextBox txtHeight 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      Height          =   315
      Left            =   705
      Locked          =   -1  'True
      TabIndex        =   1
      Text            =   "100"
      Top             =   615
      Width           =   765
   End
   Begin VB.TextBox txtWidth 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      Height          =   315
      Left            =   705
      Locked          =   -1  'True
      TabIndex        =   0
      Text            =   "100"
      Top             =   135
      Width           =   765
   End
   Begin MSComCtl2.UpDown UpDownHeight 
      Height          =   315
      Left            =   1530
      TabIndex        =   5
      Top             =   615
      Width           =   240
      _ExtentX        =   423
      _ExtentY        =   556
      _Version        =   393216
      Value           =   1
      BuddyControl    =   "txtHeight"
      BuddyDispid     =   196609
      OrigLeft        =   915
      OrigTop         =   255
      OrigRight       =   1155
      OrigBottom      =   510
      Increment       =   10
      Max             =   1000
      Min             =   1
      SyncBuddy       =   -1  'True
      BuddyProperty   =   65547
      Enabled         =   -1  'True
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "height:"
      Height          =   195
      Left            =   60
      TabIndex        =   3
      Top             =   690
      Width           =   480
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "width:"
      Height          =   195
      Left            =   60
      TabIndex        =   2
      Top             =   180
      Width           =   420
   End
End
Attribute VB_Name = "frmSize"
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
'  This form used to resize shp objects
' =========================================================

Option Explicit

Private Sub Form_Activate()
    If SELECTED_SHAPE <> -1 Then
        UpDownWidth.Value = frmMain.shp(SELECTED_SHAPE).Width
        UpDownHeight.Value = frmMain.shp(SELECTED_SHAPE).Height
    End If
End Sub

Private Sub UpDownWidth_Change()
    If SELECTED_SHAPE <> -1 Then
        frmMain.shp(SELECTED_SHAPE).Width = UpDownWidth.Value
        If frmMain.shp(SELECTED_SHAPE).Shape = 1 Or frmMain.shp(SELECTED_SHAPE).Shape = 3 Then
            frmMain.shp(SELECTED_SHAPE).Height = frmMain.shp(SELECTED_SHAPE).Width
            'UpDownHeight.Value = frmmain.shp(SELECTED_SHAPE).Height
        End If
        frmMain.theLineCollection.updateAllLines
        
        ' make sure it repaints:
        frmMain.shp(SELECTED_SHAPE).RepaintBlock
        ' update the selector:
        frmMain.setSelector frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)

        bIS_MODIFIED = True
    End If
End Sub

Private Sub UpDownHeight_Change()
    If SELECTED_SHAPE <> -1 Then
        frmMain.shp(SELECTED_SHAPE).Height = UpDownHeight.Value
        If frmMain.shp(SELECTED_SHAPE).Shape = 1 Or frmMain.shp(SELECTED_SHAPE).Shape = 3 Then
            frmMain.shp(SELECTED_SHAPE).Width = frmMain.shp(SELECTED_SHAPE).Height
            'UpDownWidth.Value = frmmain.shp(SELECTED_SHAPE).Width
        End If
        frmMain.theLineCollection.updateAllLines
        
        ' make sure it repaints:
        frmMain.shp(SELECTED_SHAPE).RepaintBlock
        ' update the selector:
        frmMain.setSelector frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)

        bIS_MODIFIED = True
    End If
End Sub
