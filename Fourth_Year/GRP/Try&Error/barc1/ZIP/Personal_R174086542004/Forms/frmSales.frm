VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmSales 
   BackColor       =   &H00DFB493&
   Caption         =   "s"
   ClientHeight    =   8175
   ClientLeft      =   105
   ClientTop       =   435
   ClientWidth     =   11760
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   8175
   ScaleWidth      =   11760
   Begin VB.Frame fraSysInfo 
      BackColor       =   &H00DFB493&
      Height          =   735
      Left            =   120
      TabIndex        =   40
      Tag             =   "TFTT*/"
      Top             =   7320
      Width           =   6615
      Begin VB.Label lblTime 
         Alignment       =   2  'Center
         BackColor       =   &H00DFB493&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   43
         Tag             =   "TTFF*/"
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label lblCashierLabel 
         BackColor       =   &H00DFB493&
         Caption         =   "Cashier:"
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
         Left            =   3000
         TabIndex        =   42
         Tag             =   "TTFF*/"
         Top             =   300
         Width           =   975
      End
      Begin VB.Label lblCashier 
         BackColor       =   &H00DFB493&
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
         Left            =   4200
         TabIndex        =   41
         Tag             =   "TTFF*/"
         Top             =   300
         Width           =   2175
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   6240
      Tag             =   "TTFF*/"
      Top             =   3360
   End
   Begin PREC.Anchor Anchor1 
      Left            =   5640
      Tag             =   "TTFF*/"
      Top             =   3360
      _ExtentX        =   847
      _ExtentY        =   820
   End
   Begin VB.TextBox txtDescription 
      Appearance      =   0  'Flat
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
      IMEMode         =   3  'DISABLE
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   9
      Tag             =   "TTTF*/"
      Top             =   2880
      Width           =   5175
   End
   Begin VB.TextBox txtItemPrice 
      Appearance      =   0  'Flat
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
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
      IMEMode         =   3  'DISABLE
      Left            =   120
      Locked          =   -1  'True
      TabIndex        =   11
      Tag             =   "TTFF*/"
      Top             =   3960
      Width           =   975
   End
   Begin VB.TextBox txtTotal 
      Appearance      =   0  'Flat
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
      IMEMode         =   3  'DISABLE
      Left            =   2400
      Locked          =   -1  'True
      TabIndex        =   17
      TabStop         =   0   'False
      Tag             =   "TTFF*/"
      Top             =   3960
      Width           =   1215
   End
   Begin VB.TextBox txtQuantity 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
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
      IMEMode         =   3  'DISABLE
      Left            =   1320
      TabIndex        =   14
      Tag             =   "TTFF*/"
      Top             =   3960
      Width           =   855
   End
   Begin VB.TextBox txtChange 
      Alignment       =   1  'Right Justify
      Appearance      =   0  'Flat
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
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
      IMEMode         =   3  'DISABLE
      Left            =   9000
      Locked          =   -1  'True
      TabIndex        =   26
      Tag             =   "FFTT*/"
      Top             =   6600
      Width           =   2535
   End
   Begin VB.TextBox txtAmountTendered 
      Alignment       =   1  'Right Justify
      Appearance      =   0  'Flat
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
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
      IMEMode         =   3  'DISABLE
      Left            =   9000
      Locked          =   -1  'True
      TabIndex        =   24
      Tag             =   "FFTT*/"
      Top             =   6000
      Width           =   2535
   End
   Begin VB.TextBox txtAmountDue 
      Alignment       =   1  'Right Justify
      Appearance      =   0  'Flat
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
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
      IMEMode         =   3  'DISABLE
      Left            =   9000
      Locked          =   -1  'True
      TabIndex        =   22
      Tag             =   "FFTT*/"
      Top             =   5400
      Width           =   2535
   End
   Begin VB.ComboBox cboItemName 
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
      Left            =   4680
      TabIndex        =   7
      Tag             =   "TTTF*/"
      Top             =   2400
      Width           =   2055
   End
   Begin VB.ComboBox cboItemCode 
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
      Left            =   1560
      TabIndex        =   5
      Tag             =   "TTFF*/"
      Top             =   2400
      Width           =   1695
   End
   Begin VB.Frame fraAccountProfile 
      BackColor       =   &H00DFB493&
      Caption         =   "Account Profile"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4455
      Left            =   6960
      TabIndex        =   27
      Tag             =   "FTTF*/"
      Top             =   600
      Width           =   4695
      Begin VB.TextBox txtCurrentBalance 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "#,##0.00;(#,##0.00)"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   1
         EndProperty
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
         IMEMode         =   3  'DISABLE
         Left            =   2040
         Locked          =   -1  'True
         TabIndex        =   32
         Tag             =   "TTFF*/"
         Top             =   2880
         Width           =   2535
      End
      Begin VB.TextBox txtFirstName 
         Appearance      =   0  'Flat
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
         IMEMode         =   3  'DISABLE
         Left            =   2040
         Locked          =   -1  'True
         TabIndex        =   36
         Tag             =   "TTFF*/"
         Top             =   3840
         Width           =   2535
      End
      Begin VB.TextBox txtLastName 
         Appearance      =   0  'Flat
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
         IMEMode         =   3  'DISABLE
         Left            =   2040
         Locked          =   -1  'True
         TabIndex        =   34
         Tag             =   "TTFF*/"
         Top             =   3360
         Width           =   2535
      End
      Begin VB.TextBox txtIDNO 
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
         IMEMode         =   3  'DISABLE
         Left            =   2040
         MaxLength       =   10
         TabIndex        =   30
         Tag             =   "TTFF*/"
         Top             =   2400
         Width           =   2535
      End
      Begin VB.Label lblPicture 
         Alignment       =   2  'Center
         BackColor       =   &H00DFB493&
         Caption         =   "Picture Here"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   615
         Left            =   1800
         TabIndex        =   28
         Tag             =   "TTFF*/"
         Top             =   960
         Visible         =   0   'False
         Width           =   1455
      End
      Begin VB.Image imgPicture 
         BorderStyle     =   1  'Fixed Single
         Height          =   1815
         Left            =   1440
         Stretch         =   -1  'True
         Tag             =   "TTFF*/"
         Top             =   360
         Width           =   2175
      End
      Begin VB.Label lblCurrBalance 
         BackColor       =   &H00DFB493&
         Caption         =   "Current &Balance:"
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
         Left            =   120
         TabIndex        =   31
         Tag             =   "TTFF*/"
         Top             =   2880
         Width           =   1935
      End
      Begin VB.Label lblFirstName 
         BackColor       =   &H00DFB493&
         Caption         =   "&First Name:"
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
         Left            =   120
         TabIndex        =   35
         Tag             =   "TTFF*/"
         Top             =   3840
         Width           =   1335
      End
      Begin VB.Label lblLastName 
         BackColor       =   &H00DFB493&
         Caption         =   "&Last Name:"
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
         Left            =   120
         TabIndex        =   33
         Tag             =   "TTFF*/"
         Top             =   3360
         Width           =   1335
      End
      Begin VB.Label lblIDNum 
         BackColor       =   &H00DFB493&
         Caption         =   "&ID Number: (F8)"
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
         Left            =   120
         TabIndex        =   29
         Tag             =   "TTFF*/"
         Top             =   2400
         Width           =   1695
      End
   End
   Begin LVbuttons.LaVolpeButton cmdCommit 
      Height          =   375
      Left            =   6840
      TabIndex        =   37
      Tag             =   "FFTT*/"
      Top             =   7560
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "Co&mmit (F5)"
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
      MICON           =   "frmSales.frx":0000
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
   Begin LVbuttons.LaVolpeButton cmdCancel 
      Height          =   375
      Left            =   8520
      TabIndex        =   38
      Tag             =   "FFTT*/"
      Top             =   7560
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "Canc&el (F3)"
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
      MICON           =   "frmSales.frx":001C
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
   Begin MSComctlLib.ListView lvItems 
      Height          =   2775
      Left            =   120
      TabIndex        =   20
      Tag             =   "TTTT*/"
      Top             =   4560
      Width           =   6615
      _ExtentX        =   11668
      _ExtentY        =   4895
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   7
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "#"
         Object.Width           =   882
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "ItemCode"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "ItemName"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "ItemDescription"
         Object.Width           =   6385
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "(P) Item Price"
         Object.Width           =   2822
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Quantity"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "Total"
         Object.Width           =   3528
      EndProperty
   End
   Begin LVbuttons.LaVolpeButton cmdExit 
      Height          =   375
      Left            =   10200
      TabIndex        =   39
      Tag             =   "FFTT*/"
      Top             =   7560
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "E&xit (F9)"
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
      MICON           =   "frmSales.frx":0038
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
   Begin LVbuttons.LaVolpeButton cmdAddToList 
      Height          =   375
      Left            =   3960
      TabIndex        =   18
      Tag             =   "FTTF*/"
      Top             =   3960
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Add (F6)"
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
      MICON           =   "frmSales.frx":0054
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
   Begin LVbuttons.LaVolpeButton cmdRemoveFromList 
      Height          =   375
      Left            =   5400
      TabIndex        =   19
      Tag             =   "FTTF*/"
      ToolTipText     =   "Remove from list"
      Top             =   3960
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Remove (F7)"
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
      MICON           =   "frmSales.frx":0070
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
   Begin VB.Label lblDescription 
      BackColor       =   &H00DFB493&
      Caption         =   "&Description:"
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
      Left            =   120
      TabIndex        =   8
      Tag             =   "TTFF*/"
      Top             =   2880
      Width           =   1215
   End
   Begin VB.Label lblItemPrice 
      BackColor       =   &H00DFB493&
      Caption         =   "Item Price:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   10
      Tag             =   "TTFF*/"
      Top             =   3360
      Width           =   855
   End
   Begin VB.Label lblItemName 
      BackColor       =   &H00DFB493&
      Caption         =   "Item &Name:"
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
      Left            =   3480
      TabIndex        =   6
      Tag             =   "TTTF*/"
      Top             =   2400
      Width           =   1215
   End
   Begin VB.Label lblItemCode 
      BackColor       =   &H00DFB493&
      Caption         =   "Item &Code:        (F11)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   4
      Tag             =   "TTFF*/"
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label14 
      Alignment       =   2  'Center
      BackColor       =   &H00DFB493&
      Caption         =   "="
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   255
      Left            =   2160
      TabIndex        =   15
      Tag             =   "TTFF*/"
      Top             =   4020
      Width           =   255
   End
   Begin VB.Label lblTotalSmall 
      BackColor       =   &H00DFB493&
      Caption         =   "Total:"
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
      Left            =   2400
      TabIndex        =   16
      Tag             =   "TTFF*/"
      Top             =   3480
      Width           =   735
   End
   Begin VB.Label Label12 
      Alignment       =   2  'Center
      BackColor       =   &H00DFB493&
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   255
      Left            =   1080
      TabIndex        =   12
      Tag             =   "TTFF*/"
      Top             =   4020
      Width           =   255
   End
   Begin VB.Label lblQuantity 
      BackColor       =   &H00DFB493&
      Caption         =   "&Quantity:      (*)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1320
      TabIndex        =   13
      Tag             =   "TTFF*/"
      Top             =   3360
      Width           =   975
   End
   Begin VB.Label lblChange 
      BackColor       =   &H00DFB493&
      Caption         =   "Chan&ge:"
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
      Left            =   6960
      TabIndex        =   25
      Tag             =   "FFTT*/"
      Top             =   6600
      Width           =   1935
   End
   Begin VB.Label lblAmountTendered 
      BackColor       =   &H00DFB493&
      Caption         =   "Amount &Tendered:"
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
      Left            =   6960
      TabIndex        =   23
      Tag             =   "FFTT*/"
      Top             =   6000
      Width           =   1935
   End
   Begin VB.Label lblAmountDue 
      BackColor       =   &H00DFB493&
      Caption         =   "Amount D&ue:"
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
      Left            =   6960
      TabIndex        =   21
      Tag             =   "FFTT*/"
      Top             =   5400
      Width           =   1455
   End
   Begin VB.Label lblCurrency 
      Alignment       =   2  'Center
      BackColor       =   &H00DFB493&
      Caption         =   "P"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   36
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   240
      TabIndex        =   2
      Tag             =   "TTFF*/"
      Top             =   1080
      Width           =   1575
   End
   Begin VB.Label lblTotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00DFB493&
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "#,##0.00;(#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   36
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   1920
      TabIndex        =   3
      Tag             =   "TTFF*/"
      Top             =   1080
      Width           =   4815
   End
   Begin VB.Label lblTotalLarge 
      BackColor       =   &H00DFB493&
      Caption         =   "Total:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Tag             =   "TTFF*/"
      Top             =   600
      Width           =   1335
   End
   Begin VB.Label lblTitle 
      BackColor       =   &H00800000&
      Caption         =   "  Personal Reloadable Card System - Terminal"
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
      Tag             =   "TTTF*/"
      Top             =   0
      Width           =   13215
   End
End
Attribute VB_Name = "frmSales"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_accAccount As CAccount
Private m_lngLstIndex As Long
Private m_strReceiptNo As String
Private m_lngPurhaseID As Long
Private m_cboItemCode As CAutoCompleteComboBox
Private m_cboItemName As CAutoCompleteComboBox
Private m_lnglvwListIndex As Long

Private Sub CalculateChange()
    On Error GoTo hErr
    If Len(txtAmountTendered.Text) = 0 Then
        Exit Sub
    End If
    
    txtChange.Text = Format$(CDbl(IIf(Len(txtAmountTendered.Text) = 0, 0, txtAmountTendered.Text) - _
       CDbl(IIf(Len(txtAmountDue.Text) = 0, 0, txtAmountDue.Text))), "#,##0.00;(#,##0.00)")
    'txtChange.Text = Format$(txtChange.Text, "P #,##0.00;(P #,##0.00)")
    If txtChange.Text < 0 Then
        txtChange.ForeColor = &HFF&
    Else
        txtChange.ForeColor = &H80000008
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub GetItem(lngItemID As Long)
    On Error GoTo hErr
    Dim rsItem As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblItems WHERE ItemID = " & lngItemID & " AND Discontinued = No"
    Set rsItem = New ADODB.Recordset
    rsItem.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic
    
    If rsItem.EOF = False Then
        txtItemPrice.Text = rsItem("UnitPrice").Value
        txtDescription.Text = rsItem("ItemDescription")
    End If
    
    rsItem.Close
    Set rsItem = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub LoadAccountInfo()
    On Error GoTo hErr
    Dim fso As FileSystemObject
    
    Set fso = New FileSystemObject
    
    With m_accAccount
        txtLastName.Text = .LastName
        txtFirstName.Text = .FirstName
        txtCurrentBalance.Text = Format$(.CurrentBalance, "P #,##0.00;(P #,##0.00)")
        'imgPicture.Picture = LoadPicture(App.Path & .PicturePath)
        
        If Len(.PicturePath) > 0 And fso.FileExists(.PicturePath) = True Then
            imgPicture.Picture = LoadPicture(.PicturePath)
            lblPicture.Visible = False
        Else
            Set imgPicture.Picture = Nothing
            lblPicture.Visible = True
            
            If Len(.PicturePath) > 0 Then
                lblPicture.Caption = "Picture Not Found"
            Else
                lblPicture.Caption = "No Picture Provided"
            End If
        End If
        
        If .CurrentBalance <= g_lngMinimumBalance Then
            txtCurrentBalance.ForeColor = &HFF&
            MsgBox "The current account's balance is equal or below the " & _
               "minimum balance requirement. Purchase cannot proceed.", vbExclamation, "Insufficient balance"
        Else
            txtCurrentBalance.ForeColor = &H80000008
        End If
        
    End With
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub PopulateItemCombo()
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblItems " & _
       "WHERE TerminalID = " & g_lngTerminalID & " AND Discontinued = No ORDER BY ItemCode ASC")
    
    If adoRs.RecordCount <> 0 Then
        Do While adoRs.EOF = False
            Call AddComboItem(cboItemCode, adoRs("ItemCode"), adoRs("ItemID"))
            Call AddComboItem(cboItemName, adoRs("ItemName"), adoRs("ItemID"))
            adoRs.MoveNext
        Loop
    End If
    
    adoRs.Close
    Set adoRs = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub RecordPurchase()
    On Error GoTo hErr
    Dim rsPurchase As ADODB.Recordset
    Dim rsPurchasedItem As ADODB.Recordset
    Dim strSQLPurchase As String
    Dim strSQLPurchasedItem As String
    Dim lngPurchaseID As String
    Dim lngLoop As Long
    
    strSQLPurchase = "SELECT * FROM tblPurchase"
    Set rsPurchase = g_dbPRECDb.GetRecordset(strSQLPurchase)
    rsPurchase.AddNew
    rsPurchase("TerminalID") = g_lngTerminalID
    rsPurchase("AccountID") = m_accAccount.AccountID
    rsPurchase("UserID") = g_lngUserID
    m_strReceiptNo = GetNextHighestValue("tblPurchase", "ReceiptNo")
    rsPurchase("ReceiptNo") = m_strReceiptNo
    rsPurchase("PurchaseDate") = Now
    rsPurchase("AmountDue") = CDbl(txtAmountDue.Text)
    rsPurchase("AmountTendered") = CDbl(txtAmountTendered.Text)
    rsPurchase("Change") = CDbl(txtChange.Text)
    rsPurchase.Update
    lngPurchaseID = rsPurchase("PurchaseID")
    m_lngPurhaseID = lngPurchaseID
    rsPurchase.Close
    Set rsPurchase = Nothing
    
    strSQLPurchasedItem = "SELECT * FROM tblPurchasedItems WHERE PurchaseID = " & lngPurchaseID
    Set rsPurchasedItem = g_dbPRECDb.GetRecordset(strSQLPurchasedItem)
    
    For lngLoop = 1 To lvItems.ListItems.Count
        rsPurchasedItem.AddNew
        rsPurchasedItem("PurchaseID") = lngPurchaseID
        rsPurchasedItem("ItemID") = lvItems.ListItems(lngLoop).Tag
        rsPurchasedItem("Quantity") = CLng(lvItems.ListItems(lngLoop).SubItems(5))
        rsPurchasedItem.Update
    Next lngLoop
    
    rsPurchasedItem.Close
    Set rsPurchasedItem = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cboItemCode_Click()
    On Error GoTo hErr
    m_lnglvwListIndex = cboItemCode.ListIndex
    cboItemName.ListIndex = m_lnglvwListIndex
    'SendKeys "{F4}"
    Call ClearItemDetails
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cboItemCode_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    
    If Len(cboItemCode.Text) = 1 And KeyAscii = 8 Then
        cboItemName.Text = ""
    End If
    
    If KeyAscii = 13 And m_lnglvwListIndex <> -1 Then
        cboItemCode.ListIndex = m_lnglvwListIndex
        m_lnglvwListIndex = -1
        txtQuantity.Text = 1
        cboItemName.ListIndex = cboItemCode.ListIndex
        Call GetItem(CurrentComboData(cboItemCode))
        txtTotal.Text = CDbl(IIf(Len(txtItemPrice.Text) = 0, 0, txtItemPrice.Text)) * _
           CDbl(IIf(Len(txtQuantity.Text) = 0, 0, txtQuantity.Text))
        txtQuantity.SetFocus
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cboItemName_Click()
    On Error GoTo hErr
    m_lnglvwListIndex = cboItemName.ListIndex
    cboItemCode.ListIndex = m_lnglvwListIndex
    
    Call ClearItemDetails
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cboItemName_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    
    If Len(cboItemName.Text) = 1 And KeyAscii = 8 Then
        cboItemCode.Text = ""
    End If
    
    If KeyAscii = 13 And m_lnglvwListIndex <> -1 Then
        cboItemName.ListIndex = m_lnglvwListIndex
        m_lnglvwListIndex = -1
        txtQuantity.Text = 1
        cboItemCode.ListIndex = cboItemName.ListIndex
        Call GetItem(CurrentComboData(cboItemCode))
        txtTotal.Text = CDbl(IIf(Len(txtItemPrice.Text) = 0, 0, txtItemPrice.Text)) * _
           CDbl(IIf(Len(txtQuantity.Text) = 0, 0, txtQuantity.Text))
        txtQuantity.SetFocus
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdAddToList_Click()
    On Error GoTo hErr
    Dim ObjLstItm As ListItem
    
    If Len(cboItemCode.Text) >= 1 And Len(txtItemPrice.Text) >= 1 Then
        m_lngLstIndex = m_lngLstIndex + 1
        Set ObjLstItm = lvItems.ListItems.Add
        
        With ObjLstItm
            .Text = m_lngLstIndex
            .SubItems(1) = cboItemCode.Text
            .SubItems(2) = cboItemName.Text
            .SubItems(3) = txtDescription.Text
            .SubItems(4) = txtItemPrice.Text
            .SubItems(5) = txtQuantity.Text
            .SubItems(6) = txtTotal.Text
        End With
        
        ' set item id as the key for text
        lvItems.ListItems.Item(m_lngLstIndex).Tag = CurrentComboData(cboItemCode)
        
        lblTotal.Caption = CDbl(IIf(Len(lblTotal.Caption) = 0, 0, lblTotal.Caption)) + _
           CDbl(IIf(Len(txtTotal.Text) = 0, 0, txtTotal.Text))
        txtAmountDue.Text = Format$(lblTotal.Caption, "#,##0.00;(#,##0.00)")
        lblTotal.Caption = Format$(lblTotal.Caption, "#,##0.00;(#,##0.00)")
        
        If Len(txtAmountTendered.Text) >= 1 Or Len(txtCurrentBalance.Text) >= 1 Then
            txtAmountTendered.Text = m_accAccount.CurrentBalance
            Call CalculateChange
        End If
        
        cboItemCode.ListIndex = -1
        cboItemName.ListIndex = -1
        'm_lnglvwListIndex = -1
        Call ClearItemDetails
    Else
        'MsgBox "No item to be added!", vbExclamation, "No Item Found"
    End If
    
    cboItemCode.SetFocus
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdCancel_Click()
    On Error GoTo hErr
    If MsgBox("Cancel transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Cancel") = vbYes Then
        Call CancelTransaction
        cboItemCode.SetFocus
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub CancelTransaction()
    On Error GoTo hErr
    Call ClearAllText(Me)
    lblTotal.Caption = ""
    lvItems.ListItems.Clear
    m_lngLstIndex = 0
    Set imgPicture.Picture = Nothing
    Set m_accAccount = Nothing
    txtIDNo.Locked = False
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdCommit_Click()
    On Error GoTo hErr
    If m_accAccount Is Nothing Then
        MsgBox "Please scan the customer's ID!", vbExclamation, "Swipe ID"
        txtIDNo.SetFocus
    ElseIf txtChange.Text < 0 Or txtCurrentBalance.ForeColor = &HFF& Then
        MsgBox "Your balance is not enough to make this purchase!", vbExclamation, "Balance Not Enough"
    ElseIf lvItems.ListItems.Count > 0 Then
        If MsgBox("Are you sure you want to commit?", vbQuestion + vbYesNo, "Confirm Commit") = vbYes Then
            m_accAccount.CurrentBalance = CDbl(txtChange.Text)
            m_accAccount.Update
            Call RecordPurchase
            MsgBox "Thank you for purchasing!", vbInformation, "Transaction Complete"
            Call ShowReport
            Call ClearAllText(Me)
            lblTotal.Caption = ""
            lvItems.ListItems.Clear
            m_lngLstIndex = 0
            Set imgPicture.Picture = Nothing
            Set m_accAccount = Nothing
            txtIDNo.Locked = False
            cboItemCode.SetFocus
        End If
    ElseIf lvItems.ListItems.Count = 0 Then
        MsgBox "Please enter items to purchase!", vbExclamation, "No Items"
        cboItemCode.SetFocus
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub ShowReport()
    On Error GoTo hErr
    Dim strSQL As String
    
    strSQL = "SELECT tblPurchase.PurchaseID, tblItems.ItemCode, tblItems.ItemDescription, " & _
       "tblPurchasedItems.Quantity, [tblItems].[UnitPrice]*[tblPurchasedItems].[Quantity] AS SubTotal, " & _
       "tblUsers.UserName " & _
       "FROM tblUsers INNER JOIN (tblPurchase INNER JOIN (tblItems INNER JOIN " & _
       "tblPurchasedItems ON tblItems.ItemID = tblPurchasedItems.ItemID) ON " & _
       "tblPurchase.PurchaseID = tblPurchasedItems.PurchaseID) ON " & _
       "tblUsers.UserID = tblPurchase.UserID WHERE tblPurchase.PurchaseID = " & m_lngPurhaseID
    
    With rptPurchase
        .txtDate.Text = Now
        .txtTerminal.Text = Right$(frmMain.lblTerminal.Caption, _
           Len(frmMain.lblTerminal.Caption) - 2)
        .txtORNo.Text = m_strReceiptNo
        .txtIDNo.Text = Me.txtIDNo.Text
        
        .txtTotal.Text = "P " & Me.txtAmountDue.Text
        .txtAmtTendered.Text = "P " & Me.txtAmountTendered.Text
        .txtChange.Text = "P " & Me.txtChange.Text
        .DataControl1.Connection = g_dbPRECDb.DbConnection
        .DataControl1.Source = strSQL
        '.Show vbModal
        .PrintReport False
    End With
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdExit_Click()
    On Error GoTo hErr
    Unload Me
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdRemoveFromList_Click()
    On Error GoTo hErr
    If lvItems.ListItems.Count > 0 Then
        If MsgBox("Are you sure you want to remove item no. " & lvItems.SelectedItem.Text & "?", _
           vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            lblTotal.Caption = CDbl(lblTotal.Caption) - CDbl(lvItems.SelectedItem.SubItems(6))
            lvItems.ListItems.Remove lvItems.SelectedItem.Index
            Call RenumberItems
            txtAmountDue.Text = Format$(lblTotal.Caption, "#,##0.00;(#,##0.00)")
            Call CalculateChange
            m_lngLstIndex = m_lngLstIndex - 1
            
            If lvItems.ListItems.Count = 0 Then
                Call CancelTransaction
            End If
        End If
    End If
    
    cboItemCode.SetFocus
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    On Error GoTo hErr
    Select Case KeyCode
        Case 114
            Call cmdCancel_Click
        Case 122  ' F11
            cboItemCode.SetFocus
        Case 116
            Call cmdCommit_Click
        Case 117
            Call cmdAddToList_Click
        Case 118
            Call cmdRemoveFromList_Click
        Case 119
            Call txtIDNo.SetFocus
        Case 120  ' F9
            Call cmdExit_Click
        Case 106
            txtQuantity.SetFocus
            KeyCode = 0
        Case 27
            cboItemCode.ListIndex = -1
            cboItemName.ListIndex = -1
            cboItemCode.Text = ""
            cboItemName.Text = ""
            Call ClearItemDetails
            cboItemCode.SetFocus
        Case 112
            'Call ShowHelp(Me.hwnd)
    End Select
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_Load()
    On Error GoTo hErr
    Call CenterForm(Me)
    ToggleFullScreen Me
    lblTitle.Caption = "  Personal Reloadable Card System - " & _
       Right$(frmMain.lblTerminal.Caption, Len(frmMain.lblTerminal.Caption) - 2)
    Call Timer1_Timer
    lblCashier.Caption = g_strUserName
    g_dbPRECDb.OpenConnection
    Call PopulateItemCombo
    Set m_cboItemCode = New CAutoCompleteComboBox
    m_cboItemCode.Init cboItemCode
    Set m_cboItemName = New CAutoCompleteComboBox
    m_cboItemName.Init cboItemName
    SendKeys "{F11}"  ' Set the focus on cboitemcode
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    If MsgBox("Are you sure you want to exit the sales form?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Sales Form") = vbYes Then
        Cancel = False
    Else
        Cancel = True
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    On Error GoTo hErr
    g_dbPRECDb.CloseConnection
    Set m_accAccount = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Timer1_Timer()
    On Error GoTo hErr
    lblTime.Caption = Format$(Now(), "yyyy/mm/dd hh:mm:ss")
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtIDNO_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 13 And KeyAscii <> 8 Then
        KeyAscii = 0
        Beep
        Exit Sub
    End If
    
    If txtIDNo.Locked = True Then
        MsgBox "Current transaction must be cancelled first!", vbExclamation, "Current Transaction Active"
        KeyAscii = 0
        Exit Sub
    End If

    If lvItems.ListItems.Count = 0 Then
        MsgBox "Please enter the items to be purchase first!", vbExclamation, "No Items Purchased"
        KeyAscii = 0
        cboItemCode.SetFocus
        SendKeys "{F4}"
    Else
        If KeyAscii = Asc(vbCr) Then
            If AccountExists(txtIDNo.Text) = True Then
                Set m_accAccount = GetAccount(g_dbPRECDb, txtIDNo.Text)
                
                If m_accAccount.Active = False Then
                    MsgBox "Cannot transact on deactivated account.", vbExclamation, "Transaction Prohibited"
                Else
                    Call LoadAccountInfo
                    cmdCommit.SetFocus
                    
                    If Len(txtAmountDue.Text) >= 1 And CDbl(IIf(Len(txtAmountDue.Text) = 0, 0, txtAmountDue.Text)) > 0 Then
                        txtAmountTendered.Text = Format$(m_accAccount.CurrentBalance, "#,##0.00;(#,##0.00)")
                        Call CalculateChange
                    End If
                    
                    txtIDNo.Locked = True
                End If
            Else
                MsgBox "Cannot find account using the entered ID number!", vbExclamation, "Account does not exists"
            End If
            
            KeyAscii = 0
        End If
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtPrePrintedReceiptNo_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    Call GotoNextField(KeyAscii)
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Function PrePrintedReceiptNumExists(strPPReceiptNum As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblLoad WHERE AccountID = " & m_accAccount.AccountID & _
       " AND PrePrintedReceiptNo = '" & strPPReceiptNum & "'"
    Set adoRs = g_dbPRECDb.GetRecordset(strSQL)
    
    ' if the preprinted receipt no is already found, refrain from reloading
    PrePrintedReceiptNumExists = Not adoRs.EOF
    adoRs.Close
    Set adoRs = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Private Sub txtQuantity_GotFocus()
    On Error GoTo hErr
    Call SelectAllText(txtQuantity)
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtQuantity_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 13 And KeyAscii <> 8 Then
        KeyAscii = 0
        Beep
        Exit Sub
    End If
    
    Call GotoNextField(KeyAscii)
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtQuantity_KeyUp(KeyCode As Integer, Shift As Integer)
    On Error GoTo hErr
    If IsNumeric(txtQuantity.Text) = False Then
        txtQuantity.Text = ""
        Beep
    Else
        txtTotal.Text = CDbl(IIf(Len(txtItemPrice.Text) = 0, 0, txtItemPrice.Text)) * _
           CDbl(IIf(Len(txtQuantity.Text) = 0, 0, txtQuantity.Text))
    End If
    
    If Len(txtQuantity.Text) = 0 Then
        txtTotal.Text = 0
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtQuantity_LostFocus()
    On Error GoTo hErr
    If Len(txtItemPrice.Text) > 0 And _
       (Len(txtQuantity.Text) = 0 Or txtQuantity.Text <= "0") Then
        txtQuantity.Text = 1
        txtTotal.Text = CDbl(IIf(Len(txtItemPrice.Text) = 0, 0, txtItemPrice.Text)) * _
           CDbl(IIf(Len(txtQuantity.Text) = 0, 0, txtQuantity.Text))
    ElseIf Len(txtItemPrice.Text) = 0 Then
        txtQuantity.Text = ""
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub RenumberItems()
    On Error GoTo hErr
    Dim lngIndex As Long
    
    For lngIndex = 1 To lvItems.ListItems.Count
        lvItems.ListItems.Item(lngIndex).Text = lngIndex
    Next lngIndex
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub ClearItemDetails()
    On Error GoTo hErr
    txtItemPrice.Text = ""
    txtDescription.Text = ""
    txtQuantity.Text = ""
    txtTotal.Text = ""
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub
