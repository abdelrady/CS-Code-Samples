using System;

using System.ComponentModel;
using System.Windows.Forms;



namespace ChatServer
{
    public partial class login : Form
    {
        public bool mico = false;
        public string userName = "";
       
        public string dblocationMain = "";
        public enum Splash { DontShow, Show }
        Splash Mode = Splash.Show;

        public login()
        {
            //    Splash GivenMode
            //    Mode = GivenMode;
            InitializeComponent();          
            /*
             * From --*Eagle*-- Library ->Disable login Close BTN
             */
            Ali_API.CloseButtonRemove.Disable(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // /* try
            //   {
            //       System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\CcAppDC.exe", Directory.GetCurrentDirectory() + "\\New Microsoft Office Access Application.mdb");
            //   }
            //   catch (Exception f)
            //   {
            //       MessageBox.Show(f.Message);
            //   }

            //   */
            //   //installation Date
            //   /*
            //   Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\AUD");
            //   Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\AUD", true).SetValue("IDte", DateTime.Today.Date.ToString());
            //   */

            //   //---------------Processing-----------------------
            //    DateTime Now = new DateTime();
            //    Now=DateTime.Now.Date;

            //    //---------------Reading From Reg and add trial interval 30 day ---------------
            ////    DateTime Regnow = Convert.ToDateTime(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\AUD", true).GetValue("IDte", RegistryValueOptions.DoNotExpandEnvironmentNames).ToString()).AddMonths(1);

            //  /*  if (DateTime.Compare(Regnow, DateTime.Now.Date) >= 0)
            //    {
            //        MessageBox.Show("Expaired");



            //            Close();

            //            FileStream f = File.Open(Directory.GetCurrentDirectory() + "\\CcAppD.exe", FileMode.Create);
            //            f.Write(Properties.Resources.CcAppD, 0, Properties.Resources.CcAppD.Length);
            //            f.Close();
            //            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\CCAPPD.exe", Directory.GetCurrentDirectory() + "\\New Bitmap Image.bmp");


            //        Application.Exit();
            //        //Application.ExitThread();

            //    }*/


            /*    if (Mode == Splash.Show)
                {
                    splash frm = new splash(false);
                    frm.ShowDialog(this);
                }
                else;
                dBConnection = Lutility.getDbConnection();
                if (dBConnection == null) Application.ExitThread();
                Lutility.RefreshMe();
                Lutility.fillComboBox(UserCombo, "SELECT Name FROM EmployeeView ");
                UserCombo.Text = UserCombo.Items[0].ToString();*/
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Environment.Exit(System.Environment.ExitCode);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Close();
            // bool TrueOrFalse = false;
            // DataTable daTable = new DataTable();

            //// daTable = Lutility.getDataTable("SELECT Name , Password1 FROM EmployeeView ");           
            // for (int i = 0; i < daTable.Rows.Count; i++)
            // {
            //     DataRow dr = daTable.Rows[i];
            //     if (UserCombo.Text == dr["Name"].ToString() && PassWordTXT.Text == dr["Password1"].ToString())
            //     {
            //         TrueOrFalse = true;
            //         userName = UserCombo.Text;
            //         this.Dispose();
            //     }
            // }
            // if (TrueOrFalse == false)
            // {
            //     MessageBox.Show("  ÚÝæÇú , áÇíãßäß ÇáÏÎæá    ", "ÎØÃ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     PassWordTXT.Text = "";
            //     PassWordTXT.Focus();
            // }

        }


    }
}