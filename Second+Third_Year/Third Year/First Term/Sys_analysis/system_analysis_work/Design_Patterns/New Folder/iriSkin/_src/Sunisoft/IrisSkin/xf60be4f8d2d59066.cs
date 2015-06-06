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
		
	internal class xf60be4f8d2d59066
	
	{
		
		#region Constructors
		
			public xf60be4f8d2d59066 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			[DllImportAttribute("kernel32.DLL", EntryPoint = "FreeLibrary", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool FreeLibrary (int hModule);
			[DllImportAttribute("kernel32.DLL", EntryPoint = "GetCurrentThread", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetCurrentThread ();
			[DllImportAttribute("kernel32.DLL", EntryPoint = "GetCurrentThreadId", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint GetCurrentThreadId ();
			[DllImportAttribute("kernel32.DLL", EntryPoint = "GetLastError", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetLastError ();
			[DllImportAttribute("kernel32.DLL", EntryPoint = "LoadLibrary", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int LoadLibrary (string lpFileName);
		#endregion
	}
	
}

