
using System;

namespace Media_Player
{
	
	// The exception that is thrown when an error occurs while opening, playing or modifying a media file.
	
	public class MediaException : Exception {
		
		public MediaException(string Message) : base(Message) {}
		
		public MediaException() : base("An error occured while accessing the media file.") {}
		
		public override string ToString() {
			return "MediaException: " + Message + " " + StackTrace;
		}
	}
}