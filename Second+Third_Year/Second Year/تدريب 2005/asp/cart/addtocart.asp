<%@ Language=VBScript %>
<HTML>
<HEAD>
</HEAD>
<BODY>
<TABLE BORDER=1 CELLSPACING=1 CELLPADDING=1>
<TR>
<TH>Item ID</TH>
<TH>Quantity</TH>
</TR>

<%
For Each item In Request.Form
If item <> "submit" And item <> "clear" And item <> "deptId" then 
If Request.Form(item) <> "" Then
%>
<TR>
<TD><%=mid(item,4)%></TD>
<TD><%=Request.Form(item)%></TD>
</TR>
<%
End If
End If
Next
%>
<%
dptID = Request.Form("deptId")
For Each item In Request.Form
If item <> "submit" And item <> "clear" And item <> "deptId" Then
If Request.Form(item) <> "" Then
Response.Cookies(item) = Request.Form(item)
End If
End If
Next
Response.Redirect "showDept.asp?deptId="&dptID
%>

</TABLE>
</BODY>
</HTML>
