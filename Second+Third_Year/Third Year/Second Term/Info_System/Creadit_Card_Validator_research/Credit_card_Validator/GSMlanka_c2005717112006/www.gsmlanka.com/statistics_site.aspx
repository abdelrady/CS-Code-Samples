<%@ Page Language="VB" %>
<script runat="server">

    sub sitestat
    
    call dbcon
    
    tcmd= new sqlcommand("select count(userid) as usercount from users",bcon)
    bcon.open
    dr=tcmd.executereader
    dr.read
    lblMemcount.text=cstr(dr("usercount"))
    bcon.close
    
    tcmd= new sqlcommand("select sum(quantity) as phn_qty from phone_details",bcon)
    bcon.open
    dr=tcmd.executereader
    dr.read
    lblphncount.text=cstr(dr("phn_qty"))
    bcon.close
    
    tcmd= new sqlcommand("select count(postID) as pstcount from post",bcon)
    bcon.open
    dr=tcmd.executereader
    dr.read
    lblpst.text=cstr(dr("pstcount"))
    bcon.close
    
    
    
    
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
