using System;
using System.IO;

namespace Media_Player
{
	//This class represents any sound file type supported by MCI.
	//This class should be able to handle at least WAVE and MIDI on any system. Playing MP3s and other formats is also available on most systems.
	public class SoundFile : MediaFile {
		
		// Initializes a new SoundFile object.
		//The sound file to open.

		public SoundFile(string file) : base(file)
        {
		if(File!="cdaudio")	TimeFormat = "ms";		// use milliseconds
		}
       
		// Specifies the MCI string that should be used when opening the sound file.
		//An MCI string that should be used when opening the sound file.
		protected override string GetOpenString() {
            if (File == "cdaudio")
                return "open cdaudio";
            else
			return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias;
		}
	}
}
