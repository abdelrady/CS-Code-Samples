<!--#Include File="QuranConfig.asp"-->


<%
Dim MainTopicID
Dim TopicsArray
Const Max_Topic_Listing=3
Const Path_Seprator="<font size=""2"" face=""Wingdings 3""><B>Ö</B></font>"
Const Topic_Heading_Dot ="<font size=""4"" color=""royalblue"" face=""Marlett"">2</font> "
'">"'"&gt;"
MainTopicID=Request.QueryString("ID")
if MainTopicID="" OR Not IsNumeric(MainTopicID) Then MainTopicID=0 Else MainTopicID=CLng(MainTopicID)
PageTitle=" ›Â—” „Ê«÷Ì⁄ «·ﬁ—¡«‰ «·ﬂ—Ì„"
Call GetAllTopics()
ShowHeader
Response.Write("<b><FONT class=TopicPath face=""Simplified Arabic"" size=3>" & GetTopicPath(MainTopicID,0) & "</FONT></B>")
	Call ShowTopics(MainTopicID)
	Call ShowTopicsAyat(MainTopicID)
ShowFooter
%>

<%
Sub GetAllTopics()
	Dim SQL,ADO,RS
	SQL="Select Topic_No,Mother_Topic,Topic_Name From Topics_Name Order By Mother_Topic ASC;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	Set RS=ADO.Execute(SQL)
	TopicsArray=RS.GetRows
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
End Sub



Function GetSubTopics(TopicID)
	Dim TheString,n,SubTopic_counter
	SubTopic_counter=1
	for n=0 to UBound(TopicsArray,2)
		if SubTopic_counter<= Max_Topic_Listing then
			if CLng(TopicsArray(1,n))=CLng(TopicID) then
				TheString=TheString & "<a Class=SubTopicHeading href=""QuranTopics.asp?id=" & TopicsArray(0,n) & """>" & TopicsArray(2,n) & "</A>, "
				SubTopic_counter=SubTopic_counter+1
			end if
		else
'			TheString=TheString & "<a href=""QuranTopics.asp?id=" & TopicID  & """> «·„“Ìœ </A>"
			TheString=TheString & "<a Class=SubTopicHeading title=""«·„“Ìœ"" href=""QuranTopics.asp?id=" & TopicID  & """> .... </A>"
			exit for
		end if
	next
	
	if Right(theString,2)=", " then theString=Left(theString,Len(theString)-2)
	if SubTopic_counter=1 then 
		TheString=""
	else
		TheString="<BR><FONT>&nbsp;&nbsp;&nbsp;" & TheString & "</FONT>"
	end if
	
	
	GetSubTopics=TheString
End Function

Function GetTopicPath(TopicID,RoundNo)
	dim theString,n
	if TopicID=0 then
		
		if RoundNo>0 then
			GetTopicPath="<A href=""QuranTopics.asp?ID=0"">«·›Â—”</A>" & Path_Seprator
		else
			GetTopicPath="«·›Â—”" & Path_Seprator
		end if
		
		exit function
	end if
	
	for n=0 to UBound(TopicsArray,2)
		if CLng(TopicsArray(0,n))=CLng(TopicID) then
			theString=theString & GetTopicPath(TopicsArray(1,n),RoundNo+1)& "<A href=""QuranTopics.asp?ID=" & TopicsArray(0,n) & """>" &  TopicsArray(2,n)  & "</A>"& Path_Seprator
		end if
	next
	
	GetTopicPath=theString
End Function

Sub ShowTopicsAyat(TopicID)
	dim n, m,i 'integers
	Dim TopicAyatArray
	dim AyatWhereCluseArray,AyatWhereCluseString
	Dim AyatRange
	Dim Ayat_Result_Array
	Dim sID:sID=0
	Dim ayID:ayID=0
	Dim index:index=0
	Dim outputString
	Dim AyatCounter:AyatCounter=0
	Dim SorahCounter:SorahCounter=0
	for n=0 to UBound(TopicsArray,2)
		if CLng(TopicsArray(1,n))=TopicID then exit sub
		' if this topic has inner topics exit and don't show any ayah...
	next
	
	Dim SQL,ADO,RS
	
	SQL="Select Topic_No,Sura_No,Ayat_No From Topic_Ayat Where Topic_No=" & TopicID  &  " Order By Sura_No ASC;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	Set RS=ADO.Execute(SQL)
	
	if Rs.EOF Then
		ADO.Close
		Set RS=Nothing
		Set ADO=Nothing
		Response.Write("<h3>" & " ·«ÌÊÃœ ¬Ì«  ·Â–« «·„Ê÷Ê⁄ " & "</h3>")
		exit sub
	End if
	
	
	TopicAyatArray=RS.GetRows
	Set RS=Nothing
	


		For n=0 to UBound(TopicAyatArray,2)
			' this code will take care of ayat range 
			' example 123-127
			AyatWhereCluseArray=split(TopicAyatArray(2,n),",")
			AyatWhereCluseString=""
			for m=0 to UBound(AyatWhereCluseArray)
				if InStr(1,AyatWhereCluseArray(m),"-")=0 then
					if AyatWhereCluseString<>"" then
						AyatWhereCluseString=AyatWhereCluseString & "," & AyatWhereCluseArray(m)
					Else
						AyatWhereCluseString=AyatWhereCluseArray(m)
					End if
				else
					
					AyatRange=Split(AyatWhereCluseArray(m),"-")
					for i=CLng(AyatRange(0)) to CLng(AyatRange(1))
						if AyatWhereCluseString<>"" then
							AyatWhereCluseString=AyatWhereCluseString & "," & Cstr(i)
						Else
							AyatWhereCluseString= Cstr(i)
						End if
					Next
				end if
			next			
			
			SQL="Select Ayat.soraano,Ayat.ayaano,Sorah.soraaname,Ayat.pageno,Ayat.ayaa from " & _
			" Ayat INNER JOIN Sorah ON Ayat.soraano = Sorah.soraano Where Ayat.soraano=" & TopicAyatArray(1,n) & _
			" AND Ayat.ayaano in (" & AyatWhereCluseString & ") " & _
			" Order By Sorah.soraano,Ayat.ayaano ASC;"
				
			
			Set RS=ADO.Execute(SQL)
			Ayat_Result_Array=RS.GetRows
			Set RS=Nothing
	'Ayat.soraano=0
	'Ayat.ayaano=1
	'Sorah.soraaname=2
	'Ayat.pageno=3
	'Ayat.ayaa=4
			for m=0 to UBound(Ayat_Result_Array,2)
				Ayat_Result_Array(1,m)=CLng(Ayat_Result_Array(1,m))
				if ayID=0 then ayID=ayID=Ayat_Result_Array(1,m)
				outputString=""
				if sID<>Ayat_Result_Array(0,m) Then 
					outputString="<h2 align=center>" & Ayat_Result_Array(2,m)  & "</h2><p>"
					ayID=0
					SorahCounter=SorahCounter+1
				END IF
				index=m+1
				outputString=outputString &  "<span class=""ayaah"">" &Ayat_Result_Array(4,m) & "</span> (" &  Ayat_Result_Array(1,m) & ") " 
				if index<=UBound(Ayat_Result_Array,2) Then
					if Clng(Ayat_Result_Array(1,index))-Clng(Ayat_Result_Array(1,m))<>1 Then 
						outputString=outputString &  "<BR>"
					Else
						outputString=outputString &  " "
					End if
				Else
					outputString=outputString &  "</p>"
				End if
 
				sID=Ayat_Result_Array(0,m)
				ayID=Ayat_Result_Array(1,m)
				Response.Write(outputString)
				AyatCounter=AyatCounter+1
			Next
			'Response.Write(outputString)
		next 
		outputString =AyatCounter & " ¬Ì…  „Ê“⁄… ⁄·Ï" & SorahCounter & " ”Ê—… ... "
		outputString="<P><B>" & outputString & "</B></P>"
		Response.Write(outputString)
	ADO.Close
	Set ADO=Nothing
End Sub

 
%>
 
<%

Sub ShowTopics(TopicID)
	Dim TopicDic,MothorTopicDic
	dim Topics,CurrentTopic
	Dim n
	set TopicDic=Server.CreateObject("Scripting.Dictionary")
	set MothorTopicDic=Server.CreateObject("Scripting.Dictionary")
	
	for n=0 to UBound(TopicsArray,2)
		TopicDic.Add TopicsArray(0,n),TopicsArray(2,n)
		'TopicID	=====	TopicName
		if MothorTopicDic.Exists(TopicsArray(1,n)) Then
			'MothorTopicDic(TopicsArray(0,n))=MothorTopicDic(TopicsArray(0,n)) & "," & TopicsArray(1,n)
			if MothorTopicDic(TopicsArray(1,n))="" then
				MothorTopicDic(TopicsArray(1,n))=TopicsArray(0,n)
			else
				MothorTopicDic(TopicsArray(1,n))=MothorTopicDic(TopicsArray(1,n)) & "," & TopicsArray(0,n)
			end if
		else
			MothorTopicDic.Add TopicsArray(1,n),TopicsArray(0,n)
		end if
	next
	
	
	Response.Write("<TABLE width=""80%"" align=""center"" cellpadding=""5"" cellspacing=""5"" border=""0"" >")
	Response.Write("<CAPTION Class=""QuranTopics_Label"">")
	if TopicDic.Exists(TopicID) Then
		Response.Write(TopicDic(TopicID))
	else 
			Response.Write("  œ·Ì· „Ê«÷Ì⁄ «·ﬁ—¬‰ «·ﬂ—Ì„  ")
	end if
	
	Response.Write("</CAPTION>")
	Response.Write("<COLGROUP><COL Width=""50%""><COL Width=""50%""></COLGROUP>")
	
	if MothorTopicDic.Exists(TopicID) Then
		
		Topics=Split(MothorTopicDic(TopicID),",")
		
		
			for n=0 to UBound(Topics) Step 2
				CurrentTopic=clng(Topics(n))
				Response.Write("<TR>")
			
				if TopicDic.Exists(CurrentTopic)  then
					Response.Write("<TD vAlign=""TOP"">" & Topic_Heading_Dot &  "<B><A  Class=""MainTopicHeading"" href=""QuranTopics.asp?id=" & CurrentTopic & """>" & TopicDic(CurrentTopic) & "</A></B>" & GetSubTopics(CurrentTopic) & "</TD>")
				else
					Response.Write("<TD>&nbsp;</TD>")
				end if
				
				if n+1<=UBound(Topics) then
				CurrentTopic=clng(Topics(1+n))
					if TopicDic.Exists(CurrentTopic)  then
						Response.Write("<TD vAlign=""TOP"">" & Topic_Heading_Dot & "<B><A  Class=""MainTopicHeading"" href=""QuranTopics.asp?id=" & CurrentTopic & """>" & TopicDic(CurrentTopic) & "</A></B>" & GetSubTopics(CurrentTopic) & "</TD>")
					else
						Response.Write("<TD>&nbsp;</TD>")
					end if				
				else
					Response.Write("<TD>&nbsp;</TD>")
				end if
				Response.Write("</TR>")
			next
	end if
	 Response.Write("</TABLE>")
	set TopicDic=Nothing
	set MothorTopicDic=Nothing
End Sub
%>