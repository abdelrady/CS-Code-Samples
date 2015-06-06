<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="upload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(Image14.png)">
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 100; left: 477px;
            position: absolute; top: 81px" />
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Style="z-index: 101;
            left: 561px; position: absolute; top: 158px" Height="28px" ImageUrl="~/upload.gif" />
        &nbsp;
        <asp:Label ID="Label1" runat="server" Style="z-index: 102; left: 573px; position: absolute;
            top: 114px" Text="Label"></asp:Label>
        <asp:HyperLink ID="HyperLink2" runat="server" Style="z-index: 103; left: 90px; position: absolute;
            top: 4px" Font-Bold="True" Font-Italic="True" Font-Size="Larger">Download file</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Lect_2.ppt" Style="z-index: 104;
            left: 88px; position: absolute; top: 76px">Lect_2.ppt</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Lecture_1_Slides.ppt"
            Style="z-index: 105; left: 88px; position: absolute; top: 44px">Lecture_1_Slides.ppt</asp:HyperLink>
        <asp:HyperLink ID="HyperLink5" runat="server" Style="z-index: 108; left: 554px; position: absolute;
            top: 7px" Font-Bold="True" Font-Italic="True" Font-Size="Large">Send file</asp:HyperLink>
        &nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" Style="z-index: 107; left: 561px; position: absolute;
            top: 39px">HyperLink</asp:HyperLink>
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/student_message.aspx"
            Style="z-index: 105; left: 591px; position: absolute; top: 257px">your messages</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
