using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using UtilityLibrary.WinControls;
using DeviceController;

namespace CDPlayer
{
	public class CDPlayer : System.Windows.Forms.Form
	{

		#region Members

		private CDDevice CDAudioObject = new CDDevice();
		private bool ScrubBarIsMoving = false;
		private bool DisplayMode = false;
		private int xPos = 0;
		private int yPos = 0;
		private bool IsPickedUp = false;
		private HSkinnedSlider PositionSlider = null;
		private System.Drawing.Image StorageImage;
		private System.Windows.Forms.Timer Timer;
		private GraphicControls.GraphicButton ExitButton;
		private GraphicControls.GraphicButton MinimiseButton;
		private GraphicControls.GraphicButton PreviousButton;
		private GraphicControls.GraphicButton NextButton;
		private GraphicControls.GraphicButton PlayButton;
		private GraphicControls.GraphicButton StopButton;
		private GraphicControls.GraphicToggleButton EjectButton;
		private System.Windows.Forms.PictureBox Background;
		private GraphicControls.GraphicButton DriveButton;
		private System.ComponentModel.IContainer components;
		private SlideDialog Slider;

		#endregion

		#region Constructor

		public CDPlayer()
		{
			InitializeComponent();

			//Create Position Slider
			Assembly a = Assembly.GetExecutingAssembly();
			Stream ScrubbarStream = a.GetManifestResourceStream( "CDPlayer.scrubbar.png" );
			Stream HandlestripStream = a.GetManifestResourceStream( "CDPlayer.handlestrip.png" );
			Bitmap appleHorizontalBackground = new System.Drawing.Bitmap( ScrubbarStream );
			ImageList appleHorizontalTracker = null;
			Bitmap currentImage = new System.Drawing.Bitmap( HandlestripStream );
			appleHorizontalTracker = new ImageList();
			appleHorizontalTracker.ImageSize = new Size(11,8);
			appleHorizontalTracker.ColorDepth = ColorDepth.Depth24Bit;
			appleHorizontalTracker.Images.AddStrip(currentImage);
			this.PositionSlider = new HSkinnedSlider( appleHorizontalBackground, appleHorizontalTracker );
			this.PositionSlider.Location = new System.Drawing.Point(13, 52);
			this.PositionSlider.Size = new System.Drawing.Size(223, 15);
			this.PositionSlider.TabStop = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[]{this.PositionSlider});
			this.PositionSlider.Value = 0;
			this.PositionSlider.Maximum = 100;
			this.PositionSlider.BringToFront();
			this.PositionSlider.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PositionSlider.MouseDown += new MouseEventHandler( PositionSlider_MouseDown );
			this.PositionSlider.MouseUp += new MouseEventHandler( PositionSlider_MouseUp );
			this.PositionSlider.MouseMove += new MouseEventHandler( PositionSlider_MouseMove );

			//Background Image
			Stream ImageStream = a.GetManifestResourceStream( "CDPlayer.mp3player.png" );
			this.StorageImage = ( new System.Drawing.Bitmap( ImageStream ) );

			this.Slider = new SlideDialog( this, (float)0.05 );
			this.Slider.BindListView(CDAudioObject.Drives);
		}

		#endregion

		#region Methods

		static void Main(string[] args)   	
		{      
			Application.Run( new CDPlayer() );
		}

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDPlayer));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.ExitButton = new GraphicControls.GraphicButton();
            this.MinimiseButton = new GraphicControls.GraphicButton();
            this.PreviousButton = new GraphicControls.GraphicButton();
            this.NextButton = new GraphicControls.GraphicButton();
            this.PlayButton = new GraphicControls.GraphicButton();
            this.StopButton = new GraphicControls.GraphicButton();
            this.EjectButton = new GraphicControls.GraphicToggleButton();
            this.DriveButton = new GraphicControls.GraphicButton();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(250, 63);
            this.Background.TabIndex = 12;
            this.Background.TabStop = false;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            this.Background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Background_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(234, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.NormalImage")));
            this.ExitButton.OverImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.OverImage")));
            this.ExitButton.Size = new System.Drawing.Size(13, 14);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Location = new System.Drawing.Point(219, 3);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("MinimiseButton.NormalImage")));
            this.MinimiseButton.OverImage = ((System.Drawing.Image)(resources.GetObject("MinimiseButton.OverImage")));
            this.MinimiseButton.Size = new System.Drawing.Size(13, 14);
            this.MinimiseButton.TabIndex = 14;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(134, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("PreviousButton.NormalImage")));
            this.PreviousButton.OverImage = ((System.Drawing.Image)(resources.GetObject("PreviousButton.OverImage")));
            this.PreviousButton.Size = new System.Drawing.Size(19, 21);
            this.PreviousButton.TabIndex = 16;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(194, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("NextButton.NormalImage")));
            this.NextButton.OverImage = ((System.Drawing.Image)(resources.GetObject("NextButton.OverImage")));
            this.NextButton.Size = new System.Drawing.Size(19, 21);
            this.NextButton.TabIndex = 17;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(154, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.NormalImage")));
            this.PlayButton.OverImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.OverImage")));
            this.PlayButton.Size = new System.Drawing.Size(19, 21);
            this.PlayButton.TabIndex = 18;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(174, 5);
            this.StopButton.Name = "StopButton";
            this.StopButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("StopButton.NormalImage")));
            this.StopButton.OverImage = ((System.Drawing.Image)(resources.GetObject("StopButton.OverImage")));
            this.StopButton.Size = new System.Drawing.Size(19, 21);
            this.StopButton.TabIndex = 20;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EjectButton
            // 
            this.EjectButton.Location = new System.Drawing.Point(4, 2);
            this.EjectButton.Name = "EjectButton";
            this.EjectButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("EjectButton.NormalImage")));
            this.EjectButton.PressedImage = ((System.Drawing.Image)(resources.GetObject("EjectButton.PressedImage")));
            this.EjectButton.Size = new System.Drawing.Size(28, 14);
            this.EjectButton.TabIndex = 21;
            this.EjectButton.Toggled += new System.EventHandler(this.EjectButton_Click);
            // 
            // DriveButton
            // 
            this.DriveButton.Location = new System.Drawing.Point(53, 5);
            this.DriveButton.Name = "DriveButton";
            this.DriveButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("DriveButton.NormalImage")));
            this.DriveButton.OverImage = ((System.Drawing.Image)(resources.GetObject("DriveButton.OverImage")));
            this.DriveButton.Size = new System.Drawing.Size(59, 21);
            this.DriveButton.TabIndex = 22;
            this.DriveButton.Click += new System.EventHandler(this.DriveButton_Click);
            // 
            // CDPlayer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(250, 63);
            this.Controls.Add(this.DriveButton);
            this.Controls.Add(this.EjectButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.MinimiseButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CDPlayer";
            this.Text = "CDPlayer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CDPlayer_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Timer_Tick(object sender, System.EventArgs e)
		{
			string Display = "";

			if(this.CDAudioObject.CurrentDrive != this.Slider.SelectedValue)
			{
				this.CDAudioObject.ChangeDrive( this.Slider.SelectedValue );
			}

			if( this.CDAudioObject.CDAvailable )
			{
				SetTrackBar();

				//Set scrubber bar
				if( this.CDAudioObject.Status == CDDevice.PlayStatus.Playing && !this.ScrubBarIsMoving )
				{
					this.PositionSlider.Value = this.CDAudioObject.TrackPositionSeconds;
				}

				Display = "Track " + this.CDAudioObject.CurrentTrack + " / " + this.CDAudioObject.TotalTracks + "  ";

				if( this.DisplayMode )
				{
					//Display
					Display += this.CDAudioObject.TrackDuration + " ";
				}
				else
				{
					//Display
					Display += this.CDAudioObject.TrackPosition + " ";
				}
			}
			else
			{
				Display = "NO CD AVAILABLE";
			}
			DrawDisplay( Display );
		}

		private void DrawDisplay( string displayText )
		{
			this.Background.Image = new System.Drawing.Bitmap( this.StorageImage );
			System.Drawing.Image WorkingImage = this.Background.Image;

			Color white = Color.FromArgb( 255, 255, 255);		
			SolidBrush brush = new SolidBrush( white );

			Font font = new System.Drawing.Font("Microsoft Sans Serif", 7.00F);

			Graphics Surface = Graphics.FromImage(WorkingImage);

			Surface.DrawString(  displayText, font, brush, 15, 30 );

			this.Background.Image = WorkingImage;
		}

		private void PositionSlider_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.ScrubBarIsMoving = true;
		}

		private void PositionSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.ScrubBarIsMoving = false;
			this.CDAudioObject.MovePosition( this.PositionSlider.Value );
			Thread.Sleep(1000);
		}
  
		private void PositionSlider_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.CDAudioObject.TrackDuration = " ";
		}

		private void CDPlayer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.CDAudioObject.Closing();
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void MinimiseButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void PreviousButton_Click(object sender, System.EventArgs e)
		{
			this.CDAudioObject.Previous();
		}

		private void NextButton_Click(object sender, System.EventArgs e)
		{
			this.CDAudioObject.Next();
		}

		private void PlayButton_Click(object sender, System.EventArgs e)
		{
			if( this.CDAudioObject.Status == CDDevice.PlayStatus.Playing )
			{
				Assembly a = Assembly.GetExecutingAssembly();
				Stream PlayStream = a.GetManifestResourceStream( "CDPlayer.play_off.png" );
				Bitmap PlayBitmap = new System.Drawing.Bitmap( PlayStream );
				this.PlayButton.NormalImage = PlayBitmap;

				Stream PlayOnStream = a.GetManifestResourceStream( "CDPlayer.play_on.png" );
				Bitmap PlayOnBitmap = new System.Drawing.Bitmap( PlayOnStream );
				this.PlayButton.OverImage = PlayOnBitmap;

				this.CDAudioObject.Pause();
			}
			else if( this.CDAudioObject.Status == CDDevice.PlayStatus.Paused ||
					 this.CDAudioObject.Status == CDDevice.PlayStatus.Stopped)
			{
				Assembly a = Assembly.GetExecutingAssembly();
				Stream PauseStream = a.GetManifestResourceStream( "CDPlayer.pause_off.png" );
				Bitmap PauseBitmap = new System.Drawing.Bitmap( PauseStream );
				this.PlayButton.NormalImage = PauseBitmap;

				Stream PauseOnStream = a.GetManifestResourceStream( "CDPlayer.pause_on.png" );
				Bitmap PauseOnBitmap = new System.Drawing.Bitmap( PauseOnStream );
				this.PlayButton.OverImage = PauseOnBitmap;

				this.CDAudioObject.Play();
			}
		}

		private void StopButton_Click(object sender, System.EventArgs e)
		{
			if( this.CDAudioObject.Status == CDDevice.PlayStatus.Playing ||
				this.CDAudioObject.Status == CDDevice.PlayStatus.Paused)
			{
				Assembly a = Assembly.GetExecutingAssembly();
				Stream PlayStream = a.GetManifestResourceStream( "CDPlayer.play_off.png" );
				Bitmap PlayBitmap = new System.Drawing.Bitmap( PlayStream );
				this.PlayButton.NormalImage = PlayBitmap;

				Stream PlayOnStream = a.GetManifestResourceStream( "CDPlayer.play_on.png" );
				Bitmap PlayOnBitmap = new System.Drawing.Bitmap( PlayOnStream );
				this.PlayButton.OverImage = PlayOnBitmap;

				this.CDAudioObject.Stop();
			}
		}

		private void EjectButton_Click(object sender, System.EventArgs e)
		{
			this.CDAudioObject.Eject();
		}

		private void Background_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.xPos = e.X;
				this.yPos = e.Y;
				this.IsPickedUp = true;
			}
		}

		private void Background_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.IsPickedUp = false;
			}
		}

		private void Background_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Screen [] screens = Screen.AllScreens;
			int width = screens[0].WorkingArea.Width;
			int height = screens[0].WorkingArea.Height;

			if( this.IsPickedUp )
			{
				Point temp = new Point(0,0);

				//Position x-axis onscreen only
				if( ((this.Location.X + (e.X - this.xPos)) > 0) && (this.Location.X  < (width-this.Width)) )
				{
					temp.X = this.Location.X + (e.X - this.xPos);
				}
				else
				{
					if( e.X > this.xPos )
					{
						temp.X = (width-this.Width);
					}
					else if( (this.Location.X + (e.X - this.xPos)) > 0)
					{
						temp.X = this.Location.X + (e.X - this.xPos);
					}
				}
				//Position y-axis onscreen only
				if( (this.Location.Y + (e.Y - this.yPos) > 0) && (this.Location.Y + (e.Y - this.yPos) < (height-this.Height)))
				{
					temp.Y = this.Location.Y + (e.Y - this.yPos);
				}
				else
				{
					if( e.Y > this.yPos )
					{
						temp.Y = (height-this.Height);
					}
					else if( (this.Location.Y + (e.Y - this.yPos)) > 0)
					{
						temp.Y = this.Location.Y + (e.Y - this.yPos);
					}
				}

				this.Location = temp;
			}
		}
        
		private void SetTrackBar()
		{
			//Set scrubber bar
			if( this.CDAudioObject.Status == CDDevice.PlayStatus.Playing && !this.ScrubBarIsMoving )
			{
				this.PositionSlider.Maximum = this.CDAudioObject.TrackDurationSeconds;
				this.PositionSlider.Value = this.CDAudioObject.TrackPositionSeconds;
			}
		}

		private void Display_Click(object sender, System.EventArgs e)
		{
			this.DisplayMode = !this.DisplayMode;
		}

		private void DriveButton_Click(object sender, System.EventArgs e)
		{
			this.Slider.SlideDirection = SlideDialog.SLIDE_DIRECTION.BOTTOM;
			this.Slider.Slide();
		}

		#endregion

        private void Background_Click(object sender, EventArgs e)
        {

        }

	}
}
