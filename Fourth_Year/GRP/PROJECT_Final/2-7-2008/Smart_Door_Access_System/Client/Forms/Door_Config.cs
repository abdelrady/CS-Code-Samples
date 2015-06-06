using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;
using SmartDoor.Properties;
using System.Security.Cryptography;

namespace SmartDoor
{
    public partial class Door_Config : Form
    {
        Door InternalDoor;
        string oldPassword;
        public Door_Config(string str, Door door, string oPassword)
        {
            InitializeComponent();
            oldPassword = oPassword;
            //  writeUsernameAndPw("asd", "asd");
            cboencryptionalogorithm.SelectedIndex = 0;
            this.Text = "Configuraton of Door [" + str + "]";
            standalone_cbo.SelectedItem = standalone_cbo.Items[1];
            log_or_not_cbo.SelectedItem = log_or_not_cbo.Items[0];
            if (Configuration.DoorDisabled)
                tabControl1.TabPages.RemoveAt(2);
            else
            {
                InternalDoor = door;
                InternalDoor.L1 = lblDoorStatus;
                InternalDoor.L2 = lblStatusBins;
                InternalDoor.L3 = label25;
            }


        }
        private void writeUsernameAndPw(string password)
        {

            RijndaelManaged ri = new RijndaelManaged();
            Rfc2898DeriveBytes rf = new Rfc2898DeriveBytes("cms.com", Encoding.ASCII.GetBytes("smartsoor by ali and abdelrady"));


            ri.Key = rf.GetBytes(ri.KeySize / 8);

            ri.IV = rf.GetBytes(ri.BlockSize / 8);


            CryptoStream cs = new CryptoStream(File.Create("KEYConfig.cfg"), ri.CreateEncryptor(), CryptoStreamMode.Write);

            StreamWriter sr = new StreamWriter(cs);


            sr.WriteLine(password);

            sr.Close();
        }
        private void Door_Config_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Black, 10), new Rectangle(this.Width - 1, this.Height - 1, 0, 0));

            //LinearGradientBrush brBrush;
            //Rectangle rcBrush = new Rectangle(0, 0, this.Width, this.Height); ;
            //brBrush = new LinearGradientBrush(rcBrush, Color.Green, Color.Black, LinearGradientMode.ForwardDiagonal);

            //brBrush.WrapMode = WrapMode.Tile;
            //brBrush.SetSigmaBellShape(0);
            //ColorBlend cb = new ColorBlend(2);
            //cb.Positions[0] = 0.0f;
            //cb.Positions[1] = 1.0f;
            //cb.Colors[0] = Color.White;
            //cb.Colors[1] = Color.Silver;


            //brBrush.InterpolationColors = cb;

            //e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.CompositingMode = CompositingMode.SourceCopy;
            //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            //e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            //Rectangle rcClient = new Rectangle(0, 0, this.Width, this.Height);
            //Rectangle rcContent = rcClient;
            //e.Graphics.FillRectangle(brBrush, rcContent);
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(TimeoutTXT.Text) < 500)
            {
                MessageBox.Show(
                                   this,
                                   "Timeout must be larger than 500 ms.",
                                   "Smart Door",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            else if (int.Parse(txtAttemptsCount.Text) < 1)
            {
                MessageBox.Show(
                                   this,
                                   "Minimum number of connection attempts must not less than 1.",
                                   "Smart Door",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show(
                    this,
                    "Are you sure that you want to change configuration?",
                    "Smart Door",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save_Configuration();
                    MessageBox.Show(
                        this,
                        "Configuration saving succeeded,\nYou Must Restart Application To apply new configurations.",
                        "Smart Door",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                if (!File.Exists(Directory.GetCurrentDirectory() + "\\Data\\Config.ini") || Configuration.Not_Valid())
                {
                    MessageBox.Show(
                            this,
                            "Configuration file [Config.ini] Not Exists,Or Unvalid configuration,\nApplication will exit.",
                            "Fetal Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }

            }
        }

        private void Save_Configuration()
        {
            #region <<<<<<<<<<<<<File & Folder Existance & Creation>>>>>>>>>>>>
            /*
             * DON NOT TOUCH THIS CODE ????!!!!!!!!!!!!!
             */
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Data"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Data");

            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Data\\Config.ini"))
                File.Create(Directory.GetCurrentDirectory() + "\\Data\\Config.ini").Close();

            else
                File.Open(Directory.GetCurrentDirectory() + "\\Data\\Config.ini", FileMode.Truncate).Close();
            #endregion
            bool Connect_To_Sql = false;
            string standalone = "Not Configured";
            if (standalone_cbo.SelectedIndex == 2)//sql server
                Connect_To_Sql = true;
            else if (standalone_cbo.SelectedIndex == 0)
            {
                Connect_To_Sql = false;
                standalone = "On";
            }
            else if (standalone_cbo.SelectedIndex == 1)
            {
                Connect_To_Sql = false;
                standalone = "Off";
            }
            Configuration.Write_Config(
                               ip_txt.Text,
                               port_txt.Text,
                               password_txt.Text,
                               id_txt.Text,
                               name_txt.Text,

                               standalone,
                               standalone_file_name_txt.Text,
                               normal_mode_filename_txt.Text,

                               log_or_not_cbo.Text,
                               log_filename_txt.Text,

                               wait_open_txt.Text,
                               lpt_portAddr_txt.Text,
                               UpdatesPortTXT.Text,
                               CHK_AutoConnect.Checked,
                               TimeoutTXT.Text,
                               TxtCnnStr.Text,
                               Connect_To_Sql,
                               chkEnableDoor.Checked, txtAttemptsCount.Text);


        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Door_Config_Load(object sender, EventArgs e)
        {
            Configuration.Read_Config();
            if (Configuration.SQLConnection == true)
                standalone_cbo.SelectedIndex = 2;
            else if (Configuration.StandaloneMode.ToLower() == "on")
                standalone_cbo.SelectedIndex = 0;
            else if (Configuration.StandaloneMode.ToLower() == "off")
                standalone_cbo.SelectedIndex = 1;
            ip_txt.Text = Configuration.ServerIP;
            port_txt.Text = Configuration.ServerPort;
            password_txt.Text = Configuration.ClientPassword;
            id_txt.Text = Configuration.ClientId;
            name_txt.Text = Configuration.ClientName;


            standalone_file_name_txt.Text = Configuration.StandaloneModeStudentsFile;
            normal_mode_filename_txt.Text = Configuration.NormalModeStudentsFile;

            log_or_not_cbo.Text = Configuration.TextLog;
            log_filename_txt.Text = Configuration.TextLogFileName;

            wait_open_txt.Text = Configuration.WaitOnOpened.ToString();
            lpt_portAddr_txt.Text = Configuration.LptPortAddressBase.ToString();
            UpdatesPortTXT.Text = Configuration.UpdatesPort;
            CHK_AutoConnect.Checked = Configuration.AutoConnect;
            TimeoutTXT.Text = Configuration.TimeOut;
            TxtCnnStr.Text = Configuration.connectionString;
            chkEnableDoor.Checked = Configuration.DoorDisabled;
            txtAttemptsCount.Text = Configuration.AttemptsCount;


        }

        private void Cmd_View_File_Click(object sender, EventArgs e)
        {
            Configuration.Open_Configuration_File();
        }



        private void txtmachinename_TextChanged(object sender, EventArgs e)
        {
            TxtCnnStr.Text = "Data Source=" + txtmachinename.Text + "\\SQLEXPRESS;initial catalog='" + txtinitialcatalog.Text + "';Integrated Security=" + txtintegratedsecurity.Text + ";persist security info=" + txtpersistantsecurityinfo.Text + " ;Connect Timeout=" + txttimeout.Text + ";User Instance=" + txtuserinstance.Text + ";uid=" + txtusername.Text + ";password=" + txtpassword.Text;
        }

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            btnOpenDoor.Enabled = false;
            btnCloseDoor.Enabled = true;
            pictureBox1.Image = Resources.opened_new;
            InternalDoor.OpenDoor();
        }

        private void BtnCloseDoor_Click(object sender, EventArgs e)
        {
            btnOpenDoor.Enabled = true;
            btnCloseDoor.Enabled = false;
            pictureBox1.Image = Resources.door_new_Closed;
            InternalDoor.CloseDoor();
        }

        private void chkInvertBins_CheckedChanged(object sender, EventArgs e)
        {

            InternalDoor.InvertBins();
        }

        private void chkEnableDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableDoor.Checked == true)
            {
                chkEnableDoor.Text = "Door is Disabled";
            }
            else
                chkEnableDoor.Text = "Door is Enabled";
        }

        private void btnsetAccount_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != oldPassword)
            {
                MessageBox.Show(this, "Old Password is Invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Text = "";

                textBox2.Focus();
                return;
            }

            if (textBox1.Text != txtpassword2.Text)
            {
                MessageBox.Show(this, "Passwords Does not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Text = "";
                txtpassword2.Text = "";
                textBox1.Focus();
                return;
            }

            writeUsernameAndPw(textBox1.Text.Trim());
            MessageBox.Show(this, "Data successfully saved.", "Smart Door Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}