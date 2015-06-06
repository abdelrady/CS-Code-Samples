<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    call checkstatus
    If Not isPostBack Then
    call dbcon
    BCmd = New sqlCommand("Select * from Board order by b_order asc",Bcon )
    Bcon.Open()
    BList.DataSource = BCmd.ExecuteReader()
    BList.DataBind()
    BCon.Close()
    End If
    End Sub
    
    Sub SelectBoard(s As Object, _
    e As DataListCommandEventArgs)
    
    Dim BoardID,B_Name As String
    B_Name = e.CommandArgument
    BoardID = _
    BList.DataKeys.Item( _
    e.Item.ItemIndex).toString()
    Response.Redirect("Threads.aspx?BoardId=" & _
    BoardID & "&B_Name=" & B_name)
    End Sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="checklogin.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>.::GSM LANKA Discussion Board::.</title> 
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">

.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #cccccc;
}
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #CCCCCC;
}

</style>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <style type="text/css">

.style1 {color: #0066CC}

body {
	background-color: #FFFFFF;
	background-image: url();
}
.style3 {font-weight: bold}
.style4 {color: #FFFFFF}
</style>
</head>
<body>
    <form runat="Server">
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
                                                        <a class="toplink" href="index.aspx"><span class="style4">Home</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="55">
                                                        <a class="toplink" href="signup.aspx"><span class="style4">Register</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="58">
                                                        <a class="toplink" href="forum.aspx"><span class="style4">Forums</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="72">
                                                        <a class="toplink" href="orderstatus.aspx"><span class="style4">Track Order </span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="66">
                                                        <a class="toplink style4" href="multimedia.aspx">Multimedia</a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="42">
                                                        <a class="toplink" href="faq.aspx"><span class="style4">Faq</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="50">
                                                        <a class="toplink" href="about.aspx"><span class="style4">About</span></a></td>
                                                    <td class="navtopdark1" onmouseover="colorOnTop(this)" onclick="jump(this)" onmouseout="colorOffTop(this)" valign="center" nowrap="nowrap" align="middle" width="80">
                                                        <a class="toplink" href="contact.aspx"><span class="style4">Contact Us </span></a></td>
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
                    <td height="7">
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
                    <td width="8" height="334">
                    </td>
                    <td valign="top" width="781">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="798" height="50">
                                        <asp:DataList id="Blist" Width="100%" cellpadding="2" cellspacing="0" borderwidth="1" RepeatColumns="0" RepeatDirection="Vertical" DataKeyField="BoardID" OnItemCommand="SelectBoard" Runat="Server">
                                            <HeaderTemplate>
                                                Discussion Boards 
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFCC00" class="border1">
                                                    <tr>
                                                        <td width="798" height="50" height="48" valign="middle" class="navtendark" onclick="jump(this)" onmouseover="colorOn(this)" onmouseout="colorOff(this)">
                                                            <a class="leftlink" >&nbsp;&raquo;</font></strong></font> 
                                                            <asp:LinkButton Font-Bold="true" font-size="10" Text='<%# Container.DataItem("B_name") %>' CommandArgument='<%# Container.DataItem("B_Name") %>' Runat="Server" />
                                                            </a> 
                                                            <br />
                                                            </strong><span class="th style1">&nbsp;&raquo;<a class="leftlink"></a></font></strong></font><%# Container.DataItem("B_Des") %></span> 
                                                            <br />
                                                            </p>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </Itemtemplate>
                                            <footertemplate>
                                                <marquee>Welcome to .::GSMLANKA Discussion Board::. 
                                                </marquee>
                                            </footertemplate>
                                        </asp:DataList>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="8">
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
