VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVBUTTONS.OCX"
Begin VB.Form frmMaint 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Database Maintenance"
   ClientHeight    =   4515
   ClientLeft      =   4125
   ClientTop       =   4755
   ClientWidth     =   4920
   Icon            =   "frmMaint.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4515
   ScaleWidth      =   4920
   StartUpPosition =   2  'CenterScreen
   Begin LVbuttons.LaVolpeButton cmdFind 
      Height          =   375
      Left            =   3240
      TabIndex        =   1
      Top             =   4080
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Close"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   1
      BCOL            =   12632256
      FCOL            =   0
      FCOLO           =   0
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmMaint.frx":08CA
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   -1  'True
      BSTYLE          =   0
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   1980
      Left            =   120
      TabIndex        =   2
      Top             =   2040
      Width           =   4695
      Begin VB.CommandButton cmdKolej 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   840
         Picture         =   "frmMaint.frx":08E6
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   1080
         Width           =   735
      End
      Begin VB.CommandButton cmdEat 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   840
         Picture         =   "frmMaint.frx":15B0
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Restore Database"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1920
         TabIndex        =   6
         Top             =   1320
         Width           =   2535
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Backup Database"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1920
         TabIndex        =   5
         Top             =   480
         Width           =   2535
      End
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Label3"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   495
      Left            =   120
      TabIndex        =   7
      Top             =   1560
      Width           =   4695
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   $"frmMaint.frx":1E7A
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   80
      TabIndex        =   0
      Top             =   240
      Width           =   4815
   End
End
Attribute VB_Name = "frmMaint"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function CopyFile Lib "kernel32" Alias _
"CopyFileA" (ByVal lpExistingFileName As String, ByVal _
lpNewFileName As String, ByVal bFailIfExists As Long) As Long
Private Sub cmdEat_Click()
Dim strSource As String
Dim strTarget As String
Dim lngRetVal As Long

    If curLevel <> 1 Then
        MsgBox "Warning! Only Administrators are verified for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If

flagBack = 0

frmChosePath.Show vbModal

If flagBack = 0 Then Exit Sub
strSource = App.Path & "\dwnmkn.mdb"
strTarget = myPath2 + "\dwnmkn_b.mdb"

Dim filenum As Integer
Dim masa As String

filenum = FreeFile

'// Copy File
lngRetVal = CopyFile(Trim$(strSource), Trim(strTarget), False)
If lngRetVal Then
    Open App.Path & "\bck.ini" For Output As #filenum
        Write #filenum, myPath2, Format(Now, "hh:mm")
    Close #filenum
    MsgBox "Database has been successfully backed up!" & vbCrLf & _
    "Location: " & myPath2 & vbCrLf & _
    "Time: " & Format(Now, "hh:mm"), vbOKOnly + vbInformation, "Backup Successful"
Else
    MsgBox "Error. Backup attempt failed!"
End If
flagBack = 0

    Dim dt As String
    If FileExists(App.Path & "\bck.ini") = False Then
        Label3.Caption = "Warning! Back up information unavailable..."
        cmdKolej.Enabled = False
        Exit Sub
    Else
        Open App.Path & "\bck.ini" For Input As #filenum
            Input #filenum, myPath, masa
        Close #filenum
        dt = Format(FileLastAccessed(App.Path & "\bck.ini"), "dd/mm/yyyy")
        Label3.Caption = "Database was last backed up on " & dt & vbCrLf & "Time: " & masa
        cmdKolej.Enabled = True
    End If
End Sub

Private Sub cmdFind_Click()
    Unload Me
End Sub

Private Sub cmdKolej_Click()
    Dim filenum As Integer
    Dim myPath As String
    Dim masa As String
    Dim ans As String
    
    On Error GoTo at
    filenum = FreeFile
    
    If curLevel <> 1 Then
        MsgBox "Warning! Only Administrators are verified for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    ans = MsgBox("Restore the backed up database to its original location?", vbYesNo + vbQuestion, "Restore Database")
    If ans <> vbYes Then
        Exit Sub
    End If
    
    If FileExists(App.Path & "\bck.ini") = False Then
        MsgBox "Backed up database information unavailable!", vbOKOnly + vbCritical, "Error"
        Exit Sub
    End If
    Open App.Path & "\bck.ini" For Input As #filenum
        Input #filenum, myPath, masa
    Close #filenum
    
    strSource = myPath & "\dwnmkn_b.mdb"
    strTarget = App.Path & "\dwnmkn.mdb"
    'restore it...
    lngRetVal = CopyFile(Trim$(strSource), Trim(strTarget), False)
    If lngRetVal Then
        MsgBox "Database has been successfully restored!", vbOKOnly + vbInformation, "Restore Successful"
    Else
        MsgBox "Error! Database was not restored!", vbOKOnly + vbCritical, "Restore Unsuccessful"
    End If
    Exit Sub
at:
    MsgBox "Error " & Err.Number & vbCrLf & Err.Description
End Sub

Private Sub Form_Load()
    Dim filenum As Integer
    Dim dt As String
    Dim masa As String
    
    filenum = FreeFile
    
    If FileExists(App.Path & "\bck.ini") = False Then
        Label3.Caption = "Warning! Back up information unavailable..."
        cmdKolej.Enabled = False
        Exit Sub
    Else
        Open App.Path & "\bck.ini" For Input As #filenum
            Input #filenum, myPath, masa
        Close #filenum
        dt = Format(FileLastAccessed(App.Path & "\bck.ini"), "dd/mm/yyyy")
        Label3.Caption = "Database was last backed up on " & dt & vbCrLf & "Time: " & masa
        cmdKolej.Enabled = True
    End If
End Sub
