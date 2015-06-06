<html>
<%
Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
Set conn = Server.CreateObject("ADODB.Connection")
conn.Open Connect
SQL = "SELECT * FROM Employee Order by LastName, FirstName"
Set RS = Conn.Execute(SQL)
%>
<head>
<title>Employee Listing</title>
</head>
<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <table align="center" border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b> Employee
        Listing</b></font></td>
    </tr>
  </table>
<p align="center">&nbsp;</p>
  <table align="center" border="1">
    <tr>
      <td><font face="Arial"><b>Emp ID</b></font></td>
      <td><font face="Arial"><b>Last Name</b></font></td>
      <td><font face="Arial"><b>First Name</b></font></td>
      <td><font face="Arial"><b>Dept</b></font></td>
      <td><font face="Arial"><b>Ext</b></font></td>
    </tr>
<%Do Until RS.EOF%>    
    <tr>
      <td>&nbsp;<%Response.write(RS("EmpID"))%></td>
      <td>&nbsp;<%Response.write(RS("LastName"))%></td>
      <td>&nbsp;<%Response.write(RS("FirstName"))%></td>
      <td>&nbsp;<%Response.write(RS("Dept"))%></td>
      <td>&nbsp;<%Response.write(RS("Ext"))%></td>
    </tr>
  <%
RS.MoveNext
Loop
RS.Close
Conn.Close
%>
</table>
  </center>
</div>
<p align="center"><font size="2" face="Arial"><a href="default.asp">Menu</a></font></p>
</body>
</html>
