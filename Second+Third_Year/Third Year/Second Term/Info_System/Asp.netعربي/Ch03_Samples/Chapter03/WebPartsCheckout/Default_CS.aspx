<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default_CS.aspx.cs" Inherits="Default_CS" %>

<%@ Register Assembly="Translator_CS" Namespace="Translator_CS" TagPrefix="cc1" %>

<%@ Register Src="GoogleSearch_CS.ascx" TagName="GoogleSearch_CS" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
        <br />
        √Œ «— ‰„ÿ «·⁄—÷ :&nbsp;<asp:DropDownList ID="ddl_ShowType" runat="server" AutoPostBack="True"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">√” ⁄—«÷</asp:ListItem>
            <asp:ListItem Value="1"> ’„Ì„</asp:ListItem>
            <asp:ListItem Value="2">√⁄œ«œ „ ﬁœ„</asp:ListItem>
            <asp:ListItem Value="3">«· Õﬂ„ «·ﬂ«„· ›Ï «· ⁄œÌ·</asp:ListItem>
        </asp:DropDownList>&nbsp;</div>
        <table>
            <tr>
                <td bgcolor="#ffcc00" style="width: 100px">
                    &nbsp;<asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                        Padding="6" EmptyZoneText="√÷› √œ«… - √”Õ» «·√œ«… À„ √›· Â« Â‰«" WebPartVerbRenderMode="TitleBar">
                        <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                        <MenuLabelHoverStyle ForeColor="#E2DED6" />
                        <EmptyZoneTextStyle Font-Size="0.8em" />
                        <MenuLabelStyle ForeColor="White" />
                        <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                            BorderWidth="1px" ForeColor="#333333" />
                        <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                        <ZoneTemplate>
                            <asp:Calendar ID="Calendar1" Title="«·‰ ÌÃ… :D"  runat="server"></asp:Calendar>
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
                        Padding="6" EmptyZoneText="√÷› √œ«… - √”Õ» «·√œ«… À„ √›· Â« Â‰«">
                        <PartChromeStyle BackColor="#EFF3FB" BorderColor="#D1DDF1" Font-Names="Verdana" ForeColor="#333333" />
                        <MenuLabelHoverStyle ForeColor="#D1DDF1" />
                        <EmptyZoneTextStyle Font-Size="0.8em" />
                        <MenuLabelStyle ForeColor="White" />
                        <MenuVerbHoverStyle BackColor="#EFF3FB" BorderColor="#CCCCCC" BorderStyle="Solid"
                            BorderWidth="1px" ForeColor="#333333" />
                        <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                        <ZoneTemplate>
                            <uc1:GoogleSearch_CS ID="GoogleSearch_CS1" title="»ÕÀ „⁄ ÃÃÃÃÃÊÃ·" runat="server" />
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
                    <asp:WebPartZone ID="Translator" runat="server" BorderColor="#CCCCCC" EmptyZoneText="√÷› √œ«… - √”Õ» «·√œ«… À„ √›· Â« Â‰«" Font-Names="Verdana" Padding="6">
                        <ZoneTemplate>
                            <cc1:translator_cs id="Translator_CS1" runat="server" ExportMode="All" strToTranslate="" Title="„ —Ã„ √‰Ã·Ì“Ì Ì«»«‰Ì"></cc1:translator_cs>
                        </ZoneTemplate>
                        <PartChromeStyle BackColor="#EFF3FB" BorderColor="#D1DDF1" Font-Names="Verdana" ForeColor="#333333" />
                        <MenuLabelHoverStyle ForeColor="#D1DDF1" />
                        <EmptyZoneTextStyle Font-Size="0.8em" />
                        <MenuLabelStyle ForeColor="White" />
                        <MenuVerbHoverStyle BackColor="#EFF3FB" BorderColor="#CCCCCC" BorderStyle="Solid"
                            BorderWidth="1px" ForeColor="#333333" />
                        <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                        <MenuVerbStyle BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                        <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                        <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                        <MenuPopupStyle BackColor="#507CD1" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                            Font-Size="0.6em" />
                        <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                    </asp:WebPartZone>
                </td>
            </tr>
        </table>
        <br />
        <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#EFF3FB" BorderColor="#CCCCCC"
            BorderWidth="1px" EmptyZoneText="Œ«·Ï" Font-Names="Verdana" HeaderText="„‰«ÿﬁ ⁄—÷ Ê  Œ’’Ì’ √œÊ« "
            InstructionText="√Œ «— «·√œ«… «· Ï  Êœ ⁄—÷Â«" Padding="6" SelectTargetZoneText="√÷› «·Ï ">
            <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
            <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
            <PartChromeStyle BorderColor="#D1DDF1" BorderStyle="Solid" BorderWidth="1px" />
            <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <PartLinkStyle Font-Size="0.8em" />
            <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
            <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <ZoneTemplate>
                <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server" Title="ﬁ«∆„… «·√œÊ« ">
                </asp:DeclarativeCatalogPart>
                <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" Title="„‰«ÿﬁ «·⁄—÷" />
                <asp:ImportCatalogPart ID="ImportCatalogPart1" runat="server" BrowseHelpText="√ﬂ » «”„ «·„·› √Ê √÷€ÿ ⁄·Ï Browse Ê √Œ «— «·„·›"
                    ImportedPartLabelText="√” Ì—«œ Œ’«∆’" PartImportErrorLabelText="Œÿ√ √À‰«¡ «·√” Ì—«œ"
                    Title="√” Ì—«œ Œ’«∆’ √œ«…" UploadButtonText="—›⁄" UploadHelpText="»„Ã—œ √Œ Ì«— „·› «·Œ’«∆’ Ê «·÷€ÿ ⁄·Ï “— &quot;—›⁄&quot; ”Ì „ √” Ì—«œ «·Œ’«∆’" />
            </ZoneTemplate>
            <PartStyle BorderColor="#EFF3FB" BorderWidth="5px" />
            <SelectedPartLinkStyle Font-Size="0.8em" />
            <FooterStyle BackColor="#D1DDF1" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
            <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
        </asp:CatalogZone>
        <br />
        &nbsp; &nbsp;
        <asp:EditorZone ID="EditorZone1" runat="server" BackColor="#EFF3FB" BorderColor="#CCCCCC"
            BorderWidth="1px" Font-Names="Verdana" Padding="6">
            <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
            <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
            <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
            <PartChromeStyle BorderColor="#D1DDF1" BorderStyle="Solid" BorderWidth="1px" />
            <ZoneTemplate>
                <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                <asp:BehaviorEditorPart ID="BehaviorEditorPart1" runat="server" />
                <asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
                <asp:PropertyGridEditorPart ID="PropertyGridEditorPart1" runat="server" />
            </ZoneTemplate>
            <PartStyle BorderColor="#EFF3FB" BorderWidth="5px" />
            <FooterStyle BackColor="#D1DDF1" HorizontalAlign="Right" />
            <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <ErrorStyle Font-Size="0.8em" />
            <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <PartTitleStyle Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
        </asp:EditorZone>
    </form>
</body>
</html>
