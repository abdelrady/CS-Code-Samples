<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <iframe id="IFRAME1" border="0" frameborder="0" height="50" scrolling="no" src="adv.aspx"
                style="z-index: 116; left: 15px; width: 715px; position: absolute; top: 275px;
                height: 23px" width="100"></iframe>
          
        &nbsp;
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Untitled-3.gif" style="z-index: 100; left: 0px; position: absolute; top: 0px" Width="753px" Height="270px" /><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/11.gif" Style="z-index: 101;
            left: 601px; position: absolute; top: 135px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/home.aspx" />
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/16.gif" Style="z-index: 102;
            left: 136px; position: absolute; top: 229px" Width="250px" OnClick="ImageButton2_Click" Height="20px" PostBackUrl="~/students.aspx" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/17.gif" Style="z-index: 103;
            left: 4px; position: absolute; top: 246px" Width="250px" OnClick="ImageButton2_Click" Height="20px" PostBackUrl="~/account.aspx" />
        &nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/15.gif" Style="z-index: 104;
            left: 243px; position: absolute; top: 210px" Width="250px" OnClick="ImageButton2_Click" Height="20px" PostBackUrl="~/account.aspx" />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/13.gif" Style="z-index: 105;
            left: 474px; position: absolute; top: 174px" Width="250px" OnClick="ImageButton2_Click" Height="20px" PostBackUrl="~/account.aspx" />
        &nbsp;&nbsp; <asp:Image ID="Image3" runat="server" ImageUrl="~/Untitled-2.gif" style="z-index: 99; left: -5px; position: absolute; top: 268px" Width="759px" Height="36px" />
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/14.gif" Style="z-index: 107;
            left: 351px; position: absolute; top: 191px" Width="250px" OnClick="ImageButton2_Click" Height="20px" PostBackUrl="~/account.aspx" />
        <asp:Image ID="Image1" runat="server" Height="406px" ImageUrl="~/Image6.jpg" Style="z-index: 108;
            left: 0px; position: absolute; top: 304px" Width="753px" BorderColor="#80FF80" /><asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/28.gif" Style="z-index: 109;
            left: 601px; position: absolute; top: 631px" Width="141px" OnClick="ImageButton2_Click" />
        <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/26.gif" Style="z-index: 110;
            left: 602px; position: absolute; top: 587px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/teach.aspx" />
        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/25.gif" Style="z-index: 111;
            left: 601px; position: absolute; top: 547px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/acc.aspx" />
        <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/24.gif" Style="z-index: 112;
            left: 601px; position: absolute; top: 507px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/degrees.aspx" />
        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/23.gif" Style="z-index: 113;
            left: 602px; position: absolute; top: 463px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/departments.aspx" />
        <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/22.gif" Style="z-index: 114;
            left: 602px; position: absolute; top: 424px" Width="141px" OnClick="ImageButton2_Click" PostBackUrl="~/goal.aspx" />
        <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/21.gif" Style="z-index: 115;
            left: 601px; position: absolute; top: 384px" Width="141px" OnClick="ImageButton2_Click" />
    </div>
    </form>
</body>
</html>
