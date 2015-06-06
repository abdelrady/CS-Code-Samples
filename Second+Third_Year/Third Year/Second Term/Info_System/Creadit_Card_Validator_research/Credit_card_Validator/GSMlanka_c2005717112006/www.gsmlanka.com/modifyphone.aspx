<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    if session("AdminID")="" then
    session("adminlog")=true
    response.Redirect("adminlogin.aspx")
    
    else
    lbladmin.text=session("adminID")
    call filldata
    if not page.ispostback then
    call finddetails
    
    end if
    
    
    end if
    End Sub
    
    sub finddetails
    dim fillSQL as string
    
    fillSQL="select phoneID,network,phone_details.man_ID,date_pub,status,dimension,weight,Disp_type,Disp_size,rng_type,custamization,vibration,phn_book,call_rec,card_slot,GPRS,HSCSD,EDGE,status_3g,WLAN,Blootooth,Infrared,USB,OS,Messeging,Browser,Clock,Games,Colors,Lang_stat,Camara,Other_features,Bat_type,Bat_standby,bat_talk,Price,Quantity,Reorder_lvl,BigImg,Smallimg,Thumnail,man_name from phone_Details,manufacturer where phone_details.man_Id=manufacturer.man_iD and phoneID= '" & cstr(request.querystring("phoneID")) & "'"
    
    mcmd=new sqlcommand(fillSQL,bcon)
    bcon.open
    objreader=mcmd.executereader
    objreader.read
    
    txtPhnID.text=cstr(objreader("phoneID"))
    txtNet.text=objreader("Network")
    cboMan.SelectedItem.Text=objreader("man_name")
    txtpub.text=objreader("date_pub")
    cboStatus.items.add(objreader("status"))
    cboStatus.SelectedItem.Text=objreader("status")
    txtDimension.text=objreader("dimension")
    txtWeight.text=objreader("weight")
    txtDtype.text=objreader("Disp_type")
    txtSize.text=replace(objreader("Disp_size"),"<br>", chr(13))
    txtRtype.text=objreader("rng_type")
    txtCustom.text=objreader("custamization")
    cbovibtion.items.add(objreader("vibration"))
    cboVibtion.selecteditem.text=objreader("vibration")
    txtPbook.text=replace(objreader("phn_book"),"<br>", chr(13))
    txtCrec.text=objreader("call_rec")
    txtCslot.text=replace(objreader("card_slot"),"<br>", chr(13))
    txtGprs.text=objreader("GPRS")
    cboHSCSD.items.add(objreader("HSCSD"))
    cboHSCSD.selecteditem.text=objreader("HSCSD")
    cboEDGE.items.add(objreader("EDGE"))
    cboEDGE.selecteditem.text=objreader("EDGE")
    cbo3G.items.add(objreader("status_3g"))
    cbo3G.selecteditem.text=objreader("status_3g")
    cboWLAN.items.add(objreader("wlan"))
    cboWLAN.selecteditem.text=objreader("WLAN")
    txtBlue.text=objreader("Blootooth")
    cboInfra.items.add(objreader("infrared"))
    cboInfra.selecteditem.text=objreader("Infrared")
    txtUsb.text=objreader("USB")
    txtOs.text=objreader("OS")
    txtMsg.text=objreader("Messeging")
    txtBrowser.text=objreader("Browser")
    cboClock.selecteditem.text=objreader("Clock")
    txtGames.text=objreader("Games")
    txtcolors.text=objreader("Colors")
    txtLangs.text=objreader("Lang_stat")
    txtCam.text=replace(objreader("Camara"),"<br>", chr(13))
    txtOtherf.text=replace(objreader("Other_features"),"<br>", chr(13))
    txtBtyp.text=objreader("Bat_type")
    txtBstan.text=objreader("Bat_standby")
    txtTalk.text=objreader("bat_talk")
    txtPrice.text=objreader("Price")
    txtQty.text=objreader("Quantity")
    txtRE.text=objreader("Reorder_lvl")
    txtfull.text=objreader("BigImg")
    txtdet.text=objreader("Smallimg")
    txtthumb.text=objreader("Thumnail")
    
    objreader.close
    
    bcon.close
    
    end sub
    
    
    
    sub updatephone( sender As Object, e As System.Web.UI.ImageClickEventArgs)
    
    
    
            if page.isvalid then
    
    
                If  Not IsDate(txtpub.text) then
                    lblerror.text="Invalid date"
                    lblerror.visible=true
    
                else
                    lblerror.text=""
                    lblstatus.text=""
                    lblstatus.visible=false
    
                call dbcon
                        dim updateSQL as string
                      dim manIDcheck as integer
    
                 bcon.open
                 mcmd=new sqlcommand("select man_id from manufacturer where man_name='" & cboMan.SelectedItem.Text & " ' ",bcon)
                 dr=mcmd.executereader
    
                 while dr.read
                 manidcheck=dr("man_ID")
                 end while
                 bcon.close
    
    
    
                bcon.open
    
    updatesql="update phone_details set  phoneID=@phoneID,network=@network,man_ID=@man_id,date_pub=@date_pub,status=@status,dimension=@dimension,weight=@weight,Disp_type=@disp_type,rng_type=@rng_type,custamization=@custamization,vibration=@vibration,phn_book=@phn_book,call_rec=@call_rec,card_slot=@card_slot,GPRS=@GPRS,HSCSD=@HSCSD,Edge=@EDGE,status_3g=@status_3g,WLAN=@WLAN,blootooth=@blootooth,infrared=@infrared,USB=@USB,OS=@OS,messeging=@messeging,Browser=@browser,Clock=@clock,games=@games,colors=@colors,lang_stat=@lang_stat,camara=@camara,other_features=@other_features,bat_type=@bat_type,bat_standby=@bat_standby,bat_talk=@bat_talk,price=@price,quantity=@quantity,Reorder_lvl=@Reorder_lvl,bigimg=@BigImg,smallImg=@smallImg,thumnail=@thumnail where phoneID=" & "'"  & cstr(request.QueryString("phoneID")) &  " '"
    
    
    
    tcmd=new sqlcommand(updateSQL,bcon)
    'adding parameters
    TCmd.Parameters.Add(New sqlParameter("@phoneID", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@Network", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@man_id", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@date_pub",sqlDbType.datetime))
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
    TCmd.Parameters("@BigImg").Value=cstr(txtfull.text)
    TCmd.Parameters("@Smallimg").Value= cstr(txtdet.text)
    TCmd.Parameters("@Thumnail").Value=cstr(txtthumb.text)
    
    
    
                TCmd.ExecuteNonQuery
                txtphnID.text=""
                response.Redirect("dbsuccess.aspx")
                end if
                bcon.close
                end if
    end sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="UBBC.aspx" -->
<!--#include file="phone_update.aspx" -->
<html>
<head>
    <title>GSMLanka - Phone Manager- Modify Phones</title>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">
<!--
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #cccccc;
}
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #CCCCCC;
}
-->
</style>
    <style type="text/css">
<!--
.style1 {color: #FFFFFF}
.style3 {color: #CC3300}
.style4 {color: #999999}
.style6 {color: #FF9900}
.style7 {
	color: #000000;
	font-size: 12px;
}
.style8 {color: #336699}
.style9 {color: #003366#336699}
.style11 {color: #FF6600}
-->
</style>
    <script type="text/JavaScript">
<!--
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
//-->
</script>
</head>
<body onload="MM_preloadImages('buttons/addnewphn2.gif','buttons/ModiyPhone2.gif','buttons/User-Management2.gif','buttons/Orders2.gif','buttons/sign_out1.gif')">
    <form runat="server">
        <table cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td valign="top" width="112" rowspan="2">
                        <img height="38" alt="Logo" src="imagenew/sg_logo.jpg" width="112" /></td>
                    <td width="269" height="25">
                        &nbsp;</td>
                    <td width="317">
                    </td>
                    <td valign="bottom" width="101" rowspan="2">
                        <span class="address"><span class="style3">GSM</span> <span class="style4">Lanka <span class="style6">Home</span> </span></span></td>
                </tr>
                <tr>
                    <td class="redfont" valign="top" height="16">
                        Welcome Administrator: <asp:Label id="lblAdmin" runat="server" font-bold="true"></asp:Label></td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="buttons/Admin_bblank.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="4" height="39">
                        &nbsp;</td>
                    <td valign="top" width="125">
                        <a onmouseover="MM_swapImage('Add New Phone','','buttons/addnewphn2.gif',1)" onmouseout="MM_swapImgRestore()" href="phonemanager.aspx"><img height="39" alt="Add New Phone" src="buttons/addnewphn1.gif" width="125" border="0" name="Add New Phone" /></a></td>
                    <td valign="top" width="123">
                        <a onmouseover="MM_swapImage('Modiy Phone','','buttons/ModiyPhone2.gif',1)" onmouseout="MM_swapImgRestore()" href="selectphone.aspx"><img height="39" alt="Modiy Phone" src="buttons/ModiyPhone1.gif" width="127" border="0" name="Modiy Phone" /></a></td>
                    <td valign="top" width="148">
                        <a onmouseover="MM_swapImage('User Managemen','','buttons/User-Management2.gif',1)" onmouseout="MM_swapImgRestore()" href="usermanager.aspx"><img height="39" alt="User Managemen" src="buttons/User-Management1.gif" width="148" border="0" name="User Managemen" /></a></td>
                    <td valign="top" width="97">
                        <a onmouseover="MM_swapImage('Orders','','buttons/Orders2.gif',1)" onmouseout="MM_swapImgRestore()" href="orderManagement.aspx"><img height="39" alt="Orders" src="buttons/Orders1.gif" width="97" border="0" name="Orders" /></a></td>
                    <td valign="top" width="100">
                        <a onmouseover="MM_swapImage('E-letter','','buttons/eletter2.gif',0)" onmouseout="MM_swapImgRestore()" href="eletter.aspx"><img height="39" alt="E-letter" src="buttons/eletter1.gif" width="100" border="0" name="E-letter" /></a></td>
                    <td width="89">
                        &nbsp;</td>
                    <td valign="top" width="83">
                        <a onmouseover="MM_swapImage('Sign out','','buttons/sign_out1.gif',1)" onmouseout="MM_swapImgRestore()" href="signout.aspx"><img height="39" alt="Sign out" src="buttons/sign_out.gif" width="91" border="0" name="Sign out" /></a></td>
                    <td width="18">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td class="address" align="left" width="275" height="39">
                        <span class="style8">&nbsp;&nbsp;<img height="34" alt="Phone Manger " src="imagenew/Phn_man_icn..png" width="48" />Phone
                        Manger </span><span class="style9"></span>: MODIFY PHONE 
                    </td>
                    <td width="123">
                        &nbsp;</td>
                    <td valign="center" align="left" width="401">
                        <asp:Label id="lblstatus" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/phoneman_up.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="11" height="2">
                    </td>
                    <td width="382">
                    </td>
                    <td width="12">
                    </td>
                    <td width="323">
                    </td>
                    <td width="59">
                    </td>
                    <td width="10">
                    </td>
                </tr>
                <tr>
                    <td height="88">
                        &nbsp;</td>
                    <td valign="top" rowspan="12">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="382" height="184">
                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="center" colspan="4" height="23">
                                                        &nbsp;&nbsp;<img height="20" alt="Gendrel Details" src="imagenew/Phn_genrl_icn..png" width="26" /> Gendrel
                                                        Details 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="95" height="5">
                                                    </td>
                                                    <td width="10">
                                                    </td>
                                                    <td width="256">
                                                    </td>
                                                    <td width="19">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Phone ID : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtPhnID" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v1" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtPhnID" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Manufacture : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboMan" runat="server"></asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="center" align="right" height="22">
                                                        <span class="leftlink">Network : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtNet" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v2" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtNet" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="center" align="right" height="22">
                                                        <span class="leftlink">Status : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboStatus" runat="server">
                                                            <asp:ListItem value="Available">Available</asp:ListItem>
                                                            <asp:ListItem value="Coming Soon">Coming Soon</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="9">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="center" align="right" height="22">
                                                        <span class="leftlink">Published : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtPub" runat="server" MaxLength="20"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v3" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtPub" Font-Bold="true"></asp:requiredfieldvalidator>
                                                        <asp:Label id="lblerror" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="5">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" height="125">
                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="1" height="1">
                                                    </td>
                                                    <td width="94">
                                                    </td>
                                                    <td width="9">
                                                    </td>
                                                    <td width="208">
                                                    </td>
                                                    <td width="68">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="redfont" valign="center" colspan="4">
                                                        &nbsp;<img height="20" alt="Ringtones" src="imagenew/Phn_ring_icn..png" width="26" />Ringtones</td>
                                                </tr>
                                                <tr>
                                                    <td height="4">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        Type : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtRtype" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v4" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtRtype" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        Customization : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtCustom" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v5" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtCustom" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td valign="center" align="right">
                                                        <span class="leftlink">Vibration : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboVibtion" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="9">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="12">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" height="284">
                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="1" height="1">
                                                    </td>
                                                    <td width="94">
                                                    </td>
                                                    <td width="9">
                                                    </td>
                                                    <td width="208">
                                                    </td>
                                                    <td width="68">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="redfont" valign="center" colspan="4">
                                                        &nbsp;<img height="20" alt="Date" src="imagenew/Phn_data_icn..png" width="26" />Data</td>
                                                </tr>
                                                <tr>
                                                    <td height="4">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        GPRS : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtGprs" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v6" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtGprs" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        HSCSD : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboHSCSD" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td valign="center" align="right">
                                                        <span class="leftlink">EDGE : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboEDGE" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td valign="center" align="right">
                                                        <span class="leftlink">3G : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cbo3G" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        WLAN : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboWLAN" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td class="leftlink" valign="center" align="right">
                                                        Bluetooth : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtBlue" runat="server" MaxLength="50"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v7" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtBlue" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td valign="center" align="right">
                                                        <span class="leftlink">Infrared port : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:DropDownList id="cboInfra" runat="server">
                                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                                            <asp:ListItem value="No">No</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="22">
                                                    </td>
                                                    <td valign="center" align="right">
                                                        <span class="leftlink">USB : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtUsb" runat="server" MaxLength="50"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v8" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtUsb" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="8">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" height="119">
                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="bottom" colspan="4" height="22">
                                                        &nbsp;<img height="20" alt="Battery" src="imagenew/Phn_Battery_icn..png" width="26" />Battery</td>
                                                </tr>
                                                <tr>
                                                    <td width="95" height="4">
                                                    </td>
                                                    <td width="10">
                                                    </td>
                                                    <td width="211">
                                                    </td>
                                                    <td width="64">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Battery : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtBtyp" runat="server" MaxLength="200"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v9" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtBtyp" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Stand-by : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtBstan" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v10" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtBstan" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="center" align="right" height="22">
                                                        <span class="leftlink">Talk time : </span></td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtTalk" runat="server" MaxLength="100"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v11" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtTalk" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="3">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="1">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" height="117">
                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="center" colspan="4" height="23">
                                                        &nbsp;&nbsp;<img height="20" alt="Size" src="imagenew/Phn_image_icn..png" width="26" /> Image 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="95" height="4">
                                                    </td>
                                                    <td width="10">
                                                    </td>
                                                    <td width="211">
                                                    </td>
                                                    <td width="64">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Thumbnail : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtThumb" runat="server" MaxLength="300"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v12" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtThumb" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="10">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="leftlink" valign="center" align="right" height="22">
                                                        Detail View : 
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:TextBox id="txtDet" runat="server" MaxLength="300"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v13" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtDet" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="4">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="center" align="right" height="22">
                                                        <p>
                                                            <span class="leftlink">Full Image :</span> 
                                                        </p>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td valign="top" colspan="2">
                                                        <asp:TextBox id="txtFull" runat="server" MaxLength="300"></asp:TextBox>
                                                        <asp:requiredfieldvalidator id="v14" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtFull" Font-Bold="true"></asp:requiredfieldvalidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="8">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td valign="top" colspan="2">
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td class="redfont" valign="center" colspan="4" height="22">
                                        &nbsp;&nbsp;<img height="20" alt="Size" src="imagenew/Phn_size_icn..png" width="26" /> Size</td>
                                </tr>
                                <tr>
                                    <td width="95" height="4">
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td width="211">
                                    </td>
                                    <td width="64">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="22">
                                        Dimensions : 
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top">
                                        <asp:TextBox id="txtDimension" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v15" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtDimension" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="22">
                                        Weight : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtWeight" runat="server"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v16" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtWeight" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="5">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="12">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="102">
                    </td>
                    <td>
                    </td>
                    <td valign="top" colspan="2">
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td class="redfont" valign="center" colspan="4" height="22">
                                        &nbsp;<img height="20" alt="Display" src="imagenew/Phn_Display_icn..png" width="26" /> Display</td>
                                </tr>
                                <tr>
                                    <td width="95" height="4">
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td width="211">
                                    </td>
                                    <td width="64">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="22">
                                        Type : 
                                    </td>
                                    <td valign="top">
                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                    <td valign="top">
                                        <asp:TextBox id="txtDtype" runat="server" MaxLength="50"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v17" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtDtype" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td valign="top" rowspan="3">
                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="35">
                                        Size : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtSize" runat="server" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v18" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtSize" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="6">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="11">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="149">
                    </td>
                    <td>
                    </td>
                    <td valign="top" colspan="2">
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="1" height="1">
                                    </td>
                                    <td width="94">
                                    </td>
                                    <td width="9">
                                    </td>
                                    <td width="208">
                                    </td>
                                    <td width="68">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="redfont" valign="center" colspan="4">
                                        &nbsp;<img height="20" alt="Memory" src="imagenew/Phn_Memory_icn..png" width="26" /> Memory</td>
                                </tr>
                                <tr>
                                    <td height="4">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        Phonebook : 
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top">
                                        <asp:TextBox id="txtPbook" runat="server" MaxLength="100" TextMode="MultiLine"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v19" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtPbook" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        Call records : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtCrec" runat="server" MaxLength="20"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v20" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtCrec" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Card slot : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtCslot" runat="server" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v21" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtCslot" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="7">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="12">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="325">
                    </td>
                    <td>
                    </td>
                    <td valign="top" colspan="2">
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="1" height="1">
                                    </td>
                                    <td width="94">
                                    </td>
                                    <td width="9">
                                    </td>
                                    <td width="208">
                                    </td>
                                    <td width="68">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="redfont" valign="center" colspan="4">
                                        &nbsp;&nbsp;<img height="20" alt="Features" src="imagenew/Phn_Features_icn..png" width="26" /> Features</td>
                                </tr>
                                <tr>
                                    <td height="4">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        OS : 
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top">
                                        <asp:TextBox id="txtOs" runat="server" MaxLength="200"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v22" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtOs" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        Messaging : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtMsg" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v41" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtPhnID" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Browser : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtBrowser" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v24" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtBrowser" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Clock : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:DropDownList id="cboClock" runat="server">
                                            <asp:ListItem value="Yes">Yes</asp:ListItem>
                                            <asp:ListItem value="No">No</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        Other : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtOtherf" runat="server" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v233" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtOtherf" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td class="leftlink" valign="center" align="right">
                                        Games : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtGames" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v25" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtGames" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Colors : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtcolors" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v26" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtcolors" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Languages : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtLangs" runat="server" MaxLength="100"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v27" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtLangs" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="9">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink">Camera : </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtCam" runat="server" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v28" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtCam" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="5">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="11">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="150">
                    </td>
                    <td>
                    </td>
                    <td valign="top" colspan="2">
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td class="redfont" valign="bottom" colspan="4" height="23">
                                        &nbsp;<img height="20" alt="Battery" src="imagenew/Phn_Stock-_icn..png" width="26" /> Stock 
                                    </td>
                                </tr>
                                <tr>
                                    <td width="95" height="4">
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td width="256">
                                    </td>
                                    <td width="19">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="22">
                                        Price : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="2">
                                        <asp:TextBox id="txtPrice" runat="server" MaxLength="8"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v30" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtPrice" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:RegularExpressionValidator id="chprice" runat="server" ControlToValidate="txtPrice" ErrorMessage="digits only" Text="* Digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="leftlink" valign="center" align="right" height="22">
                                        Quantity : 
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtQty" runat="server" MaxLength="5"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v31" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtQty" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:RegularExpressionValidator id="chQty" runat="server" ControlToValidate="txtQty" ErrorMessage="digits only" Text="* Digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="center" align="right" height="22">
                                        <span class="leftlink">Reorder Level: </span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtRE" runat="server" MaxLength="4"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="v32" runat="server" errormessege="field cannot be blank" text="*" Font-Size="12" controltovalidate="txtRE" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:RegularExpressionValidator id="chRE" runat="server" ControlToValidate="txtRE" ErrorMessage="digits only" Text="* Digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="11">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="16">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="27">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td valign="top">
                        <asp:ImageButton id="add" onclick="updatephone" runat="server" ImageUrl="buttons/Update.jpg"></asp:ImageButton>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="13">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/dlink_ban-new-copy.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="192" height="28">
                        &nbsp;</td>
                    <td valign="center" align="middle" width="394">
                        <span class="style1">Copyright © GSM Lanka (Pvt) Ltd, </span></td>
                    <td width="213">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
    </form>
</body>
</html>
