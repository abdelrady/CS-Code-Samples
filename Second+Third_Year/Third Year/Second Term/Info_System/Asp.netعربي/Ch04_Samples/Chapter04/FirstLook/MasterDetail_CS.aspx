<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterDetail_CS.aspx.cs" Inherits="MasterDetail_CS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
            CellPadding="4" DataKeyNames="pub_id" DataSourceID="Master" ForeColor="#333333"
            GridLines="None" Height="50px" Width="428px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <Fields>
                <asp:BoundField DataField="pub_id" HeaderText="pub_id" ReadOnly="True" SortExpression="pub_id" />
                <asp:BoundField DataField="pub_name" HeaderText="pub_name" SortExpression="pub_name" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                <asp:BoundField DataField="country" HeaderText="country" SortExpression="country" />
            </Fields>
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="Master" runat="server" ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>"
            SelectCommand="SELECT * FROM [publishers] ORDER BY [pub_name], [country], [state]">
        </asp:SqlDataSource>
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
            AutoGenerateColumns="False" CellPadding="4" DataSourceID="Detail" ForeColor="#333333"
            GridLines="None" PageSize="5" Width="523px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="pubdate" HeaderText="pubdate" SortExpression="pubdate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Detail" runat="server" ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>"
            SelectCommand="SELECT [title], [type], [price], [pubdate] FROM [titles] WHERE ([pub_id] = @pub_id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="pub_id" PropertyName="SelectedValue"
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
