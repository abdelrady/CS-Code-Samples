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
    if request.QueryString("man_ID")="" then
    response.Redirect("index.aspx")
    end if
    
    
    If Not isPostBack Then
    call fillmanu
            ViewState("Start") = 0
            BindPhone
            if session("useriD")="" then
            btnlogin.text="login"
            end if
    
    End If
    call checkvalidman
    call manLogo
    End Sub
    
    
    
    Sub Next_Click(Sender As Object, E As EventArgs)
    
    
            Dim dlistcount As Integer = phonelist.Items.Count
    
            intStart = ViewState("Start") + ViewState("pageSize")
            ViewState("Start") = intStart
    
        If dlistcount < ViewState("pageSize") Then
               ViewState("Start") = ViewState("Start") - ViewState("pageSize")
        End If
    
          'Call BindPhone sub and display data
         call  BindPhone
      End Sub
    
    
    
      'Set the paging previous link
      Sub Prev_Click(Sender As Object, E As EventArgs)
    
           intStart = ViewState("Start") - ViewState("pageSize")
           ViewState("Start") = intStart
    
             If intStart <= 0 Then
               ViewState("Start") = 0
             End If
    
          'BindPhone sub and display data
          call BindPhone
    
      End Sub
    
    
    
      'Jump back to the first page
      Sub FirstPage(Sender As Object, E As EventArgs)
    
             If intStart <= 0 Then
               ViewState("Start") = 0
             End If
    
          'Call BindPhone
          call BindPhone
    
      End Sub
    
    
    
    Sub BindPhone
    
    call dbcon
    bcon.Open()
    bcmd = New sqlCommand("select PhoneID,thumnail from phone_details where man_ID='" & request.querystring("man_ID") & "' order by date_pub desc",bcon)
    
    
    
       Dim phoneadapter as New sqlDataAdapter(BCmd)
       Dim dts as New DataSet()
    
              intStart = ViewState("Start")
              ViewState("pageSize") = 24
    
              phoneadapter.Fill(dts, intStart, ViewState("pageSize"), "POstID")
    
              phonelist.DataSource = dts
              phonelist.DataBind()
    
    'msglist.DataSource =bcmd.ExecuteReader()
    'msglist.DataBind()
    bcon.Close()
    
    
    
    mandsp.text=request.QueryString("man_name")
    
    
    End Sub
    
    
    sub SelectItem(s As Object,e As DataListCommandEventArgs)
    
    Dim PhoneID, man_name As String
    phoneID = e.CommandArgument
    man_name=trim(request.QueryString("man_name"))
    
    Response.Redirect("viewPhoneDetails.aspx?phoneID=" & _
    PhoneID & "&man_Name=" &man_name)
    
    
    end sub
    
    sub checkvalidman
    call dbcon
    mcmd=new sqlcommand("select man_id,man_name from manufacturer where man_ID='" & request.QueryString("man_ID") & "' and man_name='" & request.QueryString("man_name") & "'" ,bcon)
    bcon.open
    dr=mcmd.executereader
    If dr.HasRows = False Then
    session("invalidreq")="yes"
      response.Redirect("requesterror.aspx")
    
    End If
    
    
    bcon.close
    end sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="checklogin.aspx" -->
<!--#include file="man_menu.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka - All Phones</title>
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
.style4 {TEXT-TRANSFORM: capitalize; COLOR: #336699; FONT-FAMILY: Verdana, arial, helvetica; TEXT-DECORATION: none; font-size: 10px;}
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
                                                                                <font face="Verdana" size="1">Last Upated With </font><span class="postbody"><font face="Verdana" size="1">New
                                                                                Nokia 60 Seri</font></span><span class="postbody"><font face="Verdana" size="1">sdf;g<br />
                                                                                </font></span><span class="postbody"><font face="Verdana" size="1"><img height="74" src="images/nokia-6234.gif" width="61" /></font></span><span class="postbody"><font face="Verdana" size="1"> 
                                                                                <br />
                                                                                Series games</font></span> 
                                                                                <br />
                                                                                sdfgdsfgds<br />
                                                                                jkh<br />
                                                                                ioug fg 
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
                                                    <td valign="top" colspan="3" height="18">
                                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/detailview_bk_.gif" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="redfont" valign="center" width="294" height="18">
                                                                        <asp:Label id="mandsp" runat="server" cssclass="redfont"></asp:Label>: phones</td>
                                                                    <td valign="top" width="156" bgcolor="#ffffff">
                                                                        <img src="<%= manPic %>" align="right" /></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="6">
                                                    </td>
                                                    <td valign="top" width="220" rowspan="4">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="220" height="400">
                                                                        <img height="400" alt="Banner" src="Banners/side1.gif" width="107" /></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="32">
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="3" height="23">
                                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="552" height="23">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" height="130">
                                                        <asp:DataList id="phonelist" Width="100%" cellpadding="0" cellspacing="2" RepeatColumns="6" RepeatDirection="Vertical" DataKeyField="PhoneID" OnItemCommand="SelectItem" Runat="Server">
                                                            <itemtemplate>
                                                                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#FFF7EF">
                                                                    <!--DWLayoutTable-->
                                                                    <tr>
                                                                        <td width="91" height="130" align="center" valign="middle" nowrap="nowrap" class="navtopdark99" onclick="jump(this)" onmouseover="colorOnTop(this)" onmouseout="colorOffTop2(this)">
                                                                            <p>
                                                                                <a class="picture"><img src="phones/thumb/<%# Container.DataItem("thumnail") % / />"
                                                                                alt="<%# Container.DataItem("phoneID") %>" width="70" height="93" border="0" align="top"
                                                                                class="picture"></a> 
                                                                                <br />
                                                                                <span class="style4"> 
                                                                                <asp:LinkButton cssclass="leflink1" Text='<%# Container.DataItem("phoneId") %>' CommandArgument='<%# Container.DataItem("phoneID") %>' Runat="Server" />
                                                                                </span></a> 
                                                                            </p>
                                                                        </td>
                                                                    </tr>
                                                                    <!--DWLayoutTable-->
                                                                </table>
                                                            </itemtemplate>
                                                        </asp:DataList>
                                                    </td>
                                                    <td width="19">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" width="211" height="32">
                                                        <table>
                                                            <tbody>
                                                                <tr>
                                                                    <td class="style4" valign="top">
                                                                        <span class="style5">
                                                                        <asp:linkButton id="lblFirst" onclick="FirstPage" runat="server" Text="First Page"></asp:linkButton>
                                                                        &nbsp; | 
                                                                        <asp:linkButton id="lblPrev" onclick="Prev_Click" runat="server" Text="Previous"></asp:linkButton>
                                                                        &nbsp; | 
                                                                        <asp:linkButton id="lblnext" onclick="Next_Click" runat="server" Text="Next"></asp:linkButton>
                                                                        &nbsp;</span></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="220">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
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
