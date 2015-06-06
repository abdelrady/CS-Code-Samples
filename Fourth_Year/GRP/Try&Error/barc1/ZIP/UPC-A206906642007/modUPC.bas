Attribute VB_Name = "modUPC"
'*************************************************************************************
' UPC-A Barcode Image Generator
' Copyright: 2006 Chris Mauck
' Component: modUPC - Module which does all of the work.
'
' Purpose: Code was developed to create UPC-A image for a DVD Database collection. This
' allows the owner of the database to create a scannable UPC code to be printed on any
' receipts that may be generated.
'
' Could not find any other programs to generate the UPC-A barcode properly so I created
' my own. There is probably a faster way then what I have done, but creativity is
' spawned by necessity. There may be ideas and concepts intermixed within my module that
' are derivitives of others, possibly found on PSC. Not sure, its been over a year.
'
' Full version of the program creates an HTML page from the Access database information
' and includes the barcode (if user chooses to) on the page.
'
' Scope: Associated module simply takes each of the 12 digits in a UPC-A barcode and
' places them within labels already placed inside of a PictureBox in the proper locations.
' The module copies the contents of the PictureBox to a second PictureBox and then uses
' the label information from the first to 'draw' the lines for the barcode.
'
' Commented out the section of the module at the end that saves a copy of the resulting
' barcode in bitmap format.
'
' This is 'free' software with the following restrictions:
'
' You may not redistribute this code as a 'sample' or 'demo'. However, you are free
' to use the source code in your own code, but you may not claim that you created
' the sample code. It is expressly forbidden to sell or profit from this source code
' other than by the knowledge gained or the enhanced value added by your own code.
'
' Use of this software is also done so at your own risk. The code is supplied as
' is without warranty or guarantee of any kind.
'
'*************************************************************************************

Public Sub barcode(FieldUPC As String, frm As Form)
    Dim Script As Object
    Set Script = CreateObject("Scripting.filesystemobject")

    Dim X As Long, Y As Long, pos As Long
    Dim i
    Dim Bardata As String

    Dim Cur As String
    Dim CurVal As Long
    Dim TEMP As String
    Dim AryTest() As String
    Dim strText As String
        Dim BC(9) As String
        Dim cb(9) As String
        Dim BB(2) As String

    pos = 0

    frm.L(0).Caption = ""
    frm.L(1).Caption = ""
    frm.L(2).Caption = ""
    frm.L(3).Caption = ""
    frm.L(4).Caption = ""
    frm.L(5).Caption = ""
    frm.R(0).Caption = ""
    frm.R(1).Caption = ""
    frm.R(2).Caption = ""
    frm.R(3).Caption = ""
    frm.R(4).Caption = ""
    frm.R(5).Caption = ""
    
'    frm.picUPC.Picture = LoadPicture("")
     frm.picUPC.Cls

'If saving the image to a file:
'Uncomment the "Find and Delete if exists" on the next line and the "Save" line at the end.
''If Script.FileExists(App.Path & "\00000.bmp") = True Then Kill (App.Path & "\00000.bmp")
    
    If frm.txtUPC.Text = "" Then
        MsgBox "You must enter a minimum 12 digit number to complete the  " & vbCrLf & _
               "barcode example properly. Any length over 12 digits will  " & vbCrLf & _
               "be ignored.", vbCritical, frm.Caption
        frm.txtUPC.Text = "097363395843"    ' reset original 12 digit number for example.
        Exit Sub
    End If

    BC(0) = "0 0 0 1 1 0 1" '0
    BC(1) = "0 0 1 1 0 0 1" '1
    BC(2) = "0 0 1 0 0 1 1" '2
    BC(3) = "0 1 1 1 1 0 1" '3
    BC(4) = "0 1 0 0 0 1 1" '4
    BC(5) = "0 1 1 0 0 0 1" '5
    BC(6) = "0 1 0 1 1 1 1" '6
    BC(7) = "0 1 1 1 0 1 1" '7
    BC(8) = "0 1 1 0 1 1 1" '8
    BC(9) = "0 0 0 1 0 1 1" '9
    cb(0) = "1 1 1 0 0 1 0" '0
    cb(1) = "1 1 0 0 1 1 0" '1
    cb(2) = "1 1 0 1 1 0 0" '2
    cb(3) = "1 0 0 0 0 1 0" '3
    cb(4) = "1 0 1 1 1 0 0" '4
    cb(5) = "1 0 0 1 1 1 0" '5
    cb(6) = "1 0 1 0 0 0 0" '6
    cb(7) = "1 0 0 0 1 0 0" '7
    cb(8) = "1 0 0 1 0 0 0" '8
    cb(9) = "1 1 1 0 1 0 0" '9
    BB(0) = "1 0 1" 'Start
    BB(1) = "0 1 0 1 0" 'Mid
    BB(2) = "1 0 1" 'Stop
    
    'strText = frm.txtUPC.Text
    
    frm.L(0).Caption = Left(FieldUPC, 1)
    frm.L(1).Caption = Right(Left(FieldUPC, 2), 1)
    frm.L(2).Caption = Right(Left(FieldUPC, 3), 1)
    frm.L(3).Caption = Right(Left(FieldUPC, 4), 1)
    frm.L(4).Caption = Right(Left(FieldUPC, 5), 1)
    frm.L(5).Caption = Right(Left(FieldUPC, 6), 1)
    frm.R(0).Caption = Right(Left(FieldUPC, 7), 1)
    frm.R(1).Caption = Right(Left(FieldUPC, 8), 1)
    frm.R(2).Caption = Right(Left(FieldUPC, 9), 1)
    frm.R(3).Caption = Right(Left(FieldUPC, 10), 1)
    frm.R(4).Caption = Right(Left(FieldUPC, 11), 1)
    frm.R(5).Caption = Right(Left(FieldUPC, 12), 1)
    
    frm.picUPC.Picture = frm.picUPCy.Image
    
        frm.picUPC.CurrentX = 10
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(0).Caption
        CurVal = frm.L(0).Caption
            pos = 23
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 50), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 50), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 32
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(1).Caption
        CurVal = frm.L(1).Caption
            pos = 30
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 38
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(2).Caption
        CurVal = frm.L(2).Caption
            pos = 37
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 44
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(3).Caption
        CurVal = frm.L(3).Caption
            pos = 44
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 50
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(4).Caption
        CurVal = frm.L(4).Caption
            pos = 51
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 56
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.L(5).Caption
        CurVal = frm.L(5).Caption
            pos = 58
            strText = BC(CurVal)
            AryTest = Split(BC(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 71
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(0).Caption
        CurVal = frm.R(0).Caption
            pos = 70
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 78
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(1).Caption
        CurVal = frm.R(1).Caption
            pos = 77
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 84
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(2).Caption
        CurVal = frm.R(2).Caption
            pos = 84
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 90
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(3).Caption
        CurVal = frm.R(3).Caption
            pos = 91
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 96
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(4).Caption
        CurVal = frm.R(4).Caption
            pos = 98
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 42), &HFFFFFF
                End If
                pos = pos + 1
            Next i
        frm.picUPC.CurrentX = 118
        frm.picUPC.CurrentY = 42
        frm.picUPC.Print frm.R(5).Caption
        CurVal = frm.R(5).Caption
            pos = 105
            strText = cb(CurVal)
            AryTest = Split(cb(CurVal), " ")
            For i = 0 To 6
                If AryTest(i) = "1" Then
                    frm.picUPC.Line (pos, 6)-(pos, 50), &H0&
                ElseIf AryTest(i) = "0" Then
                    frm.picUPC.Line (pos, 6)-(pos, 50), &HFFFFFF
                End If
                pos = pos + 1
            Next i
    
    frm.picUPC.Line (20, 6)-(20, 50), &H0&
    frm.picUPC.Line (21, 6)-(21, 50), &HFFFFFF
    frm.picUPC.Line (22, 6)-(22, 50), &H0&
    
    frm.picUPC.Line (65, 6)-(65, 50), &HFFFFFF
    frm.picUPC.Line (66, 6)-(66, 50), &H0&
    frm.picUPC.Line (67, 6)-(67, 50), &HFFFFFF
    frm.picUPC.Line (68, 6)-(68, 50), &H0&
    frm.picUPC.Line (69, 6)-(69, 50), &HFFFFFF
   
    frm.picUPC.Line (112, 6)-(112, 50), &H0&
    frm.picUPC.Line (113, 6)-(113, 50), &HFFFFFF
    frm.picUPC.Line (114, 6)-(114, 50), &H0&

    frm.picUPC.Picture = frm.picUPC.Image

    'SavePicture frm.picUPC.Picture, App.Path & "\00000.bmp"

End Sub

