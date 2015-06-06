using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Button a = new Button();
                a.Size = new Size(25, 25);
                a.Left = i * 25 + 2;
                a.Top = 145;
                if (a.Left > 200) { a.Left = (i * 25)%200 + 2;  a.Top += 15; }
                a.Text =Convert.ToString( (char)(i + 65));
                this.Controls.Add(a);
                a.Show();
            }

        }
    }
}