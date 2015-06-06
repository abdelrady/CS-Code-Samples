using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BugSentryDemoCSharp
{
	/// <summary>
	/// Summary description for frmCSharpFeedback.
	/// </summary>
	public class frmFeedback : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtComments;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmFeedback()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(72, 40);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(296, 20);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Your Email:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "Submit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "Comments:";
			// 
			// txtComments
			// 
			this.txtComments.Location = new System.Drawing.Point(72, 64);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.Size = new System.Drawing.Size(296, 280);
			this.txtComments.TabIndex = 5;
			this.txtComments.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Your feedback helps us make this program better. ";
			// 
			// frmFeedback
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 405);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtComments);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label1);
			this.Name = "frmFeedback";
			this.Text = "Feedback ";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try{
				frmMDI.GetInstance().Sentry.Report("Feedback from " + this.txtEmail.Text ,this.txtComments.Text,ITCollaborate.BugSentry.Issue.IssueTypes.EndUserFeature);  //you could add a drop down for each enum 
				System.Windows.Forms.MessageBox.Show("Thanks for your input!");
				this.Dispose();							
			}
			catch (Exception ex){
				frmMDI.GetInstance().Sentry.Report(ex);
				System.Windows.Forms.MessageBox.Show("There was an error sending your feedback.  This error has been logged and staff will be notified.");
			}

		}
	}
}
