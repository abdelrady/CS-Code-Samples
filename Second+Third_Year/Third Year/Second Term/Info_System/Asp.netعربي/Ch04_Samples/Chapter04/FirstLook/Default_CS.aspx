<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default_CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="FillStates"
            DataTextField="state" DataValueField="state">
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="FillGrid"
            ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:TemplateField HeaderText="Show Alone">
                    <EditItemTemplate>
                        
                        <a href='OneRow_CS.aspx?AuthID=<%# Eval("au_id") %>'> <%# Eval("au_id") %> </a>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <a href='OneRow_CS.aspx?AuthID=<%# Eval("au_id") %>'> <%# Eval("au_id") %> </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="FillGrid" runat="server" ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>"
            SelectCommand="SELECT * FROM [authors] WHERE ([state] = @state)" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [authors] WHERE [au_id] = @original_au_id AND [au_lname] = @original_au_lname AND [au_fname] = @original_au_fname AND [phone] = @original_phone AND [address] = @original_address AND [city] = @original_city AND [state] = @original_state AND [zip] = @original_zip AND [contract] = @original_contract" InsertCommand="INSERT INTO [authors] ([au_id], [au_lname], [au_fname], [phone], [address], [city], [state], [zip], [contract]) VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [authors] SET [au_lname] = @au_lname, [au_fname] = @au_fname, [phone] = @phone, [address] = @address, [city] = @city, [state] = @state, [zip] = @zip, [contract] = @contract WHERE [au_id] = @original_au_id AND [au_lname] = @original_au_lname AND [au_fname] = @original_au_fname AND [phone] = @original_phone AND [address] = @original_address AND [city] = @original_city AND [state] = @original_state AND [zip] = @original_zip AND [contract] = @original_contract">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="state" PropertyName="SelectedValue"
                    Type="String" />
            </SelectParameters>
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
        <asp:SqlDataSource ID="FillStates" runat="server" ConnectionString="<%$ ConnectionStrings:pubsConnectionString %>"
            SelectCommand="SELECT DISTINCT [state] FROM [authors] ORDER BY [state]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
