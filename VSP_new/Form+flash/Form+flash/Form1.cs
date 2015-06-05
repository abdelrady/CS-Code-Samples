using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Form_flash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool test()
        {
            bool createNew;
            string str = "{EA7A33A4-613E-47e6-95AE-2DF66F5AAE47}";
            System.Threading.Mutex mut = new System.Threading.Mutex(false, str,out createNew);
            return createNew;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!test())
            {
                MessageBox.Show("There Is Another Instance Already Running.");
                this.Close();
            }
            
        }
    }
}