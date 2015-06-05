<!--#Include File="QuranConfig.asp"-->
<%'if Not isAdmin Then Response.Redirect "QuranAdminLogin.asp"%>

<%
if Request.ServerVariables("Request_Method")="POST" then HandlePostedData


Sub HandlePostedData()
	Dim Act
	Dim html
	Dim showHTML
	
	Act=LCase(Request.Form("Act"))
	showHTML= act="topic" or act="ayat" or act="delete_ayat" 	
	if  showHTML then
		html="<html dir=rtl>" & _
			"<head>" & _
			"<meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1256"">" & _
			"</head>" & _
			"<body>"
		Response.Write(html)
		ShowSubmit
	end if
		
		select case Act
		Case "topic"
			UpdateTopics 
		Case "ayat","delete_ayat"
			UpdateTopicAyat 
		case else
			Response.Write("?????????????")
		end select
	
	if showHTML then
		dim refURL
		Randomize
		refURL=Request.ServerVariables("HTTP_Referer")		
			if InStr(1,refurl,"?")=0 then
				 refURL=refURL & "?rand=" & rnd(1000)
			Else
				refURL=refURL & "&rand=" & rnd(1000)
			End if
		html="<p><center>" & _
		"<A href=""" & refURL & """> أرجع للصفحة السابقة  </A>" & _
		"</center></p>" & _
		"</body></html>"
		Response.Write(html)	
	End if	
End Sub




Sub GetTopicsJSCode()
	Dim TopicsArray
	TopicsArray=GetTopicsArray()
	Dim n,TheString
	for n=0 to UBound(TopicsArray,2)
		TheString=TheString & "Topics[" & n & "]=new Array(" & TopicsArray(0,n) & "," & TopicsArray(1,n) & ",'" & TopicsArray(2,n) & "');" & vbCrLf
	next
	TheString="var Topics=new Array();" & vbCrLf & TheString
	TheString="<SCRIPT>" & TheString & "</SCRIPT>"
	Response.Write(TheString)
End Sub

Function GetTopicAyat(TopicID)
	if TopicID=0 Or TopicID="" Or not IsNumeric(TopicID) then
		GetTopicAyat=NULL
		Exit Function
	end if
	Dim SQL,ADO,RS,AyatArray
	SQL="Select ID,Sura_NO,Ayat_NO  From Topic_Ayat Where Topic_No=" & TopicID & " Order By Sura_NO ASC;"
	AyatArray=NULL
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	Set RS=ADO.Execute(SQL)
	if Not RS.EOF Then AyatArray=RS.GetRows
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
	GetTopicAyat=AyatArray
End Function

Sub UpdateTopics()
	Dim toicID,mothorID,title
	Dim SQL
	toicID=Request.Form("toicID")
	mothorID=Request.Form("mothorID")
	title=Request.Form("title")
	if topicID="" or not IsNumeric(toicID) then toicID =0 else toicID =CLng(toicID)
	
	if topicID=0 then
		SQL="INSERT INTO Topic_Name (Mother_Topic,Topic_Name) Values (" & mothorID & ",'" & title & "');"
	Else
		SQL="Update Topic_Name Set Title='" & title & "',Mother_Topic=" & mothorID & " Where Topic_NO=" & toicID 
	End if
	
	Dim ADO
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	ADO.Execute SQL
	ADO.Close
	Set ADO=Nothing
	
	dim msg
	
	msg="<B>  تم تحديث القسم    </B>"
	if toicID=0 then msg ="<B>  تم أضافة القسم    </B>"
	Response.Write(msg)	
End Sub

Sub UpdateTopicAyat()
	Dim toicID,record_id ,sorah_name ,ayat_numbers
	Dim SQL
	Dim ADO
	dim msg
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	toicID=Request.Form("toicID")
	record_id=Request.Form("record_id")
	sorah_name=Request.Form("sorah_name")
	ayat_numbers=Request.Form("ayat_numbers")
 
	if record_id="" or not IsNumeric(record_id) then record_id =0 else record_id =CLng(record_id)
	
	if Request.Form("act")="delete_ayat" then
		if record_id >0 then
			SQL="delete From Topic_Ayat Where ID=" & record_id
			ADO.Execute SQL
			Response.Write(" تم مسح الصف من قاعدة البيانات  ")
		else
			Response.Write(" تمسح أيش؟ ")
		end if
		ADO.Close
		Set ADO=Nothing
		exit sub
	End if
	
	if record_id=0 then
		SQL="Select ID,Ayat_NO  From Topic_Ayat Where Topic_No=" & toicID  & " AND Sura_NO=" & sorah_name & ";"   ' AND ID<>" & record_id & ";"
		Response.Write(SQL & "<BR>")
		Dim RS,OldAyatNO,OldID
		OldID=0
		OldAyatNO=""
		Set RS=ado.execute(SQL)
		if Not RS.EOF Then OldID=RS(0):OldAyatNO=RS(1)
		Set RS=Nothing
		
		if OldID=0 then
			'Insert New Record			
			SQL="INSERT INTO Topic_Ayat (Topic_No,Sura_NO,Ayat_NO) Values (" & toicID & "," & sorah_name & ",'"  & ayat_numbers & "');"
			msg=" أدخال بيانات جديدة "
		else
			if OldAyatNO<>ayat_numbers   then ayat_numbers  =OldAyatNO & "," & ayat_numbers  
			SQL="UPDATE Topic_Ayat Set Ayat_NO='" & ayat_numbers  & "' Where ID=" & OldID
			msg=" تحديث البيانات الصف رقم " & OldID
		end if
	Else
		'Update Record
		SQL="UPDATE Topic_Ayat Set Ayat_NO='" & ayat_numbers & "' Where ID=" & record_id			
		msg=" تحديث البيانات الصف رقم " &  record_id 
	End if
	
	Response.Write("<BR>" & SQL & "<BR>")
	ADO.Execute SQL
	
	ADO.Close
	Set ADO=Nothing
	Response.Write(msg)	
End Sub

%>
<%
Sub ShowTopicTree()
	Dim TopicXml,TopicXSL
	Dim TopicsXMLCode
	set TopicXml =Server.CreateObject("MsXML2.DomDocument")
	set TopicXSL =Server.CreateObject("MsXML2.DomDocument")
	TopicsXMLCode="<?xml version=""1.0"" encoding=""windows-1256"" ?>" & _
				  "<topics>" & _
					GetToicXML(GetTopicsArray(),0) & _
				  "</topics>" 
	with TopicXml 
		.async=false
		.loadXML TopicsXMLCode
	end with
	
	with TopicXSL 
		.async=false
		.load Server.MapPath("TopicsTree.xsl")
	end with
	
	Response.Write(TopicXml.transformNode(TopicXSL) )
	set TopicXml =Nothing
	set TopicXSL =Nothing
End Sub

 

Function GetTopicsArray()
	Dim SQL,ADO,RS,TopicsArray
	SQL="Select Topic_No,Mother_Topic,Topic_Name From Topics_Name Order By Mother_Topic ASC;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.Open
	Set RS=ADO.Execute(SQL)
	TopicsArray=RS.GetRows
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
	GetTopicsArray=TopicsArray 
End Function


function GetToicXML(AllRows,mothor)
	Dim xmlString,i
	for i=0 to UBound(AllRows,2)
		if AllRows(1,i)= mothor then
		xmlString=xmlString & _
		 "<topic "  & _
		 "id=" & """" & AllRows(0,i) & """" & " " & _
		 "mothor=" & """" & AllRows(1,i) & """" & " " & _
		 "title=" & """" & AllRows(2,i) & """" & " >" & vbCrLf & _
		 GetToicXML(AllRows, AllRows(0,i)) & vbCrLf & _
		 "</topic>" 
		 end if
	next
	GetToicXML =xmlString
end function
%>