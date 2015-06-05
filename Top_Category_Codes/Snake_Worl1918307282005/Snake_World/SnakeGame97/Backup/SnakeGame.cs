//#define CheckRandom
//#define SpeedCheck
//#define CrashCheck

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SnakeGame
{	
	public enum Direction{unassigned, none, up, down, left, right};
	public enum GameType{levels, timeAttack, survival, kingOfTheRing};
	public enum TimeAttackSubGameType{EatHeadIncreaseTime, FixedTime};	
	//"unassigned" is for special purpose used when the directionBufferQueue is empty in snake.cs

	/// <summary>
	/// Summary description for SnakeGame.
	/// </summary>
	public class SnakeGame : System.Windows.Forms.Form
	{		
		#region data field declarations		

		private GameOptions gameOptions;
		private Snake movingHead;
		private SnakeKeys[] playerKeys;
		private SnakeKeys[] defaultPlayerKeys;
		private GameColors gameColors;
		private GameColors defaultGameColors;
		private int maxPlayers;
		private System.Windows.Forms.Label[] lblPlayerStats;
		private int timeLimitInTimeAttack;//max. time allowed in TimeAttackGame in seconds
		private int timePassed;//time passed in TimeAttack game in seconds
		private int timeIncrementPerLevel;//times increment given for higher levels
		private GameType currentGameType;
		private TimeAttackSubGameType timeAttackSubGameType;
		private int maxHeads;//max. no. of heads to pick
		private int maxHeadsForLevelGame;
		private int maxHeadsForTimeAttackGame;
		private int maxHeadsForSurvivalGame;
		private int maxHeadsForKingOfTheRingGame;	
		private int headsPicked;//no. of heads picked so far
		private int level;//current level in GameType "levels"
		private int totalLevels;
		private int minLevelSpeed;//minimim possible speed for current level
		private int defaultMinimumSpeed;//default minimum possible speed for the game		
		private bool started;
		private bool paused;
		private int players;//represents the number of players in the current game.
		private int playersLeft;//for multiplayer game, this stores the no. of players that are not
		//out and are still in the game

		private Maze maze;
		private Snake[] snakes;		
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer tmrTimeAttack;
		private System.Windows.Forms.Label lblLevelStats;
		private System.Windows.Forms.Panel pnlStats;
		private System.ComponentModel.IContainer components;

		#endregion

		#region properties

		public GameColors DefaultGameColors
		{
			get
			{
				return this.defaultGameColors;
			}			
		}

		public GameColors GameColors
		{
			get
			{
				return this.gameColors;
			}			
			set
			{
				this.gameColors = value;
				this.SetGameColors();
			}
		}

		public SnakeKeys[] DefaultPlayerKeys
		{
			get
			{
				return this.defaultPlayerKeys;
			}			
		}

		public SnakeKeys[] PlayerKeys
		{
			get
			{
				return this.playerKeys;
			}
			set
			{
				if(value.Length != this.maxPlayers)
					return;
				
				this.playerKeys = value;
				if(this.started == true)
				{
					for(int i=0; i<players; i++)
						this.snakes[i].Keys = this.playerKeys[i];
				}
			}
		}


		public bool Paused
		{
			get
			{
				return this.paused;
			}
		}


		//should be called by other clsses only to get the value of NumberOfPlayrs
		internal int NumberOfPlayers
		{
			get
			{
				return this.players;
			}
			set
			{
				if((this.started == false || this.paused == true) &&  (value>=1  &&  value<=4))
				{
					for(int i=0; i<players; i++)//dispose previous players
						if(snakes[i] != null)
						{
							snakes[i].Dispose();
							snakes[i] = null;
						}

					this.players = value;
					this.playersLeft = value;
				}
			}
		}


		private GameType CurrentGameType
		{
			get
			{
				return this.currentGameType;
			}
			set
			{
				this.currentGameType = value;
				if(this.currentGameType == GameType.levels)
					maxHeads = this.maxHeadsForLevelGame;
				else if(this.currentGameType == GameType.timeAttack)
					maxHeads = this.maxHeadsForTimeAttackGame;
				else if(this.currentGameType == GameType.survival)
					maxHeads = this.maxHeadsForSurvivalGame;	
				else if(this.currentGameType == GameType.kingOfTheRing) 
					maxHeads = this.maxHeadsForKingOfTheRingGame;	
			}
		}


		private TimeAttackSubGameType TimeAttackCurrentSubGameType
		{
			get
			{
				return this.timeAttackSubGameType;
			}
			set
			{
				this.timeAttackSubGameType = value;				
			}
		}


		private int Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
				maze.ShowMaze(level);
			}
		}


		//returns the actual bottom of the playing area, which excludes the height of stats bar
		internal int PlayingAreaBottom
		{
			get
			{
				return this.Bottom-this.pnlStats.Height;
			}
		}

		
		#endregion

		#region Methods

		#region Constructor, other initialization methods and Dispose method

		public SnakeGame()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//		
			started = false;
			paused = false;
			this.maxPlayers = 4;
			players = 1;//maximum = 4
			this.playersLeft = 1;
			lblPlayerStats = new Label[this.maxPlayers];
			for(int i=this.maxPlayers-1; i>=0;  i--)
			{
				this.lblPlayerStats[i] = new System.Windows.Forms.Label();
				this.lblPlayerStats[i].Dock = System.Windows.Forms.DockStyle.Left;
				this.lblPlayerStats[i].Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				this.lblPlayerStats[i].Location = new System.Drawing.Point(640, 0);
				this.lblPlayerStats[i].Size = new System.Drawing.Size(160, 50);
				this.lblPlayerStats[i].Text = "Player " + (i+1) + ":";
				this.lblPlayerStats[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.pnlStats.Controls.Add(lblPlayerStats[i]);
			}

			this.lblLevelStats = new System.Windows.Forms.Label();
			this.lblLevelStats.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblLevelStats.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLevelStats.Location = new System.Drawing.Point(0, 0);
			this.lblLevelStats.Name = "lblLevelStats";
			this.lblLevelStats.Size = new System.Drawing.Size(160, 50);
			this.lblLevelStats.TabIndex = 1;
			this.lblLevelStats.Text = "Level:";
			this.lblLevelStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.pnlStats.Controls.Add(this.lblLevelStats);

			//deault game colors
			this.gameColors.snake1Color = this.defaultGameColors.snake1Color = System.Drawing.SystemColors.InactiveCaptionText;		
			this.gameColors.snake2Color = this.defaultGameColors.snake2Color = System.Drawing.Color.AliceBlue;
			this.gameColors.snake3Color = this.defaultGameColors.snake3Color = System.Drawing.Color.Bisque;
			this.gameColors.snake4Color = this.defaultGameColors.snake4Color = System.Drawing.Color.LightCyan;
			this.gameColors.headColor = this.defaultGameColors.headColor = System.Drawing.SystemColors.Info;
			this.gameColors.mazeColor = this.defaultGameColors.mazeColor = System.Drawing.SystemColors.GrayText;
			this.gameColors.playingAreaColor = this.defaultGameColors.playingAreaColor = System.Drawing.Color.Tan;
			this.gameColors.messageColor = this.defaultGameColors.messageColor = System.Drawing.Color.RosyBrown;
			this.gameColors.statusBarColor = this.defaultGameColors.statusBarColor = System.Drawing.Color.LightSlateGray;
			this.gameColors.statusBarTextColor = this.defaultGameColors.statusBarTextColor = System.Drawing.Color.AliceBlue;


			snakes = new Snake[this.maxPlayers];
			maze = new Maze(this, this.gameColors.mazeColor);
			totalLevels = 10;
			level = 1;
			maxHeads = 40;
			this.maxHeadsForLevelGame = 40;
			this.maxHeadsForSurvivalGame = 50;
			this.maxHeadsForTimeAttackGame = 50;
			this.maxHeadsForKingOfTheRingGame = 20;
			headsPicked = 0;
			this.defaultMinimumSpeed = 10;//slowest possible is 16
			this.minLevelSpeed = defaultMinimumSpeed;//slowest possible is 16

			this.timeIncrementPerLevel = 12;
			this.timePassed = 0;
			this.timeLimitInTimeAttack = this.maxHeadsForTimeAttackGame*3;		
		
			this.playerKeys = new SnakeKeys[this.maxPlayers];
			this.defaultPlayerKeys = new SnakeKeys[this.maxPlayers];
						
			//default player keys
			this.playerKeys[0].keyUp = this.defaultPlayerKeys[0].keyUp = System.Windows.Forms.Keys.Up;
			this.playerKeys[0].keyDown = this.defaultPlayerKeys[0].keyDown = System.Windows.Forms.Keys.Down;
			this.playerKeys[0].keyLeft = this.defaultPlayerKeys[0].keyLeft = System.Windows.Forms.Keys.Left;
			this.playerKeys[0].keyRight = this.defaultPlayerKeys[0].keyRight = System.Windows.Forms.Keys.Right;
			this.playerKeys[0].keySpeedUp = this.defaultPlayerKeys[0].keySpeedUp = System.Windows.Forms.Keys.ShiftKey;
			this.playerKeys[0].keySpeedDown = this.defaultPlayerKeys[0].keySpeedDown = System.Windows.Forms.Keys.ControlKey;
			
			this.playerKeys[1].keyUp = this.defaultPlayerKeys[1].keyUp = System.Windows.Forms.Keys.W;
			this.playerKeys[1].keyDown = this.defaultPlayerKeys[1].keyDown = System.Windows.Forms.Keys.S;
			this.playerKeys[1].keyLeft = this.defaultPlayerKeys[1].keyLeft = System.Windows.Forms.Keys.A;
			this.playerKeys[1].keyRight = this.defaultPlayerKeys[1].keyRight = System.Windows.Forms.Keys.D;
			this.playerKeys[1].keySpeedUp = this.defaultPlayerKeys[1].keySpeedUp = System.Windows.Forms.Keys.R;
			this.playerKeys[1].keySpeedDown = this.defaultPlayerKeys[1].keySpeedDown = System.Windows.Forms.Keys.T;
						
			this.playerKeys[2].keyUp = this.defaultPlayerKeys[2].keyUp = System.Windows.Forms.Keys.NumPad8;
			this.playerKeys[2].keyDown = this.defaultPlayerKeys[2].keyDown = System.Windows.Forms.Keys.NumPad5;
			this.playerKeys[2].keyLeft = this.defaultPlayerKeys[2].keyLeft = System.Windows.Forms.Keys.NumPad4;
			this.playerKeys[2].keyRight = this.defaultPlayerKeys[2].keyRight = System.Windows.Forms.Keys.NumPad6;
			this.playerKeys[2].keySpeedUp = this.defaultPlayerKeys[2].keySpeedUp = System.Windows.Forms.Keys.Add;
			this.playerKeys[2].keySpeedDown = this.defaultPlayerKeys[2].keySpeedDown = System.Windows.Forms.Keys.Subtract;

			this.playerKeys[3].keyUp = this.defaultPlayerKeys[3].keyUp = System.Windows.Forms.Keys.I;
			this.playerKeys[3].keyDown = this.defaultPlayerKeys[3].keyDown = System.Windows.Forms.Keys.K;
			this.playerKeys[3].keyLeft = this.defaultPlayerKeys[3].keyLeft = System.Windows.Forms.Keys.J;
			this.playerKeys[3].keyRight = this.defaultPlayerKeys[3].keyRight = System.Windows.Forms.Keys.L;
			this.playerKeys[3].keySpeedUp = this.defaultPlayerKeys[3].keySpeedUp = System.Windows.Forms.Keys.OemOpenBrackets;
			this.playerKeys[3].keySpeedDown = this.defaultPlayerKeys[3].keySpeedDown = System.Windows.Forms.Keys.OemCloseBrackets;
		}


		private void InitializePlayer(int playerNumber)
		{
			int initialSnakeLength = 1;
			if(this.currentGameType == GameType.kingOfTheRing)
				initialSnakeLength = this.maxHeadsForKingOfTheRingGame;

			int xBorderDistance = 300;//horizontal distance of snake's head from horizontal border
			int yBorderDistance = 30;//vertical distance of snake's head from vertical border

			if(this.level == 6  ||  this.level == 10)
				xBorderDistance = 50;

			if(playerNumber == 1)
				snakes[0] = new Snake(this, xBorderDistance, yBorderDistance, 
					this.gameColors.snake1Color, maxHeads, initialSnakeLength, Direction.up);
			else if(playerNumber == 2)
				snakes[1] = new Snake(this, this.Right-xBorderDistance-10, yBorderDistance,
					this.gameColors.snake2Color, maxHeads, initialSnakeLength, Direction.up);
			else if(playerNumber == 3)
				snakes[2] = new Snake(this, xBorderDistance,
					this.PlayingAreaBottom - yBorderDistance-10, 
					this.gameColors.snake3Color, maxHeads, initialSnakeLength, Direction.down);
			else if(playerNumber == 4)
				snakes[3] = new Snake(this, this.Right-xBorderDistance-10,
					this.PlayingAreaBottom - yBorderDistance - 10, 
					this.gameColors.snake4Color, maxHeads, initialSnakeLength, Direction.down);								
			
			snakes[playerNumber-1].Keys = this.playerKeys[playerNumber-1];
		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.tmrTimeAttack = new System.Windows.Forms.Timer(this.components);
			this.pnlStats = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(184, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 10);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Visible = false;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.RosyBrown;
			this.lblMessage.Location = new System.Drawing.Point(279, 256);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(242, 41);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "P  A  U  S  E  D";
			this.lblMessage.Visible = false;
			// 
			// tmrTimeAttack
			// 
			this.tmrTimeAttack.Interval = 1000;
			this.tmrTimeAttack.Tick += new System.EventHandler(this.tmrTimeAttack_Tick);
			// 
			// pnlStats
			// 
			this.pnlStats.BackColor = System.Drawing.Color.LightSlateGray;
			this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlStats.ForeColor = System.Drawing.Color.AliceBlue;
			this.pnlStats.Location = new System.Drawing.Point(0, 550);
			this.pnlStats.Name = "pnlStats";
			this.pnlStats.Size = new System.Drawing.Size(800, 50);
			this.pnlStats.TabIndex = 33;
			// 
			// SnakeGame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.ControlBox = false;
			this.Controls.Add(this.pnlStats);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SnakeGame";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		#endregion

		#region other methods

		internal System.Drawing.Rectangle GetNewHeadBounds()
		{
			if(this.gameOptions.crazyHead == true)
				return this.movingHead.GetHeadPosition();

			return this.label1.Bounds;
		}

		internal System.Drawing.Rectangle GetGameAreaBounds()
		{
			return new Rectangle(0,0,this.Width, this.ClientRectangle.Height - pnlStats.Height);
		}

		public void EndGame()
		{
			for(int i=0; i<players; i++)
			{
				if(snakes[i] != null)
				{
					snakes[i].Dispose();
					snakes[i] = null;
				}
			}

			if(this.movingHead != null)
			{
				this.movingHead.Dispose();
				this.movingHead = null;
			}

			//this.playersLeft = 0;
			started = false;
			paused = false;
			this.minLevelSpeed = this.defaultMinimumSpeed;
			this.label1.Visible = false;

			if(this.currentGameType == GameType.timeAttack)
			{
				this.tmrTimeAttack.Enabled = false;
				this.timePassed = 0;
			}
		}


		public void Pause()
		{			
			if(paused == false)
				this.Pause(true);
			else
				this.Pause(false);
		}


		public void Pause(bool pause)
		{		
			if(started == false)
				return;

			paused = pause;
			for(int i=0; i<players; i++)
				snakes[i].MoveSnake = !pause;		
			
			if(pause == true)
			{
				this.lblMessage.Text = "P  A  U  S  E  D";
				int centerX = this.Width/2;
				//int centerY = this.PlayingAreaBottom/2;
				this.lblMessage.Left = centerX - (this.lblMessage.Width/2);				
			}

			this.lblMessage.Visible = pause;	

			if(this.currentGameType == GameType.timeAttack)
				this.tmrTimeAttack.Enabled = !pause;
			
			if(this.gameOptions.crazyHead == true)
				this.movingHead.MoveSnake = !pause;
		}

		private void SnakeGame_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(started == false)
				return;			
			
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				if(paused == false)
					this.Pause(true);
				else
					this.Pause(false);

				return;
			}
			
			for(int i=0; i<players; i++)
			{
				if(e.KeyCode == snakes[i].KeyUp)
					snakes[i].MovementDirection = Direction.up;
				else if(e.KeyCode == snakes[i].KeyDown)
					snakes[i].MovementDirection = Direction.down;
				else if(e.KeyCode == snakes[i].KeyLeft)
					snakes[i].MovementDirection = Direction.left;
				else if(e.KeyCode == snakes[i].KeyRight)
					snakes[i].MovementDirection = Direction.right;
				else if(e.KeyCode == snakes[i].KeySpeedUp  &&  this.gameOptions.manualSpeed == true)
				{
					snakes[i].Speed -= 1;	
					this.ShowPlayerStatisctics(i);
				}
				else if(e.KeyCode == snakes[i].KeySpeedDown  &&  this.gameOptions.manualSpeed ==true)
				{
					snakes[i].Speed += 1;								
					this.ShowPlayerStatisctics(i);
				}
			}	
		
#if CrashCheck
			if(e.KeyCode == System.Windows.Forms.Keys.D1)
				snakes[0].MoveSnake = !snakes[0].MoveSnake;
			else if(e.KeyCode == System.Windows.Forms.Keys.D2)
				snakes[1].MoveSnake = !snakes[1].MoveSnake;
			else if(e.KeyCode == System.Windows.Forms.Keys.D3)
				snakes[2].MoveSnake = !snakes[2].MoveSnake;
			else if(e.KeyCode == System.Windows.Forms.Keys.D4)
				snakes[3].MoveSnake = !snakes[3].MoveSnake;
#endif
		}


		internal void NewGame(int numberOfPlayers, GameType gameType, 
			TimeAttackSubGameType timeAttackSubGameType, int level, GameOptions gameOptions)
		{
			this.NumberOfPlayers = numberOfPlayers;			
			this.CurrentGameType = gameType;
			this.Level = level;			
			this.gameOptions = gameOptions;

			if(this.currentGameType == GameType.timeAttack)
			{
				this.TimeAttackCurrentSubGameType = timeAttackSubGameType;

				if(this.timeAttackSubGameType == TimeAttackSubGameType.EatHeadIncreaseTime)
				{
					if(level < 4)
						this.timeLimitInTimeAttack = 75;					
					else if(level == 4)
						this.timeLimitInTimeAttack = 90;
					else if(level == 5)
						this.timeLimitInTimeAttack = 150;
					if(level == 6  ||  level == 7  ||  level == 10)
						this.timeLimitInTimeAttack = 100;
					else if(level == 8  ||  level == 9)
						this.timeLimitInTimeAttack = 120;					
				}
				else
				{
					this.timeLimitInTimeAttack = this.maxHeadsForTimeAttackGame*3+
						(level*this.timeIncrementPerLevel);

					if(level == 1)
						this.timeLimitInTimeAttack = 170;
					else if(level == 2  ||  level == 3)
						this.timeLimitInTimeAttack = 175;
					else if(level == 4)
						this.timeLimitInTimeAttack = 180;
					else if(level == 5)
						this.timeLimitInTimeAttack = 250;
					else if(level == 8)
						this.timeLimitInTimeAttack = 230;					
					else if(level == 6  ||  level == 7  ||  level == 9  ||  level == 10)
						this.timeLimitInTimeAttack = 200;
				}
			}
			this.minLevelSpeed = defaultMinimumSpeed;
			this.Start();
		}


		internal void NewGame(int numberOfPlayers, GameType gameType, int level, 
		GameOptions gameOptions)
		{
			this.NumberOfPlayers = numberOfPlayers;			
			this.CurrentGameType = gameType;
			this.Level = level;			
			this.gameOptions = gameOptions;

			int speedUpToLevel = 7;//from this level onwards, the speed will remain the same
			if(this.currentGameType == GameType.levels)
			{
				if(level <= speedUpToLevel)
					this.minLevelSpeed = defaultMinimumSpeed-(level-1);
				else
					this.minLevelSpeed = defaultMinimumSpeed-(speedUpToLevel-1);
			}
			else 
				this.minLevelSpeed = defaultMinimumSpeed;
	
			this.Start();
		}


		internal void RestartGame()
		{			
			this.started = false;
			this.NewGame(this.players, this.currentGameType, this.level, this.gameOptions);
		}


		private void Start()
		{		
#if CrashCheck
			this.minLevelSpeed = 16;
#endif

			//this.currentGameType = GameType.crazyHead;

			int totalChances = 0;
			if(currentGameType==GameType.levels)
			{
				if(this.NumberOfPlayers > 1)
					totalChances = 5;
				else
					totalChances = 3;
			}
			else if(this.currentGameType == GameType.survival)
				totalChances = 1;
			else if(this.currentGameType == GameType.timeAttack
				||  currentGameType == GameType.kingOfTheRing)
				totalChances = 5;
							
			for(int i=0; i<players; i++)
			{
				if(snakes[i] != null)
				{
					snakes[i].Dispose();
					snakes[i] = null;					
				}				

				if(this.movingHead != null)
				{
					this.movingHead.Dispose();
					this.movingHead = null;
				}


				this.InitializePlayer(i+1);

				snakes[i].MinimumPossibleSpeed = this.minLevelSpeed;
				snakes[i].Speed = this.minLevelSpeed;

				this.snakes[i].TotalChances = totalChances;
				this.snakes[i].ChancesLeft = totalChances;

				snakes[i].MoveSnake = true;
			}

			for(int i=0; i<this.maxPlayers; i++)
				if(i >= players)
					this.lblPlayerStats[i].Visible = false;
				else
					this.lblPlayerStats[i].Visible = true;

			started = true;			
			paused = false;
			this.headsPicked = 0;			
			this.lblMessage.Visible = false;
			this.label1.Location = this.GenerateNewHeadPosition();
			this.label1.Visible = true;
			
			if(this.currentGameType == GameType.timeAttack)
			{
				this.timePassed = 0;
				this.tmrTimeAttack.Enabled = true;
			}
			else if(this.currentGameType == GameType.kingOfTheRing)
			{
				this.label1.Visible = false;
				this.label1.Left = -50;
				this.label1.Top = -50;
			}
			
			if(this.gameOptions.crazyHead == true)
			{
				this.label1.Visible = false;
				this.label1.Left = -50;
				this.label1.Top = -50;

				System.Drawing.Point headLoc = this.GenerateNewHeadPosition();
				this.movingHead = new Snake(this, headLoc.X, headLoc.Y, this.gameColors.headColor, 
				1, 1, true);
				this.movingHead.Speed = this.movingHead.SlowestGameSpeed-3;
				this.movingHead.MoveSnake = true;
			}

			this.ShowLevelStatisctics();
			for(int i=0; i<players; i++)
				this.ShowPlayerStatisctics(i);
			//this.lblStats.Text = this.PlayingAreaBottom+"";
		}


		private Point GenerateRandomPoint()
		{
			System.Random rand = new Random();
			int randX = rand.Next(0, this.Width-10);
			int randY = rand.Next(0, this.ClientRectangle.Height-this.pnlStats.Height-10);

#if CheckRandom
			this.lblPlayerStats[this.maxPlayers-1].Text = this.ClientRectangle.Height+":"+this.Width+"----"+
				randX+":"+randY;
#endif

			int diff = randX % 10;
			if(diff != 0)
			{
				if((randX + diff) < (this.Width-10))
					randX += 10-diff;
				else
					randX -= diff;
			}

			diff = randY % 10;
			if(diff != 0)
			{
				if((randY + diff) < (this.ClientRectangle.Height-this.pnlStats.Height-10))
					randY += 10-diff;
				else
					randY -= diff;
			}

#if CheckRandom
			this.lblPlayerStats[this.maxPlayers-1].Text += "--------------"+randX+":"+randY;
#endif

			return new Point(randX, randY);
		}


		private System.Drawing.Point GenerateNewHeadPosition()
		{
			System.Drawing.Point newLoc;
			bool correctPositionGeneratedSnake = false;//to check if new Head'sposition 
			//overlaps the snakes
			bool correctPositionGeneratedMaze = false;//to check if new head's position 
			//overlaps current level maze			

			while(true)
			{
				newLoc = this.GenerateRandomPoint();
				
				for(int i=0; i<players; i++)
				{
					correctPositionGeneratedSnake = snakes[i].IsNewHeadPositionCorrect(newLoc);
					if(correctPositionGeneratedSnake == false)
						break;
				}

				correctPositionGeneratedMaze = maze.IsHeadPositionCorrect(newLoc);				

				if(correctPositionGeneratedSnake == true  
					&& correctPositionGeneratedMaze == true)
					break;
				

			}//end of while loop
			
			return newLoc;						
		}


		internal Snake[] GetAllSnakes()
		{
			return this.snakes;
		}


		internal Maze GetMaze()
		{
			return this.maze;
		}


		private void tmrTimeAttack_Tick(object sender, System.EventArgs e)
		{
			this.timePassed++;
			if(this.timePassed == this.timeLimitInTimeAttack)
			{
				this.EndGame();
				this.lblMessage.Text = "T  I  M  E      O  V  E  R";
				int centerX = this.Width/2;
				//int centerY = this.PlayingAreaBottom/2;
				this.lblMessage.Left = centerX - (this.lblMessage.Width/2);				
				this.lblMessage.Visible = true;
				//MessageBox.Show("Time Over");
			}
		
			this.ShowLevelStatisctics();			
		}

		private void ShowLevelStatisctics()
		{
			this.lblLevelStats.Text = "Level=" + this.level;
			if(currentGameType != GameType.kingOfTheRing)
				this.lblLevelStats.Text += "   Heads=" + this.headsPicked + "/" + (this.maxHeads-1);
			this.lblLevelStats.Text += "\nMinimum Speed: " + this.minLevelSpeed;

			if(this.currentGameType == GameType.timeAttack)
				this.lblLevelStats.Text += "\nTime: " + this.timePassed + " / " + 
					this.timeLimitInTimeAttack;				
		}


		private void ShowPlayerStatisctics(int player)
		{			
			this.lblPlayerStats[player].Text = "Player " + (player+1) + ": ";
			this.lblPlayerStats[player].Text += "  Lives: " + this.snakes[player].ChancesLeft + "/" +
				this.snakes[player].TotalChances;					
			if(currentGameType != GameType.kingOfTheRing)
				this.lblPlayerStats[player].Text += "\nHeads Picked: " + (this.snakes[player].SnakeLength-1);
			//this.lblPlayerStats[player].Text += "\nLives: " + this.snakes[player].ChancesLeft + "/" +
			//this.snakes[player].TotalChances;		
			this.lblPlayerStats[player].Text += "\nCurrent Speed: " + this.snakes[player].Speed;
		}		

		//only to be called when in the KingOfTheRing the game draws by a head to head crash.
		//so that the chances of other player are also to be displayed as 0.
		private void ShowPlayerStatisctics(int player, int chancesLeft)
		{			
			this.lblPlayerStats[player].Text = "Player " + (player+1) + ": ";
			this.lblPlayerStats[player].Text += "  Lives: " + chancesLeft + "/" +
				this.snakes[player].TotalChances;					
			if(currentGameType != GameType.kingOfTheRing)
				this.lblPlayerStats[player].Text += "\nHeads Picked: " + (this.snakes[player].SnakeLength-1);
			//this.lblPlayerStats[player].Text += "\nLives: " + this.snakes[player].ChancesLeft + "/" +
			//this.snakes[player].TotalChances;		
			this.lblPlayerStats[player].Text += "\nCurrent Speed: " + this.snakes[player].Speed;
		}		


		internal void HeadCatched(int catchingPlayerNumber)
		{
			this.headsPicked++;

			if(headsPicked == maxHeads-1)//1 head is already attached to snake at start of game
			{
				this.ShowLevelStatisctics();
				this.ShowPlayerStatisctics(catchingPlayerNumber);
				this.EndGame();
				this.lblMessage.Text = "L  E  V  E  L      C  O  M  P  L  E  T  E  D";
				int centerX = this.Width/2;
				//int centerY = this.PlayingAreaBottom/2;
				this.lblMessage.Left = centerX - (this.lblMessage.Width/2);				
				this.lblMessage.Visible = true;

				return;
			}
			else
			{
				if(this.currentGameType == GameType.levels)
				{
					if((this.maxHeads/2)==this.headsPicked)//half of the heads have been eaten
					{
						this.minLevelSpeed--;
						for(int i=0; i<players; i++)
						{
							snakes[i].MinimumPossibleSpeed = this.minLevelSpeed;
							if(snakes[i].Speed > this.minLevelSpeed)
								snakes[i].Speed = this.minLevelSpeed;
						}
					}
				}
				else if(this.currentGameType == GameType.survival)
				{
					if(this.headsPicked%5 == 0  &&  this.minLevelSpeed > 2)
					{
						this.minLevelSpeed--;

						for(int i=0; i<players; i++)
						{
							snakes[i].MinimumPossibleSpeed = this.minLevelSpeed;
							if(snakes[i].Speed > this.minLevelSpeed)
								snakes[i].Speed = this.minLevelSpeed;
						}						
					}
				}
				else if(this.currentGameType == GameType.timeAttack)
				{
					if(this.timeAttackSubGameType == TimeAttackSubGameType.EatHeadIncreaseTime)
					{
						if(this.timePassed >= 2)
							this.timePassed -= 2;
						else
							this.timePassed = 0;							
					}
				}
				this.ShowPlayerStatisctics(catchingPlayerNumber);
				this.ShowLevelStatisctics();
			}

			//this.lblStats.Text = snakes[0].Speed+":"+snakes[0].MinimumPossibleSpeed+"--"+this.headsPicked;							
			if(this.gameOptions.crazyHead == true)
				this.movingHead.AIEnabledHeadLocation = this.GenerateNewHeadPosition();
			else
				this.label1.Location = this.GenerateNewHeadPosition();			
		}

		internal void SnakeCrashed(int crashedPlayerNumber)
		{				
			//special case when in KingOfTheRing game draws by a head to head crash, so that this method
			//is called by the last player. While this method has already ended the game.
			if(started == false)
				return;

			this.snakes[crashedPlayerNumber].Speed = this.minLevelSpeed;
			this.ShowPlayerStatisctics(crashedPlayerNumber);

			if(snakes[crashedPlayerNumber].ChancesLeft > 0)
				snakes[crashedPlayerNumber].ResetSnake();
			else
			{
				snakes[crashedPlayerNumber].SnakeOut();
				this.playersLeft--;
			}

			if(this.currentGameType == GameType.kingOfTheRing  &&  playersLeft == 1)
			{			
				if(Snake.headToHeadCrashed == true)
				{
					if(snakes[Snake.headToHeadCallerPlayerNumber].ChancesLeft > 1)
					{
						this.lblMessage.Text = "P  L  A  Y  E  R   " +
						Snake.headToHeadCallerPlayerNumber+ "    W  I  N  S";
						this.ShowPlayerStatisctics(Snake.headToHeadCallerPlayerNumber, 
						snakes[Snake.headToHeadCallerPlayerNumber].ChancesLeft-1);										
					}
					else
					{
						this.lblMessage.Text = "G  A  M  E      D  R  A  W";
						this.ShowPlayerStatisctics(Snake.headToHeadCallerPlayerNumber, 0);										
					}
				}
				else
				{
					int winner = -1;
					for(int i=0; i<players; i++)
						if(snakes[i].ChancesLeft > 0)
						{
							winner = i+1;
							break;
						}

					this.lblMessage.Text = "P  L  A  Y  E  R   " +winner+ "    W  I  N  S";
				}

				started = false;
				this.EndGame();
				
				int centerX = this.Width/2;
				//int centerY = this.PlayingAreaBottom/2;
				this.lblMessage.Left = centerX - (this.lblMessage.Width/2);				
				this.lblMessage.Visible = true;				
			}
			
			if(playersLeft == 0)
			{
				started = false;
				this.EndGame();
				this.lblMessage.Text = "G  A  M  E      O  V  E  R";
				int centerX = this.Width/2;
				//int centerY = this.PlayingAreaBottom/2;
				this.lblMessage.Left = centerX - (this.lblMessage.Width/2);				
				this.lblMessage.Visible = true;				
			}			
		}
		
		private void SetGameColors()
		{
			this.label1.BackColor = this.gameColors.headColor;
			this.BackColor = this.gameColors.playingAreaColor;
			this.lblMessage.ForeColor = this.gameColors.messageColor;
			this.lblMessage.BackColor = this.BackColor;
			this.pnlStats.BackColor = this.gameColors.statusBarColor;
			this.lblLevelStats.ForeColor = this.gameColors.statusBarTextColor;
			this.lblLevelStats.BackColor = this.pnlStats.BackColor;

			for(int i=0; i<this.maxPlayers; i++)
			{
				this.lblPlayerStats[i].ForeColor = this.gameColors.statusBarTextColor;
				this.lblPlayerStats[i].BackColor = this.pnlStats.BackColor;
			}

			if(this.started == true)
			{			
				if(this.NumberOfPlayers >= 1)
					this.snakes[0].SnakeColor = this.gameColors.snake1Color;
				if(this.NumberOfPlayers >= 2)
					this.snakes[1].SnakeColor = this.gameColors.snake2Color;
				if(this.NumberOfPlayers >= 3)
					this.snakes[2].SnakeColor = this.gameColors.snake3Color;
				if(this.NumberOfPlayers >= 4)
					this.snakes[3].SnakeColor = this.gameColors.snake4Color;

				if(this.gameOptions.crazyHead == true)
					this.movingHead.SnakeColor = this.gameColors.headColor;
			}

			this.maze.MazeColor = this.gameColors.mazeColor;
		}

		#endregion

		#endregion

	}
}
