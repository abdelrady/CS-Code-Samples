using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Media_Player
{
	// Defines the different states a media file can be in.
	public enum StatusInfo 
    {
		//The media file is playing.
		Playing,
		//The media file is paused.
		Paused,
		//The media file is stopped.
		Stopped,
		//The media file status is unknown.
		Unknown
	}
    public enum channels
    {
        None,
        Left,
        Right,
        Both
    }
	// An abstract base class that defines methods that should be available for any MCI file type.

	public abstract class MediaFile : IDisposable {

		// The mciSendString function sends a command string to an MCI device. The device that the command is sent to is specified in the command string.
		/// </summary>
		/// <param name="lpstrCommand">Address of a null-terminated string that specifies an MCI command string.</param>
		/// <param name="lpstrReturnString">Address of a buffer that receives return information. If no return information is needed, this parameter can be null (Nothing in VB.NET).</param>
		/// <param name="uReturnLength">Size, in characters, of the return buffer specified by the lpszReturnString parameter.</param>
		/// <param name="hwndCallback">Handle of a callback window if the notify flag was specified in the command string.</param>
		/// <returns>Returns zero if successful or an error otherwise. The low-order word of the returned doubleword value contains the error return value. If the error is device-specific, the high-order word of the return value is the driver identifier; otherwise, the high-order word is zero.<br>To retrieve a text description of mciSendString return values, pass the return value to the mciGetErrorString function.</br></returns>
		[ DllImport( "winmm.dll", EntryPoint="mciSendStringA", CharSet=CharSet.Ansi )]
		public static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
		
		/// The mciGetErrorString function retrieves a string that describes the specified MCI error code.
		/// </summary>
		/// <param name="dwError">Error code returned by the mciSendCommand or mciSendString function.</param>
		/// <param name="lpstrBuffer">Address of a buffer that receives a null-terminated string describing the specified error.</param>
		/// <param name="uLength">Length of the buffer, in characters, pointed to by the lpszErrorText parameter.</param>
		/// <returns>Returns TRUE if successful or FALSE if the error code is not known.</returns>
		[ DllImport( "winmm.dll", EntryPoint="mciGetErrorStringA", CharSet=CharSet.Ansi )]
		protected static extern int mciGetErrorString(int dwError, StringBuilder lpstrBuffer, int uLength);
		
		/// The GetShortPathName function obtains the short path form of a specified input path.
		/// </summary>
		/// <param name="lpszLongPath">Pointer to a null-terminated path string. The function obtains the short form of this path.</param>
		/// <param name="lpszShortPath">Pointer to a buffer to receive the null-terminated short form of the path specified by lpszLongPath.</param>
		/// <param name="cchBuffer">Specifies the size, in characters, of the buffer pointed to by lpszShortPath.</param>
		/// <returns>If the function succeeds, the return value is the length, in characters, of the string copied to lpszShortPath, not including the terminating null character.<br>If the function fails due to the lpszShortPath buffer being too small to contain the short path string, the return value is the size, in characters, of the short path string. You need to call the function with a short path buffer that is at least as large as the short path string.</br><br>If the function fails for any other reason, the return value is zero. To get extended error information, call GetLastError.</br></returns>
		[ DllImport( "kernel32.dll", EntryPoint="GetShortPathNameA", CharSet=CharSet.Ansi )]
		protected static extern int GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, int cchBuffer);
   
        //Initializes a new instance of the MediaFile class.
		public MediaFile(string file) : this(file, null) {}
        public MediaFile() { }
		//Initializes a new instance of the MediaFile class.
		public MediaFile(string file, IWin32Window owner) 
        {
			if (file == null)
				throw new ArgumentNullException("Parameter 'file' cannot be null!");
            if (file != "cdaudio")
            {
                if (!System.IO.File.Exists(file))
                    throw new FileNotFoundException();
            }
			Owner = owner;
			Open(file);
		}
		
		// Converts a long path into a short path.
		protected string GetShortPath(string file)
        {
			StringBuilder buffer = new StringBuilder(file.Length + 1);
			int ret = GetShortPathName(file, buffer, buffer.Capacity);
			if (ret == 0)		// Error
				return "";
			else				// Success
				return buffer.ToString();
		}
		
		/// Gets the filename of the media file.
		public string Filename 
        {
			get{
				return m_File;
			}
		}
		
		// Specifies the MCI string that should be used when opening the media file.
	
		//An MCI string that should be used when opening the media file.
		//Since this string depends on the media type, this method must be overridden in subclasses.
		protected abstract string GetOpenString();
		
		/// Opens the specified media file and creates an Alias for it.
		protected void Open(string file) 
        {
            if (file != "cdaudio")
            {
                m_File = GetShortPath(file);
                Alias = Guid.NewGuid().ToString("N");
            }
            else
                m_File = "cdaudio";
			int ret;
			ret = mciSendString(GetOpenString(), null, 0, IntPtr.Zero);
			/*if (ret != 0)
				throw new MediaException(GetMciError(ret));*/
		}
		
		// Converts an MCI error code into a string.
		protected string GetMciError(int errorCode)
        {
			StringBuilder buffer = new StringBuilder(255);
			if (mciGetErrorString(errorCode, buffer, buffer.Capacity) == 0)
				return "";
			return buffer.ToString();
		}
		// Disposes of the unmanaged resources (other than memory) used by the MediaFile object.
		public void Dispose()
        {
			if (Disposed)
				return;
			mciSendString("CLOSE " + Alias, null, 0, IntPtr.Zero);
			m_Disposed = true;
		}
		

		// Starts playing a file.
		public void Play() 
        {
			Play(0);
		}

		// Starts playing a file.
		public void Play(int from)
        {
			Play(from,Length-from);
		}

        // Specifies the MCI string that should be used when playing the media file.
        protected string GetPlayString(int from, int length)
        {
            string ret = "PLAY " + Alias + " FROM " + from.ToString() + " TO "
                + (from + length).ToString();
            if (Repeat)
                ret += " REPEAT";
            return ret;
        }
		// Starts playing a file.
		public void Play(int from, int length)
        {
			if (from < 0 || length > Length || Length < 0 || from + length > Length)
				throw new ArgumentException("Invalid parameter(s) specified.");
			int ret = mciSendString(GetPlayString(from, length), null, 0, IntPtr.Zero);
			/*if (ret != 0)
				throw new MediaException(GetMciError(ret));*/
		}

		// Stops playing a file and rewinds.
		public void Stop()
        {
			int ret = mciSendString("STOP " + Alias, null, 0, IntPtr.Zero);
			if (ret != 0)
				throw new MediaException(GetMciError(ret));
		}
		
		public bool Disposed 
        {
			get
            {
				return m_Disposed;
			}
		}

		// Gets or sets the paused state of the media file.
		//A boolean specifying whether the media file is paused or not.
		public bool Paused 
        {
			get 
            {
				return Status == StatusInfo.Paused;
			}
			set
            {
				if (value != Paused) {
					int ret;
					if (value) {			// PAUSE
						ret = mciSendString("PAUSE " + Alias, null, 0, IntPtr.Zero);
						if (ret != 0)
							throw new MediaException(GetMciError(ret));
					} else {				// RESUME
						ret = mciSendString("RESUME " + Alias, null, 0, IntPtr.Zero);
						if (ret != 0)
							throw new MediaException(GetMciError(ret));
					}
				}
			}
		}

		// Gets the status of the media file.
		public StatusInfo Status 
        {
			get{
				StringBuilder buffer = new StringBuilder(255);
				int ret = mciSendString("STATUS " + Alias + " MODE", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0) 
                {
					return StatusInfo.Unknown;
				} 
                else 
                {
					switch (buffer.ToString().ToLower())
                    {
						case "playing":
							return StatusInfo.Playing;
						case "paused":
							return StatusInfo.Paused;
						case "stopped":
							return StatusInfo.Stopped;
						default:
							return StatusInfo.Unknown;
					}
				}
			}
		}
        //Gets or Sets the channel to use
        public channels Mute
        {
            get
            {
                return pMute;
            }
            set
            {
                pMute = value;
                DoMute();
            }
        }
        private void DoMute()
        {
            int ret=0;
            switch (pMute)
            {
                case channels.None:
                    ret = mciSendString("set " + Alias + " audio all on", null, 0, IntPtr.Zero);
                    break;
                case channels.Left:
                    ret = mciSendString("set " + Alias + " audio left off", null, 0, IntPtr.Zero);
                    ret = mciSendString("set " + Alias + " audio right  on", null, 0, IntPtr.Zero);
                    break;
                case channels.Right:
                    ret = mciSendString("set " + Alias + " audio right off", null, 0, IntPtr.Zero);
                    ret = mciSendString("set " + Alias + " audio left on", null, 0, IntPtr.Zero);
                   break;
                case channels.Both:
                    ret = mciSendString("set " + Alias + " audio all off", null, 0, IntPtr.Zero);
                    break;
                  
            }
           /* if (ret != 0)
                throw new MediaException(GetMciError(ret));*/
        }
        //Get or set Balance
        public int Balance
        {
            get
            {
                return pBalance;
            }
            set
            {
                if (value >= 0 && value <= 1000 && value != pBalance)
                    pBalance = value;
                DoBalance();
            }
        }
        private void DoBalance()
        {
            int ret = 0;
            ret = mciSendString("setaudio " + Alias + " left volume to " + Convert.ToString(1000 - pBalance), null, 0, IntPtr.Zero);
            ret=mciSendString("setaudio " + Alias + " right volume to " + Convert.ToString(pBalance), null, 0, IntPtr.Zero);
            /*if (ret != 0)
                throw new MediaException(GetMciError(ret));*/
        }
        //get or set speed
        public int Speed
        {
            get
            {
                return pSpeed;
            }
            set
            {
                if (value >= 0 && value <= 2000 && value != pSpeed)
                    pSpeed = value;
                DoSpeed();
            }
        }
        private void DoSpeed()
        {
            
           int ret = mciSendString("set " + Alias + " speed " + Convert.ToString(pSpeed), null, 0, IntPtr.Zero);
            /*if (ret != 0)
                throw new MediaException(GetMciError(ret));*/
        }
        /// Get/Set Treble Volume Factor
        /// </summary>
        public int Treble
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString("setaudio"+Alias+" treble to "+value, null, 0, IntPtr.Zero);
            }
        }
		// Gets or sets the time format to use.
		protected string TimeFormat 
        {
			get {
				return m_TimeFormat;
			}
			set {
				if (value == null)
					throw new ArgumentNullException();
				int ret = mciSendString("SET " + Alias + " TIME FORMAT " + value, null, 0, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
				m_TimeFormat = value;
			}
		}
       
     
        
		// Gets the length of the file.
		//The length is measured in milliseconds.
		public int Length {
			get
            {
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " LENGTH", buffer, buffer.Capacity, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
				return int.Parse(buffer.ToString());
			}
		}

		// Gets or sets the position in the media file.
		//The position is measured in milliseconds.
		public int Position 
        {
			get 
            {
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " POSITION", buffer, buffer.Capacity, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
				return int.Parse(buffer.ToString());
			}
			set 
            {
				bool playing = (this.Status == StatusInfo.Playing);
				int ret = mciSendString("SEEK " + Alias + " TO " + value.ToString(), null, 0, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
				if (playing) 
                {
					ret = mciSendString("SEEK " + Alias + " TO " + value.ToString(), null, 0, IntPtr.Zero);
                   if(ret==0) Play(value);
					/*if (ret != 0)
						throw new MediaException(GetMciError(ret));*/
				}
			}
		}

		// Gets or sets the volume of the sound of the media file.
		//An integer that specifies the volume of the sound of the media file.
		public int Volume 
        {
			get
            {
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " VOLUME", buffer, buffer.Capacity, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
				return int.Parse(buffer.ToString());
			}
			set
            {
				int ret = mciSendString("SETAUDIO " + Alias + " VOLUME TO " + value.ToString(), null, 0, IntPtr.Zero);
				/*if (ret != 0)
					throw new MediaException(GetMciError(ret));*/
			}
		}

		// Gets or sets the alias of the media file.
		// string that holds the alias of the media file.
		public string Alias {
			get
            {
				return m_Alias;
			}
			set
            {
				m_Alias = value;
			}
		}

		// Gets the full path of the media file.
		//A string that holds the full path of the media file.
		public string File 
        {
			get 
            {
				return m_File;
			}
		}

		// Gets or sets the owner window of this media file.
		//An instance of an IWin32Window object that's the parent of the media file.
		protected IWin32Window Owner
        {
			get 
            {
				return m_Owner;
			}
			set {
				m_Owner = value;
			}
		}

		// Gets or sets whether the file should be repeated when it has reached the end.
		//A boolean that specifies whether the file should be repeated when it has reached the end.
		public bool Repeat 
        {
			get 
            {
				return m_Repeat;
			}
			set 
            {
				m_Repeat = value;
			}
		}
        //-----------------------------------------------------------------------------
        public void playCD()
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            int ret = mciSendString("play cdaudio", null, 0, IntPtr.Zero);
        }
        public void playFromTrackCD(int TrackN)
        {
            mciSendString("open cdaudio", null, 0, IntPtr.Zero);
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            int ret = mciSendString("play cdaudio from " + TrackN, null, 0, IntPtr.Zero);
        }
        public void playFromT_M_SCD(int T, int M, int S)
        {
            mciSendString("open cdaudio", null, 0, IntPtr.Zero);
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            int ret = mciSendString("play cdaudio from " +T+":"+M+":"+S+":"+"00", null, 0, IntPtr.Zero);
        }
        public void playFromAll(string value)
        {
            mciSendString("open cdaudio", null, 0, IntPtr.Zero);
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            int ret = mciSendString("play cdaudio from "+value, null, 0, IntPtr.Zero);
        }
        StringBuilder buffer2 = new StringBuilder(260);
        public String pauseCD()
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            mciSendString("status cdaudio position", buffer2, buffer2.Capacity, IntPtr.Zero);
            mciSendString("pause cdaudio", null, 0, IntPtr.Zero);
            return buffer2.ToString();
        }
        public string CurrentPositionCD()
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            mciSendString("status cdaudio position", buffer2, buffer2.Capacity, IntPtr.Zero);
            return buffer2.ToString();
        }
        public string positionCD()
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            mciSendString("status cdaudio position", buffer2, buffer2.Capacity, IntPtr.Zero);
            return buffer2.ToString();
        }
        public string lengthCD()
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            mciSendString("status cdaudio length  ", buffer2, buffer2.Capacity, IntPtr.Zero);
            return buffer2.ToString();
        }
        public string lengthTrackCD(string  TrackNo)
        {
            mciSendString("set cdaudio time format tmsf", null, 0, IntPtr.Zero);
            int ret = mciSendString("status cdaudio length track " + TrackNo, buffer2, buffer2.Capacity, IntPtr.Zero);
            return buffer2.ToString();
        }
        public void stopCD()
        {
            mciSendString("stop cdaudio", null, 0, IntPtr.Zero);
        }
        public void openCDdoor()
        {
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }
        public void closeCDdoor()
        {
            mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
        }
        public int trackNoCD()
        {
           int ret= mciSendString("status cdaudio number of tracks", buffer2, buffer2.Capacity, IntPtr.Zero);
        
            if(ret==0)
            {
                string strTrackNo = buffer2.ToString().Substring(0, 2);
            int intTrackNo = int.Parse(strTrackNo);
            return intTrackNo;
            }
            return 0;
        }
		// Destructs the MediaFile object by calling the Dispose method.
		~MediaFile() 
        {
			Dispose();
		}
		// private variables
		//Holds the value of the Owner property.
		private IWin32Window m_Owner;
		//Holds the value of the File property.
		private string m_File;
		//Holds the value of the Alias property.
		private string m_Alias;
		//Holds the value of the Disposed property.
		private bool m_Disposed;
		//Holds the value of the TimeFormat property.
		private string m_TimeFormat;
		//Holds the value of the Repeat property.
		private bool m_Repeat = false;
        //--
        private channels pMute = channels.None;
        //--
        private int pBalance = 500;
        //--
        private int pSpeed = 1000;
	}
}
