using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Text;

//I'll be using Microsoft's Cryptography Class
//for encryption purposes:

//All registration data is stored to windows
//Registry:

//I need UnicodeEncoding class of
//this namespace:

namespace SoftwareLock
{
	public partial class SoftwareLock
	{
		
		
		protected string _AppName;
		protected string _Password;
		protected HashAlgorithms _HashAlgorithm;
		protected string _DiskSerial;
		protected bool _isRegistered;
		protected RegistryHives _RegistryHive;
		protected string _RegistryBaseKey;
		protected string _RegistrySubKey;
		protected string _CustRef;
		protected string _SerialKey;
		protected int _CustRefLength;
		public RegistryHives RegistryHive
		{
			get
			{
				return _RegistryHive;
			}
			set
			{
				_RegistryHive = value;
			}
		}
		
		public enum HashAlgorithms
		{
			MD5 = 0,
			SHA1 = 1,
			SHA256 = 2,
			SHA384 = 3,
			SHA512 = 4
		}
		
		public enum RegistryHives
		{
			CURRENTUSER,
			LOCALMACHINE
		}
		
		public SoftwareLock()
		{
			_DiskSerial = HDDSerial.SerialNumber(HDDSerial.GetCurrentDrive());
			_CustRefLength = 20;
		}
		
		public string AppName
		{
			get
			{
				return _AppName;
			}
			set
			{
				_AppName = value;
			}
		}
		
		public string Password
		{
			get
			{
				return _Password;
			}
			set
			{
				_Password = value;
			}
		}
		
		//return of set HashAlgorithm for generating
		//Reference and serialkey
		public HashAlgorithms HashAlgorithm
		{
			get
			{
				return _HashAlgorithm;
			}
			set
			{
				_HashAlgorithm = value;
			}
		}
		
		//returns end-user's hard disk serial number
		public string HardDiskSerial
		{
			get
			{
				return _DiskSerial;
			}
		}
		
		//use this property to check if your software is registered
		public bool isRegistered
		{
			
			get
			{
				
				if (_RegistryBaseKey.Trim() == "")
				{
					throw (new Exception("Specify a BaseRegistryKey"));
				}
				
				try
				{
					Microsoft.Win32.RegistryKey objRegistry;
					switch (_RegistryHive)
					{
						case RegistryHives.CURRENTUSER:
							
							objRegistry = Registry.CurrentUser;
							break;
						case RegistryHives.LOCALMACHINE:
							
							objRegistry = Registry.LocalMachine;
							break;
						default:
							
							objRegistry = Registry.CurrentUser;
							break;
					}
					
					RegistryKey RK = objRegistry. OpenSubKey("Software\\" + _RegistryBaseKey);
					string SKey = RK.GetValue(_RegistrySubKey);
					if (SKey == SerialKey)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				catch (NullReferenceException)
				{
					return false;
				}
				
			}
			
		}
		
		//Base Registry key:
		//usually your software name
		public string RegistryBaseKey
		{
			get
			{
				return _RegistryBaseKey;
			}
			set
			{
				_RegistryBaseKey = value;
			}
		}
		
		//a sub key of BaseRegistryKey to store
		//the software's serial key
		public string RegistrySubKey
		{
			get
			{
				return _RegistrySubKey;
			}
			set
			{
				_RegistrySubKey = value;
			}
		}
		
		public int ReferenceLength
		{
			get
			{
				return _CustRefLength;
			}
			set
			{
				if (value >= 6 && value <= 20)
				{
					_CustRefLength = value;
				}
				else
				{
					throw (new Exception("ReferenceLength cannot be less than 6 or more than 20 characters"));
				}
			}
		}
		
		//use this method in your software's registration form's
		//OK button, and pass it the serial key entered by the end-user
		//as argument, returns True for a successful registration, False
		//for unsuccessful
		public bool Register(string strSerialKey)
		{
			GenerateCodes();
			
			Microsoft.Win32.RegistryKey objRegistry;
			switch (_RegistryHive)
			{
				
			case RegistryHives.CURRENTUSER:
				
				objRegistry = Registry.CurrentUser;
				break;
			case RegistryHives.LOCALMACHINE:
				
				objRegistry = Registry.LocalMachine;
				break;
			default:
				
				objRegistry = Registry.CurrentUser;
				break;
		}
		
		if (strSerialKey == _SerialKey)
		{
			RegistryKey RK = objRegistry. OpenSubKey("Software", true);
			RK.CreateSubKey(_RegistryBaseKey). SetValue(_RegistrySubKey, _SerialKey);
			return true;
		}
		else
		{
			return false;
		}
	}
	
	//returns customer reference based on appname,password,harddisk serial
	virtual public string Reference
	{
		get
		{
			GenerateCodes();
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
	
	//returns serial key based on Reference
	virtual public string SerialKey
	{
		get
		{
			GenerateCodes();
			return _SerialKey;
		}
	}
	
	public virtual bool CancelRegistration()
	{
		//you can use this function for testing purposes
		//should you need to remove any test entries from
		//the windows registry where registration information is stored
		
		RegistryKey objRegistry;
		switch (_RegistryHive)
		{
			case RegistryHives.CURRENTUSER:
				
				objRegistry = Registry.CurrentUser;
				break;
			case RegistryHives.LOCALMACHINE:
				
				objRegistry = Registry.LocalMachine;
				break;
			default:
				
				objRegistry = Registry.CurrentUser;
				break;
		}
		
		RegistryKey RK = objRegistry.OpenSubKey("Software", true);
		Interaction.MsgBox("The followinag key and all its subkeys will be deleted:" + "\r\n" + RK.ToString() + "\\" + _RegistryBaseKey, MsgBoxStyle.Information, null);
		RK.DeleteSubKeyTree(_RegistryBaseKey);
		
	}
	
	protected void GenerateCodes()
	{
		//generate Reference based on
		//appname,password,and harddisk serial
		//generate serial key based on Reference
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
		
		//generate hash using appname, password, and HD serial no.
		temp = _AppName + _Password + _DiskSerial;
		HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp));
		
		_CustRef = Convert.ToBase64String(HashBytes);
		//if longer than 20 chars, trim it to 20 chars
		if (_CustRef.Trim().Length > _CustRefLength)
		{
			_CustRef = _CustRef.Substring(0, _CustRefLength);
		}
		
		//convert it to upper case
		_CustRef = _CustRef.ToUpper();
		
		//clear the hash array
		Array.Clear(HashBytes, 0, HashBytes.Length);
		
		//use the above generated Reference to generate a 20 characters
		//serial key for the end user
		temp = _CustRef + _AppName + _Password;
		HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp));
		
		_SerialKey = Convert.ToBase64String(HashBytes);
		if (_SerialKey.Trim().Length > 20)
		{
			_SerialKey = _SerialKey.Substring(0, 20);
		}
		_SerialKey = _SerialKey.ToUpper();
		
	}
	
	
}

}
