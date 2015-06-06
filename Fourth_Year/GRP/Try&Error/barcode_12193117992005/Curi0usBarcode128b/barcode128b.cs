using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Reflection;



namespace barcode128b
{
	/// <summary>
	/// Summary description for barcode128b.
	/// </summary>
	public class barcode128b
	{
		private static Bitmap bmp;
		private static Graphics g;
		private static Pen pBlack;
		private static Pen pWhite;
		private static int barX;

		/// <summary>
		/// To save to database: catch stream in array of bytes:
		/// Byte[] arrImage = barcode128b.CreateBarcode128b("code128b").GetBuffer();	
		/// </summary>
		/// <param name="input">input string</param>
		/// <returns>Memory stream</returns>
		public static MemoryStream CreateBarcode128b(string input)
		{			
			//get barcode128b specficiations
            string validInput = " !" + Chr(34) + @"#$%&()**+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~" + Chr(0) + Chr(1) + Chr(2) + Chr(3) + Chr(4) + Chr(5) + Chr(6) + Chr(7) + Chr(8) + Chr(9) + Chr(10) + Chr(255);			
			Assembly assembly = Assembly.GetExecutingAssembly();
			string[] barSpacePattern = new string[107];
			StreamReader sr = new StreamReader(assembly.GetManifestResourceStream("barcode128b.barcode128b.txt"));
			
			for (int i = 0; i < 107; i++)
			{
				barSpacePattern[i] = sr.ReadLine().Replace(" ","");
			}
            			
			//check digit
			int checkDigit = 104;			
			for(int i = 0; i <= input.Length - 1; i++)
			{
				string currentChar = input.Substring(i,1);
				int currentCharValue = validInput.IndexOf(currentChar);
				checkDigit += ((i+1) * currentCharValue);
			}            
			checkDigit = (int)SqlInt32.Mod(checkDigit, 103);

			//make code with start/stop chars and checksum
			input = Chr(9) + input + validInput.Substring(checkDigit,1) + Chr(255);

			// make empty image	
			int bitmapLength = ((input.Length - 1) * 11) + 13;
			//MessageBox.Show("bitmaplength = " + bitmapLength);
			bmp = new Bitmap(bitmapLength, 50);	 
			g = Graphics.FromImage(bmp);

			//pen
			pBlack = new Pen(Color.Black, 1);
			pWhite = new Pen(Color.White, 1);
			barX = 0;

			for(int i = 0; i <= input.Length - 1; i++)
			{
					string currentChar = input.Substring(i,1);
					int currentPos = validInput.IndexOf(currentChar);
					
					bool bar = true;
					//MessageBox.Show("value = " + currentPos + "    -    " + "pattern = " + barSpacePattern[currentPos]);
					foreach(char character in barSpacePattern[currentPos])
					{
						Draw(Convert.ToInt32(character.ToString()), bar);
						bar = !bar;
					}			
			}
			//MessageBox.Show("positions written = " + barX);

			//save image to memoryStream
			MemoryStream ms = new MemoryStream();
			bmp.Save(ms, ImageFormat.Bmp);
			g.Dispose();
			bmp.Dispose();
			return ms;
		}		

		private	static Char Chr(int i)
		{
			//Return the character of the given character value
			return Convert.ToChar(i);
		}

		private static void Draw(int bars, bool bar)
		{
			for (int i = bars; i > 0; i--)
			{
				if (bar)
				{
					//draw bar
					g.DrawLine(pBlack, barX, 0, barX, 50);
				}
				else
				{
					//draw space
					g.DrawLine(pWhite, barX, 0, barX, 50);
				}
				barX++;
			}
		}

		public static string GetVersion()
		{
			// Get assembly info
			Assembly assembly = Assembly.GetAssembly(typeof(barcode128b));
			Object[] obj = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute),false);
			AssemblyTitleAttribute assemblyTitle = (AssemblyTitleAttribute)obj[0];
			obj = assembly.GetCustomAttributes(typeof(AssemblyConfigurationAttribute),false);
			AssemblyConfigurationAttribute assemblyConfiguration = (AssemblyConfigurationAttribute)obj[0];
			obj = assembly.GetCustomAttributes(typeof(AssemblyVersionAttribute),false);
			AssemblyName assemblyName = assembly.GetName();
			string version = assemblyTitle.Title + " ; " + assemblyConfiguration.Configuration + " ; " + assemblyName.Version;
			return version;
		}

	}
}
