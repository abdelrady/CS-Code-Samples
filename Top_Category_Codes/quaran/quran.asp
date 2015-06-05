<!--#Include File="QuranConfig.asp"-->
<%
Dim PageNO,Act
PageNO=Request.QueryString("page")
Act=Request.QueryString("Act")
If Act="sorah" then 
	Dim SorahNo
	SorahNo=Request.QueryString("no")
	if SorahNo<>"" and IsNumeric(SorahNo) Then
	PageNO=GetSorahStartPage(SorahNo)
	else
	PageNo=1
	end if
End if

If PageNO="" Or Not IsNumeric(PageNO) Then PageNO=1 Else PageNO=CLng(PageNO)
If PageNO<1 Or PageNO>604 Then PageNO=1


Function GetSorahStartPage(SorahID)
	Dim SQL,ADO,RS ,SorahStartPage
	SorahStartPage=1
	SQL="Select PageNo From Sorah Where SoraaNo=" & SorahID & ";"
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	Rs.open SQL,ADO
	If Not Rs.eof Then 
	SorahStartPage=RS(0)
	end if
	Rs.close
	ADO.close
	Set RS=Nothing
	Set ADO=Nothing
	GetSorahStartPage=SorahStartPage
End Function

Function GetSorahName_OLD(SorahID,ADOConnection)
	Dim SQL,tempRS,output
	SQL="Select soraaname From Sorah Where soraano=" & SorahID
	Set tempRS=ADOConnection.Execute(SQL)
	output=tempRS(0)
	Set tempRS=Nothing
	GetSorahName=output
End Function

Function GetQuranPage(PageID)
	Dim SQL,ADO,RS 
	SQL="Select * From Ayat Where PageNo=" & PageID & " Order By ID ASC;"
	'Response.Write(SQL):Exit Function
	Set ADO=Server.CreateObject("ADODB.Connection")
	Set RS=Server.CreateObject("ADODB.RecordSet")
	ADO.ConnectionString =DbConnection
	ADO.Open
	RS.CacheSize=100
	RS.Open SQL,ADO
	Dim ChNO,ChTitle,SorahNO,SorahName,FirstAyaah,TopSorahName
	Dim tempRS
	ChNO=RS("chapterNO")
	SorahNO=RS("soraano")
	
	
	'Get Sorah Name
	TopSorahName=getSorahName(SorahNO) 	'GetSorahName(SorahNo,ADO)
	
	'Get Chapter Title
	SQL="Select chapter From chapters Where ID=" & ChNO
	Set tempRS=ado.Execute(SQL)
	ChTitle=tempRS(0)
	Set tempRS=Nothing
	
	Dim OutPutString,AyahDhml,AyahDhml_Script
	
	 
	OutPutString=OutPutString & "<P dir=rtl style=""align:Justify;TEXT-ALIGN: justify"">" 
	
	do while not rs.EOF
		FirstAyaah=RS("ayaano")
		if FirstAyaah=1 Then
			'SorahName=GetSorahName(RS("soraano"),ADO)
			SorahName=getSorahName(RS("soraano"))
			OutPutString=OutPutString & "<TABLE Border=0 width=""100%"">" & _
			"<TR><TD align=center>" & SorahName 
				If PageID<>187 And PageID<>1 then OutPutString=OutPutString &"<BR><img src=""images/bismillah.gif"" border=0>"
			OutPutString=OutPutString & "</TD></TR></Table>"
		End if
		AyahDhml_Script="OnClick=""ShowAyatMenu(" & RS("soraano") & "," & RS("AyaaNo")& ",'" & SorahName & "',this.innerText);"""
		AyahDhml="<span " & AyahDhml_Script & " class=""Ayaah"" OnMouseOver=""this.className='Ayaah_Selected';"" OnMouseOut=""this.className='Ayaah';"">"
		OutPutString=OutPutString & AyahDhml & RS("Ayaa") & "</span>" & Replace(AyahNumberFormat,"$1", RS("AyaaNo")) 
		rs.MoveNext 
	loop
	
	OutPutString=OutPutString & "</P>" 
	Rs.Close
	ADO.Close
	Set RS=Nothing
	Set ADO=Nothing
	
	Dim Template_String,NavigationList,PrePage,NextPage
	Template_String=LoadTemplate("FalseAram")
	NextPage=PageID+1
	PrePage=PageID-1
	if PrePage<1 then PrePage=1
	if NextPage>604 then NextPage=1
	Dim FirstPageURL,PrevPageURL,nextPageUrl,LastPageURL,URL
	URL="Quran.asp?page="
	FirstPageURL=URL & "1"
	PrevPageURL=URL & PrePage
	nextPageUrl=URL & NextPage 
	LastPageURL=URL & "604"
	
	NavigationList=Array(FirstPageURL,PrevPageURL,nextPageUrl,LastPageURL)
	'FillTemplate(TemplateString,Chapter,SorahName,HTMLContent,Page,NavigationList)
	GetQuranPage=FillTemplate(Template_String,ChTitle,TopSorahName,OutPutString,PageID,NavigationList)
End Function
%>


<%
PageTitle="«·ﬁ—¬‰ «·ﬂ—Ì„"
ShowHeader
%>
 
</style>
<SCRIPT src="Quran.js"></SCRIPT>
<SCRIPT LANGUAGE=javascript>
<!--
var PageNO=<%=PageNO%>
var _Ayaah=""
var _AyaahNo=0
var _soraahNo=0
var _soraahName=""
var MenuEnabeld=true
 

function ShowMenu(){
	if(MenuEnabeld){
	var _x=event.x-parseInt(ToolsMenu.width )
	var _y=event.y
	ToolsMenu.style.top=_y	
	ToolsMenu.style.left=_x
	ToolsMenu.style.display=""
	}
}

function ShowAyatMenu(sorahno,ayaahno,sorahName,AyaahText){
	_Ayaah=AyaahText
	_AyaahNo=ayaahno 
	_soraahNo=sorahno
	_soraahName=sorahName
	ShowMenu()
}
function setAyaah(inputString){
	Ayaah=RemoveTashkeel(inputString)
}

function RemoveTashkeel(inputString){
	var outputString=new String(inputString)
	return(outputString.replace(/[ÛıÒˆÚ˙í¯]/g,""))
}

function DoIT(Action){}

function DoSearch(sflag)
	{
	//var url="quranSearch.asp?query="+escape(RemoveTashkeel(_Ayaah))+"&q="+sflag
	var url="quranSearch.asp?query="+escape(RemoveTashkeel(_Ayaah))+"&q="+sflag
	location.href=url
	}
	
function Audio(){
	var url="audio.asp?act=sorah&id="+_soraahNo
	location.href=url
}

function GetTafseer(tafID){
	var tafseer=new Array("GALALEEN","KATHEER","KORTOBY","TABARY")
	if(tafID>tafseer.length-1 || tafID<0){tafID=0}
	var url="http://quran.al-islam.com/Tafseer/DispTafsser.asp?l=arb&taf="+tafseer[tafID]+"&nType=1&nSora="+_soraahNo+"&nAya="+_AyaahNo
	window.open(url,"")
}
 
	function findIt() {
	var tstring=_Ayaah 
	tr=document.body.createTextRange();
	if (tr.findText(tstring)) {
      tr.select();
      tr.scrollIntoView();
      tr.execCommand("Copy")
	} 
   }  
 //-->
</SCRIPT>

<TABLE 
style="BORDER-RIGHT: 5px solid; BORDER-TOP: 5px solid; DISPLAY: none; LEFT: 60px; BORDER-LEFT: 5px solid; WIDTH: 130px; BORDER-BOTTOM: 5px solid; 
POSITION: absolute; TOP: 229px" cellSpacing=0 cellPadding=0 bgColor=#f5deb3 border=0 id=ToolsMenu width=130>
 
  <TBODY >
  <TR>
    <TD>
    <div style="MARGIN: 5px">
            <div class="menu_off" 
            onmouseover="this.className='menu_on';" 
            onmouseout="this.className='menu_off';"
            onclick="findIt();ToolsMenu.style.display='none';" >Õ›Ÿ «·¬Ì… ›Ì «·–«ﬂ—…</div>
        
        <div class="menu_off" 
        onmouseover="this.className='menu_on';" 
        onmouseout="this.className='menu_off';"
        onclick="DoSearch('all');ToolsMenu.style.display='none';" >»ÕÀ ⁄‰ ¬Ì«  „ÿ«»ﬁ…</div>
        
        <div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';"
         onclick="DoSearch('and');ToolsMenu.style.display='none';" >»ÕÀ ⁄‰ ¬Ì«  „‘«»Â… </div>
        
        <div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';"
         onclick="DoSearch('all');ToolsMenu.style.display='none';" >»ÕÀ ⁄‰ ¬Ì«  „„«À·…</div>
        
        <div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';"
         onclick="Audio();ToolsMenu.style.display='none';" 
        class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';">√” „⁄ ≈·Ï «·”Ê—… </div>
        
        <div class="menu_off"   >
	<font sie=2> ›”Ì— «·¬Ì… </font>
	<div style="margin-right:10px">
	<div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';" onclick="GetTafseer(0);ToolsMenu.style.display='none';" > ›”Ì— «·Ã·«·Ì‰</div>
	<div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';" onclick="GetTafseer(1);ToolsMenu.style.display='none';" > ›”Ì— √»‰ ﬂÀÌ—</div>
	<div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';" onclick="GetTafseer(2);ToolsMenu.style.display='none';" > ›”Ì—  «·ﬁ—ÿ»Ì</div>
	<div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';" onclick="GetTafseer(3);ToolsMenu.style.display='none';" > ›”Ì—   «·ÿ»—Ì</div>
	</div>
       </div>
        
        <div class="menu_off" onmouseover="this.className='menu_on';" onmouseout="this.className='menu_off';"
         onclick="ToolsMenu.style.display='none';" >√€·ﬁ Â–Â «·‰«›–Â </div>    
   </div>
      </TD></TR></TBODY></TABLE>

 <%=GetQuranPage(PageNO)%>

<%ShowFooter%>