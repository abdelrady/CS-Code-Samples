using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DialogDemo
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button10;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// skinEngine1
			// 
			this.skinEngine1.Active = true;
			this.skinEngine1.SerialNumber = "";
			this.skinEngine1.SkinFile = "D:\\Debug\\Skins\\Eighteen.ssk";
			this.skinEngine1.SkinPassword = null;
			this.skinEngine1.SkinStream = null;
			this.skinEngine1.SkinStreamMain = ((System.IO.MemoryStream)(resources.GetObject("skinEngine1.SkinStreamMain")));
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "MessageBox1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(160, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "MessageBox2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 64);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "MessageBox3";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(160, 64);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(136, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "MessageBox4";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(8, 176);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(136, 23);
			this.button9.TabIndex = 6;
			this.button9.Text = "PrintPreviewDialog";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(8, 144);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(136, 23);
			this.button7.TabIndex = 8;
			this.button7.Text = "FontDialog";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(160, 144);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(136, 23);
			this.button8.TabIndex = 9;
			this.button8.Text = "ColorDialog";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(160, 112);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(136, 23);
			this.button6.TabIndex = 10;
			this.button6.Text = "Remove skin";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(8, 112);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(136, 23);
			this.button5.TabIndex = 11;
			this.button5.Text = "Load skin..";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(160, 176);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(136, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "PrintDialog";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 230);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button10,
																		  this.button5,
																		  this.button6,
																		  this.button8,
																		  this.button7,
																		  this.button9,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "DialogDemo";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("Thanks for using IrisSkin.", "Sunisoft");
		}

		private void button2_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("Are you sure?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		private void button3_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("Hello world!", "Hello", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
		}

		private void button4_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("Hello world!", "Hello", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.CheckFileExists = true;
			dialog.Filter = "Sunisoft skin file (ssk file) | *.ssk";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				skinEngine1.SkinFile = dialog.FileName;
				if (! skinEngine1.Active)
					skinEngine1.Active = true;
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			skinEngine1.Active = false;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			dialog.ShowDialog();
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			dialog.ShowDialog();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			PrintPreviewDialog dialog = new PrintPreviewDialog();
			dialog.ShowDialog();
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			PrintDialog dialog = new PrintDialog();
			dialog.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
			dialog.ShowDialog();
		}


	}
}
