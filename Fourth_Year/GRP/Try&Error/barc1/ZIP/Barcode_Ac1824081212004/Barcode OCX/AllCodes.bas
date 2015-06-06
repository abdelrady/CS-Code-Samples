Attribute VB_Name = "AllCodes"
Option Explicit
Dim sBar As String, i0 As Integer, i1 As Integer
Public Function Code39(strCode As String)
Dim varBar1, varBar2
    varBar1 = Split("0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,-,., ,$,/,+,%,*", ",")
    varBar2 = Split("111221211,211211112,112211112,212211111,111221112,211221111,112221111,111211212,211211211,112211211,211112112,112112112,212112111,111122112,211122111,112122111,111112212,211112211,112112211,111122211,211111122,112111122,212111121,111121122,211121121,112121121,111111222,211111221,112111221,111121221,221111112,122111112,222111111,121121112,221121111,122121111,121111212,221111211,122111211,121212111,121211121,121112121,111212121,121121211", ",")
sBar = "121121211" & "1"
For i0 = 1 To Len(strCode)
    For i1 = 0 To UBound(varBar1)
        If Mid(strCode, i0, 1) = varBar1(i1) Then sBar = sBar & varBar2(i1) & "1"
    Next
Next
sBar = sBar & "121121211"
End Function
Public Function Code128(strCode As String)
Dim varBar1, varBar2
    varBar1 = Split(" <>!<>" & Chr(34) & "<>#<>$<>%<>&<>'<>(<>)<>*<>+<>,<>-<>.<>/<>0<>1<>2<>3<>4<>5<>6<>7<>8<>9<>:<>;<><<>=<>><>?<>@<>A<>B<>C<>D<>E<>F<>G<>H<>I<>J<>K<>L<>M<>N<>O<>P<>Q<>R<>S<>T<>U<>V<>W<>X<>Y<>Z<>[<>\<>]<>^<>_<>`<>a<>b<>c<>d<>e<>f<>g<>h<>i<>j<>k<>I<>m<>n<>o<>p<>q<>r<>s<>t<>u<>v<>w<>x<>y<>z<>{<>|<>}<>~<>DEL<>FNC 3<>FNC 2<>SHIFT<>CODE C<>FNC 4<>CODE A<>FNC 1<>Start A<>Start B<>Start C<>Stop", "<>")
    varBar2 = Split("212222,222122,222221,121223,121322,131222,122213,122312,132212,221213,221312,231212,112232,122132,122231,113222,123122,123221,223211,221132,221231,213212,223112,312131,311222,321122,321221,312212,322112,322211,212123,212321,232121,111323,131123,131321,112313,132113,132311,211313,231113,231311,112133,112331,132131,113123,113321,133121,313121,211331,231131,213113,213311,213131,311123,311321,331121,312113,312311,332111,314111,221411,431111,111224,111422,121124,121421,141122,141221,112214,112412,122114,122411,142112,142211,241211,221114,413111,241112,134111,111242,121142,121241,114212,124112,124211,411212,421112,421211,212141,214121,412121,111143,111341,131141,114113,114311,411113,411311,113141,114131,311141,411131,211412,211214,211232,2331112", ",")
Dim chksum As Single: chksum = 104
sBar = "211214"
For i0 = 1 To Len(strCode)
    For i1 = 0 To UBound(varBar1)
        If Mid(strCode, i0, 1) = varBar1(i1) Then
            sBar = sBar & varBar2(i1)
            chksum = chksum + (i1 * i0)
            Exit For
        End If
    Next
Next
sBar = sBar & varBar2(chksum - (Int(chksum / 103) * 103)) & "2331112"
End Function
Public Function Code25(strCode As String)
Dim tmpHold(20) As String
Dim varBar1, varBar2, varBar3, varBar4
    varBar1 = Split("1,2,3,4,5,6,7,8,9,0", ",")
    varBar2 = Split("3-1-1-1-3,1-3-1-1-3,3-3-1-1-1,1-1-3-1-3,3-1-3-1-1,1-3-3-1-1,1-1-1-3-3,3-1-1-3-1,1-3-1-3-1,1-1-3-3-1", ",")
sBar = "1111"
For i0 = 1 To Len(strCode)
    For i1 = 0 To UBound(varBar1)
        If Mid(strCode, i0, 1) = varBar1(i1) Then tmpHold(i0 - 1) = varBar2(i1)
    Next
Next
i0 = 0
Do Until i0 = Len(strCode)
    varBar3 = Split(tmpHold(i0), "-")
    varBar4 = Split(tmpHold(i0 + 1), "-")
    For i1 = 0 To 4
        sBar = sBar & varBar3(i1) & varBar4(i1)
    Next
    i0 = i0 + 2
Loop
sBar = sBar & "311"
End Function
Public Function Codabar(strCode As String)
Dim varBar1, varBar2
    varBar1 = Split("1,2,3,4,5,6,7,8,9,0,-,$,:,/,.,+,A,B,C,D", ",")
    varBar2 = Split("1111221,1112112,2211111,1121121,2111121,1211112,1211211,1221111,2112111,1111122,1112211,1122111,2111212,2121112,2121211,1121212,1122121,1212112,1112122,1112221", ",")
sBar = "1122121" & "1"
For i0 = 1 To Len(strCode)
    For i1 = 0 To UBound(varBar1)
        If Mid(strCode, i0, 1) = varBar1(i1) Then sBar = sBar & varBar2(i1) & "1"
    Next
Next
sBar = sBar & "1122121"
End Function
Public Function Barcode(CodeType As String, strCode As String, pic As Object, barscale As Integer, barHeight As Single, StartX As Single, startY As Single)
Dim barWidth As Single, i0 As Integer, barStart As Single
Select Case CodeType
    Case "39": strCode = UCase(strCode): Code39 strCode
    Case "128": Code128 strCode
    Case "2/5": strCode = IIf(Len(strCode) Mod 2 > 0, strCode & "0", strCode): Code25 strCode
    Case "Codabar": strCode = UCase(strCode): Codabar strCode
End Select
barStart = StartX
For i0 = 1 To Len(sBar)
    barWidth = Mid(sBar, i0, 1) * barscale
    If i0 Mod 2 > 0 Then pic.Line (barStart, startY)-Step(barWidth, barHeight), vbBlack, BF
    barStart = barStart + IIf(i0 Mod 2 > 0, barWidth, barWidth * 1.3)
Next
pic.FontSize = 16: pic.CurrentX = StartX: pic.CurrentY = (startY * 1.2) + barHeight: pic.Print strCode
End Function
