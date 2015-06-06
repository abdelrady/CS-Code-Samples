VERSION 5.00
Begin VB.Form frmPreview 
   Caption         =   "Barcode Printing"
   ClientHeight    =   8205
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9075
   LinkTopic       =   "Form2"
   MDIChild        =   -1  'True
   ScaleHeight     =   8205
   ScaleWidth      =   9075
   Begin VB.PictureBox PicOuter 
      BackColor       =   &H8000000C&
      Height          =   7575
      Left            =   120
      ScaleHeight     =   7515
      ScaleWidth      =   4995
      TabIndex        =   0
      Top             =   480
      Width           =   5055
      Begin VB.HScrollBar HScroll 
         Height          =   255
         Left            =   0
         TabIndex        =   3
         Top             =   7320
         Width           =   3255
      End
      Begin VB.VScrollBar VScroll 
         Height          =   3135
         Left            =   4680
         TabIndex        =   2
         Top             =   0
         Width           =   255
      End
      Begin VB.PictureBox picPreview 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         Height          =   7455
         Left            =   120
         ScaleHeight     =   7395
         ScaleWidth      =   4515
         TabIndex        =   1
         Top             =   0
         Width           =   4575
      End
   End
End
Attribute VB_Name = "frmPreview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub PaperSize()
Dim PicLeft         As Integer
Dim PicTop          As Integer

    picPreview.Width = FarRightMargin
    picPreview.Height = FarTopMargin
    PicLeft = (PicOuter.Width - picPreview.Width) / 2
    If PicLeft <= 0 Then
        PicLeft = 0
    End If
    PicTop = (PicOuter.Height - picPreview.Height) / 2
    If PicTop <= 0 Then
        PicTop = 0
    End If
    picPreview.Left = PicLeft
    picPreview.Top = PicTop
    
    ResizeScrollBars
End Sub

Private Sub Form_Load()
Call PaperSize
End Sub

Private Sub Form_Resize()
    PicOuter.Width = Me.Width - PicOuter.Left - 120
    PicOuter.Height = Me.Height - PicOuter.Top - 400
    Call PaperSize
End Sub

Private Sub HScroll_Change()
    picPreview.Left = (-HScroll.Value)
End Sub

Private Sub HScroll_Scroll()
    picPreview.Left = (-HScroll.Value)
End Sub

Private Sub VScroll_Change()
    picPreview.Top = (-VScroll.Value)
End Sub

Private Sub VScroll_Scroll()
    picPreview.Top = (-VScroll.Value)
End Sub

Private Sub ResizeScrollBars()
    Me.VScroll.Left = PicOuter.Width - Me.VScroll.Width - 50
    
    Me.HScroll.Top = PicOuter.Height - Me.HScroll.Height - 60
    
    If Me.VScroll.Visible = True Then
        Me.HScroll.Width = Me.VScroll.Left
    Else
        Me.HScroll.Width = Me.PicOuter.Width - 70
    End If
    If Me.HScroll.Visible = True Then
        Me.VScroll.Height = Me.HScroll.Top
    Else
        Me.VScroll.Height = Me.PicOuter.Height - 70
    End If
    
    With VScroll
        If picPreview.Height > PicOuter.Height Then
            .Visible = True
            .Max = picPreview.Height - PicOuter.Height + HScroll.Height + 60
            .Min = 0
            .ZOrder 0
            .LargeChange = picPreview.Height - PicOuter.Height
            VScroll_Scroll
        Else
            .Max = 0
            .Visible = False
        End If
    End With
    With HScroll
        If picPreview.Width > PicOuter.Width Then
            .Visible = True
            .Max = picPreview.Width - PicOuter.Width + VScroll.Width + 40
            .Min = 0
            .ZOrder 0
            .LargeChange = picPreview.Width - PicOuter.ScaleWidth
            HScroll_Scroll
        Else
            .Max = 0
            .Visible = False
        End If
    End With
End Sub

