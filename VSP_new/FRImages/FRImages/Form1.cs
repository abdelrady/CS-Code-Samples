using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FRImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vLDemoDataSet.Faces' table. You can move, or remove it, as needed.
            this.facesTableAdapter.Fill(this.vLDemoDataSet.Faces);

        }
    }
}