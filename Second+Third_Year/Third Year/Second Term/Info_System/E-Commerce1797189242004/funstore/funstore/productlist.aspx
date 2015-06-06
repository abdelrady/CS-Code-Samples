<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.productlist" CodeFile="productlist.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>productlist</title>
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
			<asp:DataList id="DataList2" style="Z-INDEX: 101; LEFT: 296px; POSITION: absolute; TOP: 176px"
				runat="server" Width="504px" RepeatColumns="2">
				<ItemTemplate>
					<TABLE width="300" border="0">
						<TR>
							<TD vAlign="middle" align="right" width="100"><A href='productdetails.aspx?ProductID=<%#DataBinder.Eval(Container.DataItem,"ProductID")%>'><IMG height=75 src='pictures/<%#DataBinder.Eval(Container.DataItem,"Image")%>' width=100>
								</A>
							</TD>
							<TD vAlign="middle" width="200"><A href='ProductDetails.aspx?productID=<%# DataBinder.Eval(Container.DataItem, "ProductID") %>'><SPAN class="ProductListHead"><%# DataBinder.Eval(Container.DataItem, "ProductName") %></SPAN><BR>
								</A><SPAN class="ProductListItem"><B>Price: </B>
									<%# DataBinder.Eval(Container.DataItem, "UnitPrice", "{0:c}") %>
								</SPAN>
								<BR>
								<STRONG><U><FONT color="#0000ff"><A href='addtocart.aspx?productID=<%# DataBinder.Eval(Container.DataItem, "ProductID") %>'>
												<SPAN class="ProductListItem"><FONT color="#9d0000"><B>ADD TO CART<B></FONT></SPAN>
											</A></FONT></U></STRONG></B></B></TD>
						</TR>
					</TABLE>
				</ItemTemplate>
			</asp:DataList>
		</form>
	</body>
</HTML>
