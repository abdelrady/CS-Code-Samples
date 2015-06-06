/*=============================================================================
 File:			Terminal.cs					Serial terminal/debugger Class. 

 Created:		1.00	10/13/03	TJK		Timothy J. Krell	(SAIC)

 Version:		1.00

 Revisions:		1.00	10/13/03	TJK		Initial Release.

 Copyright(c)	2003, Science Applications International Corporation (SAIC)
				All Rights Reserved. Sponsored by the U.S. Government under
				Contract #DAAH01-00-D-0013/10. This software may be reproduced
				by or for the US Government pursuant to the copyright license
				under clause at DFARS 252.227-7014 (June 1995).
=============================================================================*/

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using SerialPorts;

namespace SerialTerminal
{
	
	public class Terminal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox ComPort;
		private System.Windows.Forms.Label LblModem;
		private System.Windows.Forms.Label LblRING;
		private System.Windows.Forms.Label LblRLSD;
		private System.Windows.Forms.Label LblDSR;
		private System.Windows.Forms.Label LblCTS;
		private System.Windows.Forms.Label LblStatus;
		private System.Windows.Forms.Label LblPort;
		private System.Windows.Forms.Label LblTxData;
		private System.Windows.Forms.Label LblRxData;
		private System.Windows.Forms.Label LblXmit;
		private System.Windows.Forms.Label LblSettings;
		private System.Windows.Forms.Label LblTxCnt;
		private System.Windows.Forms.Label LblRxCnt;
		private System.Windows.Forms.Label LblReadRate;
		private System.Windows.Forms.Label LblMsec1;
		private System.Windows.Forms.Label LblHandshake;
		private System.Windows.Forms.Label LblForces;

		private System.Windows.Forms.Panel PnlCom;
		private System.Windows.Forms.Panel PnlHandshake;
		private System.Windows.Forms.Panel PnlModem;
		private System.Windows.Forms.Panel PnlTxData;
		private System.Windows.Forms.Panel PnlRxData;
		private System.Windows.Forms.Panel PnlRING;
		private System.Windows.Forms.Panel PnlRLSD;
		private System.Windows.Forms.Panel PnlDSR;
		private System.Windows.Forms.Panel PnlCTS;

		private System.Windows.Forms.Button CmdOpen;
		private System.Windows.Forms.Button CmdQuit;
		private System.Windows.Forms.Button CmdConfig;
		private System.Windows.Forms.Button CmdCont;
		private System.Windows.Forms.Button CmdSend;
		private System.Windows.Forms.Button CmdClear;
		private System.Windows.Forms.Button CmdBreak;
		private System.Windows.Forms.Button CmdRts;
		private System.Windows.Forms.Button CmdDtr;
		private System.Windows.Forms.Button CmdXoff;

		private System.Windows.Forms.CheckBox ChkTxHex;
		private System.Windows.Forms.CheckBox ChkRxHex;
		private System.Windows.Forms.CheckBox ChkRxEcho;
		private System.Windows.Forms.CheckBox ChkUpdate;

		private System.Windows.Forms.Timer RecvTimer;

		internal System.Windows.Forms.TextBox TxStr;
		internal System.Windows.Forms.TextBox TxData;
		internal System.Windows.Forms.TextBox RxData;
		internal System.Windows.Forms.TextBox TxCount;
		internal System.Windows.Forms.TextBox RxCount;
		internal System.Windows.Forms.TextBox Settings;
		internal System.Windows.Forms.TextBox Status;
		internal System.Windows.Forms.TextBox RecvRate;
		internal System.Windows.Forms.TextBox HndShake;

		private System.ComponentModel.IContainer components;

		#region Members
		// Terminal app constants.
		private const int	MAX_PORTS  = 32;
		private const int	RANDOM_LO  = 32;
		private const int	RANDOM_HI  = 127;
		private const int	RANDOM_CNT = 80;

		// Terminal app locals.
		private int			TxBytes = 0;
		private int			RxBytes = 0;
		private string		TxString = "";
		private string		RxString = "";
		private Thread		TxThread;
		private bool		TxThreadStop;

		// Terminal interface port.
		private SerialPort	Port;

		// Terminal functions that 
		// handle base class events.
		private WithEvents	Func;
		#endregion

		#region Constructor
		/// <summary>
		/// Terminal constructor. Initialization.
		/// </summary>
		public Terminal()
		{
			InitializeComponent();

			this.ChkTxHex.Checked = false;
			this.ChkRxHex.Checked = false;
			this.ChkRxEcho.Checked = false;

			TxBytes = 0;
			this.TxString = "";
			this.TxCount.Text = "0";
			this.TxData.Text = "";
			this.TxStr.Text = "";

			RxBytes = 0;
			this.RxString = "";
			this.RxCount.Text = "0";
			this.RxData.Text = "";

			this.Status.Text = "";
			this.Settings.Text = "";
			this.HndShake.Text = "";
			this.RecvRate.Text = this.RecvTimer.Interval.ToString();

			// Fill com port list.
			this.FillAvailable();

			// Instantiate base class event handlers.
			this.Func = new WithEvents();
			this.Func.Error   = new StrnFunc(this.OnError);
			this.Func.RxChar  = new ByteFunc(this.OnRecvI);
			this.Func.CtsSig  = new BoolFunc(this.OnCts);
			this.Func.DsrSig  = new BoolFunc(this.OnDsr);
			this.Func.RlsdSig = new BoolFunc(this.OnRlsd);
			this.Func.RingSig = new BoolFunc(this.OnRing);

			// Instantiate the terminal port.
			this.Port = new SerialPort(this.Func);
			return;
		}
		#endregion

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.components = new System.ComponentModel.Container();
			this.PnlCom = new System.Windows.Forms.Panel();
			this.HndShake = new System.Windows.Forms.TextBox();
			this.LblHandshake = new System.Windows.Forms.Label();
			this.ComPort = new System.Windows.Forms.ComboBox();
			this.Settings = new System.Windows.Forms.TextBox();
			this.LblSettings = new System.Windows.Forms.Label();
			this.LblPort = new System.Windows.Forms.Label();
			this.Status = new System.Windows.Forms.TextBox();
			this.LblStatus = new System.Windows.Forms.Label();
			this.PnlHandshake = new System.Windows.Forms.Panel();
			this.CmdXoff = new System.Windows.Forms.Button();
			this.CmdDtr = new System.Windows.Forms.Button();
			this.CmdRts = new System.Windows.Forms.Button();
			this.LblForces = new System.Windows.Forms.Label();
			this.CmdBreak = new System.Windows.Forms.Button();
			this.PnlModem = new System.Windows.Forms.Panel();
			this.PnlRING = new System.Windows.Forms.Panel();
			this.PnlRLSD = new System.Windows.Forms.Panel();
			this.PnlDSR = new System.Windows.Forms.Panel();
			this.LblRING = new System.Windows.Forms.Label();
			this.LblRLSD = new System.Windows.Forms.Label();
			this.LblDSR = new System.Windows.Forms.Label();
			this.LblCTS = new System.Windows.Forms.Label();
			this.PnlCTS = new System.Windows.Forms.Panel();
			this.LblModem = new System.Windows.Forms.Label();
			this.PnlTxData = new System.Windows.Forms.Panel();
			this.TxData = new System.Windows.Forms.TextBox();
			this.ChkUpdate = new System.Windows.Forms.CheckBox();
			this.TxCount = new System.Windows.Forms.TextBox();
			this.LblTxCnt = new System.Windows.Forms.Label();
			this.ChkTxHex = new System.Windows.Forms.CheckBox();
			this.LblXmit = new System.Windows.Forms.Label();
			this.TxStr = new System.Windows.Forms.TextBox();
			this.LblTxData = new System.Windows.Forms.Label();
			this.PnlRxData = new System.Windows.Forms.Panel();
			this.LblMsec1 = new System.Windows.Forms.Label();
			this.RecvRate = new System.Windows.Forms.TextBox();
			this.LblReadRate = new System.Windows.Forms.Label();
			this.RxCount = new System.Windows.Forms.TextBox();
			this.LblRxCnt = new System.Windows.Forms.Label();
			this.ChkRxEcho = new System.Windows.Forms.CheckBox();
			this.ChkRxHex = new System.Windows.Forms.CheckBox();
			this.RxData = new System.Windows.Forms.TextBox();
			this.LblRxData = new System.Windows.Forms.Label();
			this.CmdOpen = new System.Windows.Forms.Button();
			this.CmdQuit = new System.Windows.Forms.Button();
			this.CmdConfig = new System.Windows.Forms.Button();
			this.CmdCont = new System.Windows.Forms.Button();
			this.CmdClear = new System.Windows.Forms.Button();
			this.CmdSend = new System.Windows.Forms.Button();
			this.RecvTimer = new System.Windows.Forms.Timer(this.components);
			this.PnlCom.SuspendLayout();
			this.PnlHandshake.SuspendLayout();
			this.PnlModem.SuspendLayout();
			this.PnlTxData.SuspendLayout();
			this.PnlRxData.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlCom
			// 
			this.PnlCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlCom.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.HndShake,
																				 this.LblHandshake,
																				 this.ComPort,
																				 this.Settings,
																				 this.LblSettings,
																				 this.LblPort});
			this.PnlCom.Location = new System.Drawing.Point(8, 8);
			this.PnlCom.Name = "PnlCom";
			this.PnlCom.Size = new System.Drawing.Size(432, 64);
			this.PnlCom.TabIndex = 0;
			// 
			// HndShake
			// 
			this.HndShake.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.HndShake.Location = new System.Drawing.Point(120, 32);
			this.HndShake.Name = "HndShake";
			this.HndShake.Size = new System.Drawing.Size(128, 26);
			this.HndShake.TabIndex = 54;
			this.HndShake.Text = "";
			this.HndShake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LblHandshake
			// 
			this.LblHandshake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblHandshake.ForeColor = System.Drawing.Color.Teal;
			this.LblHandshake.Location = new System.Drawing.Point(120, 0);
			this.LblHandshake.Name = "LblHandshake";
			this.LblHandshake.Size = new System.Drawing.Size(128, 24);
			this.LblHandshake.TabIndex = 53;
			this.LblHandshake.Text = "Handshake";
			this.LblHandshake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ComPort
			// 
			this.ComPort.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ComPort.Location = new System.Drawing.Point(8, 32);
			this.ComPort.MaxDropDownItems = 16;
			this.ComPort.Name = "ComPort";
			this.ComPort.Size = new System.Drawing.Size(96, 26);
			this.ComPort.TabIndex = 51;
			// 
			// Settings
			// 
			this.Settings.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Settings.Location = new System.Drawing.Point(264, 32);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(160, 26);
			this.Settings.TabIndex = 41;
			this.Settings.Text = "";
			this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LblSettings
			// 
			this.LblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblSettings.ForeColor = System.Drawing.Color.Teal;
			this.LblSettings.Location = new System.Drawing.Point(264, 0);
			this.LblSettings.Name = "LblSettings";
			this.LblSettings.Size = new System.Drawing.Size(160, 24);
			this.LblSettings.TabIndex = 40;
			this.LblSettings.Text = "Settings";
			this.LblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblPort
			// 
			this.LblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblPort.ForeColor = System.Drawing.Color.Teal;
			this.LblPort.Location = new System.Drawing.Point(8, 0);
			this.LblPort.Name = "LblPort";
			this.LblPort.Size = new System.Drawing.Size(96, 24);
			this.LblPort.TabIndex = 39;
			this.LblPort.Text = "Active Port";
			this.LblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Status
			// 
			this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Status.Location = new System.Drawing.Point(64, 704);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(944, 23);
			this.Status.TabIndex = 11;
			this.Status.Text = "";
			// 
			// LblStatus
			// 
			this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblStatus.Location = new System.Drawing.Point(8, 704);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(56, 24);
			this.LblStatus.TabIndex = 12;
			this.LblStatus.Text = "Status:";
			this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PnlHandshake
			// 
			this.PnlHandshake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlHandshake.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.CmdXoff,
																					   this.CmdDtr,
																					   this.CmdRts,
																					   this.LblForces,
																					   this.CmdBreak});
			this.PnlHandshake.Location = new System.Drawing.Point(448, 8);
			this.PnlHandshake.Name = "PnlHandshake";
			this.PnlHandshake.Size = new System.Drawing.Size(344, 64);
			this.PnlHandshake.TabIndex = 34;
			// 
			// CmdXoff
			// 
			this.CmdXoff.Location = new System.Drawing.Point(8, 32);
			this.CmdXoff.Name = "CmdXoff";
			this.CmdXoff.Size = new System.Drawing.Size(80, 24);
			this.CmdXoff.TabIndex = 67;
			this.CmdXoff.Text = "Set XOFF";
			this.CmdXoff.Click += new System.EventHandler(this.CmdXoff_Click);
			// 
			// CmdDtr
			// 
			this.CmdDtr.Location = new System.Drawing.Point(176, 32);
			this.CmdDtr.Name = "CmdDtr";
			this.CmdDtr.Size = new System.Drawing.Size(80, 24);
			this.CmdDtr.TabIndex = 66;
			this.CmdDtr.Text = "Set DTR";
			this.CmdDtr.Click += new System.EventHandler(this.CmdDtr_Click);
			// 
			// CmdRts
			// 
			this.CmdRts.Location = new System.Drawing.Point(88, 32);
			this.CmdRts.Name = "CmdRts";
			this.CmdRts.Size = new System.Drawing.Size(80, 24);
			this.CmdRts.TabIndex = 65;
			this.CmdRts.Text = "Set RTS";
			this.CmdRts.Click += new System.EventHandler(this.CmdRts_Click);
			// 
			// LblForces
			// 
			this.LblForces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblForces.ForeColor = System.Drawing.Color.Teal;
			this.LblForces.Location = new System.Drawing.Point(16, 0);
			this.LblForces.Name = "LblForces";
			this.LblForces.Size = new System.Drawing.Size(320, 24);
			this.LblForces.TabIndex = 41;
			this.LblForces.Text = "Force Signals";
			this.LblForces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CmdBreak
			// 
			this.CmdBreak.Location = new System.Drawing.Point(256, 32);
			this.CmdBreak.Name = "CmdBreak";
			this.CmdBreak.Size = new System.Drawing.Size(80, 24);
			this.CmdBreak.TabIndex = 64;
			this.CmdBreak.Text = "Set BRK";
			this.CmdBreak.Click += new System.EventHandler(this.CmdBreak_Click);
			// 
			// PnlModem
			// 
			this.PnlModem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlModem.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.PnlRING,
																				   this.PnlRLSD,
																				   this.PnlDSR,
																				   this.LblRING,
																				   this.LblRLSD,
																				   this.LblDSR,
																				   this.LblCTS,
																				   this.PnlCTS,
																				   this.LblModem});
			this.PnlModem.Location = new System.Drawing.Point(800, 8);
			this.PnlModem.Name = "PnlModem";
			this.PnlModem.Size = new System.Drawing.Size(208, 64);
			this.PnlModem.TabIndex = 35;
			// 
			// PnlRING
			// 
			this.PnlRING.BackColor = System.Drawing.Color.Red;
			this.PnlRING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlRING.Enabled = false;
			this.PnlRING.Location = new System.Drawing.Point(160, 40);
			this.PnlRING.Name = "PnlRING";
			this.PnlRING.Size = new System.Drawing.Size(32, 16);
			this.PnlRING.TabIndex = 47;
			// 
			// PnlRLSD
			// 
			this.PnlRLSD.BackColor = System.Drawing.Color.Red;
			this.PnlRLSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlRLSD.Enabled = false;
			this.PnlRLSD.Location = new System.Drawing.Point(112, 40);
			this.PnlRLSD.Name = "PnlRLSD";
			this.PnlRLSD.Size = new System.Drawing.Size(32, 16);
			this.PnlRLSD.TabIndex = 46;
			// 
			// PnlDSR
			// 
			this.PnlDSR.BackColor = System.Drawing.Color.Red;
			this.PnlDSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlDSR.Enabled = false;
			this.PnlDSR.Location = new System.Drawing.Point(64, 40);
			this.PnlDSR.Name = "PnlDSR";
			this.PnlDSR.Size = new System.Drawing.Size(32, 16);
			this.PnlDSR.TabIndex = 45;
			// 
			// LblRING
			// 
			this.LblRING.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblRING.Location = new System.Drawing.Point(152, 24);
			this.LblRING.Name = "LblRING";
			this.LblRING.Size = new System.Drawing.Size(48, 16);
			this.LblRING.TabIndex = 44;
			this.LblRING.Text = "RNG";
			this.LblRING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblRLSD
			// 
			this.LblRLSD.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblRLSD.Location = new System.Drawing.Point(104, 24);
			this.LblRLSD.Name = "LblRLSD";
			this.LblRLSD.Size = new System.Drawing.Size(48, 16);
			this.LblRLSD.TabIndex = 43;
			this.LblRLSD.Text = "RLSD";
			this.LblRLSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblDSR
			// 
			this.LblDSR.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblDSR.Location = new System.Drawing.Point(56, 24);
			this.LblDSR.Name = "LblDSR";
			this.LblDSR.Size = new System.Drawing.Size(48, 16);
			this.LblDSR.TabIndex = 42;
			this.LblDSR.Text = "DSR";
			this.LblDSR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblCTS
			// 
			this.LblCTS.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblCTS.Location = new System.Drawing.Point(8, 24);
			this.LblCTS.Name = "LblCTS";
			this.LblCTS.Size = new System.Drawing.Size(48, 16);
			this.LblCTS.TabIndex = 41;
			this.LblCTS.Text = "CTS";
			this.LblCTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PnlCTS
			// 
			this.PnlCTS.BackColor = System.Drawing.Color.Red;
			this.PnlCTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlCTS.Enabled = false;
			this.PnlCTS.Location = new System.Drawing.Point(16, 40);
			this.PnlCTS.Name = "PnlCTS";
			this.PnlCTS.Size = new System.Drawing.Size(32, 16);
			this.PnlCTS.TabIndex = 40;
			// 
			// LblModem
			// 
			this.LblModem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblModem.ForeColor = System.Drawing.Color.Teal;
			this.LblModem.Location = new System.Drawing.Point(8, 0);
			this.LblModem.Name = "LblModem";
			this.LblModem.Size = new System.Drawing.Size(192, 24);
			this.LblModem.TabIndex = 39;
			this.LblModem.Text = "Modem Signals";
			this.LblModem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PnlTxData
			// 
			this.PnlTxData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlTxData.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.TxData,
																					this.ChkUpdate,
																					this.TxCount,
																					this.LblTxCnt,
																					this.ChkTxHex,
																					this.LblXmit,
																					this.TxStr,
																					this.LblTxData});
			this.PnlTxData.Location = new System.Drawing.Point(8, 368);
			this.PnlTxData.Name = "PnlTxData";
			this.PnlTxData.Size = new System.Drawing.Size(1000, 280);
			this.PnlTxData.TabIndex = 38;
			// 
			// TxData
			// 
			this.TxData.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TxData.Location = new System.Drawing.Point(8, 24);
			this.TxData.Multiline = true;
			this.TxData.Name = "TxData";
			this.TxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxData.Size = new System.Drawing.Size(984, 208);
			this.TxData.TabIndex = 39;
			this.TxData.Text = "";
			// 
			// ChkUpdate
			// 
			this.ChkUpdate.Location = new System.Drawing.Point(744, 240);
			this.ChkUpdate.Name = "ChkUpdate";
			this.ChkUpdate.Size = new System.Drawing.Size(120, 24);
			this.ChkUpdate.TabIndex = 64;
			this.ChkUpdate.Text = "Pause Updates";
			this.ChkUpdate.CheckedChanged += new System.EventHandler(this.ChkUpdate_CheckedChanged);
			// 
			// TxCount
			// 
			this.TxCount.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TxCount.Location = new System.Drawing.Point(88, 240);
			this.TxCount.Name = "TxCount";
			this.TxCount.Size = new System.Drawing.Size(80, 26);
			this.TxCount.TabIndex = 60;
			this.TxCount.Text = "";
			this.TxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LblTxCnt
			// 
			this.LblTxCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblTxCnt.Location = new System.Drawing.Point(8, 240);
			this.LblTxCnt.Name = "LblTxCnt";
			this.LblTxCnt.Size = new System.Drawing.Size(72, 24);
			this.LblTxCnt.TabIndex = 59;
			this.LblTxCnt.Text = "TX Count:";
			this.LblTxCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ChkTxHex
			// 
			this.ChkTxHex.Location = new System.Drawing.Point(880, 240);
			this.ChkTxHex.Name = "ChkTxHex";
			this.ChkTxHex.Size = new System.Drawing.Size(112, 24);
			this.ChkTxHex.TabIndex = 42;
			this.ChkTxHex.Text = "Display In Hex";
			this.ChkTxHex.CheckedChanged += new System.EventHandler(this.ChkTxHex_CheckedChanged);
			// 
			// LblXmit
			// 
			this.LblXmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblXmit.Location = new System.Drawing.Point(184, 240);
			this.LblXmit.Name = "LblXmit";
			this.LblXmit.Size = new System.Drawing.Size(72, 24);
			this.LblXmit.TabIndex = 41;
			this.LblXmit.Text = "Transmit:";
			this.LblXmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxStr
			// 
			this.TxStr.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TxStr.Location = new System.Drawing.Point(256, 240);
			this.TxStr.Name = "TxStr";
			this.TxStr.Size = new System.Drawing.Size(480, 26);
			this.TxStr.TabIndex = 40;
			this.TxStr.Text = "";
			this.TxStr.TextChanged += new System.EventHandler(this.TxStr_TextChanged);
			// 
			// LblTxData
			// 
			this.LblTxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblTxData.ForeColor = System.Drawing.Color.Teal;
			this.LblTxData.Location = new System.Drawing.Point(16, 0);
			this.LblTxData.Name = "LblTxData";
			this.LblTxData.Size = new System.Drawing.Size(976, 24);
			this.LblTxData.TabIndex = 38;
			this.LblTxData.Text = "Transmitted Data";
			this.LblTxData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PnlRxData
			// 
			this.PnlRxData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlRxData.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.LblMsec1,
																					this.RecvRate,
																					this.LblReadRate,
																					this.RxCount,
																					this.LblRxCnt,
																					this.ChkRxEcho,
																					this.ChkRxHex,
																					this.RxData,
																					this.LblRxData});
			this.PnlRxData.Location = new System.Drawing.Point(8, 80);
			this.PnlRxData.Name = "PnlRxData";
			this.PnlRxData.Size = new System.Drawing.Size(1000, 280);
			this.PnlRxData.TabIndex = 40;
			// 
			// LblMsec1
			// 
			this.LblMsec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblMsec1.Location = new System.Drawing.Point(336, 240);
			this.LblMsec1.Name = "LblMsec1";
			this.LblMsec1.Size = new System.Drawing.Size(48, 24);
			this.LblMsec1.TabIndex = 51;
			this.LblMsec1.Text = "msec";
			this.LblMsec1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RecvRate
			// 
			this.RecvRate.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RecvRate.Location = new System.Drawing.Point(256, 240);
			this.RecvRate.Name = "RecvRate";
			this.RecvRate.Size = new System.Drawing.Size(80, 26);
			this.RecvRate.TabIndex = 50;
			this.RecvRate.Text = "";
			this.RecvRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.RecvRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecvRate_KeyUp);
			// 
			// LblReadRate
			// 
			this.LblReadRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblReadRate.Location = new System.Drawing.Point(176, 240);
			this.LblReadRate.Name = "LblReadRate";
			this.LblReadRate.Size = new System.Drawing.Size(80, 24);
			this.LblReadRate.TabIndex = 49;
			this.LblReadRate.Text = "Recv Rate:";
			this.LblReadRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RxCount
			// 
			this.RxCount.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RxCount.Location = new System.Drawing.Point(80, 240);
			this.RxCount.Name = "RxCount";
			this.RxCount.Size = new System.Drawing.Size(80, 26);
			this.RxCount.TabIndex = 48;
			this.RxCount.Text = "";
			this.RxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LblRxCnt
			// 
			this.LblRxCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblRxCnt.Location = new System.Drawing.Point(8, 240);
			this.LblRxCnt.Name = "LblRxCnt";
			this.LblRxCnt.Size = new System.Drawing.Size(72, 24);
			this.LblRxCnt.TabIndex = 47;
			this.LblRxCnt.Text = "RX Count:";
			this.LblRxCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ChkRxEcho
			// 
			this.ChkRxEcho.Location = new System.Drawing.Point(744, 248);
			this.ChkRxEcho.Name = "ChkRxEcho";
			this.ChkRxEcho.Size = new System.Drawing.Size(120, 24);
			this.ChkRxEcho.TabIndex = 44;
			this.ChkRxEcho.Text = "Enable Echo";
			// 
			// ChkRxHex
			// 
			this.ChkRxHex.Location = new System.Drawing.Point(880, 248);
			this.ChkRxHex.Name = "ChkRxHex";
			this.ChkRxHex.Size = new System.Drawing.Size(112, 24);
			this.ChkRxHex.TabIndex = 43;
			this.ChkRxHex.Text = "Display In Hex";
			this.ChkRxHex.CheckedChanged += new System.EventHandler(this.ChkRxHex_CheckedChanged);
			// 
			// RxData
			// 
			this.RxData.Font = new System.Drawing.Font("Courier New", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RxData.Location = new System.Drawing.Point(8, 24);
			this.RxData.Multiline = true;
			this.RxData.Name = "RxData";
			this.RxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.RxData.Size = new System.Drawing.Size(984, 208);
			this.RxData.TabIndex = 39;
			this.RxData.Text = "";
			// 
			// LblRxData
			// 
			this.LblRxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LblRxData.ForeColor = System.Drawing.Color.Teal;
			this.LblRxData.Location = new System.Drawing.Point(8, 0);
			this.LblRxData.Name = "LblRxData";
			this.LblRxData.Size = new System.Drawing.Size(984, 24);
			this.LblRxData.TabIndex = 38;
			this.LblRxData.Text = "Received Data";
			this.LblRxData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CmdOpen
			// 
			this.CmdOpen.Location = new System.Drawing.Point(8, 656);
			this.CmdOpen.Name = "CmdOpen";
			this.CmdOpen.Size = new System.Drawing.Size(120, 40);
			this.CmdOpen.TabIndex = 59;
			this.CmdOpen.Text = "OnLine";
			this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
			// 
			// CmdQuit
			// 
			this.CmdQuit.Location = new System.Drawing.Point(888, 656);
			this.CmdQuit.Name = "CmdQuit";
			this.CmdQuit.Size = new System.Drawing.Size(120, 40);
			this.CmdQuit.TabIndex = 58;
			this.CmdQuit.Text = "Terminate";
			this.CmdQuit.Click += new System.EventHandler(this.CmdQuit_Click);
			// 
			// CmdConfig
			// 
			this.CmdConfig.Location = new System.Drawing.Point(768, 656);
			this.CmdConfig.Name = "CmdConfig";
			this.CmdConfig.Size = new System.Drawing.Size(120, 40);
			this.CmdConfig.TabIndex = 57;
			this.CmdConfig.Text = "Configure";
			this.CmdConfig.Click += new System.EventHandler(this.CmdConfig_Click);
			// 
			// CmdCont
			// 
			this.CmdCont.Location = new System.Drawing.Point(248, 656);
			this.CmdCont.Name = "CmdCont";
			this.CmdCont.Size = new System.Drawing.Size(120, 40);
			this.CmdCont.TabIndex = 64;
			this.CmdCont.Text = "Continuous";
			this.CmdCont.Click += new System.EventHandler(this.CmdCont_Click);
			// 
			// CmdClear
			// 
			this.CmdClear.Location = new System.Drawing.Point(368, 656);
			this.CmdClear.Name = "CmdClear";
			this.CmdClear.Size = new System.Drawing.Size(120, 40);
			this.CmdClear.TabIndex = 62;
			this.CmdClear.Text = "Clear";
			this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
			// 
			// CmdSend
			// 
			this.CmdSend.Location = new System.Drawing.Point(128, 656);
			this.CmdSend.Name = "CmdSend";
			this.CmdSend.Size = new System.Drawing.Size(120, 40);
			this.CmdSend.TabIndex = 61;
			this.CmdSend.Text = "Transmit";
			this.CmdSend.Click += new System.EventHandler(this.CmdSend_Click);
			// 
			// RecvTimer
			// 
			this.RecvTimer.Tick += new System.EventHandler(this.RecvTimer_Tick);
			// 
			// Terminal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(1016, 732);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CmdCont,
																		  this.CmdClear,
																		  this.CmdSend,
																		  this.CmdOpen,
																		  this.CmdQuit,
																		  this.CmdConfig,
																		  this.PnlRxData,
																		  this.PnlTxData,
																		  this.PnlModem,
																		  this.LblStatus,
																		  this.Status,
																		  this.PnlCom,
																		  this.PnlHandshake});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Terminal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Serial Test & Debug Terminal";
			this.Closed += new System.EventHandler(this.TermForm_Closed);
			this.PnlCom.ResumeLayout(false);
			this.PnlHandshake.ResumeLayout(false);
			this.PnlModem.ResumeLayout(false);
			this.PnlTxData.ResumeLayout(false);
			this.PnlRxData.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Methods
		/// <summary>
		/// Send chars one-at-a-time when entered into the transmit line.
		/// </summary>
		private void TxStr_TextChanged(object sender, System.EventArgs e)
		{
			if(this.TxStr.Text.Length > 0)
			{
				string s = this.TxStr.Text.Substring(this.TxStr.Text.Length-1);
				this.SendStr(s);
			}
		}

		/// <summary>
		/// Converts between ASCII and hex display.
		/// </summary>
		private void ChkTxHex_CheckedChanged(object sender, System.EventArgs e)
		{
			this.TxData.Text = (this.ChkTxHex.Checked) ? 
				AtoX(this.TxString) : this.TxString;
		}

		/// <summary>
		/// Converts between ASCII and hex display.
		/// </summary>
		private void ChkRxHex_CheckedChanged(object sender, System.EventArgs e)
		{
			this.RxData.Text = (this.ChkRxHex.Checked) ?
				AtoX(this.RxString) : this.RxString;
		}

		/// <summary>
		/// Updates the TX/RX data text boxes if continuous is off.
		/// </summary>
		private void ChkUpdate_CheckedChanged(object sender, System.EventArgs e)
		{
			if((this.ChkUpdate.Checked == false) && (this.CmdCont.Text == "Continuous"))
			{
				this.TxDataUpdate("");
				this.RxDataUpdate("");
			}
		}

		/// <summary>
		/// Force the XON/XOFF signals.
		/// </summary>
		private void CmdXoff_Click(object sender, System.EventArgs e)
		{
            if(this.CmdXoff.Text == "Set XOFF")
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.SetXOFF) == false)
					this.Status.Text = "Set XOFF Extended Function Failed.";
				else
					this.CmdXoff.Text = "Set XON";
			}
			else
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.SetXON) == false)
					this.Status.Text = "Set XON Extended Function Failed.";
				else
					this.CmdXoff.Text = "Set XOFF";
			}
		}

		/// <summary>
		/// Force the RTS signal.
		/// </summary>
		private void CmdRts_Click(object sender, System.EventArgs e)
		{
			if(this.CmdRts.Text == "Set RTS")
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.SetRTS) == false)
					this.Status.Text = "Set RTS Extended Function Failed.";
				else
					this.CmdRts.Text = "Clr RTS";
			}
			else
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.ClrRTS) == false)
					this.Status.Text = "Clear RTS Extended Function Failed.";
				else
					this.CmdRts.Text = "Set RTS";
			}
		}

		/// <summary>
		/// Force the DTR signal.
		/// </summary>
		private void CmdDtr_Click(object sender, System.EventArgs e)
		{
			if(this.CmdDtr.Text == "Set DTR")
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.SetDTR) == false)
					this.Status.Text = "Set DTR Extended Function Failed.";
				else
					this.CmdDtr.Text = "Clr DTR";
			}
			else
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.ClrDTR) == false)
					this.Status.Text = "Clear DTR Extended Function Failed.";
				else
					this.CmdDtr.Text = "Set DTR";
			}
		}

		/// <summary>
		/// Force the line BREAK.
		/// </summary>
		private void CmdBreak_Click(object sender, System.EventArgs e)
		{
			if(this.CmdBreak.Text == "Set BRK")
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.SetBreak) == false)
					this.Status.Text = "Set BREAK Extended Function Failed.";
				else
					this.CmdBreak.Text = "Clr BRK";
			}
			else
			{
				if(this.Port.SendE(SerialPorts.ExtCodes.ClrBreak) == false)
					this.Status.Text = "Clear BREAK Extended Function Failed.";
				else
					this.CmdBreak.Text = "Set BRK";
			}
		}

		/// <summary>
		/// Open/close the com port.
		/// </summary>
		private void CmdOpen_Click(object sender, System.EventArgs e)
		{
			this.PortControl();
		}

		/// <summary>
		/// Sends the TX line (or makes one up if empty).
		/// </summary>
		private void CmdSend_Click(object sender, System.EventArgs e)
		{
			if(this.Port.IsOpen)
			{
				if(this.TxStr.Text != "")
				{
					this.SendStr(this.TxStr.Text);
				}
				else
				{
					byte[] b;
					this.TxStr.Text = this.RandomText(out b);
					this.SendBuf(b);
				}
				this.Status.Text = "Sent The Transmit Line.";
			}
			else
			{
				this.Status.Text = "ERROR - Cannot Send: The Serial Port Is Closed.";
			}
			return;
		}

		/// <summary>
		/// Start/stop continuous TX.
		/// </summary>
		private void CmdCont_Click(object sender, System.EventArgs e)
		{
			if(this.Port.IsOpen)
			{
				if(this.CmdCont.Text == "Continuous")
				{
					this.CmdCont.Text = "Stop";

					// Start transmitter thread.
					TxThread = new Thread(new ThreadStart(TransmitThread));
					TxThread.Name = "TermXmit";
					TxThread.Priority = ThreadPriority.AboveNormal;
					TxThread.Start();
					TxThreadStop = false;
					this.Status.Text = "Starting Continuous Transmit Thread...";
				}
				else
				{
					this.CmdCont.Text = "Continuous";
					TxThreadStop = true;
				}
			}
			else
			{
				this.Status.Text = "ERROR - Cannot Send: The Serial Port Is Closed.";
			}
		}

		/// <summary>
		/// Clear display fields.
		/// </summary>
		private void CmdClear_Click(object sender, System.EventArgs e)
		{
			TxBytes = 0;
			this.TxString = "";
			this.TxCount.Text = "0";
			this.TxData.Text = "";
			this.TxStr.Text = "";

			RxBytes = 0;
			this.RxString = "";
			this.RxCount.Text = "0";
			this.RxData.Text = "";

			this.Status.Text = "";
		}

		/// <summary>
		/// Open the port settings dialog.
		/// </summary>
		private void CmdConfig_Click(object sender, System.EventArgs e)
		{
			Settings frm = new Settings(this.Port.ConfigFileName, this.Port.Cnfg);
			frm.ShowDialog();
		}

		/// <summary>
		/// Quit the terminal app.
		/// </summary>
		private void CmdQuit_Click(object sender, System.EventArgs e)
		{
			this.Port.Close();
			this.Port = null;
			Application.Exit();
		}

		/// <summary>
		/// Quit terminal app.
		/// </summary>
		private void TermForm_Closed(object sender, System.EventArgs e)
		{
			this.CmdQuit_Click(sender, e);
		}

		/// <summary>
		/// Changes RX data display rate on CR.
		/// </summary>
		private void RecvRate_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue == 13)
			{
				try
				{
					this.RecvTimer.Interval = Convert.ToInt32(this.RecvRate.Text, 10);
				}
				catch
				{
					this.RecvTimer.Interval = 100;
				}
			}
		}

		/// <summary>
		/// Pulls data from the driver and updates the RX data text box.
		/// </summary>
		private void RecvTimer_Tick(object sender, System.EventArgs e)
		{
			byte[] b;
			uint nBytes = this.Port.Recv(out b);
			if(nBytes > 0)
			{
				this.RxDataUpdate(Encoding.ASCII.GetString(b));
				if(this.ChkRxEcho.Checked)
					this.SendBuf(b);
			}
		}

		/// <summary>
		/// Send data ASAP.
		/// </summary>
		private void TransmitThread()
		{
			int cnt = 80;
			byte[] b = new byte[cnt];
			Random rand = new Random();
			long start = DateTime.Now.Ticks;

			try
			{
				// Send til stopped.
				while(true)
				{
					// Encode random 80 byte buffer.
					for(int i = 0; i < cnt-2; ++i) 
					{
						b[i] = (byte) rand.Next(RANDOM_LO, RANDOM_HI);
					}
					b[78] = 0xD;
					b[79] = 0xA;

					// Send buffer.
					if(this.SendBuf(b) != b.Length)
					{
						this.Status.Text = this.Port.Fault;
						this.CmdCont.Text = "Continuous";
						break;
					}

					// Quit on stop.
					if(TxThreadStop)
						break;
				}
			}
			catch(Exception e)
			{
				this.Status.Text = e.Message;
			}
			finally
			{
				TxThread = null;
				if(TxThreadStop)
				{
					string s="";
					double max = (int) this.Port.Cnfg.BaudRate / 
						((int) this.Port.Cnfg.DataBits + 
						(int) this.Port.Cnfg.StopBits + 1);
					long nTicks = DateTime.Now.Ticks - start;
					long nBytes = long.Parse(this.TxCount.Text);
					long nMsecs = nTicks / 10000;
					long average = (long) ((float)(nBytes*10000000) / ((float) nTicks));
					s = s + "Stopped Continuous Transmit Thread. ";
					s = s + "Sent " + this.TxCount.Text + " Bytes In ";
					s = s +  nMsecs.ToString() + "ms. Average Rate = ";
					s = s +  average.ToString() + " Bytes/Second. ";
					s = s + "Max Possible = " + max.ToString();
					this.Status.Text = s;
				}
			}
			return;
		}

		/// <summary>
		/// Fill the com port selector with a list of available ports.
		/// </summary>
		private void FillAvailable()
		{
			string s;
			SerialPort p = new SerialPort(this.Func);
			for(int i = 1; i <= MAX_PORTS; i++)
			{
				s = "COM" + i.ToString() + ":";
				if(p.Available(s))
				{
					this.ComPort.Items.Add(s);
				}
			}
			this.ComPort.SelectedIndex = 0;
			return;
		}

		/// <summary>
		/// Generate a random string/buffer.
		/// </summary>
		private string RandomText(out byte[] b)
		{
			char chr;
			string s = "";
			Random rand = new Random();
			int cnt = rand.Next(1, RANDOM_CNT);

			for(int i = 0; i < cnt; ++i) 
			{
				chr = (char) rand.Next(RANDOM_LO, RANDOM_HI);
				s = s + chr.ToString();
			}
			s = s + "\r\n";
			b = new Byte[cnt+2];
			b = Encoding.ASCII.GetBytes(s);
			return s;
		}

		/// <summary>
		/// Converts an ASCII string to hex formatted lines.
		/// </summary>
		private string AtoX(string asc)
		{
			int nLines;
			int nChars;
			int offset;
			string hex = "";

			// Compute number of hex lines.
			if((asc.Length % 16) > 0)
				nLines = asc.Length/16+1;
			else
				nLines = asc.Length/16;

			// Convert into hex lines.
			for(int i = 0; i < nLines; i++)
			{
				offset = i * 16;
				if((asc.Length - offset) > 16)
					nChars = 16;
				else
					nChars = asc.Length - offset;
				hex += this.HexLine(i, asc.Substring(offset, nChars)) + "\r\n";
			}
			return hex;
		}

		/// <summary>
		/// Converts a 16 byte ASCII string into one hex formatted line.
		/// </summary>
		private string HexLine(int lNum, string asc)
		{
			string hex = "";

			// Copy line to char buffer.
			char[] c = new char[16];
			asc.CopyTo(0, c, 0, asc.Length);

			// Create offset prefix.
			hex += String.Format("{0:X8} - {1:X8}", lNum*16, (lNum+1)*16-1);
			hex += "    ";

			// Convert chars to hex representation.
			for(int i = 0; i < asc.Length; i++)
			{
				if((i != 0) && ((i % 4) == 0))
					hex += " ";
				hex += String.Format("{0:X2}", (int) c[i]);
			}

			// Add padding.
			int nSpaces = 62 - hex.Length;
			for(int i = 0; i < nSpaces; i++)
				hex += " ";

			// Add ASCII to end of line.
			for(int i = 0; i < asc.Length; i++)
			{
				if(((int) c[i] < 32) || ((int) c[i] > 126))
					hex += ".";
				else
					hex += c[i].ToString();
			}

			// Return hex dump line.
			return hex;
		}

		/// <summary>
		/// Updates the TX data info.
		/// </summary>
		private void TxDataUpdate(string s)
		{
			TxBytes += s.Length;
			TxString = TxString + s;
			this.TxCount.Text = TxBytes.ToString();
			if(this.ChkUpdate.Checked == false)
			{
				if(this.ChkTxHex.Checked)
					this.TxData.Text = this.AtoX(TxString);
				else
					this.TxData.Text = TxString;
			}
			return;
		}

		/// <summary>
		/// Updates the RX data info.
		/// </summary>
		private void RxDataUpdate(string s)
		{
			RxBytes += s.Length;
			RxString = RxString + s;
			this.RxCount.Text = RxBytes.ToString();
			if(this.ChkUpdate.Checked == false)
			{
				if(this.ChkRxHex.Checked)
					this.RxData.Text = this.AtoX(RxString);
				else
					this.RxData.Text = RxString;
			}
			return;
		}

		/// <summary>
		/// Gets the current port index.
		/// </summary>
		private int PortIndex
		{
			get	
			{
				if(this.Port == null)
					return -1;
				string s = (string) this.ComPort.SelectedItem;
				return Convert.ToInt32(s.Substring(3, s.Length-4), 10);
			}
		}

		/// <summary>
		/// Controls opening/closing the port.
		/// </summary>
		private void PortControl()
		{
			if(this.Port.IsOpen == false)
			{
				if(this.Port.Open(this.PortIndex) == false)
				{
					this.Status.Text = this.Port.Fault;
				}
				else
				{
					this.CmdOpen.Text = "OffLine";
					this.Settings.Text = PortSettings;
					this.HndShake.Text = HsType;
					this.RecvTimer.Enabled = true;
					this.ComPort.Enabled = false;
					this.Status.Text = "Selected Port Opened OK.";
				}
			}
			else
			{
				if(this.Port.IsOpen)
				{
					this.Port.Close();
				}
				this.Settings.Text = "";
				this.HndShake.Text = "";
				this.CmdOpen.Text = "OnLine";
				this.RecvTimer.Enabled = false;
				this.ComPort.Enabled = true;
				this.Status.Text = "Selected Port Closed.";
				this.Port.Signals();
			}
			return;
		}

		/// <summary>
		/// Transmit a string.
		/// </summary>
		private uint SendStr(string s)
		{
			uint nSent=0;
			if(s != "")
			{
				byte[] b = new byte[s.Length];
				b = Encoding.ASCII.GetBytes(s);
				nSent = this.SendBuf(b);
			}
			return nSent;
		}

		/// <summary>
		/// Transmit a buffer.
		/// </summary>
		private uint SendBuf(byte[] b)
		{
			uint nSent=0;
			if(b.Length > 0)
			{
				nSent = this.Port.Send(b);
				if(nSent != b.Length)
				{
					this.Status.Text = this.Port.Fault;
				}
				this.TxDataUpdate(Encoding.ASCII.GetString(b));
			}
			return nSent;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets the current port settings.
		/// </summary>
		private string PortSettings
		{
			get	
			{
				string temp =       this.Port.Cnfg.BaudRate.ToString().Substring(5);
				temp = temp + ":" + this.Port.Cnfg.Parity.ToString().Substring(0,1);
				temp = temp + ":" + ((int)this.Port.Cnfg.DataBits).ToString();
				if((int)this.Port.Cnfg.StopBits == 0)
					temp = temp + ":1";
				else if((int)this.Port.Cnfg.StopBits == 1)
					temp = temp + ":1.5";
				else if((int)this.Port.Cnfg.StopBits == 2)
					temp = temp + ":2";
				return temp;
			}
		}

		/// <summary>
		/// Gets the current port handshake description.
		/// </summary>
		private string HsType
		{
			get
			{
				if(this.Port.Cnfg.FlowCtrl == Handshake.None)
					return "None";
				if(this.Port.Cnfg.FlowCtrl == Handshake.CtsRts)
					return "CTS/RTS";
				if(this.Port.Cnfg.FlowCtrl == Handshake.DsrDtr)
					return "DSR/DTR";
				if(this.Port.Cnfg.FlowCtrl == Handshake.XonXoff)
					return "XON/XOFF";
				else
					return "Unknown";
			}
		}
		#endregion

		/********************************************************************************/
		/*******************************   Delegate Hooks   *****************************/
		/********************************************************************************/
		#region Hooks
		/// <summary>
		/// Handles error events.
		/// </summary>
		internal void OnError(string fault)
		{
			this.Status.Text = fault;
			this.PortControl();
		}

		/// <summary>
		/// Set the modem state displays.
		/// </summary>
		internal void OnCts(bool cts)
		{
			this.PnlCTS.BackColor  = cts  ? Color.Lime : Color.Red;
		}

		/// <summary>
		/// Set the modem state displays.
		/// </summary>
		internal void OnDsr(bool dsr)
		{
			this.PnlDSR.BackColor  = dsr  ? Color.Lime : Color.Red;
		}

		/// <summary>
		/// Set the modem state displays.
		/// </summary>
		internal void OnRlsd(bool rlsd)
		{
			this.PnlRLSD.BackColor = rlsd ? Color.Lime : Color.Red;
		}

		/// <summary>
		/// Set the modem state displays.
		/// </summary>
		internal void OnRing(bool ring)
		{
			this.PnlRING.BackColor = ring ? Color.Lime : Color.Red;
		}

		/// <summary>
		/// Immediate byte received.
		/// </summary>
		internal void OnRecvI(byte[] b)
		{
			this.RxDataUpdate(Encoding.ASCII.GetString(b));
			if(this.ChkRxEcho.Checked)
				this.SendBuf(b);
		}
		#endregion
	}
    /// <summary>
    /// Used to launch a stand-alone terminal app.
    /// </summary>
    public class TerminalMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Terminal());
            return;
        }
    }

    /// <summary>
    /// Summary description for Terminal.
    /// </summary>
}

