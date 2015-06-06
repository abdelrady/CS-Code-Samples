/*
 * Created by SharpDevelop.
 * User: pc123
 * Date: 1/6/2006
 * Time: 1:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using FormEffect;
	/// <summary>
	/// Description of Form1.	
	/// </summary>
public struct  student
{
	public string f_name;
	public string l_name;
	public int id;
	public int stage;
    public int s_year;
    public int status;
    public int help_grades;			
}
public struct admin
{
    public string name;
    public string pass;
}
public struct grade
{
    public int midterm;
    public int term;
}
public struct coarse
{
	public int c_id;
	public string name;
}
			
public class Form1 : System.Windows.Forms.Form
{
    //private
    private WindowsApplication1.Connection cnn;
    private OleDbCommand cmd;
	private const int ID_ERROR=-2147467259;
	private const int DATE_ERROR=-2147217913;
	private const int REFRENTIAL_INTEGRITY_ERROR=-2147467259;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.TextBox del_last_name;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.Label results;
	private System.Windows.Forms.TextBox s_id;
	private System.Windows.Forms.Button prev;
	private System.Windows.Forms.Button add_clear;
	private System.Windows.Forms.GroupBox groupBox4;
	private System.Windows.Forms.GroupBox groupBox3;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.TextBox r_stage;
	private System.Windows.Forms.Button get_results;
	private System.Windows.Forms.TextBox r_first_name;
	private System.Windows.Forms.Button button4;
	private System.Windows.Forms.Button update;
	private System.Windows.Forms.CheckBox ch_first_name;
	private System.Windows.Forms.TabPage tabPage5;
	public System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.CheckBox new_last_name;
	private System.Windows.Forms.CheckBox new_id;
	private System.Windows.Forms.TextBox up_first_name2;
	private System.Windows.Forms.TextBox up_last_name1;
	private System.Windows.Forms.CheckBox new_first_name;
	private System.Windows.Forms.TextBox s_first_name;
    private System.Windows.Forms.Label first_named;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.CheckBox ch_up_first_name;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox s_last_name;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Button next;
	private System.Windows.Forms.TextBox r_last_name;
	private System.Windows.Forms.CheckBox ch_s_id;
    private System.Windows.Forms.CheckBox ch_s_first_name;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.CheckBox new_dob;
	private System.Windows.Forms.CheckBox ch_last_name;
	private System.Windows.Forms.TextBox textBox5;
	private System.Windows.Forms.TabPage tabPage3;
	private System.Windows.Forms.TabPage tabPage2;
	private System.Windows.Forms.TextBox r_id;
	private System.Windows.Forms.TabPage tabPage4;
	private System.Windows.Forms.TextBox up_first_name1;
	private System.Windows.Forms.Button cl;
	private System.Windows.Forms.TextBox del_id;
	private System.Windows.Forms.Button next2;
	private System.Windows.Forms.TextBox last_name;
	private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox ch_id;
	private System.Windows.Forms.TextBox up_id1;
	private System.Windows.Forms.CheckBox ch_s_stage;
	private System.Windows.Forms.Label last_named;
	private System.Windows.Forms.TextBox del_first_name;
	private System.Windows.Forms.CheckBox ch_up_last_name;
	private System.Windows.Forms.Label idd;
	private System.Windows.Forms.Button prev2;
	private System.Windows.Forms.TextBox up_id2;
	private System.Windows.Forms.TextBox up_last_name2;
	private System.Windows.Forms.CheckBox ch_up_dob;
    private System.Windows.Forms.TextBox id;
	private System.Windows.Forms.CheckBox ch_up_id;
	private System.Windows.Forms.CheckBox ch_s_last_name;
	private System.Windows.Forms.Button search;
	private System.Windows.Forms.TextBox first_name;
	private System.Windows.Forms.Label label3;
    private OleDbDataReader reader;
	public int index;
	public int size;
	public int index2;
	public int size2;
	public int st_id;
	private System.Windows.Forms.TabPage tabPage6;
	private System.Windows.Forms.Button display;
    private System.Windows.Forms.DataGrid dataGrid1;
	student[] students;
	coarse[] coarses;
    static coarse[] coarses2;
    grade[] grade1;
    //bool flag1;
	private System.Windows.Forms.ContextMenu contextMenu1; //////////////////
	private System.Windows.Forms.MenuItem menuItem1;
	private System.Windows.Forms.MenuItem update_st;
    private System.Windows.Forms.MenuItem del_st;
    private Label label10;
    private TextBox s_year;
    private ComboBox status;
    private Label label11;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private ComboBox status3;
    private ComboBox status2;
    private Label up_results;
    private ComboBox cbstage;
    private ComboBox cb3stage;
    private ComboBox cb5stage;
    private ComboBox cb4stage;
    private TabPage tabPage9;
    private Button button5;
    private GroupBox groupBox10;
    private TextBox textBox1;
    private TextBox textBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private Button button6;
    private Button button7;
    private Button button8;
    private Label label13;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox6;
    private CheckBox checkBox5;
    private CheckBox checkBox6;
    private CheckBox checkBox7;
    private CheckBox checkBox8;
    private Button button9;
    private Button button10;
    private GroupBox groupBox11;
    private ComboBox comboBox3;
    private Label label14;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private Button button15;
    private Button button16;
    private ComboBox comboBox4;
    private Label label15;
    private TextBox textBox7;
    private CheckBox checkBox9;
    private CheckBox checkBox10;
    private CheckBox checkBox11;
    private TextBox textBox8;
    private TextBox textBox9;
    private CheckBox checkBox12;
    private GroupBox groupBox9;
    private ComboBox comboBox5;
    private Label results2_2;
    private Button button19;
    private Button button17;
    private Button button18;
    private GroupBox groupBox12;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox13;
    private TextBox textBox12;
    private TextBox textBox11;
    private TextBox textBox10;
    private CheckBox checkBox18;
    private CheckBox checkBox17;
    private CheckBox checkBox16;
    private CheckBox checkBox15;
    private CheckBox checkBox14;
    private CheckBox checkBox13;
    private Button button20;
    private Button button21;
    private Button button22;
    private ImageList imageList1;
    private ComboBox comboBox1;
    private Label label9;
    private System.ComponentModel.IContainer components;
	//bool flag2;

	public Form1(WindowsApplication1.Connection asd)
	{
		//
		// The InitializeComponent() call is required for Windows Forms designer support.
		//
		InitializeComponent();
		//parent=p;
		this.AcceptButton=button1;
		students=new student[15];
		coarses=new coarse[15];
        coarses2 = new coarse[15];
        grade1=new grade[15];
		//connect();
//		flag1=false;
		//flag2=false;
        cnn = asd;
			
			
		//
		// TODO: Add constructor code after the InitializeComponent() call.
		//
	}
		
	#region Windows Forms Designer generated code
	/// <summary>
	/// This method is required for Windows Forms designer support.
	/// Do not change the method contents inside the source code editor. The Forms designer might
	/// not be able to load this method if it was changed manually.
	/// </summary>
	private void InitializeComponent() 
	{
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.label3 = new System.Windows.Forms.Label();
        this.first_name = new System.Windows.Forms.TextBox();
        this.search = new System.Windows.Forms.Button();
        this.ch_s_last_name = new System.Windows.Forms.CheckBox();
        this.ch_up_id = new System.Windows.Forms.CheckBox();
        this.id = new System.Windows.Forms.TextBox();
        this.ch_up_dob = new System.Windows.Forms.CheckBox();
        this.up_last_name2 = new System.Windows.Forms.TextBox();
        this.up_id2 = new System.Windows.Forms.TextBox();
        this.prev2 = new System.Windows.Forms.Button();
        this.idd = new System.Windows.Forms.Label();
        this.ch_up_last_name = new System.Windows.Forms.CheckBox();
        this.del_first_name = new System.Windows.Forms.TextBox();
        this.last_named = new System.Windows.Forms.Label();
        this.ch_s_stage = new System.Windows.Forms.CheckBox();
        this.up_id1 = new System.Windows.Forms.TextBox();
        this.ch_id = new System.Windows.Forms.CheckBox();
        this.label5 = new System.Windows.Forms.Label();
        this.last_name = new System.Windows.Forms.TextBox();
        this.next2 = new System.Windows.Forms.Button();
        this.del_id = new System.Windows.Forms.TextBox();
        this.cl = new System.Windows.Forms.Button();
        this.up_first_name1 = new System.Windows.Forms.TextBox();
        this.tabPage4 = new System.Windows.Forms.TabPage();
        this.button2 = new System.Windows.Forms.Button();
        this.del_last_name = new System.Windows.Forms.TextBox();
        this.ch_last_name = new System.Windows.Forms.CheckBox();
        this.button3 = new System.Windows.Forms.Button();
        this.ch_first_name = new System.Windows.Forms.CheckBox();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.r_id = new System.Windows.Forms.TextBox();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.r_stage = new System.Windows.Forms.TextBox();
        this.r_last_name = new System.Windows.Forms.TextBox();
        this.r_first_name = new System.Windows.Forms.TextBox();
        this.label8 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.ch_s_first_name = new System.Windows.Forms.CheckBox();
        this.ch_s_id = new System.Windows.Forms.CheckBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.cb3stage = new System.Windows.Forms.ComboBox();
        this.button4 = new System.Windows.Forms.Button();
        this.s_last_name = new System.Windows.Forms.TextBox();
        this.s_first_name = new System.Windows.Forms.TextBox();
        this.s_id = new System.Windows.Forms.TextBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.results = new System.Windows.Forms.Label();
        this.next = new System.Windows.Forms.Button();
        this.prev = new System.Windows.Forms.Button();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label9 = new System.Windows.Forms.Label();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.cbstage = new System.Windows.Forms.ComboBox();
        this.status = new System.Windows.Forms.ComboBox();
        this.label11 = new System.Windows.Forms.Label();
        this.label10 = new System.Windows.Forms.Label();
        this.s_year = new System.Windows.Forms.TextBox();
        this.add_clear = new System.Windows.Forms.Button();
        this.button1 = new System.Windows.Forms.Button();
        this.first_named = new System.Windows.Forms.Label();
        this.textBox5 = new System.Windows.Forms.TextBox();
        this.new_dob = new System.Windows.Forms.CheckBox();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.ch_up_first_name = new System.Windows.Forms.CheckBox();
        this.label2 = new System.Windows.Forms.Label();
        this.new_first_name = new System.Windows.Forms.CheckBox();
        this.up_last_name1 = new System.Windows.Forms.TextBox();
        this.up_first_name2 = new System.Windows.Forms.TextBox();
        this.new_id = new System.Windows.Forms.CheckBox();
        this.new_last_name = new System.Windows.Forms.CheckBox();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage6 = new System.Windows.Forms.TabPage();
        this.dataGrid1 = new System.Windows.Forms.DataGrid();
        this.display = new System.Windows.Forms.Button();
        this.tabPage5 = new System.Windows.Forms.TabPage();
        this.cb5stage = new System.Windows.Forms.ComboBox();
        this.cb4stage = new System.Windows.Forms.ComboBox();
        this.checkBox2 = new System.Windows.Forms.CheckBox();
        this.checkBox1 = new System.Windows.Forms.CheckBox();
        this.status3 = new System.Windows.Forms.ComboBox();
        this.status2 = new System.Windows.Forms.ComboBox();
        this.up_results = new System.Windows.Forms.Label();
        this.update = new System.Windows.Forms.Button();
        this.get_results = new System.Windows.Forms.Button();
        this.tabPage9 = new System.Windows.Forms.TabPage();
        this.groupBox12 = new System.Windows.Forms.GroupBox();
        this.button22 = new System.Windows.Forms.Button();
        this.button21 = new System.Windows.Forms.Button();
        this.button20 = new System.Windows.Forms.Button();
        this.textBox15 = new System.Windows.Forms.TextBox();
        this.textBox14 = new System.Windows.Forms.TextBox();
        this.textBox13 = new System.Windows.Forms.TextBox();
        this.textBox12 = new System.Windows.Forms.TextBox();
        this.textBox11 = new System.Windows.Forms.TextBox();
        this.textBox10 = new System.Windows.Forms.TextBox();
        this.checkBox18 = new System.Windows.Forms.CheckBox();
        this.checkBox17 = new System.Windows.Forms.CheckBox();
        this.checkBox16 = new System.Windows.Forms.CheckBox();
        this.checkBox15 = new System.Windows.Forms.CheckBox();
        this.checkBox14 = new System.Windows.Forms.CheckBox();
        this.checkBox13 = new System.Windows.Forms.CheckBox();
        this.textBox7 = new System.Windows.Forms.TextBox();
        this.checkBox9 = new System.Windows.Forms.CheckBox();
        this.checkBox10 = new System.Windows.Forms.CheckBox();
        this.checkBox11 = new System.Windows.Forms.CheckBox();
        this.textBox8 = new System.Windows.Forms.TextBox();
        this.textBox9 = new System.Windows.Forms.TextBox();
        this.checkBox12 = new System.Windows.Forms.CheckBox();
        this.groupBox9 = new System.Windows.Forms.GroupBox();
        this.comboBox5 = new System.Windows.Forms.ComboBox();
        this.results2_2 = new System.Windows.Forms.Label();
        this.button19 = new System.Windows.Forms.Button();
        this.button17 = new System.Windows.Forms.Button();
        this.button18 = new System.Windows.Forms.Button();
        this.contextMenu1 = new System.Windows.Forms.ContextMenu();
        this.update_st = new System.Windows.Forms.MenuItem();
        this.del_st = new System.Windows.Forms.MenuItem();
        this.menuItem1 = new System.Windows.Forms.MenuItem();
        this.button5 = new System.Windows.Forms.Button();
        this.groupBox10 = new System.Windows.Forms.GroupBox();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.checkBox3 = new System.Windows.Forms.CheckBox();
        this.checkBox4 = new System.Windows.Forms.CheckBox();
        this.button6 = new System.Windows.Forms.Button();
        this.button7 = new System.Windows.Forms.Button();
        this.button8 = new System.Windows.Forms.Button();
        this.label13 = new System.Windows.Forms.Label();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.textBox6 = new System.Windows.Forms.TextBox();
        this.checkBox5 = new System.Windows.Forms.CheckBox();
        this.checkBox6 = new System.Windows.Forms.CheckBox();
        this.checkBox7 = new System.Windows.Forms.CheckBox();
        this.checkBox8 = new System.Windows.Forms.CheckBox();
        this.button9 = new System.Windows.Forms.Button();
        this.button10 = new System.Windows.Forms.Button();
        this.groupBox11 = new System.Windows.Forms.GroupBox();
        this.comboBox3 = new System.Windows.Forms.ComboBox();
        this.label14 = new System.Windows.Forms.Label();
        this.button11 = new System.Windows.Forms.Button();
        this.button12 = new System.Windows.Forms.Button();
        this.button13 = new System.Windows.Forms.Button();
        this.button14 = new System.Windows.Forms.Button();
        this.button15 = new System.Windows.Forms.Button();
        this.button16 = new System.Windows.Forms.Button();
        this.comboBox4 = new System.Windows.Forms.ComboBox();
        this.label15 = new System.Windows.Forms.Label();
        this.imageList1 = new System.Windows.Forms.ImageList(this.components);
        this.tabPage4.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
        this.tabPage5.SuspendLayout();
        this.tabPage9.SuspendLayout();
        this.groupBox12.SuspendLayout();
        this.groupBox9.SuspendLayout();
        this.groupBox10.SuspendLayout();
        this.groupBox11.SuspendLayout();
        this.SuspendLayout();
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.ForeColor = System.Drawing.Color.Firebrick;
        this.label3.Location = new System.Drawing.Point(368, 24);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(136, 32);
        this.label3.TabIndex = 13;
        this.label3.Text = "New Value";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label3.Click += new System.EventHandler(this.label3_Click);
        // 
        // first_name
        // 
        this.first_name.Location = new System.Drawing.Point(128, 59);
        this.first_name.Name = "first_name";
        this.first_name.Size = new System.Drawing.Size(153, 20);
        this.first_name.TabIndex = 5;
        this.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
        // 
        // search
        // 
        this.search.Location = new System.Drawing.Point(376, 120);
        this.search.Name = "search";
        this.search.Size = new System.Drawing.Size(88, 40);
        this.search.TabIndex = 4;
        this.search.Text = "Search";
        this.search.Click += new System.EventHandler(this.SearchClick);
        // 
        // ch_s_last_name
        // 
        this.ch_s_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_s_last_name.Location = new System.Drawing.Point(16, 118);
        this.ch_s_last_name.Name = "ch_s_last_name";
        this.ch_s_last_name.Size = new System.Drawing.Size(112, 24);
        this.ch_s_last_name.TabIndex = 3;
        this.ch_s_last_name.Text = "Last Name";
        this.ch_s_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_s_last_name.CheckedChanged += new System.EventHandler(this.CheckBox5CheckedChanged);
        // 
        // ch_up_id
        // 
        this.ch_up_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_up_id.Location = new System.Drawing.Point(16, 60);
        this.ch_up_id.Name = "ch_up_id";
        this.ch_up_id.Size = new System.Drawing.Size(120, 32);
        this.ch_up_id.TabIndex = 0;
        this.ch_up_id.Text = "ID:";
        this.ch_up_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_up_id.CheckedChanged += new System.EventHandler(this.Ch_up_idCheckedChanged);
        // 
        // id
        // 
        this.id.Enabled = false;
        this.id.Location = new System.Drawing.Point(128, 27);
        this.id.Name = "id";
        this.id.Size = new System.Drawing.Size(153, 20);
        this.id.TabIndex = 4;
        this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
        // 
        // ch_up_dob
        // 
        this.ch_up_dob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_up_dob.Location = new System.Drawing.Point(16, 165);
        this.ch_up_dob.Name = "ch_up_dob";
        this.ch_up_dob.Size = new System.Drawing.Size(120, 32);
        this.ch_up_dob.TabIndex = 3;
        this.ch_up_dob.Text = "Stage:";
        this.ch_up_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_up_dob.CheckedChanged += new System.EventHandler(this.Ch_up_dobCheckedChanged);
        // 
        // up_last_name2
        // 
        this.up_last_name2.Enabled = false;
        this.up_last_name2.Location = new System.Drawing.Point(360, 137);
        this.up_last_name2.Name = "up_last_name2";
        this.up_last_name2.Size = new System.Drawing.Size(160, 20);
        this.up_last_name2.TabIndex = 11;
        this.up_last_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_last_name2.TextChanged += new System.EventHandler(this.up_last_name2_TextChanged);
        // 
        // up_id2
        // 
        this.up_id2.Enabled = false;
        this.up_id2.Location = new System.Drawing.Point(360, 64);
        this.up_id2.Name = "up_id2";
        this.up_id2.Size = new System.Drawing.Size(160, 20);
        this.up_id2.TabIndex = 9;
        this.up_id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_id2.TextChanged += new System.EventHandler(this.up_id2_TextChanged);
        // 
        // prev2
        // 
        this.prev2.Enabled = false;
        this.prev2.Location = new System.Drawing.Point(24, 311);
        this.prev2.Name = "prev2";
        this.prev2.Size = new System.Drawing.Size(128, 40);
        this.prev2.TabIndex = 20;
        this.prev2.Text = "<< prev";
        this.prev2.Click += new System.EventHandler(this.Prev2Click);
        // 
        // idd
        // 
        this.idd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.idd.Location = new System.Drawing.Point(32, 19);
        this.idd.Name = "idd";
        this.idd.Size = new System.Drawing.Size(88, 32);
        this.idd.TabIndex = 0;
        this.idd.Text = "Student ID :";
        this.idd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.idd.Click += new System.EventHandler(this.idd_Click);
        // 
        // ch_up_last_name
        // 
        this.ch_up_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_up_last_name.Location = new System.Drawing.Point(16, 135);
        this.ch_up_last_name.Name = "ch_up_last_name";
        this.ch_up_last_name.Size = new System.Drawing.Size(104, 24);
        this.ch_up_last_name.TabIndex = 1;
        this.ch_up_last_name.Text = "Last Name:";
        this.ch_up_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_up_last_name.CheckedChanged += new System.EventHandler(this.Ch_up_last_nameCheckedChanged);
        // 
        // del_first_name
        // 
        this.del_first_name.Enabled = false;
        this.del_first_name.Location = new System.Drawing.Point(144, 88);
        this.del_first_name.Name = "del_first_name";
        this.del_first_name.Size = new System.Drawing.Size(192, 20);
        this.del_first_name.TabIndex = 3;
        this.del_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.del_first_name.TextChanged += new System.EventHandler(this.del_first_name_TextChanged);
        // 
        // last_named
        // 
        this.last_named.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.last_named.Location = new System.Drawing.Point(32, 90);
        this.last_named.Name = "last_named";
        this.last_named.Size = new System.Drawing.Size(88, 32);
        this.last_named.TabIndex = 2;
        this.last_named.Text = "Last Name :";
        this.last_named.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.last_named.Click += new System.EventHandler(this.last_named_Click);
        // 
        // ch_s_stage
        // 
        this.ch_s_stage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_s_stage.Location = new System.Drawing.Point(16, 158);
        this.ch_s_stage.Name = "ch_s_stage";
        this.ch_s_stage.Size = new System.Drawing.Size(112, 24);
        this.ch_s_stage.TabIndex = 4;
        this.ch_s_stage.Text = "Stage";
        this.ch_s_stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_s_stage.CheckedChanged += new System.EventHandler(this.CheckBox6CheckedChanged);
        // 
        // up_id1
        // 
        this.up_id1.Enabled = false;
        this.up_id1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.up_id1.Location = new System.Drawing.Point(144, 64);
        this.up_id1.Name = "up_id1";
        this.up_id1.Size = new System.Drawing.Size(152, 21);
        this.up_id1.TabIndex = 5;
        this.up_id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_id1.TextChanged += new System.EventHandler(this.up_id1_TextChanged);
        // 
        // ch_id
        // 
        this.ch_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_id.Location = new System.Drawing.Point(16, 35);
        this.ch_id.Name = "ch_id";
        this.ch_id.Size = new System.Drawing.Size(104, 40);
        this.ch_id.TabIndex = 0;
        this.ch_id.Text = "Student ID";
        this.ch_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_id.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(16, 151);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(104, 32);
        this.label5.TabIndex = 3;
        this.label5.Text = "Stage :";
        this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        this.label5.Click += new System.EventHandler(this.label5_Click);
        // 
        // last_name
        // 
        this.last_name.Location = new System.Drawing.Point(128, 94);
        this.last_name.Name = "last_name";
        this.last_name.Size = new System.Drawing.Size(153, 20);
        this.last_name.TabIndex = 6;
        this.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.last_name.TextChanged += new System.EventHandler(this.last_name_TextChanged);
        // 
        // next2
        // 
        this.next2.Enabled = false;
        this.next2.Location = new System.Drawing.Point(400, 311);
        this.next2.Name = "next2";
        this.next2.Size = new System.Drawing.Size(128, 40);
        this.next2.TabIndex = 21;
        this.next2.Text = "next >>";
        this.next2.Click += new System.EventHandler(this.Next2Click);
        // 
        // del_id
        // 
        this.del_id.Enabled = false;
        this.del_id.Location = new System.Drawing.Point(144, 48);
        this.del_id.Name = "del_id";
        this.del_id.Size = new System.Drawing.Size(192, 20);
        this.del_id.TabIndex = 2;
        this.del_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.del_id.TextChanged += new System.EventHandler(this.del_id_TextChanged);
        // 
        // cl
        // 
        this.cl.Location = new System.Drawing.Point(32, 352);
        this.cl.Name = "cl";
        this.cl.Size = new System.Drawing.Size(112, 40);
        this.cl.TabIndex = 23;
        this.cl.Text = "Clear";
        this.cl.Click += new System.EventHandler(this.ClClick);
        // 
        // up_first_name1
        // 
        this.up_first_name1.Enabled = false;
        this.up_first_name1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.up_first_name1.Location = new System.Drawing.Point(144, 100);
        this.up_first_name1.Name = "up_first_name1";
        this.up_first_name1.Size = new System.Drawing.Size(152, 21);
        this.up_first_name1.TabIndex = 6;
        this.up_first_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_first_name1.TextChanged += new System.EventHandler(this.up_first_name1_TextChanged);
        // 
        // tabPage4
        // 
        this.tabPage4.Controls.Add(this.button2);
        this.tabPage4.Controls.Add(this.del_last_name);
        this.tabPage4.Controls.Add(this.ch_last_name);
        this.tabPage4.Controls.Add(this.button3);
        this.tabPage4.Controls.Add(this.del_first_name);
        this.tabPage4.Controls.Add(this.del_id);
        this.tabPage4.Controls.Add(this.ch_first_name);
        this.tabPage4.Controls.Add(this.ch_id);
        this.tabPage4.Controls.Add(this.groupBox4);
        this.tabPage4.Location = new System.Drawing.Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Size = new System.Drawing.Size(560, 406);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "Delete";
        this.tabPage4.UseVisualStyleBackColor = true;
        this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
        this.tabPage4.Leave += new System.EventHandler(this.tabPage4_Leave);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(384, 80);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(72, 40);
        this.button2.TabIndex = 7;
        this.button2.Text = "Clear";
        this.button2.Click += new System.EventHandler(this.ClClick);
        // 
        // del_last_name
        // 
        this.del_last_name.Enabled = false;
        this.del_last_name.Location = new System.Drawing.Point(144, 136);
        this.del_last_name.Name = "del_last_name";
        this.del_last_name.Size = new System.Drawing.Size(192, 20);
        this.del_last_name.TabIndex = 6;
        this.del_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.del_last_name.TextChanged += new System.EventHandler(this.del_last_name_TextChanged);
        // 
        // ch_last_name
        // 
        this.ch_last_name.Enabled = false;
        this.ch_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_last_name.Location = new System.Drawing.Point(16, 128);
        this.ch_last_name.Name = "ch_last_name";
        this.ch_last_name.Size = new System.Drawing.Size(96, 32);
        this.ch_last_name.TabIndex = 5;
        this.ch_last_name.Text = "Last name";
        this.ch_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_last_name.CheckedChanged += new System.EventHandler(this.Del_last_nameCheckedChanged);
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(128, 240);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(224, 40);
        this.button3.TabIndex = 4;
        this.button3.Text = "Delete";
        this.button3.Click += new System.EventHandler(this.Button3Click);
        // 
        // ch_first_name
        // 
        this.ch_first_name.Enabled = false;
        this.ch_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_first_name.Location = new System.Drawing.Point(16, 80);
        this.ch_first_name.Name = "ch_first_name";
        this.ch_first_name.Size = new System.Drawing.Size(96, 32);
        this.ch_first_name.TabIndex = 1;
        this.ch_first_name.Text = "First name";
        this.ch_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_first_name.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
        // 
        // groupBox4
        // 
        this.groupBox4.Location = new System.Drawing.Point(8, 16);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(480, 288);
        this.groupBox4.TabIndex = 8;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Delete Criteria";
        this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
        // 
        // r_id
        // 
        this.r_id.Enabled = false;
        this.r_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.r_id.Location = new System.Drawing.Point(24, 288);
        this.r_id.Name = "r_id";
        this.r_id.Size = new System.Drawing.Size(88, 21);
        this.r_id.TabIndex = 10;
        this.r_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.r_id.TextChanged += new System.EventHandler(this.r_id_TextChanged);
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.r_stage);
        this.tabPage2.Controls.Add(this.r_last_name);
        this.tabPage2.Controls.Add(this.r_first_name);
        this.tabPage2.Controls.Add(this.r_id);
        this.tabPage2.Controls.Add(this.label8);
        this.tabPage2.Controls.Add(this.label7);
        this.tabPage2.Controls.Add(this.label6);
        this.tabPage2.Controls.Add(this.label4);
        this.tabPage2.Controls.Add(this.ch_s_stage);
        this.tabPage2.Controls.Add(this.ch_s_last_name);
        this.tabPage2.Controls.Add(this.ch_s_first_name);
        this.tabPage2.Controls.Add(this.ch_s_id);
        this.tabPage2.Controls.Add(this.groupBox2);
        this.tabPage2.Controls.Add(this.groupBox3);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Size = new System.Drawing.Size(560, 406);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Search";
        this.tabPage2.UseVisualStyleBackColor = true;
        this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
        this.tabPage2.Leave += new System.EventHandler(this.tabPage2_Leave);
        // 
        // r_stage
        // 
        this.r_stage.Enabled = false;
        this.r_stage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.r_stage.Location = new System.Drawing.Point(344, 288);
        this.r_stage.Name = "r_stage";
        this.r_stage.Size = new System.Drawing.Size(88, 21);
        this.r_stage.TabIndex = 13;
        this.r_stage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.r_stage.TextChanged += new System.EventHandler(this.r_stage_TextChanged);
        // 
        // r_last_name
        // 
        this.r_last_name.Enabled = false;
        this.r_last_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.r_last_name.Location = new System.Drawing.Point(232, 288);
        this.r_last_name.Name = "r_last_name";
        this.r_last_name.Size = new System.Drawing.Size(88, 21);
        this.r_last_name.TabIndex = 12;
        this.r_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.r_last_name.TextChanged += new System.EventHandler(this.r_last_name_TextChanged);
        // 
        // r_first_name
        // 
        this.r_first_name.Enabled = false;
        this.r_first_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.r_first_name.Location = new System.Drawing.Point(128, 288);
        this.r_first_name.Name = "r_first_name";
        this.r_first_name.Size = new System.Drawing.Size(88, 21);
        this.r_first_name.TabIndex = 11;
        this.r_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.r_first_name.TextChanged += new System.EventHandler(this.r_first_name_TextChanged);
        // 
        // label8
        // 
        this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label8.ForeColor = System.Drawing.Color.Firebrick;
        this.label8.Location = new System.Drawing.Point(336, 256);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(96, 24);
        this.label8.TabIndex = 9;
        this.label8.Text = "Stage";
        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label8.Click += new System.EventHandler(this.label8_Click);
        // 
        // label7
        // 
        this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label7.ForeColor = System.Drawing.Color.Firebrick;
        this.label7.Location = new System.Drawing.Point(232, 256);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(80, 24);
        this.label7.TabIndex = 8;
        this.label7.Text = "Last Name";
        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label7.Click += new System.EventHandler(this.label7_Click);
        // 
        // label6
        // 
        this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.ForeColor = System.Drawing.Color.Firebrick;
        this.label6.Location = new System.Drawing.Point(128, 256);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(80, 24);
        this.label6.TabIndex = 7;
        this.label6.Text = "First Name";
        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label6.Click += new System.EventHandler(this.label6_Click);
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.ForeColor = System.Drawing.Color.Firebrick;
        this.label4.Location = new System.Drawing.Point(24, 256);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(80, 24);
        this.label4.TabIndex = 6;
        this.label4.Text = "ID";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label4.Click += new System.EventHandler(this.label4_Click);
        // 
        // ch_s_first_name
        // 
        this.ch_s_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_s_first_name.Location = new System.Drawing.Point(16, 78);
        this.ch_s_first_name.Name = "ch_s_first_name";
        this.ch_s_first_name.Size = new System.Drawing.Size(112, 24);
        this.ch_s_first_name.TabIndex = 2;
        this.ch_s_first_name.Text = "First Name";
        this.ch_s_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_s_first_name.CheckedChanged += new System.EventHandler(this.CheckBox4CheckedChanged);
        // 
        // ch_s_id
        // 
        this.ch_s_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_s_id.Location = new System.Drawing.Point(16, 32);
        this.ch_s_id.Name = "ch_s_id";
        this.ch_s_id.Size = new System.Drawing.Size(112, 24);
        this.ch_s_id.TabIndex = 1;
        this.ch_s_id.Text = " ID";
        this.ch_s_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_s_id.CheckedChanged += new System.EventHandler(this.CheckBox3CheckedChanged);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.cb3stage);
        this.groupBox2.Controls.Add(this.button4);
        this.groupBox2.Controls.Add(this.search);
        this.groupBox2.Controls.Add(this.s_last_name);
        this.groupBox2.Controls.Add(this.s_first_name);
        this.groupBox2.Controls.Add(this.s_id);
        this.groupBox2.Location = new System.Drawing.Point(8, 8);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(480, 184);
        this.groupBox2.TabIndex = 5;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Search Criterea";
        this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
        // 
        // cb3stage
        // 
        this.cb3stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cb3stage.Enabled = false;
        this.cb3stage.FormattingEnabled = true;
        this.cb3stage.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.cb3stage.Location = new System.Drawing.Point(144, 152);
        this.cb3stage.Name = "cb3stage";
        this.cb3stage.Size = new System.Drawing.Size(216, 21);
        this.cb3stage.TabIndex = 6;
        this.cb3stage.SelectedIndexChanged += new System.EventHandler(this.cb3stage_SelectedIndexChanged);
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(376, 40);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(88, 40);
        this.button4.TabIndex = 5;
        this.button4.Text = "Clear";
        this.button4.Click += new System.EventHandler(this.ClClick);
        // 
        // s_last_name
        // 
        this.s_last_name.Enabled = false;
        this.s_last_name.Location = new System.Drawing.Point(144, 112);
        this.s_last_name.Name = "s_last_name";
        this.s_last_name.Size = new System.Drawing.Size(216, 20);
        this.s_last_name.TabIndex = 2;
        this.s_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.s_last_name.TextChanged += new System.EventHandler(this.s_last_name_TextChanged);
        // 
        // s_first_name
        // 
        this.s_first_name.Enabled = false;
        this.s_first_name.Location = new System.Drawing.Point(144, 72);
        this.s_first_name.Name = "s_first_name";
        this.s_first_name.Size = new System.Drawing.Size(216, 20);
        this.s_first_name.TabIndex = 1;
        this.s_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.s_first_name.TextChanged += new System.EventHandler(this.s_first_name_TextChanged);
        // 
        // s_id
        // 
        this.s_id.Enabled = false;
        this.s_id.Location = new System.Drawing.Point(144, 32);
        this.s_id.Name = "s_id";
        this.s_id.Size = new System.Drawing.Size(216, 20);
        this.s_id.TabIndex = 0;
        this.s_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.s_id.TextChanged += new System.EventHandler(this.s_id_TextChanged);
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.results);
        this.groupBox3.Controls.Add(this.next);
        this.groupBox3.Controls.Add(this.prev);
        this.groupBox3.Location = new System.Drawing.Point(16, 224);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(472, 152);
        this.groupBox3.TabIndex = 14;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Results";
        this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
        // 
        // results
        // 
        this.results.Location = new System.Drawing.Point(144, 112);
        this.results.Name = "results";
        this.results.Size = new System.Drawing.Size(128, 32);
        this.results.TabIndex = 2;
        this.results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.results.Click += new System.EventHandler(this.results_Click);
        // 
        // next
        // 
        this.next.Enabled = false;
        this.next.Location = new System.Drawing.Point(336, 120);
        this.next.Name = "next";
        this.next.Size = new System.Drawing.Size(80, 24);
        this.next.TabIndex = 1;
        this.next.Text = "next>>";
        this.next.Click += new System.EventHandler(this.NextClick);
        // 
        // prev
        // 
        this.prev.Enabled = false;
        this.prev.Location = new System.Drawing.Point(16, 120);
        this.prev.Name = "prev";
        this.prev.Size = new System.Drawing.Size(80, 24);
        this.prev.TabIndex = 0;
        this.prev.Text = "<<prev";
        this.prev.Click += new System.EventHandler(this.PrevClick);
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.label1);
        this.tabPage3.Controls.Add(this.groupBox1);
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(560, 406);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Add Student";
        this.tabPage3.UseVisualStyleBackColor = true;
        this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
        this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
        this.tabPage3.Leave += new System.EventHandler(this.tabPage3_Leave);
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(16, 8);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(344, 32);
        this.label1.TabIndex = 1;
        this.label1.Text = "Please Enter the data of the student\'s you want to add";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.label9);
        this.groupBox1.Controls.Add(this.comboBox1);
        this.groupBox1.Controls.Add(this.cbstage);
        this.groupBox1.Controls.Add(this.status);
        this.groupBox1.Controls.Add(this.label11);
        this.groupBox1.Controls.Add(this.label10);
        this.groupBox1.Controls.Add(this.s_year);
        this.groupBox1.Controls.Add(this.add_clear);
        this.groupBox1.Controls.Add(this.button1);
        this.groupBox1.Controls.Add(this.id);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.last_named);
        this.groupBox1.Controls.Add(this.first_named);
        this.groupBox1.Controls.Add(this.idd);
        this.groupBox1.Controls.Add(this.last_name);
        this.groupBox1.Controls.Add(this.first_name);
        this.groupBox1.Location = new System.Drawing.Point(8, 40);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(420, 328);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Student\'s Data";
        this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
        // 
        // label9
        // 
        this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label9.Location = new System.Drawing.Point(32, 124);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(88, 32);
        this.label9.TabIndex = 17;
        this.label9.Text = "Gender:";
        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // comboBox1
        // 
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
        this.comboBox1.Location = new System.Drawing.Point(128, 130);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(153, 21);
        this.comboBox1.TabIndex = 16;
        // 
        // cbstage
        // 
        this.cbstage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cbstage.FormattingEnabled = true;
        this.cbstage.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.cbstage.Location = new System.Drawing.Point(128, 166);
        this.cbstage.Name = "cbstage";
        this.cbstage.Size = new System.Drawing.Size(153, 21);
        this.cbstage.TabIndex = 14;
        this.cbstage.SelectedIndexChanged += new System.EventHandler(this.cbstage_SelectedIndexChanged);
        // 
        // status
        // 
        this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.status.FormattingEnabled = true;
        this.status.Items.AddRange(new object[] {
            "doubler",
            "Fresh"});
        this.status.Location = new System.Drawing.Point(128, 233);
        this.status.Name = "status";
        this.status.Size = new System.Drawing.Size(153, 21);
        this.status.TabIndex = 13;
        this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
        // 
        // label11
        // 
        this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label11.Location = new System.Drawing.Point(14, 220);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(104, 32);
        this.label11.TabIndex = 12;
        this.label11.Text = "Status :";
        this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        this.label11.Click += new System.EventHandler(this.label11_Click);
        // 
        // label10
        // 
        this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label10.Location = new System.Drawing.Point(15, 190);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(104, 32);
        this.label10.TabIndex = 10;
        this.label10.Text = "Study Year :";
        this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        this.label10.Click += new System.EventHandler(this.label10_Click);
        // 
        // s_year
        // 
        this.s_year.Location = new System.Drawing.Point(128, 200);
        this.s_year.Name = "s_year";
        this.s_year.Size = new System.Drawing.Size(153, 20);
        this.s_year.TabIndex = 11;
        this.s_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.s_year.TextChanged += new System.EventHandler(this.s_year_TextChanged);
        // 
        // add_clear
        // 
        this.add_clear.Location = new System.Drawing.Point(316, 150);
        this.add_clear.Name = "add_clear";
        this.add_clear.Size = new System.Drawing.Size(80, 32);
        this.add_clear.TabIndex = 9;
        this.add_clear.Text = "Clear";
        this.add_clear.Click += new System.EventHandler(this.Add_clearClick);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(184, 279);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(136, 40);
        this.button1.TabIndex = 8;
        this.button1.Text = "Add Student";
        this.button1.Click += new System.EventHandler(this.Button1Click);
        // 
        // first_named
        // 
        this.first_named.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.first_named.Location = new System.Drawing.Point(32, 53);
        this.first_named.Name = "first_named";
        this.first_named.Size = new System.Drawing.Size(88, 32);
        this.first_named.TabIndex = 1;
        this.first_named.Text = "First Name :";
        this.first_named.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.first_named.Click += new System.EventHandler(this.first_named_Click);
        // 
        // textBox5
        // 
        this.textBox5.Location = new System.Drawing.Point(192, 144);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new System.Drawing.Size(200, 20);
        this.textBox5.TabIndex = 4;
        this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
        // 
        // new_dob
        // 
        this.new_dob.Enabled = false;
        this.new_dob.Location = new System.Drawing.Point(328, 172);
        this.new_dob.Name = "new_dob";
        this.new_dob.Size = new System.Drawing.Size(16, 24);
        this.new_dob.TabIndex = 18;
        this.new_dob.CheckedChanged += new System.EventHandler(this.New_dobCheckedChanged);
        // 
        // tabPage1
        // 
        this.tabPage1.Location = new System.Drawing.Point(0, 0);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Size = new System.Drawing.Size(200, 100);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
        // 
        // ch_up_first_name
        // 
        this.ch_up_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch_up_first_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.ch_up_first_name.Location = new System.Drawing.Point(16, 95);
        this.ch_up_first_name.Name = "ch_up_first_name";
        this.ch_up_first_name.Size = new System.Drawing.Size(120, 32);
        this.ch_up_first_name.TabIndex = 2;
        this.ch_up_first_name.Text = "First Name:";
        this.ch_up_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ch_up_first_name.CheckedChanged += new System.EventHandler(this.Ch_up_first_nameCheckedChanged);
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.ForeColor = System.Drawing.Color.Firebrick;
        this.label2.Location = new System.Drawing.Point(152, 24);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(136, 32);
        this.label2.TabIndex = 4;
        this.label2.Text = "Old Value";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label2.Click += new System.EventHandler(this.label2_Click);
        // 
        // new_first_name
        // 
        this.new_first_name.Enabled = false;
        this.new_first_name.Location = new System.Drawing.Point(328, 100);
        this.new_first_name.Name = "new_first_name";
        this.new_first_name.Size = new System.Drawing.Size(16, 24);
        this.new_first_name.TabIndex = 16;
        this.new_first_name.CheckedChanged += new System.EventHandler(this.New_first_nameCheckedChanged);
        // 
        // up_last_name1
        // 
        this.up_last_name1.Enabled = false;
        this.up_last_name1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.up_last_name1.Location = new System.Drawing.Point(144, 137);
        this.up_last_name1.Name = "up_last_name1";
        this.up_last_name1.Size = new System.Drawing.Size(152, 21);
        this.up_last_name1.TabIndex = 7;
        this.up_last_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_last_name1.TextChanged += new System.EventHandler(this.up_last_name1_TextChanged);
        // 
        // up_first_name2
        // 
        this.up_first_name2.Enabled = false;
        this.up_first_name2.Location = new System.Drawing.Point(360, 100);
        this.up_first_name2.Name = "up_first_name2";
        this.up_first_name2.Size = new System.Drawing.Size(160, 20);
        this.up_first_name2.TabIndex = 10;
        this.up_first_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.up_first_name2.TextChanged += new System.EventHandler(this.up_first_name2_TextChanged);
        // 
        // new_id
        // 
        this.new_id.Enabled = false;
        this.new_id.Location = new System.Drawing.Point(328, 64);
        this.new_id.Name = "new_id";
        this.new_id.Size = new System.Drawing.Size(16, 24);
        this.new_id.TabIndex = 15;
        this.new_id.CheckedChanged += new System.EventHandler(this.New_idCheckedChanged);
        // 
        // new_last_name
        // 
        this.new_last_name.Enabled = false;
        this.new_last_name.Location = new System.Drawing.Point(328, 137);
        this.new_last_name.Name = "new_last_name";
        this.new_last_name.Size = new System.Drawing.Size(16, 24);
        this.new_last_name.TabIndex = 17;
        this.new_last_name.CheckedChanged += new System.EventHandler(this.New_last_nameCheckedChanged);
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage6);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage5);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Controls.Add(this.tabPage9);
        this.tabControl1.Location = new System.Drawing.Point(8, 16);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(568, 432);
        this.tabControl1.TabIndex = 0;
        this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
        // 
        // tabPage6
        // 
        this.tabPage6.Controls.Add(this.dataGrid1);
        this.tabPage6.Controls.Add(this.display);
        this.tabPage6.Location = new System.Drawing.Point(4, 22);
        this.tabPage6.Name = "tabPage6";
        this.tabPage6.Size = new System.Drawing.Size(560, 406);
        this.tabPage6.TabIndex = 5;
        this.tabPage6.Text = "Display Students";
        this.tabPage6.UseVisualStyleBackColor = true;
        this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
        this.tabPage6.Leave += new System.EventHandler(this.tabPage6_Leave);
        // 
        // dataGrid1
        // 
        this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
        this.dataGrid1.CaptionText = "Student";
        this.dataGrid1.DataMember = "";
        this.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
        this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        this.dataGrid1.Location = new System.Drawing.Point(96, 32);
        this.dataGrid1.Name = "dataGrid1";
        this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Red;
        this.dataGrid1.ParentRowsVisible = false;
        this.dataGrid1.ReadOnly = true;
        this.dataGrid1.Size = new System.Drawing.Size(344, 304);
        this.dataGrid1.TabIndex = 1;
        this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
        this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
        // 
        // display
        // 
        this.display.Location = new System.Drawing.Point(192, 336);
        this.display.Name = "display";
        this.display.Size = new System.Drawing.Size(136, 48);
        this.display.TabIndex = 0;
        this.display.Text = "Refresh";
        this.display.Click += new System.EventHandler(this.display_Click);
        // 
        // tabPage5
        // 
        this.tabPage5.Controls.Add(this.cb5stage);
        this.tabPage5.Controls.Add(this.cb4stage);
        this.tabPage5.Controls.Add(this.checkBox2);
        this.tabPage5.Controls.Add(this.checkBox1);
        this.tabPage5.Controls.Add(this.status3);
        this.tabPage5.Controls.Add(this.status2);
        this.tabPage5.Controls.Add(this.cl);
        this.tabPage5.Controls.Add(this.up_results);
        this.tabPage5.Controls.Add(this.next2);
        this.tabPage5.Controls.Add(this.prev2);
        this.tabPage5.Controls.Add(this.update);
        this.tabPage5.Controls.Add(this.new_dob);
        this.tabPage5.Controls.Add(this.new_last_name);
        this.tabPage5.Controls.Add(this.new_first_name);
        this.tabPage5.Controls.Add(this.new_id);
        this.tabPage5.Controls.Add(this.get_results);
        this.tabPage5.Controls.Add(this.label3);
        this.tabPage5.Controls.Add(this.up_last_name2);
        this.tabPage5.Controls.Add(this.up_first_name2);
        this.tabPage5.Controls.Add(this.up_id2);
        this.tabPage5.Controls.Add(this.up_last_name1);
        this.tabPage5.Controls.Add(this.up_first_name1);
        this.tabPage5.Controls.Add(this.up_id1);
        this.tabPage5.Controls.Add(this.label2);
        this.tabPage5.Controls.Add(this.ch_up_dob);
        this.tabPage5.Controls.Add(this.ch_up_first_name);
        this.tabPage5.Controls.Add(this.ch_up_last_name);
        this.tabPage5.Controls.Add(this.ch_up_id);
        this.tabPage5.Location = new System.Drawing.Point(4, 22);
        this.tabPage5.Name = "tabPage5";
        this.tabPage5.Size = new System.Drawing.Size(560, 406);
        this.tabPage5.TabIndex = 4;
        this.tabPage5.Text = "Update";
        this.tabPage5.UseVisualStyleBackColor = true;
        this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
        this.tabPage5.Leave += new System.EventHandler(this.tabPage5_Leave);
        // 
        // cb5stage
        // 
        this.cb5stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cb5stage.Enabled = false;
        this.cb5stage.FormattingEnabled = true;
        this.cb5stage.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.cb5stage.Location = new System.Drawing.Point(360, 174);
        this.cb5stage.Name = "cb5stage";
        this.cb5stage.Size = new System.Drawing.Size(160, 21);
        this.cb5stage.TabIndex = 28;
        this.cb5stage.SelectedIndexChanged += new System.EventHandler(this.cb5stage_SelectedIndexChanged);
        // 
        // cb4stage
        // 
        this.cb4stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cb4stage.Enabled = false;
        this.cb4stage.FormattingEnabled = true;
        this.cb4stage.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.cb4stage.Location = new System.Drawing.Point(144, 176);
        this.cb4stage.Name = "cb4stage";
        this.cb4stage.Size = new System.Drawing.Size(152, 21);
        this.cb4stage.TabIndex = 27;
        this.cb4stage.SelectedIndexChanged += new System.EventHandler(this.cb4stage_SelectedIndexChanged);
        // 
        // checkBox2
        // 
        this.checkBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.checkBox2.Location = new System.Drawing.Point(16, 207);
        this.checkBox2.Name = "checkBox2";
        this.checkBox2.Size = new System.Drawing.Size(120, 32);
        this.checkBox2.TabIndex = 26;
        this.checkBox2.Text = "Status:";
        this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
        // 
        // checkBox1
        // 
        this.checkBox1.Enabled = false;
        this.checkBox1.Location = new System.Drawing.Point(328, 215);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new System.Drawing.Size(16, 24);
        this.checkBox1.TabIndex = 25;
        this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
        // 
        // status3
        // 
        this.status3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.status3.Enabled = false;
        this.status3.FormattingEnabled = true;
        this.status3.Items.AddRange(new object[] {
            "Doubler",
            "Fresh"});
        this.status3.Location = new System.Drawing.Point(360, 215);
        this.status3.Name = "status3";
        this.status3.Size = new System.Drawing.Size(160, 21);
        this.status3.TabIndex = 24;
        this.status3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
        // 
        // status2
        // 
        this.status2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.status2.Enabled = false;
        this.status2.FormattingEnabled = true;
        this.status2.Items.AddRange(new object[] {
            "Doubler",
            "Fresh"});
        this.status2.Location = new System.Drawing.Point(144, 215);
        this.status2.Name = "status2";
        this.status2.Size = new System.Drawing.Size(152, 21);
        this.status2.TabIndex = 1;
        this.status2.SelectedIndexChanged += new System.EventHandler(this.status2_SelectedIndexChanged);
        // 
        // up_results
        // 
        this.up_results.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.up_results.Location = new System.Drawing.Point(213, 360);
        this.up_results.Name = "up_results";
        this.up_results.Size = new System.Drawing.Size(144, 32);
        this.up_results.TabIndex = 22;
        this.up_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.up_results.Click += new System.EventHandler(this.up_results_Click);
        // 
        // update
        // 
        this.update.Enabled = false;
        this.update.Location = new System.Drawing.Point(408, 352);
        this.update.Name = "update";
        this.update.Size = new System.Drawing.Size(112, 40);
        this.update.TabIndex = 19;
        this.update.Text = "Update";
        this.update.Click += new System.EventHandler(this.Button2Click);
        // 
        // get_results
        // 
        this.get_results.Location = new System.Drawing.Point(216, 311);
        this.get_results.Name = "get_results";
        this.get_results.Size = new System.Drawing.Size(128, 40);
        this.get_results.TabIndex = 14;
        this.get_results.Text = "Get Results";
        this.get_results.Click += new System.EventHandler(this.Get_resultsClick);
        // 
        // tabPage9
        // 
        this.tabPage9.Controls.Add(this.groupBox12);
        this.tabPage9.Controls.Add(this.textBox7);
        this.tabPage9.Controls.Add(this.checkBox9);
        this.tabPage9.Controls.Add(this.checkBox10);
        this.tabPage9.Controls.Add(this.checkBox11);
        this.tabPage9.Controls.Add(this.textBox8);
        this.tabPage9.Controls.Add(this.textBox9);
        this.tabPage9.Controls.Add(this.checkBox12);
        this.tabPage9.Controls.Add(this.groupBox9);
        this.tabPage9.Location = new System.Drawing.Point(4, 22);
        this.tabPage9.Name = "tabPage9";
        this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage9.Size = new System.Drawing.Size(560, 406);
        this.tabPage9.TabIndex = 8;
        this.tabPage9.Text = "Insert grades";
        this.tabPage9.UseVisualStyleBackColor = true;
        this.tabPage9.Click += new System.EventHandler(this.tabPage9_Click);
        this.tabPage9.Leave += new System.EventHandler(this.tabPage9_Leave);
        // 
        // groupBox12
        // 
        this.groupBox12.Controls.Add(this.button22);
        this.groupBox12.Controls.Add(this.button21);
        this.groupBox12.Controls.Add(this.button20);
        this.groupBox12.Controls.Add(this.textBox15);
        this.groupBox12.Controls.Add(this.textBox14);
        this.groupBox12.Controls.Add(this.textBox13);
        this.groupBox12.Controls.Add(this.textBox12);
        this.groupBox12.Controls.Add(this.textBox11);
        this.groupBox12.Controls.Add(this.textBox10);
        this.groupBox12.Controls.Add(this.checkBox18);
        this.groupBox12.Controls.Add(this.checkBox17);
        this.groupBox12.Controls.Add(this.checkBox16);
        this.groupBox12.Controls.Add(this.checkBox15);
        this.groupBox12.Controls.Add(this.checkBox14);
        this.groupBox12.Controls.Add(this.checkBox13);
        this.groupBox12.Location = new System.Drawing.Point(294, 25);
        this.groupBox12.Name = "groupBox12";
        this.groupBox12.Size = new System.Drawing.Size(260, 295);
        this.groupBox12.TabIndex = 20;
        this.groupBox12.TabStop = false;
        this.groupBox12.Text = "Courses Grades";
        // 
        // button22
        // 
        this.button22.Location = new System.Drawing.Point(75, 217);
        this.button22.Name = "button22";
        this.button22.Size = new System.Drawing.Size(106, 23);
        this.button22.TabIndex = 35;
        this.button22.Text = "Add &Help Grades";
        this.button22.UseVisualStyleBackColor = true;
        this.button22.Click += new System.EventHandler(this.button22_Click);
        // 
        // button21
        // 
        this.button21.Location = new System.Drawing.Point(132, 252);
        this.button21.Name = "button21";
        this.button21.Size = new System.Drawing.Size(106, 23);
        this.button21.TabIndex = 34;
        this.button21.Text = "&Clear";
        this.button21.UseVisualStyleBackColor = true;
        this.button21.Click += new System.EventHandler(this.button21_Click);
        // 
        // button20
        // 
        this.button20.Location = new System.Drawing.Point(20, 252);
        this.button20.Name = "button20";
        this.button20.Size = new System.Drawing.Size(106, 23);
        this.button20.TabIndex = 33;
        this.button20.Text = "&Assign Grades";
        this.button20.UseVisualStyleBackColor = true;
        this.button20.Click += new System.EventHandler(this.button20_Click);
        // 
        // textBox15
        // 
        this.textBox15.Enabled = false;
        this.textBox15.Location = new System.Drawing.Point(108, 191);
        this.textBox15.Name = "textBox15";
        this.textBox15.Size = new System.Drawing.Size(120, 20);
        this.textBox15.TabIndex = 32;
        this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox14
        // 
        this.textBox14.Enabled = false;
        this.textBox14.Location = new System.Drawing.Point(108, 156);
        this.textBox14.Name = "textBox14";
        this.textBox14.Size = new System.Drawing.Size(120, 20);
        this.textBox14.TabIndex = 31;
        this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox13
        // 
        this.textBox13.Enabled = false;
        this.textBox13.Location = new System.Drawing.Point(108, 120);
        this.textBox13.Name = "textBox13";
        this.textBox13.Size = new System.Drawing.Size(120, 20);
        this.textBox13.TabIndex = 30;
        this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox12
        // 
        this.textBox12.Enabled = false;
        this.textBox12.Location = new System.Drawing.Point(108, 84);
        this.textBox12.Name = "textBox12";
        this.textBox12.Size = new System.Drawing.Size(120, 20);
        this.textBox12.TabIndex = 29;
        this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox11
        // 
        this.textBox11.Enabled = false;
        this.textBox11.Location = new System.Drawing.Point(108, 14);
        this.textBox11.Name = "textBox11";
        this.textBox11.Size = new System.Drawing.Size(120, 20);
        this.textBox11.TabIndex = 28;
        this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox10
        // 
        this.textBox10.Enabled = false;
        this.textBox10.Location = new System.Drawing.Point(108, 50);
        this.textBox10.Name = "textBox10";
        this.textBox10.Size = new System.Drawing.Size(120, 20);
        this.textBox10.TabIndex = 27;
        this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // checkBox18
        // 
        this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox18.Location = new System.Drawing.Point(6, 191);
        this.checkBox18.Name = "checkBox18";
        this.checkBox18.Size = new System.Drawing.Size(96, 32);
        this.checkBox18.TabIndex = 26;
        this.checkBox18.Text = "Student ID";
        this.checkBox18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
        // 
        // checkBox17
        // 
        this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox17.Location = new System.Drawing.Point(6, 156);
        this.checkBox17.Name = "checkBox17";
        this.checkBox17.Size = new System.Drawing.Size(96, 32);
        this.checkBox17.TabIndex = 25;
        this.checkBox17.Text = "Student ID";
        this.checkBox17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
        // 
        // checkBox16
        // 
        this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox16.Location = new System.Drawing.Point(6, 121);
        this.checkBox16.Name = "checkBox16";
        this.checkBox16.Size = new System.Drawing.Size(96, 32);
        this.checkBox16.TabIndex = 24;
        this.checkBox16.Text = "Student ID";
        this.checkBox16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
        // 
        // checkBox15
        // 
        this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox15.Location = new System.Drawing.Point(6, 85);
        this.checkBox15.Name = "checkBox15";
        this.checkBox15.Size = new System.Drawing.Size(96, 32);
        this.checkBox15.TabIndex = 23;
        this.checkBox15.Text = "Student ID";
        this.checkBox15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
        // 
        // checkBox14
        // 
        this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox14.Location = new System.Drawing.Point(6, 50);
        this.checkBox14.Name = "checkBox14";
        this.checkBox14.Size = new System.Drawing.Size(96, 32);
        this.checkBox14.TabIndex = 22;
        this.checkBox14.Text = "Student ID";
        this.checkBox14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
        // 
        // checkBox13
        // 
        this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox13.Location = new System.Drawing.Point(6, 16);
        this.checkBox13.Name = "checkBox13";
        this.checkBox13.Size = new System.Drawing.Size(96, 32);
        this.checkBox13.TabIndex = 21;
        this.checkBox13.Text = "Student ID";
        this.checkBox13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
        // 
        // textBox7
        // 
        this.textBox7.Enabled = false;
        this.textBox7.Location = new System.Drawing.Point(141, 160);
        this.textBox7.Name = "textBox7";
        this.textBox7.Size = new System.Drawing.Size(120, 20);
        this.textBox7.TabIndex = 18;
        this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // checkBox9
        // 
        this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox9.Location = new System.Drawing.Point(29, 200);
        this.checkBox9.Name = "checkBox9";
        this.checkBox9.Size = new System.Drawing.Size(104, 32);
        this.checkBox9.TabIndex = 15;
        this.checkBox9.Text = "Stage";
        this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
        // 
        // checkBox10
        // 
        this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox10.Location = new System.Drawing.Point(29, 152);
        this.checkBox10.Name = "checkBox10";
        this.checkBox10.Size = new System.Drawing.Size(106, 32);
        this.checkBox10.TabIndex = 14;
        this.checkBox10.Text = "Last Name";
        this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
        // 
        // checkBox11
        // 
        this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox11.Location = new System.Drawing.Point(29, 104);
        this.checkBox11.Name = "checkBox11";
        this.checkBox11.Size = new System.Drawing.Size(111, 32);
        this.checkBox11.TabIndex = 13;
        this.checkBox11.Text = "First Name";
        this.checkBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
        // 
        // textBox8
        // 
        this.textBox8.Enabled = false;
        this.textBox8.Location = new System.Drawing.Point(141, 112);
        this.textBox8.Name = "textBox8";
        this.textBox8.Size = new System.Drawing.Size(120, 20);
        this.textBox8.TabIndex = 17;
        this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox9
        // 
        this.textBox9.Enabled = false;
        this.textBox9.Location = new System.Drawing.Point(141, 64);
        this.textBox9.Name = "textBox9";
        this.textBox9.Size = new System.Drawing.Size(120, 20);
        this.textBox9.TabIndex = 16;
        this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // checkBox12
        // 
        this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox12.Location = new System.Drawing.Point(29, 56);
        this.checkBox12.Name = "checkBox12";
        this.checkBox12.Size = new System.Drawing.Size(106, 32);
        this.checkBox12.TabIndex = 12;
        this.checkBox12.Text = "Student ID";
        this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
        // 
        // groupBox9
        // 
        this.groupBox9.Controls.Add(this.comboBox5);
        this.groupBox9.Controls.Add(this.results2_2);
        this.groupBox9.Controls.Add(this.button19);
        this.groupBox9.Controls.Add(this.button17);
        this.groupBox9.Controls.Add(this.button18);
        this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.groupBox9.ForeColor = System.Drawing.Color.Firebrick;
        this.groupBox9.Location = new System.Drawing.Point(21, 24);
        this.groupBox9.Name = "groupBox9";
        this.groupBox9.Size = new System.Drawing.Size(256, 296);
        this.groupBox9.TabIndex = 19;
        this.groupBox9.TabStop = false;
        this.groupBox9.Text = "Student Information";
        // 
        // comboBox5
        // 
        this.comboBox5.Enabled = false;
        this.comboBox5.FormattingEnabled = true;
        this.comboBox5.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.comboBox5.Location = new System.Drawing.Point(120, 176);
        this.comboBox5.Name = "comboBox5";
        this.comboBox5.Size = new System.Drawing.Size(120, 26);
        this.comboBox5.TabIndex = 14;
        // 
        // results2_2
        // 
        this.results2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.results2_2.Location = new System.Drawing.Point(72, 216);
        this.results2_2.Name = "results2_2";
        this.results2_2.Size = new System.Drawing.Size(112, 32);
        this.results2_2.TabIndex = 3;
        this.results2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button19
        // 
        this.button19.Enabled = false;
        this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button19.ForeColor = System.Drawing.Color.Black;
        this.button19.Location = new System.Drawing.Point(8, 256);
        this.button19.Name = "button19";
        this.button19.Size = new System.Drawing.Size(64, 32);
        this.button19.TabIndex = 2;
        this.button19.Text = "<< prev";
        this.button19.Click += new System.EventHandler(this.button19_Click);
        // 
        // button17
        // 
        this.button17.Enabled = false;
        this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button17.ForeColor = System.Drawing.Color.Black;
        this.button17.Location = new System.Drawing.Point(176, 256);
        this.button17.Name = "button17";
        this.button17.Size = new System.Drawing.Size(64, 32);
        this.button17.TabIndex = 1;
        this.button17.Text = "next >>";
        this.button17.Click += new System.EventHandler(this.button17_Click);
        // 
        // button18
        // 
        this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button18.ForeColor = System.Drawing.Color.Black;
        this.button18.Location = new System.Drawing.Point(88, 256);
        this.button18.Name = "button18";
        this.button18.Size = new System.Drawing.Size(72, 32);
        this.button18.TabIndex = 0;
        this.button18.Text = "Get Student";
        this.button18.Click += new System.EventHandler(this.button18_Click);
        // 
        // contextMenu1
        // 
        this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.update_st,
            this.del_st,
            this.menuItem1});
        this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
        // 
        // update_st
        // 
        this.update_st.Index = 0;
        this.update_st.Text = "Update Student";
        this.update_st.Click += new System.EventHandler(this.update_st_Click);
        // 
        // del_st
        // 
        this.del_st.Index = 1;
        this.del_st.Text = "Delete Student";
        this.del_st.Click += new System.EventHandler(this.del_st_Click);
        // 
        // menuItem1
        // 
        this.menuItem1.Index = 2;
        this.menuItem1.Text = "Assign or Remove Coarse";
        this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
        // 
        // button5
        // 
        this.button5.Location = new System.Drawing.Point(216, 328);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(136, 32);
        this.button5.TabIndex = 13;
        this.button5.Text = "Clear";
        this.button5.Click += new System.EventHandler(this.button5_Click);
        // 
        // groupBox10
        // 
        this.groupBox10.Controls.Add(this.textBox1);
        this.groupBox10.Controls.Add(this.textBox2);
        this.groupBox10.Controls.Add(this.checkBox3);
        this.groupBox10.Controls.Add(this.checkBox4);
        this.groupBox10.Controls.Add(this.button6);
        this.groupBox10.Controls.Add(this.button7);
        this.groupBox10.Controls.Add(this.button8);
        this.groupBox10.Controls.Add(this.label13);
        this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.groupBox10.ForeColor = System.Drawing.Color.Firebrick;
        this.groupBox10.Location = new System.Drawing.Point(272, 16);
        this.groupBox10.Name = "groupBox10";
        this.groupBox10.Size = new System.Drawing.Size(272, 296);
        this.groupBox10.TabIndex = 12;
        this.groupBox10.TabStop = false;
        this.groupBox10.Text = "Coarse Information";
        this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
        // 
        // textBox1
        // 
        this.textBox1.Enabled = false;
        this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.textBox1.Location = new System.Drawing.Point(128, 88);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(120, 20);
        this.textBox1.TabIndex = 3;
        this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // textBox2
        // 
        this.textBox2.Enabled = false;
        this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.textBox2.Location = new System.Drawing.Point(128, 40);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(120, 20);
        this.textBox2.TabIndex = 2;
        this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        // 
        // checkBox3
        // 
        this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox3.ForeColor = System.Drawing.Color.Black;
        this.checkBox3.Location = new System.Drawing.Point(8, 88);
        this.checkBox3.Name = "checkBox3";
        this.checkBox3.Size = new System.Drawing.Size(125, 24);
        this.checkBox3.TabIndex = 1;
        this.checkBox3.Text = "Coarse Name";
        this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
        // 
        // checkBox4
        // 
        this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox4.ForeColor = System.Drawing.Color.Black;
        this.checkBox4.Location = new System.Drawing.Point(8, 40);
        this.checkBox4.Name = "checkBox4";
        this.checkBox4.Size = new System.Drawing.Size(112, 24);
        this.checkBox4.TabIndex = 0;
        this.checkBox4.Text = "Coarse ID";
        this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
        // 
        // button6
        // 
        this.button6.Enabled = false;
        this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button6.ForeColor = System.Drawing.Color.Black;
        this.button6.Location = new System.Drawing.Point(192, 256);
        this.button6.Name = "button6";
        this.button6.Size = new System.Drawing.Size(64, 32);
        this.button6.TabIndex = 3;
        this.button6.Text = "next >>";
        this.button6.Click += new System.EventHandler(this.button6_Click);
        // 
        // button7
        // 
        this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button7.ForeColor = System.Drawing.Color.Black;
        this.button7.Location = new System.Drawing.Point(104, 256);
        this.button7.Name = "button7";
        this.button7.Size = new System.Drawing.Size(72, 32);
        this.button7.TabIndex = 3;
        this.button7.Text = "Get Coarse";
        this.button7.Click += new System.EventHandler(this.button7_Click);
        // 
        // button8
        // 
        this.button8.Enabled = false;
        this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button8.ForeColor = System.Drawing.Color.Black;
        this.button8.Location = new System.Drawing.Point(24, 256);
        this.button8.Name = "button8";
        this.button8.Size = new System.Drawing.Size(64, 32);
        this.button8.TabIndex = 3;
        this.button8.Text = "<< prev";
        this.button8.Click += new System.EventHandler(this.button8_Click);
        // 
        // label13
        // 
        this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.label13.Location = new System.Drawing.Point(88, 208);
        this.label13.Name = "label13";
        this.label13.Size = new System.Drawing.Size(112, 32);
        this.label13.TabIndex = 4;
        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label13.Click += new System.EventHandler(this.label13_Click);
        // 
        // textBox3
        // 
        this.textBox3.Enabled = false;
        this.textBox3.Location = new System.Drawing.Point(128, 152);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(120, 20);
        this.textBox3.TabIndex = 8;
        this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
        // 
        // textBox4
        // 
        this.textBox4.Enabled = false;
        this.textBox4.Location = new System.Drawing.Point(128, 104);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(120, 20);
        this.textBox4.TabIndex = 7;
        this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
        // 
        // textBox6
        // 
        this.textBox6.Enabled = false;
        this.textBox6.Location = new System.Drawing.Point(128, 56);
        this.textBox6.Name = "textBox6";
        this.textBox6.Size = new System.Drawing.Size(120, 20);
        this.textBox6.TabIndex = 6;
        this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
        // 
        // checkBox5
        // 
        this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox5.Location = new System.Drawing.Point(16, 192);
        this.checkBox5.Name = "checkBox5";
        this.checkBox5.Size = new System.Drawing.Size(104, 32);
        this.checkBox5.TabIndex = 3;
        this.checkBox5.Text = "Stage";
        this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
        // 
        // checkBox6
        // 
        this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox6.Location = new System.Drawing.Point(16, 144);
        this.checkBox6.Name = "checkBox6";
        this.checkBox6.Size = new System.Drawing.Size(96, 32);
        this.checkBox6.TabIndex = 2;
        this.checkBox6.Text = "Last Name";
        this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
        // 
        // checkBox7
        // 
        this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox7.Location = new System.Drawing.Point(16, 96);
        this.checkBox7.Name = "checkBox7";
        this.checkBox7.Size = new System.Drawing.Size(96, 32);
        this.checkBox7.TabIndex = 1;
        this.checkBox7.Text = "First Name";
        this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
        // 
        // checkBox8
        // 
        this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.checkBox8.Location = new System.Drawing.Point(16, 48);
        this.checkBox8.Name = "checkBox8";
        this.checkBox8.Size = new System.Drawing.Size(96, 32);
        this.checkBox8.TabIndex = 0;
        this.checkBox8.Text = "Student ID";
        this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
        // 
        // button9
        // 
        this.button9.Enabled = false;
        this.button9.Location = new System.Drawing.Point(56, 328);
        this.button9.Name = "button9";
        this.button9.Size = new System.Drawing.Size(104, 32);
        this.button9.TabIndex = 4;
        this.button9.Text = "Assign";
        this.button9.Click += new System.EventHandler(this.button9_Click);
        // 
        // button10
        // 
        this.button10.Enabled = false;
        this.button10.Location = new System.Drawing.Point(408, 328);
        this.button10.Name = "button10";
        this.button10.Size = new System.Drawing.Size(104, 32);
        this.button10.TabIndex = 5;
        this.button10.Text = "Remove";
        this.button10.Click += new System.EventHandler(this.button10_Click);
        // 
        // groupBox11
        // 
        this.groupBox11.Controls.Add(this.comboBox3);
        this.groupBox11.Controls.Add(this.label14);
        this.groupBox11.Controls.Add(this.button11);
        this.groupBox11.Controls.Add(this.button12);
        this.groupBox11.Controls.Add(this.button13);
        this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.groupBox11.ForeColor = System.Drawing.Color.Firebrick;
        this.groupBox11.Location = new System.Drawing.Point(8, 16);
        this.groupBox11.Name = "groupBox11";
        this.groupBox11.Size = new System.Drawing.Size(256, 296);
        this.groupBox11.TabIndex = 11;
        this.groupBox11.TabStop = false;
        this.groupBox11.Text = "Student Information";
        this.groupBox11.Enter += new System.EventHandler(this.groupBox11_Enter);
        // 
        // comboBox3
        // 
        this.comboBox3.Enabled = false;
        this.comboBox3.FormattingEnabled = true;
        this.comboBox3.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.comboBox3.Location = new System.Drawing.Point(120, 176);
        this.comboBox3.Name = "comboBox3";
        this.comboBox3.Size = new System.Drawing.Size(120, 21);
        this.comboBox3.TabIndex = 14;
        this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
        // 
        // label14
        // 
        this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.label14.Location = new System.Drawing.Point(72, 216);
        this.label14.Name = "label14";
        this.label14.Size = new System.Drawing.Size(112, 32);
        this.label14.TabIndex = 3;
        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label14.Click += new System.EventHandler(this.label14_Click);
        // 
        // button11
        // 
        this.button11.Enabled = false;
        this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button11.ForeColor = System.Drawing.Color.Black;
        this.button11.Location = new System.Drawing.Point(8, 256);
        this.button11.Name = "button11";
        this.button11.Size = new System.Drawing.Size(64, 32);
        this.button11.TabIndex = 2;
        this.button11.Text = "<< prev";
        this.button11.Click += new System.EventHandler(this.button11_Click);
        // 
        // button12
        // 
        this.button12.Enabled = false;
        this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button12.ForeColor = System.Drawing.Color.Black;
        this.button12.Location = new System.Drawing.Point(176, 256);
        this.button12.Name = "button12";
        this.button12.Size = new System.Drawing.Size(64, 32);
        this.button12.TabIndex = 1;
        this.button12.Text = "next >>";
        this.button12.Click += new System.EventHandler(this.button12_Click);
        // 
        // button13
        // 
        this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button13.ForeColor = System.Drawing.Color.Black;
        this.button13.Location = new System.Drawing.Point(88, 256);
        this.button13.Name = "button13";
        this.button13.Size = new System.Drawing.Size(72, 32);
        this.button13.TabIndex = 0;
        this.button13.Text = "Get Student";
        this.button13.Click += new System.EventHandler(this.button13_Click);
        // 
        // button14
        // 
        this.button14.Enabled = false;
        this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button14.ForeColor = System.Drawing.Color.Black;
        this.button14.Location = new System.Drawing.Point(176, 256);
        this.button14.Name = "button14";
        this.button14.Size = new System.Drawing.Size(64, 32);
        this.button14.TabIndex = 1;
        this.button14.Text = "next >>";
        this.button14.Click += new System.EventHandler(this.button14_Click);
        // 
        // button15
        // 
        this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button15.ForeColor = System.Drawing.Color.Black;
        this.button15.Location = new System.Drawing.Point(88, 256);
        this.button15.Name = "button15";
        this.button15.Size = new System.Drawing.Size(72, 32);
        this.button15.TabIndex = 0;
        this.button15.Text = "Get Student";
        this.button15.Click += new System.EventHandler(this.button15_Click);
        // 
        // button16
        // 
        this.button16.Enabled = false;
        this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.button16.ForeColor = System.Drawing.Color.Black;
        this.button16.Location = new System.Drawing.Point(8, 256);
        this.button16.Name = "button16";
        this.button16.Size = new System.Drawing.Size(64, 32);
        this.button16.TabIndex = 2;
        this.button16.Text = "<< prev";
        this.button16.Click += new System.EventHandler(this.button16_Click);
        // 
        // comboBox4
        // 
        this.comboBox4.Enabled = false;
        this.comboBox4.FormattingEnabled = true;
        this.comboBox4.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
        this.comboBox4.Location = new System.Drawing.Point(120, 176);
        this.comboBox4.Name = "comboBox4";
        this.comboBox4.Size = new System.Drawing.Size(120, 21);
        this.comboBox4.TabIndex = 14;
        this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
        // 
        // label15
        // 
        this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.label15.Location = new System.Drawing.Point(72, 216);
        this.label15.Name = "label15";
        this.label15.Size = new System.Drawing.Size(112, 32);
        this.label15.TabIndex = 3;
        this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label15.Click += new System.EventHandler(this.label15_Click);
        // 
        // imageList1
        // 
        this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
        this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
        this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // Form1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(584, 462);
        this.Controls.Add(this.tabControl1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Students & Grades";
        this.Closed += new System.EventHandler(this.Form1Closed);
        this.Click += new System.EventHandler(this.Add_clearClick);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        this.Load += new System.EventHandler(this.Form1_Load);
        this.tabPage4.ResumeLayout(false);
        this.tabPage4.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.tabPage3.ResumeLayout(false);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.tabPage6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
        this.tabPage5.ResumeLayout(false);
        this.tabPage5.PerformLayout();
        this.tabPage9.ResumeLayout(false);
        this.tabPage9.PerformLayout();
        this.groupBox12.ResumeLayout(false);
        this.groupBox12.PerformLayout();
        this.groupBox9.ResumeLayout(false);
        this.groupBox10.ResumeLayout(false);
        this.groupBox10.PerformLayout();
        this.groupBox11.ResumeLayout(false);
        this.ResumeLayout(false);

	}
	#endregion
	void Form1Closed(object sender, System.EventArgs e)
	{
		//parent.Visible=true;
        //cnn.MyConnection.Close();
			
	}
	
		
	/*void connect ()
	{
		try
		{
            MyConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=control_room.mdb");
			MyConnection.Open();	
		}
		catch(System.Data.OleDb.OleDbException)
		{
			MessageBox.Show("Error: Database not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			Application.Exit();
		}	
	}*/
    public void choose(int i)
    {
        this.tabControl1.SelectedIndex = i;
        //MessageBox.Show("");
       /* if (i == 0)
            this.tabControl1.SelectedIndex = 0;
        else if(i==1)
            this.tabControl1.SelectedIndex = 1;
        else if (i == 2)
            this.tabControl1.SelectedIndex = 2;
        else if (i == 3)
            this.tabControl1.SelectedIndex = 3;
        else if (i == 4)
            this.tabControl1.SelectedIndex = 4;
        else if (i == 5)
            this.tabControl1.SelectedIndex = 5;*/
    }
	void clear_text()
	{
        checkBox13.Checked = false;
        checkBox14.Checked = false;
        checkBox15.Checked = false;
        checkBox16.Checked = false;
        checkBox17.Checked = false;
        checkBox18.Checked = false;

        textBox10.Enabled = false;
        textBox11.Enabled = false;
        textBox12.Enabled = false;
        textBox13.Enabled = false;
        textBox14.Enabled = false;
        textBox15.Enabled = false;
        textBox10.Text = "";
        textBox11.Text = "";
        textBox12.Text = "";
        textBox13.Text = "";
        textBox14.Text = "";
        textBox15.Text = "";

        comboBox1.SelectedIndex = -1;

		get_results.Enabled=true;
		ch_up_id.Checked=false;
		ch_up_first_name.Checked=false;
		ch_up_last_name.Checked=false;
		ch_up_dob.Checked=false;
        checkBox2.Checked = false;
			
		ch_id.Checked=false;
		ch_first_name.Checked=false;
		ch_last_name.Checked=false;
			
		ch_s_id.Checked=false;
		ch_s_first_name.Checked=false;
		ch_s_last_name.Checked=false;
		ch_s_stage.Checked=false;
			
		new_id.Checked=false;
		new_first_name.Checked=false;
		new_last_name.Checked=false;
		new_dob.Checked=false;
        checkBox1.Checked = false;
			
		id.Text="";
		first_name.Text="";
		last_name.Text="";
        cbstage.SelectedIndex = -1;
        status.SelectedIndex = -1;
        s_year.Text = "";
		del_id.Text="";
		del_first_name.Text="";
		del_last_name.Text="";
			
		s_id.Text="";
		s_first_name.Text="";
		s_last_name.Text="";
        cb3stage.SelectedIndex = -1;
			
		r_id.Text="";
		r_first_name.Text="";
		r_last_name.Text="";
		r_stage.Text="";
			
		up_id1.Text="";
		up_first_name1.Text="";
		up_last_name1.Text="";
        cb4stage.SelectedIndex = -1;
        status2.SelectedIndex = -1;
			
		up_id2.Text="";
		up_first_name2.Text="";
		up_last_name2.Text="";
        cb5stage.SelectedIndex = -1;
        status3.SelectedIndex = -1;
			
		next.Enabled=false;
		prev.Enabled=false;
		next2.Enabled=false;
		prev2.Enabled=false;
		update.Enabled=false;
			
		new_id.Enabled=false;
		new_first_name.Enabled=false;
		new_last_name.Enabled=false;
		new_dob.Enabled=false;
		results.Text="";
		up_results.Text="";
//		flag1=false;
//		flag2=false;
	}	
	void Button1Click(object sender, System.EventArgs e)
	{
        try
        {
            string gender="";
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter a value in the Gender field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear_text();
                return;
            }
            else gender=comboBox1.SelectedIndex == 0 ? "Male" : "Female";

            cmd = cnn.MyConnection.CreateCommand();
            string query = "INSERT INTO Students (id,first_name,last_name,stage,study_year,status,help_grades,Gender) VALUES (";
            query += id.Text + ",'" + first_name.Text + "','" + last_name.Text + "'," + (cbstage.SelectedIndex + 1) + "," + s_year.Text + "," + status.SelectedIndex + "," + 0 +",'"+gender+ "')";
            //MessageBox.Show(query);

            if (id.Text == "" || !Regex.Match(id.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the Id field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (first_name.Text == "")
            {
                MessageBox.Show("Please Enter a value in the first name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (last_name.Text == "")
            {
                MessageBox.Show("Please Enter a value in the last name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear_text();
                return;
            }
            if (cbstage.SelectedIndex==-1)
            {
                MessageBox.Show("Please Enter a value in the stage field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear_text();
                return;
            }
            if (s_year.Text == "")
            {
                MessageBox.Show("Please Enter a value in the study year field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear_text();
                return;
            }
            if (status.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter a value in the status field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear_text();
                return;
            }
            try
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            cmd = cnn.MyConnection.CreateCommand();
            for (int i = 0; i < 6; i++)
            {
                query = "INSERT INTO Grades (S_ID,C_ID,Midterm_Grades,Term_Grades,Enter_year,Success_year) VALUES (";
                query += id.Text + "," + i + "," + 0 + "," + 0 + "," + 0 + "," + 1 +")";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Student was added successfully to the database", "Student added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_text();
        }
        catch (System.Data.OleDb.OleDbException m)
        {
            //	MessageBox.Show(m.ErrorCode.ToString());
            if (m.ErrorCode == ID_ERROR)
                MessageBox.Show("Can't add student, a student with the same ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           /* else
                if (m.ErrorCode == DATE_ERROR)
                    MessageBox.Show("Please enter a valid date in the date of birth field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            * */
        }		
	}
		
	void Button2Click(object sender, System.EventArgs e)
	{
		try
		{
			cmd =cnn.MyConnection.CreateCommand();
			string query="Update Students SET";
			string query2="";
			if(up_id2.Enabled)
			{
				if(up_id2.Text==""||!Regex.Match(up_id2.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				query2+=" id="+up_id2.Text;
					
			}
			if(up_first_name2.Enabled)
			{
				if(up_first_name2.Text=="")
				{
					MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(up_id2.Enabled)
					query2+=",";
				query2+=" first_name='"+up_first_name2.Text+"'";
			}
			if(up_last_name2.Enabled)
			{
				if(up_last_name2.Text=="")
				{
					MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(up_id2.Enabled||up_first_name2.Enabled)
					query2+=",";
				query2+=" last_name='"+up_last_name2.Text+"'";
			}
            if (cb5stage.Enabled)
			{
				if(cb5stage.SelectedIndex==-1)
				{
					MessageBox.Show("Please Enter a value in the stage field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(up_id2.Enabled||up_first_name2.Enabled||up_last_name2.Enabled)
					query2+=",";
				query2+=" stage='"+(cb5stage.SelectedIndex+1)+"'";
			}
            if (status3.Enabled)
            {
                if (status3.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter a value in the staus field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (up_id1.Enabled || up_first_name1.Enabled || up_last_name1.Enabled || cb4stage.Enabled)
                    query2 += " AND";
                query2 += " status='" + status.SelectedIndex + "'";
            }
			
			if(query2=="")
			{
				MessageBox.Show("Please enter new details for the student you want to update ","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+=" WHERE";
			
			query2+=" id="+up_id1.Text;//you must complete this case (f_name,l_name,so on)
				
			cmd.CommandText=query+query2;
			int r=cmd.ExecuteNonQuery();
			if(r!=0)
				MessageBox.Show("Student data was updated successfuly");
		}
		catch(System.Data.OleDb.OleDbException m)
		{
			if(m.ErrorCode==ID_ERROR)
				MessageBox.Show("Can't update student, a student with the same ID already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else 
				if (m.ErrorCode==DATE_ERROR)
				MessageBox.Show("Please enter a valid date in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}	
	}
	void CheckBox1CheckedChanged(object sender, System.EventArgs e)
	{
		if(del_id.Enabled)
			del_id.Enabled=false;
		else
			del_id.Enabled=true;
	}
		
	void CheckBox2CheckedChanged(object sender, System.EventArgs e)
	{
		if(del_first_name.Enabled)
			del_first_name.Enabled=false;
		else
			del_first_name.Enabled=true;
	}
		
	void Button3Click(object sender, System.EventArgs e)
	{
		cmd=cnn.MyConnection.CreateCommand();
		string query="DELETE FROM Students WHERE ";
		string query2="";
		if(del_id.Enabled)
		{
			if(del_id.Text==""||!Regex.Match(del_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+="id="+del_id.Text;
				
		}
		if(del_first_name.Enabled)
		{
			if(del_first_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(del_id.Enabled)
				query2+=" AND";
			query2+=" first_name='"+del_first_name.Text+"'";
		}
		if(del_last_name.Enabled)
		{
			if(del_last_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(del_id.Enabled||del_first_name.Enabled)
				query2+=" AND";
			query2+=" last_name='"+del_last_name.Text+"'";
		}
			
		if(query2=="")
		{
			MessageBox.Show("Please enter details of the student you want to delete","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		cmd.CommandText=query+query2;
			
		int result=cmd.ExecuteNonQuery();
        if(result==0)
			MessageBox.Show("Can't delete, Unable to find this student","error",MessageBoxButtons.OK,MessageBoxIcon.Error);	
		else 
			MessageBox.Show(""+result+" students were deleted ","Students Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        cmd.CommandText = "DELETE FROM Grades WHERE S_ID=" + del_id.Text;
        result = cmd.ExecuteNonQuery();
		
        clear_text();
	}
		
	void Del_last_nameCheckedChanged(object sender, System.EventArgs e)
	{
		if(del_last_name.Enabled)
			del_last_name.Enabled=false;
		else
			del_last_name.Enabled=true;
				
	}
		
		
		
	void TabControl1SelectedIndexChanged(object sender, System.EventArgs e)
	{
        //MessageBox.Show(sender.ToString());
        if (sender.ToString() != "tabPage3")
        {
        //    clear_text();
        }
	}
		
	void Ch_up_idCheckedChanged(object sender, System.EventArgs e)
	{
		if(up_id1.Enabled)
			up_id1.Enabled=false;
		else
			up_id1.Enabled=true;
    }
    
    void Ch_up_first_nameCheckedChanged(object sender, System.EventArgs e)
	{
		if(up_first_name1.Enabled)
			up_first_name1.Enabled=false;
		else
			up_first_name1.Enabled=true;
			
	}
		
	void Ch_up_last_nameCheckedChanged(object sender, System.EventArgs e)
	{
		if(up_last_name1.Enabled)
			up_last_name1.Enabled=false;
		else
			up_last_name1.Enabled=true;
	}
		
	void Ch_up_dobCheckedChanged(object sender, System.EventArgs e)
	{
		if(cb4stage.Enabled)
            cb4stage.Enabled = false;
		else
            cb4stage.Enabled = true;
	}

	void CheckBox3CheckedChanged(object sender, System.EventArgs e)
	{
		if(s_id.Enabled)
			s_id.Enabled=false;
		else
			s_id.Enabled=true;
	}
		
	void CheckBox4CheckedChanged(object sender, System.EventArgs e)
	{
		if(s_first_name.Enabled)
			s_first_name.Enabled=false;
		else
			s_first_name.Enabled=true;
	}
		
	void CheckBox5CheckedChanged(object sender, System.EventArgs e)
	{
		if(s_last_name.Enabled)
			s_last_name.Enabled=false;
		else
			s_last_name.Enabled=true;
	}
		
	void CheckBox6CheckedChanged(object sender, System.EventArgs e)
	{
		if(cb3stage.Enabled)
            cb3stage.Enabled = false;
		else
            cb3stage.Enabled = true;
	}

	void SearchClick(object sender, System.EventArgs e)
	{
		cmd=cnn.MyConnection.CreateCommand();
		string query="SELECT * FROM Students WHERE";
		string query2="";
		if(s_id.Enabled)
		{
			if(s_id.Text==""||!Regex.Match(s_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+=" id="+s_id.Text;
				
		}
		if(s_first_name.Enabled)
		{
			if(s_first_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(s_id.Enabled)
				query2+=" AND";
			query2+=" first_name='"+s_first_name.Text+"'";
		}
		if(s_last_name.Enabled)
		{
			if(s_last_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(s_id.Enabled||s_first_name.Enabled)
				query2+=" AND";
			query2+=" last_name='"+s_last_name.Text+"'";
		}
		if(cb3stage.Enabled)
		{
			if(cb3stage.SelectedIndex==-1)
			{
				MessageBox.Show("Please Enter a value in the Stage field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(s_id.Enabled||s_first_name.Enabled||s_last_name.Enabled)
				query2+=" AND";
			query2+=" stage="+(cb3stage.SelectedIndex+1)+"";
		}
			
		if(query2=="")
		{
			MessageBox.Show("Please enter any detail of the student you want to search for","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		//MessageBox.Show(query+query2);
			
		cmd.CommandText=query+query2;
		reader=cmd.ExecuteReader();
			
			
		size=0;
		index=0;
			
		while(reader.Read())
		{
			students[size].id=(int)reader.GetValue(0);
			students[size].f_name=reader.GetValue(1).ToString();				
			students[size].l_name=reader.GetValue(2).ToString();				
			students[size].stage=int.Parse(reader.GetValue(3).ToString());
            students[size].s_year = int.Parse(reader.GetValue(4).ToString());
            students[size].status = int.Parse(reader.GetValue(5).ToString());				
			size++;
		}
		reader.Close();
		if(size==0)
		{
			MessageBox.Show("NO results");
				
		}
		else
		{
			MessageBox.Show(size+" results where found","Results");
			display_results(0);
			if(size>1)
				next.Enabled=true;
		}
	}
		
	void display_results(int ind)
	{
		
		results.Text="Result "+(index+1)+"/"+size;
		r_id.Text=students[ind].id.ToString();
		r_first_name.Text=students[ind].f_name.ToString();
		r_last_name.Text=students[ind].l_name.ToString();
		r_stage.Text=students[ind].stage.ToString();
	}
	/*void display_results3(int ind)
	{
		
		results2.Text="Result "+(index+1)+"/"+size;
		ass_st_id.Text=students[ind].id.ToString();
		ass_st_fname.Text=students[ind].f_name.ToString();
		ass_st_lname.Text=students[ind].l_name.ToString();
		comboBox2.SelectedIndex=int.Parse( students[ind].stage.ToString());
	}*/
    void display_results_3(int ind)
    {

        results2_2.Text = "Result " + (index + 1) + "/" + size;
        textBox9.Text = students[ind].id.ToString();
        textBox8.Text = students[ind].f_name.ToString();
        textBox7.Text = students[ind].l_name.ToString();
        comboBox5.SelectedIndex = int.Parse(students[ind].stage.ToString())-1;
        if (students[ind].help_grades == 1) button22.Enabled = false;
        else button22.Enabled = true;
    }
	/*void display_results4(int ind)
	{
		results3.Text="Result "+(index2+1)+"/"+size2;
		ass_c_id.Text=coarses[ind].c_id.ToString();
		ass_c_name.Text=coarses[ind].name;
	}
    */
	void NextClick(object sender, System.EventArgs e)
	{
		prev.Enabled=true;
		index++;	
		if(index<size)
		{	
			display_results(index);
		}
		else 
		{
			MessageBox.Show("No More Results");
			index--;
			next.Enabled=false;
		}
	}
		
	void PrevClick(object sender, System.EventArgs e)
	{
		index--;
		if(index>=0)
		{
			display_results(index);	
		}
		else
		{
			MessageBox.Show("No More Results");
			index++;
			prev.Enabled=false;
		}
			
	}
			
	void display_results2(int ind)
	{
		up_results.Text="Result "+(index+1)+"/"+size;
		up_id1.Text=students[ind].id.ToString();
		up_first_name1.Text=students[ind].f_name.ToString();
		up_last_name1.Text=students[ind].l_name.ToString();
        cb4stage.SelectedIndex = students[ind].stage-1;
        status2.SelectedIndex = students[ind].status;
	}
		
	void Get_resultsClick(object sender, System.EventArgs e)
	{
		cmd=cnn.MyConnection.CreateCommand();
		string query="SELECT * FROM Students WHERE";
		string query2="";
		if(up_id1.Enabled)
		{
			if(up_id1.Text==""||!Regex.Match(up_id1.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+=" id="+up_id1.Text;
				
		}
		if(up_first_name1.Enabled)
		{
			if(up_first_name1.Text=="")
			{
				MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(up_id1.Enabled)
				query2+=" AND";
			query2+=" first_name='"+up_first_name1.Text+"'";
		}
		if(up_last_name1.Enabled)
		{
			if(up_last_name1.Text=="")
			{
				MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(up_id1.Enabled||up_first_name1.Enabled)
				query2+=" AND";
			query2+=" last_name='"+up_last_name1.Text+"'";
		}
		if(cb4stage.Enabled)
		{
			if(cb4stage.SelectedIndex==-1)
			{
				MessageBox.Show("Please Enter a value in the stage field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(up_id1.Enabled||up_first_name1.Enabled||up_last_name1.Enabled)
				query2+=" AND";
			query2+=" stage='"+(cb4stage.SelectedIndex+1)+"'";
		}
        if (status2.Enabled)
        {
            if (status2.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter a value in the staus field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (up_id1.Enabled || up_first_name1.Enabled || up_last_name1.Enabled || cb4stage.Enabled)
                query2 += " AND";
            query2 += " status='" + status2.SelectedIndex + "'";
        }
		if(query2=="")
		{
			MessageBox.Show("Please enter any detail of the student you want to search for","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		//MessageBox.Show(query+query2);
			
		cmd.CommandText=query+query2;
		reader=cmd.ExecuteReader();
			
			
		size=0;
		index=0;
			
		while(reader.Read())
		{
			students[size].id=(int)reader.GetValue(0);
			students[size].f_name=reader.GetValue(1).ToString();				
			students[size].l_name=reader.GetValue(2).ToString();				
			students[size].stage=int.Parse( reader.GetValue(3).ToString());
            students[size].s_year =int.Parse( reader.GetValue(4).ToString());
            students[size].status =int.Parse( reader.GetValue(5).ToString());				
			size++;
				
		}
		reader.Close();
		if(size==0)
		{
			MessageBox.Show("NO results");
				
		}
		else
		{
			MessageBox.Show(size+" results where found","Results");
			display_results2(0);
				
			new_id.Enabled=true;
			new_first_name.Enabled=true;
			new_last_name.Enabled=true;
			new_dob.Enabled=true;
            checkBox1.Enabled = true;
				
			if(size>1)
				next2.Enabled=true;
				
			update.Enabled=true;
				
		}
			
				
	}
		
	void New_idCheckedChanged(object sender, System.EventArgs e)
	{
		if(up_id2.Enabled)
			up_id2.Enabled=false;
		else
			up_id2.Enabled=true;
				
			
	}
		
	void New_first_nameCheckedChanged(object sender, System.EventArgs e)
	{
		if(up_first_name2.Enabled)
			up_first_name2.Enabled=false;
		else
			up_first_name2.Enabled=true;
				
	}
		
	void New_last_nameCheckedChanged(object sender, System.EventArgs e)
	{
			
		if(up_last_name2.Enabled)
			up_last_name2.Enabled=false;
		else
			up_last_name2.Enabled=true;
	}
		
	void New_dobCheckedChanged(object sender, System.EventArgs e)
	{
		if(cb5stage.Enabled)
            cb5stage.Enabled = false;
		else
            cb5stage.Enabled = true;
	}
		
	void Next2Click(object sender, System.EventArgs e)
	{
		prev2.Enabled=true;
		index++;	
		if(index<size)
		{	
			display_results2(index);
				
		}
		else 
		{
			MessageBox.Show("No More Results");
			index--;
			next2.Enabled=false;
		}
	}
		
	void Prev2Click(object sender, System.EventArgs e)
	{
		index--;
		next2.Enabled=true;
		if(index>=0)
		{
			display_results2(index);	
		}
		else
		{
			MessageBox.Show("No More Results");
			index++;
			prev2.Enabled=false;
		}
	}
		
	void Add_clearClick(object sender, System.EventArgs e)
	{
		clear_text();
	}
		
	void ClClick(object sender, System.EventArgs e)
	{
		clear_text();	
	}

	private void display_Click(object sender, System.EventArgs e)
	{
		cmd=cnn.MyConnection.CreateCommand();
        cmd.CommandText = "SELECT id,stage,First_name,Last_Name,Gender,(select sum(Term_Grades) from Grades g WHERE g.S_ID=s.ID) as Total_Grades FROM Students s ORDER BY id,stage ASC";
		OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);	
		DataSet dataset=new DataSet();
		
		int result=adapter.Fill(dataset,"students");	
		dataGrid1.DataSource=dataset.Tables[0];
			
		
	}
    /*
	private void assign_Click(object sender, System.EventArgs e)
	{
		try
		{
			string query="INSERT INTO bridge (id,c_id) VALUES (";
			if(ass_st_id.Text==""||!Regex.Match(ass_st_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Student ID field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(ass_c_id.Text==""||!Regex.Match(ass_c_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Coarse ID field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}										
		
			query+=ass_st_id.Text+","+ass_c_id.Text+")";
			
			////////////// check to see if the coarse is already on the student coarse list////////////////
			string query2="SELECT * FROM bridge WHERE id="+ass_st_id.Text+" AND c_id="+ass_c_id.Text;
			cmd=cnn.MyConnection.CreateCommand();
			cmd.CommandText=query2;			
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataSet dataset=new DataSet();
			int r=adapter.Fill(dataset,"bridge");	
			if(r!=0)
			{
				MessageBox.Show("This coarse is already on the stident coarse list","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}			
			///////////////////////////////////////////////////////////////////
			cmd.CommandText=query;
			r=cmd.ExecuteNonQuery();
			if(r!=0)
				MessageBox.Show("Coarse was assigned successfully to the student","Success");
		}
		catch(System.Data.OleDb.OleDbException m)
		{
			if(m.ErrorCode==REFRENTIAL_INTEGRITY_ERROR)
			{
				string error=m.Errors[0].ToString();
				char ch=error[error.Length-3];
				if(ch=='t')
					MessageBox.Show("Cant assign coarse: This student does not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				else
					if(ch=='e')
					MessageBox.Show("Cant assign coarse: This coarse deos not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}
		}

	}

	private void remove_Click(object sender, System.EventArgs e)
	{
		string query="DELETE FROM bridge WHERE ";
		if(ass_st_id.Text==""||!Regex.Match(ass_st_id.Text,@"^\d*$").Success)
		{
			MessageBox.Show("Please Enter an integer value in the Student ID field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		if(ass_c_id.Text==""||!Regex.Match(ass_c_id.Text,@"^\d*$").Success)
		{
			MessageBox.Show("Please Enter an integer value in the Coarse ID field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}		
								
		query+="id="+ass_st_id.Text+" AND c_id="+ass_c_id.Text;
		
		cmd=cnn.MyConnection.CreateCommand();
		cmd.CommandText=query;
		int r=cmd.ExecuteNonQuery();
		if(r!=0)
			MessageBox.Show("Coarse was deleted successfully from the student","Success");
		else
			MessageBox.Show("Cant delete coarse: The student or the coarse may not exist or the student does not have this coarse in his coarse list","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
	
	}

	private void ch_ass_st_id_CheckedChanged(object sender, System.EventArgs e)
	{
		if(ass_st_id.Enabled)
			ass_st_id.Enabled=false;
		else
			ass_st_id.Enabled=true;

	}

	private void ch_ass_st_fname_CheckedChanged(object sender, System.EventArgs e)
	{
		if(ass_st_fname.Enabled)
			ass_st_fname.Enabled=false;
		else
			ass_st_fname.Enabled=true;
	
	}

	private void ch_ass_st_lname_CheckedChanged(object sender, System.EventArgs e)
	{
		if(ass_st_lname.Enabled)
			ass_st_lname.Enabled=false;
		else
			ass_st_lname.Enabled=true;
	
	}

	private void ch_ass_st_dob_CheckedChanged(object sender, System.EventArgs e)
	{
		if(comboBox2.Enabled)
            comboBox2.Enabled = false;
		else
            comboBox2.Enabled = true;
	}

	private void ch_ass_c_id_CheckedChanged(object sender, System.EventArgs e)
	{
		if(ass_c_id.Enabled)
			ass_c_id.Enabled=false;
		else
			ass_c_id.Enabled=true;
	}

	private void ch_ass_c_name_CheckedChanged(object sender, System.EventArgs e)
	{
		if(ass_c_name.Enabled)
			ass_c_name.Enabled=false;
		else
			ass_c_name.Enabled=true;
	}

	private void get_st_Click(object sender, System.EventArgs e)
	{
		cmd=cnn.MyConnection.CreateCommand();
		string query="SELECT * FROM Students WHERE";
		string query2="";
		if(ass_st_id.Enabled)
		{
			if(ass_st_id.Text==""||!Regex.Match(ass_st_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+=" id="+ass_st_id.Text;
				
		}
		if(ass_st_fname.Enabled)
		{
			if(ass_st_fname.Text=="")
			{
				MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(ass_st_id.Enabled)
				query2+=" AND";
			query2+=" first_name='"+ass_st_fname.Text+"'";
		}
		if(ass_st_lname.Enabled)
		{
			if(ass_st_lname.Text=="")
			{
				MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(ass_st_id.Enabled||ass_st_fname.Enabled)
				query2+=" AND";
			query2+=" last_name='"+ass_st_lname.Text+"'";
		}
		if(comboBox2.Enabled)
		{
            if (comboBox2.SelectedIndex==-1)
			{
				MessageBox.Show("Please Enter a value in the stage field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(ass_st_id.Enabled||ass_st_fname.Enabled||ass_st_lname.Enabled)
				query2+=" AND";
            query2 += " stage='" + (comboBox2.SelectedIndex+1)+ "'";
		}
			
		if(query2=="")
		{
			MessageBox.Show("Please enter any detail of the student","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		//MessageBox.Show(query+query2);
		
		size=0;
		index=0;

		cmd.CommandText=query+query2;
		
		reader=cmd.ExecuteReader();
		while(reader.Read())
		{
			students[size].id=(int)reader.GetValue(0);
			students[size].f_name=reader.GetValue(1).ToString();				
			students[size].l_name=reader.GetValue(2).ToString();
            students[size].stage = int.Parse(reader.GetValue(3).ToString());
            students[size].s_year = int.Parse(reader.GetValue(4).ToString());
            students[size].status = int.Parse(reader.GetValue(5).ToString());
			size++;				
		}
		reader.Close();
		if(size==0)
		{
			MessageBox.Show("No students were found");
		}
		else
		{
			MessageBox.Show(size+" students were found","Results");
			display_results3(0);
			
			if(size>1)
				next3.Enabled=true;
				
				
		}
			
	}
    
	private void next3_Click(object sender, System.EventArgs e)
	{
		prev3.Enabled=true;
		index++;	
		if(index<size)
		{	
			display_results3(index);
				
		}
		else 
		{
			MessageBox.Show("No More Results");
			index--;
			next3.Enabled=false;
		}
	
	}

	private void prev3_Click(object sender, System.EventArgs e)
	{
		index--;
		next3.Enabled=true;
		if(index>=0)
		{
			display_results3(index);	
		}
		else
		{
			MessageBox.Show("No More Results");
			index++;
			prev3.Enabled=false;
		}
	}

	private void get_coarse_Click(object sender, System.EventArgs e)
	{
        string query1 = "SELECT * FROM Courses WHERE ";
		string query2="";
		if(ass_c_id.Enabled)
		{
			if(ass_c_id.Text==""||!Regex.Match(ass_c_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}
			query2+="id="+ass_c_id.Text;

		}
		if(ass_c_name.Enabled)
		{
			if(ass_c_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}
			if(ass_c_id.Enabled)
				query2+=" AND";
			query2+=" name='"+ass_c_name.Text+"'";
		}

		if(query2=="")
		{
			MessageBox.Show("Please enter any details for the coarse","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			return;
		}
		size2=0;
		index2=0;	
		cmd=cnn.MyConnection.CreateCommand();
		cmd.CommandText=query1+query2;
		
		reader=cmd.ExecuteReader();

		while(reader.Read())
		{
			coarses[size2].c_id=(int)reader.GetValue(0);
			coarses[size2].name=reader.GetValue(1).ToString();				
			size2++;
						
		}
		reader.Close();
		if(size2==0)
			MessageBox.Show("No coarses were found","Results",MessageBoxButtons.OK,MessageBoxIcon.Information);
		else
		{
			MessageBox.Show(size2+" coarses were found","Results");
			display_results4(0);
			
			if(size2>1)
    			next4.Enabled=true;
        }
	}

	private void next4_Click(object sender, System.EventArgs e)
	{
		prev4.Enabled=true;
		index2++;	
		if(index2<size2)
		{	
			display_results4(index2);
				
		}
		else 
		{
			MessageBox.Show("No More Results");
			index2--;
			next4.Enabled=false;
		}
	
	
	}

	private void prev4_Click(object sender, System.EventArgs e)
	{
		index2--;
		next4.Enabled=true;
		if(index2>=0)
		{
			display_results4(index2);	
		}
		else
		{
			MessageBox.Show("No More Results");
			index2++;
			prev4.Enabled=false;
		}
	
	}

	private void ass_st_id_TextChanged(object sender, System.EventArgs e)
	{
		if(ass_st_id.Text!=""&& Regex.Match(ass_st_id.Text,@"^\d*$").Success)
			flag1=true;

		if(flag1 && flag2)
		{
			assign.Enabled=true;
			remove.Enabled=true;
		}
	}

	private void ass_c_id_TextChanged(object sender, System.EventArgs e)
	{
	
		if(ass_c_id.Text!=""&& Regex.Match(ass_c_id.Text,@"^\d*$").Success)
			flag2=true;

		if(flag1 && flag2)
		{
			assign.Enabled=true;
			remove.Enabled=true;
		}
	}

	*/

	/*private void get_course_Click(object sender, System.EventArgs e)
	{
		try
		{
			cmd=cnn.MyConnection.CreateCommand();
            cmd.CommandText = "SELECT Students.first_name,Students.last_name,coarses.Course_name,grades.midterm_Grades + grades.term_Grades,coarses.Course_total FROM coarses,grades,Students WHERE coarse.c_id=bridge.c_id AND students.id=" + gr_id.Text;
            MessageBox.Show(cmd.CommandText);                   //AND bridge.key=31 
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataSet dataset=new DataSet();
			adapter.Fill(dataset,"grades");
			dataGrid2.DataSource=dataset.Tables[0];
		}
		catch(System.Data.OleDb.OleDbException m)
		{
			MessageBox.Show(m.Errors[0].ToString());
		}
		
	
	}*/

	private void dataGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		DataSet dataset=new DataSet();
		cmd=cnn.MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM Students ORDER BY id ASC";
		OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
		DataRow row;
		DataGrid myGrid = (DataGrid) sender;
		System.Windows.Forms.DataGrid.HitTestInfo hti;
		hti = myGrid.HitTest(e.X, e.Y);
		//dataGrid1.CurrentRowIndex=hti.Row+2;
		
		
		
		if(e.Button==MouseButtons.Right)
		{

			switch (hti.Type) 
			{
				case System.Windows.Forms.DataGrid.HitTestType.Cell :
					adapter.Fill(dataset);
					row=dataset.Tables[0].Rows[hti.Row];
					st_id=Convert.ToInt32(row[0]);
					contextMenu1.Show(dataGrid1,new Point(e.X,e.Y));
					break;
				
				case System.Windows.Forms.DataGrid.HitTestType.RowHeader :
					adapter.Fill(dataset);
					row=dataset.Tables[0].Rows[hti.Row];
					st_id=Convert.ToInt32(row[0]);
					contextMenu1.Show(dataGrid1,new Point(e.X,e.Y));
					break;
				
			}

			//MessageBox.Show(message);
		}


	}

	

	private void menuItem1_Click(object sender, System.EventArgs e)
	{
		/*tabControl1.SelectedIndex=5;
		DataSet dataset=new DataSet();
		cmd=cnn.MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM Students Where id="+st_id;
		OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
		adapter.Fill(dataset);
		ch_ass_st_id.Checked=true;
		ch_ass_st_fname.Checked=true;
		ch_ass_st_lname.Checked=true;
		ch_ass_st_dob.Checked=true;
		get_st.Enabled=false;

		ass_st_id.Text=dataset.Tables[0].Rows[0][0].ToString();
		ass_st_fname.Text=dataset.Tables[0].Rows[0][1].ToString();
		ass_st_lname.Text=dataset.Tables[0].Rows[0][2].ToString();
		comboBox2.SelectedIndex=int.Parse( dataset.Tables[0].Rows[0][3].ToString());
	*/
	}

	private void update_st_Click(object sender, System.EventArgs e)
	{
		tabControl1.SelectedIndex=3;
		DataSet dataset=new DataSet();
		cmd=cnn.MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM Students Where id="+st_id;
		OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
		adapter.Fill(dataset);
		ch_up_id.Checked=true;
		ch_up_first_name.Checked=true;
		ch_up_last_name.Checked=true;
		ch_up_dob.Checked=true;

		new_id.Enabled=true;
		new_first_name.Enabled=true;
		new_last_name.Enabled=true;
		new_dob.Enabled=true;

		get_results.Enabled=false;
		update.Enabled=true;

		up_id1.Text=dataset.Tables[0].Rows[0][0].ToString();
		up_first_name1.Text=dataset.Tables[0].Rows[0][1].ToString();
		up_last_name1.Text=dataset.Tables[0].Rows[0][2].ToString();
		cb4stage.SelectedIndex=int.Parse( dataset.Tables[0].Rows[0][3].ToString());
        //here study year
        status2.SelectedIndex =int.Parse( dataset.Tables[0].Rows[0][5].ToString());
	
	
	}

	private void del_st_Click(object sender, System.EventArgs e)
	{
		
		DialogResult result=MessageBox.Show("Are you sure you want to delete that Student","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
		if (result==DialogResult.Yes)
		{
			cmd=cnn.MyConnection.CreateCommand();
			cmd.CommandText="DELETE FROM Students WHERE id="+st_id;
			int r=cmd.ExecuteNonQuery();
			if(r!=0)
			{
				MessageBox.Show("The student was successfully deleted ","Student Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);	
				display_Click(this,new System.EventArgs());
			}
		}
	}

    private void Form1_Load(object sender, EventArgs e)
    {
        ClassLibrary2.Class1 class2 = new ClassLibrary2.Class1();
        class2.SetProcessWorkingSetSize();
        this.Show();
        a = new Label();
        t = new TextBox();
        a.Name = "";
        t.Name = "";
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (status2.Enabled)
            status2.Enabled = false;
        else
            status2.Enabled = true;
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (status3.Enabled)
            status3.Enabled = false;
        else
            status3.Enabled = true;
    }
    static Label a;
static TextBox t;
    public int i = 0;     
    private void cbstage_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c.Name.Contains("lbla") || c.Name.Contains("txtt"))
                    this.groupBox1.Controls.Remove(c);
            }
        try
        {
            cnn.MyConnection.Close();
        }
        catch (System.Data.OleDb.OleDbException) { }
        connect();
        cmd = cnn.MyConnection.CreateCommand();
        cmd.CommandText = "SELECT Course_name FROM Courses WHERE year_no=" + (cbstage.SelectedIndex + 1) + "";//Course_name// ORDER BY id ASC
        reader = cmd.ExecuteReader();
        //OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
        //DataSet dataset = new DataSet();
        

        //int result = adapter.Fill(dataset);
        i = 0;
        while(reader.Read())
        {
            a = new Label();
            t = new TextBox();
            //MessageBox.Show(reader.GetValue(0).ToString());
            t.Name = "txtt" + i.ToString();
            a.Name = "lbla" + i.ToString();
            a.Location = new Point(252, 47+30*i);
            a.Width = 75;
            t.Location = new Point(330, 47 + 30 * i);
            a.Text = reader.GetValue(0).ToString()+':';
            t.Text = "";
            a.Visible = true;
            t.Show();
            this.groupBox1.Controls.Add(a);
            this.groupBox1.Controls.Add(t);
            //this.Controls.Add(a);
            i++;
        }*/

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void first_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void id_TextChanged(object sender, EventArgs e)
    {

    }

    private void up_last_name2_TextChanged(object sender, EventArgs e)
    {

    }

    private void up_id2_TextChanged(object sender, EventArgs e)
    {

    }

    private void idd_Click(object sender, EventArgs e)
    {

    }

    private void del_first_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void last_named_Click(object sender, EventArgs e)
    {

    }

    private void up_id1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void last_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void del_id_TextChanged(object sender, EventArgs e)
    {

    }

    private void up_first_name1_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage4_Click(object sender, EventArgs e)
    {

    }

    private void del_last_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {

    }

    private void r_id_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void r_stage_TextChanged(object sender, EventArgs e)
    {

    }

    private void r_last_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void r_first_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void cb3stage_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void s_last_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void s_first_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void s_id_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void results_Click(object sender, EventArgs e)
    {

    }
    //public Int32 max;
    private void tabPage3_Click(object sender, EventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void status_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void s_year_TextChanged(object sender, EventArgs e)
    {

    }

    private void first_named_Click(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void up_last_name1_TextChanged(object sender, EventArgs e)
    {

    }

    private void up_first_name2_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage6_Click(object sender, EventArgs e)
    {

    }

    private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
    {

    }

    private void tabPage5_Click(object sender, EventArgs e)
    {

    }

    private void cb5stage_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cb4stage_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void status2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void up_results_Click(object sender, EventArgs e)
    {

    }

    private void tabPage7_Click(object sender, EventArgs e)
    {

    }

    private void groupBox5_Enter(object sender, EventArgs e)
    {

    }

    private void groupBox7_Enter(object sender, EventArgs e)
    {

    }

    private void ass_c_name_TextChanged(object sender, EventArgs e)
    {

    }

    private void results3_Click(object sender, EventArgs e)
    {

    }

    private void ass_st_lname_TextChanged(object sender, EventArgs e)
    {

    }

    private void ass_st_fname_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBox6_Enter(object sender, EventArgs e)
    {

    }

    private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void results2_Click(object sender, EventArgs e)
    {

    }

    private void tabPage8_Click(object sender, EventArgs e)
    {

    }

    private void dataGrid2_Navigate(object sender, NavigateEventArgs ne)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }

    private void gr_id_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBox8_Enter(object sender, EventArgs e)
    {

    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void contextMenu1_Popup(object sender, EventArgs e)
    {

    }

    private void tabPage9_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

    private void groupBox10_Enter(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void button8_Click(object sender, EventArgs e)
    {

    }

    private void label13_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox8_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button9_Click(object sender, EventArgs e)
    {

    }

    private void button10_Click(object sender, EventArgs e)
    {

    }

    private void groupBox11_Enter(object sender, EventArgs e)
    {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label14_Click(object sender, EventArgs e)
    {

    }

    private void button11_Click(object sender, EventArgs e)
    {

    }

    private void button12_Click(object sender, EventArgs e)
    {

    }

    private void button13_Click(object sender, EventArgs e)
    {

    }

    private void button14_Click(object sender, EventArgs e)
    {

    }

    private void button15_Click(object sender, EventArgs e)
    {

    }

    private void button16_Click(object sender, EventArgs e)
    {

    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label15_Click(object sender, EventArgs e)
    {

    }

    private void button18_Click(object sender, EventArgs e)
    {
        button21_Click(sender, e);
        cmd = null;
        cmd = cnn.MyConnection.CreateCommand();
        string query = "SELECT s.ID,first_name,last_name,stage,s.study_year,status,c.ID,Course_name,year_no,Midterm_Grades,Term_Grades,help_grades FROM Students s,Courses c,Grades g WHERE";
        string query2 = "";
        if (textBox9.Enabled)
        {
            if (textBox9.Text == "" || !Regex.Match(textBox9.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the Id field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            query2 += " s.id=" + textBox9.Text;

        }
        if (textBox8.Enabled)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Enter a value in the first name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox9.Enabled)
                query2 += " AND";
            query2 += " s.first_name='" + textBox8.Text + "'";
        }
        if (textBox7.Enabled)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter a value in the last name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox9.Enabled || textBox8.Enabled)
                query2 += " AND";
            query2 += " s.last_name='" + textBox7.Text + "'";
        }
        if (comboBox5.Enabled)
        {
            if (comboBox5.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter a value in the stage field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox9.Enabled || textBox8.Enabled || textBox7.Enabled)
                query2 += " AND";
            query2 += " s.stage=" + (comboBox5.SelectedIndex + 1) + "";
        }

        if (query2 == "")
        {
            MessageBox.Show("Please enter any detail of the student", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        //MessageBox.Show(query+query2);

        size = 0;
        index = 0;

        cmd.CommandText = query + query2 + "AND s.ID=g.S_ID AND c.id=g.C_ID ORDER BY S.ID,C.ID ASC";

        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            students[size].id = (int)reader.GetValue(0);
            students[size].f_name = reader.GetValue(1).ToString();
            students[size].l_name = reader.GetValue(2).ToString();
            students[size].stage = int.Parse(reader.GetValue(3).ToString());
            students[size].s_year = int.Parse(reader.GetValue(4).ToString());
            students[size].status = int.Parse(reader.GetValue(5).ToString());
            coarses[size].c_id=int.Parse(reader.GetValue(6).ToString());
            coarses[size].name=reader.GetValue(7).ToString();
            grade1[size].midterm=int.Parse(reader.GetValue(9).ToString());
            grade1[size].term=int.Parse(reader.GetValue(10).ToString());
            students[size].help_grades = int.Parse(reader.GetValue(11).ToString());
            size++;
        }
        reader.Close();
        if (size == 0)
        {
            MessageBox.Show("No students were found");
        }
        else
        {
            MessageBox.Show(size + " students were found", "Results");
            display_results_3(0);
            
            

            if (size > 1)
                button17.Enabled = true;

            checkBox13.Text = coarses[0].name;
            checkBox14.Text = coarses[1].name;
            checkBox15.Text = coarses[2].name;
            checkBox16.Text = coarses[3].name;
            checkBox17.Text = coarses[4].name;
            checkBox18.Text = coarses[5].name;

            ShowResult();

           /* OleDbCommand cmd22 = cnn.MyConnection.CreateCommand();
            string query3 = "SELECT id,Course_name FROM Courses WHERE year_no=" + comboBox5.SelectedIndex+1;
            cmd22.CommandText = query3 ;
            reader2= cmd22.ExecuteReader();
            int size2 = 0;
            while (reader2.Read())
            {
                coarses2[size2].c_id = (int)reader2.GetValue(0);
                coarses2[size2].name = reader2.GetValue(1).ToString();
                size2++;
            }
            reader.Close();
            
         */   
        }
		
    }

    private void button17_Click(object sender, EventArgs e)
    {
        button19.Enabled = true;
        index++;
        if (index < size)
        {
            display_results_3(index);

        }
        else
        {
            MessageBox.Show("No More Results");
            index--;
            button17.Enabled = false;
        }
	
    }

    private void button19_Click(object sender, EventArgs e)
    {
        index--;
        button17.Enabled = true;
        if (index >= 0)
        {
            display_results_3(index);
        }
        else
        {
            MessageBox.Show("No More Results");
            index++;
            button19.Enabled = false;
        }
    }

    private void button20_Click(object sender, EventArgs e)
    {
        cmd = cnn.MyConnection.CreateCommand();
        int i2 = 5;
        /*foreach (Control txt_private in this.groupBox12.Controls)
        {
            if (txt_private is TextBox)
            {
                if (txt_private.Enabled)
                {

                    if (txt_private.Text == "" || !Regex.Match(txt_private.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[i2].name + " " + coarses[i2].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[i2].c_id + ",Term_Grades=" + txt_private.Text + " WHERE S_ID=" + textBox9.Text+" AND C_ID="+coarses[i2].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r=cmd.ExecuteNonQuery();
                    txt_private.Enabled = false;
                    if (r != 0)
                        continue;
                    else
                        MessageBox.Show("Error But Unknown.");
                }
                i2--;
            }
        }*/
        if (textBox15.Enabled)
        {

            if (textBox15.Text == "" || !Regex.Match(textBox15.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[5].name + " " + coarses[5].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[5].c_id + ",Term_Grades=" + textBox15.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[5].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox15.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
        if (textBox14.Enabled)
        {

            if (textBox14.Text == "" || !Regex.Match(textBox14.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[4].name + " " + coarses[4].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[4].c_id + ",Term_Grades=" + textBox14.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[4].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox14.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
        if (textBox13.Enabled)
        {

            if (textBox13.Text == "" || !Regex.Match(textBox13.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[3].name + " " + coarses[3].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[3].c_id + ",Term_Grades=" + textBox13.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[3].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox13.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
        if (textBox12.Enabled)
        {

            if (textBox12.Text == "" || !Regex.Match(textBox12.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[2].name + " " + coarses[2].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[2].c_id + ",Term_Grades=" + textBox12.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[2].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox12.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
        if (textBox11.Enabled)
        {

            if (textBox11.Text == "" || !Regex.Match(textBox11.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[0].name + " " + coarses[0].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[0].c_id + ",Term_Grades=" + textBox11.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[0].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox11.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
        if (textBox10.Enabled)
        {

            if (textBox10.Text == "" || !Regex.Match(textBox10.Text, @"^\d*$").Success)
            {
                MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;// = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
            query = "Update Grades SET S_ID=";
            MessageBox.Show(coarses[1].name + " " + coarses[1].c_id.ToString());
            query += textBox9.Text + ",C_ID=" + coarses[1].c_id + ",Term_Grades=" + textBox10.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[1].c_id;
            //MessageBox.Show(query);
            cmd.CommandText = query;
            int r = cmd.ExecuteNonQuery();
            textBox10.Enabled = false;
            if (r == 0)
                //continue;
                //else
                MessageBox.Show("Error But Unknown.");
        }
        i2--;
            
        MessageBox.Show("Student data was updated successfuly");
        button21_Click(sender, e);
                   
    }

    private void checkBox12_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox9.Enabled)
            textBox9.Enabled = false;
        else
            textBox9.Enabled = true;
    }

    private void checkBox11_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox8.Enabled)
            textBox8.Enabled = false;
        else
            textBox8.Enabled = true;
    }

    private void checkBox10_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox7.Enabled)
            textBox7.Enabled = false;
        else
            textBox7.Enabled = true;
    }

    private void checkBox9_CheckedChanged(object sender, EventArgs e)
    {
        if (comboBox5.Enabled)
            comboBox5.Enabled = false;
        else
            comboBox5.Enabled = true;
    }

    private void checkBox13_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox11.Enabled)
            textBox11.Enabled = false;
        else
            textBox11.Enabled = true;
    }

    private void checkBox14_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox10.Enabled)
            textBox10.Enabled = false;
        else
            textBox10.Enabled = true;
    }

    private void checkBox15_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox12.Enabled)
            textBox12.Enabled = false;
        else
            textBox12.Enabled = true;
    }

    private void checkBox16_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox13.Enabled)
            textBox13.Enabled = false;
        else
            textBox13.Enabled = true;
    }

    private void checkBox17_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox14.Enabled)
            textBox14.Enabled = false;
        else
            textBox14.Enabled = true;
    }

    private void checkBox18_CheckedChanged(object sender, EventArgs e)
    {
        if (textBox15.Enabled)
            textBox15.Enabled = false;
        else
            textBox15.Enabled = true;
    }
    static void asd(CheckBox c)
    {
        c.Checked = false;
    }
    private void button21_Click(object sender, EventArgs e)
    {
        int i = 1;
        foreach (Control c in this.groupBox12.Controls)
        {
            if (c is CheckBox)
            {
                asd((CheckBox) c);
                c.Text = "course" + i++.ToString();
            }

        }
    }
    void ShowResult()
    {
        textBox11.Text = grade1[0].term.ToString();
        textBox10.Text = grade1[1].term.ToString();
        textBox12.Text = grade1[2].term.ToString();
        textBox13.Text = grade1[3].term.ToString();
        textBox14.Text = grade1[4].term.ToString();
        textBox15.Text = grade1[5].term.ToString();
    }

    private void button22_Click(object sender, EventArgs e)
    {
        int max=10,aI=0;
        cmd = cnn.MyConnection.CreateCommand();
        //int i2 = 5;
        string query;
        for (int i = 0; i < 6; i++)
        {
            if (grade1[i].term < 50 && grade1[i].term > 40 && max>0)
            {
                aI=50 - grade1[i].term;
                if ((aI) <= max)
                {
                    max -= aI;
                    grade1[i].term = 50;
                    query = "Update Grades SET Term_Grades=" + grade1[i].term +" WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[i].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    if (r == 0)
                    { MessageBox.Show("Error But Unknown."); return; }
                }
            }
        }
        ShowResult();
        
        /*foreach (Control txt_private in this.groupBox12.Controls)
        {
            if (txt_private is TextBox)
            {
             */
        //for
/*        if (textBox11.Enabled)
                {
            if (textBox11.Text == "" || !Regex.Match(textBox11.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[5].name + " " + coarses[5].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[5].c_id + ",Term_Grades=" + textBox11.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[5].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox13.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
                if (textBox10.Enabled)
                {
                    if (textBox10.Text == "" || !Regex.Match(textBox10.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[4].name + " " + coarses[4].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[4].c_id + ",Term_Grades=" + textBox10.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[4].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox14.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
         
        if (textBox12.Enabled)
                {

                    if (textBox12.Text == "" || !Regex.Match(textBox12.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[3].name + " " + coarses[3].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[3].c_id + ",Term_Grades=" + textBox12.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[3].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox15.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
                if (textBox13.Enabled)
                {

                    if (textBox13.Text == "" || !Regex.Match(textBox13.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[2].name + " " + coarses[2].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[2].c_id + ",Term_Grades=" + textBox13.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[2].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox16.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
                if (textBox14.Enabled)
                {

                    if (textBox14.Text == "" || !Regex.Match(textBox14.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[1].name + " " + coarses[1].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[1].c_id + ",Term_Grades=" + textBox14.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[1].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox17.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
                if (textBox15.Enabled)
                {

                    if (textBox15.Text == "" || !Regex.Match(textBox15.Text, @"^\d*$").Success)
                    {
                        MessageBox.Show("Please Enter an integer value in the grade field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // = "INSERT INTO Grades (S_ID,C_ID,Term_Grades) VALUES (";
                    query = "Update Grades SET S_ID=";
                    MessageBox.Show(coarses[0].name + " " + coarses[0].c_id.ToString());
                    query += textBox9.Text + ",C_ID=" + coarses[0].c_id + ",Term_Grades=" + textBox15.Text + " WHERE S_ID=" + textBox9.Text + " AND C_ID=" + coarses[0].c_id;
                    //MessageBox.Show(query);
                    cmd.CommandText = query;
                    int r = cmd.ExecuteNonQuery();
                    checkBox18.Enabled = false;
                    if (r == 0)
                        MessageBox.Show("Error But Unknown.");
                }
        */
         query = "Update Students SET help_grades=";
        //MessageBox.Show(coarses[i2].name + " " + coarses[i2].c_id.ToString());
        query += 1 + " WHERE ID=" + textBox9.Text;
        //MessageBox.Show(query);
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
                   
        MessageBox.Show("Student data was updated successfuly");
        button21_Click(sender, e);
        
        button22.Enabled = false;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
    }

    private void tabPage3_Enter(object sender, EventArgs e)
    {
        
        string strMax = "";
        OleDbDataReader reader2=null;
        try
        {
            cmd = cnn.MyConnection.CreateCommand();
            cmd.CommandText = "Select max(id) from students";
            reader2 = cmd.ExecuteReader();
            reader2.Read();
            //MessageBox.Show("is" + strMax);
            strMax = reader2.GetValue(0).ToString();
            reader2.Close();
        }
        catch (OleDbException ee)
        {
            MessageBox.Show(ee.Message);
        }
        finally
        {
            reader2.Close();
        }
        //Max = Int32.Parse(strMax);
        this.id.Text =Convert.ToString((int.Parse( strMax)+1));
    }

    private void tabPage3_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

    private void tabPage2_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

    private void tabPage5_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

    private void tabPage4_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

    private void tabPage9_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

    private void tabPage6_Leave(object sender, EventArgs e)
    {
        clear_text();
    }

}










