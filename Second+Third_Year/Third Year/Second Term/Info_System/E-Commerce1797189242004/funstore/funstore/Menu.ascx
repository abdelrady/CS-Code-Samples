<%@ Control Language="c#" Inherits="funstore.Menu" CodeFile="Menu.ascx.cs" %>
<DIV style="WIDTH: 248px; POSITION: relative; HEIGHT: 502px; BACKGROUND-COLOR: #cc9966"><asp:datalist id="DataList1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 48px" Height="318px"
		runat="server">
		<HeaderTemplate>
			<FONT color="#ffcc33"><STRONG>PRODUCT CATEGORIES</STRONG></FONT>
		</HeaderTemplate>
		<ItemTemplate>
			<asp:HyperLink id=HyperLink1 runat="server" NavigateUrl='<%# "productlist.aspx?CategoryID=" + DataBinder.Eval(Container.DataItem, "CategoryID") + "&amp;selection=" + Container.ItemIndex %>' ForeColor="White" Font-Bold="True" Font-Names="Arial Black" Width="138px">
				<%#DataBinder.Eval(Container.DataItem,"CategoryName")%>
			</asp:HyperLink>
		</ItemTemplate>
	</asp:datalist></DIV>
