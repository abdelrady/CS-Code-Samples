using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;

namespace SoftwareLock
{
	sealed class HDDSerial
	{
		
		[DllImport("Kernel32",EntryPoint="GetVolumeInformationA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
		
		//this function returns the specified logical drive's serial no.
		//if no drive parameter is specified it returns drive C:\'s serial.
		//u can use the function GetCurrentDrive() below to retrieve current
		//drive for the Drive parameter
		public static string SerialNumber(string Drive)
		{
			int Serial; //Serialno
			string VName;
			string FSName;
			//Create buffers
			VName = new string('\0', 255); //Volume name
			FSName = new string('\0', 255); //File system
			
			//Get the volume information
			GetVolumeInformation(Drive, VName, 255, ref Serial, 0, 0, FSName, 255);
			//Strip the extra chr$(0)'s
			VName = Microsoft.VisualBasic.Left(VName, Strings.InStr(1, VName, '\0', 0) - 1);
			FSName = Microsoft.VisualBasic.Left(FSName, Strings.InStr(1, FSName, '\0', 0) - 1);
			//Return Trim(Str(Serial))
			return Serial.ToString().Trim();
		}
		
		public static string GetCurrentDrive()
		{
			string returnValue;
			returnValue = System.IO.Directory.GetCurrentDirectory().Substring(0, 3);
			return returnValue;
		}
		
	}
	
}
