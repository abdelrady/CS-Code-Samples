// created on 05/14/2002 at 3:39 PM
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vega
{
    public class button : Button
    {
        public button()
        {
            Text = "click me";
            Click += new System.EventHandler(this.ClickMe);
        }

        private void ClickMe(object sender, System.EventArgs e)
        {
            MessageBox.Show("You clicked me!");
        }
    }
}
