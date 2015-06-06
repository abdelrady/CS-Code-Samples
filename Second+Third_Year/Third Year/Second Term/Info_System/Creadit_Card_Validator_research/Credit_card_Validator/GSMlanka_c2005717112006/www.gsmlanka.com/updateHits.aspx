<%@ Page Language="VB" %>
<script runat="server">

    sub updateHIts
    
    cartcon.open()
    dim statHIts as string
    statHits="UPDATE phone_details SET hits=hits+1 WHERE phoneID ='" & request.QueryString("PhoneID")  & "'"
    
    pcmd=new sqlcommand( statHIts,cartcon)
    pcmd.ExecuteNonQuery()
    
    cartcon.Close()
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
