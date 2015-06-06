<%@ Page Language="VB" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>.::GSM LANKA Discussion Board::.</title> 
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
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="60" height="28">
                                                        <a class="toplink" href="index.html"><span class="style1">Home</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="50">
                                                        <a class="toplink" href="index.html"><span class="style1">News</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="58">
                                                        <a class="toplink" href="index.html"><span class="style1">Forums</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="68">
                                                        <a class="toplink" href="index.html"><span class="style1">Ringtone</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="72">
                                                        <a class="toplink" href="index.html"><span class="style1">Software</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="42">
                                                        <a class="toplink" href="index.html"><span class="style1">Faq</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="50">
                                                        <a class="toplink" href="index.html"><span class="style1">Links</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="80">
                                                        <a class="toplink" href="index.html"><span class="style1">Contact Us </span></a></td>
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
                                                    <td valign="top" width="203" height="18">
                                                        You are logged in as <asp:Label id="lblusertext" runat="server" font-bold="true" text="Guest"></asp:Label></td>
                                                    <td width="446">
                                                    </td>
                                                    <td valign="center" width="134">
                                                        <span class="style3">
                                                        <asp:linkButton id="btnlogin" onclick="sign" runat="server" Text="Logout"></asp:linkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:LinkButton id="btnViewprof" runat="server" Text="View Profile"></asp:LinkButton>
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
                                    <td valign="top" width="89" height="18">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="navtendark" onmouseover="colorOn(this)" onclick="jump(this)" onmouseout="colorOff(this)" valign="center" width="105" height="18">
                                                        <a class="leftlink" href="index.html">&nbsp;<span class="style1">» Nokia </span></a></td>
                                                </tr>
                                                <!--DWLayoutTable-->
                                            </tbody>
                                        </table>
                                    </td>
                                    <td width="6">
                                    </td>
                                    <td valign="top" colspan="3">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="center" width="403" background="imagenew/detailview_bk_.gif" height="18">
                                                        Nokia N73</td>
                                                    <td width="92">
                                                    </td>
                                                    <td valign="top" width="82">
                                                        <img height="17" alt="Nokia Logo" src="imagenew/nokia_sml_logo.gif" width="82" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td valign="top" width="9" rowspan="9">
                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                    <td valign="top" width="102" rowspan="6">
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
                                    <td height="10">
                                    </td>
                                    <td>
                                    </td>
                                    <td width="150">
                                    </td>
                                    <td width="6">
                                    </td>
                                    <td width="421">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="197">
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#f3f3f3" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="5" height="6">
                                                    </td>
                                                    <td width="141">
                                                    </td>
                                                    <td width="5">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="185">
                                                    </td>
                                                    <td class="picture" valign="top" bgcolor="#ffffff">
                                                        <p>
                                                            <a href="login.aspx"></a><a href="login.aspx"><img height="184" alt="6600" src="imagenew/nokia-n73.gif" width="139" border="0" /></a> 
                                                        </p>
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
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" rowspan="5">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="421" height="151">
                                                        <table bordercolor="#cccccc" height="50" width="421">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="73" bgcolor="#fff5ec" rowspan="3">
                                                                        <div align="center"><span class="leftlink1"><strong>GENERAL</strong></span> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" width="89" bgcolor="#fef9f5" height="15">
                                                                        Network</td>
                                                                    <td class="leftlink2" width="243" bgcolor="#fef9f5">
                                                                        UMTS / GSM 850 / 900 / 1800 / 1900</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5">
                                                                        Announced</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        2006, April</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Status</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        Coming Soon</td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="2">
                                                                        <div class="leftlink1" align="center"><strong>SIZE</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Dimensions</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        110 x 49 x 19 mm 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Weight</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        116 g</td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="2">
                                                                        <div class="leftlink1" align="center"><strong>DISPLAY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Type</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        TFT, 256K colors 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        size</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        240 x 320 pixels, 36 x 48 mm 
                                                                        <br />
                                                                        - Downloadable themes 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>RINGTONES</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Type</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        Polyphonic (64 channels), MP3 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Customization</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        Download 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Vibration</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        Yes 
                                                                        <br />
                                                                        - 3D sound stereo speakers 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>mEMORY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Phonebook</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        yes</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Call records</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        yes</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Card slot</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        miniSD, hot swap 
                                                                        <br />
                                                                        - 42 MB shared memory 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="8">
                                                                        <div class="leftlink1" align="center"><strong>DATA</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        GPRS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Class 10 (4+1/3+2 slots), 32 - 48 kbps</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        HSCSD</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">No</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        EDGE</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Class 10, 236.8 kbps</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        3G</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Yes, 384 kbps</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        WLAN</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">No</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Bluetooth</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Yes, v2.0 </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Infrared port</td>
                                                                    <td class="leftlink2" bgcolor="#fef9f5">
                                                                        Yes</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        USB</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Yes,</span> v2.0 
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="6">
                                                                        <div class="leftlink1" align="center"><strong>FEATURES</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        oS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Symbian OS 9.1, S60 3rd edition </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Messaging</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">SMS, MMS, Email, Instant Messaging </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Browser</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">WAP 2.0/xHTML, HTML</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Games</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Yes + Java downloadable</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Colors</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Silver Grey/Deep Plum, Frost White/Metallic Red </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Camera</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        3.2 MP, 2048x1536 pixels, Carl Zeiss optics, autofocus, video(CIF), flash; secondary
                                                                        VGA video call camera 
                                                                        <br />
                                                                        - Java MIDP 2.0<br />
                                                                        - Push to talk<br />
                                                                        - Video calling and download<br />
                                                                        - MP3/AAC/MPEG4 player<br />
                                                                        - T9<br />
                                                                        - Stereo FM radio<br />
                                                                        - Voice command/dial<br />
                                                                        - PIM including calendar, to-do list and printing<br />
                                                                        - Photo/video editor</td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="3">
                                                                        <div class="leftlink1" align="center"><strong>BATTERY</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" valign="top" bgcolor="#fef9f5" height="15">
                                                                        Battery</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Standard battery, Li-Ion 1100 mAh<br />
                                                                        (BP-6M ) </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Stand-by</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Up to 350 h</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Talk time</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <span class="leftlink2">Up to 6 h </span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top" bgcolor="#fff5ec" rowspan="4">
                                                                        <div class="leftlink1" align="center"><strong>STOCK</strong> 
                                                                        </div>
                                                                    </td>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Stock in Hand 
                                                                    </td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        Price</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" bgcolor="#fef9f5" height="15">
                                                                        HITS</td>
                                                                    <td class="leftlink1" bgcolor="#fef9f5">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style2" colspan="2" height="15">
                                                                        <div align="right"><img height="27" alt="Add to Cart" src="imagenew/Addto_cart.jpg" width="115" /> 
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
                                    <td height="8">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="208">
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#f3f3f3" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont style1" valign="center" align="middle" width="150" bgcolor="#ffcc00" height="22">
                                                        Voting results</td>
                                                </tr>
                                                <tr>
                                                    <td height="186">
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="234">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="150">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" rowspan="3">
                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#dbe8fd" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="102" height="186">
                                                        &nbsp;</td>
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
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="29">
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
