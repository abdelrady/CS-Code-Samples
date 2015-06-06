VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Cls_Code39"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
'**************************************************************************************
' Module      : Cls_Code39
' Date Heure  : 22/12/2005 17:32
' Auteur      : Orignal code from Paul Bahlawan - class from Driss HANIB
' But         : classe permettant de créer un code barre du type code39

' ******* MODIFICATIONS ***************************************************************
'
'
'**************************************************************************************
Option Explicit

'*** VARIABLES ET CONSTANTES **********************************************************
'variables locales de stockage des valeurs de propriétés
Private mvarDonnéesInvalides As Boolean ' permet de savoir s'il y a eu une erreur dans la création du CB
Private mvarPictureBox As PictureBox  'nom de la picture box utilisée
Private mvarAutoSize As Boolean 'permet de déterminer si le picture doit suivre le code barre
Private mvarDécalage_Latéral As Long ' marge gauche et droite
Private mvarDécalage_Hauteur As Long 'décalage du CB avec le haut et le bas = marge haute et basse


Dim BC(43) As String  ' tableau des codes binaires

Public Property Let Décalage_Hauteur(ByVal vData As Long)
'utilisé lors de l'affectation d'une valeur à la propriété, du coté gauche de l'affectation.
'Syntax: X.Décalage_Hauteur = 5
    mvarDécalage_Hauteur = vData
End Property


Public Property Get Décalage_Hauteur() As Long
'utilisé lors de la lecture de la valeur de la propriété, du coté droit de l'instruction.
'Syntax: Debug.Print X.Décalage_Hauteur
    Set Décalage_Hauteur = mvarDécalage_Hauteur
End Property


Public Property Let Décalage_Latéral(ByVal vData As Long)
'utilisé lors de l'affectation d'une valeur à la propriété, du coté gauche de l'affectation.
'Syntax: X.Décalage_Latéral = 5
    mvarDécalage_Latéral = vData
End Property

Public Property Get Décalage_Latéral() As Long
'utilisé lors de la lecture de la valeur de la propriété, du coté droit de l'instruction.
'Syntax: Debug.Print X.Décalage_Latéral
    Set Décalage_Latéral = mvarDécalage_Latéral
End Property


Public Property Let AutoSize(ByVal vData As Boolean)
'utilisé lors de l'affectation d'une valeur à la propriété, du coté gauche de l'affectation.
'Syntax: X.AutoSize = 5
    mvarAutoSize = vData
End Property


Public Property Get AutoSize() As Boolean
' détermine si le picturebox doit s'ajuster à la largeur du code barre
AutoSize = mvarAutoSize
End Property


'*** PROPRIETES DE LA CLASSE **********************************************************


'---------------------------------------------------------------------------------------
' Property        : DonnéesInvalides
' Date            : 22/12/2005 17:38
' Auteur          : Driss HANIB
' But             : permet au prog utilisateur de savoir s'il y a eu une erreur
'
' Entrées         : Aucune
' Sorties         : oui / non
'---------------------------------------------------------------------------------------
'
Public Property Get DonnéesInvalides() As Boolean

'Syntax: Debug.Print X.DonnéesInvalides
    DonnéesInvalides = mvarDonnéesInvalides
End Property


'*** INITIALISATION DE LA CLASSE ET TERMINAISON ***************************************


Private Sub Class_Initialize()
'on réinitialise les variables
mvarDonnéesInvalides = False
mvarAutoSize = True ' par défaut on fait un autosize
'Set mvarpicturebox = Nothing
' création du tableau de codes
CB_CréeTableauCodes
End Sub

Private Sub Class_Terminate()
'on réinitialise les variables
mvarDonnéesInvalides = False
Set mvarPictureBox = Nothing
' détruit le tableau de codes
Erase BC()
End Sub


'*** PROCEDURES ET FONCTIONS **********************************************************



Sub CB_AssignePictureBox(ByVal vData As PictureBox)
Set mvarPictureBox = vData
' on fixe le scale mode en pixels
mvarPictureBox.ScaleMode = vbPixels
mvarDécalage_Latéral = 10
mvarDécalage_Hauteur = 1
End Sub



'---------------------------------------------------------------------------------------
' Sub             : CB_Création
' Date            : 22/12/2005 17:50
' Auteur          : Driss HANIB
' But             : Création du code barre dans le picture box sélectionné
'
' Entrées         : Chaine à transformer, label en clair ou non, caractère de controle ou non
' Sorties         : Aucune : création du picture box
'---------------------------------------------------------------------------------------
'
Sub CB_Création(Chaine As String, _
                Optional OptimiseImpression As Boolean = True, _
                Optional AjoutLabel As Boolean, _
                Optional CheckSomme As Boolean)

Dim X As Integer, Y As Integer, z As Integer, pos As Integer
Dim Bardata As String
Dim Cur As String
Dim CurVal As Long
Dim ChkSum As Long
Dim ChkChr As String

' variables liées au booléens
Dim L_Optimise As Long
Dim L_AjouteLabel As Long

' on met à jour les valeurs
If OptimiseImpression = True Then
    L_Optimise = 1
Else
    L_Optimise = 0
End If
If AjoutLabel = True Then
    L_AjouteLabel = 1
Else
    L_AjouteLabel = 0
End If

mvarPictureBox.Cls

If Chaine = "" Then Exit Sub
' On fixe la position du départ du graphique
pos = mvarDécalage_Latéral
'on passe la chaine en majuscule, car seuls sont définis les caractères en majuscules
Bardata = UCase(Chaine)





'Check for invalid characters and calculate check sum
For X = 1 To Len(Bardata)
    Cur = Mid$(Bardata, X, 1)
    Select Case Cur
        Case "0" To "9"
            CurVal = Val(Cur)
        Case "A" To "Z"
            CurVal = Asc(Cur) - 55
        Case "-"
            CurVal = 36
        Case "."
            CurVal = 37
        Case " "
            CurVal = 38
        Case "$"
            CurVal = 39
        Case "/"
            CurVal = 40
        Case "+"
            CurVal = 41
        Case "%"
            CurVal = 42
        Case Else 'oops!
            mvarPictureBox.Cls
            mvarPictureBox.Print Cur & " is Invalid"
            Exit Sub
    End Select
    ChkSum = ChkSum + CurVal
Next


'Add Check Character? (rarely used, but i put it here anyway...)
If CheckSomme = True Then
    ChkSum = ChkSum Mod 43
    ChkChr = Mid$("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*", ChkSum + 1, 1)
    'mvarPictureBox.Print "_" & ChkChr
    Bardata = Bardata & ChkChr
End If

'Add Label? (add it now so start & stop chrs dont show)
If AjoutLabel = True Then
    With mvarPictureBox
        .CurrentX = mvarDécalage_Latéral + 15 + Len(Bardata) * (5 + L_Optimise * 2) 'kinda center
        .CurrentY = .ScaleHeight - 12 - mvarDécalage_Hauteur
        mvarPictureBox.Print Bardata
    End With
        
End If


'Add Start & Stop characters (must have 'em for valid barcodes)
Bardata = "*" & Bardata & "*"

'Generate Barcode on trace le graphique
For X = 1 To Len(Bardata)
    Cur = Mid$(Bardata, X, 1)
    Select Case Cur
        Case "0" To "9"
            CurVal = Val(Cur)
        Case "A" To "Z"
            CurVal = Asc(Cur) - 55
        Case "-"
            CurVal = 36
        Case "."
            CurVal = 37
        Case " "
            CurVal = 38
        Case "$"
            CurVal = 39
        Case "/"
            CurVal = 40
        Case "+"
            CurVal = 41
        Case "%"
            CurVal = 42
        Case "*"
            CurVal = 43
    End Select
    
    ' on fait un  redimensionnement du picture box pour ne pas perdre des données avant nouvelle entrée
    ' resize the picture box before graphing next code
    If mvarAutoSize = True Then
        With mvarPictureBox
            .Width = (pos + 22 + mvarDécalage_Latéral) * 15
            '.Width = (25 * (Len(Bardata) + 2) + (mvarDécalage_Latéral * 2)) * 15
        End With
    End If
    
    For Y = 1 To 9
        If Y Mod 2 = 0 Then
            'SPACE
            pos = pos + 1 + (2 * Val(Mid$(BC(CurVal), Y, 1))) + L_Optimise
        Else
            'BAR
            For z = 1 To 1 + (2 * Val(Mid$(BC(CurVal), Y, 1)))
                With mvarPictureBox
                    mvarPictureBox.Line (pos, 1 + mvarDécalage_Hauteur)-(pos, .ScaleHeight - 5 - mvarDécalage_Hauteur - L_AjouteLabel * 8)
                End With
                pos = pos + 1
            Next z
        End If
    Next
    pos = pos + 1 + L_Optimise 'make inter-character gap (ie: 1 narrow space)
Next
If mvarAutoSize = True Then
    With mvarPictureBox
        '.Width = (pos + mvarDécalage_Latéral) * 15
    End With
End If
End Sub


Private Sub CB_CréeTableauCodes()

'3 of the 9 bars are wide: 0=narrow, 1=wide
    
    BC(0) = "000110100" '0
    BC(1) = "100100001" '1
    BC(2) = "001100001" '2
    BC(3) = "101100000" '3
    BC(4) = "000110001" '4
    BC(5) = "100110000" '5
    BC(6) = "001110000" '6
    BC(7) = "000100101" '7
    BC(8) = "100100100" '8
    BC(9) = "001100100" '9
    BC(10) = "100001001" 'A
    BC(11) = "001001001" 'B
    BC(12) = "101001000" 'C
    BC(13) = "000011001" 'D
    BC(14) = "100011000" 'E
    BC(15) = "001011000" 'F
    BC(16) = "000001101" 'G
    BC(17) = "100001100" 'H
    BC(18) = "001001100" 'I
    BC(19) = "000011100" 'J
    BC(20) = "100000011" 'K
    BC(21) = "001000011" 'L
    BC(22) = "101000010" 'M
    BC(23) = "000010011" 'N
    BC(24) = "100010010" 'O
    BC(25) = "001010010" 'P
    BC(26) = "000000111" 'Q
    BC(27) = "100000110" 'R
    BC(28) = "001000110" 'S
    BC(29) = "000010110" 'T
    BC(30) = "110000001" 'U
    BC(31) = "011000001" 'V
    BC(32) = "111000000" 'W
    BC(33) = "010010001" 'X
    BC(34) = "110010000" 'Y
    BC(35) = "011010000" 'Z
    BC(36) = "010000101" '-
    BC(37) = "110000100" '.
    BC(38) = "011000100" '<spc>
    BC(39) = "010101000" '$
    BC(40) = "010100010" '/
    BC(41) = "010001010" '+
    BC(42) = "000101010" '%
    BC(43) = "010010100" '*  (used for start/stop character only)

End Sub


'---------------------------------------------------------------------------------------
' Sub: CB_SauveImage
' Date            : 23/12/2005 13:48
' Auteur          : Driss HANIB
' But             : permet la sauvegarde de l'image produite sous forme de fichier bmp
'
' Entrées         : Chemin et nom du fichier à créer, picturebox
' Sorties         : Aucune
'---------------------------------------------------------------------------------------
'
Sub CB_SauveImage(CheminFichier As String) ', mvarpicturebox As PictureBox)
'on regarde d'abord si il y a un suffixe bmp
If Right$(CheminFichier, 4) <> ".bmp" Then
    CheminFichier = CheminFichier & ".bmp"
End If
SavePicture mvarPictureBox.Image, CheminFichier
End Sub


Sub CB_Copy_PressePapier() 'mvarpicturebox As PictureBox)
Clipboard.Clear
Clipboard.SetData mvarPictureBox.Image
End Sub
