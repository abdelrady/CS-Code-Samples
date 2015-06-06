<%@ Page Language="VB" %>
<script runat="server">

    sub checkstatus
    
    if session("userid")="" then
    
    
    btnviewprof.visible=false
    btnlogin.text="Login"
    lblusertext.text="Guest"
    else
    
    
    btnviewprof.visible=true
    btnlogin.text="Logout"
    lblusertext.text=session("userid")
    end if
    
    if session("cartison")="yes" then
    
    showcart.text="view cart"
    else
    showcart.text=""
    end if
    
    
    end  sub
    
    Sub sign( obj As Object, e As EventArgs )
    if session("userid")="" then
    response.redirect("login.aspx")
    else
    if session("cartison")="yes" then
    call dbcon
    
    pcmd=new sqlcommand("delete from temP_cart where transID='" & session.SessionID & "' and secCode='" & session("secCode") & "' and userid='" & session("userId") & "'",bcon)
    bcon.open
    pcmd.executenonquery
    bcon.close
    end if
    session("userid")=""
    session("cartison")=""
    session("seccode")=""
    btnlogin.text="Login"
    lblusertext.text="Guest"
    response.Redirect("successlogout.aspx")
    checkstatus
    end if
    end sub
    
    
    sub viewthecart( obj As Object, e As EventArgs )
    if session("cartison")="yes"
    response.Redirect("viewcart.aspx?transID=" &session.SessionID & "&secCode=" &cstr(session("secCode")) & "&userID=" &session("userID"))
    end if
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
