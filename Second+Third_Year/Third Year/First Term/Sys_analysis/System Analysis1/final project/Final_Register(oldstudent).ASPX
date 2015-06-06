<%@ Page Language="C#" Debug="true" %>
<%@ import Namespace="System.Web.Security " %>
<%@ import Namespace="System.Data " %>
<%@ import Namespace="System.Data.OleDb " %>
<%@ import Namespace="System.Data.SqlClient " %>
<script runat="server">

    // Insert page code here
    //
    
    void Button1_Click(object sender, EventArgs e) {
    string Name=st_name.Text;
    string number= st_number.Text;
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
    string degree=st_degree.SelectedItem.Text ;
    string build=st_build.SelectedItem.Text ;
     string connection;
       connection = " Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\madina project.mdb";
       OleDbConnection conn = new OleDbConnection( connection);//
       OleDbConnection conn1;//=new OleDbConnection( connection);
       conn.Open();
      OleDbCommand command,comm ;
      string sql;
    
      sql = " insert into Old values (  "+number+" ,' "+Name+"',' "+type+"',' "+rel+"',"+day+",' "+month+"',"+year+",' "+city+"',' "+govern+"',' "+name+"',' " +job+ "',' "+place+"',"+code+","+tele+",' "+facul+"',' "+degree+"',' "+ build+"')";
    
    
      //***********************************************//
      string s1="الحاسبات والمعلومات";
      string s2="العلوم";
     if(facul == "Engineering")
     {
      string sql1= " select * from fci ";
      OleDbDataReader data;
      command = new OleDbCommand(sql1,conn);
      data= command.ExecuteReader();
       while(data.Read())
     {
      if(number.Equals(data.GetString(0)))
      {
    //    conn.Close();
    //   conn1=new OleDbConnection( connection);
     //   conn1.Open();
         comm=new OleDbCommand(sql,conn);
         comm.ExecuteNonQuery();
         Response.Redirect("accept_request.aspx");
         conn.Close();
    
         }
        }
        }
        if((st_faculty.TabIndex) ==1)
     {
      string sql1= " select * from science ";
      OleDbDataReader data;
      command = new OleDbCommand(sql1,conn);
      data= command.ExecuteReader();
       while(data.Read())
     {
      if(Name.Equals(data.GetString(1)))
      {
         conn.Close();
         conn1=new OleDbConnection( connection);
         conn1.Open();
         comm=new OleDbCommand(sql,conn1);
         comm.ExecuteNonQuery();
         Response.Redirect("accept_request.aspx");
         conn1.Close();
    
         }
        }
        }
        if(st_faculty.SelectedIndex==2)
     {
      string sql1= " select * from tegara ";
      OleDbDataReader data;
      command = new OleDbCommand(sql1,conn);
      data= command.ExecuteReader();
       while(data.Read())
     {
      if(Name.Equals(data.GetString(1)))
      {
         conn.Close();
         conn1=new OleDbConnection( connection);
         conn1.Open();
         comm=new OleDbCommand(sql,conn1);
         comm.ExecuteNonQuery();
         Response.Redirect("accept_request.aspx");
         conn1.Close();
    
         }
        }
        }
    
          Response.Redirect("request refused.aspx");
    
    
    
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font size="6"><strong>صفحة
            التسجيل</strong></font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_number" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label15" runat="server">رقم البطاقة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox id="st_name" runat="server" Width="151px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label4" runat="server" width="77px">اسم
            الطالب</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_type" runat="server" Width="142px">
                <asp:ListItem Value="ذكر">ذكر</asp:ListItem>
                <asp:ListItem Value="انثى">انثى</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label2" runat="server" width="37px">النوع</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_relg" runat="server" Width="160px">
                <asp:ListItem Value="مسلم">مسلم</asp:ListItem>
                <asp:ListItem Value="مسيحى">مسيحى</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label3" runat="server" width="42px">الديانة</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:Label id="Label9" runat="server" width="79px">تاريخ الميلاد</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_year" runat="server" Width="66px"></asp:TextBox>
            &nbsp;<asp:Label id="Label5" runat="server" width="34px">سنة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:DropDownList id="st_month" runat="server">
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
            &nbsp;&nbsp; <asp:Label id="Label6" runat="server" width="54px">شهر</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox id="st_day" runat="server" Width="56px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; يوم&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            :&nbsp;محل الميلاد&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_govern" runat="server">
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
            &nbsp;<asp:Label id="Label11" runat="server" width="13px">المحافظة</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_city" runat="server" Width="96px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label id="Label10" runat="server" width="92px">القرية/
            المركز</asp:Label> 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_job" runat="server" Width="100px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label13" runat="server" width="85px">وظيفته</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;<asp:TextBox id="stt_name" runat="server" Width="100px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label12" runat="server" width="94px">اسم
            ولى الامر</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_place" runat="server" Width="113px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label id="Label14" runat="server" width="76px">محل
            عمله</asp:Label> 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_tele" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="st_code" runat="server" Width="39px"></asp:TextBox>
            &nbsp;&nbsp; <asp:Label id="Label16" runat="server" width="166px" height="24px">رقم
            التليفون ان وجد</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(3334461&nbsp;)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(065)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_faculty" runat="server" Width="182px">
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
                <asp:ListItem Value="Engineering">Engineering</asp:ListItem>
                <asp:ListItem Value="FCI">FCI</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp; <asp:Label id="Label17" runat="server">الكلية</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id="st_degree" runat="server" Width="182px">
                <asp:ListItem Value="جيد">جيد</asp:ListItem>
                <asp:ListItem Value="جيد جدا">جيد جدا</asp:ListItem>
                <asp:ListItem Value="امتياز">امتياز</asp:ListItem>
            </asp:DropDownList>
            &nbsp; <asp:Label id="Label1" runat="server" width="41px">التقدير</asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList id="st_build" runat="server" Width="201px">
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label id="Label18" runat="server" width="156px">المبنى
            الذى ترغب فيه: </asp:Label>
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
            <asp:Button id="Button1" onclick="Button1_Click" runat="server" Width="121px" Text="Submit"></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input style="WIDTH: 124px; HEIGHT: 24px" type="reset" size="44" value="Reset" />&nbsp; 
        </p>
    </form>
    <!-- Insert content here -->
</body>
</html>
