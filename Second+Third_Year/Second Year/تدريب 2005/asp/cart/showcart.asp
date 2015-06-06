<%@ Language=VBScript %>
<HTML>
<HEAD>
</HEAD>
<BODY>
<center>
 <A HREF="showDept.asp?deptId=1">TV - Video</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=2">Stereo</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=3">Kitchen Accessories</A>
</center>
<%
strSQL = "SELECT * FROM ITEMS WHERE ID IN("
For Each item In Request.Cookies
If Left(item,3) = "txt" Then
itemId = Mid(item,4)
strSQL = strSQL & itemId & ","
End If
Next
strSQL = strSQL & "-1)"
%>

<%
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
<H1>Your Cart Is Empty</H1>
<%
rs.Close
conn.Close
Set conn = Nothing
Set rs = Nothing
Response.End
End If

rs.MoveFirst
%>
<H2>Items List In Shopping Cart:</H2>
<TABLE BORDER=1 CELLSPACING=1 CELLPADDING=1>
<TR>
<TH>Item</TH>
<TH>Quantity</TH>
<TH>Remove</TH>
</TR>
<%
Do Until rs.EOF
item = "txt" & rs(0)
quantity = Request.Cookies(item)
totalCost = totalCost + rs(3) * quantity
%>
<TR>
<TD><% = rs(1) & " " & rs(2) & " ($" & rs(3) & ")"%></TD>
<TD><% = quantity%></TD>

<TD>
<A HREF="removeFromCart.asp?cook=<%=item%>">RemoveNow</A>
</TD>
</TR>
<%
rs.MoveNext
Loop

rs.Close
conn.Close 
Set conn = Nothing 
Set rs = Nothing
%>
</TABLE>
<H3>total Cost :$<%=totalCost%></H3>

<P align=center>
<FORM action="acceptOrder.asp" method=POST name=form1>
<TABLE BORDER=1 CELLSPACING=1 CELLPADDING=1>
<TR>
<TD>First Name</TD>
<TD><INPUT name=txtFName></TD>
</TR>
<TR>
<TD>Last Name</TD>
<TD><INPUT name=txtLName></TD>
</TR>
<TR>
<TD>CreditCard Authority</TD>
<TD><INPUT name=txtCCAuth>
</TD>
</TR>
<TR>
<TD>Credit CardNumber</TD>
<TD><INPUT name=txtCCNum></TD>
</TR>
<TR>
<TD>AddressTo Deliver</TD>
<TD><INPUT name=txtAddr></TD>
</TR>
<TR>
<TD><INPUT type="submit" value = "Make Order"></TD>
<TD><INPUT type="reset" value="Clear"></TD>
</TR>
</TABLE>
</FORM>
</P>

</BODY>
</HTML>
