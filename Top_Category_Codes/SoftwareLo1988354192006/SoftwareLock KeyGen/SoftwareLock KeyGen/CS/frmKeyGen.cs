using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace SoftwareLock_KeyGen
{
	public partial class frmKeyGen
	{
		public frmKeyGen()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static frmKeyGen defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmKeyGen Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmKeyGen();
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
		
		SoftwareLockKeyGen SLGen = new SoftwareLockKeyGen();
		
		private void btnGenKey_Click(System.Object sender, System.EventArgs e)
		{
			
			try
			{
				SLGen.AppName = txtAppName.Text;
				SLGen.Password = txtAppPassword.Text;
				SLGen.Reference = txtCustRef.Text;
				
				switch (true)
				{
					default:
						if (true == rbSHA512.Checked)
						{
							
							SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA512;
							break;
						}
						if (true == rbSHA384.Checked)
						{
							
							SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA384;
							break;
						}
						if (true == rbSHA256.Checked)
						{
							
							SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA256;
							break;
						}
						if (true == rbSHA1.Checked)
						{
							
							SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA1;
							break;
						}
						if (true == rbMD5.Checked)
						{
							
							SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.MD5;
							break;
						}
				}
				
				txtSerialKey.Text = SLGen.FormatSerialKey(Strings.Space(1));
				//if Reference Length is less than 6 or more than 20 chars
				//SoftwareLock will throw an exception
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			if (chkSaveToFile.Checked)
			{
				string FileName = (new Microsoft.VisualBasic.Devices.Computer().FileSystem. CurrentDirectory + "\\" + SLGen.Reference + ".key");
				string SerialKey = SLGen.SerialKey;
				System.IO.File.WriteAllText(FileName, SerialKey, (System.Text.Encoding) false);
			}
		}
		
		
		
	}
	
	
	public partial class SoftwareLockKeyGen : SoftwareLock.SoftwareLock
	{
		
		
		public override string Reference
		{
			get
			{
				return _CustRef;
			}
			set
			{
				if (value.Length >= 6 && value.Length <= 20)
				{
					_CustRef = value;
				}
				else
				{
					throw (new Exception("Reference cannot be less than 6 or more than 20 characters"));
				}
			}
		}
		
		public override string SerialKey
		{
			get
			{
				//generate serial key based on the supplied Reference
				HashAlgorithm Hash;
				byte[] HashBytes;
				UnicodeEncoding UNIEncoding = new UnicodeEncoding();
				string temp;
				
				//load the user selected hash-algorithm
				switch (_HashAlgorithm)
				{
					case HashAlgorithms.MD5:
						
						Hash = new MD5CryptoServiceProvider();
						break;
					case HashAlgorithms.SHA1:
						
						Hash = new SHA1CryptoServiceProvider();
						break;
					case HashAlgorithms.SHA256:
						
						Hash = new SHA256Managed();
						break;
					case HashAlgorithms.SHA384:
						
						Hash = new SHA384Managed();
						break;
					case HashAlgorithms.SHA512:
						
						Hash = new SHA512Managed();
						break;
					default: //default hash algorithm
						
						Hash = new MD5CryptoServiceProvider();
						break;
				}
				
				//convert it to upper case
				_CustRef = _CustRef.ToUpper();
				
				//use the supplied Reference to generate a 20 characters
				//serial key for the end user
				temp = _CustRef + _AppName + _Password;
				HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp));
				
				_SerialKey = Convert.ToBase64String(HashBytes);
				if (_SerialKey.Trim().Length > 20)
				{
					_SerialKey = _SerialKey.Substring(0, 20);
				}
				return _SerialKey.ToUpper();
			}
		}
		
		public string FormatSerialKey(string Separator)
		{
			string[] parts = new string[4];
			parts[0] = this.SerialKey.Substring(0, 5) + Separator;
			parts[1] = this.SerialKey.Substring(5, 5) + Separator;
			parts[2] = this.SerialKey.Substring(10, 5) + Separator;
			parts[3] = this.SerialKey.Substring(15, 5);
			
			return parts[0] + parts[1] + parts[2] + parts[3];
		}
	}
}
