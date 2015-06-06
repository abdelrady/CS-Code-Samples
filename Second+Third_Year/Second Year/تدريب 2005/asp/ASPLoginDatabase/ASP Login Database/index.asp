<%@ Language=VBScript %>
<!-- Option Explicit %> -->
<!--#include file="adovbs.inc" -->

<HTML>
<HEAD>
<TITLE>ASP/Database Login System</TITLE>
</HEAD>
<BODY>


<%

If Request("operation")="Login" And Request("name")<>"" And Request("pw")<>"" Then
   ' check for valid name,pw
   if BetterValidLogin(Request("name"),Request("pw")) Then %>
       <H2>You are logged in <%=Request("name")%></H2>
   <%Else%>
       <H2>Invalid Name or Password</H2>
   <%End If
ElseIf Request("operation")="Create" Then
   ' check for valid entries all we care about is name,pw
   If Request("name") = "" OR Request("pw") = "" Then %>
      <H2>Invalid name or password</H2>
   <%ElseIf GetPassword(Request("name"))<>"" Then %>
      <H2>That name is already taken</H2>
   <%Else
      Call OtherNewAccount(Request("name"),Request("pw")) %>
      <H2>Your account has been created, you can now log in</H2>
   <%End If 
ElseIf Request("operation") = "Change" Then
   'check for valid name
   If Request("name") = "" OR Request("pw") = "" Then %>
      <H2>Invalid name or password</H2>
   <%ElseIf GetPassword(Request("name"))="" Then %>
      <H2>No such name (ID) found</H2>
   <%ElseIf Not ValidLogin(Request("name"),Request("opw")) Then %>
      <H2>Bad (old) password</H2>
   <%Else
      Call OtherChangePassword(Request("name"),Request("pw")) %>
      <H2>Your Password has been changed.</H2>
   <%End If 
ElseIf Request("operation") <> "" Then%>
   <H2>Unknown Request</H2>
<%
End If
Call Forms()
%>


<% '=================================================
Sub Forms()
%>
<!--#include file='login.html'--> 
<% End Sub %>
<% '================================================= %>
<%
Function ValidLogin(name,pw)
  Dim DBConn
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")
  Set res = DBConn.Execute("SELECT * FROM Password")
  ValidLogin=False
  Do Until res.EOF
    If res("Name")=name And res("Password")=pw Then
       ValidLogin=True
       Exit Do
    End If
    res.MoveNext
  Loop 
End Function


Function BetterValidLogin(name,pw)
  Dim DBConn
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")
  Set res = DBConn.Execute _
        ("SELECT * FROM Password WHERE name = '"&name&"'")
  If res.EOF Then
     BetterValidLogin=False
  ElseIf res("Password") = pw Then
     BetterValidLogin=True
  Else
     BetterValidLogin=False
  End If
End Function


Function GetPassword(name)
  Dim DBConn
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")
  Set res = DBConn.Execute("SELECT * FROM Password Where Name = '" & name & "'")
  If res.EOF THen
    GetPassword=""
  Else
    GetPassword=res("Password")
  End If
End Function

Sub NewAccount(name,pw)
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")
  DBConn.Execute("INSERT INTO password (Name, Password) VALUES ('" &name& "', '"& pw & "');")
  ' need to do some error checking !
End Sub


Sub OtherNewAccount(name,pw)
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")	
  Set RS = Server.CreateObject("ADODB.RecordSet")
  RS.Open "password",DBConn,adOpenDynamic,adLockOptimistic
  RS.AddNew
  RS("Name")=name
  RS("Password")= pw
  RS.Update
End Sub

Sub OtherChangePassword(name,pw)
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")	
  Set RS = Server.CreateObject("ADODB.RecordSet")
  RS.Open "SELECT * FROM password WHERE Name = '"&name&"'",DBConn,adOpenDynamic,adLockOptimistic
  RS("Password")=pw
  RS.Update
End Sub	
  
Sub ChangePassword(name,pw)
  Set DBConn=Server.CreateObject("ADODB.Connection")
  DBConn.Open("eiw")
  DBConn.Execute("UPDATE password Set Password = '" & pw & "' WHERE Name='" & name & "';")
  ' need to do some error checking !
End Sub


%>

</BODY>
</HTML>






