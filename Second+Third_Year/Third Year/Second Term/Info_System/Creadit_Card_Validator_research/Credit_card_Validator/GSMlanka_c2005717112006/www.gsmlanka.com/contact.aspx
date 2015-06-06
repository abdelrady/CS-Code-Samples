<%@ Page Explicit="True" Language="VB" Debug="True" validaterequest="False" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    
    
    If Not isPostBack Then
    call dbcon
    call fillmanu
    call scrollphone
    End If
    End Sub
    
    sub contact(Sender as Object, e as EventArgs)
    
    Dim EmailMessage As New System.Web.Mail.MailMessage
                if txtsubject.text="" or txtmsg.text="" or txtname.text="" or txtemail.text="" then
    
                  else
                    'Smtp object to send the message
                 Dim emailSMTP As System.Web.Mail.SmtpMail
    
                 'build the mailMessage
                 EmailMessage.From = txtemail.text
                 EmailMessage.To = "mfmaneef@gmail.com"
    
                 EmailMessage.Subject = txtsubject.text
                    EmailMessage.BodyFormat = Mail.MailFormat.Html
                 EmailMessage.Body = "message from " &  htmlclean(txtname.text) & "<br><BR>" & smiley(ubbcparse(HtmlClean(txtmsg.text)))
    
    
                 emailSMTP.SmtpServer = "localhost"
    
                      emailSMTP.Send(EmailMessage)
                      'session to avoid the conformation page not viewed all the time
                      session("conMsg")="sent"
                        response.Redirect("confirm.aspx")
    end if
    end sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="scrollerdata.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="UBBC.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka - Contact us for any complaints or queries</title> 
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
                                                    <td width="783" height="18">
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
                                                    <td valign="top" width="538" height="433">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="center" bgcolor="#fbdca3" colspan="3" height="20">
                                                                        &nbsp;&nbsp;<span class="address">CONTACT US </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="41" height="10">
                                                                    </td>
                                                                    <td width="448">
                                                                    </td>
                                                                    <td width="47">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="380">
                                                                        &nbsp;</td>
                                                                    <td valign="top">
                                                                        <table cellspacing="2" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="top" width="444" height="340">
                                                                                        <table cellspacing="0" cellpadding="5" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr align="right" bgcolor="#eeeeee">
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2" height="28">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" width="257" bgcolor="#ffffff">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" width="41" bgcolor="#ffffff">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                <tr bgcolor="#eeeeee">
                                                                                                    <td class="leftlink1" valign="top" align="right" bgcolor="#ffffff" colspan="2">
                                                                                                        Subject :</td>
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2">
                                                                                                        <asp:TextBox id="txtsubject" runat="server" MaxLength="100"></asp:TextBox>
                                                                                                        <asp:RequiredFieldValidator id="ch1" runat="server" Text="*" ErrorMessage="cannot be empty" ControlToValidate="txtsubject"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr bgcolor="#eeeeee">
                                                                                                    <td class="leftlink1" valign="top" align="right" bgcolor="#ffffff" colspan="2">
                                                                                                        Message :</td>
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2">
                                                                                                        <asp:TextBox id="txtMsg" runat="server" Columns="30" TextMode="MultiLine" Width="400" MaxLength="1000" Height="50" Rows="5"></asp:TextBox>
                                                                                                        <asp:RequiredFieldValidator id="ch2" runat="server" Text="*" ErrorMessage="cannot be empty" ControlToValidate="txtsubject"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr bgcolor="#eeeeee">
                                                                                                    <td class="leftlink1" valign="top" align="right" bgcolor="#ffffff" colspan="2">
                                                                                                        Your Name :</td>
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2">
                                                                                                        <asp:TextBox id="txtname" runat="server" MaxLength="50"></asp:TextBox>
                                                                                                        <asp:RequiredFieldValidator id="ch3" runat="server" Text="*" ErrorMessage="cannot be empty" ControlToValidate="txtname"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr bgcolor="#eeeeee">
                                                                                                    <td class="leftlink1" valign="top" align="right" bgcolor="#ffffff" colspan="2">
                                                                                                        E-mail :</td>
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2">
                                                                                                        <asp:TextBox id="txtEmail" runat="server" Width="150"></asp:TextBox>
                                                                                                        <asp:RequiredFieldValidator id="ch4" runat="server" Text="*" ErrorMessage="cannot be empty" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                                                                                                        <br />
                                                                                                        <asp:RegularExpressionValidator id="EVAL" runat="server" Text="enter a valid email address" ErrorMessage="Not a valid mail" ControlToValidate="txtemail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr bgcolor="#eeeeee">
                                                                                                    <td valign="top" align="right" width="66" bgcolor="#ffffff" height="52">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" align="right" width="40" bgcolor="#ffffff">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" bgcolor="#ffffff" colspan="2">
                                                                                                        <br />
                                                                                                        <asp:Button id="submit" onclick="contact" runat="server" text="submit"></asp:Button>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="19">
                                                                                                        &nbsp;</td>
                                                                                                    <td>
                                                                                                        &nbsp;</td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="20">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" colspan="2">
                                                                                                        <asp:Label id="lblmsg" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
                                                                                                    <td>
                                                                                                        &nbsp;</td>
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
                                                                <tr>
                                                                    <td height="21">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="8">
                                                        &nbsp;</td>
                                                    <td valign="top" width="130">
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
