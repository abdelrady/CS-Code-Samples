using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for FormControls.
	/// </summary>
	public class FormSetControls : System.Windows.Forms.Form
	{
		#region data field declarations
		private MainForm parentForm;
		private FormGetKey formGetKey;
		private string labelUpHeading;
		private string labelDownHeading;
		private string labelLeftHeading;
		private string labelRightHeading;
		private string labelSpeedUpHeading;
		private string labelSpeedDownHeading;
		private System.Windows.Forms.Label labelClicked;//refers to the label clicked to change a key
		private CustomCollapsableGroupBox2.CollapsableGroupBox collapsableGroupBox1;
		private System.Windows.Forms.Button btnClose;
		private CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer1;	
		private System.Windows.Forms.Label lblPlayer1Down;
		private System.Windows.Forms.Label lblPlayer1Up;
		private System.Windows.Forms.Label lblPlayer1Right;
		private System.Windows.Forms.Label lblPlayer1Left;
		private System.Windows.Forms.Label lblPlayer1SpeedDown;
		private System.Windows.Forms.Label lblPlayer1SpeedUp;
		private CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer2;
		private CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer3;
		private SnakeKeys[] playerKeys;
		private System.Windows.Forms.Label lblPlayer4SpeedUp;
		private System.Windows.Forms.Label lblPlayer4Right;
		private System.Windows.Forms.Label lblPlayer4Left;
		private System.Windows.Forms.Label lblPlayer4Down;
		private System.Windows.Forms.Label lblPlayer3SpeedUp;
		private System.Windows.Forms.Label lblPlayer3Right;
		private System.Windows.Forms.Label lblPlayer3Left;
		private System.Windows.Forms.Label lblPlayer3Down;
		private System.Windows.Forms.Label lblPlayer3Up;
		private System.Windows.Forms.Label lblPlayer2SpeedUp;
		private System.Windows.Forms.Label lblPlayer2Right;
		private System.Windows.Forms.Label lblPlayer2Left;
		private System.Windows.Forms.Label lblPlayer2Down;
		private System.Windows.Forms.Label lblPlayer2Up;
		private System.Windows.Forms.Label lblPlayer4SpeedDown;
		private System.Windows.Forms.Label lblPlayer3SpeedDown;
		private System.Windows.Forms.Label lblPlayer2SpeedDown;
		private System.Windows.Forms.Label lblPlayer4Up;
		private CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer4;
		private System.Windows.Forms.Button btnCancel;
		#endregion
		private System.Windows.Forms.Button btnRestoreDefaults;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormSetControls(MainForm parentForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.parentForm = parentForm;
			this.labelUpHeading = "Move Up:  ";
			this.labelDownHeading = "Move Down:  ";
			this.labelLeftHeading = "Move Left:  ";
			this.labelRightHeading = "Move Right:  ";
			this.labelSpeedUpHeading = "Speed Up:  ";
			this.labelSpeedDownHeading = "Speed Down:  ";
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
			this.collapsableGroupBox1 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.btnRestoreDefaults = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cgbPlayer4 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.lblPlayer4SpeedDown = new System.Windows.Forms.Label();
			this.lblPlayer4SpeedUp = new System.Windows.Forms.Label();
			this.lblPlayer4Right = new System.Windows.Forms.Label();
			this.lblPlayer4Left = new System.Windows.Forms.Label();
			this.lblPlayer4Down = new System.Windows.Forms.Label();
			this.lblPlayer4Up = new System.Windows.Forms.Label();
			this.cgbPlayer3 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.lblPlayer3SpeedDown = new System.Windows.Forms.Label();
			this.lblPlayer3SpeedUp = new System.Windows.Forms.Label();
			this.lblPlayer3Right = new System.Windows.Forms.Label();
			this.lblPlayer3Left = new System.Windows.Forms.Label();
			this.lblPlayer3Down = new System.Windows.Forms.Label();
			this.lblPlayer3Up = new System.Windows.Forms.Label();
			this.cgbPlayer2 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.lblPlayer2SpeedDown = new System.Windows.Forms.Label();
			this.lblPlayer2SpeedUp = new System.Windows.Forms.Label();
			this.lblPlayer2Right = new System.Windows.Forms.Label();
			this.lblPlayer2Left = new System.Windows.Forms.Label();
			this.lblPlayer2Down = new System.Windows.Forms.Label();
			this.lblPlayer2Up = new System.Windows.Forms.Label();
			this.cgbPlayer1 = new CustomCollapsableGroupBox2.CollapsableGroupBox();
			this.lblPlayer1SpeedDown = new System.Windows.Forms.Label();
			this.lblPlayer1SpeedUp = new System.Windows.Forms.Label();
			this.lblPlayer1Right = new System.Windows.Forms.Label();
			this.lblPlayer1Left = new System.Windows.Forms.Label();
			this.lblPlayer1Down = new System.Windows.Forms.Label();
			this.lblPlayer1Up = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.collapsableGroupBox1.SuspendLayout();
			this.cgbPlayer4.SuspendLayout();
			this.cgbPlayer3.SuspendLayout();
			this.cgbPlayer2.SuspendLayout();
			this.cgbPlayer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// collapsableGroupBox1
			// 
			this.collapsableGroupBox1.AutoHide = true;
			this.collapsableGroupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.collapsableGroupBox1.BorderColor = System.Drawing.Color.White;
			this.collapsableGroupBox1.BorderThickness = 1;
			this.collapsableGroupBox1.BorderVisible = true;
			this.collapsableGroupBox1.CaptionBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.collapsableGroupBox1.CaptionEnableBCGradient = false;
			this.collapsableGroupBox1.CaptionGradColor1 = System.Drawing.SystemColors.Menu;
			this.collapsableGroupBox1.CaptionGradColor2 = System.Drawing.Color.RosyBrown;
			this.collapsableGroupBox1.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.collapsableGroupBox1.CaptionHeight = 26;
			this.collapsableGroupBox1.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.collapsableGroupBox1.CaptionTextColor = System.Drawing.SystemColors.Info;
			this.collapsableGroupBox1.Collapsed = false;
			this.collapsableGroupBox1.Controls.Add(this.btnRestoreDefaults);
			this.collapsableGroupBox1.Controls.Add(this.btnCancel);
			this.collapsableGroupBox1.Controls.Add(this.cgbPlayer4);
			this.collapsableGroupBox1.Controls.Add(this.cgbPlayer3);
			this.collapsableGroupBox1.Controls.Add(this.cgbPlayer2);
			this.collapsableGroupBox1.Controls.Add(this.cgbPlayer1);
			this.collapsableGroupBox1.Controls.Add(this.btnClose);
			this.collapsableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableGroupBox1.HighlightCaptionTextColor = System.Drawing.Color.White;
			this.collapsableGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.collapsableGroupBox1.Name = "collapsableGroupBox1";
			this.collapsableGroupBox1.Size = new System.Drawing.Size(658, 500);
			this.collapsableGroupBox1.SmoothCollapse = false;
			this.collapsableGroupBox1.SmoothCollapseSpeed = 5;
			this.collapsableGroupBox1.TabIndex = 0;
			this.collapsableGroupBox1.Text = "P l a y e r    C o n t r o l s";
			this.collapsableGroupBox1.TimeToAutoHide = 0;
			this.collapsableGroupBox1.CollapsedStateChanged += new System.EventHandler(this.collapsableGroupBox1_CollapsedStateChanged);
			// 
			// btnRestoreDefaults
			// 
			this.btnRestoreDefaults.BackColor = System.Drawing.SystemColors.Info;
			this.btnRestoreDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestoreDefaults.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnRestoreDefaults.Location = new System.Drawing.Point(273, 448);
			this.btnRestoreDefaults.Name = "btnRestoreDefaults";
			this.btnRestoreDefaults.Size = new System.Drawing.Size(112, 32);
			this.btnRestoreDefaults.TabIndex = 43;
			this.btnRestoreDefaults.Text = "&Restore Defaults";
			this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnCancel.Location = new System.Drawing.Point(421, 448);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 32);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cgbPlayer4
			// 
			this.cgbPlayer4.AutoHide = false;
			this.cgbPlayer4.BackColor = System.Drawing.Color.LightSlateGray;
			this.cgbPlayer4.BorderColor = System.Drawing.Color.White;
			this.cgbPlayer4.BorderThickness = 1;
			this.cgbPlayer4.BorderVisible = true;
			this.cgbPlayer4.CaptionBackColor = System.Drawing.Color.RosyBrown;
			this.cgbPlayer4.CaptionEnableBCGradient = false;
			this.cgbPlayer4.CaptionGradColor1 = System.Drawing.Color.White;
			this.cgbPlayer4.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.cgbPlayer4.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.cgbPlayer4.CaptionHeight = 20;
			this.cgbPlayer4.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cgbPlayer4.CaptionTextColor = System.Drawing.Color.Azure;
			this.cgbPlayer4.Collapsed = false;
			this.cgbPlayer4.Controls.Add(this.lblPlayer4SpeedDown);
			this.cgbPlayer4.Controls.Add(this.lblPlayer4SpeedUp);
			this.cgbPlayer4.Controls.Add(this.lblPlayer4Right);
			this.cgbPlayer4.Controls.Add(this.lblPlayer4Left);
			this.cgbPlayer4.Controls.Add(this.lblPlayer4Down);
			this.cgbPlayer4.Controls.Add(this.lblPlayer4Up);
			this.cgbPlayer4.HighlightCaptionTextColor = System.Drawing.SystemColors.Info;
			this.cgbPlayer4.Location = new System.Drawing.Point(356, 248);
			this.cgbPlayer4.Name = "cgbPlayer4";
			this.cgbPlayer4.Size = new System.Drawing.Size(276, 160);
			this.cgbPlayer4.SmoothCollapse = true;
			this.cgbPlayer4.SmoothCollapseSpeed = 5;
			this.cgbPlayer4.TabIndex = 21;
			this.cgbPlayer4.Text = "Player 4";
			this.cgbPlayer4.TimeToAutoHide = 0;
			// 
			// lblPlayer4SpeedDown
			// 
			this.lblPlayer4SpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4SpeedDown.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4SpeedDown.Location = new System.Drawing.Point(56, 128);
			this.lblPlayer4SpeedDown.Name = "lblPlayer4SpeedDown";
			this.lblPlayer4SpeedDown.Size = new System.Drawing.Size(176, 30);
			this.lblPlayer4SpeedDown.TabIndex = 32;
			this.lblPlayer4SpeedDown.Tag = "Speed Down:  ";
			this.lblPlayer4SpeedDown.Text = "Speed Down:  Right Control";
			this.lblPlayer4SpeedDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer4SpeedDown.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer4SpeedUp
			// 
			this.lblPlayer4SpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4SpeedUp.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4SpeedUp.Location = new System.Drawing.Point(64, 100);
			this.lblPlayer4SpeedUp.Name = "lblPlayer4SpeedUp";
			this.lblPlayer4SpeedUp.Size = new System.Drawing.Size(168, 30);
			this.lblPlayer4SpeedUp.TabIndex = 31;
			this.lblPlayer4SpeedUp.Tag = "Speed Up:  ";
			this.lblPlayer4SpeedUp.Text = "Speed Up:   Right Shift";
			this.lblPlayer4SpeedUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer4SpeedUp.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer4Right
			// 
			this.lblPlayer4Right.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4Right.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4Right.Location = new System.Drawing.Point(136, 66);
			this.lblPlayer4Right.Name = "lblPlayer4Right";
			this.lblPlayer4Right.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer4Right.TabIndex = 30;
			this.lblPlayer4Right.Tag = "Move Right:  ";
			this.lblPlayer4Right.Text = "Move Right:  Right";
			this.lblPlayer4Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer4Right.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer4Left
			// 
			this.lblPlayer4Left.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4Left.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4Left.Location = new System.Drawing.Point(136, 32);
			this.lblPlayer4Left.Name = "lblPlayer4Left";
			this.lblPlayer4Left.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer4Left.TabIndex = 29;
			this.lblPlayer4Left.Tag = "Move Left:  ";
			this.lblPlayer4Left.Text = "Move Left:  Left";
			this.lblPlayer4Left.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer4Left.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer4Down
			// 
			this.lblPlayer4Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4Down.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4Down.Location = new System.Drawing.Point(8, 66);
			this.lblPlayer4Down.Name = "lblPlayer4Down";
			this.lblPlayer4Down.Size = new System.Drawing.Size(135, 30);
			this.lblPlayer4Down.TabIndex = 21;
			this.lblPlayer4Down.Tag = "Move Down:  ";
			this.lblPlayer4Down.Text = "Move Down:  Down";
			this.lblPlayer4Down.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer4Up
			// 
			this.lblPlayer4Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer4Up.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer4Up.Location = new System.Drawing.Point(8, 32);
			this.lblPlayer4Up.Name = "lblPlayer4Up";
			this.lblPlayer4Up.Size = new System.Drawing.Size(109, 30);
			this.lblPlayer4Up.TabIndex = 19;
			this.lblPlayer4Up.Tag = "Move Up:  ";
			this.lblPlayer4Up.Text = "Move Up:   Up";
			this.lblPlayer4Up.Click += new System.EventHandler(this.label_Click);
			// 
			// cgbPlayer3
			// 
			this.cgbPlayer3.AutoHide = false;
			this.cgbPlayer3.BackColor = System.Drawing.Color.LightSlateGray;
			this.cgbPlayer3.BorderColor = System.Drawing.Color.White;
			this.cgbPlayer3.BorderThickness = 1;
			this.cgbPlayer3.BorderVisible = true;
			this.cgbPlayer3.CaptionBackColor = System.Drawing.Color.RosyBrown;
			this.cgbPlayer3.CaptionEnableBCGradient = false;
			this.cgbPlayer3.CaptionGradColor1 = System.Drawing.Color.White;
			this.cgbPlayer3.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.cgbPlayer3.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.cgbPlayer3.CaptionHeight = 20;
			this.cgbPlayer3.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cgbPlayer3.CaptionTextColor = System.Drawing.Color.Azure;
			this.cgbPlayer3.Collapsed = false;
			this.cgbPlayer3.Controls.Add(this.lblPlayer3SpeedDown);
			this.cgbPlayer3.Controls.Add(this.lblPlayer3SpeedUp);
			this.cgbPlayer3.Controls.Add(this.lblPlayer3Right);
			this.cgbPlayer3.Controls.Add(this.lblPlayer3Left);
			this.cgbPlayer3.Controls.Add(this.lblPlayer3Down);
			this.cgbPlayer3.Controls.Add(this.lblPlayer3Up);
			this.cgbPlayer3.HighlightCaptionTextColor = System.Drawing.SystemColors.Info;
			this.cgbPlayer3.Location = new System.Drawing.Point(28, 248);
			this.cgbPlayer3.Name = "cgbPlayer3";
			this.cgbPlayer3.Size = new System.Drawing.Size(276, 160);
			this.cgbPlayer3.SmoothCollapse = true;
			this.cgbPlayer3.SmoothCollapseSpeed = 5;
			this.cgbPlayer3.TabIndex = 20;
			this.cgbPlayer3.Text = "Player 3";
			this.cgbPlayer3.TimeToAutoHide = 0;
			// 
			// lblPlayer3SpeedDown
			// 
			this.lblPlayer3SpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3SpeedDown.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3SpeedDown.Location = new System.Drawing.Point(56, 128);
			this.lblPlayer3SpeedDown.Name = "lblPlayer3SpeedDown";
			this.lblPlayer3SpeedDown.Size = new System.Drawing.Size(176, 30);
			this.lblPlayer3SpeedDown.TabIndex = 32;
			this.lblPlayer3SpeedDown.Tag = "Speed Down:  ";
			this.lblPlayer3SpeedDown.Text = "Speed Down:  Right Control";
			this.lblPlayer3SpeedDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer3SpeedDown.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer3SpeedUp
			// 
			this.lblPlayer3SpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3SpeedUp.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3SpeedUp.Location = new System.Drawing.Point(64, 100);
			this.lblPlayer3SpeedUp.Name = "lblPlayer3SpeedUp";
			this.lblPlayer3SpeedUp.Size = new System.Drawing.Size(168, 30);
			this.lblPlayer3SpeedUp.TabIndex = 31;
			this.lblPlayer3SpeedUp.Tag = "Speed Up:  ";
			this.lblPlayer3SpeedUp.Text = "Speed Up:   Right Shift";
			this.lblPlayer3SpeedUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer3SpeedUp.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer3Right
			// 
			this.lblPlayer3Right.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3Right.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3Right.Location = new System.Drawing.Point(136, 66);
			this.lblPlayer3Right.Name = "lblPlayer3Right";
			this.lblPlayer3Right.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer3Right.TabIndex = 30;
			this.lblPlayer3Right.Tag = "Move Right:  ";
			this.lblPlayer3Right.Text = "Move Right:  Right";
			this.lblPlayer3Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer3Right.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer3Left
			// 
			this.lblPlayer3Left.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3Left.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3Left.Location = new System.Drawing.Point(136, 32);
			this.lblPlayer3Left.Name = "lblPlayer3Left";
			this.lblPlayer3Left.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer3Left.TabIndex = 29;
			this.lblPlayer3Left.Tag = "Move Left:  ";
			this.lblPlayer3Left.Text = "Move Left:  Left";
			this.lblPlayer3Left.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer3Left.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer3Down
			// 
			this.lblPlayer3Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3Down.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3Down.Location = new System.Drawing.Point(8, 66);
			this.lblPlayer3Down.Name = "lblPlayer3Down";
			this.lblPlayer3Down.Size = new System.Drawing.Size(135, 30);
			this.lblPlayer3Down.TabIndex = 21;
			this.lblPlayer3Down.Tag = "Move Down:  ";
			this.lblPlayer3Down.Text = "Move Down:  Down";
			this.lblPlayer3Down.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer3Up
			// 
			this.lblPlayer3Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer3Up.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer3Up.Location = new System.Drawing.Point(8, 32);
			this.lblPlayer3Up.Name = "lblPlayer3Up";
			this.lblPlayer3Up.Size = new System.Drawing.Size(109, 30);
			this.lblPlayer3Up.TabIndex = 19;
			this.lblPlayer3Up.Tag = "Move Up:  ";
			this.lblPlayer3Up.Text = "Move Up:   Up";
			this.lblPlayer3Up.Click += new System.EventHandler(this.label_Click);
			// 
			// cgbPlayer2
			// 
			this.cgbPlayer2.AutoHide = false;
			this.cgbPlayer2.BackColor = System.Drawing.Color.LightSlateGray;
			this.cgbPlayer2.BorderColor = System.Drawing.Color.White;
			this.cgbPlayer2.BorderThickness = 1;
			this.cgbPlayer2.BorderVisible = true;
			this.cgbPlayer2.CaptionBackColor = System.Drawing.Color.RosyBrown;
			this.cgbPlayer2.CaptionEnableBCGradient = false;
			this.cgbPlayer2.CaptionGradColor1 = System.Drawing.Color.White;
			this.cgbPlayer2.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.cgbPlayer2.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.cgbPlayer2.CaptionHeight = 20;
			this.cgbPlayer2.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cgbPlayer2.CaptionTextColor = System.Drawing.Color.Azure;
			this.cgbPlayer2.Collapsed = false;
			this.cgbPlayer2.Controls.Add(this.lblPlayer2SpeedDown);
			this.cgbPlayer2.Controls.Add(this.lblPlayer2SpeedUp);
			this.cgbPlayer2.Controls.Add(this.lblPlayer2Right);
			this.cgbPlayer2.Controls.Add(this.lblPlayer2Left);
			this.cgbPlayer2.Controls.Add(this.lblPlayer2Down);
			this.cgbPlayer2.Controls.Add(this.lblPlayer2Up);
			this.cgbPlayer2.HighlightCaptionTextColor = System.Drawing.SystemColors.Info;
			this.cgbPlayer2.Location = new System.Drawing.Point(356, 64);
			this.cgbPlayer2.Name = "cgbPlayer2";
			this.cgbPlayer2.Size = new System.Drawing.Size(276, 160);
			this.cgbPlayer2.SmoothCollapse = true;
			this.cgbPlayer2.SmoothCollapseSpeed = 5;
			this.cgbPlayer2.TabIndex = 19;
			this.cgbPlayer2.Text = "Player 2";
			this.cgbPlayer2.TimeToAutoHide = 0;
			// 
			// lblPlayer2SpeedDown
			// 
			this.lblPlayer2SpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2SpeedDown.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2SpeedDown.Location = new System.Drawing.Point(56, 128);
			this.lblPlayer2SpeedDown.Name = "lblPlayer2SpeedDown";
			this.lblPlayer2SpeedDown.Size = new System.Drawing.Size(176, 30);
			this.lblPlayer2SpeedDown.TabIndex = 32;
			this.lblPlayer2SpeedDown.Tag = "Speed Down:  ";
			this.lblPlayer2SpeedDown.Text = "Speed Down:  Right Control";
			this.lblPlayer2SpeedDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer2SpeedDown.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer2SpeedUp
			// 
			this.lblPlayer2SpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2SpeedUp.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2SpeedUp.Location = new System.Drawing.Point(64, 100);
			this.lblPlayer2SpeedUp.Name = "lblPlayer2SpeedUp";
			this.lblPlayer2SpeedUp.Size = new System.Drawing.Size(168, 30);
			this.lblPlayer2SpeedUp.TabIndex = 31;
			this.lblPlayer2SpeedUp.Tag = "Speed Up:  ";
			this.lblPlayer2SpeedUp.Text = "Speed Up:   Right Shift";
			this.lblPlayer2SpeedUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer2SpeedUp.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer2Right
			// 
			this.lblPlayer2Right.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2Right.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2Right.Location = new System.Drawing.Point(136, 66);
			this.lblPlayer2Right.Name = "lblPlayer2Right";
			this.lblPlayer2Right.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer2Right.TabIndex = 30;
			this.lblPlayer2Right.Tag = "Move Right:  ";
			this.lblPlayer2Right.Text = "Move Right:  Right";
			this.lblPlayer2Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer2Right.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer2Left
			// 
			this.lblPlayer2Left.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2Left.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2Left.Location = new System.Drawing.Point(136, 32);
			this.lblPlayer2Left.Name = "lblPlayer2Left";
			this.lblPlayer2Left.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer2Left.TabIndex = 29;
			this.lblPlayer2Left.Tag = "Move Left:  ";
			this.lblPlayer2Left.Text = "Move Left:  Up";
			this.lblPlayer2Left.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer2Left.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer2Down
			// 
			this.lblPlayer2Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2Down.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2Down.Location = new System.Drawing.Point(8, 66);
			this.lblPlayer2Down.Name = "lblPlayer2Down";
			this.lblPlayer2Down.Size = new System.Drawing.Size(135, 30);
			this.lblPlayer2Down.TabIndex = 21;
			this.lblPlayer2Down.Tag = "Move Down:  ";
			this.lblPlayer2Down.Text = "Move Down:  Down";
			this.lblPlayer2Down.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer2Up
			// 
			this.lblPlayer2Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer2Up.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer2Up.Location = new System.Drawing.Point(8, 32);
			this.lblPlayer2Up.Name = "lblPlayer2Up";
			this.lblPlayer2Up.Size = new System.Drawing.Size(136, 30);
			this.lblPlayer2Up.TabIndex = 19;
			this.lblPlayer2Up.Tag = "Move Up:  ";
			this.lblPlayer2Up.Text = "Move Up:   Up";
			this.lblPlayer2Up.Click += new System.EventHandler(this.label_Click);
			// 
			// cgbPlayer1
			// 
			this.cgbPlayer1.AutoHide = false;
			this.cgbPlayer1.BackColor = System.Drawing.Color.LightSlateGray;
			this.cgbPlayer1.BorderColor = System.Drawing.Color.White;
			this.cgbPlayer1.BorderThickness = 1;
			this.cgbPlayer1.BorderVisible = true;
			this.cgbPlayer1.CaptionBackColor = System.Drawing.Color.RosyBrown;
			this.cgbPlayer1.CaptionEnableBCGradient = false;
			this.cgbPlayer1.CaptionGradColor1 = System.Drawing.Color.White;
			this.cgbPlayer1.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.cgbPlayer1.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.cgbPlayer1.CaptionHeight = 20;
			this.cgbPlayer1.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.cgbPlayer1.CaptionTextColor = System.Drawing.Color.Azure;
			this.cgbPlayer1.Collapsed = false;
			this.cgbPlayer1.Controls.Add(this.lblPlayer1SpeedDown);
			this.cgbPlayer1.Controls.Add(this.lblPlayer1SpeedUp);
			this.cgbPlayer1.Controls.Add(this.lblPlayer1Right);
			this.cgbPlayer1.Controls.Add(this.lblPlayer1Left);
			this.cgbPlayer1.Controls.Add(this.lblPlayer1Down);
			this.cgbPlayer1.Controls.Add(this.lblPlayer1Up);
			this.cgbPlayer1.HighlightCaptionTextColor = System.Drawing.SystemColors.Info;
			this.cgbPlayer1.Location = new System.Drawing.Point(28, 64);
			this.cgbPlayer1.Name = "cgbPlayer1";
			this.cgbPlayer1.Size = new System.Drawing.Size(276, 160);
			this.cgbPlayer1.SmoothCollapse = true;
			this.cgbPlayer1.SmoothCollapseSpeed = 5;
			this.cgbPlayer1.TabIndex = 18;
			this.cgbPlayer1.Text = "Player 1";
			this.cgbPlayer1.TimeToAutoHide = 0;
			// 
			// lblPlayer1SpeedDown
			// 
			this.lblPlayer1SpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1SpeedDown.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1SpeedDown.Location = new System.Drawing.Point(56, 128);
			this.lblPlayer1SpeedDown.Name = "lblPlayer1SpeedDown";
			this.lblPlayer1SpeedDown.Size = new System.Drawing.Size(176, 30);
			this.lblPlayer1SpeedDown.TabIndex = 32;
			this.lblPlayer1SpeedDown.Tag = "Speed Down:  ";
			this.lblPlayer1SpeedDown.Text = "Speed Down:  Right Control";
			this.lblPlayer1SpeedDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer1SpeedDown.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer1SpeedUp
			// 
			this.lblPlayer1SpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1SpeedUp.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1SpeedUp.Location = new System.Drawing.Point(64, 100);
			this.lblPlayer1SpeedUp.Name = "lblPlayer1SpeedUp";
			this.lblPlayer1SpeedUp.Size = new System.Drawing.Size(168, 30);
			this.lblPlayer1SpeedUp.TabIndex = 31;
			this.lblPlayer1SpeedUp.Tag = "Speed Up:  ";
			this.lblPlayer1SpeedUp.Text = "Speed Up:   Right Shift";
			this.lblPlayer1SpeedUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPlayer1SpeedUp.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer1Right
			// 
			this.lblPlayer1Right.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1Right.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1Right.Location = new System.Drawing.Point(136, 66);
			this.lblPlayer1Right.Name = "lblPlayer1Right";
			this.lblPlayer1Right.Size = new System.Drawing.Size(130, 30);
			this.lblPlayer1Right.TabIndex = 30;
			this.lblPlayer1Right.Tag = "Move Right:  ";
			this.lblPlayer1Right.Text = "Move Right:  Right";
			this.lblPlayer1Right.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer1Right.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer1Left
			// 
			this.lblPlayer1Left.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1Left.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1Left.Location = new System.Drawing.Point(156, 32);
			this.lblPlayer1Left.Name = "lblPlayer1Left";
			this.lblPlayer1Left.Size = new System.Drawing.Size(110, 30);
			this.lblPlayer1Left.TabIndex = 29;
			this.lblPlayer1Left.Tag = "Move Left:  ";
			this.lblPlayer1Left.Text = "Move Left:  Left";
			this.lblPlayer1Left.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPlayer1Left.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer1Down
			// 
			this.lblPlayer1Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1Down.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1Down.Location = new System.Drawing.Point(8, 66);
			this.lblPlayer1Down.Name = "lblPlayer1Down";
			this.lblPlayer1Down.Size = new System.Drawing.Size(135, 30);
			this.lblPlayer1Down.TabIndex = 21;
			this.lblPlayer1Down.Tag = "Move Down:  ";
			this.lblPlayer1Down.Text = "Move Down:  Down";
			this.lblPlayer1Down.Click += new System.EventHandler(this.label_Click);
			// 
			// lblPlayer1Up
			// 
			this.lblPlayer1Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblPlayer1Up.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPlayer1Up.Location = new System.Drawing.Point(8, 32);
			this.lblPlayer1Up.Name = "lblPlayer1Up";
			this.lblPlayer1Up.Size = new System.Drawing.Size(109, 30);
			this.lblPlayer1Up.TabIndex = 19;
			this.lblPlayer1Up.Tag = "Move Up:  ";
			this.lblPlayer1Up.Text = "Move Up:   Up";
			this.lblPlayer1Up.Click += new System.EventHandler(this.label_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.Info;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnClose.Location = new System.Drawing.Point(125, 448);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 32);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "&Apply Changes";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormSetControls
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(658, 504);
			this.ControlBox = false;
			this.Controls.Add(this.collapsableGroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "FormSetControls";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FormControls_Load);
			this.collapsableGroupBox1.ResumeLayout(false);
			this.cgbPlayer4.ResumeLayout(false);
			this.cgbPlayer3.ResumeLayout(false);
			this.cgbPlayer2.ResumeLayout(false);
			this.cgbPlayer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void collapsableGroupBox1_CollapsedStateChanged(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox1.Height;
		}

		private void FormControls_Load(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox1.Height;
						
			this.SetAllKeys(this.parentForm.GetPlayerKeys());
		}

		private void SetAllKeys(SnakeKeys[] snakeKeys)
		{
			this.playerKeys = snakeKeys;

			if(playerKeys.Length >= 1)
			{
				this.lblPlayer1Down.Text = this.labelDownHeading + "" + playerKeys[0].keyDown;
				this.lblPlayer1Down.Tag = playerKeys[0].keyDown;

				this.lblPlayer1Up.Text = this.labelUpHeading + "" + playerKeys[0].keyUp;
				this.lblPlayer1Up.Tag = playerKeys[0].keyUp;

				this.lblPlayer1Left.Text = this.labelLeftHeading + "" + playerKeys[0].keyLeft;
				this.lblPlayer1Left.Tag = playerKeys[0].keyLeft;

				this.lblPlayer1Right.Text = this.labelRightHeading + "" + playerKeys[0].keyRight;
				this.lblPlayer1Right.Tag = playerKeys[0].keyRight;

				this.lblPlayer1SpeedDown.Text = this.labelSpeedDownHeading + "" + playerKeys[0].keySpeedDown;
				this.lblPlayer1SpeedDown.Tag = playerKeys[0].keySpeedDown;

				this.lblPlayer1SpeedUp.Text = this.labelSpeedUpHeading + "" + playerKeys[0].keySpeedUp;
				this.lblPlayer1SpeedUp.Tag = playerKeys[0].keySpeedUp;
			}
			if(playerKeys.Length >= 2)
			{
				this.lblPlayer2Down.Text = this.labelDownHeading + "" + playerKeys[1].keyDown;
				this.lblPlayer2Down.Tag = playerKeys[1].keyDown;

				this.lblPlayer2Up.Text = this.labelUpHeading + "" + playerKeys[1].keyUp;
				this.lblPlayer2Up.Tag = playerKeys[1].keyUp;

				this.lblPlayer2Left.Text = this.labelLeftHeading + "" + playerKeys[1].keyLeft;
				this.lblPlayer2Left.Tag = playerKeys[1].keyLeft;

				this.lblPlayer2Right.Text = this.labelRightHeading + "" + playerKeys[1].keyRight;
				this.lblPlayer2Right.Tag = playerKeys[1].keyRight;

				this.lblPlayer2SpeedDown.Text = this.labelSpeedDownHeading + "" + playerKeys[1].keySpeedDown;
				this.lblPlayer2SpeedDown.Tag = playerKeys[1].keySpeedDown;

				this.lblPlayer2SpeedUp.Text = this.labelSpeedUpHeading + "" + playerKeys[1].keySpeedUp;
				this.lblPlayer2SpeedUp.Tag = playerKeys[1].keySpeedUp;
			}
			if(playerKeys.Length >= 3)
			{
				this.lblPlayer3Down.Text = this.labelDownHeading + "" + playerKeys[2].keyDown;
				this.lblPlayer3Down.Tag = playerKeys[2].keyDown;

				this.lblPlayer3Up.Text = this.labelUpHeading + "" + playerKeys[2].keyUp;
				this.lblPlayer3Up.Tag = playerKeys[2].keyUp;

				this.lblPlayer3Left.Text = this.labelLeftHeading + "" + playerKeys[2].keyLeft;
				this.lblPlayer3Left.Tag = playerKeys[2].keyLeft;

				this.lblPlayer3Right.Text = this.labelRightHeading + "" + playerKeys[2].keyRight;
				this.lblPlayer3Right.Tag = playerKeys[2].keyRight;

				this.lblPlayer3SpeedDown.Text = this.labelSpeedDownHeading + "" + playerKeys[2].keySpeedDown;
				this.lblPlayer3SpeedDown.Tag = playerKeys[2].keySpeedDown;

				this.lblPlayer3SpeedUp.Text = this.labelSpeedUpHeading + "" + playerKeys[2].keySpeedUp;
				this.lblPlayer3SpeedUp.Tag = playerKeys[2].keySpeedUp;
			}
			if(playerKeys.Length >= 4)
			{
				this.lblPlayer4Down.Text = this.labelDownHeading + "" + playerKeys[3].keyDown;
				this.lblPlayer4Down.Tag = playerKeys[3].keyDown;

				this.lblPlayer4Up.Text = this.labelUpHeading + "" + playerKeys[3].keyUp;
				this.lblPlayer4Up.Tag = playerKeys[3].keyUp;

				this.lblPlayer4Left.Text = this.labelLeftHeading + "" + playerKeys[3].keyLeft;
				this.lblPlayer4Left.Tag = playerKeys[3].keyLeft;

				this.lblPlayer4Right.Text = this.labelRightHeading + "" + playerKeys[3].keyRight;
				this.lblPlayer4Right.Tag = playerKeys[3].keyRight;

				this.lblPlayer4SpeedDown.Text = this.labelSpeedDownHeading + "" + playerKeys[3].keySpeedDown;
				this.lblPlayer4SpeedDown.Tag = playerKeys[3].keySpeedDown;

				this.lblPlayer4SpeedUp.Text = this.labelSpeedUpHeading + "" + playerKeys[3].keySpeedUp;
				this.lblPlayer4SpeedUp.Tag = playerKeys[3].keySpeedUp;
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{	
			if(CheckKeyClashes() == false)
			{
				this.ApplySettings();
				this.Close();
			}
		}

		private bool CheckKeyClashes()//returns true if some keys clash with each other
		{
			for(int i=1; i<=4; i++)
				if(this.CheckIndividualPlayerKeyClashes(i) == true)
					return true;
			
			if(this.CheckClashWithOtherPlayers() == true)
				return true;

			return false;
		}

		//following function checks whether the keys of each individual player clash with its own
		//other keys or not. Returns true if some keys clash.
		private bool CheckIndividualPlayerKeyClashes(int playerNumber)
		{
			CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer = this.cgbPlayer1;
			
			if(playerNumber == 2)
				cgbPlayer = this.cgbPlayer2;
			else if(playerNumber == 3)
				cgbPlayer = this.cgbPlayer3;
			else if(playerNumber == 4)
				cgbPlayer = this.cgbPlayer4;
				
			for(int i=0; i<cgbPlayer.Controls.Count; i++)
				if(cgbPlayer.Controls[i].GetType().ToString() == "System.Windows.Forms.Label")
					for(int j=i+1; j<cgbPlayer.Controls.Count; j++)
						if(cgbPlayer.Controls[j].GetType().ToString() == "System.Windows.Forms.Label"
							&& cgbPlayer.Controls[j] != cgbPlayer.Controls[i])
						{
							System.Windows.Forms.Keys ctrl1Key = (System.Windows.Forms.Keys)cgbPlayer.Controls[i].Tag;
							System.Windows.Forms.Keys ctrl2Key = (System.Windows.Forms.Keys)cgbPlayer.Controls[j].Tag;
							if(ctrl2Key == ctrl1Key)
							{
								MessageBox.Show("Key " +ctrl1Key+ " is assigned to more than one controls !", "Error");
								return true;
							}
						}

			return false;
		}


		//following function checks whether the keys of a player clash with those
		//of other players or not. Returns true if some keys clash.
		private bool CheckClashWithOtherPlayers()
		{
			for(int playerNumber=1; playerNumber<4; playerNumber++)
			{
				CustomCollapsableGroupBox2.CollapsableGroupBox cgbPlayer = this.cgbPlayer1;
			
				if(playerNumber == 2)
					cgbPlayer = this.cgbPlayer2;
				else if(playerNumber == 3)
					cgbPlayer = this.cgbPlayer3;
				
				for(int otherPlayerNumber=playerNumber+1; otherPlayerNumber<=4; otherPlayerNumber++)
				{

					CustomCollapsableGroupBox2.CollapsableGroupBox cgbOtherPlayer = this.cgbPlayer2;
			
					if(otherPlayerNumber == 3)
						cgbOtherPlayer = this.cgbPlayer3;
					else if(otherPlayerNumber == 4)
						cgbOtherPlayer = this.cgbPlayer4;					
				
					for(int i=0; i<cgbPlayer.Controls.Count; i++)
						if(cgbPlayer.Controls[i].GetType().ToString() == "System.Windows.Forms.Label")
							for(int j=0; j<cgbOtherPlayer.Controls.Count; j++)
								if(cgbOtherPlayer.Controls[j].GetType().ToString() == "System.Windows.Forms.Label")
								{
									System.Windows.Forms.Keys ctrl1Key = (System.Windows.Forms.Keys)cgbPlayer.Controls[i].Tag;
									System.Windows.Forms.Keys ctrl2Key = (System.Windows.Forms.Keys)cgbOtherPlayer.Controls[j].Tag;
									if(ctrl2Key == ctrl1Key)
									{
										MessageBox.Show("Key " +ctrl1Key+ " is assigned to more than one controls !", "Error");
										return true;
									}
								}

				}
			}

			return false;
		}


		private void label_Click(object sender, System.EventArgs e)
		{
			this.labelClicked = (System.Windows.Forms.Label)sender;
			this.formGetKey = new FormGetKey(this);
			this.formGetKey.ShowDialog();
		}

		internal void SetNewKey(System.Windows.Forms.Keys newKey)
		{			
			if(this.labelClicked.Text.IndexOf(this.labelUpHeading) >= 0)
				this.labelClicked.Text = this.labelUpHeading + newKey.ToString();
			else if(this.labelClicked.Text.IndexOf(this.labelDownHeading) >= 0)
				this.labelClicked.Text = this.labelDownHeading + newKey.ToString();
			else if(this.labelClicked.Text.IndexOf(this.labelLeftHeading) >= 0)
				this.labelClicked.Text = this.labelLeftHeading + newKey.ToString();
			else if(this.labelClicked.Text.IndexOf(this.labelRightHeading) >= 0)
				this.labelClicked.Text = this.labelRightHeading + newKey.ToString();
			else if(this.labelClicked.Text.IndexOf(this.labelSpeedUpHeading) >= 0)
				this.labelClicked.Text = this.labelSpeedUpHeading + newKey.ToString();
			else if(this.labelClicked.Text.IndexOf(this.labelSpeedDownHeading) >= 0)
				this.labelClicked.Text = this.labelSpeedDownHeading + newKey.ToString();

			this.labelClicked.Tag = newKey;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ApplySettings()
		{
			playerKeys[0].keyDown = (System.Windows.Forms.Keys)this.lblPlayer1Down.Tag;
			playerKeys[0].keyUp = (System.Windows.Forms.Keys)this.lblPlayer1Up.Tag;
			playerKeys[0].keyLeft = (System.Windows.Forms.Keys)this.lblPlayer1Left.Tag;
			playerKeys[0].keyRight = (System.Windows.Forms.Keys)this.lblPlayer1Right.Tag;
			playerKeys[0].keySpeedDown = (System.Windows.Forms.Keys)this.lblPlayer1SpeedDown.Tag;
			playerKeys[0].keySpeedUp = (System.Windows.Forms.Keys)this.lblPlayer1SpeedUp.Tag;

			playerKeys[1].keyDown = (System.Windows.Forms.Keys)this.lblPlayer2Down.Tag;
			playerKeys[1].keyUp = (System.Windows.Forms.Keys)this.lblPlayer2Up.Tag;
			playerKeys[1].keyLeft = (System.Windows.Forms.Keys)this.lblPlayer2Left.Tag;
			playerKeys[1].keyRight = (System.Windows.Forms.Keys)this.lblPlayer2Right.Tag;
			playerKeys[1].keySpeedDown = (System.Windows.Forms.Keys)this.lblPlayer2SpeedDown.Tag;
			playerKeys[1].keySpeedUp = (System.Windows.Forms.Keys)this.lblPlayer2SpeedUp.Tag;

			playerKeys[2].keyDown = (System.Windows.Forms.Keys)this.lblPlayer3Down.Tag;
			playerKeys[2].keyUp = (System.Windows.Forms.Keys)this.lblPlayer3Up.Tag;
			playerKeys[2].keyLeft = (System.Windows.Forms.Keys)this.lblPlayer3Left.Tag;
			playerKeys[2].keyRight = (System.Windows.Forms.Keys)this.lblPlayer3Right.Tag;
			playerKeys[2].keySpeedDown = (System.Windows.Forms.Keys)this.lblPlayer3SpeedDown.Tag;
			playerKeys[2].keySpeedUp = (System.Windows.Forms.Keys)this.lblPlayer3SpeedUp.Tag;

			playerKeys[3].keyDown = (System.Windows.Forms.Keys)this.lblPlayer4Down.Tag;
			playerKeys[3].keyUp = (System.Windows.Forms.Keys)this.lblPlayer4Up.Tag;
			playerKeys[3].keyLeft = (System.Windows.Forms.Keys)this.lblPlayer4Left.Tag;
			playerKeys[3].keyRight = (System.Windows.Forms.Keys)this.lblPlayer4Right.Tag;
			playerKeys[3].keySpeedDown = (System.Windows.Forms.Keys)this.lblPlayer4SpeedDown.Tag;
			playerKeys[3].keySpeedUp = (System.Windows.Forms.Keys)this.lblPlayer4SpeedUp.Tag;

			this.parentForm.SetPlayerKeys(this.playerKeys);
		}

		private void btnRestoreDefaults_Click(object sender, System.EventArgs e)
		{
			this.SetAllKeys(this.parentForm.GetDefaultPlayerKeys());
		}
	}
}
