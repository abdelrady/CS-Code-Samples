<html>
<%
Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
Set conn = Server.CreateObject("ADODB.Connection")
conn.Open Connect
SQL = "SELECT EmpID, LastName & ', ' & FirstName as EmpName FROM Employee Order by LastName"
Set RS = Conn.Execute(SQL)
%>
<head>
<title>Employee Listing</title>
</head>
<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <center>
  <table border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b>Employee
        Lookup</b></font></td>
    </tr>
  </table>
  </center>
<p align="center">&nbsp;</p>
<form action="employee_lookup_results.asp" method="POST" name="LookupEmp">
  <p align="center">
<select size="1" name="LookupEmp">
  <%Do Until RS.EOF%>    
    <option value="<%Response.write(RS("EmpID"))%>">
    <%Response.write(RS("EmpName"))%></option>
    <%
RS.MoveNext
Loop
RS.Close
Conn.Close
%>
  </select>
<input type="submit" value="Lookup" name="Lookup"></p>
</form>
<p align="center"><font size="2" face="Arial"><a href="default.asp">Menu</a></font></p>
</body>
</html>
