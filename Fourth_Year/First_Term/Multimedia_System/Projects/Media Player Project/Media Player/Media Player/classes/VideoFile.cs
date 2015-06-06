using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Media_Player
{
	//This class represents any video file type supported by MCI.
	//This class should be able to handle at least AVI on any system. Playing MPEG, DivX and other formats is also available on most systems.
	public class VideoFile : MediaFile {
		
		// Initializes a new VideoFile object.
		public VideoFile(string file) : this(file, null) {}
		// Initializes a new VideoFile object.
		//The video file to open.
		public VideoFile(string file, IWin32Window owner) : base(file, owner)
        {
			TimeFormat = "ms";		// use milliseconds
		}
        public void FullScreen()
        {
            mciSendString("play " + Alias + " FullScreen ", null, 0, IntPtr.Zero);
        }
		// Specifies the MCI string that should be used when opening the video file.
		//An MCI string that should be used when opening the video file.
		protected override string GetOpenString() 
        {
			if (Owner == null)
				return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias;
			else
				return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias + " PARENT " + Owner.Handle.ToInt64().ToString() + " STYLE child";
		}

		// Gets or sets the width of the client area on the destination window.
		//An integer that specifies the width of the destination window.
		public int Width 
        {
			get 
            {
				return OutputRect.Width;
			}
			set 
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, value, output.Height);
			}
		}

		// Gets or sets the height of the client area on the destination window.
		//An integer that specifies the height of the destination window.
		public int Height
        {
			get 
            {
				return OutputRect.Height;
			}
			set
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, output.Width, value);
			}
		}

		// Gets or sets the left position of the client area on the destination window.
		//An integer that specifies the left position on the destination window.
		
		public int Left 
        {
			get 
            {
				return OutputRect.X;
			}
			set 
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(value, output.Y, output.Width, output.Height);
			}
		}

		// Gets or sets the top position of the client area on the destination window.
		//An integer that specifies the top position of the destination window.
		
		public int Top
        {
			get 
            {
				return OutputRect.Y;
			}
			set
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, value, output.Width, output.Height);
			}
		}

		// Gets or sets the width and the height of the client area on the destination window.
        //A Size instance that holds the width and height of the client area on the destination window.</value>
        public Size Size 
        {
			get 
            {
				Rectangle output = OutputRect;
				return new Size(OutputRect.Width, OutputRect.Height);
			}
			set 
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, value.Width, value.Height);
			}
		}

		// Gets or sets the left and top position of the client area on the destination window.
        //A Point instance that holds the left and top of the client area on the destination window.</value>
		public Point Location
        {
			get 
            {
				Rectangle output = OutputRect;
				return new Point(OutputRect.Left, OutputRect.Top);
			}
			set 
            {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(value.X, value.Y, output.Width, output.Height);
			}
		}

		// Gets or sets the left, top, width and height values of the client area on the destination window.
		//A Rectangle instance that holds the left, top, width and height values of the client area on the destination window.</value>
		public Rectangle OutputRect
        {
			get 
            {
				StringBuilder buffer = new StringBuilder(255);
				int ret = mciSendString("WHERE " + Alias + " DESTINATION", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				/*try {*/
					string [] parts = buffer.ToString().Split(' ');
					return new Rectangle(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]) - int.Parse(parts[0]), int.Parse(parts[3]) - int.Parse(parts[1]));
				/*} catch {
					throw new MediaException("Unrecognized MCI reply.");
				}*/
			}
			set 
            {
				int ret = mciSendString("PUT " + Alias + " WINDOW AT " + value.X.ToString() + " " + value.Y.ToString() + " " + (value.Width).ToString() + " " + (value.Height).ToString(), null, 0, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
			}
		}
	}
}
