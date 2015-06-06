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
    call Getamount
    if session("useriD")="" then
    btnlogin.text="login"
    end if
    
    
    If Not isPostBack Then
    call dbcon
    
    if session("useriD")="" then
            btnlogin.text="login"
            end if
    
    End If
    lblip.text=request.servervariables("REMOTE_ADDR")
    End Sub
    
    
    sub logincheck
    
    if session("userID")="" or session("cartison")="" or session.sessionID<>request.QueryString("transID") or session("seccode")<>request.QueryString("seccode") or session("cartison")="" then
    
    session("checklog")= true
    response.redirect("requesterror.aspx")
    
    end if
    
    
    end sub
    
    sub Getamount
    dbcon
    mcmd=new sqlcommand("select sum(totalamount) as finaltotal from temp_cart where transiD='"& session.SessionID &"' and secCode='"& request("secCode") & "' and userID='"& session("userID") & "' ",bcon)
    bcon.open
    objreader=mcmd.executereader
    objreader.read
    
    totalamount=objreader("finaltotal")
    lblfinalprice.text=totalamount & " LKR"
    objreader.close
    bcon.close
    end sub
    
    sub savedata(sender As Object, e As System.Web.UI.ImageClickEventArgs)
    call ordernumgen
    
    orderID="ORD" & cstr(ord) & session("userID")
    session("orderID")=cstr(orderID)
    dim xdate as string
    
    xdate= txtmm.text & "/" & txtYYYY.text
    If Not IsDate(xdate) then
                    lbldate.text="Invalid date"
                    lbldate.visible=true
    else if (DateDiff(DateInterval.Day, CDate(Now), CDate(xdate)))< 7 then
    lbldate.text="card is expired or expires within 7 days"
    lbldate.visible=true
    
    else if txtcardno.text.length< 15 then
    lblcardVal.text="*card number should be atleast 15 digits"
    lblcardval.visible=true
    else
    tcmd= new sqlcommand("insert into payments(orderID,userID,amount,card_type,card_holder,card_secno,card_no,exp_date,IP,Ord_date,TP,Deladdr,status)values(@orderID,@userID,@amount,@card_type,@card_holder,@card_secno,@card_no,@exp_date,@IP,@ord_date,@tp,@Deladdr,@status)",bcon)
    
    TCmd.Parameters.Add(New sqlParameter("@orderID", sqlDbType.Varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@userID", sqlDbType.Varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@amount", sqlDbType.decimal))
    TCmd.Parameters.Add(New sqlParameter("@card_type", sqlDbType.Varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@card_holder", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@card_secno", sqlDbType.int))
    TCmd.Parameters.Add(New sqlParameter("@card_no", sqlDbType.Varchar,100))
    TCmd.Parameters.Add(New sqlParameter("@exp_date", sqlDbType.datetime))
    TCmd.Parameters.Add(New sqlParameter("@IP", sqlDbType.char,200))
    TCmd.Parameters.Add(New sqlParameter("@ord_date", sqlDbType.datetime))
    TCmd.Parameters.Add(New sqlParameter("@TP", sqlDbType.varchar,50))
    TCmd.Parameters.Add(New sqlParameter("@Deladdr", sqlDbType.Varchar,500))
    TCmd.Parameters.Add(New sqlParameter("@Status", sqlDbType.Varchar,10))
    
    TCmd.Parameters("@orderID").Value=orderID
    TCmd.Parameters("@userID").Value=session("userID")
    TCmd.Parameters("@amount").Value=totalamount
    TCmd.Parameters("@card_type").Value=cboCardtyp.selecteditem.text
    TCmd.Parameters("@card_holder").Value=txtCardhol.text
    TCmd.Parameters("@card_secno").Value=cint(txtSeccode.text)
    TCmd.Parameters("@card_no").Value=txtcardno.text
    TCmd.Parameters("@exp_date").Value=cdate(xdate)
    TCmd.Parameters("@IP").Value=request.ServerVariables("REMOTE_ADDR")
    TCmd.Parameters("@ord_date").Value=cdate(now)
    TCmd.Parameters("@TP").Value=txtPhnno.text
    TCmd.Parameters("@Deladdr").Value=txtDeladd.text
    TCmd.Parameters("@status").Value="No"
    bcon.open
    tcmd.executenonquery
    bcon.close
    bcon.open
    mcmd=new sqlcommand("update ordGen set ordernumber=ordernumber+1",bcon)
    mcmd.executenonquery
    bcon.close
    call dataTopermenent
    call updateqty
    call deltemp
    call sendnotification
    call checkreOrder
    response.Redirect("paymentsuccess.aspx?transID=" &request.QueryString("transID") & "&secCode=" &cstr(session("secCode")))
    end if
    
    
    end sub
    
    
    sub dataTopermenent
    
    call dbcon
    
    
    
    bcmd=new sqlcommand("select phoneId,qty,totalamount from temp_cart where transId='" & session.SessionID & "' and userID='" & session("userID") & "' and  secCode='" & request.QueryString("secCode") & "' ",bcon)
    bcon.open
    objreader = BCmd.ExecuteReader
    
    while objreader.read
                  cartcon.open()
    
                 Tcmd = New SqlCommand("insert into ordertable(OrderID,userID,phoneID,ord_quantity,subtotal)values('" & orderID & "','" & session("userID") &"','" & objreader("phoneID") & "','" & objreader("qty") & "','" & objreader("totalamount") & "')",cartCon)
                 Tcmd.ExecuteNonQuery()
                 cartCon.Close()
    
    end while
    bcon.close
    
    end sub
    
    
    sub deltemp
    
    call dbcon
    
    pcmd=new sqlcommand("delete from temP_cart where transID='" & session.SessionID & "' and secCode='" & session("secCode") & "' and userid='" & session("userId") & "'",bcon)
    bcon.open
    pcmd.executenonquery
    bcon.close
    session("cartisOn")=""
    end sub
    
    
    'generate ordernumber
    sub ordernumgen
    dbcon
    mcmd=new sqlcommand("select ordernumber from ordgen",bcon)
    bcon.open
    dr=mcmd.executereader
    dr.read
    ord=dr("ordernumber")
    dr.close
    bcon.close
    
    end sub
    public orderID as string
    public ord as integer
    public totalamount as decimal
    
    
    sub sendnotification'user
    call dbcon
    dim usermail as string
    pcmd=new sqlcommand("select email from users where userID='" & session("userID") & "'",cartCon)
    cartcon.open
    dr=pcmd.executereader
    dr.read
    usermail=dr("email")
    session("cusemail")=usermail
    Dim EmailMessage As New System.Web.Mail.MailMessage
    
                    'Smtp object to send the message
                 Dim emailSMTP As System.Web.Mail.SmtpMail
    
                 'build the mailMessage
                 EmailMessage.From = "noreply@azmil.com"
                 EmailMessage.To = usermail
    
                 EmailMessage.Subject = "transaction details	"
                    EmailMessage.BodyFormat = Mail.MailFormat.Html
                 EmailMessage.Body = "Dear <b> " & session("userId") & " </b>, <p>thank you for purchasing at GSMlanka your transaction details are as follows:<BR>OrderID:<b>" & orderID & " </B>    <br>Status:success<br><br>thank you for visiting www.azmil.com.keep in touch<br>thank you<br>gsmlanka<br><br>please check your order stats at www.azmil.com/trackorder.aspx<br>p:s you are recieving this mail because you are a member of the website located at www.azmil.com "
    
    
    
                 emailSMTP.SmtpServer = "localhost"
    
                      emailSMTP.Send(EmailMessage)
    
    end sub
    
    
    
    sub updateqty
    
    
    call dbcon
    
    mcmd=new sqlcommand("select phoneID,qty from temp_cart  where transId='" & session.SessionID & "' and userID='" & session("userID") & "' and  secCode='" & request.QueryString("secCode") & "' ",bcon)
    bcon.open
    cdr=mcmd.executereader
    
    while cdr.read
    
    tcmd=new sqlcommand("update phone_details set quantity=quantity-'" & cdr("qty") & "' where phoneID='" & cdr("phoneID") & " '",cartcon)
    cartcon.open
    tcmd.executenonquery
    cartcon.close
    end while
    
    bcon.close
    end sub
    
    
    sub checkreOrder
    call dbcon
    
    mcmd=new sqlcommand("select phoneID from phone_details where reorder_lvl>quantity",bcon)
    bcon.open
    tempdr=mcmd.executereader
    
    if tempdr.hasrows=true then
    maillevel  ="phones reached re-order level"
    while tempdr.read
    
    maillevel= maillevel & "<br>" & tempdr("phoneID")  & "<br>"
    call emailreorder
    end while
    bcon.close
    end if
    
    end sub
    
    sub emailreorder
    Dim EmailLVL As New System.Web.Mail.MailMessage
    
                    'Smtp object to send the message
                 Dim emailSMTP As System.Web.Mail.SmtpMail
    
                 'build the mailMessage
                 EmailLVL.From = "noreply@azmil.com"
                 EmailLVL.To = "mfmaneef@gmail.com"
    
                 EmailLVL.Subject = "Phones in need"
                    EmailLVL.BodyFormat = Mail.MailFormat.Html
                 EmailLVL.Body = maillevel
    
    
    
                 emailSMTP.SmtpServer = "localhost"
    
                      emailSMTP.Send(EmailLVL)
    
    end sub
    
    
    
    
    
    
    public maillevel as string

</script>
<!--#include file="config.aspx" -->
<!--#include file="scrollerdata.aspx" -->
<!--#include file="man_menu.aspx" -->
<!--#include file="checklogin.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka - your online mobile shop,discussion forum and support for mobile
    users</title> 
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
.style8 {color: #336699}
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
                                                    <td width="233">
                                                        &nbsp;</td>
                                                    <td valign="center" align="right" width="347">
                                                        <span class="style3">
                                                        <asp:LinkButton id="btnViewprof" runat="server" Text="View Profile" CausesValidation="false"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:LinkButton id="showcart" runat="server" CausesValidation="false"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:linkButton id="btnlogin" onclick="sign" runat="server" CausesValidation="false"></asp:linkButton>
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
                                                    <td valign="top" colspan="2" height="132">
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
                                                    <td width="73" height="10">
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
                                                    <td valign="top" colspan="2" height="198">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" colspan="3" height="192">
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
                                                                </tr>
                                                                <tr>
                                                                    <td width="12" height="6">
                                                                    </td>
                                                                    <td valign="top" width="32">
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
                                                                    <td width="56">
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
                                    <td valign="top" width="676">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="537" height="433">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="537" height="433">
                                                                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td class="address" valign="center" bgcolor="#fbdca3" colspan="5" height="18">
                                                                                        &nbsp;&nbsp;CHECK OUT</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td width="1" height="14">
                                                                                    </td>
                                                                                    <td width="137">
                                                                                    </td>
                                                                                    <td width="293">
                                                                                    </td>
                                                                                    <td width="55">
                                                                                    </td>
                                                                                    <td width="49">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="20">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td class="leftlink" valign="center" align="right" width="120" height="20">
                                                                                                        Amount :</td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="bottom" width="98" bgcolor="#f3f3f3" height="20">
                                                                                                        <span class="redfont"><asp:Label id="lblfinalprice" runat="server"></asp:Label></span></td>
                                                                                                    <td width="144">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                    <td>
                                                                                        &nbsp;</td>
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
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" width="120" height="20">
                                                                                                        <p class="leftlink">
                                                                                                            Credit Card Type : 
                                                                                                        </p>
                                                                                                    </td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top" colspan="2">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="121" height="22">
                                                                                                        <asp:DropDownList id="cboCardtyp" runat="server">
                                                                                                            <asp:ListItem value="MasterCard">Master Card</asp:ListItem>
                                                                                                            <asp:ListItem value="Visa">Visa</asp:ListItem>
                                                                                                            <asp:ListItem value="AmericanExpress">American Express</asp:ListItem>
                                                                                                            <asp:ListItem value="SampathNet">SampathNet</asp:ListItem>
                                                                                                        </asp:DropDownList>
                                                                                                    </td>
                                                                                                    <td valign="center" align="middle" width="193">
                                                                                                        <img height="18" alt="cards logo" src="imagenew/creditcardlogos.jpg" width="133" /></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;</td>
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
                                                                                <tr>
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" width="120" height="20">
                                                                                                        <p class="leftlink">
                                                                                                            Credit Card No : 
                                                                                                        </p>
                                                                                                    </td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="242" height="22">
                                                                                                        <asp:TextBox id="txtcardno" runat="server" MaxLength="16"></asp:TextBox>
                                                                                                        <asp:requiredfieldvalidator id="chc" runat="server" text="*" errormessege="field cannot be blank" Font-Size="12" controltovalidate="txtcardno" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                        <br />
                                                                                                        <asp:RegularExpressionValidator id="chcardNo" runat="server" Text="* Digits only" ControlToValidate="txtcardNO" ErrorMessage="digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                                                                                        <asp:Label id="lblcardVal" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
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
                                                                                <tr>
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td width="121" height="6">
                                                                                                    </td>
                                                                                                    <td width="16">
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" height="20">
                                                                                                        <p class="leftlink">
                                                                                                            Security Code : 
                                                                                                        </p>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="bottom" width="242" height="34">
                                                                                                        <asp:TextBox id="txtSeccode" runat="server" Columns="4" Width="20" MaxLength="4" Height="20"></asp:TextBox>
                                                                                                        <img height="18" alt="Security code" src="imagenew/Securitycode.jpg" width="32" /> 
                                                                                                        <asp:requiredfieldvalidator id="chsec2" runat="server" text="*" errormessege="field cannot be blank" Font-Size="12" controltovalidate="txtsecCode" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                        <br />
                                                                                                        <asp:RegularExpressionValidator id="chsec" runat="server" Text="* Digits only" ControlToValidate="txtsecCode" ErrorMessage="digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                                                                                    </td>
                                                                                                    <td width="41">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
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
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" width="120" height="20">
                                                                                                        <span class="leftlink">Card Holder :</span></td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="242" height="22">
                                                                                                        <asp:TextBox id="txtCardhol" runat="server"></asp:TextBox>
                                                                                                        <asp:requiredfieldvalidator id="chname" runat="server" text="*" errormessege="field cannot be blank" Font-Size="12" controltovalidate="txtcardhol" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
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
                                                                                <tr>
                                                                                    <td height="34">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td width="120" height="14">
                                                                                                    </td>
                                                                                                    <td width="15">
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" height="20">
                                                                                                        <span class="leftlink">Expiration Date :</span></td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top" colspan="3" rowspan="2">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="361" height="57">
                                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td class="style8" valign="top" width="19" height="12">
                                                                                                                        MM</td>
                                                                                                                    <td width="4">
                                                                                                                    </td>
                                                                                                                    <td class="style8" valign="top" width="74">
                                                                                                                        &nbsp;&nbsp; YYYY</td>
                                                                                                                    <td width="263">
                                                                                                                    </td>
                                                                                                                    <td width="6">
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
                                                                                                                    <td valign="top" colspan="4" height="44">
                                                                                                                        <asp:TextBox id="txtMm" runat="server" Columns="2" Width="20" MaxLength="2" Height="20"></asp:TextBox>
                                                                                                                        <asp:requiredfieldvalidator id="chMM" runat="server" text="*" errormessege="*" Font-Size="12" controltovalidate="txtMM" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                                        <span>
                                                                                                                        <asp:TextBox id="txtYyyy" runat="server" Columns="4" Width="50" MaxLength="4" Height="20"></asp:TextBox>
                                                                                                                        <asp:requiredfieldvalidator id="chYYYY" runat="server" text="*" errormessege="*" Font-Size="12" controltovalidate="txtyyyy" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                                        <asp:Label id="lbldate" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></span></td>
                                                                                                                    <td>
                                                                                                                        &nbsp;</td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                    <td width="27">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="23">
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="20">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" width="120" height="20">
                                                                                                        <span class="leftlink">Delivery Address :</span></td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top" colspan="2" rowspan="2">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="272" height="35">
                                                                                                        <asp:TextBox id="txtDeladd" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                                                                        <asp:requiredfieldvalidator id="chaddr" runat="server" text="*" errormessege="field cannot be blank" Font-Size="12" controltovalidate="txtdeladd" Font-Bold="true"></asp:requiredfieldvalidator>
                                                                                                    </td>
                                                                                                    <td width="37">
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="15">
                                                                                    </td>
                                                                                    <td>
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
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="center" align="right" width="120" height="20">
                                                                                                        <span class="leftlink">Phone No :</span></td>
                                                                                                    <td width="15">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td valign="top" width="206" height="20">
                                                                                                        <asp:TextBox id="txtPhnno" runat="server"></asp:TextBox>
                                                                                                        <asp:RegularExpressionValidator id="chphn" runat="server" Text="* Digits only" ControlToValidate="txtphnNo" ErrorMessage="digits only" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                                                                                                    </td>
                                                                                                    <td width="36">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="22">
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="60">
                                                                                    </td>
                                                                                    <td valign="top" colspan="4">
                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                            <!--DWLayoutTable-->
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td width="56" height="27">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="149">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="top" width="151">
                                                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                                                            <!--DWLayoutTable-->
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td valign="top" width="74" height="27">
                                                                                                                        <asp:ImageButton id="cmdbuy" onclick="savedata" runat="server" ImageUrl="buttons/submit.jpg"></asp:ImageButton>
                                                                                                                    </td>
                                                                                                                    <td width="40">
                                                                                                                        &nbsp;</td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                    <td width="129">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="49">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td height="33">
                                                                                                        &nbsp;</td>
                                                                                                    <td valign="center" align="middle" colspan="3">
                                                                                                        <br />
                                                                                                        <br />
                                                                                                        Your IP address is <asp:Label id="lblIP" runat="server" cssclass="redfont"></asp:Label>.every
                                                                                                        processes in the site is monitored to avoid credit card fourge</td>
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
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="8">
                                                        &nbsp;</td>
                                                    <td valign="top" width="131">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="top" width="131" height="298">
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
                                                                    <td height="6">
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
