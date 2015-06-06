<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.search" CodeFile="search.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>search</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<uc1:Header id="Header1" runat="server"></uc1:Header>
				<uc1:Menu id="Menu1" runat="server"></uc1:Menu>
				<uc1:Footer id="Footer1" runat="server"></uc1:Footer>
				<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 280px; POSITION: absolute; TOP: 160px" runat="server"
					Width="168px" Font-Bold="True">Enter Your Search Text</asp:Label>
				<asp:TextBox id="txtsearch" style="Z-INDEX: 102; LEFT: 464px; POSITION: absolute; TOP: 160px"
					runat="server" Width="176px"></asp:TextBox>
				<asp:Button id="btnSearch" style="Z-INDEX: 103; LEFT: 656px; POSITION: absolute; TOP: 160px"
					runat="server" Width="64px" Font-Bold="True" Text="GO" ForeColor="Blue" Font-Names="Bodoni MT Black" onclick="btnSearch_Click"></asp:Button>
				<asp:Label id="lblresults" style="Z-INDEX: 104; LEFT: 304px; POSITION: absolute; TOP: 208px"
					runat="server" Width="384px"></asp:Label></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>
				<asp:DataGrid id="DataGrid1" style="Z-INDEX: 105; LEFT: 288px; POSITION: absolute; TOP: 248px"
					runat="server" Width="632px" Height="234px" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
					BackColor="#DEBA84" CellPadding="3" AutoGenerateColumns="False" PageSize="5" AllowPaging="True"
					OnPageIndexChanged="DataGrid_page" CellSpacing="2">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
					<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
					<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="ProductID" ReadOnly="True" HeaderText="ProductID"></asp:BoundColumn>
						<asp:HyperLinkColumn Text="ProductName" DataNavigateUrlField="ProductID" DataNavigateUrlFormatString="productdetails.aspx?ProductID={0}"
							DataTextField="ProductName" HeaderText="ProductName"></asp:HyperLinkColumn>
						<asp:BoundColumn DataField="UnitPrice" ReadOnly="True" HeaderText="UnitPrice"></asp:BoundColumn>
						<asp:HyperLinkColumn Text="ADDTOCART" DataNavigateUrlField="ProductID" DataNavigateUrlFormatString="addtocart.aspx?ProductID={0}"
							HeaderText="ADDTOCART"></asp:HyperLinkColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
				</asp:DataGrid></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>
