<html>
<%
	Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\emplyee.mdb")
	Set conn = Server.CreateObject("ADODB.Connection")
	conn.Open Connect
%>

<head>
<title>Employee Listing</title>
</head>
<body>
<p align="center"><img border="0" src="UniColordSmall.jpg"></p>
  <table align="center" border="1" width="590" bgcolor="#996633">
    <tr>
      <td>
        <p align="center"><font face="Arial" size="5" color="#FFFFFF"><b>Edit Employee</b></font></td>
    </tr>
  </table>
<p align="center">&nbsp;</p>
<p align="center">&nbsp;</p>
<p align="center"><font size="2" face="Arial">
<%If request.querystring("EmpID")<>"" Then
	SQL = "Update Employee"
	SQL = SQL & " Set EmpID =" & Request.Form("EmpID") 
	SQL = SQL & ", LastName = '" & Request.Form("Last") & "'"
	SQL = SQL & ", FirstName = '" & Request.Form("First") & "'"
	SQL = SQL & ", Dept = '" & Request.Form("Dept") & "'"
	SQL = SQL & ", Ext = '" & Request.Form("Ext") & "'"
	SQL = SQL & "  Where EmpID = " & Request.Querystring("EmpID") 
Else
	SQL = "Insert into Employee (EmpID,LastName,FirstName,Dept,Ext) Values ("
	SQL = SQL + request.Form("EmpID") + ",'"
	SQL = SQL + request.Form("Last") + "','" + request.Form("First") + "','"
	SQL = SQL + request.Form("Dept") + "','" + request.Form("Ext") + "')"
End If


Set RS = Conn.Execute(SQL)
Set RS = Nothing
If conn.errors.count>0 Then
	for counter = 0 to conn.errors.count
		response.write conn.errors(counter).description & "<P>"
	next
Else
	response.write ("Update Complete") & "<P>"
End If
Conn.close
Set Conn = Nothing
%>
</body>
</html>
