<%@ Page language="c#" Codebehind="system.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.system" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - System</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
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
				function __killProcess(processId, processName) {
						var deleteit = confirm('Are you sure you want to kill process \"' + processName + '\" (' + processId + ')?');
						if (deleteit) {
							__doPostBack('killprocess', processId);
						}
							}
				function __confirmPowerOption(pOption) {
						var deleteit = confirm('Are you sure you want to \"' + pOption + '\", which may result in a lost of data?');
						if (deleteit) {
							__doPostBack('power', pOption);
						}
							}
			// -->
			</script>
			<!-- #include virtual="../header.inc" -->
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
							<H3>System</H3>
							<P>This section of the site allows administrators with Super User access to control 
								some aspects of the computer remotely, such as:&nbsp; Viewing running 
								processes, Restarting ASP.NET, and controlling power functions.</P>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P><STRONG>System Uptime</STRONG><BR>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]) && Convert.ToBoolean(Session["su"])) { %>
								<asp:Label id="lblSystemUptime" runat="server">lblSystemUptime</asp:Label></P>
							<% } %>
							<P><STRONG>System Power</STRONG><BR>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]) && Convert.ToBoolean(Session["su"])) { %>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0">
									<TR>
										<TD><a href="javascript:__confirmPowerOption('Reboot')" title="Reboot Computer">Reboot</a></TD>
										<TD><A title="Shutdown Computer" href="javascript:__confirmPowerOption('Shutdown')">Shutdown</A></TD>
									</TR>
									<TR>
										<TD><a href="javascript:__confirmPowerOption('Hibernate')" title="Send computer into hibernation">Hibernate</a></TD>
										<TD><a href="javascript:__confirmPowerOption('Suspend')" title="Suspend the computer">Suspend</a></TD>
									</TR>
								</TABLE>
								<% } %>
							</P>
							<P><STRONG>Processes</STRONG><BR>
								<asp:Table id="tableProcesses" runat="server" Width="100%"></asp:Table></P>
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
