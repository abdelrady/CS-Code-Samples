using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Tracking_Using_bgEstimation
{
    public partial class Splash : Form
    {       
        public Splash(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}