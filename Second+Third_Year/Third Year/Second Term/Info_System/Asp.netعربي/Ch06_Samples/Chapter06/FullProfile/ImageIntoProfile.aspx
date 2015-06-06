<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ImageIntoProfile.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>ملفك الشخصى و الصور</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="حفظ الصورة" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Literal ID="ltrlStatus" runat="server"></asp:Literal> <br />
        <asp:Image ID="Image" runat="server" ImageUrl="previewpic.aspx" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </div>
    </form>
</body>
</html>
