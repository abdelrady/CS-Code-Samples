<%@ Page language="c#" Codebehind="viewmsg.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.bb.viewmsg" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Message Board -
			<%= MessageTitle %>
		</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
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
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P>
								<asp:Table id="tableBB" runat="server" Width="100%"></asp:Table></P>
						</TD>
					</TR>
				</TABLE>
			</p>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted � 2003 David Elizalde</P>
		</form>
	</body>
</HTML>
