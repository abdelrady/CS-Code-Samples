<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OneRow_CS.aspx.cs" Inherits="OneRow_CS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" DataSourceID="OneRow"
            Height="50px" Width="503px" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <Fields>
                <asp:BoundField DataField="au_lname" HeaderText="First Name" SortExpression="au_lname" />
                <asp:BoundField DataField="au_fname" HeaderText="Last Name" SortExpression="au_fname" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="zip" HeaderText="zip" SortExpression="zip" />
                <asp:CheckBoxField DataField="contract" HeaderText="contract" SortExpression="contract" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="OneRow" runat="server" ConflictDetection="CompareAllValues"
            ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>" DeleteCommand="DELETE FROM [authors] WHERE [au_id] = @original_au_id AND [au_lname] = @original_au_lname AND [au_fname] = @original_au_fname AND [phone] = @original_phone AND [address] = @original_address AND [city] = @original_city AND [state] = @original_state AND [zip] = @original_zip AND [contract] = @original_contract"
            InsertCommand="INSERT INTO [authors] ([au_id], [au_lname], [au_fname], [phone], [address], [city], [state], [zip], [contract]) VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)"
            OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [authors] WHERE ([au_id] = @au_id)"
            UpdateCommand="UPDATE [authors] SET [au_lname] = @au_lname, [au_fname] = @au_fname, [phone] = @phone, [address] = @address, [city] = @city, [state] = @state, [zip] = @zip, [contract] = @contract WHERE [au_id] = @original_au_id AND [au_lname] = @original_au_lname AND [au_fname] = @original_au_fname AND [phone] = @original_phone AND [address] = @original_address AND [city] = @original_city AND [state] = @original_state AND [zip] = @original_zip AND [contract] = @original_contract">
            <DeleteParameters>
                <asp:Parameter Name="original_au_id" Type="String" />
                <asp:Parameter Name="original_au_lname" Type="String" />
                <asp:Parameter Name="original_au_fname" Type="String" />
                <asp:Parameter Name="original_phone" Type="String" />
                <asp:Parameter Name="original_address" Type="String" />
                <asp:Parameter Name="original_city" Type="String" />
                <asp:Parameter Name="original_state" Type="String" />
                <asp:Parameter Name="original_zip" Type="String" />
                <asp:Parameter Name="original_contract" Type="Boolean" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="au_lname" Type="String" />
                <asp:Parameter Name="au_fname" Type="String" />
                <asp:Parameter Name="phone" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="city" Type="String" />
                <asp:Parameter Name="state" Type="String" />
                <asp:Parameter Name="zip" Type="String" />
                <asp:Parameter Name="contract" Type="Boolean" />
                <asp:Parameter Name="original_au_id" Type="String" />
                <asp:Parameter Name="original_au_lname" Type="String" />
                <asp:Parameter Name="original_au_fname" Type="String" />
                <asp:Parameter Name="original_phone" Type="String" />
                <asp:Parameter Name="original_address" Type="String" />
                <asp:Parameter Name="original_city" Type="String" />
                <asp:Parameter Name="original_state" Type="String" />
                <asp:Parameter Name="original_zip" Type="String" />
                <asp:Parameter Name="original_contract" Type="Boolean" />
            </UpdateParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="au_id" QueryStringField="AuthID" Type="String" />
            </SelectParameters>
            <InsertParameters>
                <asp:Parameter Name="au_id" Type="String" />
                <asp:Parameter Name="au_lname" Type="String" />
                <asp:Parameter Name="au_fname" Type="String" />
                <asp:Parameter Name="phone" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="city" Type="String" />
                <asp:Parameter Name="state" Type="String" />
                <asp:Parameter Name="zip" Type="String" />
                <asp:Parameter Name="contract" Type="Boolean" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
