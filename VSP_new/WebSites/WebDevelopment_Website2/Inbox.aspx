<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inbox.aspx.cs" Inherits="Inbox" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
</script>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="c:\db\JobSeekersDB.mdb"
        SelectCommand="SELECT [FirstName], [LastName], [CompanyName], [City], [Country], [Email], [Website], [ID] FROM [Employers]">
    </asp:AccessDataSource>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    &nbsp;<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<strong><span
        style="font-size: 16pt; color:Green">What Amazing?!!!!!!!!!! You Are Hired!!!!!!!!!!!!!!!!!!!!!!!<br />
        <br />
    </span></strong>&nbsp;
    <table style="width: 740px; height: 131px">
        <tr>
            <td style="width: 365px">
    <asp:Image ID="Image1" runat="server" ImageAlign="Middle" ImageUrl="~/Images/Hired.jpg" style="left: 20px; top: 38px" /></td>
      <h3>
      <td>
      <b>
<font size="5">
</font></b>

    <asp:Label ID="Label1" runat="server" Height="127px" Style="left: 34px; top: -29px"
        Text="Label" Width="568px"></asp:Label></td></h3>

        </tr>
       <tr>
            <td style="width: 365px">
            </td>
            <td>
            </td>
        </tr>
    </table>
    
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="AccessDataSource1"
        Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Website" HeaderText="Website" SortExpression="Website" />
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
        </Fields>
    </asp:DetailsView>
</asp:Content>

