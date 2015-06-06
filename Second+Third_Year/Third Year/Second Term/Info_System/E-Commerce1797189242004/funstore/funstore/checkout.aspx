<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.checkout1" CodeFile="checkout.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Checkout</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:header id="Header1" runat="server"></uc1:header><uc1:menu id="Menu1" runat="server"></uc1:menu><uc1:footer id="Footer1" runat="server"></uc1:footer><asp:datagrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 288px; POSITION: absolute; TOP: 232px"
				runat="server" AutoGenerateColumns="False" CellPadding="3" BackColor="#DEBA84" BorderWidth="1px" CellSpacing="2" BorderStyle="None" BorderColor="#DEBA84" Width="608px" Height="248px">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="ProductName" HeaderText="ProductName"></asp:BoundColumn>
					<asp:BoundColumn DataField="UnitPrice" HeaderText="UnitPirce"></asp:BoundColumn>
					<asp:BoundColumn DataField="Quantity" HeaderText="Quantity"></asp:BoundColumn>
					<asp:BoundColumn DataField="ExtendedAmount" HeaderText="Total" DataFormatString="{0:c}"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 296px; POSITION: absolute; TOP: 200px" runat="server"
					Width="584px" Font-Names="Arial Black" Font-Bold="True" ForeColor="#FF8000">Please Review and Submit Your Order</asp:label></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 280px; POSITION: absolute; TOP: 504px" runat="server">your order Total</asp:label></P>
			<P><asp:label id="lbltotal" style="Z-INDEX: 103; LEFT: 400px; POSITION: absolute; TOP: 504px"
					runat="server" Width="88px"></asp:label></P>
			<P>&nbsp;</P>
			<P><asp:button id="btnOrder" style="Z-INDEX: 104; LEFT: 280px; POSITION: absolute; TOP: 536px"
					runat="server" Width="120px" Text="Confirm Order" onclick="btnOrder_Click"></asp:button></P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>
