<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default_VB.aspx.vb" Inherits="Default_VB" %>

<%@ Register Assembly="Translator_VB" Namespace="Translator_VB" TagPrefix="cc1" %>
<%@ Register Src="GoogleSearch_VB.ascx" TagName="GoogleSearch_VB" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
    
    </div>
        <table>
            <tr>
                <td bgcolor="#ffcc00" style="width: 100px">
                    <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                        Padding="6">
                        <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                        <MenuLabelHoverStyle ForeColor="#E2DED6" />
                        <EmptyZoneTextStyle Font-Size="0.8em" />
                        <MenuLabelStyle ForeColor="White" />
                        <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                            BorderWidth="1px" ForeColor="#333333" />
                        <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                        <ZoneTemplate>
                            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                        </ZoneTemplate>
                        <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                        <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                        <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                        <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                            Font-Size="0.6em" />
                        <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                    </asp:WebPartZone>
                </td>
                <td bgcolor="#ff6699"  style="width: 100px">
                    &nbsp;<asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                        Padding="6">
                        <PartChromeStyle BackColor="#EFF3FB" BorderColor="#D1DDF1" Font-Names="Verdana" ForeColor="#333333" />
                        <MenuLabelHoverStyle ForeColor="#D1DDF1" />
                        <EmptyZoneTextStyle Font-Size="0.8em" />
                        <MenuLabelStyle ForeColor="White" />
                        <MenuVerbHoverStyle BackColor="#EFF3FB" BorderColor="#CCCCCC" BorderStyle="Solid"
                            BorderWidth="1px" ForeColor="#333333" />
                        <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                        <ZoneTemplate>
                            <uc1:GoogleSearch_VB ID="GoogleSearch_VB1" runat="server" />
                        </ZoneTemplate>
                        <MenuVerbStyle BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                        <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                        <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                        <MenuPopupStyle BackColor="#507CD1" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                            Font-Size="0.6em" />
                        <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                    </asp:WebPartZone>
                </td>
                <td style="width: 100px">
                    <asp:WebPartZone ID="WebPartZone3" runat="server">
                        <ZoneTemplate>
                            <cc1:Translator_VB ID="Translator_VB1" runat="server" Title="ãÊÑÌã ÃäÌáíÒí íÇÈÇäí" />
                        </ZoneTemplate>
                        
                    </asp:WebPartZone>
                </td>
            </tr>
        </table>
        <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#EFF3FB" BorderColor="#CCCCCC"
            BorderWidth="1px" Font-Names="Verdana" Padding="6">
            <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
            <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
            <PartChromeStyle BorderColor="#D1DDF1" BorderStyle="Solid" BorderWidth="1px" />
            <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <PartLinkStyle Font-Size="0.8em" />
            <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
            <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <ZoneTemplate>
                <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                </asp:DeclarativeCatalogPart>
                <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
                <asp:ImportCatalogPart ID="ImportCatalogPart1" runat="server" />
            </ZoneTemplate>
            <PartStyle BorderColor="#EFF3FB" BorderWidth="5px" />
            <SelectedPartLinkStyle Font-Size="0.8em" />
            <FooterStyle BackColor="#D1DDF1" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
            <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
        </asp:CatalogZone>
    </form>
</body>
</html>