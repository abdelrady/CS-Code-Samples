﻿<%@ Page Explicit="True" Language="VB" Debug="True" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    if session("invalidreq")="" then
    response.Redirect("index.aspx")
    end if
    
    
    
    End Sub

</script>
<html>
<head>
    <title>GSM Lanka - ERROR!</title>
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
.style6 {color: #CC0000; font-weight: bold; font-size: 12px; }
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
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="783" height="134">
                                        <img height="134" alt="Banner" src="imagenew/main_ban.jpg" width="783" /></td>
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
                    <td width="7" height="337">
                    </td>
                    <td valign="top" width="783">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="154" height="105">
                                        &nbsp;</td>
                                    <td width="491">
                                        &nbsp;</td>
                                    <td width="138">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="62">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <div align="center"><span class="style6">Invalid request!! 
                                            <br />
                                            Please check the link you requested..</span><span class="redfont"> 
                                            <br />
                                            </span><span class="style6">or</span><span class="redfont"> <a href="Index.aspx">click
                                            here </a></span><span class="style6">to go to the home page.<br />
                                            thank you!. </span>
                                            <br />
                                            <br />
                                        </div>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="187">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="7">
                    </td>
                </tr>
                <tr>
                    <td height="7">
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
