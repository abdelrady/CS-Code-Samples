VERSION 5.00
Begin VB.Form frmJavaTest 
   Caption         =   "frmJavaTest"
   ClientHeight    =   2745
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   2745
   ScaleWidth      =   4680
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame Frame1 
      Height          =   1950
      Left            =   120
      TabIndex        =   5
      Top             =   60
      Width           =   4425
      Begin VB.Label Label1 
         Caption         =   " !!!!!!!          the file will be in the same folder         !!!!!!!!    "
         Height          =   930
         Left            =   165
         TabIndex        =   6
         Top             =   555
         Width           =   4170
      End
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   465
      Left            =   2940
      TabIndex        =   4
      Top             =   2220
      Width           =   1395
   End
   Begin VB.TextBox txtP 
      Height          =   570
      Index           =   2
      Left            =   90
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   3
      Text            =   "frmJavaTest.frx":0000
      Top             =   1365
      Visible         =   0   'False
      Width           =   4305
   End
   Begin VB.TextBox txtP 
      Height          =   570
      Index           =   1
      Left            =   45
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   2
      Text            =   "frmJavaTest.frx":0056
      Top             =   735
      Visible         =   0   'False
      Width           =   4305
   End
   Begin VB.TextBox txtP 
      Height          =   570
      Index           =   0
      Left            =   60
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   1
      Text            =   "frmJavaTest.frx":02A1
      Top             =   90
      Visible         =   0   'False
      Width           =   4305
   End
   Begin VB.CommandButton cmdMake 
      Caption         =   "Make GuiTest.java"
      Height          =   510
      Left            =   120
      TabIndex        =   0
      Top             =   2190
      Width           =   1710
   End
End
Attribute VB_Name = "frmJavaTest"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com


Option Explicit

Private Sub cmdClose_Click()
    Me.Hide
End Sub

Private Sub cmdMake_Click()
    ' properties of current window control:
    Dim s1 As String
    Dim s2 As String
    
    If (SELECTED_SHAPE = -1) Then
        mBox "Block not selected!"
        Exit Sub
    End If

    Dim cb As cBlock
    Set cb = frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
    
    s1 = cb.zParam1  ' window properties.
    s2 = cb.zParam2  ' control properties.
    
    
    
    Dim iFnum As Integer
    iFnum = FreeFile
    
    Open AddSlash(App.Path) & "GuiTest.java" For Output As iFnum
    
    Print #iFnum, txtP(0).Text          ' const #1
    
    ' generate insert #1:
    insertDefinitions iFnum, s2
    
    Print #iFnum, ""        ' empty line!
    
    Print #iFnum, txtP(1).Text          ' const #2
        
    ' generate insert #2:
    insertCreation iFnum, s2
    
    Print #iFnum, ""        ' empty line!
    
    ' generate insert #3:
    insertWindowProp iFnum, s1
    
    Print #iFnum, "    }"       ' close the contructor.
    
    Print #iFnum, ""        ' empty line!
    
    ' generate insert #4:
    insertActionPerformed iFnum, s2
    
    Print #iFnum, ""        ' empty line!
    
    Print #iFnum, txtP(2).Text          ' const #3
    
    
    
    Close #iFnum
    
    
    mBox "File created:   GuiTest.java" & vbNewLine & _
           "Now do this: " & vbNewLine & _
           "   javac GuiTest.java" & vbNewLine & _
           "   java GuiTest"
    Me.Hide
End Sub





Private Sub insertDefinitions(iFnum As Integer, ByVal Source As String)
Dim sTYPE As String
Dim s As String

next_Component:
            
        sTYPE = rcToken(Source, "|")    ' component type.
        
        If sTYPE <> "" Then ' stop when string ends.
            s = rcToken(Source, "|") ' name (sID).

                
            ' generate the code:
            Select Case sTYPE
            Case "BUTTON"
                Print #iFnum, "JButton " & s & ";"
            Case "TAREA"
                Print #iFnum, "JTextField " & s & ";"
            End Select
              
                
            ' skip all other properties:
            
            s = rcToken(Source, "|") ' text.
                 
            s = rcToken(Source, "|") ' X.
            ' Val(s)
            
            s = rcToken(Source, "|") ' Y.
            ' Val(s)
            
            s = rcToken(Source, "|") ' W.
            ' Val(s)
            
            s = rcToken(Source, "|") ' H.
            ' Val(s)
            
            s = rcToken(Source, "|") ' function 1.
            
            s = rcToken(Source, "|") ' function 2.
            
            GoTo next_Component
        End If

End Sub



Private Sub insertCreation(iFnum As Integer, ByVal Source As String)
Dim sTYPE As String
Dim s As String

Dim sName As String
Dim sText As String
Dim X As Integer
Dim Y As Integer
Dim w As Integer
Dim h As Integer

next_Component:
            
        sTYPE = rcToken(Source, "|")    ' component type.
        
        If sTYPE <> "" Then ' stop when string ends.
            sName = rcToken(Source, "|") ' name (sID).
              
            
            sText = rcToken(Source, "|") ' text.
                 
            s = rcToken(Source, "|") ' X.
            X = Val(s) / Screen.TwipsPerPixelX
            
            s = rcToken(Source, "|") ' Y.
            Y = Val(s) / Screen.TwipsPerPixelY
            
            s = rcToken(Source, "|") ' W.
            w = Val(s) / Screen.TwipsPerPixelX
            
            s = rcToken(Source, "|") ' H.
            h = Val(s) / Screen.TwipsPerPixelY
            
            ' generate the code:
            Select Case sTYPE
            Case "BUTTON"
                Print #iFnum, sName & " = new JButton(""" & sText & """);"
                Print #iFnum, sName & ".reshape(" & X & "," & Y & "," & w & "," & h; ");"
                Print #iFnum, "pMain.add (" & sName & ");"
                Print #iFnum, sName & ".addActionListener(this);"
            Case "TAREA"
                Print #iFnum, sName & " = new JTextField(""" & sText & """);"
                Print #iFnum, sName & ".reshape(" & X & "," & Y & "," & w & "," & h; ");"
                Print #iFnum, "pMain.add (" & sName & ");"
                Print #iFnum, sName & ".addActionListener(this);"
            End Select
            
            
             ' skip all other properties:
            
            
            s = rcToken(Source, "|") ' function 1.
            
            s = rcToken(Source, "|") ' function 2.
            
            GoTo next_Component
        End If

End Sub



Private Sub insertWindowProp(iFnum As Integer, ByVal Source As String)

Dim w As Integer
Dim h As Integer

    Print #iFnum, "setContentPane (pMain);"
               
    w = Val(rcToken(Source, "|")) / Screen.TwipsPerPixelX
    h = Val(rcToken(Source, "|")) / Screen.TwipsPerPixelY
    
    If Me.ScaleMode = 1 Then ' works only with twips!!!
        ' corretion for caption
        '   (it doesn't really matter what form to use)
        h = h + (Me.Height - Me.ScaleHeight) / Screen.TwipsPerPixelY
    End If
    
    Print #iFnum, "setSize(" & w & "," & h & ");"
    
    Print #iFnum, "setVisible(true);"
     
End Sub




Private Sub insertActionPerformed(iFnum As Integer, ByVal Source As String)
Dim sTYPE As String
Dim s As String


    Print #iFnum, "public void actionPerformed(ActionEvent e){"
    Print #iFnum, "  Object src=e.getSource();"


next_Component:
            
        sTYPE = rcToken(Source, "|")    ' component type.
        
        If sTYPE <> "" Then ' stop when string ends.
            s = rcToken(Source, "|") ' name (sID).

                
            ' generate the code:
            Print #iFnum, "  if (src == " & s & ") {"
            Print #iFnum, "            // add your code here!"
            Print #iFnum, "  }"
                
            ' skip all other properties:
            
            s = rcToken(Source, "|") ' text.
                 
            s = rcToken(Source, "|") ' X.
            ' Val(s)
            
            s = rcToken(Source, "|") ' Y.
            ' Val(s)
            
            s = rcToken(Source, "|") ' W.
            ' Val(s)
            
            s = rcToken(Source, "|") ' H.
            ' Val(s)
            
            s = rcToken(Source, "|") ' function 1.
            
            s = rcToken(Source, "|") ' function 2.
            
            GoTo next_Component
        End If


     Print #iFnum, "}"  ' close actionPerformed().
     
End Sub
