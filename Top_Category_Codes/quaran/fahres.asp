<!--#Include File="QuranConfig.asp"-->
 <%
Dim SortOrder,OrderID,OrderDir
Dim TableHeaders(5),TableHeadersHTML
SortOrder=Array("soraano","soraaname","ID","PageNo","AyatCount","isMakiah")
TableHeaders(0)="—ﬁ„ «·”Ê—…"
TableHeaders(1)="√”„ «·”Ê—…"
TableHeaders(2)="«·Ã‹‹“¡"
TableHeaders(3)="—ﬁ„ «·’›Õ…"
TableHeaders(4)="⁄œœ «·¬Ì« "
TableHeaders(5)=" ’‰Ì›Â«"

OrderID=Request.QueryString("order")
OrderDir=Request.QueryString("dir")

if OrderID="" Or Not IsNumeric(OrderID) Then OrderID=0 Else OrderID=CLng(OrderID)
If OrderID>UBound(SortOrder) Or OrderID<0 then OrderID=0
If OrderDir="" Then OrderDir="ASC" 
If OrderDir<>"ASC" AND OrderDir<>"DESC" Then OrderDir="ASC"

Dim n,URL
URL="fahres.asp?"
TableHeadersHTML="<THEAD Class=""Common_THead"" ><TR>" 
for n=0 to UBound(SortOrder)
	TableHeadersHTML=TableHeadersHTML & "<TD><Div style=""cursor:hand"" title="""
		if n=OrderID then
			If OrderDir="ASC" Then
				TableHeadersHTML=TableHeadersHTML & " ⁄—÷ (" & TableHeaders(n) & ")  ‰«“·Ì« " & """" & _
				" OnClick=""JavaScript:location.href='" & URL & "order=" & n & "&dir=DESC';"">"
			Else
				TableHeadersHTML=TableHeadersHTML & " ⁄—÷ (" & TableHeaders(n) & ")   ’«⁄œÌ«" & """" & _
				" OnClick=""JavaScript:location.href='" & URL & "order=" & n & "&dir=ASC';"">"
			End if
		Else
			TableHeadersHTML=TableHeadersHTML & " ⁄—÷ (" & TableHeaders(n) & ")   ’«⁄œÌ«" & """" & _
				" OnClick=""JavaScript:location.href='" & URL & "order=" & n & "&dir=ASC';"">"
		End if
	TableHeadersHTML=TableHeadersHTML & TableHeaders(n)  & "</div></TD>"
next
TableHeadersHTML=TableHeadersHTML & "</TR></THEAD>"
PageTitle="›Â—” «·ﬁ—¬‰ «·ﬂ—Ì„"
ShowHeader

Response.Write("<TABLE cellSpacing=2 cellPadding=3 width=""80%"" border=0 align=center class=""Common_Table"" >" & TableHeadersHTML)


Dim SQL,ADO,RS 


SQL="SELECT Sorah.soraano, Sorah.soraaname, Sorah.AyatCount, Sorah.isMakiah, chapters.Chapter,chapters.ID, Sorah.PageNo " & _
	" FROM Sorah, chapters " & _
	" WHERE (((Sorah.PageNo) Between [Chapters].[StartPage] And [Chapters].[EndPage])) Order By " & SortOrder(OrderID) & " " & OrderDir & ";"
	
Set ADO=Server.CreateObject("ADODB.Connection")
Set RS=Server.CreateObject("ADODB.RecordSet")
ADO.ConnectionString =DbConnection
ADO.Open
RS.Open SQL,ADO
Dim SorahName,SorahNO,SorahCh,SorahAyat,SorahType,SorahPage
Dim cValue
Response.Write("<TBODY Class=""Common_TBODY"" >" )
do while not RS.EOF 
 

	Response.Write("<TR>")
	for n=0 to UBound(SortOrder)
		cValue=RS(SortOrder(n))
		if SortOrder(n)="isMakiah" Then
			if cValue then cValue=" „ﬂÌ¯… " Else cValue=" „œ‰Ì¯… "
		ElseIF SortOrder(n)="ID" Then
			cValue=RS("Chapter")
		ElseIF SortOrder(n)="soraaname" Then
			cValue="<A href='quran.asp?act=sorah&no=" & RS("SoraaNo") & "'>" & RS("soraaname") & "</A>"
		end if
		Response.Write("<TD>" & cValue  & "</TD>")
	next
	Response.Write("</TR>") 
	Response.Flush 
	RS.MoveNext 
loop
Response.Write("</TBODY></TABLE>" )
RS.Close 
ADO.Close

Set RS=Nothing
Set ADO=Nothing

ShowFooter
%>

