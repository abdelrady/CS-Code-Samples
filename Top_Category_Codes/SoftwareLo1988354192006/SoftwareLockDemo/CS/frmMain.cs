using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

//This application demonstrates how to use SoftwareLock class
//to protect your software against illegal copying or un-authorised
//use.
//you can use the SofwareLock class, the DLL, or any snippet from
//this project anywhere you like, but giving me credit where credit
//is due, is always a good idea!

//PLEASE NOTE THAT: before running this program you need to click on
//SoftwareLock.vb file in the solutions explorer and then click
//Build to build SoftwareLock.dll, referenced in this project.


namespace SoftwareLockDemo
{
	public partial class frmMain
	{
		
		#region Default Instance
		
		private static frmMain defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmMain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmMain();
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
		
		public frmMain()
		{
			
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
			
			// Add any initialization after the InitializeComponent() call.
			
			//WE NEED TO SET UP A FEW PROPERTIES OF THE SOFTWARELOCK OBJECT,
			//AND THE BEST PLACE TO DO THIS IS IN THE MAIN FORM'S CONSTRUCTOR:
			
			//SL is the SoftwareLock object, declared as Public in Module1.vb
			//and has global scope in the project
			
			//Name of application
			Module1.SL.AppName = "mysoftware";
			//password for the application
			Module1.SL.Password = "mypassword";
			//HashAlgorithm used for encryption: I am using MD5!
			Module1.SL.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.MD5;
			//Length of Reference we want to provide to the end-user
			//between 6 and 20 characters
			Module1.SL.ReferenceLength = 6;
			//Base Registry Key where registration information is stored
			//usually its "CompanyName\ProductName"
			Module1.SL.RegistryBaseKey = "AFTech\\SoftwareLockDemo";
			//Subkey of Base Registry Key to store end-user's Serial Key
			Module1.SL.RegistrySubKey = "SerialNo";
			//THAT's IT!
		}
		
		
		private void frmMain_Load(System.Object sender, System.EventArgs e)
		{
			
			//in application's main form's load event we have to check if
			//the program is registered if yes, we give the end-user full
			//access to all program features, if not we prompt the user for
			//registration, this is done by checking the isRegistered property
			if (Module1.SL.isRegistered == true)
			{
				Label1.Text = "Software registered." + "\r\n" + "Your Serial Key is:  " + Module1.SL.SerialKey + "\r\n" + "You now have full access to all program features!";
				Button1.Text = "Cancel Registration";
			}
			else
			{
				Label1.Text = "Software not registered.";
				Button1.Text = "Register";
			}
			
		}
		
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			Button btn;
			btn = (Button) sender;
			if (btn.Text == "Register")
			{
				frmRegister.Default.ShowDialog();
			}
			else
			{
				//CancelRegistration() method is for testing purposes, should u
				//wish to delete any test registration data from the windows
				//registry, or maybe you can use it to un-register the software
				//if the end-user does something you don't like!!! LOL!...
				//anyways, it returns true if successful and vice-versa
				if (Module1.SL.CancelRegistration())
				{
					Label1.Text = "Software not registered.";
					btn.Text = "Register";
				}
			}
		}
		
		
	}
}
