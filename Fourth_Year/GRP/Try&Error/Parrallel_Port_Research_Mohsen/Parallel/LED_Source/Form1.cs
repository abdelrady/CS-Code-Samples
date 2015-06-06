/* -----------------------------------------------------------------
 * 
 * LED initialization code written by Levent S. 
 * E-mail: ls@izdir.com
 * 
 * This code is provided without implied warranty so the author is
 * not responsible about damages by the use of the code.
 * 
 * You can use this code for any purpose even in any commercial 
 * distributions by referencing my name. 
 * 
 * ! Don't remove or alter this notice in any distribution !
 * 
 * -----------------------------------------------------------------*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Timers;

namespace Led
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button_Send_Bits;
		private System.Windows.Forms.CheckBox checkBox_Pin1;
		private System.Windows.Forms.CheckBox checkBox_Pin2;
		private System.Windows.Forms.CheckBox checkBox_Pin3;
		private System.Windows.Forms.CheckBox checkBox_Pin6;
		private System.Windows.Forms.CheckBox checkBox_Pin5;
		private System.Windows.Forms.CheckBox checkBox_Pin4;
		private System.Windows.Forms.CheckBox checkBox_Pin8;
		private System.Windows.Forms.CheckBox checkBox_Pin7;
		private System.Windows.Forms.Button button_Reset_Leds;
		private System.Windows.Forms.Label Not;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button button_Count;
		private System.Windows.Forms.PictureBox pictureBox_D7;
		private System.Windows.Forms.PictureBox pictureBox_D6;
		private System.Windows.Forms.PictureBox pictureBox_D5;
		private System.Windows.Forms.PictureBox pictureBox_D4;
		private System.Windows.Forms.PictureBox pictureBox_D3;
		private System.Windows.Forms.PictureBox pictureBox_D2;
		private System.Windows.Forms.PictureBox pictureBox_D1;
		private System.Windows.Forms.PictureBox pictureBox_D0;
		private System.Windows.Forms.TextBox textBox_byte;
		private System.Windows.Forms.TextBox textBox_port_adress;
		private System.Windows.Forms.Button button_Address;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button_Dance;
		public int i=0, j=0, adress = 888;


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();
			Reset_LEDs(); // Resets everything after form initialization
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
			this.button_Send_Bits = new System.Windows.Forms.Button();
			this.checkBox_Pin1 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin2 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin3 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin6 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin5 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin4 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin8 = new System.Windows.Forms.CheckBox();
			this.checkBox_Pin7 = new System.Windows.Forms.CheckBox();
			this.button_Reset_Leds = new System.Windows.Forms.Button();
			this.Not = new System.Windows.Forms.Label();
			this.button_Count = new System.Windows.Forms.Button();
			this.button_Dance = new System.Windows.Forms.Button();
			this.pictureBox_D7 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D6 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D5 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D4 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D3 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D2 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D1 = new System.Windows.Forms.PictureBox();
			this.pictureBox_D0 = new System.Windows.Forms.PictureBox();
			this.textBox_byte = new System.Windows.Forms.TextBox();
			this.textBox_port_adress = new System.Windows.Forms.TextBox();
			this.button_Address = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			/* You can use this loop if you don't have a gui anxiety
			for(int i=0;i<8;i++)
			{
				Checkboxes[i] = new CheckBox();
				Checkboxes[i].Location = new Point(i * 50 + 14, 14);
				Checkboxes[i].Width = 50;
				Checkboxes[i].Text = (i + 1).ToString();
				Checkboxes[i].Tag = i;
				Checkboxes[i].CheckedChanged += new EventHandler(onCheckBoxClick);
				Controls.Add(boxes[i]);
			}
			*/
			
			// 
			// button_Send_Bits
			// 
			this.button_Send_Bits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Send_Bits.Location = new System.Drawing.Point(392, 72);
			this.button_Send_Bits.Name = "button_Send_Bits";
			this.button_Send_Bits.Size = new System.Drawing.Size(48, 23);
			this.button_Send_Bits.TabIndex = 0;
			this.button_Send_Bits.Text = "Send";
			this.button_Send_Bits.Click += new System.EventHandler(this.button_Send_Bits_Click);
			// 
			// checkBox_Pin1
			// 
			this.checkBox_Pin1.Location = new System.Drawing.Point(400, 40);
			this.checkBox_Pin1.Name = "checkBox_Pin1";
			this.checkBox_Pin1.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin1.TabIndex = 1;
			this.checkBox_Pin1.Text = "D0";
			this.checkBox_Pin1.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin2
			// 
			this.checkBox_Pin2.Location = new System.Drawing.Point(344, 40);
			this.checkBox_Pin2.Name = "checkBox_Pin2";
			this.checkBox_Pin2.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin2.TabIndex = 2;
			this.checkBox_Pin2.Text = "D1";
			this.checkBox_Pin2.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin3
			// 
			this.checkBox_Pin3.Location = new System.Drawing.Point(288, 40);
			this.checkBox_Pin3.Name = "checkBox_Pin3";
			this.checkBox_Pin3.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin3.TabIndex = 3;
			this.checkBox_Pin3.Text = "D2";
			this.checkBox_Pin3.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin6
			// 
			this.checkBox_Pin6.Location = new System.Drawing.Point(120, 40);
			this.checkBox_Pin6.Name = "checkBox_Pin6";
			this.checkBox_Pin6.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin6.TabIndex = 6;
			this.checkBox_Pin6.Text = "D5";
			this.checkBox_Pin6.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin5
			// 
			this.checkBox_Pin5.Location = new System.Drawing.Point(176, 40);
			this.checkBox_Pin5.Name = "checkBox_Pin5";
			this.checkBox_Pin5.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin5.TabIndex = 5;
			this.checkBox_Pin5.Text = "D4";
			this.checkBox_Pin5.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin4
			// 
			this.checkBox_Pin4.Location = new System.Drawing.Point(232, 40);
			this.checkBox_Pin4.Name = "checkBox_Pin4";
			this.checkBox_Pin4.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin4.TabIndex = 4;
			this.checkBox_Pin4.Text = "D3";
			this.checkBox_Pin4.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin8
			// 
			this.checkBox_Pin8.Location = new System.Drawing.Point(8, 40);
			this.checkBox_Pin8.Name = "checkBox_Pin8";
			this.checkBox_Pin8.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin8.TabIndex = 8;
			this.checkBox_Pin8.Text = "D7";
			this.checkBox_Pin8.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// checkBox_Pin7
			// 
			this.checkBox_Pin7.Location = new System.Drawing.Point(64, 40);
			this.checkBox_Pin7.Name = "checkBox_Pin7";
			this.checkBox_Pin7.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Pin7.TabIndex = 7;
			this.checkBox_Pin7.Text = "D6";
			this.checkBox_Pin7.CheckedChanged += new System.EventHandler(this.onCheckBoxClick);
			// 
			// button_Reset_Leds
			// 
			this.button_Reset_Leds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Reset_Leds.Location = new System.Drawing.Point(368, 104);
			this.button_Reset_Leds.Name = "button_Reset_Leds";
			this.button_Reset_Leds.TabIndex = 9;
			this.button_Reset_Leds.Text = "Reset Leds";
			this.button_Reset_Leds.Click += new System.EventHandler(this.button_Reset_Leds_Click);
			// 
			// Not
			// 
			this.Not.Location = new System.Drawing.Point(0, 72);
			this.Not.Name = "Not";
			this.Not.Size = new System.Drawing.Size(320, 32);
			this.Not.TabIndex = 10;
			this.Not.Text = "Not: You can send data with checkboxes in bit form or you can send data with byte" +
				" (8 bits) form by writing in decimal box... -->";
			// 
			// button_Count
			// 
			this.button_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Count.Location = new System.Drawing.Point(264, 104);
			this.button_Count.Name = "button_Count";
			this.button_Count.Size = new System.Drawing.Size(96, 23);
			this.button_Count.TabIndex = 11;
			this.button_Count.Text = "Count in Binary";
			this.button_Count.Click += new System.EventHandler(this.button_Count_Click);
			// 
			// button_Dance
			// 
			this.button_Dance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Dance.Location = new System.Drawing.Point(176, 104);
			this.button_Dance.Name = "button_Dance";
			this.button_Dance.Size = new System.Drawing.Size(80, 23);
			this.button_Dance.TabIndex = 12;
			this.button_Dance.Text = "Dance Lights";
			this.button_Dance.Click += new System.EventHandler(this.button_Dance_Click);
			// 
			// pictureBox_D7
			// 
			this.pictureBox_D7.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D7.Image")));
			this.pictureBox_D7.Location = new System.Drawing.Point(16, 8);
			this.pictureBox_D7.Name = "pictureBox_D7";
			this.pictureBox_D7.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D7.TabIndex = 13;
			this.pictureBox_D7.TabStop = false;
			// 
			// pictureBox_D6
			// 
			this.pictureBox_D6.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D6.Image")));
			this.pictureBox_D6.Location = new System.Drawing.Point(72, 8);
			this.pictureBox_D6.Name = "pictureBox_D6";
			this.pictureBox_D6.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D6.TabIndex = 14;
			this.pictureBox_D6.TabStop = false;
			// 
			// pictureBox_D5
			// 
			this.pictureBox_D5.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D5.Image")));
			this.pictureBox_D5.Location = new System.Drawing.Point(128, 8);
			this.pictureBox_D5.Name = "pictureBox_D5";
			this.pictureBox_D5.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D5.TabIndex = 15;
			this.pictureBox_D5.TabStop = false;
			// 
			// pictureBox_D4
			// 
			this.pictureBox_D4.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D4.Image")));
			this.pictureBox_D4.Location = new System.Drawing.Point(184, 8);
			this.pictureBox_D4.Name = "pictureBox_D4";
			this.pictureBox_D4.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D4.TabIndex = 16;
			this.pictureBox_D4.TabStop = false;
			// 
			// pictureBox_D3
			// 
			this.pictureBox_D3.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D3.Image")));
			this.pictureBox_D3.Location = new System.Drawing.Point(240, 8);
			this.pictureBox_D3.Name = "pictureBox_D3";
			this.pictureBox_D3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D3.TabIndex = 17;
			this.pictureBox_D3.TabStop = false;
			// 
			// pictureBox_D2
			// 
			this.pictureBox_D2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D2.Image")));
			this.pictureBox_D2.Location = new System.Drawing.Point(288, 8);
			this.pictureBox_D2.Name = "pictureBox_D2";
			this.pictureBox_D2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D2.TabIndex = 18;
			this.pictureBox_D2.TabStop = false;
			// 
			// pictureBox_D1
			// 
			this.pictureBox_D1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D1.Image")));
			this.pictureBox_D1.Location = new System.Drawing.Point(344, 8);
			this.pictureBox_D1.Name = "pictureBox_D1";
			this.pictureBox_D1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D1.TabIndex = 19;
			this.pictureBox_D1.TabStop = false;
			// 
			// pictureBox_D0
			// 
			this.pictureBox_D0.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox_D0.Image")));
			this.pictureBox_D0.Location = new System.Drawing.Point(400, 8);
			this.pictureBox_D0.Name = "pictureBox_D0";
			this.pictureBox_D0.Size = new System.Drawing.Size(24, 24);
			this.pictureBox_D0.TabIndex = 20;
			this.pictureBox_D0.TabStop = false;
			// 
			// textBox_byte
			// 
			this.textBox_byte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_byte.Location = new System.Drawing.Point(320, 74);
			this.textBox_byte.Name = "textBox_byte";
			this.textBox_byte.Size = new System.Drawing.Size(64, 20);
			this.textBox_byte.TabIndex = 21;
			this.textBox_byte.Text = "170";
			// 
			// textBox_port_adress
			// 
			this.textBox_port_adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_port_adress.Location = new System.Drawing.Point(8, 106);
			this.textBox_port_adress.Name = "textBox_port_adress";
			this.textBox_port_adress.Size = new System.Drawing.Size(64, 20);
			this.textBox_port_adress.TabIndex = 22;
			this.textBox_port_adress.Text = "378";
			// 
			// button_Address
			// 
			this.button_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Address.Location = new System.Drawing.Point(80, 104);
			this.button_Address.Name = "button_Address";
			this.button_Address.Size = new System.Drawing.Size(88, 23);
			this.button_Address.TabIndex = 23;
			this.button_Address.Text = "Apply Address";
			this.button_Address.Click += new System.EventHandler(this.button_Address_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkColor = System.Drawing.Color.Green;
			this.linkLabel1.Location = new System.Drawing.Point(320, 136);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(144, 16);
			this.linkLabel1.TabIndex = 24;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Programmed By Levent S.";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 149);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.linkLabel1,
																		  this.button_Address,
																		  this.textBox_port_adress,
																		  this.textBox_byte,
																		  this.pictureBox_D0,
																		  this.pictureBox_D1,
																		  this.pictureBox_D2,
																		  this.pictureBox_D3,
																		  this.pictureBox_D4,
																		  this.pictureBox_D5,
																		  this.pictureBox_D6,
																		  this.pictureBox_D7,
																		  this.button_Dance,
																		  this.button_Count,
																		  this.Not,
																		  this.button_Reset_Leds,
																		  this.checkBox_Pin8,
																		  this.checkBox_Pin7,
																		  this.checkBox_Pin6,
																		  this.checkBox_Pin5,
																		  this.checkBox_Pin4,
																		  this.checkBox_Pin3,
																		  this.checkBox_Pin2,
																		  this.checkBox_Pin1,
																		  this.button_Send_Bits});
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Controlling LEDs with Parallel Port";
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
 
        private void Reset_LEDs() // Makes all the data pins low so the LED's turned off
		{
			PortAccess.Output(adress, 0);
		}
		
		
		#region LED Picture Loadings
		private void LoadNewPict_D0()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D0.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D1()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D1.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D2()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D2.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D3()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D3.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D4()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D4.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D5()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D5.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D6()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D6.Image = Image.FromFile (path);
		}

		private void LoadNewPict_D7()
		{
			
			string path = @"C:\C#\LED\on.gif";
			this.pictureBox_D7.Image = Image.FromFile (path);
		}
		
		
		private void LoadOldPict_D0()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D0.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D1()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D1.Image = Image.FromFile (path);
		}
		
		private void LoadOldPict_D2()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D2.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D3()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D3.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D4()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D4.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D5()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D5.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D6()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D6.Image = Image.FromFile (path);
		}

		private void LoadOldPict_D7()
		{
			
			string path = @"C:\C#\LED\off.gif";
			this.pictureBox_D7.Image = Image.FromFile (path);
		}
		
		#endregion 
		
		void onCheckBoxClick(object sender, EventArgs e) //For checkboxes and the imageboxes you can also use a loop here
		{
			int value = 0;

			if(checkBox_Pin1.Checked)
			{
				value += (int)Math.Pow(2,0);
				LoadNewPict_D0();
			}
			else
				LoadOldPict_D0();
				value += 0;

			if(checkBox_Pin2.Checked)
			{
				value += (int)Math.Pow(2,1);
				LoadNewPict_D1();
			}
			else
				LoadOldPict_D1();
				value += 0;
			
			if(checkBox_Pin3.Checked)
			{
				value += (int)Math.Pow(2,2);
				LoadNewPict_D2();
			}
			else
				LoadOldPict_D2();
				value += 0;
				
			if(checkBox_Pin4.Checked)
			{
				value += (int)Math.Pow(2,3);
				LoadNewPict_D3();
			}
			else
				LoadOldPict_D3();
				value += 0;
				
			if(checkBox_Pin5.Checked)
			{
				value += (int)Math.Pow(2,4);
				LoadNewPict_D4();
			}
			else
				LoadOldPict_D4();
				value += 0;
				
			if(checkBox_Pin6.Checked)
			{
				value += (int)Math.Pow(2,5);
				LoadNewPict_D5();
			}
			else
				LoadOldPict_D5();
				value += 0;
			
			if(checkBox_Pin7.Checked)
			{
				value += (int)Math.Pow(2,6);
				LoadNewPict_D6();
			}
			else
				LoadOldPict_D6();
				value += 0;
				
			if(checkBox_Pin8.Checked)
			{
				value += (int)Math.Pow(2,7);
				LoadNewPict_D7();
			}
			else
				LoadOldPict_D7();
				value += 0;


			PortAccess.Output(adress, value);
		}
		

		private void button_Send_Bits_Click(object sender, System.EventArgs e) // Sends decimal to data pins
		{
			PortAccess.Output(adress, Int32.Parse(this.textBox_byte.Text));
		}

		private void button_Reset_Leds_Click(object sender, System.EventArgs e) // Unchecks the checkboxes and reset leds
		{
			j=0; i=0;
			Reset_LEDs();
			checkBox_Pin8.Checked = false;
			checkBox_Pin7.Checked = false;
			checkBox_Pin6.Checked = false;
			checkBox_Pin5.Checked = false;
			checkBox_Pin4.Checked = false;
			checkBox_Pin3.Checked = false;
			checkBox_Pin2.Checked = false;
			checkBox_Pin1.Checked = false;
		}

		void dance_LEDs(object o2, EventArgs e2) //Gives a motion to the LEDs
		{
			if(j<9)
			{
				switch(j)
				{
					case 0:
						PortAccess.Output(888, 24);
						break;
					case 1:
						PortAccess.Output(888, 36);
						break;
					case 2:
						PortAccess.Output(888, 66);
						break;
					case 3:
						PortAccess.Output(888, 129);
						break;
					case 4:
						PortAccess.Output(888, 0);
						break;
					case 5:
						PortAccess.Output(888, 129);
						break;
					case 6:
						PortAccess.Output(888, 195);
						break;
					case 7:
						PortAccess.Output(888, 231);
						break;
					case 8:
						PortAccess.Output(888, 255);
						break;
				}
			}
			else
			{
				((System.Windows.Forms.Timer)o2).Stop();
				((System.Windows.Forms.Timer)o2).Tick -= new EventHandler(dance_LEDs);
			}
			j+=1;
		}
		
		
		private void button_Dance_Click(object sender, System.EventArgs e) // Executes the timer and dance LEDs function
		{
			System.Windows.Forms.Timer timer02 = new System.Windows.Forms.Timer();
			timer02.Interval = 200;
			timer02.Tick += new EventHandler(dance_LEDs);
			timer02.Enabled = true;

		}

		void count_binary(object o1, EventArgs e1) //Makes the leds counting in binary form
		{
			
			if(i<256)
			{
				PortAccess.Output(adress, i);
				i+=1;
			}
			else
			{
				((System.Windows.Forms.Timer)o1).Stop();
				((System.Windows.Forms.Timer)o1).Tick -= new EventHandler(count_binary);
			}
		}

		private void button_Count_Click(object sender, System.EventArgs e) //Activates the timer for bnary counting delays
		{
			System.Windows.Forms.Timer timer01 = new System.Windows.Forms.Timer();
			timer01.Interval = 100;
			timer01.Tick += new EventHandler(count_binary);
			timer01.Enabled = true;
		}

		private void button_Address_Click(object sender, System.EventArgs e) //Sets the parallel port address for the program to run
		{
			if(this.textBox_port_adress.Text == "378")
				adress = 888;
			else
				adress = 632;
		}

		private void linkLabel1_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Change the color of the link text by setting LinkVisited 
			// to True.
			linkLabel1.LinkVisited = true;
   
			// Call the Process.Start method to open the default browser 
			// with a URL:
			System.Diagnostics.Process.Start("mailto:ls@izdir.com");
		}
	
	}
}
