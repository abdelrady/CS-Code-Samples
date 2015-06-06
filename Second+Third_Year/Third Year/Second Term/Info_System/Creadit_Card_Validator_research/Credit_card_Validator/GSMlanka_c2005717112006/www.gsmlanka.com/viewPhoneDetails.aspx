<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    public man_name1
    
    Sub Page_Load( s As Object, e As EventArgs )
    
    call checkstatus
    if session("useriD")="" then
    btnlogin.text="login"
    end if
    'if request.QueryString("man_ID")="" then
    'response.Redirect("index.aspx")
    'end if
    
    
    If Not isPostBack Then
    call fillmanu
            ViewState("Start") = 0
    
            if session("useriD")="" then
            btnlogin.text="login"
            end if
    
    End If
    
    call checkman
    call manLogo
    call showDetails
    call updateHIts
    call disprating
    End Sub
    
    sub checkman
    call dbcon
    mcmd=new sqlcommand("select phoneid,man_id from phone_details where phoneID='" & request.QueryString("phoneID") & "' and man_id=(select man_id from manufacturer where man_name='" & request.QueryString("man_name") & "')" ,bcon)
    bcon.open
    dr=mcmd.executereader
    If dr.HasRows = False Then
    session("invalidreq")="yes"
      response.Redirect("requesterror.aspx")
    
    End If
    
    
    bcon.close
    end sub
    
    
    
    
    sub showDetails
    
    call dbcon
    
    bcmd=new sqlcommand("select phoneID,network,phone_details.man_ID,date_pub,status,dimension,weight,Disp_type,Disp_size,rng_type,custamization,vibration,phn_book,call_rec,card_slot,GPRS,HSCSD,EDGE,status_3g,WLAN,Blootooth,Infrared,USB,OS,Messeging,Browser,Clock,Games,Colors,Lang_stat,Camara,Other_features,Bat_type,Bat_standby,bat_talk,Hits,Price,Quantity,Reorder_lvl,BigImg,Smallimg,Thumnail,man_name from phone_Details,manufacturer where phone_details.man_Id=manufacturer.man_iD and phoneID= '" & cstr(request.querystring("phoneID")) & "'",bcon)
    
    bcon.open
    objreader=bcmd.executereader
    objreader.read
    
    end sub
    
    sub addtocart(sender As Object, e As System.Web.UI.ImageClickEventArgs)
    
    dim prodID,man_name,transID,secID as string
    secID=session("secCode")
    transID=cstr(session.SessionID)
    prodID=request.QueryString("phoneID")
    man_name=request.QueryString("man_name")
    
    if session("userID")="" then
    response.redirect("login.aspx")
    else
    Response.Redirect("addtocart.aspx?phoneID=" & _
    ProdID & "&man_Name=" &man_name & "&transID=" &transID & "&secCode=" &secID)
    end if
    end sub
    
    
    public hits as string

</script>
<!--#include file="config.aspx" -->
<!--#include file="checklogin.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="updateHits.aspx" -->
<!--#include file="ratings.aspx" -->
<html>
<head>
    <title>GSM LANKA-View Phone Details</title>
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
</style>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
<!--
.style2 {TEXT-TRANSFORM: capitalize; COLOR: #336699; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none; font-size: 11px;}
.style3 {font-weight: bold}
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
                    <td width="7" height="769">
                    </td>
                    <td valign="top" width="783">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="96" rowspan="3">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="108" height="143">
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
                                                </tr>
                                                <!--DWLayoutTable-->
                                            </tbody>
                                        </table>
                                    </td>
                                    <td width="10" height="18">
                                    </td>
                                    <td valign="top" colspan="3">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="center" width="403" background="imagenew/detailview_bk_.gif" height="18">
                                                        <%= request.QueryString("man_name") %>: <%= request.QueryString("phoneID") %></td>
                                                    <td width="92">
                                                    </td>
                                                    <td valign="top" width="82">
                                                        <img src="<%= manPic %>" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td valign="top" width="6" rowspan="4">
                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                    <td valign="top" width="96" rowspan="3">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#eeeeee" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="102" height="675">
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="2">
                                    </td>
                                    <td width="153">
                                    </td>
                                    <td width="6">
                                    </td>
                                    <td width="420">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="115">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="3" height="6">
                                                    </td>
                                                    <td width="197">
                                                    </td>
                                                    <td width="5">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="185">
                                                    </td>
                                                    <td class="picture" valign="top" bgcolor="#ffffff">
                                                        <p>
                                                            <a href="fullview.aspx?phoneID=<%= request.QueryString(" phoneID?)%>&amp;man_Name=<%= request.QueryString("man_name")%>"&gt;<img src="phones/small/<%= cstr(objreader(" Smallimg?)) % />"
                                                            alt="<%= cstr(objreader("phoneID")) %>" width="139" height="184" border="0"&gt;</a> 
                                                        </p>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="33">
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="192">
                                                    </td>
                                                    <td valign="top">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="redfont" valign="center" align="middle" background="imagenew/bkh.gif" colspan="3" height="18">
                                                                        Rating</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="border2" valign="top" colspan="3" height="26">
                                                                        <asp:Image id="imgRatingApproval" runat="server" ImageUrl="imagenew/rater.jpg"></asp:Image>
                                                                        <asp:Image id="imgRatingBlank" runat="server" ImageUrl="imagenew/raterblank.jpg"></asp:Image>
                                                                        <asp:Label id="lblRatingCount" runat="server" cssclass="leftlink5"></asp:Label>&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" colspan="3" height="88">
                                                                        <asp:radiobuttonlist id="rblRating" runat="server" RepeatDirection="Vertical" RepeatLayout="table" CssClass="leftlink1">
                                                                            <asp:listitem Value="5">Awsum</asp:listitem>
                                                                            <asp:listitem Value="4">Good</asp:listitem>
                                                                            <asp:listitem Value="3" selected="True">Average</asp:listitem>
                                                                            <asp:listitem Value="2">Below Average</asp:listitem>
                                                                            <asp:listitem Value="1">Poor</asp:listitem>
                                                                        </asp:radiobuttonlist>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="center" align="middle" colspan="3" height="20">
                                                                        <asp:Label id="lblRating" runat="server" forecolor="#FF0000"></asp:Label>&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="77" height="29">
                                                                        &nbsp;</td>
                                                                    <td valign="top" width="108">
                                                                        <asp:imagebutton id="btnRating" onclick="btnRating_Click" runat="server" ImageUrl="buttons/rate.jpg"></asp:imagebutton>
                                                                        &nbsp;</td>
                                                                    <td width="12">
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="11">
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
                                                    <td height="18">
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="91%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="383" height="151">
                                                        <table bordercolor="#cccccc" height="50" width="419">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="78" bgcolor="#fff5ec" rowspan="3">
                                                                        <div align="center"><span class="leftlink1"><strong>GENERAL</strong></span> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" width="87" bgcolor="#fef9f5" height="15">
                                                                        Network</td>
                                                                    <td class="leftlink2" width="223" bgcolor="#fef9f5">
                                                                        <%= objreader("network") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5">
                                                                        Announced</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= cstr(objreader("date_pub")) %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Status</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("status") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="2">
                                                                        <div class="leftlink1" align="center"><strong>SIZE</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Dimensions</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("dimension") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Weight</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("weight") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="2">
                                                                        <div class="leftlink1" align="center"><strong>DISPLAY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Type</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("Disp_type") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        size</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("Disp_size") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>RINGTONES</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Type</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("rng_type") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Customization</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("custamization") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Vibration</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("vibration") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>MEMORY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Phonebook</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("phn_book") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Call records</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("call_rec") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Card slot</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("card_slot") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="8">
                                                                        <div class="leftlink1" align="center"><strong>DATA</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        GPRS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("GPRS") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        HSCSD</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("HSCSD") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        EDGE</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("EDGE") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        3G</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("status_3g") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        WLAN</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("WLAN") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Bluetooth</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("blootooth") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Infrared port</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        <%= objreader("infrared") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        USB</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("USB") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="8">
                                                                        <div class="leftlink1" align="center"><strong>FEATURES</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        oS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("OS") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Messaging</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("Messeging") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Browser</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("Browser") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Languages</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("Lang_stat") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Clock</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("Clock") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Games</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("games") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Colors</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("colors") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Camera</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("camara") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Other Features 
                                                                    </td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("Other_features") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>BATTERY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Battery</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("Bat_type") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Stand-by</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("Bat_standby") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Talk time</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2"><%= objreader("bat_talk") %></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>STOCK</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="20">
                                                                        Stock in Hand 
                                                                    </td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("Quantity") %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="20">
                                                                        Price</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= objreader("price") %>Rs</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="20">
                                                                        HITS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <%= cstr(objreader("HITS")) %></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="29">
                                                                        &nbsp;</td>
                                                                    <td class="style2" align="right" colspan="2">
                                                                        <asp:imagebutton id="cmdaddTocart" onclick="addTocart" runat="server" ImageUrl="imagenew/Addto_cart.jpg"></asp:imagebutton>
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
                                    <td height="45">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#f3f3f3" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="9" height="29">
                                                        &nbsp;</td>
                                                    <td class="toplink1" valign="center" width="403">
                                                        Disclaimer. We can not guarantee that the information on this page is 100% correct.
                                                        Read more</td>
                                                    <td width="9">
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td valign="top">
                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="7">
                    </td>
                </tr>
                <tr>
                    <td height="6">
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
