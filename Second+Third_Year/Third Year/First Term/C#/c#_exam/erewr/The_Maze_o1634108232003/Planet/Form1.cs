using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace The_Maze_of_the_Gems
{
	
	public class MazeController                 ///Contains static functions that control the game
	{
		private static bool Ready;
		private static int Ball_x;
		private static int Ball_y;
		private static Bitmap Rock;
		private static Bitmap BallPicture;
		private static Bitmap Gem;
		private static Bitmap Teleport;
		private static Bitmap Exit;
		private static Bitmap FireHole;
		private static Bitmap Fire;
		private static Bitmap BackGround;
		private static Bitmap Spikes;
		private const int LENGTH=30;
		private const int LOOP_LIMIT=400;
		private const int STEP=6;
		private const int MAXJUMP=70;
		private const char SymFree='0';
		private const char SymRock='1';
		private const char SymSpikes='3';
		private const char SymGem='4';
		private const char SymFireHole='6';
		private const char SymFire='7';
		private const char SymStart='9';
		private const char SymExit='8';
		private const char MinSymTele='A';
		private const char MaxSymTele='Z';
		private static int Maze,                ///Holds maze number
			CameraX,CameraY;   ///Hold the location of the top left corner of the screen
		private static PictureBox Pic1,Pic10,PicGem1,PicGem10,PicGame; ///Interface pictures that refer to pictures in the main form
		private static bool PictureFlag;
		private static bool LeftFlag;
		private static bool RightFlag;
		private static bool JumpFlag;
		private static int JumpCounter;
		private static int gems;
		private static bool Exit_Flag;
		public static char[,] Block;            ///Holds Maze Data
		public static bool LeftKeyFlag
		{
			set
			{
				LeftFlag=value;
			}
		}
		public static bool RightKeyFlag
		{
			set
			{
				RightFlag=value;
			}
		}
		public static bool BallJumpFlag
		{
			set
			{
				if(value)
				{if(Ball_y%LENGTH==0 && !JumpFlag && Ball_y>0)
				  
						if(Available(Block[Ball_x/LENGTH,Ball_y/LENGTH-1]) && Ball_x%LENGTH==0 || Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH-1]))
							if(!Available(Block[Ball_x/LENGTH,Ball_y/LENGTH+1]) || Ball_x%LENGTH>0 && !Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]))
							{
								JumpFlag=true;
								JumpCounter=0;
							}
				}
				else
					JumpFlag=false;
			}
		}
		private static bool Exit_Ability_Flag
		{
			get
			{
				return Exit_Flag; 
			}
			set
			{
				Exit_Flag=value;
				Exit.Dispose();
				Exit=new Bitmap(Dir.ImageDir+(value ?"Exit" :"ExitClosed")+".bmp");
			}
		}
		public static int GemCount
		{
			get
			{
				return gems;
			}
			set
			{
				gems=value;
				PicGem1.Image=Image.FromFile(Dir.ImageDir+gems%10+".gif");
				PicGem10.Image=Image.FromFile(Dir.ImageDir+gems/10+".gif");
				Exit_Ability_Flag=(value==0);
			}
		}
		private static bool Available(char TestBlock)
		{
			switch(TestBlock)
			{
				case SymRock:
				   return false;
				   break;
				default:
					return true;
			}
		}
		private static bool TeleportCheck(char TestBlock)
		{
			return(TestBlock>=MinSymTele && TestBlock<=MaxSymTele);
		}
		private static bool Death(char TestBlock)
		{
			return(TestBlock==SymSpikes || TestBlock==SymFire);
		}
		public static void SetInterfaceObjects(PictureBox OutPic1,PictureBox OutPic10,PictureBox GemNumPic1,PictureBox GemNumPic10,PictureBox GameArea)
		{
			PicGame=GameArea;
			Pic1=OutPic1;
			Pic10=OutPic10;
			PicGem1=GemNumPic1;
			PicGem10=GemNumPic10;
		}
        
		public static void InitializeGraphics()
		{
			///Set Patterns
			Size PicSize=new Size(LENGTH,LENGTH);
			Rock=new Bitmap(Dir.ImageDir+"Rock.bmp");
			BackGround=new Bitmap(Dir.ImageDir+"Back.bmp");
			Spikes=new Bitmap(Dir.ImageDir+"Spikes.bmp");
			Gem=new Bitmap(Dir.ImageDir+"Gem.bmp");
			Teleport=new Bitmap(Dir.ImageDir+"Teleport1.bmp");
			BallPicture=new Bitmap(Dir.ImageDir+"Ball.bmp");
			Exit=new Bitmap(Dir.ImageDir+"ExitClosed.bmp");
			FireHole=new Bitmap(Dir.ImageDir+"FireHole.bmp");
			Fire=new Bitmap(Dir.ImageDir+"Fire2.bmp");
		}
		public static int CurrentMaze           ///Property asoociated with the variable Maze
		{
			get
			{
				return Maze;
			}
		}  
		private static void NewMaze()
		{
			Maze++;
			if(File.Exists(Dir.MazeDir+"maze"+Maze+".txt"))
			{
				Pic10.Image=Image.FromFile(Dir.ImageDir+Maze/10+".gif");
				Pic1.Image=Image.FromFile(Dir.ImageDir+Maze%10+".gif");
				MazeController.Block=MazeLoader.LoadMaze(Maze);
				for(int y=0;y<=MazeLoader.xmax;y++)
				{
					for(int x=0;x<=MazeLoader.xmax;x++)
					{
						if(Block[x,y]==SymStart)
						{
							///Set CameraX
							if(x<4) 
								CameraX=0;
							else if(x>MazeLoader.xmax-5)
								CameraX=(MazeLoader.xmax-9)*LENGTH;
							else
								CameraX=(x-4)*LENGTH;
							///Set CameraY
							if(y<4) 
								CameraY=0;
							else if(y>MazeLoader.ymax-5)
								CameraY=(MazeLoader.ymax-9)*LENGTH;
							else
								CameraY=(y-4)*LENGTH;
							///Put Ball
							Ball_x=x*LENGTH;
							Ball_y=y*LENGTH;
							break;
						}
					}
					
				}
				
				Ready=true;
				JumpFlag=RightFlag=LeftFlag=false;
				ManageGame();
			}
			else
			{
				MessageBox.Show("You defeated the game !!!","Congratulations !!!");
				NewGame();
			}
		}
		public static void NewGame()
		{
			Maze=0;	
			NewMaze();
		}
		public static void Paint(Graphics GraphicsObject)
		{
			if(Ready)
			{
				Graphics Graph=GraphicsObject;
				Graph.Clear(Color.White);
				int xlimit=(CameraX/LENGTH+9==MazeLoader.xmax) ?CameraX/LENGTH+9 :CameraX/LENGTH+10;
				int ylimit=(CameraY/LENGTH+9==MazeLoader.ymax) ?CameraY/LENGTH+9 :CameraY/LENGTH+10;
				for(int y=CameraY/LENGTH;y<=ylimit;y++)
				{
					for(int x=CameraX/LENGTH;x<=xlimit;x++)
					{
						switch(Block[x,y])
						{
							case SymRock:
								Graph.DrawImage(Rock,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							case SymSpikes:
								Graph.DrawImage(Spikes,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							case SymGem:
								Graph.DrawImage(Gem,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							case SymExit:
								Graph.DrawImage(Exit,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							case SymFireHole:
								Graph.DrawImage(FireHole,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							case SymFire:
								Graph.DrawImage(Fire,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
							default:
								if(TeleportCheck(Block[x,y]))
									Graph.DrawImage(Teleport,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								else
									Graph.DrawImage(BackGround,LENGTH*(x-CameraX/LENGTH)-CameraX%LENGTH,LENGTH*(y-CameraY/LENGTH)-CameraY%LENGTH,LENGTH,LENGTH);
								break;
						}
						Graph.DrawImage(BallPicture,Ball_x-CameraX,Ball_y-CameraY,LENGTH,LENGTH);
						
					}
				}
				
			}
			
		}
		
		public static void ManageGame()
		{
			bool dummy=true;
			while(dummy)
			{
				///Respond To Outer Events
				Application.DoEvents();
				///Manage Left Movement
				if(LeftFlag && Ball_x>0)
				{
					if(Ball_x%LENGTH!=0)
						Ball_x-=STEP;
					else if(!Available(Block[Ball_x/LENGTH-1,Ball_y/LENGTH]))
						;///Null Statement
					else if(Ball_y%LENGTH>0 && !Available(Block[Ball_x/LENGTH-1,Ball_y/LENGTH+1]))
						;///Null Statement
					else
						Ball_x-=STEP;
				}
				///Manage Right Movement
				if(RightFlag && (Ball_x/LENGTH)<MazeLoader.xmax)
				{
					if(Ball_x%LENGTH!=0)
						Ball_x+=STEP;
					else if(!Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH]))
						;///Null Statement
					else if(Ball_y%LENGTH>0  && !Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]))
						;///Null Statement
					else
						Ball_x+=STEP;
				}
				///Manage Falling
				if(!JumpFlag && Ball_y/LENGTH<MazeLoader.ymax)
					if(Available(Block[Ball_x/LENGTH,Ball_y/LENGTH+1]))
						if(!(Ball_x%LENGTH>0 && !Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1])))
							Ball_y+=STEP;
				///Manage Jumping
				if(JumpFlag)
				{
					if(Ball_y%LENGTH>0 || (Ball_y>0 && Available(Block[Ball_x/LENGTH,Ball_y/LENGTH-1]) && !(Ball_x%LENGTH>0 && !Available(Block[Ball_x/LENGTH+1,Ball_y/LENGTH-1]))))
					{
						Ball_y-=STEP;
						JumpCounter+=STEP;
						if(JumpCounter>=MAXJUMP)
						{
							BallJumpFlag=false;
						}
					}
					else
						BallJumpFlag=false;
				}
				///Manage Teleport
				char TeleportTarget=' ';
				bool TeleportFlag=false;
				if(Ball_x%LENGTH<=12 && Ball_y%LENGTH<=12 && TeleportCheck(Block[Ball_x/LENGTH,Ball_y/LENGTH]))
				{
					TeleportTarget=Block[Ball_x/LENGTH,Ball_y/LENGTH].ToString().ToLower().Trim().ToCharArray()[0];
					TeleportFlag=true;
				}
				if(Ball_x%LENGTH>12 && Ball_y%LENGTH<=12 && TeleportCheck(Block[Ball_x/LENGTH+1,Ball_y/LENGTH]))
				{
					TeleportTarget=Block[Ball_x/LENGTH+1,Ball_y/LENGTH].ToString().ToLower().Trim().ToCharArray()[0];
					TeleportFlag=true;
				}
				if(Ball_x%LENGTH<=12 && Ball_y%LENGTH>12 && TeleportCheck(Block[Ball_x/LENGTH,Ball_y/LENGTH+1]))
				{
					TeleportTarget=Block[Ball_x/LENGTH,Ball_y/LENGTH+1].ToString().ToLower().Trim().ToCharArray()[0];
					TeleportFlag=true;
				}
				if(Ball_x%LENGTH>12 && Ball_y%LENGTH>12 && TeleportCheck(Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]))
				{
					TeleportTarget=Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1].ToString().ToLower().Trim().ToCharArray()[0];
					TeleportFlag=true;
				}
				if(TeleportFlag)
				{
					for(int y=0;y<=MazeLoader.ymax;y++)
						for(int x=0;x<=MazeLoader.xmax;x++)
							if(Block[x,y]==TeleportTarget)
							{
								///Set CameraX
								if(x<4) 
									CameraX=0;
								else if(x>MazeLoader.xmax-5)
									CameraX=(MazeLoader.xmax-9)*LENGTH;
								else
									CameraX=(x-4)*LENGTH;
								///Set CameraY
								if(y<4) 
									CameraY=0;
								else if(y>MazeLoader.ymax-5)
									CameraY=(MazeLoader.ymax-9)*LENGTH;
								else
									CameraY=(y-4)*LENGTH;
								///Put Ball
								Ball_x=x*LENGTH;
								Ball_y=y*LENGTH;
								break;
							}
								
				}
				///Manage Gems
				if(Ball_x%LENGTH<=12 && Ball_y%LENGTH<=12 && Block[Ball_x/LENGTH,Ball_y/LENGTH]==SymGem)
				{
					Block[Ball_x/LENGTH,Ball_y/LENGTH]=SymFree;
					GemCount--;
				}
				if(Ball_x%LENGTH>=18 && Ball_y%LENGTH<=12 && Block[Ball_x/LENGTH+1,Ball_y/LENGTH]==SymGem)
				{
					Block[Ball_x/LENGTH+1,Ball_y/LENGTH]=SymFree;
					GemCount--;
				}
				if(Ball_x%LENGTH<=12 && Ball_y%LENGTH>=18 && Block[Ball_x/LENGTH,Ball_y/LENGTH+1]==SymGem)
				{
					Block[Ball_x/LENGTH,Ball_y/LENGTH+1]=SymFree;
					GemCount--;
				}
				if(Ball_x%LENGTH>=18 && Ball_y%LENGTH>=18 && Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]==SymGem)
				{
					Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]=SymFree;
					GemCount--;
				}
				///Manage Exit
				if(Exit_Flag)
				{
						bool Leave=false;
					if(Ball_x%LENGTH<=12 && Ball_y%LENGTH<=12 && Block[Ball_x/LENGTH,Ball_y/LENGTH]=='8')
						Leave=true;
					if(Ball_x%LENGTH>=18 && Ball_y%LENGTH<=12 && Block[Ball_x/LENGTH+1,Ball_y/LENGTH]=='8')
						Leave=true;
					if(Ball_x%LENGTH<=12 && Ball_y%LENGTH>=18 && Block[Ball_x/LENGTH,Ball_y/LENGTH+1]=='8')
						Leave=true;
					if(Ball_x%LENGTH>=18 && Ball_y%LENGTH>=18 && Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]=='8')
						Leave=true;
					if(Leave)
					{
						NewMaze();
					}
				}
				///Manage Spikes & Fire
				bool Die=false;
				if(Ball_x%LENGTH<=18 && Ball_y%LENGTH<=18 && Death(Block[Ball_x/LENGTH,Ball_y/LENGTH]))
					Die=true;
				if(Ball_x%LENGTH>=12 && Ball_y%LENGTH<=18 && Death(Block[Ball_x/LENGTH+1,Ball_y/LENGTH]))
					Die=true;
				if(Ball_x%LENGTH<=18 && Ball_y%LENGTH>=12 && Death(Block[Ball_x/LENGTH,Ball_y/LENGTH+1]))
					Die=true;
				if(Ball_x%LENGTH>=18 && Ball_y%LENGTH>=12 && Death(Block[Ball_x/LENGTH+1,Ball_y/LENGTH+1]))
					Die=true;
				if(Die)
				{
					MessageBox.Show("Gotta Be More Careful !!!","You're Dead");
					Maze--;
					NewMaze();
				}
				///Set CameraX
				if(Ball_x<2*LENGTH) 
					CameraX=0;
				else if(Ball_x>(MazeLoader.xmax-2)*LENGTH)
					CameraX=(MazeLoader.xmax-9)*LENGTH;
				else if(Ball_x<CameraX+2*LENGTH)
                    CameraX=Ball_x-2*LENGTH;
				else if(Ball_x>CameraX+7*LENGTH)
					CameraX=Ball_x-7*LENGTH;
				///Set CameraY
				if(Ball_y<2*LENGTH) 
					CameraY=0;
				else if(Ball_y>(MazeLoader.ymax-2)*LENGTH)
					CameraY=(MazeLoader.ymax-9)*LENGTH;
				else if(Ball_y<CameraY+2*LENGTH)
                    CameraY=Ball_y-2*LENGTH;
				else if(Ball_y>CameraY+7*LENGTH)
					CameraY=Ball_y-7*LENGTH;
				PicGame.Invalidate();
			}
		}
		public static void ExchangePictures()
		{
			Gem.Dispose();
			Teleport.Dispose();
			Fire.Dispose();
			if(PictureFlag)
			{
				Gem=new Bitmap(Dir.ImageDir+"gem.bmp");
				Teleport=new Bitmap(Dir.ImageDir+"Teleport1.bmp");
				Fire=new Bitmap(Dir.ImageDir+"Fire.bmp");
			}
			else
			{
				Gem=new Bitmap(Dir.ImageDir+"gem2.bmp");
				Teleport=new Bitmap(Dir.ImageDir+"Teleport2.bmp");
				Fire=new Bitmap(Dir.ImageDir+"Fire2.bmp");
			}
			PictureFlag=!PictureFlag;
		}
		public static void ControlFire()
		{
			if(Ready)
			{
				for(int y=0;y<=MazeLoader.ymax;y++)
					for(int x=0;x<=MazeLoader.xmax;x++)
						if(Block[x,y]==SymFire)
							Block[x,y]=SymFireHole;
						else if(Block[x,y]==SymFireHole)
							Block[x,y]=SymFire;
			}
		}
	}
	/// <summary>
		/// This Class determines the location of required directories                    
	/// </summary>
	public class Dir  
                           
	{
		public static string ImageDir
		{
				get
		 {return Directory.GetCurrentDirectory()+"\\Images\\";}			
		}
		public static string MazeDir
		{
				get
		  {return Directory.GetCurrentDirectory()+"\\Mazes\\";}
		}
	}
	/// <summary>
	/// This Class loads maze data from the file                    
	/// </summary>
	public class MazeLoader
	{
		private static int x_max,y_max,gems;
		public static int gemcount
		{
			get
			{
				return gems;
			}
		}
		public static int xmax
		{
			get
			{
				return x_max;
			}
		}
		public static int ymax
		{
			get
			{
				return y_max;
			}
		}
		public static char[,] LoadMaze(int Maze)
				{
					gems=0;
					int x,y;
					char[,] Block;
					char[] LineBuffer;
					StreamReader BlockReader=new StreamReader(Dir.MazeDir+"Maze"+Maze+".txt");
					x_max=Int32.Parse(BlockReader.ReadLine());
					y_max=Int32.Parse(BlockReader.ReadLine());
					Block=new char[x_max+1,y_max+1];
					LineBuffer=new char[x_max+1];
					for(y=0;y<=y_max;y++)
					{
						LineBuffer=BlockReader.ReadLine().ToCharArray();
						for(x=0;x<=x_max;x++)
						{
							Block[x,y]=LineBuffer[x];
							if(Block[x,y]=='4')
								gems++;
						}
					}
					BlockReader.Close();
					MazeController.GemCount=gems;
					return Block;
				}
	}
	
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu MenuFile;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem ItemNew;
		private System.Windows.Forms.MenuItem ItemExit;
		private System.Windows.Forms.PictureBox Picture_Power1;
		private System.Windows.Forms.PictureBox Picture_Power0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox PicturePlay;
		private System.Windows.Forms.Timer PictureExchangeTimer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox PictureGem1;
		private System.Windows.Forms.PictureBox PictureGem10;
		private System.Windows.Forms.Timer FireTimer;
		private System.ComponentModel.IContainer components;
	  
		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.MenuFile = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.ItemNew = new System.Windows.Forms.MenuItem();
			this.ItemExit = new System.Windows.Forms.MenuItem();
			this.PicturePlay = new System.Windows.Forms.PictureBox();
			this.Picture_Power1 = new System.Windows.Forms.PictureBox();
			this.Picture_Power0 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PictureExchangeTimer = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.PictureGem1 = new System.Windows.Forms.PictureBox();
			this.PictureGem10 = new System.Windows.Forms.PictureBox();
			this.FireTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// MenuFile
			// 
			this.MenuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.ItemNew,
																					  this.ItemExit});
			this.menuItem1.Text = "&File";
			// 
			// ItemNew
			// 
			this.ItemNew.Index = 0;
			this.ItemNew.Text = "&New Game";
			this.ItemNew.Click += new System.EventHandler(this.ItemNew_Click);
			// 
			// ItemExit
			// 
			this.ItemExit.Index = 1;
			this.ItemExit.Text = "&Exit";
			this.ItemExit.Click += new System.EventHandler(this.ItemExit_Click);
			// 
			// PicturePlay
			// 
			this.PicturePlay.BackColor = System.Drawing.Color.Linen;
			this.PicturePlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PicturePlay.Location = new System.Drawing.Point(8, 8);
			this.PicturePlay.Name = "PicturePlay";
			this.PicturePlay.Size = new System.Drawing.Size(300, 300);
			this.PicturePlay.TabIndex = 0;
			this.PicturePlay.TabStop = false;
			this.PicturePlay.Paint += new System.Windows.Forms.PaintEventHandler(this.PicturePlay_Paint);
			// 
			// Picture_Power1
			// 
			this.Picture_Power1.Enabled = false;
			this.Picture_Power1.Location = new System.Drawing.Point(328, 88);
			this.Picture_Power1.Name = "Picture_Power1";
			this.Picture_Power1.Size = new System.Drawing.Size(24, 40);
			this.Picture_Power1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture_Power1.TabIndex = 1;
			this.Picture_Power1.TabStop = false;
			// 
			// Picture_Power0
			// 
			this.Picture_Power0.Enabled = false;
			this.Picture_Power0.Location = new System.Drawing.Point(352, 88);
			this.Picture_Power0.Name = "Picture_Power0";
			this.Picture_Power0.Size = new System.Drawing.Size(24, 40);
			this.Picture_Power0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture_Power0.TabIndex = 2;
			this.Picture_Power0.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label1.Location = new System.Drawing.Point(320, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Maze";
			// 
			// PictureExchangeTimer
			// 
			this.PictureExchangeTimer.Enabled = true;
			this.PictureExchangeTimer.Tick += new System.EventHandler(this.PictureExchangeTimer_Tick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label2.Location = new System.Drawing.Point(312, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gems";
			// 
			// PictureGem1
			// 
			this.PictureGem1.Enabled = false;
			this.PictureGem1.Location = new System.Drawing.Point(352, 192);
			this.PictureGem1.Name = "PictureGem1";
			this.PictureGem1.Size = new System.Drawing.Size(24, 40);
			this.PictureGem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureGem1.TabIndex = 6;
			this.PictureGem1.TabStop = false;
			// 
			// PictureGem10
			// 
			this.PictureGem10.Enabled = false;
			this.PictureGem10.Location = new System.Drawing.Point(328, 192);
			this.PictureGem10.Name = "PictureGem10";
			this.PictureGem10.Size = new System.Drawing.Size(24, 40);
			this.PictureGem10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureGem10.TabIndex = 5;
			this.PictureGem10.TabStop = false;
			// 
			// FireTimer
			// 
			this.FireTimer.Enabled = true;
			this.FireTimer.Interval = 5000;
			this.FireTimer.Tick += new System.EventHandler(this.FireTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(382, 311);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.PictureGem1,
																		  this.PictureGem10,
																		  this.label2,
																		  this.label1,
																		  this.Picture_Power0,
																		  this.Picture_Power1,
																		  this.PicturePlay});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.Menu = this.MenuFile;
			this.Name = "MainForm";
			this.Text = "The Maze of the Gems";
			this.TransparencyKey = System.Drawing.Color.Green;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			this.ResumeLayout(false);

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
			MazeController.InitializeGraphics();
			MazeController.SetInterfaceObjects(this.Picture_Power0,this.Picture_Power1,this.PictureGem1,this.PictureGem10,this.PicturePlay);
		}
		private void ItemExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();  
		}

		private void ItemNew_Click(object sender, System.EventArgs e)
		{
			MazeController.NewGame();
			MazeController.ManageGame();
		}
		private void PicturePlay_Paint(object sender,PaintEventArgs PEArgs)
		{
			MazeController.Paint(PEArgs.Graphics);
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode.ToString().Trim().ToLower())
			{
				case "a":
					MazeController.LeftKeyFlag=true;
					break;
				case "d":
					MazeController.RightKeyFlag=true;
					break;
				case "m":
					MazeController.BallJumpFlag=true;
					break;
			}
		}
		private void MainForm_KeyUp(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode.ToString().Trim().ToLower())
			{
				case "a":
					MazeController.LeftKeyFlag=false;
					break;
				case "d":
					MazeController.RightKeyFlag=false;
					break;
				case "m":
					MazeController.BallJumpFlag=false;
					break;
			}
		}

		private void PictureExchangeTimer_Tick(object sender, System.EventArgs e)
		{
			MazeController.ExchangePictures();
		}

		private void FireTimer_Tick(object sender, System.EventArgs e)
		{
			MazeController.ControlFire();
		}
	}
}
