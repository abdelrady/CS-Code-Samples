using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BugSentryDemoCSharp
{
	/// <summary>
	/// Summary description for frmTrivialExample.
	/// </summary>
	public class frmTrivialExample : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label lblResult;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button1;
		
		private static frmTrivialExample myInstance;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTrivialExample()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			myInstance=this;
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

		public static frmTrivialExample GetInstance(){
			if (myInstance ==null){
				myInstance=new frmTrivialExample();
			}
			return myInstance;
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(32, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(232, 24);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "1) Enter some data likely to fail such as 19/0.";
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// lblResult
			// 
			this.lblResult.Location = new System.Drawing.Point(168, 40);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(64, 23);
			this.lblResult.TabIndex = 12;
			this.lblResult.Text = "equals:";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(64, 40);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 23);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "divided by";
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(120, 40);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(40, 20);
			this.TextBox2.TabIndex = 10;
			this.TextBox2.Text = "";
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(32, 96);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Do It";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(32, 40);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(33, 20);
			this.TextBox1.TabIndex = 14;
			this.TextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 15;
			this.label3.Text = "2) Click \"Do It\" to try it.";
			// 
			// frmTrivialExample
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(328, 213);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Button1);
			this.Name = "frmTrivialExample";
			this.Text = "Trivial Example";
			this.ResumeLayout(false);

		}
		#endregion

		

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try{
	          this.Cursor=Cursors.WaitCursor;
				//sloppy, non validated code likely to cause errors.
				this.lblResult.Text = Convert.ToString(Convert.ToDecimal(this.TextBox1.Text) / Convert.ToDecimal(this.TextBox2.Text));
				this.Cursor=Cursors.Default;
			}
			catch (Exception ex){
				this.Cursor=Cursors.Default;
//Use if you want to ask user permission:
				frmMDI.ReportErrorIfUserOKs(ex);
//Use if you don't want to ask user permission:
				frmMDI.GetInstance().Sentry.Report(ex);
				System.Windows.Forms.MessageBox.Show("A serious error has occurred: " + ex.Message + "\nStaff have been notified.");
			}

		}

		private void Label1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
