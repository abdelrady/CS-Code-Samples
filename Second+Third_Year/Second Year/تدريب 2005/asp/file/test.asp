<%response.buffer=true%>
<html>

<body bgcolor="#000099">

<center>
<hr1><font size=7 color="#ccff66">
<%
Response.Write time
%>
</hr1> 
<br>  
<table >
<%
for i=1 to 12
	response.write "<tr>"	
	for j=1 to 12
		response.write "<td>"& i*j &"</td>"
	next
	response.write "</tr>"
next
%>
</table>
</font>
</center>
</body>
</html>