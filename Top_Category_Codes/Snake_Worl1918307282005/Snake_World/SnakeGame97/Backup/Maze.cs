using System;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for Maze.
	/// </summary>
	public class Maze
	{
		#region data field declarations

		private int obstacleThickness;//if obstacle is vertical, then obstacle's width
		//is the obstacleThickness. Otherwise it is the obstacle's height
		private SnakeGame parentForm;
		private int numberOfObstacles;
		private int maxNumberOfObstacles;
		private System.Windows.Forms.Label[] obstacles;		
		private System.Drawing.Color mazeColor;

		#endregion

		internal System.Drawing.Color MazeColor
		{
			get
			{
				return this.mazeColor;
			}
			set
			{
				this.mazeColor = value;

				if(this.obstacles != null)
					for(int i=0; i<this.numberOfObstacles; i++)
						this.obstacles[i].BackColor = this.mazeColor;
			}
		}

		public Maze(SnakeGame parentForm)
		{
			//
			// TODO: Add constructor logic here
			//
			this.maxNumberOfObstacles = 20;
			this.numberOfObstacles = 20;
			//this.obstacles = new System.Windows.Forms.Label[this.numberOfObstacles];	
			this.obstacleThickness = 20;
			this.parentForm = parentForm;
			this.mazeColor = System.Drawing.SystemColors.GrayText;
		}

		public Maze(SnakeGame parentForm, System.Drawing.Color mazeColor)
		{
			//
			// TODO: Add constructor logic here
			//
			this.maxNumberOfObstacles = 20;
			this.numberOfObstacles = 20;
			//this.obstacles = new System.Windows.Forms.Label[this.numberOfObstacles];	
			this.obstacleThickness = 20;
			this.parentForm = parentForm;
			this.mazeColor = mazeColor;
		}


		private void InitializeObstacles()
		{
			this.obstacles = new System.Windows.Forms.Label[this.numberOfObstacles];	
			for(int i=0; i<this.numberOfObstacles; i++)
			{
				this.obstacles[i] = new System.Windows.Forms.Label();
				this.obstacles[i].BackColor = this.mazeColor;
				this.obstacles[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;								
				this.parentForm.Controls.Add(this.obstacles[i]);
			}
		}

		internal bool IsHeadPositionCorrect(System.Drawing.Point newLoc)
		{	
			if(this.numberOfObstacles == 0)
				return true;

			for(int i=0; i<this.numberOfObstacles; i++)
				if(newLoc.X >= this.obstacles[i].Left  &&  newLoc.X < this.obstacles[i].Right
				&&  newLoc.Y >= this.obstacles[i].Top  &&  newLoc.Y < this.obstacles[i].Bottom)
					return false;
				
			return true;
		}
		
		internal void ShowMaze(int level)
		{
			if(this.obstacles != null)
			{
				for(int i=0; i<this.numberOfObstacles; i++)
					if(this.obstacles[i] != null)
					{
						this.parentForm.Controls.Remove(this.obstacles[i]);
						this.obstacles[i].Dispose();
						this.obstacles[i] = null;
					}

				this.obstacles = null;
			}

			if(level == 1)
			{
				this.numberOfObstacles = 0;
				return;
			}

			int parentMidX = this.parentForm.Width/2;
			int parentMidY = this.parentForm.PlayingAreaBottom/2;
			int diff = parentMidX % 10;
			if(diff != 0)
				parentMidX += 10-diff;
			
			diff = parentMidY % 10;
			if(diff != 0)
				parentMidY += 10-diff;

			//we need parent's right and bottom as multiples of 10
			int parentRequiredRight = this.parentForm.Width;
			int parentRequiredBottom = this.parentForm.PlayingAreaBottom;
			diff = parentRequiredRight % 10;
			if(diff != 0)
				parentRequiredRight -= diff;

			diff = parentRequiredBottom % 10;
			if(diff != 0)
				parentRequiredBottom -= diff;
	
			
			if(level == 2)
			{
				this.numberOfObstacles = 3;
				this.InitializeObstacles();
				
				int obstacleDistance = 40;//horizontal distance between obstacles
				int obstacleLength = 200;//if obstacle is vertical, then obstacle's height
				//is the obstacleLength. Otherwise it is the obstacle's width

				this.obstacles[0].Height = obstacleLength;
				this.obstacles[0].Width = this.obstacleThickness;
				this.obstacles[0].Left = parentMidX-(this.obstacles[0].Width/2);
				this.obstacles[0].Top = parentMidY-(this.obstacles[0].Height/2);

				this.obstacles[1].Height = this.obstacleThickness;
				this.obstacles[1].Width = obstacleLength;
				this.obstacles[1].Top = this.obstacles[0].Top;
				this.obstacles[1].Left = this.obstacles[0].Left-obstacleDistance-obstacleLength;

				this.obstacles[2].Height = this.obstacleThickness;
				this.obstacles[2].Width = obstacleLength;
				this.obstacles[2].Top = this.obstacles[0].Bottom-this.obstacleThickness;
				this.obstacles[2].Left = this.obstacles[0].Right + obstacleDistance;			
			}
			else if(level == 3)
			{
				this.numberOfObstacles = 5;
				this.InitializeObstacles();
				
				int distanceFromParentBorder = 100;
				int obstacleDistance = 20;//distance between different obstacles
				int obstacleLength = 200;//if obstacle is vertical, then obstacle's height
				//is the obstacleLength. Otherwise it is the obstacle's width

				//draw the center vertical obstacle
				this.obstacles[0].Height = obstacleLength;
				this.obstacles[0].Width = this.obstacleThickness;
				this.obstacles[0].Left = parentMidX-(this.obstacles[0].Width/2);
				this.obstacles[0].Top = parentMidY-(this.obstacles[0].Height/2);

				//draw the left top horizontal obstacle
				this.obstacles[1].Height = this.obstacleThickness;
				this.obstacles[1].Width = obstacleLength;
				this.obstacles[1].Top = this.parentForm.Top+distanceFromParentBorder;
				this.obstacles[1].Left = distanceFromParentBorder;

				//draw the left top vertical obstacle
				this.obstacles[2].Height = obstacleLength+this.obstacleThickness;
				this.obstacles[2].Width = this.obstacleThickness;
				this.obstacles[2].Top = this.obstacles[1].Bottom + obstacleDistance;
				this.obstacles[2].Left = distanceFromParentBorder;

				//draw the bottom right horizontal obstacle
				this.obstacles[3].Height = this.obstacleThickness;
				this.obstacles[3].Width = obstacleLength;
				this.obstacles[3].Top = parentRequiredBottom-distanceFromParentBorder
					-obstacleThickness;
				this.obstacles[3].Left = parentRequiredRight-distanceFromParentBorder-
					obstacleLength;			

				//draw the left top vertical obstacle
				this.obstacles[4].Height = obstacleLength+this.obstacleThickness;
				this.obstacles[4].Width = this.obstacleThickness;
				this.obstacles[4].Top = this.obstacles[3].Top - obstacleLength
					-obstacleThickness - obstacleDistance;
				this.obstacles[4].Left = this.obstacles[3].Right - obstacleThickness;
			}
			else if(level == 4)
			{
				this.numberOfObstacles = 6;
				this.InitializeObstacles();
								
				int obstacleDistance = 100;//distance between different obstacles
				int obstacleLength = 300;//if obstacle is vertical, then obstacle's height
				//is the obstacleLength. Otherwise it is the obstacle's width

				for(int i=0; i<this.numberOfObstacles; i++)
				{
					this.obstacles[i].Height = obstacleLength;
					this.obstacles[i].Width = this.obstacleThickness;
					this.obstacles[i].Top = parentMidY-(this.obstacles[0].Height/2);
				}

				//set the 3nd vertical obstacle from the left to right side
				this.obstacles[0].Left = parentMidX-(obstacleDistance/2)-obstacleThickness;
				
				//set the 2nd vertical obstacle from the left to right side
				this.obstacles[1].Left = this.obstacles[0].Left-obstacleThickness
					-obstacleDistance;
				
				//set the 1st vertical obstacle from the left to right side
				this.obstacles[2].Left = this.obstacles[1].Left-obstacleThickness
					-obstacleDistance;
				
				//set the 4rd vertical obstacle from the left to right side
				this.obstacles[3].Left = parentMidX+(obstacleDistance/2);
				
				//set the 5th vertical obstacle from the left to right side
				this.obstacles[4].Left = this.obstacles[3].Right+obstacleDistance;				

				//set the 5th vertical obstacle from the left to right side
				this.obstacles[5].Left = this.obstacles[4].Right+obstacleDistance;				
			}
			else if(level == 5)
			{
				this.numberOfObstacles = 5;
				this.InitializeObstacles();
								
				int obstacleDistance = 140;//vertical distance between horizontal obstacles
				int obstacleLength = parentRequiredRight-300;//if obstacle is horizontal, then
				//obstacle's width is the obstacleLength

				//draw the center horizotal obstacle
				this.obstacles[0].Height = this.obstacleThickness;
				this.obstacles[0].Width = obstacleLength;
				this.obstacles[0].Left = this.parentForm.Right-obstacleLength;
				this.obstacles[0].Top = parentMidY-(this.obstacleThickness/2);

				//draw the topmost horizotal obstacle
				this.obstacles[1].Height = this.obstacleThickness;
				this.obstacles[1].Width = obstacleLength;
				this.obstacles[1].Left = 0;
				this.obstacles[1].Top = this.obstacles[0].Top-(this.obstacleThickness/2)
					-obstacleDistance;

				//draw the bottommost horizotal obstacle
				this.obstacles[2].Height = this.obstacleThickness;
				this.obstacles[2].Width = obstacleLength;
				this.obstacles[2].Left = 0;
				this.obstacles[2].Top = this.obstacles[0].Bottom+obstacleDistance;

				int distanceFromBorder = 80;
				int verticalObstacleLength = 200;
				int verticalDistance = obstacleDistance/2;//distance of vertical obstacles 
				//from the howizontal ones

				//draw the left vertical obstacle
				this.obstacles[3].Height = verticalObstacleLength;
				this.obstacles[3].Width = this.obstacleThickness;
				this.obstacles[3].Left = distanceFromBorder;
				this.obstacles[3].Top = this.obstacles[1].Top+verticalDistance-20;

				//draw the right vertical obstacle
				this.obstacles[4].Height = verticalObstacleLength;
				this.obstacles[4].Width = this.obstacleThickness;
				this.obstacles[4].Left = this.parentForm.Right-distanceFromBorder
					-this.obstacleThickness;
				this.obstacles[4].Top = this.obstacles[0].Top+verticalDistance-20;
			}
			else if(level == 6)
			{
				this.numberOfObstacles = 10;
				this.InitializeObstacles();
								
				int obstacleDistance = 100;//distance between different obstacles
				int obstacleLength = 300;//if obstacle is vertical, then obstacle's height
				//is the obstacleLength

				for(int i=0; i<this.numberOfObstacles; i++)
				{
					this.obstacles[i].Height = obstacleLength;
					this.obstacles[i].Width = this.obstacleThickness;
					this.obstacles[i].Top = parentMidY-(this.obstacles[0].Height/2);
				}

				//set the 3nd vertical obstacle from the left to right side
				this.obstacles[0].Left = parentMidX-(obstacleDistance/2)-obstacleThickness;
				
				//set the 2nd vertical obstacle from the left to right side
				this.obstacles[1].Left = this.obstacles[0].Left-obstacleThickness
					-obstacleDistance;
				
				//set the 1st vertical obstacle from the left to right side
				this.obstacles[2].Left = this.obstacles[1].Left-obstacleThickness
					-obstacleDistance;
				
				//set the 4rd vertical obstacle from the left to right side
				this.obstacles[3].Left = parentMidX+(obstacleDistance/2);
				
				//set the 5th vertical obstacle from the left to right side
				this.obstacles[4].Left = this.obstacles[3].Right+obstacleDistance;				

				//set the 6th vertical obstacle from the left to right side
				this.obstacles[5].Left = this.obstacles[4].Right+obstacleDistance;	
			
				int horizontalObstacleLength = this.obstacles[0].Right - this.obstacles[2].Left;
				int horizontalObstacleDistance = obstacleDistance/2;//vertical distance  between
				//horizontal and vertical obstacles

				//draw the left top horizontal obstacle
				this.obstacles[6].Height = this.obstacleThickness;
				this.obstacles[6].Width = horizontalObstacleLength;
				this.obstacles[6].Top = this.obstacles[0].Top-this.obstacleThickness
					-horizontalObstacleDistance;
				this.obstacles[6].Left = this.obstacles[2].Left;	

				//draw the Right top horizontal obstacle
				this.obstacles[7].Height = this.obstacleThickness;
				this.obstacles[7].Width = horizontalObstacleLength;
				this.obstacles[7].Top = this.obstacles[0].Top-this.obstacleThickness
					-horizontalObstacleDistance;
				this.obstacles[7].Left = this.obstacles[3].Left;	

				//draw the Right Bottom horizontal obstacle
				this.obstacles[8].Height = this.obstacleThickness;
				this.obstacles[8].Width = horizontalObstacleLength;
				this.obstacles[8].Top = this.obstacles[0].Bottom+horizontalObstacleDistance;
				this.obstacles[8].Left = this.obstacles[3].Left;	

				//draw the Left Bottom horizontal obstacle
				this.obstacles[9].Height = this.obstacleThickness;
				this.obstacles[9].Width = horizontalObstacleLength;
				this.obstacles[9].Top = this.obstacles[0].Bottom+horizontalObstacleDistance;
				this.obstacles[9].Left = this.obstacles[2].Left;	
			}
			else if(level == 7)
			{
				this.numberOfObstacles = 11;
				this.InitializeObstacles();
								
				int obstacleDistance = 60;//vertical distance between horizontal obstacles
				int obstacleLength = 200;//if obstacle is horizontal, then
				//obstacle's width is the obstacleLength
				int verticalObstacleLength = 180;

				//draw the center horizotal obstacle
				this.obstacles[0].Height = this.obstacleThickness;
				this.obstacles[0].Width = obstacleLength;
				this.obstacles[0].Left = parentMidX-(obstacleLength/2);
				this.obstacles[0].Top = parentMidY-(this.obstacleThickness/2);

				//draw the topmost vertical obstacle
				this.obstacles[1].Height = verticalObstacleLength;
				this.obstacles[1].Width = this.obstacleThickness;
				this.obstacles[1].Left = parentMidX-(this.obstacleThickness/2);
				this.obstacles[1].Top = this.obstacles[0].Top-obstacleDistance
					-verticalObstacleLength;

				//draw the bottommost vertical obstacle
				this.obstacles[2].Height = verticalObstacleLength;
				this.obstacles[2].Width = this.obstacleThickness;
				this.obstacles[2].Left = obstacles[1].Left;
				this.obstacles[2].Top = this.obstacles[0].Bottom+obstacleDistance;

				//draw the top left horizontal obstacle
				this.obstacles[3].Height = this.obstacleThickness;
				this.obstacles[3].Width = obstacleLength;
				this.obstacles[3].Left = obstacles[0].Left-obstacleLength;
				this.obstacles[3].Top = this.obstacles[1].Top;

				//draw the top right horizontal obstacle
				this.obstacles[4].Height = this.obstacleThickness;
				this.obstacles[4].Width = obstacleLength;
				this.obstacles[4].Left = obstacles[0].Right;
				this.obstacles[4].Top = this.obstacles[1].Top;

				//draw the upper middle left horizontal obstacle
				this.obstacles[5].Height = this.obstacleThickness;
				this.obstacles[5].Width = obstacleLength;
				this.obstacles[5].Left = obstacles[0].Left-obstacleLength;
				this.obstacles[5].Top = this.obstacles[1].Bottom-this.obstacleThickness;

				//draw the upper middle right horizontal obstacle
				this.obstacles[6].Height = this.obstacleThickness;
				this.obstacles[6].Width = obstacleLength;
				this.obstacles[6].Left = obstacles[0].Right;
				this.obstacles[6].Top = this.obstacles[1].Bottom-this.obstacleThickness;

				//draw the lower middle left horizontal obstacle
				this.obstacles[7].Height = this.obstacleThickness;
				this.obstacles[7].Width = obstacleLength;
				this.obstacles[7].Left = obstacles[0].Left-obstacleLength;
				this.obstacles[7].Top = this.obstacles[2].Top;

				//draw the lower middle right horizontal obstacle
				this.obstacles[8].Height = this.obstacleThickness;
				this.obstacles[8].Width = obstacleLength;
				this.obstacles[8].Left = obstacles[0].Right;
				this.obstacles[8].Top = this.obstacles[2].Top;

				//draw the bottom left horizontal obstacle
				this.obstacles[9].Height = this.obstacleThickness;
				this.obstacles[9].Width = obstacleLength;
				this.obstacles[9].Left = obstacles[0].Left-obstacleLength;
				this.obstacles[9].Top = this.obstacles[2].Bottom-this.obstacleThickness;

				//draw the bottom right horizontal obstacle
				this.obstacles[10].Height = this.obstacleThickness;
				this.obstacles[10].Width = obstacleLength;
				this.obstacles[10].Left = obstacles[0].Right;
				this.obstacles[10].Top = this.obstacles[2].Bottom-this.obstacleThickness;
			}	
			else if(level == 8)
			{
				this.numberOfObstacles = 17;
				this.InitializeObstacles();
				
				int distanceFromParentBorder = 60;
				int obstacleDistance = 40;//distance between different obstacles
				int obstacleLength = 160;//if obstacle is vertical, then obstacle's height
				//is the obstacleLength. Otherwise it is the obstacle's width

				//draw the upper left pair of obstacles
				//draw the left top horizontal obstacle(the upper one)
				this.obstacles[0].Height = this.obstacleThickness;
				this.obstacles[0].Width = obstacleLength;
				this.obstacles[0].Top = this.parentForm.Top+distanceFromParentBorder;
				this.obstacles[0].Left = distanceFromParentBorder;

				//draw the left top vertical obstacle(the left one)
				this.obstacles[1].Height = obstacleLength;
				this.obstacles[1].Width = this.obstacleThickness;
				this.obstacles[1].Top = this.obstacles[0].Bottom;
				this.obstacles[1].Left = obstacles[0].Left;

				//draw the left top vertical obstacle(the right one)
				this.obstacles[2].Height = obstacleLength;
				this.obstacles[2].Width = this.obstacleThickness;
				this.obstacles[2].Top = this.obstacles[0].Top;
				this.obstacles[2].Left = obstacles[0].Right+obstacleDistance;

				//draw the left top horizontal obstacle(the lower one)
				this.obstacles[3].Height = this.obstacleThickness;
				this.obstacles[3].Width = obstacleLength;
				this.obstacles[3].Top = this.obstacles[2].Bottom;
				this.obstacles[3].Left = this.obstacles[2].Right-obstacleLength;

				//draw the upper right pair of obstacles
				//draw the right top horizontal obstacle(the upper one)
				this.obstacles[4].Height = this.obstacleThickness;
				this.obstacles[4].Width = obstacleLength;
				this.obstacles[4].Top = this.parentForm.Top+distanceFromParentBorder;
				this.obstacles[4].Left = parentRequiredRight - distanceFromParentBorder
					-obstacleLength-obstacleDistance;

				//draw the right top vertical obstacle(the left one)
				this.obstacles[5].Height = obstacleLength;
				this.obstacles[5].Width = this.obstacleThickness;
				this.obstacles[5].Top = this.obstacles[4].Bottom;
				this.obstacles[5].Left = obstacles[4].Left;

				//draw the right top vertical obstacle(the right one)
				this.obstacles[6].Height = obstacleLength;
				this.obstacles[6].Width = this.obstacleThickness;
				this.obstacles[6].Top = this.obstacles[4].Top;
				this.obstacles[6].Left = obstacles[4].Right+obstacleDistance;

				//draw the right top horizontal obstacle(the lower one)
				this.obstacles[7].Height = this.obstacleThickness;
				this.obstacles[7].Width = obstacleLength;
				this.obstacles[7].Top = this.obstacles[6].Bottom;
				this.obstacles[7].Left = this.obstacles[6].Right-obstacleLength;


				//draw the bottom right pair of obstacles
				//draw the bottom right horizontal obstacle(the lower one)
				this.obstacles[8].Height = this.obstacleThickness;
				this.obstacles[8].Width = obstacleLength;
				this.obstacles[8].Top = parentRequiredBottom-distanceFromParentBorder
					-obstacleThickness;
				this.obstacles[8].Left = parentRequiredRight - distanceFromParentBorder
					-obstacleLength-obstacleDistance;

				//draw the bottom right vertical obstacle(the left one)
				this.obstacles[9].Height = obstacleLength;
				this.obstacles[9].Width = this.obstacleThickness;
				this.obstacles[9].Top = this.obstacles[8].Top-obstacleLength;
				this.obstacles[9].Left = obstacles[8].Left;

				//draw the bottom right horizontal obstacle(the upper one)
				this.obstacles[10].Height = this.obstacleThickness;
				this.obstacles[10].Width = obstacleLength;
				this.obstacles[10].Top = this.obstacles[9].Top;
				this.obstacles[10].Left = this.obstacles[9].Right+obstacleDistance;

				//draw the bottom right vertical obstacle(the right one)
				this.obstacles[11].Height = obstacleLength;
				this.obstacles[11].Width = this.obstacleThickness;
				this.obstacles[11].Top = this.obstacles[10].Bottom;
				this.obstacles[11].Left = obstacles[6].Left;


				//draw the bottom left pair of obstacles
				//draw the bottom left horizontal obstacle(the lower one)
				this.obstacles[12].Height = this.obstacleThickness;
				this.obstacles[12].Width = obstacleLength;
				this.obstacles[12].Top = parentRequiredBottom-distanceFromParentBorder
					-obstacleThickness;
				this.obstacles[12].Left = obstacles[0].Left;
					
				//draw the bottom left vertical obstacle(the left one)
				this.obstacles[13].Height = obstacleLength;
				this.obstacles[13].Width = this.obstacleThickness;
				this.obstacles[13].Top = this.obstacles[12].Top-obstacleLength;
				this.obstacles[13].Left = obstacles[12].Left;

				//draw the bottom left horizontal obstacle(the upper one)
				this.obstacles[14].Height = this.obstacleThickness;
				this.obstacles[14].Width = obstacleLength;
				this.obstacles[14].Top = this.obstacles[13].Top;
				this.obstacles[14].Left = this.obstacles[13].Right+obstacleDistance;

				//draw the bottom left vertical obstacle(the right one)
				this.obstacles[15].Height = obstacleLength;
				this.obstacles[15].Width = this.obstacleThickness;
				this.obstacles[15].Top = this.obstacles[14].Bottom;
				this.obstacles[15].Left = obstacles[2].Left;

				//draw the middle obstacles
				this.obstacles[16].Height = this.obstacleThickness;
				this.obstacles[16].Width = obstacleLength;
				this.obstacles[16].Left = parentMidX-(obstacleLength/2);
				this.obstacles[16].Top = parentMidY-(this.obstacleThickness/2);
			}
			else if(level == 9)
			{
				this.numberOfObstacles = 16;
				this.InitializeObstacles();
				
				int startLeft = 80;
				int startTop = 50;
				int obstacleDistance = 40;//distance between a horizontal and vertical obstacle
				int obstacleLength = 130;//if obstacle is horizontal, then obstacle's width
				//is the obstacleLength. 

				//draw the upper sequence of obstacles
				//draw the upper left horizontal obstacle(1st obstacle from the left)				
				this.obstacles[0].Height = this.obstacleThickness;
				this.obstacles[0].Width = obstacleLength;
				this.obstacles[0].Top = startTop;
				this.obstacles[0].Left = startLeft;

				//draw the upper left vertical obstacle(2nd obstacle from the left)				
				this.obstacles[1].Height = obstacleLength;
				this.obstacles[1].Width = this.obstacleThickness;
				this.obstacles[1].Top = startTop;
				this.obstacles[1].Left = this.obstacles[0].Right + obstacleDistance;

				//draw the upper left horizontal obstacle(3rd obstacle from the left)				
				this.obstacles[2].Height = this.obstacleThickness;
				this.obstacles[2].Width = obstacleLength;
				this.obstacles[2].Top = this.obstacles[1].Bottom - this.obstacleThickness;
				this.obstacles[2].Left = this.obstacles[1].Right + obstacleDistance;

				//draw the upper left vertical obstacle(4th obstacle from the left)				
				this.obstacles[3].Height = obstacleLength;
				this.obstacles[3].Width = this.obstacleThickness;
				this.obstacles[3].Top = this.obstacles[2].Top;
				this.obstacles[3].Left = this.obstacles[2].Right + obstacleDistance;

				//draw the upper left horizontal obstacle(5th obstacle from the left)				
				this.obstacles[4].Height = this.obstacleThickness;
				this.obstacles[4].Width = obstacleLength;
				this.obstacles[4].Top = this.obstacles[3].Bottom - this.obstacleThickness;
				this.obstacles[4].Left = this.obstacles[3].Right + obstacleDistance;

				//draw the upper left vertical obstacle(6th obstacle from the left)				
				this.obstacles[5].Height = obstacleLength;
				this.obstacles[5].Width = this.obstacleThickness;
				this.obstacles[5].Top = this.obstacles[4].Top;
				this.obstacles[5].Left = this.obstacles[4].Right + obstacleDistance;

				//draw the lower sequence of obstacles
				//draw the lower left vertical obstacle(1st obstacle from the left)				
				this.obstacles[6].Height = obstacleLength;
				this.obstacles[6].Width = this.obstacleThickness;
				this.obstacles[6].Top = this.obstacles[1].Bottom;
				this.obstacles[6].Left = this.obstacles[0].Left;

				//draw the lower left horizontal obstacle(2nd obstacle from the left)				
				this.obstacles[7].Height = this.obstacleThickness;
				this.obstacles[7].Width = obstacleLength;
				this.obstacles[7].Top = this.obstacles[6].Bottom - this.obstacleThickness;
				this.obstacles[7].Left = this.obstacles[6].Right + obstacleDistance;

				//draw the lower left vertical obstacle(3rd obstacle from the left)				
				this.obstacles[8].Height = obstacleLength;
				this.obstacles[8].Width = this.obstacleThickness;
				this.obstacles[8].Top = this.obstacles[7].Top;
				this.obstacles[8].Left = this.obstacles[7].Right + obstacleDistance;

				//draw the lower left horizontal obstacle(4th obstacle from the left)				
				this.obstacles[9].Height = this.obstacleThickness;
				this.obstacles[9].Width = obstacleLength;
				this.obstacles[9].Top = this.obstacles[8].Bottom - this.obstacleThickness;
				this.obstacles[9].Left = this.obstacles[8].Right + obstacleDistance;

				//draw the lower left vertical obstacle(5th obstacle from the left)				
				this.obstacles[10].Height = obstacleLength;
				this.obstacles[10].Width = this.obstacleThickness;
				this.obstacles[10].Top = this.obstacles[9].Top;
				this.obstacles[10].Left = this.obstacles[9].Right + obstacleDistance;

				//draw the lower left horizontal obstacle(6th obstacle from the left)				
				this.obstacles[11].Height = this.obstacleThickness;
				this.obstacles[11].Width = obstacleLength;
				this.obstacles[11].Top = this.obstacles[10].Bottom - this.obstacleThickness;
				this.obstacles[11].Left = this.obstacles[10].Right + obstacleDistance;


				//draw the bottom left pair of obstacles
				//draw the lower left vertical obstacle
				this.obstacles[12].Height = obstacleLength;
				this.obstacles[12].Width = this.obstacleThickness;
				this.obstacles[12].Top = this.obstacles[10].Top;
				this.obstacles[12].Left = this.obstacles[0].Left;

				//draw the lower left horizontal obstacle
				this.obstacles[13].Height = this.obstacleThickness;
				this.obstacles[13].Width = obstacleLength;
				this.obstacles[13].Top = this.obstacles[11].Top;
				this.obstacles[13].Left = this.obstacles[12].Right;


				//draw the bottom left pair of obstacles
				//draw the lower left vertical obstacle
				this.obstacles[14].Height = obstacleLength;
				this.obstacles[14].Width = this.obstacleThickness;
				this.obstacles[14].Top = this.obstacles[0].Top;
				this.obstacles[14].Left = this.obstacles[5].Left;

				//draw the lower left horizontal obstacle
				this.obstacles[15].Height = this.obstacleThickness;
				this.obstacles[15].Width = obstacleLength;
				this.obstacles[15].Top = this.obstacles[0].Top;
				this.obstacles[15].Left = this.obstacles[14].Left - obstacleLength;
			}
			else if(level == 10)
			{
				this.numberOfObstacles = 16;
				this.InitializeObstacles();
				
				int startLeft = 80;
				int startTop = 70;
				int obstacleYDistance = 10;//denotes vertical distance between pair of horizontal
				//obstacles. OR denotes horizontal distance between pair of vertical obstacles
				int obstacleXDistance = 60;//denotes horizontal distance between pair of vertical
				//obstacles. OR denotes vertical distance between pair of horizontal obstacles
				int obstacleLength = 130;//for vertical obstacles, the obstacle's height
				//is the obstacleLength. Otherwise it is the obstacle's width

				//draw the upper left vertical pair of obstacles
				//draw the left top vertical obstacle(the left one)
				this.obstacles[0].Height = obstacleLength;
				this.obstacles[0].Width = this.obstacleThickness;
				this.obstacles[0].Top = startTop;
				this.obstacles[0].Left = startLeft;

				//draw the left top vertical obstacle(the middle one)
				this.obstacles[1].Height = obstacleLength;
				this.obstacles[1].Width = this.obstacleThickness;
				this.obstacles[1].Top = this.obstacles[0].Top + obstacleXDistance;
				this.obstacles[1].Left = this.obstacles[0].Right + obstacleYDistance;

				//draw the left top vertical obstacle(the right one)
				this.obstacles[2].Height = obstacleLength;
				this.obstacles[2].Width = this.obstacleThickness;
				this.obstacles[2].Top = this.obstacles[1].Top + obstacleXDistance;
				this.obstacles[2].Left = this.obstacles[1].Right + obstacleYDistance;


				//draw the bottom right vertical pair of obstacles
				//draw the bottom top vertical obstacle(the lower one)
				this.obstacles[3].Height = obstacleLength;
				this.obstacles[3].Width = this.obstacleThickness;
				this.obstacles[3].Top = parentRequiredBottom - obstacleLength - startTop;
				this.obstacles[3].Left = parentRequiredRight - this.obstacleThickness - startLeft;

				//draw the left top vertical obstacle(the middle one)
				this.obstacles[4].Height = obstacleLength;
				this.obstacles[4].Width = this.obstacleThickness;
				this.obstacles[4].Top = this.obstacles[3].Bottom - obstacleXDistance - obstacleLength;
				this.obstacles[4].Left = this.obstacles[3].Left - obstacleYDistance - this.obstacleThickness;

				//draw the left top horizontal obstacle(the upper one)
				this.obstacles[5].Height = obstacleLength;
				this.obstacles[5].Width = this.obstacleThickness;
				this.obstacles[5].Top = this.obstacles[4].Bottom - obstacleXDistance - obstacleLength;
				this.obstacles[5].Left = this.obstacles[4].Left - obstacleYDistance - this.obstacleThickness;


				//draw the upper right horizontal pair of obstacles
				//draw the upper right horizontal obstacle(the upper one)
				this.obstacles[6].Height = this.obstacleThickness;
				this.obstacles[6].Width = obstacleLength;
				this.obstacles[6].Top = this.obstacles[0].Top;
				this.obstacles[6].Left = this.obstacles[5].Right - obstacleLength;

				//draw the upper right horizontal obstacle(the middle one)
				this.obstacles[7].Height = this.obstacleThickness;
				this.obstacles[7].Width = obstacleLength;
				this.obstacles[7].Top = this.obstacles[6].Bottom + obstacleYDistance;
				this.obstacles[7].Left = this.obstacles[6].Left - obstacleXDistance - this.obstacleThickness;

				//draw the upper right horizontal obstacle(the lower one)
				this.obstacles[8].Height = this.obstacleThickness;
				this.obstacles[8].Width = obstacleLength;
				this.obstacles[8].Top = this.obstacles[7].Bottom + obstacleYDistance;
				this.obstacles[8].Left = this.obstacles[7].Left - obstacleXDistance - this.obstacleThickness;


				//draw the bottom left horizontal pair of obstacles
				//draw the bottom left horizontal obstacle(the lower one)
				this.obstacles[9].Height = this.obstacleThickness;
				this.obstacles[9].Width = obstacleLength;
				this.obstacles[9].Top = this.obstacles[3].Bottom - this.obstacleThickness;
				this.obstacles[9].Left = this.obstacles[2].Left;

				//draw the bottom left horizontal obstacle(the middle one)
				this.obstacles[10].Height = this.obstacleThickness;
				this.obstacles[10].Width = obstacleLength;
				this.obstacles[10].Top = this.obstacles[9].Top - obstacleYDistance - this.obstacleThickness;
				this.obstacles[10].Left = this.obstacles[9].Left + obstacleXDistance;

				//draw the bottom left horizontal obstacle(the lower one)
				this.obstacles[11].Height = this.obstacleThickness;
				this.obstacles[11].Width = obstacleLength;
				this.obstacles[11].Top = this.obstacles[10].Top - obstacleYDistance - this.obstacleThickness;
				this.obstacles[11].Left = this.obstacles[10].Left + obstacleXDistance;

				//draw the central pair of obstacles
				int obstacleDistance = 20;
				int midStartLeft = ((this.obstacleThickness*2) + (obstacleDistance*2) + obstacleLength)/2;
				diff = midStartLeft % 10;
				if(diff != 0)
					midStartLeft -= diff;

				int midStartTop = obstacleLength/2;
				diff = midStartTop % 10;
				if(diff != 0)
					midStartTop -= diff;				

				midStartTop = parentMidY - midStartTop;
				midStartLeft = parentMidX - midStartLeft;

				//draw the left vertical obstacle
				this.obstacles[12].Height = obstacleLength;
				this.obstacles[12].Width = this.obstacleThickness;
				this.obstacles[12].Left = midStartLeft;
				this.obstacles[12].Top = midStartTop;

				//draw the upper horizontal obstacle
				this.obstacles[13].Height = this.obstacleThickness;
				this.obstacles[13].Width = obstacleLength;
				this.obstacles[13].Left = this.obstacles[12].Right + obstacleDistance;
				this.obstacles[13].Top = midStartTop;

				//draw the right vertical obstacle
				this.obstacles[14].Height = obstacleLength;
				this.obstacles[14].Width = this.obstacleThickness;
				this.obstacles[14].Left = this.obstacles[13].Right + obstacleDistance;
				this.obstacles[14].Top = midStartTop;

				//draw the upper horizontal obstacle
				this.obstacles[15].Height = this.obstacleThickness;
				this.obstacles[15].Width = obstacleLength;
				this.obstacles[15].Left = this.obstacles[13].Left;
				this.obstacles[15].Top = this.obstacles[14].Bottom - this.obstacleThickness;
			}
			else
				this.numberOfObstacles = 0;
		}


	}
}
