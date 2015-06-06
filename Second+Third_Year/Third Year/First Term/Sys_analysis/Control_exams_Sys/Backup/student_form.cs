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

	/// <summary>
	/// Description of Form1.	
	/// </summary>
public struct  student
{
	public string f_name;
	public string l_name;
	public int id;
	public string dob;
			
}
public struct coarse
{
	public int c_id;
	public string name;
}
			
public class Form1 : System.Windows.Forms.Form
{
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
	private System.Windows.Forms.TextBox r_dob;
	private System.Windows.Forms.Button get_results;
	private System.Windows.Forms.TextBox r_first_name;
	private System.Windows.Forms.Button button4;
	private System.Windows.Forms.Button update;
	private System.Windows.Forms.CheckBox ch_first_name;
	private System.Windows.Forms.TabPage tabPage5;
	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.CheckBox new_last_name;
	private System.Windows.Forms.CheckBox new_id;
	private System.Windows.Forms.TextBox up_first_name2;
	private System.Windows.Forms.TextBox up_last_name1;
	private System.Windows.Forms.CheckBox new_first_name;
	private System.Windows.Forms.TextBox s_first_name;
	private System.Windows.Forms.Label first_named;
	private System.Windows.Forms.TextBox s_dob;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.CheckBox ch_up_first_name;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox s_last_name;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Button next;
	private System.Windows.Forms.TextBox r_last_name;
	private System.Windows.Forms.CheckBox ch_s_id;
	private System.Windows.Forms.CheckBox ch_s_first_name;
	private System.Windows.Forms.TextBox dob;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.CheckBox new_dob;
	private System.Windows.Forms.TextBox up_dob2;
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
	private System.Windows.Forms.TextBox up_dob1;
	private System.Windows.Forms.TextBox up_id1;
	private System.Windows.Forms.CheckBox ch_s_dob;
	private System.Windows.Forms.Label last_named;
	private System.Windows.Forms.TextBox del_first_name;
	private System.Windows.Forms.CheckBox ch_up_last_name;
	private System.Windows.Forms.Label idd;
	private System.Windows.Forms.Button prev2;
	private System.Windows.Forms.TextBox up_id2;
	private System.Windows.Forms.TextBox up_last_name2;
	private System.Windows.Forms.CheckBox ch_up_dob;
	private System.Windows.Forms.TextBox id;
	private System.Windows.Forms.Label up_results;
	private System.Windows.Forms.CheckBox ch_up_id;
	private System.Windows.Forms.CheckBox ch_s_last_name;
	private System.Windows.Forms.Button search;
	private System.Windows.Forms.TextBox first_name;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Form parent;
	private OleDbConnection MyConnection;
	private OleDbDataReader reader;
	public int index;
	public int size;
	public int index2;
	public int size2;
	public int st_id;
	private System.Windows.Forms.TabPage tabPage6;
	private System.Windows.Forms.Button display;
	private System.Windows.Forms.DataGrid dataGrid1;
	private System.Windows.Forms.TabPage tabPage7;
	private System.Windows.Forms.TabPage tabPage8;
	private System.Windows.Forms.Button assign;
	private System.Windows.Forms.Button remove;
	private System.Windows.Forms.GroupBox groupBox5;
	private System.Windows.Forms.CheckBox ch_ass_st_id;
	private System.Windows.Forms.CheckBox ch_ass_st_fname;
	private System.Windows.Forms.CheckBox ch_ass_st_lname;
	private System.Windows.Forms.CheckBox ch_ass_st_dob;
	private System.Windows.Forms.TextBox ass_st_id;
	private System.Windows.Forms.TextBox ass_st_fname;
	private System.Windows.Forms.TextBox ass_st_lname;
	private System.Windows.Forms.TextBox ass_st_dob;
	private System.Windows.Forms.GroupBox groupBox6;
	private System.Windows.Forms.GroupBox groupBox7;
	private System.Windows.Forms.TextBox ass_c_id;
	private System.Windows.Forms.TextBox ass_c_name;
	private System.Windows.Forms.CheckBox ch_ass_c_name;
	private System.Windows.Forms.CheckBox ch_ass_c_id;
	private System.Windows.Forms.Button get_st;
	private System.Windows.Forms.Button next3;
	private System.Windows.Forms.Button prev3;
	private System.Windows.Forms.Button get_coarse;
	private System.Windows.Forms.Button cl4;
	private System.Windows.Forms.Label results2;
	private System.Windows.Forms.Label results3;
	private System.Windows.Forms.Button next4;
	private System.Windows.Forms.Button prev4;
	student[] students;
	coarse[] coarses;
	bool flag1;
	private System.Windows.Forms.TextBox gr_id;
	private System.Windows.Forms.Label label9;
	private System.Windows.Forms.GroupBox groupBox8;
	private System.Windows.Forms.Button get_course;
	private System.Windows.Forms.DataGrid dataGrid2;
	private System.Windows.Forms.ContextMenu contextMenu1; //////////////////
	private System.Windows.Forms.MenuItem menuItem1;
	private System.Windows.Forms.MenuItem update_st;
	private System.Windows.Forms.MenuItem del_st;
	bool flag2;

	public Form1(System.Windows.Forms.Form p)
	{
		//
		// The InitializeComponent() call is required for Windows Forms designer support.
		//
		InitializeComponent();
		parent=p;
		this.AcceptButton=button1;
		students=new student[100];
		coarses=new coarse[100];
		connect();
		flag1=false;
		flag2=false;
			
			
			
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
		this.label3 = new System.Windows.Forms.Label();
		this.first_name = new System.Windows.Forms.TextBox();
		this.search = new System.Windows.Forms.Button();
		this.ch_s_last_name = new System.Windows.Forms.CheckBox();
		this.ch_up_id = new System.Windows.Forms.CheckBox();
		this.up_results = new System.Windows.Forms.Label();
		this.id = new System.Windows.Forms.TextBox();
		this.ch_up_dob = new System.Windows.Forms.CheckBox();
		this.up_last_name2 = new System.Windows.Forms.TextBox();
		this.up_id2 = new System.Windows.Forms.TextBox();
		this.prev2 = new System.Windows.Forms.Button();
		this.idd = new System.Windows.Forms.Label();
		this.ch_up_last_name = new System.Windows.Forms.CheckBox();
		this.del_first_name = new System.Windows.Forms.TextBox();
		this.last_named = new System.Windows.Forms.Label();
		this.ch_s_dob = new System.Windows.Forms.CheckBox();
		this.up_id1 = new System.Windows.Forms.TextBox();
		this.up_dob1 = new System.Windows.Forms.TextBox();
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
		this.r_dob = new System.Windows.Forms.TextBox();
		this.r_last_name = new System.Windows.Forms.TextBox();
		this.r_first_name = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.ch_s_first_name = new System.Windows.Forms.CheckBox();
		this.ch_s_id = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.button4 = new System.Windows.Forms.Button();
		this.s_dob = new System.Windows.Forms.TextBox();
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
		this.add_clear = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.first_named = new System.Windows.Forms.Label();
		this.dob = new System.Windows.Forms.TextBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.up_dob2 = new System.Windows.Forms.TextBox();
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
		this.tabPage7 = new System.Windows.Forms.TabPage();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.cl4 = new System.Windows.Forms.Button();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.ass_c_name = new System.Windows.Forms.TextBox();
		this.ass_c_id = new System.Windows.Forms.TextBox();
		this.ch_ass_c_name = new System.Windows.Forms.CheckBox();
		this.ch_ass_c_id = new System.Windows.Forms.CheckBox();
		this.next4 = new System.Windows.Forms.Button();
		this.get_coarse = new System.Windows.Forms.Button();
		this.prev4 = new System.Windows.Forms.Button();
		this.results3 = new System.Windows.Forms.Label();
		this.ass_st_dob = new System.Windows.Forms.TextBox();
		this.ass_st_lname = new System.Windows.Forms.TextBox();
		this.ass_st_fname = new System.Windows.Forms.TextBox();
		this.ass_st_id = new System.Windows.Forms.TextBox();
		this.ch_ass_st_dob = new System.Windows.Forms.CheckBox();
		this.ch_ass_st_lname = new System.Windows.Forms.CheckBox();
		this.ch_ass_st_fname = new System.Windows.Forms.CheckBox();
		this.ch_ass_st_id = new System.Windows.Forms.CheckBox();
		this.assign = new System.Windows.Forms.Button();
		this.remove = new System.Windows.Forms.Button();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.results2 = new System.Windows.Forms.Label();
		this.prev3 = new System.Windows.Forms.Button();
		this.next3 = new System.Windows.Forms.Button();
		this.get_st = new System.Windows.Forms.Button();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.update = new System.Windows.Forms.Button();
		this.get_results = new System.Windows.Forms.Button();
		this.tabPage8 = new System.Windows.Forms.TabPage();
		this.dataGrid2 = new System.Windows.Forms.DataGrid();
		this.label9 = new System.Windows.Forms.Label();
		this.gr_id = new System.Windows.Forms.TextBox();
		this.groupBox8 = new System.Windows.Forms.GroupBox();
		this.get_course = new System.Windows.Forms.Button();
		this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		this.menuItem1 = new System.Windows.Forms.MenuItem();
		this.update_st = new System.Windows.Forms.MenuItem();
		this.del_st = new System.Windows.Forms.MenuItem();
		this.tabPage4.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
		this.tabPage7.SuspendLayout();
		this.groupBox5.SuspendLayout();
		this.groupBox7.SuspendLayout();
		this.groupBox6.SuspendLayout();
		this.tabPage5.SuspendLayout();
		this.tabPage8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
		this.groupBox8.SuspendLayout();
		this.SuspendLayout();
		// 
		// label3
		// 
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label3.ForeColor = System.Drawing.Color.Firebrick;
		this.label3.Location = new System.Drawing.Point(368, 24);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(136, 32);
		this.label3.TabIndex = 13;
		this.label3.Text = "New Value";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// first_name
		// 
		this.first_name.Location = new System.Drawing.Point(128, 88);
		this.first_name.Name = "first_name";
		this.first_name.Size = new System.Drawing.Size(224, 20);
		this.first_name.TabIndex = 5;
		this.first_name.Text = "";
		this.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// search
		// 
		this.search.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.search.Location = new System.Drawing.Point(376, 120);
		this.search.Name = "search";
		this.search.Size = new System.Drawing.Size(88, 40);
		this.search.TabIndex = 4;
		this.search.Text = "Search";
		this.search.Click += new System.EventHandler(this.SearchClick);
		// 
		// ch_s_last_name
		// 
		this.ch_s_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_s_last_name.Location = new System.Drawing.Point(16, 120);
		this.ch_s_last_name.Name = "ch_s_last_name";
		this.ch_s_last_name.Size = new System.Drawing.Size(112, 24);
		this.ch_s_last_name.TabIndex = 3;
		this.ch_s_last_name.Text = "Last Name";
		this.ch_s_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_s_last_name.CheckedChanged += new System.EventHandler(this.CheckBox5CheckedChanged);
		// 
		// ch_up_id
		// 
		this.ch_up_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_up_id.Location = new System.Drawing.Point(16, 56);
		this.ch_up_id.Name = "ch_up_id";
		this.ch_up_id.Size = new System.Drawing.Size(120, 32);
		this.ch_up_id.TabIndex = 0;
		this.ch_up_id.Text = "ID";
		this.ch_up_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_up_id.CheckedChanged += new System.EventHandler(this.Ch_up_idCheckedChanged);
		// 
		// up_results
		// 
		this.up_results.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.up_results.Location = new System.Drawing.Point(192, 240);
		this.up_results.Name = "up_results";
		this.up_results.Size = new System.Drawing.Size(144, 32);
		this.up_results.TabIndex = 22;
		this.up_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// id
		// 
		this.id.Location = new System.Drawing.Point(128, 40);
		this.id.Name = "id";
		this.id.Size = new System.Drawing.Size(224, 20);
		this.id.TabIndex = 4;
		this.id.Text = "";
		this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ch_up_dob
		// 
		this.ch_up_dob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_up_dob.Location = new System.Drawing.Point(16, 208);
		this.ch_up_dob.Name = "ch_up_dob";
		this.ch_up_dob.Size = new System.Drawing.Size(120, 32);
		this.ch_up_dob.TabIndex = 3;
		this.ch_up_dob.Text = "Date of Birth";
		this.ch_up_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_up_dob.CheckedChanged += new System.EventHandler(this.Ch_up_dobCheckedChanged);
		// 
		// up_last_name2
		// 
		this.up_last_name2.Enabled = false;
		this.up_last_name2.Location = new System.Drawing.Point(360, 160);
		this.up_last_name2.Name = "up_last_name2";
		this.up_last_name2.Size = new System.Drawing.Size(160, 20);
		this.up_last_name2.TabIndex = 11;
		this.up_last_name2.Text = "";
		this.up_last_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// up_id2
		// 
		this.up_id2.Enabled = false;
		this.up_id2.Location = new System.Drawing.Point(360, 64);
		this.up_id2.Name = "up_id2";
		this.up_id2.Size = new System.Drawing.Size(160, 20);
		this.up_id2.TabIndex = 9;
		this.up_id2.Text = "";
		this.up_id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// prev2
		// 
		this.prev2.Enabled = false;
		this.prev2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.prev2.Location = new System.Drawing.Point(24, 288);
		this.prev2.Name = "prev2";
		this.prev2.Size = new System.Drawing.Size(128, 40);
		this.prev2.TabIndex = 20;
		this.prev2.Text = "<< prev";
		this.prev2.Click += new System.EventHandler(this.Prev2Click);
		// 
		// idd
		// 
		this.idd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.idd.Location = new System.Drawing.Point(32, 32);
		this.idd.Name = "idd";
		this.idd.Size = new System.Drawing.Size(88, 32);
		this.idd.TabIndex = 0;
		this.idd.Text = "Student ID :";
		this.idd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// ch_up_last_name
		// 
		this.ch_up_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_up_last_name.Location = new System.Drawing.Point(16, 152);
		this.ch_up_last_name.Name = "ch_up_last_name";
		this.ch_up_last_name.TabIndex = 1;
		this.ch_up_last_name.Text = "Last Name";
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
		this.del_first_name.Text = "";
		// 
		// last_named
		// 
		this.last_named.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.last_named.Location = new System.Drawing.Point(32, 132);
		this.last_named.Name = "last_named";
		this.last_named.Size = new System.Drawing.Size(88, 32);
		this.last_named.TabIndex = 2;
		this.last_named.Text = "Last Name :";
		this.last_named.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// ch_s_dob
		// 
		this.ch_s_dob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_s_dob.Location = new System.Drawing.Point(16, 160);
		this.ch_s_dob.Name = "ch_s_dob";
		this.ch_s_dob.Size = new System.Drawing.Size(112, 24);
		this.ch_s_dob.TabIndex = 4;
		this.ch_s_dob.Text = "Date of Birth";
		this.ch_s_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_s_dob.CheckedChanged += new System.EventHandler(this.CheckBox6CheckedChanged);
		// 
		// up_id1
		// 
		this.up_id1.Enabled = false;
		this.up_id1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.up_id1.Location = new System.Drawing.Point(144, 64);
		this.up_id1.Name = "up_id1";
		this.up_id1.Size = new System.Drawing.Size(152, 21);
		this.up_id1.TabIndex = 5;
		this.up_id1.Text = "";
		this.up_id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// up_dob1
		// 
		this.up_dob1.Enabled = false;
		this.up_dob1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.up_dob1.Location = new System.Drawing.Point(144, 208);
		this.up_dob1.Name = "up_dob1";
		this.up_dob1.Size = new System.Drawing.Size(152, 21);
		this.up_dob1.TabIndex = 8;
		this.up_dob1.Text = "";
		this.up_dob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ch_id
		// 
		this.ch_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_id.Location = new System.Drawing.Point(16, 32);
		this.ch_id.Name = "ch_id";
		this.ch_id.Size = new System.Drawing.Size(104, 40);
		this.ch_id.TabIndex = 0;
		this.ch_id.Text = "Student ID";
		this.ch_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_id.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
		// 
		// label5
		// 
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label5.Location = new System.Drawing.Point(24, 182);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(104, 32);
		this.label5.TabIndex = 3;
		this.label5.Text = "Date of Birth :";
		this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
		// 
		// last_name
		// 
		this.last_name.Location = new System.Drawing.Point(128, 136);
		this.last_name.Name = "last_name";
		this.last_name.Size = new System.Drawing.Size(224, 20);
		this.last_name.TabIndex = 6;
		this.last_name.Text = "";
		this.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// next2
		// 
		this.next2.Enabled = false;
		this.next2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.next2.Location = new System.Drawing.Point(400, 288);
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
		this.del_id.Text = "";
		// 
		// cl
		// 
		this.cl.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
		this.up_first_name1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.up_first_name1.Location = new System.Drawing.Point(144, 112);
		this.up_first_name1.Name = "up_first_name1";
		this.up_first_name1.Size = new System.Drawing.Size(152, 21);
		this.up_first_name1.TabIndex = 6;
		this.up_first_name1.Text = "";
		this.up_first_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
		// 
		// button2
		// 
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
		this.del_last_name.Text = "";
		// 
		// ch_last_name
		// 
		this.ch_last_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.button3.Location = new System.Drawing.Point(128, 240);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(224, 40);
		this.button3.TabIndex = 4;
		this.button3.Text = "Delete";
		this.button3.Click += new System.EventHandler(this.Button3Click);
		// 
		// ch_first_name
		// 
		this.ch_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
		// 
		// r_id
		// 
		this.r_id.Enabled = false;
		this.r_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.r_id.Location = new System.Drawing.Point(24, 288);
		this.r_id.Name = "r_id";
		this.r_id.Size = new System.Drawing.Size(88, 21);
		this.r_id.TabIndex = 10;
		this.r_id.Text = "";
		this.r_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.Add(this.r_dob);
		this.tabPage2.Controls.Add(this.r_last_name);
		this.tabPage2.Controls.Add(this.r_first_name);
		this.tabPage2.Controls.Add(this.r_id);
		this.tabPage2.Controls.Add(this.label8);
		this.tabPage2.Controls.Add(this.label7);
		this.tabPage2.Controls.Add(this.label6);
		this.tabPage2.Controls.Add(this.label4);
		this.tabPage2.Controls.Add(this.ch_s_dob);
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
		// 
		// r_dob
		// 
		this.r_dob.Enabled = false;
		this.r_dob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.r_dob.Location = new System.Drawing.Point(344, 288);
		this.r_dob.Name = "r_dob";
		this.r_dob.Size = new System.Drawing.Size(88, 21);
		this.r_dob.TabIndex = 13;
		this.r_dob.Text = "";
		this.r_dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// r_last_name
		// 
		this.r_last_name.Enabled = false;
		this.r_last_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.r_last_name.Location = new System.Drawing.Point(232, 288);
		this.r_last_name.Name = "r_last_name";
		this.r_last_name.Size = new System.Drawing.Size(88, 21);
		this.r_last_name.TabIndex = 12;
		this.r_last_name.Text = "";
		this.r_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// r_first_name
		// 
		this.r_first_name.Enabled = false;
		this.r_first_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.r_first_name.Location = new System.Drawing.Point(128, 288);
		this.r_first_name.Name = "r_first_name";
		this.r_first_name.Size = new System.Drawing.Size(88, 21);
		this.r_first_name.TabIndex = 11;
		this.r_first_name.Text = "";
		this.r_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// label8
		// 
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label8.ForeColor = System.Drawing.Color.Firebrick;
		this.label8.Location = new System.Drawing.Point(336, 256);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(96, 24);
		this.label8.TabIndex = 9;
		this.label8.Text = "Date Of Birth";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// label7
		// 
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label7.ForeColor = System.Drawing.Color.Firebrick;
		this.label7.Location = new System.Drawing.Point(232, 256);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(80, 24);
		this.label7.TabIndex = 8;
		this.label7.Text = "Last Name";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// label6
		// 
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label6.ForeColor = System.Drawing.Color.Firebrick;
		this.label6.Location = new System.Drawing.Point(128, 256);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(80, 24);
		this.label6.TabIndex = 7;
		this.label6.Text = "First Name";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// label4
		// 
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label4.ForeColor = System.Drawing.Color.Firebrick;
		this.label4.Location = new System.Drawing.Point(24, 256);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(80, 24);
		this.label4.TabIndex = 6;
		this.label4.Text = "ID";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// ch_s_first_name
		// 
		this.ch_s_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_s_first_name.Location = new System.Drawing.Point(16, 72);
		this.ch_s_first_name.Name = "ch_s_first_name";
		this.ch_s_first_name.Size = new System.Drawing.Size(112, 24);
		this.ch_s_first_name.TabIndex = 2;
		this.ch_s_first_name.Text = "First Name";
		this.ch_s_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_s_first_name.CheckedChanged += new System.EventHandler(this.CheckBox4CheckedChanged);
		// 
		// ch_s_id
		// 
		this.ch_s_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
		this.groupBox2.Controls.Add(this.button4);
		this.groupBox2.Controls.Add(this.search);
		this.groupBox2.Controls.Add(this.s_dob);
		this.groupBox2.Controls.Add(this.s_last_name);
		this.groupBox2.Controls.Add(this.s_first_name);
		this.groupBox2.Controls.Add(this.s_id);
		this.groupBox2.Location = new System.Drawing.Point(8, 8);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(480, 184);
		this.groupBox2.TabIndex = 5;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Search Criterea";
		// 
		// button4
		// 
		this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.button4.Location = new System.Drawing.Point(376, 40);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(88, 40);
		this.button4.TabIndex = 5;
		this.button4.Text = "Clear";
		this.button4.Click += new System.EventHandler(this.ClClick);
		// 
		// s_dob
		// 
		this.s_dob.Enabled = false;
		this.s_dob.Location = new System.Drawing.Point(144, 152);
		this.s_dob.Name = "s_dob";
		this.s_dob.Size = new System.Drawing.Size(216, 20);
		this.s_dob.TabIndex = 3;
		this.s_dob.Text = "";
		// 
		// s_last_name
		// 
		this.s_last_name.Enabled = false;
		this.s_last_name.Location = new System.Drawing.Point(144, 112);
		this.s_last_name.Name = "s_last_name";
		this.s_last_name.Size = new System.Drawing.Size(216, 20);
		this.s_last_name.TabIndex = 2;
		this.s_last_name.Text = "";
		// 
		// s_first_name
		// 
		this.s_first_name.Enabled = false;
		this.s_first_name.Location = new System.Drawing.Point(144, 72);
		this.s_first_name.Name = "s_first_name";
		this.s_first_name.Size = new System.Drawing.Size(216, 20);
		this.s_first_name.TabIndex = 1;
		this.s_first_name.Text = "";
		// 
		// s_id
		// 
		this.s_id.Enabled = false;
		this.s_id.Location = new System.Drawing.Point(144, 32);
		this.s_id.Name = "s_id";
		this.s_id.Size = new System.Drawing.Size(216, 20);
		this.s_id.TabIndex = 0;
		this.s_id.Text = "";
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
		// 
		// results
		// 
		this.results.Location = new System.Drawing.Point(144, 112);
		this.results.Name = "results";
		this.results.Size = new System.Drawing.Size(128, 32);
		this.results.TabIndex = 2;
		this.results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// next
		// 
		this.next.Enabled = false;
		this.next.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
		this.prev.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
		// 
		// label1
		// 
		this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label1.Location = new System.Drawing.Point(16, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(344, 32);
		this.label1.TabIndex = 1;
		this.label1.Text = "Please Enter the data of the student\'s you want to add";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// groupBox1
		// 
		this.groupBox1.Controls.Add(this.add_clear);
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Controls.Add(this.id);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.last_named);
		this.groupBox1.Controls.Add(this.first_named);
		this.groupBox1.Controls.Add(this.idd);
		this.groupBox1.Controls.Add(this.last_name);
		this.groupBox1.Controls.Add(this.dob);
		this.groupBox1.Controls.Add(this.first_name);
		this.groupBox1.Location = new System.Drawing.Point(8, 40);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(472, 328);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Student\'s Data";
		// 
		// add_clear
		// 
		this.add_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.add_clear.Location = new System.Drawing.Point(376, 112);
		this.add_clear.Name = "add_clear";
		this.add_clear.Size = new System.Drawing.Size(80, 32);
		this.add_clear.TabIndex = 9;
		this.add_clear.Text = "Clear";
		this.add_clear.Click += new System.EventHandler(this.Add_clearClick);
		// 
		// button1
		// 
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.button1.Location = new System.Drawing.Point(184, 240);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(136, 40);
		this.button1.TabIndex = 8;
		this.button1.Text = "Add Student";
		this.button1.Click += new System.EventHandler(this.Button1Click);
		// 
		// first_named
		// 
		this.first_named.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.first_named.Location = new System.Drawing.Point(32, 82);
		this.first_named.Name = "first_named";
		this.first_named.Size = new System.Drawing.Size(88, 32);
		this.first_named.TabIndex = 1;
		this.first_named.Text = "First Name :";
		this.first_named.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// dob
		// 
		this.dob.Location = new System.Drawing.Point(128, 192);
		this.dob.Name = "dob";
		this.dob.Size = new System.Drawing.Size(224, 20);
		this.dob.TabIndex = 7;
		this.dob.Text = "";
		this.dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// textBox5
		// 
		this.textBox5.Location = new System.Drawing.Point(192, 144);
		this.textBox5.Name = "textBox5";
		this.textBox5.Size = new System.Drawing.Size(200, 20);
		this.textBox5.TabIndex = 4;
		this.textBox5.Text = "";
		// 
		// up_dob2
		// 
		this.up_dob2.Enabled = false;
		this.up_dob2.Location = new System.Drawing.Point(360, 208);
		this.up_dob2.Name = "up_dob2";
		this.up_dob2.Size = new System.Drawing.Size(160, 20);
		this.up_dob2.TabIndex = 12;
		this.up_dob2.Text = "";
		this.up_dob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// new_dob
		// 
		this.new_dob.Enabled = false;
		this.new_dob.Location = new System.Drawing.Point(328, 208);
		this.new_dob.Name = "new_dob";
		this.new_dob.Size = new System.Drawing.Size(16, 24);
		this.new_dob.TabIndex = 18;
		this.new_dob.CheckedChanged += new System.EventHandler(this.New_dobCheckedChanged);
		// 
		// tabPage1
		// 
		this.tabPage1.Location = new System.Drawing.Point(0, 0);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.TabIndex = 0;
		// 
		// ch_up_first_name
		// 
		this.ch_up_first_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.ch_up_first_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ch_up_first_name.Location = new System.Drawing.Point(16, 104);
		this.ch_up_first_name.Name = "ch_up_first_name";
		this.ch_up_first_name.Size = new System.Drawing.Size(120, 32);
		this.ch_up_first_name.TabIndex = 2;
		this.ch_up_first_name.Text = "First Name";
		this.ch_up_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_up_first_name.CheckedChanged += new System.EventHandler(this.Ch_up_first_nameCheckedChanged);
		// 
		// label2
		// 
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label2.ForeColor = System.Drawing.Color.Firebrick;
		this.label2.Location = new System.Drawing.Point(152, 24);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(136, 32);
		this.label2.TabIndex = 4;
		this.label2.Text = "Old Value";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// new_first_name
		// 
		this.new_first_name.Enabled = false;
		this.new_first_name.Location = new System.Drawing.Point(328, 112);
		this.new_first_name.Name = "new_first_name";
		this.new_first_name.Size = new System.Drawing.Size(16, 24);
		this.new_first_name.TabIndex = 16;
		this.new_first_name.CheckedChanged += new System.EventHandler(this.New_first_nameCheckedChanged);
		// 
		// up_last_name1
		// 
		this.up_last_name1.Enabled = false;
		this.up_last_name1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.up_last_name1.Location = new System.Drawing.Point(144, 160);
		this.up_last_name1.Name = "up_last_name1";
		this.up_last_name1.Size = new System.Drawing.Size(152, 21);
		this.up_last_name1.TabIndex = 7;
		this.up_last_name1.Text = "";
		this.up_last_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// up_first_name2
		// 
		this.up_first_name2.Enabled = false;
		this.up_first_name2.Location = new System.Drawing.Point(360, 112);
		this.up_first_name2.Name = "up_first_name2";
		this.up_first_name2.Size = new System.Drawing.Size(160, 20);
		this.up_first_name2.TabIndex = 10;
		this.up_first_name2.Text = "";
		this.up_first_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
		this.new_last_name.Location = new System.Drawing.Point(328, 160);
		this.new_last_name.Name = "new_last_name";
		this.new_last_name.Size = new System.Drawing.Size(16, 24);
		this.new_last_name.TabIndex = 17;
		this.new_last_name.CheckedChanged += new System.EventHandler(this.New_last_nameCheckedChanged);
		// 
		// tabControl1
		// 
		this.tabControl1.Controls.Add(this.tabPage6);
		this.tabControl1.Controls.Add(this.tabPage5);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Controls.Add(this.tabPage7);
		this.tabControl1.Controls.Add(this.tabPage8);
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
		// 
		// dataGrid1
		// 
		this.dataGrid1.CaptionText = "Student";
		this.dataGrid1.DataMember = "";
		this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
		this.dataGrid1.Location = new System.Drawing.Point(96, 32);
		this.dataGrid1.Name = "dataGrid1";
		this.dataGrid1.ParentRowsVisible = false;
		this.dataGrid1.ReadOnly = true;
		this.dataGrid1.Size = new System.Drawing.Size(344, 304);
		this.dataGrid1.TabIndex = 1;
		this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
		// 
		// display
		// 
		this.display.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.display.Location = new System.Drawing.Point(192, 336);
		this.display.Name = "display";
		this.display.Size = new System.Drawing.Size(136, 48);
		this.display.TabIndex = 0;
		this.display.Text = "Refresh";
		this.display.Click += new System.EventHandler(this.display_Click);
		// 
		// tabPage7
		// 
		this.tabPage7.Controls.Add(this.groupBox5);
		this.tabPage7.Location = new System.Drawing.Point(4, 22);
		this.tabPage7.Name = "tabPage7";
		this.tabPage7.Size = new System.Drawing.Size(560, 406);
		this.tabPage7.TabIndex = 6;
		this.tabPage7.Text = "Coarses";
		// 
		// groupBox5
		// 
		this.groupBox5.Controls.Add(this.cl4);
		this.groupBox5.Controls.Add(this.groupBox7);
		this.groupBox5.Controls.Add(this.ass_st_dob);
		this.groupBox5.Controls.Add(this.ass_st_lname);
		this.groupBox5.Controls.Add(this.ass_st_fname);
		this.groupBox5.Controls.Add(this.ass_st_id);
		this.groupBox5.Controls.Add(this.ch_ass_st_dob);
		this.groupBox5.Controls.Add(this.ch_ass_st_lname);
		this.groupBox5.Controls.Add(this.ch_ass_st_fname);
		this.groupBox5.Controls.Add(this.ch_ass_st_id);
		this.groupBox5.Controls.Add(this.assign);
		this.groupBox5.Controls.Add(this.remove);
		this.groupBox5.Controls.Add(this.groupBox6);
		this.groupBox5.Location = new System.Drawing.Point(8, 16);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(552, 368);
		this.groupBox5.TabIndex = 6;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Assign or Remove a coarse from a student";
		// 
		// cl4
		// 
		this.cl4.Location = new System.Drawing.Point(216, 328);
		this.cl4.Name = "cl4";
		this.cl4.Size = new System.Drawing.Size(136, 32);
		this.cl4.TabIndex = 13;
		this.cl4.Text = "Clear";
		this.cl4.Click += new System.EventHandler(this.ClClick);
		// 
		// groupBox7
		// 
		this.groupBox7.Controls.Add(this.ass_c_name);
		this.groupBox7.Controls.Add(this.ass_c_id);
		this.groupBox7.Controls.Add(this.ch_ass_c_name);
		this.groupBox7.Controls.Add(this.ch_ass_c_id);
		this.groupBox7.Controls.Add(this.next4);
		this.groupBox7.Controls.Add(this.get_coarse);
		this.groupBox7.Controls.Add(this.prev4);
		this.groupBox7.Controls.Add(this.results3);
		this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.groupBox7.ForeColor = System.Drawing.Color.Firebrick;
		this.groupBox7.Location = new System.Drawing.Point(272, 16);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(272, 296);
		this.groupBox7.TabIndex = 12;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "Coarse Information";
		// 
		// ass_c_name
		// 
		this.ass_c_name.Enabled = false;
		this.ass_c_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ass_c_name.Location = new System.Drawing.Point(128, 88);
		this.ass_c_name.Name = "ass_c_name";
		this.ass_c_name.Size = new System.Drawing.Size(120, 20);
		this.ass_c_name.TabIndex = 3;
		this.ass_c_name.Text = "";
		this.ass_c_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ass_c_id
		// 
		this.ass_c_id.Enabled = false;
		this.ass_c_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ass_c_id.Location = new System.Drawing.Point(128, 40);
		this.ass_c_id.Name = "ass_c_id";
		this.ass_c_id.Size = new System.Drawing.Size(120, 20);
		this.ass_c_id.TabIndex = 2;
		this.ass_c_id.Text = "";
		this.ass_c_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.ass_c_id.TextChanged += new System.EventHandler(this.ass_c_id_TextChanged);
		// 
		// ch_ass_c_name
		// 
		this.ch_ass_c_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_c_name.ForeColor = System.Drawing.Color.Black;
		this.ch_ass_c_name.Location = new System.Drawing.Point(8, 88);
		this.ch_ass_c_name.Name = "ch_ass_c_name";
		this.ch_ass_c_name.Size = new System.Drawing.Size(112, 24);
		this.ch_ass_c_name.TabIndex = 1;
		this.ch_ass_c_name.Text = "Coarse Name";
		this.ch_ass_c_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_c_name.CheckedChanged += new System.EventHandler(this.ch_ass_c_name_CheckedChanged);
		// 
		// ch_ass_c_id
		// 
		this.ch_ass_c_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_c_id.ForeColor = System.Drawing.Color.Black;
		this.ch_ass_c_id.Location = new System.Drawing.Point(8, 40);
		this.ch_ass_c_id.Name = "ch_ass_c_id";
		this.ch_ass_c_id.Size = new System.Drawing.Size(88, 24);
		this.ch_ass_c_id.TabIndex = 0;
		this.ch_ass_c_id.Text = "Coarse ID";
		this.ch_ass_c_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_c_id.CheckedChanged += new System.EventHandler(this.ch_ass_c_id_CheckedChanged);
		// 
		// next4
		// 
		this.next4.Enabled = false;
		this.next4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.next4.ForeColor = System.Drawing.Color.Black;
		this.next4.Location = new System.Drawing.Point(192, 256);
		this.next4.Name = "next4";
		this.next4.Size = new System.Drawing.Size(64, 32);
		this.next4.TabIndex = 3;
		this.next4.Text = "next >>";
		this.next4.Click += new System.EventHandler(this.next4_Click);
		// 
		// get_coarse
		// 
		this.get_coarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.get_coarse.ForeColor = System.Drawing.Color.Black;
		this.get_coarse.Location = new System.Drawing.Point(104, 256);
		this.get_coarse.Name = "get_coarse";
		this.get_coarse.Size = new System.Drawing.Size(72, 32);
		this.get_coarse.TabIndex = 3;
		this.get_coarse.Text = "Get Coarse";
		this.get_coarse.Click += new System.EventHandler(this.get_coarse_Click);
		// 
		// prev4
		// 
		this.prev4.Enabled = false;
		this.prev4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.prev4.ForeColor = System.Drawing.Color.Black;
		this.prev4.Location = new System.Drawing.Point(24, 256);
		this.prev4.Name = "prev4";
		this.prev4.Size = new System.Drawing.Size(64, 32);
		this.prev4.TabIndex = 3;
		this.prev4.Text = "<< prev";
		this.prev4.Click += new System.EventHandler(this.prev4_Click);
		// 
		// results3
		// 
		this.results3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.results3.Location = new System.Drawing.Point(88, 208);
		this.results3.Name = "results3";
		this.results3.Size = new System.Drawing.Size(112, 32);
		this.results3.TabIndex = 4;
		this.results3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// ass_st_dob
		// 
		this.ass_st_dob.Enabled = false;
		this.ass_st_dob.Location = new System.Drawing.Point(128, 200);
		this.ass_st_dob.Name = "ass_st_dob";
		this.ass_st_dob.Size = new System.Drawing.Size(120, 20);
		this.ass_st_dob.TabIndex = 9;
		this.ass_st_dob.Text = "";
		this.ass_st_dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ass_st_lname
		// 
		this.ass_st_lname.Enabled = false;
		this.ass_st_lname.Location = new System.Drawing.Point(128, 152);
		this.ass_st_lname.Name = "ass_st_lname";
		this.ass_st_lname.Size = new System.Drawing.Size(120, 20);
		this.ass_st_lname.TabIndex = 8;
		this.ass_st_lname.Text = "";
		this.ass_st_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ass_st_fname
		// 
		this.ass_st_fname.Enabled = false;
		this.ass_st_fname.Location = new System.Drawing.Point(128, 104);
		this.ass_st_fname.Name = "ass_st_fname";
		this.ass_st_fname.Size = new System.Drawing.Size(120, 20);
		this.ass_st_fname.TabIndex = 7;
		this.ass_st_fname.Text = "";
		this.ass_st_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// ass_st_id
		// 
		this.ass_st_id.Enabled = false;
		this.ass_st_id.Location = new System.Drawing.Point(128, 56);
		this.ass_st_id.Name = "ass_st_id";
		this.ass_st_id.Size = new System.Drawing.Size(120, 20);
		this.ass_st_id.TabIndex = 6;
		this.ass_st_id.Text = "";
		this.ass_st_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.ass_st_id.TextChanged += new System.EventHandler(this.ass_st_id_TextChanged);
		// 
		// ch_ass_st_dob
		// 
		this.ch_ass_st_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_st_dob.Location = new System.Drawing.Point(16, 192);
		this.ch_ass_st_dob.Name = "ch_ass_st_dob";
		this.ch_ass_st_dob.Size = new System.Drawing.Size(104, 32);
		this.ch_ass_st_dob.TabIndex = 3;
		this.ch_ass_st_dob.Text = "Date of Birth";
		this.ch_ass_st_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_st_dob.CheckedChanged += new System.EventHandler(this.ch_ass_st_dob_CheckedChanged);
		// 
		// ch_ass_st_lname
		// 
		this.ch_ass_st_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_st_lname.Location = new System.Drawing.Point(16, 144);
		this.ch_ass_st_lname.Name = "ch_ass_st_lname";
		this.ch_ass_st_lname.Size = new System.Drawing.Size(96, 32);
		this.ch_ass_st_lname.TabIndex = 2;
		this.ch_ass_st_lname.Text = "Last Name";
		this.ch_ass_st_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_st_lname.CheckedChanged += new System.EventHandler(this.ch_ass_st_lname_CheckedChanged);
		// 
		// ch_ass_st_fname
		// 
		this.ch_ass_st_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_st_fname.Location = new System.Drawing.Point(16, 96);
		this.ch_ass_st_fname.Name = "ch_ass_st_fname";
		this.ch_ass_st_fname.Size = new System.Drawing.Size(96, 32);
		this.ch_ass_st_fname.TabIndex = 1;
		this.ch_ass_st_fname.Text = "First Name";
		this.ch_ass_st_fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_st_fname.CheckedChanged += new System.EventHandler(this.ch_ass_st_fname_CheckedChanged);
		// 
		// ch_ass_st_id
		// 
		this.ch_ass_st_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.ch_ass_st_id.Location = new System.Drawing.Point(16, 48);
		this.ch_ass_st_id.Name = "ch_ass_st_id";
		this.ch_ass_st_id.Size = new System.Drawing.Size(96, 32);
		this.ch_ass_st_id.TabIndex = 0;
		this.ch_ass_st_id.Text = "Student ID";
		this.ch_ass_st_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ch_ass_st_id.CheckedChanged += new System.EventHandler(this.ch_ass_st_id_CheckedChanged);
		// 
		// assign
		// 
		this.assign.Enabled = false;
		this.assign.Location = new System.Drawing.Point(56, 328);
		this.assign.Name = "assign";
		this.assign.Size = new System.Drawing.Size(104, 32);
		this.assign.TabIndex = 4;
		this.assign.Text = "Assign";
		this.assign.Click += new System.EventHandler(this.assign_Click);
		// 
		// remove
		// 
		this.remove.Enabled = false;
		this.remove.Location = new System.Drawing.Point(408, 328);
		this.remove.Name = "remove";
		this.remove.Size = new System.Drawing.Size(104, 32);
		this.remove.TabIndex = 5;
		this.remove.Text = "Remove";
		this.remove.Click += new System.EventHandler(this.remove_Click);
		// 
		// groupBox6
		// 
		this.groupBox6.Controls.Add(this.results2);
		this.groupBox6.Controls.Add(this.prev3);
		this.groupBox6.Controls.Add(this.next3);
		this.groupBox6.Controls.Add(this.get_st);
		this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.groupBox6.ForeColor = System.Drawing.Color.Firebrick;
		this.groupBox6.Location = new System.Drawing.Point(8, 16);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(256, 296);
		this.groupBox6.TabIndex = 11;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Student Information";
		// 
		// results2
		// 
		this.results2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.results2.Location = new System.Drawing.Point(72, 216);
		this.results2.Name = "results2";
		this.results2.Size = new System.Drawing.Size(112, 32);
		this.results2.TabIndex = 3;
		this.results2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// prev3
		// 
		this.prev3.Enabled = false;
		this.prev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.prev3.ForeColor = System.Drawing.Color.Black;
		this.prev3.Location = new System.Drawing.Point(8, 256);
		this.prev3.Name = "prev3";
		this.prev3.Size = new System.Drawing.Size(64, 32);
		this.prev3.TabIndex = 2;
		this.prev3.Text = "<< prev";
		this.prev3.Click += new System.EventHandler(this.prev3_Click);
		// 
		// next3
		// 
		this.next3.Enabled = false;
		this.next3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.next3.ForeColor = System.Drawing.Color.Black;
		this.next3.Location = new System.Drawing.Point(176, 256);
		this.next3.Name = "next3";
		this.next3.Size = new System.Drawing.Size(64, 32);
		this.next3.TabIndex = 1;
		this.next3.Text = "next >>";
		this.next3.Click += new System.EventHandler(this.next3_Click);
		// 
		// get_st
		// 
		this.get_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.get_st.ForeColor = System.Drawing.Color.Black;
		this.get_st.Location = new System.Drawing.Point(88, 256);
		this.get_st.Name = "get_st";
		this.get_st.Size = new System.Drawing.Size(72, 32);
		this.get_st.TabIndex = 0;
		this.get_st.Text = "Get Student";
		this.get_st.Click += new System.EventHandler(this.get_st_Click);
		// 
		// tabPage5
		// 
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
		this.tabPage5.Controls.Add(this.up_dob2);
		this.tabPage5.Controls.Add(this.up_last_name2);
		this.tabPage5.Controls.Add(this.up_first_name2);
		this.tabPage5.Controls.Add(this.up_id2);
		this.tabPage5.Controls.Add(this.up_dob1);
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
		// 
		// update
		// 
		this.update.Enabled = false;
		this.update.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.update.Location = new System.Drawing.Point(408, 352);
		this.update.Name = "update";
		this.update.Size = new System.Drawing.Size(112, 40);
		this.update.TabIndex = 19;
		this.update.Text = "Update";
		this.update.Click += new System.EventHandler(this.Button2Click);
		// 
		// get_results
		// 
		this.get_results.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.get_results.Location = new System.Drawing.Point(216, 288);
		this.get_results.Name = "get_results";
		this.get_results.Size = new System.Drawing.Size(128, 40);
		this.get_results.TabIndex = 14;
		this.get_results.Text = "Get Results";
		this.get_results.Click += new System.EventHandler(this.Get_resultsClick);
		// 
		// tabPage8
		// 
		this.tabPage8.Controls.Add(this.dataGrid2);
		this.tabPage8.Controls.Add(this.label9);
		this.tabPage8.Controls.Add(this.gr_id);
		this.tabPage8.Controls.Add(this.groupBox8);
		this.tabPage8.Location = new System.Drawing.Point(4, 22);
		this.tabPage8.Name = "tabPage8";
		this.tabPage8.Size = new System.Drawing.Size(560, 406);
		this.tabPage8.TabIndex = 7;
		this.tabPage8.Text = "Grades";
		// 
		// dataGrid2
		// 
		this.dataGrid2.DataMember = "";
		this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
		this.dataGrid2.Location = new System.Drawing.Point(48, 216);
		this.dataGrid2.Name = "dataGrid2";
		this.dataGrid2.Size = new System.Drawing.Size(432, 120);
		this.dataGrid2.TabIndex = 3;
		// 
		// label9
		// 
		this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
		this.label9.ForeColor = System.Drawing.Color.Firebrick;
		this.label9.Location = new System.Drawing.Point(16, 56);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(128, 24);
		this.label9.TabIndex = 1;
		this.label9.Text = "Student ID";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// gr_id
		// 
		this.gr_id.Location = new System.Drawing.Point(144, 56);
		this.gr_id.Name = "gr_id";
		this.gr_id.Size = new System.Drawing.Size(136, 20);
		this.gr_id.TabIndex = 0;
		this.gr_id.Text = "";
		this.gr_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		// 
		// groupBox8
		// 
		this.groupBox8.Controls.Add(this.get_course);
		this.groupBox8.Location = new System.Drawing.Point(8, 24);
		this.groupBox8.Name = "groupBox8";
		this.groupBox8.Size = new System.Drawing.Size(304, 168);
		this.groupBox8.TabIndex = 2;
		this.groupBox8.TabStop = false;
		this.groupBox8.Text = "Student Information";
		// 
		// get_course
		// 
		this.get_course.Location = new System.Drawing.Point(80, 96);
		this.get_course.Name = "get_course";
		this.get_course.Size = new System.Drawing.Size(136, 40);
		this.get_course.TabIndex = 0;
		this.get_course.Text = "Get Coarses";
		this.get_course.Click += new System.EventHandler(this.get_course_Click);
		// 
		// contextMenu1
		// 
		this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.update_st,
																					 this.del_st,
																					 this.menuItem1});
		// 
		// menuItem1
		// 
		this.menuItem1.Index = 2;
		this.menuItem1.Text = "Assign or Remove Coarse";
		this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
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
		// Form1
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(584, 462);
		this.Controls.Add(this.tabControl1);
		this.Name = "Form1";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Manage database";
		this.Click += new System.EventHandler(this.Add_clearClick);
		this.Closed += new System.EventHandler(this.Form1Closed);
		this.tabPage4.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.tabPage3.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.tabControl1.ResumeLayout(false);
		this.tabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
		this.tabPage7.ResumeLayout(false);
		this.groupBox5.ResumeLayout(false);
		this.groupBox7.ResumeLayout(false);
		this.groupBox6.ResumeLayout(false);
		this.tabPage5.ResumeLayout(false);
		this.tabPage8.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
		this.groupBox8.ResumeLayout(false);
		this.ResumeLayout(false);

	}
	#endregion
	void Form1Closed(object sender, System.EventArgs e)
	{
		parent.Visible=true;
		MyConnection.Close();
			
	}
	
		
	void connect ()
	{
		try
		{
			MyConnection =new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db1.mdb");
			MyConnection.Open();	
		}
		catch(System.Data.OleDb.OleDbException)
		{
			MessageBox.Show("Error: Database not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			Application.Exit();
		}
				
			
	}
	void clear_text()
	{
		get_results.Enabled=true;
		get_st.Enabled=true;
		ch_up_id.Checked=false;
		ch_up_first_name.Checked=false;
		ch_up_last_name.Checked=false;
		ch_up_dob.Checked=false;
			
		ch_id.Checked=false;
		ch_first_name.Checked=false;
		ch_last_name.Checked=false;
			
		ch_s_id.Checked=false;
		ch_s_first_name.Checked=false;
		ch_s_last_name.Checked=false;
		ch_s_dob.Checked=false;
			
		new_id.Checked=false;
		new_first_name.Checked=false;
		new_last_name.Checked=false;
		new_dob.Checked=false;
			
		id.Text="";
		first_name.Text="";
		last_name.Text="";
		dob.Text="";
		del_id.Text="";
		del_first_name.Text="";
		del_last_name.Text="";
			
		s_id.Text="";
		s_first_name.Text="";
		s_last_name.Text="";
		s_dob.Text="";
			
		r_id.Text="";
		r_first_name.Text="";
		r_last_name.Text="";
		r_dob.Text="";
			
		up_id1.Text="";
		up_first_name1.Text="";
		up_last_name1.Text="";
		up_dob1.Text="";
			
		up_id2.Text="";
		up_first_name2.Text="";
		up_last_name2.Text="";
		up_dob2.Text="";
			
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
			
		ass_st_id.Text="";
		ass_st_fname.Text="";
		ass_st_lname.Text="";
		ass_st_dob.Text="";
		ass_c_id.Text="";
		ass_c_name.Text="";

			
		ch_ass_st_id.Checked=false;
		ch_ass_st_fname.Checked=false;
		ch_ass_st_lname.Checked=false;
		ch_ass_st_dob.Checked=false;

		ch_ass_c_id.Checked=false;
		ch_ass_c_name.Checked=false;

		next3.Enabled=false;
		next4.Enabled=false;
		prev3.Enabled=false;
		prev4.Enabled=false;
		flag1=false;
		flag2=false;
		assign.Enabled=false;
		remove.Enabled=false;
		results2.Text="";
		results3.Text="";
	}
		
		
	
		
	void Button1Click(object sender, System.EventArgs e)
	{
		try
		{
			OleDbCommand cmd=MyConnection.CreateCommand();
			string query="INSERT INTO student (id,first_name,last_name,dob) VALUES (";
			query+=id.Text+",'"+first_name.Text+"','"+last_name.Text+"','"+dob.Text+"')";
			//MessageBox.Show(query);
			
			if(id.Text=="" || !Regex.Match(id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}
			if(first_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the first name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}
			if(last_name.Text=="")
			{
				MessageBox.Show("Please Enter a value in the last name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				//clear_text();
				return; 
			}
			if(dob.Text=="")
			{
				MessageBox.Show("Please Enter a value in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				//clear_text();
				return; 
			}
			cmd.CommandText=query;
			cmd.ExecuteNonQuery();
			MessageBox.Show("Student was added successfully to the database","Student added",MessageBoxButtons.OK,MessageBoxIcon.Information);
			clear_text();
		}
		catch(System.Data.OleDb.OleDbException m)
		{
			//	MessageBox.Show(m.ErrorCode.ToString());
			if(m.ErrorCode==ID_ERROR)
				MessageBox.Show("Can't add student, a student with the same ID already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else 
				if (m.ErrorCode==DATE_ERROR)
				MessageBox.Show("Please enter a valid date in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

			
			
		}
		
		
			
			
	}
		
	void Button2Click(object sender, System.EventArgs e)
	{
		try
		{
			OleDbCommand cmd =MyConnection.CreateCommand();
			string query="Update student SET";
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
			if(up_dob2.Enabled)
			{
				if(up_dob2.Text=="")
				{
					MessageBox.Show("Please Enter a value in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(up_id2.Enabled||up_first_name2.Enabled||up_last_name2.Enabled)
					query2+=",";
				query2+=" dob='"+up_dob2.Text+"'";
			}	
			
			if(query2=="")
			{
				MessageBox.Show("Please enter new details for the student you want to update ","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			query2+=" WHERE";
			
			query2+=" id="+up_id1.Text;
				
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
		OleDbCommand cmd=MyConnection.CreateCommand();
		string query="DELETE FROM student WHERE ";
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
		clear_text();
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
		if(up_dob1.Enabled)
			up_dob1.Enabled=false;
		else
			up_dob1.Enabled=true;
				
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
		if(s_dob.Enabled)
			s_dob.Enabled=false;
		else
			s_dob.Enabled=true;
	}
		
		
		
		
		
	void SearchClick(object sender, System.EventArgs e)
	{
		OleDbCommand cmd=MyConnection.CreateCommand();
		string query="SELECT * FROM student WHERE";
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
		if(s_dob.Enabled)
		{
			if(s_dob.Text=="")
			{
				MessageBox.Show("Please Enter a value in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(s_id.Enabled||s_first_name.Enabled||s_last_name.Enabled)
				query2+=" AND";
			query2+=" dob='"+s_dob.Text+"'";
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
			students[size].dob=reader.GetValue(3).ToString();				
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
		r_dob.Text=students[ind].dob.ToString();
	}
	void display_results3(int ind)
	{
		
		results2.Text="Result "+(index+1)+"/"+size;
		ass_st_id.Text=students[ind].id.ToString();
		ass_st_fname.Text=students[ind].f_name.ToString();
		ass_st_lname.Text=students[ind].l_name.ToString();
		ass_st_dob.Text=students[ind].dob.ToString();
	}
		
	void display_results4(int ind)
	{
		results3.Text="Result "+(index2+1)+"/"+size2;
		ass_c_id.Text=coarses[ind].c_id.ToString();
		ass_c_name.Text=coarses[ind].name;
	}

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
		up_dob1.Text=students[ind].dob.ToString();
	}
		
	void Get_resultsClick(object sender, System.EventArgs e)
	{
		OleDbCommand cmd=MyConnection.CreateCommand();
		string query="SELECT * FROM student WHERE";
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
		if(up_dob1.Enabled)
		{
			if(up_dob1.Text=="")
			{
				MessageBox.Show("Please Enter a value in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(up_id1.Enabled||up_first_name1.Enabled||up_last_name1.Enabled)
				query2+=" AND";
			query2+=" dob='"+up_dob1.Text+"'";
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
			students[size].dob=reader.GetValue(3).ToString();				
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
		if(up_dob2.Enabled)
			up_dob2.Enabled=false;
		else
			up_dob2.Enabled=true;
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
		OleDbCommand cmd=MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM student ORDER BY id ASC";
		OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);		
		DataSet dataset=new DataSet();
		
		int result=adapter.Fill(dataset,"student");	
		dataGrid1.DataSource=dataset.Tables[0];
			
		
	}

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
			OleDbCommand cmd=MyConnection.CreateCommand();
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
		
		OleDbCommand cmd=MyConnection.CreateCommand();
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
		if(ass_st_dob.Enabled)
			ass_st_dob.Enabled=false;
		else
			ass_st_dob.Enabled=true;
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
		OleDbCommand cmd=MyConnection.CreateCommand();
		string query="SELECT * FROM student WHERE";
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
		if(ass_st_dob.Enabled)
		{
			if(ass_st_dob.Text=="")
			{
				MessageBox.Show("Please Enter a value in the date of birth field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			if(ass_st_id.Enabled||ass_st_fname.Enabled||ass_st_lname.Enabled)
				query2+=" AND";
			query2+=" dob='"+ass_st_dob.Text+"'";
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
			students[size].dob=reader.GetValue(3).ToString();				
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
		string query1="SELECT * FROM coarse WHERE ";
		string query2="";
		if(ass_c_id.Enabled)
		{
			if(ass_c_id.Text==""||!Regex.Match(ass_c_id.Text,@"^\d*$").Success)
			{
				MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}
			query2+="c_id="+ass_c_id.Text;

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
		OleDbCommand cmd=MyConnection.CreateCommand();
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

	

	private void get_course_Click(object sender, System.EventArgs e)
	{
		try
		{
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText="SELECT coarse.name,coarse.duration,coarse.total,coarse.grade FROM coarse,bridge,student WHERE bridge.key=31 AND coarse.c_id=bridge.c_id ";
			MessageBox.Show(cmd.CommandText);
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataSet dataset=new DataSet();
			adapter.Fill(dataset,"grades");
			dataGrid2.DataSource=dataset.Tables[0];
		}
		catch(System.Data.OleDb.OleDbException m)
		{
			MessageBox.Show(m.Errors[0].ToString());
		}
		
	
	}

	private void dataGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		DataSet dataset=new DataSet();
		OleDbCommand cmd=MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM student ORDER BY id ASC";
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
		tabControl1.SelectedIndex=5;
		DataSet dataset=new DataSet();
		OleDbCommand cmd=MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM student Where id="+st_id;
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
		ass_st_dob.Text=dataset.Tables[0].Rows[0][3].ToString();
	
	}

	private void update_st_Click(object sender, System.EventArgs e)
	{
		tabControl1.SelectedIndex=1;
		DataSet dataset=new DataSet();
		OleDbCommand cmd=MyConnection.CreateCommand();
		cmd.CommandText="SELECT * FROM student Where id="+st_id;
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
		up_dob1.Text=dataset.Tables[0].Rows[0][3].ToString();
	
	
	}

	private void del_st_Click(object sender, System.EventArgs e)
	{
		
		DialogResult result=MessageBox.Show("Are you sure you want to delete that Student","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
		if (result==DialogResult.Yes)
		{
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText="DELETE FROM student WHERE id="+st_id;
			int r=cmd.ExecuteNonQuery();
			if(r!=0)
			{
				MessageBox.Show("The student was successfully deleted ","Student Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);	
				display_Click(this,new System.EventArgs());
			}
		}
	}
	
}

	
	

	

	
		


