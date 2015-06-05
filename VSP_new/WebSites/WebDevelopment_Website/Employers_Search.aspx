<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employers_Search.aspx.cs" Inherits="Employers_Search" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
<!--

function IMG3_onclick() {

}

// -->
</script>
<div id="contentBackground" style="BACKGROUND-POSITION: center top; MARGIN-TOP: 2px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 485px;z-index:1;">
<IMG height=685 src="images/headerbox.png" width=772>
</div>
<div id="ContentPlaceHolder" style="MARGIN-TOP: 0px; MARGIN-LEFT: 7px;z-index:0;left: 10px; position: relative; top: -400px;width:700px;">

    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>Search For Job Seekers</p>
    <p>
        Here You Can Search For A given Job Seekr By his Experts,Environement,Country,&amp;
        By Category</p>
    <p>
        If you already have been assigned a CareerFCIS.com ID and password, log in to your
        <a href="login.aspx?type='Employers'"><b><span style="color: #0000ff">Member Desktop</span></b></a>
        to begin.</p>
        <h3>
        <span style="font-size: 14pt; color: #ff0000">Search Panel<br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </span><span style="font-size: 7pt"></span></h3>
        <br />
    <table background="imagenew/sn_bk.jpg" border="0" cellpadding="0" cellspacing="0"
        style="font-size: 7pt" width="456">
        <tr>
            <td align="middle" valign="top" width="10">
                </td>
            <td align="left" colspan="4">
                <span class="tablenote"><span class="mandatory" style="color: red"><strong>*= required
                    field </strong></span></span>
            </td>
        </tr>
        <tr style="font-weight: bold; font-size: 7pt; color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="font-weight: bold; font-size: 7pt; color: #000000">
            <td align="middle" valign="top" width="10" style="height: 41px">
                </td>
            <td valign="top" width="110" style="height: 41px">
                <br />
                <span class="tabletitle"><span class="mandatory"><span style="color: #000000">
                    <span style="font-size: 9pt">
                    Job Category</span></span></span></span></td>
            <td bgcolor="#c9d1f2" style="font-size: 9pt; color: #000000; height: 41px;" width="1">
                </td>
            <td style="font-size: 9pt; color: #000000; height: 41px;" width="5">
                </td>
            <td align="left" style="font-size: 9pt; color: #000000; height: 41px;" valign="top" width="330">
                <br />
                
                <asp:DropDownList ID="DropDownList1" runat="server" Width="236px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Computer System</asp:ListItem>
                    <asp:ListItem>Education</asp:ListItem>
                    <asp:ListItem>Agriculture</asp:ListItem>
                    <asp:ListItem>Commerce</asp:ListItem>
                    <asp:ListItem>Engineering</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
                <br />
                
                <span
                    style="font-size: 7pt"> </span>
                </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                <span><span class="tabletitle"><span class="mandatory"><span style="color: #000000">
                    <span style="font-size: 9pt">KeyWords</span><span></span></span></span></span><br />
                    </span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
               </td>
            <td style="color: #000000" width="5">
                </td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <asp:TextBox ID="TextBox2" runat="server" Width="233px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox2_TextChanged" Width="233px"></asp:TextBox><br />
                <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox2_TextChanged" Width="233px"></asp:TextBox><br />
                <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox2_TextChanged" Width="233px"></asp:TextBox><br />
            </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10" style="height: 21px">
                </td>
            <td valign="top" width="110" style="height: 21px">
               <br />
                <span class="tabletitle" style="color: #000000"></span><strong><span style="font-size: 10px">
                    Country</span></strong><br />
                </td>
            <td bgcolor="#c9d1f2" width="1" style="height: 21px">
                </td>
            <td width="5" style="height: 21px">
                </td>
            <td align="left" valign="top" width="330" style="height: 21px">
                <br />
                &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Width="231px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Egypt</asp:ListItem>
                    <asp:ListItem>Saudi</asp:ListItem>
                    <asp:ListItem>Qatar</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>UAE</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                </td>
            <td bgcolor="#c9d1f2" width="1">
                </td>
            <td width="5">
                </td>
            <td align="left" valign="top" width="330">
                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/searchbutton.gif"
                    OnClick="ImageButton1_Click" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
</td>
        </tr>
    </table>
</asp:Content>

