using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Imaging;

namespace barcode128b
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmTestCode128b : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCreateBarCode128b;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.PictureBox picBarcode;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnVersionInfo;
		private System.Windows.Forms.LinkLabel llblDeveloper;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTestCode128b()
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
			this.btnCreateBarCode128b = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.picBarcode = new System.Windows.Forms.PictureBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnVersionInfo = new System.Windows.Forms.Button();
			this.llblDeveloper = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// btnCreateBarCode128b
			// 
			this.btnCreateBarCode128b.Location = new System.Drawing.Point(24, 40);
			this.btnCreateBarCode128b.Name = "btnCreateBarCode128b";
			this.btnCreateBarCode128b.Size = new System.Drawing.Size(144, 32);
			this.btnCreateBarCode128b.TabIndex = 0;
			this.btnCreateBarCode128b.Text = "&Create Barcode 128b";
			this.btnCreateBarCode128b.Click += new System.EventHandler(this.btnCreateBarCode128b_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(24, 16);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(512, 20);
			this.txtInput.TabIndex = 1;
			this.txtInput.Text = "";
			// 
			// picBarcode
			// 
			this.picBarcode.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.picBarcode.Location = new System.Drawing.Point(24, 96);
			this.picBarcode.Name = "picBarcode";
			this.picBarcode.Size = new System.Drawing.Size(522, 50);
			this.picBarcode.TabIndex = 2;
			this.picBarcode.TabStop = false;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(176, 40);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(144, 32);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save Barcode to BMP";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnVersionInfo
			// 
			this.btnVersionInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnVersionInfo.Location = new System.Drawing.Point(472, 40);
			this.btnVersionInfo.Name = "btnVersionInfo";
			this.btnVersionInfo.Size = new System.Drawing.Size(64, 32);
			this.btnVersionInfo.TabIndex = 4;
			this.btnVersionInfo.Text = "&Info";
			this.btnVersionInfo.Click += new System.EventHandler(this.btnVersionInfo_Click);
			// 
			// llblDeveloper
			// 
			this.llblDeveloper.BackColor = System.Drawing.Color.White;
			this.llblDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.llblDeveloper.Location = new System.Drawing.Point(344, 160);
			this.llblDeveloper.Name = "llblDeveloper";
			this.llblDeveloper.Size = new System.Drawing.Size(208, 16);
			this.llblDeveloper.TabIndex = 5;
			this.llblDeveloper.TabStop = true;
			this.llblDeveloper.Text = "Developed by Curi0uS";
			this.llblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llblDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDeveloper_LinkClicked);
			// 
			// frmTestCode128b
			// 
			this.AcceptButton = this.btnCreateBarCode128b;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(562, 184);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.llblDeveloper,
																		  this.btnVersionInfo,
																		  this.btnSave,
																		  this.picBarcode,
																		  this.txtInput,
																		  this.btnCreateBarCode128b});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 216);
			this.Name = "frmTestCode128b";
			this.Text = "Test Barcode128b";
			this.Load += new System.EventHandler(this.frmTestCode128b_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmTestCode128b());
		}

		private void btnCreateBarCode128b_Click(object sender, System.EventArgs e)
		{
			picBarcode.Image = Image.FromStream(barcode128b.CreateBarcode128b(txtInput.Text));
			Byte[] arrImage = barcode128b.CreateBarcode128b(txtInput.Text).GetBuffer();			
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (picBarcode.Image != null)
			{
				picBarcode.Image.Save("barcode.bmp", ImageFormat.Bmp);
			}
		}

		private void btnVersionInfo_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(barcode128b.GetVersion(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frmTestCode128b_Load(object sender, System.EventArgs e)
		{
			llblDeveloper.Links.Add(0, llblDeveloper.Text.Length,"mailto:Curi0uS@operamail.com");
		}

		private void llblDeveloper_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start((string)e.Link.LinkData);
		}
	}
}
