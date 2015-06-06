<%@ Page Language="VB" %>
<script runat="server">

    sub loginAdmin(sender As Object, e As System.Web.UI.ImageClickEventArgs)
    
    
             Dim strUname As String
             Dim strPass as string
             Dim strSQLQuery as string
             Dim CheckUname as string
             Dim Checkpass as string
    
             CheckUname =txtGsmadmin.Text
             Checkpass = txtadminlogPas.Text
               call dbcon
              strSQLQuery = "select userID,pass_word from users where userID='" & txtGsmadmin.Text & "' and priviladge='Administrator'"
                Bcon.open
             Data.SqlClient.SqlCommand  bcmd = New Data.SqlClient.SqlCommand(strSQLQuery, Bcon))
             objreader = bcmd.ExecuteReader
    
                If objreader.HasRows = False Then
    
                lblmessege.text="Your Admin ID is incorrect. Please try again"
                   lblmessege.visible=true
             End If
    
    
             Do while (objreader.Read())
    
                 strUname=objReader("UserID")
                 strPass=objReader("pass_word")
    
    
    
            if  (strUname <> Request.Form("txtGsmadmin")) Then
                     lblmessege.text = "Your AdminID is incorrect. Please try again."
                        txtGsmadmin.text=""
                     lblmessege.Visible = True
                 elseif (strPass <> Request.Form("txtadminlogPas")) Then
                     lblmessege.text = "Your password is incorrect. Please try again."
                     lblmessege.Visible = True
    
    
                 else
                     Session("userid") = strUname
                        session("adminID")=strUname
                        session("secCOde")=getsecCode(1,546789)
                        session("adminlog")=false
                     Response.Redirect("adminhome.aspx")
                        txtGsmadmin.text=""
                 end if
    
             loop
    
             bcon.close
    
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
    &nbsp;<asp:textbox id="txtadminlogPas" runat="server"></asp:textbox>
    <asp:textbox id="txtGsmadmin" runat="server"></asp:textbox>
    <asp:Label id="lblmessege" runat="server" text="Label"></asp:Label>
</body>
</html>
