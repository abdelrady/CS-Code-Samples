using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for FormSetColors.
	/// </summary>
	public class FormSetColors : System.Windows.Forms.Form
	{
		#region data field declarations

		private MainForm parentForm;
		private CustomCollapsableGroupBox2.CollapsableGroupBox collapsableGroupBox2;
		private System.Windows.Forms.Label labelClicked;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lblSnake1Color;
		private System.Windows.Forms.Label lblSnake2Color;
		private System.Windows.Forms.Label lblSnake3Color;
		private System.Windows.Forms.Label lblSnake4Color;
		private System.Windows.Forms.Label lblHeadColor;
		private System.Windows.Forms.Label lblMazeColor;
		private System.Windows.Forms.Label lblPlayingAreaColor;
		private System.Windows.Forms.Label lblMessageColor;
		private System.Windows.Forms.Label lblStatusBarColor;
		private System.Windows.Forms.Label lblStatusBarTextColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnRestoreDefaults;
		private System.Windows.Forms.Label label1;

		#endregion
		private System.Windows.Forms.Button btnApply;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormSetColors(MainForm mainForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.parentForm = mainForm;
		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.collapsableGroupBox2 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.btnRestoreDefaults = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.lblStatusBarTextColor = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.lblStatusBarColor = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lblMessageColor = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblPlayingAreaColor = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblMazeColor = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblHeadColor = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblSnake4Color = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblSnake3Color = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSnake2Color = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSnake1Color = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.collapsableGroupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// collapsableGroupBox2
			// 
			this.collapsableGroupBox2.AutoHide = true;
			this.collapsableGroupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.collapsableGroupBox2.BorderColor = System.Drawing.Color.White;
			this.collapsableGroupBox2.BorderThickness = 1;
			this.collapsableGroupBox2.BorderVisible = true;
			this.collapsableGroupBox2.CaptionBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.collapsableGroupBox2.CaptionEnableBCGradient = false;
			this.collapsableGroupBox2.CaptionGradColor1 = System.Drawing.Color.White;
			this.collapsableGroupBox2.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.collapsableGroupBox2.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.collapsableGroupBox2.CaptionHeight = 26;
			this.collapsableGroupBox2.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.collapsableGroupBox2.CaptionTextColor = System.Drawing.Color.LightYellow;
			this.collapsableGroupBox2.Collapsed = false;
			this.collapsableGroupBox2.Controls.Add(this.btnRestoreDefaults);
			this.collapsableGroupBox2.Controls.Add(this.btnCancel);
			this.collapsableGroupBox2.Controls.Add(this.btnApply);
			this.collapsableGroupBox2.Controls.Add(this.lblStatusBarTextColor);
			this.collapsableGroupBox2.Controls.Add(this.label19);
			this.collapsableGroupBox2.Controls.Add(this.lblStatusBarColor);
			this.collapsableGroupBox2.Controls.Add(this.label17);
			this.collapsableGroupBox2.Controls.Add(this.lblMessageColor);
			this.collapsableGroupBox2.Controls.Add(this.label15);
			this.collapsableGroupBox2.Controls.Add(this.lblPlayingAreaColor);
			this.collapsableGroupBox2.Controls.Add(this.label13);
			this.collapsableGroupBox2.Controls.Add(this.lblMazeColor);
			this.collapsableGroupBox2.Controls.Add(this.label11);
			this.collapsableGroupBox2.Controls.Add(this.lblHeadColor);
			this.collapsableGroupBox2.Controls.Add(this.label9);
			this.collapsableGroupBox2.Controls.Add(this.lblSnake4Color);
			this.collapsableGroupBox2.Controls.Add(this.label7);
			this.collapsableGroupBox2.Controls.Add(this.lblSnake3Color);
			this.collapsableGroupBox2.Controls.Add(this.label5);
			this.collapsableGroupBox2.Controls.Add(this.lblSnake2Color);
			this.collapsableGroupBox2.Controls.Add(this.label3);
			this.collapsableGroupBox2.Controls.Add(this.lblSnake1Color);
			this.collapsableGroupBox2.Controls.Add(this.label1);
			this.collapsableGroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
			this.collapsableGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableGroupBox2.HighlightCaptionTextColor = System.Drawing.Color.LemonChiffon;
			this.collapsableGroupBox2.Location = new System.Drawing.Point(0, 0);
			this.collapsableGroupBox2.Name = "collapsableGroupBox2";
			this.collapsableGroupBox2.Size = new System.Drawing.Size(432, 408);
			this.collapsableGroupBox2.SmoothCollapse = false;
			this.collapsableGroupBox2.SmoothCollapseSpeed = 5;
			this.collapsableGroupBox2.TabIndex = 7;
			this.collapsableGroupBox2.Tag = "ColorLabel";
			this.collapsableGroupBox2.Text = "G a m e    C o l o r s";
			this.collapsableGroupBox2.TimeToAutoHide = 0;
			this.collapsableGroupBox2.CollapsedStateChanged += new System.EventHandler(this.collapsableGroupBox1_CollapsedStateChanged);
			// 
			// btnRestoreDefaults
			// 
			this.btnRestoreDefaults.BackColor = System.Drawing.SystemColors.Info;
			this.btnRestoreDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestoreDefaults.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnRestoreDefaults.Location = new System.Drawing.Point(160, 352);
			this.btnRestoreDefaults.Name = "btnRestoreDefaults";
			this.btnRestoreDefaults.Size = new System.Drawing.Size(112, 30);
			this.btnRestoreDefaults.TabIndex = 42;
			this.btnRestoreDefaults.Text = "&Restore Defaults";
			this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnCancel.Location = new System.Drawing.Point(288, 352);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 30);
			this.btnCancel.TabIndex = 41;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnApply
			// 
			this.btnApply.BackColor = System.Drawing.SystemColors.Info;
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApply.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnApply.Location = new System.Drawing.Point(32, 352);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(112, 30);
			this.btnApply.TabIndex = 40;
			this.btnApply.Text = "&Apply Changes";
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// lblStatusBarTextColor
			// 
			this.lblStatusBarTextColor.BackColor = System.Drawing.Color.AliceBlue;
			this.lblStatusBarTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblStatusBarTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblStatusBarTextColor.ForeColor = System.Drawing.Color.LightYellow;
			this.lblStatusBarTextColor.Location = new System.Drawing.Point(352, 272);
			this.lblStatusBarTextColor.Name = "lblStatusBarTextColor";
			this.lblStatusBarTextColor.Size = new System.Drawing.Size(32, 16);
			this.lblStatusBarTextColor.TabIndex = 39;
			this.lblStatusBarTextColor.Tag = "ColorLabel";
			this.lblStatusBarTextColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Cursor = System.Windows.Forms.Cursors.Default;
			this.label19.ForeColor = System.Drawing.Color.LightYellow;
			this.label19.Location = new System.Drawing.Point(232, 272);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(114, 16);
			this.label19.TabIndex = 38;
			this.label19.Tag = "";
			this.label19.Text = "Statusbar Text Color :";
			// 
			// lblStatusBarColor
			// 
			this.lblStatusBarColor.BackColor = System.Drawing.Color.LightSlateGray;
			this.lblStatusBarColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblStatusBarColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblStatusBarColor.ForeColor = System.Drawing.Color.LightYellow;
			this.lblStatusBarColor.Location = new System.Drawing.Point(136, 272);
			this.lblStatusBarColor.Name = "lblStatusBarColor";
			this.lblStatusBarColor.Size = new System.Drawing.Size(32, 16);
			this.lblStatusBarColor.TabIndex = 37;
			this.lblStatusBarColor.Tag = "ColorLabel";
			this.lblStatusBarColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Cursor = System.Windows.Forms.Cursors.Default;
			this.label17.ForeColor = System.Drawing.Color.LightYellow;
			this.label17.Location = new System.Drawing.Point(40, 272);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(89, 16);
			this.label17.TabIndex = 36;
			this.label17.Tag = "";
			this.label17.Text = "Statusbar Color :";
			// 
			// lblMessageColor
			// 
			this.lblMessageColor.BackColor = System.Drawing.Color.RosyBrown;
			this.lblMessageColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMessageColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMessageColor.ForeColor = System.Drawing.Color.LightYellow;
			this.lblMessageColor.Location = new System.Drawing.Point(352, 224);
			this.lblMessageColor.Name = "lblMessageColor";
			this.lblMessageColor.Size = new System.Drawing.Size(32, 16);
			this.lblMessageColor.TabIndex = 35;
			this.lblMessageColor.Tag = "ColorLabel";
			this.lblMessageColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Cursor = System.Windows.Forms.Cursors.Default;
			this.label15.ForeColor = System.Drawing.Color.LightYellow;
			this.label15.Location = new System.Drawing.Point(260, 224);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(86, 16);
			this.label15.TabIndex = 34;
			this.label15.Tag = "";
			this.label15.Text = "Message Color :";
			// 
			// lblPlayingAreaColor
			// 
			this.lblPlayingAreaColor.BackColor = System.Drawing.Color.Tan;
			this.lblPlayingAreaColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPlayingAreaColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayingAreaColor.ForeColor = System.Drawing.Color.LightYellow;
			this.lblPlayingAreaColor.Location = new System.Drawing.Point(136, 224);
			this.lblPlayingAreaColor.Name = "lblPlayingAreaColor";
			this.lblPlayingAreaColor.Size = new System.Drawing.Size(32, 16);
			this.lblPlayingAreaColor.TabIndex = 33;
			this.lblPlayingAreaColor.Tag = "ColorLabel";
			this.lblPlayingAreaColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.label13.ForeColor = System.Drawing.Color.LightYellow;
			this.label13.Location = new System.Drawing.Point(24, 224);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 16);
			this.label13.TabIndex = 32;
			this.label13.Tag = "";
			this.label13.Text = "Playing Area Color :";
			// 
			// lblMazeColor
			// 
			this.lblMazeColor.BackColor = System.Drawing.SystemColors.GrayText;
			this.lblMazeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMazeColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMazeColor.ForeColor = System.Drawing.Color.LightYellow;
			this.lblMazeColor.Location = new System.Drawing.Point(352, 176);
			this.lblMazeColor.Name = "lblMazeColor";
			this.lblMazeColor.Size = new System.Drawing.Size(32, 16);
			this.lblMazeColor.TabIndex = 31;
			this.lblMazeColor.Tag = "ColorLabel";
			this.lblMazeColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.label11.ForeColor = System.Drawing.Color.LightYellow;
			this.label11.Location = new System.Drawing.Point(278, 176);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 16);
			this.label11.TabIndex = 30;
			this.label11.Tag = "";
			this.label11.Text = "Maze Color :";
			// 
			// lblHeadColor
			// 
			this.lblHeadColor.BackColor = System.Drawing.SystemColors.Info;
			this.lblHeadColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHeadColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblHeadColor.ForeColor = System.Drawing.SystemColors.Info;
			this.lblHeadColor.Location = new System.Drawing.Point(136, 176);
			this.lblHeadColor.Name = "lblHeadColor";
			this.lblHeadColor.Size = new System.Drawing.Size(32, 16);
			this.lblHeadColor.TabIndex = 29;
			this.lblHeadColor.Tag = "ColorLabel";
			this.lblHeadColor.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.label9.ForeColor = System.Drawing.Color.LightYellow;
			this.label9.Location = new System.Drawing.Point(61, 176);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 16);
			this.label9.TabIndex = 28;
			this.label9.Tag = "";
			this.label9.Text = "Head Color :";
			// 
			// lblSnake4Color
			// 
			this.lblSnake4Color.BackColor = System.Drawing.Color.LightCyan;
			this.lblSnake4Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSnake4Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSnake4Color.ForeColor = System.Drawing.Color.LightYellow;
			this.lblSnake4Color.Location = new System.Drawing.Point(352, 128);
			this.lblSnake4Color.Name = "lblSnake4Color";
			this.lblSnake4Color.Size = new System.Drawing.Size(32, 16);
			this.lblSnake4Color.TabIndex = 27;
			this.lblSnake4Color.Tag = "ColorLabel";
			this.lblSnake4Color.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.label7.ForeColor = System.Drawing.Color.LightYellow;
			this.label7.Location = new System.Drawing.Point(264, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 16);
			this.label7.TabIndex = 26;
			this.label7.Tag = "";
			this.label7.Text = "Snake 4 Color :";
			// 
			// lblSnake3Color
			// 
			this.lblSnake3Color.BackColor = System.Drawing.Color.Bisque;
			this.lblSnake3Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSnake3Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSnake3Color.ForeColor = System.Drawing.Color.LightYellow;
			this.lblSnake3Color.Location = new System.Drawing.Point(136, 128);
			this.lblSnake3Color.Name = "lblSnake3Color";
			this.lblSnake3Color.Size = new System.Drawing.Size(32, 16);
			this.lblSnake3Color.TabIndex = 25;
			this.lblSnake3Color.Tag = "ColorLabel";
			this.lblSnake3Color.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.label5.ForeColor = System.Drawing.Color.LightYellow;
			this.label5.Location = new System.Drawing.Point(47, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 16);
			this.label5.TabIndex = 24;
			this.label5.Tag = "";
			this.label5.Text = "Snake 3 Color :";
			// 
			// lblSnake2Color
			// 
			this.lblSnake2Color.BackColor = System.Drawing.Color.AliceBlue;
			this.lblSnake2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSnake2Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSnake2Color.ForeColor = System.Drawing.Color.LightYellow;
			this.lblSnake2Color.Location = new System.Drawing.Point(352, 80);
			this.lblSnake2Color.Name = "lblSnake2Color";
			this.lblSnake2Color.Size = new System.Drawing.Size(32, 16);
			this.lblSnake2Color.TabIndex = 23;
			this.lblSnake2Color.Tag = "ColorLabel";
			this.lblSnake2Color.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.ForeColor = System.Drawing.Color.LightYellow;
			this.label3.Location = new System.Drawing.Point(264, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 22;
			this.label3.Tag = "";
			this.label3.Text = "Snake 2 Color :";
			// 
			// lblSnake1Color
			// 
			this.lblSnake1Color.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblSnake1Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSnake1Color.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSnake1Color.ForeColor = System.Drawing.Color.LightYellow;
			this.lblSnake1Color.Location = new System.Drawing.Point(136, 80);
			this.lblSnake1Color.Name = "lblSnake1Color";
			this.lblSnake1Color.Size = new System.Drawing.Size(32, 16);
			this.lblSnake1Color.TabIndex = 21;
			this.lblSnake1Color.Tag = "ColorLabel";
			this.lblSnake1Color.Click += new System.EventHandler(this.lblColors_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.ForeColor = System.Drawing.Color.LightYellow;
			this.label1.Location = new System.Drawing.Point(47, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 20;
			this.label1.Tag = "";
			this.label1.Text = "Snake 1 Color :";
			// 
			// colorDialog1
			// 
			this.colorDialog1.AnyColor = true;
			this.colorDialog1.FullOpen = true;
			this.colorDialog1.ShowHelp = true;
			// 
			// FormSetColors
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 408);
			this.Controls.Add(this.collapsableGroupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSetColors";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormSetColors";
			this.Load += new System.EventHandler(this.FormSetColors_Load);
			this.collapsableGroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormSetColors_Load(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox2.Height;
			this.SetColors(this.parentForm.GetGameColors());						
		}

		private void collapsableGroupBox1_CollapsedStateChanged(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox2.Height;
		}

		private void lblColors_Click(object sender, System.EventArgs e)
		{
			this.labelClicked = (System.Windows.Forms.Label)sender;
			this.colorDialog1.Color = this.labelClicked.BackColor;
			this.colorDialog1.ShowDialog();
			this.labelClicked.BackColor = this.colorDialog1.Color;
		}

		private void btnRestoreDefaults_Click(object sender, System.EventArgs e)
		{
			this.SetColors(this.parentForm.GetDefaultGameColors());						
		}

		private void SetColors(GameColors gameColors)
		{
			this.lblSnake1Color.BackColor = gameColors.snake1Color;
			this.lblSnake2Color.BackColor = gameColors.snake2Color;
			this.lblSnake3Color.BackColor = gameColors.snake3Color;
			this.lblSnake4Color.BackColor = gameColors.snake4Color;
			this.lblHeadColor.BackColor = gameColors.headColor;
			this.lblMazeColor.BackColor = gameColors.mazeColor;
			this.lblPlayingAreaColor.BackColor = gameColors.playingAreaColor;
			this.lblMessageColor.BackColor = gameColors.messageColor;
			this.lblStatusBarColor.BackColor = gameColors.statusBarColor;
			this.lblStatusBarTextColor.BackColor = gameColors.statusBarTextColor;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			if(CheckColorClashes() == false)
			{
				this.ApplySettings();
				this.Close();
			}
		}

		//following method returns true if some color is assigned to more than one objects
		private bool CheckColorClashes()
		{
			if(this.CheckPlayersColorClashes() == true)
				return true;
			
			if(this.CheckOtherClashes() == true)
				return true;			

			return false;
		}

		//following fn. checks if same color is assigned to more than one snakes
		private bool CheckPlayersColorClashes()
		{
			bool colorClashed = false;

			if(this.lblSnake1Color.BackColor.ToArgb() == this.lblSnake2Color.BackColor.ToArgb())
				colorClashed = true;
			else if(this.lblSnake1Color.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb())
				colorClashed = true;
			else if(this.lblSnake1Color.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
				colorClashed = true;
			else if(this.lblSnake2Color.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb())
				colorClashed = true;
			else if(this.lblSnake2Color.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
				colorClashed = true;
			else if(this.lblSnake3Color.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
				colorClashed = true;

			if(colorClashed == true)
			{
				MessageBox.Show("Same color can't be assigned to more than one players !", "Error");
				return true;
			}

			return false;
		}

		//following fn. checks all other possible color clashes
		private bool CheckOtherClashes()
		{
			if(this.lblHeadColor.BackColor.ToArgb() == this.lblSnake1Color.BackColor.ToArgb()
			|| this.lblHeadColor.BackColor.ToArgb() == this.lblSnake2Color.BackColor.ToArgb()
			|| this.lblHeadColor.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb()
			|| this.lblHeadColor.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
			{
				MessageBox.Show("Head Color and Snake Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblSnake1Color.BackColor.ToArgb()
				|| this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblSnake2Color.BackColor.ToArgb()
				|| this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb()
				|| this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
			{
				MessageBox.Show("Playing Area Color and Snake Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblMazeColor.BackColor.ToArgb() == this.lblSnake1Color.BackColor.ToArgb()
				|| this.lblMazeColor.BackColor.ToArgb() == this.lblSnake2Color.BackColor.ToArgb()
				|| this.lblMazeColor.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb()
				|| this.lblMazeColor.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
			{
				MessageBox.Show("Maze Color and Snake Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblMessageColor.BackColor.ToArgb() == this.lblSnake1Color.BackColor.ToArgb()
				|| this.lblMessageColor.BackColor.ToArgb() == this.lblSnake2Color.BackColor.ToArgb()
				|| this.lblMessageColor.BackColor.ToArgb() == this.lblSnake3Color.BackColor.ToArgb()
				|| this.lblMessageColor.BackColor.ToArgb() == this.lblSnake4Color.BackColor.ToArgb())
			{
				MessageBox.Show("Message Color and Snake Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblHeadColor.BackColor.ToArgb() == this.lblPlayingAreaColor.BackColor.ToArgb())
			{
				MessageBox.Show("Head Color and Playing Area Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblHeadColor.BackColor.ToArgb() == this.lblMazeColor.BackColor.ToArgb())
			{
				MessageBox.Show("Head Color and Maze Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblHeadColor.BackColor.ToArgb() == this.lblMessageColor.BackColor.ToArgb())
			{
				MessageBox.Show("Head Color and Message Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblMazeColor.BackColor.ToArgb())
			{
				MessageBox.Show("Maze Color and Playing Area Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblMessageColor.BackColor.ToArgb())
			{
				MessageBox.Show("Message Color and Playing Area Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblMazeColor.BackColor.ToArgb() == this.lblMessageColor.BackColor.ToArgb())
			{
				MessageBox.Show("Maze Color and Message Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblPlayingAreaColor.BackColor.ToArgb() == this.lblStatusBarColor.BackColor.ToArgb())
			{
				MessageBox.Show("Playing Area Color and Statusbar Color can't have the same value !", "Error");
				return true;
			}
			else if(this.lblStatusBarColor.BackColor.ToArgb() == this.lblStatusBarTextColor.BackColor.ToArgb())
			{
				MessageBox.Show("Statusbar Color and Statusbar Text Color can't have the same value !", "Error");
				return true;
			}

			return false;
		}

		private void ApplySettings()
		{
			GameColors gameColors;
			gameColors.snake1Color = this.lblSnake1Color.BackColor; 
			gameColors.snake2Color = this.lblSnake2Color.BackColor;
			gameColors.snake3Color = this.lblSnake3Color.BackColor; 
			gameColors.snake4Color = this.lblSnake4Color.BackColor;
			gameColors.headColor = this.lblHeadColor.BackColor;
			gameColors.mazeColor = this.lblMazeColor.BackColor;
			gameColors.playingAreaColor = this.lblPlayingAreaColor.BackColor;
			gameColors.messageColor = this.lblMessageColor.BackColor;
			gameColors.statusBarColor = this.lblStatusBarColor.BackColor;
			gameColors.statusBarTextColor = this.lblStatusBarTextColor.BackColor;

			this.parentForm.SetGameColors(gameColors);			
		}
	}
}
