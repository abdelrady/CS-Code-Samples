/*
* FileSystem class: filesystem utility class
*
* Authors:		R. LOPES
* Contributors:	R. LOPES
* Created:		14 November 2002
* Modified:		20 November 2002
*
* Version:		1.0
*/

using System;
using System.IO;

namespace abood.IO{
	/// <summary>
	/// FileSystem.
	/// </summary>
	public class FileSystem{
		// Copy directory structure recursively
		public static void copyDirectory(string Src,string Dst){
			String[] Files;

			if(Dst[Dst.Length-1]!=Path.DirectorySeparatorChar) Dst+=Path.DirectorySeparatorChar;
			if(!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
			Files=Directory.GetFileSystemEntries(Src,"*.txt");
			foreach(string Element in Files){
				// Sub directories
				if(Directory.Exists(Element)) copyDirectory(Element,Dst+Path.GetFileName(Element));
				// Files in directory
				else File.Copy(Element,Dst+Path.GetFileName(Element),true);
				}
			}

		}
	}
