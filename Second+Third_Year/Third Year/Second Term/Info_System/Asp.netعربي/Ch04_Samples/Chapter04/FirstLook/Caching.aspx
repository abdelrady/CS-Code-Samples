<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Caching.aspx.cs" Inherits="Caching" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body dir="ltr">
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="DDLSource" DataTextField="FullName" DataValueField="au_id">
    </asp:DropDownList><asp:SqlDataSource ID="DDLSource" runat="server" ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>"
        SelectCommand="SELECT au_lname + ', ' + au_fname AS FullName, au_id FROM authors ORDER BY FullName">
    </asp:SqlDataSource>
    <asp:detailsview ID="Detailsview1" runat="server" height="50px" width="680px" AutoGenerateRows="False" CellPadding="4" DataSourceID="DetailSource" ForeColor="#333333" GridLines="None">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="au_lname" HeaderText="au_lname" SortExpression="au_lname" />
            <asp:BoundField DataField="au_fname" HeaderText="au_fname" SortExpression="au_fname" />
            <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
            <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
            <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
            <asp:BoundField DataField="zip" HeaderText="zip" SortExpression="zip" />
            <asp:CheckBoxField DataField="contract" HeaderText="contract" SortExpression="contract" />
            <asp:BoundField DataField="ViewDate" HeaderText="ViewDate" ReadOnly="True" SortExpression="ViewDate" />
        </Fields>
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:detailsview>
        <asp:SqlDataSource ID="DetailSource" runat="server" CacheDuration="60" CacheExpirationPolicy="Sliding"
            ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>" EnableCaching="True"
            SelectCommand="SELECT au_lname, au_fname, phone, address, city, state, zip, contract, GETDATE() AS ViewDate&#13;&#10; FROM authors&#13;&#10;where au_id=@au_id">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="au_id" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>

</html>
