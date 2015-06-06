using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VS2005Demo
{
    public partial class Form1 : Form
    {
        private int currentSkin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Sunisoft skin file (ssk file) | *.ssk";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                skinEngine1.SkinFile = dialog.FileName;
                if (!skinEngine1.Active)
                    skinEngine1.Active = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skinEngine1.Active = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Visual Studio 2005 ! ", "IrisSkin2",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowDialog();
        }

        private void diamonGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyMainBuiltInSkin();
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void mSNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(0);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void sportsBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(1);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void macOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(2);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void steelBlackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(3);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void xPSilverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(4);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(currentSkin);
            currentSkin++;
            if (currentSkin == 5)
                currentSkin = 0;
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyMainBuiltInSkin();
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
        }
    }
}