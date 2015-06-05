<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employer_SearchResult.aspx.cs" Inherits="Employer_SearchResult" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h3>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" CellPadding="4"
        ForeColor="#333333" GridLines="None" Height="255px" OnPageIndexChanging="DetailsView1_PageIndexChanging"
        Width="741px" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="AccessDataSource1" EmptyDataText="<div style='color:red;'> Sorry There Is No Data Available For Chosen Keywords...<br />Try Another Strong Keywords</div>">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
        <EditRowStyle BackColor="#2461BF" />
        <RowStyle BackColor="#EFF3FB" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
        <Fields>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            <asp:BoundField DataField="Email_Address" HeaderText="Email_Address" SortExpression="Email_Address" />
            <asp:BoundField DataField="Education_Category" HeaderText="Education_Category" SortExpression="Education_Category" />
            <asp:BoundField DataField="Experts" HeaderText="Experts" SortExpression="Experts" />
        </Fields>
    </asp:DetailsView>
    </h3>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="c:\db\JobSeekersDB.mdb"
        SelectCommand="SELECT [FirstName], [LastName], [Address], [State], [Country], [Email_Address], [Experts], [Education_Category], [ID] FROM [Seekers]">
    </asp:AccessDataSource>
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label><br />
    &nbsp;
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/AcceptButton.png"
        OnClick="ImageButton1_Click" Style="left: 263px; position: relative; top: 0px" /><br />
    
</asp:Content>

