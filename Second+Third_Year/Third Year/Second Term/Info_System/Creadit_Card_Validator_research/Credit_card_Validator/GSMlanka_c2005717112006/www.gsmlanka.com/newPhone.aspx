<%@ Page Language="VB" %>
<script runat="server">

    'updates the newest added phone
    sub updatenewphone
    
      dim manIDcheck1 as integer
      //using
                 bcon.open
             mcmd = New Data.SqlClient.SqlCommand("select man_id from manufacturer where man_name='" & cboMan.SelectedItem.Text & " ' ", bcon)
                 dr=mcmd.executereader
    
                 while dr.read
                 manidcheck1=dr("man_ID")
                 end while
                 bcon.close
    
    
    
    MCmd=new sqlcommand("update newestPhone set PhoneID=@phoneID,man_id=@man_id,price=@price,thumnail=@thumnail where checker='new'",bcon)
             MCmd.Parameters.Add(New Data.SqlClient.SqlParameter("@phoneID", sqlDbType.Varchar, 100))
    MCmd.Parameters.Add(New sqlParameter("@man_id", sqlDbType.int))
    MCmd.Parameters.Add(New sqlParameter("@Price", sqlDbType.decimal))
    MCmd.Parameters.Add(New sqlParameter("@Thumnail", sqlDbType.Varchar,300))
    
    MCmd.Parameters("@phoneID").Value=cstr(txtPhnID.text)
    MCmd.Parameters("@man_id").Value=manIDcheck1
    MCmd.Parameters("@Price").Value=cdec(txtPrice.text)
    MCmd.Parameters("@Thumnail").Value=txtthumb.text
    
    bcon.open
    MCmd.executenonquery
    bcon.close
    end sub

</script>
<html>
<head>
</head>
<body>
    using Data.SqlClient; 
</body>
</html>
