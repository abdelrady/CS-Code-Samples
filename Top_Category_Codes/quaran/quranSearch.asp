<!--#Include File="QuranConfig.asp"-->
<!--#Include File="adovbs.inc"-->
<%
	Const SearchQueryLimit=90
	Dim isOK:isOK=false
	Dim SearchFor:SearchFor=Request.QueryString("Query")
	Dim SearchJoin:SearchJoin=Request.QueryString("q")
	Dim SorahNo:SorahNo=Request.QueryString("SoraaNo")
	Dim PageNo:PageNo=Request.QueryString("PageNo")
	DIm PS:PS=Request.QueryString("Ps")
	Dim NoNVaildQuery:NoNVaildQuery="[^ –÷’Àﬁ›€⁄ÂŒÕÃœÿﬂ„‰ «√·»Ì”‘∆¡ƒ—Ï¬…Ê“Ÿ≈]"
	Dim RegExpTest
	Dim Msg
PageTitle=" »ÕÀ "	

	If PageNo="" Or not IsNumeric(PageNo) Then PageNo=1 Else PageNo=CLng(PageNo)
	If PageNo<1 then PageNo=1
	If PS="" or Not IsNumeric(PS) then Ps=10 Else PS=CLng(PS)
	if PS MOD 10 <>0 Then PS=10
	if SearchFor="" and Request.QueryString.Count>0 then Msg="√ﬂ » ﬂ·„«  «·»ÕÀ"
	If Request.QueryString.Count>0 And SearchFor<>"" then
		set RegExpTest=new RegExp
		RegExpTest.IgnoreCase=true
		'RegExpTest.Multiline=false
		RegExpTest.Pattern=NoNVaildQuery
		isOK=Not RegExpTest.Test(SearchFor)
		Set RegExpTest=Nothing
		if not isOK Then Msg=" «·—Ã«¡ ≈œŒ«· ﬂ·„… √Ê ﬂ·„«  »«··€… «·⁄—»Ì… Ê »œÊ‰ √—ﬁ«„ √Ê —„Ê“ "
	End if
if Not isOk Then ExtraHeader="<SCRIPT LANGUAGE=javascript src=""quran.js""></SCRIPT>"
%>
	<%ShowHeader%>
<%If Not isOK Then%>


	<center><%=Msg%></center>
	<form id=form1 name=form1 Action="quranSearch.asp" Method="GET">
	<div align="center">
      <center>
	<TABLE cellSpacing=0 cellPadding=0 width="75%" border=1 style="border-collapse: collapse" bordercolor="#111111">
	<TR>
		<TD>«»ÕÀ ⁄‰:</TD>
		<TD><INPUT size=40 name=query></TD>
	</TR>
	<TR>
		<TD vAlign=top>
		ŒÌ«—«  «·»ÕÀ
		</TD>
		<TD>
			<INPUT type=radio value=and name=q checked>Ã„Ì⁄ «·ﬂ·„« .<BR>
			<INPUT type=radio value=or name=q>√Ì ﬂ·„….<BR>
			<INPUT type=radio value=all name=q>Ã„·… √Ê Ã“¡ „‰ ¬Ì….</LABEL>
      
		</TD>
    </TR>
	<TR>
		<TD vAlign=top>«·”Ê—:</TD>
		<TD>
			<%'=GetSorahList(5,"SoraaNo")%>
			<SCRIPT LANGUAGE=javascript>
<!--
document.write(SoraaNamesSelectByID())
//-->
            </SCRIPT>

			
		&nbsp;</TD>
	</TR>
	<TR>
		<TD vAlign=top></TD>
		<TD><INPUT type=submit value=√»ÕÀ id=submit1 name=submit1><INPUT type=reset value=„”Õ id=reset1 name=reset1></TD>
	</TR>
</TABLE>
      </center>
    </div>
</P>
</form>
<%Else%>
<A HREF="quranSearch.asp?<%=Request.QueryString%>">»ÕÀ</A> / ‰ «∆Ã «·»ÕÀ [<STRONG><%=SearchFor %></STRONG>]
<%
DoSearch
End if%>	
<%ShowFooter%>

<%Sub ShowNavForn%>
<form action="quranSearch.asp" method="GET">
	<INPUT type="hidden"  name="query" value="<%=SearchFor%>">
	<INPUT type="hidden"  name="q" value="<%=SearchJoin%>">
	<INPUT type="hidden"  name="PageNO" value="<%=PageNo %>">
	<INPUT type="hidden"  name="SoraaNo" value="<%=SorahNo%>">
	⁄œœ «·¬Ì«  ›Ì ﬂ· ’›Õ… :
	<INPUT type="radio" id=rd1 name=ps value=10 <%if PS=10 then Response.Write("checked")%> onClick="update();">
		<label for="rd1">10</label>
	<INPUT type="radio" id=rd2 name=ps value=20 <%if PS=20 then Response.Write("checked")%> onClick="update();">
		<label for="rd2">20</label>
	<INPUT type="radio" id=rd3 name=ps value=30 <%if PS=30 then Response.Write("checked")%> onClick="update();">
		<label for="rd3">30</label>
		<SCRIPT LANGUAGE=javascript>
		<!--
			function update(){
				if( event.srcElement.checked)
				{
				document.forms[0].submit()
				}
			}
		//-->
		</SCRIPT>

<%End Sub%>
<%Sub ShowMiniForm()%>
	<form id=form1 name=form1 Action="quranSearch.asp" Method="GET">
	«»ÕÀ ⁄‰:<INPUT size=40 name=query  value="<%=SearchFor%>"><INPUT type=submit value=√»ÕÀ id=submit1 name=submit1>
	<INPUT type="hidden"  name="q" value="<%=SearchJoin%>" >
	<INPUT type="hidden"  name="PageNO" value="<%=PageNo %>">
	<INPUT type="hidden"  name="SoraaNo" value="<%=SorahNo%>">
	</form>
<%End Sub%>

<%
Sub DoSearch
	Dim SQL,ADO,RS
	Dim SearchTerms
	Dim SQL_Where_Cluse
	Dim n:n=0
	SQL_Where_Cluse=""
	
	If SearchJoin<>"and" and SearchJoin<>"or" and SearchJoin<>"all" then SearchJoin="and"
	
	If SearchJoin="and" or SearchJoin="or" Then
		SearchTerms=Split(SearchFor)
		for n=0 to UBound(SearchTerms)
			If SearchJoin="and" Then
				if SQL_Where_Cluse="" Then
					SQL_Where_Cluse="(AyaaIndex LIKE '%" & SearchTerms(n) & "%')"
				Else
					SQL_Where_Cluse=SQL_Where_Cluse & " AND (AyaaIndex LIKE '%" & SearchTerms(n) & "%')"
				End if
			Else
				if SQL_Where_Cluse="" Then
					SQL_Where_Cluse="(AyaaIndex LIKE '%" & SearchTerms(n) & "%')"
				Else
					SQL_Where_Cluse=SQL_Where_Cluse & " OR (AyaaIndex LIKE '%" & SearchTerms(n) & "%')"
				End if
			End if
		Next 
	
	Else
		SQL_Where_Cluse="(AyaaIndex LIKE '%" & SearchFor & "%')"
	End if	
	
	
	Dim SQL_Where_Cluse2
	If SorahNo<>"" Then
		SQL_Where_Cluse2=""
		SorahNo=Split(SorahNo,",")
		for n=0 to UBound(SorahNo)
			if SorahNo(n)="" or not IsNumeric(SorahNo(n)) Then SorahNo(n)=0 Else SorahNo(n)=CLng(SorahNo(n))
			if SorahNo(n)<0 Then SorahNo(n)=0
		next
		SorahNo=Join(SorahNo,",")
		SQL_Where_Cluse2= " Ayat.SoraaNO in (" & SorahNo & ")"
	End if
	SQL_Where_Cluse="(" & SQL_Where_Cluse & ")"
	if SQL_Where_Cluse2<>"" then SQL_Where_Cluse=SQL_Where_Cluse & " AND (" & SQL_Where_Cluse2 & ")"
	'SQL="Select TOP 10 Ayaa From Ayat Where " & SQL_Where_Cluse & ";"
	SQL="Select Ayat.Ayaa,Ayat.ayaano,Ayat.pageno,Ayat.soraano,Sorah.soraaname From (Ayat INNER JOIN Sorah ON Ayat.soraano = Sorah.soraano)  Where " & SQL_Where_Cluse & " Order By Ayat.pageno,Ayat.ayaano ASC;"
	'Response.Write(SQL)
	'Response.End 
	ShowMiniForm
	
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	RS.CursorLocation=adUseClient 
	RS.PageSize=PS
	'RS.CacheSize=100
	RS.Open SQL,ADO,adOpenStatic,adLockReadOnly
	if PageNo>RS.PageCount then PageNo=RS.PageCount
	if not RS.EOF then  RS.AbsolutePage=PageNo
	IF RS.EOF then
		Response.Write ("  <B> ·« ÌÊÃœ ‰ «∆Ã </B>  ")
	End if
	
	Dim StartCounter
	if PageNo=1 Then StartCounter=1 Else StartCounter=RS.PageSize * (PageNo-1)
	
	Response.Write("<OL start=" & StartCounter &"> ⁄œœ «·¬Ì« :" & RS.RecordCount  )
	Do While Not RS.EOF AND RS.AbsolutePage =PageNo 
		Response.Write("<LI><span class=""Ayaah"">" & RS(0) & "</span> [<A href='quran.asp?page=" & RS("PageNO") & "'>" & RS("SoraaName") & "</A> «·¬Ì… " & RS("AyaaNo") & "]</LI>")
		Response.Flush 
		RS.MoveNext 
	loop
	Response.Write("</OL>")
	Dim URL,m
	URL="quranSearch.asp?query=" & SearchFor & "&q=" & SearchJoin &"&SoraaNo=" & Request.QueryString("SoraaNo") & "&ps=" & PS
	Response.Write(" ⁄œœ «·’›Õ« : " & RS.PageCount & "<BR>")
	if RS.PageCount >1 Then
		m=0	
		if PageNO>1 then
		Response.Write ("<A href='" & URL & "&PageNO=" & PageNO-1 & "'> &lt;&lt;«·’›Õ… «·”«»ﬁ…</A> ")
		end if
		if PageNO+10 < RS.PageCount And PageNo-10>0 then StartCounter=PageNo-10
		For n=StartCounter to RS.PageCount 
				IF N<>PageNo Then
					Response.Write ("<A href='" & URL & "&PageNO=" & n & "'>" & N & "</A> ")
				else
					Response.Write(n & " ")
				end if	
			m=m+1
			if m>10 then exit for
		next
		if PageNo+1<= RS.PageCount Then _
			Response.Write ("<A href='" & URL & "&PageNO=" & PageNo+1 & "'>«·’›Õ… «· «·Ì… &gt;&gt;</A> ")
	End if
	if RS.PageCount>1 then ShowNavForn
	RS.Close 
	'Response.Write("<p dir=ltr>" & SQL & "</p>")
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
End Sub
%>