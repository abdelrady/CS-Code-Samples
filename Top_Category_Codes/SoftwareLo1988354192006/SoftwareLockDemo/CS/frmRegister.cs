using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;


namespace SoftwareLockDemo
{
	public partial class frmRegister
	{
		public frmRegister()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static frmRegister defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmRegister Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmRegister();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			
			//Reference property is a customer reference which is generated
			//by SoftwareLock using your supplied AppName, Password,and the
			//end-user's Hard Disk Serial No.
			//We need to display Reference to the end-user so they can
			//quote it to us, and using that Reference we use the keygen
			//program supplied to give end-user his/her serial key
			lblCustRef.Text = Module1.SL.Reference;
		}
		
		
		private void btnRegister_Click(System.Object sender, System.EventArgs e)
		{
			
			//The text typed in the textboxes by the customer is concatenated and passed to
			//the Register() method of the SoftwareLock object, it returns
			//a boolean value of True if the correct key was entered by the
			//end user, or vice-versa:
			bool Successful;
			Successful = Module1.SL.Register(txtSK1.Text + txtSK2.Text + txtSK3.Text + txtSK4.Text);
			
			if (Successful == true)
			{
				MessageBox.Show("Software successfully registered. Thank You!");
				frmMain.Default.Label1.Text = "Software registered." + "\r\n" + "Your Serial Key is:  " + Module1.SL.SerialKey;
				frmMain.Default.Button1.Text = "Cancel Registration";
				
			}
			else
			{
				MessageBox.Show("There was an error registering your software" + "\r\n" + "Make sure you have quoted the correct reference to" + "\r\n" + "the program\'s vendor and obtained the correct Serial Key.");
			}
		}
		
		
		private void txtSK1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			//This is just to give our program a professional look and feel
			//and has nothing to do with SoftwareLock:
			//if 5 characters are typed into one of the serial-key textboxes then
			//the focus is automatically shifted to the next textbox
			TextBox txt;
			txt = (TextBox) sender;
			
			if (txt.Text.Length == 5)
			{
				switch (true)
				{
					default:
						if (true == sender.Equals(txtSK4))
						{
							
							e.Handled = true;
							btnRegister.Focus();
							break;
						}
						if (true == sender.Equals(txtSK3))
						{
							
							e.Handled = true;
							txtSK4.Focus();
							break;
						}
						if (true == sender.Equals(txtSK2))
						{
							
							e.Handled = true;
							txtSK3.Focus();
							break;
						}
						if (true == sender.Equals(txtSK1))
						{
							
							e.Handled = true;
							txtSK2.Focus();
							break;
						}
				}
				
				break;
			}
			else if (txt.Text.Length == 0)
			{
				switch (true)
				{
					default:
						if (true == sender.Equals(txtSK2))
						{
							
							e.Handled = true;
							txtSK1.Focus();
							break;
						}
						if (true == sender.Equals(txtSK3))
						{
							
							e.Handled = true;
							txtSK2.Focus();
							break;
						}
						if (true == sender.Equals(txtSK4))
						{
							
							e.Handled = true;
							txtSK3.Focus();
							break;
						}
				}
			}
		}
		
		
	}
	
}
