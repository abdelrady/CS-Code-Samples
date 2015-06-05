<html dir=rtl>
<head>
<meta http-equiv="Content-Language" content="ar-sa">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1256">
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<link rel="stylesheet" type="text/css" href="QuranStyle.css">
<title><%=PageTitle%></title>
<%=ExtraHeader%>
</head><body>
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse" bordercolor="#111111" width="100%" id="AutoNumber1">
  <tr>
    <td width="20%">
    <img border="0" src="images/quran-logo.jpg" width="150" height="145"></td>
    <td width="80%" valign="bottom">
    <p align="center"><img border="0" src="images/TopAaya.jpg" width="347" height="100"></p>
        <%
		dim headerLinks(8),headerLinksText(8)
		dim headerTableHTML
		Dim currentPage
		Dim LastSplash
		Const Color1="#FFFFCC"
		Const Color2="#f5deb3"
		Dim Color
		Dim Script
		currentPage=Request.ServerVariables("Script_Name")
		LastSplash=InStrRev(currentPage,"/")
		currentPage=LCase(Mid(currentPage,LastSplash+1))
		'headerLinksText= Array(8)
		'headerLinks= Array(8)
		headerLinksText(0)="عرض القرآن":headerLinks(0)="quran.asp"
		headerLinksText(1)="الفهرس":headerLinks(1)="fahres.asp"
		headerLinksText(2)="فهرس المواضيع":headerLinks(2)="QuranTopics.asp"
		headerLinksText(3)="الأجزاء":headerLinks(3)="chapters.asp"
		headerLinksText(4)="الآيات هجائيا":headerLinks(4)="QuranLetters.asp"
		headerLinksText(5)="بحث":headerLinks(5)="quranSearch.asp"
		headerLinksText(6)="استمع للقرآن":headerLinks(6)="Audio.asp"
		headerLinksText(7)="حول البرنامج":headerLinks(7)="about.asp"
		headerLinksText(8)="إدارة الموقع":headerLinks(8)="QuranAdmin.asp"
		
		headerTableHTML="<tr>"
		dim style
		style=" style=""cursor:hand;""  align=""center"" "
		for LastSplash=0 to ubound(headerLinks)
			Color=Color1
			
			Script=" onMouseOver=""this.style.backgroundColor='" & Color2 & "';"" " & _
				   " onMouseOut=""this.style.backgroundColor='" & Color1 & "';"" " 
			if lCase(headerLinks(LastSplash))=currentPage then Color=Color2:Script=""
			headerTableHTML=headerTableHTML & "<TD  bgcolor=""" & Color & """ " & _
			Script & _
			" onClick=""location.href='" & headerLinks(LastSplash) & "';"" " & _
							style & ">" & _
							"<b><font size=""2"">" & _
							headerLinksText(LastSplash) & "</font></b></td>"
			
		next
		LastSplash=LastSplash+1
		style="   align=""center"" "
		headerTableHTML=headerTableHTML & "</tr><tr><td colspan=" & LastSplash & " bgcolor=""" & Color2 & """ " & _
		style & _
		" height=""8""><img border=""0"" width=""1"" height=""1"" src=""images/pixel.gif""></td>"
    %>
    
        <table border="0" cellpadding="0" cellspacing="0" 
        style="border-collapse: collapse; border-left-width: 1" bordercolor="#008000" width="100%"  >
	<ColGroup>
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
		<Col width="11%">
	</ColGroup>
	<%=headerTableHTML%>
	</table>
 
 
    

    
    
  </tr>
  </table>
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse" bordercolor="#111111" width="100%" id="AutoNumber2">
  <tr>
    <td width="100%">
    <hr color="#007F00">
    </td>
  </tr>
</table>
  <%if IsADmin Then%>
		<table border="1" cellpadding="0" cellspacing="0" width="100%" bordercolor="#007F00" style="border-collapse: collapse">
		<ColGroup>
		<Col width="11%"><Col width="11%">
		<Col width="11%"><Col width="11%">
		<Col width="11%"><Col width="11%">
		<Col width="11%"><Col width="11%">		
		<Col width="11%"><Col width="11%">
		<Col width="11%">
		</ColGroup>
	<TR>
      <td bgcolor="#FFFFCC" style="border-left-style: none; border-left-width: medium" align="center"><b><font size="2">قائمة الأدوات :</font></b></td>
      <td  bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp"><font size="2">إحصائيات</font></A></b></td>
      <td  bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=readers"><font size="2">القراء</font></A></b></td>
      <td bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=editreader&id=0"><font size="2">قارئي جديد</font></A></b></td>
      <td  bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=sound"><font size="2">صوت القرآن</font></A></b></td>
      <td  bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=editsound&id=0"><font size="2">صوت جديد</font></A></b></td>
      <td bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=provider"><font size="2">المواقع</font></A></b></td>
      <td bgcolor="#FFFFCC" align="center"><b><A HREF="QuranAdmin.asp?act=edit_provider&id=0"><font size="2">موقع جديد</font></A></b></td>
      <td bgcolor="#FFFFCC" align="center"><b><A HREF="QuranTopicsAdmin.asp"><font size="2">مواضيع القرآن</font></A></b></td>
    </tr>
  </table>
  <%End if%>
</table> 
<br>