<html>
<%
Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
Set conn = Server.CreateObject("ADODB.Connection")
conn.Open Connect

SQL = "SELECT * FROM Employee Order by EmpID"
Set RS = Conn.Execute(SQL)
%>
<head>
<title>Edit/Delete Employee</title>
</head>
<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <table align="center" border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b>Add/Edit/Delete Employee</b></font></td>
    </tr>
  </table>
<p align="center"><b><font face="Arial" size="2">&nbsp;</font></b></p>
  <table align="center" border="1">
    <tr>
      <td><font face="Arial" font size="2"><b>Emp ID</b></font></td>
      <td><font face="Arial" font size="2"><b>Last Name</b></font></td>
      <td><font face="Arial" font size="2"><b>First Name</b></font></td>
      <td><font face="Arial" font size="2"><b>Dept</b></font></td>
      <td><font face="Arial" font size="2"><b>Ext</b></font></td>
      <td>&nbsp;</td>
      <td>&nbsp;</td>
    </tr>
<%Do Until RS.EOF%>    
    <tr>
      <td><font face="Arial" font size="2">&nbsp;<%Response.write(RS("EmpID"))%></td>
	<td><font face="Arial" font size="2">&nbsp<%Response.write(RS("LastName"))%></td>
      	<td><font face="Arial" font size="2">&nbsp<%Response.write(RS("FirstName"))%></td>
      	<td><font face="Arial" font size="2">&nbsp<%Response.write(RS("Dept"))%></td>
      	<td><font face="Arial" font size="2">&nbsp<%Response.write(RS("Ext"))%></td>
      	<td><font face="Arial" font size="2">
		<a href="InsUpd_employee.asp?EmpID=<%response.write(RS("EmpID"))%>">Edit</a></font></td>
      	<td><font face="Arial" font size="2">
		<a href="Del_employee.asp?EmpID=<%response.write(RS("EmpID"))%>">Del</a></font></td>
    </tr>
  <%
RS.MoveNext
Loop
RS.Close
Set RS=Nothing
Conn.Close
%>
</table>

<p align="center"><font size="2" face="Arial"><a href="InsUpd_employee.asp">Add New Employee</a><br>
</body>
</html>
 
