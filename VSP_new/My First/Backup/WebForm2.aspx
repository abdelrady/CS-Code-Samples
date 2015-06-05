<%@ Page language="c#" Codebehind="WebForm2.aspx.cs" AutoEventWireup="false" Inherits="My_First.WebForm2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="WebForm2" method="post" runat="server">
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 217px; POSITION: absolute; TOP: 60px" runat="server" Width="300px"  ShowFooter="True" AutoGenerateColumns="False">
				<AlternatingItemStyle ForeColor="Black" BackColor="#FFFFCC"></AlternatingItemStyle>
				<ItemStyle ForeColor="Black" BackColor="#CCCC99"></ItemStyle>
				<HeaderStyle ForeColor="White" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="White" BackColor="#000099"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="Name" HeaderText="Name">
						<ItemStyle Width="200px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Points" HeaderText="Points"></asp:BoundColumn>
				</Columns>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
