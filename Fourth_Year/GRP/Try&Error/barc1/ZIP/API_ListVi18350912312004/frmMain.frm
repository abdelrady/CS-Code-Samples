VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "ListView Autosize Example"
   ClientHeight    =   2295
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5295
   BeginProperty Font 
      Name            =   "Verdana"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2295
   ScaleWidth      =   5295
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdAbout 
      Caption         =   "&About"
      Height          =   345
      Left            =   3960
      TabIndex        =   3
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton cmdColumn 
      Caption         =   "Column 2"
      Height          =   345
      Index           =   1
      Left            =   1440
      TabIndex        =   2
      Top             =   120
      Width           =   1215
   End
   Begin MSComctlLib.ListView lvwTest 
      Height          =   1695
      Left            =   0
      TabIndex        =   1
      Top             =   600
      Width           =   5295
      _ExtentX        =   9340
      _ExtentY        =   2990
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   0
   End
   Begin VB.CommandButton cmdColumn 
      Caption         =   "Column 1"
      Height          =   345
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Known possible bugs:
'
' If the ListView control is set to report mode, AND an indent value is
'   specified for any item, AND the computer has v4.70 or v4.72 of COMMCTL32.DLL
'   installed, this will not work.
' Fix: Upgrade COMMCTL32.DLL
'   See: http://support.microsoft.com/default.aspx?scid=kb;EN-US;q246364
'
' If only some of the items in the ListView are bold, but the actual font for
'   the control is not set to bold, the column will resize to the correct width
'   for the items as if they were not bold.
' Fix: Set the font of the entire ListView control to bold, THEN call
'   LVM_SETCOLUMNWIDTH, then unset the bold font of the entire ListView control.
'   If you know of a better way, please contact me via my website in the about
'   dialog or post a reply on Planet Source Code.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Explicit

Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function LockWindowUpdate Lib "user32" (ByVal hwndLock As Long) As Long

Const LVM_FIRST As Long = &H1000
Const LVM_SETCOLUMNWIDTH As Long = (LVM_FIRST + 30)
Const LVSCW_AUTOSIZE As Long = -1
Const LVSCW_AUTOSIZE_USEHEADER As Long = -2 'Note: On last column, its width fills remaining width
                                            '   of list-view according to Micro$oft. This does not
                                            '   appear to be the case when I do it.

Private Sub cmdAbout_Click()
    MsgBox "Author:" & vbTab & "Barcode (Andy D.)" & vbCrLf & _
    "Website:" & vbTab & "http://andy.dynamicbits.com/", _
    vbOKOnly + vbInformation, "About"
End Sub

Private Sub cmdColumn_Click(Index As Integer)   ' Resize column
    LockWindowUpdate lvwTest.hWnd               ' Lock update of ListView. Prevents ghostly text
                                                ' from appearing. I have seen it happen in other
                                                ' projects, but not this one. Always a good idea
                                                ' to use nonetheless.
    SendMessage lvwTest.hWnd, LVM_SETCOLUMNWIDTH, Index, LVSCW_AUTOSIZE_USEHEADER ' The magic of auotosize
    LockWindowUpdate 0                          ' Unlock
End Sub

Private Sub Form_Load()                     ' Load data into the ListView
    lvwTest.ColumnHeaders.Add 1, , "Character"                          ' Header 1
    lvwTest.ColumnHeaders.Add 2, , "Role"                               ' Header 2
    lvwTest.ListItems.Add 1, , "Homer Simpson"                          ' Column 1
    lvwTest.ListItems(1).SubItems(1) = "Works at nuclear power plant"   ' Column 2
    lvwTest.ListItems.Add 2, , "Montgomery Burns"
    lvwTest.ListItems(2).SubItems(1) = "Owner/boss of power plant"
    lvwTest.ListItems.Add 3, , "Wayland Smithers"
    lvwTest.ListItems(3).SubItems(1) = "Mr. Burns's secretary"
    lvwTest.ListItems.Add 4, , "Apu Nahasateemapetalon"
    lvwTest.ListItems(4).SubItems(1) = "Owns Kwik-E-Mart"
    lvwTest.ListItems.Add 5, , "Clancey Wiggum"
    lvwTest.ListItems(5).SubItems(1) = "Police chief"
    lvwTest.ListItems.Add 6, , "Milhouse Van Houghton"
    lvwTest.ListItems(6).SubItems(1) = "Bart's best friend"
End Sub
