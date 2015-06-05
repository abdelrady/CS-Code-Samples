using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for FormGetKey.
	/// </summary>
	public class FormGetKey : System.Windows.Forms.Form
	{
		private FormSetControls parentForm;
		private System.Windows.Forms.Label lblPlayer1Down;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormGetKey(FormSetControls parentForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.parentForm = parentForm;
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
			this.lblPlayer1Down = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPlayer1Down
			// 
			this.lblPlayer1Down.AutoSize = true;
			this.lblPlayer1Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1Down.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPlayer1Down.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1Down.Location = new System.Drawing.Point(10, 45);
			this.lblPlayer1Down.Name = "lblPlayer1Down";
			this.lblPlayer1Down.Size = new System.Drawing.Size(221, 30);
			this.lblPlayer1Down.TabIndex = 22;
			this.lblPlayer1Down.Text = "PRESS THE NEW KEY";
			// 
			// FormGetKey
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(236, 120);
			this.ControlBox = false;
			this.Controls.Add(this.lblPlayer1Down);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormGetKey";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGetKey_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormGetKey_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
				return;

			this.parentForm.SetNewKey(e.KeyCode);
			this.Close();
		}
	}
}
