//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 25/12/2006 02:25:34 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace WindowsApplication1

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal abstract class Program
	
	{
		
		#region Methods
		
			[STAThreadAttribute()]
			private static void Main ()
			
			/*
				// Code Size: 22 Bytes
				.maxstack 8
				L_0000: call System.Windows.Forms.Application::Void EnableVisualStyles()
				L_0005: ldc.i4.0 
				L_0006: call System.Windows.Forms.Application::Void SetCompatibleTextRenderingDefault(Boolean)
				L_000b: newobj WindowsApplication1.Form1::Void .ctor()
				L_0010: call System.Windows.Forms.Application::Void Run(System.Windows.Forms.Form)
				L_0015: ret 
			*/
			
			
			{
				//Application.EnableVisualStyles ();
				//Application.SetCompatibleTextRenderingDefault (false);
				Application.Run (( new frm ()));
			}
			
		#endregion
	}
	
}

