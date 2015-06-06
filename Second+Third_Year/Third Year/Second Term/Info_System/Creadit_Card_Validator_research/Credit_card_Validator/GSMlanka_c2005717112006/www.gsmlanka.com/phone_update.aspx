<%@ Page Language="VB" %>
<script runat="server">

    sub filldata
    dim manuSQL as string
    call dbcon
    manusql= "select man_name from manufacturer order by man_ID"
    bcon.open
    bcmd = New SqlCommand(manuSQL, Bcon)
    objreader = bcmd.ExecuteReader
    
    while objreader.read
    cboMan.items.add(objreader("man_name"))
    end while
    bcon.close
    end sub
    
    
    
    
    
    'fill the controls with phone details

</script>
<html>
<head>
</head>
<body>
</body>
</html>
