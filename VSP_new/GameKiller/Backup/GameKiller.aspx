<%@ Page language="c#" Codebehind="GameKiller.aspx.cs" AutoEventWireup="false" Inherits="GameKiller.GKForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Game Killer</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="GKForm" method="post" runat="server">
			<p id="ErrMsg" style="COLOR: #ff0000" runat="server"></p>
			<table>
				<tr>
					<td>&nbsp;</td>
					<td align="right">Input:
					</td>
					<td><asp:textbox id="Input" runat="server" Width="600px"></asp:textbox></td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td></td>
					<td>&nbsp;<asp:button id="Display" runat="server" Width="100px" Text="Display"></asp:button>
						&nbsp;<asp:button id="Filter1" runat="server" Width="100px" Text="Filter"></asp:button>
						&nbsp;<asp:button id="Filter2" runat="server" Width="100px" Text="Reverse Filter"></asp:button>
						&nbsp;<asp:button id="Add" runat="server" Width="100px" Text="Add"></asp:button>
						&nbsp;<asp:button id="Kill" runat="server" Width="100px" Text="Kill"></asp:button>
						&nbsp;<asp:button id="Restart" runat="server" Width="100px" Text="Restart"></asp:button>&nbsp;&nbsp;
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>
			<br>
			<br>
			<table id="All" width="800" runat="server">
				<tr>
					<td>&nbsp;</td>
					<th align="left">
						Process ID</th>
					<th align="left">
						Time</th>
					<th align="left">
						File</th>
					<td>&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
