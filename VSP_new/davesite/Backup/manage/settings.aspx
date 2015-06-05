<%@ Page language="c#" Codebehind="settings.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.settings" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - Settings</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
		<SCRIPT LANGUAGE="Javascript" SRC="ColorPicker2.js"></SCRIPT>
		<SCRIPT LANGUAGE="JavaScript">
var cp = new ColorPicker('window');
var cp2 = new ColorPicker();
// Runs when a color is clicked
function pickColor(color) {
	field.value = color;
	}

var field;
function pick1(anchorname) {
	field = document.forms[0].color;
	cp.show(anchorname);
	}
function pick2(anchorname) {
	field = document.forms[0].color2;
	cp2.show(anchorname);
	}
		</SCRIPT>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" value="void" name="__EVENTTARGET"> <input type="hidden" value="void" name="__EVENTARGUMENT">
			<script language="javascript">
			<!--
				function __doPostBack(eventTarget, eventArgument) {
						var theform = document.Form1;
						theform.__EVENTTARGET.value = eventTarget;
						theform.__EVENTARGUMENT.value = eventArgument;
						theform.submit();
							}
							// --> </script>
			<!-- #include virtual="../header.inc" -->
			<HR width="100%" SIZE="1">
			<P>
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
							<H3>Settings</H3>
							<P>This section allows Administrators to modify some important settings concerning 
								the site's Style Sheets, Webmaster contact information and other settings.</P>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P><STRONG>Style Sheet</STRONG><% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0">
									<TR>
										<TD>
											<asp:TextBox id="txtStyleSheet" runat="server" Width="455px" TextMode="MultiLine" Height="314px"></asp:TextBox></TD>
										<TD vAlign="top">
											<P><a href="javascript:__doPostBack('updatecss', 'void')"><img src="../images/icons/post.gif" border="0" alt="Save">Save</a></P>
											<P><INPUT TYPE="text" NAME="color2" SIZE="7" style="WIDTH: 77px; HEIGHT: 22px"> <A HREF="javascript:void()" onClick="pick2('pick2');return false;" NAME="pick2" ID="pick2">
													Colors</A>
												<script language="javascript">cp.writeDiv()</script>
											</P>
										</TD>
									</TR>
								</TABLE>
								<% } %>
							</P>
							<P><STRONG>Webmaster Email Address</STRONG><BR>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<asp:TextBox id="txtWebmasterEmail" runat="server" Width="240px"></asp:TextBox>&nbsp;
								<A href="javascript:__doPostBack('updateadminemail', 'void')"><IMG alt="Save" src="../images/icons/post.gif" border="0">Update 
									Webmaster Email Address</A></P>
							<% } %>
							<P><STRONG>Mail Server (SMTP)</STRONG><BR>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<asp:TextBox id="txtSMTPServer" runat="server" Width="240px"></asp:TextBox>&nbsp;
								<A href="javascript:__doPostBack('updatemailserver', 'void')"><IMG alt="Save" src="../images/icons/post.gif" border="0">Update 
									Mail Server Address</A></P>
								<% } %>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P><STRONG>Web Site Title/Header/Scroll<BR>
								</STRONG>To edit these files please use the text editor, below is links to 
								activate the text editor:</P>
							<UL>
								<LI>
									<a href="./editors/text.aspx?file=Li4vLi4vdGl0bGUuaW5j">Title</a> (The title displayed on a browser 
										window; applies to every page)</LI>
								<LI>
									<a href="./editors/text.aspx?file=Li4vLi4vaGVhZGVyLmluYw==">Header</a> (The header displayed on the 
										top&nbsp;every page)</LI>
								<LI>
									<a href="./editors/text.aspx?file=Li4vLi4vc2Nyb2xsLmluYw==">Scroll</a> (On the main page, the text the 
										scrolls by)<BR>
								</LI>
							</UL>
							<% } %>
						</TD>
					</TR>
				</TABLE>
			</P>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted © 2003 David Elizalde</P>
		</form>
	</body>
</HTML>
