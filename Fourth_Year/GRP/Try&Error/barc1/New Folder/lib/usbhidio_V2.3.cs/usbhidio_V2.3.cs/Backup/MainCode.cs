using System;
using System.Windows.Forms;

namespace HID_Test_Application
{
	/// <summary>
	/// Summary description for MainCode.
	/// </summary>
	public class MainCode
	{
		public MainCode()
		{
			//
			// TODO: Add constructor logic here
			//
		}

    [STAThread]
    static void Main() {
      Application.Run(new frmMain());
    }
  
  }
}
