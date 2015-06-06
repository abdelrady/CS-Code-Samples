VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "Mscomctl.ocx"
Begin VB.Form frmShowAllMedia 
   Caption         =   "MediaLibraryShow All"
   ClientHeight    =   6465
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   12300
   LinkTopic       =   "Form1"
   ScaleHeight     =   6465
   ScaleWidth      =   12300
   StartUpPosition =   3  'Windows Default
   Begin VB.ComboBox cboMediaKeys 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   345
      Left            =   7320
      Sorted          =   -1  'True
      TabIndex        =   5
      Top             =   5520
      Width           =   3015
   End
   Begin VB.CommandButton cmdRefreshView 
      Caption         =   "Refresh View"
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton cmdShowFind 
      Caption         =   "&Find"
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   5520
      Width           =   1455
   End
   Begin VB.TextBox txtFindKeyValue 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   1920
      TabIndex        =   2
      Text            =   "-- enter media key --"
      Top             =   5520
      Width           =   3615
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   10560
      TabIndex        =   1
      Top             =   5520
      Width           =   1455
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   4815
      Left            =   240
      TabIndex        =   0
      Top             =   600
      Width           =   11895
      _ExtentX        =   20981
      _ExtentY        =   8493
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      HotTracking     =   -1  'True
      HoverSelection  =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Comic Sans MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   0
   End
   Begin VB.Label lblStatusLine 
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   6000
      Width           =   12015
   End
   Begin VB.Label Label1 
      Caption         =   "Media Key:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6240
      TabIndex        =   6
      Top             =   5520
      Width           =   975
   End
End
Attribute VB_Name = "frmShowAllMedia"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------
' Module    : frmShowAll
' DateTime  : 04/05/2005 08:30
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' BUG FIX   :
' Version   : 1.1
' Details   : add sorted media keys combo to help find keys in listview as per request Zhu JinYong May 2005
'
'
' Other changes:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'
' Purpose:
'        This is a beta media library sample using the BSTN class as it's database engine.
'        Other p-s-c visitors offered their help in testing the beta sample, checking the adds, removes,
'        ordered lists etc. and it's overall general usage.
'        The sample maintains details of media such as CDs, DVDs, Audio Tapes, VHS Videos etc.
'
'---------------------------------------------------------------------------------------

' Project   : Media Library
' DateTime  : 28/04/2005 20:37
' Author    : D K Richmond
' Status    : BETA RELEASE 1.1
' Version   : Visual Basic 6 (SP6)
' User Type : Beginner/Intermediate/Advanced
' Applicable: Database/Data Sorting/Key Retrieval/Binary Trees/Node Traversals
'
' Credits :    Chan Wilson - for all extra beta testing
' ---------
'
' Disclaimer:
' -----------
' This software is provided as-is, no liability accepted in using
' this code or part of this code where information is used and relied upon in any
' other system or systems, projects, modules etc.
' In other words, it is provided for educational value and where experimenting
' in writing applications needing fast ordered key retrieval for testing and
' running experimental non-critical non-business applications.
'
' Copyright:
' -----------
' This was written by myself based on information from various Data Abstraction
' and storage techniques.  Some of the deletion routines are based on information (only information not code)
' from various pages on the internet (non-copyright).
' There are some excellent articles on the internet, try google.com .. searching for "Binary Trees"
'
' ALL OF THIS CODE IN THIS CLASS WAS WRITTEN FROM A BLANK WORKSHEET.  IN OTHER WORDS NONE OF THIS CODE
' WAS STRIPPED, EXTRACTED OR COPIED FROM OTHER PEOPLES WORK.  PLEASE RESPECT THAT AND
' IF YOU USE THIS CODE IN ANY OF YOUR APPLICATIONS/EXAMPLES PLEASE GIVE CREDIT FOR MY WORK.
'
' DAVID K RICHMOND dk.richmond@ntlworld.com
'
' GUIDELINES:
' -----------
'
' OVERVIEW:
' -----------
'
' DEBUGGING:
' ---------
' In BSTN Class Initialise :  gbDebug = False   '  change this to true to see lots of debug message boxes
'
' SURPRISES:
'  I have left some msgbox's and some redundant error trapping in some routines, this will be taken out real soon.
'  The are some extra definitions that I have left for the future.

' FUTURE:
' -------
' There is a lot of scope to improve this code.
'
'
' Nomenclature (normal):
' -------------
'      i - integer prefix
'      l - long prefix
'      d - double prefix
'      s - string prefix
'      e - enum
'      c - original class prefix
'      cls - instance of a class prefix
'
'      m_i - member integer prefix
'      m_l - member long prefix
'      m_d - member double prefix
'      m_s - member string prefix
'      m_e - member enum
'      m_cls - member instance of a class prefix
'
' Nomenclature (not normal):
' -------------------------
'      ip - parameter integer prefix
'      lp - parameter long prefix
'      dp - parameter double prefix
'      sp - parameter string prefix
'
'      ipo - parameter optional integer prefix
'      lpo - parameter optional long prefix
'      dpo - parameter optional double prefix
'      spo - parameter optional string prefix

Option Explicit

Private Sub cboMediaKeys_Click()

    txtFindKeyValue.Text = cboMediaKeys.Text
    cmdShowFind_Click
    
End Sub

Private Sub cmdClose_Click()
    Unload Me
End Sub


'---------------------------------------------------------------------------------------
' Procedure : cmdRefreshView_Click
' DateTime  : 04/05/2005 07:29
' Author    : D K Richmond
' Purpose   : BUG fixed where rebalance caused null key in listview due to index being lost in InitrootNode
'---------------------------------------------------------------------------------------
'
Private Sub cmdRefreshView_Click()
 Dim lNextNode As Long
 Dim sKey As String
 Dim sKeyValue As String
 Dim sTextValue As String
 Dim lDataIndex As Long
 Dim saDataValues() As String
 Dim bOk As Boolean
 Dim lviItem As MSComctlLib.ListItem
 Dim iFields As Integer
 Dim iField As Integer
 Dim bfirst As Boolean
 Dim lRecords As Long
 Dim iCol As Integer
   
   On Error GoTo cmdRefreshView_Click_Error
    
    lRecords = 0
    ListView1.Visible = False
    ListView1.ListItems.Clear
    ListView1.ColumnHeaders.Clear
    cboMediaKeys.Clear
    
    clsgBSTStore.ResetToRootNode
    bfirst = True
    Do
        If clsgBSTStore.GetNextNodeInSortedOrder(lNextNode) = True Then
    'debug
    If lNextNode > 70 Then
       ' MsgBox "eeek!" & lNextNode
        Debug.Print ""
    End If
            
            lDataIndex = clsgBSTStore.GetDataNodeIndex(lNextNode)
            
            bOk = clsgBSTStore.GetMediaRecordDataValues(lDataIndex, saDataValues())
            If bOk = False Then
                MsgBox "Media @node " & lNextNode & " No Data Found!", vbExclamation
                Exit Sub
            Else
                sKeyValue = saDataValues(egMediaIdentifier)
                Debug.Print lNextNode, lDataIndex, sKeyValue
                If sKeyValue = "" Then
                    MsgBox "Null key!"
                    Exit Sub
                    'GoTo skip
                End If
                sTextValue = saDataValues(egMediaIdentifier)
                Set lviItem = ListView1.ListItems.Add(, "K" & sKeyValue, sTextValue)
                '  ## extra feature sorted combo to find a key as requested by Zhu JinYong ##
                cboMediaKeys.AddItem sKeyValue
                If Not lviItem Is Nothing Then
                    iFields = UBound(saDataValues())
                    iCol = 0
                    For iField = 0 To iFields
                        If bfirst = True Then
                            ListView1.ColumnHeaders.Add iField + 1, "K" & iField, "" & iField
                            ListView1.ColumnHeaders(iField + 1).Width = (iCol * igcColumnSizing)
                        End If
                        iCol = iCol + 1
                        If iCol >= 4 Then
                            iCol = 1
                        End If
                        lviItem.ListSubItems.Add , "K" & saDataValues(iField) & Format(iField, "000000"), saDataValues(iField)
                    Next
                    If bfirst = True Then  ' dummy last field
                        ListView1.ColumnHeaders.Add iField + 1, "K" & iField, "" & iField
                        ListView1.ColumnHeaders(iField + 1).Width = (iCol * igcColumnSizing)
                    End If
                End If
            End If
        Else
            Exit Do
        End If
skip:
        DoEvents
        
        lblStatusLine.Caption = "Loading Record " & lRecords & " into view with key of:  " & sKeyValue
        lblStatusLine.Refresh
        lRecords = lRecords + 1
        
        If (clsgBSTStore.TopOfTreeReached = True) Then
            Exit Do
        End If
        bfirst = False
    Loop
    
    lblStatusLine.Caption = "Loaded (" & lRecords & ") Records." & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
    lblStatusLine.Refresh
    ListView1.Visible = True

    bgRefreshView = False
    
   On Error GoTo 0
   Exit Sub

cmdRefreshView_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdRefreshView_Click of Form frmShowAllMedia"
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : cmdShowFind_Click
' DateTime  : 05/05/2005 19:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdShowFind_Click()
Dim lviItem As MSComctlLib.ListItem
Dim sKeyFindValue As String

   On Error GoTo cmdShowFind_Click_Error

    sKeyFindValue = txtFindKeyValue.Text
    
    For Each lviItem In ListView1.ListItems
        If lviItem.Text = sKeyFindValue Then
            lviItem.Selected = True
            lviItem.EnsureVisible
            Exit For
        End If
    Next

   On Error GoTo 0
   Exit Sub

cmdShowFind_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdShowFind_Click of Form frmShowAllMedia"
End Sub

Private Sub Form_Activate()
 
  ' refresh of large disk files is a little tedious when testing
    ' so use dirty flag to co-ordinate if view already filled
    If ListView1.ListItems.Count > 0 Then
        'If bgDirtyFlag = False Then
            'MsgBox "No change!"
          '  Exit Sub
        'End If
    End If
    
    cmdRefreshView_Click
 
End Sub


'---------------------------------------------------------------------------------------
' Procedure : Form_Load
' DateTime  : 05/05/2005 19:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub Form_Load()
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : ListView1_Click
' DateTime  : 05/05/2005 19:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub ListView1_Click()
 Dim lviItem As MSComctlLib.ListItem
 Dim iFields As Integer
 Dim sMediaCoverFileName As String
 Dim sMediaCoverFilePathName As String
 Dim sDefaultCoverPictureFilePathName As String

   On Error GoTo ListView1_Click_Error

    Set lviItem = ListView1.SelectedItem
    If Not lviItem Is Nothing Then
        frmMainMediaLibrary.txtMediaIdentifier.Text = lviItem.ListSubItems(egMediaIdentifier + 1).Text
        frmMainMediaLibrary.txtPublisher.Text = lviItem.ListSubItems(egMediaPublisher + 1).Text
        frmMainMediaLibrary.txtTitle.Text = lviItem.ListSubItems(egMediaTitle + 1).Text
        frmMainMediaLibrary.SetMediaTypeOptionBoxes lviItem.ListSubItems(egMediaType + 1).Text
        frmMainMediaLibrary.txtClassification.Text = lviItem.ListSubItems(egMediaClassification + 1).Text
        frmMainMediaLibrary.txtCoverFileName.Text = lviItem.ListSubItems(egMediaCover + 1).Text
        frmMainMediaLibrary.cmdMediaDelete.Enabled = True
        frmMainMediaLibrary.cmdMediaEdit.Enabled = True
        
        ' begin: ###  display cover of media if exists ###
        sMediaCoverFileName = lviItem.ListSubItems(egMediaCover + 1).Text
        ' dir doesn't work for all files .. just a quick and dirty soltion for now needs FSO really
        If Len(sMediaCoverFileName) > 1 Then
            sDefaultCoverPictureFilePathName = App.Path & "\DATA\" & sgcDefaultCoverPictureFileName
            sMediaCoverFilePathName = App.Path & "\DATA\" & sMediaCoverFileName
            If Dir(sMediaCoverFilePathName, 63) = "" Then
                frmMainMediaLibrary.pctMediaCover.Picture = LoadPicture(sDefaultCoverPictureFilePathName)
            Else
                ' display default picture
                frmMainMediaLibrary.pctMediaCover.Picture = LoadPicture(sMediaCoverFilePathName)
            End If
        End If
        ' end: ###  display cover of media if exists ###
        
        frmMainMediaLibrary.Show
    Else
        MsgBox "select something first!", vbExclamation
    End If

   On Error GoTo 0
   Exit Sub

ListView1_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure ListView1_Click of Form frmShowAllMedia"
End Sub

'---------------------------------------------------------------------------------------
' Procedure : ListView1_ColumnClick
' DateTime  : 05/05/2005 19:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub ListView1_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    
   On Error GoTo ListView1_ColumnClick_Error

    ListView1.Sorted = True
    ListView1.SortKey = ColumnHeader.Index - 1
    If ListView1.SortOrder = lvwAscending Then
        ListView1.SortOrder = lvwDescending
    Else
        ListView1.SortOrder = lvwAscending
    End If

   On Error GoTo 0
   Exit Sub

ListView1_ColumnClick_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure ListView1_ColumnClick of Form frmShowAllMedia"
    
End Sub


' eom

