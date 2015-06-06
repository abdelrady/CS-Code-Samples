using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;

namespace USB_Write_Protection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.CheckBox chkOnOff;
		internal System.Windows.Forms.Button btnSave;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.chkOnOff = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chkOnOff
			// 
			this.chkOnOff.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkOnOff.Location = new System.Drawing.Point(24, 7);
			this.chkOnOff.Name = "chkOnOff";
			this.chkOnOff.Size = new System.Drawing.Size(120, 24);
			this.chkOnOff.TabIndex = 4;
			this.chkOnOff.Text = "Enable Write Protect";
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSave.Location = new System.Drawing.Point(176, 7);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save Change";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 38);
			this.Controls.Add(this.chkOnOff);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "USB Write Protection";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Sets up the WriteBlock variable to point to the Local_Machine hive
			// of the windows registry.
			RegistryKey WriteBlock = Registry.LocalMachine;
			// This sets up WriteBlock to open the specific sub key that is needed
			// and also sets up the permissions to allow writing to it.
			WriteBlock = WriteBlock.OpenSubKey("System\\CurrentControlSet\\Control\\" +
				"StorageDevicePolicies", true);

			try
			{
				// This checks to make sure that sub key and value exist in the 
				// registry.
				if (WriteBlock == null)
				{
					// If the sub key does not exist then it is created.
					WriteBlock = Registry.LocalMachine.CreateSubKey("System\\" +
						"CurrentControlSet\\Control\\StorageDevicePolicies");
					// Once the sub key is created it is opened and the permissions
					// are set to be writeable.
					WriteBlock.OpenSubKey("System\\CurrentControlSet\\Control\\" + 
						"StorageDevicePolicies", true);
					// Now the value is created and set.
					WriteBlock.SetValue("WriteProtect", 0);
				}
			}
			catch (Exception ex)
			{
				// If there is any kind of error creating the sub key and value
				// this will show the message to the end user.
				MessageBox.Show("Error:\n" + ex.Message.ToString(), 
					"Error Creating Registry Value", MessageBoxButtons.OK, 
					MessageBoxIcon.Error);
			}

			try
			{
				// If the value comes back as being null then we create
				// the value and populate it with a zero which will 
				// create the value in a disabled state.
				if (WriteBlock.GetValue("WriteProtect") == null)
				{
					WriteBlock.SetValue("WriteProtect", 0);
				}
			}
			catch (Exception ex)
			{
				// If there is any kind of error creating the sub key and value
				// this will show the message to the end user.
				MessageBox.Show("Error:\n" + ex.Message.ToString(), 
					"Error Creating Registry Value", MessageBoxButtons.OK, 
					MessageBoxIcon.Error);
			}

			try
			{
				// This checks the value returned from the registry.  If the 
				// value is a zero then it executes the code.  If the value
				// is a one it goes on to the next step.
				if (WriteBlock.GetValue("WriteProtect").ToString() == "0")
				{
					// If the value returned is a zero then the check box is
					// loaded in a non checked state.
					this.chkOnOff.Checked = false;
				}
				// If the value returned is a one then the following code is 
				// executed.
				else if (WriteBlock.GetValue("WriteProtect").ToString() == "1")
				{
					// If the value comes back as a one then the check box is
					// loaded in a checked state.
					this.chkOnOff.Checked = true;
				}
			}
			catch (Exception ex)
			{
				// If there is any kind of error creating the sub key and value
				// this will show the message to the end user.
				MessageBox.Show("Error:\n" + ex.Message.ToString(), 
					"Error Reading Registry Value", MessageBoxButtons.OK, 
					MessageBoxIcon.Error);
			}

		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			// Sets up the WriteBlock variable to point to the Local_Machine hive
			// of the windows registry.
			RegistryKey WriteBlock = Registry.LocalMachine;
			// This sets up WriteBlock to open the specific sub key that is needed
			// and also sets up the permissions to allow writing to it.
			WriteBlock = WriteBlock.OpenSubKey("System\\CurrentControlSet\\Control\\" +
				"StorageDevicePolicies", true);

			try
			{
				// This checks to see if the checkbox is checked or not.
				if (this.chkOnOff.Checked == true)
				{
					// If the checkbox is checked then a value of one is written
					// to the registry enabling the USB write protection.
					WriteBlock.SetValue("WriteProtect", 1);
					// A message box is shown to the end user telling them that the 
					// value was written and that write protection is now enalbed.
					MessageBox.Show("USB write protection is now enabled.", 
						"Write Protection",	MessageBoxButtons.OK, 
						MessageBoxIcon.Information);
					// Changes the caption of the form to show that the write
					// protection is enabled.
					this.Text = "USB Write Protection - On";
				}
				// This is the catch if the checkbox is not checked.
				else if (this.chkOnOff.Checked == false)
				{
					// If the checkbox is not checked then a value of zero is
					// written to the registry disabling the USB write 
					// protection.
					WriteBlock.SetValue("WriteProtect", 0);
					// A message box is shown to the end user telling them that the 
					// value was written and that write protection is now disalbed.
					MessageBox.Show("USB write protection is now disabled.", 
						"Write Protection", MessageBoxButtons.OK, 
						MessageBoxIcon.Information);
					// Changes the caption of the form to show that the write
					// protection is enabled.
					this.Text = "USB Write Protection - Off";
				}
			}
			catch (Exception ex)
			{
				// If there is any kind of error creating the sub key and value
				// this will show the message to the end user.
				MessageBox.Show("Error:\n" + ex.Message.ToString(), 
					"Error Changing Registry Value", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}
