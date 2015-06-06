VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   BackColor       =   &H80000000&
   Caption         =   "Contacts Viewer"
   ClientHeight    =   9300
   ClientLeft      =   60
   ClientTop       =   -1680
   ClientWidth     =   10440
   Icon            =   "Barcode.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   9300
   ScaleWidth      =   10440
   Begin VB.Frame frameBarcode 
      Height          =   8655
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   10215
      Begin VB.Frame Frame1 
         Caption         =   "Properties And Printing"
         Height          =   5655
         Left            =   120
         TabIndex        =   42
         Top             =   1920
         Width           =   9975
         Begin VB.CommandButton cmdPrint 
            Caption         =   "Print"
            Height          =   375
            Left            =   120
            TabIndex        =   71
            Top             =   4200
            Width           =   1695
         End
         Begin VB.CommandButton cmdPreview 
            Caption         =   "Print Preview"
            Height          =   375
            Left            =   2160
            TabIndex        =   69
            Top             =   1560
            Width           =   1695
         End
         Begin VB.CommandButton cmdPageSetup 
            Caption         =   "Page Setup"
            Height          =   375
            Left            =   120
            TabIndex        =   65
            Top             =   1560
            Width           =   1695
         End
         Begin VB.TextBox txtBCode 
            Height          =   285
            Index           =   1
            Left            =   2640
            TabIndex        =   64
            Text            =   "0.2"
            Top             =   3840
            Width           =   495
         End
         Begin VB.TextBox txtBCode 
            Height          =   285
            Index           =   0
            Left            =   2640
            TabIndex        =   63
            Text            =   "0.2"
            Top             =   3480
            Width           =   495
         End
         Begin VB.PictureBox picSample1 
            Appearance      =   0  'Flat
            AutoRedraw      =   -1  'True
            BackColor       =   &H00FFFFFF&
            FillColor       =   &H80000000&
            ForeColor       =   &H80000008&
            Height          =   857
            Left            =   4920
            ScaleHeight     =   825
            ScaleWidth      =   2175
            TabIndex        =   59
            Top             =   1680
            Width           =   2203
         End
         Begin VB.PictureBox picSample2 
            Appearance      =   0  'Flat
            AutoRedraw      =   -1  'True
            BackColor       =   &H00FFFFFF&
            FillColor       =   &H00FFFFFF&
            ForeColor       =   &H80000008&
            Height          =   857
            Left            =   7200
            ScaleHeight     =   825
            ScaleWidth      =   2175
            TabIndex        =   58
            Top             =   1680
            Width           =   2203
         End
         Begin VB.PictureBox picSample3 
            Appearance      =   0  'Flat
            AutoRedraw      =   -1  'True
            BackColor       =   &H00FFFFFF&
            FillColor       =   &H80000000&
            ForeColor       =   &H80000008&
            Height          =   857
            Left            =   4920
            ScaleHeight     =   825
            ScaleWidth      =   2175
            TabIndex        =   57
            Top             =   2640
            Width           =   2203
         End
         Begin VB.Frame fr128 
            BackColor       =   &H80000004&
            Caption         =   "BarCode 128 Properties"
            Height          =   1185
            Left            =   3960
            TabIndex        =   44
            Top             =   240
            Width           =   4485
            Begin VB.CheckBox Check1 
               Appearance      =   0  'Flat
               BackColor       =   &H80000004&
               Caption         =   "Top Align Caption"
               ForeColor       =   &H80000008&
               Height          =   255
               Left            =   2400
               TabIndex        =   70
               Top             =   360
               Value           =   1  'Checked
               Width           =   1935
            End
            Begin VB.CheckBox checkBarCaption 
               Appearance      =   0  'Flat
               BackColor       =   &H80000004&
               Caption         =   "Bar With Caption"
               ForeColor       =   &H80000008&
               Height          =   255
               Left            =   360
               TabIndex        =   46
               Top             =   360
               Value           =   1  'Checked
               Width           =   1815
            End
            Begin VB.CheckBox chkTextAlignment 
               Appearance      =   0  'Flat
               BackColor       =   &H80000004&
               Caption         =   "Bottom Align Caption"
               ForeColor       =   &H80000008&
               Height          =   255
               Left            =   360
               TabIndex        =   45
               Top             =   720
               Value           =   1  'Checked
               Width           =   1935
            End
         End
         Begin VB.Frame Frame3 
            BackColor       =   &H80000004&
            Caption         =   "Type of Bar"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   1185
            Left            =   120
            TabIndex        =   43
            Top             =   240
            Width           =   3765
            Begin VB.ComboBox cboTextStyle 
               Height          =   315
               ItemData        =   "Barcode.frx":030A
               Left            =   2430
               List            =   "Barcode.frx":031A
               Style           =   2  'Dropdown List
               TabIndex        =   50
               Top             =   680
               Width           =   975
            End
            Begin VB.ComboBox cboBarSize 
               Height          =   315
               ItemData        =   "Barcode.frx":0343
               Left            =   2430
               List            =   "Barcode.frx":0350
               Style           =   2  'Dropdown List
               TabIndex        =   49
               Top             =   300
               Width           =   975
            End
            Begin VB.OptionButton optBar 
               Appearance      =   0  'Flat
               BackColor       =   &H80000004&
               Caption         =   "Bar 128"
               ForeColor       =   &H80000008&
               Height          =   255
               Index           =   1
               Left            =   360
               TabIndex        =   48
               Top             =   720
               Width           =   855
            End
            Begin VB.OptionButton optBar 
               Appearance      =   0  'Flat
               BackColor       =   &H80000004&
               Caption         =   "Bar 39"
               ForeColor       =   &H80000008&
               Height          =   255
               Index           =   0
               Left            =   360
               TabIndex        =   47
               Top             =   360
               Value           =   -1  'True
               Width           =   855
            End
            Begin VB.Label Label4 
               BackStyle       =   0  'Transparent
               Caption         =   "Text Style"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   225
               Left            =   1560
               TabIndex        =   52
               Top             =   735
               Width           =   975
            End
            Begin VB.Label Label5 
               BackStyle       =   0  'Transparent
               Caption         =   "Bar Size"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   0
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Left            =   1560
               TabIndex        =   51
               Top             =   375
               Width           =   855
            End
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(1) Paper Size :"
            Height          =   195
            Index           =   10
            Left            =   240
            TabIndex        =   68
            Top             =   2040
            Width           =   1080
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(a) Width : XXXX inch/es"
            Height          =   195
            Index           =   9
            Left            =   600
            TabIndex        =   67
            Tag             =   "(a) Width : XXXX inch/es"
            Top             =   2400
            Width           =   1785
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(b) Height : XXXX inch/es"
            Height          =   195
            Index           =   8
            Left            =   600
            TabIndex        =   66
            Tag             =   "(b) Height : XXXX inch/es"
            Top             =   2760
            Width           =   1830
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(b) Barcode 1 to Barcode 3 :              inch/es"
            Height          =   195
            Index           =   2
            Left            =   600
            TabIndex        =   62
            Top             =   3840
            Width           =   3180
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(a) Barcode 1 to Barcode 2 :              inch/es"
            Height          =   195
            Index           =   1
            Left            =   600
            TabIndex        =   61
            Top             =   3480
            Width           =   3180
         End
         Begin VB.Label lblProp 
            AutoSize        =   -1  'True
            Caption         =   "(2) Distance between barcodes :"
            Height          =   195
            Index           =   0
            Left            =   240
            TabIndex        =   60
            Top             =   3120
            Width           =   2310
         End
      End
      Begin VB.PictureBox Picture1 
         Appearance      =   0  'Flat
         AutoRedraw      =   -1  'True
         BackColor       =   &H80000005&
         FillColor       =   &H80000000&
         ForeColor       =   &H80000008&
         Height          =   1545
         Left            =   120
         ScaleHeight     =   1515
         ScaleWidth      =   9915
         TabIndex        =   1
         Top             =   240
         Width           =   9945
      End
   End
   Begin MSComctlLib.TabStrip tbStrip 
      Height          =   9135
      Left            =   0
      TabIndex        =   40
      Top             =   120
      Width           =   10425
      _ExtentX        =   18389
      _ExtentY        =   16113
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   3
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Contact Details"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab2 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Barcode"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab3 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Search"
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
   Begin VB.Frame frData 
      Height          =   7455
      Left            =   120
      TabIndex        =   5
      Top             =   480
      Width           =   10215
      Begin VB.Frame frBarcode 
         Height          =   975
         Left            =   2640
         TabIndex        =   53
         Top             =   840
         Width           =   7455
         Begin VB.CommandButton cmdBarcode 
            Height          =   630
            Left            =   6720
            TabIndex        =   55
            Top             =   240
            Width           =   615
         End
         Begin VB.TextBox Text1 
            Alignment       =   2  'Center
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   20.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   630
            Left            =   1440
            MaxLength       =   21
            TabIndex        =   54
            Text            =   "SAMPLE BARCODE"
            Top             =   210
            Width           =   5235
         End
         Begin VB.Label Label1 
            Caption         =   "Barcode >>"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   120
            TabIndex        =   56
            Top             =   360
            Width           =   1335
         End
      End
      Begin MSComctlLib.Toolbar Toolbar1 
         Height          =   540
         Left            =   15
         TabIndex        =   41
         Top             =   120
         Width           =   10185
         _ExtentX        =   17965
         _ExtentY        =   953
         ButtonWidth     =   1376
         ButtonHeight    =   953
         Appearance      =   1
         Style           =   1
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   6
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&New"
               Key             =   "new"
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&Edit"
               Key             =   "edit"
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&Update"
               Key             =   "update"
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&Delete"
               Key             =   "delete"
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&Refresh"
               Key             =   "refresh"
            EndProperty
            BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Caption         =   "&Close"
               Key             =   "close"
            EndProperty
         EndProperty
      End
      Begin VB.TextBox txtSearch 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         TabIndex        =   26
         Top             =   240
         Visible         =   0   'False
         Width           =   7455
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   25
         Tag             =   "Company Name"
         Text            =   "Company Name"
         Top             =   2400
         Width           =   7455
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   24
         Tag             =   "Address"
         Text            =   "Address"
         Top             =   2880
         Width           =   7455
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   23
         Tag             =   "City"
         Text            =   "City"
         Top             =   3360
         Width           =   2775
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   22
         Tag             =   "Country"
         Text            =   "Country"
         Top             =   3840
         Width           =   2775
      End
      Begin VB.ComboBox cbostate 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Barcode.frx":036A
         Left            =   7080
         List            =   "Barcode.frx":03A1
         Locked          =   -1  'True
         Sorted          =   -1  'True
         TabIndex        =   21
         Tag             =   "State"
         Text            =   "State"
         Top             =   3360
         Width           =   3015
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   20
         Tag             =   "DID Number"
         Text            =   "DID Number"
         Top             =   4320
         Width           =   2775
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   19
         Tag             =   "Fax Number"
         Text            =   "Fax Number"
         Top             =   4800
         Width           =   2775
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   7680
         Locked          =   -1  'True
         TabIndex        =   18
         Tag             =   "Mobile Number"
         Text            =   "Mobile Number"
         Top             =   4320
         Width           =   2415
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   7680
         Locked          =   -1  'True
         TabIndex        =   17
         Tag             =   "e-mail"
         Text            =   "e-mail"
         Top             =   4800
         Width           =   2415
      End
      Begin VB.TextBox txtData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Index           =   9
         Left            =   2040
         Locked          =   -1  'True
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   16
         Tag             =   "Notes"
         Text            =   "Barcode.frx":0457
         Top             =   5280
         Width           =   8055
      End
      Begin VB.ComboBox cboContactType 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   7080
         Locked          =   -1  'True
         TabIndex        =   15
         Tag             =   "ContactType"
         Text            =   "ContactType"
         Top             =   3840
         Width           =   3015
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   0
         Left            =   2040
         TabIndex        =   14
         Top             =   1920
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   1
         Left            =   2040
         TabIndex        =   13
         Top             =   2400
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   2
         Left            =   2040
         TabIndex        =   12
         Top             =   2880
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   7
         Left            =   7080
         TabIndex        =   11
         Top             =   4320
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   3
         Left            =   2040
         TabIndex        =   10
         Top             =   3360
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   4
         Left            =   2040
         TabIndex        =   9
         Top             =   3840
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   5
         Left            =   2040
         TabIndex        =   8
         Top             =   4320
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   6
         Left            =   2040
         TabIndex        =   7
         Top             =   4800
         Width           =   495
      End
      Begin VB.CommandButton cdmSearch 
         Height          =   375
         Index           =   8
         Left            =   7080
         TabIndex        =   6
         Top             =   4800
         Width           =   495
      End
      Begin VB.TextBox txtData 
         BackColor       =   &H00FFFFC0&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   27
         Tag             =   "Contact Person"
         Text            =   "Contact Person"
         Top             =   1920
         Width           =   7455
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Contact Person:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   39
         Top             =   1920
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Company Name:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   38
         Top             =   2400
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Address:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   120
         TabIndex        =   37
         Top             =   2880
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "City:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   120
         TabIndex        =   36
         Top             =   3360
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Country:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   120
         TabIndex        =   35
         Top             =   3840
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "DID Number:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   120
         TabIndex        =   34
         Top             =   4320
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Fax Number:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   120
         TabIndex        =   33
         Top             =   4800
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Notes:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   120
         TabIndex        =   32
         Top             =   5280
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "State:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   5160
         TabIndex        =   31
         Top             =   3360
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Contact  Type:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   5160
         TabIndex        =   30
         Top             =   3840
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "Mobile Number:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   5160
         TabIndex        =   29
         Top             =   4320
         Width           =   1815
      End
      Begin VB.Label lblData 
         Alignment       =   1  'Right Justify
         Caption         =   "e-Mail Address:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   5160
         TabIndex        =   28
         Top             =   4800
         Width           =   1815
      End
   End
   Begin VB.Frame frameResult 
      Height          =   5415
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   10215
      Begin MSComctlLib.ListView lstResult 
         Height          =   4695
         Left            =   120
         TabIndex        =   3
         Top             =   225
         Width           =   9975
         _ExtentX        =   17595
         _ExtentY        =   8281
         View            =   3
         LabelEdit       =   1
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         NumItems        =   0
      End
      Begin VB.Label lbl 
         Alignment       =   2  'Center
         Caption         =   "Label2"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   480
         Left            =   120
         TabIndex        =   4
         Top             =   4905
         Width           =   9975
      End
   End
   Begin VB.Menu mnucp 
      Caption         =   "Copy Image"
      Visible         =   0   'False
      Begin VB.Menu mnuCopyImage1 
         Caption         =   "Copy  Bar of Code 128 to Clip Board"
      End
      Begin VB.Menu mnuSaveImage1 
         Caption         =   "Save As"
      End
   End
   Begin VB.Menu mnucp1 
      Caption         =   "Copy Image2"
      Visible         =   0   'False
      Begin VB.Menu mnuCopyImage2 
         Caption         =   "Copy This Bar of Code 39 to Clip Board"
      End
      Begin VB.Menu mnuSaveImage2 
         Caption         =   "Save As"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Target          As Object
Dim LastSave        As String 'To Store last Saved Directory
Dim MyConn          As ADODB.Connection
Dim MyADO           As ADODB.Recordset

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

Public Sub FloodWithData(RecordID As String, Optional TreeKey As String)
Dim i               As Integer

If RecordID <> "" Then
    Set MyADO = New Recordset
    DoEvents
    MyADO.Open "SELECT * FROM CONTACT WHERE [Record ID]='" & RecordID & "'", MainMDi.TEMPCONN, adOpenStatic, adLockOptimistic, adCmdText
    If Not MyADO.EOF Then
        For i = 0 To txtData.UBound
            txtData(i).Text = MyADO(txtData(i).DataField).Value & ""
        Next
        Text1.Text = MyADO("Record ID").Value
        cbostate.Text = MyADO(cbostate.DataField).Value & ""
        cboContactType.Text = MyADO(cboContactType.DataField).Value & ""
        Me.Caption = "Contacts Viewer = " & MyADO("Record ID").Value
    Else
        MsgBox "Requested data (" & RecordID & ") not found. Thank you", vbInformation, "Information"
        Exit Sub
    End If
    MyADO.Close
    Set MyADO = Nothing
End If
tbStrip.Tabs(1).Selected = True
Call LoadedData
Toolbar1.Tag = RecordID '//keep the existing data
Toolbar1.Buttons("close").Tag = TreeKey '//keep the tree node key

End Sub

Private Sub SearchData(FldName As String, TheValue As String)
Dim i               As Integer
Dim TempData        As String
Dim TempSTR         As String
Dim MyCount         As Long

Set MyADO = New Recordset
Screen.MousePointer = vbHourglass
TheValue = TheValue & "%"
MyADO.Open "SELECT * FROM CONTACT WHERE [" & FldName & "] LIKE '" & TheValue & "'", MainMDi.TEMPCONN, adOpenStatic, adLockOptimistic, adCmdText
If Not MyADO.EOF Then
    lbl = "Total Data Found = " & MyADO.RecordCount
    lstResult.ListItems.Clear
    MyADO.MoveFirst: MyCount = 0
    MainMDi.PBar.Value = 0
    Do While Not MyADO.EOF
        MyCount = MyCount + 1
        TempData = MyADO("Record ID").Value
        lstResult.ListItems.add , TempData, TempData
        For i = 2 To lstResult.ColumnHeaders.count
            TempSTR = ""
            If Not IsNull(MyADO(lstResult.ColumnHeaders(i).Text).Value) Then
                TempSTR = MyADO(lstResult.ColumnHeaders(i).Text).Value
            End If
            lstResult.ListItems(TempData).SubItems(i - 1) = TempSTR
        Next
        MainMDi.PBar.Value = (MyCount / MyADO.RecordCount) * 100
        MyADO.MoveNext
    Loop
    lbl = MyCount & " of " & MyADO.RecordCount & " Data Found."
    tbStrip.Tabs(3).Selected = True
Else
    If Len(TheValue) > 0 Then TheValue = Left(TheValue, Len(TheValue) - 1)
    MsgBox "Requested data (" & TheValue & ") not found. Thank you", vbInformation, "Information"
    Exit Sub
End If

MyADO.Close
Set MyADO = Nothing
Screen.MousePointer = vbNormal
End Sub

Private Sub UpdateData(RecordID As String)
Dim i           As Integer
Dim Fld         As String
Dim SQLstr      As String
Dim FldValue    As String

Fld = ""
SQLstr = ""

For i = 0 To txtData.UBound
    Fld = Fld & "[" & txtData(i).DataField & "]"
    FldValue = Trim(txtData(i).Text)
    If Trim(FldValue) = "" Then
        Fld = Fld & "=NULL,"
    Else
        SQLstr = Replace(FldValue, "'", "''")
        Fld = Fld & "='" & SQLstr & "',"
    End If
Next
    Fld = Fld & "[" & cboContactType.DataField & "]"
    FldValue = Trim(cboContactType.Text)
    If Trim(FldValue) = "" Then
        Fld = Fld & "=NULL,"
    Else
        SQLstr = Replace(FldValue, "'", "''")
        Fld = Fld & "='" & SQLstr & "',"
    End If

    Fld = Fld & "[" & cbostate.DataField & "]"
    FldValue = Trim(cbostate.Text)
    If Trim(FldValue) = "" Then
        Fld = Fld & "=NULL, "
    Else
        SQLstr = Replace(FldValue, "'", "''")
        Fld = Fld & "='" & SQLstr & "',"
    End If
If Len(Fld) > 0 Then Fld = Left(Fld, Len(Fld) - 1)
SQLstr = "UPDATE CONTACT SET " & Fld & " WHERE [Record ID] = '" & RecordID & "'"

MyConn.Execute SQLstr
End Sub

Private Sub add()
Dim FldName     As String
Dim FldValue    As String
Dim SQLstr      As String

'//INSERT INTO table_name (column1, column2,...) VALUES (value1, value2,....)
SQLstr = "INSERT INTO CONTACT (" & FldName & ") VALUES (" & FldValue & ")"

MyConn.Execute SQLstr
End Sub

Private Sub cboBarSize_Click()
Picture1.ScaleMode = 3
'Picture1.ScaleMode = 3
Picture1.Cls
Select Case cboBarSize.ListIndex
    Case 0
        Picture1.Height = Picture1.Height * (1.4 * 40 / Picture1.ScaleHeight)
        Picture1.FontSize = 8
    Case 1
        Picture1.Height = Picture1.Height * (2.4 * 40 / Picture1.ScaleHeight)
        Picture1.FontSize = 10
    Case 2
        Picture1.Height = Picture1.Height * (3 * 40 / Picture1.ScaleHeight)
        Picture1.FontSize = 14
End Select
    Text1_Change
End Sub

Private Sub cboTextStyle_Click()
    Text1_Change
End Sub

Private Sub cdmSearch_Click(Index As Integer)

If txtSearch.Visible = False Or Val(txtSearch.Tag) <> Index Then
    txtSearch.Text = "TYPE SEARCH KEYWORD HERE"
    txtSearch.Visible = True
    txtSearch.SelStart = 0
    txtSearch.SelLength = Len("TYPE SEARCH KEYWORD HERE")
    txtSearch.SetFocus
    txtSearch.Top = txtData(Index).Top
    txtSearch.Width = txtData(Index).Width
    txtSearch.Left = txtData(Index).Left
    txtSearch.Tag = Index
    txtSearch.ZOrder 0
Else
    If txtSearch.Text <> "" And txtSearch.Text <> "TYPE SEARCH KEYWORD HERE" Then
        Call SearchData(txtData(Index).Tag, txtSearch.Text)
    End If
    txtSearch.Visible = False
End If
End Sub

Private Sub checkBarCaption_Click()
If checkBarCaption.Value = 1 Then
    checkBarCaption.Caption = "Show Text Caption"
    chkTextAlignment.Visible = True
Else
    checkBarCaption.Caption = "No Caption"
    chkTextAlignment.Value = 0
    chkTextAlignment.Visible = False
End If
End Sub

Private Sub chkTextAlignment_Click()
If chkTextAlignment.Value = 1 Then
    chkTextAlignment.Caption = "Bottom Align Caption"
Else
    chkTextAlignment.Caption = "Top Align Caption"
End If
End Sub

Private Sub printBar128(BarString As String, obj As Object)


    'Combination of bar
    'Start Character    3 character (Fixed)
    'Data
    'Check Character    3 character (Depends upon then value of the bar)
    'Stop Character     4 character (Fixed)
    
    
    '//######################################################
'    //PARAMETERS AND THIER MEANING
'    //a=LEFT
'    //b=TOP
'    //hgt=Height of the Barcode
'    //width=width of the thin Barcode in pixel
'    //r1=ratio of the thick barcode and thin barcode
'    //str=Value of the barcode
'    //align=alignment ofthe text i.e 1=left,2=center,3=right,4=justify
'    //textdisp= text position with respect to barcode i.e 2=TOP or 1=BOTTOM
'    //extra=distance of the text from the barcode
'    //ln=device context of the out put device
'//######################################################
Dim Dl As Long
Dim MinWidth  As Long

obj.Cls

    
Dim RT_VAL As RET_VAL
    
    With bar
        .crBack = RGB(255, 255, 255)
        .crFore = RGB(0, 0, 0)
        .lalign = 2 'Alignment of the text
        .lExtra = 4   'Distance between the barcode and the text
        .lheight = 40  'Height of the bar
        .lLeft = 20     'Left Position of the bar in the specified device (here e.g. Pictire1)
        .lR1 = 1        'Ratio between thin and thick bar (Standard all over world)
        .lR2 = 1        'Not necessary
        .lRetHeight = 0 'Returns the actual height of the bar code
        .lRetWidth = 0  'Returns the actual width of the bar code
        .lRotation = 0  'to rotate the bar code 0=0degree , 1=90 degree etc.
        .lShowCheck = 1 'Whether check digit will be displayed or not in the bar
        .lstyle = cboTextStyle.ListIndex + 1    'Bold, Italic, Underline or Strikethrough of text
        .lTop = 1      'Top Position of the bar in the specified device (here e.g. Picture1)
        .ltxtdisp = chkTextAlignment.Value + 1 'Whether text displayed at bottom(1) or top(2) of the bar
        .lWidth = cboBarSize.ListIndex + 1    'Width of thin bar in pixel
        .nsize = 10     'Font Size of bar
        .szAdDigit = "" 'Not necessary
        .szBarCaption = IIf(checkBarCaption.Value, BarString, "")
        .szDigit = ""   'Not necessary
        .szReadText = BarString
        .szSymbology = 16
        .TextColor = RGB(255, 0, 0) 'Color of text
        .tiFaceName = "Courier New"       'Font name of text
    End With
    
       Set Target = obj
       Dl = Special_128b(bar, Target.hDc)
            
    
    If Dl <> 0 Then MsgBox ErrSpecial_128bMessage(Dl)
End Sub

Private Sub cmdPageSetup_Click()
Dim MyLength        As Single
    MyLength = ShowPageSetupDlg
    'Call PaperSize
    If MyLength > -1 Then
        MyLength = (12210 / 8500) * 1000
        lblProp(9).Caption = Replace(lblProp(9).Tag, "XXXX", FarRightMargin / MyLength)
        lblProp(8).Caption = Replace(lblProp(8).Tag, "XXXX", FarTopMargin / MyLength)
    End If
End Sub

Private Sub cmdPreview_Click()
If Val(txtBCode(0)) = 0 Or Val(txtBCode(1)) = 0 Then
    MsgBox "Please input values in the Distance between barcodes. Thank you", vbInformation, "Information"
    Exit Sub
End If
If FarRightMargin = 0 Or FarTopMargin = 0 Then
    MsgBox "Please set the papersize using page setup. Thank you", vbInformation, "Information"
    Exit Sub
End If
    Load frmPreview
    frmPreview.ZOrder 0
    frmPreview.picPreview.Cls
    frmPreview.PaperSize
    Call CreateLabel(Me.picSample1, frmPreview.picPreview)
End Sub

Private Sub cmdPrint_Click()
If Val(txtBCode(0)) = 0 Or Val(txtBCode(1)) = 0 Then
    MsgBox "Please input values in the Distance between barcodes. Thank you", vbInformation, "Information"
    Exit Sub
End If
If FarRightMargin = 0 Or FarTopMargin = 0 Then
    MsgBox "Please set the papersize using page setup. Thank you", vbInformation, "Information"
    Exit Sub
End If
    Call CreateLabel(picSample1, Printer)
    Printer.EndDoc
End Sub

Private Sub CreateLabel(SOURCEobj As Object, TARGETobj As Object)
Dim maxROW      As Integer
Dim maxCLMN     As Integer
Dim i, j        As Integer
Dim toB2, toB3  As Double
Dim Xcoord      As Double
Dim Ycoord      As Double

'TARGETobj.ScaleMode = SOURCEobj.ScaleMode
SOURCEobj.ScaleMode = TARGETobj.ScaleMode
SOURCEobj.Picture = SOURCEobj.Image
toB2 = Val(GetSetting(App.Title, "Settings", "toB2", 549))
toB3 = Val(GetSetting(App.Title, "Settings", "toB3", 549))

TARGETobj.Width = FarRightMargin
TARGETobj.Height = FarTopMargin
'//get the max picture can load per column
'//maxCLMN=papersize(width)/(width of barcode + toB2)

maxCLMN = (TARGETobj.Width - MaxLeftMargin) / (SOURCEobj.Width + toB2)
'//get the max picture can load per row
'//maxROW=papersize(heght)/(height of barcode + toB3)
maxROW = (TARGETobj.Height - PrinterTop) / (SOURCEobj.Height + toB2)
Ycoord = PrinterTop ' ScaleX(PrinterTop, vbTwips, vbPixels)
For i = 1 To maxROW '// max picture in row reached than stop or move to next page
    Xcoord = MaxLeftMargin ' ScaleX(MaxLeftMargin, vbTwips, vbPixels)
    For j = 1 To maxCLMN '//max picture in column reached than move to next row
        TARGETobj.PaintPicture SOURCEobj.Picture, Xcoord, Ycoord, SOURCEobj.Width, SOURCEobj.Height
        Xcoord = Xcoord + SOURCEobj.Width + toB2 ' Xcoord + ScaleX(SOURCEobj.Width + toB2, vbTwips, vbPixels)
    Next '//rows
    Ycoord = Ycoord + SOURCEobj.Height + toB3 ' Ycoord + ScaleX(SOURCEobj.Height + toB3, vbTwips, vbPixels)
Next '//columns
'PicSrc.Picture = LoadPicture(App.Path & "\test.jpg")
'TARGETobj.PaintPicture PicSrc.Picture, 0, 0, PicSrc.ScaleWidth, PicSrc.ScaleHeight
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Dim i           As Integer
Dim X           As Single
Dim Y           As Single

Screen.MousePointer = vbHourglass

cboBarSize.ListIndex = 1
cboTextStyle.ListIndex = 0

lstResult.View = lvwReport
lstResult.ColumnHeaders.Clear
lstResult.ListItems.Clear
    
lstResult.View = lvwReport
lstResult.ColumnHeaders.Clear
lstResult.ListItems.Clear
lstResult.ColumnHeaders.add , , "Record ID"
For i = 0 To txtData.UBound
    lstResult.ColumnHeaders.add , , txtData(i).Tag
Next
lstResult.ColumnHeaders.add , , cbostate.Tag
lstResult.ColumnHeaders.add , , cboContactType.Tag

tbStrip.Tabs(1).Selected = True
lbl = ""

For i = 0 To txtData.UBound
    txtData(i).DataField = txtData(i).Tag
    txtData(i).Text = ""
    txtData(i).BackColor = &HE0E0E0
Next

Me.cboContactType.DataField = cboContactType.Tag
Me.cbostate.DataField = cbostate.Tag
Me.cboContactType.BackColor = &HE0E0E0
Me.cbostate.BackColor = &HE0E0E0
Me.cboContactType.Text = ""
Me.cbostate.Text = ""
Set MyConn = New ADODB.Connection
MyConn.Open MainMDi.TEMPCONN
'w 2203 h 857
'//load sample barcode
picSample1.ScaleMode = 3
picSample2.ScaleMode = 3
picSample3.ScaleMode = 3
picSample1.Height = picSample1.Height * (1.4 * 40 / picSample1.ScaleHeight)
picSample1.FontSize = 8
Call DrawBarcode("BARCODE 1", picSample1)

picSample2.Height = picSample2.Height * (1.4 * 40 / picSample2.ScaleHeight)
picSample2.FontSize = 8
Call DrawBarcode("BARCODE 2", picSample2)

picSample3.Height = picSample3.Height * (1.4 * 40 / picSample3.ScaleHeight)
picSample3.FontSize = 8
Call DrawBarcode("BARCODE 3", picSample3)

X = Val(GetSetting(App.Title, "Settings", "toB2", 549))
If X = 0 Then X = 549
X = ScaleX(X, vbTwips, vbInches)
txtBCode(0).Text = X

Y = Val(GetSetting(App.Title, "Settings", "toB3", 549))
If Y = 0 Then Y = 549
Y = ScaleY(Y, vbTwips, vbInches)
txtBCode(0).Text = Y

picSample2.Left = picSample1.Left + picSample1.Width + (txtBCode(0) * 1440)
picSample3.Top = picSample1.Top + picSample1.Height + (txtBCode(1) * 1440)

Screen.MousePointer = vbNormal
End Sub

Private Sub Form_Resize()
If Me.WindowState <> 1 Then
    tbStrip.Width = Me.Width - Me.frameResult.Left - 50
    tbStrip.Height = Me.Height - tbStrip.Top - 400
    Me.frameResult.Left = 80
    Me.frameResult.Top = 480
    Me.frameResult.Height = Me.Height - frameResult.Top - 500
    Me.frameResult.Width = Me.Width - Me.frameResult.Left - 200
    
    Me.frameBarcode.Left = Me.frameResult.Left
    Me.frameBarcode.Height = Me.frameResult.Height
    Me.frameBarcode.Top = Me.frameResult.Top
    Me.frameBarcode.Width = Me.frameResult.Width
    
    Me.frData.Left = Me.frameResult.Left
    Me.frData.Top = Me.frameResult.Top
    Me.frData.Width = Me.frameResult.Width
    Me.frData.Height = Me.frameResult.Height
    
    lstResult.Width = frameResult.Width - 250
    lbl.Width = Me.lstResult.Width
    lbl.Top = frameResult.Height - lbl.Height - 20
    lstResult.Height = frameResult.Height - lbl.Height - lstResult.Top - 20
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
MyConn.Close
Set MyConn = Nothing
End Sub

Private Sub lstResult_DblClick()
    Call FloodWithData(lstResult.SelectedItem.Key)
End Sub

'Private Sub lblFeedBack_Click()
' ShellExecute Me.hwnd, "open", "http://www.planet-source-code.com/vb/default.asp?lngCId=39531&lngWId=1", 0&, LastSave, vbNormalFocus
'End Sub

Private Sub mnuCopyImage1_Click()
    pCopyToClipBoard Picture1
End Sub

Private Sub mnuSaveImage1_Click()
    'Call FileSaving Routine for BarCode 128
     FileSave Picture1
End Sub

Private Sub optBar_Click(Index As Integer)
Dim Enable128       As Boolean

If optBar(1).Value = True Then
    Picture1.ScaleWidth = 9885
    Picture1.Width = 9945
    Call printBar128(Text1, Picture1)
    Enable128 = True
Else
    Call DrawBarcode(Text1, Picture1)
    Enable128 = False
End If
fr128.Enabled = Enable128
checkBarCaption.Enabled = Enable128
chkTextAlignment.Enabled = Enable128
End Sub

Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 2 And Text1 <> "" Then
         
        PopupMenu mnucp
    End If
End Sub



Private Sub Picture2_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
If Button = 2 And Text1 <> "" Then
    
    PopupMenu mnucp1
End If
End Sub

Private Sub tbStrip_Click()
Select Case tbStrip.SelectedItem.Index
Case 1
    Me.frData.ZOrder 0
Case 2
    Me.frameBarcode.ZOrder 0
Case 3
    Me.frameResult.ZOrder 0
End Select

End Sub

Private Sub Text1_GotFocus()
    Text1.SelStart = 0
    Text1.SelLength = Len(Text1.Text)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then
    If Text1.Text <> "" Then
        Call FloodWithData(Text1.Text)
    End If
End If
End Sub

Private Sub Text1_Change()
If optBar(0).Value = True Then
    Call optBar_Click(0)
Else
    Call optBar_Click(1)
End If
End Sub

Sub pCopyToClipBoard(ByVal PictureBox As Object)
    ' copy The Image to clipboard
    PictureBox.Picture = PictureBox.Image
    Clipboard.Clear
    Clipboard.SetData PictureBox.Image, 2
End Sub

Sub FileSave(Picbox As PictureBox)
    'This Procedure Saves the Bars to desired Format
    Dim sName, RetVal, retSave
    Dim ObjGifImg               As GIF
    Screen.MousePointer = 11
    Dim TheFilter               As String
    Dim MyRequest               As String
    Dim TempData                As String
    
    TheFilter = "Bitmaps (*.bmp) " & Chr$(0) & "*.bmp" & Chr$(0) & "gif (*.gif) " & Chr$(0) & "*.gif" & Chr$(0) & "Transparent Gif (*.Gif) " & Chr$(0) & "*.Gif"
    'TheFilter = "Bitmaps (*.bmp)|*.bmp;Gif (*.gif)|*.gif;Transparent Gif (*.gif)|*.gif"
    MyRequest = SelectFile(Me, TheFilter, OFS_FILE_SAVE_FLAGS, "", 1)
    If MyRequest = "" Then Screen.MousePointer = vbNormal: Exit Sub
    TheFilter = DetermineFilename(MyRequest)
    If TheFilter = "" Then
        Exit Sub
    End If
    
    'CDialog.FilterIndex = 1 'make Dialog as Save
    'If LastSave <> "" Then
    '    CDialog.InitDir = LastSave
    'Else
    '    CDialog.InitDir = App.Path & "\ExportedImages"
    'End If
    
    'On Error GoTo ErrHandler
    'CDialog.Filename = Picbox.Name
    'CDialog.CancelError = True
    'CDialog.Flags = cdlOFNOverwritePrompt + cdlOFNNoReadOnlyReturn
    'CDialog.filter = "Bitmaps (*.bmp)|*.bmp|Gif (*.gif)|*.gif|Transparent Gif (*.gif)|*.gif"
    'CDialog.ShowSave
    'retrive the Folder Name
    'retSave = InStrRev(CDialog.Filename, "\")
    'LastSave = Mid(CDialog.Filename, 1, retSave)
    'DoEvents
    TempData = MyRequest
    TheFilter = HowMany(TempData, ".")
    TheFilter = Right(MyRequest, Len(MyRequest) - Val(TheFilter))
    Picbox.Picture = Picbox.Image
    Select Case TheFilter
      Case "bmp": 'if BITMAP is selected
                SavePicture Picbox.Picture, MyRequest
      Case "gif": 'if GIF is selected
                Set ObjGifImg = New GIF
                ObjGifImg.SaveGIF Picbox.Image, MyRequest, Picbox.hDc, False, Picbox.Point(0, 0)
                Set ObjGifImg = Nothing
      Case "Gif": 'if Transperent GIF is selected
                Set ObjGifImg = New GIF
                ObjGifImg.SaveGIF Picbox.Image, MyRequest, Picbox.hDc, True, Picbox.Point(0, 0)
                Set ObjGifImg = Nothing
    End Select

Screen.MousePointer = 0
Exit Sub
ErrHandler:

    If Err.Number = 32755 Then ' Handle the Cancel error
        Screen.MousePointer = 0
        Exit Sub
    Else
            If Err.Number <> 0 Then MsgBox "Error saving file: " & Err.Number & " - " & Err.Description
            Screen.MousePointer = 0
    End If
    
End Sub

Private Sub LoadedData()
Dim i       As Integer

For i = 1 To Toolbar1.Buttons.count
    Toolbar1.Buttons(i).Value = tbrUnpressed
Next
Toolbar1.Buttons("new").Caption = "&New"
Toolbar1.Buttons("edit").Caption = "&Edit"
Toolbar1.Buttons("new").Enabled = True
Toolbar1.Buttons("edit").Enabled = True
Toolbar1.Buttons("update").Enabled = False
Toolbar1.Buttons("delete").Enabled = True

Call LockOrnot("Loaded")

End Sub

Private Sub LockOrnot(tType As String)
Dim BckColor
Dim Enabler         As Boolean
Dim i               As Integer

Select Case tType
Case "Loaded"
    BckColor = &HE0E0E0
    Enabler = True
Case "Edit"
    BckColor = &HC0FFC0
    Enabler = False
Case "New"
    BckColor = &HC0FFFF
    Enabler = False
Case "Delete"
    For i = 0 To txtData.UBound
        txtData(i).Text = ""
    Next
    
    Me.cboContactType.Text = ""
    Me.cbostate.Text = ""

    BckColor = &HE0E0E0
    Enabler = True
End Select
For i = 0 To txtData.UBound
    txtData(i).BackColor = BckColor
    txtData(i).Locked = Enabler
Next

Me.cboContactType.BackColor = BckColor
Me.cbostate.BackColor = BckColor
Me.cboContactType.Locked = Enabler
Me.cbostate.Locked = Enabler
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
Dim i       As Integer

For i = 1 To Toolbar1.Buttons.count
    Toolbar1.Buttons(i).Value = tbrUnpressed
Next
Select Case Button.Key
Case "new"
    If Button.Caption = "&New" Then
        Button.Caption = "&Cancel"
        Toolbar1.Buttons("new").Value = tbrPressed
        Toolbar1.Buttons("edit").Enabled = False
        Toolbar1.Buttons("update").Enabled = True
        Toolbar1.Buttons("delete").Enabled = False
        For i = 0 To txtData.UBound
            txtData(i).Text = ""
            txtData(i).Text = ""
        Next
        
        Me.cboContactType.Text = ""
        Me.cbostate.Text = ""
        Call LockOrnot("New")
    Else
        Button.Caption = "&New"
        Toolbar1.Buttons("new").Value = tbrUnpressed
        Toolbar1.Buttons("new").Enabled = True
        Toolbar1.Buttons("edit").Enabled = True
        Toolbar1.Buttons("update").Enabled = False
        Toolbar1.Buttons("delete").Enabled = True
        Call LockOrnot("Loaded")
        Call FloodWithData(Me.Toolbar1.Tag)
    End If
Case "edit"
    If Toolbar1.Tag = "" Then
        MsgBox "There is no active data to edit. Thank you", vbInformation, "Information"
        Exit Sub
    End If
    If Button.Caption = "&Edit" Then
        Button.Caption = "&Cancel"
        Toolbar1.Buttons("edit").Value = tbrPressed
        Toolbar1.Buttons("new").Enabled = False
        Toolbar1.Buttons("update").Enabled = True
        Toolbar1.Buttons("delete").Enabled = False
        Call LockOrnot("Edit")
    Else
        Button.Caption = "&Edit"
        Toolbar1.Buttons("new").Enabled = True
        Toolbar1.Buttons("edit").Value = tbrUnpressed
        Toolbar1.Buttons("new").Enabled = True
        Toolbar1.Buttons("update").Enabled = False
        Toolbar1.Buttons("delete").Enabled = True
        Call LockOrnot("Loaded")
        Call FloodWithData(Me.Toolbar1.Tag)
    End If
Case "update"
    Toolbar1.Buttons("new").Caption = "&New"
    Toolbar1.Buttons("new").Enabled = True
    Toolbar1.Buttons("edit").Enabled = True
    Toolbar1.Buttons("update").Enabled = False
    Toolbar1.Buttons("delete").Enabled = True
    Call LockOrnot("Loaded")
    Call UpdateData(Me.Toolbar1.Tag)
    Toolbar1.Buttons("edit").Caption = "&Edit"
    'Call FloodWithData(Me.Toolbar1.Tag)
Case "delete"
    Call LockOrnot("Delete")
    Toolbar1.Tag = ""
    For i = 0 To txtData.UBound
        txtData(i).Text = ""
        txtData(i).Text = ""
    Next
    
    Me.cboContactType.Text = ""
    Me.cbostate.Text = ""
Case "refresh"
    Toolbar1.Buttons("new").Caption = "&New"
    Toolbar1.Buttons("new").Enabled = True
    Toolbar1.Buttons("edit").Enabled = True
    Toolbar1.Buttons("update").Enabled = True
    Toolbar1.Buttons("delete").Enabled = True
    Call LockOrnot("Loaded")
    Call FloodWithData(Me.Toolbar1.Tag)
Case "close"
    Unload Me
End Select
End Sub

Private Sub txtBCode_LostFocus(Index As Integer)
Dim X           As Single
Dim Y           As Single

Select Case Index
Case 0
    X = ScaleX(Val(txtBCode(Index).Text), vbInches, vbTwips)
    picSample2.Left = picSample1.Left + picSample1.Width + X
    SaveSetting App.Title, "Settings", "toB2", X
Case 1
    Y = ScaleY(Val(txtBCode(Index).Text), vbInches, vbTwips)
    picSample3.Top = picSample1.Top + picSample1.Height + Y
    SaveSetting App.Title, "Settings", "toB3", Y
End Select
End Sub

Private Sub txtData_Click(Index As Integer)
    txtSearch.Visible = False
End Sub

Private Sub txtSearch_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        cdmSearch_Click Val(txtSearch.Tag)
    End If
End Sub
