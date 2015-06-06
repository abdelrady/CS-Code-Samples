VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3600
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9165
   LinkTopic       =   "Form1"
   ScaleHeight     =   240
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   611
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      BackColor       =   &H00FFFFC0&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Left            =   2520
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   2400
      Width           =   4335
   End
   Begin VB.CommandButton Command1 
      Caption         =   "OK"
      Height          =   495
      Left            =   4080
      TabIndex        =   1
      Top             =   3000
      Width           =   1095
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00C0FFFF&
      FillStyle       =   0  'Solid
      Height          =   2775
      Left            =   120
      ScaleHeight     =   181
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   589
      TabIndex        =   0
      Top             =   120
      Width           =   8895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
            
            
            Picture1.Cls
            uno = "10001"
            due = "01001"
            tre = "11000"
            quattro = "00101"
            cinque = "10100"
            sei = "01100"
            sette = "00011"
            otto = "10010"
            nove = "01010"
            zero = "00110"
            rs = 3
            barrastretta = 0.72 '0.5
            barralarga = barrastretta * rs
            altezza = 18
            barrastretta1 = 3
            barralarga1 = 9
            altezza1 = 120
            stringa = Text1.Text
            lunghezza = barrastretta * 6 + barrastretta * rs
            '<<<< Calcolo Check Digit >>>>
            factor = 3
            weightedTotal = "0"
            For i = Len(stringa) To 1 Step -1
                'Singolo carattere partendo dalla coda
                CurrentChar = Mid(stringa, i, 1)
                'moltiplico per il fattore peso che è 3,1,3,1...
                'e faccio la somma
                weightedTotal = weightedTotal + CurrentChar * factor
                'cambio il fattore per il prossimo calcolo
                factor = 4 - factor
            Next i
            'cerco il CheckDigit trovando il più piccolo numero che = a un multiplo di 10
            i = (weightedTotal Mod 10)
            If i <> 0 Then
               CheckDigit = (10 - i)
            Else
               CheckDigit = 0
            End If
            'aggiungo il CheckDigit alla stringa
            stringa = stringa & CheckDigit
            
            shift = 10
            shift1 = 10
            Open App.Path + "\" + Text1.Text + ".dxf" For Output As #1
            Print #1, 0
            Print #1, "SECTION"
            Print #1, 2
            Print #1, "ENTITIES"
            
            ' disegno sulla picture box
            ' creo il DXF
            ' Start point
            Picture1.FillColor = RGB(0, 0, 0)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
            shift = shift + barrastretta
            shift1 = shift1 + barrastretta1
                
            Picture1.FillColor = RGB(240, 240, 240)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                
            shift = shift + barrastretta
            shift1 = shift1 + barrastretta1
                
            Picture1.FillColor = RGB(0, 0, 0)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
            
            shift = shift + barrastretta
            shift1 = shift1 + barrastretta1
                
            Picture1.FillColor = RGB(240, 240, 240)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                                
            shift = shift + barrastretta
            shift1 = shift1 + barrastretta1
            
            For i = 1 To Len(stringa) Step 2
                s1 = Mid(stringa, i, 1)
                s2 = Mid(stringa, i + 1, 1)
                Select Case s1
                       Case "0"
                            stringauscita1 = zero
                       Case "1"
                            stringauscita1 = uno
                       Case "2"
                            stringauscita1 = due
                       Case "3"
                            stringauscita1 = tre
                       Case "4"
                            stringauscita1 = quattro
                       Case "5"
                            stringauscita1 = cinque
                       Case "6"
                            stringauscita1 = sei
                       Case "7"
                            stringauscita1 = sette
                       Case "8"
                            stringauscita1 = otto
                       Case "9"
                            stringauscita1 = nove
                End Select
                Select Case s2
                       Case "0"
                            stringauscita2 = zero
                       Case "1"
                            stringauscita2 = uno
                       Case "2"
                            stringauscita2 = due
                       Case "3"
                            stringauscita2 = tre
                       Case "4"
                            stringauscita2 = quattro
                       Case "5"
                            stringauscita2 = cinque
                       Case "6"
                            stringauscita2 = sei
                       Case "7"
                            stringauscita2 = sette
                       Case "8"
                            stringauscita2 = otto
                       Case "9"
                            stringauscita2 = nove
                End Select
                
                For kk = 1 To 5
                    ' prima barra di colore nero
                    s1 = Mid(stringauscita1, kk, 1)
                    If s1 = "0" Then
                       lunghezza = lunghezza + barrastretta
                       Picture1.FillColor = RGB(0, 0, 0)
                       Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift
                       Print #1, 20
                       Print #1, 10
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift + barrastretta
                       Print #1, 21
                       Print #1, 10
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift + barrastretta
                       Print #1, 20
                       Print #1, 10
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift + barrastretta
                       Print #1, 21
                       Print #1, 10 + altezza
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift + barrastretta
                       Print #1, 20
                       Print #1, 10 + altezza
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift
                       Print #1, 21
                       Print #1, 10 + altezza
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift
                       Print #1, 20
                       Print #1, 10 + altezza
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift
                       Print #1, 21
                       Print #1, 10
                       Print #1, 31
                       Print #1, 0
                       
                       shift = shift + barrastretta
                       shift1 = shift1 + barrastretta1
                    ElseIf s1 = "1" Then
                       lunghezza = lunghezza + barralarga
                       Picture1.FillColor = RGB(0, 0, 0)
                       Picture1.Line (shift1, 10)-(shift1 + barralarga1, 10 + altezza1), , B
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift
                       Print #1, 20
                       Print #1, 10
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift + barralarga
                       Print #1, 21
                       Print #1, 10
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift + barralarga
                       Print #1, 20
                       Print #1, 10
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift + barralarga
                       Print #1, 21
                       Print #1, 10 + altezza
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift + barralarga
                       Print #1, 20
                       Print #1, 10 + altezza
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift
                       Print #1, 21
                       Print #1, 10 + altezza
                       Print #1, 31
                       Print #1, 0
                       
                       Print #1, 0
                       Print #1, "LINE"
                       Print #1, 8
                       Print #1, "0"
                       Print #1, 10
                       Print #1, shift
                       Print #1, 20
                       Print #1, 10 + altezza
                       Print #1, 30
                       Print #1, 0
                       Print #1, 11
                       Print #1, shift
                       Print #1, 21
                       Print #1, 10
                       Print #1, 31
                       Print #1, 0
                       
                       shift = shift + barralarga
                       shift1 = shift1 + barralarga1
                    End If
                    ' seconda barra di colore grigio
                    s1 = Mid(stringauscita2, kk, 1)
                    If s1 = "0" Then
                       lunghezza = lunghezza + barrastretta
                       Picture1.FillColor = RGB(240, 240, 240)
                       Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                       shift = shift + barrastretta
                       shift1 = shift1 + barrastretta1
                    ElseIf s1 = "1" Then
                       lunghezza = lunghezza + barralarga
                       Picture1.FillColor = RGB(240, 240, 240)
                       Picture1.Line (shift1, 10)-(shift1 + barralarga1, 10 + altezza1), , B
                       shift = shift + barralarga
                       shift1 = shift1 + barralarga1
                    End If
                Next kk
            Next i
            
            ' Stp point
            Picture1.FillColor = RGB(0, 0, 0)
            Picture1.Line (shift1, 10)-(shift1 + barralarga1, 10 + altezza1), , B
                
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barralarga
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barralarga
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barralarga
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barralarga
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
            
            shift = shift + barralarga
            shift1 = shift1 + barralarga1
            
            Picture1.FillColor = RGB(240, 240, 240)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                
            shift = shift + barrastretta
            shift1 = shift1 + barrastretta1
                                
            Picture1.FillColor = RGB(0, 0, 0)
            Picture1.Line (shift1, 10)-(shift1 + barrastretta1, 10 + altezza1), , B
                
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift + barrastretta
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift + barrastretta
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10 + altezza
            Print #1, 31
            Print #1, 0
                       
            Print #1, 0
            Print #1, "LINE"
            Print #1, 8
            Print #1, "0"
            Print #1, 10
            Print #1, shift
            Print #1, 20
            Print #1, 10 + altezza
            Print #1, 30
            Print #1, 0
            Print #1, 11
            Print #1, shift
            Print #1, 21
            Print #1, 10
            Print #1, 31
            Print #1, 0
            Print #1, 0
            Print #1, "ENDSEC"
            Print #1, 0
            Print #1, "EOF"
            Close #1
            MsgBox "FILE " + App.Path + "\" + Text1.Text + " CREATED !!!"
End Sub


Private Sub Text1_Click()
Text1.Text = ""
End Sub


