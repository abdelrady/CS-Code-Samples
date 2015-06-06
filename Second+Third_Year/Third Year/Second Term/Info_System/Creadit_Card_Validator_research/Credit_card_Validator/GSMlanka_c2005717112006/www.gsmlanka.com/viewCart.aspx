<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    call logincheck
    call checkstatus
    call dbcon
    call fillmanu
    call scrollphone
    if session("useriD")="" then
    btnlogin.text="login"
    end if
    
    If Not isPostBack Then
    
    if session("useriD")="" then
            btnlogin.text="login"
            end if
    
    call bindcart
    End If
    End Sub
    
    
    
    sub logincheck
    
    if session("userID")="" or session("cartison")="" or session.sessionID<>request.QueryString("transID") or session("seccode")<>request.QueryString("seccode") then
    
    session("invalidreq")="yes"
    response.redirect("requesterror.aspx")
    
    end if
    end sub
    
    
    sub bindcart
    
    
    call dbcon
    BCmd = New sqlCommand("Select phoneId,price,qty,totalamount,man_name from temp_cart,manufacturer where manufacturer.man_id=temp_cart.man_id and userid='" & session("userID") & "'  and  transid= '" & session.SessionID & "' and secCode='" & session("secCode") & "'",bcon)
    Bcon.Open()
    cartlist.DataSource = BCmd.ExecuteReader()
    cartlist.DataBind()
    BCon.Close()
    call totaldisp
    end sub
    
    sub removeItem(s As Object, e As DataListCommandEventArgs)
      dim phoneID as string
      phoneId= e.commandargument
      call dbcon
      mcmd=new sqlcommand("delete from temp_cart where phoneID='" & phoneId & "' and transID='" & session.SessionID & "' and secCode='" & session("seccode") & "' and userid='" & session("userID") & "'",bcon)
    bcon.open
    mcmd.executenonquery
    bcon.close
    
    call bindcart
    
    end sub
    
    
    sub totaldisp
    call dbcon
    dim nodata as boolean
    mcmd= new sqlcommand("select phoneID from temp_cart  where transid='" & session.SessionID & " ' and secCode='" & session("secCode") & " ' and userID='" & session("userID") & "'",bcon)
    bcon.open
    dr=mcmd.executereader
    
    
    if dr.hasrows=true then
    nodata=true
    else
    nodata=false
    end if
    bcon.close
    
    
    if nodata=true then
    
    
    tcmd=new sqlcommand("select count(phoneID) as totITems,sum(totalamount) as totCost from temp_cart where transid='" & session.SessionID & " ' and secCode='" & session("secCode") & " ' and userID='" & session("userID") & "'",bcon)
    
    bcon.open
    objreader=tcmd.executereader
    
    
    if objreader.hasrows=true  then
            objreader.read
            totItems=objreader("totItems")
            totCOst=objreader("totcost")
            else
    
            totItems=0
            totCost=0.00
    
    end if
    
    
    bcon.close
    end if
    
    end sub
    
    
    sub check_out(sender As Object, e As System.Web.UI.ImageClickEventArgs)
    call dbcon
    pcmd =new sqlcommand("select phoneID from temp_cart where transID='" & session.SessionID & "' and secCode='" & request.QueryString("secCode") &"'and userID='"& session("userID") &"'",bcon)
    
    bcon.open
    cdr=pcmd.executereader
    
    if cdr.hasrows=true then
    
    response.Redirect("checkout.aspx?transID=" &request.QueryString("transID") & "&secCode=" &cstr(session("secCode")) & "&userID=" &session("userID"))
    lblmessage.visible=false
    else
    lblmessage.text="you have no items in your cart"
    lblmessage.visible=true
    end if
    bcon.close
    end sub
    
    
    
    
    public nodata as boolean
    public totcost as decimal=0.00
    public totitems as integer=0

</script>
<!--#include file="config.aspx" -->
<!--#include file="scrollerdata.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="checklogin.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka - your online mobile shop,discussion forum and support for mobile
    users</title>
    <link href="favicon.ico" type="image/png" rel="icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link href="stylesheet1.css" type="text/css" rel="stylesheet1" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
</style>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet1" />
    <style type="text/css">.style1 {
	COLOR: #ffffff
}
.style3 {
	FONT-WEIGHT: bold
}
</style>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
<!--
.style4 {COLOR: #336699; FONT-FAMILY: Arial, Helvetica, sans-serif; font-size: 10pt;}
.style2 {TEXT-TRANSFORM: capitalize; COLOR: #336699; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none; font-size: 11px;}
-->
</style>
</head>
<body>
    <form runat="server">
        <table cellspacing="0" cellpadding="0" width="800" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td valign="top" width="800" height="32">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="307" height="4">
                                    </td>
                                    <td width="493">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" height="28">
                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/up_serch_ban.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="153" height="28">
                                                        &nbsp;</td>
                                                    <td valign="top" width="150">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="157" height="28">
                                                                        <font color="#336699">
                                                                        <asp:TextBox id="txtSearch" runat="server" Columns="6" width="104px" TextMode="SingleLine"></asp:TextBox>
                                                                        <asp:Button id="btnSearch" runat="server" Text="Go" Width="32"></asp:Button>
                                                                        </font></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="4">
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                        <table height="28" cellspacing="0" cellpadding="0" width="100%" align="center" bgcolor="#ffcc00" background="imagenew/up_ban.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="52" height="28">
                                                        <a class="toplink" href="index.aspx"><span class="style1">Home</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="55">
                                                        <a class="toplink" href="signup.aspx"><span class="style1">Register</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="58">
                                                        <a class="toplink" href="forum.aspx"><span class="style1">Forums</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="72">
                                                        <a class="toplink" href="orderstatus.aspx"><span class="style1">Track Order </span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="66">
                                                        <a class="toplink" href="multimedia.aspx">Multimedia</a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="42">
                                                        <a class="toplink" href="faq.aspx"><span class="style1">Faq</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="50">
                                                        <a class="toplink" href="about.aspx"><span class="style1">About</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="80">
                                                        <a class="toplink" href="contact.aspx"><span class="style1">Contact Us </span></a></td>
                                                    <td width="18">
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="7" height="7">
                    </td>
                    <td width="783">
                    </td>
                    <td width="7">
                    </td>
                </tr>
                <tr>
                    <td height="134">
                    </td>
                    <td valign="top">
                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/main_ban.jpg" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="783" height="134">
                                        <object title="Banner" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0" height="134" width="783" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000">
                                            <param name="movie" value="Flash Banner/banner.swf" />
                                            <param name="quality" value="high" />
                                            <embed src="Flash Banner/banner.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="783" height="134"></embed> 
                                        </object>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
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
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="7" height="18">
                    </td>
                    <td valign="top" width="783">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="783" height="18">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#f3f3f3" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="center" width="203" height="24">
                                                        You are logged in as <asp:Label id="lblusertext" runat="server" font-bold="true" text="Guest"></asp:Label></td>
                                                    <td width="203">
                                                        &nbsp;</td>
                                                    <td valign="center" align="right" width="377">
                                                        <span class="style3">
                                                        <asp:LinkButton id="btnViewprof" runat="server" Text="View Profile"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:LinkButton id="showcart" onclick="viewthecart" runat="server"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:linkButton id="btnlogin" onclick="sign" runat="server"></asp:linkButton>
                                                        </span></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="7">
                    </td>
                </tr>
                <tr>
                    <td height="9">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="7" height="430">
                        &nbsp;</td>
                    <td valign="top" width="783">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="108" height="432">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" colspan="4" height="132">
                                                        <asp:DataList id="phnlist" Width="100%" cellpadding="0" cellspacing="0" RepeatColumns="0" RepeatDirection="Vertical" DataKeyField="man_ID" OnItemCommand="Selectphn" Runat="Server">
                                                            <itemtemplate>
                                                                <table width="100%" border="0" cellpadding="0" cellspacing="0" class="border6">
                                                                    <!--DWLayoutTable-->
                                                                    <td width="100" height="18" valign="middle" class="navtendark" onclick="jump(this)" onmouseover="colorOn(this)" onmouseout="colorOff(this)">
                                                                        <a class="leftlink" >&nbsp;<span class="style1">&raquo;</font></strong></font> 
                                                                        <asp:LinkButton cssclass="style1" Text='<%# Container.DataItem("man_name") %>' CommandArgument='<%# Container.DataItem("man_name") %>' Runat="Server" />
                                                                        </span> </a> 
                                                                    </td>
                                                                </table>
                                                            </itemtemplate>
                                                        </asp:DataList>
                                                    </td>
                                                    <td width="7">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="12" height="10">
                                                    </td>
                                                    <td width="32">
                                                    </td>
                                                    <td width="29">
                                                    </td>
                                                    <td valign="top" width="27">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="27" height="10">
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="4" height="156">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" bgcolor="#f6f1dd" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="address" valign="center" width="89" bgcolor="#fbdca3" height="18">
                                                                        &nbsp;&nbsp;NEWS</td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="12">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="center" height="114">
                                                                        <font size="2"> 
                                                                        <marquee class="leftlink" onmouseover="this.stop()" onmouseout="this.start()" scrollamount="1" scrolldelay="15" direction="up" width="100%" height="114">
                                                                            <p align="center">
                                                                                <font face="Verdana" size="1">Lastest Upated </font><span class="postbody"><font face="Verdana" size="1">New <%= scrMan %></font></span><span class="postbody"><font face="Verdana" size="1"><%= scrPID %>
                                                                                <br />
                                                                                </font></span><span class="postbody"><font face="Verdana" size="1"><img height="100" src="phones/thumb/<%= scrImg %>" width="70" /></font></span><span class="postbody"><font face="Verdana" size="1"> 
                                                                                <br />
                                                                                only <%= scrPrice %></font></span>
                                                                                <br />
                                                                                now online 
                                                                            </p>
                                                                        </marquee>
                                                                        </font></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="10">
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="6">
                                                    </td>
                                                    <td valign="top">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="32" height="6">
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
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
                                    <td valign="top" width="676">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="536" height="433">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="41" height="14">
                                                                    </td>
                                                                    <td width="453">
                                                                    </td>
                                                                    <td width="40">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="194">
                                                                    </td>
                                                                    <td valign="top">
                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="top" colspan="2" height="81">
                                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="442" height="18">
                                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td class="address" valign="center" width="435" bgcolor="#fbdca3" height="18">
                                                                                                                        &nbsp;&nbsp;ITEMS IN YOUR CART</td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="top" height="35">
                                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td width="442" height="35">
                                                                                                                        <table bordercolor="#cccccc" height="35" width="442">
                                                                                                                            <!--DWLayoutTable-->
                                                                                                                            <tbody>
                                                                                                                                <tr>
                                                                                                                                    <td valign="center" width="70" bgcolor="#fff5ec">
                                                                                                                                        <div align="center"><span class="redfont">Product</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                    <td class="style2" width="84" bgcolor="#fff5ec" height="18">
                                                                                                                                        <div align="center"><span class="redfont">Make</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                    <td class="leftlink2" width="59" bgcolor="#fff5ec">
                                                                                                                                        <div align="center"><span class="redfont">Price</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                    <td class="leftlink2" width="67" bgcolor="#fff5ec">
                                                                                                                                        <div align="center"><span class="redfont">Quantity</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                    <td class="leftlink2" width="62" bgcolor="#fff5ec">
                                                                                                                                        <div align="center"><span class="redfont">Total</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                    <td class="leftlink2" width="60" bgcolor="#fff5ec">
                                                                                                                                        <div align="center"><span class="redfont">Option</span> 
                                                                                                                                        </div>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                            </tbody>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="top" height="23">
                                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td width="442" height="23">
                                                                                                                        <asp:DataList id="cartlist" Width="100%" cellpadding="0" cellspacing="0" RepeatColumns="0" RepeatDirection="Vertical" DataKeyField="phoneID" OnItemCommand="removeItem" Runat="Server">
                                                                                                                            <itemtemplate>
                                                                                                                                <table width="442" height="24" bordercolor="#CCCCCC">
                                                                                                                                    <!--DWLayoutTable-->
                                                                                                                                    <tr>
                                                                                                                                        <td width="70" height="18" valign="top" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <div align="center"><%# Container.DataItem("PhoneId") %> 
                                                                                                                                            </div>
                                                                                                                                        </td>
                                                                                                                                        <td width="84" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <div align="center"><%# Container.DataItem("man_name") %> 
                                                                                                                                            </div>
                                                                                                                                        </td>
                                                                                                                                        <td width="59" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <div align="right"><span class="leftlink1"><%# Container.DataItem("price") %></span> 
                                                                                                                                            </div>
                                                                                                                                        </td>
                                                                                                                                        <td width="67" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <div align="center"><span class="leftlink1"><%# Container.DataItem("qty") %></span> 
                                                                                                                                            </div>
                                                                                                                                        </td>
                                                                                                                                        <td width="62" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <span class="leftlink1"><%# Container.DataItem("totalamount") %></span></td>
                                                                                                                                        <td width="60" bgcolor="FEF9F5" class="leftlink1">
                                                                                                                                            <span class="leftlink1"> 
                                                                                                                                            <asp:LinkButton id="remove_item" text="remove" runat="server" CommandArgument='<%# Container.DataItem("PhoneID") %>' Font-Bold="true" />
                                                                                                                                            </span></td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </itemtemplate>
                                                                                                                        </asp:DataList>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td width="217" height="23">
                                                                                        &nbsp;</td>
                                                                                    <td width="227">
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="90">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" width="216" bgcolor="#fbdca3" height="20">
                                                                                                        <span class="address">&nbsp;&nbsp;CART SUMMERY</span></td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="top" height="70">
                                                                                                        <table class="border2" bordercolor="#cccccc" height="46" width="216">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td valign="center" align="left" width="114" bgcolor="#fff5ec" height="18">
                                                                                                                        <span class="leftlink1">Total Items in Cart </span></td>
                                                                                                                    <td class="style2" width="90" bgcolor="#fef9f5">
                                                                                                                        <div align="center"><%= totItems %>
                                                                                                                        </div>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td class="style4" valign="center" bgcolor="#fff5ec" height="18">
                                                                                                                        <div align="left"><span class="leftlink1">Total Cost </span>
                                                                                                                        </div>
                                                                                                                    </td>
                                                                                                                    <td class="style2" bgcolor="#fef9f5">
                                                                                                                        <div align="center"><%= totCost %>LKR 
                                                                                                                        </div>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td height="20">
                                                                                                                    </td>
                                                                                                                    <td>
                                                                                                                        <asp:ImageButton id="cmdcheckout" onclick="check_out" runat="server" ImageUrl="buttons/checkout.jpg"></asp:ImageButton>
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
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="25">
                                                                    </td>
                                                                    <td valign="center">
                                                                        <asp:Label id="lblmessage" runat="server" font-bold="true" visible="false" forecolor="#CC0000"></asp:Label>&nbsp;</td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="198">
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="10">
                                                    </td>
                                                    <td valign="top" width="130" rowspan="2">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="128" height="298">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="top" width="126" height="298">
                                                                                        <object title="banner" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0" height="298" width="126" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000">
                                                                                            <param name="movie" value="Banners/index_s.swf" />
                                                                                            <param name="quality" value="high" />
                                                                                            <embed src="Banners/index_s.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="126" height="298"></embed> 
                                                                                        </object>
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="8">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" align="middle" bgcolor="#acb3b8" height="125">
                                                                        <img height="125" alt="Banner" src="Banners/125x125.gif" width="125" /></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="7">
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
                    <td width="7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="1">
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
                    <td class="style1" valign="center" align="middle" width="394">
                        Copyright © GSM Lanka (Pvt) Ltd, 
                    </td>
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
