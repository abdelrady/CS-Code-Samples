<%@ Language=VBScript CodePage=1256%>
<%
Option Explicit
Response.buffer=true
%>
<!--#Include File="SorahInfo.asp"-->
<%
Const LoginID="Alnoor-World.com"
Const LoginPws="Quran"

 
Const AyahNumberFormat="<Font Face=""AGA Arabesque"" Color=""Blue"">)<font face=""Tahoma"" color=""red"">$1</font>(</Font> "
Const TashKelFormat="<Font class=""Tashkel"" Color=""blue"">$1</Font>"
Const TashKel="ÛıÒëˆÚ¯˙"
Const MainTemplate="template.htm"
Dim DbConnection
Dim PageTitle,ExtraHeader
Dim isAdmin:isAdmin=Session("QuranAdmin")
DbConnection="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Server.MapPath("Database\quran.mdb")

Function DoTashelat(Ayat)
	Dim regEx
	Dim StrText
	StrText=Ayat
	Set regEx = New RegExp
	regEx.Global = true
	regEx.IgnoreCase = True
	regEx.Pattern="([" & TashKel & "])"
	StrText=regEx.Replace (StrText,TashKelFormat)
	set regEx=Nothing
	DoTashelat=StrText
End Function


Function DoNumbering(Ayat)
	Dim regEx
	Dim StrText
	StrText=Ayat
	Set regEx = New RegExp
	regEx.Global = true
	regEx.IgnoreCase = True
	regEx.Pattern="([1-9][0-9]*)"
	StrText=regEx.Replace (StrText,AyahNumberFormat)
	set regEx=Nothing
	DoNumbering=StrText
End Function


Function DoFormating(Ayat)
	DoFormating=DoTashelat(DoNumbering(Ayat))
End Function

Function GetAyat(SorahNo,AyahNo,PageSize)
	DoFormating=DoTashelat(DoNumbering(Ayat))
End Function

Function LoadTemplate(TemplateID)
	Dim FSO,TemplateFolderPath,FileObj
	Set FSO=Server.CreateObject("Scripting.FileSystemObject")
	TemplateFolderPath="templates"
	TemplateFolderPath=Server.MapPath(TemplateFolderPath)
	If Not FSO.FileExists (TemplateFolderPath &"\" &TemplateID) Then TemplateID=TemplateFolderPath &"\" & MainTemplate	
	Dim TheString,TheString2
	Set FileObj=FSO.OpenTextFile(TemplateID,1)
	TheString=FileObj.readAll()
	FileObj.close
	Set FileObj=Nothing
	Set FSO=Nothing
	Dim p1
	
	p1=InStr(1,theString ,"[template]",1)
	TheString2=Mid(TheString,p1+11)
	
	p1=InStr(1,TheString2 ,"[/template]")
	TheString2=Mid(TheString2,1,p1-1)
	
	LoadTemplate=TheString2
End Function

Function FillTemplate(TemplateString,Chapter,SorahName,HTMLContent,Page,NavigationList)
	Dim OutPut
		'#chapter#
		'#SoraName#
		'#Content#
		'#Page#
		'#FirstPage#
		'#PrePage#
		'#NextPage#
		'#LastPage#
		
	OutPut=TemplateString
	OutPut=Replace(OutPut,"#chapter#",Chapter)
	OutPut=Replace(OutPut,"#SoraName#",SorahName)
	OutPut=Replace(OutPut,"#Content#",HTMLContent )
	OutPut=Replace(OutPut,"#Page#",Page)
	OutPut=Replace(OutPut,"#FirstPage#",NavigationList(0))
	OutPut=Replace(OutPut,"#PrePage#",NavigationList(1))
	OutPut=Replace(OutPut,"#NextPage#",NavigationList(2))
	OutPut=Replace(OutPut,"#LastPage#",NavigationList(3))
	FillTemplate=OutPut
End Function

Function GetSorahList(lSize,BoundCol)
	Dim SQL,ADO,RS,OutPut
	SQL="Select SoraaName," & BoundCol &  " From Sorah Order By SoraaNo;"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	RS.Open SQL,ADO
	If lSize>1 Then
		OutPut="<SELECT size=" & lSize & " name=" & BoundCol & " multiple><OPTION>Ã„Ì⁄ «·”Ê—</OPTION>"
	Else 
		OutPut="<SELECT size=" & lSize &  " name=" & BoundCol & "><OPTION>«Œ — «·”Ê—…</OPTION>" 
	End if
	do while not rs.eof
		OutPut=OutPut & "<OPTION value=" & RS(1) & ">" & RS(0) & "</OPTION>"
		rs.movenext
	loop
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
	OutPut=OutPut & "</SELECT>"
	GetSorahList=OutPut
End Function

%>

<%Sub ShowHeader%><!--#Include File="quran_hearder.inc"--><%End Sub%>

<%Sub ShowFooter%><!--#Include File="quran_Footer.inc"--><%End Sub%>


<SCRIPT LANGUAGE=vbscript RUNAT=Server>
Function Iff(Expression,TrueValue,FalseValue)
	if Expression then iff=TrueValue else Iff=FalseValue
End Function

Function ExecuteQuery(SQL)
	Dim RecAff
	Dim ADO
	Set ADO=Server.CreateObject("ADODB.Connection")
	ADO.ConnectionString=DbConnection
	ADO.open
	ADo.execute SQL,RecAff
	ADO.close
	Set Ado=Nothing
	ExecuteQuery=RecAff 
End Function

Sub ShowSubmit()
	Dim Obj
	Response.Write("<P dir=ltr>")
	If Request.ServerVariables("Request_Method")="POST" Then
		For Each Obj in Request.Form
			Response.Write(Obj & "=" & Request.Form(Obj) & "<BR>")
		Next
	Else
		For Each Obj in Request.QueryString 
			Response.Write(Obj & "=" & Request.QueryString(Obj) & "<BR>")
		Next
	End if
	Response.Write("</P>")
End Sub
</SCRIPT>