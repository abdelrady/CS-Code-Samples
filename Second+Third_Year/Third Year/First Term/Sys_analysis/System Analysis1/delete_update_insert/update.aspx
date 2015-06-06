<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-attachment: fixed; background-image: url(Untitled-4.gif)">
    <form id="form1" runat="server">
    <div style="text-align: justify">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 100;
            left: 576px; position: absolute; top: 47px" Text=":√”„ «·ÿ«·»  " BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black" Width="81px"></asp:Label>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 101;
            left: 577px; position: absolute; top: 99px" Text=":⁄‰Ê«‰ «·ÿ«·»" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 102;
            left: 331px; position: absolute; top: 99px" Text=":«·„œÌ‰…" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 103;
            left: 180px; position: absolute; top: 99px" Text=":«·„—ﬂ“" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black"></asp:Label>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 104;
            left: 280px; position: absolute; top: 47px" Text=":«·‰Ê⁄" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black" Width="43px"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 105;
            left: 578px; position: absolute; top: 152px" Text=":—ﬁ„ «· ·Ì›Ê‰" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black" Width="81px"></asp:Label>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 106;
            left: 589px; position: absolute; top: 203px" Text=":—ﬁ„ «·ÿ«·»" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid" ForeColor="Black" Width="68px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="15px" OnTextChanged="TextBox1_TextChanged"
            Style="z-index: 107; left: 399px; position: absolute; top: 47px" Width="155px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Style="z-index: 108;
            left: 403px; position: absolute; top: 154px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black" Width="155px"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Style="z-index: 109; left: 363px; position: absolute;
            top: 244px" Text="Label" Visible="False" BackColor="Red" BorderColor="Blue" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        &nbsp; &nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
            Style="z-index: 110; left: 197px; position: absolute; top: 47px" Width="73px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black">
            <asp:ListItem Selected="True">–ﬂ—</asp:ListItem>
            <asp:ListItem>√‰ÀÏ</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox3" runat="server" Height="15px" OnTextChanged="TextBox3_TextChanged"
            Style="z-index: 111; left: 248px; position: absolute; top: 99px" Width="74px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="15px" OnTextChanged="TextBox5_TextChanged"
            Style="z-index: 112; left: 401px; position: absolute; top: 99px" Width="155px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Height="15px" Style="z-index: 113; left: 82px;
            position: absolute; top: 99px" Width="77px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" Height="15px" Style="z-index: 114; left: 405px;
            position: absolute; top: 207px" Width="155px" BackColor="#E0E0E0" Font-Bold="False" Font-Italic="True" ForeColor="Black"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" Style="z-index: 115;
            left: 276px; position: absolute; top: 296px" Width="100px" OnClick="ImageButton1_Click" ImageUrl="~/Untitled-6.gif" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="39px" Style="z-index: 116;
            left: 176px; position: absolute; top: 296px" Width="100px" OnClick="ImageButton2_Click" ImageUrl="~/Untitled-8.gif" />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="39px" OnClick="ImageButton3_Click"
            Style="z-index: 117; left: 376px; position: absolute; top: 296px" Width="100px" ImageUrl="~/Untitled-7.gif" />
        <asp:ImageButton ID="ImageButton4" runat="server" OnClick="ImageButton4_Click" Style="z-index: 118;
            left: 476px; position: absolute; top: 296px" ImageUrl="~/Untitled-5.gif" />
        &nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/message.aspx" Style="z-index: 120;
            left: 593px; position: absolute; top: 344px">send message</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
