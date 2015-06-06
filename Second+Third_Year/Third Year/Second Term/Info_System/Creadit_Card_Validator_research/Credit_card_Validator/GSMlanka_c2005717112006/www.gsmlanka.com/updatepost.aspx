<%@ Page Language="VB" %>
<script runat="server">

    sub updatepostcount
    bcon.open()
    dim stat as string
    stat="UPDATE users SET posts=posts+1 WHERE userId ='" & session("userid") & "'"
    
    pcmd=new sqlcommand( stat,bcon)
    pcmd.ExecuteNonQuery()
    
    bcon.Close()
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
