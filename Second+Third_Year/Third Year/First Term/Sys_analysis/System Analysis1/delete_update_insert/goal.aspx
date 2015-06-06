<%@ Page Language="C#" AutoEventWireup="true" CodeFile="goal.aspx.cs" Inherits="goal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="position: absolute">
    <form id="form1" runat="server">
    <div>
    <IFRAME border=0  scrolling=yes src="goals.aspx" width=100 frameBorder=0 
 height=50 style="z-index: 114; left: 3px; width: 572px; position: absolute; top: 304px; height: 396px" id="IFRAME1" ></IFRAME>
     
        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/11.gif" OnClick="ImageButton2_Click"
            Style="z-index: 100; left: 601px; position: absolute; top: 135px" Width="141px" />
        <asp:ImageButton ID="ImageButton5" runat="server" Height="20px" ImageUrl="~/16.gif"
            OnClick="ImageButton2_Click" Style="z-index: 101; left: 136px; position: absolute;
            top: 229px" Width="250px" />
        <asp:ImageButton ID="ImageButton4" runat="server" Height="20px" ImageUrl="~/17.gif"
            OnClick="ImageButton2_Click" Style="z-index: 102; left: 4px; position: absolute;
            top: 246px" Width="250px" />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="20px" ImageUrl="~/15.gif"
            OnClick="ImageButton2_Click" Style="z-index: 103; left: 243px; position: absolute;
            top: 210px" Width="250px" />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/13.gif"
            OnClick="ImageButton2_Click" Style="z-index: 104; left: 474px; position: absolute;
            top: 174px" Width="250px" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" ImageUrl="~/14.gif"
            OnClick="ImageButton2_Click" Style="z-index: 105; left: 351px; position: absolute;
            top: 191px" Width="250px" />
        &nbsp;
        <asp:Image ID="Image2" runat="server" Height="270px" ImageUrl="~/Untitled-3.gif"
            Style="z-index: 100; left: 0px; position: absolute; top: 0px" Width="753px" />
        &nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" ImageUrl="~/main.gif" Style="z-index: 105;
            left: 575px; position: absolute; top: 304px" Width="178px" Height="400px" />
        <asp:Image ID="Image5" runat="server" Height="270px" ImageUrl="~/Untitled-3.gif"
            Style="z-index: 100; left: 0px; position: absolute; top: 0px" Width="753px" />
        <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/28.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 598px; position: absolute; top: 631px" Width="141px" />
        <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/26.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 599px; position: absolute; top: 587px" Width="141px" />
        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/25.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 598px; position: absolute; top: 547px" Width="141px" />
        <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/24.gif" OnClick="ImageButton2_Click"
            PostBackUrl="~/25.gif" Style="z-index: 105; left: 598px; position: absolute;
            top: 507px" Width="141px" />
        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/23.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 599px; position: absolute; top: 463px" Width="141px" PostBackUrl="~/departments.aspx" />
        <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/22.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 599px; position: absolute; top: 424px" Width="141px" PostBackUrl="~/goal.aspx" />
        <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/21.gif" OnClick="ImageButton2_Click"
            Style="z-index: 105; left: 598px; position: absolute; top: 384px" Width="141px" />
        <asp:Image ID="Image4" runat="server" Height="36px" ImageUrl="~/Untitled-2.gif" Style="z-index: 102;
            left: 0px; position: absolute; top: 268px" Width="753px" />
    
    </div>
    </form>
</body>
</html>
