<%@ Page Language="C#" Debug="true" %>
<%@ import Namespace="System.Web.Security " %>
<%@ import Namespace="System.Data " %>
<%@ import Namespace="System.Data.OleDb " %>
<%@ import Namespace="System.Data.SqlClient " %>
<script runat="server">

    // Insert page code here
    //
    
    void Button1_Click(object sender, EventArgs e)
    
     {
    string Name=st_name.Text;
    int number= Convert.ToInt32(st_number.Text);
    string rel=st_relg.SelectedItem.Text ;
    string type=st_type.SelectedItem.Text ;
    int day=Convert.ToInt32(st_day.Text);
    string month=st_month.SelectedItem.Text ;
    int year=Convert.ToInt32(st_year.Text);
    string city= st_city.Text;
    string govern=st_govern.SelectedItem.Text ;
    string name=stt_name.Text;
    string job=st_job.Text;
    string place=st_place.Text;
    int code=Convert.ToInt32(st_code.Text);
    int tele=Convert.ToInt32(st_tele.Text);
    string facul=st_faculty.SelectedItem.Text ;
    string build=st_build.SelectedItem.Text ;
     string connection;
       connection = " Provider = Microsoft.Jet.OLEDB.4.0; Data Source = madina project.mdb";
       OleDbConnection conn = new OleDbConnection( connection);
       conn.Open();
      OleDbCommand command ;
      string sql;
    
    
           sql = " insert into students values (  "+number+" ,' "+Name+"',' "+type+"',' "+rel+"',"+day+",' "+month+"',"+year+",' "+city+"',' "+govern+"',' "+name+"',' " +job+ "',' "+place+"',"+code+","+tele+",' "+facul+"',' "+ build+"')";
    
             command = new OleDbCommand(sql,conn);
             command.ExecuteNonQuery();
             Response.Redirect("accept_request.aspx");
              conn.Close();
    
    
    
    }

</script>
<html>
<head>
</head>
<body background="GrayPaper.gif">
    <form runat="server">
        <p>
            &nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color="#008040" size="6"><strong>صفحة
            التسجيل</strong></font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;<asp:TextBox id="st_number" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label15" runat="server">رقم البطاقة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_name" runat="server" Width="151px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<asp:Label id="Label4" runat="server" width="78px">اسم الطالب</asp:Label>&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;<asp:DropDownList id="st_type" runat="server" Width="157px">
                <asp:ListItem Value="ذكر">ذكر</asp:ListItem>
                <asp:ListItem Value="انثى">انثى</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label2" runat="server" width="37px">النوع</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:DropDownList id="st_relg" runat="server" Width="151px">
                <asp:ListItem Value="مسلم">مسلم</asp:ListItem>
                <asp:ListItem Value="مسيحى">مسيحى</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label3" runat="server" width="42px">الديانة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label9" runat="server" width="95px">تاريخ
            الميلاد</asp:Label>&nbsp; &nbsp;<asp:TextBox id="st_year" runat="server" Width="105px"></asp:TextBox>
            &nbsp;<asp:Label id="Label5" runat="server" width="34px">سنة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_month" runat="server" Width="102px">
                <asp:ListItem Value="يناير">يناير</asp:ListItem>
                <asp:ListItem Value="فبراير">فبراير</asp:ListItem>
                <asp:ListItem Value="مارس">مارس</asp:ListItem>
                <asp:ListItem Value="ابريل">ابريل</asp:ListItem>
                <asp:ListItem Value="مايو">مايو</asp:ListItem>
                <asp:ListItem Value="يونيه">يونيه</asp:ListItem>
                <asp:ListItem Value="يوليه">يوليه</asp:ListItem>
                <asp:ListItem Value="اغسطس">اغسطس</asp:ListItem>
                <asp:ListItem Value="سبتمبر">سبتمبر</asp:ListItem>
                <asp:ListItem Value="اكتوبر">اكتوبر</asp:ListItem>
                <asp:ListItem Value="نوفمبر">نوفمبر</asp:ListItem>
                <asp:ListItem Value="ديسمبر">ديسمبر</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp; <asp:Label id="Label6" runat="server" width="54px">شهر</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox id="st_day" runat="server" Width="68px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; يوم&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;محل
            الميلاد&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_govern" runat="server">
                <asp:ListItem Value="القاهرة">القاهرة</asp:ListItem>
                <asp:ListItem Value="الا سكندرية">الا سكندرية</asp:ListItem>
                <asp:ListItem Value="الجيزة">الجيزة</asp:ListItem>
                <asp:ListItem Value="المنوفية">المنوفية</asp:ListItem>
                <asp:ListItem Value="الدقهلية">الدقهلية</asp:ListItem>
                <asp:ListItem Value="الغربية">الغربية</asp:ListItem>
                <asp:ListItem Value="الشرقية">الشرقية</asp:ListItem>
                <asp:ListItem Value="مرسى مطروح">مرسى مطروح</asp:ListItem>
                <asp:ListItem Value="السويس">السويس</asp:ListItem>
                <asp:ListItem Value="الا سماعيلية">الا سماعيلية</asp:ListItem>
                <asp:ListItem Value="بورسعيد">بورسعيد</asp:ListItem>
                <asp:ListItem Value="الفيوم">الفيوم</asp:ListItem>
                <asp:ListItem Value="بنى سويف">بنى سويف</asp:ListItem>
                <asp:ListItem Value="المنيا">المنيا</asp:ListItem>
                <asp:ListItem Value="اسيوط">اسيوط</asp:ListItem>
                <asp:ListItem Value="سوهاج">سوهاج</asp:ListItem>
                <asp:ListItem Value="قنا">قنا</asp:ListItem>
                <asp:ListItem Value="اسوان">اسوان</asp:ListItem>
                <asp:ListItem Value="البحر الاحمر">البحر الاحمر</asp:ListItem>
                <asp:ListItem Value="الوادى الجديد">الوادى الجديد</asp:ListItem>
                <asp:ListItem Value="القليوبية">القليوبية</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:Label id="Label11" runat="server" width="13px">المحافظة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:TextBox id="st_city" runat="server" Width="96px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label10" runat="server" width="92px">القرية/
            المركز</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox id="st_job" runat="server" Width="100px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label13" runat="server" width="43px">وظيفته</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox id="stt_name" runat="server" Width="100px"></asp:TextBox>
            &nbsp;&nbsp; <asp:Label id="Label12" runat="server" width="129px">اسم ولى الامر</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:TextBox id="st_place" runat="server" Width="195px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label id="Label1" runat="server" width="76px">محل
            عمله</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_tele" runat="server" Width="132px"></asp:TextBox>
            -&nbsp;<asp:TextBox id="st_code" runat="server" Width="39px"></asp:TextBox>
            &nbsp;&nbsp; &nbsp;<asp:Label id="Label16" runat="server" width="128px" height="24px">رقم
            التليفون ان وجد</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp; 
            <asp:DropDownList id="st_faculty" runat="server" Width="197px">
                <asp:ListItem Value="الحاسبات والمعلومات">الحاسبات والمعلومات</asp:ListItem>
                <asp:ListItem Value="الهندسة">الهندسة</asp:ListItem>
                <asp:ListItem Value="الطب البشرى">الطب البشرى</asp:ListItem>
                <asp:ListItem Value="الصيدلة">الصيدلة</asp:ListItem>
                <asp:ListItem Value="العلوم">العلوم</asp:ListItem>
                <asp:ListItem Value="الزراعة">الزراعة</asp:ListItem>
                <asp:ListItem Value="الحقوق">الحقوق</asp:ListItem>
                <asp:ListItem Value="التجارة">التجارة</asp:ListItem>
                <asp:ListItem Value="التربية ">التربية </asp:ListItem>
                <asp:ListItem Value="الطب البيطرى">الطب البيطرى</asp:ListItem>
                <asp:ListItem Value="التربية الرياضية">التربية الرياضية</asp:ListItem>
                <asp:ListItem Value="اداب">اداب</asp:ListItem>
                <asp:ListItem Value="خدمة اجتماعية">خدمة اجتماعية</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label17" runat="server" width="48px">الكلية</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label18" runat="server" width="163px">المبنى
            الذى ترغب فيه: </asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:DropDownList id="st_build" runat="server" Width="201px">
                <asp:ListItem Value="مبنى ا">مبنى ا</asp:ListItem>
                <asp:ListItem Value="مبنى ب">مبنى ب</asp:ListItem>
                <asp:ListItem Value="مبنى ج">مبنى ج</asp:ListItem>
                <asp:ListItem Value="مبنى د">مبنى د</asp:ListItem>
                <asp:ListItem Value="مبنى و">مبنى و</asp:ListItem>
                <asp:ListItem Value="مبنى ز">مبنى ز</asp:ListItem>
                <asp:ListItem Value="مبنى س">مبنى س</asp:ListItem>
                <asp:ListItem Value="مبنى ع">مبنى ع</asp:ListItem>
                <asp:ListItem Value="قطاع 1">قطاع 1</asp:ListItem>
                <asp:ListItem Value="قطاع 1">قطاع 1</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p style="BACKGROUND-COLOR: bisque">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button id="Button1" onclick="Button1_Click" runat="server" Width="121px" Text="تسجيل"></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input style="WIDTH: 124px; HEIGHT: 24px" type="reset" size="44" value="مسح" />&nbsp; 
        </p>
    </form>
</body>
</html>
