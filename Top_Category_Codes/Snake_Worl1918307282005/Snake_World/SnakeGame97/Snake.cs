using System;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for Snake.
	/// </summary>
	/// 

	public class Snake
	{			
		#region data field declarations

		private int movesBeforeAIDirectionChange;
		private int currentAImoves;
		private Direction suggestedAIDirection;
		private bool isAIEnabledHead;

		private Direction layoutDirection;//indicates the layout direction of the snake
		//e.g. if layoutDirection==Direction.right, the snake will be drawn in left to right
		// direction on the screen, with the head in the Direction.left direction.
		private System.Drawing.Color snakeBackColor;
		private bool snakeOut;
		private SnakeKeys keys;
		private System.Windows.Forms.Keys keyUp;
		private	System.Windows.Forms.Keys keyDown;
		private System.Windows.Forms.Keys keyLeft;
		private System.Windows.Forms.Keys keyRight;
		private System.Windows.Forms.Keys keySpeedUp;
		private System.Windows.Forms.Keys keySpeedDown;
		private int totalChances;//there can be a max. of 100 chances
		private int chancesLeft;
		private static int totalPlayers = -1;
		internal static bool headToHeadCrashed = false;//its value will remain true only during
		//the period from when a head to head crash occured between any 2 players
		//to the time when the ResetSnake() method is called for any snake. In ResetSnake() method
		//the value will get back to false. If ResetSnake() method isn't called, then the value
		//will be set to true in the constructor, whenever a new object is initialized.
		//The basic purpose of this variable is in KingOfTheRing game, when there are 2 players
		//left. Both of them have only one chance left and then they have a head to head, so that
		//no one wins and the SnakeCrashed() method of SnakeGame class can check out the value
		//of this variable to figure out whether the last crash was a head to head.

		internal static int headToHeadCallerPlayerNumber = -1;//if CheckHeadToHeadCrash() method
		//is called by snake object A, it checks all the other snake Objects if they have a head to 
		//head with object A. If some other object say B is having a head to head Clash with object A
		//first, the SnakeCrashed() method of SnakeGame class will be called for object B; not 
		//for object A. But immedialtely after that the SnakeCrashed() will also be called for 
		//object A, informing the SnakeGame class about the playerNumber of object A.
		//In above situation, headToHeadCallerPlayerNumber stores the playerNumber of object A, for
		//which the CheckHeadToHeadCrash() method was originally called.
		//The purpose of this variable is in KingOfTheRing game, to show the statistics of both
		// the last players, if the game draws for a last head to head crash as described for 
		// the explanation of headToHeadCrashed variable above.
		//Both of these static variables headToHeadCrashed and headToHeadCallerPlayerNumber
		//should be used in conjunction with each other.

		private int playerNumber;
		private SnakeGame parentForm;
		private System.Windows.Forms.Timer timer1;
		private Queue directionBufferQueue;		
		private int directionBufferSize;
		private int speed;//between 1(fastest)-16(slowest).Default=16
		private int slowestGameSpeed;//default slowest speed allowed by the game.
		private int fastestGameSpeed;//default fastest speed allowed by the game.
		private int minimumPossibleSpeed;//snake's speed cant be more slower than this value
		private int defaultSpeed;
		private Direction direction;
		private int hi;//index of the head 
		private int ti;//index of the tail
		private int snakeLength;//current length of snake
		private int maxSnakeLength;
		private static int size = 10;
		private int snakeStartLeft;
		private int snakeStartTop;		
		private System.Windows.Forms.Label[] snake;
		#endregion
        
		#region properties

		internal System.Drawing.Color SnakeColor
		{
			get
			{
				return this.snakeBackColor;
			}
			set
			{
				this.snakeBackColor = value;

				for(int i=0; i<this.snakeLength; i++)
					this.snake[i].BackColor = value;
			}
		}

		internal System.Drawing.Point AIEnabledHeadLocation
		{
			get
			{
				return this.snake[hi].Location;
			}
			set
			{
				if(this.isAIEnabledHead == true)
				{
					this.snake[hi].Visible = false;
					this.snake[hi].Location = value;
					this.snake[hi].Visible = true;
				}
			}
		}

		internal bool IsAIEnabledHead
		{
			get
			{
				return this.isAIEnabledHead;
			}
		}

		internal int GetTimerValue
		{
			get
			{
				return this.timer1.Interval;
			}
		}


		internal SnakeKeys Keys
		{
			get
			{
				keys.keyUp = this.keyUp;
				keys.keyDown = this.keyDown;
				keys.keyLeft = this.keyLeft;
				keys.keyRight = this.keyRight;
				keys.keySpeedUp = this.keySpeedUp;
				keys.keySpeedDown = this.keySpeedDown;
				return keys;
			}
			set
			{
				this.keys = value;
				this.keyUp = keys.keyUp;
				this.keyDown = keys.keyDown;
				this.keyLeft = keys.keyLeft;
				this.keyRight = keys.keyRight;
				this.keySpeedUp = keys.keySpeedUp;
				this.keySpeedDown = keys.keySpeedDown;
			}
		}


		internal System.Windows.Forms.Keys KeyUp
		{
			get
			{
				return this.keyUp;
			}
			set
			{
				this.keyUp = value;
			}
		}


		internal System.Windows.Forms.Keys KeyDown
		{
			get
			{
				return this.keyDown;
			}
			set
			{
				this.keyDown = value;
			}
		}


		internal System.Windows.Forms.Keys KeyLeft
		{
			get
			{
				return this.keyLeft;
			}
			set
			{
				this.keyLeft = value;
			}
		}


		internal System.Windows.Forms.Keys KeyRight
		{
			get
			{
				return this.keyRight;
			}
			set
			{
				this.keyRight = value;
			}
		}


		internal System.Windows.Forms.Keys KeySpeedUp
		{
			get
			{
				return this.keySpeedUp;
			}
			set
			{
				this.keySpeedUp = value;
			}
		}


		internal System.Windows.Forms.Keys KeySpeedDown
		{
			get
			{
				return this.keySpeedDown;
			}
			set
			{
				this.keySpeedDown = value;
			}
		}


		internal int SnakeLength
		{
			get
			{
				return this.snakeLength;
			}
			set
			{
				if(value <= this.maxSnakeLength)
				{
					for(int i=value; i<snakeLength; i++)
						snake[i].Visible = false;

					this.snakeLength = value;
				}
			}
		}


		internal bool MoveSnake
		{
			get
			{
				return this.timer1.Enabled;
			}
			set
			{		
				if(this.snakeOut == false)
					this.timer1.Enabled = value;
			}
		}


		internal Direction MovementDirection
		{
			get
			{
				Direction tempDirection = directionBufferQueue.GetTopElement();
				if(tempDirection == Direction.unassigned  ||  tempDirection == Direction.none)
					return direction;
				else
					return tempDirection;
			}
			set
			{		
				//if new direction key is not the same as that the last one pressed
				if(value != directionBufferQueue.GetBottomElement())
				{
					//if snake is not moving and the layoutDirection direction key is pressed
					//which is not allowed when the snakeLength > 1. Since the snake tail is
					//in the layoutDirection direction with head opposite to layoutDirection 
					//direction so accepting the layoutDirection direction key will crash 
					//the snake
					//For example, by default layoutDirection=Direction.right which means that
					//the snake is positioned from left->right with head in the left direction
					//so accepting the right key will crash the snake
					if(direction == Direction.none  &&  directionBufferQueue.IsEmpty()
					&& snakeLength > 1  &&  value == this.layoutDirection)
						return;

					directionBufferQueue.Push(value);									
				}
			}
		}

		//between 1(fastest)-16(slowest). Default=16
		internal int Speed
		{
			get
			{
				return this.speed;
			}
			set
			{
				if(value>=this.fastestGameSpeed  &&  value<=this.slowestGameSpeed  &&  
				value <= this.minimumPossibleSpeed)
				{
					this.speed = value;

					float timerValue;
					if(value < 10)
						timerValue = 0.1F + (value/10F);
					else
						timerValue = value - 8;

					this.timer1.Interval = Convert.ToInt32(timerValue*100);
					//timer's value=20 for speed=1//timer's value=30 for speed=2
					//timer's value=40 for speed=3//timer's value=100 for speed=9
					//timer's value=200 for speed=10//timer's value=300 for speed=11
					//timer's value=800 for speed=16
				}
			}
		}

		//returns the speed for the snake below which the snake cant decrease the speed anymore.
		internal int MinimumPossibleSpeed
		{
			get
			{
				return this.minimumPossibleSpeed;
			}
			set
			{
				if(value>=this.fastestGameSpeed && value<=this.slowestGameSpeed)
					this.minimumPossibleSpeed = value;
			}
		}

		//returns the default slowest speed allowed by the game
		internal int SlowestGameSpeed
		{
			get
			{
				return this.slowestGameSpeed;
			}
		}

		//returns the default fastest speed allowed by the game
		internal int FastestGameSpeed
		{
			get
			{
				return this.fastestGameSpeed;
			}
		}


		internal int ChancesLeft
		{
			get
			{
				return this.chancesLeft;
			}
			set
			{
				if(value >= 0  &&  value <= totalChances)
					this.chancesLeft = value;
			}
		}

		internal int TotalChances
		{
			get
			{
				return this.totalChances;
			}
			set
			{
				if(value >= 0  &&  value <= 100)
					this.totalChances = value;
			}
		}

		internal static int Size
		{
			get
			{
				return Snake.size;
			}
		}
		
		internal bool IsSnakeOut
		{
			get
			{
				return this.snakeOut;
			}
		}

		#endregion

		#region methods

		#region Constructors and Others Initialization Methods

		public Snake(SnakeGame parentForm)
		{
			InitializeDataMembers(parentForm, 200, 200, 
			System.Drawing.SystemColors.InactiveCaptionText, 20, 1, Direction.right, false);
		}

		public Snake(SnakeGame parentForm, System.Drawing.Color color)
		{
			InitializeDataMembers(parentForm, 200, 200, color, 20, 1, Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int maxSnakeLength)
		{
			InitializeDataMembers(parentForm, 200, 200, 
			System.Drawing.SystemColors.InactiveCaptionText, maxSnakeLength, 1, 
			Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int left, int top)
		{
			InitializeDataMembers(parentForm, left, top, 
			System.Drawing.SystemColors.InactiveCaptionText, 20, 1, Direction.right, false);
		}
        
		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color)
		{
			InitializeDataMembers(parentForm, left, top, color, 20, 1, Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, int maxSnakeLength)
		{
			InitializeDataMembers(parentForm, left, top, 
			System.Drawing.SystemColors.InactiveCaptionText, maxSnakeLength, 1, 
			Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, Direction layoutDirection)
		{
			InitializeDataMembers(parentForm, left, top, 
			System.Drawing.SystemColors.InactiveCaptionText, 20, 1, layoutDirection, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, int maxSnakeLength,
		Direction layoutDirection)
		{
			InitializeDataMembers(parentForm, left, top, 
			System.Drawing.SystemColors.InactiveCaptionText, maxSnakeLength, 1, 
			layoutDirection, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, int maxSnakeLength,
			int initialSnakeLength, Direction layoutDirection)
		{
			InitializeDataMembers(parentForm, left, top, 
			System.Drawing.SystemColors.InactiveCaptionText, maxSnakeLength, initialSnakeLength, 
			layoutDirection, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, int maxSnakeLength,
			int initialSnakeLength)
		{
			InitializeDataMembers(parentForm, left, top, 
				System.Drawing.SystemColors.InactiveCaptionText, maxSnakeLength, initialSnakeLength, 
				Direction.right, false);
		}


		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color,
			int maxSnakeLength)
		{
			InitializeDataMembers(parentForm, left, top, color, maxSnakeLength, 1, 
			Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color,
		int maxSnakeLength, Direction layoutDirection)
		{
			InitializeDataMembers(parentForm, left, top, color, maxSnakeLength, 1,
			layoutDirection, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color,
			int maxSnakeLength, int initialSnakeLength)
		{
			InitializeDataMembers(parentForm, left, top, color, maxSnakeLength, initialSnakeLength, 
				Direction.right, false);
		}

		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color,
		int maxSnakeLength, int initialSnakeLength, bool isAIHead)
		{
			InitializeDataMembers(parentForm, left, top, color, maxSnakeLength, initialSnakeLength, 
				Direction.right, isAIHead);
		}
		
		public Snake(SnakeGame parentForm, int left, int top, System.Drawing.Color color,
			int maxSnakeLength, int initialSnakeLength, Direction layoutDirection)
		{
			InitializeDataMembers(parentForm, left, top, color, maxSnakeLength, initialSnakeLength, 
			layoutDirection, false);
		}


		private void InitializeDataMembers(SnakeGame parentForm, int left, int top,
		System.Drawing.Color color, int maxSnakeLength, int initialSnakeLength, 
		Direction layoutDirection, bool isAIHead)
		{
			this.slowestGameSpeed = 16;
			this.fastestGameSpeed = 1;

			this.parentForm = parentForm;

			snakeStartLeft = left;
			snakeStartTop = top;		
			snakeBackColor = color;
			this.layoutDirection = layoutDirection;

			directionBufferSize = 4;
			directionBufferQueue = new Queue(directionBufferSize);
			direction = Direction.none;

			hi = 0;
			this.maxSnakeLength = maxSnakeLength;
			if(initialSnakeLength <= maxSnakeLength)
				this.snakeLength = initialSnakeLength;
			else
				this.snakeLength = maxSnakeLength;

			ti = initialSnakeLength - 1;


			//size = 10;

			this.snake = new System.Windows.Forms.Label[maxSnakeLength];
			for(int i=0; i<this.snakeLength; i++)
			{
				if(this.layoutDirection == Direction.right)
					this.InitializeHead(i, snakeStartLeft+(i*size), snakeStartTop);	
				else if(this.layoutDirection == Direction.left)
					this.InitializeHead(i, snakeStartLeft-(i*size), snakeStartTop);	
				else if(this.layoutDirection == Direction.down)
					this.InitializeHead(i, snakeStartLeft, snakeStartTop+(i*size));	
				else if(this.layoutDirection == Direction.up)
					this.InitializeHead(i, snakeStartLeft, snakeStartTop-(i*size));	
			}
			
			this.timer1 = new System.Windows.Forms.Timer();
			this.timer1.Enabled = false;	
			this.snakeOut = false;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			
			defaultSpeed = 16;
			this.Speed = defaultSpeed;
			this.minimumPossibleSpeed = defaultSpeed;
			//this.timer1.Interval = Convert.ToInt32(speed*100);			

			this.isAIEnabledHead = isAIHead;
			if(this.isAIEnabledHead == false)
			{
				Snake.totalPlayers++;
				playerNumber = totalPlayers;
				this.snake[0].Text = "+";			
			}
			else
			{
				playerNumber = 420;
				this.currentAImoves = 0;
				this.movesBeforeAIDirectionChange = 10;
			}

			totalChances = 3;
			chancesLeft = 3;

			Snake.headToHeadCrashed  = false;
			Snake.headToHeadCallerPlayerNumber = -1;
		}

		private void InitializeHead(int headNumber)
		{
			this.snake[headNumber] = new System.Windows.Forms.Label();
			this.snake[headNumber].Text = "";
			this.snake[headNumber].Visible = false;
			this.snake[headNumber].Width = size;
			this.snake[headNumber].Height = size;
			this.snake[headNumber].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.snake[headNumber].BackColor = snakeBackColor;				
			this.snake[headNumber].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.parentForm.Controls.Add(snake[headNumber]);	
		}
		
		private void InitializeHead(int headNumber, int left, int top)
		{
			 this.snake[headNumber] = new System.Windows.Forms.Label();
			 this.snake[headNumber].Text = "";
			 //this.snake[headNumber].Visible = false;
			 this.snake[headNumber].Width = size;
			 this.snake[headNumber].Height = size;
			 this.snake[headNumber].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			 this.snake[headNumber].BackColor = snakeBackColor;				
			 this.snake[headNumber].Left = left;//+(headNumber*size);
			 this.snake[headNumber].Top = top;
			 this.snake[headNumber].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			 this.parentForm.Controls.Add(snake[headNumber]);	
		 }
		#endregion

		#region Other Methods

		#region Snake Movement Related Methods

		internal void Move()
		{
			Direction tempDirection = directionBufferQueue.Pop();			
			if(tempDirection != Direction.unassigned)
			{
				bool directionValid = true;
				if(snakeLength > 1)//direction opposite to current direction is not allowed
				{
					if((direction == Direction.left  &&  tempDirection == Direction.right)
					||(direction == Direction.right  &&  tempDirection == Direction.left)
					||(direction == Direction.up  &&  tempDirection == Direction.down)
					||(direction == Direction.down  &&  tempDirection == Direction.up))
						directionValid = false;
				}
	
				if(directionValid == true)
					direction = tempDirection;
			}
			
			snake[ti].Visible = false;//newly added for avoiding flickering

			if(direction == Direction.left)
				MoveLeft();
			else if(direction == Direction.right)
				MoveRight();
			else if(direction == Direction.up)
				MoveUp();
			else if(direction == Direction.down)
				MoveDown();

			snake[ti].Visible = true;//newly added for avoiding flickering
			UpdateIndex();			
		}


		private void MoveLeft()
		{
			snake[ti].Left = snake[hi].Left - size;
			snake[ti].Top = snake[hi].Top;
		}

		private void MoveRight()
		{
			snake[ti].Left = snake[hi].Left + size;
			snake[ti].Top = snake[hi].Top;
		}

		private void MoveUp()
		{
			snake[ti].Left = snake[hi].Left;
			snake[ti].Top = snake[hi].Top - size ;
		}

		private void MoveDown()
		{
			snake[ti].Left = snake[hi].Left;
			snake[ti].Top = snake[hi].Top + size;
		}

		
		private void UpdateIndex()
		{
			snake[hi].Text = "";
			hi = ti;

			if(this.isAIEnabledHead == false)
				snake[hi].Text = "+";

			if(ti == 0)
				ti = snakeLength-1;
			else
				ti -= 1;
		}


		#endregion

		#region monitor movement mehods

		private void timer1_Tick(object sender, System.EventArgs e)
		{	
			if(this.isAIEnabledHead == true)
			{				
				if(this.currentAImoves % this.movesBeforeAIDirectionChange == 0)
				{
					if(this.currentAImoves == this.movesBeforeAIDirectionChange)
						this.currentAImoves = 0;
					else
						this.currentAImoves++;

					SetDirectionForAIEnabledHead();
				}
				else
				{
					this.currentAImoves++;
					bool isAIDirectionCorrect = false;

					while(isAIDirectionCorrect == false)
					{
						isAIDirectionCorrect = this.CheckAIDirectionCorrect(this.direction);
						if(isAIDirectionCorrect == false)
							this.direction = this.GetAlternateSuggestedDirection(this.direction);
					}			
				}
			}

			if(this.MovementDirection != Direction.none)
				this.Move();
			
			if(this.isAIEnabledHead != true)
				MonitorMovement();			
		}


		private void MonitorMovement()
		{	
			if(CheckBorderCrash() == true  ||  CheckSelfCrash() == true  
				||  CheckCrashWithOtherPlayers() == true  ||  CheckMazeCrash() == true)
			{					
				this.timer1.Enabled = false;
				this.chancesLeft -= 1;
				this.parentForm.SnakeCrashed(this.playerNumber);	
				return;
			}

			if(CheckHeadCatch() == true)
			{					
				AddHead();					
				this.parentForm.HeadCatched(this.playerNumber);
			}			
		}


		private bool CheckHeadCatch()
		{				
			if(snake[hi].Bounds == this.parentForm.GetNewHeadBounds())				
				return true;
			
			return false;				
		}


		private bool CheckBorderCrash()
		{			
			//if(snakeOut == true)
			//	return false;

			System.Drawing.Rectangle headPos = snake[hi].Bounds;
			System.Drawing.Rectangle borderArea = this.parentForm.GetGameAreaBounds();
			
			if(headPos.Left < borderArea.Left  ||  headPos.Right > borderArea.Right  ||
				headPos.Top < borderArea.Top  ||  headPos.Bottom > borderArea.Bottom)				
				return true;
			
			return false;				
		}


		private bool CheckSelfCrash()
		{
			for(int i=0; i<snakeLength; i++)
				if(hi != i)
					if(snake[hi].Bounds == snake[i].Bounds)				
						return true;
			
			return false;				
		}


		private bool CheckCrashWithOtherPlayers()
		{
			if(this.parentForm.NumberOfPlayers == 1)
				return false;

			Snake[] allSnakes = this.parentForm.GetAllSnakes();
			for(int i=0; i<this.parentForm.NumberOfPlayers; i++)
				if(allSnakes[i] != null  &&  allSnakes[i].playerNumber != this.playerNumber)
					for(int j=0; j<allSnakes[i].snakeLength; j++)
						if(this.snake[hi].Bounds == allSnakes[i].snake[j].Bounds)//crash occured
						{
							//Check for Head to head Crash
							if(allSnakes[i].snake[allSnakes[i].hi].Bounds == this.snake[hi].Bounds)
							{
								if(allSnakes[i].IsSnakeMoving() == true)
								{
									allSnakes[i].timer1.Enabled = false;
									allSnakes[i].chancesLeft -= 1;
									Snake.headToHeadCrashed = true;
									Snake.headToHeadCallerPlayerNumber = this.playerNumber;
									parentForm.SnakeCrashed(allSnakes[i].playerNumber);				
								}
							}

							return true;				
						}
			
			return false;
		}


		private bool CheckMazeCrash()
		{
			Maze maze = this.parentForm.GetMaze();
			return !(maze.IsHeadPositionCorrect(this.snake[hi].Location));			
		}


		#endregion

		#region AI Movement Related Methods

		private void SetSuggestedAIDirectionWRTPlayer(Snake player)
		{		
			//Direction suggestedDirection = Direction.none;
			int xDistanceMagnitude, yDistanceMagnitude;

			int xDistance = player.snake[hi].Left - this.snake[hi].Left;
			xDistanceMagnitude = xDistance;
			if(xDistance < 0)
				xDistanceMagnitude *= -1;

			int yDistance = player.snake[hi].Top - this.snake[hi].Top;
			yDistanceMagnitude = yDistance;
			if(yDistance < 0)
				yDistanceMagnitude *= -1;

			//System.Windows.Forms.MessageBox.Show(xDistance +":"+ yDistance);
			//compare xDistanceMagnitude to yDistanceMagnitude. See which one is lesser.
			//So the snake is closer to the player's head in the direction with lesser
			//distance magnitude. Hence the distance of this head from player's head should
			//be increased in that direction.

			if(xDistanceMagnitude < yDistanceMagnitude)
			{//this head is closer horizontally to the player's head, so increase horizontal
				//distance.

				if(xDistance > 0)//player's head is towards right of this head
					this.suggestedAIDirection = Direction.left;//move this head to left
				else if(xDistance < 0)//player's head is towards left of this head
					this.suggestedAIDirection = Direction.right;//move this head to right
				else if(xDistance == 0)//player's head and this head have same Left
				{
					//move this head to the opposite direction of player's head

					if(player.MovementDirection == Direction.left)
						this.suggestedAIDirection = Direction.right;
					else if(player.MovementDirection == Direction.right)
						this.suggestedAIDirection = Direction.left;
					else
						this.suggestedAIDirection = Direction.right;
				}
			}
			else if(xDistanceMagnitude > yDistanceMagnitude 
				||  xDistanceMagnitude == yDistanceMagnitude)
			{//this head is closer vertically to the player's head, so increase vertical distance
				 
				//Also deals the case when this head is equally closer in both vertical and 
				//horizontal direction to the player's head, so by default, increase vertical 
				//distance

				if(yDistance > 0)//player's head is in down direction of this head
					this.suggestedAIDirection = Direction.up;//move this head upwards
				else if(yDistance < 0)//player's head is in up direction of this head
					this.suggestedAIDirection = Direction.down;//move this head downwards
				else if(yDistance == 0)//player's head and this head have same Top
				{
					//move this head to the opposite direction of player's head

					if(player.MovementDirection == Direction.up)
						this.suggestedAIDirection = Direction.down;
					else if(player.MovementDirection == Direction.down)
						this.suggestedAIDirection = Direction.up;
					else
						this.suggestedAIDirection = Direction.down;
				}
			}			
		}


		private bool CheckAIDirectionCorrect(Direction headDirection)
		{//returns false if the direction is not correct and causes a crash

			System.Drawing.Point actualHeadLocation = this.snake[hi].Location;

			//assign new position to player's head temporarily according to suggested direction
			if(headDirection == Direction.left)
				this.snake[hi].Left -= Snake.size;
			else if(headDirection == Direction.right)
				this.snake[hi].Left += Snake.size;
			else if(headDirection == Direction.up)
				this.snake[hi].Top -= Snake.size;
			else if(headDirection == Direction.down)
				this.snake[hi].Top += Snake.size;

			bool isCrashed = false;
			if(this.CheckBorderCrash() == true  ||  this.CheckMazeCrash() == true
			||  this.CheckAICrashWithOtherPlayers() == true)
				isCrashed = true;

			this.snake[hi].Location = actualHeadLocation;//reset actual location of player's head
			return !isCrashed;
		}

		private bool CheckAICrashWithOtherPlayers()
		{
			Snake[] allSnakes = this.parentForm.GetAllSnakes();
			for(int i=0; i<this.parentForm.NumberOfPlayers; i++)
				if(allSnakes[i] != null)
					for(int j=0; j<allSnakes[i].snakeLength; j++)
						if(this.snake[hi].Bounds == allSnakes[i].snake[j].Bounds)//crash occured
							return true;										
			
			return false;
		}


		private Direction GetAlternateSuggestedDirection(Direction headDirection)
		{//This method is to be called when the suggested direction of the head set by the method
		 //SetDirectionWRTPlayer causes a border crash detected by the CheckAIHeadBorderCrash
		 //method. So the suggested direction needs to be changed.

		 //Here headDirection parameter represents the wrongly suggested direction with reference
		 //to which the alternate direction will be created.

			//a random new direction will be created now.
			//random nos. correspond to directions as follows:
			//left = 0
			//right = 1
			//up = 2
			//down = 3

			int code = -1;
			if(headDirection == Direction.left)
				code = 0;
			else if(headDirection == Direction.right)
				code = 1;
			else if(headDirection == Direction.up)
				code = 2;
			else if(headDirection == Direction.down)
				code = 3;

			System.Random rand = new Random();
			int newDirectionCode = code;
			while(newDirectionCode == code)
			{
				newDirectionCode = rand.Next(0,4);
			}

			Direction alternateDirection = Direction.none;

			if(newDirectionCode == 0)
				alternateDirection = Direction.left;
			else if(newDirectionCode == 1)
				alternateDirection = Direction.right;
			else if(newDirectionCode == 2)
				alternateDirection = Direction.up;
			else if(newDirectionCode == 3)
				alternateDirection = Direction.down;

			return alternateDirection;
		}

		private double GetDistanceFromPlayer(int playerHeadLeft, int playerHeadTop)
		{			
			double xDistanceSquare = System.Math.Pow(playerHeadLeft-this.snake[hi].Left, 2);
			double yDistanceSquare = System.Math.Pow(playerHeadTop-this.snake[hi].Top, 2);
			return System.Math.Sqrt(xDistanceSquare + yDistanceSquare);
		}

		private void SetDirectionForAIEnabledHead()
		{
			Snake[] allSnakes = this.parentForm.GetAllSnakes();
			Snake closestSnake = allSnakes[0];

			if(this.parentForm.NumberOfPlayers >= 1)
			{
				double closestDistance = 9999;
				int closestSnakeNumber = -1;

				for(int i=0; i<this.parentForm.NumberOfPlayers; i++)
					if(allSnakes[i] != null)
					{
						double tempClosestDistance = GetDistanceFromPlayer(allSnakes[i].snake[hi].Left,
						allSnakes[i].snake[hi].Top);
						
						if(tempClosestDistance < closestDistance)
						{
							closestDistance = tempClosestDistance;
							closestSnakeNumber = i;
						}
					}

				closestSnake = allSnakes[closestSnakeNumber];
			}
			
			this.SetSuggestedAIDirectionWRTPlayer(closestSnake);
			bool isAIDirectionCorrect = false;

			while(isAIDirectionCorrect == false)
			{
				isAIDirectionCorrect = this.CheckAIDirectionCorrect(this.suggestedAIDirection);
				if(isAIDirectionCorrect == false)
					this.suggestedAIDirection = this.GetAlternateSuggestedDirection(this.suggestedAIDirection);
			}			

			this.direction = this.suggestedAIDirection;			
		}
		#endregion

		internal System.Drawing.Rectangle GetHeadPosition()
		{
			return snake[hi].Bounds;
		}


		internal void Dispose()
		{			
			for(int i=0; i<this.snakeLength; i++)
			{
				this.parentForm.Controls.Remove(this.snake[i]);
				this.snake[i].Dispose();
			}

			this.timer1.Dispose();	

			if(this.isAIEnabledHead == false)
				Snake.totalPlayers --;				
		}


		internal void SnakeOut()
		{
			for(int i=0; i<this.snakeLength; i++)
			{
				this.snake[i].Visible = false;
				this.snake[i].Left = -10;
				this.snake[i].Top = -10;				
			}

			this.MoveSnake = false;
			this.snakeOut = true;
			this.directionBufferQueue.Clear();
			this.direction = Direction.none;
		}


		internal bool IsSnakeMoving()
		{
			if(this.direction == Direction.none  
				&&  this.directionBufferQueue.IsEmpty() == true)
				return false;

			return true;
		}


		//changes the position of label at "index1" to that present at "index2"
		private void SwapPosition(int index1, int index2)
		{
			int headTop = snake[index1].Top;
			int headLeft = snake[index1].Left;
			snake[index1].Top = snake[index2].Top;
			snake[index1].Left = snake[index2].Left;
			snake[index2].Top = headTop;
			snake[index2].Left = headLeft;			
		}


		internal void AddHead()
		{		
			snakeLength++;
			this.InitializeHead(snakeLength-1);
			
			if(direction == Direction.left  ||  direction == Direction.right)
			{
				if(direction == Direction.left)
					snake[snakeLength-1].Left = snake[ti].Left + size;
				else
					snake[snakeLength-1].Left = snake[ti].Left - size;

				snake[snakeLength-1].Top = snake[ti].Top;

				if(hi != 0)
				{
					int current = ti;
					while(current != 0)
					{
						this.SwapPosition(current, snakeLength-1);
						current -= 1;
					}					
					this.SwapPosition(current, snakeLength-1);
				}	
				else
					ti = snakeLength-1;
			}			
			else if(direction == Direction.up  ||  direction == Direction.down)
			{			

				if(direction == Direction.up)
					snake[snakeLength-1].Top = snake[ti].Top + size;
				else
					snake[snakeLength-1].Top = snake[ti].Top - size;

				snake[snakeLength-1].Left = snake[ti].Left;

				if(hi != 0)
				{
					int current = ti;
					while(current != 0)
					{
						this.SwapPosition(current, snakeLength-1);
						current -= 1;
					}					
					this.SwapPosition(current, snakeLength-1);
				}	
				else
					ti = snakeLength-1;
			}
						
			snake[snakeLength-1].Visible = true;					
		}


		internal void ResetSnake()
		{
			this.direction = Direction.none;
			this.directionBufferQueue.Clear();

			for(int i=0; i<snakeLength; i++)
			{
				if(this.layoutDirection == Direction.right)
				{
					this.snake[i].Left = snakeStartLeft+(i*size);
					this.snake[i].Top = snakeStartTop;
				}
				else if(this.layoutDirection == Direction.left)
				{
					this.snake[i].Left = snakeStartLeft-(i*size);
					this.snake[i].Top = snakeStartTop;					
				}
				else if(this.layoutDirection == Direction.down)
				{
					this.snake[i].Left = snakeStartLeft;
					this.snake[i].Top = snakeStartTop+(i*size);					
				}
				else if(this.layoutDirection == Direction.up)
				{
					this.snake[i].Left = snakeStartLeft;
					this.snake[i].Top = snakeStartTop-(i*size);					
				}

				this.snake[i].Text = "";
			}

			if(this.isAIEnabledHead == false)
				this.snake[0].Text = "+";

			this.Speed = this.minimumPossibleSpeed;
			hi = 0;
			ti = snakeLength-1;
			this.MoveSnake = true;

			Snake.headToHeadCrashed = false;
		}		


		internal bool IsNewHeadPositionCorrect(System.Drawing.Point newLoc)
		{
			int minDistanceAllowed = 20;

			int xDifference, yDifference;
			for(int i=0; i<snakeLength; i++)
			{
				xDifference = snake[i].Location.X - newLoc.X;
				if(xDifference < 0)
					xDifference *= -1;
				if(xDifference < minDistanceAllowed)
					return false;

				yDifference = snake[i].Location.Y - newLoc.Y;
				if(yDifference < 0)
					yDifference *= -1;
				if(yDifference < minDistanceAllowed)
					return false;
			}

			return true;
		}

		#endregion

		#endregion
	}	
}
