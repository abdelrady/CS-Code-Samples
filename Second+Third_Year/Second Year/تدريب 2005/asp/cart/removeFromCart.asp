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
cookName = Request.QueryString("cook")
Response.Cookies(cookName).Expires = Now()-1000
Response.Redirect "showCart.asp"
%>

</BODY>
</HTML>
