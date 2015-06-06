<html>
<%
	Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
	Set conn = Server.CreateObject("ADODB.Connection")
	conn.Open Connect
	SQL = "Select * from Employee Where EmpID = " + request.querystring("EmpID") 
	Set RS = Conn.Execute(SQL)
%>
<head>
<title>Delete Employee</title>
</head>

<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <center>
  <table border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b>Delete Employee</b></font></td>
    </tr>
  </table>
  </center>

<p align="center"><b><font face="Arial" size="2">&nbsp;</font></b></p>
  <center>
  <table border="1">
    <tr>
      <td><font face="Arial" font size="2"><b>Emp ID</b></font></td>
      <td><font face="Arial" font size="2"><b>Last Name</b></font></td>
      <td><font face="Arial" font size="2"><b>First Name</b></font></td>
      <td><font face="Arial" font size="2"><b>Dept</b></font></td>
      <td><font face="Arial" font size="2"><b>Ext</b></font></td>
    </tr>
    <tr>
      <td><font face="Arial" font size="2">&nbsp;<%Response.write(RS("EmpID"))%></td>
      <td><font face="Arial" font size="2">&nbsp<%Response.write(RS("LastName"))%></td>
      <td><font face="Arial" font size="2">&nbsp<%Response.write(RS("FirstName"))%></td>
      <td><font face="Arial" font size="2">&nbsp<%Response.write(RS("Dept"))%></td>
      <td><font face="Arial" font size="2">&nbsp<%Response.write(RS("Ext"))%></td>
    </tr>
  <%
RS.MoveNext
RS.Close
Set RS=Nothing
Conn.Close
%>
</table>
  </center>
<p align="center">
<font size="2" face="Arial">
Are you sure you want to delete?
&nbsp<a href="del_employee_action.asp?EmpID=<%Response.write(Request.QueryString("EmpID"))%>">Yes</a>
&nbsp <a href="index.html">No</a></font></p>
<br>
<p align="center"><font size="2" face="Arial"><a href="default.asp">Main Page</a></font></p>
</html>
