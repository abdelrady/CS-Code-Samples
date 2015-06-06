using System;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;

using UtilityLibrary.WinControls;

namespace UtilityLibrary.WinControls
{

	[ToolboxItem(false)]
	public class SkinnedSlider : System.Windows.Forms.Control
	{
		#region Events
		public event EventHandler ValueChanged;
		#endregion

		#region Class Variables
		
		// Tracker images
		protected ImageList trackerImageList = null;
		
		// Property backing variables
		protected  int _value = 0;
		protected  int previousValue = 0;
		protected  int min = 0;
		protected  int max = 100;
		
		// Miscelaneous
		protected int trackerPos = 0;
		protected int offset = 0;
		protected DrawState drawState = DrawState.Normal;
		protected Rectangle trackerRect = Rectangle.Empty;
		
		#endregion
				
		#region Constructors
		public SkinnedSlider()
		{
			Initialize(null, null);
		}

		public SkinnedSlider(Bitmap backgroundImage, ImageList trackerImageList)
		{
			Initialize(backgroundImage, trackerImageList);
		}

		void Initialize(Bitmap backgroundImage, ImageList trackerImageList)
		{
			// We are going to do all of the painting so better setup the control
			// to use double buffering
			SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.ResizeRedraw
				| ControlStyles.Opaque |
				ControlStyles.UserPaint|ControlStyles.DoubleBuffer, true);
			BackgroundImage = backgroundImage;
			this.trackerImageList = trackerImageList;
		}

		#endregion

		#region Overrides
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			Graphics g = pe.Graphics;
			
			// paint background
			DrawBackground(g);
			// The little tracker
			DrawTracker(g);
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			// Initalize the position value
			trackerPos = GetPosition(_value);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			// Set state to hot
			base.OnMouseEnter(e);
			Point pos = Control.MousePosition;
			pos = PointToClient(pos);
			if ( trackerRect.Contains(pos) )
			{
				drawState = DrawState.Hot;
				Invalidate();
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			// Set state to Normal
			base.OnMouseLeave(e);
			drawState = DrawState.Normal;
			Invalidate();
		}
		#endregion

		#region Virtuals
		// Some of these virtual need to be implemented by the derived class
		// --They should have been abstract if it was not for the IDE desinger 
		// throwing an assertion if the class was abstract
		protected virtual void DrawBackground(Graphics g)
		{
			Rectangle rc = ClientRectangle;
			// If we have a background bitmap
			if ( BackgroundImage != null )
			{
				int imageWidth = BackgroundImage.Size.Width;
				int imageHeight =  BackgroundImage.Size.Height;
				
				// Paint background color first to allow transparent bitmaps
				using ( Brush b = new SolidBrush(BackColor) )
				{
					// Don't strech the bitmap height to avoid distortion
					// when using a horizontal slider, the width if using
					// a vertical slider
					HSkinnedSlider tempSlider = this as HSkinnedSlider;
					bool bHorizontal = tempSlider != null;
                    
					// We assume that the bitmap is always same size of smaller
					// than the control size
					int top = rc.Top;
					int left = rc.Left;
					if ( bHorizontal ) 
					{
						if ( rc.Height > imageHeight)
						{
							top = rc.Top + (rc.Height - imageHeight)/2;
							imageWidth = rc.Width;
						}
					}
					else
					{
						if ( rc.Width > imageWidth)
						{
							left = rc.Left + (rc.Width - imageWidth)/2;
							imageHeight = rc.Height;
						}
					}

					// Draw background 
					g.FillRectangle(b, rc.Left, rc.Top, rc.Width, rc.Height);

					// We need to draw the background in chunks to avoid distorting the image corner
					// in case the image has rounded corner. We are assuming a corner area of 10 pixels
					// on both size, the rest will be the area we strech
					Image image = BackgroundImage;
					if ( bHorizontal )
					{
						// Draw start corner
						g.DrawImage(image, new Rectangle(left, top, 10, imageHeight), 0, 0, 10, imageHeight, GraphicsUnit.Pixel);
						// Draw middle part
						g.DrawImage(image, new Rectangle(left+10, top, rc.Width-20, imageHeight), 10, 0, image.Width-20, imageHeight, GraphicsUnit.Pixel);
						// Draw end corner
						g.DrawImage(image, new Rectangle(rc.Right-10, top, 10, imageHeight), image.Width-10, 0, 10, imageHeight, GraphicsUnit.Pixel);
					}
					else
					{
						g.DrawImage(image, new Rectangle(left, top, imageWidth, 10), 0, 0, imageWidth, 10, GraphicsUnit.Pixel);
						// Draw middle part
						g.DrawImage(image, new Rectangle(left, top+10, imageWidth, rc.Height-20), 0, 10, imageWidth, image.Height - 20, GraphicsUnit.Pixel);
						// Draw end corner
						g.DrawImage(image, new Rectangle(left, rc.Bottom-10, imageWidth, 10), 0, image.Height-10, imageWidth, 10, GraphicsUnit.Pixel);
					}
					
				}
			}
		}
		protected virtual void DrawTracker(Graphics g)
		{
		}
		protected virtual int GetValue(int position)
		{
			return 0;
		}
		protected virtual int GetPosition(int _value)
		{
			return 0;
		}

		protected virtual void ResizeSkinnedSlider()
		{
			// Let the base classes implement this functionality
		}
		#endregion

		#region Properties
		public int Value
		{
			set 
			{
				previousValue = _value;
				
				// Make sure we don't get out of bounds
				if ( value > max )
					_value = max;
				else if ( value < min )
					_value = min;
				else
					_value = value;

				// If value is actually changing
				if ( previousValue != value )
				{
					trackerPos = GetPosition(_value);
					Invalidate();
					FireValueChanged();
				}
			}
			get { return _value;}
		}

		public int PreviousValue
		{
			get { return previousValue;}
		}

		public ImageList TrackerImageList
		{
			set { trackerImageList = value; }
			get { return trackerImageList; }
		}

		public int Minimum
		{
			set { min = value; }
			get { return min; }
		}

		public int Maximum
		{
			set { max = value; }
			get { return max; }
		}
		public new Image BackgroundImage
		{
			set 
			{
				base.BackgroundImage = value;
				ResizeSkinnedSlider();
			}
			get { return base.BackgroundImage; }
		}
		#endregion

		#region Methods
		#endregion

		#region Implementation
		void FireValueChanged()
		{
			if ( ValueChanged != null )
				ValueChanged(this, EventArgs.Empty);
		}
       
		#endregion

	}

	[ToolboxItem(false)]
	public class HSkinnedSlider : UtilityLibrary.WinControls.SkinnedSlider
	{
		#region Class variables
		#endregion

		#region Constructors
		public HSkinnedSlider()
		{
			
		}

		public HSkinnedSlider(Bitmap backgroundImage, ImageList trackerImageList) 
			: base(backgroundImage, trackerImageList)
		{
		}
		#endregion

		#region Overrides
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			ResizeSkinnedSlider();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if ( e.Button != MouseButtons.Left) 
				return;

			// Process left button down
			Capture = true;
			// use property to set the new value
			// so that the event Value change can be fired 
			// if it needs to
			Rectangle rc = trackerRect;
			if ( !(rc.Contains(new Point(e.X, e.Y))) )
			{
				// Only update the value when the mouse hit outside
				// the tracker, otherwise we get the strange effect
				// of the tracker value jumping to a new value when
				// we just want to start dragging the tracker
				Value = GetValue(e.X);
				trackerPos = e.X;
			}
			else
			{
				// If we hit the tracker, keep track of the offset
				// from the mouse hit to the middle of the tracker position
				int trackerWidth = 0;
				if ( trackerImageList != null )
					trackerWidth = trackerImageList.ImageSize.Width;
				int middlePos = rc.Left + trackerWidth/2;
				offset = middlePos - e.X;
			}
			drawState = DrawState.Pressed;
			Invalidate();
		}
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			bool invalidate = false;
			Rectangle tracker = trackerRect;
			if ( !Capture )
			{
				if ( tracker.Contains(new Point(e.X, e.Y) ) )
				{
					drawState = DrawState.Hot;
				}
				else
				{
					drawState = DrawState.Normal;
				}
				invalidate = true;
			}
                        
			if ( e.Button != MouseButtons.Left) 
			{
				if ( invalidate )
					Invalidate();
				return;
			}
		
			// Process left button down
			if ( Capture )
			{
				Rectangle rc = ClientRectangle;
				int trackerWidth = 0;
				if ( trackerImageList != null )
					trackerWidth = trackerImageList.ImageSize.Width;
				if ( e.X <= rc.Left + trackerWidth/2 ) offset = 0;
				if ( e.X >= rc.Right - trackerWidth/2 ) offset = 0;

				Value = GetValue(e.X + offset);
				trackerPos = e.X + offset;
				invalidate = true;
			}
            
			if ( invalidate )
				Invalidate();

		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if ( e.Button != MouseButtons.Left) 
				return;

			Rectangle rc = ClientRectangle;
			int trackerWidth = 0;
			if ( trackerImageList != null )
				trackerWidth = trackerImageList.ImageSize.Width;
			if ( e.X <= rc.Left + trackerWidth/2 ) offset = 0;
			if ( e.X >= rc.Right - trackerWidth/2 ) offset = 0;
			
			// Process left button down
			Capture = false;
			Value = GetValue(e.X + offset);
			trackerPos = e.X + offset;
			drawState = DrawState.Normal;
			Invalidate();
		}

		protected override void DrawTracker(Graphics g)
		{
			Rectangle rc = ClientRectangle;
					
			// If we have the needed image
			if ( trackerImageList != null &&  trackerImageList.Images.Count > (int)drawState )
			{
				int trackerWidth = trackerImageList.ImageSize.Width;
				int trackerHeight = trackerImageList.ImageSize.Height;
				int x = trackerPos;
				if ( x + trackerWidth/2 > rc.Width - 1 )
				{
					// Divide and multiply by 2 to eliminate rounding error
					x = rc.Right - (trackerWidth/2*2) - 1;
				}
				else if ( x - trackerWidth/2 < 0 )
					x = 0;
				else
					x -= trackerWidth/2;
				
				Point pt = new Point(x, rc.Top + (rc.Height-trackerHeight)/2);
				trackerRect = new Rectangle(pt.X, pt.Y, trackerWidth, trackerHeight);
				g.DrawImage(trackerImageList.Images[(int)drawState], trackerRect);
			}
		}

		protected override int GetValue(int position)
		{
			int trackerWidth = 0;
			if ( trackerImageList != null )
				trackerWidth = trackerImageList.ImageSize.Width;
			
			if ( position > ClientRectangle.Right-trackerWidth/2)
				position = ClientRectangle.Right-trackerWidth/2;
			else if ( position < ClientRectangle.Left+trackerWidth/2 )
				position = ClientRectangle.Left+trackerWidth/2;
						
			return (position-trackerWidth/2)*(max-min)/(ClientRectangle.Width-trackerWidth);
		}

		protected override int GetPosition(int _value)
		{
			int trackerWidth = 0;
			if ( trackerImageList != null )
				trackerWidth = trackerImageList.ImageSize.Width;
			return _value*(ClientRectangle.Width-trackerWidth)/(max-min) + trackerWidth/2;
		}
		protected override void ResizeSkinnedSlider()
		{
			// Size control to be the size size as 
			// the background bitmap so that it draws as it were transparent
			Image bm = BackgroundImage;
			if ( bm != null )
			{
				Rectangle rc = Bounds;
				Bounds = new Rectangle(rc.Left, rc.Top, rc.Width, bm.Height);
			}
		}
		#endregion

		#region Implementation
		#endregion

	}

	#region DrawState
	public enum DrawState
	{
		Normal,
		Hot,
		Pressed,
		Disable
	}
	#endregion

	#region ScrollBarEvent
	public enum ScrollBarEvent
	{
		LineUp,
		LineDown,
		PageUp,
		PageDown,
		ThumbUp,
		ThumbDown
	}

	#endregion

	#region ScrollBarHit
	public enum ScrollBarHit
	{
		UpArrow,
		DownArrow,
		PageUp,
		PageDown,
		Thumb,
		LeftArrow,
		RightArrow,
		PageLeft,
		PageRight,
		None
	}
	#endregion

	#region Orientation
	public enum Orientation
	{
		Vertical,
		Horizontal
	}
	#endregion

}
