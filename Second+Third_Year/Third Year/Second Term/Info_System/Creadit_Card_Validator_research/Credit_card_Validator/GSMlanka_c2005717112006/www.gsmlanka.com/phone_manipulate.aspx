<%@ Page Language="VB" %>
<script runat="server">

    public manIDcheck as integer
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
    
    
    
    Sub createparam
    
      dim manIDcheck as integer
    
                 bcon.open
                 mcmd=new sqlcommand("select man_id from manufacturer where man_name='" & cboMan.SelectedItem.Text & " ' ",bcon)
                 dr=mcmd.executereader
    
                 while dr.read
                 manidcheck=dr("man_ID")
                 end while
                 bcon.close
    
    
    
    
    
    
    
    tcmd=new sqlcommand(insertSQL,bcon)
    'adding parameters
    TCmd.Parameters.Add(New sqlParameter("@phoneID", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Network", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@man_id", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@date_pub", sqlDbType.datetime))
    TCmd.Parameters.Add(New sqlParameter("@status", sqlDbType.Varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@dimension", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@weight", sqlDbType.Varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@Disp_type", sqlDbType.char,100))
    TCmd.Parameters.Add(New sqlParameter("@Disp_size", sqlDbType.Varchar,200))
    TCmd.Parameters.Add(New sqlParameter("@rng_type", sqlDbType.char,100))
    TCmd.Parameters.Add(New sqlParameter("@custamization", sqlDbType.char,100))
    TCmd.Parameters.Add(New sqlParameter("@vibration", sqlDbType.char,20))
    TCmd.Parameters.Add(New sqlParameter("@phn_book", sqlDbType.char,100))
    TCmd.Parameters.Add(New sqlParameter("@call_rec", sqlDbType.char,20))
    TCmd.Parameters.Add(New sqlParameter("@card_slot", sqlDbType.Varchar,200))
    TCmd.Parameters.Add(New sqlParameter("@GPRS", sqlDbType.varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@HSCSD", sqlDbType.char,50))
    TCmd.Parameters.Add(New sqlParameter("@EDGE", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@status_3g", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@WLAN", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Blootooth", sqlDbType.char,50))
    TCmd.Parameters.Add(New sqlParameter("@Infrared", sqlDbType.char,50))
    TCmd.Parameters.Add(New sqlParameter("@USB", sqlDbType.char,50))
    TCmd.Parameters.Add(New sqlParameter("@OS", sqlDbType.Varchar,200))
    TCmd.Parameters.Add(New sqlParameter("@Messeging", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Browser", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Clock", sqlDbType.char,10))
    TCmd.Parameters.Add(New sqlParameter("@Games", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Colors", sqlDbType.char,100))
    TCmd.Parameters.Add(New sqlParameter("@Lang_stat", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Camara", sqlDbType.Varchar,500))
    TCmd.Parameters.Add(New sqlParameter("@Other_features", sqlDbType.Varchar,200))
    TCmd.Parameters.Add(New sqlParameter("@Bat_type", sqlDbType.Varchar,200))
    TCmd.Parameters.Add(New sqlParameter("@Bat_standby", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@bat_talk", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Price", sqlDbType.decimal))
    TCmd.Parameters.Add(New sqlParameter("@Quantity", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@Reorder_lvl", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@Hits", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@BigImg", sqlDbType.Varchar,300))
    TCmd.Parameters.Add(New sqlParameter("@Smallimg", sqlDbType.Varchar,300))
    TCmd.Parameters.Add(New sqlParameter("@Thumnail", sqlDbType.Varchar,300))
    
    
    'assigning values
    
    
    TCmd.Parameters("@phoneID").Value=cstr(txtPhnID.text)
    TCmd.Parameters("@Network").Value=cstr(txtNet.text)
    TCmd.Parameters("@man_id").Value=manIDcheck
    TCmd.Parameters("@date_pub").Value=cstr(txtpub.text)
    TCmd.Parameters("@status").Value=cstr(cboStatus.SelectedItem.Text)
    TCmd.Parameters("@dimension").Value=cstr(txtDimension.text)
    TCmd.Parameters("@weight").Value=cstr(txtWeight.text)
    TCmd.Parameters("@Disp_type").Value=cstr(txtDtype.text)
    TCmd.Parameters("@Disp_size").Value=cstr(Replace(txtSize.text, CStr(chr(13)), "<br>"))
    TCmd.Parameters("@rng_type").Value=cstr(txtRtype.text)
    TCmd.Parameters("@custamization").Value=cstr(txtCustom.text)
    TCmd.Parameters("@vibration").Value=cstr(cboVibtion.selecteditem.text)
    TCmd.Parameters("@phn_book").Value=cstr(Replace(txtPbook.text, CStr(chr(13)), "<br>"))
    TCmd.Parameters("@call_rec").Value=cstr(txtCrec.text)
    TCmd.Parameters("@card_slot").Value=cstr(Replace(txtCslot.text, CStr(chr(13)), "<br>"))
    TCmd.Parameters("@GPRS").Value=cstr(txtGprs.text)
    TCmd.Parameters("@HSCSD").Value=cstr(cboHSCSD.selecteditem.text)
    TCmd.Parameters("@EDGE").Value=cstr(cboEDGE.selecteditem.text)
    TCmd.Parameters("@status_3g").Value=cstr(cbo3G.selecteditem.text)
    TCmd.Parameters("@WLAN").Value=cstr(cboWLAN.selecteditem.text)
    TCmd.Parameters("@Blootooth").Value=cstr(txtBlue.text)
    TCmd.Parameters("@Infrared").Value=cstr(cboInfra.selecteditem.text)
    TCmd.Parameters("@USB").Value=cstr(txtUsb.text)
    TCmd.Parameters("@OS").Value=cstr(txtOs.text)
    TCmd.Parameters("@Messeging").Value=cstr(txtMsg.text)
    TCmd.Parameters("@Browser").Value=cstr(txtBrowser.text)
    TCmd.Parameters("@Clock").Value=cstr(cboClock.selecteditem.text)
    TCmd.Parameters("@Games").Value=cstr(txtGames.text)
    TCmd.Parameters("@Colors").Value=cstr(txtcolors.text)
    TCmd.Parameters("@Lang_stat").Value=cstr(txtLangs.text)
    TCmd.Parameters("@Camara").Value=cstr(Replace(txtCam.text, CStr(chr(13)), "<br>"))
    TCmd.Parameters("@Other_features").Value=cstr(Replace(txtOtherf.text, CStr(chr(13)), "<br>"))
    TCmd.Parameters("@Bat_type").Value=cstr(txtBtyp.text)
    TCmd.Parameters("@Bat_standby").Value=cstr(txtBstan.text)
    TCmd.Parameters("@bat_talk").Value=cstr(txtTalk.text)
    TCmd.Parameters("@Price").Value=cdec(txtPrice.text)
    TCmd.Parameters("@Quantity").Value=cint(txtQty.text)
    TCmd.Parameters("@Reorder_lvl").Value=cint(txtRE.text)
    TCmd.Parameters("@Hits").Value=0
    TCmd.Parameters("@BigImg").Value= txtfull.text
    TCmd.Parameters("@Smallimg").Value=txtdet.text
    TCmd.Parameters("@Thumnail").Value=txtthumb.text
    
    
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
