using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Students__House_Control
{

    internal class About : Form
    {

        internal Button button1;
        private Button button2;
        private IContainer components;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
        private Panel me;
        private Panel panel1;
        private Timer timer1;
        private int YCordinate;

        public string AssemblyCompany
        {
            get
            {
                string s;

                object[] objArr = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((AssemblyCompanyAttribute)objArr[0]).Company;
                return s;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                string s;

                object[] objArr = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((AssemblyCopyrightAttribute)objArr[0]).Copyright;
                return s;
            }
        }

        public string AssemblyDescription
        {
            get
            {
                string s;

                object[] objArr = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((AssemblyDescriptionAttribute)objArr[0]).Description;
                return s;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                string s;

                object[] objArr = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((AssemblyProductAttribute)objArr[0]).Product;
                return s;
            }
        }

        public string AssemblyTitle
        {
            get
            {
                string s;

                object[] objArr = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                bool flag = objArr.Length <= 0;
                if (!flag)
                {
                    AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)objArr[0];
                    flag = assemblyTitleAttribute.Title == "";
                    if (!flag)
                    {
                        return assemblyTitleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public About()
        {
            components = null;
            YCordinate = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            components = new Container();
            button1 = new Button();
            label1 = new Label();
            me = new Panel();
            label5 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new Timer(components);
            panel1 = new Panel();
            label7 = new Label();
            button2 = new Button();
            me.SuspendLayout();
            SuspendLayout();
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(46, 62);
            button1.Name = "button1";
            button1.Size = new Size(69, 23);
            button1.TabIndex = 25;
            button1.Text = "&OK";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 30;
            label1.Text = "Assuit University Dormitory           ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            me.BackColor = SystemColors.Menu;
            me.Controls.Add(label5);
            me.Controls.Add(label2);
            me.Controls.Add(linkLabel1);
            me.Controls.Add(label6);
            me.Controls.Add(label4);
            me.Controls.Add(label3);
            me.Location = new Point(203, 96);
            me.Name = "me";
            me.Size = new Size(242, 136);
            me.TabIndex = 7;
            label5.AutoSize = true;
            label5.Location = new Point(47, 82);
            label5.Name = "label5";
            label5.Size = new Size(132, 13);
            label5.TabIndex = 12;
            label5.Text = "All Rights Reserved To me";
            label2.AutoSize = true;
            label2.Location = new Point(33, 107);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 11;
            label2.Text = "e-mail";
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(66, 107);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 13);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "alihussin3400@hotmail.com";
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            label6.AutoSize = true;
            label6.Location = new Point(93, 60);
            label6.Name = "label6";
            label6.Size = new Size(48, 13);
            label6.TabIndex = 9;
            label6.Text = "3rd Year";
            label4.AutoSize = true;
            label4.Location = new Point(28, 39);
            label4.Name = "label4";
            label4.Size = new Size(198, 13);
            label4.TabIndex = 8;
            label4.Text = "Faculity Of Computers And Information ";
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 11);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 6;
            label3.Text = "Eng.Ali Hussin Ahmed ";
            timer1.Interval = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(198, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 105);
            panel1.TabIndex = 31;
            label7.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(117, 34);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 32;
            label7.Text = "ver 1.0.0.1";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            button2.Location = new Point(114, 62);
            button2.Name = "button2";
            button2.Size = new Size(40, 23);
            button2.TabIndex = 33;
            button2.TabStop = false;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(button2_Click);
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(198, 92);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(me);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Padding = new Padding(9);
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About . . .";
            me.ResumeLayout(false);
            me.PerformLayout();
            ResumeLayout(false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IEXPLORE", "http:\\www.ali.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point = me.Location;
            YCordinate = point.Y;
            bool flag = YCordinate != (-1 * me.Height);
            if (!flag)
                YCordinate = Height;
            point = me.Location;
            int i = YCordinate - 1;
            YCordinate--;
            me.Location = new Point(point.X, i);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class About

}

