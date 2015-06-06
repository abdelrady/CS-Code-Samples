using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Students__House_Control
{

    internal class About : System.Windows.Forms.Form
    {

        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel me;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private int YCordinate;

        public string AssemblyCompany
        {
            get
            {
                string s;

                object[] objArr = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCompanyAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((System.Reflection.AssemblyCompanyAttribute)objArr[0]).Company;
                return s;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                string s;

                object[] objArr = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCopyrightAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((System.Reflection.AssemblyCopyrightAttribute)objArr[0]).Copyright;
                return s;
            }
        }

        public string AssemblyDescription
        {
            get
            {
                string s;

                object[] objArr = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyDescriptionAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((System.Reflection.AssemblyDescriptionAttribute)objArr[0]).Description;
                return s;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                string s;

                object[] objArr = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyProductAttribute), false);
                bool flag = objArr.Length != 0;
                if (!flag)
                    s = "";
                else
                    s = ((System.Reflection.AssemblyProductAttribute)objArr[0]).Product;
                return s;
            }
        }

        public string AssemblyTitle
        {
            get
            {
                string s;

                object[] objArr = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false);
                bool flag = objArr.Length <= 0;
                if (!flag)
                {
                    System.Reflection.AssemblyTitleAttribute assemblyTitleAttribute = (System.Reflection.AssemblyTitleAttribute)objArr[0];
                    flag = assemblyTitleAttribute.Title == "";
                    if (!flag)
                    {
                        return assemblyTitleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public About()
        {
            components = null;
            YCordinate = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            me = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            me.SuspendLayout();
            SuspendLayout();
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(46, 62);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(69, 23);
            button1.TabIndex = 25;
            button1.Text = "&OK";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(button1_Click);
            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(5, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 25);
            label1.TabIndex = 30;
            label1.Text = "Assuit University Dormitory           ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            me.BackColor = System.Drawing.SystemColors.Menu;
            me.Controls.Add(label5);
            me.Controls.Add(label2);
            me.Controls.Add(linkLabel1);
            me.Controls.Add(label6);
            me.Controls.Add(label4);
            me.Controls.Add(label3);
            me.Location = new System.Drawing.Point(203, 96);
            me.Name = "me";
            me.Size = new System.Drawing.Size(242, 136);
            me.TabIndex = 7;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(47, 82);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 13);
            label5.TabIndex = 12;
            label5.Text = "All Rights Reserved To me";
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 11;
            label2.Text = "e-mail";
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(66, 107);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(138, 13);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "alihussin3400@hotmail.com";
            linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(93, 60);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 13);
            label6.TabIndex = 9;
            label6.Text = "3rd Year";
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(198, 13);
            label4.TabIndex = 8;
            label4.Text = "Faculity Of Computers And Information ";
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(24, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(208, 23);
            label3.TabIndex = 6;
            label3.Text = "Eng.Ali Hussin Ahmed ";
            timer1.Interval = 20;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            panel1.BackColor = System.Drawing.SystemColors.Menu;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Location = new System.Drawing.Point(198, -4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(252, 105);
            panel1.TabIndex = 31;
            label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(117, 34);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 25);
            label7.TabIndex = 32;
            label7.Text = "ver 1.0.0.1";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button2.Location = new System.Drawing.Point(114, 62);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(40, 23);
            button2.TabIndex = 33;
            button2.TabStop = false;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(198, 92);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(me);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Padding = new System.Windows.Forms.Padding(9);
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About . . .";
            me.ResumeLayout(false);
            me.PerformLayout();
            ResumeLayout(false);
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE", "http:\\www.ali.com");
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            System.Drawing.Point point = me.Location;
            YCordinate = point.Y;
            bool flag = YCordinate != (-1 * me.Height);
            if (!flag)
                YCordinate = Height;
            point = me.Location;
            int i = YCordinate - 1;
            YCordinate--;
            me.Location = new System.Drawing.Point(point.X, i);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class About

}

