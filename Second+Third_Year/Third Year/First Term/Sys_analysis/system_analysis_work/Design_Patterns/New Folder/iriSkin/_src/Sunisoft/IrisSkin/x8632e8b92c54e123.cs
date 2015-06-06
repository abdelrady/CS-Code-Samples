//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Runtime.InteropServices;
			using System.Text;
			
			
		#endregion
		
	[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	internal struct x8632e8b92c54e123
	
	{
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 0040)]
		public byte[] xd6c4260cb4131eb3;
		public byte x1b809103b90e9c4f;
		public uint xcb1c51bccf5db2d5;
		public uint xd95e52224405bb92;
		public uint x4f6686d624d5dfe1;
		
		#region Properties
		
			public xab0f0a5b63c83169 x3146d638ec378671
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 2
					.locals (System.Byte V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::Byte x1b809103b90e9c4f
					L_0006: stloc.0 
					L_0007: ldloc.0 
					L_0008: switch (L_001d, L_001f, L_0021, L_0023)
					L_001d: ldc.i4.0 
					L_001e: ret 
					L_001f: ldc.i4.1 
					L_0020: ret 
					L_0021: ldc.i4.2 
					L_0022: ret 
					L_0023: ldc.i4.3 
					L_0024: ret 
				*/
				
				{
					switch (this.x1b809103b90e9c4f)
					{
						case byte.MinValue:
						
						{
								return xab0f0a5b63c83169.xb8a774e0111d0fbe;
						}
						case 1:
						
						{
								return xab0f0a5b63c83169.x53e1aac0092bbcc1;
						}
						case 2:
						
						{
								return xab0f0a5b63c83169.x5facb5daef2aaefa;
						}
						case 3:
						
						{
								return xab0f0a5b63c83169.x0ca6ca9a928135fe;
						}
					}
					return xab0f0a5b63c83169.xb8a774e0111d0fbe;
				}
			}
			
			
			public string xb66f90d7e750b49e
			
			{
				get
				
				/*
					// Code Size: 39 Bytes
					.maxstack 5
					.locals (System.Char[] V_0)
					L_0000: call System.Text.Encoding::System.Text.Encoding get_Default()
					L_0005: ldarg.0 
					L_0006: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::Byte[] xd6c4260cb4131eb3
					L_000b: ldc.i4.0 
					L_000c: ldarg.0 
					L_000d: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::Byte[] xd6c4260cb4131eb3
					L_0012: ldlen 
					L_0013: conv.i4 
					L_0014: callvirt System.Text.Encoding::System.String GetString(Byte[], Int32, Int32)
					L_0019: ldc.i4.1 
					L_001a: newarr System.Char
					L_001f: stloc.0 
					L_0020: ldloc.0 
					L_0021: callvirt System.String::System.String TrimEnd(Char[])
					L_0026: ret 
				*/
				
				{
					return Encoding.Default.GetString (this.xd6c4260cb4131eb3, 0, this.xd6c4260cb4131eb3.Length).TrimEnd (new char[1]);
				}
			}
			
		#endregion
	}
	
}

