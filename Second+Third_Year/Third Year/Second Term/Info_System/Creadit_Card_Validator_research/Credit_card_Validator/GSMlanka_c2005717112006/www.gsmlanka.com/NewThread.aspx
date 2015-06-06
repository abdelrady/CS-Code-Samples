<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    call checkstatus
    
    
    call logincheck
    
    End Sub
    
    sub logincheck
    
    if session("userid")="" then
    session("checklog")= true
    response.redirect("login.aspx")
    
    end if
    
    
    end sub
    
    Sub PostClick( obj As Object, e As EventArgs )
    
    call dbcon
    Dim InsertThread, InsertMessage As String
    Dim GetThread, Message as string
    Dim ThreadID As Long
    Dim ThreadResult As Integer
    
    bcon.open()
    
    if  subjecttext.text="" or threadtext.text="" or messagetext.text="" then
    
    else
    InsertThread = "Insert Into Thread (TName,startedby,boardid) " & _
    "VALUES (@ThreadName,'" & session("userid") & "',@BoardID)"
    TCmd = New sqlCommand(InsertThread, BCOn)
    TCmd.Parameters.Add( _
    New sqlParameter("@ThreadName", sqlDbType.Varchar,100))
    tcmd.Parameters.Add( _
    New sqlParameter("@Boardid", sqlDbType.int))
    tcmd.Parameters("@ThreadName").Value = _
    ThreadText.Text
    tcmd.Parameters("@BoardID").Value = _
    Request.QueryString("BoardID")
    
    
    
    ThreadResult = tcmd.ExecuteNonQuery
    
    
    
    GetThread = "Select ThreadID from Thread Where TName='" & _
    ThreadText.Text & "'"
    mcmd = New sqlCommand( GetThread,Bcon)
    objreader = mCMd.ExecuteReader()
    objreader.Read
    ThreadID = objreader.Item("ThreadID")
    objreader.Close
    InsertMessage = "Insert Into Post (Subject, " & _
    "POstedby, posted, IP, Message,ThreadID) VALUES (@Subject, " & _
    "'" & session("userid") & "', '" & cstr(now) & "','" & request.servervariables("REMOTE_ADDR") & "', @Message, @ThreadID)"
    
    
    Mcmd = _
    New sqlCommand(InsertMessage, BCon)
    mcmd.Parameters.Add( _
    New sqlParameter("@Subject", sqlDbType.Varchar,100))
    
    Mcmd.Parameters.Add( _
    New sqlParameter("@Message", sqlDbType.ntext))
    
    
    Mcmd.Parameters.Add( _
    New sqlParameter("@ThreadID", sqlDBType.int))
    
    Message = MessageText.Text
    Message = smiley(Replace(UBBCparse(HtmlClean(Message)), CStr(chr(13)), "<br>"))
    MCmd.Parameters("@Subject").Value = HtmlClean(SubjectText.Text)
    MCmd.Parameters("@Message").Value = Message
    MCmd.Parameters("@ThreadID").Value = ThreadID
    MCmd.ExecuteNonQuery
    bcon.Close()
    call updatepostcount
    Response.Redirect("Threads.aspx?BoardID=" & _
    Request.QueryString("BoarDId") & _
    "&B_name=" & Request.QueryString("B_name"))
    
    
    end if
    
    
    
    
    
    End Sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="updatepost.aspx" -->
<!--#include file="checklogin.aspx" -->
<!--#include file="UBBC.aspx" -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>.::GSM LANKA Discussion Board::.</title>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">
<!--
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #cccccc;
}
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #CCCCCC;
}
-->
</style>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
<!--
.style1 {color: #FFFFFF}
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
                                                        <a class="toplink style1" href="multimedia.aspx">Multimedia</a></td>
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
                                                        <asp:LinkButton id="btnViewprof" runat="server" Text="View Profile" CausesValidation="false"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:LinkButton id="showcart" onclick="viewthecart" runat="server" CausesValidation="false"></asp:LinkButton>
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
                    <td width="8" height="283">
                        &nbsp;</td>
                    <td valign="top" width="780">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="298" height="25">
                                        &nbsp;</td>
                                    <td width="337">
                                        &nbsp;</td>
                                    <td width="145">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" colspan="2" height="222">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="center" colspan="4" height="19">
                                                        <span class="leftlink">Type your New thread details here and click submit. for UBBC<strong> help </strong>Click
                                                        here . </span></td>
                                                    <td width="12">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td width="380" height="8">
                                                    </td>
                                                    <td width="68">
                                                    </td>
                                                    <td width="7">
                                                    </td>
                                                    <td width="156">
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="2" height="35">
                                                        <font color="#336699">New Thread 
                                                        <br />
                                                        <asp:TextBox id="threadtext" runat="server" Columns="40" TextMode="SingleLine" MaxLength="150"></asp:TextBox>
                                                        </font>
                                                        <br />
                                                        <asp:requiredfieldvalidator id="checktxtname" runat="server" text="Please enter a thread name" controltovalidate="threadtext" errormessage="enter a thread name"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="2" height="35">
                                                        <font color="#336699"><span class="leftlink">Subjact</span> 
                                                        <br />
                                                        <asp:TextBox id="subjecttext" runat="server" Columns="40" TextMode="SingleLine" MaxLength="150"></asp:TextBox>
                                                        <br />
                                                        </font>
                                                        <asp:requiredfieldvalidator id="checktxtsubject" runat="server" text="Please enter a subject name" controltovalidate="subjecttext" errormessage="enter a subject name"></asp:requiredfieldvalidator>
                                                        <br />
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" colspan="2" height="63">
                                                        <label></label><span class="leftlink">Massege</span> 
                                                        <br />
                                                        <asp:TextBox id="messagetext" runat="server" Columns="60" TextMode="MultiLine" Rows="15"></asp:TextBox>
                                                        <br />
                                                        <asp:requiredfieldvalidator id="checktxtmsg" runat="server" text="messege cannot be empty" controltovalidate="messagetext" errormessage="Post cannot be empty"></asp:requiredfieldvalidator>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="24">
                                                        &nbsp;</td>
                                                    <td valign="top" colspan="2">
                                                        <asp:Button id="btnPost" onclick="PostClick" runat="server" Text="Post Thread"></asp:Button>
                                                        <font color="#336699">&nbsp; </font></td>
                                                    <td>
                                                        &nbsp;</td>
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
                                    <td class="redfont" valign="top" height="59">
                                        <strong><font face="arial"><a href="threads.aspx?BoardID=<%=Request.QueryString(" BoardID?)%>&amp;B_Name=<%=Request.QueryString("B_Name")%>"&gt;Return
                                        to <b><%=Request.QueryString("B_Name") %></b>Threads</a> 
                                        <br />
                                        <a href="Forum.aspx">Return to list of <b>Boards</b></a></font></strong></td>
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
                </tr>
                <tr>
                    <td height="59">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
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
