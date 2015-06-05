<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hired_Jobs.aspx.cs" Inherits="Hired_Jobs" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 32pt"><strong><span style="color: #3366ff"></span></strong></span>
    <h1>
   <strong>
   <p align="center" style="color: #3366ff; position: relative;font-size: 32pt;">Your InBox</p>
</strong>
    </h1>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataKeyNames="EmployeeID,JobID" DataSourceID="AccessDataSource1"
        Height="1px" Width="727px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="<div>Sorry There Is No Job Admired Emails Sent to You Now</div>">
        <Columns>
            <asp:TemplateField HeaderText="Message From" SortExpression="JobID">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("JobID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("JobID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField HeaderText="Message" Text="You Are Admired" DataNavigateUrlFields="JobID" DataNavigateUrlFormatString="Inbox.aspx?EID={0}" />
            <asp:CommandField HeaderText="Delete Message" ShowDeleteButton="True" />
        </Columns>
        <EmptyDataTemplate>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "inbox.aspx?EID="+Eval("JobID") %>'
                Text='<%# Eval("JobID") %>'></asp:HyperLink>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <EditRowStyle BackColor="#2461BF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    &nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="c:\db\JobSeekersDB.mdb"
        SelectCommand="SELECT * FROM [Employees_Hired]"></asp:AccessDataSource>
    &nbsp;&nbsp;
</asp:Content>

