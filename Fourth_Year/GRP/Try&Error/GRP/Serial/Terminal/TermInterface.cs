/*=============================================================================
 File:			TermInterface.cs			Serial terminal interface class. 
 
				Provides a composite class consisting of the serial base class, 
				supporting Win32xxx wrapper classes, and the user defined port
				configuration class. Also controls the terminal & setup forms.

 Created:		1.00	10/27/03	TJK		Timothy J. Krell	(SAIC)

 Version:		1.00

 Revisions:		1.00	10/27/03	TJK		Initial Release.

 Copyright(c)	2001, Science Applications International Corporation (SAIC)
				All Rights Reserved. Sponsored by the U.S. Government under
				Contract #DAAH01-00-D-0013/10. This software may be reproduced
				by or for the US Government pursuant to the copyright license
				under clause at DFARS 252.227-7014 (June 1995).
=============================================================================*/

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SerialPorts;

namespace SerialTerminal
{
	/// <summary>
	/// Serial terminal interface class. Provides a composite class consisting of 
	/// the serial communications class and supporting Win32xxx wrapper classes, 
	/// the user configuration class and the serial terminal and settings forms.
	/// </summary>
	public class TermInterface : SerialComm
	{
		public static TermInterface Port;
		public static Terminal Term;
		public static SerialCnfg Config;

		public static string configFile = "Port";
		public static string configExt  = ".cfg";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static int Main() 
		{
			Port = new TermInterface();
			Term = new Terminal();
			Application.Run(Term);
			return 0;
		}

		/// <summary>
		/// Setup the com port.
		/// </summary>
		public void LoadSetup(int index)
		{
			Config = new SerialCnfg(index);
			string fileName = configFile + index.ToString() + configExt;

			FileInfo fi = new FileInfo(fileName);
			if(fi.Exists)
			{
				Config.Load(fileName);
			}
			else
			{
				Config.SetFlowControl();
			}
			return;
		}

		/// <summary>
		/// Setup the com port.
		/// </summary>
		public void SaveSetup(int index)
		{
			string fileName = configFile + index.ToString() + configExt;
			Config.Save(fileName);
			return;
		}

		/// <summary>
		/// Setup the com port.
		/// </summary>
		public void ChngSetup(int index)
		{
			string fileName = configFile + index.ToString() + configExt;
			if(Config == null)
			{
				this.LoadSetup(index);
			}
			Settings frm = new Settings(fileName, Config);
			frm.ShowDialog();
			return;
		}

		/// <summary>
		/// Send extended escape code.
		/// </summary>
		public bool SendEsc(ExtCodes code)
		{
			return this.SendE(code);
		}

		/// <summary>
		/// Send string.
		/// </summary>
		public uint SendStr(string s)
		{
			byte[] b = new byte[s.Length];
			b = Encoding.ASCII.GetBytes(s);
			return this.Send(b);
		}

		/// <summary>
		/// Send buffer.
		/// </summary>
		public uint SendBuf(byte[] b)
		{
			return this.Send(b);
		}

		/// <summary>
		/// Override method to handle a character receive event.
		/// </summary>
		protected override void OnRxChar(byte[] b)
		{
			Term.RxByte(b);
		}
	
		/// <summary>
		/// Override method to handle a change to any modem signal state.
		/// </summary>
		protected override void OnSignal(bool cts, bool dsr, bool rlsd, bool ring)
		{
			Term.SetIndicators(cts, dsr, rlsd, ring);
		}
	}
}

