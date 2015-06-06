VERSION 5.00
Begin VB.Form frmSignout 
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
   Begin VB.CommandButton cmdPrev 
      Caption         =   "Previous"
      Height          =   195
      Left            =   360
      TabIndex        =   53
      Top             =   3660
      Width           =   8895
   End
   Begin VB.Frame famSignOut 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Sign Out"
      Height          =   7095
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   9375
      Begin VB.Data Topics 
         Caption         =   "Topics"
         Connect         =   "Access"
         DatabaseName    =   "U:\DSD\lib.mdb"
         DefaultCursorType=   0  'DefaultCursor
         DefaultType     =   2  'UseODBC
         Exclusive       =   0   'False
         Height          =   345
         Left            =   120
         Options         =   0
         ReadOnly        =   0   'False
         RecordsetType   =   1  'Dynaset
         RecordSource    =   "Topics"
         Top             =   2640
         Visible         =   0   'False
         Width           =   3255
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Main Menu"
         Height          =   255
         Left            =   8280
         TabIndex        =   30
         Top             =   3120
         Width           =   975
      End
      Begin VB.Frame famPatronInfo 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Patron Information"
         Height          =   2655
         Left            =   3480
         TabIndex        =   12
         Top             =   240
         Width           =   5775
         Begin VB.OLE OLE1 
            DataField       =   "Picture"
            DataSource      =   "Patrons"
            Height          =   2295
            Left            =   3600
            SizeMode        =   3  'Zoom
            TabIndex        =   41
            Top             =   240
            Width           =   2055
         End
         Begin VB.Label Label21 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Status"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   40
            Top             =   2400
            Width           =   1455
         End
         Begin VB.Label Label20 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Status:"
            Height          =   255
            Left            =   120
            TabIndex        =   39
            Top             =   2400
            Width           =   1215
         End
         Begin VB.Label Label19 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "PatronType"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   38
            Top             =   2160
            Width           =   2175
         End
         Begin VB.Label Label18 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Type:"
            Height          =   255
            Left            =   120
            TabIndex        =   37
            Top             =   2160
            Width           =   1215
         End
         Begin VB.Label Label17 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "E-Mail:"
            DataField       =   "Telephone Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   32
            Top             =   1920
            Width           =   1215
         End
         Begin VB.Label Label16 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Email"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   31
            Top             =   1920
            Width           =   2175
         End
         Begin VB.Label Label3 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   27
            Top             =   240
            Width           =   1215
         End
         Begin VB.Label lblPatronNumber 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "PatronBarcode"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   26
            Top             =   240
            Width           =   615
         End
         Begin VB.Label Label5 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Name:"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   480
            Width           =   1215
         End
         Begin VB.Label lblPatronName 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "LastName"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   24
            Top             =   480
            Width           =   975
         End
         Begin VB.Label Label4 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Patron Address:"
            Height          =   255
            Left            =   120
            TabIndex        =   23
            Top             =   720
            Width           =   1215
         End
         Begin VB.Label Label6 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Address1"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   22
            Top             =   720
            Width           =   3135
         End
         Begin VB.Label Label7 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Town:"
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   960
            Width           =   1215
         End
         Begin VB.Label Label8 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Town"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   20
            Top             =   960
            Width           =   2295
         End
         Begin VB.Label Label9 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "FirstName"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   2400
            TabIndex        =   19
            Top             =   480
            Width           =   975
         End
         Begin VB.Label Label10 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Province"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   18
            Top             =   1200
            Width           =   1575
         End
         Begin VB.Label Label11 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Province:"
            Height          =   255
            Left            =   120
            TabIndex        =   17
            Top             =   1200
            Width           =   1215
         End
         Begin VB.Label Label12 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Postal"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   16
            Top             =   1440
            Width           =   2175
         End
         Begin VB.Label Label13 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Postal Code:"
            Height          =   255
            Left            =   120
            TabIndex        =   15
            Top             =   1440
            Width           =   1215
         End
         Begin VB.Label Label14 
            BackStyle       =   0  'Transparent
            Caption         =   "00000"
            DataField       =   "Tel"
            DataSource      =   "Patrons"
            Height          =   255
            Left            =   1440
            TabIndex        =   14
            Top             =   1680
            Width           =   1455
         End
         Begin VB.Label Label15 
            Alignment       =   1  'Right Justify
            BackStyle       =   0  'Transparent
            Caption         =   "Telephone #:"
            DataField       =   "Telephone Number:"
            Height          =   255
            Left            =   120
            TabIndex        =   13
            Top             =   1680
            Width           =   1215
         End
      End
      Begin VB.TextBox txtInput 
         Height          =   285
         Left            =   3000
         TabIndex        =   1
         Top             =   3120
         Width           =   5295
      End
      Begin VB.PictureBox Picture1 
         BackColor       =   &H00FFFFFF&
         Height          =   2895
         Left            =   240
         ScaleHeight     =   2835
         ScaleWidth      =   8835
         TabIndex        =   2
         Top             =   3840
         Width           =   8895
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   0
            Left            =   120
            TabIndex        =   48
            Top             =   120
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   3
            Left            =   120
            TabIndex        =   51
            Top             =   2280
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   2
            Left            =   120
            TabIndex        =   50
            Top             =   1560
            Width           =   8415
         End
         Begin VB.Label lblBookSelect 
            BackStyle       =   0  'Transparent
            Height          =   495
            Index           =   1
            Left            =   120
            TabIndex        =   49
            Top             =   840
            Width           =   8415
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
            TabIndex        =   45
            Top             =   2400
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
            TabIndex        =   44
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
            Height          =   255
            Index           =   1
            Left            =   6360
            TabIndex        =   43
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
            Index           =   0
            Left            =   6360
            TabIndex        =   42
            Top             =   240
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   3
            Left            =   3480
            TabIndex        =   36
            Top             =   2280
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   2
            Left            =   3480
            TabIndex        =   35
            Top             =   1560
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   1
            Left            =   3480
            TabIndex        =   34
            Top             =   840
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Label lblTopic 
            BackStyle       =   0  'Transparent
            Caption         =   "Topic"
            Height          =   255
            Index           =   0
            Left            =   3480
            TabIndex        =   33
            Top             =   120
            Visible         =   0   'False
            Width           =   2175
         End
         Begin VB.Image icoBooks 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "frmSignout.frx":0000
            Top             =   120
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
            Index           =   1
            Left            =   120
            Picture         =   "frmSignout.frx":030A
            Top             =   840
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
            Index           =   2
            Left            =   120
            Picture         =   "frmSignout.frx":0614
            Top             =   1560
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
            Index           =   3
            Left            =   120
            Picture         =   "frmSignout.frx":091E
            Top             =   2280
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Line hr 
            Index           =   3
            Visible         =   0   'False
            X1              =   120
            X2              =   8520
            Y1              =   2880
            Y2              =   2880
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   0
            Left            =   720
            TabIndex        =   10
            Top             =   360
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   0
            Left            =   720
            TabIndex        =   9
            Top             =   120
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   1
            Left            =   720
            TabIndex        =   8
            Top             =   1080
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   1
            Left            =   720
            TabIndex        =   7
            Top             =   840
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   2
            Left            =   720
            TabIndex        =   6
            Top             =   1800
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   2
            Left            =   720
            TabIndex        =   5
            Top             =   1560
            Visible         =   0   'False
            Width           =   2655
         End
         Begin VB.Label Title 
            BackStyle       =   0  'Transparent
            Caption         =   "Title"
            Height          =   255
            Index           =   3
            Left            =   720
            TabIndex        =   4
            Top             =   2520
            Visible         =   0   'False
            Width           =   3255
         End
         Begin VB.Label Barcode 
            BackStyle       =   0  'Transparent
            Caption         =   "Barcode"
            Height          =   255
            Index           =   3
            Left            =   720
            TabIndex        =   3
            Top             =   2280
            Visible         =   0   'False
            Width           =   2655
         End
      End
      Begin VB.Data Patrons 
         Caption         =   "Patrons"
         Connect         =   "Access"
         DatabaseName    =   "U:\DSD\lib.mdb"
         DefaultCursorType=   0  'DefaultCursor
         DefaultType     =   2  'UseODBC
         Exclusive       =   0   'False
         Height          =   345
         Left            =   120
         Options         =   0
         ReadOnly        =   -1  'True
         RecordsetType   =   1  'Dynaset
         RecordSource    =   "Patron"
         Top             =   1920
         Visible         =   0   'False
         Width           =   3255
      End
      Begin VB.Data Books 
         Caption         =   "Books"
         Connect         =   "Access"
         DatabaseName    =   "U:\DSD\lib.mdb"
         DefaultCursorType=   0  'DefaultCursor
         DefaultType     =   2  'UseODBC
         Exclusive       =   0   'False
         Height          =   345
         Left            =   120
         Options         =   0
         ReadOnly        =   0   'False
         RecordsetType   =   1  'Dynaset
         RecordSource    =   "Books"
         Top             =   2280
         Visible         =   0   'False
         Width           =   3255
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Patron's Media Items"
         Height          =   3495
         Left            =   120
         TabIndex        =   11
         Top             =   3480
         Width           =   9135
         Begin VB.CommandButton cmdNext 
            Caption         =   "NEXT"
            Height          =   195
            Left            =   120
            TabIndex        =   52
            Top             =   3240
            Width           =   8895
         End
      End
      Begin VB.Label Label22 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "Please Enter Patron or Book Barcode:"
         Height          =   255
         Left            =   120
         TabIndex        =   47
         Top             =   3120
         Width           =   2775
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
         TabIndex        =   29
         Top             =   360
         Width           =   2895
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Beta 1.0"
         Height          =   255
         Left            =   960
         TabIndex        =   28
         Top             =   840
         Width           =   1695
      End
      Begin VB.Image imgLogo 
         Height          =   1635
         Left            =   120
         Picture         =   "frmSignout.frx":0C28
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1620
      End
   End
   Begin VB.Label lblRed 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "RED"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   255
      Left            =   120
      TabIndex        =   46
      Top             =   120
      Width           =   2175
   End
End
Attribute VB_Name = "frmSignout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim KeySection As String
Dim KeyKey As String
Dim KeyValue As String
Dim RstQuery As Recordset
Dim StrSQL As String
Dim StrAvail As String
Dim txtStringVal As String
Dim EntryLength As Integer
Dim bookTitle(12)
Dim bookBarcode(12)
Dim bookTopic(12)
Dim bookDateDue(12)
Dim signout As Recordset
Dim dbBooks As Recordset


Private Sub loadini()

Dim lngResult As Long
Dim strFileName
Dim strResult As String * 50
strFileName = App.Path & "\bookkeeper.ini" 'Declare your ini file !
lngResult = GetPrivateProfileString(KeySection, _
KeyKey, strFileName, strResult, Len(strResult), _
strFileName)
If lngResult = 0 Then
'An error has occurred
Call MsgBox("An error has occurred while calling the API function", vbExclamation)
Else
KeyValue = Trim(strResult)
End If

End Sub

Private Sub cmdNext_Click()
c = c + 4
Call vsb_Change
End Sub

Private Sub cmdPrev_Click()
c = c - 4
Call vsb_Change
End Sub

Private Sub Command1_Click()
Me.Hide
End Sub

Private Sub Form_Load()
KeySection = "Database Properties"
KeyKey = "Database"
loadini
Books.DatabaseName = KeyValue
Patrons.DatabaseName = KeyValue
End Sub

Private Sub lblBookSelect_DblClick(Index As Integer)
    StrSQL = "SELECT * FROM [Books]"
    StrSQL = StrSQL & " WHERE [Barcode] LIKE '" & Barcode(Index).Caption & "'"
    SearchSTR = StrSQL
    frmBooks.Show
End Sub

Private Sub txtInput_Click()
cmdPrev.Visible = False
If Len(txtInput) = 0 Then
Else
If Len(txtInput) < 10 Then
If Left(txtInput, 1) = "?" Then
If Left(txtInput, 4) = "? A " Then
InputBox ("Authors Name")
ElseIf Left(txtInput, 4) = "? A:" Then
EntryLength = Len(txtInput) - 4
txtStringVal = Right(txtInput, EntryLength)
MsgBox ("Your Selected Authour is " & txtStringVal)
ElseIf Left(txtInput, 4) = "? T " Then
InputBox ("Title?")
ElseIf Left(txtInput, 4) = "? T:" Then
EntryLength = Len(txtInput) - 4
txtStringVal = Right(txtInput, EntryLength)
MsgBox ("You Want The Title " & txtStringVal)
End If
Else
   Set RstQuery = Nothing
icoBooks(0).Visible = False
hr(0).Visible = False
Barcode(0).Visible = False
Title(0).Visible = False
lblTopic(0).Visible = False
icoBooks(1).Visible = False
hr(1).Visible = False
Barcode(1).Visible = False
Title(1).Visible = False
lblTopic(1).Visible = False
icoBooks(2).Visible = False
hr(2).Visible = False
Barcode(2).Visible = False
Title(2).Visible = False
lblTopic(2).Visible = False
icoBooks(3).Visible = False
hr(3).Visible = False
Barcode(3).Visible = False
Title(3).Visible = False
lblTopic(3).Visible = False
lblDateDue(0).Visible = False
lblDateDue(1).Visible = False
lblDateDue(2).Visible = False
lblDateDue(3).Visible = False
A = 0
c = 0
Patrons.Recordset.MoveFirst
Patrons.Recordset.FindFirst ("PatronBarcode='" & txtInput & "'")
Label14.Caption = Format(Label14.Caption, "(###)-###-####")
' Find Books Already Signed Out
    StrSQL = "SELECT * FROM [Signout]"
    StrSQL = StrSQL & " WHERE [Patron] LIKE '" & txtInput.Text & "'"
    Set RstQuery = Db.OpenRecordset(StrSQL)
    If Not (RstQuery.BOF And RstQuery.EOF) Then
        RstQuery.MoveFirst
        Do While Not RstQuery.EOF
        Books.Recordset.MoveFirst
        Books.Recordset.FindFirst ("Barcode='" & RstQuery.Fields("Barcode").Value & "'")
        If A > 3 Then
        Topica = Books.Recordset.Fields("TopicID").Value
        Topics.Recordset.MoveFirst
        Topics.Recordset.FindFirst ("TopicID=" & Topica)
        Else
        icoBooks(A).Visible = True
        hr(A).Visible = True
        Barcode(A).Visible = True
        Title(A).Visible = True
        lblTopic(A).Visible = True
        lblDateDue(A).Visible = True
        Barcode(A).Caption = Books.Recordset.Fields("Barcode").Value
        Title(A).Caption = Books.Recordset.Fields("Title").Value
        Topics.Recordset.MoveFirst
        lblTopic(A).Caption = Books.Recordset.Fields("TopicID").Value
        Topics.Recordset.FindFirst ("TopicID=" & lblTopic(A).Caption)
        lblTopic(A).Caption = Topics.Recordset.Fields("TopicName").Value
        lblDateDue(A).Caption = RstQuery.Fields("DateDue").Value
       End If
        bookTitle(A) = Books.Recordset.Fields("Title").Value
        bookBarcode(A) = Books.Recordset.Fields("Barcode").Value
        bookTopic(A) = Topics.Recordset.Fields("TopicName").Value
        bookDateDue(A) = RstQuery.Fields("DateDue").Value
        A = A + 1
        RstQuery.MoveNext
        Loop
  
    End If



End If
Else
If Left(txtInput, 1) = "?" Then
If Left(txtInput, 4) = "? A " Then
InputBox ("Authors Name")
ElseIf Left(txtInput, 4) = "? A:" Then
EntryLength = Len(txtInput) - 4
txtStringVal = Right(txtInput, EntryLength)
MsgBox ("Your Selected Authour is " & txtStringVal)
ElseIf Left(txtInput, 4) = "? T " Then
InputBox ("Title?")
ElseIf Left(txtInput, 4) = "? T:" Then
EntryLength = Len(txtInput) - 4
txtStringVal = Right(txtInput, EntryLength)
MsgBox ("You Want The Title " & txtStringVal)
End If
Else
StrSQL = "SELECT * FROM [Books]"
StrSQL = StrSQL & " WHERE [Barcode] LIKE '" & txtInput.Text & "'"
Set dbBooks = Db.OpenRecordset(StrSQL)
If dbBooks.EOF And dbBooks.BOF Then
N = MsgBox("Barcode Not Found", vbOKOnly, "Not Found")
Else
        StrAvail = "Select * From [Signout] Where [Barcode] Like '" & txtInput.Text & "' AND [Available] Not Like True"
        Set signout = Db.OpenRecordset(StrAvail)
        If signout.BOF And signout.EOF Then
        Topica = dbBooks.Fields("TopicID").Value
        Topics.Recordset.MoveFirst
        Topics.Recordset.FindFirst ("TopicID=" & Topica)
        bookTitle(A) = dbBooks.Fields("Title").Value
        bookBarcode(A) = dbBooks.Fields("Barcode").Value
        bookTopic(A) = Topics.Recordset.Fields("TopicName").Value
        bookDateDue(A) = Left(DateAdd("d", 14, Now), 8)
        signout.AddNew
        signout.Fields("Barcode") = bookBarcode(A)
        signout.Fields("DateDue") = bookDateDue(A)
        signout.Fields("Patron") = lblPatronNumber.Caption
        signout.Update
        b = A - 3
        If A < 3 Then
        icoBooks(A).Visible = True
        hr(A).Visible = True
        Barcode(A).Visible = True
        Title(A).Visible = True
        lblTopic(A).Visible = True
        lblDateDue(A).Visible = True
        Call vsb_Change
        Else
        End If
        
        A = A + 1
        Call vsb_Change
        Else
        End If
        
End If
End If
End If
txtInput.Text = ""
End If
End Sub

Private Sub txtInput_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Call txtInput_Click
End Sub

Private Sub vsb_Change()
lblTopic(0).Caption = bookTopic(c)
lblTopic(1).Caption = bookTopic(c + 1)
lblTopic(2).Caption = bookTopic(c + 2)
lblTopic(3).Caption = bookTopic(c + 3)
Barcode(0).Caption = bookBarcode(c)
Barcode(1).Caption = bookBarcode(c + 1)
Barcode(2).Caption = bookBarcode(c + 2)
Barcode(3).Caption = bookBarcode(c + 3)
Title(0).Caption = bookTitle(c)
Title(1).Caption = bookTitle(c + 1)
Title(2).Caption = bookTitle(c + 2)
Title(3).Caption = bookTitle(c + 3)
lblDateDue(0).Caption = bookDateDue(c)
lblDateDue(1).Caption = bookDateDue(c + 1)
lblDateDue(2).Caption = bookDateDue(c + 2)
lblDateDue(3).Caption = bookDateDue(c + 3)
If c = 0 Then
cmdPrev.Visible = False
Else
cmdPrev.Visible = True
End If
If A <= 4 Then cmdNext.Visible = False
If A > 4 Then cmdNext.Visible = True
If Barcode(1).Caption = "" Then
icoBooks(1).Visible = True
hr(1).Visible = True
Barcode(1).Visible = True
Title(1).Visible = True
lblTopic(1).Visible = True
lblDateDue(1).Visible = True
icoBooks(2).Visible = True
hr(2).Visible = True
Barcode(2).Visible = True
Title(2).Visible = True
lblTopic(2).Visible = True
lblDateDue(2).Visible = True
icoBooks(3).Visible = True
hr(3).Visible = True
Barcode(3).Visible = True
Title(3).Visible = True
lblTopic(3).Visible = True
lblDateDue(3).Visible = True
ElseIf Barcode(2).Caption = "" Then
icoBooks(2).Visible = True
hr(2).Visible = True
Barcode(2).Visible = True
Title(2).Visible = True
lblTopic(2).Visible = True
lblDateDue(2).Visible = True
icoBooks(3).Visible = True
hr(3).Visible = True
Barcode(3).Visible = True
Title(3).Visible = True
lblTopic(3).Visible = True
lblDateDue(3).Visible = True
ElseIf Barcode(3).Caption = "" Then
icoBooks(3).Visible = True
hr(3).Visible = True
Barcode(3).Visible = True
Title(3).Visible = True
lblTopic(3).Visible = True
lblDateDue(3).Visible = True
Else
icoBooks(0).Visible = True
hr(0).Visible = True
Barcode(0).Visible = True
Title(0).Visible = True
lblTopic(0).Visible = True
lblDateDue(0).Visible = True
icoBooks(1).Visible = True
hr(1).Visible = True
Barcode(1).Visible = True
Title(1).Visible = True
lblTopic(1).Visible = True
lblDateDue(1).Visible = True
icoBooks(2).Visible = True
hr(2).Visible = True
Barcode(2).Visible = True
Title(2).Visible = True
lblTopic(2).Visible = True
lblDateDue(2).Visible = True
icoBooks(3).Visible = True
hr(3).Visible = True
Barcode(3).Visible = True
Title(3).Visible = True
lblTopic(3).Visible = True
lblDateDue(3).Visible = True
End If

End Sub
