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
			
			
		#endregion
		
	[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	internal struct xe24cbd369cdd075a
	
	{
		public byte xf1d229e72cb3c738;
		public byte xc1917e8d03fa28b7;
		public byte xd7f69a95873c51b8;
		public byte xcb734f8c3043b335;
		
		#region Constructors
		
			public xe24cbd369cdd075a (byte L1, byte L2, byte L3, byte L4)
			/*
				// Code Size: 30 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: stfld Sunisoft.IrisSkin.xe24cbd369cdd075a::Byte xf1d229e72cb3c738
				L_0007: ldarg.0 
				L_0008: ldarg.2 
				L_0009: stfld Sunisoft.IrisSkin.xe24cbd369cdd075a::Byte xc1917e8d03fa28b7
				L_000e: ldarg.0 
				L_000f: ldarg.3 
				L_0010: stfld Sunisoft.IrisSkin.xe24cbd369cdd075a::Byte xd7f69a95873c51b8
				L_0015: ldarg.0 
				L_0016: ldarg.s L4
				L_0018: stfld Sunisoft.IrisSkin.xe24cbd369cdd075a::Byte xcb734f8c3043b335
				L_001d: ret 
			*/
		#endregion
		
		#region Methods
		
			public static xe24cbd369cdd075a x544f68ae4f70de0e (int x37cf7043760b312e)
			
			/*
				// Code Size: 58 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4 255
				L_0006: and 
				L_0007: conv.u1 
				L_0008: ldarg.0 
				L_0009: ldc.i4.8 
				L_000a: call Sunisoft.IrisSkin.xe24cbd369cdd075a::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_000f: ldc.i4 255
				L_0014: and 
				L_0015: conv.u1 
				L_0016: ldarg.0 
				L_0017: ldc.i4.s 16
				L_0019: call Sunisoft.IrisSkin.xe24cbd369cdd075a::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_001e: ldc.i4 255
				L_0023: and 
				L_0024: conv.u1 
				L_0025: ldarg.0 
				L_0026: ldc.i4.s 24
				L_0028: call Sunisoft.IrisSkin.xe24cbd369cdd075a::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_002d: ldc.i4 255
				L_0032: and 
				L_0033: conv.u1 
				L_0034: newobj Sunisoft.IrisSkin.xe24cbd369cdd075a::Void .ctor(Byte, Byte, Byte, Byte)
				L_0039: ret 
			*/
			
			
			{
				return new xe24cbd369cdd075a (((byte) (x37cf7043760b312e & 255)), ((byte) (xe24cbd369cdd075a.xa52147d0d9c2c73c (x37cf7043760b312e, 8) & 255)), ((byte) (xe24cbd369cdd075a.xa52147d0d9c2c73c (x37cf7043760b312e, 16) & 255)), ((byte) (xe24cbd369cdd075a.xa52147d0d9c2c73c (x37cf7043760b312e, 24) & 255)));
			}
			
			public static int xa52147d0d9c2c73c (int x7b28e8a789372508, int x1148d0e8cc982c04)
			
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: ble.s L_000b
				L_0004: ldarg.0 
				L_0005: ldarg.1 
				L_0006: ldc.i4.s 31
				L_0008: and 
				L_0009: shr 
				L_000a: ret 
				L_000b: ldarg.0 
				L_000c: ldarg.1 
				L_000d: ldc.i4.s 31
				L_000f: and 
				L_0010: shr.un 
				L_0011: ret 
			*/
			
			
			{
				if (x7b28e8a789372508 <= 0)
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
				else
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
			}
			
		#endregion
	}
	
}

