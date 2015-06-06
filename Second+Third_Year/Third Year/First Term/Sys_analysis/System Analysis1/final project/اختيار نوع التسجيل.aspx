<%@ Page Language="C#" %>
<script runat="server">

    // Insert page code here
    //
    
    void Button1_Click(object sender, EventArgs e) {
     Response.Redirect("Final_Register(newstudent).aspx");
    }
    
    void Button2_Click(object sender, EventArgs e) {
    Response.Redirect("finalRegister2.aspx");
    }

</script>
<html>
<head>
</head>
<body background="GrayPaper.gif">
    <center>
        <form runat="server">
            <p align="center">
            </p>
            <p align="right">
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
                <strong><font color="green" size="6">اختر نوع التسجيل</font></strong> 
            </p>
            <legend style="WIDTH: 30px; HEIGHT: 30px">
                <div align="center">
                    <p>
                    </p>
                </div>
                <p>
                </p>
                <p>
                    <asp:Button id="Button1" onclick="Button1_Click" runat="server" Height="44px" Width="186px" Text="طالب مستجد"></asp:Button>
                </p>
                <p>
                    <asp:Button id="Button2" onclick="Button2_Click" runat="server" Height="50px" Width="186px" Text="طالب قديم"></asp:Button>
                </p>
            </legend>
            <!-- Insert content here -->
        </form>
    </center>
</body>
</html>
