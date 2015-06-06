VERSION 5.00
Begin VB.Form frmRenew 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   7200
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   9600
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   480
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   640
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame famSignOut 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Renew"
      Height          =   7095
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   9375
      Begin VB.PictureBox Picture1 
         BackColor       =   &H00FFFFFF&
         Height          =   2895
         Left            =   240
         ScaleHeight     =   2835
         ScaleWidth      =   8835
         TabIndex        =   26
         Top             =   3840
         Width           =   8895
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   3
            Left            =   720
            TabIndex        =   46
            Top             =   2280
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   3
            Left            =   720
            TabIndex        =   45
            Top             =   2520
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   2
            Left            =   720
            TabIndex        =   44
            Top             =   1560
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   2
            Left            =   720
            TabIndex        =   43
            Top             =   1800
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   1
            Left            =   720
            TabIndex        =   42
            Top             =   840
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   1
            Left            =   720
            TabIndex        =   41
            Top             =   1080
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   0
            Left            =   720
            TabIndex        =   40
            Top             =   120
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   0
            Left            =   720
            TabIndex        =   39
            Top             =   360
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Line hr 
            Index           =   3
            Visible         =   0   'False
            X1              =   120
            X2              =   8520
            Y1              =   2880
            Y2              =   2880
         End
         Begin VB.Image icoBooks 
            Height          =   480
            Index           =   3
            Left            =   120
            Picture         =   "frmRenew.frx":0000
            Top             =   2280
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Line hr 
            Index           =   2
            Visible         =   0   'False
            X1              =   120
            X2              =   8520
            Y1              =   2160
            Y2              =   2160
         End
         Begin VB.Image icoBooks 
            Height          =   480
            Index           =   2
            Left            =   120
            Picture         =   "frmRenew.frx":030A
            Top             =   1560
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Line hr 
            Index           =   1
            Visible         =   0   'False
            X1              =   120
            X2              =   8520
            Y1              =   1440
            Y2              =   1440
         End
         Begin VB.Image icoBooks 
            Height          =   480
            Index           =   1
            Left            =   120
            Picture         =   "frmRenew.frx":0614
            Top             =   840
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Line hr 
            Index           =   0
            Visible         =   0   'False
            X1              =   120
            X2              =   8520
            Y1              =   720
            Y2              =   720
         End
         Begin VB.Image icoBooks 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "frmRenew.frx":091E
            Top             =   120
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   0
            Left            =   3480
            TabIndex        =   38
            Top             =   120
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   1
            Left            =   3480
            TabIndex        =   37
            Top             =   840
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   2
            Left            =   3480
            TabIndex        =   36
            Top             =   1560
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   3
            Left            =   3480
            TabIndex        =   35
            Top             =   2280
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblDateDue 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Due Date"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   0
            Left            =   6360
            TabIndex        =   34
            Top             =   240
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblDateDue 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Due Date"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   1
            Left            =   6360
            TabIndex        =   33
            Top             =   960
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblDateDue 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Due Date"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   2
            Left            =   6360
            TabIndex        =   32
            Top             =   1680
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblDateDue 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Due Date"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   255
            Index           =   3
            Left            =   6360
            TabIndex        =   31
            Top             =   2400
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   1
            Left            =   120
            TabIndex        =   30
            Top             =   840
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   2
            Left            =   120
            TabIndex        =   29
            Top             =   1560
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   3
            Left            =   120
            TabIndex        =   28
            Top             =   2280
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   0
            Left            =   120
            TabIndex        =   27
            Top             =   120
            Width           =   8415
         End
      End
      Begin VB.TextBox txtInput 
         Height          =   285
         Left            =   3000
         TabIndex        =   25
         Top             =   3120
         Width           =   5295
      End
      Begin VB.Frame famPatronInfo 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Patron Information"
         Height          =   2655
         Left            =   3480
         TabIndex        =   2
         Top             =   240
         Width           =   5775
         Begin VB.Label Label15 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Telephone #:"
            DataField       =   "Telephone Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   1680
            Width           =   1215
         End
         Begin VB.Label lblTel 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Tel"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   23
            Top             =   1680
            Width           =   1455
         End
         Begin VB.Label Label13 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Postal Code:"
            Height          =   255
            Left            =   120
            TabIndex        =   22
            Top             =   1440
            Width           =   1215
         End
         Begin VB.Label lblPostal 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Postal"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   21
            Top             =   1440
            Width           =   2175
         End
         Begin VB.Label Label11 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Province:"
            Height          =   255
            Left            =   120
            TabIndex        =   20
            Top             =   1200
            Width           =   1215
         End
         Begin VB.Label lblProvince 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Province"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   19
            Top             =   1200
            Width           =   1575
         End
         Begin VB.Label lblFname 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "FirstName"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   2400
            TabIndex        =   18
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblTown 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Town"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   17
            Top             =   960
            Width           =   2295
         End
         Begin VB.Label Label7 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Town:"
            Height          =   255
            Left            =   120
            TabIndex        =   16
            Top             =   960
            Width           =   1215
         End
         Begin VB.Label lblAddress 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Address1"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   15
            Top             =   720
            Width           =   3135
         End
         Begin VB.Label Label4 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Address:"
            Height          =   255
            Left            =   120
            TabIndex        =   14
            Top             =   720
            Width           =   1215
         End
         Begin VB.Label lblLName 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "LastName"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   13
            Top             =   480
            Width           =   975
         End
         Begin VB.Label Label5 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Name:"
            Height          =   255
            Left            =   120
            TabIndex        =   12
            Top             =   480
            Width           =   1215
         End
         Begin VB.Label lblNumber 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "PatronBarcode"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   11
            Top             =   240
            Width           =   615
         End
         Begin VB.Label Label3 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   10
            Top             =   240
            Width           =   1215
         End
         Begin VB.Label lblEmail 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Email"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   9
            Top             =   1920
            Width           =   2175
         End
         Begin VB.Label Label17 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "E-Mail:"
            DataField       =   "Telephone Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   8
            Top             =   1920
            Width           =   1215
         End
         Begin VB.Label Label18 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Type:"
            Height          =   255
            Left            =   120
            TabIndex        =   7
            Top             =   2160
            Width           =   1215
         End
         Begin VB.Label lblType 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "PatronType"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   6
            Top             =   2160
            Width           =   2175
         End
         Begin VB.Label Label20 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Status:"
            Height          =   255
            Left            =   120
            TabIndex        =   5
            Top             =   2400
            Width           =   1215
         End
         Begin VB.Label lblStatus 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Status"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   4
            Top             =   2400
            Width           =   1455
         End
         Begin VB.OLE OLE1 
            DataField       =   "Picture"
            DataSource      =   "Patrons"
            Height          =   2295
            Left            =   3600
            SizeMode        =   3  'Zoom
            TabIndex        =   3
            Top             =   240
            Width           =   2055
         End
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Main Menu"
         Height          =   255
         Left            =   8280
         TabIndex        =   1
         Top             =   3120
         Width           =   975
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Patron's Media Items"
         Height          =   3495
         Left            =   120
         TabIndex        =   47
         Top             =   3480
         Width           =   9135
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Beta 1.0"
         Height          =   255
         Left            =   960
         TabIndex        =   50
         Top             =   840
         Width           =   1695
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Book Keeper 101"
         BeginProperty Font 
            Name            =   "Coronet"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   480
         TabIndex        =   49
         Top             =   360
         Width           =   2895
      End
      Begin VB.Label Label22 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "Please Enter Patron or Book Barcode:"
         Height          =   255
         Left            =   120
         TabIndex        =   48
         Top             =   3120
         Width           =   2775
      End
      Begin VB.Image imgLogo 
         Height          =   1635
         Left            =   120
         Picture         =   "frmRenew.frx":0C28
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1620
      End
   End
End
Attribute VB_Name = "frmRenew"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Topics As Recordset
Dim Patrons As Recordset
Dim Signout As Recordset

Private Sub Command1_Click()
Unload Me
End Sub

Private Sub Form_Load()
A = 0
End Sub

Private Sub txtInput_Click()
If Len(txtInput) > 0 Then
'Open The Records From The Data Base
StrSQL = "Select * From [Signout] Where [Barcode] Like '" & txtInput.Text & "'"
Set Signout = Db.OpenRecordset(StrSQL)
StrSQL = "Select * From [Books] Where [Barcode] Like '" & txtInput.Text & "'"
Set Books = Db.OpenRecordset(StrSQL)
StrSQL = "Select * From [Patron] Where [PatronBarcode] Like '" & Signout.Fields("Patron") & "'"
Set Patrons = Db.OpenRecordset(StrSQL)
StrSQL = "Select * From [Topics] Where [TopicID] Like " & Books.Fields("TopicID")
Set Topics = Db.OpenRecordset(StrSQL)
'Finished Defining The Databases

' Get Patron Information
lblNumber.Caption = Patrons.Fields("PatronBarcode")
lblLName.Caption = Patrons.Fields("LastName")
lblFname.Caption = Patrons.Fields("FirstName")
lblAddress.Caption = Patrons.Fields("Address1")
lblTown.Caption = Patrons.Fields("Town")
lblProvince.Caption = Patrons.Fields("Province")
lblPostal.Caption = Patrons.Fields("Postal")
lblTel.Caption = Format(Patrons.Fields("Tel"), "(###) ###-####")
lblEmail.Caption = Patrons.Fields("Email")
lblType.Caption = Patrons.Fields("PatronType")
If Patrons.Fields("Status") = 1 Then
lblStatus.Caption = "Active"
Else
lblStatus.Caption = "Retired"
End If
' Finsihed Getting Patron Info

' Renew The Book
Barcode(A).Caption = Books.Fields("Barcode")
Title(A).Caption = Books.Fields("Title")
lblTopic(A).Caption = Topics.Fields("TopicName")
lblDateDue(A).Caption = Left(DateAdd("d", 14, Now), 10)
Signout.Edit
Signout.Fields("DateDue") = Left(DateAdd("d", 14, Now), 8)


Signout.Update
Barcode(A).Visible = True
Title(A).Visible = True
lblTopic(A).Visible = True
lblDateDue(A).Visible = True
icoBooks(A).Visible = True
hr(A).Visible = True
' Finished Renewing The Book
A = A + 1
Else
End If
txtInput.Text = ""
End Sub

Private Sub txtInput_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Call txtInput_Click
End Sub

