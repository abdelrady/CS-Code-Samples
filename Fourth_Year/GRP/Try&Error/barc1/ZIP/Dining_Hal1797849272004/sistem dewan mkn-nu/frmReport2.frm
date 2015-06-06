VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmReport2 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Attendance Report"
   ClientHeight    =   7890
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9255
   Icon            =   "frmReport2.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7890
   ScaleWidth      =   9255
   StartUpPosition =   1  'CenterOwner
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid Lista 
      Height          =   2295
      Left            =   720
      TabIndex        =   1
      Top             =   4920
      Visible         =   0   'False
      Width           =   3615
      _ExtentX        =   6376
      _ExtentY        =   4048
      _Version        =   393216
      Rows            =   0
      FixedRows       =   0
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Please determine the range of date to view report"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   9015
      Begin VB.Frame Frame3 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Filter"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   5040
         TabIndex        =   12
         Top             =   240
         Width           =   3735
         Begin VB.CheckBox chkFemale 
            BackColor       =   &H00FFFFFF&
            Caption         =   "Female"
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
            Left            =   2280
            TabIndex        =   14
            Top             =   240
            Value           =   1  'Checked
            Width           =   1215
         End
         Begin VB.CheckBox chkMale 
            BackColor       =   &H00FFFFFF&
            Caption         =   "Male"
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
            Left            =   480
            TabIndex        =   13
            Top             =   240
            Value           =   1  'Checked
            Width           =   855
         End
      End
      Begin MSComCtl2.DTPicker txtFecIni 
         Height          =   375
         Left            =   1680
         TabIndex        =   7
         Top             =   360
         Width           =   2295
         _ExtentX        =   4048
         _ExtentY        =   661
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Format          =   62783488
         CurrentDate     =   37987
      End
      Begin MSComCtl2.DTPicker txtFecFin 
         Height          =   375
         Left            =   1680
         TabIndex        =   8
         Top             =   840
         Width           =   2295
         _ExtentX        =   4048
         _ExtentY        =   661
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Format          =   62783488
         CurrentDate     =   37987
      End
      Begin LVbuttons.LaVolpeButton Command2 
         Height          =   375
         Left            =   5040
         TabIndex        =   11
         Top             =   960
         Width           =   3735
         _ExtentX        =   6588
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&View Report"
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
         BCOL            =   13160660
         FCOL            =   0
         FCOLO           =   0
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmReport2.frx":0CCA
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
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Initial Date"
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
         Index           =   0
         Left            =   360
         TabIndex        =   10
         Top             =   420
         Width           =   1215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Final Date"
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
         Index           =   1
         Left            =   480
         TabIndex        =   9
         Top             =   900
         Width           =   1215
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   5775
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   9015
      Begin MSChart20Lib.MSChart MSChart1 
         Height          =   5415
         Left            =   240
         OleObjectBlob   =   "frmReport2.frx":0CE6
         TabIndex        =   5
         TabStop         =   0   'False
         Top             =   240
         Width           =   8415
      End
   End
   Begin LVbuttons.LaVolpeButton Command4 
      Height          =   375
      Left            =   7680
      TabIndex        =   2
      Top             =   7440
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
      BCOL            =   13160660
      FCOL            =   0
      FCOLO           =   0
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmReport2.frx":2A79
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
   Begin VB.CommandButton Command1 
      Caption         =   "Abrir DB"
      Height          =   495
      Left            =   7440
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin LVbuttons.LaVolpeButton LaVolpeButton1 
      Height          =   375
      Left            =   6120
      TabIndex        =   3
      Top             =   7440
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Print"
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
      BCOL            =   13160660
      FCOL            =   0
      FCOLO           =   0
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmReport2.frx":2A95
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
End
Attribute VB_Name = "frmReport2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private msConn As New ADODB.Connection
Private rs As New ADODB.Recordset
Private nD(7) As String
Private nV(7) As Single
Private Sub Command1_Click()
'CONECT TO DATABASE
DoEvents
msConn.Open "Provider=Microsoft.Jet.OLEDB.4.0;" _
            + "Data Source=" + App.Path + "\dwnmkn.mdb;" ' _
Command1.Enabled = False
End Sub

Private Sub Command2_Click()
Dim cT As String
Dim dFe As Date
Dim str As String
Dim i, MiRow As Integer
Dim dF1 As String
Dim dF2 As String
Dim x1
dF1 = Format(txtFecIni, "dd/mm/yyyy")
dF2 = Format(txtFecFin, "dd/mm/yyyy")
    
If chkMale.Value = vbChecked And chkFemale.Value = vbChecked Then
    str = "%"
ElseIf chkMale.Value <> vbChecked And chkFemale.Value <> vbChecked Then
    str = "%"
ElseIf chkMale.Value = vbChecked Then
    str = "m"
ElseIf chkFemale.Value = vbChecked Then
    str = "f"
End If

If str = "%" Then
    cT = "SELECT dine.dtdine,count(dine.id) as nunm from dine,student " & _
       "WHERE dine.kpitm = student.kpitm " & _
       "AND dine.dtdine >=#" & Format(txtFecIni.Value, "dd/mm/yyyy") & "# " & _
       "AND dine.dtdine <=#" & Format(txtFecFin.Value, "dd/mm/yyyy") & "# " & _
       "GROUP BY dine.dtdine"
Else
    cT = "SELECT dine.dtdine,count(dine.id) as nunm from dine,student " & _
       "WHERE dine.kpitm = student.kpitm " & _
       "AND dine.dtdine >=#" & Format(txtFecIni.Value, "dd/mm/yyyy") & "# " & _
       "AND dine.dtdine <=#" & Format(txtFecFin.Value, "dd/mm/yyyy") & "# " & _
       "AND student.sex = '" & str & "' " & _
       "GROUP BY dine.dtdine"
End If
'MsgBox cT
'CHECK CONECTION BEFORE QUERY
If msConn.State = adStateClosed Then
    MsgBox "Error", vbOKOnly + vbExclamation, "Error"
    Exit Sub
End If

'IF RECORDSET OPEN, CLOSE IT
If rs.State = adStateOpen Then rs.Close
rs.Open cT, msConn

x1 = 1
Do While x1 <= 7
    nV(x1) = 0
    x1 = x1 + 1
Loop
Do Until rs.EOF
    dFe = Format(rs!dtdine, "dd/mm/yyyy")
    Call AsignaVentas(Weekday(dFe), rs!nunm)
    rs.MoveNext
Loop

'PREP. CHART
With MSChart1
    .chartType = VtChChartType2dBar
    .RowCount = 7
    .TitleText = "Dining Hall Attendance Report for " & txtFecIni & " until " & txtFecFin
End With

'CLEAR GRID
Lista.Clear: Lista.Rows = 0: Lista.Refresh
MiRow = 1
'POPULATE DATA INTO CHART

For MiRow = 1 To 7
    MSChart1.Row = MiRow
    MSChart1.Column = 1
    MSChart1.RowLabel = nD(MiRow)
    MSChart1.Data = Format(nV(MiRow), "standard")
    Lista.AddItem nD(MiRow) & vbTab & Format(nV(MiRow), "standard")
Next
MSChart1.Refresh
End Sub

Private Function AsignaVentas(d As Integer, n As Single)
'ADD SALES TO A SPECIFIC DAY OF THE WEEK
nV(d) = nV(d) + n
End Function

Private Function AsignaDias()
'PREPARE ARRAY OF DAYS
Dim i As Integer
For i = 1 To 7
        If i = 1 Then nD(i) = "Sun"   'SUNDAY
        If i = 2 Then nD(i) = "Mon"    'MONDAY
        If i = 3 Then nD(i) = "Tue"     'ETC...
        If i = 4 Then nD(i) = "Wed"
        If i = 5 Then nD(i) = "Thu"
        If i = 6 Then nD(i) = "Fri"
        If i = 7 Then nD(i) = "Sat"  'SATURDAY
Next
End Function

Private Sub Command4_Click()
    If rs.State = adStateOpen Then rs.Close
    Unload Me
End Sub

Private Sub Form_Load()
    txtFecIni.Value = Date
    txtFecFin.Value = Date
    Command1_Click
    Call AsignaDias
End Sub

Private Sub LaVolpeButton1_Click()
    Me.PrintForm
End Sub
