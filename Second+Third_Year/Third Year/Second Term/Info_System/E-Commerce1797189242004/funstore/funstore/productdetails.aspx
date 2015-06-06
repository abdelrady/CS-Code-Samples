<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.productdetails" CodeFile="productdetails.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>productdetails</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><uc1:header id="Header1" runat="server"></uc1:header><uc1:menu id="Menu1" runat="server"></uc1:menu><uc1:footer id="Footer1" runat="server"></uc1:footer></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><asp:datalist id="DataList1" style="Z-INDEX: 102; LEFT: 320px; POSITION: absolute; TOP: 208px"
					runat="server">
					<ItemTemplate>
						<TD><A><IMG style="WIDTH: 216px; HEIGHT: 118px" height=118 src='pictures/<%#DataBinder.Eval(Container.DataItem,"Image")%>' width=216>&nbsp;
								<P>
									<asp:Label id="lbldesc" runat="server" Height="36px" Width="496px">
										<%#DataBinder.Eval(Container.DataItem,"Description")%>
									</asp:Label></P>
							</A>
							<P>
								<asp:Image id="Image2" runat="server" Height="48px" Width="120px" ImageUrl="file:///C:\Inetpub\wwwroot\funstore\images\BUY..JPG"></asp:Image>
								<asp:Label id="lblname" runat="server" Height="32px" Width="232px">
									<%#DataBinder.Eval(Container.DataItem,"ProductName")%>
								</asp:Label></P>
							<DIV style="WIDTH: 352px; POSITION: relative; HEIGHT: 26px">
								<P>
									<asp:Label id="lblprice" runat="server" Width="104px">
									<%#DataBinder.Eval(Container.DataItem,"UnitPrice")%> BAHT
								</asp:Label></P>
								<asp:HyperLink id="HyperLink1" runat="server" Width="168px" Font-Bold="True">
									<a href='addtocart.aspx?productID=<%# DataBinder.Eval(Container.DataItem, "ProductID") %>'>
										<span class="ProductListItem"><font color="#9D0000"><b>ADD TO CART<b></font></span>
									</a>
								</asp:HyperLink>
							</DIV>
							<P>&nbsp;</P>
					</ItemTemplate>
				</asp:datalist></P>
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
		</form>
	</body>
</HTML>
