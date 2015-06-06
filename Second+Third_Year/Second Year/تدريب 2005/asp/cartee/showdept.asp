<html>
<head>
<title>Login</title>
<meta http-equiv="Content-Type" content="text/html;charset=windows-1256"">

<head>
<title>Unauthorised Access</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
</head>

<body bgcolor="#FFFFFF" text="#000000">
<center>
 <A HREF="showDept.asp?deptId=1">TV - Video</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=2">Stereo</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=3">Kitchen Accessories</A>
</center>
<%
dptId = Request.QueryString("deptId")

arrDPT = Array("TV - Video","Stereo","Kitchen")
dptName = arrDPT(dptId - 1)

strSQL = "SELECT ID,DESC,MAN,PRICE FROM iTEMS WHERE storeID=" & dptId

dbname="\mahdy\cart.mdb"
Set conn = Server.CreateObject("ADODB.Connection")
ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;" 
ConnectionString=ConnectionString & "Data Source="  
ConnectionString=ConnectionString & Server.MapPath(dbname)
conn.ConnectionString =ConnectionString
conn.Open

set RS = Server.CreateObject("ADODB.recordset")
set RS=conn.Execute (strsql)


If rs.BOF And rs.EOF Then
%>
<H1>This departement is empty</H1>
<%
rs.Close
conn.Close
Set conn = Nothing
Set rs = Nothing
Response.End
End If
rs.MoveFirst
%>

<FORM action="addToCart.asp" method=POST name=form1>
<TABLE BORDER=2 CELLSPACING=1 CELLPADDING=1>
<TR>
<TH>Item</TH>
<TH>Quantity</TH>
</TR>
<%
Do Until rs.EOF
%>
<TR>
<TD><%=rs(1) & " " &rs(2)&"($"&rs(3)&")"%></TD>
<TD><INPUT name=txt<%=rs(0)%> value=<%=Request.Cookies("txt" & rs(0))%>></TD>
</TR>
<%
rs.MoveNext
Loop
%>

<TR>
<TD><INPUT type="submit" value="UPDATE CART" name=submit></TD>
<TD><INPUT type="reset" value="CLEAR" name=clear></TD>
</TR>
</TABLE>
<INPUT type="hidden" name= deptId value=<%=dptId%>>
</FORM>
<%
rs.Close
conn.Close
Set conn = Nothing
Set rs = Nothing
%>

<A HREF="showcart.asp">show cart</A>
</div>
</body>
</html>
