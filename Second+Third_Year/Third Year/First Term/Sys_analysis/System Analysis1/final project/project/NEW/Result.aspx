<%@ Page Language="C#" Debug="true" %>
<%@ import Namespace="System.Web.Security " %>
<%@ import Namespace="System.Data " %>
<%@ import Namespace="System.Data.OleDb " %>
<%@ import Namespace="System.Data.SqlClient " %>
<script runat="server">

    // Insert page code here
    //
    
    void Button1_Click(object sender, EventArgs e) {
    //int number= Convert.(st_number.Text);
    string build=st_build.SelectedItem.Text ;
    
    //int build1=Convert.ToInt32(build);
    string connection= " Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\madina project.mdb";
    if(build=="ا")
    {
    
    string sql=" select * from A";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    res.Visible=true;
    string str="Result";
    
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="ب")
    {
    
    string sql=" select * from B";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    res.Visible=true;
    string str="Result";
    
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="ج")
    {
    
    string sql=" select * from c";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="د")
    {
    
    string sql=" select * from d";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    
    if(build=="و")
    {
    
    string sql=" select * from e";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="ز")
    {
    
    string sql=" select * from f";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="س")
    {
    
    string sql=" select * from g";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    if(build=="ع")
    {
    
    string sql=" select * from h";
    OleDbDataAdapter da = new OleDbDataAdapter(sql,connection);
    DataSet ds = new DataSet();
    da.Fill(ds, "Result");
    //ds.Tables["Result"].Rows.Count;
    
    string str="Result";
    res.Visible=true;
    foreach(DataRow r in  ds.Tables["Result"].Rows)
    {
      str += r[2];
      str += r["buillding_name"];
    }
    
    
    dg.DataSource = ds;
    dg.DataMember = "Result" ;
    dg.DataBind();
    }
    
    
    
    }
    
    void Button2_Click(object sender, EventArgs e) {
    
    
    res.Visible=false;
    dg.Visible=false;
    
    }

</script>
<html>
<head>
</head>
<body>
    <form runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><font size="6">صفحة
            النتيجة</font></strong> 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label1" runat="server" font-bold="True" width="120px">اختر
            المبنى</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList id="st_build" runat="server" Height="87px" Width="320px">
                <asp:ListItem Value="ج">ج</asp:ListItem>
                <asp:ListItem Value="د">د</asp:ListItem>
                <asp:ListItem Value="و">و</asp:ListItem>
                <asp:ListItem Value="ز">ز</asp:ListItem>
                <asp:ListItem Value="س">س</asp:ListItem>
                <asp:ListItem Value="ع">ع</asp:ListItem>
                <asp:ListItem Value="ا">ا</asp:ListItem>
                <asp:ListItem Value="ب">ب</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button id="Button1" onclick="Button1_Click" runat="server" Width="129px" Text="Submit"></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button id="Button2" onclick="Button2_Click" runat="server" Width="110px" Text="Reset"></asp:Button>
        </p>
        <p>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="res" runat="server" font-bold="True" width="307px" visible="False">الطلاب
            المقبولين بالمدينة الجامعية</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DataGrid id="dg" runat="server" BorderColor="Blue"></asp:DataGrid>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <!-- Insert content here -->
        </p>
    </form>
</body>
</html>
