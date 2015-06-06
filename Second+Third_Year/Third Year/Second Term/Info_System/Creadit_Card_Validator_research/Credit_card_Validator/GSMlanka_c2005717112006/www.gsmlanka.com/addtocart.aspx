<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    call logincheck
    call checkPhonedetails
    call checkstatus
    call dbcon
    call fillmanu
    call fillrecept
    call scrollphone
    if session("useriD")="" then
    btnlogin.text="login"
    end if
    
    If Not isPostBack Then
    
    if session("useriD")="" then
            btnlogin.text="login"
            end if
    
    
    End If
    End Sub
    
    
    
    sub logincheck
    
    if session("userID")="" or request.QueryString("phoneId")="" or session.sessionID<>request.QueryString("transID") or request.QueryString("man_name")="" or session("seccode")<>request.QueryString("seccode") then
    
    session("checklog")= true
    response.redirect("login.aspx")
    
    end if
    end sub
    
    
    
    
    sub checkPhonedetails
    call dbcon
    mcmd=new sqlcommand("select phoneid,man_id from phone_details where phoneID='" & request.QueryString("phoneID") & "' and man_id=(select man_id from manufacturer where man_name='" & request.QueryString("man_name") & "')" ,bcon)
    bcon.open
    dr=mcmd.executereader
    If dr.HasRows = False Then
    session("invalidreq")="yes"
      response.Redirect("requesterror.aspx")
    
    End If
    end sub
    
    sub fillrecept
    dim SQLcart as string
    call dbcon
    sqlcart="select PhoneID,man_ID,price,quantity,thumnail from phone_details where phoneid='" & request.QueryString("phoneID")& "' and man_id=(select man_id from manufacturer where man_name='" & request.QueryString("man_name") & "')"
    bcmd= new sqlcommand(sqlcart,bcon)
    bcon.open
    objreader=bcmd.executereader
    objreader.read
    lblMan.text=request.QueryString("man_name")
    lblPhone.text=objreader("phoneID")
    lblprice.text=objreader("price")
    lblqty.text=objreader("quantity")
    imgpath=objreader("thumnail")
    manID=objreader("man_ID")
    objreader.close
    bcon.close
    end sub
    
    
    sub addtoDB(sender As Object, e As System.Web.UI.ImageClickEventArgs)
    dim qty as decimal
    dim totamount as decimal
    dim price as decimal
    dim checkval,qtycheck as boolean
    call dbcon
    tcmd=new sqlcommand("select transID,secCode,phoneID,userID,qty from temp_cart where transid='" & request.QueryString("transID") & "' and secCode='" & cint(request.QueryString("secCode")) & "' and phoneID='" & request.QueryString("phoneID") & "' and userID='" & session("userID") & "' ",cartcon)
    
    cartcon.open
    objreader=tcmd.executereader
    objreader.read
    dim counter,chkqty as integer
    
                If objreader.HasRows =true Then
                    checkval=true
                    counter=objreader("qty")
                    else
                    checkval=false
                    counter=0
             End If
    
    
    
    if not isnumeric(txtqty.text) then
            lblmessage.text="please enter only digits "
    
            else
            chkqty = cint(txtqty.text)+ counter
            end if
    
    if chkqty > 50 then
    qtycheck=true
    else
    qtycheck=false
    end if
    
    
    if not isnumeric(txtqty.text) then
    
    else if cint(txtqty.text) > cint(lblqty.text) then
    lblmessage.text="please insert a value within the stock limit"
    else if qtycheck=true then
    lblmessage.text="only 50 pieces on a product are allowed you have added " & counter  & " items on this and you can add " &  50-counter & " pieces more"
    
    
    else if checkval=true then
    
    lblmessage.text="Please type the quantity you need and click add."
    
    qty=cdec(txtqty.text)
    price=cdec(lblprice.text)
    totamount=qty * price
    
    call dbcon
    bcmd=new sqlcommand("update temp_cart set qty=qty+'" & qty & " ',totalamount=totalamount+'" & totamount & "'",bcon)
    bcon.open
    bcmd.executenonquery
    bcon.close
    
    session("cartison")="yes"
    response.Redirect("viewcart.aspx?transID=" &request.QueryString("transID") & "&secCode=" &cstr(session("secCode")) & "&userID=" &session("userID"))
    
    else
    
    lblmessage.text="Please type the quantity you need and click add."
    
    qty=cdec(txtqty.text)
    price=cdec(lblprice.text)
    totamount=qty * price
    
    
    
    
    call dbcon
    mcmd=new sqlcommand("insert into temp_cart(transID,seccode,userID,phoneID,man_id,price,qty,totalamount)values(@transID,@secCode,@userID,@phoneId,@man_ID,@price,@qty,@totalamount)",bcon)
    
    
    
    MCmd.Parameters.Add(New sqlParameter("@TransID", sqlDbType.Varchar,500))
    MCmd.Parameters.Add(New sqlParameter("@secCode", sqlDbType.int))
    MCmd.Parameters.Add(New sqlParameter("@userID", sqlDbType.Varchar,50))
    MCmd.Parameters.Add(New sqlParameter("@phoneID", sqlDbType.Varchar,100))
    MCmd.Parameters.Add(New sqlParameter("@man_id", sqlDbType.int))
    MCmd.Parameters.Add(New sqlParameter("@price", sqlDbType.decimal))
    MCmd.Parameters.Add(New sqlParameter("@qty", sqlDbType.int))
    MCmd.Parameters.Add(New sqlParameter("@totalamount", sqlDbType.decimal))
    
    
    
    mCmd.Parameters("@transID").Value=cstr(request.QueryString("transID"))
    mCmd.Parameters("@secCode").Value=cstr(request.QueryString("secCode"))
    mCmd.Parameters("@useriD").Value=cstr(session("userID"))
    mCmd.Parameters("@phoneId").Value=cstr(lblphone.text)
    mCmd.Parameters("@man_ID").Value=manID
    mCmd.Parameters("@price").Value=cdec(lblprice.text)
    mCmd.Parameters("@qty").Value=qty
    mCmd.Parameters("@totalamount").Value=totamount
    
    
    
    bcon.open
    mcmd.executenonquery
    bcon.close
    session("cartison")="yes"
    response.Redirect("viewcart.aspx?transID=" &request.QueryString("transID") & "&secCode=" &cstr(session("secCode")) & "&userID=" &session("userID"))
    
    end if
    
    
    
    
    end sub
    
    
    
    public manID as integer
    public imgpath as string

</script>
<!--#include file="config.aspx" -->
<!--#include file="scrollerdata.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="checklogin.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka -Shopping cart- Do you want to add this item in your cart ?</title> 
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
.style4 {color: #FF0000}
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
                                                    <td valign="top" width="541" height="422">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" background="imagenew/cart_bk.jpg" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="79" height="88">
                                                                        &nbsp;</td>
                                                                    <td width="369">
                                                                        &nbsp;</td>
                                                                    <td width="93">
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="230">
                                                                        &nbsp;</td>
                                                                    <td valign="top">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" bgcolor="#ffffff" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="top" colspan="5" height="28">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" bgcolor="#fbdca3" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" width="372" height="28">
                                                                                                        <span class="redfont">&nbsp;&nbsp;Do you want to add this item in your cart ?</span></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td width="11" height="13">
                                                                                    </td>
                                                                                    <td width="91">
                                                                                    </td>
                                                                                    <td width="9">
                                                                                    </td>
                                                                                    <td width="244">
                                                                                    </td>
                                                                                    <td width="12">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="141">
                                                                                        &nbsp;</td>
                                                                                    <td valign="top" bgcolor="#f6f1dd">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="middle" width="91" bgcolor="#f6f1dd" height="141">
                                                                                                        <img alt="<%= request.QueryString(" src="phones/thumb/<%=  imgpath  %>" phoneId?) 
                                % />"
                                                                                                        width="70" height="93"&gt;<br />
                                                                                                        <br />
                                                                                                        <span class="redfont"><%= request.QueryString("phoneId") %></span></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" width="96" bgcolor="#fff5ec" rowspan="2">
                                                                                                        <span class="leftlink">&nbsp;Brands:</span></td>
                                                                                                    <td width="6" height="17">
                                                                                                    </td>
                                                                                                    <td width="2">
                                                                                                    </td>
                                                                                                    <td valign="center" width="142" bgcolor="#fef9f5">
                                                                                                        <asp:Label id="lblMan" runat="server" font-bold="true"></asp:Label></td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="3">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" bgcolor="#fff5ec" height="20">
                                                                                                        <span class="leftlink">&nbsp;Model:</span></td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td valign="center" bgcolor="#fef9f5" colspan="2">
                                                                                                        <asp:Label id="lblPhone" runat="server" font-bold="true"></asp:Label></td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" bgcolor="#fff5ec" height="20">
                                                                                                        <span class="leftlink">&nbsp;Price:</span></td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td valign="center" bgcolor="#fef9f5" colspan="2">
                                                                                                        <asp:Label id="lblPrice" runat="server" font-bold="true"></asp:Label>&nbsp; LKR</td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" bgcolor="#fff5ec" height="20">
                                                                                                        <span class="leftlink">&nbsp;Stock: </span></td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td valign="center" bgcolor="#fef9f5" colspan="2">
                                                                                                        <asp:Label id="lblQTY" runat="server" font-bold="true"></asp:Label></td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" bgcolor="#fff5ec" height="22">
                                                                                                        <span class="leftlink">&nbsp;Quantity:</span></td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td valign="top" bgcolor="#fef9f5" colspan="2">
                                                                                                        <asp:TextBox id="txtqty" runat="server" Width="50" MaxLength="3"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="leftlink1 style4" valign="center" align="middle" bgcolor="#fff5ec" height="27">
                                                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                    <td valign="center" align="left" bgcolor="#fef9f5" colspan="2">
                                                                                                        <asp:ImageButton id="additem" onclick="addtoDB" runat="server" ImageUrl="buttons/add.jpg" Font-Size="12" Font-Bold="true"></asp:ImageButton>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="2">
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
                                                                                    <td height="25">
                                                                                    </td>
                                                                                    <td valign="center" align="middle" bgcolor="#fff5ec" colspan="3">
                                                                                        <span class="leftlink1 style4"><asp:Label id="lblmessage" runat="server" text="Please type the quantity you need and click add."></asp:Label></span></td>
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
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="102">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="9">
                                                        &nbsp;</td>
                                                    <td valign="top" width="126" rowspan="2">
                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="124" height="360">
                                                                        <!--DWLayoutEmptyCell-->&nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="69">
                                                                        &nbsp;</td>
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
