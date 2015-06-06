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

namespace SmartDoor
{
    public partial class Door_Config : Form
    {
        public Door_Config(string str)
        {
            InitializeComponent();
            this.Text = "Configuraton of Door [" + str+"]";
            standalone_cbo.SelectedItem = standalone_cbo.Items[1];
            log_or_not_cbo.SelectedItem = log_or_not_cbo.Items[0];
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

            Configuration.Write_Config(
                               ip_txt.Text,
                               port_txt.Text,
                               password_txt.Text,
                               id_txt.Text,
                               name_txt.Text,

                               standalone_cbo.Text,
                               standalone_file_name_txt.Text,
                               normal_mode_filename_txt.Text,

                               log_or_not_cbo.Text,
                               log_filename_txt.Text,

                               wait_open_txt.Text,
                               lpt_portAddr_txt.Text,
                               UpdatesPortTXT.Text,
                               CHK_AutoConnect.Checked,
                               TimeoutTXT.Text,TxtCnnStr.Text,CHK_Connect_To_Sql.Checked);


        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Door_Config_Load(object sender, EventArgs e)
        {
            Configuration.Read_Config();
            CHK_Connect_To_Sql.Checked = Configuration.SQLConnection;
            ip_txt.Text = Configuration.ServerIP;
            port_txt.Text = Configuration.ServerPort;
            password_txt.Text = Configuration.ClientPassword;
            id_txt.Text = Configuration.ClientId;
            name_txt.Text = Configuration.ClientName;

            standalone_cbo.Text = Configuration.StandaloneMode;
            standalone_file_name_txt.Text = Configuration.StandaloneModeStudentsFile;
            normal_mode_filename_txt.Text = Configuration.NormalModeStudentsFile;

            log_or_not_cbo.Text = Configuration.TextLog;
            log_filename_txt.Text = Configuration.TextLogFileName;

            wait_open_txt.Text = Configuration.WaitOnOpened.ToString();
            lpt_portAddr_txt.Text = Configuration.LptPortAddressBase.ToString();
            UpdatesPortTXT.Text= Configuration.UpdatesPort;
            CHK_AutoConnect.Checked = Configuration.AutoConnect;
            TimeoutTXT.Text = Configuration.TimeOut;
            TxtCnnStr.Text = Configuration.connectionString;
            

        }

        private void Cmd_View_File_Click(object sender, EventArgs e)
        {
            Configuration.Open_Configuration_File();
        }

 

        private void txtmachinename_TextChanged(object sender, EventArgs e)
        {
            TxtCnnStr.Text = "Data Source=" + txtmachinename.Text + "\\SQLEXPRESS;initial catalog='" + txtinitialcatalog.Text + "';Integrated Security=" + txtintegratedsecurity.Text + ";persist security info=" + txtpersistantsecurityinfo.Text + " ;Connect Timeout=" + txttimeout.Text + ";User Instance=" + txtuserinstance.Text + ";uid=" + txtusername.Text + ";password=" + txtpassword.Text;
        }
    }
}