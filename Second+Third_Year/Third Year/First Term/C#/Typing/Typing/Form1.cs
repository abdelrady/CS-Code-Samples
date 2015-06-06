    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Typing
{
    public partial class Form1 : Form
    {
        private Button lastbutton;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Back: changeColor(button26);
                    if (textBox1.Text.Length - 1 >= 0)
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    break;
                case Keys.Enter: changeColor(button53);
                    textBox1.Text += "\n\r";
                    break;
                case Keys.Tab: changeColor(button33);
                    textBox1.Text += "\t";
                    break;
                case Keys.Space: changeColor(button68);
                    textBox1.Text += " ";
                    break;
                case Keys.D0: changeColor(button23);
                    textBox1.Text += "0";
                    break;
                case Keys.BrowserSearch:
                    changeColor(button14);
                    textBox1.Text += "Search";
                    break;
                case Keys.D1: changeColor(button14);
                    textBox1.Text += "1";
                    break;
                case Keys.D2: changeColor(button15);
                    textBox1.Text += "2";
                    break;
                case Keys.D3: changeColor(button16);
                    textBox1.Text += "3";
                    break;
                case Keys.D4: changeColor(button17);
                    textBox1.Text += "4";
                    break;
                case Keys.D5: changeColor(button18);
                    textBox1.Text += "5";
                    break;
                case Keys.D6: changeColor(button19);
                    textBox1.Text += "6";
                    break;
                case Keys.D7: changeColor(button20);
                    textBox1.Text += "7";
                    break;
                case Keys.D8: changeColor(button21);
                    textBox1.Text += "8";
                    break;
                case Keys.D9: changeColor(button22);
                    textBox1.Text += "9";
                    break;
                case Keys.F1: changeColor(button1);
                    break;
                case Keys.F2: changeColor(button2);
                    break;
                case Keys.F3: changeColor(button3);
                    break;
                case Keys.F4: changeColor(button4);
                    break;
                case Keys.F5: changeColor(button5);
                    break;
                case Keys.F6: changeColor(button6);
                    break;
                case Keys.F7: changeColor(button7);
                    break;
                case Keys.F8: changeColor(button8);
                    break;
                case Keys.F9: changeColor(button11);
                    break;
                case Keys.F10: changeColor(button9);
                    break;
                case Keys.F11: changeColor(button10);
                    break;
                case Keys.F12: changeColor(button12);
                    break;
                case Keys.OemOpenBrackets: changeColor(button38);
                    textBox1.Text += "[";
                    break;
                case Keys.OemCloseBrackets: changeColor(button39);
                    textBox1.Text += "]";
                    break;
                case Keys.Oemplus: changeColor(button24);
                    textBox1.Text += "+";
                    break;
                case Keys.OemMinus: changeColor(button25);
                    textBox1.Text += "-";
                    break;
                case Keys.Oemtilde: changeColor(button13);
                    textBox1.Text += "~";
                    break;
                case Keys.OemSemicolon: changeColor(button51);
                    textBox1.Text += ";";
                    break;
                case Keys.OemQuotes: changeColor(button52);
                    textBox1.Text += '"';
                    break;
                case Keys.OemPeriod: changeColor(button63);
                    textBox1.Text += ".";
                    break;
                case Keys.Oemcomma: changeColor(button62);
                    textBox1.Text += ",";
                    break;
                case Keys.OemPipe: changeColor(button40 );
                    textBox1 .Text +='\\';
                    break ;
                case Keys.OemQuestion: changeColor(button64);
                    textBox1.Text += "?";
                    break;
                case ((Keys)65552): changeColor(button58);
                    break;
                case ((Keys)131089): changeColor(button69);
                    break;
                case ((Keys)262162): changeColor(button67);
                    break;
                case Keys.CapsLock: changeColor(button48);
                    break;
                case Keys.Up: changeColor(button66);
                    break;
                case Keys.Down : changeColor(button70);
                    break;
                case Keys.Right : changeColor(button72);
                    break;
                case Keys.Left : changeColor(button71);
                    break;
  }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (char.ToUpper(e.KeyChar))
            {
                case ((char)Keys.A): changeColor(button41);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.B): changeColor(button59);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.C): changeColor(button56);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.D): changeColor(button43);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.E): changeColor(button30);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.F): changeColor(button44);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.G): changeColor(button45);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.H): changeColor(button46);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.I): changeColor(button35);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.J): changeColor(button47);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.K): changeColor(button49);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.L): changeColor(button50);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.M): changeColor(button61);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.N): changeColor(button60);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.O): changeColor(button36);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.P): changeColor(button37);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.Q): changeColor(button28);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.R): changeColor(button31);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.S): changeColor(button42);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.T): changeColor(button32);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.U): changeColor(button34);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.V): changeColor(button57);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.W): changeColor(button29);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.X): changeColor(button55);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.Y): changeColor(button27);
                    textBox1.Text += e.KeyChar;
                    break;
                case ((char)Keys.Z): changeColor(button54);
                    textBox1.Text += e.KeyChar;
                    break;


            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ResetColor();
        }
        public void changeColor(Button btn)
        {
            ResetColor();
            btn.BackColor = Color.LightGoldenrodYellow;
            lastbutton = btn;

        }
        public void ResetColor()
        {
        if (lastbutton !=null )
         {
            lastbutton.BackColor=SystemColors .Control;
         }

         }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult res;
            res = fd.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            textBox1.Font = fd.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult res;
            cd.FullOpen = true;
            res = cd.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            textBox1.ForeColor = cd.Color;
        }

        private void clearTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color temp;
            temp = textBox1.BackColor;
            textBox1.BackColor = textBox1.ForeColor;
            textBox1.ForeColor = temp;
        }

    }
}