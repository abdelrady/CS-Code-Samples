<!--#Include File="QuranConfig.asp"-->
<%if Not isAdmin Then Response.Redirect "QuranAdminLogin.asp"%>

<%
PageTitle="€—›… «·„œÌ—"
ExtraHeader="<SCRIPT src=""Quran.js""></SCRIPT>"
ShowHeader

	Dim Act,sID,TryNO
	act=Request.QueryString("act")
	sID=Request.QueryString("ID")
	TryNO=Request.QueryString("try")
if sID="" or Not IsNumeric(sID) then sID=0 else sID=CLng(sID)
if TryNO="" or Not IsNumeric(TryNO) then TryNO=0 else TryNO=CLng(TryNO)
if Request.ServerVariables("Request_Method")="GET" Then	
	select case LCase(Act)
	case "readers"
		ViewReaders
	case "provider"
		ViewProviders 
	case "edit_provider"
		call EditProvider(sID)
	case "sound"
		call ViewAllSorahAudio()
	case "newreader"
	case "newsound"
	case "viewsound"
	call ViewReaderAudio(sID) 
	case "editreader"
	Call EditReader(sID)
	case "editsound"
	Call EditSound(sID)
		Case "deletesound"
		Response.Write(" Õ–› »Ì«‰«  „·› «·’Ê  —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranSound Where ID=" & sID))
		Case "deletereader"		
			Select Case TryNO
			Case 0 'delete Notifcation
				Response.Write (" Â·  —Ìœ „”Õ »Ì«‰«  «·„·›«  «·Œ«’… »Â–« «·ﬁ«—∆ √‰ ÊÃœ ø")
				Response.Write("<BR><A href=""QuranAdmin.asp?act=deletereader&try=1&id=" & sID & """> ‰⁄„ </A>")
				Response.Write("|<A href=""QuranAdmin.asp?act=deletereader&try=2&id=" & sID & """> ·« </A>")
			Case 1 'Delete reader with all corrsopending sound records
				Response.Write(" Õ–› »Ì«‰«  „·› «·ﬁ«—∆ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranReaders Where ID=" & sID))
				Response.Write("<BR> Õ–› „·›«  «·’Ê  «·Œ«’… »«·ﬁ«—∆ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranSound Where ReaderID=" & sID))
			Case 2'Delete Only Reader Info
				Response.Write(" Õ–› »Ì«‰«  „·› «·ﬁ«—Ï¡ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranReaders Where ID=" & sID))
			Case Else 'delete Notifcation
				Response.Write (" Â·  —Ìœ „”Õ »Ì«‰«  «·„·›«  «·Œ«’… »Â–« «·ﬁ«—∆ ≈‰ ÊÃœ ø")
				Response.Write("<BR><A href=""QuranAdmin.asp?act=deletereader&try=1&id=" & sID & """> ‰⁄„ </A>")
				Response.Write("|<A href=""QuranAdmin.asp?act=deletereader&try=2&id=" & sID & """> ·« </A>")
			End Select
		Case "delete_provider"
			Select Case TryNO
			Case 0 'delete Notifcation
				Response.Write (" Â·  —Ìœ „”Õ »Ì«‰«  «·„·›«  «·Œ«’… »Â–««·„Êﬁ⁄ ≈‰ ÊÃœ ø")
				Response.Write("<BR><A href=""QuranAdmin.asp?act=delete_provider&try=1&id=" & sID & """> ‰⁄„ </A>")
				Response.Write("|<A href=""QuranAdmin.asp?act=delete_provider&try=2&id=" & sID & """> ·« </A>")
			Case 1 'Delete reader with all corrsopending sound records
				Response.Write(" Õ–› »Ì«‰«    «·„Êﬁ⁄ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranSoundProvider Where ID=" & sID))
				Response.Write("<BR> Õ–› „·›«  «·’Ê  «·Œ«’… »«·„Êﬁ⁄ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranSound Where SourceID=" & sID))
			Case 2'Delete Only Reader Info
				Response.Write(" Õ–› »Ì«‰«   «·„Êﬁ⁄ —ﬁ„# " & sID & "<BR>«·»Ì«‰«  «·„Õ–Ê›… = " & ExecuteQuery("Delete From QuranSoundProvider Where ID=" & sID))
			Case Else 'delete Notifcation
				Response.Write (" Â·  —Ìœ „”Õ »Ì«‰«  «·„·›«  «·Œ«’… »Â–««·„Êﬁ⁄ ≈‰ ÊÃœ ø")
				Response.Write("<BR><A href=""QuranAdmin.asp?act=delete_provider&try=1&id=" & sID & """> ‰⁄„ </A>")
				Response.Write("|<A href=""QuranAdmin.asp?act=delete_provider&try=2&id=" & sID & """> ·« </A>")
			End Select
	case else
		ShowStatics
	end select
Else
	act=Lcase(Request.Form("Act"))
	Select Case act
	Case "new_reader","update_reader"
		Call UpdateReader()
	Case "new_sound","update_sound"
		Call UpdateSound()
	Case "new_site","update_site"
		Call UpdateSites()
	Case Else
		Response.Write(act)
	End Select
	  
	' Call ShowSubmit()
End if
ShowFooter


%> 

<%Sub EditReader(ID)%>
	<%
	Dim ReaderName,ReaderID,isComplete,sAct
	if Not IsNumeric(ID) Or ID="" then ID=0 Else ID=CLng(ID)
	If ID>0 then
		sAct="update_reader"
		Dim SQL,ADO,RS	
		Set ADO=Server.CreateObject("ADODB.Connection")
		Set RS=Server.CreateObject("ADODB.RecordSet")
		ADO.ConnectionString =DbConnection
		ADO.Open
		SQL="Select * From QuranReaders Where ID=" & Id & ";"
		Rs.open SQL,ADO
		If Rs.eof Then
			Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
			Response.Write(" Â–« «·ﬁ«—∆ €Ì— „ÊÃÊœ ›Ì ﬁ«⁄œ… «·»Ì«‰«   ")
			exit sub
		end if
		ReaderName=RS("Name")
		ReaderID=RS("ID")
		isComplete=RS("Complete")
		Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
	else
		sAct="new_reader"
		ReaderID=0
		ReaderName=""
	end if
	%>
<form id=reader_form name=reader_form method=POST action=QuranAdmin.asp>
	<input type="hidden" name="act" value="<%=sAct%>">
	<input type="hidden" name="readerid" value="<%=ReaderID%>">
	«”„ «·ﬁ«—∆:
	<input type="text" name="readerName" value="<%=ReaderName%>" size="20">
	<BR>
	ﬂ· «·”Ê—:
	<INPUT type="checkbox" id=checkbox1 name=Complete value="<%=isComplete%>" <%if isComplete then Response.Write("Checked")%>>
	<BR>
	<INPUT type="submit" value="Submit" id=submit1 name=submit1>
	</form>
	
	<%End Sub%>
	
	<%Sub EditSound(ID)%>
	<%
	Dim sAct
	Dim SorahNO,ReaderID,DownloadLink,PlayLink,DownloadSize
	Dim SourceID,MediaType
	if Not IsNumeric(ID) Or ID="" then ID=0 Else ID=CLng(ID)
	If ID>0 then
		sAct="update_sound"
		Dim SQL,ADO,RS	
		Set ADO=Server.CreateObject("ADODB.Connection")
		Set RS=Server.CreateObject("ADODB.RecordSet")
		ADO.ConnectionString =DbConnection
		ADO.Open
		SQL="Select * From QuranSound Where ID=" & Id & ";"
		Rs.open SQL,ADO
		If Rs.eof Then
			Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
			Response.Write(" Â–« «·„·› €Ì— „ÊÃÊœ ›Ì ﬁ«⁄œ… «·»Ì«‰«   ")
			exit sub
		end if
		
		ReaderID=RS("ReaderID")
		SorahNO=RS("SoraaNO")
		DownloadLink =RS("DownloadLink")
		PlayLink=RS("PlayLink")
		DownloadSize =RS("DownloadSize")
		SourceID =RS("SourceID")
		MediaType =RS("MediaType")
		
			Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
	else
		sAct="new_sound"
		ReaderID=0
		SorahNO=0
		DownloadLink =""
		PlayLink=""
		DownloadSize =""
		SourceID =""
		MediaType ="Real Player"
	end if
	%>
<form id=sound_form name=sound_form method=POST action=QuranAdmin.asp>
	<input type="hidden" name="act" value="<%=sAct%>">
	<input type="hidden" name="soundid" value="<%=ID%>">
	«·”Ê—…:
	<SCRIPT LANGUAGE=javascript>document.write(SoraaNamesSelectByID_Admin(<%=SorahNO%>))</SCRIPT><BR>
	«”„ «·ﬁ«—∆:<%=Replace( GetReaders(ReaderID),"onChange","onChange_") %><BR>
	
	«·„Êﬁ⁄:<%=GetProviders(SourceID) %><BR>
	⁄‰Ê«‰ «·Õ›Ÿ:<input type="text" name="downloadlink" value="<%=DownloadLink %>" size=60 maxlength=255 dir=ltr><BR>
	⁄‰Ê«‰ «· ‘€Ì·:<input type="text" name="PlayLink" value="<%=PlayLink %>" size=60 maxlength=255 dir=ltr><BR>
	ÕÃ„ «·„·›:<input type="text" name="DownloadSize" value="<%=DownloadSize %>" size="20"><BR>
	‰Ê⁄ «·„·›:
	<select name=mediaType>
	<option value="Real Audio" <%if MediaType="Real Audio" then Response.Write("Selected")%>>Real Audio</option>
	<option value="MP3" <%if MediaType="MP3" then Response.Write("Selected")%>>MP3</option>
	<option value="Win Audio" <%if MediaType="Win Audio" then Response.Write("Selected")%>>Win Audio</option>
	</select>
	<BR>
	<INPUT type="submit" value="Submit" id=submit1 name=submit1>
	</form>
 
	<%End Sub%>

<%Sub EditProvider(ID)%>
	<%
	Dim SiteName,SiteURL,SiteCommonURL,sAct
	if Not IsNumeric(ID) Or ID="" then ID=0 Else ID=CLng(ID)
	If ID>0 then
		sAct="update_site"
		Dim SQL,ADO,RS	
		Set ADO=Server.CreateObject("ADODB.Connection")
		Set RS=Server.CreateObject("ADODB.RecordSet")
		ADO.ConnectionString =DbConnection
		ADO.Open
		SQL="Select * From QuranSoundProvider Where ID=" & Id & ";"
		Rs.open SQL,ADO
		If Rs.eof Then
			Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
			Response.Write(" Â–« «·„Êﬁ⁄ €Ì— „ÊÃÊœ ›Ì ﬁ«⁄œ… «·»Ì«‰«   ")
			exit sub
		end if
		SiteName=RS("Name")
		SiteURL=RS("URL")
		SiteCommonURL=RS("CommonURL")
		Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
	else
		sAct="new_site"
		ID=0
		SiteName=""
		SiteURL=""
		SiteCommonURL=""
	end if
	%>
<form id=reader_form name=reader_form method=POST action=QuranAdmin.asp>
	<input type="hidden" name="act" value="<%=sAct%>">
	<input type="hidden" name="SiteID" value="<%=ID%>">
	«”„ «·„Êﬁ⁄:
	<input type="text" name="SiteName" value="<%=SiteName%>" size="20">
	<BR>
	⁄‰Ê«‰ «·„Êﬁ⁄:
	<input type="text" name="SiteURL" value="<%=SiteURL%>" size="20">
	<BR>
	⁄‰Ê«‰ „Ã·œ «·„·›«  «·’Ê Ì…:
	<input type="text" name="CommonURL" value="<%=SiteCommonURL %>" size="20">
	<BR>
	<INPUT type="submit" value="Submit" id=submit1 name=submit1>
	</form>
	
<%End Sub%>


<%
Sub ShowStatics
	Dim SQL,ADO,RS
	Dim QuranReadersCount,ProviderCount,SoundFilesCount
	Dim QuranTopics,QuranTopicsAyat
	SQL="Select count(*) From QuranReaders ;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	QuranReadersCount=RS(0)
	Rs.close
	
	SQL="Select count(*) From QuranSoundProvider ;"
	Rs.open SQL,ADO
	ProviderCount=RS(0)
	Rs.close
	
	SQL="Select count(*) From QuranSound ;"
	Rs.open SQL,ADO
	SoundFilesCount =RS(0)
	Rs.close

	SQL="Select count(*) From Topics_Name ;"
	Rs.open SQL,ADO
	QuranTopics  =RS(0)
	Rs.close
	
	SQL="Select count(*) From Topic_Ayat ;"
	Rs.open SQL,ADO
	QuranTopicsAyat  =RS(0)
	Rs.close
	
	ADo.close
	Set RS=Nothing
	Set ADO=Nothing 
	
	Response.Write("<TABLE border=1 >")
	Response.Write("<CAPTION> √—ﬁ«„ Ê ≈Õ’«∆Ì«  </CAPTION>")
	Response.Write("<THEAD class=""TableHeader"">")
	Response.Write("<TR>")
		Response.Write("<TD width=100> «·ÃœÊ· </TD>")
		Response.Write("<TD width=""25""> «·⁄œœ </TD>")
	Response.Write("</TR>")
	Response.Write("</THEAD>")
	Response.Write("<TBODY Class=""TableBody"">")
	Response.Write("<TR>")
		Response.Write("<TD> «·ﬁ—«¡ </TD>")
		Response.Write("<TD>" & QuranReadersCount & "</TD>")
	Response.Write("</TR>")
	
	Response.Write("<TR>")
		Response.Write("<TD> «·„Ê«ﬁ⁄ </TD>")
		Response.Write("<TD>" & ProviderCount & "</TD>")
	Response.Write("</TR>")
	
	Response.Write("<TR>")
		Response.Write("<TD> „·›«  «·’Ê  </TD>")
		Response.Write("<TD>" & SoundFilesCount  & "</TD>")
	Response.Write("</TR>")
	
	Response.Write("<TR>")
		Response.Write("<TD> «·„Ê«÷Ì⁄ </TD>")
		Response.Write("<TD>" & QuranTopics   & "</TD>")
	Response.Write("</TR>")
	
	Response.Write("<TR>")
		Response.Write("<TD> ”Ê— «·„Ê«÷Ì⁄ </TD>")
		Response.Write("<TD>" & QuranTopicsAyat   & "</TD>")
	Response.Write("</TR>")
	
	Response.Write("</TBODY>")
	Response.Write("</TABLE>")
	Response.Flush 
End Sub

Sub ViewAllSorahAudio()
	Dim SQL,ADO,RS
	Dim SorahNoList
	dim i,flag
	
	
	SQL="" & _
	"SELECT " & _
	"QuranSound.ID as RecordID, " & _
	"QuranSound.soraano, " & _
	"Sorah.SoraaName as SorahName," & _
	"QuranSound.DownloadLink, " & _
	"QuranSound.PlayLink, " & _
	"QuranSound.MediaType, " & _
	"QuranSound.DownloadSize, " & _
	"QuranReaders.Name As QuranReaderName," & _
	"QuranReaders.ID As QuranReaderID, " & _
	"QuranSoundProvider.Name AS QuranSoundProviderName, " & _
	"QuranSoundProvider.URL," & _
	"QuranSoundProvider.CommonURL As pCommonURL," & _
	"Sorah.soraaname, Sorah.PageNo " & _
	"FROM " & _
	"(" & _
	" (QuranReaders INNER JOIN QuranSound ON QuranReaders.ID = QuranSound.ReaderID) " & _
	" INNER JOIN QuranSoundProvider ON QuranSound.SourceID = QuranSoundProvider.ID) " & _
	" INNER JOIN Sorah ON QuranSound.soraano = Sorah.soraano  " 
	
	SorahNoList=Request.QueryString("SoraaNO")
	SorahNoList=Split(SorahNoList,",")
	
	flag=true
	 
	if UBound(SorahNoList)<>-1 then
		for i=0 to UBound(SorahNoList)
			if SorahNoList(i)="" Or Not IsNumeric(SorahNoList(i)) Then
				flag=false
				exit for
				 
			else
				SorahNoList(i)=CLng(SorahNoList(i))
				if SorahNoList(i)<0 Or SorahNoList(i)>114 then SorahNoList(i)=0
				 
			end if
		next
	else
		flag=false
	end if
	
	if flag then
		if SorahNoList(0)>0 then
		sql=sql & " Where QuranSound.soraano in (" & Join(SorahNoList,",")  & ") ORDER BY QuranSound.soraano;"  
		else
		sql=sql & "   ORDER BY QuranSound.soraano;"  
		end if
	else
		Response.Write("<FORM Method=GET Action=QuranAdmin.asp name=viewSound><input type=hidden name=act value=sound>")
		Response.Write("«Œ — «·”Ê—:")
		Response.Write("<" & "SCR" & "IPT" & ">" & "document.write(SoraaNamesSelectByID_admin(new Array()));" & "</" & "SCR" & "IPT" & ">")
		Response.Write("<BR><INPUT type=submit value=""«” ⁄—«÷"" id=submit2 name=submit2><INPUT type=reset value=""„”Õ"" id=reset1 name=reset1></FORM>")		 
		exit sub
	end if
 
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	
	If   Rs.eof Then 
		Response.Write("<B>  ·« ÌÊÃœ „·›«  ·Â–Â «·”Ê—…</B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		exit sub
	end if
	
	
	Response.Write("<a name=top></a><" & "SCR" & "IPT" & ">" & "document.write(SoraaNamesGetByID_admin(new Array(" & Join(SorahNoList,",")  & ")));" & "</" & "SCR" & "IPT" & ">")
	
	Response.Write("<TABLE cellSpacing=1 cellPadding=1 width=""100%"" border=1>")
	Response.Write("<TR>")
		Response.Write("<TH>«·ﬁ«—∆</TH>")
		Response.Write("<TH>‰Ê⁄ «·„·›</TH>")
		Response.Write("<TH>«” „«⁄</TH>")
		Response.Write("<TH>Õ›Ÿ</TH>")
		Response.Write("<TH>„‰ „Êﬁ⁄</TH>")
		Response.Write("<TH>-</TH>")
	Response.Write("</TR>")
	Response.Flush 
	Dim URL,AudioURL,playURL,DownloadURL
	Dim CurrentSoraaNO
	Dim iURL
	Flag=RS("SoraaNO") 
	CurrentSoraaNO=RS("SoraaNO")
		Response.Write("<TR>")
			Response.Write("<TD ColSpan=6><A name=soraa_" & Flag & ">"& RS("SorahName") & "</A></TD>")
		Response.Write("</TR>")
	
 
		do while not RS.EOF 
		if CurrentSoraaNO<>flag Then
		Response.Write("<TR>")
			Response.Write("<TD ColSpan=6><A name=soraa_" & Flag & ">"& RS("SorahName") & "</A></TD>")
		Response.Write("</TR>")
		CurrentSoraaNO=RS("SoraaNO")
		end if
		
		
			URL=RS("URL"):AudioURL=RS("pCommonURL")
			playURL=RS("PlayLink"):DownloadURL=RS("DownLoadLink")
			if AudioURL<>"" then playURL=AudioURL & playURL:DownloadURL=AudioURL & DownloadURL
			If InStr(1,URL,"http://")=0 then URL="http://" & URL
			Response.Write("<TR>")
'				Response.Write("<TD>"  & RS("SoraaNO") & "-" & RS("RecordID") & "</A></TD>")
				'Response.Write("<TD><A href=""Audio.asp?id=" & RS("QuranReaderID") & """>"  & RS("QuranReaderName")& "</A></TD>")
	Response.Write("<TD>" & Iff(Not IsNull(RS("QuranReaderName")),"<A href=""Audio.asp?id=" & RS("QuranReaderID") & """>"  & RS("QuranReaderName")& "</A>"," €/„ ") & "</TD>")
				Response.Write("<TD  align=center>" & RS("MediaType") & "</TD>")
				IF RS("MediaType")="MP3" Then
					Response.Write("<TD colspan=2  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
				Else
					Response.Write("<TD  align=center><a href=""" & playURL &  """>«” „«⁄</a></TD>")
					Response.Write("<TD  align=center><A href=""" & DownloadURL & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
				end if
'Response.Write("<TD><A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A></TD>")
Response.Write("<TD>" & iff(Not IsNull(RS("QuranSoundProviderName")), "<A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A>"," €/„ ") & "</TD>")
iURL="QuranAdmin.asp?id=" &  RS("RecordID")  & "&act="
Response.Write("<TD>")
Response.Write("<A href="""& iURL & "editsound"""  & " >  Õ—Ì—</A>")
Response.Write("|<A href="""& iURL & "deletesound"""  & ">  „”Õ</A>")
Response.Write("</TD>")
			Response.Write("</TR>")
			Response.Flush 
			rs.movenext
if Not Rs.EOF Then Flag=RS("SoraaNO")
		loop		
'	loop
	Response.Write("</Table>")
	'on error goto 0
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
	Response.Write("«Œ — «·”Ê—:")
	Response.Write("<FORM Method=GET Action=QuranAdmin.asp name=viewSound><input type=hidden name=act value=sound>")
	Response.Write("<" & "SCR" & "IPT" & ">" & "document.write(SoraaNamesSelectByID_admin(new Array(" & Join(SorahNoList,",")  & ")));" & "</" & "SCR" & "IPT" & ">")
	Response.Write("<BR><INPUT type=submit value=""«” ⁄—«÷"" id=submit2 name=submit2><INPUT type=reset value=""„”Õ"" id=reset1 name=reset1></FORM>")
	
	Response.Write("<center><A href=#top> ≈·Ï √⁄·Ï «·’›Õ…  </A></center>")
End Sub


Function GetReaders(ID)
	Dim SQL,ADO,RS
	SQL="Select * From QuranReaders ;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	If   Rs.eof Then 
		GetReaders=" ·« ÌÊÃœ ﬁ—«¡ "
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		exit function
	end if
	
	Dim OutPutString,isSelected
	OutPutString="<select id=quranReader name=quranReader ><OPTION>....</OPTION>"
	do while not RS.EOF 
		if RS(0)=ID Then isSelected="selected" Else isSelected=""
		OutPutString=OutPutString & "<OPTION " & isSelected & " value=""" & RS(0) & """>" & RS(1)  & "</Option>"
		Rs.moveNext
	loop
	OutPutString=OutPutString & "</select>"
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
	GetReaders=OutPutString
End Function

Function GetProviders(ID)
	Dim SQL,ADO,RS
	SQL="Select Id,Name From QuranSoundProvider ;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	If   Rs.eof Then 
		GetReaders=" ·«  ÊÃœ  „Ê«ﬁ⁄"
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		exit function
	end if
	
	Dim OutPutString,isSelected
	OutPutString="<select id=quranSoundProvider name=quranSoundProvider ><OPTION>....</OPTION>"
	do while not RS.EOF 
		if RS(0)=ID Then isSelected="selected" Else isSelected=""
		OutPutString=OutPutString & "<OPTION " & isSelected & " value=""" & RS(0) & """>" & RS(1)  & "</Option>"
		Rs.moveNext
	loop
	OutPutString=OutPutString & "</select>"
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
	GetProviders =OutPutString
End Function

Sub ViewReaders()
	Dim SQL,ADO,RS
	SQL="Select ID,Name From QuranReaders ;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	If   Rs.eof Then 
		Response.Write("<B>  ·« ÌÊÃœ ﬁ—«¡  </B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		exit sub
	end if
	 
	Response.Write("<TABLE width=""100%"" >")
	Response.Write("<TR>")
		Response.Write("<TH> «·ﬁ«—∆ </TH>")
		Response.Write("<TH> </TH>")
	Response.Write("</TR>")
	Dim URL
	do while not RS.EOF 
		
		URL="QuranAdmin.asp?id=" & RS(0) & "&act="
		Response.Write("<TR>")
			Response.Write("<TD>" & RS(1)& "</TD>")
			Response.Write("<TD>")
			Response.Write("<A href=""" & URL & "editreader" & """>  Õ—Ì— </A>|")
			Response.Write("<A href=""" & URL & "deletereader" & """> „”Õ </A>|")
			Response.Write("<A href=""" & URL & "viewsound" & """> ⁄—÷  </A>")
			Response.Write("</TD>")
		Response.Write("<TR>")
		Rs.moveNext
	loop
	Response.Write("</table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub
'==================

Sub ViewReaderAudio(ID)
	Dim SQL,ADO,RS
	SQL="SELECT QuranSound.ID As RecordID,QuranSound.soraano, QuranSound.DownloadLink, QuranSound.PlayLink, QuranSound.MediaType, QuranSound.DownloadSize, QuranReaders.Name As QuranReaderName, QuranSoundProvider.Name AS QuranSoundProviderName, QuranSoundProvider.URL, Sorah.soraaname, Sorah.PageNo " & _
		"FROM ((QuranReaders INNER JOIN QuranSound ON QuranReaders.ID = QuranSound.ReaderID) INNER JOIN QuranSoundProvider ON QuranSound.SourceID = QuranSoundProvider.ID) INNER JOIN Sorah ON QuranSound.soraano = Sorah.soraano  " & _
		"WHERE (QuranSound.ReaderID=" & ID & ") " & _
		"ORDER BY QuranSound.soraano;"


	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	
	If   Rs.eof Then 
		Response.Write("<B>  ·« ÌÊÃœ „·›«  ·Â–« «·ﬁ«—∆</B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		Call ViewReaders ()
		exit sub
	end if
	Response.Write("<BR><A href=""QuranAdmin.asp?act=readers""> ﬁ—«¡ «·ﬁ—¬‰ </A>: «·‘ÌŒ " )
	Response.Write(RS("QuranReaderName"))
	Response.Write("<TABLE cellSpacing=1 cellPadding=1 width=""100%"" border=1>")
	Response.Write("<TR>")
		Response.Write("<TH width=1>„</TH>")
		Response.Write("<TH>«·”Ê—…</TH>")
		Response.Write("<TH>‰Ê⁄ «·„·›</TH>")
		Response.Write("<TH>«” „«⁄</TH>")
		Response.Write("<TH>Õ›Ÿ</TH>")
		Response.Write("<TH>„‰ „Êﬁ⁄</TH>")
		Response.Write("<TH>.</TH>")
	Response.Write("</TR>")
	Response.Flush 
	Dim URL
	do while not RS.EOF 
		URL=RS("URL")
		If InStr(1,URL,"http://")=0 then URL="http://" & URL
		Response.Write("<TR>")
			Response.Write("<TD  align=center>" & RS("SoraaNO") & "</TD>")
			Response.Write("<TD>" & RS("SoraaName") & "</TD>")
			Response.Write("<TD  align=center>" & RS("MediaType") & "</TD>")
			IF RS("MediaType")="MP3" Then
				Response.Write("<TD colspan=2  align=center><A href=""" & RS("DownLoadLink") & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			Else
				Response.Write("<TD  align=center><a href=""" & RS("PlayLink") &  """>«” „«⁄</a></TD>")
				Response.Write("<TD  align=center><A href=""" & RS("DownLoadLink") & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			end if
			Response.Write("<TD><A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A></TD>")
			Response.Write("<TD><A href=""QuranAdmin.asp?Act=editsound&id=" & RS("RecordID")  & """>  Õ—Ì— </A></TD>")
		Response.Write("</TR>")
		Response.Flush 
		rs.movenext
	loop
	Response.Write("</Table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub

Sub ViewSorahAudio(ID)
	Dim SQL,ADO,RS
	SQL="SELECT QuranSound.soraano, QuranSound.DownloadLink, QuranSound.PlayLink, QuranSound.MediaType, QuranSound.DownloadSize, QuranReaders.Name As QuranReaderName,QuranReaders.ID As QuranReaderID, QuranSoundProvider.Name AS QuranSoundProviderName, QuranSoundProvider.URL, Sorah.soraaname, Sorah.PageNo " & _
		"FROM ((QuranReaders INNER JOIN QuranSound ON QuranReaders.ID = QuranSound.ReaderID) INNER JOIN QuranSoundProvider ON QuranSound.SourceID = QuranSoundProvider.ID) INNER JOIN Sorah ON QuranSound.soraano = Sorah.soraano  " & _
		"WHERE (QuranSound.soraano=" & ID & ") " & _
		"ORDER BY QuranSound.soraano;"


	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	
	If   Rs.eof Then 
		Response.Write("<B>  ·«  ÊÃœ „·›«  ·Â–Â «·”Ê—…</B> ")
		RS.Close
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing 
		Call ViewReaders ()
		exit sub
	end if
	Response.Write("<A href=""Audio.asp""> ﬁ—«¡ «·ﬁ—¬‰ </A>: ”Ê—… <a href=""quran.asp?act=sorah&no=" & RS("SoraaNO") & """>" & Rs("soraaname") & "</A>")
	
	Response.Write("<TABLE cellSpacing=1 cellPadding=1 width=""100%"" border=1>")
	Response.Write("<TR>")
		Response.Write("<TH>«·ﬁ«—∆</TH>")
		Response.Write("<TH>‰Ê⁄ «·„·›</TH>")
		Response.Write("<TH>«” „«⁄</TH>")
		Response.Write("<TH>Õ›Ÿ</TH>")
		Response.Write("<TH>„‰ „Êﬁ⁄</TH>")
		Response.Write("<TH>.</TH>")
	Response.Write("</TR>")
	Response.Flush 
	Dim URL
	do while not RS.EOF 
		URL=RS("URL")
		If InStr(1,URL,"http://")=0 then URL="http://" & URL
		Response.Write("<TR>")
			Response.Write("<TD><A href=""Audio.asp?id=" & RS("QuranReaderID") & """>"  & RS("QuranReaderName")& "</A></TD>")
			Response.Write("<TD  align=center>" & RS("MediaType") & "</TD>")
			IF RS("MediaType")="MP3" Then
				Response.Write("<TD colspan=2  align=center><A href=""" & RS("DownLoadLink") & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			Else
				Response.Write("<TD  align=center><a href=""" & RS("PlayLink") &  """>«” „«⁄</a></TD>")
				Response.Write("<TD  align=center><A href=""" & RS("DownLoadLink") & """> Õ›Ÿ </A> [" & RS("DownLoadSize") & " kb]</TD>")
			end if
			Response.Write("<TD><A href=""" & URL & """>"  & RS("QuranSoundProviderName")& "</A></TD>")
			Response.Write("<TD><A href=""" & URL & "&act=editsound" & """>  Õ—Ì— </A></TD>")
		Response.Write("</TR>")
		Response.Flush 
		rs.movenext
	loop
	Response.Write("</Table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
End Sub


Sub ViewProviders() 
		Dim SQL,ADO,RS	
		Set ADO=Server.CreateObject("ADODB.Connection")
		Set RS=Server.CreateObject("ADODB.RecordSet")
		ADO.ConnectionString =DbConnection
		ADO.Open
		SQL="Select * From QuranSoundProvider ;"
		Rs.open SQL,ADO
		If Rs.eof Then
			Rs.close
			ADO.close
			Set RS=Nothing
			Set ADO=Nothing
			Response.Write(" ·«  ÊÃœ „Ê«ﬁ⁄ ›Ì ﬁ«⁄œ… «·»Ì«‰«  ")
			exit sub
		end if
	Dim SiteName,SiteURL,SiteCommonURL,SiteID
	Response.Write("<TABLE Width=""100%"" >")
	Response.Write("<TR>")
	Response.Write("<TD>«”„ «·„Êﬁ⁄</TD>")
	Response.Write("<TD>⁄‰Ê«‰Â</TD>")
	Response.Write("<TD>„Ã·œ „·›«  «·’Ê </TD>")
	Response.Write("<TD>.</TD>")
	Response.Write("</TR>")
	do while not rs.eof
		SiteID=rs("ID")
		SiteName=RS("Name")
		SiteURL=RS("URL")
		SiteCommonURL=RS("CommonURL")
		Response.Write("<TR>")
			Response.Write("<TD>" & SiteName  & "</TD>")
			Response.Write("<TD>" & SiteURL & "</TD>")
			Response.Write("<TD>" & SiteCommonURL & "</TD>")
			Response.Write("<TD>")
			Response.Write("<A href=""QuranAdmin.asp?act=edit_provider&id=" & SiteID & """>  Õ—Ì—</A>|")
			Response.Write("<A href=""QuranAdmin.asp?act=delete_provider&id=" & SiteID & """> „”Õ</A>")
			Response.Write("</TD>")
		Response.Write("</TR>")
		Response.Flush 
		rs.movenext
	loop
Response.Write("</table>")
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
 End Sub


Sub UpdateSites()
	Dim SiteID,SiteName,SiteURL,ComURL
	Dim SQL,MSG
	SiteID=Request.Form("SiteID")
	SiteName=Request.Form("SiteName"):SiteName=Replace(SiteName,"'","''"):SiteName=Trim(Left(SiteName,50) )
	SiteURL=Request.Form("SiteURL"):SiteURL=Replace(SiteURL,"'","''"):SiteURL=Trim(Left(SiteURL,255) )
	ComURL=Request.Form("CommonURL"):ComURL=Replace(ComURL,"'","''"):ComURL=Trim(Left(ComURL,255) )
	SiteID=CLng(SiteID)
	
	if SiteName="" or SiteURL="" then
	Response.Write("  √œŒ· «”„ «·„Êﬁ⁄ Ê ⁄‰Ê«‰Â √Ê·« <BR> <A href=""javascript:history.go(-1);""> «—Ã⁄ ·≈ﬂ„«· «·»«‰«   </A>  ")
	exit sub
	end if
	
	If SiteID=0 Then
		SQL="Insert INTO QuranSoundProvider (Name,URL,CommonURL) Values " & _
		"('" & SiteName & "','" & SiteURL  & "','" & ComURL & "');"
		MSG=" Ã«—Ì ≈œŒ«· »Ì«‰«  «·„Êﬁ⁄  " 
	Else
		SQL="Update QuranSoundProvider Set Name='" & SiteName & "',URL='" & SiteURL & "',CommonURL='" & ComURL & "' Where ID=" & SiteID & ";"
		MSG ="Ã«—Ì  ÕœÌÀ »Ì«‰«  «·„Êﬁ⁄ —ﬁ„ #" & SiteID 
	End if	
	
	Response.Write(Msg & "<BR> ⁄œœ  «·»Ì«‰«  «·„ÕœÀ…  =" & ExecuteQuery(SQL))
	
End sub



Sub UpdateSound()
	Dim SoundID,SoraaNO,qReader,DwnLink,PlyLink,DwnSize,qsPro,mt
	Dim SQL,MSG
	SoundID=Request.Form("SoundID")
	SoraaNO=Request.Form("SoraaNO")
	qReader=Request.Form("quranReader")
	DwnLink =Request.Form("DownLoadLink"):DwnLink=Replace(DwnLink,"'","''"):DwnLink=Trim(Left(DwnLink,255) )
	PlyLink=Request.Form("PlayLink"):PlyLink=Replace(PlyLink,"'","''"):PlyLink=Trim(Left(PlyLink,255) )
	DwnSize =Request.Form("DownloadSize")
	qsPro=Request.Form("quranSoundProvider")
	mt=Request.Form("mediaType")
	if not IsNumeric(qsPro) or qsPro="" then qsPro=0
	if not IsNumeric(qReader) or qReader="" then qReader=0
	if not IsNumeric(SoraaNO) or SoraaNO="" then SoraaNO=1
	if not IsNumeric(DwnSize ) or DwnSize="" then DwnSize=0
	SoundID=CLng(SoundID)
	
	if DwnLink ="" and PlyLink="" then
	Response.Write("  ÌÃ» ≈œŒ«· ⁄‰Ê«‰ Ê’·… Ê«Õœ… ⁄·Ï «·√ﬁ· ... <BR> <A href=""javascript:history.go(-1);""> «—Ã⁄ ·≈ﬂ„«· «·»«‰«   </A>  ")
	exit sub
	end if
	
	If SoundID =0 Then
		SQL="Insert INTO QuranSound (soraano,ReaderID,DownLoadLink,PlayLink,MediaType,DownloadSize,SourceID) Values " & _
		"(" & SoraaNO  & "," & qReader  & ",'" & DwnLink  & "','" & PlyLink & "','" & mt & "'," & DwnSize & "," & qsPro & ");" 
		MSG=" Ã«—Ì ≈œŒ«· »Ì«‰«  «·’Ê .." 
	Else
		SQL="Update QuranSound Set soraano=" & SoraaNO & ",ReaderID=" & qReader & ",DownloadLink='" & DwnLink  & "',PlayLink='" & PlyLink & "',MediaType='" & mt & "',DownloadSize=" & DwnSize & ",SourceID=" & qsPro & " Where ID=" & SoundID  & ";"
		MSG ="Ã«—Ì  ÕœÌÀ »Ì«‰«  «·’Ê  —ﬁ„ #" & SoundID  
	End if	
	
	Response.Write(Msg & "<BR> ⁄œœ  «·»Ì«‰«  «·„ÕœÀ…  =" & ExecuteQuery(SQL))
	
End sub

Sub UpdateReader()
	Dim ReaderID,ReaderName,isComplete
	Dim SQL,MSG
	ReaderID=Request.Form("ReaderID")
	ReaderName=Request.Form("ReaderName"):ReaderName=Replace(ReaderName,"'","''"):ReaderName=Trim(left(ReaderName,50))
	isComplete=Request.Form("Complete"):isComplete=Iff(isComplete<>"",1,0)
	ReaderID=CLng(ReaderID)
	if ReaderName="" then
	Response.Write("  √œŒ· «”„ «·ﬁ«—∆ √Ê·« <BR> <A href=""javascript:history.go(-1);""> «—Ã⁄ ·≈ﬂ„«· «·»Ì«‰«   </A>  ")
	exit sub
	end if
	If ReaderID =0 Then
		SQL="Insert INTO QuranReaders (Name,Complete) Values " & _
		"('" & ReaderName   & "'," & isComplete & ");" 
		MSG=" Ã«—Ì ≈œŒ«· »Ì«‰«  «·ﬁ«—∆ .." 
	Else
		SQL="Update QuranReaders Set Name='" & ReaderName  & "',Complete=" & isComplete & " Where ID=" & ReaderID   & ";"
		MSG ="Ã«—Ì  ÕœÌÀ »Ì«‰«  «·ﬁ«—∆ —ﬁ„ #" & ReaderID  
	End if	
	
	Response.Write(Msg & "<BR> ⁄œœ  «·»Ì«‰«  «·„ÕœÀ…  =" & ExecuteQuery(SQL))
	
End sub
%>