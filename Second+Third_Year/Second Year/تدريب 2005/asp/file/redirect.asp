<html>
<body>
<%
dim n,pass
n=request.form("logn")
pass=request.form("logpass")
dim namedr
if pass=555 then %>
<form action=""comment.asp" method="post" name="com">
<input type="hidden" name="n"  >lksdfjkdjhfkdfjkdf   c c c   c 
</form>
<%
else
response.redirect("accessdenid.asp")
end if
%>
</body>
</html>
