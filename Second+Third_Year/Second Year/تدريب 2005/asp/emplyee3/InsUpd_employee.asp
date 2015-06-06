<html>
<%
Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
Set conn = Server.CreateObject("ADODB.Connection")
conn.Open Connect

If request.querystring("EmpID")<>"" Then
	SQL = "Select * from Employee Where EmpID = " & request.querystring("EmpID")  
	Set RS = Conn.Execute(SQL)
End if
%>
<head>
<title>Add/Edit Employee</title>
</head>
<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <table align="center" border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b>Add/Edit
        Employee</b></font></td>
    </tr>
  </table>
<p align="center">&nbsp;</p>
<form action="InsUpd_employee_action.asp<%If request.querystring("EmpID")<>"" Then
	 %>?EmpID=<%Response.Write(Request.QueryString("EmpID"))%><%End If%>" method="POST" name="NewEmp">
    <table align="center" border="0" width="590">
      <tr>
        <td align="right"><font face="Arial">Emp ID:</font></td>
        <td><input type="text" name="EmpID" size="4" maxlength="4"
        <%If request.querystring("EmpID")<>"" Then %>value='<%Response.write(RS("EmpID"))%>'<%End If%>></td>
      </tr>

      <tr>
        <td align="right"><font face="Arial">Last Name:</font></td>
        <td><input type="text" name="Last" size="30" maxlength="30" 
        <%If request.querystring("EmpID")<>"" Then %>value='<%Response.write(RS("LastName"))%>'<%End If%>></td>
      </tr>

      <tr>
        <td align="right"><font face="Arial">First Name:&nbsp; </font></td>
        <td><input type="text" name="First" size="20" maxlength="20"
        <%If request.querystring("EmpID")<>"" Then %>value='<%Response.write(RS("FirstName"))%>'<%End If%>></td>
      </tr>

      <tr>
        <td align="right"><font face="Arial">Dept ID:</font></td>
        <td><input type="text" name="Dept" size="4" maxlength="4"
        <%If request.querystring("EmpID")<>"" Then %>value='<%Response.write(RS("Dept"))%>'<%End If%>></td>
      </tr>

      <tr>
        <td align="right"><font face="Arial">Ext: </font></td>
        <td><input type="text" name="Ext" size="4" maxlength="4"
        <%If request.querystring("EmpID")<>"" Then %>value='<%Response.write(RS("Ext"))%>'<%End If%>></td>
      </tr>
    </table>
  <p align="center"><input type="submit" value="Submit" name="Submit"><input type="reset" value="Reset" name="Reset"></p>
</form>
</body>
</html>
