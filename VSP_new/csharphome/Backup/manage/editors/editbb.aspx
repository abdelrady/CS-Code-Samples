<%@ Page language="c#" Codebehind="editbb.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.editbb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Message Board - Edit Message</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<script language="javascript" type="text/javascript"> <!--			
function storeCaret (textEl) {
	if (textEl.createTextRange)
		textEl.caretPos = document.selection.createRange().duplicate();
}

function DoSmilie(addSmilie) {
	var revisedMessage;
	var currentMessage = document.replier.message.value;
	revisedMessage = currentMessage+addSmilie;
	document.replier.message.value=revisedMessage;
	document.replier.message.focus();
	return;
}

function insertAtCaret (textEl, text) {
	if (textEl.createTextRange && textEl.caretPos) {
		var caretPos = textEl.caretPos;
		caretPos.text =
			caretPos.text.charAt(caretPos.text.length - 1) == ' ' ?
			text + ' ' : text;
	} else {
		textEl.value  = textEl.value + text; // for non MSIE browsers just append it
	}

	return true;
}

function InsertUrl() {
	var url = prompt("Type your url you want to link to", "http://");
	if (url == null) { return; }
	
	var displaytext = prompt("Type the text you want to display your url as", "web page");
	if (displaytext == null) { displaytext = url; }
	
	insertAtCaret(document.Form1.txtBody, ' ' + "[URL]" + url + "[URLX]" + displaytext + "[/URL]" + ' ');
	document.Form1.txtBody.focus();
	
	return true;
}

function InsertImage() {
	var url = prompt("Type your url you want your image to link to", "http://");
	if (url == null) { return; }
	
	
	insertAtCaret(document.Form1.txtBody, ' ' + "[IMG]" + url + "[/IMG]" + ' ');
	document.Form1.txtBody.focus();
	
	return true;
}  //--></script>
			<!-- #include virtual="../../header.inc" -->
			<HR width="100%" SIZE="1">
			<p>
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD width="15%" vAlign="top">
							<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
							<P><STRONG>Welcome<BR>
									<%= Session["User_Name"] %>
									!</STRONG></P>
							<% } %>
							<asp:Literal id="liLinks" runat="server"></asp:Literal>
						</TD>
						<TD vAlign="top">
							<H3>Edit Message</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P>
								<TABLE id="Table3" style="HEIGHT: 169px" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD style="WIDTH: 74px; HEIGHT: 29px">Subject</TD>
										<TD>
											<asp:textbox id="txtSubject" runat="server" MaxLength="255" Width="243px"></asp:textbox>&nbsp;Id:
											<asp:TextBox id="txtId" runat="server" Width="27px" ReadOnly="True"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 74px; HEIGHT: 29px">Post icon</TD>
										<TD>
											<INPUT type="radio" value="1" name="msg_icon"> <IMG alt="Icon 1" src="../../images/icons/icon1.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="2" name="msg_icon"> <IMG alt="Icon 2" src="../../images/icons/icon2.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="3" name="msg_icon"> <IMG alt="Icon 3" src="../../images/icons/icon3.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="4" name="msg_icon"> <IMG alt="Icon 4" src="../../images/icons/icon4.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="5" name="msg_icon"> <IMG alt="Icon 5" src="../../images/icons/icon5.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="6" name="msg_icon"> <IMG alt="Icon 6" src="../../images/icons/icon6.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="7" name="msg_icon"> <IMG alt="Icon 7" src="../../images/icons/icon7.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="8" name="msg_icon"> <IMG alt="Icon 8" src="../../images/icons/icon8.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="9" name="msg_icon"> <IMG alt="Icon 9" src="../../images/icons/icon9.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<BR>
											<INPUT type="radio" value="10" name="msg_icon"> <IMG alt="Icon 10" src="../../images/icons/icon10.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="11" name="msg_icon"> <IMG alt="Icon 11" src="../../images/icons/icon11.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="12" name="msg_icon"> <IMG alt="Icon 12" src="../../images/icons/icon12.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="13" name="msg_icon"> <IMG alt="Icon 13" src="../../images/icons/icon13.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="13" name="msg_icon"> <IMG alt="Icon 13" src="../../images/icons/icon13.gif" align="middle">&nbsp;&nbsp;&nbsp;&nbsp;
											<INPUT type="radio" value="<%= strIcon %>" name="msg_icon" CHECKED> <IMG alt="Current Icon" src="../../images/icons/icon<%= strIcon %>.gif" align="middle">&nbsp;<STRONG>Current</STRONG>&nbsp;&nbsp;&nbsp;</TD>
									</TR>
									<!-- <INPUT type="radio" CHECKED value="<%= strIcon %>" name="msg_icon"> <IMG alt="Current Icon" src="../../images/icons/icon<%= strIcon %>.gif" align="middle">&nbsp;Current 
											Icon -->
									<TR>
										<TD style="WIDTH: 74px" vAlign="center" colSpan="1" rowSpan="1">Simily</TD>
										<TD><A onclick="insertAtCaret(document.Form1.txtBody, ' :) '); document.Form1.txtBody.focus();" href="javascript:void(0)"><IMG alt="Smile" src="../../images/icons/smile.gif" border="0"></A>
											&nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :( '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Frown" src="../../images/icons/frown.gif" border="0"></A> &nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :o '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Embarrassed" src="../../images/icons/redface.gif" border="0"></A> 
											&nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :D '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Big Grin" src="../../images/icons/biggrin.gif" border="0"></A> &nbsp;
											<A onclick="insertAtCaret(document.Form1.txtBody, ' ;) '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Wink" src="../../images/icons/wink.gif" border="0"></A> &nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :p '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Razz" src="../../images/icons/tongue.gif" border="0"></A>&nbsp;&nbsp;
											<A onclick="insertAtCaret(document.Form1.txtBody, ' :cool: '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Cool" src="../../images/icons/cool.gif" border="0"></A> &nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :rolleyes: '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Roll Eyes" src="../../images/icons/rolleyes.gif" border="0"></A> &nbsp;
											<A onclick="insertAtCaret(document.Form1.txtBody, ' :mad: '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Mad" src="../../images/icons/mad.gif" border="0"></A> &nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :eek: '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG alt="Eek!" src="../../images/icons/eek.gif" border="0"></A> &nbsp; <A onclick="insertAtCaret(document.Form1.txtBody, ' :confused: '); document.Form1.txtBody.focus();" href="javascript:void(0)">
												<IMG height="22" alt="Confused" src="../../images/icons/confused.gif" width="15" border="0"></A></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 74px" vAlign="center">Control's</TD>
										<TD>&nbsp;&nbsp;<A onclick="InsertUrl();" href="javascript:void(0)">Link Tag</A>&nbsp;&nbsp;<A onclick="InsertImage();" href="javascript:void(0)">Image 
												Tag</A>&nbsp;&nbsp;<A onclick="insertAtCaret(document.Form1.txtBody, ' [B]...[/B] '); document.Form1.txtBody.focus();" href="javascript:void(0)">Bold 
												Tag</A>&nbsp;&nbsp;<A onclick="insertAtCaret(document.Form1.txtBody, ' [I]...[/I] '); document.Form1.txtBody.focus();" href="javascript:void(0)">Italic 
												Tag</A>&nbsp;&nbsp;<A onclick="insertAtCaret(document.Form1.txtBody, ' [U]...[/U] '); document.Form1.txtBody.focus();" href="javascript:void(0)">Underline 
												Tag</A>&nbsp;&nbsp;<A onclick="insertAtCaret(document.Form1.txtBody, ' [UL] [LI]...[/LI] [/UL] '); document.Form1.txtBody.focus();" href="javascript:void(0)">List 
												Tag</A>&nbsp;&nbsp;</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 74px" vAlign="top">Body</TD>
										<TD><TEXTAREA id="txtBody" onkeyup="storeCaret(this);" style="WIDTH: 525px; HEIGHT: 218px" onclick="storeCaret(this);" name="txtBody" rows="13" cols="63" runat="server"></TEXTAREA></TD>
									</TR>
								</TABLE>
							</P>
							<P><asp:button id="btnSubmit" runat="server" Text="Submit"></asp:button>
								<asp:TextBox id="txtEdited" runat="server" Visible="False">NO</asp:TextBox></P>
							<P><FONT size="1"> Note: HTML Tags are not allowed.</FONT></P>
							<% } %>
						</TD>
					</TR>
				</TABLE>
				</TD></TR></TABLE>
			</p>
			<HR width="100%" SIZE="1">
			<P align="center">Copyrighted © 2003 David Elizalde</P>
		</form>
	</body>
</HTML>
