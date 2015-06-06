/*
 * Created by SharpDevelop.
 * User: pc123
 * Date: 1/4/2006
 * Time: 7:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
namespace DefaultNamespace
{
	/// <summary>
	/// Description of MainForm.	
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button student_f;
		private System.Windows.Forms.Button coarse_f;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			
			Application.Run(new MainForm());
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() 
		{
			this.label1 = new System.Windows.Forms.Label();
			this.student_f = new System.Windows.Forms.Button();
			this.coarse_f = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 80);
			this.label1.TabIndex = 2;
			this.label1.Text = "Please choose the table you want to connect to ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// student_f
			// 
			this.student_f.Location = new System.Drawing.Point(32, 152);
			this.student_f.Name = "student_f";
			this.student_f.Size = new System.Drawing.Size(128, 40);
			this.student_f.TabIndex = 4;
			this.student_f.Text = "Students";
			this.student_f.Click += new System.EventHandler(this.student_f_Click);
			// 
			// coarse_f
			// 
			this.coarse_f.Location = new System.Drawing.Point(264, 152);
			this.coarse_f.Name = "coarse_f";
			this.coarse_f.Size = new System.Drawing.Size(128, 40);
			this.coarse_f.TabIndex = 5;
			this.coarse_f.Text = "Coarses";
			this.coarse_f.Click += new System.EventHandler(this.coarse_f_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 246);
			this.Controls.Add(this.coarse_f);
			this.Controls.Add(this.student_f);
			this.Controls.Add(this.label1);
			this.IsMdiContainer = true;
			this.Location = new System.Drawing.Point(300, 300);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}
		#endregion
		
		
		
		
		
		
		

		private void student_f_Click(object sender, System.EventArgs e)
		{
			Form1 f=new Form1(this);
			f.Show();
			this.Visible=false;

		}

		private void coarse_f_Click(object sender, System.EventArgs e)
		{
			coarse_form f2=new coarse_form(this);
			f2.Show();
			this.Visible=false;
		}
		
	}
	
	
	
	
}
