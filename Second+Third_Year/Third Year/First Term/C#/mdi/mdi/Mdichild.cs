using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mdi
{
    public partial class Mdichild : Form
    {
        public Mdichild()
        {
            InitializeComponent();
        }

        private void openIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation  = openFileDialog1.FileName;
        }
    }
}