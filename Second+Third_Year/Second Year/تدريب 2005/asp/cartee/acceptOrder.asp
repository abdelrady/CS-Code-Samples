<%@ Language=VBScript %>
<HTML>
<HEAD>
</HEAD>
<BODY>
<center>
 <A HREF="showDept.asp?deptId=1">TV - Video</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=2">Stereo</A>&nbsp;|&nbsp;
<A HREF="showDept.asp?deptId=3">Kitchen Accessories</A>
</center>
<%
fn = Request.Form("txtFName")
ln = Request.Form("txtLName")
cca = Request.Form("txtCCAuth")
ccn = Request.Form("txtCCNum")
addr = Request.Form("txtAddr")

strSQL= "SELECT * FROM count"

dbname="\mahdy\cart.mdb"
Set conn = Server.CreateObject("ADODB.Connection")
ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;" 
ConnectionString=ConnectionString & "Data Source="  
ConnectionString=ConnectionString & Server.MapPath(dbname)
conn.ConnectionString =ConnectionString
conn.Open

set RS = Server.CreateObject("ADODB.recordset")
rs.Open "select * from counts",conn,,2

thisOrderNumber = rs(0)
rs(0) = thisOrderNumber+1
rs.Update
rs.Close
Set rs = Nothing

mydate=now()
mydate1=split(mydate," ")
 

strSQL = "INSERT INTO orders (id,orderdate,fname,lname,cardtype,cnumber,address) VALUES ( " 
strsql=strsql & thisOrderNumber  & ",#" & mydate1(0) & "#,'" 
strSQL=strSQL & fn & "','" & ln & "','" & cca & "'," & ccn & ",'" & addr & "' )"

response.write strsql
 //response.end

conn.execute (strsql)


For Each item In Request.Cookies
If Left(item,3) = "txt" Then
itemId = Mid(item,4)
quantity = Request.Cookies(item)

strSQLOrderDetails="INSERT INTO order_detail (ITEMID,ORDERID,QUANTITY) VALUES (" 
strSQLOrderDetails=strSQLOrderDetails & itemId & "," & thisOrderNumber & "," & quantity & ")"
conn.Execute strSQLOrderDetails

Response.Cookies(item).Expires = Now()-1000
End If
Next
conn.Close
Set conn = Nothing
%>

<HTML>
<HEAD></HEAD>
<BODY>
<H2 align = center> Your Order Was Successfully Accepted. Order Number is:
<%=thisOrderNumber%></H2>
</BODY></HTML>
