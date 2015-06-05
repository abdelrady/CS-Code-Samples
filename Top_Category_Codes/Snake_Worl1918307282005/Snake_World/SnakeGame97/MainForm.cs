using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private FormSetColors formSetColors;
		private FormAbout formAbout;
		private FormHelp formHelp;
		private SnakeGame formPlayingArea;
		private FormChooseGame formChooseGame;
		private FormSetControls formSetControls;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem miNewGame;
		private System.Windows.Forms.MenuItem miRestartGame;
		private System.Windows.Forms.MenuItem miPause;
		private System.Windows.Forms.MenuItem miEndGame;
		private System.Windows.Forms.MenuItem menuGame;
		private System.Windows.Forms.MenuItem miControls;
		private System.Windows.Forms.MenuItem miColors;
		private System.Windows.Forms.MenuItem Help;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miHelpTopics;
		private System.Windows.Forms.MenuItem miAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuGame = new System.Windows.Forms.MenuItem();
			this.miNewGame = new System.Windows.Forms.MenuItem();
			this.miRestartGame = new System.Windows.Forms.MenuItem();
			this.miPause = new System.Windows.Forms.MenuItem();
			this.miEndGame = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.miControls = new System.Windows.Forms.MenuItem();
			this.miColors = new System.Windows.Forms.MenuItem();
			this.Help = new System.Windows.Forms.MenuItem();
			this.miHelpTopics = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuGame,
																					  this.menuItem1,
																					  this.Help});
			// 
			// menuGame
			// 
			this.menuGame.Index = 0;
			this.menuGame.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.miNewGame,
																					 this.miRestartGame,
																					 this.miPause,
																					 this.miEndGame,
																					 this.menuItem3,
																					 this.miExit});
			this.menuGame.Text = "&Game";
			this.menuGame.Popup += new System.EventHandler(this.menuItem1_Popup);
			// 
			// miNewGame
			// 
			this.miNewGame.Index = 0;
			this.miNewGame.Text = "&New Game";
			this.miNewGame.Click += new System.EventHandler(this.miNewGame_Click);
			// 
			// miRestartGame
			// 
			this.miRestartGame.Enabled = false;
			this.miRestartGame.Index = 1;
			this.miRestartGame.Text = "&Restart Game";
			this.miRestartGame.Click += new System.EventHandler(this.miRestartGame_Click);
			// 
			// miPause
			// 
			this.miPause.Enabled = false;
			this.miPause.Index = 2;
			this.miPause.Text = "&Pause";
			this.miPause.Click += new System.EventHandler(this.miPause_Click);
			// 
			// miEndGame
			// 
			this.miEndGame.Enabled = false;
			this.miEndGame.Index = 3;
			this.miEndGame.Text = "&End Game";
			this.miEndGame.Click += new System.EventHandler(this.miEndGame_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 4;
			this.menuItem3.Text = "-";
			// 
			// miExit
			// 
			this.miExit.Index = 5;
			this.miExit.Text = "E&xit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miControls,
																					  this.miColors});
			this.menuItem1.Text = "&Settings";
			this.menuItem1.Popup += new System.EventHandler(this.menuItem1_Popup);
			// 
			// miControls
			// 
			this.miControls.Index = 0;
			this.miControls.Text = "&Controls";
			this.miControls.Click += new System.EventHandler(this.miControls_Click);
			// 
			// miColors
			// 
			this.miColors.Index = 1;
			this.miColors.Text = "Game Colo&rs";
			this.miColors.Click += new System.EventHandler(this.miColors_Click);
			// 
			// Help
			// 
			this.Help.Index = 2;
			this.Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.miHelpTopics,
																				 this.miAbout});
			this.Help.Text = "&Help";
			this.Help.Popup += new System.EventHandler(this.menuItem1_Popup);
			// 
			// miHelpTopics
			// 
			this.miHelpTopics.Index = 0;
			this.miHelpTopics.Text = "Hel&p Topics";
			this.miHelpTopics.Click += new System.EventHandler(this.miHelpTopics_Click);
			// 
			// miAbout
			// 
			this.miAbout.Index = 1;
			this.miAbout.Text = "&About";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(804, 624);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snake World";
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			//this.formChooseGame = new FormChooseGame();

			this.formPlayingArea = new SnakeGame();
			this.formPlayingArea.MdiParent = this;				
			this.formPlayingArea.Show();				
			this.formPlayingArea.Dock = DockStyle.Fill;	
		}

		private void miNewGame_Click(object sender, System.EventArgs e)
		{
			if(this.formPlayingArea.Paused == false)
				this.formPlayingArea.Pause(true);
			
			this.formChooseGame = new FormChooseGame();
			System.Windows.Forms.DialogResult dr = this.formChooseGame.ShowDialog();	
			if(dr == DialogResult.No)
				return;
						
			GameType selectedGameType = this.formChooseGame.SelectedGameType;
			GameOptions selectedGameOptions = this.formChooseGame.selectedGameOptions;

			if(selectedGameType == GameType.timeAttack)
				this.formPlayingArea.NewGame(this.formChooseGame.SelectedNumberOfPlayers,
					selectedGameType, this.formChooseGame.SelectedSubGameType, 
					this.formChooseGame.SelectedLevel, selectedGameOptions);				
			else
				this.formPlayingArea.NewGame(this.formChooseGame.SelectedNumberOfPlayers,
					selectedGameType, this.formChooseGame.SelectedLevel,selectedGameOptions);			
			
			for(int i=1; i<this.menuGame.MenuItems.Count-2; i++)
				this.menuGame.MenuItems[i].Enabled = true;
		}

		private void miPause_Click(object sender, System.EventArgs e)
		{
			this.formPlayingArea.Pause();
		}

		private void miRestartGame_Click(object sender, System.EventArgs e)
		{
			this.formPlayingArea.RestartGame();
		}

		private void miEndGame_Click(object sender, System.EventArgs e)
		{
			this.formPlayingArea.EndGame();
		}

		private void miControls_Click(object sender, System.EventArgs e)
		{
			this.formSetControls = new FormSetControls(this);
			this.formSetControls.ShowDialog();
		}

		private void miExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void MainForm_SizeChanged(object sender, System.EventArgs e)
		{
			if(this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
				this.formPlayingArea.Pause(true);
		}

		private void miColors_Click(object sender, System.EventArgs e)
		{
			this.formSetColors = new FormSetColors(this);
			formSetColors.ShowDialog();
		}

		internal SnakeKeys[] GetPlayerKeys()
		{
			return this.formPlayingArea.PlayerKeys;
		}

		internal SnakeKeys[] GetDefaultPlayerKeys()
		{
			return this.formPlayingArea.DefaultPlayerKeys;
		}

		internal void SetPlayerKeys(SnakeKeys[] playerKeys)
		{
			this.formPlayingArea.PlayerKeys = playerKeys;
		}


		private void menuItem1_Popup(object sender, System.EventArgs e)
		{
			if(this.formPlayingArea.Paused == false)
				this.formPlayingArea.Pause(true);
		}

		private void MainForm_Deactivate(object sender, System.EventArgs e)
		{
			if(this.formPlayingArea.Paused == false)
				this.formPlayingArea.Pause(true);
		}

		private void miHelpTopics_Click(object sender, System.EventArgs e)
		{
			this.formHelp =new FormHelp(this);
			this.formHelp.ShowDialog();
		}

		private void miAbout_Click(object sender, System.EventArgs e)
		{
			this.formAbout = new FormAbout();
			this.formAbout.ShowDialog();
		}

		internal GameColors GetDefaultGameColors()
		{
			return this.formPlayingArea.DefaultGameColors;
		}

		internal GameColors GetGameColors()
		{
			return this.formPlayingArea.GameColors;
		}

		internal void SetGameColors(GameColors gameColors)
		{
			this.formPlayingArea.GameColors = gameColors;
		}

	}
}
