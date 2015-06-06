using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO ;

namespace WindowsApplication1
{

    public partial class master : Form
    {
        
        //Button button1=new Button();
          //  this.button1 = new System.Windows.Forms.Button();

        public master()
        {
               
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text =="œŒÊ·")
            {

                login asd = new login();
                asd.ShowDialog();
                if (asd.DialogResult == DialogResult.Cancel)
                {
                    button1.Text = "Œ—ÊÃ";
                    bell.Enabled = true;
                    addd.Enabled = true;
                    hellep.Enabled = true;
                }
            }
            else
             if(button1 .Text =="Œ—ÊÃ")
                {
               //         MessageBox.Show("Â·  —Ìœ «·Œ—ÊÃøø", "Œ—ÊÃ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (MessageBox.Show("Â·  —Ìœ «·Œ—ÊÃøø", "Œ—ÊÃ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        button1.Text = "œŒÊ·";
                        hellep.Enabled = false;
                        addd.Enabled = false;
                        bell.Enabled = false;
                    }
                    else
                    {
                     
                        return;
                    }
                   
                 }

      
        }

        private void master_Load(object sender, EventArgs e)
        {
            hellep.Enabled = false;
            addd.Enabled = false;
            bell.Enabled = false;
            button1.Enabled = true;
            display(pictureBox1, 1);
            display(pictureBox2, 2);
            display(pictureBox3, 3);
            display(pictureBox4, 4);
            display(pictureBox5, 5);
            display(pictureBox6, 6);
        }
        public void display(PictureBox www, int x)
        {
            //Random asd =new Random ();
            //int num=asd.Next (1,7);
            www.Image = Image.FromFile(Directory.GetCurrentDirectory() +
                "\\pic\\p" + x + ".jpg");

        }

        private void button3_Click(object sender, EventArgs e)
        {

                Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddNewProduct asd = new AddNewProduct();
            asd.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddNewSupp asd = new AddNewSupp();
            asd.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddMantainCustomer asd = new AddMantainCustomer();
            asd.ShowDialog();
        }

        private void «÷«ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 asd = new Form1();
            asd.ShowDialog();
        }

        private void ‘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainBill asd = new maintainBill();
            asd.ShowDialog();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Â·  —Ìœ«€·«ﬁ «·»—‰«„Ãøø", "«€·«ﬁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
    }
}
