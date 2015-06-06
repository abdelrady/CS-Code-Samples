using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Picture_show
{
    public partial class Form1 : Form
    {
        int h, w;
        int ch, cw,chm,cwm;
        bool max = false;
        string[] iconFiles;
        string[] iconFiles2;
        string[] allImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iconFiles = Directory.GetFiles(Application.StartupPath, "*.jpg");
            iconFiles2 = Directory.GetFiles(Application.StartupPath, "*.gif");
            allImage=new string [iconFiles.Length+iconFiles2.Length];
            for (int i = 0; i < iconFiles.Length; i++)
            {

                allImage[i] = iconFiles[i];
            }
            for(int j=iconFiles.Length;j<iconFiles2.Length;j++)
            {
                allImage[j]=iconFiles2[j];
            }
            ch = SystemInformation.VirtualScreen.Height / 2;
            chm = SystemInformation.VirtualScreen.Height / 2;
            cw = SystemInformation.VirtualScreen.Width / 2;
            cwm = SystemInformation.VirtualScreen.Width / 2;
            this.Location = new System.Drawing.Point(cw, ch);
            this.ClientSize = new System.Drawing.Size(0, 0);
            
        }
        int p=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((h == SystemInformation.VirtualScreen.Height) && (w == SystemInformation.VirtualScreen.Width))
                {

                    max = true;
                }
                if (h == 0 && w == 0)
                {
                    max = false;
                    if (p == allImage.Length) p = 0;
                    else

                        pictureBox1.ImageLocation = allImage[p];
                    p++;
                    label1.Text = "Picture No:" + (p);
                }
                if (max == false)
                {

                    this.ClientSize = new System.Drawing.Size(w, h);

                    this.Location = new System.Drawing.Point(cw, ch);
                    if (cw > 0)
                        cw -= 4;
                    if (ch > 0)
                        ch -= 3;
                    if (h < SystemInformation.VirtualScreen.Height)
                        h += 6;
                    if (w < SystemInformation.VirtualScreen.Width)
                        w += 8;
                }
                else if (max == true)
                {



                    this.ClientSize = new System.Drawing.Size(w, h);

                    this.Location = new System.Drawing.Point(cw, ch);
                    if (cw < cwm)
                        cw += 4;
                    if (ch < chm)
                        ch += 3;
                    if (h > 0)
                        h -= 6;
                    if (w > 0)
                        w -= 8;
                }
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("No Found Picture here with jpgor gif extention");
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}