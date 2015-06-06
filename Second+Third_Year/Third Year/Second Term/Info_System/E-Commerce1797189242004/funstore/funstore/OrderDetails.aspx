<%@ Page language="c#" Inherits="funstore.OrderDetails1" CodeFile="OrderDetails.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>OrderDetails</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:Header id="Header1" runat="server"></uc1:Header>
			<uc1:Menu id="Menu1" runat="server"></uc1:Menu>
			<uc1:Footer id="Footer1" runat="server"></uc1:Footer>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 352px; POSITION: absolute; TOP: 176px" runat="server"
				Width="336px" ForeColor="#FF8000" Font-Bold="True">Your Order Information</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 368px; POSITION: absolute; TOP: 208px" runat="server"
				Width="112px">Your Order ID</asp:Label>
			<asp:Label id="lblid" style="Z-INDEX: 103; LEFT: 504px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px"></asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 368px; POSITION: absolute; TOP: 240px" runat="server"
				Width="120px">Your Order Date</asp:Label>
			<asp:Label id="lbldate" style="Z-INDEX: 105; LEFT: 504px; POSITION: absolute; TOP: 240px" runat="server"
				Width="152px"></asp:Label>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 106; LEFT: 368px; POSITION: absolute; TOP: 280px"
				runat="server" Width="528px" BorderColor="#DEBA84" BorderStyle="None" CellSpacing="2" BorderWidth="1px"
				BackColor="#DEBA84" CellPadding="3">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="ProductName" HeaderText="ProductName"></asp:BoundColumn>
					<asp:BoundColumn DataField="UnitPrice" HeaderText="UnitPrice"></asp:BoundColumn>
					<asp:BoundColumn DataField="Quantity" HeaderText="Quantity"></asp:BoundColumn>
					<asp:BoundColumn DataField="ExtendedAmount" HeaderText="Total"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>
				<asp:Label id="Label6" style="Z-INDEX: 107; LEFT: 376px; POSITION: absolute; TOP: 504px" runat="server"
					Width="64px">Total</asp:Label></P>
			<P>
				<asp:Label id="lbltotal" style="Z-INDEX: 108; LEFT: 464px; POSITION: absolute; TOP: 504px"
					runat="server" Width="104px"></asp:Label></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>
				<asp:Button id="btnsubmit" style="Z-INDEX: 109; LEFT: 392px; POSITION: absolute; TOP: 552px"
					runat="server" Width="120px" Text="SUBMIT"></asp:Button></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>
