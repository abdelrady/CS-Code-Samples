<html>
<body bgcolor="#ccccff">
<%
dim n,e,c
n=request.form("name1")
e=request.form("email")
c=request.form("comment")
%>
<h2>Name of User :</h2>
<%response.write n %>
<h2>your Email :</h2>
<% response.write e %>
<br>
<H1> thank you for your comment which is<h1><br>
<center>
<font color=red size=5 ><%response.write c%></font>



<%response.write f %>
<h3>Time of submition : </h3>
<%response.write now %>

</body>
</html>