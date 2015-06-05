<!--#Include File="QuranConfig.asp"-->
<%
Dim Letters,n,Letters_HTML,Found,CurrentLetter,cClass
Letters=Split("Ç Ã È Ê Ë Ì Í Î Ï Ğ Ñ Ò Ó Ô Õ Ö Ø Ù Ú Û İ Ş ß á ã ä åÜ æ í")
Found=False
CurrentLetter=Request.QueryString("Letter")
Letters_HTML="<span ID=""buttonMenu"" align=""center"">  &nbsp;"
for n=0 to UBound(Letters)
	if Letters(n)=CurrentLetter then Found=true:cClass="button_pressed" Else cClass="button"
	'Letters_HTML=Letters_HTML & "<A style=""text-decoration:none"" href=""QuranLetters.asp?Letter=" & Letters(n) & """ >" & Letters(n) & "</A>&nbsp;" & vbCrLf
	Letters_HTML=Letters_HTML & vbcrlf &  "<A class=""" & cClass & """ style=""text-decoration:none"" href=""QuranLetters.asp?Letter=" & Letters(n) & """ >" & Letters(n) & "</A>&nbsp;" & vbCrLf  
next
Letters_HTML=Letters_HTML & "</span>"
PageTitle="ÃÈÌÏíÉ ÇáŞÑÂä ÇáßÑíã"
ShowHeader

Dim isSelected
Response.Write("<form method=get id=form1 name=form1>ÃÎÊÑ ÇáÍÑİ:<select name=Letter>")
for n=0 to UBound(Letters)
	if CurrentLetter=Letters(n) then isSelected="selected" else isSelected=""
	Response.Write("<OPTION " & isSelected  & " value=""" & Letters(n) & """>" & Letters(n) & vbCrLf)
next
Response.Write("</select>ÚÏÏ ÇáäÊÇÆÌ İí ßá ÕİÍÉ:")
for n=10 to 50 step 10
	if CStr(Request.QueryString("PS"))=CStr(n) then isSelected="checked" else isSelected=""
	Response.Write("<INPUT type=""radio"" name=ps value=" & n &" " & isSelected & ">" & n)
next
isSelected=1
if IsNumeric(Request.QueryString("P")) then isSelected=Request.QueryString("P") 
Response.Write("<input type=hidden name=p value=" & isSelected & ">")
Response.Write("<INPUT type=""checkbox"" name=countOnly value=1> áÇ ÊÚÑÖ ÇáÂíÇÊ¡ ÃÚÑÖ ÚÏÏ ÇáÂíÇÊ İŞØ. ")
Response.Write("<INPUT type=""submit"" value=""ÃÈÍË""></form>")
 
If Found Then Call Ayatet_Alpha	()
ShowFooter
%>

<%
Sub Ayatet_Alpha()
	Dim SQL,ADO,RS
	Dim cPage,Pages,PS
	Dim rsCount
	cPage=Request.QueryString("p")
	PS=Request.QueryString("ps")
	if cPage="" or not IsNumeric(cPage) then cPage=1 else cPage=CLng(cPage)
	if PS="" or not IsNumeric(PS) then PS=10 else PS=CLng(PS)
	if PS<=0 then PS=10
	if cPage<=0 then cPage=1
	if PS MOD 10 <>0 then PS=10

	SQL="Select Ayat.AyaaNo,Ayat.PageNo,Ayat.SoraaNo,Ayat.Ayaa,Sorah.soraaname From (Ayat INNER JOIN Sorah ON Ayat.soraano = Sorah.soraano)  Where (Mid([Ayat].[ayaa],1,1)='" & Mid(CurrentLetter,1,1) & "');"
	if Request.QueryString("countOnly")<>"" then
		SQL="Select count(*) From Ayat   Where (Mid([Ayat].[ayaa],1,1)='" & Mid(CurrentLetter,1,1) & "');"
	end if
	'Select * From Ayat Where (Mid([Ayat].[ayaa];1;1)='È');
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	RS.PageSize=PS
	RS.Open SQL,ADO,3
	if Request.QueryString("countOnly")<>"" then
		Response.Write("<P><B>  ÚÏÏ ÇáÂíÇÊ =" & RS(0) & "</B></P>")
		RS.Close 
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing
		exit sub
	end if
	
	Pages=RS.PageCount
	rsCount=RS.RecordCount 
	if cPage> Pages then cPage=1
	RS.AbsolutePage=cPage
 
	n=PS *(cPage-1) + 1
	Dim AyahString
	Response.Write("<A name=""" & CurrentLetter & """></A>")
	Response.Write("<OL start=" & n  &    ">ÇáÍÑİ  " & CurrentLetter)
	if RS.EOF Then Response.Write("<BR>áÇ ÊæÌÏ ÂíÇÊ ÊÈÏÃ ÈÍÑİ Çá  " & CurrentLetter)
	Do while Not RS.EOF and RS.AbsolutePage=cPage
		n=1+n
		AyahString=RS("Ayaa")
		AyahString="<LI>" & AyahString  & " [ãä ÓæÑÉ <A href='Quran.asp?page=" & RS("PageNo") & "'>" & RS("SoraaName") & "</A>" & " ÇáÂíÉ " & RS("AyaaNo") & "]</LI>"
		Response.Write(AyahString)
		Response.Flush 
		RS.MoveNext 
	loop
	Response.Write("</OL>")
	RS.Close 
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
	
	
	if Pages=1 then Exit Sub
	' Paging Navgation
	Dim pre_page,next_page
	dim fst_page,Lst_page
	Dim pre_page_html,next_page_html
	dim fst_page_html,Lst_page_html
	dim url
	dim sep
	
	fst_page =1
	pre_page=cPage-1
	next_page=cPage+1
	Lst_page=Pages
	fst_page_html  ="|<<"
	pre_page_html  ="< "
	next_page_html =" >"
	Lst_page_html  =">>|"
	sep="&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; "
	
	url="QuranLetters.asp?Letter=" & CurrentLetter & "&ps=" & PS & "&p="
	if cPage<>fst_page then  fst_page_html ="<A href=""" & url & fst_page  & """>" & fst_page_html & "</A>"
	
	if pre_page>0  then  pre_page_html  ="<A href=""" & url & pre_page  & """>" & pre_page_html  & "</A>"
	
	if next_page<=Pages  then  next_page_html ="<A href=""" & url & next_page  & """>" & next_page_html & "</A>"
	
	if Lst_page<>cPage then  Lst_page_html ="<A href=""" & url & Lst_page  & """>" & Lst_page_html & "</A>"
	Response.Write("<P align=center>")
	Response.Write(" ÚÏÏ ÇáÂíÇÊ  " & rsCount & " ¡ ÇáÕİÍÉ " & cPage & "  ãä " & Pages & " ÕİÍÉ..<BR>"  )
	Response.Write (fst_page_html &sep& pre_page_html )
	Response.Write (sep)
	Response.Write (next_page_html  & sep& Lst_page_html  )
	Response.Write("</P>")
	

End Sub
%>