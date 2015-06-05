<%@ Page language="c#" Codebehind="viewbooth.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.vote.viewbooth" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Voting - Booth -
			<%= strBoothName %>
		</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../../styles.css" type="text/css" rel="stylesheet">
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
				function update(booth, votename, value) {
						__doPostBack("update", booth + '-' + votename + '-' + value);
							}
			// -->
			</script>
			<!-- #include virtual="../../header.inc" -->
			<HR width="100%" SIZE="1">
			<p>
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD vAlign="top" width="15%">
							<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
							<P><STRONG>Welcome<BR>
									<%= Session["User_Name"] %>
									!</STRONG></P>
							<% } %>
							<asp:literal id="liLinks" runat="server"></asp:literal></TD>
						<TD vAlign="top">
							<H3>Voting - Booth -
								<%= strBoothName %>
							</H3>
							<P><asp:literal id="liMessage" runat="server"></asp:literal></P>
							<h5><%= strDescription %></h5>
							<P><asp:table id="tableBooth" runat="server" Width="100%"></asp:table><BR>
								Total Votes:
								<%= maxVotes %>
								<BR>
								<BR>
								<asp:table id="tableChoices" runat="server"></asp:table></P>
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
