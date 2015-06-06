<%@ Page Language="VB" %>
<script runat="server">

    sub scrollphone
    
      dim scrollcmd as  sqlcommand
      dim manNO as integer
      dim mansql as string
      scrollcmd=new sqlcommand("select phoneID,man_id,price,thumnail from newestPhone where checker='new'",bcon)
    bcon.open
    objreader=scrollcmd.executereader
    objreader.read
    scrPID=objreader("phoneID")
    manNo=objreader("man_Id")
    scrPrice=objreader("price")
    scrImg=objreader("thumnail")
    bcon.close
    
    'get manufacture name
    mansql="select man_name from manufacturer where man_id=" & manNO
    pcmd=new sqlcommand(manSQL,bcon)
    bcon.open
    dr=pcmd.executereader
    dr.read
    scrMan=dr("man_name")
    bcon.close
    
    
    end sub
    public scrPID,scrMan,scrPrice,scrImg as string

</script>
<html>
<head>
</head>
<body>
</body>
</html>
