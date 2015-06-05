using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace get_Screen_capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            SendKeys.Send("{PRTSC}");
            pictureBox1.Image = Clipboard.GetImage();
            img = Clipboard.GetImage();
            try
            {
                img.Save("c:\\image.jpg", ImageFormat.Jpeg);
            }
            catch
            {
               // MessageBox.Show("Failed to save image to JPg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 500;
        }
        Image img;
        int i=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("%{PRTSC}");
            pictureBox1.Image = Clipboard.GetImage();
            img = Clipboard.GetImage();
            try
            {
                img.Save("image" + i.ToString() + ".jpg", ImageFormat.Jpeg);
            }
            catch
            {
                MessageBox.Show("Failed to save image to JPg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
            pictureBox1.Image = Clipboard.GetImage();
            img = Clipboard.GetImage();
            try
            {
                img.Save("c:\\image.jpg", ImageFormat.Jpeg);
            }
            catch
            {
                MessageBox.Show("Failed to save image to JPg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{F4}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(%({DEL}))");
        }
    }
}