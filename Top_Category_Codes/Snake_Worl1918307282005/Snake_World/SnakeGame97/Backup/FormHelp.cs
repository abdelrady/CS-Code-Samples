using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for FormHelp.
	/// </summary>
	public class FormHelp : System.Windows.Forms.Form
	{
		private MainForm mainForm;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGeneral;
		private System.Windows.Forms.Button btnLevelBasedGame;
		private System.Windows.Forms.Button btnTimeAttack;
		private System.Windows.Forms.Button btnKingOfTheRing;
		private System.Windows.Forms.Button btnSurvival;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel pnlText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCrazyHead;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormHelp(MainForm mainForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.mainForm = mainForm;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSurvival = new System.Windows.Forms.Button();
			this.btnKingOfTheRing = new System.Windows.Forms.Button();
			this.btnTimeAttack = new System.Windows.Forms.Button();
			this.btnLevelBasedGame = new System.Windows.Forms.Button();
			this.btnGeneral = new System.Windows.Forms.Button();
			this.pnlText = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCrazyHead = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.pnlText.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Controls.Add(this.btnCrazyHead);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnSurvival);
			this.panel1.Controls.Add(this.btnKingOfTheRing);
			this.panel1.Controls.Add(this.btnTimeAttack);
			this.panel1.Controls.Add(this.btnLevelBasedGame);
			this.panel1.Controls.Add(this.btnGeneral);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(144, 358);
			this.panel1.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnExit.Location = new System.Drawing.Point(12, 301);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 32);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "&Exit";
			this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSurvival
			// 
			this.btnSurvival.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnSurvival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSurvival.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnSurvival.Location = new System.Drawing.Point(12, 163);
			this.btnSurvival.Name = "btnSurvival";
			this.btnSurvival.Size = new System.Drawing.Size(120, 32);
			this.btnSurvival.TabIndex = 14;
			this.btnSurvival.Text = "&Survival";
			this.btnSurvival.Click += new System.EventHandler(this.btnSurvival_Click);
			// 
			// btnKingOfTheRing
			// 
			this.btnKingOfTheRing.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnKingOfTheRing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKingOfTheRing.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnKingOfTheRing.Location = new System.Drawing.Point(12, 209);
			this.btnKingOfTheRing.Name = "btnKingOfTheRing";
			this.btnKingOfTheRing.Size = new System.Drawing.Size(120, 32);
			this.btnKingOfTheRing.TabIndex = 13;
			this.btnKingOfTheRing.Text = "&King of the Ring";
			this.btnKingOfTheRing.Click += new System.EventHandler(this.btnKingOfTheRing_Click);
			// 
			// btnTimeAttack
			// 
			this.btnTimeAttack.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnTimeAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimeAttack.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnTimeAttack.Location = new System.Drawing.Point(12, 117);
			this.btnTimeAttack.Name = "btnTimeAttack";
			this.btnTimeAttack.Size = new System.Drawing.Size(120, 32);
			this.btnTimeAttack.TabIndex = 12;
			this.btnTimeAttack.Text = "&Time Attack";
			this.btnTimeAttack.Click += new System.EventHandler(this.btnTimeAttack_Click);
			// 
			// btnLevelBasedGame
			// 
			this.btnLevelBasedGame.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnLevelBasedGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLevelBasedGame.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnLevelBasedGame.Location = new System.Drawing.Point(12, 71);
			this.btnLevelBasedGame.Name = "btnLevelBasedGame";
			this.btnLevelBasedGame.Size = new System.Drawing.Size(120, 32);
			this.btnLevelBasedGame.TabIndex = 11;
			this.btnLevelBasedGame.Text = "&Level Based Game";
			this.btnLevelBasedGame.Click += new System.EventHandler(this.btnLevelBasedGame_Click);
			// 
			// btnGeneral
			// 
			this.btnGeneral.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGeneral.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnGeneral.Location = new System.Drawing.Point(12, 25);
			this.btnGeneral.Name = "btnGeneral";
			this.btnGeneral.Size = new System.Drawing.Size(120, 32);
			this.btnGeneral.TabIndex = 10;
			this.btnGeneral.Text = "&General";
			this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
			// 
			// pnlText
			// 
			this.pnlText.AutoScroll = true;
			this.pnlText.Controls.Add(this.label1);
			this.pnlText.Location = new System.Drawing.Point(144, 0);
			this.pnlText.Name = "pnlText";
			this.pnlText.Size = new System.Drawing.Size(368, 360);
			this.pnlText.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(16, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 356);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
			// 
			// btnCrazyHead
			// 
			this.btnCrazyHead.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnCrazyHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrazyHead.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnCrazyHead.Location = new System.Drawing.Point(12, 255);
			this.btnCrazyHead.Name = "btnCrazyHead";
			this.btnCrazyHead.Size = new System.Drawing.Size(120, 32);
			this.btnCrazyHead.TabIndex = 16;
			this.btnCrazyHead.Text = "&Crazy Head";
			this.btnCrazyHead.Click += new System.EventHandler(this.btnCrazyHead_Click);
			// 
			// FormHelp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(510, 358);
			this.ControlBox = false;
			this.Controls.Add(this.pnlText);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormHelp";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FormHelp_Load);
			this.panel1.ResumeLayout(false);
			this.pnlText.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnKingOfTheRing_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = "   King of the Ring is a multiplayer game in which the sole "
			+"puprose of players is to knock out their opponents. There are no heads to pick and "
			+"the snake, by default, is enough long that you can use its tail to make other snakes "
			+"lose their lives. The winner is the one who survives till there are no other players "
			+"left."
			+"\n\n   In this game mode, there are no speed restriction at any level, so you "
			+" can adjust the speed of your snake according to your needs. The default number of "
			+" lives for each player is 5.";
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{	
			/*		
			while(true)
			{
				bool heightMinimum = false;
				bool widthMinimum = false;

				if(this.Width > 124)
				{
					this.Left++;					
					this.Width-=2;					
				}
				else
					widthMinimum = true;

				if(this.Height > 34)
				{
					this.Top++;					
					this.Height-=2;
				}
				else
					heightMinimum = true;

				if(heightMinimum == true  &&  widthMinimum == true)
					break;
			}
			*/
			this.Close();
		}

		private void btnTimeAttack_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = "   In Time Attack game, you have to collect 49 heads in the "
			+"specified time limit. The time limits are different for each level and set so that "
			+"the game feels both playable and challenging at the same time. There are no speed "
			+"restrictions at any level, but to win, even at the earlier levels, u have to "
			+"continuously keep on insreasing/decreasing your speeds. You have 5 lives in this "
			+"game mode."
			+"\n\nThere are further two sub game types:"
			+"\n\n   In \"Eat Head-Increase Time\" mode, not so much time is available to you, but "
			+"eating each head gives you a relaxation of 2 more seconds."
			+"\n\n   In \"Fixed Speed\" mode, the specified time limits are larger, but eating heads "
				+"gives you no relaxations at all.";
		}

		private void btnSurvival_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = "   In Survival game, the job of the player is to survive against "
			+"the continuously increasing speed limit. You have to collect a total of 49 heads. "
			+"Each time you collect 5 heads, your minimum speed limit is reduced by 1. You may still "
			+"increase your speed, but you cannot decrease your speed below the minimum speed limit "
			+"imposed on you by the game. So that after you have picked 35 or 40 heads, you have to "
			+"control the snake at really crazy speeds. Most importantly, you have only ONE LIFE."
			+"\n\n   The initial minimum allowed speed limit is same for all levels. This initial "
			+"speed limit is set to 10(the default minimum possible speed allowed by the game).";
		}

		private void btnLevelBasedGame_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = "   In Level Based Game mode, each level has its own default minimum "
			+"speed limit. At first level, this minimum speed limit is set to 10(the default minimum "
			+"possible speed allowed by the game). After that, this minimum speed limit decreases "
			+"inversely with the level number."
			+"\n\n   You have to pick a total of 39 heads at each level. Within each level, if you "
			+"pick half of the heads(20 heads), the minimum speed limit is further reduced by 1. "
			+"You can increase/decrease your speed anytime you want, but you cannot decrease "
			+"your speed below the minimum speed limit."
			+"\n\n   For a single player game, the player has 3 lives, while for a multiplayer game, "
			+"the number of lives for each player is 5.";
		}

		private void btnGeneral_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = " Snake World is much more interesting, playable and challenging "
			+"than the ordinary snake game because:\n"
			+"\n1) A total of 4 players can play the game simultaneously.\n"
			+"\n2) Players can fully customize their control keys and game colors.\n"
			+"\n3) There are 4 different types of games available to the players and each one of "
			+"those is entirely different to the others.\n"
			+"\n4) The game offers you 10 different levels, where the design and difficulty settings "
			+"of each level are complex than those of the previous levels.\n"
			+"\n5) Players can control their speed through the speed up/down keys while playing the "
			+"game. The snake's fastest speed is 1, while the slowest possible speed is 10.\n"
			+"\n6) In multiplayer mode, the game gives you the choice to enable/disable speed "
			+"control, so that you can have the multiplayer match the way you want.\n"
			+"\n7) Depending upon the level and different game types, there is sometimes a minimum "
			+"speed limit imposed on the players, so that they cannot speed down their snake below "
			+"this minimum speed limit.\n"
			+"\n8) In most of the game, the players have more than one lives available so that they "
			+"can try again and again to complete the current level.\n"	
			+"\n9) Players can pause/unpause the game anytime. Enter key is reserved for this.\n";

			this.label1.Height = 700;	
			this.label1.Width = this.pnlText.Width - 35;
		}

		private void FormHelp_Load(object sender, System.EventArgs e)
		{
			this.btnGeneral_Click(sender, e);
		}

		private void label1_TextChanged(object sender, System.EventArgs e)
		{
			this.label1.Height = this.pnlText.Height;		
			this.label1.Width = this.pnlText.Width - 20;
		}

		private void btnCrazyHead_Click(object sender, System.EventArgs e)
		{
			this.label1.Text = "   The Crazy Head can be enabled in all the game modes except "
				+"the King of the Ring game. With crazy head option enabled, now the each new head "
				+"is always moving. In a single player game, the "
				+"head normally tends to move away from the player. Similarly, in a "
				+"multiplayer game, the head tends to move away from the player that is "
				+"closest to its current position."
				+"\n\n   The continuously moving head and its direction changing behavior "
				+"makes this game mode much challenging and interesting than the ordinary "
				+"games with static head.";
		}

	}
}
