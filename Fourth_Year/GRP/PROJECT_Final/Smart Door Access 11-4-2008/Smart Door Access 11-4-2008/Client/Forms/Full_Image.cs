using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatClient.Forms
{
    public partial class Full_Image : Form
    {
        public Full_Image(Image I)
        {
            InitializeComponent();
            this.BackgroundImage = I;
        }

        private void Full_Image_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void Full_Image_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}