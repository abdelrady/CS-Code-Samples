<%@ Page language="c#" Codebehind="sendmail.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.sendmail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Send Email</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
		<SCRIPT LANGUAGE="Javascript" SRC="../ColorPicker2.js"></SCRIPT>
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
							<H3>Send Email</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD style="WIDTH: 84px" vAlign="top">From</TD>
										<TD>
											<asp:TextBox id="txtFromAddr" runat="server" Width="251px">webmaster@</asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top">To</TD>
										<TD>
											<asp:TextBox id="txtToAddr" runat="server" Width="251px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top">Subject</TD>
										<TD>
											<asp:TextBox id="txtSubject" runat="server" Width="251px">Untitled</asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top">HTML Tools</TD>
										<TD>
											<INPUT style="WIDTH: 77px; HEIGHT: 22px" type="text" size="7" name="color2">&nbsp;<A id="pick2" onclick="pick2('pick2');return false;" href="javascript:void()" name="pick2">Colors</A>
											<SCRIPT language="javascript">cp.writeDiv()</SCRIPT>
										</TD>
									</TR>
									<TR>
										<TD vAlign="top">Body</TD>
										<TD>
											<asp:TextBox id="txtBody" runat="server" Width="523px" TextMode="MultiLine" Height="200px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top"></TD>
										<TD>
											<asp:CheckBox id="chkSendHTML" runat="server" Text="Send using HTML"></asp:CheckBox><BR>
											<asp:CheckBox id="chkSendDiff" runat="server" Text="Send using different Mail Server"></asp:CheckBox>&nbsp;
											<asp:TextBox id="txtMailServer" runat="server">localhost</asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top"></TD>
										<TD>
											<asp:Button id="cmbSendEmail" runat="server" Text="Send Email"></asp:Button>
											<asp:textbox id="txtEdited" runat="server" Visible="False">NO</asp:textbox></TD>
									</TR>
								</TABLE>
								<% } %>
							</P>
						</TD>
					</TR>
				</TABLE>
			</p>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted © 2003 David Elizalde</P>
		</form>
	</body>
</HTML>
