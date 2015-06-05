using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for FormChooseGame.
	/// </summary>
	public class FormChooseGame : System.Windows.Forms.Form
	{
		private GameOptions gameOptions;
		private CustomCollapsableGroupBox2.CollapsableGroupBox collapsableGroupBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbGameType;
		private System.Windows.Forms.ComboBox cmbNumberOfPlayers;
		private System.Windows.Forms.ComboBox cmbLevels;
		private System.Windows.Forms.Label lblLevels;
		private System.Windows.Forms.ComboBox cmbTimeAttackSubgame;
		private System.Windows.Forms.Label lblTimeAttackSubgame;
		private System.Windows.Forms.CheckBox chkEnableManualSpeed;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox chkEnableCrazyHead;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public int SelectedNumberOfPlayers
		{
			get
			{
				return Convert.ToInt32(this.cmbNumberOfPlayers.Text);
			}
		}

		public GameType SelectedGameType
		{
			get
			{
				GameType gameType = GameType.levels;

				if(this.cmbGameType.SelectedIndex == 0)//level based game
					gameType = GameType.levels;
				else if(this.cmbGameType.SelectedIndex == 1)//time attack
					gameType = GameType.timeAttack;
				else if(this.cmbGameType.SelectedIndex == 2)//survival
					gameType = GameType.survival;
				else if(this.cmbGameType.SelectedIndex == 3)//King of the ring
					gameType = GameType.kingOfTheRing;

				return gameType;
			}
		}

		internal GameOptions selectedGameOptions
		{
			get
			{				
				gameOptions.crazyHead = this.chkEnableCrazyHead.Checked;
				gameOptions.manualSpeed = this.chkEnableManualSpeed.Checked;
				gameOptions.enemySnake = false;

				return gameOptions;
			}
		}


		public TimeAttackSubGameType SelectedSubGameType
		{
			get
			{
				TimeAttackSubGameType gameType = TimeAttackSubGameType.EatHeadIncreaseTime;

				if(this.cmbTimeAttackSubgame.SelectedIndex == 0)//Eat Head Increase Time
					gameType = TimeAttackSubGameType.EatHeadIncreaseTime;
				else if(this.cmbGameType.SelectedIndex == 1)//time attack
					gameType = TimeAttackSubGameType.FixedTime;
				
				return gameType;
			}
		}

		public int SelectedLevel
		{
			get
			{
				return Convert.ToInt32(this.cmbLevels.Text);
			}
		}
		
		public FormChooseGame()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			GameOptions gameOptions = new GameOptions();
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
			this.chkEnableCrazyHead = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.chkEnableManualSpeed = new System.Windows.Forms.CheckBox();
			this.cmbTimeAttackSubgame = new System.Windows.Forms.ComboBox();
			this.lblTimeAttackSubgame = new System.Windows.Forms.Label();
			this.cmbLevels = new System.Windows.Forms.ComboBox();
			this.lblLevels = new System.Windows.Forms.Label();
			this.cmbGameType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbNumberOfPlayers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.collapsableGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// collapsableGroupBox1
			// 
			this.collapsableGroupBox1.AutoHide = true;
			this.collapsableGroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.collapsableGroupBox1.BorderColor = System.Drawing.Color.White;
			this.collapsableGroupBox1.BorderThickness = 1;
			this.collapsableGroupBox1.BorderVisible = true;
			this.collapsableGroupBox1.CaptionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.collapsableGroupBox1.CaptionEnableBCGradient = true;
			this.collapsableGroupBox1.CaptionGradColor1 = System.Drawing.Color.White;
			this.collapsableGroupBox1.CaptionGradColor2 = System.Drawing.Color.LightSteelBlue;
			this.collapsableGroupBox1.CaptionGradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.collapsableGroupBox1.CaptionHeight = 26;
			this.collapsableGroupBox1.CaptionTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.collapsableGroupBox1.CaptionTextColor = System.Drawing.Color.SteelBlue;
			this.collapsableGroupBox1.Collapsed = false;
			this.collapsableGroupBox1.Controls.Add(this.chkEnableCrazyHead);
			this.collapsableGroupBox1.Controls.Add(this.btnCancel);
			this.collapsableGroupBox1.Controls.Add(this.chkEnableManualSpeed);
			this.collapsableGroupBox1.Controls.Add(this.cmbTimeAttackSubgame);
			this.collapsableGroupBox1.Controls.Add(this.lblTimeAttackSubgame);
			this.collapsableGroupBox1.Controls.Add(this.cmbLevels);
			this.collapsableGroupBox1.Controls.Add(this.lblLevels);
			this.collapsableGroupBox1.Controls.Add(this.cmbGameType);
			this.collapsableGroupBox1.Controls.Add(this.label2);
			this.collapsableGroupBox1.Controls.Add(this.cmbNumberOfPlayers);
			this.collapsableGroupBox1.Controls.Add(this.label1);
			this.collapsableGroupBox1.Controls.Add(this.btnClose);
			this.collapsableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableGroupBox1.HighlightCaptionTextColor = System.Drawing.Color.DodgerBlue;
			this.collapsableGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.collapsableGroupBox1.Name = "collapsableGroupBox1";
			this.collapsableGroupBox1.Size = new System.Drawing.Size(384, 328);
			this.collapsableGroupBox1.SmoothCollapse = false;
			this.collapsableGroupBox1.SmoothCollapseSpeed = 5;
			this.collapsableGroupBox1.TabIndex = 0;
			this.collapsableGroupBox1.Text = "Choose Game Type";
			this.collapsableGroupBox1.TimeToAutoHide = 0;
			this.collapsableGroupBox1.CollapsedStateChanged += new System.EventHandler(this.collapsableGroupBox1_CollapsedStateChanged);
			// 
			// chkEnableCrazyHead
			// 
			this.chkEnableCrazyHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkEnableCrazyHead.ForeColor = System.Drawing.SystemColors.Highlight;
			this.chkEnableCrazyHead.Location = new System.Drawing.Point(101, 208);
			this.chkEnableCrazyHead.Name = "chkEnableCrazyHead";
			this.chkEnableCrazyHead.Size = new System.Drawing.Size(180, 16);
			this.chkEnableCrazyHead.TabIndex = 19;
			this.chkEnableCrazyHead.Text = "Enable Crazy Head";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnCancel.Location = new System.Drawing.Point(200, 280);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 32);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// chkEnableManualSpeed
			// 
			this.chkEnableManualSpeed.Checked = true;
			this.chkEnableManualSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEnableManualSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkEnableManualSpeed.ForeColor = System.Drawing.SystemColors.Highlight;
			this.chkEnableManualSpeed.Location = new System.Drawing.Point(103, 240);
			this.chkEnableManualSpeed.Name = "chkEnableManualSpeed";
			this.chkEnableManualSpeed.Size = new System.Drawing.Size(180, 16);
			this.chkEnableManualSpeed.TabIndex = 17;
			this.chkEnableManualSpeed.Text = "Enable manual speed control";
			this.chkEnableManualSpeed.Visible = false;
			// 
			// cmbTimeAttackSubgame
			// 
			this.cmbTimeAttackSubgame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTimeAttackSubgame.Items.AddRange(new object[] {
																	  "Eat Head-Increase Time",
																	  "Fixed Time For Each level"});
			this.cmbTimeAttackSubgame.Location = new System.Drawing.Point(163, 167);
			this.cmbTimeAttackSubgame.Name = "cmbTimeAttackSubgame";
			this.cmbTimeAttackSubgame.Size = new System.Drawing.Size(152, 21);
			this.cmbTimeAttackSubgame.TabIndex = 3;
			this.cmbTimeAttackSubgame.Visible = false;			
			// 
			// lblTimeAttackSubgame
			// 
			this.lblTimeAttackSubgame.AutoSize = true;
			this.lblTimeAttackSubgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTimeAttackSubgame.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblTimeAttackSubgame.Location = new System.Drawing.Point(59, 169);
			this.lblTimeAttackSubgame.Name = "lblTimeAttackSubgame";
			this.lblTimeAttackSubgame.Size = new System.Drawing.Size(89, 16);
			this.lblTimeAttackSubgame.TabIndex = 16;
			this.lblTimeAttackSubgame.Text = "Sub Game Type";
			this.lblTimeAttackSubgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTimeAttackSubgame.Visible = false;
			// 
			// cmbLevels
			// 
			this.cmbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLevels.Items.AddRange(new object[] {
														   "1",
														   "2",
														   "3",
														   "4",
														   "5",
														   "6",
														   "7",
														   "8",
														   "9",
														   "10"});
			this.cmbLevels.Location = new System.Drawing.Point(163, 93);
			this.cmbLevels.MaxDropDownItems = 5;
			this.cmbLevels.Name = "cmbLevels";
			this.cmbLevels.Size = new System.Drawing.Size(48, 21);
			this.cmbLevels.TabIndex = 1;
			// 
			// lblLevels
			// 
			this.lblLevels.AutoSize = true;
			this.lblLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLevels.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblLevels.Location = new System.Drawing.Point(72, 95);
			this.lblLevels.Name = "lblLevels";
			this.lblLevels.Size = new System.Drawing.Size(76, 16);
			this.lblLevels.TabIndex = 14;
			this.lblLevels.Text = "Choose Level";
			this.lblLevels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbGameType
			// 
			this.cmbGameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGameType.Items.AddRange(new object[] {
															 "Level Based Game",
															 "Time Attack",
															 "Survival",
															 "King Of The Ring"});
			this.cmbGameType.Location = new System.Drawing.Point(163, 130);
			this.cmbGameType.Name = "cmbGameType";
			this.cmbGameType.Size = new System.Drawing.Size(120, 21);
			this.cmbGameType.TabIndex = 2;
			this.cmbGameType.SelectedIndexChanged += new System.EventHandler(this.cmbGameType_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(83, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Game Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbNumberOfPlayers
			// 
			this.cmbNumberOfPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNumberOfPlayers.Items.AddRange(new object[] {
																	"1",
																	"2",
																	"3",
																	"4"});
			this.cmbNumberOfPlayers.Location = new System.Drawing.Point(163, 56);
			this.cmbNumberOfPlayers.Name = "cmbNumberOfPlayers";
			this.cmbNumberOfPlayers.Size = new System.Drawing.Size(48, 21);
			this.cmbNumberOfPlayers.TabIndex = 0;
			this.cmbNumberOfPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfPlayers_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(46, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Number of Players";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.Info;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnClose.Location = new System.Drawing.Point(56, 280);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 32);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "&Play";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormChooseGame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 336);
			this.ControlBox = false;
			this.Controls.Add(this.collapsableGroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormChooseGame";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FormChooseGame_Load);
			this.collapsableGroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void collapsableGroupBox1_CollapsedStateChanged(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox1.Height;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{			
			if(this.cmbGameType.SelectedIndex == 3)
			{
				if(this.cmbNumberOfPlayers.SelectedIndex == 0)
				{
					MessageBox.Show("King of the Ring is available only for a multiplayer game", "Error");
					return;
				}
				else if(this.chkEnableCrazyHead.Checked == true)
				{
					MessageBox.Show("Crazy Head can't be enabled in the King of the Ring game", "Error");
					return;
				}
			}
			//else
			this.Close();
		}

		private void FormChooseGame_Load(object sender, System.EventArgs e)
		{
			this.Height = this.collapsableGroupBox1.Height;

			this.cmbNumberOfPlayers.SelectedIndex = 0;
			this.cmbGameType.SelectedIndex = 0;
			this.cmbLevels.SelectedIndex = 0;
			this.cmbTimeAttackSubgame.SelectedIndex = 0;
		}

		private void cmbGameType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.cmbGameType.SelectedIndex != 1)
				ShowHideSubGameOption(false);
			else
				ShowHideSubGameOption(true);
		}

		private void ShowHideSubGameOption(bool visible)
		{
			this.cmbTimeAttackSubgame.Visible = visible;
			this.lblTimeAttackSubgame.Visible = visible;
		}

		private void cmbNumberOfPlayers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.cmbNumberOfPlayers.SelectedIndex != 0)
				this.chkEnableManualSpeed.Visible = true;
			else
				this.chkEnableManualSpeed.Visible = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
