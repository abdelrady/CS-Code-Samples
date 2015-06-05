<!--#Include File="QuranConfig.asp"-->
<%
dim ChNO,Flag
ChNO=Request.QueryString("ChNO")
Flag=Request.QueryString("f")
if flag="all" then Flag=true else Flag=false
If ChNO<>"" And IsNumeric(ChNO) then
	ChNO=CLng(ChNO)
	if ChNO<0 OR ChNO>30 then ChNO=null
else
	ChNO=null
end if

PageTitle=" √Ã“«¡ «·ﬁ—¬‰ «·ﬂ—Ì„ "
ShowHeader
%>


<%if not Flag and IsNumeric(ChNO) then %>[<A HREF="chapters.asp">√Ã“«¡ «·ﬁ—¬‰ «·ﬂ—Ì„</A>]<%end if%>

<%if not Flag then %>[<A HREF="chapters.asp?f=all">⁄—÷ «·”Ê— ›Ì Ã„Ì⁄ «·√Ã“«¡</A>]<%end if%><%
Dim SQL,ADO,RS,AllRows
SQL="Select Chapter,StartPage,EndPage,ID From Chapters Order By ID ASC"
Set ADO=Server.CreateObject("ADODB.Connection")
Set RS=Server.CreateObject("ADODB.RecordSet")
ADO.ConnectionString =DbConnection
ADO.Open
RS.Open SQL,ADO
AllRows=RS.GetRows
RS.Close


Dim i,ii
Response.Write( "<TABLE width=""100%"">")
Response.Write("<TR>")
for i=0 to UBound(AllRows,2) step 10
		Response.Write("<TD valign=top>")
		for ii=i to i+9
			if ii<=UBound(AllRows,2) then
				Response.Write("<a href='chapters.asp?chNo=" & AllRows(3,ii ) & "'>" & AllRows(0,ii ) & "</a>&nbsp;[" & AllRows(1,ii ) & "-" &  AllRows(2,ii ) & "]<BR>" )
				
				if Flag then ChNO=CLng(AllRows(3,ii )) 
				if Not IsNull(ChNO) then
					
					if CLng(AllRows(3,ii ))=ChNO then
						SQL="SELECT DISTINCT Sorah.soraaname, Sorah.soraano " & _
						"FROM (Ayat INNER JOIN Sorah ON Ayat.soraano = Sorah.soraano) " & _
						"INNER JOIN chapters ON Ayat.chapterNO = chapters.ID " & _
						"WHERE (((chapters.ID)=$ChNO) AND ((Ayat.chapterNO)=$ChNO)) " & _
						"ORDER BY Sorah.soraano; "
						SQL=Replace(SQL,"$ChNO",ChNO)
						RS.Open SQL,ADO
						Response.Write("<UL>")
						Response.Write("<b> «·”Ê— ›Ì Â–« «·Ã“¡: </B> ")
							do while not RS.EOF
							Response.Write("<LI>")
								'Response.Write("&nbsp;&nbsp;&nbsp;<A href='sorah.asp?no=" & rs(1) & "'>" & rs(0) & "</A><br>")
								Response.Write("<A href='quran.asp?act=sorah&no=" & rs("soraano") & "'>" & rs(0) & "</A>")
							Response.Write("</LI>")
								RS.MoveNext 
							loop
						Response.Write("</UL>")
						RS.Close
					end if
					
				end if
				
			end if
		next
		Response.Write("</TD>")
next
Response.Write("</TR>")
Response.Write("</TABLE>")

ADO.Close
Set RS=Nothing
Set ADO=Nothing
%><%ShowFooter%>