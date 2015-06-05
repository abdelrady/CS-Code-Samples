<%@ Page language="c#" Codebehind="editbooth.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.editbooth" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Voting - Edit Booth</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" name="__EVENTTARGET" value="void"> <input type="hidden" name="__EVENTARGUMENT" value="void">
			<script language="javascript">
			<!--
				function __doPostBack(eventTarget, eventArgument) {
						var theform = document.Form1;
						theform.__EVENTTARGET.value = eventTarget;
						theform.__EVENTARGUMENT.value = eventArgument;
						theform.submit();
							}
				function __confirmDeletion(id) {
						var deleteit = confirm('Are you sure you want to delete this choice?');
						if (deleteit) {
							__doPostBack('deletechoice', id);
							}
						}
			// -->
			</script>
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
							<H3>Edit Voting Booth</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD style="WIDTH: 84px" vAlign="top">Booth Name</TD>
										<TD>
											<asp:textbox id="txtBoothName" runat="server" MaxLength="255" Width="289px"></asp:textbox>&nbsp;Id:
											<asp:TextBox id="txtId" runat="server" Width="189px" ReadOnly="True"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px" vAlign="top">Description</TD>
										<TD>
											<asp:TextBox id="txtDescription" runat="server" Width="523px" TextMode="MultiLine" Height="51px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD vAlign="top">Booth Values</TD>
										<TD>
											<asp:Table id="tableBooth" runat="server"></asp:Table></TD>
									</TR>
									<TR>
										<TD vAlign="top"></TD>
										<TD>
											<asp:button id="btnSubmit" runat="server" Text="Posted Edited Voting Booth"></asp:button>
											<asp:TextBox id="txtEdited" runat="server" Visible="False">NO</asp:TextBox></TD>
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
