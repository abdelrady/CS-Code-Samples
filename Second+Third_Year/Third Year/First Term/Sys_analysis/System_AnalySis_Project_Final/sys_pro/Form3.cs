using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DefaultNamespace;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form3 : Form
    {
        public Connection Asd;
        public DefaultNamespace.MainForm fform;
        public Form3()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FormEffect.Fade.In(this, 1.0, .03);
            //WindowsApplication1.login a = new login();
            timer1.Enabled = true;
            progressBar1.Visible = true;
            Asd = new Connection();
            //a.connect();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value <= 30)

                label2.Text = "ÈÏÇíÉ ÊÔÛíá ÇáÈÑäÇãÌ Ü Ü Ü Ü";

       else if (progressBar1.Value <= 50)

                label2.Text = "ÊÍãíá ÇáÈÑäÇãÌ Ü Ü Ü Ü";

       else if (progressBar1.Value <= 70)

                label2.Text = "ÇáÊÍÞíÞ ãä ÇáãáÝÇÊ Ü Ü Ü Ü";

       else if (progressBar1.Value <= 100)

                label2.Text = "ÇáÑÌÇÁ ÇáÇäÊÙÇÑ Ü-Ü-Ü-Ü-Ü";

            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                this.Hide();
                fform = new DefaultNamespace.MainForm(Asd);
                fform.ShowDialog();
                this.Dispose();
            }

            this.Update();
        }

    }
}