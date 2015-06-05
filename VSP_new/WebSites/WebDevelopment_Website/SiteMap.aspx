<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SiteMap.aspx.cs" Inherits="SiteMap" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp; &nbsp;&nbsp;
    <table style="width: 776px; height: 191px">
        <tr>
            <td style="background-position: center center; background-attachment: scroll; background-image: url(Images/headerbox.png);
                width: 560px; background-repeat: repeat; height: 47px">
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" style="left: 14px; position: relative; top: 6px">
                </asp:Menu>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="background-position: center center; background-attachment: scroll; background-image: url(Images/headerbox.png);
                width: 560px; background-repeat: repeat; height: 4px">
            </td>
        </tr>
    </table>
</asp:Content>

