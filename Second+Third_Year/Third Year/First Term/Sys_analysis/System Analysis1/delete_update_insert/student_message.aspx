<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student_message.aspx.cs" Inherits="student_message" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="211px" Style="z-index: 100; left: 16px;
            position: absolute; top: 107px" TextMode="MultiLine" Width="364px"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Style="z-index: 101;
            left: 158px; position: absolute; top: 360px" />
        <asp:Label ID="Label1" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 102; left: 282px;
            position: absolute; top: 62px" Text=": ÛÑÖ ÇáÑÓáÉ"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 103; left: 207px;
            position: absolute; top: 62px"></asp:Label>
        <asp:Label ID="Label3" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 104; left: 102px;
            position: absolute; top: 62px" Text=": ÇáÑÇÓá"></asp:Label>
        <asp:Label ID="Label4" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 105; left: 27px;
            position: absolute; top: 62px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#E0E0E0" BorderColor="#E0E0E0"
            Style="z-index: 108; left: 142px; position: absolute; top: 332px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Style="z-index: 107; left: 315px; position: absolute; top: 332px" Text=": ÃÏÎá ÇÓãß"></asp:Label>
        <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton1_Click" Style="z-index: 101;
            left: 209px; position: absolute; top: 360px" />
        <asp:Label ID="Label6" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 102; left: 289px;
            position: absolute; top: 22px" Text=": ÚÏÏ ÇáÑÓÇÆá"></asp:Label>
        <asp:Label ID="Label7" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Font-Size="Large" Style="z-index: 103; left: 215px;
            position: absolute; top: 22px"></asp:Label>
        <asp:ImageButton ID="ImageButton3" runat="server" OnClick="ImageButton1_Click" Style="z-index: 101;
            left: 209px; position: absolute; top: 360px" />
    
    </div>
    </form>
</body>
</html>
