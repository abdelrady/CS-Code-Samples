using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace storeANDretrieveImages
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		System.Data.OleDb.OleDbParameter param = new System.Data.OleDb.OleDbParameter();
		System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.Jet.OlEDB.4.0; Data Source = c:\\myDataBase.mdb");
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		DataSet ds = new DataSet();
		#region " Windows Form Designer generated code "
		
		public Form1()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Button btnGet;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.TextBox tbImagePath;
		internal System.Windows.Forms.Button tbBrowse;
		internal System.Windows.Forms.OpenFileDialog ofd;
		internal System.Windows.Forms.ComboBox cbIDs;
		internal System.Windows.Forms.PictureBox pb;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.btnGet = new System.Windows.Forms.Button();
			this.btnGet.Click += new System.EventHandler(btnGet_Click);
			base.Load += new System.EventHandler(Form1_Load);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(btnSave_Click);
			this.tbImagePath = new System.Windows.Forms.TextBox();
			this.tbBrowse = new System.Windows.Forms.Button();
			this.tbBrowse.Click += new System.EventHandler(tbBrowse_Click);
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.cbIDs = new System.Windows.Forms.ComboBox();
			this.pb = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			//
			//btnGet
			//
			this.btnGet.Location = new System.Drawing.Point(296, 256);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(75, 24);
			this.btnGet.TabIndex = 1;
			this.btnGet.Text = "get Image";
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(296, 296);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 24);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "save image";
			//
			//tbImagePath
			//
			this.tbImagePath.Location = new System.Drawing.Point(104, 296);
			this.tbImagePath.Name = "tbImagePath";
			this.tbImagePath.Size = new System.Drawing.Size(184, 20);
			this.tbImagePath.TabIndex = 3;
			this.tbImagePath.Text = "";
			//
			//tbBrowse
			//
			this.tbBrowse.Location = new System.Drawing.Point(24, 296);
			this.tbBrowse.Name = "tbBrowse";
			this.tbBrowse.Size = new System.Drawing.Size(72, 23);
			this.tbBrowse.TabIndex = 4;
			this.tbBrowse.Text = "browse";
			//
			//cbIDs
			//
			this.cbIDs.Location = new System.Drawing.Point(216, 256);
			this.cbIDs.Name = "cbIDs";
			this.cbIDs.Size = new System.Drawing.Size(72, 21);
			this.cbIDs.TabIndex = 5;
			//
			//pb
			//
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pb.Location = new System.Drawing.Point(16, 24);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(376, 216);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb.TabIndex = 6;
			this.pb.TabStop = false;
			//
			//Form1
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 342);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pb, this.cbIDs, this.tbBrowse, this.tbImagePath, this.btnSave, this.btnGet });
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void tbBrowse_Click(System.Object sender, System.EventArgs e)
		{
			ofd.Filter = "Image Files (*.bmp) | *.bmp|JPEG Files (*.jpg)|*.jpg|AllFiles (*.*)|*.*";
			ofd.FilterIndex = 1;
			ofd.Title = "pick up a file o open";
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;
			ofd.ValidateNames = true;
			ofd.DereferenceLinks = true;
			ofd.InitialDirectory = "C:\\";
			ofd.RestoreDirectory = true;
			ofd.ShowDialog();
			tbImagePath.Text = ofd.FileName;
		}
		
		private void insertImage()
		{
			
			
			
		}
		
		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (tbImagePath.Text == "")
			{
				MessageBox.Show("Error You must choose Picture");
				//End
				return;
			}
			string strFile = tbImagePath.Text;
			
			System.IO.FileStream imageStream = new System.IO.FileStream(strFile, System.IO.FileMode.Open);
			byte[] imageData = new byte[imageStream.Length + 1];
			
			imageStream.Read(imageData, 0, (int) imageStream.Length);
			imageStream.Close();
			
			cmd = new System.Data.OleDb.OleDbCommand("spInsertImage", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			param = new System.Data.OleDb.OleDbParameter("@ImageData", System.Data.OleDb.OleDbType.LongVarBinary);
			param.Value = imageData;
			cmd.Parameters.Add(param);
			
			try
			{
				if (System.Convert.ToBoolean(MessageBox.Show("هل فعلا تريد اضافة هذا السجل", "اضافة سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).CompareTo(DialogResult.No)))
				{
					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				conn.Close();
				MessageBox.Show(ex.Message);
			}
			
			getIds();
			
			tbImagePath.ResetText();
			
		}
		
		private void btnGet_Click(System.Object sender, System.EventArgs e)
		{
			byte[] imageData;
			System.IO.MemoryStream memoryStream;
			
			cmd = new System.Data.OleDb.OleDbCommand("spGetImage", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			param = new System.Data.OleDb.OleDbParameter("@id", System.Data.OleDb.OleDbType.Integer);
			param.Value = cbIDs.Text;
			cmd.Parameters.Add(param);
			
			
			try
			{
				conn.Open();
				if (!System.Convert.ToBoolean(cmd.ExecuteScalar() == System.DBNull.Value))
				{
					imageData = (byte[]) cmd.ExecuteScalar();
					if (imageData != null)
					{
						memoryStream = new System.IO.MemoryStream(imageData);
						pb.Image = new Bitmap(memoryStream);
						memoryStream.Close();
					}
					else
					{
						pb.Image = null;
					}
				}
				else
				{
					pb.Image = null;
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				conn.Close();
				MessageBox.Show(ex.Message);
			}
			
		}
		
		private void getIds()
		{
			ds.Clear();
			
			cmd = new System.Data.OleDb.OleDbCommand("spImageID", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			try
			{
				conn.Open();
				
				
				da.SelectCommand = cmd;
				da.Fill(ds, "Id");
				conn.Close();
				cbIDs.DataSource = ds.Tables["Id"];
				cbIDs.DisplayMember = "id";
				cbIDs.Text = "اختار رقم";
				
				
				
			}
			catch (Exception ex)
			{
				conn.Close();
				MessageBox.Show(ex.Message);
			}
			
		}
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			getIds();
		}
	}
	
}
