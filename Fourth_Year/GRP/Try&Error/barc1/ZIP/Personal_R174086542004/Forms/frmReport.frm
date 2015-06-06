VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmReport 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   3090
   ClientLeft      =   4215
   ClientTop       =   4440
   ClientWidth     =   4380
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3090
   ScaleWidth      =   4380
   ShowInTaskbar   =   0   'False
   Begin VB.ComboBox cboTerminal 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   1920
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   720
      Width           =   2295
   End
   Begin MSComCtl2.DTPicker dtStart 
      Height          =   375
      Left            =   1920
      TabIndex        =   4
      Top             =   1320
      Width           =   2295
      _ExtentX        =   4048
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   23658497
      CurrentDate     =   38030
   End
   Begin LVbuttons.LaVolpeButton cmdPreview 
      Height          =   375
      Left            =   480
      TabIndex        =   7
      Top             =   2520
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Preview"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   2
      BCOL            =   14660755
      FCOL            =   0
      FCOLO           =   12582912
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmReport.frx":0000
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
      Cancel          =   -1  'True
      Height          =   375
      Left            =   2640
      TabIndex        =   8
      Top             =   2520
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Close"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   2
      BCOL            =   14660755
      FCOL            =   0
      FCOLO           =   12582912
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmReport.frx":001C
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
   Begin MSComCtl2.DTPicker dtEnd 
      Height          =   375
      Left            =   1920
      TabIndex        =   6
      Top             =   1800
      Width           =   2295
      _ExtentX        =   4048
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   23658497
      CurrentDate     =   38030
   End
   Begin VB.Label Label3 
      BackColor       =   &H00DFB493&
      Caption         =   "&Terminal:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   765
      Width           =   975
   End
   Begin VB.Label Label2 
      BackColor       =   &H00DFB493&
      Caption         =   "&End Date:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   1800
      Width           =   975
   End
   Begin VB.Label Label1 
      BackColor       =   &H00DFB493&
      Caption         =   "&Start Date:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   360
      TabIndex        =   3
      Top             =   1320
      Width           =   1335
   End
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Sales Report"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   4575
   End
End
Attribute VB_Name = "frmReport"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cboTerminal_KeyPress(KeyAscii As Integer)
    Call GotoNextField(KeyAscii)
End Sub

Private Sub cmdClose_Click()
    Unload Me
End Sub

Private Sub cmdPreview_Click()
    If Len(cboTerminal.Text) = 0 Then
        MsgBox "Please select a terminal!", vbExclamation, "Terminal Required"
        cboTerminal.SetFocus
        SendKeys "{F4}"
        Exit Sub
    End If
    
    With rptSalesReport
        .txtStartDate.Text = DateValue(dtStart.Value)
        .txtEndDate.Text = DateValue(dtEnd.Value)
        .lblTitle.Caption = cboTerminal.Text & " Sales Report"
        .DataControl1.Connection = g_dbPRECDb.DbConnection
        .DataControl1.Source = "SELECT tblPurchase.PurchaseID, " & _
           "tblPurchase.ReceiptNo, tblPurchase.TerminalID, " & _
           "tblTerminal.TerminalName, tblAccount.IDNo, " & _
           "DateValue([PurchaseDate]) AS PDate, tblPurchasedItems.ID, " & _
           "tblPurchasedItems.ItemID, tblItems.ItemCode, tblItems.ItemName, " & _
           "tblPurchasedItems.Quantity, tblItems.UnitPrice, [tblItems].[UnitPrice]*[tblPurchasedItems].[Quantity] AS SubTotal " & _
           "FROM tblTerminal INNER JOIN ((tblAccount INNER JOIN tblPurchase " & _
           "ON tblAccount.AccountID = tblPurchase.AccountID) INNER JOIN " & _
           "(tblItems INNER JOIN tblPurchasedItems ON " & _
           "tblItems.ItemID = tblPurchasedItems.ItemID) ON " & _
           "tblPurchase.PurchaseID = tblPurchasedItems.PurchaseID) ON " & _
           "(tblTerminal.TerminalID = tblPurchase.TerminalID) " & _
           "AND (tblTerminal.TerminalID = tblItems.TerminalID) " & _
           "WHERE tblPurchase.TerminalID = " & CurrentComboData(cboTerminal) & " " & _
           "AND DateValue([PurchaseDate]) BETWEEN #" & DateValue(Me.dtStart.Value) & _
           "# AND #" & DateValue(dtEnd.Value) & "# " & _
           "ORDER BY DateValue([PurchaseDate]), tblPurchase.ReceiptNo"
        .Show vbModal
    End With
End Sub

Private Sub dtEnd_KeyPress(KeyAscii As Integer)
    Call GotoNextField(KeyAscii)
End Sub

Private Sub dtStart_KeyPress(KeyAscii As Integer)
    Call GotoNextField(KeyAscii)
End Sub

Private Sub Form_Load()
    Call CenterForm(Me)
    Call g_dbPRECDb.OpenConnection
    Call PopulateTerminalCombo
    dtStart.Value = Now
    dtEnd.Value = Now
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Unload rptSalesReport
    g_dbPRECDb.CloseConnection
End Sub

Private Sub PopulateTerminalCombo()
    Dim adoRs As ADODB.Recordset
    Dim lngListIndex As Long
    Dim lngLoop As Long
    
    lngListIndex = -1
    
    ' if the current terminal is not the accounting, disable the combo box
    If g_lngTerminalID <> 3 Then
        cboTerminal.Enabled = False
    End If
    
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblTerminal WHERE TerminalID <> 3 ORDER BY TerminalName")
    
    If adoRs.RecordCount <> 0 Then
        Do While adoRs.EOF = False
            If g_lngTerminalID = adoRs("TerminalID") Then
                lngListIndex = lngLoop
            End If
            
            Call AddComboItem(cboTerminal, adoRs("TerminalName"), adoRs("TerminalID"))
            adoRs.MoveNext
            lngLoop = lngLoop + 1
        Loop
    End If
    
    cboTerminal.ListIndex = lngListIndex
    adoRs.Close
    Set adoRs = Nothing
End Sub
