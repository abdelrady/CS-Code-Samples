<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    call checkstatus
    if session("useriD")="" then
    btnlogin.text="login"
    end if
    
    If Not isPostBack Then
    call dbcon
    call fillmanu
    if session("useriD")="" then
            btnlogin.text="login"
            end if
    call scrollphone
    call sitestat
    End If
    End Sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="scrollerdata.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="checklogin.aspx" -->
<!--#include file="statistics_site.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka - your online mobile shop,discussion forum and support for mobile
    users</title>
    <link href="favicon.ico" type="image/png" rel="icon" />
    <meta content="gsmlanka the first srilankan online mobile shop.find all your latest phones and get them delevered to your door step." name="description" />
    <meta content="gsmlanka,gsm lanka, mobile. srilanka,srilankan mobile, srilankan phone, phones, mobiles,aneef,mobile discussion,forum,lanka mobile,gsm" name="keywords" />
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
.style6 {
	font-size: 8px;
	color: #336699;
}
.style7 {color: #FF9900}
.style9 {color: #669940}
.style10 {
	color: #D13737;
	font-weight: bold;
}
.style12 {color: #669940; font-weight: bold; }
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
                                                                    <td class="address" valign="center" width="89" background="imagenew/bkh.gif" height="18">
                                                                        &nbsp;&nbsp;<span class="style9">NEWS</span></td>
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
                                                    <td valign="top" colspan="3" rowspan="2">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="address" valign="center" background="imagenew/bkh.gif" colspan="5" height="18">
                                                                        &nbsp;&nbsp;<span class="style9">WEL COME</span> 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="6" height="6">
                                                                    </td>
                                                                    <td width="220">
                                                                    </td>
                                                                    <td width="8">
                                                                    </td>
                                                                    <td width="104">
                                                                    </td>
                                                                    <td width="6">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="80">
                                                                        &nbsp;</td>
                                                                    <td class="leftlink2" valign="top">
                                                                        Welcome to GSMLanka<sup>©</sup> your online mobile shop.find all about your favorite
                                                                        phone. rate,Discuss and purchase them online with no time.and it will be deleverd
                                                                        to your door step . enjoy GSM Lanka!. 
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td valign="top">
                                                                        <img height="80" alt="Wel Come" src="imagenew/welcome.gif" width="104" /></td>
                                                                    <td>
                                                                        &nbsp;</td>
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
                                                    <td valign="top" width="8" height="48">
                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                    <td valign="top" width="185" rowspan="2">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="center" width="183" background="imagenew/bkh.gif" height="18">
                                                                        <span class="style12">&nbsp;&nbsp;SITE STATISTICS </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" height="30">
                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td width="183" height="4">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="bottom" align="left" height="26">
                                                                                        <img height="25" alt="usr" src="imagenew/logged-in-as-img.jpg" width="27" align="absMiddle" /> <asp:Label id="lblMemcount" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label><span class="leftlink2">Members</span> 
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="4">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" height="26">
                                                                        <img height="26" alt="phn" src="imagenew/Phn_Memory_icn..png" width="27" align="absMiddle" /> <asp:Label id="lblphncount" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label><span class="leftlink2">Phones </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="4">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" height="26">
                                                                        <img height="26" alt="pst" src="imagenew/Phn_man_icn..png" width="27" align="absMiddle" /> <asp:Label id="lblpst" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label><span class="leftlink2">Discussions</span></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="8">
                                                    </td>
                                                    <td valign="top" width="131" rowspan="7">
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
                                                    <td height="65">
                                                        &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="185" height="9">
                                                    </td>
                                                    <td width="9">
                                                    </td>
                                                    <td width="150">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" rowspan="2">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="183" height="124">
                                                                        <object title="intro" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0" height="124" width="183" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000">
                                                                            <param name="movie" value="Flash Banner/smallswf.swf" />
                                                                            <param name="quality" value="high" />
                                                                            <embed src="Flash                         
                        Banner/smallswf.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="183" height="124"></embed> 
                                                                        </object>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td height="126">
                                                    </td>
                                                    <td valign="top" colspan="3">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="address" valign="center" background="imagenew/bkh.gif" colspan="5" height="18">
                                                                        &nbsp;&nbsp;<span class="style9">DISCLAIMER</span> 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="6" height="6">
                                                                    </td>
                                                                    <td width="219">
                                                                    </td>
                                                                    <td width="6">
                                                                    </td>
                                                                    <td width="104">
                                                                    </td>
                                                                    <td width="6">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="93">
                                                                        &nbsp;</td>
                                                                    <td class="leftlink2" valign="center">
                                                                        Please note this site is currently under testing and used for educational purpose.and
                                                                        the site is not used to any purposes like phising.so please use fake credit card details
                                                                        in the shopping cart.thank you.Admin.</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td valign="top">
                                                                        <img height="89" alt="Wel Come" src="imagenew/info.gif" width="104" /></td>
                                                                    <td>
                                                                        &nbsp;</td>
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
                                                    <td height="1">
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
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="5" height="175">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="246" height="82">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td class="address" valign="center" background="imagenew/bkh.gif" colspan="2" height="18">
                                                                                        &nbsp;<span class="style9">REWIEWS</span></td>
                                                                                </tr>
                                                                                <!--DWLayoutTable-->
                                                                                <tr>
                                                                                    <td valign="top" width="77" height="62">
                                                                                        <img height="62" alt="6280" src="imagenew/6280.gif" width="77" /></td>
                                                                                    <td class="leftlink1" valign="center" width="172">
                                                                                        <div align="left">reviews on the phones @ GSM Lanka by the experts on mobile phones
                                                                                            will be coming soon.stay in touch to know all about your favorite phone. 
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td width="9">
                                                                    </td>
                                                                    <td width="136" rowspan="3">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="center" width="134" background="imagenew/bkh.gif" height="18">
                                                                                        <span class="address">&nbsp;&nbsp;&nbsp;<span class="style9">TOP THEMES</span> </span></td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="4">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="43" height="35">
                                                                                                        <img height="28" alt="Civic New" src="imagenew/civic_themes.gif" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="top" width="91">
                                                                                                        <strong>Civic New</strong><span class="style6"> 
                                                                                                        <br />
                                                                                                        98.5 KB. 
                                                                                                        <br />
                                                                                                        <span class="style7"><strong>Sony Ericsson</strong></span></span></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="44" height="35">
                                                                                                        <img height="28" alt="Windows Xp " src="imagenew/win_xp.gif" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="91">
                                                                                                        <strong>Windows Xp </strong><span class="style6">
                                                                                                        <br />
                                                                                                        159.0 KB. 
                                                                                                        <br />
                                                                                                        <span class="style7"><strong>Sony Ericsson</strong></span></span></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="40" rowspan="2">
                                                                                                        <img height="28" alt="Think Linux " src="imagenew/ThinkLinux.gif" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="82" height="33">
                                                                                                        <strong>Think Linux </strong><span class="style6">
                                                                                                        <br />
                                                                                                        179.0 KB. 
                                                                                                        <br />
                                                                                                        <span class="style7"><strong>Sony Ericsson</strong></span></span></td>
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
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="35">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="44" height="35">
                                                                                                        <img height="28" alt="Daisy" src="imagenew/Daisy.gif" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="91">
                                                                                                        <strong>Daisy</strong><span class="style6"> 
                                                                                                        <br />
                                                                                                        44.0 KB. 
                                                                                                        <br />
                                                                                                        <span class="style7"><strong>Sony Ericsson</strong></span></span></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td width="9">
                                                                    </td>
                                                                    <td valign="top" width="137" rowspan="3">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="center" width="135" background="imagenew/bkh.gif" height="18">
                                                                                        <span class="address">&nbsp;&nbsp;&nbsp;<span class="style9">TOP MP3 TONES</span></span></td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="4">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="40" rowspan="2">
                                                                                                        <img height="28" alt="Gorillaz" src="imagenew/mp3_gorillaz.jpg" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="82" height="33">
                                                                                                        <span class="style10">Feel Good Inc </span>
                                                                                                        <br />
                                                                                                        Gorillaz 
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
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="44" height="35">
                                                                                                        <img height="28" alt="Veerzara" src="imagenew/mp3_veerzarah.jpg" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="91">
                                                                                                        <span class="style10">Veer Zara</span> 
                                                                                                        <br />
                                                                                                        Main Yahaan</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="36">
                                                                                        <table class="border8" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="40" rowspan="2">
                                                                                                        <img height="28" alt="Kalhonaho" src="imagenew/mp3_kalhonaho.jpg" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="82" height="33">
                                                                                                        <span class="style10">Kal Ho Na Ho</span><strong> 
                                                                                                        <br />
                                                                                                        </strong>Kal HoNa Ho...</td>
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
                                                                                    <td height="2">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="top" height="35">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="44" height="35">
                                                                                                        <img height="28" alt="Khakee" src="imagenew/mp3_khakee.jpg" width="31" /></td>
                                                                                                    <td class="leftlink1" valign="center" width="91">
                                                                                                        <span class="style10">Khakee</span> 
                                                                                                        <br />
                                                                                                        Wada Raha</td>
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
                                                                    <td height="9">
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" rowspan="2">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td class="address" valign="center" background="imagenew/bkh.gif" colspan="2" height="18">
                                                                                        &nbsp;<span class="style9">COMING SOON</span></td>
                                                                                </tr>
                                                                                <!--DWLayoutTable-->
                                                                                <tr>
                                                                                    <td valign="top" width="76" height="62">
                                                                                        <img height="62" alt="6280" src="imagenew/cominsoon.gif" width="77" /></td>
                                                                                    <td class="leftlink1" valign="center" width="169">
                                                                                        We will releasing our portal for mobile mulitimedia and mobile applications, on june
                                                                                        2006.and it will be totally free for members.</td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td height="82">
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
