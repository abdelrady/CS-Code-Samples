using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieShow
{
    public partial class Form4 : Form
    {
        public int i;
        public bool indexchange = false;
        public Form4(string [] s)
        {

            string[] s1;
            InitializeComponent();
            for (int j = 0; j < s.Length-1; j++)
            {
                s1 = s[j].Split('\\');
                listBox1.Items.Add(s1[s1.Length-1]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
            indexchange = true;

        }
    }
}