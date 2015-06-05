using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MineSweeperReader
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblMines;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtMines;
		private System.Windows.Forms.Button btnRead;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Windows.Forms.Button[,] ButtonArray = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Control[] MainControls = null;

		public Form1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblMines = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtMines = new System.Windows.Forms.TextBox();
			this.btnRead = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(8, 16);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(36, 13);
			this.lblWidth.TabIndex = 0;
			this.lblWidth.Text = "Width:";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(112, 16);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(40, 13);
			this.lblHeight.TabIndex = 1;
			this.lblHeight.Text = "Height:";
			// 
			// lblMines
			// 
			this.lblMines.AutoSize = true;
			this.lblMines.Location = new System.Drawing.Point(216, 16);
			this.lblMines.Name = "lblMines";
			this.lblMines.Size = new System.Drawing.Size(38, 13);
			this.lblMines.TabIndex = 2;
			this.lblMines.Text = "Mines:";
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(48, 12);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.ReadOnly = true;
			this.txtWidth.Size = new System.Drawing.Size(48, 20);
			this.txtWidth.TabIndex = 3;
			this.txtWidth.Text = "";
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(152, 12);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.ReadOnly = true;
			this.txtHeight.Size = new System.Drawing.Size(48, 20);
			this.txtHeight.TabIndex = 4;
			this.txtHeight.Text = "";
			// 
			// txtMines
			// 
			this.txtMines.Location = new System.Drawing.Point(256, 12);
			this.txtMines.Name = "txtMines";
			this.txtMines.ReadOnly = true;
			this.txtMines.Size = new System.Drawing.Size(48, 20);
			this.txtMines.TabIndex = 5;
			this.txtMines.Text = "";
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(8, 40);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(296, 24);
			this.btnRead.TabIndex = 6;
			this.btnRead.Text = "Read MineSweeper Memory";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 16);
			this.button1.TabIndex = 7;
			this.button1.Text = "button1";
			this.button1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.btnRead,
																		  this.txtMines,
																		  this.txtHeight,
																		  this.txtWidth,
																		  this.lblMines,
																		  this.lblHeight,
																		  this.lblWidth});
			this.Name = "Form1";
			this.Opacity = 0.800000011920929;
			this.Text = "MineSweeper Memory Reader";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnRead_Click(object sender, System.EventArgs e)
		{
			int iWidthAddress;
			int iHeightAddress;
			int iMinesAddress;
			int iCellBaseAddress;
			
			// check if version is win2k or winXP
			if (Environment.OSVersion.Version.Major == 5)
			{
				if (Environment.OSVersion.Version.Minor == 0)	// win2K
				{
					// Thanks goes to Ryan Schreiber for discovering these addresses.
					iWidthAddress = 0x10056f8;
					iHeightAddress = 0x1005a68;
					iMinesAddress = 0x1005a6c;
					iCellBaseAddress = 0x1005700;
				}
				else	// winXP
				{
					iWidthAddress = 0x1005334;
					iHeightAddress = 0x1005338;
					iMinesAddress = 0x1005330;
					iCellBaseAddress = 0x1005340;
				}
			}
			else
			{
				MessageBox.Show("Sorry, only winXP and win2K are supported!");
				return;
			}
			
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			
			ProcessMemoryReaderLib.ProcessMemoryReader pReader = new ProcessMemoryReaderLib.ProcessMemoryReader();
			
			System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("winmine");
			
			// take first instance of minesweeper you find
			if (myProcesses.Length == 0)
			{
				MessageBox.Show("No MineSweeper process found!");
				return;
			}
			pReader.ReadProcess = myProcesses[0];

			// open process in read memory mode
			pReader.OpenProcess();
			
			int bytesReaded;
			int iWidth, iHeight, iMines;
			int iIsMine;
			int iCellAddress;
			byte[] memory;

			memory = pReader.ReadProcessMemory((IntPtr)iWidthAddress,1,out bytesReaded);
			iWidth = memory[0];
			txtWidth.Text = iWidth.ToString();
		
			memory = pReader.ReadProcessMemory((IntPtr)iHeightAddress,1,out bytesReaded);
			iHeight = memory[0];
			txtHeight.Text = iHeight.ToString();

			memory = pReader.ReadProcessMemory((IntPtr)iMinesAddress,1,out bytesReaded);
			iMines = memory[0];
			txtMines.Text = iMines.ToString();

			this.Controls.Clear();
			this.Controls.AddRange(MainControls);
			ButtonArray = new System.Windows.Forms.Button[iWidth,iHeight];
			int x,y;
			for (y=0 ; y<iHeight ; y++)
				for (x=0 ; x<iWidth ; x++)
				{
					ButtonArray[x,y] = new System.Windows.Forms.Button();
					ButtonArray[x,y].Location = new System.Drawing.Point(20 + x*16, 70 + y*16);
					ButtonArray[x,y].Name = "";
					ButtonArray[x,y].Size = new System.Drawing.Size(16,16);
					
					iCellAddress = (iCellBaseAddress) + (32 * (y+1)) + (x+1);
					memory = pReader.ReadProcessMemory((IntPtr)iCellAddress,1,out bytesReaded);
					iIsMine = memory[0];
			
					if (iIsMine == 0x8f)
                        ButtonArray[x,y].Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
			
					this.Controls.Add(ButtonArray[x,y]);
					
				}

			// close process handle
			pReader.CloseHandle();
			
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			MainControls = new Control[this.Controls.Count];
			this.Controls.CopyTo(MainControls,0);
		}

		
	}
}
