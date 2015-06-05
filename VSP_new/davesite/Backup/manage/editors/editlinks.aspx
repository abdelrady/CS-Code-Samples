<%@ Page language="c#" Codebehind="editlinks.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.editlinks" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Home Management - Edit links</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
	</HEAD>
	<body>
			<form id="Form1" method="post" runat="server">
				<!-- #include virtual="../../header.inc" -->
				<P align="left">
					<HR width="100%" SIZE="1">
				<P></P>
				<H2 align="left">
					<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
						<TR>
							<TD vAlign="top" width="15%">
								<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
								<P><STRONG>Welcome<BR>
										<%= Session["User_Name"] %>
										!</STRONG></P>
								<% } %>
								<asp:Literal id="liLinks" runat="server"></asp:Literal></TD>
							<TD vAlign="top" width="85%">
								<P>
									<asp:literal id="literalMessage" runat="server"></asp:literal></P>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<P>
									<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
										<TR>
											<TD style="HEIGHT: 20px" width="84">Link Id:</TD>
											<TD style="HEIGHT: 20px"><asp:textbox id="txtId" runat="server" ReadOnly="True" Width="27px"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 64px">Link Data:</TD>
											<TD><asp:textbox id="txtLinkData" runat="server" Width="523px" TextMode="MultiLine" Height="195px"></asp:textbox><BR>
												Note: New line tag '&lt;br&gt;' are automatically added.</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 64px"></TD>
											<TD><asp:button id="btnPostEditedLink" runat="server" Text="Post Edited Links"></asp:button><asp:textbox id="txtEdited" runat="server" Visible="False">NO</asp:textbox></TD>
										</TR>
									</TABLE>
								</P>
								<% } %>
							</TD>
						</TR>
					</TABLE>
				</H2>
			</form>
		<HR width="100%" SIZE="1">
		<P></P>
		<P></P>
		<P align="center">Copyrighted  2003 David Elizalde</P>
	</body>
</HTML>
