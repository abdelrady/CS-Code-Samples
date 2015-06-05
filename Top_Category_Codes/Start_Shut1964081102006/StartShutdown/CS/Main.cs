using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.IO;

///''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
//
// Copyright © 2005-2006 Herbert N. Swearengen III
// All Rights Reserved.
//
///''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


namespace StartShutdown
{
	public partial class Main
	{
		public Main()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static Main defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Main Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Main();
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
		private int mintSeconds;
		private bool mblnBeeps;
		private const string Msg1 = "This computer is scheduled to shutdown in ";
		private const string Msg2 = " minutes. Click to cancel.";
		private const string Msg3 = " seconds. Click to cancel.";
		
		private void Main_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == Strings.Chr(System.Convert.ToInt32(Keys.Escape)))
			{
				this.Close();
			}
		}
		
		private void Main_Load(System.Object sender, System.EventArgs e)
		{
			// set label
			lblWarning.Text = Msg1 + "3:00" + Msg2;
			
			if (My.Item["Beep"].ToString == "False")
			{
				mblnBeeps = false;
				chkDisableBeeps.Checked = true;
			}
			else if (My.Item["Beep"].ToString == "True")
			{
				mblnBeeps = true;
				chkDisableBeeps.Checked = false;
			}
			
		}
		
		private void cmdCancel_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void chkDisableBeeps_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (chkDisableBeeps.Checked == true)
			{
				mblnBeeps = false;
				Item["Beep"] = "False";
				Save[];
			}
			else if (chkDisableBeeps.Checked == false)
			{
				mblnBeeps = true;
				Item["Beep"] = "True";
				Save[];
			}
		}
		
		private void tmrShutdown_Tick(System.Object sender, System.EventArgs e)
		{
			string strSeconds;
			mintSeconds++;
			
			// if beeps are enabled, beep every 10 seconds
			if (mblnBeeps == true)
			{
				strSeconds = mintSeconds.ToString();
				if (strSeconds.Substring(strSeconds.Length - 1) == "0")
				{
					(new Microsoft.VisualBasic.Devices.Audio()).Play(My.Resources.Resources.Beep, AudioPlayMode.Background);
				}
			}
			
			if (mintSeconds == 180)
			{
				tmrShutdown.Enabled = false;
				Shutdown();
			}
			else if (mintSeconds <= 120)
			{
				prgShutdown.Value = mintSeconds;
				lblWarning.Text = Msg1 + FormatShortTime(180 - mintSeconds) + Msg2;
			}
			else if (mintSeconds > 120)
			{
				prgShutdown.Value = mintSeconds;
				lblWarning.Text = Msg1 + FormatShortTime(180 - mintSeconds) + Msg3;
			}
		}
		
		private void Shutdown()
		{
			try
			{
				// Now shutdown
				ProcessStartInfo startInfo = new ProcessStartInfo("c:\\windows\\system32\\shutdown.exe", " -s -t 5");
				startInfo.WindowStyle = ProcessWindowStyle.Normal;
				Process.Start(startInfo);
				
				try
				{
					// Write to the event log
					(new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Log.WriteEntry("Shutdown Initiated", TraceEventType.Information);
				}
				catch (Exception exp)
				{
					MessageBox.Show("An error occurred writing to the System Application Log." + "\r\n" + "\r\n" + "The system returned the following information:" + "\r\n" + "\r\n" + exp.Message, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				// now close this application
				this.Close();
			}
			catch (Exception)
			{
				// Write to the event log
				(new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Log.WriteEntry("Failed to Initiate shutdown.", TraceEventType.Error);
			}
		}
		
		public string FormatShortTime(int intInSeconds)
		{
			// returns time formatted as mm:ss, all digits returned, leading zeros retained, from seconds
			int intMinutes;
			int intSeconds;
			string strMinutes;
			string strSeconds;
			
			try
			{
				// initialize variables
				strMinutes = "";
				strSeconds = "";
				
				// get whole minutes
				intMinutes = System.Convert.ToInt32(Conversion.Int(intInSeconds / 60));
				
				// get whole seconds
				intSeconds = Conversion.Int(intInSeconds - intMinutes * 60);
				
				// format minutes
				if (intMinutes < 10)
				{
					strMinutes = "0" + intMinutes.ToString() + ":";
				}
				
				if (intMinutes >= 10)
				{
					strMinutes = intMinutes.ToString() + ":";
				}
				
				if (intMinutes > 59 || intMinutes < 0)
				{
					strMinutes = "00:";
				}
				
				// format seconds
				if (intSeconds < 10)
				{
					strSeconds = "0" + intSeconds.ToString();
				}
				
				if (intSeconds >= 10)
				{
					strSeconds = intSeconds.ToString();
				}
				if (intSeconds > 59 || intSeconds < 0)
				{
					strSeconds = "00";
				}
				
				return strMinutes + strSeconds;
			}
			catch
			{
				return Constants.vbNullString;
			}
			
		}
		
	}
	
}
