<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WithoutMasterPage.aspx.cs" Inherits="WithoutMasterPage" MasterPageFile="~/MasterPage.master" %>
<asp:Content  ContentPlaceHolderID=ContentPlaceHolder1 ID=ContentHolder runat=server><div>
        ������<br />
        ����� :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        ������� :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="���" /></div>
</asp:Content>