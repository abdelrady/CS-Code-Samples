using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;



	/// <summary>
	/// Summary description for coarse_form.
	/// </summary>
	public class coarse_form : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Form parent;
		private OleDbConnection MyConnection;
		private System.Windows.Forms.Button bt_refresh;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button add_clear;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label first_named;
		private System.Windows.Forms.Label idd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label dur;
		private System.Windows.Forms.TextBox duration;
		private System.Windows.Forms.TextBox c_name;
		private System.Windows.Forms.TextBox c_total;
		private const int ID_ERROR=-2147467259;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cl;
		private System.Windows.Forms.Button next2;
		private System.Windows.Forms.Button prev2;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button get_results;
		private System.Windows.Forms.TextBox up_total1;
		private System.Windows.Forms.TextBox up_duration1;
		private System.Windows.Forms.TextBox up_name1;
		private System.Windows.Forms.TextBox up_id1;
		private System.Windows.Forms.TextBox up_duration2;
		private System.Windows.Forms.TextBox up_name2;
		private System.Windows.Forms.TextBox up_id2;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.TextBox up_total2;
		private System.Windows.Forms.CheckBox ch_duration2;
		private System.Windows.Forms.CheckBox ch_id2;
		private System.Windows.Forms.CheckBox ch_total1;
		private System.Windows.Forms.CheckBox ch_duration1;
		private System.Windows.Forms.CheckBox ch_name1;
		private System.Windows.Forms.CheckBox ch_id1;
		private System.Windows.Forms.CheckBox ch_name2;
		private System.Windows.Forms.CheckBox ch_total2;
		private int size,index;
		private DataSet dataset;
		private int coarse_id;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox ch_del_id;
		private System.Windows.Forms.CheckBox ch_del_name;
		private System.Windows.Forms.TextBox del_id;
		private System.Windows.Forms.TextBox del_name;
		private System.Windows.Forms.Button del;
		private System.Windows.Forms.Button cle;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox ch_s_id;
		private System.Windows.Forms.CheckBox ch_s_name;
		private System.Windows.Forms.CheckBox ch_s_duration;
		private System.Windows.Forms.CheckBox ch_s_total;
		private System.Windows.Forms.TextBox s_id;
		private System.Windows.Forms.TextBox s_name;
		private System.Windows.Forms.TextBox s_duration;
		private System.Windows.Forms.TextBox s_total;
		private System.Windows.Forms.Button b_Cl;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem update_coarse;
		private System.Windows.Forms.MenuItem del_coarse;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public coarse_form(System.Windows.Forms.Form p)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			parent=p;
			connect();
			dataset=new DataSet();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.bt_refresh = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.c_total = new System.Windows.Forms.TextBox();
			this.add_clear = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dur = new System.Windows.Forms.Label();
			this.first_named = new System.Windows.Forms.Label();
			this.idd = new System.Windows.Forms.Label();
			this.duration = new System.Windows.Forms.TextBox();
			this.c_name = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.result = new System.Windows.Forms.Label();
			this.cl = new System.Windows.Forms.Button();
			this.next2 = new System.Windows.Forms.Button();
			this.prev2 = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.get_results = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.up_total2 = new System.Windows.Forms.TextBox();
			this.up_duration2 = new System.Windows.Forms.TextBox();
			this.up_name2 = new System.Windows.Forms.TextBox();
			this.up_id2 = new System.Windows.Forms.TextBox();
			this.ch_duration2 = new System.Windows.Forms.CheckBox();
			this.ch_id2 = new System.Windows.Forms.CheckBox();
			this.ch_total1 = new System.Windows.Forms.CheckBox();
			this.ch_duration1 = new System.Windows.Forms.CheckBox();
			this.ch_name1 = new System.Windows.Forms.CheckBox();
			this.ch_id1 = new System.Windows.Forms.CheckBox();
			this.up_total1 = new System.Windows.Forms.TextBox();
			this.up_duration1 = new System.Windows.Forms.TextBox();
			this.up_name1 = new System.Windows.Forms.TextBox();
			this.up_id1 = new System.Windows.Forms.TextBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.ch_name2 = new System.Windows.Forms.CheckBox();
			this.ch_total2 = new System.Windows.Forms.CheckBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.del = new System.Windows.Forms.Button();
			this.cle = new System.Windows.Forms.Button();
			this.del_name = new System.Windows.Forms.TextBox();
			this.del_id = new System.Windows.Forms.TextBox();
			this.ch_del_name = new System.Windows.Forms.CheckBox();
			this.ch_del_id = new System.Windows.Forms.CheckBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.search = new System.Windows.Forms.Button();
			this.b_Cl = new System.Windows.Forms.Button();
			this.s_total = new System.Windows.Forms.TextBox();
			this.s_duration = new System.Windows.Forms.TextBox();
			this.s_name = new System.Windows.Forms.TextBox();
			this.s_id = new System.Windows.Forms.TextBox();
			this.ch_s_total = new System.Windows.Forms.CheckBox();
			this.ch_s_duration = new System.Windows.Forms.CheckBox();
			this.ch_s_name = new System.Windows.Forms.CheckBox();
			this.ch_s_id = new System.Windows.Forms.CheckBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.update_coarse = new System.Windows.Forms.MenuItem();
			this.del_coarse = new System.Windows.Forms.MenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(568, 424);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGrid1);
			this.tabPage1.Controls.Add(this.bt_refresh);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(560, 398);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Display Coarses";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "Coarses";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(104, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(344, 296);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
			// 
			// bt_refresh
			// 
			this.bt_refresh.Location = new System.Drawing.Point(216, 336);
			this.bt_refresh.Name = "bt_refresh";
			this.bt_refresh.Size = new System.Drawing.Size(112, 32);
			this.bt_refresh.TabIndex = 0;
			this.bt_refresh.Text = "Refresh";
			this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(560, 398);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Add Coarse";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.Location = new System.Drawing.Point(32, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Please Enter the data of the student\'s you want to add";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.c_total);
			this.groupBox1.Controls.Add(this.add_clear);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.id);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dur);
			this.groupBox1.Controls.Add(this.first_named);
			this.groupBox1.Controls.Add(this.idd);
			this.groupBox1.Controls.Add(this.duration);
			this.groupBox1.Controls.Add(this.c_name);
			this.groupBox1.Location = new System.Drawing.Point(24, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 328);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Coarse Data";
			// 
			// c_total
			// 
			this.c_total.Location = new System.Drawing.Point(144, 184);
			this.c_total.Name = "c_total";
			this.c_total.Size = new System.Drawing.Size(224, 20);
			this.c_total.TabIndex = 7;
			this.c_total.Text = "";
			this.c_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// add_clear
			// 
			this.add_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.add_clear.Location = new System.Drawing.Point(392, 112);
			this.add_clear.Name = "add_clear";
			this.add_clear.Size = new System.Drawing.Size(80, 32);
			this.add_clear.TabIndex = 9;
			this.add_clear.Text = "Clear";
			this.add_clear.Click += new System.EventHandler(this.add_clear_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(184, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add Coarse";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(144, 40);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(224, 20);
			this.id.TabIndex = 4;
			this.id.Text = "";
			this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 32);
			this.label5.TabIndex = 3;
			this.label5.Text = "Total ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dur
			// 
			this.dur.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dur.Location = new System.Drawing.Point(16, 128);
			this.dur.Name = "dur";
			this.dur.Size = new System.Drawing.Size(128, 32);
			this.dur.TabIndex = 2;
			this.dur.Text = "Duration (hours)";
			this.dur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// first_named
			// 
			this.first_named.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.first_named.Location = new System.Drawing.Point(16, 82);
			this.first_named.Name = "first_named";
			this.first_named.Size = new System.Drawing.Size(128, 32);
			this.first_named.TabIndex = 1;
			this.first_named.Text = "Name ";
			this.first_named.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// idd
			// 
			this.idd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.idd.Location = new System.Drawing.Point(16, 32);
			this.idd.Name = "idd";
			this.idd.Size = new System.Drawing.Size(128, 32);
			this.idd.TabIndex = 0;
			this.idd.Text = "Coarse ID ";
			this.idd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// duration
			// 
			this.duration.Location = new System.Drawing.Point(144, 136);
			this.duration.Name = "duration";
			this.duration.Size = new System.Drawing.Size(224, 20);
			this.duration.TabIndex = 6;
			this.duration.Text = "";
			this.duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// c_name
			// 
			this.c_name.Location = new System.Drawing.Point(144, 88);
			this.c_name.Name = "c_name";
			this.c_name.Size = new System.Drawing.Size(224, 20);
			this.c_name.TabIndex = 5;
			this.c_name.Text = "";
			this.c_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.result);
			this.tabPage3.Controls.Add(this.cl);
			this.tabPage3.Controls.Add(this.next2);
			this.tabPage3.Controls.Add(this.prev2);
			this.tabPage3.Controls.Add(this.update);
			this.tabPage3.Controls.Add(this.get_results);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.up_total2);
			this.tabPage3.Controls.Add(this.up_duration2);
			this.tabPage3.Controls.Add(this.up_name2);
			this.tabPage3.Controls.Add(this.up_id2);
			this.tabPage3.Controls.Add(this.ch_duration2);
			this.tabPage3.Controls.Add(this.ch_id2);
			this.tabPage3.Controls.Add(this.ch_total1);
			this.tabPage3.Controls.Add(this.ch_duration1);
			this.tabPage3.Controls.Add(this.ch_name1);
			this.tabPage3.Controls.Add(this.ch_id1);
			this.tabPage3.Controls.Add(this.up_total1);
			this.tabPage3.Controls.Add(this.up_duration1);
			this.tabPage3.Controls.Add(this.up_name1);
			this.tabPage3.Controls.Add(this.up_id1);
			this.tabPage3.Controls.Add(this.checkBox9);
			this.tabPage3.Controls.Add(this.ch_name2);
			this.tabPage3.Controls.Add(this.ch_total2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(560, 398);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Update";
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.result.ForeColor = System.Drawing.Color.Firebrick;
			this.result.Location = new System.Drawing.Point(200, 232);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(144, 24);
			this.result.TabIndex = 29;
			this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cl
			// 
			this.cl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cl.Location = new System.Drawing.Point(24, 328);
			this.cl.Name = "cl";
			this.cl.Size = new System.Drawing.Size(112, 40);
			this.cl.TabIndex = 28;
			this.cl.Text = "Clear";
			this.cl.Click += new System.EventHandler(this.cl_Click);
			// 
			// next2
			// 
			this.next2.Enabled = false;
			this.next2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.next2.Location = new System.Drawing.Point(392, 264);
			this.next2.Name = "next2";
			this.next2.Size = new System.Drawing.Size(128, 40);
			this.next2.TabIndex = 27;
			this.next2.Text = "next >>";
			this.next2.Click += new System.EventHandler(this.next2_Click);
			// 
			// prev2
			// 
			this.prev2.Enabled = false;
			this.prev2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.prev2.Location = new System.Drawing.Point(16, 264);
			this.prev2.Name = "prev2";
			this.prev2.Size = new System.Drawing.Size(128, 40);
			this.prev2.TabIndex = 26;
			this.prev2.Text = "<< prev";
			this.prev2.Click += new System.EventHandler(this.prev2_Click);
			// 
			// update
			// 
			this.update.Enabled = false;
			this.update.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.update.Location = new System.Drawing.Point(400, 328);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(112, 40);
			this.update.TabIndex = 25;
			this.update.Text = "Update";
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// get_results
			// 
			this.get_results.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.get_results.Location = new System.Drawing.Point(208, 264);
			this.get_results.Name = "get_results";
			this.get_results.Size = new System.Drawing.Size(128, 40);
			this.get_results.TabIndex = 24;
			this.get_results.Text = "Get Results";
			this.get_results.Click += new System.EventHandler(this.get_results_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Firebrick;
			this.label3.Location = new System.Drawing.Point(368, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 32);
			this.label3.TabIndex = 21;
			this.label3.Text = "New Value";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Firebrick;
			this.label2.Location = new System.Drawing.Point(152, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 32);
			this.label2.TabIndex = 20;
			this.label2.Text = "Old Value";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// up_total2
			// 
			this.up_total2.Enabled = false;
			this.up_total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_total2.Location = new System.Drawing.Point(352, 200);
			this.up_total2.Name = "up_total2";
			this.up_total2.Size = new System.Drawing.Size(168, 22);
			this.up_total2.TabIndex = 19;
			this.up_total2.Text = "";
			this.up_total2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_duration2
			// 
			this.up_duration2.Enabled = false;
			this.up_duration2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_duration2.Location = new System.Drawing.Point(352, 152);
			this.up_duration2.Name = "up_duration2";
			this.up_duration2.Size = new System.Drawing.Size(168, 22);
			this.up_duration2.TabIndex = 18;
			this.up_duration2.Text = "";
			this.up_duration2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_name2
			// 
			this.up_name2.Enabled = false;
			this.up_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_name2.Location = new System.Drawing.Point(352, 112);
			this.up_name2.Name = "up_name2";
			this.up_name2.Size = new System.Drawing.Size(168, 22);
			this.up_name2.TabIndex = 17;
			this.up_name2.Text = "";
			this.up_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_id2
			// 
			this.up_id2.Enabled = false;
			this.up_id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_id2.Location = new System.Drawing.Point(352, 64);
			this.up_id2.Name = "up_id2";
			this.up_id2.Size = new System.Drawing.Size(168, 22);
			this.up_id2.TabIndex = 16;
			this.up_id2.Text = "";
			this.up_id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ch_duration2
			// 
			this.ch_duration2.Enabled = false;
			this.ch_duration2.Location = new System.Drawing.Point(320, 152);
			this.ch_duration2.Name = "ch_duration2";
			this.ch_duration2.Size = new System.Drawing.Size(32, 24);
			this.ch_duration2.TabIndex = 14;
			this.ch_duration2.CheckedChanged += new System.EventHandler(this.ch_duration2_CheckedChanged);
			// 
			// ch_id2
			// 
			this.ch_id2.Enabled = false;
			this.ch_id2.Location = new System.Drawing.Point(320, 64);
			this.ch_id2.Name = "ch_id2";
			this.ch_id2.Size = new System.Drawing.Size(32, 16);
			this.ch_id2.TabIndex = 12;
			this.ch_id2.CheckedChanged += new System.EventHandler(this.ch_id2_CheckedChanged);
			// 
			// ch_total1
			// 
			this.ch_total1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_total1.Location = new System.Drawing.Point(8, 200);
			this.ch_total1.Name = "ch_total1";
			this.ch_total1.Size = new System.Drawing.Size(128, 24);
			this.ch_total1.TabIndex = 11;
			this.ch_total1.Text = "Total";
			this.ch_total1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_total1.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// ch_duration1
			// 
			this.ch_duration1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.ch_duration1.Location = new System.Drawing.Point(8, 152);
			this.ch_duration1.Name = "ch_duration1";
			this.ch_duration1.Size = new System.Drawing.Size(128, 24);
			this.ch_duration1.TabIndex = 10;
			this.ch_duration1.Text = "Duration";
			this.ch_duration1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_duration1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// ch_name1
			// 
			this.ch_name1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.ch_name1.Location = new System.Drawing.Point(8, 112);
			this.ch_name1.Name = "ch_name1";
			this.ch_name1.Size = new System.Drawing.Size(128, 24);
			this.ch_name1.TabIndex = 9;
			this.ch_name1.Text = "Name";
			this.ch_name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_name1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// ch_id1
			// 
			this.ch_id1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.ch_id1.Location = new System.Drawing.Point(8, 64);
			this.ch_id1.Name = "ch_id1";
			this.ch_id1.Size = new System.Drawing.Size(128, 24);
			this.ch_id1.TabIndex = 8;
			this.ch_id1.Text = "Coarse ID";
			this.ch_id1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_id1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// up_total1
			// 
			this.up_total1.Enabled = false;
			this.up_total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_total1.Location = new System.Drawing.Point(136, 200);
			this.up_total1.Name = "up_total1";
			this.up_total1.Size = new System.Drawing.Size(168, 22);
			this.up_total1.TabIndex = 3;
			this.up_total1.Text = "";
			this.up_total1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_duration1
			// 
			this.up_duration1.Enabled = false;
			this.up_duration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_duration1.Location = new System.Drawing.Point(136, 152);
			this.up_duration1.Name = "up_duration1";
			this.up_duration1.Size = new System.Drawing.Size(168, 22);
			this.up_duration1.TabIndex = 2;
			this.up_duration1.Text = "";
			this.up_duration1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_name1
			// 
			this.up_name1.Enabled = false;
			this.up_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_name1.Location = new System.Drawing.Point(136, 112);
			this.up_name1.Name = "up_name1";
			this.up_name1.Size = new System.Drawing.Size(168, 22);
			this.up_name1.TabIndex = 1;
			this.up_name1.Text = "";
			this.up_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// up_id1
			// 
			this.up_id1.Enabled = false;
			this.up_id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.up_id1.Location = new System.Drawing.Point(136, 64);
			this.up_id1.Name = "up_id1";
			this.up_id1.Size = new System.Drawing.Size(168, 22);
			this.up_id1.TabIndex = 0;
			this.up_id1.Text = "";
			this.up_id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// checkBox9
			// 
			this.checkBox9.Enabled = false;
			this.checkBox9.Location = new System.Drawing.Point(336, 152);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(32, 24);
			this.checkBox9.TabIndex = 14;
			// 
			// ch_name2
			// 
			this.ch_name2.Enabled = false;
			this.ch_name2.Location = new System.Drawing.Point(320, 112);
			this.ch_name2.Name = "ch_name2";
			this.ch_name2.Size = new System.Drawing.Size(32, 24);
			this.ch_name2.TabIndex = 13;
			this.ch_name2.CheckedChanged += new System.EventHandler(this.ch_name2_CheckedChanged);
			// 
			// ch_total2
			// 
			this.ch_total2.Enabled = false;
			this.ch_total2.Location = new System.Drawing.Point(320, 200);
			this.ch_total2.Name = "ch_total2";
			this.ch_total2.Size = new System.Drawing.Size(32, 24);
			this.ch_total2.TabIndex = 15;
			this.ch_total2.CheckedChanged += new System.EventHandler(this.ch_total2_CheckedChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(560, 398);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Delete";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.del);
			this.groupBox2.Controls.Add(this.cle);
			this.groupBox2.Controls.Add(this.del_name);
			this.groupBox2.Controls.Add(this.del_id);
			this.groupBox2.Controls.Add(this.ch_del_name);
			this.groupBox2.Controls.Add(this.ch_del_id);
			this.groupBox2.Location = new System.Drawing.Point(16, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(528, 248);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Delete Criterea";
			// 
			// del
			// 
			this.del.Location = new System.Drawing.Point(144, 160);
			this.del.Name = "del";
			this.del.Size = new System.Drawing.Size(248, 40);
			this.del.TabIndex = 5;
			this.del.Text = "Delete";
			this.del.Click += new System.EventHandler(this.del_Click);
			// 
			// cle
			// 
			this.cle.Location = new System.Drawing.Point(408, 72);
			this.cle.Name = "cle";
			this.cle.Size = new System.Drawing.Size(88, 40);
			this.cle.TabIndex = 4;
			this.cle.Text = "Clear";
			this.cle.Click += new System.EventHandler(this.add_clear_Click);
			// 
			// del_name
			// 
			this.del_name.Enabled = false;
			this.del_name.Location = new System.Drawing.Point(152, 104);
			this.del_name.Name = "del_name";
			this.del_name.Size = new System.Drawing.Size(192, 20);
			this.del_name.TabIndex = 3;
			this.del_name.Text = "";
			this.del_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// del_id
			// 
			this.del_id.Enabled = false;
			this.del_id.Location = new System.Drawing.Point(152, 56);
			this.del_id.Name = "del_id";
			this.del_id.Size = new System.Drawing.Size(192, 20);
			this.del_id.TabIndex = 2;
			this.del_id.Text = "";
			this.del_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ch_del_name
			// 
			this.ch_del_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_del_name.Location = new System.Drawing.Point(40, 96);
			this.ch_del_name.Name = "ch_del_name";
			this.ch_del_name.Size = new System.Drawing.Size(112, 32);
			this.ch_del_name.TabIndex = 1;
			this.ch_del_name.Text = "Name";
			this.ch_del_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_del_name.CheckedChanged += new System.EventHandler(this.ch_del_name_CheckedChanged);
			// 
			// ch_del_id
			// 
			this.ch_del_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_del_id.Location = new System.Drawing.Point(40, 48);
			this.ch_del_id.Name = "ch_del_id";
			this.ch_del_id.Size = new System.Drawing.Size(112, 32);
			this.ch_del_id.TabIndex = 0;
			this.ch_del_id.Text = "Coarse ID";
			this.ch_del_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_del_id.CheckedChanged += new System.EventHandler(this.ch_del_id_CheckedChanged);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.dataGrid2);
			this.tabPage5.Controls.Add(this.groupBox3);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(560, 398);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Search";
			// 
			// dataGrid2
			// 
			this.dataGrid2.CaptionText = "Results";
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(104, 224);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(344, 152);
			this.dataGrid2.TabIndex = 1;
			this.dataGrid2.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.search);
			this.groupBox3.Controls.Add(this.b_Cl);
			this.groupBox3.Controls.Add(this.s_total);
			this.groupBox3.Controls.Add(this.s_duration);
			this.groupBox3.Controls.Add(this.s_name);
			this.groupBox3.Controls.Add(this.s_id);
			this.groupBox3.Controls.Add(this.ch_s_total);
			this.groupBox3.Controls.Add(this.ch_s_duration);
			this.groupBox3.Controls.Add(this.ch_s_name);
			this.groupBox3.Controls.Add(this.ch_s_id);
			this.groupBox3.Location = new System.Drawing.Point(16, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(528, 184);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Search Criterea";
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(400, 120);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(96, 40);
			this.search.TabIndex = 9;
			this.search.Text = "Search";
			this.search.Click += new System.EventHandler(this.search_Click);
			// 
			// b_Cl
			// 
			this.b_Cl.Location = new System.Drawing.Point(400, 32);
			this.b_Cl.Name = "b_Cl";
			this.b_Cl.Size = new System.Drawing.Size(96, 40);
			this.b_Cl.TabIndex = 8;
			this.b_Cl.Text = "Clear";
			this.b_Cl.Click += new System.EventHandler(this.add_clear_Click);
			// 
			// s_total
			// 
			this.s_total.Enabled = false;
			this.s_total.Location = new System.Drawing.Point(152, 144);
			this.s_total.Name = "s_total";
			this.s_total.Size = new System.Drawing.Size(184, 20);
			this.s_total.TabIndex = 7;
			this.s_total.Text = "";
			this.s_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// s_duration
			// 
			this.s_duration.Enabled = false;
			this.s_duration.Location = new System.Drawing.Point(152, 104);
			this.s_duration.Name = "s_duration";
			this.s_duration.Size = new System.Drawing.Size(184, 20);
			this.s_duration.TabIndex = 6;
			this.s_duration.Text = "";
			this.s_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// s_name
			// 
			this.s_name.Enabled = false;
			this.s_name.Location = new System.Drawing.Point(152, 64);
			this.s_name.Name = "s_name";
			this.s_name.Size = new System.Drawing.Size(184, 20);
			this.s_name.TabIndex = 5;
			this.s_name.Text = "";
			this.s_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// s_id
			// 
			this.s_id.Enabled = false;
			this.s_id.Location = new System.Drawing.Point(152, 24);
			this.s_id.Name = "s_id";
			this.s_id.Size = new System.Drawing.Size(184, 20);
			this.s_id.TabIndex = 4;
			this.s_id.Text = "";
			this.s_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ch_s_total
			// 
			this.ch_s_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_s_total.Location = new System.Drawing.Point(32, 144);
			this.ch_s_total.Name = "ch_s_total";
			this.ch_s_total.Size = new System.Drawing.Size(112, 24);
			this.ch_s_total.TabIndex = 3;
			this.ch_s_total.Text = "Total";
			this.ch_s_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_s_total.CheckedChanged += new System.EventHandler(this.ch_s_total_CheckedChanged);
			// 
			// ch_s_duration
			// 
			this.ch_s_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_s_duration.Location = new System.Drawing.Point(32, 104);
			this.ch_s_duration.Name = "ch_s_duration";
			this.ch_s_duration.Size = new System.Drawing.Size(112, 24);
			this.ch_s_duration.TabIndex = 2;
			this.ch_s_duration.Text = "Duration";
			this.ch_s_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_s_duration.CheckedChanged += new System.EventHandler(this.ch_s_duration_CheckedChanged);
			// 
			// ch_s_name
			// 
			this.ch_s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_s_name.Location = new System.Drawing.Point(32, 64);
			this.ch_s_name.Name = "ch_s_name";
			this.ch_s_name.Size = new System.Drawing.Size(112, 24);
			this.ch_s_name.TabIndex = 1;
			this.ch_s_name.Text = "Name";
			this.ch_s_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_s_name.CheckedChanged += new System.EventHandler(this.ch_s_name_CheckedChanged);
			// 
			// ch_s_id
			// 
			this.ch_s_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ch_s_id.Location = new System.Drawing.Point(32, 24);
			this.ch_s_id.Name = "ch_s_id";
			this.ch_s_id.Size = new System.Drawing.Size(112, 24);
			this.ch_s_id.TabIndex = 0;
			this.ch_s_id.Text = "Coarse ID";
			this.ch_s_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ch_s_id.CheckedChanged += new System.EventHandler(this.ch_s_id_CheckedChanged);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.update_coarse,
																						 this.del_coarse});
			// 
			// update_coarse
			// 
			this.update_coarse.Index = 0;
			this.update_coarse.Text = "Update Coarse";
			this.update_coarse.Click += new System.EventHandler(this.update_coarse_Click);
			// 
			// del_coarse
			// 
			this.del_coarse.Index = 1;
			this.del_coarse.Text = "Delete Coarse";
			this.del_coarse.Click += new System.EventHandler(this.del_coarse_Click);
			// 
			// coarse_form
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 462);
			this.Controls.Add(this.tabControl1);
			this.Name = "coarse_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "coarse_form";
			this.Closed += new System.EventHandler(this.coarse_form_Closed);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void coarse_form_Closed(object sender, System.EventArgs e)
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

		private void bt_refresh_Click(object sender, System.EventArgs e)
		{
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText="SELECT * FROM coarse ORDER BY c_id ASC";
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataSet dataset=new DataSet();
			adapter.Fill(dataset,"coarse");
			dataGrid1.DataSource=dataset.Tables[0];
			

		}

		private void clear_text()
		{
			id.Text="";
			c_name.Text="";
			duration.Text="";
			c_total.Text="";

			up_id1.Text="";
			up_name1.Text="";
			up_duration1.Text="";
			up_total1.Text="";

			up_id2.Text="";
			up_name2.Text="";
			up_duration2.Text="";
			up_total2.Text="";

			ch_id1.Checked=false;
			ch_name1.Checked=false;
			ch_duration1.Checked=false;
			ch_total1.Checked=false;

			ch_id2.Checked=false;
			ch_name2.Checked=false;
			ch_duration2.Checked=false;
			ch_total2.Checked=false;

			next2.Enabled=false;
			prev2.Enabled=false;
			update.Enabled=false;

			del_id.Text="";
			del_name.Text="";
			ch_del_id.Checked=false;
			ch_del_name.Checked=false;

			s_id.Text="";
			s_name.Text="";
			s_duration.Text="";
			s_total.Text="";

			ch_s_id.Checked=false;
			ch_s_name.Checked=false;
			ch_s_duration.Checked=false;
			ch_s_total.Checked=false;
			dataGrid2.Visible=false;

		}
		private void add_clear_Click(object sender, System.EventArgs e)
		{	
			clear_text();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				OleDbCommand cmd=MyConnection.CreateCommand();
				string query="INSERT INTO coarse (c_id,name,duration,total) VALUES(";
				query+=id.Text+",'"+c_name.Text+"',"+duration.Text+","+c_total.Text+")";
	
				//MessageBox.Show(query);
				if(id.Text=="" || !Regex.Match(id.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(c_name.Text=="")
				{
					MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(duration.Text=="" || !Regex.Match(duration.Text,@"^\d*$").Success)
				{	
					MessageBox.Show("Please Enter an integer value in the duration field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(c_total.Text=="" || !Regex.Match(c_total.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the total field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}	
	
				cmd.CommandText=query;
				cmd.ExecuteNonQuery();
				MessageBox.Show("Coarse was added successfully to the database","Student added",MessageBoxButtons.OK,MessageBoxIcon.Information);
				clear_text();
			}
			catch(System.Data.OleDb.OleDbException m)
			{	
				
				if(m.ErrorCode==ID_ERROR)
					MessageBox.Show("Can't add Coarse, a coarse with the same ID already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}
			
	}

		private void tabPage1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_id1.Enabled)
				up_id1.Enabled=false;
			else
				up_id1.Enabled=true;

		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_name1.Enabled)
				up_name1.Enabled=false;
			else
				up_name1.Enabled=true;
		
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_duration1.Enabled)
				up_duration1.Enabled=false;
			else
				up_duration1.Enabled=true;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_total1.Enabled)
				up_total1.Enabled=false;
			else
				up_total1.Enabled=true;
		
		}

		private void cl_Click(object sender, System.EventArgs e)
		{
			clear_text();
		}

		private void get_results_Click(object sender, System.EventArgs e)
		{
			string query1="SELECT * FROM coarse WHERE ";
			string query2="";
			if(up_id1.Enabled)
			{
				if(up_id1.Text==""||!Regex.Match(up_id1.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				query2+="c_id="+up_id1.Text;

			}
			if(up_name1.Enabled)
			{
				if(up_name1.Text=="")
				{
					MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(up_id1.Enabled)
					query2+=" AND";
				query2+=" name='"+up_name1.Text+"'";
			}
			if(up_duration1.Enabled)
			{
				if(up_duration1.Text==""||!Regex.Match(up_duration1.Text,@"^\d*$").Success)
				{	
					MessageBox.Show("Please Enter an integer value in the duration field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(up_id1.Enabled||up_name1.Enabled)
					query2+=" AND";
				query2+=" duration="+up_duration1.Text;


			}
			///
			if(up_total1.Enabled)
			{
				if(up_total1.Text==""||!Regex.Match(up_total1.Text,@"^\d*$").Success)
				{	
					MessageBox.Show("Please Enter an integer value in the total field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(up_id1.Enabled||up_name1.Enabled||up_duration1.Enabled)
					query2+=" AND";
				query2+=" total="+up_total1.Text;


			}

			if(query2=="")
			{
				MessageBox.Show("Please enter any details for the coarse you want to search for","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			OleDbCommand cmd=MyConnection.CreateCommand();
			dataset.Reset();
			size=0;
			index=0;
			cmd.CommandText=query1+query2;
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			size=adapter.Fill(dataset,"coarse");
			if(size==0)
				MessageBox.Show("NO results");
			else
			{
				MessageBox.Show(size.ToString()+" results where found","Results",MessageBoxButtons.OK,MessageBoxIcon.Information);
				result.Text="Result "+(index+1)+"/"+size;
				display_results(index);
				next2.Enabled=true;
				ch_id2.Enabled=true;
				ch_name2.Enabled=true;
				ch_duration2.Enabled=true;
				ch_total2.Enabled=true;

				update.Enabled=true;
			}
			
			
		}
	
		private void display_results(int ind)
		{
			DataTable t=dataset.Tables[0];
			DataRow r=t.Rows[ind];
			up_id1.Text=r[0].ToString();
			up_name1.Text=r[1].ToString();
			up_duration1.Text=r[2].ToString();
			up_total1.Text=r[3].ToString();
			
		}

		private void next2_Click(object sender, System.EventArgs e)
		{
			prev2.Enabled=true;
			index++;	
			
			if(index<size)
			{	
				display_results(index);
				
			}
			else 
			{
				MessageBox.Show("No More Results");
				index--;
				next2.Enabled=false;

			}
				
		}

		private void prev2_Click(object sender, System.EventArgs e)
		{
			index--;
			next2.Enabled=true;
			if(index>=0)
			{
				display_results(index);	
			}
			else
			{
				MessageBox.Show("No More Results");
				index++;
				prev2.Enabled=false;
			}
		}

		private void update_Click(object sender, System.EventArgs e)
		{
			try
			{
				OleDbCommand cmd =MyConnection.CreateCommand();
				string query="Update coarse SET";
				string query2="";
				if(up_id2.Enabled)
				{
					if(up_id2.Text==""||!Regex.Match(up_id2.Text,@"^\d*$").Success)
					{
						MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}
					query2+=" c_id="+up_id2.Text;
					
				}
				if(up_name2.Enabled)
				{
					if(up_name2.Text=="")
					{
						MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}
					if(up_id2.Enabled)
						query2+=",";
					query2+=" name='"+up_name2.Text+"'";
				}
				if(up_duration2.Enabled)
				{
					if(up_duration2.Text==""||!Regex.Match(up_duration2.Text,@"^\d*$").Success)
					{
						MessageBox.Show("Please Enter an integer value int the duration field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}
					if(up_id2.Enabled||up_name2.Enabled)
						query2+=",";
					query2+=" duration="+up_duration2.Text;
				}
				if(up_total2.Enabled)
				{
					if(up_total2.Text==""||!Regex.Match(up_total2.Text,@"^\d*$").Success)
					{
						MessageBox.Show("Please Enter an integer value in the total field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}
					if(up_id2.Enabled||up_name2.Enabled||up_duration2.Enabled)
						query2+=",";
					query2+=" total="+up_total2.Text;
				}	
			
				if(query2=="")
				{
					MessageBox.Show("Please enter new details for the coarse you want to update ","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				query2+=" WHERE";
			
				query2+=" c_id="+up_id1.Text;
				
				cmd.CommandText=query+query2;
				int r=cmd.ExecuteNonQuery();
				if(r!=0)
					MessageBox.Show("Coarse data was updated successfuly");
			}
			catch(System.Data.OleDb.OleDbException m)
			{
				if(m.ErrorCode==ID_ERROR)
					MessageBox.Show("Can't update coarse, a coarse with the same ID already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 	
					
			}
		
		}

		private void ch_id2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_id2.Enabled)
				up_id2.Enabled=false;
			else
				up_id2.Enabled=true;
		}

		private void ch_name2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_name2.Enabled)
				up_name2.Enabled=false;
			else
				up_name2.Enabled=true;
		}

		private void ch_duration2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_duration2.Enabled)
				up_duration2.Enabled=false;
			else
				up_duration2.Enabled=true;
		}

		private void ch_total2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(up_total2.Enabled)
				up_total2.Enabled=false;
			else
				up_total2.Enabled=true;
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			clear_text();
		}

		private void ch_del_id_CheckedChanged(object sender, System.EventArgs e)
		{
			if(del_id.Enabled)
				del_id.Enabled=false;
			else
				del_id.Enabled=true;
		}

		private void ch_del_name_CheckedChanged(object sender, System.EventArgs e)
		{
			if(del_name.Enabled)
				del_name.Enabled=false;
			else
				del_name.Enabled=true;
		}

		private void del_Click(object sender, System.EventArgs e)
		{
			OleDbCommand cmd=MyConnection.CreateCommand();
			string query="DELETE FROM coarse WHERE ";
			string query2="";
			if(del_id.Enabled)
			{
				if(del_id.Text==""||!Regex.Match(del_id.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				query2+="c_id="+del_id.Text;
				
			}
			if(del_name.Enabled)
			{
				if(del_name.Text=="")
				{
					MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(del_id.Enabled)
					query2+=" AND";
				query2+=" name='"+del_name.Text+"'";
			}
			if(query2=="")
			{
				MessageBox.Show("Please enter details for the coarse you want to delete","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			cmd.CommandText=query+query2;
			
			int result=cmd.ExecuteNonQuery();
			if(result==0)
				MessageBox.Show("Can't delete, Unable to find this coarse","error",MessageBoxButtons.OK,MessageBoxIcon.Error);	
			else 
				MessageBox.Show(""+result+" coarse were deleted ","Coarse Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);	
			clear_text();
		}

		private void ch_s_id_CheckedChanged(object sender, System.EventArgs e)
		{
			if(s_id.Enabled)
				s_id.Enabled=false;
			else
				s_id.Enabled=true;
		}

		private void ch_s_name_CheckedChanged(object sender, System.EventArgs e)
		{
			if(s_name.Enabled)
				s_name.Enabled=false;
			else
				s_name.Enabled=true;
		}

		private void ch_s_duration_CheckedChanged(object sender, System.EventArgs e)
		{
			if(s_duration.Enabled)
				s_duration.Enabled=false;
			else
				s_duration.Enabled=true;
		}

		private void ch_s_total_CheckedChanged(object sender, System.EventArgs e)
		{
			if(s_total.Enabled)
				s_total.Enabled=false;
			else
				s_total.Enabled=true;
		}

		private void search_Click(object sender, System.EventArgs e)
		{
			string query1="SELECT * FROM coarse WHERE ";
			string query2="";
			if(s_id.Enabled)
			{
				if(s_id.Text==""||!Regex.Match(s_id.Text,@"^\d*$").Success)
				{
					MessageBox.Show("Please Enter an integer value in the Id field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				query2+="c_id="+s_id.Text;

			}
			if(s_name.Enabled)
			{
				if(s_name.Text=="")
				{
					MessageBox.Show("Please Enter a value in the name field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(s_id.Enabled)
					query2+=" AND";
				query2+=" name='"+s_name.Text+"'";
			}
			if(s_duration.Enabled)
			{
				if(s_duration.Text==""||!Regex.Match(s_duration.Text,@"^\d*$").Success)
				{	
					MessageBox.Show("Please Enter an integer value in the duration field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(s_id.Enabled||s_name.Enabled)
					query2+=" AND";
				query2+=" duration="+s_duration.Text;


			}
			///
			if(s_total.Enabled)
			{
				if(s_total.Text==""||!Regex.Match(s_total.Text,@"^\d*$").Success)
				{	
					MessageBox.Show("Please Enter an integer value in the total field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return; 
				}
				if(s_id.Enabled||s_name.Enabled||s_duration.Enabled)
					query2+=" AND";
				query2+=" total="+s_total.Text;


			}

			if(query2=="")
			{
				MessageBox.Show("Please enter any details for the coarse you want to search for","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText=query1+query2;
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataSet dataset=new DataSet();
			int result=adapter.Fill(dataset,"coarse");
			if(result==0)
				MessageBox.Show("No result was found","Results",MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				MessageBox.Show(result+" results were found","Results",MessageBoxButtons.OK,MessageBoxIcon.Information);
				dataGrid2.DataSource=dataset.Tables[0];
				dataGrid2.Visible=true;
			}
		}

		private void dataGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			DataSet dataset=new DataSet();
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText="SELECT * FROM coarse ORDER BY c_id ASC";
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			DataRow row;
			DataGrid myGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo hti;
			hti = myGrid.HitTest(e.X, e.Y);
			if(e.Button==MouseButtons.Right)
			{

				switch (hti.Type) 
				{
					case System.Windows.Forms.DataGrid.HitTestType.Cell :
						adapter.Fill(dataset);
						row=dataset.Tables[0].Rows[hti.Row];
						coarse_id=Convert.ToInt32(row[0]);
						contextMenu1.Show(dataGrid1,new Point(e.X,e.Y));
						break;
				
					case System.Windows.Forms.DataGrid.HitTestType.RowHeader :
						adapter.Fill(dataset);
						row=dataset.Tables[0].Rows[hti.Row];
						coarse_id=Convert.ToInt32(row[0]);
						contextMenu1.Show(dataGrid1,new Point(e.X,e.Y));
						break;
				
				}

				//MessageBox.Show(message);
			}


		}

		private void update_coarse_Click(object sender, System.EventArgs e)
		{
			tabControl1.SelectedIndex=2;
			DataSet dataset=new DataSet();
			OleDbCommand cmd=MyConnection.CreateCommand();
			cmd.CommandText="SELECT * FROM coarse Where c_id="+coarse_id;
			OleDbDataAdapter adapter=new OleDbDataAdapter(cmd);
			adapter.Fill(dataset);
			
			ch_id1.Checked=true;
			ch_name1.Checked=true;
			ch_duration1.Checked=true;
			ch_total1.Checked=true;

			up_id1.Text=dataset.Tables[0].Rows[0][0].ToString();
			up_name1.Text=dataset.Tables[0].Rows[0][1].ToString();
			up_duration1.Text=dataset.Tables[0].Rows[0][2].ToString();
			up_total1.Text=dataset.Tables[0].Rows[0][3].ToString();
			ch_id2.Enabled=true;
			ch_name2.Enabled=true;
			ch_duration2.Enabled=true;
			ch_total2.Enabled=true;
			update.Enabled=true;
		}

		private void del_coarse_Click(object sender, System.EventArgs e)
		{
			DialogResult result=MessageBox.Show("Are you sure you want to delete that coarse","Delete Coarse",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				OleDbCommand cmd=MyConnection.CreateCommand();
				cmd.CommandText="DELETE FROM coarse WHERE c_id="+coarse_id;
				int r=cmd.ExecuteNonQuery();
				if(r!=0)
				{
					MessageBox.Show("The coarse was successfully deleted ","Coarse Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);	
					bt_refresh_Click(this,new System.EventArgs());
				}
				
				



			}

		
		}

		

		


		

		
	
	}

		

		
	

