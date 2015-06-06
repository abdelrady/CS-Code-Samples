<%@ Page Language="VB" %>
<script runat="server">

    sub loginuser(Sender as Object, e as EventArgs)
    
    
             Dim strUname as string
             Dim strPass as string
             Dim strSQLQuery as string
             Dim CheckUname as string
             Dim Checkpass as string
    
             CheckUname =txtuser.Text
             Checkpass = txtpass.Text
               call dbcon
              strSQLQuery = "select userID,pass_word from users where userID='" & txtuser.Text & "'"
                Bcon.open
             bcmd = New SqlCommand(strSQLQuery, Bcon)
             objreader = bcmd.ExecuteReader
    
                If objreader.HasRows = False Then
    
                lblmessege.text="Your userID is incorrect. Please try again"
                   lblmessege.visible=true
             End If
    
    
             Do while (objreader.Read())
    
                 strUname=objReader("UserID")
                 strPass=objReader("pass_word")
    
    
    
            if  (strUname <> Request.Form("txtuser")) Then
                     lblmessege.text = "Your userID is incorrect. Please try again."
                        txtuser.text=""
                     lblmessege.Visible = True
                 elseif (strPass <> Request.Form("txtpass")) Then
                     lblmessege.text = "Your password is incorrect. Please try again."
                     lblmessege.Visible = True
    
    
                 else
                     Session("userid") = strUname
                        session("secCOde")=cstr(getsecCode(1,546789))
                        session("checklog")=false
                     Response.Redirect("index.aspx")
                        txtuser.text=""
                 end if
    
             loop
    
             bcon.close
    
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
