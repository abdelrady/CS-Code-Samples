using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class choose : UserControl
    {
        public choose()
        {
            InitializeComponent();
        }

       private void choose_Load(object sender, EventArgs e)
        {
            ClassLibrary2.Class1 class2 = new ClassLibrary2.Class1();
            class2.SetProcessWorkingSetSize();
        }

        private void student_f_Click_1(object sender, EventArgs e)
        {/*
            Form1 f = new Form1(Asd);
            f.Show();*/
            //this.Visible = false;
        }

        private void coarse_f_Click_1(object sender, EventArgs e)
        {
            /*coarse_form f2 = new coarse_form();
            f2.Show();
            //this.Visible = false;*/
        }
    }
}
