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
            ViewState("Start") = 0
            BindData
            if session("useriD")="" then
            btnlogin.text="login"
            end if
    End If
    End Sub
    
    
    
    
    Sub Next_Click(Sender As Object, E As EventArgs)
    
    
            Dim dlistcount As Integer = msglist.Items.Count
    
            intStart = ViewState("Start") + ViewState("pageSize")
            ViewState("Start") = intStart
    
        If dlistcount < ViewState("pageSize") Then
               ViewState("Start") = ViewState("Start") - ViewState("pageSize")
        End If
    
          'Call Bindlist sub and display data
         call  Binddata
    
      End Sub
    
    
    
      'Set the paging previous link
      Sub Prev_Click(Sender As Object, E As EventArgs)
    
           intStart = ViewState("Start") - ViewState("pageSize")
           ViewState("Start") = intStart
    
             If intStart <= 0 Then
               ViewState("Start") = 0
             End If
    
          'Call Bindlist sub and display data
          call Binddata
    
      End Sub
    
    
    
      'Jump back to the first page
      Sub FirstPage(Sender As Object, E As EventArgs)
    
             If intStart <= 0 Then
               ViewState("Start") = 0
             End If
    
          'Call Bindlist - show data
          call Binddata
    
      End Sub
    
    
    
    Sub BindData
    
    call dbcon
    bcon.Open()
    bcmd = New sqlCommand("select posts,userid,priviladge,joineddate,imageurl,PostID,subject,POsted,message from users,post where users.userid=post.postedby  and threadID='" & request.querystring("threadID") & "' order by post.postID ",bcon )
    
    
    
       Dim postadapter as New sqlDataAdapter(BCmd)
       Dim dts as New DataSet()
    
              intStart = ViewState("Start")
              ViewState("pageSize") = 10
    
              postadapter.Fill(dts, intStart, ViewState("pageSize"), "POstID")
    
              msglist.DataSource = dts
              msglist.DataBind()
    
    'msglist.DataSource =bcmd.ExecuteReader()
    'msglist.DataBind()
    
    
    bcon.Close()
    End Sub
    
    Sub PostClick( obj As Object, e As EventArgs )
    if session("userID")="" then
    response.redirect("login.aspx")
    else
    if (txtsubject.text="" and txtmsg.text="") or (txtsubject.text="" OR txtmsg.text="") then
    
    lblfeedback.text="please fill in the both fields"
    else
    call dbcon
    Dim InsertString as string
    Dim Message As String
    
    
    
    InsertString = "Insert Into post (Subject, postedby, posted,IP,Message,threadID) values(@subject,'" & session("userID") & "','" & cstr(now) & "','" & request.servervariables("REMOTE_ADDR") & "',@messege,'" & cint(request.querystring("threadid")) & "')"
    
    Mcmd=new sqlcommand(insertstring,bcon)
    
    mcmd.Parameters.Add(New SqlParameter("@subject", SqlDbType.VarChar, 100))
      mcmd.Parameters.Add(New SqlParameter("@messege", SqlDbType.NText))
    
    mcmd.Parameters("@subject").Value=HtmlClean(txtsubject.text)
    mcmd.Parameters("@messege").Value=smiley(Replace(UBBCparse(HtmlClean(txtmsg.text)), CStr(chr(13)), "<br>"))
    bcon.Open()
    Mcmd.ExecuteNonQuery
    bcon.Close()
    
    
    
    call updatepostcount
    call BindData
    end if
    end if
    txtsubject.Text = ""
    txtmsg.Text = ""
    
    End Sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="updatepost.aspx" -->
<!--#include file="checklogin.aspx" -->
<!--#include file="UBBC.aspx" -->
<html>
<head>
    <title>.::GSMLANKA Discussion Board::.</title> <style type="text/css">.style4 {
	FONT-SIZE: 12px
}
</style>
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
.style5 {
	font-size: 12;
	font-weight: bold;
}
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
                                                        <asp:LinkButton id="btnViewprof" runat="server" Text="View Profile"></asp:LinkButton>
                                                        &nbsp;&nbsp; 
                                                        <asp:LinkButton id="showcart" onclick="viewthecart" runat="server" CausesValidation="false"></asp:LinkButton>
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
                    <td width="4" height="406">
                        &nbsp;</td>
                    <td valign="top" width="803">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="803" height="32">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" height="344">
                                        <a href="threads.aspx?BoardID=<%=Request.QueryString(" BoardID?)%>&amp;B_Name=<%=Request.QueryString("B_Name")%>"&gt; <font size="5"><u><%=Request.QueryString("B_Name") & _
"</a></u> : <u>" & _
Request.QueryString("ThreadName") %></u></font>
                                        <asp:datalist id="msglist" runat="server" Width="100%" cellpadding="2" cellspacing="0" borderwidth="0" RepeatColumns="0" RepeatDirection="Vertical" DataKeyField="Postid">
                                            <HeaderTemplate>
                                                Messeges 
                                            </HeaderTemplate>
                                            <itemtemplate>
                                                <table width="783" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="FAFAFA" class="border2">
                                                    <!--DWLayoutTable-->
                                                    <tr>
                                                        <td width="4" height="230">
                                                            &nbsp;</td>
                                                        <td width="146" valign="top">
                                                            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                                <!--DWLayoutTable-->
                                                                <tr>
                                                                    <td width="145" height="4"></td>
                                                                </tr>
                                                                <!--DWLayoutTable-->
                                                                <tr>
                                                                    <td height="44" valign="top">
                                                                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tr>
                                                                                <td width="145" height="19" valign="middle">
                                                                                    <p class="leftlink">
                                                                                        <strong><%# Container.DataItem("UserID") %> </strong> 
                                                                                        <br />
                                                                                        <br />
                                                                                    </p>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td height="25" valign="top">
                                                                                    <span class="leftlink"><%# Container.DataItem("priviladge") %></span></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="4"></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="142" valign="top">
                                                                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tr>
                                                                                <td width="21" height="14"></td>
                                                                                <td width="100"></td>
                                                                                <td width="24"></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td height="101"></td>
                                                                                <td valign="top">
                                                                                    <img src="<%# Container.DataItem("imageurl") % / />" alt="test" width="100" height="100"
                                                                                    /></td>
                                                                                <td></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td height="27"></td>
                                                                                <td></td>
                                                                                <td></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="28" valign="top">
                                                                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tr>
                                                                                <td width="145" height="14" valign="middle" class="leftlink">
                                                                                    Joined: <%# Container.DataItem("Joineddate") %></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td height="14" valign="top">
                                                                                    <span class="leftlink">Posts: <%# Container.DataItem("posts") %> </span></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="8"></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td width="11" valign="top" class="border3">
                                                            <!--DWLayoutEmptyCell-->
                                                            &nbsp;</td>
                                                        <td width="621" valign="top">
                                                            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                                                <!--DWLayoutTable-->
                                                                <tr>
                                                                    <td width="6" height="49"></td>
                                                                    <td colspan="2" valign="top">
                                                                        <table width="100%" border="0" cellpadding="0" cellspacing="0" class="border1">
                                                                            <!--DWLayoutTable-->
                                                                            <tr>
                                                                                <td height="33" colspan="2" valign="top">
                                                                                    <strong class="redfont"><%# Container.DataItem("subject") %></strong> 
                                                                                    <br />
                                                                                </td>
                                                                                <td width="19">
                                                                                    &nbsp;</td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td width="430" height="15" valign="top" class="leftlink1">
                                                                                    &laquo; posted on <%# Container.DataItem("posted") %> &raquo;</td>
                                                                                <td width="177"></td>
                                                                                <td></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="8"></td>
                                                                    <td width="602"></td>
                                                                    <td width="12"></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="146"></td>
                                                                    <td valign="top">
                                                                        <span class="leftlink2"><%# Container.DataItem("message") %> </span></td>
                                                                    <td></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="27"></td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td height="0"></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                    </tr>
                                                </table>
                                            </itemtemplate>
                                            <footertemplate>
                                                <table >
                                                    <td valign="top" class="style4">
                                                        <span class="style5"> 
                                                        <asp:linkButton ID="lblFirst" Text="First Page" onclick="FirstPage" runat="server" />
                                                        &nbsp; | 
                                                        <asp:linkButton ID="lblPrev" Text="Previous" onclick="Prev_Click" runat="server" />
                                                        &nbsp; | 
                                                        <asp:linkButton ID="lblnext" Text="Next" onclick="Next_Click" runat="server" />
                                                        &nbsp;</span></td>
                                                </table>
                                            </footertemplate>
                                        </asp:datalist>
                                        </a></td>
                                </tr>
                                <tr>
                                    <td height="30">
                                        &nbsp;</td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="18">
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
                        <table class="border2" cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="9" height="21">
                                        &nbsp;</td>
                                    <td valign="center" width="500">
                                        To post a new message to this thread, type your message below and click Post.</td>
                                    <td width="272">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="22">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <asp:Label id="lblfeedback" runat="server"></asp:Label></td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="163">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <p>
                                            <font size="2">Subject:</font> 
                                            <br />
                                            <asp:textbox id="txtsubject" runat="server" columns="50"></asp:textbox>
                                        </p>
                                        <p>
                                            <font size="2">Message:</font> 
                                            <br />
                                            <asp:textbox id="txtmsg" runat="server" columns="50" textmode="multiline" rows="5"></asp:textbox>
                                        </p>
                                        <p>
                                            <asp:Button id="cmdpost" onclick="PostClick" runat="server" Text=" Post "></asp:Button>
                                        </p>
                                        <p>
                                        </p>
                                    </td>
                                    <td>
                                        &nbsp;</td>
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
