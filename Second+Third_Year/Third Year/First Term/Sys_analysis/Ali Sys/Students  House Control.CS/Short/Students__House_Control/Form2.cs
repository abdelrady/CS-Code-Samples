using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class Form2 : Form
    {

        private Button button1;
        private Button button2;
        internal Button CloseBtn;
        private ListBox listBox1;
        public MyUtility o;

        public Form2()
        {
            o = new MyUtility();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            o.fillList(listBox1, "SELECT ST_Name FROM Students WHERE PayedOrNot=false and Dismissed = false");
            o.RefreshMe();
            bool flag = listBox1.Items.Count == 0;
            if (!flag)
                listBox1.SelectedIndex = 0;
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.Date;
            int i = dateTime.Month;
            Text += i.ToString();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            CloseBtn = new Button();
            SuspendLayout();
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Tahoma", 9.0F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 254);
            listBox1.TabIndex = 0;
            button1.BackgroundImage = (Image)componentResourceManager.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(209, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 27);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(button1_Click);
            button2.BackgroundImage = (Image)componentResourceManager.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(209, 38);
            button2.Name = "button2";
            button2.Size = new Size(56, 27);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(button2_Click);
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            CloseBtn.Image = (Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(209, 232);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = RightToLeft.No;
            CloseBtn.Size = new Size(56, 34);
            CloseBtn.TabIndex = 23;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new EventHandler(CloseBtn_Click);
            AcceptButton = button2;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(272, 278);
            Controls.Add(CloseBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0627\u0644\u0645\u0633\u062F\u062F\u064A\u0646 \u062E\u0644\u0627\u0644 \u0634\u0647\u0631 ";
            Load += new EventHandler(Form2_Load);
            ResumeLayout(false);
        }

    } // class Form2

}

