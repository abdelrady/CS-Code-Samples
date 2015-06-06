<%@ Page Language="VB" %>
<script runat="server">

    sub fillmanu
    call dbcon
    BCmd = New sqlCommand("select * from manufacturer order by man_id asc",Bcon )
    Bcon.Open()
    phnList.DataSource = BCmd.ExecuteReader()
    phnList.DataBind()
    BCon.Close()
    
    
    
    end sub
    
    
    Sub SelectPhn(s As Object, _
    e As DataListCommandEventArgs)
    
    Dim man_ID,Man_Name As String
    Man_Name = e.CommandArgument
    man_ID = _
    phnList.DataKeys.Item( _
    e.Item.ItemIndex).toString()
    Response.Redirect("viewphone.aspx?man_Id=" & _
    man_id & "&man_Name=" &man_name)
    End Sub
    
    sub manLogo
    call dbcon
    bcon.open
    tcmd=new sqlcommand("select man_img from manufacturer where man_ID='" & request.QueryString("man_Id") & "' or man_name='" & request.QueryString("man_name") & "'",bcon)
    objreader=tcmd.executereader
    while objreader.read
    manPic=cstr(objreader("man_img"))
    end while
    bcon.close
    
    
    end sub
    
    
    
    public manPIc as string

</script>
<html>
<head>
</head>
<body>
</body>
</html>
