Attribute VB_Name = "modPrinting"
Private Type Rect
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type

Private Type CharRange
    cpMin As Long     ' First character of range (0 for start of doc)
    cpMax As Long     ' Last character of range (-1 for end of doc)
End Type

Private Type FormatRange
    hdc As Long       ' Actual DC to draw on
    hdcTarget As Long ' Target DC for determining text formatting
    rc As Rect        ' Region of the DC to draw to (in twips)
    rcPage As Rect    ' Region of the entire DC (page size) (in twips)
    chrg As CharRange ' Range of text to draw (see above declaration)
End Type

Private Const WM_USER As Long = &H400
Private Const EM_FORMATRANGE As Long = WM_USER + 57
Private Const EM_SETTARGETDEVICE As Long = WM_USER + 72
Private Const PHYSICALOFFSETX As Long = 112
Private Const PHYSICALOFFSETY As Long = 113

Private Declare Function GetDeviceCaps Lib "gdi32" ( _
    ByVal hdc As Long, ByVal nIndex As Long) As Long

'Remove the comments below so you can use SendMessage function
'on frmPreview.
'
Public Declare Function SendMessage Lib "USER32" Alias "SendMessageA" _
    (ByVal hWnd As Long, ByVal msg As Long, ByVal wp As Long, _
    lp As Any) As Long
'Used for finding strings in list/combo boxes
Public Const CB_FINDSTRINGEXACT = &H158
Public Const CB_FINDSTRING = &H14C
Public Const CB_ERR = (-1)

Private Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" _
    (ByVal lpDriverName As String, ByVal lpDeviceName As String, _
    ByVal lpOutput As Long, ByVal lpInitData As Long) As Long

'pgOrientation = 1 for Portrait, 2 for Landscape

Public Sub PrintPreview(RTF As RichTextBox, LeftMarginWidth As Currency, _
    TopMarginHeight As Currency, RightMarginWidth As Currency, BottomMarginHeight As Currency, _
    pgOrientation As Integer)
      
    Dim LeftOffset As Long, TopOffset As Long
    Dim LeftMargin As Long, TopMargin As Long
    Dim RightMargin As Long, BottomMargin As Long
    Dim fr As FormatRange
    Dim rcDrawTo As Rect
    Dim rcPage As Rect
    Dim TextLength As Long
    Dim NextCharPosition As Long
    Dim r As Long
    Dim iCount As Integer

    On Error GoTo ErrHandle
    
'Set the orientation of the printer
    Printer.Orientation = pgOrientation
    Printer.ScaleMode = vbTwips

' Calculate the Left, Top, Right, and Bottom margins
    LeftMargin = CLng(LeftMarginWidth - LeftOffset)
    TopMargin = CLng(TopMarginHeight - TopOffset)
    RightMargin = CLng((Printer.Width - RightMarginWidth) - LeftOffset)
    BottomMargin = CLng((Printer.Height - BottomMarginHeight) - TopOffset)

' Set printable area rect
    rcPage.Left = 0
    rcPage.Top = 0
    rcPage.Right = Printer.ScaleWidth
    rcPage.Bottom = Printer.ScaleHeight

' Set rect in which to print (relative to printable area)
    rcDrawTo.Left = LeftMargin
    rcDrawTo.Top = TopMargin
    rcDrawTo.Right = RightMargin
    rcDrawTo.Bottom = BottomMargin

'Size the Print Preview picture box
    frmPreview.SizePreview Printer.Width, Printer.Height
    
' Set up the print instructions
    fr.hdc = frmPreview.picPreview(0).hdc   ' Use the same DC for measuring and rendering
    fr.hdcTarget = frmPreview.picPreview(0).hdc  ' Point at printer hDC
    fr.rc = rcDrawTo            ' Indicate the area on page to draw to
    fr.rcPage = rcPage          ' Indicate entire size of page
    fr.chrg.cpMin = 0           ' Indicate start of text through
    fr.chrg.cpMax = -1          ' end of the text

' Get length of text in RTF
    TextLength = Len(RTF.Text)

' Loop printing each page until done
    Dim iPage As Integer
    
    iPage = 1
    
    Do
        With frmPreview
            If iPage > 1 Then
                .AddPage iPage
                fr.hdc = .picPreview(iPage - 1).hdc
                fr.hdcTarget = .picPreview(iPage - 1).hdc
            End If
            .picPreview(iPage - 1).Print
        End With

' Print the page by sending EM_FORMATRANGE message
        NextCharPosition = SendMessage(RTF.hWnd, EM_FORMATRANGE, True, fr)
        If NextCharPosition >= TextLength Then Exit Do  'If done then exit
        fr.chrg.cpMin = NextCharPosition ' Starting position for next page
        
        iPage = iPage + 1
    Loop

' Allow the RTF to free up memory
    r = SendMessage(RTF.hWnd, EM_FORMATRANGE, False, ByVal CLng(0))

    frmPreview.Show

    Exit Sub
    
ErrHandle:
    Select Case Err.Number
        Case 482
            MsgBox "Make sure that you have a printer installed.  If a " & _
                "printer is installed, go into your printer properties " & _
                "look under the Setup tab, and make sure the ICM checkbox " & _
                "is checked and try printing again.", , "Printer Error"
            Exit Sub
        Case Else
            MsgBox Err.Number & " " & Err.Description
            Resume Next
    End Select
    
End Sub


