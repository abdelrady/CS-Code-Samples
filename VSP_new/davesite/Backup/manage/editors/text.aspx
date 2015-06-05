<%@ Page language="c#" Codebehind="text.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.text" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Text Editor</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<script type="text/javascript">
		<!--
			function __newFile(eventTarget, eventArgument) {
						var deleteit = confirm('Are you sure you to begin a new file?');
						if (deleteit) {
							var theform = document.Form1;
							theform.txtEditor.value = "";
						}
							}
		// -->
			</script>
			<!-- #include virtual="../../header.inc" -->
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
							<H3>Text Editor</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P>Filename:
								<asp:TextBox id="txtFilename" runat="server" Width="246px"></asp:TextBox>&nbsp;&nbsp;
								<INPUT type="button" value="New" onclick="__newFile()">&nbsp;
								<asp:Button id="btnOpen" runat="server" Text="Open"></asp:Button>&nbsp;
								<asp:Button id="btnSave" runat="server" Text="Save/Save As"></asp:Button><BR>
								<asp:textbox id="txtEdited" runat="server" Visible="False">NO</asp:textbox></P>

							<P>
								<asp:TextBox id="txtEditor" runat="server" Width="632px" Height="314px" Wrap="False" TextMode="MultiLine"></asp:TextBox></P>
							<% } %>
						</TD>
					</TR>
				</TABLE>
			</P>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted  2003 David Elizalde</P>
		</form>
	</body>
</HTML>
