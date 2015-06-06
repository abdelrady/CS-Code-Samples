VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmCollege 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "College Information"
   ClientHeight    =   3885
   ClientLeft      =   2550
   ClientTop       =   2700
   ClientWidth     =   6255
   Icon            =   "frmCollege.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3885
   ScaleWidth      =   6255
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Frame1"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1845
      Left            =   1320
      TabIndex        =   6
      Top             =   1080
      Visible         =   0   'False
      Width           =   4695
      Begin VB.TextBox txtColName 
         Alignment       =   2  'Center
         DataField       =   "collegeName"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   1200
         TabIndex        =   7
         TabStop         =   0   'False
         Top             =   915
         Width           =   3255
      End
      Begin LVbuttons.LaVolpeButton cmdCanCol 
         Height          =   375
         Left            =   3000
         TabIndex        =   5
         Top             =   1320
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "C&ancel"
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
         MICON           =   "frmCollege.frx":08CA
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
      Begin LVbuttons.LaVolpeButton cmdSaveCol 
         Height          =   375
         Left            =   1440
         TabIndex        =   4
         Top             =   1320
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Save"
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
         MICON           =   "frmCollege.frx":08E6
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
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   12
         Top             =   360
         Width           =   4455
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "College Name"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   8
         Top             =   870
         Width           =   855
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "College Information"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3615
      Left            =   120
      TabIndex        =   9
      Top             =   120
      Width           =   6015
      Begin MSAdodcLib.Adodc Adodc2 
         Height          =   330
         Left            =   240
         Top             =   3120
         Visible         =   0   'False
         Width           =   1200
         _ExtentX        =   2117
         _ExtentY        =   582
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   8
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "select * from college order by collegeName"
         Caption         =   "Adodc2"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSAdodcLib.Adodc Adodc1 
         Height          =   330
         Left            =   4560
         Top             =   3000
         Visible         =   0   'False
         Width           =   1200
         _ExtentX        =   2117
         _ExtentY        =   582
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   8
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "select * from college order by collegeName"
         Caption         =   "Adodc1"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSDataGridLib.DataGrid DataGrid1 
         Bindings        =   "frmCollege.frx":0902
         Height          =   1935
         Left            =   360
         TabIndex        =   10
         Top             =   1080
         Width           =   3855
         _ExtentX        =   6800
         _ExtentY        =   3413
         _Version        =   393216
         AllowUpdate     =   0   'False
         HeadLines       =   1
         RowHeight       =   15
         FormatLocked    =   -1  'True
         BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ColumnCount     =   1
         BeginProperty Column00 
            DataField       =   "collegeName"
            Caption         =   "College Name"
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         SplitCount      =   1
         BeginProperty Split0 
            BeginProperty Column00 
            EndProperty
         EndProperty
      End
      Begin LVbuttons.LaVolpeButton cmdAdd 
         Height          =   375
         Left            =   4440
         TabIndex        =   0
         Top             =   1080
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Add"
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
         MICON           =   "frmCollege.frx":0917
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
      Begin LVbuttons.LaVolpeButton cmdEdit 
         Height          =   375
         Left            =   4440
         TabIndex        =   1
         Top             =   1560
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Edit"
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
         MICON           =   "frmCollege.frx":0933
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
      Begin LVbuttons.LaVolpeButton cmdDel 
         Height          =   375
         Left            =   4440
         TabIndex        =   2
         Top             =   2040
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Delete"
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
         MICON           =   "frmCollege.frx":094F
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
      Begin LVbuttons.LaVolpeButton cmdClose 
         Height          =   375
         Left            =   4440
         TabIndex        =   3
         Top             =   2520
         Width           =   1455
         _ExtentX        =   2566
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
         MICON           =   "frmCollege.frx":096B
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
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   $"frmCollege.frx":0987
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Left            =   360
         TabIndex        =   13
         Top             =   240
         Width           =   5295
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
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
         Left            =   360
         TabIndex        =   11
         Top             =   3120
         Width           =   3855
      End
   End
End
Attribute VB_Name = "frmCollege"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public flag As Integer
Private Sub LaVolpeButton1_Click()
    Frame1.Visible = True
End Sub

Private Sub LaVolpeButton4_Click()
    Unload Me
End Sub

Private Sub cmdAdd_Click()
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    flag = 1
    
    Frame1.Visible = True
    Frame1.Caption = "Add New Record"
    Label3.Caption = "Please specify the name of the college to be added and click Save."
    Adodc1.Recordset.AddNew
    txtColName.SetFocus
End Sub
 
Private Sub cmdCanCol_Click()
    If flag = 1 Then
        Adodc1.Refresh
    Else
        Adodc1.Recordset.CancelUpdate
        Adodc1.Refresh
    End If
        Frame1.Visible = False
End Sub

Private Sub cmdClose_Click()
    Unload Me
End Sub

Private Sub cmdDel_Click()
    Dim a As String
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    a = MsgBox("Delete '" & Adodc1.Recordset.Fields("collegeName") & "' from database?", vbYesNo + vbExclamation, "Delete Confirmation")
    If a = vbYes Then
        Adodc1.Recordset.Delete
        Adodc1.Refresh
        Adodc1.Recordset.MoveLast
    Else
        Exit Sub
    End If

    Adodc1.RecordSource = "SELECT * FROM college order by collegeName"
    Adodc1.Refresh
    Label2.Caption = Adodc1.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub cmdEdit_Click()
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    flag = 2
    
    Frame1.Visible = True
    Label3.Caption = "You may edit names of the college and click Save to update the record."
    Frame1.Caption = "Edit Existing Record"
    With txtColName
        .SelStart = 0
        .SelLength = Len(.Text)
        .SetFocus
    End With
End Sub

Private Sub cmdSaveCol_Click()

If flag = 1 Then
    'check 4 zilch...hehehe
    If txtColName.Text = "" Then
        MsgBox "Please specify the college name!", vbOKOnly + vbInformation, "College Name"
        txtColName.SetFocus
        Exit Sub
    Else

        'lets check for redundancy
        Adodc2.RecordSource = "SELECT * FROM college WHERE collegeName = '" & txtColName.Text & "'"
        Adodc2.Refresh
        If Adodc2.Recordset.RecordCount <> 0 Then
            MsgBox "Error ! The college name specified has already exist.", vbOKOnly + vbExclamation, "Error"
            With txtColName
                .SetFocus
                .SelStart = 0
                .SelLength = Len(.Text)
            End With
            Exit Sub
        End If
    End If
    
    Adodc1.Recordset.UpdateBatch adAffectAll
    Adodc1.Refresh
    Frame1.Visible = False
End If

If flag = 2 Then
    Dim a As String
        
    a = MsgBox("Update this record?", vbYesNo + vbQuestion, "Update?")
    
    If a = vbYes Then
        Adodc1.Recordset.UpdateBatch adAffectCurrent
        Adodc1.Refresh
        Frame1.Visible = False
    Else
        Frame1.Visible = False
        Adodc1.Recordset.CancelUpdate
        Adodc1.Refresh
    End If
    Frame1.Visible = False
End If
    Adodc1.RecordSource = "SELECT * FROM college order by collegeName"
    Adodc1.Refresh
    Label2.Caption = Adodc1.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub Form_Load()
    If Adodc1.Recordset.RecordCount <> 0 Then
        Label2.Caption = Adodc1.Recordset.RecordCount & " record(s) displayed."
    Else
        Label2.Caption = "0 record(s) displayed."
        Exit Sub
    End If
End Sub
