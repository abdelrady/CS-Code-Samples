<html>
<%

%>
<body>

<%
%>

<%
if ValidLogin(Request.Form("userid"),request.form("userpassword"))then
Response.Redirect "main.asp"
else 
Response.Redirect "errors.asp"
end if
%>
<%
Function ValidLogin(name,pw)
 Connect = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & Server.MapPath(".\access\school.mdb")
Set conn = Server.CreateObject("ADODB.Connection")
conn.Open Connect 
SQL = "select st_name,st_pass from student "
Set RS = conn.Execute (sql)
  ValidLogin=False
  Do Until rs.EOF
    If rs("st_name")=name And rs("st_pass")=pw Then
       ValidLogin=True
       Exit Do
    End If
    rs.MoveNext
  Loop 
End Function
%>