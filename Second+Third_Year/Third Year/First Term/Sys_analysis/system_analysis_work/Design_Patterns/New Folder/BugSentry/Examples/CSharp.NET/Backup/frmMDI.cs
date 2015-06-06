using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BugSentryDemoCSharp {

	public class frmMDI : System.Windows.Forms.Form {
		private static frmMDI myInstance ;
		private ITCollaborate.BugSentry.Sentry _Sentry;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuBuggyForm;
		private System.Windows.Forms.MenuItem menuItem5;
		private static frmConfirmReport myErrorReportForm;
		private System.ComponentModel.Container components = null;

		public frmMDI() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			myInstance=this;
		}


		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
		private void InitializeComponent() {
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuBuggyForm = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.menuItem1,
																											 this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.menuItem2});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "E&xit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.mnuBuggyForm,
																											 this.menuItem5});
			this.menuItem3.Text = "F&orms";
			// 
			// mnuBuggyForm
			// 
			this.mnuBuggyForm.Index = 0;
			this.mnuBuggyForm.Text = "&Trivial Example";
			this.mnuBuggyForm.Click += new System.EventHandler(this.mnuBuggyForm_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "&Feedback Form";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// frmMDI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmMDI";
			this.Text = "C# Example";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

		}
		#endregion

		[STAThread]
		static void Main() {
			Application.Run(new frmMDI());
		}
		private void mnuBuggyForm_Click(object sender, System.EventArgs e) {
			try {
				frmTrivialExample.GetInstance().MdiParent = this;
				frmTrivialExample.GetInstance().Show();
			}
			catch (Exception ex) {
				this.Sentry.Report(ex);
				System.Windows.Forms.MessageBox.Show(ex.ToString());				  
			}

		}
			public static void ReportErrorIfUserOKs(Exception ex){
				if(myErrorReportForm ==null){
					myErrorReportForm = new frmConfirmReport("A serious error has occurred.  Report this to ACME software?","Yes","No","Send error report?");
				}		
				myErrorReportForm.setException(ex);
				myErrorReportForm.ShowDialog();
				if (myErrorReportForm.DialogResult==System.Windows.Forms.DialogResult.OK){
					frmMDI.GetInstance().Sentry.Report(ex);
				}

			}
		public static frmMDI GetInstance() {
			if (myInstance ==null) {
				myInstance = new frmMDI();
			}
			return myInstance;		
		}
		
		private void menuItem2_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}



		private void menuItem5_Click(object sender, System.EventArgs e) {
			try {
				frmFeedback frm;
				frm=new frmFeedback();
				frm.Show();
			}
			catch (Exception ex) {
				this.Sentry.Report(ex);
				System.Windows.Forms.MessageBox.Show("A serious error has occurred: " + ex.Message + "\r\nStaff have been notified.");
			}
		}

		/* Edit private variables with the specifics of your license. 
		 * License code and public key can be copied from the Tools menu in the desktop client. */
		
		public ITCollaborate.BugSentry.Sentry Sentry {
			get {
				///COPY VALUE FROM BUGSENTRY DEV CLIENT
				string MyLicenseCode = null;
				///COPY VALUE FROM BUGSENTRY DEV CLIENT
				string MyPublicKey = null;
				////BugSentry will create it if it doesn't exist, but BugSentry must have exclusive access to this directory.  Store nothing else here.
				string myCacheDirectory = null;
				///Instructs BugSentry to cache issues in a directory on the hard drive.
				ITCollaborate.BugSentry.Sentry.CacheStorageTypes myCacheType = ITCollaborate.BugSentry.Sentry.CacheStorageTypes.Directory;
					
				
				
				if (_Sentry == null) {
					if (MyLicenseCode ==null) {
						System.Windows.Forms.MessageBox.Show("License code not specified.  Copy it from the BugSentry Dev Client's Tools menu.");
						System.Windows.Forms.MessageBox.Show("This application will now crash horribly.");
						return null;
					}
					if (MyPublicKey ==null) {
						System.Windows.Forms.MessageBox.Show("Public Key not specified.  Copy it from the BugSentry Dev Client's Tools menu.");
						System.Windows.Forms.MessageBox.Show("This application will now crash horribly.");
						return null;
					}
							 
					if (myCacheDirectory ==null && myCacheType == ITCollaborate.BugSentry.Sentry.CacheStorageTypes.Directory ) {
						System.Windows.Forms.MessageBox.Show("Cache directory not specified.  Specify a directory to which you have permissions.");
						System.Windows.Forms.MessageBox.Show("This application will now crash horribly.");
						return null;
					}	
					_Sentry = new ITCollaborate.BugSentry.Sentry(MyLicenseCode, MyPublicKey, myCacheType,myCacheDirectory);
				
	
				}
				return _Sentry;
			}

		}
	}
}
