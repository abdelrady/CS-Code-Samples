<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.shoppingcart" CodeFile="shoppingcart.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>shoppingcart</title>
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
			<asp:Panel id="Panel1" style="Z-INDEX: 101; LEFT: 296px; POSITION: absolute; TOP: 208px" runat="server"
				Width="608px" Height="260px">
<asp:DataGrid id="DataGrid1" runat="server" Height="186px" Width="600px" BorderColor="#DEBA84"
					BorderStyle="None" CellSpacing="2" BorderWidth="1px" BackColor="#DEBA84" CellPadding="3"
					AutoGenerateColumns="False">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
					<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
					<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
					<Columns>
						<asp:TemplateColumn HeaderText="Product&nbsp;ID">
							<ItemTemplate>
								<asp:Label id="ProductID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProductID") %>' />
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="ProductName" ReadOnly="True" HeaderText="ProductName"></asp:BoundColumn>
						<asp:BoundColumn DataField="UnitPrice" ReadOnly="True" HeaderText="Price"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Quantity">
							<ItemTemplate>
								<asp:TextBox id="Quantity" runat="server" Columns="4" MaxLength="3" Text='<%# DataBinder.Eval(Container.DataItem, "Quantity") %>' width="40px" />
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="ExtendedAmount" HeaderText="Total" DataFormatString="{0:c}"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Remove">
							<ItemTemplate>
								<center>
									<asp:CheckBox id="Remove" runat="server" />
								</center>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
				</asp:DataGrid>
<asp:Button id="btnCheckout" runat="server" Width="112px" Text="CHECKOUT" ForeColor="RoyalBlue"
					Font-Bold="True" onclick="btnCheckout_Click"></asp:Button>&nbsp;&nbsp; 
<asp:Button id="btnShopping" runat="server" Width="144px" Text="CONTINUE SHOPPING" ForeColor="RoyalBlue"
					Font-Bold="True" onclick="btnShopping_Click"></asp:Button>&nbsp;&nbsp; 
<asp:Button id="btnUpdateCart" runat="server" Width="112px" Text="UPDATE CART" ForeColor="RoyalBlue"
					Font-Bold="True" onclick="btnUpdateCart_Click"></asp:Button>&nbsp;&nbsp;&nbsp; 
<asp:Label id="Label2" runat="server" Width="80px" Font-Bold="True">TOTAL</asp:Label>
<asp:Label id="lblTotal" runat="server" Width="105px"></asp:Label>
			</asp:Panel>
			<asp:Label id="lberror" style="Z-INDEX: 102; LEFT: 288px; POSITION: absolute; TOP: 176px" runat="server"
				Width="544px" ForeColor="Red" Font-Bold="True"></asp:Label>
		</form>
	</body>
</HTML>
