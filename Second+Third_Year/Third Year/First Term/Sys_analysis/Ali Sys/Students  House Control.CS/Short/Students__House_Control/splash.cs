using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class splash : Form
    {

        private IContainer components;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private float real;
        private Timer timer1;

        public splash(bool Show)
        {
            real = 0.0F;
            InitializeComponent();
            bool flag = !Show;
            if (!flag)
            {
                progressBar1.Visible = false;
                label1.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(splash));
            timer1 = new Timer(components);
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            timer1.Interval = 150;
            timer1.Tick += new EventHandler(timer1_Tick);
            progressBar1.BackColor = SystemColors.ControlLightLight;
            progressBar1.Location = new Point(12, 216);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(209, 10);
            progressBar1.Step = 20;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(4, 182);
            label1.Name = "label1";
            label1.Size = new Size(228, 16);
            label1.TabIndex = 1;
            label1.Text = "Connecting To The Database  Please Wait . . .";
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(28, 161);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 3;
            label3.Text = "UNREGESTRED COPY TO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(172, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 4;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Book Antiqua", 24.0F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Transparent;
            label2.Image = (Image)componentResourceManager.GetObject("label2.Image");
            label2.Location = new Point(0, 201);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(528, 37);
            label2.TabIndex = 26;
            label2.TextAlign = ContentAlignment.MiddleRight;
            AutoScaleBaseSize = new Size(5, 14);
            BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
            ClientSize = new Size(528, 238);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash";
            FormClosing += new FormClosingEventHandler(splash_FormClosing);
            Load += new EventHandler(splash_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private void splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            // trial
        }

        private void splash_Load(object sender, EventArgs e)
        {
            // trial
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool flag = real >= 1.0F;
            if (!flag)
            {
                real += 0.1F;
                progressBar1.Value += 10;
                flag = progressBar1.Value != 30;
                if (!flag)
                    label1.Text = "Extracting Data ... ";
                flag = progressBar1.Value != 60;
                if (!flag)
                    label1.Text = "Inittilizing Components ... ";
                flag = progressBar1.Value != 90;
                if (!flag)
                    label1.Text = "Finishing ...";
            }
            else
            {
                timer1.Stop();
                base.Dispose();
            }
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class splash

}

