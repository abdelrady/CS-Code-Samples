using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

//using System.Windows.Forms

namespace Hospital
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region connection
		private string constr="provider=Microsoft.JET.OLEDB.4.0;"
			+@"Data Source=Hospital";
		private System.Windows.Forms.TextBox nmMinimum;
		private System.Windows.Forms.ComboBox nmUnit;
		private System.Windows.Forms.TextBox nmMedicinName;
		private System.Windows.Forms.Label vdUnit3;
		private System.Windows.Forms.Label vdUnit2;
		private System.Windows.Forms.Label vdUnit1;
		private System.Windows.Forms.TextBox vdRemaining;
		private System.Windows.Forms.TextBox vdTotal;
		private System.Windows.Forms.ComboBox vdMedicinName;
		private System.Windows.Forms.TextBox rtQuantity;
		private System.Windows.Forms.ComboBox rtMedicinName;
		private System.Windows.Forms.TextBox byBellNumber;
		private System.Windows.Forms.Label byUnit;
		private System.Windows.Forms.TextBox byQuantity;
		private System.Windows.Forms.ComboBox byMedicinName;
		private System.Windows.Forms.TextBox vdUsed;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox byPrice;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox rtPrice;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TabPage recordUsage;
		private System.Windows.Forms.ComboBox usgMedicineName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label usgUnit;
		private System.Windows.Forms.TextBox usgQuantity;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label rtUnit;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label vdUnit4;
		private System.Windows.Forms.TextBox vdByedQuantity;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label vdUnit5;
		private System.Windows.Forms.TextBox vdreturnsQuantity;
		public System.Windows.Forms.Button vdViewMinimums;
		private System.Windows.Forms.TextBox vdMinumMedicinName;
		private System.Windows.Forms.Button vdNext;
		private System.Windows.Forms.Button vdPrev;
		private System.Windows.Forms.Button vdBack;
		private System.Windows.Forms.Button vdOk;
		private System.Windows.Forms.Label vdUnit6;
		private System.Windows.Forms.TextBox vdMinimumLimit;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.Button rtViewData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker vdDate;
		private System.Windows.Forms.Button rtBack;
		private System.Windows.Forms.Button rtPrev;
		private System.Windows.Forms.Button rtNext;
		private System.Windows.Forms.DateTimePicker rtDate;
		private System.Windows.Forms.Button rtOk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button usgOk;
		public System.Windows.Forms.Button byViewData;
		private System.Windows.Forms.Button byBack;
		private System.Windows.Forms.Button byPrev;
		private System.Windows.Forms.Button byNext;
		private System.Windows.Forms.Button byOk;
		private System.Windows.Forms.DateTimePicker byDate;
		private System.Windows.Forms.TextBox rtBellNumber;
		private System.Windows.Forms.Label rtDateLabel;
		private System.Windows.Forms.Label byDateLabel;
		private System.Windows.Forms.Button nmChangeData;
		private System.Windows.Forms.Label nmMedNameLabel;
		private System.Windows.Forms.Button nmChangeOk;
		private System.Windows.Forms.Label nmNewMedicinLabel;
		private System.Windows.Forms.Button nmOk;
		private System.Windows.Forms.ComboBox nmMedicins;
		private System.Windows.Forms.Button nmBack;
		private System.Windows.Forms.TabPage recordReturns;
		private OleDbConnection connection=new OleDbConnection();
		
		private void openConnection()
		{
			if(connection.State==ConnectionState.Open) 
			{
				connection.Close();
				connection.Open();
			}
			else 
				connection.Open();
		}
		private void closeConnection()
		{
			if(connection.State==ConnectionState.Closed) return;
			connection.Close();
		}
		#endregion
		
		public static ArrayList units=new ArrayList();
		OleDbCommand com;
		OleDbDataReader reader;
		private DatabaseManager dbm;
		private int vdMinIndex=0;
		private int byIndex=0;
		private int rtIndex;
		private DataBaseViewer viewer=new DataBaseViewer();
		private ArrayList MinimumsHolder=new ArrayList();
		private ArrayList BuyingsHolder=new ArrayList(),
			RetuensHolder=new ArrayList();
			

		#region data definitions
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Viewdat;
		private System.Windows.Forms.TabPage recordBuying;
		private System.Windows.Forms.TabPage AddNewMedicin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.ComponentModel.IContainer components;
		#endregion
		/// <summary>
		/// Required designer variable.
		/// </summary>

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			connection.ConnectionString=constr;
			
			InitializeComponent();
			initializeMedicins();
			dbm=new DatabaseManager(this);
			nmUnit.SelectedIndex=0;
					
		}
		
		
		void initializeMedicins()
		{
			string sqlcom="SELECT * from MEDICINS";
			openConnection();
			OleDbCommand com=new OleDbCommand(sqlcom,connection);
			reader=com.ExecuteReader();
			while(reader.Read())
			{
				string str=reader["MEDICIN_NAME"].ToString();
				units.Add(reader["MEDICIN_UNIT"].ToString());
				byMedicinName.Items.Add(str);
				vdMedicinName.Items.Add(str);
				rtMedicinName.Items.Add(str);
				usgMedicineName.Items.Add(str);
			}
			closeConnection();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null)
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
			this.Viewdat = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.vdDate = new System.Windows.Forms.DateTimePicker();
			this.vdUnit6 = new System.Windows.Forms.Label();
			this.vdMinimumLimit = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.vdBack = new System.Windows.Forms.Button();
			this.vdPrev = new System.Windows.Forms.Button();
			this.vdNext = new System.Windows.Forms.Button();
			this.vdMinumMedicinName = new System.Windows.Forms.TextBox();
			this.vdViewMinimums = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.vdUnit5 = new System.Windows.Forms.Label();
			this.vdreturnsQuantity = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.vdUnit4 = new System.Windows.Forms.Label();
			this.vdByedQuantity = new System.Windows.Forms.TextBox();
			this.vdOk = new System.Windows.Forms.Button();
			this.vdUnit3 = new System.Windows.Forms.Label();
			this.vdUnit2 = new System.Windows.Forms.Label();
			this.vdUnit1 = new System.Windows.Forms.Label();
			this.vdRemaining = new System.Windows.Forms.TextBox();
			this.vdUsed = new System.Windows.Forms.TextBox();
			this.vdTotal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.vdMedicinName = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddNewMedicin = new System.Windows.Forms.TabPage();
			this.nmBack = new System.Windows.Forms.Button();
			this.nmChangeOk = new System.Windows.Forms.Button();
			this.nmNewMedicinLabel = new System.Windows.Forms.Label();
			this.nmMedicins = new System.Windows.Forms.ComboBox();
			this.nmChangeData = new System.Windows.Forms.Button();
			this.nmOk = new System.Windows.Forms.Button();
			this.nmMinimum = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.nmUnit = new System.Windows.Forms.ComboBox();
			this.nmMedicinName = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.nmMedNameLabel = new System.Windows.Forms.Label();
			this.recordUsage = new System.Windows.Forms.TabPage();
			this.usgOk = new System.Windows.Forms.Button();
			this.usgUnit = new System.Windows.Forms.Label();
			this.usgQuantity = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.usgMedicineName = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.recordReturns = new System.Windows.Forms.TabPage();
			this.rtDateLabel = new System.Windows.Forms.Label();
			this.rtDate = new System.Windows.Forms.DateTimePicker();
			this.rtBack = new System.Windows.Forms.Button();
			this.rtPrev = new System.Windows.Forms.Button();
			this.rtNext = new System.Windows.Forms.Button();
			this.rtViewData = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.rtPrice = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.rtBellNumber = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.rtOk = new System.Windows.Forms.Button();
			this.rtUnit = new System.Windows.Forms.Label();
			this.rtQuantity = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.rtMedicinName = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.recordBuying = new System.Windows.Forms.TabPage();
			this.byBack = new System.Windows.Forms.Button();
			this.byPrev = new System.Windows.Forms.Button();
			this.byNext = new System.Windows.Forms.Button();
			this.byViewData = new System.Windows.Forms.Button();
			this.byDate = new System.Windows.Forms.DateTimePicker();
			this.byDateLabel = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.byPrice = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.byBellNumber = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.byOk = new System.Windows.Forms.Button();
			this.byUnit = new System.Windows.Forms.Label();
			this.byQuantity = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.byMedicinName = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.Viewdat.SuspendLayout();
			this.AddNewMedicin.SuspendLayout();
			this.recordUsage.SuspendLayout();
			this.recordReturns.SuspendLayout();
			this.recordBuying.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Viewdat);
			this.tabControl1.Controls.Add(this.recordBuying);
			this.tabControl1.Controls.Add(this.recordReturns);
			this.tabControl1.Controls.Add(this.recordUsage);
			this.tabControl1.Controls.Add(this.AddNewMedicin);
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(325, 384);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.MouseEnter += new System.EventHandler(this.changeColor);
			this.tabControl1.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// Viewdat
			// 
			this.Viewdat.Controls.Add(this.label1);
			this.Viewdat.Controls.Add(this.vdDate);
			this.Viewdat.Controls.Add(this.vdUnit6);
			this.Viewdat.Controls.Add(this.vdMinimumLimit);
			this.Viewdat.Controls.Add(this.label14);
			this.Viewdat.Controls.Add(this.vdBack);
			this.Viewdat.Controls.Add(this.vdPrev);
			this.Viewdat.Controls.Add(this.vdNext);
			this.Viewdat.Controls.Add(this.vdMinumMedicinName);
			this.Viewdat.Controls.Add(this.vdViewMinimums);
			this.Viewdat.Controls.Add(this.label22);
			this.Viewdat.Controls.Add(this.vdUnit5);
			this.Viewdat.Controls.Add(this.vdreturnsQuantity);
			this.Viewdat.Controls.Add(this.label20);
			this.Viewdat.Controls.Add(this.vdUnit4);
			this.Viewdat.Controls.Add(this.vdByedQuantity);
			this.Viewdat.Controls.Add(this.vdOk);
			this.Viewdat.Controls.Add(this.vdUnit3);
			this.Viewdat.Controls.Add(this.vdUnit2);
			this.Viewdat.Controls.Add(this.vdUnit1);
			this.Viewdat.Controls.Add(this.vdRemaining);
			this.Viewdat.Controls.Add(this.vdUsed);
			this.Viewdat.Controls.Add(this.vdTotal);
			this.Viewdat.Controls.Add(this.label7);
			this.Viewdat.Controls.Add(this.label6);
			this.Viewdat.Controls.Add(this.label5);
			this.Viewdat.Controls.Add(this.vdMedicinName);
			this.Viewdat.Controls.Add(this.label2);
			this.Viewdat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.Viewdat.Location = new System.Drawing.Point(4, 23);
			this.Viewdat.Name = "Viewdat";
			this.Viewdat.Size = new System.Drawing.Size(317, 357);
			this.Viewdat.TabIndex = 0;
			this.Viewdat.Text = "ÈíÇäÇÊ íæãíÉ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.Location = new System.Drawing.Point(218, 20);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 72;
			this.label1.Text = "ÇáÊÇÑíÎ";
			// 
			// vdDate
			// 
			this.vdDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdDate.Location = new System.Drawing.Point(66, 20);
			this.vdDate.Name = "vdDate";
			this.vdDate.Size = new System.Drawing.Size(144, 22);
			this.vdDate.TabIndex = 71;
			this.vdDate.ValueChanged += new System.EventHandler(this.vdMedicinChanged);
			// 
			// vdUnit6
			// 
			this.vdUnit6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit6.Location = new System.Drawing.Point(50, 276);
			this.vdUnit6.Name = "vdUnit6";
			this.vdUnit6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit6.Size = new System.Drawing.Size(50, 24);
			this.vdUnit6.TabIndex = 70;
			this.vdUnit6.Text = "ÇáæÍÏÉ";
			// 
			// vdMinimumLimit
			// 
			this.vdMinimumLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdMinimumLimit.Location = new System.Drawing.Point(122, 276);
			this.vdMinimumLimit.Name = "vdMinimumLimit";
			this.vdMinimumLimit.ReadOnly = true;
			this.vdMinimumLimit.Size = new System.Drawing.Size(49, 22);
			this.vdMinimumLimit.TabIndex = 69;
			this.vdMinimumLimit.Text = "";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label14.Location = new System.Drawing.Point(170, 276);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label14.Size = new System.Drawing.Size(134, 24);
			this.label14.TabIndex = 68;
			this.label14.Text = "ÇáÍÏ ÇáÇÏäì ÇáãÓãæÍ Èå";
			// 
			// vdBack
			// 
			this.vdBack.Enabled = false;
			this.vdBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdBack.Location = new System.Drawing.Point(90, 308);
			this.vdBack.Name = "vdBack";
			this.vdBack.Size = new System.Drawing.Size(87, 30);
			this.vdBack.TabIndex = 67;
			this.vdBack.Text = "ÑÌæÚ";
			this.vdBack.Visible = false;
			this.vdBack.Click += new System.EventHandler(this.vdBack_Click);
			this.vdBack.MouseEnter += new System.EventHandler(this.changeColor);
			this.vdBack.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// vdPrev
			// 
			this.vdPrev.Enabled = false;
			this.vdPrev.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdPrev.Location = new System.Drawing.Point(202, 308);
			this.vdPrev.Name = "vdPrev";
			this.vdPrev.Size = new System.Drawing.Size(48, 30);
			this.vdPrev.TabIndex = 66;
			this.vdPrev.Text = ">>>";
			this.vdPrev.Visible = false;
			this.vdPrev.Click += new System.EventHandler(this.vdPrev_Click);
			this.vdPrev.MouseEnter += new System.EventHandler(this.changeColor);
			this.vdPrev.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// vdNext
			// 
			this.vdNext.Enabled = false;
			this.vdNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdNext.Location = new System.Drawing.Point(26, 308);
			this.vdNext.Name = "vdNext";
			this.vdNext.Size = new System.Drawing.Size(48, 30);
			this.vdNext.TabIndex = 65;
			this.vdNext.Text = "<<<";
			this.vdNext.Visible = false;
			this.vdNext.Click += new System.EventHandler(this.vdNext_Click);
			this.vdNext.MouseEnter += new System.EventHandler(this.changeColor);
			this.vdNext.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// vdMinumMedicinName
			// 
			this.vdMinumMedicinName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdMinumMedicinName.Location = new System.Drawing.Point(66, 60);
			this.vdMinumMedicinName.Name = "vdMinumMedicinName";
			this.vdMinumMedicinName.ReadOnly = true;
			this.vdMinumMedicinName.Size = new System.Drawing.Size(152, 22);
			this.vdMinumMedicinName.TabIndex = 64;
			this.vdMinumMedicinName.Text = "";
			this.vdMinumMedicinName.Visible = false;
			// 
			// vdViewMinimums
			// 
			this.vdViewMinimums.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdViewMinimums.Location = new System.Drawing.Point(8, 308);
			this.vdViewMinimums.Name = "vdViewMinimums";
			this.vdViewMinimums.Size = new System.Drawing.Size(104, 24);
			this.vdViewMinimums.TabIndex = 63;
			this.vdViewMinimums.Text = "ÇÏæíÉ Ç áÍÏ ÇáÃÏäì";
			this.vdViewMinimums.Click += new System.EventHandler(this.vdViewMinimums_Click);
			this.vdViewMinimums.MouseEnter += new System.EventHandler(this.changeColor);
			this.vdViewMinimums.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label22.Location = new System.Drawing.Point(178, 204);
			this.label22.Name = "label22";
			this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label22.Size = new System.Drawing.Size(88, 24);
			this.label22.TabIndex = 62;
			this.label22.Text = "ßãíÉ ÇáãÑÊÌÚÇÊ";
			// 
			// vdUnit5
			// 
			this.vdUnit5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit5.Location = new System.Drawing.Point(50, 204);
			this.vdUnit5.Name = "vdUnit5";
			this.vdUnit5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit5.Size = new System.Drawing.Size(50, 24);
			this.vdUnit5.TabIndex = 61;
			this.vdUnit5.Text = "ÇáæÍÏÉ";
			// 
			// vdreturnsQuantity
			// 
			this.vdreturnsQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdreturnsQuantity.Location = new System.Drawing.Point(122, 204);
			this.vdreturnsQuantity.Name = "vdreturnsQuantity";
			this.vdreturnsQuantity.ReadOnly = true;
			this.vdreturnsQuantity.Size = new System.Drawing.Size(49, 22);
			this.vdreturnsQuantity.TabIndex = 60;
			this.vdreturnsQuantity.Text = "";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label20.Location = new System.Drawing.Point(186, 164);
			this.label20.Name = "label20";
			this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label20.Size = new System.Drawing.Size(86, 24);
			this.label20.TabIndex = 59;
			this.label20.Text = "ßãíÉÇáãÔÊÑíÇÊ";
			// 
			// vdUnit4
			// 
			this.vdUnit4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit4.Location = new System.Drawing.Point(50, 164);
			this.vdUnit4.Name = "vdUnit4";
			this.vdUnit4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit4.Size = new System.Drawing.Size(50, 24);
			this.vdUnit4.TabIndex = 58;
			this.vdUnit4.Text = "ÇáæÍÏÉ";
			// 
			// vdByedQuantity
			// 
			this.vdByedQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdByedQuantity.Location = new System.Drawing.Point(122, 164);
			this.vdByedQuantity.Name = "vdByedQuantity";
			this.vdByedQuantity.ReadOnly = true;
			this.vdByedQuantity.Size = new System.Drawing.Size(49, 22);
			this.vdByedQuantity.TabIndex = 57;
			this.vdByedQuantity.Text = "";
			// 
			// vdOk
			// 
			this.vdOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdOk.Location = new System.Drawing.Point(130, 308);
			this.vdOk.Name = "vdOk";
			this.vdOk.Size = new System.Drawing.Size(88, 24);
			this.vdOk.TabIndex = 52;
			this.vdOk.Text = "ÚÑÖ ÇáÈíÇäÇÊ";
			this.vdOk.Click += new System.EventHandler(this.vdOkhandler);
			this.vdOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.vdOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// vdUnit3
			// 
			this.vdUnit3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit3.Location = new System.Drawing.Point(50, 244);
			this.vdUnit3.Name = "vdUnit3";
			this.vdUnit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit3.Size = new System.Drawing.Size(50, 24);
			this.vdUnit3.TabIndex = 44;
			this.vdUnit3.Text = "ÇáæÍÏÉ";
			// 
			// vdUnit2
			// 
			this.vdUnit2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit2.Location = new System.Drawing.Point(50, 132);
			this.vdUnit2.Name = "vdUnit2";
			this.vdUnit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit2.Size = new System.Drawing.Size(50, 24);
			this.vdUnit2.TabIndex = 43;
			this.vdUnit2.Text = "ÇáæÍÏÉ";
			// 
			// vdUnit1
			// 
			this.vdUnit1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUnit1.Location = new System.Drawing.Point(50, 100);
			this.vdUnit1.Name = "vdUnit1";
			this.vdUnit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.vdUnit1.Size = new System.Drawing.Size(50, 24);
			this.vdUnit1.TabIndex = 42;
			this.vdUnit1.Text = "ÇáæÍÏÉ";
			// 
			// vdRemaining
			// 
			this.vdRemaining.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdRemaining.Location = new System.Drawing.Point(122, 244);
			this.vdRemaining.Name = "vdRemaining";
			this.vdRemaining.ReadOnly = true;
			this.vdRemaining.Size = new System.Drawing.Size(49, 22);
			this.vdRemaining.TabIndex = 38;
			this.vdRemaining.Text = "";
			// 
			// vdUsed
			// 
			this.vdUsed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdUsed.Location = new System.Drawing.Point(122, 132);
			this.vdUsed.Name = "vdUsed";
			this.vdUsed.ReadOnly = true;
			this.vdUsed.Size = new System.Drawing.Size(49, 22);
			this.vdUsed.TabIndex = 37;
			this.vdUsed.Text = "";
			// 
			// vdTotal
			// 
			this.vdTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdTotal.Location = new System.Drawing.Point(122, 100);
			this.vdTotal.Name = "vdTotal";
			this.vdTotal.ReadOnly = true;
			this.vdTotal.Size = new System.Drawing.Size(49, 22);
			this.vdTotal.TabIndex = 36;
			this.vdTotal.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label7.Location = new System.Drawing.Point(170, 244);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(100, 24);
			this.label7.TabIndex = 35;
			this.label7.Text = "ÇáßãíÉ ÇáãÊÈÞíÉ";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label6.Location = new System.Drawing.Point(170, 132);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(100, 24);
			this.label6.TabIndex = 34;
			this.label6.Text = "ÇáßãíÉ ÇáãäÕÑÝÉ";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label5.Location = new System.Drawing.Point(170, 100);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(100, 24);
			this.label5.TabIndex = 33;
			this.label5.Text = "ÇáßãíÉ ÇáÇÌãÇáíÉ";
			// 
			// vdMedicinName
			// 
			this.vdMedicinName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vdMedicinName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.vdMedicinName.Location = new System.Drawing.Point(66, 60);
			this.vdMedicinName.Name = "vdMedicinName";
			this.vdMedicinName.Size = new System.Drawing.Size(150, 22);
			this.vdMedicinName.TabIndex = 32;
			this.vdMedicinName.SelectedIndexChanged += new System.EventHandler(this.vdMedicinChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.Location = new System.Drawing.Point(234, 60);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(36, 21);
			this.label2.TabIndex = 29;
			this.label2.Text = "ÇáÏæÇÁ";
			// 
			// AddNewMedicin
			// 
			this.AddNewMedicin.Controls.Add(this.nmBack);
			this.AddNewMedicin.Controls.Add(this.nmChangeOk);
			this.AddNewMedicin.Controls.Add(this.nmNewMedicinLabel);
			this.AddNewMedicin.Controls.Add(this.nmMedicins);
			this.AddNewMedicin.Controls.Add(this.nmChangeData);
			this.AddNewMedicin.Controls.Add(this.nmOk);
			this.AddNewMedicin.Controls.Add(this.nmMinimum);
			this.AddNewMedicin.Controls.Add(this.label16);
			this.AddNewMedicin.Controls.Add(this.nmUnit);
			this.AddNewMedicin.Controls.Add(this.nmMedicinName);
			this.AddNewMedicin.Controls.Add(this.label17);
			this.AddNewMedicin.Controls.Add(this.nmMedNameLabel);
			this.AddNewMedicin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.AddNewMedicin.Location = new System.Drawing.Point(4, 23);
			this.AddNewMedicin.Name = "AddNewMedicin";
			this.AddNewMedicin.Size = new System.Drawing.Size(317, 357);
			this.AddNewMedicin.TabIndex = 3;
			this.AddNewMedicin.Text = "ÇáÇÏæíå";
			// 
			// nmBack
			// 
			this.nmBack.Enabled = false;
			this.nmBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmBack.Location = new System.Drawing.Point(32, 256);
			this.nmBack.Name = "nmBack";
			this.nmBack.Size = new System.Drawing.Size(88, 24);
			this.nmBack.TabIndex = 19;
			this.nmBack.Text = "ÑÌæÚ";
			this.nmBack.Visible = false;
			this.nmBack.Click += new System.EventHandler(this.nmBack_Click);
			this.nmBack.MouseEnter += new System.EventHandler(this.changeColor);
			this.nmBack.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// nmChangeOk
			// 
			this.nmChangeOk.Enabled = false;
			this.nmChangeOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmChangeOk.Location = new System.Drawing.Point(160, 256);
			this.nmChangeOk.Name = "nmChangeOk";
			this.nmChangeOk.Size = new System.Drawing.Size(88, 24);
			this.nmChangeOk.TabIndex = 18;
			this.nmChangeOk.Text = "ÊÜÚÜÏíÜÜá";
			this.nmChangeOk.Visible = false;
			this.nmChangeOk.Click += new System.EventHandler(this.nmChangeOk_Click);
			this.nmChangeOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.nmChangeOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// nmNewMedicinLabel
			// 
			this.nmNewMedicinLabel.Enabled = false;
			this.nmNewMedicinLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmNewMedicinLabel.Location = new System.Drawing.Point(144, 40);
			this.nmNewMedicinLabel.Name = "nmNewMedicinLabel";
			this.nmNewMedicinLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmNewMedicinLabel.TabIndex = 17;
			this.nmNewMedicinLabel.Text = "ÇÓã ÇáÏæÇÁ";
			this.nmNewMedicinLabel.Visible = false;
			// 
			// nmMedicins
			// 
			this.nmMedicins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nmMedicins.Enabled = false;
			this.nmMedicins.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmMedicins.Location = new System.Drawing.Point(24, 40);
			this.nmMedicins.Name = "nmMedicins";
			this.nmMedicins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmMedicins.Size = new System.Drawing.Size(104, 22);
			this.nmMedicins.TabIndex = 16;
			this.nmMedicins.Visible = false;
			this.nmMedicins.SelectedIndexChanged += new System.EventHandler(this.nmMedicinChanged);
			// 
			// nmChangeData
			// 
			this.nmChangeData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmChangeData.Location = new System.Drawing.Point(38, 260);
			this.nmChangeData.Name = "nmChangeData";
			this.nmChangeData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmChangeData.TabIndex = 15;
			this.nmChangeData.Text = "ÊÛííÑ ÈíÇäÇÊ ÏæÇÁ";
			this.nmChangeData.Click += new System.EventHandler(this.nmChangeData_Click);
			this.nmChangeData.MouseEnter += new System.EventHandler(this.changeColor);
			this.nmChangeData.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// nmOk
			// 
			this.nmOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmOk.Location = new System.Drawing.Point(174, 260);
			this.nmOk.Name = "nmOk";
			this.nmOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmOk.TabIndex = 14;
			this.nmOk.Text = "ÊÓÌíá";
			this.nmOk.Click += new System.EventHandler(this.newMedicineHandler);
			this.nmOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.nmOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// nmMinimum
			// 
			this.nmMinimum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmMinimum.Location = new System.Drawing.Point(30, 172);
			this.nmMinimum.Name = "nmMinimum";
			this.nmMinimum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmMinimum.TabIndex = 13;
			this.nmMinimum.Text = "";
			this.nmMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
			this.nmMinimum.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label16.Location = new System.Drawing.Point(158, 172);
			this.label16.Name = "label16";
			this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label16.TabIndex = 12;
			this.label16.Text = "ÇáÍÏ ÇáÃÏäì";
			// 
			// nmUnit
			// 
			this.nmUnit.AllowDrop = true;
			this.nmUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nmUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmUnit.Items.AddRange(new object[] {
														"ÃãÈæá",
														"ÚáÈÉ",
														"ÒÌÇÌÉ"});
			this.nmUnit.Location = new System.Drawing.Point(30, 116);
			this.nmUnit.Name = "nmUnit";
			this.nmUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmUnit.Size = new System.Drawing.Size(101, 22);
			this.nmUnit.TabIndex = 11;
			// 
			// nmMedicinName
			// 
			this.nmMedicinName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmMedicinName.Location = new System.Drawing.Point(30, 76);
			this.nmMedicinName.Name = "nmMedicinName";
			this.nmMedicinName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmMedicinName.TabIndex = 10;
			this.nmMedicinName.Text = "";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label17.Location = new System.Drawing.Point(142, 116);
			this.label17.Name = "label17";
			this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label17.Size = new System.Drawing.Size(122, 25);
			this.label17.TabIndex = 9;
			this.label17.Text = "äæÚ ÇáæÍÏÉ ÇáãÓÊÎÏãå";
			// 
			// nmMedNameLabel
			// 
			this.nmMedNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.nmMedNameLabel.Location = new System.Drawing.Point(150, 76);
			this.nmMedNameLabel.Name = "nmMedNameLabel";
			this.nmMedNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nmMedNameLabel.TabIndex = 8;
			this.nmMedNameLabel.Text = "ÇÓã ÇáÏæÇÁ";
			// 
			// recordUsage
			// 
			this.recordUsage.Controls.Add(this.usgOk);
			this.recordUsage.Controls.Add(this.usgUnit);
			this.recordUsage.Controls.Add(this.usgQuantity);
			this.recordUsage.Controls.Add(this.label23);
			this.recordUsage.Controls.Add(this.usgMedicineName);
			this.recordUsage.Controls.Add(this.label9);
			this.recordUsage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.recordUsage.Location = new System.Drawing.Point(4, 23);
			this.recordUsage.Name = "recordUsage";
			this.recordUsage.Size = new System.Drawing.Size(317, 357);
			this.recordUsage.TabIndex = 4;
			this.recordUsage.Text = "ÇáãÓÊåáßÇÊ";
			// 
			// usgOk
			// 
			this.usgOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.usgOk.Location = new System.Drawing.Point(100, 220);
			this.usgOk.Name = "usgOk";
			this.usgOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usgOk.TabIndex = 82;
			this.usgOk.Text = "ãæÇÝÞ";
			this.usgOk.Click += new System.EventHandler(this.usgOk_Click);
			this.usgOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.usgOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// usgUnit
			// 
			this.usgUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.usgUnit.Location = new System.Drawing.Point(20, 156);
			this.usgUnit.Name = "usgUnit";
			this.usgUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usgUnit.TabIndex = 41;
			this.usgUnit.Text = "ÇáæÍÏÉ";
			// 
			// usgQuantity
			// 
			this.usgQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.usgQuantity.Location = new System.Drawing.Point(140, 156);
			this.usgQuantity.Name = "usgQuantity";
			this.usgQuantity.Size = new System.Drawing.Size(49, 22);
			this.usgQuantity.TabIndex = 40;
			this.usgQuantity.Text = "";
			this.usgQuantity.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label23.Location = new System.Drawing.Point(204, 156);
			this.label23.Name = "label23";
			this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label23.Size = new System.Drawing.Size(64, 21);
			this.label23.TabIndex = 39;
			this.label23.Text = "ÇáßãíÉ ";
			// 
			// usgMedicineName
			// 
			this.usgMedicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.usgMedicineName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.usgMedicineName.Location = new System.Drawing.Point(44, 116);
			this.usgMedicineName.Name = "usgMedicineName";
			this.usgMedicineName.Size = new System.Drawing.Size(150, 22);
			this.usgMedicineName.TabIndex = 37;
			this.usgMedicineName.SelectedIndexChanged += new System.EventHandler(this.usgMedicineChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label9.Location = new System.Drawing.Point(212, 116);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(56, 21);
			this.label9.TabIndex = 36;
			this.label9.Text = "ÇáÏæÇÁ";
			// 
			// recordReturns
			// 
			this.recordReturns.Controls.Add(this.rtDateLabel);
			this.recordReturns.Controls.Add(this.rtDate);
			this.recordReturns.Controls.Add(this.rtBack);
			this.recordReturns.Controls.Add(this.rtPrev);
			this.recordReturns.Controls.Add(this.rtNext);
			this.recordReturns.Controls.Add(this.rtViewData);
			this.recordReturns.Controls.Add(this.label27);
			this.recordReturns.Controls.Add(this.rtPrice);
			this.recordReturns.Controls.Add(this.label28);
			this.recordReturns.Controls.Add(this.rtBellNumber);
			this.recordReturns.Controls.Add(this.label18);
			this.recordReturns.Controls.Add(this.rtOk);
			this.recordReturns.Controls.Add(this.rtUnit);
			this.recordReturns.Controls.Add(this.rtQuantity);
			this.recordReturns.Controls.Add(this.label13);
			this.recordReturns.Controls.Add(this.rtMedicinName);
			this.recordReturns.Controls.Add(this.label4);
			this.recordReturns.Controls.Add(this.label8);
			this.recordReturns.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.recordReturns.Location = new System.Drawing.Point(4, 23);
			this.recordReturns.Name = "recordReturns";
			this.recordReturns.Size = new System.Drawing.Size(317, 357);
			this.recordReturns.TabIndex = 2;
			this.recordReturns.Text = "ÇáãÑÊÌÚÇÊ";
			// 
			// rtDateLabel
			// 
			this.rtDateLabel.Enabled = false;
			this.rtDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtDateLabel.Location = new System.Drawing.Point(216, 40);
			this.rtDateLabel.Name = "rtDateLabel";
			this.rtDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rtDateLabel.Size = new System.Drawing.Size(48, 24);
			this.rtDateLabel.TabIndex = 74;
			this.rtDateLabel.Text = "ÇáÊÇÑíÎ";
			this.rtDateLabel.Visible = false;
			// 
			// rtDate
			// 
			this.rtDate.Enabled = false;
			this.rtDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtDate.Location = new System.Drawing.Point(31, 40);
			this.rtDate.Name = "rtDate";
			this.rtDate.Size = new System.Drawing.Size(144, 22);
			this.rtDate.TabIndex = 73;
			this.rtDate.Visible = false;
			this.rtDate.ValueChanged += new System.EventHandler(this.rtViewData_Click);
			// 
			// rtBack
			// 
			this.rtBack.Enabled = false;
			this.rtBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtBack.Location = new System.Drawing.Point(103, 288);
			this.rtBack.Name = "rtBack";
			this.rtBack.Size = new System.Drawing.Size(87, 30);
			this.rtBack.TabIndex = 70;
			this.rtBack.Text = "ÑÌæÚ";
			this.rtBack.Visible = false;
			this.rtBack.Click += new System.EventHandler(this.rtBack_Click);
			this.rtBack.MouseEnter += new System.EventHandler(this.changeColor);
			this.rtBack.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// rtPrev
			// 
			this.rtPrev.Enabled = false;
			this.rtPrev.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtPrev.Location = new System.Drawing.Point(215, 288);
			this.rtPrev.Name = "rtPrev";
			this.rtPrev.Size = new System.Drawing.Size(40, 30);
			this.rtPrev.TabIndex = 69;
			this.rtPrev.Text = ">>>";
			this.rtPrev.Visible = false;
			this.rtPrev.Click += new System.EventHandler(this.rtPrev_Click);
			this.rtPrev.MouseEnter += new System.EventHandler(this.changeColor);
			this.rtPrev.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// rtNext
			// 
			this.rtNext.Enabled = false;
			this.rtNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtNext.Location = new System.Drawing.Point(31, 288);
			this.rtNext.Name = "rtNext";
			this.rtNext.Size = new System.Drawing.Size(48, 30);
			this.rtNext.TabIndex = 68;
			this.rtNext.Text = "<<<";
			this.rtNext.Visible = false;
			this.rtNext.Click += new System.EventHandler(this.rtNext_Click);
			this.rtNext.MouseEnter += new System.EventHandler(this.changeColor);
			this.rtNext.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// rtViewData
			// 
			this.rtViewData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtViewData.Location = new System.Drawing.Point(31, 256);
			this.rtViewData.Name = "rtViewData";
			this.rtViewData.Size = new System.Drawing.Size(96, 24);
			this.rtViewData.TabIndex = 50;
			this.rtViewData.Text = "ÚÑÖ ÈíÇäÇÊ";
			this.rtViewData.Click += new System.EventHandler(this.rtViewData_Click);
			this.rtViewData.MouseEnter += new System.EventHandler(this.changeColor);
			this.rtViewData.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label27.Location = new System.Drawing.Point(71, 192);
			this.label27.Name = "label27";
			this.label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label27.Size = new System.Drawing.Size(24, 23);
			this.label27.TabIndex = 49;
			this.label27.Text = "Ì.ã";
			// 
			// rtPrice
			// 
			this.rtPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtPrice.Location = new System.Drawing.Point(111, 192);
			this.rtPrice.Name = "rtPrice";
			this.rtPrice.Size = new System.Drawing.Size(49, 22);
			this.rtPrice.TabIndex = 48;
			this.rtPrice.Text = "";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label28.Location = new System.Drawing.Point(200, 192);
			this.label28.Name = "label28";
			this.label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 47;
			this.label28.Text = "ÇáËãä";
			// 
			// rtBellNumber
			// 
			this.rtBellNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtBellNumber.Location = new System.Drawing.Point(63, 152);
			this.rtBellNumber.Name = "rtBellNumber";
			this.rtBellNumber.TabIndex = 41;
			this.rtBellNumber.Text = "";
			this.rtBellNumber.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label18.Location = new System.Drawing.Point(208, 152);
			this.label18.Name = "label18";
			this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 40;
			this.label18.Text = "ÑÞã ÇáÝÇÊæÑÉ";
			// 
			// rtOk
			// 
			this.rtOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtOk.Location = new System.Drawing.Point(183, 256);
			this.rtOk.Name = "rtOk";
			this.rtOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rtOk.TabIndex = 39;
			this.rtOk.Text = "ãæÇÝÞ";
			this.rtOk.Click += new System.EventHandler(this.returnOkHandler);
			this.rtOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.rtOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// rtUnit
			// 
			this.rtUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtUnit.Location = new System.Drawing.Point(39, 112);
			this.rtUnit.Name = "rtUnit";
			this.rtUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rtUnit.Size = new System.Drawing.Size(56, 16);
			this.rtUnit.TabIndex = 38;
			this.rtUnit.Text = "ÇáæÍÏÉ";
			// 
			// rtQuantity
			// 
			this.rtQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtQuantity.Location = new System.Drawing.Point(119, 112);
			this.rtQuantity.Name = "rtQuantity";
			this.rtQuantity.Size = new System.Drawing.Size(49, 22);
			this.rtQuantity.TabIndex = 37;
			this.rtQuantity.Text = "";
			this.rtQuantity.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label13.Location = new System.Drawing.Point(191, 112);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(89, 23);
			this.label13.TabIndex = 36;
			this.label13.Text = "ÇáßãíÉ ÇáãÑÊÌÚÉ";
			// 
			// rtMedicinName
			// 
			this.rtMedicinName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rtMedicinName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.rtMedicinName.Location = new System.Drawing.Point(31, 72);
			this.rtMedicinName.Name = "rtMedicinName";
			this.rtMedicinName.Size = new System.Drawing.Size(144, 22);
			this.rtMedicinName.TabIndex = 35;
			this.rtMedicinName.SelectedIndexChanged += new System.EventHandler(this.rtMedicineChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.Location = new System.Drawing.Point(208, 72);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 34;
			this.label4.Text = "ÇáÏæÇÁ";
			// 
			// label8
			// 
			this.label8.Enabled = false;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label8.Location = new System.Drawing.Point(199, 40);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(48, 24);
			this.label8.TabIndex = 74;
			this.label8.Text = "ÇáÊÇÑíÎ";
			this.label8.Visible = false;
			// 
			// recordBuying
			// 
			this.recordBuying.Controls.Add(this.byBack);
			this.recordBuying.Controls.Add(this.byPrev);
			this.recordBuying.Controls.Add(this.byNext);
			this.recordBuying.Controls.Add(this.byViewData);
			this.recordBuying.Controls.Add(this.byDate);
			this.recordBuying.Controls.Add(this.byDateLabel);
			this.recordBuying.Controls.Add(this.label25);
			this.recordBuying.Controls.Add(this.byPrice);
			this.recordBuying.Controls.Add(this.label26);
			this.recordBuying.Controls.Add(this.byBellNumber);
			this.recordBuying.Controls.Add(this.label19);
			this.recordBuying.Controls.Add(this.byOk);
			this.recordBuying.Controls.Add(this.byUnit);
			this.recordBuying.Controls.Add(this.byQuantity);
			this.recordBuying.Controls.Add(this.label11);
			this.recordBuying.Controls.Add(this.byMedicinName);
			this.recordBuying.Controls.Add(this.label10);
			this.recordBuying.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.recordBuying.Location = new System.Drawing.Point(4, 23);
			this.recordBuying.Name = "recordBuying";
			this.recordBuying.Size = new System.Drawing.Size(317, 357);
			this.recordBuying.TabIndex = 1;
			this.recordBuying.Text = "ÇáãÔÊÑíÇÊ";
			// 
			// byBack
			// 
			this.byBack.Enabled = false;
			this.byBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byBack.Location = new System.Drawing.Point(116, 288);
			this.byBack.Name = "byBack";
			this.byBack.Size = new System.Drawing.Size(87, 30);
			this.byBack.TabIndex = 80;
			this.byBack.Text = "ÑÌæÚ";
			this.byBack.Visible = false;
			this.byBack.Click += new System.EventHandler(this.byBack_Click);
			this.byBack.MouseEnter += new System.EventHandler(this.changeColor);
			this.byBack.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// byPrev
			// 
			this.byPrev.Enabled = false;
			this.byPrev.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byPrev.Location = new System.Drawing.Point(220, 288);
			this.byPrev.Name = "byPrev";
			this.byPrev.Size = new System.Drawing.Size(48, 30);
			this.byPrev.TabIndex = 79;
			this.byPrev.Text = ">>>";
			this.byPrev.Visible = false;
			this.byPrev.Click += new System.EventHandler(this.byPrev_Click);
			this.byPrev.MouseEnter += new System.EventHandler(this.changeColor);
			this.byPrev.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// byNext
			// 
			this.byNext.Enabled = false;
			this.byNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byNext.Location = new System.Drawing.Point(44, 288);
			this.byNext.Name = "byNext";
			this.byNext.Size = new System.Drawing.Size(48, 30);
			this.byNext.TabIndex = 78;
			this.byNext.Text = "<<<";
			this.byNext.Visible = false;
			this.byNext.Click += new System.EventHandler(this.byNext_Click);
			this.byNext.MouseEnter += new System.EventHandler(this.changeColor);
			this.byNext.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// byViewData
			// 
			this.byViewData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byViewData.Location = new System.Drawing.Point(28, 256);
			this.byViewData.Name = "byViewData";
			this.byViewData.Size = new System.Drawing.Size(96, 24);
			this.byViewData.TabIndex = 77;
			this.byViewData.Text = "ÚÑÖ ÈíÇäÇÊ";
			this.byViewData.Click += new System.EventHandler(this.byViewData_Click_1);
			this.byViewData.MouseEnter += new System.EventHandler(this.changeColor);
			this.byViewData.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// byDate
			// 
			this.byDate.Enabled = false;
			this.byDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byDate.Location = new System.Drawing.Point(20, 40);
			this.byDate.Name = "byDate";
			this.byDate.Size = new System.Drawing.Size(144, 22);
			this.byDate.TabIndex = 75;
			this.byDate.Visible = false;
			this.byDate.ValueChanged += new System.EventHandler(this.byViewData_Click_1);
			// 
			// byDateLabel
			// 
			this.byDateLabel.Enabled = false;
			this.byDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byDateLabel.Location = new System.Drawing.Point(204, 40);
			this.byDateLabel.Name = "byDateLabel";
			this.byDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.byDateLabel.Size = new System.Drawing.Size(48, 24);
			this.byDateLabel.TabIndex = 76;
			this.byDateLabel.Text = "ÇáÊÇÑíÎ";
			this.byDateLabel.Visible = false;
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label25.Location = new System.Drawing.Point(36, 160);
			this.label25.Name = "label25";
			this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label25.Size = new System.Drawing.Size(48, 23);
			this.label25.TabIndex = 46;
			this.label25.Text = "Ì.ã";
			// 
			// byPrice
			// 
			this.byPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byPrice.Location = new System.Drawing.Point(116, 160);
			this.byPrice.Name = "byPrice";
			this.byPrice.Size = new System.Drawing.Size(49, 22);
			this.byPrice.TabIndex = 45;
			this.byPrice.Text = "";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label26.Location = new System.Drawing.Point(180, 160);
			this.label26.Name = "label26";
			this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label26.Size = new System.Drawing.Size(80, 24);
			this.label26.TabIndex = 44;
			this.label26.Text = "ÇáËãä";
			// 
			// byBellNumber
			// 
			this.byBellNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byBellNumber.Location = new System.Drawing.Point(68, 192);
			this.byBellNumber.Name = "byBellNumber";
			this.byBellNumber.TabIndex = 43;
			this.byBellNumber.Text = "";
			this.byBellNumber.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label19.Location = new System.Drawing.Point(180, 192);
			this.label19.Name = "label19";
			this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label19.Size = new System.Drawing.Size(80, 24);
			this.label19.TabIndex = 42;
			this.label19.Text = "ÑÞã ÇáÝÇÊæÑÉ";
			// 
			// byOk
			// 
			this.byOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byOk.Location = new System.Drawing.Point(164, 256);
			this.byOk.Name = "byOk";
			this.byOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.byOk.Size = new System.Drawing.Size(88, 24);
			this.byOk.TabIndex = 32;
			this.byOk.Text = "ãæÇÝÞ";
			this.byOk.Click += new System.EventHandler(this.BuyingOkHandler);
			this.byOk.MouseEnter += new System.EventHandler(this.changeColor);
			this.byOk.MouseLeave += new System.EventHandler(this.getColorback);
			// 
			// byUnit
			// 
			this.byUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byUnit.Location = new System.Drawing.Point(36, 128);
			this.byUnit.Name = "byUnit";
			this.byUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.byUnit.Size = new System.Drawing.Size(48, 23);
			this.byUnit.TabIndex = 31;
			this.byUnit.Text = "ÇáæÍÏÉ";
			// 
			// byQuantity
			// 
			this.byQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byQuantity.Location = new System.Drawing.Point(116, 128);
			this.byQuantity.Name = "byQuantity";
			this.byQuantity.Size = new System.Drawing.Size(49, 22);
			this.byQuantity.TabIndex = 30;
			this.byQuantity.Text = "";
			this.byQuantity.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label11.Location = new System.Drawing.Point(176, 120);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label11.Size = new System.Drawing.Size(88, 24);
			this.label11.TabIndex = 29;
			this.label11.Text = "ÇáßãíÉ ÇáãÔÊÑÇå";
			// 
			// byMedicinName
			// 
			this.byMedicinName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.byMedicinName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.byMedicinName.Location = new System.Drawing.Point(20, 80);
			this.byMedicinName.Name = "byMedicinName";
			this.byMedicinName.Size = new System.Drawing.Size(150, 22);
			this.byMedicinName.TabIndex = 28;
			this.byMedicinName.SelectedIndexChanged += new System.EventHandler(this.byMedicinChanged);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label10.Location = new System.Drawing.Point(180, 80);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 27;
			this.label10.Text = "ÇáÏæÇÁ";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(322, 382);
			this.Controls.Add(this.tabControl1);
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.99;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ÇáãÎÒä";
			this.MouseEnter += new System.EventHandler(this.changeColor);
			this.MouseLeave += new System.EventHandler(this.getColorback);
			this.tabControl1.ResumeLayout(false);
			this.Viewdat.ResumeLayout(false);
			this.AddNewMedicin.ResumeLayout(false);
			this.recordUsage.ResumeLayout(false);
			this.recordReturns.ResumeLayout(false);
			this.recordBuying.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
		
		public  void changeColor(object sender, System.EventArgs e)
		{
			Button b = sender as Button;
			if(b==null )return;
			b.BackColor = Color.Aqua;
		}
		public  void getColorback(object sender, System.EventArgs e)
		{
			Button b = sender as Button;
			if(b==null) return;
			b.BackColor = b.Parent.BackColor;
		}
		private void newMedicineHandler(object sender, System.EventArgs e)
		{
			if(this.nmMedicinName.Text.Equals("")||
				this.nmMedicinName.Text.Equals("")||
				this.nmUnit.Text.Equals(""))
			{
				ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
				return;
			}

			foreach(string s in byMedicinName.Items)
			{
				if(nmMedicinName.Text.Equals("")||
					nmUnit.Text.Equals("")||
					nmMinimum.Text.Equals(""))
				{
					ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
					return;
				}
				
					if(s.Equals(nmMedicinName.Text))
				{
					ErrorMessage("åÐÇ ÇáÏæÇÁ Êã ÊÓÌíáå ãä ÞÈá",false);
					return;
				}
			}
			dbm.newMedicineHandler(nmMedicinName.Text,nmUnit.Text,nmMinimum.Text);

			vdMedicinName.Items.Add(nmMedicinName.Text);
			byMedicinName.Items.Add(nmMedicinName.Text);
			rtMedicinName.Items.Add(nmMedicinName.Text);
			usgMedicineName.Items.Add(nmMedicinName.Text);
			units.Add(nmUnit.Text);
			MessageBox.Show("Êã ÇáÊÓÌíá");
			closeConnection();
		}

		private void textChanged(object sender, System.EventArgs e)
		{
			TextBox b=sender as TextBox;
			foreach(char ch in b.Text)
				if(!(ch>='0' && ch<='9'))
				{
					MessageBox.Show("ãä ÝÖáß ÇÓÊÎÏã ÇÑÞÇãÇ ÝÞØ");
					b.Text="0";
				}
		}
		private void vdOkhandler(object sender, System.EventArgs e)
		{
			if(vdMedicinName.SelectedIndex==-1) return;
			MyDate date=new MyDate();
			date.Day=vdDate.Value.Day;
			date.Month=vdDate.Value.Month;
			date.Year=vdDate.Value.Year;			
			string sqlcom="SELECT * from INVENTORY_OPERATION where DATE='"+date.ToString()+"' ";
			sqlcom+=" and MEDICIN_ID="+vdMedicinName.SelectedIndex.ToString()+" ;";
			openConnection();
			com=new OleDbCommand(sqlcom,connection);
			reader=com.ExecuteReader();
			
			if(!reader.Read())
			{
				ErrorMessage("áíÓÊ ßá ÇáÈíÇäÇÊ ãæÌæÏÉ áåÐÇ ÇáÏæÇÁ Ýì åÐÇ ÇáÊÇÑíÎ\nãä ÝÖááß ÍÇæá ÇáÑÌæÚ Çáì ãØæÑì ÇáÈÑäÇãÌ",false);
				return;
			}

			vdTotal.Text=reader[1].ToString();
			vdUsed.Text=reader["USED_QUANTITY"].ToString();
			int rem=(Int32.Parse(vdTotal.Text)-Int32.Parse(vdUsed.Text))
				-Int32.Parse(reader["RETURNS"].ToString())+Int32.Parse(reader["BUYINGS"].ToString());
			vdRemaining.Text=rem.ToString();
			
			vdUnit1.Text=vdUnit2.Text=vdUnit3.Text=vdUnit4.Text=vdUnit5.Text=vdUnit6.Text=
				units[vdMedicinName.SelectedIndex].ToString();
			vdreturnsQuantity.Text=reader["RETURNS"].ToString();
			vdByedQuantity.Text=reader["BUYINGS"].ToString();
			vdMinimumLimit.Text=((int)dbm.minimums[vdMedicinName.SelectedIndex]).ToString();
			if(	Int32.Parse(vdRemaining.Text)
				<(int)(dbm.minimums[vdMedicinName.SelectedIndex])&&
				(vdDate.Value.Day==DateTime.Now.Day
				&&vdDate.Value.Month==DateTime.Now.Month
				&&vdDate.Value.Year==DateTime.Now.Year ))
			{
				ErrorMessage("\t\t\tÊÍÐíÑ:\náÞÏ ÈáÛ åÇ ÇáÏæÇÁ ÇáÍÏ ÇáÇÏäì\nãä ÝÖáß ÍÇæá ÔÑÇÁ ßãíÉ ÌÏíÏÉ ãäå",true);
			}
			closeConnection();
		}

		private void BuyingOkHandler(object sender, System.EventArgs e)
		{
			
			if(byPrice.Text.Equals("")||
				byQuantity.Text.Equals("")||
				byBellNumber.Text.Equals("")||
				byMedicinName.SelectedIndex==-1)
			{
				ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
				return;
			}
			if( dbm.addNewBuyings(byMedicinName.SelectedIndex.ToString(),byQuantity.Text,byBellNumber.Text,
				byPrice.Text) )
			{
				MessageBox.Show("Êã ÇáÊÓÌíá");
			}
		}
		
		private void returnOkHandler(object sender, System.EventArgs e)
		{
			if(rtPrice.Text.Equals("")||
				rtQuantity.Text.Equals("")||
				rtBellNumber.Text.Equals("")||
				rtMedicinName.SelectedIndex==-1)
			{
				ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
				return;
			}
			if( dbm.addNewReturns(rtMedicinName.SelectedIndex.ToString(),rtQuantity.Text,
				rtBellNumber.Text,rtPrice.Text) )
			{
				MessageBox.Show("Êã ÇáÊÓÌíá");
			}
		}

		
		public  string  MedicineName( int MedicineId)
		{
			return vdMedicinName.Items[MedicineId].ToString();
		}

		private void vdMedicinChanged(object sender, System.EventArgs e)
		{
			if(vdMedicinName.SelectedIndex==-1) return;
			vdClear();
			vdUnit1.Text=vdUnit2.Text=vdUnit3.Text=vdUnit4.Text=vdUnit5.Text=vdUnit4.Text=vdUnit6.Text=
				units[vdMedicinName.SelectedIndex].ToString();
			vdOkhandler(vdOk,e);
		}

		private void rtMedicineChanged(object sender, System.EventArgs e)
		{
			rtUnit.Text=units[rtMedicinName.SelectedIndex].ToString();
			if(rtDate.Enabled) rtViewData_Click(rtViewData,new EventArgs());
		}

		private void byMedicinChanged(object sender, System.EventArgs e)
		{
			byClear();
			byUnit.Text=units[byMedicinName.SelectedIndex].ToString();			
			if(byDate.Visible)
			{
				byViewData_Click_1(byViewData,new EventArgs());
			}
		}

		private void usgMedicineChanged(object sender, System.EventArgs e)
		{
			usgUnit.Text=units[usgMedicineName.SelectedIndex].ToString();
		}

		private void usgOk_Click(object sender, System.EventArgs e)
		{
			if(usgMedicineName.SelectedIndex==-1 || usgQuantity.Text.Equals(""))
			{
				ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
				return;
			}
			if(dbm.addUsage(usgMedicineName.SelectedIndex.ToString(),usgQuantity.Text))
				MessageBox.Show("Êã ÇáÊÓÌíá");
		}

		public void vdViewMinimums_Click(object sender, System.EventArgs e)
		{
			MinimumsHolder=dbm.checkForMinimus();
			if(MinimumsHolder.Count==0) 
			{
				MessageBox.Show("áÇ ÊæÌÏ ÇÏæíÉ ÊÍÊ ÇáÍÏ ÇáÇÏäì");
				return;
			}
			vdMinIndex=0;
			vdMedicinName.Visible=vdMedicinName.Enabled=false;
			vdMinumMedicinName.Visible=vdMinumMedicinName.Enabled=true;
			vdPrev.Visible=vdNext.Visible=true;
			vdBack.Enabled=vdBack.Visible=true;
			vdOk.Enabled=vdOk.Visible=false;
			vdViewMinimums.Visible=vdViewMinimums.Enabled=false;
			vdPutaDataFromHolder((InventoryRecord)MinimumsHolder[0]);
			if(MinimumsHolder.Count==1) return;
			else
			{
				vdNext.Enabled=vdPrev.Enabled=true;
			}
		}
		private void vdPutaDataFromHolder(InventoryRecord r)
		{
			vdTotal.Text=r.total;
			vdUsed.Text=r.used;
			vdRemaining.Text=r.remaining;			
			vdUnit1.Text=vdUnit2.Text=vdUnit3.Text=
				vdUnit4.Text=vdUnit5.Text=vdUnit6.Text=r.unit;
			vdreturnsQuantity.Text=r.returns;
			vdByedQuantity.Text=r.buyings;
			vdMinimumLimit.Text=r.minimum;
			vdMinumMedicinName.Text=r.name;
		}
		private void vdClear()
		{
			vdTotal.Text="";
			vdUsed.Text="";
			vdRemaining.Text="";
			vdUnit1.Text=vdUnit2.Text="";
				vdUnit4.Text=vdUnit5.Text="";
			vdreturnsQuantity.Text="";
			vdByedQuantity.Text="";
			vdMinimumLimit.Text="";
		}
		
		private void vdBack_Click(object sender, System.EventArgs e)
		{
			vdClear();
			vdMedicinName.Visible=vdMedicinName.Enabled=true;
			vdMinumMedicinName.Visible=vdMinumMedicinName.Enabled=false;
			vdPrev.Visible=vdNext.Visible=false;
			vdBack.Enabled=vdBack.Visible=false;
			vdOk.Enabled=vdOk.Visible=true;
			vdViewMinimums.Visible=vdViewMinimums.Enabled=true;
			vdMinIndex=0;
			MinimumsHolder.Clear();
		}
		
		private void vdNext_Click(object sender, System.EventArgs e)
		{
			
			if(vdMinIndex==MinimumsHolder.Count-1)
			{
				vdNext.Enabled=false;
				return;
			}
			else
			{
				vdMinIndex++;
				vdPutaDataFromHolder((InventoryRecord)MinimumsHolder[vdMinIndex]);
				vdPrev.Enabled=true;
				if(vdMinIndex==MinimumsHolder.Count-1)
					vdNext.Enabled=false;
				return;
			}

		}
		
		private void vdPrev_Click(object sender, System.EventArgs e)
		{
			
			if(vdMinIndex<=0)
			{
				vdPrev.Enabled=false;
				return;
			}
			else
			{
				vdMinIndex--;
				vdPutaDataFromHolder((InventoryRecord)MinimumsHolder[vdMinIndex]);
				vdNext.Enabled=true;
				if(vdMinIndex<=0)
					vdPrev.Enabled=false;
				return;
			}

		}

		

		public void rtViewData_Click(object sender, System.EventArgs e)
		{
			if(!rtDate.Enabled && !rtViewData.Equals(sender)) return;
			RetuensHolder=viewer.GetReturns(rtDate.Value,rtMedicinName.SelectedIndex,this);
			rtDate.Visible=rtDate.Enabled=
			rtBellNumber.ReadOnly=
			rtBellNumber.ReadOnly=
			rtQuantity.ReadOnly=
			rtPrice.ReadOnly=
			rtBellNumber.ReadOnly=
			rtNext.Visible=rtNext.Enabled=
				rtPrev.Visible=rtPrev.Enabled
				=rtBack.Enabled=rtBack.Visible=
				rtDateLabel.Visible=rtDateLabel.Enabled=true;
			rtViewData.Visible=
				rtViewData.Enabled=
				rtOk.Visible=
				rtOk.Enabled=false;
			if(RetuensHolder.Count==1||BuyingsHolder.Count==0)
			{
				byPrev.Enabled=byNext.Enabled=false;
				return;
			}
			byNext.Enabled=byPrev.Enabled=true;
			byIndex=0;
			byPutData(RetuensHolder[0] as ReturnsBuyingsRecord);
		}

		private void rtBack_Click(object sender, System.EventArgs e)
		{
			rtDate.Visible=rtDate.Enabled=
			rtBellNumber.ReadOnly=
			rtBellNumber.ReadOnly=
			rtQuantity.ReadOnly=
			rtPrice.ReadOnly=
			rtBellNumber.ReadOnly=
			rtNext.Visible=rtNext.Enabled=
				rtPrev.Visible=rtPrev.Enabled
				=rtBack.Enabled=rtBack.Visible=
				rtDateLabel.Visible=rtDateLabel.Enabled=false;
			rtViewData.Visible=
				rtViewData.Enabled=
				rtOk.Visible=
				rtOk.Enabled=true;
		}

		private void byViewData_Click_1(object sender, System.EventArgs e)
		{
			if(!byDate.Enabled && !byViewData.Equals(sender)) return;
			BuyingsHolder=viewer.GetBuyings(byDate.Value,byMedicinName.SelectedIndex,this);
			byDate.Visible=byDate.Enabled=
				byQuantity.ReadOnly=
				byPrice.ReadOnly=
				byBellNumber.ReadOnly=
				byNext.Visible=byNext.Enabled=
				byPrev.Visible=byPrev.Enabled
				=byBack.Enabled=byBack.Visible=
				byDateLabel.Visible=byDateLabel.Enabled=true;

			byViewData.Visible=
				byViewData.Enabled=
				byOk.Visible=
				byOk.Enabled=false;
			if(BuyingsHolder.Count==1||BuyingsHolder.Count==0)
			{
				byPrev.Enabled=byNext.Enabled=false;
				return;
			}
			byNext.Enabled=byPrev.Enabled=true;
			byIndex=0;
			byPutData(BuyingsHolder[0] as ReturnsBuyingsRecord);
		}
		void byPutData(ReturnsBuyingsRecord r)
		{
			byPrice.Text=r.price;
			byQuantity.Text=r.quantity;
			byUnit.Text=r.unit;
			byBellNumber.Text=r.bellNumber;
		}
		void rtPutData(ReturnsBuyingsRecord r)
		{
			rtPrice.Text=r.price;
			rtQuantity.Text=r.quantity;
			rtUnit.Text=r.unit;
			rtBellNumber.Text=r.bellNumber;
		}
		void byClear()
		{
			byPrice.Text=
			byQuantity.Text=
			byUnit.Text=
			byBellNumber.Text="";
		}

		private void byBack_Click(object sender, System.EventArgs e)
		{
			byDate.Visible=byDate.Enabled=
				byQuantity.ReadOnly=
				byPrice.ReadOnly=
				byBellNumber.ReadOnly=
				byNext.Visible=byNext.Enabled=
				byPrev.Visible=byPrev.Enabled
				=byBack.Enabled=byBack.Visible=
				byDateLabel.Visible=byDateLabel.Enabled=false;
			byViewData.Visible=
				byViewData.Enabled=
				byOk.Visible=
				byOk.Enabled=true;
			byDate.Value=DateTime.Now;
			byClear();
		}

		private void byPrev_Click(object sender, System.EventArgs e)
		{
			if(byIndex==0)
			{
				byPrev.Enabled=false;
				byNext.Enabled=true;
				byPutData(( ReturnsBuyingsRecord)BuyingsHolder[byIndex]);
				return;
			}
			else
			{
				byIndex--;
				byPutData(( ReturnsBuyingsRecord)BuyingsHolder[byIndex]);
				if(byIndex<=0)
				{
					byPrev.Enabled=false;
					byNext.Enabled=true;
				
				}
			}


		}

		private void byNext_Click(object sender, System.EventArgs e)
		{
			if(byIndex>=BuyingsHolder.Count-1)
			{
				byNext.Enabled=false;
				byPrev.Enabled=true;
			}
			else
			{
				byIndex++;
				byPutData( (ReturnsBuyingsRecord)BuyingsHolder[byIndex]);
				byPrev.Enabled=true;
				if(byIndex>=BuyingsHolder.Count-1)
				{
					byNext.Enabled=false;
				}
			}
		}
		public static void ErrorMessage(string text,bool warn)
		{
			if(warn)
			MessageBox.Show(null,text,"                        ÊÍÐíÑ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			else
				MessageBox.Show(null,text,"                       ÎØÃ",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void keypressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		
		}

		private void rtNext_Click(object sender, System.EventArgs e)
		{
			if(rtIndex>=BuyingsHolder.Count-1)
			{
				rtNext.Enabled=false;
				rtPrev.Enabled=true;
			}
			else
			{
				rtIndex++;
				rtPutData( (ReturnsBuyingsRecord)BuyingsHolder[rtIndex]);
				rtPrev.Enabled=true;
				if(rtIndex>=BuyingsHolder.Count-1)
				{
					rtNext.Enabled=false;
				}
			}
		}

		private void rtPrev_Click(object sender, System.EventArgs e)
		{
			if(rtIndex==0)
			{
				rtPrev.Enabled=false;
				rtNext.Enabled=true;
				rtPutData(( ReturnsBuyingsRecord)BuyingsHolder[rtIndex]);
				return;
			}
			else
			{
				rtIndex--;
				rtPutData(( ReturnsBuyingsRecord)BuyingsHolder[rtIndex]);
				if(rtIndex<=0)
				{
					rtPrev.Enabled=false;
					rtNext.Enabled=true;				
				}
			}

		}

		private void nmChangeOk_Click(object sender, System.EventArgs e)
		{
			if(this.nmMedicinName.Text.Equals("")||
				this.nmMedicinName.Text.Equals("")||
				this.nmUnit.Text.Equals(""))
			{
				ErrorMessage("ãä ÝÖáß ÇÏÎá ßá ÇáÈíÇäÇÊ",false);
				return;
			}
			foreach(string s in this.vdMedicinName.Items)
			{
				if(s.Equals(this.nmMedicinName.Text)&&!this.nmMedicinName.Text.Equals(this.nmMedicins.Text))
				{
					MessageBox.Show("åÐÇ ÇáÇÓã ãÓÊÎÏã ,\nÇÓÊÎÏã ÇÓãÇ ÇÎÑ");
					return;
				}
			}
			if(this.dbm.updateMedicine(this.nmMedicins.SelectedIndex,this.nmMedicinName.Text,this.nmMinimum.Text,this.nmUnit.Text))
			{

				MessageBox.Show("Êã ÇáÊÚÏíá");
				units[this.nmMedicins.SelectedIndex]=this.nmUnit.Text;
				this.dbm.minimums[this.nmMedicins.SelectedIndex]=Int32.Parse(this.nmMinimum.Text);
				vdMedicinName.Items[nmMedicins.SelectedIndex]=nmMedicinName.Text;
				byMedicinName.Items[nmMedicins.SelectedIndex]=nmMedicinName.Text;
				rtMedicinName.Items[nmMedicins.SelectedIndex]=nmMedicinName.Text;
				usgMedicineName.Items[nmMedicins.SelectedIndex]=nmMedicinName.Text;
				this.nmMedicins.Items[nmMedicins.SelectedIndex]=nmMedicinName.Text;
			}
			else
			{
				ErrorMessage("Fatal Error",false);
			}
		}

		private void nmChangeData_Click(object sender, System.EventArgs e)
		{
			this.nmMedNameLabel.Text="ÇáÇÓã ÇáÌÏíÏ";
			this.nmChangeOk.Enabled=this.nmChangeOk.Visible=
				this.nmNewMedicinLabel.Visible=
			this.nmNewMedicinLabel.Enabled=
				this.nmMedicins.Visible=this.nmMedicins.Enabled=
				this.nmBack.Visible=this.nmBack.Enabled=true;
			this.nmChangeData.Visible=this.nmChangeData.Enabled=
				this.nmOk.Enabled=this.nmOk.Visible=false;
			foreach(string s in this.vdMedicinName.Items)
			{
				this.nmMedicins.Items.Add(s);
			}
			if(this.nmMedicins.Items.Count!=0)
				this.nmMedicins.SelectedIndex=0;
			
		}

		private void nmBack_Click(object sender, System.EventArgs e)
		{
			this.nmMedNameLabel.Text="ÇáÇÓã";
			this.nmChangeOk.Enabled=this.nmChangeOk.Visible=
				this.nmNewMedicinLabel.Visible=
				this.nmNewMedicinLabel.Enabled=
				this.nmMedicins.Visible=this.nmMedicins.Enabled=
				this.nmBack.Visible=this.nmBack.Enabled=false;
			this.nmChangeData.Visible=this.nmChangeData.Enabled=
				this.nmOk.Enabled=this.nmOk.Visible=true;
			this.nmMedicins.Items.Clear();
		}

		private void nmMedicinChanged(object sender, System.EventArgs e)
		{
			this.nmMedicinName.Text=this.nmMedicins.Text;
			this.nmUnit.Text=units[this.nmMedicins.SelectedIndex].ToString();
			this.nmMinimum.Text=this.dbm.minimums[this.nmMedicins.SelectedIndex].ToString();
		}

	}
}
