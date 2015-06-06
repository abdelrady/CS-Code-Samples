using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class Form2 : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ListBox listBox1;
        public Students__House_Control.MyUtility o;

        public Form2()
        {
            o = new Students__House_Control.MyUtility();
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            bool flag = (listBox1.SelectedIndex > 0) && (listBox1.Items.Count != 0);
            if (!flag)
            {
            }
            else
            {
                int i = listBox1.SelectedIndex - 1;
                listBox1.SelectedIndex--;
                listBox1.SelectedIndex = i;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            o.fillList(listBox1, "SELECT ST_Name FROM Students WHERE PayedOrNot=false and Dismissed = false");
            o.RefreshMe();
            bool flag = listBox1.Items.Count == 0;
            if (!flag)
                listBox1.SelectedIndex = 0;
            System.DateTime dateTime = System.DateTime.Now;
            dateTime = dateTime.Date;
            int i = dateTime.Month;
            Text += i.ToString();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.Form2));
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            CloseBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listBox1.Font = new System.Drawing.Font("Tahoma", 9.0F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new System.Drawing.Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(191, 254);
            listBox1.TabIndex = 0;
            button1.BackgroundImage = (System.Drawing.Image)componentResourceManager.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.Location = new System.Drawing.Point(209, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(56, 27);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            button2.BackgroundImage = (System.Drawing.Image)componentResourceManager.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.Location = new System.Drawing.Point(209, 38);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(56, 27);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            CloseBtn.BackColor = System.Drawing.Color.Transparent;
            CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            CloseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            CloseBtn.Image = (System.Drawing.Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new System.Drawing.Point(209, 232);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CloseBtn.Size = new System.Drawing.Size(56, 34);
            CloseBtn.TabIndex = 23;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new System.EventHandler(CloseBtn_Click);
            AcceptButton = button2;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(272, 278);
            Controls.Add(CloseBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0627\u0644\u0645\u0633\u062F\u062F\u064A\u0646 \u062E\u0644\u0627\u0644 \u0634\u0647\u0631 ";
            Load += new System.EventHandler(Form2_Load);
            ResumeLayout(false);
        }

    } // class Form2

}

