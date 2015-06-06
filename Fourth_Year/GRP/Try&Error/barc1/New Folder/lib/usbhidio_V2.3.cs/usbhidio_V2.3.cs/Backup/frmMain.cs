//using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HID_Test_Application
{
	
	internal class frmMain : System.Windows.Forms.Form
	{
		
    #region "Windows Form Designer generated code "
		public frmMain() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

    private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Timer tmrContinuousDataCollect;
		public System.Windows.Forms.Button cmdContinuous;
		public System.Windows.Forms.Button cmdOnce;
		public System.Windows.Forms.GroupBox fraSendAndReceive;
		public System.Windows.Forms.TextBox txtBytesReceived;
		public System.Windows.Forms.GroupBox fraBytesReceived;
		public System.Windows.Forms.CheckBox chkAutoincrement;
		public System.Windows.Forms.ComboBox cboByte1;
		public System.Windows.Forms.ComboBox cboByte0;
		public System.Windows.Forms.GroupBox fraBytesToSend;
		public System.Windows.Forms.Timer tmrDelay;
		public System.Windows.Forms.ListBox lstResults;
		internal System.Windows.Forms.GroupBox fraReportTypes;
		internal System.Windows.Forms.RadioButton optInputOutput;
		internal System.Windows.Forms.RadioButton optFeature;
		internal System.Windows.Forms.GroupBox fraInputReportBufferSize;
		internal System.Windows.Forms.TextBox txtInputReportBufferSize;
		internal System.Windows.Forms.Button cmdInputReportBufferSize;
		internal System.Windows.Forms.GroupBox fraDeviceIdentifiers;
		internal System.Windows.Forms.Label lblVendorID;
		internal System.Windows.Forms.TextBox txtVendorID;
		internal System.Windows.Forms.Label lblProductID;
		internal System.Windows.Forms.TextBox txtProductID;
		internal System.Windows.Forms.Button cmdFindDevice;
		internal System.Windows.Forms.CheckBox chkUseControlTransfersOnly;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
      this.components = new System.ComponentModel.Container();
      this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tmrContinuousDataCollect = new System.Windows.Forms.Timer(this.components);
      this.fraSendAndReceive = new System.Windows.Forms.GroupBox();
      this.cmdContinuous = new System.Windows.Forms.Button();
      this.cmdOnce = new System.Windows.Forms.Button();
      this.fraBytesReceived = new System.Windows.Forms.GroupBox();
      this.txtBytesReceived = new System.Windows.Forms.TextBox();
      this.fraBytesToSend = new System.Windows.Forms.GroupBox();
      this.chkAutoincrement = new System.Windows.Forms.CheckBox();
      this.cboByte1 = new System.Windows.Forms.ComboBox();
      this.cboByte0 = new System.Windows.Forms.ComboBox();
      this.tmrDelay = new System.Windows.Forms.Timer(this.components);
      this.lstResults = new System.Windows.Forms.ListBox();
      this.fraReportTypes = new System.Windows.Forms.GroupBox();
      this.chkUseControlTransfersOnly = new System.Windows.Forms.CheckBox();
      this.optFeature = new System.Windows.Forms.RadioButton();
      this.optInputOutput = new System.Windows.Forms.RadioButton();
      this.fraInputReportBufferSize = new System.Windows.Forms.GroupBox();
      this.cmdInputReportBufferSize = new System.Windows.Forms.Button();
      this.txtInputReportBufferSize = new System.Windows.Forms.TextBox();
      this.fraDeviceIdentifiers = new System.Windows.Forms.GroupBox();
      this.txtProductID = new System.Windows.Forms.TextBox();
      this.lblProductID = new System.Windows.Forms.Label();
      this.txtVendorID = new System.Windows.Forms.TextBox();
      this.lblVendorID = new System.Windows.Forms.Label();
      this.cmdFindDevice = new System.Windows.Forms.Button();
      this.fraSendAndReceive.SuspendLayout();
      this.fraBytesReceived.SuspendLayout();
      this.fraBytesToSend.SuspendLayout();
      this.fraReportTypes.SuspendLayout();
      this.fraInputReportBufferSize.SuspendLayout();
      this.fraDeviceIdentifiers.SuspendLayout();
      this.SuspendLayout();
      // 
      // tmrContinuousDataCollect
      // 
      this.tmrContinuousDataCollect.Interval = 1;
      this.tmrContinuousDataCollect.Tick += new System.EventHandler(this.tmrContinuousDataCollect_Tick);
      // 
      // fraSendAndReceive
      // 
      this.fraSendAndReceive.BackColor = System.Drawing.SystemColors.Control;
      this.fraSendAndReceive.Controls.Add(this.cmdContinuous);
      this.fraSendAndReceive.Controls.Add(this.cmdOnce);
      this.fraSendAndReceive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.fraSendAndReceive.Location = new System.Drawing.Point(507, 104);
      this.fraSendAndReceive.Name = "fraSendAndReceive";
      this.fraSendAndReceive.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.fraSendAndReceive.Size = new System.Drawing.Size(146, 111);
      this.fraSendAndReceive.TabIndex = 7;
      this.fraSendAndReceive.TabStop = false;
      this.fraSendAndReceive.Text = "Send and Receive Data";
      // 
      // cmdContinuous
      // 
      this.cmdContinuous.BackColor = System.Drawing.SystemColors.Control;
      this.cmdContinuous.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdContinuous.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContinuous.Location = new System.Drawing.Point(13, 72);
      this.cmdContinuous.Name = "cmdContinuous";
      this.cmdContinuous.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdContinuous.Size = new System.Drawing.Size(101, 29);
      this.cmdContinuous.TabIndex = 9;
      this.cmdContinuous.Text = "Continuous";
      this.cmdContinuous.Click += new System.EventHandler(this.cmdContinuous_Click);
      // 
      // cmdOnce
      // 
      this.cmdOnce.BackColor = System.Drawing.SystemColors.Control;
      this.cmdOnce.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdOnce.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOnce.Location = new System.Drawing.Point(13, 26);
      this.cmdOnce.Name = "cmdOnce";
      this.cmdOnce.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdOnce.Size = new System.Drawing.Size(101, 29);
      this.cmdOnce.TabIndex = 8;
      this.cmdOnce.Text = "Once";
      this.cmdOnce.Click += new System.EventHandler(this.cmdOnce_Click);
      // 
      // fraBytesReceived
      // 
      this.fraBytesReceived.BackColor = System.Drawing.SystemColors.Control;
      this.fraBytesReceived.Controls.Add(this.txtBytesReceived);
      this.fraBytesReceived.ForeColor = System.Drawing.SystemColors.ControlText;
      this.fraBytesReceived.Location = new System.Drawing.Point(173, 104);
      this.fraBytesReceived.Name = "fraBytesReceived";
      this.fraBytesReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.fraBytesReceived.Size = new System.Drawing.Size(107, 111);
      this.fraBytesReceived.TabIndex = 4;
      this.fraBytesReceived.TabStop = false;
      this.fraBytesReceived.Text = "Bytes Received";
      // 
      // txtBytesReceived
      // 
      this.txtBytesReceived.AcceptsReturn = true;
      this.txtBytesReceived.AutoSize = false;
      this.txtBytesReceived.BackColor = System.Drawing.SystemColors.Window;
      this.txtBytesReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtBytesReceived.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBytesReceived.Location = new System.Drawing.Point(13, 20);
      this.txtBytesReceived.MaxLength = 0;
      this.txtBytesReceived.Multiline = true;
      this.txtBytesReceived.Name = "txtBytesReceived";
      this.txtBytesReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtBytesReceived.Size = new System.Drawing.Size(79, 78);
      this.txtBytesReceived.TabIndex = 5;
      this.txtBytesReceived.Text = "";
      // 
      // fraBytesToSend
      // 
      this.fraBytesToSend.BackColor = System.Drawing.SystemColors.Control;
      this.fraBytesToSend.Controls.Add(this.chkAutoincrement);
      this.fraBytesToSend.Controls.Add(this.cboByte1);
      this.fraBytesToSend.Controls.Add(this.cboByte0);
      this.fraBytesToSend.ForeColor = System.Drawing.SystemColors.ControlText;
      this.fraBytesToSend.Location = new System.Drawing.Point(13, 104);
      this.fraBytesToSend.Name = "fraBytesToSend";
      this.fraBytesToSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.fraBytesToSend.Size = new System.Drawing.Size(151, 111);
      this.fraBytesToSend.TabIndex = 1;
      this.fraBytesToSend.TabStop = false;
      this.fraBytesToSend.Text = "Bytes to Send";
      // 
      // chkAutoincrement
      // 
      this.chkAutoincrement.BackColor = System.Drawing.SystemColors.Control;
      this.chkAutoincrement.Cursor = System.Windows.Forms.Cursors.Default;
      this.chkAutoincrement.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkAutoincrement.Location = new System.Drawing.Point(8, 78);
      this.chkAutoincrement.Name = "chkAutoincrement";
      this.chkAutoincrement.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkAutoincrement.Size = new System.Drawing.Size(132, 28);
      this.chkAutoincrement.TabIndex = 6;
      this.chkAutoincrement.Text = "Autoincrement values";
      // 
      // cboByte1
      // 
      this.cboByte1.BackColor = System.Drawing.SystemColors.Window;
      this.cboByte1.Cursor = System.Windows.Forms.Cursors.Default;
      this.cboByte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboByte1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.cboByte1.Location = new System.Drawing.Point(7, 52);
      this.cboByte1.Name = "cboByte1";
      this.cboByte1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cboByte1.Size = new System.Drawing.Size(84, 21);
      this.cboByte1.TabIndex = 3;
      // 
      // cboByte0
      // 
      this.cboByte0.BackColor = System.Drawing.SystemColors.Window;
      this.cboByte0.Cursor = System.Windows.Forms.Cursors.Default;
      this.cboByte0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboByte0.ForeColor = System.Drawing.SystemColors.WindowText;
      this.cboByte0.Location = new System.Drawing.Point(7, 20);
      this.cboByte0.Name = "cboByte0";
      this.cboByte0.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cboByte0.Size = new System.Drawing.Size(84, 21);
      this.cboByte0.TabIndex = 2;
      // 
      // tmrDelay
      // 
      this.tmrDelay.Interval = 1;
      // 
      // lstResults
      // 
      this.lstResults.BackColor = System.Drawing.SystemColors.Window;
      this.lstResults.Cursor = System.Windows.Forms.Cursors.Default;
      this.lstResults.ForeColor = System.Drawing.SystemColors.WindowText;
      this.lstResults.HorizontalScrollbar = true;
      this.lstResults.Location = new System.Drawing.Point(13, 221);
      this.lstResults.Name = "lstResults";
      this.lstResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lstResults.Size = new System.Drawing.Size(634, 212);
      this.lstResults.TabIndex = 0;
      // 
      // fraReportTypes
      // 
      this.fraReportTypes.Controls.Add(this.chkUseControlTransfersOnly);
      this.fraReportTypes.Controls.Add(this.optFeature);
      this.fraReportTypes.Controls.Add(this.optInputOutput);
      this.fraReportTypes.Location = new System.Drawing.Point(287, 104);
      this.fraReportTypes.Name = "fraReportTypes";
      this.fraReportTypes.Size = new System.Drawing.Size(213, 96);
      this.fraReportTypes.TabIndex = 8;
      this.fraReportTypes.TabStop = false;
      this.fraReportTypes.Text = "Report Options";
      // 
      // chkUseControlTransfersOnly
      // 
      this.chkUseControlTransfersOnly.Location = new System.Drawing.Point(20, 39);
      this.chkUseControlTransfersOnly.Name = "chkUseControlTransfersOnly";
      this.chkUseControlTransfersOnly.Size = new System.Drawing.Size(167, 20);
      this.chkUseControlTransfersOnly.TabIndex = 2;
      this.chkUseControlTransfersOnly.Text = "Use ControlTransfers Only";
      // 
      // optFeature
      // 
      this.optFeature.Location = new System.Drawing.Point(7, 65);
      this.optFeature.Name = "optFeature";
      this.optFeature.Size = new System.Drawing.Size(189, 20);
      this.optFeature.TabIndex = 1;
      this.optFeature.Text = "Exchange Feature Reports";
      // 
      // optInputOutput
      // 
      this.optInputOutput.Checked = true;
      this.optInputOutput.Location = new System.Drawing.Point(7, 20);
      this.optInputOutput.Name = "optInputOutput";
      this.optInputOutput.Size = new System.Drawing.Size(197, 19);
      this.optInputOutput.TabIndex = 0;
      this.optInputOutput.TabStop = true;
      this.optInputOutput.Text = "Exchange Input and Output Reports";
      // 
      // fraInputReportBufferSize
      // 
      this.fraInputReportBufferSize.Controls.Add(this.cmdInputReportBufferSize);
      this.fraInputReportBufferSize.Controls.Add(this.txtInputReportBufferSize);
      this.fraInputReportBufferSize.Location = new System.Drawing.Point(207, 13);
      this.fraInputReportBufferSize.Name = "fraInputReportBufferSize";
      this.fraInputReportBufferSize.Size = new System.Drawing.Size(173, 78);
      this.fraInputReportBufferSize.TabIndex = 9;
      this.fraInputReportBufferSize.TabStop = false;
      this.fraInputReportBufferSize.Text = "Input Report Buffer Size";
      // 
      // cmdInputReportBufferSize
      // 
      this.cmdInputReportBufferSize.Location = new System.Drawing.Point(80, 26);
      this.cmdInputReportBufferSize.Name = "cmdInputReportBufferSize";
      this.cmdInputReportBufferSize.Size = new System.Drawing.Size(80, 46);
      this.cmdInputReportBufferSize.TabIndex = 1;
      this.cmdInputReportBufferSize.Text = "Change Buffer Size";
      this.cmdInputReportBufferSize.Click += new System.EventHandler(this.cmdInputReportBufferSize_Click);
      // 
      // txtInputReportBufferSize
      // 
      this.txtInputReportBufferSize.Location = new System.Drawing.Point(13, 33);
      this.txtInputReportBufferSize.Name = "txtInputReportBufferSize";
      this.txtInputReportBufferSize.Size = new System.Drawing.Size(47, 20);
      this.txtInputReportBufferSize.TabIndex = 0;
      this.txtInputReportBufferSize.Text = "";
      // 
      // fraDeviceIdentifiers
      // 
      this.fraDeviceIdentifiers.Controls.Add(this.txtProductID);
      this.fraDeviceIdentifiers.Controls.Add(this.lblProductID);
      this.fraDeviceIdentifiers.Controls.Add(this.txtVendorID);
      this.fraDeviceIdentifiers.Controls.Add(this.lblVendorID);
      this.fraDeviceIdentifiers.Location = new System.Drawing.Point(13, 13);
      this.fraDeviceIdentifiers.Name = "fraDeviceIdentifiers";
      this.fraDeviceIdentifiers.Size = new System.Drawing.Size(174, 78);
      this.fraDeviceIdentifiers.TabIndex = 10;
      this.fraDeviceIdentifiers.TabStop = false;
      this.fraDeviceIdentifiers.Text = "Device Identifiers";
      // 
      // txtProductID
      // 
      this.txtProductID.Location = new System.Drawing.Point(100, 46);
      this.txtProductID.Name = "txtProductID";
      this.txtProductID.Size = new System.Drawing.Size(60, 20);
      this.txtProductID.TabIndex = 3;
      this.txtProductID.Text = "1234";
      this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
      // 
      // lblProductID
      // 
      this.lblProductID.Location = new System.Drawing.Point(13, 46);
      this.lblProductID.Name = "lblProductID";
      this.lblProductID.Size = new System.Drawing.Size(94, 18);
      this.lblProductID.TabIndex = 2;
      this.lblProductID.Text = "Product ID (hex):";
      // 
      // txtVendorID
      // 
      this.txtVendorID.Location = new System.Drawing.Point(100, 20);
      this.txtVendorID.Name = "txtVendorID";
      this.txtVendorID.Size = new System.Drawing.Size(60, 20);
      this.txtVendorID.TabIndex = 1;
      this.txtVendorID.Text = "0925";
      this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
      // 
      // lblVendorID
      // 
      this.lblVendorID.Location = new System.Drawing.Point(13, 20);
      this.lblVendorID.Name = "lblVendorID";
      this.lblVendorID.Size = new System.Drawing.Size(94, 18);
      this.lblVendorID.TabIndex = 0;
      this.lblVendorID.Text = "Vendor ID (hex):";
      // 
      // cmdFindDevice
      // 
      this.cmdFindDevice.Location = new System.Drawing.Point(387, 39);
      this.cmdFindDevice.Name = "cmdFindDevice";
      this.cmdFindDevice.Size = new System.Drawing.Size(113, 33);
      this.cmdFindDevice.TabIndex = 11;
      this.cmdFindDevice.Text = "Find My Device";
      this.cmdFindDevice.Click += new System.EventHandler(this.cmdFindDevice_Click);
      // 
      // frmMain
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(659, 452);
      this.Controls.Add(this.cmdFindDevice);
      this.Controls.Add(this.fraDeviceIdentifiers);
      this.Controls.Add(this.fraInputReportBufferSize);
      this.Controls.Add(this.fraReportTypes);
      this.Controls.Add(this.fraSendAndReceive);
      this.Controls.Add(this.fraBytesReceived);
      this.Controls.Add(this.fraBytesToSend);
      this.Controls.Add(this.lstResults);
      this.Location = new System.Drawing.Point(21, 28);
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Jan\'s HID Tester";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.Closed += new System.EventHandler(this.frmMain_Closed);
      this.fraSendAndReceive.ResumeLayout(false);
      this.fraBytesReceived.ResumeLayout(false);
      this.fraBytesToSend.ResumeLayout(false);
      this.fraReportTypes.ResumeLayout(false);
      this.fraInputReportBufferSize.ResumeLayout(false);
      this.fraDeviceIdentifiers.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion
		
    // Project: usbhidio_vbdotnet
    // Version: 2.0
    // Date: 6/24/04
		// 
    // Purpose:
		// Demonstrates USB communications with a HID-class device
		// Description:
		// Finds an attached device that matches the vendor and product IDs in the form's
		// text boxes.
		// Retrieves the device's capabilities.
		// Sends and requests HID reports.
		
		// Uses RegisterDeviceNotification() and WM_DEVICE_CHANGE messages
		// to detect when a device is attached or removed.
		// RegisterDeviceNotification doesn't work under Windows 98 (not sure why).
		
		// A list box displays the data sent and received,
		// along with error and status messages.
		
		// Combo boxes select data to send, and 1-time or timed, periodic transfers.
		
		// You can change the size of the host's Input report buffer and request to use control
		// transfers only to exchange Input and Output reports.
		
		// To view additional debugging messages, in the Visual Studio development environment,
		// select the Debug build (Build > Configuration Manager > Active Solution Configuration)
		// and view the Output window (View > Other Windows > Output)
		
		// The application uses a Delegate and the BeginInvoke and EndInvoke methods to read
		// from the device asynchronously.
		
		// If you want to only receive data or only send data, comment out the unwanted code
		// (the "Success = " line and the "If Success" block that follows it).
		
		// This project includes the following modules:
		// frmMain.vb - routines specific to the form.
		// Hid.vb - routines specific to HID communications.
		// DeviceManagement.vb - routines for obtaining a handle to a device from its GUID
		// and receiving device notifications. This routines are not specific to HIDs.
		// Debugging.vb - contains a routine for displaying API error messages.
		
		// HidDeclarations.vb - Declarations for API functions used by Hid.vb.
		// FileIODeclarations.vb - Declarations for file-related API functions.
		// DeviceManagementDeclarations.vb - Declarations for API functions used by DeviceManagement.vb.
		// DebuggingDeclarations.vb - Declarations for API functions used by Debugging.vb.
		
		// Companion device firmware for several device CPUs is available from www.Lvr.com/hidpage.htm.
		// You can use any generic HID (not a system mouse or keyboard) that sends and receives reports.
		
		// For more information about HIDs and USB, and additional example device firmware to use
		// with this application, visit Lakeview Research at http:// www.Lvr.com .
		
		// Send comments, bug reports, etc. to jan@Lvr.com .
		
		// This application has been tested under Windows 98SE, Windows 2000, and Windows XP.
		
		IntPtr _DeviceNotificationHandle;
		int _HIDHandle;
		bool _MyDeviceDetected;
		string _MyDevicePathName;
		Hid _MyHID = new Hid();
		int _ReadHandle;
		
		// Used only in viewing results of API calls in debug.write statements:
		Debugging _MyDebugging = new Debugging();
		
		DeviceManagement _MyDeviceManagement = new DeviceManagement();
		
		// Define a class of delegates that point to the Hid.DeviceReport.Read function.
		// The delegate has the same parameters as Hid.DeviceReport.Read.
		// Used for asynchronous reads from the device.
		private delegate void ReadInputReportDelegate (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] readBuffer, ref bool success);
		
		
		internal void OnDeviceChange (Message m)
		{
			
			// Purpose    : Called when a WM_DEVICECHANGE message has arrived,
			//            : indicating that a device has been attached or removed.
			// Accepts    : m - a message with information about the device
			
			Debug.WriteLine("WM_DEVICECHANGE");
			
			try
			{
				if (m.WParam.ToInt32() == DeviceManagementApiDeclarations.DBT_DEVICEARRIVAL)
				{
					
					// If WParam contains DBT_DEVICEARRIVAL, a device has been attached.
					Debug.WriteLine("A device has been attached.");
					
					// Find out if it's the device we're communicating with.
					if (_MyDeviceManagement.DeviceNameMatch(m, _MyDevicePathName))
					{
						Debug.WriteLine("My device attached");
						lstResults.Items.Add("My device attached.");
					}
					
				}
				else if (m.WParam.ToInt32() == DeviceManagementApiDeclarations.DBT_DEVICEREMOVECOMPLETE)
				{
					
					// If WParam contains DBT_DEVICEREMOVAL, a device has been removed.
					Debug.WriteLine("A device has been removed.");
					
					// Find out if it's the device we're communicating with.
					if (_MyDeviceManagement.DeviceNameMatch(m, _MyDevicePathName))
					{
						
						Debug.WriteLine("My device removed");
						lstResults.Items.Add("My device removed.");
						
						// Set MyDeviceDetected False so on the next data-transfer attempt,
						// FindTheHid() will be called to look for the device
						// and get a new handle.
						this._MyDeviceDetected = false;
					}
				}
				
				ScrollToBottomOfListBox();
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private bool FindTheHid()
		{
			
			// Purpose    : Uses a series of API calls to locate a HID-class device
			//            ; by its Vendor ID and Product ID.
			// Returns    : True if the device is detected, False if not detected.
			
			bool DeviceFound = false;
			string[] DevicePathName = new string[128];
			string GUIDString;
			System.Guid HidGuid;
			int MemberIndex = 0;
			short MyProductID = 0;
			short MyVendorID = 0;
			int Result = 0;
			FileIOApiDeclarations.SECURITY_ATTRIBUTES Security = new HID_Test_Application.FileIOApiDeclarations.SECURITY_ATTRIBUTES();
			bool Success = false;
			
			try {
				
				HidGuid = Guid.Empty;
				_MyDeviceDetected = false;
				
				// Values for the SECURITY_ATTRIBUTES structure:
				Security.lpSecurityDescriptor = 0;
				Security.bInheritHandle = System.Convert.ToInt32(true);
        Security.nLength = Marshal.SizeOf(Security);
				
				// Get the device's Vendor ID and Product ID from the form's text boxes.
				GetVendorAndProductIDsFromTextBoxes(ref MyVendorID, ref MyProductID);

        Console.WriteLine ("VendorID: " + MyVendorID.ToString());
        Console.WriteLine ("ProductID: " + MyProductID.ToString());
				
				/*
				  API function: 'HidD_GetHidGuid
				  Purpose: Retrieves the interface class GUID for the HID class.
				  Accepts: 'A System.Guid object for storing the GUID.
				  */
				
				HidApiDeclarations.HidD_GetHidGuid(ref HidGuid);
				Debug.WriteLine(_MyDebugging.ResultOfAPICall("GetHidGuid"));
				
				// Display the GUID.
				GUIDString = HidGuid.ToString();
				Debug.WriteLine("  GUID for system HIDs: " + GUIDString);
				
				// Fill an array with the device path names of all attached HIDs.
				DeviceFound = _MyDeviceManagement.FindDeviceFromGuid(HidGuid, ref DevicePathName);
				
				// If there is at least one HID, attempt to read the Vendor ID and Product ID
				// of each device until there is a match or all devices have been examined.
				
				if (DeviceFound) {
					MemberIndex = 0;
					do {
						// ***
						// API function:
						// CreateFile
						// Purpose:
						// Retrieves a handle to a device.
						// Accepts:
						// A device path name returned by SetupDiGetDeviceInterfaceDetail
						// The type of access requested (read/write).
						// FILE_SHARE attributes to allow other processes to access the device while this handle is open.
						// A Security structure. Using Null for this may cause problems under Windows XP.
						// A creation disposition value. Use OPEN_EXISTING for devices.
						// Flags and attributes for files. Not used for devices.
						// Handle to a template file. Not used.
						// Returns: a handle that enables reading and writing to the device.
						// ***
						
						_HIDHandle = FileIOApiDeclarations.CreateFile
                (DevicePathName[MemberIndex], 
                 FileIOApiDeclarations.GENERIC_READ | FileIOApiDeclarations.GENERIC_WRITE, 
                 FileIOApiDeclarations.FILE_SHARE_READ | FileIOApiDeclarations.FILE_SHARE_WRITE, 
                 ref Security, 
                 FileIOApiDeclarations.OPEN_EXISTING, 0, 0);
						
						Debug.WriteLine(_MyDebugging.ResultOfAPICall("CreateFile"));
						Debug.WriteLine("  Returned handle: " + _HIDHandle.ToString("x") + "h");
						
						if (_HIDHandle != FileIOApiDeclarations.INVALID_HANDLE_VALUE) {
							
							// The returned handle is valid,
							// so find out if this is the device we're looking for.
							
							// Set the Size property of DeviceAttributes to the number of bytes in the structure.
              //_MyHID.DeviceAttributes.Size = _MyHID.DeviceAttributes.ToString().Length;
              _MyHID.DeviceAttributes.Size = Marshal.SizeOf(_MyHID.DeviceAttributes);
							
							// ***
							// API function:
							// HidD_GetAttributes
							// Purpose:
							// Retrieves a HIDD_ATTRIBUTES structure containing the Vendor ID,
							// Product ID, and Product Version Number for a device.
							// Accepts:
							// A handle returned by CreateFile.
							// A pointer to receive a HIDD_ATTRIBUTES structure.
							// Returns:
							// True on success, False on failure.
							// ***
							
							Result = HidApiDeclarations.HidD_GetAttributes(_HIDHandle, ref _MyHID.DeviceAttributes);
							
							
							Debug.WriteLine(_MyDebugging.ResultOfAPICall("HidD_GetAttributes"));
							
							if (Result != 0) {
								
								Debug.WriteLine("  HIDD_ATTRIBUTES structure filled without error.");
								
								//Debug.WriteLine("  Structure size: " + MyHID.DeviceAttributes.Size);
								Debug.WriteLine("  Vendor ID: " + _MyHID.DeviceAttributes.VendorID.ToString("x"));
								Debug.WriteLine("  Product ID: " + _MyHID.DeviceAttributes.ProductID.ToString("x"));
								Debug.WriteLine("  Version Number: " + _MyHID.DeviceAttributes.VersionNumber.ToString("x"));
								
								// Find out if the device matches the one we're looking for.
								if ((_MyHID.DeviceAttributes.VendorID == MyVendorID) & (_MyHID.DeviceAttributes.ProductID == MyProductID)) {
									
									// It's the desired device.
									Debug.WriteLine("  My device detected");
									
									// Display the information in form's list box.
									lstResults.Items.Add("Device detected:");
									lstResults.Items.Add("  Vendor ID = " + _MyHID.DeviceAttributes.VendorID.ToString("x"));
									lstResults.Items.Add("  Product ID = " + _MyHID.DeviceAttributes.ProductID.ToString("x"));
									
									ScrollToBottomOfListBox();
									
									_MyDeviceDetected = true;
									
									// Save the DevicePathName so OnDeviceChange() knows which name is my device.
									_MyDevicePathName = DevicePathName[MemberIndex];
								} else {
									
									// It's not a match, so close the handle.
									_MyDeviceDetected = false;
									
									Result = FileIOApiDeclarations.CloseHandle(_HIDHandle);
									
									Debug.WriteLine(_MyDebugging.ResultOfAPICall("CloseHandle"));
								}
							} else {
								// There was a problem in retrieving the information.
								Debug.WriteLine("  Error in filling HIDD_ATTRIBUTES structure.");
								_MyDeviceDetected = false;
								Result = FileIOApiDeclarations.CloseHandle(_HIDHandle);
							}
						}
						
						// Keep looking until we find the device or there are no more left to examine.
						MemberIndex = MemberIndex + 1;
						
					} while (!((_MyDeviceDetected == true) |(MemberIndex == DevicePathName.Length + 1)));
				}
				
				if (_MyDeviceDetected) {
					
					// The device was detected.
					// Register to receive notifications if the device is removed or attached.
					Success = _MyDeviceManagement.RegisterForDeviceNotifications(_MyDevicePathName, this.Handle, HidGuid, ref _DeviceNotificationHandle);
					
					Debug.WriteLine("RegisterForDeviceNotifications = " + Success);
					
					// Learn the capabilities of the device.
					_MyHID.Capabilities = _MyHID.GetDeviceCapabilities(_HIDHandle);
					
					if (Success) {
						// Get and display the Input report buffer size.
						GetInputReportBufferSize();
						cmdInputReportBufferSize.Enabled = true;
						
						// Get another handle to use in overlapped ReadFiles (for requesting Input reports).
						_ReadHandle = FileIOApiDeclarations.CreateFile(_MyDevicePathName, FileIOApiDeclarations.GENERIC_READ | FileIOApiDeclarations.GENERIC_WRITE, FileIOApiDeclarations.FILE_SHARE_READ | FileIOApiDeclarations.FILE_SHARE_WRITE, ref Security, FileIOApiDeclarations.OPEN_EXISTING, FileIOApiDeclarations.FILE_FLAG_OVERLAPPED, 0);
						
						Debug.WriteLine(_MyDebugging.ResultOfAPICall("CreateFile, ReadHandle"));
						Debug.WriteLine("  Returned handle: " + _ReadHandle.ToString("x") + "h");

						// (optional)
						// Flush any waiting reports in the input buffer.
						_MyHID.FlushQueue(_ReadHandle);
					}
				} else {
					
					// The device wasn't detected.
					lstResults.Items.Add("Device not found.");
					cmdInputReportBufferSize.Enabled = false;
					cmdOnce.Enabled = true;
					
					Debug.WriteLine(" Device not found.");
					
					ScrollToBottomOfListBox();
				}
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      return _MyDeviceDetected;
    }
		
		
		private void cmdContinuous_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			// Start or stop a series of periodic transfers.
			try
			{
				if (cmdContinuous.Text == "Continuous") {
					
					// Start doing periodic transfers.
					// Change the command button to "Cancel Continuous"
					cmdContinuous.Text = "Cancel Continuous";
					
					// Enable the timer event to trigger a set of transfers.
					tmrContinuousDataCollect.Enabled = true;
					ReadAndWriteToDevice();
				} else {
					
					// Stop doing continuous transfers.
					// Change the command button to "Continuous"
					cmdContinuous.Text = "Continuous";
					
					// Disable the timer that triggers the transfers.
					tmrContinuousDataCollect.Enabled = false;
				}
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void cmdInputReportBufferSize_Click (System.Object sender, System.EventArgs e)
		{
			
			// Set the number of Input reports the host will store.
			try {
				SetInputReportBufferSize();
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void cmdFindDevice_Click (System.Object sender, System.EventArgs e)
		{
			
			// Search for a specific device.
			try {
				FindTheHid();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void cmdOnce_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			// Attempt to write a report and read a report.
			
			try {
				// Don't allow another transfer request until this one completes.
				cmdOnce.Enabled = false;
				
				ReadAndWriteToDevice();
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		private void DeviceHasChanged ()
		{
			
			// Called if the user changes the Vendor ID or Product ID in the text box.
			try
			{
				// If a device was previously detected, stop receiving notifications about it.
				if (_MyDeviceDetected) {
					_MyDeviceManagement.StopReceivingDeviceNotifications(_DeviceNotificationHandle);
				}
				
				// Search for the device the next time FindTheHid is called.
				_MyDeviceDetected = false;
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		private void ExchangeFeatureReports ()
		{
			
			// Purpose    : Sends a Feature report, then retrieves one.
			//            : Assumes report ID = 0 for both reports.
			
			string ByteValue;
			byte[] InFeatureReportBuffer;
			byte[] OutFeatureReportBuffer;
			bool Success;
			
			try
			{
				Hid.InFeatureReport myInFeatureReport = new Hid.InFeatureReport();
				Hid.OutFeatureReport myOutFeatureReport = new Hid.OutFeatureReport();
				
				// Set the size of the Feature report buffer.
				// Subtract 1 from the value in the Capabilities structure because
				// the array begins at index 0.
				OutFeatureReportBuffer = new byte[_MyHID.Capabilities.FeatureReportByteLength];
				
				// Store the report ID in the buffer:
				OutFeatureReportBuffer[0] = 0;
				
				// Store the report data following the report ID.
				// Use the data in the combo boxes on the form.
				OutFeatureReportBuffer[1] = Byte.Parse(cboByte0.SelectedIndex.ToString());
				OutFeatureReportBuffer[2] = Byte.Parse(cboByte1.SelectedIndex.ToString());
				
				// Write a report to the device
				Success = myOutFeatureReport.Write(OutFeatureReportBuffer, _HIDHandle);
				
				if (Success) {
					lstResults.Items.Add("A Feature report has been written.");
					
					Debug.WriteLine(" Feature Report ID: " + OutFeatureReportBuffer[0]);
					Debug.WriteLine(" Feature Report Data:");
					
					// Display the report data sent in the form's list box.
					lstResults.Items.Add(" Feature Report ID: " + OutFeatureReportBuffer[0]);
					lstResults.Items.Add(" Feature Report Data:");
					
					// txtBytesReceived.Text = ""
					for (int i = 1; i <= 2; i++) {
						
						// Add a leading zero to values from 0 to F.
						if (OutFeatureReportBuffer[i].ToString("x").Length < 2) {
							ByteValue = "0" + OutFeatureReportBuffer[i].ToString("x");
						} else {
							ByteValue = OutFeatureReportBuffer[i].ToString("x");
						}
						
						Debug.WriteLine(" " + ByteValue);
						lstResults.Items.Add(" " + ByteValue);
					}
				} else {
					lstResults.Items.Add("The attempt to write a Feature report has failed.");
				}
				
				// Read a report from the device.
				
				// Set the size of the Feature report buffer.
				// Subtract 1 from the value in the Capabilities structure because
				// the array begins at index 0.
				InFeatureReportBuffer = new byte[_MyHID.Capabilities.FeatureReportByteLength];
				
				// Read a report.
				myInFeatureReport.Read(_ReadHandle, _HIDHandle, ref _MyDeviceDetected, ref InFeatureReportBuffer, ref Success);
				
				if (Success) {
					lstResults.Items.Add("A Feature report has been read.");
					Debug.WriteLine(" Feature Report ID: " + InFeatureReportBuffer[0]);
					Debug.WriteLine(" Feature Report Data:");
					
					// Display the report data received in the form's list box.
					lstResults.Items.Add(" Feature Report ID: " + InFeatureReportBuffer[0]);
					lstResults.Items.Add(" Feature Report Data:");
					
					txtBytesReceived.Text = "";
					for (int i = 0; i < InFeatureReportBuffer.Length; i++) {
						
						// Add a leading zero to values from 0 to F.
						if (InFeatureReportBuffer[i].ToString("x").Length < 2) {
							ByteValue = "0" + InFeatureReportBuffer[i].ToString("x");
						} else {
							ByteValue = InFeatureReportBuffer[i].ToString("x");
						}
						
						Debug.WriteLine(" " + ByteValue);
						lstResults.Items.Add(" " + ByteValue);
						
						// Display the received bytes in the "Received Bytes" text box.
						txtBytesReceived.SelectionStart = txtBytesReceived.Text.Length;
						txtBytesReceived.SelectedText = ByteValue + "\n";
					}
				} else {
					lstResults.Items.Add("The attempt to read a Feature report has failed.");
				}
				
				ScrollToBottomOfListBox();
				
				cmdOnce.Enabled = true;
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void ExchangeInputAndOutputReports ()
		{
			
			// Purpose    : Sends an Outputreport, then retrieves an Input report.
			//            : Assumes report ID = 0 for both reports.
			
			string ByteValue;
			byte[] InputReportBuffer;
			byte[] OutputReportBuffer;
			bool Success;
			
			try
			{
				// Set the size of the Output report buffer.
				// Subtract 1 from the value in the Capabilities structure because
				// the array begins at index 0.
				OutputReportBuffer = new byte[_MyHID.Capabilities.OutputReportByteLength-1 + 1];
				
				// Store the report ID in the first byte of the buffer:
				OutputReportBuffer[0] = 0;
				
				// Store the report data following the report ID.
				// Use the data in the combo boxes on the form.
				OutputReportBuffer[1] = Byte.Parse(cboByte0.SelectedIndex.ToString());
				OutputReportBuffer[2] = Byte.Parse(cboByte1.SelectedIndex.ToString());
				
				// Write a report.
				if ((chkUseControlTransfersOnly.Checked) == true)
				{
					
					// Use a control transfer to send the report,
					// even if the HID has an interrupt OUT endpoint.
					
					Hid.OutputReportViaControlTransfer myOutputReport = new Hid.OutputReportViaControlTransfer();
					Success = myOutputReport.Write(OutputReportBuffer, _HIDHandle);
				} else {
					// If the HID has an interrupt OUT endpoint, use an interrupt transfer
					// to send the report. Otherwise use a control transfer.
					
					Hid.OutputReport myOutputReport = new Hid.OutputReport();
					Success = myOutputReport.Write(OutputReportBuffer, _HIDHandle);
				}
				
				if (Success) {
					lstResults.Items.Add("An Output report has been written.");
					
					// Display the report data in the form's list box.
					lstResults.Items.Add(" Output Report ID: " + OutputReportBuffer[0]);
					lstResults.Items.Add(" Output Report Data:");
					
					txtBytesReceived.Text = "";
					for (int i = 1; i <= 2; i++) {
						
						// Add a leading zero to values from 0 to F.
						if (OutputReportBuffer[i].ToString("x").Length < 2) {
							ByteValue = "0" + OutputReportBuffer[i].ToString("x");
						} else {
							ByteValue = OutputReportBuffer[i].ToString("x");
						}
						
						Debug.WriteLine(" " + ByteValue);
						lstResults.Items.Add(" " + ByteValue);
						
					}
				} else {
					lstResults.Items.Add("The attempt to write an Output report has failed.");
				}
				
				
				Debug.WriteLine(" Output Report ID: " + OutputReportBuffer[0]);
				Debug.WriteLine(" Output Report Data:");
				
				// Read an Input report.
				
				// Set the size of the Input report buffer.
				// Subtract 1 from the value in the Capabilities structure because
				// the array begins at index 0.
				InputReportBuffer = new byte[_MyHID.Capabilities.InputReportByteLength-1 + 1];
				
				if (chkUseControlTransfersOnly.Checked == true) {
					
					// Read a report using a control transfer.
					
					Hid.InputReportViaControlTransfer myInputReport = new Hid.InputReportViaControlTransfer();
					
					// Read the report.
					myInputReport.Read(_ReadHandle, _HIDHandle, ref _MyDeviceDetected, ref InputReportBuffer, ref Success);
					
					if (Success) {
						lstResults.Items.Add("An Input report has been read.");
						
						Debug.WriteLine(" Input Report ID: " + InputReportBuffer[0]);
						Debug.WriteLine(" Input Report Data:");
						// Display the report data received in the form's list box.
						lstResults.Items.Add(" Input Report ID: " + InputReportBuffer[0]);
						lstResults.Items.Add(" Input Report Data:");
						
						txtBytesReceived.Text = "";
						for (int i = 0; i <= InputReportBuffer.Length; i++) {
							
							// Add a leading zero to values from 0 to F.
							if (InputReportBuffer[i].ToString("x").Length < 2) {
								ByteValue = "0" + InputReportBuffer[i].ToString("x");
							} else {
								ByteValue = InputReportBuffer[i].ToString("x");
							}
							
							Debug.WriteLine(" " + ByteValue);
							lstResults.Items.Add(" " + ByteValue);
							
							// Display the received bytes in the "Received Bytes" text box.
							txtBytesReceived.SelectionStart = txtBytesReceived.Text.Length;
							txtBytesReceived.SelectedText = ByteValue + "\n";
						}
					} else {
						lstResults.Items.Add("The attempt to read an Input report has failed.");
					}
					
					ScrollToBottomOfListBox();
					
					// Enable requesting another transfer.
					cmdOnce.Enabled = true;
					
				} else {
					
					// Read a report using interrupt transfers.
					// To enable reading a report without blocking the main thread, this
					// application uses an asynchronous delegate.
					
					IAsyncResult ar;
					Hid.InputReport myInputReport = new Hid.InputReport();
					
					// Define a delegate for the Read method of myInputReport.
					ReadInputReportDelegate MyReadInputReportDelegate = new ReadInputReportDelegate( myInputReport.Read);
					
					// The BeginInvoke method calls myInputReport.Read to attempt to read a report.
					// The method has the same parameters as the Read function,
					// plus two additional parameters:
					// GetInputReportData is the callback procedure that executes when the Read function returns.
					// MyReadInputReportDelegate is the asynchronous delegate object.
					// The last parameter can optionally be an object passed to the callback.
					ar = MyReadInputReportDelegate.BeginInvoke(_ReadHandle, _HIDHandle, ref _MyDeviceDetected, ref InputReportBuffer, ref Success, new AsyncCallback( GetInputReportData), MyReadInputReportDelegate);
				}
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void frmMain_Closed (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			try {
				// Perform shutdown operations.
				Shutdown();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void frmMain_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
      Console.WriteLine ((16).ToString("x"));
      Console.WriteLine ((0).ToString("x"));
      Console.WriteLine ((255).ToString("x"));
      // Perform startup operations.
			try {
				this.Show();
				Startup();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void GetInputReportBufferSize ()
		{
			
			// Purpose    : Finds and displays the number of Input buffers
			//            : (the number of Input reports the host will store).
			
			int NumberOfInputBuffers = 0;
			
			try {
				// Get the number of input buffers.
				_MyHID.GetNumberOfInputBuffers(_HIDHandle, ref NumberOfInputBuffers);
				
				// Display the result in the text box.
				txtInputReportBufferSize.Text = System.Convert.ToString(NumberOfInputBuffers);
			
      } catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void GetInputReportData (IAsyncResult ar)
		{
			
			// Purpose    : Retrieves Input report data and status information.
			//            : This routine is called automatically when myInputReport.Read
			//            : returns.
			
			// Accepts    : ar - an object containing status information about
			//            : the asynchronous operation.
			
			string ByteValue;
			byte[] InputReportBuffer = new byte[0];
			bool Success = false;
			
			try
			{
				
				// Define a delegate using the IAsyncResult object.
				ReadInputReportDelegate deleg = ((ReadInputReportDelegate)(ar.AsyncState));
				
				// Get the IAsyncResult object and the values of other paramaters that the
				// BeginInvoke method passed ByRef.
				deleg.EndInvoke(ref _MyDeviceDetected, ref InputReportBuffer, ref Success, ar);
				
				// Display the received report data in the form's list box.
				if (ar.IsCompleted & Success) {
					
					lstResults.Items.Add("An Input report has been read.");
					
					Debug.WriteLine(" Input Report ID: " + InputReportBuffer[0]);
					Debug.WriteLine(" Input Report Data:");
					
					lstResults.Items.Add(" Input Report ID: " + InputReportBuffer[0]);
					lstResults.Items.Add(" Input Report Data:");
					
					txtBytesReceived.Text = "";
					for (int i = 0; i < InputReportBuffer.Length; i++) {
						
						// Add a leading zero to values from 0 to F.
						if (InputReportBuffer[i].ToString("x").Length < 2) {
							ByteValue = "0" + InputReportBuffer[i].ToString("x");
						} else {
							ByteValue = InputReportBuffer[i].ToString("x");
						}
						
						Debug.WriteLine(" " + ByteValue);
						lstResults.Items.Add(" " + ByteValue);
						
						// Display the report data in the "Received Data" text box.
						txtBytesReceived.SelectionStart = txtBytesReceived.Text.Length;
						txtBytesReceived.SelectedText = ByteValue + "\n";
					}
					
				} else {
					lstResults.Items.Add("The attempt to read an Input report has failed.");
					Debug.Write("The attempt to read an Input report has failed");
				}
				
				ScrollToBottomOfListBox();
				
				// Enable requesting another transfer.
				cmdOnce.Enabled = true;
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void GetVendorAndProductIDsFromTextBoxes (ref short myVendorID, ref short myProductID)
		{
			
			// Purpose    : Retrieves a Vendor ID and Product ID in hexadecimal
			//            : from the form's text boxes and converts the text to Shorts.
			// Accepts    : myVendorID - the Vendor ID as a Short.
			//            : myProductID - the Product ID as a Short.
      try {
        //myVendorID = System.Convert.ToInt16(Conversion.Val("&h" + txtVendorID.Text)) - 1107;
        //myProductID = System.Convert.ToInt16(Conversion.Val("&h" + txtProductID.Text)) - offp;
        myVendorID = short.Parse(txtVendorID.Text, System.Globalization.NumberStyles.HexNumber);
        myProductID = short.Parse(txtProductID.Text, System.Globalization.NumberStyles.HexNumber);
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void InitializeDisplay ()
		{
			
			// Purpose    : Initialize the elements on the form.
			
			string ByteValue;
			
			try {
				// Create a dropdown list box for each byte to send in a report.
				// Add a leading zero for values from 0 to F.
				for (int i = 0; i < 255; i++) {
					if (i.ToString("x").Length < 2) {
						ByteValue = "0" + i.ToString("x");
					} else {
						ByteValue = i.ToString("x");
					}
					this.cboByte0.Items.Insert(i, ByteValue);
				}
				
				for (int i = 0; i <= 255; i++) {
					if (i.ToString("x").Length < 2) {
						ByteValue = "0" + i.ToString("x");
					} else {
						ByteValue = i.ToString("x");
					}
					this.cboByte1.Items.Insert(i, ByteValue);
				}
				
				// Select a default value for each box
				this.cboByte0.SelectedIndex = 0;
				this.cboByte1.SelectedIndex = 128;
				
				// Check the autoincrement box to increment the values each time a report is sent.
				chkAutoincrement.CheckState = System.Windows.Forms.CheckState.Checked;
				
				// Don't allow the user to select an input report buffer size until there is
				// a handle to a HID.
				cmdInputReportBufferSize.Enabled = false;
				
				if (_MyHID.IsWindowsXpOrLater()) {
					
					chkUseControlTransfersOnly.Enabled = true;
					
				} else {
					// If the operating system is earlier than Windows XP,
					// disable the option to force Input and Output reports to use control transfers
					// (not supported).
					chkUseControlTransfersOnly.Enabled = false;
				}
				
				lstResults.Items.Add("For a more detailed event log, view debug statements in Visual Studio's Output window:");
				lstResults.Items.Add("Click Build > Configuration Manager > Active Solution Configuration > Debug.");
				lstResults.Items.Add("Then click View > Other Windows > Output.");
				lstResults.Items.Add("");
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void ReadAndWriteToDevice ()
		{
			
			// Purpose    : Initiates the exchanging of reports.
			//            : The application sends a report and requests to read a report.
			
			// Report header for the debug display:
			Debug.WriteLine("");
			Debug.WriteLine("***** HID Test Report *****");
			Debug.WriteLine(DateTime.Today + ": " + DateTime.Today.ToShortTimeString());
			
			try {
				// If the device hasn't been detected, was removed, or timed out on a previous attempt
				// to access it, look for the device.
				if (!_MyDeviceDetected) {
					_MyDeviceDetected = FindTheHid();
				}
				
				if (_MyDeviceDetected) {
					
					// Get the bytes to send in a report from the combo boxes.
					// Increment the values if the autoincrement check box is selected.
					if (chkAutoincrement.Checked) {
						if (cboByte0.SelectedIndex < 255) {
							cboByte0.SelectedIndex = cboByte0.SelectedIndex + 1;
						} else {
							cboByte0.SelectedIndex = 0;
						}
						if (cboByte1.SelectedIndex < 255) {
							cboByte1.SelectedIndex = cboByte1.SelectedIndex + 1;
						} else {
							cboByte1.SelectedIndex = 0;
						}
					}
					
					// An option button selects whether to exchange Input and Output reports
					// or Feature reports.
					if (optInputOutput.Checked) {
						ExchangeInputAndOutputReports();
					} else {
						ExchangeFeatureReports();
					}
				}
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		private void ScrollToBottomOfListBox ()
		{
			try {
				// Scroll to the bottom of the list box.
				lstResults.SelectedIndex = lstResults.Items.Count - 1;
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		private void SetInputReportBufferSize ()
		{
			
			// Purpose    : Set the number of Input buffers (the number of Input reports
			//            : the host will store) from the value in the text box.
			
			int NumberOfInputBuffers;
			
			try {
				// Get the number of buffers from the text box.
				NumberOfInputBuffers = int.Parse(txtInputReportBufferSize.Text);
				
				// Set the number of buffers.
				_MyHID.SetNumberOfInputBuffers(_HIDHandle, NumberOfInputBuffers);
				
				// Verify and display the result.
				GetInputReportBufferSize();
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void Shutdown ()
		{
			// Purpose    : Perform actions that must execute when the program ends.
			
			try {
				// Close open handles to the device.
				if (_HIDHandle != 0) {
					FileIOApiDeclarations.CloseHandle(_HIDHandle);
					Debug.WriteLine(_MyDebugging.ResultOfAPICall("CloseHandle (HIDHandle)"));
				}
				
				if (_ReadHandle != 0) {
					FileIOApiDeclarations.CloseHandle(_ReadHandle);
					Debug.WriteLine(_MyDebugging.ResultOfAPICall("CloseHandle (ReadHandle)"));
				}
				
				// Stop receiving notifications.
				_MyDeviceManagement.StopReceivingDeviceNotifications(_DeviceNotificationHandle);
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void Startup ()
		{
			// Purpose    : Perform actions that must execute when the program starts.
			
			try {
				_MyHID = new Hid();
				InitializeDisplay();
				tmrContinuousDataCollect.Enabled = false;
				tmrContinuousDataCollect.Interval = 1000;
				
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		private void tmrContinuousDataCollect_Tick (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			try {
				// Exchange data with the device.
				// The timer is enabled only if cmdContinous has been clicked,
				// selecting continous (periodic) transfers.
				ReadAndWriteToDevice();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void txtProductID_TextChanged (System.Object sender, System.EventArgs e)
		{
			// The Product ID has changed in the text box.
			
			try {
				DeviceHasChanged();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
		}
		
		
		private void txtVendorID_TextChanged (System.Object sender, System.EventArgs e)
		{
			// The Vendor ID has changed in the text box.
			try {
				DeviceHasChanged();
			} catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		protected override void WndProc (ref Message m)
		{
			// Purpose    : Overrides WndProc to enable checking for and handling
			//            : WM_DEVICECHANGE(messages)
			// Accepts    : m - a Windows Message
			
			try {
				// The OnDeviceChange routine processes WM_DEVICECHANGE messages.
				if (m.Msg == DeviceManagementApiDeclarations.WM_DEVICECHANGE) {
					OnDeviceChange(m);
				}
				
				// Let the base form process the message.
				base.WndProc(ref m);
			
      } catch (Exception ex) {
				HandleException(this.Name + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
		}
		
		
		static public void HandleException (string moduleName, Exception e)
		{
			// Purpose    : Provides a central mechanism for exception handling.
			//            : Displays a message box that describes the exception.
			// Accepts    : moduleName - the module where the exception occurred.
			//            : e - the exception
			string Message;
			string Caption;
			
			try {
				// Create an error message.
				Message = "Exception: " + e.Message + Environment.NewLine + "Module: " + moduleName + Environment.NewLine + "Method: " + e.TargetSite.Name;
				
				// Specify a caption.
				Caption = "Unexpected Exception";
				
				// Display the message in a message box.
				MessageBox.Show(Message, Caption, MessageBoxButtons.OK);
				Debug.Write(Message);
				
      } catch (Exception ex) {
        Debug.WriteLine ("HandleException: " + ex.Message);
      }
			
		}

		
	}
}
