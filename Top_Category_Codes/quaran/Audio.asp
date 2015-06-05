<!--#Include File="QuranConfig.asp"-->
<%

Sub ViewReaders()
	Dim SQL,ADO,RS
	SQL="Select * From QuranReaders ;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	If   Rs.eof Then 
		Response.Write("<B>  ·«ÌÊÃœ ﬁ—«¡  </B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		exit sub
	end if
	Dim isComplete
	Response.Write("<UL> ﬁ—«¡ «·ﬁ—¬‰ ")
	do while not RS.EOF 
		if RS(2)=1 Then isComplete="[„ﬂ „·]" Else isComplete=""
		Response.Write("<LI><A href=""Audio.asp?id=" & RS(0) & """>" & RS(1) & isComplete & "</A></LI>")
		Rs.moveNext
	loop
	Response.Write("</UL>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub

Sub ViewReaderAudio(ID)
	Dim SQL,ADO,RS
	SQL="SELECT QuranSound.soraano, QuranSound.DownloadLink, QuranSound.PlayLink, " & _
		"QuranSound.MediaType, QuranSound.DownloadSize, QuranReaders.Name As QuranReaderName, " & _
		"QuranSoundProvider.Name AS QuranSoundProviderName, QuranSoundProvider.URL, " & _
		"QuranSoundProvider.CommonURL As pCommonURL, Sorah.soraaname, Sorah.PageNo " & _
		"FROM ((QuranReaders INNER JOIN QuranSound ON QuranReaders.ID = QuranSound.ReaderID) " & _
		"INNER JOIN QuranSoundProvider ON QuranSound.SourceID = QuranSoundProvider.ID) " & _
		"INNER JOIN Sorah ON QuranSound.soraano = Sorah.soraano  " & _
		"WHERE (QuranSound.ReaderID=" & ID & ") " & _
		"ORDER BY QuranSound.soraano;"


	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	
	If   Rs.eof Then 
		Response.Write("<B>  ·«ÌÊÃœ „·›«  ·Â–« «·ﬁ«—∆</B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		Call ViewReaders ()
		exit sub
	end if
	Response.Write("<A href=""Audio.asp""> ﬁ—«¡ «·ﬁ—¬‰ </A>: «·‘ÌŒ " )
	Response.Write(RS("QuranReaderName"))
	Response.Write("<TABLE class=""Common_Table"" cellSpacing=3 cellPadding=2 width=""100%"" border=0>")
	Response.Write("<THEAD class=""Common_THead""><TR>")
		Response.Write("<TH width=1>„</TH>")
		Response.Write("<TH>«·”Ê—…</TH>")
		Response.Write("<TH>‰Ê⁄ «·„·›</TH>")
		Response.Write("<TH>«” „«⁄</TH>")
		Response.Write("<TH>Õ›Ÿ</TH>")
		Response.Write("<TH>„‰ „Êﬁ⁄</TH>")
	Response.Write("</TR></THEAD><TBODY class=""Common_TBODY"">")
	Response.Flush 
	Dim URL,AudioURL,playURL,DownloadURL
	do while not RS.EOF 
		URL=RS("URL")
		If InStr(1,URL,"http://")=0 then URL="http://" & URL
		AudioURL=RS("pCommonURL")
		playURL=RS("PlayLink")
		DownloadURL=RS("DownLoadLink")
		if AudioURL<>"" then playURL=AudioURL & playURL:DownloadURL=AudioURL & DownloadURL
		Response.Write("<TR>")
			Response.Write("<TD  align=center>" & RS("SoraaNO") & "</TD>")
			Response.Write("<TD>" & RS("SoraaName") & "</TD>")
			Response.Write("<TD  align=center>" & RS("MediaType") & "</TD>")
			IF RS("MediaType")="MP3" Then
				Response.Write("<TD colspan=2  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			Else
				Response.Write("<TD  align=center><a href=""" & playURL &  """>«” „«⁄</a></TD>")
				Response.Write("<TD  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			end if
			Response.Write("<TD><A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A></TD>")
		Response.Write("</TR>")
		Response.Flush 
		rs.movenext
	loop
	Response.Write("</TBODY></Table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub

Sub ViewSorahAudio(ID)
	Dim SQL,ADO,RS
	SQL="SELECT QuranSound.soraano, QuranSound.DownloadLink, QuranSound.PlayLink, "& _
		"QuranSound.MediaType, QuranSound.DownloadSize, QuranReaders.Name As QuranReaderName, " & _
		"QuranReaders.ID As QuranReaderID, QuranSoundProvider.Name AS QuranSoundProviderName, " & _
		"QuranSoundProvider.URL,QuranSoundProvider.CommonURL As pCommonURL, Sorah.soraaname, " & _
		"Sorah.PageNo " & _
		"FROM ((QuranReaders INNER JOIN QuranSound ON QuranReaders.ID = QuranSound.ReaderID) " & _
		"INNER JOIN QuranSoundProvider ON QuranSound.SourceID = QuranSoundProvider.ID) " & _
		"INNER JOIN Sorah ON QuranSound.soraano = Sorah.soraano  " & _
		"WHERE (QuranSound.soraano=" & ID & ") " & _
		"ORDER BY QuranSound.soraano;"


	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	
	If   Rs.eof Then 
		Response.Write("<B>  ·«ÌÊÃœ „·›«  ·Â–Â «·”Ê—…</B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		Call ViewReaders ()
		exit sub
	end if
	Response.Write("<A href=""Audio.asp""> ﬁ—«¡ «·ﬁ—¬‰ </A>: ”Ê—… <a href=""quran.asp?act=sorah&no=" & RS("SoraaNO") & """>" & Rs("soraaname") & "</A>")
	
	Response.Write("<TABLE class=""Common_Table"" cellSpacing=1 cellPadding=1 width=""100%"" border=1>")
	Response.Write("<THEAD class=""Common_THead""><TR>")
		Response.Write("<TH>«·ﬁ«—∆</TH>")
		Response.Write("<TH>‰Ê⁄ «·„·›</TH>")
		Response.Write("<TH>«” „«⁄</TH>")
		Response.Write("<TH>Õ›Ÿ</TH>")
		Response.Write("<TH>„‰ „Êﬁ⁄</TH>")
	Response.Write("</TR></THEAD><TBODY class=""COMMON_TBODY"">")
	Response.Flush 
	Dim URL,AudioURL,playURL,DownloadURL
	do while not RS.EOF 
		URL=RS("URL")
		AudioURL=RS("pCommonURL")
		playURL=RS("PlayLink")
		DownloadURL=RS("DownLoadLink")
		if AudioURL<>"" then playURL=AudioURL & playURL:DownloadURL=AudioURL & DownloadURL
		If InStr(1,URL,"http://")=0 then URL="http://" & URL
		Response.Write("<TR>")
			Response.Write("<TD><A href=""Audio.asp?id=" & RS("QuranReaderID") & """>"  & RS("QuranReaderName")& "</A></TD>")
			Response.Write("<TD  align=center>" & RS("MediaType") & "</TD>")
			IF RS("MediaType")="MP3" Then
				Response.Write("<TD colspan=2  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			Else
				Response.Write("<TD  align=center><a href=""" & playURL &  """>«” „«⁄</a></TD>")
				Response.Write("<TD  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			end if
			Response.Write("<TD><A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A></TD>")
		Response.Write("</TR>")
		Response.Flush 
		rs.movenext
	loop
	Response.Write("</TBODY></Table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub

'==================================
PageTitle=" ·«Ê… «·ﬁ—¬‰ «·ﬂ—Ì„"
ShowHeader

Dim rID,Act

rID=Request.QueryString("ID")
Act=Request.QueryString("act")
if lcase(act)="sorah" then
	if rID="" or not IsNumeric(rID) then
		call ViewReaders() 
	else
		call ViewSorahAudio(Clng(rID))
	end if
else
	If rID="" or not IsNumeric(rID) then Call ViewReaders() Else Call ViewReaderAudio(CLng(rID)) 
end if

ShowFooter
%>